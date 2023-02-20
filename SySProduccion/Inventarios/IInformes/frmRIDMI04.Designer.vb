<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRIDMI04
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRIDMI04))
        Me.chbbImpItmCero = New System.Windows.Forms.CheckBox()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecFin = New System.Windows.Forms.Label()
        Me.dtpFecDocFin = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecIni = New System.Windows.Forms.Label()
        Me.chbbImpItmInac = New System.Windows.Forms.CheckBox()
        Me.txtsImpItmCero = New System.Windows.Forms.Label()
        Me.txtbImpAct = New System.Windows.Forms.Label()
        Me.lblsCodGrp = New System.Windows.Forms.Label()
        Me.cmdIEDMI_QGrpFin = New System.Windows.Forms.Button()
        Me.txtsCodGrpFin = New System.Windows.Forms.TextBox()
        Me.cmdIEDMI_QGrpIni = New System.Windows.Forms.Button()
        Me.txtsCodGrpIni = New System.Windows.Forms.TextBox()
        Me.lblsCodItm = New System.Windows.Forms.Label()
        Me.cmdIEDMI_QItmFin = New System.Windows.Forms.Button()
        Me.txtsCodItmFin = New System.Windows.Forms.TextBox()
        Me.cmdIEDMI_QItmIni = New System.Windows.Forms.Button()
        Me.txtsCodItmIni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblsCodAlm = New System.Windows.Forms.Label()
        Me.cmdIEDMI_QAlmFin = New System.Windows.Forms.Button()
        Me.txtsCodAlmFin = New System.Windows.Forms.TextBox()
        Me.cmdIEDMI_QAlmIni = New System.Windows.Forms.Button()
        Me.txtsCodAlmIni = New System.Windows.Forms.TextBox()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbbImpItmCero
        '
        Me.chbbImpItmCero.AutoSize = True
        Me.chbbImpItmCero.Location = New System.Drawing.Point(175, 224)
        Me.chbbImpItmCero.Name = "chbbImpItmCero"
        Me.chbbImpItmCero.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpItmCero.TabIndex = 67
        Me.chbbImpItmCero.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodAlm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QAlmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodAlmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QAlmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodAlmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbbImpItmCero)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbbImpItmInac)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsImpItmCero)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtbImpAct)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodGrp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QGrpFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodGrpFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QGrpIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodGrpIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodItm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodItmIni)
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
        Me.SplitContainer1.TabIndex = 586
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Enabled = False
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(129, 150)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecDocIni.TabIndex = 70
        '
        'lbldFecFin
        '
        Me.lbldFecFin.AutoSize = True
        Me.lbldFecFin.Location = New System.Drawing.Point(246, 154)
        Me.lbldFecFin.Name = "lbldFecFin"
        Me.lbldFecFin.Size = New System.Drawing.Size(71, 13)
        Me.lbldFecFin.TabIndex = 71
        Me.lbldFecFin.Text = "Fecha Corte :"
        '
        'dtpFecDocFin
        '
        Me.dtpFecDocFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocFin.Location = New System.Drawing.Point(330, 149)
        Me.dtpFecDocFin.Name = "dtpFecDocFin"
        Me.dtpFecDocFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecDocFin.TabIndex = 68
        '
        'lbldFecIni
        '
        Me.lbldFecIni.AutoSize = True
        Me.lbldFecIni.Location = New System.Drawing.Point(15, 156)
        Me.lbldFecIni.Name = "lbldFecIni"
        Me.lbldFecIni.Size = New System.Drawing.Size(91, 13)
        Me.lbldFecIni.TabIndex = 69
        Me.lbldFecIni.Text = "Fecha Inicial Inv.:"
        '
        'chbbImpItmInac
        '
        Me.chbbImpItmInac.AutoSize = True
        Me.chbbImpItmInac.Location = New System.Drawing.Point(175, 197)
        Me.chbbImpItmInac.Name = "chbbImpItmInac"
        Me.chbbImpItmInac.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpItmInac.TabIndex = 66
        Me.chbbImpItmInac.UseVisualStyleBackColor = True
        '
        'txtsImpItmCero
        '
        Me.txtsImpItmCero.AutoSize = True
        Me.txtsImpItmCero.Location = New System.Drawing.Point(15, 223)
        Me.txtsImpItmCero.Name = "txtsImpItmCero"
        Me.txtsImpItmCero.Size = New System.Drawing.Size(144, 13)
        Me.txtsImpItmCero.TabIndex = 65
        Me.txtsImpItmCero.Text = "Imprimir ítems con saldo cero"
        '
        'txtbImpAct
        '
        Me.txtbImpAct.AutoSize = True
        Me.txtbImpAct.Location = New System.Drawing.Point(15, 197)
        Me.txtbImpAct.Name = "txtbImpAct"
        Me.txtbImpAct.Size = New System.Drawing.Size(116, 13)
        Me.txtbImpAct.TabIndex = 64
        Me.txtbImpAct.Text = "Imprimir ítems inactivos"
        '
        'lblsCodGrp
        '
        Me.lblsCodGrp.AutoSize = True
        Me.lblsCodGrp.Location = New System.Drawing.Point(15, 86)
        Me.lblsCodGrp.Name = "lblsCodGrp"
        Me.lblsCodGrp.Size = New System.Drawing.Size(36, 13)
        Me.lblsCodGrp.TabIndex = 54
        Me.lblsCodGrp.Text = "Grupo"
        '
        'cmdIEDMI_QGrpFin
        '
        Me.cmdIEDMI_QGrpFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QGrpFin.Location = New System.Drawing.Point(444, 78)
        Me.cmdIEDMI_QGrpFin.Name = "cmdIEDMI_QGrpFin"
        Me.cmdIEDMI_QGrpFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QGrpFin.TabIndex = 58
        Me.cmdIEDMI_QGrpFin.Text = "Lst"
        Me.cmdIEDMI_QGrpFin.UseVisualStyleBackColor = False
        '
        'txtsCodGrpFin
        '
        Me.txtsCodGrpFin.Location = New System.Drawing.Point(330, 81)
        Me.txtsCodGrpFin.MaxLength = 20
        Me.txtsCodGrpFin.Name = "txtsCodGrpFin"
        Me.txtsCodGrpFin.Size = New System.Drawing.Size(94, 20)
        Me.txtsCodGrpFin.TabIndex = 57
        '
        'cmdIEDMI_QGrpIni
        '
        Me.cmdIEDMI_QGrpIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QGrpIni.Location = New System.Drawing.Point(245, 78)
        Me.cmdIEDMI_QGrpIni.Name = "cmdIEDMI_QGrpIni"
        Me.cmdIEDMI_QGrpIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QGrpIni.TabIndex = 56
        Me.cmdIEDMI_QGrpIni.Text = "Lst"
        Me.cmdIEDMI_QGrpIni.UseVisualStyleBackColor = False
        '
        'txtsCodGrpIni
        '
        Me.txtsCodGrpIni.Location = New System.Drawing.Point(130, 80)
        Me.txtsCodGrpIni.MaxLength = 20
        Me.txtsCodGrpIni.Name = "txtsCodGrpIni"
        Me.txtsCodGrpIni.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodGrpIni.TabIndex = 55
        '
        'lblsCodItm
        '
        Me.lblsCodItm.AutoSize = True
        Me.lblsCodItm.Location = New System.Drawing.Point(15, 120)
        Me.lblsCodItm.Name = "lblsCodItm"
        Me.lblsCodItm.Size = New System.Drawing.Size(27, 13)
        Me.lblsCodItm.TabIndex = 36
        Me.lblsCodItm.Text = "Ítem"
        '
        'cmdIEDMI_QItmFin
        '
        Me.cmdIEDMI_QItmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QItmFin.Location = New System.Drawing.Point(444, 113)
        Me.cmdIEDMI_QItmFin.Name = "cmdIEDMI_QItmFin"
        Me.cmdIEDMI_QItmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QItmFin.TabIndex = 48
        Me.cmdIEDMI_QItmFin.Text = "Lst"
        Me.cmdIEDMI_QItmFin.UseVisualStyleBackColor = False
        '
        'txtsCodItmFin
        '
        Me.txtsCodItmFin.Location = New System.Drawing.Point(330, 115)
        Me.txtsCodItmFin.MaxLength = 20
        Me.txtsCodItmFin.Name = "txtsCodItmFin"
        Me.txtsCodItmFin.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodItmFin.TabIndex = 46
        '
        'cmdIEDMI_QItmIni
        '
        Me.cmdIEDMI_QItmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QItmIni.Location = New System.Drawing.Point(245, 113)
        Me.cmdIEDMI_QItmIni.Name = "cmdIEDMI_QItmIni"
        Me.cmdIEDMI_QItmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QItmIni.TabIndex = 44
        Me.cmdIEDMI_QItmIni.Text = "Lst"
        Me.cmdIEDMI_QItmIni.UseVisualStyleBackColor = False
        '
        'txtsCodItmIni
        '
        Me.txtsCodItmIni.Location = New System.Drawing.Point(130, 115)
        Me.txtsCodItmIni.MaxLength = 20
        Me.txtsCodItmIni.Name = "txtsCodItmIni"
        Me.txtsCodItmIni.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodItmIni.TabIndex = 42
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
        Me.Label1.Location = New System.Drawing.Point(153, 10)
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape4, Me.LineShape3, Me.LineShape1, Me.LineShape2, Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 421
        Me.LineShape1.Y1 = 169
        Me.LineShape1.Y2 = 168
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 15
        Me.LineShape2.X2 = 461
        Me.LineShape2.Y1 = 98
        Me.LineShape2.Y2 = 99
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 15
        Me.LineShape5.X2 = 461
        Me.LineShape5.Y1 = 63
        Me.LineShape5.Y2 = 64
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
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 13
        Me.LineShape3.X2 = 186
        Me.LineShape3.Y1 = 210
        Me.LineShape3.Y2 = 209
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 14
        Me.LineShape4.X2 = 189
        Me.LineShape4.Y1 = 236
        Me.LineShape4.Y2 = 236
        '
        'lblsCodAlm
        '
        Me.lblsCodAlm.AutoSize = True
        Me.lblsCodAlm.Location = New System.Drawing.Point(15, 50)
        Me.lblsCodAlm.Name = "lblsCodAlm"
        Me.lblsCodAlm.Size = New System.Drawing.Size(48, 13)
        Me.lblsCodAlm.TabIndex = 72
        Me.lblsCodAlm.Text = "Almacén"
        '
        'cmdIEDMI_QAlmFin
        '
        Me.cmdIEDMI_QAlmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QAlmFin.Location = New System.Drawing.Point(444, 43)
        Me.cmdIEDMI_QAlmFin.Name = "cmdIEDMI_QAlmFin"
        Me.cmdIEDMI_QAlmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QAlmFin.TabIndex = 20
        Me.cmdIEDMI_QAlmFin.Text = "Lst"
        Me.cmdIEDMI_QAlmFin.UseVisualStyleBackColor = False
        '
        'txtsCodAlmFin
        '
        Me.txtsCodAlmFin.Location = New System.Drawing.Point(330, 45)
        Me.txtsCodAlmFin.MaxLength = 20
        Me.txtsCodAlmFin.Name = "txtsCodAlmFin"
        Me.txtsCodAlmFin.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodAlmFin.TabIndex = 15
        '
        'cmdIEDMI_QAlmIni
        '
        Me.cmdIEDMI_QAlmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QAlmIni.Location = New System.Drawing.Point(245, 43)
        Me.cmdIEDMI_QAlmIni.Name = "cmdIEDMI_QAlmIni"
        Me.cmdIEDMI_QAlmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QAlmIni.TabIndex = 10
        Me.cmdIEDMI_QAlmIni.Text = "Lst"
        Me.cmdIEDMI_QAlmIni.UseVisualStyleBackColor = False
        '
        'txtsCodAlmIni
        '
        Me.txtsCodAlmIni.Location = New System.Drawing.Point(130, 45)
        Me.txtsCodAlmIni.MaxLength = 20
        Me.txtsCodAlmIni.Name = "txtsCodAlmIni"
        Me.txtsCodAlmIni.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodAlmIni.TabIndex = 5
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 19
        Me.LineShape6.X2 = 465
        Me.LineShape6.Y1 = 133
        Me.LineShape6.Y2 = 134
        '
        'frmRIDMI04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRIDMI04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Saldos Inventarios fechas anteriores"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chbbImpItmCero As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chbbImpItmInac As System.Windows.Forms.CheckBox
    Friend WithEvents txtsImpItmCero As System.Windows.Forms.Label
    Friend WithEvents txtbImpAct As System.Windows.Forms.Label
    Friend WithEvents lblsCodGrp As System.Windows.Forms.Label
    Friend WithEvents cmdIEDMI_QGrpFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodGrpFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEDMI_QGrpIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodGrpIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodItm As System.Windows.Forms.Label
    Friend WithEvents cmdIEDMI_QItmFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodItmFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEDMI_QItmIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodItmIni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents dtpFecDocFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecIni As System.Windows.Forms.Label
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecFin As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblsCodAlm As System.Windows.Forms.Label
    Friend WithEvents cmdIEDMI_QAlmFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlmFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEDMI_QAlmIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlmIni As System.Windows.Forms.TextBox
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
