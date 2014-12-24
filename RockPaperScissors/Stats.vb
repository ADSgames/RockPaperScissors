Imports System.Windows.Forms.DataVisualization.Charting

Public Class Stats
    Private Sub Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        statsGraph.Series(0).Points(0).YValues(0) = My.Settings.wins
        statsGraph.Series(0).Points(1).YValues(0) = My.Settings.draws
        statsGraph.Series(0).Points(2).YValues(0) = My.Settings.losses

        lblNumberWins.Text = My.Settings.wins
        lblNumberTies.Text = My.Settings.draws
        lblNumberLosses.Text = My.Settings.losses
    End Sub

    Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErase.Click
        My.Settings.wins = 0
        My.Settings.draws = 0
        My.Settings.losses = 0

        statsGraph.Series(0).Points(0).YValues(0) = My.Settings.wins
        statsGraph.Series(0).Points(1).YValues(0) = My.Settings.draws
        statsGraph.Series(0).Points(2).YValues(0) = My.Settings.losses

        lblNumberWins.Text = My.Settings.wins
        lblNumberTies.Text = My.Settings.draws
        lblNumberLosses.Text = My.Settings.losses

        statsGraph.ResetAutoValues()
    End Sub

    Private Sub Stats_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        statsGraph.Series(0).Points(0).YValues(0) = My.Settings.wins
        statsGraph.Series(0).Points(1).YValues(0) = My.Settings.draws
        statsGraph.Series(0).Points(2).YValues(0) = My.Settings.losses

        lblNumberWins.Text = My.Settings.wins
        lblNumberTies.Text = My.Settings.draws
        lblNumberLosses.Text = My.Settings.losses

        statsGraph.ResetAutoValues()
    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close.Click
        Me.Hide()
    End Sub
End Class