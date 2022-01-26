# Group F's Technical Specifications

---

<details>
<summary>Table of Contents</summary>

- [Technologies Badges](#technologies-badges)
- [Technical Specification](#technical-specification)
- [Create and play a basic note](#create-and-play-a-basic-note)
- [Basic Filters, Envelopes and Chords](#basic-filters-envelopes-and-chords)

</details>

## Technologies Badges

[![made-with-FSharp](https://img.shields.io/badge/Languages%20Used:-FSharp-007acc.svg)](https://fsharp.org)

[![made-with-Visual-Studio-Code](https://img.shields.io/badge/Softwares%20Used:-Visual%20Studio%20Code-0078d7.svg)](https://code.visualstudio.com) [![made-with-Visual-Studio-Community](https://img.shields.io/badge/Visual%20Studio%20Community-5d2b90.svg)](https://visualstudio.microsoft.com/vs/community/)

## Technical specification

  The end goal of the project is to have a synthetiser that let users program a music (note, scale, amplitude, length, effects,...).

  The users will be able to do it thanks to an interface in which they will be able to program their music.
  
## Create and play a basic note

At the beginning we need the four basic waveform(sine,square,triangle and sawtooth).To make this we have create four function for each waveform. After you create a file in .wav corresponding to the wave. You write the file that has just been created and you use a function to display it.
when you run your program the wave was create with parameter choose on the program. When you create a file it was save at the same place of the program to be use after. To read a section of an audio file you need a Time to begin you initialise a time on millisecond.After you can put the audio at the time select before with this a function. To play a sound without saving it you need just the function PlaySound with this you just play the sound create but you don't save it.

## Basic Filters, Envelopes and Chords

We have three basic filters the echo, the flange effect and the reverberation also we have a filter to modify the wave amplitude by a fixed amount. for this modification you need to have a parameter for the amplitude. To make the overdriven you need a loop for to make the effect on all of the sound and to know when make the effect on the sound because it depend of the amplitude of the sound. For the echo,the flange and the reverberation you need two different sound : the basic sound and a second with the effect for the echo it's the same sound repeat lower than the previous indeed to make a echo effect you need an amplitude lower than the basic sound. For the flange effect is more complicated because you need also two sound but the second sound is the same than the first but with a time lag of 20 millisecond at the beginning but the second sound is gradually catching up the basic sound and when the basic and the second sound is equivalent the second sound slow down and it was repeat at each sound. To make the reverberation you need two sound also because the second is to extend the sound.
