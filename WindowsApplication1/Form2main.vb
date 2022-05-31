Public Class Form2main
    Private Sub Form2main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub 办理借阅ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 新书入库ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form4newbook.show()
    End Sub
    Private Sub 库存管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 修改图书信息ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 图书Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图书Menu.Click
        Form3bookbrowser.Show()
    End Sub

    Private Sub 办理借阅ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 办理借阅ToolStripMenuItem.Click
        Form7borrow.Show()
    End Sub
 

Private Sub Form2main_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

End Sub

Public Sub New()

    ' 此调用是设计器所必需的。
    InitializeComponent()

    ' 在 InitializeComponent() 调用之后添加任何初始化。

End Sub

Protected Overrides Sub Finalize()
    MyBase.Finalize()
End Sub

Private Sub 图书管理ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 图书管理ToolStripMenuItem.Click

End Sub

    Private Sub 新书入库Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新书入库Menu.Click
        Form4newbook.Show()
    End Sub

    Private Sub 查询读者信息ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查询读者信息ToolStripMenuItem.Click
        Form5readerbrowser.Show()
    End Sub

    Private Sub 新读者注册ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新读者注册ToolStripMenuItem.Click
        Form6newreader.Show()
    End Sub

    Private Sub 借阅情况ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 借阅情况ToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub 月汇总ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 月汇总ToolStripMenuItem.Click
        Form2summary.Show()
    End Sub

    
End Class

