namespace FSharpSynthe

module DisplayWave =
    open XPlot.GoogleCharts
    open FSharpSynthe.CreateWave
    let display (wave:List<float>) =
            wave
            |>Chart.Line
            |>Chart.Show
