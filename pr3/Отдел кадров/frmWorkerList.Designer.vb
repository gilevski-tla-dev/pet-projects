<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkerList
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkerList))
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbRemove = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ilsIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.ttpPopup = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgdList = New System.Windows.Forms.DataGridView()
        Me.lblCountField = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.tspMain.SuspendLayout()
        CType(Me.dgdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tspMain
        '
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdd, Me.tsbEdit, Me.tsbRemove, Me.ToolStripSeparator1, Me.tsbExit})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(607, 25)
        Me.tspMain.TabIndex = 0
        Me.tspMain.Text = "ToolStrip1"
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(23, 22)
        Me.tsbAdd.Text = "ToolStripButton1"
        '
        'tsbEdit
        '
        Me.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEdit.Image = CType(resources.GetObject("tsbEdit.Image"), System.Drawing.Image)
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(23, 22)
        Me.tsbEdit.Text = "ToolStripButton2"
        '
        'tsbRemove
        '
        Me.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRemove.Image = CType(resources.GetObject("tsbRemove.Image"), System.Drawing.Image)
        Me.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRemove.Name = "tsbRemove"
        Me.tsbRemove.Size = New System.Drawing.Size(23, 22)
        Me.tsbRemove.Text = "ToolStripButton3"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(23, 22)
        Me.tsbExit.Text = "ToolStripButton4"
        '
        'ilsIcons
        '
        Me.ilsIcons.ImageStream = CType(resources.GetObject("ilsIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsIcons.Images.SetKeyName(0, "add.ico")
        Me.ilsIcons.Images.SetKeyName(1, "edit.ico")
        Me.ilsIcons.Images.SetKeyName(2, "org_32x32.ico")
        Me.ilsIcons.Images.SetKeyName(3, "436.ico")
        '
        'dgdList
        '
        Me.dgdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdList.Location = New System.Drawing.Point(4, 26)
        Me.dgdList.Name = "dgdList"
        Me.dgdList.Size = New System.Drawing.Size(592, 210)
        Me.dgdList.TabIndex = 1
        '
        'lblCountField
        '
        Me.lblCountField.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCountField.Location = New System.Drawing.Point(353, 248)
        Me.lblCountField.Name = "lblCountField"
        Me.lblCountField.Size = New System.Drawing.Size(155, 20)
        Me.lblCountField.TabIndex = 2
        Me.lblCountField.Text = "Всего физических лиц:"
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCount.Location = New System.Drawing.Point(502, 248)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(93, 20)
        Me.lblCount.TabIndex = 3
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(491, 282)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(103, 34)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Закрыть"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmWorkerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 318)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblCountField)
        Me.Controls.Add(Me.dgdList)
        Me.Controls.Add(Me.tspMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkerList"
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        CType(Me.dgdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tspMain As ToolStrip
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbEdit As ToolStripButton
    Friend WithEvents tsbRemove As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents ilsIcons As ImageList
    Friend WithEvents ttpPopup As ToolTip
    Friend WithEvents dgdList As DataGridView
    Friend WithEvents lblCountField As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents cmdExit As Button
End Class
