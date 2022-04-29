Public Class frmMain
    Dim myPurch As New UpdatePURCH_POTables
    Dim frmOpen_All As New Open_All
    Dim frmOpen_FabSub As New Open_FabSub
    Dim frmOpen_ItemQuery As New Open_ItemQuery
    Dim frmProject_Status As New Project_Status
    Dim frmProject_Lookup As New Project_Lookup
    Dim frmProject_AllOpen As New Project_AllOpen
    Dim frmExcess_Mgmt As New Excess_Mgmt
    Dim frmReceiving_Query As New Receiving_Query
    Dim frmExcess_Transfer As New Excess_Transfer
    Dim frmMcMcOpenLate As New McMc_OpenLate
    Dim frmMcMcAllocation As New McMc_StockAllocation

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPurch.LoadData()
    End Sub


    '***Menu Handling***
    Private Sub AllOpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllOpenToolStripMenuItem.Click
        If frmOpen_All.Visible Then
            frmOpen_All.BringToFront()
            Exit Sub
        End If
        frmOpen_All = New Open_All
        frmOpen_All.TopLevel = False
        frmOpen_All.Dock = DockStyle.Fill
        frmOpen_All.MdiParent = Me
        Me.MainPanel.Controls.Add(frmOpen_All)
        frmOpen_All.Show()
        frmOpen_All.BringToFront()
    End Sub

    Private Sub FabricationSubcontractorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FabricationSubcontractorToolStripMenuItem.Click
        If frmOpen_FabSub.Visible Then
            frmOpen_FabSub.BringToFront()
            Exit Sub
        End If
        frmOpen_FabSub = New Open_FabSub
        frmOpen_FabSub.TopLevel = False
        frmOpen_FabSub.Dock = DockStyle.Fill
        frmOpen_FabSub.MdiParent = Me
        Me.MainPanel.Controls.Add(frmOpen_FabSub)
        frmOpen_FabSub.Show()
        frmOpen_FabSub.BringToFront()
    End Sub

    Private Sub OpenItemQueryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenItemQueryToolStripMenuItem1.Click
        If frmOpen_ItemQuery.Visible Then
            frmOpen_ItemQuery.BringToFront()
            Exit Sub
        End If
        frmOpen_ItemQuery = New Open_ItemQuery
        frmOpen_ItemQuery.TopLevel = False
        frmOpen_ItemQuery.Dock = DockStyle.Fill
        frmOpen_ItemQuery.MdiParent = Me
        Me.MainPanel.Controls.Add(frmOpen_ItemQuery)
        frmOpen_ItemQuery.Show()
        frmOpen_ItemQuery.BringToFront()
    End Sub

    Private Sub ProjectStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectStatusToolStripMenuItem.Click
        If frmProject_Status.Visible Then
            frmProject_Status.BringToFront()
            Exit Sub
        End If
        frmProject_Status = New Project_Status
        frmProject_Status.TopLevel = False
        frmProject_Status.Dock = DockStyle.Fill
        frmProject_Status.MdiParent = Me
        Me.MainPanel.Controls.Add(frmProject_Status)
        frmProject_Status.Show()
        frmProject_Status.BringToFront()
    End Sub

    Private Sub JobLookUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobLookUpToolStripMenuItem.Click
        If frmProject_Lookup.Visible Then
            frmProject_Lookup.BringToFront()
            Exit Sub
        End If
        frmProject_Lookup = New Project_Lookup
        frmProject_Lookup.TopLevel = False
        frmProject_Lookup.Dock = DockStyle.Fill
        frmProject_Lookup.MdiParent = Me
        Me.MainPanel.Controls.Add(frmProject_Lookup)
        frmProject_Lookup.Show()
        frmProject_Lookup.BringToFront()
    End Sub

    Private Sub AllOpenProjectsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AllOpenProjectsToolStripMenuItem1.Click
        If frmProject_AllOpen.Visible Then
            frmProject_AllOpen.BringToFront()
            Exit Sub
        End If
        frmProject_AllOpen = New Project_AllOpen
        frmProject_AllOpen.TopLevel = False
        frmProject_AllOpen.Dock = DockStyle.Fill
        frmProject_AllOpen.MdiParent = Me
        Me.MainPanel.Controls.Add(frmProject_AllOpen)
        frmProject_AllOpen.Show()
        frmProject_AllOpen.BringToFront()
    End Sub

    Private Sub ManageDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageDatabaseToolStripMenuItem.Click
        If frmExcess_Mgmt.Visible Then
            frmExcess_Mgmt.BringToFront()
            Exit Sub
        End If
        frmExcess_Mgmt = New Excess_Mgmt
        frmExcess_Mgmt.TopLevel = False
        frmExcess_Mgmt.Dock = DockStyle.Fill
        frmExcess_Mgmt.MdiParent = Me
        Me.MainPanel.Controls.Add(frmExcess_Mgmt)
        frmExcess_Mgmt.Show()
        frmExcess_Mgmt.BringToFront()
    End Sub

    Private Sub QueryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QueryToolStripMenuItem1.Click
        If frmReceiving_Query.Visible Then
            frmReceiving_Query.BringToFront()
            Exit Sub
        End If
        frmReceiving_Query = New Receiving_Query
        frmReceiving_Query.TopLevel = False
        frmReceiving_Query.Dock = DockStyle.Fill
        frmReceiving_Query.MdiParent = Me
        Me.MainPanel.Controls.Add(frmReceiving_Query)
        frmReceiving_Query.Show()
        frmReceiving_Query.BringToFront()
    End Sub

    Private Sub TransferItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferItemsToolStripMenuItem.Click
        If frmExcess_Transfer.Visible Then
            frmExcess_Transfer.BringToFront()
            Exit Sub
        End If
        frmExcess_Transfer = New Excess_Transfer
        frmExcess_Transfer.TopLevel = False
        frmExcess_Transfer.Dock = DockStyle.Fill
        frmExcess_Transfer.MdiParent = Me
        Me.MainPanel.Controls.Add(frmExcess_Transfer)
        frmExcess_Transfer.Show()
        frmExcess_Transfer.BringToFront()
    End Sub

    Private Sub REFRESHDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REFRESHDataToolStripMenuItem.Click
        If frmOpen_All.Visible = True Then frmOpen_All.RefreshData()

    End Sub

    Private Sub OpenLateReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenLateReportToolStripMenuItem1.Click
        If frmMcMcOpenLate.Visible Then
            frmMcMcOpenLate.BringToFront()
            Exit Sub
        End If
        frmMcMcOpenLate = New McMc_OpenLate
        frmMcMcOpenLate.TopLevel = False
        frmMcMcOpenLate.Dock = DockStyle.Fill
        frmMcMcOpenLate.MdiParent = Me
        Me.MainPanel.Controls.Add(frmMcMcOpenLate)
        frmMcMcOpenLate.Show()
        frmMcMcOpenLate.BringToFront()
    End Sub

    Private Sub AllocationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllocationReportToolStripMenuItem.Click
        If frmMcMcAllocation.Visible Then
            frmMcMcAllocation.BringToFront()
            Exit Sub
        End If
        frmMcMcAllocation = New McMc_StockAllocation
        frmMcMcAllocation.TopLevel = False
        frmMcMcAllocation.Dock = DockStyle.Fill
        frmMcMcAllocation.MdiParent = Me
        Me.MainPanel.Controls.Add(frmMcMcAllocation)
        frmMcMcAllocation.Show()
        frmMcMcAllocation.BringToFront()
    End Sub


End Class
