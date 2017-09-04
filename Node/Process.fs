module rec Fable.Import.Node.Process

open System
open Fable.Core
open Fable.Import.Node
open Fable.Import.Node.Base
open Fable.Import.JS

type [<AllowNullLiteral>] Process =
      abstract addListener: ``event``: U2<string, Symbol> * listener: Function -> obj
      abstract on: ``event``: U2<string, Symbol> * listener: Function -> obj
      abstract once: ``event``: U2<string, Symbol> * listener: Function -> obj
      abstract removeListener: ``event``: U2<string, Symbol> * listener: Function -> obj
      abstract removeAllListeners: ?``event``: U2<string, Symbol> -> obj
      abstract setMaxListeners: n: float -> obj
      abstract getMaxListeners: unit -> float
      abstract listeners: ``event``: U2<string, Symbol> -> ResizeArray<Function>
      abstract emit: ``event``: U2<string, Symbol> * [<ParamArray>] args: obj[] -> bool
      abstract listenerCount: ``type``: U2<string, Symbol> -> float
      abstract prependListener: ``event``: U2<string, Symbol> * listener: Function -> obj
      abstract prependOnceListener: ``event``: U2<string, Symbol> * listener: Function -> obj
      abstract eventNames: unit -> ResizeArray<U2<string, Symbol>>
      abstract stdout: Stream.Writable<string> with get, set
      abstract stderr: Stream.Writable<string> with get, set
      abstract stdin: Stream.Readable<string> with get, set
      abstract argv: ResizeArray<string> with get, set
      abstract argv0: string with get, set
      abstract execArgv: ResizeArray<string> with get, set
      abstract execPath: string with get, set
      abstract env: obj with get, set
      abstract exitCode: float with get, set
      abstract version: string with get, set
      abstract config: obj with get, set
      abstract pid: float with get, set
      abstract title: string with get, set
      abstract arch: NodeJS.Arch with get, set
      abstract platform: NodeJS.Platform with get, set
      abstract connected: bool with get, set
      abstract abort: unit -> unit
      abstract chdir: directory: string -> unit
      abstract cwd: unit -> string
      abstract exit: ?code: int -> unit
      abstract getgid: unit -> float
      abstract setgid: id: float -> unit
      abstract setgid: id: string -> unit
      /// The process.getuid() method returns the numeric user identity of the process. (See getuid(2).)
      abstract getuid: unit -> float
      /// The process.geteuid() method returns the numerical effective user identity of the process. (See geteuid(2).)    
      abstract geteuid: unit -> float
      abstract setuid: id: float -> unit
      abstract setuid: id: string -> unit
      abstract kill: pid: float * ?signal: U2<string, float> -> unit
      abstract nextTick: callback: Function * [<ParamArray>] args: obj[] -> unit
      abstract umask: ?mask: float -> float
      abstract uptime: unit -> float
      abstract hrtime: ?time: float * float -> float * float
      abstract send: message: obj * ?sendHandle: obj -> unit
      abstract disconnect: unit -> unit