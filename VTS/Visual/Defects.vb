Public Class Defects
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable

    Private Sub Defects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

        lblGroup.Text = Handler.GroupName
        lblLane.Text = IIf(Handler.Lane <> "", "Lane : " & Handler.Lane, "")
        lblSection.Text = IIf(Handler.Section <> "", "Section : " & Handler.Section, "")

    End Sub

    Private Sub btnFreinage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinage.Click
        'My.Forms.Freinage.lblFRCar.Text = lblPlate.Text
        My.Forms.Freinage.Label2.Text = Label5.Text

        Freinage.Show()
        Me.Dispose()
    End Sub

    Private Sub btnVehicule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehicule.Click
        'My.Forms.Identification.lblIdentCar.Text = lblPlate.Text
        My.Forms.Identification.Label3.Text = Label3.Text
        Identification.Show()
        Me.Dispose()
    End Sub

    Private Sub btnDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirection.Click
        ' My.Forms.Direction.Label1.Text = lblCarDefect.Text
        My.Forms.Direction.Label2.Text = Label6.Text
        Direction.Show()
        Me.Dispose()
    End Sub

    Private Sub btnVisibilte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisibilte.Click
        'My.Forms.Visibilite.Label1.Text = lblCarDefect.Text
        My.Forms.Visibilite.Label3.Text = Label7.Text
        Visibilite.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEclairage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEclairage.Click
        'My.Forms.Eclairage.Label1.Text = lblCarDefect.Text
        My.Forms.Eclairage.Label2.Text = Label4.Text
        Eclairage.Show()
        Me.Dispose()
    End Sub

    Private Sub btnLiaisons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiaisons.Click
        'My.Forms.Liaisons_au_sol.Label1.Text = lblCarDefect.Text
        My.Forms.Liaisons_au_sol.Label5.Text = Label8.Text
        Liaisons_au_sol.Show()
        Me.Dispose()
    End Sub

    Private Sub btnStructure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructure.Click
        ' My.Forms.Structure_carrosserie.Label1.Text = lblCarDefect.Text
        My.Forms.Structure_carrosserie.Label6.Text = Label9.Text
        Structure_carrosserie.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEquipements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipements.Click
        'My.Forms.Equipements.Label1.Text = lblCarDefect.Text
        My.Forms.Equipements.Label7.Text = Label10.Text
        Equipements.Show()
        Me.Dispose()
    End Sub

    Private Sub btnOrganes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganes.Click
        'My.Forms.Organes_Mécaniques.Label1.Text = lblCarDefect.Text
        My.Forms.Organes_Mécaniques.Label8.Text = Label11.Text
        Organes_Mécaniques.Show()
        Me.Dispose()
    End Sub

    Private Sub btnPollution_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPollution.Click
        ' My.Forms.Pollution__Niveau_sonore__Spécial.Label1.Text = lblCarDefect.Text
        My.Forms.Pollution__Niveau_sonore__Spécial.Label9.Text = Label12.Text
        Pollution__Niveau_sonore__Spécial.Show()
        Me.Dispose()
    End Sub


    Private Sub btnControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControl.Click
        'My.Forms.Un_controle_supplementaire_de_vehicules_soumis_a_la_loi_specifique.Label1.Text = lblCarDefect.Text
        My.Forms.Un_controle_supplementaire_de_vehicules_soumis_a_la_loi_specifique.Label10.Text = Label13.Text
        Un_controle_supplementaire_de_vehicules_soumis_a_la_loi_specifique.Show()
        Me.Dispose()
    End Sub


    Private Sub btnEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsc.Click
        'My.Forms.Vehicles.Label1.Text = lblCarDefect.Text
        'My.Forms.Vehicles.btnVisual.Enabled = True
        'My.Forms.Vehicles.btnReview.Enabled = True
        'My.Forms.Vehicles.btnStore.Enabled = True
        ''My.Forms.Vehicles.btnSelect.Enabled = False
        'My.Forms.Vehicles.btnDeleted.Enabled = True

        Vehicles.Show()
        Me.Dispose()
    End Sub


    Private Sub btnesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnEsc.KeyDown
        If e.KeyCode = Keys.Escape Then
            'My.Forms.Vehicles.Label1.Text = lblCarDefect.Text
            'My.Forms.Vehicles.btnVisual.Enabled = True
            'My.Forms.Vehicles.btnReview.Enabled = True
            'My.Forms.Vehicles.btnStore.Enabled = True
            'My.Forms.Vehicles.btnSelect.Enabled = False
            '' My.Forms.Vehicles.btnDeleted.Enabled = True

            Vehicles.Show()
            Me.Dispose()

        End If

    End Sub

End Class