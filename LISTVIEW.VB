Public Class LISTVIEW
    Dim PROMEDIO As Double = 0
    Dim C As Byte = 0
    Dim FILA As Byte = 0

    Dim LS As Byte = 12
    Dim LI As Byte = 1
    Private Sub BTN_AGREGA_Click(sender As Object, e As EventArgs) Handles BTN_AGREGA.Click
        'UCASE > PONE EN MAYUSCULAS
        Dim lista As ListViewItem = New ListViewItem(UCase(TXT_NOMBRE.Text))
        lista.SubItems.Add(UCase(TXT_APELLIDO.Text))
        lista.SubItems.Add(TXT_NOTA.Text)

        If Val(TXT_NOTA.Text) > 5 Then
            lista.SubItems.Add("Aprueba")
        Else
            lista.SubItems.Add("Recursa")
        End If

        If Val(TXT_NOTA.Text) > 12 Or Val(TXT_NOTA.Text) < 1 Then
            MessageBox.Show("ATENCION LAS NOTAS VAN ENTRE 1 Y 12")
            Exit Sub
        End If
        If TXT_NOMBRE.Text = "" Or TXT_APELLIDO.Text = "" Then
            MessageBox.Show("ATENCION NOM O APELL ESTA VACIO..")
            Exit Sub
        End If
        ListView1.Items.Add(lista)
    End Sub

    Private Sub BTN_ELIMINA_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINA.Click
        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In ListView1.SelectedItems
            lista.Remove()
        Next

    End Sub

    Private Sub BTN_LIMPIA_Click(sender As Object, e As EventArgs) Handles BTN_LIMPIA.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub BTN_FIN_Click(sender As Object, e As EventArgs) Handles BTN_FIN.Click
        Me.Close()

    End Sub

    Private Sub BTN_CARGA_Click(sender As Object, e As EventArgs) Handles BTN_CARGA.Click
        ListView1.Items.Clear()

        For I = 1 To 10
            TXT_NOMBRE.Text = I
            TXT_APELLIDO.Text = I & " " & I
            TXT_NOTA.Text = Int((LS - LI + 1) * Rnd() + LI)
            Dim lista As New ListViewItem(UCase(TXT_NOMBRE.Text))
            lista.SubItems.Add(UCase(TXT_APELLIDO.Text))
            lista.SubItems.Add(TXT_NOTA.Text)

            If Val(TXT_NOTA.Text) > 5 Then
                lista.SubItems.Add("Aprueba")
            Else
                lista.SubItems.Add("Recursa")
            End If

            ListView1.Items.Add(lista)

            TXT_NOMBRE.Text = ""
            TXT_APELLIDO.Text = ""
            TXT_NOTA.Text = ""
        Next
    End Sub

    Private Sub LISTVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub BTN_PROMEDIO_Click(sender As Object, e As EventArgs) Handles BTN_PROMEDIO.Click
        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In ListView1.Items
            Dim PRIMERELEMNTO As ListViewItem = ListView1.Items(FILA)
            Dim NOTA As Byte = PRIMERELEMNTO.SubItems(2).Text

            PROMEDIO = PROMEDIO + NOTA
            C = C + 1
            FILA = FILA + 1

        Next
        LBL_PROMEDIO.Text = Val(PROMEDIO / C).ToString

    End Sub

End Class