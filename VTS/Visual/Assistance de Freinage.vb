Public Class Assistance_de_Freinage

 

    Private Sub btnAssistance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssistance.Click
        'My.Forms.Assistence_de_frienage_servo.Label1.Text = Label1.Text
        My.Forms.Assistence_de_frienage_servo.Label2.Text = Label2.Text
        My.Forms.Assistence_de_frienage_servo.Label3.Text = Label3.Text
        My.Forms.Assistence_de_frienage_servo.Label4.Text = Label4.Text

        Assistence_de_frienage_servo.Show()
        Me.Dispose()
    End Sub

    Private Sub btnTuyauterie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTuyauterie.Click
        'My.Forms.Tuyauterie_dassistance__de_freinage.Label1.Text = Label1.Text
        My.Forms.Tuyauterie_dassistance__de_freinage.Label2.Text = Label2.Text
        My.Forms.Tuyauterie_dassistance__de_freinage.Label3.Text = Label3.Text
        My.Forms.Tuyauterie_dassistance__de_freinage.Label4.Text = Label5.Text

        Tuyauterie_dassistance__de_freinage.Show()
        Me.Dispose()
    End Sub



    Private Sub BtnEscDirAssis_Click(sender As Object, e As EventArgs) Handles btnEscDirAssis.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Assistance_de_Freinage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

        ' Defects.Show()
        'Me.Dispose()
    End Sub
End Class