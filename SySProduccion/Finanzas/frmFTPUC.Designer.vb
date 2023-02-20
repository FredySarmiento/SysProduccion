<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFTPUC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTPUC))
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtsCodNIIF = New System.Windows.Forms.TextBox()
        Me.txtsCodCtaAlt = New System.Windows.Forms.TextBox()
        Me.txtsNomCta = New System.Windows.Forms.TextBox()
        Me.txtsCodCta = New System.Windows.Forms.TextBox()
        Me.chbCtaMov = New System.Windows.Forms.CheckBox()
        Me.chbCtaPpo = New System.Windows.Forms.CheckBox()
        Me.chbCtaTer = New System.Windows.Forms.CheckBox()
        Me.lblSdoCta = New System.Windows.Forms.Label()
        Me.lblTipCta = New System.Windows.Forms.Label()
        Me.lblNivCta = New System.Windows.Forms.Label()
        Me.lblCodNIIF = New System.Windows.Forms.Label()
        Me.lblCodCtaAlt = New System.Windows.Forms.Label()
        Me.lblNomCta = New System.Windows.Forms.Label()
        Me.lblCodCta = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(85, 251)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 23
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 251)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 22
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodNIIF)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodCtaAlt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsNomCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtsCodCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbCtaMov)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbCtaPpo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbCtaTer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSdoCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTipCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNivCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCodNIIF)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCodCtaAlt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNomCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCodCta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin01)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin02)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin03)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin04)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin05)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin06)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLin07)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(767, 278)
        Me.SplitContainer1.SplitterDistance = 497
        Me.SplitContainer1.TabIndex = 35
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 146)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(95, 20)
        Me.TextBox3.TabIndex = 239
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 20)
        Me.TextBox2.TabIndex = 238
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 20)
        Me.TextBox1.TabIndex = 237
        '
        'txtsCodNIIF
        '
        Me.txtsCodNIIF.Location = New System.Drawing.Point(129, 79)
        Me.txtsCodNIIF.Name = "txtsCodNIIF"
        Me.txtsCodNIIF.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodNIIF.TabIndex = 235
        '
        'txtsCodCtaAlt
        '
        Me.txtsCodCtaAlt.Location = New System.Drawing.Point(129, 56)
        Me.txtsCodCtaAlt.Name = "txtsCodCtaAlt"
        Me.txtsCodCtaAlt.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodCtaAlt.TabIndex = 234
        '
        'txtsNomCta
        '
        Me.txtsNomCta.Location = New System.Drawing.Point(129, 33)
        Me.txtsNomCta.Name = "txtsNomCta"
        Me.txtsNomCta.Size = New System.Drawing.Size(355, 20)
        Me.txtsNomCta.TabIndex = 233
        '
        'txtsCodCta
        '
        Me.txtsCodCta.Location = New System.Drawing.Point(129, 10)
        Me.txtsCodCta.Name = "txtsCodCta"
        Me.txtsCodCta.Size = New System.Drawing.Size(95, 20)
        Me.txtsCodCta.TabIndex = 44
        '
        'chbCtaMov
        '
        Me.chbCtaMov.AutoSize = True
        Me.chbCtaMov.Location = New System.Drawing.Point(285, 14)
        Me.chbCtaMov.Name = "chbCtaMov"
        Me.chbCtaMov.Size = New System.Drawing.Size(131, 17)
        Me.chbCtaMov.TabIndex = 43
        Me.chbCtaMov.Text = "Cuenta de movimiento"
        Me.chbCtaMov.UseVisualStyleBackColor = True
        '
        'chbCtaPpo
        '
        Me.chbCtaPpo.AutoSize = True
        Me.chbCtaPpo.Location = New System.Drawing.Point(12, 202)
        Me.chbCtaPpo.Name = "chbCtaPpo"
        Me.chbCtaPpo.Size = New System.Drawing.Size(136, 17)
        Me.chbCtaPpo.TabIndex = 42
        Me.chbCtaPpo.Text = "Cuenta de presupuesto"
        Me.chbCtaPpo.UseVisualStyleBackColor = True
        '
        'chbCtaTer
        '
        Me.chbCtaTer.AutoSize = True
        Me.chbCtaTer.Location = New System.Drawing.Point(12, 179)
        Me.chbCtaTer.Name = "chbCtaTer"
        Me.chbCtaTer.Size = New System.Drawing.Size(116, 17)
        Me.chbCtaTer.TabIndex = 41
        Me.chbCtaTer.Text = "Cuenta de terceros"
        Me.chbCtaTer.UseVisualStyleBackColor = True
        '
        'lblSdoCta
        '
        Me.lblSdoCta.AutoSize = True
        Me.lblSdoCta.Location = New System.Drawing.Point(5, 152)
        Me.lblSdoCta.Name = "lblSdoCta"
        Me.lblSdoCta.Size = New System.Drawing.Size(34, 13)
        Me.lblSdoCta.TabIndex = 40
        Me.lblSdoCta.Text = "Saldo"
        '
        'lblTipCta
        '
        Me.lblTipCta.AutoSize = True
        Me.lblTipCta.Location = New System.Drawing.Point(5, 130)
        Me.lblTipCta.Name = "lblTipCta"
        Me.lblTipCta.Size = New System.Drawing.Size(28, 13)
        Me.lblTipCta.TabIndex = 39
        Me.lblTipCta.Text = "Tipo"
        '
        'lblNivCta
        '
        Me.lblNivCta.AutoSize = True
        Me.lblNivCta.Location = New System.Drawing.Point(5, 108)
        Me.lblNivCta.Name = "lblNivCta"
        Me.lblNivCta.Size = New System.Drawing.Size(31, 13)
        Me.lblNivCta.TabIndex = 38
        Me.lblNivCta.Text = "Nivel"
        '
        'lblCodNIIF
        '
        Me.lblCodNIIF.AutoSize = True
        Me.lblCodNIIF.Location = New System.Drawing.Point(5, 84)
        Me.lblCodNIIF.Name = "lblCodNIIF"
        Me.lblCodNIIF.Size = New System.Drawing.Size(63, 13)
        Me.lblCodNIIF.TabIndex = 37
        Me.lblCodNIIF.Text = "Código NIIF"
        '
        'lblCodCtaAlt
        '
        Me.lblCodCtaAlt.AutoSize = True
        Me.lblCodCtaAlt.Location = New System.Drawing.Point(5, 62)
        Me.lblCodCtaAlt.Name = "lblCodCtaAlt"
        Me.lblCodCtaAlt.Size = New System.Drawing.Size(75, 13)
        Me.lblCodCtaAlt.TabIndex = 36
        Me.lblCodCtaAlt.Text = "Código alterno"
        '
        'lblNomCta
        '
        Me.lblNomCta.AutoSize = True
        Me.lblNomCta.Location = New System.Drawing.Point(5, 39)
        Me.lblNomCta.Name = "lblNomCta"
        Me.lblNomCta.Size = New System.Drawing.Size(80, 13)
        Me.lblNomCta.TabIndex = 35
        Me.lblNomCta.Text = "Nombre cuenta"
        '
        'lblCodCta
        '
        Me.lblCodCta.AutoSize = True
        Me.lblCodCta.Location = New System.Drawing.Point(5, 15)
        Me.lblCodCta.Name = "lblCodCta"
        Me.lblCodCta.Size = New System.Drawing.Size(76, 13)
        Me.lblCodCta.TabIndex = 34
        Me.lblCodCta.Text = "Código cuenta"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(7, 17)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 232
        Me.lblLin01.Text = "___________________________"
        '
        'lblLin02
        '
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(6, 40)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 236
        Me.lblLin02.Text = "___________________________"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(7, 63)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 240
        Me.lblLin03.Text = "___________________________"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(5, 86)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 241
        Me.lblLin04.Text = "___________________________"
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(5, 109)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(169, 13)
        Me.lblLin05.TabIndex = 242
        Me.lblLin05.Text = "___________________________"
        '
        'lblLin06
        '
        Me.lblLin06.AutoSize = True
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(8, 131)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(169, 13)
        Me.lblLin06.TabIndex = 243
        Me.lblLin06.Text = "___________________________"
        '
        'lblLin07
        '
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(5, 153)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(169, 13)
        Me.lblLin07.TabIndex = 244
        Me.lblLin07.Text = "___________________________"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.AliceBlue
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(266, 278)
        Me.TreeView1.TabIndex = 35
        '
        'frmFTPUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(767, 278)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFTPUC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan de cuentas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chbCtaMov As System.Windows.Forms.CheckBox
    Friend WithEvents chbCtaPpo As System.Windows.Forms.CheckBox
    Friend WithEvents chbCtaTer As System.Windows.Forms.CheckBox
    Friend WithEvents lblSdoCta As System.Windows.Forms.Label
    Friend WithEvents lblTipCta As System.Windows.Forms.Label
    Friend WithEvents lblNivCta As System.Windows.Forms.Label
    Friend WithEvents lblCodNIIF As System.Windows.Forms.Label
    Friend WithEvents lblCodCtaAlt As System.Windows.Forms.Label
    Friend WithEvents lblNomCta As System.Windows.Forms.Label
    Friend WithEvents lblCodCta As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents txtsCodCta As System.Windows.Forms.TextBox
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodNIIF As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodCtaAlt As System.Windows.Forms.TextBox
    Friend WithEvents txtsNomCta As System.Windows.Forms.TextBox
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
End Class
