Public Class Témoins_de_mauvais_fonctionement_du_cossin_gonflable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label7.Text
        My.Forms.DefectPage.Label2.Text = Label10.Text
        My.Forms.DefectPage.Label4.Text = Label11.Text
        My.Forms.DefectPage.Label5.Text = Label12.Text
        DefectPage.Show()
       Me.Dispose()

    End Sub


    Private Sub btnTemoinESCAllum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemoinESCAllum.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Témoins_de_mauvais_fonctionement_du_cossin_gonflable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class