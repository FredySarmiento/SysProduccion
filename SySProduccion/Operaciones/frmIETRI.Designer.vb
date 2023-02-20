<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIETRI
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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.lbl004 = New System.Windows.Forms.Label()
        Me.txtnTotDoc = New System.Windows.Forms.TextBox()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecCtb = New System.Windows.Forms.DateTimePicker()
        Me.pnlGral = New System.Windows.Forms.Panel()
        Me.txtsAlmOri = New System.Windows.Forms.TextBox()
        Me.lbl008 = New System.Windows.Forms.Label()
        Me.txt001 = New System.Windows.Forms.TextBox()
        Me.cmd001 = New System.Windows.Forms.Button()
        Me.lbl007 = New System.Windows.Forms.Label()
        Me.txtsDocRef = New System.Windows.Forms.TextBox()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.lbl006 = New System.Windows.Forms.Label()
        Me.mtbFecDoc = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFecCtb = New System.Windows.Forms.MaskedTextBox()
        Me.txtsCodTer = New System.Windows.Forms.TextBox()
        Me.lbl005 = New System.Windows.Forms.Label()
        Me.lbl003 = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.dgvIDINV = New System.Windows.Forms.DataGridView()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
        Me.lbl002 = New System.Windows.Forms.Label()
        Me.lbl001 = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.lblLin08 = New System.Windows.Forms.Label()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.pnlGral.SuspendLayout()
        CType(Me.dgvIDINV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(164, 366)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 131
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(7, 39)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(169, 13)
        Me.lblLin05.TabIndex = 113
        Me.lblLin05.Text = "___________________________"
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Location = New System.Drawing.Point(15, 80)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(102, 17)
        Me.rb4.TabIndex = 121
        Me.rb4.TabStop = True
        Me.rb4.Text = "Habilitar Eliminar"
        Me.rb4.UseVisualStyleBackColor = True
        '
        'lbl004
        '
        Me.lbl004.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl004.Location = New System.Drawing.Point(502, 303)
        Me.lbl004.Name = "lbl004"
        Me.lbl004.Size = New System.Drawing.Size(120, 13)
        Me.lbl004.TabIndex = 109
        Me.lbl004.Text = "Total documento"
        '
        'txtnTotDoc
        '
        Me.txtnTotDoc.Location = New System.Drawing.Point(614, 298)
        Me.txtnTotDoc.MaxLength = 20
        Me.txtnTotDoc.Name = "txtnTotDoc"
        Me.txtnTotDoc.Size = New System.Drawing.Size(116, 20)
        Me.txtnTotDoc.TabIndex = 108
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(15, 57)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(112, 17)
        Me.rb3.TabIndex = 120
        Me.rb3.TabStop = True
        Me.rb3.Text = "Habilitar Actualizar"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(643, 24)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(80, 20)
        Me.dtpFecDoc.TabIndex = 2
        Me.dtpFecDoc.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'dtpFecCtb
        '
        Me.dtpFecCtb.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecCtb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCtb.Location = New System.Drawing.Point(641, 1)
        Me.dtpFecCtb.Name = "dtpFecCtb"
        Me.dtpFecCtb.Size = New System.Drawing.Size(82, 20)
        Me.dtpFecCtb.TabIndex = 1
        Me.dtpFecCtb.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'pnlGral
        '
        Me.pnlGral.AutoSize = True
        Me.pnlGral.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlGral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGral.Controls.Add(Me.txtsAlmOri)
        Me.pnlGral.Controls.Add(Me.lbl008)
        Me.pnlGral.Controls.Add(Me.txt001)
        Me.pnlGral.Controls.Add(Me.cmd001)
        Me.pnlGral.Controls.Add(Me.lbl007)
        Me.pnlGral.Controls.Add(Me.txtsDocRef)
        Me.pnlGral.Controls.Add(Me.lblLin06)
        Me.pnlGral.Controls.Add(Me.lbl006)
        Me.pnlGral.Controls.Add(Me.mtbFecDoc)
        Me.pnlGral.Controls.Add(Me.mtbFecCtb)
        Me.pnlGral.Controls.Add(Me.txtsCodTer)
        Me.pnlGral.Controls.Add(Me.lbl005)
        Me.pnlGral.Controls.Add(Me.lblLin05)
        Me.pnlGral.Controls.Add(Me.lbl004)
        Me.pnlGral.Controls.Add(Me.txtnTotDoc)
        Me.pnlGral.Controls.Add(Me.dtpFecDoc)
        Me.pnlGral.Controls.Add(Me.dtpFecCtb)
        Me.pnlGral.Controls.Add(Me.lbl003)
        Me.pnlGral.Controls.Add(Me.lblLin03)
        Me.pnlGral.Controls.Add(Me.dgvIDINV)
        Me.pnlGral.Controls.Add(Me.txtnNroDoc)
        Me.pnlGral.Controls.Add(Me.lbl002)
        Me.pnlGral.Controls.Add(Me.lbl001)
        Me.pnlGral.Controls.Add(Me.lblLin01)
        Me.pnlGral.Controls.Add(Me.lblLin02)
        Me.pnlGral.Controls.Add(Me.lblLin04)
        Me.pnlGral.Controls.Add(Me.lblLin07)
        Me.pnlGral.Controls.Add(Me.lblLin08)
        Me.pnlGral.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGral.Location = New System.Drawing.Point(0, 0)
        Me.pnlGral.Name = "pnlGral"
        Me.pnlGral.Size = New System.Drawing.Size(797, 325)
        Me.pnlGral.TabIndex = 128
        '
        'txtsAlmOri
        '
        Me.txtsAlmOri.BackColor = System.Drawing.SystemColors.Window
        Me.txtsAlmOri.Location = New System.Drawing.Point(643, 73)
        Me.txtsAlmOri.MaxLength = 12
        Me.txtsAlmOri.Name = "txtsAlmOri"
        Me.txtsAlmOri.Size = New System.Drawing.Size(80, 20)
        Me.txtsAlmOri.TabIndex = 123
        Me.txtsAlmOri.Text = "  "
        '
        'lbl008
        '
        Me.lbl008.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl008.Location = New System.Drawing.Point(499, 79)
        Me.lbl008.Name = "lbl008"
        Me.lbl008.Size = New System.Drawing.Size(114, 13)
        Me.lbl008.TabIndex = 124
        Me.lbl008.Text = "Almacén origen"
        '
        'txt001
        '
        Me.txt001.BackColor = System.Drawing.SystemColors.Window
        Me.txt001.Location = New System.Drawing.Point(145, 300)
        Me.txt001.MaxLength = 20
        Me.txt001.Name = "txt001"
        Me.txt001.Size = New System.Drawing.Size(99, 20)
        Me.txt001.TabIndex = 122
        '
        'cmd001
        '
        Me.cmd001.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmd001.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd001.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmd001.Location = New System.Drawing.Point(112, 309)
        Me.cmd001.Name = "cmd001"
        Me.cmd001.Size = New System.Drawing.Size(19, 10)
        Me.cmd001.TabIndex = 121
        Me.cmd001.UseVisualStyleBackColor = False
        '
        'lbl007
        '
        Me.lbl007.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl007.Location = New System.Drawing.Point(7, 306)
        Me.lbl007.Name = "lbl007"
        Me.lbl007.Size = New System.Drawing.Size(114, 13)
        Me.lbl007.TabIndex = 119
        Me.lbl007.Text = "Número documento"
        '
        'txtsDocRef
        '
        Me.txtsDocRef.BackColor = System.Drawing.SystemColors.Window
        Me.txtsDocRef.Location = New System.Drawing.Point(643, 47)
        Me.txtsDocRef.MaxLength = 12
        Me.txtsDocRef.Name = "txtsDocRef"
        Me.txtsDocRef.Size = New System.Drawing.Size(80, 20)
        Me.txtsDocRef.TabIndex = 4
        Me.txtsDocRef.Text = "  "
        '
        'lblLin06
        '
        Me.lblLin06.AutoSize = True
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(556, 54)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(169, 13)
        Me.lblLin06.TabIndex = 115
        Me.lblLin06.Text = "___________________________"
        '
        'lbl006
        '
        Me.lbl006.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl006.Location = New System.Drawing.Point(499, 54)
        Me.lbl006.Name = "lbl006"
        Me.lbl006.Size = New System.Drawing.Size(114, 13)
        Me.lbl006.TabIndex = 114
        Me.lbl006.Text = "Referencia"
        '
        'mtbFecDoc
        '
        Me.mtbFecDoc.Location = New System.Drawing.Point(642, 24)
        Me.mtbFecDoc.Name = "mtbFecDoc"
        Me.mtbFecDoc.Size = New System.Drawing.Size(82, 20)
        Me.mtbFecDoc.TabIndex = 2
        '
        'mtbFecCtb
        '
        Me.mtbFecCtb.Location = New System.Drawing.Point(641, 1)
        Me.mtbFecCtb.Name = "mtbFecCtb"
        Me.mtbFecCtb.Size = New System.Drawing.Size(82, 20)
        Me.mtbFecCtb.TabIndex = 1
        '
        'txtsCodTer
        '
        Me.txtsCodTer.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodTer.Location = New System.Drawing.Point(138, 33)
        Me.txtsCodTer.MaxLength = 15
        Me.txtsCodTer.Name = "txtsCodTer"
        Me.txtsCodTer.Size = New System.Drawing.Size(99, 20)
        Me.txtsCodTer.TabIndex = 3
        '
        'lbl005
        '
        Me.lbl005.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl005.Location = New System.Drawing.Point(7, 36)
        Me.lbl005.Name = "lbl005"
        Me.lbl005.Size = New System.Drawing.Size(114, 13)
        Me.lbl005.TabIndex = 112
        Me.lbl005.Text = "Proveedor"
        '
        'lbl003
        '
        Me.lbl003.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl003.Location = New System.Drawing.Point(499, 30)
        Me.lbl003.Name = "lbl003"
        Me.lbl003.Size = New System.Drawing.Size(139, 13)
        Me.lbl003.TabIndex = 96
        Me.lbl003.Text = "Fecha de documento"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(499, 32)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 95
        Me.lblLin03.Text = "___________________________"
        '
        'dgvIDINV
        '
        Me.dgvIDINV.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvIDINV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIDINV.Location = New System.Drawing.Point(7, 106)
        Me.dgvIDINV.Name = "dgvIDINV"
        Me.dgvIDINV.Size = New System.Drawing.Size(722, 175)
        Me.dgvIDINV.TabIndex = 5
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Location = New System.Drawing.Point(138, 2)
        Me.txtnNroDoc.MaxLength = 20
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(99, 20)
        Me.txtnNroDoc.TabIndex = 0
        '
        'lbl002
        '
        Me.lbl002.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl002.Location = New System.Drawing.Point(499, 6)
        Me.lbl002.Name = "lbl002"
        Me.lbl002.Size = New System.Drawing.Size(139, 13)
        Me.lbl002.TabIndex = 69
        Me.lbl002.Text = "Fecha de contabilización"
        '
        'lbl001
        '
        Me.lbl001.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl001.Location = New System.Drawing.Point(6, 6)
        Me.lbl001.Name = "lbl001"
        Me.lbl001.Size = New System.Drawing.Size(114, 13)
        Me.lbl001.TabIndex = 59
        Me.lbl001.Text = "Número documento"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(6, 9)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 71
        Me.lblLin01.Text = "___________________________"
        '
        'lblLin02
        '
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(499, 8)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 66
        Me.lblLin02.Text = "___________________________"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(502, 305)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 110
        Me.lblLin04.Text = "___________________________"
        '
        'lblLin07
        '
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(7, 307)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(169, 13)
        Me.lblLin07.TabIndex = 120
        Me.lblLin07.Text = "___________________________"
        '
        'lblLin08
        '
        Me.lblLin08.AutoSize = True
        Me.lblLin08.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin08.Location = New System.Drawing.Point(502, 80)
        Me.lblLin08.Name = "lblLin08"
        Me.lblLin08.Size = New System.Drawing.Size(169, 13)
        Me.lblLin08.TabIndex = 125
        Me.lblLin08.Text = "___________________________"
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(15, 34)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(99, 17)
        Me.rb2.TabIndex = 119
        Me.rb2.TabStop = True
        Me.rb2.Text = "Habilitar Buscar"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'cmdCrear
        '
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 338)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 134
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(82, 339)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 133
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(82, 366)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 132
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(163, 338)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 129
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(15, 11)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(91, 17)
        Me.rb1.TabIndex = 118
        Me.rb1.TabStop = True
        Me.rb1.Text = "Habilitar Crear"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(5, 366)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 130
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.rb4)
        Me.gb1.Controls.Add(Me.rb3)
        Me.gb1.Controls.Add(Me.rb2)
        Me.gb1.Controls.Add(Me.rb1)
        Me.gb1.Location = New System.Drawing.Point(475, 338)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(144, 101)
        Me.gb1.TabIndex = 135
        Me.gb1.TabStop = False
        '
        'frmITINV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(797, 453)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.pnlGral)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.gb1)
        Me.Name = "frmITINV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado de inventarios"
        Me.pnlGral.ResumeLayout(False)
        Me.pnlGral.PerformLayout()
        CType(Me.dgvIDINV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents lbl004 As System.Windows.Forms.Label
    Friend WithEvents txtnTotDoc As System.Windows.Forms.TextBox
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecCtb As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlGral As System.Windows.Forms.Panel
    Friend WithEvents txtsAlmOri As System.Windows.Forms.TextBox
    Friend WithEvents lbl008 As System.Windows.Forms.Label
    Friend WithEvents txt001 As System.Windows.Forms.TextBox
    Friend WithEvents cmd001 As System.Windows.Forms.Button
    Friend WithEvents lbl007 As System.Windows.Forms.Label
    Friend WithEvents txtsDocRef As System.Windows.Forms.TextBox
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
    Friend WithEvents lbl006 As System.Windows.Forms.Label
    Friend WithEvents mtbFecDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbFecCtb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtsCodTer As System.Windows.Forms.TextBox
    Friend WithEvents lbl005 As System.Windows.Forms.Label
    Friend WithEvents lbl003 As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents dgvIDINV As System.Windows.Forms.DataGridView
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents lbl002 As System.Windows.Forms.Label
    Friend WithEvents lbl001 As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents lblLin08 As System.Windows.Forms.Label
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
End Class
