module CreateWave
open System

let sample x = (x + 1.)/2. * 255. |> byte
let Pi = Math.PI
let Amplitude = 1. // Measurement of its change in a single period
let Frequency = 40. // Hertz
let limit = 500


// Periodic calculation for sine wave
let sinus = Array.init limit (fun i -> Amplitude * sin((Frequency/ Pi) * float i)) //Sinusoidale


// Periodic calculation for sawtooth wave
let sawTooth = Array.init limit (fun i -> (2.*Amplitude/Pi)* Math.Atan(tan((2.*Pi*float i)/Frequency))  )


// Periodic calculation for triangle wave
let triangle = Array.init limit (fun i ->  (2.*Amplitude/Pi)* Math.Asin(sin((2.*Pi*float i)/Frequency))  )


// Periodic calculation for squrae wave
let square = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(Frequency/float limit)))))