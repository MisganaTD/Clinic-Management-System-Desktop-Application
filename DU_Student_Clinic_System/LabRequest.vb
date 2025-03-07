Imports System.Data.SqlClient
Public Class LabRequest
    'Private curentDate As DateTime = DateTime.Today 
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
    Private Sub LabRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DUSCSDataSet.patienttbl' table. You can move, or remove it, as needed.
        FilterDataforlareq("")
        'FilterDatarndm("")
        'Location = New Point(Mainmenu.Left + 25, Mainmenu.Top + 45)
    End Sub
#Region "View diagnosis of current date"
    Public Sub FilterDataforlareq(valueToSearch As String)
        Dim curentDate As DateTime = DateTime.Today
        'MsgBox("Current date is " & curentDate)
        Try
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim lbrq As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQ As String = $"SELECT ptbl.name,ptbl.patientid,ptbl.age,ptbl.branch,pd.diagnosisdate,pd.hematology, pd.stoolexam, pd.urinalysis, pd.serology,
pd.reportedby, pd.qualification, pd.remark from patientdiagnosistbl pd INNER JOIN patienttbl ptbl ON pd.patientid = ptbl.patientid 
WHERE pd.diagnosisdate = '{curentDate.ToShortDateString()}' and pd.status='senttolab' and ptbl.branch='" & lbrq & "'"
            Dim ccl As New SqlCommand(SearchQ, cn)
            Dim ddl As New SqlDataAdapter(ccl)
            Dim ttl As New DataTable()
            ddl.Fill(ttl)
            DataGridViewforLabreq.DataSource = ttl
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "Search diagnosis randomly"
    Public Sub FilterDatarndmForLReq(valueToSearchrndm As String)
        Try
            Dim lbreqs As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuery As String = $"SELECT ptbl.name,ptbl.patientid,ptbl.age,ptbl.branch,pd.diagnosisdate,pd.hematology, pd.stoolexam, pd.urinalysis, pd.serology,pd.reportedby, pd.qualification, pd.remark from patientdiagnosistbl pd INNER JOIN patienttbl ptbl ON pd.patientid = ptbl.patientid
WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueToSearchrndm & "%' and pd.status='senttolab' and ptbl.branch='" & lbreqs & "'"
            Dim cl As New SqlCommand(SearchQuery, cn)
            Dim dl As New SqlDataAdapter(cl)
            Dim tl As New DataTable()
            dl.Fill(tl)
            DataGridViewforLabreq.DataSource = tl
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
    Private Sub ToolStripBtnLabreq_Click(sender As Object, e As EventArgs) Handles ToolStripBtnLabreq.Click
        If vld(ToolStriptxtBoxlabrequest) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        Else
            FilterDatarndmForLReq(ToolStriptxtBoxlabrequest.Text)
        End If
    End Sub
    Private Sub ToolStriptxtBoxlabrequest_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStriptxtBoxlabrequest.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripBtnLabreq_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridViewforLabreq_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabreq.CellFormatting
        DataGridViewforLabreq.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
End Class