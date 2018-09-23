namespace Fable.Import

open System
open Fable.Core
open Fable.Import.JS

module rec WebWorker =
    
    [<AllowNullLiteral>]
    type IExports =
        abstract close : unit -> unit
        abstract postMessage : message:obj * ?transfer:ResizeArray<Transferable> -> unit
        abstract msWriteProfilerMark : profilerMarkName:string -> unit
        abstract dispatchEvent : event:Event -> bool
        abstract importScripts : [<ParamArray>] urls:string -> unit
        abstract atob : encodedString:string -> string
        abstract btoa : rawString:string -> string
        abstract fetch : input:RequestInfo * ?init:RequestInit -> Promise<Response>
        abstract clearInterval : handle:float -> unit
        abstract clearTimeout : handle:float -> unit
        abstract createImageBitmap : image:ImageBitmapSource -> Promise<ImageBitmap>
        abstract createImageBitmap : image:ImageBitmapSource * sx:float * sy:float * sw:float * sh:float
         -> Promise<ImageBitmap>
        abstract queueMicrotask : callback:Function -> unit
        abstract setInterval : handler:TimerHandler * ?timeout:float * [<ParamArray>] arguments:obj -> float
        abstract setTimeout : handler:TimerHandler * ?timeout:float * [<ParamArray>] arguments:obj -> float
        abstract addEventListener : ``type``:'K * listener:(DedicatedWorkerGlobalScope -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(DedicatedWorkerGlobalScope -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<AllowNullLiteral>]
    type AddEventListenerOptions =
        inherit EventListenerOptions
        abstract once : bool option with get, set
        abstract passive : bool option with get, set
    
    [<AllowNullLiteral>]
    type AesCbcParams =
        inherit Algorithm
        abstract iv : obj with get, set
    
    [<AllowNullLiteral>]
    type AesCtrParams =
        inherit Algorithm
        abstract counter : obj with get, set
        abstract length : float with get, set
    
    [<AllowNullLiteral>]
    type AesDerivedKeyParams =
        inherit Algorithm
        abstract length : float with get, set
    
    [<AllowNullLiteral>]
    type AesGcmParams =
        inherit Algorithm
        abstract additionalData : obj option with get, set
        abstract iv : obj with get, set
        abstract tagLength : float option with get, set
    
    [<AllowNullLiteral>]
    type AesKeyAlgorithm =
        inherit KeyAlgorithm
        abstract length : float with get, set
    
    [<AllowNullLiteral>]
    type AesKeyGenParams =
        inherit Algorithm
        abstract length : float with get, set
    
    [<AllowNullLiteral>]
    type Algorithm =
        abstract name : string with get, set
    
    [<AllowNullLiteral>]
    type BlobPropertyBag =
        abstract ``type`` : string option with get, set
    
    [<AllowNullLiteral>]
    type CacheQueryOptions =
        abstract cacheName : string option with get, set
        abstract ignoreMethod : bool option with get, set
        abstract ignoreSearch : bool option with get, set
        abstract ignoreVary : bool option with get, set
    
    [<AllowNullLiteral>]
    type ClientQueryOptions =
        abstract includeUncontrolled : bool option with get, set
        abstract ``type`` : ClientTypes option with get, set
    
    [<AllowNullLiteral>]
    type CloseEventInit =
        inherit EventInit
        abstract code : float option with get, set
        abstract reason : string option with get, set
        abstract wasClean : bool option with get, set
    
    [<AllowNullLiteral>]
    type CryptoKeyPair =
        abstract privateKey : CryptoKey option with get, set
        abstract publicKey : CryptoKey option with get, set
    
    [<AllowNullLiteral>]
    type CustomEventInit<'T> =
        inherit EventInit
        abstract detail : 'T option with get, set
    
    [<AllowNullLiteral>]
    type DOMMatrix2DInit =
        abstract a : float option with get, set
        abstract b : float option with get, set
        abstract c : float option with get, set
        abstract d : float option with get, set
        abstract e : float option with get, set
        abstract f : float option with get, set
        abstract m11 : float option with get, set
        abstract m12 : float option with get, set
        abstract m21 : float option with get, set
        abstract m22 : float option with get, set
        abstract m41 : float option with get, set
        abstract m42 : float option with get, set
    
    [<AllowNullLiteral>]
    type DOMMatrixInit =
        inherit DOMMatrix2DInit
        abstract is2D : bool option with get, set
        abstract m13 : float option with get, set
        abstract m14 : float option with get, set
        abstract m23 : float option with get, set
        abstract m24 : float option with get, set
        abstract m31 : float option with get, set
        abstract m32 : float option with get, set
        abstract m33 : float option with get, set
        abstract m34 : float option with get, set
        abstract m43 : float option with get, set
        abstract m44 : float option with get, set
    
    [<AllowNullLiteral>]
    type DOMPointInit =
        abstract w : float option with get, set
        abstract x : float option with get, set
        abstract y : float option with get, set
        abstract z : float option with get, set
    
    [<AllowNullLiteral>]
    type DOMQuadInit =
        abstract p1 : DOMPointInit option with get, set
        abstract p2 : DOMPointInit option with get, set
        abstract p3 : DOMPointInit option with get, set
        abstract p4 : DOMPointInit option with get, set
    
    [<AllowNullLiteral>]
    type DOMRectInit =
        abstract height : float option with get, set
        abstract width : float option with get, set
        abstract x : float option with get, set
        abstract y : float option with get, set
    
    [<AllowNullLiteral>]
    type EcKeyGenParams =
        inherit Algorithm
        abstract namedCurve : NamedCurve with get, set
    
    [<AllowNullLiteral>]
    type EcKeyImportParams =
        inherit Algorithm
        abstract namedCurve : NamedCurve with get, set
    
    [<AllowNullLiteral>]
    type EcdhKeyDeriveParams =
        inherit Algorithm
        abstract ``public`` : CryptoKey with get, set
    
    [<AllowNullLiteral>]
    type EcdsaParams =
        inherit Algorithm
        abstract hash : HashAlgorithmIdentifier with get, set
    
    [<AllowNullLiteral>]
    type ErrorEventInit =
        inherit EventInit
        abstract colno : float option with get, set
        abstract error : obj option with get, set
        abstract filename : string option with get, set
        abstract lineno : float option with get, set
        abstract message : string option with get, set
    
    [<AllowNullLiteral>]
    type EventInit =
        abstract bubbles : bool option with get, set
        abstract cancelable : bool option with get, set
        abstract composed : bool option with get, set
    
    [<AllowNullLiteral>]
    type EventListenerOptions =
        abstract capture : bool option with get, set
    
    [<AllowNullLiteral>]
    type ExtendableEventInit =
        inherit EventInit
    
    [<AllowNullLiteral>]
    type ExtendableMessageEventInit =
        inherit ExtendableEventInit
        abstract data : obj option with get, set
        abstract lastEventId : string option with get, set
        abstract origin : string option with get, set
        abstract ports : ResizeArray<MessagePort> option with get, set
        abstract source : U3<Client, ServiceWorker, MessagePort> option option with get, set
    
    [<AllowNullLiteral>]
    type FetchEventInit =
        inherit ExtendableEventInit
        abstract clientId : string option with get, set
        abstract preloadResponse : Promise<obj> option with get, set
        abstract request : Request with get, set
        abstract resultingClientId : string option with get, set
        abstract targetClientId : string option with get, set
    
    [<AllowNullLiteral>]
    type FilePropertyBag =
        inherit BlobPropertyBag
        abstract lastModified : float option with get, set
    
    [<AllowNullLiteral>]
    type GetNotificationOptions =
        abstract tag : string option with get, set
    
    [<AllowNullLiteral>]
    type HmacImportParams =
        inherit Algorithm
        abstract hash : HashAlgorithmIdentifier with get, set
        abstract length : float option with get, set
    
    [<AllowNullLiteral>]
    type HmacKeyGenParams =
        inherit Algorithm
        abstract hash : HashAlgorithmIdentifier with get, set
        abstract length : float option with get, set
    
    [<AllowNullLiteral>]
    type IDBIndexParameters =
        abstract multiEntry : bool option with get, set
        abstract unique : bool option with get, set
    
    [<AllowNullLiteral>]
    type IDBObjectStoreParameters =
        abstract autoIncrement : bool option with get, set
        abstract keyPath : U2<string, ResizeArray<string>> option option with get, set
    
    [<AllowNullLiteral>]
    type IDBVersionChangeEventInit =
        inherit EventInit
        abstract newVersion : float option option with get, set
        abstract oldVersion : float option with get, set
    
    [<AllowNullLiteral>]
    type JsonWebKey =
        abstract alg : string option with get, set
        abstract crv : string option with get, set
        abstract d : string option with get, set
        abstract dp : string option with get, set
        abstract dq : string option with get, set
        abstract e : string option with get, set
        abstract ext : bool option with get, set
        abstract k : string option with get, set
        abstract key_ops : ResizeArray<string> option with get, set
        abstract kty : string option with get, set
        abstract n : string option with get, set
        abstract oth : ResizeArray<RsaOtherPrimesInfo> option with get, set
        abstract p : string option with get, set
        abstract q : string option with get, set
        abstract qi : string option with get, set
        abstract ``use`` : string option with get, set
        abstract x : string option with get, set
        abstract y : string option with get, set
    
    [<AllowNullLiteral>]
    type KeyAlgorithm =
        abstract name : string with get, set
    
    [<AllowNullLiteral>]
    type MessageEventInit =
        inherit EventInit
        abstract data : obj option with get, set
        abstract lastEventId : string option with get, set
        abstract origin : string option with get, set
        abstract ports : ResizeArray<MessagePort> option with get, set
        abstract source : MessageEventSource option option with get, set
    
    [<AllowNullLiteral>]
    type NavigationPreloadState =
        abstract enabled : bool option with get, set
        abstract headerValue : string option with get, set
    
    [<AllowNullLiteral>]
    type NotificationAction =
        abstract action : string with get, set
        abstract icon : string option with get, set
        abstract title : string with get, set
    
    [<AllowNullLiteral>]
    type NotificationEventInit =
        inherit ExtendableEventInit
        abstract action : string option with get, set
        abstract notification : Notification with get, set
    
    [<AllowNullLiteral>]
    type NotificationOptions =
        abstract actions : ResizeArray<NotificationAction> option with get, set
        abstract badge : string option with get, set
        abstract body : string option with get, set
        abstract data : obj option with get, set
        abstract dir : NotificationDirection option with get, set
        abstract icon : string option with get, set
        abstract image : string option with get, set
        abstract lang : string option with get, set
        abstract renotify : bool option with get, set
        abstract requireInteraction : bool option with get, set
        abstract silent : bool option with get, set
        abstract tag : string option with get, set
        abstract timestamp : float option with get, set
        abstract vibrate : VibratePattern option with get, set
    
    [<AllowNullLiteral>]
    type Pbkdf2Params =
        inherit Algorithm
        abstract hash : HashAlgorithmIdentifier with get, set
        abstract iterations : float with get, set
        abstract salt : obj with get, set
    
    [<AllowNullLiteral>]
    type PerformanceObserverInit =
        abstract buffered : bool option with get, set
        abstract entryTypes : ResizeArray<string> with get, set
    
    [<AllowNullLiteral>]
    type ProgressEventInit =
        inherit EventInit
        abstract lengthComputable : bool option with get, set
        abstract loaded : float option with get, set
        abstract total : float option with get, set
    
    [<AllowNullLiteral>]
    type PromiseRejectionEventInit =
        inherit EventInit
        abstract promise : Promise<obj> with get, set
        abstract reason : obj option with get, set
    
    [<AllowNullLiteral>]
    type PushEventInit =
        inherit ExtendableEventInit
        abstract data : PushMessageDataInit option with get, set
    
    [<AllowNullLiteral>]
    type PushSubscriptionChangeInit =
        inherit ExtendableEventInit
        abstract newSubscription : PushSubscription option with get, set
        abstract oldSubscription : PushSubscription option with get, set
    
    [<AllowNullLiteral>]
    type PushSubscriptionJSON =
        abstract endpoint : string option with get, set
        abstract expirationTime : float option option with get, set
        abstract keys : Map<string, string option> with get, set
    
    [<AllowNullLiteral>]
    type PushSubscriptionOptionsInit =
        abstract applicationServerKey : U2<BufferSource, string> option option with get, set
        abstract userVisibleOnly : bool option with get, set
    
    [<AllowNullLiteral>]
    type RegistrationOptions =
        abstract scope : string option with get, set
        abstract ``type`` : WorkerType option with get, set
        abstract updateViaCache : ServiceWorkerUpdateViaCache option with get, set
    
    [<AllowNullLiteral>]
    type RequestInit =
        abstract body : BodyInit option option with get, set
        abstract cache : RequestCache option with get, set
        abstract credentials : RequestCredentials option with get, set
        abstract headers : HeadersInit option with get, set
        abstract integrity : string option with get, set
        abstract keepalive : bool option with get, set
        abstract method : string option with get, set
        abstract mode : RequestMode option with get, set
        abstract redirect : RequestRedirect option with get, set
        abstract referrer : string option with get, set
        abstract referrerPolicy : ReferrerPolicy option with get, set
        abstract signal : AbortSignal option option with get, set
        abstract window : obj option with get, set
    
    [<AllowNullLiteral>]
    type ResponseInit =
        abstract headers : HeadersInit option with get, set
        abstract status : float option with get, set
        abstract statusText : string option with get, set
    
    [<AllowNullLiteral>]
    type RsaHashedImportParams =
        inherit Algorithm
        abstract hash : HashAlgorithmIdentifier with get, set
    
    [<AllowNullLiteral>]
    type RsaHashedKeyGenParams =
        inherit RsaKeyGenParams
        abstract hash : HashAlgorithmIdentifier with get, set
    
    [<AllowNullLiteral>]
    type RsaKeyGenParams =
        inherit Algorithm
        abstract modulusLength : float with get, set
        abstract publicExponent : BigInteger with get, set
    
    [<AllowNullLiteral>]
    type RsaOaepParams =
        inherit Algorithm
        abstract label : obj option with get, set
    
    [<AllowNullLiteral>]
    type RsaOtherPrimesInfo =
        abstract d : string option with get, set
        abstract r : string option with get, set
        abstract t : string option with get, set
    
    [<AllowNullLiteral>]
    type RsaPssParams =
        inherit Algorithm
        abstract saltLength : float with get, set
    
    [<AllowNullLiteral>]
    type StorageEstimate =
        abstract quota : float option with get, set
        abstract usage : float option with get, set
    
    [<AllowNullLiteral>]
    type SyncEventInit =
        inherit ExtendableEventInit
        abstract lastChance : bool option with get, set
        abstract tag : string with get, set
    
    [<AllowNullLiteral>]
    type TextDecodeOptions =
        abstract stream : bool option with get, set
    
    [<AllowNullLiteral>]
    type TextDecoderOptions =
        abstract fatal : bool option with get, set
        abstract ignoreBOM : bool option with get, set
    
    [<AllowNullLiteral>]
    type EventListener =
        [<Emit"$0($1...)">]
        abstract Invoke : evt:Event -> unit
    
    [<AllowNullLiteral>]
    type AbortController =
        abstract signal : AbortSignal with get, set
        abstract abort : unit -> unit
    
    [<Global>]
    let AbortController : obj = jsNative
    
    [<AllowNullLiteral>]
    type AbortSignalEventMap =
        abstract abort : ProgressEvent with get, set
    
    [<AllowNullLiteral>]
    type AbortSignal =
        inherit EventTarget
        abstract aborted : bool with get, set
        abstract onabort : obj option with get, set
        abstract addEventListener : ``type``:'K * listener:(AbortSignal -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(AbortSignal -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let AbortSignal : obj = jsNative
    
    [<AllowNullLiteral>]
    type AbstractWorkerEventMap =
        abstract error : ErrorEvent with get, set
    
    [<AllowNullLiteral>]
    type AbstractWorker =
        abstract onerror : obj option with get, set
        abstract addEventListener : ``type``:'K * listener:(AbstractWorker -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(AbstractWorker -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<AllowNullLiteral>]
    type AesCfbParams =
        inherit Algorithm
        abstract iv : obj with get, set
    
    [<AllowNullLiteral>]
    type AesCmacParams =
        inherit Algorithm
        abstract length : float with get, set
    
    [<AllowNullLiteral>]
    type Blob =
        abstract size : float with get, set
        abstract ``type`` : string with get, set
        abstract slice : ?start:float * ?``end``:float * ?contentType:string -> Blob
    
    [<Global>]
    let Blob : obj = jsNative
    
    [<AllowNullLiteral>]
    type Body =
        abstract body : ReadableStream option with get, set
        abstract bodyUsed : bool with get, set
        abstract arrayBuffer : unit -> Promise<ArrayBuffer>
        abstract blob : unit -> Promise<Blob>
        abstract formData : unit -> Promise<FormData>
        abstract json : unit -> Promise<obj>
        abstract text : unit -> Promise<string>
    
    [<AllowNullLiteral>]
    type BroadcastChannelEventMap =
        abstract message : MessageEvent with get, set
        abstract messageerror : MessageEvent with get, set
    
    [<AllowNullLiteral>]
    type BroadcastChannel =
        inherit EventTarget
        abstract name : string with get, set
        abstract onmessage : obj option with get, set
        abstract onmessageerror : obj option with get, set
        abstract close : unit -> unit
        abstract postMessage : message:obj -> unit
        abstract addEventListener : ``type``:'K * listener:(BroadcastChannel -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(BroadcastChannel -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let BroadcastChannel : obj = jsNative
    
    [<AllowNullLiteral>]
    type Cache =
        abstract add : request:RequestInfo -> Promise<unit>
        abstract addAll : requests:ResizeArray<RequestInfo> -> Promise<unit>
        abstract delete : request:RequestInfo * ?options:CacheQueryOptions -> Promise<bool>
        abstract keys : ?request:RequestInfo * ?options:CacheQueryOptions -> Promise<ReadonlyArray<Request>>
        abstract ``match`` : request:RequestInfo * ?options:CacheQueryOptions -> Promise<Response option>
        abstract matchAll : ?request:RequestInfo * ?options:CacheQueryOptions -> Promise<ReadonlyArray<Response>>
        abstract put : request:RequestInfo * response:Response -> Promise<unit>
    
    [<Global>]
    let Cache : obj = jsNative
    
    [<AllowNullLiteral>]
    type CacheStorage =
        abstract delete : cacheName:string -> Promise<bool>
        abstract has : cacheName:string -> Promise<bool>
        abstract keys : unit -> Promise<ResizeArray<string>>
        abstract ``match`` : request:RequestInfo * ?options:CacheQueryOptions -> Promise<Response option>
        abstract ``open`` : cacheName:string -> Promise<Cache>
    
    [<Global>]
    let CacheStorage : obj = jsNative
    
    [<AllowNullLiteral>]
    type CanvasGradient =
        abstract addColorStop : offset:float * color:string -> unit
    
    [<Global>]
    let CanvasGradient : obj = jsNative
    
    [<AllowNullLiteral>]
    type CanvasPath =
        abstract arc : x:float * y:float * radius:float * startAngle:float * endAngle:float * ?anticlockwise:bool
         -> unit
        abstract arcTo : x1:float * y1:float * x2:float * y2:float * radius:float -> unit
        abstract bezierCurveTo : cp1x:float * cp1y:float * cp2x:float * cp2y:float * x:float * y:float -> unit
        abstract closePath : unit -> unit
        abstract ellipse : x:float * y:float * radiusX:float * radiusY:float * rotation:float * startAngle:float * endAngle:float * ?anticlockwise:bool
         -> unit
        abstract lineTo : x:float * y:float -> unit
        abstract moveTo : x:float * y:float -> unit
        abstract quadraticCurveTo : cpx:float * cpy:float * x:float * y:float -> unit
        abstract rect : x:float * y:float * w:float * h:float -> unit
    
    [<AllowNullLiteral>]
    type CanvasPattern =
        abstract setTransform : transform:DOMMatrix2DInit -> unit
    
    [<Global>]
    let CanvasPattern : obj = jsNative
    
    [<AllowNullLiteral>]
    type Client =
        abstract id : string with get, set
        abstract ``type`` : ClientTypes with get, set
        abstract url : string with get, set
        abstract postMessage : message:obj * ?transfer:ResizeArray<Transferable> -> unit
    
    [<Global>]
    let Client : obj = jsNative
    
    [<AllowNullLiteral>]
    type Clients =
        abstract claim : unit -> Promise<unit>
        abstract get : id:string -> Promise<obj>
        abstract matchAll : options:ClientQueryOptions -> Promise<ReadonlyArray<Client>>
        abstract openWindow : url:string -> Promise<WindowClient option>
    
    [<Global>]
    let Clients : obj = jsNative
    
    [<AllowNullLiteral>]
    type CloseEvent =
        inherit Event
        abstract code : float with get, set
        abstract reason : string with get, set
        abstract wasClean : bool with get, set
        abstract initCloseEvent : typeArg:string * canBubbleArg:bool * cancelableArg:bool * wasCleanArg:bool * codeArg:float * reasonArg:string
         -> unit
    
    [<Global>]
    let CloseEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type ConcatParams =
        inherit Algorithm
        abstract algorithmId : Uint8Array with get, set
        abstract hash : U2<string, Algorithm> option with get, set
        abstract partyUInfo : Uint8Array with get, set
        abstract partyVInfo : Uint8Array with get, set
        abstract privateInfo : Uint8Array option with get, set
        abstract publicInfo : Uint8Array option with get, set
    
    [<AllowNullLiteral>]
    type Console =
        abstract memory : obj with get, set
        abstract ``assert`` : ?condition:bool * ?message:string * [<ParamArray>] data:obj -> unit
        abstract clear : unit -> unit
        abstract count : label:string -> unit
        abstract debug : ?message:obj * [<ParamArray>] optionalParams:obj -> unit
        abstract dir : ?value:obj * [<ParamArray>] optionalParams:obj -> unit
        abstract dirxml : value:obj -> unit
        abstract error : ?message:obj * [<ParamArray>] optionalParams:obj -> unit
        abstract ``exception`` : ?message:string * [<ParamArray>] optionalParams:obj -> unit
        abstract group : ?groupTitle:string * [<ParamArray>] optionalParams:obj -> unit
        abstract groupCollapsed : ?groupTitle:string * [<ParamArray>] optionalParams:obj -> unit
        abstract groupEnd : unit -> unit
        abstract info : ?message:obj * [<ParamArray>] optionalParams:obj -> unit
        abstract log : ?message:obj * [<ParamArray>] optionalParams:obj -> unit
        abstract markTimeline : label:string -> unit
        abstract profile : reportName:string -> unit
        abstract profileEnd : reportName:string -> unit
        abstract table : [<ParamArray>] tabularData:obj -> unit
        abstract time : label:string -> unit
        abstract timeEnd : label:string -> unit
        abstract timeStamp : label:string -> unit
        abstract timeline : label:string -> unit
        abstract timelineEnd : label:string -> unit
        abstract trace : ?message:obj * [<ParamArray>] optionalParams:obj -> unit
        abstract warn : ?message:obj * [<ParamArray>] optionalParams:obj -> unit
    
    [<Global>]
    let Console : obj = jsNative
    
    [<AllowNullLiteral>]
    type Crypto =
        abstract subtle : SubtleCrypto with get, set
        abstract getRandomValues : array:'T -> 'T
    
    [<Global>]
    let Crypto : obj = jsNative
    
    [<AllowNullLiteral>]
    type CryptoKey =
        abstract algorithm : KeyAlgorithm with get, set
        abstract extractable : bool with get, set
        abstract ``type`` : KeyType with get, set
        abstract usages : ResizeArray<KeyUsage> with get, set
    
    [<Global>]
    let CryptoKey : obj = jsNative
    
    [<AllowNullLiteral>]
    type CustomEvent<'T> =
        inherit Event
        abstract detail : 'T with get, set
        abstract initCustomEvent : typeArg:string * canBubbleArg:bool * cancelableArg:bool * detailArg:'T -> unit
    
    [<Global>]
    let CustomEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMException =
        abstract code : float with get, set
        abstract message : string with get, set
        abstract name : string with get, set
        abstract ABORT_ERR : float with get, set
        abstract DATA_CLONE_ERR : float with get, set
        abstract DOMSTRING_SIZE_ERR : float with get, set
        abstract HIERARCHY_REQUEST_ERR : float with get, set
        abstract INDEX_SIZE_ERR : float with get, set
        abstract INUSE_ATTRIBUTE_ERR : float with get, set
        abstract INVALID_ACCESS_ERR : float with get, set
        abstract INVALID_CHARACTER_ERR : float with get, set
        abstract INVALID_MODIFICATION_ERR : float with get, set
        abstract INVALID_NODE_TYPE_ERR : float with get, set
        abstract INVALID_STATE_ERR : float with get, set
        abstract NAMESPACE_ERR : float with get, set
        abstract NETWORK_ERR : float with get, set
        abstract NOT_FOUND_ERR : float with get, set
        abstract NOT_SUPPORTED_ERR : float with get, set
        abstract NO_DATA_ALLOWED_ERR : float with get, set
        abstract NO_MODIFICATION_ALLOWED_ERR : float with get, set
        abstract QUOTA_EXCEEDED_ERR : float with get, set
        abstract SECURITY_ERR : float with get, set
        abstract SYNTAX_ERR : float with get, set
        abstract TIMEOUT_ERR : float with get, set
        abstract TYPE_MISMATCH_ERR : float with get, set
        abstract URL_MISMATCH_ERR : float with get, set
        abstract VALIDATION_ERR : float with get, set
        abstract WRONG_DOCUMENT_ERR : float with get, set
    
    [<Global>]
    let DOMException : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMMatrix =
        inherit DOMMatrixReadOnly
        abstract a : float with get, set
        abstract b : float with get, set
        abstract c : float with get, set
        abstract d : float with get, set
        abstract e : float with get, set
        abstract f : float with get, set
        abstract m11 : float with get, set
        abstract m12 : float with get, set
        abstract m13 : float with get, set
        abstract m14 : float with get, set
        abstract m21 : float with get, set
        abstract m22 : float with get, set
        abstract m23 : float with get, set
        abstract m24 : float with get, set
        abstract m31 : float with get, set
        abstract m32 : float with get, set
        abstract m33 : float with get, set
        abstract m34 : float with get, set
        abstract m41 : float with get, set
        abstract m42 : float with get, set
        abstract m43 : float with get, set
        abstract m44 : float with get, set
        abstract invertSelf : unit -> DOMMatrix
        abstract multiplySelf : other:DOMMatrixInit -> DOMMatrix
        abstract preMultiplySelf : other:DOMMatrixInit -> DOMMatrix
        abstract rotateAxisAngleSelf : ?x:float * ?y:float * ?z:float * ?angle:float -> DOMMatrix
        abstract rotateFromVectorSelf : ?x:float * ?y:float -> DOMMatrix
        abstract rotateSelf : ?rotX:float * ?rotY:float * ?rotZ:float -> DOMMatrix
        abstract scale3dSelf : ?scale:float * ?originX:float * ?originY:float * ?originZ:float -> DOMMatrix
        abstract scaleSelf : ?scaleX:float * ?scaleY:float * ?scaleZ:float * ?originX:float * ?originY:float * ?originZ:float
         -> DOMMatrix
        abstract skewXSelf : sx:float -> DOMMatrix
        abstract skewYSelf : sy:float -> DOMMatrix
        abstract translateSelf : ?tx:float * ?ty:float * ?tz:float -> DOMMatrix
    
    [<Global>]
    let DOMMatrix : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMMatrixReadOnly =
        abstract a : float with get, set
        abstract b : float with get, set
        abstract c : float with get, set
        abstract d : float with get, set
        abstract e : float with get, set
        abstract f : float with get, set
        abstract is2D : bool with get, set
        abstract isIdentity : bool with get, set
        abstract m11 : float with get, set
        abstract m12 : float with get, set
        abstract m13 : float with get, set
        abstract m14 : float with get, set
        abstract m21 : float with get, set
        abstract m22 : float with get, set
        abstract m23 : float with get, set
        abstract m24 : float with get, set
        abstract m31 : float with get, set
        abstract m32 : float with get, set
        abstract m33 : float with get, set
        abstract m34 : float with get, set
        abstract m41 : float with get, set
        abstract m42 : float with get, set
        abstract m43 : float with get, set
        abstract m44 : float with get, set
        abstract flipX : unit -> DOMMatrix
        abstract flipY : unit -> DOMMatrix
        abstract inverse : unit -> DOMMatrix
        abstract multiply : other:DOMMatrixInit -> DOMMatrix
        abstract rotate : ?rotX:float * ?rotY:float * ?rotZ:float -> DOMMatrix
        abstract rotateAxisAngle : ?x:float * ?y:float * ?z:float * ?angle:float -> DOMMatrix
        abstract rotateFromVector : ?x:float * ?y:float -> DOMMatrix
        abstract scale : ?scaleX:float * ?scaleY:float * ?scaleZ:float * ?originX:float * ?originY:float * ?originZ:float
         -> DOMMatrix
        abstract scale3d : ?scale:float * ?originX:float * ?originY:float * ?originZ:float -> DOMMatrix
        abstract skewX : sx:float -> DOMMatrix
        abstract skewY : sy:float -> DOMMatrix
        abstract toFloat32Array : unit -> Float32Array
        abstract toFloat64Array : unit -> Float64Array
        abstract toJSON : unit -> obj
        abstract transformPoint : point:DOMPointInit -> DOMPoint
        abstract translate : ?tx:float * ?ty:float * ?tz:float -> DOMMatrix
    
    [<Global>]
    let DOMMatrixReadOnly : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMPoint =
        inherit DOMPointReadOnly
        abstract w : float with get, set
        abstract x : float with get, set
        abstract y : float with get, set
        abstract z : float with get, set
    
    [<Global>]
    let DOMPoint : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMPointReadOnly =
        abstract w : float with get, set
        abstract x : float with get, set
        abstract y : float with get, set
        abstract z : float with get, set
        abstract matrixTransform : matrix:DOMMatrixInit -> DOMPoint
        abstract toJSON : unit -> obj
    
    [<Global>]
    let DOMPointReadOnly : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMQuad =
        abstract p1 : DOMPoint with get, set
        abstract p2 : DOMPoint with get, set
        abstract p3 : DOMPoint with get, set
        abstract p4 : DOMPoint with get, set
        abstract getBounds : unit -> DOMRect
        abstract toJSON : unit -> obj
    
    [<Global>]
    let DOMQuad : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMRect =
        inherit DOMRectReadOnly
        abstract height : float with get, set
        abstract width : float with get, set
        abstract x : float with get, set
        abstract y : float with get, set
    
    [<Global>]
    let DOMRect : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMRectReadOnly =
        abstract bottom : float with get, set
        abstract height : float with get, set
        abstract left : float with get, set
        abstract right : float with get, set
        abstract top : float with get, set
        abstract width : float with get, set
        abstract x : float with get, set
        abstract y : float with get, set
        abstract toJSON : unit -> obj
    
    [<Global>]
    let DOMRectReadOnly : obj = jsNative
    
    [<AllowNullLiteral>]
    type DOMStringList =
        abstract length : float with get, set
        abstract contains : string:string -> bool
        abstract item : index:float -> string option
        [<Emit"$0[$1]{{=$2}}">]
        abstract Item : index:float -> string with get, set
    
    [<Global>]
    let DOMStringList : obj = jsNative
    
    [<AllowNullLiteral>]
    type DedicatedWorkerGlobalScopeEventMap =
        inherit WorkerGlobalScopeEventMap
        abstract message : MessageEvent with get, set
    
    [<AllowNullLiteral>]
    type DedicatedWorkerGlobalScope =
        inherit WorkerGlobalScope
        abstract onmessage : obj option with get, set
        abstract close : unit -> unit
        abstract postMessage : message:obj * ?transfer:ResizeArray<Transferable> -> unit
        abstract addEventListener : ``type``:'K * listener:(DedicatedWorkerGlobalScope -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(DedicatedWorkerGlobalScope -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let DedicatedWorkerGlobalScope : obj = jsNative
    
    [<AllowNullLiteral>]
    type DhImportKeyParams =
        inherit Algorithm
        abstract generator : Uint8Array with get, set
        abstract prime : Uint8Array with get, set
    
    [<AllowNullLiteral>]
    type DhKeyAlgorithm =
        inherit KeyAlgorithm
        abstract generator : Uint8Array with get, set
        abstract prime : Uint8Array with get, set
    
    [<AllowNullLiteral>]
    type DhKeyDeriveParams =
        inherit Algorithm
        abstract ``public`` : CryptoKey with get, set
    
    [<AllowNullLiteral>]
    type DhKeyGenParams =
        inherit Algorithm
        abstract generator : Uint8Array with get, set
        abstract prime : Uint8Array with get, set
    
    [<AllowNullLiteral>]
    type ErrorEvent =
        inherit Event
        abstract colno : float with get, set
        abstract error : obj with get, set
        abstract filename : string with get, set
        abstract lineno : float with get, set
        abstract message : string with get, set
    
    [<Global>]
    let ErrorEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type Event =
        abstract bubbles : bool with get, set
        abstract cancelBubble : bool with get, set
        abstract cancelable : bool with get, set
        abstract composed : bool with get, set
        abstract currentTarget : EventTarget option with get, set
        abstract defaultPrevented : bool with get, set
        abstract eventPhase : float with get, set
        abstract isTrusted : bool with get, set
        abstract returnValue : bool with get, set
        abstract srcElement : obj option with get, set
        abstract target : EventTarget option with get, set
        abstract timeStamp : float with get, set
        abstract ``type`` : string with get, set
        abstract composedPath : unit -> ResizeArray<EventTarget>
        abstract initEvent : ``type``:string * ?bubbles:bool * ?cancelable:bool -> unit
        abstract preventDefault : unit -> unit
        abstract stopImmediatePropagation : unit -> unit
        abstract stopPropagation : unit -> unit
        abstract AT_TARGET : float with get, set
        abstract BUBBLING_PHASE : float with get, set
        abstract CAPTURING_PHASE : float with get, set
        abstract NONE : float with get, set
    
    [<Global>]
    let Event : obj = jsNative
    
    [<AllowNullLiteral>]
    type EventListenerObject =
        abstract handleEvent : evt:Event -> unit
    
    [<AllowNullLiteral>]
    type EventSource =
        inherit EventTarget
        abstract CLOSED : float with get, set
        abstract CONNECTING : float with get, set
        abstract OPEN : float with get, set
        abstract onerror : (MessageEvent -> obj) with get, set
        abstract onmessage : (MessageEvent -> obj) with get, set
        abstract onopen : (MessageEvent -> obj) with get, set
        abstract readyState : float with get, set
        abstract url : string with get, set
        abstract withCredentials : bool with get, set
        abstract close : unit -> unit
    
    [<Global>]
    let EventSource : obj = jsNative
    
    [<AllowNullLiteral>]
    type EventSourceInit =
        abstract withCredentials : bool with get, set
    
    [<AllowNullLiteral>]
    type EventTarget =
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject option * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract dispatchEvent : event:Event -> bool
        abstract removeEventListener : ``type``:string * callback:EventListenerOrEventListenerObject option * ?options:U2<EventListenerOptions, bool>
         -> unit
    
    [<Global>]
    let EventTarget : obj = jsNative
    
    [<AllowNullLiteral>]
    type ExtendableEvent =
        inherit Event
        abstract waitUntil<'t> : f:Promise<'t> -> unit
    
    [<Global>]
    let ExtendableEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type ExtendableMessageEvent =
        inherit ExtendableEvent
        abstract data : obj with get, set
        abstract lastEventId : string with get, set
        abstract origin : string with get, set
        abstract ports : ReadonlyArray<MessagePort> with get, set
        abstract source : U3<Client, ServiceWorker, MessagePort> option with get, set
    
    [<Global>]
    let ExtendableMessageEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type FetchEvent =
        inherit ExtendableEvent
        abstract clientId : string with get, set
        abstract preloadResponse : Promise<obj> with get, set
        abstract request : Request with get, set
        abstract resultingClientId : string with get, set
        abstract targetClientId : string with get, set
        abstract respondWith : r:Promise<Response> -> unit
    
    [<Global>]
    let FetchEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type File =
        inherit Blob
        abstract lastModified : float with get, set
        abstract name : string with get, set
    
    [<Global>]
    let File : obj = jsNative
    
    [<AllowNullLiteral>]
    type FileList =
        abstract length : float with get, set
        abstract item : index:float -> File option
        [<Emit"$0[$1]{{=$2}}">]
        abstract Item : index:float -> File with get, set
    
    [<Global>]
    let FileList : obj = jsNative
    
    [<AllowNullLiteral>]
    type FileReaderEventMap =
        abstract abort : ProgressEvent with get, set
        abstract error : ProgressEvent with get, set
        abstract load : ProgressEvent with get, set
        abstract loadend : ProgressEvent with get, set
        abstract loadstart : ProgressEvent with get, set
        abstract progress : ProgressEvent with get, set
    
    [<AllowNullLiteral>]
    type FileReader =
        inherit EventTarget
        abstract error : DOMException option with get, set
        abstract onabort : obj option with get, set
        abstract onerror : obj option with get, set
        abstract onload : obj option with get, set
        abstract onloadend : obj option with get, set
        abstract onloadstart : obj option with get, set
        abstract onprogress : obj option with get, set
        abstract readyState : float with get, set
        abstract result : U2<string, ArrayBuffer> option with get, set
        abstract abort : unit -> unit
        abstract readAsArrayBuffer : blob:Blob -> unit
        abstract readAsBinaryString : blob:Blob -> unit
        abstract readAsDataURL : blob:Blob -> unit
        abstract readAsText : blob:Blob * ?label:string -> unit
        abstract DONE : float with get, set
        abstract EMPTY : float with get, set
        abstract LOADING : float with get, set
        abstract addEventListener : ``type``:'K * listener:(FileReader -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(FileReader -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let FileReader : obj = jsNative
    
    [<AllowNullLiteral>]
    type FileReaderSync =
        abstract readAsArrayBuffer : blob:Blob -> ArrayBuffer
        abstract readAsBinaryString : blob:Blob -> string
        abstract readAsDataURL : blob:Blob -> string
        abstract readAsText : blob:Blob * ?label:string -> string
    
    [<Global>]
    let FileReaderSync : obj = jsNative
    
    [<AllowNullLiteral>]
    type FormData =
        abstract append : name:string * value:U2<string, Blob> * ?fileName:string -> unit
        abstract delete : name:string -> unit
        abstract get : name:string -> FormDataEntryValue option
        abstract getAll : name:string -> ResizeArray<FormDataEntryValue>
        abstract has : name:string -> bool
        abstract set : name:string * value:U2<string, Blob> * ?fileName:string -> unit
        abstract forEach : callbackfn:(FormDataEntryValue -> string -> FormData -> unit) * ?thisArg:obj -> unit
    
    [<Global>]
    let FormData : obj = jsNative
    
    [<AllowNullLiteral>]
    type GlobalFetch =
        abstract fetch : input:RequestInfo * ?init:RequestInit -> Promise<Response>
    
    [<AllowNullLiteral>]
    type Headers =
        abstract append : name:string * value:string -> unit
        abstract delete : name:string -> unit
        abstract get : name:string -> string option
        abstract has : name:string -> bool
        abstract set : name:string * value:string -> unit
        abstract forEach : callbackfn:(string -> string -> Headers -> unit) * ?thisArg:obj -> unit
    
    [<Global>]
    let Headers : obj = jsNative
    
    [<AllowNullLiteral>]
    type HkdfCtrParams =
        inherit Algorithm
        abstract context : obj with get, set
        abstract hash : U2<string, Algorithm> with get, set
        abstract label : obj with get, set
    
    [<AllowNullLiteral>]
    type IDBArrayKey =
        inherit Array<IDBValidKey>
    
    [<AllowNullLiteral>]
    type IDBCursor =
        abstract direction : IDBCursorDirection with get, set
        abstract key : U2<IDBValidKey, IDBKeyRange> with get, set
        abstract primaryKey : U2<IDBValidKey, IDBKeyRange> with get, set
        abstract source : U2<IDBObjectStore, IDBIndex> with get, set
        abstract advance : count:float -> unit
        abstract ``continue`` : key:U2<IDBValidKey, IDBKeyRange> -> unit
        abstract continuePrimaryKey : key:U2<IDBValidKey, IDBKeyRange> * primaryKey:U2<IDBValidKey, IDBKeyRange> -> unit
        abstract delete : unit -> IDBRequest<obj>
        abstract update : value:obj -> IDBRequest<IDBValidKey>
    
    [<Global>]
    let IDBCursor : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBCursorWithValue =
        inherit IDBCursor
        abstract value : obj with get, set
    
    [<Global>]
    let IDBCursorWithValue : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBDatabaseEventMap =
        abstract abort : Event with get, set
        abstract close : Event with get, set
        abstract error : Event with get, set
        abstract versionchange : IDBVersionChangeEvent with get, set
    
    [<AllowNullLiteral>]
    type IDBDatabase =
        inherit EventTarget
        abstract name : string with get, set
        abstract objectStoreNames : DOMStringList with get, set
        abstract onabort : obj option with get, set
        abstract onclose : obj option with get, set
        abstract onerror : obj option with get, set
        abstract onversionchange : obj option with get, set
        abstract version : float with get, set
        abstract close : unit -> unit
        abstract createObjectStore : name:string * ?optionalParameters:IDBObjectStoreParameters -> IDBObjectStore
        abstract deleteObjectStore : name:string -> unit
        abstract transaction : storeNames:U2<string, ResizeArray<string>> * ?mode:IDBTransactionMode -> IDBTransaction
        abstract addEventListener : ``type``:'K * listener:(IDBDatabase -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(IDBDatabase -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let IDBDatabase : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBFactory =
        abstract cmp : first:obj * second:obj -> float
        abstract deleteDatabase : name:string -> IDBOpenDBRequest
        abstract ``open`` : name:string * ?version:float -> IDBOpenDBRequest
    
    [<Global>]
    let IDBFactory : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBIndex =
        abstract keyPath : U2<string, ResizeArray<string>> with get, set
        abstract multiEntry : bool with get, set
        abstract name : string with get, set
        abstract objectStore : IDBObjectStore with get, set
        abstract unique : bool with get, set
        abstract count : key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<float>
        abstract get : key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<obj option>
        abstract getAll : ?query:U2<IDBValidKey, IDBKeyRange> * ?count:float -> IDBRequest<ResizeArray<obj>>
        abstract getAllKeys : ?query:U2<IDBValidKey, IDBKeyRange> * ?count:float -> IDBRequest<ResizeArray<IDBValidKey>>
        abstract getKey : key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<IDBValidKey option>
        abstract openCursor : ?range:U2<IDBValidKey, IDBKeyRange> * ?direction:IDBCursorDirection
         -> IDBRequest<IDBCursorWithValue option>
        abstract openKeyCursor : ?range:U2<IDBValidKey, IDBKeyRange> * ?direction:IDBCursorDirection
         -> IDBRequest<IDBCursor option>
    
    [<Global>]
    let IDBIndex : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBKeyRange =
        abstract lower : obj with get, set
        abstract lowerOpen : bool with get, set
        abstract upper : obj with get, set
        abstract upperOpen : bool with get, set
        abstract includes : key:obj -> bool
    
    [<Global>]
    let IDBKeyRange : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBObjectStore =
        abstract autoIncrement : bool with get, set
        abstract indexNames : DOMStringList with get, set
        abstract keyPath : U2<string, ResizeArray<string>> with get, set
        abstract name : string with get, set
        abstract transaction : IDBTransaction with get, set
        abstract add : value:obj * ?key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<IDBValidKey>
        abstract clear : unit -> IDBRequest<obj>
        abstract count : key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<float>
        abstract createIndex : name:string * keyPath:U2<string, ResizeArray<string>> * ?options:IDBIndexParameters
         -> IDBIndex
        abstract delete : key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<obj>
        abstract deleteIndex : name:string -> unit
        abstract get : query:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<obj option>
        abstract getAll : ?query:U2<IDBValidKey, IDBKeyRange> * ?count:float -> IDBRequest<ResizeArray<obj>>
        abstract getAllKeys : ?query:U2<IDBValidKey, IDBKeyRange> * ?count:float -> IDBRequest<ResizeArray<IDBValidKey>>
        abstract getKey : query:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<IDBValidKey option>
        abstract index : name:string -> IDBIndex
        abstract openCursor : ?range:U2<IDBValidKey, IDBKeyRange> * ?direction:IDBCursorDirection
         -> IDBRequest<IDBCursorWithValue option>
        abstract openKeyCursor : ?query:U2<IDBValidKey, IDBKeyRange> * ?direction:IDBCursorDirection
         -> IDBRequest<IDBCursor option>
        abstract put : value:obj * ?key:U2<IDBValidKey, IDBKeyRange> -> IDBRequest<IDBValidKey>
    
    [<Global>]
    let IDBObjectStore : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBOpenDBRequestEventMap =
        inherit IDBRequestEventMap
        abstract blocked : Event with get, set
        abstract upgradeneeded : IDBVersionChangeEvent with get, set
    
    [<AllowNullLiteral>]
    type IDBOpenDBRequest =
        inherit IDBRequest<IDBDatabase>
        abstract onblocked : obj option with get, set
        abstract onupgradeneeded : obj option with get, set
        abstract addEventListener : ``type``:'K * listener:(IDBOpenDBRequest -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(IDBOpenDBRequest -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let IDBOpenDBRequest : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBRequestEventMap =
        abstract error : Event with get, set
        abstract success : Event with get, set
    
    [<AllowNullLiteral>]
    type IDBRequest<'T> =
        inherit EventTarget
        abstract error : DOMException option with get, set
        abstract onerror : obj option with get, set
        abstract onsuccess : obj option with get, set
        abstract readyState : IDBRequestReadyState with get, set
        abstract result : 'T with get, set
        abstract source : U3<IDBObjectStore, IDBIndex, IDBCursor> with get, set
        abstract transaction : IDBTransaction option with get, set
        abstract addEventListener : ``type``:'K * listener:(IDBRequest<'T> -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(IDBRequest<'T> -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let IDBRequest : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBTransactionEventMap =
        abstract abort : Event with get, set
        abstract complete : Event with get, set
        abstract error : Event with get, set
    
    [<AllowNullLiteral>]
    type IDBTransaction =
        inherit EventTarget
        abstract db : IDBDatabase with get, set
        abstract error : DOMException with get, set
        abstract mode : IDBTransactionMode with get, set
        abstract objectStoreNames : DOMStringList with get, set
        abstract onabort : obj option with get, set
        abstract oncomplete : obj option with get, set
        abstract onerror : obj option with get, set
        abstract abort : unit -> unit
        abstract objectStore : name:string -> IDBObjectStore
        abstract addEventListener : ``type``:'K * listener:(IDBTransaction -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(IDBTransaction -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let IDBTransaction : obj = jsNative
    
    [<AllowNullLiteral>]
    type IDBVersionChangeEvent =
        inherit Event
        abstract newVersion : float option with get, set
        abstract oldVersion : float with get, set
    
    [<Global>]
    let IDBVersionChangeEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type ImageBitmap =
        abstract height : float with get, set
        abstract width : float with get, set
        abstract close : unit -> unit
    
    [<Global>]
    let ImageBitmap : obj = jsNative
    
    [<AllowNullLiteral>]
    type ImageBitmapOptions =
        abstract colorSpaceConversion : U2<string, string> option with get, set
        abstract imageOrientation : U2<string, string> option with get, set
        abstract premultiplyAlpha : U3<string, string, string> option with get, set
        abstract resizeHeight : float option with get, set
        abstract resizeQuality : U4<string, string, string, string> option with get, set
        abstract resizeWidth : float option with get, set
    
    [<AllowNullLiteral>]
    type ImageData =
        abstract data : Uint8ClampedArray with get, set
        abstract height : float with get, set
        abstract width : float with get, set
    
    [<Global>]
    let ImageData : obj = jsNative
    
    [<AllowNullLiteral>]
    type MessageChannel =
        abstract port1 : MessagePort with get, set
        abstract port2 : MessagePort with get, set
    
    [<Global>]
    let MessageChannel : obj = jsNative
    
    [<AllowNullLiteral>]
    type MessageEvent =
        inherit Event
        abstract data : obj with get, set
        abstract lastEventId : string with get, set
        abstract origin : string with get, set
        abstract ports : ReadonlyArray<MessagePort> with get, set
        abstract source : MessageEventSource option with get, set
    
    [<Global>]
    let MessageEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type MessagePortEventMap =
        abstract message : MessageEvent with get, set
        abstract messageerror : MessageEvent with get, set
    
    [<AllowNullLiteral>]
    type MessagePort =
        inherit EventTarget
        abstract onmessage : obj option with get, set
        abstract onmessageerror : obj option with get, set
        abstract close : unit -> unit
        abstract postMessage : message:obj * ?transfer:ResizeArray<Transferable> -> unit
        abstract start : unit -> unit
        abstract addEventListener : ``type``:'K * listener:(MessagePort -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(MessagePort -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let MessagePort : obj = jsNative
    
    [<AllowNullLiteral>]
    type NavigationPreloadManager =
        abstract disable : unit -> Promise<unit>
        abstract enable : unit -> Promise<unit>
        abstract getState : unit -> Promise<NavigationPreloadState>
        abstract setHeaderValue : value:string -> Promise<unit>
    
    [<Global>]
    let NavigationPreloadManager : obj = jsNative
    
    [<AllowNullLiteral>]
    type NavigatorBeacon =
        abstract sendBeacon : url:string * ?data:obj -> bool
    
    [<AllowNullLiteral>]
    type NavigatorConcurrentHardware =
        abstract hardwareConcurrency : float with get, set
    
    [<AllowNullLiteral>]
    type NavigatorID =
        abstract appCodeName : string with get, set
        abstract appName : string with get, set
        abstract appVersion : string with get, set
        abstract platform : string with get, set
        abstract product : string with get, set
        abstract productSub : string with get, set
        abstract userAgent : string with get, set
        abstract vendor : string with get, set
        abstract vendorSub : string with get, set
    
    [<AllowNullLiteral>]
    type NavigatorOnLine =
        abstract onLine : bool with get, set
    
    [<AllowNullLiteral>]
    type NavigatorStorage =
        abstract storage : StorageManager with get, set
    
    [<AllowNullLiteral>]
    type NotificationEventMap =
        abstract click : Event with get, set
        abstract close : Event with get, set
        abstract error : Event with get, set
        abstract show : Event with get, set
    
    [<AllowNullLiteral>]
    type Notification =
        inherit EventTarget
        abstract actions : ReadonlyArray<NotificationAction> with get, set
        abstract badge : string with get, set
        abstract body : string with get, set
        abstract data : obj with get, set
        abstract dir : NotificationDirection with get, set
        abstract icon : string with get, set
        abstract image : string with get, set
        abstract lang : string with get, set
        abstract onclick : obj option with get, set
        abstract onclose : obj option with get, set
        abstract onerror : obj option with get, set
        abstract onshow : obj option with get, set
        abstract renotify : bool with get, set
        abstract requireInteraction : bool with get, set
        abstract silent : bool with get, set
        abstract tag : string with get, set
        abstract timestamp : float with get, set
        abstract title : string with get, set
        abstract vibrate : ReadonlyArray<float> with get, set
        abstract close : unit -> unit
        abstract addEventListener : ``type``:'K * listener:(Notification -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(Notification -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let Notification : obj = jsNative
    
    [<AllowNullLiteral>]
    type NotificationEvent =
        inherit ExtendableEvent
        abstract action : string with get, set
        abstract notification : Notification with get, set
    
    [<Global>]
    let NotificationEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type Path2D =
        inherit CanvasPath
        abstract addPath : path:Path2D * ?transform:DOMMatrix2DInit -> unit
    
    [<Global>]
    let Path2D : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceEventMap =
        abstract resourcetimingbufferfull : Event with get, set
    
    [<AllowNullLiteral>]
    type Performance =
        inherit EventTarget
        abstract onresourcetimingbufferfull : obj option with get, set
        abstract timeOrigin : float with get, set
        abstract clearMarks : markName:string -> unit
        abstract clearMeasures : measureName:string -> unit
        abstract clearResourceTimings : unit -> unit
        abstract getEntries : unit -> PerformanceEntryList
        abstract getEntriesByName : name:string * ?``type``:string -> PerformanceEntryList
        abstract getEntriesByType : ``type``:string -> PerformanceEntryList
        abstract mark : markName:string -> unit
        abstract measure : measureName:string * ?startMark:string * ?endMark:string -> unit
        abstract now : unit -> float
        abstract setResourceTimingBufferSize : maxSize:float -> unit
        abstract toJSON : unit -> obj
        abstract addEventListener : ``type``:'K * listener:(Performance -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(Performance -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let Performance : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceEntry =
        abstract duration : float with get, set
        abstract entryType : string with get, set
        abstract name : string with get, set
        abstract startTime : float with get, set
        abstract toJSON : unit -> obj
    
    [<Global>]
    let PerformanceEntry : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceMark =
        inherit PerformanceEntry
    
    [<Global>]
    let PerformanceMark : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceMeasure =
        inherit PerformanceEntry
    
    [<Global>]
    let PerformanceMeasure : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceObserver =
        abstract disconnect : unit -> unit
        abstract observe : options:PerformanceObserverInit -> unit
        abstract takeRecords : unit -> PerformanceEntryList
    
    [<Global>]
    let PerformanceObserver : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceObserverEntryList =
        abstract getEntries : unit -> PerformanceEntryList
        abstract getEntriesByName : name:string * ?``type``:string -> PerformanceEntryList
        abstract getEntriesByType : ``type``:string -> PerformanceEntryList
    
    [<Global>]
    let PerformanceObserverEntryList : obj = jsNative
    
    [<AllowNullLiteral>]
    type PerformanceResourceTiming =
        inherit PerformanceEntry
        abstract connectEnd : float with get, set
        abstract connectStart : float with get, set
        abstract decodedBodySize : float with get, set
        abstract domainLookupEnd : float with get, set
        abstract domainLookupStart : float with get, set
        abstract encodedBodySize : float with get, set
        abstract fetchStart : float with get, set
        abstract initiatorType : string with get, set
        abstract nextHopProtocol : string with get, set
        abstract redirectEnd : float with get, set
        abstract redirectStart : float with get, set
        abstract requestStart : float with get, set
        abstract responseEnd : float with get, set
        abstract responseStart : float with get, set
        abstract secureConnectionStart : float with get, set
        abstract transferSize : float with get, set
        abstract workerStart : float with get, set
        abstract toJSON : unit -> obj
    
    [<Global>]
    let PerformanceResourceTiming : obj = jsNative
    
    [<AllowNullLiteral>]
    type ProgressEvent =
        inherit Event
        abstract lengthComputable : bool with get, set
        abstract loaded : float with get, set
        abstract total : float with get, set
    
    [<Global>]
    let ProgressEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type PromiseRejectionEvent =
        inherit Event
        abstract promise : Promise<obj> with get, set
        abstract reason : obj with get, set
    
    [<Global>]
    let PromiseRejectionEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type PushEvent =
        inherit ExtendableEvent
        abstract data : PushMessageData option with get, set
    
    [<Global>]
    let PushEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type PushManager =
        abstract getSubscription : unit -> Promise<PushSubscription option>
        abstract permissionState : options:PushSubscriptionOptionsInit -> Promise<PushPermissionState>
        abstract subscribe : options:PushSubscriptionOptionsInit -> Promise<PushSubscription>
    
    [<Global>]
    let PushManager : obj = jsNative
    
    [<AllowNullLiteral>]
    type PushMessageData =
        abstract arrayBuffer : unit -> ArrayBuffer
        abstract blob : unit -> Blob
        abstract json : unit -> obj
        abstract text : unit -> string
    
    [<Global>]
    let PushMessageData : obj = jsNative
    
    [<AllowNullLiteral>]
    type PushSubscription =
        abstract endpoint : string with get, set
        abstract expirationTime : float option with get, set
        abstract options : PushSubscriptionOptions with get, set
        abstract getKey : name:PushEncryptionKeyName -> ArrayBuffer option
        abstract toJSON : unit -> PushSubscriptionJSON
        abstract unsubscribe : unit -> Promise<bool>
    
    [<Global>]
    let PushSubscription : obj = jsNative
    
    [<AllowNullLiteral>]
    type PushSubscriptionChangeEvent =
        inherit ExtendableEvent
        abstract newSubscription : PushSubscription option with get, set
        abstract oldSubscription : PushSubscription option with get, set
    
    [<Global>]
    let PushSubscriptionChangeEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type PushSubscriptionOptions =
        abstract applicationServerKey : ArrayBuffer option with get, set
        abstract userVisibleOnly : bool with get, set
    
    [<Global>]
    let PushSubscriptionOptions : obj = jsNative
    
    [<AllowNullLiteral>]
    type ReadableStream =
        abstract locked : bool with get, set
        abstract cancel : unit -> Promise<unit>
        abstract getReader : unit -> ReadableStreamReader
    
    [<Global>]
    let ReadableStream : obj = jsNative
    
    [<AllowNullLiteral>]
    type ReadableStreamReader =
        abstract cancel : unit -> Promise<unit>
        abstract read : unit -> Promise<obj>
        abstract releaseLock : unit -> unit
    
    [<Global>]
    let ReadableStreamReader : obj = jsNative
    
    [<AllowNullLiteral>]
    type Request =
        inherit Body
        abstract cache : RequestCache with get, set
        abstract credentials : RequestCredentials with get, set
        abstract destination : RequestDestination with get, set
        abstract headers : Headers with get, set
        abstract integrity : string with get, set
        abstract isHistoryNavigation : bool with get, set
        abstract isReloadNavigation : bool with get, set
        abstract keepalive : bool with get, set
        abstract method : string with get, set
        abstract mode : RequestMode with get, set
        abstract redirect : RequestRedirect with get, set
        abstract referrer : string with get, set
        abstract referrerPolicy : ReferrerPolicy with get, set
        abstract signal : AbortSignal with get, set
        abstract url : string with get, set
        abstract clone : unit -> Request
    
    [<Global>]
    let Request : obj = jsNative
    
    [<AllowNullLiteral>]
    type Response =
        inherit Body
        abstract headers : Headers with get, set
        abstract ok : bool with get, set
        abstract redirected : bool with get, set
        abstract status : float with get, set
        abstract statusText : string with get, set
        abstract trailer : Promise<Headers> with get, set
        abstract ``type`` : ResponseType with get, set
        abstract url : string with get, set
        abstract clone : unit -> Response
    
    [<Global>]
    let Response : obj = jsNative
    
    [<AllowNullLiteral>]
    type ServiceWorkerEventMap =
        inherit AbstractWorkerEventMap
        abstract statechange : Event with get, set
    
    [<AllowNullLiteral>]
    type ServiceWorker =
        inherit EventTarget
        inherit AbstractWorker
        abstract onstatechange : obj option with get, set
        abstract scriptURL : string with get, set
        abstract state : ServiceWorkerState with get, set
        abstract postMessage : message:obj * ?transfer:ResizeArray<Transferable> -> unit
        abstract addEventListener : ``type``:'K * listener:(ServiceWorker -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(ServiceWorker -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let ServiceWorker : obj = jsNative
    
    [<AllowNullLiteral>]
    type ServiceWorkerContainerEventMap =
        abstract controllerchange : Event with get, set
        abstract message : MessageEvent with get, set
        abstract messageerror : MessageEvent with get, set
    
    [<AllowNullLiteral>]
    type ServiceWorkerContainer =
        inherit EventTarget
        abstract controller : ServiceWorker option with get, set
        abstract oncontrollerchange : obj option with get, set
        abstract onmessage : obj option with get, set
        abstract onmessageerror : obj option with get, set
        abstract ready : Promise<ServiceWorkerRegistration> with get, set
        abstract getRegistration : clientURL:string -> Promise<ServiceWorkerRegistration option>
        abstract getRegistrations : unit -> Promise<ReadonlyArray<ServiceWorkerRegistration>>
        abstract register : scriptURL:string * ?options:RegistrationOptions -> Promise<ServiceWorkerRegistration>
        abstract startMessages : unit -> unit
        abstract addEventListener : ``type``:'K * listener:(ServiceWorkerContainer -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(ServiceWorkerContainer -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let ServiceWorkerContainer : obj = jsNative
    
    [<AllowNullLiteral>]
    type ServiceWorkerGlobalScopeEventMap =
        inherit WorkerGlobalScopeEventMap
        abstract activate : ExtendableEvent with get, set
        abstract fetch : FetchEvent with get, set
        abstract install : ExtendableEvent with get, set
        abstract message : ExtendableMessageEvent with get, set
        abstract messageerror : MessageEvent with get, set
        abstract notificationclick : NotificationEvent with get, set
        abstract notificationclose : NotificationEvent with get, set
        abstract push : PushEvent with get, set
        abstract pushsubscriptionchange : PushSubscriptionChangeEvent with get, set
        abstract sync : SyncEvent with get, set
    
    [<AllowNullLiteral>]
    type ServiceWorkerGlobalScope =
        inherit WorkerGlobalScope
        abstract clients : Clients with get, set
        abstract onactivate : obj option with get, set
        abstract onfetch : obj option with get, set
        abstract oninstall : obj option with get, set
        abstract onmessage : obj option with get, set
        abstract onmessageerror : obj option with get, set
        abstract onnotificationclick : obj option with get, set
        abstract onnotificationclose : obj option with get, set
        abstract onpush : obj option with get, set
        abstract onpushsubscriptionchange : obj option with get, set
        abstract onsync : obj option with get, set
        abstract registration : ServiceWorkerRegistration with get, set
        abstract skipWaiting : unit -> Promise<unit>
        abstract addEventListener : ``type``:'K * listener:(ServiceWorkerGlobalScope -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(ServiceWorkerGlobalScope -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let ServiceWorkerGlobalScope : obj = jsNative
    
    [<AllowNullLiteral>]
    type ServiceWorkerRegistrationEventMap =
        abstract updatefound : Event with get, set
    
    [<AllowNullLiteral>]
    type ServiceWorkerRegistration =
        inherit EventTarget
        abstract active : ServiceWorker option with get, set
        abstract installing : ServiceWorker option with get, set
        abstract navigationPreload : NavigationPreloadManager with get, set
        abstract onupdatefound : obj option with get, set
        abstract pushManager : PushManager with get, set
        abstract scope : string with get, set
        abstract sync : SyncManager with get, set
        abstract updateViaCache : ServiceWorkerUpdateViaCache with get, set
        abstract waiting : ServiceWorker option with get, set
        abstract getNotifications : filter:GetNotificationOptions -> Promise<ResizeArray<Notification>>
        abstract showNotification : title:string * ?options:NotificationOptions -> Promise<unit>
        abstract unregister : unit -> Promise<bool>
        abstract update : unit -> Promise<unit>
        abstract addEventListener : ``type``:'K * listener:(ServiceWorkerRegistration -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(ServiceWorkerRegistration -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let ServiceWorkerRegistration : obj = jsNative
    
    [<AllowNullLiteral>]
    type StorageManager =
        abstract estimate : unit -> Promise<StorageEstimate>
        abstract persisted : unit -> Promise<bool>
    
    [<Global>]
    let StorageManager : obj = jsNative
    
    [<AllowNullLiteral>]
    type SubtleCrypto =
        abstract decrypt : algorithm:obj * key:CryptoKey * data:obj -> PromiseLike<ArrayBuffer>
        abstract deriveBits : algorithm:U6<string, EcdhKeyDeriveParams, DhKeyDeriveParams, ConcatParams, HkdfCtrParams, Pbkdf2Params> * baseKey:CryptoKey * length:float
         -> PromiseLike<ArrayBuffer>
        abstract deriveKey : algorithm:U6<string, EcdhKeyDeriveParams, DhKeyDeriveParams, ConcatParams, HkdfCtrParams, Pbkdf2Params> * baseKey:CryptoKey * derivedKeyType:U6<string, AesDerivedKeyParams, HmacImportParams, ConcatParams, HkdfCtrParams, Pbkdf2Params> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKey>
        abstract digest : algorithm:U2<string, Algorithm> * data:obj -> PromiseLike<ArrayBuffer>
        abstract encrypt : algorithm:obj * key:CryptoKey * data:obj -> PromiseLike<ArrayBuffer>
        
        [<Emit"$0.exportKey('jwk',$1...)">]
        abstract exportKey_jwk : key:CryptoKey -> PromiseLike<JsonWebKey>
        
        abstract exportKey : format:U3<string, string, string> * key:CryptoKey -> PromiseLike<ArrayBuffer>
        abstract exportKey : format:string * key:CryptoKey -> PromiseLike<U2<JsonWebKey, ArrayBuffer>>
        abstract generateKey : algorithm:string * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<U2<CryptoKeyPair, CryptoKey>>
        abstract generateKey : algorithm:U3<RsaHashedKeyGenParams, EcKeyGenParams, DhKeyGenParams> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKeyPair>
        abstract generateKey : algorithm:U3<AesKeyGenParams, HmacKeyGenParams, Pbkdf2Params> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKey>
        
        [<Emit"$0.importKey('jwk',$1...)">]
        abstract importKey_jwk : keyData:JsonWebKey * algorithm:U6<string, RsaHashedImportParams, EcKeyImportParams, HmacImportParams, DhImportKeyParams, AesKeyAlgorithm> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKey>
        
        abstract importKey : format:U3<string, string, string> * keyData:obj * algorithm:U6<string, RsaHashedImportParams, EcKeyImportParams, HmacImportParams, DhImportKeyParams, AesKeyAlgorithm> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKey>
        abstract importKey : format:string * keyData:obj * algorithm:U6<string, RsaHashedImportParams, EcKeyImportParams, HmacImportParams, DhImportKeyParams, AesKeyAlgorithm> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKey>
        abstract sign : algorithm:U4<string, RsaPssParams, EcdsaParams, AesCmacParams> * key:CryptoKey * data:obj
         -> PromiseLike<ArrayBuffer>
        abstract unwrapKey : format:string * wrappedKey:obj * unwrappingKey:CryptoKey * unwrapAlgorithm:U2<string, Algorithm> * unwrappedKeyAlgorithm:U2<string, Algorithm> * extractable:bool * keyUsages:ResizeArray<string>
         -> PromiseLike<CryptoKey>
        abstract verify : algorithm:U4<string, RsaPssParams, EcdsaParams, AesCmacParams> * key:CryptoKey * signature:obj * data:obj
         -> PromiseLike<bool>
        abstract wrapKey : format:string * key:CryptoKey * wrappingKey:CryptoKey * wrapAlgorithm:U2<string, Algorithm>
         -> PromiseLike<ArrayBuffer>
    
    [<Global>]
    let SubtleCrypto : obj = jsNative
    
    [<AllowNullLiteral>]
    type SyncEvent =
        inherit ExtendableEvent
        abstract lastChance : bool with get, set
        abstract tag : string with get, set
    
    [<Global>]
    let SyncEvent : obj = jsNative
    
    [<AllowNullLiteral>]
    type SyncManager =
        abstract getTags : unit -> Promise<ResizeArray<string>>
        abstract register : tag:string -> Promise<unit>
    
    [<Global>]
    let SyncManager : obj = jsNative
    
    [<AllowNullLiteral>]
    type TextDecoder =
        abstract encoding : string with get, set
        abstract fatal : bool with get, set
        abstract ignoreBOM : bool with get, set
        abstract decode : ?input:BufferSource * ?options:TextDecodeOptions -> string
    
    [<Global>]
    let TextDecoder : obj = jsNative
    
    [<AllowNullLiteral>]
    type TextEncoder =
        abstract encoding : string with get, set
        abstract encode : input:string -> Uint8Array
    
    [<Global>]
    let TextEncoder : obj = jsNative
    
    [<AllowNullLiteral>]
    type URL =
        abstract hash : string with get, set
        abstract host : string with get, set
        abstract hostname : string with get, set
        abstract href : string with get, set
        abstract origin : string with get, set
        abstract password : string with get, set
        abstract pathname : string with get, set
        abstract port : string with get, set
        abstract protocol : string with get, set
        abstract search : string with get, set
        abstract searchParams : URLSearchParams with get, set
        abstract username : string with get, set
        abstract toJSON : unit -> string
    
    [<Global>]
    let URL : obj = jsNative
    
    [<AllowNullLiteral>]
    type URLSearchParams =
        abstract append : name:string * value:string -> unit
        abstract delete : name:string -> unit
        abstract get : name:string -> string option
        abstract getAll : name:string -> ResizeArray<string>
        abstract has : name:string -> bool
        abstract set : name:string * value:string -> unit
        abstract sort : unit -> unit
        abstract forEach : callbackfn:(string -> string -> URLSearchParams -> unit) * ?thisArg:obj -> unit
    
    [<Global>]
    let URLSearchParams : obj = jsNative
    
    [<AllowNullLiteral>]
    type WebSocketEventMap =
        abstract close : CloseEvent with get, set
        abstract error : Event with get, set
        abstract message : MessageEvent with get, set
        abstract ``open`` : Event with get, set
    
    [<AllowNullLiteral>]
    type WebSocket =
        inherit EventTarget
        abstract binaryType : BinaryType with get, set
        abstract bufferedAmount : float with get, set
        abstract extensions : string with get, set
        abstract onclose : obj option with get, set
        abstract onerror : obj option with get, set
        abstract onmessage : obj option with get, set
        abstract onopen : obj option with get, set
        abstract protocol : string with get, set
        abstract readyState : float with get, set
        abstract url : string with get, set
        abstract close : ?code:float * ?reason:string -> unit
        abstract send : data:U4<string, ArrayBuffer, Blob, ArrayBufferView> -> unit
        abstract CLOSED : float with get, set
        abstract CLOSING : float with get, set
        abstract CONNECTING : float with get, set
        abstract OPEN : float with get, set
        abstract addEventListener : ``type``:'K * listener:(WebSocket -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(WebSocket -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let WebSocket : obj = jsNative
    
    [<AllowNullLiteral>]
    type WindowBase64 =
        abstract atob : encodedString:string -> string
        abstract btoa : rawString:string -> string
    
    [<AllowNullLiteral>]
    type WindowClient =
        inherit Client
        abstract ancestorOrigins : ReadonlyArray<string> with get, set
        abstract focused : bool with get, set
        abstract visibilityState : VisibilityState with get, set
        abstract focus : unit -> Promise<WindowClient>
        abstract navigate : url:string -> Promise<WindowClient option>
    
    [<Global>]
    let WindowClient : obj = jsNative
    
    [<AllowNullLiteral>]
    type WindowConsole =
        abstract console : Console with get, set
    
    [<AllowNullLiteral>]
    type WindowOrWorkerGlobalScope =
        abstract caches : CacheStorage with get, set
        abstract crypto : Crypto with get, set
        abstract indexedDB : IDBFactory with get, set
        abstract origin : string with get, set
        abstract performance : Performance with get, set
        abstract atob : data:string -> string
        abstract btoa : data:string -> string
        abstract clearInterval : handle:float -> unit
        abstract clearTimeout : handle:float -> unit
        abstract createImageBitmap : image:ImageBitmapSource -> Promise<ImageBitmap>
        abstract createImageBitmap : image:ImageBitmapSource * sx:float * sy:float * sw:float * sh:float
         -> Promise<ImageBitmap>
        abstract fetch : input:RequestInfo * ?init:RequestInit -> Promise<Response>
        abstract queueMicrotask : callback:Function -> unit
        abstract setInterval : handler:TimerHandler * ?timeout:float * [<ParamArray>] arguments:obj -> float
        abstract setTimeout : handler:TimerHandler * ?timeout:float * [<ParamArray>] arguments:obj -> float
    
    [<AllowNullLiteral>]
    type WorkerEventMap =
        inherit AbstractWorkerEventMap
        abstract message : MessageEvent with get, set
    
    [<AllowNullLiteral>]
    type Worker =
        inherit EventTarget
        inherit AbstractWorker
        abstract onmessage : obj option with get, set
        abstract postMessage : message:obj * ?transfer:ResizeArray<Transferable> -> unit
        abstract terminate : unit -> unit
        abstract addEventListener : ``type``:'K * listener:(Worker -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(Worker -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let Worker : obj = jsNative
    
    [<AllowNullLiteral>]
    type WorkerGlobalScopeEventMap =
        abstract error : ErrorEvent with get, set
    
    [<AllowNullLiteral>]
    type WorkerGlobalScope =
        inherit EventTarget
        inherit WorkerUtils
        inherit WindowConsole
        inherit GlobalFetch
        inherit WindowOrWorkerGlobalScope
        abstract caches : CacheStorage with get, set
        abstract isSecureContext : bool with get, set
        abstract location : WorkerLocation with get, set
        abstract onerror : obj option with get, set
        abstract performance : Performance with get, set
        abstract self : WorkerGlobalScope with get, set
        abstract msWriteProfilerMark : profilerMarkName:string -> unit
        abstract addEventListener : ``type``:'K * listener:(WorkerGlobalScope -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        [<Emit("$0.addEventListener('install',$1...)")>] abstract addEventListener_install: listener: (ExtendableEvent -> 'Out) * ?useCapture : bool -> unit
        [<Emit("$0.addEventListener('activate',$1...)")>] abstract addEventListener_activate: listener: (ExtendableEvent -> 'Out) * ?useCapture : bool -> unit
        [<Emit("$0.addEventListener('fetch',$1...)")>] abstract addEventListener_fetch: listener: (FetchEvent -> 'Out) * ?useCapture : bool -> unit
        [<Emit("$0.addEventListener('push',$1...)")>] abstract addEventListener_push: listener: (PushEvent -> 'Out) * ?useCapture : bool -> unit
        [<Emit("$0.addEventListener('notificationclick',$1...)")>] abstract addEventListener_notificationclick: listener: (NotificationEvent -> 'Out) * ?useCapture : bool -> unit
        [<Emit("$0.addEventListener('notificationclose',$1...)")>] abstract addEventListener_notificationclose: listener: (NotificationEvent -> 'Out) * ?useCapture : bool -> unit
        [<Emit("$0.addEventListener('sync',$1...)")>] abstract addEventListener_sync: listener: (SyncEvent -> 'Out) * ?useCapture : bool -> unit
        abstract removeEventListener : ``type``:'K * listener:(WorkerGlobalScope -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let WorkerGlobalScope : obj = jsNative
    
    [<AllowNullLiteral>]
    type WorkerLocation =
        abstract hash : string with get, set
        abstract host : string with get, set
        abstract hostname : string with get, set
        abstract href : string with get, set
        abstract origin : string with get, set
        abstract pathname : string with get, set
        abstract port : string with get, set
        abstract protocol : string with get, set
        abstract search : string with get, set
        abstract toString : unit -> string
    
    [<Global>]
    let WorkerLocation : obj = jsNative
    
    [<AllowNullLiteral>]
    type WorkerNavigator =
        inherit NavigatorID
        inherit NavigatorOnLine
        inherit NavigatorBeacon
        inherit NavigatorConcurrentHardware
        inherit NavigatorStorage
        abstract serviceWorker : ServiceWorkerContainer with get, set
    
    [<Global>]
    let WorkerNavigator : obj = jsNative
    
    [<AllowNullLiteral>]
    type WorkerUtils =
        inherit WindowBase64
        abstract indexedDB : IDBFactory with get, set
        abstract msIndexedDB : IDBFactory with get, set
        abstract navigator : WorkerNavigator with get, set
        abstract importScripts : [<ParamArray>] urls:string -> unit
    
    [<AllowNullLiteral>]
    type XMLHttpRequestEventMap =
        inherit XMLHttpRequestEventTargetEventMap
        abstract readystatechange : Event with get, set
    
    [<AllowNullLiteral>]
    type XMLHttpRequest =
        inherit XMLHttpRequestEventTarget
        abstract onreadystatechange : obj option with get, set
        abstract readyState : float with get, set
        abstract response : obj with get, set
        abstract responseText : string with get, set
        abstract responseType : XMLHttpRequestResponseType with get, set
        abstract responseURL : string with get, set
        abstract status : float with get, set
        abstract statusText : string with get, set
        abstract timeout : float with get, set
        abstract upload : XMLHttpRequestUpload with get, set
        abstract withCredentials : bool with get, set
        abstract abort : unit -> unit
        abstract getAllResponseHeaders : unit -> string
        abstract getResponseHeader : name:string -> string option
        abstract ``open`` : method:string * url:string -> unit
        abstract ``open`` : method:string * url:string * async:bool * ?username:string option * ?password:string option
         -> unit
        abstract overrideMimeType : mime:string -> unit
        abstract send : body:BodyInit option -> unit
        abstract setRequestHeader : name:string * value:string -> unit
        abstract DONE : float with get, set
        abstract HEADERS_RECEIVED : float with get, set
        abstract LOADING : float with get, set
        abstract OPENED : float with get, set
        abstract UNSENT : float with get, set
        abstract addEventListener : ``type``:'K * listener:(XMLHttpRequest -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(XMLHttpRequest -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let XMLHttpRequest : obj = jsNative
    
    [<AllowNullLiteral>]
    type XMLHttpRequestEventTargetEventMap =
        abstract abort : ProgressEvent with get, set
        abstract error : ProgressEvent with get, set
        abstract load : ProgressEvent with get, set
        abstract loadend : ProgressEvent with get, set
        abstract loadstart : ProgressEvent with get, set
        abstract progress : ProgressEvent with get, set
        abstract timeout : ProgressEvent with get, set
    
    [<AllowNullLiteral>]
    type XMLHttpRequestEventTarget =
        inherit EventTarget
        abstract onabort : obj option with get, set
        abstract onerror : obj option with get, set
        abstract onload : obj option with get, set
        abstract onloadend : obj option with get, set
        abstract onloadstart : obj option with get, set
        abstract onprogress : obj option with get, set
        abstract ontimeout : obj option with get, set
        abstract addEventListener : ``type``:'K * listener:(XMLHttpRequestEventTarget -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(XMLHttpRequestEventTarget -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let XMLHttpRequestEventTarget : obj = jsNative
    
    [<AllowNullLiteral>]
    type XMLHttpRequestUpload =
        inherit XMLHttpRequestEventTarget
        abstract addEventListener : ``type``:'K * listener:(XMLHttpRequestUpload -> obj -> obj) * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract addEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, AddEventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:'K * listener:(XMLHttpRequestUpload -> obj -> obj) * ?options:U2<bool, EventListenerOptions>
         -> unit
        abstract removeEventListener : ``type``:string * listener:EventListenerOrEventListenerObject * ?options:U2<bool, EventListenerOptions>
         -> unit
    
    [<Global>]
    let XMLHttpRequestUpload : obj = jsNative
    
    type EventListenerOrEventListenerObject = U2<EventListener, EventListenerObject>
    
    [<AllowNullLiteral>]
    type EventHandlerNonNull =
        [<Emit"$0($1...)">]
        abstract Invoke : event:Event -> obj
    
    [<AllowNullLiteral>]
    type PerformanceObserverCallback =
        [<Emit"$0($1...)">]
        abstract Invoke : entries:PerformanceObserverEntryList * observer:PerformanceObserver -> unit
    
    [<Global>]
    let onmessage : obj option = jsNative
    
    [<Global>]
    let isSecureContext : bool = jsNative
    
    [<Global>]
    let location : WorkerLocation = jsNative
    
    [<Global>]
    let onerror : obj option = jsNative
        
    [<Global>]
    let self : WorkerGlobalScope = jsNative
    
    [<Global>]
    let indexedDB : IDBFactory = jsNative
    
    [<Global>]
    let msIndexedDB : IDBFactory = jsNative
    
    [<Global>]
    let navigator : WorkerNavigator = jsNative
    
    [<Global>]
    let console : Console = jsNative
    
    [<Global>]
    let caches : CacheStorage = jsNative
    
    [<Global>]
    let crypto : Crypto = jsNative
        
    [<Global>]
    let origin : string = jsNative
    
    [<Global>]
    let performance : Performance = jsNative
    
    type BlobPart = U3<BufferSource, Blob, string>
    
    type HeadersInit = U3<Headers, ResizeArray<ResizeArray<string>>, Map<string, string>>
    
    type BodyInit = U6<Blob, BufferSource, FormData, URLSearchParams, ReadableStream, string>
    
    type RequestInfo = U2<Request, string>
    
    type DOMHighResTimeStamp = float
    
    type CanvasImageSource = ImageBitmap
    
    type MessageEventSource = U2<MessagePort, ServiceWorker>
    
    type ImageBitmapSource = U3<CanvasImageSource, Blob, ImageData>
    
    type TimerHandler = U2<string, Function>
    
    type PerformanceEntryList = ResizeArray<PerformanceEntry>
    
    type PushMessageDataInit = U2<BufferSource, string>
    
    type VibratePattern = U2<float, ResizeArray<float>>
    
    type AlgorithmIdentifier = U2<string, Algorithm>
    
    type HashAlgorithmIdentifier = AlgorithmIdentifier
    
    type BigInteger = Uint8Array
    
    type NamedCurve = string
    
    type BufferSource = U2<ArrayBufferView, ArrayBuffer>
    
    type DOMTimeStamp = float
    
    type FormDataEntryValue = U2<File, string>
    
    type IDBValidKey = U5<float, string, DateTime, BufferSource, IDBArrayKey>
    
    type Transferable = U3<ArrayBuffer, MessagePort, ImageBitmap>
    
    [<StringEnum; RequireQualifiedAccess>]
    type BinaryType =
        | [<CompiledName"blob">] Blob
        | [<CompiledName"arraybuffer">] Arraybuffer
    
    [<StringEnum; RequireQualifiedAccess>]
    type ClientTypes =
        | [<CompiledName"window">] Window
        | [<CompiledName"worker">] Worker
        | [<CompiledName"sharedworker">] Sharedworker
        | [<CompiledName"all">] All
    
    [<StringEnum; RequireQualifiedAccess>]
    type IDBCursorDirection =
        | [<CompiledName"next">] Next
        | [<CompiledName"nextunique">] Nextunique
        | [<CompiledName"prev">] Prev
        | [<CompiledName"prevunique">] Prevunique
    
    [<StringEnum; RequireQualifiedAccess>]
    type IDBRequestReadyState =
        | [<CompiledName"pending">] Pending
        | [<CompiledName"done">] Done
    
    [<StringEnum; RequireQualifiedAccess>]
    type IDBTransactionMode =
        | [<CompiledName"readonly">] Readonly
        | [<CompiledName"readwrite">] Readwrite
        | [<CompiledName"versionchange">] Versionchange
    
    [<StringEnum; RequireQualifiedAccess>]
    type KeyFormat =
        | [<CompiledName"raw">] Raw
        | [<CompiledName"spki">] Spki
        | [<CompiledName"pkcs8">] Pkcs8
        | [<CompiledName"jwk">] Jwk
    
    [<StringEnum; RequireQualifiedAccess>]
    type KeyType =
        | [<CompiledName"public">] Public
        | [<CompiledName"private">] Private
        | [<CompiledName"secret">] Secret
    
    [<StringEnum; RequireQualifiedAccess>]
    type KeyUsage =
        | [<CompiledName"encrypt">] Encrypt
        | [<CompiledName"decrypt">] Decrypt
        | [<CompiledName"sign">] Sign
        | [<CompiledName"verify">] Verify
        | [<CompiledName"deriveKey">] DeriveKey
        | [<CompiledName"deriveBits">] DeriveBits
        | [<CompiledName"wrapKey">] WrapKey
        | [<CompiledName"unwrapKey">] UnwrapKey
    
    [<StringEnum; RequireQualifiedAccess>]
    type NotificationDirection =
        | [<CompiledName"auto">] Auto
        | [<CompiledName"ltr">] Ltr
        | [<CompiledName"rtl">] Rtl
    
    [<StringEnum; RequireQualifiedAccess>]
    type NotificationPermission =
        | [<CompiledName"default">] Default
        | [<CompiledName"denied">] Denied
        | [<CompiledName"granted">] Granted
    
    [<StringEnum; RequireQualifiedAccess>]
    type PushEncryptionKeyName =
        | [<CompiledName"p256dh">] P256dh
        | [<CompiledName"auth">] Auth
    
    [<StringEnum; RequireQualifiedAccess>]
    type PushPermissionState =
        | [<CompiledName"denied">] Denied
        | [<CompiledName"granted">] Granted
        | [<CompiledName"prompt">] Prompt
    
    [<StringEnum; RequireQualifiedAccess>]
    type ReferrerPolicy =
        | [<CompiledName"">] Empty
        | [<CompiledName"no-referrer">] NoReferrer
        | [<CompiledName"no-referrer-when-downgrade">] NoReferrerWhenDowngrade
        | [<CompiledName"origin-only">] OriginOnly
        | [<CompiledName"origin-when-cross-origin">] OriginWhenCrossOrigin
        | [<CompiledName"unsafe-url">] UnsafeUrl
    
    [<StringEnum; RequireQualifiedAccess>]
    type RequestCache =
        | [<CompiledName"default">] Default
        | [<CompiledName"no-store">] NoStore
        | [<CompiledName"reload">] Reload
        | [<CompiledName"no-cache">] NoCache
        | [<CompiledName"force-cache">] ForceCache
        | [<CompiledName"only-if-cached">] OnlyIfCached
    
    [<StringEnum; RequireQualifiedAccess>]
    type RequestCredentials =
        | [<CompiledName"omit">] Omit
        | [<CompiledName"same-origin">] SameOrigin
        | [<CompiledName"include">] Include
    
    [<StringEnum; RequireQualifiedAccess>]
    type RequestDestination =
        | [<CompiledName"">] Empty
        | [<CompiledName"audio">] Audio
        | [<CompiledName"audioworklet">] Audioworklet
        | [<CompiledName"document">] Document
        | [<CompiledName"embed">] Embed
        | [<CompiledName"font">] Font
        | [<CompiledName"image">] Image
        | [<CompiledName"manifest">] Manifest
        | [<CompiledName"object">] Object
        | [<CompiledName"paintworklet">] Paintworklet
        | [<CompiledName"report">] Report
        | [<CompiledName"script">] Script
        | [<CompiledName"sharedworker">] Sharedworker
        | [<CompiledName"style">] Style
        | [<CompiledName"track">] Track
        | [<CompiledName"video">] Video
        | [<CompiledName"worker">] Worker
        | [<CompiledName"xslt">] Xslt
    
    [<StringEnum; RequireQualifiedAccess>]
    type RequestMode =
        | [<CompiledName"navigate">] Navigate
        | [<CompiledName"same-origin">] SameOrigin
        | [<CompiledName"no-cors">] NoCors
        | [<CompiledName"cors">] Cors
    
    [<StringEnum; RequireQualifiedAccess>]
    type RequestRedirect =
        | [<CompiledName"follow">] Follow
        | [<CompiledName"error">] Error
        | [<CompiledName"manual">] Manual
    
    [<StringEnum; RequireQualifiedAccess>]
    type ResponseType =
        | [<CompiledName"basic">] Basic
        | [<CompiledName"cors">] Cors
        | [<CompiledName"default">] Default
        | [<CompiledName"error">] Error
        | [<CompiledName"opaque">] Opaque
        | [<CompiledName"opaqueredirect">] Opaqueredirect
    
    [<StringEnum; RequireQualifiedAccess>]
    type ServiceWorkerState =
        | [<CompiledName"installing">] Installing
        | [<CompiledName"installed">] Installed
        | [<CompiledName"activating">] Activating
        | [<CompiledName"activated">] Activated
        | [<CompiledName"redundant">] Redundant
    
    [<StringEnum; RequireQualifiedAccess>]
    type ServiceWorkerUpdateViaCache =
        | [<CompiledName"imports">] Imports
        | [<CompiledName"all">] All
        | [<CompiledName"none">] None
    
    [<StringEnum; RequireQualifiedAccess>]
    type VisibilityState =
        | [<CompiledName"hidden">] Hidden
        | [<CompiledName"visible">] Visible
        | [<CompiledName"prerender">] Prerender
    
    [<StringEnum; RequireQualifiedAccess>]
    type WorkerType =
        | [<CompiledName"classic">] Classic
        | [<CompiledName"module">] Module
    
    [<StringEnum; RequireQualifiedAccess>]
    type XMLHttpRequestResponseType =
        | [<CompiledName"">] Empty
        | [<CompiledName"arraybuffer">] Arraybuffer
        | [<CompiledName"blob">] Blob
        | [<CompiledName"document">] Document
        | [<CompiledName"json">] Json
        | [<CompiledName"text">] Text


    module ServiceWorker =
    
        let self: ServiceWorkerGlobalScope = jsNative