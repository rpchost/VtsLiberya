Public Class Circuit_Hydraulique




    Private Sub btnReservoir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservoir.Click
        'My.Forms.Réservoir_de_liquide_de_frein.Label1.Text = Label1.Text
        My.Forms.Réservoir_de_liquide_de_frein.Label2.Text = Label2.Text
        My.Forms.Réservoir_de_liquide_de_frein.Label3.Text = Label3.Text
        My.Forms.Réservoir_de_liquide_de_frein.Label4.Text = Label4.Text
        Réservoir_de_liquide_de_frein.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMaitreCylinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaitreCylinder.Click
        'My.Forms.Maitre_cylindre.Label1.Text = Label1.Text
        My.Forms.Maitre_cylindre.Label2.Text = Label2.Text
        My.Forms.Maitre_cylindre.Label3.Text = Label3.Text
        My.Forms.Maitre_cylindre.Label4.Text = Label5.Text
        Maitre_cylindre.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCanalisation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanalisation.Click
        ' My.Forms.Canalisation_de_frein.Label1.Text = Label1.Text
        My.Forms.Canalisation_de_frein.Label2.Text = Label2.Text
        My.Forms.Canalisation_de_frein.Label3.Text = Label3.Text
        My.Forms.Canalisation_de_frein.Label4.Text = Label6.Text
        Canalisation_de_frein.Show()
        Me.Dispose()
    End Sub

    Private Sub btnFlexibleFrein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlexibleFrein.Click
        '' My.Forms.Flexible_de_frein.Label1.Text = Label1.Text
        My.Forms.Flexible_de_frein.Label2.Text = Label2.Text
        My.Forms.Flexible_de_frein.Label3.Text = Label3.Text
        My.Forms.Flexible_de_frein.Label4.Text = Label7.Text
        Flexible_de_frein.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCorrecteur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrecteur.Click
        'My.Forms.Correcteur__repartiteur_de_freinage.Label1.Text = Label1.Text
        My.Forms.Correcteur__repartiteur_de_freinage.Label2.Text = Label2.Text
        My.Forms.Correcteur__repartiteur_de_freinage.Label3.Text = Label3.Text
        My.Forms.Correcteur__repartiteur_de_freinage.Label4.Text = Label8.Text
        Correcteur__repartiteur_de_freinage.Show()
        Me.Dispose()
    End Sub


    Private Sub btnCircuitHydESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircuitHydESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Circuit_Hydraulique_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class