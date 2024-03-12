Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing.Printing

Public Class frm_actualiza_precios

    Dim paso As Boolean = False
    Dim esPreview As Boolean
    Private prtFont As System.Drawing.Font
    Private prtSettings As PrinterSettings
    Private prtDoc As PrintDocument
    Private lineaActual As Integer
    Dim linea As Integer = 0


    Private da As OleDbDataAdapter
    Private da1 As OleDbDataAdapter

    Private dt As DataTable
    Private dt1 As DataTable

    Private sql As String
    Dim id() As String

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        '  Dim i As Integer
        Dim Fuente As New Font("Courier New", 10)
        Dim blancos As Byte
        Dim texto As String

        Dim yPos As Single = e.MarginBounds.Top
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim printFont As System.Drawing.Font
        Try



            ' Asignar el tipo de letra
            printFont = prtFont

            Dim fontTitulo As New Font("Comic Sans MS", 20, FontStyle.Bold)
            e.Graphics.DrawString("Listado de  productos", fontTitulo, Brushes.Black, leftMargin, yPos)

            yPos += fontTitulo.GetHeight(e.Graphics)

            'esta pregunta es para imprimir la 2 vez
            If lineaActual <= dt.Rows.Count And paso = True Then
                lineaActual = 0
                paso = False
            Else

            End If

            Do
                yPos += 15
                Dim dr As DataRow
                dr = dt.Rows(lineaActual)
                blancos = 50 - Len(dr(1))
                texto = dr(1) & Space(blancos) & Format(dr(2), "$u ##,##0.00")
                e.Graphics.DrawString(texto, Fuente, Brushes.Black, leftMargin, yPos)
                lineaActual += 1

            Loop Until yPos >= e.MarginBounds.Bottom OrElse lineaActual >= dt.Rows.Count  'Datos.Count

            If lineaActual < dt.Rows.Count Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                paso = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub carga_grilla()

        Dim font As New Font(DGV1.DefaultCellStyle.Font.FontFamily, 10, FontStyle.Bold)

        Try

            If ComboBox1.Text <> "Todos" Then
                sql = "SELECT Productos.IdProducto, Productos.NombreProducto, Productos.PrecioUnidad, Proveedores.NombreCompañía " _
                        + "FROM Proveedores INNER JOIN (Categorías INNER JOIN Productos ON Categorías.IdCategoría = Productos.IdCategoría) ON Proveedores.IdProveedor = Productos.IdProveedor " _
                        + "WHERE Categorías.NombreCategoría='" & ComboBox1.Text & "';"
            Else
                sql = "SELECT Productos.IdProducto, Productos.NombreProducto, Productos.PrecioUnidad, Proveedores.NombreCompañía " _
                        + "FROM Proveedores INNER JOIN Productos ON Proveedores.IdProveedor = Productos.IdProveedor;"
            End If

            da = New OleDbDataAdapter(sql, RutaDB_NEPTUNO)
            dt = New DataTable
            da.Fill(dt)

            With DGV1
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = dt
                .Columns("IdProducto").HeaderText = "Código"
                .Columns("NombreProducto").HeaderText = "Descripción"
                .Columns("PrecioUnidad").HeaderText = "Precio"
                .Columns("NombreCompañía").HeaderText = "Proveedor"
                .Columns("PrecioUnidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("PrecioUnidad").DefaultCellStyle.Format = "$##,##0.00"
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
                .GridColor = Color.GreenYellow
                .DefaultCellStyle.BackColor = Color.LightSteelBlue
                .Columns("PrecioUnidad").DefaultCellStyle.Font = font

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CARGA_CATEGORIAS()
        Dim SQL As String
        Try

            SQL = "Select Categorías.NombreCategoría, categorías.idcategoría " _
    + "From Categorías " _
    + "Order By Categorías.NombreCategoría;"

            Dim da As New OleDbDataAdapter(SQL, RutaDB_NEPTUNO)
            Dim dt As New DataTable
            da.Fill(dt)
            ComboBox1.Items.Clear()

            Dim i As Integer
            ReDim id(dt.Rows.Count - 1)


            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow 'dr datarow
                dr = dt.Rows(i)
                ComboBox1.Items.Add(dr(0))

                id(i) = dr("IdCategoría").ToString

            Next
            ComboBox1.Items.Add("Todos")

            Me.DGV1.ContextMenuStrip = Me.ContextMenuStrip1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frm_actualiza_precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGA_CATEGORIAS()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        carga_grilla()

    End Sub

    Private Sub btn_aumenta_Click(sender As Object, e As EventArgs) Handles btn_aumenta.Click

        Dim aumento1 As Double

        Try
            '          1 + (10/100) = 1.1
            aumento1 = 1 + NumericUpDown1.Value / 100

            If ComboBox1.Text <> "Todos" Then
                'sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad*" & aumento1 & " " _
                '+ "WHERE IdCategoría=" & id(ComboBox1.SelectedIndex.ToString) & ";"

                sql = "UPDATE Categorías INNER JOIN Productos ON Categorías.IdCategoría " _
                    + "= Productos.IdCategoría Set Productos.PrecioUnidad = [Productos]![PrecioUnidad] " _
                + "*" & aumento1 & " WHERE (((Categorías.NombreCategoría)='” & ComboBox1.Text & ”'));”

            Else
                sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad*" & aumento1 & ""

            End If

            Dim cs1 As New OleDbConnection(RutaDB_NEPTUNO)
            Dim cmdUpdate As New OleDbCommand(sql, cs1)
            cmdUpdate.Connection.Open()
            MsgBox("Actualizacion completa. Filas Afectadas ." & cmdUpdate.ExecuteNonQuery())

            carga_grilla()

        Catch ex As InvalidOperationException
            MsgBox("Error: {0" & ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BTN_DISMINUYE_Click(sender As Object, e As EventArgs) Handles BTN_DISMINUYE.Click
        Dim dto As Double

        Try

            dto = 1 - (NumericUpDown1.Value) / 100

            If ComboBox1.Text <> "Todos" Then
                'UPDATE Categorías INNER JOIN Productos ON Categorías.IdCategoría = Productos.IdCategoría SET Productos.PrecioUnidad = [Productos]![PrecioUnidad]/1.1
                'WHERE (((Categorías.NombreCategoría)="bebidas"));

                sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad * " & dto & " " _
                + "WHERE IdCategoría=" & id(ComboBox1.SelectedIndex.ToString) & ";"
            Else
                sql = "UPDATE Productos SET PrecioUnidad = Productos.PrecioUnidad * " & dto & ""

            End If

            Dim cs1 As New OleDbConnection(RutaDB_NEPTUNO)

            Dim cmdUpdate As New OleDbCommand(sql, cs1)
            cmdUpdate.Connection.Open()
            MsgBox("Actualización completa. Filas Afectadas ." & cmdUpdate.ExecuteNonQuery())


            carga_grilla()

        Catch ex As InvalidOperationException
            MsgBox("Error: {0" & ex.Message)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BTN_IMPRIME_Click(sender As Object, e As EventArgs) Handles BTN_IMPRIME.Click

        Try

            esPreview = True

            If prtSettings Is Nothing Then
                prtSettings = New PrinterSettings
            End If

            If prtDoc Is Nothing Then
                prtDoc = New System.Drawing.Printing.PrintDocument
                AddHandler prtDoc.PrintPage, AddressOf PrintDocument1_PrintPage
            End If

            ' la línea actual
            lineaActual = 0

            ' la configuración a usar en la impresión
            prtDoc.PrinterSettings = prtSettings

            If esPreview Then
                Dim prtPrev As New PrintPreviewDialog
                prtPrev.Document = prtDoc
                prtPrev.Text = "Previsualizar documento"
                prtPrev.ShowDialog()

            Else
                prtDoc.Print()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class