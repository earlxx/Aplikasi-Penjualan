<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanPenjualan))
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnbulanan = New System.Windows.Forms.Button()
        Me.DTP4 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTP3 = New System.Windows.Forms.DateTimePicker()
        Me.btnperiodik = New System.Windows.Forms.Button()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnharian = New System.Windows.Forms.Button()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 123)
        Me.CRV.Name = "CRV"
        Me.CRV.Size = New System.Drawing.Size(647, 307)
        Me.CRV.TabIndex = 3
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 123)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnbulanan)
        Me.GroupBox4.Controls.Add(Me.DTP4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(309, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(153, 104)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Bulanan"
        '
        'btnbulanan
        '
        Me.btnbulanan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnbulanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbulanan.ForeColor = System.Drawing.Color.Black
        Me.btnbulanan.Location = New System.Drawing.Point(3, 77)
        Me.btnbulanan.Name = "btnbulanan"
        Me.btnbulanan.Size = New System.Drawing.Size(147, 24)
        Me.btnbulanan.TabIndex = 1
        Me.btnbulanan.Text = "View"
        Me.btnbulanan.UseVisualStyleBackColor = True
        '
        'DTP4
        '
        Me.DTP4.CustomFormat = "MMMMyyyy"
        Me.DTP4.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP4.Location = New System.Drawing.Point(3, 18)
        Me.DTP4.Name = "DTP4"
        Me.DTP4.ShowUpDown = True
        Me.DTP4.Size = New System.Drawing.Size(147, 22)
        Me.DTP4.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTP3)
        Me.GroupBox3.Controls.Add(Me.btnperiodik)
        Me.GroupBox3.Controls.Add(Me.DTP2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(156, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 104)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Periodik"
        '
        'DTP3
        '
        Me.DTP3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP3.Location = New System.Drawing.Point(3, 40)
        Me.DTP3.Name = "DTP3"
        Me.DTP3.Size = New System.Drawing.Size(147, 22)
        Me.DTP3.TabIndex = 2
        '
        'btnperiodik
        '
        Me.btnperiodik.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnperiodik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperiodik.ForeColor = System.Drawing.Color.Black
        Me.btnperiodik.Location = New System.Drawing.Point(3, 77)
        Me.btnperiodik.Name = "btnperiodik"
        Me.btnperiodik.Size = New System.Drawing.Size(147, 24)
        Me.btnperiodik.TabIndex = 1
        Me.btnperiodik.Text = "View"
        Me.btnperiodik.UseVisualStyleBackColor = True
        '
        'DTP2
        '
        Me.DTP2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(3, 18)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(147, 22)
        Me.DTP2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnharian)
        Me.GroupBox2.Controls.Add(Me.DTP1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 104)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Harian"
        '
        'btnharian
        '
        Me.btnharian.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnharian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnharian.ForeColor = System.Drawing.Color.Black
        Me.btnharian.Location = New System.Drawing.Point(3, 77)
        Me.btnharian.Name = "btnharian"
        Me.btnharian.Size = New System.Drawing.Size(147, 24)
        Me.btnharian.TabIndex = 1
        Me.btnharian.Text = "View"
        Me.btnharian.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(3, 18)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(147, 22)
        Me.DTP1.TabIndex = 0
        '
        'LaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 430)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LaporanPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnharian As System.Windows.Forms.Button
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnperiodik As System.Windows.Forms.Button
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbulanan As System.Windows.Forms.Button
    Friend WithEvents DTP4 As System.Windows.Forms.DateTimePicker
End Class
