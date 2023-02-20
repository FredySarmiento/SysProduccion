<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmATGRI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmATGRI))
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.txtsNomGrp = New System.Windows.Forms.TextBox()
        Me.txtsCodGrp = New System.Windows.Forms.TextBox()
        Me.lblNomGrp = New System.Windows.Forms.Label()
        Me.lblCodGrp = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtsMetVlz = New System.Windows.Forms.TextBox()
        Me.txtsMetAba = New System.Windows.Forms.TextBox()
        Me.lblMetVlz = New System.Windows.Forms.Label()
        Me.lblMetAba = New System.Windows.Forms.Label()
        Me.lblLin18 = New System.Windows.Forms.Label()
        Me.lblLin19 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboCtaWIP = New System.Windows.Forms.ComboBox()
        Me.cboCtaDevCom = New System.Windows.Forms.ComboBox()
        Me.cboCtaCom = New System.Windows.Forms.ComboBox()
        Me.cboCtaRedInv = New System.Windows.Forms.ComboBox()
        Me.cboCtaAumInv = New System.Windows.Forms.ComboBox()
        Me.cboCtaRev = New System.Windows.Forms.ComboBox()
        Me.cboCtaDifPre = New System.Windows.Forms.ComboBox()
        Me.cboCtaDot = New System.Windows.Forms.ComboBox()
        Me.cboCtaGto = New System.Windows.Forms.ComboBox()
        Me.cboCtaVrc = New System.Windows.Forms.ComboBox()
        Me.cboCtaDevVta = New System.Windows.Forms.ComboBox()
        Me.cboCtaIng = New System.Windows.Forms.ComboBox()
        Me.cboCtaTrs = New System.Windows.Forms.ComboBox()
        Me.cboCtaCosVta = New System.Windows.Forms.ComboBox()
        Me.cboCtaInv = New System.Windows.Forms.ComboBox()
        Me.lblCtaDevCom = New System.Windows.Forms.Label()
        Me.lblCtaCom = New System.Windows.Forms.Label()
        Me.lblCtaRedInv = New System.Windows.Forms.Label()
        Me.lblCtaAumInv = New System.Windows.Forms.Label()
        Me.lblCtaRev = New System.Windows.Forms.Label()
        Me.lblCtaDifPre = New System.Windows.Forms.Label()
        Me.lblCtaDot = New System.Windows.Forms.Label()
        Me.lblCtaVrc = New System.Windows.Forms.Label()
        Me.lblCtaTrs = New System.Windows.Forms.Label()
        Me.lblCtaWIP = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCtaCosVta = New System.Windows.Forms.Label()
        Me.lblCtaInv = New System.Windows.Forms.Label()
        Me.lblCtaIng = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.lblLin08 = New System.Windows.Forms.Label()
        Me.lblLin09 = New System.Windows.Forms.Label()
        Me.lblLin10 = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.lblLin12 = New System.Windows.Forms.Label()
        Me.lblLin13 = New System.Windows.Forms.Label()
        Me.lblLin14 = New System.Windows.Forms.Label()
        Me.lblLin15 = New System.Windows.Forms.Label()
        Me.lblLin16 = New System.Windows.Forms.Label()
        Me.lblLin17 = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.cmdLstATGRI = New System.Windows.Forms.Button()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 314)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 120
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(6, 314)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 121
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 314)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 122
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(5, 315)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 117
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(6, 314)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 118
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(85, 315)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 119
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'txtsNomGrp
        '
        Me.txtsNomGrp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsNomGrp.Location = New System.Drawing.Point(130, 30)
        Me.txtsNomGrp.Name = "txtsNomGrp"
        Me.txtsNomGrp.Size = New System.Drawing.Size(341, 20)
        Me.txtsNomGrp.TabIndex = 116
        '
        'txtsCodGrp
        '
        Me.txtsCodGrp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsCodGrp.Location = New System.Drawing.Point(130, 5)
        Me.txtsCodGrp.Name = "txtsCodGrp"
        Me.txtsCodGrp.Size = New System.Drawing.Size(97, 20)
        Me.txtsCodGrp.TabIndex = 115
        '
        'lblNomGrp
        '
        Me.lblNomGrp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNomGrp.AutoSize = True
        Me.lblNomGrp.Location = New System.Drawing.Point(7, 36)
        Me.lblNomGrp.Name = "lblNomGrp"
        Me.lblNomGrp.Size = New System.Drawing.Size(74, 13)
        Me.lblNomGrp.TabIndex = 114
        Me.lblNomGrp.Text = "Nombre grupo"
        '
        'lblCodGrp
        '
        Me.lblCodGrp.AutoSize = True
        Me.lblCodGrp.Location = New System.Drawing.Point(5, 10)
        Me.lblCodGrp.Name = "lblCodGrp"
        Me.lblCodGrp.Size = New System.Drawing.Size(70, 13)
        Me.lblCodGrp.TabIndex = 113
        Me.lblCodGrp.Text = "Código grupo"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(696, 236)
        Me.TabControl1.TabIndex = 123
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.txtsMetVlz)
        Me.TabPage1.Controls.Add(Me.txtsMetAba)
        Me.TabPage1.Controls.Add(Me.lblMetVlz)
        Me.TabPage1.Controls.Add(Me.lblMetAba)
        Me.TabPage1.Controls.Add(Me.lblLin18)
        Me.TabPage1.Controls.Add(Me.lblLin19)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(688, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'txtsMetVlz
        '
        Me.txtsMetVlz.Location = New System.Drawing.Point(197, 34)
        Me.txtsMetVlz.Name = "txtsMetVlz"
        Me.txtsMetVlz.Size = New System.Drawing.Size(100, 20)
        Me.txtsMetVlz.TabIndex = 250
        '
        'txtsMetAba
        '
        Me.txtsMetAba.Location = New System.Drawing.Point(197, 4)
        Me.txtsMetAba.Name = "txtsMetAba"
        Me.txtsMetAba.Size = New System.Drawing.Size(100, 20)
        Me.txtsMetAba.TabIndex = 249
        '
        'lblMetVlz
        '
        Me.lblMetVlz.AutoSize = True
        Me.lblMetVlz.Location = New System.Drawing.Point(5, 40)
        Me.lblMetVlz.Name = "lblMetVlz"
        Me.lblMetVlz.Size = New System.Drawing.Size(117, 13)
        Me.lblMetVlz.TabIndex = 1
        Me.lblMetVlz.Text = "Método de valorización"
        '
        'lblMetAba
        '
        Me.lblMetAba.AutoSize = True
        Me.lblMetAba.Location = New System.Drawing.Point(5, 10)
        Me.lblMetAba.Name = "lblMetAba"
        Me.lblMetAba.Size = New System.Drawing.Size(132, 13)
        Me.lblMetAba.TabIndex = 0
        Me.lblMetAba.Text = "Método de abastecimiento"
        '
        'lblLin18
        '
        Me.lblLin18.AutoSize = True
        Me.lblLin18.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin18.Location = New System.Drawing.Point(6, 11)
        Me.lblLin18.Name = "lblLin18"
        Me.lblLin18.Size = New System.Drawing.Size(229, 13)
        Me.lblLin18.TabIndex = 247
        Me.lblLin18.Text = "_____________________________________"
        '
        'lblLin19
        '
        Me.lblLin19.AutoSize = True
        Me.lblLin19.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin19.Location = New System.Drawing.Point(6, 41)
        Me.lblLin19.Name = "lblLin19"
        Me.lblLin19.Size = New System.Drawing.Size(229, 13)
        Me.lblLin19.TabIndex = 248
        Me.lblLin19.Text = "_____________________________________"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.cboCtaWIP)
        Me.TabPage2.Controls.Add(Me.cboCtaDevCom)
        Me.TabPage2.Controls.Add(Me.cboCtaCom)
        Me.TabPage2.Controls.Add(Me.cboCtaRedInv)
        Me.TabPage2.Controls.Add(Me.cboCtaAumInv)
        Me.TabPage2.Controls.Add(Me.cboCtaRev)
        Me.TabPage2.Controls.Add(Me.cboCtaDifPre)
        Me.TabPage2.Controls.Add(Me.cboCtaDot)
        Me.TabPage2.Controls.Add(Me.cboCtaGto)
        Me.TabPage2.Controls.Add(Me.cboCtaVrc)
        Me.TabPage2.Controls.Add(Me.cboCtaDevVta)
        Me.TabPage2.Controls.Add(Me.cboCtaIng)
        Me.TabPage2.Controls.Add(Me.cboCtaTrs)
        Me.TabPage2.Controls.Add(Me.cboCtaCosVta)
        Me.TabPage2.Controls.Add(Me.cboCtaInv)
        Me.TabPage2.Controls.Add(Me.lblCtaDevCom)
        Me.TabPage2.Controls.Add(Me.lblCtaCom)
        Me.TabPage2.Controls.Add(Me.lblCtaRedInv)
        Me.TabPage2.Controls.Add(Me.lblCtaAumInv)
        Me.TabPage2.Controls.Add(Me.lblCtaRev)
        Me.TabPage2.Controls.Add(Me.lblCtaDifPre)
        Me.TabPage2.Controls.Add(Me.lblCtaDot)
        Me.TabPage2.Controls.Add(Me.lblCtaVrc)
        Me.TabPage2.Controls.Add(Me.lblCtaTrs)
        Me.TabPage2.Controls.Add(Me.lblCtaWIP)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lblCtaCosVta)
        Me.TabPage2.Controls.Add(Me.lblCtaInv)
        Me.TabPage2.Controls.Add(Me.lblCtaIng)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lblLin03)
        Me.TabPage2.Controls.Add(Me.lblLin04)
        Me.TabPage2.Controls.Add(Me.lblLin05)
        Me.TabPage2.Controls.Add(Me.lblLin06)
        Me.TabPage2.Controls.Add(Me.lblLin07)
        Me.TabPage2.Controls.Add(Me.lblLin08)
        Me.TabPage2.Controls.Add(Me.lblLin09)
        Me.TabPage2.Controls.Add(Me.lblLin10)
        Me.TabPage2.Controls.Add(Me.lblLin11)
        Me.TabPage2.Controls.Add(Me.lblLin12)
        Me.TabPage2.Controls.Add(Me.lblLin13)
        Me.TabPage2.Controls.Add(Me.lblLin14)
        Me.TabPage2.Controls.Add(Me.lblLin15)
        Me.TabPage2.Controls.Add(Me.lblLin16)
        Me.TabPage2.Controls.Add(Me.lblLin17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(688, 210)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Finanzas"
        '
        'cboCtaWIP
        '
        Me.cboCtaWIP.FormattingEnabled = True
        Me.cboCtaWIP.Location = New System.Drawing.Point(562, 157)
        Me.cboCtaWIP.Name = "cboCtaWIP"
        Me.cboCtaWIP.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaWIP.TabIndex = 278
        '
        'cboCtaDevCom
        '
        Me.cboCtaDevCom.FormattingEnabled = True
        Me.cboCtaDevCom.Location = New System.Drawing.Point(562, 132)
        Me.cboCtaDevCom.Name = "cboCtaDevCom"
        Me.cboCtaDevCom.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaDevCom.TabIndex = 277
        '
        'cboCtaCom
        '
        Me.cboCtaCom.FormattingEnabled = True
        Me.cboCtaCom.Location = New System.Drawing.Point(562, 107)
        Me.cboCtaCom.Name = "cboCtaCom"
        Me.cboCtaCom.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaCom.TabIndex = 276
        '
        'cboCtaRedInv
        '
        Me.cboCtaRedInv.FormattingEnabled = True
        Me.cboCtaRedInv.Location = New System.Drawing.Point(562, 82)
        Me.cboCtaRedInv.Name = "cboCtaRedInv"
        Me.cboCtaRedInv.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaRedInv.TabIndex = 275
        '
        'cboCtaAumInv
        '
        Me.cboCtaAumInv.FormattingEnabled = True
        Me.cboCtaAumInv.Location = New System.Drawing.Point(562, 57)
        Me.cboCtaAumInv.Name = "cboCtaAumInv"
        Me.cboCtaAumInv.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaAumInv.TabIndex = 274
        '
        'cboCtaRev
        '
        Me.cboCtaRev.FormattingEnabled = True
        Me.cboCtaRev.Location = New System.Drawing.Point(562, 32)
        Me.cboCtaRev.Name = "cboCtaRev"
        Me.cboCtaRev.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaRev.TabIndex = 273
        '
        'cboCtaDifPre
        '
        Me.cboCtaDifPre.FormattingEnabled = True
        Me.cboCtaDifPre.Location = New System.Drawing.Point(562, 7)
        Me.cboCtaDifPre.Name = "cboCtaDifPre"
        Me.cboCtaDifPre.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaDifPre.TabIndex = 272
        '
        'cboCtaDot
        '
        Me.cboCtaDot.FormattingEnabled = True
        Me.cboCtaDot.Location = New System.Drawing.Point(192, 182)
        Me.cboCtaDot.Name = "cboCtaDot"
        Me.cboCtaDot.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaDot.TabIndex = 271
        '
        'cboCtaGto
        '
        Me.cboCtaGto.FormattingEnabled = True
        Me.cboCtaGto.Location = New System.Drawing.Point(192, 157)
        Me.cboCtaGto.Name = "cboCtaGto"
        Me.cboCtaGto.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaGto.TabIndex = 270
        '
        'cboCtaVrc
        '
        Me.cboCtaVrc.FormattingEnabled = True
        Me.cboCtaVrc.Location = New System.Drawing.Point(192, 132)
        Me.cboCtaVrc.Name = "cboCtaVrc"
        Me.cboCtaVrc.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaVrc.TabIndex = 269
        '
        'cboCtaDevVta
        '
        Me.cboCtaDevVta.FormattingEnabled = True
        Me.cboCtaDevVta.Location = New System.Drawing.Point(192, 107)
        Me.cboCtaDevVta.Name = "cboCtaDevVta"
        Me.cboCtaDevVta.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaDevVta.TabIndex = 268
        '
        'cboCtaIng
        '
        Me.cboCtaIng.FormattingEnabled = True
        Me.cboCtaIng.Location = New System.Drawing.Point(192, 82)
        Me.cboCtaIng.Name = "cboCtaIng"
        Me.cboCtaIng.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaIng.TabIndex = 267
        '
        'cboCtaTrs
        '
        Me.cboCtaTrs.FormattingEnabled = True
        Me.cboCtaTrs.Location = New System.Drawing.Point(192, 57)
        Me.cboCtaTrs.Name = "cboCtaTrs"
        Me.cboCtaTrs.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaTrs.TabIndex = 265
        '
        'cboCtaCosVta
        '
        Me.cboCtaCosVta.FormattingEnabled = True
        Me.cboCtaCosVta.Location = New System.Drawing.Point(192, 32)
        Me.cboCtaCosVta.Name = "cboCtaCosVta"
        Me.cboCtaCosVta.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaCosVta.TabIndex = 263
        '
        'cboCtaInv
        '
        Me.cboCtaInv.FormattingEnabled = True
        Me.cboCtaInv.Location = New System.Drawing.Point(192, 7)
        Me.cboCtaInv.Name = "cboCtaInv"
        Me.cboCtaInv.Size = New System.Drawing.Size(121, 21)
        Me.cboCtaInv.TabIndex = 260
        '
        'lblCtaDevCom
        '
        Me.lblCtaDevCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaDevCom.AutoSize = True
        Me.lblCtaDevCom.Location = New System.Drawing.Point(370, 139)
        Me.lblCtaDevCom.Name = "lblCtaDevCom"
        Me.lblCtaDevCom.Size = New System.Drawing.Size(139, 13)
        Me.lblCtaDevCom.TabIndex = 266
        Me.lblCtaDevCom.Text = "Cuenta devolución compras"
        '
        'lblCtaCom
        '
        Me.lblCtaCom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaCom.AutoSize = True
        Me.lblCtaCom.Location = New System.Drawing.Point(370, 114)
        Me.lblCtaCom.Name = "lblCtaCom"
        Me.lblCtaCom.Size = New System.Drawing.Size(99, 13)
        Me.lblCtaCom.TabIndex = 264
        Me.lblCtaCom.Text = "Cuenta de compras"
        '
        'lblCtaRedInv
        '
        Me.lblCtaRedInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaRedInv.AutoSize = True
        Me.lblCtaRedInv.Location = New System.Drawing.Point(370, 89)
        Me.lblCtaRedInv.Name = "lblCtaRedInv"
        Me.lblCtaRedInv.Size = New System.Drawing.Size(165, 13)
        Me.lblCtaRedInv.TabIndex = 262
        Me.lblCtaRedInv.Text = "Cuenta disminución del inventario"
        '
        'lblCtaAumInv
        '
        Me.lblCtaAumInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaAumInv.AutoSize = True
        Me.lblCtaAumInv.Location = New System.Drawing.Point(370, 64)
        Me.lblCtaAumInv.Name = "lblCtaAumInv"
        Me.lblCtaAumInv.Size = New System.Drawing.Size(151, 13)
        Me.lblCtaAumInv.TabIndex = 261
        Me.lblCtaAumInv.Text = "Cuenta aumento del inventario"
        '
        'lblCtaRev
        '
        Me.lblCtaRev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaRev.AutoSize = True
        Me.lblCtaRev.Location = New System.Drawing.Point(370, 39)
        Me.lblCtaRev.Name = "lblCtaRev"
        Me.lblCtaRev.Size = New System.Drawing.Size(109, 13)
        Me.lblCtaRev.TabIndex = 259
        Me.lblCtaRev.Text = "Cuenta revalorización"
        '
        'lblCtaDifPre
        '
        Me.lblCtaDifPre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaDifPre.AutoSize = True
        Me.lblCtaDifPre.Location = New System.Drawing.Point(370, 14)
        Me.lblCtaDifPre.Name = "lblCtaDifPre"
        Me.lblCtaDifPre.Size = New System.Drawing.Size(152, 13)
        Me.lblCtaDifPre.TabIndex = 258
        Me.lblCtaDifPre.Text = "Cuenta de diferencia de precio"
        '
        'lblCtaDot
        '
        Me.lblCtaDot.AutoSize = True
        Me.lblCtaDot.Location = New System.Drawing.Point(7, 189)
        Me.lblCtaDot.Name = "lblCtaDot"
        Me.lblCtaDot.Size = New System.Drawing.Size(100, 13)
        Me.lblCtaDot.TabIndex = 257
        Me.lblCtaDot.Text = "Cuenta de dotación"
        '
        'lblCtaVrc
        '
        Me.lblCtaVrc.AutoSize = True
        Me.lblCtaVrc.Location = New System.Drawing.Point(7, 139)
        Me.lblCtaVrc.Name = "lblCtaVrc"
        Me.lblCtaVrc.Size = New System.Drawing.Size(113, 13)
        Me.lblCtaVrc.TabIndex = 256
        Me.lblCtaVrc.Text = "Cuenta de variaciones"
        '
        'lblCtaTrs
        '
        Me.lblCtaTrs.AutoSize = True
        Me.lblCtaTrs.Location = New System.Drawing.Point(7, 64)
        Me.lblCtaTrs.Name = "lblCtaTrs"
        Me.lblCtaTrs.Size = New System.Drawing.Size(120, 13)
        Me.lblCtaTrs.TabIndex = 255
        Me.lblCtaTrs.Text = "Cuenta de transferencia"
        '
        'lblCtaWIP
        '
        Me.lblCtaWIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaWIP.AutoSize = True
        Me.lblCtaWIP.Location = New System.Drawing.Point(370, 164)
        Me.lblCtaWIP.Name = "lblCtaWIP"
        Me.lblCtaWIP.Size = New System.Drawing.Size(168, 13)
        Me.lblCtaWIP.TabIndex = 254
        Me.lblCtaWIP.Text = "Cuenta de producción en proceso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 13)
        Me.Label8.TabIndex = 253
        Me.Label8.Text = "Cuenta de devoluciones de ventas"
        '
        'lblCtaCosVta
        '
        Me.lblCtaCosVta.AutoSize = True
        Me.lblCtaCosVta.Location = New System.Drawing.Point(7, 39)
        Me.lblCtaCosVta.Name = "lblCtaCosVta"
        Me.lblCtaCosVta.Size = New System.Drawing.Size(140, 13)
        Me.lblCtaCosVta.TabIndex = 252
        Me.lblCtaCosVta.Text = "Cuenta de costos de ventas"
        '
        'lblCtaInv
        '
        Me.lblCtaInv.AutoSize = True
        Me.lblCtaInv.Location = New System.Drawing.Point(7, 14)
        Me.lblCtaInv.Name = "lblCtaInv"
        Me.lblCtaInv.Size = New System.Drawing.Size(110, 13)
        Me.lblCtaInv.TabIndex = 251
        Me.lblCtaInv.Text = "Cuenta de inventarios"
        '
        'lblCtaIng
        '
        Me.lblCtaIng.AutoSize = True
        Me.lblCtaIng.Location = New System.Drawing.Point(7, 89)
        Me.lblCtaIng.Name = "lblCtaIng"
        Me.lblCtaIng.Size = New System.Drawing.Size(91, 13)
        Me.lblCtaIng.TabIndex = 250
        Me.lblCtaIng.Text = "Cuenta de ventas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 249
        Me.Label4.Text = "Cuenta de gastos"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(7, 15)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(229, 13)
        Me.lblLin03.TabIndex = 279
        Me.lblLin03.Text = "_____________________________________"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(5, 40)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(229, 13)
        Me.lblLin04.TabIndex = 280
        Me.lblLin04.Text = "_____________________________________"
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(5, 65)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(229, 13)
        Me.lblLin05.TabIndex = 281
        Me.lblLin05.Text = "_____________________________________"
        '
        'lblLin06
        '
        Me.lblLin06.AutoSize = True
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(5, 90)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(229, 13)
        Me.lblLin06.TabIndex = 282
        Me.lblLin06.Text = "_____________________________________"
        '
        'lblLin07
        '
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(8, 115)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(229, 13)
        Me.lblLin07.TabIndex = 283
        Me.lblLin07.Text = "_____________________________________"
        '
        'lblLin08
        '
        Me.lblLin08.AutoSize = True
        Me.lblLin08.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin08.Location = New System.Drawing.Point(5, 140)
        Me.lblLin08.Name = "lblLin08"
        Me.lblLin08.Size = New System.Drawing.Size(229, 13)
        Me.lblLin08.TabIndex = 284
        Me.lblLin08.Text = "_____________________________________"
        '
        'lblLin09
        '
        Me.lblLin09.AutoSize = True
        Me.lblLin09.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin09.Location = New System.Drawing.Point(7, 165)
        Me.lblLin09.Name = "lblLin09"
        Me.lblLin09.Size = New System.Drawing.Size(229, 13)
        Me.lblLin09.TabIndex = 285
        Me.lblLin09.Text = "_____________________________________"
        '
        'lblLin10
        '
        Me.lblLin10.AutoSize = True
        Me.lblLin10.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin10.Location = New System.Drawing.Point(7, 190)
        Me.lblLin10.Name = "lblLin10"
        Me.lblLin10.Size = New System.Drawing.Size(229, 13)
        Me.lblLin10.TabIndex = 286
        Me.lblLin10.Text = "_____________________________________"
        '
        'lblLin11
        '
        Me.lblLin11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin11.AutoSize = True
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(369, 15)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(229, 13)
        Me.lblLin11.TabIndex = 287
        Me.lblLin11.Text = "_____________________________________"
        '
        'lblLin12
        '
        Me.lblLin12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin12.AutoSize = True
        Me.lblLin12.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin12.Location = New System.Drawing.Point(371, 40)
        Me.lblLin12.Name = "lblLin12"
        Me.lblLin12.Size = New System.Drawing.Size(229, 13)
        Me.lblLin12.TabIndex = 288
        Me.lblLin12.Text = "_____________________________________"
        '
        'lblLin13
        '
        Me.lblLin13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin13.AutoSize = True
        Me.lblLin13.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin13.Location = New System.Drawing.Point(372, 65)
        Me.lblLin13.Name = "lblLin13"
        Me.lblLin13.Size = New System.Drawing.Size(229, 13)
        Me.lblLin13.TabIndex = 289
        Me.lblLin13.Text = "_____________________________________"
        '
        'lblLin14
        '
        Me.lblLin14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin14.AutoSize = True
        Me.lblLin14.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin14.Location = New System.Drawing.Point(369, 90)
        Me.lblLin14.Name = "lblLin14"
        Me.lblLin14.Size = New System.Drawing.Size(229, 13)
        Me.lblLin14.TabIndex = 290
        Me.lblLin14.Text = "_____________________________________"
        '
        'lblLin15
        '
        Me.lblLin15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin15.AutoSize = True
        Me.lblLin15.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin15.Location = New System.Drawing.Point(369, 115)
        Me.lblLin15.Name = "lblLin15"
        Me.lblLin15.Size = New System.Drawing.Size(229, 13)
        Me.lblLin15.TabIndex = 291
        Me.lblLin15.Text = "_____________________________________"
        '
        'lblLin16
        '
        Me.lblLin16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin16.AutoSize = True
        Me.lblLin16.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin16.Location = New System.Drawing.Point(371, 140)
        Me.lblLin16.Name = "lblLin16"
        Me.lblLin16.Size = New System.Drawing.Size(229, 13)
        Me.lblLin16.TabIndex = 292
        Me.lblLin16.Text = "_____________________________________"
        '
        'lblLin17
        '
        Me.lblLin17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin17.AutoSize = True
        Me.lblLin17.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin17.Location = New System.Drawing.Point(369, 165)
        Me.lblLin17.Name = "lblLin17"
        Me.lblLin17.Size = New System.Drawing.Size(229, 13)
        Me.lblLin17.TabIndex = 293
        Me.lblLin17.Text = "_____________________________________"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(5, 12)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 232
        Me.lblLin01.Text = "___________________________"
        '
        'lblLin02
        '
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(8, 37)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 233
        Me.lblLin02.Text = "___________________________"
        '
        'cmdLstATGRI
        '
        Me.cmdLstATGRI.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATGRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstATGRI.Location = New System.Drawing.Point(255, 5)
        Me.cmdLstATGRI.Name = "cmdLstATGRI"
        Me.cmdLstATGRI.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATGRI.TabIndex = 495
        Me.cmdLstATGRI.Text = "Lst"
        Me.cmdLstATGRI.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATGRI.UseVisualStyleBackColor = False
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(592, 30)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(88, 17)
        Me.chbbRegAci.TabIndex = 498
        Me.chbbRegAci.Text = "Grupo Activo"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'frmATGRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(704, 342)
        Me.Controls.Add(Me.chbbRegAci)
        Me.Controls.Add(Me.cmdLstATGRI)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtsNomGrp)
        Me.Controls.Add(Me.txtsCodGrp)
        Me.Controls.Add(Me.lblNomGrp)
        Me.Controls.Add(Me.lblCodGrp)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.lblLin01)
        Me.Controls.Add(Me.lblLin02)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmATGRI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos de inventarios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtsNomGrp As System.Windows.Forms.TextBox
    Friend WithEvents txtsCodGrp As System.Windows.Forms.TextBox
    Friend WithEvents lblNomGrp As System.Windows.Forms.Label
    Friend WithEvents lblCodGrp As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblMetAba As System.Windows.Forms.Label
    Friend WithEvents lblMetVlz As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents lblLin18 As System.Windows.Forms.Label
    Friend WithEvents lblLin19 As System.Windows.Forms.Label
    Friend WithEvents txtsMetVlz As System.Windows.Forms.TextBox
    Friend WithEvents txtsMetAba As System.Windows.Forms.TextBox
    Friend WithEvents cboCtaWIP As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaDevCom As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaCom As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaRedInv As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaAumInv As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaRev As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaDifPre As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaDot As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaGto As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaVrc As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaDevVta As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaIng As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaTrs As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaCosVta As System.Windows.Forms.ComboBox
    Friend WithEvents cboCtaInv As System.Windows.Forms.ComboBox
    Friend WithEvents lblCtaDevCom As System.Windows.Forms.Label
    Friend WithEvents lblCtaCom As System.Windows.Forms.Label
    Friend WithEvents lblCtaRedInv As System.Windows.Forms.Label
    Friend WithEvents lblCtaAumInv As System.Windows.Forms.Label
    Friend WithEvents lblCtaRev As System.Windows.Forms.Label
    Friend WithEvents lblCtaDifPre As System.Windows.Forms.Label
    Friend WithEvents lblCtaDot As System.Windows.Forms.Label
    Friend WithEvents lblCtaVrc As System.Windows.Forms.Label
    Friend WithEvents lblCtaTrs As System.Windows.Forms.Label
    Friend WithEvents lblCtaWIP As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCtaCosVta As System.Windows.Forms.Label
    Friend WithEvents lblCtaInv As System.Windows.Forms.Label
    Friend WithEvents lblCtaIng As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents lblLin08 As System.Windows.Forms.Label
    Friend WithEvents lblLin09 As System.Windows.Forms.Label
    Friend WithEvents lblLin10 As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents lblLin12 As System.Windows.Forms.Label
    Friend WithEvents lblLin13 As System.Windows.Forms.Label
    Friend WithEvents lblLin14 As System.Windows.Forms.Label
    Friend WithEvents lblLin15 As System.Windows.Forms.Label
    Friend WithEvents lblLin16 As System.Windows.Forms.Label
    Friend WithEvents lblLin17 As System.Windows.Forms.Label
    Friend WithEvents cmdLstATGRI As System.Windows.Forms.Button
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
End Class
