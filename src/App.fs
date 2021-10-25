module App

open PokerOdds
open Feliz
open PokerOdds.Components.Card
open Tailwind

[<ReactComponent>]
let App() =
    Html.div [
        prop.classes [
            tw.``h-screen``
            tw.``w-full``
            tw.``bg-green-700``
            tw.``p-08``
            tw.flex
        ]

        prop.children [
            card ()
            card ()
        ]
    ]
