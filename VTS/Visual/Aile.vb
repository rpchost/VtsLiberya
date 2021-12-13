Public Class Aile

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label13.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label14.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label15.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label16.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub



    Private Sub btnESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub btnESC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnESC.KeyDown
        If e.KeyCode = Keys.Escape Then
            'My.Forms.Defects.lblCarDefect.Text = Label1.Text
            Defects.Show()
           Me.Dispose()
        End If
    End Sub

    Private Sub Aile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class