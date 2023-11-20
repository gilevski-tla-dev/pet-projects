Public Class Должность

    Public strConnectionString As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & strDBFileName

    Private intID As Integer
    Private strRank As String
    Private intQual As Integer
    Private dblZP As Double

    Public Property ИД() As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property
    Public Property Должность() As String
        Get
            Return strRank
        End Get
        Set(value As String)
            strRank = value
        End Set
    End Property
    Public Property Разряд() As Integer
        Get
            Return intQual
        End Get
        Set(value As Integer)
            intQual = value
        End Set
    End Property
    Public Property ЗаработнаяПлата() As Double
        Get
            Return dblZP
        End Get
        Set(value As Double)
            dblZP = value
        End Set
    End Property

    Public Sub New(ByVal intID As Integer)
        If ЕстьТакой(intID) = True Then
            Dim strQuery As String = "SELECT * FROM Должности WHERE Код_должности = " & intID

            Try
                Dim objConnection As New OleDb.OleDbConnection(strConnectionString)
                objConnection.Open()
                Dim objCommand As New OleDb.OleDbCommand(strQuery, objConnection)
                Dim objDataReader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)

                While objDataReader.Read() = True
                    With Me
                        .ИД = objDataReader.GetValue(0)
                        .Должность = objDataReader.GetValue(1)
                        .Разряд = objDataReader.GetValue(2)
                        .ЗаработнаяПлата = objDataReader.GetValue(3)
                    End With
                End While

                objDataReader.Close()
                objConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            With Me
                .ИД = MaxID("Должности", "Код_должности") + 1
                .Должность = "(не указана)"
                .Разряд = 0
                .ЗаработнаяПлата = 0
            End With
        End If
    End Sub

    Public Function ЕстьТакой(ByVal intID As Integer) As Boolean
        Dim strQuery As String = "SELECT COUNT(*) FROM Должности WHERE Код_должности = " & intID
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

    Public Function Добавить(ByVal objRank As Должность) As Boolean
        Dim strQuery As String = "INSERT INTO Должности(Код_должности, Должность, Разряд, Заработная_плата) VALUES (" & objRank.ИД & ",'" & objRank.Должность & "'," & objRank.Разряд & "," & objRank.ЗаработнаяПлата & ")"
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

    Public Function Редактировать(objRank As Должность) As Boolean
        Dim strQuery As String = "UPDATE Должности SET Должность = '" & objRank.Должность & "', Разряд = " & objRank.Разряд & ", Заработная_плата = " & objRank.ЗаработнаяПлата & " WHERE Код_должности = " & objRank.ИД
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

    Public Function Удалить(objRank As Должность) As Boolean
        Dim strQuery As String = "DELETE FROM Должности WHERE Код_должности = " & objRank.ИД
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
