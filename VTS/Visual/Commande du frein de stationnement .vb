Public Class Commande_du_frein_de_stationnement

 
 
    Private Sub btnMauvaisFonction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMauvaisFonction.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label5.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnVerouillage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerouillage.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label6.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnFixation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFixation.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label7.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourse.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label8.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnAbsence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbsence.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label9.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub btnCircuitHydESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuitHydESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Commande_du_frein_de_stationnement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
    End Sub
End Class