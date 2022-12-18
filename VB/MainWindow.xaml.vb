Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace ScrollableLegend

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim rnd As Random = New Random()
            Dim today As Date = Date.Today
            Me.chart.BeginInit()
            For i As Integer = 0 To 20 - 1
                Dim areaSeries As AreaStackedSeries2D = New AreaStackedSeries2D()
                areaSeries.ArgumentScaleType = ScaleType.DateTime
                areaSeries.LabelsVisibility = False
                areaSeries.Transparency = 0.3
                areaSeries.DisplayName = "Area " & (i + 1).ToString()
                For j As Integer = 0 To 30
                    Dim p As SeriesPoint = New SeriesPoint(today.AddDays(j), rnd.Next(50, 100))
                    areaSeries.Points.Add(p)
                Next

                Me.xyDiagram.Series.Add(areaSeries)
            Next

            Me.chart.EndInit()
        End Sub
    End Class
End Namespace
