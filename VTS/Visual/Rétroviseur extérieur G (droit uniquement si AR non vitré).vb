Public Class Rétroviseur_extérieur_G__droit_uniquement_si_AR_non_vitré_

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label8.Text
        DefectPage.Show()
       Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label9.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label5.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label10.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

 

    Private Sub btnResCarESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResCarESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Rétroviseur_extérieur_G__droit_uniquement_si_AR_non_vitré__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class