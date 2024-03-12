Imports System.Data.OleDb
Imports System.IO

Public Class CLS_USUARIO

    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'structure query language
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()


    Function AgregaUsuario(ByVal nombre As String, ByVal apellido As String,
                           ByVal usuario As String, ByVal fecha_Creacion As String,
                           ByVal pic As PictureBox, ByVal contraseña As String) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB) 'APUNTA A LA BASE DE DATOS.. CON = CONEXION 
            con.Open()

            Dim FileSize As UInt32
            If pic.ImageLocation = Nothing Then
                FileSize = 0
            Else
                FileSize = mstream.Length
            End If

            Try
                pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                FileSize = mstream.Length
                mstream.Close()
            Catch
                FileSize = 0
            End Try

            Sql = "Insert into usuarios (nombre, apellido, usuario, fecha_Creacion, foto, contraseña) " _
                + "Values (@nombre,@apellido,@usuario,@fecha_Creacion,@foto,@contraseña)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@nombre", nombre.ToUpper)
                .Parameters.AddWithValue("@apellido", apellido.ToUpper)
                .Parameters.AddWithValue("@usuario", usuario.ToUpper)
                .Parameters.AddWithValue("@fecha_creacion", fecha_Creacion)
                .Parameters.AddWithValue("@foto", arrImage)
                .Parameters.AddWithValue("@contraseña", contraseña)

                .ExecuteNonQuery()
            End With

            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True

        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


    Function Modificausuario(ByVal nombre As String, ByVal apellido As String,
                             ByVal usuario As String, ByVal fecha_Creacion As String,
                             ByVal id As Integer, ByVal imagen As PictureBox, ByVal contraseña As String) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB)

            Dim MS As New MemoryStream

            imagen.Image.Save(MS, imagen.Image.RawFormat)

            Dim Imagenes() As Byte = MS.GetBuffer

            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE usuarios SET Nombre = '" & nombre.ToUpper & "', apellido = '" & apellido.ToUpper & "', usuario = '" & usuario.ToUpper & "',fecha_creacion = '" & fecha_Creacion & "',foto=@imagen, contraseña= '" & contraseña & "' WHERE id =" & id

            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.Parameters.AddWithValue("@foto", Imagenes)

            ComandoSql.ExecuteNonQuery() 'EJECUTA LOS CAMBIOS
            ComandoSql.Dispose() 'LIMPIA LA VARIABLE 
            Sql = String.Empty 'EMPTY  LIMPIA LA VARIABLE
            con.Close()
            Return True

        Catch exsql As OleDbException
            Return False

        Catch ex As Exception
            Return False
        End Try

    End Function

    Function EliminaUsuarios(ByVal id As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB)
            con.Open()
            Sql = "DELETE * FROM usuarios WHERE id =" & id
            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.ExecuteNonQuery()
            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
