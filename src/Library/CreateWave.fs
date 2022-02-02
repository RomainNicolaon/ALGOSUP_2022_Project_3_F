namespace FSharpSynthe

open System

module CreateWave =

    let Pi = Math.PI

    type noteLetter  =
        | A
        | B
        | C
        | D
        | E
        | F
        | G
    let Note note  = 
                match note with
                | A -> 587.
                | B -> 659.
                | C -> 426.63
                | D -> 459.
                | E -> 495.
                | F -> 514.
                | G -> 523.


    // Periodic calculation for sine wave
    let sinusWave  time freq amp =

        let t = 1. + (1./44100.) 
        let N = 44100. * time 
        let calc = 2. * Pi * freq  
        let points = [(0.)..t..N] 
        let points = points |> List.map(fun x -> amp * sin(calc*x) ) 
        // List.map(fun x -> printfn "%O" x) points |> ignore // Print all value of the list
        points
    // Periodic calculation for sawtooth wave
    let SawtoothWave time freq amp = //Sinusoidale
        let t = 1.+(1./44100.)
        let N = 44100. * time
        let points = [(0.)..t..N]
        let points = points |> List.map(fun i -> amp * 2. * ( i * freq - floor(0.5 + i*freq)))
        points 

    // Periodic calculation for triangle wave
    let TriangleWave time freq amp = //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * 2. * asin( sin( 2.* Pi * t * freq))/ Pi)
            points 

    // Periodic calculation for squrae wave
    let SquareWave time freq amp = //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let calc = 2. * Pi * freq
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * float(sign(sin(i*calc))))
            points 
