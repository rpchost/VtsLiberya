Public Class Triangle_de_pré_signalisation__en_labsence_de_signal_de_détresse__



    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label3.Text
        My.Forms.DefectPage.Label4.Text = Label4.Text
        My.Forms.DefectPage.Label5.Text = Label5.Text
        DefectPage.Show()
       Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTriESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Triangle_de_pré_signalisation__en_labsence_de_signal_de_détresse___Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class