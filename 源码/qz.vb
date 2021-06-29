Public Class qz
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox2.Text = RichTextBox2.Text + vbCrLf + "老头" + Str(Year(Now)) + "年" + Str(Month(Now)) + "月" + Str(DateAndTime.Day(Now)) + "日" + Str(Hour(Now)) + "时" + Str(Minute(Now)) + "分" + vbCrLf + RichTextBox1.Text
        RichTextBox1.Text = ""
    End Sub
End Class