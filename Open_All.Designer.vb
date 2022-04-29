<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Open_All
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvOpen = New System.Windows.Forms.DataGridView()
        Me.lblOpen = New System.Windows.Forms.Label()
        Me.lblLate = New System.Windows.Forms.Label()
        Me.lblRFQ = New System.Windows.Forms.Label()
        Me.dgvRFQ = New System.Windows.Forms.DataGridView()
        Me.lblNotAck = New System.Windows.Forms.Label()
        Me.dgvNot = New System.Windows.Forms.DataGridView()
        Me.lblUnknown = New System.Windows.Forms.Label()
        Me.dgvUnknown = New System.Windows.Forms.DataGridView()
        Me.txtPONote = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCopyMech = New System.Windows.Forms.CheckBox()
        Me.chkCopyElec = New System.Windows.Forms.CheckBox()
        Me.btnAddNote = New System.Windows.Forms.Button()
        Me.btnSaveNote = New System.Windows.Forms.Button()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.lblPONo = New System.Windows.Forms.Label()
        Me.lblRequestor = New System.Windows.Forms.Label()
        Me.txtPOTotal = New System.Windows.Forms.TextBox()
        Me.lblShipComplete = New System.Windows.Forms.Label()
        Me.dgvLate = New System.Windows.Forms.DataGridView()
        Me.lblPODueDate = New System.Windows.Forms.Label()
        CType(Me.dgvOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRFQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUnknown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOpen
        '
        Me.dgvOpen.AllowUserToAddRows = False
        Me.dgvOpen.AllowUserToDeleteRows = False
        Me.dgvOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOpen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpen.Location = New System.Drawing.Point(12, 39)
        Me.dgvOpen.MultiSelect = False
        Me.dgvOpen.Name = "dgvOpen"
        Me.dgvOpen.ReadOnly = True
        Me.dgvOpen.RowHeadersVisible = False
        Me.dgvOpen.RowHeadersWidth = 45
        Me.dgvOpen.RowTemplate.Height = 27
        Me.dgvOpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOpen.Size = New System.Drawing.Size(735, 581)
        Me.dgvOpen.TabIndex = 0
        '
        'lblOpen
        '
        Me.lblOpen.AutoSize = True
        Me.lblOpen.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOpen.Location = New System.Drawing.Point(12, 13)
        Me.lblOpen.Name = "lblOpen"
        Me.lblOpen.Size = New System.Drawing.Size(137, 20)
        Me.lblOpen.TabIndex = 1
        Me.lblOpen.Text = "Open PO List - xxx"
        '
        'lblLate
        '
        Me.lblLate.AutoSize = True
        Me.lblLate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLate.Location = New System.Drawing.Point(776, 13)
        Me.lblLate.Name = "lblLate"
        Me.lblLate.Size = New System.Drawing.Size(128, 20)
        Me.lblLate.TabIndex = 3
        Me.lblLate.Text = "Late Orders - xxx"
        '
        'lblRFQ
        '
        Me.lblRFQ.AutoSize = True
        Me.lblRFQ.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRFQ.Location = New System.Drawing.Point(1535, 13)
        Me.lblRFQ.Name = "lblRFQ"
        Me.lblRFQ.Size = New System.Drawing.Size(76, 20)
        Me.lblRFQ.TabIndex = 5
        Me.lblRFQ.Text = "RFQ - xxx"
        '
        'dgvRFQ
        '
        Me.dgvRFQ.AllowUserToAddRows = False
        Me.dgvRFQ.AllowUserToDeleteRows = False
        Me.dgvRFQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRFQ.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRFQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRFQ.Location = New System.Drawing.Point(1535, 39)
        Me.dgvRFQ.MultiSelect = False
        Me.dgvRFQ.Name = "dgvRFQ"
        Me.dgvRFQ.ReadOnly = True
        Me.dgvRFQ.RowHeadersVisible = False
        Me.dgvRFQ.RowHeadersWidth = 45
        Me.dgvRFQ.RowTemplate.Height = 27
        Me.dgvRFQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRFQ.Size = New System.Drawing.Size(357, 226)
        Me.dgvRFQ.TabIndex = 4
        '
        'lblNotAck
        '
        Me.lblNotAck.AutoSize = True
        Me.lblNotAck.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNotAck.Location = New System.Drawing.Point(1535, 290)
        Me.lblNotAck.Name = "lblNotAck"
        Me.lblNotAck.Size = New System.Drawing.Size(181, 20)
        Me.lblNotAck.TabIndex = 7
        Me.lblNotAck.Text = "Not Acknowledged - xxx"
        '
        'dgvNot
        '
        Me.dgvNot.AllowUserToAddRows = False
        Me.dgvNot.AllowUserToDeleteRows = False
        Me.dgvNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNot.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNot.Location = New System.Drawing.Point(1535, 316)
        Me.dgvNot.MultiSelect = False
        Me.dgvNot.Name = "dgvNot"
        Me.dgvNot.ReadOnly = True
        Me.dgvNot.RowHeadersVisible = False
        Me.dgvNot.RowHeadersWidth = 45
        Me.dgvNot.RowTemplate.Height = 27
        Me.dgvNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNot.Size = New System.Drawing.Size(357, 487)
        Me.dgvNot.TabIndex = 6
        '
        'lblUnknown
        '
        Me.lblUnknown.AutoSize = True
        Me.lblUnknown.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUnknown.Location = New System.Drawing.Point(1535, 827)
        Me.lblUnknown.Name = "lblUnknown"
        Me.lblUnknown.Size = New System.Drawing.Size(162, 20)
        Me.lblUnknown.TabIndex = 9
        Me.lblUnknown.Text = "Unknown Status - xxx"
        '
        'dgvUnknown
        '
        Me.dgvUnknown.AllowUserToAddRows = False
        Me.dgvUnknown.AllowUserToDeleteRows = False
        Me.dgvUnknown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUnknown.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUnknown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnknown.Location = New System.Drawing.Point(1535, 853)
        Me.dgvUnknown.MultiSelect = False
        Me.dgvUnknown.Name = "dgvUnknown"
        Me.dgvUnknown.ReadOnly = True
        Me.dgvUnknown.RowHeadersVisible = False
        Me.dgvUnknown.RowHeadersWidth = 45
        Me.dgvUnknown.RowTemplate.Height = 27
        Me.dgvUnknown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnknown.Size = New System.Drawing.Size(357, 233)
        Me.dgvUnknown.TabIndex = 8
        '
        'txtPONote
        '
        Me.txtPONote.BackColor = System.Drawing.Color.Cornsilk
        Me.txtPONote.Location = New System.Drawing.Point(12, 729)
        Me.txtPONote.Multiline = True
        Me.txtPONote.Name = "txtPONote"
        Me.txtPONote.Size = New System.Drawing.Size(497, 354)
        Me.txtPONote.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.chkCopyMech)
        Me.GroupBox1.Controls.Add(Me.chkCopyElec)
        Me.GroupBox1.Controls.Add(Me.btnAddNote)
        Me.GroupBox1.Controls.Add(Me.btnSaveNote)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 630)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Notes"
        '
        'chkCopyMech
        '
        Me.chkCopyMech.AutoSize = True
        Me.chkCopyMech.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkCopyMech.Location = New System.Drawing.Point(185, 54)
        Me.chkCopyMech.Name = "chkCopyMech"
        Me.chkCopyMech.Size = New System.Drawing.Size(102, 24)
        Me.chkCopyMech.TabIndex = 2
        Me.chkCopyMech.Text = "cc R. Kelley"
        Me.chkCopyMech.UseVisualStyleBackColor = True
        '
        'chkCopyElec
        '
        Me.chkCopyElec.AutoSize = True
        Me.chkCopyElec.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkCopyElec.Location = New System.Drawing.Point(185, 24)
        Me.chkCopyElec.Name = "chkCopyElec"
        Me.chkCopyElec.Size = New System.Drawing.Size(132, 24)
        Me.chkCopyElec.TabIndex = 1
        Me.chkCopyElec.Text = "cc R. Thompson"
        Me.chkCopyElec.UseVisualStyleBackColor = True
        '
        'btnAddNote
        '
        Me.btnAddNote.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddNote.Location = New System.Drawing.Point(11, 26)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(141, 36)
        Me.btnAddNote.TabIndex = 0
        Me.btnAddNote.Text = "Add Note"
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'btnSaveNote
        '
        Me.btnSaveNote.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSaveNote.Location = New System.Drawing.Point(11, 26)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(141, 36)
        Me.btnSaveNote.TabIndex = 3
        Me.btnSaveNote.Text = "Add Note"
        Me.btnSaveNote.UseVisualStyleBackColor = False
        Me.btnSaveNote.Visible = False
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.AllowUserToDeleteRows = False
        Me.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Location = New System.Drawing.Point(531, 681)
        Me.dgvDetails.MultiSelect = False
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.RowHeadersVisible = False
        Me.dgvDetails.RowHeadersWidth = 45
        Me.dgvDetails.RowTemplate.Height = 27
        Me.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetails.Size = New System.Drawing.Size(980, 405)
        Me.dgvDetails.TabIndex = 12
        '
        'lblPONo
        '
        Me.lblPONo.AutoSize = True
        Me.lblPONo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPONo.Location = New System.Drawing.Point(531, 630)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(81, 20)
        Me.lblPONo.TabIndex = 13
        Me.lblPONo.Text = "PO Details"
        '
        'lblRequestor
        '
        Me.lblRequestor.AutoSize = True
        Me.lblRequestor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRequestor.Location = New System.Drawing.Point(531, 654)
        Me.lblRequestor.Name = "lblRequestor"
        Me.lblRequestor.Size = New System.Drawing.Size(90, 20)
        Me.lblRequestor.TabIndex = 14
        Me.lblRequestor.Text = "Requestor: "
        '
        'txtPOTotal
        '
        Me.txtPOTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtPOTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPOTotal.Location = New System.Drawing.Point(1369, 647)
        Me.txtPOTotal.Name = "txtPOTotal"
        Me.txtPOTotal.ReadOnly = True
        Me.txtPOTotal.Size = New System.Drawing.Size(142, 27)
        Me.txtPOTotal.TabIndex = 15
        Me.txtPOTotal.TabStop = False
        Me.txtPOTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblShipComplete
        '
        Me.lblShipComplete.AutoSize = True
        Me.lblShipComplete.BackColor = System.Drawing.Color.Yellow
        Me.lblShipComplete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShipComplete.ForeColor = System.Drawing.Color.Maroon
        Me.lblShipComplete.Location = New System.Drawing.Point(1077, 654)
        Me.lblShipComplete.Name = "lblShipComplete"
        Me.lblShipComplete.Size = New System.Drawing.Size(122, 20)
        Me.lblShipComplete.TabIndex = 16
        Me.lblShipComplete.Text = "SHIP COMPLETE"
        Me.lblShipComplete.Visible = False
        '
        'dgvLate
        '
        Me.dgvLate.AllowUserToAddRows = False
        Me.dgvLate.AllowUserToDeleteRows = False
        Me.dgvLate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLate.Location = New System.Drawing.Point(776, 39)
        Me.dgvLate.MultiSelect = False
        Me.dgvLate.Name = "dgvLate"
        Me.dgvLate.ReadOnly = True
        Me.dgvLate.RowHeadersVisible = False
        Me.dgvLate.RowHeadersWidth = 45
        Me.dgvLate.RowTemplate.Height = 27
        Me.dgvLate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLate.Size = New System.Drawing.Size(735, 581)
        Me.dgvLate.TabIndex = 17
        Me.dgvLate.TabStop = False
        '
        'lblPODueDate
        '
        Me.lblPODueDate.AutoSize = True
        Me.lblPODueDate.BackColor = System.Drawing.Color.Yellow
        Me.lblPODueDate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPODueDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblPODueDate.Location = New System.Drawing.Point(857, 654)
        Me.lblPODueDate.Name = "lblPODueDate"
        Me.lblPODueDate.Size = New System.Drawing.Size(106, 20)
        Me.lblPODueDate.TabIndex = 18
        Me.lblPODueDate.Text = "PO Due Date: "
        Me.lblPODueDate.Visible = False
        '
        'Open_All
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.lblPODueDate)
        Me.Controls.Add(Me.dgvLate)
        Me.Controls.Add(Me.lblShipComplete)
        Me.Controls.Add(Me.txtPOTotal)
        Me.Controls.Add(Me.lblRequestor)
        Me.Controls.Add(Me.lblPONo)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPONote)
        Me.Controls.Add(Me.lblUnknown)
        Me.Controls.Add(Me.dgvUnknown)
        Me.Controls.Add(Me.lblNotAck)
        Me.Controls.Add(Me.dgvNot)
        Me.Controls.Add(Me.lblRFQ)
        Me.Controls.Add(Me.dgvRFQ)
        Me.Controls.Add(Me.lblLate)
        Me.Controls.Add(Me.lblOpen)
        Me.Controls.Add(Me.dgvOpen)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Open_All"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SubFormTemplate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRFQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUnknown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOpen As DataGridView
    Friend WithEvents lblOpen As Label
    Friend WithEvents lblLate As Label
    Friend WithEvents lblRFQ As Label
    Friend WithEvents dgvRFQ As DataGridView
    Friend WithEvents lblNotAck As Label
    Friend WithEvents dgvNot As DataGridView
    Friend WithEvents lblUnknown As Label
    Friend WithEvents dgvUnknown As DataGridView
    Friend WithEvents txtPONote As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCopyMech As CheckBox
    Friend WithEvents chkCopyElec As CheckBox
    Friend WithEvents btnAddNote As Button
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents lblPONo As Label
    Friend WithEvents lblRequestor As Label
    Friend WithEvents txtPOTotal As TextBox
    Friend WithEvents btnSaveNote As Button
    Friend WithEvents lblShipComplete As Label
    Friend WithEvents dgvLate As DataGridView
    Friend WithEvents lblPODueDate As Label
End Class
