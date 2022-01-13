<<<<<<< Updated upstream
namespace FSharpSynthe.Library

open System.IO

module CreateFile =

   let write stream (data:byte[]) =
      use writer = new BinaryWriter(stream)
      // RIFF
      writer.Write("RIFF"B)
      let size = 36 + data.Length in writer.Write(size)
      writer.Write("WAVE"B)
      // fmt
=======
namespace Library
open System.IO


module createFile  = 
   let write stream (data:byte[]) =
      use writer = new BinaryWriter(stream)
   // RIFF
      writer.Write("RIFF"B)
      let size = 36 + data.Length in writer.Write(size)
      writer.Write("WAVE"B)
   // fmt
>>>>>>> Stashed changes
      writer.Write("fmt "B)
      let headerSize = 16 in writer.Write(headerSize)
      let pcmFormat = 1s in writer.Write(pcmFormat)
      let mono = 1s in writer.Write(mono)
      let sampleRate = 44100 in writer.Write(sampleRate)
      let byteRate = sampleRate in writer.Write(byteRate)
      let blockAlign = 1s in writer.Write(blockAlign)
      let bitsPerSample = 16s in writer.Write(bitsPerSample)
<<<<<<< Updated upstream
      // data
      writer.Write("data"B)
      writer.Write(data.Length)
      writer.Write(data)
=======
   // data
      writer.Write("data"B)
      writer.Write(data.Length)
      writer.Write(data)
   let sample x = (x + 1.)/2. * 255. |> byte
   let Song SongFloat = SongFloat 
                  |> List.map sample 
                  |> Microsoft.FSharp.Collections.List.toArray
   let stream = File.Create(@"test.wav")
   write stream Song
>>>>>>> Stashed changes
