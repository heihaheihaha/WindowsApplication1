<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.系统ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重新登录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.图书管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新书入库Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.图书Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.读者管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新读者注册ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询读者信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借还书管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.办理借阅ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息统计ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.借阅情况ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.月汇总ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOOKDataSet = New WindowsApplication1.BOOKDataSet2()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKTableAdapter = New WindowsApplication1.BOOKDataSet2TableAdapters.BOOKTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.BOOKDataSet2TableAdapters.TableAdapterManager()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BOOKDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.系统ToolStripMenuItem, Me.图书管理ToolStripMenuItem, Me.读者管理ToolStripMenuItem, Me.借还书管理ToolStripMenuItem, Me.ToolStripMenuItem1, Me.信息统计ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '系统ToolStripMenuItem
        '
        Me.系统ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.重新登录ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem"
        Me.系统ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.系统ToolStripMenuItem.Text = "系统"
        '
        '重新登录ToolStripMenuItem
        '
        Me.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem"
        Me.重新登录ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.重新登录ToolStripMenuItem.Text = "重新登录"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '图书管理ToolStripMenuItem
        '
        Me.图书管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新书入库Menu, Me.图书Menu})
        Me.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem"
        Me.图书管理ToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.图书管理ToolStripMenuItem.Text = "图书管理"
        '
        '新书入库Menu
        '
        Me.新书入库Menu.Name = "新书入库Menu"
        Me.新书入库Menu.Size = New System.Drawing.Size(168, 24)
        Me.新书入库Menu.Text = "新书入库"
        '
        '图书Menu
        '
        Me.图书Menu.Name = "图书Menu"
        Me.图书Menu.Size = New System.Drawing.Size(168, 24)
        Me.图书Menu.Text = "查询图书信息"
        '
        '读者管理ToolStripMenuItem
        '
        Me.读者管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新读者注册ToolStripMenuItem, Me.查询读者信息ToolStripMenuItem})
        Me.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem"
        Me.读者管理ToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.读者管理ToolStripMenuItem.Text = "读者管理"
        '
        '新读者注册ToolStripMenuItem
        '
        Me.新读者注册ToolStripMenuItem.Name = "新读者注册ToolStripMenuItem"
        Me.新读者注册ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.新读者注册ToolStripMenuItem.Text = "新读者注册"
        '
        '查询读者信息ToolStripMenuItem
        '
        Me.查询读者信息ToolStripMenuItem.Name = "查询读者信息ToolStripMenuItem"
        Me.查询读者信息ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.查询读者信息ToolStripMenuItem.Text = "查询读者信息"
        '
        '借还书管理ToolStripMenuItem
        '
        Me.借还书管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.办理借阅ToolStripMenuItem})
        Me.借还书管理ToolStripMenuItem.Name = "借还书管理ToolStripMenuItem"
        Me.借还书管理ToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.借还书管理ToolStripMenuItem.Text = "借还书管理"
        '
        '办理借阅ToolStripMenuItem
        '
        Me.办理借阅ToolStripMenuItem.Name = "办理借阅ToolStripMenuItem"
        Me.办理借阅ToolStripMenuItem.Size = New System.Drawing.Size(183, 24)
        Me.办理借阅ToolStripMenuItem.Text = "办理借书和还书"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 24)
        '
        '信息统计ToolStripMenuItem
        '
        Me.信息统计ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.借阅情况ToolStripMenuItem, Me.月汇总ToolStripMenuItem})
        Me.信息统计ToolStripMenuItem.Name = "信息统计ToolStripMenuItem"
        Me.信息统计ToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.信息统计ToolStripMenuItem.Text = "信息统计"
        '
        '借阅情况ToolStripMenuItem
        '
        Me.借阅情况ToolStripMenuItem.Name = "借阅情况ToolStripMenuItem"
        Me.借阅情况ToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.借阅情况ToolStripMenuItem.Text = "借阅情况"
        '
        '月汇总ToolStripMenuItem
        '
        Me.月汇总ToolStripMenuItem.Name = "月汇总ToolStripMenuItem"
        Me.月汇总ToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.月汇总ToolStripMenuItem.Text = "月汇总"
        '
        'BOOKDataSet
        '
        Me.BOOKDataSet.DataSetName = "BOOKDataSet"
        Me.BOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.BOOKDataSet
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ADTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Me.BOOKTableAdapter
        Me.TableAdapterManager.BORROWTableAdapter = Nothing
        Me.TableAdapterManager.READERTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.BOOKDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'Form2main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 380)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "图书借阅管理系统"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BOOKDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 系统ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重新登录ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 图书管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新书入库Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 图书Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 读者管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新读者注册ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查询读者信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 借还书管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 办理借阅ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOOKDataSet As WindowsApplication1.BOOKDataSet2
    Friend WithEvents BOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKTableAdapter As WindowsApplication1.BOOKDataSet2TableAdapters.BOOKTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.BOOKDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 信息统计ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 借阅情况ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 月汇总ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
