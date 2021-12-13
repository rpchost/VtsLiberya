Public Class Tuyauterie_dassistance__de_freinage

    Private Sub Tuyauterie_dassistance__de_freinage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btnMauvaiseFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMauvaiseFix.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label5.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnDefaut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefaut.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label6.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub



    Private Sub btnFeuStop1ESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeuStop1ESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class