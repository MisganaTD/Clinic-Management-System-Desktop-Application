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
Public Class ReportPharmacy
    Private Sub ReportPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pharmcy_DataSet.prescriptiontbl' table. You can move, or remove it, as needed.
        Try
            Me.prescriptiontblTableAdapter.Fill(Me.Pharmcy_DataSet.prescriptiontbl)
            Me.ReportViewerPharRport.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSearchPharRport_Click(sender As Object, e As EventArgs) Handles btnSearchPharRport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchPharRport.Text) Then
                Dim keyword As String = Me.txtboxSearchPharRport.Text.Trim()
                Me.prescriptiontblBindingSource.Filter =
                        "(department LIKE '%" & keyword & "%')" &
                        "OR (name LIKE '%" & keyword & "%')" &
                        "OR (drugname LIKE '%" & keyword & "%')" &
                        "OR (branch LIKE '%" & keyword & "%')"
                Me.ReportViewerPharRport.RefreshReport()
            Else
                'Me.prescriptiontblBindingSource.RemoveFilter()
                ReportPharmacy_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchPharRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchPharRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchPharRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchPharRport.PerformClick()
        End If
    End Sub

    Private Sub btnsrchbydrugnameandbranchonly_Click(sender As Object, e As EventArgs) Handles btnsrchbydrugnameandbranchonly.Click
        Try
            Dim brn = Mainmenu.lblcampus.Text.Trim()
            If Not String.IsNullOrEmpty(txtboxsrchbydrugnameandbranchonly.Text) Then
                Dim keyword As String = Me.txtboxsrchbydrugnameandbranchonly.Text.Trim()
                Me.prescriptiontblBindingSource.Filter =
                        "(drugname LIKE '%" & keyword & "%')" &
                        "AND (branch='" & brn & "')"
                Me.ReportViewerPharRport.RefreshReport()
            Else
                Me.prescriptiontblBindingSource.RemoveFilter()
                ReportPharmacy_Load(sender, e)
            End If
            ' End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxsrchbydrugnameandbranchonly.Focus()
        End Try
    End Sub

    Private Sub btnsearchpharmacyall_Click(sender As Object, e As EventArgs) Handles btnsearchpharmacyall.Click
        'Try
        Dim dtpallfrom As DateTime = dtpikerallfrom.Value.ToShortDateString()
        Dim dtpallto As DateTime = dtpickerallto.Value.ToShortDateString()
        Dim brall As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        'Where pres.giveoutstatus = 'dispensed' order by pres.dispenseddate
        Dim SearchQueryall As String = $"SELECT pres.patientid, ptb.name, ptb.gender, ptb.age, ptb.idnumber, ptb.department, ptb.year, ptb.branch, pres.drugid,pres.drugname, pres.strength,pres.dose, pres.dosageform, pres.quantity,pres.price,pres.otherinfo, pres.prescribersname, pres.prescribeddate, pres.dispensername,
         pres.dispenserqualification, pres.dispenserremark, pres.dispenseddate, pres.giveoutstatus From prescriptiontbl As pres INNER Join patienttbl As ptb
        On pres.patientid = ptb.patientid Where ptb.branch ='" & brall & "' and pres.dispenseddate BETWEEN '" & dtpallfrom & "' AND '" & dtpallto & "'"
        Dim c1 As New SqlCommand(SearchQueryall, cn)
        Dim d1 = New SqlDataAdapter(c1)
        Dim t1 As New DataTable()
        d1.Fill(t1)
        DataGridViewpharmcyall.DataSource = t1
        ' Catch ex As Exception
        'MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        ' End Try
        'Dim index As Integer = e.RowIndex
        'Dim ttl As Integer = DataGridViewLabRAll.DisplayedRowCount(index)
        Dim ttls As Integer = DataGridViewpharmcyall.DisplayedRowCount(True) 'get total number of lab result
        lblphtotal.Text = ttls
    End Sub
#Region "export paharmacy rprt to excel"
    Private Sub btnexportallpharmacyreslt_Click(sender As Object, e As EventArgs) Handles btnexportallpharmacyreslt.Click
        Try
            btnexportallpharmacyreslt.Text = "Please wait..."
            btnexportallpharmacyreslt.Enabled = False
            SaveFileDialogpharmcyallrslt.Filter = "Excel Docoment (*.xlsx)|*.xlsx"
            If SaveFileDialogpharmcyallrslt.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")

                For x = 0 To DataGridViewpharmcyall.RowCount - 2
                    For y = 0 To DataGridViewpharmcyall.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewpharmcyall.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewpharmcyall.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewpharmcyall(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogpharmcyallrslt.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjectph(xlapp)
                releaseObjectph(xlworkbook)
                releaseObjectph(xlworksheet)
                MsgBox("Successfully saved" & vbCrLf & "File saved at:" & SaveFileDialogpharmcyallrslt.FileName, MsgBoxStyle.Information, "Information")
                btnexportallpharmacyreslt.Text = "Export to Excel"
                btnexportallpharmacyreslt.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save", "Error Message - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObjectph(ByVal obj As Object)
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