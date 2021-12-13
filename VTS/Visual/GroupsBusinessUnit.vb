Public Class GroupsBusinessUnit
    Private Sub GroupsBusinessUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100

        FillAvailableBU()
        FillGroup()
        FillGroupBU(cmbGroup.SelectedValue)

    End Sub

    Private Sub FillGroup()
        Dim str As String
        Dim dtGroup As New Data.DataTable

        Dim conn As New connection
        str = "select * from groups"
        dtGroup = conn.ExecuteReaderdt(str)
        cmbGroup.DataSource = dtGroup
        cmbGroup.DisplayMember = "Label"
        cmbGroup.ValueMember = "ID"
    End Sub

    Private Sub FillAvailableBU()

        Dim opExec As New connection
        Dim dt As New DataTable
        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select * from BusinessUNit order by Ordr asc")
        Try

            If reader.HasRows = True Then

                dt.Load(reader)

                '' lstBUAvailable.DataSource = dt
                '' lstBUAvailable.DisplayMember = "Label"
                '' lstBUAvailable.ValueMember = "ID"

                CheckedListBox1.DataSource = dt
                CheckedListBox1.DisplayMember = "Label"
                CheckedListBox1.ValueMember = "ID"

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Sub

    Private Sub ClearBU()

        For index As Integer = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(index, False)

        Next

    End Sub

    Private Sub FillGroupBU(ByVal grp As String)

        Dim opExec As New connection
        Dim dt As New DataTable

        ClearBU()

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader("select ID, GroupID, BU from GroupsBusinessUnit where GroupID = " & Integer.Parse(grp))
        Try

            If reader.HasRows = True Then

                While reader.Read
                    For index As Integer = 0 To CheckedListBox1.Items.Count - 1
                        Dim drv As DataRowView = CType(CheckedListBox1.Items(index), DataRowView)
                        Dim value As String = Convert.ToString(drv(CheckedListBox1.ValueMember))
                        If (value = reader("BU")) Then CheckedListBox1.SetItemChecked(index, True)
                    Next
                End While


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged

        If (cmbGroup.Text = "" Or cmbGroup.SelectedValue.Equals("System.Data.DataRowView")) Then
            Return

        Else
            Try
                FillGroupBU(cmbGroup.SelectedValue)
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If (cmbGroup.Text = "" Or cmbGroup.SelectedValue.Equals("System.Data.DataRowView")) Then
            Return
        End If

        Dim arrLst As New ArrayList

        For Each chk In CheckedListBox1.CheckedItems

            Dim drv As DataRowView = CType(chk, DataRowView)
            Dim value As String = Convert.ToString(drv(CheckedListBox1.ValueMember))

            arrLst.Add(value)

        Next


        Dim i As Integer

        If (arrLst.Count > 0) Then
            Dim opExec As New connection

            opExec.ExecuteSqlCommand("delete from GroupsBusinessUnit where GroupID=" & cmbGroup.SelectedValue)
            opExec.closeConnection()

            For i = 0 To arrLst.Count - 1
                opExec.ExecuteSqlCommand("insert into GroupsBusinessUnit(GroupID, BU) values (" & cmbGroup.SelectedValue & "," & arrLst(i) & ") ")
            Next
            opExec.closeConnection()

            MessageBox.Show("Business Unit updated for group " & cmbGroup.Text)

        End If


    End Sub
End Class