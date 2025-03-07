Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class Login
    Dim canClose As Boolean = False
    Dim GlobalUserID As String
    Dim GlobalUserRole As String
    Dim canReset As Boolean = False
    Dim cmdwellcome As New SqlCommand()
    Private currentDate As DateTime = DateTime.Today
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
    Private Sub Form8_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If canClose = False And canReset = False Then
            Mainmenu.Close()
        ElseIf canClose = True Then
            Mainmenu.Show()
            CreateAcc.PlayLoginSound()
        ElseIf canReset Then
            CreateAcc.Show()
        End If
    End Sub
    Private Sub Form8_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Mainmenu.Hide()
    End Sub
    Private Sub btnLogn_Click(sender As Object, e As EventArgs) Handles btnLogn.Click
        '----------------------------- for login ---------------------------------------
        ' Dim sqlinjec As String = "'--'"
        ' If vld(txtboxUserName) = False Then
        'MsgBox("Error occur", MsgBoxStyle.Critical, "System Error")
        ' txtboxUserName.Clear()

        'Else
        Dim userName As String = txtboxUserName.Text.Trim()
        Dim userpassWord As String = MaskedtxtboxPassword.Text.Trim()
        Dim command As New SqlCommand($"Select * FROM physiciantbl WHERE physicianid = '" & userName & "' AND emppassword = '" & Encrypt(userpassWord, "abc") & "' AND status = 1", cn)
        command.Parameters.AddWithValue("physicianid", userName)
        command.Parameters.AddWithValue("emppassword", userpassWord)
        command.Connection = cn
        Try
            cn.Open()
            Dim rd As SqlDataReader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (rd.HasRows = True) Then
                While (rd.Read())
                    GlobalUserID = rd.GetName(rd.GetOrdinal("physicianid"))
                    'GlobalUserID = rd.GetInt32(rd.GetOrdinal("userid"))
                    GlobalUserRole = rd.GetString(rd.GetOrdinal("emprole"))
                End While
                Me.Hide()
                'Role List: Physician, Reception(Card Room), Pharmacist,Laboratorist,System Admin
                If GlobalUserRole = "System Admin" Then
                    'Form1.ButtonPe.Visible = True
                    Mainmenu.PhysicianToolStripMenuItem.Visible = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    Mainmenu.ReportsToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    Mainmenu.ProceedRequestedStockToolStripMenuItem.Visible = False
                    'Mainmenu.AdministratorToolStripMenuItem.Enabled = False
                    Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                    Mainmenu.RequestedStockbyPharmasistToolStripMenuItem.Visible = False
                    Mainmenu.DispenseryByPharmasistToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Physician" Then
                    'Form1.ButtonPe.Visible = True
                    'Mainmenu.PhysicianToolStripMenuItem.Enabled = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    'Mainmenu.ReportsToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                    Mainmenu.LabReportToolStripMenuItem.Visible = False
                    'Mainmenu.PatientReportsToolStripMenuItem.Enabled = False
                    Mainmenu.ReportPharmToolStripMenuItem.Visible = False
                    Mainmenu.LabReportByDateToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StockToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryToolStripMenuItem.Visible = False
                    Mainmenu.ConsumedStockToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.ProceedRequestedStockToolStripMenuItem.Visible = False
                    Mainmenu.RequestedStockbyPharmasistToolStripMenuItem.Visible = False
                    Mainmenu.DispenseryByPharmasistToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Reception (Card Room)" Then
                    'Form1.ButtonPe.Visible = True
                    Mainmenu.PhysicianToolStripMenuItem.Visible = False
                    'Mainmenu.PatientInformationToolStripMenuItem.Enabled = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    Mainmenu.ReportsToolStripMenuItem.Visible = False
                    Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StockToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryToolStripMenuItem.Visible = False
                    Mainmenu.ConsumedStockToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                    Mainmenu.RequestedStockbyPharmasistToolStripMenuItem.Visible = False
                    Mainmenu.DispenseryByPharmasistToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Pharmacist" Then
                    'Form1.ButtonPe.Visible = True
                    Mainmenu.PhysicianToolStripMenuItem.Visible = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                    Mainmenu.LabReportToolStripMenuItem.Visible = False
                    Mainmenu.PatientReportsToolStripMenuItem.Visible = False
                    'Mainmenu.ReportPharmToolStripMenuItem.Enabled = False
                    Mainmenu.LabReportByDateToolStripMenuItem.Visible = False
                    Mainmenu.StockToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryToolStripMenuItem.Visible = False
                    'Mainmenu.ConsumedStockToolStripMenuItem.Visible = False
                    'Mainmenu.PharmacistToolStripMenuItem.Enabled = False
                    'Mainmenu.ReportsToolStripMenuItem.Visible = False
                    Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Laboratorist" Then
                    'Form1.ButtonPe.Visible = True
                    Mainmenu.PhysicianToolStripMenuItem.Visible = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    'Mainmenu.LabratoryToolStripMenuItem.Enabled = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    'Mainmenu.ReportsToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                    'Mainmenu.LabReportToolStripMenuItem.Enabled = False
                    Mainmenu.PatientReportsToolStripMenuItem.Visible = False
                    Mainmenu.ReportPharmToolStripMenuItem.Visible = False
                    'Mainmenu.LabReportByDateToolStripMenuItem.Enabled = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StockToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryToolStripMenuItem.Visible = False
                    Mainmenu.ConsumedStockToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.RequestedStockbyPharmasistToolStripMenuItem.Visible = False
                    Mainmenu.DispenseryByPharmasistToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Managing Physician For DUSCS" Then
                    'Form1.ButtonPe.Visible = True
                    'Mainmenu.PhysicianToolStripMenuItem.Enabled = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    'Mainmenu.AddEmployeeToolStripMenuItem.Visible = False
                    Mainmenu.ManageEmployeeToolStripMenuItem.Visible = False
                    'Mainmenu.StockToolStripMenuItem.Visible = False 
                    Mainmenu.ExpiryToolStripMenuItem.Visible = False
                    'Mainmenu.ConsumedStockToolStripMenuItem.Visible = False
                    'Mainmenu.ResetEmployeePasswordToolStripMenuItem.Visible = False
                    'Mainmenu.OtherToolStripMenuItem.Visible = False
                    'Mainmenu.EditEmployeeToolStripMenuItem.Visible = False
                    'Mainmenu.ProceedRequestedStockToolStripMenuItem.Visible=False
                    'Mainmenu.ReportsToolStripMenuItem.Enabled = False
                    'Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    'Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Store Manager" Then
                    'Form1.ButtonPe.Visible = True
                    Mainmenu.PhysicianToolStripMenuItem.Visible = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    Mainmenu.LabReportByDateToolStripMenuItem.Visible = False
                    Mainmenu.LabReportToolStripMenuItem.Visible = False
                    Mainmenu.PatientReportsToolStripMenuItem.Visible = False
                    Mainmenu.ReportPharmToolStripMenuItem.Visible = False
                    'Mainmenu.ReportsToolStripMenuItem.Visible=False
                    Mainmenu.AddEmployeeToolStripMenuItem.Visible = False
                    Mainmenu.ManageEmployeeToolStripMenuItem.Visible = False
                    Mainmenu.OtherToolStripMenuItem.Visible = False
                    Mainmenu.StServTeamLeaderToolStripMenuItem.Visible = False
                    Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.ConsumedStockToolStripMenuItem.Visible = False
                    Mainmenu.RequestedStockbyPharmasistToolStripMenuItem.Visible = False
                    Mainmenu.DispenseryByPharmasistToolStripMenuItem.Visible = False
                ElseIf GlobalUserRole = "Student Service Team Leader" Then
                    Mainmenu.PhysicianToolStripMenuItem.Visible = False
                    Mainmenu.PatientInformationToolStripMenuItem.Visible = False
                    Mainmenu.LabratoryToolStripMenuItem.Visible = False
                    Mainmenu.PharmacistToolStripMenuItem.Visible = False
                    Mainmenu.ReportsToolStripMenuItem.Visible = False
                    Mainmenu.LabReportByDateToolStripMenuItem.Visible = False
                    Mainmenu.LabReportToolStripMenuItem.Visible = False
                    Mainmenu.ExpiryAlertToolStripMenuItem.Visible = False
                    'Mainmenu.StServTeamLeaderToolStripMenuItem.Visible=False 
                    'Mainmenu.ApprovalToolStripMenuItem.Visible=False
                    Mainmenu.PatientReportsToolStripMenuItem.Visible = False
                    Mainmenu.ReportPharmToolStripMenuItem.Visible = False
                    Mainmenu.AdministratorToolStripMenuItem.Visible = False
                    Mainmenu.StoreToolStripMenuItem.Visible = False
                    Mainmenu.RequestedStockbyPharmasistToolStripMenuItem.Visible = False
                    Mainmenu.DispenseryByPharmasistToolStripMenuItem.Visible = False
                End If
                Loading.ShowDialog(Mainmenu)
                rd.Close()
                '-----------------Welcome user---------------------------------------------------------
                Try
                    'cn.Open()
                    'Dim userName As String = txtboxUserName.Text.Trim()
                    Dim wellcome As String = userName.ToString()
                    'Dim rdm As SqlDataReader ' = command.ExecuteReader(CommandBehavior.SingleRow)
                    cmdwellcome = New SqlCommand("select * from physiciantbl WHERE physicianid = '" & wellcome & "'", cn)
                    rd = cmdwellcome.ExecuteReader()
                    If (rd.HasRows) Then
                        While (rd.Read())
                            Mainmenu.lblusername.Text = rd("name").ToString() ' + " " + "wellcome to DU SCS"
                            Mainmenu.lblEID.Text = rd("physicianid").ToString()
                            ' Mainmenu.lblopd.Text = rd("opdname").ToString()
                            Mainmenu.lblcampus.Text = rd("branch").ToString()
                        End While
                        rd.Close()
                        cn.Close()
                    End If
                Catch ex As Exception
                    MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
                End Try
                '------------------------------------------------------------------------------------------
                'Mainmenu.txtlblusername.Text = userName.ToString
                'Form1.ShowDialog()
                txtboxUserName.Clear()
                MaskedtxtboxPassword.Clear()
                txtboxUserName.Focus()
            Else
                MsgBox("Incorrect username or password", MsgBoxStyle.Critical, "Try again")
            End If
            'reader.Close()
        Catch ex As System.Exception
            MsgBox("Error: " & ex.Message & "." & vbCrLf & "Please contact your System Administrator.", MsgBoxStyle.Critical, "System Error") 'For debug only
        Finally
            cn.Close()
        End Try
        '--------------------------------------------------------------------------------------------------------
    End Sub
#Region "Custom Subroutine"
    'This is another source code for login
    'Dim userName As String = TextBox1.Text.Trim()
    'Dim userPassword As String = MaskedTextBox1.Text.Trim()
    'Dim cmd As New SqlCommand("SELECT username, userpassword FROM usertbl WHERE username = @userName AND userpassword = @userPassword", connection)
    'cmd.Parameters.AddWithValue("username", userName)
    'cmd.Parameters.AddWithValue("userpassword", userPassword)
    'Dim adapter As New SqlDataAdapter(cmd)
    'Dim table As New DataTable()
    'adapter.Fill(table)
    'If table.Rows.Count = 0 Then
    '    MsgBox("Incorrect username or password or you are not yet register. Please try again !", MsgBoxStyle.Critical, "Error")
    '    TextBox1.Clear()
    '    MaskedTextBox1.Clear()
    '    TextBox1.Focus()
    'Else
    '    Form1.Show()
    '    Me.Hide()
    'End If
#End Region
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtboxUserName.Clear()
        MaskedtxtboxPassword.Clear()
        txtboxUserName.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If MaskedtxtboxPassword.UseSystemPasswordChar = True Then
            'show password
            MaskedtxtboxPassword.UseSystemPasswordChar = False
        Else
            'hide password
            MaskedtxtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub MaskedTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedtxtboxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogn_Click(sender, e)
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxUserName.ShortcutsEnabled = False
        txtboxUserName.ContextMenu = New ContextMenu()
        MaskedtxtboxPassword.ShortcutsEnabled = False
        MaskedtxtboxPassword.ContextMenu = New ContextMenu()
    End Sub
    Private Function mytime(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function
    Private Sub txtboxUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxUserName.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub MaskedtxtboxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedtxtboxPassword.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class