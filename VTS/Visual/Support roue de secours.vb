Public Class Support_roue_de_secours

    Private Sub Support_roue_de_secours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label7.Text
        My.Forms.DefectPage.Label2.Text = Label9.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label13.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub



    Private Sub BtnStructuresESC_Click(sender As Object, e As EventArgs) Handles btnStructuresESC.Click
        Defects.Show()
        Me.Dispose()
    End Sub
End Class