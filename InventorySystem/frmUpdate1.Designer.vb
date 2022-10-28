<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdate1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtOQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cboItemCode = New System.Windows.Forms.ComboBox()
        Me.txtOPrice = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtOrderNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtOQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(188, 216)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(169, 26)
        Me.txtContact.TabIndex = 66
        '
        'txtOQuantity
        '
        Me.txtOQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOQuantity.Location = New System.Drawing.Point(188, 279)
        Me.txtOQuantity.Name = "txtOQuantity"
        Me.txtOQuantity.Size = New System.Drawing.Size(169, 26)
        Me.txtOQuantity.TabIndex = 65
        '
        'cboItemCode
        '
        Me.cboItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemCode.FormattingEnabled = True
        Me.cboItemCode.Items.AddRange(New Object() {"Option 1", "Option 2", "Option 3", "Option 4"})
        Me.cboItemCode.Location = New System.Drawing.Point(188, 248)
        Me.cboItemCode.Name = "cboItemCode"
        Me.cboItemCode.Size = New System.Drawing.Size(169, 28)
        Me.cboItemCode.TabIndex = 63
        '
        'txtOPrice
        '
        Me.txtOPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOPrice.Location = New System.Drawing.Point(188, 313)
        Me.txtOPrice.Name = "txtOPrice"
        Me.txtOPrice.Size = New System.Drawing.Size(169, 26)
        Me.txtOPrice.TabIndex = 61
        '
        'txtClient
        '
        Me.txtClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.Location = New System.Drawing.Point(188, 184)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(169, 26)
        Me.txtClient.TabIndex = 60
        '
        'txtOrderNum
        '
        Me.txtOrderNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNum.Location = New System.Drawing.Point(188, 114)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.Size = New System.Drawing.Size(169, 26)
        Me.txtOrderNum.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "ItemCode"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Contact Number"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 20)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Price"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Quantity"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(43, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 20)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Client Name"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(43, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 20)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Order Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(43, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 20)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Order Number"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(188, 148)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(169, 26)
        Me.txtDate.TabIndex = 67
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkGreen
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(114, 373)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(114, 46)
        Me.btnUpdate.TabIndex = 68
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(234, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 46)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 39)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Update Order"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmUpdate1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 452)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtOQuantity)
        Me.Controls.Add(Me.cboItemCode)
        Me.Controls.Add(Me.txtOPrice)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.txtOrderNum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdate1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtOQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtOQuantity As NumericUpDown
    Friend WithEvents cboItemCode As ComboBox
    Friend WithEvents txtOPrice As TextBox
    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtOrderNum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
