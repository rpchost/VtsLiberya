Public Class Teneur_en_CO_des_gaz_echappement

    Private Sub Teneur_en_CO_des_gaz_echappement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label9.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label11.Text
        My.Forms.DefectPage.Label5.Text = Label12.Text
        DefectPage.Show()
       Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label9.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label11.Text
        My.Forms.DefectPage.Label5.Text = Label14.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label9.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label11.Text
        My.Forms.DefectPage.Label5.Text = Label12.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label9.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label11.Text
        My.Forms.DefectPage.Label5.Text = Label13.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


 

    Private Sub btnTemoinESCAllum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemoinESCAllum.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class