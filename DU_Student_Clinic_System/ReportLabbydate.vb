Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelautoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class ReportLabbydate
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
#Region "Select Lab result rprt randomly for Hematology"
    Private Sub btnsearchlabrhem_Click(sender As Object, e As EventArgs) Handles btnsearchlabrhem.Click
        'Try
        Dim dtphfrom As DateTime = DateTimePickerhfrom.Value.ToShortDateString()
        Dim dtphto As DateTime = DateTimePickerhto.Value.ToShortDateString()
        Dim bh As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuery As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,ptbl.department,ptbl.branch,ptbl.year,lr.bf, lr.otherhema, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE ptbl.branch='" & bh & "' and lr.resultdate BETWEEN '" & dtphfrom & "' AND '" & dtphto & "'   order by lr.resultdate"
        Dim crd As New SqlCommand(SearchQuery, cn)
        Dim dard As New SqlDataAdapter(crd)
        Dim trd As New DataTable()
        dard.Fill(trd)
        DataGridViewLabRHem.DataSource = trd
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
#Region "Report for all lab result"
    Private Sub btnsearchlaball_Click(sender As Object, e As EventArgs) Handles btnsearchlaball.Click
        'Try
        Dim dtpallfrom As DateTime = DateTimePickerallfrom.Value.ToShortDateString()
        Dim dtpallto As DateTime = DateTimePickerallto.Value.ToShortDateString()
        Dim brall As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQueryall As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,ptbl.department,ptbl.year,lr.bf, lr.otherhema,lr.appearance,lr.microscopy,
lr.urinedeepsticktest,lr.rbc,lr.wbc,lr.epithalialcells,lr.hcg,lr.othersurina,lr.hd,lr.od,lr.wellfelix,lr.pregnancytest,lr.reportedby,lr.resultdate
FROM labresult AS lr INNER JOIN patienttbl AS ptbl ON lr.patientid = ptbl.patientid
WHERE ptbl.branch='" & brall & "' and lr.resultdate BETWEEN '" & dtpallfrom & "' AND '" & dtpallto & "'"
        Dim c1 As New SqlCommand(SearchQueryall, cn)
        Dim d1 = New SqlDataAdapter(c1)
        Dim t1 As New DataTable()
        d1.Fill(t1)
        DataGridViewLabRAll.DataSource = t1
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
        'Dim index As Integer = e.RowIndex
        'Dim ttl As Integer = DataGridViewLabRAll.DisplayedRowCount(index)
        Dim ttls As Integer = DataGridViewLabRAll.DisplayedRowCount(True) 'get total number of lab result
        lbltotal.Text = ttls

    End Sub
#End Region
#Region "Report lab result for stool"
    Private Sub btnsearchlabstr_Click(sender As Object, e As EventArgs) Handles btnsearchlabstr.Click
        'Try
        Dim dtpstfrom As DateTime = DateTimePickerlstfrom.Value.ToShortDateString()
        Dim dtpstto As DateTime = DateTimePickerlstto.Value.ToShortDateString()
        Dim bst As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQuerysto As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,ptbl.department,ptbl.year,lr.appearance, lr.microscopy, lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE ptbl.branch='" & bst & "' and lr.resultdate BETWEEN '" & dtpstfrom & "' AND '" & dtpstto & "'"
        Dim c2 As New SqlCommand(SearchQuerysto, cn)
        Dim d2 As New SqlDataAdapter(c2)
        Dim t2 As New DataTable()
        d2.Fill(t2)
        DataGridViewLabRSto.DataSource = t2
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
#Region "Report uri lab result for stool"
    Private Sub btnsearchlaburr_Click(sender As Object, e As EventArgs) Handles btnsearchlaburr.Click

        'Try
        Dim dtpurfrom As DateTime = DateTimePickerufrom.Value.ToShortDateString()
        Dim dtpurto As DateTime = DateTimePickeruto.Value.ToShortDateString()
        Dim bur As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQueryur As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,ptbl.department,ptbl.year,lr.urinedeepsticktest,lr.rbc,lr.wbc,lr.epithalialcells, lr.hcg, lr.othersurina,lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE ptbl.branch='" & bur & "' and lr.resultdate BETWEEN '" & dtpurfrom & "' AND '" & dtpurto & "' order by lr.resultdate"
        Dim c3 As New SqlCommand(SearchQueryur, cn)
        Dim d3 As New SqlDataAdapter(c3)
        Dim t3 As New DataTable()
        d3.Fill(t3)
        DataGridViewLabRUri.DataSource = t3
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub
#End Region
#Region "Report uri lab result for stool"
    Private Sub btnsearchlabserr_Click(sender As Object, e As EventArgs) Handles btnsearchlabserr.Click

        'Try
        Dim dtpserfrom As DateTime = DateTimePickerserfrom.Value.ToShortDateString()
        Dim dtpserto As DateTime = DateTimePickerserto.Value.ToShortDateString()
        Dim bser As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        Dim SearchQueryser As String = $"Select ptbl.name, ptbl.age,ptbl.gender,ptbl.branch,ptbl.department,ptbl.year,lr.hd, lr.od, lr.wellfelix, lr.pregnancytest,lr.reportedby, lr.remarkedby, lr.resultdate FROM labresult AS lr INNER JOIN
patienttbl AS ptbl ON lr.patientid = ptbl.patientid WHERE ptbl.branch='" & bser & "' and lr.resultdate BETWEEN '" & dtpserfrom & "' AND '" & dtpserto & "' order by lr.resultdate"
        Dim c4 As New SqlCommand(SearchQueryser, cn)
        Dim d4 As New SqlDataAdapter(c4)
        Dim t4 As New DataTable()
        d4.Fill(t4)
        DataGridViewLabRSero.DataSource = t4
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
    End Sub

    Private Sub DataGridViewLabRHem_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewLabRHem.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewLabRHem.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewLabRHem.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewLabRHem.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewLabRSto_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewLabRSto.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewLabRSto.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewLabRSto.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewLabRSto.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DataGridViewLabRUri_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewLabRUri.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewLabRUri.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewLabRUri.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewLabRUri.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewLabRSero_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewLabRSero.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewLabRSero.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewLabRSero.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewLabRSero.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewLabRAll_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewLabRAll.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewLabRAll.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewLabRAll.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewLabRAll.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DataGridViewLabRHem_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewLabRHem.CellFormatting
        DataGridViewLabRHem.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewLabRSto_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewLabRSto.CellFormatting
        DataGridViewLabRSto.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewLabRUri_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewLabRUri.CellFormatting
        DataGridViewLabRUri.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewLabRSero_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewLabRSero.CellFormatting
        DataGridViewLabRSero.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewLabRAll_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewLabRAll.CellFormatting
        DataGridViewLabRAll.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub btnexportalllabreslt_Click(sender As Object, e As EventArgs) Handles btnexportalllabreslt.Click
        Try
            btnexportalllabreslt.Text = "Please wait..."
            btnexportalllabreslt.Enabled = False
            SaveFileDialogalllabrslt.Filter = "Excel Docoment (*.xlsx)|*.xlsx"
            If SaveFileDialogalllabrslt.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")

                For x = 0 To DataGridViewLabRAll.RowCount - 2
                    For y = 0 To DataGridViewLabRAll.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewLabRAll.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewLabRAll.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewLabRAll(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogalllabrslt.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjectmed(xlapp)
                releaseObjectmed(xlworkbook)
                releaseObjectmed(xlworksheet)
                MsgBox("Successfully saved" & vbCrLf & "File saved at:" & SaveFileDialogalllabrslt.FileName, MsgBoxStyle.Information, "Information")
                btnexportalllabreslt.Text = "Export to Excel"
                btnexportalllabreslt.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save", "Error Message - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObjectmed(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
#End Region
End Class