Public Class TimerSet
    Private Sub TimerSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100
        Me.WindowState = FormWindowState.Maximized

        Dim opExec As New connection
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from settings")
        Try

            If reader.HasRows = True Then

                reader.Read()
                txtValue.Text = IIf(IsDBNull(reader("TimerInterval")), 0, reader("TimerInterval"))
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (Not IsNumeric(txtValue.Text)) Then
            MessageBox.Show("Timer value should be numeric")
            Return
        End If
        If (txtValue.Text.Length > 10) Then
            MessageBox.Show("Timer value should not pass 10 digits")
            Return
        End If

        Dim opExec As New connection
        If (opExec.ExecuteSqlCommand("update Settings set TimerInterval = '" & txtValue.Text.Trim & "'").Item1) Then
            MessageBox.Show("Timer value saved")
        End If
        opExec.closeConnection()
        Me.Close()
    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub
End Class