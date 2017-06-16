module rec Fable.Import.Pg
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Node
open System.Collections.Generic

type [<AllowNullLiteral>] ConnectionConfig =
    abstract user: string option with get, set
    abstract database: string option with get, set
    abstract password: string option with get, set
    abstract port: float option with get, set
    abstract host: string option with get, set

type [<AllowNullLiteral>] Defaults =
    inherit ConnectionConfig
    abstract poolSize: float option with get, set
    abstract poolIdleTimeout: float option with get, set
    abstract reapIntervalMillis: float option with get, set
    abstract binary: bool option with get, set
    abstract parseInt8: bool option with get, set

type [<AllowNullLiteral>] ClientConfig =
    inherit ConnectionConfig
    abstract ssl: bool option with get, set

type [<AllowNullLiteral>] PoolConfig =
    inherit ClientConfig
    abstract max: float option with get, set
    abstract min: float option with get, set
    abstract refreshIdle: bool option with get, set
    abstract idleTimeoutMillis: float option with get, set
    abstract reapIntervalMillis: float option with get, set
    abstract returnToHead: bool option with get, set
    abstract application_name: string option with get, set

type [<AllowNullLiteral>] QueryConfig =
    abstract name: string option with get, set
    abstract text: string with get, set
    abstract values: ResizeArray<obj> option with get, set

type [<AllowNullLiteral>] QueryResult =
    abstract command: string with get, set
    abstract rowCount: float with get, set
    abstract oid: float with get, set
    abstract rows: 'a array with get, set

type [<AllowNullLiteral>] ResultBuilder =
    inherit QueryResult
    abstract addRow: row: obj -> unit

type [<AllowNullLiteral>] Pool =
    inherit Events.EventEmitter
    abstract connect: unit -> Promise<Client>
    abstract connect: (Error -> Client -> (unit -> unit) -> unit) -> unit
    abstract ``end``: unit -> Promise<unit>
    abstract query: QueryConfig -> Promise<QueryResult>
    abstract query: string -> Promise<QueryResult>
    abstract query: obj -> Stream.Readable<Buffer.Buffer>
    abstract query: string * obj list -> Promise<QueryResult>
    abstract query: string * (Error -> QueryResult -> unit) -> Query
    abstract query: QueryConfig * (Error -> QueryResult -> unit) -> Query
    abstract query: string * obj list * (Error -> QueryResult -> unit) -> Query


type [<AllowNullLiteral>] PoolStatic =
    [<Emit("new $0($1)")>] abstract Create: PoolConfig -> Pool
    [<Emit("new $0($1)")>] abstract Create: unit -> Pool

type [<AllowNullLiteral>] Client =
    inherit Events.EventEmitter
    abstract connect: ?callback: (Error -> unit) -> unit
    abstract ``end``: ?callback: (Error -> unit) -> unit
    abstract release: ?err: Error -> unit
    abstract query: queryStream: obj -> Stream.Readable<Buffer.Buffer>
    abstract query: string -> Promise<QueryResult>
    abstract query: QueryConfig -> Promise<QueryResult>
    abstract query: string * ResizeArray<obj> -> Promise<QueryResult>
    abstract query: string * ResizeArray<obj> * (Error -> QueryResult -> unit) -> Query
    abstract query: string * (Error -> QueryResult -> unit) -> Query
    abstract query: QueryConfig * (Error -> QueryResult -> unit) -> Query
    abstract copyFrom: queryText: string -> Stream.Writable<string>
    abstract copyTo: queryText: string -> Stream.Readable<Buffer.Buffer>
    abstract pauseDrain: unit -> unit
    abstract resumeDrain: unit -> unit

type [<AllowNullLiteral>] ClientStatic =
    [<Emit("new $0($1)")>] abstract Create: ClientConfig -> Client

type [<AllowNullLiteral>] Query =
    inherit Events.EventEmitter
    abstract on:(string * (obj -> ResultBuilder -> unit)) -> Query
    abstract on:(string * (Error -> unit)) -> Query
    abstract on:(string * (ResultBuilder -> unit)) -> Query

type [<AllowNullLiteral>] QueryStatic =
    [<Emit("new $0()")>] abstract Create: unit -> Query

type IExports =
  abstract Pool: PoolStatic with get, set
  abstract Client: ClientStatic with get, set
  abstract Query: QueryStatic with get, set
  abstract types: obj with get, set
  abstract defaults: obj with get, set
  abstract connect: (string * (Error -> Client -> (obj -> unit) -> unit)) -> unit
  abstract connect: (ClientConfig * (Error -> Client -> (obj -> unit) -> unit)) -> unit
  abstract ``end``: unit -> unit

[<Import("*","pg")>]
let Pg:IExports = jsNative
