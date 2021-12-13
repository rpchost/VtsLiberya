Public Class Direction


    Private Sub Direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub



  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeasureDirection.Click

        My.Forms.MesureDirection.Label2.Text = Label2.Text
        My.Forms.MesureDirection.Label3.Text = Label3.Text
        MesureDirection.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganesDirection.Click

        My.Forms.OrganesDeDirection.Label2.Text = Label2.Text
        My.Forms.OrganesDeDirection.Label3.Text = Label4.Text
        OrganesDeDirection.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssitanceDirection.Click

        My.Forms.Assistance_de_direction.Label2.Text = Label2.Text
        My.Forms.Assistance_de_direction.Label5.Text = Label5.Text
        Assistance_de_direction.Show()
        Me.Dispose()

    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class