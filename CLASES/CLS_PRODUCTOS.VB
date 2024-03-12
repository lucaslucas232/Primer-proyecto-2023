
Imports System.Data.OleDb
Imports System.IO

Public Class CLS_PRODUCTOS

    Dim ComandoSql As OleDbCommand
    Dim Sql As String
    Dim mstream As New System.IO.MemoryStream()

    Function AgregaUsuario(ByVal nombre As String, ByVal PRECIO_UNITARIO As String, ByVal FECHA_VENCIMIENTO As String) As Boolean

        Try
            Dim conexion As New OleDbConnection(RutaDB) 'APUNTA A LA BASE DE DATOS.. CON = CONEXION 
            conexion.Open()

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = conexion
                .CommandText = Sql
                .Parameters.AddWithValue("@nombre", nombre.ToUpper)
                .Parameters.AddWithValue("@precio_unitrio", PRECIO_UNITARIO.ToUpper)
                .Parameters.AddWithValue("@fecha_vencimiento", FECHA_VENCIMIENTO.ToUpper)
                .ExecuteNonQuery()
            End With

            ComandoSql.Dispose()
            Sql = String.Empty
            conexion.Close()
            Return True

        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
