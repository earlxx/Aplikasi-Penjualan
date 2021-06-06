Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LaporanPenjualan
    Dim report As New ReportDocument

    Private Sub LaporanPenjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
    End Sub

    Private Sub btnharian_Click(sender As System.Object, e As System.EventArgs) Handles btnharian.Click
        CRV.SelectionFormula = "Totext({tblpenjualan.tanggal}) = '" & DTP1.Text & "'"
        CRV.ReportSource = "laporan harian.rpt"
        CRV.RefreshReport()
        'report.Load("laporan harian.rpt")
        'report.Refresh()
        'report.PrintOptions.PrinterName = "EPSON L360 Series"
        'report.PrintToPrinter(1, False, 0, 0)

    End Sub

    Private Sub btnperiodik_Click(sender As System.Object, e As System.EventArgs) Handles btnperiodik.Click
        CRV.SelectionFormula = "{tblpenjualan.tanggal} in date ('" & DTP2.Text & "') to date ('" & DTP3.Text & "')"
        CRV.ReportSource = "laporan periodik.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub btnbulanan_Click(sender As System.Object, e As System.EventArgs) Handles btnbulanan.Click
        CRV.SelectionFormula = "month({tblpenjualan.tanggal}) = (" & Month(DTP4.Text) & ") and year({tblpenjualan.tanggal}) = (" & Year(DTP4.Text) & ")"
        CRV.ReportSource = "laporan bulanan ringkas.rpt"
        CRV.RefreshReport()
    End Sub
End Class