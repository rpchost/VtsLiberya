Public Class Mesures





    Private Sub btnFeuCroisement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeuCroisement.Click
        'My.Forms.FeuCroisementdeclairage.Label1.Text = Label1.Text
        'My.Forms.FeuCroisementdeclairage.Label2.Text = Label2.Text
        'My.Forms.FeuCroisementdeclairage.Label3.Text = Label3.Text
        'My.Forms.FeuCroisementdeclairage.Label4.Text = Label6.Text

        'FeuCroisementdeclairage.Show()
        'Me.Hide()
    End Sub


    Private Sub btnMesures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesures.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Mesures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100


        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class