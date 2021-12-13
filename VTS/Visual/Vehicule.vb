Public Class Vehicule

    Private Sub Vehicule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
    End Sub





    Private Sub btnPresentation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentation.Click

        My.Forms.VehiculePage.Label2.Text = Label2.Text
        My.Forms.VehiculePage.Label4.Text = Label4.Text
        My.Forms.VehiculePage.Label3.Text = Label3.Text
        VehiculePage.Show()
        Me.Dispose()
    End Sub

    Private Sub btnContSuppEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContSuppEsc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class