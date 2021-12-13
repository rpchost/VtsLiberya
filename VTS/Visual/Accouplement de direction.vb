Public Class Accouplement_de_direction

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ''My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label8.Text
        My.Forms.DefectPage.Label5.Text = Label9.Text
        DefectPage.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ''My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label8.Text
        My.Forms.DefectPage.Label5.Text = Label10.Text
        DefectPage.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ''My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label8.Text
        My.Forms.DefectPage.Label5.Text = Label11.Text
        DefectPage.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ''My.Forms.DefectPage.Label1.Text = Label1.Text
        My.Forms.DefectPage.Label3.Text = Label2.Text
        My.Forms.DefectPage.Label2.Text = Label4.Text
        My.Forms.DefectPage.Label4.Text = Label8.Text
        My.Forms.DefectPage.Label5.Text = Label12.Text
        DefectPage.Show()
        Me.Dispose()
    End Sub


    Private Sub btnESC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnESC.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub btnESC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnESC.KeyDown
        If e.KeyCode = Keys.Escape Then
            'My.Forms.Defects.lblCarDefect.Text = Label1.Text
            Defects.Show()
            Me.Dispose()
        End If




    End Sub

    Private Sub Accouplement_de_direction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate

    End Sub
End Class