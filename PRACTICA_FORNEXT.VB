Public Class PRACTICA_FORNEXT
    Dim I As Byte
    Dim N1, N2 As Byte
    Dim AUXILIAR As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For I = 1 To 10
            ListBox1.Items.Add(I)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        N1 = Int((10 - 1 + 1) * Rnd() + 1)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)
        TextBox1.Text = N1
        TextBox2.Text = N2
        LST_PAR.Items.Clear()
        LST_IMPAR.Items.Clear()

        If N1 > N2 Then
            AUXILIAR = N2
            N2 = N1
            N1 = AUXILIAR
        End If

        For I = N1 To N2

            If I Mod 2 = 0 Then
                LST_PAR.Items.Add(I)
            Else
                LST_IMPAR.Items.Add(I)
            End If
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        N1 = Int((10 - 1 + 1) * Rnd() + 1)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)
        TextBox1.Text = N1
        TextBox2.Text = N2
        ListBox1.Items.Clear()

        If N1 > N2 Then
            AUXILIAR = N2
            N2 = N1
            N1 = AUXILIAR
        End If

        For I = N1 To N2
            ListBox1.Items.Add(I)
        Next



    End Sub
End Class