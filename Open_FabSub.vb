
Imports System.Data.SqlClient
Class Open_FabSub
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

    Private Sub Open_FabSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFabrication()
        LoadSubcontractors()
    End Sub

    Private Sub LoadFabrication()
        myPurch.LoadFabrication()
        dgvFabrication.DataSource = myPurch.FAStQuoteDS.Tables("AllFab")
        lblFab.Text = "Fabrication - " & dgvFabrication.Rows.Count
        With dgvFabrication
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 8% 'Job
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 7% 'Unit
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 7% 'PO
            .Columns(3).HeaderText = "Issued"
            .Columns(3).DefaultCellStyle.Format = "d"
            .Columns(3).FillWeight = 12% 'Issued
            .Columns(4).HeaderText = "Due"
            .Columns(4).DefaultCellStyle.Format = "d"
            .Columns(4).FillWeight = 12% 'Due
            .Columns(5).HeaderText = "Description"
            .Columns(5).FillWeight = 35% 'Description
            .Columns(6).HeaderText = "Vendor"
            .Columns(6).FillWeight = 25% 'Vendor
        End With
    End Sub

    Private Sub LoadSubcontractors()
        myPurch.LoadSubcontractor()
        dgvSubcontractor.DataSource = myPurch.FAStQuoteDS.Tables("AllSub")
        lblSub.Text = "Subcontractor - " & dgvSubcontractor.Rows.Count

        With dgvSubcontractor
            .Columns(0).HeaderText = "Job"
            .Columns(0).FillWeight = 8% 'Job
            .Columns(1).HeaderText = "Unit"
            .Columns(1).FillWeight = 7% 'Unit
            .Columns(2).HeaderText = "PO"
            .Columns(2).FillWeight = 7% 'PO
            .Columns(3).HeaderText = "Issued"
            .Columns(3).DefaultCellStyle.Format = "d"
            .Columns(3).FillWeight = 12% 'Issued
            .Columns(4).HeaderText = "Due"
            .Columns(4).DefaultCellStyle.Format = "d"
            .Columns(4).FillWeight = 12% 'Due
            .Columns(5).HeaderText = "Description"
            .Columns(5).FillWeight = 35% 'Description
            .Columns(6).HeaderText = "Vendor"
            .Columns(6).FillWeight = 25% 'Vendor
        End With
    End Sub

    Private Sub DGV_Click(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFabrication.CellClick, dgvSubcontractor.CellClick
        Select Case sender.name
            Case "dgvFabrication"
                dgvSubcontractor.ClearSelection()
            Case "dgvSubcontractor"
                dgvFabrication.ClearSelection()
        End Select

        'Fills in PO Details
        vJob = sender.CurrentRow.Cells(0).Value
        vUnit = sender.CurrentRow.Cells(1).Value
        vPO = sender.CurrentRow.Cells(2).Value

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
End Class