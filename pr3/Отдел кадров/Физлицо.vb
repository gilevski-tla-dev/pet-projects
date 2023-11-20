Public Class Физлицо
    Public strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName
    Private intID As Integer
    Private strFam As String
    Private strIm As String
    Private strOtch As String
    Private datDOB As String
    Private strAdr As String
    Private strTel As String

    Public Property ИД As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property
    Public Property Фамилия As String
        Get
            Return strFam
        End Get
        Set(value As String)
            strFam = value
        End Set
    End Property
    Public Property Имя As String
        Get
            Return strIm
        End Get
        Set(value As String)
            strIm = value
        End Set
    End Property
    Public Property Отчество As String
        Get
            Return strOtch
        End Get
        Set(value As String)
            strOtch = value
        End Set
    End Property
    Public Property ДатаРождения As String
        Get
            Return datDOB
        End Get
        Set(value As String)
            datDOB = value
        End Set
    End Property
    Public Property Адрес As String
        Get
            Return strAdr
        End Get
        Set(value As String)
            strAdr = value
        End Set
    End Property
    Public Property Телефон As String
        Get
            Return strTel
        End Get
        Set(value As String)
            strTel = value
        End Set
    End Property


    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strQuery As String = "SELECT * FROM Физические_лица WHERE Код_физического_лица =" & intID
            Dim intCount As Integer = 0

            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Фамилия = objDataReader.GetValue(1)
                        .Имя = objDataReader.GetValue(2)
                        .Отчество = objDataReader.GetValue(3)
                        .ДатаРождения = objDataReader.GetValue(4)
                        .Адрес = objDataReader.GetValue(5)
                        .Телефон = objDataReader.GetValue(6)
                    End With
                End While

                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Физические_лица", "Код_физического_лица") + 1
                .Фамилия = "(не указана)"
                .Имя = "(не указано)"
                .Отчество = "(не указано)"
                .ДатаРождения = Now.Date
                .Адрес = "(не указан)"
                .Телефон = "(не указан)"
            End With
        End If
    End Sub

    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
        Dim strQuery As String = "SELECT COUNT(*) FROM Физические_лица WHERE Код_физического_лица =" & intID
        Dim intCount As Integer = 0

        Try
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            While objDataReader.Read() = True
                intCount = objDataReader.GetValue(0)
            End While

            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If intCount > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Добавить(ByVal objFL As Физлицо) As Boolean
        Dim strQuery As String = "INSERT INTO Физические_лица(Код_физического_лица, Фамилия, Имя, Отчество, Дата_рождения, Адрес, Телефон) VALUES (" & objFL.ИД & ",'" & objFL.Фамилия & "','" & objFL.Имя & "','" & objFL.Отчество & "','" & objFL.ДатаРождения & "','" & objFL.Адрес & "','" & objFL.Телефон & "')"
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)

        Try

            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)

            With objCommand
                .Connection = objConnection
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка добавления элемента справочника", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

    Public Function Редактировать(ByVal objFL As Физлицо) As Boolean
        Dim strQuery As String = "UPDATE Физические_лица SET Фамилия = '" & objFL.Фамилия & "', Имя = '" & objFL.Имя & "', Отчество = '" & objFL.Отчество & "', Дата_рождения='" & objFL.ДатаРождения & "', Адрес = '" & objFL.Адрес & "', Телефон = '" & objFL.Телефон & "' WHERE Код_физического_лица = " & objFL.ИД
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)

        Try

            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)

            With objCommand
                .Connection = objConnection
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка редактирования элемента справочника", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

    Public Function Удалить(ByVal objFL As Физлицо) As Boolean
        Dim strQuery As String = "DELETE FROM Физические_лица WHERE Код_физического_лица = " & objFL.ИД
        Dim objConnection As New OleDb.OleDbConnection(strConnectionString)

        Try

            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)

            With objCommand
                .Connection = objConnection
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка при удалении элемента справочника", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

    Public Function ОтобразитьФИО(ByVal objFL As Физлицо) As String
        Dim strQuery As String = "SELECT * FROM Физические_лица WHERE Код_физического_лица =" & intID
        Dim intCount As Integer = 0
        Dim strFIO As String
        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
            objConnection.Open()
            Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
            Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

            While objDataReader.Read() = True
                With Me
                    .ИД = objDataReader.GetValue(0)
                    .Фамилия = objDataReader.GetValue(1)
                    .Имя = objDataReader.GetValue(2)
                    .Отчество = objDataReader.GetValue(3)
                    .ДатаРождения = objDataReader.GetValue(4)
                    .Адрес = objDataReader.GetValue(5)
                    .Телефон = objDataReader.GetValue(6)
                End With
            End While
            strFIO = Me.Фамилия & " " & Me.Имя.Substring(0, 1) & ". " & Me.Отчество.Substring(0, 1) & "."
            objDataReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            strFIO = vbNullString
        End Try
        Return strFIO
    End Function

End Class
