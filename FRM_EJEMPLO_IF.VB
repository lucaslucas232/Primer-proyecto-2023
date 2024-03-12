Public Class FRM_EJEMPLO_IF
    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Dim EDAD As Byte
        EDAD = Val(TXT_EDAD.Text)
        If EDAD >= 18 Then
            MessageBox.Show("COMPRA TODO!")
        Else
            MessageBox.Show("SIN ALCOHOL")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim EDAD As Byte
        EDAD = Val(TXT_EDAD.Text)

        If EDAD <= 12 Then
            LBL_OBSERVA.Text = "NIÑO"
        ElseIf EDAD < 18 Then
            LBL_OBSERVA.Text = "ADOLECENTE"
        Else
            LBL_OBSERVA.Text = "ADULTO"
        End If

        LBL_OBSERVA.Visible = True


    End Sub

    Private Sub TXT_EDAD_TextChanged(sender As Object, e As EventArgs) Handles TXT_EDAD.TextChanged

    End Sub

    Private Sub TXT_EDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_EDAD.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{tab}")
            '   BTN_OK1_Click(Nothing, Nothing)

            Button1_Click(Nothing, Nothing)

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EDAD As Byte
        EDAD = Val(TXT_EDAD.Text)

        If EDAD <= 12 Then
            LBL_OBSERVA.Text = "NIÑO"
        ElseIf EDAD < 18 Then
            LBL_OBSERVA.Text = "ADOLECENTE"
        Else
            LBL_OBSERVA.Text = "ADULTO"
        End If

        LBL_OBSERVA.Visible = True

        LBL_NOMBRE1.Text = UCase(TXT_NOMBRE.Text) & " " & UCase(TXT_APELLIDO.Text)

        LBL_NOMBRE1.Visible = True


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged

    End Sub
End Class