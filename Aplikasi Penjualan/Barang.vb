Imports System.Data.OleDb

Public Class Barang

    Sub formatuang(ByRef text As TextBox)
        If Len(text.Text) > 0 Then
            text.Text = FormatNumber(CDbl(text.Text), 0)
            Dim x As Integer = text.SelectionStart.ToString
            If x = 0 Then
                text.SelectionStart = Len(text.Text)
                text.SelectionLength = 0
            Else
                text.SelectionStart = x
                text.SelectionLength = 0
            End If
        End If
    End Sub

    Public Function formatuangkebilangan(ByRef N As String) As Double
        formatuangkebilangan = Replace(N, ",", "")
    End Function

    Sub reset()
        tkode.Text = ""
        tnama.Text = ""
        cmbsatuan.Text = ""
        tbeli.Text = ""
        tjual.Text = ""
        tcari.text = ""
        tstok.Text = ""
        tkode.MaxLength = 13
        tnama.MaxLength = 200
        tkode.Focus()
    End Sub

    Sub tampilgrid1()
        Call koneksi()
        da = New OleDbDataAdapter(" select * from tblbarang", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
        DGV1.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV1.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGV1.Columns(5).DefaultCellStyle.Format = "###,###,###"
        DGV1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSalmon
        DGV1.ReadOnly = True
        DGV1.Columns(1).Width = 200
        DGV1.Columns(2).Width = 60
        DGV1.Columns(3).Width = 80
        DGV1.Columns(4).Width = 80
        DGV1.Columns(5).Width = 60
    End Sub

    Private Sub Barang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call reset()
        Call tampilgrid1()

    End Sub


    Private Sub tkode_KeyPress1(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OleDbCommand(" select * from tblbarang where kode_barang = '" & tkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tnama.Text = dr.Item(1)
                cmbsatuan.Text = dr.Item(2)
                tbeli.Text = dr.Item(3)
                tjual.Text = dr.Item(4)
                tstok.Text = dr.Item(5)
            Else
                tnama.Text = ""
                cmbsatuan.Text = ""
                tbeli.Text = ""
                tjual.Text = ""
                tstok.Text = ""
                tnama.Focus()
            End If
        End If
    End Sub

    Private Sub tcari_OnTextChange(sender As System.Object, e As System.EventArgs) Handles tcari.OnTextChange
        Call koneksi()
        da = New OleDbDataAdapter("select * from tblbarang where kode_barang like '%" & tkode.Text & "%' or nama_barang like '%" & tnama.Text & "%' or stok like '%" & tstok.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If tkode.Text = "" Or tnama.Text = "" Then
            MsgBox("data barang belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tblbarang where kode_barang = '" & tkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Dim simpan As String = "insert into tblbarang values ('" & tkode.Text & "', '" & tnama.Text & "', '" & cmbsatuan.Text & "', '" & tbeli.Text & "', '" & tjual.Text & "', '" & tstok.Text & "')"
                Call koneksi()
                cmd = New OleDbCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("data barang berhasil disimpan")
                Call reset()
                Call tampilgrid1()
            Else
                Dim edit As String = "update tblbarang set nama_barang = '" & tnama.Text & "', satuan = '" & cmbsatuan.Text & "', harga_beli = '" & tbeli.Text & "', harga_jual = '" & tjual.Text & "', stok = '" & tstok.Text & "' where kode_barang = '" & tkode.Text & "'"
                Call koneksi()
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("data barang berhasil diedit")
                Call reset()
                Call tampilgrid1()
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        If tkode.Text = "" Then
            MsgBox("kode barang belum di-isi")
            tkode.Focus()
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand(" select * from tblbarang where kode_barang = '" & tkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim hapus As String = "delete from tblbarang where kode_barang = '" & tkode.Text & "'"
                Call koneksi()
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                MsgBox("data berhasil dihapus")
                Call reset()
                Call tampilgrid1()
            Else
                Call reset()
            End If
        End If
    End Sub

    Private Sub btnbatal_Click(sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        Call reset()
        Call tampilgrid1()

    End Sub

    Private Sub btntutup_Click(sender As System.Object, e As System.EventArgs) Handles btntutup.Click
        Me.Close()

    End Sub

    Private Sub DGV1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        tkode.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        tnama.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
        cmbsatuan.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
        tbeli.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
        tjual.Text = DGV1.Rows(e.RowIndex).Cells(4).Value
        tstok.Text = DGV1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub tbeli_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbeli_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbeli.TextChanged
        formatuang(tbeli)
    End Sub

    Private Sub tjual_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tjual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tjual_TextChanged(sender As System.Object, e As System.EventArgs) Handles tjual.TextChanged
        formatuang(tjual)
    End Sub

    Private Sub tstok_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tstok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tstok_TextChanged(sender As System.Object, e As System.EventArgs) Handles tstok.TextChanged
        formatuang(tstok)
    End Sub

End Class

