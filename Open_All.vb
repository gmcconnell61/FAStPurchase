Imports System.Data.SqlClient

Public Class Open_All
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

    Private Sub Open_All_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDGV()
    End Sub

    Public Sub LoadDGV()
        'dgvDetails.DataSource = Nothing

        vTotal = 0 'Clears total PO price
        lblPONo.Text = "PO Details"

        myPurch.LoadAllPOHead()
        dgvOpen.DataSource = myPurch.FAStQuoteDS.Tables("AllOpen")
        lblOpen.Text = "Open PO List - " & dgvOpen.Rows.Count

        With dgvOpen
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 8% 'Job
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 7% 'Unit
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 7% 'PO
            .Columns(3).HeaderText = "Issued"
            .Columns(3).DefaultCellStyle.Format = "M/d/yy"
            .Columns(3).FillWeight = 12% 'Issued
            .Columns(4).HeaderText = "Due"
            .Columns(4).DefaultCellStyle.Format = "M/d/yy"
            .Columns(4).FillWeight = 12% 'Due
            .Columns(5).HeaderText = "Description"
            .Columns(5).FillWeight = 33% 'Description
            .Columns(6).HeaderText = "Vendor"
            .Columns(6).FillWeight = 30% 'Vendor
        End With

        LoadRFQ()
        LoadNotAcknowledged()
        LoadUnknown()
        LoadLates()
    End Sub

    Private Sub LoadLates()
        myPurch.LoadLates()
        dgvLate.DataSource = myPurch.FAStQuoteDS.Tables("AllLate")
        lblLate.Text = "Late Orders - " & dgvLate.Rows.Count

        With dgvLate
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 8%
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 7%
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 7%
            .Columns(3).HeaderText = "Issued"
            .Columns(3).DefaultCellStyle.Format = "M/d/yy"
            .Columns(3).FillWeight = 12%
            .Columns(4).HeaderText = "Due"
            .Columns(4).DefaultCellStyle.Format = "M/d/yy"
            .Columns(4).FillWeight = 12%
            .Columns(5).HeaderText = "LateDate"
            .Columns(5).DefaultCellStyle.Format = "d" '"M/d/yy"
            .Columns(5).FillWeight = 12%
            .Columns(6).HeaderText = "Description"
            .Columns(6).FillWeight = 20%
            .Columns(7).HeaderText = "Vendor"
            .Columns(7).FillWeight = 20%
        End With

        With dgvLate
            For x = 0 To dgvLate.Rows.Count - 1
                .Rows(x).Cells(5).Value = myPurch.GetHeaderLateDate(.Rows(x).Cells(0).Value, .Rows(x).Cells(1).Value, .Rows(x).Cells(2).Value)
                If IsDBNull(.Rows(x).Cells(5).Value) = False Then
                    .Rows(x).Cells(5).Style.BackColor = Color.Yellow
                    .Rows(x).Cells(5).Style.ForeColor = Color.Red
                End If
            Next
        End With
    End Sub

    Private Sub dgvLate_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLate.ColumnHeaderMouseClick
        'Reloads late dates and colors after column sort
        With dgvLate
            For x = 0 To dgvLate.Rows.Count - 1
                .Rows(x).Cells(5).Value = myPurch.GetHeaderLateDate(.Rows(x).Cells(0).Value, .Rows(x).Cells(1).Value, .Rows(x).Cells(2).Value)
                If IsDBNull(.Rows(x).Cells(5).Value) = False Then
                    .Rows(x).Cells(5).Style.BackColor = Color.Yellow
                    .Rows(x).Cells(5).Style.ForeColor = Color.Red
                End If
            Next
        End With

    End Sub

    Private Sub LoadRFQ()
        myPurch.LoadRFQ()
        dgvRFQ.DataSource = myPurch.FAStQuoteDS.Tables("AllRFQ")
        lblRFQ.Text = "RFQ - " & dgvRFQ.Rows.Count

        With dgvRFQ
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 15% 'Job
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 12% 'Unit
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 12% 'PO
            .Columns(3).HeaderText = "Vendor"
            .Columns(3).FillWeight = 50% 'Vendor
        End With
    End Sub

    Private Sub LoadNotAcknowledged()
        myPurch.LoadNotAcknowledged()
        dgvNot.DataSource = myPurch.FAStQuoteDS.Tables("AllNot")
        lblNotAck.Text = "Not Acknowledged - " & dgvNot.Rows.Count

        With dgvNot
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 15% 'Job
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 12% 'Unit
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 12% 'PO
            .Columns(3).HeaderText = "Vendor"
            .Columns(3).FillWeight = 50% 'Vendor
        End With
    End Sub

    Private Sub LoadUnknown()
        myPurch.LoadUnknown()
        dgvUnknown.DataSource = myPurch.FAStQuoteDS.Tables("AllUnknown")
        lblUnknown.Text = "Unknown Status - " & dgvUnknown.Rows.Count

        With dgvUnknown
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 15% 'Job
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 12% 'Unit
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 12% 'PO
            .Columns(3).HeaderText = "Vendor"
            .Columns(3).FillWeight = 50% 'Vendor
        End With
    End Sub

    Private Sub DGV_Click(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLate.CellClick, dgvNot.CellClick, dgvOpen.CellClick,
                                                                                    dgvRFQ.CellClick, dgvUnknown.CellClick
        Select Case sender.name
            Case "dgvLate"
                dgvOpen.ClearSelection()
                dgvNot.ClearSelection()
                dgvRFQ.ClearSelection()
                dgvUnknown.ClearSelection()
                vPODesc = sender.CurrentRow.Cells(6).Value 'Here because other DGV don't list this field
                vVendor = sender.CurrentRow.Cells(7).Value
                'Determines which due date
                If IsDBNull(sender.CurrentRow.Cells(5).value) = True Then
                    vDueDate = Format(sender.CurrentRow.Cells(4).Value, "MM/dd/yyyy")
                Else
                    vDueDate = Format(sender.CurrentRow.Cells(5).Value, "MM/dd/yyyy")
                End If
                lblPODueDate.Text = "PO Due Date: " & Format(sender.CurrentRow.Cells(4).Value, "MM/dd/yyyy")
                lblPODueDate.Visible = True
                '***lblShipComplete.Visible = true
            Case "dgvNot"
                dgvOpen.ClearSelection()
                dgvLate.ClearSelection()
                dgvRFQ.ClearSelection()
                dgvUnknown.ClearSelection()
                lblPODueDate.Visible = False
                lblShipComplete.Visible = False
            Case "dgvOpen"
                dgvLate.ClearSelection()
                dgvNot.ClearSelection()
                dgvRFQ.ClearSelection()
                dgvUnknown.ClearSelection()
                vVendor = sender.CurrentRow.Cells(6).Value
                vPODesc = sender.CurrentRow.Cells(5).Value 'Here because other DGV don;t list this field
                vDueDate = sender.CurrentRow.Cells(4).Value
                lblPODueDate.Text = "PO Due Date: " & Format(sender.CurrentRow.Cells(4).Value, "MM/dd/yyyy")
                lblPODueDate.Visible = True
                '***lblShipComplete.Visible = true
            Case "dgvRFQ"
                dgvOpen.ClearSelection()
                dgvNot.ClearSelection()
                dgvLate.ClearSelection()
                dgvUnknown.ClearSelection()
                lblPODueDate.Visible = False
                lblShipComplete.Visible = False
            Case "dgvUnknown"
                dgvOpen.ClearSelection()
                dgvNot.ClearSelection()
                dgvRFQ.ClearSelection()
                dgvLate.ClearSelection()
                lblPODueDate.Visible = False
                lblShipComplete.Visible = False
        End Select

        'Fills in PO Details
        vJob = sender.CurrentRow.Cells(0).Value
        vUnit = sender.CurrentRow.Cells(1).Value
        vPO = sender.CurrentRow.Cells(2).Value

        If myPurch.GetHeaderShipComplete(vJob, vUnit, vPO) = True Then lblShipComplete.Visible = True Else lblShipComplete.Visible = False
        ShowPODetails()

        'Gets PO Notes
        txtPONote.Text = myPurch.GetPONote(vJob, vUnit, vPO)
    End Sub

    Private Sub ShowPODetails()
        If dgvDetails.Columns.Count = 8 Then
            myPurch.LoadPODetails(vJob, vUnit, vPO)
            dgvDetails.DataSource = myPurch.FAStQuoteDS.Tables("PODetails")
            lblPONo.Text = "PO Details for #" & vJob & "-" & vUnit & "-" & vPO
            lblRequestor.Text = "Requestor: " & myPurch.PO_Requestor(vJob, vUnit, vPO)
            GoTo Update_Lates
        End If

        myPurch.LoadPODetails(vJob, vUnit, vPO)
        lblPONo.Text = "PO Details for #" & vJob & "-" & vUnit & "-" & vPO
        lblRequestor.Text = "Requestor: " & myPurch.PO_Requestor(vJob, vUnit, vPO)

        With dgvDetails
            .DataSource = myPurch.FAStQuoteDS.Tables("PODetails")
            .Columns(0).HeaderText = "Rec"
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Mfg"
            .Columns(2).HeaderText = "Catalog No."
            .Columns(3).HeaderText = "Description"
            .Columns(4).HeaderText = "Ord"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderText = "Recv"
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderText = "Price"
            .Columns(6).DefaultCellStyle.Format = "c"
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        'Adds column for LateDate - ONE TIME
        If dgvDetails.Columns.Count = 7 Then
            With dgvDetails
                Dim col As New DataGridViewTextBoxColumn
                col.HeaderText = "LateDate"
                col.DefaultCellStyle.Format = "M/d/yy"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns.Add(col)
            End With

            With dgvDetails
                .Columns(1).FillWeight = 12%
                .Columns(2).FillWeight = 15%
                .Columns(3).FillWeight = 30%
                .Columns(4).FillWeight = 8%
                .Columns(5).FillWeight = 8%
                .Columns(6).FillWeight = 15%
                .Columns(7).FillWeight = 10%

                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
                .Columns(6).ReadOnly = True
                .Columns(7).ReadOnly = False
            End With
        End If

Update_Lates:
        With dgvDetails
            For x = 0 To dgvDetails.Rows.Count - 1
                .Rows(x).Cells(7).Value = myPurch.GetDetailLateDate(vJob, vUnit, vPO, .Rows(x).Cells(0).Value)
                If .Rows(x).Cells(7).Value IsNot Nothing Then
                    .Rows(x).Cells(7).Style.BackColor = Color.Yellow
                    .Rows(x).Cells(7).Style.ForeColor = Color.Red
                End If
            Next
        End With

        'Update Received Quantities
        For r = 0 To dgvDetails.Rows.Count - 1
            With dgvDetails
                .Rows(r).Cells(5).Value = myPurch.GetRecvQty(vJob, vUnit, vPO, .Rows(r).Cells(0).Value)
                If .Rows(r).Cells(5).Value < .Rows(r).Cells(4).Value Then
                    .Rows(r).DefaultCellStyle.BackColor = Color.Red
                    .Rows(r).DefaultCellStyle.ForeColor = Color.White
                End If
            End With
        Next

        'Locks late date cell if item is complete and clears late date from other table
        For l = 0 To dgvDetails.Rows.Count - 1
            With dgvDetails
                If .Rows(l).Cells(5).Value >= .Rows(l).Cells(4).Value Then
                    .Rows(l).Cells(7).ReadOnly = True
                    myPurch.ClearLateDate(vJob, vUnit, vPO, .Rows(l).Cells(0).Value)
                End If
            End With
        Next

        'Hides 0 from quantities where don't belong
        For q = 0 To dgvDetails.Rows.Count - 1
            With dgvDetails
                If .Rows(q).Cells(4).Value = 0 Then
                    .Rows(q).Cells(4).Style.ForeColor = Color.White
                    .Rows(q).Cells(5).Style.ForeColor = Color.White
                    .Rows(q).Cells(6).Style.ForeColor = Color.White
                End If
            End With
        Next

        vTotal = 0
        For t = 0 To dgvDetails.Rows.Count - 1
            vTotal = vTotal + (dgvDetails.Rows(t).Cells(4).Value * dgvDetails.Rows(t).Cells(6).Value)
        Next
        txtPOTotal.Text = Format(vTotal, "currency")
    End Sub

    Private Sub dgvDetails_UpdateLateDates(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetails.CellDoubleClick
        If dgvDetails.CurrentRow.Cells(7).ReadOnly = False Then 'cell is readonly if recv=ordered
            vRow = dgvDetails.CurrentRow.Index
            POLateUpdate.lblJob.Text = vJob
            POLateUpdate.lblUnit.Text = vUnit
            POLateUpdate.lblPO.Text = vPO
            POLateUpdate.lblRec.Text = dgvDetails.Rows(vRow).Cells(0).Value
            POLateUpdate.lblvRow.Text = vRow
            POLateUpdate.lblVendor.Text = vVendor
            POLateUpdate.lblDueDate.Text = vDueDate
            POLateUpdate.lblPartNo.Text = dgvDetails.Rows(vRow).Cells(1).Value & "  " & dgvDetails.Rows(vRow).Cells(2).Value

            POLateUpdate.ShowDialog()
            POLateUpdateNotes.ShowDialog()
        End If
    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        AddNote()
    End Sub

    Public Sub AddNote()

        'Adds note to PO
        Me.txtPONote.ReadOnly = False
        chkCopyElec.Visible = True
        chkCopyMech.Visible = True
        btnSaveNote.Visible = True
        btnAddNote.Visible = False

        If Len(txtPONote.Text) > 0 Then
            NewNote = False
            Me.txtPONote.Text = Format(Now(), "MM/dd/yyyy hh:mm tt") & ": " & vbCrLf & "----------------------------" & vbCrLf & txtPONote.Text
        Else
            NewNote = True
            Me.txtPONote.Text = Format(Now(), "MM/dd/yyyy hh:mm tt") & ":   "
        End If
        txtPONote.Focus()
    End Sub

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        SaveNote(False)
    End Sub

    Public Sub SaveNote(RemoteCall As Boolean) 'Sets NewNote false if called from another form
        If RemoteCall = True Then NewNote = True

        If chkCopyElec.Checked = True And chkCopyMech.Checked = True Then
            varCC = "gmcconnell@factoryautomation.com, RThompson@factoryautomation.com, RKelley@factoryautomation.com"
        ElseIf chkCopyMech.Checked = True And chkCopyElec.Checked = False Then
            varCC = "gmcconnell@factoryautomation.com, RKelley@factoryautomation.com"
        ElseIf chkCopyMech.Checked = False And chkCopyElec.Checked = True Then
            varCC = "gmcconnell@factoryautomation.com, RThompson@factoryautomation.com"
        Else
            varCC = "gmcconnell@factoryautomation.com"
        End If

        If NewNote = True Then
            myPurch.NewPONote(txtPONote.Text, vJob, vUnit, vPO, vPODesc, varCC)
        Else
            myPurch.UpdatePONote(txtPONote.Text, vJob, vUnit, vPO, vPODesc, varCC)
        End If

        Me.txtPONote.ReadOnly = True
        chkCopyElec.Visible = False
        chkCopyMech.Visible = False
        btnSaveNote.Visible = False
        btnAddNote.Visible = True
        btnSaveNote.Visible = False
        varCC = ""
        dgvLate.Focus()
    End Sub

    Public Sub RefreshData()
        If dgvDetails.Columns.Count = 8 Then dgvDetails.Columns.RemoveAt(7)
        dgvDetails.DataSource = Nothing
        dgvOpen.DataSource = Nothing
        dgvLate.DataSource = Nothing
        dgvRFQ.DataSource = Nothing
        dgvNot.DataSource = Nothing
        dgvUnknown.DataSource = Nothing

        LoadDGV()
    End Sub

End Class