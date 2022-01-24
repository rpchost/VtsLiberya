Imports System.IO

Public Class EsIn
    Public Function ToEsPath(ByVal EsType As String, ByVal EsIO As String, ByVal FileName As String, ByVal Lane As String, Optional EsVehTyp As String = "") As Boolean
        'EsVehTyp param if empty then CreateEsIn in all sections upon the choice of EsIO and EsType
        'EsType = RYME or VTS
        'EsIO = IN or OUT
        'FileName is the Plate number

        Dim dc As Dictionary(Of String, String) = GetSectionsDir(EsType, EsIO, Lane, EsVehTyp)

        For Each iKey As String In dc.Keys
            Try
                WriteEsIn(EsType, dc(iKey), FileName)
                Handler.Log("EsIn created successfully ; User = " & Handler.InspectorID & " EsIn data: " & dc(iKey) & " " & FileName, Handler.GenerateTimeZone(), "EsIn.WriteEsIn.ToEsPath", "Success")
            Catch ex As Exception
                Handler.Log("FileName " & FileName & " Location " & dc(iKey) & " EsType " & EsType, Handler.GenerateTimeZone(), "EsIn.WriteEsIn", ex.Message)
            End Try

        Next

        Return True

    End Function

    Public Function DeleteAllEs(ByVal EsType As String, ByVal EsIO As String, ByVal FileName As String, ByVal Lane As String, Optional EsVehTyp As String = "") As Boolean

        Dim dc As Dictionary(Of String, String) = GetSectionsDir(EsType, EsIO, Lane, EsVehTyp)

        For Each iKey As String In dc.Keys
            Try
                DeleteEs(EsType, dc(iKey), FileName)
                Handler.Log("EsIn deleted successfully ; User = " & Handler.InspectorID & " EsIn data: " & dc(iKey) & " " & FileName, Handler.GenerateTimeZone(), "EsIn.DeleteAllEs.ToEsPath", "Success")
            Catch ex As Exception
                Handler.Log("FileName " & FileName & " Location " & dc(iKey) & " EsType " & EsType, Handler.GenerateTimeZone(), "EsIn.DeleteAllEs", ex.Message)
            End Try

        Next

        Return True

    End Function
    Private Function DeleteEs(EsType As String, Loc As String, FileName As String) As Boolean

        Dim strFile As String = Loc & "\" & FileName & ".txt"
        Try
            If (File.Exists(strFile)) Then
                File.Delete(strFile)
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function WriteEsIn(EsType As String, Loc As String, FileName As String) As Boolean

        Dim strFile As String = Loc & "\" & FileName & ".txt"

        Dim Res As Boolean = False

        If (EsType = "RYME") Then

            Dim sw As New StreamWriter(strFile, False)
            sw.WriteLine("[DATOS_RYME]")
            sw.WriteLine("00100=" & FileName)
            sw.WriteLine("00101=" & Handler.InspectionNo)
            sw.WriteLine("00102=" & Handler.GenerateTimeZone().ToString("dd/MM/yyyy"))
            sw.WriteLine("00103=" & Handler.GenerateTimeZone().ToString("HH:mm"))
            sw.WriteLine("00104=" & Handler.InspectorID)

            Res = True
            sw.Close()
        End If

        Return Res

    End Function


    Private Function GetSectionsDir(ByVal EsType As String, ByVal EsIO As String, ByVal Lane As String, Optional EsVehTyp As String = "") As Dictionary(Of String, String)

        Dim str As String = ""
        Dim opExec As New connection
        Dim sql As String = ""
        Dim dc As New Dictionary(Of String, String)

        sql = "select SC_DIR_LOC, SC_LBL from SECTION_LABELS where SC_TYP = '" & EsType & "' and SC_IN_OUT = '" & EsIO & "'  "
        If (EsVehTyp <> "") Then sql = sql + " and SC_VEH_TYP = " & EsVehTyp

        Dim reader As SqlClient.SqlDataReader = opExec.rdGetReader(sql)
        Try

            If reader.HasRows = True Then

                While reader.Read()
                    dc.Add(reader("SC_LBL"), reader("SC_DIR_LOC") & "\" & Lane)
                End While

            End If

            Return dc

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            opExec.closeConnection()
        End Try

    End Function


End Class
