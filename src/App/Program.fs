module main

open System
open SFML.Audio
open System.Threading
open CreateWave
open XPlot.GoogleCharts
// let PlaySound = 
//     let buffer = new SoundBuffer("test.wav")
//     let sound  = new Sound(buffer)
//     sound.Play()

//     while sound.Status = SoundStatus.Playing do 
//         Thread.Sleep(100)

        
// PlaySound

sinus |> Chart.Line |> Chart.Show