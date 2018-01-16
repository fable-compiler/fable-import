module Fable.Import.Node.Net

open Fable.Core
open Fable.Import.JS
open Fable.Import.Node

type [<AllowNullLiteral>] Socket =
    inherit Stream.Readable<Buffer.Buffer>
    inherit Stream.Writable<Buffer.Buffer>
    abstract bufferSize: float with get, set
    abstract remoteAddress: string with get, set
    abstract remoteFamily: string with get, set
    abstract remotePort: float with get, set
    abstract localAddress: string with get, set
    abstract localPort: float with get, set
    abstract bytesRead: float with get, set
    abstract bytesWritten: float with get, set
    abstract connect: port: float * ?host: string * ?connectionListener:(Socket -> unit) -> unit
    abstract connect: path: string * ?connectionListener:(Socket -> unit) -> unit
    abstract setEncoding: ?encoding: string -> unit
    abstract destroy: unit -> unit
    abstract destroyed: bool
    abstract setTimeout: timeout: float * ?callback: Function -> unit
    abstract setNoDelay: ?noDelay: bool -> unit
    abstract setKeepAlive: ?enable: bool * ?initialDelay: float -> unit
    abstract address: unit -> obj
    abstract unref: unit -> unit
    abstract ref: unit -> unit

type [<AllowNullLiteral>] SocketStatic =
    [<Emit("new $0()")>] abstract Create: unit -> Socket

type [<AllowNullLiteral>] Fd =
    abstract fd: int with get, set

type [<AllowNullLiteral>] Server =
    inherit Socket
    abstract maxConnections: float with get, set
    abstract connections: float with get, set
    abstract listen: port: float * ?host: string * ?backlog: float * ?listeningListener:(unit -> unit) -> Server
    abstract listen: path: string * ?listeningListener:(unit -> unit) -> Server
    abstract listen: handle: Fd * ?listeningListener:(unit -> unit) -> Server
    abstract listen: handle: obj * ?listeningListener:(unit -> unit) -> Server
    abstract close: ?callback: Function -> Server
    abstract address: unit -> obj

type [<AllowNullLiteral>] ServerStatic =
    [<Emit("new $0()")>] abstract Create: unit -> Server

type [<AllowNullLiteral>] CreateServerOptions =
    abstract allowHalfOpen: bool option with get, set
    abstract pauseOnConnect: bool option with get, set

type IExports =
    abstract Socket: SocketStatic with get, set
    abstract createServer: ?connectionListener:(Socket -> unit) -> Server
    abstract createServer: ?options: CreateServerOptions * ?connectionListener:(Socket -> unit) -> Server
    abstract connect: options: obj * ?connectionListener:(Socket -> unit) -> Socket
    abstract connect: port: float * ?host: string * ?connectionListener:(Socket -> unit) -> Socket
    abstract connect: path: string * ?connectionListener:(Socket -> unit) -> Socket
    abstract createConnection: options: obj * ?connectionListener:(Socket -> unit) -> Socket
    abstract createConnection: port: float * ?host: string * ?connectionListener:(Socket -> unit) -> Socket
    abstract createConnection: path: string * ?connectionListener:(Socket -> unit) -> Socket
    abstract isIP: input: string -> float
    abstract isIPv4: input: string -> bool
    abstract isIPv6: input: string -> bool
