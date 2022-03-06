module Render

open Feliz
open Model

let render (state : State) (dispatch : Msg -> unit) = Html.div []
