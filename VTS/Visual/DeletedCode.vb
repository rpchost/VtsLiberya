Public Class DeletedCode
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable
    Private Sub DeletedCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        header.Width = Me.Width
        header.Height = 100

        Try
            sql = "select * from DeletedCodes  where plateNO='" & Label1.Text & "'"
            dt = conn.ExecuteReaderdt(sql)
            lblUser.Text = ""
            lblDeleted.Text = ""
            For i = 0 To dt.Rows.Count - 1
                lblUser.Text = lblUser.Text & dt.Rows(i).Item("inspector") & Environment.NewLine
                lblDeleted.Text = lblDeleted.Text & dt.Rows(i).Item("DeletedCode") & Environment.NewLine
            Next



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnDeleteCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCode.Click

        'My.Forms.Vehicles.btnVisual.Enabled = True
        'My.Forms.Vehicles.btnReview.Enabled = True
        'My.Forms.Vehicles.btnStore.Enabled = True
        ''My.Forms.Vehicles.btnSelect.Enabled = False
        'My.Forms.Vehicles.btnDeleted.Enabled = True

        Vehicles.Show()
        Me.Dispose()
    End Sub


    Private Sub btnLogoutDCODE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogoutDCODE.Click
        My.Forms.SYSTEMLOGIN.Show()
        My.Forms.SYSTEMLOGIN.txtUser.ResetText()
        My.Forms.SYSTEMLOGIN.txtPwd.ResetText()
        My.Forms.SYSTEMLOGIN.txtUser.Focus()
        My.Forms.SYSTEMLOGIN.lblmsg.ResetText()
        Label1.ResetText()
        Me.Dispose()
    End Sub
End Class