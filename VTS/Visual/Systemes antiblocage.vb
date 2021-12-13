Public Class Systemes_antiblocage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystAntiblock.Click

        My.Forms.Systemes_antiblocage1.Label2.Text = Label2.Text
        My.Forms.Systemes_antiblocage1.Label3.Text = Label3.Text
        My.Forms.Systemes_antiblocage1.Label4.Text = Label4.Text
        Systemes_antiblocage1.Show()
        Me.Dispose()

    End Sub



    Private Sub btnAntiESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAntiESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Systemes_antiblocage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100


        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class