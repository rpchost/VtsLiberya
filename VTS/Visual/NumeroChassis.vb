Public Class NumeroChassis

    Private Sub NumeroChassis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.PlaqueConstructeur.Label2.Text = Label2.Text
        My.Forms.PlaqueConstructeur.Label4.Text = Label4.Text
        My.Forms.PlaqueConstructeur.Label3.Text = Label3.Text
        PlaqueConstructeur.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.FrappeFroid.Label2.Text = Label2.Text
        My.Forms.FrappeFroid.Label4.Text = Label4.Text
        My.Forms.FrappeFroid.Label3.Text = Label5.Text
        FrappeFroid.Show()
        Me.Dispose()
    End Sub


    Private Sub btnNoChassisESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoChassisESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class