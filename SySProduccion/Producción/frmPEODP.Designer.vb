<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPEODP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPEODP))
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cboACUNI = New System.Windows.Forms.ComboBox()
        Me.lblUniMedPro = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtbsCodItm = New System.Windows.Forms.MaskedTextBox()
        Me.cmdLstPELIM = New System.Windows.Forms.Button()
        Me.cboABEOP = New System.Windows.Forms.ComboBox()
        Me.txtnCanOdp = New System.Windows.Forms.TextBox()
        Me.txtsNomItm = New System.Windows.Forms.TextBox()
        Me.txtnNroDoc = New System.Windows.Forms.TextBox()
        Me.cboABODP = New System.Windows.Forms.ComboBox()
        Me.lblCanOdp = New System.Windows.Forms.Label()
        Me.lblNomItm = New System.Windows.Forms.Label()
        Me.lblLin04 = New System.Windows.Forms.Label()
        Me.lblEstOdp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLin06 = New System.Windows.Forms.Label()
        Me.lblCodItm = New System.Windows.Forms.Label()
        Me.lblLin05 = New System.Windows.Forms.Label()
        Me.lblCodDoc = New System.Windows.Forms.Label()
        Me.lblLin01 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstCpA = New System.Windows.Forms.ListBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtnVrcTasCIF = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtnVrcCosUni = New System.Windows.Forms.TextBox()
        Me.txtnVrcUni = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtnVrcTotCIF = New System.Windows.Forms.TextBox()
        Me.txtnVrcTotMOD = New System.Windows.Forms.TextBox()
        Me.txtnVrcTotMPD = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtnVrcCosTot = New System.Windows.Forms.TextBox()
        Me.txtnVrcTieMOD = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtnTotTasCnsCIF = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtnCosUniCns = New System.Windows.Forms.TextBox()
        Me.txtnTotUniCns = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtnVlrTotCnsCIF = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotCnsMOD = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotCnsMPD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnCosTotCns = New System.Windows.Forms.TextBox()
        Me.txtnTotTieCnsMOD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtnTotTasReqCIF = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtnCosUniReq = New System.Windows.Forms.TextBox()
        Me.txtnTotUniReq = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtnVlrTotReqCIF = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotReqMOD = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotReqMPD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnCosTotReq = New System.Windows.Forms.TextBox()
        Me.txtnTotTieReqMOD = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotCosReqOP = New System.Windows.Forms.Label()
        Me.lblTotReq = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgv5 = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtnTotVta = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtnItoTotCns = New System.Windows.Forms.TextBox()
        Me.txtnUtiTot = New System.Windows.Forms.TextBox()
        Me.txtnGtoTotCns = New System.Windows.Forms.TextBox()
        Me.txtnCosTotCns1 = New System.Windows.Forms.TextBox()
        Me.txtnVlrUniCnsCIF = New System.Windows.Forms.TextBox()
        Me.txtnVlrUniCnsMOD = New System.Windows.Forms.TextBox()
        Me.txtnVlrUniCnsMPD = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtnCanUniEdp1 = New System.Windows.Forms.TextBox()
        Me.txtnPreVta = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtnUtiUni = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotCnsCIF1 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtnGtoUniCns = New System.Windows.Forms.TextBox()
        Me.txtnCosUniCns1 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtnPorGto = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotCnsMOD1 = New System.Windows.Forms.TextBox()
        Me.txtnPorIto = New System.Windows.Forms.TextBox()
        Me.txtnItoUniCns = New System.Windows.Forms.TextBox()
        Me.txtnVlrTotCnsMPD1 = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtnCanUniEdp = New System.Windows.Forms.TextBox()
        Me.lblCanUniEdp = New System.Windows.Forms.Label()
        Me.cmdLstATALM = New System.Windows.Forms.Button()
        Me.txtsCodAlm = New System.Windows.Forms.TextBox()
        Me.lblCodAlm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFecFin = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecEmi = New System.Windows.Forms.DateTimePicker()
        Me.lblFecIni = New System.Windows.Forms.Label()
        Me.lblLin03 = New System.Windows.Forms.Label()
        Me.lblFecEmi = New System.Windows.Forms.Label()
        Me.lblLin02 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cboAPLND1 = New System.Windows.Forms.ComboBox()
        Me.lblNroLot = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtsNroLot = New System.Windows.Forms.TextBox()
        Me.lblCanUniOdp = New System.Windows.Forms.Label()
        Me.txtnCanUniOdp = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lblCanUniStn = New System.Windows.Forms.Label()
        Me.txtnCanUniStn = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lblTiexUni = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtnTieItm = New System.Windows.Forms.TextBox()
        Me.lblTotTieOdp = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtnTotTieOdp = New System.Windows.Forms.TextBox()
        Me.txtnTotTieEdp = New System.Windows.Forms.TextBox()
        Me.lblTotTieEdp = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtsUniMedInv = New System.Windows.Forms.TextBox()
        Me.txtsUniMedInv1 = New System.Windows.Forms.TextBox()
        Me.txtsUniMedInv2 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmdLstPEODP = New System.Windows.Forms.Button()
        Me.cmdCpa = New System.Windows.Forms.Button()
        Me.txtsCmn = New System.Windows.Forms.TextBox()
        Me.lblsCmn = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.cmdRecODP = New System.Windows.Forms.Button()
        Me.cmdRecEDP = New System.Windows.Forms.Button()
        Me.cmdRecInv = New System.Windows.Forms.Button()
        Me.cmdImpFal = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEliminar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdEliminar.Location = New System.Drawing.Point(3, 475)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 22)
        Me.cmdEliminar.TabIndex = 105
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCrear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCrear.Location = New System.Drawing.Point(3, 475)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 22)
        Me.cmdCrear.TabIndex = 100
        Me.cmdCrear.Text = "&Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdOk.Location = New System.Drawing.Point(3, 475)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 22)
        Me.cmdOk.TabIndex = 107
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdActualizar.Location = New System.Drawing.Point(3, 475)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(75, 22)
        Me.cmdActualizar.TabIndex = 101
        Me.cmdActualizar.Text = "&Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = False
        Me.cmdActualizar.Visible = False
        '
        'cboACUNI
        '
        Me.cboACUNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.cboACUNI.FormattingEnabled = True
        Me.cboACUNI.ItemHeight = 13
        Me.cboACUNI.Location = New System.Drawing.Point(133, 138)
        Me.cboACUNI.MaxLength = 20
        Me.cboACUNI.Name = "cboACUNI"
        Me.cboACUNI.Size = New System.Drawing.Size(100, 21)
        Me.cboACUNI.TabIndex = 19
        '
        'lblUniMedPro
        '
        Me.lblUniMedPro.AutoSize = True
        Me.lblUniMedPro.Location = New System.Drawing.Point(3, 145)
        Me.lblUniMedPro.Name = "lblUniMedPro"
        Me.lblUniMedPro.Size = New System.Drawing.Size(112, 13)
        Me.lblUniMedPro.TabIndex = 171
        Me.lblUniMedPro.Text = "Unidad de producción"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.LightGray
        Me.Label15.Location = New System.Drawing.Point(3, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 13)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "_____________________________"
        '
        'mtbsCodItm
        '
        Me.mtbsCodItm.Location = New System.Drawing.Point(133, 94)
        Me.mtbsCodItm.Mask = "AAA-000"
        Me.mtbsCodItm.Name = "mtbsCodItm"
        Me.mtbsCodItm.Size = New System.Drawing.Size(100, 20)
        Me.mtbsCodItm.TabIndex = 13
        '
        'cmdLstPELIM
        '
        Me.cmdLstPELIM.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPELIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdLstPELIM.Location = New System.Drawing.Point(238, 99)
        Me.cmdLstPELIM.Name = "cmdLstPELIM"
        Me.cmdLstPELIM.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstPELIM.TabIndex = 15
        Me.cmdLstPELIM.Text = "Lst"
        Me.cmdLstPELIM.UseVisualStyleBackColor = False
        '
        'cboABEOP
        '
        Me.cboABEOP.FormattingEnabled = True
        Me.cboABEOP.Location = New System.Drawing.Point(133, 71)
        Me.cboABEOP.Name = "cboABEOP"
        Me.cboABEOP.Size = New System.Drawing.Size(100, 21)
        Me.cboABEOP.TabIndex = 11
        '
        'txtnCanOdp
        '
        Me.txtnCanOdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnCanOdp.Location = New System.Drawing.Point(133, 116)
        Me.txtnCanOdp.MaxLength = 15
        Me.txtnCanOdp.Name = "txtnCanOdp"
        Me.txtnCanOdp.Size = New System.Drawing.Size(100, 20)
        Me.txtnCanOdp.TabIndex = 17
        Me.txtnCanOdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsNomItm
        '
        Me.txtsNomItm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsNomItm.BackColor = System.Drawing.SystemColors.Window
        Me.txtsNomItm.Enabled = False
        Me.txtsNomItm.Location = New System.Drawing.Point(431, 94)
        Me.txtsNomItm.MaxLength = 100
        Me.txtsNomItm.Name = "txtsNomItm"
        Me.txtsNomItm.Size = New System.Drawing.Size(387, 20)
        Me.txtsNomItm.TabIndex = 33
        '
        'txtnNroDoc
        '
        Me.txtnNroDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtnNroDoc.Enabled = False
        Me.txtnNroDoc.Location = New System.Drawing.Point(239, 28)
        Me.txtnNroDoc.MaxLength = 20
        Me.txtnNroDoc.Name = "txtnNroDoc"
        Me.txtnNroDoc.Size = New System.Drawing.Size(84, 20)
        Me.txtnNroDoc.TabIndex = 7
        Me.txtnNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboABODP
        '
        Me.cboABODP.FormattingEnabled = True
        Me.cboABODP.Location = New System.Drawing.Point(133, 3)
        Me.cboABODP.Name = "cboABODP"
        Me.cboABODP.Size = New System.Drawing.Size(100, 21)
        Me.cboABODP.TabIndex = 1
        '
        'lblCanOdp
        '
        Me.lblCanOdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCanOdp.Location = New System.Drawing.Point(3, 122)
        Me.lblCanOdp.Name = "lblCanOdp"
        Me.lblCanOdp.Size = New System.Drawing.Size(114, 13)
        Me.lblCanOdp.TabIndex = 162
        Me.lblCanOdp.Text = "Cantidad a producir"
        '
        'lblNomItm
        '
        Me.lblNomItm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNomItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblNomItm.Location = New System.Drawing.Point(290, 100)
        Me.lblNomItm.Name = "lblNomItm"
        Me.lblNomItm.Size = New System.Drawing.Size(115, 13)
        Me.lblNomItm.TabIndex = 168
        Me.lblNomItm.Text = "Nombre"
        '
        'lblLin04
        '
        Me.lblLin04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin04.AutoSize = True
        Me.lblLin04.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin04.Location = New System.Drawing.Point(295, 101)
        Me.lblLin04.Name = "lblLin04"
        Me.lblLin04.Size = New System.Drawing.Size(169, 13)
        Me.lblLin04.TabIndex = 169
        Me.lblLin04.Text = "___________________________"
        '
        'lblEstOdp
        '
        Me.lblEstOdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblEstOdp.Location = New System.Drawing.Point(3, 78)
        Me.lblEstOdp.Name = "lblEstOdp"
        Me.lblEstOdp.Size = New System.Drawing.Size(114, 13)
        Me.lblEstOdp.TabIndex = 166
        Me.lblEstOdp.Text = "Estado OP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(3, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "___________________________"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblNroDoc.Location = New System.Drawing.Point(3, 33)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(114, 13)
        Me.lblNroDoc.TabIndex = 164
        Me.lblNroDoc.Text = "Número OP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "___________________________"
        '
        'lblLin06
        '
        Me.lblLin06.AutoSize = True
        Me.lblLin06.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin06.Location = New System.Drawing.Point(3, 123)
        Me.lblLin06.Name = "lblLin06"
        Me.lblLin06.Size = New System.Drawing.Size(169, 13)
        Me.lblLin06.TabIndex = 163
        Me.lblLin06.Text = "___________________________"
        '
        'lblCodItm
        '
        Me.lblCodItm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCodItm.Location = New System.Drawing.Point(3, 100)
        Me.lblCodItm.Name = "lblCodItm"
        Me.lblCodItm.Size = New System.Drawing.Size(115, 13)
        Me.lblCodItm.TabIndex = 160
        Me.lblCodItm.Text = "Ítem a producir"
        '
        'lblLin05
        '
        Me.lblLin05.AutoSize = True
        Me.lblLin05.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin05.Location = New System.Drawing.Point(3, 101)
        Me.lblLin05.Name = "lblLin05"
        Me.lblLin05.Size = New System.Drawing.Size(169, 13)
        Me.lblLin05.TabIndex = 161
        Me.lblLin05.Text = "___________________________"
        '
        'lblCodDoc
        '
        Me.lblCodDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCodDoc.Location = New System.Drawing.Point(3, 10)
        Me.lblCodDoc.Name = "lblCodDoc"
        Me.lblCodDoc.Size = New System.Drawing.Size(114, 13)
        Me.lblCodDoc.TabIndex = 158
        Me.lblCodDoc.Text = "Tipo de OP"
        '
        'lblLin01
        '
        Me.lblLin01.AutoSize = True
        Me.lblLin01.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin01.Location = New System.Drawing.Point(3, 11)
        Me.lblLin01.Name = "lblLin01"
        Me.lblLin01.Size = New System.Drawing.Size(169, 13)
        Me.lblLin01.TabIndex = 159
        Me.lblLin01.Text = "___________________________"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(3, 184)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(817, 285)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.lstCpA)
        Me.TabPage1.Controls.Add(Me.dgv1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(809, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Componentes"
        '
        'lstCpA
        '
        Me.lstCpA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCpA.FormattingEnabled = True
        Me.lstCpA.Items.AddRange(New Object() {"Salida de Materiales", "Entrada de producción", "Devolución de Materiales"})
        Me.lstCpA.Location = New System.Drawing.Point(695, 214)
        Me.lstCpA.Name = "lstCpA"
        Me.lstCpA.Size = New System.Drawing.Size(108, 43)
        Me.lstCpA.TabIndex = 265
        Me.lstCpA.Visible = False
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 3)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(803, 253)
        Me.dgv1.TabIndex = 55
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage2.Controls.Add(Me.dgv2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(809, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Operaciones"
        '
        'dgv2
        '
        Me.dgv2.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv2.Location = New System.Drawing.Point(3, 3)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(803, 253)
        Me.dgv2.TabIndex = 57
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage3.Controls.Add(Me.dgv3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(809, 259)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CIF"
        '
        'dgv3
        '
        Me.dgv3.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv3.Location = New System.Drawing.Point(3, 3)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.Size = New System.Drawing.Size(803, 253)
        Me.dgv3.TabIndex = 59
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(809, 259)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Resumen"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtnVrcTasCIF)
        Me.Panel3.Controls.Add(Me.Label45)
        Me.Panel3.Controls.Add(Me.txtnVrcCosUni)
        Me.Panel3.Controls.Add(Me.txtnVrcUni)
        Me.Panel3.Controls.Add(Me.Label46)
        Me.Panel3.Controls.Add(Me.Label47)
        Me.Panel3.Controls.Add(Me.Label48)
        Me.Panel3.Controls.Add(Me.txtnVrcTotCIF)
        Me.Panel3.Controls.Add(Me.txtnVrcTotMOD)
        Me.Panel3.Controls.Add(Me.txtnVrcTotMPD)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.txtnVrcCosTot)
        Me.Panel3.Controls.Add(Me.txtnVrcTieMOD)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Location = New System.Drawing.Point(541, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 234)
        Me.Panel3.TabIndex = 65
        '
        'txtnVrcTasCIF
        '
        Me.txtnVrcTasCIF.Enabled = False
        Me.txtnVrcTasCIF.Location = New System.Drawing.Point(84, 124)
        Me.txtnVrcTasCIF.Name = "txtnVrcTasCIF"
        Me.txtnVrcTasCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcTasCIF.TabIndex = 163
        Me.txtnVrcTasCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(3, 205)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(71, 13)
        Me.Label45.TabIndex = 162
        Me.Label45.Text = "Costo unitario"
        '
        'txtnVrcCosUni
        '
        Me.txtnVrcCosUni.Enabled = False
        Me.txtnVrcCosUni.Location = New System.Drawing.Point(172, 199)
        Me.txtnVrcCosUni.Name = "txtnVrcCosUni"
        Me.txtnVrcCosUni.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcCosUni.TabIndex = 161
        Me.txtnVrcCosUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVrcUni
        '
        Me.txtnVrcUni.Enabled = False
        Me.txtnVrcUni.Location = New System.Drawing.Point(172, 173)
        Me.txtnVrcUni.Name = "txtnVrcUni"
        Me.txtnVrcUni.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcUni.TabIndex = 159
        Me.txtnVrcUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(3, 179)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(79, 13)
        Me.Label46.TabIndex = 157
        Me.Label46.Text = "Toltal unidades"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.LightGray
        Me.Label47.Location = New System.Drawing.Point(3, 180)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(223, 13)
        Me.Label47.TabIndex = 158
        Me.Label47.Text = "____________________________________"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.LightGray
        Me.Label48.Location = New System.Drawing.Point(3, 206)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(223, 13)
        Me.Label48.TabIndex = 160
        Me.Label48.Text = "____________________________________"
        '
        'txtnVrcTotCIF
        '
        Me.txtnVrcTotCIF.Enabled = False
        Me.txtnVrcTotCIF.Location = New System.Drawing.Point(172, 124)
        Me.txtnVrcTotCIF.Name = "txtnVrcTotCIF"
        Me.txtnVrcTotCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcTotCIF.TabIndex = 150
        Me.txtnVrcTotCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVrcTotMOD
        '
        Me.txtnVrcTotMOD.Enabled = False
        Me.txtnVrcTotMOD.Location = New System.Drawing.Point(173, 98)
        Me.txtnVrcTotMOD.Name = "txtnVrcTotMOD"
        Me.txtnVrcTotMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcTotMOD.TabIndex = 149
        Me.txtnVrcTotMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVrcTotMPD
        '
        Me.txtnVrcTotMPD.Enabled = False
        Me.txtnVrcTotMPD.Location = New System.Drawing.Point(173, 72)
        Me.txtnVrcTotMPD.Name = "txtnVrcTotMPD"
        Me.txtnVrcTotMPD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcTotMPD.TabIndex = 148
        Me.txtnVrcTotMPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(84, 38)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 13)
        Me.Label26.TabIndex = 147
        Me.Label26.Text = "Cantidades"
        '
        'txtnVrcCosTot
        '
        Me.txtnVrcCosTot.Enabled = False
        Me.txtnVrcCosTot.Location = New System.Drawing.Point(172, 149)
        Me.txtnVrcCosTot.Name = "txtnVrcCosTot"
        Me.txtnVrcCosTot.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcCosTot.TabIndex = 146
        Me.txtnVrcCosTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVrcTieMOD
        '
        Me.txtnVrcTieMOD.Enabled = False
        Me.txtnVrcTieMOD.Location = New System.Drawing.Point(84, 98)
        Me.txtnVrcTieMOD.Name = "txtnVrcTieMOD"
        Me.txtnVrcTieMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVrcTieMOD.TabIndex = 144
        Me.txtnVrcTieMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 154)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 13)
        Me.Label27.TabIndex = 123
        Me.Label27.Text = "Costo Total"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 129)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 13)
        Me.Label28.TabIndex = 122
        Me.Label28.Text = "C.I.F."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 104)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 13)
        Me.Label29.TabIndex = 121
        Me.Label29.Text = "M.O.D."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 78)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 13)
        Me.Label30.TabIndex = 120
        Me.Label30.Text = "Materiales"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(186, 38)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 119
        Me.Label31.Text = "Costos"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(3, 3)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 13)
        Me.Label32.TabIndex = 118
        Me.Label32.Text = "Variaciones"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.LightGray
        Me.Label33.Location = New System.Drawing.Point(3, 79)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(211, 13)
        Me.Label33.TabIndex = 139
        Me.Label33.Text = "__________________________________"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.LightGray
        Me.Label34.Location = New System.Drawing.Point(3, 105)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(211, 13)
        Me.Label34.TabIndex = 140
        Me.Label34.Text = "__________________________________"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.LightGray
        Me.Label35.Location = New System.Drawing.Point(3, 131)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(211, 13)
        Me.Label35.TabIndex = 141
        Me.Label35.Text = "__________________________________"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.LightGray
        Me.Label36.Location = New System.Drawing.Point(3, 156)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(223, 13)
        Me.Label36.TabIndex = 142
        Me.Label36.Text = "____________________________________"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtnTotTasCnsCIF)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.txtnCosUniCns)
        Me.Panel1.Controls.Add(Me.txtnTotUniCns)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Controls.Add(Me.txtnVlrTotCnsCIF)
        Me.Panel1.Controls.Add(Me.txtnVlrTotCnsMOD)
        Me.Panel1.Controls.Add(Me.txtnVlrTotCnsMPD)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtnCosTotCns)
        Me.Panel1.Controls.Add(Me.txtnTotTieCnsMOD)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Location = New System.Drawing.Point(273, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 234)
        Me.Panel1.TabIndex = 15163
        '
        'txtnTotTasCnsCIF
        '
        Me.txtnTotTasCnsCIF.Enabled = False
        Me.txtnTotTasCnsCIF.Location = New System.Drawing.Point(85, 124)
        Me.txtnTotTasCnsCIF.Name = "txtnTotTasCnsCIF"
        Me.txtnTotTasCnsCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotTasCnsCIF.TabIndex = 158
        Me.txtnTotTasCnsCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(3, 207)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 13)
        Me.Label41.TabIndex = 162
        Me.Label41.Text = "Costo unitario"
        '
        'txtnCosUniCns
        '
        Me.txtnCosUniCns.Enabled = False
        Me.txtnCosUniCns.Location = New System.Drawing.Point(172, 201)
        Me.txtnCosUniCns.Name = "txtnCosUniCns"
        Me.txtnCosUniCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnCosUniCns.TabIndex = 161
        Me.txtnCosUniCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnTotUniCns
        '
        Me.txtnTotUniCns.Enabled = False
        Me.txtnTotUniCns.Location = New System.Drawing.Point(172, 175)
        Me.txtnTotUniCns.Name = "txtnTotUniCns"
        Me.txtnTotUniCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotUniCns.TabIndex = 159
        Me.txtnTotUniCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(3, 181)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(134, 13)
        Me.Label42.TabIndex = 157
        Me.Label42.Text = "Toltal unidades producidas"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.LightGray
        Me.Label43.Location = New System.Drawing.Point(3, 182)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(223, 13)
        Me.Label43.TabIndex = 158
        Me.Label43.Text = "____________________________________"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.LightGray
        Me.Label44.Location = New System.Drawing.Point(3, 208)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(223, 13)
        Me.Label44.TabIndex = 160
        Me.Label44.Text = "____________________________________"
        '
        'txtnVlrTotCnsCIF
        '
        Me.txtnVlrTotCnsCIF.Enabled = False
        Me.txtnVlrTotCnsCIF.Location = New System.Drawing.Point(172, 124)
        Me.txtnVlrTotCnsCIF.Name = "txtnVlrTotCnsCIF"
        Me.txtnVlrTotCnsCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotCnsCIF.TabIndex = 150
        Me.txtnVlrTotCnsCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotCnsMOD
        '
        Me.txtnVlrTotCnsMOD.Enabled = False
        Me.txtnVlrTotCnsMOD.Location = New System.Drawing.Point(173, 98)
        Me.txtnVlrTotCnsMOD.Name = "txtnVlrTotCnsMOD"
        Me.txtnVlrTotCnsMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotCnsMOD.TabIndex = 149
        Me.txtnVlrTotCnsMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotCnsMPD
        '
        Me.txtnVlrTotCnsMPD.Enabled = False
        Me.txtnVlrTotCnsMPD.Location = New System.Drawing.Point(173, 72)
        Me.txtnVlrTotCnsMPD.Name = "txtnVlrTotCnsMPD"
        Me.txtnVlrTotCnsMPD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotCnsMPD.TabIndex = 148
        Me.txtnVlrTotCnsMPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Cantidades"
        '
        'txtnCosTotCns
        '
        Me.txtnCosTotCns.Enabled = False
        Me.txtnCosTotCns.Location = New System.Drawing.Point(172, 149)
        Me.txtnCosTotCns.Name = "txtnCosTotCns"
        Me.txtnCosTotCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnCosTotCns.TabIndex = 146
        Me.txtnCosTotCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnTotTieCnsMOD
        '
        Me.txtnTotTieCnsMOD.Enabled = False
        Me.txtnTotTieCnsMOD.Location = New System.Drawing.Point(84, 98)
        Me.txtnTotTieCnsMOD.Name = "txtnTotTieCnsMOD"
        Me.txtnTotTieCnsMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotTieCnsMOD.TabIndex = 144
        Me.txtnTotTieCnsMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Costo Total"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "C.I.F."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 104)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "M.O.D."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 120
        Me.Label19.Text = "Materiales"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(186, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "Costos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "Consumido"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.LightGray
        Me.Label22.Location = New System.Drawing.Point(3, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(211, 13)
        Me.Label22.TabIndex = 139
        Me.Label22.Text = "__________________________________"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.LightGray
        Me.Label23.Location = New System.Drawing.Point(3, 105)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(211, 13)
        Me.Label23.TabIndex = 140
        Me.Label23.Text = "__________________________________"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.LightGray
        Me.Label24.Location = New System.Drawing.Point(3, 131)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(211, 13)
        Me.Label24.TabIndex = 141
        Me.Label24.Text = "__________________________________"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.LightGray
        Me.Label25.Location = New System.Drawing.Point(3, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(223, 13)
        Me.Label25.TabIndex = 142
        Me.Label25.Text = "____________________________________"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtnTotTasReqCIF)
        Me.Panel2.Controls.Add(Me.Label40)
        Me.Panel2.Controls.Add(Me.txtnCosUniReq)
        Me.Panel2.Controls.Add(Me.txtnTotUniReq)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.txtnVlrTotReqCIF)
        Me.Panel2.Controls.Add(Me.txtnVlrTotReqMOD)
        Me.Panel2.Controls.Add(Me.txtnVlrTotReqMPD)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtnCosTotReq)
        Me.Panel2.Controls.Add(Me.txtnTotTieReqMOD)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblTotCosReqOP)
        Me.Panel2.Controls.Add(Me.lblTotReq)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label39)
        Me.Panel2.Location = New System.Drawing.Point(6, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 235)
        Me.Panel2.TabIndex = 61
        Me.Panel2.TabStop = True
        '
        'txtnTotTasReqCIF
        '
        Me.txtnTotTasReqCIF.Enabled = False
        Me.txtnTotTasReqCIF.Location = New System.Drawing.Point(85, 124)
        Me.txtnTotTasReqCIF.Name = "txtnTotTasReqCIF"
        Me.txtnTotTasReqCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotTasReqCIF.TabIndex = 157
        Me.txtnTotTasReqCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(3, 207)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(71, 13)
        Me.Label40.TabIndex = 156
        Me.Label40.Text = "Costo unitario"
        '
        'txtnCosUniReq
        '
        Me.txtnCosUniReq.Enabled = False
        Me.txtnCosUniReq.Location = New System.Drawing.Point(172, 201)
        Me.txtnCosUniReq.Name = "txtnCosUniReq"
        Me.txtnCosUniReq.Size = New System.Drawing.Size(81, 20)
        Me.txtnCosUniReq.TabIndex = 155
        Me.txtnCosUniReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnTotUniReq
        '
        Me.txtnTotUniReq.Enabled = False
        Me.txtnTotUniReq.Location = New System.Drawing.Point(172, 175)
        Me.txtnTotUniReq.Name = "txtnTotUniReq"
        Me.txtnTotUniReq.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotUniReq.TabIndex = 153
        Me.txtnTotUniReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 181)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(129, 13)
        Me.Label37.TabIndex = 151
        Me.Label37.Text = "Toltal unidades a producir"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.LightGray
        Me.Label38.Location = New System.Drawing.Point(3, 182)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(223, 13)
        Me.Label38.TabIndex = 152
        Me.Label38.Text = "____________________________________"
        '
        'txtnVlrTotReqCIF
        '
        Me.txtnVlrTotReqCIF.Enabled = False
        Me.txtnVlrTotReqCIF.Location = New System.Drawing.Point(172, 124)
        Me.txtnVlrTotReqCIF.Name = "txtnVlrTotReqCIF"
        Me.txtnVlrTotReqCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotReqCIF.TabIndex = 150
        Me.txtnVlrTotReqCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotReqMOD
        '
        Me.txtnVlrTotReqMOD.Enabled = False
        Me.txtnVlrTotReqMOD.Location = New System.Drawing.Point(173, 98)
        Me.txtnVlrTotReqMOD.Name = "txtnVlrTotReqMOD"
        Me.txtnVlrTotReqMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotReqMOD.TabIndex = 149
        Me.txtnVlrTotReqMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotReqMPD
        '
        Me.txtnVlrTotReqMPD.Enabled = False
        Me.txtnVlrTotReqMPD.Location = New System.Drawing.Point(173, 72)
        Me.txtnVlrTotReqMPD.Name = "txtnVlrTotReqMPD"
        Me.txtnVlrTotReqMPD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotReqMPD.TabIndex = 148
        Me.txtnVlrTotReqMPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Cantidades"
        '
        'txtnCosTotReq
        '
        Me.txtnCosTotReq.Enabled = False
        Me.txtnCosTotReq.Location = New System.Drawing.Point(172, 149)
        Me.txtnCosTotReq.Name = "txtnCosTotReq"
        Me.txtnCosTotReq.Size = New System.Drawing.Size(81, 20)
        Me.txtnCosTotReq.TabIndex = 146
        Me.txtnCosTotReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnTotTieReqMOD
        '
        Me.txtnTotTieReqMOD.Enabled = False
        Me.txtnTotTieReqMOD.Location = New System.Drawing.Point(84, 98)
        Me.txtnTotTieReqMOD.Name = "txtnTotTieReqMOD"
        Me.txtnTotTieReqMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotTieReqMOD.TabIndex = 144
        Me.txtnTotTieReqMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "Costo Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "C.I.F."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "M.O.D."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Materiales"
        '
        'lblTotCosReqOP
        '
        Me.lblTotCosReqOP.AutoSize = True
        Me.lblTotCosReqOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotCosReqOP.Location = New System.Drawing.Point(186, 38)
        Me.lblTotCosReqOP.Name = "lblTotCosReqOP"
        Me.lblTotCosReqOP.Size = New System.Drawing.Size(45, 13)
        Me.lblTotCosReqOP.TabIndex = 119
        Me.lblTotCosReqOP.Text = "Costos"
        '
        'lblTotReq
        '
        Me.lblTotReq.AutoSize = True
        Me.lblTotReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotReq.Location = New System.Drawing.Point(3, 3)
        Me.lblTotReq.Name = "lblTotReq"
        Me.lblTotReq.Size = New System.Drawing.Size(65, 13)
        Me.lblTotReq.TabIndex = 118
        Me.lblTotReq.Text = "Requerido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(3, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(211, 13)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "__________________________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(3, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(211, 13)
        Me.Label12.TabIndex = 140
        Me.Label12.Text = "__________________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.LightGray
        Me.Label13.Location = New System.Drawing.Point(3, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(211, 13)
        Me.Label13.TabIndex = 141
        Me.Label13.Text = "__________________________________"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.LightGray
        Me.Label14.Location = New System.Drawing.Point(3, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(223, 13)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "____________________________________"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.LightGray
        Me.Label39.Location = New System.Drawing.Point(3, 208)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(223, 13)
        Me.Label39.TabIndex = 154
        Me.Label39.Text = "____________________________________"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage5.Controls.Add(Me.dgv5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(809, 259)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Análisis"
        '
        'dgv5
        '
        Me.dgv5.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv5.GridColor = System.Drawing.Color.GhostWhite
        Me.dgv5.Location = New System.Drawing.Point(3, 3)
        Me.dgv5.Name = "dgv5"
        Me.dgv5.Size = New System.Drawing.Size(803, 253)
        Me.dgv5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage6.Controls.Add(Me.Panel4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(809, 259)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Margen"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtnTotVta)
        Me.Panel4.Controls.Add(Me.Label66)
        Me.Panel4.Controls.Add(Me.txtnItoTotCns)
        Me.Panel4.Controls.Add(Me.txtnUtiTot)
        Me.Panel4.Controls.Add(Me.txtnGtoTotCns)
        Me.Panel4.Controls.Add(Me.txtnCosTotCns1)
        Me.Panel4.Controls.Add(Me.txtnVlrUniCnsCIF)
        Me.Panel4.Controls.Add(Me.txtnVlrUniCnsMOD)
        Me.Panel4.Controls.Add(Me.txtnVlrUniCnsMPD)
        Me.Panel4.Controls.Add(Me.Label68)
        Me.Panel4.Controls.Add(Me.Label61)
        Me.Panel4.Controls.Add(Me.txtnCanUniEdp1)
        Me.Panel4.Controls.Add(Me.txtnPreVta)
        Me.Panel4.Controls.Add(Me.Label60)
        Me.Panel4.Controls.Add(Me.Label59)
        Me.Panel4.Controls.Add(Me.txtnUtiUni)
        Me.Panel4.Controls.Add(Me.txtnVlrTotCnsCIF1)
        Me.Panel4.Controls.Add(Me.Label57)
        Me.Panel4.Controls.Add(Me.txtnGtoUniCns)
        Me.Panel4.Controls.Add(Me.txtnCosUniCns1)
        Me.Panel4.Controls.Add(Me.Label58)
        Me.Panel4.Controls.Add(Me.txtnPorGto)
        Me.Panel4.Controls.Add(Me.txtnVlrTotCnsMOD1)
        Me.Panel4.Controls.Add(Me.txtnPorIto)
        Me.Panel4.Controls.Add(Me.txtnItoUniCns)
        Me.Panel4.Controls.Add(Me.txtnVlrTotCnsMPD1)
        Me.Panel4.Controls.Add(Me.Label62)
        Me.Panel4.Controls.Add(Me.Label63)
        Me.Panel4.Controls.Add(Me.Label64)
        Me.Panel4.Controls.Add(Me.Label65)
        Me.Panel4.Controls.Add(Me.Label67)
        Me.Panel4.Location = New System.Drawing.Point(6, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(797, 247)
        Me.Panel4.TabIndex = 15164
        '
        'txtnTotVta
        '
        Me.txtnTotVta.Enabled = False
        Me.txtnTotVta.Location = New System.Drawing.Point(669, 23)
        Me.txtnTotVta.Name = "txtnTotVta"
        Me.txtnTotVta.Size = New System.Drawing.Size(81, 20)
        Me.txtnTotVta.TabIndex = 181
        Me.txtnTotVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(578, 26)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(68, 13)
        Me.Label66.TabIndex = 180
        Me.Label66.Text = "Total Venta :"
        '
        'txtnItoTotCns
        '
        Me.txtnItoTotCns.Enabled = False
        Me.txtnItoTotCns.Location = New System.Drawing.Point(581, 184)
        Me.txtnItoTotCns.Name = "txtnItoTotCns"
        Me.txtnItoTotCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnItoTotCns.TabIndex = 179
        Me.txtnItoTotCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnUtiTot
        '
        Me.txtnUtiTot.Enabled = False
        Me.txtnUtiTot.Location = New System.Drawing.Point(671, 184)
        Me.txtnUtiTot.Name = "txtnUtiTot"
        Me.txtnUtiTot.Size = New System.Drawing.Size(81, 20)
        Me.txtnUtiTot.TabIndex = 178
        Me.txtnUtiTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnGtoTotCns
        '
        Me.txtnGtoTotCns.Enabled = False
        Me.txtnGtoTotCns.Location = New System.Drawing.Point(491, 184)
        Me.txtnGtoTotCns.Name = "txtnGtoTotCns"
        Me.txtnGtoTotCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnGtoTotCns.TabIndex = 177
        Me.txtnGtoTotCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnCosTotCns1
        '
        Me.txtnCosTotCns1.Enabled = False
        Me.txtnCosTotCns1.Location = New System.Drawing.Point(400, 184)
        Me.txtnCosTotCns1.Name = "txtnCosTotCns1"
        Me.txtnCosTotCns1.Size = New System.Drawing.Size(81, 20)
        Me.txtnCosTotCns1.TabIndex = 176
        Me.txtnCosTotCns1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrUniCnsCIF
        '
        Me.txtnVlrUniCnsCIF.Enabled = False
        Me.txtnVlrUniCnsCIF.Location = New System.Drawing.Point(310, 146)
        Me.txtnVlrUniCnsCIF.Name = "txtnVlrUniCnsCIF"
        Me.txtnVlrUniCnsCIF.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrUniCnsCIF.TabIndex = 175
        Me.txtnVlrUniCnsCIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrUniCnsMOD
        '
        Me.txtnVlrUniCnsMOD.Enabled = False
        Me.txtnVlrUniCnsMOD.Location = New System.Drawing.Point(219, 146)
        Me.txtnVlrUniCnsMOD.Name = "txtnVlrUniCnsMOD"
        Me.txtnVlrUniCnsMOD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrUniCnsMOD.TabIndex = 174
        Me.txtnVlrUniCnsMOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrUniCnsMPD
        '
        Me.txtnVlrUniCnsMPD.Enabled = False
        Me.txtnVlrUniCnsMPD.Location = New System.Drawing.Point(129, 146)
        Me.txtnVlrUniCnsMPD.Name = "txtnVlrUniCnsMPD"
        Me.txtnVlrUniCnsMPD.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrUniCnsMPD.TabIndex = 173
        Me.txtnVlrUniCnsMPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(38, 184)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(55, 13)
        Me.Label68.TabIndex = 172
        Me.Label68.Text = "Vlr Total"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(38, 26)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(114, 13)
        Me.Label61.TabIndex = 169
        Me.Label61.Text = "Unidades Producidas :"
        '
        'txtnCanUniEdp1
        '
        Me.txtnCanUniEdp1.Enabled = False
        Me.txtnCanUniEdp1.Location = New System.Drawing.Point(169, 23)
        Me.txtnCanUniEdp1.Name = "txtnCanUniEdp1"
        Me.txtnCanUniEdp1.Size = New System.Drawing.Size(81, 20)
        Me.txtnCanUniEdp1.TabIndex = 168
        Me.txtnCanUniEdp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnPreVta
        '
        Me.txtnPreVta.Enabled = False
        Me.txtnPreVta.Location = New System.Drawing.Point(425, 23)
        Me.txtnPreVta.Name = "txtnPreVta"
        Me.txtnPreVta.Size = New System.Drawing.Size(81, 20)
        Me.txtnPreVta.TabIndex = 167
        Me.txtnPreVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(710, 72)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(42, 13)
        Me.Label60.TabIndex = 166
        Me.Label60.Text = "Utilidad"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(607, 72)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(55, 13)
        Me.Label59.TabIndex = 165
        Me.Label59.Text = "Impuestos"
        '
        'txtnUtiUni
        '
        Me.txtnUtiUni.Enabled = False
        Me.txtnUtiUni.Location = New System.Drawing.Point(671, 146)
        Me.txtnUtiUni.Name = "txtnUtiUni"
        Me.txtnUtiUni.Size = New System.Drawing.Size(81, 20)
        Me.txtnUtiUni.TabIndex = 163
        Me.txtnUtiUni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotCnsCIF1
        '
        Me.txtnVlrTotCnsCIF1.Enabled = False
        Me.txtnVlrTotCnsCIF1.Location = New System.Drawing.Point(309, 184)
        Me.txtnVlrTotCnsCIF1.Name = "txtnVlrTotCnsCIF1"
        Me.txtnVlrTotCnsCIF1.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotCnsCIF1.TabIndex = 158
        Me.txtnVlrTotCnsCIF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(411, 72)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(71, 13)
        Me.Label57.TabIndex = 162
        Me.Label57.Text = "Costo unitario"
        '
        'txtnGtoUniCns
        '
        Me.txtnGtoUniCns.Enabled = False
        Me.txtnGtoUniCns.Location = New System.Drawing.Point(490, 146)
        Me.txtnGtoUniCns.Name = "txtnGtoUniCns"
        Me.txtnGtoUniCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnGtoUniCns.TabIndex = 161
        Me.txtnGtoUniCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnCosUniCns1
        '
        Me.txtnCosUniCns1.Enabled = False
        Me.txtnCosUniCns1.Location = New System.Drawing.Point(400, 146)
        Me.txtnCosUniCns1.Name = "txtnCosUniCns1"
        Me.txtnCosUniCns1.Size = New System.Drawing.Size(81, 20)
        Me.txtnCosUniCns1.TabIndex = 159
        Me.txtnCosUniCns1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(325, 26)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(74, 13)
        Me.Label58.TabIndex = 157
        Me.Label58.Text = "Precio Venta :"
        '
        'txtnPorGto
        '
        Me.txtnPorGto.Enabled = False
        Me.txtnPorGto.Location = New System.Drawing.Point(491, 108)
        Me.txtnPorGto.Name = "txtnPorGto"
        Me.txtnPorGto.Size = New System.Drawing.Size(81, 20)
        Me.txtnPorGto.TabIndex = 150
        Me.txtnPorGto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotCnsMOD1
        '
        Me.txtnVlrTotCnsMOD1.Enabled = False
        Me.txtnVlrTotCnsMOD1.Location = New System.Drawing.Point(219, 184)
        Me.txtnVlrTotCnsMOD1.Name = "txtnVlrTotCnsMOD1"
        Me.txtnVlrTotCnsMOD1.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotCnsMOD1.TabIndex = 149
        Me.txtnVlrTotCnsMOD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnPorIto
        '
        Me.txtnPorIto.Enabled = False
        Me.txtnPorIto.Location = New System.Drawing.Point(581, 108)
        Me.txtnPorIto.Name = "txtnPorIto"
        Me.txtnPorIto.Size = New System.Drawing.Size(81, 20)
        Me.txtnPorIto.TabIndex = 148
        Me.txtnPorIto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnItoUniCns
        '
        Me.txtnItoUniCns.Enabled = False
        Me.txtnItoUniCns.Location = New System.Drawing.Point(581, 146)
        Me.txtnItoUniCns.Name = "txtnItoUniCns"
        Me.txtnItoUniCns.Size = New System.Drawing.Size(81, 20)
        Me.txtnItoUniCns.TabIndex = 146
        Me.txtnItoUniCns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnVlrTotCnsMPD1
        '
        Me.txtnVlrTotCnsMPD1.Enabled = False
        Me.txtnVlrTotCnsMPD1.Location = New System.Drawing.Point(129, 184)
        Me.txtnVlrTotCnsMPD1.Name = "txtnVlrTotCnsMPD1"
        Me.txtnVlrTotCnsMPD1.Size = New System.Drawing.Size(81, 20)
        Me.txtnVlrTotCnsMPD1.TabIndex = 144
        Me.txtnVlrTotCnsMPD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(532, 72)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(40, 13)
        Me.Label62.TabIndex = 123
        Me.Label62.Text = "Gastos"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(361, 72)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(32, 13)
        Me.Label63.TabIndex = 122
        Me.Label63.Text = "C.I.F."
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(261, 72)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(41, 13)
        Me.Label64.TabIndex = 121
        Me.Label64.Text = "M.O.D."
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(158, 72)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(55, 13)
        Me.Label65.TabIndex = 120
        Me.Label65.Text = "Materiales"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(36, 146)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(70, 13)
        Me.Label67.TabIndex = 118
        Me.Label67.Text = "Vlr Unitario"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCancelar.Location = New System.Drawing.Point(84, 476)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 22)
        Me.cmdCancelar.TabIndex = 109
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscar.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdBuscar.Location = New System.Drawing.Point(3, 475)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 22)
        Me.cmdBuscar.TabIndex = 103
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtnCanUniEdp
        '
        Me.txtnCanUniEdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnCanUniEdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnCanUniEdp.Enabled = False
        Me.txtnCanUniEdp.Location = New System.Drawing.Point(431, 162)
        Me.txtnCanUniEdp.MaxLength = 15
        Me.txtnCanUniEdp.Name = "txtnCanUniEdp"
        Me.txtnCanUniEdp.Size = New System.Drawing.Size(100, 20)
        Me.txtnCanUniEdp.TabIndex = 43
        Me.txtnCanUniEdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCanUniEdp
        '
        Me.lblCanUniEdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCanUniEdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCanUniEdp.Location = New System.Drawing.Point(290, 168)
        Me.lblCanUniEdp.Name = "lblCanUniEdp"
        Me.lblCanUniEdp.Size = New System.Drawing.Size(115, 13)
        Me.lblCanUniEdp.TabIndex = 192
        Me.lblCanUniEdp.Text = "Unidades producidas"
        '
        'cmdLstATALM
        '
        Me.cmdLstATALM.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstATALM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdLstATALM.Location = New System.Drawing.Point(237, 164)
        Me.cmdLstATALM.Name = "cmdLstATALM"
        Me.cmdLstATALM.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstATALM.TabIndex = 23
        Me.cmdLstATALM.Text = "Lst"
        Me.cmdLstATALM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLstATALM.UseVisualStyleBackColor = False
        '
        'txtsCodAlm
        '
        Me.txtsCodAlm.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCodAlm.Location = New System.Drawing.Point(133, 161)
        Me.txtsCodAlm.MaxLength = 15
        Me.txtsCodAlm.Name = "txtsCodAlm"
        Me.txtsCodAlm.Size = New System.Drawing.Size(100, 20)
        Me.txtsCodAlm.TabIndex = 21
        '
        'lblCodAlm
        '
        Me.lblCodAlm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCodAlm.Location = New System.Drawing.Point(3, 167)
        Me.lblCodAlm.Name = "lblCodAlm"
        Me.lblCodAlm.Size = New System.Drawing.Size(114, 13)
        Me.lblCodAlm.TabIndex = 190
        Me.lblCodAlm.Text = "Almacén de producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(3, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 13)
        Me.Label5.TabIndex = 191
        Me.Label5.Text = "___________________________"
        '
        'lblFecFin
        '
        Me.lblFecFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecFin.Location = New System.Drawing.Point(582, 56)
        Me.lblFecFin.Name = "lblFecFin"
        Me.lblFecFin.Size = New System.Drawing.Size(139, 13)
        Me.lblFecFin.TabIndex = 187
        Me.lblFecFin.Text = "Fecha de finalización"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(718, 26)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecIni.TabIndex = 177
        Me.dtpFecIni.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'dtpFecEmi
        '
        Me.dtpFecEmi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecEmi.CustomFormat = "yyyy.mm.dd"
        Me.dtpFecEmi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmi.Location = New System.Drawing.Point(718, 4)
        Me.dtpFecEmi.Name = "dtpFecEmi"
        Me.dtpFecEmi.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecEmi.TabIndex = 176
        Me.dtpFecEmi.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'lblFecIni
        '
        Me.lblFecIni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecIni.Location = New System.Drawing.Point(582, 31)
        Me.lblFecIni.Name = "lblFecIni"
        Me.lblFecIni.Size = New System.Drawing.Size(139, 13)
        Me.lblFecIni.TabIndex = 186
        Me.lblFecIni.Text = "Fecha de fabricación"
        '
        'lblLin03
        '
        Me.lblLin03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin03.AutoSize = True
        Me.lblLin03.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin03.Location = New System.Drawing.Point(580, 33)
        Me.lblLin03.Name = "lblLin03"
        Me.lblLin03.Size = New System.Drawing.Size(169, 13)
        Me.lblLin03.TabIndex = 185
        Me.lblLin03.Text = "___________________________"
        '
        'lblFecEmi
        '
        Me.lblFecEmi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecEmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblFecEmi.Location = New System.Drawing.Point(582, 8)
        Me.lblFecEmi.Name = "lblFecEmi"
        Me.lblFecEmi.Size = New System.Drawing.Size(139, 13)
        Me.lblFecEmi.TabIndex = 184
        Me.lblFecEmi.Text = "Fecha de emisión"
        '
        'lblLin02
        '
        Me.lblLin02.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLin02.AutoSize = True
        Me.lblLin02.ForeColor = System.Drawing.Color.LightGray
        Me.lblLin02.Location = New System.Drawing.Point(580, 10)
        Me.lblLin02.Name = "lblLin02"
        Me.lblLin02.Size = New System.Drawing.Size(169, 13)
        Me.lblLin02.TabIndex = 183
        Me.lblLin02.Text = "___________________________"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(579, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "___________________________"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(718, 50)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecFin.TabIndex = 189
        Me.dtpFecFin.Value = New Date(2012, 5, 13, 0, 0, 0, 0)
        '
        'Label49
        '
        Me.Label49.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.LightGray
        Me.Label49.Location = New System.Drawing.Point(291, 169)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(169, 13)
        Me.Label49.TabIndex = 193
        Me.Label49.Text = "___________________________"
        '
        'cboAPLND1
        '
        Me.cboAPLND1.FormattingEnabled = True
        Me.cboAPLND1.Location = New System.Drawing.Point(133, 26)
        Me.cboAPLND1.Name = "cboAPLND1"
        Me.cboAPLND1.Size = New System.Drawing.Size(100, 21)
        Me.cboAPLND1.TabIndex = 5
        '
        'lblNroLot
        '
        Me.lblNroLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblNroLot.Location = New System.Drawing.Point(3, 55)
        Me.lblNroLot.Name = "lblNroLot"
        Me.lblNroLot.Size = New System.Drawing.Size(114, 13)
        Me.lblNroLot.TabIndex = 194
        Me.lblNroLot.Text = "Lote número"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.LightGray
        Me.Label50.Location = New System.Drawing.Point(3, 56)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(169, 13)
        Me.Label50.TabIndex = 195
        Me.Label50.Text = "___________________________"
        '
        'txtsNroLot
        '
        Me.txtsNroLot.BackColor = System.Drawing.SystemColors.Window
        Me.txtsNroLot.Location = New System.Drawing.Point(133, 49)
        Me.txtsNroLot.MaxLength = 10
        Me.txtsNroLot.Name = "txtsNroLot"
        Me.txtsNroLot.Size = New System.Drawing.Size(100, 20)
        Me.txtsNroLot.TabIndex = 9
        Me.txtsNroLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCanUniOdp
        '
        Me.lblCanUniOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCanUniOdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCanUniOdp.Location = New System.Drawing.Point(291, 145)
        Me.lblCanUniOdp.Name = "lblCanUniOdp"
        Me.lblCanUniOdp.Size = New System.Drawing.Size(114, 13)
        Me.lblCanUniOdp.TabIndex = 196
        Me.lblCanUniOdp.Text = "Unidades a producir"
        '
        'txtnCanUniOdp
        '
        Me.txtnCanUniOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnCanUniOdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnCanUniOdp.Enabled = False
        Me.txtnCanUniOdp.Location = New System.Drawing.Point(431, 139)
        Me.txtnCanUniOdp.MaxLength = 15
        Me.txtnCanUniOdp.Name = "txtnCanUniOdp"
        Me.txtnCanUniOdp.Size = New System.Drawing.Size(100, 20)
        Me.txtnCanUniOdp.TabIndex = 39
        Me.txtnCanUniOdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label51
        '
        Me.Label51.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.LightGray
        Me.Label51.Location = New System.Drawing.Point(293, 146)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(169, 13)
        Me.Label51.TabIndex = 198
        Me.Label51.Text = "___________________________"
        '
        'lblCanUniStn
        '
        Me.lblCanUniStn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCanUniStn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblCanUniStn.Location = New System.Drawing.Point(290, 122)
        Me.lblCanUniStn.Name = "lblCanUniStn"
        Me.lblCanUniStn.Size = New System.Drawing.Size(126, 14)
        Me.lblCanUniStn.TabIndex = 199
        Me.lblCanUniStn.Text = "Unidades lote estándar"
        '
        'txtnCanUniStn
        '
        Me.txtnCanUniStn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnCanUniStn.BackColor = System.Drawing.SystemColors.Window
        Me.txtnCanUniStn.Enabled = False
        Me.txtnCanUniStn.Location = New System.Drawing.Point(431, 117)
        Me.txtnCanUniStn.MaxLength = 15
        Me.txtnCanUniStn.Name = "txtnCanUniStn"
        Me.txtnCanUniStn.Size = New System.Drawing.Size(100, 20)
        Me.txtnCanUniStn.TabIndex = 35
        Me.txtnCanUniStn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label52
        '
        Me.Label52.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.LightGray
        Me.Label52.Location = New System.Drawing.Point(291, 124)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(169, 13)
        Me.Label52.TabIndex = 201
        Me.Label52.Text = "___________________________"
        '
        'lblTiexUni
        '
        Me.lblTiexUni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiexUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblTiexUni.Location = New System.Drawing.Point(580, 122)
        Me.lblTiexUni.Name = "lblTiexUni"
        Me.lblTiexUni.Size = New System.Drawing.Size(137, 14)
        Me.lblTiexUni.TabIndex = 202
        Me.lblTiexUni.Text = "Tiempo x unidad (min)"
        '
        'Label54
        '
        Me.Label54.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.LightGray
        Me.Label54.Location = New System.Drawing.Point(595, 124)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(169, 13)
        Me.Label54.TabIndex = 203
        Me.Label54.Text = "___________________________"
        '
        'txtnTieItm
        '
        Me.txtnTieItm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTieItm.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTieItm.Enabled = False
        Me.txtnTieItm.Location = New System.Drawing.Point(718, 117)
        Me.txtnTieItm.MaxLength = 15
        Me.txtnTieItm.Name = "txtnTieItm"
        Me.txtnTieItm.Size = New System.Drawing.Size(100, 20)
        Me.txtnTieItm.TabIndex = 47
        Me.txtnTieItm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotTieOdp
        '
        Me.lblTotTieOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotTieOdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblTotTieOdp.Location = New System.Drawing.Point(580, 144)
        Me.lblTotTieOdp.Name = "lblTotTieOdp"
        Me.lblTotTieOdp.Size = New System.Drawing.Size(137, 14)
        Me.lblTotTieOdp.TabIndex = 205
        Me.lblTotTieOdp.Text = "Tot. tie. unid. a prod. (hor)"
        '
        'Label55
        '
        Me.Label55.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.LightGray
        Me.Label55.Location = New System.Drawing.Point(595, 146)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(169, 13)
        Me.Label55.TabIndex = 206
        Me.Label55.Text = "___________________________"
        '
        'txtnTotTieOdp
        '
        Me.txtnTotTieOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTotTieOdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTotTieOdp.Enabled = False
        Me.txtnTotTieOdp.Location = New System.Drawing.Point(718, 139)
        Me.txtnTotTieOdp.MaxLength = 15
        Me.txtnTotTieOdp.Name = "txtnTotTieOdp"
        Me.txtnTotTieOdp.Size = New System.Drawing.Size(100, 20)
        Me.txtnTotTieOdp.TabIndex = 49
        Me.txtnTotTieOdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnTotTieEdp
        '
        Me.txtnTotTieEdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnTotTieEdp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnTotTieEdp.Enabled = False
        Me.txtnTotTieEdp.Location = New System.Drawing.Point(718, 161)
        Me.txtnTotTieEdp.MaxLength = 15
        Me.txtnTotTieEdp.Name = "txtnTotTieEdp"
        Me.txtnTotTieEdp.Size = New System.Drawing.Size(100, 20)
        Me.txtnTotTieEdp.TabIndex = 51
        Me.txtnTotTieEdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotTieEdp
        '
        Me.lblTotTieEdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotTieEdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblTotTieEdp.Location = New System.Drawing.Point(580, 165)
        Me.lblTotTieEdp.Name = "lblTotTieEdp"
        Me.lblTotTieEdp.Size = New System.Drawing.Size(137, 14)
        Me.lblTotTieEdp.TabIndex = 209
        Me.lblTotTieEdp.Text = "Tot. tie. unid. prod. (hor)"
        '
        'Label53
        '
        Me.Label53.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.LightGray
        Me.Label53.Location = New System.Drawing.Point(580, 167)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(169, 13)
        Me.Label53.TabIndex = 210
        Me.Label53.Text = "___________________________"
        '
        'txtsUniMedInv
        '
        Me.txtsUniMedInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsUniMedInv.BackColor = System.Drawing.SystemColors.Window
        Me.txtsUniMedInv.Enabled = False
        Me.txtsUniMedInv.Location = New System.Drawing.Point(539, 118)
        Me.txtsUniMedInv.MaxLength = 15
        Me.txtsUniMedInv.Name = "txtsUniMedInv"
        Me.txtsUniMedInv.Size = New System.Drawing.Size(27, 20)
        Me.txtsUniMedInv.TabIndex = 37
        Me.txtsUniMedInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsUniMedInv1
        '
        Me.txtsUniMedInv1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsUniMedInv1.BackColor = System.Drawing.SystemColors.Window
        Me.txtsUniMedInv1.Enabled = False
        Me.txtsUniMedInv1.Location = New System.Drawing.Point(539, 141)
        Me.txtsUniMedInv1.MaxLength = 15
        Me.txtsUniMedInv1.Name = "txtsUniMedInv1"
        Me.txtsUniMedInv1.Size = New System.Drawing.Size(27, 20)
        Me.txtsUniMedInv1.TabIndex = 41
        Me.txtsUniMedInv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsUniMedInv2
        '
        Me.txtsUniMedInv2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsUniMedInv2.BackColor = System.Drawing.SystemColors.Window
        Me.txtsUniMedInv2.Enabled = False
        Me.txtsUniMedInv2.Location = New System.Drawing.Point(539, 164)
        Me.txtsUniMedInv2.MaxLength = 15
        Me.txtsUniMedInv2.Name = "txtsUniMedInv2"
        Me.txtsUniMedInv2.Size = New System.Drawing.Size(27, 20)
        Me.txtsUniMedInv2.TabIndex = 45
        Me.txtsUniMedInv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdLstPEODP
        '
        Me.cmdLstPEODP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdLstPEODP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdLstPEODP.Location = New System.Drawing.Point(237, 4)
        Me.cmdLstPEODP.Name = "cmdLstPEODP"
        Me.cmdLstPEODP.Size = New System.Drawing.Size(34, 16)
        Me.cmdLstPEODP.TabIndex = 3
        Me.cmdLstPEODP.Text = "Lst"
        Me.cmdLstPEODP.UseVisualStyleBackColor = False
        '
        'cmdCpa
        '
        Me.cmdCpa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCpa.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdCpa.Location = New System.Drawing.Point(730, 477)
        Me.cmdCpa.Name = "cmdCpa"
        Me.cmdCpa.Size = New System.Drawing.Size(86, 21)
        Me.cmdCpa.TabIndex = 264
        Me.cmdCpa.Text = "Copiar a"
        Me.cmdCpa.UseVisualStyleBackColor = False
        '
        'txtsCmn
        '
        Me.txtsCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsCmn.BackColor = System.Drawing.SystemColors.Window
        Me.txtsCmn.Location = New System.Drawing.Point(430, 72)
        Me.txtsCmn.MaxLength = 100
        Me.txtsCmn.Name = "txtsCmn"
        Me.txtsCmn.Size = New System.Drawing.Size(387, 20)
        Me.txtsCmn.TabIndex = 31
        '
        'lblsCmn
        '
        Me.lblsCmn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsCmn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblsCmn.Location = New System.Drawing.Point(290, 78)
        Me.lblsCmn.Name = "lblsCmn"
        Me.lblsCmn.Size = New System.Drawing.Size(115, 13)
        Me.lblsCmn.TabIndex = 266
        Me.lblsCmn.Text = "Productos"
        '
        'Label56
        '
        Me.Label56.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.LightGray
        Me.Label56.Location = New System.Drawing.Point(290, 79)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(169, 13)
        Me.Label56.TabIndex = 267
        Me.Label56.Text = "___________________________"
        '
        'cmdRecODP
        '
        Me.cmdRecODP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRecODP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdRecODP.Location = New System.Drawing.Point(401, 477)
        Me.cmdRecODP.Name = "cmdRecODP"
        Me.cmdRecODP.Size = New System.Drawing.Size(86, 21)
        Me.cmdRecODP.TabIndex = 268
        Me.cmdRecODP.Text = "Recalc. OP"
        Me.cmdRecODP.UseVisualStyleBackColor = False
        '
        'cmdRecEDP
        '
        Me.cmdRecEDP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRecEDP.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdRecEDP.Location = New System.Drawing.Point(503, 477)
        Me.cmdRecEDP.Name = "cmdRecEDP"
        Me.cmdRecEDP.Size = New System.Drawing.Size(86, 21)
        Me.cmdRecEDP.TabIndex = 269
        Me.cmdRecEDP.Text = "Recalc. EDP"
        Me.cmdRecEDP.UseVisualStyleBackColor = False
        '
        'cmdRecInv
        '
        Me.cmdRecInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRecInv.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdRecInv.Location = New System.Drawing.Point(601, 477)
        Me.cmdRecInv.Name = "cmdRecInv"
        Me.cmdRecInv.Size = New System.Drawing.Size(86, 21)
        Me.cmdRecInv.TabIndex = 270
        Me.cmdRecInv.Text = "Recalc. Inv."
        Me.cmdRecInv.UseVisualStyleBackColor = False
        '
        'cmdImpFal
        '
        Me.cmdImpFal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImpFal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdImpFal.Location = New System.Drawing.Point(298, 477)
        Me.cmdImpFal.Name = "cmdImpFal"
        Me.cmdImpFal.Size = New System.Drawing.Size(86, 21)
        Me.cmdImpFal.TabIndex = 271
        Me.cmdImpFal.Text = "Imp faltantes"
        Me.cmdImpFal.UseVisualStyleBackColor = False
        '
        'frmPEODP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(824, 502)
        Me.Controls.Add(Me.cmdImpFal)
        Me.Controls.Add(Me.cmdRecInv)
        Me.Controls.Add(Me.cmdRecEDP)
        Me.Controls.Add(Me.cmdRecODP)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.lblsCmn)
        Me.Controls.Add(Me.txtsCmn)
        Me.Controls.Add(Me.cmdCpa)
        Me.Controls.Add(Me.cmdLstPEODP)
        Me.Controls.Add(Me.txtsUniMedInv2)
        Me.Controls.Add(Me.txtsUniMedInv1)
        Me.Controls.Add(Me.txtsUniMedInv)
        Me.Controls.Add(Me.lblTotTieEdp)
        Me.Controls.Add(Me.txtnTotTieEdp)
        Me.Controls.Add(Me.txtnTotTieOdp)
        Me.Controls.Add(Me.lblTotTieOdp)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.txtnTieItm)
        Me.Controls.Add(Me.lblTiexUni)
        Me.Controls.Add(Me.txtnCanUniStn)
        Me.Controls.Add(Me.lblCanUniStn)
        Me.Controls.Add(Me.txtnCanUniOdp)
        Me.Controls.Add(Me.lblCanUniOdp)
        Me.Controls.Add(Me.txtsNroLot)
        Me.Controls.Add(Me.lblNroLot)
        Me.Controls.Add(Me.cboAPLND1)
        Me.Controls.Add(Me.txtnCanUniEdp)
        Me.Controls.Add(Me.lblCanUniEdp)
        Me.Controls.Add(Me.cmdLstATALM)
        Me.Controls.Add(Me.txtsCodAlm)
        Me.Controls.Add(Me.lblCodAlm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFecFin)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.dtpFecEmi)
        Me.Controls.Add(Me.lblFecIni)
        Me.Controls.Add(Me.lblLin03)
        Me.Controls.Add(Me.lblFecEmi)
        Me.Controls.Add(Me.lblLin02)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cboACUNI)
        Me.Controls.Add(Me.lblUniMedPro)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.mtbsCodItm)
        Me.Controls.Add(Me.cmdLstPELIM)
        Me.Controls.Add(Me.cboABEOP)
        Me.Controls.Add(Me.txtnCanOdp)
        Me.Controls.Add(Me.txtsNomItm)
        Me.Controls.Add(Me.txtnNroDoc)
        Me.Controls.Add(Me.cboABODP)
        Me.Controls.Add(Me.lblCanOdp)
        Me.Controls.Add(Me.lblNomItm)
        Me.Controls.Add(Me.lblLin04)
        Me.Controls.Add(Me.lblEstOdp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLin06)
        Me.Controls.Add(Me.lblCodItm)
        Me.Controls.Add(Me.lblLin05)
        Me.Controls.Add(Me.lblCodDoc)
        Me.Controls.Add(Me.lblLin01)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label56)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPEODP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de producción"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cboACUNI As System.Windows.Forms.ComboBox
    Friend WithEvents lblUniMedPro As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mtbsCodItm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdLstPELIM As System.Windows.Forms.Button
    Friend WithEvents cboABEOP As System.Windows.Forms.ComboBox
    Friend WithEvents txtnCanOdp As System.Windows.Forms.TextBox
    Friend WithEvents txtsNomItm As System.Windows.Forms.TextBox
    Friend WithEvents txtnNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboABODP As System.Windows.Forms.ComboBox
    Friend WithEvents lblCanOdp As System.Windows.Forms.Label
    Friend WithEvents lblNomItm As System.Windows.Forms.Label
    Friend WithEvents lblLin04 As System.Windows.Forms.Label
    Friend WithEvents lblEstOdp As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNroDoc As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLin06 As System.Windows.Forms.Label
    Friend WithEvents lblCodItm As System.Windows.Forms.Label
    Friend WithEvents lblLin05 As System.Windows.Forms.Label
    Friend WithEvents lblCodDoc As System.Windows.Forms.Label
    Friend WithEvents lblLin01 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtnVrcCosUni As System.Windows.Forms.TextBox
    Friend WithEvents txtnVrcUni As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtnVrcTotCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtnVrcTotMOD As System.Windows.Forms.TextBox
    Friend WithEvents txtnVrcTotMPD As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtnVrcCosTot As System.Windows.Forms.TextBox
    Friend WithEvents txtnVrcTieMOD As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtnCosUniCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotUniCns As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtnVlrTotCnsCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrTotCnsMOD As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrTotCnsMPD As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnCosTotCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotTieCnsMOD As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtnCosUniReq As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotUniReq As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtnVlrTotReqCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrTotReqMOD As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrTotReqMPD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnCosTotReq As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotTieReqMOD As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotCosReqOP As System.Windows.Forms.Label
    Friend WithEvents lblTotReq As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtnCanUniEdp As System.Windows.Forms.TextBox
    Friend WithEvents lblCanUniEdp As System.Windows.Forms.Label
    Friend WithEvents cmdLstATALM As System.Windows.Forms.Button
    Friend WithEvents txtsCodAlm As System.Windows.Forms.TextBox
    Friend WithEvents lblCodAlm As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFecFin As System.Windows.Forms.Label
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecEmi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecIni As System.Windows.Forms.Label
    Friend WithEvents lblLin03 As System.Windows.Forms.Label
    Friend WithEvents lblFecEmi As System.Windows.Forms.Label
    Friend WithEvents lblLin02 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cboAPLND1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblNroLot As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtsNroLot As System.Windows.Forms.TextBox
    Friend WithEvents lblCanUniOdp As System.Windows.Forms.Label
    Friend WithEvents txtnCanUniOdp As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lblCanUniStn As System.Windows.Forms.Label
    Friend WithEvents txtnCanUniStn As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblTiexUni As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtnTieItm As System.Windows.Forms.TextBox
    Friend WithEvents lblTotTieOdp As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtnTotTieOdp As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotTieEdp As System.Windows.Forms.TextBox
    Friend WithEvents lblTotTieEdp As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtnTotTasReqCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtsUniMedInv As System.Windows.Forms.TextBox
    Friend WithEvents txtsUniMedInv1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgv5 As System.Windows.Forms.DataGridView
    Friend WithEvents txtnVrcTasCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtnTotTasCnsCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtsUniMedInv2 As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents cmdLstPEODP As System.Windows.Forms.Button
    Friend WithEvents lstCpA As System.Windows.Forms.ListBox
    Friend WithEvents cmdCpa As System.Windows.Forms.Button
    Friend WithEvents txtsCmn As System.Windows.Forms.TextBox
    Friend WithEvents lblsCmn As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtnVlrTotCnsCIF1 As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtnGtoUniCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnCosUniCns1 As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtnPorGto As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrTotCnsMOD1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnPorIto As System.Windows.Forms.TextBox
    Friend WithEvents txtnItoUniCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrTotCnsMPD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtnUtiUni As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtnPreVta As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtnCanUniEdp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtnGtoTotCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnCosTotCns1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrUniCnsCIF As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrUniCnsMOD As System.Windows.Forms.TextBox
    Friend WithEvents txtnVlrUniCnsMPD As System.Windows.Forms.TextBox
    Friend WithEvents txtnItoTotCns As System.Windows.Forms.TextBox
    Friend WithEvents txtnUtiTot As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtnTotVta As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents cmdRecODP As System.Windows.Forms.Button
    Friend WithEvents cmdRecEDP As System.Windows.Forms.Button
    Friend WithEvents cmdRecInv As System.Windows.Forms.Button
    Friend WithEvents cmdImpFal As System.Windows.Forms.Button
End Class
