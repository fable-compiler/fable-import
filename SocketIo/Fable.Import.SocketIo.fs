module rec Fable.Import.SocketIo
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Node

type [<AllowNullLiteral>] Server =
    inherit Events.EventEmitter
    abstract engine: obj with get, set
    abstract nsps: obj with get, set
    abstract sockets: Namespace with get, set
    abstract json: Server with get, set
    abstract checkRequest: req: obj * fn: (obj -> bool -> unit) -> unit
    abstract serveClient: unit -> bool
    abstract serveClient: v: bool -> Server
    abstract path: unit -> string
    abstract path: v: string -> Server
    abstract adapter: unit -> obj
    abstract adapter: v: obj -> Server
    abstract origins: unit -> string
    abstract origins: v: string -> Server
    abstract attach: srv: obj * ?opts: ServerOptions -> Server
    abstract attach: port: float * ?opts: ServerOptions -> Server
    abstract listen: srv: obj * ?opts: ServerOptions -> Server
    abstract listen: port: float * ?opts: ServerOptions -> Server
    abstract bind: srv: obj -> Server
    abstract onconnection: socket: obj -> Server
    abstract ``of``: nsp: string -> Namespace
    abstract close: ?fn: (unit -> unit) -> unit
    [<Emit("$0.on('connection',$1...)")>] abstract on_connection: listener: (Socket -> unit) -> Namespace
    [<Emit("$0.on('connect',$1...)")>] abstract on_connect: listener: (Socket -> unit) -> Namespace
    abstract on: ``event``: string * listener: Function -> Namespace
    abstract ``to``: room: string -> Namespace
    abstract ``in``: room: string -> Namespace
    abstract ``use``: fn: (Socket -> (obj -> unit) -> unit) -> Namespace
    abstract emit: ``event``: string * [<ParamArray>] args: obj[] -> Namespace
    abstract send: [<ParamArray>] args: obj[] -> Namespace
    abstract write: [<ParamArray>] args: obj[] -> Namespace
    abstract clients: [<ParamArray>] args: obj[] -> Namespace
    abstract compress: [<ParamArray>] args: obj[] -> Namespace

type [<AllowNullLiteral>] ServerOptions =
    abstract path: string option with get, set
    abstract serveClient: bool option with get, set
    abstract adapter: Adapter option with get, set
    abstract origins: string option with get, set
    abstract pingTimeout: float option with get, set
    abstract pingInterval: float option with get, set
    abstract maxHttpBufferSize: float option with get, set
    abstract allowRequest: (obj -> (float -> bool -> unit) -> unit) option with get, set
    abstract transports: ResizeArray<string> option with get, set
    abstract allowUpgrades: bool option with get, set
    abstract perMessageDeflate: U2<obj, bool> option with get, set
    abstract httpCompression: U2<obj, bool> option with get, set
    abstract cookie: U2<string, bool> option with get, set

type [<AllowNullLiteral>] ServerStatic =
    [<Emit("$0($1...)")>] abstract Invoke: unit -> Server
    [<Emit("$0($1...)")>] abstract Invoke: srv: obj * ?opts: ServerOptions -> Server
    [<Emit("$0($1...)")>] abstract Invoke: port: string * ?opts: ServerOptions -> Server
    [<Emit("$0($1...)")>] abstract Invoke: port: float * ?opts: ServerOptions -> Server
    [<Emit("$0($1...)")>] abstract Invoke: opts: ServerOptions -> Server

type [<AllowNullLiteral>] Namespace =
    inherit Events.EventEmitter
    abstract name: string with get, set
    abstract server: Server with get, set
    abstract sockets: obj with get, set
    abstract connected: obj with get, set
    abstract adapter: Adapter with get, set
    abstract json: Namespace with get, set
    abstract ``use``: fn: (Socket -> (obj -> unit) -> unit) -> Namespace
    abstract ``to``: room: string -> Namespace
    abstract ``in``: room: string -> Namespace
    abstract send: [<ParamArray>] args: obj[] -> Namespace
    abstract write: [<ParamArray>] args: obj[] -> Namespace
    [<Emit("$0.on('connection',$1...)")>] abstract on_connection: listener: (Socket -> unit) -> obj
    [<Emit("$0.on('connect',$1...)")>] abstract on_connect: listener: (Socket ->  unit) -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract clients: fn: Function -> Namespace
    abstract compress: compress: bool -> Namespace

type [<AllowNullLiteral>] Packet =
  abstract ``type``: string with get, set
  abstract data: Option<obj> with get, set
  abstract id: int option with get, set

type SocketUseArgs<'T> = string * 'T option * (obj -> unit) option

type [<AllowNullLiteral>] Socket =
    inherit Events.EventEmitter
    abstract nsp: Namespace with get, set
    abstract server: Server with get, set
    abstract adapter: Adapter with get, set
    abstract id: string with get, set
    abstract request: obj with get, set
    abstract client: Client with get, set
    abstract conn: EngineSocket with get, set
    abstract rooms: obj with get, set
    abstract connected: bool with get, set
    abstract disconnected: bool with get, set
    abstract handshake: obj with get, set
    abstract json: Socket with get, set
    abstract ``volatile``: Socket with get, set
    abstract broadcast: Socket with get, set
    abstract ``to``: room: string -> Socket
    abstract ``in``: room: string -> Socket
    abstract send: [<ParamArray>] args: obj[] -> Socket
    abstract write: [<ParamArray>] args: obj[] -> Socket
    abstract join: name: string * ?fn: (obj ->  unit) -> Socket
    abstract leave: name: string * ?fn: Function -> Socket
    abstract leaveAll: unit -> unit
    abstract disconnect: ?close: bool -> Socket
    abstract listeners: ``event``: string -> ResizeArray<Function>
    abstract compress: compress: bool -> Socket
    abstract ``use``: fn:('a -> (Error option -> unit) -> unit) -> Socket

type [<AllowNullLiteral>] Adapter =
    inherit Events.EventEmitter
    abstract nsp: Namespace with get, set
    abstract rooms: obj with get, set
    abstract sids: obj with get, set
    abstract add: id: string * room: string * ?callback: (obj ->  unit) -> unit
    abstract del: id: string * room: string * ?callback: (obj ->  unit) -> unit
    abstract delAll: id: string -> unit
    abstract broadcast: packet: obj * opts: obj -> unit

type [<AllowNullLiteral>] Client =
    abstract server: Server with get, set
    abstract conn: EngineSocket with get, set
    abstract id: string with get, set
    abstract request: obj with get, set
    abstract sockets: obj with get, set
    abstract nsps: obj with get, set

type [<AllowNullLiteral>] EngineSocket =
    inherit Events.EventEmitter
    abstract id: string with get, set
    abstract server: obj with get, set
    abstract readyState: string with get, set
    abstract remoteAddress: string with get, set
    abstract upgraded: bool with get, set
    abstract request: obj with get, set
    abstract transport: obj with get, set


[<Import("default","socket.io")>]
let ``socket.io``:ServerStatic = jsNative

