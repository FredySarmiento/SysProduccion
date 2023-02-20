<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmABEOP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABEOP))
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.lblNroOrd = New System.Windows.Forms.Label()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.cmdLstABEOP = New System.Windows.Forms.Button()
        Me.txtsNomEstODP = New System.Windows.Forms.TextBox()
        Me.lblsNomEstODP = New System.Windows.Forms.Label()
        Me.txtsCodEstODP = New System.Windows.Forms.TextBox()
        Me.lblsCodEstODP = New System.Windows.Forms.Label()
        Me.txtnNroOrd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(4, 236)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 500
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(4, 236)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 502
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(4, 236)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 505
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(4, 236)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 503
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 236)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 501
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(4, 236)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 504
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'lblNroOrd
        '
        Me.lblNroOrd.AutoSize = True
        Me.lblNroOrd.Location = New System.Drawing.Point(12, 57)
        Me.lblNroOrd.Name = "lblNroOrd"
        Me.lblNroOrd.Size = New System.Drawing.Size(101, 13)
        Me.lblNroOrd.TabIndex = 530
        Me.lblNroOrd.Text = "Consecutivo Orden "
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(12, 82)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(98, 17)
        Me.chbbRegAci.TabIndex = 529
        Me.chbbRegAci.Text = "Registro Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'cmdLstABEOP
        '
        Me.cmdLstABEOP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstABEOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstABEOP.Location = New System.Drawing.Point(288, 6)
        Me.cmdLstABEOP.Name = "cmdLstABEOP"
        Me.cmdLstABEOP.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstABEOP.TabIndex = 528
        Me.cmdLstABEOP.Text = "Lst"
        Me.cmdLstABEOP.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstABEOP.UseVisualStyleBackColor = False
        '
        'txtsNomEstODP
        '
        Me.txtsNomEstODP.Location = New System.Drawing.Point(167, 28)
        Me.txtsNomEstODP.MaxLength = 100
        Me.txtsNomEstODP.Name = "txtsNomEstODP"
        Me.txtsNomEstODP.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomEstODP.TabIndex = 525
        '
        'lblsNomEstODP
        '
        Me.lblsNomEstODP.AutoSize = True
        Me.lblsNomEstODP.Location = New System.Drawing.Point(12, 34)
        Me.lblsNomEstODP.Name = "lblsNomEstODP"
        Me.lblsNomEstODP.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomEstODP.TabIndex = 527
        Me.lblsNomEstODP.Text = "Descripción"
        '
        'txtsCodEstODP
        '
        Me.txtsCodEstODP.Location = New System.Drawing.Point(167, 3)
        Me.txtsCodEstODP.MaxLength = 8
        Me.txtsCodEstODP.Name = "txtsCodEstODP"
        Me.txtsCodEstODP.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodEstODP.TabIndex = 524
        '
        'lblsCodEstODP
        '
        Me.lblsCodEstODP.AutoSize = True
        Me.lblsCodEstODP.Location = New System.Drawing.Point(12, 9)
        Me.lblsCodEstODP.Name = "lblsCodEstODP"
        Me.lblsCodEstODP.Size = New System.Drawing.Size(93, 13)
        Me.lblsCodEstODP.TabIndex = 526
        Me.lblsCodEstODP.Text = "Código del Estado"
        '
        'txtnNroOrd
        '
        Me.txtnNroOrd.Location = New System.Drawing.Point(167, 54)
        Me.txtnNroOrd.MaxLength = 8
        Me.txtnNroOrd.Name = "txtnNroOrd"
        Me.txtnNroOrd.Size = New System.Drawing.Size(100, 20)
        Me.txtnNroOrd.TabIndex = 531
        '
        'frmABEOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.txtnNroOrd)
        Me.Controls.Add(Me.lblNroOrd)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstABEOP)
        Me.Controls.Add(Me.txtsNomEstODP)
        Me.Controls.Add(Me.lblsNomEstODP)
        Me.Controls.Add(Me.txtsCodEstODP)
        Me.Controls.Add(Me.lblsCodEstODP)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmABEOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados de la Orden de Producción"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCrear As Button
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents lblNroOrd As Label
    Friend WithEvents chbbRegAci As CheckBox
    Friend WithEvents cmdLstABEOP As Button
    Friend WithEvents txtsNomEstODP As TextBox
    Friend WithEvents lblsNomEstODP As Label
    Friend WithEvents txtsCodEstODP As TextBox
    Friend WithEvents lblsCodEstODP As Label
    Friend WithEvents txtnNroOrd As TextBox
End Class
