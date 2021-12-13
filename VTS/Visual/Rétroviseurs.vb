Public Class Rétroviseurs

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Rétroviseur_intérieur.Label3.Text = Label3.Text
        My.Forms.Rétroviseur_intérieur.Label5.Text = Label5.Text
        My.Forms.Rétroviseur_intérieur.Label6.Text = Label6.Text
        Rétroviseur_intérieur.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Rétroviseur_extérieur_G__droit_uniquement_si_AR_non_vitré_.Label3.Text = Label3.Text
        My.Forms.Rétroviseur_extérieur_G__droit_uniquement_si_AR_non_vitré_.Label5.Text = Label5.Text
        My.Forms.Rétroviseur_extérieur_G__droit_uniquement_si_AR_non_vitré_.Label7.Text = Label7.Text
        Rétroviseur_extérieur_G__droit_uniquement_si_AR_non_vitré_.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Commande_de_Rétroviseur_extérieur.Label3.Text = Label3.Text
        My.Forms.Commande_de_Rétroviseur_extérieur.Label5.Text = Label5.Text
        My.Forms.Commande_de_Rétroviseur_extérieur.Label8.Text = Label8.Text
        Commande_de_Rétroviseur_extérieur.Show()
        Me.Dispose()
    End Sub



    Private Sub btnEscRetro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscRetro.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Rétroviseurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class