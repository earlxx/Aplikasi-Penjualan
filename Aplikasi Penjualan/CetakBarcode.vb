Imports System.Data.OleDb

Public Class CetakBarcode
    Sub reset()
        lkode.Text = ""
        lnama.Text = ""
        ljumlah.Text = ""
        lstok.Text = ""
        btncari.text = ""
        lkode.Focus()
      
    End Sub

    Sub tampilgrid()
        Call koneksi()
        da = New OleDbDataAdapter("select kode_barang, nama_barang, stok from tblbarang", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        DGV.Columns(1).Width = 170
        DGV.Columns(2).Width = 60

    End Sub

    Private Sub CetakBarcode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        Call reset()
        Call tampilgrid()

    End Sub

    Private Sub DGV_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        lkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        lnama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        lstok.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        btncari.text = ""
        ljumlah.Focus()
    End Sub

    Private Sub lkode_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OleDbCommand("select * from tblbarang where kode_barang = '" & lkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lnama.Text = dr.Item(1)
                lstok.Text = dr.Item(5)
                ljumlah.Focus()
            Else
                MsgBox("kode barang tidak ada")
                lkode.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub lkode_TextChanged(sender As System.Object, e As System.EventArgs) Handles lkode.TextChanged

    End Sub

    Private Sub btncari_OnTextChange(sender As System.Object, e As System.EventArgs) Handles btncari.OnTextChange
        Call koneksi()
        da = New OleDbDataAdapter("select kode_barang, nama_barang, stok from tblbarang where kode_barang like '%" & btncari.text & "%' or nama_barang like '%" & btncari.text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True

    End Sub

    Private Sub btncetak_Click(sender As System.Object, e As System.EventArgs) Handles btncetak.Click
        If lkode.Text = "" Or lnama.Text = "" Then
            MsgBox("data belum lengkap")
            Exit Sub
        Else
            ' Try
            Call koneksi()
            cmd = New OleDbCommand("select * from tbldetailbarang where kode_barang = '" & lkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows Then
                For I As Integer = 1 To Val(ljumlah.Text)
                    Dim simpandetail As String = "insert into tbldetailbarang values('" & lkode.Text & "','" & I & "/" & CStr(ljumlah.Text) & "')"
                    cmd = New OleDbCommand(simpandetail, conn)
                    cmd.ExecuteNonQuery()
                Next
                CRV.SelectionFormula = "{tblbarang.kode_barang} = '" & lkode.Text & "'"
                CRV.ReportSource = "stok barcode.rpt"
                CRV.RefreshReport()
            Else
                Dim HAPUSDULU1 As String = "delete from tbldetailbarang where kode_barang ='" & lkode.Text & "'"
                cmd = New OleDbCommand(HAPUSDULU1, conn)
                cmd.ExecuteNonQuery()

                For I As Integer = 1 To Val(ljumlah.Text)
                    Dim simpandetail As String = "insert into tbldetailbarang values('" & lkode.Text & "','" & I & "/" & CStr(ljumlah.Text) & "')"
                    cmd = New OleDbCommand(simpandetail, conn)
                    cmd.ExecuteNonQuery()
                Next
                CRV.SelectionFormula = "{tblbarang.kode_barang} = '" & lkode.Text & "'"
                CRV.ReportSource = "stok barcode.rpt"
                CRV.RefreshReport()
            End If
            Call reset()
            Call tampilgrid()
            'Catch ex As Exception
            '    MsgBox("ERROR") '
            'End Try

            'CRV.SelectionFormula = "{tblbarang.kode_barang} = '" & lkode.Text & "'"
            'CRV.ReportSource = "stok barcode.rpt"
            'CRV.RefreshReport()
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        Call reset()
    End Sub

    Private Sub ljumlah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ljumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ljumlah_TextChanged(sender As System.Object, e As System.EventArgs) Handles ljumlah.TextChanged

    End Sub

    Private Sub btntutup_Click(sender As System.Object, e As System.EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub
End Class