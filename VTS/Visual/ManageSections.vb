Public Class ManageSections

    Dim dt As DataTable

    Private Sub ManageSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        dt = New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select SC_LBL as LABEL, SC_DSC As DESCRIPTION, SC_IN_OUT as IO, SC_DIR_LOC as DIRECTORY, SC_INDX as INDX, SC_TYP as TYPE  from Section_Labels")
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
        If (txtLbl.Text = Nothing Or txtDsc.Text = Nothing Or cmbIO.Text = Nothing Or txtDir.Text = Nothing) Then
            MessageBox.Show("Fields should not be empty")
            Return
        End If

        Dim opExec As New connection
        dt = New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select *  from Section_Labels where SC_LBL = '" & txtLbl.Text & "' and SC_IN_OUT = '" & cmbIO.Text & "'")
        Try

            If reader.HasRows = True Then

                MessageBox.Show("Label and InOut are already exist")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

        opExec.ExecuteSqlCommand("Insert into Section_Labels (SC_LBL,SC_DSC,SC_IN_OUT,SC_DIR_LOC,SC_TYP) values ('" & txtLbl.Text & "','" & txtDsc.Text & "','" & cmbIO.Text & "','" & txtDir.Text & "','" & cmbType.Text & "')")
        opExec.closeConnection()

        FillData()

        txtLbl.Text = ""
        txtDsc.Text = ""
        txtDir.Text = ""
        cmbIO.Text = ""

    End Sub

    Private Sub DeleteSection(ScLabel As String, ScIO As String)

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("delete from Section_Labels where SC_LBL = '" & ScLabel & "' and SC_IN_OUT = '" & ScIO & "' ")
        opExec.closeConnection()

        FillData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this section?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Delete") = vbYes Then
            DeleteSection(DataGridView1.SelectedCells(0).Value, DataGridView1.SelectedCells(2).Value)
        End If
    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub
End Class