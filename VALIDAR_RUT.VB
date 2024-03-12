Public Class VALIDAR_RUT
    Private Sub BTN_1_Click(sender As Object, e As EventArgs) Handles BTN_1.Click

        MaskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If valida_rut(MaskedTextBox1.Text) Then
            MsgBox("rut valido")
        Else
            MsgBox("Rut incorrecto", MsgBoxStyle.Exclamation, "Error")
            MaskedTextBox1.Focus()
            MaskedTextBox1.Select(15, 1)
        End If



    End Sub

    Private Function valida_rut(ByVal rut As String) As Boolean

        '3399486
        '        Ej. el rut de antel 
        '| 2 | 1 | 1 | 0 | 0 | 3 | 4 | 2 | 0 | 0 | 1 | 7
        '| 4 | 3 | 2 | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
        '| 8 | 3 | 2 | 0 | 0 |21 |24 |10 | 0 | 0 | 2 |= 70

        ' el resto de 70 / 11 = 4

        'digito verif. = 11 - 4 = 7 


        Dim clave(11) As Byte : Dim a As String : Dim b As String : Dim c As Double
        Dim d As Byte

        Dim i As Integer

        'txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        If rut.Length < 12 Then
            MsgBox("Rut incompleto", MsgBoxStyle.Exclamation, "Error")
            MaskedTextBox1.Focus() : MaskedTextBox1.SelectAll()
            Return False
            Exit Function
        Else
            clave(11) = 2 : clave(10) = 3 : clave(9) = 4 : clave(8) = 5
            clave(7) = 6 : clave(6) = 7 : clave(5) = 8 : clave(4) = 9
            clave(3) = 2 : clave(2) = 3 : clave(1) = 4

            c = 0
            For i = 11 To 1 Step -1
                a = Mid(rut, i, 1)
                b = a * clave(i)
                c = c + b
            Next i

            Dim r As Byte
            r = c Mod 11
            d = 11 - r

            If d <> Mid(rut, 12, 1) Then
                Return False
                Exit Function
            End If

            Return True

        End If

    End Function



    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
        End If

    End Sub
End Class