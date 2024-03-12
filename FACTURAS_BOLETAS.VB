Public Class FACTURAS_BOLETAS
    Dim descuento As Double
    Dim subtotal As Double = 0
    Dim VALOR As Double
    Dim iva As Double
    Dim importe As Double = 0
    Dim redondeo As Double = 0
    Dim total1 As Double = 0
    Dim total As Double
    Dim A As Double
    Dim SUBTOTAL1 As Double
    Dim FILA_p_EDITAR As Double
    Private Function CHEQUEA_CODIGO(ByVal CODIGO As String) As Boolean
        Dim fila As Byte = 0
        Dim lista As ListViewItem = New ListViewItem()

        For Each lista In ListView1.Items

            'VER SI EXISE ESE CODIGO
            Dim Elemento As ListViewItem = ListView1.Items(fila)
            Dim cod As String = Elemento.SubItems(0).Text
            If CODIGO = cod Then
                Return True
                Exit Function
            End If

            fila += 1
        Next
        Return False
    End Function
    Private Sub BTN_AGREGA_Click(sender As Object, e As EventArgs) Handles BTN_AGREGA.Click
        Dim importe As Double = Val(TXT_PRECIO.Text) * Val(TXT_CANTIDAD.Text)

        Dim lista As ListViewItem = New ListViewItem(UCase(TXT_CODIGO.Text))

        If CHEQUEA_CODIGO(TXT_CODIGO.Text) = True Then
            MsgBox("EL CODIGO YA EXISTE")
            TXT_CODIGO.Focus()
            TXT_CODIGO.SelectAll()

            Exit Sub
        End If

        lista.SubItems.Add(UCase(TXT_PRODUCTO.Text))
        lista.SubItems.Add(TXT_PRECIO.Text)
        lista.SubItems.Add(TXT_CANTIDAD.Text)

        If Val(TXT_CANTIDAD.Text) >= 5 Then
            descuento = (Val(TXT_PRECIO.Text) * 10 / 100)
            lista.SubItems.Add(descuento.ToString)
            importe = importe - descuento
        Else
            lista.SubItems.Add(descuento.ToString)
        End If

        lista.SubItems.Add(importe.ToString)
        ListView1.Items.Add(lista)
        subtotal = subtotal + importe

        iva = (subtotal * 22) / 100
        '560.68  .....560.7
        subtotal = Math.Round(subtotal + iva, 2)
        total = Math.Round(subtotal + iva, 0)
        redondeo = total - subtotal

        LBL_SUBTOTAL.Text = Format(subtotal, "$u ##,##0.00")
        LBL_IVA.Text = Format(iva, "$u ##,##0.00")
        LBL_TOTAL.Text = Format(total, "$u ##,##0.00")
        LBL_REDONDEO.Text = Format(redondeo, "$u ##,##0.00")
        LBL_SUBTOTAL2.Text = Format(subtotal, "$u ##,##0.00")
    End Sub
    Private Sub TXT_CODIGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CODIGO.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TXT_PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRECIO.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_CANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANTIDAD.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_ELIMINA_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINA.Click
        Dim p As Boolean = False
        Dim redondeo As Double = 0
        Dim lista As ListViewItem = New ListViewItem()

        For Each lista In ListView1.CheckedItems
            lista.Remove()
            p = True
        Next

        If p = False Then
            MsgBox("Elija elemento a eliminar")
            Exit Sub
        End If

        'a --- acumula el importe de las lineas a eliminar
        subtotal = subtotal - A
        iva = (subtotal * 22) / 100
        total1 = Math.Round(subtotal + iva, 2)
        total = Math.Round(subtotal + iva, 1)
        redondeo = total - total1

        LBL_SUBTOTAL.Text = Format(subtotal, "$u ##,##0.00")
        LBL_IVA.Text = Format(iva, "$u ##,##0.00")
        LBL_TOTAL.Text = Format(total, "$u ##,##0.00")
        LBL_REDONDEO.Text = Format(redondeo, "$u ##,##0.00")
        LBL_SUBTOTAL2.Text = Format(total1, "$u ##,##0.00")
        A = 0

    End Sub
    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListView1.ItemCheck

        If (e.CurrentValue = CheckState.Unchecked) Then
            A = A + Val(ListView1.Items(e.Index).SubItems(5).Text)
            FILA_p_EDITAR = e.Index

        ElseIf (e.CurrentValue = CheckState.Checked) Then
            A = A - Val(ListView1.Items(e.Index).SubItems(5).Text)
        End If

    End Sub

    Private Sub LBL_SUBTOTAL_Click(sender As Object, e As EventArgs) Handles LBL_SUBTOTAL.Click

    End Sub
End Class