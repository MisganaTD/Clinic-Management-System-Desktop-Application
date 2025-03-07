Imports System.Data.SqlClient
Public Class EmployeeEdit
    Dim index As Integer
    'declare global variable
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProviderDctF.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub btnclremplist_Click(sender As Object, e As EventArgs) Handles btnclremplist.Click
        txtboxeditaddress.Clear()
        txtboxediteid.Clear()
        txtboxeditemail.Clear()
        txtboxeditfn.Clear()
        txtboxeditphone.Clear()
        cmbboxeditbranch.Text = ""
        cmbboxeditdept.Text = ""
        cmbboxeditgender.Text = ""
        cmbboxeditqual.Text = ""
        cmbboxeditrole.Text = ""
        txtboxediteid.Focus()
    End Sub

    Private Sub btneditemp_Click(sender As Object, e As EventArgs) Handles btneditemp.Click
        If vld(txtboxeditaddress, txtboxediteid, txtboxeditemail, txtboxeditfn, txtboxeditphone, cmbboxeditbranch, cmbboxeditdept, cmbboxeditgender, cmbboxeditqual, cmbboxeditrole) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            Dim updtequery As String = "update physiciantbl set name='" & txtboxeditfn.Text & "', email='" & txtboxeditemail.Text & "', address='" & txtboxeditaddress.Text & "', phonenumber='" & txtboxeditphone.Text & "', department='" & cmbboxeditdept.Text & "', branch='" & cmbboxeditbranch.Text & "', qualification='" & cmbboxeditqual.Text & "', gender='" & cmbboxeditgender.Text & "', emprole='" & cmbboxeditrole.Text & "',opdname='" & cmbboxopdname.Text & "' where physicianid='" & txtboxediteid.Text & "'"
            InsertUpdateDelete(updtequery)
            MessageBox.Show("Successfully edited !", "Data updated - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("Successfully updated!")
            txtboxeditaddress.Clear()
            txtboxediteid.Clear()
            txtboxeditemail.Clear()
            txtboxeditfn.Clear()
            txtboxeditphone.Clear()
            cmbboxeditbranch.Text = ""
            cmbboxeditdept.Text = ""
            cmbboxeditgender.Text = ""
            cmbboxeditqual.Text = ""
            cmbboxeditrole.Text = ""
            txtboxediteid.Focus()
        End If
    End Sub
    Private Sub DataGridViewAllEmployeeforEdit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAllEmployeeforEdit.CellContentClick
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewAllEmployeeforEdit.Rows(index)
            txtboxediteid.Text = selectedRow.Cells(0).Value.ToString
            txtboxeditfn.Text = selectedRow.Cells(1).Value.ToString
            txtboxeditemail.Text = selectedRow.Cells(2).Value.ToString
            txtboxeditaddress.Text = selectedRow.Cells(3).Value.ToString
            txtboxeditphone.Text = selectedRow.Cells(4).Value.ToString
            cmbboxeditdept.Text = selectedRow.Cells(5).Value.ToString
            cmbboxeditbranch.Text = selectedRow.Cells(6).Value.ToString
            cmbboxeditgender.Text = selectedRow.Cells(7).Value.ToString
            cmbboxeditqual.Text = selectedRow.Cells(8).Value.ToString
            cmbboxeditrole.Text = selectedRow.Cells(9).Value.ToString
            cmbboxopdname.Text = selectedRow.Cells(16).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy employee details from database", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub ToolStripBtnEditEmpSearch_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEditEmpSearch.Click
        FilterDtedit(txttobeeditandsearch.Text)
    End Sub
    Public Sub FilterDtedit(valToSearch As String)
        Try
            Dim SearchQery As String = "select * from physiciantbl where CONCAT(name,email,phonenumber,physicianid,branch) like '%" & valToSearch & "%'"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            'DataGridViewAllEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridViewAllEmployeeforEdit.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub txttobeeditandsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txttobeeditandsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripBtnEditEmpSearch_Click(sender, e)
        End If
    End Sub
    Private Sub txttobeeditandsearch_TextChanged(sender As Object, e As EventArgs) Handles txttobeeditandsearch.TextChanged
        FilterDtedit(txttobeeditandsearch.Text)
    End Sub
    Private Sub EmployeeEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterDtedit("")
    End Sub
    Private Sub btninactiveemp_Click(sender As Object, e As EventArgs) Handles btninactiveemp.Click
        If vld(txtEmpIDtobeinactive) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to inactive this employee ?") Then
            '-----------------  reset emppassword---------------------------------------------------------
            conn.Open()
            Dim cmder As SqlCommand = New SqlCommand("select physicianid from physiciantbl where physicianid=@epid", conn)
            cmder.Parameters.AddWithValue("@epid", txtEmpIDtobeinactive.Text)
            Dim nowdate As DateTime = DateTime.Today
            Dim rdrr As SqlDataReader = cmder.ExecuteReader()
            If rdrr.HasRows Then
                Dim updateuery As String = "update physiciantbl set status = 0 where physicianid ='" & txtEmpIDtobeinactive.Text & "'"
                InsertUpdateDelete(updateuery)
                MessageBox.Show("Done successfully !", "Data Inactive - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully updated!"
                txtEmpIDtobeinactive.Clear()
                txtEmpIDtobeinactive.Focus()
            Else
                MsgBox("No such employee id exist please try again!", MsgBoxStyle.Critical)
            End If
        End If
        conn.Close()
    End Sub
    Private Sub DataGridViewAllEmployeeforEdit_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewAllEmployeeforEdit.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewAllEmployeeforEdit.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewAllEmployeeforEdit.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewAllEmployeeforEdit.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewAllEmployeeforEdit_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewAllEmployeeforEdit.CellFormatting
        DataGridViewAllEmployeeforEdit.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
End Class