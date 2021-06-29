Public Class main
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Str(Hour(Now)) + "时" + Str(Minute(Now)) + "分"
        If TrackBar1.Value = 100 Then
            Hide()
            sta.Show()
            TrackBar1.Value = 0
        End If
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Str(Hour(Now)) + "时" + Str(Minute(Now)) + "分"
        Label2.Text = Str(Year(Now)) + "年" + Str(Month(Now)) + "月" + Str(DateAndTime.Day(Now)) + "日"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Hide()
        sta.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        off.Show()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        emcl.Show()
    End Sub
End Class