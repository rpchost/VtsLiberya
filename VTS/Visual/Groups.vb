Public Class Groups
    Private Sub Groups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100


        LoadGroups()


    End Sub

    Private Sub LoadGroups()
        Dim str As String
        Dim dtGroup As New Data.DataTable

        'Retrieving from inspectionactive join cardaftar table in order to retrieve the plateno in dropdown where escreated=1
        Dim conn As New connection
        str = "select * from groups"
        dtGroup = conn.ExecuteReaderdt(str)
        cmbGroup.DataSource = dtGroup
        cmbGroup.DisplayMember = "Label"
        cmbGroup.ValueMember = "ID"
    End Sub


    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        If (cmbGroup.Text <> "") Then
            txtGroup.Text = cmbGroup.Text
        Else
            txtGroup.Text = ""
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If (txtGroup.Text.Trim = "") Then Return

        Dim opExec As New connection
        opExec.ExecuteSqlCommand("update Groups set Label = '" & txtGroup.Text & "' where  ID = " & cmbGroup.SelectedValue)
        opExec.closeConnection()

        MessageBox.Show("Group updated successfully")
        LoadGroups()

    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtGroup.Text.Trim = "") Then Return

        Dim conn As New connection
        Dim Str As String = "select * from groups where Label='" & txtGroup.Text.Trim & "'"
        Dim dtGroup As DataTable = conn.ExecuteReaderdt(Str)
        If dtGroup.Rows.Count > 0 Then
            MessageBox.Show("Group already exist")
            Return
        End If


        Dim opExec As New connection
        opExec.ExecuteSqlCommand("insert into Groups(Label) values ('" & txtGroup.Text & "') ")
        opExec.closeConnection()
        MessageBox.Show("Group inserted successfully")
        LoadGroups()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtGroup.Text.Trim = "") Then Return


        If MsgBox("Are you sure you want to delete this group", vbQuestion Or vbYesNo Or vbDefaultButton2, "Confirm Vehicle Inspection") = vbYes Then
            Dim opExec As New connection
            opExec.ExecuteSqlCommand("delete from Groups where ID = " & cmbGroup.SelectedValue)
            opExec.closeConnection()
            MessageBox.Show("Group deleted successfully")
            LoadGroups()
        End If


    End Sub
End Class