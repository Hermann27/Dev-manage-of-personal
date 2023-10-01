' '**************************************************************************************************
'j'ais recupere ce code sur vbfrance qui est de lumesh. je cherche a faire une capture
'd'image a partir d'une source video comme une webcam.
'l exemple de lumesh me semblait le mieux approprié pour ce genre de manip d'autant plus
'qu'il utilise DirectX. ce que tout le monde a sur son pc (..enfin tout joueur que ce resprect.;))
'j'ais modifier son code ( modCap) ou la declaration de sa structure Active ne faisait pas 
'appel a Capure de DirectX.Capture.Capture mais directement de Capture .
'ainsi grace a DirectX.Capture.Capture je beneficie d'une liste d'enenements comme la capture d'image.
'Bon il est possible que je raconte pas mal de conneries....mais ca marche, donc si vraiment je me met
'le doigt dans l'oeil dite moi pourquoi. 24/11/2006
'**************************************************************************************************
Imports DirectX.Capture

Public Class FrmWebcam
    Inherits System.Windows.Forms.Form
    Dim NombreDeCapture As Int16
    Dim TimeElapsCapture As Integer
    Dim StartTime As Date



#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    ' Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(347, 237)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(244, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Executer"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(347, 274)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(244, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(24, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Temp_Capture"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(25, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 157)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(347, 43)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 157)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(410, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Capture image"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Source_Webcam :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Source_Micropho:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Photo_IMobile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(402, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Photo_Mobile"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(324, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Save"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Pink
        Me.Label6.Location = New System.Drawing.Point(2, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Realiser Par :Djoumdjeu "
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(227, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 35)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Fermer"
        '
        'FrmWebcam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(603, 386)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Name = "FrmWebcam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choisir la caméra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim j As Short
        'Dim f As Filter

        ''listage des peripheriques video installés sur la machine
        'ComboBox1.Items.Clear()
        'For j = 0 To Dispositivos.VideoInputDevices.Count - 1
        '    f = Dispositivos.VideoInputDevices(j)
        '    ComboBox1.Items.Add(f.Name)
        'Next
        'If j > 0 Then ComboBox1.SelectedIndex = 0

        ''listage des peripheriques audio installés sur la machine
        'ComboBox2.Items.Clear()
        'For j = 0 To Dispositivos.AudioInputDevices.Count - 1
        '    f = Dispositivos.AudioInputDevices(j)
        '    ComboBox2.Items.Add(f.Name)
        'Next
        'If j > 0 Then ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'pre configuration du capturing
        'definission de la camera
        CaptureInformation2.Camera = Dispositivos.VideoInputDevices(ComboBox1.SelectedIndex)
        'mise en place du stream video et audio
        CaptureInformation2.CaptureInfo = New DirectX.Capture.Capture(CaptureInformation2.Camera, Dispositivos.AudioInputDevices(ComboBox2.SelectedIndex))
        'renseignement du panneau d'affichage de la video
        CaptureInformation2.CaptureInfo.PreviewWindow = PictureBox2
        'compteur pour les capture d'image (frame video)
        CaptureInformation2.Counter = 1
        CaptureInformation2.CounterFrames = 1
        'configurations avancées
        Configurer()
        'pour faire plus joli
        Button1.Enabled = False
        'pour la gestion evennementiel de la capture d'ecran je cree un gestionnaire d evennement sur Framecapturecomplete
        AddHandler CaptureInformation2.CaptureInfo.FrameCaptureComplete, AddressOf NewCaptureReady
    End Sub

    Private Sub Configurer()

        'configurations avancées
        'configuration du systeme de compression video et audio
        CaptureInformation2.CaptureInfo.VideoCompressor = Dispositivos.VideoCompressors(1) 'compression video
        'taille de la video
        CaptureInformation2.CaptureInfo.FrameSize = New Size(320, 240) 'taille de la video
        'FPS de la video
        CaptureInformation2.CaptureInfo.FrameRate = 50 'FPS
        'fichier .avi
        ''CaptureInformation.CaptureInfo.Filename = Application.StartupPath + "\essai.avi"
        'lancement du streaming d'affichage
        CaptureInformation2.CaptureInfo.RenderPreview()

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
    Private Sub NewCaptureReady(ByVal Sender As System.Windows.Forms.PictureBox)
        'appele par le gestionnaire de handler sur l'evennement "FrameCapture
        'ma picture capturé est arrivée...

        Dim la As PictureBox = CType(Sender, PictureBox) 'la je converti mon picturebox en picturebox...je sais pas pourquoi, fo le faire sinom ca marche pas

        '' histoire de savoir combien ca prends de temps de faire une capture.
        Dim RunLength As System.TimeSpan = Now.Subtract(StartTime)
        Dim TimeElapsCapture As Integer = RunLength.Milliseconds

        Label1.Visible = True
        NombreDeCapture = NombreDeCapture + 1
        Label1.Text = "Capture nmr:" & NombreDeCapture & " Capture realisée en:" & TimeElapsCapture & " ms"
        PictureBox1.Image = la.Image 'j affecte ma capture d'image a mon picturebox qui attend que ca.

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'demande une capture DirectX ...et lorsqu'elle est ready je la recoit par le Handler cree un peut plus haut
        Dim StartTime = Now()    ' Starting date/time.
        CaptureInformation2.CaptureInfo.CaptureFrame()

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
