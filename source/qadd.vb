Public Class qadd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = True
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dlqq.ListBox1.Items.Add("飞火F")
        Button2.Text = "您已添加"
        Button2.Enabled = False
    End Sub
End Class