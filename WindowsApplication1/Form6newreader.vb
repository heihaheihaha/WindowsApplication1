Imports System.Data
Imports System.Data.SqlClient
Public Class Form6newreader
    Dim cn As SqlConnection
    Dim da As New SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("数据值不可以为空", , "注册")
            Exit Sub
        End If
        Dim strinput As String
        strinput = "INSERT INTO READER(READER, CARD_ID, READER_TELE) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strinput, cn)
        da.SelectCommand.ExecuteNonQuery()
        MsgBox(strinput)   ' 双击左侧断点查看，或用msgbox输出查看可能错误语句
        MsgBox("注册成功", , "注册")
    End Sub
    
End Class