Public Class LISTBOX
    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
        If TextBox1.Text = "" Then
            MsgBox("Por favor escriba un color", , "Error")
            TextBox1.Text = InputBox("Listbox ?", "Ingrese un color..", "Verde_Esmeralda", 400, 400)
            TextBox1.Focus()
            Exit Sub
        End If

        If ListBox1.Items.Contains(UCase(Trim(TextBox1.Text))) Then
            MsgBox("Ya está escrito en el listbox1..")
            Exit Sub
        End If

        ListBox1.Items.Add(UCase(Trim(TextBox1.Text)))
        TextBox1.Focus() 'enviar  enfoque al textbox
        TextBox1.SelectAll()

    End Sub

    Private Sub BTN_ELIMINA1_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINA1.Click
        Try
            If ListBox1.SelectedIndex = -1 Then 'si hay algo seleccionado?
                MsgBox("ELIJA UN ELEMENTO DE LA LISTA PARA ELIMINAR")
                ListBox1.SelectedIndex = 0 ' selecciona el primero
                Exit Sub
            End If
            ListBox1.Items.Remove(ListBox1.SelectedItem)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_ELIMINA_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINA.Click
        Dim r As Byte
        If ListBox1.Items.Count > 0 Then
            r = MsgBox("Desea eliminar todos los colores? ", MsgBoxStyle.YesNo, "Atención")
            If r = vbYes Then
                ListBox1.Items.Clear()
            Else
                MsgBox("Ahhh ...", MsgBoxStyle.OkOnly, "Atención")
            End If
        Else
            MsgBox("sin elementos...")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim obj As Object
        Dim dias As String

        dias = "Dias Seleccionados: "
        For Each obj In CHKLST.CheckedItems
            dias = dias & vbCrLf & obj.ToString & " - "
        Next
        MsgBox(dias)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTN_RTRIM.Click
        TextBox1.Text = RTrim(TextBox1.Text)
        TextBox1.Focus()
        TextBox1.SelectAll()

    End Sub

    Private Sub BTN_LTRIM_Click(sender As Object, e As EventArgs) Handles BTN_LTRIM.Click

        TextBox1.Text = LTrim(TextBox1.Text) 'ELIMINA ESPACIOS A LA IZQ
        TextBox1.Focus()
        TextBox1.SelectAll()

    End Sub

    Private Sub BTN_TRIM_Click(sender As Object, e As EventArgs) Handles BTN_TRIM.Click
        TextBox1.Text = Trim(TextBox1.Text)
        TextBox1.Focus()
        TextBox1.SelectAll()

    End Sub

    Private Sub RADIOBUTTON1_CheckedChanged(sender As Object, e As EventArgs) Handles RADIOBUTTON1.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Left

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Right

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        With ListBox1

            MsgBox("Seleccionó el elemento " & .GetItemText(.SelectedItem) _
            & vbCrLf & " que está en la posición " & .SelectedIndex + 1, MsgBoxStyle.Information, "ATENCION")
        End With
    End Sub
End Class