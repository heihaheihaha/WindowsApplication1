<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7borrow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_borrow = New System.Windows.Forms.Button()
        Me.txt_borrow_reader = New System.Windows.Forms.TextBox()
        Me.txt_borrow_bookid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.txt_return_bookid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_BWInfo = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_BWInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "借书证号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "图书号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 12)
        Me.Label3.TabIndex = 2
        '
        'btn_borrow
        '
        Me.btn_borrow.Location = New System.Drawing.Point(107, 141)
        Me.btn_borrow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_borrow.Name = "btn_borrow"
        Me.btn_borrow.Size = New System.Drawing.Size(89, 35)
        Me.btn_borrow.TabIndex = 3
        Me.btn_borrow.Text = "借阅"
        Me.btn_borrow.UseVisualStyleBackColor = True
        '
        'txt_borrow_reader
        '
        Me.txt_borrow_reader.Location = New System.Drawing.Point(173, 61)
        Me.txt_borrow_reader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_borrow_reader.Name = "txt_borrow_reader"
        Me.txt_borrow_reader.Size = New System.Drawing.Size(150, 21)
        Me.txt_borrow_reader.TabIndex = 4
        '
        'txt_borrow_bookid
        '
        Me.txt_borrow_bookid.Location = New System.Drawing.Point(173, 92)
        Me.txt_borrow_bookid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_borrow_bookid.Name = "txt_borrow_bookid"
        Me.txt_borrow_bookid.Size = New System.Drawing.Size(76, 21)
        Me.txt_borrow_bookid.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_borrow)
        Me.GroupBox1.Controls.Add(Me.txt_borrow_bookid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_borrow_reader)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 201)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "图书借阅"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_return)
        Me.GroupBox2.Controls.Add(Me.txt_return_bookid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(513, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 201)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "图书归还"
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(91, 89)
        Me.btn_return.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(89, 35)
        Me.btn_return.TabIndex = 3
        Me.btn_return.Text = "归还"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'txt_return_bookid
        '
        Me.txt_return_bookid.Location = New System.Drawing.Point(157, 40)
        Me.txt_return_bookid.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_return_bookid.Name = "txt_return_bookid"
        Me.txt_return_bookid.Size = New System.Drawing.Size(76, 21)
        Me.txt_return_bookid.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "图书号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 12)
        Me.Label6.TabIndex = 2
        '
        'dgv_BWInfo
        '
        Me.dgv_BWInfo.AllowUserToAddRows = False
        Me.dgv_BWInfo.AllowUserToDeleteRows = False
        Me.dgv_BWInfo.AllowUserToOrderColumns = True
        Me.dgv_BWInfo.AllowUserToResizeRows = False
        Me.dgv_BWInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_BWInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_BWInfo.Location = New System.Drawing.Point(31, 20)
        Me.dgv_BWInfo.Name = "dgv_BWInfo"
        Me.dgv_BWInfo.ReadOnly = True
        Me.dgv_BWInfo.RowTemplate.Height = 23
        Me.dgv_BWInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_BWInfo.Size = New System.Drawing.Size(788, 366)
        Me.dgv_BWInfo.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_BWInfo)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(838, 395)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "读者借还信息"
        '
        'Form7borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 638)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form7borrow"
        Me.Text = "借书"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_BWInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_borrow As System.Windows.Forms.Button
    Friend WithEvents txt_borrow_reader As System.Windows.Forms.TextBox
    Friend WithEvents txt_borrow_bookid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents txt_return_bookid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_BWInfo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
