<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActPEROD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActPEROD))
        Me.cmdCerrarReg = New System.Windows.Forms.Button()
        Me.cmdAbrirReg = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCerrarReg
        '
        Me.cmdCerrarReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCerrarReg.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCerrarReg.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdCerrarReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrarReg.Location = New System.Drawing.Point(60, 80)
        Me.cmdCerrarReg.Name = "cmdCerrarReg"
        Me.cmdCerrarReg.Size = New System.Drawing.Size(160, 80)
        Me.cmdCerrarReg.TabIndex = 5
        Me.cmdCerrarReg.Text = "Cie&rre Manual de Registros Diarios Producción"
        Me.cmdCerrarReg.UseVisualStyleBackColor = False
        '
        'cmdAbrirReg
        '
        Me.cmdAbrirReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAbrirReg.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAbrirReg.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdAbrirReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbrirReg.Location = New System.Drawing.Point(260, 80)
        Me.cmdAbrirReg.Name = "cmdAbrirReg"
        Me.cmdAbrirReg.Size = New System.Drawing.Size(160, 80)
        Me.cmdAbrirReg.TabIndex = 10
        Me.cmdAbrirReg.Text = "&Apertura Manual de Registros Diarios Producción"
        Me.cmdAbrirReg.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(5, 237)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 15
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmActPEROD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdCerrarReg)
        Me.Controls.Add(Me.cmdAbrirReg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActPEROD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización Manual Registro Diario Operaciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCerrarReg As System.Windows.Forms.Button
    Friend WithEvents cmdAbrirReg As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
