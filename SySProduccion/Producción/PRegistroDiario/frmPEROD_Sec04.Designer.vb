<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEROD_Sec04
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEROD_Sec04))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.grpbx04 = New System.Windows.Forms.GroupBox()
        Me.cmdOpe04040 = New System.Windows.Forms.Button()
        Me.cmdOpe04006 = New System.Windows.Forms.Button()
        Me.cmdOpe04003 = New System.Windows.Forms.Button()
        Me.cmdOpe04999 = New System.Windows.Forms.Button()
        Me.grpbx04.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(325, 100)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(140, 70)
        Me.cmdCancelar.TabIndex = 20
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'grpbx04
        '
        Me.grpbx04.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpbx04.Controls.Add(Me.cmdOpe04999)
        Me.grpbx04.Controls.Add(Me.cmdOpe04040)
        Me.grpbx04.Controls.Add(Me.cmdCancelar)
        Me.grpbx04.Controls.Add(Me.cmdOpe04006)
        Me.grpbx04.Controls.Add(Me.cmdOpe04003)
        Me.grpbx04.Location = New System.Drawing.Point(5, 5)
        Me.grpbx04.Name = "grpbx04"
        Me.grpbx04.Size = New System.Drawing.Size(473, 176)
        Me.grpbx04.TabIndex = 115
        Me.grpbx04.TabStop = False
        Me.grpbx04.Text = "Operaciones"
        '
        'cmdOpe04040
        '
        Me.cmdOpe04040.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe04040.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe04040.Location = New System.Drawing.Point(325, 19)
        Me.cmdOpe04040.Name = "cmdOpe04040"
        Me.cmdOpe04040.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe04040.TabIndex = 15
        Me.cmdOpe04040.Text = "Loteado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "04040"
        Me.cmdOpe04040.UseVisualStyleBackColor = False
        '
        'cmdOpe04006
        '
        Me.cmdOpe04006.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe04006.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe04006.Location = New System.Drawing.Point(165, 19)
        Me.cmdOpe04006.Name = "cmdOpe04006"
        Me.cmdOpe04006.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe04006.TabIndex = 10
        Me.cmdOpe04006.Text = "Recepción MP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "04006"
        Me.cmdOpe04006.UseVisualStyleBackColor = False
        '
        'cmdOpe04003
        '
        Me.cmdOpe04003.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe04003.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe04003.Location = New System.Drawing.Point(5, 20)
        Me.cmdOpe04003.Name = "cmdOpe04003"
        Me.cmdOpe04003.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe04003.TabIndex = 5
        Me.cmdOpe04003.Text = "Limp/Acond  Área" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "04003"
        Me.cmdOpe04003.UseVisualStyleBackColor = False
        '
        'cmdOpe04999
        '
        Me.cmdOpe04999.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe04999.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe04999.Location = New System.Drawing.Point(5, 100)
        Me.cmdOpe04999.Name = "cmdOpe04999"
        Me.cmdOpe04999.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe04999.TabIndex = 21
        Me.cmdOpe04999.Text = "Otros " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "04999"
        Me.cmdOpe04999.UseVisualStyleBackColor = False
        '
        'frmPEROD_Sec04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(482, 184)
        Me.Controls.Add(Me.grpbx04)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEROD_Sec04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sección : 04 Codificado"
        Me.grpbx04.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grpbx04 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOpe04040 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe04006 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe04003 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe04999 As System.Windows.Forms.Button
End Class
