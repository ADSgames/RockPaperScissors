Public Class Game
    Dim guess As Integer
    Dim number As Integer
    Dim guess_string As String
    Dim number_string As String
    Dim understand As Boolean

    Private Sub btnRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRock.Click
        guess = 1
        guess_string = "rock"
        Randomize()
        number = Math.Round(1 + Rnd() * 2)
        mainGame()
    End Sub

    Private Sub btnPaper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaper.Click
        guess = 2
        guess_string = "paper"
        Randomize()
        number = Math.Round(1 + Rnd() * 2)
        mainGame()
    End Sub

    Private Sub btnScissors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScissors.Click
        guess = 3
        guess_string = "scissors"
        Randomize()
        number = Math.Round(1 + Rnd() * 2)
        mainGame()
    End Sub

    Private Sub mainGame()
        'Guess

        'translates letters to numbers for computer
        If number = 1 Then
            number_string = "rock"
        ElseIf number = 2 Then
            number_string = "paper"
        ElseIf number = 3 Then
            number_string = "scissors"
        End If

        'Display outcome
        lblInfo.Text = "Opponent chooses " & number_string & " and you choose " & guess_string & "!"

        If number = guess Then
            lblInfo.Text = lblInfo.Text + " Draw."
            My.Settings.draws += 1
        ElseIf number = 1 And guess = 2 Or number = 2 And guess = 3 Or number = 3 And guess = 1 Then
            lblInfo.Text = lblInfo.Text + " You win!"
            My.Settings.wins += 1
        ElseIf number = 2 And guess = 1 Or number = 3 And guess = 2 Or number = 1 And guess = 3 Then
            lblInfo.Text = lblInfo.Text + " You Lose."
            My.Settings.losses += 1
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class