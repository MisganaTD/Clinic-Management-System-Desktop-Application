Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(4)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            Mainmenu.Show()
            Timer1.Stop()
        End If
    End Sub
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class