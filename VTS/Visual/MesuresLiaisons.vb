Public Class MesuresLiaisons



  

    Private Sub btnSuspension_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuspension.Click

        My.Forms.Suspension.Label2.Text = Label5.Text
        My.Forms.Suspension.Label3.Text = Label6.Text
        My.Forms.Suspension.Label4.Text = Label7.Text
        Suspension.Show()
        Me.Dispose()
    End Sub

    Private Sub btnMesureFRESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesureFRESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub MesuresLiaisons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class