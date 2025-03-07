Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class DiagnosisandPrescriptionEntry
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Dim hemtobf As String
    Dim hemtoother As String
    Dim stlexamapp As String
    Dim stlexammicro As String
    Dim uranlysisdip As String
    Dim uranlysismicro As String
    Dim serologywidal As String
    Dim serologywell As String
    Dim serologypreg As String
    Dim cmdrby As New SqlCommand()
    ' Dim dr As New SqlDataReader()
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProviderForPD.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Dim opd As String = Mainmenu.lblopd.Text.Trim() 'opdname.ToString()  opdname = '" & opd & "' 
        Dim brnch As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
        Dim searchCommand As New SqlCommand("select * from patienttbl where branch = '" & brnch & "' and patientid=@RegID", conn)
        searchCommand.Parameters.Add("@RegID", SqlDbType.VarChar).Value = TextBoxRegID.Text
        Dim adapter As New SqlDataAdapter(searchCommand)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            'TextBoxDID.Text = table(0)(0)
            TextBoxN.Text = table(0)(1)
            TextBoxGender.Text = table(0)(6)
            TextBoxAge.Text = table(0)(7)
            TextBoxRD.Text = table(0)(14)
            TextBoxPID.Text = table(0)(2)
            TextBoxPD.Text = table(0)(3)
            TextBoxPayear.Text = table(0)(4)
            TextBoxPbran.Text = table(0)(5)
            txtopdname.Text = table(0)(17)
        Else
            'TextBoxDID.Text = ""
            TextBoxRD.Text = ""
            TextBoxN.Text = ""
            TextBoxPD.Text = ""
            TextBoxPID.Text = ""
            TextBoxAge.Text = ""
            TextBoxPayear.Text = ""
            TextBoxGender.Text = ""
            txtopdname.Text = ""
            MsgBox("No data found", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBoxRegID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxRegID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6_Click(sender, e)
        End If
    End Sub

    Private Sub PrescriptionEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-------------------------------------for auto DID-----------------------------------------
        btnRefer.Enabled = False
        Dim GetCode As String = "0"
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = conn
        'command.CommandText = "SELECT TOP(1) * FROM patienttbl where branch='" & brnchd & "' ORDER BY patientid DESC"
        command.CommandText = "SELECT TOP(1) * FROM patientdiagnosistbl ORDER BY diagnosisid DESC"
        Try
            conn.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetString(reader.GetOrdinal("diagnosisid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        If (GetCode = "0") Then
            TextBoxDID.Text = "DIDH1"
        ElseIf (GetCode <> "0") Then
            'Button1.Enabled = False
            'Button1.Visible = False
            'Dim TotalCodeWithoutLable As String = GetCode.Count - 3
            'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
            'TextBoxDID.Text = "DID" + Format(OldNum + 1, "000000").ToString 'format number of diagnosis id
            If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
                Dim TotalCodeWithoutLableocl As String = GetCode.Count - 4
                Dim OldNumocl As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLableocl)
                TextBoxDID.Text = "DIDO" + Format(OldNumocl + 1).ToString 'format number of diagnosis id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
                Dim TotalCodeWithoutLablemcl As String = GetCode.Count - 4
                Dim OldNummcl As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablemcl)
                TextBoxDID.Text = "DIDM" + Format(OldNummcl + 1).ToString 'format number of diagnosis id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
                Dim TotalCodeWithoutLablehdl As String = GetCode.Count - 4
                Dim OldNumhdl As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablehdl)
                TextBoxDID.Text = "DIDH" + Format(OldNumhdl + 1).ToString 'format number of diagnosis id
            End If

            TextBoxPD.Clear()
            TextBoxOther.Clear()
            TextBoxDID.Focus()
        End If
        '------------------------------------------- for Med ------------------------------------------------------------
        Dim GetCodemed As String = "0"
        Dim commandmed As New SqlCommand()
        commandmed = New SqlCommand()
        command.Connection = conn
        command.CommandText = "SELECT TOP(1) * FROM prescriptiontbl ORDER BY drugid DESC"
        Try
            conn.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCodemed = (reader.GetString(reader.GetOrdinal("drugid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        If (GetCodemed = "0") Then
            TextBoxPdrugId.Text = "DRUGH1"
        ElseIf (GetCodemed <> "0") Then
            'Button1.Enabled = False
            'Button1.Visible = False 
            If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
                Dim TotalCodeWithoutLableo As String = GetCodemed.Count - 5
                Dim OldNumo As String = GetCodemed.Substring(GetCodemed.Length - TotalCodeWithoutLableo)
                TextBoxPdrugId.Text = "DRUGO" + Format(OldNumo + 1).ToString 'format number of medicine id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
                Dim TotalCodeWithoutLablem As String = GetCodemed.Count - 5
                Dim OldNumm As String = GetCodemed.Substring(GetCodemed.Length - TotalCodeWithoutLablem)
                TextBoxPdrugId.Text = "DRUGM" + Format(OldNumm + 1).ToString 'format number of medicine id
            ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
                Dim TotalCodeWithoutLableh As String = GetCodemed.Count - 5
                Dim OldNumh As String = GetCodemed.Substring(GetCodemed.Length - TotalCodeWithoutLableh)
                TextBoxPdrugId.Text = "DRUGH" + Format(OldNumh + 1).ToString 'format number of medicine id
            End If
            TextBoxPD.Clear()
            TextBoxOther.Clear()
            TextBoxDID.Focus()

        End If
        '-----------------Fill Auto Complete for patientid ------------------------------
        Try
            ' conn.Open()
            Dim physid As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim opd As String = Mainmenu.lblopd.Text.Trim() 'opdname.ToString() 
            'Dim branch As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
            Dim command1 As New SqlCommand("select ptbl.patientid from patienttbl ptbl INNER Join physiciantbl py On py.branch = ptbl.branch where py.physicianid = '" & physid & "'", conn)
            'select * from patienttbl where branch ='Odayea Campus'
            'select * from patienttbl where branch ='Main Campus'
            'Dim datel As 
            Dim daa As New SqlClient.SqlDataAdapter(command1)
            Dim dstel As DataSet = New DataSet
            daa.Fill(dstel, "patienttbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To dstel.Tables(0).Rows.Count - 1
                coltel.Add(dstel.Tables(0).Rows(i)(0).ToString)
            Next
            TextBoxRegID.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBoxRegID.AutoCompleteCustomSource = coltel
            TextBoxRegID.AutoCompleteMode = AutoCompleteMode.Suggest

            ToolStriptxtBoxPhistory.AutoCompleteSource = AutoCompleteSource.CustomSource
            ToolStriptxtBoxPhistory.AutoCompleteCustomSource = coltel
            ToolStriptxtBoxPhistory.AutoCompleteMode = AutoCompleteMode.Suggest

            ToolStripTextBoxprescri.AutoCompleteSource = AutoCompleteSource.CustomSource
            ToolStripTextBoxprescri.AutoCompleteCustomSource = coltel
            ToolStripTextBoxprescri.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        End Try
        '------------------------------------------------------------------------------------------
        '-----------------Fill Auto Complete for drug name ------------------------------
        Try
            'Dim cmdtel As
            Dim physd As String = Mainmenu.lblEID.Text.Trim() 'userName.ToString()
            'Dim command1 As New SqlCommand("select patientid from patienttbl", conn)
            Dim br As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim qn As Integer = 0
            Dim command1 As New SqlCommand("select items from pharmstoretbl where quantity <> '" & qn & "' and branch='" & br & "' and itemstatus='gained' order by stockid ASC", conn)
            'Dim datel As 
            Dim daa As New SqlClient.SqlDataAdapter(command1)
            Dim dstel As DataSet = New DataSet
            daa.Fill(dstel, "pharmstoretbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To dstel.Tables(0).Rows.Count - 1
                coltel.Add(dstel.Tables(0).Rows(i)(0).ToString)
            Next
            TextBoxPdrugName.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBoxPdrugName.AutoCompleteCustomSource = coltel
            TextBoxPdrugName.AutoCompleteMode = AutoCompleteMode.Suggest

            txtd2.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtd2.AutoCompleteCustomSource = coltel
            txtd2.AutoCompleteMode = AutoCompleteMode.Suggest

            txtd3.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtd3.AutoCompleteCustomSource = coltel
            txtd3.AutoCompleteMode = AutoCompleteMode.Suggest

            txtd4.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtd4.AutoCompleteCustomSource = coltel
            txtd4.AutoCompleteMode = AutoCompleteMode.Suggest

            txtd5.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtd5.AutoCompleteCustomSource = coltel
            txtd5.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration Error", MsgBoxStyle.Information)
        End Try
        '--------------------------------------------------------------------------
#Region "lbl reported by"
        ''-----------------lbl reported by ---------------------------------------------------------
        'Try
        '    connection.Open()
        '    Dim rby As String = Mainmenu.txtlblusername.Text.Trim()
        '    cmdrby = New SqlCommand("select * from physiciantbl WHERE physicianid = '" & rby & "'", connection)
        '    Dim dr = cmdrby.ExecuteReader()
        '    If (dr.HasRows) Then
        '        While (dr.Read())
        '            lblrby.Text = dr("name").ToString()
        '        End While
        '        dr.Close()
        '        connection.Close()
        '    End If
        'Catch ex As Exception
        '    MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
        'End Try
        ''------------------------------------------------------------------------------------------
#End Region
    End Sub
#Region "Add patient diagnosis"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAddPD.Click
        'diagnosis
        Try
            If vld(TextBoxRegID, TextBoxICD, txtboxvx, txtboxphyexamination, TextBoxOther, TextBoxRmrkforDiagnosis) = False Then
                'Exit Sub
                MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
                '-------------------------------set value for checkbox------------------------------------------------------------------------------
            Else
                If cheboxBF.Checked = True Then
                    hemtobf = "BF(Hemoparasite)"
                Else
                    hemtobf = " "
                End If
                If cheboxHemother.Checked = True Then
                    hemtoother = "Others"
                Else
                    hemtoother = " "
                End If
                If cheboxApp.Checked = True Then
                    stlexamapp = "Appearance"
                Else
                    stlexamapp = " "
                End If
                If cheboxMicrocopy.Checked = True Then
                    stlexammicro = "Microscopy"
                Else
                    stlexammicro = " "
                End If
                If cheboxDip.Checked = True Then
                    uranlysisdip = "Urine Dip StickTest"
                Else
                    uranlysisdip = " "
                End If
                If cheboxMicropic.Checked = True Then
                    uranlysismicro = "Microscopic"
                Else
                    uranlysismicro = " "
                End If
                If cheboxWidal.Checked = True Then
                    serologywidal = "Widal Test"
                Else
                    serologywidal = " "
                End If
                If cheboxWell.Checked = True Then
                    serologywell = "Well Felix(OX19)"
                Else
                    serologywell = " "
                End If
                If cheboxPreg.Checked = True Then
                    serologypreg = "Pregnancy Test"
                Else
                    serologypreg = " "
                End If
                '-------------------------------------------------------------------------------------------------------------
                '-----------------  diagnosis rby detail---------------------------------------------------------
                'Try
                'conn.Open()
                'Dim diagrby As String = Mainmenu.lblusername.Text 'userName.ToString()
                'Dim cmddiag As New SqlCommand("select * from physiciantbl WHERE name = '" & diagrby & "'", conn)
                'Dim rd As SqlDataReader = cmddiag.ExecuteReader()
                'If (rd.HasRows) Then
                '    While (rd.Read())
                'Mainmenu.txtlblusername.Text = dr("name").ToString()
                Dim drby = Mainmenu.lblusername.Text
                'Dim rbyqual = rd("qualification").ToString()
                Dim stus As String = "senttolab"
                Dim diageidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                Dim insertQuery As String = "insert into patientdiagnosistbl(diagnosisid, patientid, diagnosisdate, diagnosisoricd, hematology, stoolexam, urinalysis, serology, patienthistory, reportedby,remark, status, physicianid, vitalsign, physicalexamination) values('" & TextBoxDID.Text & "', '" & TextBoxRegID.Text & "', '" & DateTimePickerPDD.Value.ToShortDateString() & "','" & TextBoxICD.Text & "','" & hemtobf & "'+ ' ' +'" & hemtoother & "','" & stlexamapp & "'+ ' ' +'" & stlexammicro & "', '" & uranlysisdip & "'+ ' ' +'" & uranlysismicro & "','" & serologywidal & "'+ ' ' +'" & serologywell & "'+ ' ' +'" & serologypreg & "','" & TextBoxOther.Text & "','" & drby & "','" & TextBoxRmrkforDiagnosis.Text & "','" & stus & "','" & diageidby & "','" & txtboxvx.Text & "','" & txtboxphyexamination.Text & "')"
                InsertUpdateDelete(insertQuery)
                MessageBox.Show("Data successfully added !", "Data added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    End While
                '    rd.Close()
                '    conn.Close()
                'End If
                '     Catch ex As Exception
                '   MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
                'End Try
                '-------------------------------end  rby detail -----------------------------------------------------------
                '-------------------------------------for auto DID-----------------------------------------
                Dim GetCode As String = "0"
                Dim command As New SqlCommand()
                command = New SqlCommand()
                command.Connection = conn
                command.CommandText = "SELECT TOP(1) * FROM patientdiagnosistbl ORDER BY diagnosisid DESC"
                ' Try
                conn.Open()
                Dim reader As SqlDataReader
                reader = command.ExecuteReader(CommandBehavior.SingleRow)
                If (reader.HasRows = True) Then
                    While reader.Read()
                        GetCode = (reader.GetString(reader.GetOrdinal("diagnosisid")))
                    End While
                End If
                reader.Close()
                'Catch ex As System.Exception
                'MsgBox(ex.Message)
                '     Finally
                conn.Close()
                ' End Try
                If (GetCode = "0") Then
                    TextBoxDID.Text = "DIDH1"
                ElseIf (GetCode <> "0") Then
                    'Button1.Enabled = False
                    'Button1.Visible = False
                    'Dim TotalCodeWithoutLable As String = GetCode.Count - 3
                    'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
                    'TextBoxDID.Text = "DID" + Format(OldNum + 1, "000000").ToString 'format number of diagnosis id
                    If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
                        Dim TotalCodeWithoutLableoc As String = GetCode.Count - 4
                        Dim OldNumoc As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLableoc)
                        TextBoxDID.Text = "DIDO" + Format(OldNumoc + 1).ToString 'format number of diagnosis id
                    ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
                        Dim TotalCodeWithoutLablemc As String = GetCode.Count - 4
                        Dim OldNummc As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablemc)
                        TextBoxDID.Text = "DIDM" + Format(OldNummc + 1).ToString 'format number of diagnosis id
                    ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
                        Dim TotalCodeWithoutLablehd As String = GetCode.Count - 4
                        Dim OldNumhd As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLablehd)
                        TextBoxDID.Text = "DIDH" + Format(OldNumhd + 1).ToString 'format number of diagnosis id
                    End If
                    TextBoxPD.Clear()
                    TextBoxOther.Clear()
                    TextBoxDID.Focus()
                End If
            End If
            '------------------------------------------- en did auto ------------------------------------------------------------
            '-------------------------------------------------------------------------------------------------------------
            TextBoxRegID.Clear()
                TextBoxRD.Clear()
                TextBoxN.Clear()
                TextBoxGender.Clear()
                TextBoxAge.Clear()
                TextBoxPD.Clear()
                TextBoxPID.Clear()
                TextBoxPayear.Clear()
                TextBoxPbran.Clear()
                cheboxBF.Checked = False
                cheboxHemother.Checked = False
                cheboxApp.Checked = False
                cheboxMicrocopy.Checked = False
                cheboxMicropic.Checked = False
                cheboxDip.Checked = False
                cheboxWidal.Checked = False
                cheboxWell.Checked = False
                cheboxPreg.Checked = False
                TextBoxOther.Clear()
                TextBoxICD.Clear()
                TextBoxRmrkforDiagnosis.Clear()
                txtboxvx.Clear()
                txtboxphyexamination.Clear()
                TextBoxRegID.Focus()
                '-------------------------------------------------------------------------------------------------------------
        Catch ex As Exception
            MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            Me.Close()
        End Try
    End Sub
#End Region
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
#Region "Prescribe medicine"
    Private Sub btnAddPrescription_Click(sender As Object, e As EventArgs) Handles btnAddPrescription.Click
        'Prescribe
        If vld(TextBoxRegID, TextBoxPdrugName, TextBoxPfreq, txtqd1) = False Then
            'Exit Sub
            MsgBox("Please complete the form first", MsgBoxStyle.Critical)
            conn.Open()
            If vld(TextBoxPdrugName) = True Then
                Dim brnchs As String = Mainmenu.lblcampus.Text
                Dim cmdprs As New SqlCommand("select * from pharmstoretbl WHERE items = '" & TextBoxPdrugName.Text & "' and itemstatus='gained' and branch='" & brnchs & "'", conn)
                Dim rdval As SqlDataReader = cmdprs.ExecuteReader()
                If (rdval.HasRows) = False Then
                    'While (rdval.Read())
                    MsgBox("No such drug name(selected from textbox 1) exist  or enter quantity. Please try again!", MsgBoxStyle.Critical)
                    'End While 
                End If
                rdval.Close()
            End If
            If vld(txtd2) = True Then
                Dim brnchs1 As String = Mainmenu.lblcampus.Text
                Dim cmdprs As New SqlCommand("select * from pharmstoretbl WHERE items = '" & txtd2.Text & "' and itemstatus='gained' and branch='" & brnchs1 & "'", conn)
                Dim rdval As SqlDataReader = cmdprs.ExecuteReader()
                If (rdval.HasRows) = False Or CInt(txtqd2.Text) = 0 Then
                    'While (rdval.Read())
                    MsgBox("No such drug name (selected from textbox 2) exist or enter quantity. Please try again!", MsgBoxStyle.Critical)
                    'End While 
                End If
                rdval.Close()
            End If
            If vld(txtd3) = True Then
                Dim brnchs2 As String = Mainmenu.lblcampus.Text
                Dim cmdprs As New SqlCommand("select * from pharmstoretbl WHERE items = '" & txtd3.Text & "' and itemstatus='gained' and branch='" & brnchs2 & "'", conn)
                Dim rdval As SqlDataReader = cmdprs.ExecuteReader()
                If (rdval.HasRows) = False And CInt(txtqd3.Text) = 0 Then
                    'While (rdval.Read())
                    MsgBox("No such drug name (selected from textbox 3) exist or enter quantity. Please try again!", MsgBoxStyle.Critical)
                    'End While 
                End If
                rdval.Close()
            End If
            If vld(txtd4) = True Then
                Dim brnchs3 As String = Mainmenu.lblcampus.Text
                Dim cmdprs As New SqlCommand("select * from pharmstoretbl WHERE items = '" & txtd4.Text & "' and itemstatus='gained' and branch='" & brnchs3 & "'", conn)
                Dim rdval As SqlDataReader = cmdprs.ExecuteReader()
                If (rdval.HasRows) = False And CInt(txtqd4.Text) = 0 Then
                    'While (rdval.Read())
                    MsgBox("No such drug name (selected from textbox 4) exist or enter quantity. Please try again!", MsgBoxStyle.Critical)
                    'End While 
                End If
                rdval.Close()
            End If
            If vld(txtd5) = True Then
                Dim brnchs4 As String = Mainmenu.lblcampus.Text
                Dim cmdprs As New SqlCommand("select * from pharmstoretbl WHERE items = '" & txtd5.Text & "' and itemstatus='gained' and branch='" & brnchs4 & "'", conn)
                Dim rdval As SqlDataReader = cmdprs.ExecuteReader()
                If (rdval.HasRows) = False And CInt(txtqd5.Text) = 0 Then
                    'While (rdval.Read())
                    MsgBox("No such drug name (selected from textbox 5) exist or enter quantity. Please try again!", MsgBoxStyle.Critical)
                    'End While 
                End If
                rdval.Close()
            End If
            conn.Close()
            'Dim qq1 As Integer = CInt(txtqd1.Text)
        ElseIf vld(TextBoxPdrugName) = True And CInt(txtqd1.Text) <= 0 Then
            MsgBox("Quantity for selected drug one must greater than zero. please try again", MsgBoxStyle.Critical)
        ElseIf vld(txtd2) = True And CInt(txtqd2.Text) <= 0 Then
            MsgBox("Quantity for selected drug two must greater than zero. please try again", MsgBoxStyle.Critical)
        ElseIf vld(txtd3) = True And CInt(txtqd3.Text) <= 0 Then
            MsgBox("Quantity for selected drug three must greater than zero. please try again", MsgBoxStyle.Critical)
        ElseIf vld(txtd4) = True And CInt(txtqd4.Text) <= 0 Then
            MsgBox("Quantity for selected drug four must greater than zero. please try again", MsgBoxStyle.Critical)
        ElseIf vld(txtd5) = True And CInt(txtqd5.Text) <= 0 Then
            MsgBox("Quantity for selected drug five must greater than zero. please try again", MsgBoxStyle.Critical)
            '-----------------  dispenser detail---------------------------------------------------------
        Else
            Try
                conn.Open()
                Dim dispby As String = Mainmenu.lblusername.Text.Trim() 'userName.ToString()
                Dim cmdpres As New SqlCommand("select * from physiciantbl WHERE name = '" & dispby & "'", conn)
                Dim rd1 As SqlDataReader = cmdpres.ExecuteReader()
                If (rd1.HasRows) Then
                    While (rd1.Read())
                        'Mainmenu.txtlblusername.Text = dr("name").ToString()
                        Dim presdispensedby = rd1("name").ToString()
                        Dim despenserqualification = rd1("qualification").ToString()
                        '------------------------------------------------------------------------------------------
                        Dim disp As String = "prescribed"
                        Dim preseidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()  
                        Dim dosage As String = "-"
                        Dim duration As String = "-"
                        Dim streng As String = "-"
                        Dim streng2 As String = "-"
                        Dim streng3 As String = "-"
                        Dim streng4 As String = "-"
                        Dim streng5 As String = "-"
                        Dim quan As String = "-"
                        Dim price As String = "price amount"
                        Dim how As String = " how to use"
                        Dim rmark As String = "prescriber remark"
                        Dim insertQuy As String = "insert into prescriptiontbl(patientid,drugid,drugname,strength,frequency,dose,dosageform,duration,quantity,price,howtouse,otherinfo,prescribersname,prescriberqualification,prescriberremark,prescribeddate,giveoutstatus,prescribereid,drugtwo,strengthfordrugtwo,frequencyfordrugtwo,dosefordrugtwo,otherinformationfordrugtwo,drugthree,strengthfordrugthree,frequencyfordrugthree,dosefordrugthree,otherinformationfordrugthree,drugfour,strengthfordrugfour,frequencyfordrugfour,dosefordrugfour,otherinformationfordrugfour,drugfive,strengthfordrugfive,frequencyfordrugfive,dosefordrugfive,otherinformationfordrugfive,reqid,reqid2,reqid3,reqid4,reqid5) values('" & TextBoxRegID.Text & "','" & TextBoxPdrugId.Text & "','" & TextBoxPdrugName.Text & "','" & streng & "','" & TextBoxPfreq.Text & "','" & TextBoxPdose.Text & "','" & dosage & "','" & duration & "','" & quan & "','" & price & "','" & how & "','" & TextBoxPInfo.Text & "','" & presdispensedby & "','" & despenserqualification & "','" & rmark & "','" & DateTimePickerPPresdate.Value.ToShortDateString() & "','" & disp & "','" & preseidby & "','" & txtd2.Text & "', '" & streng2 & "', '" & txtf2.Text & "', '" & txtdos2.Text & "', '" & txtinfo2.Text & "', '" & txtd3.Text & "', '" & streng3 & "', '" & txtf3.Text & "','" & txtdos3.Text & "', '" & txtinfo3.Text & "', '" & txtd4.Text & "', '" & streng4 & "', '" & txtf4.Text & "', '" & txtdos4.Text & "', '" & txtinfo4.Text & "','" & txtd5.Text & "', '" & streng5 & "', '" & txtf5.Text & "', '" & txtdos5.Text & "', '" & txtinfo5.Text & "', '" & txtboxdr1.Text & "', '" & txtboxdr2.Text & "', '" & txtboxdr3.Text & "', '" & txtboxdr4.Text & "', '" & txtboxdr5.Text & "')"
                        InsertUpdateDelete(insertQuy)
                        If txtboxab1.Text <> 0 Then
                            Dim q1 As Integer = CInt(txtqd1.Text)
                            Dim updatequeryr1 As String = "update pharmstoretbl set availablebalance = availablebalance - " & q1 & " where reqid='" & txtboxdr1.Text & "'"
                            InsertUpdateDelete(updatequeryr1)
                        End If
                        'Dim b2 As Integer = CInt(txtboxab2.Text) 'for ineger conversion
                        If txtboxab2.Text <> 0 Then
                            Dim q2 As Integer = CInt(txtqd2.Text)
                            Dim updatequeryr2 As String = "update pharmstoretbl set availablebalance = availablebalance - " & q2 & " where reqid='" & txtboxdr2.Text & "'"
                            InsertUpdateDelete(updatequeryr2)
                        End If
                        If txtboxab3.Text <> 0 Then
                            Dim q3 As Integer = CInt(txtqd3.Text)
                            Dim updatequeryr3 As String = "update pharmstoretbl set availablebalance = availablebalance - " & q3 & " where reqid='" & txtboxdr3.Text & "'"
                            InsertUpdateDelete(updatequeryr3)
                        End If
                        If txtboxab4.Text <> 0 Then
                            Dim q4 As Integer = CInt(txtqd4.Text)
                            Dim updatequeryr4 As String = "update pharmstoretbl set availablebalance = availablebalance - " & q4 & " where reqid='" & txtboxdr4.Text & "'"
                            InsertUpdateDelete(updatequeryr4)
                        End If
                        If txtboxab5.Text <> 0 Then
                            Dim q5 As Integer = CInt(txtqd5.Text)
                            Dim updatequeryr5 As String = "update pharmstoretbl set availablebalance = availablebalance - " & q5 & " where reqid='" & txtboxdr5.Text & "'"
                            InsertUpdateDelete(updatequeryr5)
                        End If
                        MessageBox.Show("Data successfully added !", "Data added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End While
                    rd1.Close()
                    conn.Close()
                    'Me.Controls.Clear()
                    'InitializeComponent()
                    'PrescriptionEntry_Load(e, e)
                    'Refresh()
                End If
            Catch ex As Exception
                MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            End Try
        End If
        '-------------------------------end  dispenser detail -----------------------------------------------------------
        '--------------------------------------- for med----------------------------------------------------------------------
        Dim GetCodemed As String = "0"
            Dim command As New SqlCommand()
            command = New SqlCommand()
            command.Connection = conn
            command.CommandText = "SELECT TOP(1) * FROM prescriptiontbl ORDER BY drugid DESC"
            Try
                conn.Open()
                Dim reader1 As SqlDataReader
                reader1 = command.ExecuteReader(CommandBehavior.SingleRow)
                If (reader1.HasRows = True) Then
                    While reader1.Read()
                        GetCodemed = (reader1.GetString(reader1.GetOrdinal("drugid")))
                    End While
                End If
                reader1.Close()
            Catch ex As System.Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            If (GetCodemed = "0") Then
                TextBoxPdrugId.Text = "DRUGH1"
                'TextBoxDID.Text = "DID000001"
            ElseIf (GetCodemed <> "0") Then
                'Dim TotalCodeWithoutLable As String = GetCode.Count - 4
                'Dim OldNum As String = GetCode.Substring(GetCode.Length - TotalCodeWithoutLable)
                'TextBoxPdrugId.Text = "DRUG" + Format(OldNum + 1, "000000").ToString 'format number of medicine id

                If Mainmenu.lblcampus.Text.Trim() = "Odayea Campus" Then
                    Dim TotalCodeWithoutLableod As String = GetCodemed.Count - 5
                    Dim OldNumod As String = GetCodemed.Substring(GetCodemed.Length - TotalCodeWithoutLableod)
                    TextBoxPdrugId.Text = "DRUGO" + Format(OldNumod + 1).ToString 'format number of medicine id
                ElseIf Mainmenu.lblcampus.Text.Trim() = "Main Campus" Then
                    Dim TotalCodeWithoutLablem As String = GetCodemed.Count - 5
                    Dim OldNummd As String = GetCodemed.Substring(GetCodemed.Length - TotalCodeWithoutLablem)
                    TextBoxPdrugId.Text = "DRUGM" + Format(OldNummd + 1).ToString 'format number of medicine id
                ElseIf Mainmenu.lblcampus.Text.Trim() = "Hasedela Campus" Then
                    Dim TotalCodeWithoutLablehd As String = GetCodemed.Count - 5
                    Dim OldNumhd As String = GetCodemed.Substring(GetCodemed.Length - TotalCodeWithoutLablehd)
                    TextBoxPdrugId.Text = "DRUGH" + Format(OldNumhd + 1).ToString 'format number of medicine id
                End If
            TextBoxRegID.Clear()
            TextBoxRD.Clear()
            TextBoxN.Clear()
            TextBoxGender.Clear()
            TextBoxAge.Clear()
            TextBoxPD.Clear()
            TextBoxPayear.Clear()
            TextBoxPID.Clear()
            TextBoxPdrugName.Clear()
            TextBoxPInfo.Clear()
            TextBoxPdose.Clear()
            TextBoxPfreq.Clear()
            TextBoxICD.Clear()
            TextBoxPbran.Clear()
            txtd2.Clear()
            txtd3.Clear()
            txtd4.Clear()
            txtd5.Clear()
            txtboxab1.Text = 0
            txtboxab2.Text = 0
            txtboxab3.Text = 0
            txtboxab4.Text = 0
            txtboxab5.Text = 0
            txtqd1.Text = 0
            txtqd2.Text = 0
            txtqd3.Text = 0
            txtqd4.Text = 0
            txtqd5.Text = 0
            txtboxdr1.Clear()
            txtboxdr2.Clear()
            txtboxdr3.Clear()
            txtboxdr4.Clear()
            txtboxdr5.Clear()
            txtf2.Clear()
            txtf3.Clear()
            txtf4.Clear()
            txtf5.Clear()
            txtdos2.Clear()
            txtdos3.Clear()
            txtdos4.Clear()
            txtdos5.Clear()
            txtinfo2.Clear()
            txtinfo3.Clear()
            txtinfo4.Clear()
            txtinfo5.Clear()
            TextBoxRegID.Focus()
        End If
        '    TextBoxRegID.Clear()
        '    TextBoxRD.Clear()
        '    TextBoxN.Clear()
        '    TextBoxGender.Clear()
        '    TextBoxAge.Clear()
        '    TextBoxPD.Clear()
        '    TextBoxPayear.Clear()
        '    TextBoxPID.Clear()
        '    TextBoxPdrugName.Clear()
        '    TextBoxPInfo.Clear()
        '    TextBoxPdose.Clear()
        '    TextBoxPfreq.Clear()
        '    txtd2.Clear()
        '    txtd3.Clear()
        '    txtd4.Clear()
        'txtd5.Clear()
        'txtboxab1.Text = 0
        'txtboxab2.Text = 0
        'txtboxab3.Text = 0
        'txtboxab4.Text = 0
        'txtboxab5.Text = 0
        'txtboxdr1.Clear()
        '    txtboxdr2.Clear()
        '    txtboxdr3.Clear()
        '    txtboxdr4.Clear()
        '    txtboxdr5.Clear()
        '    txtf2.Clear()
        '    txtf3.Clear()
        '    txtf4.Clear()
        '    txtf5.Clear()
        '    txtdos2.Clear()
        '    txtdos3.Clear()
        '    txtdos4.Clear()
        '    txtdos5.Clear()
        '    txtinfo2.Clear()
        '    txtinfo3.Clear()
        '    txtinfo4.Clear()
        '    txtinfo5.Clear()
        '    TextBoxICD.Clear()
        '    TextBoxRegID.Focus()
        '-------------------------------------------------------------------------------------------------------------

        '' End If
    End Sub
#End Region
#Region "Clear or reset"
    Private Sub btnclrd_Click(sender As Object, e As EventArgs) Handles btnclrd.Click
        TextBoxRegID.Clear()
        TextBoxRD.Clear()
        TextBoxN.Clear()
        TextBoxGender.Clear()
        TextBoxAge.Clear()
        TextBoxPD.Clear()
        TextBoxPID.Clear()
        TextBoxPayear.Clear()
        cheboxBF.Checked = False
        cheboxHemother.Checked = False
        cheboxApp.Checked = False
        cheboxMicrocopy.Checked = False
        cheboxMicropic.Checked = False
        cheboxDip.Checked = False
        cheboxWidal.Checked = False
        cheboxWell.Checked = False
        cheboxPreg.Checked = False
        TextBoxOther.Clear()
        TextBoxICD.Clear()
        TextBoxRmrkforDiagnosis.Clear()
        txtboxvx.Clear()
        txtboxphyexamination.Clear()
        TextBoxRegID.Focus()
    End Sub
#End Region
#Region "Clear txtbox"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBoxRegID.Clear()
        TextBoxRD.Clear()
        TextBoxN.Clear()
        TextBoxGender.Clear()
        TextBoxAge.Clear()
        TextBoxPD.Clear()
        TextBoxPayear.Clear()
        TextBoxPID.Clear()
        TextBoxPbran.Clear()
        TextBoxPdrugName.Clear()
        TextBoxPInfo.Clear()
        TextBoxPdose.Clear()
        TextBoxPfreq.Clear()
        TextBoxICD.Clear()
        txtd2.Clear()
        txtd3.Clear()
        txtd4.Clear()
        txtd5.Clear()
        txtf2.Clear()
        txtf3.Clear()
        txtf4.Clear()
        txtf5.Clear()
        txtdos2.Clear()
        txtdos3.Clear()
        txtdos4.Clear()
        txtdos5.Clear()
        txtinfo2.Clear()
        txtinfo3.Clear()
        txtinfo4.Clear()
        txtinfo5.Clear()
        txtboxab1.Text = 0
        txtboxab2.Text = 0
        txtboxab3.Text = 0
        txtboxab4.Text = 0
        txtboxab5.Text = 0
        txtqd1.Text = 0
        txtqd2.Text = 0
        txtqd3.Text = 0
        txtqd4.Text = 0
        txtqd5.Text = 0
        txtboxdr1.Clear()
        txtboxdr2.Clear()
        txtboxdr3.Clear()
        txtboxdr4.Clear()
        txtboxdr5.Clear()
        TextBoxRegID.Focus()
    End Sub
#Region "Search Patient History"
    Public Sub FilterDatarndmForPhist(valueToSearchrndm As String)
        Try
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim brnchs As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuery As String = $"SELECT ptbl.patientid,ptbl.name,pd.diagnosisdate,pd.patienthistory,pd.diagnosisoricd,pd.vitalsign,pd.physicalexamination,pd.hematology, pd.stoolexam, pd.urinalysis, pd.serology, pd.remark, pd.reportedby, pd.qualification from patientdiagnosistbl pd INNER JOIN patienttbl ptbl ON pd.patientid = ptbl.patientid
WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueToSearchrndm & "%' and pd.status='completed' and ptbl.branch='" & brnchs & "'"
            Dim cl As New SqlCommand(SearchQuery, cn)
            Dim dl As New SqlDataAdapter(cl)
            Dim tl As New DataTable()
            dl.Fill(tl)
            DataGridViewforPrescriHistory.DataSource = tl
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
    Private Sub ToolStripBtnphistory_Click(sender As Object, e As EventArgs) Handles ToolStripBtnphistory.Click
        'If vld(ToolStriptxtBoxPhistory) = False Then
        '    'Exit Sub
        '    MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        'Else
        FilterDatarndmForPhist(ToolStriptxtBoxPhistory.Text)
        'End If
    End Sub

    Private Sub DataGridViewforPHistory_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewforPrescriHistory.CellPainting
        'If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < DataGridViewforPHistory.Rows.Count - 1 Then
        '    Dim indexstr As String = (e.RowIndex - 1).ToString
        '    Dim sz As SizeF = e.Graphics.MeasureString(indexstr, DataGridViewforPHistory.Font)
        '    Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    e.Graphics.DrawString(indexstr, DataGridViewforPHistory.Font, Brushes.Black, pt)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub DataGridViewforPHistory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewforPrescriHistory.CellFormatting
        DataGridViewforPrescriHistory.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub
#Region "Search Patient prescription/other History"
    Public Sub FilterDatarndmForPrescrihist(valueToSearchrndmpre As String)
        Try
            'Dim SearchQuery As String = "select * from patientdiagnosistbl where CONCAT(name,email,phone) like '%" & valueToSearch & "%'"
            Dim brnchs As String = Mainmenu.lblcampus.Text.Trim() 'userName.ToString()
            Dim SearchQuery As String = $"SELECT ptbl.patientid,ptbl.name,pr.prescribeddate,pr.drugname,pr.prescriberremark, pr.dispenserremark, pr.prescribersname,pr.prescriberqualification,pr.dispensername,pr.dispenserqualification from prescriptiontbl pr INNER JOIN patienttbl ptbl ON pr.patientid = ptbl.patientid
            WHERE CONCAT(ptbl.name,ptbl.phone,ptbl.patientid) like '%" & valueToSearchrndmpre & "%' and pr.giveoutstatus='dispensed'  and ptbl.branch='" & brnchs & "'"
            Dim cl As New SqlCommand(SearchQuery, cn)
            Dim dl As New SqlDataAdapter(cl)
            Dim tl As New DataTable()
            dl.Fill(tl)
            DataGridViewprevprescri.DataSource = tl
        Catch ex As Exception
            MsgBox("No Data Found", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
    Private Sub ToolStripbtnprescri_Click(sender As Object, e As EventArgs) Handles ToolStripbtnprescri.Click
        'If vld(ToolStripTextBoxprescri) = False Then
        '    'Exit Sub
        '    MsgBox("Please enter the keyword to search", MsgBoxStyle.Critical)
        'Else
        FilterDatarndmForPrescrihist(ToolStripTextBoxprescri.Text)
        'End If
    End Sub

    Private Sub DataGridViewprevprescri_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewprevprescri.CellFormatting
        DataGridViewprevprescri.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub ToolStriptxtBoxPhistory_KeyDown(sender As Object, e1 As KeyEventArgs) Handles ToolStriptxtBoxPhistory.KeyDown
        If e1.KeyCode = Keys.Enter Then
            ToolStripBtnphistory_Click(sender, e1)
        End If
    End Sub

    Private Sub ToolStripTextBoxprescri_KeyDown(sender As Object, e2 As KeyEventArgs) Handles ToolStripTextBoxprescri.KeyDown
        If e2.KeyCode = Keys.Enter Then
            ToolStripbtnprescri_Click(sender, e2)
        End If
    End Sub

    Private Sub TextBoxPdrugName_Click(sender As Object, e As EventArgs) Handles TextBoxPdrugName.Click
        If TextBoxPdrugName.Text <> "" Then
            TextBoxPdrugName.Enabled = False
            btnclear.Visible = False
        End If
    End Sub

    Private Sub txtd2_Click(sender As Object, e As EventArgs) Handles txtd2.Click
        If txtd2.Text <> "" Then
            txtd2.Enabled = False
            btnclear.Visible = False
        End If
    End Sub

    Private Sub txtd3_Click(sender As Object, e As EventArgs) Handles txtd3.Click
        If txtd3.Text <> "" Then
            txtd3.Enabled = False
            btnclear.Visible = False
        End If
    End Sub

    Private Sub txtd4_Click(sender As Object, e As EventArgs) Handles txtd4.Click
        If txtd4.Text <> "" Then
            txtd4.Enabled = False
            btnclear.Visible = False
        End If
    End Sub

    Private Sub txtd5_Click(sender As Object, e As EventArgs) Handles txtd5.Click
        If txtd5.Text <> "" Then
            txtd5.Enabled = False
            btnclear.Visible = False
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Controls.Clear()
        InitializeComponent()
        PrescriptionEntry_Load(e, e)
        Refresh()
    End Sub

    Private Sub btnsubmitdrug_Click(sender As Object, e As EventArgs) Handles btnsubmitdrug.Click
        Try
            Dim bra As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
            Dim searchCommand As New SqlCommand("Select reqid,items,availablebalance from pharmstoretbl where availablebalance <> 0 and branch ='" & bra & "' and itemstatus='gained' and items=@DrugName order by reqid ASC", conn)
            searchCommand.Parameters.Add("@DrugName", SqlDbType.VarChar).Value = TextBoxPdrugName.Text
            Dim adapter As New SqlDataAdapter(searchCommand)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                txtboxdr1.Text = table(0)(0)
                txtboxab1.Text = table(0)(2)
                If txtboxab1.Text = 0 Then
                    MsgBox("No available balance select other drug", MsgBoxStyle.Information)
                    TextBoxPdrugName.Text = ""
                    txtboxab1.Text = 0
                    txtboxdr1.Text = ""
                End If
            Else
                MsgBox("No data found try again", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim bra2 As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
            Dim searchCommand2 As New SqlCommand("Select items,reqid,availablebalance from pharmstoretbl where quantity <> 0 and branch ='" & bra2 & "' and itemstatus='gained' and items=@Drug2Name order by reqid ASC", conn)
            searchCommand2.Parameters.Add("@Drug2Name", SqlDbType.VarChar).Value = txtd2.Text
            Dim adapter2 As New SqlDataAdapter(searchCommand2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            If table2.Rows.Count > 0 Then
                txtboxdr2.Text = table2(0)(1)
                txtboxab2.Text = table2(0)(2)
                If txtboxab2.Text = 0 Or txtd2.Text = TextBoxPdrugName.Text Then
                    MsgBox("No available balance or already selected drug please select other drug item", MsgBoxStyle.Information)
                    txtd2.Text = ""
                    txtboxab2.Text = 0
                    txtboxdr2.Text = ""
                End If
            Else
                'MsgBox("No data found", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim bra3 As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
            Dim searchCommand3 As New SqlCommand("Select items,reqid,availablebalance from pharmstoretbl where quantity <> 0 and branch ='" & bra3 & "' and itemstatus='gained' and items=@Drug3Name order by reqid ASC", conn)
            searchCommand3.Parameters.Add("@Drug3Name", SqlDbType.VarChar).Value = txtd3.Text
            Dim adapter3 As New SqlDataAdapter(searchCommand3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            If table3.Rows.Count > 0 Then
                'TextBoxDID.Text = table(0)(0)
                txtboxdr3.Text = table3(0)(1)
                txtboxab3.Text = table3(0)(2)
                If txtboxab3.Text = 0 Or txtd3.Text = txtd2.Text Or txtd3.Text = TextBoxPdrugName.Text Then
                    MsgBox("No available balance or already selected drug please select other drug item", MsgBoxStyle.Information)
                    txtd3.Text = ""
                    txtboxab3.Text = 0
                    txtboxdr3.Text = ""
                End If
            Else
                'MsgBox("No data found", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim bra4 As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
            Dim searchCommand4 As New SqlCommand("Select items,reqid,availablebalance from pharmstoretbl where quantity <> 0 and branch ='" & bra4 & "' and itemstatus='gained' and items=@Drug4Name order by reqid ASC", conn)
            searchCommand4.Parameters.Add("@Drug4Name", SqlDbType.VarChar).Value = txtd4.Text
            Dim adapter4 As New SqlDataAdapter(searchCommand4)
            Dim table4 As New DataTable()
            adapter4.Fill(table4)
            If table4.Rows.Count > 0 Then
                'TextBoxDID.Text = table(0)(0)
                txtboxdr4.Text = table4(0)(1)
                txtboxab4.Text = table4(0)(2)
                If txtboxab4.Text = 0 Or txtd4.Text = txtd3.Text Or txtd4.Text = txtd2.Text Or txtd4.Text = TextBoxPdrugName.Text Then
                    MsgBox("No available balance or already selected drug please select other drug item", MsgBoxStyle.Information)
                    txtd4.Text = ""
                    txtboxab4.Text = 0
                    txtboxdr4.Text = ""
                End If
            Else
                'MsgBox("No data found", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim bra5 As String = Mainmenu.lblcampus.Text.Trim() 'branch.ToString() 
            Dim searchCommand5 As New SqlCommand("Select items,reqid,availablebalance from pharmstoretbl where quantity <> 0 and branch ='" & bra5 & "' and itemstatus='gained' and items=@Drug5Name order by reqid ASC", conn)
            searchCommand5.Parameters.Add("@Drug5Name", SqlDbType.VarChar).Value = txtd5.Text
            Dim adapter5 As New SqlDataAdapter(searchCommand5)
            Dim table5 As New DataTable()
            adapter5.Fill(table5)
            If table5.Rows.Count > 0 Then
                'TextBoxDID.Text = table(0)(0)
                txtboxdr5.Text = table5(0)(1)
                txtboxab5.Text = table5(0)(2)
                If txtboxab1.Text = 0 Or txtd5.Text = txtd3.Text Or txtd5.Text = txtd2.Text Or txtd5.Text = txtd4.Text Or txtd5.Text = TextBoxPdrugName.Text Then
                    MsgBox("No available balance or already selected drug please select other drug item", MsgBoxStyle.Information)
                    txtd5.Text = ""
                    txtboxab5.Text = 0
                    txtboxdr5.Text = ""
                End If
            Else
                'MsgBox("No data found", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxPdrugName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPdrugName.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmitdrug_Click(sender, e)
        End If
    End Sub

    Private Sub txtd2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtd2.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmitdrug_Click(sender, e)
        End If
    End Sub

    Private Sub txtd3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtd3.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmitdrug_Click(sender, e)
        End If
    End Sub

    Private Sub txtd4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtd4.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmitdrug_Click(sender, e)
        End If
    End Sub

    Private Sub txtd5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtd5.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmitdrug_Click(sender, e)
        End If
    End Sub

    Private Sub txtqd3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqd3.KeyPress, txtqd2.KeyPress, txtqd1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtqd5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqd5.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtqd4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqd4.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            'ToolTipForPval.Show("Only numeric input required", sender, 5000)
            MsgBox("Please enter number only !", MsgBoxStyle.Critical)
            e.KeyChar = Nothing
        End If
    End Sub

#End Region
#Region "Value for checkbox field"
    'Private Sub cheboxBF_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxBF.CheckedChanged
    '    hemtobf = "BF (Hemoparasite)"
    'End Sub

    'Private Sub cheboxHemother_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxHemother.CheckedChanged
    '    If (cheboxHemother.Checked) Then
    '        hemtoother = "Others"
    '    Else
    '        cheboxHemother.Checked = False
    '    End If
    'End Sub

    'Private Sub cheboxApp_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxApp.CheckedChanged
    '    If (cheboxApp.Checked) Then
    '        stlexamapp = "Appearance"
    '    Else
    '        cheboxApp.Checked = False
    '    End If
    'End Sub
    'Private Sub cheboxMicrocopy_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxMicrocopy.CheckedChanged
    '    If (cheboxMicrocopy.Checked) Then
    '        stlexammicro = "Microscopy"
    '    Else
    '        cheboxMicrocopy.Checked = False
    '    End If
    'End Sub

    'Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxDip.CheckedChanged
    '    If (cheboxDip.Checked) Then
    '        uranlysisdip = "Urine Dip StickTest"
    '    Else
    '        cheboxDip.Checked = False
    '    End If
    'End Sub

    'Private Sub cheboxMicropic_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxMicropic.CheckedChanged
    '    If (cheboxMicropic.Checked) Then
    '        uranlysismicro = "Microscopic"
    '    Else
    '        cheboxMicropic.Checked = False
    '    End If
    'End Sub

    'Private Sub cheboxWidal_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxWidal.CheckedChanged
    '    If (cheboxWidal.Checked) Then
    '        serologywidal = "Widal Test"
    '    Else
    '        cheboxWidal.Checked = False
    '    End If
    'End Sub

    'Private Sub cheboxWell_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxWell.CheckedChanged
    '    If (cheboxWell.Checked) Then
    '        serologywell = "Well Felix (OX19)"
    '    Else
    '        cheboxWell.Checked = False
    '    End If
    'End Sub

    'Private Sub cheboxPreg_CheckedChanged(sender As Object, e As EventArgs) Handles cheboxPreg.CheckedChanged
    '    If (cheboxPreg.Checked) Then
    '        serologypreg = "Pregnancy Test"
    '    Else
    '        cheboxPreg.Checked = False
    '    End If
    'End Sub
#End Region
End Class