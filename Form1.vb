Public Class Factoria76

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        System.Diagnostics.Process.Start("http://protocolo.factoria76.com")
        Application.Exit()
    End Sub
End Class
