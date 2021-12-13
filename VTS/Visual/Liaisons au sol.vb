Public Class Liaisons_au_sol

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.MesuresLiaisons.Label5.Text = Label5.Text
        My.Forms.MesuresLiaisons.Label6.Text = Label6.Text
        MesuresLiaisons.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Trains.Label5.Text = Label5.Text
        My.Forms.Trains.Label7.Text = Label7.Text
        Trains.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Roues.Label5.Text = Label5.Text
        My.Forms.Roues.Label8.Text = Label8.Text
        Roues.Show()
        Me.Dispose()
    End Sub


    Private Sub btnLiaisonSolESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiaisonSolESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Liaisons_au_sol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class