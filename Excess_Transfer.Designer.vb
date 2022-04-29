<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Excess_Transfer
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
        Me.dgvExcessRequest = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvExcessDetails = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPendingRequests = New System.Windows.Forms.Label()
        Me.btnOpenRequests = New System.Windows.Forms.Button()
        CType(Me.dgvExcessRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExcessDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExcessRequest
        '
        Me.dgvExcessRequest.AllowUserToAddRows = False
        Me.dgvExcessRequest.AllowUserToDeleteRows = False
        Me.dgvExcessRequest.AllowUserToResizeColumns = False
        Me.dgvExcessRequest.AllowUserToResizeRows = False
        Me.dgvExcessRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExcessRequest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExcessRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcessRequest.Location = New System.Drawing.Point(12, 172)
        Me.dgvExcessRequest.MultiSelect = False
        Me.dgvExcessRequest.Name = "dgvExcessRequest"
        Me.dgvExcessRequest.RowHeadersVisible = False
        Me.dgvExcessRequest.RowHeadersWidth = 45
        Me.dgvExcessRequest.RowTemplate.Height = 27
        Me.dgvExcessRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvExcessRequest.Size = New System.Drawing.Size(564, 290)
        Me.dgvExcessRequest.TabIndex = 0
        Me.dgvExcessRequest.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(15, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Excess Transfer Requests"
        Me.Label1.Visible = False
        '
        'dgvExcessDetails
        '
        Me.dgvExcessDetails.AllowUserToAddRows = False
        Me.dgvExcessDetails.AllowUserToDeleteRows = False
        Me.dgvExcessDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExcessDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvExcessDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcessDetails.Location = New System.Drawing.Point(15, 511)
        Me.dgvExcessDetails.Name = "dgvExcessDetails"
        Me.dgvExcessDetails.RowHeadersVisible = False
        Me.dgvExcessDetails.RowHeadersWidth = 45
        Me.dgvExcessDetails.RowTemplate.Height = 27
        Me.dgvExcessDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvExcessDetails.Size = New System.Drawing.Size(561, 363)
        Me.dgvExcessDetails.TabIndex = 2
        Me.dgvExcessDetails.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(15, 486)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Excess Request Details"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(15, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pending Requests"
        '
        'lblPendingRequests
        '
        Me.lblPendingRequests.AutoSize = True
        Me.lblPendingRequests.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPendingRequests.Location = New System.Drawing.Point(201, 22)
        Me.lblPendingRequests.Name = "lblPendingRequests"
        Me.lblPendingRequests.Size = New System.Drawing.Size(21, 24)
        Me.lblPendingRequests.TabIndex = 5
        Me.lblPendingRequests.Text = "x"
        '
        'btnOpenRequests
        '
        Me.btnOpenRequests.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenRequests.Location = New System.Drawing.Point(244, 18)
        Me.btnOpenRequests.Name = "btnOpenRequests"
        Me.btnOpenRequests.Size = New System.Drawing.Size(75, 35)
        Me.btnOpenRequests.TabIndex = 6
        Me.btnOpenRequests.Text = "Open"
        Me.btnOpenRequests.UseVisualStyleBackColor = True
        Me.btnOpenRequests.Visible = False
        '
        'Excess_Transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.btnOpenRequests)
        Me.Controls.Add(Me.lblPendingRequests)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvExcessDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvExcessRequest)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Excess_Transfer"
        Me.Text = "Excess_Transfer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvExcessRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExcessDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvExcessRequest As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvExcessDetails As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPendingRequests As Label
    Friend WithEvents btnOpenRequests As Button
End Class
