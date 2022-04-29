Public Class Excess_Transfer
    Dim myDB As New DB_Connections
    Dim vPending As Integer

    Private Sub Excess_Transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountRequests()

    End Sub

    Private Sub btnOpenRequests_Click(sender As Object, e As EventArgs) Handles btnOpenRequests.Click
        btnOpenRequests.Visible = True
        Label1.Visible = True
        dgvExcessRequest.Visible = True
        Label2.Visible = True
        dgvExcessDetails.Visible = True
    End Sub

    Private Sub dgvExcessRequest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExcessRequest.CellClick
        vRow = dgvExcessRequest.CurrentRow.Index
        vExcessID = dgvExcessRequest.Rows(vRow).Cells(0).Value
        LoadDetails()
    End Sub

    Private Sub CountRequests()
        vQuery = "Select * from ExcessRequest " &
                 "WHERE Complete = 0" &
                 "ORDER BY Date"
        myDB.FAStQuoteQuery(vQuery, "ExcessRequest")
        vPending = myDB.FAStQuoteDS.Tables("ExcessRequest").Rows.Count
        lblPendingRequests.Text = vPending

        If vPending > 0 Then
            btnOpenRequests.Visible = True
            LoadRequests()
        Else
            btnOpenRequests.Visible = False
            Label1.Visible = False
            dgvExcessRequest.Visible = False
            Label2.Visible = False
            dgvExcessDetails.Visible = False
        End If


    End Sub

    Private Sub LoadRequests()
        vQuery = "Select * from ExcessRequest " &
                 "WHERE Complete = 0" &
                 "ORDER BY Date"
        myDB.FAStQuoteQuery(vQuery, "ExcessRequest")

        With dgvExcessRequest
            .DataSource = myDB.FAStQuoteDS.Tables("ExcessRequest")
            .Columns(0).Visible = False

            .Columns(1).FillWeight = 15
            .Columns(2).FillWeight = 15
            .Columns(3).FillWeight = 15
            .Columns(4).FillWeight = 25
            .Columns(5).FillWeight = 15
            .Columns(6).FillWeight = 15

            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
        End With

        vExcessID = dgvExcessRequest.Rows(0).Cells(0).Value
        LoadDetails()
    End Sub

    Private Sub LoadDetails()
        vQuery = "Select * from ExcessRequestDetails " &
                 "WHERE ERId = " & vExcessID & " " &
                 "ORDER BY Mfg, CatalogNo"
        myDB.FAStQuoteQuery(vQuery, "ExcessDetails")

        With dgvExcessDetails
            .DataSource = myDB.FAStQuoteDS.Tables("ExcessDetails")
            .Columns(0).Visible = False
            .Columns(1).Visible = False

            .Columns(2).FillWeight = 18
            .Columns(3).FillWeight = 25
            .Columns(4).FillWeight = 25
            .Columns(5).FillWeight = 8
            .Columns(6).FillWeight = 14
            .Columns(7).FillWeight = 10

            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True

            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).DefaultCellStyle.Format = "c"
        End With

    End Sub


End Class