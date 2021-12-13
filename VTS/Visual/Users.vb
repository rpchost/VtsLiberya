Public Class Users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100

    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        If (txtUserName.Text = "") Then
            MessageBox.Show("UserName should not be empty")
            Return
        End If
    End Sub

End Class