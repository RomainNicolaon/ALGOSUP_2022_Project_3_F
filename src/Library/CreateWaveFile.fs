namespace FSharpSynthe

open System.IO

module CreateFile =

   let write (filename: string) (data:byte[]) = 
      let stream = File.Create(filename+".wav") 
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
      let sampleRate = 44100 in writer.Write(sampleRate)
      let byteRate = sampleRate in writer.Write(byteRate)
      let blockAlign = 1s in writer.Write(blockAlign)
      let bitsPerSample = 8s in writer.Write(bitsPerSample)
      // data
      writer.Write("data"B)
      writer.Write(data.Length)
      writer.Write(data)
   let sample x = (x + 1.)/2. * 255. |> byte
   let mixsong listofnote = 
                     listofnote
                     |> List.rev
                     |> List.map sample 
                     |> Microsoft.FSharp.Collections.List.toArray
   let mixnote note =
                   note
                   |> List.map sample 
                   |> Microsoft.FSharp.Collections.List.toArray
      
   let writemp3 (filename: string) (data:byte[]) = 
      let stream = File.Create(filename+".mp3") 
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
      let sampleRate = 44100 in writer.Write(sampleRate)
      let byteRate = sampleRate in writer.Write(byteRate)
      let blockAlign = 1s in writer.Write(blockAlign)
      let bitsPerSample = 8s in writer.Write(bitsPerSample)
      // data
      writer.Write("data"B)
      writer.Write(data.Length)
      writer.Write(data)