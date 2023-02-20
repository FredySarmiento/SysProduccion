<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATCIF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATCIF))
        Me.cmdActCos = New System.Windows.Forms.Button()
        Me.cmdLstATCIF = New System.Windows.Forms.Button()
        Me.cboATCTR = New System.Windows.Forms.ComboBox()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.txtnVlrCIFRea = New System.Windows.Forms.TextBox()
        Me.lblnVlrReaCIF = New System.Windows.Forms.Label()
        Me.lblCodCTR = New System.Windows.Forms.Label()
        Me.txtnBasCIFPpo = New System.Windows.Forms.TextBox()
        Me.lblnBasCIFPpo = New System.Windows.Forms.Label()
        Me.txtnVlrCIFPpo = New System.Windows.Forms.TextBox()
        Me.lblNVlrCIFPpo = New System.Windows.Forms.Label()
        Me.txtnVlrCIF = New System.Windows.Forms.TextBox()
        Me.lblnVlrCIF = New System.Windows.Forms.Label()
        Me.txtnTasCIF = New System.Windows.Forms.TextBox()
        Me.lblnTasCIF = New System.Windows.Forms.Label()
        Me.txtsNomCIF = New System.Windows.Forms.TextBox()
        Me.lblsNomCIF = New System.Windows.Forms.Label()
        Me.txtsCodCIF = New System.Windows.Forms.TextBox()
        Me.lblsCodCIF = New System.Windows.Forms.Label()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdActCos
        '
        Me.cmdActCos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActCos.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActCos.Location = New System.Drawing.Point(403, 236)
        Me.cmdActCos.Name = "cmdActCos"
        Me.cmdActCos.Size = New System.Drawing.Size(114, 22)
        Me.cmdActCos.TabIndex = 536
        Me.cmdActCos.Text = "Actualizar Costos"
        Me.cmdActCos.UseVisualStyleBackColor = False
        '
        'cmdLstATCIF
        '
        Me.cmdLstATCIF.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATCIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATCIF.Location = New System.Drawing.Point(275, 7)
        Me.cmdLstATCIF.Name = "cmdLstATCIF"
        Me.cmdLstATCIF.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATCIF.TabIndex = 2
        Me.cmdLstATCIF.Text = "Lst"
        Me.cmdLstATCIF.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATCIF.UseVisualStyleBackColor = False
        '
        'cboATCTR
        '
        Me.cboATCTR.FormattingEnabled = True
        Me.cboATCTR.Location = New System.Drawing.Point(159, 54)
        Me.cboATCTR.Name = "cboATCTR"
        Me.cboATCTR.Size = New System.Drawing.Size(100, 21)
        Me.cboATCTR.TabIndex = 4
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(4, 235)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 522
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(4, 235)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 524
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(4, 235)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 523
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(4, 235)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 520
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 235)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 521
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(4, 235)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 519
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'txtnVlrCIFRea
        '
        Me.txtnVlrCIFRea.Location = New System.Drawing.Point(160, 178)
        Me.txtnVlrCIFRea.MaxLength = 20
        Me.txtnVlrCIFRea.Name = "txtnVlrCIFRea"
        Me.txtnVlrCIFRea.Size = New System.Drawing.Size(100, 20)
        Me.txtnVlrCIFRea.TabIndex = 9
        Me.txtnVlrCIFRea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnVlrReaCIF
        '
        Me.lblnVlrReaCIF.AutoSize = True
        Me.lblnVlrReaCIF.Location = New System.Drawing.Point(5, 183)
        Me.lblnVlrReaCIF.Name = "lblnVlrReaCIF"
        Me.lblnVlrReaCIF.Size = New System.Drawing.Size(75, 13)
        Me.lblnVlrReaCIF.TabIndex = 532
        Me.lblnVlrReaCIF.Text = "Vlr unitario CIF"
        '
        'lblCodCTR
        '
        Me.lblCodCTR.AutoSize = True
        Me.lblCodCTR.Location = New System.Drawing.Point(5, 60)
        Me.lblCodCTR.Name = "lblCodCTR"
        Me.lblCodCTR.Size = New System.Drawing.Size(91, 13)
        Me.lblCodCTR.TabIndex = 531
        Me.lblCodCTR.Text = "Centro de trabajo:"
        '
        'txtnBasCIFPpo
        '
        Me.txtnBasCIFPpo.Location = New System.Drawing.Point(159, 128)
        Me.txtnBasCIFPpo.MaxLength = 20
        Me.txtnBasCIFPpo.Name = "txtnBasCIFPpo"
        Me.txtnBasCIFPpo.Size = New System.Drawing.Size(100, 20)
        Me.txtnBasCIFPpo.TabIndex = 7
        Me.txtnBasCIFPpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnBasCIFPpo
        '
        Me.lblnBasCIFPpo.AutoSize = True
        Me.lblnBasCIFPpo.Location = New System.Drawing.Point(5, 134)
        Me.lblnBasCIFPpo.Name = "lblnBasCIFPpo"
        Me.lblnBasCIFPpo.Size = New System.Drawing.Size(145, 13)
        Me.lblnBasCIFPpo.TabIndex = 530
        Me.lblnBasCIFPpo.Text = "Base de los CIF. Tot H.Prod.:"
        '
        'txtnVlrCIFPpo
        '
        Me.txtnVlrCIFPpo.Location = New System.Drawing.Point(159, 103)
        Me.txtnVlrCIFPpo.MaxLength = 20
        Me.txtnVlrCIFPpo.Name = "txtnVlrCIFPpo"
        Me.txtnVlrCIFPpo.Size = New System.Drawing.Size(100, 20)
        Me.txtnVlrCIFPpo.TabIndex = 6
        Me.txtnVlrCIFPpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNVlrCIFPpo
        '
        Me.lblNVlrCIFPpo.AutoSize = True
        Me.lblNVlrCIFPpo.Location = New System.Drawing.Point(5, 109)
        Me.lblNVlrCIFPpo.Name = "lblNVlrCIFPpo"
        Me.lblNVlrCIFPpo.Size = New System.Drawing.Size(128, 13)
        Me.lblNVlrCIFPpo.TabIndex = 529
        Me.lblNVlrCIFPpo.Text = "Vlr CIF Presupuesto Cont."
        '
        'txtnVlrCIF
        '
        Me.txtnVlrCIF.Location = New System.Drawing.Point(159, 154)
        Me.txtnVlrCIF.MaxLength = 20
        Me.txtnVlrCIF.Name = "txtnVlrCIF"
        Me.txtnVlrCIF.Size = New System.Drawing.Size(100, 20)
        Me.txtnVlrCIF.TabIndex = 8
        Me.txtnVlrCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnVlrCIF
        '
        Me.lblnVlrCIF.AutoSize = True
        Me.lblnVlrCIF.Location = New System.Drawing.Point(5, 160)
        Me.lblnVlrCIF.Name = "lblnVlrCIF"
        Me.lblnVlrCIF.Size = New System.Drawing.Size(64, 13)
        Me.lblnVlrCIF.TabIndex = 528
        Me.lblnVlrCIF.Text = "Vlr Hora CIF"
        '
        'txtnTasCIF
        '
        Me.txtnTasCIF.Location = New System.Drawing.Point(159, 79)
        Me.txtnTasCIF.MaxLength = 20
        Me.txtnTasCIF.Name = "txtnTasCIF"
        Me.txtnTasCIF.Size = New System.Drawing.Size(100, 20)
        Me.txtnTasCIF.TabIndex = 5
        Me.txtnTasCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnTasCIF
        '
        Me.lblnTasCIF.AutoSize = True
        Me.lblnTasCIF.Location = New System.Drawing.Point(5, 85)
        Me.lblnTasCIF.Name = "lblnTasCIF"
        Me.lblnTasCIF.Size = New System.Drawing.Size(56, 13)
        Me.lblnTasCIF.TabIndex = 527
        Me.lblnTasCIF.Text = "Tasa CIF :"
        '
        'txtsNomCIF
        '
        Me.txtsNomCIF.Location = New System.Drawing.Point(159, 29)
        Me.txtsNomCIF.MaxLength = 100
        Me.txtsNomCIF.Name = "txtsNomCIF"
        Me.txtsNomCIF.Size = New System.Drawing.Size(420, 20)
        Me.txtsNomCIF.TabIndex = 3
        '
        'lblsNomCIF
        '
        Me.lblsNomCIF.AutoSize = True
        Me.lblsNomCIF.Location = New System.Drawing.Point(5, 35)
        Me.lblsNomCIF.Name = "lblsNomCIF"
        Me.lblsNomCIF.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomCIF.TabIndex = 526
        Me.lblsNomCIF.Text = "Descripción"
        '
        'txtsCodCIF
        '
        Me.txtsCodCIF.Location = New System.Drawing.Point(159, 4)
        Me.txtsCodCIF.MaxLength = 8
        Me.txtsCodCIF.Name = "txtsCodCIF"
        Me.txtsCodCIF.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodCIF.TabIndex = 1
        '
        'lblsCodCIF
        '
        Me.lblsCodCIF.AutoSize = True
        Me.lblsCodCIF.Location = New System.Drawing.Point(5, 10)
        Me.lblsCodCIF.Name = "lblsCodCIF"
        Me.lblsCodCIF.Size = New System.Drawing.Size(71, 13)
        Me.lblsCodCIF.TabIndex = 525
        Me.lblsCodCIF.Text = "Código C.I.F.:"
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 2
        Me.LineShape7.X2 = 176
        Me.LineShape7.Y1 = 23
        Me.LineShape7.Y2 = 23
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.LineShape7})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 262)
        Me.ShapeContainer1.TabIndex = 537
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 7
        Me.LineShape8.X2 = 181
        Me.LineShape8.Y1 = 196
        Me.LineShape8.Y2 = 196
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 5
        Me.LineShape6.X2 = 179
        Me.LineShape6.Y1 = 173
        Me.LineShape6.Y2 = 173
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 9
        Me.LineShape5.X2 = 183
        Me.LineShape5.Y1 = 147
        Me.LineShape5.Y2 = 147
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 9
        Me.LineShape4.X2 = 183
        Me.LineShape4.Y1 = 122
        Me.LineShape4.Y2 = 122
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 8
        Me.LineShape3.X2 = 182
        Me.LineShape3.Y1 = 97
        Me.LineShape3.Y2 = 97
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 8
        Me.LineShape2.X2 = 182
        Me.LineShape2.Y1 = 73
        Me.LineShape2.Y2 = 73
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 4
        Me.LineShape1.X2 = 178
        Me.LineShape1.Y1 = 48
        Me.LineShape1.Y2 = 48
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(9, 207)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(75, 17)
        Me.chbbRegAci.TabIndex = 539
        Me.chbbRegAci.Text = "CIF Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'frmATCIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdActCos)
        Me.Controls.Add(Me.cmdLstATCIF)
        Me.Controls.Add(Me.cboATCTR)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.txtnVlrCIFRea)
        Me.Controls.Add(Me.lblnVlrReaCIF)
        Me.Controls.Add(Me.lblCodCTR)
        Me.Controls.Add(Me.txtnBasCIFPpo)
        Me.Controls.Add(Me.lblnBasCIFPpo)
        Me.Controls.Add(Me.txtnVlrCIFPpo)
        Me.Controls.Add(Me.lblNVlrCIFPpo)
        Me.Controls.Add(Me.txtnVlrCIF)
        Me.Controls.Add(Me.lblnVlrCIF)
        Me.Controls.Add(Me.txtnTasCIF)
        Me.Controls.Add(Me.lblnTasCIF)
        Me.Controls.Add(Me.txtsNomCIF)
        Me.Controls.Add(Me.lblsNomCIF)
        Me.Controls.Add(Me.txtsCodCIF)
        Me.Controls.Add(Me.lblsCodCIF)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATCIF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C.I.F."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdActCos As System.Windows.Forms.Button
    Friend WithEvents cmdLstATCIF As System.Windows.Forms.Button
    Friend WithEvents cboATCTR As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents txtnVlrCIFRea As System.Windows.Forms.TextBox
    Friend WithEvents lblnVlrReaCIF As System.Windows.Forms.Label
    Friend WithEvents lblCodCTR As System.Windows.Forms.Label
    Friend WithEvents txtnBasCIFPpo As System.Windows.Forms.TextBox
    Friend WithEvents lblnBasCIFPpo As System.Windows.Forms.Label
    Friend WithEvents txtnVlrCIFPpo As System.Windows.Forms.TextBox
    Friend WithEvents lblNVlrCIFPpo As System.Windows.Forms.Label
    Friend WithEvents txtnVlrCIF As System.Windows.Forms.TextBox
    Friend WithEvents lblnVlrCIF As System.Windows.Forms.Label
    Friend WithEvents txtnTasCIF As System.Windows.Forms.TextBox
    Friend WithEvents lblnTasCIF As System.Windows.Forms.Label
    Friend WithEvents txtsNomCIF As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomCIF As System.Windows.Forms.Label
    Friend WithEvents txtsCodCIF As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodCIF As System.Windows.Forms.Label
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
End Class
