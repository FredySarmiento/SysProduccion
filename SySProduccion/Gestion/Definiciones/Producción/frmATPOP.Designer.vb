<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATPOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATPOP))
        Me.cmdLstATPOP = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.txtsNomTer = New System.Windows.Forms.TextBox()
        Me.lblsNomTer = New System.Windows.Forms.Label()
        Me.txtsCodTer = New System.Windows.Forms.TextBox()
        Me.lblsCodTer = New System.Windows.Forms.Label()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdLstATPOP
        '
        Me.cmdLstATPOP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATPOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATPOP.Location = New System.Drawing.Point(285, 8)
        Me.cmdLstATPOP.Name = "cmdLstATPOP"
        Me.cmdLstATPOP.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATPOP.TabIndex = 511
        Me.cmdLstATPOP.Text = "Lst"
        Me.cmdLstATPOP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATPOP.UseVisualStyleBackColor = False
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
        Me.cmdCrear.TabIndex = 505
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
        Me.cmdOk.TabIndex = 507
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
        Me.cmdEliminar.TabIndex = 510
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
        Me.cmdBuscar.TabIndex = 508
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
        Me.cmdCancelar.TabIndex = 506
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
        Me.cmdActualizar.TabIndex = 509
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'txtsNomTer
        '
        Me.txtsNomTer.Location = New System.Drawing.Point(164, 30)
        Me.txtsNomTer.MaxLength = 100
        Me.txtsNomTer.Name = "txtsNomTer"
        Me.txtsNomTer.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomTer.TabIndex = 496
        '
        'lblsNomTer
        '
        Me.lblsNomTer.AutoSize = True
        Me.lblsNomTer.Location = New System.Drawing.Point(9, 36)
        Me.lblsNomTer.Name = "lblsNomTer"
        Me.lblsNomTer.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomTer.TabIndex = 501
        Me.lblsNomTer.Text = "Descripción"
        '
        'txtsCodTer
        '
        Me.txtsCodTer.Location = New System.Drawing.Point(164, 5)
        Me.txtsCodTer.MaxLength = 8
        Me.txtsCodTer.Name = "txtsCodTer"
        Me.txtsCodTer.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodTer.TabIndex = 495
        '
        'lblsCodTer
        '
        Me.lblsCodTer.AutoSize = True
        Me.lblsCodTer.Location = New System.Drawing.Point(9, 11)
        Me.lblsCodTer.Name = "lblsCodTer"
        Me.lblsCodTer.Size = New System.Drawing.Size(98, 13)
        Me.lblsCodTer.TabIndex = 500
        Me.lblsCodTer.Text = "Código del operario"
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(9, 61)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(99, 17)
        Me.chbbRegAci.TabIndex = 513
        Me.chbbRegAci.Text = "Operario Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'frmATPOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATPOP)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.txtsNomTer)
        Me.Controls.Add(Me.lblsNomTer)
        Me.Controls.Add(Me.txtsCodTer)
        Me.Controls.Add(Me.lblsCodTer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATPOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdLstATPOP As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents txtsNomTer As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomTer As System.Windows.Forms.Label
    Friend WithEvents txtsCodTer As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodTer As System.Windows.Forms.Label
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
End Class
