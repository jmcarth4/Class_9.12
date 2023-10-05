Public Class Form1
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim userName As String

        userName = InputTextBox.Text

        If IsNumeric(userName) Then
            MsgBox("Bad!")
            BadLabel.Text = BadLabel.Text + 1

        Else
            OutputLabel.Text = userName
            GoodLabel.Text = GoodLabel.Text + 1
        End If
        InputTextBox.Clear()
    End Sub


End Class
