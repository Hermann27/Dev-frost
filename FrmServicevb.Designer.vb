<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicevb
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
        Me.txtEntrep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.LBL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnClose = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSup = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnMod = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.IDU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personnel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supprimer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CmbPers = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDur = New System.Windows.Forms.TextBox()
        Me.txtDat = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.KryptonPanel.Controls.Add(Me.txtEntrep)
        Me.KryptonPanel.Controls.Add(Me.Label3)
        Me.KryptonPanel.Controls.Add(Me.txtnumero)
        Me.KryptonPanel.Controls.Add(Me.LBL)
        Me.KryptonPanel.Controls.Add(Me.btnClose)
        Me.KryptonPanel.Controls.Add(Me.btnSup)
        Me.KryptonPanel.Controls.Add(Me.btnMod)
        Me.KryptonPanel.Controls.Add(Me.btnSave)
        Me.KryptonPanel.Controls.Add(Me.DGV)
        Me.KryptonPanel.Controls.Add(Me.CmbPers)
        Me.KryptonPanel.Controls.Add(Me.Label7)
        Me.KryptonPanel.Controls.Add(Me.txtDur)
        Me.KryptonPanel.Controls.Add(Me.txtDat)
        Me.KryptonPanel.Controls.Add(Me.txtNom)
        Me.KryptonPanel.Controls.Add(Me.Label4)
        Me.KryptonPanel.Controls.Add(Me.Label2)
        Me.KryptonPanel.Controls.Add(Me.Label1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(773, 337)
        Me.KryptonPanel.TabIndex = 0
        '
        'txtEntrep
        '
        Me.txtEntrep.Enabled = False
        Me.txtEntrep.Location = New System.Drawing.Point(573, 13)
        Me.txtEntrep.Name = "txtEntrep"
        Me.txtEntrep.Size = New System.Drawing.Size(177, 20)
        Me.txtEntrep.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(513, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Entreprise"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(573, 48)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(41, 20)
        Me.txtnumero.TabIndex = 52
        Me.txtnumero.Visible = False
        '
        'LBL
        '
        Me.LBL.Location = New System.Drawing.Point(516, 48)
        Me.LBL.Name = "LBL"
        Me.LBL.Size = New System.Drawing.Size(24, 20)
        Me.LBL.TabIndex = 51
        Me.LBL.Values.Text = "N°"
        Me.LBL.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(660, 300)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 25)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Values.Text = "Fermer"
        '
        'btnSup
        '
        Me.btnSup.Location = New System.Drawing.Point(447, 300)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(90, 25)
        Me.btnSup.TabIndex = 49
        Me.btnSup.Values.Text = "Supprimer"
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(234, 300)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(90, 25)
        Me.btnMod.TabIndex = 48
        Me.btnMod.Values.Text = "Modifier"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(21, 300)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Values.Text = "Enregistrer"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDU, Me.Nom, Me.Personnel, Me.Duree, Me.DateD, Me.Supprimer})
        Me.DGV.Location = New System.Drawing.Point(21, 138)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(730, 138)
        Me.DGV.TabIndex = 46
        '
        'IDU
        '
        Me.IDU.FillWeight = 29.61611!
        Me.IDU.HeaderText = "N°"
        Me.IDU.MaxInputLength = 3276
        Me.IDU.Name = "IDU"
        '
        'Nom
        '
        Me.Nom.FillWeight = 123.5604!
        Me.Nom.HeaderText = "Nom du service"
        Me.Nom.Name = "Nom"
        '
        'Personnel
        '
        Me.Personnel.FillWeight = 123.5604!
        Me.Personnel.HeaderText = "Client"
        Me.Personnel.Name = "Personnel"
        '
        'Duree
        '
        Me.Duree.FillWeight = 123.5604!
        Me.Duree.HeaderText = "Durée"
        Me.Duree.Name = "Duree"
        '
        'DateD
        '
        Me.DateD.FillWeight = 123.5604!
        Me.DateD.HeaderText = "Date Demande"
        Me.DateD.Name = "DateD"
        '
        'Supprimer
        '
        Me.Supprimer.FillWeight = 76.14214!
        Me.Supprimer.HeaderText = "Supprimer"
        Me.Supprimer.Name = "Supprimer"
        '
        'CmbPers
        '
        Me.CmbPers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPers.FormattingEnabled = True
        Me.CmbPers.Location = New System.Drawing.Point(346, 48)
        Me.CmbPers.Name = "CmbPers"
        Me.CmbPers.Size = New System.Drawing.Size(156, 21)
        Me.CmbPers.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(299, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Client"
        '
        'txtDur
        '
        Me.txtDur.Location = New System.Drawing.Point(346, 12)
        Me.txtDur.Name = "txtDur"
        Me.txtDur.Size = New System.Drawing.Size(156, 20)
        Me.txtDur.TabIndex = 43
        '
        'txtDat
        '
        Me.txtDat.Location = New System.Drawing.Point(127, 48)
        Me.txtDat.Name = "txtDat"
        Me.txtDat.Size = New System.Drawing.Size(160, 20)
        Me.txtDat.TabIndex = 42
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(127, 10)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(160, 20)
        Me.txtNom.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(299, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Durée"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Date de la demande"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nom du service"
        '
        'FrmServicevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 337)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FrmServicevb"
        Me.Text = "FrmServicevb"
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
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents LBL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnClose As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSup As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMod As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CmbPers As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDur As System.Windows.Forms.TextBox
    Friend WithEvents txtDat As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Personnel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supprimer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtEntrep As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
