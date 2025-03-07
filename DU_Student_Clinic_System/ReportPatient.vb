Public Class ReportPatient
    Private Sub ReportPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Diagnosis_Dataset.patientdiagnosistbl' table. You can move, or remove it, as needed.
        Try
            Me.patientdiagnosistblTableAdapter.Fill(Me.Diagnosis_Dataset.patientdiagnosistbl)
            Me.ReportViewerPatientReport.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnSearchPaRport_Click(sender As Object, e As EventArgs) Handles btnSearchPaRport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchPaRport.Text) Then
                Dim keyword As String = Me.txtboxSearchPaRport.Text.Trim()
                'If
                Me.patientdiagnosistblBindingSource.Filter =
                    "(name LIKE '%" & keyword & "%')" &
                    "OR (diagnosisoricd LIKE '%" & keyword & "%')" &
                    "OR (branch LIKE '%" & keyword & "%')"
                Me.ReportViewerPatientReport.RefreshReport()
            Else
                Me.patientdiagnosistblBindingSource.RemoveFilter()
                ReportPatient_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchPaRport.Focus()
        End Try
    End Sub
    Private Sub txtboxSearchPaRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchPaRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchPaRport.PerformClick()
        End If
    End Sub

    Private Sub btnsrchbycmbox_Click(sender As Object, e As EventArgs) Handles btnsrchbycmbox.Click
        Try
            Dim brn = Mainmenu.lblcampus.Text.Trim()
            If Not String.IsNullOrEmpty(txtboxsrchbybranchanddiagnosisoricdonly.Text) Then
                Dim keyword As String = Me.txtboxsrchbybranchanddiagnosisoricdonly.Text.Trim()
                Me.patientdiagnosistblBindingSource.Filter =
                        "(diagnosisoricd LIKE '%" & keyword & "%')" &
                        "AND (branch='" & brn & "')"
                Me.ReportViewerPatientReport.RefreshReport()
            Else
                Me.patientdiagnosistblBindingSource.RemoveFilter()
                    ReportPatient_Load(sender, e)
                End If
           ' End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxsrchbybranchanddiagnosisoricdonly.Focus()
        End Try
    End Sub
End Class