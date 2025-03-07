Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Imports System.Text.RegularExpressions
Public Class AddPatient
    'declare global variable
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProviderPntF.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(Mainmenu.Left + 25, Mainmenu.Top + 45)
        '--------------------------------------------------------------------------
        'Dim GetCode As String = "0"
        'Dim command As New SqlCommand()
        'command = New SqlCommand()
        'command.Connection = conn
        'Dim brnch As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        ''SELECT TOP(1) * FROM patienttbl where branch='Odayea Campus' ORDER BY patientid DESC ptbl.branch='" & brnchs & "'
        'command.CommandText = "SELECT TOP(1) * FROM patienttbl where branch='" & brnch & "' ORDER BY patientid DESC"
        'Try
        '    conn.Open()
        '    Dim reader As SqlDataReader
        '    reader = command.ExecuteReader(CommandBehavior.SingleRow)
        '    If (reader.HasRows = True) Then
        '        While reader.Read()
        '            GetCode = (reader.GetString(reader.GetOrdinal("patientid")))
        '        End While
        '    End If
        '    reader.Close()
        'Catch ex As System.Exception
        '    MsgBox(ex.Message)
        'Finally
        '    conn.Close()
        'End Try
        'If (GetCode = "0") Then
        '    TextBoxPID.Text = "PIDH1"
        'ElseIf (GetCode <> "0") Then
        '    'Dim TotalCodeWithoutLable As String = GetCode.Count - 3
        '    'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
        '    'TextBoxPID.Text = "PID" + Format(OldNum + 1).ToString 'format number of student id

        '    ' Dim brncho As String = Mainmenu.lblcampus.Text.Trim()
        '    If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
        '        Dim TotalCodeWithoutLableo As String = GetCode.Count - 4
        '        Dim OldNumo As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLableo)
        '        TextBoxPID.Text = "PIDO" + Format(OldNumo + 1).ToString 'format number of student id
        '    ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
        '        Dim TotalCodeWithoutLablem As String = GetCode.Count - 4
        '        Dim OldNumm As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablem)
        '        TextBoxPID.Text = "PIDM" + Format(OldNumm + 1).ToString 'format number of student id
        '    ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
        '        Dim TotalCodeWithoutLablehd As String = GetCode.Count - 4
        '        Dim OldNumhd As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablehd)
        '        TextBoxPID.Text = "PIDH" + Format(OldNumhd + 1).ToString 'format number of student id
        '    End If
        ' End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'when hit enter key
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            'AddPatient()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxPID.Clear()
        TextBoxPFN.Clear()
        TextBoxPMN.Clear()
        TextBoxPLN.Clear()
        TextBoxPaID.Clear()
        TextBoxPTel.Clear()
        ComboBoxPG.Text = ""
        TextBoxAge.Clear()
        ComboBoxMStatus.Text = ""
        ComboBoxBgroup.Text = ""
        ComboBoxPYear.Text = ""
        ComboBoxPDept.Text = ""
        'DateTimePickerPBD.ResetText()
        TextBoxPCo.Clear()
        TextBoxPCi.Clear()
        TextBoxPEA.Clear()
        TextBoxPFN.Focus()
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        '    If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        PictureBoxPPic.SizeMode = PictureBoxSizeMode.Zoom
        '        PictureBoxPPic.Load(OpenFileDialog1.FileName)
        '    End If
        'End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vld(TextBoxPID, TextBoxPFN, TextBoxPMN, TextBoxPaID, TextBoxPLN, ComboBoxPG, TextBoxAge, ComboBoxPYear, ComboBoxPDept, cmbboxopdna) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            conn.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select patientid from patienttbl where patientid=@pid", conn)
            cmdep.Parameters.AddWithValue("@pid", TextBoxPID.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                MsgBox("Patient ID already exist please try again!", MsgBoxStyle.Critical)
            Else
                'conn.Open()
                Dim pby As String = Mainmenu.lblusername.Text 'userName.ToString()
                Dim regeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                Dim addpbranch As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
                Dim insertQery As String = "insert into patienttbl(patientid, name, idnumber, department,year,branch,gender,age,maritalstatus, bloodgroup,country, city, email, phone,registrationdate,patientregisteredby,regbyeid,opdname) values('" & TextBoxPID.Text & "','" & TextBoxPFN.Text & "'+ ' ' +'" & TextBoxPMN.Text & "'+ ' '+ '" & TextBoxPLN.Text & "','" & TextBoxPaID.Text & "','" & ComboBoxPDept.Text & "','" & ComboBoxPYear.Text & "','" & addpbranch & "','" & ComboBoxPG.Text & "','" & TextBoxAge.Text & "','" & ComboBoxMStatus.Text & "','" & ComboBoxBgroup.Text & "','" & TextBoxPCo.Text & "','" & TextBoxPCi.Text & "','" & TextBoxPEA.Text & "', '" & TextBoxPTel.Text & "','" & DateTimePickerRD.Value.ToShortDateString() & "', '" & pby & "', '" & regeidby & "','" & cmbboxopdna.Text & "')"
                InsertUpdateDelete(insertQery)
                MessageBox.Show("Data successfully added", "Data Added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxPID.Clear()
                TextBoxPFN.Clear()
                TextBoxPMN.Clear()
                TextBoxPLN.Clear()
                TextBoxPaID.Clear()
                TextBoxPTel.Clear()
                ComboBoxPG.Text = ""
                TextBoxAge.Clear()
                ComboBoxMStatus.Text = ""
                ComboBoxBgroup.Text = ""
                ComboBoxPYear.Text = ""
                ComboBoxPDept.Text = ""
                'DateTimePickerPBD.ResetText()
                TextBoxPCo.Clear()
                TextBoxPCi.Clear()
                TextBoxPEA.Clear()
                TextBoxPID.Focus()
            End If
        End If
        conn.Close()
        '--------------------------------------------------------------------------
        Dim GetCode As String = "0"
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = conn
        Dim brnch As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
        'SELECT TOP(1) * FROM patienttbl where branch='Odayea Campus' ORDER BY patientid DESC ptbl.branch='" & brnchs & "'
        command.CommandText = "SELECT TOP(1) * FROM patienttbl where branch='" & brnch & "' ORDER BY patientid DESC"
        Try
            conn.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetString(reader.GetOrdinal("patientid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        'If (GetCode = "0") Then
        '    TextBoxPID.Text = "PIDH1"
        'ElseIf (GetCode <> "0") Then
        '    'Dim TotalCodeWithoutLable As String = GetCode.Count - 3
        '    'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
        '    'TextBoxPID.Text = "PID" + Format(OldNum + 1).ToString 'format number of student id

        '    ' Dim brncho As String = Mainmenu.lblcampus.Text.Trim()
        '    If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
        '        Dim TotalCodeWithoutLableo As String = GetCode.Count - 4
        '        Dim OldNumo As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLableo)
        '        TextBoxPID.Text = "PIDO" + Format(OldNumo + 1).ToString 'format number of student id
        '    ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
        '        Dim TotalCodeWithoutLablem As String = GetCode.Count - 4
        '        Dim OldNumm As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablem)
        '        TextBoxPID.Text = "PIDM" + Format(OldNumm + 1).ToString 'format number of student id
        '    ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
        '        Dim TotalCodeWithoutLablehd As String = GetCode.Count - 4
        '        Dim OldNumhd As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablehd)
        '        TextBoxPID.Text = "PIDH" + Format(OldNumhd + 1).ToString 'format number of student id
        '    End If
        '    TextBoxPFN.Clear()
        '    TextBoxPMN.Clear()
        '    TextBoxPLN.Clear()
        '    TextBoxPTel.Clear()
        '    ComboBoxPYear.Text = ""
        '    ComboBoxPDept.Text = ""
        '    ComboBoxPG.Text = ""
        '    TextBoxAge.Clear()
        '    ComboBoxMStatus.Text = ""
        '    'DateTimePickerPBD.ResetText()
        '    TextBoxPCo.Clear()
        '    TextBoxPCi.Clear()
        '    TextBoxPEA.Clear()
        '    TextBoxPFN.Focus()
        'End If
    End Sub
    'Public Sub ExcuteQuery(query As String)
    '    'These is for cmd to be excuted and database connection
    '    Dim command As New SqlCommand(query, connection)
    '    connection.Open()
    '    command.ExecuteNonQuery()
    '    connection.Close()
    'End Sub
    Private Sub TextBoxPCN_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPTel.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            ToolTipForPval.Show("Only numeric input required", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPFN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPFN.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPMN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPMN.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPLN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPLN.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPCo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPCo.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPCi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPCi.KeyPress
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPA_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxPPC_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            ToolTipForPval.Show("Only numeric input required", sender, 5000)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxReligion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not e.Handled = Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("Please enter character only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBoxAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxAge.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub
#Region "VIEW patient detail to duscs patienttbl from SIMS SYS"
    'Private Sub btnViewpatientdetailfromsimsto_Click(sender As Object, e As EventArgs) Handles btnViewpatientdetailfromsimsto.Click
    '    Dim brnch As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
    '    Dim searchCommand As New SqlCommand("select * from simsstudentdetailtbl where branch = '" & brnch & "' and studid=@RegID", connofsims)
    '    searchCommand.Parameters.Add("@RegID", SqlDbType.VarChar).Value = txtboxstudid.Text
    '    Dim adapter As New SqlDataAdapter(searchCommand)
    '    Dim table As New DataTable()
    '    adapter.Fill(table)
    '    If table.Rows.Count > 0 Then
    '        TextBoxPFN.Text = table(0)(1) 'fname
    '        TextBoxPMN.Text = table(0)(6) 'mname
    '        TextBoxPLN.Text = table(0)(14) 'lname
    '        TextBoxPaID.Text = table(0)(2) 'stud id
    '        TextBoxPTel.Text = table(0)(4) 'phone
    '        ComboBoxPG.Text = table(0)(5) 'gender
    '        TextBoxAge.Text = table(0)(17) 'age
    '        ComboBoxMStatus.Text = table(0)(17) 'marital status
    '        ComboBoxBgroup.Text = table(0)(17) 'blood group
    '        ComboBoxPYear.Text = table(0)(17) 'year
    '        ComboBoxPDept.Text = table(0)(17) 'dept
    '        'DateTimePickerPBD.ResetText() '
    '        TextBoxPCo.Text = table(0)(17) 'country
    '        TextBoxPCi.Text = table(0)(17) 'city
    '        TextBoxPEA.Text = table(0)(17) 'email
    '    Else
    '        TextBoxPFN.Text = ""
    '        TextBoxPMN.Text = ""
    '        TextBoxPLN.Text = ""
    '        TextBoxPaID.Text = ""
    '        TextBoxPTel.Text = ""
    '        ComboBoxPG.Text = ""
    '        TextBoxAge.Text = ""
    '        ComboBoxMStatus.Text = ""
    '        ComboBoxBgroup.Text = ""
    '        ComboBoxPYear.Text = ""
    '        ComboBoxPDept.Text = ""
    '        'DateTimePickerPBD.ResetText()
    '        TextBoxPCo.Text = ""
    '        TextBoxPCi.Text = ""
    '        TextBoxPEA.Text = ""
    '        TextBoxPFN.Focus()
    '        MsgBox("No data found", MsgBoxStyle.Information)
    '    End If
    'End Sub
#End Region
End Class