module PokerOdds.Components.Card

open PokerOdds
open Feliz
open Tailwind
open Fable.Core.JsInterop

let spades: string = import "*" "../../content/assets/spades.svg"

[<ReactComponent>]
let card () =
    Html.div [
        prop.style [
            style.height 134
            style.width 86
        ]

        prop.classes [
            tw.``bg-white``
            tw.``rounded-lg``
            tw.``shadow-lg``
            tw.flex
            tw.``p-02``
            tw.``mr-04``
        ]

        prop.children [
            Html.p [
                prop.classes [
                    tw.absolute
                    tw.``ml-01``
                    tw.``font-black``
                    tw.``text-2xl``
                ]

                prop.style [
                    style.fontFamily "Sofia Pro"
                ]

                prop.text "3"
            ]

            Html.img [
                prop.src spades

                prop.classes [
                    tw.``align-middle``
                    tw.``mx-auto``
                    tw.``w-10``
                ]
            ]
        ]
    ]
