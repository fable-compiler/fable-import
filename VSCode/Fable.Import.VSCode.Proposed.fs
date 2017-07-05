namespace Fable.Import

open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.vscode

module vscodeProposed =
    type ProblemPattern =
        abstract regexp: Regex with get, set
        abstract file: float option with get, set
        abstract location: float option with get, set
        abstract line: float option with get, set
        abstract character: float option with get, set
        abstract endLine: float option with get, set
        abstract endCharacter: float option with get, set
        abstract severity: float option with get, set
        abstract code: float option with get, set
        abstract message: float option with get, set
        abstract loop: bool option with get, set

    and MultiLineProblemPattern =
        ResizeArray<ProblemPattern>

    and FileLocationKind =
        | Auto = 1
        | Relative = 2
        | Absolute = 3

    and ApplyToKind =
        | AllDocuments = 1
        | OpenDocuments = 2
        | ClosedDocuments = 3

    and BackgroundPattern =
        abstract regexp: Regex with get, set
        abstract file: float option with get, set

    and BackgroundMonitor =
        abstract activeOnStart: bool option with get, set
        abstract beginsPattern: U2<Regex, BackgroundPattern> with get, set
        abstract endsPattern: U2<Regex, BackgroundPattern> with get, set

    and ProblemMatcher =
        abstract owner: string option with get, set
        abstract applyTo: ApplyToKind option with get, set
        abstract fileLocation: U2<FileLocationKind, string> option with get, set
        abstract pattern: U2<ProblemPattern, MultiLineProblemPattern> with get, set
        abstract severity: DiagnosticSeverity option with get, set
        abstract backgound: BackgroundMonitor option with get, set

    and RevealKind =
        | Always = 1
        | Silent = 2
        | Never = 3

    and TerminalBehaviour =
        abstract reveal: RevealKind option with get, set
        abstract echo: bool option with get, set

    and ProcessOptions =
        abstract cwd: string option with get, set
        abstract env: obj option with get, set

    and [<StringEnum>] [<Import("TaskGroup","vscode")>] TaskGroup =
        | Clean | Build | RebuildAll | Test

    and [<Import("ProcessTask","vscode")>] ProcessTask(name: string, ``process``: string, args: ResizeArray<string>, options: ProcessOptions, [<ParamArray>] problemMatchers: ProblemMatcher[]) =
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.identifier with get(): string = jsNative and set(v: string): unit = jsNative
        member __.isBackground with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.``process`` with get(): string = jsNative and set(v: string): unit = jsNative
        member __.args with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
        member __.group with get(): TaskGroup option = jsNative and set(v: TaskGroup option): unit = jsNative
        member __.options with get(): ProcessOptions = jsNative and set(v: ProcessOptions): unit = jsNative
        member __.terminal with get(): TerminalBehaviour = jsNative and set(v: TerminalBehaviour): unit = jsNative
        member __.problemMatchers with get(): ResizeArray<ProblemMatcher> = jsNative and set(v: ResizeArray<ProblemMatcher>): unit = jsNative

    and ShellOptions =
        U3<obj, obj, obj>

    and [<Import("ShellTask","vscode")>] ShellTask(name: string, commandLine: string, options: ShellOptions, [<ParamArray>] problemMatchers: ProblemMatcher[]) =
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.identifier with get(): string = jsNative and set(v: string): unit = jsNative
        member __.isBackground with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.commandLine with get(): string = jsNative and set(v: string): unit = jsNative
        member __.group with get(): TaskGroup option = jsNative and set(v: TaskGroup option): unit = jsNative
        member __.options with get(): ShellOptions = jsNative and set(v: ShellOptions): unit = jsNative
        member __.terminal with get(): TerminalBehaviour = jsNative and set(v: TerminalBehaviour): unit = jsNative
        member __.problemMatchers with get(): ResizeArray<ProblemMatcher> = jsNative and set(v: ResizeArray<ProblemMatcher>): unit = jsNative

    and Task =
        U2<ProcessTask, ShellTask>

    and TaskProvider =
        abstract provideTasks: token: CancellationToken -> ProviderResult<ResizeArray<Task>>

    and TreeView<'T> =
        abstract refresh: [<ParamArray>] nodes: 'T[] -> unit
        abstract dispose: unit -> unit

    and TreeDataProvider<'T> =
        abstract provideRootNode: unit -> U2<'T, PromiseLike<'T>>
        abstract resolveChildren: node: 'T -> U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>
        abstract getLabel: node: 'T -> string
        abstract getHasChildren: node: 'T -> bool
        abstract getClickCommand: node: 'T -> Command

    and LineChange =
        abstract originalStartLineNumber: float with get, set
        abstract originalEndLineNumber: float with get, set
        abstract modifiedStartLineNumber: float with get, set
        abstract modifiedEndLineNumber: float with get, set

    and Terminal =
        abstract name: string with get, set
        abstract processId: PromiseLike<float> with get, set
        abstract sendText: text: string * ?addNewLine: bool -> unit
        abstract show: ?preserveFocus: bool -> unit
        abstract hide: unit -> unit
        abstract dispose: unit -> unit
        abstract onData: callback: Func<string, obj> -> unit

    type [<Import("workspace","vscode")>] workspace =
        inherit vscode.workspace
        static member registerTaskProvider(provider: TaskProvider): Disposable = jsNative

    type [<Import("window","vscode")>] window =
        inherit vscode.window
        static member sampleFunction(): PromiseLike<obj> = jsNative
        static member createTreeView(viewId: string, provider: TreeDataProvider<'T>): TreeView<'T> = jsNative

    type [<Import("commands","vscode")>] commands =
        inherit vscode.commands
        static member registerDiffInformationCommand(command: string, callback: Func<ResizeArray<LineChange>, obj, obj>, ?thisArg: obj): Disposable = jsNative
