<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATPCO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATPCO))
        Me.cboABEPC = New System.Windows.Forms.ComboBox()
        Me.lblEstPdo = New System.Windows.Forms.Label()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.cmdLstATPCO = New System.Windows.Forms.Button()
        Me.txtsNomPdo = New System.Windows.Forms.TextBox()
        Me.lblsNomTra = New System.Windows.Forms.Label()
        Me.txtsCodPdo = New System.Windows.Forms.TextBox()
        Me.lblsCodPco = New System.Windows.Forms.Label()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.lblFecIni = New System.Windows.Forms.Label()
        Me.lblFecFin = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.txtsCodAno = New System.Windows.Forms.TextBox()
        Me.lblsCodAno = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'cboABEPC
        '
        Me.cboABEPC.FormattingEnabled = True
        Me.cboABEPC.Items.AddRange(New Object() {"E", "S"})
        Me.cboABEPC.Location = New System.Drawing.Point(160, 54)
        Me.cboABEPC.Name = "cboABEPC"
        Me.cboABEPC.Size = New System.Drawing.Size(100, 21)
        Me.cboABEPC.TabIndex = 20
        '
        'lblEstPdo
        '
        Me.lblEstPdo.AutoSize = True
        Me.lblEstPdo.Location = New System.Drawing.Point(5, 61)
        Me.lblEstPdo.Name = "lblEstPdo"
        Me.lblEstPdo.Size = New System.Drawing.Size(98, 13)
        Me.lblEstPdo.TabIndex = 550
        Me.lblEstPdo.Text = "Estado del Período"
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(8, 163)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(97, 17)
        Me.chbbRegAci.TabIndex = 40
        Me.chbbRegAci.Text = "Período Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'cmdLstATPCO
        '
        Me.cmdLstATPCO.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATPCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATPCO.Location = New System.Drawing.Point(281, 8)
        Me.cmdLstATPCO.Name = "cmdLstATPCO"
        Me.cmdLstATPCO.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATPCO.TabIndex = 10
        Me.cmdLstATPCO.Text = "Lst"
        Me.cmdLstATPCO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATPCO.UseVisualStyleBackColor = False
        '
        'txtsNomPdo
        '
        Me.txtsNomPdo.Location = New System.Drawing.Point(160, 30)
        Me.txtsNomPdo.MaxLength = 100
        Me.txtsNomPdo.Name = "txtsNomPdo"
        Me.txtsNomPdo.Size = New System.Drawing.Size(412, 20)
        Me.txtsNomPdo.TabIndex = 15
        '
        'lblsNomTra
        '
        Me.lblsNomTra.AutoSize = True
        Me.lblsNomTra.Location = New System.Drawing.Point(5, 36)
        Me.lblsNomTra.Name = "lblsNomTra"
        Me.lblsNomTra.Size = New System.Drawing.Size(63, 13)
        Me.lblsNomTra.TabIndex = 547
        Me.lblsNomTra.Text = "Descripción"
        '
        'txtsCodPdo
        '
        Me.txtsCodPdo.Location = New System.Drawing.Point(160, 5)
        Me.txtsCodPdo.MaxLength = 8
        Me.txtsCodPdo.Name = "txtsCodPdo"
        Me.txtsCodPdo.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodPdo.TabIndex = 5
        '
        'lblsCodPco
        '
        Me.lblsCodPco.AutoSize = True
        Me.lblsCodPco.Location = New System.Drawing.Point(5, 11)
        Me.lblsCodPco.Name = "lblsCodPco"
        Me.lblsCodPco.Size = New System.Drawing.Size(129, 13)
        Me.lblsCodPco.TabIndex = 546
        Me.lblsCodPco.Text = "Código Período Contable:"
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(4, 223)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 50
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(4, 223)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 540
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(4, 223)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 543
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(4, 223)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 541
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(85, 223)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 100
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(4, 223)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 542
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'lblFecIni
        '
        Me.lblFecIni.AutoSize = True
        Me.lblFecIni.Location = New System.Drawing.Point(5, 86)
        Me.lblFecIni.Name = "lblFecIni"
        Me.lblFecIni.Size = New System.Drawing.Size(73, 13)
        Me.lblFecIni.TabIndex = 553
        Me.lblFecIni.Text = "Fecha Inicial :"
        '
        'lblFecFin
        '
        Me.lblFecFin.AutoSize = True
        Me.lblFecFin.Location = New System.Drawing.Point(5, 112)
        Me.lblFecFin.Name = "lblFecFin"
        Me.lblFecFin.Size = New System.Drawing.Size(68, 13)
        Me.lblFecFin.TabIndex = 554
        Me.lblFecFin.Text = "Fecha Final :"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(160, 80)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecIni.TabIndex = 25
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(160, 106)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecFin.TabIndex = 30
        '
        'txtsCodAno
        '
        Me.txtsCodAno.Location = New System.Drawing.Point(160, 132)
        Me.txtsCodAno.MaxLength = 8
        Me.txtsCodAno.Name = "txtsCodAno"
        Me.txtsCodAno.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodAno.TabIndex = 35
        '
        'lblsCodAno
        '
        Me.lblsCodAno.AutoSize = True
        Me.lblsCodAno.Location = New System.Drawing.Point(5, 138)
        Me.lblsCodAno.Name = "lblsCodAno"
        Me.lblsCodAno.Size = New System.Drawing.Size(112, 13)
        Me.lblsCodAno.TabIndex = 558
        Me.lblsCodAno.Text = "Año Período Contable"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 245)
        Me.ShapeContainer1.TabIndex = 559
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 8
        Me.LineShape6.X2 = 256
        Me.LineShape6.Y1 = 151
        Me.LineShape6.Y2 = 151
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 8
        Me.LineShape5.X2 = 256
        Me.LineShape5.Y1 = 125
        Me.LineShape5.Y2 = 125
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 9
        Me.LineShape4.X2 = 257
        Me.LineShape4.Y1 = 99
        Me.LineShape4.Y2 = 99
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 9
        Me.LineShape3.X2 = 257
        Me.LineShape3.Y1 = 74
        Me.LineShape3.Y2 = 74
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 8
        Me.LineShape2.X2 = 256
        Me.LineShape2.Y1 = 49
        Me.LineShape2.Y2 = 49
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 7
        Me.LineShape1.X2 = 255
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 24
        '
        'frmATPCO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 245)
        Me.Controls.Add(Me.txtsCodAno)
        Me.Controls.Add(Me.lblsCodAno)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.lblFecFin)
        Me.Controls.Add(Me.lblFecIni)
        Me.Controls.Add(Me.cboABEPC)
        Me.Controls.Add(Me.lblEstPdo)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATPCO)
        Me.Controls.Add(Me.txtsNomPdo)
        Me.Controls.Add(Me.lblsNomTra)
        Me.Controls.Add(Me.txtsCodPdo)
        Me.Controls.Add(Me.lblsCodPco)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATPCO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Períodos contables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboABEPC As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstPdo As System.Windows.Forms.Label
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLstATPCO As System.Windows.Forms.Button
    Friend WithEvents txtsNomPdo As System.Windows.Forms.TextBox
    Friend WithEvents lblsNomTra As System.Windows.Forms.Label
    Friend WithEvents txtsCodPdo As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodPco As System.Windows.Forms.Label
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents lblFecIni As System.Windows.Forms.Label
    Friend WithEvents lblFecFin As System.Windows.Forms.Label
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsCodAno As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodAno As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
