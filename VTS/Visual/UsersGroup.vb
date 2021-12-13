Public Class UsersGroup
    Private Sub UsersGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = My.Computer.Screen.WorkingArea.Size.Width - 50
        Me.Height = My.Computer.Screen.WorkingArea.Size.Height - 50
        Me.Top = My.Computer.Screen.WorkingArea.Top + 20
        Me.Left = My.Computer.Screen.WorkingArea.Left + 20
        header.Width = My.Computer.Screen.WorkingArea.Size.Width
        header.Height = 100

        Dim str As String
        Dim dtGroup As New Data.DataTable
        Dim dtUsers As New Data.DataTable

        'Retrieving from inspectionactive join cardaftar table in order to retrieve the plateno in dropdown where escreated=1
        Dim conn As New connection
        str = "select * from groups"
        dtGroup = conn.ExecuteReaderdt(str)
        lstGroups.DataSource = dtGroup
        lstGroups.DisplayMember = "Label"
        lstGroups.ValueMember = "ID"

        str = "select * from Users"
        dtUSers = conn.ExecuteReaderdt(str)
        lstUsers.DataSource = dtUsers
        lstUsers.DisplayMember = "Name"
        lstUsers.ValueMember = "ID"


    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Dispose()
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged

        If (lstUsers.SelectedValue.ToString.Equals("System.Data.DataRowView")) Then
            Return
        End If


        Dim opExec As New connection
        Dim sql As String = ""
        sql = "select Group_FK from Users where ID = " & lstUsers.SelectedValue.ToString


        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()

                lstGroups.SelectedValue = reader("Group_FK")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim opExec As New connection
        opExec.ExecuteSqlCommand("update Users set Group_FK = " & lstGroups.SelectedValue & " where  ID = " & lstUsers.SelectedValue)
        opExec.closeConnection()

        MessageBox.Show("User's group updated successfully")
    End Sub
End Class