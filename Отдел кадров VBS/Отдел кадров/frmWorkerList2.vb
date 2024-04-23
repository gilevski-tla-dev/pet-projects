Public Class frmWorkerList2
    Public Sub CreateWorkerList()
        Dim strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName
        Dim strQuery As String = "SELECT Код_сотрудника, Должности.Должность, Физическое_лицо FROM Сотрудники, Должности, Физические_лица WHERE Физическое_лицо = Код_физического_лица AND Сотрудники.Должность = Код_должности"
        Dim intCount As Integer = 0
        Dim intIDRow As Integer = 0
        Dim dtDataTable As New DataTable

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            With dtDataTable.Columns
                .Add("ID")
                .Add("№ пп")
                .Add("Должность")
                .Add("ФИО")
            End With

            While objDataReader.Read() = True
                If objDataReader.GetValue(0) <> 0 Then
                    intCount += 1
                    Dim objFL As Физлицо = New Физлицо(objDataReader.GetValue(2))
                    dtDataTable.Rows.Add(New String() {objDataReader.GetValue(0), intCount, objDataReader.GetValue(1), objFL.ОтобразитьФИО(objFL)})
                End If
            End While

            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        With dgdList
            .DataSource = dtDataTable
            .ReadOnly = True
            .AllowUserToAddRows = False
            .Columns(0).Visible = False
            .Columns(1).Width = 40
            .Columns(2).Width = 300
            .Columns(3).Width = 200
        End With

        lblCount.Text = intCount

        If intCount >= 1 Then
            With dgdList
                .Rows(0).Selected = True
            End With
        End If
    End Sub
    Private Sub frmWorkerList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Сотрудники"
            .WindowState = FormWindowState.Normal
            .Icon = My.Resources.resOK.fl
            .MaximizeBox = False
            .MinimizeBox = False
        End With

        tsbAdd.Image = ilsIcons.Images(0)
        tsbEdit.Image = ilsIcons.Images(1)
        tsbRemove.Image = ilsIcons.Images(2)
        tsbExit.Image = ilsIcons.Images(3)

        With cmdExit
            .Image = ilsIcons.Images(3)
            .ImageAlign = ContentAlignment.MiddleLeft
            .TextAlign = ContentAlignment.MiddleLeft
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With

        Call CreateWorkerList()

    End Sub

    Private Sub dgdList_Click(sender As Object, e As EventArgs) Handles dgdList.Click
        intIDWorker = dgdList.Item(0, dgdList.CurrentRow.Index).Value
    End Sub

    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        Dim objWorker As Сотрудник = New Сотрудник(98538562)
        strFormMode = "ADD"
        frmWorker.Show()
    End Sub

    Private Sub tsbEdit_Click(sender As Object, e As EventArgs) Handles tsbEdit.Click
        Dim objWorker As Сотрудник = New Сотрудник(intIDWorker)
        strFormMode = "EDIT"
        frmWorker.Show()
    End Sub

    Private Sub tsbRemove_Click(sender As Object, e As EventArgs) Handles tsbRemove.Click
        Dim objWorker As Сотрудник = New Сотрудник(intIDWorker)
        If intIDWorker > 0 Then
            If MessageBox.Show("Вы действительно хотите удалить элемент с идентификатором " & intIDFL & " из справочника?", "Удаление элемента из справочника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objWorker.Удалить(objWorker) = True Then
                    MessageBox.Show("Элемент с идентификатором " & intIDFL & " успешно удален из справочника", "Удаление элемента из справочнка", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("При удалении элемента из справочника возникла ошибка", "Удаление элемента из справочнка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Требуется указать элемент справочника, который Вы хотите удалить", "Удаление элемента из справочнка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Call CreateWorkerList()
    End Sub
End Class