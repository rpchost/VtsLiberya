Public Class CalculatedVts
    Private Sub CalculatedVts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height
        Me.Top = My.Computer.Screen.WorkingArea.Top
        Me.Left = My.Computer.Screen.WorkingArea.Left
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100
        Me.WindowState = FormWindowState.Maximized

        Dim str As String = ""

        FillVtsGroupTypes()
        FillData()
    End Sub

    Private Sub FillVtsGroupTypes()

        Dim opExec As New connection
        Dim dt As New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from VTS_TYPES_GR")
        Try

            If reader.HasRows = True Then

                dt.Load(reader)

            End If


            cmbType.DataSource = dt
            cmbType.ValueMember = "ID"
            cmbType.DisplayMember = "VTS_TYP_GR"


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Sub

    Private Sub FillData()

        Dim opExec As New connection
        Dim dt As New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, CLC_VTS_CODE As CODE, CLC_VTS_TYP As TYPE, CLC_EQUATION as EQUATION from CALCULATED_VTS_CODES")
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
        If (txtCode.Text = Nothing Or txtCode.Text = "" Or cmbType.Text = "") Then
            MessageBox.Show("Fields should not be empty")
            Return
        End If

        If (lblID.Text = "") Then
            Dim opExec As New connection
            opExec.ExecuteSqlCommand("Insert into CALCULATED_VTS_CODES (CLC_VTS_CODE, CLC_VTS_TYP, CLC_EQUATION) values ('" & txtCode.Text & "', '" & cmbType.Text & "', '" & txtEquation.Text & "')")
            opExec.closeConnection()
        Else
            Dim opExec As New connection
            opExec.ExecuteSqlCommand("update CALCULATED_VTS_CODES set  CLC_VTS_CODE='" & txtCode.Text & "', CLC_VTS_TYP='" & cmbType.Text & "', CLC_EQUATION = '" & txtEquation.Text & "'  where ID=" & lblID.Text)
            opExec.closeConnection()
            lblID.Text = ""
            btnAdd.Text = "Add"
        End If

        FillData()

        txtCode.Text = ""
        cmbType.Text = ""
        txtEquation.Text = ""

    End Sub


    Private Sub DeleteSection(GrId As Integer)

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("delete from CALCULATED_VTS_CODES where ID = " & GrId)
        opExec.closeConnection()

        FillData()

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this Calculated Code?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Delete") = vbYes Then
            DeleteSection(DataGridView1.SelectedCells(0).Value)
        End If
    End Sub

    Private Sub FillTmpFields(Id As Integer, CLC_VTS_CODE As String, CLC_VTS_TYP As String, CLC_EQUATION As String)

        lblID.Text = Id
        txtCode.Text = CLC_VTS_CODE
        cmbType.Text = CLC_VTS_TYP
        txtEquation.Text = CLC_EQUATION
        btnAdd.Text = "Update"

    End Sub


    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim i As Integer = e.RowIndex
        Dim j As Integer = e.ColumnIndex

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        FillTmpFields(row.Cells(0).Value.ToString(), row.Cells(1).Value.ToString(), row.Cells(2).Value.ToString(), row.Cells(3).Value.ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class