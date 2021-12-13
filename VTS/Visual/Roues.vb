Public Class Roues

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Roue.Label1.Text = Label1.Text
        My.Forms.Roue.Label5.Text = Label5.Text
        My.Forms.Roue.Label8.Text = Label8.Text
        My.Forms.Roue.Label9.Text = Label9.Text
        Roue.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Jante.Label5.Text = Label5.Text
        My.Forms.Jante.Label8.Text = Label8.Text
        My.Forms.Jante.Label10.Text = Label10.Text
        Jante.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Pneumatique.Label5.Text = Label5.Text
        My.Forms.Pneumatique.Label8.Text = Label8.Text
        My.Forms.Pneumatique.Label11.Text = Label11.Text
        Pneumatique.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Roue_de_secours.Label5.Text = Label5.Text
        My.Forms.Roue_de_secours.Label8.Text = Label8.Text
        My.Forms.Roue_de_secours.Label12.Text = Label12.Text
        Roue_de_secours.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Forms.Dispositif_de_levage_de_vehicule_et_outils_neccessaires_pour_effectuer_le_replacement_de_la_roue_defecteuse.Label5.Text = Label5.Text
        My.Forms.Dispositif_de_levage_de_vehicule_et_outils_neccessaires_pour_effectuer_le_replacement_de_la_roue_defecteuse.Label8.Text = Label8.Text
        My.Forms.Dispositif_de_levage_de_vehicule_et_outils_neccessaires_pour_effectuer_le_replacement_de_la_roue_defecteuse.Label13.Text = Label13.Text
        Dispositif_de_levage_de_vehicule_et_outils_neccessaires_pour_effectuer_le_replacement_de_la_roue_defecteuse.Show()
        Me.Dispose()
    End Sub


    Private Sub btnRouesESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRouesESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Roues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class