namespace FSharpSynthe.Library

open System.Threading
open SFML.Audio
open SFML.System


module Filter =

    let reverb = 
        // calculation by applying the Sabine Formula
        let delay = (60.0 / 0.2) * 1000.0
        let blanche = delay * 2.0
        let croche = delay / 2.0
        delay