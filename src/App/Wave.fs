namespace FSharpSynthe.App


open System.IO
open System.Threading
open FSharpSynthe.CreateWave
open FSharpSynthe.CreateFile
open XPlot.GoogleCharts

open FSharpSynthe.PlaySound
open FSharpSynthe.Filter
open FSharp.Collections
open FSharpSynthe.Envelop

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

                        
   (*  let AuClairDeLaLune2 = 
                     AuClairDeLaLune 
                     |> List.map sample 
                     |> Microsoft.FSharp.Collections.List.toArray

    let stream = File.Create(@"../Examples/Lune-Song.wav") 
    write stream AuClairDeLaLune2

    let longueur = List.length(AuClairDeLaLune)
    printfn "%A " longueur
    
    let lowpasstest = lowPass 44100 400 AuClairDeLaLune
    let lowpasstest2 = 
                     lowpasstest 
                     |> List.map sample 
                     |> Microsoft.FSharp.Collections.List.toArray
    let stream2 = File.Create(@"../Examples/Lune-Song-lowpass.wav") 
    write stream2 lowpasstest2
 *)
    let test = reverb (sinusWave 1. 523. 1.) |> mixnote
    

    write "../Examples/reverb" test