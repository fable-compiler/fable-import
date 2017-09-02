#r "packages/build/FAKE/tools/FakeLib.dll"
#r "System.IO.Compression.FileSystem"

open System
open System.IO
open System.Text.RegularExpressions
open System.Collections.Generic
open Fake
open Fake.AssemblyInfoFile
open Fake.Git
open Fake.ReleaseNotesHelper

let packages = [
    "Browser/Fable.Import.Browser"
    "Node/Fable.Import.Node"
    "Express/Fable.Import.Express"
    "Pg/Fable.Import.Pg"
    "SocketIo/Fable.Import.SocketIo"
    "Uws/Fable.Import.Uws"
    "Mocha/Fable.Import.Mocha"
    "VSCode/Fable.Import.VSCode"
    "Electron/Fable.Import.Electron"
]

#if MONO
// prevent incorrect output encoding (e.g. https://github.com/fsharp/FAKE/issues/1196)
System.Console.OutputEncoding <- System.Text.Encoding.UTF8
#endif

module Util =
    open System.Net

    let retryIfFails maxRetries f =
        let rec loop retriesRemaining =
            try
                f ()
            with _ when retriesRemaining > 0 ->
                loop (retriesRemaining - 1)
        loop maxRetries

    let (|RegexReplace|_|) =
        let cache = new Dictionary<string, Regex>()
        fun pattern (replacement: string) input ->
            let regex =
                match cache.TryGetValue(pattern) with
                | true, regex -> regex
                | false, _ ->
                    let regex = Regex pattern
                    cache.Add(pattern, regex)
                    regex
            let m = regex.Match(input)
            if m.Success
            then regex.Replace(input, replacement) |> Some
            else None

    let join pathParts =
        Path.Combine(Array.ofSeq pathParts)

    let run workingDir fileName args =
        printfn "CWD: %s" workingDir
        let fileName, args =
            if EnvironmentHelper.isUnix
            then fileName, args else "cmd", ("/C " + fileName + " " + args)
        let ok =
            execProcess (fun info ->
                info.FileName <- fileName
                info.WorkingDirectory <- workingDir
                info.Arguments <- args) TimeSpan.MaxValue
        if not ok then failwith (sprintf "'%s> %s %s' task failed" workingDir fileName args)

    let start workingDir fileName args =
        let p = new System.Diagnostics.Process()
        p.StartInfo.FileName <- fileName
        p.StartInfo.WorkingDirectory <- workingDir
        p.StartInfo.Arguments <- args
        p.Start() |> ignore
        p

    let runAndReturn workingDir fileName args =
        printfn "CWD: %s" workingDir
        let fileName, args =
            if EnvironmentHelper.isUnix
            then fileName, args else "cmd", ("/C " + args)
        ExecProcessAndReturnMessages (fun info ->
            info.FileName <- fileName
            info.WorkingDirectory <- workingDir
            info.Arguments <- args) TimeSpan.MaxValue
        |> fun p -> p.Messages |> String.concat "\n"

    let visitFile (visitor: string->string) (fileName : string) =
        File.ReadAllLines(fileName)
        |> Array.map (visitor)
        |> fun lines -> File.WriteAllLines(fileName, lines)

        // This code is supposed to prevent OutOfMemory exceptions but it outputs wrong BOM
        // use reader = new StreamReader(fileName, encoding)
        // let tempFileName = Path.GetTempFileName()
        // use writer = new StreamWriter(tempFileName, false, encoding)
        // while not reader.EndOfStream do
        //     reader.ReadLine() |> visitor |> writer.WriteLine
        // reader.Close()
        // writer.Close()
        // File.Delete(fileName)
        // File.Move(tempFileName, fileName)

    let replaceLines (replacer: string->Match->string option) (reg: Regex) (fileName: string) =
        fileName |> visitFile (fun line ->
            let m = reg.Match(line)
            if not m.Success
            then line
            else
                match replacer line m with
                | None -> line
                | Some newLine -> newLine)

    let rec findFileUpwards fileName dir =
        let fullPath = dir </> fileName
        if File.Exists(fullPath)
        then fullPath
        else
            let parent = Directory.GetParent(dir)
            if isNull parent then
                failwithf "Couldn't find %s directory" fileName
            findFileUpwards fileName parent.FullName

let gitOwner = "fable-compiler"
let gitHome = "https://github.com/" + gitOwner

let dotnetcliVersion = "2.0.0"
let mutable dotnetExePath = environVarOrDefault "DOTNET" "dotnet"

// Targets
let installDotnetSdk () =
    dotnetExePath <- DotNetCli.InstallDotNetSDK dotnetcliVersion

let clean () =
    !! "**/bin" |> CleanDirs
    // Don't delete whole obj folder to leave Paket cache
    !! "**/obj/*.nuspec" ++ "**/obj/*.nuspec" |> DeleteFiles

let needsPublishing (versionRegex: Regex) (releaseNotes: ReleaseNotes) projFile =
    printfn "Project: %s" projFile
    if releaseNotes.NugetVersion.ToUpper().EndsWith("NEXT")
    then
        printfn "Version in Release Notes ends with NEXT, don't publish yet."
        false
    else
        File.ReadLines(projFile)
        |> Seq.tryPick (fun line ->
            let m = versionRegex.Match(line)
            if m.Success then Some m else None)
        |> function
            | None -> failwith "Couldn't find version in project file"
            | Some m ->
                let sameVersion = m.Groups.[1].Value = releaseNotes.NugetVersion
                if sameVersion then
                    printfn "Already version %s, no need to publish." releaseNotes.NugetVersion
                not sameVersion

let pushNuget (releaseNotes: ReleaseNotes) (projFiles: string list) =
    let versionRegex = Regex("<Version>(.*?)</Version>", RegexOptions.IgnoreCase)
    projFiles
    |> Seq.map (fun projFile -> __SOURCE_DIRECTORY__ </> projFile)
    |> Seq.filter (needsPublishing versionRegex releaseNotes)
    |> Seq.iter (fun projFile ->
        let projDir = Path.GetDirectoryName(projFile)
        let nugetKey =
            match environVarOrNone "NUGET_KEY" with
            | Some nugetKey -> nugetKey
            | None -> failwith "The Nuget API key must be set in a NUGET_KEY environmental variable"
        // Restore dependencies here so they're updated to latest project versions
        Util.run projDir dotnetExePath "restore"
        // Update the project file
        (versionRegex, projFile) ||> Util.replaceLines (fun line _ ->
            versionRegex.Replace(line, "<Version>"+releaseNotes.NugetVersion+"</Version>") |> Some)
        try
            Util.run projDir dotnetExePath "pack -c Release"
            Paket.Push (fun p ->
                { p with
                    ApiKey = nugetKey
                    WorkingDir = projDir </> "bin" </> "Release" })
        with _ ->
            Path.GetFileNameWithoutExtension(projFile)
            |> printfn "There's been an error when pushing project: %s"
            printfn "Please revert the version change in .fsproj"
            reraise()
    )

Target "Clean" clean

Target "Build" (fun () ->
    installDotnetSdk ()
    clean ()
    for pkg in packages do
        let projFile = __SOURCE_DIRECTORY__ </> (pkg + ".fsproj")
        let projDir = Path.GetDirectoryName(projFile)
        Util.run projDir dotnetExePath "restore"
        Util.run projDir dotnetExePath "build"
)

let publishPackages () =
    installDotnetSdk ()
    clean ()
    for pkg in packages do
        let projFile = __SOURCE_DIRECTORY__ </> (pkg + ".fsproj")
        let projDir = Path.GetDirectoryName(projFile)
        let release =
            Util.findFileUpwards "RELEASE_NOTES.md" projDir
            |> ReleaseNotesHelper.LoadReleaseNotes
        pushNuget release [projFile]

Target "PublishPackages" publishPackages

// Start build
RunTargetOrDefault "Build"
