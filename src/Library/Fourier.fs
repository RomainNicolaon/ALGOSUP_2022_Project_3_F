namespace FSharpSynthe.Library

open CreateWave
open System.Numerics
 
module Fourier =

    let e = 2.71828
    let fourier time freq (wave:list<float>) =
        let t = 1. + (1./44100.) 
        let N = 44100. * time
        let points = [(0.)..t..N] 
        let points = points |> List.map(fun x -> wave[int(x)] * e**(-2.*Pi*sqrt(-1.)*freq*x))

        points
