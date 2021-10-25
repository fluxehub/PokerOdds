module PokerOdds.Tailwind

open Zanaptak.TypedCssClasses

// Configure type provider to use generated Tailwind classes.
// Naming.Verbatim is required for PurgeCSS bundle reduction, see https://tailwindcss.com/docs/optimizing-for-production
type tw =
    CssClasses<
        "content/tailwind-source.css"
        , Naming.Verbatim
        , commandFile = "node"
        , argumentPrefix = "tailwind-process.js tailwind.config.js"
        //, logFile = "TypedCssClasses.log" // uncomment to enable logging
    >
