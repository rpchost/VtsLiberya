Public Class Témoin_de_dispositif_OBD

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label9.Text
        My.Forms.DefectPage.Label2.Text = Label12.Text
        My.Forms.DefectPage.Label4.Text = Label13.Text
        My.Forms.DefectPage.Label5.Text = Label14.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub btnTemoinAllumeESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemoinAllumeESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Témoin_de_dispositif_OBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class