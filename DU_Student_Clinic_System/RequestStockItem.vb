Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class RequestStockItem
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
#Region "form load"
    Private Sub RequestStockItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(Mainmenu.Left + 25, Mainmenu.Top + 45)
        FilterData("")
        txtboxblance.Text = 0
        btnedititem.Visible = False
        '==========================================================================
        '-----------------Fill Auto Complete for item name ------------------------------
        Try
            'Dim cmdtel As
            Dim physd As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            ' Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim qn As Integer = 0
            Dim command1 As New SqlCommand("select productnamestrengthdosageform from mainstoretbl where quantybalance <> '" & qn & "'", con)
            'Dim datel As 
            Dim daa As New SqlClient.SqlDataAdapter(command1)
            Dim dstel As DataSet = New DataSet
            daa.Fill(dstel, "mainstoretbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To dstel.Tables(0).Rows.Count - 1
                coltel.Add(dstel.Tables(0).Rows(i)(0).ToString)
            Next
            txtboxi.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtboxi.AutoCompleteCustomSource = coltel
            txtboxi.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
        '--------------------------------------------------------------------------
        Dim GetCode As String = "0"
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = con
        command.CommandText = "Select TOP(1) * FROM pharmstoretbl ORDER BY reqid DESC"
        Try
            con.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetString(reader.GetOrdinal("reqid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        If (GetCode = "0") Then
            txtboxreqid.Text = "1"
        ElseIf (GetCode <> "0") Then
            Dim TotalCodeWithoutLable As String = GetCode.Count - 0
            Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
            txtboxreqid.Text = Format(OldNum + 1).ToString
            txtboxi.Clear()        '    
            txtboxq.Clear()
            txtboxiu.Clear()
            txtboxremark.Clear()
            txtboxi.Focus()
        End If
        txtboxforitemedit.Visible = False
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
            txtboxiu.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtboxiu.AutoCompleteCustomSource = coltelpu
            txtboxiu.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
        '============================================for dispernser==================================
        '-----------------Fill Auto Complete for item name ------------------------------
        Try
            'Dim cmdtel As
            Dim physd As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            Dim brcn As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim qnp As Integer = 0
            Dim command1ds As New SqlCommand("select items from pharmstoretbl where availablebalance <> '" & qnp & "' and itemstatus='gained' and branch='" & brcn & "' order by availablebalance ASC", con)
            'Dim datel As 
            Dim daads As New SqlClient.SqlDataAdapter(command1ds)
            Dim dstelds As DataSet = New DataSet
            daads.Fill(dstelds, "pharmstoretbl")
            Dim coltelds As New AutoCompleteStringCollection
            For i = 0 To dstelds.Tables(0).Rows.Count - 1
                coltelds.Add(dstelds.Tables(0).Rows(i)(0).ToString)
            Next
            txtbi.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtbi.AutoCompleteCustomSource = coltelds
            txtbi.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
        '--------------------------------------------------------------------------
        '-----------------Fill Auto Complete for EID  ------------------------------
        Try
            'Dim cmdtel As
            Dim physd As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            ' Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim qnp As Integer = 0
            Dim command1dse As New SqlCommand("select physicianid from physiciantbl where status=1", con)
            'Dim datel As 
            Dim daadse As New SqlClient.SqlDataAdapter(command1dse)
            Dim dsteldse As DataSet = New DataSet
            daadse.Fill(dsteldse, "physiciantbl")
            Dim colteldse As New AutoCompleteStringCollection
            For i = 0 To dsteldse.Tables(0).Rows.Count - 1
                colteldse.Add(dsteldse.Tables(0).Rows(i)(0).ToString)
            Next
            txtbubyeid.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtbubyeid.AutoCompleteCustomSource = colteldse
            txtbubyeid.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
        '--------------------------------------------------------------------------
    End Sub
#End Region
#Region "Add request"
    Private Sub btnadditem_Click(sender As Object, e As EventArgs) Handles btnadditem.Click
        If vld(lblstiid, txtboxi, txtboxq, txtboxiu, txtboxremark) = False Then
            'Exit Sub
            'DateTimePickermanufmed
            'DateTimePickerexpimed
            MsgBox("Please complete the form first", MsgBoxStyle.Critical)
        Else
            con.Open()
            'Dim cmp As SqlCommand = New SqlCommand("Select stockid from pharmstoretbl where stockid=@sid", con)
            Dim cmp As SqlCommand = New SqlCommand("Select ph.stockid,ms.productnamestrengthdosageform from mainstoretbl As ms inner Join pharmstoretbl as ph on ms.stockid = ph.stockid where ph.stockid=@sid and ph.itemstatus='requested'", con)
            cmp.Parameters.AddWithValue("@sid", lblstiid.Text)
            Dim rdp As SqlDataReader = cmp.ExecuteReader()
            If CLng(txtboxq.Text) > CLng(txtboxblance.Text) Then
                MsgBox("Quantity must less or equal to balance quantity, please try again!", MsgBoxStyle.Critical)
                'End If
            ElseIf rdp.HasRows Or txtboxblance.Text = 0 Then
                MsgBox("Please try again!", MsgBoxStyle.Critical)
                'If rdp.HasRows Or txtboxblance.Text = 0 Then
                'MsgBox("Please try again!", MsgBoxStyle.Critical)
            Else
                rdp.Close()
                ' Dim cmpp As SqlCommand = New SqlCommand("Select  ph.stockid,ms.productnamestrengthdosageform from mainstoretbl As ms inner Join pharmstoretbl as ph on ms.productnamestrengthdosageform = '" & txtboxi.Text & "'", con)
                Dim cmpp As SqlCommand = New SqlCommand("Select productnamestrengthdosageform from mainstoretbl where productnamestrengthdosageform = '" & txtboxi.Text & "'", con)
                cmpp.Parameters.AddWithValue("@sid", lblstiid.Text)
                Dim rdpp As SqlDataReader = cmpp.ExecuteReader()
                If rdpp.HasRows = False Then
                    MsgBox("No such item/product; please try again!", MsgBoxStyle.Critical)
                Else
                    Dim regby As String = Mainmenu.lblEID.Text 'userName.ToString()
                    Dim addbrnch As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
                    'Dim regby As String = Mainmenu.lblusername.Text 'userName.ToString()
                    Dim cnntDate As DateTime = DateTime.Today
                    Dim sta As String = "requested" 'possible value are "requested,proceede,approved,gained"
                    'Dim tq As Integer = CInt(txtboxq.Text) 'for ineger conversion
                    Dim apiecexquantityunit As Integer = CInt(txtboxpval.Text) * CInt(txtboxq.Text)
                    Dim insertQery As String = "insert into pharmstoretbl(reqid,stockid, items, unit, quantity,availablebalance,branch, requestedbyempid, remark, itemstatus,requesteddate) values('" & txtboxreqid.Text & "','" & lblstiid.Text & "','" & txtboxi.Text & "','" & txtboxiu.Text & "', '" & txtboxq.Text & "','" & apiecexquantityunit & "','" & addbrnch & "','" & regby & "','" & txtboxremark.Text & "','" & sta & "','" & cnntDate.ToShortDateString & "')"
                    InsertUpdateDelete(insertQery)
                    Dim tq As Integer = CInt(txtboxq.Text) 'for ineger conversion
                    Dim apiecexquantityuni As Integer = CInt(txtboxpval.Text) * CInt(txtboxq.Text)
                    'Dim tq As Integer = CInt(txtboxq.Text) for decimal
                    Dim updtequeryaft As String = "update mainstoretbl set quantybalance = quantybalance - " & tq & ",balancevalueofpieceandasked = balancevalueofpieceandasked - " & apiecexquantityuni & "  where stockid='" & lblstiid.Text & "'"
                    InsertUpdateDelete(updtequeryaft)
                    MessageBox.Show("Request successfully added", "Request Added - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtboxforitemedit.Clear()
                    txtboxq.Clear()
                    txtboxiu.Clear()
                    txtboxremark.Clear()
                    txtboxblance.Text = 0
                    txtboxi.Clear()
                    txtboxi.Visible = True
                    txtboxforitemedit.Visible = False
                    btnadditem.Visible = True
                    btnclear.Visible = True
                    txtboxi.Focus()
                End If
            End If
            con.Close()
        End If
    End Sub
#End Region
#Region "Edit request"
    Private Sub btnedititem_Click(sender As Object, e As EventArgs) Handles btnedititem.Click
        'If vld(lblstiid, txtboxforitemedit, txtboxq, cmbboxu, txtboxremark) = False Then
        '    'Exit Sub
        '    MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        'Else
        '    con.Open()
        '    Dim cmdep As SqlCommand = New SqlCommand("select stockid from pharmstoretbl where stockid=@mid", con)
        '    cmdep.Parameters.AddWithValue("@mid", lblstiid.Text)
        '    Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
        '    If rdrp.HasRows Then
        '        Dim updatedby As String = Mainmenu.lblEID.Text 'userName.ToString() 
        '        'Dim regby As String = Mainmenu.lblusername.Text 'userName.ToString()
        '        Dim crdate As DateTime = DateTime.Today
        '        Dim st As String = "requested" 'possible value are "requested,proceede,approved,gained"
        '        Dim tq1 As Integer = CInt(txtboxq.Text) 'for ineger conversion
        '        Dim tqbal As Integer = CInt(txtboxblance.Text) 'for ineger conversion
        '        If tq1 <= tqbal And tq1 >= tq1 Then
        '            Dim updtequery As String = "update pharmstoretbl set items ='" & txtboxforitemedit.Text & "',unit='" & cmbboxu.Text & "',quantity ='" & txtboxq.Text & "', requestedbyempid='" & updatedby & "',remark='" & txtboxremark.Text & "',itemstatus ='" & st & "', requesteddate='" & crdate & "'  where stockid='" & lblstiid.Text & "'"
        '            InsertUpdateDelete(updtequery)
        '            Dim tq As Integer = CInt(txtboxq.Text) 'for ineger conversion
        '            'Dim tq As Integer = CInt(txtboxq.Text) for decimal
        '            'Dim cm As SqlCommand = New SqlCommand("select MIN(quantybalance) from mainstoretbl where productnamestrengthdosageform='" & txtboxforitemedit.Text & "' and quantybalance <> 0", con)
        '            'cm.Parameters.AddWithValue("@mid", txtboxii.Text)
        '            'Dim rdr As SqlDataReader = cm.ExecuteReader()
        '            'If rdr.HasRows Then
        '            Dim updtequeryaft As String = "update mainstoretbl set quantybalance = quantybalance - " & tq & "  where stockid='" & lblstiid.Text & "'"
        '                InsertUpdateDelete(updtequeryaft)
        '                MessageBox.Show("Request item successfully edited !", "Data updated - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                txtboxforitemedit.Clear()
        '                txtboxq.Clear()
        '                cmbboxu.Text = ""
        '                txtboxremark.Clear()
        '                txtboxblance.Text = 0
        '                txtboxi.Visible = True
        '                txtboxforitemedit.Visible = False
        '                btnadditem.Visible = True
        '                btnclear.Visible = True
        '                txtboxforitemedit.Focus()
        '            Else
        '                MsgBox("Error please try again!", MsgBoxStyle.Critical)
        '            'End If
        '        End If
        '    End If
        'End If
        'con.Close()
    End Sub
#End Region
#Region "Delete request"
    Private Sub btndeleteitem_Click(sender As Object, e As EventArgs) Handles btndeleteitem.Click
        If vld(lblstiid) = False Then
            'Exit Sub
            MsgBox("Please select requested item from the list to delete the requested item", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to delete this request from database?") Then
            Dim dletequery As String = "delete from pharmstoretbl where stockid='" & lblstiid.Text & "'"
            If InsertUpdateDelete(dletequery) Then
                Dim tq As Integer = CLng(txtboxq.Text) 'for ineger conversion
                Dim pval As Integer = CLng(txtboxpval.Text) 'for ineger conversion
                'Dim tq As Integer = CInt(txtboxq.Text) for decimal
                'TODO Dim apiecexquantityunit As Integer = CInt(txtboxpval.Text) * CInt(txtboxq.Text)
                Dim updtequeryaft As String = "update mainstoretbl set balancevalueofpieceandasked = (balancevalueofpieceandasked) + (" & tq & " * " & pval & "), quantybalance = quantybalance + " & tq & " where stockid='" & lblstiid.Text & "'"
                InsertUpdateDelete(updtequeryaft)
                MessageBox.Show("Requested item successfully deleted !", "Data deleted - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtboxi.Clear()
                ' lblstiid.Clear()
                txtboxq.Clear()
                txtboxiu.Clear()
                txtboxremark.Clear()
                btnadditem.Visible = True
                btnclear.Visible = True
                txtboxi.Focus()
            End If
        End If
    End Sub
#End Region
#Region "View available quantity of selected item during stock request"
    Private Sub btnviewbalance_Click(sender As Object, e As EventArgs) Handles btnviewbalance.Click
        'select COUNT(*) as blnace from mainstoretbl where unitofissue='Pkt' 
        Dim searchCommand As New SqlCommand("select * from mainstoretbl where productnamestrengthdosageform=@pnsdf and quantybalance <> 0 order by quantybalance DESC", con)
        searchCommand.Parameters.Add("@pnsdf", SqlDbType.VarChar).Value = txtboxi.Text
        Dim adapter As New SqlDataAdapter(searchCommand)
        'Dim dalb As New SqlDataAdapter(searchCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            txtboxblance.Text = table(0)(13)
            txtboxi.Text = table(0)(2)
            lblstiid.Text = table(0)(0)
        Else
            txtboxblance.Text = "0"
            'MsgBox("No item data found!", MsgBoxStyle.Information)
        End If
    End Sub
#End Region
#Region "Refresh"
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Controls.Clear()
        InitializeComponent()
        RequestStockItem_Load(e, e)
        Refresh()
    End Sub
#End Region
#Region "VIEW AND EDIT Stock DETAIL"
    Public Sub FilterData(valToSearch As String)
        Try
            Dim SearchQery As String = "select p.* from pharmstoretbl as p inner join mainstoretbl as m on p.stockid=m.stockid where p.itemstatus='requested'" ' where CONCAT(stockid,productnamestrengthdosageform) like '%" & valToSearch & "%'"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            DataGridViewRquesteddata.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub txtboxi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxi.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnviewbalance_Click(sender, e)
        End If
    End Sub
    Private Sub btnviewreqnotapprovalorproceed_Click(sender As Object, e As EventArgs) Handles btnviewreqnotapprovalorproceed.Click
        FilterData("")
    End Sub
    'Private Sub txtboxsearchitem_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearchitem.TextChanged
    '    FilterData(txtboxsearchitem.Text)
    'End Sub
#End Region
#Region "Clear"
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtboxi.Clear()
        txtboxq.Clear()
        txtboxiu.Clear()
        txtboxremark.Clear()
        txtboxblance.Clear()
        txtboxi.Focus()
    End Sub
    Private Sub txtboxi_Click(sender As Object, e As EventArgs) Handles txtboxi.Click
        If txtboxi.Text <> "" Then
            txtboxi.Enabled = False
        End If
    End Sub

    Private Sub DataGridViewRquesteddata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRquesteddata.CellContentClick
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewRquesteddata.Rows(index)
            lblstiid.Text = selectedRow.Cells(1).Value.ToString
            txtboxforitemedit.Text = selectedRow.Cells(2).Value.ToString
            txtboxiu.Text = selectedRow.Cells(3).Value.ToString
            txtboxq.Text = selectedRow.Cells(4).Value.ToString
            txtboxremark.Text = selectedRow.Cells(10).Value.ToString
            txtboxblance.Text = selectedRow.Cells(5).Value.ToString
            txtboxpval.Text = (selectedRow.Cells(5).Value.ToString) / (selectedRow.Cells(4).Value.ToString)
            'select * from mainstoretbl where productnamestrengthdosageform=@pnsdf and quantybalance <> 0 order by quantybalance ASC
            Dim searchCommand As New SqlCommand("select * from mainstoretbl where productnamestrengthdosageform=@pnsdf and quantybalance <> 0 order by quantybalance ASC", con)
            searchCommand.Parameters.Add("@pnsdf", SqlDbType.VarChar).Value = txtboxforitemedit.Text
            Dim adapter As New SqlDataAdapter(searchCommand)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                txtboxblance.Text = table(0)(13)
                txtboxi.Text = table(0)(2)
                'lblstiid.Text = table(0)(0)
            Else
                txtboxblance.Text = "0"
                'MsgBox("No item data found!", MsgBoxStyle.Information)
            End If
            txtboxi.Visible = False
            txtboxforitemedit.Visible = True
            btnadditem.Visible = False
            btnclear.Visible = False
        Catch ex As Exception
            MsgBox("Ctrl + C to copy stock details from database", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtboxq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxq.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtboxpval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxpval.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub btncrlit_Click(sender As Object, e As EventArgs) Handles btncrlit.Click
        txtbbalitem.Clear()
        txtbi.Clear()
        txtbq.Clear()
        txtbubyeid.Clear()
        txtbr.Clear()
        txtbrid.Clear()
        lblstid.Text = ""
        txtbubyeid.Focus()
    End Sub

    Private Sub btnvwitembal_Click(sender As Object, e As EventArgs) Handles btnvwitembal.Click
        'select COUNT(*) as blnace from mainstoretbl where unitofissue='Pkt' 
        Dim searchCommandds As New SqlCommand("select * from pharmstoretbl where items=@pnsdfit and availablebalance <> 0 and itemstatus='gained' order by availablebalance ASC", con)
        searchCommandds.Parameters.Add("@pnsdfit", SqlDbType.VarChar).Value = txtbi.Text
        Dim adapterds As New SqlDataAdapter(searchCommandds)
        'Dim dalb As New SqlDataAdapter(searchCommand)
        Dim tableds As New DataTable()
        adapterds.Fill(tableds)
        If tableds.Rows.Count > 0 Then
            txtbrid.Text = tableds(0)(0)
            txtbbalitem.Text = tableds(0)(5)
            txtbi.Text = tableds(0)(2)
            lblstid.Text = tableds(0)(1)
        Else
            txtbbalitem.Text = "0"
            lblstid.Text = ""
            'MsgBox("No item data found!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtbi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbi.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnvwitembal_Click(sender, e)
        End If
    End Sub

    Private Sub txtbubyeid_Click(sender As Object, e As EventArgs) Handles txtbubyeid.Click
        If txtbubyeid.Text <> "" Then
            txtbubyeid.Enabled = False
        End If
    End Sub

    Private Sub txtbi_Click(sender As Object, e As EventArgs) Handles txtbi.Click
        If txtbi.Text <> "" Then
            txtbi.Enabled = False
        End If
    End Sub

    Private Sub btnrefreshdisp_Click(sender As Object, e As EventArgs) Handles btnrefreshdisp.Click
        Me.Controls.Clear()
        InitializeComponent()
        RequestStockItem_Load(e, e)
        Refresh()
    End Sub

    Private Sub btndispit_Click(sender As Object, e As EventArgs) Handles btndispit.Click
        If vld(txtbrid, txtbi, txtbq, txtbubyeid, txtbbalitem, lblstid) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
            'End If
            'If IsConfirm("Do you want to dispense ?") Then
        Else
            '-----------------  dispby detail---------------------------------------------------------
            Try
                con.Open()
                Dim dpbyds As String = Mainmenu.lblusername.Text
                Dim cmddiagds = New SqlCommand("select * from physiciantbl WHERE name = '" & dpbyds & "'", con)
                Dim drds = cmddiagds.ExecuteReader()
                If CLng(txtbq.Text) > CLng(txtbbalitem.Text) Then
                    MsgBox("Quantity must less or equal to balance quantity, please try again!", MsgBoxStyle.Critical)
                    'End If
                    Me.Close()
                ElseIf txtbbalitem.Text = 0 Then
                    MsgBox("Please try again!", MsgBoxStyle.Critical)
                    'ElseIf drds.HasRows Or txtboxblance.Text = 0 Then
                    '    MsgBox("Please try again!", MsgBoxStyle.Critical)
                Else
                    Dim dspnby = Mainmenu.lblusername.Text
                    Dim cntDate As DateTime = DateTime.Today
                    Dim qitm As Integer = CInt(txtbq.Text)
                    Dim dispeidby As String = Mainmenu.lblEID.Text
                    Dim br As String = Mainmenu.lblcampus.Text
                    Dim rqid As String = txtbrid.Text
                    Dim insertQeryds As String = "insert into dispenseryforphysiciantbl(stockid,items,quantityofpiece, branch,dispensereid,requestedbyeid, requesteddate,dispenseddate,remark) values('" & lblstid.Text & "','" & txtbi.Text & "','" & txtbq.Text & "','" & br & "', '" & dispeidby & "','" & txtbubyeid.Text & "','" & cntDate.ToShortDateString() & "','" & cntDate.ToShortDateString() & "','" & txtbr.Text & "')"
                    InsertUpdateDelete(insertQeryds)
                    Dim updatequeryds As String = "update pharmstoretbl set availablebalance = availablebalance - " & qitm & " where reqid='" & txtbrid.Text & "'"
                    InsertUpdateDelete(updatequeryds)
                    MessageBox.Show("Item successfully dispensed !", "Data dispensed - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("Successfully updated!"
                    drds.Close()
                    con.Close()
                    '-------------------------------end  dispby detail -----------------------------------------------------------
                End If
            Catch ex As Exception
                MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            End Try
            txtbbalitem.Clear()
            txtbi.Clear()
            txtbq.Clear()
            txtbubyeid.Clear()
            txtbr.Clear()
            txtbrid.Clear()
            lblstid.Text = ""
            txtbubyeid.Focus()
        End If
    End Sub

    Private Sub txtbq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbq.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub
#End Region
End Class