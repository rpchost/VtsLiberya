Public Class Pollution__Niveau_sonore__Spécial

    Private Sub Pollution__Niveau_sonore__Spécial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Mesures_pollution.Label9.Text = Label9.Text
        My.Forms.Mesures_pollution.Label10.Text = Label10.Text
        Mesures_pollution.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Niveau_sonore.Label9.Text = Label9.Text
        My.Forms.Niveau_sonore.Label11.Text = Label11.Text
        Niveau_sonore.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.éléments_information.Label9.Text = Label9.Text
        My.Forms.éléments_information.Label12.Text = Label12.Text
        éléments_information.Show()
        Me.Dispose()

    End Sub


    Private Sub btnPollutionSonoreESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPollutionSonoreESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class