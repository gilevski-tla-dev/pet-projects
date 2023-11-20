Public Class frmFL
    Dim objFL1 As Физлицо
    Private Sub frmFL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            Select Case strFormMode
                Case "ADD"
                    objFL1 = New Физлицо(2638532)
                    .Text = "Новое физическое лицо"
                    .Icon = My.Resources.resOK._add
                Case "EDIT"
                    objFL1 = New Физлицо(intIDFL)
                    .Text = "Редактирование сведений о физическом лице"
                    .Icon = My.Resources.resOK._edit
                Case Else
                    MessageBox.Show("Неизвестный режим отображения формы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            .WindowState = FormWindowState.Normal
            .MaximizeBox = False
            .MinimizeBox = False
        End With

        'lblID.Visible = False
        lblFam.Text = "Фамилия"
        lblIm.Text = "Имя"
        lblOtch.Text = "Отчество"
        lblDoB.Text = "Дата рождения"
        lblAdress.Text = "Адрес"
        lblTel.Text = "Телефон"

        With cmdExit
            .Text = "Закрыть"
            .Image = My.Resources.resOK.i_exit
            .ImageAlign = ContentAlignment.MiddleLeft
            .TextAlign = ContentAlignment.MiddleLeft
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With

        With cmdSave
            .Text = "Сохранить"
            .Image = My.Resources.resOK.i_save
            .ImageAlign = ContentAlignment.MiddleLeft
            .TextAlign = ContentAlignment.MiddleLeft
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With

        With objFL1
            lblID.Text = .ИД
            txtFam.Text = .Фамилия
            txtIm.Text = .Имя
            txtOtch.Text = .Отчество
            dtpDoB.Value = .ДатаРождения
            txtAdress.Text = .Адрес
            txtTel.Text = .Телефон
        End With

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        With objFL1
            .Фамилия = txtFam.Text
            .Имя = txtIm.Text
            .Отчество = txtOtch.Text
            .ДатаРождения = dtpDoB.Value
            .Адрес = txtAdress.Text
            .Телефон = txtTel.Text
        End With

        Select Case strFormMode
            Case "ADD"
                If objFL1.Добавить(objFL1) = True Then
                    MessageBox.Show("Новый элемент успешно добавлен в справочник", "Добавление элемента в справочник", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case "EDIT"
                If objFL1.Редактировать(objFL1) = True Then
                    MessageBox.Show("Изменения в элемент справочника успешно внесены", "Редактирование элемента в справочнике", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Else
                MessageBox.Show("Неизвестный режим отображения формы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        Call frmFLList.CreateFLList()
        Me.Close()

    End Sub
End Class