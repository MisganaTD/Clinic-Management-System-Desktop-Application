Imports System.Data.SqlClient

Public Class CreateAcc
    Dim connection As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
    Dim canClose As Boolean = False
#Region "Custome Subroutine"

    Public Sub PlayLoginSound()
        Dim pathSound As String = "C:\Windows\media\Windows Notify Calendar.wav"
        If My.Computer.FileSystem.FileExists(pathSound) Then
            My.Computer.Audio.Play(pathSound, AudioPlayMode.Background)
        End If
    End Sub
#End Region

    Private Sub Form7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'If canClose = False Then
        '    Mainmenu.Close()
        'Else
        '    Mainmenu.Show()
        '    PlayLoginSound()

        'End If
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'Dim insertQuery As String = "insert into usertbl()"
    '    If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(MaskedTextBox1.Text) Or String.IsNullOrWhiteSpace(MaskedTextBox2.Text) Then
    '        MessageBox.Show("Make sure that all data have been entered", "Create account - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    Else
    '        If MaskedTextBox1.Text <> MaskedTextBox2.Text Then
    '            MessageBox.Show("The password you entered don't match", "Create account - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else
    '            Dim sWriter As New System.IO.StreamWriter(Mainmenu.pathAccount & "username.text")
    '            sWriter.Write(TextBox1.Text)
    '            sWriter.Close()
    '            sWriter = New System.IO.StreamWriter(Mainmenu.pathAccount & "password.text")
    '            sWriter.Write(MaskedTextBox1.Text)
    '            sWriter.Close()
    '            canClose = True
    '            Close()
    '        End If
    '    End If
    'End Sub
    'Public Sub ExcuteQuery(query As String)
    '    Dim command As New SqlCommand(query, connection)
    '    connection.Open()
    '    command.ExecuteNonQuery()
    '    connection.Close()


    'End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        TextBox1.Focus()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class