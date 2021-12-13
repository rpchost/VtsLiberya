Public Class VTSTypesGroups
    Private Sub VTSTypesGroups_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height
        Me.Top = My.Computer.Screen.WorkingArea.Top
        Me.Left = My.Computer.Screen.WorkingArea.Left
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100
        Me.WindowState = FormWindowState.Maximized

        Dim str As String = ""

        FillData()
    End Sub

    Private Sub FillData()

        Dim opExec As New connection
        Dim dt As New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, VTS_TYP_GR As TYPE from VTS_TYPES_GR")
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
        If (txtType.Text = Nothing) Then
            MessageBox.Show("Field should not be empty")
            Return
        End If

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("Insert into VTS_TYPES_GR (VTS_TYP_GR) values ('" & txtType.Text & "')")
        opExec.closeConnection()

        FillData()

        txtType.Text = ""

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this Group?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Delete") = vbYes Then
            DeleteSection(DataGridView1.SelectedCells(0).Value)

        End If
    End Sub

    Private Sub DeleteSection(GrId As Integer)

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("delete from VTS_TYPES_GR where ID = " & GrId)
        opExec.closeConnection()

        FillData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class