Public Class TAREA_2_IVA
    Dim MONTO As Double
    Dim IVA As Double
    Dim RESULTADO As Double

    Private Sub CALCULA_Click(sender As Object, e As EventArgs) Handles CALCULA.Click
        If TXT_MONTO.Text = "" Then
            MessageBox.Show("Ingrese monto")
        End If

        MONTO = TXT_MONTO.Text
        IVA = TXT_MONTO.Text * 0.22
        LBL_RESULTADO.Text = MONTO + IVA

    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        TXT_MONTO.Text = ""
        TXT_MONTO.Focus()
        LBL_RESULTADO.Text = "0"

    End Sub
End Class