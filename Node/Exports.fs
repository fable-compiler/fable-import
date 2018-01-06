[<AutoOpen>]
module Fable.Import.Node.Exports

open Fable.Import.Node
open Fable.Core

[<Import("*", "buffer")>] 
let buffer: Buffer.IExports = jsNative

[<Import("*", "child_process")>]
let childProcess: ChildProcess.IExports = jsNative

[<Import("*", "events")>]
let events: Events.IExports = jsNative

[<Import("*", "fs")>]
let fs: Fs.IExports = jsNative

[<Import("*","net")>]
let net: Net.IExports = jsNative

[<Import("*","crypto")>] 
let crypto: Crypto.IExports = jsNative

[<Import("*","tls")>] 
let tls: Tls.IExports = jsNative

[<Import("*","http")>]
let http: Http.IExports = jsNative

[<Import("*","https")>]
let https: Https.IExports = jsNative

[<Import("*", "os")>]
let os: Os.IExports = jsNative

[<Import("*", "querystring")>]
let querystring: Querystring.IExports = jsNative

[<Import("*", "stream")>]
let stream: Stream.IExports = jsNative

[<Import("*", "url")>]
let url: Url.IExports = jsNative

[<Import("*", "path")>] 
let path: Path.IExports = jsNative