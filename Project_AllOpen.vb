Public Class Project_AllOpen
    Dim myProj As New UpdatePROJ_Tables

    Private Sub Project_AllOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vQuery = "Select * from vOpenJobs order by job_no DESC"
        myProj.LoadJobs(vQuery)
        With dgvJobs
            .DataSource = myProj.FAStQuoteDS.Tables("OpenJobs")
            .Columns(0).HeaderText = "Job"
            .Columns(1).HeaderText = "Description"
            .Columns(2).HeaderText = "Proj Mgr"
            .Columns(3).HeaderText = "Engineer"
            .Columns(4).HeaderText = "Sales"
            .Columns(0).FillWeight = 10
            .Columns(1).FillWeight = 45
            .Columns(2).FillWeight = 15
            .Columns(3).FillWeight = 15
            .Columns(4).FillWeight = 15
        End With

        For x = 0 To dgvJobs.Rows.Count - 1
            With dgvJobs
                .Rows(x).Cells(2).Value = myProj.GetName(.Rows(x).Cells(2).Value)
                .Rows(x).Cells(3).Value = myProj.GetName(.Rows(x).Cells(3).Value)
                .Rows(x).Cells(4).Value = myProj.GetName(.Rows(x).Cells(4).Value)
            End With
        Next
    End Sub
End Class