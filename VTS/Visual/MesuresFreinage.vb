Public Class MesuresFreinage

   

    Private Sub MesuresFreinage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub



    Private Sub btnFreinStationnement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinStationnement.Click

        My.Forms.FreinStationnement.Label2.Text = Label2.Text
        My.Forms.FreinStationnement.Label3.Text = Label6.Text
        My.Forms.FreinStationnement.Label4.Text = Label4.Text
        FreinStationnement.Show()
        Me.Dispose()
    End Sub


    Private Sub btnFreinService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinService.Click

        My.Forms.FreinDeService.Label2.Text = Label2.Text
        My.Forms.FreinDeService.Label5.Text = Label6.Text
        My.Forms.FreinDeService.Label6.Text = Label3.Text
        FreinDeService.Show()
        Me.Dispose()
    End Sub



    Private Sub btnFreinSecours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinSecours.Click

        My.Forms.Frein_de_secours.Label2.Text = Label2.Text
        My.Forms.Frein_de_secours.Label3.Text = Label6.Text
        My.Forms.Frein_de_secours.Label4.Text = Label5.Text
        Frein_de_secours.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMesureFRESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesureFRESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class