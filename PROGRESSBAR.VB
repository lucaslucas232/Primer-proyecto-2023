Public Class PROGRESSBAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_COMINZA.Click
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If

        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            BTN_COMINZA.Text = "Detiene"
        Else
            If BTN_COMINZA.Text = "Detiene" Then
                BTN_COMINZA.Text = "Continua"
                Timer1.Enabled = False
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        Label1.Text = ProgressBar1.Value.ToString & " % completado."
        StatusBar1.Text = ProgressBar1.Value.ToString & " % completado"

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop() ' = timer1.enabled=false
            BTN_COMINZA.Text = "Comienza"
        End If

    End Sub
End Class