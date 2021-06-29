Public Class m
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        sta.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = 0 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\hyl.wav")
        ElseIf ListBox1.SelectedIndex = 1 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\爱的供养.mp3")
        ElseIf ListBox1.SelectedIndex = 2 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\不是因为寂寞才想你.mp3")
        ElseIf ListBox1.SelectedIndex = 3 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\该死的温柔.mp3")
        ElseIf ListBox1.SelectedIndex = 4 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\老鼠爱大米.mp3")
        ElseIf ListBox1.SelectedIndex = 5 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\没有你的日子我真的好孤单.mp3")
        ElseIf ListBox1.SelectedIndex = 6 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\秋天不回来.mp3")
        ElseIf ListBox1.SelectedIndex = 7 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\天使的翅膀.mp3")
        ElseIf ListBox1.SelectedIndex = 8 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\无情的温柔.mp3")
        ElseIf ListBox1.SelectedIndex = 9 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\因为爱情.mp3")
        ElseIf ListBox1.SelectedIndex = 10 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\隐形的翅膀.mp3")
        ElseIf ListBox1.SelectedIndex = 11 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\有一种爱叫做放手.mp3")
        ElseIf ListBox1.SelectedIndex = 12 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\月亮之上.mp3")
        ElseIf ListBox1.SelectedIndex = 13 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\自由飞翔.mp3")
        ElseIf ListBox1.SelectedIndex = 14 Then
            CreateObject("Wscript.Shell").Run(Application.StartupPath & "\res\快乐崇拜.mp3")
        ElseIf ListBox1.SelectedIndex = -1 Then
            MsgBox("请选择音乐", 48, "提示")
        ElseIf ListBox1.SelectedIndex = 15 Then
            CreateObject("Wscript.Shell").Run("https://music.163.com")
        End If
    End Sub
End Class