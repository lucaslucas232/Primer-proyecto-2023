Public Class TAREA
    Dim CONTADOR As Integer
    Dim LS As Byte = 9
    Dim LI As Byte = 1

    Private Sub BTN_COMIENZA_Click(sender As Object, e As EventArgs) Handles BTN_COMIENZA.Click
        CONTADOR = 5
        LBL_SEGUNDOS.Text = CONTADOR
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CONTADOR = CONTADOR - 1
        LBL_SEGUNDOS.Text = CONTADOR

        If CONTADOR = 0 Then
            MessageBox.Show("FIN")
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        LBL_NUM1.Text = Int((9 - 1 + 1) * Rnd() + LI)
        LBL_NUM2.Text = Int((9 - 1 + 1) * Rnd() + LI)
        LBL_NUM3.Text = Int((9 - 1 + 1) * Rnd() + LI)

        If LBL_NUM1.Text = LBL_NUM2.Text And LBL_NUM1.Text = LBL_NUM3.Text Then
            MessageBox.Show("GANASTE")
        End If

    End Sub
End Class