Public Class Identification


    Private Sub Identification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        My.Forms.Plaque.Label2.Text = Label2.Text
        My.Forms.Plaque.Label3.Text = Label3.Text
        Plaque.Show()
        Me.Dispose()


        'Dim frm As New Plaque()
        'frm.Show()
        'Me.Hide()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        My.Forms.NumeroChassis.Label2.Text = Label3.Text
        My.Forms.NumeroChassis.Label4.Text = Label4.Text
        NumeroChassis.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Vehicule.Label3.Text = Label3.Text
        My.Forms.Vehicule.Label4.Text = Label5.Text
        Vehicule.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Divers.Label2.Text = Label3.Text
        My.Forms.Divers.Label6.Text = Label6.Text
        Divers.Show()
        Me.Dispose()
    End Sub


    Private Sub btnFreinServiceESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinServiceESC.Click
        ' My.Forms.Defects.lblPlate.Text = lblIdentCar.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class