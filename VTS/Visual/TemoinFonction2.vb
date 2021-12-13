Public Class TemoinFonction2


    Private Sub btnTemoinfct2Esc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemoinfct2Esc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub TemoinFonction2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class