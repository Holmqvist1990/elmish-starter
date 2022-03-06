module Update

open Elmish
open Model

let update (msg : Msg) (state : State) = state, Cmd.ofMsg msg
