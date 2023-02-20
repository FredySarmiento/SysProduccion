Public Class frmPEROD
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-10
#End Region
#Region "001 Inicia. wp - vp Definición del variables públicas"
    Public Property wg_aePEODP As Array
    Public Property wg_aePLODP2 As Array
    Public Property wg_aeTEDMT As Array
    Public Property wg_sFrmOri As String
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"
    ' vl numéricas
    Dim vl_nNroSig As Double
    Dim wl_bCmpVdo As Boolean
    ' wl Booleanas
    Dim wl_bEdit As Boolean
    Dim wl_bEOF As Boolean
    Dim wl_bSwsBor As Boolean
    Dim wl_bSwsCbo As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bVdoCom As Boolean
    Dim wl_bVdoVta As Boolean
    Dim wl_bYesNo As Boolean
    Dim wl_bAbrirReg As Boolean
    Dim wl_bCerrarReg As Boolean
    Dim wl_bRegNue As Boolean
    Dim wl_bOpcOk As Boolean
    Dim wl_bOpeAbi As Boolean
    Dim wl_bNoOpeAbi As Boolean
    Dim wl_bAlzAbi As Boolean
    Dim wl_bCafAbi As Boolean

    ' wl numéricas
    Dim wl_nBoxMsg As Integer
    Dim wl_nResMsg As String
    Dim wl_nTab As Integer
    Dim wl_nVlr As Double

    ' Caracter

    Dim wl_sClaPPl1 As String
    Dim wl_sClaPPl2 As String
    Dim wl_sCod As String
    Dim wl_sCodDgv As String
    Dim wl_sDoc As String
    Dim wl_sNom As String
    Dim wl_sNomFrm As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNroALetras As String
    Dim wl_sTipTbl As String
    Dim wl_sNomTblL1 As String
    Dim wl_sEstDoc As String

    ' Variables públicas


    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_nNroOpc As Integer
    Dim wp_sTipCmp As String

#End Region
#Region "012 BD - Variables campos BD Locales"

    Dim vl_nId As Long
    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodSer As String
    Dim vl_sTipMov As String
    Dim vl_sEstDoc As String
    Dim vl_dFecCtb As Date
    Dim vl_dFecDoc As Date
    Dim vl_dFecVto As Date
    Dim vl_dFecSys As Date
    Dim vl_sCodTer As String
    Dim vl_sNomTer As String
    Dim vl_sDocRef As String
    Dim vl_nTotHHCns As Long
    Dim vl_nTotMMCns As Long
    Dim vl_nTotTieCns As Long
    Dim vl_nTotDoc As Double
    Dim vl_sCodCte As String
    Dim vl_nNroCte As Long
    Dim vl_sClsDoc As String
    Dim vl_sCmn As String
    Dim vl_sCodCteCtb As String
    Dim vl_nNroCteCtb As Long
    Dim vl_nIdFECCT As Long
    Dim vl_sNitTer As String
    Dim vl_sTipDoc As String
    Dim vl_sCodUsr As String
    Dim vl_bPrp01 As Boolean
    Dim vl_bPrp02 As Boolean
    Dim vl_bPrp03 As Boolean
    Dim vl_nTotHHOpe As Long
    Dim vl_nTotMMOpe As Long
    Dim vl_nTotTieOpe As Double
    Dim vl_nTotHHAlz As Long
    Dim vl_nTotMMAlz As Long
    Dim vl_nTotTieAlz As Long
    Dim vl_nTotHHCaf As Long
    Dim vl_nTotMMCaf As Long
    Dim vl_nTotTieCaf As Long

    Dim vl_nId_l As Long
    Dim vl_nIdPEROP As Long
    Dim vl_sCodDocBas As String '5
    Dim vl_sCodSerBas As String
    Dim vl_nNroDocBas As Long
    Dim vl_sCodItm As String
    Dim vl_nCanItm As Double
    Dim vl_sCodOpe As String
    Dim vl_sNomOpe As String
    Dim vl_nHHIniOpe As Long
    Dim vl_nMMIniOpe As Long
    Dim vl_nHHFinOpe As Long
    Dim vl_nMMFinOpe As Long
    Dim vl_nHHCnsOpe As Long
    Dim vl_nMMCnsOpe As Long
    Dim vl_nTieCnsOpe As Long
    Dim vl_nHHCns As Long
    Dim vl_nMMCns As Long
    Dim vl_nTieCns As Long
    Dim vl_nTieReq As Long
    Dim vl_nPreUni As Long
    Dim vl_nTotLin As Double
    Dim vl_sCodCco As String
    Dim vl_nLinBas As Long
    Dim vl_sCodPdo As String
    Dim vl_sCodCta As String
    Dim vl_sCtaCosVta As String
    Dim vl_bItmBlq As Boolean
    Dim vl_nCanOpeTer As Long
    Dim vl_sCodCtr As String
    Dim vl_nHHIniAlz As Long
    Dim vl_nMMIniAlz As Long
    Dim vl_nHHFinAlz As Long
    Dim vl_nMMFinAlz As Long
    Dim vl_nHHCnsAlz As Long
    Dim vl_nMMCnsAlz As Long
    Dim vl_nTieCnsAlz As Long
    Dim vl_nHHIniCaf As Long
    Dim vl_nMMIniCaf As Long
    Dim vl_nHHFinCaf As Long
    Dim vl_nMMFinCaf As Long
    Dim vl_nHHCnsCaf As Long
    Dim vl_nMMCnsCaf As Long
    Dim vl_nTieCnsCaf As Long

    Dim vl_sEstPdo As String
    Dim vl_sTipRegTie As String
#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas
    Dim vl_nTamCmp As Integer
    Dim wl_bVdaRow As Boolean
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_nCellCod As Integer
    Dim wl_nCellDes As Integer
    Dim wl_nCntCol As Integer
    Dim wl_nCntRow As Integer
    Dim wl_nCol As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColCVC As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColKD As Integer
    Dim wl_nColKP As Integer
    Dim wl_nColKU As Integer
    Dim wl_nColNom As Integer
    Dim wl_nColSig As Integer
    Dim wl_nNroCol As Integer
    Dim wl_nNroDgv As Integer
    Dim wl_nRow As Integer
    Dim wl_nRowAct As Integer
    Dim wl_nRowAlto As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nRowCVC As Integer
    Dim wl_nRowIni As Integer
    Dim wl_nRowKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nRowSig As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nTotCol As Integer
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fila
#End Region
#Region "014 Objetos locales"
    Dim clnActTab As New ClaseNegocios.clnActTbl
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnPEODP As New ClaseNegocios.clnPEODP
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTE1 As New DataTable
    Dim wl_DTLst1 As New DataTable
    Dim wl_DTAPLND1 As New DataTable

#End Region
#Region "015 Estructuras"

    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim wl_aePEROP() As moe_Estructuras.ePEROP
    Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
    Dim wl_eABESD As New moe_Estructuras.eABESD
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
    Dim wl_eATOPE As New moe_Estructuras.eATOPE
    Dim wl_eFECTT As New moe_Estructuras.eFECTT
    Dim wl_eFLCTT1 As New moe_Estructuras.eFLCTT1
    Dim wl_eATPOP As New moe_Estructuras.eATPOP
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEROP As New moe_Estructuras.ePEROP
    Dim wl_ePLODP2 As moe_Estructuras.ePLODP2
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1


#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region

#Region "020 frm Eventos - Principal"
    Private Sub frmPEROD_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error :  frmPEROP_Disposed")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmPEROD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            Cbo_CargarLst()
            mof_IniciarVar()
            Plo_IniciarVar() '080
            Plo_InHabCtrl()
            
        Catch ex As Exception
            MsgBox("Error :  frmPEROD_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
           
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
   
    
    
#End Region
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_Lst_ATPOP()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATPOP"
            wl_eATPOP = New moe_Estructuras.eATPOP
            'wl_frmLst.wp_eATPOP = New moe_Estructuras.eATPOP
            wl_frmLst.ShowDialog()
            wl_eATPOP = wl_frmLst.wp_eATPOP
            vl_sCodTer = wl_eATPOP.sCodTer
            txtsCodTer.Text = wl_eATPOP.sCodTer
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Lst_ATPOP")
        End Try
    End Sub
    Private Sub BD_Var_eATPOP()
        Try
            With wl_eATPOP
                '  vl_nId = .nID
                txtsNomTer.Text = .sNomTer
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: wl_eATPOP")
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"

#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarATPOP() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATPOP = New moe_Estructuras.eATPOP
            wr_bEOFE2 = mof_fConATPOP(vl_sCodTer,
                                      wl_eATPOP)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATPOP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPELROP_Grl() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePEROP.sCodTer = txtsCodTer.Text
            wl_ePEROP.dFecDoc = vl_dFecDoc
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEROP.cndtConPELROP_Grl(wl_ePEROP,
                                                 wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPELROP_Grl")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPEROP_Grl() As Boolean
        Try
            Dim wl_sNomTbl As String
            Dim wl_sMayMenIgu As String



            wr_bEOFE2 = True
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePEROP.sCodTer = txtsCodTer.Text
            wl_ePEROP.dFecDoc = vl_dFecDoc
            wl_ePEROP.sEstDoc = "A"
            wl_sNomTbl = "PEROP"
            wl_sMayMenIgu = "="
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEROP.cndtConPEROP_Grl(wl_sNomTbl,
                                                wl_ePEROP,
                                                wl_sMayMenIgu,
                                                wr_bEOFE2)
            If wr_bEOFE2 = False Then
               

                wl_nRow = wl_DTE1.Rows.Count - 1
                wl_ePEROP = New moe_Estructuras.ePEROP
                moo_ePEROP_DT(wl_ePEROP,
                              wl_DTE1,
                              wl_nRow)
                Plo_VarfrmPEROD_ePEROP()
                vl_nId = wl_ePEROP.nId
                vl_sCodDoc = wl_ePEROP.sCodDoc
                vl_nNroDoc = wl_ePEROP.nNroDoc
                txtnNroDoc.Text = wl_ePEROP.nNroDoc
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPEROP_Grl")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPLROP1_Grl() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            wl_ePLROP1.nIdPEROP = wl_ePEROP.nId
            wl_ePLROP1.sCodDoc = wl_ePEROP.sCodDoc
            wl_ePLROP1.nNroDoc = wl_ePEROP.nNroDoc
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEROP.cndtConPLROP1(wl_ePLROP1,
                                             wr_bEOFE2)
            If wr_bEOFE2 = False Then
                wl_nRow = wl_DTE1.Rows.Count - 1
                wl_nRow = 0
                wl_ePLROP1 = New moe_Estructuras.ePLROP1
                moo_ePLROP1_DT(wl_ePLROP1,
                               wl_DTE1,
                               wl_nRow)
                Plo_VarfrmPEROD_Sec_ePLROP1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPLROP1_Grl")
        End Try
        Return wr_bEOFE2
    End Function


#End Region

#Region "043 BD Cargar"

#End Region
#Region "044 BD Contabilización"

#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdAbrirReg_Click(sender As System.Object, e As System.EventArgs) Handles cmdAbrirReg.Click
        Try
            wl_bAbrirReg = True
            wl_bCerrarReg = False
            Dim wl_frmPEROD_Opc As New frmPEROD_Opc
            wl_frmPEROD_Opc.wg_ePEROP = wl_ePEROP
            wl_frmPEROD_Opc.wg_ePLROP1 = wl_ePLROP1

            wl_frmPEROD_Opc.vg_sCodTer = vl_sCodTer
            wl_frmPEROD_Opc.vg_sNomTer = txtsNomTer.Text
            wl_frmPEROD_Opc.vg_dFecDoc = vl_dFecDoc
            wl_frmPEROD_Opc.vg_sHorSys = txtdHHMM.Text
            wl_frmPEROD_Opc.wg_bAbrirReg = wl_bAbrirReg
            wl_frmPEROD_Opc.wg_bCerrarReg = wl_bCerrarReg
            wl_frmPEROD_Opc.wg_bRegNue = wl_bRegNue
            wl_bOpcOk = False
            wl_frmPEROD_Opc.wg_ePEROP = wl_ePEROP
            wl_frmPEROD_Opc.wg_ePLROP1 = wl_ePLROP1
            wl_frmPEROD_Opc.ShowDialog()
            wl_bOpcOk = wl_frmPEROD_Opc.wg_bOpcOk
            Plo_IniciarVar()
            cmdTecOpe.PerformClick()
            cmdCancelar.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdAbrirReg_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            mof_LmpMsgError()
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdBuscar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs)
        Try
            wl_bEOF = False
            mof_LmpMsgError()
            MsgBox("Registro Exitoso")
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Try
            mof_LmpMsgError()
            wl_bEOF = False
            vl_sCodTer = ""
            BD_Lst_ATPOP()
            BD_Var_eATPOP()
            txtsCodTer.Focus()
            If vl_sCodTer = "" Or vl_sCodTer = 0 Then
                cmdTecOpe.Focus()
            Else
                Plo_VdaReg()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
    End Sub
    Private Sub cmdTecOpe_Click(sender As System.Object, e As System.EventArgs) Handles cmdTecOpe.Click
        Try
            mof_LmpMsgError()
            vl_sCodTer = ""
            Plo_IniciarVar()
            Dim wl_frmPEROD_TecNum As New frmPEROD_TecNum
            wl_frmPEROD_TecNum.Text = "Código Operario"
            wl_frmPEROD_TecNum.ShowDialog()

            vl_sCodTer = wl_frmPEROD_TecNum.wg_nNroEnt
            If vl_sCodTer = "" Or vl_sCodTer = 0 Then
                cmdTecOpe.Focus()
            Else
                txtsCodTer.Text = wl_frmPEROD_TecNum.wg_nNroEnt
                txtsCodTer.Focus()
                Plo_VdaReg()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdTecOpe_Click")
        End Try
    End Sub
#End Region
#Region "070 DGV"

#End Region

#Region "080 Plo"
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            vl_sCodTer = ""
            vl_sNomTer = ""
            wl_sEstDoc = ""
            txtsCodTer.Text = ""
            txtsNomTer.Text = ""
            txtnNroDoc.Text = ""
            txtsCodDoc.Text = ""
            wp_sCmdSel = " "
            wl_bAlzAbi = False
            wl_bCafAbi = False
            wl_bOpeAbi = False
            wl_bNoOpeAbi = False

            wl_bAbrirReg = False
            wl_bCerrarReg = False
            wl_bRegNue = False
            wl_ePEROP.sCodDoc = vl_sCodDoc
            wl_ePEROP.nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)
            wl_ePEROP.sClsDoc = vl_sClsDoc
            wl_ePEROP.sCodUsr = vg_sCodUsr
            wl_ePEROP.dFecSys = Date.Today


            'cboABESD.SelectedValue = vl_sEstDoc
            vl_sNitTer = ""
            wl_bVdoVta = False
            wl_bVdoCom = False

            ' errores
            wl_bYesNo = False
            wl_bEdit = False
            wg_sCodErrAdi = "10-203"
            wg_sCodErrCon = "10-103"
            wg_sCodErrOk = "20-001"
            wl_sCoderr = "10-112"
            wg_sDesMsgEli = "Este opción elimina el documento. ¿ Continua ?"
            wg_sTitMsgEli = "Mensaje del sistema"
            wg_sDesMsgAdi = "Este documento no puede modificarse después de crearse. ¿ Continua ?"
            wg_sTitMsgAdi = Me.Text

            dtpFecDoc.Value = Date.Today
            dtpFecDoc.Format = DateTimePickerFormat.Custom
            dtpFecDoc.CustomFormat = "yyyy-MM-dd"

            vl_sEstDoc = "A" ' 
            vl_sClsDoc = "DP"
            'vl_sCodDoc
            vl_nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)
            vl_sCodSer = ""
            '   cboABROP.SelectedValue = "S"
            vl_sEstDoc = txtsEstDoc.text
            vl_sTipMov = "S"
            vl_dFecCtb = dtpFecDoc.Value
            vl_dFecDoc = dtpFecDoc.Value
            vl_dFecVto = dtpFecDoc.Value
            vl_dFecSys = Date.Today
            vl_sCodTer = ""
            vl_sNomTer = ""
            vl_sDocRef = ""
            vl_nTotHHCns = 0
            vl_nTotMMCns = 0
            vl_nTotTieCns = 0
            vl_nTotDoc = 0
            vl_sCodCte = ""
            vl_nNroCte = 0
            'vl_sClsDoc = ""
            vl_sCmn = ""
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0
            vl_sNitTer = ""
            vl_sTipDoc = ""
            vl_sCodUsr = vg_sCodUsr
            vl_bPrp01 = False
            vl_bPrp02 = False
            vl_bPrp02 = False
            vl_nTotHHOpe = 0
            vl_nTotMMOpe = 0
            vl_nTotTieOpe = 0
            vl_nTotHHalz = 0
            vl_nTotMMalz = 0
            vl_nTotTiealz = 0
            vl_nTotHHcaf = 0
            vl_nTotMMcaf = 0
            vl_nTotTiecaf = 0

            ' Habilita controles
            wl_bOpcOk = True
            cmdAbrirReg.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_TxtsCodPerKeyUp()
        Try
            wl_ePEROP.sCodTer = txtsCodTer.Text
            vl_sCodTer = txtsCodTer.Text
            If vl_sCodTer <> " " Then


                BD_BuscarATPOP()
                If wr_bEOFE2 Then
                    MsgBox("Código de Operario " & vl_sCodTer & " - NO EXISTE")
                    cmdTecOpe.PerformClick()
                Else
                    txtsNomTer.Text = wl_eATPOP.sNomTer
                    Plo_HabCtrl()
                    '          cmdCancelar.Focus()
                    '        cmdAbrirReg.PerformClick()
                End If
            Else
                cmdCancelar.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_TxtsCodPerKeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaReg()
        Try
            wl_sEstDoc = ""
            wl_bEOF = False
            Plo_TxtsCodPerKeyUp()
            wl_bEOF = BD_ConPEROP_Grl()
            If wl_bEOF = True Then
                wl_bRegNue = True
                wl_ePEROP = New moe_Estructuras.ePEROP
                'mdAbrirReg.Focus()
                txtnNroDoc.Text = ""
                txtsCodDoc.Text = ""
                cmdAbrirReg.PerformClick()
                'cmdCancelar.Focus()
            Else
                wl_sEstDoc = wl_ePEROP.sEstDoc
                If wl_sEstDoc = "C" Then
                    wl_bRegNue = True
                    wl_ePEROP = New moe_Estructuras.ePEROP
                    txtnNroDoc.Text = ""
                    txtsCodDoc.Text = ""
                    cmdAbrirReg.PerformClick()
                Else
                    wl_bRegNue = False
                    wl_bEOF = BD_ConPLROP1_Grl()
                    If wl_bEOF = False Then
                        Plo_VarfrmPEROD_ePEROP()
                        Plo_VarfrmPEROD_Sec_ePLROP1()
                    End If
                    If wl_bOpcOk = True Then
                        cmdAbrirReg.PerformClick()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_VdaReg")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePEROP_VarfrmPEROD()
        Try
            wl_ePEROP.sCodDoc = txtsCodDoc.Text
            wl_ePEROP.nNroDoc = txtnNroDoc.Text
            wl_ePEROP.sTipMov = vl_sTipMov
            wl_ePEROP.sEstDoc = vl_sEstDoc
            wl_ePEROP.sCodSer = vl_sCodSer
            wl_ePEROP.dFecDoc = dtpFecDoc.Text
            wl_ePEROP.dFecCtb = vl_dFecCtb
            wl_ePEROP.dFecVto = vl_dFecVto
            wl_ePEROP.dFecSys = vl_dFecSys
            wl_ePEROP.sCodTer = vl_sCodTer
            wl_ePEROP.sNomTer = vl_sNomTer
            wl_ePEROP.sDocRef = vl_sDocRef
            wl_ePEROP.nTotHHCns = vl_nTotHHCns
            wl_ePEROP.nTotMMCns = vl_nTotMMCns
            wl_ePEROP.nTotTieCns = vl_nTotTieCns
            wl_ePEROP.nTotDoc = vl_nTotDoc
            wl_ePEROP.sCodCteCtb = vl_sCodCte
            wl_ePEROP.nNroCteCtb = vl_nNroCte
            wl_ePEROP.sClsDoc = vl_sClsDoc
            wl_ePEROP.sCmn = vl_sCmn
            wl_ePEROP.sCodCteCtb = vl_sCodCteCtb
            wl_ePEROP.nNroCteCtb = vl_nNroCteCtb
            wl_ePEROP.nIdFECCT = vl_nIdFECCT
            wl_ePEROP.sNitTer = vl_sNitTer
            wl_ePEROP.sTipDoc = vl_sTipDoc
            wl_ePEROP.sCodUsr = vl_sCodUsr
            wl_ePEROP.bPrp01 = vl_bPrp01
            wl_ePEROP.bPrp02 = vl_bPrp02
            wl_ePEROP.bPrp02 = vl_bPrp03
            wl_ePEROP.nTotHHOpe = vl_nTotHHOpe
            wl_ePEROP.nTotMMOpe = vl_nTotMMOpe
            wl_ePEROP.nTotTieOpe = vl_nTotTieOpe
            wl_ePEROP.nTotHHAlz = vl_nTotHHalz
            wl_ePEROP.nTotMMAlz = vl_nTotMMalz
            wl_ePEROP.nTotTieAlz = vl_nTotTiealz
            wl_ePEROP.nTotHHCaf = vl_nTotHHcaf
            wl_ePEROP.nTotMMCaf = vl_nTotMMcaf
            wl_ePEROP.nTotTieCaf = vl_nTotTiecaf




        Catch ex As Exception
            MsgBox("Error : Plo_frmPEROD_ePEROP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePLROP1_VarfrmPEROD_Sec()
        Try
            wl_ePEROP.nId = vl_nId_l
            wl_ePLROP1.sCodDocBas = vl_sCodDocBas
            wl_ePLROP1.sCodSerBas = vl_sCodSerBas
            wl_ePLROP1.nNroDocBas = vl_nNroDocBas
            wl_ePLROP1.sCodItm = vl_sCodItm
            wl_ePLROP1.nCanItm = vl_nCanItm
            wl_ePLROP1.sCodOpe = vl_sCodOpe
            wl_ePLROP1.sNomOpe = vl_sNomOpe
            wl_ePLROP1.nHHIniOpe = vl_nHHIniOpe
            wl_ePLROP1.nMMIniOpe = vl_nMMIniOpe
            wl_ePLROP1.nHHFinOpe = vl_nHHFinOpe
            wl_ePLROP1.nMMFinOpe = vl_nMMFinOpe
            wl_ePLROP1.nHHCns = vl_nHHCns
            wl_ePLROP1.nMMCns = vl_nMMCns
            wl_ePLROP1.nTieCns = vl_nTieCns
            wl_ePLROP1.nTieReq = vl_nTieReq
            wl_ePLROP1.nPreUni = vl_nPreUni
            wl_ePLROP1.nTotLin = vl_nTotLin
            wl_ePLROP1.sCodCco = vl_sCodCco
            wl_ePLROP1.nLinBas = vl_nLinBas
            wl_ePLROP1.sCodPdo = vl_sCodPdo
            wl_ePLROP1.sCodCta = vl_sCodCta
            wl_ePLROP1.sCtaCosVta = vl_sCtaCosVta
            wl_ePLROP1.bItmBlq = vl_bItmBlq
            wl_ePLROP1.nCanOpeTer = vl_nCanOpeTer
            wl_ePLROP1.sCodCtr = vl_sCodCtr
        Catch ex As Exception
            MsgBox("Error : Plo_ePLROP1_VarfrmPEROD_Sec")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VarfrmPEROD_ePEROP()
        Try
            vl_nId = wl_ePEROP.nId
            vl_sCodDoc = wl_ePEROP.sCodDoc
            vl_nNroDoc = wl_ePEROP.nNroDoc
            txtnNroDoc.Text = wl_ePEROP.nNroDoc
            vl_sCodSer = wl_ePEROP.sCodSer
            vl_sTipMov = wl_ePEROP.sTipMov
            vl_sEstDoc = wl_ePEROP.sEstDoc
            vl_dFecCtb = wl_ePEROP.dFecCtb
            vl_dFecDoc = wl_ePEROP.dFecDoc
            dtpFecDoc.Text = wl_ePEROP.dFecDoc
            vl_dFecVto = wl_ePEROP.dFecVto
            vl_dFecSys = wl_ePEROP.dFecSys
            vl_sCodTer = wl_ePEROP.sCodTer
            vl_sNomTer = wl_ePEROP.sNomTer
            vl_sDocRef = wl_ePEROP.sDocRef
            vl_nTotHHCns = wl_ePEROP.nTotHHCns
            vl_nTotMMCns = wl_ePEROP.nTotMMCns
            vl_nTotTieCns = wl_ePEROP.nTotTieCns
            vl_nTotDoc = wl_ePEROP.nTotDoc
            vl_sCodCte = wl_ePEROP.sCodCteCtb
            vl_nNroCte = wl_ePEROP.nNroCteCtb
            vl_sClsDoc = wl_ePEROP.sClsDoc
            vl_sCmn = wl_ePEROP.sCmn
            vl_sCodCteCtb = wl_ePEROP.sCodCteCtb
            vl_nNroCteCtb = wl_ePEROP.nNroCteCtb
            vl_nIdFECCT = wl_ePEROP.nIdFECCT
            vl_sNitTer = wl_ePEROP.sNitTer
            vl_sTipDoc = wl_ePEROP.sTipDoc
            vl_sCodUsr = wl_ePEROP.sCodUsr
            vl_bPrp01 = wl_ePEROP.bPrp01
            vl_bPrp02 = wl_ePEROP.bPrp02
            vl_bPrp03 = wl_ePEROP.bPrp02
            vl_nTotHHOpe = wl_ePEROP.nTotHHOpe
            vl_nTotMMOpe = wl_ePEROP.nTotMMOpe
            vl_nTotTieOpe = wl_ePEROP.nTotTieOpe
            vl_nTotHHAlz = wl_ePEROP.nTotHHAlz
            vl_nTotMMAlz = wl_ePEROP.nTotMMAlz
            vl_nTotTieAlz = wl_ePEROP.nTotTieAlz
            vl_nTotHHCaf = wl_ePEROP.nTotHHCaf
            vl_nTotMMCaf = wl_ePEROP.nTotMMCaf
            vl_nTotTieCaf = wl_ePEROP.nTotTieCaf
        Catch ex As Exception
            MsgBox("Error : Plo_VarfrmPEROD_ePEROP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VarfrmPEROD_Sec_ePLROP1()
        Try
            vl_nId_l = wl_ePEROP.nId
            vl_sCodDocBas = wl_ePLROP1.sCodDocBas
            vl_sCodSerBas = wl_ePLROP1.sCodSerBas
            vl_nNroDocBas = wl_ePLROP1.nNroDocBas
            vl_sCodItm = wl_ePLROP1.sCodItm
            vl_nCanItm = wl_ePLROP1.nCanItm
            vl_sCodOpe = wl_ePLROP1.sCodOpe
            vl_sNomOpe = wl_ePLROP1.sNomOpe
            vl_nHHIniOpe = wl_ePLROP1.nHHIniOpe
            vl_nMMIniOpe = wl_ePLROP1.nMMIniOpe
            vl_nHHFinOpe = wl_ePLROP1.nHHFinOpe
            vl_nMMFinOpe = wl_ePLROP1.nMMFinOpe
            vl_nHHCnsOpe = wl_ePLROP1.nHHCnsOpe
            vl_nMMCnsOpe = wl_ePLROP1.nMMCnsOpe
            vl_nTieCnsOpe = wl_ePLROP1.nTieCnsOpe
            vl_nHHCns = wl_ePLROP1.nHHCns
            vl_nMMCns = wl_ePLROP1.nMMCns
            vl_nTieCns = wl_ePLROP1.nTieCns
            vl_nTieReq = wl_ePLROP1.nTieReq
            vl_nPreUni = wl_ePLROP1.nPreUni
            vl_nTotLin = wl_ePLROP1.nTotLin
            vl_sCodCco = wl_ePLROP1.sCodCco
            vl_nLinBas = wl_ePLROP1.nLinBas
            vl_sCodPdo = wl_ePLROP1.sCodPdo
            vl_sCodCta = wl_ePLROP1.sCodCta
            vl_sCtaCosVta = wl_ePLROP1.sCtaCosVta
            vl_bItmBlq = wl_ePLROP1.bItmBlq
            vl_nCanOpeTer = wl_ePLROP1.nCanOpeTer
            vl_sCodCtr = wl_ePLROP1.sCodCtr
            vl_nHHIniAlz = wl_ePLROP1.nHHIniAlz
            vl_nMMIniAlz = wl_ePLROP1.nMMIniAlz
            vl_nHHFinAlz = wl_ePLROP1.nHHFinAlz
            vl_nMMFinAlz = wl_ePLROP1.nMMFinAlz
            vl_nHHCnsAlz = wl_ePLROP1.nHHCnsAlz
            vl_nMMCnsAlz = wl_ePLROP1.nMMCnsAlz
            vl_nTieCnsAlz = wl_ePLROP1.nTieCnsAlz
            vl_nHHIniCaf = wl_ePLROP1.nHHIniCaf
            vl_nMMIniCaf = wl_ePLROP1.nMMIniCaf
            vl_nHHFinCaf = wl_ePLROP1.nHHFinCaf
            vl_nMMFinCaf = wl_ePLROP1.nMMFinCaf
            vl_nHHCnsCaf = wl_ePLROP1.nHHCnsCaf
            vl_nMMCnsCaf = wl_ePLROP1.nMMCnsCaf
            vl_nTieCnsCaf = wl_ePLROP1.nTieCnsCaf

            'ope
            If vl_sCodDocBas <> "" Then
                If (vl_nHHIniOpe + vl_nMMIniOpe) > 0 Then
                    wl_bOpeAbi = True
                End If
                If (vl_nHHFinOpe + vl_nMMFinOpe) > 0 Then
                    wl_bOpeAbi = False
                End If
            End If
            'No operativas
            If vl_sCodOpe = "" Then
                If (vl_nHHIniOpe + vl_nMMIniOpe) > 0 Then
                    wl_bNoOpeAbi = True
                End If
                If (vl_nHHFinOpe + vl_nMMFinOpe) > 0 Then
                    wl_bNoOpeAbi = False
                End If
            End If
            If wl_bOpeAbi = True Or wl_bNoOpeAbi = True Then
                ' Almuerzo
                If (vl_nHHIniAlz + vl_nMMIniAlz) > 0 Then
                    wl_bAlzAbi = True
                End If
                If (vl_nHHFinAlz + vl_nMMFinAlz) > 0 Then
                    wl_bAlzAbi = True
                End If
                ' Cafetería
                If (vl_nHHIniCaf + vl_nMMIniCaf) > 0 Then
                    wl_bAlzAbi = True
                End If
                If (vl_nHHFinCaf + vl_nMMFinCaf) > 0 Then
                    wl_bAlzAbi = True
                End If

            End If
        Catch ex As Exception
            MsgBox("Error : Plo_VarfrmPEROD_Sec_ePLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_HabCtrl()
        Try
            cmdAbrirReg.Enabled = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabCtrl()
        Try
            cmdAbrirReg.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            txtdHHMM.Text = TimeString.ToString
        Catch ex As Exception
            MsgBox("Error :  Timer1_Tick")
            MsgBox(ex.Message)
        End Try
    End Sub
   
#End Region
#Region "082 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"
    'Private Sub txtsCodTer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCodTer.KeyUp
    '    Try
    '        If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
    '            If vl_sCodTer <> "" Then
    '                Plo_TxtsCodPerKeyUp()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error : txtsCodTer_KeyUp")
    '        MsgBox(ex.Message)
    '    End Try
    '
    '   End Sub
    '   Private Sub txtsCodTer_LostFocus(sender As Object, e As System.EventArgs) Handles txtsCodTer.LostFocus
    '       Try
    '           If vl_sCodTer <> "" Then
    '               Plo_TxtsCodPerKeyUp()
    '           End If
    '       Catch ex As Exception
    '           MsgBox("Error : txtsCodTer_LostFocus")
    '           MsgBox(ex.Message)
    '       End Try
    '   End Sub
    Private Sub dtpFecDoc_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecDoc.ValueChanged
        Try
            vl_dFecCtb = dtpFecDoc.Value
            vl_dFecDoc = dtpFecDoc.Value
            vl_dFecVto = dtpFecDoc.Value
            vl_dFecSys = Date.Today
        Catch ex As Exception
            MsgBox("Error : dtpFecDoc_ValueChanged")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region
#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#Region "150 grl Otros"
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_LmpMsgError()
        Me.Close()
        mof_LmpMsgError()
    End Sub
#End Region
#End Region

End Class