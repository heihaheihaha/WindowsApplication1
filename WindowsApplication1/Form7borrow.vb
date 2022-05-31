Imports System.Data
Imports System.Data.SqlClient
Public Class Form7borrow
    Dim strsql As String
    Dim strCard As String
    Dim strBookCode As String



    Dim cn As SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim rst As Integer


    Private Sub btn_borrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrow.Click
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()

        ' 借书证号验证
        strCard = txt_borrow_reader.Text
        strsql = "select * from reader where card_id='" & strCard & "'"
        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()

        da.Fill(ds, "seltable")
        If (ds.Tables.Item(0).Rows.Count < 1) Then
            MsgBox("当前借书证号查无此人！")
            Return
        End If

        '图书条码号验证
        strBookCode = txt_borrow_bookid.Text
        strsql = "select * from BookIDTable where bid=" & strBookCode

        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()

        da.Fill(ds, "seltable")
        If (ds.Tables.Item(0).Rows.Count < 1) Then
            MsgBox("当前条码号非法，请重新输入图书条码号！")
            Return
        End If

        '添加当前借阅的信息
        strsql = "insert into borrowReturnTable(readerid,bookid,borrowDate) values('" & strCard & "'," & strBookCode & ",'" & Date.Now.ToString() & "')"
        da.SelectCommand = New SqlCommand(strsql, cn)
        rst = da.SelectCommand.ExecuteNonQuery()
        If (rst > 0) Then
            MsgBox("图书借阅成功")
        Else
            MsgBox("借阅过程出现错误") '改成错误按钮提示框

        End If

        strsql = "select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code order by borrowid desc"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()
        da.Fill(ds, "seltable")
        dgv_BWInfo.DataSource = ds.Tables.Item(0)

    End Sub

    Private Sub btn_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_return.Click
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()


        '图书条码号验证
        strBookCode = txt_return_bookid.Text
        strsql = "select * from BookIDTable where bid=" & strBookCode

        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()


        '归还图书
        strsql = "update borrowReturnTable set returnDate='" & Date.Now.ToString() & "' where bookid=" & strBookCode
        da.SelectCommand = New SqlCommand(strsql, cn)
        rst = da.SelectCommand.ExecuteNonQuery()
        If (rst > 0) Then
            MsgBox("图书归还成功")
        Else
            MsgBox("归还过程出现错误") '改成错误按钮提示框

        End If

        strsql = "select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code order by borrowid desc"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()
        da.Fill(ds, "seltable")
        dgv_BWInfo.DataSource = ds.Tables.Item(0)

    End Sub
End Class