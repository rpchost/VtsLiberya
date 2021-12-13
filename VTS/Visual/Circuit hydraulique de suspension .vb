Public Class Circuit_hydraulique_de_suspension

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label19.Text
        My.Forms.DefectPage.Label5.Text = Label20.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label19.Text
        My.Forms.DefectPage.Label5.Text = Label21.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label19.Text
        My.Forms.DefectPage.Label5.Text = Label22.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label19.Text
        My.Forms.DefectPage.Label5.Text = Label23.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub btnCarosserieESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarosserieESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Circuit_hydraulique_de_suspension_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class