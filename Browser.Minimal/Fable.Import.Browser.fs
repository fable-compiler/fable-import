namespace Fable.Import

open System
open Fable.Import.JS
open Fable.Core
open System

module Browser =

    type [<AllowNullLiteral>] ActivateEvent =
        inherit ExtendableEvent

    and [<AllowNullLiteral>] Algorithm =
        abstract name: string option with get, set

    and [<AllowNullLiteral>] AriaRequestEventInit =
        inherit EventInit
        abstract attributeName: string option with get, set
        abstract attributeValue: string option with get, set

    and [<AllowNullLiteral>] Body =
        abstract bodyUsed: bool with get, set
        abstract arrayBuffer: unit -> Promise<ArrayBuffer>
        abstract blob: unit -> Promise<Blob>
        abstract formData: unit -> Promise<FormData>
        abstract json: unit -> Promise<obj option>
        abstract text: unit -> Promise<string>

    and [<AllowNullLiteral>] Cache =
        abstract add: request: Request -> Promise<unit>
        abstract addAll: requestArray: Array<Request> -> Promise<unit>
        abstract delete: request: Request * ?options: CacheStorageOptions -> Promise<bool>
        abstract keys: ?request: Request * ?options: CacheStorageOptions -> Promise<Array<string>>
        abstract ``match``: request: Request * ?options: CacheStorageOptions -> Promise<Response>
        abstract matchAll: request: Request * ?options: CacheStorageOptions -> Promise<Array<Response>>
        abstract put: request: U2<Request, string> * response: Response -> Promise<unit>

    and [<AllowNullLiteral>] CacheStorage =
        abstract delete: cacheName: string -> Promise<bool>
        abstract has: cacheName: string -> Promise<bool>
        abstract keys: unit -> Promise<Array<string>>
        abstract ``match``: request: Request * ?options: CacheStorageOptions -> Promise<Response>
        abstract ``open``: cacheName: string -> Promise<Cache>

    and [<AllowNullLiteral>] CacheStorageOptions =
        abstract cacheName: string option with get, set
        abstract ignoreMethod: bool option with get, set
        abstract ignoreSearch: bool option with get, set
        abstract ignoreVary: bool option with get, set

    and [<AllowNullLiteral>] ClipboardEventInit =
        inherit EventInit
        abstract data: string option with get, set
        abstract dataType: string option with get, set

    and [<AllowNullLiteral>] CommandEventInit =
        inherit EventInit
        abstract commandName: string option with get, set
        abstract detail: string option with get, set

    and [<AllowNullLiteral>] CompositionEventInit =
        inherit UIEventInit
        abstract data: string option with get, set

    and [<AllowNullLiteral>] CustomEventInit =
        inherit EventInit
        abstract detail: obj option with get, set

    and [<AllowNullLiteral>] DeviceAccelerationDict =
        abstract x: float option with get, set
        abstract y: float option with get, set
        abstract z: float option with get, set

    and [<AllowNullLiteral>] DeviceRotationRateDict =
        abstract alpha: float option with get, set
        abstract beta: float option with get, set
        abstract gamma: float option with get, set


    and [<AllowNullLiteral>] EventInit =
        abstract bubbles: bool option with get, set
        abstract cancelable: bool option with get, set

    and [<AllowNullLiteral>] ExceptionInformation =
        abstract domain: string option with get, set

    and [<AllowNullLiteral>] ExtendableEvent =
        inherit Event
        abstract waitUntil: fn: Promise<obj option> -> unit

    and [<AllowNullLiteral>] FocusEventInit =
        inherit UIEventInit
        abstract relatedTarget: EventTarget option with get, set

    and [<AllowNullLiteral>] HashChangeEventInit =
        inherit EventInit
        abstract newURL: string option with get, set
        abstract oldURL: string option with get, set

    and [<AllowNullLiteral>] Headers =
        abstract append: name: string * value: string -> unit
        abstract delete: name: string -> unit
        abstract entries: unit -> Array<Array<string>>
        abstract get: name: string -> string
        abstract getAll: name: string -> Array<string>
        abstract has: name: string -> bool
        abstract keys: unit -> Array<string>
        abstract set: name: string * value: string -> unit
        abstract values: unit -> Array<string>

    and [<AllowNullLiteral>] HeadersStatic =
        [<Emit "new $0($1...)">] abstract Create: ?init: obj option -> Headers

    and [<AllowNullLiteral>] IExports =
        abstract Headers: HeadersStatic
        abstract Request: RequestStatic
        abstract Response: ResponseStatic
        abstract fetch: request: U2<Request, string> -> Promise<Response>
        abstract skipWaiting: unit -> unit

    and [<AllowNullLiteral>] KeyAlgorithm =
        abstract name: string option with get, set

    and [<AllowNullLiteral>] KeyboardEventInit =
        inherit SharedKeyboardAndMouseEventInit
        abstract key: string option with get, set
        abstract location: float option with get, set
        abstract repeat: bool option with get, set

    and [<AllowNullLiteral>] MouseEventInit =
        inherit SharedKeyboardAndMouseEventInit
        abstract screenX: float option with get, set
        abstract screenY: float option with get, set
        abstract clientX: float option with get, set
        abstract clientY: float option with get, set
        abstract button: float option with get, set
        abstract buttons: float option with get, set
        abstract relatedTarget: EventTarget option with get, set

    and [<AllowNullLiteral>] MutationObserverInit =
        abstract childList: bool option with get, set
        abstract attributes: bool option with get, set
        abstract characterData: bool option with get, set
        abstract subtree: bool option with get, set
        abstract attributeOldValue: bool option with get, set
        abstract characterDataOldValue: bool option with get, set
        abstract attributeFilter: ResizeArray<string> option with get, set

    and [<AllowNullLiteral>] ObjectURLOptions =
        abstract oneTimeOnly: bool option with get, set

    and [<AllowNullLiteral>] PointerEventInit =
        inherit MouseEventInit
        abstract pointerId: float option with get, set
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract pressure: float option with get, set
        abstract tiltX: float option with get, set
        abstract tiltY: float option with get, set
        abstract pointerType: string option with get, set
        abstract isPrimary: bool option with get, set

    and [<AllowNullLiteral>] PositionOptions =
        abstract enableHighAccuracy: bool option with get, set
        abstract timeout: float option with get, set
        abstract maximumAge: float option with get, set

    and [<AllowNullLiteral>] SharedKeyboardAndMouseEventInit =
        inherit UIEventInit
        abstract ctrlKey: bool option with get, set
        abstract shiftKey: bool option with get, set
        abstract altKey: bool option with get, set
        abstract metaKey: bool option with get, set
        abstract keyModifierStateAltGraph: bool option with get, set
        abstract keyModifierStateCapsLock: bool option with get, set
        abstract keyModifierStateFn: bool option with get, set
        abstract keyModifierStateFnLock: bool option with get, set
        abstract keyModifierStateHyper: bool option with get, set
        abstract keyModifierStateNumLock: bool option with get, set
        abstract keyModifierStateOS: bool option with get, set
        abstract keyModifierStateScrollLock: bool option with get, set
        abstract keyModifierStateSuper: bool option with get, set
        abstract keyModifierStateSymbol: bool option with get, set
        abstract keyModifierStateSymbolLock: bool option with get, set

    and [<AllowNullLiteral>] StoreExceptionsInformation =
        inherit ExceptionInformation
        abstract siteName: string option with get, set
        abstract explanationString: string option with get, set
        abstract detailURI: string option with get, set

    and [<AllowNullLiteral>] StoreSiteSpecificExceptionsInformation =
        inherit StoreExceptionsInformation
        abstract arrayOfDomainStrings: ResizeArray<string> option with get, set



    and [<AllowNullLiteral>] UIEventInit =
        inherit EventInit
        abstract view: Window option with get, set
        abstract detail: float option with get, set

    and [<AllowNullLiteral>] WebGLContextAttributes =
        abstract alpha: bool option with get, set
        abstract depth: bool option with get, set
        abstract stencil: bool option with get, set
        abstract antialias: bool option with get, set
        abstract premultipliedAlpha: bool option with get, set
        abstract preserveDrawingBuffer: bool option with get, set

    and [<AllowNullLiteral>] WebGLContextEventInit =
        inherit EventInit
        abstract statusMessage: string option with get, set

    and [<AllowNullLiteral>] WheelEventInit =
        inherit MouseEventInit
        abstract deltaX: float option with get, set
        abstract deltaY: float option with get, set
        abstract deltaZ: float option with get, set
        abstract deltaMode: float option with get, set


    and [<AllowNullLiteral>] ANGLE_instanced_arrays =
        abstract VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE: float with get, set
        abstract drawArraysInstancedANGLE: mode: float * first: float * count: float * primcount: float -> unit
        abstract drawElementsInstancedANGLE: mode: float * count: float * ``type``: float * offset: float * primcount: float -> unit
        abstract vertexAttribDivisorANGLE: index: float * divisor: float -> unit

    and [<AllowNullLiteral>] ANGLE_instanced_arraysType =
        abstract prototype: ANGLE_instanced_arrays with get, set
        abstract VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ANGLE_instanced_arrays

    and [<AllowNullLiteral>] AnalyserNode =
        inherit AudioNode
        abstract fftSize: int with get, set
        abstract frequencyBinCount: int with get
        abstract maxDecibels: float with get, set
        abstract minDecibels: float with get, set
        abstract smoothingTimeConstant: float with get, set
        abstract getByteFrequencyData: array: Uint8Array -> unit
        abstract getByteTimeDomainData: array: Uint8Array -> unit
        abstract getFloatFrequencyData: array: Float32Array -> unit
        abstract getFloatTimeDomainData: array: Float32Array -> unit

    and [<AllowNullLiteral>] AnalyserNodeType =
        abstract prototype: AnalyserNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AnalyserNode

    and [<AllowNullLiteral>] AnimationEvent =
        inherit Event
        abstract animationName: string with get, set
        abstract elapsedTime: float with get, set
        abstract initAnimationEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * animationNameArg: string * elapsedTimeArg: float -> unit

    and [<AllowNullLiteral>] AnimationEventType =
        abstract prototype: AnimationEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AnimationEvent

    and [<AllowNullLiteral>] ApplicationCache =
        inherit EventTarget
        abstract oncached: (Event -> 'Out) with get, set
        abstract onchecking: (Event -> 'Out) with get, set
        abstract ondownloading: (Event -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onnoupdate: (Event -> 'Out) with get, set
        abstract onobsolete: (Event -> 'Out) with get, set
        abstract onprogress: (ProgressEvent -> 'Out) with get, set
        abstract onupdateready: (Event -> 'Out) with get, set
        abstract status: float with get, set
        abstract CHECKING: float with get, set
        abstract DOWNLOADING: float with get, set
        abstract IDLE: float with get, set
        abstract OBSOLETE: float with get, set
        abstract UNCACHED: float with get, set
        abstract UPDATEREADY: float with get, set
        abstract abort: unit -> unit
        abstract swapCache: unit -> unit
        abstract update: unit -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] ApplicationCacheType =
        abstract prototype: ApplicationCache with get, set
        abstract CHECKING: float with get, set
        abstract DOWNLOADING: float with get, set
        abstract IDLE: float with get, set
        abstract OBSOLETE: float with get, set
        abstract UNCACHED: float with get, set
        abstract UPDATEREADY: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ApplicationCache

    and [<AllowNullLiteral>] AriaRequestEvent =
        inherit Event
        abstract attributeName: string with get, set
        abstract attributeValue: string with get, set

    and [<AllowNullLiteral>] AriaRequestEventType =
        abstract prototype: AriaRequestEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: AriaRequestEventInit -> AriaRequestEvent

    and [<AllowNullLiteral>] Attr =
        inherit Node
        abstract name: string with get, set
        abstract ownerElement: Element with get, set
        abstract specified: bool with get, set
        abstract value: string with get, set

    and [<AllowNullLiteral>] AttrType =
        abstract prototype: Attr with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Attr

    and [<AllowNullLiteral>] AudioBuffer =
        abstract duration: float with get
        abstract length: int with get
        abstract numberOfChannels: int with get
        abstract sampleRate: float with get
        abstract getChannelData: channel: float -> Float32Array
        abstract copyFromChannel: destination: Float32Array * channelNumber: int * ?startInChannel: int -> unit
        abstract copyToChannel: source: Float32Array * channelNumber: int * ?startInChannel: int -> unit

    and [<AllowNullLiteral>] AudioBufferType =
        abstract prototype: AudioBuffer with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioBuffer

    and [<AllowNullLiteral>] AudioBufferSourceNode =
        inherit AudioNode
        abstract buffer: AudioBuffer with get, set
        abstract loop: bool with get, set
        abstract loopEnd: float with get, set
        abstract loopStart: float with get, set
        abstract onended: (Event -> 'Out) with get, set
        abstract playbackRate: AudioParam with get
        abstract detune: AudioParam with get
        abstract start: ?``when``: float * ?offset: float * ?duration: float -> unit
        abstract stop: ?``when``: float -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] AudioBufferSourceNodeType =
        abstract prototype: AudioBufferSourceNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioBufferSourceNode

    and [<AllowNullLiteral>] AudioContext =
        inherit BaseAudioContext
        abstract createMediaElementSource: mediaElement: HTMLMediaElement -> MediaElementAudioSourceNode
        abstract createMediaStreamSource: mediaStream: MediaStream -> MediaStreamAudioSourceNode
        abstract createMediaStreamDestination: unit -> MediaStreamAudioDestinationNode

    and [<AllowNullLiteral>] AudioContextType =
        abstract prototype: AudioContext with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioContext

    and [<AllowNullLiteral>] AudioContextOptions =
        abstract playbackCategory : AudioContextPlaybackCategory

    and [<StringEnum>] AudioContextPlaybackCategory =
        | Balanced
        | Interactive
        | Playback

    and [<StringEnum>] AudioContextState =
        | Suspended
        | Running
        | Closed

    and [<AllowNullLiteral>] AudioDestinationNode =
        inherit AudioNode
        abstract maxChannelCount: int with get

    and [<AllowNullLiteral>] AudioDestinationNodeType =
        abstract prototype: AudioDestinationNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioDestinationNode

    and [<AllowNullLiteral>] AudioListener =
        abstract setOrientation: x: float * y: float * z: float * xUp: float * yUp: float * zUp: float -> unit
        abstract setPosition: x: float * y: float * z: float -> unit

    and [<AllowNullLiteral>] AudioListenerType =
        abstract prototype: AudioListener with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioListener

    and [<AllowNullLiteral>] AudioNode =
        inherit EventTarget
        abstract channelCount: int with get,set
        abstract channelCountMode: ChannelCountMode with get, set
        abstract channelInterpretation: ChannelInterpretation with get, set
        abstract context: AudioContext with get
        abstract numberOfInputs: int with get
        abstract numberOfOutputs: int with get
        abstract connect: destination: AudioNode * ?output: int * ?input: int -> unit
        abstract connect: destination: AudioParam * ?output: int -> unit
        abstract disconnect: ?output: int -> unit
        abstract disconnect: destination: AudioNode * ?output: int * ?input: int -> unit
        abstract disconnect: destination: AudioParam * ?output: int -> unit

    and [<AllowNullLiteral>] AudioNodeType =
        abstract prototype: AudioNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioNode

    and [<AllowNullLiteral>] AudioParam =
        abstract defaultValue: float with get
        abstract value: float with get, set
        abstract cancelScheduledValues: startTime: float -> AudioParam
        abstract exponentialRampToValueAtTime: value: float * endTime: float -> AudioParam
        abstract linearRampToValueAtTime: value: float * endTime: float -> AudioParam
        abstract setTargetAtTime: target: float * startTime: float * timeConstant: float -> AudioParam
        abstract setValueAtTime: value: float * startTime: float -> AudioParam
        abstract setValueCurveAtTime: values: Float32Array * startTime: float * duration: float -> AudioParam

    and [<AllowNullLiteral>] AudioParamType =
        abstract prototype: AudioParam with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioParam

    and [<AllowNullLiteral>] AudioProcessingEvent =
        inherit Event
        abstract inputBuffer: AudioBuffer with get
        abstract outputBuffer: AudioBuffer with get
        abstract playbackTime: float with get

    and [<AllowNullLiteral>] AudioProcessingEventType =
        abstract prototype: AudioProcessingEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioProcessingEvent

    and [<AllowNullLiteral>] AudioTrack =
        abstract enabled: bool with get, set
        abstract id: string with get, set
        abstract kind: string with get, set
        abstract label: string with get, set
        abstract language: string with get, set
        abstract sourceBuffer: SourceBuffer with get, set

    and [<AllowNullLiteral>] AudioTrackType =
        abstract prototype: AudioTrack with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioTrack

    and [<AllowNullLiteral>] AudioTrackList =
        inherit EventTarget
        abstract length: float with get, set
        abstract onaddtrack: (TrackEvent -> 'Out) with get, set
        abstract onchange: (Event -> 'Out) with get, set
        abstract onremovetrack: (TrackEvent -> 'Out) with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> AudioTrack with get, set
        abstract getTrackById: id: string -> AudioTrack
        abstract item: index: float -> AudioTrack
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] AudioTrackListType =
        abstract prototype: AudioTrackList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioTrackList

    and [<AllowNullLiteral>] AudioWorker =
        inherit Worker
        abstract terminate: unit -> unit
        abstract postMessage: message: obj * ?transfer: obj
        abstract parameters: AudioWorkerParamDescriptor array with get
        abstract onerror: (Event -> 'Out) with get, set
        abstract onmessage: (Event -> 'Out) with get, set
        abstract onloaded: (Event -> 'Out) with get, set
        abstract createNode: numberOfInputs: int * numberOfOutputs: int -> AudioWorkerNode
        abstract addParameter: name: string * defaultValue: float -> AudioParam
        abstract removeParameter: name: string -> unit

    and [<AllowNullLiteral>] AudioWorkerGlobalScope =
        abstract sampleRate: float with get
        abstract addParameter: name: string * defaultValue: float -> AudioParam
        abstract removeParameter: name: string -> unit
        abstract onnodecreate: (Event -> 'Out) with get, set
        abstract parameters: AudioWorkerParamDescriptor array with get

    and [<AllowNullLiteral>] AudioWorkerGlobalScopeType =
        abstract prototype: AudioWorkerGlobalScope with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioWorkerGlobalScope

    and [<AllowNullLiteral>] AudioWorkerNode =
        inherit AudioNode
        abstract postMessage: message: obj * ?transfer: obj
        abstract onmessage: (Event -> 'Out) with get, set

    and [<AllowNullLiteral>] AudioWorkerNodeType =
        abstract prototype: AudioWorkerNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioWorkerNode

    and [<AllowNullLiteral>] AudioWorkerNodeProcessor =
        inherit EventTarget
        abstract onmessage: (Event -> 'Out) with get, set
        abstract postMessage: message: obj * ?transfer: obj

    and [<AllowNullLiteral>] AudioWorkerNodeProcessorType =
        abstract prototype: AudioWorkerNodeProcessor with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioWorkerNodeProcessor

    and [<AllowNullLiteral>] AudioWorkerParamDescriptor =
        abstract name: string with get
        abstract defaultValue: float with get

    and [<AllowNullLiteral>] AudioWorkerType =
        abstract prototype: AudioWorker with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> AudioWorker

     and [<AllowNullLiteral>] BarProp =
        abstract visible: bool with get, set

    and [<AllowNullLiteral>] BarPropType =
        abstract prototype: BarProp with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> BarProp

    and [<AllowNullLiteral>] BaseAudioContext =
        inherit EventTarget
        abstract destination: AudioDestinationNode with get
        abstract sampleRate: float with get
        abstract currentTime: float with get
        abstract listener: AudioListener with get
        abstract suspend: unit -> Promise<unit>
        abstract resume: unit -> Promise<unit>
        abstract close: unit -> Promise<unit>
        abstract state: AudioContextState with get
        abstract onstatechange: (Event -> 'Out) with get, set
        abstract createBuffer: numberOfChannels: int * length: int * sampleRate: float -> AudioBuffer
        abstract decodeAudioData: audioData: ArrayBuffer * ?successCallback: DecodeSuccessCallback * ?errorCallback: DecodeErrorCallback -> unit
        abstract createBufferSource: unit -> AudioBufferSourceNode
        abstract createAudioWorker: string -> Promise<AudioWorker>
        abstract createScriptProcessor: ?bufferSize: int * ?numberOfInputChannels: int * ?numberOfOutputChannels: int -> ScriptProcessorNode
        abstract createAnalyser: unit -> AnalyserNode
        abstract createGain: unit -> GainNode
        abstract createDelay: ?maxDelayTime: float -> DelayNode
        abstract createBiquadFilter: unit -> BiquadFilterNode
        abstract createIIRFilter: feedforward: Float32Array * feedback: Float32Array -> IIRFilterNode
        abstract createWaveShaper: unit -> WaveShaperNode
        abstract createPanner: unit -> PannerNode
        abstract createSpatialPanner: unit -> SpatialPannerNode
        abstract createStereoPanner: unit -> StereoPannerNode
        abstract createConvolver: unit -> ConvolverNode
        abstract createChannelSplitter: ?numberOfOutputs: int -> ChannelSplitterNode
        abstract createChannelMerger: ?numberOfInputs: int -> ChannelMergerNode
        abstract createDynamicsCompressor: unit -> DynamicsCompressorNode
        abstract createOscillator: unit -> OscillatorNode
        abstract createPeriodicWave: real: Float32Array * imag: Float32Array * ?constraints: PeriodicWaveConstraints -> PeriodicWave

    and [<AllowNullLiteral>] BaseAudioContextType =
        abstract prototype: BaseAudioContext with get, set
        [<Emit("new $0($1...)")>] abstract Create: ?contextOptions: AudioContextOptions -> AudioContext

    and [<AllowNullLiteral>] BeforeUnloadEvent =
        inherit Event
        abstract returnValue: obj with get, set

    and [<AllowNullLiteral>] BeforeUnloadEventType =
        abstract prototype: BeforeUnloadEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> BeforeUnloadEvent

    and [<AllowNullLiteral>] BiquadFilterNode =
        inherit AudioNode
        abstract Q: AudioParam with get
        abstract detune: AudioParam with get
        abstract frequency: AudioParam with get
        abstract gain: AudioParam with get
        abstract ``type``: BiquadFilterType with get, set
        abstract getFrequencyResponse: frequencyHz: Float32Array * magResponse: Float32Array * phaseResponse: Float32Array -> unit

    and [<AllowNullLiteral>] BiquadFilterNodeType =
        abstract prototype: BiquadFilterNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> BiquadFilterNode

    and [<StringEnum>] BiquadFilterType =
        | [<CompiledName("lowpass")>] LowPass
        | [<CompiledName("highpass")>] HighPass
        | [<CompiledName("bandpass")>] BandPass
        | [<CompiledName("lowshelf")>] LowShelf
        | [<CompiledName("highshelf")>] HighShelf
        | Peaking
        | Notch
        | [<CompiledName("allpass")>] AllPass

    and [<AllowNullLiteral>] Blob =
        abstract size: float with get, set
        abstract ``type``: string with get, set
        abstract slice: ?start: float * ?``end``: float * ?contentType: string -> Blob

    and [<AllowNullLiteral>] BlobType =
        abstract prototype: Blob with get, set
        [<Emit("new $0($1...)")>] abstract Create: ?blobParts: ResizeArray<obj> * ?options: BlobPropertyBag -> Blob

    and [<AllowNullLiteral>] CDATASection =
        inherit Text


    and [<AllowNullLiteral>] CDATASectionType =
        abstract prototype: CDATASection with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CDATASection

    // and [<AllowNullLiteral>] CSS =
    //     abstract supports: property: string * ?value: string -> bool

    // and [<AllowNullLiteral>] CSSConditionRule =
    //     inherit CSSGroupingRule
    //     abstract conditionText: string with get, set

    // and [<AllowNullLiteral>] CSSConditionRuleType =
    //     abstract prototype: CSSConditionRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSConditionRule

    // and [<AllowNullLiteral>] CSSFontFaceRule =
    //     inherit CSSRule
    //     abstract style: CSSStyleDeclaration with get, set

    // and [<AllowNullLiteral>] CSSFontFaceRuleType =
    //     abstract prototype: CSSFontFaceRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSFontFaceRule

    // and [<AllowNullLiteral>] CSSGroupingRule =
    //     inherit CSSRule
    //     abstract cssRules: CSSRuleList with get, set
    //     abstract deleteRule: ?index: float -> unit
    //     abstract insertRule: rule: string * ?index: float -> float

    // and [<AllowNullLiteral>] CSSGroupingRuleType =
    //     abstract prototype: CSSGroupingRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSGroupingRule

    // and [<AllowNullLiteral>] CSSImportRule =
    //     inherit CSSRule
    //     abstract href: string with get, set
    //     abstract media: MediaList with get, set
    //     abstract styleSheet: CSSStyleSheet with get, set

    // and [<AllowNullLiteral>] CSSImportRuleType =
    //     abstract prototype: CSSImportRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSImportRule

    // and [<AllowNullLiteral>] CSSKeyframeRule =
    //     inherit CSSRule
    //     abstract keyText: string with get, set
    //     abstract style: CSSStyleDeclaration with get, set

    // and [<AllowNullLiteral>] CSSKeyframeRuleType =
    //     abstract prototype: CSSKeyframeRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSKeyframeRule

    // and [<AllowNullLiteral>] CSSKeyframesRule =
    //     inherit CSSRule
    //     abstract cssRules: CSSRuleList with get, set
    //     abstract name: string with get, set
    //     abstract appendRule: rule: string -> unit
    //     abstract deleteRule: rule: string -> unit
    //     abstract findRule: rule: string -> CSSKeyframeRule

    // and [<AllowNullLiteral>] CSSKeyframesRuleType =
    //     abstract prototype: CSSKeyframesRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSKeyframesRule

    // and [<AllowNullLiteral>] CSSMediaRule =
    //     inherit CSSConditionRule
    //     abstract media: MediaList with get, set

    // and [<AllowNullLiteral>] CSSMediaRuleType =
    //     abstract prototype: CSSMediaRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSMediaRule

    // and [<AllowNullLiteral>] CSSNamespaceRule =
    //     inherit CSSRule
    //     abstract namespaceURI: string with get, set
    //     abstract prefix: string with get, set

    // and [<AllowNullLiteral>] CSSNamespaceRuleType =
    //     abstract prototype: CSSNamespaceRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSNamespaceRule

    // and [<AllowNullLiteral>] CSSPageRule =
    //     inherit CSSRule
    //     abstract pseudoClass: string with get, set
    //     abstract selector: string with get, set
    //     abstract selectorText: string with get, set
    //     abstract style: CSSStyleDeclaration with get, set

    // and [<AllowNullLiteral>] CSSPageRuleType =
    //     abstract prototype: CSSPageRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSPageRule

    // and [<AllowNullLiteral>] CSSRule =
    //     abstract cssText: string with get, set
    //     abstract parentRule: CSSRule with get, set
    //     abstract parentStyleSheet: CSSStyleSheet with get, set
    //     abstract ``type``: float with get, set
    //     abstract CHARSET_RULE: float with get, set
    //     abstract FONT_FACE_RULE: float with get, set
    //     abstract IMPORT_RULE: float with get, set
    //     abstract KEYFRAMES_RULE: float with get, set
    //     abstract KEYFRAME_RULE: float with get, set
    //     abstract MEDIA_RULE: float with get, set
    //     abstract NAMESPACE_RULE: float with get, set
    //     abstract PAGE_RULE: float with get, set
    //     abstract STYLE_RULE: float with get, set
    //     abstract SUPPORTS_RULE: float with get, set
    //     abstract UNKNOWN_RULE: float with get, set
    //     abstract VIEWPORT_RULE: float with get, set

    // and [<AllowNullLiteral>] CSSRuleType =
    //     abstract prototype: CSSRule with get, set
    //     abstract CHARSET_RULE: float with get, set
    //     abstract FONT_FACE_RULE: float with get, set
    //     abstract IMPORT_RULE: float with get, set
    //     abstract KEYFRAMES_RULE: float with get, set
    //     abstract KEYFRAME_RULE: float with get, set
    //     abstract MEDIA_RULE: float with get, set
    //     abstract NAMESPACE_RULE: float with get, set
    //     abstract PAGE_RULE: float with get, set
    //     abstract STYLE_RULE: float with get, set
    //     abstract SUPPORTS_RULE: float with get, set
    //     abstract UNKNOWN_RULE: float with get, set
    //     abstract VIEWPORT_RULE: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSRule

    // and [<AllowNullLiteral>] CSSRuleList =
    //     abstract length: float with get, set
    //     [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> CSSRule with get, set
    //     abstract item: index: float -> CSSRule

    // and [<AllowNullLiteral>] CSSRuleListType =
    //     abstract prototype: CSSRuleList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSRuleList

    // and [<AllowNullLiteral>] CSSStyleDeclaration =
    //     abstract alignContent: string with get, set
    //     abstract alignItems: string with get, set
    //     abstract alignSelf: string with get, set
    //     abstract alignmentBaseline: string with get, set
    //     abstract animation: string with get, set
    //     abstract animationDelay: string with get, set
    //     abstract animationDirection: string with get, set
    //     abstract animationDuration: string with get, set
    //     abstract animationFillMode: string with get, set
    //     abstract animationIterationCount: string with get, set
    //     abstract animationName: string with get, set
    //     abstract animationPlayState: string with get, set
    //     abstract animationTimingFunction: string with get, set
    //     abstract backfaceVisibility: string with get, set
    //     abstract background: string with get, set
    //     abstract backgroundAttachment: string with get, set
    //     abstract backgroundClip: string with get, set
    //     abstract backgroundColor: string with get, set
    //     abstract backgroundImage: string with get, set
    //     abstract backgroundOrigin: string with get, set
    //     abstract backgroundPosition: string with get, set
    //     abstract backgroundPositionX: string with get, set
    //     abstract backgroundPositionY: string with get, set
    //     abstract backgroundRepeat: string with get, set
    //     abstract backgroundSize: string with get, set
    //     abstract baselineShift: string with get, set
    //     abstract border: string with get, set
    //     abstract borderBottom: string with get, set
    //     abstract borderBottomColor: string with get, set
    //     abstract borderBottomLeftRadius: string with get, set
    //     abstract borderBottomRightRadius: string with get, set
    //     abstract borderBottomStyle: string with get, set
    //     abstract borderBottomWidth: string with get, set
    //     abstract borderCollapse: string with get, set
    //     abstract borderColor: string with get, set
    //     abstract borderImage: string with get, set
    //     abstract borderImageOutset: string with get, set
    //     abstract borderImageRepeat: string with get, set
    //     abstract borderImageSlice: string with get, set
    //     abstract borderImageSource: string with get, set
    //     abstract borderImageWidth: string with get, set
    //     abstract borderLeft: string with get, set
    //     abstract borderLeftColor: string with get, set
    //     abstract borderLeftStyle: string with get, set
    //     abstract borderLeftWidth: string with get, set
    //     abstract borderRadius: string with get, set
    //     abstract borderRight: string with get, set
    //     abstract borderRightColor: string with get, set
    //     abstract borderRightStyle: string with get, set
    //     abstract borderRightWidth: string with get, set
    //     abstract borderSpacing: string with get, set
    //     abstract borderStyle: string with get, set
    //     abstract borderTop: string with get, set
    //     abstract borderTopColor: string with get, set
    //     abstract borderTopLeftRadius: string with get, set
    //     abstract borderTopRightRadius: string with get, set
    //     abstract borderTopStyle: string with get, set
    //     abstract borderTopWidth: string with get, set
    //     abstract borderWidth: string with get, set
    //     abstract bottom: string with get, set
    //     abstract boxShadow: string with get, set
    //     abstract boxSizing: string with get, set
    //     abstract breakAfter: string with get, set
    //     abstract breakBefore: string with get, set
    //     abstract breakInside: string with get, set
    //     abstract captionSide: string with get, set
    //     abstract clear: string with get, set
    //     abstract clip: string with get, set
    //     abstract clipPath: string with get, set
    //     abstract clipRule: string with get, set
    //     abstract color: string with get, set
    //     abstract colorInterpolationFilters: string with get, set
    //     abstract columnCount: obj with get, set
    //     abstract columnFill: string with get, set
    //     abstract columnGap: obj with get, set
    //     abstract columnRule: string with get, set
    //     abstract columnRuleColor: obj with get, set
    //     abstract columnRuleStyle: string with get, set
    //     abstract columnRuleWidth: obj with get, set
    //     abstract columnSpan: string with get, set
    //     abstract columnWidth: obj with get, set
    //     abstract columns: string with get, set
    //     abstract content: string with get, set
    //     abstract counterIncrement: string with get, set
    //     abstract counterReset: string with get, set
    //     abstract cssFloat: string with get, set
    //     abstract cssText: string with get, set
    //     abstract cursor: string with get, set
    //     abstract direction: string with get, set
    //     abstract display: string with get, set
    //     abstract dominantBaseline: string with get, set
    //     abstract emptyCells: string with get, set
    //     abstract enableBackground: string with get, set
    //     abstract fill: string with get, set
    //     abstract fillOpacity: string with get, set
    //     abstract fillRule: string with get, set
    //     abstract filter: string with get, set
    //     abstract flex: string with get, set
    //     abstract flexBasis: string with get, set
    //     abstract flexDirection: string with get, set
    //     abstract flexFlow: string with get, set
    //     abstract flexGrow: string with get, set
    //     abstract flexShrink: string with get, set
    //     abstract flexWrap: string with get, set
    //     abstract floodColor: string with get, set
    //     abstract floodOpacity: string with get, set
    //     abstract font: string with get, set
    //     abstract fontFamily: string with get, set
    //     abstract fontFeatureSettings: string with get, set
    //     abstract fontSize: string with get, set
    //     abstract fontSizeAdjust: string with get, set
    //     abstract fontStretch: string with get, set
    //     abstract fontStyle: string with get, set
    //     abstract fontVariant: string with get, set
    //     abstract fontWeight: string with get, set
    //     abstract glyphOrientationHorizontal: string with get, set
    //     abstract glyphOrientationVertical: string with get, set
    //     abstract height: string with get, set
    //     abstract imeMode: string with get, set
    //     abstract justifyContent: string with get, set
    //     abstract kerning: string with get, set
    //     abstract left: string with get, set
    //     abstract length: float with get, set
    //     abstract letterSpacing: string with get, set
    //     abstract lightingColor: string with get, set
    //     abstract lineHeight: string with get, set
    //     abstract listStyle: string with get, set
    //     abstract listStyleImage: string with get, set
    //     abstract listStylePosition: string with get, set
    //     abstract listStyleType: string with get, set
    //     abstract margin: string with get, set
    //     abstract marginBottom: string with get, set
    //     abstract marginLeft: string with get, set
    //     abstract marginRight: string with get, set
    //     abstract marginTop: string with get, set
    //     abstract marker: string with get, set
    //     abstract markerEnd: string with get, set
    //     abstract markerMid: string with get, set
    //     abstract markerStart: string with get, set
    //     abstract mask: string with get, set
    //     abstract maxHeight: string with get, set
    //     abstract maxWidth: string with get, set
    //     abstract minHeight: string with get, set
    //     abstract minWidth: string with get, set
    //     abstract opacity: string with get, set
    //     abstract order: string with get, set
    //     abstract orphans: string with get, set
    //     abstract outline: string with get, set
    //     abstract outlineColor: string with get, set
    //     abstract outlineStyle: string with get, set
    //     abstract outlineWidth: string with get, set
    //     abstract overflow: string with get, set
    //     abstract overflowX: string with get, set
    //     abstract overflowY: string with get, set
    //     abstract padding: string with get, set
    //     abstract paddingBottom: string with get, set
    //     abstract paddingLeft: string with get, set
    //     abstract paddingRight: string with get, set
    //     abstract paddingTop: string with get, set
    //     abstract pageBreakAfter: string with get, set
    //     abstract pageBreakBefore: string with get, set
    //     abstract pageBreakInside: string with get, set
    //     abstract parentRule: CSSRule with get, set
    //     abstract perspective: string with get, set
    //     abstract perspectiveOrigin: string with get, set
    //     abstract pointerEvents: string with get, set
    //     abstract position: string with get, set
    //     abstract quotes: string with get, set
    //     abstract right: string with get, set
    //     abstract rubyAlign: string with get, set
    //     abstract rubyOverhang: string with get, set
    //     abstract rubyPosition: string with get, set
    //     abstract stopColor: string with get, set
    //     abstract stopOpacity: string with get, set
    //     abstract stroke: string with get, set
    //     abstract strokeDasharray: string with get, set
    //     abstract strokeDashoffset: string with get, set
    //     abstract strokeLinecap: string with get, set
    //     abstract strokeLinejoin: string with get, set
    //     abstract strokeMiterlimit: string with get, set
    //     abstract strokeOpacity: string with get, set
    //     abstract strokeWidth: string with get, set
    //     abstract tableLayout: string with get, set
    //     abstract textAlign: string with get, set
    //     abstract textAlignLast: string with get, set
    //     abstract textAnchor: string with get, set
    //     abstract textDecoration: string with get, set
    //     abstract textFillColor: string with get, set
    //     abstract textIndent: string with get, set
    //     abstract textJustify: string with get, set
    //     abstract textKashida: string with get, set
    //     abstract textKashidaSpace: string with get, set
    //     abstract textOverflow: string with get, set
    //     abstract textShadow: string with get, set
    //     abstract textTransform: string with get, set
    //     abstract textUnderlinePosition: string with get, set
    //     abstract top: string with get, set
    //     abstract touchAction: string with get, set
    //     abstract transform: string with get, set
    //     abstract transformOrigin: string with get, set
    //     abstract transformStyle: string with get, set
    //     abstract transition: string with get, set
    //     abstract transitionDelay: string with get, set
    //     abstract transitionDuration: string with get, set
    //     abstract transitionProperty: string with get, set
    //     abstract transitionTimingFunction: string with get, set
    //     abstract unicodeBidi: string with get, set
    //     abstract verticalAlign: string with get, set
    //     abstract visibility: string with get, set
    //     abstract whiteSpace: string with get, set
    //     abstract widows: string with get, set
    //     abstract width: string with get, set
    //     abstract wordBreak: string with get, set
    //     abstract wordSpacing: string with get, set
    //     abstract wordWrap: string with get, set
    //     abstract writingMode: string with get, set
    //     abstract zIndex: string with get, set
    //     abstract zoom: string with get, set
    //     [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
    //     abstract getPropertyPriority: propertyName: string -> string
    //     abstract getPropertyValue: propertyName: string -> string
    //     abstract item: index: float -> string
    //     abstract removeProperty: propertyName: string -> string
    //     abstract setProperty: propertyName: string * value: string * ?priority: string -> unit

    // and [<AllowNullLiteral>] CSSStyleDeclarationType =
    //     abstract prototype: CSSStyleDeclaration with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleDeclaration

    // and [<AllowNullLiteral>] CSSStyleRule =
    //     inherit CSSRule
    //     abstract readOnly: bool with get, set
    //     abstract selectorText: string with get, set
    //     abstract style: CSSStyleDeclaration with get, set

    // and [<AllowNullLiteral>] CSSStyleRuleType =
    //     abstract prototype: CSSStyleRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleRule

    // and [<AllowNullLiteral>] CSSStyleSheet =
    //     inherit StyleSheet
    //     abstract cssRules: CSSRuleList with get, set
    //     abstract cssText: string with get, set
    //     abstract href: string with get, set
    //     abstract id: string with get, set
    //     abstract imports: StyleSheetList with get, set
    //     abstract isAlternate: bool with get, set
    //     abstract isPrefAlternate: bool with get, set
    //     abstract ownerRule: CSSRule with get, set
    //     abstract owningElement: Element with get, set
    //     abstract pages: StyleSheetPageList with get, set
    //     abstract readOnly: bool with get, set
    //     abstract rules: CSSRuleList with get, set
    //     abstract addImport: bstrURL: string * ?lIndex: float -> float
    //     abstract addPageRule: bstrSelector: string * bstrStyle: string * ?lIndex: float -> float
    //     abstract addRule: bstrSelector: string * ?bstrStyle: string * ?lIndex: float -> float
    //     abstract deleteRule: ?index: float -> unit
    //     abstract insertRule: rule: string * ?index: float -> float
    //     abstract removeImport: lIndex: float -> unit
    //     abstract removeRule: lIndex: float -> unit

    // and [<AllowNullLiteral>] CSSStyleSheetType =
    //     abstract prototype: CSSStyleSheet with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSStyleSheet

    // and [<AllowNullLiteral>] CSSSupportsRule =
    //     inherit CSSConditionRule


    // and [<AllowNullLiteral>] CSSSupportsRuleType =
    //     abstract prototype: CSSSupportsRule with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> CSSSupportsRule

    and [<AllowNullLiteral>] CanvasGradient =
        abstract addColorStop: offset: float * color: string -> unit

    and [<AllowNullLiteral>] CanvasGradientType =
        abstract prototype: CanvasGradient with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasGradient

    and [<AllowNullLiteral>] CanvasPattern =
        interface end

    and [<AllowNullLiteral>] CanvasPatternType =
        abstract prototype: CanvasPattern with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasPattern

    and [<AllowNullLiteral>] CanvasRenderingContext2D =
        abstract canvas: HTMLCanvasElement with get, set
        abstract fillStyle: U3<string, CanvasGradient, CanvasPattern> with get, set
        abstract font: string with get, set
        abstract globalAlpha: float with get, set
        abstract globalCompositeOperation: string with get, set
        abstract lineCap: string with get, set
        abstract lineDashOffset: float with get, set
        abstract lineJoin: string with get, set
        abstract lineWidth: float with get, set
        abstract miterLimit: float with get, set
        abstract shadowBlur: float with get, set
        abstract shadowColor: string with get, set
        abstract shadowOffsetX: float with get, set
        abstract shadowOffsetY: float with get, set
        abstract strokeStyle: U3<string, CanvasGradient, CanvasPattern> with get, set
        abstract textAlign: string with get, set
        abstract textBaseline: string with get, set
        abstract arc: x: float * y: float * radius: float * startAngle: float * endAngle: float * ?anticlockwise: bool -> unit
        abstract arcTo: x1: float * y1: float * x2: float * y2: float * radius: float -> unit
        abstract beginPath: unit -> unit
        abstract bezierCurveTo: cp1x: float * cp1y: float * cp2x: float * cp2y: float * x: float * y: float -> unit
        abstract clearRect: x: float * y: float * w: float * h: float -> unit
        abstract clip: ?fillRule: string -> unit
        abstract closePath: unit -> unit
        abstract createImageData: imageDataOrSw: U2<float, ImageData> * ?sh: float -> ImageData
        abstract createLinearGradient: x0: float * y0: float * x1: float * y1: float -> CanvasGradient
        abstract createPattern: image: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * repetition: string -> CanvasPattern
        abstract createRadialGradient: x0: float * y0: float * r0: float * x1: float * y1: float * r1: float -> CanvasGradient
        abstract drawImage: image: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> * offsetX: float * offsetY: float * ?width: float * ?height: float * ?canvasOffsetX: float * ?canvasOffsetY: float * ?canvasImageWidth: float * ?canvasImageHeight: float -> unit
        abstract fill: ?fillRule: string -> unit
        abstract fillRect: x: float * y: float * w: float * h: float -> unit
        abstract fillText: text: string * x: float * y: float * ?maxWidth: float -> unit
        abstract getImageData: sx: float * sy: float * sw: float * sh: float -> ImageData
        abstract getLineDash: unit -> ResizeArray<float>
        abstract isPointInPath: x: float * y: float * ?fillRule: string -> bool
        abstract lineTo: x: float * y: float -> unit
        abstract measureText: text: string -> TextMetrics
        abstract moveTo: x: float * y: float -> unit
        abstract putImageData: imagedata: ImageData * dx: float * dy: float * ?dirtyX: float * ?dirtyY: float * ?dirtyWidth: float * ?dirtyHeight: float -> unit
        abstract quadraticCurveTo: cpx: float * cpy: float * x: float * y: float -> unit
        abstract rect: x: float * y: float * w: float * h: float -> unit
        abstract restore: unit -> unit
        abstract rotate: angle: float -> unit
        abstract save: unit -> unit
        abstract scale: x: float * y: float -> unit
        abstract setLineDash: segments: ResizeArray<float> -> unit
        abstract setTransform: m11: float * m12: float * m21: float * m22: float * dx: float * dy: float -> unit
        abstract stroke: unit -> unit
        abstract strokeRect: x: float * y: float * w: float * h: float -> unit
        abstract strokeText: text: string * x: float * y: float * ?maxWidth: float -> unit
        abstract transform: m11: float * m12: float * m21: float * m22: float * dx: float * dy: float -> unit
        abstract translate: x: float * y: float -> unit

    and [<AllowNullLiteral>] CanvasRenderingContext2DType =
        abstract prototype: CanvasRenderingContext2D with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CanvasRenderingContext2D

    and [<StringEnum>] ChannelCountMode =
        | Max
        | [<CompiledName("clamped-max")>] ClampedMax
        | Explicit

    and [<StringEnum>] ChannelInterpretation =
        | Speakers
        | Discrete

     and [<AllowNullLiteral>] ChannelMergerNode =
        inherit AudioNode

    and [<AllowNullLiteral>] ChannelMergerNodeType =
        abstract prototype: ChannelMergerNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ChannelMergerNode

    and [<AllowNullLiteral>] ChannelSplitterNode =
        inherit AudioNode

    and [<AllowNullLiteral>] ChannelSplitterNodeType =
        abstract prototype: ChannelSplitterNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ChannelSplitterNode

    and [<AllowNullLiteral>] CharacterData =
        inherit Node
        inherit ChildNode
        abstract data: string with get, set
        abstract length: float with get, set
        abstract appendData: arg: string -> unit
        abstract deleteData: offset: float * count: float -> unit
        abstract insertData: offset: float * arg: string -> unit
        abstract replaceData: offset: float * count: float * arg: string -> unit
        abstract substringData: offset: float * count: float -> string
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] CharacterDataType =
        abstract prototype: CharacterData with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CharacterData

    and [<AllowNullLiteral>] ClientRect =
        abstract bottom: float with get, set
        abstract height: float with get, set
        abstract left: float with get, set
        abstract right: float with get, set
        abstract top: float with get, set
        abstract width: float with get, set

    and [<AllowNullLiteral>] ClientRectType =
        abstract prototype: ClientRect with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ClientRect

    and [<AllowNullLiteral>] ClientRectList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> ClientRect with get, set
        abstract item: index: float -> ClientRect

    and [<AllowNullLiteral>] ClientRectListType =
        abstract prototype: ClientRectList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ClientRectList

    and [<AllowNullLiteral>] ClipboardEvent =
        inherit Event
        abstract clipboardData: DataTransfer with get, set

    and [<AllowNullLiteral>] ClipboardEventType =
        abstract prototype: ClipboardEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: ClipboardEventInit -> ClipboardEvent

    and [<AllowNullLiteral>] CloseEvent =
        inherit Event
        abstract code: float with get, set
        abstract reason: string with get, set
        abstract wasClean: bool with get, set
        abstract initCloseEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * wasCleanArg: bool * codeArg: float * reasonArg: string -> unit

    and [<AllowNullLiteral>] CloseEventType =
        abstract prototype: CloseEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CloseEvent

    and [<AllowNullLiteral>] CommandEvent =
        inherit Event
        abstract commandName: string with get, set
        abstract detail: string with get, set

    and [<AllowNullLiteral>] CommandEventType =
        abstract prototype: CommandEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: CommandEventInit -> CommandEvent

    and [<AllowNullLiteral>] Comment =
        inherit CharacterData
        abstract text: string with get, set

    and [<AllowNullLiteral>] CommentType =
        abstract prototype: Comment with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Comment

    and [<AllowNullLiteral>] CompositionEvent =
        inherit UIEvent
        abstract data: string with get, set
        abstract locale: string with get, set
        abstract initCompositionEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * dataArg: string * locale: string -> unit

    and [<AllowNullLiteral>] CompositionEventType =
        abstract prototype: CompositionEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: CompositionEventInit -> CompositionEvent

    and [<AllowNullLiteral>] Console =
        abstract ``assert``: test: bool * message: string * [<ParamArray>] optionalParams: obj[] -> unit
        abstract clear: unit -> unit
        abstract count: ?countTitle: string -> unit
        abstract debug: message: string * [<ParamArray>] optionalParams: obj[] -> unit
        abstract dir: value: obj * [<ParamArray>] optionalParams: obj[] -> unit
        abstract dirxml: value: obj -> unit
        abstract error: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
        abstract group: ?groupTitle: string -> unit
        abstract groupCollapsed: ?groupTitle: string -> unit
        abstract groupEnd: unit -> unit
        abstract info: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
        abstract log: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
        abstract profile: ?reportName: string -> unit
        abstract profileEnd: unit -> unit
        abstract select: element: Element -> unit
        abstract time: ?timerName: string -> unit
        abstract timeEnd: ?timerName: string -> unit
        abstract trace: message: obj * [<ParamArray>] optionalParams: obj[] -> unit
        abstract warn: message: obj * [<ParamArray>] optionalParams: obj[] -> unit

    and [<AllowNullLiteral>] ConsoleType =
        abstract prototype: Console with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Console

    and [<AllowNullLiteral>] ConvolverNode =
        inherit AudioNode
        abstract buffer: AudioBuffer with get, set
        abstract normalize: bool with get, set

    and [<AllowNullLiteral>] ConvolverNodeType =
        abstract prototype: ConvolverNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ConvolverNode

    and [<AllowNullLiteral>] Coordinates =
        abstract accuracy: float with get, set
        abstract altitude: float with get, set
        abstract altitudeAccuracy: float with get, set
        abstract heading: float with get, set
        abstract latitude: float with get, set
        abstract longitude: float with get, set
        abstract speed: float with get, set

    and [<AllowNullLiteral>] CoordinatesType =
        abstract prototype: Coordinates with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Coordinates

    and [<AllowNullLiteral>] Crypto =
        inherit RandomSource
        abstract subtle: SubtleCrypto with get, set

    and [<AllowNullLiteral>] CryptoType =
        abstract prototype: Crypto with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Crypto

    and [<AllowNullLiteral>] CryptoKey =
        abstract algorithm: KeyAlgorithm with get, set
        abstract extractable: bool with get, set
        abstract ``type``: string with get, set
        abstract usages: ResizeArray<string> with get, set

    and [<AllowNullLiteral>] CryptoKeyType =
        abstract prototype: CryptoKey with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CryptoKey

    and [<AllowNullLiteral>] CryptoKeyPair =
        abstract privateKey: CryptoKey with get, set
        abstract publicKey: CryptoKey with get, set

    and [<AllowNullLiteral>] CryptoKeyPairType =
        abstract prototype: CryptoKeyPair with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> CryptoKeyPair

    and [<AllowNullLiteral>] CustomEvent =
        inherit Event
        abstract detail: obj with get, set
        abstract initCustomEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * detailArg: obj -> unit

    and [<AllowNullLiteral>] CustomEventType =
        abstract prototype: CustomEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: CustomEventInit -> CustomEvent

    and [<StringEnum>] DistanceModelType =
        | Linear
        | Inverse
        | Exponential

    and [<AllowNullLiteral>] DOMError =
        abstract name: string with get, set
        abstract toString: unit -> string

    and [<AllowNullLiteral>] DOMErrorType =
        abstract prototype: DOMError with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMError

    and [<AllowNullLiteral>] DOMException =
        abstract code: float with get, set
        abstract message: string with get, set
        abstract name: string with get, set
        abstract ABORT_ERR: float with get, set
        abstract DATA_CLONE_ERR: float with get, set
        abstract DOMSTRING_SIZE_ERR: float with get, set
        abstract HIERARCHY_REQUEST_ERR: float with get, set
        abstract INDEX_SIZE_ERR: float with get, set
        abstract INUSE_ATTRIBUTE_ERR: float with get, set
        abstract INVALID_ACCESS_ERR: float with get, set
        abstract INVALID_CHARACTER_ERR: float with get, set
        abstract INVALID_MODIFICATION_ERR: float with get, set
        abstract INVALID_NODE_TYPE_ERR: float with get, set
        abstract INVALID_STATE_ERR: float with get, set
        abstract NAMESPACE_ERR: float with get, set
        abstract NETWORK_ERR: float with get, set
        abstract NOT_FOUND_ERR: float with get, set
        abstract NOT_SUPPORTED_ERR: float with get, set
        abstract NO_DATA_ALLOWED_ERR: float with get, set
        abstract NO_MODIFICATION_ALLOWED_ERR: float with get, set
        abstract PARSE_ERR: float with get, set
        abstract QUOTA_EXCEEDED_ERR: float with get, set
        abstract SECURITY_ERR: float with get, set
        abstract SERIALIZE_ERR: float with get, set
        abstract SYNTAX_ERR: float with get, set
        abstract TIMEOUT_ERR: float with get, set
        abstract TYPE_MISMATCH_ERR: float with get, set
        abstract URL_MISMATCH_ERR: float with get, set
        abstract VALIDATION_ERR: float with get, set
        abstract WRONG_DOCUMENT_ERR: float with get, set
        abstract toString: unit -> string

    and [<AllowNullLiteral>] DOMExceptionType =
        abstract prototype: DOMException with get, set
        abstract ABORT_ERR: float with get, set
        abstract DATA_CLONE_ERR: float with get, set
        abstract DOMSTRING_SIZE_ERR: float with get, set
        abstract HIERARCHY_REQUEST_ERR: float with get, set
        abstract INDEX_SIZE_ERR: float with get, set
        abstract INUSE_ATTRIBUTE_ERR: float with get, set
        abstract INVALID_ACCESS_ERR: float with get, set
        abstract INVALID_CHARACTER_ERR: float with get, set
        abstract INVALID_MODIFICATION_ERR: float with get, set
        abstract INVALID_NODE_TYPE_ERR: float with get, set
        abstract INVALID_STATE_ERR: float with get, set
        abstract NAMESPACE_ERR: float with get, set
        abstract NETWORK_ERR: float with get, set
        abstract NOT_FOUND_ERR: float with get, set
        abstract NOT_SUPPORTED_ERR: float with get, set
        abstract NO_DATA_ALLOWED_ERR: float with get, set
        abstract NO_MODIFICATION_ALLOWED_ERR: float with get, set
        abstract PARSE_ERR: float with get, set
        abstract QUOTA_EXCEEDED_ERR: float with get, set
        abstract SECURITY_ERR: float with get, set
        abstract SERIALIZE_ERR: float with get, set
        abstract SYNTAX_ERR: float with get, set
        abstract TIMEOUT_ERR: float with get, set
        abstract TYPE_MISMATCH_ERR: float with get, set
        abstract URL_MISMATCH_ERR: float with get, set
        abstract VALIDATION_ERR: float with get, set
        abstract WRONG_DOCUMENT_ERR: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMException

    and [<AllowNullLiteral>] DOMImplementation =
        abstract createDocument: namespaceURI: string * qualifiedName: string * doctype: DocumentType -> Document
        abstract createDocumentType: qualifiedName: string * publicId: string * systemId: string -> DocumentType
        abstract createHTMLDocument: title: string -> Document
        abstract hasFeature: feature: string * version: string -> bool

    and [<AllowNullLiteral>] DOMImplementationType =
        abstract prototype: DOMImplementation with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMImplementation

    and [<AllowNullLiteral>] DOMParser =
        abstract parseFromString: source: string * mimeType: string -> Document

    and [<AllowNullLiteral>] DOMParserType =
        abstract prototype: DOMParser with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMParser

    and [<AllowNullLiteral>] DOMSettableTokenList =
        inherit DOMTokenList
        abstract value: string with get, set

    and [<AllowNullLiteral>] DOMSettableTokenListType =
        abstract prototype: DOMSettableTokenList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMSettableTokenList

    and [<AllowNullLiteral>] DOMStringList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
        abstract contains: str: string -> bool
        abstract item: index: float -> string

    and [<AllowNullLiteral>] DOMStringListType =
        abstract prototype: DOMStringList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMStringList

    and [<AllowNullLiteral>] DOMStringMap =
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> string with get, set

    and [<AllowNullLiteral>] DOMStringMapType =
        abstract prototype: DOMStringMap with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMStringMap

    and [<AllowNullLiteral>] DOMTokenList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
        abstract add: [<ParamArray>] token: string[] -> unit
        abstract contains: token: string -> bool
        abstract item: index: float -> string
        abstract remove: [<ParamArray>] token: string[] -> unit
        abstract toString: unit -> string
        abstract toggle: token: string * ?force: bool -> bool

    and [<AllowNullLiteral>] DOMTokenListType =
        abstract prototype: DOMTokenList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DOMTokenList

    and [<AllowNullLiteral>] DataCue =
        inherit TextTrackCue
        abstract data: ArrayBuffer with get, set

    and [<AllowNullLiteral>] DataCueType =
        abstract prototype: DataCue with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DataCue

    and [<AllowNullLiteral>] DataTransfer =
        abstract dropEffect: string with get, set
        abstract effectAllowed: string with get, set
        abstract files: FileList with get, set
        abstract items: DataTransferItemList with get, set
        abstract types: DOMStringList with get, set
        abstract clearData: ?format: string -> bool
        abstract getData: format: string -> string
        abstract setData: format: string * data: string -> bool

    and [<AllowNullLiteral>] DataTransferType =
        abstract prototype: DataTransfer with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DataTransfer

    and [<AllowNullLiteral>] DataTransferItem =
        abstract kind: string with get, set
        abstract ``type``: string with get, set
        abstract getAsFile: unit -> File
        abstract getAsString: _callback: FunctionStringCallback -> unit

    and [<AllowNullLiteral>] DataTransferItemType =
        abstract prototype: DataTransferItem with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DataTransferItem

    and [<AllowNullLiteral>] DataTransferItemList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> DataTransferItem with get, set
        abstract add: data: File -> DataTransferItem
        abstract clear: unit -> unit
        abstract item: index: float -> DataTransferItem
        abstract remove: index: float -> unit

    and [<AllowNullLiteral>] DataTransferItemListType =
        abstract prototype: DataTransferItemList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DataTransferItemList

    and [<AllowNullLiteral>] DeferredPermissionRequest =
        abstract id: float with get, set
        abstract ``type``: string with get, set
        abstract uri: string with get, set
        abstract allow: unit -> unit
        abstract deny: unit -> unit

    and [<AllowNullLiteral>] DeferredPermissionRequestType =
        abstract prototype: DeferredPermissionRequest with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DeferredPermissionRequest

    and [<AllowNullLiteral>] DelayNode =
        inherit AudioNode
        abstract delayTime: AudioParam with get

    and [<AllowNullLiteral>] DelayNodeType =
        abstract prototype: DelayNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DelayNode

    and [<AllowNullLiteral>] DeviceAcceleration =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract z: float with get, set

    and [<AllowNullLiteral>] DeviceAccelerationType =
        abstract prototype: DeviceAcceleration with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DeviceAcceleration

    and [<AllowNullLiteral>] DeviceMotionEvent =
        inherit Event
        abstract acceleration: DeviceAcceleration with get, set
        abstract accelerationIncludingGravity: DeviceAcceleration with get, set
        abstract interval: float with get, set
        abstract rotationRate: DeviceRotationRate with get, set
        abstract initDeviceMotionEvent: ``type``: string * bubbles: bool * cancelable: bool * acceleration: DeviceAccelerationDict * accelerationIncludingGravity: DeviceAccelerationDict * rotationRate: DeviceRotationRateDict * interval: float -> unit

    and [<AllowNullLiteral>] DeviceMotionEventType =
        abstract prototype: DeviceMotionEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DeviceMotionEvent

    and [<AllowNullLiteral>] DeviceOrientationEvent =
        inherit Event
        abstract absolute: bool with get, set
        abstract alpha: float with get, set
        abstract beta: float with get, set
        abstract gamma: float with get, set
        abstract initDeviceOrientationEvent: ``type``: string * bubbles: bool * cancelable: bool * alpha: float * beta: float * gamma: float * absolute: bool -> unit

    and [<AllowNullLiteral>] DeviceOrientationEventType =
        abstract prototype: DeviceOrientationEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DeviceOrientationEvent

    and [<AllowNullLiteral>] DeviceRotationRate =
        abstract alpha: float with get, set
        abstract beta: float with get, set
        abstract gamma: float with get, set

    and [<AllowNullLiteral>] DeviceRotationRateType =
        abstract prototype: DeviceRotationRate with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DeviceRotationRate

    and [<AllowNullLiteral>] Document =
        inherit Node
        inherit GlobalEventHandlers
        inherit NodeSelector
        inherit DocumentEvent
        /// Sets or gets the URL for the current document.
        abstract URL: string with get, set
        /// Gets the URL for the document, stripped of any character encoding.
        abstract URLUnencoded: string with get, set
        /// Gets the object that has the focus when the parent document has focus.
        abstract activeElement: Element with get, set
        /// Sets or gets the color of all active links in the document.
        abstract alinkColor: string with get, set
        /// Returns a reference to the collection of elements contained by the object.
        abstract all: HTMLCollection with get, set
        /// Retrieves a collection of all a objects that have a name and/or id property. Objects in this collection are in HTML source order.
        abstract anchors: HTMLCollection with get, set
        /// Retrieves a collection of all applet objects in the document.
        abstract applets: HTMLCollection with get, set
        /// Deprecated. Sets or retrieves a value that indicates the background color behind the object.
        abstract bgColor: string with get, set
        /// Specifies the beginning and end of the document body.
        abstract body: HTMLElement with get, set
        abstract characterSet: string with get, set
        /// Gets or sets the character set used to encode the object.
        abstract charset: string with get, set
        /// Gets a value that indicates whether standards-compliant mode is switched on for the object.
        abstract compatMode: string with get, set
        abstract cookie: string with get, set
        abstract defaultCharset: string with get, set
        abstract defaultView: Window with get, set
        /// Sets or gets a value that indicates whether the document can be edited.
        abstract designMode: string with get, set
        /// Sets or retrieves a value that indicates the reading order of the object.
        abstract dir: string with get, set
        /// Gets an object representing the document type declaration associated with the current document.
        abstract doctype: DocumentType with get, set
        /// Gets a reference to the root node of the document.
        abstract documentElement: HTMLElement with get, set
        /// Sets or gets the security domain of the document.
        abstract domain: string with get, set
        /// Retrieves a collection of all embed objects in the document.
        abstract embeds: HTMLCollection with get, set
        /// Sets or gets the foreground (text) color of the document.
        abstract fgColor: string with get, set
        /// Retrieves a collection, in source order, of all form objects in the document.
        abstract forms: HTMLCollection with get, set
        abstract fullscreenElement: Element with get, set
        abstract fullscreenEnabled: bool with get, set
        abstract head: HTMLHeadElement with get, set
        abstract hidden: bool with get, set
        /// Retrieves a collection, in source order, of img objects in the document.
        abstract images: HTMLCollection with get, set
        /// Gets the implementation object of the current document.
        abstract implementation: DOMImplementation with get, set
        /// Returns the character encoding used to create the webpage that is loaded into the document object.
        abstract inputEncoding: string with get, set
        /// Gets the date that the page was last modified, if the page supplies one.
        abstract lastModified: string with get, set
        /// Sets or gets the color of the document links.
        abstract linkColor: string with get, set
        /// Retrieves a collection of all a objects that specify the href property and all area objects in the document.
        abstract links: HTMLCollection with get, set
        /// Contains information about the current URL.
        abstract location: Location with get, set
        abstract media: string with get, set
        /// Fires when the user aborts the download.
        abstract onabort: (Event -> 'Out) with get, set
        /// Fires when the object is set as the active element.
        abstract onactivate: (UIEvent -> 'Out) with get, set
        /// Fires immediately before the object is set as the active element.
        abstract onbeforeactivate: (UIEvent -> 'Out) with get, set
        /// Fires immediately before the activeElement is changed from the current object to another object in the parent document.
        abstract onbeforedeactivate: (UIEvent -> 'Out) with get, set
        /// Fires when the object loses the input focus.
        abstract onblur: (FocusEvent -> 'Out) with get, set
        /// Occurs when playback is possible, but would require further buffering.
        abstract oncanplay: (Event -> 'Out) with get, set
        abstract oncanplaythrough: (Event -> 'Out) with get, set
        /// Fires when the contents of the object or selection have changed.
        abstract onchange: (Event -> 'Out) with get, set
        /// Fires when the user clicks the left mouse button on the object
        abstract onclick: (MouseEvent -> 'Out) with get, set
        /// Fires when the user clicks the right mouse button in the client area, opening the context menu.
        abstract oncontextmenu: (PointerEvent -> 'Out) with get, set
        /// Fires when the user double-clicks the object.
        abstract ondblclick: (MouseEvent -> 'Out) with get, set
        /// Fires when the activeElement is changed from the current object to another object in the parent document.
        abstract ondeactivate: (UIEvent -> 'Out) with get, set
        /// Fires on the source object continuously during a drag operation.
        abstract ondrag: (DragEvent -> 'Out) with get, set
        /// Fires on the source object when the user releases the mouse at the close of a drag operation.
        abstract ondragend: (DragEvent -> 'Out) with get, set
        /// Fires on the target element when the user drags the object to a valid drop target.
        abstract ondragenter: (DragEvent -> 'Out) with get, set
        /// Fires on the target object when the user moves the mouse out of a valid drop target during a drag operation.
        abstract ondragleave: (DragEvent -> 'Out) with get, set
        /// Fires on the target element continuously while the user drags the object over a valid drop target.
        abstract ondragover: (DragEvent -> 'Out) with get, set
        /// Fires on the source object when the user starts to drag a text selection or selected object.
        abstract ondragstart: (DragEvent -> 'Out) with get, set
        abstract ondrop: (DragEvent -> 'Out) with get, set
        /// Occurs when the duration attribute is updated.
        abstract ondurationchange: (Event -> 'Out) with get, set
        /// Occurs when the media element is reset to its initial state.
        abstract onemptied: (Event -> 'Out) with get, set
        /// Occurs when the end of playback is reached.
        abstract onended: (Event -> 'Out) with get, set
        /// Fires when an error occurs during object loading.
        abstract onerror: (Event -> 'Out) with get, set
        /// Fires when the object receives focus.
        abstract onfocus: (FocusEvent -> 'Out) with get, set
        abstract onfullscreenchange: (Event -> 'Out) with get, set
        abstract onfullscreenerror: (Event -> 'Out) with get, set
        abstract oninput: (Event -> 'Out) with get, set
        /// Fires when the user presses a key.
        abstract onkeydown: (KeyboardEvent -> 'Out) with get, set
        /// Fires when the user presses an alphanumeric key.
        abstract onkeypress: (KeyboardEvent -> 'Out) with get, set
        /// Fires when the user releases a key.
        abstract onkeyup: (KeyboardEvent -> 'Out) with get, set
        /// Fires immediately after the browser loads the object.
        abstract onload: (Event -> 'Out) with get, set
        /// Occurs when media data is loaded at the current playback position.
        abstract onloadeddata: (Event -> 'Out) with get, set
        /// Occurs when the duration and dimensions of the media have been determined.
        abstract onloadedmetadata: (Event -> 'Out) with get, set
        /// Occurs when Internet Explorer begins looking for media data.
        abstract onloadstart: (Event -> 'Out) with get, set
        /// Fires when the user clicks the object with either mouse button.
        abstract onmousedown: (MouseEvent -> 'Out) with get, set
        /// Fires when the user moves the mouse over the object.
        abstract onmousemove: (MouseEvent -> 'Out) with get, set
        /// Fires when the user moves the mouse pointer outside the boundaries of the object.
        abstract onmouseout: (MouseEvent -> 'Out) with get, set
        /// Fires when the user moves the mouse pointer into the object.
        abstract onmouseover: (MouseEvent -> 'Out) with get, set
        /// Fires when the user releases a mouse button while the mouse is over the object.
        abstract onmouseup: (MouseEvent -> 'Out) with get, set
        /// Fires when the wheel button is rotated.
        abstract onmousewheel: (MouseWheelEvent -> 'Out) with get, set
        /// Occurs when playback is paused.
        abstract onpause: (Event -> 'Out) with get, set
        /// Occurs when the play method is requested.
        abstract onplay: (Event -> 'Out) with get, set
        /// Occurs when the audio or video has started playing.
        abstract onplaying: (Event -> 'Out) with get, set
        abstract onpointerlockchange: (Event -> 'Out) with get, set
        abstract onpointerlockerror: (Event -> 'Out) with get, set
        /// Occurs to indicate progress while downloading media data.
        abstract onprogress: (ProgressEvent -> 'Out) with get, set
        /// Occurs when the playback rate is increased or decreased.
        abstract onratechange: (Event -> 'Out) with get, set
        /// Fires when the state of the object has changed.
        abstract onreadystatechange: (ProgressEvent -> 'Out) with get, set
        /// Fires when the user resets a form.
        abstract onreset: (Event -> 'Out) with get, set
        /// Fires when the user repositions the scroll box in the scroll bar on the object.
        abstract onscroll: (UIEvent -> 'Out) with get, set
        /// Occurs when the seek operation ends.
        abstract onseeked: (Event -> 'Out) with get, set
        /// Occurs when the current playback position is moved.
        abstract onseeking: (Event -> 'Out) with get, set
        /// Fires when the current selection changes.
        abstract onselect: (UIEvent -> 'Out) with get, set
        abstract onselectstart: (Event -> 'Out) with get, set
        /// Occurs when the download has stopped.
        abstract onstalled: (Event -> 'Out) with get, set
        /// Fires when the user clicks the Stop button or leaves the Web page.
        abstract onstop: (Event -> 'Out) with get, set
        abstract onsubmit: (Event -> 'Out) with get, set
        /// Occurs if the load operation has been intentionally halted.
        abstract onsuspend: (Event -> 'Out) with get, set
        /// Occurs to indicate the current playback position.
        abstract ontimeupdate: (Event -> 'Out) with get, set
        abstract ontouchcancel: (TouchEvent -> 'Out) with get, set
        abstract ontouchend: (TouchEvent -> 'Out) with get, set
        abstract ontouchmove: (TouchEvent -> 'Out) with get, set
        abstract ontouchstart: (TouchEvent -> 'Out) with get, set
        /// Occurs when the volume is changed, or playback is muted or unmuted.
        abstract onvolumechange: (Event -> 'Out) with get, set
        /// Occurs when playback stops because the next frame of a video resource is not available.
        abstract onwaiting: (Event -> 'Out) with get, set
        abstract plugins: HTMLCollection with get, set
        abstract pointerLockElement: Element with get, set
        /// Retrieves a value that indicates the current state of the object.
        abstract readyState: string with get, set
        /// Gets the URL of the location that referred the user to the current page.
        abstract referrer: string with get, set
        // /// Gets the root svg element in the document hierarchy.
        // abstract rootElement: SVGSVGElement with get, set
        /// Retrieves a collection of all script objects in the document.
        abstract scripts: HTMLCollection with get, set
        abstract security: string with get, set
        // /// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
        // abstract styleSheets: StyleSheetList with get, set
        /// Contains the title of the document.
        abstract title: string with get, set
        abstract visibilityState: string with get, set
        /// Sets or gets the color of the links that the user has visited.
        abstract vlinkColor: string with get, set
        abstract xmlEncoding: string with get, set
        abstract xmlStandalone: bool with get, set
        /// Gets or sets the version attribute specified in the declaration of an XML document.
        abstract xmlVersion: string with get, set
        abstract currentScript: HTMLScriptElement with get, set
        abstract adoptNode: source: Node -> Node
        abstract captureEvents: unit -> unit
        abstract clear: unit -> unit
        /// Closes an output stream and forces the sent data to display.
        abstract close: unit -> unit
        /// <summary>Creates an attribute object with a specified name.</summary>
        /// <param name="name">String that sets the attribute object's name.</param>
        abstract createAttribute: name: string -> Attr
        abstract createAttributeNS: namespaceURI: string * qualifiedName: string -> Attr
        abstract createCDATASection: data: string -> CDATASection
        /// <summary>Creates a comment object with the specified data.</summary>
        /// <param name="data">Sets the comment object's data.</param>
        abstract createComment: data: string -> Comment
        /// Creates a new document.
        abstract createDocumentFragment: unit -> DocumentFragment
        /// <summary>Creates an instance of the element for the specified tag.</summary>
        /// <param name="tagName">The name of an element.</param>
        abstract createElement: tagName: string -> HTMLElement
        abstract createElementNS: namespaceURI: string * qualifiedName: string -> Element
        // abstract createExpression: expression: string * resolver: XPathNSResolver -> XPathExpression
        // abstract createNSResolver: nodeResolver: Node -> XPathNSResolver
        /// <summary>Creates a NodeIterator object that you can use to traverse filtered lists of nodes or elements in a document.</summary>
        /// <param name="root">The root element or node to start traversing on.</param>
        /// <param name="whatToShow">The type of nodes or elements to appear in the node list</param>
        /// <param name="filter">A custom NodeFilter function to use. For more information, see filter. Use null for no filter.</param>
        /// <param name="entityReferenceExpansion">A flag that specifies whether entity reference nodes are expanded.</param>
        abstract createNodeIterator: root: Node * ?whatToShow: float * ?filter: NodeFilter * ?entityReferenceExpansion: bool -> NodeIterator
        abstract createProcessingInstruction: target: string * data: string -> ProcessingInstruction
        /// Returns an empty range object that has both of its boundary points positioned at the beginning of the document.
        abstract createRange: unit -> Range
        /// <summary>Creates a text string from the specified value.</summary>
        /// <param name="data">String that specifies the nodeValue property of the text node.</param>
        abstract createTextNode: data: string -> Text
        abstract createTouch: view: obj * target: EventTarget * identifier: float * pageX: float * pageY: float * screenX: float * screenY: float -> Touch
        abstract createTouchList: [<ParamArray>] touches: Touch[] -> TouchList
        /// <summary>Creates a TreeWalker object that you can use to traverse filtered lists of nodes or elements in a document.</summary>
        /// <param name="root">The root element or node to start traversing on.</param>
        /// <param name="whatToShow">The type of nodes or elements to appear in the node list. For more information, see whatToShow.</param>
        /// <param name="filter">A custom NodeFilter function to use.</param>
        /// <param name="entityReferenceExpansion">A flag that specifies whether entity reference nodes are expanded.</param>
        abstract createTreeWalker: root: Node * ?whatToShow: float * ?filter: NodeFilter * ?entityReferenceExpansion: bool -> TreeWalker
        /// <summary>Returns the element for the specified x coordinate and the specified y coordinate.</summary>
        /// <param name="x">The x-offset</param>
        /// <param name="y">The y-offset</param>
        abstract elementFromPoint: x: float * y: float -> Element
        // abstract evaluate: expression: string * contextNode: Node * resolver: XPathNSResolver * ``type``: float * result: XPathResult -> XPathResult
        /// <summary>Executes a command on the current document, current selection, or the given range.</summary>
        /// <param name="commandId">String that specifies the command to execute. This command can be any of the command identifiers that can be executed in script.</param>
        /// <param name="showUI">Display the user interface, defaults to false.</param>
        /// <param name="value">Value to assign.</param>
        abstract execCommand: commandId: string * ?showUI: bool * ?value: obj -> bool
        /// <summary>Displays help information for the given command identifier.</summary>
        /// <param name="commandId">Displays help information for the given command identifier.</param>
        abstract execCommandShowHelp: commandId: string -> bool
        abstract exitFullscreen: unit -> unit
        abstract exitPointerLock: unit -> unit
        /// Causes the element to receive the focus and executes the code specified by the onfocus event.
        abstract focus: unit -> unit
        /// <summary>Returns a reference to the first object with the specified value of the ID or NAME attribute.</summary>
        /// <param name="elementId">String that specifies the ID value. Case-insensitive.</param>
        /// <param name="elementId">String that specifies the ID value. Case-insensitive.</param>
        abstract getElementById: elementId: string -> HTMLElement
        abstract getElementsByClassName: classNames: string -> NodeListOf<Element>
        /// <summary>Gets a collection of objects based on the value of the NAME or ID attribute.</summary>
        /// <param name="elementName">Gets a collection of objects based on the value of the NAME or ID attribute.</param>
        abstract getElementsByName: elementName: string -> NodeListOf<Element>
        /// Retrieves a collection of objects based on the specified element name.
        abstract getElementsByTagName: tagname: string -> NodeListOf<Element>
        abstract getElementsByTagNameNS: namespaceURI: string * localName: string -> NodeListOf<Element>
        /// Returns an object representing the current selection of the document that is loaded into the object displaying a webpage.
        abstract getSelection: unit -> Selection
        /// Gets a value indicating whether the object currently has focus.
        abstract hasFocus: unit -> bool
        abstract importNode: importedNode: Node * deep: bool -> Node
        /// <summary>Opens a new window and loads a document specified by a given URL. Also, opens a new window that uses the url parameter and the name parameter to collect the output of the write method and the writeln method.</summary>
        /// <param name="url">Specifies a MIME type for the document.</param>
        /// <param name="name">Specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.</param>
        /// <param name="features">Contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes"). The following values are supported.</param>
        /// <param name="replace">Specifies whether the existing entry for the document is replaced in the history list.</param>
        abstract ``open``: ?url: string * ?name: string * ?features: string * ?replace: bool -> Document
        /// <summary>Returns a Boolean value that indicates whether a specified command can be successfully executed using execCommand, given the current state of the document.</summary>
        /// <param name="commandId">Specifies a command identifier.</param>
        abstract queryCommandEnabled: commandId: string -> bool
        /// <summary>Returns a Boolean value that indicates whether the specified command is in the indeterminate state.</summary>
        /// <param name="commandId">String that specifies a command identifier.</param>
        abstract queryCommandIndeterm: commandId: string -> bool
        /// <summary>Returns a Boolean value that indicates the current state of the command.</summary>
        /// <param name="commandId">String that specifies a command identifier.</param>
        abstract queryCommandState: commandId: string -> bool
        /// <summary>Returns a Boolean value that indicates whether the current command is supported on the current range.</summary>
        /// <param name="commandId">Specifies a command identifier.</param>
        abstract queryCommandSupported: commandId: string -> bool
        /// <summary>Retrieves the string associated with a command.</summary>
        /// <param name="commandId">String that contains the identifier of a command. This can be any command identifier given in the list of Command Identifiers.</param>
        abstract queryCommandText: commandId: string -> string
        /// <summary>Returns the current value of the document, range, or current selection for the given command.</summary>
        /// <param name="commandId">String that specifies a command identifier.</param>
        abstract queryCommandValue: commandId: string -> string
        abstract releaseEvents: unit -> unit
        /// Allows updating the print settings for the page.
        abstract updateSettings: unit -> unit
        /// <summary>Writes one or more HTML expressions to a document in the specified window.</summary>
        /// <param name="content">Specifies the text and HTML tags to write.</param>
        abstract write: [<ParamArray>] content: string[] -> unit
        /// <summary>Writes one or more HTML expressions, followed by a carriage return, to a document in the specified window.</summary>
        /// <param name="content">The text and HTML tags to write.</param>
        abstract writeln: [<ParamArray>] content: string[] -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] DocumentType =
        abstract prototype: Document with get, set
        abstract entities: NamedNodeMap with get, set
        abstract internalSubset: string with get, set
        abstract name: string with get, set
        abstract notations: NamedNodeMap with get, set
        abstract publicId: string with get, set
        abstract systemId: string with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Document
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] DocumentFragment =
        inherit Node
        inherit NodeSelector
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] DocumentFragmentType =
        abstract prototype: DocumentFragment with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DocumentFragment

    and [<AllowNullLiteral>] DocumentTypeType =
        abstract prototype: DocumentType with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DocumentType

    and [<AllowNullLiteral>] DragEvent =
        inherit MouseEvent
        abstract dataTransfer: DataTransfer with get, set
        abstract initDragEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float * screenXArg: float * screenYArg: float * clientXArg: float * clientYArg: float * ctrlKeyArg: bool * altKeyArg: bool * shiftKeyArg: bool * metaKeyArg: bool * buttonArg: float * relatedTargetArg: EventTarget * dataTransferArg: DataTransfer -> unit

    and [<AllowNullLiteral>] DragEventType =
        abstract prototype: DragEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DragEvent

    and [<AllowNullLiteral>] DynamicsCompressorNode =
        inherit AudioNode
        abstract attack: AudioParam with get
        abstract knee: AudioParam with get
        abstract ratio: AudioParam with get
        abstract reduction: AudioParam with get
        abstract release: AudioParam with get
        abstract threshold: AudioParam with get

    and [<AllowNullLiteral>] DynamicsCompressorNodeType =
        abstract prototype: DynamicsCompressorNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> DynamicsCompressorNode

    and [<AllowNullLiteral>] Element =
        inherit Node
        inherit GlobalEventHandlers
        inherit ElementTraversal
        inherit NodeSelector
        inherit ChildNode
        abstract classList: DOMTokenList with get, set
        abstract clientHeight: float with get, set
        abstract clientLeft: float with get, set
        abstract clientTop: float with get, set
        abstract clientWidth: float with get, set
        abstract onariarequest: (AriaRequestEvent -> 'Out) with get, set
        abstract oncommand: (CommandEvent -> 'Out) with get, set
        abstract ongotpointercapture: (PointerEvent -> 'Out) with get, set
        abstract onlostpointercapture: (PointerEvent -> 'Out) with get, set
        abstract ontouchcancel: (TouchEvent -> 'Out) with get, set
        abstract ontouchend: (TouchEvent -> 'Out) with get, set
        abstract ontouchmove: (TouchEvent -> 'Out) with get, set
        abstract ontouchstart: (TouchEvent -> 'Out) with get, set
        abstract scrollHeight: float with get, set
        abstract scrollLeft: float with get, set
        abstract scrollTop: float with get, set
        abstract scrollWidth: float with get, set
        abstract tagName: string with get, set
        abstract id: string with get, set
        abstract className: string with get, set
        abstract innerHTML: string with get, set
        abstract getAttribute: ?name: string -> string
        abstract getAttributeNS: namespaceURI: string * localName: string -> string
        abstract getAttributeNode: name: string -> Attr
        abstract getAttributeNodeNS: namespaceURI: string * localName: string -> Attr
        abstract getBoundingClientRect: unit -> ClientRect
        abstract getClientRects: unit -> ClientRectList
        abstract getElementsByTagName: name: string -> NodeListOf<Element>
        abstract getElementsByTagNameNS: namespaceURI: string * localName: string -> NodeListOf<Element>
        abstract hasAttribute: name: string -> bool
        abstract hasAttributeNS: namespaceURI: string * localName: string -> bool
        abstract releasePointerCapture: pointerId: float -> unit
        abstract removeAttribute: ?name: string -> unit
        abstract removeAttributeNS: namespaceURI: string * localName: string -> unit
        abstract removeAttributeNode: oldAttr: Attr -> Attr
        abstract requestFullscreen: unit -> unit
        abstract requestPointerLock: unit -> unit
        abstract setAttribute: name: string * value: string -> unit
        abstract setAttributeNS: namespaceURI: string * qualifiedName: string * value: string -> unit
        abstract setAttributeNode: newAttr: Attr -> Attr
        abstract setAttributeNodeNS: newAttr: Attr -> Attr
        abstract setPointerCapture: pointerId: float -> unit
        abstract getElementsByClassName: classNames: string -> NodeListOf<Element>
        abstract matches: selector: string -> bool
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] ElementType =
        abstract prototype: Element with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Element

    and [<AllowNullLiteral>] ErrorEvent =
        inherit Event
        abstract colno: float with get, set
        abstract error: obj with get, set
        abstract filename: string with get, set
        abstract lineno: float with get, set
        abstract message: string with get, set
        abstract initErrorEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * messageArg: string * filenameArg: string * linenoArg: float -> unit

    and [<AllowNullLiteral>] ErrorEventType =
        abstract prototype: ErrorEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ErrorEvent

    and [<AllowNullLiteral>] Event =
        abstract bubbles: bool with get, set
        abstract cancelBubble: bool with get, set
        abstract cancelable: bool with get, set
        abstract currentTarget: EventTarget with get, set
        abstract defaultPrevented: bool with get, set
        abstract eventPhase: float with get, set
        abstract isTrusted: bool with get, set
        abstract returnValue: bool with get, set
        abstract srcElement: Element with get, set
        abstract target: EventTarget with get, set
        abstract timeStamp: float with get, set
        abstract ``type``: string with get, set
        abstract AT_TARGET: float with get, set
        abstract BUBBLING_PHASE: float with get, set
        abstract CAPTURING_PHASE: float with get, set
        abstract initEvent: eventTypeArg: string * canBubbleArg: bool * cancelableArg: bool -> unit
        abstract preventDefault: unit -> unit
        abstract stopImmediatePropagation: unit -> unit
        abstract stopPropagation: unit -> unit

    and [<AllowNullLiteral>] EventType =
        abstract prototype: Event with get, set
        abstract AT_TARGET: float with get, set
        abstract BUBBLING_PHASE: float with get, set
        abstract CAPTURING_PHASE: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: EventInit -> Event

    and [<AllowNullLiteral>] EventTarget =
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit
        abstract dispatchEvent: evt: Event -> bool
        abstract removeEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] EventTargetType =
        abstract prototype: EventTarget with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> EventTarget

    and [<AllowNullLiteral>] External =
        interface end

    and [<AllowNullLiteral>] ExternalType =
        abstract prototype: External with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> External

    and [<AllowNullLiteral>] FetchEvent =
        inherit Event
        abstract request: Request with get, set
        abstract respondWith: response: U2<Promise<Response>, Response> -> Promise<Response>

    and [<AllowNullLiteral>] File =
        inherit Blob
        abstract lastModifiedDate: obj with get, set
        abstract name: string with get, set

    and [<AllowNullLiteral>] FileType =
        abstract prototype: File with get, set
        [<Emit("new $0($1...)")>] abstract Create: parts: ResizeArray<U4<ArrayBuffer, ArrayBufferView, Blob, string>> * filename: string * ?properties: FilePropertyBag -> File

    and [<AllowNullLiteral>] FileList =
        abstract length: int with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> File with get, set
        abstract item: index: int -> File

    and [<AllowNullLiteral>] FileListType =
        abstract prototype: FileList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> FileList

    and [<AllowNullLiteral>] FileReader =
        inherit EventTarget
        abstract error: DOMError with get, set
        abstract readAsArrayBuffer: blob: Blob -> unit
        abstract readAsBinaryString: blob: Blob -> unit
        abstract readAsDataURL: blob: Blob -> unit
        abstract readAsText: blob: Blob * ?encoding: string -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] FileReaderType =
        abstract prototype: FileReader with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> FileReader

    and [<AllowNullLiteral>] FocusEvent =
        inherit UIEvent
        abstract relatedTarget: EventTarget with get, set
        abstract initFocusEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float * relatedTargetArg: EventTarget -> unit

    and [<AllowNullLiteral>] FocusEventType =
        abstract prototype: FocusEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: FocusEventInit -> FocusEvent

    and [<AllowNullLiteral>] FormData =
        abstract append: name: obj * value: obj * ?blobName: string -> unit

    and [<AllowNullLiteral>] FormDataType =
        abstract prototype: FormData with get, set
        [<Emit("new $0($1...)")>] abstract Create: ?form: HTMLFormElement -> FormData

    and [<AllowNullLiteral>] GainNode =
        inherit AudioNode
        abstract gain: AudioParam with get

    and [<AllowNullLiteral>] GainNodeType =
        abstract prototype: GainNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> GainNode

    and [<AllowNullLiteral>] Gamepad =
        abstract axes: ResizeArray<float> with get, set
        abstract buttons: ResizeArray<GamepadButton> with get, set
        abstract connected: bool with get, set
        abstract id: string with get, set
        abstract index: float with get, set
        abstract mapping: string with get, set
        abstract timestamp: float with get, set

    and [<AllowNullLiteral>] GamepadType =
        abstract prototype: Gamepad with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Gamepad

    and [<AllowNullLiteral>] GamepadButton =
        abstract pressed: bool with get, set
        abstract value: float with get, set

    and [<AllowNullLiteral>] GamepadButtonType =
        abstract prototype: GamepadButton with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> GamepadButton

    and [<AllowNullLiteral>] GamepadEvent =
        inherit Event
        abstract gamepad: Gamepad with get, set

    and [<AllowNullLiteral>] GamepadEventType =
        abstract prototype: GamepadEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> GamepadEvent

    and [<AllowNullLiteral>] Geolocation =
        abstract clearWatch: watchId: float -> unit
        abstract getCurrentPosition: successCallback: PositionCallback * ?errorCallback: PositionErrorCallback * ?options: PositionOptions -> unit
        abstract watchPosition: successCallback: PositionCallback * ?errorCallback: PositionErrorCallback * ?options: PositionOptions -> float

    and [<AllowNullLiteral>] GeolocationType =
        abstract prototype: Geolocation with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Geolocation

    and [<AllowNullLiteral>] HTMLAllCollection =
        inherit HTMLCollection
        /// Sets or retrieves the shape of the object.
        /// Retrieves a select object or an object from an options collection.
        abstract namedItem: name: string -> Element

    and [<AllowNullLiteral>] HTMLAllCollectionType =
        abstract prototype: HTMLAllCollection with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAllCollection

    and [<AllowNullLiteral>] HTMLAnchorElement =
        inherit HTMLElement
        abstract Methods: string with get, set
        /// Sets or retrieves the character set used to encode the object.
        abstract charset: string with get, set
        /// Sets or retrieves the coordinates of the object.
        abstract coords: string with get, set
        /// Contains the anchor portion of the URL including the hash sign (#).
        abstract hash: string with get, set
        /// Contains the hostname and port values of the URL.
        abstract host: string with get, set
        /// Contains the hostname of a URL.
        /// Sets or retrieves the hostname and port number of the location or URL.
        abstract hostname: string with get, set
        /// Sets or retrieves a destination URL or an anchor point.
        abstract href: string with get, set
        /// Sets or retrieves the language code of the object.
        /// Sets or retrieves a destination URL or an anchor point.
        abstract hreflang: string with get, set
        abstract mimeType: string with get, set
        /// Sets or retrieves the shape of the object.
        abstract name: string with get, set
        /// Sets or retrieves the name of the object.
        abstract nameProp: string with get, set
        /// Contains the pathname of the URL.
        abstract pathname: string with get, set
        /// Sets or retrieves the port number associated with a URL.
        abstract port: string with get, set
        /// Contains the protocol of the URL.
        abstract protocol: string with get, set
        /// Sets or retrieves the protocol portion of a URL.
        abstract protocolLong: string with get, set
        /// Sets or retrieves the relationship between the object and the destination of the link.
        abstract rel: string with get, set
        /// Sets or retrieves the relationship between the object and the destination of the link.
        abstract rev: string with get, set
        /// Sets or retrieves the substring of the href property that follows the question mark.
        abstract search: string with get, set
        /// Sets or retrieves the shape of the object.
        abstract shape: string with get, set
        /// Sets or retrieves the window or frame at which to target content.
        abstract target: string with get, set
        /// Retrieves or sets the text of the object as a string.
        abstract text: string with get, set
        /// Returns the content type of the object.
        abstract ``type``: string with get, set
        abstract urn: string with get, set
        /// Returns a string representation of an object.
        abstract toString: unit -> string

    and [<AllowNullLiteral>] HTMLAnchorElementType =
        abstract prototype: HTMLAnchorElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAnchorElement

    and [<AllowNullLiteral>] HTMLAppletElement =
        inherit HTMLElement
        /// Retrieves a string of the URL where the object tag can be found. This is often the href of the document that the object is in, or the value set by a base element.
        abstract BaseHref: string with get, set
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        /// Sets or retrieves a text alternative to the graphic.
        abstract alt: string with get, set
        /// Gets or sets the optional alternative HTML script to execute if the object fails to load.
        /// Sets or retrieves a text alternative to the graphic.
        abstract altHtml: string with get, set
        /// Sets or retrieves a character string that can be used to implement your own archive functionality for the object.
        abstract archive: string with get, set
        /// Specifies the properties of a border drawn around an object.
        abstract border: string with get, set
        /// Sets or retrieves the URL of the file containing the compiled Java class.
        abstract code: string with get, set
        /// Sets or retrieves the URL of the component.
        abstract codeBase: string with get, set
        /// Sets or retrieves the Internet media type for the code associated with the object.
        abstract codeType: string with get, set
        /// Address of a pointer to the document this page or frame contains. If there is no document, then null will be returned.
        /// Gets or sets meta-information to associate with httpEquiv or name.
        abstract contentDocument: Document with get, set
        /// Sets or retrieves the URL that references the data of the object.
        abstract data: string with get, set
        /// Sets or retrieves a character string that can be used to implement your own declare functionality for the object.
        abstract declare: bool with get, set
        /// Retrieves a reference to the form that the object is embedded in.
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the height of the object.
        abstract height: string with get, set
        /// Sets or retrieves the horizontal margin for the object.
        abstract hspace: float with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set
        abstract ``object``: string with get, set
        /// Sets or retrieves a message to be displayed while an object is loading.
        abstract standby: string with get, set
        /// Gets the classification and default behavior of the button.
        abstract ``type``: string with get, set
        /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        abstract useMap: string with get, set
        /// Sets or retrieves the vertical margin for the object.
        abstract vspace: float with get, set
        /// Gets or sets the width of a canvas element on a document.
        abstract width: float with get, set

    and [<AllowNullLiteral>] HTMLAppletElementType =
        abstract prototype: HTMLAppletElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAppletElement

    and [<AllowNullLiteral>] HTMLAreaElement =
        inherit HTMLElement
        /// Sets or retrieves a text alternative to the graphic.
        abstract alt: string with get, set
        /// Sets or retrieves the coordinates of the object.
        abstract coords: string with get, set
        /// Sets or retrieves the subsection of the href property that follows the number sign (#).
        abstract hash: string with get, set
        abstract host: string with get, set
        /// Sets or retrieves the host name part of the location or URL.
        abstract hostname: string with get, set
        /// Gets or sets the baseline URL on which relative links are based.
        abstract href: string with get, set
        /// Sets or gets whether clicks in this region cause action.
        abstract noHref: bool with get, set
        /// Sets or retrieves the file name or path specified by the object.
        abstract pathname: string with get, set
        /// Sets or retrieves the port number associated with a URL.
        abstract port: string with get, set
        abstract protocol: string with get, set
        /// Sets or retrieves the relationship between the object and the destination of the link.
        abstract rel: string with get, set
        /// Sets or retrieves the substring of the href property that follows the question mark.
        abstract search: string with get, set
        /// Sets or retrieves the shape of the object.
        abstract shape: string with get, set
        /// Sets or retrieves the window or frame at which to target content.
        abstract target: string with get, set
        /// Returns a string representation of an object.
        abstract toString: unit -> string

    and [<AllowNullLiteral>] HTMLAreaElementType =
        abstract prototype: HTMLAreaElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAreaElement

    and [<AllowNullLiteral>] HTMLAreasCollection =
        inherit HTMLCollection
        /// <summary>Adds an element to the areas, controlRange, or options collection.</summary>
        /// <param name="element">Variant of type Number that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
        /// <param name="before">Variant of type Object that specifies an element to insert before, or null to append the object to the collection.</param>
        abstract add: element: HTMLElement * ?before: U2<HTMLElement, float> -> unit
        /// <summary>Removes an element from the collection.</summary>
        /// <param name="index">Number that specifies the zero-based index of the element to remove from the collection.</param>
        abstract remove: ?index: float -> unit

    and [<AllowNullLiteral>] HTMLAreasCollectionType =
        abstract prototype: HTMLAreasCollection with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAreasCollection

    and [<AllowNullLiteral>] HTMLAudioElement =
        inherit HTMLMediaElement


    and [<AllowNullLiteral>] HTMLAudioElementType =
        abstract prototype: HTMLAudioElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLAudioElement

    and [<AllowNullLiteral>] HTMLBRElement =
        inherit HTMLElement
        /// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
        abstract clear: string with get, set

    and [<AllowNullLiteral>] HTMLBRElementType =
        abstract prototype: HTMLBRElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBRElement

    and [<AllowNullLiteral>] HTMLBaseElement =
        inherit HTMLElement
        /// Sets or retrieves a destination URL or an anchor point.
        abstract href: string with get, set
        /// Sets or retrieves the window or frame at which to target content.
        abstract target: string with get, set

    and [<AllowNullLiteral>] HTMLBaseElementType =
        abstract prototype: HTMLBaseElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBaseElement

    and [<AllowNullLiteral>] HTMLBaseFontElement =
        inherit HTMLElement
        inherit DOML2DeprecatedColorProperty
        /// Sets or retrieves the current typeface family.
        abstract face: string with get, set
        /// Sets or retrieves the font size of the object.
        abstract size: float with get, set
        /// <param name="element">Variant of type Number that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
        /// <param name="before">Variant of type Object that specifies an element to insert before, or null to append the object to the collection.</param>
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLBaseFontElementType =
        abstract prototype: HTMLBaseFontElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBaseFontElement

    and [<AllowNullLiteral>] HTMLBlockElement =
        inherit HTMLElement
        /// Sets or retrieves reference information about the object.
        abstract cite: string with get, set
        abstract clear: string with get, set
        /// Sets or retrieves the width of the object.
        abstract width: float with get, set

    and [<AllowNullLiteral>] HTMLBlockElementType =
        abstract prototype: HTMLBlockElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBlockElement

    and [<AllowNullLiteral>] HTMLBodyElement =
        inherit HTMLElement
        abstract aLink: obj with get, set
        abstract background: string with get, set
        abstract bgColor: obj with get, set
        abstract bgProperties: string with get, set
        abstract link: obj with get, set
        /// Sets or retrieves whether the browser automatically performs wordwrap.
        abstract noWrap: bool with get, set
        abstract onafterprint: (Event -> 'Out) with get, set
        abstract onbeforeprint: (Event -> 'Out) with get, set
        abstract onbeforeunload: (BeforeUnloadEvent -> 'Out) with get, set
        abstract onblur: (FocusEvent -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onfocus: (FocusEvent -> 'Out) with get, set
        abstract onhashchange: (HashChangeEvent -> 'Out) with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract onmessage: (MessageEvent -> 'Out) with get, set
        abstract onoffline: (Event -> 'Out) with get, set
        abstract ononline: (Event -> 'Out) with get, set
        abstract onorientationchange: (Event -> 'Out) with get, set
        abstract onpagehide: (PageTransitionEvent -> 'Out) with get, set
        abstract onpageshow: (PageTransitionEvent -> 'Out) with get, set
        abstract onpopstate: (PopStateEvent -> 'Out) with get, set
        abstract onresize: (UIEvent -> 'Out) with get, set
        abstract onstorage: (StorageEvent -> 'Out) with get, set
        abstract onunload: (Event -> 'Out) with get, set
        /// Sets or retrieves the text string specified by the option tag.
        abstract text: obj with get, set
        abstract vLink: obj with get, set
        abstract createTextRange: unit -> TextRange
        /// <param name="before">Variant of type Object that specifies an element to insert before, or null to append the object to the collection.</param>
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLBodyElementType =
        abstract prototype: HTMLBodyElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLBodyElement

    and [<AllowNullLiteral>] HTMLButtonElement =
        inherit HTMLElement
        /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
        abstract autofocus: bool with get, set
        abstract disabled: bool with get, set
        /// Retrieves a reference to the form that the object is embedded in.
        abstract form: HTMLFormElement with get, set
        /// Overrides the action attribute (where the data on a form is sent) on the parent form element.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formAction: string with get, set
        /// Used to override the encoding (formEnctype attribute) specified on the form element.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formEnctype: string with get, set
        /// Overrides the submit method attribute previously specified on a form element.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formMethod: string with get, set
        /// Overrides any validation or required attributes on a form or form elements to allow it to be submitted without validation. This can be used to create a "save draft"-type submit option.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formNoValidate: string with get, set
        /// Overrides the target attribute on a form element.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formTarget: string with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set
        /// Sets or retrieves the value indicating whether the control is selected.
        abstract status: obj with get, set
        /// Returns the content type of the object.
        abstract ``type``: string with get, set
        /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
        abstract validationMessage: string with get, set
        /// Returns a  ValidityState object that represents the validity states of an element.
        abstract validity: ValidityState with get, set
        /// Sets or retrieves the default or selected value of the control.
        abstract value: string with get, set
        /// Returns whether an element will successfully validate based on forms validation rules and constraints.
        abstract willValidate: bool with get, set
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        abstract createTextRange: unit -> TextRange
        /// <summary>Sets a custom error message that is displayed when a form is submitted.</summary>
        /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
        abstract setCustomValidity: error: string -> unit

    and [<AllowNullLiteral>] HTMLButtonElementType =
        abstract prototype: HTMLButtonElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLButtonElement

    and [<AllowNullLiteral>] HTMLCanvasElement =
        inherit HTMLElement
        /// Gets or sets the height of a canvas element on a document.
        abstract height: float with get, set
        /// Sets or retrieves the width of the object.
        abstract width: float with get, set
        [<Emit("$0.getContext('2d'{{, $1}})")>]  abstract getContext_2d: ?contextAttributes: obj -> CanvasRenderingContext2D
        /// Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document. A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
        abstract getContext: contextId: string * ?contextAttributes: obj -> obj
        /// <summary>Returns the content of the current canvas as an image that you can use as a source for another canvas or an HTML element.</summary>
        /// <param name="type">The standard MIME type for the image format to return. If you do not specify this parameter, the default value is a PNG format image.</param>
        abstract toDataURL: ?``type``: string * [<ParamArray>] args: obj[] -> string
        /// Returns a blob object encoded as a Portable Network Graphics (PNG) format from a canvas image or drawing.
        abstract toBlob : (Blob -> unit) * ?mimeType:string * ?quality: float -> unit

    and [<AllowNullLiteral>] HTMLCanvasElementType =
        abstract prototype: HTMLCanvasElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLCanvasElement

    and [<AllowNullLiteral>] HTMLCollection =
        /// Sets or retrieves the number of objects in a collection.
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Element with get, set
        /// Retrieves an object from various collections.
        abstract item: ?nameOrIndex: obj * ?optionalIndex: obj -> Element
        /// Retrieves a form object or an object from an elements collection.
        /// Sets or retrieves the frame name.
        abstract namedItem: name: string -> Element

    and [<AllowNullLiteral>] HTMLCollectionType =
        abstract prototype: HTMLCollection with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLCollection

    and [<AllowNullLiteral>] HTMLDDElement =
        inherit HTMLElement
        /// Sets or retrieves whether the browser automatically performs wordwrap.
        abstract noWrap: bool with get, set

    and [<AllowNullLiteral>] HTMLDDElementType =
        abstract prototype: HTMLDDElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDDElement

    and [<AllowNullLiteral>] HTMLDListElement =
        inherit HTMLElement
        abstract compact: bool with get, set

    and [<AllowNullLiteral>] HTMLDListElementType =
        abstract prototype: HTMLDListElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDListElement

    and [<AllowNullLiteral>] HTMLDTElement =
        inherit HTMLElement
        abstract noWrap: bool with get, set

    and [<AllowNullLiteral>] HTMLDTElementType =
        abstract prototype: HTMLDTElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDTElement

    and [<AllowNullLiteral>] HTMLDataListElement =
        inherit HTMLElement
        abstract options: HTMLCollection with get, set

    and [<AllowNullLiteral>] HTMLDataListElementType =
        abstract prototype: HTMLDataListElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDataListElement

    and [<AllowNullLiteral>] HTMLDirectoryElement =
        inherit HTMLElement
        abstract compact: bool with get, set

    and [<AllowNullLiteral>] HTMLDirectoryElementType =
        abstract prototype: HTMLDirectoryElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDirectoryElement

    and [<AllowNullLiteral>] HTMLDivElement =
        inherit HTMLElement
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        abstract noWrap: bool with get, set

    and [<AllowNullLiteral>] HTMLDivElementType =
        abstract prototype: HTMLDivElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDivElement

    and [<AllowNullLiteral>] HTMLDocument =
        inherit Document


    and [<AllowNullLiteral>] HTMLDocumentType =
        abstract prototype: HTMLDocument with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLDocument

    and [<AllowNullLiteral>] HTMLElement =
        inherit Element
        abstract accessKey: string with get, set
        abstract children: HTMLCollection with get, set
        abstract contentEditable: string with get, set
        /// Sets or retrieves the URL that references the data of the object.
        abstract dataset: DOMStringMap with get, set
        abstract dir: string with get, set
        abstract draggable: bool with get, set
        abstract hidden: bool with get, set
        abstract hideFocus: bool with get, set
        abstract innerHTML: string with get, set
        abstract innerText: string with get, set
        abstract isContentEditable: bool with get, set
        abstract lang: string with get, set
        abstract offsetHeight: float with get, set
        abstract offsetLeft: float with get, set
        abstract offsetParent: Element with get, set
        abstract offsetTop: float with get, set
        abstract offsetWidth: float with get, set
        abstract onabort: (Event -> 'Out) with get, set
        abstract onactivate: (UIEvent -> 'Out) with get, set
        abstract onbeforeactivate: (UIEvent -> 'Out) with get, set
        abstract onbeforecopy: (DragEvent -> 'Out) with get, set
        abstract onbeforecut: (DragEvent -> 'Out) with get, set
        abstract onbeforedeactivate: (UIEvent -> 'Out) with get, set
        abstract onbeforepaste: (DragEvent -> 'Out) with get, set
        abstract onblur: (FocusEvent -> 'Out) with get, set
        abstract oncanplay: (Event -> 'Out) with get, set
        abstract oncanplaythrough: (Event -> 'Out) with get, set
        abstract onchange: (Event -> 'Out) with get, set
        abstract onclick: (MouseEvent -> 'Out) with get, set
        abstract oncontextmenu: (PointerEvent -> 'Out) with get, set
        abstract oncopy: (DragEvent -> 'Out) with get, set
        abstract oncuechange: (Event -> 'Out) with get, set
        abstract oncut: (DragEvent -> 'Out) with get, set
        abstract ondblclick: (MouseEvent -> 'Out) with get, set
        abstract ondeactivate: (UIEvent -> 'Out) with get, set
        abstract ondrag: (DragEvent -> 'Out) with get, set
        abstract ondragend: (DragEvent -> 'Out) with get, set
        abstract ondragenter: (DragEvent -> 'Out) with get, set
        abstract ondragleave: (DragEvent -> 'Out) with get, set
        abstract ondragover: (DragEvent -> 'Out) with get, set
        abstract ondragstart: (DragEvent -> 'Out) with get, set
        abstract ondrop: (DragEvent -> 'Out) with get, set
        abstract ondurationchange: (Event -> 'Out) with get, set
        abstract onemptied: (Event -> 'Out) with get, set
        abstract onended: (Event -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onfocus: (FocusEvent -> 'Out) with get, set
        abstract oninput: (Event -> 'Out) with get, set
        abstract onkeydown: (KeyboardEvent -> 'Out) with get, set
        abstract onkeypress: (KeyboardEvent -> 'Out) with get, set
        abstract onkeyup: (KeyboardEvent -> 'Out) with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract onloadeddata: (Event -> 'Out) with get, set
        abstract onloadedmetadata: (Event -> 'Out) with get, set
        abstract onloadstart: (Event -> 'Out) with get, set
        abstract onmousedown: (MouseEvent -> 'Out) with get, set
        abstract onmouseenter: (MouseEvent -> 'Out) with get, set
        abstract onmouseleave: (MouseEvent -> 'Out) with get, set
        abstract onmousemove: (MouseEvent -> 'Out) with get, set
        abstract onmouseout: (MouseEvent -> 'Out) with get, set
        abstract onmouseover: (MouseEvent -> 'Out) with get, set
        abstract onmouseup: (MouseEvent -> 'Out) with get, set
        abstract onmousewheel: (MouseWheelEvent -> 'Out) with get, set
        abstract onpaste: (DragEvent -> 'Out) with get, set
        abstract onpause: (Event -> 'Out) with get, set
        abstract onplay: (Event -> 'Out) with get, set
        abstract onplaying: (Event -> 'Out) with get, set
        abstract onprogress: (ProgressEvent -> 'Out) with get, set
        abstract onratechange: (Event -> 'Out) with get, set
        abstract onreset: (Event -> 'Out) with get, set
        abstract onscroll: (UIEvent -> 'Out) with get, set
        abstract onseeked: (Event -> 'Out) with get, set
        abstract onseeking: (Event -> 'Out) with get, set
        abstract onselect: (UIEvent -> 'Out) with get, set
        abstract onselectstart: (Event -> 'Out) with get, set
        abstract onstalled: (Event -> 'Out) with get, set
        abstract onsubmit: (Event -> 'Out) with get, set
        abstract onsuspend: (Event -> 'Out) with get, set
        abstract ontimeupdate: (Event -> 'Out) with get, set
        abstract onvolumechange: (Event -> 'Out) with get, set
        abstract onwaiting: (Event -> 'Out) with get, set
        abstract outerHTML: string with get, set
        abstract outerText: string with get, set
        abstract spellcheck: bool with get, set
        // abstract style: CSSStyleDeclaration with get, set
        abstract tabIndex: float with get, set
        abstract title: string with get, set
        abstract blur: unit -> unit
        abstract click: unit -> unit
        abstract dragDrop: unit -> bool
        abstract focus: unit -> unit
        abstract insertAdjacentElement: position: string * insertedElement: Element -> Element
        abstract insertAdjacentHTML: where: string * html: string -> unit
        abstract insertAdjacentText: where: string * text: string -> unit
        abstract scrollIntoView: ?top: bool -> unit
        abstract setActive: unit -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLElementType =
        abstract prototype: HTMLElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLElement

    and [<AllowNullLiteral>] HTMLEmbedElement =
        inherit HTMLElement
        inherit GetSVGDocument
        /// Sets or retrieves the height of the object.
        abstract height: string with get, set
        abstract hidden: obj with get, set
        /// Sets or retrieves the frame name.
        abstract name: string with get, set
        /// Retrieves the palette used for the embedded document.
        abstract palette: string with get, set
        /// Retrieves the URL of the plug-in used to view an embedded document.
        abstract pluginspage: string with get, set
        abstract readyState: string with get, set
        /// Sets or retrieves a URL to be loaded by the object.
        abstract src: string with get, set
        /// Sets or retrieves the height and width units of the embed object.
        abstract units: string with get, set
        /// Sets or retrieves the width of the object.
        abstract width: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLEmbedElementType =
        abstract prototype: HTMLEmbedElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLEmbedElement

    and [<AllowNullLiteral>] HTMLFieldSetElement =
        inherit HTMLElement
        /// Sets or retrieves a value that indicates the table alignment.
        abstract align: string with get, set
        abstract disabled: bool with get, set
        /// Retrieves a reference to the form that the object is embedded in.
        abstract form: HTMLFormElement with get, set
        /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
        abstract validationMessage: string with get, set
        /// Returns a  ValidityState object that represents the validity states of an element.
        abstract validity: ValidityState with get, set
        /// Returns whether an element will successfully validate based on forms validation rules and constraints.
        abstract willValidate: bool with get, set
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
        abstract setCustomValidity: error: string -> unit

    and [<AllowNullLiteral>] HTMLFieldSetElementType =
        abstract prototype: HTMLFieldSetElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFieldSetElement

    and [<AllowNullLiteral>] HTMLFontElement =
        inherit HTMLElement
        inherit DOML2DeprecatedColorProperty
        inherit DOML2DeprecatedSizeProperty
        /// Sets or retrieves the current typeface family.
        abstract face: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLFontElementType =
        abstract prototype: HTMLFontElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFontElement

    and [<AllowNullLiteral>] HTMLFormElement =
        inherit HTMLElement
        /// Sets or retrieves a list of character encodings for input data that must be accepted by the server processing the form.
        /// Sets or retrieves a comma-separated list of content types.
        abstract acceptCharset: string with get, set
        /// Sets or retrieves the URL to which the form content is sent for processing.
        abstract action: string with get, set
        /// Specifies whether autocomplete is applied to an editable text field.
        abstract autocomplete: string with get, set
        /// Retrieves a collection, in source order, of all controls in a given form.
        abstract elements: HTMLCollection with get, set
        /// Sets or retrieves the MIME encoding for the form.
        abstract encoding: string with get, set
        /// Sets or retrieves the encoding type for the form.
        abstract enctype: string with get, set
        /// Sets or retrieves the number of objects in a collection.
        abstract length: float with get, set
        /// Sets or retrieves how to send the form data to the server.
        abstract ``method``: string with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set
        /// Designates a form that is not validated when submitted.
        abstract noValidate: bool with get, set
        /// Sets or retrieves the window or frame at which to target content.
        abstract target: string with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> obj with get, set
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        /// <summary>Retrieves a form object or an object from an elements collection.</summary>
        /// <param name="name">Variant of type Number or String that specifies the object or collection to retrieve. If this parameter is a Number, it is the zero-based index of the object. If this parameter is a string, all objects with matching name or id properties are retrieved, and a collection is returned if more than one match is made.</param>
        /// <param name="index">Variant of type Number that specifies the zero-based index of the object to retrieve when a collection is returned.</param>
        abstract item: ?name: obj * ?index: obj -> obj
        /// Sets or retrieves the name of the object.
        /// Retrieves a select object or an object from an options collection.
        abstract namedItem: name: string -> obj
        /// Fires when the user resets a form.
        abstract reset: unit -> unit
        /// Fires when a FORM is about to be submitted.
        abstract submit: unit -> unit

    and [<AllowNullLiteral>] HTMLFormElementType =
        abstract prototype: HTMLFormElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFormElement

    and [<AllowNullLiteral>] HTMLFrameElement =
        inherit HTMLElement
        inherit GetSVGDocument
        /// Specifies the properties of a border drawn around an object.
        abstract border: string with get, set
        /// Sets or retrieves the border color of the object.
        /// Specifies the properties of a border drawn around an object.
        abstract borderColor: obj with get, set
        /// Retrieves the document object of the page or frame.
        abstract contentDocument: Document with get, set
        /// Retrieves the object of the specified.
        abstract contentWindow: Window with get, set
        /// Sets or retrieves whether to display a border for the frame.
        /// Sets or retrieves the way the border frame around the table is displayed.
        abstract frameBorder: string with get, set
        /// Sets or retrieves the amount of additional space between the frames.
        abstract frameSpacing: obj with get, set
        /// Sets or retrieves the height of the object.
        abstract height: U2<string, float> with get, set
        /// Sets or retrieves a URI to a long description of the object.
        abstract longDesc: string with get, set
        /// Sets or retrieves the top and bottom margin heights before displaying the text in a frame.
        abstract marginHeight: string with get, set
        /// Sets or retrieves the left and right margin widths before displaying the text in a frame.
        abstract marginWidth: string with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set
        /// Sets or retrieves whether the user can resize the frame.
        abstract noResize: bool with get, set
        abstract onload: (Event -> 'Out) with get, set
        /// Sets or retrieves whether the frame can be scrolled.
        abstract scrolling: string with get, set
        abstract security: obj with get, set
        /// Sets or retrieves a URL to be loaded by the object.
        abstract src: string with get, set
        /// Sets or retrieves the width of the object.
        abstract width: U2<string, float> with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLFrameElementType =
        abstract prototype: HTMLFrameElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFrameElement

    and [<AllowNullLiteral>] HTMLFrameSetElement =
        inherit HTMLElement
        /// Sets or retrieves the width of the border to draw around the object.
        abstract border: string with get, set
        /// Sets or retrieves the border color of the object.
        /// Sets or retrieves the width of the border to draw around the object.
        abstract borderColor: obj with get, set
        /// Sets or retrieves the frame widths of the object.
        abstract cols: string with get, set
        /// Sets or retrieves whether to display a border for the frame.
        abstract frameBorder: string with get, set
        /// Sets or retrieves the amount of additional space between the frames.
        abstract frameSpacing: obj with get, set
        /// Sets or retrieves the value specified in the content attribute of the meta object.
        abstract name: string with get, set
        abstract onafterprint: (Event -> 'Out) with get, set
        abstract onbeforeprint: (Event -> 'Out) with get, set
        abstract onbeforeunload: (BeforeUnloadEvent -> 'Out) with get, set
        abstract onblur: (FocusEvent -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onfocus: (FocusEvent -> 'Out) with get, set
        abstract onhashchange: (HashChangeEvent -> 'Out) with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract onmessage: (MessageEvent -> 'Out) with get, set
        abstract onoffline: (Event -> 'Out) with get, set
        abstract ononline: (Event -> 'Out) with get, set
        abstract onorientationchange: (Event -> 'Out) with get, set
        abstract onpagehide: (PageTransitionEvent -> 'Out) with get, set
        abstract onpageshow: (PageTransitionEvent -> 'Out) with get, set
        abstract onresize: (UIEvent -> 'Out) with get, set
        abstract onstorage: (StorageEvent -> 'Out) with get, set
        abstract onunload: (Event -> 'Out) with get, set
        /// Sets or retrieves the frame heights of the object.
        abstract rows: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLFrameSetElementType =
        abstract prototype: HTMLFrameSetElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLFrameSetElement

    and [<AllowNullLiteral>] HTMLHRElement =
        inherit HTMLElement
        inherit DOML2DeprecatedColorProperty
        inherit DOML2DeprecatedSizeProperty
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        /// Sets or retrieves whether the horizontal rule is drawn with 3-D shading.
        abstract noShade: bool with get, set
        /// Sets or retrieves the width of the object.
        abstract width: float with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLHRElementType =
        abstract prototype: HTMLHRElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHRElement

    and [<AllowNullLiteral>] HTMLHeadElement =
        inherit HTMLElement
        abstract profile: string with get, set

    and [<AllowNullLiteral>] HTMLHeadElementType =
        abstract prototype: HTMLHeadElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHeadElement

    and [<AllowNullLiteral>] HTMLHeadingElement =
        inherit HTMLElement
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        abstract clear: string with get, set

    and [<AllowNullLiteral>] HTMLHeadingElementType =
        abstract prototype: HTMLHeadingElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHeadingElement

    and [<AllowNullLiteral>] HTMLHtmlElement =
        inherit HTMLElement
        /// Sets or retrieves the DTD version that governs the current document.
        abstract version: string with get, set

    and [<AllowNullLiteral>] HTMLHtmlElementType =
        abstract prototype: HTMLHtmlElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLHtmlElement

    and [<AllowNullLiteral>] HTMLIFrameElement =
        inherit HTMLElement
        inherit GetSVGDocument
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        abstract allowFullscreen: bool with get, set
        abstract border: string with get, set
        /// Retrieves the document object of the page or frame.
        abstract contentDocument: Document with get, set
        /// Retrieves the object of the specified.
        abstract contentWindow: Window with get, set
        /// Sets or retrieves whether to display a border for the frame.
        abstract frameBorder: string with get, set
        /// Sets or retrieves the amount of additional space between the frames.
        abstract frameSpacing: obj with get, set
        /// Sets or retrieves the height of the object.
        abstract height: string with get, set
        /// Sets or retrieves the width of the border to draw around the object.
        abstract hspace: float with get, set
        /// Sets or retrieves a URI to a long description of the object.
        abstract longDesc: string with get, set
        /// Sets or retrieves the top and bottom margin heights before displaying the text in a frame.
        abstract marginHeight: string with get, set
        /// Sets or retrieves the left and right margin widths before displaying the text in a frame.
        abstract marginWidth: string with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set
        /// Sets or retrieves whether the user can resize the frame.
        abstract noResize: bool with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract sandbox: DOMSettableTokenList with get, set
        /// Sets or retrieves whether the frame can be scrolled.
        abstract scrolling: string with get, set
        abstract security: obj with get, set
        /// Sets or retrieves a URL to be loaded by the object.
        abstract src: string with get, set
        /// Sets or retrieves the vertical margin for the object.
        abstract vspace: float with get, set
        /// Sets or retrieves the width of the object.
        abstract width: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLIFrameElementType =
        abstract prototype: HTMLIFrameElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLIFrameElement

    and [<AllowNullLiteral>] HTMLImageElement =
        inherit HTMLElement
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        /// Sets or retrieves a text alternative to the graphic.
        abstract alt: string with get, set
        abstract border: string with get, set
        /// Retrieves whether the object is fully loaded.
        abstract complete: bool with get, set
        abstract crossOrigin: string with get, set
        /// Gets the address or URL of the current media resource that is selected by IHTMLMediaElement.
        abstract currentSrc: string with get, set
        /// Sets or retrieves the height of the object.
        abstract height: float with get, set
        /// Sets or retrieves the width of the border to draw around the object.
        abstract hspace: float with get, set
        /// Sets or retrieves whether the image is a server-side image map.
        abstract isMap: bool with get, set
        /// Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
        abstract longDesc: string with get, set
        /// Sets or retrieves the name of an input parameter for an element.
        abstract name: string with get, set
        /// The original height of the image resource before sizing.
        abstract naturalHeight: float with get, set
        /// The original width of the image resource before sizing.
        abstract naturalWidth: float with get, set
        /// The address or URL of the a media resource that is to be considered.
        abstract src: string with get, set
        /// The address or URL of the a media resource that is to be considered.
        abstract srcset: string with get, set
        /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        abstract useMap: string with get, set
        /// Sets or retrieves the vertical margin for the object.
        abstract vspace: float with get, set
        /// Sets or retrieves the width of the object.
        abstract width: float with get, set
        abstract x: float with get, set
        abstract y: float with get, set

    and [<AllowNullLiteral>] HTMLImageElementType =
        abstract prototype: HTMLImageElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLImageElement
        abstract create: unit -> HTMLImageElement

    and [<AllowNullLiteral>] HTMLInputElement =
        inherit HTMLElement
        abstract accept: string with get, set
        /// Retrieves a reference to the form that the object is embedded in.
        abstract align: string with get, set
        /// Sets or retrieves a text alternative to the graphic.
        abstract alt: string with get, set
        /// Specifies whether autocomplete is applied to an editable text field.
        abstract autocomplete: string with get, set
        /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
        abstract autofocus: bool with get, set
        abstract border: string with get, set
        /// Sets or retrieves the state of the check box or radio button.
        abstract ``checked``: bool with get, set
        /// Retrieves whether the object is fully loaded.
        abstract complete: bool with get, set
        /// Sets or retrieves the state of the check box or radio button.
        abstract defaultChecked: bool with get, set
        /// Sets or retrieves the initial contents of the object.
        abstract defaultValue: string with get, set
        abstract disabled: bool with get, set
        /// Returns a FileList object on a file type input object.
        abstract files: FileList with get, set
        /// Retrieves a reference to the form that the object is embedded in.
        abstract form: HTMLFormElement with get, set
        /// Overrides the action attribute (where the data on a form is sent) on the parent form element.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formAction: string with get, set
        /// Used to override the encoding (formEnctype attribute) specified on the form element.
        /// Retrieves a reference to the form that the object is embedded in.
        abstract formEnctype: string with get, set
        /// Overrides the submit method attribute previously specified on a form element.
        abstract formMethod: string with get, set
        /// Overrides any validation or required attributes on a form or form elements to allow it to be submitted without validation. This can be used to create a "save draft"-type submit option.
        abstract formNoValidate: string with get, set
        /// Overrides the target attribute on a form element.
        abstract formTarget: string with get, set
        /// Sets or retrieves the height of the object.
        abstract height: string with get, set
        abstract hspace: float with get, set
        abstract indeterminate: bool with get, set
        /// Specifies the ID of a pre-defined datalist of options for an input element.
        abstract list: HTMLElement with get, set
        /// Defines the maximum acceptable value for an input element with type="number".When used with the min and step attributes, lets you control the range and increment (such as only even numbers) that the user can enter into an input field.
        abstract max: string with get, set
        /// Sets or retrieves the maximum number of characters that the user can enter in a text control.
        /// Defines the maximum, or "done" value for a progress element.
        abstract maxLength: float with get, set
        /// Defines the minimum acceptable value for an input element with type="number". When used with the max and step attributes, lets you control the range and increment (such as even numbers only) that the user can enter into an input field.
        abstract min: string with get, set
        /// Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
        abstract multiple: bool with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set
        /// Gets or sets a string containing a regular expression that the user's input must match.
        abstract pattern: string with get, set
        /// Gets or sets a text string that is displayed in an input field as a hint or prompt to users as the format or type of information they need to enter.The text appears in an input field until the user puts focus on the field.
        abstract placeholder: string with get, set
        /// Sets or retrieves the value indicated whether the content of the object is read-only.
        abstract readOnly: bool with get, set
        /// When present, marks an element that can't be submitted without a value.
        abstract required: bool with get, set
        /// Gets or sets the end position or offset of a text selection.
        /// Makes the selection equal to the current object.
        abstract selectionEnd: float with get, set
        /// Gets or sets the starting position or offset of a text selection.
        /// Highlights the input area of a form element.
        abstract selectionStart: float with get, set
        /// Sets or retrieves the number of rows in the list box.
        abstract size: float with get, set
        /// The address or URL of the a media resource that is to be considered.
        abstract src: string with get, set
        abstract status: bool with get, set
        /// Defines an increment or jump between values that you want to allow the user to enter. When used with the max and min attributes, lets you control the range and increment (for example, allow only even numbers) that the user can enter into an input field.
        abstract step: string with get, set
        /// Sets or retrieves the MIME type of the object.
        abstract ``type``: string with get, set
        /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        abstract useMap: string with get, set
        /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
        abstract validationMessage: string with get, set
        /// Returns a  ValidityState object that represents the validity states of an element.
        abstract validity: ValidityState with get, set
        /// Returns the value of the data at the cursor's current position.
        abstract value: string with get, set
        /// Sets or retrieves the value of a list item.
        abstract valueAsDate: DateTime with get, set
        /// Returns the input field value as a number.
        /// Sets or retrieves the value which is returned to the server when the form control is submitted.
        abstract valueAsNumber: float with get, set
        abstract vspace: float with get, set
        /// Sets or gets a value that you can use to implement your own width functionality for the object.
        abstract width: string with get, set
        /// Returns whether an element will successfully validate based on forms validation rules and constraints.
        abstract willValidate: bool with get, set
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        abstract createTextRange: unit -> TextRange
        abstract select: unit -> unit
        /// <summary>Sets a custom error message that is displayed when a form is submitted.</summary>
        /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
        abstract setCustomValidity: error: string -> unit
        /// <summary>Sets the start and end positions of a selection in a text field.</summary>
        /// <param name="start">The offset into the text field for the start of the selection.</param>
        /// <param name="end">The offset into the text field for the end of the selection.</param>
        abstract setSelectionRange: start: float * ``end``: float -> unit
        /// <summary>Decrements a range input control's value by the value given by the Step attribute. If the optional parameter is used, it will decrement the input control's step value multiplied by the parameter's value.</summary>
        /// <param name="n">Value to decrement the value by.</param>
        abstract stepDown: ?n: float -> unit
        /// <summary>Increments a range input control's value by the value given by the Step attribute. If the optional parameter is used, will increment the input control's value by that value.</summary>
        /// <param name="n">Value to increment the value by.</param>
        abstract stepUp: ?n: float -> unit

    and [<AllowNullLiteral>] HTMLInputElementType =
        abstract prototype: HTMLInputElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLInputElement

    and [<AllowNullLiteral>] HTMLIsIndexElement =
        inherit HTMLElement
        abstract action: string with get, set
        abstract form: HTMLFormElement with get, set
        abstract prompt: string with get, set

    and [<AllowNullLiteral>] HTMLIsIndexElementType =
        abstract prototype: HTMLIsIndexElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLIsIndexElement

    and [<AllowNullLiteral>] HTMLLIElement =
        inherit HTMLElement
        /// Sets or retrieves the MIME type of the object.
        abstract ``type``: string with get, set
        /// Sets or retrieves the value which is returned to the server when the form control is submitted.
        abstract value: float with get, set

    and [<AllowNullLiteral>] HTMLLIElementType =
        abstract prototype: HTMLLIElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLIElement

    and [<AllowNullLiteral>] HTMLLabelElement =
        inherit HTMLElement
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the object to which the given label object is assigned.
        abstract htmlFor: string with get, set

    and [<AllowNullLiteral>] HTMLLabelElementType =
        abstract prototype: HTMLLabelElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLabelElement

    and [<AllowNullLiteral>] HTMLLegendElement =
        inherit HTMLElement
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        abstract form: HTMLFormElement with get, set

    and [<AllowNullLiteral>] HTMLLegendElementType =
        abstract prototype: HTMLLegendElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLegendElement

    and [<AllowNullLiteral>] HTMLLinkElement =
        inherit HTMLElement
        // inherit LinkStyle
        /// Sets or retrieves the character set used to encode the object.
        abstract charset: string with get, set
        abstract disabled: bool with get, set
        abstract href: string with get, set
        /// Sets or retrieves the language code of the object.
        abstract hreflang: string with get, set
        /// Sets or retrieves the media type.
        abstract media: string with get, set
        abstract rel: string with get, set
        /// Sets or retrieves the relationship between the object and the destination of the link.
        abstract rev: string with get, set
        /// Sets or retrieves the window or frame at which to target content.
        abstract target: string with get, set
        /// Sets or retrieves the content type of the resource designated by the value attribute.
        abstract ``type``: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLLinkElementType =
        abstract prototype: HTMLLinkElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLLinkElement

    and [<AllowNullLiteral>] HTMLMapElement =
        inherit HTMLElement
        /// Retrieves a collection of the area objects defined for the given map object.
        abstract areas: HTMLAreasCollection with get, set
        /// Sets or retrieves the name of the object.
        abstract name: string with get, set

    and [<AllowNullLiteral>] HTMLMapElementType =
        abstract prototype: HTMLMapElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMapElement

    and [<AllowNullLiteral>] HTMLMarqueeElement =
        inherit HTMLElement
        abstract behavior: string with get, set
        abstract bgColor: obj with get, set
        abstract direction: string with get, set
        /// Sets or retrieves the height of the object.
        abstract height: string with get, set
        abstract hspace: float with get, set
        /// Gets or sets a flag to specify whether playback should restart after it completes.
        abstract loop: float with get, set
        abstract onbounce: (Event -> 'Out) with get, set
        abstract onfinish: (Event -> 'Out) with get, set
        abstract onstart: (Event -> 'Out) with get, set
        abstract scrollAmount: float with get, set
        abstract scrollDelay: float with get, set
        abstract trueSpeed: bool with get, set
        abstract vspace: float with get, set
        /// Sets or retrieves the width of the object.
        abstract width: string with get, set
        /// The starting number.
        abstract start: unit -> unit
        abstract stop: unit -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLMarqueeElementType =
        abstract prototype: HTMLMarqueeElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMarqueeElement

    and [<AllowNullLiteral>] HTMLMediaElement =
        inherit HTMLElement
        /// Returns an AudioTrackList object with the audio tracks for a given video element.
        abstract audioTracks: AudioTrackList with get, set
        /// Gets or sets a value that indicates whether to start playing the media automatically.
        abstract autoplay: bool with get, set
        /// Gets a collection of buffered time ranges.
        abstract buffered: TimeRanges with get, set
        /// Gets or sets a flag that indicates whether the client provides a set of controls for the media (in case the developer does not include controls for the player).
        abstract controls: bool with get, set
        abstract currentSrc: string with get, set
        /// Gets or sets the current playback position, in seconds.
        abstract currentTime: float with get, set
        abstract defaultMuted: bool with get, set
        /// Gets or sets the default playback rate when the user is not using fast forward or reverse for a video or audio resource.
        abstract defaultPlaybackRate: float with get, set
        /// Returns the duration in seconds of the current media resource. A NaN value is returned if duration is not available, or Infinity if the media resource is streaming.
        abstract duration: float with get, set
        /// Gets information about whether the playback has ended or not.
        abstract ended: bool with get, set
        /// Returns an object representing the current error state of the audio or video element.
        abstract error: MediaError with get, set
        abstract loop: bool with get, set
        /// Gets or sets a flag that indicates whether the audio (either audio or the audio track on video media) is muted.
        abstract muted: bool with get, set
        /// Gets the current network activity for the element.
        abstract networkState: float with get, set
        /// Gets a flag that specifies whether playback is paused.
        /// Pauses the current playback and sets paused to TRUE. This can be used to test whether the media is playing or paused. You can also use the pause or play events to tell whether the media is playing or not.
        abstract paused: bool with get, set
        /// Gets or sets the current rate of speed for the media resource to play. This speed is expressed as a multiple of the normal speed of the media resource.
        /// Loads and starts playback of a media resource.
        abstract playbackRate: float with get, set
        /// Gets TimeRanges for the current media resource that has been played.
        abstract played: TimeRanges with get, set
        /// Gets or sets the current playback position, in seconds.
        abstract preload: string with get, set
        abstract readyState: float with get, set
        /// Returns a TimeRanges object that represents the ranges of the current media resource that can be seeked.
        abstract seekable: TimeRanges with get, set
        /// Gets a flag that indicates whether the the client is currently moving to a new playback position in the media resource.
        abstract seeking: bool with get, set
        /// Retrieves the URL to an external file that contains the source code or data.
        abstract src: string with get, set
        /// Sets or retrieves the text string specified by the option tag.
        abstract textTracks: TextTrackList with get, set
        abstract videoTracks: VideoTrackList with get, set
        /// Gets or sets the volume level for audio portions of the media element.
        abstract volume: float with get, set
        abstract HAVE_CURRENT_DATA: float with get, set
        abstract HAVE_ENOUGH_DATA: float with get, set
        abstract HAVE_FUTURE_DATA: float with get, set
        abstract HAVE_METADATA: float with get, set
        abstract HAVE_NOTHING: float with get, set
        abstract NETWORK_EMPTY: float with get, set
        abstract NETWORK_IDLE: float with get, set
        abstract NETWORK_LOADING: float with get, set
        abstract NETWORK_NO_SOURCE: float with get, set
        abstract addTextTrack: kind: string * ?label: string * ?language: string -> TextTrack
        /// Returns a string that specifies whether the client can play a given media resource type.
        abstract canPlayType: ``type``: string -> string
        /// Resets the audio or video object and loads a new media resource.
        abstract load: unit -> unit
        abstract pause: unit -> unit
        abstract play: unit -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLMediaElementType =
        abstract prototype: HTMLMediaElement with get, set
        abstract HAVE_CURRENT_DATA: float with get, set
        abstract HAVE_ENOUGH_DATA: float with get, set
        abstract HAVE_FUTURE_DATA: float with get, set
        abstract HAVE_METADATA: float with get, set
        abstract HAVE_NOTHING: float with get, set
        abstract NETWORK_EMPTY: float with get, set
        abstract NETWORK_IDLE: float with get, set
        abstract NETWORK_LOADING: float with get, set
        abstract NETWORK_NO_SOURCE: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMediaElement

    and [<AllowNullLiteral>] HTMLMenuElement =
        inherit HTMLElement
        abstract compact: bool with get, set
        /// Sets or retrieves the MIME type for the associated scripting engine.
        abstract ``type``: string with get, set

    and [<AllowNullLiteral>] HTMLMenuElementType =
        abstract prototype: HTMLMenuElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMenuElement

    and [<AllowNullLiteral>] HTMLMetaElement =
        inherit HTMLElement
        /// Sets or retrieves the character set used to encode the object.
        abstract charset: string with get, set
        abstract content: string with get, set
        /// Gets or sets information used to bind the value of a content attribute of a meta element to an HTTP response header.
        abstract httpEquiv: string with get, set
        abstract name: string with get, set
        /// Sets or retrieves a scheme to be used in interpreting the value of a property specified for the object.
        abstract scheme: string with get, set
        /// Sets or retrieves the URL property that will be loaded after the specified time has elapsed.
        abstract url: string with get, set

    and [<AllowNullLiteral>] HTMLMetaElementType =
        abstract prototype: HTMLMetaElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLMetaElement

    and [<AllowNullLiteral>] HTMLModElement =
        inherit HTMLElement
        /// Sets or retrieves reference information about the object.
        abstract cite: string with get, set
        /// Sets or retrieves the date and time of a modification to the object.
        abstract dateTime: string with get, set

    and [<AllowNullLiteral>] HTMLModElementType =
        abstract prototype: HTMLModElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLModElement

    and [<AllowNullLiteral>] HTMLNextIdElement =
        inherit HTMLElement
        abstract n: string with get, set

    and [<AllowNullLiteral>] HTMLNextIdElementType =
        abstract prototype: HTMLNextIdElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLNextIdElement

    and [<AllowNullLiteral>] HTMLOListElement =
        inherit HTMLElement
        abstract compact: bool with get, set
        abstract start: float with get, set
        /// Retrieves the type of select control based on the value of the MULTIPLE attribute.
        abstract ``type``: string with get, set

    and [<AllowNullLiteral>] HTMLOListElementType =
        abstract prototype: HTMLOListElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOListElement

    and [<AllowNullLiteral>] HTMLObjectElement =
        inherit HTMLElement
        inherit GetSVGDocument
        /// Retrieves a string of the URL where the object tag can be found. This is often the href of the document that the object is in, or the value set by a base element.
        abstract BaseHref: string with get, set
        /// Sets or retrieves the alignment of the caption or legend.
        abstract align: string with get, set
        abstract alt: string with get, set
        /// Gets or sets the optional alternative HTML script to execute if the object fails to load.
        abstract altHtml: string with get, set
        /// Sets or retrieves a character string that can be used to implement your own archive functionality for the object.
        abstract archive: string with get, set
        abstract border: string with get, set
        abstract code: string with get, set
        /// Sets or retrieves the URL of the component.
        abstract codeBase: string with get, set
        /// Sets or retrieves the Internet media type for the code associated with the object.
        abstract codeType: string with get, set
        /// Retrieves the document object of the page or frame.
        abstract contentDocument: Document with get, set
        abstract data: string with get, set
        abstract declare: bool with get, set
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the height of the object.
        abstract height: string with get, set
        abstract hspace: float with get, set
        abstract name: string with get, set
        abstract ``object``: obj with get, set
        abstract readyState: float with get, set
        /// Sets or retrieves a message to be displayed while an object is loading.
        abstract standby: string with get, set
        /// Gets or sets the MIME type of a media resource.
        abstract ``type``: string with get, set
        /// Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
        abstract useMap: string with get, set
        /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
        abstract validationMessage: string with get, set
        /// Returns a  ValidityState object that represents the validity states of an element.
        abstract validity: ValidityState with get, set
        abstract vspace: float with get, set
        /// Sets or retrieves the width of the object.
        abstract width: string with get, set
        /// Returns whether an element will successfully validate based on forms validation rules and constraints.
        abstract willValidate: bool with get, set
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
        abstract setCustomValidity: error: string -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLObjectElementType =
        abstract prototype: HTMLObjectElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLObjectElement

    and [<AllowNullLiteral>] HTMLOptGroupElement =
        inherit HTMLElement
        /// Sets or retrieves the status of an option.
        abstract defaultSelected: bool with get, set
        abstract disabled: bool with get, set
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the ordinal position of an option in a list box.
        abstract index: float with get, set
        /// Sets or retrieves a value that you can use to implement your own label functionality for the object.
        abstract label: string with get, set
        /// Sets or retrieves whether the option in the list box is the default item.
        abstract selected: bool with get, set
        /// Retrieves or sets the text of the object as a string.
        abstract text: string with get, set
        /// Sets or retrieves the value of an input parameter for an element.
        abstract value: string with get, set

    and [<AllowNullLiteral>] HTMLOptGroupElementType =
        abstract prototype: HTMLOptGroupElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOptGroupElement

    and [<AllowNullLiteral>] HTMLOptionElement =
        inherit HTMLElement
        /// Sets or retrieves the status of an option.
        abstract defaultSelected: bool with get, set
        abstract disabled: bool with get, set
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the ordinal position of an option in a list box.
        abstract index: float with get, set
        /// Sets or retrieves a value that you can use to implement your own label functionality for the object.
        abstract label: string with get, set
        /// Sets or retrieves whether the option in the list box is the default item.
        abstract selected: bool with get, set
        /// Retrieves or sets the text of the object as a string.
        abstract text: string with get, set
        /// Sets or gets the current value of a progress element. The value must be a non-negative number between 0 and the max value.
        abstract value: string with get, set

    and [<AllowNullLiteral>] HTMLOptionElementType =
        abstract prototype: HTMLOptionElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLOptionElement
        abstract create: unit -> HTMLOptionElement

    and [<AllowNullLiteral>] HTMLParagraphElement =
        inherit HTMLElement
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        abstract clear: string with get, set

    and [<AllowNullLiteral>] HTMLParagraphElementType =
        abstract prototype: HTMLParagraphElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLParagraphElement

    and [<AllowNullLiteral>] HTMLParamElement =
        inherit HTMLElement
        abstract name: string with get, set
        /// Retrieves the CSS language in which the style sheet is written.
        abstract ``type``: string with get, set
        /// Sets or retrieves the value which is returned to the server when the form control is submitted.
        abstract value: string with get, set
        /// Sets or retrieves the data type of the value attribute.
        /// Retrieves or sets the text in the entry field of the textArea element.
        abstract valueType: string with get, set

    and [<AllowNullLiteral>] HTMLParamElementType =
        abstract prototype: HTMLParamElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLParamElement

    and [<AllowNullLiteral>] HTMLPhraseElement =
        inherit HTMLElement
        abstract cite: string with get, set
        abstract dateTime: string with get, set

    and [<AllowNullLiteral>] HTMLPhraseElementType =
        abstract prototype: HTMLPhraseElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPhraseElement

    and [<AllowNullLiteral>] HTMLPreElement =
        inherit HTMLElement
        abstract cite: string with get, set
        abstract clear: string with get, set
        /// Sets or retrieves the width of the object.
        abstract width: float with get, set

    and [<AllowNullLiteral>] HTMLPreElementType =
        abstract prototype: HTMLPreElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPreElement

    and [<AllowNullLiteral>] HTMLProgressElement =
        inherit HTMLElement
        abstract form: HTMLFormElement with get, set
        abstract max: float with get, set
        /// Returns the quotient of value/max when the value attribute is set (determinate progress bar), or -1 when the value attribute is missing (indeterminate progress bar).
        abstract position: float with get, set
        abstract value: float with get, set

    and [<AllowNullLiteral>] HTMLProgressElementType =
        abstract prototype: HTMLProgressElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLProgressElement

    and [<AllowNullLiteral>] HTMLQuoteElement =
        inherit HTMLElement
        abstract cite: string with get, set
        abstract dateTime: string with get, set

    and [<AllowNullLiteral>] HTMLQuoteElementType =
        abstract prototype: HTMLQuoteElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLQuoteElement

    and [<AllowNullLiteral>] HTMLScriptElement =
        inherit HTMLElement
        abstract async: bool with get, set
        /// Sets or retrieves the character set used to encode the object.
        abstract charset: string with get, set
        /// Sets or retrieves the status of the script.
        abstract defer: bool with get, set
        /// Sets or retrieves the event for which the script is written.
        abstract ``event``: string with get, set
        /// Sets or retrieves the object that is bound to the event script.
        abstract htmlFor: string with get, set
        /// The address or URL of the a media resource that is to be considered.
        abstract src: string with get, set
        abstract text: string with get, set
        /// Retrieves the type of control.
        abstract ``type``: string with get, set

    and [<AllowNullLiteral>] HTMLScriptElementType =
        abstract prototype: HTMLScriptElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLScriptElement

    and [<AllowNullLiteral>] HTMLSelectElement =
        inherit HTMLElement
        /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
        abstract autofocus: bool with get, set
        abstract disabled: bool with get, set
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the number of objects in a collection.
        abstract length: float with get, set
        /// Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
        abstract multiple: bool with get, set
        abstract name: string with get, set
        abstract options: HTMLCollection with get, set
        /// When present, marks an element that can't be submitted without a value.
        abstract required: bool with get, set
        /// Sets or retrieves the index of the selected option in a select object.
        abstract selectedIndex: float with get, set
        abstract size: float with get, set
        abstract ``type``: string with get, set
        /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
        abstract validationMessage: string with get, set
        /// Returns a  ValidityState object that represents the validity states of an element.
        abstract validity: ValidityState with get, set
        abstract value: string with get, set
        /// Returns whether an element will successfully validate based on forms validation rules and constraints.
        abstract willValidate: bool with get, set
        abstract selectedOptions: HTMLCollection with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> obj with get, set
        abstract add: element: HTMLElement * ?before: U2<HTMLElement, float> -> unit
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        /// <param name="name">Variant of type Number or String that specifies the object or collection to retrieve. If this parameter is a Number, it is the zero-based index of the object. If this parameter is a string, all objects with matching name or id properties are retrieved, and a collection is returned if more than one match is made.</param>
        /// <param name="index">Variant of type Number that specifies the zero-based index of the object to retrieve when a collection is returned.</param>
        abstract item: ?name: obj * ?index: obj -> obj
        abstract namedItem: name: string -> obj
        /// <param name="index">Number that specifies the zero-based index of the element to remove from the collection.</param>
        abstract remove: ?index: float -> unit
        /// <summary>Sets a custom error message that is displayed when a form is submitted.</summary>
        /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
        abstract setCustomValidity: error: string -> unit

    and [<AllowNullLiteral>] HTMLSelectElementType =
        abstract prototype: HTMLSelectElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSelectElement

    and [<AllowNullLiteral>] HTMLSourceElement =
        inherit HTMLElement
        /// Gets or sets the intended media type of the media source.
        abstract media: string with get, set
        abstract src: string with get, set
        abstract ``type``: string with get, set

    and [<AllowNullLiteral>] HTMLSourceElementType =
        abstract prototype: HTMLSourceElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSourceElement

    and [<AllowNullLiteral>] HTMLSpanElement =
        inherit HTMLElement


    and [<AllowNullLiteral>] HTMLSpanElementType =
        abstract prototype: HTMLSpanElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLSpanElement

    and [<AllowNullLiteral>] HTMLStyleElement =
        inherit HTMLElement
        // inherit LinkStyle
        /// Sets or retrieves the media type.
        abstract media: string with get, set
        abstract ``type``: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLStyleElementType =
        abstract prototype: HTMLStyleElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLStyleElement

    and [<AllowNullLiteral>] HTMLTableCaptionElement =
        inherit HTMLElement
        /// Sets or retrieves the alignment of the object relative to the display or table.
        abstract align: string with get, set
        /// Sets or retrieves whether the caption appears at the top or bottom of the table.
        abstract vAlign: string with get, set

    and [<AllowNullLiteral>] HTMLTableCaptionElementType =
        abstract prototype: HTMLTableCaptionElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableCaptionElement

    and [<AllowNullLiteral>] HTMLTableCellElement =
        inherit HTMLElement
        inherit HTMLTableAlignment
        /// Sets or retrieves abbreviated text for the object.
        abstract abbr: string with get, set
        /// Sets or retrieves a value that indicates the table alignment.
        abstract align: string with get, set
        /// Sets or retrieves a comma-delimited list of conceptual categories associated with the object.
        abstract axis: string with get, set
        abstract bgColor: obj with get, set
        /// Retrieves the position of the object in the cells collection of a row.
        abstract cellIndex: float with get, set
        /// Sets or retrieves the number columns in the table that the object should span.
        abstract colSpan: float with get, set
        /// Sets or retrieves a list of header cells that provide information for the object.
        abstract headers: string with get, set
        /// Sets or retrieves the height of the object.
        abstract height: obj with get, set
        abstract noWrap: bool with get, set
        /// Sets or retrieves how many rows in a table the cell should span.
        abstract rowSpan: float with get, set
        /// Sets or retrieves the group of cells in a table to which the object's information applies.
        abstract scope: string with get, set
        /// Gets or sets the width of the video element.
        abstract width: string with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLTableCellElementType =
        abstract prototype: HTMLTableCellElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableCellElement

    and [<AllowNullLiteral>] HTMLTableColElement =
        inherit HTMLElement
        inherit HTMLTableAlignment
        /// Sets or retrieves how the object is aligned with adjacent text.
        abstract align: string with get, set
        /// Sets or retrieves the number of columns in the group.
        abstract span: float with get, set
        abstract width: obj with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLTableColElementType =
        abstract prototype: HTMLTableColElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableColElement

    and [<AllowNullLiteral>] HTMLTableDataCellElement =
        inherit HTMLTableCellElement


    and [<AllowNullLiteral>] HTMLTableDataCellElementType =
        abstract prototype: HTMLTableDataCellElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableDataCellElement

    and [<AllowNullLiteral>] HTMLTableElement =
        inherit HTMLElement
        /// Sets or retrieves a value that indicates the table alignment.
        abstract align: string with get, set
        abstract bgColor: obj with get, set
        abstract border: string with get, set
        /// Sets or retrieves the border color of the object.
        abstract borderColor: obj with get, set
        /// Retrieves the caption object of a table.
        abstract caption: HTMLTableCaptionElement with get, set
        /// Sets or retrieves the amount of space between the border of the cell and the content of the cell.
        abstract cellPadding: string with get, set
        /// Sets or retrieves the amount of space between cells in a table.
        abstract cellSpacing: string with get, set
        /// Sets or retrieves the number of columns in the table.
        abstract cols: float with get, set
        abstract frame: string with get, set
        /// Sets or retrieves the height of the object.
        abstract height: obj with get, set
        /// Sets or retrieves the number of horizontal rows contained in the object.
        abstract rows: HTMLCollection with get, set
        /// Sets or retrieves which dividing lines (inner borders) are displayed.
        abstract rules: string with get, set
        /// Sets or retrieves a description and/or structure of the object.
        abstract summary: string with get, set
        /// Retrieves a collection of all tBody objects in the table. Objects in this collection are in source order.
        abstract tBodies: HTMLCollection with get, set
        /// Retrieves the tFoot object of the table.
        abstract tFoot: HTMLTableSectionElement with get, set
        /// Retrieves the tHead object of the table.
        abstract tHead: HTMLTableSectionElement with get, set
        abstract width: string with get, set
        /// Creates an empty caption element in the table.
        abstract createCaption: unit -> HTMLTableCaptionElement
        /// Creates an empty tBody element in the table.
        abstract createTBody: unit -> HTMLTableSectionElement
        /// Creates an empty tFoot element in the table.
        abstract createTFoot: unit -> HTMLTableSectionElement
        /// Returns the tHead element object if successful, or null otherwise.
        abstract createTHead: unit -> HTMLTableSectionElement
        /// Deletes the caption element and its contents from the table.
        abstract deleteCaption: unit -> unit
        /// <summary>Removes the specified row (tr) from the element and from the rows collection.</summary>
        /// <param name="index">Number that specifies the zero-based position in the rows collection of the row to remove.</param>
        abstract deleteRow: ?index: float -> unit
        /// Deletes the tFoot element and its contents from the table.
        abstract deleteTFoot: unit -> unit
        /// Deletes the tHead element and its contents from the table.
        abstract deleteTHead: unit -> unit
        /// <summary>Creates a new row (tr) in the table, and adds the row to the rows collection.</summary>
        /// <param name="index">Number that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
        abstract insertRow: ?index: float -> HTMLTableRowElement

    and [<AllowNullLiteral>] HTMLTableElementType =
        abstract prototype: HTMLTableElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableElement

    and [<AllowNullLiteral>] HTMLTableHeaderCellElement =
        inherit HTMLTableCellElement
        /// Sets or retrieves the group of cells in a table to which the object's information applies.
        abstract scope: string with get, set

    and [<AllowNullLiteral>] HTMLTableHeaderCellElementType =
        abstract prototype: HTMLTableHeaderCellElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableHeaderCellElement

    and [<AllowNullLiteral>] HTMLTableRowElement =
        inherit HTMLElement
        inherit HTMLTableAlignment
        abstract align: string with get, set
        abstract bgColor: obj with get, set
        /// Retrieves a collection of all cells in the table row.
        abstract cells: HTMLCollection with get, set
        /// Gets or sets the height of the video element.
        abstract height: obj with get, set
        /// Retrieves the position of the object in the rows collection for the table.
        abstract rowIndex: float with get, set
        /// Retrieves the position of the object in the collection.
        abstract sectionRowIndex: float with get, set
        /// <summary>Removes the specified cell from the table row, as well as from the cells collection.</summary>
        /// <param name="index">Number that specifies the zero-based position of the cell to remove from the table row. If no value is provided, the last cell in the cells collection is deleted.</param>
        abstract deleteCell: ?index: float -> unit
        /// <summary>Creates a new cell in the table row, and adds the cell to the cells collection.</summary>
        /// <param name="index">Number that specifies where to insert the cell in the tr. The default value is -1, which appends the new cell to the end of the cells collection.</param>
        abstract insertCell: ?index: float -> HTMLTableCellElement
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLTableRowElementType =
        abstract prototype: HTMLTableRowElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableRowElement

    and [<AllowNullLiteral>] HTMLTableSectionElement =
        inherit HTMLElement
        inherit HTMLTableAlignment
        abstract align: string with get, set
        /// Sets or retrieves the number of horizontal rows contained in the object.
        abstract rows: HTMLCollection with get, set
        /// <param name="index">Number that specifies the zero-based position in the rows collection of the row to remove.</param>
        abstract deleteRow: ?index: float -> unit
        /// <param name="index">Number that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
        abstract insertRow: ?index: float -> HTMLTableRowElement
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLTableSectionElementType =
        abstract prototype: HTMLTableSectionElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTableSectionElement

    and [<AllowNullLiteral>] HTMLTextAreaElement =
        inherit HTMLElement
        /// Provides a way to direct a user to a specific field when a document loads. This can provide both direction and convenience for a user, reducing the need to click or tab to a field when a page opens. This attribute is true when present on an element, and false when missing.
        abstract autofocus: bool with get, set
        /// Sets or retrieves the width of the object.
        abstract cols: float with get, set
        /// Sets or retrieves the initial contents of the object.
        abstract defaultValue: string with get, set
        abstract disabled: bool with get, set
        abstract form: HTMLFormElement with get, set
        /// Sets or retrieves the maximum number of characters that the user can enter in a text control.
        abstract maxLength: float with get, set
        abstract name: string with get, set
        /// Gets or sets a text string that is displayed in an input field as a hint or prompt to users as the format or type of information they need to enter.The text appears in an input field until the user puts focus on the field.
        abstract placeholder: string with get, set
        abstract readOnly: bool with get, set
        /// When present, marks an element that can't be submitted without a value.
        abstract required: bool with get, set
        /// Sets or retrieves the number of horizontal rows contained in the object.
        abstract rows: float with get, set
        /// Gets or sets the end position or offset of a text selection.
        abstract selectionEnd: float with get, set
        /// Gets or sets the starting position or offset of a text selection.
        abstract selectionStart: float with get, set
        abstract status: obj with get, set
        abstract ``type``: string with get, set
        /// Returns the error message that would be displayed if the user submits the form, or an empty string if no error message. It also triggers the standard error message, such as "this is a required field". The result is that the user sees validation messages without actually submitting.
        abstract validationMessage: string with get, set
        /// Returns a  ValidityState object that represents the validity states of an element.
        abstract validity: ValidityState with get, set
        abstract value: string with get, set
        /// Returns whether an element will successfully validate based on forms validation rules and constraints.
        abstract willValidate: bool with get, set
        /// Sets or retrieves how to handle wordwrapping in the object.
        abstract wrap: string with get, set
        /// Returns whether a form will validate when it is submitted, without having to submit it.
        abstract checkValidity: unit -> bool
        abstract createTextRange: unit -> TextRange
        abstract select: unit -> unit
        /// <param name="error">Sets a custom error message that is displayed when a form is submitted.</param>
        abstract setCustomValidity: error: string -> unit
        /// <param name="start">The offset into the text field for the start of the selection.</param>
        /// <param name="end">The offset into the text field for the end of the selection.</param>
        abstract setSelectionRange: start: float * ``end``: float -> unit

    and [<AllowNullLiteral>] HTMLTextAreaElementType =
        abstract prototype: HTMLTextAreaElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTextAreaElement

    and [<AllowNullLiteral>] HTMLTitleElement =
        inherit HTMLElement
        abstract text: string with get, set

    and [<AllowNullLiteral>] HTMLTitleElementType =
        abstract prototype: HTMLTitleElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTitleElement

    and [<AllowNullLiteral>] HTMLTrackElement =
        inherit HTMLElement
        abstract ``default``: bool with get, set
        abstract kind: string with get, set
        abstract label: string with get, set
        abstract readyState: float with get, set
        abstract src: string with get, set
        abstract srclang: string with get, set
        abstract track: TextTrack with get, set
        abstract ERROR: float with get, set
        abstract LOADED: float with get, set
        abstract LOADING: float with get, set
        abstract NONE: float with get, set

    and [<AllowNullLiteral>] HTMLTrackElementType =
        abstract prototype: HTMLTrackElement with get, set
        abstract ERROR: float with get, set
        abstract LOADED: float with get, set
        abstract LOADING: float with get, set
        abstract NONE: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTrackElement

    and [<AllowNullLiteral>] HTMLUListElement =
        inherit HTMLElement
        abstract compact: bool with get, set
        abstract ``type``: string with get, set

    and [<AllowNullLiteral>] HTMLUListElementType =
        abstract prototype: HTMLUListElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLUListElement

    and [<AllowNullLiteral>] HTMLUnknownElement =
        inherit HTMLElement


    and [<AllowNullLiteral>] HTMLUnknownElementType =
        abstract prototype: HTMLUnknownElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLUnknownElement

    and [<AllowNullLiteral>] HTMLVideoElement =
        inherit HTMLMediaElement
        abstract height: float with get, set
        /// Gets or sets a URL of an image to display, for example, like a movie poster. This can be a still frame from the video, or another image if no video data is available.
        abstract poster: string with get, set
        /// Gets the intrinsic height of a video in CSS pixels, or zero if the dimensions are not known.
        abstract videoHeight: float with get, set
        /// Gets the intrinsic width of a video in CSS pixels, or zero if the dimensions are not known.
        abstract videoWidth: float with get, set
        abstract width: float with get, set
        abstract getVideoPlaybackQuality: unit -> VideoPlaybackQuality
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLVideoElementType =
        abstract prototype: HTMLVideoElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLVideoElement

    and [<AllowNullLiteral>] HashChangeEvent =
        inherit Event
        abstract newURL: string with get, set
        abstract oldURL: string with get, set

    and [<AllowNullLiteral>] HashChangeEventType =
        abstract prototype: HashChangeEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: HashChangeEventInit -> HashChangeEvent

    and [<AllowNullLiteral>] History =
        abstract length: float with get, set
        abstract state: obj with get, set
        abstract back: ?distance: obj -> unit
        abstract forward: ?distance: obj -> unit
        abstract go: ?delta: obj -> unit
        abstract pushState: statedata: obj * ?title: string * ?url: string -> unit
        abstract replaceState: statedata: obj * ?title: string * ?url: string -> unit

    and [<AllowNullLiteral>] HistoryType =
        abstract prototype: History with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> History

    // and [<AllowNullLiteral>] IDBCursor =
    //     abstract direction: string with get, set
    //     abstract key: obj with get, set
    //     abstract primaryKey: obj with get, set
    //     abstract source: U2<IDBObjectStore, IDBIndex> with get, set
    //     abstract NEXT: string with get, set
    //     abstract NEXT_NO_DUPLICATE: string with get, set
    //     abstract PREV: string with get, set
    //     abstract PREV_NO_DUPLICATE: string with get, set
    //     abstract advance: count: float -> unit
    //     abstract ``continue``: ?key: obj -> unit
    //     abstract delete: unit -> IDBRequest
    //     abstract update: value: obj -> IDBRequest

    // and [<AllowNullLiteral>] IDBCursorType =
    //     abstract prototype: IDBCursor with get, set
    //     abstract NEXT: string with get, set
    //     abstract NEXT_NO_DUPLICATE: string with get, set
    //     abstract PREV: string with get, set
    //     abstract PREV_NO_DUPLICATE: string with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBCursor

    // and [<AllowNullLiteral>] IDBCursorWithValue =
    //     inherit IDBCursor
    //     abstract value: obj with get, set

    // and [<AllowNullLiteral>] IDBCursorWithValueType =
    //     abstract prototype: IDBCursorWithValue with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBCursorWithValue

    // and [<AllowNullLiteral>] IDBDatabase =
    //     inherit EventTarget
    //     abstract name: string with get, set
    //     abstract objectStoreNames: DOMStringList with get, set
    //     abstract onabort: (Event -> 'Out) with get, set
    //     abstract onerror: (Event -> 'Out) with get, set
    //     abstract version: float with get, set
    //     abstract close: unit -> unit
    //     abstract createObjectStore: name: string * ?optionalParameters: IDBObjectStoreParameters -> IDBObjectStore
    //     abstract deleteObjectStore: name: string -> unit
    //     abstract transaction: storeNames: U2<string, ResizeArray<string>> * ?mode: string -> IDBTransaction
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] IDBDatabaseType =
    //     abstract prototype: IDBDatabase with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBDatabase

    // and [<AllowNullLiteral>] IDBFactory =
    //     abstract cmp: first: obj * second: obj -> float
    //     abstract deleteDatabase: name: string -> IDBOpenDBRequest
    //     abstract ``open``: name: string * ?version: float -> IDBOpenDBRequest

    // and [<AllowNullLiteral>] IDBFactoryType =
    //     abstract prototype: IDBFactory with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBFactory

    // and [<AllowNullLiteral>] IDBIndex =
    //     abstract keyPath: U2<string, ResizeArray<string>> with get, set
    //     abstract name: string with get, set
    //     abstract objectStore: IDBObjectStore with get, set
    //     abstract unique: bool with get, set
    //     abstract multiEntry: bool with get, set
    //     abstract count: ?key: obj -> IDBRequest
    //     abstract get: key: obj -> IDBRequest
    //     abstract getKey: key: obj -> IDBRequest
    //     abstract openCursor: ?range: IDBKeyRange * ?direction: string -> IDBRequest
    //     abstract openKeyCursor: ?range: IDBKeyRange * ?direction: string -> IDBRequest

    // and [<AllowNullLiteral>] IDBIndexType =
    //     abstract prototype: IDBIndex with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBIndex

    // and [<AllowNullLiteral>] IDBKeyRange =
    //     abstract lower: obj with get, set
    //     abstract lowerOpen: bool with get, set
    //     abstract upper: obj with get, set
    //     abstract upperOpen: bool with get, set

    // and [<AllowNullLiteral>] IDBKeyRangeType =
    //     abstract prototype: IDBKeyRange with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBKeyRange
    //     abstract bound: lower: obj * upper: obj * ?lowerOpen: bool * ?upperOpen: bool -> IDBKeyRange
    //     abstract lowerBound: bound: obj * ?``open``: bool -> IDBKeyRange
    //     abstract only: value: obj -> IDBKeyRange
    //     abstract upperBound: bound: obj * ?``open``: bool -> IDBKeyRange

    // and [<AllowNullLiteral>] IDBObjectStore =
    //     abstract indexNames: DOMStringList with get, set
    //     abstract keyPath: U2<string, ResizeArray<string>> with get, set
    //     abstract name: string with get, set
    //     abstract transaction: IDBTransaction with get, set
    //     abstract autoIncrement: bool with get, set
    //     abstract add: value: obj * ?key: obj -> IDBRequest
    //     abstract clear: unit -> IDBRequest
    //     abstract count: ?key: obj -> IDBRequest
    //     abstract createIndex: name: string * keyPath: U2<string, ResizeArray<string>> * ?optionalParameters: IDBIndexParameters -> IDBIndex
    //     abstract delete: key: obj -> IDBRequest
    //     abstract deleteIndex: indexName: string -> unit
    //     abstract get: key: obj -> IDBRequest
    //     abstract index: name: string -> IDBIndex
    //     abstract openCursor: ?range: obj * ?direction: string -> IDBRequest
    //     abstract put: value: obj * ?key: obj -> IDBRequest

    // and [<AllowNullLiteral>] IDBObjectStoreType =
    //     abstract prototype: IDBObjectStore with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBObjectStore

    // and [<AllowNullLiteral>] IDBOpenDBRequest =
    //     inherit IDBRequest
    //     abstract onblocked: (Event -> 'Out) with get, set
    //     abstract onupgradeneeded: (IDBVersionChangeEvent -> 'Out) with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] IDBOpenDBRequestType =
    //     abstract prototype: IDBOpenDBRequest with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBOpenDBRequest

    // and [<AllowNullLiteral>] IDBRequest =
    //     inherit EventTarget
    //     abstract error: DOMError with get, set
    //     abstract onerror: (Event -> 'Out) with get, set
    //     abstract onsuccess: (Event -> 'Out) with get, set
    //     abstract readyState: string with get, set
    //     abstract result: obj with get, set
    //     abstract source: U3<IDBObjectStore, IDBIndex, IDBCursor> with get, set
    //     abstract transaction: IDBTransaction with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] IDBRequestType =
    //     abstract prototype: IDBRequest with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBRequest

    // and [<AllowNullLiteral>] IDBTransaction =
    //     inherit EventTarget
    //     abstract db: IDBDatabase with get, set
    //     abstract error: DOMError with get, set
    //     abstract mode: string with get, set
    //     abstract onabort: (Event -> 'Out) with get, set
    //     abstract oncomplete: (Event -> 'Out) with get, set
    //     abstract onerror: (Event -> 'Out) with get, set
    //     abstract READ_ONLY: string with get, set
    //     abstract READ_WRITE: string with get, set
    //     abstract VERSION_CHANGE: string with get, set
    //     abstract abort: unit -> unit
    //     abstract objectStore: name: string -> IDBObjectStore
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] IDBTransactionType =
    //     abstract prototype: IDBTransaction with get, set
    //     abstract READ_ONLY: string with get, set
    //     abstract READ_WRITE: string with get, set
    //     abstract VERSION_CHANGE: string with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBTransaction

    // and [<AllowNullLiteral>] IDBVersionChangeEvent =
    //     inherit Event
    //     abstract newVersion: float with get, set
    //     abstract oldVersion: float with get, set

    // and [<AllowNullLiteral>] IDBVersionChangeEventType =
    //     abstract prototype: IDBVersionChangeEvent with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> IDBVersionChangeEvent

    // and [<AllowNullLiteral>] IDBObjectStoreParameters =
    //     abstract keyPath: U2<string, ResizeArray<string>> option with get, set
    //     abstract autoIncrement: bool option with get, set

    // and [<AllowNullLiteral>] IDBIndexParameters =
    //     abstract unique: bool option with get, set
    //     abstract multiEntry: bool option with get, set

    // and [<AllowNullLiteral>] IDBEnvironment =
    //     abstract indexedDB: IDBFactory with get, set

    and [<AllowNullLiteral>] IIRFilterNode =
        inherit AudioNode
        abstract getFrequencyResponse: frequencyHz: Float32Array * magResponse: Float32Array * phaseResponse: Float32Array -> unit

    and [<AllowNullLiteral>] IIRFilterNodeType =
        abstract prototype: IIRFilterNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> IIRFilterNode

    and [<AllowNullLiteral>] ImageData =
        abstract data: Uint8ClampedArray with get, set
        abstract height: float with get, set
        abstract width: float with get, set

    and [<AllowNullLiteral>] ImageDataType =
        abstract prototype: ImageData with get, set
        [<Emit("new $0($1...)")>] abstract Create: width: float * height: float -> ImageData
        [<Emit("new $0($1...)")>] abstract Create: array: Uint8ClampedArray * width: float * height: float -> ImageData

    and [<AllowNullLiteral>] InstallEvent =
        inherit ExtendableEvent
        abstract activeWorker: ServiceWorker with get, set

    and [<AllowNullLiteral>] KeyboardEvent =
        inherit UIEvent
        abstract altKey: bool with get, set
        abstract char: string with get, set
        abstract charCode: float with get, set
        abstract ctrlKey: bool with get, set
        abstract key: string with get, set
        abstract keyCode: float with get, set
        abstract locale: string with get, set
        abstract location: float with get, set
        abstract metaKey: bool with get, set
        abstract repeat: bool with get, set
        abstract shiftKey: bool with get, set
        abstract which: float with get, set
        abstract DOM_KEY_LOCATION_JOYSTICK: float with get, set
        abstract DOM_KEY_LOCATION_LEFT: float with get, set
        abstract DOM_KEY_LOCATION_MOBILE: float with get, set
        abstract DOM_KEY_LOCATION_NUMPAD: float with get, set
        abstract DOM_KEY_LOCATION_RIGHT: float with get, set
        abstract DOM_KEY_LOCATION_STANDARD: float with get, set
        abstract getModifierState: keyArg: string -> bool
        abstract initKeyboardEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * keyArg: string * locationArg: float * modifiersListArg: string * repeat: bool * locale: string -> unit

    and [<AllowNullLiteral>] KeyboardEventType =
        abstract prototype: KeyboardEvent with get, set
        abstract DOM_KEY_LOCATION_JOYSTICK: float with get, set
        abstract DOM_KEY_LOCATION_LEFT: float with get, set
        abstract DOM_KEY_LOCATION_MOBILE: float with get, set
        abstract DOM_KEY_LOCATION_NUMPAD: float with get, set
        abstract DOM_KEY_LOCATION_RIGHT: float with get, set
        abstract DOM_KEY_LOCATION_STANDARD: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: KeyboardEventInit -> KeyboardEvent

    and [<AllowNullLiteral>] Location =
        abstract hash: string with get, set
        abstract host: string with get, set
        abstract hostname: string with get, set
        abstract href: string with get, set
        abstract origin: string with get, set
        abstract password: string with get, set
        abstract pathname: string with get, set
        abstract port: string with get, set
        abstract protocol: string with get, set
        abstract search: string with get, set
        abstract username: string with get, set
        abstract assign: url: string -> unit
        abstract reload: ?forcedReload: bool -> unit
        abstract replace: url: string -> unit
        abstract toString: unit -> string

    and [<AllowNullLiteral>] LocationType =
        abstract prototype: Location with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Location

    and [<AllowNullLiteral>] LongRunningScriptDetectedEvent =
        inherit Event
        abstract executionTime: float with get, set
        abstract stopPageScriptExecution: bool with get, set

    and [<AllowNullLiteral>] LongRunningScriptDetectedEventType =
        abstract prototype: LongRunningScriptDetectedEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> LongRunningScriptDetectedEvent

    and [<AllowNullLiteral>] MediaElementAudioSourceNode =
        inherit AudioNode

    and [<AllowNullLiteral>] MediaElementAudioSourceNodeType =
        abstract prototype: MediaElementAudioSourceNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaElementAudioSourceNode

    and [<AllowNullLiteral>] MediaError =
        abstract code: float with get, set
        abstract MEDIA_ERR_ABORTED: float with get, set
        abstract MEDIA_ERR_DECODE: float with get, set
        abstract MEDIA_ERR_NETWORK: float with get, set
        abstract MEDIA_ERR_SRC_NOT_SUPPORTED: float with get, set

    and [<AllowNullLiteral>] MediaErrorType =
        abstract prototype: MediaError with get, set
        abstract MEDIA_ERR_ABORTED: float with get, set
        abstract MEDIA_ERR_DECODE: float with get, set
        abstract MEDIA_ERR_NETWORK: float with get, set
        abstract MEDIA_ERR_SRC_NOT_SUPPORTED: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaError

    and [<AllowNullLiteral>] MediaList =
        abstract length: float with get, set
        abstract mediaText: string with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
        abstract appendMedium: newMedium: string -> unit
        abstract deleteMedium: oldMedium: string -> unit
        abstract item: index: float -> string
        abstract toString: unit -> string

    and [<AllowNullLiteral>] MediaListType =
        abstract prototype: MediaList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaList

    and [<AllowNullLiteral>] MediaQueryList =
        abstract matches: bool with get, set
        abstract media: string with get, set
        abstract addListener: listener: MediaQueryListListener -> unit
        abstract removeListener: listener: MediaQueryListListener -> unit

    and [<AllowNullLiteral>] MediaQueryListType =
        abstract prototype: MediaQueryList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaQueryList

    and [<AllowNullLiteral>] MediaSource =
        inherit EventTarget
        abstract activeSourceBuffers: SourceBufferList with get, set
        abstract duration: float with get, set
        abstract readyState: string with get, set
        abstract sourceBuffers: SourceBufferList with get, set
        abstract addSourceBuffer: ``type``: string -> SourceBuffer
        abstract endOfStream: ?error: float -> unit
        abstract removeSourceBuffer: sourceBuffer: SourceBuffer -> unit

    and [<AllowNullLiteral>] MediaSourceType =
        abstract prototype: MediaSource with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaSource
        abstract isTypeSupported: ``type``: string -> bool

    and [<AllowNullLiteral>] MediaStream =
        interface end

    and [<AllowNullLiteral>] MediaStreamType =
        abstract prototype: MediaStream with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaStream

    and [<AllowNullLiteral>] MediaStreamAudioDestinationNode =
        inherit AudioNode
        abstract stream: MediaStream with get

    and [<AllowNullLiteral>] MediaStreamAudioDestinationNodeType =
        abstract prototype: MediaStreamAudioDestinationNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaStreamAudioDestinationNode

    and [<AllowNullLiteral>] MediaStreamAudioSourceNode =
        inherit AudioNode

    and [<AllowNullLiteral>] MediaStreamAudioSourceNodeType =
        abstract prototype: MediaStreamAudioSourceNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MediaStreamAudioSourceNode

     and [<AllowNullLiteral>] MessageChannel =
        abstract port1: MessagePort with get, set
        abstract port2: MessagePort with get, set

    and [<AllowNullLiteral>] MessageChannelType =
        abstract prototype: MessageChannel with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MessageChannel

    and [<AllowNullLiteral>] MessageEvent =
        inherit Event
        abstract data: obj with get, set
        abstract origin: string with get, set
        abstract ports: obj with get, set
        abstract source: Window with get, set
        abstract initMessageEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * dataArg: obj * originArg: string * lastEventIdArg: string * sourceArg: Window -> unit

    and [<AllowNullLiteral>] MessageEventType =
        abstract prototype: MessageEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: MessageEventInit -> MessageEvent

    and [<AllowNullLiteral>] MessagePort =
        inherit EventTarget
        abstract onmessage: (MessageEvent -> 'Out) with get, set
        abstract close: unit -> unit
        abstract postMessage: ?message: obj * ?ports: obj -> unit
        abstract start: unit -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] MessagePortType =
        abstract prototype: MessagePort with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MessagePort

    and [<AllowNullLiteral>] MimeType =
        abstract description: string with get, set
        abstract enabledPlugin: Plugin with get, set
        abstract suffixes: string with get, set
        abstract ``type``: string with get, set

    and [<AllowNullLiteral>] MimeTypeType =
        abstract prototype: MimeType with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MimeType

    and [<AllowNullLiteral>] MimeTypeArray =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Plugin with get, set
        abstract item: index: float -> Plugin
        abstract namedItem: ``type``: string -> Plugin

    and [<AllowNullLiteral>] MimeTypeArrayType =
        abstract prototype: MimeTypeArray with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MimeTypeArray

    and [<AllowNullLiteral>] MouseEvent =
        inherit UIEvent
        abstract altKey: bool with get, set
        abstract button: float with get, set
        abstract buttons: float with get, set
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract ctrlKey: bool with get, set
        abstract fromElement: Element with get, set
        abstract layerX: float with get, set
        abstract layerY: float with get, set
        abstract metaKey: bool with get, set
        abstract movementX: float with get, set
        abstract movementY: float with get, set
        abstract offsetX: float with get, set
        abstract offsetY: float with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set
        abstract relatedTarget: EventTarget with get, set
        abstract screenX: float with get, set
        abstract screenY: float with get, set
        abstract shiftKey: bool with get, set
        abstract toElement: Element with get, set
        abstract which: float with get, set
        abstract x: float with get, set
        abstract y: float with get, set
        abstract getModifierState: keyArg: string -> bool
        abstract initMouseEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float * screenXArg: float * screenYArg: float * clientXArg: float * clientYArg: float * ctrlKeyArg: bool * altKeyArg: bool * shiftKeyArg: bool * metaKeyArg: bool * buttonArg: float * relatedTargetArg: EventTarget -> unit

    and [<AllowNullLiteral>] MouseEventType =
        abstract prototype: MouseEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: MouseEventInit -> MouseEvent

    and [<AllowNullLiteral>] MouseWheelEvent =
        inherit MouseEvent
        abstract wheelDelta: float with get, set
        abstract wheelDeltaX: float with get, set
        abstract wheelDeltaY: float with get, set
        abstract initMouseWheelEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float * screenXArg: float * screenYArg: float * clientXArg: float * clientYArg: float * buttonArg: float * relatedTargetArg: EventTarget * modifiersListArg: string * wheelDeltaArg: float -> unit

    and [<AllowNullLiteral>] MouseWheelEventType =
        abstract prototype: MouseWheelEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> MouseWheelEvent

    and [<AllowNullLiteral>] NamedNodeMap =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Attr with get, set
        abstract getNamedItem: name: string -> Attr
        abstract getNamedItemNS: namespaceURI: string * localName: string -> Attr
        abstract item: index: float -> Attr
        abstract removeNamedItem: name: string -> Attr
        abstract removeNamedItemNS: namespaceURI: string * localName: string -> Attr
        abstract setNamedItem: arg: Attr -> Attr
        abstract setNamedItemNS: arg: Attr -> Attr

    and [<AllowNullLiteral>] NamedNodeMapType =
        abstract prototype: NamedNodeMap with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> NamedNodeMap

    and [<AllowNullLiteral>] NavigationCompletedEvent =
        inherit NavigationEvent
        abstract isSuccess: bool with get, set
        abstract webErrorStatus: float with get, set

    and [<AllowNullLiteral>] NavigationCompletedEventType =
        abstract prototype: NavigationCompletedEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> NavigationCompletedEvent

    and [<AllowNullLiteral>] NavigationEvent =
        inherit Event
        abstract uri: string with get, set

    and [<AllowNullLiteral>] NavigationEventType =
        abstract prototype: NavigationEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> NavigationEvent

    and [<AllowNullLiteral>] NavigationEventWithReferrer =
        inherit NavigationEvent
        abstract referer: string with get, set

    and [<AllowNullLiteral>] NavigationEventWithReferrerType =
        abstract prototype: NavigationEventWithReferrer with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> NavigationEventWithReferrer

    and [<AllowNullLiteral>] Navigator =
        inherit NavigatorID
        inherit NavigatorOnLine
        inherit NavigatorContentUtils
        inherit NavigatorStorageUtils
        inherit NavigatorGeolocation
        abstract appCodeName: string with get, set
        abstract appMinorVersion: string with get, set
        abstract browserLanguage: string with get, set
        abstract connectionSpeed: float with get, set
        abstract cookieEnabled: bool with get, set
        abstract cpuClass: string with get, set
        abstract language: string with get, set
        abstract maxTouchPoints: float with get, set
        abstract pointerEnabled: bool with get, set
        abstract systemLanguage: string with get, set
        abstract userLanguage: string with get, set
        abstract webdriver: bool with get, set
        abstract getGamepads: unit -> ResizeArray<Gamepad>
        abstract javaEnabled: unit -> bool
        abstract vibrate: pattern: U2<float, ResizeArray<float>> -> bool
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit
        abstract serviceWorker: ServiceWorkerContainer with get, set


    and [<AllowNullLiteral>] NavigatorType =
        abstract prototype: Navigator with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Navigator

    and [<AllowNullLiteral>] Node =
        inherit EventTarget
        abstract attributes: NamedNodeMap with get, set
        abstract baseURI: string with get, set
        abstract childNodes: NodeList with get, set
        abstract firstChild: Node with get, set
        abstract lastChild: Node with get, set
        abstract localName: string with get, set
        abstract namespaceURI: string with get, set
        abstract nextSibling: Node with get, set
        abstract nodeName: string with get, set
        abstract nodeType: float with get, set
        abstract nodeValue: string with get, set
        abstract ownerDocument: Document with get, set
        abstract parentElement: HTMLElement with get, set
        abstract parentNode: Node with get, set
        abstract prefix: string with get, set
        abstract previousSibling: Node with get, set
        abstract textContent: string with get, set
        abstract ATTRIBUTE_NODE: float with get, set
        abstract CDATA_SECTION_NODE: float with get, set
        abstract COMMENT_NODE: float with get, set
        abstract DOCUMENT_FRAGMENT_NODE: float with get, set
        abstract DOCUMENT_NODE: float with get, set
        abstract DOCUMENT_POSITION_CONTAINED_BY: float with get, set
        abstract DOCUMENT_POSITION_CONTAINS: float with get, set
        abstract DOCUMENT_POSITION_DISCONNECTED: float with get, set
        abstract DOCUMENT_POSITION_FOLLOWING: float with get, set
        abstract DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC: float with get, set
        abstract DOCUMENT_POSITION_PRECEDING: float with get, set
        abstract DOCUMENT_TYPE_NODE: float with get, set
        abstract ELEMENT_NODE: float with get, set
        abstract ENTITY_NODE: float with get, set
        abstract ENTITY_REFERENCE_NODE: float with get, set
        abstract NOTATION_NODE: float with get, set
        abstract PROCESSING_INSTRUCTION_NODE: float with get, set
        abstract TEXT_NODE: float with get, set
        abstract appendChild: newChild: Node -> Node
        abstract cloneNode: ?deep: bool -> Node
        abstract compareDocumentPosition: other: Node -> float
        abstract hasAttributes: unit -> bool
        abstract hasChildNodes: unit -> bool
        abstract insertBefore: newChild: Node * ?refChild: Node -> Node
        abstract isDefaultNamespace: namespaceURI: string -> bool
        abstract isEqualNode: arg: Node -> bool
        abstract isSameNode: other: Node -> bool
        abstract lookupNamespaceURI: prefix: string -> string
        abstract lookupPrefix: namespaceURI: string -> string
        abstract normalize: unit -> unit
        abstract removeChild: oldChild: Node -> Node
        abstract replaceChild: newChild: Node * oldChild: Node -> Node
        abstract contains: node: Node -> bool

    and [<AllowNullLiteral>] NodeType =
        abstract prototype: Node with get, set
        abstract ATTRIBUTE_NODE: float with get, set
        abstract CDATA_SECTION_NODE: float with get, set
        abstract COMMENT_NODE: float with get, set
        abstract DOCUMENT_FRAGMENT_NODE: float with get, set
        abstract DOCUMENT_NODE: float with get, set
        abstract DOCUMENT_POSITION_CONTAINED_BY: float with get, set
        abstract DOCUMENT_POSITION_CONTAINS: float with get, set
        abstract DOCUMENT_POSITION_DISCONNECTED: float with get, set
        abstract DOCUMENT_POSITION_FOLLOWING: float with get, set
        abstract DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC: float with get, set
        abstract DOCUMENT_POSITION_PRECEDING: float with get, set
        abstract DOCUMENT_TYPE_NODE: float with get, set
        abstract ELEMENT_NODE: float with get, set
        abstract ENTITY_NODE: float with get, set
        abstract ENTITY_REFERENCE_NODE: float with get, set
        abstract NOTATION_NODE: float with get, set
        abstract PROCESSING_INSTRUCTION_NODE: float with get, set
        abstract TEXT_NODE: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Node

    and [<AllowNullLiteral>] NodeFilter =
        abstract acceptNode: n: Node -> float

    and [<AllowNullLiteral>] NodeFilterType =
        abstract FILTER_ACCEPT: float with get, set
        abstract FILTER_REJECT: float with get, set
        abstract FILTER_SKIP: float with get, set
        abstract SHOW_ALL: float with get, set
        abstract SHOW_ATTRIBUTE: float with get, set
        abstract SHOW_CDATA_SECTION: float with get, set
        abstract SHOW_COMMENT: float with get, set
        abstract SHOW_DOCUMENT: float with get, set
        abstract SHOW_DOCUMENT_FRAGMENT: float with get, set
        abstract SHOW_DOCUMENT_TYPE: float with get, set
        abstract SHOW_ELEMENT: float with get, set
        abstract SHOW_ENTITY: float with get, set
        abstract SHOW_ENTITY_REFERENCE: float with get, set
        abstract SHOW_NOTATION: float with get, set
        abstract SHOW_PROCESSING_INSTRUCTION: float with get, set
        abstract SHOW_TEXT: float with get, set

    and [<AllowNullLiteral>] NodeIterator =
        abstract expandEntityReferences: bool with get, set
        abstract filter: NodeFilter with get, set
        abstract root: Node with get, set
        abstract whatToShow: float with get, set
        abstract detach: unit -> unit
        abstract nextNode: unit -> Node
        abstract previousNode: unit -> Node

    and [<AllowNullLiteral>] NodeIteratorType =
        abstract prototype: NodeIterator with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> NodeIterator

    and [<AllowNullLiteral>] NodeList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Node with get, set
        abstract item: index: float -> Node

    and [<AllowNullLiteral>] NodeListType =
        abstract prototype: NodeList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> NodeList

    and [<AllowNullLiteral>] Notification =
        abstract body: string with get, set
        abstract data: obj option with get, set
        abstract icon: string with get, set
        abstract lang: string with get, set
        abstract requireInteraction: bool with get, set
        abstract silent: bool with get, set
        abstract tag: string with get, set
        abstract timestamp: float with get, set
        abstract title: string with get, set
        abstract close: unit -> unit
        abstract requestPermission: unit -> Promise<string>

    and [<AllowNullLiteral>] NotificationEvent =
        abstract action: string with get, set
        abstract notification: Notification with get, set

    and [<AllowNullLiteral>] OES_element_index_uint =
        interface end

    and [<AllowNullLiteral>] OES_element_index_uintType =
        abstract prototype: OES_element_index_uint with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> OES_element_index_uint

    and [<AllowNullLiteral>] OES_standard_derivatives =
        abstract FRAGMENT_SHADER_DERIVATIVE_HINT_OES: float with get, set

    and [<AllowNullLiteral>] OES_standard_derivativesType =
        abstract prototype: OES_standard_derivatives with get, set
        abstract FRAGMENT_SHADER_DERIVATIVE_HINT_OES: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> OES_standard_derivatives

    and [<AllowNullLiteral>] OES_texture_float =
        interface end

    and [<AllowNullLiteral>] OES_texture_floatType =
        abstract prototype: OES_texture_float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> OES_texture_float

    and [<AllowNullLiteral>] OES_texture_float_linear =
        interface end

    and [<AllowNullLiteral>] OES_texture_float_linearType =
        abstract prototype: OES_texture_float_linear with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> OES_texture_float_linear

    and [<AllowNullLiteral>] OfflineAudioCompletionEvent =
        inherit Event
        abstract renderedBuffer: AudioBuffer with get

    and [<AllowNullLiteral>] OfflineAudioCompletionEventType =
        abstract prototype: OfflineAudioCompletionEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> OfflineAudioCompletionEvent

    and [<AllowNullLiteral>] OfflineAudioContext =
        inherit AudioContext
        abstract oncomplete: (OfflineAudioCompletionEvent -> 'Out) with get, set
        abstract startRendering: unit -> unit
        abstract resume: unit -> Promise<unit>
        abstract suspend: suspendTime: float -> Promise<unit>
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] OfflineAudioContextType =
        abstract prototype: OfflineAudioContext with get, set
        [<Emit("new $0($1...)")>] abstract Create: numberOfChannels: float * length: float * sampleRate: float -> OfflineAudioContext

    and [<AllowNullLiteral>] OscillatorNode =
        inherit AudioNode
        abstract detune: AudioParam with get
        abstract frequency: AudioParam with get
        abstract onended: (Event -> 'Out) with get, set
        abstract ``type``: OscillatorType with get, set
        abstract setPeriodicWave: periodicWave: PeriodicWave -> unit
        abstract start: ?``when``: float -> unit
        abstract stop: ?``when``: float -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] OscillatorNodeType =
        abstract prototype: OscillatorNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> OscillatorNode

    and [<StringEnum>] OscillatorType =
        | Sine
        | Square
        | Sawtooth
        | Triangle
        | Custom

    and [<StringEnum; RequireQualifiedAccess>] OverSampleType =
        | None
        | [<CompiledName("2x")>] X2
        | [<CompiledName("4x")>] X4

     and [<AllowNullLiteral>] PageTransitionEvent =
        inherit Event
        abstract persisted: bool with get, set

    and [<AllowNullLiteral>] PageTransitionEventType =
        abstract prototype: PageTransitionEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PageTransitionEvent

    and [<AllowNullLiteral>] PannerNode =
        inherit AudioNode
        abstract coneInnerAngle: float with get, set
        abstract coneOuterAngle: float with get, set
        abstract coneOuterGain: float with get, set
        abstract distanceModel: DistanceModelType with get, set
        abstract maxDistance: float with get, set
        abstract panningModel: PanningModelType with get, set
        abstract refDistance: float with get, set
        abstract rolloffFactor: float with get, set
        abstract setOrientation: x: float * y: float * z: float -> unit
        abstract setPosition: x: float * y: float * z: float -> unit
        abstract setVelocity: x: float * y: float * z: float -> unit

    and [<AllowNullLiteral>] PannerNodeType =
        abstract prototype: PannerNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PannerNode

    and [<StringEnum>] PanningModelType =
        | [<CompiledName("equalpower")>] EqualPower
        | [<CompiledName("HRTF")>] HRTF

    and [<AllowNullLiteral>] PerfWidgetExternal =
        abstract activeNetworkRequestCount: float with get, set
        abstract averageFrameTime: float with get, set
        abstract averagePaintTime: float with get, set
        abstract extraInformationEnabled: bool with get, set
        abstract independentRenderingEnabled: bool with get, set
        abstract irDisablingContentString: string with get, set
        abstract irStatusAvailable: bool with get, set
        abstract maxCpuSpeed: float with get, set
        abstract paintRequestsPerSecond: float with get, set
        abstract performanceCounter: float with get, set
        abstract performanceCounterFrequency: float with get, set
        abstract addEventListener: eventType: string * callback: Function -> unit
        abstract getMemoryUsage: unit -> float
        abstract getProcessCpuUsage: unit -> float
        abstract getRecentCpuUsage: last: float -> obj
        abstract getRecentFrames: last: float -> obj
        abstract getRecentMemoryUsage: last: float -> obj
        abstract getRecentPaintRequests: last: float -> obj
        abstract removeEventListener: eventType: string * callback: Function -> unit
        abstract repositionWindow: x: float * y: float -> unit
        abstract resizeWindow: width: float * height: float -> unit

    and [<AllowNullLiteral>] PerfWidgetExternalType =
        abstract prototype: PerfWidgetExternal with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerfWidgetExternal

    and [<AllowNullLiteral>] Performance =
        abstract navigation: PerformanceNavigation with get, set
        abstract timing: PerformanceTiming with get, set
        abstract clearMarks: ?markName: string -> unit
        abstract clearMeasures: ?measureName: string -> unit
        abstract clearResourceTimings: unit -> unit
        abstract getEntries: unit -> obj
        abstract getEntriesByName: name: string * ?entryType: string -> obj
        abstract getEntriesByType: entryType: string -> obj
        abstract getMarks: ?markName: string -> obj
        abstract getMeasures: ?measureName: string -> obj
        abstract mark: markName: string -> unit
        abstract ``measure``: measureName: string * ?startMarkName: string * ?endMarkName: string -> unit
        abstract now: unit -> float
        abstract setResourceTimingBufferSize: maxSize: float -> unit
        abstract toJSON: unit -> obj

    and [<AllowNullLiteral>] PerformanceType =
        abstract prototype: Performance with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Performance

    and [<AllowNullLiteral>] PerformanceEntry =
        abstract duration: float with get, set
        abstract entryType: string with get, set
        abstract name: string with get, set
        abstract startTime: float with get, set

    and [<AllowNullLiteral>] PerformanceEntryType =
        abstract prototype: PerformanceEntry with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceEntry

    and [<AllowNullLiteral>] PerformanceMark =
        inherit PerformanceEntry


    and [<AllowNullLiteral>] PerformanceMarkType =
        abstract prototype: PerformanceMark with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceMark

    and [<AllowNullLiteral>] PerformanceMeasure =
        inherit PerformanceEntry


    and [<AllowNullLiteral>] PerformanceMeasureType =
        abstract prototype: PerformanceMeasure with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceMeasure

    and [<AllowNullLiteral>] PerformanceNavigation =
        abstract redirectCount: float with get, set
        abstract ``type``: float with get, set
        abstract TYPE_BACK_FORWARD: float with get, set
        abstract TYPE_NAVIGATE: float with get, set
        abstract TYPE_RELOAD: float with get, set
        abstract TYPE_RESERVED: float with get, set
        abstract toJSON: unit -> obj

    and [<AllowNullLiteral>] PerformanceNavigationType =
        abstract prototype: PerformanceNavigation with get, set
        abstract TYPE_BACK_FORWARD: float with get, set
        abstract TYPE_NAVIGATE: float with get, set
        abstract TYPE_RELOAD: float with get, set
        abstract TYPE_RESERVED: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceNavigation

    and [<AllowNullLiteral>] PerformanceNavigationTiming =
        inherit PerformanceEntry
        abstract connectEnd: float with get, set
        abstract connectStart: float with get, set
        abstract domComplete: float with get, set
        abstract domContentLoadedEventEnd: float with get, set
        abstract domContentLoadedEventStart: float with get, set
        abstract domInteractive: float with get, set
        abstract domLoading: float with get, set
        abstract domainLookupEnd: float with get, set
        abstract domainLookupStart: float with get, set
        abstract fetchStart: float with get, set
        abstract loadEventEnd: float with get, set
        abstract loadEventStart: float with get, set
        abstract navigationStart: float with get, set
        abstract redirectCount: float with get, set
        abstract redirectEnd: float with get, set
        abstract redirectStart: float with get, set
        abstract requestStart: float with get, set
        abstract responseEnd: float with get, set
        abstract responseStart: float with get, set
        abstract ``type``: string with get, set
        abstract unloadEventEnd: float with get, set
        abstract unloadEventStart: float with get, set

    and [<AllowNullLiteral>] PerformanceNavigationTimingType =
        abstract prototype: PerformanceNavigationTiming with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceNavigationTiming

    and [<AllowNullLiteral>] PerformanceResourceTiming =
        inherit PerformanceEntry
        abstract connectEnd: float with get, set
        abstract connectStart: float with get, set
        abstract domainLookupEnd: float with get, set
        abstract domainLookupStart: float with get, set
        abstract fetchStart: float with get, set
        abstract initiatorType: string with get, set
        abstract redirectEnd: float with get, set
        abstract redirectStart: float with get, set
        abstract requestStart: float with get, set
        abstract responseEnd: float with get, set
        abstract responseStart: float with get, set

    and [<AllowNullLiteral>] PerformanceResourceTimingType =
        abstract prototype: PerformanceResourceTiming with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceResourceTiming

    and [<AllowNullLiteral>] PerformanceTiming =
        abstract connectEnd: float with get, set
        abstract connectStart: float with get, set
        abstract domComplete: float with get, set
        abstract domContentLoadedEventEnd: float with get, set
        abstract domContentLoadedEventStart: float with get, set
        abstract domInteractive: float with get, set
        abstract domLoading: float with get, set
        abstract domainLookupEnd: float with get, set
        abstract domainLookupStart: float with get, set
        abstract fetchStart: float with get, set
        abstract loadEventEnd: float with get, set
        abstract loadEventStart: float with get, set
        abstract navigationStart: float with get, set
        abstract redirectEnd: float with get, set
        abstract redirectStart: float with get, set
        abstract requestStart: float with get, set
        abstract responseEnd: float with get, set
        abstract responseStart: float with get, set
        abstract unloadEventEnd: float with get, set
        abstract unloadEventStart: float with get, set
        abstract toJSON: unit -> obj

    and [<AllowNullLiteral>] PerformanceTimingType =
        abstract prototype: PerformanceTiming with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PerformanceTiming

    and [<AllowNullLiteral>] PeriodicWave =
        interface end

    and [<AllowNullLiteral>] PeriodicWaveConstraints =
        abstract disableNormalisation: bool

    and [<AllowNullLiteral>] PeriodicWaveType =
        abstract prototype: PeriodicWave with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PeriodicWave

    and [<AllowNullLiteral>] PermissionRequest =
        inherit DeferredPermissionRequest
        abstract state: string with get, set
        abstract defer: unit -> unit

    and [<AllowNullLiteral>] PermissionRequestType =
        abstract prototype: PermissionRequest with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PermissionRequest

    and [<AllowNullLiteral>] PermissionRequestedEvent =
        inherit Event
        abstract permissionRequest: PermissionRequest with get, set

    and [<AllowNullLiteral>] PermissionRequestedEventType =
        abstract prototype: PermissionRequestedEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PermissionRequestedEvent

    and [<AllowNullLiteral>] Plugin =
        abstract description: string with get, set
        abstract filename: string with get, set
        abstract length: float with get, set
        abstract name: string with get, set
        abstract version: string with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> MimeType with get, set
        abstract item: index: float -> MimeType
        abstract namedItem: ``type``: string -> MimeType

    and [<AllowNullLiteral>] PluginType =
        abstract prototype: Plugin with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Plugin

    and [<AllowNullLiteral>] PluginArray =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Plugin with get, set
        abstract item: index: float -> Plugin
        abstract namedItem: name: string -> Plugin
        abstract refresh: ?reload: bool -> unit

    and [<AllowNullLiteral>] PluginArrayType =
        abstract prototype: PluginArray with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PluginArray

    and [<AllowNullLiteral>] PointerEvent =
        inherit MouseEvent
        abstract currentPoint: obj with get, set
        abstract height: float with get, set
        abstract hwTimestamp: float with get, set
        abstract intermediatePoints: obj with get, set
        abstract isPrimary: bool with get, set
        abstract pointerId: float with get, set
        abstract pointerType: obj with get, set
        abstract pressure: float with get, set
        abstract rotation: float with get, set
        abstract tiltX: float with get, set
        abstract tiltY: float with get, set
        abstract width: float with get, set
        abstract getCurrentPoint: element: Element -> unit
        abstract getIntermediatePoints: element: Element -> unit
        abstract initPointerEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float * screenXArg: float * screenYArg: float * clientXArg: float * clientYArg: float * ctrlKeyArg: bool * altKeyArg: bool * shiftKeyArg: bool * metaKeyArg: bool * buttonArg: float * relatedTargetArg: EventTarget * offsetXArg: float * offsetYArg: float * widthArg: float * heightArg: float * pressure: float * rotation: float * tiltX: float * tiltY: float * pointerIdArg: float * pointerType: obj * hwTimestampArg: float * isPrimary: bool -> unit

    and [<AllowNullLiteral>] PointerEventType =
        abstract prototype: PointerEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: PointerEventInit -> PointerEvent

    and [<AllowNullLiteral>] PopStateEvent =
        inherit Event
        abstract state: obj with get, set
        abstract initPopStateEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * stateArg: obj -> unit

    and [<AllowNullLiteral>] PopStateEventType =
        abstract prototype: PopStateEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PopStateEvent

    and [<AllowNullLiteral>] Position =
        abstract coords: Coordinates with get, set
        abstract timestamp: float with get, set

    and [<AllowNullLiteral>] PositionType =
        abstract prototype: Position with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Position

    and [<AllowNullLiteral>] PositionError =
        abstract code: float with get, set
        abstract message: string with get, set
        abstract PERMISSION_DENIED: float with get, set
        abstract POSITION_UNAVAILABLE: float with get, set
        abstract TIMEOUT: float with get, set
        abstract toString: unit -> string

    and [<AllowNullLiteral>] PositionErrorType =
        abstract prototype: PositionError with get, set
        abstract PERMISSION_DENIED: float with get, set
        abstract POSITION_UNAVAILABLE: float with get, set
        abstract TIMEOUT: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> PositionError

    and [<AllowNullLiteral>] ProcessingInstruction =
        inherit CharacterData
        abstract target: string with get, set

    and [<AllowNullLiteral>] ProcessingInstructionType =
        abstract prototype: ProcessingInstruction with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ProcessingInstruction

    and [<AllowNullLiteral>] ProgressEvent =
        inherit Event
        abstract lengthComputable: bool with get, set
        abstract loaded: float with get, set
        abstract total: float with get, set
        abstract initProgressEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * lengthComputableArg: bool * loadedArg: float * totalArg: float -> unit

    and [<AllowNullLiteral>] ProgressEventType =
        abstract prototype: ProgressEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: ProgressEventInit -> ProgressEvent

    and [<AllowNullLiteral>] PushEvent =
        inherit ExtendableEvent
        abstract data: PushMessageData with get, set

    and [<AllowNullLiteral>] PushManager =
        abstract getSubscription: unit -> Promise<PushSubscription>
        abstract permissionState: unit -> Promise<string>
        abstract subscribe: unit -> Promise<PushSubscription>

    and [<AllowNullLiteral>] PushMessageData =
        abstract arrayBuffer: unit -> ArrayBuffer
        abstract blob: unit -> Blob
        abstract json: unit -> obj option
        abstract text: unit -> string

    and [<AllowNullLiteral>] PushSubscription =
        abstract endpoint: string with get, set
        abstract getKey: ``method``: string -> ArrayBuffer
        abstract toJSON: unit -> string
        abstract unsubscribe: unit -> Promise<bool>

    and [<AllowNullLiteral>] Range =
        abstract collapsed: bool with get, set
        abstract commonAncestorContainer: Node with get, set
        abstract endContainer: Node with get, set
        abstract endOffset: float with get, set
        abstract startContainer: Node with get, set
        abstract startOffset: float with get, set
        abstract END_TO_END: float with get, set
        abstract END_TO_START: float with get, set
        abstract START_TO_END: float with get, set
        abstract START_TO_START: float with get, set
        abstract cloneContents: unit -> DocumentFragment
        abstract cloneRange: unit -> Range
        abstract collapse: toStart: bool -> unit
        abstract compareBoundaryPoints: how: float * sourceRange: Range -> float
        abstract createContextualFragment: fragment: string -> DocumentFragment
        abstract deleteContents: unit -> unit
        abstract detach: unit -> unit
        abstract expand: Unit: string -> bool
        abstract extractContents: unit -> DocumentFragment
        abstract getBoundingClientRect: unit -> ClientRect
        abstract getClientRects: unit -> ClientRectList
        abstract insertNode: newNode: Node -> unit
        abstract selectNode: refNode: Node -> unit
        abstract selectNodeContents: refNode: Node -> unit
        abstract setEnd: refNode: Node * offset: float -> unit
        abstract setEndAfter: refNode: Node -> unit
        abstract setEndBefore: refNode: Node -> unit
        abstract setStart: refNode: Node * offset: float -> unit
        abstract setStartAfter: refNode: Node -> unit
        abstract setStartBefore: refNode: Node -> unit
        abstract surroundContents: newParent: Node -> unit
        abstract toString: unit -> string

    and [<AllowNullLiteral>] RangeType =
        abstract prototype: Range with get, set
        abstract END_TO_END: float with get, set
        abstract END_TO_START: float with get, set
        abstract START_TO_END: float with get, set
        abstract START_TO_START: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Range

    and [<StringEnum>] [<RequireQualifiedAccess>] ReferrerPolicy =
        | [<CompiledName "">] Empty
        | [<CompiledName "no-referrer">] NoReferrer
        | [<CompiledName "no-referrer-when-downgrade">] NoReferrerWhenDowngrade
        | [<CompiledName "origin-only">] OriginOnly
        | [<CompiledName "origin-when-cross-origin">] OriginWhenCrossOrigin
        | [<CompiledName "unsafe-url">] UnsafeUrl

    and [<AllowNullLiteral>] Request =
        inherit Body
        abstract cache: RequestCache with get, set
        abstract credentials: RequestCredentials with get, set
        abstract headers: Headers with get, set
        abstract integrity: string with get, set
        abstract ``method``: string with get, set
        abstract mode: RequestMode with get, set
        abstract referrer: string with get, set
        abstract referrerPolicy: ReferrerPolicy with get, set
        abstract redirect: RequestRedirect with get, set
        abstract url: string with get, set
        abstract clone: unit -> Request

    and [<AllowNullLiteral>] RequestStatic =
        [<Emit "new $0($1...)">] abstract Create: url: string * ?init: RequestStaticInit -> Request

    and [<AllowNullLiteral>] RequestStaticInit =
        abstract ``method``: string option with get, set
        abstract url: string option with get, set
        abstract referrer: string option with get, set
        abstract mode: U4<string, string, string, string> option with get, set
        abstract credentials: U3<string, string, string> option with get, set
        abstract redirect: U3<string, string, string> option with get, set
        abstract integrity: string option with get, set
        abstract cache: U5<string, string, string, string, string> option with get, set
        abstract headers: Headers option with get, set

    and [<StringEnum>] [<RequireQualifiedAccess>] RequestCache =
        | Default
        | [<CompiledName "no-store">] NoStore
        | Reload
        | [<CompiledName "no-cache">] NoCache
        | [<CompiledName "force-cache">] ForceCache

    and [<StringEnum>] [<RequireQualifiedAccess>] RequestCredentials =
        | Omit
        | [<CompiledName "same-origin">] SameOrigin
        | Include

    and [<StringEnum>] [<RequireQualifiedAccess>] RequestMode =
        | Cors
        | [<CompiledName "no-cors">] NoCors
        | [<CompiledName "same-origin">] SameOrigin
        | Navigate

    and [<StringEnum>] [<RequireQualifiedAccess>] RequestRedirect =
        | Follow
        | Error
        | Manual

    and [<AllowNullLiteral>] Response =
        inherit Body
        abstract headers: Headers with get, set
        abstract ok: bool with get, set
        abstract redirected: bool with get, set
        abstract status: float with get, set
        abstract statusText: string with get, set
        abstract ``type``: ResponseType with get, set
        abstract url: string with get, set
        abstract useFinalURL: bool with get, set
        abstract clone: unit -> Response
        abstract error: unit -> Response
        abstract redirect: unit -> Response

    and [<AllowNullLiteral>] ResponseStatic =
        [<Emit "new $0($1...)">] abstract Create: url: string -> Response

    and [<AllowNullLiteral>] ResponseStaticInit =
        abstract status: float option with get, set
        abstract statusText: string option with get, set
        abstract headers: U2<Headers, obj> option with get, set

    and [<StringEnum>] [<RequireQualifiedAccess>] ResponseType =
        | Basic
        | Cores
        | Error
        | Opaque

    and [<AllowNullLiteral>] ServiceWorker =
        inherit Worker
        abstract scriptURL: string with get, set
        abstract state: ServiceWorkerState with get, set
        abstract addEventListener: event: string * listener: (Event -> 'Out) * ?useCapture : bool -> unit

    and [<AllowNullLiteral>] ServiceWorkerContainer =
        abstract controller: ServiceWorker option with get, set
        abstract oncontrollerchange: (Event -> obj option) option with get, set
        abstract onerror: (Event -> obj option) option with get, set
        abstract onmessage: (Event -> obj option) option with get, set
        abstract ready: Promise<ServiceWorkerRegistration> with get, set
        abstract getRegistration: ?scope: string -> Promise<ServiceWorkerRegistration>
        abstract getRegistrations: unit -> Promise<Array<ServiceWorkerRegistration>>
        abstract register: url: string * ?options: ServiceWorkerRegistrationOptions -> Promise<ServiceWorkerRegistration>

    and [<AllowNullLiteral>] ServiceWorkerNotificationOptions =
        abstract tag: string option with get, set

    and [<AllowNullLiteral>] ServiceWorkerRegistration =
        abstract active: ServiceWorker option with get, set
        abstract installing: ServiceWorker option with get, set
        abstract onupdatefound: (Event -> obj option) option with get, set
        abstract pushManager: PushManager with get, set
        abstract scope: string with get, set
        abstract waiting: ServiceWorker option with get, set
        abstract getNotifications: ?options: ServiceWorkerNotificationOptions -> Promise<Array<Notification>>
        abstract update: unit -> unit
        abstract unregister: unit -> Promise<bool>

    and [<AllowNullLiteral>] ServiceWorkerRegistrationOptions =
        abstract scope: string option with get, set

    and [<StringEnum>] [<RequireQualifiedAccess>] ServiceWorkerState =
        | Installing
        | Installed
        | Activating
        | Activated
        | Redundant

    // and [<AllowNullLiteral>] SVGAElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGURIReference
    //     abstract target: SVGAnimatedString with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGAElementType =
    //     abstract prototype: SVGAElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAElement

    // and [<AllowNullLiteral>] SVGAngle =
    //     abstract unitType: float with get, set
    //     abstract value: float with get, set
    //     abstract valueAsString: string with get, set
    //     abstract valueInSpecifiedUnits: float with get, set
    //     abstract SVG_ANGLETYPE_DEG: float with get, set
    //     abstract SVG_ANGLETYPE_GRAD: float with get, set
    //     abstract SVG_ANGLETYPE_RAD: float with get, set
    //     abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    //     abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    //     abstract convertToSpecifiedUnits: unitType: float -> unit
    //     abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

    // and [<AllowNullLiteral>] SVGAngleType =
    //     abstract prototype: SVGAngle with get, set
    //     abstract SVG_ANGLETYPE_DEG: float with get, set
    //     abstract SVG_ANGLETYPE_GRAD: float with get, set
    //     abstract SVG_ANGLETYPE_RAD: float with get, set
    //     abstract SVG_ANGLETYPE_UNKNOWN: float with get, set
    //     abstract SVG_ANGLETYPE_UNSPECIFIED: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAngle

    // and [<AllowNullLiteral>] SVGAnimatedAngle =
    //     abstract animVal: SVGAngle with get, set
    //     abstract baseVal: SVGAngle with get, set

    // and [<AllowNullLiteral>] SVGAnimatedAngleType =
    //     abstract prototype: SVGAnimatedAngle with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedAngle

    // and [<AllowNullLiteral>] SVGAnimatedBoolean =
    //     abstract animVal: bool with get, set
    //     abstract baseVal: bool with get, set

    // and [<AllowNullLiteral>] SVGAnimatedBooleanType =
    //     abstract prototype: SVGAnimatedBoolean with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedBoolean

    // and [<AllowNullLiteral>] SVGAnimatedEnumeration =
    //     abstract animVal: float with get, set
    //     abstract baseVal: float with get, set

    // and [<AllowNullLiteral>] SVGAnimatedEnumerationType =
    //     abstract prototype: SVGAnimatedEnumeration with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedEnumeration

    // and [<AllowNullLiteral>] SVGAnimatedInteger =
    //     abstract animVal: float with get, set
    //     abstract baseVal: float with get, set

    // and [<AllowNullLiteral>] SVGAnimatedIntegerType =
    //     abstract prototype: SVGAnimatedInteger with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedInteger

    // and [<AllowNullLiteral>] SVGAnimatedLength =
    //     abstract animVal: SVGLength with get, set
    //     abstract baseVal: SVGLength with get, set

    // and [<AllowNullLiteral>] SVGAnimatedLengthType =
    //     abstract prototype: SVGAnimatedLength with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedLength

    // and [<AllowNullLiteral>] SVGAnimatedLengthList =
    //     abstract animVal: SVGLengthList with get, set
    //     abstract baseVal: SVGLengthList with get, set

    // and [<AllowNullLiteral>] SVGAnimatedLengthListType =
    //     abstract prototype: SVGAnimatedLengthList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedLengthList

    // and [<AllowNullLiteral>] SVGAnimatedNumber =
    //     abstract animVal: float with get, set
    //     abstract baseVal: float with get, set

    // and [<AllowNullLiteral>] SVGAnimatedNumberType =
    //     abstract prototype: SVGAnimatedNumber with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedNumber

    // and [<AllowNullLiteral>] SVGAnimatedNumberList =
    //     abstract animVal: SVGNumberList with get, set
    //     abstract baseVal: SVGNumberList with get, set

    // and [<AllowNullLiteral>] SVGAnimatedNumberListType =
    //     abstract prototype: SVGAnimatedNumberList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedNumberList

    // and [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatio =
    //     abstract animVal: SVGPreserveAspectRatio with get, set
    //     abstract baseVal: SVGPreserveAspectRatio with get, set

    // and [<AllowNullLiteral>] SVGAnimatedPreserveAspectRatioType =
    //     abstract prototype: SVGAnimatedPreserveAspectRatio with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedPreserveAspectRatio

    // and [<AllowNullLiteral>] SVGAnimatedRect =
    //     abstract animVal: SVGRect with get, set
    //     abstract baseVal: SVGRect with get, set

    // and [<AllowNullLiteral>] SVGAnimatedRectType =
    //     abstract prototype: SVGAnimatedRect with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedRect

    // and [<AllowNullLiteral>] SVGAnimatedString =
    //     abstract animVal: string with get, set
    //     abstract baseVal: string with get, set

    // and [<AllowNullLiteral>] SVGAnimatedStringType =
    //     abstract prototype: SVGAnimatedString with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedString

    // and [<AllowNullLiteral>] SVGAnimatedTransformList =
    //     abstract animVal: SVGTransformList with get, set
    //     abstract baseVal: SVGTransformList with get, set

    // and [<AllowNullLiteral>] SVGAnimatedTransformListType =
    //     abstract prototype: SVGAnimatedTransformList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGAnimatedTransformList

    // and [<AllowNullLiteral>] SVGCircleElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract cx: SVGAnimatedLength with get, set
    //     abstract cy: SVGAnimatedLength with get, set
    //     abstract r: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGCircleElementType =
    //     abstract prototype: SVGCircleElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGCircleElement

    // and [<AllowNullLiteral>] SVGClipPathElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGUnitTypes
    //     abstract clipPathUnits: SVGAnimatedEnumeration with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGClipPathElementType =
    //     abstract prototype: SVGClipPathElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGClipPathElement

    // and [<AllowNullLiteral>] SVGComponentTransferFunctionElement =
    //     inherit SVGElement
    //     abstract amplitude: SVGAnimatedNumber with get, set
    //     abstract exponent: SVGAnimatedNumber with get, set
    //     abstract intercept: SVGAnimatedNumber with get, set
    //     abstract offset: SVGAnimatedNumber with get, set
    //     abstract slope: SVGAnimatedNumber with get, set
    //     abstract tableValues: SVGAnimatedNumberList with get, set
    //     abstract ``type``: SVGAnimatedEnumeration with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set

    // and [<AllowNullLiteral>] SVGComponentTransferFunctionElementType =
    //     abstract prototype: SVGComponentTransferFunctionElement with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_GAMMA: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_LINEAR: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_TABLE: float with get, set
    //     abstract SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGComponentTransferFunctionElement

    // and [<AllowNullLiteral>] SVGDefsElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGDefsElementType =
    //     abstract prototype: SVGDefsElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGDefsElement

    // and [<AllowNullLiteral>] SVGDescElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGLangSpace
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGDescElementType =
    //     abstract prototype: SVGDescElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGDescElement

    // and [<AllowNullLiteral>] SVGElement =
    //     inherit Element
    //     abstract id: string with get, set
    //     abstract onclick: (MouseEvent -> 'Out) with get, set
    //     abstract ondblclick: (MouseEvent -> 'Out) with get, set
    //     abstract onfocusin: (FocusEvent -> 'Out) with get, set
    //     abstract onfocusout: (FocusEvent -> 'Out) with get, set
    //     abstract onload: (Event -> 'Out) with get, set
    //     abstract onmousedown: (MouseEvent -> 'Out) with get, set
    //     abstract onmousemove: (MouseEvent -> 'Out) with get, set
    //     abstract onmouseout: (MouseEvent -> 'Out) with get, set
    //     abstract onmouseover: (MouseEvent -> 'Out) with get, set
    //     abstract onmouseup: (MouseEvent -> 'Out) with get, set
    //     abstract ownerSVGElement: SVGSVGElement with get, set
    //     abstract viewportElement: SVGElement with get, set
    //     abstract xmlbase: string with get, set
    //     abstract className: obj with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGElementType =
    //     abstract prototype: SVGElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElement

    // and [<AllowNullLiteral>] SVGElementInstance =
    //     inherit EventTarget
    //     abstract childNodes: SVGElementInstanceList with get, set
    //     abstract correspondingElement: SVGElement with get, set
    //     abstract correspondingUseElement: SVGUseElement with get, set
    //     abstract firstChild: SVGElementInstance with get, set
    //     abstract lastChild: SVGElementInstance with get, set
    //     abstract nextSibling: SVGElementInstance with get, set
    //     abstract parentNode: SVGElementInstance with get, set
    //     abstract previousSibling: SVGElementInstance with get, set

    // and [<AllowNullLiteral>] SVGElementInstanceType =
    //     abstract prototype: SVGElementInstance with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElementInstance

    // and [<AllowNullLiteral>] SVGElementInstanceList =
    //     abstract length: float with get, set
    //     abstract item: index: float -> SVGElementInstance

    // and [<AllowNullLiteral>] SVGElementInstanceListType =
    //     abstract prototype: SVGElementInstanceList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGElementInstanceList

    // and [<AllowNullLiteral>] SVGEllipseElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract cx: SVGAnimatedLength with get, set
    //     abstract cy: SVGAnimatedLength with get, set
    //     abstract rx: SVGAnimatedLength with get, set
    //     abstract ry: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGEllipseElementType =
    //     abstract prototype: SVGEllipseElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGEllipseElement

    // and [<AllowNullLiteral>] SVGFEBlendElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract in2: SVGAnimatedString with get, set
    //     abstract mode: SVGAnimatedEnumeration with get, set
    //     abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    //     abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    //     abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    //     abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    //     abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    //     abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    //     abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    //     abstract SVG_FEBLEND_MODE_HUE: float with get, set
    //     abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    //     abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    //     abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    //     abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    //     abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    //     abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    //     abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    //     abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    //     abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEBlendElementType =
    //     abstract prototype: SVGFEBlendElement with get, set
    //     abstract SVG_FEBLEND_MODE_COLOR: float with get, set
    //     abstract SVG_FEBLEND_MODE_COLOR_BURN: float with get, set
    //     abstract SVG_FEBLEND_MODE_COLOR_DODGE: float with get, set
    //     abstract SVG_FEBLEND_MODE_DARKEN: float with get, set
    //     abstract SVG_FEBLEND_MODE_DIFFERENCE: float with get, set
    //     abstract SVG_FEBLEND_MODE_EXCLUSION: float with get, set
    //     abstract SVG_FEBLEND_MODE_HARD_LIGHT: float with get, set
    //     abstract SVG_FEBLEND_MODE_HUE: float with get, set
    //     abstract SVG_FEBLEND_MODE_LIGHTEN: float with get, set
    //     abstract SVG_FEBLEND_MODE_LUMINOSITY: float with get, set
    //     abstract SVG_FEBLEND_MODE_MULTIPLY: float with get, set
    //     abstract SVG_FEBLEND_MODE_NORMAL: float with get, set
    //     abstract SVG_FEBLEND_MODE_OVERLAY: float with get, set
    //     abstract SVG_FEBLEND_MODE_SATURATION: float with get, set
    //     abstract SVG_FEBLEND_MODE_SCREEN: float with get, set
    //     abstract SVG_FEBLEND_MODE_SOFT_LIGHT: float with get, set
    //     abstract SVG_FEBLEND_MODE_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEBlendElement

    // and [<AllowNullLiteral>] SVGFEColorMatrixElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract ``type``: SVGAnimatedEnumeration with get, set
    //     abstract values: SVGAnimatedNumberList with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEColorMatrixElementType =
    //     abstract prototype: SVGFEColorMatrixElement with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_HUEROTATE: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_MATRIX: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_SATURATE: float with get, set
    //     abstract SVG_FECOLORMATRIX_TYPE_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEColorMatrixElement

    // and [<AllowNullLiteral>] SVGFEComponentTransferElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEComponentTransferElementType =
    //     abstract prototype: SVGFEComponentTransferElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEComponentTransferElement

    // and [<AllowNullLiteral>] SVGFECompositeElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract in2: SVGAnimatedString with get, set
    //     abstract k1: SVGAnimatedNumber with get, set
    //     abstract k2: SVGAnimatedNumber with get, set
    //     abstract k3: SVGAnimatedNumber with get, set
    //     abstract k4: SVGAnimatedNumber with get, set
    //     abstract operator: SVGAnimatedEnumeration with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFECompositeElementType =
    //     abstract prototype: SVGFECompositeElement with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_ARITHMETIC: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_ATOP: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_IN: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_OUT: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_OVER: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_UNKNOWN: float with get, set
    //     abstract SVG_FECOMPOSITE_OPERATOR_XOR: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFECompositeElement

    // and [<AllowNullLiteral>] SVGFEConvolveMatrixElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract bias: SVGAnimatedNumber with get, set
    //     abstract divisor: SVGAnimatedNumber with get, set
    //     abstract edgeMode: SVGAnimatedEnumeration with get, set
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract kernelMatrix: SVGAnimatedNumberList with get, set
    //     abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    //     abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    //     abstract orderX: SVGAnimatedInteger with get, set
    //     abstract orderY: SVGAnimatedInteger with get, set
    //     abstract preserveAlpha: SVGAnimatedBoolean with get, set
    //     abstract targetX: SVGAnimatedInteger with get, set
    //     abstract targetY: SVGAnimatedInteger with get, set
    //     abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    //     abstract SVG_EDGEMODE_NONE: float with get, set
    //     abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    //     abstract SVG_EDGEMODE_WRAP: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEConvolveMatrixElementType =
    //     abstract prototype: SVGFEConvolveMatrixElement with get, set
    //     abstract SVG_EDGEMODE_DUPLICATE: float with get, set
    //     abstract SVG_EDGEMODE_NONE: float with get, set
    //     abstract SVG_EDGEMODE_UNKNOWN: float with get, set
    //     abstract SVG_EDGEMODE_WRAP: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEConvolveMatrixElement

    // and [<AllowNullLiteral>] SVGFEDiffuseLightingElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract diffuseConstant: SVGAnimatedNumber with get, set
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    //     abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    //     abstract surfaceScale: SVGAnimatedNumber with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEDiffuseLightingElementType =
    //     abstract prototype: SVGFEDiffuseLightingElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDiffuseLightingElement

    // and [<AllowNullLiteral>] SVGFEDisplacementMapElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract in2: SVGAnimatedString with get, set
    //     abstract scale: SVGAnimatedNumber with get, set
    //     abstract xChannelSelector: SVGAnimatedEnumeration with get, set
    //     abstract yChannelSelector: SVGAnimatedEnumeration with get, set
    //     abstract SVG_CHANNEL_A: float with get, set
    //     abstract SVG_CHANNEL_B: float with get, set
    //     abstract SVG_CHANNEL_G: float with get, set
    //     abstract SVG_CHANNEL_R: float with get, set
    //     abstract SVG_CHANNEL_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEDisplacementMapElementType =
    //     abstract prototype: SVGFEDisplacementMapElement with get, set
    //     abstract SVG_CHANNEL_A: float with get, set
    //     abstract SVG_CHANNEL_B: float with get, set
    //     abstract SVG_CHANNEL_G: float with get, set
    //     abstract SVG_CHANNEL_R: float with get, set
    //     abstract SVG_CHANNEL_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDisplacementMapElement

    // and [<AllowNullLiteral>] SVGFEDistantLightElement =
    //     inherit SVGElement
    //     abstract azimuth: SVGAnimatedNumber with get, set
    //     abstract elevation: SVGAnimatedNumber with get, set

    // and [<AllowNullLiteral>] SVGFEDistantLightElementType =
    //     abstract prototype: SVGFEDistantLightElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEDistantLightElement

    // and [<AllowNullLiteral>] SVGFEFloodElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEFloodElementType =
    //     abstract prototype: SVGFEFloodElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFloodElement

    // and [<AllowNullLiteral>] SVGFEFuncAElement =
    //     inherit SVGComponentTransferFunctionElement


    // and [<AllowNullLiteral>] SVGFEFuncAElementType =
    //     abstract prototype: SVGFEFuncAElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncAElement

    // and [<AllowNullLiteral>] SVGFEFuncBElement =
    //     inherit SVGComponentTransferFunctionElement


    // and [<AllowNullLiteral>] SVGFEFuncBElementType =
    //     abstract prototype: SVGFEFuncBElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncBElement

    // and [<AllowNullLiteral>] SVGFEFuncGElement =
    //     inherit SVGComponentTransferFunctionElement


    // and [<AllowNullLiteral>] SVGFEFuncGElementType =
    //     abstract prototype: SVGFEFuncGElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncGElement

    // and [<AllowNullLiteral>] SVGFEFuncRElement =
    //     inherit SVGComponentTransferFunctionElement


    // and [<AllowNullLiteral>] SVGFEFuncRElementType =
    //     abstract prototype: SVGFEFuncRElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEFuncRElement

    // and [<AllowNullLiteral>] SVGFEGaussianBlurElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract stdDeviationX: SVGAnimatedNumber with get, set
    //     abstract stdDeviationY: SVGAnimatedNumber with get, set
    //     abstract setStdDeviation: stdDeviationX: float * stdDeviationY: float -> unit
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEGaussianBlurElementType =
    //     abstract prototype: SVGFEGaussianBlurElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEGaussianBlurElement

    // and [<AllowNullLiteral>] SVGFEImageElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     inherit SVGLangSpace
    //     inherit SVGURIReference
    //     inherit SVGExternalResourcesRequired
    //     abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEImageElementType =
    //     abstract prototype: SVGFEImageElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEImageElement

    // and [<AllowNullLiteral>] SVGFEMergeElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEMergeElementType =
    //     abstract prototype: SVGFEMergeElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMergeElement

    // and [<AllowNullLiteral>] SVGFEMergeNodeElement =
    //     inherit SVGElement
    //     abstract in1: SVGAnimatedString with get, set

    // and [<AllowNullLiteral>] SVGFEMergeNodeElementType =
    //     abstract prototype: SVGFEMergeNodeElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMergeNodeElement

    // and [<AllowNullLiteral>] SVGFEMorphologyElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract operator: SVGAnimatedEnumeration with get, set
    //     abstract radiusX: SVGAnimatedNumber with get, set
    //     abstract radiusY: SVGAnimatedNumber with get, set
    //     abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    //     abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    //     abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEMorphologyElementType =
    //     abstract prototype: SVGFEMorphologyElement with get, set
    //     abstract SVG_MORPHOLOGY_OPERATOR_DILATE: float with get, set
    //     abstract SVG_MORPHOLOGY_OPERATOR_ERODE: float with get, set
    //     abstract SVG_MORPHOLOGY_OPERATOR_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEMorphologyElement

    // and [<AllowNullLiteral>] SVGFEOffsetElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract dx: SVGAnimatedNumber with get, set
    //     abstract dy: SVGAnimatedNumber with get, set
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFEOffsetElementType =
    //     abstract prototype: SVGFEOffsetElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEOffsetElement

    // and [<AllowNullLiteral>] SVGFEPointLightElement =
    //     inherit SVGElement
    //     abstract x: SVGAnimatedNumber with get, set
    //     abstract y: SVGAnimatedNumber with get, set
    //     abstract z: SVGAnimatedNumber with get, set

    // and [<AllowNullLiteral>] SVGFEPointLightElementType =
    //     abstract prototype: SVGFEPointLightElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFEPointLightElement

    // and [<AllowNullLiteral>] SVGFESpecularLightingElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract kernelUnitLengthX: SVGAnimatedNumber with get, set
    //     abstract kernelUnitLengthY: SVGAnimatedNumber with get, set
    //     abstract specularConstant: SVGAnimatedNumber with get, set
    //     abstract specularExponent: SVGAnimatedNumber with get, set
    //     abstract surfaceScale: SVGAnimatedNumber with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFESpecularLightingElementType =
    //     abstract prototype: SVGFESpecularLightingElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFESpecularLightingElement

    // and [<AllowNullLiteral>] SVGFESpotLightElement =
    //     inherit SVGElement
    //     abstract limitingConeAngle: SVGAnimatedNumber with get, set
    //     abstract pointsAtX: SVGAnimatedNumber with get, set
    //     abstract pointsAtY: SVGAnimatedNumber with get, set
    //     abstract pointsAtZ: SVGAnimatedNumber with get, set
    //     abstract specularExponent: SVGAnimatedNumber with get, set
    //     abstract x: SVGAnimatedNumber with get, set
    //     abstract y: SVGAnimatedNumber with get, set
    //     abstract z: SVGAnimatedNumber with get, set

    // and [<AllowNullLiteral>] SVGFESpotLightElementType =
    //     abstract prototype: SVGFESpotLightElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFESpotLightElement

    // and [<AllowNullLiteral>] SVGFETileElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract in1: SVGAnimatedString with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFETileElementType =
    //     abstract prototype: SVGFETileElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFETileElement

    // and [<AllowNullLiteral>] SVGFETurbulenceElement =
    //     inherit SVGElement
    //     inherit SVGFilterPrimitiveStandardAttributes
    //     abstract baseFrequencyX: SVGAnimatedNumber with get, set
    //     abstract baseFrequencyY: SVGAnimatedNumber with get, set
    //     abstract numOctaves: SVGAnimatedInteger with get, set
    //     abstract seed: SVGAnimatedNumber with get, set
    //     abstract stitchTiles: SVGAnimatedEnumeration with get, set
    //     abstract ``type``: SVGAnimatedEnumeration with get, set
    //     abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    //     abstract SVG_STITCHTYPE_STITCH: float with get, set
    //     abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    //     abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    //     abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    //     abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFETurbulenceElementType =
    //     abstract prototype: SVGFETurbulenceElement with get, set
    //     abstract SVG_STITCHTYPE_NOSTITCH: float with get, set
    //     abstract SVG_STITCHTYPE_STITCH: float with get, set
    //     abstract SVG_STITCHTYPE_UNKNOWN: float with get, set
    //     abstract SVG_TURBULENCE_TYPE_FRACTALNOISE: float with get, set
    //     abstract SVG_TURBULENCE_TYPE_TURBULENCE: float with get, set
    //     abstract SVG_TURBULENCE_TYPE_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFETurbulenceElement

    // and [<AllowNullLiteral>] SVGFilterElement =
    //     inherit SVGElement
    //     inherit SVGUnitTypes
    //     inherit SVGStylable
    //     inherit SVGLangSpace
    //     inherit SVGURIReference
    //     inherit SVGExternalResourcesRequired
    //     abstract filterResX: SVGAnimatedInteger with get, set
    //     abstract filterResY: SVGAnimatedInteger with get, set
    //     abstract filterUnits: SVGAnimatedEnumeration with get, set
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract primitiveUnits: SVGAnimatedEnumeration with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract setFilterRes: filterResX: float * filterResY: float -> unit
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGFilterElementType =
    //     abstract prototype: SVGFilterElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGFilterElement

    // and [<AllowNullLiteral>] SVGForeignObjectElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGForeignObjectElementType =
    //     abstract prototype: SVGForeignObjectElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGForeignObjectElement

    // and [<AllowNullLiteral>] SVGGElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGGElementType =
    //     abstract prototype: SVGGElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGGElement

    // and [<AllowNullLiteral>] SVGGradientElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGURIReference
    //     inherit SVGUnitTypes
    //     abstract gradientTransform: SVGAnimatedTransformList with get, set
    //     abstract gradientUnits: SVGAnimatedEnumeration with get, set
    //     abstract spreadMethod: SVGAnimatedEnumeration with get, set
    //     abstract SVG_SPREADMETHOD_PAD: float with get, set
    //     abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    //     abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    //     abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGGradientElementType =
    //     abstract prototype: SVGGradientElement with get, set
    //     abstract SVG_SPREADMETHOD_PAD: float with get, set
    //     abstract SVG_SPREADMETHOD_REFLECT: float with get, set
    //     abstract SVG_SPREADMETHOD_REPEAT: float with get, set
    //     abstract SVG_SPREADMETHOD_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGGradientElement

    // and [<AllowNullLiteral>] SVGImageElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGURIReference
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGImageElementType =
    //     abstract prototype: SVGImageElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGImageElement

    // and [<AllowNullLiteral>] SVGLength =
    //     abstract unitType: float with get, set
    //     abstract value: float with get, set
    //     abstract valueAsString: string with get, set
    //     abstract valueInSpecifiedUnits: float with get, set
    //     abstract SVG_LENGTHTYPE_CM: float with get, set
    //     abstract SVG_LENGTHTYPE_EMS: float with get, set
    //     abstract SVG_LENGTHTYPE_EXS: float with get, set
    //     abstract SVG_LENGTHTYPE_IN: float with get, set
    //     abstract SVG_LENGTHTYPE_MM: float with get, set
    //     abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    //     abstract SVG_LENGTHTYPE_PC: float with get, set
    //     abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    //     abstract SVG_LENGTHTYPE_PT: float with get, set
    //     abstract SVG_LENGTHTYPE_PX: float with get, set
    //     abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    //     abstract convertToSpecifiedUnits: unitType: float -> unit
    //     abstract newValueSpecifiedUnits: unitType: float * valueInSpecifiedUnits: float -> unit

    // and [<AllowNullLiteral>] SVGLengthType =
    //     abstract prototype: SVGLength with get, set
    //     abstract SVG_LENGTHTYPE_CM: float with get, set
    //     abstract SVG_LENGTHTYPE_EMS: float with get, set
    //     abstract SVG_LENGTHTYPE_EXS: float with get, set
    //     abstract SVG_LENGTHTYPE_IN: float with get, set
    //     abstract SVG_LENGTHTYPE_MM: float with get, set
    //     abstract SVG_LENGTHTYPE_NUMBER: float with get, set
    //     abstract SVG_LENGTHTYPE_PC: float with get, set
    //     abstract SVG_LENGTHTYPE_PERCENTAGE: float with get, set
    //     abstract SVG_LENGTHTYPE_PT: float with get, set
    //     abstract SVG_LENGTHTYPE_PX: float with get, set
    //     abstract SVG_LENGTHTYPE_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLength

    // and [<AllowNullLiteral>] SVGLengthList =
    //     abstract numberOfItems: float with get, set
    //     abstract appendItem: newItem: SVGLength -> SVGLength
    //     abstract clear: unit -> unit
    //     abstract getItem: index: float -> SVGLength
    //     abstract initialize: newItem: SVGLength -> SVGLength
    //     abstract insertItemBefore: newItem: SVGLength * index: float -> SVGLength
    //     abstract removeItem: index: float -> SVGLength
    //     abstract replaceItem: newItem: SVGLength * index: float -> SVGLength

    // and [<AllowNullLiteral>] SVGLengthListType =
    //     abstract prototype: SVGLengthList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLengthList

    // and [<AllowNullLiteral>] SVGLineElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract x1: SVGAnimatedLength with get, set
    //     abstract x2: SVGAnimatedLength with get, set
    //     abstract y1: SVGAnimatedLength with get, set
    //     abstract y2: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGLineElementType =
    //     abstract prototype: SVGLineElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLineElement

    // and [<AllowNullLiteral>] SVGLinearGradientElement =
    //     inherit SVGGradientElement
    //     abstract x1: SVGAnimatedLength with get, set
    //     abstract x2: SVGAnimatedLength with get, set
    //     abstract y1: SVGAnimatedLength with get, set
    //     abstract y2: SVGAnimatedLength with get, set

    // and [<AllowNullLiteral>] SVGLinearGradientElementType =
    //     abstract prototype: SVGLinearGradientElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGLinearGradientElement

    // and [<AllowNullLiteral>] SVGMarkerElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGFitToViewBox
    //     abstract markerHeight: SVGAnimatedLength with get, set
    //     abstract markerUnits: SVGAnimatedEnumeration with get, set
    //     abstract markerWidth: SVGAnimatedLength with get, set
    //     abstract orientAngle: SVGAnimatedAngle with get, set
    //     abstract orientType: SVGAnimatedEnumeration with get, set
    //     abstract refX: SVGAnimatedLength with get, set
    //     abstract refY: SVGAnimatedLength with get, set
    //     abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    //     abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    //     abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    //     abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    //     abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    //     abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    //     abstract setOrientToAngle: angle: SVGAngle -> unit
    //     abstract setOrientToAuto: unit -> unit
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGMarkerElementType =
    //     abstract prototype: SVGMarkerElement with get, set
    //     abstract SVG_MARKERUNITS_STROKEWIDTH: float with get, set
    //     abstract SVG_MARKERUNITS_UNKNOWN: float with get, set
    //     abstract SVG_MARKERUNITS_USERSPACEONUSE: float with get, set
    //     abstract SVG_MARKER_ORIENT_ANGLE: float with get, set
    //     abstract SVG_MARKER_ORIENT_AUTO: float with get, set
    //     abstract SVG_MARKER_ORIENT_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMarkerElement

    // and [<AllowNullLiteral>] SVGMaskElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGUnitTypes
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract maskContentUnits: SVGAnimatedEnumeration with get, set
    //     abstract maskUnits: SVGAnimatedEnumeration with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGMaskElementType =
    //     abstract prototype: SVGMaskElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMaskElement

    // and [<AllowNullLiteral>] SVGMatrix =
    //     abstract a: float with get, set
    //     abstract b: float with get, set
    //     abstract c: float with get, set
    //     abstract d: float with get, set
    //     abstract e: float with get, set
    //     abstract f: float with get, set
    //     abstract flipX: unit -> SVGMatrix
    //     abstract flipY: unit -> SVGMatrix
    //     abstract inverse: unit -> SVGMatrix
    //     abstract multiply: secondMatrix: SVGMatrix -> SVGMatrix
    //     abstract rotate: angle: float -> SVGMatrix
    //     abstract rotateFromVector: x: float * y: float -> SVGMatrix
    //     abstract scale: scaleFactor: float -> SVGMatrix
    //     abstract scaleNonUniform: scaleFactorX: float * scaleFactorY: float -> SVGMatrix
    //     abstract skewX: angle: float -> SVGMatrix
    //     abstract skewY: angle: float -> SVGMatrix
    //     abstract translate: x: float * y: float -> SVGMatrix

    // and [<AllowNullLiteral>] SVGMatrixType =
    //     abstract prototype: SVGMatrix with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMatrix

    // and [<AllowNullLiteral>] SVGMetadataElement =
    //     inherit SVGElement


    // and [<AllowNullLiteral>] SVGMetadataElementType =
    //     abstract prototype: SVGMetadataElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGMetadataElement

    // and [<AllowNullLiteral>] SVGNumber =
    //     abstract value: float with get, set

    // and [<AllowNullLiteral>] SVGNumberType =
    //     abstract prototype: SVGNumber with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGNumber

    // and [<AllowNullLiteral>] SVGNumberList =
    //     abstract numberOfItems: float with get, set
    //     abstract appendItem: newItem: SVGNumber -> SVGNumber
    //     abstract clear: unit -> unit
    //     abstract getItem: index: float -> SVGNumber
    //     abstract initialize: newItem: SVGNumber -> SVGNumber
    //     abstract insertItemBefore: newItem: SVGNumber * index: float -> SVGNumber
    //     abstract removeItem: index: float -> SVGNumber
    //     abstract replaceItem: newItem: SVGNumber * index: float -> SVGNumber

    // and [<AllowNullLiteral>] SVGNumberListType =
    //     abstract prototype: SVGNumberList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGNumberList

    // and [<AllowNullLiteral>] SVGPathElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGAnimatedPathData
    //     abstract createSVGPathSegArcAbs: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcAbs
    //     abstract createSVGPathSegArcRel: x: float * y: float * r1: float * r2: float * angle: float * largeArcFlag: bool * sweepFlag: bool -> SVGPathSegArcRel
    //     abstract createSVGPathSegClosePath: unit -> SVGPathSegClosePath
    //     abstract createSVGPathSegCurvetoCubicAbs: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicAbs
    //     abstract createSVGPathSegCurvetoCubicRel: x: float * y: float * x1: float * y1: float * x2: float * y2: float -> SVGPathSegCurvetoCubicRel
    //     abstract createSVGPathSegCurvetoCubicSmoothAbs: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothAbs
    //     abstract createSVGPathSegCurvetoCubicSmoothRel: x: float * y: float * x2: float * y2: float -> SVGPathSegCurvetoCubicSmoothRel
    //     abstract createSVGPathSegCurvetoQuadraticAbs: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticAbs
    //     abstract createSVGPathSegCurvetoQuadraticRel: x: float * y: float * x1: float * y1: float -> SVGPathSegCurvetoQuadraticRel
    //     abstract createSVGPathSegCurvetoQuadraticSmoothAbs: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothAbs
    //     abstract createSVGPathSegCurvetoQuadraticSmoothRel: x: float * y: float -> SVGPathSegCurvetoQuadraticSmoothRel
    //     abstract createSVGPathSegLinetoAbs: x: float * y: float -> SVGPathSegLinetoAbs
    //     abstract createSVGPathSegLinetoHorizontalAbs: x: float -> SVGPathSegLinetoHorizontalAbs
    //     abstract createSVGPathSegLinetoHorizontalRel: x: float -> SVGPathSegLinetoHorizontalRel
    //     abstract createSVGPathSegLinetoRel: x: float * y: float -> SVGPathSegLinetoRel
    //     abstract createSVGPathSegLinetoVerticalAbs: y: float -> SVGPathSegLinetoVerticalAbs
    //     abstract createSVGPathSegLinetoVerticalRel: y: float -> SVGPathSegLinetoVerticalRel
    //     abstract createSVGPathSegMovetoAbs: x: float * y: float -> SVGPathSegMovetoAbs
    //     abstract createSVGPathSegMovetoRel: x: float * y: float -> SVGPathSegMovetoRel
    //     abstract getPathSegAtLength: distance: float -> float
    //     abstract getPointAtLength: distance: float -> SVGPoint
    //     abstract getTotalLength: unit -> float
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGPathElementType =
    //     abstract prototype: SVGPathElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathElement

    // and [<AllowNullLiteral>] SVGPathSeg =
    //     abstract pathSegType: float with get, set
    //     abstract pathSegTypeAsLetter: string with get, set
    //     abstract PATHSEG_ARC_ABS: float with get, set
    //     abstract PATHSEG_ARC_REL: float with get, set
    //     abstract PATHSEG_CLOSEPATH: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    //     abstract PATHSEG_LINETO_ABS: float with get, set
    //     abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    //     abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    //     abstract PATHSEG_LINETO_REL: float with get, set
    //     abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    //     abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    //     abstract PATHSEG_MOVETO_ABS: float with get, set
    //     abstract PATHSEG_MOVETO_REL: float with get, set
    //     abstract PATHSEG_UNKNOWN: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegType =
    //     abstract prototype: SVGPathSeg with get, set
    //     abstract PATHSEG_ARC_ABS: float with get, set
    //     abstract PATHSEG_ARC_REL: float with get, set
    //     abstract PATHSEG_CLOSEPATH: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_REL: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_SMOOTH_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_CUBIC_SMOOTH_REL: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_REL: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS: float with get, set
    //     abstract PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL: float with get, set
    //     abstract PATHSEG_LINETO_ABS: float with get, set
    //     abstract PATHSEG_LINETO_HORIZONTAL_ABS: float with get, set
    //     abstract PATHSEG_LINETO_HORIZONTAL_REL: float with get, set
    //     abstract PATHSEG_LINETO_REL: float with get, set
    //     abstract PATHSEG_LINETO_VERTICAL_ABS: float with get, set
    //     abstract PATHSEG_LINETO_VERTICAL_REL: float with get, set
    //     abstract PATHSEG_MOVETO_ABS: float with get, set
    //     abstract PATHSEG_MOVETO_REL: float with get, set
    //     abstract PATHSEG_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSeg

    // and [<AllowNullLiteral>] SVGPathSegArcAbs =
    //     inherit SVGPathSeg
    //     abstract angle: float with get, set
    //     abstract largeArcFlag: bool with get, set
    //     abstract r1: float with get, set
    //     abstract r2: float with get, set
    //     abstract sweepFlag: bool with get, set
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegArcAbsType =
    //     abstract prototype: SVGPathSegArcAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegArcAbs

    // and [<AllowNullLiteral>] SVGPathSegArcRel =
    //     inherit SVGPathSeg
    //     abstract angle: float with get, set
    //     abstract largeArcFlag: bool with get, set
    //     abstract r1: float with get, set
    //     abstract r2: float with get, set
    //     abstract sweepFlag: bool with get, set
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegArcRelType =
    //     abstract prototype: SVGPathSegArcRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegArcRel

    // and [<AllowNullLiteral>] SVGPathSegClosePath =
    //     inherit SVGPathSeg


    // and [<AllowNullLiteral>] SVGPathSegClosePathType =
    //     abstract prototype: SVGPathSegClosePath with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegClosePath

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract x1: float with get, set
    //     abstract x2: float with get, set
    //     abstract y: float with get, set
    //     abstract y1: float with get, set
    //     abstract y2: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicAbsType =
    //     abstract prototype: SVGPathSegCurvetoCubicAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicAbs

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract x1: float with get, set
    //     abstract x2: float with get, set
    //     abstract y: float with get, set
    //     abstract y1: float with get, set
    //     abstract y2: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicRelType =
    //     abstract prototype: SVGPathSegCurvetoCubicRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicRel

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract x2: float with get, set
    //     abstract y: float with get, set
    //     abstract y2: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothAbsType =
    //     abstract prototype: SVGPathSegCurvetoCubicSmoothAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicSmoothAbs

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract x2: float with get, set
    //     abstract y: float with get, set
    //     abstract y2: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoCubicSmoothRelType =
    //     abstract prototype: SVGPathSegCurvetoCubicSmoothRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoCubicSmoothRel

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract x1: float with get, set
    //     abstract y: float with get, set
    //     abstract y1: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticAbsType =
    //     abstract prototype: SVGPathSegCurvetoQuadraticAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticAbs

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract x1: float with get, set
    //     abstract y: float with get, set
    //     abstract y1: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticRelType =
    //     abstract prototype: SVGPathSegCurvetoQuadraticRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticRel

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothAbsType =
    //     abstract prototype: SVGPathSegCurvetoQuadraticSmoothAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothAbs

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegCurvetoQuadraticSmoothRelType =
    //     abstract prototype: SVGPathSegCurvetoQuadraticSmoothRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegCurvetoQuadraticSmoothRel

    // and [<AllowNullLiteral>] SVGPathSegLinetoAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegLinetoAbsType =
    //     abstract prototype: SVGPathSegLinetoAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoAbs

    // and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalAbsType =
    //     abstract prototype: SVGPathSegLinetoHorizontalAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoHorizontalAbs

    // and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegLinetoHorizontalRelType =
    //     abstract prototype: SVGPathSegLinetoHorizontalRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoHorizontalRel

    // and [<AllowNullLiteral>] SVGPathSegLinetoRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegLinetoRelType =
    //     abstract prototype: SVGPathSegLinetoRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoRel

    // and [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbs =
    //     inherit SVGPathSeg
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegLinetoVerticalAbsType =
    //     abstract prototype: SVGPathSegLinetoVerticalAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoVerticalAbs

    // and [<AllowNullLiteral>] SVGPathSegLinetoVerticalRel =
    //     inherit SVGPathSeg
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegLinetoVerticalRelType =
    //     abstract prototype: SVGPathSegLinetoVerticalRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegLinetoVerticalRel

    // and [<AllowNullLiteral>] SVGPathSegList =
    //     abstract numberOfItems: float with get, set
    //     abstract appendItem: newItem: SVGPathSeg -> SVGPathSeg
    //     abstract clear: unit -> unit
    //     abstract getItem: index: float -> SVGPathSeg
    //     abstract initialize: newItem: SVGPathSeg -> SVGPathSeg
    //     abstract insertItemBefore: newItem: SVGPathSeg * index: float -> SVGPathSeg
    //     abstract removeItem: index: float -> SVGPathSeg
    //     abstract replaceItem: newItem: SVGPathSeg * index: float -> SVGPathSeg

    // and [<AllowNullLiteral>] SVGPathSegListType =
    //     abstract prototype: SVGPathSegList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegList

    // and [<AllowNullLiteral>] SVGPathSegMovetoAbs =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegMovetoAbsType =
    //     abstract prototype: SVGPathSegMovetoAbs with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegMovetoAbs

    // and [<AllowNullLiteral>] SVGPathSegMovetoRel =
    //     inherit SVGPathSeg
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGPathSegMovetoRelType =
    //     abstract prototype: SVGPathSegMovetoRel with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPathSegMovetoRel

    // and [<AllowNullLiteral>] SVGPatternElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGFitToViewBox
    //     inherit SVGURIReference
    //     inherit SVGUnitTypes
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract patternContentUnits: SVGAnimatedEnumeration with get, set
    //     abstract patternTransform: SVGAnimatedTransformList with get, set
    //     abstract patternUnits: SVGAnimatedEnumeration with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGPatternElementType =
    //     abstract prototype: SVGPatternElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPatternElement

    // and [<AllowNullLiteral>] SVGPoint =
    //     abstract x: float with get, set
    //     abstract y: float with get, set
    //     abstract matrixTransform: matrix: SVGMatrix -> SVGPoint

    // and [<AllowNullLiteral>] SVGPointType =
    //     abstract prototype: SVGPoint with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPoint

    // and [<AllowNullLiteral>] SVGPointList =
    //     abstract numberOfItems: float with get, set
    //     abstract appendItem: newItem: SVGPoint -> SVGPoint
    //     abstract clear: unit -> unit
    //     abstract getItem: index: float -> SVGPoint
    //     abstract initialize: newItem: SVGPoint -> SVGPoint
    //     abstract insertItemBefore: newItem: SVGPoint * index: float -> SVGPoint
    //     abstract removeItem: index: float -> SVGPoint
    //     abstract replaceItem: newItem: SVGPoint * index: float -> SVGPoint

    // and [<AllowNullLiteral>] SVGPointListType =
    //     abstract prototype: SVGPointList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPointList

    // and [<AllowNullLiteral>] SVGPolygonElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGAnimatedPoints
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGPolygonElementType =
    //     abstract prototype: SVGPolygonElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPolygonElement

    // and [<AllowNullLiteral>] SVGPolylineElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGAnimatedPoints
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGPolylineElementType =
    //     abstract prototype: SVGPolylineElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPolylineElement

    // and [<AllowNullLiteral>] SVGPreserveAspectRatio =
    //     abstract align: float with get, set
    //     abstract meetOrSlice: float with get, set
    //     abstract SVG_MEETORSLICE_MEET: float with get, set
    //     abstract SVG_MEETORSLICE_SLICE: float with get, set
    //     abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set

    // and [<AllowNullLiteral>] SVGPreserveAspectRatioType =
    //     abstract prototype: SVGPreserveAspectRatio with get, set
    //     abstract SVG_MEETORSLICE_MEET: float with get, set
    //     abstract SVG_MEETORSLICE_SLICE: float with get, set
    //     abstract SVG_MEETORSLICE_UNKNOWN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_NONE: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_UNKNOWN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMAXYMAX: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMAXYMID: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMAXYMIN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMIDYMAX: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMIDYMID: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMIDYMIN: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMINYMAX: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMINYMID: float with get, set
    //     abstract SVG_PRESERVEASPECTRATIO_XMINYMIN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGPreserveAspectRatio

    // and [<AllowNullLiteral>] SVGRadialGradientElement =
    //     inherit SVGGradientElement
    //     abstract cx: SVGAnimatedLength with get, set
    //     abstract cy: SVGAnimatedLength with get, set
    //     abstract fx: SVGAnimatedLength with get, set
    //     abstract fy: SVGAnimatedLength with get, set
    //     abstract r: SVGAnimatedLength with get, set

    // and [<AllowNullLiteral>] SVGRadialGradientElementType =
    //     abstract prototype: SVGRadialGradientElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRadialGradientElement

    // and [<AllowNullLiteral>] SVGRect =
    //     abstract height: float with get, set
    //     abstract width: float with get, set
    //     abstract x: float with get, set
    //     abstract y: float with get, set

    // and [<AllowNullLiteral>] SVGRectType =
    //     abstract prototype: SVGRect with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRect

    // and [<AllowNullLiteral>] SVGRectElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract rx: SVGAnimatedLength with get, set
    //     abstract ry: SVGAnimatedLength with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGRectElementType =
    //     abstract prototype: SVGRectElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGRectElement

    // and [<AllowNullLiteral>] SVGSVGElement =
    //     inherit SVGElement
    //     inherit DocumentEvent
    //     inherit SVGLocatable
    //     inherit SVGTests
    //     inherit SVGStylable
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGFitToViewBox
    //     inherit SVGZoomAndPan
    //     abstract contentScriptType: string with get, set
    //     abstract contentStyleType: string with get, set
    //     abstract currentScale: float with get, set
    //     abstract currentTranslate: SVGPoint with get, set
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract onabort: (Event -> 'Out) with get, set
    //     abstract onerror: (Event -> 'Out) with get, set
    //     abstract onresize: (UIEvent -> 'Out) with get, set
    //     abstract onscroll: (UIEvent -> 'Out) with get, set
    //     abstract onunload: (Event -> 'Out) with get, set
    //     abstract onzoom: (SVGZoomEvent -> 'Out) with get, set
    //     abstract pixelUnitToMillimeterX: float with get, set
    //     abstract pixelUnitToMillimeterY: float with get, set
    //     abstract screenPixelToMillimeterX: float with get, set
    //     abstract screenPixelToMillimeterY: float with get, set
    //     abstract viewport: SVGRect with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract checkEnclosure: element: SVGElement * rect: SVGRect -> bool
    //     abstract checkIntersection: element: SVGElement * rect: SVGRect -> bool
    //     abstract createSVGAngle: unit -> SVGAngle
    //     abstract createSVGLength: unit -> SVGLength
    //     abstract createSVGMatrix: unit -> SVGMatrix
    //     abstract createSVGNumber: unit -> SVGNumber
    //     abstract createSVGPoint: unit -> SVGPoint
    //     abstract createSVGRect: unit -> SVGRect
    //     abstract createSVGTransform: unit -> SVGTransform
    //     abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    //     abstract deselectAll: unit -> unit
    //     abstract forceRedraw: unit -> unit
    //     // abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
    //     abstract getCurrentTime: unit -> float
    //     abstract getElementById: elementId: string -> Element
    //     abstract getEnclosureList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    //     abstract getIntersectionList: rect: SVGRect * referenceElement: SVGElement -> NodeList
    //     abstract pauseAnimations: unit -> unit
    //     abstract setCurrentTime: seconds: float -> unit
    //     abstract suspendRedraw: maxWaitMilliseconds: float -> float
    //     abstract unpauseAnimations: unit -> unit
    //     abstract unsuspendRedraw: suspendHandleID: float -> unit
    //     abstract unsuspendRedrawAll: unit -> unit
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGSVGElementType =
    //     abstract prototype: SVGSVGElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSVGElement

    // and [<AllowNullLiteral>] SVGScriptElement =
    //     inherit SVGElement
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGURIReference
    //     abstract ``type``: string with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGScriptElementType =
    //     abstract prototype: SVGScriptElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGScriptElement

    // and [<AllowNullLiteral>] SVGStopElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     abstract offset: SVGAnimatedNumber with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGStopElementType =
    //     abstract prototype: SVGStopElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStopElement

    // and [<AllowNullLiteral>] SVGStringList =
    //     abstract numberOfItems: float with get, set
    //     abstract appendItem: newItem: string -> string
    //     abstract clear: unit -> unit
    //     abstract getItem: index: float -> string
    //     abstract initialize: newItem: string -> string
    //     abstract insertItemBefore: newItem: string * index: float -> string
    //     abstract removeItem: index: float -> string
    //     abstract replaceItem: newItem: string * index: float -> string

    // and [<AllowNullLiteral>] SVGStringListType =
    //     abstract prototype: SVGStringList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStringList

    // and [<AllowNullLiteral>] SVGStyleElement =
    //     inherit SVGElement
    //     inherit SVGLangSpace
    //     abstract media: string with get, set
    //     abstract title: string with get, set
    //     abstract ``type``: string with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGStyleElementType =
    //     abstract prototype: SVGStyleElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGStyleElement

    // and [<AllowNullLiteral>] SVGSwitchElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGSwitchElementType =
    //     abstract prototype: SVGSwitchElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSwitchElement

    // and [<AllowNullLiteral>] SVGSymbolElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGFitToViewBox
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGSymbolElementType =
    //     abstract prototype: SVGSymbolElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGSymbolElement

    // and [<AllowNullLiteral>] SVGTSpanElement =
    //     inherit SVGTextPositioningElement


    // and [<AllowNullLiteral>] SVGTSpanElementType =
    //     abstract prototype: SVGTSpanElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTSpanElement

    // and [<AllowNullLiteral>] SVGTextContentElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     abstract lengthAdjust: SVGAnimatedEnumeration with get, set
    //     abstract textLength: SVGAnimatedLength with get, set
    //     abstract LENGTHADJUST_SPACING: float with get, set
    //     abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    //     abstract LENGTHADJUST_UNKNOWN: float with get, set
    //     abstract getCharNumAtPosition: point: SVGPoint -> float
    //     abstract getComputedTextLength: unit -> float
    //     abstract getEndPositionOfChar: charnum: float -> SVGPoint
    //     abstract getExtentOfChar: charnum: float -> SVGRect
    //     abstract getNumberOfChars: unit -> float
    //     abstract getRotationOfChar: charnum: float -> float
    //     abstract getStartPositionOfChar: charnum: float -> SVGPoint
    //     abstract getSubStringLength: charnum: float * nchars: float -> float
    //     abstract selectSubString: charnum: float * nchars: float -> unit
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGTextContentElementType =
    //     abstract prototype: SVGTextContentElement with get, set
    //     abstract LENGTHADJUST_SPACING: float with get, set
    //     abstract LENGTHADJUST_SPACINGANDGLYPHS: float with get, set
    //     abstract LENGTHADJUST_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextContentElement

    // and [<AllowNullLiteral>] SVGTextElement =
    //     inherit SVGTextPositioningElement
    //     inherit SVGTransformable
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGTextElementType =
    //     abstract prototype: SVGTextElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextElement

    // and [<AllowNullLiteral>] SVGTextPathElement =
    //     inherit SVGTextContentElement
    //     inherit SVGURIReference
    //     abstract ``method``: SVGAnimatedEnumeration with get, set
    //     abstract spacing: SVGAnimatedEnumeration with get, set
    //     abstract startOffset: SVGAnimatedLength with get, set
    //     abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    //     abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    //     abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    //     abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    //     abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    //     abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGTextPathElementType =
    //     abstract prototype: SVGTextPathElement with get, set
    //     abstract TEXTPATH_METHODTYPE_ALIGN: float with get, set
    //     abstract TEXTPATH_METHODTYPE_STRETCH: float with get, set
    //     abstract TEXTPATH_METHODTYPE_UNKNOWN: float with get, set
    //     abstract TEXTPATH_SPACINGTYPE_AUTO: float with get, set
    //     abstract TEXTPATH_SPACINGTYPE_EXACT: float with get, set
    //     abstract TEXTPATH_SPACINGTYPE_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextPathElement

    // and [<AllowNullLiteral>] SVGTextPositioningElement =
    //     inherit SVGTextContentElement
    //     abstract dx: SVGAnimatedLengthList with get, set
    //     abstract dy: SVGAnimatedLengthList with get, set
    //     abstract rotate: SVGAnimatedNumberList with get, set
    //     abstract x: SVGAnimatedLengthList with get, set
    //     abstract y: SVGAnimatedLengthList with get, set

    // and [<AllowNullLiteral>] SVGTextPositioningElementType =
    //     abstract prototype: SVGTextPositioningElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTextPositioningElement

    // and [<AllowNullLiteral>] SVGTitleElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGLangSpace
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGTitleElementType =
    //     abstract prototype: SVGTitleElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTitleElement

    // and [<AllowNullLiteral>] SVGTransform =
    //     abstract angle: float with get, set
    //     abstract matrix: SVGMatrix with get, set
    //     abstract ``type``: float with get, set
    //     abstract SVG_TRANSFORM_MATRIX: float with get, set
    //     abstract SVG_TRANSFORM_ROTATE: float with get, set
    //     abstract SVG_TRANSFORM_SCALE: float with get, set
    //     abstract SVG_TRANSFORM_SKEWX: float with get, set
    //     abstract SVG_TRANSFORM_SKEWY: float with get, set
    //     abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    //     abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    //     abstract setMatrix: matrix: SVGMatrix -> unit
    //     abstract setRotate: angle: float * cx: float * cy: float -> unit
    //     abstract setScale: sx: float * sy: float -> unit
    //     abstract setSkewX: angle: float -> unit
    //     abstract setSkewY: angle: float -> unit
    //     abstract setTranslate: tx: float * ty: float -> unit

    // and [<AllowNullLiteral>] SVGTransformType =
    //     abstract prototype: SVGTransform with get, set
    //     abstract SVG_TRANSFORM_MATRIX: float with get, set
    //     abstract SVG_TRANSFORM_ROTATE: float with get, set
    //     abstract SVG_TRANSFORM_SCALE: float with get, set
    //     abstract SVG_TRANSFORM_SKEWX: float with get, set
    //     abstract SVG_TRANSFORM_SKEWY: float with get, set
    //     abstract SVG_TRANSFORM_TRANSLATE: float with get, set
    //     abstract SVG_TRANSFORM_UNKNOWN: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTransform

    // and [<AllowNullLiteral>] SVGTransformList =
    //     abstract numberOfItems: float with get, set
    //     abstract appendItem: newItem: SVGTransform -> SVGTransform
    //     abstract clear: unit -> unit
    //     abstract consolidate: unit -> SVGTransform
    //     abstract createSVGTransformFromMatrix: matrix: SVGMatrix -> SVGTransform
    //     abstract getItem: index: float -> SVGTransform
    //     abstract initialize: newItem: SVGTransform -> SVGTransform
    //     abstract insertItemBefore: newItem: SVGTransform * index: float -> SVGTransform
    //     abstract removeItem: index: float -> SVGTransform
    //     abstract replaceItem: newItem: SVGTransform * index: float -> SVGTransform

    // and [<AllowNullLiteral>] SVGTransformListType =
    //     abstract prototype: SVGTransformList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGTransformList

    // and [<AllowNullLiteral>] SVGUnitTypes =
    //     abstract SVG_UNIT_TYPE_OBJECTBOUNDINGBOX: float with get, set
    //     abstract SVG_UNIT_TYPE_UNKNOWN: float with get, set
    //     abstract SVG_UNIT_TYPE_USERSPACEONUSE: float with get, set

    // and [<AllowNullLiteral>] SVGUseElement =
    //     inherit SVGElement
    //     inherit SVGStylable
    //     inherit SVGTransformable
    //     inherit SVGTests
    //     inherit SVGLangSpace
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGURIReference
    //     abstract animatedInstanceRoot: SVGElementInstance with get, set
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract instanceRoot: SVGElementInstance with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGUseElementType =
    //     abstract prototype: SVGUseElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGUseElement

    // and [<AllowNullLiteral>] SVGViewElement =
    //     inherit SVGElement
    //     inherit SVGExternalResourcesRequired
    //     inherit SVGFitToViewBox
    //     inherit SVGZoomAndPan
    //     abstract viewTarget: SVGStringList with get, set
    //     abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    // and [<AllowNullLiteral>] SVGViewElementType =
    //     abstract prototype: SVGViewElement with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGViewElement

    // and [<AllowNullLiteral>] SVGZoomAndPan =
    //     abstract zoomAndPan: float with get, set

    // and [<AllowNullLiteral>] SVGZoomAndPanType =
    //     abstract SVG_ZOOMANDPAN_DISABLE: float with get, set
    //     abstract SVG_ZOOMANDPAN_MAGNIFY: float with get, set
    //     abstract SVG_ZOOMANDPAN_UNKNOWN: float with get, set

    // and [<AllowNullLiteral>] SVGZoomEvent =
    //     inherit UIEvent
    //     abstract newScale: float with get, set
    //     abstract newTranslate: SVGPoint with get, set
    //     abstract previousScale: float with get, set
    //     abstract previousTranslate: SVGPoint with get, set
    //     abstract zoomRectScreen: SVGRect with get, set

    // and [<AllowNullLiteral>] SVGZoomEventType =
    //     abstract prototype: SVGZoomEvent with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> SVGZoomEvent

    and [<AllowNullLiteral>] Screen =
        inherit EventTarget
        abstract availHeight: float with get, set
        abstract availWidth: float with get, set
        abstract bufferDepth: float with get, set
        abstract colorDepth: float with get, set
        abstract deviceXDPI: float with get, set
        abstract deviceYDPI: float with get, set
        abstract fontSmoothingEnabled: bool with get, set
        abstract height: float with get, set
        abstract logicalXDPI: float with get, set
        abstract logicalYDPI: float with get, set
        abstract pixelDepth: float with get, set
        abstract systemXDPI: float with get, set
        abstract systemYDPI: float with get, set
        abstract width: float with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] ScreenType =
        abstract prototype: Screen with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Screen

    and [<AllowNullLiteral>] ScriptNotifyEvent =
        inherit Event
        abstract callingUri: string with get, set
        abstract value: string with get, set

    and [<AllowNullLiteral>] ScriptNotifyEventType =
        abstract prototype: ScriptNotifyEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ScriptNotifyEvent

    and [<AllowNullLiteral>] ScriptProcessorNode =
        inherit AudioNode
        abstract bufferSize: int with get
        abstract onaudioprocess: (AudioProcessingEvent -> 'Out) with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] ScriptProcessorNodeType =
        abstract prototype: ScriptProcessorNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ScriptProcessorNode

    and [<AllowNullLiteral>] Selection =
        abstract anchorNode: Node with get, set
        abstract anchorOffset: float with get, set
        abstract focusNode: Node with get, set
        abstract focusOffset: float with get, set
        abstract isCollapsed: bool with get, set
        abstract rangeCount: float with get, set
        abstract ``type``: string with get, set
        abstract addRange: range: Range -> unit
        abstract collapse: parentNode: Node * offset: float -> unit
        abstract collapseToEnd: unit -> unit
        abstract collapseToStart: unit -> unit
        abstract containsNode: node: Node * partlyContained: bool -> bool
        abstract deleteFromDocument: unit -> unit
        abstract empty: unit -> unit
        abstract extend: newNode: Node * offset: float -> unit
        abstract getRangeAt: index: float -> Range
        abstract removeAllRanges: unit -> unit
        abstract removeRange: range: Range -> unit
        abstract selectAllChildren: parentNode: Node -> unit
        abstract setBaseAndExtent: baseNode: Node * baseOffset: float * extentNode: Node * extentOffset: float -> unit
        abstract toString: unit -> string

    and [<AllowNullLiteral>] SelectionType =
        abstract prototype: Selection with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Selection

    and [<AllowNullLiteral>] SourceBuffer =
        inherit EventTarget
        abstract appendWindowEnd: float with get, set
        abstract appendWindowStart: float with get, set
        abstract audioTracks: AudioTrackList with get, set
        abstract buffered: TimeRanges with get, set
        abstract mode: string with get, set
        abstract timestampOffset: float with get, set
        abstract updating: bool with get, set
        abstract videoTracks: VideoTrackList with get, set
        abstract abort: unit -> unit
        abstract appendBuffer: data: U2<ArrayBuffer, ArrayBufferView> -> unit
        abstract remove: start: float * ``end``: float -> unit

    and [<AllowNullLiteral>] SourceBufferType =
        abstract prototype: SourceBuffer with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> SourceBuffer

    and [<AllowNullLiteral>] SourceBufferList =
        inherit EventTarget
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> SourceBuffer with get, set
        abstract item: index: float -> SourceBuffer

    and [<AllowNullLiteral>] SourceBufferListType =
        abstract prototype: SourceBufferList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> SourceBufferList

    and [<AllowNullLiteral>] SpatialListener =
        abstract positionX: AudioParam with get
        abstract positionY: AudioParam with get
        abstract positionZ: AudioParam with get
        abstract forwardX: AudioParam with get
        abstract forwardY: AudioParam with get
        abstract forwardZ: AudioParam with get
        abstract upX: AudioParam with get
        abstract upY: AudioParam with get
        abstract upZ: AudioParam with get

    and [<AllowNullLiteral>] SpatialListenerType =
        abstract prototype: SpatialListener with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> SpatialListener

    and [<AllowNullLiteral>] SpatialPannerNode =
        inherit AudioNode
        abstract panningModel: PanningModelType with get,set
        abstract positionX: AudioParam with get
        abstract positionY: AudioParam with get
        abstract positionZ: AudioParam with get
        abstract orientationX: AudioParam with get
        abstract orientationY: AudioParam with get
        abstract orientationZ: AudioParam with get
        abstract distanceModel: DistanceModelType with get, set
        abstract refDistance: float with get, set
        abstract maxDistance: float with get, set
        abstract rolloffFactor: float with get, set
        abstract coneInnerAngle: float with get, set
        abstract coneOuterAngle: float with get, set
        abstract coneOuterGain: float with get, set

    and [<AllowNullLiteral>] SpatialPannerNodeType =
        abstract prototype: SpatialPannerNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> SpatialPannerNode

     and [<AllowNullLiteral>] StereoPannerNode =
        inherit AudioNode
        abstract pan: AudioParam with get, set

    and [<AllowNullLiteral>] StereoPannerNodeType =
        abstract prototype: StereoPannerNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> StereoPannerNode

    and [<AllowNullLiteral>] Storage =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> obj with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> string with get, set
        abstract clear: unit -> unit
        abstract getItem: key: string -> obj
        abstract key: index: float -> string
        abstract removeItem: key: string -> unit
        abstract setItem: key: string * data: string -> unit

    and [<AllowNullLiteral>] StorageType =
        abstract prototype: Storage with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Storage

    and [<AllowNullLiteral>] StorageEvent =
        inherit Event
        abstract url: string with get, set
        abstract key: string option with get, set
        abstract oldValue: string option with get, set
        abstract newValue: string option with get, set
        abstract storageArea: Storage option with get, set

    and [<AllowNullLiteral>] StorageEventType =
        abstract prototype: StorageEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: StorageEventInit -> StorageEvent

    and [<AllowNullLiteral>] StyleMedia =
        abstract ``type``: string with get, set
        abstract matchMedium: mediaquery: string -> bool

    and [<AllowNullLiteral>] StyleMediaType =
        abstract prototype: StyleMedia with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> StyleMedia

    // and [<AllowNullLiteral>] StyleSheet =
    //     abstract disabled: bool with get, set
    //     abstract href: string with get, set
    //     abstract media: MediaList with get, set
    //     abstract ownerNode: Node with get, set
    //     abstract parentStyleSheet: StyleSheet with get, set
    //     abstract title: string with get, set
    //     abstract ``type``: string with get, set

    // and [<AllowNullLiteral>] StyleSheetType =
    //     abstract prototype: StyleSheet with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheet

    // and [<AllowNullLiteral>] StyleSheetList =
    //     abstract length: float with get, set
    //     [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> StyleSheet with get, set
    //     abstract item: ?index: float -> StyleSheet

    // and [<AllowNullLiteral>] StyleSheetListType =
    //     abstract prototype: StyleSheetList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheetList

    // and [<AllowNullLiteral>] StyleSheetPageList =
    //     abstract length: float with get, set
    //     [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> CSSPageRule with get, set
    //     abstract item: index: float -> CSSPageRule

    // and [<AllowNullLiteral>] StyleSheetPageListType =
    //     abstract prototype: StyleSheetPageList with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> StyleSheetPageList

    // and [<AllowNullLiteral>] LinkStyle =
    //     abstract sheet: StyleSheet with get, set

    and [<AllowNullLiteral>] SubtleCrypto =
        abstract decrypt: algorithm: U2<string, Algorithm> * key: CryptoKey * data: ArrayBufferView -> obj
        abstract deriveBits: algorithm: U2<string, Algorithm> * baseKey: CryptoKey * length: float -> obj
        abstract deriveKey: algorithm: U2<string, Algorithm> * baseKey: CryptoKey * derivedKeyType: U2<string, Algorithm> * extractable: bool * keyUsages: ResizeArray<string> -> obj
        abstract digest: algorithm: U2<string, Algorithm> * data: ArrayBufferView -> obj
        abstract encrypt: algorithm: U2<string, Algorithm> * key: CryptoKey * data: ArrayBufferView -> obj
        abstract exportKey: format: string * key: CryptoKey -> obj
        abstract generateKey: algorithm: U2<string, Algorithm> * extractable: bool * keyUsages: ResizeArray<string> -> obj
        abstract importKey: format: string * keyData: ArrayBufferView * algorithm: U2<string, Algorithm> * extractable: bool * keyUsages: ResizeArray<string> -> obj
        abstract sign: algorithm: U2<string, Algorithm> * key: CryptoKey * data: ArrayBufferView -> obj
        abstract unwrapKey: format: string * wrappedKey: ArrayBufferView * unwrappingKey: CryptoKey * unwrapAlgorithm: U2<string, Algorithm> * unwrappedKeyAlgorithm: U2<string, Algorithm> * extractable: bool * keyUsages: ResizeArray<string> -> obj
        abstract verify: algorithm: U2<string, Algorithm> * key: CryptoKey * signature: ArrayBufferView * data: ArrayBufferView -> obj
        abstract wrapKey: format: string * key: CryptoKey * wrappingKey: CryptoKey * wrapAlgorithm: U2<string, Algorithm> -> obj

    and [<AllowNullLiteral>] SubtleCryptoType =
        abstract prototype: SubtleCrypto with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> SubtleCrypto

    and [<AllowNullLiteral>] SyncEvent =
        inherit Event
        abstract lastChance: bool with get, set
        abstract tag: string with get, set

    and [<AllowNullLiteral>] Text =
        inherit CharacterData
        abstract wholeText: string with get, set
        abstract replaceWholeText: content: string -> Text
        abstract splitText: offset: float -> Text

    and [<AllowNullLiteral>] TextType =
        abstract prototype: Text with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Text

    and [<AllowNullLiteral>] TextEvent =
        inherit UIEvent
        abstract data: string with get, set
        abstract inputMethod: float with get, set
        abstract locale: string with get, set
        abstract DOM_INPUT_METHOD_DROP: float with get, set
        abstract DOM_INPUT_METHOD_HANDWRITING: float with get, set
        abstract DOM_INPUT_METHOD_IME: float with get, set
        abstract DOM_INPUT_METHOD_KEYBOARD: float with get, set
        abstract DOM_INPUT_METHOD_MULTIMODAL: float with get, set
        abstract DOM_INPUT_METHOD_OPTION: float with get, set
        abstract DOM_INPUT_METHOD_PASTE: float with get, set
        abstract DOM_INPUT_METHOD_SCRIPT: float with get, set
        abstract DOM_INPUT_METHOD_UNKNOWN: float with get, set
        abstract DOM_INPUT_METHOD_VOICE: float with get, set
        abstract initTextEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * dataArg: string * inputMethod: float * locale: string -> unit

    and [<AllowNullLiteral>] TextEventType =
        abstract prototype: TextEvent with get, set
        abstract DOM_INPUT_METHOD_DROP: float with get, set
        abstract DOM_INPUT_METHOD_HANDWRITING: float with get, set
        abstract DOM_INPUT_METHOD_IME: float with get, set
        abstract DOM_INPUT_METHOD_KEYBOARD: float with get, set
        abstract DOM_INPUT_METHOD_MULTIMODAL: float with get, set
        abstract DOM_INPUT_METHOD_OPTION: float with get, set
        abstract DOM_INPUT_METHOD_PASTE: float with get, set
        abstract DOM_INPUT_METHOD_SCRIPT: float with get, set
        abstract DOM_INPUT_METHOD_UNKNOWN: float with get, set
        abstract DOM_INPUT_METHOD_VOICE: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextEvent

    and [<AllowNullLiteral>] TextMetrics =
        abstract width: float with get, set

    and [<AllowNullLiteral>] TextMetricsType =
        abstract prototype: TextMetrics with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextMetrics

    and [<AllowNullLiteral>] TextRange =
        abstract boundingHeight: float with get, set
        abstract boundingLeft: float with get, set
        abstract boundingTop: float with get, set
        abstract boundingWidth: float with get, set
        abstract htmlText: string with get, set
        abstract offsetLeft: float with get, set
        abstract offsetTop: float with get, set
        abstract text: string with get, set
        abstract collapse: ?start: bool -> unit
        abstract compareEndPoints: how: string * sourceRange: TextRange -> float
        abstract duplicate: unit -> TextRange
        abstract execCommand: cmdID: string * ?showUI: bool * ?value: obj -> bool
        abstract execCommandShowHelp: cmdID: string -> bool
        abstract expand: Unit: string -> bool
        abstract findText: string: string * ?count: float * ?flags: float -> bool
        abstract getBookmark: unit -> string
        abstract getBoundingClientRect: unit -> ClientRect
        abstract getClientRects: unit -> ClientRectList
        abstract inRange: range: TextRange -> bool
        abstract isEqual: range: TextRange -> bool
        abstract move: unit: string * ?count: float -> float
        abstract moveEnd: unit: string * ?count: float -> float
        abstract moveStart: unit: string * ?count: float -> float
        abstract moveToBookmark: bookmark: string -> bool
        abstract moveToElementText: element: Element -> unit
        abstract moveToPoint: x: float * y: float -> unit
        abstract parentElement: unit -> Element
        abstract pasteHTML: html: string -> unit
        abstract queryCommandEnabled: cmdID: string -> bool
        abstract queryCommandIndeterm: cmdID: string -> bool
        abstract queryCommandState: cmdID: string -> bool
        abstract queryCommandSupported: cmdID: string -> bool
        abstract queryCommandText: cmdID: string -> string
        abstract queryCommandValue: cmdID: string -> obj
        abstract scrollIntoView: ?fStart: bool -> unit
        abstract select: unit -> unit
        abstract setEndPoint: how: string * SourceRange: TextRange -> unit

    and [<AllowNullLiteral>] TextRangeType =
        abstract prototype: TextRange with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextRange

    and [<AllowNullLiteral>] TextRangeCollection =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextRange with get, set
        abstract item: index: float -> TextRange

    and [<AllowNullLiteral>] TextRangeCollectionType =
        abstract prototype: TextRangeCollection with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextRangeCollection

    and [<AllowNullLiteral>] TextTrack =
        inherit EventTarget
        abstract activeCues: TextTrackCueList with get, set
        abstract cues: TextTrackCueList with get, set
        abstract inBandMetadataTrackDispatchType: string with get, set
        abstract kind: string with get, set
        abstract label: string with get, set
        abstract language: string with get, set
        abstract mode: obj with get, set
        abstract oncuechange: (Event -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract readyState: float with get, set
        abstract DISABLED: float with get, set
        abstract ERROR: float with get, set
        abstract HIDDEN: float with get, set
        abstract LOADED: float with get, set
        abstract LOADING: float with get, set
        abstract NONE: float with get, set
        abstract SHOWING: float with get, set
        abstract addCue: cue: TextTrackCue -> unit
        abstract removeCue: cue: TextTrackCue -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] TextTrackType =
        abstract prototype: TextTrack with get, set
        abstract DISABLED: float with get, set
        abstract ERROR: float with get, set
        abstract HIDDEN: float with get, set
        abstract LOADED: float with get, set
        abstract LOADING: float with get, set
        abstract NONE: float with get, set
        abstract SHOWING: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrack

    and [<AllowNullLiteral>] TextTrackCue =
        inherit EventTarget
        abstract endTime: float with get, set
        abstract id: string with get, set
        abstract onenter: (Event -> 'Out) with get, set
        abstract onexit: (Event -> 'Out) with get, set
        abstract pauseOnExit: bool with get, set
        abstract startTime: float with get, set
        abstract text: string with get, set
        abstract track: TextTrack with get, set
        abstract getCueAsHTML: unit -> DocumentFragment
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] TextTrackCueType =
        abstract prototype: TextTrackCue with get, set
        [<Emit("new $0($1...)")>] abstract Create: startTime: float * endTime: float * text: string -> TextTrackCue

    and [<AllowNullLiteral>] TextTrackCueList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextTrackCue with get, set
        abstract getCueById: id: string -> TextTrackCue
        abstract item: index: float -> TextTrackCue

    and [<AllowNullLiteral>] TextTrackCueListType =
        abstract prototype: TextTrackCueList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrackCueList

    and [<AllowNullLiteral>] TextTrackList =
        inherit EventTarget
        abstract length: float with get, set
        abstract onaddtrack: (TrackEvent -> 'Out) with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> TextTrack with get, set
        abstract item: index: float -> TextTrack
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] TextTrackListType =
        abstract prototype: TextTrackList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TextTrackList

    and [<AllowNullLiteral>] TimeRanges =
        abstract length: float with get, set
        abstract ``end``: index: float -> float
        abstract start: index: float -> float

    and [<AllowNullLiteral>] TimeRangesType =
        abstract prototype: TimeRanges with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TimeRanges

    and [<AllowNullLiteral>] Touch =
        abstract clientX: float with get, set
        abstract clientY: float with get, set
        abstract identifier: float with get, set
        abstract pageX: float with get, set
        abstract pageY: float with get, set
        abstract screenX: float with get, set
        abstract screenY: float with get, set
        abstract target: EventTarget with get, set

    and [<AllowNullLiteral>] TouchType =
        abstract prototype: Touch with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Touch

    and [<AllowNullLiteral>] TouchEvent =
        inherit UIEvent
        abstract altKey: bool with get, set
        abstract changedTouches: TouchList with get, set
        abstract ctrlKey: bool with get, set
        abstract metaKey: bool with get, set
        abstract shiftKey: bool with get, set
        abstract targetTouches: TouchList with get, set
        abstract touches: TouchList with get, set

    and [<AllowNullLiteral>] TouchEventType =
        abstract prototype: TouchEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TouchEvent

    and [<AllowNullLiteral>] TouchList =
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Touch with get, set
        abstract item: index: float -> Touch

    and [<AllowNullLiteral>] TouchListType =
        abstract prototype: TouchList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TouchList

    and [<AllowNullLiteral>] TrackEvent =
        inherit Event
        abstract track: obj with get, set

    and [<AllowNullLiteral>] TrackEventType =
        abstract prototype: TrackEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TrackEvent

    and [<AllowNullLiteral>] TransitionEvent =
        inherit Event
        abstract elapsedTime: float with get, set
        abstract propertyName: string with get, set
        abstract initTransitionEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * propertyNameArg: string * elapsedTimeArg: float -> unit

    and [<AllowNullLiteral>] TransitionEventType =
        abstract prototype: TransitionEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TransitionEvent

    and [<AllowNullLiteral>] TreeWalker =
        abstract currentNode: Node with get, set
        abstract expandEntityReferences: bool with get, set
        abstract filter: NodeFilter with get, set
        abstract root: Node with get, set
        abstract whatToShow: float with get, set
        abstract firstChild: unit -> Node
        abstract lastChild: unit -> Node
        abstract nextNode: unit -> Node
        abstract nextSibling: unit -> Node
        abstract parentNode: unit -> Node
        abstract previousNode: unit -> Node
        abstract previousSibling: unit -> Node

    and [<AllowNullLiteral>] TreeWalkerType =
        abstract prototype: TreeWalker with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> TreeWalker

    and [<AllowNullLiteral>] UIEvent =
        inherit Event
        abstract detail: float with get, set
        abstract view: Window with get, set
        abstract initUIEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float -> unit

    and [<AllowNullLiteral>] UIEventType =
        abstract prototype: UIEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: ``type``: string * ?eventInitDict: UIEventInit -> UIEvent

    and [<AllowNullLiteral>] URL =
        abstract hash: string with get, set
        abstract host: string with get, set
        abstract hostname: string with get, set
        abstract href: string with get, set
        abstract origin: string
        abstract password: string with get, set
        abstract pathname: string with get, set
        abstract port: string with get, set
        abstract protocol: string with get, set
        abstract search: string with get, set
        abstract username: string with get, set
        abstract searchParams: URLSearchParams
        abstract toString: unit -> string

    and [<AllowNullLiteral>] URLType =
        abstract prototype: URL with get, set
        [<Emit("new $0($1...)")>] abstract Create: url: string -> URL

    and [<AllowNullLiteral>] URLSearchParams =
        /// Appends a specified key/value pair as a new search parameter.
        abstract append: name: string * value: string -> unit
        /// Deletes the given search parameter, and its associated value, from the list of all search parameters.
        abstract delete: name: string -> unit
        /// Returns the first value associated to the given search parameter.
        abstract get: name: string -> string option
        /// Returns all the values association with a given search parameter.
        abstract getAll: name: string -> ResizeArray<string>
        /// Returns a Boolean indicating if such a search parameter exists.
        abstract has: name: string -> bool
        /// Sets the value associated to a given search parameter to the given value. If there were several values, delete the others.
        abstract set: name: string * value: string -> unit

    and [<AllowNullLiteral>] URLSearchParamsType =
        abstract prototype: URLSearchParams with get, set
        [<Emit("new $0($1...)")>] abstract Create: arg: obj -> URLSearchParams

    and [<AllowNullLiteral>] UnviewableContentIdentifiedEvent =
        inherit NavigationEventWithReferrer
        abstract mediaType: string with get, set

    and [<AllowNullLiteral>] UnviewableContentIdentifiedEventType =
        abstract prototype: UnviewableContentIdentifiedEvent with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> UnviewableContentIdentifiedEvent

    and [<AllowNullLiteral>] ValidityState =
        abstract badInput: bool with get, set
        abstract customError: bool with get, set
        abstract patternMismatch: bool with get, set
        abstract rangeOverflow: bool with get, set
        abstract rangeUnderflow: bool with get, set
        abstract stepMismatch: bool with get, set
        abstract tooLong: bool with get, set
        abstract tooShort: bool with get, set
        abstract typeMismatch: bool with get, set
        abstract valid: bool with get, set
        abstract valueMissing: bool with get, set

    and [<AllowNullLiteral>] ValidityStateType =
        abstract prototype: ValidityState with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> ValidityState

    and [<AllowNullLiteral>] VideoPlaybackQuality =
        abstract corruptedVideoFrames: float with get, set
        abstract creationTime: float with get, set
        abstract droppedVideoFrames: float with get, set
        abstract totalFrameDelay: float with get, set
        abstract totalVideoFrames: float with get, set

    and [<AllowNullLiteral>] VideoPlaybackQualityType =
        abstract prototype: VideoPlaybackQuality with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> VideoPlaybackQuality

    and [<AllowNullLiteral>] VideoTrack =
        abstract id: string with get, set
        abstract kind: string with get, set
        abstract label: string with get, set
        abstract language: string with get, set
        abstract selected: bool with get, set
        abstract sourceBuffer: SourceBuffer with get, set

    and [<AllowNullLiteral>] VideoTrackType =
        abstract prototype: VideoTrack with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> VideoTrack

    and [<AllowNullLiteral>] VideoTrackList =
        inherit EventTarget
        abstract length: float with get, set
        abstract onaddtrack: (TrackEvent -> 'Out) with get, set
        abstract onchange: (Event -> 'Out) with get, set
        abstract onremovetrack: (TrackEvent -> 'Out) with get, set
        abstract selectedIndex: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> VideoTrack with get, set
        abstract getTrackById: id: string -> VideoTrack
        abstract item: index: float -> VideoTrack
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] VideoTrackListType =
        abstract prototype: VideoTrackList with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> VideoTrackList

    and [<AllowNullLiteral>] WaveShaperNode =
        inherit AudioNode
        abstract curve: Float32Array with get, set
        abstract oversample: OverSampleType with get, set

    and [<AllowNullLiteral>] WaveShaperNodeType =
        abstract prototype: WaveShaperNode with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> WaveShaperNode

    // and [<AllowNullLiteral>] WEBGL_compressed_texture_s3tc =
    //     abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: float with get, set
    //     abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: float with get, set
    //     abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: float with get, set
    //     abstract COMPRESSED_RGB_S3TC_DXT1_EXT: float with get, set

    // and [<AllowNullLiteral>] WEBGL_compressed_texture_s3tcType =
    //     abstract prototype: WEBGL_compressed_texture_s3tc with get, set
    //     abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: float with get, set
    //     abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: float with get, set
    //     abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: float with get, set
    //     abstract COMPRESSED_RGB_S3TC_DXT1_EXT: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_compressed_texture_s3tc

    // and [<AllowNullLiteral>] WEBGL_debug_renderer_info =
    //     abstract UNMASKED_RENDERER_WEBGL: float with get, set
    //     abstract UNMASKED_VENDOR_WEBGL: float with get, set

    // and [<AllowNullLiteral>] WEBGL_debug_renderer_infoType =
    //     abstract prototype: WEBGL_debug_renderer_info with get, set
    //     abstract UNMASKED_RENDERER_WEBGL: float with get, set
    //     abstract UNMASKED_VENDOR_WEBGL: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_debug_renderer_info

    // and [<AllowNullLiteral>] WEBGL_depth_texture =
    //     abstract UNSIGNED_INT_24_8_WEBGL: float with get, set

    // and [<AllowNullLiteral>] WEBGL_depth_textureType =
    //     abstract prototype: WEBGL_depth_texture with get, set
    //     abstract UNSIGNED_INT_24_8_WEBGL: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_depth_texture

    // and [<AllowNullLiteral>] WebGLActiveInfo =
    //     abstract name: string with get, set
    //     abstract size: float with get, set
    //     abstract ``type``: float with get, set

    // and [<AllowNullLiteral>] WebGLActiveInfoType =
    //     abstract prototype: WebGLActiveInfo with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLActiveInfo

    // and [<AllowNullLiteral>] WebGLBuffer =
    //     inherit WebGLObject


    // and [<AllowNullLiteral>] WebGLBufferType =
    //     abstract prototype: WebGLBuffer with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLBuffer

    // and [<AllowNullLiteral>] WebGLContextEvent =
    //     inherit Event
    //     abstract statusMessage: string with get, set

    // and [<AllowNullLiteral>] WebGLContextEventType =
    //     abstract prototype: WebGLContextEvent with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLContextEvent

    // and [<AllowNullLiteral>] WebGLFramebuffer =
    //     inherit WebGLObject


    // and [<AllowNullLiteral>] WebGLFramebufferType =
    //     abstract prototype: WebGLFramebuffer with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLFramebuffer

    // and [<AllowNullLiteral>] WebGLObject =
    //     interface end

    // and [<AllowNullLiteral>] WebGLObjectType =
    //     abstract prototype: WebGLObject with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLObject

    // and [<AllowNullLiteral>] WebGLProgram =
    //     inherit WebGLObject

    // and [<AllowNullLiteral>] WebGLProgramType =
    //     abstract prototype: WebGLProgram with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLProgram

    // and [<AllowNullLiteral>] WebGLRenderbuffer =
    //     inherit WebGLObject

    // and [<AllowNullLiteral>] WebGLRenderbufferType =
    //     abstract prototype: WebGLRenderbuffer with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLRenderbuffer

    // and [<AllowNullLiteral>] WebGLRenderingContext =
    //     abstract canvas: HTMLCanvasElement with get, set
    //     abstract drawingBufferHeight: float with get, set
    //     abstract drawingBufferWidth: float with get, set
    //     abstract ACTIVE_ATTRIBUTES: float with get, set
    //     abstract ACTIVE_TEXTURE: float with get, set
    //     abstract ACTIVE_UNIFORMS: float with get, set
    //     abstract ALIASED_LINE_WIDTH_RANGE: float with get, set
    //     abstract ALIASED_POINT_SIZE_RANGE: float with get, set
    //     abstract ALPHA: float with get, set
    //     abstract ALPHA_BITS: float with get, set
    //     abstract ALWAYS: float with get, set
    //     abstract ARRAY_BUFFER: float with get, set
    //     abstract ARRAY_BUFFER_BINDING: float with get, set
    //     abstract ATTACHED_SHADERS: float with get, set
    //     abstract BACK: float with get, set
    //     abstract BLEND: float with get, set
    //     abstract BLEND_COLOR: float with get, set
    //     abstract BLEND_DST_ALPHA: float with get, set
    //     abstract BLEND_DST_RGB: float with get, set
    //     abstract BLEND_EQUATION: float with get, set
    //     abstract BLEND_EQUATION_ALPHA: float with get, set
    //     abstract BLEND_EQUATION_RGB: float with get, set
    //     abstract BLEND_SRC_ALPHA: float with get, set
    //     abstract BLEND_SRC_RGB: float with get, set
    //     abstract BLUE_BITS: float with get, set
    //     abstract BOOL: float with get, set
    //     abstract BOOL_VEC2: float with get, set
    //     abstract BOOL_VEC3: float with get, set
    //     abstract BOOL_VEC4: float with get, set
    //     abstract BROWSER_DEFAULT_WEBGL: float with get, set
    //     abstract BUFFER_SIZE: float with get, set
    //     abstract BUFFER_USAGE: float with get, set
    //     abstract BYTE: float with get, set
    //     abstract CCW: float with get, set
    //     abstract CLAMP_TO_EDGE: float with get, set
    //     abstract COLOR_ATTACHMENT0: float with get, set
    //     abstract COLOR_BUFFER_BIT: float with get, set
    //     abstract COLOR_CLEAR_VALUE: float with get, set
    //     abstract COLOR_WRITEMASK: float with get, set
    //     abstract COMPILE_STATUS: float with get, set
    //     abstract COMPRESSED_TEXTURE_FORMATS: float with get, set
    //     abstract CONSTANT_ALPHA: float with get, set
    //     abstract CONSTANT_COLOR: float with get, set
    //     abstract CONTEXT_LOST_WEBGL: float with get, set
    //     abstract CULL_FACE: float with get, set
    //     abstract CULL_FACE_MODE: float with get, set
    //     abstract CURRENT_PROGRAM: float with get, set
    //     abstract CURRENT_VERTEX_ATTRIB: float with get, set
    //     abstract CW: float with get, set
    //     abstract DECR: float with get, set
    //     abstract DECR_WRAP: float with get, set
    //     abstract DELETE_STATUS: float with get, set
    //     abstract DEPTH_ATTACHMENT: float with get, set
    //     abstract DEPTH_BITS: float with get, set
    //     abstract DEPTH_BUFFER_BIT: float with get, set
    //     abstract DEPTH_CLEAR_VALUE: float with get, set
    //     abstract DEPTH_COMPONENT: float with get, set
    //     abstract DEPTH_COMPONENT16: float with get, set
    //     abstract DEPTH_FUNC: float with get, set
    //     abstract DEPTH_RANGE: float with get, set
    //     abstract DEPTH_STENCIL: float with get, set
    //     abstract DEPTH_STENCIL_ATTACHMENT: float with get, set
    //     abstract DEPTH_TEST: float with get, set
    //     abstract DEPTH_WRITEMASK: float with get, set
    //     abstract DITHER: float with get, set
    //     abstract DONT_CARE: float with get, set
    //     abstract DST_ALPHA: float with get, set
    //     abstract DST_COLOR: float with get, set
    //     abstract DYNAMIC_DRAW: float with get, set
    //     abstract ELEMENT_ARRAY_BUFFER: float with get, set
    //     abstract ELEMENT_ARRAY_BUFFER_BINDING: float with get, set
    //     abstract EQUAL: float with get, set
    //     abstract FASTEST: float with get, set
    //     abstract FLOAT: float with get, set
    //     abstract FLOAT_MAT2: float with get, set
    //     abstract FLOAT_MAT3: float with get, set
    //     abstract FLOAT_MAT4: float with get, set
    //     abstract FLOAT_VEC2: float with get, set
    //     abstract FLOAT_VEC3: float with get, set
    //     abstract FLOAT_VEC4: float with get, set
    //     abstract FRAGMENT_SHADER: float with get, set
    //     abstract FRAMEBUFFER: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: float with get, set
    //     abstract FRAMEBUFFER_BINDING: float with get, set
    //     abstract FRAMEBUFFER_COMPLETE: float with get, set
    //     abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: float with get, set
    //     abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: float with get, set
    //     abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: float with get, set
    //     abstract FRAMEBUFFER_UNSUPPORTED: float with get, set
    //     abstract FRONT: float with get, set
    //     abstract FRONT_AND_BACK: float with get, set
    //     abstract FRONT_FACE: float with get, set
    //     abstract FUNC_ADD: float with get, set
    //     abstract FUNC_REVERSE_SUBTRACT: float with get, set
    //     abstract FUNC_SUBTRACT: float with get, set
    //     abstract GENERATE_MIPMAP_HINT: float with get, set
    //     abstract GEQUAL: float with get, set
    //     abstract GREATER: float with get, set
    //     abstract GREEN_BITS: float with get, set
    //     abstract HIGH_FLOAT: float with get, set
    //     abstract HIGH_INT: float with get, set
    //     abstract IMPLEMENTATION_COLOR_READ_FORMAT: float with get, set
    //     abstract IMPLEMENTATION_COLOR_READ_TYPE: float with get, set
    //     abstract INCR: float with get, set
    //     abstract INCR_WRAP: float with get, set
    //     abstract INT: float with get, set
    //     abstract INT_VEC2: float with get, set
    //     abstract INT_VEC3: float with get, set
    //     abstract INT_VEC4: float with get, set
    //     abstract INVALID_ENUM: float with get, set
    //     abstract INVALID_FRAMEBUFFER_OPERATION: float with get, set
    //     abstract INVALID_OPERATION: float with get, set
    //     abstract INVALID_VALUE: float with get, set
    //     abstract INVERT: float with get, set
    //     abstract KEEP: float with get, set
    //     abstract LEQUAL: float with get, set
    //     abstract LESS: float with get, set
    //     abstract LINEAR: float with get, set
    //     abstract LINEAR_MIPMAP_LINEAR: float with get, set
    //     abstract LINEAR_MIPMAP_NEAREST: float with get, set
    //     abstract LINES: float with get, set
    //     abstract LINE_LOOP: float with get, set
    //     abstract LINE_STRIP: float with get, set
    //     abstract LINE_WIDTH: float with get, set
    //     abstract LINK_STATUS: float with get, set
    //     abstract LOW_FLOAT: float with get, set
    //     abstract LOW_INT: float with get, set
    //     abstract LUMINANCE: float with get, set
    //     abstract LUMINANCE_ALPHA: float with get, set
    //     abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: float with get, set
    //     abstract MAX_CUBE_MAP_TEXTURE_SIZE: float with get, set
    //     abstract MAX_FRAGMENT_UNIFORM_VECTORS: float with get, set
    //     abstract MAX_RENDERBUFFER_SIZE: float with get, set
    //     abstract MAX_TEXTURE_IMAGE_UNITS: float with get, set
    //     abstract MAX_TEXTURE_SIZE: float with get, set
    //     abstract MAX_VARYING_VECTORS: float with get, set
    //     abstract MAX_VERTEX_ATTRIBS: float with get, set
    //     abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: float with get, set
    //     abstract MAX_VERTEX_UNIFORM_VECTORS: float with get, set
    //     abstract MAX_VIEWPORT_DIMS: float with get, set
    //     abstract MEDIUM_FLOAT: float with get, set
    //     abstract MEDIUM_INT: float with get, set
    //     abstract MIRRORED_REPEAT: float with get, set
    //     abstract NEAREST: float with get, set
    //     abstract NEAREST_MIPMAP_LINEAR: float with get, set
    //     abstract NEAREST_MIPMAP_NEAREST: float with get, set
    //     abstract NEVER: float with get, set
    //     abstract NICEST: float with get, set
    //     abstract NONE: float with get, set
    //     abstract NOTEQUAL: float with get, set
    //     abstract NO_ERROR: float with get, set
    //     abstract ONE: float with get, set
    //     abstract ONE_MINUS_CONSTANT_ALPHA: float with get, set
    //     abstract ONE_MINUS_CONSTANT_COLOR: float with get, set
    //     abstract ONE_MINUS_DST_ALPHA: float with get, set
    //     abstract ONE_MINUS_DST_COLOR: float with get, set
    //     abstract ONE_MINUS_SRC_ALPHA: float with get, set
    //     abstract ONE_MINUS_SRC_COLOR: float with get, set
    //     abstract OUT_OF_MEMORY: float with get, set
    //     abstract PACK_ALIGNMENT: float with get, set
    //     abstract POINTS: float with get, set
    //     abstract POLYGON_OFFSET_FACTOR: float with get, set
    //     abstract POLYGON_OFFSET_FILL: float with get, set
    //     abstract POLYGON_OFFSET_UNITS: float with get, set
    //     abstract RED_BITS: float with get, set
    //     abstract RENDERBUFFER: float with get, set
    //     abstract RENDERBUFFER_ALPHA_SIZE: float with get, set
    //     abstract RENDERBUFFER_BINDING: float with get, set
    //     abstract RENDERBUFFER_BLUE_SIZE: float with get, set
    //     abstract RENDERBUFFER_DEPTH_SIZE: float with get, set
    //     abstract RENDERBUFFER_GREEN_SIZE: float with get, set
    //     abstract RENDERBUFFER_HEIGHT: float with get, set
    //     abstract RENDERBUFFER_INTERNAL_FORMAT: float with get, set
    //     abstract RENDERBUFFER_RED_SIZE: float with get, set
    //     abstract RENDERBUFFER_STENCIL_SIZE: float with get, set
    //     abstract RENDERBUFFER_WIDTH: float with get, set
    //     abstract RENDERER: float with get, set
    //     abstract REPEAT: float with get, set
    //     abstract REPLACE: float with get, set
    //     abstract RGB: float with get, set
    //     abstract RGB565: float with get, set
    //     abstract RGB5_A1: float with get, set
    //     abstract RGBA: float with get, set
    //     abstract RGBA4: float with get, set
    //     abstract SAMPLER_2D: float with get, set
    //     abstract SAMPLER_CUBE: float with get, set
    //     abstract SAMPLES: float with get, set
    //     abstract SAMPLE_ALPHA_TO_COVERAGE: float with get, set
    //     abstract SAMPLE_BUFFERS: float with get, set
    //     abstract SAMPLE_COVERAGE: float with get, set
    //     abstract SAMPLE_COVERAGE_INVERT: float with get, set
    //     abstract SAMPLE_COVERAGE_VALUE: float with get, set
    //     abstract SCISSOR_BOX: float with get, set
    //     abstract SCISSOR_TEST: float with get, set
    //     abstract SHADER_TYPE: float with get, set
    //     abstract SHADING_LANGUAGE_VERSION: float with get, set
    //     abstract SHORT: float with get, set
    //     abstract SRC_ALPHA: float with get, set
    //     abstract SRC_ALPHA_SATURATE: float with get, set
    //     abstract SRC_COLOR: float with get, set
    //     abstract STATIC_DRAW: float with get, set
    //     abstract STENCIL_ATTACHMENT: float with get, set
    //     abstract STENCIL_BACK_FAIL: float with get, set
    //     abstract STENCIL_BACK_FUNC: float with get, set
    //     abstract STENCIL_BACK_PASS_DEPTH_FAIL: float with get, set
    //     abstract STENCIL_BACK_PASS_DEPTH_PASS: float with get, set
    //     abstract STENCIL_BACK_REF: float with get, set
    //     abstract STENCIL_BACK_VALUE_MASK: float with get, set
    //     abstract STENCIL_BACK_WRITEMASK: float with get, set
    //     abstract STENCIL_BITS: float with get, set
    //     abstract STENCIL_BUFFER_BIT: float with get, set
    //     abstract STENCIL_CLEAR_VALUE: float with get, set
    //     abstract STENCIL_FAIL: float with get, set
    //     abstract STENCIL_FUNC: float with get, set
    //     abstract STENCIL_INDEX: float with get, set
    //     abstract STENCIL_INDEX8: float with get, set
    //     abstract STENCIL_PASS_DEPTH_FAIL: float with get, set
    //     abstract STENCIL_PASS_DEPTH_PASS: float with get, set
    //     abstract STENCIL_REF: float with get, set
    //     abstract STENCIL_TEST: float with get, set
    //     abstract STENCIL_VALUE_MASK: float with get, set
    //     abstract STENCIL_WRITEMASK: float with get, set
    //     abstract STREAM_DRAW: float with get, set
    //     abstract SUBPIXEL_BITS: float with get, set
    //     abstract TEXTURE: float with get, set
    //     abstract TEXTURE0: float with get, set
    //     abstract TEXTURE1: float with get, set
    //     abstract TEXTURE10: float with get, set
    //     abstract TEXTURE11: float with get, set
    //     abstract TEXTURE12: float with get, set
    //     abstract TEXTURE13: float with get, set
    //     abstract TEXTURE14: float with get, set
    //     abstract TEXTURE15: float with get, set
    //     abstract TEXTURE16: float with get, set
    //     abstract TEXTURE17: float with get, set
    //     abstract TEXTURE18: float with get, set
    //     abstract TEXTURE19: float with get, set
    //     abstract TEXTURE2: float with get, set
    //     abstract TEXTURE20: float with get, set
    //     abstract TEXTURE21: float with get, set
    //     abstract TEXTURE22: float with get, set
    //     abstract TEXTURE23: float with get, set
    //     abstract TEXTURE24: float with get, set
    //     abstract TEXTURE25: float with get, set
    //     abstract TEXTURE26: float with get, set
    //     abstract TEXTURE27: float with get, set
    //     abstract TEXTURE28: float with get, set
    //     abstract TEXTURE29: float with get, set
    //     abstract TEXTURE3: float with get, set
    //     abstract TEXTURE30: float with get, set
    //     abstract TEXTURE31: float with get, set
    //     abstract TEXTURE4: float with get, set
    //     abstract TEXTURE5: float with get, set
    //     abstract TEXTURE6: float with get, set
    //     abstract TEXTURE7: float with get, set
    //     abstract TEXTURE8: float with get, set
    //     abstract TEXTURE9: float with get, set
    //     abstract TEXTURE_2D: float with get, set
    //     abstract TEXTURE_BINDING_2D: float with get, set
    //     abstract TEXTURE_BINDING_CUBE_MAP: float with get, set
    //     abstract TEXTURE_CUBE_MAP: float with get, set
    //     abstract TEXTURE_CUBE_MAP_NEGATIVE_X: float with get, set
    //     abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: float with get, set
    //     abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: float with get, set
    //     abstract TEXTURE_CUBE_MAP_POSITIVE_X: float with get, set
    //     abstract TEXTURE_CUBE_MAP_POSITIVE_Y: float with get, set
    //     abstract TEXTURE_CUBE_MAP_POSITIVE_Z: float with get, set
    //     abstract TEXTURE_MAG_FILTER: float with get, set
    //     abstract TEXTURE_MIN_FILTER: float with get, set
    //     abstract TEXTURE_WRAP_S: float with get, set
    //     abstract TEXTURE_WRAP_T: float with get, set
    //     abstract TRIANGLES: float with get, set
    //     abstract TRIANGLE_FAN: float with get, set
    //     abstract TRIANGLE_STRIP: float with get, set
    //     abstract UNPACK_ALIGNMENT: float with get, set
    //     abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: float with get, set
    //     abstract UNPACK_FLIP_Y_WEBGL: float with get, set
    //     abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: float with get, set
    //     abstract UNSIGNED_BYTE: float with get, set
    //     abstract UNSIGNED_INT: float with get, set
    //     abstract UNSIGNED_SHORT: float with get, set
    //     abstract UNSIGNED_SHORT_4_4_4_4: float with get, set
    //     abstract UNSIGNED_SHORT_5_5_5_1: float with get, set
    //     abstract UNSIGNED_SHORT_5_6_5: float with get, set
    //     abstract VALIDATE_STATUS: float with get, set
    //     abstract VENDOR: float with get, set
    //     abstract VERSION: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_ENABLED: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_POINTER: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_SIZE: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_STRIDE: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_TYPE: float with get, set
    //     abstract VERTEX_SHADER: float with get, set
    //     abstract VIEWPORT: float with get, set
    //     abstract ZERO: float with get, set
    //     abstract activeTexture: texture: float -> unit
    //     abstract attachShader: program: WebGLProgram * shader: WebGLShader -> unit
    //     abstract bindAttribLocation: program: WebGLProgram * index: float * name: string -> unit
    //     abstract bindBuffer: target: float * buffer: WebGLBuffer -> unit
    //     abstract bindFramebuffer: target: float * framebuffer: WebGLFramebuffer -> unit
    //     abstract bindRenderbuffer: target: float * renderbuffer: WebGLRenderbuffer -> unit
    //     abstract bindTexture: target: float * texture: WebGLTexture -> unit
    //     abstract blendColor: red: float * green: float * blue: float * alpha: float -> unit
    //     abstract blendEquation: mode: float -> unit
    //     abstract blendEquationSeparate: modeRGB: float * modeAlpha: float -> unit
    //     abstract blendFunc: sfactor: float * dfactor: float -> unit
    //     abstract blendFuncSeparate: srcRGB: float * dstRGB: float * srcAlpha: float * dstAlpha: float -> unit
    //     abstract bufferData: target: float * size: U3<float, ArrayBufferView, ArrayBuffer> * usage: float -> unit
    //     abstract bufferSubData: target: float * offset: float * data: U2<ArrayBufferView, ArrayBuffer> -> unit
    //     abstract checkFramebufferStatus: target: float -> float
    //     abstract clear: mask: float -> unit
    //     abstract clearColor: red: float * green: float * blue: float * alpha: float -> unit
    //     abstract clearDepth: depth: float -> unit
    //     abstract clearStencil: s: float -> unit
    //     abstract colorMask: red: bool * green: bool * blue: bool * alpha: bool -> unit
    //     abstract compileShader: shader: WebGLShader -> unit
    //     abstract compressedTexImage2D: target: float * level: float * internalformat: float * width: float * height: float * border: float * data: ArrayBufferView -> unit
    //     abstract compressedTexSubImage2D: target: float * level: float * xoffset: float * yoffset: float * width: float * height: float * format: float * data: ArrayBufferView -> unit
    //     abstract copyTexImage2D: target: float * level: float * internalformat: float * x: float * y: float * width: float * height: float * border: float -> unit
    //     abstract copyTexSubImage2D: target: float * level: float * xoffset: float * yoffset: float * x: float * y: float * width: float * height: float -> unit
    //     abstract createBuffer: unit -> WebGLBuffer
    //     abstract createFramebuffer: unit -> WebGLFramebuffer
    //     abstract createProgram: unit -> WebGLProgram
    //     abstract createRenderbuffer: unit -> WebGLRenderbuffer
    //     abstract createShader: ``type``: float -> WebGLShader
    //     abstract createTexture: unit -> WebGLTexture
    //     abstract cullFace: mode: float -> unit
    //     abstract deleteBuffer: buffer: WebGLBuffer -> unit
    //     abstract deleteFramebuffer: framebuffer: WebGLFramebuffer -> unit
    //     abstract deleteProgram: program: WebGLProgram -> unit
    //     abstract deleteRenderbuffer: renderbuffer: WebGLRenderbuffer -> unit
    //     abstract deleteShader: shader: WebGLShader -> unit
    //     abstract deleteTexture: texture: WebGLTexture -> unit
    //     abstract depthFunc: func: float -> unit
    //     abstract depthMask: flag: bool -> unit
    //     abstract depthRange: zNear: float * zFar: float -> unit
    //     abstract detachShader: program: WebGLProgram * shader: WebGLShader -> unit
    //     abstract disable: cap: float -> unit
    //     abstract disableVertexAttribArray: index: float -> unit
    //     abstract drawArrays: mode: float * first: float * count: float -> unit
    //     abstract drawElements: mode: float * count: float * ``type``: float * offset: float -> unit
    //     abstract enable: cap: float -> unit
    //     abstract enableVertexAttribArray: index: float -> unit
    //     abstract finish: unit -> unit
    //     abstract flush: unit -> unit
    //     abstract framebufferRenderbuffer: target: float * attachment: float * renderbuffertarget: float * renderbuffer: WebGLRenderbuffer -> unit
    //     abstract framebufferTexture2D: target: float * attachment: float * textarget: float * texture: WebGLTexture * level: float -> unit
    //     abstract frontFace: mode: float -> unit
    //     abstract generateMipmap: target: float -> unit
    //     abstract getActiveAttrib: program: WebGLProgram * index: float -> WebGLActiveInfo
    //     abstract getActiveUniform: program: WebGLProgram * index: float -> WebGLActiveInfo
    //     abstract getAttachedShaders: program: WebGLProgram -> ResizeArray<WebGLShader>
    //     abstract getAttribLocation: program: WebGLProgram * name: string -> float
    //     abstract getBufferParameter: target: float * pname: float -> obj
    //     abstract getContextAttributes: unit -> WebGLContextAttributes
    //     abstract getError: unit -> float
    //     abstract getExtension: name: string -> obj
    //     abstract getFramebufferAttachmentParameter: target: float * attachment: float * pname: float -> obj
    //     abstract getParameter: pname: float -> obj
    //     abstract getProgramInfoLog: program: WebGLProgram -> string
    //     abstract getProgramParameter: program: WebGLProgram * pname: float -> obj
    //     abstract getRenderbufferParameter: target: float * pname: float -> obj
    //     abstract getShaderInfoLog: shader: WebGLShader -> string
    //     abstract getShaderParameter: shader: WebGLShader * pname: float -> obj
    //     abstract getShaderPrecisionFormat: shadertype: float * precisiontype: float -> WebGLShaderPrecisionFormat
    //     abstract getShaderSource: shader: WebGLShader -> string
    //     abstract getSupportedExtensions: unit -> ResizeArray<string>
    //     abstract getTexParameter: target: float * pname: float -> obj
    //     abstract getUniform: program: WebGLProgram * location: WebGLUniformLocation -> obj
    //     abstract getUniformLocation: program: WebGLProgram * name: string -> WebGLUniformLocation
    //     abstract getVertexAttrib: index: float * pname: float -> obj
    //     abstract getVertexAttribOffset: index: float * pname: float -> float
    //     abstract hint: target: float * mode: float -> unit
    //     abstract isBuffer: buffer: WebGLBuffer -> bool
    //     abstract isContextLost: unit -> bool
    //     abstract isEnabled: cap: float -> bool
    //     abstract isFramebuffer: framebuffer: WebGLFramebuffer -> bool
    //     abstract isProgram: program: WebGLProgram -> bool
    //     abstract isRenderbuffer: renderbuffer: WebGLRenderbuffer -> bool
    //     abstract isShader: shader: WebGLShader -> bool
    //     abstract isTexture: texture: WebGLTexture -> bool
    //     abstract lineWidth: width: float -> unit
    //     abstract linkProgram: program: WebGLProgram -> unit
    //     abstract pixelStorei: pname: float * param: float -> unit
    //     abstract polygonOffset: factor: float * units: float -> unit
    //     abstract readPixels: x: float * y: float * width: float * height: float * format: float * ``type``: float * pixels: ArrayBufferView -> unit
    //     abstract renderbufferStorage: target: float * internalformat: float * width: float * height: float -> unit
    //     abstract sampleCoverage: value: float * invert: bool -> unit
    //     abstract scissor: x: float * y: float * width: float * height: float -> unit
    //     abstract shaderSource: shader: WebGLShader * source: string -> unit
    //     abstract stencilFunc: func: float * ref: float * mask: float -> unit
    //     abstract stencilFuncSeparate: face: float * func: float * ref: float * mask: float -> unit
    //     abstract stencilMask: mask: float -> unit
    //     abstract stencilMaskSeparate: face: float * mask: float -> unit
    //     abstract stencilOp: fail: float * zfail: float * zpass: float -> unit
    //     abstract stencilOpSeparate: face: float * fail: float * zfail: float * zpass: float -> unit
    //     abstract texImage2D: target: float * level: float * internalformat: float * width: float * height: float * border: float * format: float * ``type``: float * pixels: ArrayBufferView -> unit
    //     abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * image: HTMLImageElement -> unit
    //     abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * canvas: HTMLCanvasElement -> unit
    //     abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * video: HTMLVideoElement -> unit
    //     abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * pixels: ImageData -> unit
    //     abstract texParameterf: target: float * pname: float * param: float -> unit
    //     abstract texParameteri: target: float * pname: float * param: float -> unit
    //     abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * width: float * height: float * format: float * ``type``: float * pixels: ArrayBufferView -> unit
    //     abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * image: HTMLImageElement -> unit
    //     abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * canvas: HTMLCanvasElement -> unit
    //     abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * video: HTMLVideoElement -> unit
    //     abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * pixels: ImageData -> unit
    //     abstract uniform1f: location: WebGLUniformLocation * x: float -> unit
    //     abstract uniform1fv: location: WebGLUniformLocation * v: Float32Array -> unit
    //     abstract uniform1i: location: WebGLUniformLocation * x: float -> unit
    //     abstract uniform1iv: location: WebGLUniformLocation * v: Int32Array -> unit
    //     abstract uniform2f: location: WebGLUniformLocation * x: float * y: float -> unit
    //     abstract uniform2fv: location: WebGLUniformLocation * v: Float32Array -> unit
    //     abstract uniform2i: location: WebGLUniformLocation * x: float * y: float -> unit
    //     abstract uniform2iv: location: WebGLUniformLocation * v: Int32Array -> unit
    //     abstract uniform3f: location: WebGLUniformLocation * x: float * y: float * z: float -> unit
    //     abstract uniform3fv: location: WebGLUniformLocation * v: Float32Array -> unit
    //     abstract uniform3i: location: WebGLUniformLocation * x: float * y: float * z: float -> unit
    //     abstract uniform3iv: location: WebGLUniformLocation * v: Int32Array -> unit
    //     abstract uniform4f: location: WebGLUniformLocation * x: float * y: float * z: float * w: float -> unit
    //     abstract uniform4fv: location: WebGLUniformLocation * v: Float32Array -> unit
    //     abstract uniform4i: location: WebGLUniformLocation * x: float * y: float * z: float * w: float -> unit
    //     abstract uniform4iv: location: WebGLUniformLocation * v: Int32Array -> unit
    //     abstract uniformMatrix2fv: location: WebGLUniformLocation * transpose: bool * value: Float32Array -> unit
    //     abstract uniformMatrix3fv: location: WebGLUniformLocation * transpose: bool * value: Float32Array -> unit
    //     abstract uniformMatrix4fv: location: WebGLUniformLocation * transpose: bool * value: Float32Array -> unit
    //     abstract useProgram: program: WebGLProgram -> unit
    //     abstract validateProgram: program: WebGLProgram -> unit
    //     abstract vertexAttrib1f: indx: float * x: float -> unit
    //     abstract vertexAttrib1fv: indx: float * values: Float32Array -> unit
    //     abstract vertexAttrib2f: indx: float * x: float * y: float -> unit
    //     abstract vertexAttrib2fv: indx: float * values: Float32Array -> unit
    //     abstract vertexAttrib3f: indx: float * x: float * y: float * z: float -> unit
    //     abstract vertexAttrib3fv: indx: float * values: Float32Array -> unit
    //     abstract vertexAttrib4f: indx: float * x: float * y: float * z: float * w: float -> unit
    //     abstract vertexAttrib4fv: indx: float * values: Float32Array -> unit
    //     abstract vertexAttribPointer: indx: float * size: float * ``type``: float * normalized: bool * stride: float * offset: float -> unit
    //     abstract viewport: x: float * y: float * width: float * height: float -> unit

    // and [<AllowNullLiteral>] WebGLRenderingContextType =
    //     abstract prototype: WebGLRenderingContext with get, set
    //     abstract ACTIVE_ATTRIBUTES: float with get, set
    //     abstract ACTIVE_TEXTURE: float with get, set
    //     abstract ACTIVE_UNIFORMS: float with get, set
    //     abstract ALIASED_LINE_WIDTH_RANGE: float with get, set
    //     abstract ALIASED_POINT_SIZE_RANGE: float with get, set
    //     abstract ALPHA: float with get, set
    //     abstract ALPHA_BITS: float with get, set
    //     abstract ALWAYS: float with get, set
    //     abstract ARRAY_BUFFER: float with get, set
    //     abstract ARRAY_BUFFER_BINDING: float with get, set
    //     abstract ATTACHED_SHADERS: float with get, set
    //     abstract BACK: float with get, set
    //     abstract BLEND: float with get, set
    //     abstract BLEND_COLOR: float with get, set
    //     abstract BLEND_DST_ALPHA: float with get, set
    //     abstract BLEND_DST_RGB: float with get, set
    //     abstract BLEND_EQUATION: float with get, set
    //     abstract BLEND_EQUATION_ALPHA: float with get, set
    //     abstract BLEND_EQUATION_RGB: float with get, set
    //     abstract BLEND_SRC_ALPHA: float with get, set
    //     abstract BLEND_SRC_RGB: float with get, set
    //     abstract BLUE_BITS: float with get, set
    //     abstract BOOL: float with get, set
    //     abstract BOOL_VEC2: float with get, set
    //     abstract BOOL_VEC3: float with get, set
    //     abstract BOOL_VEC4: float with get, set
    //     abstract BROWSER_DEFAULT_WEBGL: float with get, set
    //     abstract BUFFER_SIZE: float with get, set
    //     abstract BUFFER_USAGE: float with get, set
    //     abstract BYTE: float with get, set
    //     abstract CCW: float with get, set
    //     abstract CLAMP_TO_EDGE: float with get, set
    //     abstract COLOR_ATTACHMENT0: float with get, set
    //     abstract COLOR_BUFFER_BIT: float with get, set
    //     abstract COLOR_CLEAR_VALUE: float with get, set
    //     abstract COLOR_WRITEMASK: float with get, set
    //     abstract COMPILE_STATUS: float with get, set
    //     abstract COMPRESSED_TEXTURE_FORMATS: float with get, set
    //     abstract CONSTANT_ALPHA: float with get, set
    //     abstract CONSTANT_COLOR: float with get, set
    //     abstract CONTEXT_LOST_WEBGL: float with get, set
    //     abstract CULL_FACE: float with get, set
    //     abstract CULL_FACE_MODE: float with get, set
    //     abstract CURRENT_PROGRAM: float with get, set
    //     abstract CURRENT_VERTEX_ATTRIB: float with get, set
    //     abstract CW: float with get, set
    //     abstract DECR: float with get, set
    //     abstract DECR_WRAP: float with get, set
    //     abstract DELETE_STATUS: float with get, set
    //     abstract DEPTH_ATTACHMENT: float with get, set
    //     abstract DEPTH_BITS: float with get, set
    //     abstract DEPTH_BUFFER_BIT: float with get, set
    //     abstract DEPTH_CLEAR_VALUE: float with get, set
    //     abstract DEPTH_COMPONENT: float with get, set
    //     abstract DEPTH_COMPONENT16: float with get, set
    //     abstract DEPTH_FUNC: float with get, set
    //     abstract DEPTH_RANGE: float with get, set
    //     abstract DEPTH_STENCIL: float with get, set
    //     abstract DEPTH_STENCIL_ATTACHMENT: float with get, set
    //     abstract DEPTH_TEST: float with get, set
    //     abstract DEPTH_WRITEMASK: float with get, set
    //     abstract DITHER: float with get, set
    //     abstract DONT_CARE: float with get, set
    //     abstract DST_ALPHA: float with get, set
    //     abstract DST_COLOR: float with get, set
    //     abstract DYNAMIC_DRAW: float with get, set
    //     abstract ELEMENT_ARRAY_BUFFER: float with get, set
    //     abstract ELEMENT_ARRAY_BUFFER_BINDING: float with get, set
    //     abstract EQUAL: float with get, set
    //     abstract FASTEST: float with get, set
    //     abstract FLOAT: float with get, set
    //     abstract FLOAT_MAT2: float with get, set
    //     abstract FLOAT_MAT3: float with get, set
    //     abstract FLOAT_MAT4: float with get, set
    //     abstract FLOAT_VEC2: float with get, set
    //     abstract FLOAT_VEC3: float with get, set
    //     abstract FLOAT_VEC4: float with get, set
    //     abstract FRAGMENT_SHADER: float with get, set
    //     abstract FRAMEBUFFER: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: float with get, set
    //     abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: float with get, set
    //     abstract FRAMEBUFFER_BINDING: float with get, set
    //     abstract FRAMEBUFFER_COMPLETE: float with get, set
    //     abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: float with get, set
    //     abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: float with get, set
    //     abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: float with get, set
    //     abstract FRAMEBUFFER_UNSUPPORTED: float with get, set
    //     abstract FRONT: float with get, set
    //     abstract FRONT_AND_BACK: float with get, set
    //     abstract FRONT_FACE: float with get, set
    //     abstract FUNC_ADD: float with get, set
    //     abstract FUNC_REVERSE_SUBTRACT: float with get, set
    //     abstract FUNC_SUBTRACT: float with get, set
    //     abstract GENERATE_MIPMAP_HINT: float with get, set
    //     abstract GEQUAL: float with get, set
    //     abstract GREATER: float with get, set
    //     abstract GREEN_BITS: float with get, set
    //     abstract HIGH_FLOAT: float with get, set
    //     abstract HIGH_INT: float with get, set
    //     abstract IMPLEMENTATION_COLOR_READ_FORMAT: float with get, set
    //     abstract IMPLEMENTATION_COLOR_READ_TYPE: float with get, set
    //     abstract INCR: float with get, set
    //     abstract INCR_WRAP: float with get, set
    //     abstract INT: float with get, set
    //     abstract INT_VEC2: float with get, set
    //     abstract INT_VEC3: float with get, set
    //     abstract INT_VEC4: float with get, set
    //     abstract INVALID_ENUM: float with get, set
    //     abstract INVALID_FRAMEBUFFER_OPERATION: float with get, set
    //     abstract INVALID_OPERATION: float with get, set
    //     abstract INVALID_VALUE: float with get, set
    //     abstract INVERT: float with get, set
    //     abstract KEEP: float with get, set
    //     abstract LEQUAL: float with get, set
    //     abstract LESS: float with get, set
    //     abstract LINEAR: float with get, set
    //     abstract LINEAR_MIPMAP_LINEAR: float with get, set
    //     abstract LINEAR_MIPMAP_NEAREST: float with get, set
    //     abstract LINES: float with get, set
    //     abstract LINE_LOOP: float with get, set
    //     abstract LINE_STRIP: float with get, set
    //     abstract LINE_WIDTH: float with get, set
    //     abstract LINK_STATUS: float with get, set
    //     abstract LOW_FLOAT: float with get, set
    //     abstract LOW_INT: float with get, set
    //     abstract LUMINANCE: float with get, set
    //     abstract LUMINANCE_ALPHA: float with get, set
    //     abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: float with get, set
    //     abstract MAX_CUBE_MAP_TEXTURE_SIZE: float with get, set
    //     abstract MAX_FRAGMENT_UNIFORM_VECTORS: float with get, set
    //     abstract MAX_RENDERBUFFER_SIZE: float with get, set
    //     abstract MAX_TEXTURE_IMAGE_UNITS: float with get, set
    //     abstract MAX_TEXTURE_SIZE: float with get, set
    //     abstract MAX_VARYING_VECTORS: float with get, set
    //     abstract MAX_VERTEX_ATTRIBS: float with get, set
    //     abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: float with get, set
    //     abstract MAX_VERTEX_UNIFORM_VECTORS: float with get, set
    //     abstract MAX_VIEWPORT_DIMS: float with get, set
    //     abstract MEDIUM_FLOAT: float with get, set
    //     abstract MEDIUM_INT: float with get, set
    //     abstract MIRRORED_REPEAT: float with get, set
    //     abstract NEAREST: float with get, set
    //     abstract NEAREST_MIPMAP_LINEAR: float with get, set
    //     abstract NEAREST_MIPMAP_NEAREST: float with get, set
    //     abstract NEVER: float with get, set
    //     abstract NICEST: float with get, set
    //     abstract NONE: float with get, set
    //     abstract NOTEQUAL: float with get, set
    //     abstract NO_ERROR: float with get, set
    //     abstract ONE: float with get, set
    //     abstract ONE_MINUS_CONSTANT_ALPHA: float with get, set
    //     abstract ONE_MINUS_CONSTANT_COLOR: float with get, set
    //     abstract ONE_MINUS_DST_ALPHA: float with get, set
    //     abstract ONE_MINUS_DST_COLOR: float with get, set
    //     abstract ONE_MINUS_SRC_ALPHA: float with get, set
    //     abstract ONE_MINUS_SRC_COLOR: float with get, set
    //     abstract OUT_OF_MEMORY: float with get, set
    //     abstract PACK_ALIGNMENT: float with get, set
    //     abstract POINTS: float with get, set
    //     abstract POLYGON_OFFSET_FACTOR: float with get, set
    //     abstract POLYGON_OFFSET_FILL: float with get, set
    //     abstract POLYGON_OFFSET_UNITS: float with get, set
    //     abstract RED_BITS: float with get, set
    //     abstract RENDERBUFFER: float with get, set
    //     abstract RENDERBUFFER_ALPHA_SIZE: float with get, set
    //     abstract RENDERBUFFER_BINDING: float with get, set
    //     abstract RENDERBUFFER_BLUE_SIZE: float with get, set
    //     abstract RENDERBUFFER_DEPTH_SIZE: float with get, set
    //     abstract RENDERBUFFER_GREEN_SIZE: float with get, set
    //     abstract RENDERBUFFER_HEIGHT: float with get, set
    //     abstract RENDERBUFFER_INTERNAL_FORMAT: float with get, set
    //     abstract RENDERBUFFER_RED_SIZE: float with get, set
    //     abstract RENDERBUFFER_STENCIL_SIZE: float with get, set
    //     abstract RENDERBUFFER_WIDTH: float with get, set
    //     abstract RENDERER: float with get, set
    //     abstract REPEAT: float with get, set
    //     abstract REPLACE: float with get, set
    //     abstract RGB: float with get, set
    //     abstract RGB565: float with get, set
    //     abstract RGB5_A1: float with get, set
    //     abstract RGBA: float with get, set
    //     abstract RGBA4: float with get, set
    //     abstract SAMPLER_2D: float with get, set
    //     abstract SAMPLER_CUBE: float with get, set
    //     abstract SAMPLES: float with get, set
    //     abstract SAMPLE_ALPHA_TO_COVERAGE: float with get, set
    //     abstract SAMPLE_BUFFERS: float with get, set
    //     abstract SAMPLE_COVERAGE: float with get, set
    //     abstract SAMPLE_COVERAGE_INVERT: float with get, set
    //     abstract SAMPLE_COVERAGE_VALUE: float with get, set
    //     abstract SCISSOR_BOX: float with get, set
    //     abstract SCISSOR_TEST: float with get, set
    //     abstract SHADER_TYPE: float with get, set
    //     abstract SHADING_LANGUAGE_VERSION: float with get, set
    //     abstract SHORT: float with get, set
    //     abstract SRC_ALPHA: float with get, set
    //     abstract SRC_ALPHA_SATURATE: float with get, set
    //     abstract SRC_COLOR: float with get, set
    //     abstract STATIC_DRAW: float with get, set
    //     abstract STENCIL_ATTACHMENT: float with get, set
    //     abstract STENCIL_BACK_FAIL: float with get, set
    //     abstract STENCIL_BACK_FUNC: float with get, set
    //     abstract STENCIL_BACK_PASS_DEPTH_FAIL: float with get, set
    //     abstract STENCIL_BACK_PASS_DEPTH_PASS: float with get, set
    //     abstract STENCIL_BACK_REF: float with get, set
    //     abstract STENCIL_BACK_VALUE_MASK: float with get, set
    //     abstract STENCIL_BACK_WRITEMASK: float with get, set
    //     abstract STENCIL_BITS: float with get, set
    //     abstract STENCIL_BUFFER_BIT: float with get, set
    //     abstract STENCIL_CLEAR_VALUE: float with get, set
    //     abstract STENCIL_FAIL: float with get, set
    //     abstract STENCIL_FUNC: float with get, set
    //     abstract STENCIL_INDEX: float with get, set
    //     abstract STENCIL_INDEX8: float with get, set
    //     abstract STENCIL_PASS_DEPTH_FAIL: float with get, set
    //     abstract STENCIL_PASS_DEPTH_PASS: float with get, set
    //     abstract STENCIL_REF: float with get, set
    //     abstract STENCIL_TEST: float with get, set
    //     abstract STENCIL_VALUE_MASK: float with get, set
    //     abstract STENCIL_WRITEMASK: float with get, set
    //     abstract STREAM_DRAW: float with get, set
    //     abstract SUBPIXEL_BITS: float with get, set
    //     abstract TEXTURE: float with get, set
    //     abstract TEXTURE0: float with get, set
    //     abstract TEXTURE1: float with get, set
    //     abstract TEXTURE10: float with get, set
    //     abstract TEXTURE11: float with get, set
    //     abstract TEXTURE12: float with get, set
    //     abstract TEXTURE13: float with get, set
    //     abstract TEXTURE14: float with get, set
    //     abstract TEXTURE15: float with get, set
    //     abstract TEXTURE16: float with get, set
    //     abstract TEXTURE17: float with get, set
    //     abstract TEXTURE18: float with get, set
    //     abstract TEXTURE19: float with get, set
    //     abstract TEXTURE2: float with get, set
    //     abstract TEXTURE20: float with get, set
    //     abstract TEXTURE21: float with get, set
    //     abstract TEXTURE22: float with get, set
    //     abstract TEXTURE23: float with get, set
    //     abstract TEXTURE24: float with get, set
    //     abstract TEXTURE25: float with get, set
    //     abstract TEXTURE26: float with get, set
    //     abstract TEXTURE27: float with get, set
    //     abstract TEXTURE28: float with get, set
    //     abstract TEXTURE29: float with get, set
    //     abstract TEXTURE3: float with get, set
    //     abstract TEXTURE30: float with get, set
    //     abstract TEXTURE31: float with get, set
    //     abstract TEXTURE4: float with get, set
    //     abstract TEXTURE5: float with get, set
    //     abstract TEXTURE6: float with get, set
    //     abstract TEXTURE7: float with get, set
    //     abstract TEXTURE8: float with get, set
    //     abstract TEXTURE9: float with get, set
    //     abstract TEXTURE_2D: float with get, set
    //     abstract TEXTURE_BINDING_2D: float with get, set
    //     abstract TEXTURE_BINDING_CUBE_MAP: float with get, set
    //     abstract TEXTURE_CUBE_MAP: float with get, set
    //     abstract TEXTURE_CUBE_MAP_NEGATIVE_X: float with get, set
    //     abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: float with get, set
    //     abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: float with get, set
    //     abstract TEXTURE_CUBE_MAP_POSITIVE_X: float with get, set
    //     abstract TEXTURE_CUBE_MAP_POSITIVE_Y: float with get, set
    //     abstract TEXTURE_CUBE_MAP_POSITIVE_Z: float with get, set
    //     abstract TEXTURE_MAG_FILTER: float with get, set
    //     abstract TEXTURE_MIN_FILTER: float with get, set
    //     abstract TEXTURE_WRAP_S: float with get, set
    //     abstract TEXTURE_WRAP_T: float with get, set
    //     abstract TRIANGLES: float with get, set
    //     abstract TRIANGLE_FAN: float with get, set
    //     abstract TRIANGLE_STRIP: float with get, set
    //     abstract UNPACK_ALIGNMENT: float with get, set
    //     abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: float with get, set
    //     abstract UNPACK_FLIP_Y_WEBGL: float with get, set
    //     abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: float with get, set
    //     abstract UNSIGNED_BYTE: float with get, set
    //     abstract UNSIGNED_INT: float with get, set
    //     abstract UNSIGNED_SHORT: float with get, set
    //     abstract UNSIGNED_SHORT_4_4_4_4: float with get, set
    //     abstract UNSIGNED_SHORT_5_5_5_1: float with get, set
    //     abstract UNSIGNED_SHORT_5_6_5: float with get, set
    //     abstract VALIDATE_STATUS: float with get, set
    //     abstract VENDOR: float with get, set
    //     abstract VERSION: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_ENABLED: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_POINTER: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_SIZE: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_STRIDE: float with get, set
    //     abstract VERTEX_ATTRIB_ARRAY_TYPE: float with get, set
    //     abstract VERTEX_SHADER: float with get, set
    //     abstract VIEWPORT: float with get, set
    //     abstract ZERO: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLRenderingContext

    // and [<AllowNullLiteral>] WebGLShader =
    //     inherit WebGLObject

    // and [<AllowNullLiteral>] WebGLShaderType =
    //     abstract prototype: WebGLShader with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLShader

    // and [<AllowNullLiteral>] WebGLShaderPrecisionFormat =
    //     abstract precision: float with get, set
    //     abstract rangeMax: float with get, set
    //     abstract rangeMin: float with get, set

    // and [<AllowNullLiteral>] WebGLShaderPrecisionFormatType =
    //     abstract prototype: WebGLShaderPrecisionFormat with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLShaderPrecisionFormat

    // and [<AllowNullLiteral>] WebGLTexture =
    //     inherit WebGLObject

    // and [<AllowNullLiteral>] WebGLTextureType =
    //     abstract prototype: WebGLTexture with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLTexture

    // and [<AllowNullLiteral>] WebGLUniformLocation =
    //     interface end

    // and [<AllowNullLiteral>] WebGLUniformLocationType =
    //     abstract prototype: WebGLUniformLocation with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLUniformLocation

    // and [<AllowNullLiteral>] EXT_texture_filter_anisotropic =
    //     abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: float with get, set
    //     abstract TEXTURE_MAX_ANISOTROPY_EXT: float with get, set

    // and [<AllowNullLiteral>] EXT_texture_filter_anisotropicType =
    //     abstract prototype: EXT_texture_filter_anisotropic with get, set
    //     abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: float with get, set
    //     abstract TEXTURE_MAX_ANISOTROPY_EXT: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> EXT_texture_filter_anisotropic

    and [<AllowNullLiteral>] WebSocket =
        inherit EventTarget
        abstract binaryType: string with get, set
        abstract bufferedAmount: float with get, set
        abstract extensions: string with get, set
        abstract onclose: (CloseEvent -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onmessage: (MessageEvent -> 'Out) with get, set
        abstract onopen: (Event -> 'Out) with get, set
        abstract protocol: string with get, set
        abstract readyState: float with get, set
        abstract url: string with get, set
        abstract CLOSED: float with get, set
        abstract CLOSING: float with get, set
        abstract CONNECTING: float with get, set
        abstract OPEN: float with get, set
        abstract close: ?code: float * ?reason: string -> unit
        abstract send: data: obj -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] WebSocketType =
        abstract prototype: WebSocket with get, set
        abstract CLOSED: float with get, set
        abstract CLOSING: float with get, set
        abstract CONNECTING: float with get, set
        abstract OPEN: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: url: string * ?protocols: U2<string, ResizeArray<string>> -> WebSocket

    and [<AllowNullLiteral>] WheelEvent =
        inherit MouseEvent
        abstract deltaMode: float with get, set
        abstract deltaX: float with get, set
        abstract deltaY: float with get, set
        abstract deltaZ: float with get, set
        abstract DOM_DELTA_LINE: float with get, set
        abstract DOM_DELTA_PAGE: float with get, set
        abstract DOM_DELTA_PIXEL: float with get, set
        abstract getCurrentPoint: element: Element -> unit
        abstract initWheelEvent: typeArg: string * canBubbleArg: bool * cancelableArg: bool * viewArg: Window * detailArg: float * screenXArg: float * screenYArg: float * clientXArg: float * clientYArg: float * buttonArg: float * relatedTargetArg: EventTarget * modifiersListArg: string * deltaXArg: float * deltaYArg: float * deltaZArg: float * deltaMode: float -> unit

    and [<AllowNullLiteral>] WheelEventType =
        abstract prototype: WheelEvent with get, set
        abstract DOM_DELTA_LINE: float with get, set
        abstract DOM_DELTA_PAGE: float with get, set
        abstract DOM_DELTA_PIXEL: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: typeArg: string * ?eventInitDict: WheelEventInit -> WheelEvent

    and [<AllowNullLiteral>] Window =
        inherit EventTarget
        inherit WindowTimers
        inherit WindowSessionStorage
        inherit WindowLocalStorage
        inherit WindowConsole
        inherit GlobalEventHandlers
        // inherit IDBEnvironment
        inherit WindowBase64
        abstract animationStartTime: float with get, set
        abstract applicationCache: ApplicationCache with get, set
        abstract clientInformation: Navigator with get, set
        abstract closed: bool with get, set
        abstract crypto: Crypto with get, set
        abstract defaultStatus: string with get, set
        abstract devicePixelRatio: float with get, set
        abstract doNotTrack: string with get, set
        abstract document: Document with get, set
        abstract ``event``: Event with get, set
        abstract ``external``: External with get, set
        abstract frameElement: Element with get, set
        abstract frames: Window with get, set
        abstract history: History with get, set
        abstract innerHeight: float with get, set
        abstract innerWidth: float with get, set
        abstract length: float with get, set
        abstract location: Location with get, set
        abstract locationbar: BarProp with get, set
        abstract menubar: BarProp with get, set
        abstract name: string with get, set
        abstract navigator: Navigator with get, set
        abstract offscreenBuffering: U2<string, bool> with get, set
        abstract onabort: (Event -> 'Out) with get, set
        abstract onafterprint: (Event -> 'Out) with get, set
        abstract onbeforeprint: (Event -> 'Out) with get, set
        abstract onbeforeunload: (BeforeUnloadEvent -> 'Out) with get, set
        abstract onblur: (FocusEvent -> 'Out) with get, set
        abstract oncanplay: (Event -> 'Out) with get, set
        abstract oncanplaythrough: (Event -> 'Out) with get, set
        abstract onchange: (Event -> 'Out) with get, set
        abstract onclick: (MouseEvent -> 'Out) with get, set
        abstract oncompassneedscalibration: (Event -> 'Out) with get, set
        abstract oncontextmenu: (PointerEvent -> 'Out) with get, set
        abstract ondblclick: (MouseEvent -> 'Out) with get, set
        abstract ondevicemotion: (DeviceMotionEvent -> 'Out) with get, set
        abstract ondeviceorientation: (DeviceOrientationEvent -> 'Out) with get, set
        abstract ondrag: (DragEvent -> 'Out) with get, set
        abstract ondragend: (DragEvent -> 'Out) with get, set
        abstract ondragenter: (DragEvent -> 'Out) with get, set
        abstract ondragleave: (DragEvent -> 'Out) with get, set
        abstract ondragover: (DragEvent -> 'Out) with get, set
        abstract ondragstart: (DragEvent -> 'Out) with get, set
        abstract ondrop: (DragEvent -> 'Out) with get, set
        abstract ondurationchange: (Event -> 'Out) with get, set
        abstract onemptied: (Event -> 'Out) with get, set
        abstract onended: (Event -> 'Out) with get, set
        abstract onerror: ErrorEventHandler with get, set
        abstract onfocus: (FocusEvent -> 'Out) with get, set
        abstract onhashchange: (HashChangeEvent -> 'Out) with get, set
        abstract oninput: (Event -> 'Out) with get, set
        abstract onkeydown: (KeyboardEvent -> 'Out) with get, set
        abstract onkeypress: (KeyboardEvent -> 'Out) with get, set
        abstract onkeyup: (KeyboardEvent -> 'Out) with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract onloadeddata: (Event -> 'Out) with get, set
        abstract onloadedmetadata: (Event -> 'Out) with get, set
        abstract onloadstart: (Event -> 'Out) with get, set
        abstract onmessage: (MessageEvent -> 'Out) with get, set
        abstract onmousedown: (MouseEvent -> 'Out) with get, set
        abstract onmouseenter: (MouseEvent -> 'Out) with get, set
        abstract onmouseleave: (MouseEvent -> 'Out) with get, set
        abstract onmousemove: (MouseEvent -> 'Out) with get, set
        abstract onmouseout: (MouseEvent -> 'Out) with get, set
        abstract onmouseover: (MouseEvent -> 'Out) with get, set
        abstract onmouseup: (MouseEvent -> 'Out) with get, set
        abstract onmousewheel: (MouseWheelEvent -> 'Out) with get, set
        abstract onoffline: (Event -> 'Out) with get, set
        abstract ononline: (Event -> 'Out) with get, set
        abstract onorientationchange: (Event -> 'Out) with get, set
        abstract onpagehide: (PageTransitionEvent -> 'Out) with get, set
        abstract onpageshow: (PageTransitionEvent -> 'Out) with get, set
        abstract onpause: (Event -> 'Out) with get, set
        abstract onplay: (Event -> 'Out) with get, set
        abstract onplaying: (Event -> 'Out) with get, set
        abstract onpopstate: (PopStateEvent -> 'Out) with get, set
        abstract onprogress: (ProgressEvent -> 'Out) with get, set
        abstract onratechange: (Event -> 'Out) with get, set
        abstract onreadystatechange: (ProgressEvent -> 'Out) with get, set
        abstract onreset: (Event -> 'Out) with get, set
        abstract onresize: (UIEvent -> 'Out) with get, set
        abstract onscroll: (UIEvent -> 'Out) with get, set
        abstract onseeked: (Event -> 'Out) with get, set
        abstract onseeking: (Event -> 'Out) with get, set
        abstract onselect: (UIEvent -> 'Out) with get, set
        abstract onstalled: (Event -> 'Out) with get, set
        abstract onstorage: (StorageEvent -> 'Out) with get, set
        abstract onsubmit: (Event -> 'Out) with get, set
        abstract onsuspend: (Event -> 'Out) with get, set
        abstract ontimeupdate: (Event -> 'Out) with get, set
        abstract ontouchcancel: obj with get, set
        abstract ontouchend: obj with get, set
        abstract ontouchmove: obj with get, set
        abstract ontouchstart: obj with get, set
        abstract onunload: (Event -> 'Out) with get, set
        abstract onvolumechange: (Event -> 'Out) with get, set
        abstract onwaiting: (Event -> 'Out) with get, set
        abstract opener: Window with get, set
        abstract orientation: U2<string, float> with get, set
        abstract outerHeight: float with get, set
        abstract outerWidth: float with get, set
        abstract pageXOffset: float with get, set
        abstract pageYOffset: float with get, set
        abstract parent: Window with get, set
        abstract performance: Performance with get, set
        abstract personalbar: BarProp with get, set
        abstract screen: Screen with get, set
        abstract screenLeft: float with get, set
        abstract screenTop: float with get, set
        abstract screenX: float with get, set
        abstract screenY: float with get, set
        abstract scrollX: float with get, set
        abstract scrollY: float with get, set
        abstract scrollbars: BarProp with get, set
        abstract self: Window with get, set
        abstract status: string with get, set
        abstract statusbar: BarProp with get, set
        abstract styleMedia: StyleMedia with get, set
        abstract toolbar: BarProp with get, set
        abstract top: Window with get, set
        abstract window: Window with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> Window with get, set
        abstract alert: ?message: obj -> unit
        abstract blur: unit -> unit
        abstract cancelAnimationFrame: handle: float -> unit
        abstract captureEvents: unit -> unit
        abstract close: unit -> unit
        abstract confirm: ?message: string -> bool
        abstract focus: unit -> unit
        // abstract getComputedStyle: elt: Element * ?pseudoElt: string -> CSSStyleDeclaration
        // abstract getMatchedCSSRules: elt: Element * ?pseudoElt: string -> CSSRuleList
        abstract getSelection: unit -> Selection
        abstract matchMedia: mediaQuery: string -> MediaQueryList
        abstract moveBy: ?x: float * ?y: float -> unit
        abstract moveTo: ?x: float * ?y: float -> unit
        abstract ``open``: ?url: string * ?target: string * ?features: string * ?replace: bool -> Window
        abstract postMessage: message: obj * targetOrigin: string * ?ports: obj -> unit
        abstract print: unit -> unit
        abstract prompt: ?message: string * ?_default: string -> string
        abstract releaseEvents: unit -> unit
        abstract requestAnimationFrame: callback: (float -> unit) -> float
        abstract resizeBy: ?x: float * ?y: float -> unit
        abstract resizeTo: ?x: float * ?y: float -> unit
        abstract scroll: ?x: float * ?y: float -> unit
        abstract scrollBy: ?x: float * ?y: float -> unit
        abstract scrollTo: ?x: float * ?y: float -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] WindowClient =
        abstract focused: bool with get, set
        abstract visibilityState: WindowClientState with get, set
        abstract focus: unit -> Promise<WindowClient>
        abstract navigate: url: string -> Promise<WindowClient>

    and [<StringEnum>] [<RequireQualifiedAccess>] WindowClientState =
        | Hidden
        | Visible
        | Prerender
        | Unloaded

    and [<AllowNullLiteral>] WindowType =
        abstract prototype: Window with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> Window

    and [<AllowNullLiteral>] Worker =
        inherit EventTarget
        inherit AbstractWorker
        abstract onmessage: (MessageEvent -> 'Out) with get, set
        abstract postMessage: message: obj * ?ports: obj -> unit
        abstract terminate: unit -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] WorkerType =
        abstract prototype: Worker with get, set
        [<Emit("new $0($1...)")>] abstract Create: stringUrl: string -> Worker

    and [<AllowNullLiteral>] XMLDocument =
        inherit Document


    and [<AllowNullLiteral>] XMLDocumentType =
        abstract prototype: XMLDocument with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> XMLDocument

    and [<AllowNullLiteral>] XMLHttpRequest =
        inherit EventTarget
        inherit XMLHttpRequestEventTarget
        abstract onreadystatechange: (ProgressEvent -> 'Out) with get, set
        abstract readyState: float with get, set
        abstract response: obj with get, set
        abstract responseBody: obj with get, set
        abstract responseText: string with get, set
        abstract responseType: string with get, set
        abstract responseXML: obj with get, set
        abstract status: float with get, set
        abstract statusText: string with get, set
        abstract timeout: float with get, set
        abstract upload: XMLHttpRequestUpload with get, set
        abstract withCredentials: bool with get, set
        abstract DONE: float with get, set
        abstract HEADERS_RECEIVED: float with get, set
        abstract LOADING: float with get, set
        abstract OPENED: float with get, set
        abstract UNSENT: float with get, set
        abstract abort: unit -> unit
        abstract getAllResponseHeaders: unit -> string
        abstract getResponseHeader: header: string -> string
        abstract ``open``: ``method``: string * url: string * ?async: bool * ?user: string * ?password: string -> unit
        abstract overrideMimeType: mime: string -> unit
        abstract send: ?data: Document -> unit
        abstract send: ?data: string -> unit
        abstract send: ?data: obj -> unit
        abstract setRequestHeader: header: string * value: string -> unit
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] XMLHttpRequestType =
        abstract prototype: XMLHttpRequest with get, set
        abstract DONE: float with get, set
        abstract HEADERS_RECEIVED: float with get, set
        abstract LOADING: float with get, set
        abstract OPENED: float with get, set
        abstract UNSENT: float with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> XMLHttpRequest
        abstract create: unit -> XMLHttpRequest

    and [<AllowNullLiteral>] XMLHttpRequestUpload =
        inherit EventTarget
        inherit XMLHttpRequestEventTarget
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] XMLHttpRequestUploadType =
        abstract prototype: XMLHttpRequestUpload with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> XMLHttpRequestUpload

    // and [<AllowNullLiteral>] XMLSerializer =
    //     abstract serializeToString: target: Node -> string

    // and [<AllowNullLiteral>] XMLSerializerType =
    //     abstract prototype: XMLSerializer with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> XMLSerializer

    // and [<AllowNullLiteral>] XPathEvaluator =
    //     abstract createExpression: expression: string * resolver: XPathNSResolver -> XPathExpression
    //     abstract createNSResolver: ?nodeResolver: Node -> XPathNSResolver
    //     abstract evaluate: expression: string * contextNode: Node * resolver: XPathNSResolver * ``type``: float * result: XPathResult -> XPathResult

    // and [<AllowNullLiteral>] XPathEvaluatorType =
    //     abstract prototype: XPathEvaluator with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> XPathEvaluator

    // and [<AllowNullLiteral>] XPathExpression =
    //     abstract evaluate: contextNode: Node * ``type``: float * result: XPathResult -> XPathExpression

    // and [<AllowNullLiteral>] XPathExpressionType =
    //     abstract prototype: XPathExpression with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> XPathExpression

    // and [<AllowNullLiteral>] XPathNSResolver =
    //     abstract lookupNamespaceURI: prefix: string -> string

    // and [<AllowNullLiteral>] XPathNSResolverType =
    //     abstract prototype: XPathNSResolver with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> XPathNSResolver

    // and [<AllowNullLiteral>] XPathResult =
    //     abstract booleanValue: bool with get, set
    //     abstract invalidIteratorState: bool with get, set
    //     abstract numberValue: float with get, set
    //     abstract resultType: float with get, set
    //     abstract singleNodeValue: Node with get, set
    //     abstract snapshotLength: float with get, set
    //     abstract stringValue: string with get, set
    //     abstract ANY_TYPE: float with get, set
    //     abstract ANY_UNORDERED_NODE_TYPE: float with get, set
    //     abstract BOOLEAN_TYPE: float with get, set
    //     abstract FIRST_ORDERED_NODE_TYPE: float with get, set
    //     abstract NUMBER_TYPE: float with get, set
    //     abstract ORDERED_NODE_ITERATOR_TYPE: float with get, set
    //     abstract ORDERED_NODE_SNAPSHOT_TYPE: float with get, set
    //     abstract STRING_TYPE: float with get, set
    //     abstract UNORDERED_NODE_ITERATOR_TYPE: float with get, set
    //     abstract UNORDERED_NODE_SNAPSHOT_TYPE: float with get, set
    //     abstract iterateNext: unit -> Node
    //     abstract snapshotItem: index: float -> Node

    // and [<AllowNullLiteral>] XPathResultType =
    //     abstract prototype: XPathResult with get, set
    //     abstract ANY_TYPE: float with get, set
    //     abstract ANY_UNORDERED_NODE_TYPE: float with get, set
    //     abstract BOOLEAN_TYPE: float with get, set
    //     abstract FIRST_ORDERED_NODE_TYPE: float with get, set
    //     abstract NUMBER_TYPE: float with get, set
    //     abstract ORDERED_NODE_ITERATOR_TYPE: float with get, set
    //     abstract ORDERED_NODE_SNAPSHOT_TYPE: float with get, set
    //     abstract STRING_TYPE: float with get, set
    //     abstract UNORDERED_NODE_ITERATOR_TYPE: float with get, set
    //     abstract UNORDERED_NODE_SNAPSHOT_TYPE: float with get, set
    //     [<Emit("new $0($1...)")>] abstract Create: unit -> XPathResult

    and [<AllowNullLiteral>] AbstractWorker =
        abstract onerror: (Event -> 'Out) with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] ChildNode =
        abstract remove: unit -> unit

    and [<AllowNullLiteral>] DOML2DeprecatedColorProperty =
        abstract color: string with get, set

    and [<AllowNullLiteral>] DOML2DeprecatedSizeProperty =
        abstract size: float with get, set

    and [<AllowNullLiteral>] DocumentEvent =
        abstract createEvent: eventInterface: string -> Event

    and [<AllowNullLiteral>] ElementTraversal =
        abstract childElementCount: float with get, set
        abstract firstElementChild: Element with get, set
        abstract lastElementChild: Element with get, set
        abstract nextElementSibling: Element with get, set
        abstract previousElementSibling: Element with get, set

    and [<AllowNullLiteral>] GetSVGDocument =
        abstract getSVGDocument: unit -> Document

    and [<AllowNullLiteral>] GlobalEventHandlers =
        abstract onpointercancel: (PointerEvent -> 'Out) with get, set
        abstract onpointerdown: (PointerEvent -> 'Out) with get, set
        abstract onpointerenter: (PointerEvent -> 'Out) with get, set
        abstract onpointerleave: (PointerEvent -> 'Out) with get, set
        abstract onpointermove: (PointerEvent -> 'Out) with get, set
        abstract onpointerout: (PointerEvent -> 'Out) with get, set
        abstract onpointerover: (PointerEvent -> 'Out) with get, set
        abstract onpointerup: (PointerEvent -> 'Out) with get, set
        abstract onwheel: (WheelEvent -> 'Out) with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] HTMLTableAlignment =
        /// Sets or retrieves a value that you can use to implement your own ch functionality for the object.
        abstract ch: string with get, set
        /// Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
        abstract chOff: string with get, set
        /// Sets or retrieves how text and other content are vertically aligned within the object that contains them.
        abstract vAlign: string with get, set

    and [<AllowNullLiteral>] NavigatorContentUtils =
        interface end

    and [<AllowNullLiteral>] NavigatorGeolocation =
        abstract geolocation: Geolocation with get, set

    and [<AllowNullLiteral>] NavigatorID =
        abstract appName: string with get, set
        abstract appVersion: string with get, set
        abstract platform: string with get, set
        abstract product: string with get, set
        abstract productSub: string with get, set
        abstract userAgent: string with get, set
        abstract vendor: string with get, set
        abstract vendorSub: string with get, set

    and [<AllowNullLiteral>] NavigatorOnLine =
        abstract onLine: bool with get, set

    and [<AllowNullLiteral>] NavigatorStorageUtils =
        interface end

    and [<AllowNullLiteral>] NodeSelector =
        abstract querySelector: selectors: string -> Element
        abstract querySelectorAll: selectors: string -> NodeListOf<Element>

    and [<AllowNullLiteral>] RandomSource =
        abstract getRandomValues: array: ArrayBufferView -> ArrayBufferView

    // and [<AllowNullLiteral>] SVGAnimatedPathData =
    //     abstract pathSegList: SVGPathSegList with get, set

    // and [<AllowNullLiteral>] SVGAnimatedPoints =
    //     abstract animatedPoints: SVGPointList with get, set
    //     abstract points: SVGPointList with get, set

    // and [<AllowNullLiteral>] SVGExternalResourcesRequired =
    //     abstract externalResourcesRequired: SVGAnimatedBoolean with get, set

    // and [<AllowNullLiteral>] SVGFilterPrimitiveStandardAttributes =
    //     inherit SVGStylable
    //     abstract height: SVGAnimatedLength with get, set
    //     abstract result: SVGAnimatedString with get, set
    //     abstract width: SVGAnimatedLength with get, set
    //     abstract x: SVGAnimatedLength with get, set
    //     abstract y: SVGAnimatedLength with get, set

    // and [<AllowNullLiteral>] SVGFitToViewBox =
    //     abstract preserveAspectRatio: SVGAnimatedPreserveAspectRatio with get, set
    //     abstract viewBox: SVGAnimatedRect with get, set

    // and [<AllowNullLiteral>] SVGLangSpace =
    //     abstract xmllang: string with get, set
    //     abstract xmlspace: string with get, set

    // and [<AllowNullLiteral>] SVGLocatable =
    //     abstract farthestViewportElement: SVGElement with get, set
    //     abstract nearestViewportElement: SVGElement with get, set
    //     abstract getBBox: unit -> SVGRect
    //     abstract getCTM: unit -> SVGMatrix
    //     abstract getScreenCTM: unit -> SVGMatrix
    //     abstract getTransformToElement: element: SVGElement -> SVGMatrix

    // and [<AllowNullLiteral>] SVGStylable =
    //     abstract className: obj with get, set
    //     // abstract style: CSSStyleDeclaration with get, set

    // and [<AllowNullLiteral>] SVGTests =
    //     abstract requiredExtensions: SVGStringList with get, set
    //     abstract requiredFeatures: SVGStringList with get, set
    //     abstract systemLanguage: SVGStringList with get, set
    //     abstract hasExtension: extension: string -> bool

    // and [<AllowNullLiteral>] SVGTransformable =
    //     inherit SVGLocatable
    //     abstract transform: SVGAnimatedTransformList with get, set

    // and [<AllowNullLiteral>] SVGURIReference =
    //     abstract href: SVGAnimatedString with get, set

    and [<AllowNullLiteral>] WindowBase64 =
        abstract atob: encodedString: string -> string
        abstract btoa: rawString: string -> string

    and [<AllowNullLiteral>] WindowConsole =
        abstract console: Console with get, set

    and [<AllowNullLiteral>] WindowLocalStorage =
        abstract localStorage: Storage with get, set

    and [<AllowNullLiteral>] WindowSessionStorage =
        abstract sessionStorage: Storage with get, set

    and [<AllowNullLiteral>] WindowTimers =
        inherit WindowTimersExtension
        abstract clearInterval: handle: float -> unit
        abstract clearTimeout: handle: float -> unit
        abstract setInterval: handler: obj * timeout: int * [<ParamArray>] args: obj[] -> float
        abstract setTimeout: handler: obj * timeout: int * [<ParamArray>] args: obj[] -> float

    and [<AllowNullLiteral>] WindowTimersExtension =
        abstract clearImmediate: handle: float -> unit
        abstract setImmediate: expression: obj * [<ParamArray>] args: obj[] -> float

    and [<AllowNullLiteral>] XMLHttpRequestEventTarget =
        abstract onabort: (Event -> 'Out) with get, set
        abstract onerror: (Event -> 'Out) with get, set
        abstract onload: (Event -> 'Out) with get, set
        abstract onloadend: (ProgressEvent -> 'Out) with get, set
        abstract onloadstart: (Event -> 'Out) with get, set
        abstract onprogress: (ProgressEvent -> 'Out) with get, set
        abstract ontimeout: (ProgressEvent -> 'Out) with get, set
        abstract addEventListener: ``type``: string * listener: (Event->unit) * ?useCapture: bool -> unit

    and [<AllowNullLiteral>] StorageEventInit =
        inherit EventInit
        abstract key: string option with get, set
        abstract oldValue: string option with get, set
        abstract newValue: string option with get, set
        abstract url: string with get, set
        abstract storageArea: Storage option with get, set

    and [<AllowNullLiteral>] NodeListOf<'TNode> =
        inherit NodeList
        abstract length: float with get, set
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: int -> 'TNode with get, set
        abstract item: index: float -> 'TNode

    and [<AllowNullLiteral>] BlobPropertyBag =
        abstract ``type``: string option with get, set
        abstract endings: string option with get, set

    and [<AllowNullLiteral>] FilePropertyBag =
        abstract ``type``: string option with get, set
        abstract lastModified: float option with get, set

    and [<AllowNullLiteral>] EventListenerObject =
        abstract handleEvent: evt: Event -> unit

    and [<AllowNullLiteral>] MessageEventInit =
        inherit EventInit
        abstract data: obj option with get, set
        abstract origin: string option with get, set
        abstract lastEventId: string option with get, set
        abstract channel: string option with get, set
        abstract source: obj option with get, set
        abstract ports: ResizeArray<MessagePort> option with get, set

    and [<AllowNullLiteral>] ProgressEventInit =
        inherit EventInit
        abstract lengthComputable: bool option with get, set
        abstract loaded: float option with get, set
        abstract total: float option with get, set

    and [<AllowNullLiteral>] HTMLTemplateElement =
        inherit HTMLElement
        abstract content: DocumentFragment with get, set

    and [<AllowNullLiteral>] HTMLTemplateElementType =
        abstract prototype: HTMLTemplateElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLTemplateElement

    and [<AllowNullLiteral>] HTMLPictureElement =
        inherit HTMLElement

    and [<AllowNullLiteral>] HTMLPictureElementType =
        abstract prototype: HTMLPictureElement with get, set
        [<Emit("new $0($1...)")>] abstract Create: unit -> HTMLPictureElement

    and ErrorEventHandler = (string -> string -> float -> float -> Error -> unit)

    and PositionCallback = (Position -> unit)

    and PositionErrorCallback = (PositionError -> unit)

    and MediaQueryListListener = (MediaQueryList -> unit)

    and DecodeSuccessCallback = (AudioBuffer -> unit)

    and DecodeErrorCallback = (DOMException -> unit)

    and FunctionStringCallback = (string -> unit)

    and AudioType =
        [<Emit("new $0($1...)")>] abstract Create: ?src: string -> HTMLAudioElement

    and ImageType =
        [<Emit("new $0($1...)")>] abstract Create: ?width: float * ?height: float -> HTMLImageElement

    and OptionType =
        [<Emit("new $0($1...)")>] abstract Create: ?text: string * ?value: string * ?defaultSelected: bool * ?selected: bool -> HTMLOptionElement

    let [<Global>] ANGLE_instanced_arrays: ANGLE_instanced_arraysType = jsNative
    let [<Global>] AnalyserNode: AnalyserNodeType = jsNative
    let [<Global>] AnimationEvent: AnimationEventType = jsNative
    let [<Global>] ApplicationCache: ApplicationCacheType = jsNative
    let [<Global>] AriaRequestEvent: AriaRequestEventType = jsNative
    let [<Global>] Attr: AttrType = jsNative
    let [<Global>] AudioBuffer: AudioBufferType = jsNative
    let [<Global>] AudioBufferSourceNode: AudioBufferSourceNodeType = jsNative
    let [<Global>] AudioContext: AudioContextType = jsNative
    let [<Global>] AudioDestinationNode: AudioDestinationNodeType = jsNative
    let [<Global>] AudioListener: AudioListenerType = jsNative
    let [<Global>] AudioNode: AudioNodeType = jsNative
    let [<Global>] AudioParam: AudioParamType = jsNative
    let [<Global>] AudioProcessingEvent: AudioProcessingEventType = jsNative
    let [<Global>] AudioTrack: AudioTrackType = jsNative
    let [<Global>] AudioTrackList: AudioTrackListType = jsNative
    let [<Global>] AudioWorker: AudioWorkerType = jsNative
    let [<Global>] AudioWorkerGlobalScope: AudioWorkerGlobalScopeType = jsNative
    let [<Global>] AudioWorkerNode: AudioWorkerNodeType = jsNative
    let [<Global>] AudioWorkerNodeProcessor: AudioWorkerNodeProcessorType = jsNative
    let [<Global>] BarProp: BarPropType = jsNative
    let [<Global>] BeforeUnloadEvent: BeforeUnloadEventType = jsNative
    let [<Global>] BiquadFilterNode: BiquadFilterNodeType = jsNative
    let [<Global>] Blob: BlobType = jsNative
    let [<Global>] CDATASection: CDATASectionType = jsNative
    // let [<Global>] CSS: CSS = jsNative
    // let [<Global>] CSSConditionRule: CSSConditionRuleType = jsNative
    // let [<Global>] CSSFontFaceRule: CSSFontFaceRuleType = jsNative
    // let [<Global>] CSSGroupingRule: CSSGroupingRuleType = jsNative
    // let [<Global>] CSSImportRule: CSSImportRuleType = jsNative
    // let [<Global>] CSSKeyframeRule: CSSKeyframeRuleType = jsNative
    // let [<Global>] CSSKeyframesRule: CSSKeyframesRuleType = jsNative
    // let [<Global>] CSSMediaRule: CSSMediaRuleType = jsNative
    // let [<Global>] CSSNamespaceRule: CSSNamespaceRuleType = jsNative
    // let [<Global>] CSSPageRule: CSSPageRuleType = jsNative
    // let [<Global>] CSSRule: CSSRuleType = jsNative
    // let [<Global>] CSSRuleList: CSSRuleListType = jsNative
    // let [<Global>] CSSStyleDeclaration: CSSStyleDeclarationType = jsNative
    // let [<Global>] CSSStyleRule: CSSStyleRuleType = jsNative
    // let [<Global>] CSSStyleSheet: CSSStyleSheetType = jsNative
    // let [<Global>] CSSSupportsRule: CSSSupportsRuleType = jsNative
    let [<Global>] CanvasGradient: CanvasGradientType = jsNative
    let [<Global>] CanvasPattern: CanvasPatternType = jsNative
    let [<Global>] CanvasRenderingContext2D: CanvasRenderingContext2DType = jsNative
    let [<Global>] ChannelMergerNode: ChannelMergerNodeType = jsNative
    let [<Global>] ChannelSplitterNode: ChannelSplitterNodeType = jsNative
    let [<Global>] CharacterData: CharacterDataType = jsNative
    let [<Global>] ClientRect: ClientRectType = jsNative
    let [<Global>] ClientRectList: ClientRectListType = jsNative
    let [<Global>] ClipboardEvent: ClipboardEventType = jsNative
    let [<Global>] CloseEvent: CloseEventType = jsNative
    let [<Global>] CommandEvent: CommandEventType = jsNative
    let [<Global>] Comment: CommentType = jsNative
    let [<Global>] CompositionEvent: CompositionEventType = jsNative
    let [<Global>] Console: ConsoleType = jsNative
    let [<Global>] ConvolverNode: ConvolverNodeType = jsNative
    let [<Global>] Coordinates: CoordinatesType = jsNative
    let [<Global>] Crypto: CryptoType = jsNative
    let [<Global>] CryptoKey: CryptoKeyType = jsNative
    let [<Global>] CryptoKeyPair: CryptoKeyPairType = jsNative
    let [<Global>] CustomEvent: CustomEventType = jsNative
    let [<Global>] DOMError: DOMErrorType = jsNative
    let [<Global>] DOMException: DOMExceptionType = jsNative
    let [<Global>] DOMImplementation: DOMImplementationType = jsNative
    let [<Global>] DOMParser: DOMParserType = jsNative
    let [<Global>] DOMSettableTokenList: DOMSettableTokenListType = jsNative
    let [<Global>] DOMStringList: DOMStringListType = jsNative
    let [<Global>] DOMStringMap: DOMStringMapType = jsNative
    let [<Global>] DOMTokenList: DOMTokenListType = jsNative
    let [<Global>] DataCue: DataCueType = jsNative
    let [<Global>] DataTransfer: DataTransferType = jsNative
    let [<Global>] DataTransferItem: DataTransferItemType = jsNative
    let [<Global>] DataTransferItemList: DataTransferItemListType = jsNative
    let [<Global>] DeferredPermissionRequest: DeferredPermissionRequestType = jsNative
    let [<Global>] DelayNode: DelayNodeType = jsNative
    let [<Global>] DeviceAcceleration: DeviceAccelerationType = jsNative
    let [<Global>] DeviceMotionEvent: DeviceMotionEventType = jsNative
    let [<Global>] DeviceOrientationEvent: DeviceOrientationEventType = jsNative
    let [<Global>] DeviceRotationRate: DeviceRotationRateType = jsNative
    let [<Global>] Document: DocumentType = jsNative
    let [<Global>] DocumentFragment: DocumentFragmentType = jsNative
    let [<Global>] DocumentType: DocumentTypeType = jsNative
    let [<Global>] DragEvent: DragEventType = jsNative
    let [<Global>] DynamicsCompressorNode: DynamicsCompressorNodeType = jsNative
    let [<Global>] Element: ElementType = jsNative
    let [<Global>] ErrorEvent: ErrorEventType = jsNative
    let [<Global>] Event: EventType = jsNative
    let [<Global>] EventTarget: EventTargetType = jsNative
    let [<Global>] External: ExternalType = jsNative
    let [<Global>] File: FileType = jsNative
    let [<Global>] FileList: FileListType = jsNative
    let [<Global>] FileReader: FileReaderType = jsNative
    let [<Global>] FocusEvent: FocusEventType = jsNative
    let [<Global>] FormData: FormDataType = jsNative
    let [<Global>] GainNode: GainNodeType = jsNative
    let [<Global>] Gamepad: GamepadType = jsNative
    let [<Global>] GamepadButton: GamepadButtonType = jsNative
    let [<Global>] GamepadEvent: GamepadEventType = jsNative
    let [<Global>] Geolocation: GeolocationType = jsNative
    let [<Global>] HTMLAllCollection: HTMLAllCollectionType = jsNative
    let [<Global>] HTMLAnchorElement: HTMLAnchorElementType = jsNative
    let [<Global>] HTMLAppletElement: HTMLAppletElementType = jsNative
    let [<Global>] HTMLAreaElement: HTMLAreaElementType = jsNative
    let [<Global>] HTMLAreasCollection: HTMLAreasCollectionType = jsNative
    let [<Global>] HTMLAudioElement: HTMLAudioElementType = jsNative
    let [<Global>] HTMLBRElement: HTMLBRElementType = jsNative
    let [<Global>] HTMLBaseElement: HTMLBaseElementType = jsNative
    let [<Global>] HTMLBaseFontElement: HTMLBaseFontElementType = jsNative
    let [<Global>] HTMLBlockElement: HTMLBlockElementType = jsNative
    let [<Global>] HTMLBodyElement: HTMLBodyElementType = jsNative
    let [<Global>] HTMLButtonElement: HTMLButtonElementType = jsNative
    let [<Global>] HTMLCanvasElement: HTMLCanvasElementType = jsNative
    let [<Global>] HTMLCollection: HTMLCollectionType = jsNative
    let [<Global>] HTMLDDElement: HTMLDDElementType = jsNative
    let [<Global>] HTMLDListElement: HTMLDListElementType = jsNative
    let [<Global>] HTMLDTElement: HTMLDTElementType = jsNative
    let [<Global>] HTMLDataListElement: HTMLDataListElementType = jsNative
    let [<Global>] HTMLDirectoryElement: HTMLDirectoryElementType = jsNative
    let [<Global>] HTMLDivElement: HTMLDivElementType = jsNative
    let [<Global>] HTMLDocument: HTMLDocumentType = jsNative
    let [<Global>] HTMLElement: HTMLElementType = jsNative
    let [<Global>] HTMLEmbedElement: HTMLEmbedElementType = jsNative
    let [<Global>] HTMLFieldSetElement: HTMLFieldSetElementType = jsNative
    let [<Global>] HTMLFontElement: HTMLFontElementType = jsNative
    let [<Global>] HTMLFormElement: HTMLFormElementType = jsNative
    let [<Global>] HTMLFrameElement: HTMLFrameElementType = jsNative
    let [<Global>] HTMLFrameSetElement: HTMLFrameSetElementType = jsNative
    let [<Global>] HTMLHRElement: HTMLHRElementType = jsNative
    let [<Global>] HTMLHeadElement: HTMLHeadElementType = jsNative
    let [<Global>] HTMLHeadingElement: HTMLHeadingElementType = jsNative
    let [<Global>] HTMLHtmlElement: HTMLHtmlElementType = jsNative
    let [<Global>] HTMLIFrameElement: HTMLIFrameElementType = jsNative
    let [<Global>] HTMLImageElement: HTMLImageElementType = jsNative
    let [<Global>] HTMLInputElement: HTMLInputElementType = jsNative
    let [<Global>] HTMLIsIndexElement: HTMLIsIndexElementType = jsNative
    let [<Global>] HTMLLIElement: HTMLLIElementType = jsNative
    let [<Global>] HTMLLabelElement: HTMLLabelElementType = jsNative
    let [<Global>] HTMLLegendElement: HTMLLegendElementType = jsNative
    let [<Global>] HTMLLinkElement: HTMLLinkElementType = jsNative
    let [<Global>] HTMLMapElement: HTMLMapElementType = jsNative
    let [<Global>] HTMLMarqueeElement: HTMLMarqueeElementType = jsNative
    let [<Global>] HTMLMediaElement: HTMLMediaElementType = jsNative
    let [<Global>] HTMLMenuElement: HTMLMenuElementType = jsNative
    let [<Global>] HTMLMetaElement: HTMLMetaElementType = jsNative
    let [<Global>] HTMLModElement: HTMLModElementType = jsNative
    let [<Global>] HTMLNextIdElement: HTMLNextIdElementType = jsNative
    let [<Global>] HTMLOListElement: HTMLOListElementType = jsNative
    let [<Global>] HTMLObjectElement: HTMLObjectElementType = jsNative
    let [<Global>] HTMLOptGroupElement: HTMLOptGroupElementType = jsNative
    let [<Global>] HTMLOptionElement: HTMLOptionElementType = jsNative
    let [<Global>] HTMLParagraphElement: HTMLParagraphElementType = jsNative
    let [<Global>] HTMLParamElement: HTMLParamElementType = jsNative
    let [<Global>] HTMLPhraseElement: HTMLPhraseElementType = jsNative
    let [<Global>] HTMLPreElement: HTMLPreElementType = jsNative
    let [<Global>] HTMLProgressElement: HTMLProgressElementType = jsNative
    let [<Global>] HTMLQuoteElement: HTMLQuoteElementType = jsNative
    let [<Global>] HTMLScriptElement: HTMLScriptElementType = jsNative
    let [<Global>] HTMLSelectElement: HTMLSelectElementType = jsNative
    let [<Global>] HTMLSourceElement: HTMLSourceElementType = jsNative
    let [<Global>] HTMLSpanElement: HTMLSpanElementType = jsNative
    let [<Global>] HTMLStyleElement: HTMLStyleElementType = jsNative
    let [<Global>] HTMLTableCaptionElement: HTMLTableCaptionElementType = jsNative
    let [<Global>] HTMLTableCellElement: HTMLTableCellElementType = jsNative
    let [<Global>] HTMLTableColElement: HTMLTableColElementType = jsNative
    let [<Global>] HTMLTableDataCellElement: HTMLTableDataCellElementType = jsNative
    let [<Global>] HTMLTableElement: HTMLTableElementType = jsNative
    let [<Global>] HTMLTableHeaderCellElement: HTMLTableHeaderCellElementType = jsNative
    let [<Global>] HTMLTableRowElement: HTMLTableRowElementType = jsNative
    let [<Global>] HTMLTableSectionElement: HTMLTableSectionElementType = jsNative
    let [<Global>] HTMLTextAreaElement: HTMLTextAreaElementType = jsNative
    let [<Global>] HTMLTitleElement: HTMLTitleElementType = jsNative
    let [<Global>] HTMLTrackElement: HTMLTrackElementType = jsNative
    let [<Global>] HTMLUListElement: HTMLUListElementType = jsNative
    let [<Global>] HTMLUnknownElement: HTMLUnknownElementType = jsNative
    let [<Global>] HTMLVideoElement: HTMLVideoElementType = jsNative
    let [<Global>] HashChangeEvent: HashChangeEventType = jsNative
    let [<Global>] History: HistoryType = jsNative
    // let [<Global>] IDBCursor: IDBCursorType = jsNative
    // let [<Global>] IDBCursorWithValue: IDBCursorWithValueType = jsNative
    // let [<Global>] IDBDatabase: IDBDatabaseType = jsNative
    // let [<Global>] IDBFactory: IDBFactoryType = jsNative
    // let [<Global>] IDBIndex: IDBIndexType = jsNative
    // let [<Global>] IDBKeyRange: IDBKeyRangeType = jsNative
    // let [<Global>] IDBObjectStore: IDBObjectStoreType = jsNative
    // let [<Global>] IDBOpenDBRequest: IDBOpenDBRequestType = jsNative
    // let [<Global>] IDBRequest: IDBRequestType = jsNative
    // let [<Global>] IDBTransaction: IDBTransactionType = jsNative
    // let [<Global>] IDBVersionChangeEvent: IDBVersionChangeEventType = jsNative
    let [<Global>] IIRFilterNode: IIRFilterNodeType = jsNative
    let [<Global>] ImageData: ImageDataType = jsNative
    let [<Global>] KeyboardEvent: KeyboardEventType = jsNative
    let [<Global>] Location: LocationType = jsNative
    let [<Global>] LongRunningScriptDetectedEvent: LongRunningScriptDetectedEventType = jsNative
    let [<Global>] MediaElementAudioSourceNode: MediaElementAudioSourceNodeType = jsNative
    let [<Global>] MediaError: MediaErrorType = jsNative
    let [<Global>] MediaList: MediaListType = jsNative
    let [<Global>] MediaQueryList: MediaQueryListType = jsNative
    let [<Global>] MediaSource: MediaSourceType = jsNative
    let [<Global>] MediaStream: MediaStreamType = jsNative
    let [<Global>] MediaStreamAudioDestinationNode: MediaStreamAudioDestinationNodeType = jsNative
    let [<Global>] MediaStreamAudioSourceNode: MediaStreamAudioSourceNodeType = jsNative
    let [<Global>] MessageChannel: MessageChannelType = jsNative
    let [<Global>] MessageEvent: MessageEventType = jsNative
    let [<Global>] MessagePort: MessagePortType = jsNative
    let [<Global>] MimeType: MimeTypeType = jsNative
    let [<Global>] MimeTypeArray: MimeTypeArrayType = jsNative
    let [<Global>] MouseEvent: MouseEventType = jsNative
    let [<Global>] MouseWheelEvent: MouseWheelEventType = jsNative
    let [<Global>] NamedNodeMap: NamedNodeMapType = jsNative
    let [<Global>] NavigationCompletedEvent: NavigationCompletedEventType = jsNative
    let [<Global>] NavigationEvent: NavigationEventType = jsNative
    let [<Global>] NavigationEventWithReferrer: NavigationEventWithReferrerType = jsNative
    let [<Global>] Navigator: NavigatorType = jsNative
    let [<Global>] Node: NodeType = jsNative
    let [<Global>] NodeFilter: NodeFilterType = jsNative
    let [<Global>] NodeIterator: NodeIteratorType = jsNative
    let [<Global>] NodeList: NodeListType = jsNative
    let [<Global>] OES_element_index_uint: OES_element_index_uintType = jsNative
    let [<Global>] OES_standard_derivatives: OES_standard_derivativesType = jsNative
    let [<Global>] OES_texture_float: OES_texture_floatType = jsNative
    let [<Global>] OES_texture_float_linear: OES_texture_float_linearType = jsNative
    let [<Global>] OfflineAudioCompletionEvent: OfflineAudioCompletionEventType = jsNative
    let [<Global>] OfflineAudioContext: OfflineAudioContextType = jsNative
    let [<Global>] OscillatorNode: OscillatorNodeType = jsNative
    let [<Global>] PageTransitionEvent: PageTransitionEventType = jsNative
    let [<Global>] PannerNode: PannerNodeType = jsNative
    let [<Global>] PerfWidgetExternal: PerfWidgetExternalType = jsNative
    let [<Global>] Performance: PerformanceType = jsNative
    let [<Global>] PerformanceEntry: PerformanceEntryType = jsNative
    let [<Global>] PerformanceMark: PerformanceMarkType = jsNative
    let [<Global>] PerformanceMeasure: PerformanceMeasureType = jsNative
    let [<Global>] PerformanceNavigation: PerformanceNavigationType = jsNative
    let [<Global>] PerformanceNavigationTiming: PerformanceNavigationTimingType = jsNative
    let [<Global>] PerformanceResourceTiming: PerformanceResourceTimingType = jsNative
    let [<Global>] PerformanceTiming: PerformanceTimingType = jsNative
    let [<Global>] PeriodicWave: PeriodicWaveType = jsNative
    let [<Global>] PermissionRequest: PermissionRequestType = jsNative
    let [<Global>] PermissionRequestedEvent: PermissionRequestedEventType = jsNative
    let [<Global>] Plugin: PluginType = jsNative
    let [<Global>] PluginArray: PluginArrayType = jsNative
    let [<Global>] PointerEvent: PointerEventType = jsNative
    let [<Global>] PopStateEvent: PopStateEventType = jsNative
    let [<Global>] Position: PositionType = jsNative
    let [<Global>] PositionError: PositionErrorType = jsNative
    let [<Global>] ProcessingInstruction: ProcessingInstructionType = jsNative
    let [<Global>] ProgressEvent: ProgressEventType = jsNative
    let [<Global>] Range: RangeType = jsNative
    // let [<Global>] SVGAElement: SVGAElementType = jsNative
    // let [<Global>] SVGAngle: SVGAngleType = jsNative
    // let [<Global>] SVGAnimatedAngle: SVGAnimatedAngleType = jsNative
    // let [<Global>] SVGAnimatedBoolean: SVGAnimatedBooleanType = jsNative
    // let [<Global>] SVGAnimatedEnumeration: SVGAnimatedEnumerationType = jsNative
    // let [<Global>] SVGAnimatedInteger: SVGAnimatedIntegerType = jsNative
    // let [<Global>] SVGAnimatedLength: SVGAnimatedLengthType = jsNative
    // let [<Global>] SVGAnimatedLengthList: SVGAnimatedLengthListType = jsNative
    // let [<Global>] SVGAnimatedNumber: SVGAnimatedNumberType = jsNative
    // let [<Global>] SVGAnimatedNumberList: SVGAnimatedNumberListType = jsNative
    // let [<Global>] SVGAnimatedPreserveAspectRatio: SVGAnimatedPreserveAspectRatioType = jsNative
    // let [<Global>] SVGAnimatedRect: SVGAnimatedRectType = jsNative
    // let [<Global>] SVGAnimatedString: SVGAnimatedStringType = jsNative
    // let [<Global>] SVGAnimatedTransformList: SVGAnimatedTransformListType = jsNative
    // let [<Global>] SVGCircleElement: SVGCircleElementType = jsNative
    // let [<Global>] SVGClipPathElement: SVGClipPathElementType = jsNative
    // let [<Global>] SVGComponentTransferFunctionElement: SVGComponentTransferFunctionElementType = jsNative
    // let [<Global>] SVGDefsElement: SVGDefsElementType = jsNative
    // let [<Global>] SVGDescElement: SVGDescElementType = jsNative
    // let [<Global>] SVGElement: SVGElementType = jsNative
    // let [<Global>] SVGElementInstance: SVGElementInstanceType = jsNative
    // let [<Global>] SVGElementInstanceList: SVGElementInstanceListType = jsNative
    // let [<Global>] SVGEllipseElement: SVGEllipseElementType = jsNative
    // let [<Global>] SVGFEBlendElement: SVGFEBlendElementType = jsNative
    // let [<Global>] SVGFEColorMatrixElement: SVGFEColorMatrixElementType = jsNative
    // let [<Global>] SVGFEComponentTransferElement: SVGFEComponentTransferElementType = jsNative
    // let [<Global>] SVGFECompositeElement: SVGFECompositeElementType = jsNative
    // let [<Global>] SVGFEConvolveMatrixElement: SVGFEConvolveMatrixElementType = jsNative
    // let [<Global>] SVGFEDiffuseLightingElement: SVGFEDiffuseLightingElementType = jsNative
    // let [<Global>] SVGFEDisplacementMapElement: SVGFEDisplacementMapElementType = jsNative
    // let [<Global>] SVGFEDistantLightElement: SVGFEDistantLightElementType = jsNative
    // let [<Global>] SVGFEFloodElement: SVGFEFloodElementType = jsNative
    // let [<Global>] SVGFEFuncAElement: SVGFEFuncAElementType = jsNative
    // let [<Global>] SVGFEFuncBElement: SVGFEFuncBElementType = jsNative
    // let [<Global>] SVGFEFuncGElement: SVGFEFuncGElementType = jsNative
    // let [<Global>] SVGFEFuncRElement: SVGFEFuncRElementType = jsNative
    // let [<Global>] SVGFEGaussianBlurElement: SVGFEGaussianBlurElementType = jsNative
    // let [<Global>] SVGFEImageElement: SVGFEImageElementType = jsNative
    // let [<Global>] SVGFEMergeElement: SVGFEMergeElementType = jsNative
    // let [<Global>] SVGFEMergeNodeElement: SVGFEMergeNodeElementType = jsNative
    // let [<Global>] SVGFEMorphologyElement: SVGFEMorphologyElementType = jsNative
    // let [<Global>] SVGFEOffsetElement: SVGFEOffsetElementType = jsNative
    // let [<Global>] SVGFEPointLightElement: SVGFEPointLightElementType = jsNative
    // let [<Global>] SVGFESpecularLightingElement: SVGFESpecularLightingElementType = jsNative
    // let [<Global>] SVGFESpotLightElement: SVGFESpotLightElementType = jsNative
    // let [<Global>] SVGFETileElement: SVGFETileElementType = jsNative
    // let [<Global>] SVGFETurbulenceElement: SVGFETurbulenceElementType = jsNative
    // let [<Global>] SVGFilterElement: SVGFilterElementType = jsNative
    // let [<Global>] SVGForeignObjectElement: SVGForeignObjectElementType = jsNative
    // let [<Global>] SVGGElement: SVGGElementType = jsNative
    // let [<Global>] SVGGradientElement: SVGGradientElementType = jsNative
    // let [<Global>] SVGImageElement: SVGImageElementType = jsNative
    // let [<Global>] SVGLength: SVGLengthType = jsNative
    // let [<Global>] SVGLengthList: SVGLengthListType = jsNative
    // let [<Global>] SVGLineElement: SVGLineElementType = jsNative
    // let [<Global>] SVGLinearGradientElement: SVGLinearGradientElementType = jsNative
    // let [<Global>] SVGMarkerElement: SVGMarkerElementType = jsNative
    // let [<Global>] SVGMaskElement: SVGMaskElementType = jsNative
    // let [<Global>] SVGMatrix: SVGMatrixType = jsNative
    // let [<Global>] SVGMetadataElement: SVGMetadataElementType = jsNative
    // let [<Global>] SVGNumber: SVGNumberType = jsNative
    // let [<Global>] SVGNumberList: SVGNumberListType = jsNative
    // let [<Global>] SVGPathElement: SVGPathElementType = jsNative
    // let [<Global>] SVGPathSeg: SVGPathSegType = jsNative
    // let [<Global>] SVGPathSegArcAbs: SVGPathSegArcAbsType = jsNative
    // let [<Global>] SVGPathSegArcRel: SVGPathSegArcRelType = jsNative
    // let [<Global>] SVGPathSegClosePath: SVGPathSegClosePathType = jsNative
    // let [<Global>] SVGPathSegCurvetoCubicAbs: SVGPathSegCurvetoCubicAbsType = jsNative
    // let [<Global>] SVGPathSegCurvetoCubicRel: SVGPathSegCurvetoCubicRelType = jsNative
    // let [<Global>] SVGPathSegCurvetoCubicSmoothAbs: SVGPathSegCurvetoCubicSmoothAbsType = jsNative
    // let [<Global>] SVGPathSegCurvetoCubicSmoothRel: SVGPathSegCurvetoCubicSmoothRelType = jsNative
    // let [<Global>] SVGPathSegCurvetoQuadraticAbs: SVGPathSegCurvetoQuadraticAbsType = jsNative
    // let [<Global>] SVGPathSegCurvetoQuadraticRel: SVGPathSegCurvetoQuadraticRelType = jsNative
    // let [<Global>] SVGPathSegCurvetoQuadraticSmoothAbs: SVGPathSegCurvetoQuadraticSmoothAbsType = jsNative
    // let [<Global>] SVGPathSegCurvetoQuadraticSmoothRel: SVGPathSegCurvetoQuadraticSmoothRelType = jsNative
    // let [<Global>] SVGPathSegLinetoAbs: SVGPathSegLinetoAbsType = jsNative
    // let [<Global>] SVGPathSegLinetoHorizontalAbs: SVGPathSegLinetoHorizontalAbsType = jsNative
    // let [<Global>] SVGPathSegLinetoHorizontalRel: SVGPathSegLinetoHorizontalRelType = jsNative
    // let [<Global>] SVGPathSegLinetoRel: SVGPathSegLinetoRelType = jsNative
    // let [<Global>] SVGPathSegLinetoVerticalAbs: SVGPathSegLinetoVerticalAbsType = jsNative
    // let [<Global>] SVGPathSegLinetoVerticalRel: SVGPathSegLinetoVerticalRelType = jsNative
    // let [<Global>] SVGPathSegList: SVGPathSegListType = jsNative
    // let [<Global>] SVGPathSegMovetoAbs: SVGPathSegMovetoAbsType = jsNative
    // let [<Global>] SVGPathSegMovetoRel: SVGPathSegMovetoRelType = jsNative
    // let [<Global>] SVGPatternElement: SVGPatternElementType = jsNative
    // let [<Global>] SVGPoint: SVGPointType = jsNative
    // let [<Global>] SVGPointList: SVGPointListType = jsNative
    // let [<Global>] SVGPolygonElement: SVGPolygonElementType = jsNative
    // let [<Global>] SVGPolylineElement: SVGPolylineElementType = jsNative
    // let [<Global>] SVGPreserveAspectRatio: SVGPreserveAspectRatioType = jsNative
    // let [<Global>] SVGRadialGradientElement: SVGRadialGradientElementType = jsNative
    // let [<Global>] SVGRect: SVGRectType = jsNative
    // let [<Global>] SVGRectElement: SVGRectElementType = jsNative
    // let [<Global>] SVGSVGElement: SVGSVGElementType = jsNative
    // let [<Global>] SVGScriptElement: SVGScriptElementType = jsNative
    // let [<Global>] SVGStopElement: SVGStopElementType = jsNative
    // let [<Global>] SVGStringList: SVGStringListType = jsNative
    // let [<Global>] SVGStyleElement: SVGStyleElementType = jsNative
    // let [<Global>] SVGSwitchElement: SVGSwitchElementType = jsNative
    // let [<Global>] SVGSymbolElement: SVGSymbolElementType = jsNative
    // let [<Global>] SVGTSpanElement: SVGTSpanElementType = jsNative
    // let [<Global>] SVGTextContentElement: SVGTextContentElementType = jsNative
    // let [<Global>] SVGTextElement: SVGTextElementType = jsNative
    // let [<Global>] SVGTextPathElement: SVGTextPathElementType = jsNative
    // let [<Global>] SVGTextPositioningElement: SVGTextPositioningElementType = jsNative
    // let [<Global>] SVGTitleElement: SVGTitleElementType = jsNative
    // let [<Global>] SVGTransform: SVGTransformType = jsNative
    // let [<Global>] SVGTransformList: SVGTransformListType = jsNative
    // let [<Global>] SVGUnitTypes: SVGUnitTypes = jsNative
    // let [<Global>] SVGUseElement: SVGUseElementType = jsNative
    // let [<Global>] SVGViewElement: SVGViewElementType = jsNative
    // let [<Global>] SVGZoomAndPan: SVGZoomAndPanType = jsNative
    // let [<Global>] SVGZoomEvent: SVGZoomEventType = jsNative
    let [<Global>] Screen: ScreenType = jsNative
    let [<Global>] ScriptNotifyEvent: ScriptNotifyEventType = jsNative
    let [<Global>] ScriptProcessorNode: ScriptProcessorNodeType = jsNative
    let [<Global>] Selection: SelectionType = jsNative
    let [<Global>] SourceBuffer: SourceBufferType = jsNative
    let [<Global>] SourceBufferList: SourceBufferListType = jsNative
    let [<Global>] SpatialListener: SpatialListenerType = jsNative
    let [<Global>] SpatialPannerNode: SpatialPannerNodeType = jsNative
    let [<Global>] StereoPannerNode: StereoPannerNodeType = jsNative
    let [<Global>] Storage: StorageType = jsNative
    let [<Global>] StorageEvent: StorageEventType = jsNative
    let [<Global>] StyleMedia: StyleMediaType = jsNative
    // let [<Global>] StyleSheet: StyleSheetType = jsNative
    // let [<Global>] StyleSheetList: StyleSheetListType = jsNative
    // let [<Global>] StyleSheetPageList: StyleSheetPageListType = jsNative
    let [<Global>] SubtleCrypto: SubtleCryptoType = jsNative
    let [<Global>] Text: TextType = jsNative
    let [<Global>] TextEvent: TextEventType = jsNative
    let [<Global>] TextMetrics: TextMetricsType = jsNative
    let [<Global>] TextRange: TextRangeType = jsNative
    let [<Global>] TextRangeCollection: TextRangeCollectionType = jsNative
    let [<Global>] TextTrack: TextTrackType = jsNative
    let [<Global>] TextTrackCue: TextTrackCueType = jsNative
    let [<Global>] TextTrackCueList: TextTrackCueListType = jsNative
    let [<Global>] TextTrackList: TextTrackListType = jsNative
    let [<Global>] TimeRanges: TimeRangesType = jsNative
    let [<Global>] Touch: TouchType = jsNative
    let [<Global>] TouchEvent: TouchEventType = jsNative
    let [<Global>] TouchList: TouchListType = jsNative
    let [<Global>] TrackEvent: TrackEventType = jsNative
    let [<Global>] TransitionEvent: TransitionEventType = jsNative
    let [<Global>] TreeWalker: TreeWalkerType = jsNative
    let [<Global>] UIEvent: UIEventType = jsNative
    let [<Global>] UnviewableContentIdentifiedEvent: UnviewableContentIdentifiedEventType = jsNative
    let [<Global>] ValidityState: ValidityStateType = jsNative
    let [<Global>] VideoPlaybackQuality: VideoPlaybackQualityType = jsNative
    let [<Global>] VideoTrack: VideoTrackType = jsNative
    let [<Global>] VideoTrackList: VideoTrackListType = jsNative
    let [<Global>] WaveShaperNode: WaveShaperNodeType = jsNative
    // let [<Global>] WEBGL_compressed_texture_s3tc: WEBGL_compressed_texture_s3tcType = jsNative
    // let [<Global>] WEBGL_debug_renderer_info: WEBGL_debug_renderer_infoType = jsNative
    // let [<Global>] WEBGL_depth_texture: WEBGL_depth_textureType = jsNative
    // let [<Global>] WebGLActiveInfo: WebGLActiveInfoType = jsNative
    // let [<Global>] WebGLBuffer: WebGLBufferType = jsNative
    // let [<Global>] WebGLContextEvent: WebGLContextEventType = jsNative
    // let [<Global>] WebGLFramebuffer: WebGLFramebufferType = jsNative
    // let [<Global>] WebGLObject: WebGLObjectType = jsNative
    // let [<Global>] WebGLProgram: WebGLProgramType = jsNative
    // let [<Global>] WebGLRenderbuffer: WebGLRenderbufferType = jsNative
    // let [<Global>] WebGLRenderingContext: WebGLRenderingContextType = jsNative
    // let [<Global>] WebGLShader: WebGLShaderType = jsNative
    // let [<Global>] WebGLShaderPrecisionFormat: WebGLShaderPrecisionFormatType = jsNative
    // let [<Global>] WebGLTexture: WebGLTextureType = jsNative
    // let [<Global>] WebGLUniformLocation: WebGLUniformLocationType = jsNative
    // let [<Global>] EXT_texture_filter_anisotropic: EXT_texture_filter_anisotropicType = jsNative
    let [<Global>] WebSocket: WebSocketType = jsNative
    let [<Global>] WheelEvent: WheelEventType = jsNative
    let [<Global>] Window: WindowType = jsNative
    let [<Global>] Worker: WorkerType = jsNative
    let [<Global>] XMLDocument: XMLDocumentType = jsNative
    let [<Global>] XMLHttpRequest: XMLHttpRequestType = jsNative
    let [<Global>] XMLHttpRequestUpload: XMLHttpRequestUploadType = jsNative
    // let [<Global>] XMLSerializer: XMLSerializerType = jsNative
    // let [<Global>] XPathEvaluator: XPathEvaluatorType = jsNative
    // let [<Global>] XPathExpression: XPathExpressionType = jsNative
    // let [<Global>] XPathNSResolver: XPathNSResolverType = jsNative
    // let [<Global>] XPathResult: XPathResultType = jsNative
    let [<Global>] HTMLTemplateElement: HTMLTemplateElementType = jsNative
    let [<Global>] HTMLPictureElement: HTMLPictureElementType = jsNative
    let [<Global>] Audio: AudioType = jsNative
    let [<Global>] Image: ImageType = jsNative
    let [<Global>] Option: OptionType = jsNative
    let [<Global>] animationStartTime: float = jsNative
    let [<Global>] applicationCache: ApplicationCache = jsNative
    let [<Global>] clientInformation: Navigator = jsNative
    let [<Global>] closed: bool = jsNative
    let [<Global>] crypto: Crypto = jsNative
    let [<Global>] defaultStatus: string = jsNative
    let [<Global>] devicePixelRatio: float = jsNative
    let [<Global>] doNotTrack: string = jsNative
    let [<Global>] document: Document = jsNative
    let [<Global>] ``event``: Event = jsNative
    let [<Global>] ``external``: External = jsNative
    let [<Global>] frameElement: Element = jsNative
    let [<Global>] frames: Window = jsNative
    let [<Global>] history: History = jsNative
    let [<Global>] innerHeight: float = jsNative
    let [<Global>] innerWidth: float = jsNative
    let [<Global>] length: float = jsNative
    let [<Global>] location: Location = jsNative
    let [<Global>] locationbar: BarProp = jsNative
    let [<Global>] menubar: BarProp = jsNative
    let [<Global>] name: string = jsNative
    let [<Global>] navigator: Navigator = jsNative
    let [<Global>] offscreenBuffering: U2<string, bool> = jsNative
    let [<Global>] opener: Window = jsNative
    let [<Global>] orientation: U2<string, float> = jsNative
    let [<Global>] outerHeight: float = jsNative
    let [<Global>] outerWidth: float = jsNative
    let [<Global>] pageXOffset: float = jsNative
    let [<Global>] pageYOffset: float = jsNative
    let [<Global>] parent: Window = jsNative
    let [<Global>] performance: Performance = jsNative
    let [<Global>] personalbar: BarProp = jsNative
    let [<Global>] screen: Screen = jsNative
    let [<Global>] screenLeft: float = jsNative
    let [<Global>] screenTop: float = jsNative
    let [<Global>] screenX: float = jsNative
    let [<Global>] screenY: float = jsNative
    let [<Global>] scrollX: float = jsNative
    let [<Global>] scrollY: float = jsNative
    let [<Global>] scrollbars: BarProp = jsNative
    let [<Global>] self: Window = jsNative
    let [<Global>] status: string = jsNative
    let [<Global>] statusbar: BarProp = jsNative
    let [<Global>] styleMedia: StyleMedia = jsNative
    let [<Global>] toolbar: BarProp = jsNative
    let [<Global>] top: Window = jsNative
    let [<Global>] window: Window = jsNative
    let [<Global>] URL: URLType = jsNative
    let [<Global>] URLSearchParams: URLSearchParamsType = jsNative
    let [<Global>] sessionStorage: Storage = jsNative
    let [<Global>] localStorage: Storage = jsNative
    let [<Global>] console: Console = jsNative
    // let [<Global>] indexedDB: IDBFactory = jsNative
    let [<Global>] Headers: Headers = jsNative
    let [<Global>] Response: Response = jsNative
    let [<Global>] Request: Request = jsNative
    let [<Global>] caches: CacheStorage = jsNative
//    let [<Global>] clients: Clients = jsNative
    let [<Global>] onactivate: (ExtendableEvent -> obj option) = jsNative
    let [<Global>] onfetch: (FetchEvent -> obj option) = jsNative
    let [<Global>] oninstall: (ExtendableEvent -> obj option) = jsNative
    let [<Global>] onnotificationclick: (NotificationEvent -> obj option) = jsNative
    let [<Global>] onnotificationclose: (NotificationEvent -> obj option) = jsNative
    let [<Global>] onpush: (PushEvent -> obj option) = jsNative
    let [<Global>] onpushsubscriptionchange: (unit -> obj option) = jsNative
    let [<Global>] onsync: (SyncEvent -> obj option) = jsNative
    let [<Global>] registration: ServiceWorkerRegistration = jsNative


    [<Global>]
    module Intl =
        type [<AllowNullLiteral>] CollatorOptions =
            abstract usage: string option with get, set
            abstract localeMatcher: string option with get, set
            abstract numeric: bool option with get, set
            abstract caseFirst: string option with get, set
            abstract sensitivity: string option with get, set
            abstract ignorePunctuation: bool option with get, set

        and [<AllowNullLiteral>] ResolvedCollatorOptions =
            abstract locale: string with get, set
            abstract usage: string with get, set
            abstract sensitivity: string with get, set
            abstract ignorePunctuation: bool with get, set
            abstract collation: string with get, set
            abstract caseFirst: string with get, set
            abstract numeric: bool with get, set

        and [<AllowNullLiteral>] Collator =
            abstract compare: x: string * y: string -> float
            abstract resolvedOptions: unit -> ResolvedCollatorOptions

        and [<AllowNullLiteral>] CollatorType =
            [<Emit("new $0($1...)")>] abstract Create: ?locales: string[] * ?options: CollatorOptions -> Collator
            [<Emit("new $0($1...)")>] abstract Create: ?locale: string * ?options: CollatorOptions -> Collator
            [<Emit("$0($1...)")>] abstract Invoke: ?locales: string[] * ?options: CollatorOptions -> Collator
            [<Emit("$0($1...)")>] abstract Invoke: ?locale: string * ?options: CollatorOptions -> Collator
            abstract supportedLocalesOf: locales: string[] * ?options: CollatorOptions -> string[]
            abstract supportedLocalesOf: locale: string * ?options: CollatorOptions -> string[]

        and [<AllowNullLiteral>] NumberFormatOptions =
            abstract localeMatcher: string option with get, set
            abstract style: string option with get, set
            abstract currency: string option with get, set
            abstract currencyDisplay: string option with get, set
            abstract useGrouping: bool option with get, set
            abstract minimumIntegerDigits: float option with get, set
            abstract minimumFractionDigits: float option with get, set
            abstract maximumFractionDigits: float option with get, set
            abstract minimumSignificantDigits: float option with get, set
            abstract maximumSignificantDigits: float option with get, set

        and [<AllowNullLiteral>] ResolvedNumberFormatOptions =
            abstract locale: string with get, set
            abstract numberingSystem: string with get, set
            abstract style: string with get, set
            abstract currency: string option with get, set
            abstract currencyDisplay: string option with get, set
            abstract minimumIntegerDigits: float with get, set
            abstract minimumFractionDigits: float with get, set
            abstract maximumFractionDigits: float with get, set
            abstract minimumSignificantDigits: float option with get, set
            abstract maximumSignificantDigits: float option with get, set
            abstract useGrouping: bool with get, set

        and [<AllowNullLiteral>] NumberFormat =
            abstract format: value: float -> string
            abstract resolvedOptions: unit -> ResolvedNumberFormatOptions

        and [<AllowNullLiteral>] NumberFormatType =
            [<Emit("new $0($1...)")>] abstract Create: ?locales: string[] * ?options: NumberFormatOptions -> NumberFormat
            [<Emit("new $0($1...)")>] abstract Create: ?locale: string * ?options: NumberFormatOptions -> NumberFormat
            [<Emit("$0($1...)")>] abstract Invoke: ?locales: string[] * ?options: NumberFormatOptions -> NumberFormat
            [<Emit("$0($1...)")>] abstract Invoke: ?locale: string * ?options: NumberFormatOptions -> NumberFormat
            abstract supportedLocalesOf: locales: string[] * ?options: NumberFormatOptions -> string[]
            abstract supportedLocalesOf: locale: string * ?options: NumberFormatOptions -> string[]

        and [<AllowNullLiteral>] DateTimeFormatOptions =
            abstract localeMatcher: string option with get, set
            abstract weekday: string option with get, set
            abstract era: string option with get, set
            abstract year: string option with get, set
            abstract month: string option with get, set
            abstract day: string option with get, set
            abstract hour: string option with get, set
            abstract minute: string option with get, set
            abstract second: string option with get, set
            abstract timeZoneName: string option with get, set
            abstract formatMatcher: string option with get, set
            abstract hour12: bool option with get, set
            abstract timeZone: string option with get, set

        and [<AllowNullLiteral>] ResolvedDateTimeFormatOptions =
            abstract locale: string with get, set
            abstract calendar: string with get, set
            abstract numberingSystem: string with get, set
            abstract timeZone: string with get, set
            abstract hour12: bool option with get, set
            abstract weekday: string option with get, set
            abstract era: string option with get, set
            abstract year: string option with get, set
            abstract month: string option with get, set
            abstract day: string option with get, set
            abstract hour: string option with get, set
            abstract minute: string option with get, set
            abstract second: string option with get, set
            abstract timeZoneName: string option with get, set

        and [<AllowNullLiteral>] DateTimeFormat =
            abstract format: ?date: U2<DateTime, float> -> string
            abstract resolvedOptions: unit -> ResolvedDateTimeFormatOptions

        and [<AllowNullLiteral>] DateTimeFormatType =
            [<Emit("new $0($1...)")>] abstract Create: ?locales: string[] * ?options: DateTimeFormatOptions -> DateTimeFormat
            [<Emit("new $0($1...)")>] abstract Create: ?locale: string * ?options: DateTimeFormatOptions -> DateTimeFormat
            [<Emit("$0($1...)")>] abstract Invoke: ?locales: string[] * ?options: DateTimeFormatOptions -> DateTimeFormat
            [<Emit("$0($1...)")>] abstract Invoke: ?locale: string * ?options: DateTimeFormatOptions -> DateTimeFormat
            abstract supportedLocalesOf: locales: string[] * ?options: DateTimeFormatOptions -> string[]
            abstract supportedLocalesOf: locale: string * ?options: DateTimeFormatOptions -> string[]

        let Collator: CollatorType = jsNative
        let NumberFormat: NumberFormatType = jsNative
        let DateTimeFormat: DateTimeFormatType = jsNative


    // TODO
    // [<AutoOpen>]
    // module Extensions =
    //     type [<AllowNullLiteral>] String =
    //         abstract localeCompare: that: string * locales: string[] * ?options: Intl.CollatorOptions -> float
    //         abstract localeCompare: that: string * locale: string * ?options: Intl.CollatorOptions -> float

    //     and [<AllowNullLiteral>] Number =
    //         abstract toLocaleString: ?locales: string[] * ?options: Intl.NumberFormatOptions -> string
    //         abstract toLocaleString: ?locale: string * ?options: Intl.NumberFormatOptions -> string

    //     and [<AllowNullLiteral>] Date =
    //         abstract toLocaleString: ?locales: string[] * ?options: Intl.DateTimeFormatOptions -> string
    //         abstract toLocaleDateString: ?locales: string[] * ?options: Intl.DateTimeFormatOptions -> string
    //         abstract toLocaleTimeString: ?locale: string[] * ?options: Intl.DateTimeFormatOptions -> string
    //         abstract toLocaleString: ?locale: string * ?options: Intl.DateTimeFormatOptions -> string
    //         abstract toLocaleDateString: ?locale: string * ?options: Intl.DateTimeFormatOptions -> string
    //         abstract toLocaleTimeString: ?locale: string * ?options: Intl.DateTimeFormatOptions -> string

