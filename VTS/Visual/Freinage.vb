Public Class Freinage

  
    Private Sub Freinage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub


    Private Sub btnMesures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesures.Click
        ' My.Forms.MesuresFreinage.Label1.Text = lblFRCar.Text
        My.Forms.MesuresFreinage.Label2.Text = Label2.Text
        My.Forms.MesuresFreinage.Label6.Text = Label3.Text
        MesuresFreinage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnCircuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuit.Click
        'My.Forms.Circuit_Hydraulique.Label1.Text = lblFRCar.Text
        My.Forms.Circuit_Hydraulique.Label2.Text = Label2.Text
        My.Forms.Circuit_Hydraulique.Label3.Text = Label4.Text
        Circuit_Hydraulique.Show()
       Me.Dispose()
    End Sub

    Private Sub btnElement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElement.Click
        'My.Forms.Eléments_de_commande.Label1.Text = lblFRCar.Text
        My.Forms.Eléments_de_commande.Label2.Text = Label2.Text
        My.Forms.Eléments_de_commande.Label3.Text = Label5.Text
        Eléments_de_commande.Show()
       Me.Dispose()
    End Sub

    Private Sub btnElemRecept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElemRecept.Click
        ' My.Forms.Eléments_de_récepteurs.Label1.Text = lblFRCar.Text
        My.Forms.Eléments_de_récepteurs.Label2.Text = Label2.Text
        My.Forms.Eléments_de_récepteurs.Label3.Text = Label6.Text
        Eléments_de_récepteurs.Show()
       Me.Dispose()
    End Sub

    Private Sub btnAssistFrein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssistFrein.Click
        'My.Forms.Assistance_de_Freinage.Label1.Text = lblFRCar.Text
        My.Forms.Assistance_de_Freinage.Label2.Text = Label2.Text
        My.Forms.Assistance_de_Freinage.Label3.Text = Label7.Text
        Assistance_de_Freinage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnSystemAnti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystemAnti.Click
        '  My.Forms.Systemes_antiblocage.Label1.Text = lblFRCar.Text
        My.Forms.Systemes_antiblocage.Label2.Text = Label2.Text
        My.Forms.Systemes_antiblocage.Label3.Text = Label8.Text
        Systemes_antiblocage.Show()
       Me.Dispose()

    End Sub

    Private Sub btnCircuitPneu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuitPneu.Click
        ' My.Forms.circuit_pneumatiques.Label1.Text = lblFRCar.Text
        My.Forms.circuit_pneumatiques.Label2.Text = Label2.Text
        My.Forms.circuit_pneumatiques.Label3.Text = Label9.Text
        circuit_pneumatiques.Show()
       Me.Dispose()
    End Sub


    Private Sub btnFRESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFRESC.Click

        ' My.Forms.Defects.lblPlate.Text = lblFRCar.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class