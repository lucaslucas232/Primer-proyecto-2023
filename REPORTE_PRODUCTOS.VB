Public Class REPORTE_PRODUCTOS

    Dim REPORTE As New CrystalReport1

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        CrystalReportViewer1.Refresh()

        CrystalReportViewer1.ReportSource = REPORTE


        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class