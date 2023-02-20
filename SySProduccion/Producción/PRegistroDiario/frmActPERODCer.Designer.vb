<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActPERODCer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActPERODCer))
        Me.txtsCodTerIni = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtdHHMM = New System.Windows.Forms.TextBox()
        Me.txtnMMFinOpe = New System.Windows.Forms.TextBox()
        Me.txtnHHFinOpe = New System.Windows.Forms.TextBox()
        Me.lblMMFin = New System.Windows.Forms.Label()
        Me.lblHHFin = New System.Windows.Forms.Label()
        Me.lblHHMMCie = New System.Windows.Forms.Label()
        Me.txtsEstDocIni = New System.Windows.Forms.TextBox()
        Me.lblsEstDoc = New System.Windows.Forms.Label()
        Me.lblsCodSer = New System.Windows.Forms.Label()
        Me.cmdAPENDSerI = New System.Windows.Forms.Button()
        Me.txtsCodSerIni = New System.Windows.Forms.TextBox()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecDoc = New System.Windows.Forms.Label()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.cmdIEMOVIni = New System.Windows.Forms.Button()
        Me.txtnNroDocIni = New System.Windows.Forms.TextBox()
        Me.lblsCodTer = New System.Windows.Forms.Label()
        Me.cmdTEDMTIni = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsCodTerIni
        '
        Me.txtsCodTerIni.Location = New System.Drawing.Point(218, 83)
        Me.txtsCodTerIni.MaxLength = 20
        Me.txtsCodTerIni.Name = "txtsCodTerIni"
        Me.txtsCodTerIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodTerIni.TabIndex = 25
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtdHHMM)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnMMFinOpe)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnHHFinOpe)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMMFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHHFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHHMMCie)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsEstDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsEstDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodTerIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodSer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdAPENDSerI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodSerIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblnNroDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEMOVIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtnNroDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodTer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdTEDMTIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdActualizar)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 305)
        Me.SplitContainer1.SplitterDistance = 237
        Me.SplitContainer1.TabIndex = 590
        '
        'txtdHHMM
        '
        Me.txtdHHMM.BackColor = System.Drawing.SystemColors.Window
        Me.txtdHHMM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdHHMM.Enabled = False
        Me.txtdHHMM.Location = New System.Drawing.Point(218, 170)
        Me.txtdHHMM.MaxLength = 12
        Me.txtdHHMM.Name = "txtdHHMM"
        Me.txtdHHMM.Size = New System.Drawing.Size(63, 20)
        Me.txtdHHMM.TabIndex = 45
        '
        'txtnMMFinOpe
        '
        Me.txtnMMFinOpe.BackColor = System.Drawing.SystemColors.Window
        Me.txtnMMFinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnMMFinOpe.Location = New System.Drawing.Point(418, 170)
        Me.txtnMMFinOpe.MaxLength = 2
        Me.txtnMMFinOpe.Name = "txtnMMFinOpe"
        Me.txtnMMFinOpe.Size = New System.Drawing.Size(20, 20)
        Me.txtnMMFinOpe.TabIndex = 55
        '
        'txtnHHFinOpe
        '
        Me.txtnHHFinOpe.BackColor = System.Drawing.SystemColors.Window
        Me.txtnHHFinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnHHFinOpe.Location = New System.Drawing.Point(338, 170)
        Me.txtnHHFinOpe.MaxLength = 2
        Me.txtnHHFinOpe.Name = "txtnHHFinOpe"
        Me.txtnHHFinOpe.Size = New System.Drawing.Size(20, 20)
        Me.txtnHHFinOpe.TabIndex = 50
        '
        'lblMMFin
        '
        Me.lblMMFin.AutoSize = True
        Me.lblMMFin.Location = New System.Drawing.Point(376, 176)
        Me.lblMMFin.Name = "lblMMFin"
        Me.lblMMFin.Size = New System.Drawing.Size(28, 13)
        Me.lblMMFin.TabIndex = 78
        Me.lblMMFin.Text = "MM:"
        '
        'lblHHFin
        '
        Me.lblHHFin.AutoSize = True
        Me.lblHHFin.Location = New System.Drawing.Point(299, 176)
        Me.lblHHFin.Name = "lblHHFin"
        Me.lblHHFin.Size = New System.Drawing.Size(29, 13)
        Me.lblHHFin.TabIndex = 77
        Me.lblHHFin.Text = "HH :"
        '
        'lblHHMMCie
        '
        Me.lblHHMMCie.AutoSize = True
        Me.lblHHMMCie.Location = New System.Drawing.Point(98, 174)
        Me.lblHHMMCie.Name = "lblHHMMCie"
        Me.lblHHMMCie.Size = New System.Drawing.Size(75, 13)
        Me.lblHHMMCie.TabIndex = 76
        Me.lblHHMMCie.Text = "Hora de Cierre"
        '
        'txtsEstDocIni
        '
        Me.txtsEstDocIni.Location = New System.Drawing.Point(218, 109)
        Me.txtsEstDocIni.MaxLength = 20
        Me.txtsEstDocIni.Name = "txtsEstDocIni"
        Me.txtsEstDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsEstDocIni.TabIndex = 35
        '
        'lblsEstDoc
        '
        Me.lblsEstDoc.AutoSize = True
        Me.lblsEstDoc.Location = New System.Drawing.Point(98, 114)
        Me.lblsEstDoc.Name = "lblsEstDoc"
        Me.lblsEstDoc.Size = New System.Drawing.Size(43, 13)
        Me.lblsEstDoc.TabIndex = 75
        Me.lblsEstDoc.Text = "Estado:"
        '
        'lblsCodSer
        '
        Me.lblsCodSer.AutoSize = True
        Me.lblsCodSer.Location = New System.Drawing.Point(98, 38)
        Me.lblsCodSer.Name = "lblsCodSer"
        Me.lblsCodSer.Size = New System.Drawing.Size(31, 13)
        Me.lblsCodSer.TabIndex = 73
        Me.lblsCodSer.Text = "Serie"
        '
        'cmdAPENDSerI
        '
        Me.cmdAPENDSerI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAPENDSerI.Location = New System.Drawing.Point(343, 31)
        Me.cmdAPENDSerI.Name = "cmdAPENDSerI"
        Me.cmdAPENDSerI.Size = New System.Drawing.Size(30, 23)
        Me.cmdAPENDSerI.TabIndex = 10
        Me.cmdAPENDSerI.Text = "Lst"
        Me.cmdAPENDSerI.UseVisualStyleBackColor = False
        '
        'txtsCodSerIni
        '
        Me.txtsCodSerIni.Location = New System.Drawing.Point(218, 34)
        Me.txtsCodSerIni.MaxLength = 20
        Me.txtsCodSerIni.Name = "txtsCodSerIni"
        Me.txtsCodSerIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodSerIni.TabIndex = 5
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(218, 140)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocIni.TabIndex = 40
        '
        'lbldFecDoc
        '
        Me.lbldFecDoc.AutoSize = True
        Me.lbldFecDoc.Location = New System.Drawing.Point(98, 144)
        Me.lbldFecDoc.Name = "lbldFecDoc"
        Me.lbldFecDoc.Size = New System.Drawing.Size(43, 13)
        Me.lbldFecDoc.TabIndex = 64
        Me.lbldFecDoc.Text = "Fecha :"
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.AutoSize = True
        Me.lblnNroDoc.Location = New System.Drawing.Point(98, 63)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(44, 13)
        Me.lblnNroDoc.TabIndex = 49
        Me.lblnNroDoc.Text = "Número"
        '
        'cmdIEMOVIni
        '
        Me.cmdIEMOVIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEMOVIni.Location = New System.Drawing.Point(343, 56)
        Me.cmdIEMOVIni.Name = "cmdIEMOVIni"
        Me.cmdIEMOVIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEMOVIni.TabIndex = 20
        Me.cmdIEMOVIni.Text = "Lst"
        Me.cmdIEMOVIni.UseVisualStyleBackColor = False
        '
        'txtnNroDocIni
        '
        Me.txtnNroDocIni.Location = New System.Drawing.Point(218, 58)
        Me.txtnNroDocIni.MaxLength = 20
        Me.txtnNroDocIni.Name = "txtnNroDocIni"
        Me.txtnNroDocIni.Size = New System.Drawing.Size(108, 20)
        Me.txtnNroDocIni.TabIndex = 15
        '
        'lblsCodTer
        '
        Me.lblsCodTer.AutoSize = True
        Me.lblsCodTer.Location = New System.Drawing.Point(98, 88)
        Me.lblsCodTer.Name = "lblsCodTer"
        Me.lblsCodTer.Size = New System.Drawing.Size(47, 13)
        Me.lblsCodTer.TabIndex = 36
        Me.lblsCodTer.Text = "Operario"
        '
        'cmdTEDMTIni
        '
        Me.cmdTEDMTIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdTEDMTIni.Location = New System.Drawing.Point(343, 81)
        Me.cmdTEDMTIni.Name = "cmdTEDMTIni"
        Me.cmdTEDMTIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdTEDMTIni.TabIndex = 30
        Me.cmdTEDMTIni.Text = "Lst"
        Me.cmdTEDMTIni.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape3, Me.LineShape4, Me.LineShape6, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 237)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 98
        Me.LineShape5.X2 = 434
        Me.LineShape5.Y1 = 188
        Me.LineShape5.Y2 = 189
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 103
        Me.LineShape3.X2 = 321
        Me.LineShape3.Y1 = 128
        Me.LineShape3.Y2 = 128
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 100
        Me.LineShape4.X2 = 323
        Me.LineShape4.Y1 = 160
        Me.LineShape4.Y2 = 159
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 104
        Me.LineShape6.X2 = 370
        Me.LineShape6.Y1 = 102
        Me.LineShape6.Y2 = 103
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 103
        Me.LineShape2.X2 = 370
        Me.LineShape2.Y1 = 77
        Me.LineShape2.Y2 = 77
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 102
        Me.LineShape1.X2 = 368
        Me.LineShape1.Y1 = 53
        Me.LineShape1.Y2 = 53
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(406, 30)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 75
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(3, 30)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 60
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(84, 30)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 70
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(3, 30)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 65
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmActPERODCer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 305)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActPERODCer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cerrar Registros Diarios de Operación"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsCodTerIni As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblsCodSer As System.Windows.Forms.Label
    Friend WithEvents cmdAPENDSerI As System.Windows.Forms.Button
    Friend WithEvents txtsCodSerIni As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents cmdIEMOVIni As System.Windows.Forms.Button
    Friend WithEvents txtnNroDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodTer As System.Windows.Forms.Label
    Friend WithEvents cmdTEDMTIni As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtsEstDocIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsEstDoc As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblHHFin As System.Windows.Forms.Label
    Friend WithEvents lblHHMMCie As System.Windows.Forms.Label
    Friend WithEvents lblMMFin As System.Windows.Forms.Label
    Friend WithEvents txtnMMFinOpe As System.Windows.Forms.TextBox
    Friend WithEvents txtnHHFinOpe As System.Windows.Forms.TextBox
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtdHHMM As System.Windows.Forms.TextBox
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
End Class
