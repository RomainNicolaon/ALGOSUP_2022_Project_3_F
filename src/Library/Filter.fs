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
        let echowave2 =  amplitude echowave (amp/2.) 

        let EndMusic = 
            [for i in timeDelay .. wave.Length-1 do yield wave.Item(i) ] 
        let timeDelay2 = sinusWave 0.2 0. 0.
        let wavesum = // sum of two waves
           startmusic |> List.append(timeDelay2) |> List.append(echowave) |> List.append(timeDelay2)|> List.append(echowave2)|>List.append(timeDelay2) |> List.append(EndMusic)|> List.rev



    let overdriven (wave: list<float>) (overdriven: float) =
        let effect1 = [for i in 0 .. wave.Length-1 do if  wave.Item(i)>=overdriven  then yield overdriven else yield  wave.Item(i)]
        let negative = -overdriven
        let effect2 = [for i in 0 .. effect1.Length-1 do if  effect1.Item(i)<=negative  then yield negative else yield  effect1.Item(i)]
        effect2


    let flanger (wave: list<float>) = 
        let effect = [for i in 0 .. wave.Length do if i%10 = 0 then yield 0. else yield  wave.Item(i)] 
        effect 
    
    let chords  (wave: list<float>)  (wave2: list<float>) = 
        let effect = [for i in 0 .. wave.Length-1 do yield wave.Item(i)+wave2.Item(i)]|> List.map(fun x -> x/2.)
        effect    

    let reverb (wave: list<float>) = 
        let revrb1 =
            [for i in  1 .. wave.Length-1  do if i <= 4410 then yield 0. else yield wave.Item(i)  ] |> List.filter( fun x -> x <> 0.)
        let revrb1final = sinusWave 0.1 0. 0. |> List.append(revrb1) |> List.map (fun x -> x*0.5)

        let revrb2 = 
            [for i in  1 .. wave.Length-1  do if i <= 8820 then yield 0. else yield wave.Item(i)  ] |> List.filter( fun x -> x <> 0.)
        let revrb2final = sinusWave 0.2 0. 0. |> List.append(revrb2) |> List.map (fun x -> x*0.25)
       
        let revrb3 =
            [for i in  1 .. wave.Length-1  do if i <= 13230 then yield 0. else yield wave.Item(i)  ] |> List.filter( fun x -> x <> 0.)
        let revrb3final = sinusWave 0.3 0. 0. |> List.append(revrb3) |> List.map (fun x -> x*0.125)
    
        let final = 
            [for i in 0 .. wave.Length-1 do yield (wave.Item(i)+revrb1final.Item(i)+revrb2final.Item(i)+revrb3final.Item(i))/4.]
        final
    
    
    let lowPass sampleRate cutoffFreq (wave:List<float>) =
        let RC = 1. / (2. * Math.PI * cutoffFreq)
        let dt = 1. / sampleRate
        let alpha = dt / (RC + dt)
        let second_alpha = 1. - alpha

        let mutable last = alpha * wave.[0]
        [last] @ (
            wave
            |> List.tail
            |> List.map (fun x ->
                last <- alpha * x + second_alpha * last
                last
            )
        )