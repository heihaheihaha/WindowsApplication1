Imports System.Data
Imports System.Data.SqlClient
Public Class Form4newbook
    Dim cn As SqlConnection
    Dim da As New SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("数据值不可以为空", , "入库")
            Exit Sub
        End If
        Dim strinput As String
        strinput = "insert into book(book_code,book_name,author,press,amount) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','"
        strinput = strinput & TextBox3.Text & "','" & TextBox4.Text & "'," & TextBox5.Text & ")"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strinput, cn)
        da.SelectCommand.ExecuteNonQuery()
        ' MsgBox(strinput)   ' 双击左侧断点查看，或用msgbox输出查看可能错误语句
        MsgBox("插入成功", , "入库")
    End Sub
End Class