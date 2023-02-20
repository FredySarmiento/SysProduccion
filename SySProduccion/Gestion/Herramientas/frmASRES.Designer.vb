<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmASRES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmASRES))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdIEDMI = New System.Windows.Forms.Button()
        Me.cmdPEODP = New System.Windows.Forms.Button()
        Me.txtsCodDocnNroDoc = New System.Windows.Forms.TextBox()
        Me.cmdILMOV1 = New System.Windows.Forms.Button()
        Me.lblnAnoSdoIniInv = New System.Windows.Forms.Label()
        Me.txtnAnoSdoIniInv = New System.Windows.Forms.TextBox()
        Me.txtdFecIniAno = New System.Windows.Forms.TextBox()
        Me.lbldFecIni = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldFecFin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.lbldFecIniOdp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdFecIniOdp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(83, 238)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 121
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
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
        Me.cmdOk.TabIndex = 120
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdIEDMI
        '
        Me.cmdIEDMI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdIEDMI.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdIEDMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdIEDMI.Location = New System.Drawing.Point(12, 12)
        Me.cmdIEDMI.Name = "cmdIEDMI"
        Me.cmdIEDMI.Size = New System.Drawing.Size(118, 22)
        Me.cmdIEDMI.TabIndex = 122
        Me.cmdIEDMI.Text = "Saldos Inventarios"
        Me.cmdIEDMI.UseVisualStyleBackColor = False
        '
        'cmdPEODP
        '
        Me.cmdPEODP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdPEODP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdPEODP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdPEODP.Location = New System.Drawing.Point(12, 40)
        Me.cmdPEODP.Name = "cmdPEODP"
        Me.cmdPEODP.Size = New System.Drawing.Size(118, 22)
        Me.cmdPEODP.TabIndex = 123
        Me.cmdPEODP.Text = "Saldos OP"
        Me.cmdPEODP.UseVisualStyleBackColor = False
        '
        'txtsCodDocnNroDoc
        '
        Me.txtsCodDocnNroDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsCodDocnNroDoc.Enabled = False
        Me.txtsCodDocnNroDoc.Location = New System.Drawing.Point(198, 142)
        Me.txtsCodDocnNroDoc.Name = "txtsCodDocnNroDoc"
        Me.txtsCodDocnNroDoc.Size = New System.Drawing.Size(173, 20)
        Me.txtsCodDocnNroDoc.TabIndex = 124
        Me.txtsCodDocnNroDoc.Visible = False
        '
        'cmdILMOV1
        '
        Me.cmdILMOV1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdILMOV1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdILMOV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdILMOV1.Location = New System.Drawing.Point(12, 68)
        Me.cmdILMOV1.Name = "cmdILMOV1"
        Me.cmdILMOV1.Size = New System.Drawing.Size(118, 22)
        Me.cmdILMOV1.TabIndex = 125
        Me.cmdILMOV1.Text = "Actualizar EDP"
        Me.cmdILMOV1.UseVisualStyleBackColor = False
        '
        'lblnAnoSdoIniInv
        '
        Me.lblnAnoSdoIniInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnAnoSdoIniInv.AutoSize = True
        Me.lblnAnoSdoIniInv.Location = New System.Drawing.Point(349, 18)
        Me.lblnAnoSdoIniInv.Name = "lblnAnoSdoIniInv"
        Me.lblnAnoSdoIniInv.Size = New System.Drawing.Size(93, 13)
        Me.lblnAnoSdoIniInv.TabIndex = 126
        Me.lblnAnoSdoIniInv.Text = "Año inicial Saldos:"
        '
        'txtnAnoSdoIniInv
        '
        Me.txtnAnoSdoIniInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnAnoSdoIniInv.Enabled = False
        Me.txtnAnoSdoIniInv.Location = New System.Drawing.Point(476, 12)
        Me.txtnAnoSdoIniInv.Name = "txtnAnoSdoIniInv"
        Me.txtnAnoSdoIniInv.ReadOnly = True
        Me.txtnAnoSdoIniInv.Size = New System.Drawing.Size(53, 20)
        Me.txtnAnoSdoIniInv.TabIndex = 127
        '
        'txtdFecIniAno
        '
        Me.txtdFecIniAno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdFecIniAno.Enabled = False
        Me.txtdFecIniAno.Location = New System.Drawing.Point(476, 40)
        Me.txtdFecIniAno.Name = "txtdFecIniAno"
        Me.txtdFecIniAno.ReadOnly = True
        Me.txtdFecIniAno.Size = New System.Drawing.Size(85, 20)
        Me.txtdFecIniAno.TabIndex = 129
        '
        'lbldFecIni
        '
        Me.lbldFecIni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldFecIni.AutoSize = True
        Me.lbldFecIni.Location = New System.Drawing.Point(349, 45)
        Me.lbldFecIni.Name = "lbldFecIni"
        Me.lbldFecIni.Size = New System.Drawing.Size(88, 13)
        Me.lbldFecIni.TabIndex = 128
        Me.lbldFecIni.Text = "Fecha Inicial Inv."
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(349, 19)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 130
        Me.lblLin02.Text = "___________________________"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(349, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "___________________________"
        '
        'lbldFecFin
        '
        Me.lbldFecFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldFecFin.AutoSize = True
        Me.lbldFecFin.Location = New System.Drawing.Point(350, 74)
        Me.lbldFecFin.Name = "lbldFecFin"
        Me.lbldFecFin.Size = New System.Drawing.Size(83, 13)
        Me.lbldFecFin.TabIndex = 132
        Me.lbldFecFin.Text = "Fecha Final Inv."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(349, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "___________________________"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecFin.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(476, 68)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(85, 20)
        Me.dtpFecFin.TabIndex = 519
        Me.dtpFecFin.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'lbldFecIniOdp
        '
        Me.lbldFecIniOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldFecIniOdp.AutoSize = True
        Me.lbldFecIniOdp.Location = New System.Drawing.Point(351, 102)
        Me.lbldFecIniOdp.Name = "lbldFecIniOdp"
        Me.lbldFecIniOdp.Size = New System.Drawing.Size(88, 13)
        Me.lbldFecIniOdp.TabIndex = 520
        Me.lbldFecIniOdp.Text = "Fecha Inicial OP:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(350, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 521
        Me.Label4.Text = "___________________________"
        '
        'txtdFecIniOdp
        '
        Me.txtdFecIniOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdFecIniOdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtdFecIniOdp.Location = New System.Drawing.Point(476, 97)
        Me.txtdFecIniOdp.Name = "txtdFecIniOdp"
        Me.txtdFecIniOdp.Size = New System.Drawing.Size(85, 20)
        Me.txtdFecIniOdp.TabIndex = 523
        '
        'frmASRES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.txtdFecIniOdp)
        Me.Controls.Add(Me.lbldFecIniOdp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.lbldFecFin)
        Me.Controls.Add(Me.txtdFecIniAno)
        Me.Controls.Add(Me.lbldFecIni)
        Me.Controls.Add(Me.txtnAnoSdoIniInv)
        Me.Controls.Add(Me.lblnAnoSdoIniInv)
        Me.Controls.Add(Me.cmdILMOV1)
        Me.Controls.Add(Me.txtsCodDocnNroDoc)
        Me.Controls.Add(Me.cmdPEODP)
        Me.Controls.Add(Me.cmdIEDMI)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.lblLin02)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmASRES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recalcular Saldos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdIEDMI As System.Windows.Forms.Button
    Friend WithEvents cmdPEODP As System.Windows.Forms.Button
    Friend WithEvents txtsCodDocnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cmdILMOV1 As System.Windows.Forms.Button
    Friend WithEvents lblnAnoSdoIniInv As System.Windows.Forms.Label
    Friend WithEvents txtnAnoSdoIniInv As System.Windows.Forms.TextBox
    Friend WithEvents txtdFecIniAno As System.Windows.Forms.TextBox
    Friend WithEvents lbldFecIni As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbldFecFin As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldFecIniOdp As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdFecIniOdp As System.Windows.Forms.TextBox
End Class
