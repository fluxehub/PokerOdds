module App

open PokerOdds
open Feliz
open PokerOdds.Components.Card
open PokerOdds.Components.Hand
open Model
open Tailwind

[<ReactComponent>]
let App() =
    Html.div [
        prop.classes [ tw.``h-screen``; tw.``w-full``; tw.``bg-green-700``; tw.``p-08``; tw.``flex``; tw.``flex-col`` ]

        prop.children [
            Hand 1 [
                Card <| Some { Rank = Eight; Suit = Spades }
                Card <| Some { Rank = Jack; Suit = Diamonds }
            ]
            Hand 2 [
                Card <| None
            ]
        ]
    ]
