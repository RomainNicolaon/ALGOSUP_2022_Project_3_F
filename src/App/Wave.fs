namespace FSharpSynthe.App


open System.IO
open System
open SFML.Audio
open System.Threading
open FSharpSynthe.Library.CreateWave
open FSharpSynthe.Library.CreateFile
open XPlot.GoogleCharts
open FSharpSynthe.Library.DisplayWave
open FSharpSynthe.Library.PlaySound
open FSharp.Collections


module main =


    // let streamTriangle = File.Create(@"Triangle.wav")
    // let streamSin = File.Create(@"Sinus.wav")
    // let streamSaw = File.Create(@"SawTooth.wav")
    // let streamSquare = File.Create(@"Square.wav")

    // write streamSaw sawToothByte
    // //write streamSin sinusByte
    // write streamTriangle triangleByte
    // write streamSquare squareByte

    // sawTooth |> Chart.Line |> Chart.Show
    // square |> Chart.Line |> Chart.Show
    // triangle|> Chart.Line |> Chart.Show
    // sinus |> Chart.Line |> Chart.Show
    

    let normalWave = sinusByte 0.1 523.3 0.6 
                        |> List.append(sinusByte 0.3 523. 0.6)
                        |> List.append(sinusByte 0.3 523. 0.6)
                        |> List.append(sinusByte 0. 523. 0.6)
                        |> List.append(sinusByte 0.3 523. 0.6)
                        |> List.append(sinusByte 0.3 587. 0.6)
                        |> List.append(sinusByte 0.3 659. 0.6)
                        |> List.append(sinusByte 0.3 523. 0.6)
                        |> List.append(sinusByte 0.6 659. 0.6)
                        |> List.append(sinusByte 0.4 587. 0.6)
                        |> List.append(sinusByte 0.3 523. 0.6)
                        |> List.append(sinusByte 0. 523. 0.6)
                        |> List.append(sinusByte 0.3 523. 0.6)
                        |> List.append(sinusByte 0. 523. 0.6)
                        |> List.append(sinusByte 0.3 523. 0.6)

  

    

       
    let normalWave2 = normalWave 
                     |> List.map sample 
                     |> Microsoft.FSharp.Collections.List.toArray

    let stream = File.Create(@"test.wav")   
    
    write stream normalWave2
    //PlaySound "test.wav"