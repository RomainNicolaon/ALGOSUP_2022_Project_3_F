# Group F's Functional Specifications

[![made-with-FSharp](https://img.shields.io/badge/Languages%20Used:-FSharp-007acc.svg)](https://fsharp.org)

---

<details>
<summary>Table of Contents</summary>
  
- [Goals](#goals)
- [Requirements](#requirements)
- [Create and play a basic note](#create-and-play-a-basic-note)
- [Basic Filters, Envelopes and Chords](#basic-filters-envelopes-and-chords)
- [Non-functional requirements](#non-functional-requirements)

</details>
  
## Goals

For this project we have to create a synthesizer in F#, it is basically an electronic musical instrument that generates audio signals. With this synthesizer it will be possible to modify a waveform, add some effect to the song like echo, reverb, flanger... The audio create at the end must be in MP3 format

Deadline: 10,February 2022

- We have created this application with the help of Robert Pickering our professor in F#

The project is developed with F#.

## Requirements

To run this project you need an IDE, we have chosen to use [Visual Studio Code](https://code.visualstudio.com/download).
You should also install [dotnet.6](https://dotnet.microsoft.com/en-us/download)

To execute correctly the project you need to install a library call SFML. This library is used just to open an audio file. So to install it open the terminal and enter the following commands:

```dotnet add package SFML.Net --version 2.5.0```

Then you need to install XPlot to see the wave in a web page. Enter in the terminal the following commands:
```dotnet add package XPlot.GoogleCharts --version 3.0.1```

## Create and play a basic note

At the beginning we need the four basic waveform(sine,square,triangle and sawtooth).To make this we have create four function for each waveform with each calcul different to each wave.

```F#
let sample x = (x + 1.)/2. * 255. |> byte
let SquareWave time freq amp = 
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let calc = 2. * Pi * freq
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * float(sign(sin(i*calc))))
            points 
let TriangleWave time freq amp = 
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp * 2. * asin( sin( 2.* Pi * t * freq))/ Pi)
            points 
let SawtoothWave time freq amp = 
        let t = 1.+(1./44100.)
        let N = 44100. * time
        let points = [(0.)..t..N]
        let points = points |> List.map(fun i -> amp * 2. * ( i * freq - floor(0.5 + i*freq)))
        points 
 let sinusWave  time freq amp =

        let t = 1. + (1./44100.) 
        let N = 44100. * time 
        let calc = 2. * Pi * freq  
        let points = [(0.)..t..N] 
        let points = points |> List.map(fun x -> amp * sin(calc*x) ) 
        points
```

 When you create a file it was save at the same place of the program to be use after with this function:

 ```F#
 let streamSquare = File.Create(@"Square.wav")
 ```

  To read a section of an audio file you need a Time to begin you initialise a time on millisecond like this :
  
  ```F#
    let t = Time.FromMilliseconds(10000) 
    //put the audio at the time select before
    do sound.set_PlayingOffset(t)
  ```

   To play a sound without saving it you need just the function PlaySound with this you just play the sound create but you don't save it.

## Basic Filters, Envelopes and Chords

We have three basic filters the echo, the flange effect and the reverberation also we have a filter to modify the wave amplitude by a fixed amount. Firstly this modification you need to have a parameter for the amplitude.
To make the overdriven you need a loop for to make the effect on all of the sound.

```F#
let overdriven (wave: list<float>) (overdriven: float) =
        let effect1 = [for i in 0 .. wave.Length-1 
        do if  wave.Item(i)>=overdriven then yield overdriven else yield wave.Item(i)]
        let negative = -overdriven
        let effect2 = [for i in 0 .. effect1.Length-1 
        do if  effect1.Item(i)<=negative then yield negative else yield effect1.Item(i)]
        effect2
```

 For the echo,the flange and the reverberation you need two different sound : the basic sound and a second with the effect for the echo code is this :

  ```F#
  let amplitude (initialList:list<float>) (amp:float) =
         let returnList = List.map (fun x -> x*amp) initialList
         returnList
        
    let createEcho (delay : float) (wave : list<float>) (amp : float)= // Add echo to the sound
        let timeDelay = 44100. * delay
        let timeDelay = int timeDelay
        let startmusic =        
            [for i in  1 .. wave.Length-1  do if i <= timeDelay then yield wave.Item(i) else yield 0.  ] |> List.filter( fun x -> x <> 0.)
        let echowave =        
            [for i in  1 .. wave.Length-1  do if i <= timeDelay then yield wave.Item(i) else yield 0.  ] |> List.filter( fun x -> x <> 0.) 
        let echowave =  amplitude echowave amp
        let EndMusic = 
            [for i in timeDelay .. wave.Length-1 do yield wave.Item(i) ] 
        let timeDelay2 = sinusWave 0.2 0. 0.
        let wavesum = // sum of two waves
            startmusic |> List.append(timeDelay2) |> List.append(echowave) |> List.append(EndMusic)|> List.rev
        wavesum

    let flanger (wave: list<float>) = 
        let effect = [for i in 0 .. wave.Length do if i%10 = 0 then yield 0. else yield  wave.Item(i)] 
        effect 
    

    let overdriven (wave: list<float>) (overdriven: float) =
        let effect1 = [for i in 0 .. wave.Length-1 do if  wave.Item(i)>=overdriven  then yield overdriven else yield  wave.Item(i)]
        let negative = -overdriven    
        let effect2 = [for i in 0 .. effect1.Length-1 do if  effect1.Item(i)<=negative  then yield negative else yield  effect1.Item(i)]
        effect2

    let chords  (wave: list<float>)  (wave2: list<float>) = 
        let effect = [for i in 0 .. wave.Length-1 do yield wave.Item(i)+wave2.Item(i)]|> List.map(fun x -> x/2.)
        effect    
  ```
