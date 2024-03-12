Public Class ZOOM
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'ZOOM.PictureBox1.Image = Me.Pic.Image
        'ZOOM.Label1.Text = ListBox1.GetItemText(ListBox1.SelectedItem)

    End Sub

    Private Sub BTN_ADELANTE_Click(sender As Object, e As EventArgs) Handles BTN_ADELANTE.Click

        If EXPLORA.ListBox1.SelectedIndex < EXPLORA.ListBox1.Items.Count - 1 Then
            EXPLORA.ListBox1.SelectedIndex = EXPLORA.ListBox1.SelectedIndex + 1
        Else
            EXPLORA.ListBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub BTN_ATRAS_Click(sender As Object, e As EventArgs) Handles BTN_ATRAS.Click
        If EXPLORA.ListBox1.SelectedIndex = 0 Then
            EXPLORA.ListBox1.SelectedIndex = EXPLORA.ListBox1.Items.Count - 1
        Else
            EXPLORA.ListBox1.SelectedIndex = EXPLORA.ListBox1.SelectedIndex - 1
        End If
    End Sub
    Sub nombre_archivo()
        Dim c As String = ""
        Dim p As Byte
        Dim largo As Byte

        Dim n As String
        'alt izq+92 \   c:\fotos\cara.jpg

        largo = Len(Label1.Text)

        Do While largo > 1
            c = Mid(Label1.Text, largo, 1)
            If c = "\" Then
                p = largo
                largo = 1
            Else
                largo = largo - 1
            End If
        Loop

        p = Len(Label1.Text) - p
        'extrae n caracteres de la la parte derecha
        n = Microsoft.VisualBasic.Right(Label1.Text, p)
        Label1.Text = n

    End Sub
    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        nombre_archivo()
    End Sub
End Class