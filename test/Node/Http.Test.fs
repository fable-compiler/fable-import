module Fable.Import.Node.Http.Test

#nowarn "40"

open Fable.Import.Jest
open Matchers
open Fable.Import.Node

testList "http foo server" [
    let withSetup f (d:Bindings.DoneStatic) =
        let server = 
            http.createServer(fun _ resp ->
              resp.``end``("foo")
            ).listen(8081, "0.0.0.0")
            
        let fin () =
            server.close(fun _ -> d.``done``())
                |> ignore

        let rec req = http.get("http://0.0.0.0:8081", fun resp ->
                f req resp fin
            )

        ()

    yield! testFixtureDone withSetup [
        "should emit data", fun req resp fin ->
            expect.assertions 1

            resp
                .on("data", fun x ->
                    x == buffer.Buffer.from("foo")
                )
                .on("end", fin)
                |> ignore

            req.``end``("blah")
        "should have statusCode", fun req resp fin ->
            resp.statusCode == Some(200)

            req.``end``()

            fin()
    ]
]  
