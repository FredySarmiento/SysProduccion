<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmACDEM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmACDEM))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblRelLeg = New System.Windows.Forms.Label()
        Me.lblFaxCia = New System.Windows.Forms.Label()
        Me.txtsFaxCia = New System.Windows.Forms.TextBox()
        Me.lblEmlCia = New System.Windows.Forms.Label()
        Me.txtsEmlCia = New System.Windows.Forms.TextBox()
        Me.lblTel2Cia = New System.Windows.Forms.Label()
        Me.txtsTel2Cia = New System.Windows.Forms.TextBox()
        Me.lblTel1Cia = New System.Windows.Forms.Label()
        Me.txtsTel1Cia = New System.Windows.Forms.TextBox()
        Me.txtsRepLeg = New System.Windows.Forms.TextBox()
        Me.txtsPaiCia = New System.Windows.Forms.TextBox()
        Me.lblPaiCia = New System.Windows.Forms.Label()
        Me.txtsDepCia = New System.Windows.Forms.TextBox()
        Me.lblDepCia = New System.Windows.Forms.Label()
        Me.txtsCiuCia = New System.Windows.Forms.TextBox()
        Me.lblCiuCia = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblDirCia = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNomCia = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.lblLin08 = New System.Windows.Forms.Label()
        Me.lblLin09 = New System.Windows.Forms.Label()
        Me.lblLin13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboATASI = New System.Windows.Forms.ComboBox()
        Me.lblAnoSdoIniInv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDigVer = New System.Windows.Forms.Label()
        Me.txtsDigVer = New System.Windows.Forms.TextBox()
        Me.lblNitCia = New System.Windows.Forms.Label()
        Me.txtsNitCia = New System.Windows.Forms.TextBox()
        Me.lblLin10 = New System.Windows.Forms.Label()
        Me.lblLin11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chbbMovSinCos = New System.Windows.Forms.CheckBox()
        Me.cbosTipInv = New System.Windows.Forms.ComboBox()
        Me.chbbCosXBod = New System.Windows.Forms.CheckBox()
        Me.lblTipInv = New System.Windows.Forms.Label()
        Me.chbbInvPte = New System.Windows.Forms.CheckBox()
        Me.lblLin12 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdEliminar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCancelar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOk)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdActualizar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCrear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdBuscar)
        Me.SplitContainer1.Size = New System.Drawing.Size(377, 465)
        Me.SplitContainer1.SplitterDistance = 409
        Me.SplitContainer1.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(377, 409)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblRelLeg)
        Me.TabPage1.Controls.Add(Me.lblFaxCia)
        Me.TabPage1.Controls.Add(Me.txtsFaxCia)
        Me.TabPage1.Controls.Add(Me.lblEmlCia)
        Me.TabPage1.Controls.Add(Me.txtsEmlCia)
        Me.TabPage1.Controls.Add(Me.lblTel2Cia)
        Me.TabPage1.Controls.Add(Me.txtsTel2Cia)
        Me.TabPage1.Controls.Add(Me.lblTel1Cia)
        Me.TabPage1.Controls.Add(Me.txtsTel1Cia)
        Me.TabPage1.Controls.Add(Me.txtsRepLeg)
        Me.TabPage1.Controls.Add(Me.txtsPaiCia)
        Me.TabPage1.Controls.Add(Me.lblPaiCia)
        Me.TabPage1.Controls.Add(Me.txtsDepCia)
        Me.TabPage1.Controls.Add(Me.lblDepCia)
        Me.TabPage1.Controls.Add(Me.txtsCiuCia)
        Me.TabPage1.Controls.Add(Me.lblCiuCia)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.lblDirCia)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.lblNomCia)
        Me.TabPage1.Controls.Add(Me.lblLin01)
        Me.TabPage1.Controls.Add(Me.lblLin02)
        Me.TabPage1.Controls.Add(Me.lblLin03)
        Me.TabPage1.Controls.Add(Me.lblLin04)
        Me.TabPage1.Controls.Add(Me.lblLin05)
        Me.TabPage1.Controls.Add(Me.lblLin06)
        Me.TabPage1.Controls.Add(Me.lblLin07)
        Me.TabPage1.Controls.Add(Me.lblLin08)
        Me.TabPage1.Controls.Add(Me.lblLin09)
        Me.TabPage1.Controls.Add(Me.lblLin13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(369, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'lblRelLeg
        '
        Me.lblRelLeg.AutoSize = True
        Me.lblRelLeg.Location = New System.Drawing.Point(5, 187)
        Me.lblRelLeg.Name = "lblRelLeg"
        Me.lblRelLeg.Size = New System.Drawing.Size(106, 13)
        Me.lblRelLeg.TabIndex = 50
        Me.lblRelLeg.Text = "Representante Legal"
        '
        'lblFaxCia
        '
        Me.lblFaxCia.AutoSize = True
        Me.lblFaxCia.Location = New System.Drawing.Point(6, 269)
        Me.lblFaxCia.Name = "lblFaxCia"
        Me.lblFaxCia.Size = New System.Drawing.Size(24, 13)
        Me.lblFaxCia.TabIndex = 39
        Me.lblFaxCia.Text = "Fax"
        '
        'txtsFaxCia
        '
        Me.txtsFaxCia.Location = New System.Drawing.Point(164, 263)
        Me.txtsFaxCia.MaxLength = 20
        Me.txtsFaxCia.Name = "txtsFaxCia"
        Me.txtsFaxCia.Size = New System.Drawing.Size(187, 20)
        Me.txtsFaxCia.TabIndex = 9
        '
        'lblEmlCia
        '
        Me.lblEmlCia.AutoSize = True
        Me.lblEmlCia.Location = New System.Drawing.Point(6, 296)
        Me.lblEmlCia.Name = "lblEmlCia"
        Me.lblEmlCia.Size = New System.Drawing.Size(94, 13)
        Me.lblEmlCia.TabIndex = 37
        Me.lblEmlCia.Text = "Correo Electrónico"
        '
        'txtsEmlCia
        '
        Me.txtsEmlCia.Location = New System.Drawing.Point(164, 290)
        Me.txtsEmlCia.MaxLength = 100
        Me.txtsEmlCia.Name = "txtsEmlCia"
        Me.txtsEmlCia.Size = New System.Drawing.Size(187, 20)
        Me.txtsEmlCia.TabIndex = 10
        '
        'lblTel2Cia
        '
        Me.lblTel2Cia.AutoSize = True
        Me.lblTel2Cia.Location = New System.Drawing.Point(5, 244)
        Me.lblTel2Cia.Name = "lblTel2Cia"
        Me.lblTel2Cia.Size = New System.Drawing.Size(58, 13)
        Me.lblTel2Cia.TabIndex = 35
        Me.lblTel2Cia.Text = "Telefono 2"
        '
        'txtsTel2Cia
        '
        Me.txtsTel2Cia.Location = New System.Drawing.Point(164, 238)
        Me.txtsTel2Cia.MaxLength = 20
        Me.txtsTel2Cia.Name = "txtsTel2Cia"
        Me.txtsTel2Cia.Size = New System.Drawing.Size(187, 20)
        Me.txtsTel2Cia.TabIndex = 8
        '
        'lblTel1Cia
        '
        Me.lblTel1Cia.AutoSize = True
        Me.lblTel1Cia.Location = New System.Drawing.Point(5, 216)
        Me.lblTel1Cia.Name = "lblTel1Cia"
        Me.lblTel1Cia.Size = New System.Drawing.Size(58, 13)
        Me.lblTel1Cia.TabIndex = 33
        Me.lblTel1Cia.Text = "Telefono 1"
        '
        'txtsTel1Cia
        '
        Me.txtsTel1Cia.Location = New System.Drawing.Point(164, 210)
        Me.txtsTel1Cia.MaxLength = 20
        Me.txtsTel1Cia.Name = "txtsTel1Cia"
        Me.txtsTel1Cia.Size = New System.Drawing.Size(187, 20)
        Me.txtsTel1Cia.TabIndex = 7
        '
        'txtsRepLeg
        '
        Me.txtsRepLeg.Location = New System.Drawing.Point(164, 181)
        Me.txtsRepLeg.MaxLength = 50
        Me.txtsRepLeg.Name = "txtsRepLeg"
        Me.txtsRepLeg.Size = New System.Drawing.Size(187, 20)
        Me.txtsRepLeg.TabIndex = 6
        '
        'txtsPaiCia
        '
        Me.txtsPaiCia.Location = New System.Drawing.Point(164, 155)
        Me.txtsPaiCia.MaxLength = 30
        Me.txtsPaiCia.Name = "txtsPaiCia"
        Me.txtsPaiCia.Size = New System.Drawing.Size(187, 20)
        Me.txtsPaiCia.TabIndex = 5
        '
        'lblPaiCia
        '
        Me.lblPaiCia.AutoSize = True
        Me.lblPaiCia.Location = New System.Drawing.Point(6, 161)
        Me.lblPaiCia.Name = "lblPaiCia"
        Me.lblPaiCia.Size = New System.Drawing.Size(29, 13)
        Me.lblPaiCia.TabIndex = 28
        Me.lblPaiCia.Text = "País"
        '
        'txtsDepCia
        '
        Me.txtsDepCia.Location = New System.Drawing.Point(164, 129)
        Me.txtsDepCia.MaxLength = 30
        Me.txtsDepCia.Name = "txtsDepCia"
        Me.txtsDepCia.Size = New System.Drawing.Size(187, 20)
        Me.txtsDepCia.TabIndex = 4
        '
        'lblDepCia
        '
        Me.lblDepCia.AutoSize = True
        Me.lblDepCia.Location = New System.Drawing.Point(6, 135)
        Me.lblDepCia.Name = "lblDepCia"
        Me.lblDepCia.Size = New System.Drawing.Size(74, 13)
        Me.lblDepCia.TabIndex = 26
        Me.lblDepCia.Text = "Departamento"
        '
        'txtsCiuCia
        '
        Me.txtsCiuCia.Location = New System.Drawing.Point(164, 103)
        Me.txtsCiuCia.MaxLength = 30
        Me.txtsCiuCia.Name = "txtsCiuCia"
        Me.txtsCiuCia.Size = New System.Drawing.Size(187, 20)
        Me.txtsCiuCia.TabIndex = 3
        '
        'lblCiuCia
        '
        Me.lblCiuCia.AutoSize = True
        Me.lblCiuCia.Location = New System.Drawing.Point(6, 109)
        Me.lblCiuCia.Name = "lblCiuCia"
        Me.lblCiuCia.Size = New System.Drawing.Size(40, 13)
        Me.lblCiuCia.TabIndex = 24
        Me.lblCiuCia.Text = "Ciudad"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 47)
        Me.TextBox2.MaxLength = 100
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 50)
        Me.TextBox2.TabIndex = 2
        '
        'lblDirCia
        '
        Me.lblDirCia.AutoSize = True
        Me.lblDirCia.Location = New System.Drawing.Point(6, 47)
        Me.lblDirCia.Name = "lblDirCia"
        Me.lblDirCia.Size = New System.Drawing.Size(52, 13)
        Me.lblDirCia.TabIndex = 22
        Me.lblDirCia.Text = "Dirección"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 19)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblNomCia
        '
        Me.lblNomCia.AutoSize = True
        Me.lblNomCia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblNomCia.Location = New System.Drawing.Point(5, 25)
        Me.lblNomCia.Name = "lblNomCia"
        Me.lblNomCia.Size = New System.Drawing.Size(114, 13)
        Me.lblNomCia.TabIndex = 20
        Me.lblNomCia.Text = "Nombre de la Empresa"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(3, 26)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 40
        Me.lblLin01.Text = "___________________________"
        '
        'lblLin02
        '
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(3, 84)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 41
        Me.lblLin02.Text = "___________________________"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(4, 110)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 42
        Me.lblLin03.Text = "___________________________"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(1, 136)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 43
        Me.lblLin04.Text = "___________________________"
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(4, 162)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(169, 13)
        Me.lblLin05.TabIndex = 44
        Me.lblLin05.Text = "___________________________"
        '
        'lblLin06
        '
        Me.lblLin06.AutoSize = True
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(1, 217)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(169, 13)
        Me.lblLin06.TabIndex = 45
        Me.lblLin06.Text = "___________________________"
        '
        'lblLin07
        '
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(1, 245)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(169, 13)
        Me.lblLin07.TabIndex = 46
        Me.lblLin07.Text = "___________________________"
        '
        'lblLin08
        '
        Me.lblLin08.AutoSize = True
        Me.lblLin08.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin08.Location = New System.Drawing.Point(1, 270)
        Me.lblLin08.Name = "lblLin08"
        Me.lblLin08.Size = New System.Drawing.Size(169, 13)
        Me.lblLin08.TabIndex = 47
        Me.lblLin08.Text = "___________________________"
        '
        'lblLin09
        '
        Me.lblLin09.AutoSize = True
        Me.lblLin09.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin09.Location = New System.Drawing.Point(1, 297)
        Me.lblLin09.Name = "lblLin09"
        Me.lblLin09.Size = New System.Drawing.Size(169, 13)
        Me.lblLin09.TabIndex = 48
        Me.lblLin09.Text = "___________________________"
        '
        'lblLin13
        '
        Me.lblLin13.AutoSize = True
        Me.lblLin13.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin13.Location = New System.Drawing.Point(1, 188)
        Me.lblLin13.Name = "lblLin13"
        Me.lblLin13.Size = New System.Drawing.Size(175, 13)
        Me.lblLin13.TabIndex = 49
        Me.lblLin13.Text = "____________________________"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.cboATASI)
        Me.TabPage2.Controls.Add(Me.lblAnoSdoIniInv)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lblDigVer)
        Me.TabPage2.Controls.Add(Me.txtsDigVer)
        Me.TabPage2.Controls.Add(Me.lblNitCia)
        Me.TabPage2.Controls.Add(Me.txtsNitCia)
        Me.TabPage2.Controls.Add(Me.lblLin10)
        Me.TabPage2.Controls.Add(Me.lblLin11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(369, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos de Contabilidad"
        '
        'cboATASI
        '
        Me.cboATASI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboATASI.FormattingEnabled = True
        Me.cboATASI.Items.AddRange(New Object() {"Promedio ponderado", "Estándar"})
        Me.cboATASI.Location = New System.Drawing.Point(164, 71)
        Me.cboATASI.Name = "cboATASI"
        Me.cboATASI.Size = New System.Drawing.Size(93, 21)
        Me.cboATASI.TabIndex = 47
        '
        'lblAnoSdoIniInv
        '
        Me.lblAnoSdoIniInv.AutoSize = True
        Me.lblAnoSdoIniInv.Location = New System.Drawing.Point(2, 77)
        Me.lblAnoSdoIniInv.Name = "lblAnoSdoIniInv"
        Me.lblAnoSdoIniInv.Size = New System.Drawing.Size(141, 13)
        Me.lblAnoSdoIniInv.TabIndex = 45
        Me.lblAnoSdoIniInv.Text = "Año Saldo Inicial Inventarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(2, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "___________________________"
        '
        'lblDigVer
        '
        Me.lblDigVer.AutoSize = True
        Me.lblDigVer.Location = New System.Drawing.Point(3, 49)
        Me.lblDigVer.Name = "lblDigVer"
        Me.lblDigVer.Size = New System.Drawing.Size(109, 13)
        Me.lblDigVer.TabIndex = 41
        Me.lblDigVer.Text = "Dígito de Verificación"
        '
        'txtsDigVer
        '
        Me.txtsDigVer.Location = New System.Drawing.Point(164, 45)
        Me.txtsDigVer.MaxLength = 1
        Me.txtsDigVer.Name = "txtsDigVer"
        Me.txtsDigVer.Size = New System.Drawing.Size(93, 20)
        Me.txtsDigVer.TabIndex = 14
        '
        'lblNitCia
        '
        Me.lblNitCia.AutoSize = True
        Me.lblNitCia.Location = New System.Drawing.Point(3, 23)
        Me.lblNitCia.Name = "lblNitCia"
        Me.lblNitCia.Size = New System.Drawing.Size(25, 13)
        Me.lblNitCia.TabIndex = 39
        Me.lblNitCia.Text = "NIT"
        '
        'txtsNitCia
        '
        Me.txtsNitCia.Location = New System.Drawing.Point(164, 17)
        Me.txtsNitCia.MaxLength = 13
        Me.txtsNitCia.Name = "txtsNitCia"
        Me.txtsNitCia.Size = New System.Drawing.Size(189, 20)
        Me.txtsNitCia.TabIndex = 13
        '
        'lblLin10
        '
        Me.lblLin10.AutoSize = True
        Me.lblLin10.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin10.Location = New System.Drawing.Point(4, 24)
        Me.lblLin10.Name = "lblLin10"
        Me.lblLin10.Size = New System.Drawing.Size(169, 13)
        Me.lblLin10.TabIndex = 42
        Me.lblLin10.Text = "___________________________"
        '
        'lblLin11
        '
        Me.lblLin11.AutoSize = True
        Me.lblLin11.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin11.Location = New System.Drawing.Point(3, 51)
        Me.lblLin11.Name = "lblLin11"
        Me.lblLin11.Size = New System.Drawing.Size(169, 13)
        Me.lblLin11.TabIndex = 43
        Me.lblLin11.Text = "___________________________"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.chbbMovSinCos)
        Me.TabPage3.Controls.Add(Me.cbosTipInv)
        Me.TabPage3.Controls.Add(Me.chbbCosXBod)
        Me.TabPage3.Controls.Add(Me.lblTipInv)
        Me.TabPage3.Controls.Add(Me.chbbInvPte)
        Me.TabPage3.Controls.Add(Me.lblLin12)
        Me.TabPage3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(369, 383)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inicialización"
        '
        'chbbMovSinCos
        '
        Me.chbbMovSinCos.AutoSize = True
        Me.chbbMovSinCos.Location = New System.Drawing.Point(31, 104)
        Me.chbbMovSinCos.Name = "chbbMovSinCos"
        Me.chbbMovSinCos.Size = New System.Drawing.Size(262, 17)
        Me.chbbMovSinCos.TabIndex = 18
        Me.chbbMovSinCos.Text = "Permite liberación de stock sin costos de artículos"
        Me.chbbMovSinCos.UseVisualStyleBackColor = True
        '
        'cbosTipInv
        '
        Me.cbosTipInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cbosTipInv.FormattingEnabled = True
        Me.cbosTipInv.Items.AddRange(New Object() {"Promedio ponderado", "Estándar"})
        Me.cbosTipInv.Location = New System.Drawing.Point(218, 42)
        Me.cbosTipInv.Name = "cbosTipInv"
        Me.cbosTipInv.Size = New System.Drawing.Size(138, 21)
        Me.cbosTipInv.TabIndex = 16
        '
        'chbbCosXBod
        '
        Me.chbbCosXBod.AutoSize = True
        Me.chbbCosXBod.Location = New System.Drawing.Point(30, 76)
        Me.chbbCosXBod.Name = "chbbCosXBod"
        Me.chbbCosXBod.Size = New System.Drawing.Size(215, 17)
        Me.chbbCosXBod.TabIndex = 17
        Me.chbbCosXBod.Text = "Gestionar costo de artículo por almacén"
        Me.chbbCosXBod.UseVisualStyleBackColor = True
        '
        'lblTipInv
        '
        Me.lblTipInv.AutoSize = True
        Me.lblTipInv.Location = New System.Drawing.Point(27, 48)
        Me.lblTipInv.Name = "lblTipInv"
        Me.lblTipInv.Size = New System.Drawing.Size(185, 13)
        Me.lblTipInv.TabIndex = 1
        Me.lblTipInv.Text = "Método de Valorización del Inventario"
        '
        'chbbInvPte
        '
        Me.chbbInvPte.AutoSize = True
        Me.chbbInvPte.Location = New System.Drawing.Point(8, 19)
        Me.chbbInvPte.Name = "chbbInvPte"
        Me.chbbInvPte.Size = New System.Drawing.Size(158, 17)
        Me.chbbInvPte.TabIndex = 15
        Me.chbbInvPte.Text = "Usar Inventario Permanente"
        Me.chbbInvPte.UseVisualStyleBackColor = True
        '
        'lblLin12
        '
        Me.lblLin12.AutoSize = True
        Me.lblLin12.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin12.Location = New System.Drawing.Point(27, 50)
        Me.lblLin12.Name = "lblLin12"
        Me.lblLin12.Size = New System.Drawing.Size(199, 13)
        Me.lblLin12.TabIndex = 44
        Me.lblLin12.Text = "________________________________"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(14, 18)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 39
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(95, 18)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 23
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdOk.Location = New System.Drawing.Point(14, 18)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 22
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(14, 18)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 24
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cmdCrear
        '
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(14, 18)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 37
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(14, 18)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 38
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'frmACDEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(377, 465)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(393, 503)
        Me.MinimumSize = New System.Drawing.Size(40, 100)
        Me.Name = "frmACDEM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la empresa"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblRelLeg As System.Windows.Forms.Label
    Friend WithEvents lblFaxCia As System.Windows.Forms.Label
    Friend WithEvents txtsFaxCia As System.Windows.Forms.TextBox
    Friend WithEvents lblEmlCia As System.Windows.Forms.Label
    Friend WithEvents txtsEmlCia As System.Windows.Forms.TextBox
    Friend WithEvents lblTel2Cia As System.Windows.Forms.Label
    Friend WithEvents txtsTel2Cia As System.Windows.Forms.TextBox
    Friend WithEvents lblTel1Cia As System.Windows.Forms.Label
    Friend WithEvents txtsTel1Cia As System.Windows.Forms.TextBox
    Friend WithEvents txtsRepLeg As System.Windows.Forms.TextBox
    Friend WithEvents txtsPaiCia As System.Windows.Forms.TextBox
    Friend WithEvents lblPaiCia As System.Windows.Forms.Label
    Friend WithEvents txtsDepCia As System.Windows.Forms.TextBox
    Friend WithEvents lblDepCia As System.Windows.Forms.Label
    Friend WithEvents txtsCiuCia As System.Windows.Forms.TextBox
    Friend WithEvents lblCiuCia As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDirCia As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNomCia As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents lblLin08 As System.Windows.Forms.Label
    Friend WithEvents lblLin09 As System.Windows.Forms.Label
    Friend WithEvents lblLin13 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblDigVer As System.Windows.Forms.Label
    Friend WithEvents txtsDigVer As System.Windows.Forms.TextBox
    Friend WithEvents lblNitCia As System.Windows.Forms.Label
    Friend WithEvents txtsNitCia As System.Windows.Forms.TextBox
    Friend WithEvents lblLin10 As System.Windows.Forms.Label
    Friend WithEvents lblLin11 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents chbbMovSinCos As System.Windows.Forms.CheckBox
    Friend WithEvents cbosTipInv As System.Windows.Forms.ComboBox
    Friend WithEvents chbbCosXBod As System.Windows.Forms.CheckBox
    Friend WithEvents lblTipInv As System.Windows.Forms.Label
    Friend WithEvents chbbInvPte As System.Windows.Forms.CheckBox
    Friend WithEvents lblLin12 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents lblAnoSdoIniInv As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboATASI As System.Windows.Forms.ComboBox
End Class
