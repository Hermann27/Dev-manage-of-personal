<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtilisateur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtilisateur))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCompte = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIdUser = New System.Windows.Forms.TextBox
        Me.CbEntreprise = New System.Windows.Forms.ComboBox
        Me.txt_creer_privilege = New System.Windows.Forms.TextBox
        Me.txt_creer_passe2 = New System.Windows.Forms.TextBox
        Me.txt_creer_login = New System.Windows.Forms.TextBox
        Me.txt_creer_passe1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lb_creer_nom = New System.Windows.Forms.Label
        Me.lb_creer_passe2 = New System.Windows.Forms.Label
        Me.lb_creer_passe1 = New System.Windows.Forms.Label
        Me.lb_creer_compte = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_creer = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtCompte)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtIdUser)
        Me.Panel1.Controls.Add(Me.CbEntreprise)
        Me.Panel1.Controls.Add(Me.txt_creer_privilege)
        Me.Panel1.Controls.Add(Me.txt_creer_passe2)
        Me.Panel1.Controls.Add(Me.txt_creer_login)
        Me.Panel1.Controls.Add(Me.txt_creer_passe1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lb_creer_nom)
        Me.Panel1.Controls.Add(Me.lb_creer_passe2)
        Me.Panel1.Controls.Add(Me.lb_creer_passe1)
        Me.Panel1.Controls.Add(Me.lb_creer_compte)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_creer)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 366)
        Me.Panel1.TabIndex = 9
        '
        'txtCompte
        '
        Me.txtCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompte.Location = New System.Drawing.Point(134, 92)
        Me.txtCompte.Name = "txtCompte"
        Me.txtCompte.Size = New System.Drawing.Size(205, 26)
        Me.txtCompte.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(17, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Etat_Compte"
        '
        'txtIdUser
        '
        Me.txtIdUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUser.Location = New System.Drawing.Point(134, 17)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(205, 26)
        Me.txtIdUser.TabIndex = 23
        '
        'CbEntreprise
        '
        Me.CbEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEntreprise.FormattingEnabled = True
        Me.CbEntreprise.Location = New System.Drawing.Point(135, 59)
        Me.CbEntreprise.Name = "CbEntreprise"
        Me.CbEntreprise.Size = New System.Drawing.Size(205, 21)
        Me.CbEntreprise.TabIndex = 22
        '
        'txt_creer_privilege
        '
        Me.txt_creer_privilege.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_creer_privilege.Location = New System.Drawing.Point(134, 251)
        Me.txt_creer_privilege.Name = "txt_creer_privilege"
        Me.txt_creer_privilege.Size = New System.Drawing.Size(205, 26)
        Me.txt_creer_privilege.TabIndex = 8
        '
        'txt_creer_passe2
        '
        Me.txt_creer_passe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_creer_passe2.Location = New System.Drawing.Point(134, 210)
        Me.txt_creer_passe2.Name = "txt_creer_passe2"
        Me.txt_creer_passe2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_creer_passe2.Size = New System.Drawing.Size(205, 26)
        Me.txt_creer_passe2.TabIndex = 7
        '
        'txt_creer_login
        '
        Me.txt_creer_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_creer_login.Location = New System.Drawing.Point(134, 126)
        Me.txt_creer_login.Name = "txt_creer_login"
        Me.txt_creer_login.Size = New System.Drawing.Size(205, 26)
        Me.txt_creer_login.TabIndex = 5
        '
        'txt_creer_passe1
        '
        Me.txt_creer_passe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_creer_passe1.Location = New System.Drawing.Point(134, 167)
        Me.txt_creer_passe1.Name = "txt_creer_passe1"
        Me.txt_creer_passe1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_creer_passe1.Size = New System.Drawing.Size(205, 26)
        Me.txt_creer_passe1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(17, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "NumCompte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Entreprise"
        '
        'lb_creer_nom
        '
        Me.lb_creer_nom.AutoSize = True
        Me.lb_creer_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_creer_nom.ForeColor = System.Drawing.Color.Red
        Me.lb_creer_nom.Location = New System.Drawing.Point(348, 261)
        Me.lb_creer_nom.Name = "lb_creer_nom"
        Me.lb_creer_nom.Size = New System.Drawing.Size(15, 20)
        Me.lb_creer_nom.TabIndex = 18
        Me.lb_creer_nom.Text = "*"
        '
        'lb_creer_passe2
        '
        Me.lb_creer_passe2.AutoSize = True
        Me.lb_creer_passe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_creer_passe2.ForeColor = System.Drawing.Color.Red
        Me.lb_creer_passe2.Location = New System.Drawing.Point(348, 218)
        Me.lb_creer_passe2.Name = "lb_creer_passe2"
        Me.lb_creer_passe2.Size = New System.Drawing.Size(15, 20)
        Me.lb_creer_passe2.TabIndex = 17
        Me.lb_creer_passe2.Text = "*"
        '
        'lb_creer_passe1
        '
        Me.lb_creer_passe1.AutoSize = True
        Me.lb_creer_passe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_creer_passe1.ForeColor = System.Drawing.Color.Red
        Me.lb_creer_passe1.Location = New System.Drawing.Point(348, 170)
        Me.lb_creer_passe1.Name = "lb_creer_passe1"
        Me.lb_creer_passe1.Size = New System.Drawing.Size(15, 20)
        Me.lb_creer_passe1.TabIndex = 16
        Me.lb_creer_passe1.Text = "*"
        '
        'lb_creer_compte
        '
        Me.lb_creer_compte.AutoSize = True
        Me.lb_creer_compte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_creer_compte.ForeColor = System.Drawing.Color.Red
        Me.lb_creer_compte.Location = New System.Drawing.Point(348, 131)
        Me.lb_creer_compte.Name = "lb_creer_compte"
        Me.lb_creer_compte.Size = New System.Drawing.Size(15, 20)
        Me.lb_creer_compte.TabIndex = 15
        Me.lb_creer_compte.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(17, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Privilege "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(19, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Confirmer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(17, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mot de passe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(17, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Login"
        '
        'btn_creer
        '
        Me.btn_creer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_creer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_creer.BackgroundImage = CType(resources.GetObject("btn_creer.BackgroundImage"), System.Drawing.Image)
        Me.btn_creer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_creer.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_creer.ForeColor = System.Drawing.Color.Red
        Me.btn_creer.Location = New System.Drawing.Point(134, 294)
        Me.btn_creer.Name = "btn_creer"
        Me.btn_creer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_creer.Size = New System.Drawing.Size(205, 50)
        Me.btn_creer.TabIndex = 9
        Me.btn_creer.Text = "Créer"
        Me.btn_creer.UseVisualStyleBackColor = False
        '
        'FormUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 390)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUtilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtilisateur"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lb_creer_nom As System.Windows.Forms.Label
    Friend WithEvents lb_creer_passe2 As System.Windows.Forms.Label
    Friend WithEvents lb_creer_passe1 As System.Windows.Forms.Label
    Friend WithEvents lb_creer_compte As System.Windows.Forms.Label
    Friend WithEvents txt_creer_privilege As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_creer_passe2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_creer_login As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_creer As System.Windows.Forms.Button
    Friend WithEvents txt_creer_passe1 As System.Windows.Forms.TextBox
    Friend WithEvents CbEntreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompte As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
