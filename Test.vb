Public Class Test
    Dim myImpExp As New ImportExport
    Dim myDB As New DB_Connections
    Dim myPurch As New UpdatePURCH_POTables
    Dim dt As DataTable
    Dim tmpDV As DataView
    Dim fasDT As DataTable
    Dim fasDV As DataView
    Dim tmpDate As Date
    Dim vReportDate As String

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        LoadFASOpen()
        lblRollupDate.Text = myPurch.GetReportDate("RollUp Report Date")
        lblAllocationDate.Text = myPurch.GetReportDate("Allocation Report Date")
        GroupBox1.Text = "Filter Data      Record Count: " & dgvFASOpen.Rows.Count
        Cursor = Cursors.Default
    End Sub

    Private Sub btnAllocated_Click(sender As Object, e As EventArgs) Handles btnAllocated.Click
        LoadNewAllocationFile()
    End Sub

    Private Sub btnLate_Click(sender As Object, e As EventArgs) Handles btnLate.Click
        LoadNewRollUpFile()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If rdoJob.Checked = True And Len(txtFilter.Text) > 0 Then
            fasDV.RowFilter = "co_name like '%McNaught%' AND PONO like'%" + txtFilter.Text + "%'"
        ElseIf rdoPartNo.Checked = True And Len(txtFilter.Text) > 0 Then
            fasDV.RowFilter = "co_name like '%McNaught%' AND Column1 like'%" + txtFilter.Text + "%'"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFilter.Text = Nothing
        fasDV.RowFilter = ""
        fasDV.Sort = "PONO"
        fasDV.RowFilter = "co_name like '%McNaught%'"
    End Sub

    Private Sub Filter_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged, rdo3.CheckedChanged, rdo4.CheckedChanged
        If rdo0.Checked = True Then
            fasDV.RowFilter = "co_name like '%McNaught%'"
        ElseIf rdo1.Checked = True Then 'Allocated
            fasDV.RowFilter = "co_name like '%McNaught%' AND Allocated > 0"
        ElseIf rdo2.Checked = True Then 'New LateDate
            fasDV.RowFilter = "co_name like '%McNaught%' AND LateDate <> NewArrival"
        ElseIf rdo3.Checked = True Then 'Unchaged LateDate
            fasDV.RowFilter = "co_name like '%McNaught%' AND LateDate = NewArrival"
        ElseIf rdo4.Checked = True Then 'Problems
            fasDV.RowFilter = "co_name like '%McNaught%' AND Issue = 1"
        End If

        'HighlightProblems()
        GroupBox1.Text = "Filter Data      Record Count: " & dgvFASOpen.Rows.Count
    End Sub



    '***SUBS***
    Private Sub LoadFASOpen()
        'Clears for reload
        fasDT = Nothing
        fasDV = Nothing
        dgvFASOpen.DataSource = Nothing

        Cursor = Cursors.WaitCursor
        myPurch.LoadItemQuery()
        fasDT = myPurch.FAStQuoteDS.Tables("OpenItems")
        'Add rows for other data
        fasDT.Columns.Add("NewArrival")
        fasDT.Columns.Add("LateDate")
        fasDT.Columns.Add("PONO")
        fasDT.Columns.Add("Allocated")
        fasDT.Columns.Add("Transfers")
        fasDT.Columns.Add("Issue")

        'Create DataView for filtering
        fasDV = fasDT.DefaultView
        fasDV.RowFilter = "co_name like '%McNaught%'"
        fasDV.Sort = "job_no, unit_no, po_no"


        With dgvFASOpen
            .DataSource = fasDV
            .Columns(0).Visible = False 'job_no
            .Columns(1).Visible = False 'unit_no
            .Columns(2).Visible = False 'po_no
            .Columns(3).Visible = False 'rec_no
            .Columns(4).Visible = False 'po_date
            .Columns(5).Visible = False 'vendor
            .Columns(6).Visible = False 'mfg
            .Columns(8).Visible = False 'desc
            .Columns(10).Visible = False 'received
            .Columns(17).Visible = False 'Issue

            .Columns(7).HeaderText = "CatalogNumber"
            .Columns(9).HeaderText = "Qty"
            .Columns(11).HeaderText = "Due Date"
            .Columns(11).DefaultCellStyle.Format = "d"
            .Columns(11).DisplayIndex = 3
            .Columns(12).DisplayIndex = 1 'new late date
            .Columns(12).DefaultCellStyle.Format = "d"
            .Columns(13).DisplayIndex = 2 'late date
            .Columns(14).HeaderText = "PO Number"
            .Columns(14).DisplayIndex = 0 'PONO

            .Columns(7).FillWeight = 30
            .Columns(9).FillWeight = 10
            .Columns(11).FillWeight = 10
            .Columns(12).FillWeight = 10
            .Columns(13).FillWeight = 10
            .Columns(14).FillWeight = 10
            .Columns(15).FillWeight = 10
            .Columns(16).FillWeight = 10

        End With

        'Gets stored data from POLateDates
        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen.Rows(x)
                vJobNo = .Cells(0).Value
                vUnitNo = .Cells(1).Value
                vPONo = .Cells(2).Value
                vRecNo = .Cells(3).Value
                'LateDate
                .Cells(13).Value = myPurch.Check4LateDates(vJobNo, vUnitNo, vPONo, vRecNo)
                If .Cells(13).Value = "1/1/0001" Or .Cells(13).Value = "1/2/1900" Then .Cells(13).Value = Nothing
                'Allocated
                .Cells(15).Value = myPurch.Check4Allocation(vJobNo, vUnitNo, vPONo, vRecNo)
                'Transferred
                .Cells(16).Value = myPurch.Check4Transfers(vJobNo, vUnitNo, vPONo, vRecNo)
                .Cells(14).Value = vJobNo & "-" & Format(vUnitNo, "000") & "-" & Format(vPONo, "000")
            End With
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub LoadNewAllocationFile()
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Excel files |*.xls;*.xlsx"
        dialog.InitialDirectory = "fileserver1\Personal Folders\Purchasing\Mc-Mc Weekly Reports\"
        dialog.Title = "Select Excel File to Import"
        'Encrypt the selected file. I'll do this later. :)
        If dialog.ShowDialog() = DialogResult.OK Then
            dt = myImpExp.ImportExceltoDatatable(dialog.FileName)
        End If
        vReportDate = InputBox("Enter Report Date: ", "Allocation Report Date", Format(Today(), "M/dd/yyyy").ToString)

        'Load data to Table
        myPurch.Load_McMc(dt, "dbo.McMcAllocation")

        'Sets Report Date
        vQuery = "Update FASt_System set Date = '" & vReportDate & "' WHERE Description = 'Allocation Report Date'"
        myPurch.AddRecord(vQuery)

        lblAllocationDate.Text = myPurch.GetReportDate("Allocation Report Date")
        LoadFASOpen()
    End Sub

    Private Sub LoadNewRollUpFile()
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Excel files |*.xls;*.xlsx"
        dialog.InitialDirectory = "fileserver1\Personal Folders\Purchasing\Mc-Mc Weekly Reports\"
        dialog.Title = "Select Excel File to Import"
        If dialog.ShowDialog() = DialogResult.OK Then
            dt = myImpExp.ImportExceltoDatatable(dialog.FileName)
        End If

        'Load data to Table
        For x = 0 To dt.Rows.Count - 1 'Clears dashes out of part numbers
            dt.Rows(x).Item("shipprod") = dt.Rows(x).Item("shipprod").ToString.Replace("-", "")
        Next
        myPurch.Load_McMc(dt, "dbo.McMcOpenLate") 'Loads to datatable

        lblRollupDate.Text = myPurch.GetReportDate("RollUp Report Date")
        LoadFASOpen()
    End Sub

    'Private Sub UpdateAllocated()
    '    'Cursor = Cursors.WaitCursor
    '    'vQuery = "Select PO, Product, [Qty Shipped], [Qty Ordered] from McMcAllocation ORDER BY PO, Product"
    '    'myDB.FAStQuoteQuery(vQuery, "Allocation")

    '    ''Load from Report
    '    'For x = 0 To dgvFASOpen.Rows.Count - 1
    '    '    With dgvFASOpen
    '    '        .Rows(x).Cells(15).Value = 0
    '    '        For y = 0 To myDB.FAStQuoteDS.Tables("Allocation").Rows.Count - 1
    '    '            If .Rows(x).Cells(14).Value = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(0) Then
    '    '                If .Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "") = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(1).ToString.Remove(0, 4) Then
    '    '                    If .Rows(x).Cells(9).Value = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(3) Then
    '    '                        .Rows(x).Cells(15).Value = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(2)
    '    '                    End If
    '    '                End If
    '    '            End If
    '    '        Next
    '    '    End With
    '    'Next

    '    ''Update Tables
    '    'For x = 0 To dgvFASOpen.Rows.Count - 1
    '    '    With dgvFASOpen.Rows(x)
    '    '        If .Cells(15).Value > 0 Then
    '    '            myPurch.UpdateAllocation(.Cells(0).Value, .Cells(1).Value, .Cells(2).Value, .Cells(3).Value, .Cells(7).Value, .Cells(15).Value)
    '    '        End If
    '    '    End With
    '    'Next
    '    'Cursor = Cursors.Default
    'End Sub

    Private Sub UpdateLateDates()
        vQuery = "Select custpo, shipprod, qtyord, [Vendor Exp Ship Date] from McMcOpenLate ORDER BY custpo, shipprod"
        myDB.FAStQuoteQuery(vQuery, "OpenLate")

        'Gets existing LateDates
        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen.Rows(x)
                vJobNo = .Cells(0).Value
                vUnitNo = .Cells(1).Value
                vPONo = .Cells(2).Value
                vRecNo = .Cells(3).Value
                .Cells(13).Value = myPurch.Check4LateDates(vJobNo, vUnitNo, vPONo, vRecNo)
                If .Cells(13).Value = "1/1/0001" Or .Cells(13).Value = "1/2/1900" Then .Cells(13).Value = Nothing
                .Cells(14).Value = vJobNo & "-" & Format(vUnitNo, "000") & "-" & Format(vPONo, "000")
            End With
        Next

        'Checks for New LateDates

        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                .Rows(x).Cells(17).Value = 0 'Resets Issue
                For y = 0 To myDB.FAStQuoteDS.Tables("OpenLate").Rows.Count - 1
                    If .Rows(x).Cells(14).Value = myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(0) Then
                        If RTrim(.Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "")) = myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(1).ToString.Remove(0, 4) Then
                            If IsDBNull(myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(3)) = False Then
                                tmpDate = Convert.ToDateTime(myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(3))
                                .Rows(x).Cells(12).Value = tmpDate.AddDays(14)
                                If .Rows(x).Cells(12).Value < Today() Then
                                    .Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    .Rows(x).DefaultCellStyle.ForeColor = Color.Yellow
                                    .Rows(x).Cells(17).Value = 1 'Issue
                                End If
                            End If
                        End If
                    End If
                Next
            End With
        Next

    End Sub

    'Private Sub UpdateTransfer()
    '    vQuery = "SELECT po_detail.job_no, rtrim(po_detail.part_no), " &
    '             "sum(po_detail.quantity) as Total, po_header.vendor_id, job_master.status " &
    '             "FROM po_detail INNER JOIN po_header ON po_detail.job_no = po_header.job_no And po_detail.unit_no = po_header.unit_no And po_detail.po_no = po_header.po_no " &
    '             "INNER JOIN job_master on po_detail.job_no = job_master.job_no " &
    '             "GROUP BY po_detail.job_no, po_detail.unit_no, po_detail.po_no, po_detail.rec_no, po_header.po_date," &
    '             "po_detail.mfg, po_detail.part_no, po_detail.description, po_detail.quantity, po_header.vendor_id, job_master.status " &
    '             "HAVING  po_header.vendor_id = 'F7823' AND po_detail.quantity > 0 AND job_master.status = 'A'" &
    '             "ORDER BY po_detail.job_no, po_detail.part_no"
    '    myDB.FASQuery(vQuery, "FASTransfers")

    '    For x = 0 To dgvFASOpen.Rows.Count - 1
    '        With dgvFASOpen
    '            For y = 0 To myDB.FASDS.Tables("FASTransfers").Rows.Count - 1
    '                If .Rows(x).Cells(0).Value = myDB.FASDS.Tables("FASTransfers").Rows(y).Item(0) Then
    '                    If .Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "") =
    '                        myDB.FASDS.Tables("OpenLate").Rows(y).Item(1).ToString.Replace("-", "").Replace(" ", "") Then
    '                        .Rows(x).Cells(16).Value = myDB.FASDS.Tables("FASTransfers").Rows(y).Item(2)
    '                    End If
    '                End If
    '            Next
    '        End With
    '    Next
    'End Sub

    Private Sub HighlightProblems()
        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                If .rows(x).cells(17).value = 1 Then
                    .Rows(x).DefaultCellStyle.BackColor = Color.Red
                    .Rows(x).DefaultCellStyle.ForeColor = Color.Yellow
                End If
            End With
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'testing area


    End Sub
End Class