Imports System.Text.RegularExpressions

Public Class VISOR_DE_AGENDA

    Private Sub Buscar_Coincidencia(ByVal pattern As String, ByVal RichTextBox1 As RichTextBox, ByVal ccolor As Color, ByVal backcolor As Color) 'parametros, pattern es el patron que voy a buscar, sacado del textbox
        Dim r As Byte = 0

        Dim resultados As MatchCollection
        Dim palabra As Match

        Try
            Dim objeto As New Regex(pattern.ToString, RegexOptions.IgnoreCase) 'se ignoran las mayusculas y minusculas, regex busca coincidencias
            resultados = objeto.Matches(RichTextBox1.Text) 'en resultados se cargan todas las palabras que son iguales al patron que mando

            With RichTextBox1
                .SelectAll()
                .SelectionColor = Color.Black 'vuelve el color del texto al estado normal
                .SelectionBackColor = Color.White 'vuelve el color de fondo del texto al estado normal
            End With

            For Each palabra In resultados 'por cada palabra que conicida en resultado, selecciona la palabra y la pinta
                With RichTextBox1
                    .SelectionStart = palabra.Index 'desde donde va a empezar a seleccionar
                    .SelectionLength = palabra.Length ' el largo que va a seleccionar
                    .SelectionColor = ccolor 'cambia el color de la letra
                    .SelectionBackColor = backcolor 'cambia el color de fondo
                    ' Debug.Print(palabra.Value) 'monitorea el valor de las variables
                End With
                r = r + 1
            Next

            If r = 0 Then
                Label1.Visible = True
            Else
                Label1.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Buscar_Coincidencia(TextBox1.Text, RichTextBox1, Color.Blue, Color.Yellow)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Button2_Click(sender, e)
        End If
    End Sub

End Class