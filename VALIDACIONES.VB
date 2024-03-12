Imports System.Text.RegularExpressions

Public Class VALIDACIONES
    Dim user As String
    Dim ruta As String = My.Application.Info.DirectoryPath & "\textos"

    Private Sub VALIDACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DTP1.Format = DateTimePickerFormat.Custom
        ' DTP1.CustomFormat = "MMMM"

    End Sub
    Private Function valida_ci(ByVal cedula As String) As Boolean
        'ARRAY()
        Dim clave(7) As Byte
        Dim a As String
        Dim b As String
        Dim c As Double
        Dim d As Byte
        Dim i As Byte
        'txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        If cedula.Length < 8 Then
            MsgBox("Cédula incompleta", MsgBoxStyle.Exclamation, "Error")
            TXT_CI.Focus() : TXT_CI.SelectAll()
            Return False
            Exit Function
        Else
            clave(1) = 2
            clave(2) = 9
            clave(3) = 8
            clave(4) = 7
            clave(5) = 6
            clave(6) = 3
            clave(7) = 4
            c = 0
            For i = 1 To 7
                'txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                'extrae 1 caracter de una cadena de caracteres
                a = Mid(cedula, i, 1)
                b = a * clave(i)
                c = c + Val(Mid(b, Len(b), 1))
            Next i
            If Val(Mid(c, 2, 1)) = 0 Then
                d = 0
            Else
                d = 10 - Val(Mid(c, 2, 1))
            End If

            If d <> Mid(cedula, 8, 1) Then
                Return False
                MsgBox("Cédula incorrecta", MsgBoxStyle.Exclamation, "Error")
                TXT_CI.Focus()
                TXT_CI.Select(10, 1)
                Exit Function
            End If
            Return True
        End If
    End Function
    Private Function validar_mail(ByVal smail As String) As Boolean
        Return Regex.IsMatch(smail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub limpiarcajas(ByVal f As Form)
        For Each h As Control In f.Controls
            If TypeOf h Is TextBox Then
                h.Text = ""
            End If

            If TypeOf h Is MaskedTextBox Then
                h.Text = ""
            End If
        Next
    End Sub

    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click

        Try
            'Nombre
            If TXT_NOMBRE.Text = "" Then
                MsgBox("Nombre incompleto", MsgBoxStyle.Exclamation, "Error")
                TXT_NOMBRE.Focus()
                Exit Sub
            End If
            TXT_NOMBRE.Text = Trim(TXT_NOMBRE.Text) 'elimina espacios en blanco
            'StrConv --convierte la primer letra en mayus..
            Me.TXT_NOMBRE.Text = StrConv(Me.TXT_NOMBRE.Text, VbStrConv.ProperCase)
            'Apellido
            If TXTAPELLIDO.Text = "" Then
                MsgBox("Apellido incompleto", MsgBoxStyle.Exclamation, "Error")
                TXTAPELLIDO.Focus()
                Exit Sub
            End If
            TXTAPELLIDO.Text = Trim(TXTAPELLIDO.Text)
            Me.TXTAPELLIDO.Text = StrConv(Me.TXTAPELLIDO.Text, VbStrConv.ProperCase)
            'Teléfono
            If TXT_TEL.Text = "" Then
                MsgBox("Teléfono incompleto", MsgBoxStyle.Exclamation, "Error")
                TXT_TEL.Focus()
                Exit Sub
            End If
            TXT_TEL.Text = Trim(TXT_TEL.Text)
            'Fecha Nac.
            Dim fecha As String
            fecha = Format(DateTime.Now, "MM/dd/yyyy").ToString

            Dim dbledad As Double = DateTime.Now.Subtract(DTP1.Text).TotalDays / 365.25
            If dbledad < 0 Or dbledad > 120 Then
                MsgBox("Fecha de nacimiento incorrecta", MsgBoxStyle.Exclamation, "Error")
                DTP1.Focus()
                Exit Sub
            End If

            'EXCLUYA LA MASCARA... (3.258.698-7)  CEDULA SIN MASCARA (32586987)
            TXT_CI.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

            If valida_ci(TXT_CI.Text) = True Then
                MsgBox("ci correcta")
            Else
                MsgBox("ci incorrecta...")
                Exit Sub
            End If

            TXT_CI.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

            'E-Mail***************************
            Dim smail As String
            TXT_MAIL.Text = Trim(TXT_MAIL.Text)
            smail = TXT_MAIL.Text
            If Len(smail) > 0 Then
                If validar_mail(smail) = False Then
                    MsgBox("Dirección e-mail incorrecta", MsgBoxStyle.Exclamation, "Error")
                    TXT_MAIL.Focus()
                    TXT_MAIL.SelectAll()
                    Exit Sub
                End If
            Else
                MsgBox("Escriba la dirección e-mail", MsgBoxStyle.Exclamation, "Error")
                TXT_MAIL.Focus()
                Exit Sub
            End If

            If TXT_CONTRASEÑA.Text = "" Then
                MsgBox("Contraseña incompleta", MsgBoxStyle.Exclamation, "Error")
                TXT_CONTRASEÑA.Focus()
                Exit Sub
            End If
            'Escribe


            My.Computer.FileSystem.WriteAllText(ruta & "\Agenda.txt", TXT_NOMBRE.Text & " " & TXTAPELLIDO.Text & " - " & TXT_TEL.Text & " - " & DTP1.Text & " - " & TXT_CI.Text & " - " & TXT_MAIL.Text & " - " & TXT_CONTRASEÑA.Text & vbCrLf, True) 'true agrega al final
            MsgBox("Información agregada", MsgBoxStyle.Information, "Información")

            'llama al procedimiento que limpia cajas de texto
            limpiarcajas(Me)
            TXT_NOMBRE.Focus()

        Catch ex As Exception
            MsgBox(ex.InnerException, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged

    End Sub

    Private Sub TXT_NOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOMBRE.KeyPress

        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz " & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub BTN_VER_Click(sender As Object, e As EventArgs) Handles BTN_VER.Click

        Try
            VISOR_DE_AGENDA.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(ruta & "\Agenda.txt")

            VISOR_DE_AGENDA.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub TXT_CI_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TXT_CI.MaskInputRejected

    End Sub
End Class