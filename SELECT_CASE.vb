Public Class Form1

    Private Sub BTN_CALCULAR_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR.Click
        Dim CATEGORIA As Char
        Dim CANTIDAD As Integer
        Dim PRECIOUNITARIO As Double
        Dim PRECIOTOTAL As Double

        CATEGORIA = CBO_CATEGORIA.Text
        CANTIDAD = Integer.Parse(TXT_CANTIDAD.Text)
        PRECIOUNITARIO = Double.Parse(TXT_PRECIO.Text)

        Select Case CATEGORIA
            Case "A", "a"
                PRECIOTOTAL = CANTIDAD * PRECIOUNITARIO
            Case "B", "b"
                PRECIOTOTAL = CANTIDAD * PRECIOUNITARIO * 0.95
            Case "C", "c"
                PRECIOTOTAL = CANTIDAD * PRECIOUNITARIO * 0.9
            Case "D", "d"
                PRECIOTOTAL = CANTIDAD * PRECIOUNITARIO * 1.1
            Case Else
                MessageBox.Show("Error... verifique")
                Exit Sub
        End Select

        LBL_TOTAL.Text = "Precio total: $" & PRECIOTOTAL
    End Sub
End Class