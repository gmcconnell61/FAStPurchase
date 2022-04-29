<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Open_FabSub
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblRequestor = New System.Windows.Forms.Label()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblPONo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPONote = New System.Windows.Forms.TextBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.dgvSubcontractor = New System.Windows.Forms.DataGridView()
        Me.lblFab = New System.Windows.Forms.Label()
        Me.dgvFabrication = New System.Windows.Forms.DataGridView()
        Me.txtPOTotal = New System.Windows.Forms.TextBox()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSubcontractor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFabrication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRequestor
        '
        Me.lblRequestor.AutoSize = True
        Me.lblRequestor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRequestor.Location = New System.Drawing.Point(531, 654)
        Me.lblRequestor.Name = "lblRequestor"
        Me.lblRequestor.Size = New System.Drawing.Size(90, 20)
        Me.lblRequestor.TabIndex = 29
        Me.lblRequestor.Text = "Requestor: "
        '
        'dgvDetails
        '
        Me.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Location = New System.Drawing.Point(531, 681)
        Me.dgvDetails.MultiSelect = False
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.RowHeadersWidth = 45
        Me.dgvDetails.RowTemplate.Height = 27
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.Size = New System.Drawing.Size(980, 405)
        Me.dgvDetails.TabIndex = 27
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox2.Location = New System.Drawing.Point(179, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(102, 24)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "cc R. Kelley"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(179, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 24)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "cc R. Thompson"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAdd.Location = New System.Drawing.Point(6, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 36)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Note"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblPONo
        '
        Me.lblPONo.AutoSize = True
        Me.lblPONo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPONo.Location = New System.Drawing.Point(531, 630)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(81, 20)
        Me.lblPONo.TabIndex = 28
        Me.lblPONo.Text = "PO Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 636)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 100)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Notes"
        '
        'txtPONote
        '
        Me.txtPONote.BackColor = System.Drawing.Color.Cornsilk
        Me.txtPONote.Location = New System.Drawing.Point(12, 734)
        Me.txtPONote.Multiline = True
        Me.txtPONote.Name = "txtPONote"
        Me.txtPONote.Size = New System.Drawing.Size(497, 348)
        Me.txtPONote.TabIndex = 25
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSub.Location = New System.Drawing.Point(776, 13)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(199, 20)
        Me.lblSub.TabIndex = 18
        Me.lblSub.Text = "Subcontractor PO List - xxx"
        '
        'dgvSubcontractor
        '
        Me.dgvSubcontractor.AllowUserToAddRows = False
        Me.dgvSubcontractor.AllowUserToDeleteRows = False
        Me.dgvSubcontractor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubcontractor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSubcontractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubcontractor.Location = New System.Drawing.Point(776, 39)
        Me.dgvSubcontractor.MultiSelect = False
        Me.dgvSubcontractor.Name = "dgvSubcontractor"
        Me.dgvSubcontractor.ReadOnly = True
        Me.dgvSubcontractor.RowHeadersVisible = False
        Me.dgvSubcontractor.RowHeadersWidth = 45
        Me.dgvSubcontractor.RowTemplate.Height = 27
        Me.dgvSubcontractor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubcontractor.Size = New System.Drawing.Size(735, 581)
        Me.dgvSubcontractor.TabIndex = 17
        '
        'lblFab
        '
        Me.lblFab.AutoSize = True
        Me.lblFab.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFab.Location = New System.Drawing.Point(12, 13)
        Me.lblFab.Name = "lblFab"
        Me.lblFab.Size = New System.Drawing.Size(178, 20)
        Me.lblFab.TabIndex = 16
        Me.lblFab.Text = "Fabrication PO List - xxx"
        '
        'dgvFabrication
        '
        Me.dgvFabrication.AllowUserToAddRows = False
        Me.dgvFabrication.AllowUserToDeleteRows = False
        Me.dgvFabrication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFabrication.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvFabrication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFabrication.Location = New System.Drawing.Point(12, 39)
        Me.dgvFabrication.MultiSelect = False
        Me.dgvFabrication.Name = "dgvFabrication"
        Me.dgvFabrication.ReadOnly = True
        Me.dgvFabrication.RowHeadersVisible = False
        Me.dgvFabrication.RowHeadersWidth = 45
        Me.dgvFabrication.RowTemplate.Height = 27
        Me.dgvFabrication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFabrication.Size = New System.Drawing.Size(735, 581)
        Me.dgvFabrication.TabIndex = 15
        '
        'txtPOTotal
        '
        Me.txtPOTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPOTotal.Location = New System.Drawing.Point(1369, 651)
        Me.txtPOTotal.Name = "txtPOTotal"
        Me.txtPOTotal.ReadOnly = True
        Me.txtPOTotal.Size = New System.Drawing.Size(142, 27)
        Me.txtPOTotal.TabIndex = 30
        Me.txtPOTotal.TabStop = False
        Me.txtPOTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Open_FabSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.txtPOTotal)
        Me.Controls.Add(Me.lblRequestor)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.lblPONo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPONote)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.dgvSubcontractor)
        Me.Controls.Add(Me.lblFab)
        Me.Controls.Add(Me.dgvFabrication)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Open_FabSub"
        Me.Text = "Open_FabSub"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSubcontractor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFabrication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRequestor As Label
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblPONo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPONote As TextBox
    Friend WithEvents lblSub As Label
    Friend WithEvents dgvSubcontractor As DataGridView
    Friend WithEvents lblFab As Label
    Friend WithEvents dgvFabrication As DataGridView
    Friend WithEvents txtPOTotal As TextBox
End Class
