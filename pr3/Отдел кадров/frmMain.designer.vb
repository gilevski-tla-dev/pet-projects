<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLabs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLabsFLs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLabsRanks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLabsWorkers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAuth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tssSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tsbCut = New System.Windows.Forms.ToolStripButton()
        Me.tsbPaste = New System.Windows.Forms.ToolStripButton()
        Me.tssSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbRemove = New System.Windows.Forms.ToolStripButton()
        Me.tssSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.tslTitle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tpbProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.tslDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMain.SuspendLayout()
        Me.tlsMain.SuspendLayout()
        Me.stsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuLabs, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.mnuMain.Size = New System.Drawing.Size(1340, 30)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSep1, Me.mnuFileExit})
        Me.mnuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(59, 28)
        Me.mnuFile.Text = "Файл"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(182, 26)
        Me.mnuFileOpen.Text = "Открыть БД..."
        '
        'mnuFileSep1
        '
        Me.mnuFileSep1.Name = "mnuFileSep1"
        Me.mnuFileSep1.Size = New System.Drawing.Size(179, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(182, 26)
        Me.mnuFileExit.Text = "Выход"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste, Me.mnuEditSep1, Me.mnuEditAdd, Me.mnuEditUpdate, Me.mnuEditRemove})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(74, 28)
        Me.mnuEdit.Text = "Правка"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.Size = New System.Drawing.Size(203, 26)
        Me.mnuEditCopy.Text = "Копировать"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.Size = New System.Drawing.Size(203, 26)
        Me.mnuEditCut.Text = "Вырезать"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.Size = New System.Drawing.Size(203, 26)
        Me.mnuEditPaste.Text = "Вставить"
        '
        'mnuEditSep1
        '
        Me.mnuEditSep1.Name = "mnuEditSep1"
        Me.mnuEditSep1.Size = New System.Drawing.Size(200, 6)
        '
        'mnuEditAdd
        '
        Me.mnuEditAdd.Name = "mnuEditAdd"
        Me.mnuEditAdd.Size = New System.Drawing.Size(203, 26)
        Me.mnuEditAdd.Text = "Добавать..."
        '
        'mnuEditUpdate
        '
        Me.mnuEditUpdate.Name = "mnuEditUpdate"
        Me.mnuEditUpdate.Size = New System.Drawing.Size(203, 26)
        Me.mnuEditUpdate.Text = "Редактировать..."
        '
        'mnuEditRemove
        '
        Me.mnuEditRemove.Name = "mnuEditRemove"
        Me.mnuEditRemove.Size = New System.Drawing.Size(203, 26)
        Me.mnuEditRemove.Text = "Удалить"
        '
        'mnuLabs
        '
        Me.mnuLabs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLabsFLs, Me.mnuLabsRanks, Me.mnuLabsWorkers})
        Me.mnuLabs.Name = "mnuLabs"
        Me.mnuLabs.Size = New System.Drawing.Size(117, 28)
        Me.mnuLabs.Text = "Справочники"
        '
        'mnuLabsFLs
        '
        Me.mnuLabsFLs.Name = "mnuLabsFLs"
        Me.mnuLabsFLs.Size = New System.Drawing.Size(183, 26)
        Me.mnuLabsFLs.Text = "Физлица..."
        '
        'mnuLabsRanks
        '
        Me.mnuLabsRanks.Name = "mnuLabsRanks"
        Me.mnuLabsRanks.Size = New System.Drawing.Size(183, 26)
        Me.mnuLabsRanks.Text = "Должности..."
        '
        'mnuLabsWorkers
        '
        Me.mnuLabsWorkers.Name = "mnuLabsWorkers"
        Me.mnuLabsWorkers.Size = New System.Drawing.Size(183, 26)
        Me.mnuLabsWorkers.Text = "Сотрудники..."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout, Me.mnuHelpAuth, Me.mnuHelpSep1, Me.mnuHelpRef})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(83, 28)
        Me.mnuHelp.Text = "Помощь"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(196, 26)
        Me.mnuHelpAbout.Text = "О программе..."
        '
        'mnuHelpAuth
        '
        Me.mnuHelpAuth.Name = "mnuHelpAuth"
        Me.mnuHelpAuth.Size = New System.Drawing.Size(196, 26)
        Me.mnuHelpAuth.Text = "Об авторе..."
        '
        'mnuHelpSep1
        '
        Me.mnuHelpSep1.Name = "mnuHelpSep1"
        Me.mnuHelpSep1.Size = New System.Drawing.Size(193, 6)
        '
        'mnuHelpRef
        '
        Me.mnuHelpRef.Name = "mnuHelpRef"
        Me.mnuHelpRef.Size = New System.Drawing.Size(196, 26)
        Me.mnuHelpRef.Text = "Справка"
        '
        'tlsMain
        '
        Me.tlsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.tssSep1, Me.tsbCopy, Me.tsbCut, Me.tsbPaste, Me.tssSep2, Me.tsbAdd, Me.tsbEdit, Me.tsbRemove, Me.tssSep3, Me.tsbExit})
        Me.tlsMain.Location = New System.Drawing.Point(0, 30)
        Me.tlsMain.Name = "tlsMain"
        Me.tlsMain.Size = New System.Drawing.Size(1340, 31)
        Me.tlsMain.TabIndex = 3
        Me.tlsMain.Text = "ToolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.AutoSize = False
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = Global.Отдел_кадров.My.Resources.resOK.Open_16х16
        Me.tsbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(29, 28)
        Me.tsbOpen.Text = "Открыть"
        '
        'tssSep1
        '
        Me.tssSep1.Name = "tssSep1"
        Me.tssSep1.Size = New System.Drawing.Size(6, 31)
        '
        'tsbCopy
        '
        Me.tsbCopy.AutoSize = False
        Me.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopy.Image = Global.Отдел_кадров.My.Resources.resOK.copy16х16
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.Size = New System.Drawing.Size(29, 28)
        Me.tsbCopy.Text = "Копировать"
        '
        'tsbCut
        '
        Me.tsbCut.AutoSize = False
        Me.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCut.Image = Global.Отдел_кадров.My.Resources.resOK.cut16х16
        Me.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCut.Name = "tsbCut"
        Me.tsbCut.Size = New System.Drawing.Size(29, 28)
        Me.tsbCut.Text = "Вырезать"
        '
        'tsbPaste
        '
        Me.tsbPaste.AutoSize = False
        Me.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPaste.Image = Global.Отдел_кадров.My.Resources.resOK.paste16х16
        Me.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPaste.Name = "tsbPaste"
        Me.tsbPaste.Size = New System.Drawing.Size(29, 28)
        Me.tsbPaste.Text = "Вставить"
        '
        'tssSep2
        '
        Me.tssSep2.Name = "tssSep2"
        Me.tssSep2.Size = New System.Drawing.Size(6, 31)
        '
        'tsbAdd
        '
        Me.tsbAdd.AutoSize = False
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.Image = Global.Отдел_кадров.My.Resources.resOK.add
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(29, 28)
        Me.tsbAdd.Text = "Добавить"
        '
        'tsbEdit
        '
        Me.tsbEdit.AutoSize = False
        Me.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEdit.Image = Global.Отдел_кадров.My.Resources.resOK.edit
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(29, 28)
        Me.tsbEdit.Text = "Редактировать"
        '
        'tsbRemove
        '
        Me.tsbRemove.AutoSize = False
        Me.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRemove.Image = Global.Отдел_кадров.My.Resources.resOK.DeleteRed
        Me.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRemove.Name = "tsbRemove"
        Me.tsbRemove.Size = New System.Drawing.Size(29, 28)
        Me.tsbRemove.Text = "Удалить"
        '
        'tssSep3
        '
        Me.tssSep3.Name = "tssSep3"
        Me.tssSep3.Size = New System.Drawing.Size(6, 31)
        '
        'tsbExit
        '
        Me.tsbExit.AutoSize = False
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = Global.Отдел_кадров.My.Resources.resOK.Exit_16x16
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(29, 28)
        Me.tsbExit.Text = "Выход"
        '
        'stsMain
        '
        Me.stsMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslTitle, Me.tpbProgress, Me.tslDateTime})
        Me.stsMain.Location = New System.Drawing.Point(0, 420)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.stsMain.Size = New System.Drawing.Size(1340, 35)
        Me.stsMain.TabIndex = 4
        Me.stsMain.Text = "StatusStrip1"
        '
        'tslTitle
        '
        Me.tslTitle.AutoSize = False
        Me.tslTitle.Enabled = False
        Me.tslTitle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tslTitle.Name = "tslTitle"
        Me.tslTitle.Size = New System.Drawing.Size(350, 29)
        Me.tslTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpbProgress
        '
        Me.tpbProgress.AutoSize = False
        Me.tpbProgress.Name = "tpbProgress"
        Me.tpbProgress.Size = New System.Drawing.Size(89, 27)
        '
        'tslDateTime
        '
        Me.tslDateTime.AutoSize = False
        Me.tslDateTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tslDateTime.Name = "tslDateTime"
        Me.tslDateTime.Size = New System.Drawing.Size(350, 29)
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'tmrProgress
        '
        Me.tmrProgress.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 455)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.tlsMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.tlsMain.ResumeLayout(False)
        Me.tlsMain.PerformLayout()
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSep1 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuEditSep1 As ToolStripSeparator
    Friend WithEvents mnuEditAdd As ToolStripMenuItem
    Friend WithEvents mnuEditUpdate As ToolStripMenuItem
    Friend WithEvents mnuEditRemove As ToolStripMenuItem
    Friend WithEvents mnuLabs As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuLabsFLs As ToolStripMenuItem
    Friend WithEvents mnuLabsRanks As ToolStripMenuItem
    Friend WithEvents mnuLabsWorkers As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuHelpAuth As ToolStripMenuItem
    Friend WithEvents mnuHelpSep1 As ToolStripSeparator
    Friend WithEvents mnuHelpRef As ToolStripMenuItem
    Friend WithEvents tlsMain As ToolStrip
    Friend WithEvents tsbOpen As ToolStripButton
    Friend WithEvents tssSep1 As ToolStripSeparator
    Friend WithEvents tsbCopy As ToolStripButton
    Friend WithEvents tsbCut As ToolStripButton
    Friend WithEvents tsbPaste As ToolStripButton
    Friend WithEvents tssSep2 As ToolStripSeparator
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbEdit As ToolStripButton
    Friend WithEvents tsbRemove As ToolStripButton
    Friend WithEvents tssSep3 As ToolStripSeparator
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents stsMain As StatusStrip
    Friend WithEvents tslTitle As ToolStripStatusLabel
    Friend WithEvents tpbProgress As ToolStripProgressBar
    Friend WithEvents tslDateTime As ToolStripStatusLabel
    Friend WithEvents tmrTime As Timer
    Friend WithEvents tmrProgress As Timer
End Class
