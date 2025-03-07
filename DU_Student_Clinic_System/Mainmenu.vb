Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlDataReader
'Imports System.Windows.Forms.Button
Public Class Mainmenu
    Dim cmd As SqlCommand
    Dim GlobalUserRole As String
    Dim GlobalUserID As String
    Private currentDate As DateTime = DateTime.Today
    'Dim Filename As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtlblusername.Text = txtboxUserName.ToString
        'txtlblusername.Text = Login.txtboxUserName.ToString 'Login.txtboxUserName.ToString
        Dim dtime As DateTime = currentDate.ToString("ddd, dd MMMM yyy")
        'Datedmy.Text = currentDate.ToString("ddd, dd MMMM yyy")
        ' If lbldatedmy.Visible = True Then
        'lbldatedmy.Text = dtime
        'myTimer.Start()
        'Else
        'myTimer.Stop()
        'End If
    End Sub
    Private Function mytime(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick
        Dim tm As String = ""
        tm &= mytime(DateTime.Now.Hour)
        tm &= ":" & mytime(DateTime.Now.Minute)
        tm &= ":" & mytime(DateTime.Now.Second)
        ''lbltime.Text = tm 'by misgana
        ' lbltime.Text = tm
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Employee.Show()
    End Sub
    Private Sub ViewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPatientToolStripMenuItem.Click
        AddPatient.Show()
    End Sub
    Private Sub PrescriptionEntryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        DiagnosisandPrescriptionEntry.Show()
    End Sub
    Private Sub PatientDiagnosisToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PDiagHistory.Show()
    End Sub
    Private Sub PatientInjectionEntryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PInjectionEntry.Show()
    End Sub
    Private Sub AppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDisplayAppointment.Show()
    End Sub
    Private Sub OtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherToolStripMenuItem.Click
        MsgBox("Product Name: Clinic and Pharm Store Management System" & vbNewLine & vbNewLine & "Version: 1.0.0" & vbNewLine & vbNewLine & "Copyright : Coder" & vbNewLine & vbNewLine & "Developer team: " & vbNewLine & vbNewLine & "Description: This Clinic and Pharm Store Management System is a desktop application software which is capable of managing Clinics’ patients and thier appointments and pharm store. The user inteface is simple and clean in order to achieve maximum efficiency")
    End Sub
    Private Sub PrescriptionEntryDiagnosisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrescriptionEntryDiagnosisToolStripMenuItem.Click
        DiagnosisandPrescriptionEntry.Show()
    End Sub
    Private Sub ViewPatientToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        ViewPatient.Show()
    End Sub
    Private Sub RequestListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestListToolStripMenuItem.Click
        Prescriptionrequest.Show()
    End Sub
    Private Sub LaboratoryRequestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LabRequest.Show()
    End Sub
    Private Sub ViewLabResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLabResultToolStripMenuItem.Click
        'ViewLabResult.Show()
        Dim r As New ViewLabResult()
        r.TopMost = True
        r.Show()
    End Sub
    Private Sub AddTestResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTestResultToolStripMenuItem.Click
        AddLabResult.Show()
    End Sub
    Private Sub ViewCatagoricallyLabReslutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCatagoricallyLabReslutToolStripMenuItem.Click
        LabResultCategory.Show()
    End Sub
    Private Sub TestReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientReportsToolStripMenuItem.Click
        Dim pr As New ReportPatient()
        pr.TopMost = True
        pr.Show()
    End Sub
    Private Sub ReportByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportPharmToolStripMenuItem.Click
        Dim pha As New ReportPharmacy()
        pha.TopMost = True
        pha.Show()
    End Sub

    Private Sub PatientAppointmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PatientAppointmentToolStripMenuItem1.Click
        frmDisplayAppointment.Show()
    End Sub
    Private Sub ViewPatientToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ViewPatientToolStripMenuItem2.Click
        ViewPatient.Show()
    End Sub

    Private Sub ChangeYourPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeYourPasswordToolStripMenuItem.Click
        'Me.Hide()
        ChangePassword.Show()
    End Sub

    Private Sub LabReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabReportToolStripMenuItem.Click
        Dim Lab As New ReportLab()
        Lab.TopMost = True
        Lab.Show()
    End Sub
    Private Sub LabReportByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabReportByDateToolStripMenuItem.Click
        ReportLabbydate.Show()
    End Sub

    Private Sub ViewPatientToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ViewPatient.Show()
    End Sub
    Private Sub PatientRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientRegistrationToolStripMenuItem.Click
        AddPatient.Show()
    End Sub
    Private Sub ResetEmployeePasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetEmployeePasswordToolStripMenuItem1.Click
        frmResetEmppassword.Show()
    End Sub
    Private Sub TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TToolStripMenuItem.Click
        EmployeeEdit.Show()
    End Sub
    Private Sub ViewEditPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEditPatientToolStripMenuItem.Click
        ViewPatient.Show()
    End Sub

    Private Sub ManageStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStockToolStripMenuItem.Click
        Store.Show()
    End Sub
    Private Sub RequestStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestStockToolStripMenuItem.Click
        RequestStockItem.Show()
    End Sub

    Private Sub ApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApprovalToolStripMenuItem.Click
        ApprovalreqstockbyTeamleader.Show()
    End Sub
    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Dim psto As New ReportStock()
        psto.TopMost = True
        psto.Show()
    End Sub

    Private Sub ExpiryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpiryToolStripMenuItem.Click
        Dim pexp As New ReportExpiry()
        pexp.TopMost = True
        pexp.Show()
    End Sub

    Private Sub ConsumedStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumedStockToolStripMenuItem.Click
        Dim pcst As New ReportConsumedStock()
        pcst.TopMost = True
        pcst.Show()
    End Sub
    Private Sub ExpiryAlertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpiryAlertToolStripMenuItem.Click
        Dim rprtp As New ReportExpirytobe()
        rprtp.TopMost = True
        rprtp.Show()
    End Sub

    Private Sub RequestedStockbyPharmasistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestedStockbyPharmasistToolStripMenuItem.Click
        Dim rprtp As New ReportRequestedStockbyPharmasist()
        rprtp.TopMost = True
        rprtp.Show()
    End Sub

    Private Sub DispenseryByPharmasistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispenseryByPharmasistToolStripMenuItem.Click
        Dim rprtp As New Reportdispenserforphyiscian()
        rprtp.TopMost = True
        rprtp.Show()
    End Sub

    Private Sub ProceedRequestedStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProceedRequestedStockToolStripMenuItem.Click
        Proceeditemrequest.Show()
    End Sub
    '#Region "Backup database"
    '    Sub Backup()
    '        Try
    '            Dim dt As DateTime = Today
    '            Dim destdir As String = "DUSCS" & System.DateTime.Now.ToString("dd-MM-yyyy_h-mm-ss") & ".bak"
    '            Dim objdlg As New SaveFileDialog
    '            objdlg.FileName = destdir
    '            objdlg.ShowDialog()
    '            Filename = objdlg.FileName
    '            Cursor = Cursors.WaitCursor
    '            ' Timer2.Enabled = True
    '            'cn = New SqlConnection()
    '            cn.Open()
    '            Dim cb As String = "backup database DUSCS to disk='" & Filename & "'with init,stats=10"
    '            cmd = New SqlCommand(cb)
    '            cmd.Connection = cn
    '            cmd.ExecuteReader()
    '            cn.Close()

    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Sub
    '    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
    '        Backup()
    '    End Sub
    '#End Region
End Class
