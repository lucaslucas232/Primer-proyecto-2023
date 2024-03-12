Public Class JUEGO
    Dim DISTANCIA As Integer = 5
    Dim NIVEL As Byte
    Dim CONTADOR As Byte = 1
    Dim PUNTAJE As Byte
    Dim RESULTADO As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Top = Label4.Top + DISTANCIA

        If Label4.Top > Me.Height Then
            Label4.Top = -20

            If NIVEL = 1 Then
                GENERA_NUMEROS()
            ElseIf NIVEL = 2 Then
                GENERA_NUMEROS_INTERMEDIO()
            Else
                GENERA_NUMEROS_AVANZADO()
            End If


            CONTADOR = CONTADOR + 1
            If CONTADOR = 5 Then

                Button1.Enabled = True
                GroupBox1.Enabled = True
                BTN_NEW.Enabled = True
                Timer1.Stop()
                MessageBox.Show("FINISH")

            End If

        End If
    End Sub
    Sub GENERA_NUMEROS()
        Dim N1, N2 As Byte
        N1 = Int((10 - 1 + 1) * Rnd() + 1)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)
        Label4.Text = N1 & " * " & N2
        RESULTADO = N1 * N2
    End Sub
    Sub GENERA_NUMEROS_INTERMEDIO()

        Dim N1, N2 As Byte
        N1 = Int((15 - 5 + 1) * Rnd() + 5)  'formula = Int((LS - LI + 1) * Rnd() + LI)
        N2 = Int((15 - 5 + 1) * Rnd() + 5)
        Label4.Text = N1 & " * " & N2
        RESULTADO = N1 * N2
    End Sub
    Sub GENERA_NUMEROS_AVANZADO()
        Dim AUXILIAR As Integer
        Dim N1, N2, N3 As Byte
        N1 = Int((10 - 1 + 1) * Rnd() + 1)  'formula = Int((LS - LI + 1) * Rnd() + LI)
        N2 = Int((10 - 1 + 1) * Rnd() + 1)
        N3 = Int((4 - 1 + 1) * Rnd() + 1)

        Select Case N3
            Case 1
                Label4.Text = N1 & " + " & N2
                RESULTADO = N1 + N2
            Case 2

                If N1 < N2 Then
                    AUXILIAR = N1
                    N1 = N2
                    N2 = AUXILIAR
                End If
                Label4.Text = N1 & " - " & N2
                RESULTADO = N1 - N2
            Case 3
                Label4.Text = N1 & " * " & N2
                RESULTADO = N1 * N2
            Case 4
                N1 = N2 * Int((10 - 1 + 1) * Rnd() + 1)
                Label4.Text = N1 & " / " & N2
                RESULTADO = N1 / N2
        End Select



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            NIVEL = 1
            Timer1.Interval = 100
            GENERA_NUMEROS()
            Timer1.Enabled = True

        ElseIf RadioButton2.Checked Then
            NIVEL = 2
            Timer1.Interval = 60
            GENERA_NUMEROS_INTERMEDIO()
            Timer1.Enabled = True



        ElseIf RadioButton3.Checked Then
            NIVEL = 3
            Timer1.Interval = 40
            GENERA_NUMEROS_AVANZADO()
            Timer1.Enabled = True
        Else
            MessageBox.Show("ERROR, VERIFIQUE")
            Exit Sub
        End If

        Button1.Enabled = False
        GroupBox1.Enabled = False
        BTN_NEW.Enabled = False


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True


            If RESULTADO = Val(TextBox1.Text) Then
                PUNTAJE = PUNTAJE + 5
                LBL_PUNTAJE.Text = PUNTAJE
                TextBox1.SelectAll()
                Label4.Top = Me.Height + 5
            Else
                Label3.Visible = True
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then

            Label3.Visible = False

        End If

    End Sub

    Private Sub JUEGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        LBL_PUNTAJE.Text = 0
        PUNTAJE = 0
        TextBox1.Text = ""
        TextBox1.Focus()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        NIVEL = 0
        CONTADOR = 0
        GroupBox1.Enabled = True
        Label3.Visible = False




    End Sub
End Class
