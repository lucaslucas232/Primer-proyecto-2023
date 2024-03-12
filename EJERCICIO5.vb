Public Class EJERCICIO5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = True

        Dim NRO1, NRO2, NRO3 As Byte
        Dim MAXIMO As Byte = 0

        NRO1 = Val(T1.Text)
        NRO2 = Val(T2.Text)
        NRO3 = Val(T3.Text)

        If NRO1 > MAXIMO Then
            MAXIMO = NRO1
        End If

        If NRO2 > MAXIMO Then
            MAXIMO = NRO2
        End If

        If NRO3 > MAXIMO Then
            MAXIMO = NRO3

        End If
        Label1.Text = "EL VALOR MAXIMO ES: " & MAXIMO

    End Sub

    Private Sub T1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub

    Private Sub T1_Click(sender As Object, e As EventArgs) Handles T1.Click
        T1.Text = ""
    End Sub

    Private Sub T2_Click(sender As Object, e As EventArgs) Handles T2.Click
        T2.Text = ""

    End Sub

    Private Sub T3_Click(sender As Object, e As EventArgs) Handles T3.Click
        T3.Text = ""

    End Sub

    Private Sub T1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T1.KeyPress
        T1.ForeColor = Color.Red

    End Sub
End Class