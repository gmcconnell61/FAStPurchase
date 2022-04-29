<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Open_ItemQuery
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAvgDaysOpen = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalReceived = New System.Windows.Forms.Label()
        Me.lblTotalOrdered = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCatalogNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMfg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJobNo = New System.Windows.Forms.TextBox()
        Me.dgvOpenQuery = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOpenQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotalValue)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblAvgDaysOpen)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblTotalReceived)
        Me.Panel1.Controls.Add(Me.lblTotalOrdered)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1904, 155)
        Me.Panel1.TabIndex = 0
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalValue.Location = New System.Drawing.Point(1716, 71)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalValue.TabIndex = 8
        Me.lblTotalValue.Text = "$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(1572, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total Open Value:"
        '
        'lblAvgDaysOpen
        '
        Me.lblAvgDaysOpen.AutoSize = True
        Me.lblAvgDaysOpen.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAvgDaysOpen.Location = New System.Drawing.Point(1483, 122)
        Me.lblAvgDaysOpen.Name = "lblAvgDaysOpen"
        Me.lblAvgDaysOpen.Size = New System.Drawing.Size(16, 20)
        Me.lblAvgDaysOpen.TabIndex = 6
        Me.lblAvgDaysOpen.Text = "z"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(1355, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Avg Days Open:"
        '
        'lblTotalReceived
        '
        Me.lblTotalReceived.AutoSize = True
        Me.lblTotalReceived.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalReceived.Location = New System.Drawing.Point(1483, 96)
        Me.lblTotalReceived.Name = "lblTotalReceived"
        Me.lblTotalReceived.Size = New System.Drawing.Size(17, 20)
        Me.lblTotalReceived.TabIndex = 4
        Me.lblTotalReceived.Text = "y"
        '
        'lblTotalOrdered
        '
        Me.lblTotalOrdered.AutoSize = True
        Me.lblTotalOrdered.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalOrdered.Location = New System.Drawing.Point(1483, 71)
        Me.lblTotalOrdered.Name = "lblTotalOrdered"
        Me.lblTotalOrdered.Size = New System.Drawing.Size(17, 20)
        Me.lblTotalOrdered.TabIndex = 3
        Me.lblTotalOrdered.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1355, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Received:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1355, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Ordered:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShowAll)
        Me.GroupBox1.Controls.Add(Me.btnQuery)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCatalogNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMfg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtVendor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtJobNo)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1276, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'btnShowAll
        '
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShowAll.Location = New System.Drawing.Point(1146, 53)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(83, 39)
        Me.btnShowAll.TabIndex = 6
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuery.Location = New System.Drawing.Point(1037, 53)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(83, 39)
        Me.btnQuery.TabIndex = 5
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(781, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Part Description"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(778, 59)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(219, 27)
        Me.txtDescription.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(553, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Part Number"
        '
        'txtCatalogNo
        '
        Me.txtCatalogNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCatalogNo.Location = New System.Drawing.Point(550, 59)
        Me.txtCatalogNo.Name = "txtCatalogNo"
        Me.txtCatalogNo.Size = New System.Drawing.Size(219, 27)
        Me.txtCatalogNo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(325, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Manufacturer"
        '
        'txtMfg
        '
        Me.txtMfg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMfg.Location = New System.Drawing.Point(322, 59)
        Me.txtMfg.Name = "txtMfg"
        Me.txtMfg.Size = New System.Drawing.Size(219, 27)
        Me.txtMfg.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(96, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vendor"
        '
        'txtVendor
        '
        Me.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendor.Location = New System.Drawing.Point(93, 59)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(219, 27)
        Me.txtVendor.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(17, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Job"
        '
        'txtJobNo
        '
        Me.txtJobNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobNo.Location = New System.Drawing.Point(14, 60)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(70, 27)
        Me.txtJobNo.TabIndex = 0
        '
        'dgvOpenQuery
        '
        Me.dgvOpenQuery.AllowUserToAddRows = False
        Me.dgvOpenQuery.AllowUserToDeleteRows = False
        Me.dgvOpenQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOpenQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpenQuery.Location = New System.Drawing.Point(18, 155)
        Me.dgvOpenQuery.Name = "dgvOpenQuery"
        Me.dgvOpenQuery.ReadOnly = True
        Me.dgvOpenQuery.RowHeadersVisible = False
        Me.dgvOpenQuery.RowHeadersWidth = 45
        Me.dgvOpenQuery.RowTemplate.Height = 27
        Me.dgvOpenQuery.Size = New System.Drawing.Size(1892, 928)
        Me.dgvOpenQuery.TabIndex = 1
        Me.dgvOpenQuery.TabStop = False
        '
        'Open_ItemQuery
        '
        Me.AcceptButton = Me.btnQuery
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1904, 1095)
        Me.Controls.Add(Me.dgvOpenQuery)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Open_ItemQuery"
        Me.Text = "Open_ItemQuery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvOpenQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalReceived As Label
    Friend WithEvents lblTotalOrdered As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvOpenQuery As DataGridView
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnQuery As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCatalogNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMfg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJobNo As TextBox
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAvgDaysOpen As Label
    Friend WithEvents Label9 As Label
End Class
