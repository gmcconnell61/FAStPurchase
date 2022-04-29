Public Class POLateUpdate
    Dim myPurch As New UpdatePURCH_POTables

    Private Sub POLateDateUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNewDate.ResetText()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If myPurch.GetDetailLateDate(lblJob.Text, lblUnit.Text, lblPO.Text, lblRec.Text) Is Nothing Then
            vQuery = "Insert into POLateDates (Job, Unit, PO, Rec, LateDate) " &
                     "VALUES (" & lblJob.Text & ", " & lblUnit.Text & ", " & lblPO.Text & ", " & lblRec.Text & ", '" & dtpNewDate.Value & "')"
        Else
            vQuery = "Update POLateDates set LateDate = '" & dtpNewDate.Value & "' " &
                     "WHERE  Job = " & lblJob.Text & " AND Unit = " & lblUnit.Text & " AND PO = " & lblPO.Text & " AND Rec = " & lblRec.Text
        End If
        myPurch.AddRecord(vQuery)
        Open_All.dgvDetails.Rows(lblvRow.Text).Cells(7).Value = Format(dtpNewDate.Value, "M/d/yyyy")

        If Len(tmpNewNote) < 1 Then
            tmpNewNote = Format(Now(), "MM/dd/yyyy hh:mm tt") & ":   " & lblVendor.Text & vbCrLf _
                       & lblPartNo.Text & "  Old Date " & lblDueDate.Text & " ----> New Date " & Format(dtpNewDate.Value, "MM/dd/yyyy")
        Else
            tmpNewNote = tmpNewNote & vbCrLf & lblPartNo.Text & "  Old Date " & lblDueDate.Text & " ----> New Date " & Format(dtpNewDate.Value, "MM/dd/yyyy")
        End If

        Me.Close()
    End Sub

End Class