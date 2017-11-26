<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrders
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrders))
        Me.errFirstName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errTelNumber = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errCity = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errState = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.lblSpecialInstructions = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.errZip = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.errLastName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errBookTitle = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errStoreNum = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errQuantity = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.rtbSpecialInstructions = New System.Windows.Forms.RichTextBox()
        Me.btnHome = New System.Windows.Forms.ToolStripButton()
        Me.stpOrdersMain = New System.Windows.Forms.ToolStrip()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnInvoices = New System.Windows.Forms.ToolStripButton()
        Me.txtQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.lblStoreNumber = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.grpCustInfo = New System.Windows.Forms.GroupBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lstTitles = New System.Windows.Forms.ListBox()
        Me.TitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookCollectionDataSet1 = New BookProject.BookCollectionDataSet()
        Me.cboStore = New System.Windows.Forms.ComboBox()
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitlesTableAdapter1 = New BookProject.BookCollectionDataSetTableAdapters.titlesTableAdapter()
        Me.StoresTableAdapter1 = New BookProject.BookCollectionDataSetTableAdapters.storesTableAdapter()
        CType(Me.errFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errTelNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errBookTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errStoreNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stpOrdersMain.SuspendLayout()
        Me.grpCustInfo.SuspendLayout()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookCollectionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'errFirstName
        '
        Me.errFirstName.ContainerControl = Me
        '
        'errTelNumber
        '
        Me.errTelNumber.ContainerControl = Me
        '
        'errAddress
        '
        Me.errAddress.ContainerControl = Me
        '
        'errCity
        '
        Me.errCity.ContainerControl = Me
        '
        'errState
        '
        Me.errState.ContainerControl = Me
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(121, 89)
        Me.txtPhoneNumber.Mask = "(999) 000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(132, 22)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.Location = New System.Drawing.Point(16, 86)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(97, 25)
        Me.lblPhoneNumber.TabIndex = 0
        Me.lblPhoneNumber.Text = "Tel. Number: "
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(120, 213)
        Me.txtZip.Mask = "00000"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(132, 22)
        Me.txtZip.TabIndex = 7
        '
        'lblSpecialInstructions
        '
        Me.lblSpecialInstructions.Location = New System.Drawing.Point(16, 240)
        Me.lblSpecialInstructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpecialInstructions.Name = "lblSpecialInstructions"
        Me.lblSpecialInstructions.Size = New System.Drawing.Size(137, 16)
        Me.lblSpecialInstructions.TabIndex = 0
        Me.lblSpecialInstructions.Text = "Special Instructions: "
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(16, 177)
        Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(97, 25)
        Me.lblState.TabIndex = 0
        Me.lblState.Text = "State: "
        '
        'lblZip
        '
        Me.lblZip.Location = New System.Drawing.Point(16, 207)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(97, 25)
        Me.lblZip.TabIndex = 0
        Me.lblZip.Text = "Zip: "
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(16, 147)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(97, 25)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "City:"
        '
        'errZip
        '
        Me.errZip.ContainerControl = Me
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(121, 182)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(132, 22)
        Me.txtState.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(120, 120)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.MaxLength = 40
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(132, 22)
        Me.txtAddress.TabIndex = 4
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(121, 58)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLast.MaxLength = 32
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(132, 22)
        Me.txtLast.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(16, 117)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(97, 25)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address: "
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(16, 57)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(97, 25)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name: "
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(121, 27)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirst.MaxLength = 32
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(132, 22)
        Me.txtFirst.TabIndex = 1
        '
        'errLastName
        '
        Me.errLastName.ContainerControl = Me
        '
        'errBookTitle
        '
        Me.errBookTitle.ContainerControl = Me
        '
        'errStoreNum
        '
        Me.errStoreNum.ContainerControl = Me
        '
        'errQuantity
        '
        Me.errQuantity.ContainerControl = Me
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(121, 151)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.MaxLength = 16
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(132, 22)
        Me.txtCity.TabIndex = 5
        '
        'rtbSpecialInstructions
        '
        Me.rtbSpecialInstructions.Location = New System.Drawing.Point(19, 260)
        Me.rtbSpecialInstructions.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbSpecialInstructions.MaxLength = 128
        Me.rtbSpecialInstructions.Name = "rtbSpecialInstructions"
        Me.rtbSpecialInstructions.Size = New System.Drawing.Size(400, 153)
        Me.rtbSpecialInstructions.TabIndex = 8
        Me.rtbSpecialInstructions.Text = ""
        '
        'btnHome
        '
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(70, 24)
        Me.btnHome.Text = "Home"
        '
        'stpOrdersMain
        '
        Me.stpOrdersMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHome, Me.btnClear, Me.btnSearch, Me.btnInvoices})
        Me.stpOrdersMain.Location = New System.Drawing.Point(0, 0)
        Me.stpOrdersMain.Name = "stpOrdersMain"
        Me.stpOrdersMain.Size = New System.Drawing.Size(844, 27)
        Me.stpOrdersMain.TabIndex = 47
        Me.stpOrdersMain.Text = "ToolStrip1"
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 24)
        Me.btnClear.Text = "Clear Form"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(73, 24)
        Me.btnSearch.Text = "Search"
        '
        'btnInvoices
        '
        Me.btnInvoices.Image = CType(resources.GetObject("btnInvoices.Image"), System.Drawing.Image)
        Me.btnInvoices.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvoices.Name = "btnInvoices"
        Me.btnInvoices.Size = New System.Drawing.Size(82, 24)
        Me.btnInvoices.Text = "Invoices"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(755, 373)
        Me.txtQuantity.Mask = "0000"
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(64, 22)
        Me.txtQuantity.TabIndex = 11
        '
        'lblStoreNumber
        '
        Me.lblStoreNumber.Location = New System.Drawing.Point(518, 341)
        Me.lblStoreNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoreNumber.Name = "lblStoreNumber"
        Me.lblStoreNumber.Size = New System.Drawing.Size(154, 25)
        Me.lblStoreNumber.TabIndex = 0
        Me.lblStoreNumber.Text = "Store Number:"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(16, 27)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(97, 25)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'grpCustInfo
        '
        Me.grpCustInfo.Controls.Add(Me.txtPhoneNumber)
        Me.grpCustInfo.Controls.Add(Me.lblPhoneNumber)
        Me.grpCustInfo.Controls.Add(Me.txtZip)
        Me.grpCustInfo.Controls.Add(Me.lblSpecialInstructions)
        Me.grpCustInfo.Controls.Add(Me.lblState)
        Me.grpCustInfo.Controls.Add(Me.lblZip)
        Me.grpCustInfo.Controls.Add(Me.lblCity)
        Me.grpCustInfo.Controls.Add(Me.txtState)
        Me.grpCustInfo.Controls.Add(Me.txtCity)
        Me.grpCustInfo.Controls.Add(Me.txtAddress)
        Me.grpCustInfo.Controls.Add(Me.txtLast)
        Me.grpCustInfo.Controls.Add(Me.lblAddress)
        Me.grpCustInfo.Controls.Add(Me.lblLastName)
        Me.grpCustInfo.Controls.Add(Me.txtFirst)
        Me.grpCustInfo.Controls.Add(Me.rtbSpecialInstructions)
        Me.grpCustInfo.Controls.Add(Me.lblFirstName)
        Me.grpCustInfo.Location = New System.Drawing.Point(25, 31)
        Me.grpCustInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpCustInfo.Name = "grpCustInfo"
        Me.grpCustInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpCustInfo.Size = New System.Drawing.Size(453, 421)
        Me.grpCustInfo.TabIndex = 0
        Me.grpCustInfo.TabStop = False
        Me.grpCustInfo.Text = "Customer Information"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Location = New System.Drawing.Point(518, 31)
        Me.lblBookTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(80, 16)
        Me.lblBookTitle.TabIndex = 0
        Me.lblBookTitle.Text = "Book Titile:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(518, 371)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(154, 25)
        Me.lblQuantity.TabIndex = 0
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(521, 406)
        Me.btnPlaceOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(299, 46)
        Me.btnPlaceOrder.TabIndex = 12
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lstTitles
        '
        Me.lstTitles.DataSource = Me.TitlesBindingSource
        Me.lstTitles.DisplayMember = "title"
        Me.lstTitles.FormattingEnabled = True
        Me.lstTitles.ItemHeight = 16
        Me.lstTitles.Location = New System.Drawing.Point(521, 58)
        Me.lstTitles.Name = "lstTitles"
        Me.lstTitles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTitles.Size = New System.Drawing.Size(298, 276)
        Me.lstTitles.TabIndex = 9
        Me.lstTitles.ValueMember = "title_id"
        '
        'TitlesBindingSource
        '
        Me.TitlesBindingSource.DataMember = "titles"
        Me.TitlesBindingSource.DataSource = Me.BookCollectionDataSet1
        '
        'BookCollectionDataSet1
        '
        Me.BookCollectionDataSet1.DataSetName = "BookCollectionDataSet"
        Me.BookCollectionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboStore
        '
        Me.cboStore.DataSource = Me.StoresBindingSource
        Me.cboStore.DisplayMember = "stor_id"
        Me.cboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStore.FormattingEnabled = True
        Me.cboStore.Location = New System.Drawing.Point(755, 341)
        Me.cboStore.Name = "cboStore"
        Me.cboStore.Size = New System.Drawing.Size(65, 24)
        Me.cboStore.TabIndex = 10
        Me.cboStore.ValueMember = "stor_id"
        '
        'StoresBindingSource
        '
        Me.StoresBindingSource.DataMember = "stores"
        Me.StoresBindingSource.DataSource = Me.BookCollectionDataSet1
        '
        'TitlesTableAdapter1
        '
        Me.TitlesTableAdapter1.ClearBeforeFill = True
        '
        'StoresTableAdapter1
        '
        Me.StoresTableAdapter1.ClearBeforeFill = True
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 469)
        Me.Controls.Add(Me.cboStore)
        Me.Controls.Add(Me.stpOrdersMain)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblStoreNumber)
        Me.Controls.Add(Me.grpCustInfo)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.lstTitles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Place Order"
        CType(Me.errFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errTelNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errBookTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errStoreNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stpOrdersMain.ResumeLayout(False)
        Me.stpOrdersMain.PerformLayout()
        Me.grpCustInfo.ResumeLayout(False)
        Me.grpCustInfo.PerformLayout()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookCollectionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents errFirstName As System.Windows.Forms.ErrorProvider
    Friend WithEvents stpOrdersMain As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnInvoices As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtQuantity As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblStoreNumber As System.Windows.Forms.Label
    Friend WithEvents grpCustInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblSpecialInstructions As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents rtbSpecialInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblBookTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents lstTitles As System.Windows.Forms.ListBox
    Friend WithEvents errTelNumber As System.Windows.Forms.ErrorProvider
    Friend WithEvents errAddress As System.Windows.Forms.ErrorProvider
    Friend WithEvents errCity As System.Windows.Forms.ErrorProvider
    Friend WithEvents errState As System.Windows.Forms.ErrorProvider
    Friend WithEvents errZip As System.Windows.Forms.ErrorProvider
    Friend WithEvents errLastName As System.Windows.Forms.ErrorProvider
    Friend WithEvents errBookTitle As System.Windows.Forms.ErrorProvider
    Friend WithEvents errStoreNum As System.Windows.Forms.ErrorProvider
    Friend WithEvents errQuantity As System.Windows.Forms.ErrorProvider
    Friend WithEvents BookCollectionDataSet As BookProject.BookCollectionDataSet
    Friend WithEvents TitlesTableAdapter As BookProject.BookCollectionDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents cboStore As System.Windows.Forms.ComboBox
    Friend WithEvents StoresTableAdapter As BookProject.BookCollectionDataSetTableAdapters.storesTableAdapter
    Friend WithEvents BookCollectionDataSet1 As BookProject.BookCollectionDataSet
    Friend WithEvents TitlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitlesTableAdapter1 As BookProject.BookCollectionDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents StoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoresTableAdapter1 As BookProject.BookCollectionDataSetTableAdapters.storesTableAdapter
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
End Class
