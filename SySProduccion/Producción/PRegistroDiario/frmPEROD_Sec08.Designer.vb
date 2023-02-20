<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEROD_Sec08
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEROD_Sec08))
        Me.grpbx01 = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOpe08044 = New System.Windows.Forms.Button()
        Me.cmdOpe08037 = New System.Windows.Forms.Button()
        Me.cmdOpe08016 = New System.Windows.Forms.Button()
        Me.cmdOpe08006 = New System.Windows.Forms.Button()
        Me.cmdOpe08005 = New System.Windows.Forms.Button()
        Me.cmdOpe08003 = New System.Windows.Forms.Button()
        Me.cmdOpe08999 = New System.Windows.Forms.Button()
        Me.grpbx01.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbx01
        '
        Me.grpbx01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpbx01.Controls.Add(Me.cmdOpe08999)
        Me.grpbx01.Controls.Add(Me.cmdCancelar)
        Me.grpbx01.Controls.Add(Me.cmdOpe08044)
        Me.grpbx01.Controls.Add(Me.cmdOpe08037)
        Me.grpbx01.Controls.Add(Me.cmdOpe08016)
        Me.grpbx01.Controls.Add(Me.cmdOpe08006)
        Me.grpbx01.Controls.Add(Me.cmdOpe08005)
        Me.grpbx01.Controls.Add(Me.cmdOpe08003)
        Me.grpbx01.Location = New System.Drawing.Point(5, 5)
        Me.grpbx01.Name = "grpbx01"
        Me.grpbx01.Size = New System.Drawing.Size(471, 260)
        Me.grpbx01.TabIndex = 585
        Me.grpbx01.TabStop = False
        Me.grpbx01.Text = " Operaciones "
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(325, 180)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(140, 70)
        Me.cmdCancelar.TabIndex = 585
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOpe08044
        '
        Me.cmdOpe08044.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08044.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08044.Location = New System.Drawing.Point(325, 100)
        Me.cmdOpe08044.Name = "cmdOpe08044"
        Me.cmdOpe08044.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08044.TabIndex = 6
        Me.cmdOpe08044.Text = "Sellado Colapsibles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08044"
        Me.cmdOpe08044.UseVisualStyleBackColor = False
        '
        'cmdOpe08037
        '
        Me.cmdOpe08037.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08037.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08037.Location = New System.Drawing.Point(165, 100)
        Me.cmdOpe08037.Name = "cmdOpe08037"
        Me.cmdOpe08037.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08037.TabIndex = 5
        Me.cmdOpe08037.Text = "Control de Peso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08037"
        Me.cmdOpe08037.UseVisualStyleBackColor = False
        '
        'cmdOpe08016
        '
        Me.cmdOpe08016.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08016.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08016.Location = New System.Drawing.Point(5, 100)
        Me.cmdOpe08016.Name = "cmdOpe08016"
        Me.cmdOpe08016.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08016.TabIndex = 4
        Me.cmdOpe08016.Text = "Llenado Tolva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08016"
        Me.cmdOpe08016.UseVisualStyleBackColor = False
        '
        'cmdOpe08006
        '
        Me.cmdOpe08006.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08006.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08006.Location = New System.Drawing.Point(325, 20)
        Me.cmdOpe08006.Name = "cmdOpe08006"
        Me.cmdOpe08006.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08006.TabIndex = 3
        Me.cmdOpe08006.Text = "Recepción MP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08006"
        Me.cmdOpe08006.UseVisualStyleBackColor = False
        '
        'cmdOpe08005
        '
        Me.cmdOpe08005.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08005.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08005.Location = New System.Drawing.Point(165, 20)
        Me.cmdOpe08005.Name = "cmdOpe08005"
        Me.cmdOpe08005.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08005.TabIndex = 1
        Me.cmdOpe08005.Text = "Limpieza Equipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08005"
        Me.cmdOpe08005.UseVisualStyleBackColor = False
        '
        'cmdOpe08003
        '
        Me.cmdOpe08003.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08003.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08003.Location = New System.Drawing.Point(5, 20)
        Me.cmdOpe08003.Name = "cmdOpe08003"
        Me.cmdOpe08003.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08003.TabIndex = 2
        Me.cmdOpe08003.Text = "Limp/Acond  Área" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "08003"
        Me.cmdOpe08003.UseVisualStyleBackColor = False
        '
        'cmdOpe08999
        '
        Me.cmdOpe08999.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe08999.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe08999.Location = New System.Drawing.Point(5, 180)
        Me.cmdOpe08999.Name = "cmdOpe08999"
        Me.cmdOpe08999.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe08999.TabIndex = 586
        Me.cmdOpe08999.Text = "Otros 08999"
        Me.cmdOpe08999.UseVisualStyleBackColor = False
        '
        'frmPEROD_Sec08
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(479, 266)
        Me.Controls.Add(Me.grpbx01)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEROD_Sec08"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sección: 08 Colapsibles"
        Me.grpbx01.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbx01 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOpe08044 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe08037 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe08016 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe08006 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe08005 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe08003 As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOpe08999 As System.Windows.Forms.Button
End Class
