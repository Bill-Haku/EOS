Public Class dlqq
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        qs.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ListBox1.SelectedIndex = -1 And ListBox2.SelectedIndex = -1 Then
            MsgBox("请选择好友或群聊",, "提示")
        ElseIf ListBox1.SelectedIndex > -1 And ListBox2.SelectedIndex = -1 Then
            dh.Text = ListBox1.SelectedItem
            dh.Show()
            dh.RichTextBox1.Text = ""
        ElseIf ListBox1.SelectedIndex = -1 And ListBox2.SelectedIndex > -1 Then
            dh.Text = ListBox2.SelectedItem
            dh.Show()
            dh.RichTextBox1.Text = ""
        End If
    End Sub
End Class