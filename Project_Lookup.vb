Public Class Project_Lookup
    Dim myDB As New DB_Connections
    Dim myProj As New UpdatePROJ_Tables

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        JobQuery()
    End Sub

    Private Sub JobQuery()
        Dim x As Integer = 0

        vQuery = "Select job_no, job_descr, quote_no, po_no, mngr_id, engr_id, salesman_id, start_date, close_date, status " &
                   "FROM job_master "

        For i = 1 To 4
            Select Case i
                Case 1 'test jobNo
                    If Me.txtJobNo.TextLength > 0 Then
                        vQuery = vQuery & " WHERE job_no like '%" & Me.txtJobNo.Text & "%' "
                        x = 1
                    End If
                Case 2 'test Quote No
                    If Me.txtQuoteNo.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND quote_no like '%" & Me.txtQuoteNo.Text & "%' "
                    ElseIf Me.txtQuoteNo.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE quote_no like '%" & Me.txtQuoteNo.Text & "%' "
                        x = 1
                    End If
                Case 3 'test PO Number
                    If Me.txtCustPO.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND po_no like '%" & Me.txtCustPO.Text & "%' "
                    ElseIf Me.txtCustPO.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE po_no like '%" & Me.txtCustPO.Text & "%' "
                        x = 1
                    End If
                Case 4 'test Description
                    If Me.txtDescription.TextLength > 0 And x > 0 Then
                        vQuery = vQuery & " AND job_descr like '%" & Me.txtDescription.Text & "%' "
                    ElseIf Me.txtDescription.TextLength > 0 And x = 0 Then
                        vQuery = vQuery & " WHERE job_descr like '%" & Me.txtDescription.Text & "%' "
                        x = 1
                    End If
            End Select
        Next

        vQuery = vQuery & " Order by job_no DESC"
        myDB.FASQuery(vQuery, "Jobs")

        With dgvJobQuery
            .DataSource = myDB.FASDS.Tables("Jobs")
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 5
            .Columns(1).HeaderText = "Job Description"
            .Columns(1).FillWeight = 21
            .Columns(2).HeaderText = "Quote No."
            .Columns(2).FillWeight = 10
            .Columns(3).HeaderText = "PO No."
            .Columns(3).FillWeight = 10
            .Columns(4).HeaderText = "PM"
            .Columns(4).FillWeight = 13
            .Columns(5).HeaderText = "Eng"
            .Columns(5).FillWeight = 13
            .Columns(6).HeaderText = "Sales"
            .Columns(6).FillWeight = 13
            .Columns(7).HeaderText = "Start"
            .Columns(7).FillWeight = 5
            .Columns(7).DefaultCellStyle.Format = "d"
            .Columns(8).HeaderText = "Closed"
            .Columns(8).FillWeight = 5
            .Columns(8).DefaultCellStyle.Format = "d"
            .Columns(9).HeaderText = "Status"
            .Columns(9).FillWeight = 5
        End With

        'Replaces empID with Name
        For x = 0 To dgvJobQuery.Rows.Count - 1
            With dgvJobQuery
                .Rows(x).Cells(4).Value = myProj.GetNameExt(.Rows(x).Cells(4).Value)
                .Rows(x).Cells(5).Value = myProj.GetNameExt(.Rows(x).Cells(5).Value)
                .Rows(x).Cells(6).Value = myProj.GetNameExt(.Rows(x).Cells(6).Value)
            End With
        Next
    End Sub

End Class