(*Amplitude between 0 & 255
*)
open System
let Amplitude = 1. // Measurement of its change in a single period
let Time = 1. // Duration of a note
let Frequency = 987.8  // Hertz
let interval = 1e-4 // Is wavelength
let nmbrOfPts = 40. // Number of points representing the curve

let coordonates = [0.;0.]
let sinCoords = [0.;0.]
let triangleCoords = [0.;0.]
let sawToothCoords = [0.;0.]
let squareCoords =[0.,0.]
let xCoord = 0.

// Calculation for the placement of the ordinates on the curve
let yCoord =  Amplitude *  (Math.PI * xCoord)

// Periodic calculation for sine wave
let sine = Amplitude * sin ((2.*Math.PI*Time - Frequency)/interval)

// Calculation for the placement of the abscissa on the curve from 0 to Time
[|for i in 0. .. Time do
    xCoord = (i * (2.*interval)) /nmbrOfPts
|]

// Show results
sprintf"%O" xCoord
sprintf"%O" yCoord
sprintf"%O" sine

// Periodic calculation for triangle wave
let  triangle = ((2.* Amplitude)/Math.PI)* sin(-1.) * sin ((2.* Math.PI * Time - Frequency)/interval)

// Show result
sprintf"%O" triangle

// Periodic calculation for sawtooth wave
let sawtooth = ((2. * Amplitude)/Math.PI) * tan(-1.) * tan ((2.* Math.PI * Time - Frequency)/2.*interval)

// Show result
sprintf"%O" sawtooth


/// Write WAVE PCM soundfile (8KHz Mono 8-bit)
(*let write stream (data:byte[]) =
    use writer = new BinaryWriter(stream)
    // RIFF
    writer.Write("RIFF"B)
    let size = 36 + data.Length in writer.Write(size)
    writer.Write("WAVE"B)
    // fmt
    writer.Write("fmt "B)
    let headerSize = 16 in writer.Write(headerSize)
    let pcmFormat = 1s in writer.Write(pcmFormat)
    let mono = 1s in writer.Write(mono)
    let sampleRate = 8000 in writer.Write(sampleRate)
    let byteRate = sampleRate in writer.Write(byteRate)
    let blockAlign = 1s in writer.Write(blockAlign)
    let bitsPerSample = 8s in writer.Write(bitsPerSample)
    // data
    writer.Write("data"B)
    writer.Write(data.Length)
    writer.Write(data)

let sample x = (x + 1.)/2. * 255. |> byte 

let datasin = Array.init 16000 (fun i -> sin (float i/float 8) |> sample)
let stream = File.Create(@"C:\tone.wav")
if (datasin.Length>0) then write stream datasin*)