Imports System.Globalization
Imports System.IO

Public Class SYSTEMLOGIN
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable
    Private Sub SYSTEMLOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPwd.Text = ""
        txtUser.Text = ""

        header.Width = Me.Width
        header.Height = 100

        Me.AutoScrollPosition = New Point(0, 0)

        Dim newCulture As CultureInfo = DirectCast(System.Threading.Thread.CurrentThread.CurrentCulture.Clone(), CultureInfo)
        newCulture.DateTimeFormat.ShortDatePattern = "dd/MMM/yyyy"
        newCulture.DateTimeFormat.DateSeparator = "-"
        Threading.Thread.CurrentThread.CurrentCulture = newCulture
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' File.Copy("C:/t/test.txt", "Z:/Rpc/Visual/text.txt", True)

        Dim helper As New Helpers
        If (helper.Expires()) Then
            Dim Answer = MessageBox.Show("System Expired, Please contact administrator.", "Expired !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (Answer = MsgBoxResult.Yes Or Answer = MsgBoxResult.No) Then
                Dispose()
            End If
        End If

        Handler.ClearShared()

        Dim sql As String = "select Name, Password,Group_fk from Users where Name='" & txtUser.Text & "' and Password='" & txtPwd.Text & "'  and Active='Y'"
        dt = conn.ExecuteReaderdt(sql)

        Dim str As String = ""
        Dim opExec As New connection

        Dim dc As New Dictionary(Of String, String)

        sql = "select Name, Password,Group_fk from Users where Name='" & txtUser.Text & "' and Password='" & txtPwd.Text & "'  and Active='Y'"

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                reader.Read()

                Handler.InspectorID = reader("Name")
                Handler.GroupID = reader("Group_fk")
                Handler.GroupName = Handler.Group(reader("Name"))
                Handler.GetLaneSection()

                Handler.Log("User Logged in succeffully ; User = " & txtUser.Text, Handler.GenerateTimeZone(), "SYSTEMLOGIN.Login", "Success")

                Vehicles.Show()
                Me.Hide()
            Else
                lblmsg.Visible = True
                lblmsg.Text = "Incorrect LOGIN"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Sub
    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtUser.KeyPress, txtPwd.KeyPress, Button1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.SendWait("{TAB}")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dispose()
    End Sub
End Class