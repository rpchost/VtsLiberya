Public Class Structure_carrosserie

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Structures.Label1.Text = Label1.Text
        My.Forms.Structures.Label6.Text = Label6.Text
        My.Forms.Structures.Label7.Text = Label7.Text
        Structures.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Carrosserie.Label1.Text = Label1.Text
        My.Forms.Carrosserie.Label6.Text = Label6.Text
        My.Forms.Carrosserie.Label8.Text = Label8.Text
        Carrosserie.Show()
       Me.Dispose()
    End Sub


    Private Sub btnStructureESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructureESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Structure_carrosserie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class