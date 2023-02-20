<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATTIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATTIN))
        Me.cboTipMov = New System.Windows.Forms.ComboBox()
        Me.lblTipMov = New System.Windows.Forms.Label()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.cmdLstATTIN = New System.Windows.Forms.Button()
        Me.txtsNomTra = New System.Windows.Forms.TextBox()
        Me.lblsNomTra = New System.Windows.Forms.Label()
        Me.txtsCodTra = New System.Windows.Forms.TextBox()
        Me.lblsCodTra = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboTipMov
        '
        Me.cboTipMov.FormattingEnabled = True
        Me.cboTipMov.Items.AddRange(New Object() {"E", "S"})
        Me.cboTipMov.Location = New System.Drawing.Point(169, 55)
        Me.cboTipMov.Name = "cboTipMov"
        Me.cboTipMov.Size = New System.Drawing.Size(100, 21)
        Me.cboTipMov.TabIndex = 537
        '
        'lblTipMov
        '
        Me.lblTipMov.AutoSize = True
        Me.lblTipMov.Location = New System.Drawing.Point(14, 57)
        Me.lblTipMov.Name = "lblTipMov"
        Me.lblTipMov.Size = New System.Drawing.Size(129, 13)
        Me.lblTipMov.TabIndex = 536
        Me.lblTipMov.Text = "Código del tipo de análisis"
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(14, 87)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(118, 17)
        Me.chbbRegAci.TabIndex = 535
        Me.chbbRegAci.Text = "Transacción Activa"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'cmdLstATTIN
        '
        Me.cmdLstATTIN.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATTIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATTIN.Location = New System.Drawing.Point(290, 6)
        Me.cmdLstATTIN.Name = "cmdLstATTIN"
        Me.cmdLstATTIN.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATTIN.TabIndex = 534
        Me.cmdLstATTIN.Text = "Lst"
        Me.cmdLstATTIN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATTIN.UseVisualStyleBackColor = False
        '
        'txtsNomTra
        '
        Me.txtsNomTra.Location = New System.Drawing.Point(169, 28)
        Me.txtsNomTra.MaxLength = 100
        Me.txtsNomTra.Name = "txtsNomTra"
        Me.txtsNomTra.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomTra.TabIndex = 531
        '
        'lblsNomTra
        '
        Me.lblsNomTra.AutoSize = True
        Me.lblsNomTra.Location = New System.Drawing.Point(14, 34)
        Me.lblsNomTra.Name = "lblsNomTra"
        Me.lblsNomTra.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomTra.TabIndex = 533
        Me.lblsNomTra.Text = "Descripción"
        '
        'txtsCodTra
        '
        Me.txtsCodTra.Location = New System.Drawing.Point(169, 3)
        Me.txtsCodTra.MaxLength = 8
        Me.txtsCodTra.Name = "txtsCodTra"
        Me.txtsCodTra.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodTra.TabIndex = 530
        '
        'lblsCodTra
        '
        Me.lblsCodTra.AutoSize = True
        Me.lblsCodTra.Location = New System.Drawing.Point(14, 9)
        Me.lblsCodTra.Name = "lblsCodTra"
        Me.lblsCodTra.Size = New System.Drawing.Size(124, 13)
        Me.lblsCodTra.TabIndex = 532
        Me.lblsCodTra.Text = "Código de la transacción"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(4, 238)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 524
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(4, 238)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 526
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(4, 238)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 529
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(4, 238)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 527
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 238)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 525
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(4, 238)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 528
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'frmATTIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.cboTipMov)
        Me.Controls.Add(Me.lblTipMov)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATTIN)
        Me.Controls.Add(Me.txtsNomTra)
        Me.Controls.Add(Me.lblsNomTra)
        Me.Controls.Add(Me.txtsCodTra)
        Me.Controls.Add(Me.lblsCodTra)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATTIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Transacciones de Inventarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipMov As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipMov As System.Windows.Forms.Label
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLstATTIN As System.Windows.Forms.Button
    Friend WithEvents txtsNomTra As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomTra As System.Windows.Forms.Label
    Friend WithEvents txtsCodTra As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodTra As System.Windows.Forms.Label
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
End Class
