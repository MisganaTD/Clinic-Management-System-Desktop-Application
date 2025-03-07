Imports System.Data.SqlClient
Public Class Store
    Dim index As Integer
#Region "Conn for DESKTOP-QKNE475"
    Public con As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
#End Region
#Region "Conn for Server"

#End Region
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProviderregmed.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#Region "Store_Load form"
    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(Mainmenu.Left + 25, Mainmenu.Top + 45)
        FilterData("")
        FilterDataForitemreqnow("") 'For current date requested item
        btndeleteitem.Visible = False
        btnedititem.Visible = False
        '--------------------------------------------------------------------------
        Dim GetCode As String = "0"
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = con
        command.CommandText = "SELECT TOP(1) * FROM mainstoretbl ORDER BY stockid DESC"
        Try
            con.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetString(reader.GetOrdinal("stockid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        'If (GetCode = "0") Then
        '    txtboxsi.Text = "SId1"
        'ElseIf (GetCode <> "0") Then
        '    Dim TotalCodeWithoutLable As String = GetCode.Count - 3
        '    Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
        '    txtboxsi.Text = "SId" + Format(OldNum + 1).ToString
        If (GetCode = "0") Then
            txtboxsi.Text = "SId0000001"
        ElseIf (GetCode <> "0") Then
            Dim TotalCodeWithoutLable As String = GetCode.Count - 3
            Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
            txtboxsi.Text = "SId" + Format(OldNum + 1, "0000000").ToString
            txtboxnhf.Clear()
            txtboxpnsdf.Clear()
            txtboxui.Clear()
            txtboxmsl.Clear()
            txtboxeop.Clear()
            txtboxamc.Clear()
            txtboxdocno.Clear()
            txtboxrforit.Clear()
            txtboxqr.Clear()
            txtboxqi.Clear()
            txtboxql.Clear()
            txtboxqb.Clear()
            txtboxbno.Clear()
            'DateTimePickerexpirydate
            txtboxremark.Clear()
            txtboxsearchitem.Clear()
            txtboxnhf.Focus()
        End If
        '-----------------Fill Auto Complete for product name ------------------------------
        Try
            'Dim cmdtel As
            Dim phyid As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            ' Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim qnp As Integer = 0
            Dim command1p As New SqlCommand("select productname from productlisttbl", con)
            'Dim datel As 
            Dim daap As New SqlClient.SqlDataAdapter(command1p)
            Dim dstelp As DataSet = New DataSet
            daap.Fill(dstelp, "productlisttbl")
            Dim coltelp As New AutoCompleteStringCollection
            For i = 0 To dstelp.Tables(0).Rows.Count - 1
                coltelp.Add(dstelp.Tables(0).Rows(i)(0).ToString)
            Next
            txtboxpnsdf.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtboxpnsdf.AutoCompleteCustomSource = coltelp
            txtboxpnsdf.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
        '-----------------Fill Auto Complete for unit name ------------------------------
        Try
            'Dim cmdtel As
            Dim phyid As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            ' Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim qnpu As Integer = 0
            Dim command1pu As New SqlCommand("select unitname from unitlisttbl", con)
            'Dim datel As 
            Dim daapu As New SqlClient.SqlDataAdapter(command1pu)
            Dim dstelpu As DataSet = New DataSet
            daapu.Fill(dstelpu, "unitlisttbl")
            Dim coltelpu As New AutoCompleteStringCollection
            For i = 0 To dstelpu.Tables(0).Rows.Count - 1
                coltelpu.Add(dstelpu.Tables(0).Rows(i)(0).ToString)
            Next
            txtboxui.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtboxui.AutoCompleteCustomSource = coltelpu
            txtboxui.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "Referesh Store form"
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Controls.Clear()
        InitializeComponent()
        Store_Load(e, e)
        Refresh()
    End Sub
#End Region
#Region "Import stock from excel file to database"
    Private Sub btnimportstockfromexcelfile_Click(sender As Object, e As EventArgs) Handles btnimportstockfromexcelfile.Click

    End Sub
#End Region
#Region "Add Stock to db"
    Private Sub btnadditem_Click(sender As Object, e As EventArgs) Handles btnadditem.Click
        If vld(txtboxsi, txtboxnhf, txtboxpnsdf, txtboxui, txtboxapv, txtboxmsl, txtboxeop, txtboxamc, txtboxdocno, txtboxrforit, txtboxqr, txtboxqi, txtboxql, txtboxqb, txtboxbno, txtboxremark) = False Then
            'Exit Sub
            'DateTimePickermanufmed
            'DateTimePickerexpimed
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            con.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select stockid from mainstoretbl where stockid=@uid", con)
            cmdep.Parameters.AddWithValue("@uid", txtboxsi.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                MsgBox("Stock id already exist please try again!", MsgBoxStyle.Critical)
            Else
                Dim regbyeid As String = Mainmenu.lblEID.Text
                'Dim regby As String = Mainmenu.lblusername.Text 'userName.ToString()
                Dim curentDate As DateTime = DateTime.Today
                'Dim tq As Integer = CInt(txtboxq.Text) 'for ineger conversion
                Dim apiecexasked As Integer = CInt(txtboxapv.Text) * CInt(txtboxqb.Text)
                Dim insertQery As String = "insert into mainstoretbl(stockid, namehealthfacility, productnamestrengthdosageform, unitofissue, maximumstocklevel, emergencyorderpoint, averagemonthlyconsumption,regdate, docnoreceivingorissueing, receivedfromorissuedto, quantyreceived, quantyissued, quantylossoradjustment, quantybalance, batchno, expirydate, remark, regbyempid,apiecevalue, balancevalueofpieceandasked) values('" & txtboxsi.Text & "','" & txtboxnhf.Text & "','" & txtboxpnsdf.Text & "', '" & txtboxui.Text & "','" & txtboxmsl.Text & "','" & txtboxeop.Text & "','" & txtboxamc.Text & "','" & curentDate.ToShortDateString() & "','" & txtboxdocno.Text & "','" & txtboxrforit.Text & "','" & txtboxqr.Text & "','" & txtboxqi.Text & "','" & txtboxql.Text & "','" & txtboxqb.Text & "','" & txtboxbno.Text & "','" & DateTimePickerexpirydate.Value.ToShortDateString() & "','" & txtboxremark.Text & "','" & regbyeid & "', '" & txtboxapv.Text & "', '" & apiecexasked & "')"
                InsertUpdateDelete(insertQery)
                MessageBox.Show("Stock successfully added", "Data Added - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtboxsi.Clear()
                txtboxnhf.Clear()
                txtboxpnsdf.Clear()
                txtboxui.Clear()
                txtboxapv.Clear()
                txtboxmsl.Clear()
                txtboxeop.Clear()
                txtboxamc.Clear()
                txtboxdocno.Clear()
                txtboxrforit.Clear()
                txtboxqr.Clear()
                txtboxqi.Clear()
                txtboxql.Clear()
                txtboxqb.Clear()
                txtboxbno.Clear()
                'DateTimePickerexpirydate
                txtboxremark.Clear()
                txtboxsearchitem.Clear()
                txtboxsi.Focus()
            End If
        End If
        con.Close()
    End Sub
#End Region
#Region "Edit Item from stock tbl"
    Private Sub btnedititem_Click(sender As Object, e As EventArgs) Handles btnedititem.Click
        If vld(txtboxsi, txtboxnhf, txtboxpnsdf, txtboxui, txtboxmsl, txtboxeop, txtboxamc, txtboxdocno, txtboxrforit, txtboxqr, txtboxqi, txtboxql, txtboxqb, txtboxbno, txtboxremark) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            con.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select stockid from mainstoretbl where stockid=@mid", con)
            cmdep.Parameters.AddWithValue("@mid", txtboxsi.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                Dim updatedby As String = Mainmenu.lblEID.Text 'userName.ToString()
                Dim updtequery As String = "update mainstoretbl set namehealthfacility ='" & txtboxnhf.Text & "',productnamestrengthdosageform='" & txtboxpnsdf.Text & "',unitofissue ='" & txtboxui.Text & "',maximumstocklevel='" & txtboxmsl.Text & "', emergencyorderpoint='" & txtboxeop.Text & "',averagemonthlyconsumption='" & txtboxamc.Text & "',docnoreceivingorissueing ='" & txtboxdocno.Text & "', receivedfromorissuedto='" & txtboxrforit.Text & "', quantyreceived='" & txtboxqr.Text & "', quantyissued ='" & txtboxqi.Text & "', quantylossoradjustment='" & txtboxql.Text & "', quantybalance='" & txtboxqb.Text & "',batchno = '" & txtboxbno.Text & "',expirydate='" & DateTimePickerexpirydate.Value.ToShortDateString() & "',regbyempid='" & updatedby & "',remark='" & txtboxremark.Text & "' where stockid='" & txtboxsi.Text & "'"
                InsertUpdateDelete(updtequery)
                MessageBox.Show("Stock item successfully edited !", "Data updated - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully updated!")
                txtboxsi.Clear()
                txtboxnhf.Clear()
                txtboxpnsdf.Clear()
                txtboxui.Clear()
                txtboxmsl.Clear()
                txtboxeop.Clear()
                txtboxamc.Clear()
                txtboxdocno.Clear()
                txtboxrforit.Clear()
                txtboxqr.Clear()
                txtboxqi.Clear()
                txtboxql.Clear()
                txtboxqb.Clear()
                txtboxbno.Clear()
                'DateTimePickerexpirydate
                txtboxremark.Clear()
                txtboxsearchitem.Clear()
                txtboxsi.Focus()
            Else
                MsgBox("No such Stock id exist please try again!", MsgBoxStyle.Critical)
            End If
        End If
        con.Close()
    End Sub
    Private Sub DataGridViewStockdata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStockdata.CellContentClick
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewStockdata.Rows(index)
            txtboxsi.Text = selectedRow.Cells(0).Value.ToString
            txtboxnhf.Text = selectedRow.Cells(1).Value.ToString
            txtboxpnsdf.Text = selectedRow.Cells(2).Value.ToString
            txtboxui.Text = selectedRow.Cells(3).Value.ToString
            txtboxmsl.Text = selectedRow.Cells(4).Value.ToString
            txtboxeop.Text = selectedRow.Cells(5).Value.ToString
            txtboxamc.Text = selectedRow.Cells(6).Value.ToString
            txtboxdocno.Text = selectedRow.Cells(8).Value.ToString
            txtboxrforit.Text = selectedRow.Cells(9).Value.ToString
            txtboxqr.Text = selectedRow.Cells(10).Value.ToString
            txtboxqi.Text = selectedRow.Cells(11).Value.ToString
            txtboxql.Text = selectedRow.Cells(12).Value.ToString
            txtboxqb.Text = selectedRow.Cells(13).Value.ToString
            txtboxbno.Text = selectedRow.Cells(14).Value.ToString
            DateTimePickerexpirydate.Text = selectedRow.Cells(15).Value.ToString
            txtboxremark.Text = selectedRow.Cells(16).Value.ToString
            txtboxapv.Text = selectedRow.Cells(18).Value.ToString
            btnadditem.Visible = False
            btnclear.Visible = False
        Catch ex As Exception
            MsgBox("Ctrl + C to copy stock details from database", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "Delete item from stock tbl"
    Private Sub btndeleteitem_Click(sender As Object, e As EventArgs) Handles btndeleteitem.Click
        If vld(txtboxsi) = False Then
            'Exit Sub
            MsgBox("Please select item id from the list to delete the stock item", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to delete this stock item from database?") Then
            Dim dletequery As String = "delete from mainstoretbl where stockid='" & txtboxsi.Text & "'"
            If InsertUpdateDelete(dletequery) Then
                MessageBox.Show("Stock item successfully deleted !", "Data deleted - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtboxsi.Clear()
                txtboxnhf.Clear()
                txtboxpnsdf.Clear()
                txtboxui.Clear()
                txtboxmsl.Clear()
                txtboxeop.Clear()
                txtboxamc.Clear()
                txtboxdocno.Clear()
                txtboxrforit.Clear()
                txtboxqr.Clear()
                txtboxqi.Clear()
                txtboxql.Clear()
                txtboxqb.Clear()
                txtboxbno.Clear()
                'DateTimePickerexpirydate
                txtboxremark.Clear()
                txtboxsearchitem.Clear()
                txtboxsi.Focus()
            End If
        End If
    End Sub
#End Region
#Region "SEARCH item From DataGridViewStockdata"
    Public Sub FilterData(valToSearch As String)
        Try
            Dim SearchQery As String = "select * from mainstoretbl where CONCAT(stockid,productnamestrengthdosageform) like '%" & valToSearch & "%'"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            DataGridViewStockdata.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub txtboxsearchitem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxsearchitem.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnitemsearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnitemsearch_Click(sender As Object, e As EventArgs) Handles btnitemsearch.Click
        FilterData(txtboxsearchitem.Text)
    End Sub
    Private Sub txtboxsearchitem_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearchitem.TextChanged
        FilterData(txtboxsearchitem.Text)
    End Sub
#End Region
#Region "CLEAR"
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtboxsi.Clear()
        txtboxnhf.Clear()
        txtboxpnsdf.Clear()
        txtboxui.Clear()
        txtboxmsl.Clear()
        txtboxeop.Clear()
        txtboxamc.Clear()
        txtboxdocno.Clear()
        txtboxrforit.Clear()
        txtboxqr.Clear()
        txtboxqi.Clear()
        txtboxql.Clear()
        txtboxqb.Clear()
        txtboxbno.Clear()
        'DateTimePickerexpirydate
        txtboxremark.Clear()
        txtboxsearchitem.Clear()
        txtboxsi.Focus()
    End Sub
#End Region
#Region "DISPENSE requested item"
    Private Sub btndispenserequesteditem_Click(sender As Object, e As EventArgs) Handles btndispenserequesteditem.Click
        If vld(txtboxreqid, txtboxitem, txtboxbranch) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
            'End If
            'If IsConfirm("Do you want to dispense ?") Then
        Else
            '-----------------  dispby detail---------------------------------------------------------
            'Try
            con.Open()
            Dim dispby As String = Mainmenu.lblusername.Text 'userName.ToString()
            Dim cmddiag = New SqlCommand("select * from physiciantbl WHERE name = '" & dispby & "'", con)
            Dim dr = cmddiag.ExecuteReader()
            If (dr.HasRows) Then
                While (dr.Read())
                    Dim dispnby = dr("name").ToString()
                    'Dim dispbyqual = dr("qualification").ToString()
                    Dim crrentDate As DateTime = DateTime.Today
                    Dim disp As String = "gained"
                    Dim dispeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                    Dim updatequery As String = "update pharmstoretbl set itemstatus = '" & disp & "', dispenserid = '" & dispeidby & "',dispenseddate = '" & crrentDate.ToShortDateString() & "' where reqid='" & txtboxreqid.Text & "' and itemstatus='proceeded'"
                    InsertUpdateDelete(updatequery)
                    MessageBox.Show("Item successfully dispensed !", "Data dispensed - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("Successfully updated!"
                End While
                dr.Close()
                con.Close()
            End If
            'Catch ex As Exception
            '  MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            'End Try
            '-------------------------------end  dispby detail -----------------------------------------------------------
            txtboxreqid.Clear()
            txtboxitem.Clear()
            txtboxbranch.Clear()
            txtboxreqid.Focus()
        End If
    End Sub
#End Region
#Region "Datagridview cellonclick"
    Private Sub DataGridViewforStockrequested_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewforStockrequested.CellContentClick
        'If IsConfirm("Do you want to dispense ?") Then
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewforStockrequested.Rows(index)
            txtboxreqid.Text = selectedRow.Cells(0).Value.ToString
            txtboxitem.Text = selectedRow.Cells(2).Value.ToString
            txtboxbranch.Text = selectedRow.Cells(6).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy patient details from database", MsgBoxStyle.Information)
        End Try
        'Else
        'MsgBox("Dispense Failed")
        'End If
    End Sub
#End Region
#Region "view requesteditem list for CURRENT date"
    Public Sub FilterDataForitemreqnow(valforSearch As String)
        Dim currentDate As DateTime = DateTime.Today
        'mp.prescribeddate = '{curentDate.ToShortDateString()}' and
        'MsgBox("Current date is " & curentDate)
        'Try
        'Dim physid As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
        Dim brnc As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuery As String = $"SELECT * from pharmstoretbl WHERE requesteddate = '" & currentDate.ToShortDateString() & "' and itemstatus = 'proceeded'"
        Dim cs As New SqlCommand(SearchQuery, cn)
        Dim ac As New SqlDataAdapter(cs)
        Dim tb As New DataTable()
        ac.Fill(tb)
        DataGridViewforStockrequested.DataSource = tb
        'Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
#Region "Select RANDOMLY requested item tbl"
    Public Sub FilterDatarndmForreq(valueforSrchrndm As String)
        Try
            Dim ctDate As DateTime = DateTime.Today
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'" and branch = '" & brn & "'
            Dim brn As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuer As String = $"SELECT * from pharmstoretbl WHERE CONCAT(stockid,items) like '%" & valueforSrchrndm & "%' and itemstatus = 'proceeded'"
            Dim cc As New SqlCommand(SearchQuer, cn)
            Dim sd As New SqlDataAdapter(cc)
            Dim tbl As New DataTable()
            sd.Fill(tbl)
            DataGridViewforStockrequested.DataSource = tbl
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "SEARCH requested item BUTTON"
    Private Sub ToolStripbtnrequesteditem_Click(sender As Object, e As EventArgs) Handles ToolStripbtnrequesteditem.Click
        If vld(ToolStriptxtBoxrequestedstock) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        Else
            FilterDatarndmForreq(ToolStriptxtBoxrequestedstock.Text)
        End If
    End Sub

    Private Sub txtboxqr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxqr.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipforvalidatetxtboxinput.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtboxqi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxqi.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipforvalidatetxtboxinput.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtboxql_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxql.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipforvalidatetxtboxinput.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub txtboxqb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxqb.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipforvalidatetxtboxinput.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub ToolStriptxtBoxrequestedstock_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStriptxtBoxrequestedstock.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripbtnrequesteditem_Click(sender, e)
        End If
    End Sub

    Private Sub txtboxapv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxapv.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub
#End Region
End Class