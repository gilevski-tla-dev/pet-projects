Public Class frmWorker
    Dim objWorker As Сотрудник
    Dim dtFL As New DataTable
    Dim dtRank As New DataTable

    Private Sub frmWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With dtFL.Columns
            .Add("ID", GetType(Integer))
            .Add("Item", GetType(String))
        End With

        With dtRank.Columns
            .Add("ID", GetType(Integer))
            .Add("Item", GetType(String))
        End With

        With cboFL
            .DisplayMember = "Item"
            .ValueMember = "ID"
        End With

        With cboRank
            .DisplayMember = "Item"
            .ValueMember = "ID"
        End With

        Call CreateListRank(cboRank, dtRank)
        Call CreateListFL(cboFL, dtFL)

        With Me
            Select Case strFormMode
                Case "ADD"
                    objWorker = New Сотрудник(2638532)
                    .Text = "Новый сотрудник"
                    .Icon = My.Resources.resOK._add
                Case "EDIT"
                    objWorker = New Сотрудник(intIDWorker)
                    .Text = "Редактирование сведений о сотруднике"
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
        lblRank.Text = "Должность"
        lblFL.Text = "ФИО"
        lblQual.Text = "Рейтинг"
        lblDoP.Text = "Дата приёма"
        lblDoU.Text = "Дата увольнения"

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

        With objWorker
            lblID.Text = .ИД
            cboRank.SelectedValue = .Должность.ИД
            cboFL.SelectedValue = .Физлицо.ИД
            txtQual.Text = .Рейтинг
            dtpDoP.Value = .ДатаПриема
            'dtpDoU.Value = .ДатаУвольнения
        End With

    End Sub
End Class