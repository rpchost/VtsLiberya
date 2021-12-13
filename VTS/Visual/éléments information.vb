Public Class éléments_information

    Private Sub éléments_information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Témoin_de_dispositif_OBD.Label9.Text = Label9.Text
        My.Forms.Témoin_de_dispositif_OBD.Label12.Text = Label12.Text
        My.Forms.Témoin_de_dispositif_OBD.Label13.Text = Label13.Text
        Témoin_de_dispositif_OBD.Show()
        Me.Dispose()
    End Sub


    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class