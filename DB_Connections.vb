Imports System.Data.SqlClient

Public Class DB_Connections
    Public FAStQuoteCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FASt-QuoteSQL;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FAStQuoteCmd As New SqlCommand
    Public FAStQuoteDA As New SqlDataAdapter
    Public FAStQuoteDS As DataSet

    Public FASCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FAS;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FASCmd As New SqlCommand
    Public FASDA As New SqlDataAdapter
    Public FASDS As DataSet

    Public Sub FAStQuoteQuery(mySQLQuery As String, myTable As String)
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, myTable)
            FAStQuoteCon.Close()
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FASQuery(mySQLQuery As String, myTable As String)
        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            FASDS = New DataSet
            FASDA.Fill(FASDS, myTable)
            FASCon.Close()
        Catch ex As Exception
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FASQuery2(mySQLQuery As String, myTable As String, vNew As Integer)
        'This one is used when I stack queries in the same table
        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            If vNew = 1 Then FASDS = New DataSet
            FASDA.Fill(FASDS, myTable)
            FASCon.Close()
        Catch ex As Exception
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class
