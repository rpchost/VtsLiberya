Public Class Barre_stabilisatrice

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label17.Text
        My.Forms.DefectPage.Label5.Text = Label18.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label17.Text
        My.Forms.DefectPage.Label5.Text = Label19.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label5.Text
        My.Forms.DefectPage.Label2.Text = Label7.Text
        My.Forms.DefectPage.Label4.Text = Label17.Text
        My.Forms.DefectPage.Label5.Text = Label20.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub



    Private Sub BtnEscDirAssis_Click(sender As Object, e As EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Barre_stabilisatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class