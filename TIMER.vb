Public Class TIMER
    Dim DISTANCIA As Integer = 1
    Private Sub TIMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = TimeString

        'asigna la fecha del sistema
        Label2.Text = DateString

        Me.Text = "Fecha: " & Label2.Text & " - " & Label1.Text

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Left = Label3.Left + DISTANCIA

        If Label3.Left > Me.Width Then
            Label3.Left = -200

        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label5.Text = HScrollBar1.Value
        DISTANCIA = HScrollBar1.Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer2.Enabled = False Then
            DISTANCIA = 2
            Label5.Text = 2
            Timer2.Enabled = True

            Button1.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Iconos\switch-on-icon_34343.ICO")
        Else
            Timer2.Enabled = False
            Button1.Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Iconos\switch-off-icon_34344.ICO")
        End If
    End Sub
End Class