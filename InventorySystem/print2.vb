Imports System.Data.OleDb
Public Class print2
    Dim source1 As New BindingSource()
    Private Sub print2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim str As String = "Select OrderNumber as [Order Number], OrderDate as [Order Date], Client as [Client],ContactNumber as [Contact Number], ItemCode as [Item Code], Quantity as [Quantity], TotalPrice as [Total Price] from tblOrders ORDER By OrderNumber "
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.Columns(0).HeaderText = "Order no."
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green

    End Sub
End Class