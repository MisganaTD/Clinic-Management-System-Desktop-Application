Imports System.Data.SqlClient
Public Class LabResultCategory
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
    Private Sub LabResultCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
#Region "Select Lab result randomly for Hematology"
    Public Sub FilterDatarndmhem(valueforSearchrndmhem As String)
        'Try
        Dim bhm As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuery As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,lr.bf, lr.otherhema, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueforSearchrndmhem & "%' and ptbl.branch='" & bhm & "'"
        Dim command As New SqlCommand(SearchQuery, cn)
        Dim da = New SqlDataAdapter(command)
        Dim table As New DataTable()
        da.Fill(table)
        DataGridViewforLabResultHem.DataSource = table
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
    Private Sub btnSearchLabResultforHem_Click(sender As Object, e As EventArgs) Handles btnSearchLabResultforHem.Click
        If vld(txtboxSearchLabHem) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
            txtboxSearchLabHem.Clear()
        Else
            FilterDatarndmhem(txtboxSearchLabHem.Text)
        End If
    End Sub
    Private Sub txtboxSearchLabHem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchLabHem.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchLabResultforHem_Click(sender, e)
        End If
    End Sub
#End Region
#Region "Select Lab result randomly for Stool"
    Public Sub FilterDatarndmsto(valueforSearchrndmsto As String)
        'Try
        Dim bstt As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuerysto As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,lr.appearance, lr.microscopy, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueforSearchrndmsto & "%' and ptbl.branch='" & bstt & "'"
        Dim command As New SqlCommand(SearchQuerysto, cn)
        Dim da As New SqlDataAdapter(command)
        Dim table As New DataTable()
        da.Fill(table)
        DataGridViewforLabResultSto.DataSource = table
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
    Private Sub btnSearchLabResultforSto_Click(sender As Object, e As EventArgs) Handles btnSearchLabResultforSto.Click
        If vld(txtboxSearchLabSto) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
            txtboxSearchLabSto.Clear()
        Else
            FilterDatarndmsto(txtboxSearchLabSto.Text)
        End If
    End Sub
    Private Sub txtboxSearchLabSto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchLabSto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchLabResultforSto_Click(sender, e)
        End If
    End Sub
#End Region
#Region "Select Lab result randomly for Urinalysis"
    Public Sub FilterDatarndmUri(valueforSearchrndmuri As String)
        'Try
        Dim brni As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQueryuri As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,lr.urinedeepsticktest,lr.rbc,lr.wbc,lr.epithalialcells, lr.hcg, lr.othersurina, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueforSearchrndmuri & "%' and ptbl.branch='" & brni & "'"
        Dim command As New SqlCommand(SearchQueryuri, cn)
        Dim da As New SqlDataAdapter(command)
        Dim table As New DataTable()
        da.Fill(table)
        DataGridViewforLabResultUri.DataSource = table
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub

    Private Sub btnSearchLabResultforUri_Click(sender As Object, e As EventArgs) Handles btnSearchLabResultforUri.Click
        If vld(txtboxSearchLabUri) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
            txtboxSearchLabUri.Clear()
        Else
            FilterDatarndmUri(txtboxSearchLabUri.Text)
        End If
    End Sub
    Private Sub txtboxSearchLabUri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchLabUri.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchLabResultforUri_Click(sender, e)
        End If
    End Sub
#End Region
#Region "Select Lab result randomly for Serology"
    Public Sub FilterDatarndmsero(valueforSearchrndmsero As String)
        'Try
        Dim bsr As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuerysero As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,lr.hd, lr.od, lr.wellfelix, lr.pregnancytest, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueforSearchrndmsero & "%' and ptbl.branch='" & bsr & "'"
        Dim command As New SqlCommand(SearchQuerysero, cn)
        Dim da As New SqlDataAdapter(command)
        Dim table As New DataTable()
        da.Fill(table)
        DataGridViewforLabResultSero.DataSource = table
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub

    Private Sub btnSearchLabResultforSero_Click(sender As Object, e As EventArgs) Handles btnSearchLabResultforSero.Click
        If vld(txtboxSearchLabSero) = False Then
            'Exit Sub
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
            txtboxSearchLabSero.Clear()
        Else
            FilterDatarndmsero(txtboxSearchLabSero.Text)
        End If
    End Sub
    Private Sub txtboxSearchLabSero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchLabSero.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchLabResultforSero_Click(sender, e)
        End If
    End Sub

    Private Sub DataGridViewforLabResultHem_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewforLabResultHem.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewforLabResultHem.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewforLabResultHem.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewforLabResultHem.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DataGridViewforLabResultSto_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewforLabResultSto.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewforLabResultSto.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewforLabResultSto.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewforLabResultSto.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DataGridViewforLabResultUri_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewforLabResultUri.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewforLabResultUri.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewforLabResultUri.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewforLabResultUri.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewforLabResultSero_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewforLabResultSero.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewforLabResultSero.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewforLabResultSero.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewforLabResultSero.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DataGridViewforLabResultHem_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabResultHem.CellFormatting
        DataGridViewforLabResultHem.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewforLabResultSto_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabResultSto.CellFormatting
        DataGridViewforLabResultSto.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewforLabResultUri_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabResultUri.CellFormatting
        DataGridViewforLabResultUri.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewforLabResultSero_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabResultSero.CellFormatting
        DataGridViewforLabResultSero.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
#End Region
End Class
