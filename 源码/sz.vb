Public Class sz


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        sta.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CreateObject("Wscript.Shell").Run("explorer.exe")
        GroupBox1.Visible = False
        LinkLabel1.Visible = True
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\1.themepack")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\2.themepack")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\3.themepack")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\4.themepack")
    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        CreateObject("Wscript.Shell").Run("magnify.exe")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        CreateObject("Wscript.Shell").Run("narrator.exe")
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateObject("Wscript.Shell").Run("taskkill.exe /F /IM explorer.exe")
        LinkLabel1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CreateObject("Wscript.Shell").Run("tabtip.exe")
    End Sub
End Class