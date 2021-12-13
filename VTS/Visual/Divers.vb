Public Class Divers




    Private Sub Divers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.DiversCarte.Label2.Text = Label2.Text
        My.Forms.DiversCarte.Label3.Text = Label6.Text
        My.Forms.DiversCarte.Label4.Text = Label3.Text
        DiversCarte.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.DiversNonRoulant.Label2.Text = Label2.Text
        My.Forms.DiversNonRoulant.Label3.Text = Label6.Text
        My.Forms.DiversNonRoulant.Label4.Text = Label3.Text
        DiversNonRoulant.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.DiversAbsence.Label2.Text = Label2.Text
        My.Forms.DiversAbsence.Label3.Text = Label6.Text
        My.Forms.DiversAbsence.Label4.Text = Label5.Text
        DiversAbsence.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.DiversKM.Label2.Text = Label2.Text
        My.Forms.DiversKM.Label3.Text = Label6.Text
        My.Forms.DiversKM.Label4.Text = Label7.Text
        DiversKM.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Forms.DiversOdm.Label2.Text = Label2.Text
        My.Forms.DiversOdm.Label3.Text = Label6.Text
        My.Forms.DiversOdm.Label4.Text = Label8.Text
        DiversOdm.Show()
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        My.Forms.DiversAbsent.Label2.Text = Label2.Text
        My.Forms.DiversAbsent.Label3.Text = Label6.Text
        My.Forms.DiversAbsent.Label4.Text = Label9.Text
        DiversAbsent.Show()
        Me.Dispose()
    End Sub



    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub
End Class