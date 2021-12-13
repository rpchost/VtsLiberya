Public Class Visibilite

    Private Sub Visibilite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Vitrages.Label3.Text = Label3.Text
        My.Forms.Vitrages.Label4.Text = Label4.Text
        Vitrages.Show()
        Me.Dispose()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Rétroviseurs.Label3.Text = Label3.Text
        My.Forms.Rétroviseurs.Label5.Text = Label5.Text
        Rétroviseurs.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Accessoires_de_visibilite.Label3.Text = Label3.Text
        My.Forms.Accessoires_de_visibilite.Label6.Text = Label6.Text
        Accessoires_de_visibilite.Show()
        Me.Dispose()

    End Sub

    Private Sub btnContSuppEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContSuppEsc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text

        Defects.Show()
        Me.Dispose()
    End Sub
End Class