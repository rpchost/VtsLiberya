Public Class échappement

    Private Sub échappement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Collecteur_échappement.Label8.Text = Label8.Text
        My.Forms.Collecteur_échappement.Label11.Text = Label11.Text
        My.Forms.Collecteur_échappement.Label12.Text = Label12.Text
        Collecteur_échappement.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Canalisation_échappement.Label8.Text = Label8.Text
        My.Forms.Canalisation_échappement.Label11.Text = Label11.Text
        My.Forms.Canalisation_échappement.Label13.Text = Label13.Text
        Canalisation_échappement.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Silencieux_échappement.Label8.Text = Label8.Text
        My.Forms.Silencieux_échappement.Label11.Text = Label11.Text
        My.Forms.Silencieux_échappement.Label14.Text = Label14.Text
        Silencieux_échappement.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Pot_catalytique__Pour_les_vehicule_mis_en_marche_a_partir_de_25.Label8.Text = Label8.Text
        My.Forms.Pot_catalytique__Pour_les_vehicule_mis_en_marche_a_partir_de_25.Label11.Text = Label11.Text
        My.Forms.Pot_catalytique__Pour_les_vehicule_mis_en_marche_a_partir_de_25.Label15.Text = Label15.Text
        Pot_catalytique__Pour_les_vehicule_mis_en_marche_a_partir_de_25.Show()
        Me.Dispose()
    End Sub


    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class