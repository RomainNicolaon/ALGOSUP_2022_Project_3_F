namespace FSharpSynthe.Library

open System

module CreateWave =


    // Periodic calculation for sine wave
// let sinus frequency = List.init limit (fun i -> Amplitude * sin((frequency/ Pi) * float i))
    let sinusByte time freq amp = //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let omega = 2. * Math.PI * freq
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * sin(omega*i))
            points

    let sample x = (x + 1.)/2. * 255. |> byte
    let Pi = Math.PI
    let Amplitude = 1. // Measurement of its change in a single period
    let Frequency = 80. // Hertz
    let limit = 10000
    
    type Note  =
        | A
        | B
        | C
        | D
        | E
        | F
        | G
    let NoteLetter note  = 
                match note with
                | A -> 440.
                | B -> 493.88
                | C -> 261.63
                | D -> 293.66
                | E -> 329.63
                | F -> 349.23
                | G -> 392.



    // Periodic calculation for sine wave
    //let sinus = Array.init limit (fun i -> Amplitude * sin((Frequency/ Pi) * float i))
    //let sinusByte = Array.init limit (fun i -> Amplitude * sin((Frequency/ Pi) * float i) |> sample)//Sinusoidale



    // Periodic calculation for sawtooth wave
    let sawTooth = Array.init limit (fun i -> (2.*Amplitude/Pi)* Math.Atan(tan((2.*Pi*float i)/Frequency)))
    let sawToothByte = Array.init limit (fun i -> (2.*Amplitude/Pi)* Math.Atan(tan((2.*Pi*float i)/Frequency)) |> sample )


    // Periodic calculation for triangle wave
    let triangle = Array.init limit (fun i ->  (2.*Amplitude/Pi)* Math.Asin(sin((2.*Pi*float i)/Frequency)) )
    let triangleByte = Array.init limit (fun i ->  (2.*Amplitude/Pi)* Math.Asin(sin((2.*Pi*float i)/Frequency)) |> sample )


    // Periodic calculation for squrae wave
    let square = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(Frequency/float limit)))))
    let squareByte = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(Frequency/float limit))))|> sample)

