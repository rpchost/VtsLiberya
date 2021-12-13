Public Class Autres_équipement

    Private Sub Autres_équipement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' My.Forms.Avertisseur_sonore.Label1.Text = Label1.Text
        My.Forms.Avertisseur_sonore.Label7.Text = Label7.Text
        My.Forms.Avertisseur_sonore.Label9.Text = Label9.Text
        My.Forms.Avertisseur_sonore.Label10.Text = Label10.Text
        Avertisseur_sonore.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ' My.Forms.Batterie.Label1.Text = Label1.Text
        My.Forms.Batterie.Label7.Text = Label7.Text
        My.Forms.Batterie.Label9.Text = Label9.Text
        My.Forms.Batterie.Label11.Text = Label11.Text
        Batterie.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'My.Forms.Support_roue_de_secours.Label1.Text = Label1.Text
        My.Forms.Support_roue_de_secours.Label7.Text = Label7.Text
        My.Forms.Support_roue_de_secours.Label9.Text = Label9.Text
        My.Forms.Support_roue_de_secours.Label12.Text = Label12.Text
        Support_roue_de_secours.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'My.Forms.Dispositif_d_attelage.Label1.Text = Label1.Text
        My.Forms.Dispositif_d_attelage.Label7.Text = Label7.Text
        My.Forms.Dispositif_d_attelage.Label9.Text = Label9.Text
        My.Forms.Dispositif_d_attelage.Label13.Text = Label13.Text
        Dispositif_d_attelage.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'My.Forms.Extincteur.Label1.Text = Label1.Text
        My.Forms.Extincteur.Label7.Text = Label7.Text
        My.Forms.Extincteur.Label9.Text = Label9.Text
        My.Forms.Extincteur.Label14.Text = Label14.Text
        Extincteur.Show()
        Me.Dispose()
    End Sub


    Private Sub btnAutreEqESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutreEqESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class