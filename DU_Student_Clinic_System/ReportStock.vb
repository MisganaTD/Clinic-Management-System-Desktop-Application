Public Class ReportStock
    Private Sub ReportStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DUSCSDataSetmainstoretbl.mainstoretbl' table. You can move, or remove it, as needed.
        Try
            Me.mainstoretblTableAdapter.Fill(Me.DUSCSDataSetmainstoretbl.mainstoretbl)
            Me.ReportViewerStockdata.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnSearchstockRport_Click(sender As Object, e As EventArgs) Handles btnSearchstockRport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchstockRport.Text) Then
                Dim keyword As String = Me.txtboxSearchstockRport.Text.Trim()
                'If
                Me.mainstoretblBindingSource.Filter =
                    "(productnamestrengthdosageform LIKE '%" & keyword & "%')" &
                    "OR (regbyempid LIKE '%" & keyword & "%')"
                Me.ReportViewerStockdata.RefreshReport()
            Else
                Me.mainstoretblBindingSource.RemoveFilter()
                ReportStock_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchstockRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchstockRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchstockRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchstockRport.PerformClick()
        End If
    End Sub

    Private Sub btnsearchsto_Click(sender As Object, e As EventArgs) Handles btnsearchsto.Click
        Try
            'If Not String.IsNullOrEmpty(txtboxSearchconsumedstockRport.Text) Then
            Dim datefrom As DateTime = Me.DateTimePickerstofrom.Value.ToShortDateString()
            Dim dateto As DateTime = Me.DateTimePickerstoto.Value.ToShortDateString()
            Me.mainstoretblBindingSource.Filter =
                "(regdate >= '" & datefrom & "' and regdate <= '" & dateto & "')"
            Me.ReportViewerStockdata.RefreshReport()
            'Me.prescriptiontblBindingSource.RemoveFilter()
            'ReportConsumedStock_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            ' Me.txtboxSearchconsumedstockRport.Focus()
        End Try
    End Sub
End Class