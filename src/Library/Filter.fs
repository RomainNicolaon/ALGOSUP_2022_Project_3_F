namespace FSharpSynthe.Library

open System.Threading
open SFML.Audio
open SFML.System


module Filter =

    let reverb = 
        // calculation by applying the Sabine Formula
        let delay = (60 / 1) * 1000
        let blanche = delay * 2
        let croche = delay / 2
        delay