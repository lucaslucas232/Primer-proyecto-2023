Imports System.Data.OleDb

Public Class VENCIMIENTOS

    Private dt As DataTable, tabla As DataTable
    Private da As OleDbDataAdapter, consulta As OleDbDataAdapter
    Private fila As Integer
    Dim s As String
    Dim cantidad As Integer
    Dim acumula As String
    Dim dato As Integer

    Dim Ini As DateTime
    Dim Fin As Date


    Sub CARGA_SUMA()
        Try
            Dim SQL As String
            Dim FECHA1 As String
            Dim FECHA2 As String
            FECHA1 = CDate(TextBox1.Text).ToString("MM/dd/yyyy")
            FECHA2 = CDate(TextBox2.Text).ToString("MM/dd/yyyy")

            SQL = "SELECT Sum(VENCIMIENTOS.IMPORTE) AS SumaDeIMPORTE " _
+ "From VENCIMIENTOS " _
+ "Where (((VENCIMIENTOS.FECHA_VENCIMIENTO) Between #" & FECHA1 & "# And #" & FECHA2 & "#));"

            da = New OleDbDataAdapter(SQL, RutaDB_PRACTICA)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim dr As DataRow
            dr = dt.Rows(0)
            Label10.Text = dr(0).ToString

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try


    End Sub
    Sub DiasHab()
        Dim feriado1 As String = "8/25"
        Dim m As Integer = Ini.Month
        Dim d As Integer = Ini.Day
        Dim fini As String = m & "/" & d


        Dim Cant As Integer = 0
        While Ini <> Fin.AddDays(1)
            If Not (Ini.DayOfWeek = DayOfWeek.Sunday Or Ini.DayOfWeek = DayOfWeek.Saturday) Then
                Cant = Cant + 1
                ListBox1.Items.Add(Ini.Date)
            End If
            Ini = Ini.AddDays(1)
        End While

        MsgBox("Días hábiles: " & Cant)

    End Sub

    Private Sub VENCIMIENTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga()

    End Sub

    Sub pinta_fila()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Selected = False
        Next
    End Sub

    Sub carga()
        Dim sql As String

        sql = "select * from vencimientos"
        da = New OleDbDataAdapter(sql, RutaDB_practica)
        Dim dt As New DataTable
        da.Fill(dt)
        cantidad = dt.Rows.Count 'cargamos la cant de reg resultado de la consulta

        With DataGridView1
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DataSource = dt
        End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        carga()
        pinta_fila()
        CARGA_SUMA()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Clear()
        DiasHab()



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Ini = e.Start.Date
        Fin = e.End.Date

        TextBox1.Text = Ini.ToString
        TextBox2.Text = Fin.ToString

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "FECHA_VENCIMIENTO" Then
            If e.Value IsNot Nothing Then
                Dim valor As Date = CType(e.Value, Date)

                If valor >= Ini And valor <= Fin Then
                    ' e.CellStyle.ForeColor = Color.Blue
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow

                End If
            End If
        End If

    End Sub
End Class