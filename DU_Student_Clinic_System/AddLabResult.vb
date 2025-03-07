Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Public Class AddLabResult
    Public conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProviderAdd.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#Region "Patient detail"
    Private Sub ButtonSubmitL_Click(sender As Object, e As EventArgs) Handles ButtonSubmitL.Click
        'Dim searchCommand As New SqlCommand("select * from patientdiagnosistbl where patientid=@pid", conn)
        'Dim opd As String = Mainmenu.lblopd.Text.Trim() 'opdname.ToString() 
        Dim brn As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
        Dim searchCommand As New SqlCommand("SELECT pd.patientid, ptbl.name, ptbl.gender, ptbl.age, ptbl.idnumber, ptbl.department,ptbl.branch, ptbl.year,
 pd.reportedby,pd.diagnosisdate FROM patientdiagnosistbl AS pd INNER JOIN   patienttbl AS ptbl ON pd.patientid = ptbl.patientid
where pd.status='senttolab' and ptbl.branch = '" & brn & "' and pd.patientid=@pid ", conn)
        searchCommand.Parameters.Add("@pid", SqlDbType.VarChar).Value = txtpidlabadd.Text
        Dim adapter As New SqlDataAdapter(searchCommand)
        'Dim dalb As New SqlDataAdapter(searchCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            TextBoxNAdd.Text = table(0)(1)
            TextBoxGenderAdd.Text = table(0)(2)
            TextBoxAgeAdd.Text = table(0)(3)
            TextBoxPaBranch.Text = table(0)(6)
            TextBoxIDAdd.Text = table(0)(4)
            TextBoxDetforAdd.Text = table(0)(5)
            TextBoxyearforAdd.Text = table(0)(7)
        Else
            TextBoxNAdd.Text = ""
            TextBoxGenderAdd.Text = ""
            TextBoxAgeAdd.Text = ""
            TextBoxPaBranch.Text = ""
            TextBoxIDAdd.Text = ""
            TextBoxDetforAdd.Text = ""
            TextBoxyearforAdd.Text = ""
            MsgBox("No data sent to lab from physician by this patient id!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub txtpidlabadd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpidlabadd.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonSubmitL_Click(sender, e)
        End If
    End Sub
#End Region
#Region " add Lab result Test"
    Private Sub btnSaveLrslt_Click(sender As Object, e As EventArgs) Handles btnSaveLrslt.Click
        'Serology test
        If vld(txtpidlabadd) = False Then
            'Exit Sub
            MsgBox("Please make sure to fill necessary information first", MsgBoxStyle.Critical)
            '-----------------  serolo rslt detail---------------------------------------------------------
        Else
            Try
                conn.Open()
                Dim srby As String = Mainmenu.lblusername.Text 'userName.ToString()
                Dim cmdser As New SqlCommand("select * from physiciantbl WHERE name = '" & srby & "'", conn)
        Dim rd As SqlDataReader = cmdser.ExecuteReader()
                If (rd.HasRows) Then
                    While (rd.Read())
                        'Mainmenu.txtlblusername.Text = dr("name").ToString()
                        Dim serby = rd("name").ToString()
                        'Dim sebyqual = dr("employeetype").ToString()
                        Dim addbyeid As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                        Dim insertQuery As String = "insert into labresult(patientid,bf, otherhema, appearance, microscopy, urinedeepsticktest, rbc, wbc, epithalialcells, hcg, othersurina, hd, od, wellfelix, pregnancytest, reportedby, remarkedby, resultdate,physicianid) values('" & txtpidlabadd.Text & "','" & TextBoxBF.Text & "', '" & TextBoxOthrhem.Text & "','" & TextBoxSAp.Text & "', '" & TextBoxSM.Text & "','" & TextBoxUdip.Text & "','" & TextBoxUrbc.Text & "','" & TextBoxUwbc.Text & "','" & TextBoxUep.Text & "','" & TextBoxUhcg.Text & "','" & TextBoxUoth.Text & "','" & TextBoxSehd.Text & "','" & TextBoxSeod.Text & "','" & TextBoxSewf.Text & "','" & TextBoxSept.Text & "','" & serby & "','" & TextBoxSeRem.Text & "', '" & DateTimeSero.Value.ToShortDateString() & "','" & addbyeid & "')"
                        InsertUpdateDelete(insertQuery)
                        Dim sta As String = "completed"
                        Dim updatequery As String = "update patientdiagnosistbl set status = '" & sta & "' where patientid='" & txtpidlabadd.Text & "'"
                        InsertUpdateDelete(updatequery)
                        MessageBox.Show("Data successfully added", "Data added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End While
                    rd.Close()
                    conn.Close()
                End If
            Catch ex As Exception
                MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            End Try
            '-------------------------------end  serorsltby detail -----------------------------------------------------------
            '--------------------------------------- clear sero text box ------------------------
            txtpidlabadd.Clear()
            TextBoxPaBranch.Clear()
            TextBoxNAdd.Clear()
            TextBoxAgeAdd.Clear()
            TextBoxGenderAdd.Clear()
            TextBoxIDAdd.Clear()
            TextBoxDetforAdd.Clear()
            TextBoxyearforAdd.Clear()
            TextBoxSehd.Clear()
            TextBoxSeod.Clear()
            TextBoxSewf.Clear()
            TextBoxSept.Clear()
            TextBoxSeRem.Clear()
            '----------------------------------------------------------------------------------
            '--------------------------------------- clear hema text box ------------------------
            TextBoxBF.Clear()
            TextBoxOthrhem.Clear()
            '----------------------------------------------------------------------------------
            '--------------------------------------- clear stol text box ------------------------
            TextBoxSAp.Clear()
            TextBoxSM.Clear()
            '----------------------------------------------------------------------------------
            '--------------------------------------- clear uri text box ------------------------
            TextBoxUdip.Clear()
            TextBoxUwbc.Clear()
            TextBoxUrbc.Clear()
            TextBoxUep.Clear()
            TextBoxUhcg.Clear()
            TextBoxUoth.Clear()
            txtpidlabadd.Focus()
            '----------------------------------------------------------------------------------
        End If
    End Sub
#End Region
    Private Sub btnClearrslt_Click(sender As Object, e As EventArgs) Handles btnClearrslt.Click
        '--------------------------------------- clear sero text box ------------------------
        txtpidlabadd.Clear()
        TextBoxPaBranch.Clear()
        TextBoxNAdd.Clear()
        TextBoxAgeAdd.Clear()
        TextBoxGenderAdd.Clear()
        TextBoxIDAdd.Clear()
        TextBoxDetforAdd.Clear()
        TextBoxyearforAdd.Clear()
        TextBoxSehd.Clear()
        TextBoxSeod.Clear()
        TextBoxSewf.Clear()
        TextBoxSept.Clear()
        TextBoxSeRem.Clear()
        '----------------------------------------------------------------------------------
        '--------------------------------------- clear hema text box ------------------------
        TextBoxBF.Clear()
        TextBoxOthrhem.Clear()
        '----------------------------------------------------------------------------------
        '--------------------------------------- clear stol text box ------------------------
        TextBoxSAp.Clear()
        TextBoxSM.Clear()
        '----------------------------------------------------------------------------------
        '--------------------------------------- clear uri text box ------------------------
        TextBoxUdip.Clear()
        TextBoxUwbc.Clear()
        TextBoxUrbc.Clear()
        TextBoxUep.Clear()
        TextBoxUhcg.Clear()
        TextBoxUoth.Clear()
        txtpidlabadd.Focus()
        '----------------------------------------------------------------------------------
    End Sub
    Private Sub AddLabResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterDataforlareq("")  'BY Misgana when modified
        '-----------------Fill Auto Complete for patientid ------------------------------
        Try
            'Dim cmdtel As
            Dim physd As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            ' Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim command1 As New SqlCommand("select ptbl.patientid from patienttbl ptbl INNER Join physiciantbl py On py.branch = ptbl.branch where py.physicianid = '" & physd & "'", conn)
            'Dim datel As 
            Dim daa As New SqlClient.SqlDataAdapter(command1)
            Dim dstel As DataSet = New DataSet
            daa.Fill(dstel, "patienttbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To dstel.Tables(0).Rows.Count - 1
                coltel.Add(dstel.Tables(0).Rows(i)(0).ToString)
            Next
            txtpidlabadd.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtpidlabadd.AutoCompleteCustomSource = coltel
            txtpidlabadd.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        End Try
        '------------------------------------------------------------------------------------------
    End Sub
#Region "View diagnosis of current date"
    Public Sub FilterDataforlareq(valueToSearch As String)
        Dim curentDate As DateTime = DateTime.Today
        'MsgBox("Current date is " & curentDate)
        Try
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQ As String = $"SELECT ptbl.patientid,ptbl.name,pd.diagnosisdate,pd.hematology, pd.stoolexam, pd.urinalysis, pd.serology,
pd.reportedby, pd.qualification from patientdiagnosistbl pd INNER JOIN patienttbl ptbl ON pd.patientid = ptbl.patientid 
WHERE pd.diagnosisdate = '{curentDate.ToShortDateString()}' and pd.status='senttolab' and ptbl.branch='" & br & "'"
            Dim ccl As New SqlCommand(SearchQ, cn)
            Dim ddl As New SqlDataAdapter(ccl)
            Dim ttl As New DataTable()
            ddl.Fill(ttl)
            DataGridViewforLabreq.DataSource = ttl
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "Search diagnosis randomly"
    Public Sub FilterDatarndmForLReq(valueToSearchrndm As String)
        Try
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim brnch As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuery As String = $"Select ptbl.patientid,ptbl.name,ptbl.branch,pd.diagnosisdate,pd.hematology,pd.stoolexam, pd.urinalysis,pd.serology,pd.reportedby, pd.qualification from patientdiagnosistbl pd INNER JOIN patienttbl ptbl On pd.patientid = ptbl.patientid WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) Like '%" & valueToSearchrndm & "%' and pd.status='senttolab' and ( pd.hematology!='' or pd.stoolexam!='' or pd.urinalysis!='' or pd.serology!='') and ptbl.branch ='" & brnch & "'"
            Dim cl As New SqlCommand(SearchQuery, cn)
            Dim dl As New SqlDataAdapter(cl)
            Dim tl As New DataTable()
            dl.Fill(tl)
            DataGridViewforLabreq.DataSource = tl
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
    Private Sub ToolStripBtnLabreq_Click(sender As Object, e As EventArgs) Handles ToolStripBtnLabreq.Click
        'If (ToolStriptxtBoxlabrequest.Text = " ") Then
        '    'Exit Sub
        '    MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        'Else
        FilterDatarndmForLReq(ToolStriptxtBoxlabrequest.Text)
        'End If
    End Sub

    Private Sub ToolStriptxtBoxlabrequest_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStriptxtBoxlabrequest.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripBtnLabreq_Click(sender, e)
        End If
    End Sub
    Private Sub DataGridViewforLabreq_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewforLabreq.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewforLabreq.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewforLabreq.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewforLabreq.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub
    Private Sub DataGridViewforLabreq_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforLabreq.CellFormatting
        DataGridViewforLabreq.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
#Region "Commented use for dictionary"
    'Private Sub TextBoxBF_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBF.LostFocus
    '    If TextBoxBF.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxBF.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxBF.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxOthrhem_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOthrhem.LostFocus
    '    If TextBoxOthrhem.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'myworddic.Show()
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxOthrhem.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxOthrhem.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxSAp_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSAp.LostFocus
    '    If TextBoxSAp.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxSAp.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxSAp.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxSM_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSM.LostFocus
    '    If TextBoxSM.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxSM.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxSM.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxUdip_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUdip.LostFocus
    '    If TextBoxUdip.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxUdip.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxUdip.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxUhcg_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUhcg.LostFocus
    '    If TextBoxUhcg.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxUhcg.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxUhcg.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub
    'Private Sub TextBoxUoth_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUoth.LostFocus
    '    If TextBoxUoth.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxUoth.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxUoth.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxSehd_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSehd.LostFocus
    '    If TextBoxSehd.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxSehd.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxSehd.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxSeod_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSeod.LostFocus
    '    If TextBoxSeod.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxSeod.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxSeod.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxSept_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSept.LostFocus
    '    If TextBoxSept.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxSept.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxSept.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub

    'Private Sub TextBoxSewf_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSewf.LostFocus
    '    If TextBoxSewf.Text.Length > 0 Then
    '        ''Dim mytxt As New RichTextBox
    '        ''mytxt.Text = IO.File.ReadAllText("C:\Users\Misgana\Documents\Visual Studio 2017\Projects\Schekr\Schekr\bin\Debug\Dictionary.txt")
    '        ''For Each line As String In mytxt.Lines
    '        ''    If TextBox1.Text = line Then
    '        ''    End If
    '        ''Next
    '        Dim myworddic As New Word.Application
    '        'Dim myworddic As New Word.Application
    '        myworddic.Visible = False
    '        Dim mydoc As Word.Document = myworddic.Documents.Add()
    '        Dim range As Word.Range
    '        range = mydoc.Range()
    '        range.Text = TextBoxSewf.Text
    '        mydoc.Activate()
    '        mydoc.CheckSpelling()
    '        Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
    '        TextBoxSewf.Text = mydoc.Range().Text.Trim(chars)
    '        mydoc.Close(SaveChanges:=False)
    '        myworddic.Quit()
    '    End If
    'End Sub
#End Region
End Class