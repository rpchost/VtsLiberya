﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class VTSEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=VTSEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function RPTFstVisitFailRateByLane(fromDate As Nullable(Of Date), toDate As Nullable(Of Date), sTATIONNAME As String) As ObjectResult(Of RPTFstVisitFailRateByLane_Result)
        Dim fromDateParameter As ObjectParameter = If(fromDate.HasValue, New ObjectParameter("FromDate", fromDate), New ObjectParameter("FromDate", GetType(Date)))

        Dim toDateParameter As ObjectParameter = If(toDate.HasValue, New ObjectParameter("ToDate", toDate), New ObjectParameter("ToDate", GetType(Date)))

        Dim sTATIONNAMEParameter As ObjectParameter = If(sTATIONNAME IsNot Nothing, New ObjectParameter("STATIONNAME", sTATIONNAME), New ObjectParameter("STATIONNAME", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of RPTFstVisitFailRateByLane_Result)("RPTFstVisitFailRateByLane", fromDateParameter, toDateParameter, sTATIONNAMEParameter)
    End Function

End Class
