<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_lav = New System.Windows.Forms.ComboBox()
        Me.txt_commento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiudiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABELLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABELLA1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGLIOAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGLIOBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABELLA2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGLIOAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGLIOBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABELLA3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGLIOAToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOGLIOBToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_idlav = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trb_rapido = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_speed = New System.Windows.Forms.Label()
        Me.chk_norapido = New System.Windows.Forms.CheckBox()
        Me.btn_surplus = New System.Windows.Forms.Button()
        Me.txt_ore_surplus = New System.Windows.Forms.TextBox()
        Me.txt_minuti_surplus = New System.Windows.Forms.TextBox()
        Me.txt_commentoSurplus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgw_lav = New System.Windows.Forms.DataGridView()
        Me.btn_conferma_surplus = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.trb_rapido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw_lav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_calc)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_lav)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(7, 89)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(212, 23)
        Me.btn_calc.TabIndex = 4
        Me.btn_calc.Text = "CALCOLA"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(7, 60)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(212, 23)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "AGGIUNGI"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LAVORAZIONI DISPONIBILI"
        '
        'cmb_lav
        '
        Me.cmb_lav.FormattingEnabled = True
        Me.cmb_lav.Items.AddRange(New Object() {"FORATURA", "MASCHIATURA", "FRESATURA"})
        Me.cmb_lav.Location = New System.Drawing.Point(6, 32)
        Me.cmb_lav.Name = "cmb_lav"
        Me.cmb_lav.Size = New System.Drawing.Size(213, 21)
        Me.cmb_lav.TabIndex = 0
        '
        'txt_commento
        '
        Me.txt_commento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_commento.Location = New System.Drawing.Point(12, 166)
        Me.txt_commento.Multiline = True
        Me.txt_commento.Name = "txt_commento"
        Me.txt_commento.Size = New System.Drawing.Size(225, 303)
        Me.txt_commento.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "COMMENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LAVORAZIONI"
        '
        'txt_tot
        '
        Me.txt_tot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tot.Location = New System.Drawing.Point(672, 529)
        Me.txt_tot.Name = "txt_tot"
        Me.txt_tot.Size = New System.Drawing.Size(100, 20)
        Me.txt_tot.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 532)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TEMPO TOTALE STIMATO [hh:mm:ss.dcm]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.ToolStripMenuItem1, Me.TABELLEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovoToolStripMenuItem, Me.ApriToolStripMenuItem, Me.SalvaToolStripMenuItem, Me.ChiudiToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'NuovoToolStripMenuItem
        '
        Me.NuovoToolStripMenuItem.Image = Global.Preventivo_Centro_Lavoro.My.Resources.Resources.nuovo
        Me.NuovoToolStripMenuItem.Name = "NuovoToolStripMenuItem"
        Me.NuovoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuovoToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NuovoToolStripMenuItem.Text = "Nuovo"
        '
        'ApriToolStripMenuItem
        '
        Me.ApriToolStripMenuItem.Image = Global.Preventivo_Centro_Lavoro.My.Resources.Resources.apri
        Me.ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        Me.ApriToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ApriToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ApriToolStripMenuItem.Text = "Apri"
        '
        'SalvaToolStripMenuItem
        '
        Me.SalvaToolStripMenuItem.Image = Global.Preventivo_Centro_Lavoro.My.Resources.Resources.salva
        Me.SalvaToolStripMenuItem.Name = "SalvaToolStripMenuItem"
        Me.SalvaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalvaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SalvaToolStripMenuItem.Text = "Salva"
        '
        'ChiudiToolStripMenuItem
        '
        Me.ChiudiToolStripMenuItem.Image = Global.Preventivo_Centro_Lavoro.My.Resources.Resources.chiudi
        Me.ChiudiToolStripMenuItem.Name = "ChiudiToolStripMenuItem"
        Me.ChiudiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ChiudiToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ChiudiToolStripMenuItem.Text = "Chiudi"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'TABELLEToolStripMenuItem
        '
        Me.TABELLEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TABELLA1ToolStripMenuItem, Me.TABELLA2ToolStripMenuItem, Me.TABELLA3ToolStripMenuItem})
        Me.TABELLEToolStripMenuItem.Name = "TABELLEToolStripMenuItem"
        Me.TABELLEToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.TABELLEToolStripMenuItem.Text = "TABELLE"
        '
        'TABELLA1ToolStripMenuItem
        '
        Me.TABELLA1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FOGLIOAToolStripMenuItem, Me.FOGLIOBToolStripMenuItem})
        Me.TABELLA1ToolStripMenuItem.Name = "TABELLA1ToolStripMenuItem"
        Me.TABELLA1ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TABELLA1ToolStripMenuItem.Text = "TABELLA 1"
        '
        'FOGLIOAToolStripMenuItem
        '
        Me.FOGLIOAToolStripMenuItem.Name = "FOGLIOAToolStripMenuItem"
        Me.FOGLIOAToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FOGLIOAToolStripMenuItem.Text = "FOGLIO A"
        '
        'FOGLIOBToolStripMenuItem
        '
        Me.FOGLIOBToolStripMenuItem.Name = "FOGLIOBToolStripMenuItem"
        Me.FOGLIOBToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FOGLIOBToolStripMenuItem.Text = "FOGLIO B"
        '
        'TABELLA2ToolStripMenuItem
        '
        Me.TABELLA2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FOGLIOAToolStripMenuItem1, Me.FOGLIOBToolStripMenuItem1})
        Me.TABELLA2ToolStripMenuItem.Name = "TABELLA2ToolStripMenuItem"
        Me.TABELLA2ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TABELLA2ToolStripMenuItem.Text = "TABELLA 2"
        '
        'FOGLIOAToolStripMenuItem1
        '
        Me.FOGLIOAToolStripMenuItem1.Name = "FOGLIOAToolStripMenuItem1"
        Me.FOGLIOAToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.FOGLIOAToolStripMenuItem1.Text = "FOGLIO A"
        '
        'FOGLIOBToolStripMenuItem1
        '
        Me.FOGLIOBToolStripMenuItem1.Name = "FOGLIOBToolStripMenuItem1"
        Me.FOGLIOBToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.FOGLIOBToolStripMenuItem1.Text = "FOGLIO B"
        '
        'TABELLA3ToolStripMenuItem
        '
        Me.TABELLA3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FOGLIOAToolStripMenuItem2, Me.FOGLIOBToolStripMenuItem2})
        Me.TABELLA3ToolStripMenuItem.Name = "TABELLA3ToolStripMenuItem"
        Me.TABELLA3ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TABELLA3ToolStripMenuItem.Text = "TABELLA 3"
        '
        'FOGLIOAToolStripMenuItem2
        '
        Me.FOGLIOAToolStripMenuItem2.Name = "FOGLIOAToolStripMenuItem2"
        Me.FOGLIOAToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.FOGLIOAToolStripMenuItem2.Text = "FOGLIO A"
        '
        'FOGLIOBToolStripMenuItem2
        '
        Me.FOGLIOBToolStripMenuItem2.Name = "FOGLIOBToolStripMenuItem2"
        Me.FOGLIOBToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.FOGLIOBToolStripMenuItem2.Text = "FOGLIO B"
        '
        'txt_idlav
        '
        Me.txt_idlav.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_idlav.Location = New System.Drawing.Point(346, 529)
        Me.txt_idlav.Name = "txt_idlav"
        Me.txt_idlav.Size = New System.Drawing.Size(173, 20)
        Me.txt_idlav.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ID LAVORAZIONE"
        '
        'trb_rapido
        '
        Me.trb_rapido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trb_rapido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trb_rapido.Location = New System.Drawing.Point(12, 504)
        Me.trb_rapido.Name = "trb_rapido"
        Me.trb_rapido.Size = New System.Drawing.Size(198, 45)
        Me.trb_rapido.TabIndex = 10
        Me.trb_rapido.Value = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 539)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Velocità del rapido [m/s]"
        '
        'lbl_speed
        '
        Me.lbl_speed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_speed.AutoSize = True
        Me.lbl_speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_speed.Location = New System.Drawing.Point(215, 537)
        Me.lbl_speed.Name = "lbl_speed"
        Me.lbl_speed.Size = New System.Drawing.Size(16, 16)
        Me.lbl_speed.TabIndex = 12
        Me.lbl_speed.Text = "6"
        '
        'chk_norapido
        '
        Me.chk_norapido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_norapido.AutoSize = True
        Me.chk_norapido.Checked = True
        Me.chk_norapido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_norapido.Location = New System.Drawing.Point(222, 504)
        Me.chk_norapido.Name = "chk_norapido"
        Me.chk_norapido.Size = New System.Drawing.Size(15, 14)
        Me.chk_norapido.TabIndex = 13
        Me.chk_norapido.UseVisualStyleBackColor = True
        '
        'btn_surplus
        '
        Me.btn_surplus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_surplus.Location = New System.Drawing.Point(12, 475)
        Me.btn_surplus.Name = "btn_surplus"
        Me.btn_surplus.Size = New System.Drawing.Size(225, 23)
        Me.btn_surplus.TabIndex = 14
        Me.btn_surplus.Text = "Aggiungi come surplus ->"
        Me.btn_surplus.UseVisualStyleBackColor = True
        '
        'txt_ore_surplus
        '
        Me.txt_ore_surplus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ore_surplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ore_surplus.Location = New System.Drawing.Point(601, 477)
        Me.txt_ore_surplus.MaxLength = 2
        Me.txt_ore_surplus.Name = "txt_ore_surplus"
        Me.txt_ore_surplus.Size = New System.Drawing.Size(27, 20)
        Me.txt_ore_surplus.TabIndex = 16
        Me.txt_ore_surplus.Text = "00"
        '
        'txt_minuti_surplus
        '
        Me.txt_minuti_surplus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_minuti_surplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_minuti_surplus.Location = New System.Drawing.Point(664, 477)
        Me.txt_minuti_surplus.MaxLength = 2
        Me.txt_minuti_surplus.Name = "txt_minuti_surplus"
        Me.txt_minuti_surplus.Size = New System.Drawing.Size(27, 20)
        Me.txt_minuti_surplus.TabIndex = 17
        Me.txt_minuti_surplus.Text = "00"
        '
        'txt_commentoSurplus
        '
        Me.txt_commentoSurplus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_commentoSurplus.Location = New System.Drawing.Point(243, 477)
        Me.txt_commentoSurplus.Name = "txt_commentoSurplus"
        Me.txt_commentoSurplus.Size = New System.Drawing.Size(327, 20)
        Me.txt_commentoSurplus.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(576, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "hh"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(635, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "mm"
        '
        'Column10
        '
        Me.Column10.HeaderText = "T l [hh:mm:ss.dcm]"
        Me.Column10.Name = "Column10"
        Me.Column10.ToolTipText = "Tempo della singola lavorazione"
        Me.Column10.Width = 75
        '
        'Column9
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column9.HeaderText = "L p [mm]"
        Me.Column9.Name = "Column9"
        Me.Column9.ToolTipText = "Lunghezza della singola passata"
        Me.Column9.Width = 50
        '
        'Column8
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column8.HeaderText = "N°p [n]"
        Me.Column8.Name = "Column8"
        Me.Column8.ToolTipText = "Numero di passate"
        Me.Column8.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Passata [mm]"
        Me.Column7.Name = "Column7"
        Me.Column7.ToolTipText = "Profondità di passata"
        Me.Column7.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "[z]"
        Me.Column6.Name = "Column6"
        Me.Column6.ToolTipText = "Numero denti"
        Me.Column6.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "[fz]"
        Me.Column5.Name = "Column5"
        Me.Column5.ToolTipText = "Avanzamento singolo dente"
        Me.Column5.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ø [mm]"
        Me.Column1.Name = "Column1"
        Me.Column1.ToolTipText = "Diametro fresa"
        Me.Column1.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "n [giri/min]"
        Me.Column4.Name = "Column4"
        Me.Column4.ToolTipText = "Numero di giri"
        Me.Column4.Width = 50
        '
        'Column3
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Avanzamento [mm/min]"
        Me.Column3.Name = "Column3"
        Me.Column3.ToolTipText = "Velocità di avanzamento"
        Me.Column3.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vt [m/min]"
        Me.Column2.Name = "Column2"
        Me.Column2.ToolTipText = "Velocità di taglio"
        Me.Column2.Width = 50
        '
        'com
        '
        Me.com.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.com.HeaderText = "COMMENTO"
        Me.com.Name = "com"
        '
        'dgw_lav
        '
        Me.dgw_lav.AllowUserToAddRows = False
        Me.dgw_lav.AllowUserToResizeColumns = False
        Me.dgw_lav.AllowUserToResizeRows = False
        Me.dgw_lav.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgw_lav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_lav.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.com, Me.Column2, Me.Column3, Me.Column4, Me.Column1, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgw_lav.Location = New System.Drawing.Point(243, 43)
        Me.dgw_lav.Name = "dgw_lav"
        Me.dgw_lav.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgw_lav.Size = New System.Drawing.Size(529, 426)
        Me.dgw_lav.TabIndex = 3
        '
        'btn_conferma_surplus
        '
        Me.btn_conferma_surplus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_conferma_surplus.Location = New System.Drawing.Point(697, 474)
        Me.btn_conferma_surplus.Name = "btn_conferma_surplus"
        Me.btn_conferma_surplus.Size = New System.Drawing.Size(75, 23)
        Me.btn_conferma_surplus.TabIndex = 22
        Me.btn_conferma_surplus.Text = "aggiungi"
        Me.btn_conferma_surplus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btn_conferma_surplus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_commentoSurplus)
        Me.Controls.Add(Me.txt_minuti_surplus)
        Me.Controls.Add(Me.txt_ore_surplus)
        Me.Controls.Add(Me.btn_surplus)
        Me.Controls.Add(Me.chk_norapido)
        Me.Controls.Add(Me.lbl_speed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.trb_rapido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_idlav)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_tot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgw_lav)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_commento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PREVENTIVO CENTRO DI LAVORO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.trb_rapido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw_lav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_lav As System.Windows.Forms.ComboBox
    Friend WithEvents btn_calc As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_commento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tot As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiudiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TABELLEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TABELLA1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TABELLA2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TABELLA3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOGLIOAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOGLIOBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOGLIOAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOGLIOBToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOGLIOAToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOGLIOBToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_idlav As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents trb_rapido As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_speed As System.Windows.Forms.Label
    Friend WithEvents chk_norapido As System.Windows.Forms.CheckBox
    Friend WithEvents btn_surplus As System.Windows.Forms.Button
    Friend WithEvents txt_ore_surplus As System.Windows.Forms.TextBox
    Friend WithEvents txt_minuti_surplus As System.Windows.Forms.TextBox
    Friend WithEvents txt_commentoSurplus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents com As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgw_lav As System.Windows.Forms.DataGridView
    Friend WithEvents btn_conferma_surplus As System.Windows.Forms.Button

End Class
