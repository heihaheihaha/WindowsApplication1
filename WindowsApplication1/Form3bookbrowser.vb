Public Class Form3bookbrowser

    Private Sub Form3bookbrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BOOKDataSet.BOOK”中。您可以根据需要移动或删除它。
        Me.BOOKTableAdapter.Fill(Me.BOOKDataSet.BOOK)

    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOKBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BOOKDataSet)

    End Sub
End Class