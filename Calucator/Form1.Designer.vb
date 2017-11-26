<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConverter
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
        Me.btnCalucate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDollar = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.txtYen = New System.Windows.Forms.Label()
        Me.txtDollar = New System.Windows.Forms.TextBox()
        Me.txtPound = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.txtEuro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalucate
        '
        Me.btnCalucate.Location = New System.Drawing.Point(43, 240)
        Me.btnCalucate.Name = "btnCalucate"
        Me.btnCalucate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalucate.TabIndex = 0
        Me.btnCalucate.Text = "Calucate"
        Me.btnCalucate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 240)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(239, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDollar
        '
        Me.lblDollar.AutoSize = True
        Me.lblDollar.Location = New System.Drawing.Point(62, 55)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.Size = New System.Drawing.Size(34, 13)
        Me.lblDollar.TabIndex = 3
        Me.lblDollar.Text = "Dollar"
        '
        'lblPound
        '
        Me.lblPound.AutoSize = True
        Me.lblPound.Location = New System.Drawing.Point(62, 112)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(38, 13)
        Me.lblPound.TabIndex = 4
        Me.lblPound.Text = "Pound"
        '
        'txtYen
        '
        Me.txtYen.AutoSize = True
        Me.txtYen.Location = New System.Drawing.Point(62, 152)
        Me.txtYen.Name = "txtYen"
        Me.txtYen.Size = New System.Drawing.Size(26, 13)
        Me.txtYen.TabIndex = 5
        Me.txtYen.Text = "Yen"
        '
        'txtDollar
        '
        Me.txtDollar.Location = New System.Drawing.Point(137, 52)
        Me.txtDollar.Name = "txtDollar"
        Me.txtDollar.Size = New System.Drawing.Size(100, 20)
        Me.txtDollar.TabIndex = 6
        Me.txtDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPound
        '
        Me.txtPound.Location = New System.Drawing.Point(137, 105)
        Me.txtPound.Name = "txtPound"
        Me.txtPound.Size = New System.Drawing.Size(100, 20)
        Me.txtPound.TabIndex = 7
        Me.txtPound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(137, 149)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Location = New System.Drawing.Point(57, 192)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(29, 13)
        Me.lblEuro.TabIndex = 9
        Me.lblEuro.Text = "Euro"
        '
        'txtEuro
        '
        Me.txtEuro.Location = New System.Drawing.Point(151, 185)
        Me.txtEuro.Name = "txtEuro"
        Me.txtEuro.Size = New System.Drawing.Size(100, 20)
        Me.txtEuro.TabIndex = 10
        Me.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 319)
        Me.Controls.Add(Me.txtEuro)
        Me.Controls.Add(Me.lblEuro)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtPound)
        Me.Controls.Add(Me.txtDollar)
        Me.Controls.Add(Me.txtYen)
        Me.Controls.Add(Me.lblPound)
        Me.Controls.Add(Me.lblDollar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalucate)
        Me.Name = "frmConverter"
        Me.Text = "Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalucate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDollar As System.Windows.Forms.Label
    Friend WithEvents lblPound As System.Windows.Forms.Label
    Friend WithEvents txtYen As System.Windows.Forms.Label
    Friend WithEvents txtDollar As System.Windows.Forms.TextBox
    Friend WithEvents txtPound As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblEuro As System.Windows.Forms.Label
    Friend WithEvents txtEuro As System.Windows.Forms.TextBox

End Class
