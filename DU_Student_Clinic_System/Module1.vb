Imports System.Data.SqlClient
Module Module1
#Region "Conn for DESKTOP-QKNE475"
    Public cn As New SqlConnection("Server = DESKTOP-QKNE475; Database = DUSCS; Integrated Security = true")
#End Region 
#End Region
    Public Sub Connect()
        If cn.State = ConnectionState.Closed Then cn.Open()
        'If con.State = ConnectionState.Closed Then con.Open()
        'Cursor.Current=Cursors.Default
    End Sub
    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Connect()
        Dim cmd As New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery() > 0
    End Function
    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function
    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim das As New SqlDataAdapter(sql, cn)
        Dim dss As New DataSet
        das.Fill(dss, "result")
        Return dss.Tables("result")
    End Function
End Module