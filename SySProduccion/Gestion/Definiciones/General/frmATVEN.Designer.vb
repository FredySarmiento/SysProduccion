<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATVEN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATVEN))
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.cmdLstATVEN = New System.Windows.Forms.Button()
        Me.txtsNomVen = New System.Windows.Forms.TextBox()
        Me.lblsNomVen = New System.Windows.Forms.Label()
        Me.txtsCodVen = New System.Windows.Forms.TextBox()
        Me.lblsCodVen = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Zona = New System.Windows.Forms.Label()
        Me.lblsTipVen = New System.Windows.Forms.Label()
        Me.cboATZON = New System.Windows.Forms.ComboBox()
        Me.cboABTIV = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(9, 115)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(111, 17)
        Me.chbbRegAci.TabIndex = 534
        Me.chbbRegAci.Text = "Encargado Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'cmdLstATVEN
        '
        Me.cmdLstATVEN.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATVEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATVEN.Location = New System.Drawing.Point(285, 8)
        Me.cmdLstATVEN.Name = "cmdLstATVEN"
        Me.cmdLstATVEN.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATVEN.TabIndex = 533
        Me.cmdLstATVEN.Text = "Lst"
        Me.cmdLstATVEN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATVEN.UseVisualStyleBackColor = False
        '
        'txtsNomVen
        '
        Me.txtsNomVen.Location = New System.Drawing.Point(164, 30)
        Me.txtsNomVen.MaxLength = 100
        Me.txtsNomVen.Name = "txtsNomVen"
        Me.txtsNomVen.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomVen.TabIndex = 530
        '
        'lblsNomVen
        '
        Me.lblsNomVen.AutoSize = True
        Me.lblsNomVen.Location = New System.Drawing.Point(9, 36)
        Me.lblsNomVen.Name = "lblsNomVen"
        Me.lblsNomVen.Size = New System.Drawing.Size(44, 13)
        Me.lblsNomVen.TabIndex = 532
        Me.lblsNomVen.Text = "Nombre"
        '
        'txtsCodVen
        '
        Me.txtsCodVen.Location = New System.Drawing.Point(164, 5)
        Me.txtsCodVen.MaxLength = 8
        Me.txtsCodVen.Name = "txtsCodVen"
        Me.txtsCodVen.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodVen.TabIndex = 529
        '
        'lblsCodVen
        '
        Me.lblsCodVen.AutoSize = True
        Me.lblsCodVen.Location = New System.Drawing.Point(9, 11)
        Me.lblsCodVen.Name = "lblsCodVen"
        Me.lblsCodVen.Size = New System.Drawing.Size(112, 13)
        Me.lblsCodVen.TabIndex = 531
        Me.lblsCodVen.Text = "Código del Encargado"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(9, 236)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 523
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(9, 236)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 525
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(9, 236)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 528
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(9, 236)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 526
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(91, 236)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 524
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(9, 236)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 527
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'Zona
        '
        Me.Zona.AutoSize = True
        Me.Zona.Location = New System.Drawing.Point(9, 63)
        Me.Zona.Name = "Zona"
        Me.Zona.Size = New System.Drawing.Size(35, 13)
        Me.Zona.TabIndex = 536
        Me.Zona.Text = "Zona "
        '
        'lblsTipVen
        '
        Me.lblsTipVen.AutoSize = True
        Me.lblsTipVen.Location = New System.Drawing.Point(6, 88)
        Me.lblsTipVen.Name = "lblsTipVen"
        Me.lblsTipVen.Size = New System.Drawing.Size(103, 13)
        Me.lblsTipVen.TabIndex = 537
        Me.lblsTipVen.Text = "Tipo de encargado :"
        '
        'cboATZON
        '
        Me.cboATZON.FormattingEnabled = True
        Me.cboATZON.Location = New System.Drawing.Point(164, 56)
        Me.cboATZON.Name = "cboATZON"
        Me.cboATZON.Size = New System.Drawing.Size(121, 21)
        Me.cboATZON.TabIndex = 538
        '
        'cboABTIV
        '
        Me.cboABTIV.FormattingEnabled = True
        Me.cboABTIV.Location = New System.Drawing.Point(164, 82)
        Me.cboABTIV.Name = "cboABTIV"
        Me.cboABTIV.Size = New System.Drawing.Size(121, 21)
        Me.cboABTIV.TabIndex = 539
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 262)
        Me.ShapeContainer1.TabIndex = 540
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 12
        Me.LineShape4.X2 = 249
        Me.LineShape4.Y1 = 102
        Me.LineShape4.Y2 = 102
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 11
        Me.LineShape3.X2 = 248
        Me.LineShape3.Y1 = 76
        Me.LineShape3.Y2 = 76
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 8
        Me.LineShape2.X2 = 245
        Me.LineShape2.Y1 = 49
        Me.LineShape2.Y2 = 49
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 7
        Me.LineShape1.X2 = 244
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 24
        '
        'frmATVEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.cboABTIV)
        Me.Controls.Add(Me.cboATZON)
        Me.Controls.Add(Me.lblsTipVen)
        Me.Controls.Add(Me.Zona)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATVEN)
        Me.Controls.Add(Me.txtsNomVen)
        Me.Controls.Add(Me.lblsNomVen)
        Me.Controls.Add(Me.txtsCodVen)
        Me.Controls.Add(Me.lblsCodVen)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATVEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargados de Compras/Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLstATVEN As System.Windows.Forms.Button
    Friend WithEvents txtsNomVen As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomVen As System.Windows.Forms.Label
    Friend WithEvents txtsCodVen As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodVen As System.Windows.Forms.Label
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents Zona As System.Windows.Forms.Label
    Friend WithEvents lblsTipVen As System.Windows.Forms.Label
    Friend WithEvents cboATZON As System.Windows.Forms.ComboBox
    Friend WithEvents cboABTIV As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
