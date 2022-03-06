module App

open Elmish
open Elmish.React

open Model
open Update
open Render

let init () : (State * Cmd<Msg>) =
  let initialState = ()
  let initialCmd = Cmd.none
  initialState, initialCmd

Program.mkProgram init update render
|> Program.withReactSynchronous "elmish-app"
|> Program.run
