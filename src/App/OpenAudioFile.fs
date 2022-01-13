namespace FSharpSynthe.App

open System
open FSharpSynthe.Library.PlaySound

module OpenAudio =

    let result = PlaySound("Sinus.wav")
    result 
    