Public Class Eléments_de_commande

 
    Private Sub btnPedaleFrein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedaleFrein.Click

        My.Forms.Pédale_du_frein_de_service.Label2.Text = Label2.Text
        My.Forms.Pédale_du_frein_de_service.Label3.Text = Label3.Text
        My.Forms.Pédale_du_frein_de_service.Label4.Text = Label4.Text

        Pédale_du_frein_de_service.Show()
        Me.Dispose()
    End Sub


    Private Sub btnCommande_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommande.Click

        My.Forms.Commande_du_frein_de_stationnement.Label2.Text = Label2.Text
        My.Forms.Commande_du_frein_de_stationnement.Label3.Text = Label3.Text
        My.Forms.Commande_du_frein_de_stationnement.Label4.Text = Label5.Text

        Commande_du_frein_de_stationnement.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCableTringlerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCableTringlerie.Click

        My.Forms.Cable__tringlerie_du_frein_de_stationnement.Label2.Text = Label2.Text
        My.Forms.Cable__tringlerie_du_frein_de_stationnement.Label3.Text = Label3.Text
        My.Forms.Cable__tringlerie_du_frein_de_stationnement.Label4.Text = Label6.Text

        Cable__tringlerie_du_frein_de_stationnement.Show()
        Me.Dispose()
    End Sub



    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Eléments_de_commande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class