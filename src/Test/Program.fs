namespace FSharpSynthe.Test

open System
open NUnit.Framework

[<TestFixture>]

type ProgramTest() =

    [<Test>]
    member x.DummyTest () =
        Assert.IsTrue(true)