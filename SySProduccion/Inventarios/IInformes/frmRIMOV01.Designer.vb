<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRIMOV01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRIMOV01))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtpFecDocFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecDocIni = New System.Windows.Forms.DateTimePicker()
        Me.mtbsCodItmFin = New System.Windows.Forms.MaskedTextBox()
        Me.mtbsCodItmIni = New System.Windows.Forms.MaskedTextBox()
        Me.lbldFecDoc = New System.Windows.Forms.Label()
        Me.lblsCodAlm = New System.Windows.Forms.Label()
        Me.cmdKARDEX_QAlmFin = New System.Windows.Forms.Button()
        Me.txtsCodAlmFin = New System.Windows.Forms.TextBox()
        Me.cmdKARDEX_QAlmIni = New System.Windows.Forms.Button()
        Me.txtsCodAlmIni = New System.Windows.Forms.TextBox()
        Me.lblsCodItm = New System.Windows.Forms.Label()
        Me.cmdKARDEX_QItmFin = New System.Windows.Forms.Button()
        Me.cmdKARDEX_QItmIni = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFecDocIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mtbsCodItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mtbsCodItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbldFecDoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodAlm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdKARDEX_QAlmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodAlmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdKARDEX_QAlmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodAlmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblsCodItm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdKARDEX_QItmFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdKARDEX_QItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShapeContainer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 362)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 585
        '
        'dtpFecDocFin
        '
        Me.dtpFecDocFin.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocFin.Location = New System.Drawing.Point(324, 108)
        Me.dtpFecDocFin.Name = "dtpFecDocFin"
        Me.dtpFecDocFin.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocFin.TabIndex = 20
        '
        'dtpFecDocIni
        '
        Me.dtpFecDocIni.CustomFormat = "yyyy/mm/dd"
        Me.dtpFecDocIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDocIni.Location = New System.Drawing.Point(129, 108)
        Me.dtpFecDocIni.Name = "dtpFecDocIni"
        Me.dtpFecDocIni.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecDocIni.TabIndex = 18
        '
        'mtbsCodItmFin
        '
        Me.mtbsCodItmFin.Location = New System.Drawing.Point(324, 36)
        Me.mtbsCodItmFin.Mask = "AAA-000"
        Me.mtbsCodItmFin.Name = "mtbsCodItmFin"
        Me.mtbsCodItmFin.Size = New System.Drawing.Size(108, 20)
        Me.mtbsCodItmFin.TabIndex = 6
        '
        'mtbsCodItmIni
        '
        Me.mtbsCodItmIni.Location = New System.Drawing.Point(129, 37)
        Me.mtbsCodItmIni.Mask = "AAA-000"
        Me.mtbsCodItmIni.Name = "mtbsCodItmIni"
        Me.mtbsCodItmIni.Size = New System.Drawing.Size(108, 20)
        Me.mtbsCodItmIni.TabIndex = 2
        '
        'lbldFecDoc
        '
        Me.lbldFecDoc.AutoSize = True
        Me.lbldFecDoc.Location = New System.Drawing.Point(14, 113)
        Me.lbldFecDoc.Name = "lbldFecDoc"
        Me.lbldFecDoc.Size = New System.Drawing.Size(43, 13)
        Me.lbldFecDoc.TabIndex = 64
        Me.lbldFecDoc.Text = "Fecha :"
        '
        'lblsCodAlm
        '
        Me.lblsCodAlm.AutoSize = True
        Me.lblsCodAlm.Location = New System.Drawing.Point(14, 77)
        Me.lblsCodAlm.Name = "lblsCodAlm"
        Me.lblsCodAlm.Size = New System.Drawing.Size(48, 13)
        Me.lblsCodAlm.TabIndex = 49
        Me.lblsCodAlm.Text = "Almacén"
        '
        'cmdKARDEX_QAlmFin
        '
        Me.cmdKARDEX_QAlmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdKARDEX_QAlmFin.Location = New System.Drawing.Point(442, 70)
        Me.cmdKARDEX_QAlmFin.Name = "cmdKARDEX_QAlmFin"
        Me.cmdKARDEX_QAlmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdKARDEX_QAlmFin.TabIndex = 16
        Me.cmdKARDEX_QAlmFin.Text = "Lst"
        Me.cmdKARDEX_QAlmFin.UseVisualStyleBackColor = False
        '
        'txtsCodAlmFin
        '
        Me.txtsCodAlmFin.Location = New System.Drawing.Point(324, 72)
        Me.txtsCodAlmFin.MaxLength = 20
        Me.txtsCodAlmFin.Name = "txtsCodAlmFin"
        Me.txtsCodAlmFin.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodAlmFin.TabIndex = 14
        '
        'cmdKARDEX_QAlmIni
        '
        Me.cmdKARDEX_QAlmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdKARDEX_QAlmIni.Location = New System.Drawing.Point(252, 70)
        Me.cmdKARDEX_QAlmIni.Name = "cmdKARDEX_QAlmIni"
        Me.cmdKARDEX_QAlmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdKARDEX_QAlmIni.TabIndex = 12
        Me.cmdKARDEX_QAlmIni.Text = "Lst"
        Me.cmdKARDEX_QAlmIni.UseVisualStyleBackColor = False
        '
        'txtsCodAlmIni
        '
        Me.txtsCodAlmIni.Location = New System.Drawing.Point(129, 72)
        Me.txtsCodAlmIni.MaxLength = 20
        Me.txtsCodAlmIni.Name = "txtsCodAlmIni"
        Me.txtsCodAlmIni.Size = New System.Drawing.Size(108, 20)
        Me.txtsCodAlmIni.TabIndex = 10
        '
        'lblsCodItm
        '
        Me.lblsCodItm.AutoSize = True
        Me.lblsCodItm.Location = New System.Drawing.Point(14, 41)
        Me.lblsCodItm.Name = "lblsCodItm"
        Me.lblsCodItm.Size = New System.Drawing.Size(27, 13)
        Me.lblsCodItm.TabIndex = 36
        Me.lblsCodItm.Text = "Ítem"
        '
        'cmdKARDEX_QItmFin
        '
        Me.cmdKARDEX_QItmFin.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdKARDEX_QItmFin.Location = New System.Drawing.Point(441, 34)
        Me.cmdKARDEX_QItmFin.Name = "cmdKARDEX_QItmFin"
        Me.cmdKARDEX_QItmFin.Size = New System.Drawing.Size(30, 23)
        Me.cmdKARDEX_QItmFin.TabIndex = 8
        Me.cmdKARDEX_QItmFin.Text = "Lst"
        Me.cmdKARDEX_QItmFin.UseVisualStyleBackColor = False
        '
        'cmdKARDEX_QItmIni
        '
        Me.cmdKARDEX_QItmIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdKARDEX_QItmIni.Location = New System.Drawing.Point(252, 34)
        Me.cmdKARDEX_QItmIni.Name = "cmdKARDEX_QItmIni"
        Me.cmdKARDEX_QItmIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdKARDEX_QItmIni.TabIndex = 4
        Me.cmdKARDEX_QItmIni.Text = "Lst"
        Me.cmdKARDEX_QItmIni.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Desde"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1, Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 300)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 16
        Me.LineShape3.X2 = 462
        Me.LineShape3.Y1 = 126
        Me.LineShape3.Y2 = 127
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 465
        Me.LineShape1.Y1 = 90
        Me.LineShape1.Y2 = 91
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.LightGray
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 15
        Me.LineShape5.X2 = 461
        Me.LineShape5.Y1 = 55
        Me.LineShape5.Y2 = 56
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 31)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 30
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 33)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 20)
        Me.cmdOk.TabIndex = 26
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 32)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 28
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmRIMOV01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRIMOV01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de movimiento de inventarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblsCodAlm As System.Windows.Forms.Label
    Friend WithEvents cmdKARDEX_QAlmFin As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlmFin As System.Windows.Forms.TextBox
    Friend WithEvents cmdKARDEX_QAlmIni As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlmIni As System.Windows.Forms.TextBox
    Friend WithEvents lblsCodItm As System.Windows.Forms.Label
    Friend WithEvents cmdKARDEX_QItmFin As System.Windows.Forms.Button
    Friend WithEvents cmdKARDEX_QItmIni As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lbldFecDoc As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents mtbsCodItmFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbsCodItmIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpFecDocIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecDocFin As System.Windows.Forms.DateTimePicker
End Class
