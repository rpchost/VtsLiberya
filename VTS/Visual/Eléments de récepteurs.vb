Public Class Eléments_de_récepteurs


    Private Sub btnDisqueFrein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisqueFrein.Click


        My.Forms.Disque_de_frein.Label2.Text = Label2.Text
        My.Forms.Disque_de_frein.Label3.Text = Label3.Text
        My.Forms.Disque_de_frein.Label4.Text = Label4.Text

        Disque_de_frein.Show()
        Me.Dispose()
    End Sub

    Private Sub btnEtrier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEtrier.Click

        My.Forms.Etrier___cylindre_de_roue.Label2.Text = Label2.Text
        My.Forms.Etrier___cylindre_de_roue.Label3.Text = Label3.Text
        My.Forms.Etrier___cylindre_de_roue.Label4.Text = Label5.Text

        Etrier___cylindre_de_roue.Show()
        Me.Dispose()
    End Sub

    Private Sub btnTambour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambour.Click

        My.Forms.Tambour_de_frein.Label2.Text = Label2.Text
        My.Forms.Tambour_de_frein.Label3.Text = Label3.Text
        My.Forms.Tambour_de_frein.Label4.Text = Label6.Text

        Tambour_de_frein.Show()
        Me.Dispose()
    End Sub

    Private Sub btnPlaquette_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaquette.Click

        My.Forms.Plaquette_de_frein.Label2.Text = Label2.Text
        My.Forms.Plaquette_de_frein.Label3.Text = Label3.Text
        My.Forms.Plaquette_de_frein.Label4.Text = Label7.Text

        Plaquette_de_frein.Show()
        Me.Dispose()
    End Sub


    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Eléments_de_récepteurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class