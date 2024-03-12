Public Class DO_WHILE
    Private Sub BTN_RIGHT_Click(sender As Object, e As EventArgs) Handles BTN_RIGHT.Click
        Dim A As String

        A = Microsoft.VisualBasic.Right(TextBox1.Text, NumericUpDown1.Value)
        MsgBox(A)
    End Sub

    Private Sub BTN_LEFT_Click(sender As Object, e As EventArgs) Handles BTN_LEFT.Click
        Dim A As String
        A = Microsoft.VisualBasic.Left(TextBox1.Text, NumericUpDown1.Value)
        MsgBox(A)
    End Sub

    Private Sub BTN_DOWHILE_Click(sender As Object, e As EventArgs) Handles BTN_DOWHILE.Click
        Dim c As String = ""
        Dim p As Byte
        Dim largo As Byte = Len(TextBox1.Text)
        Dim n As String

        'alt izq+92 \   c:\fotos\cara.jpg
        Try

            Do While c <> "\"
                'mid...extrae n caracteres de una cadena
                c = Mid(TextBox1.Text, largo, 1)
                If c = "\" Then
                    p = largo
                Else
                    largo = largo - 1
                End If
            Loop

            p = Len(TextBox1.Text) - p

            'extrae n caracteres de la la parte derecha
            n = Microsoft.VisualBasic.Right(TextBox1.Text, p)

            Label4.Text = UCase(n)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class