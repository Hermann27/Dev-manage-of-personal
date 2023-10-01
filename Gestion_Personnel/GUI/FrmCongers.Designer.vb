<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCongers
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PaneB = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.txt_debut = New System.Windows.Forms.TextBox
        Me.txt_fin = New System.Windows.Forms.TextBox
        Me.date_cloture = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.rd_non2 = New System.Windows.Forms.RadioButton
        Me.rd_oui2 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_prix2 = New System.Windows.Forms.TextBox
        Me.txt_duree = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.lst_matricule = New System.Windows.Forms.ComboBox
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneB.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.CheckBox3)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.PaneB)
        Me.Panel2.Location = New System.Drawing.Point(2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 369)
        Me.Panel2.TabIndex = 92
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(105, 53)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(673, 4)
        Me.Panel5.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 67)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(911, 46)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 90
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(101, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 24)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Congers"
        '
        'PaneB
        '
        Me.PaneB.BackColor = System.Drawing.Color.Gray
        Me.PaneB.Controls.Add(Me.Button2)
        Me.PaneB.Controls.Add(Me.txt_debut)
        Me.PaneB.Controls.Add(Me.txt_fin)
        Me.PaneB.Controls.Add(Me.date_cloture)
        Me.PaneB.Controls.Add(Me.Label16)
        Me.PaneB.Controls.Add(Me.rd_non2)
        Me.PaneB.Controls.Add(Me.rd_oui2)
        Me.PaneB.Controls.Add(Me.Button1)
        Me.PaneB.Controls.Add(Me.Panel3)
        Me.PaneB.Controls.Add(Me.txt_duree)
        Me.PaneB.Controls.Add(Me.Label8)
        Me.PaneB.Controls.Add(Me.Label9)
        Me.PaneB.Controls.Add(Me.Label11)
        Me.PaneB.Controls.Add(Me.Label13)
        Me.PaneB.Controls.Add(Me.Label14)
        Me.PaneB.Controls.Add(Me.Button3)
        Me.PaneB.Controls.Add(Me.lst_matricule)
        Me.PaneB.Location = New System.Drawing.Point(103, 66)
        Me.PaneB.Name = "PaneB"
        Me.PaneB.Size = New System.Drawing.Size(677, 276)
        Me.PaneB.TabIndex = 88
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(328, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(144, 32)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Vider"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_debut
        '
        Me.txt_debut.Enabled = False
        Me.txt_debut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_debut.Location = New System.Drawing.Point(186, 56)
        Me.txt_debut.Name = "txt_debut"
        Me.txt_debut.Size = New System.Drawing.Size(231, 26)
        Me.txt_debut.TabIndex = 75
        '
        'txt_fin
        '
        Me.txt_fin.Enabled = False
        Me.txt_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fin.Location = New System.Drawing.Point(185, 96)
        Me.txt_fin.Name = "txt_fin"
        Me.txt_fin.Size = New System.Drawing.Size(231, 26)
        Me.txt_fin.TabIndex = 74
        '
        'date_cloture
        '
        Me.date_cloture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_cloture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_cloture.Location = New System.Drawing.Point(425, 183)
        Me.date_cloture.Name = "date_cloture"
        Me.date_cloture.Size = New System.Drawing.Size(231, 26)
        Me.date_cloture.TabIndex = 73
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(350, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 20)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Date fin"
        '
        'rd_non2
        '
        Me.rd_non2.AutoSize = True
        Me.rd_non2.Checked = True
        Me.rd_non2.Enabled = False
        Me.rd_non2.Location = New System.Drawing.Point(272, 191)
        Me.rd_non2.Name = "rd_non2"
        Me.rd_non2.Size = New System.Drawing.Size(45, 17)
        Me.rd_non2.TabIndex = 71
        Me.rd_non2.TabStop = True
        Me.rd_non2.Text = "Non"
        Me.rd_non2.UseVisualStyleBackColor = True
        '
        'rd_oui2
        '
        Me.rd_oui2.AutoSize = True
        Me.rd_oui2.Enabled = False
        Me.rd_oui2.Location = New System.Drawing.Point(186, 188)
        Me.rd_oui2.Name = "rd_oui2"
        Me.rd_oui2.Size = New System.Drawing.Size(41, 17)
        Me.rd_oui2.TabIndex = 70
        Me.rd_oui2.Text = "Oui"
        Me.rd_oui2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(492, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(144, 32)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_prix2)
        Me.Panel3.Location = New System.Drawing.Point(12, 226)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 41)
        Me.Panel3.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Montant"
        '
        'txt_prix2
        '
        Me.txt_prix2.AcceptsReturn = True
        Me.txt_prix2.Enabled = False
        Me.txt_prix2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prix2.Location = New System.Drawing.Point(116, 9)
        Me.txt_prix2.Name = "txt_prix2"
        Me.txt_prix2.Size = New System.Drawing.Size(120, 26)
        Me.txt_prix2.TabIndex = 62
        Me.txt_prix2.Text = "0"
        '
        'txt_duree
        '
        Me.txt_duree.Enabled = False
        Me.txt_duree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duree.Location = New System.Drawing.Point(185, 141)
        Me.txt_duree.Name = "txt_duree"
        Me.txt_duree.Size = New System.Drawing.Size(231, 26)
        Me.txt_duree.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Conger payé"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Durée"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 20)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Matricule employer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 20)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Date début"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 20)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Date fin"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(812, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(158, 32)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Supprimer"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lst_matricule
        '
        Me.lst_matricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst_matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_matricule.FormattingEnabled = True
        Me.lst_matricule.Location = New System.Drawing.Point(186, 17)
        Me.lst_matricule.Name = "lst_matricule"
        Me.lst_matricule.Size = New System.Drawing.Size(229, 28)
        Me.lst_matricule.TabIndex = 55
        '
        'FrmCongers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 373)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmCongers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCongers"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneB.ResumeLayout(False)
        Me.PaneB.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PaneB As System.Windows.Forms.Panel
    Friend WithEvents txt_debut As System.Windows.Forms.TextBox
    Friend WithEvents txt_fin As System.Windows.Forms.TextBox
    Friend WithEvents date_cloture As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rd_non2 As System.Windows.Forms.RadioButton
    Friend WithEvents rd_oui2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_prix2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_duree As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lst_matricule As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
