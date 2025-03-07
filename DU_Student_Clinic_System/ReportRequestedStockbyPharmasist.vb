Public Class ReportRequestedStockbyPharmasist
    Private Sub ReportRequestedStockbyPharmasist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'DataSetReportRequestedby.pharmstoretbl' table. You can move, or remove it, as needed.
            Me.pharmstoretblTableAdapter.Fill(Me.DataSetReportRequestedby.pharmstoretbl)
            Me.ReportViewerreqstock.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSearchreqstockReport_Click(sender As Object, e As EventArgs) Handles btnSearchreqstockReport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchreqstockRport.Text) Then
                Dim keyword As String = Me.txtboxSearchreqstockRport.Text.Trim()
                'If
                Me.pharmstoretblBindingSource.Filter =
                    "(items LIKE '%" & keyword & "%')" &
                    "OR (branch LIKE '%" & keyword & "%')"
                Me.ReportViewerreqstock.RefreshReport()
            Else
                Me.pharmstoretblBindingSource.RemoveFilter()
                ReportRequestedStockbyPharmasist_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchreqstockRport.Focus()
        End Try
    End Sub

    Private Sub btnsearchcreqsto_Click(sender As Object, e As EventArgs) Handles btnsearchcreqsto.Click
        Try
            'If Not String.IsNullOrEmpty(txtboxSearchconsumedstockRport.Text) Then
            Dim datfrom As DateTime = Me.DateTimePickerreqtofrom.Value.ToShortDateString()
            Dim datto As DateTime = Me.DateTimePickerreqtoto.Value.ToShortDateString()
            Me.pharmstoretblBindingSource.Filter =
                "(dispenseddate >= '" & datfrom & "' and dispenseddate <= '" & datto & "')"
            Me.ReportViewerreqstock.RefreshReport()
            'Me.prescriptiontblBindingSource.RemoveFilter()
            'ReportConsumedStock_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            ' Me.txtboxSearchconsumedstockRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchreqstockRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchreqstockRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchreqstockReport.PerformClick()
        End If
    End Sub
End Class