<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRODP05
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRODP05))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtpFecEmiFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecEmiIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecFin = New System.Windows.Forms.Label()
        Me.cmdPEODP_QFFinFin = New System.Windows.Forms.Button()
        Me.txtdFecFinFin = New System.Windows.Forms.TextBox()
        Me.cmdPEODP_QFFinIni = New System.Windows.Forms.Button()
        Me.txtdFecFinIni = New System.Windows.Forms.TextBox()
        Me.lbldFecIni = New System.Windows.Forms.Label()
        Me.cmdPEODP_QFIniFin = New System.Windows.Forms.Button()
        Me.txtdFecIniFin = New System.Windows.Forms.TextBox()
        Me.cmdPEODP_QFIniIni = New System.Windows.Forms.Button()
        Me.txtdFecIniIni = New System.Windows.Forms.TextBox()
        Me.lbldFecEmi = New System.Windows.Forms.Label()
        Me.cmdPEODP_QFEmiFin = New System.Windows.Forms.Button()
        Me.cmdPEODP_QFEmiIni = New System.Windows.Forms.Button()
        Me.lblsCodItm = New System.Windows.Forms.Label()
        Me.cmdPEODP_QItmFin = New System.Windows.Forms.Button()
        Me.txtsCodItmFin = New System.Windows.Forms.TextBox()
        Me.cmdPEODP_QItmIni = New System.Windows.Forms.Button()
        Me.txtsCodItmIni = New System.Windows.Forms.TextBox()
        Me.txtsEstOdp = New System.Windows.Forms.Label()
        Me.cmdABEOPFin = New System.Windows.Forms.Button()
        Me.txtsEstOdpFin = New System.Windows.Forms.TextBox()
        Me.cmdABEOPIni = New System.Windows.Forms.Button()
        Me.txtsEstOdpIni = New System.Windows.Forms.TextBox()
        Me.lblsCodSer = New System.Windows.Forms.Label()
        Me.cmdAPLND1Fin = New System.Windows.Forms.Button()
        Me.txtsCodSerFin = New System.Windows.Forms.TextBox()
        Me.cmdAPLND1Ini = New System.Windows.Forms.Button()
        Me.txtsCodSerIni = New System.Windows.Forms.TextBox()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.cmdLstPEODPFin = New System.Windows.Forms.Button()
        Me.cmdLstABODPFin = New System.Windows.Forms.Button()
        Me.txtnNroDocFin = New System.Windows.Forms.TextBox()
        Me.txtsCodDocFin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLstPEODPIni = New System.Windows.Forms.Button()
        Me.cmdLstABODPIni = New System.Windows.Forms.Button()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.txtsCodDocIni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsCodDoc = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 33)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 20)
        Me.cmdOk.TabIndex = 74
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 32)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 75
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecEmiFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecEmiIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFFinFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdFecFinFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFFinIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdFecFinIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFIniFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdFecIniFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFIniIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdFecIniIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecEmi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFEmiFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFEmiIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodItm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstOdp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdABEOPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstOdpFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdABEOPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstOdpIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodSer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPLND1Fin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodSerFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPLND1Ini)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodSerIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblnNroDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstPEODPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstABODPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstPEODPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstABODPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 362)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 585
        '
        'dtpFecEmiFin
        '
        Me.dtpFecEmiFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecEmiFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmiFin.Location = New System.Drawing.Point(320, 189)
        Me.dtpFecEmiFin.Name = "dtpFecEmiFin"
        Me.dtpFecEmiFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecEmiFin.TabIndex = 54
        '
        'dtpFecEmiIni
        '
        Me.dtpFecEmiIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecEmiIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmiIni.Location = New System.Drawing.Point(125, 189)
        Me.dtpFecEmiIni.Name = "dtpFecEmiIni"
        Me.dtpFecEmiIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecEmiIni.TabIndex = 50
        '
        'lbldFecFin
        '
        Me.lbldFecFin.AutoSize = True
        Me.lbldFecFin.Location = New System.Drawing.Point(10, 255)
        Me.lbldFecFin.Name = "lbldFecFin"
        Me.lbldFecFin.Size = New System.Drawing.Size(92, 13)
        Me.lbldFecFin.TabIndex = 51
        Me.lbldFecFin.Text = "Fecha finalización"
        '
        'cmdPEODP_QFFinFin
        '
        Me.cmdPEODP_QFFinFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFFinFin.Location = New System.Drawing.Point(437, 248)
        Me.cmdPEODP_QFFinFin.Name = "cmdPEODP_QFFinFin"
        Me.cmdPEODP_QFFinFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFFinFin.TabIndex = 72
        Me.cmdPEODP_QFFinFin.Text = "Lst"
        Me.cmdPEODP_QFFinFin.UseVisualStyleBackColor = False
        '
        'txtdFecFinFin
        '
        Me.txtdFecFinFin.Location = New System.Drawing.Point(320, 250)
        Me.txtdFecFinFin.MaxLength = 10
        Me.txtdFecFinFin.Name = "txtdFecFinFin"
        Me.txtdFecFinFin.Size = New System.Drawing.Size(108, 20)
        Me.txtdFecFinFin.TabIndex = 70
        '
        'cmdPEODP_QFFinIni
        '
        Me.cmdPEODP_QFFinIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFFinIni.Location = New System.Drawing.Point(248, 248)
        Me.cmdPEODP_QFFinIni.Name = "cmdPEODP_QFFinIni"
        Me.cmdPEODP_QFFinIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFFinIni.TabIndex = 68
        Me.cmdPEODP_QFFinIni.Text = "Lst"
        Me.cmdPEODP_QFFinIni.UseVisualStyleBackColor = False
        '
        'txtdFecFinIni
        '
        Me.txtdFecFinIni.Location = New System.Drawing.Point(125, 250)
        Me.txtdFecFinIni.MaxLength = 10
        Me.txtdFecFinIni.Name = "txtdFecFinIni"
        Me.txtdFecFinIni.Size = New System.Drawing.Size(108, 20)
        Me.txtdFecFinIni.TabIndex = 66
        '
        'lbldFecIni
        '
        Me.lbldFecIni.AutoSize = True
        Me.lbldFecIni.Location = New System.Drawing.Point(10, 225)
        Me.lbldFecIni.Name = "lbldFecIni"
        Me.lbldFecIni.Size = New System.Drawing.Size(64, 13)
        Me.lbldFecIni.TabIndex = 46
        Me.lbldFecIni.Text = "Fecha inicio"
        '
        'cmdPEODP_QFIniFin
        '
        Me.cmdPEODP_QFIniFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFIniFin.Location = New System.Drawing.Point(437, 218)
        Me.cmdPEODP_QFIniFin.Name = "cmdPEODP_QFIniFin"
        Me.cmdPEODP_QFIniFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFIniFin.TabIndex = 64
        Me.cmdPEODP_QFIniFin.Text = "Lst"
        Me.cmdPEODP_QFIniFin.UseVisualStyleBackColor = False
        '
        'txtdFecIniFin
        '
        Me.txtdFecIniFin.Location = New System.Drawing.Point(320, 220)
        Me.txtdFecIniFin.MaxLength = 10
        Me.txtdFecIniFin.Name = "txtdFecIniFin"
        Me.txtdFecIniFin.Size = New System.Drawing.Size(108, 20)
        Me.txtdFecIniFin.TabIndex = 62
        '
        'cmdPEODP_QFIniIni
        '
        Me.cmdPEODP_QFIniIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFIniIni.Location = New System.Drawing.Point(248, 217)
        Me.cmdPEODP_QFIniIni.Name = "cmdPEODP_QFIniIni"
        Me.cmdPEODP_QFIniIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFIniIni.TabIndex = 60
        Me.cmdPEODP_QFIniIni.Text = "Lst"
        Me.cmdPEODP_QFIniIni.UseVisualStyleBackColor = False
        '
        'txtdFecIniIni
        '
        Me.txtdFecIniIni.Location = New System.Drawing.Point(125, 220)
        Me.txtdFecIniIni.MaxLength = 10
        Me.txtdFecIniIni.Name = "txtdFecIniIni"
        Me.txtdFecIniIni.Size = New System.Drawing.Size(108, 20)
        Me.txtdFecIniIni.TabIndex = 58
        '
        'lbldFecEmi
        '
        Me.lbldFecEmi.AutoSize = True
        Me.lbldFecEmi.Location = New System.Drawing.Point(10, 195)
        Me.lbldFecEmi.Name = "lbldFecEmi"
        Me.lbldFecEmi.Size = New System.Drawing.Size(75, 13)
        Me.lbldFecEmi.TabIndex = 41
        Me.lbldFecEmi.Text = "Fecha emisión"
        '
        'cmdPEODP_QFEmiFin
        '
        Me.cmdPEODP_QFEmiFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFEmiFin.Location = New System.Drawing.Point(437, 188)
        Me.cmdPEODP_QFEmiFin.Name = "cmdPEODP_QFEmiFin"
        Me.cmdPEODP_QFEmiFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFEmiFin.TabIndex = 56
        Me.cmdPEODP_QFEmiFin.Text = "Lst"
        Me.cmdPEODP_QFEmiFin.UseVisualStyleBackColor = False
        '
        'cmdPEODP_QFEmiIni
        '
        Me.cmdPEODP_QFEmiIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFEmiIni.Location = New System.Drawing.Point(248, 188)
        Me.cmdPEODP_QFEmiIni.Name = "cmdPEODP_QFEmiIni"
        Me.cmdPEODP_QFEmiIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFEmiIni.TabIndex = 52
        Me.cmdPEODP_QFEmiIni.Text = "Lst"
        Me.cmdPEODP_QFEmiIni.UseVisualStyleBackColor = False
        '
        'lblsCodItm
        '
        Me.lblsCodItm.AutoSize = True
        Me.lblsCodItm.Location = New System.Drawing.Point(10, 165)
        Me.lblsCodItm.Name = "lblsCodItm"
        Me.lblsCodItm.Size = New System.Drawing.Size(27, 13)
        Me.lblsCodItm.TabIndex = 36
        Me.lblsCodItm.Text = "Ítem"
        '
        'cmdPEODP_QItmFin
        '
        Me.cmdPEODP_QItmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QItmFin.Location = New System.Drawing.Point(437, 158)
        Me.cmdPEODP_QItmFin.Name = "cmdPEODP_QItmFin"
        Me.cmdPEODP_QItmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QItmFin.TabIndex = 48
        Me.cmdPEODP_QItmFin.Text = "Lst"
        Me.cmdPEODP_QItmFin.UseVisualStyleBackColor = False
        '
        'txtsCodItmFin
        '
        Me.txtsCodItmFin.Location = New System.Drawing.Point(320, 160)
        Me.txtsCodItmFin.MaxLength = 20
        Me.txtsCodItmFin.Name = "txtsCodItmFin"
        Me.txtsCodItmFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodItmFin.TabIndex = 46
        '
        'cmdPEODP_QItmIni
        '
        Me.cmdPEODP_QItmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QItmIni.Location = New System.Drawing.Point(248, 158)
        Me.cmdPEODP_QItmIni.Name = "cmdPEODP_QItmIni"
        Me.cmdPEODP_QItmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QItmIni.TabIndex = 44
        Me.cmdPEODP_QItmIni.Text = "Lst"
        Me.cmdPEODP_QItmIni.UseVisualStyleBackColor = False
        '
        'txtsCodItmIni
        '
        Me.txtsCodItmIni.Location = New System.Drawing.Point(125, 160)
        Me.txtsCodItmIni.MaxLength = 20
        Me.txtsCodItmIni.Name = "txtsCodItmIni"
        Me.txtsCodItmIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodItmIni.TabIndex = 42
        '
        'txtsEstOdp
        '
        Me.txtsEstOdp.AutoSize = True
        Me.txtsEstOdp.Location = New System.Drawing.Point(10, 135)
        Me.txtsEstOdp.Name = "txtsEstOdp"
        Me.txtsEstOdp.Size = New System.Drawing.Size(40, 13)
        Me.txtsEstOdp.TabIndex = 31
        Me.txtsEstOdp.Text = "Estado"
        '
        'cmdABEOPFin
        '
        Me.cmdABEOPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdABEOPFin.Location = New System.Drawing.Point(438, 128)
        Me.cmdABEOPFin.Name = "cmdABEOPFin"
        Me.cmdABEOPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdABEOPFin.TabIndex = 40
        Me.cmdABEOPFin.Text = "Lst"
        Me.cmdABEOPFin.UseVisualStyleBackColor = False
        '
        'txtsEstOdpFin
        '
        Me.txtsEstOdpFin.Location = New System.Drawing.Point(320, 130)
        Me.txtsEstOdpFin.MaxLength = 1
        Me.txtsEstOdpFin.Name = "txtsEstOdpFin"
        Me.txtsEstOdpFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsEstOdpFin.TabIndex = 38
        '
        'cmdABEOPIni
        '
        Me.cmdABEOPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdABEOPIni.Location = New System.Drawing.Point(249, 128)
        Me.cmdABEOPIni.Name = "cmdABEOPIni"
        Me.cmdABEOPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdABEOPIni.TabIndex = 36
        Me.cmdABEOPIni.Text = "Lst"
        Me.cmdABEOPIni.UseVisualStyleBackColor = False
        '
        'txtsEstOdpIni
        '
        Me.txtsEstOdpIni.Location = New System.Drawing.Point(125, 130)
        Me.txtsEstOdpIni.MaxLength = 1
        Me.txtsEstOdpIni.Name = "txtsEstOdpIni"
        Me.txtsEstOdpIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsEstOdpIni.TabIndex = 34
        '
        'lblsCodSer
        '
        Me.lblsCodSer.AutoSize = True
        Me.lblsCodSer.Location = New System.Drawing.Point(10, 75)
        Me.lblsCodSer.Name = "lblsCodSer"
        Me.lblsCodSer.Size = New System.Drawing.Size(31, 13)
        Me.lblsCodSer.TabIndex = 26
        Me.lblsCodSer.Text = "Serie"
        '
        'cmdAPLND1Fin
        '
        Me.cmdAPLND1Fin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPLND1Fin.Location = New System.Drawing.Point(439, 68)
        Me.cmdAPLND1Fin.Name = "cmdAPLND1Fin"
        Me.cmdAPLND1Fin.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPLND1Fin.TabIndex = 24
        Me.cmdAPLND1Fin.Text = "Lst"
        Me.cmdAPLND1Fin.UseVisualStyleBackColor = False
        '
        'txtsCodSerFin
        '
        Me.txtsCodSerFin.Location = New System.Drawing.Point(320, 70)
        Me.txtsCodSerFin.MaxLength = 2
        Me.txtsCodSerFin.Name = "txtsCodSerFin"
        Me.txtsCodSerFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerFin.TabIndex = 22
        '
        'cmdAPLND1Ini
        '
        Me.cmdAPLND1Ini.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPLND1Ini.Location = New System.Drawing.Point(248, 67)
        Me.cmdAPLND1Ini.Name = "cmdAPLND1Ini"
        Me.cmdAPLND1Ini.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPLND1Ini.TabIndex = 20
        Me.cmdAPLND1Ini.Text = "Lst"
        Me.cmdAPLND1Ini.UseVisualStyleBackColor = False
        '
        'txtsCodSerIni
        '
        Me.txtsCodSerIni.Location = New System.Drawing.Point(125, 70)
        Me.txtsCodSerIni.MaxLength = 2
        Me.txtsCodSerIni.Name = "txtsCodSerIni"
        Me.txtsCodSerIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerIni.TabIndex = 18
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.AutoSize = True
        Me.lblnNroDoc.Location = New System.Drawing.Point(10, 105)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(44, 13)
        Me.lblnNroDoc.TabIndex = 21
        Me.lblnNroDoc.Text = "Número"
        '
        'cmdLstPEODPFin
        '
        Me.cmdLstPEODPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODPFin.Location = New System.Drawing.Point(438, 98)
        Me.cmdLstPEODPFin.Name = "cmdLstPEODPFin"
        Me.cmdLstPEODPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstPEODPFin.TabIndex = 32
        Me.cmdLstPEODPFin.Text = "Lst"
        Me.cmdLstPEODPFin.UseVisualStyleBackColor = False
        '
        'cmdLstABODPFin
        '
        Me.cmdLstABODPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABODPFin.Location = New System.Drawing.Point(440, 38)
        Me.cmdLstABODPFin.Name = "cmdLstABODPFin"
        Me.cmdLstABODPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstABODPFin.TabIndex = 16
        Me.cmdLstABODPFin.Text = "Lst"
        Me.cmdLstABODPFin.UseVisualStyleBackColor = False
        '
        'txtnNroDocFin
        '
        Me.txtnNroDocFin.Location = New System.Drawing.Point(320, 100)
        Me.txtnNroDocFin.MaxLength = 10
        Me.txtnNroDocFin.Name = "txtnNroDocFin"
        Me.txtnNroDocFin.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocFin.TabIndex = 30
        Me.txtnNroDocFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsCodDocFin
        '
        Me.txtsCodDocFin.Location = New System.Drawing.Point(320, 40)
        Me.txtsCodDocFin.MaxLength = 3
        Me.txtsCodDocFin.Name = "txtsCodDocFin"
        Me.txtsCodDocFin.Size = New System.Drawing.Size(106, 20)
        Me.txtsCodDocFin.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hasta"
        '
        'cmdLstPEODPIni
        '
        Me.cmdLstPEODPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODPIni.Location = New System.Drawing.Point(249, 97)
        Me.cmdLstPEODPIni.Name = "cmdLstPEODPIni"
        Me.cmdLstPEODPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstPEODPIni.TabIndex = 28
        Me.cmdLstPEODPIni.Text = "Lst"
        Me.cmdLstPEODPIni.UseVisualStyleBackColor = False
        '
        'cmdLstABODPIni
        '
        Me.cmdLstABODPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABODPIni.Location = New System.Drawing.Point(249, 37)
        Me.cmdLstABODPIni.Name = "cmdLstABODPIni"
        Me.cmdLstABODPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstABODPIni.TabIndex = 12
        Me.cmdLstABODPIni.Text = "Lst"
        Me.cmdLstABODPIni.UseVisualStyleBackColor = False
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(125, 100)
        Me.txtnNroDocIni.MaxLength = 10
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 26
        Me.txtnNroDocIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsCodDocIni
        '
        Me.txtsCodDocIni.Location = New System.Drawing.Point(125, 40)
        Me.txtsCodDocIni.MaxLength = 3
        Me.txtsCodDocIni.Name = "txtsCodDocIni"
        Me.txtsCodDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodDocIni.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Desde"
        '
        'lblsCodDoc
        '
        Me.lblsCodDoc.AutoSize = True
        Me.lblsCodDoc.Location = New System.Drawing.Point(10, 45)
        Me.lblsCodDoc.Name = "lblsCodDoc"
        Me.lblsCodDoc.Size = New System.Drawing.Size(68, 13)
        Me.lblsCodDoc.TabIndex = 9
        Me.lblsCodDoc.Text = "Documento :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 10
        Me.LineShape8.X2 = 456
        Me.LineShape8.Y1 = 268
        Me.LineShape8.Y2 = 269
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 11
        Me.LineShape7.X2 = 457
        Me.LineShape7.Y1 = 238
        Me.LineShape7.Y2 = 239
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 13
        Me.LineShape6.X2 = 459
        Me.LineShape6.Y1 = 208
        Me.LineShape6.Y2 = 209
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 14
        Me.LineShape5.X2 = 460
        Me.LineShape5.Y1 = 178
        Me.LineShape5.Y2 = 179
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 12
        Me.LineShape4.X2 = 458
        Me.LineShape4.Y1 = 148
        Me.LineShape4.Y2 = 149
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 14
        Me.LineShape3.X2 = 460
        Me.LineShape3.Y1 = 118
        Me.LineShape3.Y2 = 119
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 12
        Me.LineShape2.X2 = 458
        Me.LineShape2.Y1 = 88
        Me.LineShape2.Y2 = 89
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 458
        Me.LineShape1.Y1 = 59
        Me.LineShape1.Y2 = 59
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 31)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 76
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'frmPRODP05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPRODP05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte para Revisión de OP con Costos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dtpFecEmiFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecEmiIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecFin As System.Windows.Forms.Label
    Friend WithEvents cmdPEODP_QFFinFin As System.Windows.Forms.Button
    Friend WithEvents txtdFecFinFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdPEODP_QFFinIni As System.Windows.Forms.Button
    Friend WithEvents txtdFecFinIni As System.Windows.Forms.TextBox
    Friend WithEvents lbldFecIni As System.Windows.Forms.Label
    Friend WithEvents cmdPEODP_QFIniFin As System.Windows.Forms.Button
    Friend WithEvents txtdFecIniFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdPEODP_QFIniIni As System.Windows.Forms.Button
    Friend WithEvents txtdFecIniIni As System.Windows.Forms.TextBox
    Friend WithEvents lbldFecEmi As System.Windows.Forms.Label
    Friend WithEvents cmdPEODP_QFEmiFin As System.Windows.Forms.Button
    Friend WithEvents cmdPEODP_QFEmiIni As System.Windows.Forms.Button
    Friend WithEvents lblsCodItm As System.Windows.Forms.Label
    Friend WithEvents cmdPEODP_QItmFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodItmFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdPEODP_QItmIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodItmIni As System.Windows.Forms.TextBox
    Friend WithEvents txtsEstOdp As System.Windows.Forms.Label
    Friend WithEvents cmdABEOPFin As System.Windows.Forms.Button
    Friend WithEvents txtsEstOdpFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdABEOPIni As System.Windows.Forms.Button
    Friend WithEvents txtsEstOdpIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodSer As System.Windows.Forms.Label
    Friend WithEvents cmdAPLND1Fin As System.Windows.Forms.Button
    Friend WithEvents txtsCodSerFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdAPLND1Ini As System.Windows.Forms.Button
    Friend WithEvents txtsCodSerIni As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents cmdLstPEODPFin As System.Windows.Forms.Button
    Friend WithEvents cmdLstABODPFin As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocFin As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodDocFin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdLstPEODPIni As System.Windows.Forms.Button
    Friend WithEvents cmdLstABODPIni As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodDocIni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblsCodDoc As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
