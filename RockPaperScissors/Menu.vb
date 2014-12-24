Public Class Menu
    '1=rock
    '2=paper
    '3=scissors
    Private Sub play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Game.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.adsgames.net")
    End Sub

    Private Sub quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        My.Settings.Save()
        End
    End Sub

    Private Sub stats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats.Click
        Stats.Show()
    End Sub
End Class
