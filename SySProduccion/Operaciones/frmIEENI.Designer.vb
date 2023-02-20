<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIEENI
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
        Me.pnlGral = New System.Windows.Forms.Panel()
        Me.lbl004 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cmd001 = New System.Windows.Forms.Button()
        Me.lbl007 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbl006 = New System.Windows.Forms.Label()
        Me.mtbFecDoc = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFecCtb = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbl005 = New System.Windows.Forms.Label()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecCtb = New System.Windows.Forms.DateTimePicker()
        Me.lbl003 = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl002 = New System.Windows.Forms.Label()
        Me.lbl001 = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.pnlGral.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGral
        '
        Me.pnlGral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGral.AutoScroll = True
        Me.pnlGral.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlGral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGral.Controls.Add(Me.lbl004)
        Me.pnlGral.Controls.Add(Me.TextBox4)
        Me.pnlGral.Controls.Add(Me.cmd001)
        Me.pnlGral.Controls.Add(Me.lbl007)
        Me.pnlGral.Controls.Add(Me.TextBox5)
        Me.pnlGral.Controls.Add(Me.dgv1)
        Me.pnlGral.Controls.Add(Me.lblLin04)
        Me.pnlGral.Controls.Add(Me.lblLin07)
        Me.pnlGral.Location = New System.Drawing.Point(5, 86)
        Me.pnlGral.Name = "pnlGral"
        Me.pnlGral.Size = New System.Drawing.Size(800, 272)
        Me.pnlGral.TabIndex = 60
        '
        'lbl004
        '
        Me.lbl004.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl004.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl004.Location = New System.Drawing.Point(539, 230)
        Me.lbl004.Name = "lbl004"
        Me.lbl004.Size = New System.Drawing.Size(105, 15)
        Me.lbl004.TabIndex = 109
        Me.lbl004.Text = "Total documento"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(145, 227)
        Me.TextBox4.MaxLength = 20
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(99, 20)
        Me.TextBox4.TabIndex = 122
        '
        'cmd001
        '
        Me.cmd001.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmd001.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmd001.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd001.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmd001.Location = New System.Drawing.Point(120, 231)
        Me.cmd001.Name = "cmd001"
        Me.cmd001.Size = New System.Drawing.Size(19, 10)
        Me.cmd001.TabIndex = 121
        Me.cmd001.UseVisualStyleBackColor = False
        '
        'lbl007
        '
        Me.lbl007.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl007.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl007.Location = New System.Drawing.Point(7, 229)
        Me.lbl007.Name = "lbl007"
        Me.lbl007.Size = New System.Drawing.Size(114, 13)
        Me.lbl007.TabIndex = 119
        Me.lbl007.Text = "Número documento"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(642, 228)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(116, 20)
        Me.TextBox5.TabIndex = 108
        '
        'dgv1
        '
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(5, 17)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(783, 187)
        Me.dgv1.TabIndex = 5
        '
        'lblLin04
        '
        Me.lblLin04.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(531, 233)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 110
        Me.lblLin04.Text = "___________________________"
        '
        'lblLin07
        '
        Me.lblLin07.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(7, 233)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(169, 13)
        Me.lblLin07.TabIndex = 123
        Me.lblLin07.Text = "___________________________"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(409, 429)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 104
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(249, 428)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 105
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(6, 429)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 106
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(168, 429)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 101
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(329, 429)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 102
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 429)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 103
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Location = New System.Drawing.Point(718, 50)
        Me.TextBox3.MaxLength = 12
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(83, 20)
        Me.TextBox3.TabIndex = 122
        Me.TextBox3.Text = "  "
        '
        'lbl006
        '
        Me.lbl006.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl006.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl006.Location = New System.Drawing.Point(574, 56)
        Me.lbl006.Name = "lbl006"
        Me.lbl006.Size = New System.Drawing.Size(114, 13)
        Me.lbl006.TabIndex = 131
        Me.lbl006.Text = "Referencia"
        '
        'mtbFecDoc
        '
        Me.mtbFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtbFecDoc.Location = New System.Drawing.Point(718, 27)
        Me.mtbFecDoc.Name = "mtbFecDoc"
        Me.mtbFecDoc.Size = New System.Drawing.Size(82, 20)
        Me.mtbFecDoc.TabIndex = 120
        '
        'mtbFecCtb
        '
        Me.mtbFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtbFecCtb.Location = New System.Drawing.Point(718, 3)
        Me.mtbFecCtb.Name = "mtbFecCtb"
        Me.mtbFecCtb.Size = New System.Drawing.Size(82, 20)
        Me.mtbFecCtb.TabIndex = 117
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(141, 30)
        Me.TextBox2.MaxLength = 15
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 20)
        Me.TextBox2.TabIndex = 121
        '
        'lbl005
        '
        Me.lbl005.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl005.Location = New System.Drawing.Point(10, 33)
        Me.lbl005.Name = "lbl005"
        Me.lbl005.Size = New System.Drawing.Size(114, 13)
        Me.lbl005.TabIndex = 129
        Me.lbl005.Text = "Proveedor"
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(10, 36)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(169, 13)
        Me.lblLin05.TabIndex = 130
        Me.lblLin05.Text = "___________________________"
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(717, 28)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecDoc.TabIndex = 119
        Me.dtpFecDoc.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'dtpFecCtb
        '
        Me.dtpFecCtb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecCtb.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtb.Location = New System.Drawing.Point(719, 3)
        Me.dtpFecCtb.Name = "dtpFecCtb"
        Me.dtpFecCtb.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecCtb.TabIndex = 118
        Me.dtpFecCtb.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'lbl003
        '
        Me.lbl003.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl003.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl003.Location = New System.Drawing.Point(574, 33)
        Me.lbl003.Name = "lbl003"
        Me.lbl003.Size = New System.Drawing.Size(139, 13)
        Me.lbl003.TabIndex = 128
        Me.lbl003.Text = "Fecha de documento"
        '
        'lblLin03
        '
        Me.lblLin03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(574, 35)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 127
        Me.lblLin03.Text = "___________________________"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(141, 5)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 20)
        Me.TextBox1.TabIndex = 116
        '
        'lbl002
        '
        Me.lbl002.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl002.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl002.Location = New System.Drawing.Point(574, 9)
        Me.lbl002.Name = "lbl002"
        Me.lbl002.Size = New System.Drawing.Size(139, 13)
        Me.lbl002.TabIndex = 125
        Me.lbl002.Text = "Fecha de contabilización"
        '
        'lbl001
        '
        Me.lbl001.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl001.Location = New System.Drawing.Point(9, 9)
        Me.lbl001.Name = "lbl001"
        Me.lbl001.Size = New System.Drawing.Size(114, 13)
        Me.lbl001.TabIndex = 123
        Me.lbl001.Text = "Número documento"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(9, 12)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 126
        Me.lblLin01.Text = "___________________________"
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(574, 10)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 124
        Me.lblLin02.Text = "___________________________"
        '
        'lblLin06
        '
        Me.lblLin06.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin06.AutoSize = True
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(578, 57)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(169, 13)
        Me.lblLin06.TabIndex = 132
        Me.lblLin06.Text = "___________________________"
        '
        'frmIEINV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(817, 463)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lbl006)
        Me.Controls.Add(Me.mtbFecDoc)
        Me.Controls.Add(Me.mtbFecCtb)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbl005)
        Me.Controls.Add(Me.lblLin05)
        Me.Controls.Add(Me.dtpFecDoc)
        Me.Controls.Add(Me.dtpFecCtb)
        Me.Controls.Add(Me.lbl003)
        Me.Controls.Add(Me.lblLin03)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl002)
        Me.Controls.Add(Me.lbl001)
        Me.Controls.Add(Me.lblLin01)
        Me.Controls.Add(Me.lblLin02)
        Me.Controls.Add(Me.lblLin06)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.pnlGral)
        Me.Name = "frmIEINV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradas de almacén"
        Me.pnlGral.ResumeLayout(False)
        Me.pnlGral.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlGral As System.Windows.Forms.Panel
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents lbl004 As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lbl007 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents cmd001 As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl006 As System.Windows.Forms.Label
    Friend WithEvents mtbFecDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbFecCtb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl005 As System.Windows.Forms.Label
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecCtb As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl003 As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl002 As System.Windows.Forms.Label
    Friend WithEvents lbl001 As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
End Class
