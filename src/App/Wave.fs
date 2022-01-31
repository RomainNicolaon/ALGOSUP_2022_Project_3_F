namespace FSharpSynthe.App


open System.IO
open System.Threading
open FSharpSynthe.Library.CreateWave
open FSharpSynthe.Library.CreateFile
open XPlot.GoogleCharts

open FSharpSynthe.Library.PlaySound
open FSharpSynthe.Library.Filter
open FSharp.Collections
open FSharpSynthe.Library.Envelop

module main = 
    // Play "Au Clair de la Lune"
    let AuClairDeLaLune = sinusWave 0.3 (Note G) 1 // G
                        |> List.append(sinusWave 0.05 0 1) // Pose 0.1
                        |> List.append(sinusWave 0.3 (Note G) 1) // G
                        |> List.append(sinusWave 0.1 0 1) // Pose 0.2
                        |> List.append(sinusWave 0.3 (Note G) 1)// G
                        |> List.append(sinusWave 0.05 0 1) // Pose 0.1
                        |> List.append(sinusWave 0.3 (Note A) 0.6) // A
                        |> List.append(sinusWave 0.05 0 1)// Pose 0.1
                        |> List.append(sinusWave 0.3 (Note B) 0.6) // B
                        |> List.append(sinusWave 0.15 0 1)// Pose 0.1
                        |> List.append(sinusWave 0.3 (Note A) 0.6) //A
                        |> List.append(sinusWave 0.1 0 1)// Pose 0.2
                        |> List.append(sinusWave 0.3 (Note G) 0.6) //G
                        |> List.append(sinusWave 0.05 0 1)// Pose 0.1
                        |> List.append(sinusWave 0.3 (Note B) 0.6) //B
                        |> List.append(sinusWave 0.05 0 1)// Pose 0.1
                        |> List.append(sinusWave 0.3 (Note A) 0.6) //A
                        |> List.append(sinusWave 0.05 0 1)// Pose 0.1
                        |> List.append(sinusWave 0.3 (Note A) 0.6) //A
                        |> List.append(sinusWave 0.1 0 1)// Pose 0.2
                        |> List.append(sinusWave 0.3 (Note G) 0.6) //G
                        |> List.rev

                        
    let AuClairDeLaLune2 = 
                     AuClairDeLaLune 
                     |> List.map sample 
                     |> Microsoft.FSharp.Collections.List.toArray

    let stream = File.Create(@"../Examples/Lune-Song.wav") 
    write stream AuClairDeLaLune2

    let longueur = List.length(AuClairDeLaLune)
    printfn "%A " longueur