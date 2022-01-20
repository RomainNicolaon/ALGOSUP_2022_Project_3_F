namespace FSharpSynthe.Library

open System

module OverdrivenFilter =    

    let Pi = Math.PI
    let AmplitudeBase = 1. // Measurement of its change in a single period
    let Frequency = 80. // Hertz
    let time = 1000 // listening time

    let sinus = Array.init time (fun i -> AmplitudeBase * sin((Frequency/ Pi) * float i))

    let Overdriven (overdrive:float) (Waves: float array) time =
        for i in 0.. time do
            if Waves.[i] < -overdrive then
                Waves.[i] <- -overdrive
            elif Waves.[i] > overdrive then
                Waves.[i]  <- overdrive
        
        sinus

    let sinWave = Overdriven 0.7 sinus (time - 1)