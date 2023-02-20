<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIEREV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIEREV))
        Me.cmdLstIEREV = New System.Windows.Forms.Button()
        Me.cboATTIN = New System.Windows.Forms.ComboBox()
        Me.lblsCodTra = New System.Windows.Forms.Label()
        Me.cboAPLND1 = New System.Windows.Forms.ComboBox()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.lblFecCtb = New System.Windows.Forms.Label()
        Me.lblFecDoc = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.dtpFecCtb = New System.Windows.Forms.DateTimePicker()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.txtnTotDoc = New System.Windows.Forms.TextBox()
        Me.lblTotDoc = New System.Windows.Forms.Label()
        Me.tbc003 = New System.Windows.Forms.TabControl()
        Me.tbp001 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.tbp003 = New System.Windows.Forms.TabPage()
        Me.txtnNroCteCtb = New System.Windows.Forms.TextBox()
        Me.txtsCodCteCtb = New System.Windows.Forms.TextBox()
        Me.cmdConCteCtb = New System.Windows.Forms.Button()
        Me.lblsCodCteCtb = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.txtsCmn = New System.Windows.Forms.TextBox()
        Me.lblCmn = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.txtsDocRef = New System.Windows.Forms.TextBox()
        Me.lblDocRef = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblsTipRev = New System.Windows.Forms.Label()
        Me.cboABTIR = New System.Windows.Forms.ComboBox()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.tbc003.SuspendLayout
        Me.tbp001.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.dgv1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tbp003.SuspendLayout
        Me.SuspendLayout
        '
        'cmdLstIEREV
        '
        Me.cmdLstIEREV.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstIEREV.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!)
        Me.cmdLstIEREV.Location = New System.Drawing.Point(307, 6)
        Me.cmdLstIEREV.Name = "cmdLstIEREV"
        Me.cmdLstIEREV.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstIEREV.TabIndex = 6
        Me.cmdLstIEREV.Text = "Lst"
        Me.cmdLstIEREV.UseVisualStyleBackColor = false
        '
        'cboATTIN
        '
        Me.cboATTIN.FormattingEnabled = true
        Me.cboATTIN.Location = New System.Drawing.Point(140, 28)
        Me.cboATTIN.Name = "cboATTIN"
        Me.cboATTIN.Size = New System.Drawing.Size(158, 21)
        Me.cboATTIN.TabIndex = 8
        '
        'lblsCodTra
        '
        Me.lblsCodTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.lblsCodTra.Location = New System.Drawing.Point(5, 35)
        Me.lblsCodTra.Name = "lblsCodTra"
        Me.lblsCodTra.Size = New System.Drawing.Size(139, 13)
        Me.lblsCodTra.TabIndex = 615
        Me.lblsCodTra.Text = "Transacción:"
        '
        'cboAPLND1
        '
        Me.cboAPLND1.FormattingEnabled = true
        Me.cboAPLND1.Location = New System.Drawing.Point(140, 4)
        Me.cboAPLND1.Name = "cboAPLND1"
        Me.cboAPLND1.Size = New System.Drawing.Size(57, 21)
        Me.cboAPLND1.TabIndex = 2
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnNroDoc.Location = New System.Drawing.Point(217, 5)
        Me.txtnNroDoc.MaxLength = 12
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(82, 20)
        Me.txtnNroDoc.TabIndex = 4
        Me.txtnNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblnNroDoc.Location = New System.Drawing.Point(5, 10)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDoc.TabIndex = 609
        Me.lblnNroDoc.Text = "Número:"
        '
        'lblFecCtb
        '
        Me.lblFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblFecCtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.lblFecCtb.Location = New System.Drawing.Point(450, 10)
        Me.lblFecCtb.Name = "lblFecCtb"
        Me.lblFecCtb.Size = New System.Drawing.Size(139, 13)
        Me.lblFecCtb.TabIndex = 611
        Me.lblFecCtb.Text = "Fecha de contabilización:"
        '
        'lblFecDoc
        '
        Me.lblFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.lblFecDoc.Location = New System.Drawing.Point(450, 35)
        Me.lblFecDoc.Name = "lblFecDoc"
        Me.lblFecDoc.Size = New System.Drawing.Size(105, 15)
        Me.lblFecDoc.TabIndex = 612
        Me.lblFecDoc.Text = "Fecha documento"
        '
        'lblLin11
        '
        Me.lblLin11.AutoSize = true
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(5, 12)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(235, 13)
        Me.lblLin11.TabIndex = 614
        Me.lblLin11.Text = "______________________________________"
        '
        'dtpFecCtb
        '
        Me.dtpFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtpFecCtb.Checked = false
        Me.dtpFecCtb.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtb.Location = New System.Drawing.Point(615, 4)
        Me.dtpFecCtb.Name = "dtpFecCtb"
        Me.dtpFecCtb.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecCtb.TabIndex = 12
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = true
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(450, 11)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(247, 13)
        Me.lblLin02.TabIndex = 610
        Me.lblLin02.Text = "________________________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(5, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 13)
        Me.Label5.TabIndex = 616
        Me.Label5.Text = "______________________________________"
        '
        'lblLin07
        '
        Me.lblLin07.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblLin07.AutoSize = true
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(450, 38)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(229, 13)
        Me.lblLin07.TabIndex = 613
        Me.lblLin07.Text = "_____________________________________"
        '
        'txtnTotDoc
        '
        Me.txtnTotDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtnTotDoc.Enabled = false
        Me.txtnTotDoc.Location = New System.Drawing.Point(615, 331)
        Me.txtnTotDoc.MaxLength = 200
        Me.txtnTotDoc.Multiline = true
        Me.txtnTotDoc.Name = "txtnTotDoc"
        Me.txtnTotDoc.Size = New System.Drawing.Size(104, 22)
        Me.txtnTotDoc.TabIndex = 642
        Me.txtnTotDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotDoc
        '
        Me.lblTotDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblTotDoc.AutoSize = true
        Me.lblTotDoc.Location = New System.Drawing.Point(450, 339)
        Me.lblTotDoc.Name = "lblTotDoc"
        Me.lblTotDoc.Size = New System.Drawing.Size(87, 13)
        Me.lblTotDoc.TabIndex = 651
        Me.lblTotDoc.Text = "Total documento"
        '
        'tbc003
        '
        Me.tbc003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbc003.Controls.Add(Me.tbp001)
        Me.tbc003.Controls.Add(Me.tbp003)
        Me.tbc003.Location = New System.Drawing.Point(6, 95)
        Me.tbc003.Name = "tbc003"
        Me.tbc003.SelectedIndex = 0
        Me.tbc003.Size = New System.Drawing.Size(718, 220)
        Me.tbc003.TabIndex = 18
        '
        'tbp001
        '
        Me.tbp001.BackColor = System.Drawing.Color.AliceBlue
        Me.tbp001.Controls.Add(Me.SplitContainer1)
        Me.tbp001.Location = New System.Drawing.Point(4, 22)
        Me.tbp001.Name = "tbp001"
        Me.tbp001.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp001.Size = New System.Drawing.Size(710, 194)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(704, 188)
        Me.SplitContainer1.SplitterDistance = 26
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
        Me.dgv1.Size = New System.Drawing.Size(704, 158)
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
        Me.tbp003.Size = New System.Drawing.Size(710, 194)
        Me.tbp003.TabIndex = 2
        Me.tbp003.Text = "Finanzas"
        '
        'txtnNroCteCtb
        '
        Me.txtnNroCteCtb.Location = New System.Drawing.Point(221, 41)
        Me.txtnNroCteCtb.MaxLength = 20
        Me.txtnNroCteCtb.Name = "txtnNroCteCtb"
        Me.txtnNroCteCtb.Size = New System.Drawing.Size(112, 20)
        Me.txtnNroCteCtb.TabIndex = 24
        '
        'txtsCodCteCtb
        '
        Me.txtsCodCteCtb.Location = New System.Drawing.Point(144, 41)
        Me.txtsCodCteCtb.MaxLength = 10
        Me.txtsCodCteCtb.Name = "txtsCodCteCtb"
        Me.txtsCodCteCtb.Size = New System.Drawing.Size(71, 20)
        Me.txtsCodCteCtb.TabIndex = 22
        '
        'cmdConCteCtb
        '
        Me.cmdConCteCtb.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdConCteCtb.Location = New System.Drawing.Point(96, 45)
        Me.cmdConCteCtb.Name = "cmdConCteCtb"
        Me.cmdConCteCtb.Size = New System.Drawing.Size(38, 14)
        Me.cmdConCteCtb.TabIndex = 20
        Me.cmdConCteCtb.Text = "..."
        Me.cmdConCteCtb.UseVisualStyleBackColor = false
        Me.cmdConCteCtb.Visible = false
        '
        'lblsCodCteCtb
        '
        Me.lblsCodCteCtb.AutoSize = true
        Me.lblsCodCteCtb.Location = New System.Drawing.Point(4, 44)
        Me.lblsCodCteCtb.Name = "lblsCodCteCtb"
        Me.lblsCodCteCtb.Size = New System.Drawing.Size(86, 13)
        Me.lblsCodCteCtb.TabIndex = 238
        Me.lblsCodCteCtb.Text = "Asiento contable"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = true
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(4, 47)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 240
        Me.lblLin04.Text = "___________________________"
        '
        'txtsCmn
        '
        Me.txtsCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.txtsCmn.Location = New System.Drawing.Point(87, 330)
        Me.txtsCmn.MaxLength = 200
        Me.txtsCmn.Multiline = true
        Me.txtsCmn.Name = "txtsCmn"
        Me.txtsCmn.Size = New System.Drawing.Size(327, 36)
        Me.txtsCmn.TabIndex = 26
        '
        'lblCmn
        '
        Me.lblCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblCmn.AutoSize = true
        Me.lblCmn.Location = New System.Drawing.Point(10, 328)
        Me.lblCmn.Name = "lblCmn"
        Me.lblCmn.Size = New System.Drawing.Size(65, 13)
        Me.lblCmn.TabIndex = 649
        Me.lblCmn.Text = "Comentarios"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 388)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 28
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = false
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 387)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 30
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = false
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 387)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 30
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = false
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.cmdBuscar.Location = New System.Drawing.Point(6, 387)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 30
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = false
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 388)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 32
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = false
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.cmdActualizar.Location = New System.Drawing.Point(5, 387)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 645
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = false
        Me.cmdActualizar.Visible = false
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = true
        Me.Label24.ForeColor = System.Drawing.Color.LightGray
        Me.Label24.Location = New System.Drawing.Point(-91, 574)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 13)
        Me.Label24.TabIndex = 650
        Me.Label24.Text = "_____________"
        Me.Label24.Visible = false
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = true
        Me.Label25.ForeColor = System.Drawing.Color.LightGray
        Me.Label25.Location = New System.Drawing.Point(450, 340)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(229, 13)
        Me.Label25.TabIndex = 652
        Me.Label25.Text = "_____________________________________"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = true
        Me.Label26.ForeColor = System.Drawing.Color.LightGray
        Me.Label26.Location = New System.Drawing.Point(-91, 516)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(229, 13)
        Me.Label26.TabIndex = 653
        Me.Label26.Text = "_____________________________________"
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtpFecDoc.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(615, 31)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecDoc.TabIndex = 14
        '
        'txtsDocRef
        '
        Me.txtsDocRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtsDocRef.BackColor = System.Drawing.SystemColors.Window
        Me.txtsDocRef.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsDocRef.Location = New System.Drawing.Point(615, 56)
        Me.txtsDocRef.MaxLength = 20
        Me.txtsDocRef.Name = "txtsDocRef"
        Me.txtsDocRef.Size = New System.Drawing.Size(109, 20)
        Me.txtsDocRef.TabIndex = 16
        Me.txtsDocRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDocRef
        '
        Me.lblDocRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblDocRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.lblDocRef.Location = New System.Drawing.Point(450, 60)
        Me.lblDocRef.Name = "lblDocRef"
        Me.lblDocRef.Size = New System.Drawing.Size(105, 15)
        Me.lblDocRef.TabIndex = 657
        Me.lblDocRef.Text = "Referencia :"
        '
        'lblLin03
        '
        Me.lblLin03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblLin03.AutoSize = true
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(450, 63)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(229, 13)
        Me.lblLin03.TabIndex = 658
        Me.lblLin03.Text = "_____________________________________"
        '
        'lblsTipRev
        '
        Me.lblsTipRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.lblsTipRev.Location = New System.Drawing.Point(5, 60)
        Me.lblsTipRev.Name = "lblsTipRev"
        Me.lblsTipRev.Size = New System.Drawing.Size(139, 13)
        Me.lblsTipRev.TabIndex = 659
        Me.lblsTipRev.Text = "Tipo de revalorización"
        '
        'cboABTIR
        '
        Me.cboABTIR.FormattingEnabled = true
        Me.cboABTIR.Location = New System.Drawing.Point(140, 53)
        Me.cboABTIR.Name = "cboABTIR"
        Me.cboABTIR.Size = New System.Drawing.Size(158, 21)
        Me.cboABTIR.TabIndex = 10
        '
        'lblLin05
        '
        Me.lblLin05.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblLin05.AutoSize = true
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(5, 61)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(229, 13)
        Me.lblLin05.TabIndex = 661
        Me.lblLin05.Text = "_____________________________________"
        '
        'frmIEREV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(734, 412)
        Me.Controls.Add(Me.dtpFecCtb)
        Me.Controls.Add(Me.cboABTIR)
        Me.Controls.Add(Me.lblDocRef)
        Me.Controls.Add(Me.txtsDocRef)
        Me.Controls.Add(Me.dtpFecDoc)
        Me.Controls.Add(Me.txtnTotDoc)
        Me.Controls.Add(Me.lblTotDoc)
        Me.Controls.Add(Me.txtsCmn)
        Me.Controls.Add(Me.lblCmn)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmdLstIEREV)
        Me.Controls.Add(Me.cboATTIN)
        Me.Controls.Add(Me.lblsCodTra)
        Me.Controls.Add(Me.cboAPLND1)
        Me.Controls.Add(Me.txtnNroDoc)
        Me.Controls.Add(Me.lblnNroDoc)
        Me.Controls.Add(Me.lblFecCtb)
        Me.Controls.Add(Me.lblFecDoc)
        Me.Controls.Add(Me.lblLin11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLin07)
        Me.Controls.Add(Me.tbc003)
        Me.Controls.Add(Me.lblLin03)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblsTipRev)
        Me.Controls.Add(Me.lblLin05)
        Me.Controls.Add(Me.lblLin02)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmIEREV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revalorización del inventario"
        Me.tbc003.ResumeLayout(false)
        Me.tbp001.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        CType(Me.dgv1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbp003.ResumeLayout(false)
        Me.tbp003.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmdLstIEREV As System.Windows.Forms.Button
    Friend WithEvents cboATTIN As System.Windows.Forms.ComboBox
    Friend WithEvents lblsCodTra As System.Windows.Forms.Label
    Friend WithEvents cboAPLND1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents lblFecCtb As System.Windows.Forms.Label
    Friend WithEvents lblFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCtb As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents txtnTotDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblTotDoc As System.Windows.Forms.Label
    Friend WithEvents tbc003 As System.Windows.Forms.TabControl
    Friend WithEvents tbp001 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbp003 As System.Windows.Forms.TabPage
    Friend WithEvents txtnNroCteCtb As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodCteCtb As System.Windows.Forms.TextBox
    Friend WithEvents cmdConCteCtb As System.Windows.Forms.Button
    Friend WithEvents lblsCodCteCtb As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents txtsCmn As System.Windows.Forms.TextBox
    Friend WithEvents lblCmn As System.Windows.Forms.Label
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsDocRef As System.Windows.Forms.TextBox
    Friend WithEvents lblDocRef As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents lblsTipRev As System.Windows.Forms.Label
    Friend WithEvents cboABTIR As System.Windows.Forms.ComboBox
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
End Class
