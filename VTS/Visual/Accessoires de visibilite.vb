Public Class Accessoires_de_visibilite

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.Essuie_glace_AV.Label1.Text = Label1.Text
        My.Forms.Essuie_glace_AV.Label3.Text = Label3.Text
        My.Forms.Essuie_glace_AV.Label6.Text = Label6.Text
        My.Forms.Essuie_glace_AV.Label7.Text = Label7.Text
        Essuie_glace_AV.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' My.Forms.Lave__glace_AV.Label1.Text = Label1.Text
        My.Forms.Lave__glace_AV.Label3.Text = Label3.Text
        My.Forms.Lave__glace_AV.Label6.Text = Label6.Text
        My.Forms.Lave__glace_AV.Label8.Text = Label8.Text
        Lave__glace_AV.Show()
        Me.Dispose()

    End Sub

    Private Sub btnEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsc.Click
        ' 'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub btnESC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnEsc.KeyDown
        If e.KeyCode = Keys.Escape Then
            '  'My.Forms.Defects.lblCarDefect.Text = Label1.Text
            Defects.Show()
            Me.Dispose()
        End If


    End Sub

    Private Sub Accessoires_de_visibilite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100
        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class