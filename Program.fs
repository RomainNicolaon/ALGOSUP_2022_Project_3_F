open System.IO
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
let stream = File.Create(@"C:\AlgoSup\F#\SoundSynthetiser\test.wav")
write stream data
//let result = File.Open(@"C:\AlgoSup\F#\SoundSynthetiser\test.",FileMode.Open)
let result = File.ReadAllBytes(@"C:\AlgoSup\F#\SoundSynthetiser\test.wav")
printfn "%i" result.Length
let header = System.Text.Encoding.ASCII.GetString(result.[0 .. 3])
printfn "%s" header
