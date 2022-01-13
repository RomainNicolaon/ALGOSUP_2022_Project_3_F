namespace FSharpSynthe.App

open System.IO
open System
open SFML.Audio
open System.Threading
open FSharpSynthe.Library.CreateWave
open FSharpSynthe.Library.CreateFile
open XPlot.GoogleCharts

module main =

    let streamTriangle = File.Create(@"Triangle.wav")
    let streamSin = File.Create(@"Sinus.wav")
    let streamSaw = File.Create(@"SawTooth.wav")
    let streamSquare = File.Create(@"Square.wav")

    write streamSaw sawToothByte
    write streamSin sinusByte
    write streamTriangle triangleByte
    write streamSquare squareByte

    sawTooth |> Chart.Line |> Chart.Show
    square |> Chart.Line |> Chart.Show
    triangle|> Chart.Line |> Chart.Show
    sinus |> Chart.Line |> Chart.Show



