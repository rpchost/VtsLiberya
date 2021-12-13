Public Class Circuit_pneumatique_de_suspension

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label21.Text
        My.Forms.DefectPage.Label5.Text = Label22.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

 

    Private Sub btnCircuitHydESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuitHydESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Circuit_pneumatique_de_suspension_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100


        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class