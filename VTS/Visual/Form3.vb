Imports System.IO
Imports System.IO.File
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim conn As New connection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim builder As New System.Text.StringBuilder

        'Add with list(Of T)
        Dim fStream As New System.IO.FileStream("c:/euro/ESIN/B123456.txt", IO.FileMode.Open)
        Dim sReader As New System.IO.StreamReader(fStream)
        Dim List As New List(Of String)
        Do While sReader.Peek >= 0

            List.Add(sReader.ReadLine)

        Loop

        'to go back to an array
        Dim thisArray As String() = List.ToArray

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim x As Integer = 0



        While j <= List.Count - 1
            If List(j) <> ";  -------- Visual defects" Then
                x = x + 1
                j = j + 1
            Else
                Exit While
            End If
        End While


        For i = 0 To x


            builder.AppendLine(List(i))



        Next


        fStream.Close()
        sReader.Close()

        Dim writer As New IO.StreamWriter("c:/euro/ESIN/B123456.txt")
        writer.Write(builder.ToString)

        writer.WriteLine(" ")
        writer.WriteLine("")


        writer.Close()


        Dim z1 As Integer
        Dim sqlReader1 As String
        Dim dtReader1 As New Data.DataTable
        sqlReader1 = "select GroupFreinage, plateNO, CodeFreinage,EmpID,DefectDate,DefectHour,EditEmpID,EditDefectDate from VisuelDefect where plateno='b123456' and GroupFreinage is NOT NULL"
        dtReader1 = conn.ExecuteReaderdt(sqlReader1)

        Dim sqlCode1 As String
        Dim dtCode1 As New Data.DataTable
        sqlCode1 = "select * from CodeDefects where plateNO='B123456' and GroupCode='1.Freinage' order by id asc"
        dtCode1 = conn.ExecuteReaderdt(sqlCode1)
        Dim counter1 As Integer

        If dtReader1.Rows.Count > 0 Then
            Using sw1 As StreamWriter = File.AppendText("c:/euro/ESIN/B123456.txt")

                sw1.WriteLine("; ----- 1.Freinage")

                'For u1 = 0 To dtReader1.Rows.Count - 1
                For counter1 = 0 To dtCode1.Rows.Count - 1
                    z1 = dtCode1.Rows(counter1).Item("CodeCounter")
                    sw1.WriteLine(70000 + z1 & "= " & dtReader1.Rows(counter1).Item("EmpID"))
                    sw1.WriteLine(70001 + z1 & "=  6")
                    sw1.WriteLine(70002 + z1 & "=  0")
                    sw1.WriteLine(70003 + z1 & "=" & dtReader1.Rows(counter1).Item("CodeFreinage"))
                    sw1.WriteLine(70006 + z1 & "=  1")
                    sw1.WriteLine(70008 + z1 & "=  ")
                    sw1.WriteLine(70009 + z1 & "=defect.ini")
                    sw1.WriteLine(70010 + z1 & "=" & dtReader1.Rows(counter1).Item("DefectDate"))
                    sw1.WriteLine(70011 + z1 & "=" & dtReader1.Rows(counter1).Item("DefectHour"))
                    sw1.WriteLine(70012 + z1 & "=" & dtReader1.Rows(counter1).Item("EmpID") & Space(2) & dtReader1.Rows(counter1).Item("EmpID"))
                    If IsDBNull(dtCode1.Rows(counter1).Item("EditDefectDate")) = False Then
                        sw1.WriteLine(70000 + z1 + 11 & "=1")
                        sw1.WriteLine(70001 + z1 + 11 & "=25")
                        sw1.WriteLine(70002 + z1 + 11 & "=  3")
                        sw1.WriteLine(70003 + z1 + 11 & "=" & dtReader1.Rows(counter1).Item("EmpID"))
                        sw1.WriteLine(70004 + z1 + 11 & "=" & dtReader1.Rows(counter1).Item("EditEmpID") & Space(2) & dtReader1.Rows(counter1).Item("EditEmpID"))
                        sw1.WriteLine(70005 + z1 + 11 & "=" & dtReader1.Rows(counter1).Item("EditDefectDate"))
                        sw1.WriteLine(70006 + z1 + 11 & "=" & dtReader1.Rows(counter1).Item("EditEmpID"))
                    End If

                    sw1.WriteLine(" ")
                    sw1.WriteLine(" ")


                Next

                'Next
            End Using

        End If



    End Sub
End Class