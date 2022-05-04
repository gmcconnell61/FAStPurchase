Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Net

Public Class UpdatePURCH_POTables
    Public FAStQuoteCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FASt-QuoteSQL;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FAStQuoteCmd As New SqlCommand
    Public FAStQuoteDA As New SqlDataAdapter
    Public FAStQuoteDS As DataSet

    Public FASCon As New SqlConnection With {.ConnectionString = "Data Source=FAS-SQL\SQLEXPRESS;Initial Catalog=FAS;Persist Security Info=True;User ID=fas;Password=fas"}
    Public FASCmd As New SqlCommand
    Public FASDA As New SqlDataAdapter
    Public FASDS As DataSet

    Public Sub LoadData()
        'Runs when program opens
        'Updates all PO system

        ClearTable("PurchPOHeader")
        ClearTable("PurchPODetail")
        ClearTable("PurchRecv")
        ClearTable("PurchOpenOrders")

        'Copies data to temp tables
        vQuery = "Insert into PurchPOHeader Select * from vPOHeader"
        AddRecord(vQuery)

        vQuery = "Insert into PurchPODetail Select * from vPODetail "
        AddRecord(vQuery)

        vQuery = "Insert into PurchRecv Select * from vReceived"
        AddRecord(vQuery)

        CalcOpenOrders()

        FAStQuoteCon.Open()
        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = "dbo.PurchOpenOrders"
            Try
                bulkcopy.WriteToServer(FAStQuoteDS.Tables("OpenOrders"))
            Catch ex As Exception
                MsgBox("Open Orders BulkCopy" & vbCrLf & ex.Message)
                If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            End Try
        End Using
        FAStQuoteCon.Close()
    End Sub

    Public Sub CalcOpenOrders()
        vQuery = "SELECT DISTINCT PurchPOHeader.job_no, PurchPOHeader.unit_no, PurchPOHeader.po_no, PurchPOHeader.po_date, " &
                                 "PurchPOHeader.recv_on, PurchPOHeader.po_description, PurchPOHeader.co_name, " &
                                 "PurchPOHeader.po_committed, PurchPOHeader.acknowledged, PurchPOHeader.canceled, PurchPOHeader.deleted, " &
                                 "PurchPOHeader.subcontract " &
                 "FROM PurchPODetail INNER JOIN PurchPOHeader ON PurchPODetail.job_no = PurchPOHeader.job_no " &
                                     "And PurchPODetail.unit_no = PurchPOHeader.unit_no And PurchPODetail.po_no = PurchPOHeader.po_no " &
                 "LEFT OUTER JOIN PurchRecv ON PurchPODetail.job_no = PurchRecv.job_no AND PurchPODetail.unit_no = PurchRecv.unit_no " &
                             "And PurchPODetail.po_no = PurchRecv.po_no And PurchPODetail.rec_no = PurchRecv.rec_no " &
                 "GROUP BY PurchPOHeader.po_date, PurchPOHeader.recv_on, PurchPOHeader.po_description, PurchPOHeader.co_name, " &
                          "PurchPOHeader.unit_no, PurchPOHeader.po_no, PurchPOHeader.job_no, PurchPODetail.quantity, " &
                          "PurchPOHeader.po_committed, PurchPOHeader.acknowledged, PurchPOHeader.subcontract, PurchPOHeader.canceled, " &
                          "PurchPOHeader.deleted, PurchPODetail.rec_no " &
                 "HAVING (SUM(PurchRecv.recv) < PurchPODetail.quantity OR SUM(PurchRecv.recv) IS NULL) AND (PurchPODetail.quantity > 0) " &
                    "And (PurchPOHeader.po_committed = 1) And (PurchPOHeader.canceled = 0) And (PurchPOHeader.deleted = 0) " &
                 "ORDER BY PurchPOHeader.job_no, PurchPOHeader.unit_no, PurchPOHeader.po_no"
        RunQuery(vQuery, "OpenOrders", 1)
    End Sub

    Public Sub LoadAllPOHead()
        vQuery = "Select job_no, unit_no, po_no, po_date, recv_on, po_description, co_name " &
                 "FROM PurchOpenOrders WHERE unit_no < 900 " &
                 "ORDER BY job_no, unit_no, po_no"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllOpen")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("AllOpen PO" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try

    End Sub

    Public Sub LoadLates()
        vQuery = "Select job_no, unit_no, po_no, po_date, recv_on, cast('' as date) as LateDate, po_description, co_name " &
                 "FROM PurchOpenOrders " &
                 "WHERE recv_on < '" & Now() & "' AND unit_no < 900 " &
                 "ORDER BY job_no, unit_no, po_no"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            'FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllLate")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("All Open PO" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Function GetHeaderLateDate(job As Integer, unit As Integer, po As Integer)
        Dim obj As Object
        Dim vquery As String = "SELECT min(LateDate) from POLateDates WHERE Job = " & job & " And Unit = " & unit & " And PO = " & po

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vquery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

            If obj Is Nothing Then
                Return Nothing
            Else
                Return obj
            End If

        Catch ex As Exception
            'MsgBox("Get LateDate - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function GetHeaderShipComplete(job As Integer, unit As Integer, po As Integer) As Boolean
        Dim obj As Object
        Dim vquery As String = "SELECT ship_complete from PurchPOHeader WHERE job_no = " & job & " And unit_no = " & unit & " And po_no = " & po

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vquery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

            Return obj
        Catch ex As Exception
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return False
        End Try
    End Function

    Public Sub LoadRFQ()
        vQuery = "SELECT DISTINCT job_no, unit_no, po_no, co_name " &
                 "FROM PurchPOHeader " &
                 "WHERE (request_for_info = 1) " &
                 "ORDER BY co_name"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            'FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllRFQ")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("RFQ" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Sub LoadNotAcknowledged()
        vQuery = "Select DISTINCT job_no, unit_no, po_no, co_name " &
                 "FROM PurchOpenOrders " &
                 "WHERE acknowledged = 0 " &
                 "ORDER BY co_name"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            'FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllNot")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Not Acknowledged" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Sub LoadUnknown()
        vQuery = "SELECT DISTINCT job_no, unit_no, po_no, co_name " &
                 "FROM PurchPOHeader " &
                 "WHERE (po_committed = 0 And request_for_info = 0 And acknowledged = 0 And canceled = 0 And deleted = 0) " &
                 "ORDER BY job_no, unit_no, po_no"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            'FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllUnknown")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Unknown" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Sub LoadFabrication()
        vQuery = "Select DISTINCT job_no, unit_no, po_no, po_date, recv_on, po_description, co_name " &
                 "FROM PurchOpenOrders " &
                 "WHERE po_committed = 1 " &
                 "And (co_name Like '%Engineered Fabrication%' OR " &
                 "co_name like '%Precision Machine%' OR " &
                 "co_name like '%Jet-Fab%' OR " &
                 "co_name like '%Prince Precision%') " &
                 "ORDER BY co_name, recv_on"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllFab")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Fabrication" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Sub LoadSubcontractor()
        vQuery = "Select DISTINCT job_no, unit_no, po_no, po_date, recv_on, po_description, co_name " &
                 "FROM PurchOpenOrders " &
                 "WHERE (po_committed = 1) AND (subcontract = 1) " &
                 "ORDER BY job_no, unit_no, po_no"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            'FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "AllSub")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Subcontractor" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Sub LoadPODetails(Job As Integer, Unit As Integer, PO As Integer)

        If FAStQuoteDS.Tables.Contains("PODetails") Then
            FAStQuoteDS.Tables("PODetails").Clear()
        End If

        vQuery = "Select rec_no, mfg, part_no, description, quantity, recv, (each * multiplier) as Price " &
                 "FROM PurchPODetail " &
                 "WHERE job_no = " & Job & " AND unit_no = " & Unit & " AND po_no = " & PO
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            'FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "PODetails")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("PODetails" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try
    End Sub

    Public Function GetRecvQty(job As Integer, unit As Integer, po As Integer, rec As Integer)
        Dim obj As Object
        Dim vquery As String = "SELECT recv from PurchRecv WHERE Job_no = " & job & " And Unit_no = " & unit & " And PO_no = " & po & " AND Rec_no = " & rec

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vquery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

            If obj Is Nothing Then
                Return 0
            Else
                Return obj
            End If

        Catch ex As Exception
            MsgBox("Get LateDate - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return 0
        End Try


    End Function
    Public Function GetDetailLateDate(job As Integer, unit As Integer, po As Integer, rec As Integer)
        Dim obj As Object
        Dim vquery As String = "SELECT LateDate from POLateDates WHERE Job = " & job & " And Unit = " & unit & " And PO = " & po & " AND Rec = " & rec

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vquery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

            If obj Is Nothing Then
                Return Nothing
            Else
                Return obj
            End If

        Catch ex As Exception
            MsgBox("Get LateDate - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Function GetDetailPrice(job As Integer, unit As Integer, po As Integer, rec As Integer)
        Dim obj As Object
        Dim vquery As String = "SELECT (each * multiplier) as Cost from PurchPODetail WHERE job_no = " & job & " And unit_no = " & unit & " And po_no = " & po & " AND rec_no = " & rec

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vquery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

            If obj Is Nothing Then
                Return Nothing
            Else
                Return obj
            End If

        Catch ex As Exception
            MsgBox("Get Price - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return Nothing
        End Try
    End Function

    Public Sub ClearLateDate(Job As Integer, Unit As Integer, PO As Integer, Rec As Integer)
        vQuery = "Delete from POLateDates WHERE Job = " & Job & " AND Unit = " & Unit & " AND PO = " & PO & "AND Rec = " & Rec
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Clear Late Date - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try
    End Sub

    Public Function GetPONote(xJob As Integer, xUnit As Integer, xPO As Integer) As String
        Dim obj As Object
        Dim mySqlQuery As String = "SELECT Note from PONotes WHERE Job = " & xJob & " And Unit = " & xUnit & " And PO = " & xPO

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(mySqlQuery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()

            If obj Is Nothing Then
                Return ""
            Else
                Return obj
            End If

        Catch ex As Exception
            MsgBox("Get PO Note - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return ""
        End Try
    End Function

    Public Sub NewPONote(Note As String, xJob As Integer, xUnit As Integer, xPO As Integer, xPODesc As String, varCC As String)
        vQuery = "Insert into PONotes (Job, Unit, PO, Note) VALUES (" & xJob & ", " & xUnit & ", " & xPO & ", '" & Note & "')"

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
            GetRequestorName(Note, xJob, xUnit, xPO, xPODesc, varCC)
        Catch ex As Exception
            MsgBox("New PO Note - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try
    End Sub

    Public Sub UpdatePONote(Note As String, xJob As Integer, xUnit As Integer, xPO As Integer, xPODesc As String, varCC As String)
        vQuery = "Update PONotes set Note = '" & Note & "' WHERE Job = " & xJob & " AND Unit = " & xUnit & " AND PO = " & xPO

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
            GetRequestorName(Note, xJob, xUnit, xPO, xPODesc, varCC)
        Catch ex As Exception
            MsgBox("Update PO Note - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try
    End Sub

    Public Sub SetTickler(xJob As Integer, xUnit As Integer, xPO As Integer, xDate As Date)
        'Check for existing entry
        Dim obj As Object
        Dim mySqlQuery As String = "SELECT Job from PONotes WHERE Job = " & xJob & " AND Unit = " & xUnit & " AND PO = " & xPO
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(mySqlQuery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()

            If obj Is Nothing Then
                vQuery = "Insert into PONotes (Job, Unit, PO, Note, Tickler, TicklerDate) " &
                         "VALUES (" & xJob & ", " & xUnit & ", " & xPO & ", 'Tickler Set', 1, '" & xDate & "')"
            Else
                vQuery = "Update PONotes set Tickler = 1, TicklerDate = '" & xDate & "' WHERE Job = " & xJob & " AND Unit = " & xUnit & " AND PO = " & xPO
            End If

            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Set Tickler - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try
    End Sub

    Public Function LoadTickler() As DataView
        Dim vTickler As DataView
        vQuery = "Select Job, Unit, PO, recv_on, TicklerDate, po_description, company_name " &
                 "FROM tmpAllPOHead INNER JOIN PONotes ON PONotes.Job = tmpAllPOHead.job_no " &
                 "AND PONotes.Unit = tmpAllPOHead.unit_no " &
                 "AND PONotes.PO = tmpAllPOHead.po_no " &
                 "WHERE Tickler = 1 AND TicklerDate >= '" & Format(DateAdd(DateInterval.Day, 1, Now()), "M/d/yyyy") & "'"
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
            FAStQuoteDS = New DataSet
            FAStQuoteDA.Fill(FAStQuoteDS, "Tickler")
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("Load Tickler" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try

        If FAStQuoteDS.Tables("Tickler").Rows.Count = 0 Then
            MsgBox("No filtered records found. ", vbInformation)
            Exit Function
        End If

        vTickler = FAStQuoteDS.Tables("Tickler").DefaultView
        Return vTickler
    End Function


    Public Function PO_Requestor(xJob As Integer, xUnit As Integer, xPO As Integer)
        Dim vRequestor As String
        vQuery = "Select rtrim(employee.f_name) + ' ' + rtrim(employee.l_name) + ', ext. ' + phone_ext as Requestor " &
               "FROM po_header INNER JOIN employee ON employee.emp_id = po_header.requestor_emp_id " &
               "WHERE job_no = " & xJob & " AND unit_no = " & xUnit & " AND po_no = " & xPO

        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            vRequestor = FASCmd.ExecuteScalar()
            FASCon.Close()
            Return vRequestor
        Catch ex As Exception
            MsgBox(ex.Message)
            If FASCon.State = ConnectionState.Open Then
                FASCon.Close()
            End If
            Return Nothing
        End Try

    End Function
    Public Sub GetRequestorName(Note As String, xJob As Integer, xUnit As Integer, xPO As Integer, xPODesc As String, varCC As String)
        Dim vRequestor As String
        vQuery = "Select left(employee.f_name, 1) + rtrim(employee.l_name) as Requestor " &
               "FROM po_header INNER JOIN employee ON employee.emp_id = po_header.requestor_emp_id " &
               "WHERE job_no = " & xJob & " AND unit_no = " & xUnit & " AND po_no = " & xPO

        Try
            FASCon.Open()
            FASCmd = New SqlCommand(vQuery, FASCon)
            vRequestor = FASCmd.ExecuteScalar()
            FASCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If FASCon.State = ConnectionState.Open Then
                FASCon.Close()
            End If
        End Try

        vRequestor = vRequestor & "@factoryautomation.com"
        Dim vRef As String = "A new PO Note has been created on PO #" & xJob & "-" & xUnit & "-" & xPO
        Dim vPONO As String = xJob & "-" & xUnit & "-" & xPO
        SendNoteNotification(vRequestor, vRef, Note, vPONO, xPODesc, varCC)
    End Sub

    Public Sub SendNoteNotification(requestor As String, ref As String, body As String, vPONO As String, xPODesc As String, varCC As String)
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Host = "smtp.office365.com"
            SmtpServer.Credentials = New Net.NetworkCredential("purchasing@factoryautomation.com", "Fas7186!")
            SmtpServer.EnableSsl = True
            SmtpServer.Port = 587
            mail = New MailMessage()
            mail.From = New MailAddress("purchasing@factoryautomation.com")
            mail.To.Add(requestor)
            mail.CC.Add(varCC)
            mail.Subject = ref
            mail.Body = "PO #" & vPONO & "     " & xPODesc & vbCrLf & vbCrLf & body
            SmtpServer.Send(mail)
            SmtpServer.Dispose()
            MailSent = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function Check4LateDates(job As Integer, unit As Integer, po As Integer, rec As Integer)
        Dim obj As Date

        vQuery = "Select LateDate from POLateDates where " &
            "Job = " & job & " AND " &
            "Unit = " & unit & " AND " &
            "PO = " & po & " AND " &
            "Rec = " & rec

        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            obj = FAStQuoteCmd.ExecuteScalar()
            FAStQuoteCon.Close()
            Return obj.ToShortDateString
        Catch ex As Exception
            MsgBox("Check4LateDates - " & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
            Return ""
        End Try
    End Function

    Public Sub LoadItemQuery()
        ClearTable("PurchOpenItems")

        vQuery = "SELECT PurchPODetail.job_no, PurchPODetail.unit_no, PurchPODetail.po_no, PurchPODetail.rec_no, PurchPOHeader.po_date, PurchPOHeader.co_name, PurchPODetail.mfg, rtrim(PurchPODetail.part_no), PurchPODetail.description, PurchPODetail.quantity, " &
                 "SUM(PurchRecv.recv) AS Recv, PurchPOHeader.recv_on " &
                 "FROM PurchPODetail INNER JOIN PurchPOHeader ON PurchPODetail.job_no = PurchPOHeader.job_no AND PurchPODetail.unit_no = PurchPOHeader.unit_no AND PurchPODetail.po_no = PurchPOHeader.po_no " &
                 "LEFT OUTER JOIN PurchRecv ON PurchPODetail.job_no = PurchRecv.job_no AND PurchPODetail.unit_no = PurchRecv.unit_no " &
                 "AND PurchPODetail.po_no = PurchRecv.po_no And PurchPODetail.rec_no = PurchRecv.rec_no " &
                 "GROUP BY PurchPODetail.job_no, PurchPODetail.unit_no, PurchPODetail.po_no, PurchPODetail.rec_no, PurchPOHeader.po_date," &
                 "PurchPODetail.mfg, PurchPODetail.part_no, PurchPODetail.description, PurchPODetail.quantity, PurchPOHeader.co_name, PurchPOHeader.recv_on " &
                 "HAVING (SUM(PurchRecv.recv) < PurchPODetail.quantity Or SUM(PurchRecv.recv) Is NULL) AND (PurchPODetail.quantity > 0) " &
                 "ORDER BY PurchPODetail.mfg, PurchPODetail.part_no"

        RunQuery(vQuery, "OpenItems", 1)

        FAStQuoteCon.Open()
        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = "dbo.PurchOpenItems"
            Try
                bulkcopy.WriteToServer(FAStQuoteDS.Tables("OpenItems"))
            Catch ex As Exception
                MsgBox("Open Items BulkCopy" & vbCrLf & ex.Message)
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

    Public Sub AddRecord(mySqlQuery As String)
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(mySqlQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try

    End Sub

    Public Sub GetYTD_Data(mySQLQuery As String, myTable As String, NewJob As Integer)
        Try
            FASCon.Open()
            FASCmd = New SqlCommand(mySQLQuery, FASCon)
            FASDA = New SqlDataAdapter(FASCmd)
            FASDS = New DataSet
            FASDA.Fill(FASDS, "Vendor")
            FASCon.Close()
        Catch ex As Exception
            MsgBox("GenericSQLQuery" & vbCrLf & ex.Message)
            If FASCon.State = ConnectionState.Open Then
                FASCon.Close()
            End If
        End Try

        Try
            FAStQuoteCon.Open()
            Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
                bulkcopy.DestinationTableName = "dbo.tmpVendor"
                bulkcopy.WriteToServer(FASDS.Tables("Vendor"))
            End Using
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox("GenericSQLQuery - BulkCopy" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try
    End Sub

    Public Sub Mc_Mc()
        vQuery = "Update tmpVendor set vendor_id = 'E0001' WHERE vendor_id = 'E001A'"
        Try
            FAStQuoteCon.Open()
            FAStQuoteCmd = New SqlCommand(vQuery, FAStQuoteCon)
            FAStQuoteCmd.ExecuteNonQuery()
            FAStQuoteCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
        End Try

    End Sub

    Public Sub RunQuery(mySQLQuery As String, myTable As String, NewJob As Integer)
        Try
            FAStQuoteCon.Open()
            If NewJob = 1 Then
                FAStQuoteCmd = New SqlCommand(mySQLQuery, FAStQuoteCon)
                FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
                FAStQuoteDS = New DataSet
                FAStQuoteDA.Fill(FAStQuoteDS, myTable)
            Else
                FAStQuoteCmd = New SqlCommand(mySQLQuery, FAStQuoteCon)
                FAStQuoteDA = New SqlDataAdapter(FAStQuoteCmd)
                FAStQuoteDA.Fill(FAStQuoteDS, myTable)
            End If

            FAStQuoteCon.Close()

        Catch ex As Exception
            MsgBox("RUNQUERY Error" & vbCrLf & ex.Message)
            If FAStQuoteCon.State = ConnectionState.Open Then
                FAStQuoteCon.Close()
            End If
        End Try
    End Sub

    Public Sub Load_McMc(dt As DataTable, tablename As String)
        ClearTable(tablename)

        FAStQuoteCon.Open()
        Using bulkcopy As New SqlBulkCopy(FAStQuoteCon)
            bulkcopy.DestinationTableName = tablename
            Try
                bulkcopy.WriteToServer(dt)
            Catch ex As Exception
                MsgBox("McMc Reports BulkCopy" & vbCrLf & ex.Message)
                If FAStQuoteCon.State = ConnectionState.Open Then FAStQuoteCon.Close()
            End Try
        End Using
        FAStQuoteCon.Close()

    End Sub

End Class
