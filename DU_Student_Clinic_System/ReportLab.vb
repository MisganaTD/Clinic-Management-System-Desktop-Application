Public Class ReportLab
    Private Sub ReportLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LabResult_DataSet.labresult' table. You can move, or remove it, as needed.
        Try
            Me.labresultTableAdapter.Fill(Me.LabResult_DataSet.labresult)
            Me.ReportViewerLabRport.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnSearchLabRport_Click(sender As Object, e As EventArgs) Handles btnSearchLabRport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchLabport.Text) Then
                Dim keyword As String = Me.txtboxSearchLabport.Text.Trim()
                Me.labresultBindingSource.Filter =
                "(department LIKE '%" & keyword & "%')" &
                "OR (name LIKE '%" & keyword & "%')" &
                "OR (branch LIKE '%" & keyword & "%')"
                Me.ReportViewerLabRport.RefreshReport()
            Else
                'Me.prescriptiontblBindingSource.RemoveFilter()
                ReportLab_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchLabport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchLabport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchLabport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchLabRport.PerformClick()
        End If
    End Sub
End Class