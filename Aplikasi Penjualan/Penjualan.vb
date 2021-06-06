Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class Penjualan

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
        formatuangkebilangan = Replace(N, ".", "")
    End Function

    Sub faktis()
        Call koneksi()
        cmd = New OleDbCommand("select faktur from tblpenjualan order by faktur desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            lfaktur.Text = Format(Today, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(dr.Item(0), 6) = Format(Today, "yyMMdd") Then
                lfaktur.Text = dr.Item(0) + 1
            Else
                lfaktur.Text = Format(Today, "yyMMdd") + "0001"
            End If
        End If
    End Sub

    Sub baranglist()
        Call koneksi()
        da = New OleDbDataAdapter(" select * from tblbarang where stok > 1", conn)
        ds = New DataSet
        da.Fill(ds)
        DGVBarang.DataSource = ds.Tables(0)
        DGVBarang.ReadOnly = True

        DGVBarang.Columns(0).Visible = False
        DGVBarang.Columns(2).Visible = False
        DGVBarang.Columns(3).Visible = False
        DGVBarang.Columns(4).Visible = False
        DGVBarang.Columns(5).Visible = False
        DGVBarang.Columns(1).Width = 150
    End Sub

    Sub reset()
        Button1.Text = FormatNumber(50000, 0)
        Button2.Text = FormatNumber(100000, 0)
        Button4.Text = FormatNumber(200000, 0)
        Button3.Text = FormatNumber(300000, 0)
        Button6.Text = FormatNumber(500000, 0)
        Button5.Text = FormatNumber(1000000, 0)
        cmbcustomer.Text = ""
        ltotal.Text = 0
        ljumlah.Text = 0
        ldibayar.Text = ""
        lkembali.Text = 0
        DGV.Focus()
        DGV.Rows.Clear()
    End Sub

    Sub kolom()
        DGV.Columns.Add("Kode", "Kode")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Harga", "Harga")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Subtotal", "Sub Total")
        DGV.Columns(1).Width = 170
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(4).ReadOnly = True


    End Sub
    Private Sub Penjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call faktis()
        ltanggal.Text = Today
        Call reset()
        Call koneksi()
        cmd = New OleDbCommand(" select * from tblcustomer", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmbcustomer.Items.Add(dr.Item(0))
        Loop
        Call baranglist()
        Call kolom()

    End Sub

    Sub hitungjumlah()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGV.RowCount - 1
            hitung = hitung + DGV.Rows(baris).Cells(3).Value
            ljumlah.Text = FormatNumber(hitung, 0)
        Next
    End Sub

    Sub hitungharga()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGV.RowCount - 1
            hitung = hitung + DGV.Rows(baris).Cells(4).Value
            ltotal.Text = FormatNumber(hitung, 0)

        Next
    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit

        If e.ColumnIndex = 0 Then
            For baris As Integer = 0 To DGV.RowCount - 2
                DGV.Rows(baris).Cells(0).Value = UCase(DGV.Rows(baris).Cells(0).Value)
                ' SendKeys.Send("{DOWN}")
            Next
            For barisatas As Integer = 0 To DGV.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To DGV.RowCount - 1
                    If DGV.Rows(barisbawah).Cells(0).Value = DGV.Rows(barisatas).Cells(0).Value Then
                        ' MsgBox("kode ini sudah di entri")
                        DGV.Rows(barisatas).Cells(3).Value = DGV.Rows(barisatas).Cells(3).Value + 1
                        DGV.Rows(barisatas).Cells(4).Value = DGV.Rows(barisatas).Cells(2).Value * DGV.Rows(barisatas).Cells(3).Value
                        Call hitungjumlah()
                        Call hitungharga()
                        SendKeys.Send("{DOWN}")
                        DGV.Rows.RemoveAt(barisbawah)
                        'SendKeys.Send("{UP}")
                        'DGV.Rows(barisbawah).Cells(0).Value = ""
                        Exit Sub
                    End If
                Next
            Next

            Call koneksi()
            cmd = New OleDbCommand(" select * from tblbarang where kode_barang = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
              
                DGV.Rows(e.RowIndex).Cells(1).Value = dr.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = dr.Item(4)
                DGV.Rows(e.RowIndex).Cells(3).Value = 1
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                Call hitungjumlah()
                Call hitungharga()
            Else
                MsgBox("kode barang tidak ada")
                SendKeys.Send("{UP}")
                DGV.Rows(e.RowIndex).Cells(0).Value = ""
            End If
        End If

        If e.ColumnIndex = 3 Then
            Try
                Call koneksi()
                cmd = New OleDbCommand("select * from tblbarang where kode_barang = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If DGV.Rows(e.RowIndex).Cells(3).Value > dr.Item(5) Then
                    MsgBox("stok hanya ada" & Space(1) & dr.Item(5))
                    SendKeys.Send("{UP}")
                    DGV.Rows(e.RowIndex).Cells(3).Value = dr.Item(5)
                    DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                Else
                    DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
                End If
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Catch ex As Exception
                MsgBox("harus angka")
                SendKeys.Send("{UP}")
                DGV.Rows(e.RowIndex).Cells(3).Value = 1
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            End Try
            DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Call hitungjumlah()
            Call hitungharga()

        End If
        DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub


    Private Sub DGV_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        '   If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(8) Then
            DGV.Rows.RemoveAt(DGV.CurrentCell.RowIndex)
            Call hitungjumlah()
            Call hitungharga()
        End If
            If e.KeyChar = Chr(13) Then
                ldibayar.Focus()
            End If
    End Sub

    Private Sub ldibayar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ldibayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If e.KeyChar = Chr(13) Then
            If Val(ldibayar.Text) < Val(ltotal.Text) Then
                MsgBox("pembayaran masih kurang")
                ldibayar.Focus()
                Exit Sub
            ElseIf Val(ldibayar.Text) >= Val(ltotal.Text) Then
                '   lkembali.Text = Val(ldibayar.Text) - Val(ltotal.Text)
                lkembali.Text = FormatNumber(Val(ldibayar.Text - ltotal.Text), 0)
                btnsimpan.Focus()
            End If
        End If
    End Sub

    Private Sub ldibayar_TextChanged(sender As System.Object, e As System.EventArgs) Handles ldibayar.TextChanged
        formatuang(ldibayar)
        '  On Error Resume Next
        If ldibayar.Text = "" Then
            lkembali.Text = 0
        Else
            lkembali.Text = FormatNumber(Val(ldibayar.Text - ltotal.Text), 0)
        End If

    End Sub

    Private Sub btnbatal_Click(sender As System.Object, e As System.EventArgs) Handles btnbatal.Click
        Call reset()

    End Sub

    Private Sub btntutup_Click(sender As System.Object, e As System.EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If ldibayar.Text = "" Or ldibayar.Text = 0 Then
            MsgBox("isi jumlah pembayaran")
            Exit Sub
        End If

        Dim simpan1 As String = "insert into tblpenjualan values('" & lfaktur.Text & "', '" & ltanggal.Text & "', '" & cmbcustomer.Text & "','" & ljumlah.Text & "','" & ltotal.Text & "','" & ldibayar.Text & "','" & lkembali.Text & "', '" & Menu_Utama.toolkode.Text & "')" ''USR01')" 
        cmd = New OleDbCommand(simpan1, conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To DGV.RowCount - 2
            Dim simpan2 As String = "insert into tbldetailjual values ('" & lfaktur.Text & "','" & DGV.Rows(baris).Cells(0).Value.ToString & "','" & DGV.Rows(baris).Cells(1).Value.ToString & "','" & DGV.Rows(baris).Cells(2).Value & "','" & DGV.Rows(baris).Cells(3).Value & "','" & DGV.Rows(baris).Cells(4).Value & "')"
            cmd = New OleDbCommand(simpan2, conn)
            cmd.ExecuteNonQuery()


            cmd = New OleDbCommand("select * from tblbarang where kode_barang = '" & DGV.Rows(baris).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim kurangstok As String = "update tblbarang set stok = '" & dr.Item(5) - DGV.Rows(baris).Cells(3).Value & "' where kode_barang = '" & DGV.Rows(baris).Cells(0).Value & "'"
                cmd = New OleDbCommand(kurangstok, conn)
                cmd.ExecuteNonQuery()
            End If

        Next

        If MessageBox.Show("cetak faktur ??", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Faktur.Show()
            Faktur.CRV.ReportSource = "faktur penjualan.rpt"
            Faktur.CRV.RefreshReport()

            'report.Load("laporan harian.rpt")
            'report.Refresh()
            'report.PrintOptions.PrinterName = "EPSON L360 Series"
            'report.PrintToPrinter(1, False, 0, 0)
        End If
        Call reset()
        Call faktis()

    End Sub

    Private Sub tcari_OnTextChange(sender As System.Object, e As System.EventArgs) Handles tcari.OnTextChange
        Call koneksi()
        da = New OleDbDataAdapter("select * from tblbarang where nama_barang like '%" & tcari.text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DGVBarang.DataSource = ds.Tables(0)
        '    listbarang.DataSource = ds.Tables(0)

    End Sub


    Private Sub DGVBarang_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVBarang.CellMouseClick
        On Error Resume Next
        ' DGV.Focus()
        Dim baris As Integer = DGV.RowCount - 1
        DGV.Rows.Add(DGVBarang.Rows(e.RowIndex).Cells(0).Value, DGVBarang.Rows(e.RowIndex).Cells(1).Value, DGVBarang.Rows(e.RowIndex).Cells(4).Value)
        tcari.text = ""
        'Call baranglist()

        Call koneksi()
        cmd = New OleDbCommand("select * from tblbarang where kode_barang = '" & DGV.Rows(baris).Cells(0).Value & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            'DGV.Rows(baris).Cells(1).Value = dr.Item(1)
            'DGV.Rows(baris).Cells(2).Value = dr.Item(4)
            DGV.Rows(baris).Cells(3).Value = 1
            DGV.Rows(baris).Cells(4).Value = DGV.Rows(baris).Cells(2).Value * DGV.Rows(baris).Cells(3).Value

            ' DGV.CurrentCell = DGV(0, baris)
            '  SendKeys.Send("{TAB}")
        End If

        For barisatas As Integer = 0 To DGV.RowCount - 1
            For barisbawah As Integer = barisatas + 1 To DGV.RowCount - 1
                If DGV.Rows(barisbawah).Cells(0).Value = DGV.Rows(barisatas).Cells(0).Value Then
                    DGV.Rows(barisatas).Cells(3).Value = DGV.Rows(barisatas).Cells(3).Value + 0
                    DGV.Rows(barisatas).Cells(4).Value = DGV.Rows(barisatas).Cells(2).Value * DGV.Rows(barisatas).Cells(3).Value

                    '  SendKeys.Send("{UP}")
                    DGV.Rows.RemoveAt(barisbawah)
                    '  DGV.CurrentCell = DGV(0, baris)
                    Exit Sub
                End If
                Call hitungjumlah()
                Call hitungharga()
              
            Next
        Next
        DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ldibayar.Text = Button1.Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ldibayar.Text = Button2.Text
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ldibayar.Text = Button4.Text
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ldibayar.Text = Button3.Text
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ldibayar.Text = Button6.Text
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ldibayar.Text = Button5.Text
    End Sub
End Class