namespace rec Fable.Import.Pixi.Sound

open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser
open Fable.Import.Pixi

module PIXI =
    module sound =
        type [<AllowNullLiteral>] [<Import("Filter","PIXI/sound")>] Filter(destination: AudioNode, ?source: AudioNode) =
            member __.destination with get(): AudioNode = jsNative and set(v: AudioNode): unit = jsNative
            member __.source with get(): AudioNode = jsNative and set(v: AudioNode): unit = jsNative
            member __.connect(destination: AudioNode): unit = jsNative
            member __.disconnect(): unit = jsNative
            member __.destroy(): unit = jsNative

        and [<AllowNullLiteral>] [<Import("Filterable","PIXI/sound")>] Filterable(input: AudioNode, output: AudioNode) =
            member __.destination with get(): AudioNode = jsNative and set(v: AudioNode): unit = jsNative
            member __.filters with get(): ResizeArray<Filter> = jsNative and set(v: ResizeArray<Filter>): unit = jsNative
            member __.destroy(): unit = jsNative

        and [<AllowNullLiteral>] Options =
            abstract autoPlay: bool option with get, set
            abstract preaload: bool option with get, set
            abstract singleInstance: bool option with get, set
            abstract volume: float option with get, set
            abstract speed: float option with get, set
            abstract complete: CompleteCallback option with get, set
            abstract loaded: LoadedCallback option with get, set
            abstract preload: bool option with get, set
            abstract loop: bool option with get, set
            abstract url: string option with get, set
            abstract source: U2<ArrayBuffer, HTMLAudioElement> option with get, set
            abstract sprites: obj option with get, set

        and [<AllowNullLiteral>] PlayOptions =
            abstract start: float option with get, set
            abstract ``end``: float option with get, set
            abstract speed: float option with get, set
            abstract loop: bool option with get, set
            abstract volume: float option with get, set
            abstract sprite: string option with get, set
            abstract muted: bool option with get, set
            abstract complete: CompleteCallback option with get, set
            abstract loaded: LoadedCallback option with get, set

        and LoadedCallback =
            Error -> Sound -> IMediaInstance -> unit

        and CompleteCallback =
            Sound -> unit

        and [<AllowNullLiteral>] [<Import("Sound","PIXI/sound")>] Sound(media: IMedia, options: Options) =
            member __.isLoaded with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.isPlaying with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.autoPlay with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.singleInstance with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.preload with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.url with get(): string = jsNative and set(v: string): unit = jsNative
            member __.options with get(): Options = jsNative and set(v: Options): unit = jsNative
            member __.media with get(): IMedia = jsNative and set(v: IMedia): unit = jsNative
            member __.context with get(): IMediaContext = jsNative and set(v: IMediaContext): unit = jsNative
            member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
            member __.filters with get(): ResizeArray<Filter> = jsNative and set(v: ResizeArray<Filter>): unit = jsNative
            member __.isPlayable with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
            member __.muted with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
            member __.instances with get(): ResizeArray<IMediaInstance> = jsNative and set(v: ResizeArray<IMediaInstance>): unit = jsNative
            member __.sprites with get(): SoundSprites = jsNative and set(v: SoundSprites): unit = jsNative
            member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
            static member from(source: U4<string, Options, ArrayBuffer, HTMLAudioElement>): Sound = jsNative
            member __.pause(): Sound = jsNative
            member __.resume(): Sound = jsNative
            member __.addSprites(alias: string, data: SoundSpriteData): SoundSprite = jsNative
            member __.addSprites(sprites: obj): SoundSprites = jsNative
            member __.destroy(): unit = jsNative
            member __.removeSprites(?alias: string): Sound = jsNative
            member __.stop(): Sound = jsNative
            member __.play(alias: string, ?callback: CompleteCallback): U2<IMediaInstance, Promise<IMediaInstance>> = jsNative
            member __.play(?source: U3<string, PlayOptions, CompleteCallback>, ?callback: CompleteCallback): U2<IMediaInstance, Promise<IMediaInstance>> = jsNative
            member __.refresh(): unit = jsNative
            member __.refreshPaused(): unit = jsNative
            member __.autoPlayStart(): IMediaInstance = jsNative

        and SoundMap =
            obj

        and [<AllowNullLiteral>] IMedia =
            abstract filters: ResizeArray<Filter> with get, set
            abstract context: IMediaContext with get, set
            abstract duration: float with get, set
            abstract isPlayable: bool with get, set
            abstract create: unit -> IMediaInstance
            abstract init: sound: Sound -> unit
            abstract load: ?callback: LoadedCallback -> unit
            abstract destroy: unit -> unit

        and [<AllowNullLiteral>] IMediaContext =
            abstract muted: bool with get, set
            abstract volume: float with get, set
            abstract speed: float with get, set
            abstract paused: bool with get, set
            abstract filters: ResizeArray<Filter> with get, set
            abstract audioContext: AudioContext with get, set
            abstract toggleMute: unit -> bool
            abstract togglePause: unit -> bool
            abstract refresh: unit -> unit
            abstract destroy: unit -> unit

        and [<AllowNullLiteral>] IMediaInstance =
            abstract id: float with get, set
            abstract progress: float with get, set
            abstract paused: bool with get, set
            abstract volume: float with get, set
            abstract speed: float with get, set
            abstract loop: bool with get, set
            abstract muted: bool with get, set
            abstract stop: unit -> unit
            abstract refresh: unit -> unit
            abstract refreshPaused: unit -> unit
            abstract init: parent: IMedia -> unit
            abstract play: options: PlayOptions -> unit
            abstract destroy: unit -> unit
            abstract toString: unit -> string
            abstract once: ``event``: string * fn: Func<unit, unit> * ?context: obj -> obj
            abstract on: ``event``: string * fn: Function * ?context: obj -> obj
            abstract off: ``event``: string * fn: Function * ?context: obj * ?once: bool -> obj

        and [<AllowNullLiteral>] SoundSpriteData =
            abstract start: float with get, set
            abstract ``end``: float with get, set
            abstract speed: float option with get, set

        and SoundSprites =
            obj

        and [<AllowNullLiteral>] [<Import("SoundSprite","PIXI/sound")>] SoundSprite(parent: Sound, options: SoundSpriteData) =
            member __.parent with get(): Sound = jsNative and set(v: Sound): unit = jsNative
            member __.start with get(): float = jsNative and set(v: float): unit = jsNative
            member __.``end`` with get(): float = jsNative and set(v: float): unit = jsNative
            member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
            member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
            member __.play(?complete: CompleteCallback): U2<IMediaInstance, Promise<IMediaInstance>> = jsNative
            member __.destroy(): unit = jsNative

        and [<AllowNullLiteral>] RenderOptions =
            abstract width: float option with get, set
            abstract height: float option with get, set
            abstract fill: U3<string, CanvasPattern, CanvasGradient> option with get, set

        and ExtensionMap =
            obj

        and [<AllowNullLiteral>] [<Import("SoundUtils","PIXI/sound")>] SoundUtils() =
            member __.extensions with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
            member __.supported with get(): ExtensionMap = jsNative and set(v: ExtensionMap): unit = jsNative
            static member resolveUrl(source: U2<string, PIXI.loaders.Resource>): string = jsNative
            static member sineTone(?hertz: float, ?seconds: float): Sound = jsNative
            static member render(sound: Sound, ?options: RenderOptions): PIXI.BaseTexture = jsNative
            static member playOnce(url: string, ?callback: Func<Error, unit>): string = jsNative

        type [<Import("*","PIXI/sound")>] Globals =
            static member context with get(): IMediaContext = jsNative and set(v: IMediaContext): unit = jsNative
            static member supported with get(): bool = jsNative and set(v: bool): unit = jsNative
            static member useLegacy with get(): bool = jsNative and set(v: bool): unit = jsNative
            static member volumeAll with get(): float = jsNative and set(v: float): unit = jsNative
            static member speedAll with get(): float = jsNative and set(v: float): unit = jsNative
            static member filtersAll with get(): ResizeArray<Filter> = jsNative and set(v: ResizeArray<Filter>): unit = jsNative
            static member utils with get(): obj = jsNative and set(v: obj): unit = jsNative
//            static member add(alias: string, path: string): Sound = jsNative
            static member add(alias: string, options: Options): Sound = jsNative
            static member add(map: SoundMap, ?globalOptions: Options): obj = jsNative
            static member remove(alias: string): obj = jsNative
            static member togglePauseAll(): bool = jsNative
            static member pauseAll(): obj = jsNative
            static member resumeAll(): obj = jsNative
            static member toggleMuteAll(): bool = jsNative
            static member muteAll(): obj = jsNative
            static member unmuteAll(): obj = jsNative
            static member removeAll(): obj = jsNative
            static member stopAll(): obj = jsNative
            static member exists(alias: string, ?``assert``: bool): bool = jsNative
            static member find(alias: string): Sound = jsNative
            static member play(alias: string, ?options: U3<PlayOptions, CompleteCallback, string>): U2<IMediaInstance, Promise<IMediaInstance>> = jsNative
            static member stop(alias: string): Sound = jsNative
            static member pause(alias: string): Sound = jsNative
            static member resume(alias: string): Sound = jsNative
            static member volume(alias: string, ?volume: float): float = jsNative
            static member speed(alias: string, ?speed: float): float = jsNative
            static member duration(alias: string): float = jsNative
            static member init(): obj = jsNative
            static member close(): obj = jsNative

        module filters =
            type [<AllowNullLiteral>] [<Import("DistortionFilter","PIXI/sound/filters")>] DistortionFilter(?amount: float) =
                inherit PIXI.Filter<obj>()
                member __.amount with get(): float = jsNative and set(v: float): unit = jsNative
                member __.destroy(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("EqualizerFilter","PIXI/sound/filters")>] EqualizerFilter(?f32: float, ?f64: float, ?f125: float, ?f250: float, ?f500: float, ?f1k: float, ?f2k: float, ?f4k: float, ?f8k: float, ?f16k: float) =
                inherit PIXI.Filter<obj>()
                member __.F32 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F64 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F125 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F250 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F500 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F1K with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F2K with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F4K with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F8K with get(): float = jsNative and set(v: float): unit = jsNative
                member __.F16K with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bands with get(): ResizeArray<BiquadFilterNode> = jsNative and set(v: ResizeArray<BiquadFilterNode>): unit = jsNative
                member __.bandsMap with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.f32 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f64 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f125 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f250 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f500 with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f1k with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f2k with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f4k with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f8k with get(): float = jsNative and set(v: float): unit = jsNative
                member __.f16k with get(): float = jsNative and set(v: float): unit = jsNative
                member __.setGain(frequency: float, ?gain: float): unit = jsNative
                member __.getGain(frequency: float): float = jsNative
                member __.reset(): unit = jsNative
                member __.destroy(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("MonoFilter","PIXI/sound/filters")>] MonoFilter() =
                inherit PIXI.Filter<obj>()
                member __.destroy(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("ReverbFilter","PIXI/sound/filters")>] ReverbFilter(?seconds: float, ?decay: float, ?reverse: bool) =
                inherit PIXI.Filter<obj>()
                member __.seconds with get(): float = jsNative and set(v: float): unit = jsNative
                member __.decay with get(): float = jsNative and set(v: float): unit = jsNative
                member __.reverse with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.destroy(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("StereoFilter","PIXI/sound/filters")>] StereoFilter(?pan: float) =
                inherit PIXI.Filter<obj>()
                member __.pan with get(): float = jsNative and set(v: float): unit = jsNative
                member __.destroy(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("TelephoneFilter","PIXI/sound/filters")>] TelephoneFilter() =
                inherit PIXI.Filter<obj>()




        module htmlaudio =
            type [<AllowNullLiteral>] [<Import("HTMLAudioInstance","PIXI/sound/htmlaudio")>] HTMLAudioInstance(parent: HTMLAudioMedia) =
                inherit PIXI.utils.EventEmitter()
//                interface IMediaInstance
                member __.PADDING with get(): float = jsNative and set(v: float): unit = jsNative
                member __.id with get(): float = jsNative and set(v: float): unit = jsNative
                member __.progress with get(): float = jsNative and set(v: float): unit = jsNative
                member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
                member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.muted with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.init(media: HTMLAudioMedia): unit = jsNative
                member __.stop(): unit = jsNative
                member __.refresh(): unit = jsNative
                member __.refreshPaused(): unit = jsNative
                member __.play(options: PlayOptions): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.toString(): string = jsNative

            and [<AllowNullLiteral>] [<Import("HTMLAudioContext","PIXI/sound/htmlaudio")>] HTMLAudioContext() =
                inherit PIXI.utils.EventEmitter()
//                interface IMediaContext
                member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.muted with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
                member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.filters with get(): ResizeArray<Filter> = jsNative and set(v: ResizeArray<Filter>): unit = jsNative
                member __.audioContext with get(): AudioContext = jsNative and set(v: AudioContext): unit = jsNative
                member __.refresh(): unit = jsNative
                member __.refreshPaused(): unit = jsNative
                member __.toggleMute(): bool = jsNative
                member __.togglePause(): bool = jsNative
                member __.destroy(): unit = jsNative

            and [<AllowNullLiteral>] [<Import("HTMLAudioMedia","PIXI/sound/htmlaudio")>] HTMLAudioMedia() =
                inherit PIXI.utils.EventEmitter()
//                interface IMedia
                member __.parent with get(): Sound = jsNative and set(v: Sound): unit = jsNative
                member __.isPlayable with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
                member __.context with get(): HTMLAudioContext = jsNative and set(v: HTMLAudioContext): unit = jsNative
                member __.filters with get(): ResizeArray<Filter> = jsNative and set(v: ResizeArray<Filter>): unit = jsNative
                member __.source with get(): HTMLAudioElement = jsNative and set(v: HTMLAudioElement): unit = jsNative
                member __.init(parent: Sound): unit = jsNative
                member __.create(): HTMLAudioInstance = jsNative
                member __.destroy(): unit = jsNative
                member __.load(?callback: LoadedCallback): unit = jsNative



        module webaudio =
            type [<AllowNullLiteral>] [<Import("WebAudioContext","PIXI/sound/webaudio")>] WebAudioContext() =
                inherit PIXI.utils.EventEmitter()
//                interface IMediaContext
                member __.compressor with get(): DynamicsCompressorNode = jsNative and set(v: DynamicsCompressorNode): unit = jsNative
                member __.analyser with get(): AnalyserNode = jsNative and set(v: AnalyserNode): unit = jsNative
                member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.muted with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
                member __.events with get(): PIXI.utils.EventEmitter = jsNative and set(v: PIXI.utils.EventEmitter): unit = jsNative
                member __.AudioContext with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.OfflineAudioContext with get(): obj = jsNative and set(v: obj): unit = jsNative
                member __.audioContext with get(): AudioContext = jsNative and set(v: AudioContext): unit = jsNative
                member __.offlineContext with get(): OfflineAudioContext = jsNative and set(v: OfflineAudioContext): unit = jsNative
                member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.playEmptySound(): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.refresh(): unit = jsNative
                member __.refreshPaused(): unit = jsNative
                member __.toggleMute(): bool = jsNative
                member __.togglePause(): bool = jsNative
                member __.decode(arrayBuffer: ArrayBuffer, callback: Func<Error, AudioBuffer, unit>): unit = jsNative

            and [<AllowNullLiteral>] [<Import("WebAudioInstance","PIXI/sound/webaudio")>] WebAudioInstance(media: WebAudioMedia) =
                inherit PIXI.utils.EventEmitter()
  //              interface IMediaInstance
                member __.id with get(): float = jsNative and set(v: float): unit = jsNative
                member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
                member __.volume with get(): float = jsNative and set(v: float): unit = jsNative
                member __.muted with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.progress with get(): float = jsNative and set(v: float): unit = jsNative
                member __.paused with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.stop(): unit = jsNative
                member __.refresh(): unit = jsNative
                member __.refreshPaused(): unit = jsNative
                member __.play(options: PlayOptions): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.toString(): string = jsNative
                member __.init(media: WebAudioMedia): unit = jsNative

            and [<AllowNullLiteral>] [<Import("WebAudioMedia","PIXI/sound/webaudio")>] WebAudioMedia() =
//                interface IMedia
                member __.parent with get(): Sound = jsNative and set(v: Sound): unit = jsNative
                member __.source with get(): ArrayBuffer = jsNative and set(v: ArrayBuffer): unit = jsNative
                member __.context with get(): WebAudioContext = jsNative and set(v: WebAudioContext): unit = jsNative
                member __.isPlayable with get(): bool = jsNative and set(v: bool): unit = jsNative
                member __.filters with get(): ResizeArray<Filter> = jsNative and set(v: ResizeArray<Filter>): unit = jsNative
                member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
                member __.buffer with get(): AudioBuffer = jsNative and set(v: AudioBuffer): unit = jsNative
                member __.nodes with get(): WebAudioNodes = jsNative and set(v: WebAudioNodes): unit = jsNative
                member __.init(parent: Sound): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.create(): WebAudioInstance = jsNative
                member __.load(?callback: LoadedCallback): unit = jsNative

            and [<AllowNullLiteral>] SourceClone =
                abstract source: AudioBufferSourceNode with get, set
                abstract gain: GainNode with get, set

            and [<AllowNullLiteral>] [<Import("WebAudioNodes","PIXI/sound/webaudio")>] WebAudioNodes(context: WebAudioContext) =
//                interface Filterable
                member __.BUFFER_SIZE with get(): float = jsNative and set(v: float): unit = jsNative
                member __.bufferSource with get(): AudioBufferSourceNode = jsNative and set(v: AudioBufferSourceNode): unit = jsNative
                member __.script with get(): ScriptProcessorNode = jsNative and set(v: ScriptProcessorNode): unit = jsNative
                member __.gain with get(): GainNode = jsNative and set(v: GainNode): unit = jsNative
                member __.analyser with get(): AnalyserNode = jsNative and set(v: AnalyserNode): unit = jsNative
                member __.context with get(): WebAudioContext = jsNative and set(v: WebAudioContext): unit = jsNative
                member __.destroy(): unit = jsNative
                member __.cloneBufferSource(): SourceClone = jsNative


