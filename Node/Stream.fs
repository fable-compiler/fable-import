module rec Fable.Import.Node.Stream

open Fable.Core
open Fable.Import.JS
open Fable.Import.Node


/// Legacy Stream Representation
type [<AllowNullLiteral>] Stream =
    inherit Events.EventEmitter

type [<AllowNullLiteral>] StreamStatic =
    [<Emit("new $0()")>] abstract Create: unit -> Stream

type [<AllowNullLiteral>] ReadableOptions<'a> =
    /// The maximum number of bytes to store in the internal buffer before ceasing to read from the underlying resource. Defaults to 16384 (16kb), or 16 for objectMode streams
    abstract highWaterMark: int option with get, set
    /// If specified, then buffers will be decoded to strings using the specified encoding. Defaults to null
    abstract encoding: Buffer.BufferEncoding option with get, set
    /// Whether this stream should behave as a stream of objects. Meaning that stream.read(n) returns a single value instead of a Buffer of size n. Defaults to false
    abstract objectMode: bool option with get, set
    /// All Readable stream implementations must provide an implementation of the readable._read() method to fetch data from the underlying resource.
    /// When readable._read() is called, if data is available from the resource, the implementation should begin pushing that data into the read queue using the this.push(dataChunk) method. _read() should continue reading from the resource and pushing data until readable.push() returns false. Only when _read() is called again after it has stopped should it resume pushing additional data onto the queue.
    /// Note: Once the readable._read() method has been called, it will not be called again until the readable.push() method is called.
    /// The size argument is advisory. For implementations where a "read" is a single operation that returns data can use the size argument to determine how much data to fetch. Other implementations may ignore this argument and simply provide data whenever it becomes available. There is no need to "wait" until size bytes are available before calling stream.push(chunk).
    abstract read: (int -> 'a) option with get, set

/// Readable streams are an abstraction for a source from which data is consumed.
type [<AllowNullLiteral>] Readable<'a> =
    inherit Stream
    /// Legacy. Always returns true.
    abstract readable: bool with get, set
    /// When chunk is a Buffer, Uint8Array or string, the chunk of data will be added to the internal queue for users of the stream to consume. Passing chunk as null signals the end of the stream (EOF), after which no more data can be written.
    /// When the Readable is operating in paused mode, the data added with readable.push() can be read out by calling the readable.read() method when the 'readable' event is emitted.
    /// When the Readable is operating in flowing mode, the data added with readable.push() will be delivered by emitting a 'data' event.
    /// The readable.push() method is designed to be as flexible as possible. For example, when wrapping a lower-level source that provides some form of pause/resume mechanism, and a data callback, the low-level source can be wrapped by the custom Readable instance
    abstract push: chunk: 'a option * ?encoding: Buffer.BufferEncoding -> bool
    /// The readable.unshift() method pushes a chunk of data back into the internal buffer. This is useful in certain situations where a stream is being consumed by code that needs to "un-consume" some amount of data that it has optimistically pulled out of the source, so that the data can be passed on to some other party.
    /// Note: The stream.unshift(chunk) method cannot be called after the 'end' event has been emitted or a runtime error will be thrown.
    /// Developers using stream.unshift() often should consider switching to use of a Transform stream instead. 
    abstract unshift: chunk: 'a -> unit
    /// The readable.pipe() method attaches a Writable stream to the readable, causing it to switch automatically into flowing mode and push all of its data to the attached Writable. The flow of data will be automatically managed so that the destination Writable stream is not overwhelmed by a faster Readable stream.
    abstract pipe<'b when 'b :> Stream.Writable<'a> > : destination: 'b * ?options: obj -> 'b
    /// The readable.unpipe() method detaches a Writable stream previously attached using the stream.pipe() method.
    /// If the destination is not specified, then all pipes are detached.
    /// If the destination is specified, but no pipe is set up for it, then the method does nothing.
    abstract unpipe: ?destination: Writable<'a> -> unit
    /// Versions of Node.js prior to v0.10 had streams that did not implement the entire stream module API as it is currently defined. (See Compatibility for more information.)
    /// When using an older Node.js library that emits 'data' events and has a stream.pause() method that is advisory only, the readable.wrap() method can be used to create a Readable stream that uses the old stream as its data source.
    /// It will rarely be necessary to use readable.wrap() but the method has been provided as a convenience for interacting with older Node.js applications and libraries.
    abstract wrap: oldStream: Stream -> Readable<'a>
    /// The readable.pause() method will cause a stream in flowing mode to stop emitting 'data' events, switching out of flowing mode. Any data that becomes available will remain in the internal buffer.
    abstract pause: unit -> Readable<'a>
    /// The readable.resume() method causes an explicitly paused Readable stream to resume emitting 'data' events, switching the stream into flowing mode.
    /// The readable.resume() method can be used to fully consume the data from a stream without actually processing any of that data.
    abstract resume: unit -> Readable<'a>
    /// The readable.isPaused() method returns the current operating state of the Readable. This is used primarily by the mechanism that underlies the readable.pipe() method. In most typical cases, there will be no reason to use this method directly.
    abstract isPaused: unit -> bool
    /// The readable.setEncoding() method sets the character encoding for data read from the Readable stream.
    /// By default, no encoding is assigned and stream data will be returned as Buffer objects. Setting an encoding causes the stream data to be returned as strings of the specified encoding rather than as Buffer objects. For instance, calling readable.setEncoding('utf8') will cause the output data to be interpreted as UTF-8 data, and passed as strings. Calling readable.setEncoding('hex') will cause the data to be encoded in hexadecimal string format.
    /// The Readable stream will properly handle multi-byte characters delivered through the stream that would otherwise become improperly decoded if simply pulled from the stream as Buffer objects.
    abstract setEncoding: Buffer.BufferEncoding -> unit
    /// The readable.read() method pulls some data out of the internal buffer and returns it. If no data available to be read, null is returned. By default, the data will be returned as a Buffer object unless an encoding has been specified using the readable.setEncoding() method or the stream is operating in object mode.
    /// The optional size argument specifies a specific number of bytes to read. If size bytes are not available to be read, null will be returned unless the stream has ended, in which case all of the data remaining in the internal buffer will be returned.
    /// If the size argument is not specified, all of the data contained in the internal buffer will be returned.
    /// The readable.read() method should only be called on Readable streams operating in paused mode. In flowing mode, readable.read() is called automatically until the internal buffer is fully drained.
    abstract read: ?size: int -> 'a option

type [<AllowNullLiteral>] ReadableStatic =
    [<Emit("new $0($1)")>] abstract Create<'a> : readableOptions:ReadableOptions<'a> -> Readable<'a>
    [<Emit("new $0($1)")>] abstract Create<'a> : unit -> Readable<'a>

type [<AllowNullLiteral>] WritevChunk<'a> =
    abstract chunk: 'a with get, set
    abstract encoding: Buffer.BufferEncoding with get, set

type [<AllowNullLiteral>] WritableOptions<'a> =
    /// Buffer level when stream.write() starts returning false. Defaults to 16384 (16kb), or 16 for objectMode streams.
    abstract highWaterMark: int option with get, set
    /// Whether or not to decode strings into Buffers before passing them to stream._write(). Defaults to true
    abstract decodeStrings: bool option with get, set
    /// Whether or not the stream.write(anyObj) is a valid operation. When set, it becomes possible to write JavaScript values other than string or Buffer if supported by the stream implementation. Defaults to false
    abstract objectMode: bool option with get, set
    /// The callback method must be called to signal either that the write completed successfully or failed with an error. The first argument passed to the callback must be the Error object if the call failed or null if the write succeeded.
    /// It is important to note that all calls to writable.write() that occur between the time writable._write() is called and the callback is called will cause the written data to be buffered. Once the callback is invoked, the stream will emit a 'drain' event. If a stream implementation is capable of processing multiple chunks of data at once, the writable._writev() method should be implemented.
    /// If the decodeStrings property is set in the constructor options, then chunk may be a string rather than a Buffer, and encoding will indicate the character encoding of the string. This is to support implementations that have an optimized handling for certain string data encodings. If the decodeStrings property is explicitly set to false, the encoding argument can be safely ignored, and chunk will remain the same object that is passed to .write().
    /// The writable._write() method is prefixed with an underscore because it is internal to the class that defines it, and should never be called directly by user programs.
    abstract write: ('a -> Buffer.BufferEncoding -> (Error option -> unit) -> unit) option with get, set
    /// The writable._writev() method may be implemented in addition to writable._write() in stream implementations that are capable of processing multiple chunks of data at once. If implemented, the method will be called with all chunks of data currently buffered in the write queue.
    /// The writable._writev() method is prefixed with an underscore because it is internal to the class that defines it, and should never be called directly by user programs.
    abstract writev: Option<Array<WritevChunk<'a>> -> (Error option -> unit) -> unit> with get, set

type [<AllowNullLiteral>] Writable<'a> =
    inherit Stream
    /// Legacy. Always returns true.
    abstract writable: bool with get, set
    /// The writable.write() method writes some data to the stream, and calls the supplied callback once the data has been fully handled. If an error occurs, the callback may or may not be called with the error as its first argument. To reliably detect write errors, add a listener for the 'error' event.
    /// The return value is true if the internal buffer is less than the highWaterMark configured when the stream was created after admitting chunk. If false is returned, further attempts to write data to the stream should stop until the 'drain' event is emitted.
    /// While a stream is not draining, calls to write() will buffer chunk, and return false. Once all currently buffered chunks are drained (accepted for delivery by the operating system), the 'drain' event will be emitted. It is recommended that once write() returns false, no more chunks be written until the 'drain' event is emitted. While calling write() on a stream that is not draining is allowed, Node.js will buffer all written chunks until maximum memory usage occurs, at which point it will abort unconditionally. Even before it aborts, high memory usage will cause poor garbage collector performance and high RSS (which is not typically released back to the system, even after the memory is no longer required). Since TCP sockets may never drain if the remote peer does not read the data, writing a socket that is not draining may lead to a remotely exploitable vulnerability.
    ///  Writing data while the stream is not draining is particularly problematic for a Transform, because the Transform streams are paused by default until they are piped or an 'data' or 'readable' event handler is added.
    /// If the data to be written can be generated or fetched on demand, it is recommended to encapsulate the logic into a Readable and use stream.pipe(). However, if calling write() is preferred, it is possible to respect backpressure and avoid memory issues using the 'drain' event.
    abstract write: chunk: 'a -> bool
    abstract write: chunk: 'a * encoding: Buffer.BufferEncoding * ?cb: (Error option -> unit) -> bool
    abstract write: chunk: 'a * cb: (Error option -> unit) -> bool
    /// Calling the writable.end() method signals that no more data will be written to the Writable. The optional chunk and encoding arguments allow one final additional chunk of data to be written immediately before closing the stream. If provided, the optional callback function is attached as a listener for the 'finish' event.
    /// Calling the stream.write() method after calling stream.end() will raise an error.
    abstract ``end``: cb: unit -> unit
    abstract ``end``: chunk: 'a -> unit
    abstract ``end``: chunk: 'a * cb: (unit -> unit) -> unit
    abstract ``end``: chunk: 'a * encoding: Buffer.BufferEncoding * ?cb: (unit -> unit) -> unit

type [<AllowNullLiteral>] WritableStatic =
    [<Emit("new $0($1)")>] abstract Create<'a> : writableOptions:WritableOptions<'a> -> Writable<'a>
    [<Emit("new $0($1)")>] abstract Create<'a> : unit -> Writable<'a>

type [<AllowNullLiteral>] DuplexOptions<'a, 'b> =
    /// Whether or not to decode strings into Buffers before passing them to stream._write(). Defaults to true
    abstract decodeStrings: bool option with get, set
    /// If specified, then buffers will be decoded to strings using the specified encoding. Defaults to null
    abstract encoding: Buffer.BufferEncoding with get, set
    /// Whether or not the stream.write(anyObj) is a valid operation. When set, it becomes possible to write JavaScript values other than string or Buffer if supported by the stream implementation. Defaults to false
    abstract objectMode: bool option with get, set
    /// Defaults to true. If set to false, then the stream will automatically end the writable side when the readable side ends.
    abstract allowHalfOpen: bool option with get, set
    /// Defaults to false. Sets objectMode for readable side of the stream. Has no effect if objectMode is true.
    abstract readableObjectMode: bool option with get, set
    /// Defaults to false. Sets objectMode for writable side of the stream. Has no effect if objectMode is true.
    abstract writableObjectMode: bool option with get, set
    /// All Readable stream implementations must provide an implementation of the readable._read() method to fetch data from the underlying resource.
    /// When readable._read() is called, if data is available from the resource, the implementation should begin pushing that data into the read queue using the this.push(dataChunk) method. _read() should continue reading from the resource and pushing data until readable.push() returns false. Only when _read() is called again after it has stopped should it resume pushing additional data onto the queue.
    /// Note: Once the readable._read() method has been called, it will not be called again until the readable.push() method is called.
    /// The size argument is advisory. For implementations where a "read" is a single operation that returns data can use the size argument to determine how much data to fetch. Other implementations may ignore this argument and simply provide data whenever it becomes available. There is no need to "wait" until size bytes are available before calling stream.push(chunk).
    abstract read: (int -> 'b) option with get, set
    /// The callback method must be called to signal either that the write completed successfully or failed with an error. The first argument passed to the callback must be the Error object if the call failed or null if the write succeeded.
    /// It is important to note that all calls to writable.write() that occur between the time writable._write() is called and the callback is called will cause the written data to be buffered. Once the callback is invoked, the stream will emit a 'drain' event. If a stream implementation is capable of processing multiple chunks of data at once, the writable._writev() method should be implemented.
    /// If the decodeStrings property is set in the constructor options, then chunk may be a string rather than a Buffer, and encoding will indicate the character encoding of the string. This is to support implementations that have an optimized handling for certain string data encodings. If the decodeStrings property is explicitly set to false, the encoding argument can be safely ignored, and chunk will remain the same object that is passed to .write().
    /// The writable._write() method is prefixed with an underscore because it is internal to the class that defines it, and should never be called directly by user programs.
    abstract write: ('a -> Buffer.BufferEncoding -> (Error option -> unit) -> unit) option with get, set
    /// The writable._writev() method may be implemented in addition to writable._write() in stream implementations that are capable of processing multiple chunks of data at once. If implemented, the method will be called with all chunks of data currently buffered in the write queue.
    /// The writable._writev() method is prefixed with an underscore because it is internal to the class that defines it, and should never be called directly by user programs.
    abstract writev: Option<Array<WritevChunk<'a>> -> (Error option -> unit) -> unit> with get, set

type [<AllowNullLiteral>] Duplex<'a, 'b> =
    inherit Writable<'a>
    inherit Readable<'b>

type [<AllowNullLiteral>] DuplexStatic =
    [<Emit("new $0($1)")>] abstract Create<'a, 'b> : duplexOptions:DuplexOptions<'a, 'b> -> Duplex<'a, 'b>

type [<AllowNullLiteral>] TransformOptions<'a, 'b> =
    /// Whether or not to decode strings into Buffers before passing them to stream._write(). Defaults to true
    abstract decodeStrings: bool option with get, set
    /// If specified, then buffers will be decoded to strings using the specified encoding. Defaults to null
    abstract encoding: Buffer.BufferEncoding option with get, set
    /// Defaults to true. If set to false, then the stream will automatically end the writable side when the readable side ends.
    abstract objectMode: bool option with get, set
    /// Defaults to true. If set to false, then the stream will automatically end the writable side when the readable side ends.
    abstract allowHalfOpen: bool option with get, set
    /// Defaults to false. Sets objectMode for readable side of the stream. Has no effect if objectMode is true.
    abstract readableObjectMode: bool option with get, set
    /// Defaults to false. Sets objectMode for writable side of the stream. Has no effect if objectMode is true.
    abstract writableObjectMode: bool option with get, set
    /// All Transform stream implementations must provide a _transform() method to accept input and produce output. The transform._transform() implementation handles the bytes being written, computes an output, then passes that output off to the readable portion using the readable.push() method.
    /// The transform.push() method may be called zero or more times to generate output from a single input chunk, depending on how much is to be output as a result of the chunk.
    /// It is possible that no output is generated from any given chunk of input data.
    /// The callback function must be called only when the current chunk is completely consumed. The first argument passed to the callback must be an Error object if an error occurred while processing the input or null otherwise. If a second argument is passed to the callback, it will be forwarded on to the readable.push() method.
    /// Transform._transform() is never called in parallel; streams implement a queue mechanism, and to receive the next chunk, callback must be called, either synchronously or asynchronously.
    abstract transform: 'a -> string -> (Error option * 'b option -> unit) -> unit option
    /// In some cases, a transform operation may need to emit an additional bit of data at the end of the stream. For example, a zlib compression stream will store an amount of internal state used to optimally compress the output. When the stream ends, however, that additional data needs to be flushed so that the compressed data will be complete.
    /// Custom Transform implementations may implement the transform._flush() method. This will be called when there is no more written data to be consumed, but before the 'end' event is emitted signaling the end of the Readable stream.
    /// Within the transform._flush() implementation, the readable.push() method may be called zero or more times, as appropriate. The callback function must be called when the flush operation is complete.
    /// The transform._flush() method is prefixed with an underscore because it is internal to the class that defines it, and should never be called directly by user programs.
    abstract flush: (Error option -> unit) -> unit option

type [<AllowNullLiteral>] Transform<'a, 'b> =
    inherit Writable<'a>
    inherit Readable<'b>
    /// All Transform stream implementations must provide a _transform() method to accept input and produce output. The transform._transform() implementation handles the bytes being written, computes an output, then passes that output off to the readable portion using the readable.push() method.
    /// The transform.push() method may be called zero or more times to generate output from a single input chunk, depending on how much is to be output as a result of the chunk.
    /// It is possible that no output is generated from any given chunk of input data.
    /// The callback function must be called only when the current chunk is completely consumed. The first argument passed to the callback must be an Error object if an error occurred while processing the input or null otherwise. If a second argument is passed to the callback, it will be forwarded on to the readable.push() method.
    /// Transform._transform() is never called in parallel; streams implement a queue mechanism, and to receive the next chunk, callback must be called, either synchronously or asynchronously.
    abstract _transform: chunk: 'a * encoding: string * callback: (Error option * 'b option -> unit) -> unit
    /// In some cases, a transform operation may need to emit an additional bit of data at the end of the stream. For example, a zlib compression stream will store an amount of internal state used to optimally compress the output. When the stream ends, however, that additional data needs to be flushed so that the compressed data will be complete.
    /// Custom Transform implementations may implement the transform._flush() method. This will be called when there is no more written data to be consumed, but before the 'end' event is emitted signaling the end of the Readable stream.
    /// Within the transform._flush() implementation, the readable.push() method may be called zero or more times, as appropriate. The callback function must be called when the flush operation is complete.
    /// The transform._flush() method is prefixed with an underscore because it is internal to the class that defines it, and should never be called directly by user programs.
    abstract _flush: callback: (Error option -> unit) -> unit

type [<AllowNullLiteral>] TransformStatic =
    [<Emit("new $0($1)")>] abstract Create<'a, 'b> : transformOptions:TransformOptions<'a, 'b> -> Transform<'a, 'b>


type [<AllowNullLiteral>] PassThrough<'a> =
    inherit Transform<'a, 'a>

type [<AllowNullLiteral>] PassThroughStatic =
    [<Emit("new $0()")>] abstract Create<'a> : unit -> PassThrough<'a>

type IExports =
    abstract Stream: StreamStatic with get, set
    abstract Readable: ReadableStatic with get, set
    abstract Writable: WritableStatic with get, set
    abstract Duplex: DuplexStatic with get, set
    abstract Transform: TransformStatic with get, set
    abstract PassThrough: PassThroughStatic with get, set
