Public Class EJERCICIO6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EDAD As Byte

        If TextBox3.Text = "" Then
            MessageBox.Show("ERROR INGRESE EDAD")
            TextBox3.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MessageBox.Show("ERROR INGRESE APELLIDO")
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox1.Text = "" Then
            MessageBox.Show("ERROR INGRESE NOMBRE")
            TextBox1.Focus()
            Exit Sub

        End If
        EDAD = Val(TextBox3.Text)

        Dim NOM_COMP As String
        NOM_COMP = UCase(TextBox1.Text) & " " & UCase(TextBox2.Text)

        If EDAD <= 18 Then
            LBL_OBSERVA.Text = "Lo siento, " & NOM_COMP & ", eres menor de edad y no puedes acceder"
        Else
            LBL_OBSERVA.Text = "Bienvenido(a), " & NOM_COMP
        End If

        LBL_OBSERVA.Visible = True

    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            'SendKeys.Send("{tab}")

            Button1_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{tab}")
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{tab}")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        LBL_OBSERVA.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub EJERCICIO6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class