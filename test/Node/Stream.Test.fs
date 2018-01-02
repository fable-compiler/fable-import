module Fable.Import.Node.Stream.Test

open Fable.Import.Node
open Buffer
open Fable.Import.Jest
open Fable.PowerPack
open Matchers
open Fable.Core.JsInterop

let private toBuffer (x:string) = 
    Buffer.Buffer.from x

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
    let r = Stream.PassThrough.Create<Buffer.Buffer>()
    let w = Stream.PassThrough.Create<_>()

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

    let r = Stream.Readable.Create<Buffer>(readableOpts)
        
    let transformOpts = createEmpty<Stream.TransformOptions<Buffer, Buffer>>

    transformOpts.transform <- Some (fun chunk _ cb ->
        cb None (Some (Buffer.Buffer.concat([| chunk; toBuffer "bar" |])))
    )

    let t = Stream.Transform.Create(transformOpts)

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
    let w = Stream.Writable.Create(writableOpts)

    w.write(toBuffer "foo")
        |> ignore