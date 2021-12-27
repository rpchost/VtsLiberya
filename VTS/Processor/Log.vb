Public Class Log
    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100

        FillData()

        Timer1.Interval = 10000
        Timer1.Start()

    End Sub

    Private Sub FillData()

        Dim opExec As New connection
        Dim dt = New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, LG_DSC as [ERR DESCRIPTION], LG_DATETIME As [ERR DATE], LG_SRC as [ERR SOURCE], LG_ERR as ERROR  from VTS_RYME_LOGGER where LG_ERR <> 'VTS RYME PROCESS' order by ID desc")
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FillData()
    End Sub
End Class