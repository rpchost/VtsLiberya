Public Class Roue_de_secours

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label13.Text
        DefectPage.Show()
       Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label14.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

  

    Private Sub btnMeasureEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeasureEsc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Roue_de_secours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
    End Sub
End Class