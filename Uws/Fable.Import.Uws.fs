module rec Fable.Import.Uws
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Node

type [<AllowNullLiteral>] IWebSocket =
    inherit Events.EventEmitter
    abstract CONNECTING: float with get, set
    abstract OPEN: float with get, set
    abstract CLOSING: float with get, set
    abstract CLOSED: float with get, set
    abstract upgradeReq: Http.IncomingMessage with get, set
    abstract onopen: obj -> unit
    abstract onerror: Error -> unit
    abstract onclose: obj -> unit
    abstract onmessage: obj -> unit
    abstract close: ?code: float * ?data: obj -> unit
    abstract ping: ?data: obj * ?options: obj * ?dontFail: bool -> unit
    abstract pong: ?data: obj * ?options: obj * ?dontFail: bool -> unit
    abstract send: data: obj * ?cb: (Error -> unit) -> unit
    abstract send: data: obj * options: obj * ?cb: (Error -> unit) -> unit
    abstract terminate: unit -> unit

type [<AllowNullLiteral>] IWebSocketClient =
    inherit IWebSocket

type VerifyClientCallbackSync =
    (obj -> bool)

type VerifyClientCallbackAsync =
    (obj -> (bool -> unit) -> unit)

type [<AllowNullLiteral>] IClientOptions =
    abstract protocol: string option with get, set
    abstract agent: Http.Agent option with get, set
    abstract headers: obj option with get, set
    abstract protocolVersion: obj option with get, set
    abstract host: string option with get, set
    abstract origin: string option with get, set
    abstract pfx: obj option with get, set
    abstract key: obj option with get, set
    abstract passphrase: string option with get, set
    abstract cert: obj option with get, set
    abstract ca: ResizeArray<obj> option with get, set
    abstract ciphers: string option with get, set
    abstract rejectUnauthorized: bool option with get, set

type [<AllowNullLiteral>] IPerMessageDeflateOptions =
    abstract serverNoContextTakeover: bool option with get, set
    abstract clientNoContextTakeover: bool option with get, set
    abstract serverMaxWindowBits: float option with get, set
    abstract clientMaxWindowBits: float option with get, set
    abstract memLevel: float option with get, set

type [<AllowNullLiteral>] IServerOptions =
    abstract host: string option with get, set
    abstract port: float option with get, set
    abstract server: U2<Http.Server, Https.Server> option with get, set
    abstract verifyClient: U2<VerifyClientCallbackAsync, VerifyClientCallbackSync> option with get, set
    abstract handleProtocols: obj option with get, set
    abstract path: string option with get, set
    abstract noServer: bool option with get, set
    abstract disableHixie: bool option with get, set
    abstract clientTracking: bool option with get, set
    abstract perMessageDeflate: U2<bool, IPerMessageDeflateOptions> option with get, set

type [<StringEnum>] Connection =
    | Connection

type [<AllowNullLiteral>] IServer =
    inherit Events.EventEmitter
    abstract on: Connection * (IWebSocket -> unit) -> unit
    abstract options: IServerOptions with get, set
    abstract path: string with get, set
    abstract clients: ResizeArray<IWebSocket> with get, set
    abstract close: (obj -> unit) -> unit
    abstract close: unit -> unit
    abstract handleUpgrade: Http.IncomingMessage * Net.Socket * ArrayBuffer * (IWebSocket -> unit) -> unit

type [<AllowNullLiteral>] IServerStatic =
    [<Emit("new $0()")>] abstract Create: unit -> IServer
    [<Emit("new $0($1)")>] abstract Create: IServerOptions -> IServer
    [<Emit("new $0($1, $2)")>] abstract Create: IServerOptions * (unit -> unit) -> IServer

type [<AllowNullLiteral>] IUwsHttp =
    abstract createServer: ?requestListener: (Http.IncomingMessage -> Http.ServerResponse -> unit) -> Http.Server
    abstract getExpressApp: express: obj -> obj
    abstract getResponsePrototype: unit -> Http.ServerResponse
    abstract getRequestPrototype: unit -> Http.IncomingMessage

type IExports =
    [<Emit("new $0($1)")>] abstract Create: string -> IWebSocketClient
    abstract Server: IServerStatic with get, set
    abstract http: IUwsHttp with get, set

[<Import("default","uws")>]
let uws:IExports = jsNative
