module Fable.Import.Node.Stream.Test

open Fable.Import.Node
open Buffer
open Fable.Import.Jest
open Fable.PowerPack
open Matchers
open Fable.Core.JsInterop

let private toBuffer (x:string) = 
    buffer.Buffer.from x

let private collectToPromise (x:Stream.Writable<'a>) =
    Promise.create(fun res rej -> 
        let mutable b = []

        x.on("data", fun (x:'a) ->
            b <- x :: b
        ) 
            |> ignore

        x.once("end", fun () -> res b) 
            |> ignore
    )


testAsync "piping streams" <| fun () ->
    let r = stream.PassThrough.Create<Buffer.Buffer>()
    let w = stream.PassThrough.Create<_>()

    r.``end`` (toBuffer "foo")
        |> ignore

    promise {
        let w' = r.pipe(w)

        let! b = 
            w'
                |> collectToPromise

        b == [toBuffer "foo"]
    }

testAsync "transform stream" <| fun () ->
    let readableOpts = createEmpty<Stream.ReadableOptions>
    readableOpts.read <- Some (fun _ -> 
        let self:Stream.Readable<Buffer> = jsThis

        self.push("foo" |> toBuffer |> Some)
            |> ignore
        self.push(None)
            |> ignore
    )

    let r = stream.Readable.Create<Buffer>(readableOpts)
        
    let transformOpts = createEmpty<Stream.TransformOptions<Buffer, Buffer>>

    transformOpts.transform <- Some (fun chunk _ cb ->
        cb None (Some (buffer.Buffer.concat([| chunk; toBuffer "bar" |])))
    )

    let t = stream.Transform.Create(transformOpts)

    promise {
        let t' = r.pipe(t)

        let! b =
            t'
                |> collectToPromise

        b == [ toBuffer "foobar" ]
    }

testDone "writable stream" <| fun (d) ->
    let writableOpts = createEmpty<Stream.WritableOptions<Buffer>>
    writableOpts.write <- Some(fun x _ cb ->
        x == toBuffer "foo"
        cb(None)
        d.``done``()
    )

    let w = stream.Writable.Create(writableOpts)

    w.write(toBuffer "foo")
        |> ignore

type TestRecord = {
    foo: string;
}

test "creating a passThrough with opts" <| fun () ->
    let passThroughOpts = createEmpty<Stream.PassThroughOptions<TestRecord>>
    passThroughOpts.objectMode <- Some true

    let ps = stream.PassThrough.Create passThroughOpts
    ps.write({ foo = "bar" })
        |> ignore

    ps.read() == Some { foo = "bar" }
