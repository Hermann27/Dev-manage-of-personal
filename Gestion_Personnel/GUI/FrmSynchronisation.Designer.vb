<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSynchronisation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSynchronisation))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblE = New System.Windows.Forms.Label
        Me.lst_employers = New System.Windows.Forms.ComboBox
        Me.ImgProFil = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.selection_groupe = New System.Windows.Forms.TabControl
        Me.EtatCivil = New System.Windows.Forms.TabPage
        Me.btnCapture = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lstpermis = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DateEntre = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_matricule = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Depart = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Entreprises = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CbNational = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_commentaire = New System.Windows.Forms.TextBox
        Me.txtDEF = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDiplome = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSalaire = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtposte = New System.Windows.Forms.TextBox
        Me.txt_Prenom = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.lb_matricule = New System.Windows.Forms.Label
        Me.nom_texte = New System.Windows.Forms.Label
        Me.txt_nom = New System.Windows.Forms.TextBox
        Me.date_texte = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_adresse = New System.Windows.Forms.TextBox
        Me.email_texte = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.telephonefixe_texte = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.boitepostale_texte = New System.Windows.Forms.Label
        Me.txt_bp = New System.Windows.Forms.TextBox
        Me.date_naissance = New System.Windows.Forms.DateTimePicker
        Me.lst_sitFamiliale = New System.Windows.Forms.ComboBox
        Me.lst_ville = New System.Windows.Forms.ComboBox
        Me.lst_sexe = New System.Windows.Forms.ComboBox
        Me.enfants_texte = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.portrait_groupe = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_url_portrait = New System.Windows.Forms.TextBox
        Me.btn_img_portrait = New System.Windows.Forms.Button
        Me.img_portrait = New System.Windows.Forms.PictureBox
        Me.lblFsynchro = New System.Windows.Forms.Label
        Me.btn_vider = New System.Windows.Forms.Button
        Me.btn_valider = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        CType(Me.ImgProFil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.selection_groupe.SuspendLayout()
        Me.EtatCivil.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.portrait_groupe.SuspendLayout()
        CType(Me.img_portrait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblE)
        Me.Panel1.Controls.Add(Me.lst_employers)
        Me.Panel1.Controls.Add(Me.ImgProFil)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.selection_groupe)
        Me.Panel1.Controls.Add(Me.lblFsynchro)
        Me.Panel1.Controls.Add(Me.btn_vider)
        Me.Panel1.Controls.Add(Me.btn_valider)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 673)
        Me.Panel1.TabIndex = 2
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.Color.DimGray
        Me.lblE.Location = New System.Drawing.Point(717, 19)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(143, 24)
        Me.lblE.TabIndex = 18
        Me.lblE.Text = "Liste Employers"
        '
        'lst_employers
        '
        Me.lst_employers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst_employers.FormattingEnabled = True
        Me.lst_employers.Location = New System.Drawing.Point(886, 19)
        Me.lst_employers.Name = "lst_employers"
        Me.lst_employers.Size = New System.Drawing.Size(180, 21)
        Me.lst_employers.TabIndex = 17
        '
        'ImgProFil
        '
        Me.ImgProFil.BackgroundImage = CType(resources.GetObject("ImgProFil.BackgroundImage"), System.Drawing.Image)
        Me.ImgProFil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImgProFil.Location = New System.Drawing.Point(10, 3)
        Me.ImgProFil.Name = "ImgProFil"
        Me.ImgProFil.Size = New System.Drawing.Size(90, 60)
        Me.ImgProFil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgProFil.TabIndex = 10
        Me.ImgProFil.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(105, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 4)
        Me.Panel2.TabIndex = 9
        '
        'selection_groupe
        '
        Me.selection_groupe.AllowDrop = True
        Me.selection_groupe.Controls.Add(Me.EtatCivil)
        Me.selection_groupe.Location = New System.Drawing.Point(10, 66)
        Me.selection_groupe.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.selection_groupe.Name = "selection_groupe"
        Me.selection_groupe.SelectedIndex = 0
        Me.selection_groupe.Size = New System.Drawing.Size(1062, 537)
        Me.selection_groupe.TabIndex = 5
        '
        'EtatCivil
        '
        Me.EtatCivil.BackColor = System.Drawing.Color.PaleTurquoise
        Me.EtatCivil.Controls.Add(Me.btnCapture)
        Me.EtatCivil.Controls.Add(Me.GroupBox5)
        Me.EtatCivil.Controls.Add(Me.portrait_groupe)
        Me.EtatCivil.Location = New System.Drawing.Point(4, 22)
        Me.EtatCivil.Margin = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.EtatCivil.Name = "EtatCivil"
        Me.EtatCivil.Padding = New System.Windows.Forms.Padding(3)
        Me.EtatCivil.Size = New System.Drawing.Size(1054, 511)
        Me.EtatCivil.TabIndex = 0
        Me.EtatCivil.Text = "Employes"
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.Gray
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(921, 272)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(130, 41)
        Me.btnCapture.TabIndex = 36
        Me.btnCapture.Text = "CaptureImage"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Gray
        Me.GroupBox5.Controls.Add(Me.lstpermis)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.DateEntre)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txt_matricule)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txt_Depart)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txt_Entreprises)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.CbNational)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.txtDEF)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtDiplome)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtSalaire)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtposte)
        Me.GroupBox5.Controls.Add(Me.txt_Prenom)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.lb_matricule)
        Me.GroupBox5.Controls.Add(Me.nom_texte)
        Me.GroupBox5.Controls.Add(Me.txt_nom)
        Me.GroupBox5.Controls.Add(Me.date_texte)
        Me.GroupBox5.Controls.Add(Me.txt_email)
        Me.GroupBox5.Controls.Add(Me.txt_adresse)
        Me.GroupBox5.Controls.Add(Me.email_texte)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.telephonefixe_texte)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.boitepostale_texte)
        Me.GroupBox5.Controls.Add(Me.txt_bp)
        Me.GroupBox5.Controls.Add(Me.date_naissance)
        Me.GroupBox5.Controls.Add(Me.lst_sitFamiliale)
        Me.GroupBox5.Controls.Add(Me.lst_ville)
        Me.GroupBox5.Controls.Add(Me.lst_sexe)
        Me.GroupBox5.Controls.Add(Me.enfants_texte)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(735, 489)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Informations"
        '
        'lstpermis
        '
        Me.lstpermis.DisplayMember = "fffff"
        Me.lstpermis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstpermis.FormattingEnabled = True
        Me.lstpermis.Items.AddRange(New Object() {"A1", "A", "B", "BE", "C", "CE", "DE", "D", "FA1", "FA", "FB", "G"})
        Me.lstpermis.Location = New System.Drawing.Point(180, 371)
        Me.lstpermis.Name = "lstpermis"
        Me.lstpermis.Size = New System.Drawing.Size(136, 28)
        Me.lstpermis.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 20)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Permis_Conduire"
        '
        'DateEntre
        '
        Me.DateEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEntre.Location = New System.Drawing.Point(180, 157)
        Me.DateEntre.Name = "DateEntre"
        Me.DateEntre.Size = New System.Drawing.Size(136, 26)
        Me.DateEntre.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Matricule  :"
        '
        'txt_matricule
        '
        Me.txt_matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_matricule.Location = New System.Drawing.Point(180, 330)
        Me.txt_matricule.Name = "txt_matricule"
        Me.txt_matricule.Size = New System.Drawing.Size(136, 26)
        Me.txt_matricule.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(395, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "IdDepartements  :"
        '
        'txt_Depart
        '
        Me.txt_Depart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Depart.Location = New System.Drawing.Point(561, 290)
        Me.txt_Depart.Name = "txt_Depart"
        Me.txt_Depart.Size = New System.Drawing.Size(132, 26)
        Me.txt_Depart.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "IdEntreprise  :"
        '
        'txt_Entreprises
        '
        Me.txt_Entreprises.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Entreprises.Location = New System.Drawing.Point(561, 251)
        Me.txt_Entreprises.Name = "txt_Entreprises"
        Me.txt_Entreprises.Size = New System.Drawing.Size(133, 26)
        Me.txt_Entreprises.TabIndex = 57
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(395, 215)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Nationalité"
        '
        'CbNational
        '
        Me.CbNational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNational.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNational.FormattingEnabled = True
        Me.CbNational.Items.AddRange(New Object() {"Camerounaise", "Nigeria"})
        Me.CbNational.Location = New System.Drawing.Point(561, 210)
        Me.CbNational.Name = "CbNational"
        Me.CbNational.Size = New System.Drawing.Size(133, 28)
        Me.CbNational.TabIndex = 54
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_commentaire)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(413, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 151)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commentaire"
        '
        'txt_commentaire
        '
        Me.txt_commentaire.Location = New System.Drawing.Point(6, 25)
        Me.txt_commentaire.Multiline = True
        Me.txt_commentaire.Name = "txt_commentaire"
        Me.txt_commentaire.Size = New System.Drawing.Size(266, 120)
        Me.txt_commentaire.TabIndex = 0
        '
        'txtDEF
        '
        Me.txtDEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDEF.Location = New System.Drawing.Point(561, 171)
        Me.txtDEF.Name = "txtDEF"
        Me.txtDEF.Size = New System.Drawing.Size(133, 26)
        Me.txtDEF.TabIndex = 51
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(395, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 20)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "D_Etablissement_F :"
        '
        'txtDiplome
        '
        Me.txtDiplome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiplome.Location = New System.Drawing.Point(561, 132)
        Me.txtDiplome.Name = "txtDiplome"
        Me.txtDiplome.Size = New System.Drawing.Size(132, 26)
        Me.txtDiplome.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(395, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(137, 20)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Diplome_Optenu :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(695, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "FCFA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(395, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Salaire_Mensuel  :"
        '
        'txtSalaire
        '
        Me.txtSalaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaire.Location = New System.Drawing.Point(561, 93)
        Me.txtSalaire.Name = "txtSalaire"
        Me.txtSalaire.Size = New System.Drawing.Size(132, 26)
        Me.txtSalaire.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Poste  :"
        '
        'txtposte
        '
        Me.txtposte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposte.Location = New System.Drawing.Point(561, 54)
        Me.txtposte.Name = "txtposte"
        Me.txtposte.Size = New System.Drawing.Size(132, 26)
        Me.txtposte.TabIndex = 44
        '
        'txt_Prenom
        '
        Me.txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prenom.Location = New System.Drawing.Point(85, 48)
        Me.txt_Prenom.Name = "txt_Prenom"
        Me.txt_Prenom.Size = New System.Drawing.Size(231, 26)
        Me.txt_Prenom.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = " Prenom"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label33.Location = New System.Drawing.Point(317, 302)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(20, 25)
        Me.Label33.TabIndex = 40
        Me.Label33.Text = "*"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label32.Location = New System.Drawing.Point(316, 332)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(20, 25)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label31.Location = New System.Drawing.Point(318, 269)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(20, 25)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "*"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label30.Location = New System.Drawing.Point(316, 233)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(20, 25)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "*"
        '
        'lb_matricule
        '
        Me.lb_matricule.AutoSize = True
        Me.lb_matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_matricule.Location = New System.Drawing.Point(182, 357)
        Me.lb_matricule.Name = "lb_matricule"
        Me.lb_matricule.Size = New System.Drawing.Size(0, 20)
        Me.lb_matricule.TabIndex = 11
        '
        'nom_texte
        '
        Me.nom_texte.AutoSize = True
        Me.nom_texte.BackColor = System.Drawing.Color.Transparent
        Me.nom_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_texte.Location = New System.Drawing.Point(20, 20)
        Me.nom_texte.Name = "nom_texte"
        Me.nom_texte.Size = New System.Drawing.Size(46, 20)
        Me.nom_texte.TabIndex = 1
        Me.nom_texte.Text = "Nom "
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom.Location = New System.Drawing.Point(85, 17)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(231, 26)
        Me.txt_nom.TabIndex = 34
        '
        'date_texte
        '
        Me.date_texte.AutoSize = True
        Me.date_texte.BackColor = System.Drawing.Color.Transparent
        Me.date_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_texte.Location = New System.Drawing.Point(395, 20)
        Me.date_texte.Name = "date_texte"
        Me.date_texte.Size = New System.Drawing.Size(144, 20)
        Me.date_texte.TabIndex = 2
        Me.date_texte.Text = "Date de Naissance"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(180, 297)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(136, 26)
        Me.txt_email.TabIndex = 33
        '
        'txt_adresse
        '
        Me.txt_adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adresse.Location = New System.Drawing.Point(180, 263)
        Me.txt_adresse.Name = "txt_adresse"
        Me.txt_adresse.Size = New System.Drawing.Size(136, 26)
        Me.txt_adresse.TabIndex = 31
        '
        'email_texte
        '
        Me.email_texte.AutoSize = True
        Me.email_texte.BackColor = System.Drawing.Color.Transparent
        Me.email_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_texte.Location = New System.Drawing.Point(20, 302)
        Me.email_texte.Name = "email_texte"
        Me.email_texte.Size = New System.Drawing.Size(70, 20)
        Me.email_texte.TabIndex = 12
        Me.email_texte.Text = "@ email:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 20)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Situation Familiale"
        '
        'telephonefixe_texte
        '
        Me.telephonefixe_texte.AutoSize = True
        Me.telephonefixe_texte.BackColor = System.Drawing.Color.Transparent
        Me.telephonefixe_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephonefixe_texte.Location = New System.Drawing.Point(20, 269)
        Me.telephonefixe_texte.Name = "telephonefixe_texte"
        Me.telephonefixe_texte.Size = New System.Drawing.Size(72, 20)
        Me.telephonefixe_texte.TabIndex = 13
        Me.telephonefixe_texte.Text = "Adresse:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Sexe"
        '
        'boitepostale_texte
        '
        Me.boitepostale_texte.AutoSize = True
        Me.boitepostale_texte.BackColor = System.Drawing.Color.Transparent
        Me.boitepostale_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boitepostale_texte.Location = New System.Drawing.Point(20, 245)
        Me.boitepostale_texte.Name = "boitepostale_texte"
        Me.boitepostale_texte.Size = New System.Drawing.Size(46, 20)
        Me.boitepostale_texte.TabIndex = 15
        Me.boitepostale_texte.Text = "B.P. :"
        '
        'txt_bp
        '
        Me.txt_bp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bp.Location = New System.Drawing.Point(180, 229)
        Me.txt_bp.Name = "txt_bp"
        Me.txt_bp.Size = New System.Drawing.Size(136, 26)
        Me.txt_bp.TabIndex = 28
        '
        'date_naissance
        '
        Me.date_naissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_naissance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_naissance.Location = New System.Drawing.Point(561, 15)
        Me.date_naissance.Name = "date_naissance"
        Me.date_naissance.Size = New System.Drawing.Size(136, 26)
        Me.date_naissance.TabIndex = 17
        '
        'lst_sitFamiliale
        '
        Me.lst_sitFamiliale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst_sitFamiliale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_sitFamiliale.FormattingEnabled = True
        Me.lst_sitFamiliale.Items.AddRange(New Object() {"Celibataire", "Marie", "Fiance", "Divorce"})
        Me.lst_sitFamiliale.Location = New System.Drawing.Point(180, 120)
        Me.lst_sitFamiliale.Name = "lst_sitFamiliale"
        Me.lst_sitFamiliale.Size = New System.Drawing.Size(136, 28)
        Me.lst_sitFamiliale.TabIndex = 27
        '
        'lst_ville
        '
        Me.lst_ville.BackColor = System.Drawing.Color.White
        Me.lst_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst_ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_ville.FormattingEnabled = True
        Me.lst_ville.Items.AddRange(New Object() {"Douala", "Yaounde", "Betoua", "Maroua", "Garoua"})
        Me.lst_ville.Location = New System.Drawing.Point(180, 192)
        Me.lst_ville.Name = "lst_ville"
        Me.lst_ville.Size = New System.Drawing.Size(136, 28)
        Me.lst_ville.TabIndex = 20
        '
        'lst_sexe
        '
        Me.lst_sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst_sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_sexe.FormattingEnabled = True
        Me.lst_sexe.Items.AddRange(New Object() {"Masculin", "Feminin"})
        Me.lst_sexe.Location = New System.Drawing.Point(180, 86)
        Me.lst_sexe.Name = "lst_sexe"
        Me.lst_sexe.Size = New System.Drawing.Size(136, 28)
        Me.lst_sexe.TabIndex = 26
        '
        'enfants_texte
        '
        Me.enfants_texte.AutoSize = True
        Me.enfants_texte.BackColor = System.Drawing.Color.Transparent
        Me.enfants_texte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enfants_texte.Location = New System.Drawing.Point(20, 170)
        Me.enfants_texte.Name = "enfants_texte"
        Me.enfants_texte.Size = New System.Drawing.Size(101, 20)
        Me.enfants_texte.TabIndex = 2
        Me.enfants_texte.Text = "Date_Entree"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Localisation/Ville:"
        '
        'portrait_groupe
        '
        Me.portrait_groupe.BackColor = System.Drawing.Color.Gray
        Me.portrait_groupe.Controls.Add(Me.Label34)
        Me.portrait_groupe.Controls.Add(Me.Label5)
        Me.portrait_groupe.Controls.Add(Me.txt_url_portrait)
        Me.portrait_groupe.Controls.Add(Me.btn_img_portrait)
        Me.portrait_groupe.Controls.Add(Me.img_portrait)
        Me.portrait_groupe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.portrait_groupe.Location = New System.Drawing.Point(740, 21)
        Me.portrait_groupe.Name = "portrait_groupe"
        Me.portrait_groupe.Size = New System.Drawing.Size(310, 245)
        Me.portrait_groupe.TabIndex = 5
        Me.portrait_groupe.TabStop = False
        Me.portrait_groupe.Text = "Portrait"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label34.Location = New System.Drawing.Point(337, 210)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(20, 25)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-186, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Url:"
        '
        'txt_url_portrait
        '
        Me.txt_url_portrait.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_url_portrait.Location = New System.Drawing.Point(20, 205)
        Me.txt_url_portrait.Multiline = True
        Me.txt_url_portrait.Name = "txt_url_portrait"
        Me.txt_url_portrait.Size = New System.Drawing.Size(222, 36)
        Me.txt_url_portrait.TabIndex = 43
        '
        'btn_img_portrait
        '
        Me.btn_img_portrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_img_portrait.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_img_portrait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_img_portrait.Location = New System.Drawing.Point(242, 205)
        Me.btn_img_portrait.Name = "btn_img_portrait"
        Me.btn_img_portrait.Size = New System.Drawing.Size(67, 36)
        Me.btn_img_portrait.TabIndex = 42
        Me.btn_img_portrait.Text = "Photo"
        Me.btn_img_portrait.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_img_portrait.UseVisualStyleBackColor = True
        '
        'img_portrait
        '
        Me.img_portrait.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.img_portrait.BackgroundImage = CType(resources.GetObject("img_portrait.BackgroundImage"), System.Drawing.Image)
        Me.img_portrait.Location = New System.Drawing.Point(59, 61)
        Me.img_portrait.Name = "img_portrait"
        Me.img_portrait.Size = New System.Drawing.Size(142, 130)
        Me.img_portrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_portrait.TabIndex = 10
        Me.img_portrait.TabStop = False
        '
        'lblFsynchro
        '
        Me.lblFsynchro.AutoSize = True
        Me.lblFsynchro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFsynchro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFsynchro.ForeColor = System.Drawing.Color.DimGray
        Me.lblFsynchro.Location = New System.Drawing.Point(103, 28)
        Me.lblFsynchro.Name = "lblFsynchro"
        Me.lblFsynchro.Size = New System.Drawing.Size(184, 24)
        Me.lblFsynchro.TabIndex = 4
        Me.lblFsynchro.Text = "Ajouté Un  Employer"
        '
        'btn_vider
        '
        Me.btn_vider.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_vider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_vider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_vider.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_vider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vider.Location = New System.Drawing.Point(404, 609)
        Me.btn_vider.Name = "btn_vider"
        Me.btn_vider.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_vider.Size = New System.Drawing.Size(124, 32)
        Me.btn_vider.TabIndex = 8
        Me.btn_vider.Text = "Annuler"
        Me.btn_vider.UseVisualStyleBackColor = False
        '
        'btn_valider
        '
        Me.btn_valider.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_valider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_valider.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_valider.Location = New System.Drawing.Point(569, 609)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_valider.Size = New System.Drawing.Size(144, 32)
        Me.btn_valider.TabIndex = 7
        Me.btn_valider.Text = "Enregistrer"
        Me.btn_valider.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmSynchronisation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSynchronisation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSynchronisation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImgProFil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.selection_groupe.ResumeLayout(False)
        Me.EtatCivil.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.portrait_groupe.ResumeLayout(False)
        Me.portrait_groupe.PerformLayout()
        CType(Me.img_portrait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImgProFil As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblFsynchro As System.Windows.Forms.Label
    Friend WithEvents btn_vider As System.Windows.Forms.Button
    Friend WithEvents btn_valider As System.Windows.Forms.Button
    Friend WithEvents selection_groupe As System.Windows.Forms.TabControl
    Friend WithEvents EtatCivil As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CbNational As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_commentaire As System.Windows.Forms.TextBox
    Friend WithEvents txtDEF As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDiplome As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSalaire As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtposte As System.Windows.Forms.TextBox
    Friend WithEvents txt_Prenom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lb_matricule As System.Windows.Forms.Label
    Friend WithEvents nom_texte As System.Windows.Forms.Label
    Friend WithEvents txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents date_texte As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_adresse As System.Windows.Forms.TextBox
    Friend WithEvents email_texte As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents telephonefixe_texte As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents boitepostale_texte As System.Windows.Forms.Label
    Friend WithEvents txt_bp As System.Windows.Forms.TextBox
    Friend WithEvents date_naissance As System.Windows.Forms.DateTimePicker
    Friend WithEvents lst_sitFamiliale As System.Windows.Forms.ComboBox
    Friend WithEvents lst_ville As System.Windows.Forms.ComboBox
    Friend WithEvents lst_sexe As System.Windows.Forms.ComboBox
    Friend WithEvents enfants_texte As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents portrait_groupe As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_url_portrait As System.Windows.Forms.TextBox
    Friend WithEvents btn_img_portrait As System.Windows.Forms.Button
    Friend WithEvents img_portrait As System.Windows.Forms.PictureBox
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Entreprises As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Depart As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_matricule As System.Windows.Forms.TextBox
    Friend WithEvents DateEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents lst_employers As System.Windows.Forms.ComboBox
    Friend WithEvents lstpermis As System.Windows.Forms.ComboBox
End Class
