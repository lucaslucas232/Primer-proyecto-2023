Public Class FOR_NEXT
    Dim I As Byte
    Dim X As Byte = 0
    Dim RESULTADO As Byte = 0
    Dim CUENTA As String = "" 'INICIALIZA EN NADA

    Private Sub BTN_GENERAR_Click(sender As Object, e As EventArgs) Handles BTN_GENERAR.Click
        'LST_1.Items.Clear()
        X = Val(TXT_1.Text)

        If (X > 10 Or X = 0) Then
            MessageBox.Show("INGRESE NÚMERO DEL 1 AL 10")
            Exit Sub

        End If

        If TXT_1.Text = "" Then
            MessageBox.Show("INGRESE NUMERO")
            TXT_1.Focus()
            Exit Sub

        End If
        For I = 1 To 10 'Step 2 VA DE 2 EN 2
            ' LST_1.Items.Add(I)
            RESULTADO = I * X
            CUENTA = I & " * " & X & " = " & RESULTADO
            '  LST_1.Items.Add(CUENTA)
        Next
    End Sub

    Private Sub TXT_1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_1.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If

    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click
        TXT_1.Text = ""
        TXT_1.Focus()
        LST_1.Items.Clear()
        RESULTADO = 0
        CUENTA = 0
        X = 0
    End Sub

    Private Sub BTN_FIN_Click(sender As Object, e As EventArgs) Handles BTN_FIN.Click
        FORM_PRUEBA.ShowDialog()


    End Sub
End Class