<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEROD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEROD))
        Me.dtpFecDoc = New System.Windows.Forms.DateTimePicker()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.txtsCodTer = New System.Windows.Forms.TextBox()
        Me.lblCodTer = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbFecDoc = New System.Windows.Forms.Label()
        Me.lblHH = New System.Windows.Forms.Label()
        Me.cmdTecOpe = New System.Windows.Forms.Button()
        Me.cmdAbrirReg = New System.Windows.Forms.Button()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
        Me.lblnNroDoc = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.txtsNomTer = New System.Windows.Forms.TextBox()
        Me.lblNomTer = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdHHMM = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtsCodDoc = New System.Windows.Forms.TextBox()
        Me.txtsEstDoc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dtpFecDoc
        '
        Me.dtpFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecDoc.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecDoc.Enabled = False
        Me.dtpFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDoc.Location = New System.Drawing.Point(674, 40)
        Me.dtpFecDoc.Name = "dtpFecDoc"
        Me.dtpFecDoc.Size = New System.Drawing.Size(101, 22)
        Me.dtpFecDoc.TabIndex = 35
        Me.dtpFecDoc.Value = New Date(2014, 2, 26, 0, 0, 0, 0)
        '
        'cmdListar
        '
        Me.cmdListar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListar.Location = New System.Drawing.Point(84, 437)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(75, 22)
        Me.cmdListar.TabIndex = 15
        Me.cmdListar.Text = "Listado Operarios"
        Me.cmdListar.UseVisualStyleBackColor = False
        Me.cmdListar.Visible = False
        '
        'txtsCodTer
        '
        Me.txtsCodTer.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodTer.Enabled = False
        Me.txtsCodTer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsCodTer.Location = New System.Drawing.Point(100, 10)
        Me.txtsCodTer.MaxLength = 15
        Me.txtsCodTer.Name = "txtsCodTer"
        Me.txtsCodTer.Size = New System.Drawing.Size(99, 22)
        Me.txtsCodTer.TabIndex = 5
        Me.txtsCodTer.Text = "  "
        '
        'lblCodTer
        '
        Me.lblCodTer.AutoSize = True
        Me.lblCodTer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodTer.Location = New System.Drawing.Point(5, 15)
        Me.lblCodTer.Name = "lblCodTer"
        Me.lblCodTer.Size = New System.Drawing.Size(66, 16)
        Me.lblCodTer.TabIndex = 563
        Me.lblCodTer.Text = "Operario :"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(5, 19)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 565
        Me.lblLin01.Text = "___________________________"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(450, 210)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(240, 120)
        Me.cmdCancelar.TabIndex = 55
        Me.cmdCancelar.Text = "&Salir"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(550, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 567
        Me.Label2.Text = "______________________"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(550, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 568
        Me.Label3.Text = "____________________________"
        '
        'lbFecDoc
        '
        Me.lbFecDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFecDoc.AutoSize = True
        Me.lbFecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecDoc.Location = New System.Drawing.Point(555, 44)
        Me.lbFecDoc.Name = "lbFecDoc"
        Me.lbFecDoc.Size = New System.Drawing.Size(51, 16)
        Me.lbFecDoc.TabIndex = 569
        Me.lbFecDoc.Text = "Fecha :"
        '
        'lblHH
        '
        Me.lblHH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHH.AutoSize = True
        Me.lblHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHH.Location = New System.Drawing.Point(555, 71)
        Me.lblHH.Name = "lblHH"
        Me.lblHH.Size = New System.Drawing.Size(43, 16)
        Me.lblHH.TabIndex = 570
        Me.lblHH.Text = "Hora :"
        '
        'cmdTecOpe
        '
        Me.cmdTecOpe.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdTecOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTecOpe.Location = New System.Drawing.Point(110, 210)
        Me.cmdTecOpe.Name = "cmdTecOpe"
        Me.cmdTecOpe.Size = New System.Drawing.Size(240, 120)
        Me.cmdTecOpe.TabIndex = 10
        Me.cmdTecOpe.Text = "&Iniciar Operación/Desc/Almuerzo"
        Me.cmdTecOpe.UseVisualStyleBackColor = False
        '
        'cmdAbrirReg
        '
        Me.cmdAbrirReg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAbrirReg.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdAbrirReg.Enabled = False
        Me.cmdAbrirReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbrirReg.Location = New System.Drawing.Point(130, 210)
        Me.cmdAbrirReg.Name = "cmdAbrirReg"
        Me.cmdAbrirReg.Size = New System.Drawing.Size(200, 100)
        Me.cmdAbrirReg.TabIndex = 50
        Me.cmdAbrirReg.Text = "&Abrir Registro Diario"
        Me.cmdAbrirReg.UseVisualStyleBackColor = False
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnNroDoc.Enabled = False
        Me.txtnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnNroDoc.Location = New System.Drawing.Point(694, 10)
        Me.txtnNroDoc.MaxLength = 12
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(82, 22)
        Me.txtnNroDoc.TabIndex = 25
        '
        'lblnNroDoc
        '
        Me.lblnNroDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnNroDoc.Location = New System.Drawing.Point(555, 17)
        Me.lblnNroDoc.Name = "lblnNroDoc"
        Me.lblnNroDoc.Size = New System.Drawing.Size(67, 14)
        Me.lblnNroDoc.TabIndex = 583
        Me.lblnNroDoc.Text = "Número:"
        '
        'lblLin11
        '
        Me.lblLin11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin11.AutoSize = True
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(555, 19)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(205, 13)
        Me.lblLin11.TabIndex = 584
        Me.lblLin11.Text = "_________________________________"
        '
        'txtsNomTer
        '
        Me.txtsNomTer.BackColor = System.Drawing.SystemColors.Window
        Me.txtsNomTer.Enabled = False
        Me.txtsNomTer.Location = New System.Drawing.Point(100, 40)
        Me.txtsNomTer.MaxLength = 15
        Me.txtsNomTer.Name = "txtsNomTer"
        Me.txtsNomTer.Size = New System.Drawing.Size(379, 20)
        Me.txtsNomTer.TabIndex = 30
        Me.txtsNomTer.Text = "  "
        '
        'lblNomTer
        '
        Me.lblNomTer.AutoSize = True
        Me.lblNomTer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomTer.Location = New System.Drawing.Point(5, 43)
        Me.lblNomTer.Name = "lblNomTer"
        Me.lblNomTer.Size = New System.Drawing.Size(62, 16)
        Me.lblNomTer.TabIndex = 586
        Me.lblNomTer.Text = "Nombre :"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(5, 47)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 587
        Me.lblLin03.Text = "___________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 592
        Me.Label4.Text = "Tipo Reg.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(5, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 594
        Me.Label5.Text = "_________________"
        '
        'txtdHHMM
        '
        Me.txtdHHMM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdHHMM.BackColor = System.Drawing.SystemColors.Window
        Me.txtdHHMM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdHHMM.Enabled = False
        Me.txtdHHMM.Location = New System.Drawing.Point(707, 70)
        Me.txtdHHMM.MaxLength = 12
        Me.txtdHHMM.Name = "txtdHHMM"
        Me.txtdHHMM.Size = New System.Drawing.Size(68, 20)
        Me.txtdHHMM.TabIndex = 45
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtsCodDoc
        '
        Me.txtsCodDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsCodDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsCodDoc.Enabled = False
        Me.txtsCodDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsCodDoc.Location = New System.Drawing.Point(637, 10)
        Me.txtsCodDoc.MaxLength = 12
        Me.txtsCodDoc.Name = "txtsCodDoc"
        Me.txtsCodDoc.Size = New System.Drawing.Size(34, 22)
        Me.txtsCodDoc.TabIndex = 20
        '
        'txtsEstDoc
        '
        Me.txtsEstDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsEstDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtsEstDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsEstDoc.Enabled = False
        Me.txtsEstDoc.Location = New System.Drawing.Point(100, 70)
        Me.txtsEstDoc.MaxLength = 12
        Me.txtsEstDoc.Name = "txtsEstDoc"
        Me.txtsEstDoc.Size = New System.Drawing.Size(34, 20)
        Me.txtsEstDoc.TabIndex = 40
        '
        'frmPEROD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.txtsEstDoc)
        Me.Controls.Add(Me.txtsCodDoc)
        Me.Controls.Add(Me.txtdHHMM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsNomTer)
        Me.Controls.Add(Me.lblNomTer)
        Me.Controls.Add(Me.lblLin03)
        Me.Controls.Add(Me.txtnNroDoc)
        Me.Controls.Add(Me.lblnNroDoc)
        Me.Controls.Add(Me.lblLin11)
        Me.Controls.Add(Me.cmdTecOpe)
        Me.Controls.Add(Me.lblHH)
        Me.Controls.Add(Me.lbFecDoc)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.txtsCodTer)
        Me.Controls.Add(Me.lblCodTer)
        Me.Controls.Add(Me.lblLin01)
        Me.Controls.Add(Me.dtpFecDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdAbrirReg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEROD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Operaciones Diario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFecDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdListar As System.Windows.Forms.Button
    Friend WithEvents txtsCodTer As System.Windows.Forms.TextBox
    Friend WithEvents lblCodTer As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbFecDoc As System.Windows.Forms.Label
    Friend WithEvents lblHH As System.Windows.Forms.Label
    Friend WithEvents cmdTecOpe As System.Windows.Forms.Button
    Friend WithEvents cmdAbrirReg As System.Windows.Forms.Button
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblnNroDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents txtsNomTer As System.Windows.Forms.TextBox
    Friend WithEvents lblNomTer As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdHHMM As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtsCodDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtsEstDoc As System.Windows.Forms.TextBox
End Class
