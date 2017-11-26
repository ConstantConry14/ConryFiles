<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoices))
        Me.stpInvoices = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookCollectionDataSet = New BookProject.BookCollectionDataSet()
        Me.lblRowCount = New System.Windows.Forms.ToolStripLabel()
        Me.btnFirst = New System.Windows.Forms.ToolStripButton()
        Me.btnPrevious = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.txtRowNum = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.btnLast = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInvoiceOrder = New System.Windows.Forms.ToolStripButton()
        Me.grdSales = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesTableAdapter = New BookProject.BookCollectionDataSetTableAdapters.salesTableAdapter()
        Me.TableAdapterManager = New BookProject.BookCollectionDataSetTableAdapters.TableAdapterManager()
        Me.btnViewInvoice = New System.Windows.Forms.ToolStripButton()
        CType(Me.stpInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stpInvoices.SuspendLayout()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stpInvoices
        '
        Me.stpInvoices.AddNewItem = Nothing
        Me.stpInvoices.BindingSource = Me.SalesBindingSource
        Me.stpInvoices.CountItem = Me.lblRowCount
        Me.stpInvoices.DeleteItem = Nothing
        Me.stpInvoices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFirst, Me.btnPrevious, Me.BindingNavigatorSeparator, Me.txtRowNum, Me.lblRowCount, Me.BindingNavigatorSeparator1, Me.btnNext, Me.btnLast, Me.BindingNavigatorSeparator2, Me.btnInvoiceOrder, Me.btnViewInvoice})
        Me.stpInvoices.Location = New System.Drawing.Point(0, 0)
        Me.stpInvoices.MoveFirstItem = Me.btnFirst
        Me.stpInvoices.MoveLastItem = Me.btnLast
        Me.stpInvoices.MoveNextItem = Me.btnNext
        Me.stpInvoices.MovePreviousItem = Me.btnPrevious
        Me.stpInvoices.Name = "stpInvoices"
        Me.stpInvoices.PositionItem = Me.txtRowNum
        Me.stpInvoices.Size = New System.Drawing.Size(1014, 27)
        Me.stpInvoices.TabIndex = 0
        Me.stpInvoices.Text = "BindingNavigator1"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.BookCollectionDataSet
        '
        'BookCollectionDataSet
        '
        Me.BookCollectionDataSet.DataSetName = "BookCollectionDataSet"
        Me.BookCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblRowCount
        '
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(45, 24)
        Me.lblRowCount.Text = "of {0}"
        Me.lblRowCount.ToolTipText = "Total number of items"
        '
        'btnFirst
        '
        Me.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFirst.Image = CType(resources.GetObject("btnFirst.Image"), System.Drawing.Image)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.RightToLeftAutoMirrorImage = True
        Me.btnFirst.Size = New System.Drawing.Size(23, 24)
        Me.btnFirst.Text = "Move first"
        '
        'btnPrevious
        '
        Me.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.RightToLeftAutoMirrorImage = True
        Me.btnPrevious.Size = New System.Drawing.Size(23, 24)
        Me.btnPrevious.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'txtRowNum
        '
        Me.txtRowNum.AccessibleName = "Position"
        Me.txtRowNum.AutoSize = False
        Me.txtRowNum.Name = "txtRowNum"
        Me.txtRowNum.Size = New System.Drawing.Size(50, 27)
        Me.txtRowNum.Text = "0"
        Me.txtRowNum.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnNext
        '
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.RightToLeftAutoMirrorImage = True
        Me.btnNext.Size = New System.Drawing.Size(23, 24)
        Me.btnNext.Text = "Move next"
        '
        'btnLast
        '
        Me.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Image)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.RightToLeftAutoMirrorImage = True
        Me.btnLast.Size = New System.Drawing.Size(23, 24)
        Me.btnLast.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnInvoiceOrder
        '
        Me.btnInvoiceOrder.Image = CType(resources.GetObject("btnInvoiceOrder.Image"), System.Drawing.Image)
        Me.btnInvoiceOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInvoiceOrder.Name = "btnInvoiceOrder"
        Me.btnInvoiceOrder.Size = New System.Drawing.Size(118, 24)
        Me.btnInvoiceOrder.Text = "Invoice Order"
        '
        'grdSales
        '
        Me.grdSales.AllowUserToAddRows = False
        Me.grdSales.AllowUserToDeleteRows = False
        Me.grdSales.AllowUserToOrderColumns = True
        Me.grdSales.AutoGenerateColumns = False
        Me.grdSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.grdSales.DataSource = Me.SalesBindingSource
        Me.grdSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSales.Location = New System.Drawing.Point(0, 27)
        Me.grdSales.MultiSelect = False
        Me.grdSales.Name = "grdSales"
        Me.grdSales.ReadOnly = True
        Me.grdSales.RowTemplate.Height = 24
        Me.grdSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSales.Size = New System.Drawing.Size(1014, 426)
        Me.grdSales.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "stor_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "stor_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ord_num"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ord_num"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cust_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cust_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ord_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ord_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "payterms"
        Me.DataGridViewTextBoxColumn6.HeaderText = "payterms"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "title_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "title_id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_infoTableAdapter = Nothing
        Me.TableAdapterManager.discountsTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.invoicesTableAdapter = Nothing
        Me.TableAdapterManager.jobsTableAdapter = Nothing
        Me.TableAdapterManager.pub_infoTableAdapter = Nothing
        Me.TableAdapterManager.publishersTableAdapter = Nothing
        Me.TableAdapterManager.royschedTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.storesTableAdapter = Nothing
        Me.TableAdapterManager.titleauthorTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookProject.BookCollectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnViewInvoice
        '
        Me.btnViewInvoice.Image = CType(resources.GetObject("btnViewInvoice.Image"), System.Drawing.Image)
        Me.btnViewInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewInvoice.Name = "btnViewInvoice"
        Me.btnViewInvoice.Size = New System.Drawing.Size(112, 24)
        Me.btnViewInvoice.Text = "View Invoice"
        '
        'frmInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 453)
        Me.Controls.Add(Me.grdSales)
        Me.Controls.Add(Me.stpInvoices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInvoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInvoices"
        CType(Me.stpInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stpInvoices.ResumeLayout(False)
        Me.stpInvoices.PerformLayout()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookCollectionDataSet As BookProject.BookCollectionDataSet
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As BookProject.BookCollectionDataSetTableAdapters.salesTableAdapter
    Friend WithEvents TableAdapterManager As BookProject.BookCollectionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents stpInvoices As System.Windows.Forms.BindingNavigator
    Friend WithEvents lblRowCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtRowNum As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdSales As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnInvoiceOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnViewInvoice As System.Windows.Forms.ToolStripButton
End Class
