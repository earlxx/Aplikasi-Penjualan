Imports System.Data.OleDb

Public Class Supplier
    Sub reset()
        tkode.Text = ""
        tnama.Text = ""
        talamat.Text = ""
        ttelepon.Text = ""
        tcari.text = ""
        tkode.MaxLength = 5
        tkode.Focus()
    End Sub

    Sub tampildgv1()
        Call koneksi()
        da = New OleDbDataAdapter(" select * from tblsupplier", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
        DGV1.ReadOnly = True
        DGV1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
        DGV1.Columns(1).Width = 155
    End Sub
    Private Sub supplier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call reset()
        Call tampildgv1()

    End Sub

    Private Sub tkode_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OleDbCommand(" select * from tblsupplier where kode_supplier = '" & tkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tnama.Text = dr.Item(1)
                talamat.Text = dr.Item(2)
                ttelepon.Text = dr.Item(3)
            Else
                tnama.Text = ""
                talamat.Text = ""
                ttelepon.Text = ""
                tnama.Focus()
            End If
        End If
    End Sub

    Private Sub tcari_OnTextChange(sender As System.Object, e As System.EventArgs) Handles tcari.OnTextChange
        Call koneksi()
        da = New OleDbDataAdapter("select * from tblsupplier where kode_supplier like '%" & tcari.text & "%' or nama_supplier like '%" & tcari.text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If tkode.Text = "" Or tnama.Text = "" Or talamat.Text = "" Or ttelepon.Text = "" Then
            MsgBox("data supplier belum lengkap")
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand(" select * from tblsupplier where kode_supplier = '" & tkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call koneksi()
                Dim simpan As String = "insert into tblsupplier values ('" & tkode.Text & "', '" & tnama.Text & "', '" & talamat.Text & "', '" & ttelepon.Text & "')"
                cmd = New OleDbCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("data supplier berhasil disimpan")
                Call reset()
                Call tampildgv1()
            Else
                Call koneksi()
                Dim edit As String = "update tblsupplier set nama_supplier ='" & tnama.Text & "', alamat_supplier ='" & talamat.Text & "',telepon_supplier ='" & ttelepon.Text & "' where kode_supplier ='" & tkode.Text & "'"
                cmd = New OleDbCommand(edit, conn)
                cmd.ExecuteNonQuery()
                MsgBox("data berhasil edit")
                Call reset()
                Call tampildgv1()
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        If tkode.Text = "" Then
            MsgBox("kode supplier masih kosong")
            tkode.Focus()
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand(" select * from tblsupplier where kode_supplier = '" & tkode.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim hapus As String = "delete from tblsupplier where kode_supplier = '" & tkode.Text & "'"
                If MessageBox.Show("hapus data ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call koneksi()
                    cmd = New OleDbCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("data berhasil dihapus")
                    Call reset()
                    Call tampildgv1()
                Else
                    Call reset()
                End If

            End If
        End If
    End Sub

    Private Sub btnbatal_Click(sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        Call reset()
        Call tampildgv1()

    End Sub


    Private Sub DGV1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseClick
        On Error Resume Next
        tkode.Text = DGV1.Rows(e.RowIndex).Cells(0).Value
        tnama.Text = DGV1.Rows(e.RowIndex).Cells(1).Value
        talamat.Text = DGV1.Rows(e.RowIndex).Cells(2).Value
        ttelepon.Text = DGV1.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub btntutup_Click(sender As System.Object, e As System.EventArgs) Handles btntutup.Click
        Me.Close()

    End Sub
End Class