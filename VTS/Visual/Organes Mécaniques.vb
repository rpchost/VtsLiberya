Public Class Organes_Mécaniques

    Private Sub Organes_Mécaniques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Groupe_Moto_propulseur.Label8.Text = Label8.Text
        My.Forms.Groupe_Moto_propulseur.Label9.Text = Label9.Text
        Groupe_Moto_propulseur.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Alimentation.Label8.Text = Label8.Text
        My.Forms.Alimentation.Label10.Text = Label10.Text
        Alimentation.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.échappement.Label8.Text = Label8.Text
        My.Forms.échappement.Label11.Text = Label11.Text
        échappement.Show()
        Me.Dispose()

    End Sub


    Private Sub btnOrganesMec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganesMec.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class