Public Class Elément_D_information

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Témoins_de_mauvais_fonctionement_du_cossin_gonflable.Label7.Text = Label7.Text
        My.Forms.Témoins_de_mauvais_fonctionement_du_cossin_gonflable.Label10.Text = Label10.Text
        My.Forms.Témoins_de_mauvais_fonctionement_du_cossin_gonflable.Label11.Text = Label11.Text
        Témoins_de_mauvais_fonctionement_du_cossin_gonflable.Show()
        Me.Dispose()
    End Sub



    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Elément_D_information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class