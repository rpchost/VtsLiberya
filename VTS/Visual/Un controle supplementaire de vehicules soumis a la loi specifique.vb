Public Class Un_controle_supplementaire_de_vehicules_soumis_a_la_loi_specifique

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Poids_lourds.Label1.Text = Label1.Text
        My.Forms.Poids_lourds.Label10.Text = Label10.Text
        My.Forms.Poids_lourds.Label11.Text = Label11.Text
        Poids_lourds.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Poids_lourds_internationaux.Label1.Text = Label1.Text
        My.Forms.Poids_lourds_internationaux.Label10.Text = Label10.Text
        My.Forms.Poids_lourds_internationaux.Label12.Text = Label12.Text
        Poids_lourds_internationaux.Show()
       Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' My.Forms.Autocars_touristiques.Label1.Text = Label1.Text
        My.Forms.Autocars_touristiques.Label10.Text = Label10.Text
        My.Forms.Autocars_touristiques.Label13.Text = Label13.Text
        Autocars_touristiques.Show()
       Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.Autocars_touristiques_internationaux.Label1.Text = Label1.Text
        My.Forms.Autocars_touristiques_internationaux.Label10.Text = Label10.Text
        My.Forms.Autocars_touristiques_internationaux.Label14.Text = Label14.Text
        Autocars_touristiques_internationaux.Show()
       Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.Taxipage.Label1.Text = Label1.Text
        My.Forms.Taxipage.Label10.Text = Label10.Text
        My.Forms.Taxipage.Label15.Text = Label15.Text
        Taxipage.Show()
       Me.Dispose()

    End Sub

    Private Sub btnContSuppEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContSuppEsc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Un_controle_supplementaire_de_vehicules_soumis_a_la_loi_specifique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class