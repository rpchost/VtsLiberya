Public Class Pompe_d_alimentation_en_carburant

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label8.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label14.Text
        My.Forms.DefectPage.Label5.Text = Label15.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label8.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label14.Text
        My.Forms.DefectPage.Label5.Text = Label16.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub btnPompeCarburantESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPompeCarburantESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Pompe_d_alimentation_en_carburant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class