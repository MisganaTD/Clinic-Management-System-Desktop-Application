Public Class Reportdispenserforphyiscian
    Private Sub Reportdispenserforphyiscian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'DataSetDispenseryPhyiscians.dispenseryforphysiciantbl' table. You can move, or remove it, as needed.
            Me.dispenseryforphysiciantblTableAdapter.Fill(Me.DataSetDispenseryPhyiscians.dispenseryforphysiciantbl)
            Me.ReportViewerreqddstock.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnSearchddReport_Click(sender As Object, e As EventArgs) Handles btnSearchddReport.Click
        Try
            If Not String.IsNullOrEmpty(txtboxSearchddRport.Text) Then
                Dim keyword As String = Me.txtboxSearchddRport.Text.Trim()
                'If
                Me.dispenseryforphysiciantblBindingSource.Filter =
                    "(items LIKE '%" & keyword & "%')" &
                    "OR (branch LIKE '%" & keyword & "%')" &
                    "OR (dispensereid LIKE '%" & keyword & "%')"
                Me.ReportViewerreqddstock.RefreshReport()
            Else
                Me.dispenseryforphysiciantblBindingSource.RemoveFilter()
                Reportdispenserforphyiscian_Load(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtboxSearchddRport.Focus()
        End Try
    End Sub

    Private Sub txtboxSearchddRport_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearchddRport.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearchddReport.PerformClick()
        End If
    End Sub

    Private Sub btnsearchddfromto_Click(sender As Object, e As EventArgs) Handles btnsearchddfromto.Click
        Try
            'If Not String.IsNullOrEmpty(txtboxSearchconsumedstockRport.Text) Then
            Dim datfromds As DateTime = Me.DateTimePickerddfrom.Value.ToShortDateString()
            Dim dattods As DateTime = Me.DateTimePickerddto.Value.ToShortDateString()
            Me.dispenseryforphysiciantblBindingSource.Filter =
                "(dispenseddate >= '" & datfromds & "' and dispenseddate <= '" & dattods & "')"
            Me.ReportViewerreqddstock.RefreshReport()
            'Me.prescriptiontblBindingSource.RemoveFilter()
            'ReportConsumedStock_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString(), "Error Handler - DU Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            ' Me.txtboxSearchconsumedstockRport.Focus()
        End Try
    End Sub
End Class