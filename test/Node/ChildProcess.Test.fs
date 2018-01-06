module Fable.Import.Node.PowerPack.ChildProcessTest

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.Jest
open Fable.PowerPack
open Matchers
open Fable.Import.Node
open Fable.Import.Node.ChildProcess

let toStr = function
  | U2.Case2(x:Buffer.Buffer) -> x.toString "utf8"
  | U2.Case1(x:string) -> x

let exec (cmd:string) = 
  Promise.create(fun res _ ->
    let cb (e:ExecError option) stdout' stderr' = 
      let stdout = stdout' |> toStr
      let stderr = stderr' |> toStr

      match e with
      | Some(err) -> 
        (err, stderr)
          |> Result.Error
          |> res
      | None -> 
        (stdout, stderr)
          |> Result.Ok
          |> res

    let opts = createEmpty<ChildProcess.ExecOptions>
    ChildProcess.exec (cmd, opts, cb) |> ignore
  )

testList "ChildProcess exec" [
  let withSetup f () =
    let p = exec "echo 'Print a message'"
    
    f(p)

  yield! testFixtureAsync withSetup [
    "should execute a process successfully", fun (p) ->
      promise {
        let! result = p
        result == Ok ("Print a message\n", "")
      }
  ]
]

testList "ChildProcess exec" [
    let withSetup f () =
      let p = exec "echo 'Print a message' 1>&2 && exit 1"
      f(p)

    yield! testFixtureAsync withSetup [
      "should handle errors", fun (p) ->
       
        promise {
          let! result = p
          match result with
            | Error ((e:ChildProcess.ExecError), stderr') -> 
                e.message == "Command failed: echo 'Print a message' 1>&2 && exit 1\nPrint a message\n"
                e.code == 1
                stderr' == "Print a message\n"
            | _ -> raise (System.Exception("Command didn't fail as it should have."))
        }
    ]
]