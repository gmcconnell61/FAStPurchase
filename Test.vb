Public Class Test
    Dim myImpExp As New ImportExport
    Dim myDB As New DB_Connections
    Dim myPurch As New UpdatePURCH_POTables
    Dim dt As DataTable
    Dim tmpDV As DataView
    Dim fasDT As DataTable
    Dim fasDV As DataView

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFASOpen()
    End Sub

    Private Sub btnAllocated_Click(sender As Object, e As EventArgs) Handles btnAllocated.Click
        UpdateAllocated()
    End Sub

    Private Sub btnLate_Click(sender As Object, e As EventArgs) Handles btnLate.Click
        UpdateLateDates()
    End Sub

    Private Sub LoadFASOpen()
        Cursor = Cursors.WaitCursor
        myPurch.LoadItemQuery()
        fasDT = myPurch.FAStQuoteDS.Tables("OpenItems")
        'Add rows for other data
        fasDT.Columns.Add("NewArrival")
        fasDT.Columns.Add("LateDate")
        fasDT.Columns.Add("PONO")
        fasDT.Columns.Add("Allocated")
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
            .Columns(16).Visible = False 'received

            .Columns(7).HeaderText = "Catalog Number"
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
            .Columns(11).FillWeight = 12
            .Columns(12).FillWeight = 12
            .Columns(13).FillWeight = 12
            .Columns(14).FillWeight = 12
            .Columns(15).FillWeight = 12

        End With

        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen.Rows(x)
                vJobNo = .Cells(0).Value
                vUnitNo = .Cells(1).Value
                vPONo = .Cells(2).Value
                vRecNo = .Cells(3).Value
                .Cells(13).Value = myPurch.Check4LateDates(vJobNo, vUnitNo, vPONo, vRecNo)
                If .Cells(13).Value = "1/1/0001" Then .Cells(13).Value = Nothing
                .Cells(14).Value = vJobNo & "-" & Format(vUnitNo, "000") & "-" & Format(vPONo, "000")
            End With
        Next
        'dgvFASOpen.Columns(13).DefaultCellStyle.Format = "d"
        Cursor = Cursors.Default
    End Sub

    Private Sub UpdateAllocated()
        vQuery = "Select PO, Product, [Qty Shipped], [Qty Ordered] from McMcAllocation ORDER BY PO, Product"
        myDB.FAStQuoteQuery(vQuery, "Allocation")

        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                For y = 0 To myDB.FAStQuoteDS.Tables("Allocation").Rows.Count - 1
                    If .Rows(x).Cells(14).Value = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(0) Then
                        If .Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "") = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(1).ToString.Remove(0, 4) Then
                            If .Rows(x).Cells(9).Value = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(3) Then
                                .Rows(x).Cells(15).Value = myDB.FAStQuoteDS.Tables("Allocation").Rows(y).Item(2)
                            End If
                        End If
                    End If
                Next
            End With
        Next

        'fasDV.RowFilter = "co_name like '%McNaught%' AND Allocated > 0"

    End Sub

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
                If .Cells(13).Value = "1/1/0001" Then .Cells(13).Value = Nothing
                .Cells(14).Value = vJobNo & "-" & Format(vUnitNo, "000") & "-" & Format(vPONo, "000")
            End With
        Next

        'Checks for New LateDates
        Dim tmpDate As Date

        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                For y = 0 To myDB.FAStQuoteDS.Tables("OpenLate").Rows.Count - 1
                    If .Rows(x).Cells(14).Value = myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(0) Then
                        If RTrim(.Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "")) = myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(1).ToString.Remove(0, 4) Then
                            If IsDBNull(myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(3)) = False Then
                                tmpDate = Convert.ToDateTime(myDB.FAStQuoteDS.Tables("OpenLate").Rows(y).Item(3))
                                .Rows(x).Cells(12).Value = tmpDate.AddDays(14)
                                If .Rows(x).Cells(12).Value < Today() Then
                                    .Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    .Rows(x).DefaultCellStyle.ForeColor = Color.Yellow
                                    .Rows(x).Cells(16).Value = 1 'Issue
                                Else
                                    .Rows(x).Cells(16).Value = 0 'Resets Issue
                                End If
                            End If
                        End If
                    End If
                Next
            End With
        Next

    End Sub

    Private Sub HighlightProblems()
        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                If IsDBNull(.Rows(x).Cells(12)) = False Then
                    If .Rows(x).Cells(12).Value < Today() Then
                        .Rows(x).DefaultCellStyle.BackColor = Color.Red
                        .Rows(x).DefaultCellStyle.ForeColor = Color.Yellow
                        .Rows(x).Cells(16).Value = 1 'Issue
                    Else
                        .Rows(x).Cells(16).Value = 0 'Resets Issue
                    End If
                End If
            End With
        Next
    End Sub

    Private Sub Filter_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged, rdo2.CheckedChanged, rdo3.CheckedChanged, rdo4.CheckedChanged
        If rdo0.Checked = True Then
            fasDV.RowFilter = "co_name like '%McNaught%'"
        ElseIf rdo1.Checked = True Then 'Allocated
            fasDV.RowFilter = "co_name like '%McNaught%' AND Allocated > 0"
            GoTo SkipHighlight
        ElseIf rdo2.Checked = True Then 'New LateDate
            fasDV.RowFilter = "co_name like '%McNaught%' AND LateDate <> NewArrival"
        ElseIf rdo3.Checked = True Then 'Unchaged LateDate
            fasDV.RowFilter = "co_name like '%McNaught%' AND LateDate = NewArrival"
        ElseIf rdo4.Checked = True Then 'Problems
            fasDV.RowFilter = "co_name like '%McNaught%' AND Issue = 1"
        End If

        'HighlightProblems()
SkipHighlight:
        Label1.Text = dgvFASOpen.Rows.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HighlightProblems()
    End Sub
End Class