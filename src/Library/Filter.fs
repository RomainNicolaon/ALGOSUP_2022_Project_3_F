namespace FSharpSynthe


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
        let echowave =  amplitude echowave (amp/2.) 
        let echowave2 =  amplitude echowave (amp/4.) 

        let EndMusic = 
            [for i in timeDelay .. wave.Length-1 do yield wave.Item(i) ] 
        let timeDelay2 = sinusWave 0.2 0. 0.
        let wavesum = // sum of two waves
           startmusic |> List.append(timeDelay2) |> List.append(echowave) |> List.append(timeDelay2)|> List.append(echowave2)|>List.append(timeDelay2) |> List.append(EndMusic)|> List.rev
        wavesum



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

        let revrb1 = sinusWave 0.1 0. 0. |> List.append(wave) |> List.map (fun x -> x*0.5)

        let revrb2 = sinusWave 0.2 0. 0. |> List.append(wave) |> List.map (fun x -> x*0.25)
       
        let revrb3 = sinusWave 0.3 0. 0. |> List.append(wave) |> List.map (fun x -> x*0.125)

        let final = 
            [for i in 0 .. wave.Length do yield (wave.Item(i)+revrb1.Item(i)+revrb2.Item(i)+revrb3.Item(i))/4.]
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

    let sinusAM time (wave:list<float>) ampLFO freqLFO=
          let calcLFO = 2. * Pi * freqLFO
          let t = 1.+(1./44100.)
          let N = 44100. * time
          let points = [(0.)..t..N-1.]
          let sinusAM = points |> List.map(fun i -> wave[int(i)]*ampLFO*sin(calcLFO*i))
          sinusAM

                // equation to do an Amplitude Modulation
    let sawtoothAM  time (wave:list<float>) ampLFO freqLFO=

          let t = 1.+(1./44100.)
          let N = 44100. * time
          let points = [(0.)..t..N-1.]
          let sawtoothAM = points |> List.map(fun i -> wave[int(i)]* ampLFO*( i * freqLFO - floor(0.5 + i*freqLFO)))
          sawtoothAM 

    let TriangleAM time (wave:list<float>) ampLFO freqLFO= //Sinusoidale
          let t = 1.+(1./44100.)
          let N = 44100. * time
          let points = [(0.)..t..N-1.]
          let TriangleAM = points |> List.map(fun i -> wave[int(i)]*(ampLFO*2.) *asin( sin( 2.* Pi * i * freqLFO))/ Pi)
          TriangleAM
          
    let SquareAM time (wave:list<float>) ampLFO freqLFO= //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let calcLFO = 2. *Pi*freqLFO
            let points = [(0.)..t..N-1.]
            let points = points |> List.map(fun i -> wave[int(i)]*ampLFO*float(sign(sin(i*calcLFO))))
            points 