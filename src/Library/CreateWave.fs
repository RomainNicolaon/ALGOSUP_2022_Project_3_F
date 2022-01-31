namespace FSharpSynthe

open System

module CreateWave =

    let Pi = Math.PI
    let sample x = (x + 1.)/2. * 255. |> byte
    let AmplitudeBase = 1. // Measurement of its change in a single period
    let Frequency = 80. // Hertz
    let time = 1000 // listening time

    let sinusByte time freq amp = //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let omega = 2. * Pi * freq
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * sin(omega*i))
            points

    

    
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
                | A -> 440.
                | B -> 493.88
                | C -> 261.63
                | D -> 293.66
                | E -> 329.63
                | F -> 349.23
                | G -> 392.