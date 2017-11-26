<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewInvoice
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDisplayOrderNo = New System.Windows.Forms.Label()
        Me.lblDisplaySubTotal = New System.Windows.Forms.Label()
        Me.lblDisplayTotal = New System.Windows.Forms.Label()
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblTelephoneNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblDisplayFirstName = New System.Windows.Forms.Label()
        Me.lblDisplayLastName = New System.Windows.Forms.Label()
        Me.lblDisplayTelNum = New System.Windows.Forms.Label()
        Me.lblDisplayAddr = New System.Windows.Forms.Label()
        Me.lblDisplayCity = New System.Windows.Forms.Label()
        Me.lblDisplayState = New System.Windows.Forms.Label()
        Me.lblDisplayZip = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblDisplayInstructions = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomerInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(9, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(464, 67)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrderNum
        '
        Me.lblOrderNum.Location = New System.Drawing.Point(6, 97)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(100, 23)
        Me.lblOrderNum.TabIndex = 1
        Me.lblOrderNum.Text = "Order No.:"
        Me.lblOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(33, 589)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubTotal.TabIndex = 2
        Me.lblSubTotal.Text = "Subtotal:"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(245, 589)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItems
        '
        Me.lblItems.Location = New System.Drawing.Point(9, 328)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(100, 23)
        Me.lblItems.TabIndex = 4
        Me.lblItems.Text = "Items:"
        Me.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(299, 632)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(91, 632)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 33)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 354)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(461, 191)
        Me.DataGridView1.TabIndex = 7
        '
        'lblDisplayOrderNo
        '
        Me.lblDisplayOrderNo.Location = New System.Drawing.Point(112, 97)
        Me.lblDisplayOrderNo.Name = "lblDisplayOrderNo"
        Me.lblDisplayOrderNo.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayOrderNo.TabIndex = 8
        '
        'lblDisplaySubTotal
        '
        Me.lblDisplaySubTotal.Location = New System.Drawing.Point(139, 589)
        Me.lblDisplaySubTotal.Name = "lblDisplaySubTotal"
        Me.lblDisplaySubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplaySubTotal.TabIndex = 9
        Me.lblDisplaySubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplayTotal
        '
        Me.lblDisplayTotal.Location = New System.Drawing.Point(351, 589)
        Me.lblDisplayTotal.Name = "lblDisplayTotal"
        Me.lblDisplayTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayTotal.TabIndex = 10
        Me.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayInstructions)
        Me.grpCustomerInfo.Controls.Add(Me.lblInstructions)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayZip)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayState)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayCity)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayAddr)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayTelNum)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayLastName)
        Me.grpCustomerInfo.Controls.Add(Me.lblDisplayFirstName)
        Me.grpCustomerInfo.Controls.Add(Me.lblZip)
        Me.grpCustomerInfo.Controls.Add(Me.lblState)
        Me.grpCustomerInfo.Controls.Add(Me.lblCity)
        Me.grpCustomerInfo.Controls.Add(Me.lblAddress)
        Me.grpCustomerInfo.Controls.Add(Me.lblTelephoneNumber)
        Me.grpCustomerInfo.Controls.Add(Me.lblLastName)
        Me.grpCustomerInfo.Controls.Add(Me.lblFirstName)
        Me.grpCustomerInfo.Location = New System.Drawing.Point(9, 123)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Size = New System.Drawing.Size(464, 202)
        Me.grpCustomerInfo.TabIndex = 11
        Me.grpCustomerInfo.TabStop = False
        Me.grpCustomerInfo.Text = "Customer Information"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(7, 22)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(117, 23)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(7, 45)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(117, 23)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name:"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelephoneNumber
        '
        Me.lblTelephoneNumber.Location = New System.Drawing.Point(7, 68)
        Me.lblTelephoneNumber.Name = "lblTelephoneNumber"
        Me.lblTelephoneNumber.Size = New System.Drawing.Size(117, 23)
        Me.lblTelephoneNumber.TabIndex = 2
        Me.lblTelephoneNumber.Text = "Telephone No.:"
        Me.lblTelephoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(7, 91)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(117, 23)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(253, 18)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(83, 23)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City:"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(253, 41)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(83, 23)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblZip
        '
        Me.lblZip.Location = New System.Drawing.Point(253, 64)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(83, 23)
        Me.lblZip.TabIndex = 6
        Me.lblZip.Text = "Zip:"
        Me.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplayFirstName
        '
        Me.lblDisplayFirstName.Location = New System.Drawing.Point(130, 18)
        Me.lblDisplayFirstName.Name = "lblDisplayFirstName"
        Me.lblDisplayFirstName.Size = New System.Drawing.Size(117, 23)
        Me.lblDisplayFirstName.TabIndex = 7
        Me.lblDisplayFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayLastName
        '
        Me.lblDisplayLastName.Location = New System.Drawing.Point(130, 42)
        Me.lblDisplayLastName.Name = "lblDisplayLastName"
        Me.lblDisplayLastName.Size = New System.Drawing.Size(117, 23)
        Me.lblDisplayLastName.TabIndex = 8
        Me.lblDisplayLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayTelNum
        '
        Me.lblDisplayTelNum.Location = New System.Drawing.Point(130, 66)
        Me.lblDisplayTelNum.Name = "lblDisplayTelNum"
        Me.lblDisplayTelNum.Size = New System.Drawing.Size(117, 23)
        Me.lblDisplayTelNum.TabIndex = 9
        Me.lblDisplayTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayAddr
        '
        Me.lblDisplayAddr.Location = New System.Drawing.Point(130, 90)
        Me.lblDisplayAddr.Name = "lblDisplayAddr"
        Me.lblDisplayAddr.Size = New System.Drawing.Size(206, 23)
        Me.lblDisplayAddr.TabIndex = 10
        Me.lblDisplayAddr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayCity
        '
        Me.lblDisplayCity.Location = New System.Drawing.Point(342, 18)
        Me.lblDisplayCity.Name = "lblDisplayCity"
        Me.lblDisplayCity.Size = New System.Drawing.Size(116, 23)
        Me.lblDisplayCity.TabIndex = 11
        Me.lblDisplayCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayState
        '
        Me.lblDisplayState.Location = New System.Drawing.Point(342, 43)
        Me.lblDisplayState.Name = "lblDisplayState"
        Me.lblDisplayState.Size = New System.Drawing.Size(116, 23)
        Me.lblDisplayState.TabIndex = 12
        Me.lblDisplayState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayZip
        '
        Me.lblDisplayZip.Location = New System.Drawing.Point(342, 68)
        Me.lblDisplayZip.Name = "lblDisplayZip"
        Me.lblDisplayZip.Size = New System.Drawing.Size(116, 23)
        Me.lblDisplayZip.TabIndex = 13
        Me.lblDisplayZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(7, 160)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(157, 23)
        Me.lblInstructions.TabIndex = 14
        Me.lblInstructions.Text = "Special Instructions:"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDisplayInstructions
        '
        Me.lblDisplayInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayInstructions.Location = New System.Drawing.Point(170, 140)
        Me.lblDisplayInstructions.Name = "lblDisplayInstructions"
        Me.lblDisplayInstructions.Size = New System.Drawing.Size(288, 59)
        Me.lblDisplayInstructions.TabIndex = 15
        Me.lblDisplayInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmViewInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 682)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.Controls.Add(Me.lblDisplayTotal)
        Me.Controls.Add(Me.lblDisplaySubTotal)
        Me.Controls.Add(Me.lblDisplayOrderNo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblOrderNum)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmViewInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblOrderNum As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDisplayOrderNo As System.Windows.Forms.Label
    Friend WithEvents lblDisplaySubTotal As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTotal As System.Windows.Forms.Label
    Friend WithEvents grpCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblDisplayAddr As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTelNum As System.Windows.Forms.Label
    Friend WithEvents lblDisplayLastName As System.Windows.Forms.Label
    Friend WithEvents lblDisplayFirstName As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblTelephoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblDisplayZip As System.Windows.Forms.Label
    Friend WithEvents lblDisplayState As System.Windows.Forms.Label
    Friend WithEvents lblDisplayCity As System.Windows.Forms.Label
    Friend WithEvents lblDisplayInstructions As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
End Class
