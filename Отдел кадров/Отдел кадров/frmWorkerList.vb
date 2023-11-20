Public Class frmWorkerList

    Public Sub CreateFLList()
        Dim strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName
        Dim strQuery As String = "Select Код_физического_лица, Фамилия, Имя, Отчество FROM Физические_лица ORDER BY Фамилия, Имя, Отчество"
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
                .Add("Фамилия")
                .Add("Имя")
                .Add("Отчество")
            End With

            While objDataReader.Read() = True
                If objDataReader.GetValue(0) <> 0 Then
                    intCount += 1
                    dtDataTable.Rows.Add(New String() {objDataReader.GetValue(0), intCount, objDataReader.GetValue(1), objDataReader.GetValue(2), objDataReader.GetValue(3)})
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
            .Columns(2).Width = 200
            .Columns(3).Width = 150
            .Columns(4).Width = 150
        End With

        lblCount.Text = intCount

        If intCount >= 1 Then
            With dgdList
                .Rows(0).Selected = True
            End With
        End If
    End Sub

    Private Sub frmWorkerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Физические лица"
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

        Call CreateFLList()

    End Sub


    Private Sub dgdList_Click(sender As Object, e As EventArgs) Handles dgdList.Click
        intIDFL = dgdList.Item(0, dgdList.CurrentRow.Index).Value
    End Sub

    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        Dim objFL1 As Физлицо = New Физлицо(98538562)
        strFormMode = "ADD"
        frmFL.Show()
    End Sub

    Private Sub tsbEdit_Click(sender As Object, e As EventArgs) Handles tsbEdit.Click
        Dim objFL1 As Физлицо = New Физлицо(intIDFL)
        strFormMode = "EDIT"
        frmFL.Show()
    End Sub

    Private Sub tsbRemove_Click(sender As Object, e As EventArgs) Handles tsbRemove.Click
        Dim objFL1 As Физлицо = New Физлицо(intIDFL)
        If intIDFL > 0 Then
            If MessageBox.Show("Вы действительно хотите удалить элемент с идентификатором " & intIDFL & " из справочника?", "Удаление элемента из справочника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objFL1.Удалить(objFL1) = True Then
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
        Call CreateFLList()
    End Sub
End Class
