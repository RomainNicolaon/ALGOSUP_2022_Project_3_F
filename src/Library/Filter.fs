namespace FSharpSynthe.Library


module Filter =

    open System.Threading
    open System
    open FSharpSynthe.CreateWave

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


    let sinus = Array.init time (fun i -> AmplitudeBase * sin((Frequency/ Pi) * float i))

    let Overdriven (overdrive:float) (waves: float array) time =
        for i in 0.. time do
            if waves.[i] < -overdrive then
                waves.[i] <- -overdrive
            elif waves.[i] > overdrive then
                waves.[i]  <- overdrive
        
        sinus

    let sinWave = Overdriven 0.7 sinus (time - 1)


    let lowPass sampleRate cutoffFreq (data:List<float>) =
        let RC = 1. / (2. * Math.PI * cutoffFreq)
        let dt = 1. / sampleRate
        let alpha = dt / (RC + dt)
        let alpha2 = 1. - alpha

        let mutable last = alpha * data.[0]
        [last] @ (
            data
            |> List.tail
            |> List.map (fun x ->
                last <- alpha * x + alpha2 * last
                last
            )
        )