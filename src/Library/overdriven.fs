namespace FSharpSynthe.Library

open System
open FSharpSynthe.Library

module OverdrivenFilter =

    // Periodic calculation for sine wave
    // let sinus frequency = List.init limit (fun i -> Amplitude * sin((frequency/ Pi) * float i))
    

    let AmplitudeBase = 0. // Measurement of its change in a single period
    let limit = 10000
    let incrementation = float(1/limit)
    let Amplitude = Array.init limit (fun i -> AmplitudeBase + incrementation)
    let overdriven = 0.8

    let Overdriven () =
        [for i  in Amplitude do
            if i <= -overdriven then
                yield -overdriven
            if i <= overdriven then
                yield overdriven
            else
                yield i]