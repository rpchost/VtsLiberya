 Imports System.Configuration

Public Class connection

    Public connetionString As String = Handler.AppSettings("ConnectionString")
    Dim conn As Data.SqlClient.SqlConnection
    Dim command As Data.SqlClient.SqlCommand
    Dim adapter As Data.SqlClient.SqlDataAdapter
    Dim reader As Data.SqlClient.SqlDataReader
    Dim dt As Data.DataTable
    Dim sqlConn As SqlClient.SqlConnection = Nothing
    Dim sqlComm As SqlClient.SqlCommand

    Public Function rdGetReader(ByVal strSQL As String) As SqlClient.SqlDataReader

        Try
            sqlConn = New SqlClient.SqlConnection(connetionString)
            sqlComm = New SqlClient.SqlCommand(strSQL, sqlConn)
            sqlComm.CommandText = strSQL
            sqlComm.Connection.Open()
            Reader = sqlComm.ExecuteReader()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
            If Not sqlConn Is Nothing Then
                If (sqlConn.State <> ConnectionState.Closed) Then
                    sqlConn.Close()
                End If
                sqlConn = Nothing
            End If
        Finally
            sqlComm = Nothing

        End Try
        rdGetReader = Reader

    End Function

    Public Sub closeConnection()
        'Close the connection
        Try
            If Not sqlConn Is Nothing Then
                If (sqlConn.State <> ConnectionState.Closed) Then
                    sqlConn.Close()
                End If
                sqlConn = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function ExecuteReaderdt(ByVal sqlstr As String) As Data.DataTable
        Try
            conn = New Data.SqlClient.SqlConnection(connetionString)
            conn.Open()
            command = New Data.SqlClient.SqlCommand(sqlstr, conn)
            adapter = New Data.SqlClient.SqlDataAdapter(command)
            dt = New Data.DataTable
            adapter.Fill(dt)

        Catch ex As Exception
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
        Finally
            conn.Close()
            conn = Nothing

        End Try
        ExecuteReaderdt = dt
    End Function


    Public Function ExecuteSqlCommand(ByVal sql As String) As (Boolean, String)
        ' conn = New Data.SqlClient.SqlConnection(connetionString)
        Using conn As New Data.SqlClient.SqlConnection(connetionString)
            Try
                conn.Open()
                command = New Data.SqlClient.SqlCommand(sql, conn)
                command.ExecuteNonQuery()
                Return (True, "")
            Catch ex As Exception
                If conn.State = Data.ConnectionState.Open Then
                    conn.Close()
                End If
                Return (False, ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Function

    Public Function ExecuteSqlCommand(ByVal sql As String, ByVal condition As Boolean) As (Boolean, String)

        Dim res As Boolean = False
        'conn = New Data.SqlClient.SqlConnection(connetionString)
        Using conn As New Data.SqlClient.SqlConnection(connetionString)
            Try
                conn.Open()
                command = New Data.SqlClient.SqlCommand(sql, conn)
                command.ExecuteNonQuery()
                Return (True, "")
            Catch ex As Exception
                res = False
                If conn.State = Data.ConnectionState.Open Then
                    conn.Close()
                End If
                Return (False, ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Function

    Public Function ExecuteGetReader(ByVal strsql As String) As Data.SqlClient.SqlDataReader
        Try
            conn = New Data.SqlClient.SqlConnection(connetionString)
            command = New Data.SqlClient.SqlCommand(strsql, conn)
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If

            conn.Open()
            reader = command.ExecuteReader()

        Catch ex As Exception
            If conn.State = Data.ConnectionState.Open Then
                conn.Close()
            End If
        Finally
            conn = Nothing
        End Try
        ExecuteGetReader = reader
    End Function
End Class
