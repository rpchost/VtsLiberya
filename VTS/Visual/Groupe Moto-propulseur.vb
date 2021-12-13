Public Class Groupe_Moto_propulseur

    Private Sub Groupe_Moto_propulseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Moteur.Label8.Text = Label8.Text
        My.Forms.Moteur.Label9.Text = Label9.Text
        My.Forms.Moteur.Label10.Text = Label10.Text
        Moteur.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Boite.Label8.Text = Label8.Text
        My.Forms.Boite.Label9.Text = Label9.Text
        My.Forms.Boite.Label11.Text = Label11.Text
        Boite.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Pont__boite_de_transfert.Label8.Text = Label8.Text
        My.Forms.Pont__boite_de_transfert.Label9.Text = Label9.Text
        My.Forms.Pont__boite_de_transfert.Label12.Text = Label12.Text
        Pont__boite_de_transfert.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Transmission.Label8.Text = Label8.Text
        My.Forms.Transmission.Label9.Text = Label9.Text
        My.Forms.Transmission.Label13.Text = Label13.Text
        Transmission.Show()
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Forms.Accouplement__relais_de_transmission.Label8.Text = Label8.Text
        My.Forms.Accouplement__relais_de_transmission.Label9.Text = Label9.Text
        My.Forms.Accouplement__relais_de_transmission.Label14.Text = Label14.Text
        Accouplement__relais_de_transmission.Show()
        Me.Dispose()

    End Sub



    Private Sub btnFreinServiceESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinServiceESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class