Imports System.Data.OleDb

Public Class frmMain
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim ds As DataSet = New DataSet
    Dim tables As DataTableCollection = ds.Tables


    Sub fill()
        Dim dt As New DataTable
        Dim str As String = "Select IDno as [IDno], ProductName as [Product Name], ItemCode as [Item Code],Description as [Description], Category as [Category], Brand as [Brand], Quantity as [Quantity], Price as [Price] from tblInventory ORDER By IDno "
        Dim da As New OleDb.OleDbDataAdapter(Str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.Columns(0).HeaderText = "ID no."
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green

    End Sub
    Sub fillOrder()
        Dim dt As New DataTable
        Dim str As String = "Select OrderNumber as [Order Number], OrderDate as [Order Date], Client as [Client],ContactNumber as [Contact Number], ItemCode as [Item Code], Quantity as [Quantity], TotalPrice as [Total Price] from tblOrders ORDER By OrderNumber "
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source2.DataSource = dt
        DataGridView2.DataSource = dt
        DataGridView2.Refresh()
        DataGridView2.Columns(0).HeaderText = "Order no."
        DataGridView2.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridView2.DefaultCellStyle.SelectionBackColor = Color.Green


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

    Public Sub clear()
        txtID.Clear()
        cboCat.SelectedIndex = -1
        cboBrand.SelectedIndex = -1
        txtCode.Clear()
        txtDesc.Clear()
        txtName.Clear()
        txtPrice.Clear()
        TxtQuantity.Clear()
        txtClient.Clear()
        txtOrderNum.Clear()
        txtContact.Clear()
        cboItemCode.SelectedIndex = -1
        txtOPrice.Clear()
        txtTotal.Clear()
        TxtQuantity.Text = 0
    End Sub

    Public Sub clearitems()

        ListView1.Items.Clear()
        ListView2.Items.Clear()
    End Sub
    Public Sub delterminated(ByRef id As String)
        Try
            Dim str1 As String = "Delete * from tblInventory where [tblInventory.IDno]= '" & id & "'"
            Dim cmd1 As New OleDbCommand(str1, con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            fill()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Public Sub delterminated1(ByRef id As String)
        Try
            Dim str1 As String = "Delete * from tblOrders where [tblOrders.OrderNumber]= '" & id & "'"
            Dim cmd1 As New OleDbCommand(str1, con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            fillOrder()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill()
        fillOrder()
        sold()
        inventory()
        Profit()
        '   lstItem.Visible = False
        '    lstQuantity.Visible = False
        Timer1.Enabled = True


    End Sub

    Private Sub btnAddNew_Click(sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If txtID.Text = "" Or txtName.Text = "" Or txtCode.Text = "" Or txtDesc.Text = "" Or cboCat.Text = "" Or cboBrand.Text = "" Or TxtQuantity.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Please fill out all fields.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim sql As String = "Select * FROM tblInventory where IDno = '" & txtID.Text & "' "
            Dim cmd1 As New OleDbCommand(sql, con)
            con.Open()
            Using reader As OleDbDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("ID No. already Exists!")
                    txtID.Focus()
                    txtID.SelectAll()
                Else
                    ListView1.Items.Add(txtID.Text.ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(txtName.Text).ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(txtCode.Text).ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(txtDesc.Text).ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(cboCat.Text).ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(cboBrand.Text).ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(TxtQuantity.Text).ToString)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(txtPrice.Text).ToString)
                    clear()
                End If
                con.Close()
            End Using
        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            For Each item As ListViewItem In ListView1.Items
                If con.State = ConnectionState.Closed Then con.Open()
                Dim st As String = "INSERT INTO [tblInventory](IDno, ProductName, ItemCode, Description, Category, Brand, Quantity, Price) VALUES ('" & item.Text & "','" & item.SubItems(1).Text & "','" & item.SubItems(2).Text & "','" & item.SubItems(3).Text & "','" & item.SubItems(4).Text & "','" & item.SubItems(5).Text & "','" & item.SubItems(6).Text & "','" & item.SubItems(7).Text & "' )"
                Dim cmdd As New OleDbCommand(st, con)
                cmdd.ExecuteNonQuery()
                con.Close()
                Me.fill()
                Me.fillOrder()

                Me.sold()
                Me.inventory()
                Me.Profit()

                clearitems()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmUpdate.TextBox1.Text = txtOQuantity.Text
        frmUpdate.txtID.Text = Me.DataGridView1.SelectedCells(0).Value.ToString
        frmUpdate.txtName.Text = Me.DataGridView1.SelectedCells(1).Value.ToString
        frmUpdate.txtCode.Text = Me.DataGridView1.SelectedCells(2).Value.ToString
        frmUpdate.txtDesc.Text = Me.DataGridView1.SelectedCells(3).Value.ToString
        frmUpdate.cboCat.Text = Me.DataGridView1.SelectedCells(4).Value.ToString
        frmUpdate.cboBrand.Text = Me.DataGridView1.SelectedCells(5).Value.ToString
        frmUpdate.TxtQuantity.Text = Me.DataGridView1.SelectedCells(6).Value.ToString
        frmUpdate.txtPrice.Text = Me.DataGridView1.SelectedCells(7).Value.ToString


        frmUpdate.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
            If DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) > 1 Then
                Dim dr As New DialogResult
                dr = MessageBox.Show("Are you sure you want to permanently delete selected data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If dr = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                Else
                    For i = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                        delterminated(DataGridView1.SelectedRows(i).Cells(0).Value)
                        fill()


                    Next
                End If
            Else

                Dim dr As New DialogResult
                dr = MessageBox.Show("Are you sure you want to permanently delete " & DataGridView1.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If dr = Windows.Forms.DialogResult.Cancel Then
                    DataGridView1.ClearSelection()
                    Exit Sub
                Else
                    delterminated(DataGridView1.SelectedCells(0).Value)
                    fill()


                End If
            End If

        End If
        Me.sold()
        Me.inventory()
        Me.Profit()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtOrderNum.Text = "" Or txtClient.Text = "" Or txtContact.Text = "" Or cboItemCode.Text = "" Or txtOQuantity.Text = "" Or txtOPrice.Text = "" Then
            MessageBox.Show("Please fill out all fields.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            lstItem.Items.Add(Val(cboItemCode.SelectedIndex))
            lstQuantity.Items.Add(txtOQuantity.Value.ToString)

            Dim sql As String = "Select * FROM tblOrders where OrderNumber = '" & txtOrderNum.Text & "' "
            Dim cmd1 As New OleDbCommand(sql, con)
            con.Open()
            Using reader As OleDbDataReader = cmd1.ExecuteReader()
                If reader.HasRows Then
                    MsgBox("Order Code No. already Exists!")
                    txtOrderNum.Focus()
                    txtOrderNum.SelectAll()
                Else
                    ListView2.Items.Add(txtOrderNum.Text.ToString)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(dtOrderDate.Text).ToString)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(txtClient.Text).ToString)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(txtContact.Text).ToString)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(cboItemCode.Text).ToString)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(txtOQuantity.Text).ToString)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(txtTotal.Text).ToString)
                    clear()
                End If
                con.Close()
            End Using
        End If





    End Sub

    Sub sold()
        Try
            Dim amount As Integer
            For index As Integer = 0 To DataGridView2.RowCount - 1
                amount += Convert.ToInt32(DataGridView2.Rows(index).Cells(5).Value)
            Next
            Label20.Text = amount
        Catch ex As Exception

        End Try

    End Sub

    Sub inventory()
        Try
            Dim amount As Integer
            For index As Integer = 0 To DataGridView1.RowCount - 1
                amount += Convert.ToInt32(DataGridView1.Rows(index).Cells(6).Value)
            Next
            Label23.Text = amount
        Catch ex As Exception

        End Try

    End Sub

    Sub Profit()
        Try
            Dim amount As Double
            For index As Integer = 0 To DataGridView2.RowCount - 1
                amount += Convert.ToDecimal(DataGridView2.Rows(index).Cells(6).Value)
            Next
            Label25.Text = "Php " + Val(amount).ToString("N2")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click



        Try

            '     For Each item In lstItem.Items
            '   For Each quan In lstQuantity.Items
            '           DataGridView1.Rows(item).Cells(6).Value = Val(DataGridView1.Rows(item).Cells(6).Value) - Val(quan)
            '  '       Label29.Text = Val(DataGridView1.Rows(item).Cells(6).Value) - Val(quan).ToString
            '  fillOrder()
            '      Next

            '         DataGridView1.Rows(item).Selected = True


            '   Next


            lstItem.Items.Clear()
            lstQuantity.Items.Clear()

            For Each item As ListViewItem In ListView2.Items
                If con.State = ConnectionState.Closed Then con.Open()
                Dim st As String = "INSERT INTO [tblOrders](OrderNumber, OrderDate, Client, ContactNumber, ItemCode, Quantity, TotalPrice) VALUES ('" & item.Text & "','" & item.SubItems(1).Text & "','" & item.SubItems(2).Text & "','" & item.SubItems(3).Text & "','" & item.SubItems(4).Text & "','" & item.SubItems(5).Text & "','" & item.SubItems(6).Text & "')"
                Dim cmdd As New OleDbCommand(st, con)
                cmdd.ExecuteNonQuery()
                con.Close()
                Me.fill()
                Me.fillOrder()

                Me.sold()
                Me.inventory()
                Me.Profit()

                clearitems()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmUpdate1.txtOrderNum.Text = Me.DataGridView2.SelectedCells(0).Value.ToString
        frmUpdate1.txtDate.Text = Me.DataGridView2.SelectedCells(1).Value.ToString
        frmUpdate1.txtClient.Text = Me.DataGridView2.SelectedCells(2).Value.ToString
        frmUpdate1.txtContact.Text = Me.DataGridView2.SelectedCells(3).Value.ToString
        frmUpdate1.cboItemCode.Text = Me.DataGridView2.SelectedCells(4).Value.ToString
        frmUpdate1.txtOQuantity.Text = Me.DataGridView2.SelectedCells(5).Value.ToString
        frmUpdate1.txtOPrice.Text = Me.DataGridView2.SelectedCells(6).Value.ToString

        frmUpdate1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If DataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
                If DataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected) > 1 Then
                    Dim dr As New DialogResult
                    dr = MessageBox.Show("Are you sure you want to permanently delete selected data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    If dr = Windows.Forms.DialogResult.Cancel Then
                        Exit Sub
                    Else
                        For i = DataGridView2.SelectedRows.Count - 1 To 0 Step -1
                            delterminated1(DataGridView2.SelectedRows(i).Cells(0).Value)
                            fillOrder()


                        Next
                    End If
                Else

                    Dim dr As New DialogResult
                    dr = MessageBox.Show("Are you sure you want to permanently delete " & DataGridView2.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    If dr = Windows.Forms.DialogResult.Cancel Then
                        DataGridView2.ClearSelection()
                        Exit Sub
                    Else
                        delterminated1(DataGridView2.SelectedCells(0).Value)
                        fillOrder()


                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboItemCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemCode.SelectedIndexChanged
        source1.Filter = "[Item Code] like  '%' + '" & cboItemCode.Text & "' + '%' "
        Me.DataGridView1.Refresh()

        txtOPrice.Text = DataGridView1.SelectedCells(7).Value

    End Sub

    Private Sub txtOQuantity_Click(sender As Object, e As EventArgs) Handles txtOQuantity.Click
        txtTotal.Text = Val(txtOPrice.Text) * Val(txtOQuantity.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This is an Inventory Management System designed to save the product information to the database and record the orders. This system is design by Cepe, Santiago, Furton, and Linao (2022)", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("dd-MMM-yyy")
        Label26.Text = Date.Now.ToString("hh:mm:ss tt")
        sold()
        inventory()
        Profit()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If cboOrderSearch.SelectedItem = "Order Number" Then
            If TextBox2.Text = "" Then
                source2.Filter = ""
                Me.DataGridView2.Refresh()
            Else
                source2.Filter = "[Order Number] like  '%' + '" & TextBox2.Text & "' + '%' "
                Me.DataGridView2.Refresh()
            End If
        ElseIf cboOrderSearch.SelectedItem = "Client" Then
            If TextBox2.Text = "" Then
                source2.Filter = ""
                Me.DataGridView2.Refresh()
            Else
                source2.Filter = "[Client] like  '%' + '" & TextBox2.Text & "' + '%' "
                Me.DataGridView2.Refresh()
            End If
        ElseIf cboOrderSearch.SelectedItem = "Item Code" Then
            If TextBox2.Text = "" Then
                source2.Filter = ""
                Me.DataGridView2.Refresh()
            Else
                source2.Filter = "[Item Code] like  '%' + '" & TextBox2.Text & "' + '%' "
                Me.DataGridView2.Refresh()
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If cboProdSearch.SelectedItem = "Product Name" Then
            If TextBox3.Text = "" Then
                source1.Filter = ""
                Me.DataGridView1.Refresh()
            Else
                source1.Filter = "[Product Name] like  '%' + '" & TextBox3.Text & "' + '%' "
                Me.DataGridView1.Refresh()
            End If
        ElseIf cboProdSearch.SelectedItem = "Item Code" Then
            If TextBox3.Text = "" Then
                source1.Filter = ""
                Me.DataGridView1.Refresh()
            Else
                source1.Filter = "[Item Code] like  '%' + '" & TextBox3.Text & "' + '%' "
                Me.DataGridView1.Refresh()
            End If
        ElseIf cboProdSearch.SelectedItem = "Category" Then
            If TextBox3.Text = "" Then
                source1.Filter = ""
                Me.DataGridView1.Refresh()
            Else
                source1.Filter = "[Category] like  '%' + '" & TextBox3.Text & "' + '%' "
                Me.DataGridView1.Refresh()
            End If
        ElseIf cboProdSearch.SelectedItem = "Brand" Then
            If TextBox3.Text = "" Then
                source1.Filter = ""
                Me.DataGridView1.Refresh()
            Else
                source1.Filter = "[Brand] like  '%' + '" & TextBox3.Text & "' + '%' "
                Me.DataGridView1.Refresh()
            End If
        End If
    End Sub

    Private Sub cboProdSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProdSearch.SelectedIndexChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        Print1.DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 100, 0)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Print1.Show()
        PrintDocument1.DefaultPageSettings.Landscape = True

        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        print2.Show()
        PrintDocument2.DefaultPageSettings.Landscape = True

        PrintPreviewDialog2.ShowDialog()
        PrintDocument2.Print()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim bm As New Bitmap(Me.DataGridView2.Width, Me.DataGridView2.Height)
        print2.DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 100, 0)
    End Sub

    Private Sub txtOPrice_TextChanged(sender As Object, e As EventArgs) Handles txtOPrice.TextChanged

    End Sub

    Private Sub cboBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrand.SelectedIndexChanged

    End Sub
End Class
