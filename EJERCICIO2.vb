Public Class EJERCICIO2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Visible = True

        Dim NUMERO As Integer
        Dim RESTO As Byte
        NUMERO = Val(txt_numero.Text)
        RESTO = NUMERO Mod 2

        If RESTO = 0 Then
            Label1.Text = "NUMERO PAR"
        Else
            Label1.Text = "NUMERO IMPAR"
        End If
    End Sub

    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged

    End Sub

    Private Sub txt_numero_Click(sender As Object, e As EventArgs) Handles txt_numero.Click
        txt_numero.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EJERCICIO2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class