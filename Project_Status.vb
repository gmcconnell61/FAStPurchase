Public Class Project_Status
    Dim myProj As New UpdatePROJ_Tables
    Dim myJobs As String = "00" & vUser
    Dim dvPO As New DataView
    Dim dvDetail As DataView
    Dim dvFavorites As DataView

    Private Sub Project_Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJobs("All")
    End Sub

    Private Sub dgvJobs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobs.CellClick
        vRow = dgvJobs.CurrentRow.Index
        vJobNo = dgvJobs.Rows(vRow).Cells(0).Value
        vRow = dgvJobs.CurrentRow.Index

        If e.ColumnIndex = 5 Then
            With dgvJobs
                If .Rows(vRow).Cells(5).Value = True Then
                    .Rows(vRow).Cells(5).Value = False
                    myProj.DelFromFavorites(vJobNo) 'Deletes from Favorites
                Else
                    .Rows(vRow).Cells(5).Value = True
                    myProj.Add2Favorites(vJobNo) 'Adds to Favorites
                End If
            End With
        End If
        LoadPOHeader()
    End Sub

    Private Sub imgSearch_Click(sender As Object, e As EventArgs) Handles imgSearch.Click
        chkMyJobs.Checked = False
        LoadJobs("Search")
    End Sub

    Private Sub chkMyJobs_CheckedChanged(sender As Object, e As EventArgs) Handles chkMyJobs.Click
        txtSearch.Text = ""
        If chkMyJobs.Checked = True Then
            dvFavorites.RowFilter = "Fav = True"
        Else
            dvFavorites.RowFilter = ""
        End If
    End Sub

    Private Sub dgvPOList_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPOList.ColumnHeaderMouseClick
        ColorUpdate()
    End Sub

    Private Sub dgvPOList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPOList.CellDoubleClick
        vRow = dgvPOList.CurrentRow.Index

        Try
            With dgvPOList.Rows(vRow)
                Project_POImage.txtvarJob.Text = .Cells(0).Value
                Project_POImage.txtvarUnit.Text = .Cells(1).Value
                Project_POImage.txtvarPO.Text = .Cells(2).Value
            End With

            Project_POImage.ShowDialog()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rdoAllPO_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllPO.CheckedChanged, rdoNot.CheckedChanged
        If rdoAllPO.Checked = True Then
            dvPO.RowFilter = ""
            ColorUpdate()
        End If

        If rdoNot.Checked = True Then
            dvPO.RowFilter = "status <> 'COMPLETE'"
            ColorUpdate()
        End If
    End Sub



    '***SUBS***
    Private Sub LoadJobs(vFilter As String)
        If vFilter = "All" Then
            vQuery = "Select *, cast(0 as bit) as Fav from vOpenJobs order by job_no DESC"
        ElseIf vFilter = "Search" Then
            vQuery = "Select *, cast(0 as bit) as Fav from vOpenJobs " &
                     "WHERE job_no like '%" & txtSearch.Text & "%' or job_descr like '%" & txtSearch.Text & "%' " &
                     "ORDER BY job_no DESC"
        End If
        myProj.LoadJobs(vQuery)
        dvFavorites = myProj.FAStQuoteDS.Tables("OpenJobs").DefaultView

        With dgvJobs
            .DataSource = dvFavorites
            .Columns(0).FillWeight = 13 'job_no
            .Columns(0).HeaderText = "Job"
            .Columns(1).FillWeight = 75 'job_descr
            .Columns(1).HeaderText = "Description"
            .Columns(2).Visible = False 'mngr_id
            .Columns(3).Visible = False 'engr_id
            .Columns(4).Visible = False 'salesman_id
            .Columns(5).FillWeight = 12
            .Columns(5).HeaderText = "Fav"
        End With
        vRow = dgvJobs.CurrentRow.Index
        vJobNo = dgvJobs.Rows(vRow).Cells(0).Value

        'IDs user's projects
        Dim tmpFavorites As String
        Dim tmpJob As String 'This is a string because I'm checking against a text field
        For u = 0 To dgvJobs.Rows.Count - 1
            With dgvJobs
                If .Rows(u).Cells(2).Value = myJobs Or
                            .Rows(u).Cells(3).Value = myJobs Or
                            .Rows(u).Cells(4).Value = myJobs Then
                    .Rows(u).Cells(5).Value = True
                End If
                'IDs favorites
                tmpFavorites = myProj.GetMyFavorites()
                If Len(tmpFavorites) > 0 Then
                    tmpJob = .Rows(u).Cells(0).Value
                    If tmpFavorites.Contains(tmpJob) Then
                        .Rows(u).Cells(5).Value = True
                    End If
                End If
            End With
        Next

        LoadPOHeader()
    End Sub

    Private Sub LoadPOHeader()
        myProj.LoadPO(vJobNo)
        myProj.RefreshTables()
        myProj.UpdateTables()
        myProj.Reload_POHead_Details(vJobNo)

        With dgvPOList
            .DataSource = myProj.FAStQuoteDS.Tables("POHead")
            .Columns(0).Visible = False
            .Columns(1).FillWeight = 5%
            .Columns(1).HeaderText = "Unit"
            .Columns(2).FillWeight = 5%
            .Columns(2).HeaderText = "PO"
            .Columns(3).FillWeight = 10%
            .Columns(3).DefaultCellStyle.Format = "d"
            .Columns(3).HeaderText = "Issue"
            .Columns(4).FillWeight = 10%
            .Columns(4).DefaultCellStyle.Format = "d"
            .Columns(4).HeaderText = "Due"
            .Columns(5).FillWeight = 10%
            .Columns(5).DefaultCellStyle.Format = "d"
            .Columns(5).HeaderText = "Late"
            .Columns(6).FillWeight = 30%
            .Columns(6).HeaderText = "Description"
            .Columns(7).FillWeight = 20%
            .Columns(7).HeaderText = "Vendor"
            .Columns(8).Visible = False 'committed
            .Columns(9).Visible = False 'rfq
            .Columns(10).Visible = False 'cancel
            .Columns(11).Visible = False 'deleted
            .Columns(12).FillWeight = 10%
            .Columns(12).HeaderText = "Status"
        End With

        With dgvPODetails
            .DataSource = myProj.FAStQuoteDS.Tables("PODetail")
            .Columns(0).FillWeight = 5%
            .Columns(0).HeaderText = "Job"
            .Columns(1).FillWeight = 5%
            .Columns(1).HeaderText = "Unit"
            .Columns(2).FillWeight = 5%
            .Columns(2).HeaderText = "PO"
            .Columns(3).Visible = False 'Rec
            .Columns(4).FillWeight = 15%
            .Columns(4).HeaderText = "Mfg"
            .Columns(5).FillWeight = 20%
            .Columns(5).HeaderText = "Part Number"
            .Columns(6).FillWeight = 30%
            .Columns(6).HeaderText = "Description"
            .Columns(7).FillWeight = 5%
            .Columns(7).HeaderText = "Qty"
            .Columns(8).FillWeight = 5%
            .Columns(8).HeaderText = "Recv"
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).FillWeight = 10%
            .Columns(11).HeaderText = "Late"
        End With

        With dgvUnitSummary
            .DataSource = myProj.FASDS.Tables("UnitTotals")
            .Columns(0).FillWeight = 12%
            .Columns(0).HeaderText = "Unit"
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).FillWeight = 58%
            .Columns(1).HeaderText = "Unit Name"
            .Columns(2).FillWeight = 30%
            .Columns(2).DefaultCellStyle.Format = "c"
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        'Calculates PO Total Spend
        Dim vTotalSpend As Decimal
        For x = 0 To dgvUnitSummary.Rows.Count - 1
            With dgvUnitSummary
                vTotalSpend = vTotalSpend + .Rows(x).Cells(2).Value
            End With
        Next
        lblTotalPOSpend.Text = "Total PO Spend  " & Format(vTotalSpend, "currency")

        'Fills in Project Team names
        lblPM.Text = myProj.GetName(dgvJobs.Rows(vRow).Cells(2).Value) 'Project Manager
        lblProj.Text = myProj.GetName(dgvJobs.Rows(vRow).Cells(3).Value) 'Project Engineer
        lblSales.Text = myProj.GetName(dgvJobs.Rows(vRow).Cells(4).Value) 'Salesman
        UpdateStatus()
    End Sub

    Private Sub UpdateStatus()
        Dim vUnit As Integer
        Dim vPO As Integer
        Dim vComplete As Boolean = False

        For x = 0 To dgvPOList.Rows.Count - 1 'Sets status on everything BUT Complete
            With dgvPOList
                If .Rows(x).Cells(9).Value = True Then
                    .Rows(x).Cells(12).Value = "RFQ"
                ElseIf .Rows(x).Cells(10).Value = True Or .Rows(x).Cells(11).Value = True Then
                    .Rows(x).Cells(12).Value = "Killed"
                ElseIf .Rows(x).Cells(8).Value = False And .Rows(x).Cells(9).Value = False And (.Rows(x).Cells(10).Value = False Or .Rows(x).Cells(11).Value = False) Then
                    .Rows(x).Cells(12).Value = "Unknown"
                End If
            End With
        Next

        For x = 0 To dgvPOList.Rows.Count - 1 'Checks for Complete POs
            With dgvPOList
                vUnit = .Rows(x).Cells(1).Value
                vPO = .Rows(x).Cells(2).Value
                'Nested loop of PO Details
                For y = 0 To dgvPODetails.Rows.Count - 1
                    With dgvPODetails
                        If .Rows(y).Cells(1).Value = vUnit And .Rows(y).Cells(2).Value = vPO Then
                            If dgvPOList.Rows(x).Cells(8).Value = True Then 'checks to make sure PO is committed
                                If .Rows(y).Cells(7).Value > .Rows(y).Cells(8).Value Then
                                    dgvPOList.Rows(x).Cells(12).Value = "On Order"
                                    vComplete = False
                                    Exit For
                                Else
                                    vComplete = True
                                End If
                            End If
                        End If
                    End With
                    If vComplete = True Then .Rows(x).Cells(12).Value = "COMPLETE"
                Next 'End of nested loop
            End With
            vComplete = False
        Next
        CreateDV()
    End Sub

    Public Sub CreateDV()
        dvPO = myProj.FAStQuoteDS.Tables("POHead").DefaultView
        dvDetail = myProj.FAStQuoteDS.Tables("PODetail").DefaultView
        dvPO.Sort = ("unit_no, po_no")

        dvDetail.Sort = ("unit_no, po_no, rec_no")
        dgvPOList.DataSource = dvPO
        dgvPODetails.DataSource = dvDetail

        ColorUpdate()
    End Sub

    Private Sub ColorUpdate()
        'Formats the row colors of HEADER list based on status
        For i = 0 To dgvPOList.Rows.Count - 1
            With dgvPOList
                If .Rows(i).Cells(12).Value.ToString = "COMPLETE" Then
                    .Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Green
                    .Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.White
                ElseIf .Rows(i).Cells(12).Value.ToString = "On Order" Then
                    .Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Yellow
                ElseIf .Rows(i).Cells(12).Value.ToString = "RFQ" Then
                    .Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Orange
                ElseIf .Rows(i).Cells(12).Value.ToString = "Killed" Then
                    .Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Black
                    .Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.White
                ElseIf .Rows(i).Cells(12).Value.ToString = "Unknown" Then
                    .Rows(i).DefaultCellStyle.BackColor = Drawing.Color.Red
                    .Rows(i).DefaultCellStyle.ForeColor = Drawing.Color.White
                End If
            End With
        Next
        Cursor = Cursors.Default
        dgvPOList.ClearSelection()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Me.groupHeader.Visible = True
            Me.groupDetails.Visible = False
            Me.lbldgvUnitSummary.Visible = True
            Me.dgvUnitSummary.Visible = True
        Else
            Me.groupHeader.Visible = False
            Me.groupDetails.Visible = True
            Me.lbldgvUnitSummary.Visible = False
            Me.dgvUnitSummary.Visible = False
        End If
    End Sub

    Private Sub rdoAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAllItems.CheckedChanged
        If TabControl1.SelectedIndex = 1 Then
            If rdoAllItems.Checked = True Then
                dvDetail.RowFilter = ""
            Else
                dvDetail.RowFilter = "qty > recv"
            End If
        End If
    End Sub
End Class