Public Class Pot_catalytique__Pour_les_vehicule_mis_en_marche_a_partir_de_25

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label8.Text
        My.Forms.DefectPage.Label2.Text = Label11.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label16.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub btnPompeESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPompeESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Pot_catalytique__Pour_les_vehicule_mis_en_marche_a_partir_de_25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class