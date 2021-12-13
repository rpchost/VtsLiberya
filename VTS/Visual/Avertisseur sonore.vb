Public Class Avertisseur_sonore

    Private Sub Avertisseur_sonore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label7.Text
        My.Forms.DefectPage.Label2.Text = Label9.Text
        My.Forms.DefectPage.Label4.Text = Label10.Text
        My.Forms.DefectPage.Label5.Text = Label11.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label7.Text
        My.Forms.DefectPage.Label2.Text = Label9.Text
        My.Forms.DefectPage.Label4.Text = Label10.Text
        My.Forms.DefectPage.Label5.Text = Label12.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub BtnAutreEqESC_Click(sender As Object, e As EventArgs) Handles btnAutreEqESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class