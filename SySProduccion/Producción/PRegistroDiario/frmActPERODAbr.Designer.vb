<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActPERODAbr
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActPERODAbr))
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdLstATPOP = New System.Windows.Forms.Button()
        Me.txtdHHMM = New System.Windows.Forms.TextBox()
        Me.txtnMMFinOpe = New System.Windows.Forms.TextBox()
        Me.txtnHHFinOpe = New System.Windows.Forms.TextBox()
        Me.lblMMFin = New System.Windows.Forms.Label()
        Me.lblHHFin = New System.Windows.Forms.Label()
        Me.lblHHMMAbr = New System.Windows.Forms.Label()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecDoc = New System.Windows.Forms.Label()
        Me.lblCodOpe = New System.Windows.Forms.Label()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtsCodOpe = New System.Windows.Forms.TextBox()
        Me.cmdLstATOPE = New System.Windows.Forms.Button()
        Me.txtsNomOpe = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(3, 238)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 50
        Me.cmdCrear.Text = "C&rear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(84, 238)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 55
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdLstATPOP
        '
        Me.cmdLstATPOP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATPOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATPOP.Location = New System.Drawing.Point(119, 22)
        Me.cmdLstATPOP.Name = "cmdLstATPOP"
        Me.cmdLstATPOP.Size = New System.Drawing.Size(146, 45)
        Me.cmdLstATPOP.TabIndex = 5
        Me.cmdLstATPOP.Text = "Seleccionar Operarios"
        Me.cmdLstATPOP.UseVisualStyleBackColor = False
        '
        'txtdHHMM
        '
        Me.txtdHHMM.BackColor = System.Drawing.SystemColors.Window
        Me.txtdHHMM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdHHMM.Enabled = False
        Me.txtdHHMM.Location = New System.Drawing.Point(119, 180)
        Me.txtdHHMM.MaxLength = 12
        Me.txtdHHMM.Name = "txtdHHMM"
        Me.txtdHHMM.Size = New System.Drawing.Size(62, 20)
        Me.txtdHHMM.TabIndex = 30
        '
        'txtnMMFinOpe
        '
        Me.txtnMMFinOpe.BackColor = System.Drawing.SystemColors.Window
        Me.txtnMMFinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnMMFinOpe.Location = New System.Drawing.Point(336, 181)
        Me.txtnMMFinOpe.MaxLength = 2
        Me.txtnMMFinOpe.Name = "txtnMMFinOpe"
        Me.txtnMMFinOpe.Size = New System.Drawing.Size(20, 20)
        Me.txtnMMFinOpe.TabIndex = 40
        '
        'txtnHHFinOpe
        '
        Me.txtnHHFinOpe.BackColor = System.Drawing.SystemColors.Window
        Me.txtnHHFinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnHHFinOpe.Location = New System.Drawing.Point(256, 181)
        Me.txtnHHFinOpe.MaxLength = 2
        Me.txtnHHFinOpe.Name = "txtnHHFinOpe"
        Me.txtnHHFinOpe.Size = New System.Drawing.Size(20, 20)
        Me.txtnHHFinOpe.TabIndex = 35
        '
        'lblMMFin
        '
        Me.lblMMFin.AutoSize = True
        Me.lblMMFin.Location = New System.Drawing.Point(294, 186)
        Me.lblMMFin.Name = "lblMMFin"
        Me.lblMMFin.Size = New System.Drawing.Size(28, 13)
        Me.lblMMFin.TabIndex = 616
        Me.lblMMFin.Text = "MM:"
        '
        'lblHHFin
        '
        Me.lblHHFin.AutoSize = True
        Me.lblHHFin.Location = New System.Drawing.Point(217, 186)
        Me.lblHHFin.Name = "lblHHFin"
        Me.lblHHFin.Size = New System.Drawing.Size(29, 13)
        Me.lblHHFin.TabIndex = 615
        Me.lblHHFin.Text = "HH :"
        '
        'lblHHMMAbr
        '
        Me.lblHHMMAbr.AutoSize = True
        Me.lblHHMMAbr.Location = New System.Drawing.Point(25, 185)
        Me.lblHHMMAbr.Name = "lblHHMMAbr"
        Me.lblHHMMAbr.Size = New System.Drawing.Size(76, 13)
        Me.lblHHMMAbr.TabIndex = 614
        Me.lblHHMMAbr.Text = "Hora de Inicio:"
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(119, 148)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocIni.TabIndex = 25
        '
        'lbldFecDoc
        '
        Me.lbldFecDoc.AutoSize = True
        Me.lbldFecDoc.Location = New System.Drawing.Point(25, 154)
        Me.lbldFecDoc.Name = "lbldFecDoc"
        Me.lbldFecDoc.Size = New System.Drawing.Size(43, 13)
        Me.lbldFecDoc.TabIndex = 613
        Me.lbldFecDoc.Text = "Fecha :"
        '
        'lblCodOpe
        '
        Me.lblCodOpe.AutoSize = True
        Me.lblCodOpe.Location = New System.Drawing.Point(25, 97)
        Me.lblCodOpe.Name = "lblCodOpe"
        Me.lblCodOpe.Size = New System.Drawing.Size(59, 13)
        Me.lblCodOpe.TabIndex = 621
        Me.lblCodOpe.Text = "Operación:"
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 31
        Me.LineShape4.X2 = 254
        Me.LineShape4.Y1 = 167
        Me.LineShape4.Y2 = 166
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 262)
        Me.ShapeContainer1.TabIndex = 622
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 27
        Me.LineShape2.X2 = 250
        Me.LineShape2.Y1 = 110
        Me.LineShape2.Y2 = 109
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 27
        Me.LineShape1.X2 = 352
        Me.LineShape1.Y1 = 198
        Me.LineShape1.Y2 = 200
        '
        'txtsCodOpe
        '
        Me.txtsCodOpe.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodOpe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsCodOpe.Location = New System.Drawing.Point(119, 91)
        Me.txtsCodOpe.MaxLength = 12
        Me.txtsCodOpe.Name = "txtsCodOpe"
        Me.txtsCodOpe.Size = New System.Drawing.Size(50, 20)
        Me.txtsCodOpe.TabIndex = 10
        '
        'cmdLstATOPE
        '
        Me.cmdLstATOPE.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATOPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATOPE.Location = New System.Drawing.Point(190, 89)
        Me.cmdLstATOPE.Name = "cmdLstATOPE"
        Me.cmdLstATOPE.Size = New System.Drawing.Size(75, 22)
        Me.cmdLstATOPE.TabIndex = 15
        Me.cmdLstATOPE.Text = "Operaciones"
        Me.cmdLstATOPE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATOPE.UseVisualStyleBackColor = False
        '
        'txtsNomOpe
        '
        Me.txtsNomOpe.BackColor = System.Drawing.SystemColors.Window
        Me.txtsNomOpe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsNomOpe.Enabled = False
        Me.txtsNomOpe.Location = New System.Drawing.Point(119, 117)
        Me.txtsNomOpe.MaxLength = 12
        Me.txtsNomOpe.Name = "txtsNomOpe"
        Me.txtsNomOpe.Size = New System.Drawing.Size(339, 20)
        Me.txtsNomOpe.TabIndex = 20
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(3, 238)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 45
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'frmActPERODAbr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtsNomOpe)
        Me.Controls.Add(Me.cmdLstATOPE)
        Me.Controls.Add(Me.txtsCodOpe)
        Me.Controls.Add(Me.lblCodOpe)
        Me.Controls.Add(Me.txtdHHMM)
        Me.Controls.Add(Me.txtnMMFinOpe)
        Me.Controls.Add(Me.txtnHHFinOpe)
        Me.Controls.Add(Me.lblMMFin)
        Me.Controls.Add(Me.lblHHFin)
        Me.Controls.Add(Me.lblHHMMAbr)
        Me.Controls.Add(Me.dtpFecDocIni)
        Me.Controls.Add(Me.lbldFecDoc)
        Me.Controls.Add(Me.cmdLstATPOP)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActPERODAbr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Registros Diarios de Operación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdLstATPOP As System.Windows.Forms.Button
    Friend WithEvents txtdHHMM As System.Windows.Forms.TextBox
    Friend WithEvents txtnMMFinOpe As System.Windows.Forms.TextBox
    Friend WithEvents txtnHHFinOpe As System.Windows.Forms.TextBox
    Friend WithEvents lblMMFin As System.Windows.Forms.Label
    Friend WithEvents lblHHFin As System.Windows.Forms.Label
    Friend WithEvents lblHHMMAbr As System.Windows.Forms.Label
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblCodOpe As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtsCodOpe As System.Windows.Forms.TextBox
    Friend WithEvents cmdLstATOPE As System.Windows.Forms.Button
    Friend WithEvents txtsNomOpe As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdOk As System.Windows.Forms.Button
End Class
