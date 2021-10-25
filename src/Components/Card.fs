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
    | Spades | Clubs -> "#000000"
    | Hearts | Diamonds -> "#e83c3c"

let suitToSvg suit =
    match suit with
    | Spades -> spades
    | Hearts -> hearts
    | Diamonds -> diamonds
    | Clubs -> clubs

[<ReactComponent>]
let card card =
    Html.div [
        prop.style [
            style.height 134
            style.width 95
        ]

        prop.classes [
            tw.``bg-white``
            tw.``rounded-lg``
            tw.``shadow-lg``
            tw.``flex``
            tw.``p-01``
            tw.``mr-04``
        ]

        prop.children [
            Html.p [
                prop.classes [
                    tw.``absolute``
                    tw.``ml-02``
                    tw.``font-black``
                    tw.``text-4xl``
                ]

                prop.style [
                    style.fontFamily "sofia-pro"
                    style.color <| suitToColor card.Suit
                ]

                prop.text (rankToAbbreviation card.Rank)
            ]

            Html.img [
                prop.src (suitToSvg card.Suit)

                prop.classes [
                    tw.``align-middle``
                    tw.``mx-auto``
                    tw.``w-10``
                ]
            ]
        ]
    ]
