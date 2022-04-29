<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project_POImage
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJob = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtShipZip = New System.Windows.Forms.TextBox()
        Me.txtShipState = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtShipCity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShipA2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtShipA1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtVZip = New System.Windows.Forms.TextBox()
        Me.txtVState = New System.Windows.Forms.TextBox()
        Me.txtVCity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVContact = New System.Windows.Forms.TextBox()
        Me.txtVA2 = New System.Windows.Forms.TextBox()
        Me.txtVA1 = New System.Windows.Forms.TextBox()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblShipComplete = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtShipVia = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDue = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFrt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReq = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBuyer = New System.Windows.Forms.TextBox()
        Me.txtPONote = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvPODetail = New System.Windows.Forms.DataGridView()
        Me.txtPOTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtvarJob = New System.Windows.Forms.TextBox()
        Me.txtvarUnit = New System.Windows.Forms.TextBox()
        Me.txtvarPO = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvPODetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUnit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtJob)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(23, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Location = New System.Drawing.Point(69, 119)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(141, 27)
        Me.txtDate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(34, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PO"
        '
        'txtPO
        '
        Me.txtPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPO.Location = New System.Drawing.Point(69, 88)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.ReadOnly = True
        Me.txtPO.Size = New System.Drawing.Size(408, 27)
        Me.txtPO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unit"
        '
        'txtUnit
        '
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Location = New System.Drawing.Point(69, 57)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(408, 27)
        Me.txtUnit.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job"
        '
        'txtJob
        '
        Me.txtJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJob.Location = New System.Drawing.Point(69, 26)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.ReadOnly = True
        Me.txtJob.Size = New System.Drawing.Size(408, 27)
        Me.txtJob.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtShipZip)
        Me.GroupBox2.Controls.Add(Me.txtShipState)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtShipCity)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtShipA2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtShipA1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtShip)
        Me.GroupBox2.Location = New System.Drawing.Point(507, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 154)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ship To"
        '
        'txtShipZip
        '
        Me.txtShipZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShipZip.Location = New System.Drawing.Point(273, 118)
        Me.txtShipZip.Name = "txtShipZip"
        Me.txtShipZip.ReadOnly = True
        Me.txtShipZip.Size = New System.Drawing.Size(63, 27)
        Me.txtShipZip.TabIndex = 9
        Me.txtShipZip.Text = "30349"
        '
        'txtShipState
        '
        Me.txtShipState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShipState.Location = New System.Drawing.Point(232, 119)
        Me.txtShipState.Name = "txtShipState"
        Me.txtShipState.ReadOnly = True
        Me.txtShipState.Size = New System.Drawing.Size(35, 27)
        Me.txtShipState.TabIndex = 8
        Me.txtShipState.Text = "GA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(6, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date"
        '
        'txtShipCity
        '
        Me.txtShipCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShipCity.Location = New System.Drawing.Point(53, 119)
        Me.txtShipCity.Name = "txtShipCity"
        Me.txtShipCity.ReadOnly = True
        Me.txtShipCity.Size = New System.Drawing.Size(170, 27)
        Me.txtShipCity.TabIndex = 6
        Me.txtShipCity.Text = "Atlanta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(17, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PO"
        '
        'txtShipA2
        '
        Me.txtShipA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShipA2.Location = New System.Drawing.Point(53, 88)
        Me.txtShipA2.Name = "txtShipA2"
        Me.txtShipA2.ReadOnly = True
        Me.txtShipA2.Size = New System.Drawing.Size(283, 27)
        Me.txtShipA2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(10, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Unit"
        '
        'txtShipA1
        '
        Me.txtShipA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShipA1.Location = New System.Drawing.Point(53, 57)
        Me.txtShipA1.Name = "txtShipA1"
        Me.txtShipA1.ReadOnly = True
        Me.txtShipA1.Size = New System.Drawing.Size(283, 27)
        Me.txtShipA1.TabIndex = 2
        Me.txtShipA1.Text = "5139 Southridge Parkway"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(13, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Job"
        '
        'txtShip
        '
        Me.txtShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShip.Location = New System.Drawing.Point(53, 26)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.ReadOnly = True
        Me.txtShip.Size = New System.Drawing.Size(283, 27)
        Me.txtShip.TabIndex = 0
        Me.txtShip.Text = "Factory Automation Systems"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtVZip)
        Me.GroupBox3.Controls.Add(Me.txtVState)
        Me.GroupBox3.Controls.Add(Me.txtVCity)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtVPhone)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtVContact)
        Me.GroupBox3.Controls.Add(Me.txtVA2)
        Me.GroupBox3.Controls.Add(Me.txtVA1)
        Me.GroupBox3.Controls.Add(Me.txtVendor)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 188)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vendor"
        '
        'txtVZip
        '
        Me.txtVZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVZip.Location = New System.Drawing.Point(286, 118)
        Me.txtVZip.Name = "txtVZip"
        Me.txtVZip.ReadOnly = True
        Me.txtVZip.Size = New System.Drawing.Size(117, 27)
        Me.txtVZip.TabIndex = 13
        '
        'txtVState
        '
        Me.txtVState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVState.Location = New System.Drawing.Point(245, 118)
        Me.txtVState.Name = "txtVState"
        Me.txtVState.ReadOnly = True
        Me.txtVState.Size = New System.Drawing.Size(35, 27)
        Me.txtVState.TabIndex = 12
        '
        'txtVCity
        '
        Me.txtVCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVCity.Location = New System.Drawing.Point(69, 118)
        Me.txtVCity.Name = "txtVCity"
        Me.txtVCity.ReadOnly = True
        Me.txtVCity.Size = New System.Drawing.Size(170, 27)
        Me.txtVCity.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(263, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Phone"
        '
        'txtVPhone
        '
        Me.txtVPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVPhone.Location = New System.Drawing.Point(320, 150)
        Me.txtVPhone.Name = "txtVPhone"
        Me.txtVPhone.ReadOnly = True
        Me.txtVPhone.Size = New System.Drawing.Size(157, 27)
        Me.txtVPhone.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(5, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Contact"
        '
        'txtVContact
        '
        Me.txtVContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVContact.Location = New System.Drawing.Point(69, 149)
        Me.txtVContact.Name = "txtVContact"
        Me.txtVContact.ReadOnly = True
        Me.txtVContact.Size = New System.Drawing.Size(170, 27)
        Me.txtVContact.TabIndex = 6
        '
        'txtVA2
        '
        Me.txtVA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVA2.Location = New System.Drawing.Point(69, 88)
        Me.txtVA2.Name = "txtVA2"
        Me.txtVA2.ReadOnly = True
        Me.txtVA2.Size = New System.Drawing.Size(408, 27)
        Me.txtVA2.TabIndex = 4
        '
        'txtVA1
        '
        Me.txtVA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVA1.Location = New System.Drawing.Point(69, 57)
        Me.txtVA1.Name = "txtVA1"
        Me.txtVA1.ReadOnly = True
        Me.txtVA1.Size = New System.Drawing.Size(408, 27)
        Me.txtVA1.TabIndex = 2
        '
        'txtVendor
        '
        Me.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendor.Location = New System.Drawing.Point(69, 26)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.ReadOnly = True
        Me.txtVendor.Size = New System.Drawing.Size(408, 27)
        Me.txtVendor.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblShipComplete)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtShipVia)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtDue)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtFrt)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtReq)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtBuyer)
        Me.GroupBox4.Location = New System.Drawing.Point(507, 169)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(353, 188)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc"
        '
        'lblShipComplete
        '
        Me.lblShipComplete.AutoSize = True
        Me.lblShipComplete.BackColor = System.Drawing.Color.ForestGreen
        Me.lblShipComplete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShipComplete.ForeColor = System.Drawing.Color.White
        Me.lblShipComplete.Location = New System.Drawing.Point(233, 152)
        Me.lblShipComplete.Name = "lblShipComplete"
        Me.lblShipComplete.Size = New System.Drawing.Size(110, 20)
        Me.lblShipComplete.TabIndex = 10
        Me.lblShipComplete.Text = "Ship Complete"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(17, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Ship Via"
        '
        'txtShipVia
        '
        Me.txtShipVia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShipVia.Location = New System.Drawing.Point(89, 119)
        Me.txtShipVia.Name = "txtShipVia"
        Me.txtShipVia.ReadOnly = True
        Me.txtShipVia.Size = New System.Drawing.Size(134, 27)
        Me.txtShipVia.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(45, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 19)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Due"
        '
        'txtDue
        '
        Me.txtDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDue.Location = New System.Drawing.Point(89, 149)
        Me.txtDue.Name = "txtDue"
        Me.txtDue.ReadOnly = True
        Me.txtDue.Size = New System.Drawing.Size(134, 27)
        Me.txtDue.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(24, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 19)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Freight"
        '
        'txtFrt
        '
        Me.txtFrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrt.Location = New System.Drawing.Point(89, 88)
        Me.txtFrt.Name = "txtFrt"
        Me.txtFrt.ReadOnly = True
        Me.txtFrt.Size = New System.Drawing.Size(247, 27)
        Me.txtFrt.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(3, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Requestor"
        '
        'txtReq
        '
        Me.txtReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReq.Location = New System.Drawing.Point(89, 57)
        Me.txtReq.Name = "txtReq"
        Me.txtReq.ReadOnly = True
        Me.txtReq.Size = New System.Drawing.Size(247, 27)
        Me.txtReq.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(32, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Buyer"
        '
        'txtBuyer
        '
        Me.txtBuyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuyer.Location = New System.Drawing.Point(89, 26)
        Me.txtBuyer.Name = "txtBuyer"
        Me.txtBuyer.ReadOnly = True
        Me.txtBuyer.Size = New System.Drawing.Size(247, 27)
        Me.txtBuyer.TabIndex = 0
        '
        'txtPONote
        '
        Me.txtPONote.Location = New System.Drawing.Point(873, 34)
        Me.txtPONote.Multiline = True
        Me.txtPONote.Name = "txtPONote"
        Me.txtPONote.ReadOnly = True
        Me.txtPONote.Size = New System.Drawing.Size(349, 795)
        Me.txtPONote.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(876, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "PO Notes"
        '
        'dgvPODetail
        '
        Me.dgvPODetail.AllowUserToAddRows = False
        Me.dgvPODetail.AllowUserToDeleteRows = False
        Me.dgvPODetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPODetail.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPODetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPODetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPODetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPODetail.Location = New System.Drawing.Point(12, 363)
        Me.dgvPODetail.Name = "dgvPODetail"
        Me.dgvPODetail.ReadOnly = True
        Me.dgvPODetail.RowHeadersVisible = False
        Me.dgvPODetail.RowHeadersWidth = 45
        Me.dgvPODetail.RowTemplate.Height = 27
        Me.dgvPODetail.Size = New System.Drawing.Size(848, 433)
        Me.dgvPODetail.TabIndex = 13
        '
        'txtPOTotal
        '
        Me.txtPOTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOTotal.Location = New System.Drawing.Point(711, 802)
        Me.txtPOTotal.Name = "txtPOTotal"
        Me.txtPOTotal.ReadOnly = True
        Me.txtPOTotal.Size = New System.Drawing.Size(149, 27)
        Me.txtPOTotal.TabIndex = 14
        Me.txtPOTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(639, 806)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 19)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "PO Total"
        '
        'txtvarJob
        '
        Me.txtvarJob.Location = New System.Drawing.Point(12, 877)
        Me.txtvarJob.Name = "txtvarJob"
        Me.txtvarJob.Size = New System.Drawing.Size(65, 27)
        Me.txtvarJob.TabIndex = 16
        '
        'txtvarUnit
        '
        Me.txtvarUnit.Location = New System.Drawing.Point(83, 877)
        Me.txtvarUnit.Name = "txtvarUnit"
        Me.txtvarUnit.Size = New System.Drawing.Size(65, 27)
        Me.txtvarUnit.TabIndex = 17
        '
        'txtvarPO
        '
        Me.txtvarPO.Location = New System.Drawing.Point(154, 877)
        Me.txtvarPO.Name = "txtvarPO"
        Me.txtvarPO.Size = New System.Drawing.Size(65, 27)
        Me.txtvarPO.TabIndex = 18
        '
        'Project_POImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1234, 842)
        Me.Controls.Add(Me.txtvarPO)
        Me.Controls.Add(Me.txtvarUnit)
        Me.Controls.Add(Me.txtvarJob)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtPOTotal)
        Me.Controls.Add(Me.dgvPODetail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPONote)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Project_POImage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvPODetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJob As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtShipZip As TextBox
    Friend WithEvents txtShipState As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtShipCity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtShipA2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtShipA1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtShip As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVPhone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVContact As TextBox
    Friend WithEvents txtVA2 As TextBox
    Friend WithEvents txtVA1 As TextBox
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblShipComplete As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtShipVia As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDue As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFrt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtReq As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBuyer As TextBox
    Friend WithEvents txtVZip As TextBox
    Friend WithEvents txtVState As TextBox
    Friend WithEvents txtVCity As TextBox
    Friend WithEvents txtPONote As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvPODetail As DataGridView
    Friend WithEvents txtPOTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtvarJob As TextBox
    Friend WithEvents txtvarUnit As TextBox
    Friend WithEvents txtvarPO As TextBox
End Class
