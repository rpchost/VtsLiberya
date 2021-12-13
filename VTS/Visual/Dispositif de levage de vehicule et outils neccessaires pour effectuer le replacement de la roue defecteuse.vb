Public Class Dispositif_de_levage_de_vehicule_et_outils_neccessaires_pour_effectuer_le_replacement_de_la_roue_defecteuse

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label13.Text
        My.Forms.DefectPage.Label5.Text = Label14.Text
        DefectPage.Show()
       Me.Dispose()

    End Sub


    Private Sub Dispositif_de_levage_de_vehicule_et_outils_neccessaires_pour_effectuer_le_replacement_de_la_roue_defecteuse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class