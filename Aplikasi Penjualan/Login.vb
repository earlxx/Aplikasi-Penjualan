Imports System.Data.OleDb

Public Class Login


    Sub rese()
        tid.Text = ""
        tpwd.Text = ""
        tpwd.MaxLength = 15
        tid.Focus()
        tpwd.PasswordChar = "*"
    End Sub
    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call rese()
    End Sub

    Private Sub btnok_Click(sender As System.Object, e As System.EventArgs) Handles btnok.Click

        If tid.Text = "" Or tpwd.Text = "" Then
            MsgBox("kode/password kosong")
            tid.Focus()
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbluser where nama_user = '" & tid.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("User tidak ada")
                tid.Text = ""
                tpwd.Text = ""
                tid.Focus()
                Exit Sub
            Else
                If dr("password_user") <> tpwd.Text Then
                    MsgBox("Password Salah")
                    tid.Text = ""
                    tpwd.Text = ""
                    tid.Focus()
                    Exit Sub
                End If
                Me.Hide()
                Menu_Utama.Show()
                Menu_Utama.toolkode.Text = dr.Item(0)
                Menu_Utama.toolnama.Text = dr.Item(1)
                Menu_Utama.toolstatus.Text = dr.Item(3)

                If Menu_Utama.toolstatus.Text = "OPERATOR" Then
                    Menu_Utama.llaporjual.Visible = False
                    Menu_Utama.btnlaporjual.Enabled = False
                    Menu_Utama.llapormaster.Visible = False
                    Menu_Utama.btnlapormaster.Enabled = False
                ElseIf Menu_Utama.toolstatus.Text = "USER" Then
                    Menu_Utama.lbarang.Visible = False
                    Menu_Utama.btnbarang.Enabled = False
                    Menu_Utama.lcustom.Visible = False
                    Menu_Utama.btncustomer.Enabled = False
                    Menu_Utama.luser.Visible = False
                    Menu_Utama.btnuser.Enabled = False
                    Menu_Utama.llaporjual.Visible = False
                    Menu_Utama.btnlaporjual.Enabled = False
                    Menu_Utama.llapormaster.Visible = False
                    Menu_Utama.btnlapormaster.Enabled = False
                End If

            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub tpwd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tpwd.KeyPress
        If e.KeyChar = Chr(13) Then
            btnok.PerformClick()
        End If
    End Sub
End Class