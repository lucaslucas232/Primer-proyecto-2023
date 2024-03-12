Imports System.Data.OleDb
Public Class EXPORTAR
    Sub Carga_productos(ByVal grilla As DataGridView,
                 ByVal nombre_tabla As String,
                 ByVal campoSql As String,
                 ByVal C_ORDEN As String)
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
            da = New OleDbDataAdapter(consulta, RutaDB_NEPTUNO)
            dt = New DataTable
            da.Fill(dt)
            grilla.DataSource = dt
            grilla.ReadOnly = True 'SOLO DE LECTURA


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carga_productos(DataGridView1, "Productos", "IdProducto,NombreProducto,PrecioUnidad", "IdProducto")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim sql As String

        Try

            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add
            oSheet = oBook.Worksheets(1)

            'Create the QueryTable object.
            Dim oQryTable As Object

            sql = "select IdProducto as [Nro de Producto],NombreProducto as Nombre,PrecioUnidad as Precio " _
               + "from productos " _
               + "order by IdProducto"

            oQryTable = oSheet.QueryTables.Add("OLEDB;Provider=Microsoft.ace.OLEDB.12.0;Data Source=" & RutaDB_NEPTUNO & ";", oSheet.Range("A1"), sql)
            oQryTable.RefreshStyle = 2 ' x1 InsertEntireRows=2
            oQryTable.Refresh(False)

            'Save the workbook and quit Excel.
            SaveFileDialog1.Filter = "Excel Doc File|*.xlsx|(*.txt)|*.txt|All files (*.*)|*.*"

            ' SaveFileDialog1.ShowDialog()

            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If SaveFileDialog1.FileName = "" Then
                    MsgBox("error, digite nombre...")
                    Exit Sub
                Else
                    Dim ruta As String = SaveFileDialog1.FileName
                    oBook.SaveAs(ruta)
                    oQryTable = Nothing
                    oSheet = Nothing
                    oBook = Nothing
                    oExcel.Quit()
                    oExcel = Nothing
                    MsgBox("Exportación exitosa")
                End If
            Else
                MsgBox("Canceló...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Sql As String
        Try
            Dim cnn As New OleDbConnection
            Dim ds As New DataSet
            Dim cmd As New OleDbCommand
            Dim da As New OleDbDataAdapter

            Sql = "select IdProducto,NombreProducto,PrecioUnidad " _
                + "from productos " _
                + "order by IdProducto"

            cnn.ConnectionString = RutaDB_NEPTUNO

            cmd.Connection = cnn
            cnn.Open()
            cmd.CommandText = Sql
            da.SelectCommand = cmd
            da.Fill(ds)

            SaveFileDialog1.Filter = "(*.xml)|*.xml"

            SaveFileDialog1.ShowDialog()

            Dim ruta As String = SaveFileDialog1.FileName

            ds.WriteXml(ruta, XmlWriteMode.WriteSchema)

            MsgBox("Exportación exitosa")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class