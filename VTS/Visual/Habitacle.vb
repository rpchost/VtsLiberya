Public Class Habitacle

    Private Sub Habitacle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Siege.Label1.Text = Label1.Text
        My.Forms.Siege.Label7.Text = Label7.Text
        My.Forms.Siege.Label8.Text = Label8.Text
        My.Forms.Siege.Label9.Text = Label9.Text
        Siege.Show()
       Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Ceinture__Siege_avant_et_arriere.Label1.Text = Label1.Text
        My.Forms.Ceinture__Siege_avant_et_arriere.Label7.Text = Label7.Text
        My.Forms.Ceinture__Siege_avant_et_arriere.Label8.Text = Label8.Text
        My.Forms.Ceinture__Siege_avant_et_arriere.Label10.Text = Label10.Text
        Ceinture__Siege_avant_et_arriere.Show()
       Me.Dispose()
    End Sub


    Private Sub btnFreinServiceESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreinServiceESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class