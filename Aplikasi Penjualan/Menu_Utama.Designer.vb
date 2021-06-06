<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolkode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolnama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbarang = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btncustomer = New System.Windows.Forms.Button()
        Me.btnpenjualan = New System.Windows.Forms.Button()
        Me.btnhistori = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btnlaporjual = New System.Windows.Forms.Button()
        Me.btnlapormaster = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lbarang = New System.Windows.Forms.Label()
        Me.luser = New System.Windows.Forms.Label()
        Me.lcustom = New System.Windows.Forms.Label()
        Me.lpenjualan = New System.Windows.Forms.Label()
        Me.lhistori = New System.Windows.Forms.Label()
        Me.lbarcode = New System.Windows.Forms.Label()
        Me.llaporjual = New System.Windows.Forms.Label()
        Me.llapormaster = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolkode, Me.toolnama, Me.toolstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 699)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'toolkode
        '
        Me.toolkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolkode.Name = "toolkode"
        Me.toolkode.Size = New System.Drawing.Size(39, 17)
        Me.toolkode.Text = "kode"
        '
        'toolnama
        '
        Me.toolnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolnama.Name = "toolnama"
        Me.toolnama.Size = New System.Drawing.Size(42, 17)
        Me.toolnama.Text = "nama"
        '
        'toolstatus
        '
        Me.toolstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolstatus.Name = "toolstatus"
        Me.toolstatus.Size = New System.Drawing.Size(43, 17)
        Me.toolstatus.Text = "status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.llapormaster)
        Me.Panel1.Controls.Add(Me.llaporjual)
        Me.Panel1.Controls.Add(Me.lbarcode)
        Me.Panel1.Controls.Add(Me.lhistori)
        Me.Panel1.Controls.Add(Me.lpenjualan)
        Me.Panel1.Controls.Add(Me.lcustom)
        Me.Panel1.Controls.Add(Me.luser)
        Me.Panel1.Controls.Add(Me.lbarang)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Controls.Add(Me.btnlapormaster)
        Me.Panel1.Controls.Add(Me.btnuser)
        Me.Panel1.Controls.Add(Me.btncustomer)
        Me.Panel1.Controls.Add(Me.btnlaporjual)
        Me.Panel1.Controls.Add(Me.btnbarang)
        Me.Panel1.Controls.Add(Me.btncetak)
        Me.Panel1.Controls.Add(Me.btnhistori)
        Me.Panel1.Controls.Add(Me.btnpenjualan)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 699)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnbarang
        '
        Me.btnbarang.FlatAppearance.BorderSize = 0
        Me.btnbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbarang.ForeColor = System.Drawing.Color.White
        Me.btnbarang.Location = New System.Drawing.Point(0, 183)
        Me.btnbarang.Name = "btnbarang"
        Me.btnbarang.Size = New System.Drawing.Size(165, 33)
        Me.btnbarang.TabIndex = 1
        Me.btnbarang.Text = "Barang"
        Me.btnbarang.UseVisualStyleBackColor = True
        '
        'btnuser
        '
        Me.btnuser.FlatAppearance.BorderSize = 0
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.Color.White
        Me.btnuser.Location = New System.Drawing.Point(0, 222)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(165, 33)
        Me.btnuser.TabIndex = 2
        Me.btnuser.Text = "User"
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'btncustomer
        '
        Me.btncustomer.FlatAppearance.BorderSize = 0
        Me.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomer.ForeColor = System.Drawing.Color.White
        Me.btncustomer.Location = New System.Drawing.Point(0, 261)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(165, 33)
        Me.btncustomer.TabIndex = 3
        Me.btncustomer.Text = "Customer"
        Me.btncustomer.UseVisualStyleBackColor = True
        '
        'btnpenjualan
        '
        Me.btnpenjualan.FlatAppearance.BorderSize = 0
        Me.btnpenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpenjualan.ForeColor = System.Drawing.Color.White
        Me.btnpenjualan.Location = New System.Drawing.Point(0, 341)
        Me.btnpenjualan.Name = "btnpenjualan"
        Me.btnpenjualan.Size = New System.Drawing.Size(165, 33)
        Me.btnpenjualan.TabIndex = 4
        Me.btnpenjualan.Text = "Penjualan"
        Me.btnpenjualan.UseVisualStyleBackColor = True
        '
        'btnhistori
        '
        Me.btnhistori.FlatAppearance.BorderSize = 0
        Me.btnhistori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhistori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhistori.ForeColor = System.Drawing.Color.White
        Me.btnhistori.Location = New System.Drawing.Point(0, 380)
        Me.btnhistori.Name = "btnhistori"
        Me.btnhistori.Size = New System.Drawing.Size(165, 33)
        Me.btnhistori.TabIndex = 5
        Me.btnhistori.Text = "Histori Penjualan"
        Me.btnhistori.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.FlatAppearance.BorderSize = 0
        Me.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncetak.ForeColor = System.Drawing.Color.White
        Me.btncetak.Location = New System.Drawing.Point(0, 419)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(165, 33)
        Me.btncetak.TabIndex = 6
        Me.btncetak.Text = "Cetak Barcode"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btnlaporjual
        '
        Me.btnlaporjual.FlatAppearance.BorderSize = 0
        Me.btnlaporjual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporjual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporjual.ForeColor = System.Drawing.Color.White
        Me.btnlaporjual.Location = New System.Drawing.Point(0, 499)
        Me.btnlaporjual.Name = "btnlaporjual"
        Me.btnlaporjual.Size = New System.Drawing.Size(165, 33)
        Me.btnlaporjual.TabIndex = 7
        Me.btnlaporjual.Text = "Laporan Penjualan"
        Me.btnlaporjual.UseVisualStyleBackColor = True
        '
        'btnlapormaster
        '
        Me.btnlapormaster.FlatAppearance.BorderSize = 0
        Me.btnlapormaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlapormaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlapormaster.ForeColor = System.Drawing.Color.White
        Me.btnlapormaster.Location = New System.Drawing.Point(0, 538)
        Me.btnlapormaster.Name = "btnlapormaster"
        Me.btnlapormaster.Size = New System.Drawing.Size(165, 33)
        Me.btnlapormaster.TabIndex = 8
        Me.btnlapormaster.Text = "Laporan Master"
        Me.btnlapormaster.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.FlatAppearance.BorderSize = 0
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(0, 629)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(165, 33)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lbarang
        '
        Me.lbarang.BackColor = System.Drawing.Color.Yellow
        Me.lbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbarang.Location = New System.Drawing.Point(-3, 183)
        Me.lbarang.Name = "lbarang"
        Me.lbarang.Size = New System.Drawing.Size(12, 33)
        Me.lbarang.TabIndex = 4
        '
        'luser
        '
        Me.luser.BackColor = System.Drawing.Color.Yellow
        Me.luser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.luser.Location = New System.Drawing.Point(-3, 222)
        Me.luser.Name = "luser"
        Me.luser.Size = New System.Drawing.Size(12, 33)
        Me.luser.TabIndex = 10
        '
        'lcustom
        '
        Me.lcustom.BackColor = System.Drawing.Color.Yellow
        Me.lcustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lcustom.Location = New System.Drawing.Point(-3, 261)
        Me.lcustom.Name = "lcustom"
        Me.lcustom.Size = New System.Drawing.Size(12, 33)
        Me.lcustom.TabIndex = 11
        '
        'lpenjualan
        '
        Me.lpenjualan.BackColor = System.Drawing.Color.Yellow
        Me.lpenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lpenjualan.Location = New System.Drawing.Point(-3, 341)
        Me.lpenjualan.Name = "lpenjualan"
        Me.lpenjualan.Size = New System.Drawing.Size(12, 33)
        Me.lpenjualan.TabIndex = 12
        '
        'lhistori
        '
        Me.lhistori.BackColor = System.Drawing.Color.Yellow
        Me.lhistori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lhistori.Location = New System.Drawing.Point(-3, 380)
        Me.lhistori.Name = "lhistori"
        Me.lhistori.Size = New System.Drawing.Size(12, 33)
        Me.lhistori.TabIndex = 13
        '
        'lbarcode
        '
        Me.lbarcode.BackColor = System.Drawing.Color.Yellow
        Me.lbarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbarcode.Location = New System.Drawing.Point(-3, 419)
        Me.lbarcode.Name = "lbarcode"
        Me.lbarcode.Size = New System.Drawing.Size(12, 33)
        Me.lbarcode.TabIndex = 14
        '
        'llaporjual
        '
        Me.llaporjual.BackColor = System.Drawing.Color.Yellow
        Me.llaporjual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llaporjual.Location = New System.Drawing.Point(-3, 499)
        Me.llaporjual.Name = "llaporjual"
        Me.llaporjual.Size = New System.Drawing.Size(12, 33)
        Me.llaporjual.TabIndex = 15
        '
        'llapormaster
        '
        Me.llapormaster.BackColor = System.Drawing.Color.Yellow
        Me.llapormaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llapormaster.Location = New System.Drawing.Point(-3, 538)
        Me.llapormaster.Name = "llapormaster"
        Me.llapormaster.Size = New System.Drawing.Size(12, 33)
        Me.llapormaster.TabIndex = 16
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Menu_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents toolkode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolnama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnpenjualan As System.Windows.Forms.Button
    Friend WithEvents btncustomer As System.Windows.Forms.Button
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents btnbarang As System.Windows.Forms.Button
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btnhistori As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnlapormaster As System.Windows.Forms.Button
    Friend WithEvents btnlaporjual As System.Windows.Forms.Button
    Friend WithEvents llapormaster As System.Windows.Forms.Label
    Friend WithEvents llaporjual As System.Windows.Forms.Label
    Friend WithEvents lbarcode As System.Windows.Forms.Label
    Friend WithEvents lhistori As System.Windows.Forms.Label
    Friend WithEvents lpenjualan As System.Windows.Forms.Label
    Friend WithEvents lcustom As System.Windows.Forms.Label
    Friend WithEvents luser As System.Windows.Forms.Label
    Friend WithEvents lbarang As System.Windows.Forms.Label
End Class
