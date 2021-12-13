Public Class ESINPath

    Private Sub ESINPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

      
    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        SaveFileDialog1.InitialDirectory = "C:\Euro\ESIN\"

        saveFileDialog1.Title = "Save text Files"

        saveFileDialog1.CheckFileExists = True

        saveFileDialog1.CheckPathExists = True

        saveFileDialog1.DefaultExt = "txt"

        saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        saveFileDialog1.FilterIndex = 2

        saveFileDialog1.RestoreDirectory = True



        'If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then



        System.IO.File.Copy(SaveFileDialog1.FileName, "C:\Euro\ESIN\" & System.IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName) & ".txt", True)
        TextBox1.Text = ""
        MsgBox("File uploaded successfully")
        'End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        TextBox1.Text = SaveFileDialog1.FileName
    End Sub
End Class