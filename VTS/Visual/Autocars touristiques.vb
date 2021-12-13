Public Class Autocars_touristiques

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Autocars_touristiques1.Label1.Text = Label1.Text
        My.Forms.Autocars_touristiques1.Label10.Text = Label10.Text
        My.Forms.Autocars_touristiques1.Label13.Text = Label13.Text
        My.Forms.Autocars_touristiques1.Label14.Text = Label14.Text
        Autocars_touristiques1.Show()
        Me.Dispose()
    End Sub


    Private Sub BtnEscDirAssis_Click(sender As Object, e As EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Autocars_touristiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class