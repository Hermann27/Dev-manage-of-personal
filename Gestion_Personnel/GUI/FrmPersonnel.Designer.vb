<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonnel
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPersonnel))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.new_conger = New System.Windows.Forms.ToolStripMenuItem
        Me.new_membre = New System.Windows.Forms.ToolStripMenuItem
        Me.mewEntreprises = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StagairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mwModifier = New System.Windows.Forms.ToolStripMenuItem
        Me.mod_employer = New System.Windows.Forms.ToolStripMenuItem
        Me.mod_poste = New System.Windows.Forms.ToolStripMenuItem
        Me.EntreprisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilisateursToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartementsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StagairesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.mwSupprimer = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.EntreprisesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilisateursToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.DepartementsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblheure = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.lblmessage = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panSupport = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.cboListePolices = New System.Windows.Forms.ComboBox
        Me.chkDefilement = New System.Windows.Forms.CheckBox
        Me.trkvitesse = New System.Windows.Forms.TrackBar
        Me.Vitesse = New System.Windows.Forms.Label
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.CbRecher = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CbSpecifier = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRechercher = New System.Windows.Forms.TextBox
        Me.lst_Recher = New System.Windows.Forms.ComboBox
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProfilImage = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.panSupport.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.trkvitesse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.mwModifier, Me.mwSupprimer, Me.InformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 34)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.new_conger, Me.new_membre, Me.mewEntreprises, Me.UtilisateursToolStripMenuItem, Me.DepartementsToolStripMenuItem, Me.StagairesToolStripMenuItem})
        Me.FichierToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.Color.LightPink
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.ShortcutKeyDisplayString = "Nouveau"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(76, 30)
        Me.FichierToolStripMenuItem.Tag = "Nouveau"
        Me.FichierToolStripMenuItem.Text = "&Nouveau"
        Me.FichierToolStripMenuItem.ToolTipText = "Ajouter"
        '
        'new_conger
        '
        Me.new_conger.BackColor = System.Drawing.Color.Gray
        Me.new_conger.ForeColor = System.Drawing.Color.Black
        Me.new_conger.Name = "new_conger"
        Me.new_conger.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.new_conger.Size = New System.Drawing.Size(209, 22)
        Me.new_conger.Text = "Congers"
        '
        'new_membre
        '
        Me.new_membre.BackColor = System.Drawing.Color.Gray
        Me.new_membre.ForeColor = System.Drawing.Color.Black
        Me.new_membre.Name = "new_membre"
        Me.new_membre.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.new_membre.Size = New System.Drawing.Size(209, 22)
        Me.new_membre.Text = "Employer"
        '
        'mewEntreprises
        '
        Me.mewEntreprises.BackColor = System.Drawing.Color.Gray
        Me.mewEntreprises.ForeColor = System.Drawing.Color.Black
        Me.mewEntreprises.Name = "mewEntreprises"
        Me.mewEntreprises.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mewEntreprises.Size = New System.Drawing.Size(209, 22)
        Me.mewEntreprises.Text = "Entreprises"
        '
        'UtilisateursToolStripMenuItem
        '
        Me.UtilisateursToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.UtilisateursToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UtilisateursToolStripMenuItem.Name = "UtilisateursToolStripMenuItem"
        Me.UtilisateursToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UtilisateursToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.UtilisateursToolStripMenuItem.Text = "Utilisateurs"
        '
        'DepartementsToolStripMenuItem
        '
        Me.DepartementsToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.DepartementsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DepartementsToolStripMenuItem.Name = "DepartementsToolStripMenuItem"
        Me.DepartementsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DepartementsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DepartementsToolStripMenuItem.Text = "Departements"
        '
        'StagairesToolStripMenuItem
        '
        Me.StagairesToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.StagairesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StagairesToolStripMenuItem.Name = "StagairesToolStripMenuItem"
        Me.StagairesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StagairesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StagairesToolStripMenuItem.Text = "Stagaires"
        '
        'mwModifier
        '
        Me.mwModifier.BackColor = System.Drawing.Color.Black
        Me.mwModifier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mod_employer, Me.mod_poste, Me.EntreprisesToolStripMenuItem, Me.UtilisateursToolStripMenuItem1, Me.DepartementsToolStripMenuItem1, Me.StagairesToolStripMenuItem1})
        Me.mwModifier.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mwModifier.ForeColor = System.Drawing.Color.LightPink
        Me.mwModifier.Name = "mwModifier"
        Me.mwModifier.ShortcutKeyDisplayString = "Modifier"
        Me.mwModifier.Size = New System.Drawing.Size(70, 30)
        Me.mwModifier.Text = "&Modifier"
        '
        'mod_employer
        '
        Me.mod_employer.BackColor = System.Drawing.Color.Gray
        Me.mod_employer.ForeColor = System.Drawing.Color.Black
        Me.mod_employer.Name = "mod_employer"
        Me.mod_employer.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mod_employer.Size = New System.Drawing.Size(242, 22)
        Me.mod_employer.Text = "Employer"
        '
        'mod_poste
        '
        Me.mod_poste.BackColor = System.Drawing.Color.Gray
        Me.mod_poste.ForeColor = System.Drawing.Color.Black
        Me.mod_poste.Name = "mod_poste"
        Me.mod_poste.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mod_poste.Size = New System.Drawing.Size(242, 22)
        Me.mod_poste.Text = "Congers"
        '
        'EntreprisesToolStripMenuItem
        '
        Me.EntreprisesToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.EntreprisesToolStripMenuItem.Name = "EntreprisesToolStripMenuItem"
        Me.EntreprisesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EntreprisesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.EntreprisesToolStripMenuItem.Text = "Entreprises"
        '
        'UtilisateursToolStripMenuItem1
        '
        Me.UtilisateursToolStripMenuItem1.BackColor = System.Drawing.Color.Gray
        Me.UtilisateursToolStripMenuItem1.Name = "UtilisateursToolStripMenuItem1"
        Me.UtilisateursToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UtilisateursToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
        Me.UtilisateursToolStripMenuItem1.Text = "Utilisateurs"
        '
        'DepartementsToolStripMenuItem1
        '
        Me.DepartementsToolStripMenuItem1.BackColor = System.Drawing.Color.Gray
        Me.DepartementsToolStripMenuItem1.Name = "DepartementsToolStripMenuItem1"
        Me.DepartementsToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DepartementsToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
        Me.DepartementsToolStripMenuItem1.Text = "Departements"
        '
        'StagairesToolStripMenuItem1
        '
        Me.StagairesToolStripMenuItem1.BackColor = System.Drawing.Color.Gray
        Me.StagairesToolStripMenuItem1.Name = "StagairesToolStripMenuItem1"
        Me.StagairesToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StagairesToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
        Me.StagairesToolStripMenuItem1.Text = "Stagaires"
        '
        'mwSupprimer
        '
        Me.mwSupprimer.BackColor = System.Drawing.Color.Black
        Me.mwSupprimer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem5, Me.EntreprisesToolStripMenuItem1, Me.UtilisateursToolStripMenuItem2, Me.DepartementsToolStripMenuItem2, Me.SToolStripMenuItem})
        Me.mwSupprimer.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mwSupprimer.ForeColor = System.Drawing.Color.LightPink
        Me.mwSupprimer.Name = "mwSupprimer"
        Me.mwSupprimer.ShortcutKeyDisplayString = "Supprimer"
        Me.mwSupprimer.Size = New System.Drawing.Size(84, 30)
        Me.mwSupprimer.Text = "&Supprimer"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.BackColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(233, 22)
        Me.ToolStripMenuItem8.Text = "Employer"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(233, 22)
        Me.ToolStripMenuItem5.Text = "Congers"
        '
        'EntreprisesToolStripMenuItem1
        '
        Me.EntreprisesToolStripMenuItem1.BackColor = System.Drawing.Color.Gray
        Me.EntreprisesToolStripMenuItem1.Name = "EntreprisesToolStripMenuItem1"
        Me.EntreprisesToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EntreprisesToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.EntreprisesToolStripMenuItem1.Text = "Entreprises"
        '
        'UtilisateursToolStripMenuItem2
        '
        Me.UtilisateursToolStripMenuItem2.BackColor = System.Drawing.Color.Gray
        Me.UtilisateursToolStripMenuItem2.Name = "UtilisateursToolStripMenuItem2"
        Me.UtilisateursToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UtilisateursToolStripMenuItem2.Size = New System.Drawing.Size(233, 22)
        Me.UtilisateursToolStripMenuItem2.Text = "Utilisateurs"
        '
        'DepartementsToolStripMenuItem2
        '
        Me.DepartementsToolStripMenuItem2.BackColor = System.Drawing.Color.Gray
        Me.DepartementsToolStripMenuItem2.Name = "DepartementsToolStripMenuItem2"
        Me.DepartementsToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DepartementsToolStripMenuItem2.Size = New System.Drawing.Size(233, 22)
        Me.DepartementsToolStripMenuItem2.Text = "Departements"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.SToolStripMenuItem.Text = "Stagaires"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.InformationToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformationToolStripMenuItem.ForeColor = System.Drawing.Color.LightPink
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(93, 30)
        Me.InformationToolStripMenuItem.Text = "&Information"
        '
        'lblheure
        '
        Me.lblheure.AutoSize = True
        Me.lblheure.BackColor = System.Drawing.Color.Black
        Me.lblheure.Font = New System.Drawing.Font("Meiryo UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheure.ForeColor = System.Drawing.Color.Crimson
        Me.lblheure.Location = New System.Drawing.Point(542, 4)
        Me.lblheure.Name = "lblheure"
        Me.lblheure.Size = New System.Drawing.Size(74, 26)
        Me.lblheure.TabIndex = 20
        Me.lblheure.Text = "Heure"
        Me.lblheure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button7
        '
        Me.Button7.AllowDrop = True
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(1033, 55)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(20, 20)
        Me.Button7.TabIndex = 33
        Me.Button7.Tag = "Minimize"
        Me.Button7.UseCompatibleTextRendering = True
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(1098, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(20, 20)
        Me.Button6.TabIndex = 30
        Me.Button6.Tag = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(1078, 55)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 20)
        Me.Button5.TabIndex = 29
        Me.Button5.Tag = "Maximize"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AllowDrop = True
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(1058, 55)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 28
        Me.Button4.Tag = "Minimize"
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.Location = New System.Drawing.Point(11, 0)
        Me.lblmessage.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(556, 54)
        Me.lblmessage.TabIndex = 7
        Me.lblmessage.Text = "GESTION DU PERSONNEL"
        '
        'Timer2
        '
        '
        'panSupport
        '
        Me.panSupport.Controls.Add(Me.lblmessage)
        Me.panSupport.Location = New System.Drawing.Point(3, 3)
        Me.panSupport.Name = "panSupport"
        Me.panSupport.Size = New System.Drawing.Size(1417, 55)
        Me.panSupport.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.panSupport)
        Me.FlowLayoutPanel1.Controls.Add(Me.cboListePolices)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkDefilement)
        Me.FlowLayoutPanel1.Controls.Add(Me.trkvitesse)
        Me.FlowLayoutPanel1.Controls.Add(Me.Vitesse)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(-55, 33)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1420, 60)
        Me.FlowLayoutPanel1.TabIndex = 34
        '
        'cboListePolices
        '
        Me.cboListePolices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboListePolices.FormattingEnabled = True
        Me.cboListePolices.Location = New System.Drawing.Point(3, 64)
        Me.cboListePolices.Name = "cboListePolices"
        Me.cboListePolices.Size = New System.Drawing.Size(121, 21)
        Me.cboListePolices.Sorted = True
        Me.cboListePolices.TabIndex = 10
        Me.cboListePolices.Visible = False
        '
        'chkDefilement
        '
        Me.chkDefilement.AutoSize = True
        Me.chkDefilement.Checked = True
        Me.chkDefilement.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefilement.Location = New System.Drawing.Point(130, 64)
        Me.chkDefilement.Name = "chkDefilement"
        Me.chkDefilement.Size = New System.Drawing.Size(76, 17)
        Me.chkDefilement.TabIndex = 11
        Me.chkDefilement.Text = "Défilement"
        Me.chkDefilement.Visible = False
        '
        'trkvitesse
        '
        Me.trkvitesse.Location = New System.Drawing.Point(212, 64)
        Me.trkvitesse.Maximum = 500
        Me.trkvitesse.Minimum = 10
        Me.trkvitesse.Name = "trkvitesse"
        Me.trkvitesse.Size = New System.Drawing.Size(106, 45)
        Me.trkvitesse.TabIndex = 29
        Me.trkvitesse.TickFrequency = 49
        Me.trkvitesse.Value = 10
        Me.trkvitesse.Visible = False
        '
        'Vitesse
        '
        Me.Vitesse.AutoSize = True
        Me.Vitesse.Location = New System.Drawing.Point(324, 61)
        Me.Vitesse.Name = "Vitesse"
        Me.Vitesse.Size = New System.Drawing.Size(41, 13)
        Me.Vitesse.TabIndex = 30
        Me.Vitesse.Text = "Vitesse"
        Me.Vitesse.Visible = False
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlowLayoutPanel4.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel4.Controls.Add(Me.CbRecher)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel4.Controls.Add(Me.CbSpecifier)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel4.Controls.Add(Me.txtRechercher)
        Me.FlowLayoutPanel4.Controls.Add(Me.lst_Recher)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 92)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1365, 34)
        Me.FlowLayoutPanel4.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Rechercher par:"
        '
        'CbRecher
        '
        Me.CbRecher.FormattingEnabled = True
        Me.CbRecher.Items.AddRange(New Object() {"Matricule", "Nom", "Identifiant"})
        Me.CbRecher.Location = New System.Drawing.Point(148, 3)
        Me.CbRecher.Name = "CbRecher"
        Me.CbRecher.Size = New System.Drawing.Size(149, 21)
        Me.CbRecher.TabIndex = 1
        Me.CbRecher.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Considéré comme:"
        '
        'CbSpecifier
        '
        Me.CbSpecifier.FormattingEnabled = True
        Me.CbSpecifier.Items.AddRange(New Object() {"Entreprises", "Employes", "Departements", "Congers", "Stagaire", "Utilisateurs"})
        Me.CbSpecifier.Location = New System.Drawing.Point(451, 3)
        Me.CbSpecifier.Name = "CbSpecifier"
        Me.CbSpecifier.Size = New System.Drawing.Size(144, 21)
        Me.CbSpecifier.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(601, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Rechercher:"
        '
        'txtRechercher
        '
        Me.txtRechercher.Location = New System.Drawing.Point(712, 3)
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(215, 20)
        Me.txtRechercher.TabIndex = 22
        '
        'lst_Recher
        '
        Me.lst_Recher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lst_Recher.FormattingEnabled = True
        Me.lst_Recher.Location = New System.Drawing.Point(933, 3)
        Me.lst_Recher.Name = "lst_Recher"
        Me.lst_Recher.Size = New System.Drawing.Size(180, 21)
        Me.lst_Recher.TabIndex = 24
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(6, 124)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1202, 533)
        Me.DGV.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.LightPink
        Me.Label1.Location = New System.Drawing.Point(1281, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "&Deconnecter"
        '
        'ProfilImage
        '
        Me.ProfilImage.BackgroundImage = CType(resources.GetObject("ProfilImage.BackgroundImage"), System.Drawing.Image)
        Me.ProfilImage.Location = New System.Drawing.Point(1211, 132)
        Me.ProfilImage.Name = "ProfilImage"
        Me.ProfilImage.Size = New System.Drawing.Size(142, 118)
        Me.ProfilImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilImage.TabIndex = 38
        Me.ProfilImage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1212, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Photo_Personnel"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(1259, 480)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 20)
        Me.lblCount.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1223, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 48)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Nombres " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D'Employer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dans Entreprises" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 669)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProfilImage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.lblheure)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPersonnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FORMULAIRE_PRINCIPAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panSupport.ResumeLayout(False)
        Me.panSupport.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.trkvitesse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents new_conger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents new_membre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mewEntreprises As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mwModifier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mod_employer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mod_poste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mwSupprimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblheure As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents UtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StagairesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntreprisesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilisateursToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartementsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StagairesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntreprisesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilisateursToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartementsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents panSupport As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cboListePolices As System.Windows.Forms.ComboBox
    Friend WithEvents chkDefilement As System.Windows.Forms.CheckBox
    Friend WithEvents trkvitesse As System.Windows.Forms.TrackBar
    Friend WithEvents Vitesse As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbRecher As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbSpecifier As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRechercher As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProfilImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lst_Recher As System.Windows.Forms.ComboBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
