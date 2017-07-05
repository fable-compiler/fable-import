namespace Fable.Import

open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

module vscode =
    type Command =
        abstract title: string with get, set
        abstract command: string with get, set
        abstract tooltip: string option with get, set
        abstract arguments: ResizeArray<obj> option with get, set

    and TextLine =
        abstract lineNumber: float with get, set
        abstract text: string with get, set
        abstract range: Range with get, set
        abstract rangeIncludingLineBreak: Range with get, set
        abstract firstNonWhitespaceCharacterIndex: float with get, set
        abstract isEmptyOrWhitespace: bool with get, set

    and TextDocument =
        abstract uri: Uri with get, set
        abstract fileName: string with get, set
        abstract isUntitled: bool with get, set
        abstract languageId: string with get, set
        abstract version: float with get, set
        abstract isDirty: bool with get, set
        abstract isClosed: bool with get, set
        abstract eol: EndOfLine with get, set
        abstract lineCount: float with get, set
        abstract save: unit -> PromiseLike<bool>
        abstract lineAt: line: float -> TextLine
        abstract lineAt: position: Position -> TextLine
        abstract offsetAt: position: Position -> float
        abstract positionAt: offset: float -> Position
        abstract getText: ?range: Range -> string
        abstract getWordRangeAtPosition: position: Position * ?regex: Regex -> Range option
        abstract validateRange: range: Range -> Range
        abstract validatePosition: position: Position -> Position

    and [<Import("Position","vscode")>] Position(line: float, character: float) =
        member __.line with get(): float = jsNative and set(v: float): unit = jsNative
        member __.character with get(): float = jsNative and set(v: float): unit = jsNative
        member __.isBefore(other: Position): bool = jsNative
        member __.isBeforeOrEqual(other: Position): bool = jsNative
        member __.isAfter(other: Position): bool = jsNative
        member __.isAfterOrEqual(other: Position): bool = jsNative
        member __.isEqual(other: Position): bool = jsNative
        member __.compareTo(other: Position): float = jsNative
        member __.translate(?lineDelta: float, ?characterDelta: float): Position = jsNative
        member __.translate(change: obj): Position = jsNative
        member __.``with``(?line: float, ?character: float): Position = jsNative
        member __.``with``(change: obj): Position = jsNative

    and [<Import("Range","vscode")>] Range(startLine: float, startCharacter: float, endLine: float, endCharacter: float) =
        member __.start with get(): Position = jsNative and set(v: Position): unit = jsNative
        member __.``end`` with get(): Position = jsNative and set(v: Position): unit = jsNative
        member __.isEmpty with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.isSingleLine with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.contains(positionOrRange: U2<Position, Range>): bool = jsNative
        member __.isEqual(other: Range): bool = jsNative
        member __.intersection(range: Range): Range option = jsNative
        member __.union(other: Range): Range = jsNative
        member __.``with``(?start: Position, ?``end``: Position): Range = jsNative
        member __.``with``(change: obj): Range = jsNative

    and [<Import("Selection","vscode")>] Selection(anchorLine: float, anchorCharacter: float, activeLine: float, activeCharacter: float) =
        inherit Range(anchorLine, anchorCharacter, activeLine, activeCharacter)
        member __.anchor with get(): Position = jsNative and set(v: Position): unit = jsNative
        member __.active with get(): Position = jsNative and set(v: Position): unit = jsNative
        member __.isReversed with get(): bool = jsNative and set(v: bool): unit = jsNative

    and TextEditorSelectionChangeKind =
        | Keyboard = 1
        | Mouse = 2
        | Command = 3

    and TextEditorSelectionChangeEvent =
        abstract textEditor: TextEditor with get, set
        abstract selections: ResizeArray<Selection> with get, set
        abstract kind: TextEditorSelectionChangeKind option with get, set

    and TextEditorOptionsChangeEvent =
        abstract textEditor: TextEditor with get, set
        abstract options: TextEditorOptions with get, set

    and TextEditorViewColumnChangeEvent =
        abstract textEditor: TextEditor with get, set
        abstract viewColumn: ViewColumn with get, set

    and TextEditorCursorStyle =
        | Line = 1
        | Block = 2
        | Underline = 3
        | LineThin = 4
        | BlockOutline = 5
        | UnderlineThin = 6

    and TextEditorLineNumbersStyle =
        | Off = 0
        | On = 1
        | Relative = 2

    and TextEditorOptions =
        abstract tabSize: U2<float, string> option with get, set
        abstract insertSpaces: U2<bool, string> option with get, set
        abstract cursorStyle: TextEditorCursorStyle option with get, set
        abstract lineNumbers: TextEditorLineNumbersStyle option with get, set

    and TextEditorDecorationType =
        abstract key: string with get, set
        abstract dispose: unit -> unit

    and TextEditorRevealType =
        | Default = 0
        | InCenter = 1
        | InCenterIfOutsideViewport = 2
        | AtTop = 3

    and OverviewRulerLane =
        | Left = 1
        | Center = 2
        | Right = 4
        | Full = 7

    and TextDocumentShowOptions =
        abstract viewColumn: ViewColumn option with get, set
        abstract preserveFocus: bool option with get, set
        abstract preview: bool option with get, set

    and ThemableDecorationRenderOptions =
        abstract backgroundColor: string option with get, set
        abstract outline: string option with get, set
        abstract outlineColor: string option with get, set
        abstract outlineStyle: string option with get, set
        abstract outlineWidth: string option with get, set
        abstract border: string option with get, set
        abstract borderColor: string option with get, set
        abstract borderRadius: string option with get, set
        abstract borderSpacing: string option with get, set
        abstract borderStyle: string option with get, set
        abstract borderWidth: string option with get, set
        abstract textDecoration: string option with get, set
        abstract cursor: string option with get, set
        abstract color: string option with get, set
        abstract letterSpacing: string option with get, set
        abstract gutterIconPath: U2<string, Uri> option with get, set
        abstract gutterIconSize: string option with get, set
        abstract overviewRulerColor: string option with get, set
        abstract before: ThemableDecorationAttachmentRenderOptions option with get, set
        abstract after: ThemableDecorationAttachmentRenderOptions option with get, set

    and ThemableDecorationAttachmentRenderOptions =
        abstract contentText: string option with get, set
        abstract contentIconPath: U2<string, Uri> option with get, set
        abstract border: string option with get, set
        abstract textDecoration: string option with get, set
        abstract color: string option with get, set
        abstract backgroundColor: string option with get, set
        abstract margin: string option with get, set
        abstract width: string option with get, set
        abstract height: string option with get, set

    and DecorationRenderOptions =
        inherit ThemableDecorationRenderOptions
        abstract isWholeLine: bool option with get, set
        abstract overviewRulerLane: OverviewRulerLane option with get, set
        abstract light: ThemableDecorationRenderOptions option with get, set
        abstract dark: ThemableDecorationRenderOptions option with get, set

    and DecorationOptions =
        abstract range: Range with get, set
        abstract hoverMessage: U2<MarkedString, ResizeArray<MarkedString>> option with get, set
        abstract renderOptions: DecorationInstanceRenderOptions option with get, set

    and ThemableDecorationInstanceRenderOptions =
        abstract before: ThemableDecorationAttachmentRenderOptions option with get, set
        abstract after: ThemableDecorationAttachmentRenderOptions option with get, set

    and DecorationInstanceRenderOptions =
        inherit ThemableDecorationInstanceRenderOptions
        abstract light: ThemableDecorationInstanceRenderOptions option with get, set
        abstract dark: ThemableDecorationInstanceRenderOptions option with get, set

    and TextEditor =
        abstract document: TextDocument with get, set
        abstract selection: Selection with get, set
        abstract selections: ResizeArray<Selection> with get, set
        abstract options: TextEditorOptions with get, set
        abstract viewColumn: ViewColumn option with get, set
        abstract edit: callback: Func<TextEditorEdit, unit> * ?options: obj -> PromiseLike<bool>
        abstract insertSnippet: snippet: SnippetString * ?location: U4<Position, Range, ResizeArray<Position>, ResizeArray<Range>> * ?options: obj -> PromiseLike<bool>
        abstract setDecorations: decorationType: TextEditorDecorationType * rangesOrOptions: U2<ResizeArray<Range>, ResizeArray<DecorationOptions>> -> unit
        abstract revealRange: range: Range * ?revealType: TextEditorRevealType -> unit
        abstract show: ?column: ViewColumn -> unit
        abstract hide: unit -> unit

    and EndOfLine =
        | LF = 1
        | CRLF = 2

    and TextEditorEdit =
        abstract replace: location: U3<Position, Range, Selection> * value: string -> unit
        abstract insert: location: Position * value: string -> unit
        abstract delete: location: U2<Range, Selection> -> unit
        abstract setEndOfLine: endOfLine: EndOfLine -> unit

    and [<Import("Uri","vscode")>] Uri() =
        member __.scheme with get(): string = jsNative and set(v: string): unit = jsNative
        member __.authority with get(): string = jsNative and set(v: string): unit = jsNative
        member __.path with get(): string = jsNative and set(v: string): unit = jsNative
        member __.query with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fragment with get(): string = jsNative and set(v: string): unit = jsNative
        member __.fsPath with get(): string = jsNative and set(v: string): unit = jsNative
        static member file(path: string): Uri = jsNative
        static member parse(value: string): Uri = jsNative
        member __.``with``(change: obj): Uri = jsNative
        member __.toString(?skipEncoding: bool): string = jsNative
        member __.toJSON(): obj = jsNative

    and CancellationToken =
        abstract isCancellationRequested: bool with get, set
        abstract onCancellationRequested: Event<obj> with get, set

    and [<Import("CancellationTokenSource","vscode")>] CancellationTokenSource() =
        member __.token with get(): CancellationToken = jsNative and set(v: CancellationToken): unit = jsNative
        member __.cancel(): unit = jsNative
        member __.dispose(): unit = jsNative

    and [<Import("Disposable","vscode")>] Disposable(callOnDispose: Function) =
        static member from([<ParamArray>] disposableLikes: obj[]): Disposable = jsNative
        member __.dispose(): obj = jsNative

    and Event<'T> =
        [<Emit("$0($1...)")>] abstract Invoke: listener: Func<'T, obj> * ?thisArgs: obj * ?disposables: ResizeArray<Disposable> -> Disposable

    and [<Import("EventEmitter","vscode")>] EventEmitter<'T>() =
        member __.``event`` with get(): Event<'T> = jsNative and set(v: Event<'T>): unit = jsNative
        member __.fire(?data: 'T): unit = jsNative
        member __.dispose(): unit = jsNative

    and FileSystemWatcher =
        abstract from: [<ParamArray>] disposableLikes: obj[] -> Disposable
        abstract dispose: unit -> obj
        abstract ignoreCreateEvents: bool with get, set
        abstract ignoreChangeEvents: bool with get, set
        abstract ignoreDeleteEvents: bool with get, set
        abstract onDidCreate: Event<Uri> with get, set
        abstract onDidChange: Event<Uri> with get, set
        abstract onDidDelete: Event<Uri> with get, set

    and TextDocumentContentProvider =
        abstract onDidChange: Event<Uri> option with get, set
        abstract provideTextDocumentContent: uri: Uri * token: CancellationToken -> ProviderResult<string>

    and QuickPickItem =
        abstract label: string with get, set
        abstract description: string with get, set
        abstract detail: string option with get, set

    and QuickPickOptions =
        abstract matchOnDescription: bool option with get, set
        abstract matchOnDetail: bool option with get, set
        abstract placeHolder: string option with get, set
        abstract ignoreFocusOut: bool option with get, set
        abstract onDidSelectItem: item: U2<'T, string> -> obj

    and MessageItem =
        abstract title: string with get, set
        abstract isCloseAffordance: bool option with get, set

    and MessageOptions =
        abstract modal: bool option with get, set

    and InputBoxOptions =
        abstract value: string option with get, set
        abstract valueSelection: float * float option with get, set
        abstract prompt: string option with get, set
        abstract placeHolder: string option with get, set
        abstract password: bool option with get, set
        abstract ignoreFocusOut: bool option with get, set
        abstract ``null``: obj with get, set
        abstract validateInput: value: string -> U3<string, unit, obj>

    and DocumentFilter =
        abstract language: string option with get, set
        abstract scheme: string option with get, set
        abstract pattern: string option with get, set

    and DocumentSelector =
        U3<string, DocumentFilter, ResizeArray<U2<string, DocumentFilter>>>

    and ProviderResult<'T> =
        U3<'T, unit, obj>

    and CodeActionContext =
        abstract diagnostics: ResizeArray<Diagnostic> with get, set

    and CodeActionProvider =
        abstract provideCodeActions: document: TextDocument * range: Range * context: CodeActionContext * token: CancellationToken -> ProviderResult<ResizeArray<Command>>

    and [<Import("CodeLens","vscode")>] CodeLens(range: Range, ?command: Command) =
        member __.range with get(): Range = jsNative and set(v: Range): unit = jsNative
        member __.command with get(): Command option = jsNative and set(v: Command option): unit = jsNative
        member __.isResolved with get(): bool = jsNative and set(v: bool): unit = jsNative

    and CodeLensProvider =
        abstract onDidChangeCodeLenses: Event<unit> option with get, set
        abstract provideCodeLenses: document: TextDocument * token: CancellationToken -> ProviderResult<ResizeArray<CodeLens>>
        abstract resolveCodeLens: codeLens: CodeLens * token: CancellationToken -> ProviderResult<CodeLens>

    and Definition =
        U2<Location, ResizeArray<Location>>

    and DefinitionProvider =
        abstract provideDefinition: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<Definition>

    and ImplementationProvider =
        abstract provideImplementation: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<Definition>

    and TypeDefinitionProvider =
        abstract provideTypeDefinition: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<Definition>

    and MarkedString =
        U2<string, obj>

    and [<Import("Hover","vscode")>] Hover(contents: U2<MarkedString, ResizeArray<MarkedString>>, ?range: Range) =
        member __.contents with get(): ResizeArray<MarkedString> = jsNative and set(v: ResizeArray<MarkedString>): unit = jsNative
        member __.range with get(): Range option = jsNative and set(v: Range option): unit = jsNative

    and HoverProvider =
        abstract provideHover: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<Hover>

    and DocumentHighlightKind =
        | Text = 0
        | Read = 1
        | Write = 2

    and [<Import("DocumentHighlight","vscode")>] DocumentHighlight(range: Range, ?kind: DocumentHighlightKind) =
        member __.range with get(): Range = jsNative and set(v: Range): unit = jsNative
        member __.kind with get(): DocumentHighlightKind option = jsNative and set(v: DocumentHighlightKind option): unit = jsNative

    and DocumentHighlightProvider =
        abstract provideDocumentHighlights: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<ResizeArray<DocumentHighlight>>

    and SymbolKind =
        | File = 0
        | Module = 1
        | Namespace = 2
        | Package = 3
        | Class = 4
        | Method = 5
        | Property = 6
        | Field = 7
        | Constructor = 8
        | Enum = 9
        | Interface = 10
        | Function = 11
        | Variable = 12
        | Constant = 13
        | String = 14
        | Number = 15
        | Boolean = 16
        | Array = 17
        | Object = 18
        | Key = 19
        | Null = 20
        | EnumMember = 21
        | Struct = 22
        | Event = 23
        | Operator = 24
        | TypeParameter = 25

    and [<Import("SymbolInformation","vscode")>] SymbolInformation(name: string, kind: SymbolKind, range: Range, ?uri: Uri, ?containerName: string) =
        member __.name with get(): string = jsNative and set(v: string): unit = jsNative
        member __.containerName with get(): string = jsNative and set(v: string): unit = jsNative
        member __.kind with get(): SymbolKind = jsNative and set(v: SymbolKind): unit = jsNative
        member __.location with get(): Location = jsNative and set(v: Location): unit = jsNative

    and DocumentSymbolProvider =
        abstract provideDocumentSymbols: document: TextDocument * token: CancellationToken -> ProviderResult<ResizeArray<SymbolInformation>>

    and WorkspaceSymbolProvider =
        abstract provideWorkspaceSymbols: query: string * token: CancellationToken -> ProviderResult<ResizeArray<SymbolInformation>>
        abstract resolveWorkspaceSymbol: symbol: SymbolInformation * token: CancellationToken -> ProviderResult<SymbolInformation>

    and ReferenceContext =
        abstract includeDeclaration: bool with get, set

    and ReferenceProvider =
        abstract provideReferences: document: TextDocument * position: Position * context: ReferenceContext * token: CancellationToken -> ProviderResult<ResizeArray<Location>>

    and [<Import("TextEdit","vscode")>] TextEdit(range: Range, newText: string) =
        member __.range with get(): Range = jsNative and set(v: Range): unit = jsNative
        member __.newText with get(): string = jsNative and set(v: string): unit = jsNative
        member __.newEol with get(): EndOfLine = jsNative and set(v: EndOfLine): unit = jsNative
        static member replace(range: Range, newText: string): TextEdit = jsNative
        static member insert(position: Position, newText: string): TextEdit = jsNative
        static member delete(range: Range): TextEdit = jsNative
        static member setEndOfLine(eol: EndOfLine): TextEdit = jsNative

    and [<Import("WorkspaceEdit","vscode")>] WorkspaceEdit() =
        member __.size with get(): float = jsNative and set(v: float): unit = jsNative
        member __.replace(uri: Uri, range: Range, newText: string): unit = jsNative
        member __.insert(uri: Uri, position: Position, newText: string): unit = jsNative
        member __.delete(uri: Uri, range: Range): unit = jsNative
        member __.has(uri: Uri): bool = jsNative
        member __.set(uri: Uri, edits: ResizeArray<TextEdit>): unit = jsNative
        member __.get(uri: Uri): ResizeArray<TextEdit> = jsNative
        member __.entries(): ResizeArray<Uri * ResizeArray<TextEdit>> = jsNative

    and [<Import("SnippetString","vscode")>] SnippetString(?value: string) =
        member __.value with get(): string = jsNative and set(v: string): unit = jsNative
        member __.appendText(string: string): SnippetString = jsNative
        member __.appendTabstop(?number: float): SnippetString = jsNative
        member __.appendPlaceholder(value: U2<string, Func<SnippetString, obj>>, ?number: float): SnippetString = jsNative
        member __.appendVariable(name: string, defaultValue: U2<string, Func<SnippetString, obj>>): SnippetString = jsNative

    and RenameProvider =
        abstract provideRenameEdits: document: TextDocument * position: Position * newName: string * token: CancellationToken -> ProviderResult<WorkspaceEdit>

    and FormattingOptions =
        abstract tabSize: float with get, set
        abstract insertSpaces: bool with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> U3<bool, float, string> with get, set

    and DocumentFormattingEditProvider =
        abstract provideDocumentFormattingEdits: document: TextDocument * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

    and DocumentRangeFormattingEditProvider =
        abstract provideDocumentRangeFormattingEdits: document: TextDocument * range: Range * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

    and OnTypeFormattingEditProvider =
        abstract provideOnTypeFormattingEdits: document: TextDocument * position: Position * ch: string * options: FormattingOptions * token: CancellationToken -> ProviderResult<ResizeArray<TextEdit>>

    and [<Import("ParameterInformation","vscode")>] ParameterInformation(label: string, ?documentation: string) =
        member __.label with get(): string = jsNative and set(v: string): unit = jsNative
        member __.documentation with get(): string option = jsNative and set(v: string option): unit = jsNative

    and [<Import("SignatureInformation","vscode")>] SignatureInformation(label: string, ?documentation: string) =
        member __.label with get(): string = jsNative and set(v: string): unit = jsNative
        member __.documentation with get(): string option = jsNative and set(v: string option): unit = jsNative
        member __.parameters with get(): ResizeArray<ParameterInformation> = jsNative and set(v: ResizeArray<ParameterInformation>): unit = jsNative

    and [<Import("SignatureHelp","vscode")>] SignatureHelp() =
        member __.signatures with get(): ResizeArray<SignatureInformation> = jsNative and set(v: ResizeArray<SignatureInformation>): unit = jsNative
        member __.activeSignature with get(): float = jsNative and set(v: float): unit = jsNative
        member __.activeParameter with get(): float = jsNative and set(v: float): unit = jsNative

    and SignatureHelpProvider =
        abstract provideSignatureHelp: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<SignatureHelp>

    and CompletionItemKind =
        | Text = 0
        | Method = 1
        | Function = 2
        | Constructor = 3
        | Field = 4
        | Variable = 5
        | Class = 6
        | Interface = 7
        | Module = 8
        | Property = 9
        | Unit = 10
        | Value = 11
        | Enum = 12
        | Keyword = 13
        | Snippet = 14
        | Color = 15
        | Reference = 17
        | File = 16
        | Folder = 18
        | EnumMember = 19
        | Constant = 20
        | Struct = 21
        | Event = 22
        | Operator = 23
        | TypeParameter = 24

    and [<Import("CompletionItem","vscode")>] CompletionItem(label: string, ?kind: CompletionItemKind) =
        member __.label with get(): string = jsNative and set(v: string): unit = jsNative
        member __.kind with get(): CompletionItemKind option = jsNative and set(v: CompletionItemKind option): unit = jsNative
        member __.detail with get(): string option = jsNative and set(v: string option): unit = jsNative
        member __.documentation with get(): string option = jsNative and set(v: string option): unit = jsNative
        member __.sortText with get(): string option = jsNative and set(v: string option): unit = jsNative
        member __.filterText with get(): string option = jsNative and set(v: string option): unit = jsNative
        member __.insertText with get(): U2<string, SnippetString> option = jsNative and set(v: U2<string, SnippetString> option): unit = jsNative
        member __.range with get(): Range option = jsNative and set(v: Range option): unit = jsNative
        member __.commitCharacters with get(): ResizeArray<string> option = jsNative and set(v: ResizeArray<string> option): unit = jsNative
        member __.textEdit with get(): TextEdit option = jsNative and set(v: TextEdit option): unit = jsNative
        member __.additionalTextEdits with get(): ResizeArray<TextEdit> option = jsNative and set(v: ResizeArray<TextEdit> option): unit = jsNative
        member __.command with get(): Command option = jsNative and set(v: Command option): unit = jsNative

    and [<Import("CompletionList","vscode")>] CompletionList(?items: ResizeArray<CompletionItem>, ?isIncomplete: bool) =
        member __.isIncomplete with get(): bool option = jsNative and set(v: bool option): unit = jsNative
        member __.items with get(): ResizeArray<CompletionItem> = jsNative and set(v: ResizeArray<CompletionItem>): unit = jsNative

    and CompletionItemProvider =
        abstract provideCompletionItems: document: TextDocument * position: Position * token: CancellationToken -> ProviderResult<U2<ResizeArray<CompletionItem>, CompletionList>>
        abstract resolveCompletionItem: item: CompletionItem * token: CancellationToken -> ProviderResult<CompletionItem>

    and [<Import("DocumentLink","vscode")>] DocumentLink(range: Range, ?target: Uri) =
        member __.range with get(): Range = jsNative and set(v: Range): unit = jsNative
        member __.target with get(): Uri option = jsNative and set(v: Uri option): unit = jsNative

    and DocumentLinkProvider =
        abstract provideDocumentLinks: document: TextDocument * token: CancellationToken -> ProviderResult<ResizeArray<DocumentLink>>
        abstract resolveDocumentLink: link: DocumentLink * token: CancellationToken -> ProviderResult<DocumentLink>

    and CharacterPair =
        string * string

    and CommentRule =
        abstract lineComment: string option with get, set
        abstract blockComment: CharacterPair option with get, set

    and IndentationRule =
        abstract decreaseIndentPattern: Regex with get, set
        abstract increaseIndentPattern: Regex with get, set
        abstract indentNextLinePattern: Regex option with get, set
        abstract unIndentedLinePattern: Regex option with get, set

    and IndentAction =
        | None = 0
        | Indent = 1
        | IndentOutdent = 2
        | Outdent = 3

    and EnterAction =
        abstract indentAction: IndentAction with get, set
        abstract appendText: string option with get, set
        abstract removeText: float option with get, set

    and OnEnterRule =
        abstract beforeText: Regex with get, set
        abstract afterText: Regex option with get, set
        abstract action: EnterAction with get, set

    and LanguageConfiguration =
        abstract comments: CommentRule option with get, set
        abstract brackets: ResizeArray<CharacterPair> option with get, set
        abstract wordPattern: Regex option with get, set
        abstract indentationRules: IndentationRule option with get, set
        abstract onEnterRules: ResizeArray<OnEnterRule> option with get, set
        abstract ___electricCharacterSupport: obj option with get, set
        abstract ___characterPairSupport: obj option with get, set

    and WorkspaceConfiguration =
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
        abstract get: section: string -> 'T option
        abstract get: section: string * defaultValue: 'T -> 'T
        abstract has: section: string -> bool
        abstract inspect: section: string -> obj option
        abstract update: section: string * value: obj * ?``global``: bool -> PromiseLike<unit>

    and [<Import("Location","vscode")>] Location(uri: Uri, rangeOrPosition: U2<Range, Position>) =
        member __.uri with get(): Uri = jsNative and set(v: Uri): unit = jsNative
        member __.range with get(): Range = jsNative and set(v: Range): unit = jsNative

    and DiagnosticSeverity =
        | Error = 0
        | Warning = 1
        | Information = 2
        | Hint = 3

    and [<Import("Diagnostic","vscode")>] Diagnostic(range: Range, message: string, ?severity: DiagnosticSeverity) =
        member __.range with get(): Range = jsNative and set(v: Range): unit = jsNative
        member __.message with get(): string = jsNative and set(v: string): unit = jsNative
        member __.source with get(): string = jsNative and set(v: string): unit = jsNative
        member __.severity with get(): DiagnosticSeverity = jsNative and set(v: DiagnosticSeverity): unit = jsNative
        member __.code with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative

    and DiagnosticCollection =
        abstract name: string with get, set
        abstract set: uri: Uri * diagnostics: ResizeArray<Diagnostic> option -> unit
        abstract set: entries: ResizeArray<Uri * ResizeArray<Diagnostic> option> -> unit
        abstract delete: uri: Uri -> unit
        abstract clear: unit -> unit
        abstract forEach: callback: Func<Uri, ResizeArray<Diagnostic>, DiagnosticCollection, obj> * ?thisArg: obj -> unit
        abstract get: uri: Uri -> ResizeArray<Diagnostic> option
        abstract has: uri: Uri -> bool
        abstract dispose: unit -> unit

    and ViewColumn =
        | One = 1
        | Two = 2
        | Three = 3

    and OutputChannel =
        abstract name: string with get, set
        abstract append: value: string -> unit
        abstract appendLine: value: string -> unit
        abstract clear: unit -> unit
        abstract show: ?preserveFocus: bool -> unit
        abstract show: ?column: ViewColumn * ?preserveFocus: bool -> unit
        abstract hide: unit -> unit
        abstract dispose: unit -> unit

    and StatusBarAlignment =
        | Left = 1
        | Right = 2

    and StatusBarItem =
        abstract alignment: StatusBarAlignment with get, set
        abstract priority: float with get, set
        abstract text: string with get, set
        abstract tooltip: string option with get, set
        abstract color: string option with get, set
        abstract command: string option with get, set
        abstract show: unit -> unit
        abstract hide: unit -> unit
        abstract dispose: unit -> unit

    and Progress<'T> =
        abstract report: value: 'T -> unit

    and Terminal =
        abstract name: string with get, set
        abstract processId: PromiseLike<float> with get, set
        abstract sendText: text: string * ?addNewLine: bool -> unit
        abstract show: ?preserveFocus: bool -> unit
        abstract hide: unit -> unit
        abstract dispose: unit -> unit

    and Extension<'T> =
        abstract id: string with get, set
        abstract extensionPath: string with get, set
        abstract isActive: bool with get, set
        abstract packageJSON: obj with get, set
        abstract exports: 'T with get, set
        abstract activate: unit -> PromiseLike<'T>

    and ExtensionContext =
        abstract subscriptions: ResizeArray<obj> with get, set
        abstract workspaceState: Memento with get, set
        abstract globalState: Memento with get, set
        abstract extensionPath: string with get, set
        abstract storagePath: string option with get, set
        abstract asAbsolutePath: relativePath: string -> string

    and Memento =
        abstract get: key: string -> 'T option
        abstract get: key: string * defaultValue: 'T -> 'T
        abstract update: key: string * value: obj -> PromiseLike<unit>

    and TerminalOptions =
        abstract name: string option with get, set
        abstract shellPath: string option with get, set
        abstract shellArgs: ResizeArray<string> option with get, set

    and ProgressLocation =
        | SourceControl = 1
        | Window = 10

    and ProgressOptions =
        abstract location: ProgressLocation with get, set
        abstract title: string option with get, set

    and TextDocumentContentChangeEvent =
        abstract range: Range with get, set
        abstract rangeLength: float with get, set
        abstract text: string with get, set

    and TextDocumentChangeEvent =
        abstract document: TextDocument with get, set
        abstract contentChanges: ResizeArray<TextDocumentContentChangeEvent> with get, set

    and TextDocumentSaveReason =
        | Manual = 1
        | AfterDelay = 2
        | FocusOut = 3

    and TextDocumentWillSaveEvent =
        abstract document: TextDocument with get, set
        abstract reason: TextDocumentSaveReason with get, set
        abstract waitUntil: PromiseLike: PromiseLike<ResizeArray<TextEdit>> -> unit
        abstract waitUntil: PromiseLike: PromiseLike<obj> -> unit

    and SourceControlInputBox =
        abstract value: string with get, set

    and QuickDiffProvider =
        abstract provideOriginalResource: uri: Uri * token: CancellationToken -> ProviderResult<Uri>

    and SourceControlResourceThemableDecorations =
        abstract iconPath: U2<string, Uri> option with get, set

    and SourceControlResourceDecorations =
        inherit SourceControlResourceThemableDecorations
        abstract strikeThrough: bool option with get, set
        abstract faded: bool option with get, set
        abstract light: SourceControlResourceThemableDecorations option with get, set
        abstract dark: SourceControlResourceThemableDecorations option with get, set

    and SourceControlResourceState =
        abstract resourceUri: Uri with get, set
        abstract command: Command option with get, set
        abstract decorations: SourceControlResourceDecorations option with get, set

    and SourceControlResourceGroup =
        abstract id: string with get, set
        abstract label: string with get, set
        abstract hideWhenEmpty: bool option with get, set
        abstract resourceStates: ResizeArray<SourceControlResourceState> with get, set
        abstract dispose: unit -> unit

    and SourceControl =
        abstract id: string with get, set
        abstract label: string with get, set
        abstract count: float option with get, set
        abstract quickDiffProvider: QuickDiffProvider option with get, set
        abstract commitTemplate: string option with get, set
        abstract acceptInputCommand: Command option with get, set
        abstract statusBarCommands: ResizeArray<Command> option with get, set
        abstract createResourceGroup: id: string * label: string -> SourceControlResourceGroup
        abstract dispose: unit -> unit

    let [<Import("version","vscode")>] version: string = jsNative

    type [<Import("env","vscode")>] env =
        static member appName with get(): string = jsNative and set(v: string): unit = jsNative
        static member language with get(): string = jsNative and set(v: string): unit = jsNative
        static member machineId with get(): string = jsNative and set(v: string): unit = jsNative
        static member sessionId with get(): string = jsNative and set(v: string): unit = jsNative

    type [<Import("commands","vscode")>] commands =
        static member registerCommand(command: string, callback: Func<obj, obj>, ?thisArg: obj): Disposable = jsNative
        static member registerTextEditorCommand(command: string, callback: Func<TextEditor, TextEditorEdit, obj, unit>, ?thisArg: obj): Disposable = jsNative
        static member executeCommand(command: string, [<ParamArray>] rest: obj[]): PromiseLike<'T option> = jsNative
        static member getCommands(?filterInternal: bool): PromiseLike<ResizeArray<string>> = jsNative

    type [<Import("window","vscode")>] window =
        static member activeTextEditor with get(): TextEditor option = jsNative and set(v: TextEditor option): unit = jsNative
        static member visibleTextEditors with get(): ResizeArray<TextEditor> = jsNative and set(v: ResizeArray<TextEditor>): unit = jsNative
        static member onDidChangeActiveTextEditor with get(): Event<TextEditor> = jsNative and set(v: Event<TextEditor>): unit = jsNative
        static member onDidChangeVisibleTextEditors with get(): Event<ResizeArray<TextEditor>> = jsNative and set(v: Event<ResizeArray<TextEditor>>): unit = jsNative
        static member onDidChangeTextEditorSelection with get(): Event<TextEditorSelectionChangeEvent> = jsNative and set(v: Event<TextEditorSelectionChangeEvent>): unit = jsNative
        static member onDidChangeTextEditorOptions with get(): Event<TextEditorOptionsChangeEvent> = jsNative and set(v: Event<TextEditorOptionsChangeEvent>): unit = jsNative
        static member onDidChangeTextEditorViewColumn with get(): Event<TextEditorViewColumnChangeEvent> = jsNative and set(v: Event<TextEditorViewColumnChangeEvent>): unit = jsNative
        static member onDidCloseTerminal with get(): Event<Terminal> = jsNative and set(v: Event<Terminal>): unit = jsNative
        static member showTextDocument(document: TextDocument, ?column: ViewColumn, ?preserveFocus: bool): PromiseLike<TextEditor> = jsNative
        static member showTextDocument(document: TextDocument, ?options: TextDocumentShowOptions): PromiseLike<TextEditor> = jsNative
        static member createTextEditorDecorationType(options: DecorationRenderOptions): TextEditorDecorationType = jsNative
        static member showInformationMessage(message: string, [<ParamArray>] items: string[]): PromiseLike<string option> = jsNative
        static member showInformationMessage(message: string, options: MessageOptions, [<ParamArray>] items: string[]): PromiseLike<string option> = jsNative
        static member showInformationMessage(message: string, [<ParamArray>] items: 'T[]): PromiseLike<'T option> = jsNative
        static member showInformationMessage(message: string, options: MessageOptions, [<ParamArray>] items: 'T[]): PromiseLike<'T option> = jsNative
        static member showWarningMessage(message: string, [<ParamArray>] items: string[]): PromiseLike<string option> = jsNative
        static member showWarningMessage(message: string, options: MessageOptions, [<ParamArray>] items: string[]): PromiseLike<string option> = jsNative
        static member showWarningMessage(message: string, [<ParamArray>] items: 'T[]): PromiseLike<'T option> = jsNative
        static member showWarningMessage(message: string, options: MessageOptions, [<ParamArray>] items: 'T[]): PromiseLike<'T option> = jsNative
        static member showErrorMessage(message: string, [<ParamArray>] items: string[]): PromiseLike<string option> = jsNative
        static member showErrorMessage(message: string, options: MessageOptions, [<ParamArray>] items: string[]): PromiseLike<string option> = jsNative
        static member showErrorMessage(message: string, [<ParamArray>] items: 'T[]): PromiseLike<'T option> = jsNative
        static member showErrorMessage(message: string, options: MessageOptions, [<ParamArray>] items: 'T[]): PromiseLike<'T option> = jsNative
        static member showQuickPick(items: U2<ResizeArray<string>, PromiseLike<ResizeArray<string>>>, ?options: QuickPickOptions, ?token: CancellationToken): PromiseLike<string option> = jsNative
        static member showQuickPick(items: U2<ResizeArray<'T>, PromiseLike<ResizeArray<'T>>>, ?options: QuickPickOptions, ?token: CancellationToken): PromiseLike<'T option> = jsNative
        static member showInputBox(?options: InputBoxOptions, ?token: CancellationToken): PromiseLike<string option> = jsNative
        static member createOutputChannel(name: string): OutputChannel = jsNative
        static member setStatusBarMessage(text: string, hideAfterTimeout: float): Disposable = jsNative
        static member setStatusBarMessage(text: string, hideWhenDone: PromiseLike<obj>): Disposable = jsNative
        static member setStatusBarMessage(text: string): Disposable = jsNative
        static member withScmProgress(task: Func<Progress<float>, PromiseLike<'R>>): PromiseLike<'R> = jsNative
        static member withProgress(options: ProgressOptions, task: Func<Progress<obj>, PromiseLike<'R>>): PromiseLike<'R> = jsNative
        static member createStatusBarItem(?alignment: StatusBarAlignment, ?priority: float): StatusBarItem = jsNative
        static member createTerminal(?name: string, ?shellPath: string, ?shellArgs: ResizeArray<string>): Terminal = jsNative
        static member createTerminal(options: TerminalOptions): Terminal = jsNative

    type [<Import("workspace","vscode")>] workspace =
        static member rootPath with get(): string option = jsNative and set(v: string option): unit = jsNative
        static member textDocuments with get(): ResizeArray<TextDocument> = jsNative and set(v: ResizeArray<TextDocument>): unit = jsNative
        static member onDidOpenTextDocument with get(): Event<TextDocument> = jsNative and set(v: Event<TextDocument>): unit = jsNative
        static member onDidCloseTextDocument with get(): Event<TextDocument> = jsNative and set(v: Event<TextDocument>): unit = jsNative
        static member onDidChangeTextDocument with get(): Event<TextDocumentChangeEvent> = jsNative and set(v: Event<TextDocumentChangeEvent>): unit = jsNative
        static member onWillSaveTextDocument with get(): Event<TextDocumentWillSaveEvent> = jsNative and set(v: Event<TextDocumentWillSaveEvent>): unit = jsNative
        static member onDidSaveTextDocument with get(): Event<TextDocument> = jsNative and set(v: Event<TextDocument>): unit = jsNative
        static member onDidChangeConfiguration with get(): Event<unit> = jsNative and set(v: Event<unit>): unit = jsNative
        static member createFileSystemWatcher(globPattern: string, ?ignoreCreateEvents: bool, ?ignoreChangeEvents: bool, ?ignoreDeleteEvents: bool): FileSystemWatcher = jsNative
        static member asRelativePath(pathOrUri: U2<string, Uri>): string = jsNative
        static member findFiles(``include``: string, ?exclude: string, ?maxResults: float, ?token: CancellationToken): PromiseLike<ResizeArray<Uri>> = jsNative
        static member saveAll(?includeUntitled: bool): PromiseLike<bool> = jsNative
        static member applyEdit(edit: WorkspaceEdit): PromiseLike<bool> = jsNative
        static member openTextDocument(uri: Uri): PromiseLike<TextDocument> = jsNative
        static member openTextDocument(fileName: string): PromiseLike<TextDocument> = jsNative
        static member openTextDocument(?options: obj): PromiseLike<TextDocument> = jsNative
        static member registerTextDocumentContentProvider(scheme: string, provider: TextDocumentContentProvider): Disposable = jsNative
        static member getConfiguration(?section: string): WorkspaceConfiguration = jsNative

    type [<Import("languages","vscode")>] languages =
        static member getLanguages(): PromiseLike<ResizeArray<string>> = jsNative
        static member ``match``(selector: DocumentSelector, document: TextDocument): float = jsNative
        static member createDiagnosticCollection(?name: string): DiagnosticCollection = jsNative
        static member registerCompletionItemProvider(selector: DocumentSelector, provider: CompletionItemProvider, [<ParamArray>] triggerCharacters: string[]): Disposable = jsNative
        static member registerCodeActionsProvider(selector: DocumentSelector, provider: CodeActionProvider): Disposable = jsNative
        static member registerCodeLensProvider(selector: DocumentSelector, provider: CodeLensProvider): Disposable = jsNative
        static member registerDefinitionProvider(selector: DocumentSelector, provider: DefinitionProvider): Disposable = jsNative
        static member registerImplementationProvider(selector: DocumentSelector, provider: ImplementationProvider): Disposable = jsNative
        static member registerTypeDefinitionProvider(selector: DocumentSelector, provider: TypeDefinitionProvider): Disposable = jsNative
        static member registerHoverProvider(selector: DocumentSelector, provider: HoverProvider): Disposable = jsNative
        static member registerDocumentHighlightProvider(selector: DocumentSelector, provider: DocumentHighlightProvider): Disposable = jsNative
        static member registerDocumentSymbolProvider(selector: DocumentSelector, provider: DocumentSymbolProvider): Disposable = jsNative
        static member registerWorkspaceSymbolProvider(provider: WorkspaceSymbolProvider): Disposable = jsNative
        static member registerReferenceProvider(selector: DocumentSelector, provider: ReferenceProvider): Disposable = jsNative
        static member registerRenameProvider(selector: DocumentSelector, provider: RenameProvider): Disposable = jsNative
        static member registerDocumentFormattingEditProvider(selector: DocumentSelector, provider: DocumentFormattingEditProvider): Disposable = jsNative
        static member registerDocumentRangeFormattingEditProvider(selector: DocumentSelector, provider: DocumentRangeFormattingEditProvider): Disposable = jsNative
        static member registerOnTypeFormattingEditProvider(selector: DocumentSelector, provider: OnTypeFormattingEditProvider, firstTriggerCharacter: string, [<ParamArray>] moreTriggerCharacter: string[]): Disposable = jsNative
        static member registerSignatureHelpProvider(selector: DocumentSelector, provider: SignatureHelpProvider, [<ParamArray>] triggerCharacters: string[]): Disposable = jsNative
        static member registerDocumentLinkProvider(selector: DocumentSelector, provider: DocumentLinkProvider): Disposable = jsNative
        static member setLanguageConfiguration(language: string, configuration: LanguageConfiguration): Disposable = jsNative

    type [<Import("scm","vscode")>] scm =
        static member inputBox with get(): SourceControlInputBox = jsNative and set(v: SourceControlInputBox): unit = jsNative
        static member createSourceControl(id: string, label: string): SourceControl = jsNative

    type [<Import("extensions","vscode")>] extensions =
        static member all with get(): ResizeArray<Extension<obj>> = jsNative and set(v: ResizeArray<Extension<obj>>): unit = jsNative
        static member getExtension(extensionId: string): Extension<obj> option = jsNative
        static member getExtension(extensionId: string): Extension<'T> option = jsNative
