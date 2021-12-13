Public Class circuit_pneumatiques


    Private Sub circuit_pneumatiques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btnReservoir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservoir.Click
        ' My.Forms.Réservoir_dair_de_frein.Label1.Text = Label1.Text
        My.Forms.Réservoir_dair_de_frein.Label2.Text = Label2.Text
        My.Forms.Réservoir_dair_de_frein.Label3.Text = Label3.Text
        My.Forms.Réservoir_dair_de_frein.Label4.Text = Label4.Text

        Réservoir_dair_de_frein.Show()
       Me.Dispose()
    End Sub

  
    Private Sub btnCanalisation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanalisation.Click
        'My.Forms.CanalisationFreinPneumatique.Label1.Text = Label1.Text
        My.Forms.CanalisationFreinPneumatique.Label2.Text = Label2.Text
        My.Forms.CanalisationFreinPneumatique.Label3.Text = Label3.Text
        My.Forms.CanalisationFreinPneumatique.Label4.Text = Label5.Text

        CanalisationFreinPneumatique.Show()
       Me.Dispose()
    End Sub

  
    Private Sub btnTringlerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTringlerie.Click
        'My.Forms.Tringlerie_de_commande_des_freins.Label1.Text = Label1.Text
        My.Forms.Tringlerie_de_commande_des_freins.Label2.Text = Label2.Text
        My.Forms.Tringlerie_de_commande_des_freins.Label3.Text = Label3.Text
        My.Forms.Tringlerie_de_commande_des_freins.Label4.Text = Label6.Text

        Tringlerie_de_commande_des_freins.Show()
       Me.Dispose()
    End Sub

    Private Sub btnVannes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVannes.Click
        '  My.Forms.Vannes_du_circuit_de_freinage.Label1.Text = Label1.Text
        My.Forms.Vannes_du_circuit_de_freinage.Label2.Text = Label2.Text
        My.Forms.Vannes_du_circuit_de_freinage.Label3.Text = Label3.Text
        My.Forms.Vannes_du_circuit_de_freinage.Label4.Text = Label7.Text

        Vannes_du_circuit_de_freinage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnCompresseur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompresseur.Click
        ' My.Forms.Compresseur_dair.Label1.Text = Label1.Text
        My.Forms.Compresseur_dair.Label2.Text = Label2.Text
        My.Forms.Compresseur_dair.Label3.Text = Label3.Text
        My.Forms.Compresseur_dair.Label4.Text = Label8.Text

        Compresseur_dair.Show()
       Me.Dispose()
    End Sub

    Private Sub btnMano_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMano.Click
        '   My.Forms.ManometreOuTemoinsPression.Label1.Text = Label1.Text
        My.Forms.ManometreOuTemoinsPression.Label2.Text = Label2.Text
        My.Forms.ManometreOuTemoinsPression.Label3.Text = Label3.Text
        My.Forms.ManometreOuTemoinsPression.Label4.Text = Label9.Text

        ManometreOuTemoinsPression.Show()
       Me.Dispose()
    End Sub

  

    Private Sub btnCircuitHydESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuitHydESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class