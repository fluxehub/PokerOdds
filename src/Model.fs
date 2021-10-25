module PokerOdds.Model

type Suit = Spades | Hearts | Diamonds | Clubs
type Rank = 
    |  Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten 
    | Jack | Queen | King | Ace

type Card = { Suit: Suit; Rank: Rank }