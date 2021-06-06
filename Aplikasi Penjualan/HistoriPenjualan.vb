Imports System.Data.OleDb

Public Class HistoriPenjualan
    Sub reset()
        cmbfaktur.Text = ""
        ltanggal.Text = ""
        lcustomer.Text = ""
        ljumlah.Text = 0
        ldibayar.Text = 0
        lkembali.Text = 0
        ltotal.Text = 0
    End Sub

    Private Sub HistoriPenjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call reset()

        Call koneksi()
        cmd = New OleDbCommand("select faktur from tblpenjualan", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmbfaktur.Items.Add(dr.Item(0))
        Loop
    End Sub

    Private Sub cmbfaktur_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbfaktur.SelectedIndexChanged
        cmd = New OleDbCommand("select * from tblpenjualan where faktur = '" & cmbfaktur.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ltanggal.Text = dr.Item(1)
            lcustomer.Text = dr.Item(2)
            ljumlah.Text = FormatNumber(dr.Item(3), 0)
            ltotal.Text = FormatNumber(dr.Item(4), 0)
            ldibayar.Text = FormatNumber(dr.Item(5), 0)
            lkembali.Text = FormatNumber(dr.Item(6), 0)
        End If

        da = New OleDbDataAdapter("select Nama_Barang, Harga, Jumlah, Total from tbldetailjual where tbldetailjual.kode_barang and tbldetailjual.faktur='" & cmbfaktur.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 170

        DGV.Columns(1).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnbatal_Click(sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        Call reset()

    End Sub

    Private Sub btntutup_Click(sender As System.Object, e As System.EventArgs) Handles btntutup.Click
        Me.Close()

    End Sub
End Class