Public Class Assistance_de_direction

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Assistance_dedirection.Label1.Text = Label1.Text
        My.Forms.Assistance_dedirection.Label2.Text = Label2.Text
        My.Forms.Assistance_dedirection.Label5.Text = Label5.Text
        My.Forms.Assistance_dedirection.Label6.Text = Label6.Text
        Assistance_dedirection.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.Réservoir_dassistance_de_direction.Label1.Text = Label1.Text
        My.Forms.Réservoir_dassistance_de_direction.Label2.Text = Label2.Text
        My.Forms.Réservoir_dassistance_de_direction.Label5.Text = Label5.Text
        My.Forms.Réservoir_dassistance_de_direction.Label7.Text = Label7.Text
        Réservoir_dassistance_de_direction.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My.Forms.Canalisation_dassistance_de_direction.Label1.Text = Label1.Text
        My.Forms.Canalisation_dassistance_de_direction.Label2.Text = Label2.Text
        My.Forms.Canalisation_dassistance_de_direction.Label5.Text = Label5.Text
        My.Forms.Canalisation_dassistance_de_direction.Label8.Text = Label8.Text
        Canalisation_dassistance_de_direction.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Pompe__verin_dassistance_de_direction.Label1.Text = Label1.Text
        My.Forms.Pompe__verin_dassistance_de_direction.Label2.Text = Label2.Text
        My.Forms.Pompe__verin_dassistance_de_direction.Label5.Text = Label5.Text
        My.Forms.Pompe__verin_dassistance_de_direction.Label9.Text = Label9.Text
        Pompe__verin_dassistance_de_direction.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'My.Forms.Courroie_pompe_dassistance_de_direction.Label1.Text = Label1.Text
        My.Forms.Courroie_pompe_dassistance_de_direction.Label2.Text = Label2.Text
        My.Forms.Courroie_pompe_dassistance_de_direction.Label5.Text = Label5.Text
        My.Forms.Courroie_pompe_dassistance_de_direction.Label10.Text = Label10.Text
        Courroie_pompe_dassistance_de_direction.Show()
        Me.Dispose()
    End Sub


    Private Sub btnEscDirAssis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEscDirAssis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnEscDirAssis.KeyDown
        If e.KeyCode = Keys.Escape Then
            'My.Forms.Defects.lblCarDefect.Text = Label1.Text
            Defects.Show()
            Me.Dispose()
        End If




    End Sub

    Private Sub Assistance_de_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

    End Sub
End Class