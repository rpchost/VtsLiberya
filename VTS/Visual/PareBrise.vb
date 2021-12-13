Public Class PareBrise

    Private Sub PareBrise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label5.Text
        My.Forms.DefectPage.Label5.Text = Label6.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label5.Text
        My.Forms.DefectPage.Label5.Text = Label7.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label5.Text
        My.Forms.DefectPage.Label5.Text = Label8.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label3.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label5.Text
        My.Forms.DefectPage.Label5.Text = Label9.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

  

    Private Sub btnOrganesESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganesESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class