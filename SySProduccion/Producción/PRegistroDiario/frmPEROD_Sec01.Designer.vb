<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEROD_Sec01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEROD_Sec01))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.grpbx01 = New System.Windows.Forms.GroupBox()
        Me.cmdOpe01999 = New System.Windows.Forms.Button()
        Me.cmdOpe01001 = New System.Windows.Forms.Button()
        Me.cmdOpe01058 = New System.Windows.Forms.Button()
        Me.cmdOpe01023 = New System.Windows.Forms.Button()
        Me.cmdOpe01013 = New System.Windows.Forms.Button()
        Me.cmdOpe01007 = New System.Windows.Forms.Button()
        Me.cmdOpe01006 = New System.Windows.Forms.Button()
        Me.cmdOpe01003 = New System.Windows.Forms.Button()
        Me.grpbx01.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(325, 180)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(140, 70)
        Me.cmdCancelar.TabIndex = 110
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'grpbx01
        '
        Me.grpbx01.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpbx01.Controls.Add(Me.cmdOpe01999)
        Me.grpbx01.Controls.Add(Me.cmdOpe01001)
        Me.grpbx01.Controls.Add(Me.cmdCancelar)
        Me.grpbx01.Controls.Add(Me.cmdOpe01058)
        Me.grpbx01.Controls.Add(Me.cmdOpe01023)
        Me.grpbx01.Controls.Add(Me.cmdOpe01013)
        Me.grpbx01.Controls.Add(Me.cmdOpe01007)
        Me.grpbx01.Controls.Add(Me.cmdOpe01006)
        Me.grpbx01.Controls.Add(Me.cmdOpe01003)
        Me.grpbx01.ForeColor = System.Drawing.Color.Black
        Me.grpbx01.Location = New System.Drawing.Point(5, 5)
        Me.grpbx01.Name = "grpbx01"
        Me.grpbx01.Size = New System.Drawing.Size(480, 263)
        Me.grpbx01.TabIndex = 583
        Me.grpbx01.TabStop = False
        Me.grpbx01.Text = " Operaciones "
        '
        'cmdOpe01999
        '
        Me.cmdOpe01999.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01999.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01999.Location = New System.Drawing.Point(165, 180)
        Me.cmdOpe01999.Name = "cmdOpe01999"
        Me.cmdOpe01999.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01999.TabIndex = 111
        Me.cmdOpe01999.Text = "Otros " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01999"
        Me.cmdOpe01999.UseVisualStyleBackColor = False
        '
        'cmdOpe01001
        '
        Me.cmdOpe01001.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01001.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01001.Location = New System.Drawing.Point(5, 20)
        Me.cmdOpe01001.Name = "cmdOpe01001"
        Me.cmdOpe01001.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01001.TabIndex = 10
        Me.cmdOpe01001.Text = "Pesaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01001"
        Me.cmdOpe01001.UseVisualStyleBackColor = False
        '
        'cmdOpe01058
        '
        Me.cmdOpe01058.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01058.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01058.Location = New System.Drawing.Point(5, 180)
        Me.cmdOpe01058.Name = "cmdOpe01058"
        Me.cmdOpe01058.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01058.TabIndex = 9
        Me.cmdOpe01058.Text = "Filtración estéril" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01058"
        Me.cmdOpe01058.UseVisualStyleBackColor = False
        '
        'cmdOpe01023
        '
        Me.cmdOpe01023.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01023.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01023.Location = New System.Drawing.Point(325, 100)
        Me.cmdOpe01023.Name = "cmdOpe01023"
        Me.cmdOpe01023.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01023.TabIndex = 7
        Me.cmdOpe01023.Text = "Control Calidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01023" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdOpe01023.UseVisualStyleBackColor = False
        '
        'cmdOpe01013
        '
        Me.cmdOpe01013.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01013.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01013.Location = New System.Drawing.Point(165, 100)
        Me.cmdOpe01013.Name = "cmdOpe01013"
        Me.cmdOpe01013.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01013.TabIndex = 6
        Me.cmdOpe01013.Text = "Fabricación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01013"
        Me.cmdOpe01013.UseVisualStyleBackColor = False
        '
        'cmdOpe01007
        '
        Me.cmdOpe01007.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01007.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01007.Location = New System.Drawing.Point(5, 100)
        Me.cmdOpe01007.Name = "cmdOpe01007"
        Me.cmdOpe01007.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01007.TabIndex = 5
        Me.cmdOpe01007.Text = "Despacho Material" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01007"
        Me.cmdOpe01007.UseVisualStyleBackColor = False
        '
        'cmdOpe01006
        '
        Me.cmdOpe01006.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01006.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01006.Location = New System.Drawing.Point(325, 20)
        Me.cmdOpe01006.Name = "cmdOpe01006"
        Me.cmdOpe01006.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01006.TabIndex = 3
        Me.cmdOpe01006.Text = "Recepción MP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01006"
        Me.cmdOpe01006.UseVisualStyleBackColor = False
        '
        'cmdOpe01003
        '
        Me.cmdOpe01003.BackColor = System.Drawing.Color.Thistle
        Me.cmdOpe01003.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpe01003.Location = New System.Drawing.Point(165, 20)
        Me.cmdOpe01003.Name = "cmdOpe01003"
        Me.cmdOpe01003.Size = New System.Drawing.Size(140, 70)
        Me.cmdOpe01003.TabIndex = 2
        Me.cmdOpe01003.Text = "Lim/Aco Área" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01003"
        Me.cmdOpe01003.UseVisualStyleBackColor = False
        '
        'frmPEROD_Sec01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(494, 270)
        Me.Controls.Add(Me.grpbx01)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEROD_Sec01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sección: 01 Pesaje"
        Me.grpbx01.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents grpbx01 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOpe01023 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01013 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01007 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01006 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01003 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01058 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01001 As System.Windows.Forms.Button
    Friend WithEvents cmdOpe01999 As System.Windows.Forms.Button
End Class
