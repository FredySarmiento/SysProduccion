<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEODP_SelRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEODP_SelRpt))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.lblbImpOdp = New System.Windows.Forms.Label()
        Me.chbbImpOdp = New System.Windows.Forms.CheckBox()
        Me.lblbImpCld = New System.Windows.Forms.Label()
        Me.chbbImpCld = New System.Windows.Forms.CheckBox()
        Me.lblbImpEti = New System.Windows.Forms.Label()
        Me.chbbImpEti = New System.Windows.Forms.CheckBox()
        Me.lblbImpSal = New System.Windows.Forms.Label()
        Me.chbbImpSal = New System.Windows.Forms.CheckBox()
        Me.lblbImpOpe = New System.Windows.Forms.Label()
        Me.chbbImpOpe = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(84, 186)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 135
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(4, 186)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 134
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'lblbImpOdp
        '
        Me.lblbImpOdp.AutoSize = True
        Me.lblbImpOdp.Location = New System.Drawing.Point(35, 40)
        Me.lblbImpOdp.Name = "lblbImpOdp"
        Me.lblbImpOdp.Size = New System.Drawing.Size(111, 13)
        Me.lblbImpOdp.TabIndex = 137
        Me.lblbImpOdp.Text = "Orden de Producción "
        '
        'chbbImpOdp
        '
        Me.chbbImpOdp.AutoSize = True
        Me.chbbImpOdp.Location = New System.Drawing.Point(225, 40)
        Me.chbbImpOdp.Name = "chbbImpOdp"
        Me.chbbImpOdp.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpOdp.TabIndex = 136
        Me.chbbImpOdp.UseVisualStyleBackColor = True
        '
        'lblbImpCld
        '
        Me.lblbImpCld.AutoSize = True
        Me.lblbImpCld.Location = New System.Drawing.Point(35, 65)
        Me.lblbImpCld.Name = "lblbImpCld"
        Me.lblbImpCld.Size = New System.Drawing.Size(78, 13)
        Me.lblbImpCld.TabIndex = 139
        Me.lblbImpCld.Text = "Control Calidad"
        '
        'chbbImpCld
        '
        Me.chbbImpCld.AutoSize = True
        Me.chbbImpCld.Location = New System.Drawing.Point(225, 65)
        Me.chbbImpCld.Name = "chbbImpCld"
        Me.chbbImpCld.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpCld.TabIndex = 138
        Me.chbbImpCld.UseVisualStyleBackColor = True
        '
        'lblbImpEti
        '
        Me.lblbImpEti.AutoSize = True
        Me.lblbImpEti.Location = New System.Drawing.Point(35, 90)
        Me.lblbImpEti.Name = "lblbImpEti"
        Me.lblbImpEti.Size = New System.Drawing.Size(51, 13)
        Me.lblbImpEti.TabIndex = 141
        Me.lblbImpEti.Text = "Etiquetas"
        '
        'chbbImpEti
        '
        Me.chbbImpEti.AutoSize = True
        Me.chbbImpEti.Location = New System.Drawing.Point(225, 88)
        Me.chbbImpEti.Name = "chbbImpEti"
        Me.chbbImpEti.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpEti.TabIndex = 140
        Me.chbbImpEti.UseVisualStyleBackColor = True
        '
        'lblbImpSal
        '
        Me.lblbImpSal.AutoSize = True
        Me.lblbImpSal.Location = New System.Drawing.Point(35, 115)
        Me.lblbImpSal.Name = "lblbImpSal"
        Me.lblbImpSal.Size = New System.Drawing.Size(109, 13)
        Me.lblbImpSal.TabIndex = 143
        Me.lblbImpSal.Text = "Salidas de MP y MEE"
        '
        'chbbImpSal
        '
        Me.chbbImpSal.AutoSize = True
        Me.chbbImpSal.Location = New System.Drawing.Point(225, 117)
        Me.chbbImpSal.Name = "chbbImpSal"
        Me.chbbImpSal.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpSal.TabIndex = 142
        Me.chbbImpSal.UseVisualStyleBackColor = True
        '
        'lblbImpOpe
        '
        Me.lblbImpOpe.AutoSize = True
        Me.lblbImpOpe.Location = New System.Drawing.Point(35, 140)
        Me.lblbImpOpe.Name = "lblbImpOpe"
        Me.lblbImpOpe.Size = New System.Drawing.Size(67, 13)
        Me.lblbImpOpe.TabIndex = 145
        Me.lblbImpOpe.Text = "Operaciones"
        '
        'chbbImpOpe
        '
        Me.chbbImpOpe.AutoSize = True
        Me.chbbImpOpe.Location = New System.Drawing.Point(225, 142)
        Me.chbbImpOpe.Name = "chbbImpOpe"
        Me.chbbImpOpe.Size = New System.Drawing.Size(15, 14)
        Me.chbbImpOpe.TabIndex = 144
        Me.chbbImpOpe.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Imprimir Reporte"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(35, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 13)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "_________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(38, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 13)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "_________________________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(40, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 13)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "_________________________________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(35, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 13)
        Me.Label9.TabIndex = 201
        Me.Label9.Text = "_________________________________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(38, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 13)
        Me.Label10.TabIndex = 202
        Me.Label10.Text = "_________________________________"
        '
        'frmPEODP_SelRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(284, 212)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblbImpOpe)
        Me.Controls.Add(Me.chbbImpOpe)
        Me.Controls.Add(Me.lblbImpSal)
        Me.Controls.Add(Me.chbbImpSal)
        Me.Controls.Add(Me.lblbImpEti)
        Me.Controls.Add(Me.chbbImpEti)
        Me.Controls.Add(Me.lblbImpCld)
        Me.Controls.Add(Me.chbbImpCld)
        Me.Controls.Add(Me.lblbImpOdp)
        Me.Controls.Add(Me.chbbImpOdp)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEODP_SelRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Reporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents lblbImpOdp As System.Windows.Forms.Label
    Friend WithEvents chbbImpOdp As System.Windows.Forms.CheckBox
    Friend WithEvents lblbImpCld As System.Windows.Forms.Label
    Friend WithEvents chbbImpCld As System.Windows.Forms.CheckBox
    Friend WithEvents lblbImpEti As System.Windows.Forms.Label
    Friend WithEvents chbbImpEti As System.Windows.Forms.CheckBox
    Friend WithEvents lblbImpSal As System.Windows.Forms.Label
    Friend WithEvents chbbImpSal As System.Windows.Forms.CheckBox
    Friend WithEvents lblbImpOpe As System.Windows.Forms.Label
    Friend WithEvents chbbImpOpe As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
