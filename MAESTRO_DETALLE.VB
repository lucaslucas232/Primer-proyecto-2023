Imports System.Data.OleDb


Public Class MAESTRO_DETALLE


    Private dt As DataTable, tabla As DataTable
    Private da As OleDbDataAdapter, consulta As OleDbDataAdapter
    Private fila As Integer
    Dim s As String
    Dim cantidad As Integer
    Dim acumula As String
    Dim dato As Integer

    Sub calcula_acumula()
        'CALCULA ACUMULA
        Dim i As Integer
        Dim sql1 As String = "SELECT Pedidos.IdPedido, Sum([Detalles de pedidos]![PrecioUnidad]*[Detalles de pedidos]![Cantidad]) AS Subtotal " _
        + "FROM Productos INNER JOIN (Pedidos INNER JOIN [Detalles de pedidos] ON Pedidos.IdPedido = [Detalles de pedidos].IdPedido) ON Productos.IdProducto = [Detalles de pedidos].IdProducto " _
        + "GROUP BY Pedidos.IdPedido " _
        + "HAVING Pedidos.IdPedido=" & dato & ";"

        da = New OleDbDataAdapter(sql1, RutaDB_NEPTUNO)
        Dim dt1 As New DataTable
        Dim dr1 As DataRow
        da.Fill(dt1)
        dr1 = dt1.Rows(0)
        acumula = Format(dr1("subtotal"), "$u ##,##0.00").ToString
        Label6.Text = "Importe: " & acumula

    End Sub

    Sub limpia_temporal()
        'limpia temporal
        Dim cs1 As New OleDbConnection(RutaDB_NEPTUNO)
        Dim sql2 As String = "delete * from temporal"
        Dim cmdUpdate As New OleDbCommand(sql2, cs1)
        cmdUpdate.Connection.Open()
        cmdUpdate.ExecuteNonQuery()
        cmdUpdate.Connection.Close()
        '**************************************************************************************
    End Sub


    Private Sub limpia()
        With DataGridView2
            .Columns.Clear()
        End With
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        If TextBox1.Text <> "" Then 'atento quiere decir distinto
            TextBox2.Text = MonthCalendar1.SelectionStart
        Else
            TextBox1.Text = MonthCalendar1.SelectionStart
        End If

    End Sub

    Private Sub MAESTRO_DETALLE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        '                            0                           1
        Dim sSel As String = "SELECT Clientes.IdCliente, Clientes.NombreCompañía FROM clientes ORDER BY NombreCompañía"

        Me.WindowState = FormWindowState.Maximized

        RadioButton1.Checked = True


        Try
            da = New OleDbDataAdapter(sSel, RutaDB_NEPTUNO)
            dt = New DataTable
            da.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                ComboBox1.Items.Add(dr("NombreCompañía").ToString)
                ComboBox2.Items.Add(dr("idcliente").ToString)
            Next


        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & ex.Message, "Conectar con la base", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha1 As String
        Dim fecha2 As String

        Try
            fecha1 = CDate(TextBox1.Text).ToString("MM/dd/yyyy")
            fecha2 = CDate(TextBox2.Text).ToString("MM/dd/yyyy")

            Dim sql As String

            If RadioButton1.Checked Then
                sql = "SELECT Clientes.NombreCompañía, Pedidos.IdPedido, Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.FormaEnvío, Pedidos.Destinatario, Pedidos.CiudadDestinatario " _
                + "FROM Clientes INNER JOIN Pedidos ON Clientes.IdCliente = Pedidos.IdCliente " _
            + "WHERE Clientes.IdCliente='" + ComboBox2.Text + "' AND Pedidos.FechaPedido Between #" & fecha1 & "# And #" & fecha2 & "# " _
            + "ORDER BY Pedidos.FechaEntrega;"
            Else
                sql = "SELECT Clientes.NombreCompañía, Pedidos.IdPedido, Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.FormaEnvío, Pedidos.Destinatario, Pedidos.CiudadDestinatario " _
                + "FROM Clientes INNER JOIN Pedidos ON Clientes.IdCliente = Pedidos.IdCliente " _
                + "WHERE Clientes.IdCliente='" + ComboBox2.Text + "' AND Pedidos.FechaEntrega Between #" & fecha1 & "# And #" & fecha2 & "# " _
                + "ORDER BY Pedidos.FechaEntrega;"
            End If

            da = New OleDbDataAdapter(sql, RutaDB_NEPTUNO)
            Dim dt As New DataTable
            da.Fill(dt)
            cantidad = dt.Rows.Count 'cargamos la cant de reg resultado de la consulta

            With DataGridView1
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = dt
            End With

            If cantidad = 0 Then
                limpia()
                MsgBox("No hay pedidos en ese rango de fechas...")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            ComboBox2.SelectedIndex = ComboBox1.SelectedIndex


            Dim sql As String = "SELECT Pedidos.IdCliente, Pedidos.IdPedido, Pedidos.FechaPedido, Pedidos.FechaEntrega, Pedidos.FormaEnvío, Pedidos.Destinatario, Pedidos.CiudadDestinatario " _
            + "FROM Pedidos " _
            + "WHERE(((Pedidos.IdCliente) = '" & ComboBox2.Text & "')) " _
            + "ORDER BY Pedidos.IdPedido;"

            da = New OleDbDataAdapter(sql, RutaDB_NEPTUNO)
            Dim dt As New DataTable
            da.Fill(dt)

            With DataGridView1
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = dt
            End With

        Catch ex As Exception

            MessageBox.Show("ERROR al conectar o recuperar los datos:" _
                            & vbCrLf & ex.Message, "Conectar con la base",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim da1 As OleDbDataAdapter

        Try

            limpia_temporal()


            dato = CDbl(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)

            Dim sql As String = "SELECT Pedidos.IdPedido, [Detalles de pedidos].IdProducto, Productos.NombreProducto, [Detalles de pedidos].PrecioUnidad, [Detalles de pedidos].Cantidad, [Detalles de pedidos].PrecioUnidad * [Detalles de pedidos].Cantidad as Subtotal " _
            + " FROM Productos INNER JOIN (Pedidos INNER JOIN [Detalles de pedidos] ON Pedidos.IdPedido = [Detalles de pedidos].IdPedido) ON Productos.IdProducto = [Detalles de pedidos].IdProducto " _
            + "WHERE Pedidos.IdPedido=" & dato & ""   ' el criterio dato no lleva apostrofe porque es un numero

            da = New OleDbDataAdapter(sql, RutaDB_NEPTUNO)
            Dim dt As New DataTable
            Dim dr As DataRow

            da.Fill(dt)

            calcula_acumula()

            'CARGA TEMPORAL Y CARGAR GRILLA2
            '**********************************************************************
            Dim con As New OleDbConnection(RutaDB_NEPTUNO)
            Dim ComandoSql As OleDbCommand
            Dim SQL2 As String

            con.Open()

            For H = 0 To dt.Rows.Count - 1
                Dim DRX As DataRow
                DRX = dt.Rows(H)
                SQL2 = "Insert into TEMPORAL (IdPedido, IdProducto, NombreProducto, PrecioUnidad, Cantidad, Subtotal) " _
               + "Values (@IdPedido,@IdProducto,@NombreProducto,@PrecioUnidad,@Cantidad,@Subtotal)"

                ComandoSql = New OleDbCommand
                With ComandoSql
                    .Connection = con
                    .CommandText = SQL2
                    .Parameters.AddWithValue("@IdPedido", DRX(0).ToString)
                    .Parameters.AddWithValue("@IdProducto", DRX(1).ToString)
                    .Parameters.AddWithValue("@NombreProducto", DRX(2).ToString)
                    .Parameters.AddWithValue("@PrecioUnidad", DRX(3).ToString)
                    .Parameters.AddWithValue("@Cantidad", DRX(4).ToString)
                    .Parameters.AddWithValue("@Subtotal", DRX(5).ToString)
                    .ExecuteNonQuery()
                End With
            Next

            SQL2 = "Insert into TEMPORAL (Subtotal) Values (@Subtotal)"
            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = SQL2
                .Parameters.AddWithValue("@Subtotal", acumula.ToString)
                .ExecuteNonQuery()
            End With
            con.Close()
            'sacamos datos del temporal

            sql = "SELECT TEMPORAL.IdPedido, TEMPORAL.IdProducto, TEMPORAL.NombreProducto, TEMPORAL.Cantidad,TEMPORAL.preciounidad, TEMPORAL.Subtotal FROM TEMPORAL;"
            da1 = New OleDbDataAdapter(sql, RutaDB_NEPTUNO)
            Dim dttmp As New DataTable
            da1.Fill(dttmp)

            '  MsgBox(dttmp.Rows.Count)

            With DataGridView2 'volcamos el detalle del pedido al data
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = dttmp
            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class