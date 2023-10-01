<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSupp = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ville = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Siteweb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Slogan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supprimer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtadresse = New System.Windows.Forms.TextBox()
        Me.txtslogan = New System.Windows.Forms.TextBox()
        Me.txtsite = New System.Windows.Forms.TextBox()
        Me.txtfax = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtville = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtBP = New System.Windows.Forms.TextBox()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.KryptonPanel.Controls.Add(Me.btnSupp)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.btnSave)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.txtadresse)
        Me.KryptonPanel.Controls.Add(Me.txtslogan)
        Me.KryptonPanel.Controls.Add(Me.txtsite)
        Me.KryptonPanel.Controls.Add(Me.txtfax)
        Me.KryptonPanel.Controls.Add(Me.txtemail)
        Me.KryptonPanel.Controls.Add(Me.txtville)
        Me.KryptonPanel.Controls.Add(Me.txtphone)
        Me.KryptonPanel.Controls.Add(Me.txtBP)
        Me.KryptonPanel.Controls.Add(Me.txtnom)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(954, 412)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(889, 105)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(41, 20)
        Me.txtnumero.TabIndex = 27
        '
        'LBL
        '
        Me.LBL.Location = New System.Drawing.Point(856, 105)
        Me.LBL.Name = "LBL"
        Me.LBL.Size = New System.Drawing.Size(24, 20)
        Me.LBL.TabIndex = 26
        Me.LBL.Values.Text = "N°"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(796, 366)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 25)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Values.Text = "Fermer"
        '
        'btnSupp
        '
        Me.btnSupp.Location = New System.Drawing.Point(561, 366)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(90, 25)
        Me.btnSupp.TabIndex = 24
        Me.btnSupp.Values.Text = "Supprimer"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(326, 366)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 23
        Me.btnMod.Values.Text = "Modifier"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(91, 366)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Values.Text = "Enregistrer"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nom, Me.BP, Me.Tel, Me.Ville, Me.Email, Me.Siteweb, Me.Slogan, Me.Fax, Me.Adresse, Me.Supprimer})
        Me.DGV.Location = New System.Drawing.Point(22, 171)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(905, 189)
        Me.DGV.TabIndex = 21
        '
        'ID
        '
        Me.ID.HeaderText = "N°"
        Me.ID.Name = "ID"
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom Entreprise"
        Me.Nom.Name = "Nom"
        '
        'BP
        '
        Me.BP.HeaderText = "BP"
        Me.BP.Name = "BP"
        '
        'Tel
        '
        Me.Tel.HeaderText = "Tel"
        Me.Tel.Name = "Tel"
        '
        'Ville
        '
        Me.Ville.HeaderText = "Ville"
        Me.Ville.Name = "Ville"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Siteweb
        '
        Me.Siteweb.HeaderText = "Site"
        Me.Siteweb.Name = "Siteweb"
        '
        'Slogan
        '
        Me.Slogan.HeaderText = "Slogan"
        Me.Slogan.Name = "Slogan"
        '
        'Fax
        '
        Me.Fax.HeaderText = "Fax"
        Me.Fax.Name = "Fax"
        '
        'Adresse
        '
        Me.Adresse.HeaderText = "Adresse"
        Me.Adresse.Name = "Adresse"
        '
        'Supprimer
        '
        Me.Supprimer.HeaderText = "Supprimer"
        Me.Supprimer.Name = "Supprimer"
        '
        'txtadresse
        '
        Me.txtadresse.Location = New System.Drawing.Point(718, 28)
        Me.txtadresse.Name = "txtadresse"
        Me.txtadresse.Size = New System.Drawing.Size(212, 20)
        Me.txtadresse.TabIndex = 20
        '
        'txtslogan
        '
        Me.txtslogan.Location = New System.Drawing.Point(718, 66)
        Me.txtslogan.Name = "txtslogan"
        Me.txtslogan.Size = New System.Drawing.Size(212, 20)
        Me.txtslogan.TabIndex = 18
        '
        'txtsite
        '
        Me.txtsite.Location = New System.Drawing.Point(422, 66)
        Me.txtsite.Name = "txtsite"
        Me.txtsite.Size = New System.Drawing.Size(218, 20)
        Me.txtsite.TabIndex = 17
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(718, 106)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(133, 20)
        Me.txtfax.TabIndex = 16
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(422, 28)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(218, 20)
        Me.txtemail.TabIndex = 15
        '
        'txtville
        '
        Me.txtville.Location = New System.Drawing.Point(422, 106)
        Me.txtville.Name = "txtville"
        Me.txtville.Size = New System.Drawing.Size(135, 20)
        Me.txtville.TabIndex = 14
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(153, 106)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(126, 20)
        Me.txtphone.TabIndex = 13
        '
        'txtBP
        '
        Me.txtBP.Location = New System.Drawing.Point(153, 66)
        Me.txtBP.Name = "txtBP"
        Me.txtBP.Size = New System.Drawing.Size(126, 20)
        Me.txtBP.TabIndex = 12
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(153, 28)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(181, 20)
        Me.txtnom.TabIndex = 11
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(659, 28)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel9.TabIndex = 9
        Me.KryptonLabel9.Values.Text = "Adresse"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(665, 105)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(28, 20)
        Me.KryptonLabel8.TabIndex = 8
        Me.KryptonLabel8.Values.Text = "Fax"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(357, 66)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel7.TabIndex = 7
        Me.KryptonLabel7.Values.Text = "Site Web "
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(665, 66)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel6.TabIndex = 6
        Me.KryptonLabel6.Values.Text = "Slogan"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(357, 28)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(40, 20)
        Me.KryptonLabel5.TabIndex = 5
        Me.KryptonLabel5.Values.Text = "Email"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(22, 28)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(125, 20)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Values.Text = "Nom de l'entreprise :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(22, 66)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(31, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "BP :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(22, 106)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Values.Text = "Telephone"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(357, 106)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel4.TabIndex = 4
        Me.KryptonLabel4.Values.Text = "Ville"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 412)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSupp As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtadresse As System.Windows.Forms.TextBox
    Friend WithEvents txtslogan As System.Windows.Forms.TextBox
    Friend WithEvents txtsite As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtville As System.Windows.Forms.TextBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtBP As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ville As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Siteweb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Slogan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supprimer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents LBL As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
