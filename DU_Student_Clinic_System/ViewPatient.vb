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
Public Class ViewPatient
    ' Dim connection As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Dim index As Integer
#Region "Load data"
#End Region
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProviderVP.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DUSCSDataSet.patienttbl' table. You can move, or remove it, as needed.
        FilterData("")
        'FilterDtedit("")
        FilterDataTopId("")
        Location = New Point(Mainmenu.Left + 25, Mainmenu.Top + 45)
    End Sub
    Public Sub FilterData(valueToSearch As String)
        Try
            Dim brnp As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuery As String = "select * from patienttbl where CONCAT(name,email,phone,patientid,branch) like '%" & valueToSearch & "%' and branch='" & brnp & "'"
            Dim command As New SqlCommand(SearchQuery, cn)
            Dim da As New SqlDataAdapter(command)
            Dim table As New DataTable()
            da.Fill(table)
            DataGridViewVAllPatient.DataSource = table
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub FilterDataTopId(valueToSearch As String)
        Try
            Dim brnp As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQueryt As String = "select Top(1) * from patienttbl where branch='" & brnp & "' ORDER BY patientid DESC"
            Dim commandt As New SqlCommand(SearchQueryt, cn)
            Dim dat As New SqlDataAdapter(commandt)
            Dim tablet As New DataTable()
            dat.Fill(tablet)
            DataGridViewpatientandedit.DataSource = tablet
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub ToolStripbtnpatientsearch_Click(sender As Object, e As EventArgs)
        FilterData(TextBoxPSearch.Text)
    End Sub
    Private Sub TextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ToolStripbtnpatientsearch_Click(sender, e)
        End If
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs)
        FilterData(TextBoxPSearch.Text)
    End Sub
#Region "Modify patient history"
    Public Sub FilterDtedit(valToSearch As String)
        Try
            'Dim SearchQery As String = "select * from patienttbl where CONCAT(name,email,phone,patientid,branch) like '%" & valToSearch & "%'"
            'Dim brnpnt As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            'Dim SearchQery As String = "select * from patienttbl where CONCAT(name,email,phone,patientid,branch) like '%" & valToSearch & "%' and branch!='Odayea Campus' and branch!='Main Campus'"
            Dim SearchQery As String = "select * from patienttbl where CONCAT(name,email,phone,patientid,branch) like '%" & valToSearch & "%'"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            'DataGridViewAllEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridViewpatientandedit.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword To search", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
    'Public Sub ExcuteQuery(query As String)
    '    'For db connection and excution 
    '    Dim command As New SqlCommand(query, connection)
    '    connection.Open()
    '    command.ExecuteNonQuery()
    '    connection.Close()

    'End Sub
#Region "Delete patient detail"
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    'TO DO Delete data in table of db
    '    If vld(TextBox1, TextBox2, TextBox3, TextBox4) = False Then
    '        'Exit Sub
    '    Else
    '        Dim deletequery As String = "delete from patienttbl where patientid='" & TextBox4.Text & "'"
    '        ExcuteQuery(deletequery)
    '        MessageBox.Show("Successfully deleted !", "Data deleted - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'MessageBox.Show("Successfully updated!")
    '        TextBox1.Clear()
    '        TextBox2.Clear()
    '        TextBox3.Clear()
    '        TextBox4.Clear()
    '        TextBox1.Focus()
    '    End If
    'End Sub
#End Region
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim p As New frmPatientReport()
        'p.TopMost = True
        'p.Show()
    End Sub

    Private Sub btneditemp_Click(sender As Object, e As EventArgs) Handles btneditemp.Click
        If vld(txtpeid, txtpename, cmbboxpebranch, cmbboxpeopd) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            Dim updtequery As String = "update patienttbl set branch='" & cmbboxpebranch.Text & "', opdname='" & cmbboxpeopd.Text & "' where patientid='" & txtpeid.Text & "'"
            InsertUpdateDelete(updtequery)
            MessageBox.Show("Successfully edited !", "Data updated - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("Successfully updated!")
            txtpeid.Clear()
            txtpeaddress.Clear()
            txtpeemail.Clear()
            txtpename.Clear()
            txtpephone.Clear()
            cmbboxpebranch.Text = ""
            cmbboxpeopd.Text = ""
            txtpeid.Focus()
        End If
    End Sub
    Private Sub DataGridViewpatientandedit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewpatientandedit.CellContentClick
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewpatientandedit.Rows(index)
            txtpeid.Text = selectedRow.Cells(0).Value.ToString
            txtpename.Text = selectedRow.Cells(1).Value.ToString
            txtpeemail.Text = selectedRow.Cells(12).Value.ToString
            txtpeaddress.Text = selectedRow.Cells(11).Value.ToString
            txtpephone.Text = selectedRow.Cells(13).Value.ToString
            cmbboxpebranch.Text = selectedRow.Cells(5).Value.ToString
            cmbboxpeopd.Text = selectedRow.Cells(17).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy patient details from database", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txttobeeditandsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txttobeeditandsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripBtnEditPSearch_Click(sender, e)
        End If
    End Sub
    Private Sub ToolStripBtnEditPSearch_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEditPSearch.Click
        FilterDtedit(txttobeeditandsearch.Text)
    End Sub
    Private Sub btnclremplist_Click(sender As Object, e As EventArgs) Handles btnclremplist.Click
        txtpeid.Clear()
        txtpename.Clear()
        txtpeaddress.Clear()
        txtpeemail.Clear()
        txtpephone.Clear()
        'txtpeid.Focus()
    End Sub
    Private Sub DataGridViewVAllPatient_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewVAllPatient.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewVAllPatient.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewVAllPatient.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewVAllPatient.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewpatientandedit_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewpatientandedit.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewpatientandedit.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewpatientandedit.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewpatientandedit.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewVAllPatient_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewVAllPatient.CellFormatting
        DataGridViewVAllPatient.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewpatientandedit_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewpatientandedit.CellFormatting
        DataGridViewpatientandedit.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
    Private Sub ToolStripbtnSrchP_Click(sender As Object, e As EventArgs) Handles ToolStripbtnSrchP.Click
        FilterData(TextBoxPSearch.Text)
    End Sub

    Private Sub btnexportvp_Click(sender As Object, e As EventArgs) Handles btnexportvp.Click
        Try
            btnexportvp.Text = "Please wait..."
            btnexportvp.Enabled = False
            SaveFileDialogvp.Filter = "Excel Docoment (*.xlsx)|*.xlsx"
            If SaveFileDialogvp.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")

                For x = 0 To DataGridViewVAllPatient.RowCount - 2
                    For y = 0 To DataGridViewVAllPatient.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewVAllPatient.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewVAllPatient.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewVAllPatient(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogvp.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjectmed(xlapp)
                releaseObjectmed(xlworkbook)
                releaseObjectmed(xlworksheet)
                MsgBox("Successfully saved" & vbCrLf & "File saved at:" & SaveFileDialogvp.FileName, MsgBoxStyle.Information, "Information")
                btnexportvp.Text = "Export to Excel"
                btnexportvp.Enabled = True
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
End Class