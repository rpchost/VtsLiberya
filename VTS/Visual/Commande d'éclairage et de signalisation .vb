Public Class Commande_d_éclairage_et_de_signalisation

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub Commande_d_éclairage_et_de_signalisation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btnCircuitHydESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuitHydESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class