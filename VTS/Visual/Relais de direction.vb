Public Class Relais_de_direction

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label13.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label14.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label15.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label12.Text
        My.Forms.DefectPage.Label5.Text = Label16.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

 

    Private Sub btnPompeESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPompeESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Relais_de_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class