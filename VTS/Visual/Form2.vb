Public Class Form2
    Dim DefectDate As String
    Dim DefectHour As String
    Dim conn As New connection
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DefectDate = Now.Year & Now.Month & Now.Day.ToString("D2")

        DefectHour = Now.Hour.ToString("D2") & ":" & Now.Minute.ToString("D2")
        'MessageBox.Show(DefectHour)


        Dim sqlUser As String
        Dim dtUser As New Data.DataTable

        sqlUser = "select * from CodeDefects where VisuelID=504"
        dtUser = conn.ExecuteReaderdt(sqlUser)
        Dim z As Integer
        z = 70000 + dtUser.Rows(0).Item("CodeCounter")

        MessageBox.Show(z)

    End Sub
End Class