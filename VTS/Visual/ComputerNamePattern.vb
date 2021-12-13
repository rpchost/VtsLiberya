Public Class ComputerNamePattern
    Private Sub ComputerNamePattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100
        Me.WindowState = FormWindowState.Maximized

        Dim opExec As New connection
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from settings")
        Try

            If reader.HasRows = True Then

                reader.Read()

                lblCurrentPattern.Text = "[" & IIf(IsDBNull(reader("ComputerPatternPrefix")), "", reader("ComputerPatternPrefix")) + " " + IIf(IsDBNull(reader("ComputerPattern")), "", reader("ComputerPattern")) + "]"

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If (txtPrefix.Text.Trim = "" Or cmbPattern1.Text = "" Or cmbPattern2.Text = "") Then
            MessageBox.Show("Fields must not be empty")
            Return
        End If

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("update Settings set ComputerPatternPrefix = '" & txtPrefix.Text.Trim & "', ComputerPattern = '" & cmbPattern1.Text & " & " & cmbPattern2.Text & " ' ")
        opExec.closeConnection()

        lblCurrentPattern.Text = txtPrefix.Text.Trim + " " + cmbPattern1.Text + " " + cmbPattern2.Text
    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub
End Class