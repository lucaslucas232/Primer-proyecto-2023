Imports System.Data.OleDb
Imports System.IO
Public Class CLS_USUARIOS_PROGRAMA

    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    'LENGUAJE ESTRUCTURADO DE CONSULTAS 
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()

    Function AgregaUsuario(ByVal usuario As String, ByVal contraseña As String, ByVal TIPO As String) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB) 'APUNTA A LA BASE DE DATOS.. CON = CONEXION 
            con.Open()

            Sql = "Insert into usuarios_PROGRAMA (usuario, contraseña, TIPO)" _
                + "Values (@usuario,@contraseña,@TIPO)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@usuario", usuario.ToUpper)
                .Parameters.AddWithValue("@contraseña", contraseña.ToUpper)
                .Parameters.AddWithValue("@TIPO", TIPO.ToUpper)
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

    Function Modificausuario(ByVal usuario As String, ByVal contraseña As String, ByVal TIPO As String) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB)
            Dim MS As New MemoryStream

            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE usuarioS_PROGRAMA SET contraseña= '" & contraseña.ToUpper & "', TIPO= '" & TIPO.ToUpper & "' WHERE USUARIO='" & usuario & "'"

            ComandoSql = New OleDbCommand(Sql, con)

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

    Function EliminaUsuarios(ByVal USUARIO As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB)
            con.Open()
            Sql = "DELETE * FROM usuarios_PROGRAMA WHERE USUARIO =" & USUARIO
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
