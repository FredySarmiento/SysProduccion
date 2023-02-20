<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEFOM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEFOM))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtnTieItm = New System.Windows.Forms.TextBox()
        Me.lblTotTieOpe = New System.Windows.Forms.Label()
        Me.lblTotales = New System.Windows.Forms.Label()
        Me.txtnPorItm = New System.Windows.Forms.TextBox()
        Me.lblPorItm = New System.Windows.Forms.Label()
        Me.txtnPesItm = New System.Windows.Forms.TextBox()
        Me.lblPesItm = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboATALM = New System.Windows.Forms.ComboBox()
        Me.chbbRegAci = New System.Windows.Forms.CheckBox()
        Me.txtnCanLotStn = New System.Windows.Forms.TextBox()
        Me.txtsRegSan = New System.Windows.Forms.TextBox()
        Me.lblCanItm = New System.Windows.Forms.Label()
        Me.lblCanLotStn = New System.Windows.Forms.Label()
        Me.lblCodAlm = New System.Windows.Forms.Label()
        Me.mtbsCodItm = New System.Windows.Forms.MaskedTextBox()
        Me.cmdLstPEFOM = New System.Windows.Forms.Button()
        Me.cboABLIM = New System.Windows.Forms.ComboBox()
        Me.lblTipLstMat = New System.Windows.Forms.Label()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.cboACUNI = New System.Windows.Forms.ComboBox()
        Me.lblUniMedPro = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblCodItm = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.txtsNomItm = New System.Windows.Forms.TextBox()
        Me.lblNomItm = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.lblLin07 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv5 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.cmdCpd = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.txtnTieItm)
        Me.Panel2.Controls.Add(Me.lblTotTieOpe)
        Me.Panel2.Controls.Add(Me.lblTotales)
        Me.Panel2.Controls.Add(Me.txtnPorItm)
        Me.Panel2.Controls.Add(Me.lblPorItm)
        Me.Panel2.Controls.Add(Me.txtnPesItm)
        Me.Panel2.Controls.Add(Me.lblPesItm)
        Me.Panel2.Location = New System.Drawing.Point(627, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 128)
        Me.Panel2.TabIndex = 124
        '
        'txtnTieItm
        '
        Me.txtnTieItm.Enabled = False
        Me.txtnTieItm.Location = New System.Drawing.Point(96, 78)
        Me.txtnTieItm.Name = "txtnTieItm"
        Me.txtnTieItm.Size = New System.Drawing.Size(88, 20)
        Me.txtnTieItm.TabIndex = 10
        Me.txtnTieItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotTieOpe
        '
        Me.lblTotTieOpe.AutoSize = True
        Me.lblTotTieOpe.Location = New System.Drawing.Point(8, 80)
        Me.lblTotTieOpe.Name = "lblTotTieOpe"
        Me.lblTotTieOpe.Size = New System.Drawing.Size(78, 13)
        Me.lblTotTieOpe.TabIndex = 9
        Me.lblTotTieOpe.Text = "Total Tiempo  :"
        '
        'lblTotales
        '
        Me.lblTotales.AutoSize = True
        Me.lblTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotales.Location = New System.Drawing.Point(8, 6)
        Me.lblTotales.Name = "lblTotales"
        Me.lblTotales.Size = New System.Drawing.Size(53, 13)
        Me.lblTotales.TabIndex = 8
        Me.lblTotales.Text = "Totales "
        '
        'txtnPorItm
        '
        Me.txtnPorItm.Enabled = False
        Me.txtnPorItm.Location = New System.Drawing.Point(96, 52)
        Me.txtnPorItm.Name = "txtnPorItm"
        Me.txtnPorItm.Size = New System.Drawing.Size(88, 20)
        Me.txtnPorItm.TabIndex = 7
        Me.txtnPorItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPorItm
        '
        Me.lblPorItm.AutoSize = True
        Me.lblPorItm.Location = New System.Drawing.Point(8, 55)
        Me.lblPorItm.Name = "lblPorItm"
        Me.lblPorItm.Size = New System.Drawing.Size(51, 13)
        Me.lblPorItm.TabIndex = 6
        Me.lblPorItm.Text = "Total %  :"
        '
        'txtnPesItm
        '
        Me.txtnPesItm.Enabled = False
        Me.txtnPesItm.Location = New System.Drawing.Point(96, 26)
        Me.txtnPesItm.Name = "txtnPesItm"
        Me.txtnPesItm.Size = New System.Drawing.Size(89, 20)
        Me.txtnPesItm.TabIndex = 5
        Me.txtnPesItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPesItm
        '
        Me.lblPesItm.AutoSize = True
        Me.lblPesItm.Location = New System.Drawing.Point(8, 29)
        Me.lblPesItm.Name = "lblPesItm"
        Me.lblPesItm.Size = New System.Drawing.Size(63, 13)
        Me.lblPesItm.TabIndex = 4
        Me.lblPesItm.Text = "Total peso :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cboATALM)
        Me.Panel1.Controls.Add(Me.chbbRegAci)
        Me.Panel1.Controls.Add(Me.txtnCanLotStn)
        Me.Panel1.Controls.Add(Me.txtsRegSan)
        Me.Panel1.Controls.Add(Me.lblCanItm)
        Me.Panel1.Controls.Add(Me.lblCanLotStn)
        Me.Panel1.Controls.Add(Me.lblCodAlm)
        Me.Panel1.Controls.Add(Me.mtbsCodItm)
        Me.Panel1.Controls.Add(Me.cmdLstPEFOM)
        Me.Panel1.Controls.Add(Me.cboABLIM)
        Me.Panel1.Controls.Add(Me.lblTipLstMat)
        Me.Panel1.Controls.Add(Me.lblLin05)
        Me.Panel1.Controls.Add(Me.cboACUNI)
        Me.Panel1.Controls.Add(Me.lblUniMedPro)
        Me.Panel1.Controls.Add(Me.lblLin04)
        Me.Panel1.Controls.Add(Me.lblCodItm)
        Me.Panel1.Controls.Add(Me.lblLin01)
        Me.Panel1.Controls.Add(Me.txtsNomItm)
        Me.Panel1.Controls.Add(Me.lblNomItm)
        Me.Panel1.Controls.Add(Me.lblLin03)
        Me.Panel1.Controls.Add(Me.lblLin06)
        Me.Panel1.Controls.Add(Me.lblLin02)
        Me.Panel1.Controls.Add(Me.lblLin07)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 128)
        Me.Panel1.TabIndex = 123
        '
        'cboATALM
        '
        Me.cboATALM.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboATALM.FormattingEnabled = True
        Me.cboATALM.ItemHeight = 13
        Me.cboATALM.Location = New System.Drawing.Point(498, 76)
        Me.cboATALM.MaxLength = 6
        Me.cboATALM.Name = "cboATALM"
        Me.cboATALM.Size = New System.Drawing.Size(107, 21)
        Me.cboATALM.TabIndex = 8
        '
        'chbbRegAci
        '
        Me.chbbRegAci.AutoSize = True
        Me.chbbRegAci.Location = New System.Drawing.Point(373, 104)
        Me.chbbRegAci.Name = "chbbRegAci"
        Me.chbbRegAci.Size = New System.Drawing.Size(95, 17)
        Me.chbbRegAci.TabIndex = 10
        Me.chbbRegAci.Text = "Fórmula activa"
        Me.chbbRegAci.UseVisualStyleBackColor = True
        '
        'txtnCanLotStn
        '
        Me.txtnCanLotStn.Location = New System.Drawing.Point(171, 49)
        Me.txtnCanLotStn.MaxLength = 20
        Me.txtnCanLotStn.Name = "txtnCanLotStn"
        Me.txtnCanLotStn.Size = New System.Drawing.Size(100, 20)
        Me.txtnCanLotStn.TabIndex = 4
        Me.txtnCanLotStn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsRegSan
        '
        Me.txtsRegSan.Location = New System.Drawing.Point(171, 98)
        Me.txtsRegSan.MaxLength = 20
        Me.txtsRegSan.Name = "txtsRegSan"
        Me.txtsRegSan.Size = New System.Drawing.Size(100, 20)
        Me.txtsRegSan.TabIndex = 6
        '
        'lblCanItm
        '
        Me.lblCanItm.AutoSize = True
        Me.lblCanItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCanItm.Location = New System.Drawing.Point(5, 103)
        Me.lblCanItm.Name = "lblCanItm"
        Me.lblCanItm.Size = New System.Drawing.Size(93, 13)
        Me.lblCanItm.TabIndex = 108
        Me.lblCanItm.Text = "Registro Sanitario:"
        '
        'lblCanLotStn
        '
        Me.lblCanLotStn.AutoSize = True
        Me.lblCanLotStn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCanLotStn.Location = New System.Drawing.Point(5, 55)
        Me.lblCanLotStn.Name = "lblCanLotStn"
        Me.lblCanLotStn.Size = New System.Drawing.Size(72, 13)
        Me.lblCanLotStn.TabIndex = 121
        Me.lblCanLotStn.Text = "Lote estándar"
        '
        'lblCodAlm
        '
        Me.lblCodAlm.AutoSize = True
        Me.lblCodAlm.Location = New System.Drawing.Point(370, 82)
        Me.lblCodAlm.Name = "lblCodAlm"
        Me.lblCodAlm.Size = New System.Drawing.Size(102, 13)
        Me.lblCodAlm.TabIndex = 120
        Me.lblCodAlm.Text = "Almacén de entrada"
        '
        'mtbsCodItm
        '
        Me.mtbsCodItm.Location = New System.Drawing.Point(171, 2)
        Me.mtbsCodItm.Mask = "AAA-000"
        Me.mtbsCodItm.Name = "mtbsCodItm"
        Me.mtbsCodItm.Size = New System.Drawing.Size(100, 20)
        Me.mtbsCodItm.TabIndex = 1
        '
        'cmdLstPEFOM
        '
        Me.cmdLstPEFOM.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEFOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLstPEFOM.Location = New System.Drawing.Point(304, 4)
        Me.cmdLstPEFOM.Name = "cmdLstPEFOM"
        Me.cmdLstPEFOM.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstPEFOM.TabIndex = 100
        Me.cmdLstPEFOM.Text = "FM"
        Me.cmdLstPEFOM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstPEFOM.UseVisualStyleBackColor = False
        '
        'cboABLIM
        '
        Me.cboABLIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboABLIM.FormattingEnabled = True
        Me.cboABLIM.ItemHeight = 13
        Me.cboABLIM.Location = New System.Drawing.Point(498, 51)
        Me.cboABLIM.MaxLength = 6
        Me.cboABLIM.Name = "cboABLIM"
        Me.cboABLIM.Size = New System.Drawing.Size(107, 21)
        Me.cboABLIM.TabIndex = 7
        '
        'lblTipLstMat
        '
        Me.lblTipLstMat.AutoSize = True
        Me.lblTipLstMat.Location = New System.Drawing.Point(368, 57)
        Me.lblTipLstMat.Name = "lblTipLstMat"
        Me.lblTipLstMat.Size = New System.Drawing.Size(129, 13)
        Me.lblTipLstMat.TabIndex = 113
        Me.lblTipLstMat.Text = "Tipo de lista de materiales"
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(371, 59)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(181, 13)
        Me.lblLin05.TabIndex = 114
        Me.lblLin05.Text = "_____________________________"
        '
        'cboACUNI
        '
        Me.cboACUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboACUNI.FormattingEnabled = True
        Me.cboACUNI.ItemHeight = 13
        Me.cboACUNI.Location = New System.Drawing.Point(171, 73)
        Me.cboACUNI.MaxLength = 20
        Me.cboACUNI.Name = "cboACUNI"
        Me.cboACUNI.Size = New System.Drawing.Size(100, 21)
        Me.cboACUNI.TabIndex = 5
        '
        'lblUniMedPro
        '
        Me.lblUniMedPro.AutoSize = True
        Me.lblUniMedPro.Location = New System.Drawing.Point(5, 79)
        Me.lblUniMedPro.Name = "lblUniMedPro"
        Me.lblUniMedPro.Size = New System.Drawing.Size(78, 13)
        Me.lblUniMedPro.TabIndex = 110
        Me.lblUniMedPro.Text = "Unidad del lote"
        '
        'lblLin04
        '
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(5, 81)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(181, 13)
        Me.lblLin04.TabIndex = 111
        Me.lblLin04.Text = "_____________________________"
        '
        'lblCodItm
        '
        Me.lblCodItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCodItm.Location = New System.Drawing.Point(5, 8)
        Me.lblCodItm.Name = "lblCodItm"
        Me.lblCodItm.Size = New System.Drawing.Size(114, 13)
        Me.lblCodItm.TabIndex = 104
        Me.lblCodItm.Text = "Código de la fórmula"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(5, 9)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(181, 13)
        Me.lblLin01.TabIndex = 109
        Me.lblLin01.Text = "_____________________________"
        '
        'txtsNomItm
        '
        Me.txtsNomItm.Location = New System.Drawing.Point(171, 25)
        Me.txtsNomItm.MaxLength = 100
        Me.txtsNomItm.Name = "txtsNomItm"
        Me.txtsNomItm.Size = New System.Drawing.Size(434, 20)
        Me.txtsNomItm.TabIndex = 3
        '
        'lblNomItm
        '
        Me.lblNomItm.AutoSize = True
        Me.lblNomItm.Location = New System.Drawing.Point(5, 31)
        Me.lblNomItm.Name = "lblNomItm"
        Me.lblNomItm.Size = New System.Drawing.Size(63, 13)
        Me.lblNomItm.TabIndex = 105
        Me.lblNomItm.Text = "Descripción"
        '
        'lblLin03
        '
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(5, 32)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(181, 13)
        Me.lblLin03.TabIndex = 107
        Me.lblLin03.Text = "_____________________________"
        '
        'lblLin06
        '
        Me.lblLin06.AutoSize = True
        Me.lblLin06.BackColor = System.Drawing.Color.AliceBlue
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(5, 104)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(175, 13)
        Me.lblLin06.TabIndex = 126
        Me.lblLin06.Text = "____________________________"
        '
        'lblLin02
        '
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(5, 56)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(247, 13)
        Me.lblLin02.TabIndex = 127
        Me.lblLin02.Text = "________________________________________"
        '
        'lblLin07
        '
        Me.lblLin07.AutoSize = True
        Me.lblLin07.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin07.Location = New System.Drawing.Point(372, 83)
        Me.lblLin07.Name = "lblLin07"
        Me.lblLin07.Size = New System.Drawing.Size(187, 13)
        Me.lblLin07.TabIndex = 129
        Me.lblLin07.Text = "______________________________"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(87, 476)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(4, 476)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 13
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(5, 476)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 16
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(5, 476)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 14
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(5, 476)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 15
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(6, 476)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 17
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.dgv5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(801, 303)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Análisis"
        '
        'dgv5
        '
        Me.dgv5.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv5.Location = New System.Drawing.Point(3, 3)
        Me.dgv5.Name = "dgv5"
        Me.dgv5.Size = New System.Drawing.Size(795, 297)
        Me.dgv5.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.dgv1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Componentes"
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.GridColor = System.Drawing.Color.AliceBlue
        Me.dgv1.Location = New System.Drawing.Point(3, 3)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(795, 297)
        Me.dgv1.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(5, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 329)
        Me.TabControl1.TabIndex = 10
        '
        'cmdCpd
        '
        Me.cmdCpd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCpd.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCpd.Location = New System.Drawing.Point(737, 476)
        Me.cmdCpd.Name = "cmdCpd"
        Me.cmdCpd.Size = New System.Drawing.Size(75, 22)
        Me.cmdCpd.TabIndex = 576
        Me.cmdCpd.Text = "Co&piar de.."
        Me.cmdCpd.UseVisualStyleBackColor = False
        '
        'frmPEFOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(824, 502)
        Me.Controls.Add(Me.cmdCpd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdOk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEFOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fórmulas maestra"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtnTieItm As System.Windows.Forms.TextBox
    Friend WithEvents lblTotTieOpe As System.Windows.Forms.Label
    Friend WithEvents lblTotales As System.Windows.Forms.Label
    Friend WithEvents txtnPorItm As System.Windows.Forms.TextBox
    Friend WithEvents lblPorItm As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mtbsCodItm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdLstPEFOM As System.Windows.Forms.Button
    Friend WithEvents cboABLIM As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipLstMat As System.Windows.Forms.Label
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents cboACUNI As System.Windows.Forms.ComboBox
    Friend WithEvents lblUniMedPro As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lblCanItm As System.Windows.Forms.Label
    Friend WithEvents lblCodItm As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents txtsNomItm As System.Windows.Forms.TextBox
    Friend WithEvents lblNomItm As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents txtnPesItm As System.Windows.Forms.TextBox
    Friend WithEvents lblPesItm As System.Windows.Forms.Label
    Friend WithEvents lblCodAlm As System.Windows.Forms.Label
    Friend WithEvents lblCanLotStn As System.Windows.Forms.Label
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents txtnCanLotStn As System.Windows.Forms.TextBox
    Friend WithEvents lblLin07 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv5 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents chbbRegAci As System.Windows.Forms.CheckBox
    Friend WithEvents cboATALM As System.Windows.Forms.ComboBox
    Friend WithEvents txtsRegSan As System.Windows.Forms.TextBox
    Friend WithEvents cmdCpd As System.Windows.Forms.Button
End Class
