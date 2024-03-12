Imports System.Data.OleDb

Public Class CONSULTA_PRODUCTOS

    Sub carga_categorias()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT Categorías.NombreCategoría From Categorías Order By Categorías.NombreCategoría;"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_NEPTUNO)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ComboBox1.Items.Add(dr(0))
            ' ComboBox1.Items.Add(dr(0)) 'CARGA LOS PAISES EN EL COMBO
        Next

    End Sub
    Sub carga_datos()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT Productos.NombreProducto " _
+ "FROM Productos " _
+ "ORDER BY Productos.NombreProducto;"


        Dim da As New OleDbDataAdapter(SQL, RutaDB_NEPTUNO)
        Dim dt As New DataTable

        da.Fill(dt)

        ListBox1.Items.Clear()

        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ListBox1.Items.Add(dr(0))
            ' ComboBox1.Items.Add(dr(0)) 'CARGA LOS PAISES EN EL COMBO
        Next
    End Sub

    Private Sub CONSULTA_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_datos()
        carga_categorias()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim SQL As String
        Dim DATO As String

        DATO = TextBox1.Text & "%"  '%comodin
        '                   0                  1
        SQL = "SELECT Productos.NombreProducto " _
+ "From Productos " _
+ "Where Productos.NombreProducto Like '" & DATO & "'"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_NEPTUNO)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.Rows(i)
            ListBox1.Items.Add(UCase(dr(0)))      'ucase()   Mayusculas...
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim sql As String


        sql = "SELECT Categorías.NombreCategoría, Productos.NombreProducto " _
+ "From Categorías INNER Join Productos On Categorías.IdCategoría = Productos.IdCategoría " _
+ "Where (((Categorías.NombreCategoría)= '" & ComboBox1.Text & "')) " _
+ "Order By Categorías.NombreCategoría, Productos.NombreProducto;"



        Dim da As New OleDbDataAdapter(sql, RutaDB_NEPTUNO)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBox2.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ListBox2.Items.Add(dr(1))
        Next

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim SQL As String
        Dim DATO As String

        DATO = "%" & TextBox2.Text & "%"  '%comodin
        '                   0                  1
        SQL = "SELECT Categorías.NombreCategoría, Productos.NombreProducto " _
+ "From Categorías INNER Join Productos On Categorías.IdCategoría = Productos.IdCategoría " _
+ "Where (((Categorías.NombreCategoría) = '" & ComboBox1.Text & "') And ((Productos.NombreProducto) like '" & DATO & "')) " _
+ "order By Productos.NombreProducto;"


        Dim da As New OleDbDataAdapter(SQL, RutaDB_NEPTUNO)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBox2.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow 'dr datarow
            dr = dt.Rows(i)
            ListBox2.Items.Add(dr(1))
        Next

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class