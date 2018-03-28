#r "packages/build/FAKE/tools/FakeLib.dll"
#r "System.IO.Compression.FileSystem"
#load "paket-files/build/fable-compiler/fake-helpers/Fable.FakeHelpers.fs"

open Fake
open Fable.FakeHelpers

let packages = [
    // Node is automatically published by CI
    // "Node/Fable.Import.Node"
    "Browser/Fable.Import.Browser"
    "Express/Fable.Import.Express"
    "Pg/Fable.Import.Pg"
    "SocketIo/Fable.Import.SocketIo"
    "Uws/Fable.Import.Uws"
    "Mocha/Fable.Import.Mocha"
    "VSCode/Fable.Import.VSCode"
    "Electron/Fable.Import.Electron"
    "Pixi/Fable.Import.Pixi"
    "PixiSound/Fable.Import.Pixi.Sound"
    "PixiParticles/Fable.Import.Pixi.Particles"
    "Animejs/Fable.Import.Animejs"
    "GeoJSON/Fable.Geojson"
    "Leaflet/Fable.Leaflet"
]

#if MONO
// prevent incorrect output encoding (e.g. https://github.com/fsharp/FAKE/issues/1196)
System.Console.OutputEncoding <- System.Text.Encoding.UTF8
#endif

let dotnetcliVersion = "2.1.4"
let mutable dotnetExePath = environVarOrDefault "DOTNET" "dotnet"

// Clean and install dotnet SDK
Target "Bootstrap" (fun () ->
    !! "**/bin" ++ "**/obj" |> CleanDirs
    dotnetExePath <- DotNetCli.InstallDotNetSDK dotnetcliVersion
)

Target "PublishPackages" (fun () ->
    packages
    |> List.map (fun p -> p + ".fsproj")
    |> publishPackages __SOURCE_DIRECTORY__ dotnetExePath
)

"Bootstrap"
==> "PublishPackages"

RunTargetOrDefault "Bootstrap"
