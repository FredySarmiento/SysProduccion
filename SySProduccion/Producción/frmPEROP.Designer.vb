<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEROP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEROP))
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.txtsNomTer = New System.Windows.Forms.TextBox()
        Me.lblNomTer = New System.Windows.Forms.Label()
        Me.txtsCodTer = New System.Windows.Forms.TextBox()
        Me.lblCodTer = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblFecDoc = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.cboABESD = New System.Windows.Forms.ComboBox()
        Me.cboAPLND1 = New System.Windows.Forms.ComboBox()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.lblFecCtb = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.dtpFecCtb = New System.Windows.Forms.DateTimePicker()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.lblsEstDoc = New System.Windows.Forms.Label()
        Me.lblLin12 = New System.Windows.Forms.Label()
        Me.lblTotTieOpe = New System.Windows.Forms.Label()
        Me.txtnTotTieCns = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtnNroCteCtb = New System.Windows.Forms.TextBox()
        Me.txtsCodCteCtb = New System.Windows.Forms.TextBox()
        Me.cmdConCteCtb = New System.Windows.Forms.Button()
        Me.lblsCodCteCtb = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblTotHH = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnTotHHCns = New System.Windows.Forms.TextBox()
        Me.txtnTotMMCns = New System.Windows.Forms.TextBox()
        Me.txtsCmn = New System.Windows.Forms.TextBox()
        Me.lblCmn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboABROP = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdLstPEROP = New System.Windows.Forms.Button()
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(12, 468)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 549
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(12, 468)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 551
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(12, 468)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 554
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(12, 468)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 552
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(94, 468)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 550
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(12, 468)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 553
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdListar.Location = New System.Drawing.Point(206, 6)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(27, 20)
        Me.cmdListar.TabIndex = 560
        Me.cmdListar.Text = "Lst"
        Me.cmdListar.UseVisualStyleBackColor = False
        '
        'txtsNomTer
        '
        Me.txtsNomTer.BackColor = System.Drawing.SystemColors.Window
        Me.txtsNomTer.Enabled = False
        Me.txtsNomTer.Location = New System.Drawing.Point(100, 30)
        Me.txtsNomTer.MaxLength = 15
        Me.txtsNomTer.Name = "txtsNomTer"
        Me.txtsNomTer.Size = New System.Drawing.Size(379, 20)
        Me.txtsNomTer.TabIndex = 556
        Me.txtsNomTer.Text = "  "
        '
        'lblNomTer
        '
        Me.lblNomTer.AutoSize = True
        Me.lblNomTer.Location = New System.Drawing.Point(9, 36)
        Me.lblNomTer.Name = "lblNomTer"
        Me.lblNomTer.Size = New System.Drawing.Size(50, 13)
        Me.lblNomTer.TabIndex = 559
        Me.lblNomTer.Text = "Nombre :"
        '
        'txtsCodTer
        '
        Me.txtsCodTer.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodTer.Location = New System.Drawing.Point(100, 5)
        Me.txtsCodTer.MaxLength = 15
        Me.txtsCodTer.Name = "txtsCodTer"
        Me.txtsCodTer.Size = New System.Drawing.Size(99, 20)
        Me.txtsCodTer.TabIndex = 555
        Me.txtsCodTer.Text = "  "
        '
        'lblCodTer
        '
        Me.lblCodTer.AutoSize = True
        Me.lblCodTer.Location = New System.Drawing.Point(9, 11)
        Me.lblCodTer.Name = "lblCodTer"
        Me.lblCodTer.Size = New System.Drawing.Size(53, 13)
        Me.lblCodTer.TabIndex = 558
        Me.lblCodTer.Text = "Operario :"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(9, 12)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 561
        Me.lblLin01.Text = "___________________________"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(9, 37)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 562
        Me.lblLin03.Text = "___________________________"
        '
        'lblFecDoc
        '
        Me.lblFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecDoc.Location = New System.Drawing.Point(543, 55)
        Me.lblFecDoc.Name = "lblFecDoc"
        Me.lblFecDoc.Size = New System.Drawing.Size(105, 15)
        Me.lblFecDoc.TabIndex = 571
        Me.lblFecDoc.Text = "Fecha documento"
        '
        'lblLin07
        '
        Me.lblLin07.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(544, 58)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(169, 13)
        Me.lblLin07.TabIndex = 572
        Me.lblLin07.Text = "___________________________"
        '
        'cboABESD
        '
        Me.cboABESD.FormattingEnabled = True
        Me.cboABESD.Location = New System.Drawing.Point(701, 73)
        Me.cboABESD.Name = "cboABESD"
        Me.cboABESD.Size = New System.Drawing.Size(82, 21)
        Me.cboABESD.TabIndex = 574
        Me.cboABESD.Visible = False
        '
        'cboAPLND1
        '
        Me.cboAPLND1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAPLND1.FormattingEnabled = True
        Me.cboAPLND1.Location = New System.Drawing.Point(637, 4)
        Me.cboAPLND1.Name = "cboAPLND1"
        Me.cboAPLND1.Size = New System.Drawing.Size(57, 21)
        Me.cboAPLND1.TabIndex = 563
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnNroDoc.Location = New System.Drawing.Point(701, 6)
        Me.txtnNroDoc.MaxLength = 12
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(82, 20)
        Me.txtnNroDoc.TabIndex = 564
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnNroDoc.Location = New System.Drawing.Point(543, 11)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDoc.TabIndex = 568
        Me.lblnNroDoc.Text = "Número:"
        '
        'lblFecCtb
        '
        Me.lblFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecCtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecCtb.Location = New System.Drawing.Point(544, 33)
        Me.lblFecCtb.Name = "lblFecCtb"
        Me.lblFecCtb.Size = New System.Drawing.Size(139, 13)
        Me.lblFecCtb.TabIndex = 570
        Me.lblFecCtb.Text = "Fecha de contabilización:"
        '
        'lblLin11
        '
        Me.lblLin11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin11.AutoSize = True
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(544, 13)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(169, 13)
        Me.lblLin11.TabIndex = 573
        Me.lblLin11.Text = "___________________________"
        '
        'dtpFecCtb
        '
        Me.dtpFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecCtb.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtb.Location = New System.Drawing.Point(701, 28)
        Me.dtpFecCtb.Name = "dtpFecCtb"
        Me.dtpFecCtb.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecCtb.TabIndex = 567
        Me.dtpFecCtb.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(546, 35)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 569
        Me.lblLin02.Text = "___________________________"
        '
        'lblsEstDoc
        '
        Me.lblsEstDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsEstDoc.AutoSize = True
        Me.lblsEstDoc.Location = New System.Drawing.Point(543, 78)
        Me.lblsEstDoc.Name = "lblsEstDoc"
        Me.lblsEstDoc.Size = New System.Drawing.Size(46, 13)
        Me.lblsEstDoc.TabIndex = 576
        Me.lblsEstDoc.Text = "Estado :"
        Me.lblsEstDoc.Visible = False
        '
        'lblLin12
        '
        Me.lblLin12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin12.AutoSize = True
        Me.lblLin12.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin12.Location = New System.Drawing.Point(542, 79)
        Me.lblLin12.Name = "lblLin12"
        Me.lblLin12.Size = New System.Drawing.Size(169, 13)
        Me.lblLin12.TabIndex = 577
        Me.lblLin12.Text = "___________________________"
        Me.lblLin12.Visible = False
        '
        'lblTotTieOpe
        '
        Me.lblTotTieOpe.AutoSize = True
        Me.lblTotTieOpe.Location = New System.Drawing.Point(615, 398)
        Me.lblTotTieOpe.Name = "lblTotTieOpe"
        Me.lblTotTieOpe.Size = New System.Drawing.Size(68, 13)
        Me.lblTotTieOpe.TabIndex = 578
        Me.lblTotTieOpe.Text = "Total tiempo:"
        '
        'txtnTotTieCns
        '
        Me.txtnTotTieCns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTotTieCns.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTotTieCns.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnTotTieCns.Enabled = False
        Me.txtnTotTieCns.Location = New System.Drawing.Point(721, 395)
        Me.txtnTotTieCns.MaxLength = 12
        Me.txtnTotTieCns.Name = "txtnTotTieCns"
        Me.txtnTotTieCns.Size = New System.Drawing.Size(82, 20)
        Me.txtnTotTieCns.TabIndex = 579
        Me.txtnTotTieCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(615, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 580
        Me.Label1.Text = "___________________________"
        Me.Label1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 109)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(816, 247)
        Me.TabControl1.TabIndex = 581
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.dgv1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(808, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle"
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 3)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(802, 215)
        Me.dgv1.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.txtnNroCteCtb)
        Me.TabPage2.Controls.Add(Me.txtsCodCteCtb)
        Me.TabPage2.Controls.Add(Me.cmdConCteCtb)
        Me.TabPage2.Controls.Add(Me.lblsCodCteCtb)
        Me.TabPage2.Controls.Add(Me.lblLin04)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(808, 221)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Finanzas"
        '
        'txtnNroCteCtb
        '
        Me.txtnNroCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtnNroCteCtb.Location = New System.Drawing.Point(223, 7)
        Me.txtnNroCteCtb.MaxLength = 20
        Me.txtnNroCteCtb.Name = "txtnNroCteCtb"
        Me.txtnNroCteCtb.Size = New System.Drawing.Size(112, 20)
        Me.txtnNroCteCtb.TabIndex = 242
        '
        'txtsCodCteCtb
        '
        Me.txtsCodCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsCodCteCtb.Location = New System.Drawing.Point(146, 7)
        Me.txtsCodCteCtb.MaxLength = 10
        Me.txtsCodCteCtb.Name = "txtsCodCteCtb"
        Me.txtsCodCteCtb.Size = New System.Drawing.Size(71, 20)
        Me.txtsCodCteCtb.TabIndex = 241
        '
        'cmdConCteCtb
        '
        Me.cmdConCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdConCteCtb.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdConCteCtb.Location = New System.Drawing.Point(98, 14)
        Me.cmdConCteCtb.Name = "cmdConCteCtb"
        Me.cmdConCteCtb.Size = New System.Drawing.Size(38, 14)
        Me.cmdConCteCtb.TabIndex = 244
        Me.cmdConCteCtb.Text = "..."
        Me.cmdConCteCtb.UseVisualStyleBackColor = False
        Me.cmdConCteCtb.Visible = False
        '
        'lblsCodCteCtb
        '
        Me.lblsCodCteCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblsCodCteCtb.AutoSize = True
        Me.lblsCodCteCtb.Location = New System.Drawing.Point(6, 13)
        Me.lblsCodCteCtb.Name = "lblsCodCteCtb"
        Me.lblsCodCteCtb.Size = New System.Drawing.Size(86, 13)
        Me.lblsCodCteCtb.TabIndex = 243
        Me.lblsCodCteCtb.Text = "Asiento contable"
        '
        'lblLin04
        '
        Me.lblLin04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(14, 14)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 245
        Me.lblLin04.Text = "___________________________"
        '
        'lblTotHH
        '
        Me.lblTotHH.AutoSize = True
        Me.lblTotHH.Location = New System.Drawing.Point(615, 374)
        Me.lblTotHH.Name = "lblTotHH"
        Me.lblTotHH.Size = New System.Drawing.Size(77, 13)
        Me.lblTotHH.TabIndex = 582
        Me.lblTotHH.Text = "Total HH:MM :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(620, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 583
        Me.Label2.Text = "____________________________"
        Me.Label2.Visible = False
        '
        'txtnTotHHCns
        '
        Me.txtnTotHHCns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTotHHCns.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTotHHCns.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnTotHHCns.Enabled = False
        Me.txtnTotHHCns.Location = New System.Drawing.Point(723, 368)
        Me.txtnTotHHCns.MaxLength = 3
        Me.txtnTotHHCns.Name = "txtnTotHHCns"
        Me.txtnTotHHCns.Size = New System.Drawing.Size(32, 20)
        Me.txtnTotHHCns.TabIndex = 584
        Me.txtnTotHHCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnTotMMCns
        '
        Me.txtnTotMMCns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTotMMCns.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTotMMCns.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnTotMMCns.Enabled = False
        Me.txtnTotMMCns.Location = New System.Drawing.Point(772, 368)
        Me.txtnTotMMCns.MaxLength = 3
        Me.txtnTotMMCns.Name = "txtnTotMMCns"
        Me.txtnTotMMCns.Size = New System.Drawing.Size(30, 20)
        Me.txtnTotMMCns.TabIndex = 585
        Me.txtnTotMMCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsCmn
        '
        Me.txtsCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtsCmn.Location = New System.Drawing.Point(85, 384)
        Me.txtsCmn.MaxLength = 200
        Me.txtsCmn.Multiline = True
        Me.txtsCmn.Name = "txtsCmn"
        Me.txtsCmn.Size = New System.Drawing.Size(327, 44)
        Me.txtsCmn.TabIndex = 586
        '
        'lblCmn
        '
        Me.lblCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCmn.AutoSize = True
        Me.lblCmn.Location = New System.Drawing.Point(12, 381)
        Me.lblCmn.Name = "lblCmn"
        Me.lblCmn.Size = New System.Drawing.Size(65, 13)
        Me.lblCmn.TabIndex = 587
        Me.lblCmn.Text = "Comentarios"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(17, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 588
        Me.Label3.Text = "_____________"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 589
        Me.Label4.Text = "Tipo de registro"
        '
        'cboABROP
        '
        Me.cboABROP.FormattingEnabled = True
        Me.cboABROP.Location = New System.Drawing.Point(100, 55)
        Me.cboABROP.Name = "cboABROP"
        Me.cboABROP.Size = New System.Drawing.Size(141, 21)
        Me.cboABROP.TabIndex = 590
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(8, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 13)
        Me.Label5.TabIndex = 591
        Me.Label5.Text = "___________________________"
        '
        'cmdLstPEROP
        '
        Me.cmdLstPEROP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEROP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdLstPEROP.Location = New System.Drawing.Point(789, 7)
        Me.cmdLstPEROP.Name = "cmdLstPEROP"
        Me.cmdLstPEROP.Size = New System.Drawing.Size(28, 19)
        Me.cmdLstPEROP.TabIndex = 592
        Me.cmdLstPEROP.Text = "Lst"
        Me.cmdLstPEROP.UseVisualStyleBackColor = False
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecDoc.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(702, 51)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecDoc.TabIndex = 593
        Me.dtpFecDoc.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'frmPEROP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(824, 502)
        Me.Controls.Add(Me.dtpFecDoc)
        Me.Controls.Add(Me.cmdLstPEROP)
        Me.Controls.Add(Me.cboABROP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsCmn)
        Me.Controls.Add(Me.lblCmn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnTotMMCns)
        Me.Controls.Add(Me.txtnTotHHCns)
        Me.Controls.Add(Me.lblTotHH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtnTotTieCns)
        Me.Controls.Add(Me.lblTotTieOpe)
        Me.Controls.Add(Me.lblsEstDoc)
        Me.Controls.Add(Me.lblFecDoc)
        Me.Controls.Add(Me.cboABESD)
        Me.Controls.Add(Me.cboAPLND1)
        Me.Controls.Add(Me.txtnNroDoc)
        Me.Controls.Add(Me.lblnNroDoc)
        Me.Controls.Add(Me.lblFecCtb)
        Me.Controls.Add(Me.lblLin11)
        Me.Controls.Add(Me.dtpFecCtb)
        Me.Controls.Add(Me.lblLin02)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.txtsNomTer)
        Me.Controls.Add(Me.lblNomTer)
        Me.Controls.Add(Me.txtsCodTer)
        Me.Controls.Add(Me.lblCodTer)
        Me.Controls.Add(Me.lblLin01)
        Me.Controls.Add(Me.lblLin03)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.lblLin12)
        Me.Controls.Add(Me.lblLin07)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEROP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de operaciones por operario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdListar As System.Windows.Forms.Button
    Friend WithEvents txtsNomTer As System.Windows.Forms.TextBox
    Friend WithEvents lblNomTer As System.Windows.Forms.Label
    Friend WithEvents txtsCodTer As System.Windows.Forms.TextBox
    Friend WithEvents lblCodTer As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents lblFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents cboABESD As System.Windows.Forms.ComboBox
    Friend WithEvents cboAPLND1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents lblFecCtb As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCtb As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents lblsEstDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin12 As System.Windows.Forms.Label
    Friend WithEvents lblTotTieOpe As System.Windows.Forms.Label
    Friend WithEvents txtnTotTieCns As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotHH As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnTotHHCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotMMCns As System.Windows.Forms.TextBox
    Friend WithEvents txtsCmn As System.Windows.Forms.TextBox
    Friend WithEvents lblCmn As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtnNroCteCtb As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodCteCtb As System.Windows.Forms.TextBox
    Friend WithEvents cmdConCteCtb As System.Windows.Forms.Button
    Friend WithEvents lblsCodCteCtb As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboABROP As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdLstPEROP As System.Windows.Forms.Button
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
End Class
