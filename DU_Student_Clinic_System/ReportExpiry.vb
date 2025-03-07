Public Class ReportExpiry
    Private Sub ReportExpiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Expiry.mainstoretbl' table. You can move, or remove it, as needed.
        Try
            Me.mainstoretblTableAdapter.Fill(Me.Expiry.mainstoretbl)
            Me.ReportViewerExpirydata.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSearchexpiryReport_Click(sender As Object, e As EventArgs) Handles btnSearchexpiryReport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchexpiryRport.Text) Then
                Dim keyword As String = Me.txtboxSearchexpiryRport.Text.Trim()
                'If
                Me.mainstoretblBindingSource.Filter =
                    "(productnamestrengthdosageform LIKE '%" & keyword & "%')" &
                    "OR (batchno LIKE '%" & keyword & "%')"
                Me.ReportViewerExpirydata.RefreshReport()
            Else
                Me.mainstoretblBindingSource.RemoveFilter()
                ReportExpiry_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchexpiryRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchexpiryRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchexpiryRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchexpiryReport.PerformClick()
        End If
    End Sub
End Class