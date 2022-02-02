﻿namespace FSharpSynthe.App


open System.IO
open System.Threading
open FSharpSynthe.Library.CreateWave
open FSharpSynthe.Library.CreateFile
open XPlot.GoogleCharts
open FSharpSynthe.Library.DisplayWave
open FSharpSynthe.Library.PlaySound
open FSharpSynthe.Library.Filter
open FSharp.Collections
open FSharpSynthe.Library.Envelop

module main = 
    
    // Play "Au Clair de la Lune"
    // let AuClairDeLaLune = sinusWave 0.3 (Note G) 1 // G
    //                     |> List.append(sinusWave 0.05 0 1) // Pose 0.1
    //                     |> List.append(sinusWave 0.3 (Note G) 1) // G
    //                     |> List.append(sinusWave 0.1 0 1) // Pose 0.2
    //                     |> List.append(sinusByte 0.3 (Note G) 1)// G
    //                     |> List.append(sinusWave 0.05 0 1) // Pose 0.1
    //                     |> List.append(sinusByte 0.3 (Note A) 0.6) // A
    //                     |> List.append(sinusWave 0.05 0 1)// Pose 0.1
    //                     |> List.append(sinusByte 0.3 (Note B) 0.6) // B
    //                     |> List.append(sinusWave 0.15 0 1)// Pose 0.1
    //                     |> List.append(sinusByte 0.3 (Note A) 0.6) //A
    //                     |> List.append(sinusWave 0.1 0 1)// Pose 0.2
    //                     |> List.append(sinusByte 0.3 (Note G) 0.6) //G
    //                     |> List.append(sinusWave 0.05 0 1)// Pose 0.1
    //                     |> List.append(sinusByte 0.3 (Note B) 0.6) //B
    //                     |> List.append(sinusWave 0.05 0 1)// Pose 0.1
    //                     |> List.append(sinusByte 0.3 (Note A) 0.6) //A
    //                     |> List.append(sinusWave 0.05 0 1)// Pose 0.1
    //                     |> List.append(sinusByte 0.3 (Note A) 0.6) //A
    //                     |> List.append(sinusWave 0.1 0 1)// Pose 0.2
    //                     |> List.append(sinusByte 0.3 (Note G) 0.6) //G
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 523. 0.6) //G
    //                     // |> List.append(sinusWave 0.2 0 1)// Pose 0.2
    //                     // |> List.append(sinusByte 0.3 523. 0.6) //G
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 523. 0.6) //G
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 587. 0.6) //A
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 659. 0.6) //B
    //                     // |> List.append(sinusWave 0.2 0 1)// Pose 0.2
    //                     // |> List.append(sinusByte 0.3 587. 0.6) //A
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 523. 0.6) //G
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 659. 0.6) // B
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 587. 0.6) //A
    //                     // |> List.append(sinusWave 0.2 0 1)// Pose 0.2
    //                     // |> List.append(sinusByte 0.3 587. 0.6) //A
    //                     // |> List.append(sinusWave 0.1 0 1)// Pose 0.1
    //                     // |> List.append(sinusByte 0.3 523. 0.6) //G
    //                     |> List.rev
   
   
               

     
    // let echo1 = createEcho  1.5 AuClairDeLaLune 0.3  
        
    // let AuClairDeLaLune2 = 
    //                  AuClairDeLaLune 
    //                  |> List.map sample 
    //                  |> Microsoft.FSharp.Collections.List.toArray

    // let stream = File.Create(@"../Examples/test.wav") 
    // write stream AuClairDeLaLune2

    // //PlaySound "test.wav"  
    // let test = enveloppe AuClairDeLaLune 44100. 0.5 0.1 0. 0.3 0.5

    // let test2 = 
    //                  test
    //                  |> List.map sample 
    //                  |> Microsoft.FSharp.Collections.List.toArray
    // let stream2 = File.Create(@"../Examples/Enveloptest.wav")  
    // write stream2 test2

    // let longueur = List.length(AuClairDeLaLune)
    // printfn "%A " longueur


    // time frequency amplitude
    let Titanic = sinusWave 0.4 (Note E) 1
                            |> List.append(sinusWave 0.03 0 1)
                            |> List.append(sinusWave 0.4 (Note Fs) 1)
                            |> List.append(sinusWave 0.07 0 1)
                            |> List.append(sinusWave 0.9 (Note Gs ) 1)
                            |> List.append(sinusWave 0.07 0 1)
                            |> List.append(sinusWave 0.2 (Note Fs) 1)
                            |> List.append(sinusWave 0.08 0 1)
                            |> List.append(sinusWave 0.2 (Note Fs) 1)
                            |> List.append(sinusWave 0.09 0 1)
                            |> List.append(sinusWave 0.3 (Note E) 1)
                            |> List.append(sinusWave 0.07 0 1)
                            |> List.append(sinusWave 0.35 (Note Fs) 1)
                            |> List.append(sinusWave 0.05 0 1)

                            |> List.append(sinusWave 0.4 (Note B2) 1)
                            |> List.append(sinusWave 0.3 0 1)
                            |> List.append(sinusWave 0.14 (Note B2) 1)
                            |> List.append(sinusWave 0.02 0 1)
                            |> List.append(sinusWave 0.25 (Note A) 1)
                            |> List.append(sinusWave 0.04 0 1)
                            |> List.append(sinusWave 0.25 (Note Gs) 1)
                            |> List.append(sinusWave 0.04 0 1)
                            |> List.append(sinusWave 0.4 (Note E) 1)
                            |> List.append(sinusWave 0.04 0 1)
                            |> List.append(sinusWave 0.5 (Note Cs) 1)
                            |> List.append(sinusWave 0.3 0 1)
                            |> List.append(sinusWave 0.4 (Note Cs) 1)
                            |> List.append(sinusWave 0.05 0 1)

                            |> List.append(sinusWave 0.8 (Note B) 1)
                            |> List.append(sinusWave 0.02 0 1)
                            |> List.append(sinusWave 0.65 (Note E) 1)
                            |> List.append(sinusWave 0.02 0 1)
                            |> List.append(sinusWave 0.7 (Note Fs ) 1)
                            |> List.append(sinusWave 0.02 0 1)
                            |> List.append(sinusWave 0.9 (Note Gs) 1)
                            |> List.append(sinusWave 0.25 0 1)
                            |> List.append(sinusWave 0.13 (Note A) 1)
                            |> List.append(sinusWave 0.02 0 1)
                            |> List.append(sinusWave 0.13 (Note Gs) 1)
                            |> List.append(sinusWave 0.04 0 1)
                            |> List.append(sinusWave 0.13 (Note Fs) 1)
                            |> List.append(sinusWave 0.05 0 1)

                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.07 0 1)
                            // |> List.append(sinusWave 0.4 (Note Fs) 1)
                            // |> List.append(sinusWave 0.08 0 1)
                            // |> List.append(sinusWave 0.5 (Note B2) 1)
                            // |> List.append(sinusWave 0.5 0 1)
                            // |> List.append(sinusWave 0.2 (Note Gs) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.25 (Note B2) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.65 (Note Cs2) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.28 (Note B2) 1)
                            // |> List.append(sinusWave 0.5 0 1)

                            // |> List.append(sinusWave 0.2 (Note Fs) 1)
                            // |> List.append(sinusWave 0.01 0 1)
                            // |> List.append(sinusWave 0.2 (Note Gs) 1)
                            // |> List.append(sinusWave 0.01 0 1)
                            // |> List.append(sinusWave 1. (Note Fs ) 1)
                            // |> List.append(sinusWave 0.8 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.4 0 1)
                            // |> List.append(sinusWave 0.1 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.13 0 1)
                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            
                            // |> List.append(sinusWave 0.5 (Note Ds) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.6 0 1)
                            // |> List.append(sinusWave 0.5 (Note E ) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note Ds) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.6 (Note E) 1)
                            // |> List.append(sinusWave 0.13 0 1)
                            // |> List.append(sinusWave 0.7 (Note Fs) 1)
                            // |> List.append(sinusWave 0.08 0 1)
                            // |> List.append(sinusWave 0.5 (Note Gs) 1)
                            // |> List.append(sinusWave 0.2 0 1)

                            // |> List.append(sinusWave 0.15 (Note A) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.2 (Note Gs) 1)
                            // |> List.append(sinusWave 0.08 0 1)
                            // |> List.append(sinusWave 0.8 (Note Fs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.4 0 1)
                            // |> List.append(sinusWave 0.1 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.13 0 1)
                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.03 0 1)

                            // |> List.append(sinusWave 0.5 (Note Ds) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.6 0 1)
                            // |> List.append(sinusWave 0.5 (Note E ) 1)
                            // |> List.append(sinusWave 0.01 0 1)
                            // |> List.append(sinusWave 1.6 (Note B) 1)
                            // |> List.append(sinusWave 2.5 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.4 0 1)
                            // |> List.append(sinusWave 0.1 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.13 0 1)

                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note Ds) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.7 0 1)
                            // |> List.append(sinusWave 0.5 (Note E ) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note Ds) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.6 (Note E) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.3 (Note Fs) 1)
                            // |> List.append(sinusWave 0.08 0 1)

                            // |> List.append(sinusWave 0.5 (Note Gs) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.13 (Note A) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.13 (Note Gs) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.6 (Note Fs) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.4 0 1)
                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.13 0 1)

                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note Ds) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.7 0 1)
                            // |> List.append(sinusWave 0.5 (Note E ) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 1.2 (Note B) 1)
                            // |> List.append(sinusWave 3. 0 1)
                            // |> List.append(sinusWave 1.8 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 1.3 (Note Fs) 1)
                            // |> List.append(sinusWave 0.08 0 1)

                            // |> List.append(sinusWave 0.4 (Note B) 1)
                            // |> List.append(sinusWave 0.02 0 1)
                            // |> List.append(sinusWave 0.6 (Note B2) 1)
                            // |> List.append(sinusWave 0.15 0 1)
                            // |> List.append(sinusWave 0.65 (Note A) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.4 (Note Gs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.8 (Note Fs) 1)
                            // |> List.append(sinusWave 0.2 0 1)
                            // |> List.append(sinusWave 0.6 (Note Gs) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.5 (Note A) 1)
                            // |> List.append(sinusWave 0.06 0 1)

                            // |> List.append(sinusWave 0.9 (Note Gs) 1)
                            // |> List.append(sinusWave 0.15 0 1)
                            // |> List.append(sinusWave 0.7 (Note Fs) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.75 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.3 (Note Ds) 1)
                            // |> List.append(sinusWave 0.15 0 1)
                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.3 (Note Ds) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 1. (Note Cs) 1)
                            // |> List.append(sinusWave 0.07 0 1)

                            // |> List.append(sinusWave 0.1 (Note Ds) 1)
                            // |> List.append(sinusWave 0.08 0 1)
                            // |> List.append(sinusWave 0.1 (Note Cs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 1. (Note B) 1)
                            // |> List.append(sinusWave 0.9 0 1)
                            // |> List.append(sinusWave 1.3 (Note E) 1)
                            // |> List.append(sinusWave 0.9 0 1)
                            // |> List.append(sinusWave 1.3 (Note Fs) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.4 (Note B) 1)
                            // |> List.append(sinusWave 0.03 0 1)
                            // |> List.append(sinusWave 0.8 (Note B2) 1)
                            // |> List.append(sinusWave 0.05 0 1)

                            // |> List.append(sinusWave 0.4 (Note A) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.3 (Note Gs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 1. (Note Fs) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.4 (Note Gs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.4 (Note A) 1)
                            // |> List.append(sinusWave 0.07 0 1)
                            // |> List.append(sinusWave 0.9 (Note Gs) 1)
                            // |> List.append(sinusWave 0.2 0 1)
                            // |> List.append(sinusWave 0.4 (Note Fs) 1)
                            // |> List.append(sinusWave 0.06 0 1)

                            // |> List.append(sinusWave 0.5 (Note E) 1)
                            // |> List.append(sinusWave 0.3 0 1)
                            // |> List.append(sinusWave 0.4 (Note Ds) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.9 (Note E) 1)
                            // |> List.append(sinusWave 0.09 0 1)
                            // |> List.append(sinusWave 0.2 (Note Ds) 1)
                            // |> List.append(sinusWave 0.08 0 1)
                            // |> List.append(sinusWave 0.3 (Note Ds) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.8 (Note E) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.3 (Note Fs) 1)
                            // |> List.append(sinusWave 0.1 0 1)

                            // -------------------------------------------------
                            // videoYT : 1,44

                            // |> List.append(sinusWave 0.18 (Note Gs) 1)
                            // |> List.append(sinusWave 0.16 0 1)
                            // |> List.append(sinusWave 0.1 (Note A) 1)
                            // |> List.append(sinusWave 0.5 0 1)
                            // |> List.append(sinusWave 0.1 (Note Gs) 1)
                            // |> List.append(sinusWave 0.13 0 1)
                            // |> List.append(sinusWave 0.23 (Note Fs) 1)
                            // |> List.append(sinusWave 0.15 0 1)
                            // |> List.append(sinusWave 0.7 (Note E) 1)
                            // |> List.append(sinusWave 0.17 0 1)
                            // |> List.append(sinusWave 0.6 (Note E) 1)
                            // |> List.append(sinusWave 0.9 0 1)
                            // |> List.append(sinusWave 0.13 (Note A) 1)
                            // |> List.append(sinusWave 0.5 0 1)
                            
                            // |> List.append(sinusWave 0.06 (Note Gs) 1)
                            // |> List.append(sinusWave 0.07 0 1)
                            // |> List.append(sinusWave 0.06 (Note Fs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.1 (Note E) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.3 (Note Fs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.25 (Note B2) 1)
                            // |> List.append(sinusWave 0.07 0 1)
                            // |> List.append(sinusWave 0.11 (Note Gs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.3 (Note B2) 1)
                            // |> List.append(sinusWave 0.05 0 1)

                            // |> List.append(sinusWave 0.7 (Note Cs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.3 (Note B2) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.08 (Note Fs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 0.08 (Note Gs) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            // |> List.append(sinusWave 1.2 (Note Fs) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.3 (Note E) 1)
                            // |> List.append(sinusWave 0.1 0 1)
                            // |> List.append(sinusWave 0.05 (Note E) 1)
                            // |> List.append(sinusWave 0.09 0 1)

                            //|> List.append(sinusWave 0.2 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.2 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.25 (Note Ds) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.3 (Note E) 1)
                            //|> List.append(sinusWave 0.05 0 1)
                            //|> List.append(sinusWave 0.25 (Note E) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.25 (Note Ds) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.35 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)

                            //|> List.append(sinusWave 0.15 (Note Fs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.17 (Note Gs) 1)
                            //|> List.append(sinusWave 0.04 0 1)
                            //|> List.append(sinusWave 0.05 (Note A) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.07 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.33 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.17(Note E) 1)
                            //|> List.append(sinusWave 0.04 0 1)
                            //|> List.append(sinusWave 0.05 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)

                            // |> List.append(sinusWave 0.1 (Note E) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.22 (Note E) 1)
                            // |> List.append(sinusWave 0. 0 1)
                            // |> List.append(sinusWave 0.17 (Note Ds) 1)
                            // |> List.append(sinusWave 0.01 0 1)
                            // |> List.append(sinusWave 0.34 (Note E) 1)
                            // |> List.append(sinusWave 0.05 0 1)
                            // |> List.append(sinusWave 0.09 (Note E) 1)
                            // |> List.append(sinusWave 0. 0 1)
                            // |> List.append(sinusWave 1.2(Note B) 1)
                            // |> List.append(sinusWave 0.06 0 1)
                            //|> List.append(sinusWave 0.2 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)

                            //|> List.append(sinusWave 0.06 (Note E) 1)
                            //|> List.append(sinusWave 0.04 0 1)
                            //|> List.append(sinusWave 0.1 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.25 (Note E) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.23 (Note Ds) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.3 (Note E) 1)
                            //|> List.append(sinusWave 0.04 0 1)
                            //|> List.append(sinusWave 0.16 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.25 (Note Ds) 1)
                            //|> List.append(sinusWave 0. 0 1)

                            //|> List.append(sinusWave 0.35 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.25 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.04 (Note A) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.04 (Note Gs) 1)
                            //|> List.append(sinusWave 0.04 0 1)
                            //|> List.append(sinusWave 0.33 (Note Fs) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.13 (Note E) 1)
                            //|> List.append(sinusWave 0.04 0 1)

                            //|> List.append(sinusWave 0.05 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.2 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.3 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.27 (Note Ds) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.3 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.06 (Note E) 1)
                            //|> List.append(sinusWave 0. 0 1)
                            //|> List.append(sinusWave 0.04 (Note Fs) 1)
                            //|> List.append(sinusWave 0.01 0 1)

                            //|> List.append(sinusWave 1.3 (Note B) 1)
                            //|> List.append(sinusWave 0.5 0 1)
                            //|> List.append(sinusWave 0.9 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.5 (Note Fs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.2 (Note B) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.35 (Note B2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note A) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.09 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.7 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.45 (Note Gs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.1 (Note A) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.4 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.3 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.1 (Note Ds) 1)
                            //|> List.append(sinusWave 0. 0 1)

                            //|> List.append(sinusWave 0.5 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.09 (Note Ds) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.6 (Note Cs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.06 (Note Ds) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.06 (Note Cs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.6 (Note B) 1)
                            //|> List.append(sinusWave 0.05 0 1)
                            //|> List.append(sinusWave 0.7 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)

                            //|> List.append(sinusWave 0.4 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.25 (Note B) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.45 (Note B2) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.17 (Note A) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.45 (Note Fs) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.2 (Note Gs) 1)
                            //|> List.append(sinusWave 0.01 0 1)

                            //|> List.append(sinusWave 0.25 (Note A) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.4 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.14 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.2 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.25 (Note Ds) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.35 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.09 (Note Ds) 1)
                            //|> List.append(sinusWave 0.15 0 1)

                            //|> List.append(sinusWave 0.15 (Note Ds) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.3 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note Gs) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.06 (Note A) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.07 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.1 (Note E) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.1 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.45 (Note Gs) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.05 (Note Fs) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.05 (Note Fs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.1 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.35 (Note B2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note A) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note Gs) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.25 (Note E) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.5 (Note Cs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.07 (Note Cs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.45 (Note B) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.1 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.13 (Note Fs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.5 (Note Gs) 1)
                            //|> List.append(sinusWave 0.05 0 1)
                            //|> List.append(sinusWave 0.09 (Note A) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.08 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.08 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.9 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.13 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.34 (Note B2) 1)
                            //|> List.append(sinusWave 0.1 0 1)
                            //|> List.append(sinusWave 0.1 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.12 (Note B2) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.35 (Note Cs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note Ds) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.35 (Note E) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.3 (Note Fs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.6 (Note Gs) 1)
                            //|> List.append(sinusWave 0.1 0 1)
                            //|> List.append(sinusWave 0.5 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.2 (Note Ds) 1)
                            //|> List.append(sinusWave 0.0 0 1)
                            //|> List.append(sinusWave 0.4 (Note Ds2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.2 (Note Cs2) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.1 (Note C2) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.45 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.6 (Note C2) 1)
                            //|> List.append(sinusWave 0.1 0 1)
                            //|> List.append(sinusWave 0.5 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note C2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note Cs2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.35 (Note C2) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.15 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.15 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note G) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.4 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.1 (Note G) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.6 (Note F) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.08 (Note G) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.08 (Note F) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.7 (Note Ds) 1)
                            //|> List.append(sinusWave 0.04 0 1)
                            //|> List.append(sinusWave 0.7 (Note Gs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.5 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.25 (Note Ds) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.4 (Note Ds2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.25 (Note Cs2) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.2 (Note C2) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.45 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.15 (Note C2) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.15 (Note Cs2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.4 (Note C2) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.13 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.2 (Note Gs) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.2 (Note G) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.35 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.13 (Note G) 1)
                            //|> List.append(sinusWave 0.01 0 1)
                            //|> List.append(sinusWave 0.15 (Note G) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.4 (Note Gs) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.09 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 0.35 (Note C) 1)
                            //|> List.append(sinusWave 0.03 0 1)
                            //|> List.append(sinusWave 0.05 (Note C) 1)
                            //|> List.append(sinusWave 0.02 0 1)

                            //|> List.append(sinusWave 0.3 (Note As) 1)
                            //|> List.append(sinusWave 0.02 0 1)
                            //|> List.append(sinusWave 1.3 (Note Gs) 1)
                            |> List.rev

    let echo2 = createEcho 0.5 Titanic 0.3  

    let Titanic2 = 
        Titanic
        |> List.map sample 
        |> Microsoft.FSharp.Collections.List.toArray

    let longueur2 = List.length(Titanic)

    let Titanic_song = File.Create(@"../Examples/Titanic.wav")

    printfn "%A " longueur2
    write Titanic_song Titanic2