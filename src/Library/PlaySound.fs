﻿module PlaySound

open System.Threading
open SFML.Audio
open SFML.System


type PlaySound (way:string)  = 
    let buffer = new SoundBuffer(way)
    let sound  = new Sound(buffer)
    //initialise the time to begin the audio at this time
    let t = Time.FromMilliseconds(10000) 

    //put the audio at the time select before
    do sound.set_PlayingOffset(t)
    //Play the sound at the time select or at the beginning if we don't select time
    do sound.Play()

    do while sound.Status = SoundStatus.Playing do 
        Thread.Sleep(100)