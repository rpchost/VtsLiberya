Public Class Structures

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Lomgeron__brancard.Label6.Text = Label6.Text
        My.Forms.Lomgeron__brancard.Label7.Text = Label7.Text
        My.Forms.Lomgeron__brancard.Label8.Text = Label8.Text
        Lomgeron__brancard.Show()
        Me.Dispose()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        My.Forms.Plancher.Label6.Text = Label6.Text
        My.Forms.Plancher.Label7.Text = Label7.Text
        My.Forms.Plancher.Label10.Text = Label10.Text
        Plancher.Show()
        Me.Dispose()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        My.Forms.Traverse.Label6.Text = Label6.Text
        My.Forms.Traverse.Label7.Text = Label7.Text
        My.Forms.Traverse.Label9.Text = Label9.Text
        Traverse.Show()
        Me.Dispose()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        My.Forms.Berceau.Label6.Text = Label6.Text
        My.Forms.Berceau.Label7.Text = Label7.Text
        My.Forms.Berceau.Label11.Text = Label11.Text
        Berceau.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Passage_de_roue.Label6.Text = Label6.Text
        My.Forms.Passage_de_roue.Label7.Text = Label7.Text
        My.Forms.Passage_de_roue.Label12.Text = Label12.Text
        Passage_de_roue.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Bas_de_caisse.Label6.Text = Label6.Text
        My.Forms.Bas_de_caisse.Label7.Text = Label7.Text
        My.Forms.Bas_de_caisse.Label13.Text = Label13.Text
        Bas_de_caisse.Show()
        Me.Dispose()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Forms.Infrastructure_soubassement.Label6.Text = Label6.Text
        My.Forms.Infrastructure_soubassement.Label7.Text = Label7.Text
        My.Forms.Infrastructure_soubassement.Label14.Text = Label14.Text
        Infrastructure_soubassement.Show()
        Me.Dispose()

    End Sub


    Private Sub btnStructuresESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructuresESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Structures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class