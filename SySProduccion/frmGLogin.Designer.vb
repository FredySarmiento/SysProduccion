<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmGLogin
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
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdFinalizar As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGLogin))
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdFinalizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtsNomCia = New System.Windows.Forms.TextBox()
        Me.lblCodCia = New System.Windows.Forms.Label()
        Me.txtsPwdUsr = New System.Windows.Forms.TextBox()
        Me.txtsCodUsr = New System.Windows.Forms.TextBox()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.lblNomUsr = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(170, 157)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(80, 24)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "&Aceptar"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdFinalizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdFinalizar.Location = New System.Drawing.Point(256, 157)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(80, 24)
        Me.cmdFinalizar.TabIndex = 5
        Me.cmdFinalizar.Text = "&Finalizar"
        Me.cmdFinalizar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtsNomCia)
        Me.GroupBox1.Controls.Add(Me.lblCodCia)
        Me.GroupBox1.Controls.Add(Me.txtsPwdUsr)
        Me.GroupBox1.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox1.Controls.Add(Me.txtsCodUsr)
        Me.GroupBox1.Controls.Add(Me.lblPW)
        Me.GroupBox1.Controls.Add(Me.lblNomUsr)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 149)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtsNomCia
        '
        Me.txtsNomCia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtsNomCia.Enabled = False
        Me.txtsNomCia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtsNomCia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsNomCia.Location = New System.Drawing.Point(168, 31)
        Me.txtsNomCia.MaxLength = 50
        Me.txtsNomCia.Multiline = True
        Me.txtsNomCia.Name = "txtsNomCia"
        Me.txtsNomCia.Size = New System.Drawing.Size(187, 16)
        Me.txtsNomCia.TabIndex = 14
        '
        'lblCodCia
        '
        Me.lblCodCia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCodCia.Location = New System.Drawing.Point(167, 8)
        Me.lblCodCia.Name = "lblCodCia"
        Me.lblCodCia.Size = New System.Drawing.Size(160, 25)
        Me.lblCodCia.TabIndex = 13
        Me.lblCodCia.Text = "Nombre de la Empresa"
        Me.lblCodCia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsPwdUsr
        '
        Me.txtsPwdUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtsPwdUsr.Location = New System.Drawing.Point(167, 120)
        Me.txtsPwdUsr.MaxLength = 15
        Me.txtsPwdUsr.Name = "txtsPwdUsr"
        Me.txtsPwdUsr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtsPwdUsr.Size = New System.Drawing.Size(188, 20)
        Me.txtsPwdUsr.TabIndex = 12
        '
        'txtsCodUsr
        '
        Me.txtsCodUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtsCodUsr.Location = New System.Drawing.Point(167, 80)
        Me.txtsCodUsr.MaxLength = 8
        Me.txtsCodUsr.Name = "txtsCodUsr"
        Me.txtsCodUsr.Size = New System.Drawing.Size(188, 20)
        Me.txtsCodUsr.TabIndex = 10
        '
        'lblPW
        '
        Me.lblPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblPW.Location = New System.Drawing.Point(165, 100)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(162, 23)
        Me.lblPW.TabIndex = 11
        Me.lblPW.Text = "&Contraseña"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNomUsr
        '
        Me.lblNomUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblNomUsr.Location = New System.Drawing.Point(165, 57)
        Me.lblNomUsr.Name = "lblNomUsr"
        Me.lblNomUsr.Size = New System.Drawing.Size(162, 25)
        Me.lblNomUsr.TabIndex = 8
        Me.lblNomUsr.Text = "&ID  de usuario"
        Me.lblNomUsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SySProduccion.My.Resources.Resources.LogoJPG2022SinFondo
        Me.PictureBox1.Location = New System.Drawing.Point(16, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(16, 19)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(119, 38)
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'frmGLogin
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.CancelButton = Me.cmdFinalizar
        Me.ClientSize = New System.Drawing.Size(390, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdFinalizar)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Siles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsNomCia As System.Windows.Forms.TextBox
    Friend WithEvents lblCodCia As System.Windows.Forms.Label
    Friend WithEvents txtsPwdUsr As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodUsr As System.Windows.Forms.TextBox
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents lblNomUsr As System.Windows.Forms.Label
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
