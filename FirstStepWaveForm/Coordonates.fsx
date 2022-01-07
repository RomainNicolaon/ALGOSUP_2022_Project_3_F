(*Amplitude between 0 & 255
*)
open System
let Amplitude = 1.
let Time = 1.
let Frequency = 987.8  //Hertz
let interval = 1e-4
let nmbrOfPts = 40.

let coordonates = [0.;0.]
let sinCoords = [0.;0.]
let triangleCoords = [0.;0.]
let sawToothCoords = [0.;0.]
let squareCoords =[0.,0.]
let xCoord = 0.

let yCoord =  Amplitude *  (Math.PI * xCoord)
let sin = Amplitude * Math.Sin ((2.*Math.PI*Time - Frequency)/interval)

[|for i in 0. .. Time do
    xCoord = (i * (2.*interval)) /nmbrOfPts
|]

sprintf"%O" xCoord
sprintf"%O" yCoord
sprintf"%O" sin


let  triangle = ((2.* Amplitude)/Math.PI)* Math.Sin(-1) * Math.Sin ((2.* Math.PI * Time - Frequency)/interval)

sprintf"%O" triangle


let sawtooth = ((2. * Amplitude)/Math.PI) * Math.Tan(-1) * Math.Tan ((2.* Math.PI * Time - Frequency)/2.*interval)

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