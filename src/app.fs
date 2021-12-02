module App

(**
 The famous Increment/Decrement ported from Elm.
 You can find more info about Elmish architecture and samples at https://elmish.github.io/
*)

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props

// MODEL

type Model = int

type Msg =
| Increment
| Decrement
| Reset

let init() : Model = 0

// UPDATE

let update (msg:Msg) (model:Model) =
  failwith "todo"

// VIEW (rendered with React)

let view (model:Model) dispatch =
  div []
      [ button [ OnClick (fun _ -> dispatch Increment) ] [ str "+" ]
        div [] [ str (string model) ]
        button [ OnClick (fun _ -> dispatch Decrement) ] [ str "-" ] 
        button [ OnClick (fun _ -> dispatch Reset) ] [ str "Reset" ] ]

// App
Program.mkSimple init update view
|> Program.withReactSynchronous "todoapp"
|> Program.withConsoleTrace
|> Program.run