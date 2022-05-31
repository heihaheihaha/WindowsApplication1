Imports System.Data
Imports System.Data.SqlClient

Public Class Form2summary
    Dim cn As SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim strsel As String
    Private Sub label2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click


    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=.;Initial Catalog=BOOK;Integrated Security=True")
        cn.Open()

        strsel = "select count(*) '借阅数' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code and month(borrowDate)=" & Now.Month - 1 & " and year(borrowdate)=" & Now.Year


        da.SelectCommand = New SqlCommand(strsel, cn)
        ds = New DataSet()
        da.Fill(ds, "seltable")
        ' MsgBox("lskdjf")
        Label1.Text = Now.Month - 1 & Label1.Text & ds.Tables.Item(0).Rows(0)("借阅数")


        'weihuanshu
        strsel = "select count(*) '未还数' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code and datediff(day,brt.borrowdate,getdate())>30 and returndate is null"
        da.SelectCommand = New SqlCommand(strsel, cn)

        ds.Reset()
        da.Fill(ds, "seltable")
        Label2.Text = Now.Month - 1 & Label2.Text & ds.Tables.Item(0).Rows(0)("未还数")

        strsel = " select brt.borrowid '借阅号',bidt.bid  '条码号',b.Book_name '图书名称',r.READER '读者' ,brt.borrowDate '借阅日期',brt.returnDate '归还日期' from BorrowReturnTable brt,BOOK b,BookIDTable bidt,Reader r where brt.readerid=r.card_ID and brt.bookid=bidt.bid and bidt.Book_code=b.book_code  and month(borrowDate)=" & Now.Month - 1
        '  strsel = "select a.card_id as 读者证号，reader as 姓名,count(*) as 借阅次数 from borrow a join reader b on a.card_id=b.card_id"
        ' strsel = strsel & "where month(borrow_date)=" & Now.Month - 1 & " and year(borrow_date)=" & Now.Year
        ' strsel = strsel & "group by a.card_id,reader"
        da.SelectCommand = New SqlCommand(strsel, cn)
        ds.Reset()
        Label3.Text = Now.Month - 1 & Label3.Text
        da.Fill(ds, "seltable")
        DataGridView1.DataSource = ds.Tables.Item(0)
    End Sub
End Class