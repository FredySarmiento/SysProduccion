<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIETRI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIETRI))
        Me.txtnTotDoc = New System.Windows.Forms.TextBox()
        Me.txtsCodCteCtb = New System.Windows.Forms.TextBox()
        Me.lblsCodTra = New System.Windows.Forms.Label()
        Me.cmdConCteCtb = New System.Windows.Forms.Button()
        Me.lblsCodCteCtb = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.cboAPLND1 = New System.Windows.Forms.ComboBox()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.txtnNroCteCtb = New System.Windows.Forms.TextBox()
        Me.lblFecCtb = New System.Windows.Forms.Label()
        Me.lblTotDoc = New System.Windows.Forms.Label()
        Me.tbc003 = New System.Windows.Forms.TabControl()
        Me.tbp001 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.tbp003 = New System.Windows.Forms.TabPage()
        Me.lblFecDoc = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.dtpFecCtb = New System.Windows.Forms.DateTimePicker()
        Me.txtsCmn = New System.Windows.Forms.TextBox()
        Me.lblCmn = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAPLND1F = New System.Windows.Forms.ComboBox()
        Me.txtnNroDocF = New System.Windows.Forms.TextBox()
        Me.lblnNroDocF = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecCtbF = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboATALM = New System.Windows.Forms.ComboBox()
        Me.cboATALMF = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdLstIETRI = New System.Windows.Forms.Button()
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecDocF = New System.Windows.Forms.DateTimePicker()
        Me.txtsCodTra = New System.Windows.Forms.TextBox()
        Me.txtsCodTraF = New System.Windows.Forms.TextBox()
        Me.tbc003.SuspendLayout()
        Me.tbp001.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp003.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnTotDoc
        '
        Me.txtnTotDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTotDoc.Enabled = False
        Me.txtnTotDoc.Location = New System.Drawing.Point(704, 423)
        Me.txtnTotDoc.MaxLength = 200
        Me.txtnTotDoc.Multiline = True
        Me.txtnTotDoc.Name = "txtnTotDoc"
        Me.txtnTotDoc.Size = New System.Drawing.Size(115, 22)
        Me.txtnTotDoc.TabIndex = 48
        Me.txtnTotDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsCodCteCtb
        '
        Me.txtsCodCteCtb.Location = New System.Drawing.Point(144, 41)
        Me.txtsCodCteCtb.MaxLength = 10
        Me.txtsCodCteCtb.Name = "txtsCodCteCtb"
        Me.txtsCodCteCtb.Size = New System.Drawing.Size(71, 20)
        Me.txtsCodCteCtb.TabIndex = 42
        '
        'lblsCodTra
        '
        Me.lblsCodTra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsCodTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblsCodTra.Location = New System.Drawing.Point(5, 53)
        Me.lblsCodTra.Name = "lblsCodTra"
        Me.lblsCodTra.Size = New System.Drawing.Size(139, 13)
        Me.lblsCodTra.TabIndex = 571
        Me.lblsCodTra.Text = "Transacción:"
        '
        'cmdConCteCtb
        '
        Me.cmdConCteCtb.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdConCteCtb.Location = New System.Drawing.Point(96, 45)
        Me.cmdConCteCtb.Name = "cmdConCteCtb"
        Me.cmdConCteCtb.Size = New System.Drawing.Size(38, 14)
        Me.cmdConCteCtb.TabIndex = 40
        Me.cmdConCteCtb.Text = "..."
        Me.cmdConCteCtb.UseVisualStyleBackColor = False
        Me.cmdConCteCtb.Visible = False
        '
        'lblsCodCteCtb
        '
        Me.lblsCodCteCtb.AutoSize = True
        Me.lblsCodCteCtb.Location = New System.Drawing.Point(4, 44)
        Me.lblsCodCteCtb.Name = "lblsCodCteCtb"
        Me.lblsCodCteCtb.Size = New System.Drawing.Size(86, 13)
        Me.lblsCodCteCtb.TabIndex = 238
        Me.lblsCodCteCtb.Text = "Asiento contable"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(4, 47)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 240
        Me.lblLin04.Text = "___________________________"
        '
        'cboAPLND1
        '
        Me.cboAPLND1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAPLND1.FormattingEnabled = True
        Me.cboAPLND1.Location = New System.Drawing.Point(110, 24)
        Me.cboAPLND1.Name = "cboAPLND1"
        Me.cboAPLND1.Size = New System.Drawing.Size(57, 21)
        Me.cboAPLND1.TabIndex = 2
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnNroDoc.Location = New System.Drawing.Point(195, 25)
        Me.txtnNroDoc.MaxLength = 12
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(82, 20)
        Me.txtnNroDoc.TabIndex = 4
        Me.txtnNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnNroDoc.Location = New System.Drawing.Point(5, 30)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDoc.TabIndex = 557
        Me.lblnNroDoc.Text = "Número:"
        '
        'txtnNroCteCtb
        '
        Me.txtnNroCteCtb.Location = New System.Drawing.Point(221, 41)
        Me.txtnNroCteCtb.MaxLength = 20
        Me.txtnNroCteCtb.Name = "txtnNroCteCtb"
        Me.txtnNroCteCtb.Size = New System.Drawing.Size(112, 20)
        Me.txtnNroCteCtb.TabIndex = 44
        '
        'lblFecCtb
        '
        Me.lblFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecCtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecCtb.Location = New System.Drawing.Point(5, 103)
        Me.lblFecCtb.Name = "lblFecCtb"
        Me.lblFecCtb.Size = New System.Drawing.Size(139, 13)
        Me.lblFecCtb.TabIndex = 559
        Me.lblFecCtb.Text = "Fecha de contabilización:"
        '
        'lblTotDoc
        '
        Me.lblTotDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotDoc.AutoSize = True
        Me.lblTotDoc.Location = New System.Drawing.Point(552, 431)
        Me.lblTotDoc.Name = "lblTotDoc"
        Me.lblTotDoc.Size = New System.Drawing.Size(87, 13)
        Me.lblTotDoc.TabIndex = 569
        Me.lblTotDoc.Text = "Total documento"
        '
        'tbc003
        '
        Me.tbc003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbc003.Controls.Add(Me.tbp001)
        Me.tbc003.Controls.Add(Me.tbp003)
        Me.tbc003.Location = New System.Drawing.Point(7, 158)
        Me.tbc003.Name = "tbc003"
        Me.tbc003.SelectedIndex = 0
        Me.tbc003.Size = New System.Drawing.Size(809, 250)
        Me.tbc003.TabIndex = 26
        '
        'tbp001
        '
        Me.tbp001.BackColor = System.Drawing.Color.AliceBlue
        Me.tbp001.Controls.Add(Me.SplitContainer1)
        Me.tbp001.Location = New System.Drawing.Point(4, 22)
        Me.tbp001.Name = "tbp001"
        Me.tbp001.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp001.Size = New System.Drawing.Size(801, 224)
        Me.tbp001.TabIndex = 0
        Me.tbp001.Text = "Detalle"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv1)
        Me.SplitContainer1.Size = New System.Drawing.Size(795, 218)
        Me.SplitContainer1.SplitterDistance = 35
        Me.SplitContainer1.TabIndex = 233
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(0, 0)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(795, 179)
        Me.dgv1.TabIndex = 226
        '
        'tbp003
        '
        Me.tbp003.BackColor = System.Drawing.Color.AliceBlue
        Me.tbp003.Controls.Add(Me.txtnNroCteCtb)
        Me.tbp003.Controls.Add(Me.txtsCodCteCtb)
        Me.tbp003.Controls.Add(Me.cmdConCteCtb)
        Me.tbp003.Controls.Add(Me.lblsCodCteCtb)
        Me.tbp003.Controls.Add(Me.lblLin04)
        Me.tbp003.Location = New System.Drawing.Point(4, 22)
        Me.tbp003.Name = "tbp003"
        Me.tbp003.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp003.Size = New System.Drawing.Size(801, 224)
        Me.tbp003.TabIndex = 2
        Me.tbp003.Text = "Finanzas"
        '
        'lblFecDoc
        '
        Me.lblFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecDoc.Location = New System.Drawing.Point(5, 128)
        Me.lblFecDoc.Name = "lblFecDoc"
        Me.lblFecDoc.Size = New System.Drawing.Size(105, 15)
        Me.lblFecDoc.TabIndex = 560
        Me.lblFecDoc.Text = "Fecha documento"
        '
        'lblLin11
        '
        Me.lblLin11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin11.AutoSize = True
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(5, 32)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(235, 13)
        Me.lblLin11.TabIndex = 562
        Me.lblLin11.Text = "______________________________________"
        '
        'dtpFecCtb
        '
        Me.dtpFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecCtb.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtb.Location = New System.Drawing.Point(177, 99)
        Me.dtpFecCtb.Name = "dtpFecCtb"
        Me.dtpFecCtb.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecCtb.TabIndex = 556
        Me.dtpFecCtb.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'txtsCmn
        '
        Me.txtsCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsCmn.Location = New System.Drawing.Point(77, 425)
        Me.txtsCmn.MaxLength = 200
        Me.txtsCmn.Multiline = True
        Me.txtsCmn.Name = "txtsCmn"
        Me.txtsCmn.Size = New System.Drawing.Size(327, 36)
        Me.txtsCmn.TabIndex = 46
        '
        'lblCmn
        '
        Me.lblCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCmn.AutoSize = True
        Me.lblCmn.Location = New System.Drawing.Point(4, 425)
        Me.lblCmn.Name = "lblCmn"
        Me.lblCmn.Size = New System.Drawing.Size(65, 13)
        Me.lblCmn.TabIndex = 567
        Me.lblCmn.Text = "Comentarios"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(7, 477)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 50
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(7, 477)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 52
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(7, 477)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 58
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(7, 477)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 56
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(89, 477)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 60
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(7, 477)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 54
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(4, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 568
        Me.Label1.Text = "_____________"
        Me.Label1.Visible = False
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(5, 104)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(247, 13)
        Me.lblLin02.TabIndex = 558
        Me.lblLin02.Text = "________________________________________"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 13)
        Me.Label3.TabIndex = 572
        Me.Label3.Text = "______________________________________"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(552, 432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 13)
        Me.Label4.TabIndex = 573
        Me.Label4.Text = "_____________________________________"
        '
        'lblLin07
        '
        Me.lblLin07.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(5, 131)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(229, 13)
        Me.lblLin07.TabIndex = 561
        Me.lblLin07.Text = "_____________________________________"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(4, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 13)
        Me.Label5.TabIndex = 574
        Me.Label5.Text = "_____________________________________"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(552, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 587
        Me.Label2.Text = "Transacción:"
        '
        'cboAPLND1F
        '
        Me.cboAPLND1F.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAPLND1F.FormattingEnabled = True
        Me.cboAPLND1F.Location = New System.Drawing.Point(654, 24)
        Me.cboAPLND1F.Name = "cboAPLND1F"
        Me.cboAPLND1F.Size = New System.Drawing.Size(57, 21)
        Me.cboAPLND1F.TabIndex = 14
        '
        'txtnNroDocF
        '
        Me.txtnNroDocF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnNroDocF.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDocF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnNroDocF.Location = New System.Drawing.Point(738, 25)
        Me.txtnNroDocF.MaxLength = 12
        Me.txtnNroDocF.Name = "txtnNroDocF"
        Me.txtnNroDocF.Size = New System.Drawing.Size(82, 20)
        Me.txtnNroDocF.TabIndex = 16
        Me.txtnNroDocF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnNroDocF
        '
        Me.lblnNroDocF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnNroDocF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnNroDocF.Location = New System.Drawing.Point(552, 30)
        Me.lblnNroDocF.Name = "lblnNroDocF"
        Me.lblnNroDocF.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDocF.TabIndex = 581
        Me.lblnNroDocF.Text = "Número:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label7.Location = New System.Drawing.Point(552, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 583
        Me.Label7.Text = "Fecha de contabilización:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label8.Location = New System.Drawing.Point(552, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 15)
        Me.Label8.TabIndex = 584
        Me.Label8.Text = "Fecha documento"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(556, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(235, 13)
        Me.Label9.TabIndex = 586
        Me.Label9.Text = "______________________________________"
        '
        'dtpFecCtbF
        '
        Me.dtpFecCtbF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecCtbF.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtbF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtbF.Location = New System.Drawing.Point(719, 98)
        Me.dtpFecCtbF.Name = "dtpFecCtbF"
        Me.dtpFecCtbF.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecCtbF.TabIndex = 580
        Me.dtpFecCtbF.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(552, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 13)
        Me.Label10.TabIndex = 582
        Me.Label10.Text = "________________________________________"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(559, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 13)
        Me.Label11.TabIndex = 588
        Me.Label11.Text = "______________________________________"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(552, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(229, 13)
        Me.Label12.TabIndex = 585
        Me.Label12.Text = "_____________________________________"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 14)
        Me.Label13.TabIndex = 589
        Me.Label13.Text = "Origen:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(552, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 14)
        Me.Label14.TabIndex = 590
        Me.Label14.Text = "Destino:"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label15.Location = New System.Drawing.Point(5, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 13)
        Me.Label15.TabIndex = 591
        Me.Label15.Text = "Almacén"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label16.Location = New System.Drawing.Point(552, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 13)
        Me.Label16.TabIndex = 592
        Me.Label16.Text = "Almacén"
        '
        'cboATALM
        '
        Me.cboATALM.FormattingEnabled = True
        Me.cboATALM.Location = New System.Drawing.Point(110, 73)
        Me.cboATALM.Name = "cboATALM"
        Me.cboATALM.Size = New System.Drawing.Size(166, 21)
        Me.cboATALM.TabIndex = 8
        '
        'cboATALMF
        '
        Me.cboATALMF.FormattingEnabled = True
        Me.cboATALMF.Location = New System.Drawing.Point(654, 73)
        Me.cboATALMF.Name = "cboATALMF"
        Me.cboATALMF.Size = New System.Drawing.Size(166, 21)
        Me.cboATALMF.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(5, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 13)
        Me.Label6.TabIndex = 593
        Me.Label6.Text = "______________________________________"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.LightGray
        Me.Label17.Location = New System.Drawing.Point(552, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(235, 13)
        Me.Label17.TabIndex = 594
        Me.Label17.Text = "______________________________________"
        '
        'cmdLstIETRI
        '
        Me.cmdLstIETRI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstIETRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdLstIETRI.Location = New System.Drawing.Point(298, 27)
        Me.cmdLstIETRI.Name = "cmdLstIETRI"
        Me.cmdLstIETRI.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstIETRI.TabIndex = 595
        Me.cmdLstIETRI.Text = "Lst"
        Me.cmdLstIETRI.UseVisualStyleBackColor = False
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecDoc.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(177, 125)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecDoc.TabIndex = 596
        Me.dtpFecDoc.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'dtpFecDocF
        '
        Me.dtpFecDocF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecDocF.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecDocF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocF.Location = New System.Drawing.Point(719, 122)
        Me.dtpFecDocF.Name = "dtpFecDocF"
        Me.dtpFecDocF.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecDocF.TabIndex = 597
        Me.dtpFecDocF.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'txtsCodTra
        '
        Me.txtsCodTra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsCodTra.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodTra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsCodTra.Location = New System.Drawing.Point(110, 49)
        Me.txtsCodTra.MaxLength = 12
        Me.txtsCodTra.Name = "txtsCodTra"
        Me.txtsCodTra.Size = New System.Drawing.Size(57, 20)
        Me.txtsCodTra.TabIndex = 598
        '
        'txtsCodTraF
        '
        Me.txtsCodTraF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsCodTraF.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodTraF.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsCodTraF.Location = New System.Drawing.Point(654, 49)
        Me.txtsCodTraF.MaxLength = 12
        Me.txtsCodTraF.Name = "txtsCodTraF"
        Me.txtsCodTraF.Size = New System.Drawing.Size(57, 20)
        Me.txtsCodTraF.TabIndex = 599
        Me.txtsCodTraF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmIETRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(824, 502)
        Me.Controls.Add(Me.txtsCodTraF)
        Me.Controls.Add(Me.txtsCodTra)
        Me.Controls.Add(Me.dtpFecDocF)
        Me.Controls.Add(Me.dtpFecDoc)
        Me.Controls.Add(Me.cmdLstIETRI)
        Me.Controls.Add(Me.cboATALMF)
        Me.Controls.Add(Me.cboATALM)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAPLND1F)
        Me.Controls.Add(Me.txtnNroDocF)
        Me.Controls.Add(Me.lblnNroDocF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFecCtbF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtnTotDoc)
        Me.Controls.Add(Me.lblsCodTra)
        Me.Controls.Add(Me.cboAPLND1)
        Me.Controls.Add(Me.txtnNroDoc)
        Me.Controls.Add(Me.lblnNroDoc)
        Me.Controls.Add(Me.lblFecCtb)
        Me.Controls.Add(Me.lblTotDoc)
        Me.Controls.Add(Me.tbc003)
        Me.Controls.Add(Me.lblFecDoc)
        Me.Controls.Add(Me.lblLin11)
        Me.Controls.Add(Me.dtpFecCtb)
        Me.Controls.Add(Me.txtsCmn)
        Me.Controls.Add(Me.lblCmn)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLin02)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLin07)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label17)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIETRI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de inventarios"
        Me.tbc003.ResumeLayout(False)
        Me.tbp001.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp003.ResumeLayout(False)
        Me.tbp003.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnTotDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodCteCtb As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodTra As System.Windows.Forms.Label
    Friend WithEvents cmdConCteCtb As System.Windows.Forms.Button
    Friend WithEvents lblsCodCteCtb As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents cboAPLND1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents txtnNroCteCtb As System.Windows.Forms.TextBox
    Friend WithEvents lblFecCtb As System.Windows.Forms.Label
    Friend WithEvents lblTotDoc As System.Windows.Forms.Label
    Friend WithEvents tbc003 As System.Windows.Forms.TabControl
    Friend WithEvents tbp001 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbp003 As System.Windows.Forms.TabPage
    Friend WithEvents lblFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCtb As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsCmn As System.Windows.Forms.TextBox
    Friend WithEvents lblCmn As System.Windows.Forms.Label
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAPLND1F As System.Windows.Forms.ComboBox
    Friend WithEvents txtnNroDocF As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDocF As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCtbF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboATALM As System.Windows.Forms.ComboBox
    Friend WithEvents cboATALMF As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdLstIETRI As System.Windows.Forms.Button
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecDocF As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsCodTra As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodTraF As System.Windows.Forms.TextBox
End Class
