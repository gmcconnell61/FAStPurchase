Imports System.Data.SqlClient

Public Class UpdatePROJ_Tables
    Public FAStQuoteCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FASt-QuoteSQL;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FAStQuoteCmd As New SqlCommand
    Public FAStQuoteDA As New SqlDataAdapter
    Public FAStQuoteDS As DataSet

    Public FASCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FAS;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FASCmd As New SqlCommand
    Public FASDA As New SqlDataAdapter
    Public FASDS As DataSet

    Public Sub LoadJobs(myQuery As String)
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(myQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "OpenJobs")
            FAStQuoteCon.Close()
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub LoadPO(Job As Integer)
        FASCon.Close()
        'Loads PO Header for Project Status
        vQuery = "SELECT po_header.job_no, po_header.unit_no, po_header.po_no, po_header.po_date, po_header.recv_on, " &
                 "po_header.po_description, vendor.co_name, po_header.po_committed, po_header.acknowledged, po_header.request_for_info, " &
                 "po_header.canceled, po_header.deleted, po_header.subcontract, status='' " &
                 "FROM po_header INNER Join vendor On po_header.vendor_id = vendor.vendor_id " &
                 "WHERE po_header.job_no = " & Job
        FASCon.Open()
        Try
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            FASDS = New DataSet
            FASDA.Fill(FASDS, "POHead")
        Catch ex As Exception
            MsgBox("SQL PO 'LoadPOHead'" & vbCrLf & ex.Message)
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
        End Try

        'Loads PO Details Project Status
        vQuery = "SELECT job_no, unit_no, po_no, rec_no, mfg, part_no, description, quantity, recv=0, each, multiplier " &
                 "FROM po_detail " &
                 "WHERE job_no = " & Job
        Try
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            FASDA.Fill(FASDS, "PODetail")
        Catch ex As Exception
            MsgBox("SQL PO 'LoadPODetail'" & vbCrLf & ex.Message)
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
        End Try

        'Loads Receiving records
        vQuery = "SELECT receive_header.job_no, receive_header.unit_no, receive_header.po_no, receive_detail.rec_no, Sum(receive_detail.received) AS recv " &
                 "FROM receive_header INNER JOIN receive_detail ON receive_header.receive_no = receive_detail.receive_no " &
                 "GROUP BY receive_header.job_no, receive_header.unit_no, receive_header.po_no, receive_detail.rec_no " &
                 "HAVING receive_header.job_no=" & Job
        Try
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            FASDA.Fill(FASDS, "Recv")
        Catch ex As Exception
            MsgBox("SQL PO 'LoadPORecv'" & vbCrLf & ex.Message)
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
        End Try

        'Loads Unit Totals
        vQuery = "SELECT po_detail.unit_no, unit_numbers.description, Sum([quantity]*[each]*[multiplier]) AS Total " &
                 "FROM unit_numbers INNER JOIN po_detail ON (unit_numbers.unit_no = po_detail.unit_no) AND (unit_numbers.job_no = po_detail.job_no) " &
                "INNER JOIN po_header ON (po_detail.po_no = po_header.po_no) AND (po_detail.unit_no = po_header.unit_no) AND (po_detail.job_no = po_header.job_no) " &
                "GROUP BY po_detail.unit_no, unit_numbers.description, po_detail.job_no, po_header.po_committed " &
                 "HAVING po_detail.job_no = " & Job & " AND po_header.po_committed = 1"
        Try
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            'FASDS = New DataSet
            FASDA.Fill(FASDS, "UnitTotals")
        Catch ex As Exception
            MsgBox("SQL PO 'LoadPO UnitTotal'" & vbCrLf & ex.Message)
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
        End Try

        FASCon.Close()
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

    Public Sub RefreshTables()
        'Clears existing data in temp tables
        ClearTable("myPOHead")
        ClearTable("myPODetail")
        ClearTable("myRecv")
        ClearTable("myInvoice")
        ClearTable("myRecvDollars")

        'Copies data to temp tables
        FAStQuoteCon.Open()
        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = "dbo.myPOHead"
            Try
                bulkcopy.WriteToServer(FASDS.Tables("POHead"))
            Catch ex As Exception
                MsgBox("POHead BulkCopy" & vbCrLf & ex.Message)
                If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            End Try
        End Using

        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = "dbo.myPODetail"
            Try
                bulkcopy.WriteToServer(FASDS.Tables("PODetail"))
            Catch ex As Exception
                MsgBox("PODetail BulkCopy" & vbCrLf & ex.Message)
                If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            End Try
        End Using

        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = "dbo.myRecv"
            Try
                bulkcopy.WriteToServer(FASDS.Tables("Recv"))
            Catch ex As Exception
                MsgBox("Recv BulkCopy" & vbCrLf & ex.Message)
                If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            End Try
        End Using

        FAStQuoteCon.Close()
    End Sub

    Public Sub UpdateTables()
        FAStQuoteCon.Open()

        'Update PODetail.Recv
        vQuery = "UPDATE myPODetail Set myPODetail.recv = [myRecv].[recv] " &
                 "FROM myRecv INNER JOIN myPODetail On (myPODetail.rec_no = myRecv.rec_no) " &
                 "And (myPODetail.po_no = myRecv.po_no) " &
                 "And (myPODetail.unit_no = myRecv.unit_no) " &
                 "And (myPODetail.job_no = myRecv.job_no)"
        Try
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Update Recv" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            Exit Sub
        End Try

        FAStQuoteCon.Close()
    End Sub

    Public Sub Reload_POHead_Details(Job As Integer)
        'Refreshes POHead.Max Late Date
        vQuery = "SELECT myPOHead.job_no, myPOHead.unit_no, myPOHead.po_no, myPOHead.po_date, myPOHead.recv_on, Max(POLateDates.LateDate) AS MaxOfLateDate, " &
                 "myPOHead.po_description, myPOHead.co_name, myPOHead.po_committed, myPOHead.request_for_info, myPOHead.canceled, myPOHead.deleted, status " &
                 "FROM myPOHead LEFT JOIN POLateDates ON (myPOHead.po_no = POLateDates.PO) AND (myPOHead.unit_no = POLateDates.Unit) " &
                 "AND (myPOHead.job_no = POLateDates.Job) " &
                 "GROUP BY myPOHead.job_no, myPOHead.unit_no, myPOHead.po_no, myPOHead.po_date, myPOHead.recv_on, " &
                 "myPOHead.po_description, myPOHead.co_name, myPOHead.po_committed, myPOHead.request_for_info, myPOHead.canceled, myPOHead.deleted, status " &
                 "HAVING myPOHead.job_no=" & Job
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "POHead")

            'Refreshes PO Details
            vQuery = "SELECT myPODetail.*, POLateDates.LateDate " &
                     "FROM myPODetail LEFT JOIN POLateDates ON (myPODetail.job_no = POLateDates.Job) AND " &
                     "(myPODetail.unit_no = POLateDates.Unit) AND (myPODetail.po_no = POLateDates.PO) AND (myPODetail.rec_no = POLateDates.Rec) " &
                     "WHERE myPODetail.job_no=" & Job & " AND myPODetail.qty>0 " &
                     "ORDER BY job_no, unit_no, po_no, rec_no"

            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDA.Fill(FAStQuoteDS, "PODetail")
            FAStQuoteCon.Close()
            dvPODetail = FAStQuoteDS.Tables("PODetail").DefaultView
        Catch ex As Exception
            MsgBox("Reload Project" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try

        'Loads Unit Totals
        vQuery = "Select po_detail.unit_no, unit_numbers.description, Sum([quantity]*[each]*[multiplier]) As Total " &
                 "FROM unit_numbers INNER JOIN po_detail On (unit_numbers.unit_no = po_detail.unit_no) And (unit_numbers.job_no = po_detail.job_no) " &
                 "GROUP BY po_detail.unit_no, unit_numbers.description, po_detail.job_no " &
                 "HAVING po_detail.job_no = " & Job
        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            FASDS = New DataSet
            FASDA.Fill(FASDS, "UnitTotals")
            FASCon.Close()
        Catch ex As Exception
            MsgBox("SQL PO 'LoadPO UnitTotal'" & vbCrLf & ex.Message)
            If FASCon.State = ConnectionState.Open Then FASCon.Close()
        End Try

        'dvProjHead = FAStQuoteDS.Tables("POHead").DefaultView
        'dvProjDetail = FAStQuoteDS.Tables("PODetail").DefaultView
        'dvProjUnitTotals = FASDS.Tables("UnitTotals").DefaultView
    End Sub

    Public Function GetName(empID As String)
        Dim obj As Object
        vQuery = "Select rtrim(l_name) + ', ' + rtrim(f_name) as Name " &
                 "FROM employee " &
                 "WHERE emp_id = '" & empID & "'"
        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            obj = FASCmd.ExecuteScalar
            FASCon.Close()
            Return obj
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            Return ""
        End Try
    End Function

    Public Function GetNameExt(empID As String)
        Dim obj As Object
        vQuery = "Select rtrim(l_name) + ', ' + rtrim(f_name) + ', ext. ' + phone_ext as Name " &
                 "FROM employee " &
                 "WHERE emp_id = '" & empID & "'"
        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            obj = FASCmd.ExecuteScalar
            FASCon.Close()
            Return obj
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            Return ""
        End Try
    End Function

    Public Sub Add2Favorites(Job As Integer)
        Dim obj As Object
        Dim tmpFav As String
        vQuery = "Select Favorites from FAStUsers WHERE UserID = '" & vUser & "'"
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar

            If IsDBNull(obj) = True Then 'new user added
                vQuery = "Insert into FAStUsers (UserID, UserName, AppLevel, StartScreen, Favorites) " &
                         "VALUES ('" & vUser & "', '', 2, 'POLookup', " & Job & " )"
            Else 'User exists
                tmpFav = obj & Job & ", "
                vQuery = "Update FAStUsers set Favorites = '" & tmpFav & "' WHERE UserID = '" & vUser & "'"
            End If
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Sub DelFromFavorites(Job As Integer)
        Dim obj As Object
        Dim tmpFav As String
        vQuery = "Select Favorites from FAStUsers WHERE UserID = '" & vUser & "'"
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar

            tmpFav = obj.Replace(Job & ", ", "") 'removes job # from Favorites

            vQuery = "Update FAStUsers set Favorites = '" & tmpFav & "' WHERE UserID = '" & vUser & "'"
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetMyFavorites()
        Dim obj As Object
        vQuery = "Select Favorites from FAStUsers WHERE UserID = '" & vUser & "'"
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar
            FAStQuoteCon.Close()
            If IsDBNull(obj) = True Then
                Return Nothing
            Else
                Return obj
            End If
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            Return Nothing
        End Try

    End Function
End Class
