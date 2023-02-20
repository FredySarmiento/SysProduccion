<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATANA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATANA))
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdLstATPANA = New System.Windows.Forms.Button()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.cmdLstATANA = New System.Windows.Forms.Button()
        Me.txtsNomAna = New System.Windows.Forms.TextBox()
        Me.lblsNomAna = New System.Windows.Forms.Label()
        Me.txtsCodAna = New System.Windows.Forms.TextBox()
        Me.lblsCodAna = New System.Windows.Forms.Label()
        Me.lblCodTIA = New System.Windows.Forms.Label()
        Me.cboATTIA = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(2, 238)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 494
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(2, 238)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 496
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(2, 238)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 499
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(2, 238)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 497
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(84, 238)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 495
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(2, 238)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 498
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cmdLstATPANA
        '
        Me.cmdLstATPANA.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATPANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATPANA.Location = New System.Drawing.Point(125, 12)
        Me.cmdLstATPANA.Name = "cmdLstATPANA"
        Me.cmdLstATPANA.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATPANA.TabIndex = 512
        Me.cmdLstATPANA.Text = "Lst"
        Me.cmdLstATPANA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATPANA.UseVisualStyleBackColor = False
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(12, 87)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(94, 17)
        Me.chbbRegAci.TabIndex = 519
        Me.chbbRegAci.Text = "Análisis Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'cmdLstATANA
        '
        Me.cmdLstATANA.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATANA.Location = New System.Drawing.Point(288, 6)
        Me.cmdLstATANA.Name = "cmdLstATANA"
        Me.cmdLstATANA.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATANA.TabIndex = 518
        Me.cmdLstATANA.Text = "Lst"
        Me.cmdLstATANA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATANA.UseVisualStyleBackColor = False
        '
        'txtsNomAna
        '
        Me.txtsNomAna.Location = New System.Drawing.Point(167, 28)
        Me.txtsNomAna.MaxLength = 100
        Me.txtsNomAna.Name = "txtsNomAna"
        Me.txtsNomAna.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomAna.TabIndex = 515
        '
        'lblsNomAna
        '
        Me.lblsNomAna.AutoSize = True
        Me.lblsNomAna.Location = New System.Drawing.Point(12, 34)
        Me.lblsNomAna.Name = "lblsNomAna"
        Me.lblsNomAna.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomAna.TabIndex = 517
        Me.lblsNomAna.Text = "Descripción"
        '
        'txtsCodAna
        '
        Me.txtsCodAna.Location = New System.Drawing.Point(167, 3)
        Me.txtsCodAna.MaxLength = 8
        Me.txtsCodAna.Name = "txtsCodAna"
        Me.txtsCodAna.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodAna.TabIndex = 514
        '
        'lblsCodAna
        '
        Me.lblsCodAna.AutoSize = True
        Me.lblsCodAna.Location = New System.Drawing.Point(12, 9)
        Me.lblsCodAna.Name = "lblsCodAna"
        Me.lblsCodAna.Size = New System.Drawing.Size(94, 13)
        Me.lblsCodAna.TabIndex = 516
        Me.lblsCodAna.Text = "Código del análisis"
        '
        'lblCodTIA
        '
        Me.lblCodTIA.AutoSize = True
        Me.lblCodTIA.Location = New System.Drawing.Point(12, 57)
        Me.lblCodTIA.Name = "lblCodTIA"
        Me.lblCodTIA.Size = New System.Drawing.Size(129, 13)
        Me.lblCodTIA.TabIndex = 521
        Me.lblCodTIA.Text = "Código del tipo de análisis"
        '
        'cboATTIA
        '
        Me.cboATTIA.FormattingEnabled = True
        Me.cboATTIA.Location = New System.Drawing.Point(167, 55)
        Me.cboATTIA.Name = "cboATTIA"
        Me.cboATTIA.Size = New System.Drawing.Size(100, 21)
        Me.cboATTIA.TabIndex = 523
        '
        'frmATANA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.cboATTIA)
        Me.Controls.Add(Me.lblCodTIA)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATANA)
        Me.Controls.Add(Me.txtsNomAna)
        Me.Controls.Add(Me.lblsNomAna)
        Me.Controls.Add(Me.txtsCodAna)
        Me.Controls.Add(Me.lblsCodAna)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATANA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Análisis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdLstATPANA As System.Windows.Forms.Button
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLstATANA As System.Windows.Forms.Button
    Friend WithEvents txtsNomAna As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomAna As System.Windows.Forms.Label
    Friend WithEvents txtsCodAna As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodAna As System.Windows.Forms.Label
    Friend WithEvents lblCodTIA As System.Windows.Forms.Label
    Friend WithEvents cboATTIA As System.Windows.Forms.ComboBox
End Class
