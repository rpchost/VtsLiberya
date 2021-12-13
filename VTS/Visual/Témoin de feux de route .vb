Public Class Témoin_de_feux_de_route



    Private Sub Témoin_de_feux_de_route_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label5.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub btnTemoinAllumeESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemoinAllumeESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class