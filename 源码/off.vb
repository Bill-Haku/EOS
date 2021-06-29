Public Class off
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TrackBar1.Value = 100 Then
            CreateObject("Wscript.Shell").Run("shutdown.exe -s -t 1")
            TrackBar1.Value = 0
            End
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        main.Show()
    End Sub
End Class