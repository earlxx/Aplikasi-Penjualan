﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembelian))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tcari = New Bunifu.Framework.UI.BunifuTextbox()
        Me.DGVBarang = New System.Windows.Forms.DataGridView()
        Me.ldibayar = New System.Windows.Forms.TextBox()
        Me.lkembali = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lfaktur = New System.Windows.Forms.TextBox()
        Me.cmbcustomer = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ltanggal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ltotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.ljumlah = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.tcari)
        Me.GroupBox3.Controls.Add(Me.DGVBarang)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(630, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 277)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'tcari
        '
        Me.tcari.BackColor = System.Drawing.Color.White
        Me.tcari.BackgroundImage = CType(resources.GetObject("tcari.BackgroundImage"), System.Drawing.Image)
        Me.tcari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tcari.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcari.ForeColor = System.Drawing.Color.Black
        Me.tcari.Icon = CType(resources.GetObject("tcari.Icon"), System.Drawing.Image)
        Me.tcari.Location = New System.Drawing.Point(3, 242)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(202, 32)
        Me.tcari.TabIndex = 4
        Me.tcari.text = ""
        '
        'DGVBarang
        '
        Me.DGVBarang.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGVBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGVBarang.Location = New System.Drawing.Point(3, 16)
        Me.DGVBarang.Name = "DGVBarang"
        Me.DGVBarang.Size = New System.Drawing.Size(202, 258)
        Me.DGVBarang.TabIndex = 0
        '
        'ldibayar
        '
        Me.ldibayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldibayar.Location = New System.Drawing.Point(517, 42)
        Me.ldibayar.Name = "ldibayar"
        Me.ldibayar.Size = New System.Drawing.Size(100, 22)
        Me.ldibayar.TabIndex = 15
        '
        'lkembali
        '
        Me.lkembali.BackColor = System.Drawing.Color.LightGray
        Me.lkembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lkembali.Location = New System.Drawing.Point(517, 67)
        Me.lkembali.Name = "lkembali"
        Me.lkembali.Size = New System.Drawing.Size(100, 23)
        Me.lkembali.TabIndex = 14
        Me.lkembali.Text = "Label12"
        Me.lkembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(411, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Kembali"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.LightGray
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGV.Location = New System.Drawing.Point(0, 91)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(630, 277)
        Me.DGV.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lfaktur)
        Me.GroupBox1.Controls.Add(Me.cmbcustomer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ltanggal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 91)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'lfaktur
        '
        Me.lfaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lfaktur.Location = New System.Drawing.Point(112, 19)
        Me.lfaktur.Name = "lfaktur"
        Me.lfaktur.Size = New System.Drawing.Size(155, 22)
        Me.lfaktur.TabIndex = 17
        '
        'cmbcustomer
        '
        Me.cmbcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcustomer.FormattingEnabled = True
        Me.cmbcustomer.Location = New System.Drawing.Point(411, 19)
        Me.cmbcustomer.Name = "cmbcustomer"
        Me.cmbcustomer.Size = New System.Drawing.Size(421, 24)
        Me.cmbcustomer.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(303, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Supplier"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ltanggal
        '
        Me.ltanggal.BackColor = System.Drawing.Color.LightGray
        Me.ltanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ltanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltanggal.Location = New System.Drawing.Point(112, 48)
        Me.ltanggal.Name = "ltanggal"
        Me.ltanggal.Size = New System.Drawing.Size(155, 23)
        Me.ltanggal.TabIndex = 3
        Me.ltanggal.Text = "Label4"
        Me.ltanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ldibayar)
        Me.GroupBox2.Controls.Add(Me.lkembali)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ltotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btntutup)
        Me.GroupBox2.Controls.Add(Me.ljumlah)
        Me.GroupBox2.Controls.Add(Me.btnbatal)
        Me.GroupBox2.Controls.Add(Me.btnsimpan)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(838, 100)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(411, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Dibayar"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ltotal
        '
        Me.ltotal.BackColor = System.Drawing.Color.LightGray
        Me.ltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltotal.Location = New System.Drawing.Point(517, 15)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.Size = New System.Drawing.Size(100, 23)
        Me.ltotal.TabIndex = 11
        Me.ltotal.Text = "Label9"
        Me.ltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(411, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total Harga"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(254, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Jumlah Barang"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btntutup
        '
        Me.btntutup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btntutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntutup.Image = CType(resources.GetObject("btntutup.Image"), System.Drawing.Image)
        Me.btntutup.Location = New System.Drawing.Point(151, 16)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(74, 81)
        Me.btntutup.TabIndex = 7
        Me.btntutup.Text = "Tutup"
        Me.btntutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'ljumlah
        '
        Me.ljumlah.BackColor = System.Drawing.Color.LightGray
        Me.ljumlah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ljumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ljumlah.Location = New System.Drawing.Point(254, 44)
        Me.ljumlah.Name = "ljumlah"
        Me.ljumlah.Size = New System.Drawing.Size(100, 23)
        Me.ljumlah.TabIndex = 9
        Me.ljumlah.Text = "Label7"
        Me.ljumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnbatal
        '
        Me.btnbatal.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Image = CType(resources.GetObject("btnbatal.Image"), System.Drawing.Image)
        Me.btnbatal.Location = New System.Drawing.Point(77, 16)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(74, 81)
        Me.btnbatal.TabIndex = 6
        Me.btnbatal.Text = "Refresh"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(3, 16)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(74, 81)
        Me.btnsimpan.TabIndex = 4
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 468)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Pembelian"
        Me.Text = "Pembelian"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGVBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tcari As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents DGVBarang As System.Windows.Forms.DataGridView
    Friend WithEvents ldibayar As System.Windows.Forms.TextBox
    Friend WithEvents lkembali As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lfaktur As System.Windows.Forms.TextBox
    Friend WithEvents cmbcustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ltanggal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btntutup As System.Windows.Forms.Button
    Friend WithEvents ljumlah As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
End Class
