Imports System.Data.OleDb

Public Class NUEVO_USUARIO
    Dim toco_foto As Boolean = False
    Dim ruta_imagen As String = My.Application.Info.DirectoryPath & "\fotos.png"
    Dim obj_usuario As New CLS_USUARIO
    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
    Dim id As Integer
    Private txtUsuario As Object

    Sub ModoModificacion()
        BTN_AGREGAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_MODIFICAR.Enabled = True
        BTN_CANCELAR.Enabled = True
    End Sub

    Sub LimpiarCampos()
        TXT_NOMBRE.Text = ""
        TXT_APELLIDO.Text = ""
        txt_USUARIO.Text = ""
        TXT_NOMBRE.Focus()
    End Sub

    Sub ModoInsercion()
        BTN_CANCELAR.Enabled = True
        BTN_NUEVO.Enabled = True
        BTN_ELIMINAR.Enabled = False
        BTN_MODIFICAR.Enabled = True
        BTN_AGREGAR.Enabled = True
    End Sub

    Function ValidarDatos() As Boolean

        If TXT_NOMBRE.Text.Trim = "" Then
            MsgBox("error en el nombre...")
            TXT_NOMBRE.Focus()
            Return False
            Exit Function
        End If

        If TXT_APELLIDO.Text.Trim = "" Then
            MsgBox("error en el apellido...")
            TXT_APELLIDO.Focus()
            Return False
            Exit Function
        End If

        If txt_USUARIO.Text.Trim = "" Then
            MsgBox("error en el usuario...")
            txtUsuario.Focus()
            Return False
            Exit Function
        End If
        'preguntar por la foto...si tiene la foto del comienzo....le tengo q decir elija foto...
        If TXT_CONTRASEÑA.Text.Trim = "" Then
            MsgBox("error en el usuario...")
            txtUsuario.Focus()
            Return False
            Exit Function
        End If

        If toco_foto = False Then
            MsgBox("error no eligio una foto...")
            Return False
            Exit Function
        End If

        Return True
    End Function


    Function ObtenerCampo(ByVal grilla As DataGridView, ByVal indice_columna As Byte)
        Try
            If Not IsDBNull(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value) Then
                Return CStr(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub NUEVO_USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ini = 0
        ActualizarTabla(Me.DGV1, "usuarios", "", "APELLIDO") 'tabla ususarios ordenado por apellido
        ' Label6.Text = "1"
        ' Label9.Text = n
        pinta_fila(ini)

        DGV1.Columns("fecha_creacion").DefaultCellStyle.Format = "dd/MM/yyyy"
        DGV1.Columns("fecha_creacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV1.Columns("foto").Visible = False

    End Sub

    Sub ActualizarTabla(ByVal grilla As DataGridView, ByVal nombre_tabla As String,
                        ByVal campoSql As String, ByVal C_ORDEN As String)
        Try
            Dim da As OleDbDataAdapter 'DATAADPTER
            Dim dt As DataTable
            Dim consulta As String 'f9
            consulta = "Select "
            If campoSql = "" Then
                consulta += "*"
            Else
                consulta += campoSql
            End If
            consulta += " From " & nombre_tabla & " ORDER BY " & C_ORDEN
            da = New OleDbDataAdapter(consulta, RutaDB)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count

            grilla.DataSource = dt
            grilla.ReadOnly = True 'SOLO DE LECTURA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub pinta_fila(ByVal nn As Integer)
        Try
            For i As Integer = 0 To DGV1.Rows.Count - 1
                DGV1.Rows(i).Selected = False
            Next
            If nn > 0 Then
                DGV1.Rows(nn).Selected = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
        Try
            If ValidarDatos Then
                '  obj_usuario.AgregaUsuario()
                If obj_usuario.AgregaUsuario(TXT_NOMBRE.Text, TXT_APELLIDO.Text, txt_USUARIO.Text, DTP1.Value, PictureBox1, TXT_CONTRASEÑA.Text) = True Then

                    MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "apellido")
                Else
                    MsgBox("Error al ingresar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                End If
            End If

            PictureBox1.Image = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try
        Me.ModoInsercion()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try

            With OpenFileDialog1
                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True
                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True
                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"
                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True
                'SET THE FILE NAME TO EMPTY 
                .FileName = ""
                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False
                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True
                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Seleccione una foto..."
                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True
                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
                        toco_foto = True

                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try


    End Sub

    Private Sub DGV1_MouseClick(sender As Object, e As MouseEventArgs) Handles DGV1.MouseClick
        If DGV1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un usuario para poder editarlo", MsgBoxStyle.Critical, "Error")
            DGV1.Focus()
        Else
            Me.ModoModificacion()
            id = ObtenerCampo(Me.DGV1, 0)
            TXT_NOMBRE.Text = ObtenerCampo(Me.DGV1, 1)
            TXT_APELLIDO.Text = ObtenerCampo(Me.DGV1, 2)
            txt_USUARIO.Text = ObtenerCampo(Me.DGV1, 3)
            DTP1.Text = ObtenerCampo(Me.DGV1, 4)
            TXT_CONTRASEÑA.Text = ObtenerCampo(Me.DGV1, 6)

            PictureBox1.Image = DGV1.CurrentRow.Cells("foto").FormattedValue
            BTN_NUEVO.Enabled = False
            BTN_AGREGAR.Enabled = False
            BTN_ELIMINAR.Enabled = True

            ' txtNombre.Focus()
            '   Label6.Text = dgv1.CurrentRow.Index + 1
            'ini = dgv1.CurrentRow.Index

        End If

    End Sub

    Private Sub BTN_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.Click
        Try
            Dim i = MsgBox("¿Desea modificar ese registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")

            If i = MsgBoxResult.Yes Then

                If ValidarDatos Then
                    If obj_usuario.Modificausuario(TXT_NOMBRE.Text, TXT_APELLIDO.Text, txt_USUARIO.Text, DTP1.Text, id, PictureBox1, TXT_CONTRASEÑA.Text) = True Then
                        MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                        Me.LimpiarCampos()
                        ActualizarTabla(Me.DGV1, "usuarios", "", "id")

                        Me.ModoInsercion()
                    Else
                        MsgBox("Error al modificar el registro, reintente la acción", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
        End Try

    End Sub

    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        BTN_ELIMINAR.Enabled = True
        BTN_MODIFICAR.Enabled = True
        BTN_NUEVO.Enabled = True
        BTN_AGREGAR.Enabled = True

        pinta_fila(0)
        If id > 0 Then
            id = DGV1.Item(0, 0).Value
        End If


    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        Dim i = MsgBox("¿Desea eliminar este usuario?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_usuario.EliminaUsuarios(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "usuarios", "", "id")
                    Me.ModoInsercion()
                    Me.LimpiarCampos()
                Else
                    MsgBox("Error al eliminar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
            End Try
        Else
        End If

    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click

        Try
            BTN_AGREGAR.Enabled = True
            BTN_NUEVO.Enabled = False
            '  PictureBox1.Image = Nothing
            BTN_ELIMINAR.Enabled = False

            PictureBox1.Image = Drawing.Image.FromFile(ruta_imagen)
            LimpiarCampos()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BTN_FIN_Click(sender As Object, e As EventArgs) Handles BTN_FIN.Click
        Me.Close()
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub
End Class