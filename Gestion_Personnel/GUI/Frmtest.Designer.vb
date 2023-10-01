<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmtest
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtconfirme = New System.Windows.Forms.TextBox
        Me.txtnom = New System.Windows.Forms.TextBox
        Me.txtmotpass = New System.Windows.Forms.TextBox
        Me.txtprivile = New System.Windows.Forms.TextBox
        Me.txtentreprise = New System.Windows.Forms.TextBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.ListBox2 = New System.Windows.Forms.ListBox
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(535, 185)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(244, 147)
        Me.ListBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(78, 21)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 3
        '
        'txtconfirme
        '
        Me.txtconfirme.Location = New System.Drawing.Point(78, 122)
        Me.txtconfirme.Name = "txtconfirme"
        Me.txtconfirme.Size = New System.Drawing.Size(100, 20)
        Me.txtconfirme.TabIndex = 4
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(78, 62)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(100, 20)
        Me.txtnom.TabIndex = 5
        '
        'txtmotpass
        '
        Me.txtmotpass.Location = New System.Drawing.Point(78, 88)
        Me.txtmotpass.Name = "txtmotpass"
        Me.txtmotpass.Size = New System.Drawing.Size(100, 20)
        Me.txtmotpass.TabIndex = 6
        '
        'txtprivile
        '
        Me.txtprivile.Location = New System.Drawing.Point(78, 148)
        Me.txtprivile.Name = "txtprivile"
        Me.txtprivile.Size = New System.Drawing.Size(100, 20)
        Me.txtprivile.TabIndex = 7
        '
        'txtentreprise
        '
        Me.txtentreprise.Location = New System.Drawing.Point(220, 21)
        Me.txtentreprise.Name = "txtentreprise"
        Me.txtentreprise.Size = New System.Drawing.Size(100, 20)
        Me.txtentreprise.TabIndex = 8
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(539, 29)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(240, 150)
        Me.DGV.TabIndex = 10
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(240, 185)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(289, 147)
        Me.ListBox2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 346)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtentreprise)
        Me.Controls.Add(Me.txtprivile)
        Me.Controls.Add(Me.txtmotpass)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.txtconfirme)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirme As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents txtmotpass As System.Windows.Forms.TextBox
    Friend WithEvents txtprivile As System.Windows.Forms.TextBox
    Friend WithEvents txtentreprise As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox

End Class
