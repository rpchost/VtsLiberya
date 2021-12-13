Public Class MesureDirection

    Private Sub MesureDirection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Angle__ripage.Label2.Text = Label2.Text
        My.Forms.Angle__ripage.Label3.Text = Label3.Text
        My.Forms.Angle__ripage.Label4.Text = Label4.Text

        Angle__ripage.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMesureDirESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesureDirESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class