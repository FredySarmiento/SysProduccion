<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATOPE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATOPE))
        Me.txtnUniTieOpe = New System.Windows.Forms.TextBox()
        Me.lblnUniTieOpe = New System.Windows.Forms.Label()
        Me.txtnTieOpe = New System.Windows.Forms.TextBox()
        Me.lblnTieOpe = New System.Windows.Forms.Label()
        Me.lblsCodCtr = New System.Windows.Forms.Label()
        Me.txtsNomOpe = New System.Windows.Forms.TextBox()
        Me.lblsNomOpe = New System.Windows.Forms.Label()
        Me.txtsCodOpe = New System.Windows.Forms.TextBox()
        Me.lblsCodOpe = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cboATCTR = New System.Windows.Forms.ComboBox()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdLstATOPE = New System.Windows.Forms.Button()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtnUniTieOpe
        '
        Me.txtnUniTieOpe.Location = New System.Drawing.Point(160, 105)
        Me.txtnUniTieOpe.MaxLength = 15
        Me.txtnUniTieOpe.Name = "txtnUniTieOpe"
        Me.txtnUniTieOpe.Size = New System.Drawing.Size(100, 20)
        Me.txtnUniTieOpe.TabIndex = 5
        Me.txtnUniTieOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnUniTieOpe
        '
        Me.lblnUniTieOpe.AutoSize = True
        Me.lblnUniTieOpe.Location = New System.Drawing.Point(5, 110)
        Me.lblnUniTieOpe.Name = "lblnUniTieOpe"
        Me.lblnUniTieOpe.Size = New System.Drawing.Size(93, 13)
        Me.lblnUniTieOpe.TabIndex = 157
        Me.lblnUniTieOpe.Text = "Unidad de tiempo "
        '
        'txtnTieOpe
        '
        Me.txtnTieOpe.Location = New System.Drawing.Point(160, 80)
        Me.txtnTieOpe.MaxLength = 15
        Me.txtnTieOpe.Name = "txtnTieOpe"
        Me.txtnTieOpe.Size = New System.Drawing.Size(100, 20)
        Me.txtnTieOpe.TabIndex = 4
        Me.txtnTieOpe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblnTieOpe
        '
        Me.lblnTieOpe.AutoSize = True
        Me.lblnTieOpe.Location = New System.Drawing.Point(5, 85)
        Me.lblnTieOpe.Name = "lblnTieOpe"
        Me.lblnTieOpe.Size = New System.Drawing.Size(107, 13)
        Me.lblnTieOpe.TabIndex = 155
        Me.lblnTieOpe.Text = "Tiempo de operación"
        '
        'lblsCodCtr
        '
        Me.lblsCodCtr.AutoSize = True
        Me.lblsCodCtr.Location = New System.Drawing.Point(5, 60)
        Me.lblsCodCtr.Name = "lblsCodCtr"
        Me.lblsCodCtr.Size = New System.Drawing.Size(140, 13)
        Me.lblsCodCtr.TabIndex = 153
        Me.lblsCodCtr.Text = "Código del centro de trabajo"
        '
        'txtsNomOpe
        '
        Me.txtsNomOpe.Location = New System.Drawing.Point(160, 30)
        Me.txtsNomOpe.MaxLength = 100
        Me.txtsNomOpe.Name = "txtsNomOpe"
        Me.txtsNomOpe.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomOpe.TabIndex = 2
        '
        'lblsNomOpe
        '
        Me.lblsNomOpe.AutoSize = True
        Me.lblsNomOpe.Location = New System.Drawing.Point(5, 36)
        Me.lblsNomOpe.Name = "lblsNomOpe"
        Me.lblsNomOpe.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomOpe.TabIndex = 151
        Me.lblsNomOpe.Text = "Descripción"
        '
        'txtsCodOpe
        '
        Me.txtsCodOpe.Location = New System.Drawing.Point(160, 5)
        Me.txtsCodOpe.MaxLength = 8
        Me.txtsCodOpe.Name = "txtsCodOpe"
        Me.txtsCodOpe.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodOpe.TabIndex = 1
        '
        'lblsCodOpe
        '
        Me.lblsCodOpe.AutoSize = True
        Me.lblsCodOpe.Location = New System.Drawing.Point(5, 11)
        Me.lblsCodOpe.Name = "lblsCodOpe"
        Me.lblsCodOpe.Size = New System.Drawing.Size(116, 13)
        Me.lblsCodOpe.TabIndex = 149
        Me.lblsCodOpe.Text = "Código de la operación"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 262)
        Me.ShapeContainer1.TabIndex = 159
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 5
        Me.LineShape5.X2 = 184
        Me.LineShape5.Y1 = 99
        Me.LineShape5.Y2 = 99
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 5
        Me.LineShape4.X2 = 184
        Me.LineShape4.Y1 = 73
        Me.LineShape4.Y2 = 73
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 5
        Me.LineShape3.X2 = 184
        Me.LineShape3.Y1 = 49
        Me.LineShape3.Y2 = 49
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 5
        Me.LineShape2.X2 = 184
        Me.LineShape2.Y1 = 24
        Me.LineShape2.Y2 = 24
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 5
        Me.LineShape1.X2 = 184
        Me.LineShape1.Y1 = 124
        Me.LineShape1.Y2 = 124
        '
        'cboATCTR
        '
        Me.cboATCTR.FormattingEnabled = True
        Me.cboATCTR.Location = New System.Drawing.Point(160, 54)
        Me.cboATCTR.MaxLength = 8
        Me.cboATCTR.Name = "cboATCTR"
        Me.cboATCTR.Size = New System.Drawing.Size(100, 21)
        Me.cboATCTR.TabIndex = 3
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
        Me.cmdCrear.TabIndex = 488
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
        Me.cmdOk.TabIndex = 490
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
        Me.cmdEliminar.TabIndex = 493
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
        Me.cmdBuscar.TabIndex = 491
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
        Me.cmdCancelar.TabIndex = 489
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
        Me.cmdActualizar.TabIndex = 492
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cmdLstATOPE
        '
        Me.cmdLstATOPE.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATOPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATOPE.Location = New System.Drawing.Point(281, 8)
        Me.cmdLstATOPE.Name = "cmdLstATOPE"
        Me.cmdLstATOPE.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATOPE.TabIndex = 494
        Me.cmdLstATOPE.Text = "Lst"
        Me.cmdLstATOPE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATOPE.UseVisualStyleBackColor = False
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(8, 136)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(108, 17)
        Me.chbbRegAci.TabIndex = 499
        Me.chbbRegAci.Text = "Operación Activa"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'frmATOPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATOPE)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cboATCTR)
        Me.Controls.Add(Me.txtnUniTieOpe)
        Me.Controls.Add(Me.lblnUniTieOpe)
        Me.Controls.Add(Me.txtnTieOpe)
        Me.Controls.Add(Me.lblnTieOpe)
        Me.Controls.Add(Me.lblsCodCtr)
        Me.Controls.Add(Me.txtsNomOpe)
        Me.Controls.Add(Me.lblsNomOpe)
        Me.Controls.Add(Me.txtsCodOpe)
        Me.Controls.Add(Me.lblsCodOpe)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATOPE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones de producción"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnUniTieOpe As System.Windows.Forms.TextBox
    Friend WithEvents lblnUniTieOpe As System.Windows.Forms.Label
    Friend WithEvents txtnTieOpe As System.Windows.Forms.TextBox
    Friend WithEvents lblnTieOpe As System.Windows.Forms.Label
    Friend WithEvents lblsCodCtr As System.Windows.Forms.Label
    Friend WithEvents txtsNomOpe As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomOpe As System.Windows.Forms.Label
    Friend WithEvents txtsCodOpe As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodOpe As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cboATCTR As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdLstATOPE As System.Windows.Forms.Button
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
End Class
