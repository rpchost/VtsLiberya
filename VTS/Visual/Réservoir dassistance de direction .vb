Public Class Réservoir_dassistance_de_direction

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label8.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label9.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label10.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label11.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub



    Private Sub btnPompeESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPompeESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Réservoir_dassistance_de_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
    End Sub
End Class