Public Class Niveau_sonore

    Private Sub Niveau_sonore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Bruit_moteur.Label9.Text = Label9.Text
        My.Forms.Bruit_moteur.Label11.Text = Label11.Text
        My.Forms.Bruit_moteur.Label12.Text = Label12.Text
        Bruit_moteur.Show()
        Me.Dispose()

    End Sub



    Private Sub btnMesureFRESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesureFRESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class