Public Class Taxipage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Taxi1.Label10.Text = Label10.Text
        My.Forms.Taxi1.Label15.Text = Label15.Text
        My.Forms.Taxi1.Label16.Text = Label16.Text
        Taxi1.Show()
        Me.Dispose()
    End Sub


    Private Sub btnTaxiPage1ESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaxiPage1ESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Taxipage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class