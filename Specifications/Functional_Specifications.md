
[![made-with-FSharp](https://img.shields.io/badge/Languages%20Used:-FSharp-007acc.svg)](https://fsharp.org)

# Functionnal Specification
<details>
<summary>Table of Contents</summary>
- [Goals](#goals)
- [Deliverables](#deliverables)
- [Tasks](#tasks)
- [Requirements](#requirements)
- [Product overview](#product-overview) 
</details>

## Goals

For this project we have to create a synthesizer in F#, it is basically an electronic musical instrument that generates audio signals. With this synthesizer it will be possible to modify a waveform, add some effect to the song like echo, reverb, flanger... The audio create at the end must be in MP3 format 

Deadline: 11 of February 2022

  - We have created this application with the help of Robert Pickering our professor in F#

  The project is developed with F#.

  

## Deliverables

| Ref | Description                                                                                   | Required By Date |
| --- | --------------------------------------------------------------------------------------------- | ---------------- |
| 1   | Part 1 - Create and Play a Basic Note                                                         | 14 January 2022  |
| 2   | Functional specification                                                                      | 20 January 2022  |
| 3   | Technical specification                                                                       | 20 January 2022  |
| 4   | Software architecture design choices                                                          | 20 January 2022  |
| 5   | Part 2 - Basic Filters, Envelopes, and Chords                                                 | 21 January 2022  |
| 6   | Part 3 - Frequency Analysis and Advanced filters                                              | 28 January 2022  |
| 7   | Part 4 - MP3 Compression                                                                      | 11 February 2022 |
| 8   | Unit tests to show that the API is working properly                                           | 11 February 2022 |                                                                                                                                         



## Tasks


| Ref | Description                                                                                         | Required By Date | 
| --- | --------------------------------------------------------------------------------------------------- | ---------------- | 
| 1   | Create the four basic wave forms: sine, square, triangle and sawtooth.                              | 14 January 2022  |
| 2   | A function to save waveform to disk, so it can be played back through a standard audio application. | 14 January 2022  | 
| 3   | A function to read a section of an audio file from disk.                                            | 14 January 2022  |
| 4   | A function to play the waveform directly without saving it to disk.                                 | 14 January 2022  | 
| 5   | Modify the wave’s amplitude by a fixed amount                                                       | 21 January 2022  |
| 6   | Cut off the wave at specific amplitude to given the “overdriven” often used in rock songs           | 21 January 2022  | 
| 7   | A echo effect filter                                                                                | 21 January 2022  |
| 8   | A flange effect filter                                                                              | 21 January 2022  | 
| 9   | A reverb effect filter                                                                              | 21 January 2022  | 
| 10  | Frequency Analysis and Advanced filters                                                             | 28 January 2022  |
| 11  | MP3 Compression                                                                                     | 11 February 2022 | 


## Requirements 

To run this project you need an IDE, we have chosen to use [Visual Studio Code](https://code.visualstudio.com/download). 
You should also install [dotnet.6](https://dotnet.microsoft.com/en-us/download)

To execute correctly the project you need to install a library call SFML. This library is used just to open an audio file. So to install it open the terminal and enter the following commands:

``` dotnet add package SFML.Net --version 2.5.0```

Then you need to install XPlot to see the wave in a web page. Enter in the terminal the following commands:

```dotnet add package XPlot.GoogleCharts --version 3.0.1```


## Non-functional requirements 

If we have the time it possible to create a User Interface for the synthesizer that is possible to show immediately the waves and where it possible with some buttons to add an effect or change the wave with different parameters.
