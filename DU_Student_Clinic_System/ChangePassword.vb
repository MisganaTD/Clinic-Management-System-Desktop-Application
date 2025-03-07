Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class ChangePassword
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Dim cmd As New SqlCommand()
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProviderrpass.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnresetpass.Click
        If (MaskedTextBoxnpass.Text.Trim() = MaskedTextBoxcnpass.Text.Trim()) = False Then
            'Exit Sub
            MsgBox("Please try again your password must match ", MsgBoxStyle.Information)
            'End If
            'If IsConfirm("Do you want to dispense ?") Then
        Else
            '-----------------  emp detail---------------------------------------------------------
            Try
                conn.Open()
                Dim rd As SqlDataReader '= cmd.ExecuteReader(CommandBehavior.SingleRow)
                Dim empby As String = Mainmenu.lblusername.Text 'userName.ToString()
                Dim cmdemp As New SqlCommand("select * from physiciantbl WHERE name = '" & empby & "'", conn)
                rd = cmdemp.ExecuteReader()
                If (rd.HasRows) Then
                    While (rd.Read())
                        'Mainmenu.txtlblusername.Text = dr("name").ToString()
                        Dim empname = rd("name").ToString()
                        Dim empid = rd("physicianid").ToString()
                        ' Dim disp As String = "dispensed"
                        Dim updatequery As String = "update physiciantbl set emppassword = '" & Encrypt(MaskedTextBoxnpass.Text, "abc") & "' where physicianid ='" & empid & "'"
                        InsertUpdateDelete(updatequery)
                        MessageBox.Show("Successfully changed please login again", "Data updated - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'MessageBox.Show("Successfully updated!"
                        Login.Show()
                        Me.Close()
                        Mainmenu.Close()
                    End While
                    rd.Close()
                    conn.Close()
                End If
            Catch ex As Exception
                MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
            End Try
            '-------------------------------end  dispby detail -----------------------------------------------------------
            MaskedTextBoxnpass.Clear()
            MaskedTextBoxcnpass.Clear()
            MaskedTextBoxnpass.Focus()
            'Else
            ' MsgBox("Dispense Failed")
        End If
    End Sub

    Private Sub MaskedTextBoxnpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBoxnpass.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub MaskedTextBoxcnpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBoxcnpass.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaskedTextBoxnpass.ShortcutsEnabled = False
        MaskedTextBoxnpass.ContextMenu = New ContextMenu()
        MaskedTextBoxcnpass.ShortcutsEnabled = False
        MaskedTextBoxcnpass.ContextMenu = New ContextMenu()
    End Sub
End Class