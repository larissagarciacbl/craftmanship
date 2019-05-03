// This file was auto-generated based on version 1.4.0 of the canonical data.

module BobTest

open FsUnit.Xunit
open Xunit

open Bob

[<Fact(Skip = "Remove to run test")>]
let ``Stating something`` () =
    response "Tom-ay-to, tom-aaaah-to." |> should equal "Whatever."

[<Fact(Skip = "Remove to run test")>]
let ``Shouting`` () =
    response "WATCH OUT!" |> should equal "Whoa, chill out!"

[<Fact(Skip = "Remove to run test")>]
let ``Shouting gibberish`` () =
    response "FCECDFCAAB" |> should equal "Whoa, chill out!"

[<Fact(Skip = "Remove to run test")>]
let ``Asking a question`` () =
    response "Does this cryogenic chamber make me look fat?" |> should equal "Sure."

[<Fact(Skip = "Remove to run test")>]
let ``Asking a numeric question`` () =
    response "You are, what, like 15?" |> should equal "Sure."

[<Fact(Skip = "Remove to run test")>]
let ``Asking gibberish`` () =
    response "fffbbcbeab?" |> should equal "Sure."

[<Fact(Skip = "Remove to run test")>]
let ``Talking forcefully`` () =
    response "Let's go make out behind the gym!" |> should equal "Whatever."


[<Fact(Skip = "Remove to run test")>]
let ``Forceful question`` () =
    response "WHAT THE HELL WERE YOU THINKING?" |> should equal "Calm down, I know what I'm doing!"



