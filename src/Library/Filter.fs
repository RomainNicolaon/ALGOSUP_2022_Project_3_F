namespace FSharpSynthe.Library


module Filter =

    open System.Threading
    open System
    open FSharpSynthe.Library.CreateWave

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