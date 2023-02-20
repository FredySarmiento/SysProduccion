<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATCTR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATCTR))
        Me.txtsCodCtr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsNomCtr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnCosMODFij = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnCosMODVar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnCosHorCpr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnScoVar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCodCCO = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnCosHorVar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnCosTotMOD = New System.Windows.Forms.TextBox()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cboATCCO = New System.Windows.Forms.ComboBox()
        Me.cmdLstATCTR = New System.Windows.Forms.Button()
        Me.txtnUniTieOpe = New System.Windows.Forms.TextBox()
        Me.txtnPreUni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdActCos = New System.Windows.Forms.Button()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtsCodCtr
        '
        Me.txtsCodCtr.Location = New System.Drawing.Point(160, 5)
        Me.txtsCodCtr.MaxLength = 8
        Me.txtsCodCtr.Name = "txtsCodCtr"
        Me.txtsCodCtr.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodCtr.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Código del centro de trabajo"
        '
        'txtsNomCtr
        '
        Me.txtsNomCtr.Location = New System.Drawing.Point(160, 30)
        Me.txtsNomCtr.MaxLength = 100
        Me.txtsNomCtr.Name = "txtsNomCtr"
        Me.txtsNomCtr.Size = New System.Drawing.Size(420, 20)
        Me.txtsNomCtr.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Descripción"
        '
        'txtnCosMODFij
        '
        Me.txtnCosMODFij.Location = New System.Drawing.Point(160, 80)
        Me.txtnCosMODFij.MaxLength = 20
        Me.txtnCosMODFij.Name = "txtnCosMODFij"
        Me.txtnCosMODFij.Size = New System.Drawing.Size(100, 20)
        Me.txtnCosMODFij.TabIndex = 5
        Me.txtnCosMODFij.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Costo hora MDO Fija"
        '
        'txtnCosMODVar
        '
        Me.txtnCosMODVar.Location = New System.Drawing.Point(160, 105)
        Me.txtnCosMODVar.MaxLength = 20
        Me.txtnCosMODVar.Name = "txtnCosMODVar"
        Me.txtnCosMODVar.Size = New System.Drawing.Size(100, 20)
        Me.txtnCosMODVar.TabIndex = 6
        Me.txtnCosMODVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Costo hora MDO Variable"
        '
        'txtnCosHorCpr
        '
        Me.txtnCosHorCpr.Location = New System.Drawing.Point(160, 130)
        Me.txtnCosHorCpr.MaxLength = 20
        Me.txtnCosHorCpr.Name = "txtnCosHorCpr"
        Me.txtnCosHorCpr.Size = New System.Drawing.Size(100, 20)
        Me.txtnCosHorCpr.TabIndex = 7
        Me.txtnCosHorCpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 13)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Costo hora carga prestacional"
        '
        'txtnScoVar
        '
        Me.txtnScoVar.Location = New System.Drawing.Point(160, 155)
        Me.txtnScoVar.MaxLength = 20
        Me.txtnScoVar.Name = "txtnScoVar"
        Me.txtnScoVar.Size = New System.Drawing.Size(100, 20)
        Me.txtnScoVar.TabIndex = 8
        Me.txtnScoVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Sobrecosto  variable"
        '
        'lblCodCCO
        '
        Me.lblCodCCO.AutoSize = True
        Me.lblCodCCO.Location = New System.Drawing.Point(5, 61)
        Me.lblCodCCO.Name = "lblCodCCO"
        Me.lblCodCCO.Size = New System.Drawing.Size(88, 13)
        Me.lblCodCCO.TabIndex = 143
        Me.lblCodCCO.Text = "Centro de Costos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 13)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "Sumatoria Costo Hora Variable"
        '
        'txtnCosHorVar
        '
        Me.txtnCosHorVar.Location = New System.Drawing.Point(480, 55)
        Me.txtnCosHorVar.MaxLength = 20
        Me.txtnCosHorVar.Name = "txtnCosHorVar"
        Me.txtnCosHorVar.Size = New System.Drawing.Size(100, 20)
        Me.txtnCosHorVar.TabIndex = 9
        Me.txtnCosHorVar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Costo hora  MDOTotal"
        '
        'txtnCosTotMOD
        '
        Me.txtnCosTotMOD.Location = New System.Drawing.Point(480, 80)
        Me.txtnCosTotMOD.MaxLength = 20
        Me.txtnCosTotMOD.Name = "txtnCosTotMOD"
        Me.txtnCosTotMOD.Size = New System.Drawing.Size(100, 20)
        Me.txtnCosTotMOD.TabIndex = 10
        Me.txtnCosTotMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 236)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 23
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 236)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 25
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 236)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 24
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(5, 236)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 21
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 236)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(5, 236)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 20
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 262)
        Me.ShapeContainer1.TabIndex = 500
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 320
        Me.LineShape11.X2 = 494
        Me.LineShape11.Y1 = 149
        Me.LineShape11.Y2 = 149
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 320
        Me.LineShape10.X2 = 494
        Me.LineShape10.Y1 = 124
        Me.LineShape10.Y2 = 124
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 315
        Me.LineShape9.X2 = 489
        Me.LineShape9.Y1 = 74
        Me.LineShape9.Y2 = 74
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 318
        Me.LineShape8.X2 = 492
        Me.LineShape8.Y1 = 99
        Me.LineShape8.Y2 = 99
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 7
        Me.LineShape7.X2 = 181
        Me.LineShape7.Y1 = 174
        Me.LineShape7.Y2 = 174
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 5
        Me.LineShape6.X2 = 179
        Me.LineShape6.Y1 = 149
        Me.LineShape6.Y2 = 149
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 5
        Me.LineShape5.X2 = 179
        Me.LineShape5.Y1 = 124
        Me.LineShape5.Y2 = 124
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 5
        Me.LineShape4.X2 = 179
        Me.LineShape4.Y1 = 99
        Me.LineShape4.Y2 = 99
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 5
        Me.LineShape3.X2 = 179
        Me.LineShape3.Y1 = 74
        Me.LineShape3.Y2 = 74
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 5
        Me.LineShape2.X2 = 179
        Me.LineShape2.Y1 = 49
        Me.LineShape2.Y2 = 49
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 5
        Me.LineShape1.X2 = 179
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 24
        '
        'cboATCCO
        '
        Me.cboATCCO.FormattingEnabled = True
        Me.cboATCCO.Location = New System.Drawing.Point(160, 55)
        Me.cboATCCO.Name = "cboATCCO"
        Me.cboATCCO.Size = New System.Drawing.Size(100, 21)
        Me.cboATCCO.TabIndex = 4
        '
        'cmdLstATCTR
        '
        Me.cmdLstATCTR.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATCTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATCTR.Location = New System.Drawing.Point(276, 8)
        Me.cmdLstATCTR.Name = "cmdLstATCTR"
        Me.cmdLstATCTR.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATCTR.TabIndex = 2
        Me.cmdLstATCTR.Text = "Lst"
        Me.cmdLstATCTR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATCTR.UseVisualStyleBackColor = False
        '
        'txtnUniTieOpe
        '
        Me.txtnUniTieOpe.Location = New System.Drawing.Point(480, 105)
        Me.txtnUniTieOpe.MaxLength = 20
        Me.txtnUniTieOpe.Name = "txtnUniTieOpe"
        Me.txtnUniTieOpe.Size = New System.Drawing.Size(100, 20)
        Me.txtnUniTieOpe.TabIndex = 11
        Me.txtnUniTieOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnPreUni
        '
        Me.txtnPreUni.Location = New System.Drawing.Point(480, 130)
        Me.txtnPreUni.MaxLength = 20
        Me.txtnPreUni.Name = "txtnPreUni"
        Me.txtnPreUni.Size = New System.Drawing.Size(100, 20)
        Me.txtnPreUni.TabIndex = 12
        Me.txtnPreUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 504
        Me.Label7.Text = "Unidad tiempo operación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(315, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 505
        Me.Label10.Text = "Precio unitario MDO"
        '
        'cmdActCos
        '
        Me.cmdActCos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActCos.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActCos.Location = New System.Drawing.Point(411, 237)
        Me.cmdActCos.Name = "cmdActCos"
        Me.cmdActCos.Size = New System.Drawing.Size(114, 22)
        Me.cmdActCos.TabIndex = 506
        Me.cmdActCos.Text = "Actualizar Costos"
        Me.cmdActCos.UseVisualStyleBackColor = False
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(9, 188)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(144, 17)
        Me.chbbRegAci.TabIndex = 508
        Me.chbbRegAci.Text = "Centro de Trabajo Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'frmATCTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdActCos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnPreUni)
        Me.Controls.Add(Me.txtnUniTieOpe)
        Me.Controls.Add(Me.cmdLstATCTR)
        Me.Controls.Add(Me.cboATCCO)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.txtnCosTotMOD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnCosHorVar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCodCCO)
        Me.Controls.Add(Me.txtnScoVar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnCosHorCpr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnCosMODVar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnCosMODFij)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsNomCtr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsCodCtr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATCTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centros de Trabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsCodCtr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsNomCtr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnCosMODFij As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnCosMODVar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnCosHorCpr As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnScoVar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCodCCO As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnCosHorVar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnCosTotMOD As System.Windows.Forms.TextBox
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cboATCCO As System.Windows.Forms.ComboBox
    Friend WithEvents cmdLstATCTR As System.Windows.Forms.Button
    Friend WithEvents txtnUniTieOpe As System.Windows.Forms.TextBox
    Friend WithEvents txtnPreUni As System.Windows.Forms.TextBox
    Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdActCos As System.Windows.Forms.Button
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
End Class
