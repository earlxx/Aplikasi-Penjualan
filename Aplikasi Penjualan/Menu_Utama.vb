Public Class Menu_Utama

    Private Sub btnbarang_Click(sender As System.Object, e As System.EventArgs) Handles btnbarang.Click
        'Barang.Close()
        Customer.Close()
        CetakBarcode.Close()
        HistoriPenjualan.Close()
        LaporanMaster.Close()
        LaporanPenjualan.Close()
        Penjualan.Close()
        User.Close()
        lbarang.Visible = True
        Barang.MdiParent = Me
        Barang.Show()

        ' lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub Menu_Utama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btnpenjualan_Click(sender As System.Object, e As System.EventArgs) Handles btnpenjualan.Click
        Barang.Close()
        Customer.Close()
        CetakBarcode.Close()
        HistoriPenjualan.Close()
        LaporanMaster.Close()
        LaporanPenjualan.Close()
        ' Penjualan.Close()
        User.Close()
        lpenjualan.Visible = True
        Penjualan.MdiParent = Me
        Penjualan.Show()

        lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        ' lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btnuser_Click(sender As System.Object, e As System.EventArgs) Handles btnuser.Click
        Barang.Close()
        Customer.Close()
        CetakBarcode.Close()
        HistoriPenjualan.Close()
        LaporanMaster.Close()
        LaporanPenjualan.Close()
        Penjualan.Close()
        ' User.Close()
        luser.Visible = True
        User.MdiParent = Me
        User.Show()

        lbarang.Visible = False
        lcustom.Visible = False
        ' luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btncustomer_Click(sender As System.Object, e As System.EventArgs) Handles btncustomer.Click
        Barang.Close()
        ' Customer.Close()
        CetakBarcode.Close()
        HistoriPenjualan.Close()
        LaporanMaster.Close()
        LaporanPenjualan.Close()
        Penjualan.Close()
        User.Close()
        lcustom.Visible = True
        Customer.MdiParent = Me
        Customer.Show()

        lbarang.Visible = False
        '  lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btnhistori_Click(sender As System.Object, e As System.EventArgs) Handles btnhistori.Click
        Barang.Close()
        Customer.Close()
        CetakBarcode.Close()
        'HistoriPenjualan.Close()
        LaporanMaster.Close()
        LaporanPenjualan.Close()
        Penjualan.Close()
        User.Close()
        lhistori.Visible = True
        HistoriPenjualan.MdiParent = Me
        HistoriPenjualan.Show()

        lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        ' lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btncetak_Click(sender As System.Object, e As System.EventArgs) Handles btncetak.Click
        Barang.Close()
        Customer.Close()
        'CetakBarcode.Close()
        HistoriPenjualan.Close()
        LaporanMaster.Close()
        LaporanPenjualan.Close()
        Penjualan.Close()
        User.Close()
        lbarcode.Visible = True
        CetakBarcode.MdiParent = Me
        CetakBarcode.Show()

        lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        ' lbarcode.Visible = False
        llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btnlaporjual_Click(sender As System.Object, e As System.EventArgs) Handles btnlaporjual.Click
        Barang.Close()
        Customer.Close()
        CetakBarcode.Close()
        HistoriPenjualan.Close()
        LaporanMaster.Close()
        ' LaporanPenjualan.Close()
        Penjualan.Close()
        User.Close()
        llaporjual.Visible = True
        LaporanPenjualan.MdiParent = Me
        LaporanPenjualan.Show()

        lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        ' llaporjual.Visible = False
        llapormaster.Visible = False

    End Sub

    Private Sub btnlapormaster_Click(sender As System.Object, e As System.EventArgs) Handles btnlapormaster.Click
        Barang.Close()
        Customer.Close()
        CetakBarcode.Close()
        HistoriPenjualan.Close()
        'LaporanMaster.Close()
        LaporanPenjualan.Close()
        Penjualan.Close()
        User.Close()
        llapormaster.Visible = True
        LaporanMaster.MdiParent = Me
        LaporanMaster.Show()

        lbarang.Visible = False
        lcustom.Visible = False
        luser.Visible = False
        lpenjualan.Visible = False
        lhistori.Visible = False
        lbarcode.Visible = False
        llaporjual.Visible = False
        ' llapormaster.Visible = False

    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class