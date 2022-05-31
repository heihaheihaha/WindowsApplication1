Public Class Form5readerbrowser

    Private Sub READERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles READERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.READERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BOOKDataSet2)

    End Sub

    Private Sub Form5readerbrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BOOKDataSet2.READER”中。您可以根据需要移动或删除它。
        Me.READERTableAdapter.Fill(Me.BOOKDataSet2.READER)

    End Sub
End Class