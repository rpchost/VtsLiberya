Public Class Caisse

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label16.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label17.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label18.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label19.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label20.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label6.Text
        My.Forms.DefectPage.Label2.Text = Label8.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label21.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Caisse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btnEscDirAssis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class