Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class frmResetEmppassword
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    'declare global variable
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProviderRpass.SetError(ctl(i), ctl(i).Tag)
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
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(Strininput)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
#End Region
    Private Sub btnResetEpass_Click(sender As Object, e As EventArgs) Handles btnResetEpass.Click
        If vld(txtEmpID, MaskedTextBoxresetpasswrd) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
            'End If
            'If IsConfirm("Do you want to dispense ?") Then
        Else
            '-----------------  reset emppassword---------------------------------------------------------
            conn.Open()
            Dim cmder As SqlCommand = New SqlCommand("select physicianid from physiciantbl where physicianid=@epid", conn)
            cmder.Parameters.AddWithValue("@epid", txtEmpID.Text)
            Dim nowdate As DateTime = DateTime.Today
            Dim rdrr As SqlDataReader = cmder.ExecuteReader()
            If rdrr.HasRows Then
                Dim updateuery As String = "update physiciantbl set emppassword  = '" & Encrypt(MaskedTextBoxresetpasswrd.Text, "abc") & "', passwordlastchangeddate = '" & nowdate.ToShortDateString() & "' where physicianid ='" & txtEmpID.Text & "'"
                InsertUpdateDelete(updateuery)
                MessageBox.Show("Password reset done successfully !", "Data updated - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully updated!"
                txtEmpID.Clear()
                MaskedTextBoxresetpasswrd.Clear()
                txtEmpID.Focus()
            Else
                MsgBox("No such employee id exist please try again!", MsgBoxStyle.Critical)
            End If
            conn.Close()
        End If
    End Sub
    Private Sub txtEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub MaskedTextBoxresetpasswrd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBoxresetpasswrd.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmResetEmppassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmpID.ShortcutsEnabled = False
        txtEmpID.ContextMenu = New ContextMenu()
        MaskedTextBoxresetpasswrd.ShortcutsEnabled = False
        MaskedTextBoxresetpasswrd.ContextMenu = New ContextMenu()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtEmpID.Clear()
        MaskedTextBoxresetpasswrd.Clear()
    End Sub
End Class