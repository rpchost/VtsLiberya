Public Class Eclairage

    Private Sub Eclairage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Mesures.Label2.Text = Label2.Text
        My.Forms.Mesures.Label3.Text = Label5.Text
        Mesures.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.EclairageSign.Label2.Text = Label2.Text
        My.Forms.EclairageSign.Label3.Text = Label6.Text
        EclairageSign.Show()
        Me.Dispose()
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Signalisation.Label2.Text = Label2.Text
        My.Forms.Signalisation.Label3.Text = Label6.Text
        Signalisation.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Eléments_de_commande__d_information.Label2.Text = Label2.Text
        My.Forms.Eléments_de_commande__d_information.Label3.Text = Label8.Text
        Eléments_de_commande__d_information.Show()
        Me.Dispose()

    End Sub



    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class