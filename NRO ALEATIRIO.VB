Public Class NRO_ALEATIRIO
    Dim R As Integer
    Dim CONTADOR As Byte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LS As Byte = 6
        Dim LI As Byte = 1
        Dim NUMERO As Byte = 0
        NUMERO = Int((LS - LI + 1) * Rnd() + LI)

        Label1.Text = NUMERO.ToString

        PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\1.JPG")
        Select Case NUMERO
            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\1.JPG")
            Case 2
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\2.JPG")
            Case 3
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\3.JPG")
            Case 4
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\4.JPG")
            Case 5
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\5.JPG")
            Case 6
                PictureBox1.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\ICONOS\6.JPG")
        End Select
    End Sub

    Private Sub NRO_ALEATIRIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LS As Byte = 20
        Dim LI As Byte = 1
        Dim NUMERO1 As Integer = 0
        Dim NUMERO2 As Integer = 0
        Dim NUMERO3 As Integer = 0

        CONTADOR = CONTADOR + 1
        If CONTADOR = 10 Then
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                MessageBox.Show("FIN")
                Button3.Visible = True
                Button2.Visible = False
                Button1.Visible = False
            Else
                CONTADOR = 0
            End If
        End If
        NUMERO1 = Int((LS - LI + 1) * Rnd() + LI)
        NUMERO2 = Int((LS - LI + 1) * Rnd() + LI)
        NUMERO3 = Int((4 - 1 + 1) * Rnd() + LI)

        TextBox1.Text = NUMERO1.ToString
        TextBox2.Text = NUMERO2.ToString
        TextBox3.Text = ""

        Select Case NUMERO3
            Case 1
                Label2.Text = "+"
                R = NUMERO1 + NUMERO2
            Case 2
                Dim AUXILIAR As Integer

                Label2.Text = "-"

                If NUMERO1 < NUMERO2 Then
                    AUXILIAR = NUMERO2
                    NUMERO2 = NUMERO1
                    NUMERO1 = AUXILIAR

                    TextBox1.Text = NUMERO1.ToString
                    TextBox2.Text = NUMERO2.ToString
                End If

                R = NUMERO1 - NUMERO2
            Case 3
                Label2.Text = "*"
                R = NUMERO1 * NUMERO2
            Case 4
                Label2.Text = "/"

                NUMERO1 = NUMERO2 * Int((3 - 1 + 1) * Rnd() + 1)
                TextBox1.Text = NUMERO1.ToString
                R = NUMERO1 / NUMERO2
        End Select

        Label4.Text = ""
        TextBox3.Focus()
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True

            If R = Val(TextBox3.Text) Then
                Label4.Text = "CORRECTO"
                TextBox3.SelectAll()
            Else
                Label4.Text = "INCORRECTO"
                TextBox3.SelectAll()
            End If
        End If
    End Sub
End Class
