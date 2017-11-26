<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.mnuHome = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOrder
        '
        Me.btnOrder.Image = CType(resources.GetObject("btnOrder.Image"), System.Drawing.Image)
        Me.btnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrder.Location = New System.Drawing.Point(13, 41)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(180, 110)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "Orders"
        Me.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), System.Drawing.Image)
        Me.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMaintenance.Location = New System.Drawing.Point(293, 43)
        Me.btnMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(180, 110)
        Me.btnMaintenance.TabIndex = 1
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReport.Location = New System.Drawing.Point(573, 44)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(180, 110)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "Reports"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'mnuHome
        '
        Me.mnuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.HelpToolStripMenuItem})
        Me.mnuHome.Location = New System.Drawing.Point(0, 0)
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuHome.Size = New System.Drawing.Size(767, 28)
        Me.mnuHome.TabIndex = 3
        Me.mnuHome.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(102, 24)
        Me.mnuExit.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 167)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnMaintenance)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.mnuHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuHome
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.mnuHome.ResumeLayout(False)
        Me.mnuHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents btnMaintenance As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents mnuHome As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
End Class
