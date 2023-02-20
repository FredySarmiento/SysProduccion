<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPQLIM01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPQLIM01))
        Me.mtbsCodItmIni = New System.Windows.Forms.MaskedTextBox()
        Me.cmdIEDMIIni = New System.Windows.Forms.Button()
        Me.lblCodItm = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtsNomItm = New System.Windows.Forms.TextBox()
        Me.lblNomItm = New System.Windows.Forms.Label()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.grpMPDMEE = New System.Windows.Forms.GroupBox()
        Me.rdbConMPD = New System.Windows.Forms.RadioButton()
        Me.rdbConMEE = New System.Windows.Forms.RadioButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpMPDMEE.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtbsCodItmIni
        '
        Me.mtbsCodItmIni.Location = New System.Drawing.Point(70, 26)
        Me.mtbsCodItmIni.Mask = "AAA-000"
        Me.mtbsCodItmIni.Name = "mtbsCodItmIni"
        Me.mtbsCodItmIni.Size = New System.Drawing.Size(74, 20)
        Me.mtbsCodItmIni.TabIndex = 2
        '
        'cmdIEDMIIni
        '
        Me.cmdIEDMIIni.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMIIni.Location = New System.Drawing.Point(165, 26)
        Me.cmdIEDMIIni.Name = "cmdIEDMIIni"
        Me.cmdIEDMIIni.Size = New System.Drawing.Size(30, 23)
        Me.cmdIEDMIIni.TabIndex = 4
        Me.cmdIEDMIIni.Text = "Lst"
        Me.cmdIEDMIIni.UseVisualStyleBackColor = False
        '
        'lblCodItm
        '
        Me.lblCodItm.AutoSize = True
        Me.lblCodItm.Location = New System.Drawing.Point(12, 29)
        Me.lblCodItm.Name = "lblCodItm"
        Me.lblCodItm.Size = New System.Drawing.Size(33, 13)
        Me.lblCodItm.TabIndex = 92
        Me.lblCodItm.Text = "Ítem :"
        Me.lblCodItm.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpMPDMEE)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsNomItm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNomItm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.mtbsCodItmIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdIEDMIIni)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCodItm)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Size = New System.Drawing.Size(484, 362)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 588
        '
        'txtsNomItm
        '
        Me.txtsNomItm.Enabled = False
        Me.txtsNomItm.Location = New System.Drawing.Point(69, 56)
        Me.txtsNomItm.Name = "txtsNomItm"
        Me.txtsNomItm.Size = New System.Drawing.Size(403, 20)
        Me.txtsNomItm.TabIndex = 6
        '
        'lblNomItm
        '
        Me.lblNomItm.AutoSize = True
        Me.lblNomItm.Location = New System.Drawing.Point(12, 56)
        Me.lblNomItm.Name = "lblNomItm"
        Me.lblNomItm.Size = New System.Drawing.Size(50, 13)
        Me.lblNomItm.TabIndex = 96
        Me.lblNomItm.Text = "Nombre :"
        Me.lblNomItm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLimpiar.Location = New System.Drawing.Point(394, 10)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 22)
        Me.cmdLimpiar.TabIndex = 55
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 12)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 20)
        Me.cmdOk.TabIndex = 45
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 11)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 49
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'grpMPDMEE
        '
        Me.grpMPDMEE.Controls.Add(Me.rdbConMPD)
        Me.grpMPDMEE.Controls.Add(Me.rdbConMEE)
        Me.grpMPDMEE.Location = New System.Drawing.Point(15, 95)
        Me.grpMPDMEE.Name = "grpMPDMEE"
        Me.grpMPDMEE.Size = New System.Drawing.Size(200, 99)
        Me.grpMPDMEE.TabIndex = 103
        Me.grpMPDMEE.TabStop = False
        '
        'rdbConMPD
        '
        Me.rdbConMPD.AutoSize = True
        Me.rdbConMPD.Location = New System.Drawing.Point(14, 30)
        Me.rdbConMPD.Name = "rdbConMPD"
        Me.rdbConMPD.Size = New System.Drawing.Size(99, 17)
        Me.rdbConMPD.TabIndex = 103
        Me.rdbConMPD.TabStop = True
        Me.rdbConMPD.Text = "Materias Primas"
        Me.rdbConMPD.UseVisualStyleBackColor = True
        '
        'rdbConMEE
        '
        Me.rdbConMEE.AutoSize = True
        Me.rdbConMEE.Location = New System.Drawing.Point(14, 53)
        Me.rdbConMEE.Name = "rdbConMEE"
        Me.rdbConMEE.Size = New System.Drawing.Size(172, 17)
        Me.rdbConMEE.TabIndex = 104
        Me.rdbConMEE.TabStop = True
        Me.rdbConMEE.Text = "Material de Envase y Empaque"
        Me.rdbConMEE.UseVisualStyleBackColor = True
        '
        'frmPQLIM01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPQLIM01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Componentes Comunes"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpMPDMEE.ResumeLayout(False)
        Me.grpMPDMEE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mtbsCodItmIni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdIEDMIIni As System.Windows.Forms.Button
    Friend WithEvents lblCodItm As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblNomItm As System.Windows.Forms.Label
    Friend WithEvents txtsNomItm As System.Windows.Forms.TextBox
    Friend WithEvents grpMPDMEE As System.Windows.Forms.GroupBox
    Friend WithEvents rdbConMPD As System.Windows.Forms.RadioButton
    Friend WithEvents rdbConMEE As System.Windows.Forms.RadioButton
End Class
