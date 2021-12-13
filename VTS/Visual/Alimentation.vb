Public Class Alimentation

    Private Sub Alimentation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Circuit_de_carburant.Label1.Text = Label1.Text
        My.Forms.Circuit_de_carburant.Label8.Text = Label8.Text
        My.Forms.Circuit_de_carburant.Label10.Text = Label10.Text
        My.Forms.Circuit_de_carburant.Label11.Text = Label11.Text
        Circuit_de_carburant.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Réservoir_de_carburant.Label1.Text = Label1.Text
        My.Forms.Réservoir_de_carburant.Label8.Text = Label8.Text
        My.Forms.Réservoir_de_carburant.Label10.Text = Label10.Text
        My.Forms.Réservoir_de_carburant.Label12.Text = Label12.Text
        Réservoir_de_carburant.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' My.Forms.Carburateur__systeme_d_injection.Label1.Text = Label1.Text
        My.Forms.Carburateur__systeme_d_injection.Label8.Text = Label8.Text
        My.Forms.Carburateur__systeme_d_injection.Label10.Text = Label10.Text
        My.Forms.Carburateur__systeme_d_injection.Label13.Text = Label13.Text
        Carburateur__systeme_d_injection.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'My.Forms.Pompe_d_alimentation_en_carburant.Label1.Text = Label1.Text
        My.Forms.Pompe_d_alimentation_en_carburant.Label8.Text = Label8.Text
        My.Forms.Pompe_d_alimentation_en_carburant.Label10.Text = Label10.Text
        My.Forms.Pompe_d_alimentation_en_carburant.Label14.Text = Label14.Text
        Pompe_d_alimentation_en_carburant.Show()
        Me.Dispose()

    End Sub



    Private Sub BtnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Defects.Show()
        Me.Dispose()
    End Sub
End Class