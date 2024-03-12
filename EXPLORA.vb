
Imports System.IO

Public Class EXPLORA
    Private Sub BUSCAIMAGENES(ByVal fsitemp As FileSystemInfo) 'fsitemp es una variable
        Try
            If fsitemp.GetType Is GetType(FileInfo) Then 'si lo que le pase en el procedimiento es el nombre de un archivo

                If fsitemp.Extension.ToUpper = ".JPG" Or fsitemp.Extension.ToUpper = ".PNG" Or fsitemp.Extension.ToUpper = ".gif" Then ' si la extension del archivo en mayusculas...
                    ListBox1.Items.Add(fsitemp.FullName) 'agrega el nombre completo del archivo en el listbox
                End If
            Else
                Dim dirtemp As New DirectoryInfo(fsitemp.FullName)
                Dim fsinew As FileSystemInfo
                Me.Text = "Buscando " & dirtemp.Name
                For Each fsinew In dirtemp.GetFileSystemInfos
                    Call BUSCAIMAGENES(fsinew)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BTN_EXAMINAR_Click(sender As Object, e As EventArgs) Handles BTN_EXAMINAR.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            Label1.Text = FolderBrowserDialog1.SelectedPath
            If Label1.Text = "" Then Label1.Text = "..."
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TXT_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Dim dirtemp As DirectoryInfo
        Dim ruta As String = My.Application.Info.DirectoryPath & "\iconos"
        Try
            ListBox1.Items.Clear()
            If Label1.Text = "..." Then
                dirtemp = New DirectoryInfo(ruta)
            Else
                dirtemp = New DirectoryInfo(Label1.Text)
            End If
            Call BUSCAIMAGENES(dirtemp) ' llamo el procedimiento findpictures con el directorio especificado
            dirtemp = Nothing
            'selecciona el primero

            If ListBox1.Items.Count = 0 Then
                MsgBox("sin imagenes...")
            Else
                ListBox1.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Pic.Image = Image.FromFile(ListBox1.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BTN_IZQ_Click(sender As Object, e As EventArgs) Handles BTN_IZQ.Click
        If ListBox1.SelectedIndex = 0 Then
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        Else
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        End If

    End Sub

    Private Sub BTN_DEREC_Click(sender As Object, e As EventArgs) Handles BTN_DEREC.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        Else
            ListBox1.SelectedIndex = 0
        End If

    End Sub



    Private Sub Pic_DoubleClick(sender As Object, e As EventArgs) Handles PIC.DoubleClick
        ZOOM.PictureBox1.Image = Me.PIC.Image
        ZOOM.ShowDialog()

    End Sub

    Private Sub BTN_FIN_Click(sender As Object, e As EventArgs) Handles BTN_FIN.Click
        Me.Close()

    End Sub


    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        '   BTN_BUSCAR Click(Nothing, Nothing)
        ListBox1.Focus()
    End Sub
End Class