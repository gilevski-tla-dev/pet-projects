Module modMain
    'Public strDBFileName As String = "D:\db.accdb"
    Public strDBFileName As String = "C:\Проекты\db.accdb"
    Public intIDFL As Integer = 0
    Public intIDWorker As Integer = 0
    Public strFormMode As String = "EDIT"



    Public Function MaxID(ByVal strTableName As String, ByVal strFieldName As String) As Integer
        Dim strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName
        Dim strQuery As String = "SELECT MAX(" & strFieldName & ") FROM " & strTableName
        Dim intMaxID As Integer = 0

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            While objDataReader.Read() = True
                intMaxID = objDataReader.GetValue(0)
            End While

            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return intMaxID
    End Function

    Public Sub CreateListFL(ByVal objControlName As ComboBox, ByVal dtFL As DataTable)
        Dim strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName
        Dim strQuery = "SELECT Код_физического_лица, (Фамилия + ' ' + Имя + ' ' + Отчество) As ФИО FROM Физические_лица ORDER BY Фамилия, Имя"
        Dim strFIO As String = vbNullString
        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            objControlName.Items.Clear()

            While objDataReader.Read() = True
                If objDataReader.GetValue(0) > 0 Then
                    strFIO = objDataReader.GetValue(1)
                Else
                    strFIO = "(не указан)"
                End If
                dtFL.Rows.Add(objDataReader.GetValue(0), strFIO)
            End While

            objControlName.DataSource = dtFL
            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CreateListRank(ByVal objControlName As ComboBox, ByVal dtRank As DataTable)
        Dim strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName
        Dim strQuery = "SELECT Код_должности, Должность FROM Должности ORDER BY Должность"
        Dim strRank As String = vbNullString
        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            objControlName.Items.Clear()

            While objDataReader.Read() = True
                If objDataReader.GetValue(0) > 0 Then
                    strRank = objDataReader.GetValue(1)
                Else
                    strRank = "(не указана)"
                End If
                dtRank.Rows.Add(objDataReader.GetValue(0), strRank)
            End While

            objControlName.DataSource = dtRank
            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Module
