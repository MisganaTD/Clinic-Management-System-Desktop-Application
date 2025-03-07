Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelautoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class Employee
    'Declare global variable
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
     'Dim em As String 'validate email 
    'Dim cmd As SqlCommand
    Dim GlobalUserRole As String
    Dim GlobalUserID As String
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
#Region "Function for encrypt and decrept password"
    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Function Encrypt(ByVal Strininput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(Strininput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
#End Region
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
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridViewAllEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        FilterDta("")
        Location = New Point(Mainmenu.Left + 25, Mainmenu.Top + 45)
        '----------------------------------------------------------------------------------------
        Dim GetCode As String = "0"
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = conn
        'command.CommandText = "SELECT TOP(1) * FROM physiciantbl ORDER BY physicianid DESC"
        Dim brnches As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        command.CommandText = "SELECT TOP(1) * FROM physiciantbl where branch='" & brnches & "' ORDER BY physicianid DESC"
        Try
            conn.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetString(reader.GetOrdinal("physicianid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        If (GetCode = "0") Then
            TextBoxEMid.Text = "EIDH1"
        ElseIf (GetCode <> "0") Then
            'Button1.Enabled = False
            'Button1.Visible = False
            'Dim TotalCodeWithoutLable As String = GetCode.Count - 3
            'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
            'TextBoxEMid.Text = "EID" + Format(OldNum + 1, "000000").ToString 'format number of student id
            If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
                Dim TotalCodeWithoutLablel As String = GetCode.Count - 4
                Dim OldNuml As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablel)
                TextBoxEMid.Text = "EIDO" + Format(OldNuml + 1).ToString 'format number of student id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
                Dim TotalCodeWithoutLablem As String = GetCode.Count - 4
                Dim OldNumm As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablem)
                TextBoxEMid.Text = "EIDM" + Format(OldNumm + 1).ToString 'format number of student id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
                Dim TotalCodeWithoutLableh As String = GetCode.Count - 4
                Dim OldNumh As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLableh)
                TextBoxEMid.Text = "EIDH" + Format(OldNumh + 1).ToString 'format number of student id
            End If

            TextBoxEFN.Clear()
            TextBoxEMN.Clear()
            TextBoxELN.Clear()
            TextBoxEE.Clear()
            TextBoxEA.Clear()
            TextBoxEP.Clear()
            ComboBoxpref.Text = ""
            ComboBoxDept.Text = ""
            ComboBoxEG.Text = ""
            ComboBoxET.Text = ""
            cmbboxRole.Text = ""
            TextBoxEFN.Focus()
        End If
        '-------------------------------------------------------------------------------------------------------------
    End Sub
#Region "ADD EMPLOYEE DETAIL"
    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        'AddDoctor()
        If vld(TextBoxEMid, ComboBoxpref, TextBoxEFN, TextBoxEMN, cmbboxbranch, TextBoxELN, TextBoxEE, TextBoxEA, TextBoxEP, ComboBoxDept, ComboBoxEG, ComboBoxET, cmbboxRole) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            ''Try
            conn.Open()
            Dim cmde As SqlCommand = New SqlCommand("select * from physiciantbl where physicianid=@empid", conn)
            cmde.Parameters.AddWithValue("@empid", TextBoxEMid.Text)
            Dim rdr As SqlDataReader = cmde.ExecuteReader()
            If rdr.HasRows Then
                MsgBox("Employee id already exist please try again!", MsgBoxStyle.Critical)
            Else
                Dim eby As String = Mainmenu.lblusername.Text 'userName.ToString()
                Dim regeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                Dim emppass As String = "scs123"
                Dim st As Integer = 1
                Dim todaydate As DateTime = DateTime.Today
                'Dim addbranchemp As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
                Dim insertQuey As String = $"insert into physiciantbl(physicianid,name,email, address, phonenumber,department,branch, gender,qualification, emprole,emppassword,registereddate,employeeregisteredby,status,regbyeid,opdname) values('" & TextBoxEMid.Text & "','" & ComboBoxpref.Text & "'+ ' ' +'" & TextBoxEFN.Text & "'+ ' ' +'" & TextBoxEMN.Text & "'+ ' '+ '" & TextBoxELN.Text & "','" & TextBoxEE.Text & "','" & TextBoxEA.Text & "','" & TextBoxEP.Text & "','" & ComboBoxDept.Text & "','" & cmbboxbranch.Text & "','" & ComboBoxEG.Text & "','" & ComboBoxET.Text & "','" & cmbboxRole.Text & "','" & Encrypt(emppass, "abc") & "','" & todaydate & "','" & eby & "','" & st & "','" & regeidby & "','" & cmbboxopdname.Text & "')"
                InsertUpdateDelete(insertQuey)
                'Dim insertQuery As String = "insert into phsiciantbl(physicianid,name,email,address,phonenumber,department,gender,employeetype) values('" & TextBox1.Text & "','" & TextBoxEFN.Text & "'+ ' ' +'" & TextBoxEMN.Text & "'+ ' '+ '" & TextBoxELN.Text & "', '" & TextBoxEE.Text & "','" & TextBoxEA.Text & "', '" & TextBoxEP.Text & "','" & ComboBoxDept.Text & "', '" & ComboBoxEG.Text & "', '" & ComboBoxET.Text & "')"
                MessageBox.Show("Data successfully added !", "Data added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxEFN.Clear()
                TextBoxEMN.Clear()
                TextBoxELN.Clear()
                TextBoxEE.Clear()
                TextBoxEA.Clear()
                TextBoxEP.Clear()
                ComboBoxDept.Text = ""
                ComboBoxEG.Text = ""
                ComboBoxET.Text = ""
                cmbboxRole.Text = ""
                ComboBoxpref.Text = ""
                TextBoxEMid.Focus()
                '----------------------------------
            End If
        End If
        conn.Close()
        Dim GetCode As String = "0"
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = conn
        Dim brnche As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        command.CommandText = "SELECT TOP(1) * FROM physiciantbl where branch='" & brnche & "' ORDER BY physicianid DESC"
        Try
            conn.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetString(reader.GetOrdinal("physicianid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        If (GetCode = "0") Then
            TextBoxEMid.Text = "EIDH1"
        ElseIf (GetCode <> "0") Then
            'Dim TotalCodeWithoutLable As String = GetCode.Count - 3
            'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
            'TextBoxEMid.Text = "EID" + Format(OldNum + 1, "000000").ToString 'format number of student id
            If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
                Dim TotalCodeWithoutLablelor As String = GetCode.Count - 4
                Dim OldNumlor As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablelor)
                TextBoxEMid.Text = "EIDO" + Format(OldNumlor + 1).ToString 'format number of student id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
                Dim TotalCodeWithoutLablemc As String = GetCode.Count - 4
                Dim OldNummc As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablemc)
                TextBoxEMid.Text = "EIDM" + Format(OldNummc + 1).ToString 'format number of student id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
                Dim TotalCodeWithoutLablehd As String = GetCode.Count - 4
                Dim OldNumhd As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablehd)
                TextBoxEMid.Text = "EIDH" + Format(OldNumhd + 1).ToString 'format number of student id
            End If
            'TextBoxEFN.Clear()
            'TextBoxEMN.Clear()
            'TextBoxELN.Clear()
            'TextBoxEE.Clear()
            'TextBoxEA.Clear()
            'TextBoxEP.Clear()
            'ComboBoxDept.Text = ""
            'ComboBoxEG.Text = ""
            'ComboBoxET.Text = ""
            'cmbboxRole.Text = ""
            'ComboBoxpref.Text = ""
            'cmbboxEcampus.Text = ""
            TextBoxEMid.Focus()
            'End If

            '-------------------------------------------------------------------------------------------------------------
        End If
    End Sub
    'Public Sub ExcuteQuery(query As String)
    '    Try
    '        'For db connection and excution
    '        Dim command As New SqlCommand(query, connection)
    '        connection.Open()
    '        command.ExecuteNonQuery()
    '        connection.Close()
    '    Catch ex As Exception
    '        MsgBox("Please contact your Database Administrator", MsgBoxStyle.Information)
    '    End Try
    'End Sub
    Private Sub TextBoxDD_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxEFN.Clear()
        TextBoxEMN.Clear()
        TextBoxELN.Clear()
        TextBoxEE.Clear()
        TextBoxEA.Clear()
        TextBoxEP.Clear()
        ComboBoxDept.Text = ""
        cmbboxRole.Text = ""
        ComboBoxEG.Text = ""
        ComboBoxET.Text = ""
        TextBoxEFN.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Private Sub TextBoxEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            tipForValidation.Show("Only numeric input required", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub TextBoxEFN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEFN.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxEMN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEMN.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxELN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxELN.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxEA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxEA.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    'Try email check
    ' Validate email
    '    em = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
    '    If Regex.IsMatch(TextBoxEA.Text, em) Then
    '        MsgBox("Valid email format", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Is - Validate")
    '    Else
    '        MsgBox("Invalid email format", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Not - Validate")
    '    End If
    'End Sub
    Private Sub TextBoxSalary_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            tipForValidation.Show("Only numeric input required", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub
#End Region
#Region "VIEW AND EDIT EMPLOYEE DETAIL"
    Private Sub ToolStripBtnEmpSearch_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEmpSearch.Click
        FilterDta(txttobesearch.Text)
    End Sub
    Public Sub FilterDta(valToSearch As String)
        Try
            Dim ebran As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQery As String = "select physicianid,name,gender,emprole,opdname,branch,phonenumber,email,address,department,qualification,registereddate from physiciantbl where CONCAT(name,email,phonenumber,physicianid,branch) like '%" & valToSearch & "%' 
and emprole !='System Admin' and branch='" & ebran & "'"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            'DataGridViewAllEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DataGridViewAllEmployee.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub txttobesearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txttobesearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripBtnEmpSearch_Click(sender, e)
        End If
    End Sub
    Private Sub DataGridViewAllEmployee_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewAllEmployee.CellFormatting
        DataGridViewAllEmployee.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
    Private Sub btnexportelist_Click(sender As Object, e As EventArgs) Handles btnexportelist.Click
        Try
            btnexportelist.Text = "Please wait..."
            btnexportelist.Enabled = False
            SaveFileDialogeexportelist.Filter = "Excel Docoment (*.xlsx)|*.xlsx"
            If SaveFileDialogeexportelist.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")

                For x = 0 To DataGridViewAllEmployee.RowCount - 2
                    For y = 0 To DataGridViewAllEmployee.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewAllEmployee.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewAllEmployee.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewAllEmployee(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogeexportelist.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjectmed(xlapp)
                releaseObjectmed(xlworkbook)
                releaseObjectmed(xlworksheet)
                MsgBox("Successfully saved" & vbCrLf & "File saved at:" & SaveFileDialogeexportelist.FileName, MsgBoxStyle.Information, "Information")
                btnexportelist.Text = "Export to Excel"
                btnexportelist.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save", "Error Message - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObjectmed(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
#End Region
End Class