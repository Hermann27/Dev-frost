<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonnel
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CmbSoc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.LBL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.IDU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Poste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supprimer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(814, 369)
        Me.KryptonPanel.TabIndex = 0
        '
        'CmbSoc
        '
        Me.CmbSoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSoc.FormattingEnabled = True
        Me.CmbSoc.Items.AddRange(New Object() {"Admin", "User"})
        Me.CmbSoc.Location = New System.Drawing.Point(594, 67)
        Me.CmbSoc.Name = "CmbSoc"
        Me.CmbSoc.Size = New System.Drawing.Size(196, 21)
        Me.CmbSoc.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(534, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Société"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(357, 68)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(107, 20)
        Me.txtTel.TabIndex = 26
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.txtnumero)
        Me.KryptonPanel1.Controls.Add(Me.LBL)
        Me.KryptonPanel1.Controls.Add(Me.btnClose)
        Me.KryptonPanel1.Controls.Add(Me.btnSup)
        Me.KryptonPanel1.Controls.Add(Me.btnMod)
        Me.KryptonPanel1.Controls.Add(Me.btnSave)
        Me.KryptonPanel1.Controls.Add(Me.DGV)
        Me.KryptonPanel1.Controls.Add(Me.CmbSoc)
        Me.KryptonPanel1.Controls.Add(Me.Label6)
        Me.KryptonPanel1.Controls.Add(Me.txtTel)
        Me.KryptonPanel1.Controls.Add(Me.txtEmail)
        Me.KryptonPanel1.Controls.Add(Me.txtPost)
        Me.KryptonPanel1.Controls.Add(Me.txtPrenom)
        Me.KryptonPanel1.Controls.Add(Me.txtNom)
        Me.KryptonPanel1.Controls.Add(Me.Label5)
        Me.KryptonPanel1.Controls.Add(Me.Label4)
        Me.KryptonPanel1.Controls.Add(Me.Label3)
        Me.KryptonPanel1.Controls.Add(Me.Label2)
        Me.KryptonPanel1.Controls.Add(Me.Label1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(814, 369)
        Me.KryptonPanel1.TabIndex = 1
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(481, 67)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(32, 20)
        Me.txtnumero.TabIndex = 39
        '
        'LBL
        '
        Me.LBL.Location = New System.Drawing.Point(461, 68)
        Me.LBL.Name = "LBL"
        Me.LBL.Size = New System.Drawing.Size(24, 20)
        Me.LBL.TabIndex = 38
        Me.LBL.Values.Text = "N°"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(560, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 25)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Values.Text = "Fermer"
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(428, 327)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 34
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(296, 327)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 33
        Me.btnMod.Values.Text = "Modifier"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(164, 327)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Values.Text = "Enregistrer"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDU, Me.Nom, Me.Prenom, Me.Email, Me.tel, Me.Poste, Me.Societe, Me.Supprimer})
        Me.DGV.Location = New System.Drawing.Point(27, 127)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(763, 175)
        Me.DGV.TabIndex = 31
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(357, 30)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(156, 20)
        Me.txtEmail.TabIndex = 25
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(594, 30)
        Me.txtPost.Multiline = True
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(196, 20)
        Me.txtPost.TabIndex = 24
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(77, 68)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(196, 20)
        Me.txtPrenom.TabIndex = 23
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(77, 30)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(196, 20)
        Me.txtNom.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(297, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Telephone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(297, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(534, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fonction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nom"
        '
        'IDU
        '
        Me.IDU.HeaderText = "N°"
        Me.IDU.Name = "IDU"
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        '
        'Prenom
        '
        Me.Prenom.HeaderText = "Prenom"
        Me.Prenom.Name = "Prenom"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'tel
        '
        Me.tel.HeaderText = "Telephone"
        Me.tel.Name = "tel"
        '
        'Poste
        '
        Me.Poste.HeaderText = "Fonction"
        Me.Poste.Name = "Poste"
        '
        'Societe
        '
        Me.Societe.HeaderText = "Société"
        Me.Societe.Name = "Societe"
        '
        'Supprimer
        '
        Me.Supprimer.HeaderText = "Supprimer"
        Me.Supprimer.Name = "Supprimer"
        '
        'FrmPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 369)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FrmPersonnel"
        Me.Text = "FrmPersonnel"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents CmbSoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPost As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents LBL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents IDU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prenom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Poste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supprimer As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
