<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFL
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFam = New System.Windows.Forms.Label()
        Me.txtFam = New System.Windows.Forms.TextBox()
        Me.txtIm = New System.Windows.Forms.TextBox()
        Me.lblIm = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtOtch = New System.Windows.Forms.TextBox()
        Me.lblOtch = New System.Windows.Forms.Label()
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.dtpDoB = New System.Windows.Forms.DateTimePicker()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.lblAdress = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.ilsIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblID.Location = New System.Drawing.Point(539, 9)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(57, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFam
        '
        Me.lblFam.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFam.Location = New System.Drawing.Point(25, 37)
        Me.lblFam.Name = "lblFam"
        Me.lblFam.Size = New System.Drawing.Size(202, 20)
        Me.lblFam.TabIndex = 1
        Me.lblFam.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFam
        '
        Me.txtFam.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFam.Location = New System.Drawing.Point(247, 35)
        Me.txtFam.Name = "txtFam"
        Me.txtFam.Size = New System.Drawing.Size(329, 23)
        Me.txtFam.TabIndex = 2
        '
        'txtIm
        '
        Me.txtIm.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtIm.Location = New System.Drawing.Point(247, 71)
        Me.txtIm.Name = "txtIm"
        Me.txtIm.Size = New System.Drawing.Size(329, 23)
        Me.txtIm.TabIndex = 4
        '
        'lblIm
        '
        Me.lblIm.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblIm.Location = New System.Drawing.Point(25, 73)
        Me.lblIm.Name = "lblIm"
        Me.lblIm.Size = New System.Drawing.Size(202, 20)
        Me.lblIm.TabIndex = 3
        Me.lblIm.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtTel.Location = New System.Drawing.Point(247, 284)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(329, 23)
        Me.txtTel.TabIndex = 8
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTel.Location = New System.Drawing.Point(25, 286)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(202, 20)
        Me.lblTel.TabIndex = 7
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtOtch
        '
        Me.txtOtch.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtOtch.Location = New System.Drawing.Point(247, 108)
        Me.txtOtch.Name = "txtOtch"
        Me.txtOtch.Size = New System.Drawing.Size(329, 23)
        Me.txtOtch.TabIndex = 6
        '
        'lblOtch
        '
        Me.lblOtch.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblOtch.Location = New System.Drawing.Point(25, 110)
        Me.lblOtch.Name = "lblOtch"
        Me.lblOtch.Size = New System.Drawing.Size(202, 20)
        Me.lblOtch.TabIndex = 5
        Me.lblOtch.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDoB
        '
        Me.lblDoB.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDoB.Location = New System.Drawing.Point(25, 148)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(202, 20)
        Me.lblDoB.TabIndex = 9
        Me.lblDoB.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpDoB
        '
        Me.dtpDoB.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtpDoB.Location = New System.Drawing.Point(247, 148)
        Me.dtpDoB.Name = "dtpDoB"
        Me.dtpDoB.Size = New System.Drawing.Size(329, 23)
        Me.dtpDoB.TabIndex = 10
        '
        'txtAdress
        '
        Me.txtAdress.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(247, 188)
        Me.txtAdress.Multiline = True
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(329, 78)
        Me.txtAdress.TabIndex = 12
        '
        'lblAdress
        '
        Me.lblAdress.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAdress.Location = New System.Drawing.Point(25, 190)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(202, 20)
        Me.lblAdress.TabIndex = 11
        Me.lblAdress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(372, 324)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 26)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Text = "Сохранить"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(480, 324)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(96, 26)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "Закрыть"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'ilsIcons
        '
        Me.ilsIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilsIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilsIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmFL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 355)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.lblAdress)
        Me.Controls.Add(Me.dtpDoB)
        Me.Controls.Add(Me.lblDoB)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.txtOtch)
        Me.Controls.Add(Me.lblOtch)
        Me.Controls.Add(Me.txtIm)
        Me.Controls.Add(Me.lblIm)
        Me.Controls.Add(Me.txtFam)
        Me.Controls.Add(Me.lblFam)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmFL"
        Me.Text = "frmFL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblFam As Label
    Friend WithEvents txtFam As TextBox
    Friend WithEvents txtIm As TextBox
    Friend WithEvents lblIm As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents lblTel As Label
    Friend WithEvents txtOtch As TextBox
    Friend WithEvents lblOtch As Label
    Friend WithEvents lblDoB As Label
    Friend WithEvents dtpDoB As DateTimePicker
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents lblAdress As Label
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents ilsIcons As ImageList
End Class
