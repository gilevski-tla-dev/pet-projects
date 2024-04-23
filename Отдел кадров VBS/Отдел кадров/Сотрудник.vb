Public Class Сотрудник

    Public strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName

    Private intID As Integer
    Private objRank As Должность
    Private objFL As Физлицо
    Private dblRating As Double
    Private datPriem As Date
    Private datUvol As Date

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property
    Public Property Должность() As Должность
        Get
            Return objRank
        End Get
        Set(value As Должность)
            objRank = value
        End Set
    End Property
    Public Property Физлицо() As Физлицо
        Get
            Return objFL
        End Get
        Set(value As Физлицо)
            objFL = value
        End Set
    End Property
    Public Property Рейтинг() As Double
        Get
            Return dblRating
        End Get
        Set(value As Double)
            dblRating = value
        End Set
    End Property
    Public Property ДатаПриема() As Date
        Get
            Return datPriem
        End Get
        Set(value As Date)
            datPriem = value
        End Set
    End Property
    Public Property ДатаУвольнения() As Date
        Get
            Return datUvol
        End Get
        Set(value As Date)
            datUvol = value
        End Set
    End Property

    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strQuery As String = "SELECT * FROM Сотрудники WHERE Код_сотрудника = " & intID

            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)
                'Dim datHasValue As Nullable(Of Date)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Должность = New Должность(objDataReader.GetValue(1))
                        .Физлицо = New Физлицо(objDataReader.GetValue(2))
                        .Рейтинг = objDataReader.GetValue(3)
                        .ДатаПриема = objDataReader.GetValue(4)
                        'datHasValue = objDataReader.GetValue(5)
                        'If datHasValue.HasValue = True Then
                        '    .ДатаУвольнения = objDataReader.GetValue(5)
                        'Else
                        '    .ДатаУвольнения = ""
                        '    End If
                    End With
                End While

                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                    .ИД = MaxID("Сотрудники", "Код_сотрудника") + 1
                    .Должность = New Должность(0)
                    .Физлицо = New Физлицо(0)
                    .Рейтинг = 0
                    .ДатаПриема = Now.Date
                    .ДатаУвольнения = Now.Date
                End With
        End If
    End Sub

    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strQuery As String = "SELECT COUNT(*) FROM Сотрудники WHERE Код_сотрудника = " & intID
        Dim intCount As Integer = 0

        Try
            Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
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

    Public Function Добавить(ByVal objWorker As Сотрудник) As Boolean
        Dim strQuery As String = "INSERT INTO Сотрудники(Код_сотрудники, Код_должности, Код_физического_лица, Рейтинг, Дата_приема, Дата_увольнения) VALUES (" & objWorker.ИД & "," & objWorker.Должность.ИД & "," & objWorker.Физлицо.ИД & "," & objWorker.Рейтинг & ",'" & objWorker.ДатаПриема & "','" & objWorker.ДатаУвольнения & "')"
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
            MessageBox.Show(ex.Message, "Ошибка добавления элемента к справочнику", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            objConnection.Close()
        End Try
    End Function

    Public Function Редактировать(objWorker As Сотрудник) As Boolean
        Dim strQuery As String = "UPDATE Сотрудники SET Код_должности = " & objWorker.Должность.ИД & ", Код_физического_лица = " & objWorker.Физлицо.ИД & ", Рейтинг = " & objWorker.Рейтинг & ", Дата приема = '" & objWorker.ДатаПриема & "', Дата_увольнения = '" & objWorker.ДатаУвольнения & "' WHERE Код_сотрудника = " & objWorker.ИД
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

    Public Function Удалить(objWorker As Сотрудник) As Boolean
        Dim strQuery As String = "DELETE FROM Сотрудники WHERE Код_сотрудника = " & objWorker.ИД
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

End Class
