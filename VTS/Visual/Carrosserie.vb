Public Class Carrosserie

    Private Sub Carrosserie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Porte_latérale.Label1.Text = Label1.Text
        My.Forms.Porte_latérale.Label6.Text = Label6.Text
        My.Forms.Porte_latérale.Label8.Text = Label8.Text
        My.Forms.Porte_latérale.Label9.Text = Label9.Text
        Porte_latérale.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Porte_AR__hayon.Label1.Text = Label1.Text
        My.Forms.Porte_AR__hayon.Label6.Text = Label6.Text
        My.Forms.Porte_AR__hayon.Label8.Text = Label8.Text
        My.Forms.Porte_AR__hayon.Label10.Text = Label10.Text
        Porte_AR__hayon.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.Capot.Label1.Text = Label1.Text
        My.Forms.Capot.Label6.Text = Label6.Text
        My.Forms.Capot.Label8.Text = Label8.Text
        My.Forms.Capot.Label11.Text = Label11.Text
        Capot.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ''My.Forms.Aile.Label1.Text = Label1.Text
        My.Forms.Aile.Label6.Text = Label6.Text
        My.Forms.Aile.Label8.Text = Label8.Text
        My.Forms.Aile.Label12.Text = Label12.Text
        Aile.Show()
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.Pare_chocs__bouclier.Label1.Text = Label1.Text
        My.Forms.Pare_chocs__bouclier.Label6.Text = Label6.Text
        My.Forms.Pare_chocs__bouclier.Label8.Text = Label8.Text
        My.Forms.Pare_chocs__bouclier.Label13.Text = Label13.Text
        Pare_chocs__bouclier.Show()
        Me.Dispose()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' My.Forms.Pieds_montant.Label1.Text = Label1.Text
        My.Forms.Pieds_montant.Label6.Text = Label6.Text
        My.Forms.Pieds_montant.Label8.Text = Label8.Text
        My.Forms.Pieds_montant.Label14.Text = Label14.Text
        Pieds_montant.Show()
        Me.Dispose()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'My.Forms.Caisse.Label1.Text = Label1.Text
        My.Forms.Caisse.Label6.Text = Label6.Text
        My.Forms.Caisse.Label8.Text = Label8.Text
        My.Forms.Caisse.Label15.Text = Label15.Text
        Caisse.Show()
        Me.Dispose()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'My.Forms.Bas_de_caisse_amovible.Label1.Text = Label1.Text
        My.Forms.Bas_de_caisse_amovible.Label6.Text = Label6.Text
        My.Forms.Bas_de_caisse_amovible.Label8.Text = Label8.Text
        My.Forms.Bas_de_caisse_amovible.Label16.Text = Label16.Text
        Bas_de_caisse_amovible.Show()
        Me.Dispose()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'My.Forms.Éléments_de_carrosserie_inamovible.Label1.Text = Label1.Text
        My.Forms.Éléments_de_carrosserie_inamovible.Label6.Text = Label6.Text
        My.Forms.Éléments_de_carrosserie_inamovible.Label8.Text = Label8.Text
        My.Forms.Éléments_de_carrosserie_inamovible.Label17.Text = Label17.Text
        Éléments_de_carrosserie_inamovible.Show()
        Me.Dispose()

    End Sub




    Private Sub btnCarosserieESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarosserieESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class