module CreateWave
open System

let Pi = Math.PI
let Amplitude = 1.
let Frequency = 40.
let limit = 500

let sinus = Array.init limit (fun i -> Amplitude * sin((Frequency/ Pi) * float i)) //Sinusoidale


//let sawTooth = Array.init limit (fun i -> (Amplitude * (((2. * float i/ Frequency))  2.) - Amplitude))


let triangle = Array.init limit (fun i ->  (2.*Amplitude/Pi)* Math.Asin(sin((2.*Pi*float i)/Frequency))  )


let square = Array.init limit (fun i -> float(Math.Sign(sin(2. * Math.PI * float i*(Frequency/float limit)))))