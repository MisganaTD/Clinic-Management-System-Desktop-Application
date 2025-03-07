Public Class ReportExpirytobe
    Private Sub ReportExpirytobe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'DUSCSDataSetToBeExpi.mainstoretbl' table. You can move, or remove it, as needed.
            Me.mainstoretblTableAdapter.Fill(Me.DUSCSDataSetToBeExpi.mainstoretbl)
            Me.ReportViewerStockdatatobexpi.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSearchstocktobeRport_Click(sender As Object, e As EventArgs) Handles btnSearchstocktobeRport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchstocktobeRport.Text) Then
                Dim keyword As String = Me.txtboxSearchstocktobeRport.Text.Trim()
                'If
                Me.mainstoretblBindingSource.Filter =
                    "(productnamestrengthdosageform LIKE '%" & keyword & "%')"
                Me.ReportViewerStockdatatobexpi.RefreshReport()
            Else
                Me.mainstoretblBindingSource.RemoveFilter()
                ReportExpirytobe_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchstocktobeRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchstocktobeRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchstocktobeRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchstocktobeRport.PerformClick()
        End If
    End Sub
End Class