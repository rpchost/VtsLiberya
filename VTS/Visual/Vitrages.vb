Public Class Vitrages

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'My.Forms.PareBrise.Label1.Text = Label1.Text
        My.Forms.PareBrise.Label3.Text = Label3.Text
        My.Forms.PareBrise.Label4.Text = Label4.Text
        My.Forms.PareBrise.Label5.Text = Label5.Text
        PareBrise.Show()
       Me.Dispose()
    End Sub

  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'My.Forms.Autre_Vitrage.Label1.Text = Label1.Text
        My.Forms.Autre_Vitrage.Label3.Text = Label3.Text
        My.Forms.Autre_Vitrage.Label4.Text = Label4.Text
        My.Forms.Autre_Vitrage.Label6.Text = Label6.Text
        Autre_Vitrage.Show()
       Me.Dispose()
    End Sub

    Private Sub btnContSuppEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContSuppEsc.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text

        Defects.Show()
       Me.Dispose()
    End Sub

    Private Sub Vitrages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class