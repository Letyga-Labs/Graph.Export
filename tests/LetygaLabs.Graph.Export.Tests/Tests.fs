namespace LetygaLabs.Graph.Export.Tests

open Expecto

module SayTests =
    [<Tests>]
    let tests =
        testList "samples" [
            testCase "Add two integers"
            <| fun _ ->
                let subject = 1 + 2
                Expect.equal subject 3 "Addition works"
        ]
