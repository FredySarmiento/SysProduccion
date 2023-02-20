<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIRMOV03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIRMOV03))
        Me.txtsCodTraFin = New System.Windows.Forms.TextBox()
        Me.txtsCodDocIni = New System.Windows.Forms.TextBox()
        Me.lblsTipMov = New System.Windows.Forms.Label()
        Me.cmdTipMov = New System.Windows.Forms.Button()
        Me.txtsTipMov = New System.Windows.Forms.TextBox()
        Me.lblsCodTra = New System.Windows.Forms.Label()
        Me.cmdATTINFin = New System.Windows.Forms.Button()
        Me.txtsCodSerFin = New System.Windows.Forms.TextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdATTINIni = New System.Windows.Forms.Button()
        Me.txtsCodTraIni = New System.Windows.Forms.TextBox()
        Me.lblsCodSer = New System.Windows.Forms.Label()
        Me.cmdAPENDSerF = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.txtnNroDocFin = New System.Windows.Forms.TextBox()
        Me.cmdAPENDSerI = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.mtbsCodItmFin = New System.Windows.Forms.MaskedTextBox()
        Me.mtbsCodItmIni = New System.Windows.Forms.MaskedTextBox()
        Me.cmdGELMOV1Fin = New System.Windows.Forms.Button()
        Me.cmdGELMOV1Ini = New System.Windows.Forms.Button()
        Me.lblCodItm = New System.Windows.Forms.Label()
        Me.txtsCodSerIni = New System.Windows.Forms.TextBox()
        Me.dtpFecDocFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecDoc = New System.Windows.Forms.Label()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.cmdIEMOVFin = New System.Windows.Forms.Button()
        Me.txtsCodDocFin = New System.Windows.Forms.TextBox()
        Me.cmdIEMOVIni = New System.Windows.Forms.Button()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.lblsCodDoc = New System.Windows.Forms.Label()
        Me.cmdAPENDFin = New System.Windows.Forms.Button()
        Me.cmdAPENDIni = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsCodTraFin
        '
        Me.txtsCodTraFin.Location = New System.Drawing.Point(320, 135)
        Me.txtsCodTraFin.MaxLength = 20
        Me.txtsCodTraFin.Name = "txtsCodTraFin"
        Me.txtsCodTraFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodTraFin.TabIndex = 37
        '
        'txtsCodDocIni
        '
        Me.txtsCodDocIni.Location = New System.Drawing.Point(130, 60)
        Me.txtsCodDocIni.MaxLength = 20
        Me.txtsCodDocIni.Name = "txtsCodDocIni"
        Me.txtsCodDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodDocIni.TabIndex = 9
        '
        'lblsTipMov
        '
        Me.lblsTipMov.AutoSize = True
        Me.lblsTipMov.Location = New System.Drawing.Point(10, 42)
        Me.lblsTipMov.Name = "lblsTipMov"
        Me.lblsTipMov.Size = New System.Drawing.Size(55, 13)
        Me.lblsTipMov.TabIndex = 81
        Me.lblsTipMov.Text = "Tipo Mov."
        '
        'cmdTipMov
        '
        Me.cmdTipMov.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdTipMov.Location = New System.Drawing.Point(255, 34)
        Me.cmdTipMov.Name = "cmdTipMov"
        Me.cmdTipMov.Size = New System.Drawing.Size(30, 23)
        Me.cmdTipMov.TabIndex = 7
        Me.cmdTipMov.Text = "Lst"
        Me.cmdTipMov.UseVisualStyleBackColor = False
        '
        'txtsTipMov
        '
        Me.txtsTipMov.Location = New System.Drawing.Point(130, 35)
        Me.txtsTipMov.MaxLength = 20
        Me.txtsTipMov.Name = "txtsTipMov"
        Me.txtsTipMov.Size = New System.Drawing.Size(108, 20)
        Me.txtsTipMov.TabIndex = 5
        '
        'lblsCodTra
        '
        Me.lblsCodTra.AutoSize = True
        Me.lblsCodTra.Location = New System.Drawing.Point(10, 139)
        Me.lblsCodTra.Name = "lblsCodTra"
        Me.lblsCodTra.Size = New System.Drawing.Size(66, 13)
        Me.lblsCodTra.TabIndex = 78
        Me.lblsCodTra.Text = "Transacción"
        '
        'cmdATTINFin
        '
        Me.cmdATTINFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdATTINFin.Location = New System.Drawing.Point(440, 135)
        Me.cmdATTINFin.Name = "cmdATTINFin"
        Me.cmdATTINFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdATTINFin.TabIndex = 39
        Me.cmdATTINFin.Text = "Lst"
        Me.cmdATTINFin.UseVisualStyleBackColor = False
        '
        'txtsCodSerFin
        '
        Me.txtsCodSerFin.Location = New System.Drawing.Point(320, 85)
        Me.txtsCodSerFin.MaxLength = 20
        Me.txtsCodSerFin.Name = "txtsCodSerFin"
        Me.txtsCodSerFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerFin.TabIndex = 21
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
        Me.cmdOk.TabIndex = 45
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdATTINIni
        '
        Me.cmdATTINIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdATTINIni.Location = New System.Drawing.Point(255, 134)
        Me.cmdATTINIni.Name = "cmdATTINIni"
        Me.cmdATTINIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdATTINIni.TabIndex = 35
        Me.cmdATTINIni.Text = "Lst"
        Me.cmdATTINIni.UseVisualStyleBackColor = False
        '
        'txtsCodTraIni
        '
        Me.txtsCodTraIni.Location = New System.Drawing.Point(130, 135)
        Me.txtsCodTraIni.MaxLength = 20
        Me.txtsCodTraIni.Name = "txtsCodTraIni"
        Me.txtsCodTraIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodTraIni.TabIndex = 33
        '
        'lblsCodSer
        '
        Me.lblsCodSer.AutoSize = True
        Me.lblsCodSer.Location = New System.Drawing.Point(12, 89)
        Me.lblsCodSer.Name = "lblsCodSer"
        Me.lblsCodSer.Size = New System.Drawing.Size(31, 13)
        Me.lblsCodSer.TabIndex = 73
        Me.lblsCodSer.Text = "Serie"
        '
        'cmdAPENDSerF
        '
        Me.cmdAPENDSerF.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDSerF.Location = New System.Drawing.Point(440, 83)
        Me.cmdAPENDSerF.Name = "cmdAPENDSerF"
        Me.cmdAPENDSerF.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDSerF.TabIndex = 23
        Me.cmdAPENDSerF.Text = "Lst"
        Me.cmdAPENDSerF.UseVisualStyleBackColor = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 31)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 55
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'txtnNroDocFin
        '
        Me.txtnNroDocFin.Location = New System.Drawing.Point(320, 108)
        Me.txtnNroDocFin.MaxLength = 20
        Me.txtnNroDocFin.Name = "txtnNroDocFin"
        Me.txtnNroDocFin.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocFin.TabIndex = 29
        '
        'cmdAPENDSerI
        '
        Me.cmdAPENDSerI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDSerI.Location = New System.Drawing.Point(255, 83)
        Me.cmdAPENDSerI.Name = "cmdAPENDSerI"
        Me.cmdAPENDSerI.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDSerI.TabIndex = 19
        Me.cmdAPENDSerI.Text = "Lst"
        Me.cmdAPENDSerI.UseVisualStyleBackColor = False
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.mtbsCodItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mtbsCodItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdGELMOV1Fin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdGELMOV1Ini)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCodItm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodTraFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsTipMov)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTipMov)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsTipMov)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodTra)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdATTINFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodSerFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdATTINIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodTraIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodSer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPENDSerF)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPENDSerI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodSerIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblnNroDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEMOVFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEMOVIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPENDFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPENDIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 362)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 587
        '
        'mtbsCodItmFin
        '
        Me.mtbsCodItmFin.Location = New System.Drawing.Point(320, 160)
        Me.mtbsCodItmFin.Mask = "AAA-000"
        Me.mtbsCodItmFin.Name = "mtbsCodItmFin"
        Me.mtbsCodItmFin.Size = New System.Drawing.Size(108, 20)
        Me.mtbsCodItmFin.TabIndex = 96
        '
        'mtbsCodItmIni
        '
        Me.mtbsCodItmIni.Location = New System.Drawing.Point(130, 160)
        Me.mtbsCodItmIni.Mask = "AAA-000"
        Me.mtbsCodItmIni.Name = "mtbsCodItmIni"
        Me.mtbsCodItmIni.Size = New System.Drawing.Size(108, 20)
        Me.mtbsCodItmIni.TabIndex = 95
        '
        'cmdGELMOV1Fin
        '
        Me.cmdGELMOV1Fin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdGELMOV1Fin.Location = New System.Drawing.Point(440, 158)
        Me.cmdGELMOV1Fin.Name = "cmdGELMOV1Fin"
        Me.cmdGELMOV1Fin.Size = New System.Drawing.Size(30, 23)
        Me.cmdGELMOV1Fin.TabIndex = 94
        Me.cmdGELMOV1Fin.Text = "Lst"
        Me.cmdGELMOV1Fin.UseVisualStyleBackColor = False
        '
        'cmdGELMOV1Ini
        '
        Me.cmdGELMOV1Ini.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdGELMOV1Ini.Location = New System.Drawing.Point(255, 158)
        Me.cmdGELMOV1Ini.Name = "cmdGELMOV1Ini"
        Me.cmdGELMOV1Ini.Size = New System.Drawing.Size(30, 23)
        Me.cmdGELMOV1Ini.TabIndex = 93
        Me.cmdGELMOV1Ini.Text = "Lst"
        Me.cmdGELMOV1Ini.UseVisualStyleBackColor = False
        '
        'lblCodItm
        '
        Me.lblCodItm.AutoSize = True
        Me.lblCodItm.Location = New System.Drawing.Point(10, 166)
        Me.lblCodItm.Name = "lblCodItm"
        Me.lblCodItm.Size = New System.Drawing.Size(33, 13)
        Me.lblCodItm.TabIndex = 92
        Me.lblCodItm.Text = "Ítem :"
        Me.lblCodItm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtsCodSerIni
        '
        Me.txtsCodSerIni.Location = New System.Drawing.Point(130, 85)
        Me.txtsCodSerIni.MaxLength = 20
        Me.txtsCodSerIni.Name = "txtsCodSerIni"
        Me.txtsCodSerIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerIni.TabIndex = 17
        '
        'dtpFecDocFin
        '
        Me.dtpFecDocFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocFin.Location = New System.Drawing.Point(319, 185)
        Me.dtpFecDocFin.Name = "dtpFecDocFin"
        Me.dtpFecDocFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocFin.TabIndex = 43
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(129, 185)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocIni.TabIndex = 41
        '
        'lbldFecDoc
        '
        Me.lbldFecDoc.AutoSize = True
        Me.lbldFecDoc.Location = New System.Drawing.Point(11, 190)
        Me.lbldFecDoc.Name = "lbldFecDoc"
        Me.lbldFecDoc.Size = New System.Drawing.Size(43, 13)
        Me.lbldFecDoc.TabIndex = 64
        Me.lbldFecDoc.Text = "Fecha :"
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.AutoSize = True
        Me.lblnNroDoc.Location = New System.Drawing.Point(12, 115)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(44, 13)
        Me.lblnNroDoc.TabIndex = 49
        Me.lblnNroDoc.Text = "Número"
        '
        'cmdIEMOVFin
        '
        Me.cmdIEMOVFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEMOVFin.Location = New System.Drawing.Point(440, 106)
        Me.cmdIEMOVFin.Name = "cmdIEMOVFin"
        Me.cmdIEMOVFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEMOVFin.TabIndex = 31
        Me.cmdIEMOVFin.Text = "Lst"
        Me.cmdIEMOVFin.UseVisualStyleBackColor = False
        '
        'txtsCodDocFin
        '
        Me.txtsCodDocFin.Location = New System.Drawing.Point(320, 60)
        Me.txtsCodDocFin.MaxLength = 20
        Me.txtsCodDocFin.Name = "txtsCodDocFin"
        Me.txtsCodDocFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodDocFin.TabIndex = 13
        '
        'cmdIEMOVIni
        '
        Me.cmdIEMOVIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEMOVIni.Location = New System.Drawing.Point(255, 108)
        Me.cmdIEMOVIni.Name = "cmdIEMOVIni"
        Me.cmdIEMOVIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEMOVIni.TabIndex = 27
        Me.cmdIEMOVIni.Text = "Lst"
        Me.cmdIEMOVIni.UseVisualStyleBackColor = False
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(130, 108)
        Me.txtnNroDocIni.MaxLength = 20
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 25
        '
        'lblsCodDoc
        '
        Me.lblsCodDoc.AutoSize = True
        Me.lblsCodDoc.Location = New System.Drawing.Point(10, 66)
        Me.lblsCodDoc.Name = "lblsCodDoc"
        Me.lblsCodDoc.Size = New System.Drawing.Size(62, 13)
        Me.lblsCodDoc.TabIndex = 36
        Me.lblsCodDoc.Text = "Documento"
        '
        'cmdAPENDFin
        '
        Me.cmdAPENDFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDFin.Location = New System.Drawing.Point(440, 60)
        Me.cmdAPENDFin.Name = "cmdAPENDFin"
        Me.cmdAPENDFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDFin.TabIndex = 15
        Me.cmdAPENDFin.Text = "Lst"
        Me.cmdAPENDFin.UseVisualStyleBackColor = False
        '
        'cmdAPENDIni
        '
        Me.cmdAPENDIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDIni.Location = New System.Drawing.Point(255, 58)
        Me.cmdAPENDIni.Name = "cmdAPENDIni"
        Me.cmdAPENDIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDIni.TabIndex = 11
        Me.cmdAPENDIni.Text = "Lst"
        Me.cmdAPENDIni.UseVisualStyleBackColor = False
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape7, Me.LineShape6, Me.LineShape4, Me.LineShape2, Me.LineShape3, Me.LineShape1, Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 11
        Me.LineShape7.X2 = 410
        Me.LineShape7.Y1 = 204
        Me.LineShape7.Y2 = 204
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 15
        Me.LineShape6.X2 = 461
        Me.LineShape6.Y1 = 154
        Me.LineShape6.Y2 = 155
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 15
        Me.LineShape4.X2 = 461
        Me.LineShape4.Y1 = 128
        Me.LineShape4.Y2 = 129
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 14
        Me.LineShape2.X2 = 460
        Me.LineShape2.Y1 = 103
        Me.LineShape2.Y2 = 104
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 15
        Me.LineShape3.X2 = 453
        Me.LineShape3.Y1 = 179
        Me.LineShape3.Y2 = 179
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 459
        Me.LineShape1.Y1 = 79
        Me.LineShape1.Y2 = 80
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 15
        Me.LineShape5.X2 = 270
        Me.LineShape5.Y1 = 55
        Me.LineShape5.Y2 = 55
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 32)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 49
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmIRMOV03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIRMOV03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Datos del movimiento"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsCodTraFin As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsTipMov As System.Windows.Forms.Label
    Friend WithEvents cmdTipMov As System.Windows.Forms.Button
    Friend WithEvents txtsTipMov As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodTra As System.Windows.Forms.Label
    Friend WithEvents cmdATTINFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodSerFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdATTINIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodTraIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodSer As System.Windows.Forms.Label
    Friend WithEvents cmdAPENDSerF As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdAPENDSerI As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtsCodSerIni As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecDocFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents cmdIEMOVFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodDocFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEMOVIni As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodDoc As System.Windows.Forms.Label
    Friend WithEvents cmdAPENDFin As System.Windows.Forms.Button
    Friend WithEvents cmdAPENDIni As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents mtbsCodItmFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbsCodItmIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdGELMOV1Fin As System.Windows.Forms.Button
    Friend WithEvents cmdGELMOV1Ini As System.Windows.Forms.Button
    Friend WithEvents lblCodItm As System.Windows.Forms.Label
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
