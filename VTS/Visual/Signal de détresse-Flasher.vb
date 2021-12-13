Public Class Signal_de_détresse_Flasher

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label11.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label12.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub btnDetFlashEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetFlashEsc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Signal_de_détresse_Flasher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class