Public Class Mesures_pollution


    Private Sub Mesures_pollution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Teneur_en_CO_des_gaz_echappement.Label9.Text = Label9.Text
        My.Forms.Teneur_en_CO_des_gaz_echappement.Label10.Text = Label10.Text
        My.Forms.Teneur_en_CO_des_gaz_echappement.Label11.Text = Label11.Text
        Teneur_en_CO_des_gaz_echappement.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Opacité_des_fumées_echappement.Label9.Text = Label9.Text
        My.Forms.Opacité_des_fumées_echappement.Label10.Text = Label10.Text
        My.Forms.Opacité_des_fumées_echappement.Label12.Text = Label12.Text
        Opacité_des_fumées_echappement.Show()
        Me.Dispose()

    End Sub


    Private Sub btnMesureFRESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesureFRESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class