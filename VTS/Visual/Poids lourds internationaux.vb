Public Class Poids_lourds_internationaux

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Poids_lourds_internationaux1.Label10.Text = Label10.Text
        My.Forms.Poids_lourds_internationaux1.Label12.Text = Label12.Text
        My.Forms.Poids_lourds_internationaux1.Label13.Text = Label13.Text
        Poids_lourds_internationaux1.Show()
        Me.Dispose()
    End Sub



    Private Sub btnOrganesESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganesESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Poids_lourds_internationaux_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class