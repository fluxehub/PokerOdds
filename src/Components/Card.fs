module PokerOdds.Components.Card

open Feliz
open Fable.Core.JsInterop

open PokerOdds
open Model
open Tailwind

let spades: string = import "*" "../../content/assets/spades.svg"
let hearts: string = import "*" "../../content/assets/hearts.svg"
let diamonds: string = import "*" "../../content/assets/diamonds.svg"
let clubs: string = import "*" "../../content/assets/clubs.svg"

let rankToAbbreviation rank =
    match rank with
    | Two   -> "2"
    | Three -> "3"
    | Four  -> "4"
    | Five  -> "5"
    | Six   -> "6"
    | Seven -> "7"
    | Eight -> "8"
    | Nine  -> "9"
    | Ten   -> "10"
    | Jack  -> "J"
    | Queen -> "Q"
    | King  -> "K"
    | Ace   -> "A"

let suitToColor suit =
    match suit with
    | Spades | Clubs -> [ tw.``text-black``; tw.``opacity-80`` ]
    | Hearts | Diamonds -> [ tw.``text-red-500`` ]

let suitToSvg suit =
    match suit with
    | Spades -> spades
    | Hearts -> hearts
    | Diamonds -> diamonds
    | Clubs -> clubs

let CardOutline =
    Html.div [
        prop.style [ style.height 134; style.width 95 ]

        prop.classes [ tw.``rounded-lg``; tw.``border-4``; tw.``opacity-30``; tw.``border-dashed``; tw.``flex``; tw.``p-01``; tw.``mr-04``; tw.``mb-08``; tw.``items-center``; tw.``justify-center`` ]

        prop.children [
            Html.h1 [
                prop.classes [ tw.``text-6xl``; tw.``font-black``; tw.``select-none`` ]

                prop.style [ style.fontFamily "Manrope" ]

                prop.text "+"
            ]
        ]
    ]

let CardFilled card =
    Html.div [
        prop.style [ style.height 134; style.width 95 ]

        prop.classes [ tw.``bg-white``; tw.``rounded-lg``; tw.``flex``; tw.``mr-04``; tw.``mb-08``; tw.``select-none`` ]

        prop.children [
            Html.img [
                prop.src (suitToSvg card.Suit)

                // prop.style [ style.width 22 ]
                // ?
                prop.classes [ tw.``absolute``; tw.``m-03``; tw.``w-06`` ]
            ]

            Html.h1 [
                prop.classes ([ tw.``m-auto``; tw.``font-black``; tw.``text-6xl``; ] @ suitToColor card.Suit)

                prop.style [ style.fontFamily "Manrope" ]

                prop.text (rankToAbbreviation card.Rank)
            ]
        ]
    ]

[<ReactComponent>]
let Card card =
    match card with
    | Some card -> CardFilled card
    | None      -> CardOutline
