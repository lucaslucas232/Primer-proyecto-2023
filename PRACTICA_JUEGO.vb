Public Class PRACTICA_JUEGO
    Dim DISTANCIA As Byte = 10
    Dim NIVEL As Byte
    Dim CONTADOR As Byte = 1
    Dim RESULTADO As Integer
    Dim PUNTOS As Byte


    Sub GENERA_NUMERO()
        Dim N1, N2 As Byte
        N1 = Int((10 - 1 + 1) * Rnd() + 1)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)
        Label4.Text = N1 & " * " & N2 & " = "
        RESULTADO = N1 * N2

    End Sub
    Sub GENERA_NUMERO_INTERMEDIOS()
        Dim N1, N2 As Byte
        N1 = Int((15 - 5 + 1) * Rnd() + 1)
        N2 = Int((15 - 5 + 1) * Rnd() + 1)
        Label4.Text = N1 & " * " & N2 & " = "
        RESULTADO = N1 * N2
    End Sub
    Sub GENERA_NUMERO_AVANZADO()
        Dim N1, N2, N3 As Byte
        N1 = Int((10 - 1 + 1) * Rnd() + 1)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)
        N3 = Int((4 - 1 + 1) * Rnd() + 1)   '4: CANTIDAD DE OPERACIONES: +,*,/,-
        Select Case N3
            Case 1
                Label4.Text = N1 & " + " & N2 & " = "
                RESULTADO = N1 + N2
            Case 2       'RESTA!!
                If N2 > N1 Then
                    Label4.Text = N2 & " - " & N1
                    RESULTADO = N2 - N1

                Else
                    Label4.Text = N1 & " - " & N2
                    RESULTADO = N1 - N2

                End If
            Case 3
                Label4.Text = N1 & " * " & N2 & " = "
                RESULTADO = N1 * N2
            Case 4 'DIVISION EXACTA
                N1 = N2 * Int((10 - 1 + 1) * Rnd() + 1)
                Label4.Text = N1 & " / " & N2
                RESULTADO = N1 / N2

        End Select
        Label4.Text = N1 & " * " & N2 & " = "
        RESULTADO = N1 * N2
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Top = Label4.Top + DISTANCIA
        If Label4.Top > Me.Height Then
            Label4.Top = -50

            Select Case NIVEL
                Case 1
                    GENERA_NUMERO()
                Case 2
                    GENERA_NUMERO_INTERMEDIOS()
                Case 3
                    GENERA_NUMERO_AVANZADO()
            End Select
            CONTADOR = CONTADOR + 1
        End If

        If CONTADOR > 5 Then
            Timer1.Enabled = False
            MessageBox.Show("TERMINÓ")
            TextBox1.Enabled = False
            BTN_NEW.Enabled = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            NIVEL = 1
            GENERA_NUMERO()
            Timer1.Interval = 100

        ElseIf RadioButton2.Checked Then
            NIVEL = 2
            GENERA_NUMERO_INTERMEDIOS()
            Timer1.Interval = 60

        ElseIf RadioButton3.Checked Then
            NIVEL = 3
            GENERA_NUMERO_AVANZADO()
            Timer1.Interval = 40

        Else
            MessageBox.Show("ELIJA UN NIVEL")
            Exit Sub
        End If

        Timer1.Enabled = True
        Button1.Enabled = False
        TextBox1.Focus()
        BTN_NEW.Enabled = False
        GroupBox1.Enabled = False


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            If RESULTADO = Val(TextBox1.Text) Then
                PUNTOS = PUNTOS + 5
                LBL_PUNTAJE.Text = PUNTOS
                LBL_ERROR.Visible = False
                Label4.Top = Me.Height + 5
                LBL_PUNTAJE.Text = PUNTOS.ToString
            Else
                LBL_ERROR.Visible = True

            End If
            TextBox1.SelectAll()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            LBL_ERROR.Visible = False

        End If
    End Sub

    Private Sub PRACTICA_JUEGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        PUNTOS = 0
        CONTADOR = 0
        NIVEL = 0
        RESULTADO = 0
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        LBL_ERROR.Visible = False
        LBL_PUNTAJE.Text = "0"
        Button1.Enabled = True
        TextBox1.Text = " "
        TextBox1.Enabled = True
        TextBox1.Focus()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class