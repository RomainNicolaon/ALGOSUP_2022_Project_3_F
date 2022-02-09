namespace FSharpSynthe

open System

module CreateWave =

    let Pi = Math.PI

    type noteLetter  =
        | A
        | As

        | B
        | B2

        | C
        | Cs
        | C2
        | Cs2

        | D
        | Ds
        | Ds2

        | E
        | E2

        | F
        | Fs
        | Fs2

        | G
        | Gs
        | Gs2

    let Note note  = 
            match note with
            // AuClairDeLaLune notes
            // | A -> 587.
            // | B -> 659.
            // | C -> 426.63
            // | D -> 459.
            // | E -> 495.
            // | F -> 514.
            // | G -> 523.
            
            // Titanic notes
            | A -> 880. //LA
            | As -> 932. //LA#

            | B -> 493.//SI
            | B2 -> 987. //SI2

            | C -> 523. //DO
            | Cs -> 554. //DO#
            | C2 -> 1046. //DO2
            | Cs2 -> 1108. //DO2#

            | D -> 587. //RE
            | Ds -> 622. //RE#
            | Ds2 -> 1244. //RE2#

            | E -> 659. //MI
            | E2 -> 1318. //MI2

            | F -> 698. //FA
            | Fs -> 739. //FA#
            | Fs2 -> 1479. //FA2#

            | G -> 783. //SOL
            | Gs -> 830. //SOL#
            | Gs2 -> 1661. //SOL2#


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
            let points = points |> List.map(fun i -> amp * 2. * asin( sin( 2.* Pi * i * freq))/ Pi)
            points 

    // Periodic calculation for squrae wave
    let SquareWave time freq amp = //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let calc = 2. * Pi * freq
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * float(sign(sin(i*calc))))
            points 
