Public Class net
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        sta.Show()
        CreateObject("Wscript.Shell").Run("msedge.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        sta.Show()
    End Sub
End Class