<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRIDMI01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRIDMI01))
        Me.lblsCodItm = New System.Windows.Forms.Label()
        Me.cmdIEDMI_QItmFin = New System.Windows.Forms.Button()
        Me.txtsCodItmFin = New System.Windows.Forms.TextBox()
        Me.cmdIEDMI_QItmIni = New System.Windows.Forms.Button()
        Me.txtsCodItmIni = New System.Windows.Forms.TextBox()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblsCodGrp = New System.Windows.Forms.Label()
        Me.cmdIEDMI_QGrpFin = New System.Windows.Forms.Button()
        Me.txtsCodGrpFin = New System.Windows.Forms.TextBox()
        Me.cmdIEDMI_QGrpIni = New System.Windows.Forms.Button()
        Me.txtsCodGrpIni = New System.Windows.Forms.TextBox()
        Me.lblsCodAlm = New System.Windows.Forms.Label()
        Me.cmdIEDMI_QAlmFin = New System.Windows.Forms.Button()
        Me.txtsCodAlmFin = New System.Windows.Forms.TextBox()
        Me.cmdIEDMI_QAlmIni = New System.Windows.Forms.Button()
        Me.txtsCodAlmIni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtbImpAct = New System.Windows.Forms.Label()
        Me.txtsImpItmCero = New System.Windows.Forms.Label()
        Me.chbbImpItmInac = New System.Windows.Forms.CheckBox()
        Me.chbbImpItmCero = New System.Windows.Forms.CheckBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblsCodItm
        '
        Me.lblsCodItm.AutoSize = True
        Me.lblsCodItm.Location = New System.Drawing.Point(14, 41)
        Me.lblsCodItm.Name = "lblsCodItm"
        Me.lblsCodItm.Size = New System.Drawing.Size(27, 13)
        Me.lblsCodItm.TabIndex = 36
        Me.lblsCodItm.Text = "Ítem"
        '
        'cmdIEDMI_QItmFin
        '
        Me.cmdIEDMI_QItmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QItmFin.Location = New System.Drawing.Point(441, 34)
        Me.cmdIEDMI_QItmFin.Name = "cmdIEDMI_QItmFin"
        Me.cmdIEDMI_QItmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QItmFin.TabIndex = 48
        Me.cmdIEDMI_QItmFin.Text = "Lst"
        Me.cmdIEDMI_QItmFin.UseVisualStyleBackColor = False
        '
        'txtsCodItmFin
        '
        Me.txtsCodItmFin.Location = New System.Drawing.Point(324, 36)
        Me.txtsCodItmFin.MaxLength = 20
        Me.txtsCodItmFin.Name = "txtsCodItmFin"
        Me.txtsCodItmFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodItmFin.TabIndex = 46
        '
        'cmdIEDMI_QItmIni
        '
        Me.cmdIEDMI_QItmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QItmIni.Location = New System.Drawing.Point(252, 34)
        Me.cmdIEDMI_QItmIni.Name = "cmdIEDMI_QItmIni"
        Me.cmdIEDMI_QItmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QItmIni.TabIndex = 44
        Me.cmdIEDMI_QItmIni.Text = "Lst"
        Me.cmdIEDMI_QItmIni.UseVisualStyleBackColor = False
        '
        'txtsCodItmIni
        '
        Me.txtsCodItmIni.Location = New System.Drawing.Point(129, 36)
        Me.txtsCodItmIni.MaxLength = 20
        Me.txtsCodItmIni.Name = "txtsCodItmIni"
        Me.txtsCodItmIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodItmIni.TabIndex = 42
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbbImpItmCero)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbbImpItmInac)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsImpItmCero)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtbImpAct)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodGrp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QGrpFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodGrpFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QGrpIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodGrpIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodAlm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QAlmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodAlmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMI_QAlmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodAlmIni)
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
        Me.SplitContainer1.TabIndex = 584
        '
        'lblsCodGrp
        '
        Me.lblsCodGrp.AutoSize = True
        Me.lblsCodGrp.Location = New System.Drawing.Point(14, 115)
        Me.lblsCodGrp.Name = "lblsCodGrp"
        Me.lblsCodGrp.Size = New System.Drawing.Size(36, 13)
        Me.lblsCodGrp.TabIndex = 54
        Me.lblsCodGrp.Text = "Grupo"
        '
        'cmdIEDMI_QGrpFin
        '
        Me.cmdIEDMI_QGrpFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QGrpFin.Location = New System.Drawing.Point(442, 108)
        Me.cmdIEDMI_QGrpFin.Name = "cmdIEDMI_QGrpFin"
        Me.cmdIEDMI_QGrpFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QGrpFin.TabIndex = 58
        Me.cmdIEDMI_QGrpFin.Text = "Lst"
        Me.cmdIEDMI_QGrpFin.UseVisualStyleBackColor = False
        '
        'txtsCodGrpFin
        '
        Me.txtsCodGrpFin.Location = New System.Drawing.Point(325, 110)
        Me.txtsCodGrpFin.MaxLength = 20
        Me.txtsCodGrpFin.Name = "txtsCodGrpFin"
        Me.txtsCodGrpFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodGrpFin.TabIndex = 57
        '
        'cmdIEDMI_QGrpIni
        '
        Me.cmdIEDMI_QGrpIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QGrpIni.Location = New System.Drawing.Point(252, 108)
        Me.cmdIEDMI_QGrpIni.Name = "cmdIEDMI_QGrpIni"
        Me.cmdIEDMI_QGrpIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QGrpIni.TabIndex = 56
        Me.cmdIEDMI_QGrpIni.Text = "Lst"
        Me.cmdIEDMI_QGrpIni.UseVisualStyleBackColor = False
        '
        'txtsCodGrpIni
        '
        Me.txtsCodGrpIni.Location = New System.Drawing.Point(129, 110)
        Me.txtsCodGrpIni.MaxLength = 20
        Me.txtsCodGrpIni.Name = "txtsCodGrpIni"
        Me.txtsCodGrpIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodGrpIni.TabIndex = 55
        '
        'lblsCodAlm
        '
        Me.lblsCodAlm.AutoSize = True
        Me.lblsCodAlm.Location = New System.Drawing.Point(14, 77)
        Me.lblsCodAlm.Name = "lblsCodAlm"
        Me.lblsCodAlm.Size = New System.Drawing.Size(48, 13)
        Me.lblsCodAlm.TabIndex = 49
        Me.lblsCodAlm.Text = "Almacén"
        '
        'cmdIEDMI_QAlmFin
        '
        Me.cmdIEDMI_QAlmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QAlmFin.Location = New System.Drawing.Point(442, 70)
        Me.cmdIEDMI_QAlmFin.Name = "cmdIEDMI_QAlmFin"
        Me.cmdIEDMI_QAlmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QAlmFin.TabIndex = 53
        Me.cmdIEDMI_QAlmFin.Text = "Lst"
        Me.cmdIEDMI_QAlmFin.UseVisualStyleBackColor = False
        '
        'txtsCodAlmFin
        '
        Me.txtsCodAlmFin.Location = New System.Drawing.Point(324, 72)
        Me.txtsCodAlmFin.MaxLength = 20
        Me.txtsCodAlmFin.Name = "txtsCodAlmFin"
        Me.txtsCodAlmFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodAlmFin.TabIndex = 52
        '
        'cmdIEDMI_QAlmIni
        '
        Me.cmdIEDMI_QAlmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI_QAlmIni.Location = New System.Drawing.Point(252, 70)
        Me.cmdIEDMI_QAlmIni.Name = "cmdIEDMI_QAlmIni"
        Me.cmdIEDMI_QAlmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMI_QAlmIni.TabIndex = 51
        Me.cmdIEDMI_QAlmIni.Text = "Lst"
        Me.cmdIEDMI_QAlmIni.UseVisualStyleBackColor = False
        '
        'txtsCodAlmIni
        '
        Me.txtsCodAlmIni.Location = New System.Drawing.Point(129, 72)
        Me.txtsCodAlmIni.MaxLength = 20
        Me.txtsCodAlmIni.Name = "txtsCodAlmIni"
        Me.txtsCodAlmIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodAlmIni.TabIndex = 50
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 15
        Me.LineShape2.X2 = 461
        Me.LineShape2.Y1 = 128
        Me.LineShape2.Y2 = 129
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 465
        Me.LineShape1.Y1 = 90
        Me.LineShape1.Y2 = 91
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 15
        Me.LineShape5.X2 = 461
        Me.LineShape5.Y1 = 55
        Me.LineShape5.Y2 = 56
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
        'txtbImpAct
        '
        Me.txtbImpAct.AutoSize = True
        Me.txtbImpAct.Location = New System.Drawing.Point(12, 159)
        Me.txtbImpAct.Name = "txtbImpAct"
        Me.txtbImpAct.Size = New System.Drawing.Size(116, 13)
        Me.txtbImpAct.TabIndex = 64
        Me.txtbImpAct.Text = "Imprimir ítems inactivos"
        '
        'txtsImpItmCero
        '
        Me.txtsImpItmCero.AutoSize = True
        Me.txtsImpItmCero.Location = New System.Drawing.Point(12, 187)
        Me.txtsImpItmCero.Name = "txtsImpItmCero"
        Me.txtsImpItmCero.Size = New System.Drawing.Size(144, 13)
        Me.txtsImpItmCero.TabIndex = 65
        Me.txtsImpItmCero.Text = "Imprimir ítems con saldo cero"
        '
        'chbbImpItmInac
        '
        Me.chbbImpItmInac.AutoSize = True
        Me.chbbImpItmInac.Location = New System.Drawing.Point(175, 159)
        Me.chbbImpItmInac.Name = "chbbImpItmInac"
        Me.chbbImpItmInac.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpItmInac.TabIndex = 66
        Me.chbbImpItmInac.UseVisualStyleBackColor = True
        '
        'chbbImpItmCero
        '
        Me.chbbImpItmCero.AutoSize = True
        Me.chbbImpItmCero.Location = New System.Drawing.Point(175, 186)
        Me.chbbImpItmCero.Name = "chbbImpItmCero"
        Me.chbbImpItmCero.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpItmCero.TabIndex = 67
        Me.chbbImpItmCero.UseVisualStyleBackColor = True
        '
        'frmRIDMI01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRIDMI01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de saldos de inventarios  por almacén"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblsCodItm As System.Windows.Forms.Label
    Friend WithEvents cmdIEDMI_QItmFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodItmFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEDMI_QItmIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodItmIni As System.Windows.Forms.TextBox
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblsCodAlm As System.Windows.Forms.Label
    Friend WithEvents cmdIEDMI_QAlmFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlmFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEDMI_QAlmIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlmIni As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblsCodGrp As System.Windows.Forms.Label
    Friend WithEvents cmdIEDMI_QGrpFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodGrpFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdIEDMI_QGrpIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodGrpIni As System.Windows.Forms.TextBox
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtsImpItmCero As System.Windows.Forms.Label
    Friend WithEvents txtbImpAct As System.Windows.Forms.Label
    Friend WithEvents chbbImpItmCero As System.Windows.Forms.CheckBox
    Friend WithEvents chbbImpItmInac As System.Windows.Forms.CheckBox
End Class
