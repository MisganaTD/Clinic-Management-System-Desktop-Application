Public Class ReportConsumedStock
    Private Sub ReportConsumedStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DUSCSDataSetmainstoretbl.mainstoretbl' table. You can move, or remove it, as needed.
        Try
            Me.prescriptiontblTableAdapter.Fill(Me.ConsumedStockItemprecritbl.prescriptiontbl)
            Me.ReportViewerConsumedstock.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSearchconsumstockReport_Click(sender As Object, e As EventArgs) Handles btnSearchconsumstockReport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchconsumedstockRport.Text) Then
                Dim keyword As String = Me.txtboxSearchconsumedstockRport.Text.Trim()
                'If
                Me.prescriptiontblBindingSource.Filter =
                    "(allproductnsdform LIKE '%" & keyword & "%')" &
                    "OR (dispensereid LIKE '%" & keyword & "%')"
                Me.ReportViewerConsumedstock.RefreshReport()
            Else
                Me.prescriptiontblBindingSource.RemoveFilter()
                ReportConsumedStock_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchconsumedstockRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchconsumedstockRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchconsumedstockRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchconsumstockReport.PerformClick()
        End If
    End Sub

    Private Sub btnsearchconsto_Click(sender As Object, e As EventArgs) Handles btnsearchconsto.Click
        Try
            'If Not String.IsNullOrEmpty(txtboxSearchconsumedstockRport.Text) Then
            Dim datefrom As DateTime = Me.DateTimePickercstofrom.Value.ToShortDateString()
            Dim dateto As DateTime = Me.DateTimePickercstoto.Value.ToShortDateString()
            Me.prescriptiontblBindingSource.Filter =
                "(dispenseddate >= '" & datefrom & "' and dispenseddate <= '" & dateto & "')"
            Me.ReportViewerConsumedstock.RefreshReport()
            'Me.prescriptiontblBindingSource.RemoveFilter()
            'ReportConsumedStock_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            ' Me.txtboxSearchconsumedstockRport.Focus()
        End Try
    End Sub
End Class