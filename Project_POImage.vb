Public Class Project_POImage
    Dim myDB As New DB_Connections
    Dim myProj As New UpdatePROJ_Tables
    Dim myPurch As New UpdatePURCH_POTables
    Dim vFilter As String

    Private Sub Project_POImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "PO #" & txtvarJob.Text & "-" & txtvarUnit.Text & "-" & txtvarPO.Text
        GetHeader()
    End Sub

    Public Sub GetHeader()
        'Collects all PO header stuff 
        vQuery = "SELECT po_header.job_no, job_master.job_descr, po_header.unit_no, unit_numbers.description, po_header.po_no, " &
                 "po_header.po_description, po_header.po_date, vendor.co_name, vendor.address1, vendor.address2, vendor.city, " &
                 "vendor.state, vendor.zip, po_header.vendor_contact, po_header.vendor_phone, po_header.ship_to_name, " &
                 "po_header.ship_to_address1, po_header.ship_to_address2, po_header.ship_to_city, po_header.ship_to_state, " &
                 "po_header.ship_to_zip, po_header.purchaser_emp_id, po_header.requestor_emp_id, po_header.freight, po_header.ship_via, " &
                 "po_header.recv_on, po_header.ship_complete " &
                 "FROM (job_master INNER JOIN (vendor INNER JOIN po_header ON vendor.vendor_id = po_header.vendor_id) " &
                 "ON job_master.job_no = po_header.job_no) INNER JOIN unit_numbers ON (po_header.unit_no = unit_numbers.unit_no) AND " &
                 "(po_header.job_no = unit_numbers.job_no) " &
                 "WHERE po_header.job_no = " & txtvarJob.Text & " AND po_header.unit_no = " & txtvarUnit.Text & " AND po_header.po_no = " & txtvarPO.Text
        myDB.FASQuery(vQuery, "POHeadDetail")

        'Populates the fields
        With myDB.FASDS.Tables("POHeadDetail").Rows(0)
            Me.txtJob.Text = .Item(0) & " - " & .Item(1)
            Me.txtUnit.Text = .Item(2) & " - " & .Item(3)
            Me.txtPO.Text = .Item(4) & " - " & .Item(5)
            Me.txtDate.Text = Format(.Item(6), "M/dd/yyyy h:mm tt")

            Me.txtVendor.Text = .Item(7)
            Me.txtVA1.Text = .Item(8)
            Me.txtVA2.Text = .Item(9)
            Me.txtVCity.Text = .Item(10)
            Me.txtVState.Text = .Item(11)
            Me.txtVZip.Text = .Item(12)
            Me.txtVContact.Text = .Item(13)
            Me.txtVPhone.Text = .Item(14)

            Me.txtShip.Text = .Item(15)
            Me.txtShipA1.Text = .Item(16)
            Me.txtShipA2.Text = .Item(17)
            Me.txtShipCity.Text = .Item(18)
            Me.txtShipState.Text = .Item(19)
            Me.txtShipZip.Text = .Item(20)

            Me.txtBuyer.Text = myProj.GetNameExt(.Item(21))
            Me.txtReq.Text = myProj.GetNameExt(.Item(22))
            Me.txtFrt.Text = .Item(23)
            Me.txtShipVia.Text = .Item(24)
            Me.txtDue.Text = .Item(25)
            If .Item(26) = 1 Then lblShipComplete.Visible = True Else lblShipComplete.Visible = False
        End With

        vFilter = "Job_no = " & txtvarJob.Text & " AND unit_no = " & txtvarUnit.Text & " AND po_no = " & txtvarPO.Text
        dvPODetail.RowFilter = vFilter

        With Me.dgvPODetail
            .DataSource = dvPODetail
            .Columns(0).Visible = False 'Job
            .Columns(1).Visible = False 'Unit
            .Columns(2).Visible = False 'PO
            .Columns(3).Visible = False 'Rec
            .Columns(4).HeaderText = "Manufacturer"
            .Columns(4).FillWeight = 15
            .Columns(5).HeaderText = "Part Number"
            .Columns(5).FillWeight = 20
            .Columns(6).HeaderText = "Description"
            .Columns(6).FillWeight = 43
            .Columns(7).HeaderText = "Qty"
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).FillWeight = 5
            .Columns(8).HeaderText = "Recv"
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).FillWeight = 5
            .Columns(9).Visible = False 'each
            .Columns(10).Visible = False 'multiplier
            .Columns(11).HeaderText = "LateDate"
            .Columns(11).FillWeight = 12
            .Columns(11).DefaultCellStyle.Format = "d"
        End With

        'Highlights missing item
        For i = 0 To dgvPODetail.Rows.Count - 1
            With dgvPODetail
                If .Rows(i).Cells(7).Value > .Rows(i).Cells(8).Value Then
                    .Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Red
                    .Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.White
                End If
            End With
        Next

        Dim xTotal As Decimal = 0
        With dgvPODetail
            For x = 0 To dgvPODetail.Rows.Count - 1
                xTotal += .Rows(x).Cells(7).Value * .Rows(x).Cells(9).Value * .Rows(x).Cells(10).Value
            Next
        End With
        Me.txtPOTotal.Text = Format(xTotal, "currency")

        Me.txtPONote.Text = myPurch.GetPONote(txtvarJob.Text, txtvarUnit.Text, txtvarPO.Text) 'retrieves PO notes
    End Sub

    Private Sub POImage2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        vFilter = Nothing
        Me.Dispose()
    End Sub
End Class