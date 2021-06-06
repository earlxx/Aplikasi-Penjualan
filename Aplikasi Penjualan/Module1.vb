Imports System.Data.OleDb

Module Module1

    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public str As String

    Public Sub koneksi()
        conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source = dtbkasir.mdb")
        conn.Open()
    End Sub
End Module
