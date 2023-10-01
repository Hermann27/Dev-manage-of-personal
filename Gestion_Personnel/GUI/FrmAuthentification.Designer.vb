<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuthentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAuthentification))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblinfos = New System.Windows.Forms.Label
        Me.lblerror = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_connexion = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_user = New System.Windows.Forms.TextBox
        Me.txt_passe = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblinfos)
        Me.Panel2.Controls.Add(Me.lblerror)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_connexion)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_user)
        Me.Panel2.Controls.Add(Me.txt_passe)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 185)
        Me.Panel2.TabIndex = 7
        '
        'lblinfos
        '
        Me.lblinfos.AutoSize = True
        Me.lblinfos.BackColor = System.Drawing.Color.Transparent
        Me.lblinfos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfos.ForeColor = System.Drawing.Color.Red
        Me.lblinfos.Location = New System.Drawing.Point(9, 105)
        Me.lblinfos.Name = "lblinfos"
        Me.lblinfos.Size = New System.Drawing.Size(0, 16)
        Me.lblinfos.TabIndex = 7
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(90, 8)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 20)
        Me.lblerror.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(47, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login :"
        '
        'btn_connexion
        '
        Me.btn_connexion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_connexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_connexion.BackgroundImage = CType(resources.GetObject("btn_connexion.BackgroundImage"), System.Drawing.Image)
        Me.btn_connexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_connexion.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connexion.ForeColor = System.Drawing.Color.Red
        Me.btn_connexion.Location = New System.Drawing.Point(159, 105)
        Me.btn_connexion.Name = "btn_connexion"
        Me.btn_connexion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_connexion.Size = New System.Drawing.Size(160, 50)
        Me.btn_connexion.TabIndex = 3
        Me.btn_connexion.Text = "Connexion"
        Me.btn_connexion.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(47, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mot de passe:"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(159, 29)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(205, 26)
        Me.txt_user.TabIndex = 1
        '
        'txt_passe
        '
        Me.txt_passe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passe.Location = New System.Drawing.Point(159, 73)
        Me.txt_passe.Name = "txt_passe"
        Me.txt_passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_passe.Size = New System.Drawing.Size(205, 26)
        Me.txt_passe.TabIndex = 2
        '
        'FrmAuthentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 187)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmAuthentification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_connexion As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_passe As System.Windows.Forms.TextBox
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents lblinfos As System.Windows.Forms.Label
End Class
