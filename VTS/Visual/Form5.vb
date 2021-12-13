Public Class Form5




    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnEsc.KeyDown
        If e.KeyCode = Keys.F8 Then
            'btnEsc.Focus()
            Me.Close()
        End If

        If e.KeyCode = Keys.F4 Then
            MessageBox.Show("here")
            'btnEsc.Focus()

        End If

        If e.KeyCode = Keys.F7 Then
            RichTextBox1.Visible = True

        End If
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        MessageBox.Show("here")
    End Sub

    Private Sub btnf7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf7.Click
        RichTextBox1.Visible = True
    End Sub

    Private Sub btnEsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEsc.Click
        Me.Close()
    End Sub
End Class