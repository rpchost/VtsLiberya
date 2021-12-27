Imports System
Imports System.IO

Public Class FileWatcher
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim watcher = New FileSystemWatcher("C:\Visual")



        watcher.EnableRaisingEvents = True
        watcher.SynchronizingObject = Me
        watcher.IncludeSubdirectories = True

        '  watcher.NotifyFilter = NotifyFilters.Attributes And NotifyFilters.CreationTime And NotifyFilters.DirectoryName And NotifyFilters.FileName _
        '  And NotifyFilters.LastAccess And NotifyFilters.LastWrite And NotifyFilters.Security And NotifyFilters.Size

        AddHandler watcher.Changed, New FileSystemEventHandler(AddressOf LogFile)
        AddHandler watcher.Created, New FileSystemEventHandler(AddressOf LogFile)
        AddHandler watcher.Deleted, New FileSystemEventHandler(AddressOf LogFile)
        AddHandler watcher.Renamed, New RenamedEventHandler(AddressOf LogRename)




    End Sub

    Private Async Sub LogRename(ByVal sender As Object, ByVal e As _
         RenamedEventArgs)

        MessageBox.Show("Renamed")

    End Sub

    Private Async Sub LogFile(ByVal sender As Object, ByVal e _
         As FileSystemEventArgs)

        MessageBox.Show("Logged")

    End Sub
End Class