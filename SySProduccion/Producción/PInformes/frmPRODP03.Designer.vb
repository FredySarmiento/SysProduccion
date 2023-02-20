<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRODP03
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRODP03))
        Me.txtsCodSerIni = New System.Windows.Forms.TextBox()
        Me.dtpFecDocFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecDoc = New System.Windows.Forms.Label()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.cmdIEMOVFin = New System.Windows.Forms.Button()
        Me.txtsCodTerFin = New System.Windows.Forms.TextBox()
        Me.cmdIEMOVIni = New System.Windows.Forms.Button()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.lblsCodTer = New System.Windows.Forms.Label()
        Me.cmdTEDMTFin = New System.Windows.Forms.Button()
        Me.cmdTEDMTIni = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmdPEODPFin = New System.Windows.Forms.Button()
        Me.cmdPEODPIni = New System.Windows.Forms.Button()
        Me.txtnNroDocBasFin = New System.Windows.Forms.TextBox()
        Me.txtnNroDocBasIni = New System.Windows.Forms.TextBox()
        Me.lblnNroDocBas = New System.Windows.Forms.Label()
        Me.txtsCodTerIni = New System.Windows.Forms.TextBox()
        Me.txtsCodSerFin = New System.Windows.Forms.TextBox()
        Me.lblsCodSer = New System.Windows.Forms.Label()
        Me.cmdAPENDSerF = New System.Windows.Forms.Button()
        Me.txtnNroDocFin = New System.Windows.Forms.TextBox()
        Me.cmdAPENDSerI = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsCodSerIni
        '
        Me.txtsCodSerIni.Location = New System.Drawing.Point(130, 60)
        Me.txtsCodSerIni.MaxLength = 20
        Me.txtsCodSerIni.Name = "txtsCodSerIni"
        Me.txtsCodSerIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerIni.TabIndex = 4
        '
        'dtpFecDocFin
        '
        Me.dtpFecDocFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocFin.Location = New System.Drawing.Point(320, 162)
        Me.dtpFecDocFin.Name = "dtpFecDocFin"
        Me.dtpFecDocFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocFin.TabIndex = 38
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(130, 161)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocIni.TabIndex = 36
        '
        'lbldFecDoc
        '
        Me.lbldFecDoc.AutoSize = True
        Me.lbldFecDoc.Location = New System.Drawing.Point(10, 165)
        Me.lbldFecDoc.Name = "lbldFecDoc"
        Me.lbldFecDoc.Size = New System.Drawing.Size(43, 13)
        Me.lbldFecDoc.TabIndex = 64
        Me.lbldFecDoc.Text = "Fecha :"
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.AutoSize = True
        Me.lblnNroDoc.Location = New System.Drawing.Point(10, 90)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(44, 13)
        Me.lblnNroDoc.TabIndex = 49
        Me.lblnNroDoc.Text = "Número"
        '
        'cmdIEMOVFin
        '
        Me.cmdIEMOVFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEMOVFin.Location = New System.Drawing.Point(440, 83)
        Me.cmdIEMOVFin.Name = "cmdIEMOVFin"
        Me.cmdIEMOVFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEMOVFin.TabIndex = 18
        Me.cmdIEMOVFin.Text = "Lst"
        Me.cmdIEMOVFin.UseVisualStyleBackColor = False
        '
        'txtsCodTerFin
        '
        Me.txtsCodTerFin.Location = New System.Drawing.Point(320, 110)
        Me.txtsCodTerFin.MaxLength = 20
        Me.txtsCodTerFin.Name = "txtsCodTerFin"
        Me.txtsCodTerFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodTerFin.TabIndex = 24
        '
        'cmdIEMOVIni
        '
        Me.cmdIEMOVIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEMOVIni.Location = New System.Drawing.Point(255, 83)
        Me.cmdIEMOVIni.Name = "cmdIEMOVIni"
        Me.cmdIEMOVIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEMOVIni.TabIndex = 14
        Me.cmdIEMOVIni.Text = "Lst"
        Me.cmdIEMOVIni.UseVisualStyleBackColor = False
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(130, 85)
        Me.txtnNroDocIni.MaxLength = 20
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 12
        '
        'lblsCodTer
        '
        Me.lblsCodTer.AutoSize = True
        Me.lblsCodTer.Location = New System.Drawing.Point(10, 115)
        Me.lblsCodTer.Name = "lblsCodTer"
        Me.lblsCodTer.Size = New System.Drawing.Size(47, 13)
        Me.lblsCodTer.TabIndex = 36
        Me.lblsCodTer.Text = "Operario"
        '
        'cmdTEDMTFin
        '
        Me.cmdTEDMTFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdTEDMTFin.Location = New System.Drawing.Point(440, 110)
        Me.cmdTEDMTFin.Name = "cmdTEDMTFin"
        Me.cmdTEDMTFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdTEDMTFin.TabIndex = 26
        Me.cmdTEDMTFin.Text = "Lst"
        Me.cmdTEDMTFin.UseVisualStyleBackColor = False
        '
        'cmdTEDMTIni
        '
        Me.cmdTEDMTIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdTEDMTIni.Location = New System.Drawing.Point(255, 108)
        Me.cmdTEDMTIni.Name = "cmdTEDMTIni"
        Me.cmdTEDMTIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdTEDMTIni.TabIndex = 22
        Me.cmdTEDMTIni.Text = "Lst"
        Me.cmdTEDMTIni.UseVisualStyleBackColor = False
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocBasFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocBasIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblnNroDocBas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodTerIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodSerFin)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodTerFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEMOVIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodTer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTEDMTFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTEDMTIni)
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
        Me.SplitContainer1.TabIndex = 588
        '
        'cmdPEODPFin
        '
        Me.cmdPEODPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODPFin.Location = New System.Drawing.Point(439, 134)
        Me.cmdPEODPFin.Name = "cmdPEODPFin"
        Me.cmdPEODPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODPFin.TabIndex = 34
        Me.cmdPEODPFin.Text = "Lst"
        Me.cmdPEODPFin.UseVisualStyleBackColor = False
        '
        'cmdPEODPIni
        '
        Me.cmdPEODPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODPIni.Location = New System.Drawing.Point(255, 133)
        Me.cmdPEODPIni.Name = "cmdPEODPIni"
        Me.cmdPEODPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODPIni.TabIndex = 30
        Me.cmdPEODPIni.Text = "Lst"
        Me.cmdPEODPIni.UseVisualStyleBackColor = False
        '
        'txtnNroDocBasFin
        '
        Me.txtnNroDocBasFin.Location = New System.Drawing.Point(320, 134)
        Me.txtnNroDocBasFin.MaxLength = 20
        Me.txtnNroDocBasFin.Name = "txtnNroDocBasFin"
        Me.txtnNroDocBasFin.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocBasFin.TabIndex = 32
        '
        'txtnNroDocBasIni
        '
        Me.txtnNroDocBasIni.Location = New System.Drawing.Point(130, 135)
        Me.txtnNroDocBasIni.MaxLength = 20
        Me.txtnNroDocBasIni.Name = "txtnNroDocBasIni"
        Me.txtnNroDocBasIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocBasIni.TabIndex = 28
        '
        'lblnNroDocBas
        '
        Me.lblnNroDocBas.AutoSize = True
        Me.lblnNroDocBas.Location = New System.Drawing.Point(10, 140)
        Me.lblnNroDocBas.Name = "lblnNroDocBas"
        Me.lblnNroDocBas.Size = New System.Drawing.Size(62, 13)
        Me.lblnNroDocBas.TabIndex = 83
        Me.lblnNroDocBas.Text = "Número OP"
        '
        'txtsCodTerIni
        '
        Me.txtsCodTerIni.Location = New System.Drawing.Point(130, 110)
        Me.txtsCodTerIni.MaxLength = 20
        Me.txtsCodTerIni.Name = "txtsCodTerIni"
        Me.txtsCodTerIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodTerIni.TabIndex = 20
        '
        'txtsCodSerFin
        '
        Me.txtsCodSerFin.Location = New System.Drawing.Point(320, 61)
        Me.txtsCodSerFin.MaxLength = 20
        Me.txtsCodSerFin.Name = "txtsCodSerFin"
        Me.txtsCodSerFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerFin.TabIndex = 8
        '
        'lblsCodSer
        '
        Me.lblsCodSer.AutoSize = True
        Me.lblsCodSer.Location = New System.Drawing.Point(10, 65)
        Me.lblsCodSer.Name = "lblsCodSer"
        Me.lblsCodSer.Size = New System.Drawing.Size(31, 13)
        Me.lblsCodSer.TabIndex = 73
        Me.lblsCodSer.Text = "Serie"
        '
        'cmdAPENDSerF
        '
        Me.cmdAPENDSerF.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDSerF.Location = New System.Drawing.Point(440, 58)
        Me.cmdAPENDSerF.Name = "cmdAPENDSerF"
        Me.cmdAPENDSerF.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDSerF.TabIndex = 10
        Me.cmdAPENDSerF.Text = "Lst"
        Me.cmdAPENDSerF.UseVisualStyleBackColor = False
        '
        'txtnNroDocFin
        '
        Me.txtnNroDocFin.Location = New System.Drawing.Point(320, 85)
        Me.txtnNroDocFin.MaxLength = 20
        Me.txtnNroDocFin.Name = "txtnNroDocFin"
        Me.txtnNroDocFin.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocFin.TabIndex = 16
        '
        'cmdAPENDSerI
        '
        Me.cmdAPENDSerI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDSerI.Location = New System.Drawing.Point(255, 58)
        Me.cmdAPENDSerI.Name = "cmdAPENDSerI"
        Me.cmdAPENDSerI.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDSerI.TabIndex = 6
        Me.cmdAPENDSerI.Text = "Lst"
        Me.cmdAPENDSerI.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape6, Me.LineShape2, Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 11
        Me.LineShape4.X2 = 419
        Me.LineShape4.Y1 = 178
        Me.LineShape4.Y2 = 179
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 15
        Me.LineShape6.X2 = 461
        Me.LineShape6.Y1 = 128
        Me.LineShape6.Y2 = 129
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
        Me.LineShape3.X2 = 423
        Me.LineShape3.Y1 = 152
        Me.LineShape3.Y2 = 153
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
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 31)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 44
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
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
        Me.cmdOk.TabIndex = 40
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
        Me.cmdCancelar.TabIndex = 42
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmPRODP03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPRODP03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de consumos de MDO y CIF"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsCodSerIni As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecDocFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents cmdIEMOVFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodTerFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEMOVIni As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodTer As System.Windows.Forms.Label
    Friend WithEvents cmdTEDMTFin As System.Windows.Forms.Button
    Friend WithEvents cmdTEDMTIni As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtsCodTerIni As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodSerFin As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodSer As System.Windows.Forms.Label
    Friend WithEvents cmdAPENDSerF As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdAPENDSerI As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdPEODPFin As System.Windows.Forms.Button
    Friend WithEvents cmdPEODPIni As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocBasFin As System.Windows.Forms.TextBox
    Friend WithEvents txtnNroDocBasIni As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDocBas As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
