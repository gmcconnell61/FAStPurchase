<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POLateUpdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNewDate = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblJob = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.lblRec = New System.Windows.Forms.Label()
        Me.lblvRow = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblPartNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(61, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Expected Receive Date"
        '
        'dtpNewDate
        '
        Me.dtpNewDate.Location = New System.Drawing.Point(46, 57)
        Me.dtpNewDate.Name = "dtpNewDate"
        Me.dtpNewDate.Size = New System.Drawing.Size(243, 27)
        Me.dtpNewDate.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.Location = New System.Drawing.Point(108, 101)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 36)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblJob
        '
        Me.lblJob.AutoSize = True
        Me.lblJob.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJob.Location = New System.Drawing.Point(13, 185)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(43, 15)
        Me.lblJob.TabIndex = 3
        Me.lblJob.Text = "job_no"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUnit.Location = New System.Drawing.Point(13, 200)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(47, 15)
        Me.lblUnit.TabIndex = 4
        Me.lblUnit.Text = "unit_no"
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPO.Location = New System.Drawing.Point(13, 215)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(40, 15)
        Me.lblPO.TabIndex = 5
        Me.lblPO.Text = "po_no"
        '
        'lblRec
        '
        Me.lblRec.AutoSize = True
        Me.lblRec.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRec.Location = New System.Drawing.Point(13, 230)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(42, 15)
        Me.lblRec.TabIndex = 6
        Me.lblRec.Text = "rec_no"
        '
        'lblvRow
        '
        Me.lblvRow.AutoSize = True
        Me.lblvRow.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblvRow.Location = New System.Drawing.Point(13, 245)
        Me.lblvRow.Name = "lblvRow"
        Me.lblvRow.Size = New System.Drawing.Size(36, 15)
        Me.lblvRow.TabIndex = 7
        Me.lblvRow.Text = "vRow"
        '
        'lblVendor
        '
        Me.lblVendor.AutoSize = True
        Me.lblVendor.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblVendor.Location = New System.Drawing.Point(10, 260)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(44, 15)
        Me.lblVendor.TabIndex = 8
        Me.lblVendor.Text = "Vendor"
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDueDate.Location = New System.Drawing.Point(12, 275)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(52, 15)
        Me.lblDueDate.TabIndex = 9
        Me.lblDueDate.Text = "DueDate"
        '
        'lblPartNo
        '
        Me.lblPartNo.AutoSize = True
        Me.lblPartNo.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPartNo.Location = New System.Drawing.Point(12, 290)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(44, 15)
        Me.lblPartNo.TabIndex = 10
        Me.lblPartNo.Text = "PartNo"
        '
        'POLateUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(330, 165)
        Me.Controls.Add(Me.lblPartNo)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.lblVendor)
        Me.Controls.Add(Me.lblvRow)
        Me.Controls.Add(Me.lblRec)
        Me.Controls.Add(Me.lblPO)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblJob)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpNewDate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "POLateUpdate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POLateUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpNewDate As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblJob As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblPO As Label
    Friend WithEvents lblRec As Label
    Friend WithEvents lblvRow As Label
    Friend WithEvents lblVendor As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblPartNo As Label
End Class
