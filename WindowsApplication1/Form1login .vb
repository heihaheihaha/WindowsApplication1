Public Class 登录

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "1101" And TextBox2.Text = "123456" Or TextBox1.Text = "1102" And TextBox2.Text = "234567" Then
            MsgBox("登录成功", , "登录")
            Form2main.Show()
            Me.Finalize()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("用户名或者密码不正确", , "登录")
        End If
    End Sub

    Private Sub 登录_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1start.ShowDialog()
    End Sub

End Class
