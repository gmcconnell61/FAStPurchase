Public Class McMc_OpenLate
    Dim myImpExp As New ImportExport
    Dim myDB As New DB_Connections
    Dim myPurch As New UpdatePURCH_POTables
    Dim dt As DataTable
    Dim tmpDV As DataView
    Dim fasDT As DataTable
    Dim fasDV As DataView

    Private Sub McMc_OpenLate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFASOpen()
    End Sub

    Private Sub btnGetFile_Click(sender As Object, e As EventArgs) Handles btnGetFile.Click
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

        'Setup to display in DGV
        tmpDV = dt.DefaultView
        tmpDV.Sort = "custpo"

        With dgvOpenLate
            .DataSource = tmpDV
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(18).Visible = False
            '.Columns(19).Visible = False
            '.Columns(20).Visible = False
            '.Columns(21).Visible = False
            '.Columns(22).Visible = False

            .Columns(15).DisplayIndex = 1

            .Columns(6).FillWeight = 10 'Mc-Mc Order Number
            .Columns(7).FillWeight = 5 'Mc-Mc Order Suffix
            .Columns(10).FillWeight = 30 'Part Number
            .Columns(11).FillWeight = 10 'Ordered
            .Columns(12).FillWeight = 10 'Req date
            .Columns(13).FillWeight = 10 'Promise date
            .Columns(14).FillWeight = 10 'RA Expected Ship
            .Columns(15).FillWeight = 15 'FAS PO #

        End With
        LoadNewLateDate()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If rdoJob.Checked = True And Len(txtFilter.Text) > 0 Then
            tmpDV.RowFilter = "custpo like'%" + txtFilter.Text + "%'"
            fasDV.RowFilter = "co_name like '%McNaught%' AND PONO like'%" + txtFilter.Text + "%'"
        ElseIf rdoPartNo.Checked = True And Len(txtFilter.Text) > 0 Then
            tmpDV.RowFilter = "shipprod like'%" + txtFilter.Text + "%'"
            fasDV.RowFilter = "co_name like '%McNaught%' AND part_no like'%" + txtFilter.Text + "%'"
        End If
    End Sub

    Private Sub Filter_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoChange.CheckedChanged, chkEarlier.CheckedChanged
        If dgvFASOpen.Rows.Count > 0 Then 'Makes sure data is present
            If chkEarlier.Checked = True And chkNoChange.Checked = True Then 'Full list
                fasDV.RowFilter = "co_name like '%McNaught%'"
            ElseIf chkEarlier.Checked = True And chkNoChange.Checked = False Then 'No change hidden
                fasDV.RowFilter = "co_name like '%McNaught%' AND (NewArrival <> LateDate OR LateDate = '')"
            ElseIf chkEarlier.Checked = False And chkNoChange.Checked = True Then 'Late earlier than due turned off
                fasDV.RowFilter = "co_name like '%McNaught%'"
            ElseIf chkEarlier.Checked = False And chkNoChange.Checked = False Then 'Both turned off
                fasDV.RowFilter = "co_name like '%McNaught%'"
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFilter.Text = Nothing
        tmpDV.RowFilter = ""
        tmpDV.Sort = "custpo"
        fasDV.RowFilter = "co_name like '%McNaught%'"

        'Reloads NewLateDates and highlights problem dates
        LoadNewLateDate()
    End Sub

    Private Sub dgvOpenLate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOpenLate.CellClick
        vRow = dgvOpenLate.CurrentRow.Index
        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                .ClearSelection()
                If .Rows(x).Cells(14).Value = dgvOpenLate.Rows(vRow).Cells(15).Value Then
                    If RTrim(.Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "")) = dgvOpenLate.Rows(vRow).Cells(10).Value.ToString.Remove(0, 4) Then
                        .Rows(x).Selected = True
                        .FirstDisplayedScrollingRowIndex = x
                        Exit For
                    End If
                End If
            End With
        Next
    End Sub

    Private Sub dgvFASOpen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFASOpen.CellClick
        vRow = dgvFASOpen.CurrentRow.Index
        For x = 0 To dgvOpenLate.Rows.Count - 1
            With dgvOpenLate
                .ClearSelection()
                If dgvFASOpen.Rows(vRow).Cells(14).Value = .Rows(x).Cells(15).Value Then
                    If RTrim(dgvFASOpen.Rows(vRow).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "")) = .Rows(x).Cells(10).Value.ToString.Remove(0, 4) Then
                        .Rows(x).Selected = True
                        .FirstDisplayedScrollingRowIndex = x
                        Exit For
                    End If
                End If
            End With
        Next
    End Sub




    '***Subs***
    Private Sub LoadFASOpen()
        Cursor = Cursors.WaitCursor
        myPurch.LoadItemQuery()
        fasDT = myPurch.FAStQuoteDS.Tables("OpenItems")
        'Add rows for other data
        fasDT.Columns.Add("NewArrival")
        fasDT.Columns.Add("LateDate")
        fasDT.Columns.Add("PONO")

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

            .Columns(7).HeaderText = "Catalog Number"
            .Columns(9).HeaderText = "Qty"
            .Columns(11).HeaderText = "Due Date"
            .Columns(11).DefaultCellStyle.Format = "d"
            .Columns(12).DisplayIndex = 0 'new late date
            .Columns(12).DefaultCellStyle.Format = "d"
            .Columns(13).DisplayIndex = 1 'late date
            .Columns(14).HeaderText = "PO Number"
            .Columns(14).DisplayIndex = 2 'PONO

            .Columns(7).FillWeight = 30
            .Columns(9).FillWeight = 10
            .Columns(11).FillWeight = 15
            .Columns(12).FillWeight = 15
            .Columns(13).FillWeight = 15
            .Columns(14).FillWeight = 15

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

    Private Sub LoadNewLateDate()
        Dim tmpDate As Date

        For x = 0 To dgvFASOpen.Rows.Count - 1
            With dgvFASOpen
                For y = 0 To dgvOpenLate.Rows.Count - 1
                    If .Rows(x).Cells(14).Value = dgvOpenLate.Rows(y).Cells(15).Value Then
                        If RTrim(.Rows(x).Cells(7).Value.ToString.Replace("-", "").Replace(" ", "")) = dgvOpenLate.Rows(y).Cells(10).Value.ToString.Remove(0, 4) Then
                            If IsDBNull(dgvOpenLate.Rows(y).Cells(14).Value) = False Then
                                tmpDate = Convert.ToDateTime(dgvOpenLate.Rows(y).Cells(14).Value)
                                .Rows(x).Cells(12).Value = tmpDate.AddDays(14)
                                If .Rows(x).Cells(12).Value < Today() Then
                                    .Rows(x).DefaultCellStyle.BackColor = Color.Red
                                    .Rows(x).DefaultCellStyle.ForeColor = Color.Yellow
                                End If
                            End If
                        End If
                    End If
                Next
            End With
        Next
    End Sub


End Class