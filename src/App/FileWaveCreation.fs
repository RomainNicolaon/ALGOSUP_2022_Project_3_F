
open System.IO
open System
open System.Threading
open System.Buffers
open SFML.Audio
/// Write WAVE PCM soundfile (8KHz Mono 8-bit)
let write stream (data:byte[]) =
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
   let sampleRate = 44000 in writer.Write(sampleRate)
   let byteRate = sampleRate in writer.Write(byteRate)
   let blockAlign = 1s in writer.Write(blockAlign)
   let bitsPerSample = 16s in writer.Write(bitsPerSample)
   // data
   writer.Write("data"B)
   writer.Write(data.Length)
   writer.Write(data)

let sample x = (x + 1.)/2. * 255. |> byte 

let data = Array.init 45000 (fun i -> sin (float i/float 16) |> sample)
let stream = File.Create(@"C:\Users\RobinDEBRY\Desktop\dd\SoundDigital\test.wav")
write stream data

let PlaySound = 
    let buffer = new SoundBuffer("test.wav")
    let sound  = new Sound(buffer)
    sound.Play()

    while sound.Status = SoundStatus.Playing do 
        let result = Console.CursorLeft = 0
        Thread.Sleep(100)

PlaySound