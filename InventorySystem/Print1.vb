Imports System.Data.OleDb
Public Class Print1
    Dim source1 As New BindingSource()
    Private Sub Print1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim str As String = "Select IDno as [IDno], ProductName as [Product Name], ItemCode as [Item Code],Description as [Description], Category as [Category], Brand as [Brand], Quantity as [Quantity], Price as [Price] from tblInventory ORDER By IDno "
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.Columns(0).HeaderText = "ID no."
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.White

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class