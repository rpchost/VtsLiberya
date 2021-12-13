Public Class CanalisationFreinPneumatique

    Private Sub CanalisationFreinPneumatique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        'lblInspectionNo.Text = Handler.InspNo
        'lblInspectorID.Text = Handler.InspectorID
        ' lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btnCorrosion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrosion.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label5.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub btnMauvaisPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMauvaisPos.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label6.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnMauvaisFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMauvaisFix.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label7.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnFuite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuite.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label8.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub




    Private Sub btnEscDirAssis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class