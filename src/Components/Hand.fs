module PokerOdds.Components.Hand

open Feliz

open PokerOdds
open Tailwind

[<ReactComponent>]
let Hand (number: int) (cards: Fable.React.ReactElement seq) =
    Html.div [
        prop.children [
            Html.h1 [
                prop.classes [ tw.``mb-04``; tw.``text-3xl``; tw.``text-white``; tw.``font-black``; tw.``opacity-100`` ]

                prop.style [ style.fontFamily "sofia-pro" ]

                prop.text $"Hand {number}"
            ]

            Html.div [ 
                prop.classes [ tw.``flex`` ]

                prop.children cards
            ]
        ]
    ]