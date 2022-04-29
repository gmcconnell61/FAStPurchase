<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project_Status
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvJobs = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgSearch = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.chkMyJobs = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvPOList = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvPODetails = New System.Windows.Forms.DataGridView()
        Me.groupHeader = New System.Windows.Forms.GroupBox()
        Me.rdoNot = New System.Windows.Forms.RadioButton()
        Me.rdoAllPO = New System.Windows.Forms.RadioButton()
        Me.groupDetails = New System.Windows.Forms.GroupBox()
        Me.rdoOpenItems = New System.Windows.Forms.RadioButton()
        Me.rdoAllItems = New System.Windows.Forms.RadioButton()
        Me.dgvUnitSummary = New System.Windows.Forms.DataGridView()
        Me.lbldgvUnitSummary = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblProj = New System.Windows.Forms.Label()
        Me.lblPM = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalPOSpend = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvPODetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupHeader.SuspendLayout()
        Me.groupDetails.SuspendLayout()
        CType(Me.dgvUnitSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvJobs)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 1095)
        Me.Panel1.TabIndex = 0
        '
        'dgvJobs
        '
        Me.dgvJobs.AllowUserToAddRows = False
        Me.dgvJobs.AllowUserToDeleteRows = False
        Me.dgvJobs.AllowUserToResizeColumns = False
        Me.dgvJobs.AllowUserToResizeRows = False
        Me.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJobs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobs.Location = New System.Drawing.Point(11, 156)
        Me.dgvJobs.MultiSelect = False
        Me.dgvJobs.Name = "dgvJobs"
        Me.dgvJobs.ReadOnly = True
        Me.dgvJobs.RowHeadersVisible = False
        Me.dgvJobs.RowHeadersWidth = 45
        Me.dgvJobs.RowTemplate.Height = 27
        Me.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvJobs.Size = New System.Drawing.Size(422, 927)
        Me.dgvJobs.TabIndex = 3
        Me.dgvJobs.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.imgSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.chkMyJobs)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 138)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Projects"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FAStPurchase.My.Resources.Resources.get_info
        Me.PictureBox1.Location = New System.Drawing.Point(193, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "MyProjects are any with your name in the PM, Eng, or Sales fields." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can also " &
        "check the Fav box in the Job list to add to your favorites." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uncheck box to remo" &
        "ve from MyFavorites.")
        Me.PictureBox1.UseWaitCursor = True
        '
        'imgSearch
        '
        Me.imgSearch.Image = Global.FAStPurchase.My.Resources.Resources.search_button_without_text_md
        Me.imgSearch.Location = New System.Drawing.Point(270, 96)
        Me.imgSearch.Name = "imgSearch"
        Me.imgSearch.Size = New System.Drawing.Size(33, 27)
        Me.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSearch.TabIndex = 3
        Me.imgSearch.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(15, 96)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(249, 27)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TabStop = False
        '
        'chkMyJobs
        '
        Me.chkMyJobs.AutoSize = True
        Me.chkMyJobs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkMyJobs.Location = New System.Drawing.Point(83, 42)
        Me.chkMyJobs.Name = "chkMyJobs"
        Me.chkMyJobs.Size = New System.Drawing.Size(111, 24)
        Me.chkMyJobs.TabIndex = 0
        Me.chkMyJobs.TabStop = False
        Me.chkMyJobs.Text = "MY Projects"
        Me.chkMyJobs.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(454, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 1058)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvPOList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1004, 1025)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PO Overview"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvPOList
        '
        Me.dgvPOList.AllowUserToAddRows = False
        Me.dgvPOList.AllowUserToDeleteRows = False
        Me.dgvPOList.AllowUserToResizeColumns = False
        Me.dgvPOList.AllowUserToResizeRows = False
        Me.dgvPOList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPOList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPOList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPOList.Location = New System.Drawing.Point(3, 3)
        Me.dgvPOList.Name = "dgvPOList"
        Me.dgvPOList.ReadOnly = True
        Me.dgvPOList.RowHeadersVisible = False
        Me.dgvPOList.RowHeadersWidth = 45
        Me.dgvPOList.RowTemplate.Height = 27
        Me.dgvPOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPOList.Size = New System.Drawing.Size(998, 1019)
        Me.dgvPOList.TabIndex = 0
        Me.dgvPOList.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvPODetails)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1004, 1025)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PO Detail List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvPODetails
        '
        Me.dgvPODetails.AllowUserToAddRows = False
        Me.dgvPODetails.AllowUserToDeleteRows = False
        Me.dgvPODetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPODetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPODetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPODetails.Location = New System.Drawing.Point(3, 3)
        Me.dgvPODetails.Name = "dgvPODetails"
        Me.dgvPODetails.ReadOnly = True
        Me.dgvPODetails.RowHeadersVisible = False
        Me.dgvPODetails.RowHeadersWidth = 45
        Me.dgvPODetails.RowTemplate.Height = 27
        Me.dgvPODetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPODetails.Size = New System.Drawing.Size(998, 1019)
        Me.dgvPODetails.TabIndex = 0
        Me.dgvPODetails.TabStop = False
        '
        'groupHeader
        '
        Me.groupHeader.Controls.Add(Me.rdoNot)
        Me.groupHeader.Controls.Add(Me.rdoAllPO)
        Me.groupHeader.Location = New System.Drawing.Point(1499, 42)
        Me.groupHeader.Name = "groupHeader"
        Me.groupHeader.Size = New System.Drawing.Size(221, 110)
        Me.groupHeader.TabIndex = 2
        Me.groupHeader.TabStop = False
        Me.groupHeader.Text = "Filter By"
        '
        'rdoNot
        '
        Me.rdoNot.AutoSize = True
        Me.rdoNot.Location = New System.Drawing.Point(25, 67)
        Me.rdoNot.Name = "rdoNot"
        Me.rdoNot.Size = New System.Drawing.Size(125, 24)
        Me.rdoNot.TabIndex = 1
        Me.rdoNot.Text = "NOT Complete"
        Me.rdoNot.UseVisualStyleBackColor = True
        '
        'rdoAllPO
        '
        Me.rdoAllPO.AutoSize = True
        Me.rdoAllPO.Checked = True
        Me.rdoAllPO.Location = New System.Drawing.Point(25, 41)
        Me.rdoAllPO.Name = "rdoAllPO"
        Me.rdoAllPO.Size = New System.Drawing.Size(77, 24)
        Me.rdoAllPO.TabIndex = 0
        Me.rdoAllPO.TabStop = True
        Me.rdoAllPO.Text = "All PO's"
        Me.rdoAllPO.UseVisualStyleBackColor = True
        '
        'groupDetails
        '
        Me.groupDetails.Controls.Add(Me.rdoOpenItems)
        Me.groupDetails.Controls.Add(Me.rdoAllItems)
        Me.groupDetails.Location = New System.Drawing.Point(1493, 42)
        Me.groupDetails.Name = "groupDetails"
        Me.groupDetails.Size = New System.Drawing.Size(221, 110)
        Me.groupDetails.TabIndex = 3
        Me.groupDetails.TabStop = False
        Me.groupDetails.Text = "Filter By"
        Me.groupDetails.Visible = False
        '
        'rdoOpenItems
        '
        Me.rdoOpenItems.AutoSize = True
        Me.rdoOpenItems.Location = New System.Drawing.Point(25, 67)
        Me.rdoOpenItems.Name = "rdoOpenItems"
        Me.rdoOpenItems.Size = New System.Drawing.Size(105, 24)
        Me.rdoOpenItems.TabIndex = 1
        Me.rdoOpenItems.Text = "OPEN Items"
        Me.rdoOpenItems.UseVisualStyleBackColor = True
        '
        'rdoAllItems
        '
        Me.rdoAllItems.AutoSize = True
        Me.rdoAllItems.Checked = True
        Me.rdoAllItems.Location = New System.Drawing.Point(25, 41)
        Me.rdoAllItems.Name = "rdoAllItems"
        Me.rdoAllItems.Size = New System.Drawing.Size(85, 24)
        Me.rdoAllItems.TabIndex = 0
        Me.rdoAllItems.TabStop = True
        Me.rdoAllItems.Text = "All Items"
        Me.rdoAllItems.UseVisualStyleBackColor = True
        '
        'dgvUnitSummary
        '
        Me.dgvUnitSummary.AllowUserToAddRows = False
        Me.dgvUnitSummary.AllowUserToDeleteRows = False
        Me.dgvUnitSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnitSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUnitSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnitSummary.Location = New System.Drawing.Point(1499, 227)
        Me.dgvUnitSummary.Name = "dgvUnitSummary"
        Me.dgvUnitSummary.ReadOnly = True
        Me.dgvUnitSummary.RowHeadersVisible = False
        Me.dgvUnitSummary.RowHeadersWidth = 45
        Me.dgvUnitSummary.RowTemplate.Height = 27
        Me.dgvUnitSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnitSummary.Size = New System.Drawing.Size(382, 350)
        Me.dgvUnitSummary.TabIndex = 3
        Me.dgvUnitSummary.TabStop = False
        '
        'lbldgvUnitSummary
        '
        Me.lbldgvUnitSummary.AutoSize = True
        Me.lbldgvUnitSummary.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbldgvUnitSummary.Location = New System.Drawing.Point(1502, 201)
        Me.lbldgvUnitSummary.Name = "lbldgvUnitSummary"
        Me.lbldgvUnitSummary.Size = New System.Drawing.Size(203, 20)
        Me.lbldgvUnitSummary.TabIndex = 4
        Me.lbldgvUnitSummary.Text = "PO Summary Spend by Unit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSales)
        Me.GroupBox3.Controls.Add(Me.lblProj)
        Me.GroupBox3.Controls.Add(Me.lblPM)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(1499, 742)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(382, 132)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Project Team"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSales.Location = New System.Drawing.Point(161, 97)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(25, 20)
        Me.lblSales.TabIndex = 5
        Me.lblSales.Text = "xx"
        '
        'lblProj
        '
        Me.lblProj.AutoSize = True
        Me.lblProj.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProj.Location = New System.Drawing.Point(161, 66)
        Me.lblProj.Name = "lblProj"
        Me.lblProj.Size = New System.Drawing.Size(25, 20)
        Me.lblProj.TabIndex = 4
        Me.lblProj.Text = "xx"
        '
        'lblPM
        '
        Me.lblPM.AutoSize = True
        Me.lblPM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPM.Location = New System.Drawing.Point(161, 37)
        Me.lblPM.Name = "lblPM"
        Me.lblPM.Size = New System.Drawing.Size(25, 20)
        Me.lblPM.TabIndex = 3
        Me.lblPM.Text = "xx"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Salesman"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Proj Engineer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Proj Manager"
        '
        'lblTotalPOSpend
        '
        Me.lblTotalPOSpend.AutoSize = True
        Me.lblTotalPOSpend.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalPOSpend.Location = New System.Drawing.Point(1503, 580)
        Me.lblTotalPOSpend.Name = "lblTotalPOSpend"
        Me.lblTotalPOSpend.Size = New System.Drawing.Size(115, 20)
        Me.lblTotalPOSpend.TabIndex = 6
        Me.lblTotalPOSpend.Text = "Total PO Spend"
        Me.lblTotalPOSpend.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Project_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.lblTotalPOSpend)
        Me.Controls.Add(Me.groupDetails)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbldgvUnitSummary)
        Me.Controls.Add(Me.dgvUnitSummary)
        Me.Controls.Add(Me.groupHeader)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Project_Status"
        Me.Text = "Project_Status"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvPOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvPODetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupHeader.ResumeLayout(False)
        Me.groupHeader.PerformLayout()
        Me.groupDetails.ResumeLayout(False)
        Me.groupDetails.PerformLayout()
        CType(Me.dgvUnitSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents chkMyJobs As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvPOList As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvPODetails As DataGridView
    Friend WithEvents groupHeader As GroupBox
    Friend WithEvents rdoNot As RadioButton
    Friend WithEvents rdoAllPO As RadioButton
    Friend WithEvents dgvUnitSummary As DataGridView
    Friend WithEvents lbldgvUnitSummary As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblSales As Label
    Friend WithEvents lblProj As Label
    Friend WithEvents lblPM As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvJobs As DataGridView
    Friend WithEvents groupDetails As GroupBox
    Friend WithEvents rdoOpenItems As RadioButton
    Friend WithEvents rdoAllItems As RadioButton
    Friend WithEvents lblTotalPOSpend As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
