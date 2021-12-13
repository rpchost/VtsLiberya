Public Class Equipements

    Private Sub Equipements_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Habitacle.Label7.Text = Label7.Text
        My.Forms.Habitacle.Label8.Text = Label8.Text
        Habitacle.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Autres_équipement.Label7.Text = Label7.Text
        My.Forms.Autres_équipement.Label9.Text = Label9.Text
        Autres_équipement.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Elément_D_information.Label7.Text = Label7.Text
        My.Forms.Elément_D_information.Label10.Text = Label10.Text
        Elément_D_information.Show()
        Me.Dispose()
    End Sub



    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class