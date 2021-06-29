<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class d
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 35)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "请使用键盘输入电话号码"
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Black
        Me.Button19.Location = New System.Drawing.Point(567, 7)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(48, 48)
        Me.Button19.TabIndex = 23
        Me.Button19.Text = "X"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(12, 336)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(600, 93)
        Me.Button13.TabIndex = 22
        Me.Button13.Text = "拨打"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(15, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(600, 71)
        Me.TextBox1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 35)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "快捷拨号"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 50)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "老伴 14400000000"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Button2.Location = New System.Drawing.Point(319, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(293, 50)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "老八 15400000000"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Button3.Location = New System.Drawing.Point(12, 229)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(293, 50)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "李华 16400000000"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Button4.Location = New System.Drawing.Point(319, 229)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(293, 50)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "张三 12400000000"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "d"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "拨号和联系人"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents TextBox1 As TextBox

    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Hide()
        sta.Show()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        MsgBox("您的计算机不支持拨打电话", 16, "提示")
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("您的计算机不支持拨打电话", 16, "提示")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("您的计算机不支持拨打电话", 16, "提示")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("您的计算机不支持拨打电话", 16, "提示")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("您的计算机不支持拨打电话", 16, "提示")
    End Sub
End Class
