Public Class frmMain

    Private Sub mnuLabsFLs_Click(sender As Object, e As EventArgs) Handles mnuLabsFLs.Click
        With frmFLList
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Отдел кадров"
        tslTitle.Text = "Подождите, идет соединение с БД..."
        tmrTime.Enabled = True
        tmrProgress.Enabled = True
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        tslDateTime.Text = Now
    End Sub

    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        If tpbProgress.Value < tpbProgress.Maximum Then
            tpbProgress.Increment(10)
        Else
            tslTitle.Text = "Готово"
            tpbProgress.Value = 0
            tmrProgress.Enabled = False
        End If

    End Sub
End Class
