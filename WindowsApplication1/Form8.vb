Imports System.Data
Imports System.Data.SqlClient

Public Class Form8
    Dim qname As String
    Dim strsql As String
    Dim strCard As String
    Dim strBookCode As String



    Dim cn As SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim rst As Integer
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        strsql = "select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code order by borrowid desc"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()
        da.Fill(ds, "seltable")
        dgv_BWInfo.DataSource = ds.Tables.Item(0)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "读者证号" Then
            qname = "r.card_id"
        ElseIf ComboBox1.Text = "姓名" Then
            qname = "r.reader"
        ElseIf ComboBox1.Text = "书名" Then
            qname = "b.book_name"
        End If
    End Sub

    '查询
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "读者证" Then
            qname = "r.card_id"
        ElseIf ComboBox1.Text = "姓名" Then
            qname = "r.reader"
        ElseIf ComboBox1.Text = "书名" Then
            qname = "b.book_name"
        End If
        'select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code and ='8102200905'  order by borrowid desc
        strsql = "select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code and " & qname & "='" & Trim(TextBox1.Text) & "'  order by borrowid desc"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()
        da.Fill(ds, "seltable")
        dgv_BWInfo.DataSource = ds.Tables.Item(0)
    End Sub

    '刷新
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        strsql = "select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code order by borrowid desc"
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()
        da.SelectCommand = New SqlCommand(strsql, cn)
        ds.Reset()
        da.Fill(ds, "seltable")
        dgv_BWInfo.DataSource = ds.Tables.Item(0)

    End Sub
End Class