Public Class Settings
    Dim conn As New connection
    Dim sql As String
    Dim dt As New Data.DataTable

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Vehicles.Show()
        Me.Close()
    End Sub

    Private Sub SectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionsToolStripMenuItem.Click
        ManageSections.Show()
    End Sub

    Private Sub VtsRymeProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VtsRymeProcessToolStripMenuItem.Click
        MahaRymeProcessor.Show()
    End Sub

    Private Sub ComputerNamePatternToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputerNamePatternToolStripMenuItem.Click
        ComputerNamePattern.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub EscToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Users.Show()
    End Sub

    Private Sub LoggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoggerToolStripMenuItem.Click
        Log.Show()
    End Sub

    Private Sub VTSTypesGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MachinesTypesGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VTSToolStripMenuItem.Click
        'VTSTypesGroups.Show()
    End Sub

    Private Sub MACHINESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MACHINESToolStripMenuItem.Click
        MachinesTypesGroups.Show()
    End Sub

    Private Sub CALCULATEDVTSCODESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CALCULATEDVTSCODESToolStripMenuItem1.Click
        CalculatedVts.Show()
    End Sub

    Private Sub GroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupsToolStripMenuItem.Click
        UsersGroup.Show()
    End Sub

    Private Sub GroupsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GroupsToolStripMenuItem1.Click
        Groups.Show()
    End Sub

    Private Sub BusinessUnitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusinessUnitToolStripMenuItem.Click
        BusinessUnit.Show()
    End Sub

    Private Sub GroupsBusinessUnitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupsBusinessUnitToolStripMenuItem.Click
        GroupsBusinessUnit.Show()
    End Sub

    Private Sub TimerSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerSetToolStripMenuItem.Click
        TimerSet.Show()
    End Sub

    Private Sub CancelInspectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelInspectionToolStripMenuItem.Click
        CancelInspection.Show()
    End Sub

    Private Sub FileWatcherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileWatcherToolStripMenuItem.Click
        FileWatcher.Show()
    End Sub
End Class