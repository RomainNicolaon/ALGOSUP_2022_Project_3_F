namespace FSharpSynthe

module DisplayWave =
    open XPlot.GoogleCharts
    open FSharpSynthe.Library.CreateWave
    let display (wave:List<float>) =
            wave
            |>Chart.Line
            |>Chart.Show
