Public Class EJERCICIO1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True

        Dim numero As Integer
        numero = Val(txt_numero.Text)

        If numero = 0 Then
            Label1.Text = "el numero es cero"
        ElseIf numero < 0 Then
            Label1.Text = "el numero es negativo"
        Else
            Label1.Text = "el numero es postivio"
        End If
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged

    End Sub

    Private Sub txt_numero_Click(sender As Object, e As EventArgs) Handles txt_numero.Click
        txt_numero.Text = ""

    End Sub
End Class