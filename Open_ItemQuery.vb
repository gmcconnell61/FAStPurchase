Imports System.Data.SqlClient

Public Class Open_ItemQuery
    Dim myPurch As New UpdatePURCH_POTables
    Dim vJob As Integer
    Dim vUnit As Integer
    Dim vPO As Integer
    Dim vRec As Integer
    Dim vVendor As String
    Dim vDueDate As Date
    Dim vPODesc As String
    Dim varCC As String
    Dim vTotal As Decimal
    Dim NewNote As Boolean = False
    Dim vOrd As Integer
    Dim vRecv As Integer
    Dim vDollars As Decimal
    Dim vAvg As Integer

    Private Sub Open_ItemQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPurch.LoadItemQuery()
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        LoadQuery()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        If dgvOpenQuery.Columns.Count = 15 Then
            dgvOpenQuery.Columns.RemoveAt(14)
            dgvOpenQuery.Columns.RemoveAt(13)
            dgvOpenQuery.Columns.RemoveAt(12)
        End If

        If Len(vSortBy) > 0 Then 'if user clicks column header to resort
            vQuery = "Select * from PurchOpenItems ORDER BY " & vSortBy
        Else
            vQuery = "Select * from PurchOpenItems ORDER BY co_name, mfg, part_no"
        End If

        myPurch.RunQuery(vQuery, "QueryOpenItems", 1)
        dgvOpenQuery.DataSource = myPurch.FAStQuoteDS.Tables("QueryOpenItems")

        SetColumns()
    End Sub

    Private Sub dgvOpenQuery_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOpenQuery.ColumnHeaderMouseClick
        vSortBy = dgvOpenQuery.Columns(e.ColumnIndex).Name 'Get column header name
        LoadQuery()
    End Sub




    'SUBS
    Private Sub LoadQuery()
        'Deletes added 2 columns and reloads
        If dgvOpenQuery.Columns.Count = 15 Then
            dgvOpenQuery.Columns.RemoveAt(14)
            dgvOpenQuery.Columns.RemoveAt(13)
            dgvOpenQuery.Columns.RemoveAt(12)
        End If

        Dim x As Integer

        vQuery = "Select * from PurchOpenItems "
        For i = 1 To 5
            Select Case i
                Case 1 'test jobNo
                    If Me.txtJobNo.TextLength > 0 Then
                        vQuery = vQuery & " WHERE job_no like '%" & Me.txtJobNo.Text & "%' "
                        x = 1
                    End If
                Case 2 'test Vendor
                    If Me.txtVendor.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND co_name like '%" & Me.txtVendor.Text & "%' "
                    ElseIf Me.txtVendor.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE co_name like '%" & Me.txtVendor.Text & "%' "
                        x = 1
                    End If
                Case 3 'test Mfg
                    If Me.txtMfg.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND mfg like '%" & Me.txtMfg.Text & "%' "
                    ElseIf Me.txtMfg.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE mfg like '%" & Me.txtMfg.Text & "%' "
                        x = 1
                    End If
                Case 4 'test PartNo
                    If Me.txtCatalogNo.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND part_no like '%" & Me.txtCatalogNo.Text & "%' "
                    ElseIf Me.txtCatalogNo.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE part_no like '%" & Me.txtCatalogNo.Text & "%' "
                        x = 1
                    End If
                Case 5 'test Description
                    If Me.txtDescription.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND description like '%" & Me.txtDescription.Text & "%' "
                    ElseIf Me.txtDescription.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE description like '%" & Me.txtDescription.Text & "%' "
                        x = 1
                    End If
            End Select
        Next

        If Len(vSortBy) > 0 Then 'if user clicks column header to resort
            vQuery = vQuery & " ORDER BY " & vSortBy
        Else
            vQuery = vQuery & " ORDER BY co_name, mfg, part_no"
        End If
        myPurch.RunQuery(vQuery, "QueryOpenItems", 1)

        dgvOpenQuery.DataSource = myPurch.FAStQuoteDS.Tables("QueryOpenItems")
        SetColumns()
    End Sub

    Private Sub SetColumns()
        With dgvOpenQuery
            If dgvOpenQuery.Columns.Count = 15 Then GoTo UpdateLateDates

            'adds 3 columns
            Dim col12, col13, col14 As New DataGridViewTextBoxColumn
            col12.HeaderText = "LateDate"
            col12.DefaultCellStyle.Format = "M/d/yy"
            col12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add(col12)
            col13.HeaderText = "DaysOpen"
            'col13.DefaultCellStyle.Format = "c"
            col13.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add(col13)
            col14.HeaderText = "Cost"
            col14.DefaultCellStyle.Format = "c"
            col14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns.Add(col14)

            .Columns(3).Visible = False 'RecNo

            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 3
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 3
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 3
            .Columns(4).HeaderText = "PO Date"
            .Columns(4).FillWeight = 5
            .Columns(4).DefaultCellStyle.Format = "d"
            .Columns(5).HeaderText = "Vendor"
            .Columns(5).FillWeight = 12
            .Columns(6).HeaderText = "Manufacturer"
            .Columns(6).FillWeight = 12
            .Columns(7).HeaderText = "Part Number"
            .Columns(7).FillWeight = 10
            .Columns(8).HeaderText = "Description"
            .Columns(8).FillWeight = 21
            .Columns(9).HeaderText = "Ord"
            .Columns(9).FillWeight = 3
            .Columns(10).HeaderText = "Recv"
            .Columns(10).FillWeight = 3
            .Columns(11).HeaderText = "Due Date"
            .Columns(11).FillWeight = 5
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(12).HeaderText = "Late Date"
            .Columns(12).FillWeight = 5
            .Columns(13).HeaderText = "DaysOpen"
            .Columns(13).FillWeight = 5
            .Columns(14).HeaderText = "Cost"
            .Columns(14).FillWeight = 5
        End With

UpdateLateDates:
        UpdateLatesAndPrices()
        GetTotals()
        vSortBy = "" 'Resets SortBy column name
    End Sub

    Private Sub UpdateLatesAndPrices()
        For x = 0 To dgvOpenQuery.Rows.Count - 1
            vJob = dgvOpenQuery.Rows(x).Cells(0).Value
            vUnit = dgvOpenQuery.Rows(x).Cells(1).Value
            vPO = dgvOpenQuery.Rows(x).Cells(2).Value
            vRec = dgvOpenQuery.Rows(x).Cells(3).Value
            dgvOpenQuery.Rows(x).Cells(12).Value = myPurch.GetDetailLateDate(vJob, vUnit, vPO, vRec) 'LateDate
            dgvOpenQuery.Rows(x).Cells(14).Value = myPurch.GetDetailPrice(vJob, vUnit, vPO, vRec) 'Price
        Next
    End Sub

    Private Sub GetTotals()
        vOrd = 0
        vRecv = 0
        vDollars = 0
        vAvg = 0

        Dim date2 As Date
        Dim date1 As Date
        Dim diff As Integer
        Dim difftotal As Integer

        'Gets quantity & dollars total
        For r = 0 To dgvOpenQuery.Rows.Count - 1
            With dgvOpenQuery
                vOrd = vOrd + .Rows(r).Cells(9).Value
                vRecv = vRecv + .Rows(r).Cells(10).Value
                vDollars = vDollars + ((.Rows(r).Cells(9).Value - .Rows(r).Cells(10).Value) * .Rows(r).Cells(14).Value)
            End With
        Next
        lblTotalOrdered.Text = vOrd
        lblTotalReceived.Text = vRecv
        lblTotalValue.Text = Format(vDollars, "currency")

        'Gets average open days
        For d = 0 To dgvOpenQuery.Rows.Count - 1
            With dgvOpenQuery
                diff = Nothing
                If Len(.Rows(d).Cells(12).Value) = 0 Then 'if no LateDate calculates open days from today
                    date1 = .Rows(d).Cells(4).Value
                    diff = Today().Subtract(date1).TotalDays
                Else
                    date2 = .Rows(d).Cells(12).Value
                    date1 = .Rows(d).Cells(4).Value
                    diff = date2.Subtract(date1).TotalDays
                End If
                .Rows(d).Cells(13).Value = diff
                difftotal = difftotal + diff
            End With
        Next
        lblAvgDaysOpen.Text = Int(difftotal / dgvOpenQuery.Rows.Count)
    End Sub


End Class