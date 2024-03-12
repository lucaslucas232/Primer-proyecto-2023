Public Class EJERCICIO4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True
        Label1.ForeColor = Color.Violet

        Dim LETRAS As String
        LETRAS = UCase(txt_numero.Text)

        If LETRAS = "A" Or LETRAS = "E" Or LETRAS = "I" Or LETRAS = "O" Or LETRAS = "U" Then
            Label1.Text = "VOCAl"
        Else
            Label1.Text = "CONSONANTE"
        End If

    End Sub

    Private Sub txt_numero_Click(sender As Object, e As EventArgs) Handles txt_numero.Click
        txt_numero.Text = ""
        txt_numero.ForeColor = Color.Black

    End Sub
End Class