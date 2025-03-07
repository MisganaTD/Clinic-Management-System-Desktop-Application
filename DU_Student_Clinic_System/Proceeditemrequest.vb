Imports System.Data.SqlClient
Public Class Proceeditemrequest
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
#Region "Proceed btn"
    Private Sub btnproceedrequesteditem_Click(sender As Object, e As EventArgs) Handles btnproceedrequesteditem.Click
        If vld(txtboxreqiid, txtboxitemname, txtboxbrnch) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
            'End If
            'If IsConfirm("Do you want to dispense ?") Then
        Else
            '-----------------  dispby detail---------------------------------------------------------
            'Try
            con.Open()
            Dim dispby As String = Mainmenu.lblusername.Text
            Dim cmddiag = New SqlCommand("select * from physiciantbl WHERE name = '" & dispby & "'", con)
            Dim dr = cmddiag.ExecuteReader()
            If (dr.HasRows) Then
                While (dr.Read())
                    Dim dispnby = dr("name").ToString()
                    'Dim dispbyqual = dr("qualification").ToString()
                    Dim crrentDate As DateTime = DateTime.Today
                    Dim disp As String = "proceeded"
                    Dim dispeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                    Dim updatequery As String = "update pharmstoretbl set itemstatus = '" & disp & "', proceededbyempid = '" & dispeidby & "' where reqid='" & txtboxreqiid.Text & "' and itemstatus='requested'"
                    InsertUpdateDelete(updatequery)
                    MessageBox.Show("Item successfully proceeded !", "Data proceeded - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("Successfully updated!"
                End While
                dr.Close()
                con.Close()
            End If
            'Catch ex As Exception
            '  MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            'End Try
            '-------------------------------end  dispby detail -----------------------------------------------------------
            txtboxreqiid.Clear()
            txtboxitemname.Clear()
            txtboxbrnch.Clear()
            txtboxreqiid.Focus()
        End If
    End Sub
#End Region
#Region "SEARCH button"
    Private Sub ToolStripbutnrequesteditem_Click(sender As Object, e As EventArgs) Handles ToolStripbutnrequesteditem.Click
        If vld(ToolStriptxtBoxrequestedstockitem) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        Else
            FilterDatarndmreq(ToolStriptxtBoxrequestedstockitem.Text)
        End If
    End Sub
#End Region
#Region "DataGridViewforStockrequested_CellContentClick"
    Private Sub DataGridViewforStockrequested_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewforStockrequested.CellContentClick
        'If IsConfirm("Do you want to dispense ?") Then
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewforStockrequested.Rows(index)
            txtboxreqiid.Text = selectedRow.Cells(0).Value.ToString
            txtboxitemname.Text = selectedRow.Cells(2).Value.ToString 'AndAlso selectedRow.Cells(2).Value.ToString
            txtboxbrnch.Text = selectedRow.Cells(6).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy patient details from database", MsgBoxStyle.Information)
        End Try
        'Else
        'MsgBox("Dispense Failed")
        'End If 
    End Sub
#End Region
#Region "Proceeditemrequest_Load"
    Private Sub Proceeditemrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterDataitemreqnow("")
    End Sub
#End Region
#Region "Select RANDOMLY requested item tbl"
    Public Sub FilterDatarndmreq(valueforSchrndm As String)
        Try
            Dim ctDate As DateTime = DateTime.Today
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim brn As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuerp As String = $"SELECT * from pharmstoretbl WHERE CONCAT(stockid,items) like '%" & valueforSchrndm & "%' and itemstatus = 'requested' and branch = '" & brn & "'"
            Dim cp As New SqlCommand(SearchQuerp, cn)
            Dim sd As New SqlDataAdapter(cp)
            Dim tbl As New DataTable()
            sd.Fill(tbl)
            DataGridViewforStockrequested.DataSource = tbl
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "view requesteditem list for CURRENT date"
    Public Sub FilterDataitemreqnow(valforSearch As String)
        Dim crrentDate As DateTime = DateTime.Today
        'mp.prescribeddate = '{curentDate.ToShortDateString()}' and
        'MsgBox("Current date is " & curentDate)
        'Try
        'Dim physid As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
        Dim bnc As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQueryc As String = $"SELECT * from pharmstoretbl WHERE requesteddate = '" & crrentDate.ToShortDateString() & "' and itemstatus = 'requested' and branch = '" & bnc & "'"
        Dim csc As New SqlCommand(SearchQueryc, cn)
        Dim ac As New SqlDataAdapter(csc)
        Dim tbc As New DataTable()
        ac.Fill(tbc)
        DataGridViewforStockrequested.DataSource = tbc
        'Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
End Class