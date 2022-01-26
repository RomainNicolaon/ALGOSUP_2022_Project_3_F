namespace FSharpSynthe.Library

module DisplayWave =
    open XPlot.GoogleCharts
    open FSharpSynthe.Library.CreateWave
     let Char data =
        data
        |>Chart.Combo
        |>Chart.Show
