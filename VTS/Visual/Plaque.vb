Public Class Plaque

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        header.Width = Me.Width
        header.Height = 100

        My.Forms.PlaqueCode.Label2.Text = Label2.Text
        My.Forms.PlaqueCode.Label3.Text = Label3.Text
        My.Forms.PlaqueCode.Label4.Text = Label4.Text
        PlaqueCode.Show()
        Me.Dispose()


        'Dim frm As New PlaqueCode()
        'frm.Show()
        'Me.Hide()
    End Sub



    Private Sub btnOrganesESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganesESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Plaque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class