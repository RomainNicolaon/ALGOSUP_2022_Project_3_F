namespace FSharpSynthe.Library

open System
open CreateWave

module AM =
   let sinusAM  time freq amp ampLFO freqLFO=

        let t = 1. + (1./44100.) 
        let N = 44100. * time 
        let calc = 2. * Pi * freq
        let calcLFO = 2. * Pi * freqLFO
        let points = [(0.)..t..N] 
        let points = points |> List.map(fun x -> amp * sin(calc+ampLFO*sin(calcLFO*x)*x ) )
        // List.map(fun x -> printfn "%O" x) points |> ignore // Print all value of the list
        points