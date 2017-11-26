<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrencyConvertor
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
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblEuros = New System.Windows.Forms.Label()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.txtPound = New System.Windows.Forms.TextBox()
        Me.txtEuros = New System.Windows.Forms.TextBox()
        Me.txtYen = New System.Windows.Forms.TextBox()
        Me.lblYen = New System.Windows.Forms.Label()
        Me.btnCalucate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(62, 37)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(48, 13)
        Me.lblDollars.TabIndex = 0
        Me.lblDollars.Text = " Dollars :"
        '
        'lblPound
        '
        Me.lblPound.AutoSize = True
        Me.lblPound.Location = New System.Drawing.Point(62, 74)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(44, 13)
        Me.lblPound.TabIndex = 1
        Me.lblPound.Text = "Pound :"
        '
        'lblEuros
        '
        Me.lblEuros.AutoSize = True
        Me.lblEuros.Location = New System.Drawing.Point(62, 123)
        Me.lblEuros.Name = "lblEuros"
        Me.lblEuros.Size = New System.Drawing.Size(43, 13)
        Me.lblEuros.TabIndex = 2
        Me.lblEuros.Text = "Euros : "
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(143, 34)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(100, 20)
        Me.txtDollars.TabIndex = 3
        '
        'txtPound
        '
        Me.txtPound.Location = New System.Drawing.Point(143, 71)
        Me.txtPound.Name = "txtPound"
        Me.txtPound.Size = New System.Drawing.Size(100, 20)
        Me.txtPound.TabIndex = 4
        '
        'txtEuros
        '
        Me.txtEuros.Location = New System.Drawing.Point(143, 120)
        Me.txtEuros.Name = "txtEuros"
        Me.txtEuros.Size = New System.Drawing.Size(100, 20)
        Me.txtEuros.TabIndex = 5
        '
        'txtYen
        '
        Me.txtYen.Location = New System.Drawing.Point(143, 166)
        Me.txtYen.Name = "txtYen"
        Me.txtYen.Size = New System.Drawing.Size(100, 20)
        Me.txtYen.TabIndex = 6
        '
        'lblYen
        '
        Me.lblYen.AutoSize = True
        Me.lblYen.Location = New System.Drawing.Point(62, 169)
        Me.lblYen.Name = "lblYen"
        Me.lblYen.Size = New System.Drawing.Size(35, 13)
        Me.lblYen.TabIndex = 7
        Me.lblYen.Text = "Yen : "
        '
        'btnCalucate
        '
        Me.btnCalucate.Location = New System.Drawing.Point(12, 210)
        Me.btnCalucate.Name = "btnCalucate"
        Me.btnCalucate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalucate.TabIndex = 8
        Me.btnCalucate.Text = "Calucate"
        Me.btnCalucate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(143, 209)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(280, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit "
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCurrencyConvertor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 289)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalucate)
        Me.Controls.Add(Me.lblYen)
        Me.Controls.Add(Me.txtYen)
        Me.Controls.Add(Me.txtEuros)
        Me.Controls.Add(Me.txtPound)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.lblEuros)
        Me.Controls.Add(Me.lblPound)
        Me.Controls.Add(Me.lblDollars)
        Me.Name = "frmCurrencyConvertor"
        Me.Text = "Currency Convertor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDollars As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblEuros As Label
    Friend WithEvents txtDollars As TextBox
    Friend WithEvents txtPound As TextBox
    Friend WithEvents txtEuros As TextBox
    Friend WithEvents txtYen As TextBox
    Friend WithEvents lblYen As Label
    Friend WithEvents btnCalucate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
