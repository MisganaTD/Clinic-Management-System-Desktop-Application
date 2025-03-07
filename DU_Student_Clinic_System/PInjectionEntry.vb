
Imports System.Data.SqlClient
Public Class PInjectionEntry
    ' Dim connection As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim searchCommand As New SqlCommand("select * from patienttbl where patientid=@RegID", cn)
        searchCommand.Parameters.Add("@RegID", SqlDbType.VarChar).Value = TextBoxRegID.Text
        Dim dapa As New SqlDataAdapter(searchCommand)
        Dim tablep As New DataTable()
        dapa.Fill(tablep)
        If tablep.Rows.Count > 0 Then
            TextBoxN.Text = tablep(0)(1)
            TextBoxGender.Text = tablep(0)(2)
            TextBoxAge.Text = tablep(0)(3)
            TextBoxAddress.Text = tablep(0)(11)
        Else
            TextBoxN.Text = ""
            TextBoxGender.Text = ""
            TextBoxAge.Text = ""
            TextBoxAddress.Text = ""
            MsgBox("No data found", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBoxRegID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRegID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6_Click(sender, e)
        End If
    End Sub

    Private Sub PInjectionEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-----------------Fill Auto Complete for patientid ------------------------------
        Try
            Dim commandp As New SqlCommand("select patientid from patienttbl", cn)
            Dim dap As New SqlClient.SqlDataAdapter(commandp)
            Dim dsp As New DataSet
            dap.Fill(dsp, "patienttbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To dsp.Tables(0).Rows.Count - 1
                coltel.Add(dsp.Tables(0).Rows(i)(0).ToString)
            Next
            TextBoxRegID.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBoxRegID.AutoCompleteCustomSource = coltel
            TextBoxRegID.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        End Try
        '------------------------------------------------------------------------------------------------------
    End Sub
End Class