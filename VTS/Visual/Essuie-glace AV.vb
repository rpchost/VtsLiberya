Public Class Essuie_glace_AV

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label6.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label10.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label6.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label9.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label6.Text
        My.Forms.DefectPage.Label4.Text = Label7.Text
        My.Forms.DefectPage.Label5.Text = Label8.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

 

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Essuie_glace_AV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class