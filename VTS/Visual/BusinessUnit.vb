Public Class BusinessUnit

    Private Sub BusinessUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100

        FillData()

    End Sub

    Private Sub FillData()

        Dim opExec As New connection
        Dim dt As New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, Label as BU  from BusinessUNit")
        Try

            If reader.HasRows = True Then

                dt.Load(reader)

            End If

            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (txtBusinessUnit.Text = Nothing) Then
            MessageBox.Show("Field should not be empty")
            Return
        End If

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("Insert into BusinessUNit (Label) values ('" & txtBusinessUnit.Text & "')")
        opExec.closeConnection()

        FillData()

        txtBusinessUnit.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Are you sure you want to delete this BU?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Delete") = vbYes Then
            Try
                DeleteSection(DataGridView1.SelectedCells(0).Value)
            Catch ex As Exception
                MessageBox.Show("You should select 1 row to delete")
            End Try

        End If
    End Sub

    Private Sub DeleteSection(GrId As Integer)

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("delete from BusinessUNit where ID = " & GrId)
        opExec.closeConnection()

        FillData()

    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub
End Class