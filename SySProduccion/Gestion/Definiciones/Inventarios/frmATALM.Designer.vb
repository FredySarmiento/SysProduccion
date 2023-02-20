<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmATALM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATALM))
        Me.lblCodAlm = New System.Windows.Forms.Label()
        Me.lblsNomAlm = New System.Windows.Forms.Label()
        Me.txtsCodAlm = New System.Windows.Forms.TextBox()
        Me.txtsNomAlm = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtsUbiAlm = New System.Windows.Forms.TextBox()
        Me.lblsUbiAlm = New System.Windows.Forms.Label()
        Me.lblLin18 = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.cmdLstATALM = New System.Windows.Forms.Button()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodAlm
        '
        Me.lblCodAlm.AutoSize = True
        Me.lblCodAlm.Location = New System.Drawing.Point(5, 10)
        Me.lblCodAlm.Name = "lblCodAlm"
        Me.lblCodAlm.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAlm.TabIndex = 0
        Me.lblCodAlm.Text = "Código almacén"
        '
        'lblsNomAlm
        '
        Me.lblsNomAlm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsNomAlm.AutoSize = True
        Me.lblsNomAlm.Location = New System.Drawing.Point(4, 36)
        Me.lblsNomAlm.Name = "lblsNomAlm"
        Me.lblsNomAlm.Size = New System.Drawing.Size(87, 13)
        Me.lblsNomAlm.TabIndex = 1
        Me.lblsNomAlm.Text = "Nombre almacén"
        '
        'txtsCodAlm
        '
        Me.txtsCodAlm.Location = New System.Drawing.Point(130, 5)
        Me.txtsCodAlm.Name = "txtsCodAlm"
        Me.txtsCodAlm.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodAlm.TabIndex = 2
        '
        'txtsNomAlm
        '
        Me.txtsNomAlm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsNomAlm.Location = New System.Drawing.Point(130, 30)
        Me.txtsNomAlm.Name = "txtsNomAlm"
        Me.txtsNomAlm.Size = New System.Drawing.Size(301, 20)
        Me.txtsNomAlm.TabIndex = 4
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(85, 317)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 125
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 317)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 123
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(6, 316)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 124
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 316)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 126
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(6, 316)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 127
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 316)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 128
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(5, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(696, 237)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.txtsUbiAlm)
        Me.TabPage1.Controls.Add(Me.lblsUbiAlm)
        Me.TabPage1.Controls.Add(Me.lblLin18)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(688, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'txtsUbiAlm
        '
        Me.txtsUbiAlm.Location = New System.Drawing.Point(116, 4)
        Me.txtsUbiAlm.Name = "txtsUbiAlm"
        Me.txtsUbiAlm.Size = New System.Drawing.Size(446, 20)
        Me.txtsUbiAlm.TabIndex = 8
        '
        'lblsUbiAlm
        '
        Me.lblsUbiAlm.AutoSize = True
        Me.lblsUbiAlm.Location = New System.Drawing.Point(5, 10)
        Me.lblsUbiAlm.Name = "lblsUbiAlm"
        Me.lblsUbiAlm.Size = New System.Drawing.Size(55, 13)
        Me.lblsUbiAlm.TabIndex = 0
        Me.lblsUbiAlm.Text = "Ubicación"
        '
        'lblLin18
        '
        Me.lblLin18.AutoSize = True
        Me.lblLin18.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin18.Location = New System.Drawing.Point(6, 11)
        Me.lblLin18.Name = "lblLin18"
        Me.lblLin18.Size = New System.Drawing.Size(229, 13)
        Me.lblLin18.TabIndex = 247
        Me.lblLin18.Text = "_____________________________________"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(2, 12)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(205, 13)
        Me.lblLin01.TabIndex = 248
        Me.lblLin01.Text = "_________________________________"
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(4, 37)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(205, 13)
        Me.lblLin02.TabIndex = 249
        Me.lblLin02.Text = "_________________________________"
        '
        'cmdLstATALM
        '
        Me.cmdLstATALM.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATALM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATALM.Location = New System.Drawing.Point(260, 5)
        Me.cmdLstATALM.Name = "cmdLstATALM"
        Me.cmdLstATALM.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATALM.TabIndex = 495
        Me.cmdLstATALM.Text = "Lst"
        Me.cmdLstATALM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATALM.UseVisualStyleBackColor = False
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(592, 33)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(100, 17)
        Me.chbbRegAci.TabIndex = 497
        Me.chbbRegAci.Text = "Almacén Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        Me.chbbRegAci.Visible = False
        '
        'frmATALM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(704, 342)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATALM)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.txtsNomAlm)
        Me.Controls.Add(Me.txtsCodAlm)
        Me.Controls.Add(Me.lblsNomAlm)
        Me.Controls.Add(Me.lblCodAlm)
        Me.Controls.Add(Me.lblLin01)
        Me.Controls.Add(Me.lblLin02)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATALM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacenes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodAlm As System.Windows.Forms.Label
    Friend WithEvents lblsNomAlm As System.Windows.Forms.Label
    Friend WithEvents txtsCodAlm As System.Windows.Forms.TextBox
    Friend WithEvents txtsNomAlm As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtsUbiAlm As System.Windows.Forms.TextBox
    Friend WithEvents lblsUbiAlm As System.Windows.Forms.Label
    Friend WithEvents lblLin18 As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents cmdLstATALM As System.Windows.Forms.Button
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
End Class
