<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUser
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
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.LBL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.IDU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Privilege = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entreprise = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supprimer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CmbEntrep = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbPriv = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtCNI = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtnumero)
        Me.KryptonPanel.Controls.Add(Me.LBL)
        Me.KryptonPanel.Controls.Add(Me.btnClose)
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.btnSave)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.CmbEntrep)
        Me.KryptonPanel.Controls.Add(Me.Label7)
        Me.KryptonPanel.Controls.Add(Me.CmbPriv)
        Me.KryptonPanel.Controls.Add(Me.Label6)
        Me.KryptonPanel.Controls.Add(Me.txtPass)
        Me.KryptonPanel.Controls.Add(Me.txtLog)
        Me.KryptonPanel.Controls.Add(Me.txtCNI)
        Me.KryptonPanel.Controls.Add(Me.txtPrenom)
        Me.KryptonPanel.Controls.Add(Me.txtNom)
        Me.KryptonPanel.Controls.Add(Me.Label5)
        Me.KryptonPanel.Controls.Add(Me.Label4)
        Me.KryptonPanel.Controls.Add(Me.Label3)
        Me.KryptonPanel.Controls.Add(Me.Label2)
        Me.KryptonPanel.Controls.Add(Me.Label1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(763, 371)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(610, 68)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(41, 20)
        Me.txtnumero.TabIndex = 37
        '
        'LBL
        '
        Me.LBL.Location = New System.Drawing.Point(553, 68)
        Me.LBL.Name = "LBL"
        Me.LBL.Size = New System.Drawing.Size(24, 20)
        Me.LBL.TabIndex = 36
        Me.LBL.Values.Text = "N°"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(648, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 25)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Values.Text = "Fermer"
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(446, 327)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 34
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(244, 327)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 33
        Me.btnMod.Values.Text = "Modifier"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(27, 327)
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDU, Me.Nom, Me.Prenom, Me.CNI, Me.Login, Me.Password, Me.Privilege, Me.Entreprise, Me.Supprimer})
        Me.DGV.Location = New System.Drawing.Point(27, 158)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(724, 150)
        Me.DGV.TabIndex = 31
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
        'CNI
        '
        Me.CNI.HeaderText = "CNI"
        Me.CNI.Name = "CNI"
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        '
        'Password
        '
        Me.Password.HeaderText = "Mot de passe"
        Me.Password.Name = "Password"
        '
        'Privilege
        '
        Me.Privilege.HeaderText = "Privilège"
        Me.Privilege.Name = "Privilege"
        '
        'Entreprise
        '
        Me.Entreprise.HeaderText = "Entreprise"
        Me.Entreprise.Name = "Entreprise"
        '
        'Supprimer
        '
        Me.Supprimer.HeaderText = "Supprimer"
        Me.Supprimer.Name = "Supprimer"
        '
        'CmbEntrep
        '
        Me.CmbEntrep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEntrep.FormattingEnabled = True
        Me.CmbEntrep.Location = New System.Drawing.Point(610, 25)
        Me.CmbEntrep.Name = "CmbEntrep"
        Me.CmbEntrep.Size = New System.Drawing.Size(141, 21)
        Me.CmbEntrep.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(550, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Entreprise"
        '
        'CmbPriv
        '
        Me.CmbPriv.FormattingEnabled = True
        Me.CmbPriv.Items.AddRange(New Object() {"Admin", "User"})
        Me.CmbPriv.Location = New System.Drawing.Point(381, 107)
        Me.CmbPriv.Name = "CmbPriv"
        Me.CmbPriv.Size = New System.Drawing.Size(156, 21)
        Me.CmbPriv.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(299, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Privilège"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(381, 68)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtPass.Size = New System.Drawing.Size(156, 20)
        Me.txtPass.TabIndex = 26
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(381, 26)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(156, 20)
        Me.txtLog.TabIndex = 25
        '
        'txtCNI
        '
        Me.txtCNI.Location = New System.Drawing.Point(77, 107)
        Me.txtCNI.Name = "txtCNI"
        Me.txtCNI.Size = New System.Drawing.Size(196, 20)
        Me.txtCNI.TabIndex = 24
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
        Me.Label5.Location = New System.Drawing.Point(299, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Mot de Passe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(299, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(24, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CNI"
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
        'FrmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 371)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FrmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUser"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents CmbEntrep As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbPriv As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents txtCNI As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents IDU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prenom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Privilege As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entreprise As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supprimer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents LBL As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
