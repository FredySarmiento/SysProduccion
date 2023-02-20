<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABEOC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABEOC))
        Me.txtnNroOrd = New System.Windows.Forms.TextBox()
        Me.lblNroOrd = New System.Windows.Forms.Label()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.cmdLstABEOC = New System.Windows.Forms.Button()
        Me.txtsNomEstODC = New System.Windows.Forms.TextBox()
        Me.lblsNomEstODC = New System.Windows.Forms.Label()
        Me.txtsCodEstODC = New System.Windows.Forms.TextBox()
        Me.lblsCodEstODC = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnNroOrd
        '
        Me.txtnNroOrd.Location = New System.Drawing.Point(168, 55)
        Me.txtnNroOrd.MaxLength = 8
        Me.txtnNroOrd.Name = "txtnNroOrd"
        Me.txtnNroOrd.Size = New System.Drawing.Size(100, 20)
        Me.txtnNroOrd.TabIndex = 545
        '
        'lblNroOrd
        '
        Me.lblNroOrd.AutoSize = True
        Me.lblNroOrd.Location = New System.Drawing.Point(13, 58)
        Me.lblNroOrd.Name = "lblNroOrd"
        Me.lblNroOrd.Size = New System.Drawing.Size(101, 13)
        Me.lblNroOrd.TabIndex = 544
        Me.lblNroOrd.Text = "Consecutivo Orden "
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(13, 83)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(98, 17)
        Me.chbbRegAci.TabIndex = 543
        Me.chbbRegAci.Text = "Registro Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'cmdLstABEOC
        '
        Me.cmdLstABEOC.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABEOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstABEOC.Location = New System.Drawing.Point(289, 7)
        Me.cmdLstABEOC.Name = "cmdLstABEOC"
        Me.cmdLstABEOC.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstABEOC.TabIndex = 542
        Me.cmdLstABEOC.Text = "Lst"
        Me.cmdLstABEOC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstABEOC.UseVisualStyleBackColor = False
        '
        'txtsNomEstODC
        '
        Me.txtsNomEstODC.Location = New System.Drawing.Point(168, 29)
        Me.txtsNomEstODC.MaxLength = 100
        Me.txtsNomEstODC.Name = "txtsNomEstODC"
        Me.txtsNomEstODC.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomEstODC.TabIndex = 539
        '
        'lblsNomEstODC
        '
        Me.lblsNomEstODC.AutoSize = True
        Me.lblsNomEstODC.Location = New System.Drawing.Point(13, 35)
        Me.lblsNomEstODC.Name = "lblsNomEstODC"
        Me.lblsNomEstODC.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomEstODC.TabIndex = 541
        Me.lblsNomEstODC.Text = "Descripción"
        '
        'txtsCodEstODC
        '
        Me.txtsCodEstODC.Location = New System.Drawing.Point(168, 4)
        Me.txtsCodEstODC.MaxLength = 8
        Me.txtsCodEstODC.Name = "txtsCodEstODC"
        Me.txtsCodEstODC.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodEstODC.TabIndex = 538
        '
        'lblsCodEstODC
        '
        Me.lblsCodEstODC.AutoSize = True
        Me.lblsCodEstODC.Location = New System.Drawing.Point(13, 10)
        Me.lblsCodEstODC.Name = "lblsCodEstODC"
        Me.lblsCodEstODC.Size = New System.Drawing.Size(92, 13)
        Me.lblsCodEstODC.TabIndex = 540
        Me.lblsCodEstODC.Text = "Código del estado"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 237)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 532
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 237)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 534
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 237)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 537
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(5, 237)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 535
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 237)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 533
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(5, 237)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 536
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'frmABEOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.txtnNroOrd)
        Me.Controls.Add(Me.lblNroOrd)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstABEOC)
        Me.Controls.Add(Me.txtsNomEstODC)
        Me.Controls.Add(Me.lblsNomEstODC)
        Me.Controls.Add(Me.txtsCodEstODC)
        Me.Controls.Add(Me.lblsCodEstODC)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmABEOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados de la Orden de Compra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnNroOrd As TextBox
    Friend WithEvents lblNroOrd As Label
    Friend WithEvents chbbRegAci As CheckBox
    Friend WithEvents cmdLstABEOC As Button
    Friend WithEvents txtsNomEstODC As TextBox
    Friend WithEvents lblsNomEstODC As Label
    Friend WithEvents txtsCodEstODC As TextBox
    Friend WithEvents lblsCodEstODC As Label
    Friend WithEvents cmdCrear As Button
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdActualizar As Button
End Class
