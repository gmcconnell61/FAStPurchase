Public Class McMc_StockAllocation
    Dim myImpExp As New ImportExport
    Dim dt As DataTable
    Dim tmpDV As DataView

    Private Sub btnGetFile_Click(sender As Object, e As EventArgs) Handles btnGetFile.Click

        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Excel files |*.xls;*.xlsx"
        dialog.InitialDirectory = "fileserver1\Personal Folders\Purchasing\Mc-Mc Weekly Reports\"
        dialog.Title = "Select Excel File to Import"
        'Encrypt the selected file. I'll do this later. :)
        If dialog.ShowDialog() = DialogResult.OK Then
            dt = myImpExp.ImportExceltoDatatable(dialog.FileName)
        End If

        tmpDV = dt.DefaultView
        tmpDV.Sort = "PO"
        tmpDV.RowFilter = "[Qty Shipped] > 0"
        dgvStockAllocation.DataSource = tmpDV

        With dgvStockAllocation
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False

            .Columns(11).DisplayIndex = 3

            .Columns(11).FillWeight = 8 'PO Number
            .Columns(4).FillWeight = 17 'Part Number
            .Columns(5).FillWeight = 35 'Description
            .Columns(14).FillWeight = 8 'Ordered
            .Columns(15).FillWeight = 8 'Allocated
            .Columns(16).FillWeight = 8 'Needed
            .Columns(17).FillWeight = 8 'PO date
            .Columns(18).FillWeight = 8 'Promise date

        End With
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If rdoJob.Checked = True And Len(txtFilter.Text) > 0 Then
            tmpDV.RowFilter = "[Qty Shipped] > 0 AND PO like'%" + txtFilter.Text + "%'"
        ElseIf rdoPartNo.Checked = True And Len(txtFilter.Text) > 0 Then
            tmpDV.RowFilter = "[Qty Shipped] > 0 AND Product like'%" + txtFilter.Text + "%'"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFilter.Text = Nothing
        tmpDV.RowFilter = "[Qty Shipped] > 0"
    End Sub
End Class