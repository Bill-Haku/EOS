Public Class dh
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = RichTextBox1.Text + vbCrLf + "老头" + Str(Hour(Now)) + "时" + Str(Minute(Now)) + "分" + Str(Second(Now)) + "秒" + vbCrLf + TextBox1.Text
        TextBox1.Text = ""
    End Sub
End Class