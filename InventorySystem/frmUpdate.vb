Imports System.Data.OleDb
Public Class frmUpdate
    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to Update?", "Change Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.OK Then
            If con.State = ConnectionState.Closed Then con.Open()
            Dim st As String = "UPDATE [tblInventory] SET IDno = '" & txtID.Text &
                                "', ProductName = '" & txtName.Text & "', ItemCode = '" & txtCode.Text &
                                "', Description = '" & txtDesc.Text & "', Category = '" & cboCat.Text &
                                "', Brand = '" & cboBrand.Text & "', Quantity = '" & TxtQuantity.Text &
                                "', Price = '" & txtPrice.Text &
                                "'  WHERE IDno = '" & frmMain.DataGridView1.SelectedCells(0).Value & "'"
            MessageBox.Show("Process Successful!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim cmd As New OleDbCommand(st, con)
            cmd.ExecuteNonQuery()
            con.Close()
            frmMain.fill()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtQuantity.Text = TxtQuantity.Text - TextBox1.Text
    End Sub
End Class