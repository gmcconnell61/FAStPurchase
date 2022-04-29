<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FabricationSubcontractorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenItemQueryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.McMcWeeklyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLateReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllocationReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobLookUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllOpenProjectsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcessMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.YTDSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YTDSummaryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MFGVolumeQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REFRESHDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.OpenOrdersToolStripMenuItem, Me.McMcWeeklyReportsToolStripMenuItem, Me.ProjectsToolStripMenuItem, Me.ExcessMaterialToolStripMenuItem, Me.ReceivingToolStripMenuItem, Me.YTDSummaryToolStripMenuItem, Me.REFRESHDataToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1904, 28)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'OpenOrdersToolStripMenuItem
        '
        Me.OpenOrdersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllOpenToolStripMenuItem, Me.FabricationSubcontractorToolStripMenuItem, Me.OpenItemQueryToolStripMenuItem1})
        Me.OpenOrdersToolStripMenuItem.Name = "OpenOrdersToolStripMenuItem"
        Me.OpenOrdersToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.OpenOrdersToolStripMenuItem.Text = "Open Orders"
        '
        'AllOpenToolStripMenuItem
        '
        Me.AllOpenToolStripMenuItem.Name = "AllOpenToolStripMenuItem"
        Me.AllOpenToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.AllOpenToolStripMenuItem.Text = "All Open"
        '
        'FabricationSubcontractorToolStripMenuItem
        '
        Me.FabricationSubcontractorToolStripMenuItem.Name = "FabricationSubcontractorToolStripMenuItem"
        Me.FabricationSubcontractorToolStripMenuItem.Size = New System.Drawing.Size(270, 24)
        Me.FabricationSubcontractorToolStripMenuItem.Text = "Fabrication && Subcontractor"
        '
        'OpenItemQueryToolStripMenuItem1
        '
        Me.OpenItemQueryToolStripMenuItem1.Name = "OpenItemQueryToolStripMenuItem1"
        Me.OpenItemQueryToolStripMenuItem1.Size = New System.Drawing.Size(270, 24)
        Me.OpenItemQueryToolStripMenuItem1.Text = "Open Item Query"
        '
        'McMcWeeklyReportsToolStripMenuItem
        '
        Me.McMcWeeklyReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenLateReportToolStripMenuItem1, Me.AllocationReportToolStripMenuItem})
        Me.McMcWeeklyReportsToolStripMenuItem.Name = "McMcWeeklyReportsToolStripMenuItem"
        Me.McMcWeeklyReportsToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.McMcWeeklyReportsToolStripMenuItem.Text = "Mc-Mc Weekly Reports"
        '
        'OpenLateReportToolStripMenuItem1
        '
        Me.OpenLateReportToolStripMenuItem1.Name = "OpenLateReportToolStripMenuItem1"
        Me.OpenLateReportToolStripMenuItem1.Size = New System.Drawing.Size(217, 24)
        Me.OpenLateReportToolStripMenuItem1.Text = "Open && Late Report"
        '
        'AllocationReportToolStripMenuItem
        '
        Me.AllocationReportToolStripMenuItem.Name = "AllocationReportToolStripMenuItem"
        Me.AllocationReportToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.AllocationReportToolStripMenuItem.Text = "Allocation Report"
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectStatusToolStripMenuItem, Me.JobLookUpToolStripMenuItem, Me.AllOpenProjectsToolStripMenuItem1})
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ProjectsToolStripMenuItem.Text = "Projects"
        '
        'ProjectStatusToolStripMenuItem
        '
        Me.ProjectStatusToolStripMenuItem.Name = "ProjectStatusToolStripMenuItem"
        Me.ProjectStatusToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ProjectStatusToolStripMenuItem.Text = "Project Status"
        '
        'JobLookUpToolStripMenuItem
        '
        Me.JobLookUpToolStripMenuItem.Name = "JobLookUpToolStripMenuItem"
        Me.JobLookUpToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.JobLookUpToolStripMenuItem.Text = "Project LookUp"
        '
        'AllOpenProjectsToolStripMenuItem1
        '
        Me.AllOpenProjectsToolStripMenuItem1.Name = "AllOpenProjectsToolStripMenuItem1"
        Me.AllOpenProjectsToolStripMenuItem1.Size = New System.Drawing.Size(198, 24)
        Me.AllOpenProjectsToolStripMenuItem1.Text = "All Open Projects"
        '
        'ExcessMaterialToolStripMenuItem
        '
        Me.ExcessMaterialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransferItemsToolStripMenuItem, Me.ManageDatabaseToolStripMenuItem})
        Me.ExcessMaterialToolStripMenuItem.Name = "ExcessMaterialToolStripMenuItem"
        Me.ExcessMaterialToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.ExcessMaterialToolStripMenuItem.Text = "Excess Material"
        '
        'TransferItemsToolStripMenuItem
        '
        Me.TransferItemsToolStripMenuItem.Name = "TransferItemsToolStripMenuItem"
        Me.TransferItemsToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.TransferItemsToolStripMenuItem.Text = "Transfer Items"
        '
        'ManageDatabaseToolStripMenuItem
        '
        Me.ManageDatabaseToolStripMenuItem.Name = "ManageDatabaseToolStripMenuItem"
        Me.ManageDatabaseToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.ManageDatabaseToolStripMenuItem.Text = "Manage Database"
        '
        'ReceivingToolStripMenuItem
        '
        Me.ReceivingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QueryToolStripMenuItem1})
        Me.ReceivingToolStripMenuItem.Name = "ReceivingToolStripMenuItem"
        Me.ReceivingToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.ReceivingToolStripMenuItem.Text = "Receiving"
        '
        'QueryToolStripMenuItem1
        '
        Me.QueryToolStripMenuItem1.Name = "QueryToolStripMenuItem1"
        Me.QueryToolStripMenuItem1.Size = New System.Drawing.Size(123, 24)
        Me.QueryToolStripMenuItem1.Text = "Query"
        '
        'YTDSummaryToolStripMenuItem
        '
        Me.YTDSummaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YTDSummaryToolStripMenuItem1, Me.MFGVolumeQueryToolStripMenuItem})
        Me.YTDSummaryToolStripMenuItem.Name = "YTDSummaryToolStripMenuItem"
        Me.YTDSummaryToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.YTDSummaryToolStripMenuItem.Text = "Vendor"
        '
        'YTDSummaryToolStripMenuItem1
        '
        Me.YTDSummaryToolStripMenuItem1.Name = "YTDSummaryToolStripMenuItem1"
        Me.YTDSummaryToolStripMenuItem1.Size = New System.Drawing.Size(211, 24)
        Me.YTDSummaryToolStripMenuItem1.Text = "YTD Summary"
        '
        'MFGVolumeQueryToolStripMenuItem
        '
        Me.MFGVolumeQueryToolStripMenuItem.Name = "MFGVolumeQueryToolStripMenuItem"
        Me.MFGVolumeQueryToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.MFGVolumeQueryToolStripMenuItem.Text = "MFG Volume Query"
        '
        'REFRESHDataToolStripMenuItem
        '
        Me.REFRESHDataToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod
        Me.REFRESHDataToolStripMenuItem.Name = "REFRESHDataToolStripMenuItem"
        Me.REFRESHDataToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.REFRESHDataToolStripMenuItem.Text = "REFRESH Data"
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 28)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1904, 1011)
        Me.MainPanel.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1039)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MainMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "Main"
        Me.Text = "Purchasing Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents OpenOrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllOpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FabricationSubcontractorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenItemQueryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JobLookUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcessMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YTDSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YTDSummaryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MFGVolumeQueryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REFRESHDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MainPanel As Panel
    Friend WithEvents AllOpenProjectsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransferItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents McMcWeeklyReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenLateReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AllocationReportToolStripMenuItem As ToolStripMenuItem
End Class
