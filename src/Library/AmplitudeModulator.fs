namespace FSharpSynthe.Library

open System

open CreateWave

module AM =
        let sinusAM  time freq amp ampLFO freqLFO=

          let t = 1. + (1./44100.) 
          let N = 44100. * time 
          let calc = 2. * Pi * freq
          let calcLFO = 2. * Pi * freqLFO
          let points = [(0.)..t..N] 

          let points = points |> List.map(fun x ->
           amp*ampLFO*sin(calcLFO*x)*sin(calc*x)) // equation to do an Amplitude Modulation

          points

        let sawtoothAM  time freq amp ampLFO freqLFO=

          let t = 1.+(1./44100.)
          let N = 44100. * time
          let points = [(0.)..t..N]
          let points = points |> List.map(fun i -> (amp * 2.) * (ampLFO*2.) *( i * freq - floor(0.5 + i*freq))*( i * freqLFO - floor(0.5 + i*freqLFO)))
          points 

        let TriangleAM time freq amp ampLFO freqLFO= //Sinusoidale
          let t = 1.+(1./44100.)
          let N = 44100. * time
          let points = [(0.)..t..N]
          let points = points |> List.map(fun i -> (amp * 2.)*(ampLFO*2.) * asin( sin( 2.* Pi * t * freq) * sin( 2.* Pi * t * freqLFO))/ Pi)
          points
          
        let SquareAM time freq amp ampLFO freqLFO= //Sinusoidale
            let t = 1.+(1./44100.)
            let N = 44100. * time
            let calc = 2. * Pi * freq
            let calcLFO = 2. *Pi*freqLFO
            let points = [(0.)..t..N]
            let points = points |> List.map(fun i -> amp *ampLFO* float(sign(sin(i*calc)))*float(sign(sin(i*calcLFO))))
            points 
         
