<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEEDM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEEDM))
        Me.lblFecDoc = New System.Windows.Forms.Label()
        Me.cboAPLND1 = New System.Windows.Forms.ComboBox()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
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
        Me.txtnTotDoc = New System.Windows.Forms.TextBox()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.lblTotDoc = New System.Windows.Forms.Label()
        Me.lblLin020 = New System.Windows.Forms.Label()
        Me.txtsCmn = New System.Windows.Forms.TextBox()
        Me.lblCmn = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPEODP = New System.Windows.Forms.Button()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.lblFecCtb = New System.Windows.Forms.Label()
        Me.dtpFecCtb = New System.Windows.Forms.DateTimePicker()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.cmdLstPEEDM = New System.Windows.Forms.Button()
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.tbc003.SuspendLayout()
        Me.tbp001.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp003.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecDoc
        '
        Me.lblFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecDoc.Location = New System.Drawing.Point(535, 57)
        Me.lblFecDoc.Name = "lblFecDoc"
        Me.lblFecDoc.Size = New System.Drawing.Size(105, 15)
        Me.lblFecDoc.TabIndex = 585
        Me.lblFecDoc.Text = "Fecha documento"
        '
        'cboAPLND1
        '
        Me.cboAPLND1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAPLND1.FormattingEnabled = True
        Me.cboAPLND1.Location = New System.Drawing.Point(629, 4)
        Me.cboAPLND1.Name = "cboAPLND1"
        Me.cboAPLND1.Size = New System.Drawing.Size(57, 21)
        Me.cboAPLND1.TabIndex = 569
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnNroDoc.Location = New System.Drawing.Point(699, 4)
        Me.txtnNroDoc.MaxLength = 12
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(82, 20)
        Me.txtnNroDoc.TabIndex = 570
        Me.txtnNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbc003
        '
        Me.tbc003.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbc003.Controls.Add(Me.tbp001)
        Me.tbc003.Controls.Add(Me.tbp003)
        Me.tbc003.Location = New System.Drawing.Point(6, 80)
        Me.tbc003.Name = "tbc003"
        Me.tbc003.SelectedIndex = 0
        Me.tbc003.Size = New System.Drawing.Size(812, 323)
        Me.tbc003.TabIndex = 573
        '
        'tbp001
        '
        Me.tbp001.BackColor = System.Drawing.Color.AliceBlue
        Me.tbp001.Controls.Add(Me.SplitContainer1)
        Me.tbp001.Location = New System.Drawing.Point(4, 22)
        Me.tbp001.Name = "tbp001"
        Me.tbp001.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp001.Size = New System.Drawing.Size(804, 297)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(798, 291)
        Me.SplitContainer1.SplitterDistance = 40
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
        Me.dgv1.Size = New System.Drawing.Size(798, 247)
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
        Me.tbp003.Size = New System.Drawing.Size(804, 297)
        Me.tbp003.TabIndex = 2
        Me.tbp003.Text = "Finanzas"
        '
        'txtnNroCteCtb
        '
        Me.txtnNroCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnNroCteCtb.Location = New System.Drawing.Point(228, 44)
        Me.txtnNroCteCtb.MaxLength = 20
        Me.txtnNroCteCtb.Name = "txtnNroCteCtb"
        Me.txtnNroCteCtb.Size = New System.Drawing.Size(112, 20)
        Me.txtnNroCteCtb.TabIndex = 237
        '
        'txtsCodCteCtb
        '
        Me.txtsCodCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsCodCteCtb.Location = New System.Drawing.Point(151, 44)
        Me.txtsCodCteCtb.MaxLength = 10
        Me.txtsCodCteCtb.Name = "txtsCodCteCtb"
        Me.txtsCodCteCtb.Size = New System.Drawing.Size(71, 20)
        Me.txtsCodCteCtb.TabIndex = 236
        '
        'cmdConCteCtb
        '
        Me.cmdConCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdConCteCtb.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdConCteCtb.Location = New System.Drawing.Point(103, 51)
        Me.cmdConCteCtb.Name = "cmdConCteCtb"
        Me.cmdConCteCtb.Size = New System.Drawing.Size(38, 14)
        Me.cmdConCteCtb.TabIndex = 239
        Me.cmdConCteCtb.Text = "..."
        Me.cmdConCteCtb.UseVisualStyleBackColor = False
        Me.cmdConCteCtb.Visible = False
        '
        'lblsCodCteCtb
        '
        Me.lblsCodCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblsCodCteCtb.AutoSize = True
        Me.lblsCodCteCtb.Location = New System.Drawing.Point(11, 50)
        Me.lblsCodCteCtb.Name = "lblsCodCteCtb"
        Me.lblsCodCteCtb.Size = New System.Drawing.Size(86, 13)
        Me.lblsCodCteCtb.TabIndex = 238
        Me.lblsCodCteCtb.Text = "Asiento contable"
        '
        'lblLin04
        '
        Me.lblLin04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(14, 12)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 240
        Me.lblLin04.Text = "___________________________"
        '
        'txtnTotDoc
        '
        Me.txtnTotDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTotDoc.Location = New System.Drawing.Point(717, 412)
        Me.txtnTotDoc.MaxLength = 15
        Me.txtnTotDoc.Name = "txtnTotDoc"
        Me.txtnTotDoc.Size = New System.Drawing.Size(99, 20)
        Me.txtnTotDoc.TabIndex = 591
        Me.txtnTotDoc.Text = "  "
        Me.txtnTotDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnNroDoc.Location = New System.Drawing.Point(534, 9)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDoc.TabIndex = 582
        Me.lblnNroDoc.Text = "Número:"
        '
        'lblLin11
        '
        Me.lblLin11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin11.AutoSize = True
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(534, 11)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(169, 13)
        Me.lblLin11.TabIndex = 587
        Me.lblLin11.Text = "___________________________"
        '
        'lblTotDoc
        '
        Me.lblTotDoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotDoc.AutoSize = True
        Me.lblTotDoc.Location = New System.Drawing.Point(592, 415)
        Me.lblTotDoc.Name = "lblTotDoc"
        Me.lblTotDoc.Size = New System.Drawing.Size(96, 13)
        Me.lblTotDoc.TabIndex = 590
        Me.lblTotDoc.Text = "Total a documento"
        '
        'lblLin020
        '
        Me.lblLin020.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin020.AutoSize = True
        Me.lblLin020.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin020.Location = New System.Drawing.Point(591, 418)
        Me.lblLin020.Name = "lblLin020"
        Me.lblLin020.Size = New System.Drawing.Size(169, 13)
        Me.lblLin020.TabIndex = 592
        Me.lblLin020.Text = "___________________________"
        '
        'txtsCmn
        '
        Me.txtsCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsCmn.Location = New System.Drawing.Point(105, 413)
        Me.txtsCmn.MaxLength = 200
        Me.txtsCmn.Multiline = True
        Me.txtsCmn.Name = "txtsCmn"
        Me.txtsCmn.Size = New System.Drawing.Size(327, 40)
        Me.txtsCmn.TabIndex = 574
        '
        'lblCmn
        '
        Me.lblCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCmn.AutoSize = True
        Me.lblCmn.Location = New System.Drawing.Point(12, 409)
        Me.lblCmn.Name = "lblCmn"
        Me.lblCmn.Size = New System.Drawing.Size(65, 13)
        Me.lblCmn.TabIndex = 589
        Me.lblCmn.Text = "Comentarios"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(6, 477)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 575
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(6, 477)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 579
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(6, 477)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 588
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(6, 477)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 577
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(88, 477)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 578
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(6, 477)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 576
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(10, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 593
        Me.Label1.Text = "__________________"
        Me.Label1.Visible = False
        '
        'cmdPEODP
        '
        Me.cmdPEODP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPEODP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP.Location = New System.Drawing.Point(613, 478)
        Me.cmdPEODP.Name = "cmdPEODP"
        Me.cmdPEODP.Size = New System.Drawing.Size(127, 21)
        Me.cmdPEODP.TabIndex = 580
        Me.cmdPEODP.Text = "Orden de producción"
        Me.cmdPEODP.UseVisualStyleBackColor = False
        '
        'lblLin07
        '
        Me.lblLin07.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(536, 60)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(169, 13)
        Me.lblLin07.TabIndex = 586
        Me.lblLin07.Text = "___________________________"
        '
        'lblFecCtb
        '
        Me.lblFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecCtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecCtb.Location = New System.Drawing.Point(534, 34)
        Me.lblFecCtb.Name = "lblFecCtb"
        Me.lblFecCtb.Size = New System.Drawing.Size(139, 13)
        Me.lblFecCtb.TabIndex = 584
        Me.lblFecCtb.Text = "Fecha de contabilización:"
        '
        'dtpFecCtb
        '
        Me.dtpFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecCtb.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtb.Location = New System.Drawing.Point(699, 29)
        Me.dtpFecCtb.Name = "dtpFecCtb"
        Me.dtpFecCtb.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecCtb.TabIndex = 581
        Me.dtpFecCtb.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(534, 36)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 583
        Me.lblLin02.Text = "___________________________"
        '
        'cmdLstPEEDM
        '
        Me.cmdLstPEEDM.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEEDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdLstPEEDM.Location = New System.Drawing.Point(787, 4)
        Me.cmdLstPEEDM.Name = "cmdLstPEEDM"
        Me.cmdLstPEEDM.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstPEEDM.TabIndex = 596
        Me.cmdLstPEEDM.Text = "Lst"
        Me.cmdLstPEEDM.UseVisualStyleBackColor = False
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecDoc.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(699, 52)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecDoc.TabIndex = 597
        Me.dtpFecDoc.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'frmPEEDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(824, 502)
        Me.Controls.Add(Me.dtpFecDoc)
        Me.Controls.Add(Me.cmdLstPEEDM)
        Me.Controls.Add(Me.lblFecDoc)
        Me.Controls.Add(Me.cboAPLND1)
        Me.Controls.Add(Me.txtnNroDoc)
        Me.Controls.Add(Me.tbc003)
        Me.Controls.Add(Me.txtnTotDoc)
        Me.Controls.Add(Me.lblnNroDoc)
        Me.Controls.Add(Me.lblLin11)
        Me.Controls.Add(Me.lblTotDoc)
        Me.Controls.Add(Me.lblLin020)
        Me.Controls.Add(Me.txtsCmn)
        Me.Controls.Add(Me.lblCmn)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdPEODP)
        Me.Controls.Add(Me.lblLin07)
        Me.Controls.Add(Me.lblFecCtb)
        Me.Controls.Add(Me.dtpFecCtb)
        Me.Controls.Add(Me.lblLin02)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEEDM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de materiales"
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
    Friend WithEvents lblFecDoc As System.Windows.Forms.Label
    Friend WithEvents cboAPLND1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
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
    Friend WithEvents txtnTotDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents lblTotDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin020 As System.Windows.Forms.Label
    Friend WithEvents txtsCmn As System.Windows.Forms.TextBox
    Friend WithEvents lblCmn As System.Windows.Forms.Label
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdPEODP As System.Windows.Forms.Button
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents lblFecCtb As System.Windows.Forms.Label
    Friend WithEvents dtpFecCtb As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents cmdLstPEEDM As System.Windows.Forms.Button
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
End Class
