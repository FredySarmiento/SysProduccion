<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEROD_Opc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEROD_Opc))
        Me.cmdAlmuerzo = New System.Windows.Forms.Button()
        Me.cmdDescanso = New System.Windows.Forms.Button()
        Me.cmdTerminar = New System.Windows.Forms.Button()
        Me.cmdOperaciones = New System.Windows.Forms.Button()
        Me.cmdNoOperativas = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAlmuerzo
        '
        Me.cmdAlmuerzo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAlmuerzo.BackColor = System.Drawing.Color.Linen
        Me.cmdAlmuerzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlmuerzo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlmuerzo.Location = New System.Drawing.Point(198, 101)
        Me.cmdAlmuerzo.Name = "cmdAlmuerzo"
        Me.cmdAlmuerzo.Size = New System.Drawing.Size(160, 80)
        Me.cmdAlmuerzo.TabIndex = 35
        Me.cmdAlmuerzo.Text = "&Almuerzo"
        Me.cmdAlmuerzo.UseVisualStyleBackColor = False
        '
        'cmdDescanso
        '
        Me.cmdDescanso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdDescanso.BackColor = System.Drawing.Color.Linen
        Me.cmdDescanso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDescanso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDescanso.Location = New System.Drawing.Point(198, 11)
        Me.cmdDescanso.Name = "cmdDescanso"
        Me.cmdDescanso.Size = New System.Drawing.Size(160, 80)
        Me.cmdDescanso.TabIndex = 25
        Me.cmdDescanso.Text = "&Descanso"
        Me.cmdDescanso.UseVisualStyleBackColor = False
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdTerminar.BackColor = System.Drawing.Color.IndianRed
        Me.cmdTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminar.Location = New System.Drawing.Point(23, 200)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.Size = New System.Drawing.Size(336, 80)
        Me.cmdTerminar.TabIndex = 15
        Me.cmdTerminar.Text = "&Terminar Operación"
        Me.cmdTerminar.UseVisualStyleBackColor = False
        '
        'cmdOperaciones
        '
        Me.cmdOperaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdOperaciones.BackColor = System.Drawing.Color.Thistle
        Me.cmdOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOperaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOperaciones.Location = New System.Drawing.Point(23, 11)
        Me.cmdOperaciones.Name = "cmdOperaciones"
        Me.cmdOperaciones.Size = New System.Drawing.Size(160, 80)
        Me.cmdOperaciones.TabIndex = 20
        Me.cmdOperaciones.Text = "&Operativas"
        Me.cmdOperaciones.UseVisualStyleBackColor = False
        '
        'cmdNoOperativas
        '
        Me.cmdNoOperativas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdNoOperativas.BackColor = System.Drawing.Color.Thistle
        Me.cmdNoOperativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNoOperativas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNoOperativas.Location = New System.Drawing.Point(23, 101)
        Me.cmdNoOperativas.Name = "cmdNoOperativas"
        Me.cmdNoOperativas.Size = New System.Drawing.Size(160, 80)
        Me.cmdNoOperativas.TabIndex = 30
        Me.cmdNoOperativas.Text = "&No Operativas"
        Me.cmdNoOperativas.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(23, 290)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(336, 80)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmPEROD_Opc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(384, 382)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdNoOperativas)
        Me.Controls.Add(Me.cmdOperaciones)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.cmdAlmuerzo)
        Me.Controls.Add(Me.cmdDescanso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEROD_Opc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Opción"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAlmuerzo As System.Windows.Forms.Button
    Friend WithEvents cmdDescanso As System.Windows.Forms.Button
    Friend WithEvents cmdTerminar As System.Windows.Forms.Button
    Friend WithEvents cmdOperaciones As System.Windows.Forms.Button
    Friend WithEvents cmdNoOperativas As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
