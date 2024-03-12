Imports System.Data.OleDb


Public Class FRM_PRACTICO_BD

    Dim obj_usuario As New CLS_USUARIOS_PROGRAMA 'TODAS LAS CLASES COMIENZAN CON CLS
    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
    Dim USUARIO As String
    Private txtUsuario As Object

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

    Sub ModoModificacion()
        BTN_AGREGAR.Enabled = False
        BTN_ELIMINAR.Enabled = True
        BTN_MODIFICAR.Enabled = True
        BTN_CANCELAR.Enabled = True
    End Sub

    '  Sub LimpiarCampos()
    '   TXT_NOMBRE.Text = ""
    '  TXT_CONTRASEÑA.Text = ""
    ' TXT_CONTRASEÑA2.Text = ""
    'txt_USUARIO.Focus()
    'End Sub

    Sub ModoInsercion()
        BTN_CANCELAR.Enabled = True
        BTN_NUEVO.Enabled = True
        BTN_ELIMINAR.Enabled = False
        BTN_MODIFICAR.Enabled = False
        BTN_AGREGAR.Enabled = False
    End Sub

    Function ObtenerCampo(ByVal grilla As DataGridView, ByVal indice_columna As Byte)
        Try
            If Not IsDBNull(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value) Then
                Return CStr(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

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
    Function ValidarDatos() As Boolean
        Try

            If TXT_NOMBRE.Text.Trim = "" Then
                MsgBox("INGRESE UN PRODUCTO")
                TXT_NOMBRE.Focus()
                Return False
                Exit Function
            End If

            If TXT_PRECIO.Text < 0 Then
                MsgBox("INGRESE UN PRECIO VALIDO")
                TXT_PRECIO.Focus()
                Return False
                Exit Function

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True

    End Function

End Class