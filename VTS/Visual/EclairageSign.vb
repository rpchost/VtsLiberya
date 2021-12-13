Public Class EclairageSign

    Private Sub EclairageSign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.FeuCroisementdeclairage.Label2.Text = Label2.Text
        My.Forms.FeuCroisementdeclairage.Label3.Text = Label3.Text
        My.Forms.FeuCroisementdeclairage.Label4.Text = Label7.Text
        FeuCroisementdeclairage.Show()
        Me.Dispose()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Feu_de_route.Label2.Text = Label2.Text
        My.Forms.Feu_de_route.Label3.Text = Label3.Text
        My.Forms.Feu_de_route.Label4.Text = Label8.Text
        Feu_de_route.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Feu_antibrouillard_AV.Label2.Text = Label2.Text
        My.Forms.Feu_antibrouillard_AV.Label3.Text = Label3.Text
        My.Forms.Feu_antibrouillard_AV.Label4.Text = Label9.Text
        Feu_antibrouillard_AV.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Feu_additionnel.Label2.Text = Label2.Text
        My.Forms.Feu_additionnel.Label3.Text = Label3.Text
        My.Forms.Feu_additionnel.Label4.Text = Label10.Text
        Feu_additionnel.Show()
        Me.Dispose()

    End Sub



    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class