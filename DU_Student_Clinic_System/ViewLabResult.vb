Imports System.Data.SqlClient
Public Class ViewLabResult
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ' ErrorProviderBioChem.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub ViewLabResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
        'TODO: This line of code loads data into the 'LabResult_DataSet.labresult' table. You can move, or remove it, as needed.
        'Me.labresultTableAdapter.Fill(Me.LabResult_DataSet.labresult)
        'Me.ReportViewer1.RefreshReport()
    End Sub
#Region "View all Lab Result Availabe for current day"
    Public Sub FilterData(valueToSearch As String)
        'Try
        'Dim SearchQuery As String = "select * from patienttbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
        Dim curentDate As DateTime = DateTime.Today
        Dim brnc As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuery As String = $"Select ptbl.patientid,ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,lr.bf, lr.otherhema, lr.appearance, lr.microscopy,lr.urinedeepsticktest,lr.rbc,lr.wbc,
 lr.epithalialcells, lr.hcg, lr.othersurina, lr.hd, lr.od, lr.wellfelix, lr.pregnancytest, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE lr.resultdate = '{curentDate.ToShortDateString()}' and ptbl.branch='" & brnc & "'"
        Dim command As New SqlCommand(SearchQuery, cn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewforLabResult.DataSource = table
        ' Catch ex As Exception
        '   MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
#Region "Select Lab result randomly"
    Public Sub FilterDatarndm(valueforSearchrndm As String)
        'Try
        Dim brvlab As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuery As String = $"Select ptbl.patientid,ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,lr.bf, lr.otherhema, lr.appearance, lr.microscopy,lr.urinedeepsticktest,lr.rbc,lr.wbc,
 lr.epithalialcells, lr.hcg, lr.othersurina, lr.hd, lr.od, lr.wellfelix, lr.pregnancytest, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueforSearchrndm & "%' and ptbl.branch='" & brvlab & "'"
        Dim command As New SqlCommand(SearchQuery, cn)
        Dim da As New SqlDataAdapter(command)
        Dim table As New DataTable()
        da.Fill(table)
        DataGridViewforLabResult.DataSource = table
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub

    Private Sub btnSearchLabResult_Click(sender As Object, e As EventArgs) Handles btnSearchLabResult.Click
        If vld(txtboxSearchLabR) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
            txtboxSearchLabR.Clear()
        Else
            FilterDatarndm(txtboxSearchLabR.Text)
        End If
    End Sub

    Private Sub txtboxSearchLabR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchLabR.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchLabResult_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridViewforLabResult_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabResult.CellFormatting
        DataGridViewforLabResult.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
#End Region
End Class