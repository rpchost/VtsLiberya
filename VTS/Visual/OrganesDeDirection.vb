Public Class OrganesDeDirection

    Private Sub OrganesDeDirection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoilantDirection.Click
        ' My.Forms.VolantDirection.Label1.Text = Label1.Text
        My.Forms.VolantDirection.Label2.Text = Label2.Text
        My.Forms.VolantDirection.Label4.Text = Label3.Text
        My.Forms.VolantDirection.Label5.Text = Label5.Text
        VolantDirection.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAntivolDirection.Click

        My.Forms.Antivol_de_direction.Label2.Text = Label2.Text
        My.Forms.Antivol_de_direction.Label4.Text = Label3.Text
        My.Forms.Antivol_de_direction.Label6.Text = Label6.Text
        Antivol_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColonneDirection.Click

        My.Forms.colonne_de_direction.Label2.Text = Label2.Text
        My.Forms.colonne_de_direction.Label4.Text = Label3.Text
        My.Forms.colonne_de_direction.Label7.Text = Label7.Text
        colonne_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccouplementDirection.Click

        My.Forms.Accouplement_de_direction.Label2.Text = Label2.Text
        My.Forms.Accouplement_de_direction.Label4.Text = Label3.Text
        My.Forms.Accouplement_de_direction.Label8.Text = Label8.Text
        Accouplement_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCremaillereNBoiteDirection.Click

        My.Forms.crémaillere__boitier_de_direction.Label2.Text = Label2.Text
        My.Forms.crémaillere__boitier_de_direction.Label4.Text = Label3.Text
        My.Forms.crémaillere__boitier_de_direction.Label9.Text = Label9.Text
        crémaillere__boitier_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BielletteNTimonerieDirection.Click

        My.Forms.Biellette__timonerie_de_direction.Label2.Text = Label2.Text
        My.Forms.Biellette__timonerie_de_direction.Label4.Text = Label3.Text
        My.Forms.Biellette__timonerie_de_direction.Label10.Text = Label10.Text
        Biellette__timonerie_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotulesArticulationDirection.Click
        ' My.Forms.Rotules_articulation_de_direction.Label1.Text = Label1.Text
        My.Forms.Rotules_articulation_de_direction.Label2.Text = Label2.Text
        My.Forms.Rotules_articulation_de_direction.Label4.Text = Label3.Text
        My.Forms.Rotules_articulation_de_direction.Label11.Text = Label11.Text
        Rotules_articulation_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelaisDirection.Click

        My.Forms.Relais_de_direction.Label2.Text = Label2.Text
        My.Forms.Relais_de_direction.Label4.Text = Label3.Text
        My.Forms.Relais_de_direction.Label12.Text = Label12.Text
        Relais_de_direction.Show()
        Me.Dispose()

    End Sub


    Private Sub btnOrganesESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganesESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class