<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRODP04
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRODP04))
        Me.txtsEstOdpIni = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmdPEODP_QFEmiFin = New System.Windows.Forms.Button()
        Me.cmdPEODP_QFEmiIni = New System.Windows.Forms.Button()
        Me.txtsEstOdp = New System.Windows.Forms.Label()
        Me.lblsCodDoc = New System.Windows.Forms.Label()
        Me.txtsCodDocFin = New System.Windows.Forms.TextBox()
        Me.cmdLstABODPFin = New System.Windows.Forms.Button()
        Me.txtnNroDocFin = New System.Windows.Forms.TextBox()
        Me.cmdLstABODPIni = New System.Windows.Forms.Button()
        Me.txtsCodDocIni = New System.Windows.Forms.TextBox()
        Me.dtpFecEmiFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecEmiIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecDoc = New System.Windows.Forms.Label()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.cmdLstPEODPFin = New System.Windows.Forms.Button()
        Me.txtsEstOdpFin = New System.Windows.Forms.TextBox()
        Me.cmdLstPEODPIni = New System.Windows.Forms.Button()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.cmdLstABEOPFin = New System.Windows.Forms.Button()
        Me.cmdLstABEOPIni = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdIEMOVIni = New System.Windows.Forms.Button()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsEstOdpIni
        '
        Me.txtsEstOdpIni.Location = New System.Drawing.Point(130, 110)
        Me.txtsEstOdpIni.MaxLength = 20
        Me.txtsEstOdpIni.Name = "txtsEstOdpIni"
        Me.txtsEstOdpIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsEstOdpIni.TabIndex = 45
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFEmiFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPEODP_QFEmiIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstOdp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstOdpIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstABODPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstABODPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecEmiFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecEmiIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblnNroDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstPEODPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstOdpFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstPEODPIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstABEOPFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLstABEOPIni)
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
        Me.SplitContainer1.TabIndex = 589
        '
        'cmdPEODP_QFEmiFin
        '
        Me.cmdPEODP_QFEmiFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFEmiFin.Location = New System.Drawing.Point(440, 134)
        Me.cmdPEODP_QFEmiFin.Name = "cmdPEODP_QFEmiFin"
        Me.cmdPEODP_QFEmiFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFEmiFin.TabIndex = 80
        Me.cmdPEODP_QFEmiFin.Text = "Lst"
        Me.cmdPEODP_QFEmiFin.UseVisualStyleBackColor = False
        '
        'cmdPEODP_QFEmiIni
        '
        Me.cmdPEODP_QFEmiIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP_QFEmiIni.Location = New System.Drawing.Point(255, 134)
        Me.cmdPEODP_QFEmiIni.Name = "cmdPEODP_QFEmiIni"
        Me.cmdPEODP_QFEmiIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdPEODP_QFEmiIni.TabIndex = 70
        Me.cmdPEODP_QFEmiIni.Text = "Lst"
        Me.cmdPEODP_QFEmiIni.UseVisualStyleBackColor = False
        '
        'txtsEstOdp
        '
        Me.txtsEstOdp.AutoSize = True
        Me.txtsEstOdp.Location = New System.Drawing.Point(12, 115)
        Me.txtsEstOdp.Name = "txtsEstOdp"
        Me.txtsEstOdp.Size = New System.Drawing.Size(43, 13)
        Me.txtsEstOdp.TabIndex = 84
        Me.txtsEstOdp.Text = "Estado:"
        '
        'lblsCodDoc
        '
        Me.lblsCodDoc.AutoSize = True
        Me.lblsCodDoc.Location = New System.Drawing.Point(12, 64)
        Me.lblsCodDoc.Name = "lblsCodDoc"
        Me.lblsCodDoc.Size = New System.Drawing.Size(68, 13)
        Me.lblsCodDoc.TabIndex = 83
        Me.lblsCodDoc.Text = "Documento :"
        '
        'txtsCodDocFin
        '
        Me.txtsCodDocFin.Location = New System.Drawing.Point(320, 60)
        Me.txtsCodDocFin.MaxLength = 20
        Me.txtsCodDocFin.Name = "txtsCodDocFin"
        Me.txtsCodDocFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodDocFin.TabIndex = 15
        '
        'cmdLstABODPFin
        '
        Me.cmdLstABODPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABODPFin.Location = New System.Drawing.Point(440, 56)
        Me.cmdLstABODPFin.Name = "cmdLstABODPFin"
        Me.cmdLstABODPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstABODPFin.TabIndex = 20
        Me.cmdLstABODPFin.Text = "Lst"
        Me.cmdLstABODPFin.UseVisualStyleBackColor = False
        '
        'txtnNroDocFin
        '
        Me.txtnNroDocFin.Location = New System.Drawing.Point(320, 85)
        Me.txtnNroDocFin.MaxLength = 20
        Me.txtnNroDocFin.Name = "txtnNroDocFin"
        Me.txtnNroDocFin.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocFin.TabIndex = 35
        '
        'cmdLstABODPIni
        '
        Me.cmdLstABODPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABODPIni.Location = New System.Drawing.Point(255, 56)
        Me.cmdLstABODPIni.Name = "cmdLstABODPIni"
        Me.cmdLstABODPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstABODPIni.TabIndex = 10
        Me.cmdLstABODPIni.Text = "Lst"
        Me.cmdLstABODPIni.UseVisualStyleBackColor = False
        '
        'txtsCodDocIni
        '
        Me.txtsCodDocIni.Location = New System.Drawing.Point(130, 60)
        Me.txtsCodDocIni.MaxLength = 20
        Me.txtsCodDocIni.Name = "txtsCodDocIni"
        Me.txtsCodDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodDocIni.TabIndex = 5
        '
        'dtpFecEmiFin
        '
        Me.dtpFecEmiFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecEmiFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmiFin.Location = New System.Drawing.Point(320, 135)
        Me.dtpFecEmiFin.Name = "dtpFecEmiFin"
        Me.dtpFecEmiFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecEmiFin.TabIndex = 75
        '
        'dtpFecEmiIni
        '
        Me.dtpFecEmiIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecEmiIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmiIni.Location = New System.Drawing.Point(130, 135)
        Me.dtpFecEmiIni.Name = "dtpFecEmiIni"
        Me.dtpFecEmiIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecEmiIni.TabIndex = 65
        '
        'lbldFecDoc
        '
        Me.lbldFecDoc.AutoSize = True
        Me.lbldFecDoc.Location = New System.Drawing.Point(12, 140)
        Me.lbldFecDoc.Name = "lbldFecDoc"
        Me.lbldFecDoc.Size = New System.Drawing.Size(85, 13)
        Me.lbldFecDoc.TabIndex = 64
        Me.lbldFecDoc.Text = "Fecha Emisión  :"
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.AutoSize = True
        Me.lblnNroDoc.Location = New System.Drawing.Point(12, 90)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(47, 13)
        Me.lblnNroDoc.TabIndex = 49
        Me.lblnNroDoc.Text = "Número:"
        '
        'cmdLstPEODPFin
        '
        Me.cmdLstPEODPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODPFin.Location = New System.Drawing.Point(440, 82)
        Me.cmdLstPEODPFin.Name = "cmdLstPEODPFin"
        Me.cmdLstPEODPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstPEODPFin.TabIndex = 40
        Me.cmdLstPEODPFin.Text = "Lst"
        Me.cmdLstPEODPFin.UseVisualStyleBackColor = False
        '
        'txtsEstOdpFin
        '
        Me.txtsEstOdpFin.Location = New System.Drawing.Point(320, 110)
        Me.txtsEstOdpFin.MaxLength = 20
        Me.txtsEstOdpFin.Name = "txtsEstOdpFin"
        Me.txtsEstOdpFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsEstOdpFin.TabIndex = 55
        '
        'cmdLstPEODPIni
        '
        Me.cmdLstPEODPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODPIni.Location = New System.Drawing.Point(255, 82)
        Me.cmdLstPEODPIni.Name = "cmdLstPEODPIni"
        Me.cmdLstPEODPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstPEODPIni.TabIndex = 30
        Me.cmdLstPEODPIni.Text = "Lst"
        Me.cmdLstPEODPIni.UseVisualStyleBackColor = False
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(130, 85)
        Me.txtnNroDocIni.MaxLength = 20
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 25
        '
        'cmdLstABEOPFin
        '
        Me.cmdLstABEOPFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABEOPFin.Location = New System.Drawing.Point(440, 108)
        Me.cmdLstABEOPFin.Name = "cmdLstABEOPFin"
        Me.cmdLstABEOPFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstABEOPFin.TabIndex = 60
        Me.cmdLstABEOPFin.Text = "Lst"
        Me.cmdLstABEOPFin.UseVisualStyleBackColor = False
        '
        'cmdLstABEOPIni
        '
        Me.cmdLstABEOPIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABEOPIni.Location = New System.Drawing.Point(255, 108)
        Me.cmdLstABEOPIni.Name = "cmdLstABEOPIni"
        Me.cmdLstABEOPIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdLstABEOPIni.TabIndex = 50
        Me.cmdLstABEOPIni.Text = "Lst"
        Me.cmdLstABEOPIni.UseVisualStyleBackColor = False
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape2, Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 14
        Me.LineShape6.X2 = 466
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
        Me.LineShape3.X2 = 470
        Me.LineShape3.Y1 = 154
        Me.LineShape3.Y2 = 155
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 459
        Me.LineShape1.Y1 = 77
        Me.LineShape1.Y2 = 78
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 31)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 95
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
        Me.cmdOk.TabIndex = 85
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
        Me.cmdCancelar.TabIndex = 90
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdIEMOVIni
        '
        Me.cmdIEMOVIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEMOVIni.Location = New System.Drawing.Point(255, 82)
        Me.cmdIEMOVIni.Name = "cmdIEMOVIni"
        Me.cmdIEMOVIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEMOVIni.TabIndex = 12
        Me.cmdIEMOVIni.Text = "Lst"
        Me.cmdIEMOVIni.UseVisualStyleBackColor = False
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(130, 135)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocIni.TabIndex = 67
        '
        'frmPRODP04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPRODP04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Requerimientos de Materiales"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsEstOdpIni As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtsCodDocFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdLstABODPFin As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdLstABODPIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodDocIni As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecEmiFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecEmiIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents cmdLstPEODPFin As System.Windows.Forms.Button
    Friend WithEvents txtsEstOdpFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdLstPEODPIni As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents cmdLstABEOPFin As System.Windows.Forms.Button
    Friend WithEvents cmdLstABEOPIni As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblsCodDoc As System.Windows.Forms.Label
    Friend WithEvents txtsEstOdp As System.Windows.Forms.Label
    Friend WithEvents cmdIEMOVIni As System.Windows.Forms.Button
    Friend WithEvents cmdPEODP_QFEmiIni As System.Windows.Forms.Button
    Friend WithEvents cmdPEODP_QFEmiFin As System.Windows.Forms.Button
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
End Class
