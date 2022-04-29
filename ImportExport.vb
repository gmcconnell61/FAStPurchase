Imports System.Data.SqlClient

Public Class ImportExport
    Public FAStQuoteCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FASt-QuoteSQL;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FAStQuoteCmd As New SqlCommand
    Public FAStQuoteDA As New SqlDataAdapter
    Public FAStQuoteDS As DataSet

    Public Function ImportExceltoDatatable(filepath As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim ds As New DataSet()
            Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filepath & ";Extended Properties=""Excel 12.0;HDR=YES;"""
            Dim con As New OleDb.OleDbConnection(constring & "")

            con.Open()
            Dim myTableName = con.GetSchema("Tables").Rows(0)("TABLE_NAME")
            Dim sqlquery As String = String.Format("SELECT * FROM [{0}]", myTableName) ' "Select * From " & myTableName  
            Dim da As New OleDb.OleDbDataAdapter(sqlquery, con)
            da.Fill(ds)
            'con.Close()

            dt = ds.Tables(0)
            Return dt
            'LoadDataTable(ds.Tables(0))
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
            Return dt
        End Try
    End Function

    Public Sub LoadDataTable(vData As DataTable)
        'Loads new Mc-Mc report to table

        ClearTable("McMcOpenLate")

        FAStQuoteCon.Open()
        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = "McMcOpenLate"
            Try
                bulkcopy.WriteToServer(vData)
            Catch ex As Exception
                MsgBox("McMc Report(s) BulkCopy" & vbCrLf & ex.Message)
                If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            End Try
        End Using
        FAStQuoteCon.Close()
    End Sub

    Public Sub ClearTable(myTable As String)
        'This is called from this Class
        vQuery = "Delete from " & myTable
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

        Catch ex As Exception
            MsgBox("SQLPO Clear Table" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

End Class
