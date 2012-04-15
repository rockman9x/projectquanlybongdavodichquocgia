
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ConnectionString As String
        ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_QLBD.accdb;"
        Dim AccessConnection As New System.Data.OleDb.OleDbConnection(ConnectionString)
        AccessConnection.Open()
        Dim sql As String
        sql = "select * from DoiBong"
        Dim da As New System.Data.OleDb.OleDbDataAdapter(sql, AccessConnection)
        Dim ds As New DataSet

        da.Fill(ds, "DoiBong")
        DataGridView1.DataSource = ds
        AccessConnection.Close()
    End Sub
End Class
