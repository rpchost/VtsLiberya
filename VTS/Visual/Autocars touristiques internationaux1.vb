Public Class Autocars_touristiques_internationaux1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label16.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label17.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label18.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label19.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label20.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label21.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label22.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label23.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label24.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label10.Text
        My.Forms.DefectPage.Label2.Text = Label14.Text
        My.Forms.DefectPage.Label4.Text = Label15.Text
        My.Forms.DefectPage.Label5.Text = Label25.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub


    Private Sub BtnEscDirAssis_Click(sender As Object, e As EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Autocars_touristiques_internationaux1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class