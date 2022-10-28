Imports System.Data.OleDb
Public Class frmUpdate1
    Private Sub frmUpdate1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        cboItemCode.Items.Clear()
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        cmd.CommandText = "SELECT * from tblInventory"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cboItemCode.Items.Add(dr.GetString(3))
        End While
        dr.Close()
        con.Close()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to Update?", "Change Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.OK Then
            If con.State = ConnectionState.Closed Then con.Open()
            Dim st As String = "UPDATE [tblOrders] SET OrderNumber = '" & txtOrderNum.Text &
                                "', OrderDate = '" & txtDate.Text & "', Client = '" & txtClient.Text &
                                "', ContactNumber = '" & txtContact.Text & "', ItemCode = '" & cboItemCode.Text &
                                "', Quantity = '" & txtOQuantity.Text & "', TotalPrice = '" & txtOPrice.Text &
                                "'  WHERE OrderNumber = '" & frmMain.DataGridView2.SelectedCells(0).Value & "'"
            MessageBox.Show("Process Successful!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim cmd As New OleDbCommand(st, con)
            cmd.ExecuteNonQuery()
            con.Close()
            frmMain.fillOrder()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class