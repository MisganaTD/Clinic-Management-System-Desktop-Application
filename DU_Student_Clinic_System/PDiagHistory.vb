Imports System.Data.SqlClient
Public Class PDiagHistory
    'Dim connection As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim searchCommand As New SqlCommand("select * from patienttbl where patientid=@RegID", cn)
        searchCommand.Parameters.Add("@RegID", SqlDbType.VarChar).Value = TextBoxRegID.Text
        Dim da As New SqlDataAdapter(searchCommand)
        Dim table As New DataTable()
        da.Fill(table)
        If table.Rows.Count > 0 Then
            TextBoxN.Text = table(0)(1)
            TextBoxGender.Text = table(0)(2)
            TextBoxAge.Text = table(0)(3)
            TextBoxRD.Text = table(0)(13)
        Else
            TextBoxN.Text = ""
            TextBoxGender.Text = ""
            TextBoxAge.Text = ""
            TextBoxRD.Text = ""
            MsgBox("No data found", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub PDiagHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-----------------Fill Auto Complete for patientid ------------------------------
        Try
            Dim command As New SqlCommand("select patientid from patienttbl", cn)
            Dim da As New SqlClient.SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds, "patienttbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To ds.Tables(0).Rows.Count - 1
                coltel.Add(ds.Tables(0).Rows(i)(0).ToString)
            Next
            TextBoxRegID.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBoxRegID.AutoCompleteCustomSource = coltel
            TextBoxRegID.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        End Try
        '------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub TextBoxRegID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRegID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6_Click(sender, e)
        End If
    End Sub
End Class