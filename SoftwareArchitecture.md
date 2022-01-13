# Software Architecture design group F

---

<details>

<summary><strong>Table of Contents</strong></summary>

- [Software Architecture design group F](#Software-Architecture-design-group-F)
  - [1. WaveForm part](#1-WaveForm-part)
  - [2. Sound part](#2-Sound-part)

  </details>

---
## 1. WaveForm part

We begin by generate a WaveForm they have four basic WaveForm(square,sinusoidale,sawtooth,triangle), after that we save this WaveForm if the WaveForm was not save we retry to save this WaveForm.When the WaveForm was save you can read them but you can also read a WaveForm directly without saving them. If the WaveForm was not read you regenerate them to can read the Wave. When the Wave was read you can modify the amplitude of the wave.
If the amplitude was not change you retry to change the amplitude of the way. After that when you change the amplitude you can read the wave with the changes. Afterward you can cut off
at a specific amplitude. If the wave is not cut off at a specific amplitude you retry the phase.Afterward when the wave was cut you can modify amplitude and frequency for the low pass filter or for the high pass filter. For the low pass filter we removed the low frequencies if the low frequencies was not removed you retry to modify the frequency of the wave. You see if the low frequencies was removed the wave became a low frequency oscillator. For the high pass filter it was the opposite it was the high frequencies removed to have a high frequency oscillator

## 2. Sound part
We begin to create or download an audio.After that we see if we can read the audio. If we can't we verify the way of the file. When the audio play we can add an echo, a flange effect filter and a reverb effect. if each effect don't work we retry to add each. When each work you can play an audi with all effect.Afterward we create a wrapper to implement the MP3 compression if the wrapper doesn't work we retry the phase of wrapper. 