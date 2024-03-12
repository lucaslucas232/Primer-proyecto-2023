Imports System.Net.Mail
Imports System.Threading
Imports System.ComponentModel

Public Class CORREO

    Dim Adjuntos() As String

    'instanciar la hebra
    Dim oHebra As Threading.Thread
    'Objeto SMTP
    Dim SMPT As New SmtpClient

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub Envio()
        'al finalizar el envío, abortar la hebra
        Control.CheckForIllegalCrossThreadCalls = False
        EnviarMail(TXT_DE.Text.Trim, TXT_PARA.Text, TXT_ASUNTO.Text, Adjuntos, Txt_Mensaje.Text)
        oHebra.Abort()
    End Sub
    Private Sub EnviarMail(ByVal StrDe As String, ByVal StrPara As String,
                           ByVal StrAsunto As String, ByVal sAdjunto() As String,
                           ByVal StrMensaje As String)
        Try
            'variable tipo mensaje con parametros De: Para:
            Dim Msg As New MailMessage(New MailAddress(StrDe), New MailAddress(StrPara))
            'asunto
            Msg.Subject = StrAsunto
            'mensaje
            Msg.Body = StrMensaje

            Msg.CC.Add(TXT_CC.Text)
            'Msg.Bcc.Add()

            'ADJUNTOS
            For Each FAdjunto As String In sAdjunto
                If Not FAdjunto = "" Then
                    'Objeto tipo attachment
                    Dim Adjunto As New Attachment(FAdjunto)
                    'agregar adjunto al objeto mensaje
                    Msg.Attachments.Add(Adjunto)
                End If
            Next

            'DATOS SMTP

            'Credenciales
            SMPT.Credentials = New System.Net.NetworkCredential(StrDe, TXT_PASSWORD.Text)
            'Host, Puerto, autenticacion
            ' SMPT.Host = "smtp.gmail.com"
            SMPT.Host = "smtp.office365.com"
            SMPT.Port = 587
            SMPT.EnableSsl = True
            SMPT.Timeout = 500000
            'Enviar
            SMPT.Send(Msg)

            'regresar cursor y controles a modo normal
            Me.Cursor = Cursors.Default
            BTN_ENVIAR.Enabled = True


        Catch ex As Exception
            'regresar cursor y controles a modo normal
            Me.Cursor = Cursors.Default
            BTN_ENVIAR.Enabled = True

            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CORREO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HelpProvider1.SetHelpString(TXT_DE, "Una dirección de correo válida debe tener el formato: alguien@microsoft.com")
        HelpProvider1.SetHelpString(TXT_PARA, "Una dirección de correo válida debe tener el formato: alguien@microsoft.com")

    End Sub


    Private Sub BTN_ADJUNTOS_Click(sender As Object, e As EventArgs) Handles BTN_ADJUNTOS.Click

        'para obtener adjuntos
        'establecemos filtros para mostrar todos los archivos
        OpenFileDialog1.Filter = "Todos los archivos|*.*"
        'mostramos el dialogo
        OpenFileDialog1.ShowDialog()
        'agregamos la ruta del adjunto
        CBO_ADJUNTOS.Items.Add(OpenFileDialog1.FileName)
        'visualizamos la ruta
        CBO_ADJUNTOS.SelectedIndex = CBO_ADJUNTOS.Items.Count - 1

    End Sub

    Private Sub BTN_ENVIAR_Click(sender As Object, e As EventArgs) Handles BTN_ENVIAR.Click

        Dim indice As Integer = 0
        Try

            ProgressBar1.Visible = True
            Label6.Visible = True 'enviando mail...
            Me.Cursor = Cursors.WaitCursor

            For i = 1 To 100
                ProgressBar1.Value = i
                Me.Refresh()
                My.Application.DoEvents()
            Next

            'obtenemos los adjuntos
            ReDim Preserve Adjuntos(0 To CBO_ADJUNTOS.Items.Count - 1)
            For i As Integer = 0 To Adjuntos.Length - 1
                Adjuntos(i) = CBO_ADJUNTOS.Items.Item(i).ToString
            Next

            BTN_ENVIAR.Enabled = False
            'poner en marcha la hebra

            oHebra = New Threading.Thread(AddressOf Envio)
            oHebra.Start()

            MsgBox("Listo...")
            ProgressBar1.Visible = False
            Label6.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BTN_CANCELA_Click(sender As Object, e As EventArgs) Handles BTN_CANCELA.Click

        SMPT.SendAsyncCancel()

    End Sub

    Private Sub BTN_FIN_Click(sender As Object, e As EventArgs) Handles BTN_FIN.Click
        Me.Close()

    End Sub

    Private Sub TXT_DE_Validating(sender As Object, e As CancelEventArgs) Handles TXT_DE.Validating

        'si la validación no pasa se visualiza el errorprovider
        If ValidateEmail(TXT_DE.Text.Trim) Then
            e.Cancel = False
            ErrorProvider1.SetError(TXT_DE, "")
        Else
            e.Cancel = True
            ErrorProvider1.SetError(TXT_DE, "La dirección de correo no es válida. Presione F1 para obtener ayuda.")
        End If

    End Sub
End Class