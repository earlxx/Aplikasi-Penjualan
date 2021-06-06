Public Class LaporanMaster

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CRV.ReportSource = "laporan user.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CRV.ReportSource = "laporan barang.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub LaporanMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            CRV.SelectionFormula = "{tblbarang.satuan}='" & TextBox1.Text & "'"
            CRV.ReportSource = "laporan barang.rpt"
            CRV.RefreshReport()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            CRV.SelectionFormula = "{tblbarang.nama_barang} like '*" & TextBox2.Text & "*'"
            CRV.ReportSource = "laporan barang.rpt"
            CRV.RefreshReport()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        CRV.ReportSource = "laporan customer.rpt"
        CRV.RefreshReport()
    End Sub
End Class