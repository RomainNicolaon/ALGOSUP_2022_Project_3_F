module PlaySound

open System.Threading
open SFML.Audio


let PlaySound (way:string)  = 
    let buffer = new SoundBuffer(way)
    let sound  = new Sound(buffer)
    do sound.Play()
    do while sound.Status = SoundStatus.Playing do 
        Thread.Sleep(100)
