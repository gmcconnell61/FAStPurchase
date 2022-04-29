<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class McMc_OpenLate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.rdoPartNo = New System.Windows.Forms.RadioButton()
        Me.rdoJob = New System.Windows.Forms.RadioButton()
        Me.btnGetFile = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvFASOpen = New System.Windows.Forms.DataGridView()
        Me.dgvOpenLate = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvFASOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOpenLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnGetFile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 124)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(927, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mc-Mc Open Order - Late Ship Dates"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Controls.Add(Me.rdoPartNo)
        Me.GroupBox1.Controls.Add(Me.rdoJob)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Results"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(499, 37)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 30)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset Filter"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGo.Location = New System.Drawing.Point(435, 37)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(38, 31)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Location = New System.Drawing.Point(148, 40)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(270, 27)
        Me.txtFilter.TabIndex = 2
        '
        'rdoPartNo
        '
        Me.rdoPartNo.AutoSize = True
        Me.rdoPartNo.Location = New System.Drawing.Point(20, 67)
        Me.rdoPartNo.Name = "rdoPartNo"
        Me.rdoPartNo.Size = New System.Drawing.Size(110, 24)
        Me.rdoPartNo.TabIndex = 1
        Me.rdoPartNo.Text = "Part Number"
        Me.rdoPartNo.UseVisualStyleBackColor = True
        '
        'rdoJob
        '
        Me.rdoJob.AutoSize = True
        Me.rdoJob.Checked = True
        Me.rdoJob.Location = New System.Drawing.Point(20, 26)
        Me.rdoJob.Name = "rdoJob"
        Me.rdoJob.Size = New System.Drawing.Size(83, 24)
        Me.rdoJob.TabIndex = 0
        Me.rdoJob.TabStop = True
        Me.rdoJob.Text = "Job / PO"
        Me.rdoJob.UseVisualStyleBackColor = True
        '
        'btnGetFile
        '
        Me.btnGetFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGetFile.Location = New System.Drawing.Point(25, 26)
        Me.btnGetFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetFile.Name = "btnGetFile"
        Me.btnGetFile.Size = New System.Drawing.Size(140, 44)
        Me.btnGetFile.TabIndex = 0
        Me.btnGetFile.Text = "Get New File"
        Me.btnGetFile.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvFASOpen)
        Me.Panel2.Controls.Add(Me.dgvOpenLate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1904, 971)
        Me.Panel2.TabIndex = 5
        '
        'dgvFASOpen
        '
        Me.dgvFASOpen.AllowUserToAddRows = False
        Me.dgvFASOpen.AllowUserToDeleteRows = False
        Me.dgvFASOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFASOpen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFASOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFASOpen.Location = New System.Drawing.Point(1050, 0)
        Me.dgvFASOpen.Name = "dgvFASOpen"
        Me.dgvFASOpen.RowHeadersVisible = False
        Me.dgvFASOpen.RowHeadersWidth = 45
        Me.dgvFASOpen.RowTemplate.Height = 27
        Me.dgvFASOpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFASOpen.Size = New System.Drawing.Size(842, 949)
        Me.dgvFASOpen.TabIndex = 3
        '
        'dgvOpenLate
        '
        Me.dgvOpenLate.AllowUserToAddRows = False
        Me.dgvOpenLate.AllowUserToDeleteRows = False
        Me.dgvOpenLate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOpenLate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOpenLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpenLate.Location = New System.Drawing.Point(0, 0)
        Me.dgvOpenLate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvOpenLate.Name = "dgvOpenLate"
        Me.dgvOpenLate.ReadOnly = True
        Me.dgvOpenLate.RowHeadersVisible = False
        Me.dgvOpenLate.RowHeadersWidth = 45
        Me.dgvOpenLate.RowTemplate.Height = 27
        Me.dgvOpenLate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOpenLate.Size = New System.Drawing.Size(952, 949)
        Me.dgvOpenLate.TabIndex = 2
        '
        'McMc_OpenLate
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "McMc_OpenLate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "McMc_OpenLate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvFASOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOpenLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents rdoPartNo As RadioButton
    Friend WithEvents rdoJob As RadioButton
    Friend WithEvents btnGetFile As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvOpenLate As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvFASOpen As DataGridView
End Class
