<h1>Project-3-Sound-Synthetizer</h1>

FSharpSyntheLibrary is a simple cross-platform(windows, mac) library multimedia. It is writtent in F# so you can use it in .NET core.

<h2>Authors</h2>

- Eloi Priol
- Elise Gautier
- Robin Debry
- Theo Trouvé
- Romain Nicolaon
- Thomas Planchard 

<h2>Download</h2>
For the moment you can't download it because it's an alpha version but for the future you are will able to download it with 2 different nuggets. One advanced and one simple 

<h2>Learn</h2>
To learn FSharpSynthe you can follow the tutorial

<h2>Code Example</h2>
You can run these examples in F# in Visual Studio. Make sure you build the project first. After that, simply copy and paste the code over in each of the following code examples. If you want to see the wave of each song. Download Audacity on this link : https://audacity.fr/ and put the file create by the code in Audacity to see the wave. 

<h3>Create the 4 basic wave forms and save it in a file</h3>
  
- Generate a .wav file containing a sawtooth wave or a sinus wave or a triangular wave or a square wave play in mono. Each wave last 1 second with a frequency of 523. and an amplitude of 0.8

```f#
open FSharpSynth.CreateWaveFile
open FSharpSynth.CreateWave


write "saw" sawtoothWave 1. 523. 0.8 
write "sine" sinusWave 1. 523. 0.8 
write "triangle" triangleWave 1. 523. 0.8 
write "square" squareWave 1. 523. 0.8 
```

<h3>Play an audio file</h3> 

- Play a audio file just by giving the path to the file 
  
```f#
open FSharpSynthe.PlaySound

PlaySound "saw.wav"
```

<h3>Change amplitude with a fixe amount</h3>

- Modify a wave amplitude with a fixe amount
```f#
open FSharpSynthe.Filter

amplitude (wave:list<float>) (amp:float)
```


<h3>Add echo to a song</h3>

- Apply directly a echo to a song if you want to see what happen on the wave put your audio file on Audacity. You can change the delay , and the amplitude of your echo.

```f#
open FSharpSynth.Filter

createEcho (delay : float) (wave : list<float>) (amp : float)
```

<h3>Add Chords effect</h3>

- Apply directly a chords effect with 2 waves different.
  
```f#
open FSharpSynth.Filter

chords  (wave: list<float>)  (wave2: list<float>)
```


<h3>Add overdriven effect</h3>

- Aplly an overdriven effect to a wave. You can setup your overdriven.

```f#
open FSharpSynth.Filter

overdriven (wave: list<float>) (overdriven: float)
```

<h3>Add flanger effect</h3>

- Apply a flanger effect to a wave 
  
```f#
open FSharpSynth.Filter

flanger (wave: list<float>)

```


<h3>add reverb effect</h3>


- Apply a reverb effect to a wave 
  
```f#
open FSharpSynth.Filter

reverb (wave: list<float>)

```
