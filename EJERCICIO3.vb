Public Class EJERCICIO3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True


        Dim EDAD As Byte
        EDAD = Val(txt_numero.Text)

        If EDAD >= 18 Then
            Label1.Text = "ERES MAYOR DE EDAD"
        Else
            Label1.Text = "ERES MENOR DE EDAD"

        End If



    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged

    End Sub

    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txt_numero_Click(sender As Object, e As EventArgs) Handles txt_numero.Click
        txt_numero.Text = ""
        txt_numero.ForeColor = Color.Blue


    End Sub
End Class