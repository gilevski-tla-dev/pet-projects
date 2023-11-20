<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorker
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
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.dtpDoP = New System.Windows.Forms.DateTimePicker()
        Me.lblDoP = New System.Windows.Forms.Label()
        Me.txtQual = New System.Windows.Forms.TextBox()
        Me.lblQual = New System.Windows.Forms.Label()
        Me.lblFL = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.ilsIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.cboRank = New System.Windows.Forms.ComboBox()
        Me.cboFL = New System.Windows.Forms.ComboBox()
        Me.dtpDoU = New System.Windows.Forms.DateTimePicker()
        Me.lblDoU = New System.Windows.Forms.Label()
        Me.cmdAddRank = New System.Windows.Forms.Button()
        Me.cmdAddFL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(621, 278)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(128, 32)
        Me.cmdExit.TabIndex = 29
        Me.cmdExit.Text = "Закрыть"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(477, 278)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(128, 32)
        Me.cmdSave.TabIndex = 28
        Me.cmdSave.Text = "Сохранить"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'dtpDoP
        '
        Me.dtpDoP.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtpDoP.Location = New System.Drawing.Point(311, 177)
        Me.dtpDoP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDoP.Name = "dtpDoP"
        Me.dtpDoP.Size = New System.Drawing.Size(437, 27)
        Me.dtpDoP.TabIndex = 25
        '
        'lblDoP
        '
        Me.lblDoP.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDoP.Location = New System.Drawing.Point(16, 177)
        Me.lblDoP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDoP.Name = "lblDoP"
        Me.lblDoP.Size = New System.Drawing.Size(269, 25)
        Me.lblDoP.TabIndex = 24
        Me.lblDoP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtQual
        '
        Me.txtQual.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtQual.Location = New System.Drawing.Point(312, 128)
        Me.txtQual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQual.Name = "txtQual"
        Me.txtQual.Size = New System.Drawing.Size(437, 27)
        Me.txtQual.TabIndex = 21
        '
        'lblQual
        '
        Me.lblQual.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblQual.Location = New System.Drawing.Point(16, 130)
        Me.lblQual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQual.Name = "lblQual"
        Me.lblQual.Size = New System.Drawing.Size(269, 25)
        Me.lblQual.TabIndex = 20
        Me.lblQual.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFL
        '
        Me.lblFL.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFL.Location = New System.Drawing.Point(16, 85)
        Me.lblFL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFL.Name = "lblFL"
        Me.lblFL.Size = New System.Drawing.Size(269, 25)
        Me.lblFL.TabIndex = 18
        Me.lblFL.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRank
        '
        Me.lblRank.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRank.Location = New System.Drawing.Point(16, 41)
        Me.lblRank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(269, 25)
        Me.lblRank.TabIndex = 16
        Me.lblRank.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblID.Location = New System.Drawing.Point(701, 6)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(76, 25)
        Me.lblID.TabIndex = 15
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ilsIcons
        '
        Me.ilsIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilsIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilsIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'cboRank
        '
        Me.cboRank.FormattingEnabled = True
        Me.cboRank.Location = New System.Drawing.Point(311, 36)
        Me.cboRank.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboRank.Name = "cboRank"
        Me.cboRank.Size = New System.Drawing.Size(399, 24)
        Me.cboRank.TabIndex = 30
        '
        'cboFL
        '
        Me.cboFL.FormattingEnabled = True
        Me.cboFL.Location = New System.Drawing.Point(312, 82)
        Me.cboFL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboFL.Name = "cboFL"
        Me.cboFL.Size = New System.Drawing.Size(397, 24)
        Me.cboFL.TabIndex = 31
        '
        'dtpDoU
        '
        Me.dtpDoU.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtpDoU.Location = New System.Drawing.Point(311, 229)
        Me.dtpDoU.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDoU.Name = "dtpDoU"
        Me.dtpDoU.Size = New System.Drawing.Size(437, 27)
        Me.dtpDoU.TabIndex = 33
        '
        'lblDoU
        '
        Me.lblDoU.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDoU.Location = New System.Drawing.Point(15, 229)
        Me.lblDoU.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDoU.Name = "lblDoU"
        Me.lblDoU.Size = New System.Drawing.Size(269, 25)
        Me.lblDoU.TabIndex = 32
        Me.lblDoU.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdAddRank
        '
        Me.cmdAddRank.Location = New System.Drawing.Point(719, 34)
        Me.cmdAddRank.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAddRank.Name = "cmdAddRank"
        Me.cmdAddRank.Size = New System.Drawing.Size(33, 26)
        Me.cmdAddRank.TabIndex = 34
        Me.cmdAddRank.Text = "+"
        Me.cmdAddRank.UseVisualStyleBackColor = True
        '
        'cmdAddFL
        '
        Me.cmdAddFL.Location = New System.Drawing.Point(719, 81)
        Me.cmdAddFL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAddFL.Name = "cmdAddFL"
        Me.cmdAddFL.Size = New System.Drawing.Size(33, 26)
        Me.cmdAddFL.TabIndex = 35
        Me.cmdAddFL.Text = "+"
        Me.cmdAddFL.UseVisualStyleBackColor = True
        '
        'frmWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 322)
        Me.Controls.Add(Me.cmdAddFL)
        Me.Controls.Add(Me.cmdAddRank)
        Me.Controls.Add(Me.dtpDoU)
        Me.Controls.Add(Me.lblDoU)
        Me.Controls.Add(Me.cboFL)
        Me.Controls.Add(Me.cboRank)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.dtpDoP)
        Me.Controls.Add(Me.lblDoP)
        Me.Controls.Add(Me.txtQual)
        Me.Controls.Add(Me.lblQual)
        Me.Controls.Add(Me.lblFL)
        Me.Controls.Add(Me.lblRank)
        Me.Controls.Add(Me.lblID)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmWorker"
        Me.Text = "frmWorker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents dtpDoP As DateTimePicker
    Friend WithEvents lblDoP As Label
    Friend WithEvents txtQual As TextBox
    Friend WithEvents lblQual As Label
    Friend WithEvents lblFL As Label
    Friend WithEvents lblRank As Label
    Friend WithEvents lblID As Label
    Friend WithEvents ilsIcons As ImageList
    Friend WithEvents cboRank As ComboBox
    Friend WithEvents cboFL As ComboBox
    Friend WithEvents dtpDoU As DateTimePicker
    Friend WithEvents lblDoU As Label
    Friend WithEvents cmdAddRank As Button
    Friend WithEvents cmdAddFL As Button
End Class
