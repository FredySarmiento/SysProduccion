Public Class frmPEODP
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23
#Region "001 Inicia. wg - vg Definición del variables públicas"
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
#End Region
#Region "011 frm - Variables Locales"
    Dim wl_bSwsEliLin As Boolean
    Dim wl_bCmpVdo As Boolean
    Dim wl_bEdit As Boolean
    Dim wl_bSwsBor As Boolean
    Dim wl_bSwsCbo As Boolean
    Dim wl_bSwsCboABODP As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bVda1 As Boolean
    Dim wl_bVdaCodItm As Boolean
    Dim wl_bvdaCbo As Boolean
    Dim wl_bYesNo As Boolean
    Dim wl_bCboAPLND1 As Boolean

    Dim wl_dFecIni As Date
    Dim wl_dFecFin As Date

    Dim wl_nBoxMsg As Integer
    Dim wl_nColCVC As Integer
    Dim wl_nCanCmt As Double
    Dim wl_nCanLotStn As Double
    Dim wl_nCanOdp As Double
    Dim wl_nCanReq As Double
    Dim wl_nCanUniStn As Double
    Dim wl_nNroDocAnt As Long

    Dim wl_nNroCol As Integer
    Dim wl_nResMsg As String
    Dim wl_nRowCVC As Integer

    Dim wl_sClaPPl1 As String
    Dim wl_sClaPPl2 As String
    Dim wl_sCmpOrdE11 As String

    Dim wl_sDatCmpE11 As String
    Dim wl_sDatCmpE12 As String
    Dim wl_sDatCmpL11 As String
    Dim wl_sNomCmpE11 As String
    Dim wl_sNomCmpE12 As String
    Dim wl_sNomCmpL11 As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNomTblL1 As String
    Dim wl_sNroALetras As String
    Dim wl_sTipCmpE11 As String
    Dim wl_sTipCmpE12 As String
    Dim wl_sTipCmpL11 As String
    Dim wl_sTipCmpL12 As String
    Dim wl_sTipOrdE11 As String
    Dim wl_sTitCmpE11 As String
    Dim wl_sTitCmpE12 As String
    Dim wl_sTitCmpL11 As String
    Dim wl_sUniMedCmt As String

    Dim wl_sUniMedReq As String

    Dim wl_sTipTbl As String
    Dim wl_bEOF As Boolean
    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wp_nNroOpc As Integer
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_sTipCmp As String

    Dim wl_nVlrUniCnsMPD As Double
    Dim wl_nVlrUniCnsMOD As Double
    Dim wl_nVlrUniCnsCIF As Double

    Dim wl_nVlrGtoUni As Double
    Dim wl_nVlrItoUni As Double
    Dim wl_nVlrUtiBru As Double
    Dim wl_nVlrUtiNet As Double
    Dim wl_nTotVta As Double

    Dim wl_sTipOrd As String

    Dim wl_sNomCmp As String

    Dim wl_sTipCmp As String
    Dim wl_sCmpOrd As String
    Dim wl_sNomCmp1 As String
    Dim wl_sDatCmp1 As String
    Dim wl_sTipCmp1 As String
    Dim wl_sCmpOrd1 As String
    Dim wl_sCmdSel As String
    Dim wl_sTipOrd1 As String

    Dim wl_bImpP001 As Boolean
    Dim wl_bImpP002 As Boolean
    Dim wl_bImpP003 As Boolean
    Dim wl_bImpP004 As Boolean
    Dim wl_bImpP005 As Boolean


#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nId As Integer
    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodSer As String
    Dim vl_sNroLot As String
    Dim vl_sEstOdp As String
    Dim vl_sEstOdpIni As String
    Dim vl_sCodItm As String
    Dim vl_nCanLotStn As Double
    Dim vl_sUniMedStn As String
    Dim vl_nCanUniStn As Double
    Dim vl_nCanOdp As Double
    Dim vl_nCanUniOdp As Double
    Dim vl_sUniMedOdp As String
    Dim vl_sUniMedInv As String
    Dim vl_nCanUniEdp As String
    Dim vl_nTieItm As Double
    Dim vl_nTotTieOdp As Double
    Dim vl_nTotTieEdp As Double
    Dim vl_sCodAlm As String
    Dim vl_dFecEmi As Date
    Dim vl_dFecIni As Date
    Dim vl_dFecFin As Date
    Dim vl_dFecSys As Date
    Dim vl_sClsDoc As String
    Dim vl_sCodUsr As String

    Dim vl_nVrcCan As Double
    Dim vl_nVlrTotReqMPD As Double
    Dim vl_nVlrTotCnsMPD As Double
    Dim vl_nVrcTotMPD As Double
    Dim vl_nTotTieReqMOD As Double
    Dim vl_nTotTieCnsMOD As Double
    Dim vl_nVrcTieMOD As Double
    Dim vl_nVlrTotReqMOD As Double
    Dim vl_nVlrTotCnsMOD As Double
    Dim vl_nVrcTotMOD As Double
    Dim vl_nTotTasReqCIF As Double
    Dim vl_nTotTasCnsCIF As Double
    Dim vl_nVrcTasCIF As Double
    Dim vl_nVlrTotReqCIF As Double
    Dim vl_nVlrTotCnsCIF As Double
    Dim vl_nVrcTotCIF As Double
    Dim vl_nCosTotReq As Double
    Dim vl_nCosTotCns As Double
    Dim vl_nVrcCosTot As Double
    Dim vl_nTotUniReq As Double
    Dim vl_nTotUniCns As Double
    Dim vl_nVrcUni As Double
    Dim vl_nCosUniReq As Double
    Dim vl_nCosUniCns As Double
    Dim vl_nVrcCosUni As Double
    Dim vl_sNomItm As String
    Dim vl_sCmn As String

    Dim vl_nCanCmt As Double
    Dim vl_nCanCmtItm As Double

    Dim vl_nNroSig As Long
    Dim vl_nPesCmt As Double
    Dim vl_nPesItm As Double
    Dim vl_nPorCmt As Double
    Dim vl_nPorItm As Double

    Dim vl_sCodAna As String

    Dim vl_sTipMov As String
    Dim vl_sTipLIM As String
    Dim vl_sCodTipAna As String

    'Dim vp_sCodAlm As String
    Dim vp_sNomItm As String

    Dim vl_sCodFor As String
    Dim vl_sNomFor As String
    Dim vl_sCodCmt As String

    Dim vl_sCodAlmCns As String
    Dim vl_sCodOpe As String
    Dim vl_sDesOpe As String
    Dim vl_nTieOpe As Double

    Dim vl_sCodCIF As String
    Dim vl_sDesCIF As String
    Dim vl_nTasCIF As Double
    Dim vl_nVlrCIFRea As Double

    Dim vl_nPorGto As Double
    Dim vl_nPorIto As Double
    Dim vl_nPreVta As Double
    Dim vl_bSelItm As Boolean
    Dim vl_bIndCanRes As Boolean
    Dim vl_bIndCanPry As Boolean

    Dim wl_sCodItm As String

#End Region
#Region "013 DGV - Variables Locales"

    Dim wl_bVdaE1 As Boolean
    Dim wl_bVdaRow As Boolean

    Dim wl_nCmpCla As Integer
    Dim wl_nTab As Integer

    Dim wl_nColFin As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColFin1 As Integer
    Dim wl_nColFin2 As Integer
    Dim wl_nColFin3 As Integer
    Dim wl_nColFin5 As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColIni1 As Integer
    Dim wl_nColIni2 As Integer
    Dim wl_nColIni3 As Integer
    Dim wl_nColIni5 As Integer
    Dim wl_nColSig As Integer
    Dim wl_nTotCol As Integer
    Dim wl_nTotCol1 As Integer
    Dim wl_nTotCol2 As Integer
    Dim wl_nTotCol3 As Integer
    Dim wl_nTotCol5 As Integer
    Dim vl_nTamCmp As Integer
    Dim wl_sNomFrm As String

    Dim wl_nCntRow As Integer
    Dim wl_nRow As Integer
    Dim wl_nCol As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nColAnt As Integer
    Dim wl_RowAlto As Integer
    Dim wl_nRowSig As Integer

    Dim wl_nCntCol As Integer

    Dim wl_nRowIni As Integer
    Dim wl_nRowVacia As Integer
    Dim wp_sTipCol As String 'N = numérico. C = pesos. S = string. d = fecha
    Dim wp_bVisible As Boolean
    Dim wp_bReadOnly As Boolean
    Dim wl_nRowKD As Integer
    Dim wl_nColKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nColKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nColKU As Integer
    Dim wl_nNroDgv As Integer
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y

    Dim wl_sCodDgv As String
    Dim wl_CtrlDgv As DataGridView
    Dim wl_sCodErrOk As String
    Dim wl_sCodErrCon As String
    Dim wl_sCodErrAdi As String
    Dim wl_sTblCon1 As String
    Dim wl_sCmpCon11 As String
    Dim wl_sCmpCon12 As String
    Dim wl_sTitCon11 As String
    Dim wl_sTitCon12 As String
    Dim wl_sIndCon As String
    Dim wl_sSelCon11 As String
    Dim wl_sSelCon12 As String
    Dim wl_sTblCon2 As String
    Dim wl_sTblLst1 As String
    Dim wl_sCmpTSB1 As String
    Dim wl_sCmpTSB2 As String
    Dim wl_sCmpTSB As String
    Dim wl_sDatTSB As String
    Dim wl_sTipCmpTSB As String
    Dim wl_sDatTSB1 As String
    Dim wl_sTipCmpTSB1 As String
    Dim wl_sDatTSB2 As String
    Dim wl_sTipCmpTSB2 As String
    Dim wl_sClaPpl As String
    Dim wl_sDesMsgEli As String
    Dim wl_sTitMsgEli As String
    Dim wl_sNomTblE2 As String
    Dim wl_sNomCmpE21 As String
    Dim wl_sDatCmpE21 As String
    Dim wl_sTipCmpE21 As String
    Dim wl_sCmpOrdE21 As String
    Dim wl_sTipOrdE21 As String
    Dim wl_sNomCmpE22 As String
    Dim wl_sDatCmpE22 As String
    Dim wl_sTipCmpE22 As String



#End Region
#Region "014 Objetos locales"
    ' objetos locales
    Dim clnATASI As New ClaseNegocios.clnATASI
    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim clnPELIM As New ClaseNegocios.clnPELIM
    Dim clnPEODP As New ClaseNegocios.clnPEODP
    Dim clnPEFOM As New ClaseNegocios.clnPEFOM
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnTblAB As New ClaseNegocios.clnTblAB
    Dim clnPLLIM1 As New ClaseNegocios.clnPELIM
    Dim clnPLLIM2 As New ClaseNegocios.clnPELIM
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnPLODP As New ClaseNegocios.clnPEODP
    Dim clnPLODP1 As New ClaseNegocios.clnPEODP
    Dim clnPLODP2 As New ClaseNegocios.clnPEODP
    Dim clnPLODP3 As New ClaseNegocios.clnPEODP
    Dim cnf As New ClaseNegocios.clnFunciones
    Dim vl_CtrlDgv As New DataGridView
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_DTLst1 As DataTable
    Dim wl_DTE1 As DataTable
    Dim wl_DTE2 As DataTable
    Dim wl_DTL1 As DataTable


#End Region
#Region "015 Estructuras"
    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeATANA() As moe_Estructuras.eATANA
    Dim wl_aeATASI() As moe_Estructuras.eATASI
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
    Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wl_aePELIM() As moe_Estructuras.ePELIM
    Dim wl_aePEODP() As moe_Estructuras.ePEODP
    Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
    Dim wl_aePLLIM1() As moe_Estructuras.ePLLIM1
    Dim wl_aePLLIM2() As moe_Estructuras.ePLLIM2
    Dim wl_aePLLIM3() As moe_Estructuras.ePLLIM3
    Dim wl_aePLODP1() As moe_Estructuras.ePLODP1
    Dim wl_aePLODP2() As moe_Estructuras.ePLODP2
    Dim wl_aePLODP3() As moe_Estructuras.ePLODP3
    Dim wl_aePLODP5() As moe_Estructuras.ePLODP5


    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATCIF As New moe_Estructuras.eATCIF
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATANA As New moe_Estructuras.eATANA
    Dim wl_eATASI As New moe_Estructuras.eATASI
    Dim wl_eATTIA As New moe_Estructuras.eATTIA
    Dim wl_eATOPE As New moe_Estructuras.eATOPE
    Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
    Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
    Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
    Dim wl_eILDMI1 As New moe_Estructuras.eILDMI1
    Dim wl_ePELIM As New moe_Estructuras.ePELIM
    Dim wl_ePELIMeIEDMI As New moe_Estructuras.Q_ePELIM_eIEDMI
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEODP_PLODP4 As New moe_Estructuras.ePEODP_PLODP4
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
    Dim wl_ePLLIM1 As New moe_Estructuras.ePLLIM1
    Dim wl_ePLLIM2 As New moe_Estructuras.ePLLIM2
    Dim wl_ePLLIM3 As New moe_Estructuras.ePLLIM3
    Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1
    Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
    Dim wl_ePLODP3 As New moe_Estructuras.ePLODP3
    Dim wl_ePLODP4 As New moe_Estructuras.ePLODP4
    Dim wl_ePLODP5 As New moe_Estructuras.ePLODP5


#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String

#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#End Region

#Region "020 frm Eventos - Principal"
    Private Sub frmPEODP_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Try
            grl_RemoveHandler()
        Catch ex As Exception
            MsgBox("Error : frmPELIM_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmPEODP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_RemoveHandler()
            grl_AddHandler()
            mof_fCnfCtrl(Me)
            mof_IniciarVar()

            Plo_IniciarEst()
            Plo_IniciarFrm()
            Plo_IniciarVar()
            wl_sTipTbl = "E2"

            BD_DatPrmTipTbl(wl_sTipTbl)
            dgv_APDGV()
            Plo_IniciarVarDGV() '080
            grl_EventCtrl(Me)
            Cbo_CargarLst()
            Plo_CrgModCtb() '081
            Plo_ActivarCrear()
        Catch ex As Exception
            MsgBox("Error : frmPEODP_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmPEODP_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        txtnNroDoc.Focus()
    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarABEOP()
            Cbo_CargarABODP()
            Cbo_CargarACUNI()
            Cbo_CargarAPLND1()
            wl_bvdaCbo = True
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABEOP()
        Try
            '  cboABESD.Enabled = False
            wl_DTLst1 = New DataTable
            wl_sTblLst1 = "ABEOP"
            wr_bEOFLst1 = True
            wl_DTLst1 = clnTblAB.cndtCrgABEOP(wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABEOP.DataSource = wl_DTLst1
                cboABEOP.ValueMember = wl_DTLst1.Columns("sCodEstODP").Caption.ToString
                cboABEOP.DisplayMember = wl_DTLst1.Columns("sNomEstODP").Caption.ToString
            End If
            wl_bvdaCbo = False
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABEOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABODP()
        Try
            '  cboABESD.Enabled = False
            wl_DTLst1 = New DataTable
            wr_bEOFLst1 = True
            wl_DTLst1 = clnTblAB.cndtCrgABODP(wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABODP.DataSource = wl_DTLst1
                cboABODP.ValueMember = wl_DTLst1.Columns("sCodDoc").Caption.ToString
                cboABODP.DisplayMember = wl_DTLst1.Columns("sDesDoc").Caption.ToString
            End If
            '  cboABODP.SelectedValue = "OP"
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarACUNI()
        Try
            '  cboABESD.Enabled = False
            wl_DTLst1 = New DataTable
            wl_sTblLst1 = "ACUNI"
            wr_bEOFLst1 = True
            wl_DTLst1 = clnConTbl.cndtCargarLista(wl_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACUNI.DataSource = wl_DTLst1
                cboACUNI.ValueMember = wl_DTLst1.Columns("sCodUni").Caption.ToString
                cboACUNI.DisplayMember = wl_DTLst1.Columns("sNomUni").Caption.ToString
            End If
            cboACUNI.SelectedValue = "Kg"
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarACUNI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarAPLND1()
        Try
            wl_bCboAPLND1 = False
            wl_DTL1 = New DataTable
            wl_sTblLst1 = "APLND1"
            wr_bEOFLst1 = wr_bEOFLst1
            wl_DTL1 = clnConTbl.cndtCargarNro(wl_sTblLst1,
                                                vl_sCodDoc,
                                                wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboAPLND1.DataSource = wl_DTL1
                cboAPLND1.ValueMember = wl_DTL1.Columns("sCodSer").Caption.ToString
                cboAPLND1.DisplayMember = wl_DTL1.Columns("sCodSer").Caption.ToString
                cboAPLND1.SelectedValue = wl_DTE2.Rows(0).Item("sCodSer")
                wl_sDatCmpE11 = cboABODP.SelectedValue
            End If
            wl_bCboAPLND1 = True
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarAPLND1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboAPLND1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAPLND1.SelectedIndexChanged

        Dim wl_i As Integer
        Try

            If wl_bCboAPLND1 Then
                wl_i = cboAPLND1.SelectedIndex
                If cmdCrear.Visible = True Then
                    wg_sTblLst1 = "APLND1"
                    vl_sCodSer = cboAPLND1.SelectedValue

                    wg_DTLst1 = clnConTbl.cndtSelSer(wg_sTblLst1,
                                                     vl_sCodDoc,
                                                     vl_sCodSer,
                                                     wr_bEOFLst1)
                    If Not wr_bEOFLst1 Then
                        moo_eAPLND1_DT(wl_eAPLND1,
                                       wg_DTLst1,
                                       0)
                        txtnNroDoc.Text = wl_eAPLND1.nNroSig
                        vl_nNroDoc = wl_eAPLND1.nNroSig
                        vl_sCodSer = wl_eAPLND1.sCodSer
                        Plo_IniciarVar()
                        wl_CtrlDgv.Rows.Clear()
                        dgv_AdiRow(dgv1)
                        If vl_sCodSer = "FM" Then
                            txtsNomItm.Enabled = True
                        Else
                            txtsNomItm.Enabled = False
                        End If

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cboAPLND1_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboABEOP_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboABEOP.SelectedIndexChanged
        Try
            If wl_bvdaCbo = True Then
                If cboABEOP.SelectedValue = "1" Then
                    dtpFecEmi.Enabled = True
                    dtpFecIni.Enabled = False
                    dtpFecFin.Enabled = False
                    'Plo_ReversarReservarMP()
                End If
                If cboABEOP.SelectedValue = "2" Then
                    dtpFecEmi.Enabled = False

                    dtpFecIni.Enabled = True
                    dtpFecFin.Enabled = False
                End If

                If cboABEOP.SelectedValue = "3" Then
                    dtpFecEmi.Enabled = False
                    dtpFecIni.Enabled = False
                    dtpFecFin.Enabled = True
                End If
                If cboABEOP.SelectedValue = "5" Then
                    dtpFecEmi.Enabled = False
                    dtpFecIni.Enabled = True
                    dtpFecFin.Enabled = False
                    'Plo_ReservarMP()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error :  cboABEOP_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboABODP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboABODP.SelectedIndexChanged
        Try
            Dim wl_i As Integer
            If cmdBuscar.Visible = True Then
                wl_i = cboABODP.SelectedIndex
                If wl_i = -1 Then
                    Exit Sub
                End If
                ' If cboABODP.SelectedValue.ToString <> "System.Data.DataRowView" Then
                If cboABODP.SelectedValue <> Nothing Then

                    wl_sDatCmpE11 = cboABODP.SelectedValue
                    vl_sCodDoc = cboABODP.SelectedValue
                    vl_sCodSer = ""
                    Plo_LeeAPEND()
                    Cbo_CargarAPLND1()
                    vl_nNroDoc = CLng(txtnNroDoc.Text)

                    cboAPLND1.Focus()
                    wl_CtrlDgv.Rows.Clear()
                    dgv_AdiRow(dgv1)
                    'txtnNroDoc.Focus()


                End If
            End If

            If cmdCrear.Visible = True Then
                wl_i = cboABODP.SelectedIndex
                If wl_i = -1 Then
                    Exit Sub
                End If
                If cboABODP.SelectedValue.ToString <> "System.Data.DataRowView" Then
                    vl_sCodDoc = cboABODP.SelectedValue
                    wl_sDatCmpE11 = cboABODP.SelectedValue
                    Plo_LeeAPEND()
                    Cbo_CargarAPLND1()
                    vl_nNroDoc = CLng(txtnNroDoc.Text)

                    txtnNroDoc.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cboABODP_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_ActualizarDetalle4(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            Plo_Var_FrmPLODP4()
            BD_ePLODP4_Var()
            wl_bYesNo = clnPEODP.cnCrearActualizarPLODP4(wl_ePLODP4,
                                                         wr_bEOFE1,
                                                         wp_sCmdSel)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ActualizarDetalle4")
        End Try
        Return wl_bYesNo
    End Function
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nI1 As Integer = 0
        wl_bYesNo = False
        Try
            Plo_Var_FrmPEODP()
            BD_ePEODP_Var()
            BD_BuscarATALM()
            If wr_bEOFE2 Then
                MsgBox("Código del Almacén es obligatorio")
                txtsCodAlm.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            wl_CtrlDgv = Me.dgv1
            For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                wl_nI1 = wl_nI + 1
                '    If wl_nNroDgv = 0 Then
                If dgv1.Rows(wl_nI).Visible = True Then
                    Continue For
                End If
                If dgv1.Rows(wl_nI).Cells("sCodItm").Value = "" Then
                    Exit For
                End If
                'End If
                'If wl_nNroDgv = 0 Then
                If dgv1.Rows(wl_nI).Cells("sCodCmt").Value = "" Then
                    Exit For
                    'End If
                End If
                '       If dgv1.Rows(wl_nI).Cells("nCanCmt").Value = 0 Then
                ' MsgBox("Línea Nro. " & wl_nI1.ToString & " tiene Cantidad de componente en 0")
                ' wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanCmt")
                ' Return wl_bYesNo
                ' End If
            Next
            wl_bVdaE1 = True
            If Not mov_VdaMTB(wl_bVdaE1,
                              mtbsCodItm) Then

                mtbsCodItm.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            Plo_Cal_Lostfocus()
            wl_bYesNo = clnPEODP.cnCrearActualizar(wl_ePEODP,
                                                   wr_bEOFE1,
                                                   wp_sCmdSel)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmd_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_DatPrmTipTbl(ByRef wl_sTipTbl As String)
        Try
            wl_sNomTblE1 = "PEODP"
            wl_sNomCmpE11 = "sCodDoc"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código Doc "
            wl_sDatCmpE11 = cboABODP.SelectedValue
            wl_sNomCmpE12 = "nNroDoc"
            wl_sTipCmpE12 = "N"
            wl_sTitCmpE12 = "Numero documento"
            wl_sDatCmpE12 = txtnNroDoc.Text
            wl_sClaPPl1 = wl_sDatCmpE11
            wl_sClaPPl2 = wl_sDatCmpE12
            wr_bEOFE1 = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_DatPrmTipTbl")
        End Try
    End Sub
    Private Sub BD_DatPrmTSB() 'Constante
        Try
            wl_nCmpCla = 3
            wl_sCmpTSB1 = "sCodDoc"
            wl_sCmpTSB2 = "nNroDoc"
            Select Case wl_nCmpCla
                Case 1
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_ePEODP.nId
                    wl_sTipCmpTSB = "N"

                Case 2
                    wl_sCmpTSB = wl_sCmpTSB2
                    wl_sDatTSB = wl_sClaPpl
                    wl_sTipCmpTSB = "N"
                Case 3
                    wl_sDatTSB1 = wl_sClaPPl1
                    wl_sTipCmpTSB1 = "S"
                    wl_sDatTSB2 = wl_sClaPPl2
                    wl_sTipCmpTSB2 = "N"
            End Select
        Catch ex As Exception
            MsgBox("Error :  BD_DatPrmTSB")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BD_Var_ePELIMeIEDMI()
        Try
            If wl_ePELIMeIEDMI.ePELIM.sCodItm <> "" Then
                vl_sCodItm = wl_ePELIMeIEDMI.ePELIM.sCodItm
                vl_sCodAlm = wl_ePELIMeIEDMI.ePELIM.sCodAlm
                vl_sNomItm = wl_ePELIMeIEDMI.ePELIM.sNomItm
                vl_nPreVta = wl_ePELIMeIEDMI.ePELIM.nPreVta
                vl_nPorGto = vg_nPorGto
                vl_nPorIto = vg_nPorIto
                vl_bIndCanRes = wl_ePELIMeIEDMI.ePELIM.bIndCanRes
                vl_bIndCanPry = wl_ePELIMeIEDMI.ePELIM.bIndCanPry
                vl_nCanUniStn = wl_ePELIMeIEDMI.ePELIM.nCanUniStn
                vl_sUniMedStn = wl_ePELIMeIEDMI.ePELIM.sUniMedStn
                vl_nTieItm = wl_ePELIMeIEDMI.ePELIM.nTieItm
                vl_nCanLotStn = wl_ePELIMeIEDMI.ePELIM.nCanLotStn
                vl_sUniMedInv = wl_ePELIMeIEDMI.ePELIM.sUniMedInv
                '    txtnCanOdp.Focus()
            Else
                mtbsCodItm.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eIEDMI")
        End Try

    End Sub
    Private Sub BD_ePEODP_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRowSub As Integer
            wl_nRowSub = wp_DTE1.Rows.Count - 1
            wl_ePEODP = New moe_Estructuras.ePEODP
            moo_ePEODP_DT(wl_ePEODP,
                          wp_DTE1,
                          wl_nRowSub)

            vl_sCodItm = wl_ePEODP.sCodItm
            BD_BuscarIEDMI()
            txtsNomItm.Text = wl_eIEDMI.sNomItm
            cboABODP.Text = wl_ePEODP.sCodDoc
            txtnNroDoc.Text = wl_ePEODP.nNroDoc
            wl_sDatCmpE12 = txtnNroDoc.Text
        Catch ex As Exception
            MsgBox("Error :  BD_ePEODP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_ePEODP_Var()
        Try
            wl_ePEODP = New moe_Estructuras.ePEODP
            wl_sClaPpl = vl_sCodItm
            vl_sCodItm = vl_sCodItm
            vp_sNomItm = vl_sNomItm
            With wl_ePEODP
                .sCodDoc = vl_sCodDoc
                .nNroDoc = vl_nNroDoc
                .sCodSer = vl_sCodSer
                .sNroLot = vl_sNroLot
                .sEstOdp = vl_sEstOdp
                .sCodItm = vl_sCodItm
                .nCanLotStn = vl_nCanLotStn
                .sUniMedStn = vl_sUniMedStn
                .nCanUniStn = vl_nCanUniStn
                .nCanOdp = vl_nCanOdp
                .nCanUniOdp = vl_nCanUniOdp
                .sUniMedInv = vl_sUniMedInv
                .sUniMedOdp = vl_sUniMedOdp
                .nCanUniEdp = vl_nCanUniEdp
                .nTieItm = vl_nTieItm
                .nTotTieOdp = vl_nTotTieOdp
                .nTotTieEdp = vl_nTotTieEdp
                .sCodAlm = vl_sCodAlm
                .dFecEmi = vl_dFecEmi
                .dFecIni = vl_dFecIni
                .dFecFin = vl_dFecFin
                .dFecSys = vl_dFecSys
                .sClsDoc = vl_sClsDoc
                .sCodUsr = vg_sCodUsr
                .sNomItm = vl_sNomItm
                .sCmn = vl_sCmn
                .bIndCanRes = vl_bIndCanRes
                .bIndCanPry = vl_bIndCanPry

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ePEODP_Var")
        End Try

    End Sub
    Private Sub BD_Var_ePEODP()
        Try
            With wl_ePEODP
                vl_nNroDoc = .nNroDoc
                vl_sCodSer = .sCodSer
                vl_sNroLot = .sNroLot
                vl_sEstOdp = .sEstOdp
                vl_sCodItm = .sCodItm
                vl_sNomItm = .sNomItm
                vl_nCanLotStn = .nCanLotStn
                vl_sUniMedStn = .sUniMedStn
                vl_nCanUniStn = .nCanUniStn
                vl_nCanOdp = .nCanOdp
                vl_nCanUniOdp = .nCanUniOdp
                vl_sUniMedInv = .sUniMedInv
                vl_sUniMedOdp = .sUniMedOdp
                vl_nCanUniEdp = .nCanUniEdp
                vl_nTieItm = .nTieItm
                vl_nTotTieOdp = .nTotTieOdp
                vl_nTotTieEdp = .nTotTieEdp
                vl_sCodAlm = .sCodAlm
                vl_dFecEmi = .dFecEmi
                vl_dFecIni = .dFecIni
                vl_dFecFin = .dFecFin
                vl_dFecSys = .dFecSys
                vl_sClsDoc = .sClsDoc
                vl_sCmn = .sCmn
            End With
            wl_sDatCmpE12 = txtnNroDoc.Text
            If vl_sEstOdp = "1" Then
                Plo_ActivarCmpAct()
                Plo_InactOP_1()
            Else
                Plo_InactivarCmpAct()
                If vl_sEstOdp = "2" Or vl_sEstOdp = "5" Then
                    Plo_ActivarCmpAut()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ePEODP")
        End Try
    End Sub
    Private Sub BD_ePLODP4_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRowSub As Integer
            wl_nRowSub = wp_DTE1.Rows.Count - 1
            wl_ePLODP4 = New moe_Estructuras.ePLODP4
            moo_ePLODP4_DT(wl_ePLODP4,
                           wp_DTE1,
                           wl_nRowSub)

        Catch ex As Exception
            MsgBox("Error :  BD_ePLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_ePLODP4_Var()
        Try
            wl_ePLODP4 = New moe_Estructuras.ePLODP4
            With wl_ePLODP4
                .sCodDoc = vl_sCodDoc
                .nNroDoc = vl_nNroDoc
                .sCodSer = vl_sCodSer
                .sCodItm = vl_sCodItm
                .nCanOdp = vl_nCanOdp
                .nCanUniOdp = vl_nCanUniOdp
                .nCanUniEdp = vl_nCanUniEdp
                .nVrcCan = vl_nVrcCan
                .nVlrTotReqMPD = vl_nVlrTotReqMPD
                .nVlrTotCnsMPD = vl_nVlrTotCnsMPD
                .nVrcTotMPD = vl_nVrcTotMPD
                .nTotTieReqMOD = vl_nTotTieReqMOD
                .nTotTieCnsMOD = vl_nTotTieCnsMOD
                .nVrcTieMOD = vl_nVrcTieMOD
                .nVlrTotReqMOD = vl_nVlrTotReqMOD
                .nVlrTotCnsMOD = vl_nVlrTotCnsMOD
                .nVrcTotMOD = vl_nVrcTotMOD
                .nTotTasReqCIF = vl_nTotTasReqCIF
                .nTotTasCnsCIF = vl_nTotTasCnsCIF
                .nVrcTasCIF = vl_nVrcTasCIF
                .nVlrTotReqCIF = vl_nVlrTotReqCIF
                .nVlrTotCnsCIF = vl_nVlrTotCnsCIF
                .nVrcTotCIF = vl_nVrcTotCIF
                .nCosTotReq = vl_nCosTotReq
                .nCosTotCns = vl_nCosTotCns
                .nVrcCosTot = vl_nVrcCosTot

                .nTotUniReq = vl_nTotUniReq
                .nTotUniCns = vl_nTotUniCns
                .nVrcUni = vl_nVrcUni

                .nCosUniReq = vl_nCosUniReq
                .nCosUniCns = vl_nCosUniCns
                .nVrcCosUni = vl_nVrcCosUni

                .nPreVta = vl_nPreVta
                .nPorGto = vl_nPorGto
                .nPorIto = vl_nPorIto



            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ePLODP4_Var")
        End Try

    End Sub
    Private Sub BD_Var_ePLODP4()
        Try
            With wl_ePLODP4

                ' vl_nCanOdp = .nCanOdp
                ' vl_nCanUniOdp = .nCanUniOdp
                'vl_nCanUniEdp = .nCanUniEdp

                vl_nVlrTotReqMPD = .nVlrTotReqMPD
                vl_nVlrTotCnsMPD = .nVlrTotCnsMPD
                vl_nVrcTotMPD = .nVrcTotMPD

                vl_nTotTieReqMOD = .nTotTieReqMOD
                vl_nTotTieCnsMOD = .nTotTieCnsMOD
                vl_nVrcTieMOD = .nVrcTieMOD

                vl_nVlrTotReqMOD = .nVlrTotReqMOD
                vl_nVlrTotCnsMOD = .nVlrTotCnsMOD
                vl_nVrcTotMOD = .nVrcTotMOD

                vl_nTotTasReqCIF = .nTotTasReqCIF
                vl_nTotTasCnsCIF = .nTotTasCnsCIF
                vl_nVrcTasCIF = .nVrcTasCIF

                vl_nVlrTotReqCIF = .nVlrTotReqCIF
                vl_nVlrTotCnsCIF = .nVlrTotCnsCIF
                vl_nVrcTotCIF = .nVrcTotCIF

                vl_nCosTotReq = .nCosTotReq
                vl_nCosTotCns = .nCosTotCns
                vl_nVrcCosTot = .nVrcCosTot

                vl_nTotUniReq = .nTotUniReq
                vl_nTotUniCns = .nTotUniCns
                vl_nVrcUni = .nVrcUni

                vl_nCosUniReq = .nCosUniReq
                vl_nCosUniCns = .nCosUniCns
                vl_nVrcCosUni = .nVrcCosUni

                vl_nPreVta = .nPreVta
                vl_nPorGto = .nPorGto
                vl_nPorIto = .nPorIto





            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ePLODP4")
        End Try
    End Sub
    Private Sub BD_SdoOPPEODP_0(ByVal wl_ePEODP)
        Try
            wl_bYesNo = True
            wl_bYesNo = clnPEODP.cnSdoOPPEODP_0(wl_ePEODP)
        Catch ex As Exception
            MsgBox("Error : BD_SdoOPPEODP_0")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarGLINV1()

        Try
            wl_bEOF = True
            wl_DTL1 = New DataTable
            wl_DTL1 = clnIEINV.cndtConGLINV1(wl_sNomtbl,
                                             wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sNomCmp1,
                                             wl_sDatCmp1,
                                             wl_sTipCmp1,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_sCmpOrd1,
                                             wl_sTipOrd1,
                                             wl_bEOF)
            ReDim wl_aeGLMOV1(0)
            wl_aeGLMOV1(0) = New moe_Estructuras.eGLMOV1
            If wl_bEOF = False Then
                moo_aeGLMOV1_DT(wl_aeGLMOV1,
                                wl_DTL1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarGLINV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarPLROP1()
        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEROP.cndtConGLROP1(wl_sNomCmp,
                                             wl_sDatCmp,
                                             wl_sTipCmp,
                                             wl_sNomCmp1,
                                             wl_sDatCmp1,
                                             wl_sTipCmp1,
                                             wl_sCmpOrd,
                                             wl_sTipOrd,
                                             wl_sCmpOrd1,
                                             wl_sTipOrd1,
                                             wl_bEOF)
            ReDim wl_aePLROP1(0)
            wl_aePLROP1(0) = New moe_Estructuras.ePLROP1
            If wl_bEOF = False Then
                moo_aePLROP1_DT(wl_aePLROP1,
                                wl_DTE1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarPLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_LeeFecIni()
        Try
            wl_dFecIni = Today
            wl_dFecFin = Today
            wl_bYesNo = True
            wl_DTE1 = New DataTable

            wl_eATASI = New moe_Estructuras.eATASI
            wl_eATASI.nAnoSdoIni = vg_nAnoSdoIniInv
            wl_eATASI.sNomTblEnc = "IEDMI"
            wl_DTE1 = clnATASI.cndtConATASI(wl_eATASI,
                                            wl_bYesNo)
            ReDim wl_aeATASI(0)
            wl_aeATASI(0) = New moe_Estructuras.eATASI
            If wl_bYesNo = False Then
                moo_aeATASI_DT(wl_aeATASI,
                               wl_DTE1)
                wl_eATASI = wl_aeATASI(0)
                wl_dFecIni = wl_aeATASI(0).dFecIniAno
            End If

        Catch ex As Exception
            MsgBox("Error : BD_LeeFecIni")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_SdoInvIEDMI_0(ByVal wl_eIEDMI As Object)
        Try
            '2018-08-02
            'Deja en 0s los campos nCosItm, nSdoInv
            wl_sNomtbl = "IEDMI"
            wl_bYesNo = True
            wl_bYesNo = clnIEDMI.cnSdoInvIEDMI_0(wl_eIEDMI,
                                                 wl_sNomtbl)
            wl_bYesNo = True

        Catch ex As Exception
            MsgBox("Error : BD_SdoInvIEDMI_0")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_SdoIniIEDMI(ByVal wl_eATASI As Object)

        Try
            wl_sNomtbl = "IEDMI"
            wl_bYesNo = True
            wl_bYesNo = clnIEDMI.cnSdoIniIEDMI(wl_eATASI,
                                               wl_eIEDMI,
                                               wl_sNomtbl)
            wl_bYesNo = True

        Catch ex As Exception
            MsgBox("Error : BD_SdoIniIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_GLMOV1_GELMOV1()
        Try
            ReDim wl_aeGLMOV1(0)
            ReDim wl_aeGELMOV1(0)
            wl_aeGLMOV1(0) = New moe_Estructuras.eGLMOV1
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            moo_aeGLMOV1_aeGELMOV1(wl_aeGLMOV1,
                                   wl_aeGELMOV1)
        Catch ex As Exception
            MsgBox("Error :  BD_GLMOV1_GELMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            '  Plo_ActivarCmpAct()
            wl_ePEODP = New moe_Estructuras.ePEODP
            vl_sCodDoc = wl_DTE1.Rows(0).Item("sCodDoc")
            vl_nNroDoc = wl_DTE1.Rows(0).Item("nNroDoc")
            wl_ePEODP.sCodDoc = vl_sCodDoc
            wl_ePEODP.nNroDoc = vl_nNroDoc
            BD_BuscarPEODP()
            BD_Var_ePEODP()
            Plo_FrmPEODP_Var()
            wl_sDatCmpE11 = vl_sCodDoc
            wl_sDatCmpE12 = vl_nNroDoc
            vl_sEstOdpIni = wl_ePEODP.sEstOdp
            dgv1.Enabled = True
            dgv_DGV_DT()
            BD_BuscarPLODP4()
            BD_ePLODP4_DT(wl_DTE1)
            BD_Var_ePLODP4()
            Plo_FrmPLODP4_Var()
            Plo_InactivarCmpAct()
            cmdCpa.Enabled = False
            lstCpA.Visible = False
            cmdRecEDP.Enabled = False
            cmdRecInv.Enabled = False
            cmdRecODP.Enabled = False
            mof_ActivarOK(Me)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try

    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarATTIA() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATTIA = New moe_Estructuras.eATTIA
            wr_bEOFE2 = mof_fConATTIA(vl_sCodTipAna,
                                      wl_eATTIA)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATTIA")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATALM() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATALM = New moe_Estructuras.eATALM
            wr_bEOFE2 = mof_fConATALM(vl_sCodAlm,
                                      wl_eATALM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATALM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATANA() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATANA = New moe_Estructuras.eATANA
            wr_bEOFE2 = mof_fConATANA(vl_sCodCIF,
                                      wl_eATANA)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATANA")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATCIF() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCIF = New moe_Estructuras.eATCIF
            wr_bEOFE2 = mof_fConATCIF(vl_sCodCIF,
                                      wl_eATCIF)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCIF")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATOPE() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATOPE = New moe_Estructuras.eATOPE
            wr_bEOFE2 = mof_fConATOPE(vl_sCodOpe,
                                      wl_eATOPE)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATOPE")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPLODP4() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP4(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPLODP4")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarIEDMI() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wr_bEOFE2 = mof_fConIEDMI(vl_sCodItm,
                                      wl_eIEDMI)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarIEDMI")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConSdoILMDI1() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eILDMI1 = New moe_Estructuras.eILDMI1
            wl_DTE2 = New DataTable
            wl_DTE2 = clnIEDMI.cndtConSdoILMDI1(vl_sCodAlm,
                                                vl_sCodItm,
                                                wr_bEOFE2)



        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarIEDMI")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPELIM() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePELIM = New moe_Estructuras.ePELIM
            wr_bEOFE2 = mof_fConPELIM(vl_sCodItm,
                                      wl_ePELIM)
            wl_ePELIMeIEDMI.ePELIM = wl_ePELIM
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPELIM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPEODP() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePEODP = New moe_Estructuras.ePEODP
            ' vl_sCodDoc = cboABODP.SelectedValue
            ' vl_nNroDoc = CLng(txtnNroDoc.Text)
            wr_bEOFE2 = mof_fConPEODP(vl_sCodDoc,
                                      vl_nNroDoc,
                                      Nothing,
                                      wl_ePEODP)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCIF")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "043 BD Cargar"
    Private Sub BD_CargarIEDMI(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)

        Try
            BD_frmIEDMI()
            dgv1.CurrentRow.Cells(wl_CellCod).Value = wg_sSelCon11
            dgv1.CurrentRow.Cells(wl_CellDes).Value = wg_sSelCon12
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
        Catch ex As Exception
            MsgBox("Error :  BD_CargarIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BD_CargarATALM()
        Try
            BD_frmATALM()
        Catch ex As Exception
            MsgBox("Error :  BD_CargarATALM")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_CargarATCIF(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        BD_frmATCIF()
        dgv3.CurrentRow.Cells(wl_CellCod).Value = wg_sSelCon11
        ' dgv3.CurrentRow.Cells(wl_CellDes).Value = wg_sSelCon12
        dgv3.CurrentCell = dgv3.CurrentRow.Cells(wl_CellSig)
    End Sub
    Private Sub BD_CargarATOPE(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        BD_frmATOPE()

    End Sub
    Private Sub BD_ILMOV1_PLODP4()
        Try
            wl_bEOF = False
            wl_bEOF = clnIEINV.cnActILMOV1_PLODP4(wl_ePEODP_PLODP4,
                                                  wl_bEOF)

        Catch ex As Exception
            MsgBox("Error :  BD_ILMOV1_PLODP4")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wg_sTblCon1 = "IEDMI"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> "" Then
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmIEDMIR()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wg_sTblCon1 = "IEDMIR"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> "" Then
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmQ_ePELIM_eIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_ePELIMeIEDMI = New moe_Estructuras.Q_ePELIM_eIEDMI
            wg_sTblCon1 = "PELIM"
            wl_frmLst.wp_ePELIM = New moe_Estructuras.ePELIM
            wl_frmLst.wp_sTxtFrm = "Lista de materiales"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_Q_ePELIM_eIEDMI.ePELIM.sCodItm <> "" Then
                wl_ePELIMeIEDMI = wl_frmLst.wp_Q_ePELIM_eIEDMI
            Else
                mtbsCodItm.Focus()
            End If

        Catch ex As Exception

            MsgBox("Error :  BD_frmIEDMI")
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub BD_frmATALM()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATALM = New moe_Estructuras.eATALM
            wg_sTblCon1 = "ATALM"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATALM.sCodAlm <> "" Then
                wl_eATALM = wl_frmLst.wp_eATALM
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATALM")
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub BD_frmATANA()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATANA = New moe_Estructuras.eATANA
            wg_sTblCon1 = "ATANA"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATANA.sCodAna <> "" Then
                wl_eATANA = wl_frmLst.wp_eATANA
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATANA")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmATCIF()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATCIF = New moe_Estructuras.eATCIF
            wl_frmLst.wp_sTxtFrm = "Consulta " & Me.Name
            wg_sTblCon1 = "ATCIF"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATCIF.sCodCIF <> "" Then
                wl_eATCIF = wl_frmLst.wp_eATCIF
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATCIF")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmATOPE()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATOPE = New moe_Estructuras.eATOPE
            wg_sTblCon1 = "ATOPE"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATOPE.sCodOpe <> "" Then
                wl_eATOPE = wl_frmLst.wp_eATOPE
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATOPE")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmPEODP()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_ePEODP = New moe_Estructuras.ePEODP
            wg_sTblCon1 = "PEODP"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_ePEODP.sCodDoc <> "" Then
                wl_ePEODP = wl_frmLst.wp_ePEODP
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmPEODP")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try

            wl_bYesNo = True

            wl_bYesNo = dgv_Vda_PLODP1()
            If wl_bYesNo = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If

            wp_sCmdSel = "A"
            wl_bYesNo = False
            wr_bEOFE1 = True
            wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
            If wl_bYesNo Then
                wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                Plo_RecalPLODP4()
                BD_Var_ePLODP4()
                Plo_FrmPLODP4_Var()
                Plo_Var_FrmPLODP4()
                BD_ePLODP4_Var()
                wl_bYesNo = BD_ActualizarDetalle4(wp_sCmdSel)
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = ""
                wp_sCodErr = wl_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)

                Plo_InactivarCmpAct()
                mof_ActivarOK(Me)
                cmdOk.Focus()
            Else
                mtbsCodItm.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error :  cmdActualizar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            Dim wl_nVlr As Long

            wp_sCmdSel = "B"
            wl_bYesNo = False
            mof_LmpMsgError()
            If Not Double.TryParse(txtnNroDoc.Text, wl_nVlr) Then
                txtnNroDoc.Focus()
                Exit Sub
            End If



            vl_sCodDoc = cboABODP.SelectedValue
            vl_nNroDoc = CLng(txtnNroDoc.Text)
            wl_sDatCmpE12 = txtnNroDoc.Text
            If txtnNroDoc.Text <> "" Then
                BD_DatPrmTipTbl(wl_sTipTbl)
                wl_sCmpOrdE11 = ""
                wl_sTipOrdE11 = ""
                BD_BuscarPEODP()
                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtnNroDoc.Text
                    wp_sCodErr = wl_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtnNroDoc.Focus()
                Else
                    ' Plo_InactivarCmpBus()
                    BD_Var_ePEODP()
                    vl_sEstOdpIni = wl_ePEODP.sEstOdp
                    Plo_FrmPEODP_Var()
                    mof_fLmpCtrl(Me.dgv1)
                    mof_fLmpCtrl(Me.dgv2)
                    mof_fLmpCtrl(Me.dgv3)
                    dgv_DGV_DT()
                    BD_BuscarPLODP4()
                    BD_ePLODP4_DT(wl_DTE1)
                    BD_Var_ePLODP4()
                    Plo_FrmPLODP4_Var()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    Plo_InactivarCmpBus()
                End If
            End If
            txtnNroDoc.Focus()

        Catch ex As Exception
            MsgBox("Error :  cmdBuscar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Try
            Plo_Var_FrmPEODP()
            BD_ePEODP_Var()
            If wl_ePEODP.sEstOdp <> "1" Then
                wp_nBoxMsg = 0
                wp_sDesMsg = "Estado de la Orden de producción invalido"
                wp_sTitMsg = Me.Text
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                cboABEOP.Focus()
                Exit Sub
            End If


            wp_sCmdSel = "C"
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtnNroDoc.Text <> "" And mtbsCodItm.Text <> "" Then
                BD_DatPrmTipTbl(wl_sTipTbl)
                wl_DTE1 = mof_fConTblE2(wl_sNomTblE1,
                                        wl_sNomCmpE11,
                                        wl_sDatCmpE11,
                                        wl_sTipCmpE11,
                                        wl_sNomCmpE12,
                                        wl_sDatCmpE12,
                                        wl_sTipCmpE12,
                                        wr_bEOFE1)
                If wr_bEOFE1 Then
                    wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                    If wl_bYesNo Then
                        wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                        wl_bYesNo = BD_ActualizarDetalle4(wp_sCmdSel)
                        PloNroSig_APEND()
                        PloNroSig_APLND1()
                        wp_sNomTbl = wl_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = wl_sCodErrOk
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)

                        mof_habTsbCrear()
                        mof_habTsbEliminar()
                        Plo_InactivarCmpAct()
                        mof_ActivarOK(Me)
                        cmdOk.Focus()
                    End If
                Else
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtnNroDoc.Text
                    wp_sCodErr = wl_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtnNroDoc.Focus()

                End If

            End If
            txtnNroDoc.Focus()
        Catch ex As Exception
            MsgBox("Error :  cmdCrear_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            wp_sCmdSel = "E"
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtnNroDoc.Text <> "" Then
                wp_nBoxMsg = 4
                wp_sDesMsg = wl_sDesMsgEli
                wp_sTitMsg = wl_sTitMsgEli
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                If wp_nResMsg = 6 Then
                    BD_DatPrmTipTbl(wl_sTipTbl)
                    wl_sCmpOrdE11 = ""
                    wl_sTipOrdE11 = ""
                    wl_DTE1 = clnConTbl.cndtBuscar(wl_sNomTblE1,
                                                   wl_sNomCmpE11,
                                                   wl_sDatCmpE11,
                                                   wl_sTipCmpE11,
                                                   wl_sCmpOrdE11,
                                                   wl_sTipOrdE11,
                                                   wr_bEOFE1)
                    If Not wr_bEOFE1 Then
                        '        BD_ePEODP_DT(wl_DTE1)
                        wp_sNomTbl = ""
                        wl_bYesNo = mov_VdaODP(vl_sCodDoc,
                                               vl_nNroDoc,
                                               wp_sNomTbl,
                                               wl_bVda)

                        If wl_bVda = True Then



                            wl_bYesNo = clnPEODP.cnEliminar(wl_ePEODP.sCodDoc,
                                                            wl_ePEODP.nNroDoc,
                                                            wl_ePEODP.sCodSer,
                                                            wr_bEOF)
                            If wl_bYesNo Then
                                mof_ActivarBuscar(Me)
                                wp_sNomTbl = wl_sNomTblE1
                                wp_sDatCmp = ""
                                wp_sCodErr = wl_sCodErrOk
                                mof_MsgError(wp_sNomTbl,
                                             wp_sDatCmp,
                                             wp_sCodErr)
                                mof_ActivarOK(Me)
                            Else
                                mtbsCodItm.Focus()
                            End If

                        Else
                            wp_sDatCmp = vl_sCodAlm
                            wp_sCodErr = "10-619"
                            mof_MsgError(wp_sNomTbl,
                                         wp_sDatCmp,
                                         wp_sCodErr)
                            Plo_InactivarCmpAct()
                            mof_ActivarOK(Me)
                            cmdOk.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cmdEliminar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCpa.Click
        Try
            lstCpA.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdCpa_Click")
        End Try

    End Sub
    Private Sub cmdImpFal_Click(sender As System.Object, e As System.EventArgs) Handles cmdImpFal.Click
        Try
            Dim wl_frmPEODP_SelItm As New frmPEODP_SelItm
            wl_frmPEODP_SelItm.wp_bSelItm = True
            wl_frmPEODP_SelItm.ShowDialog()
            vl_bSelItm = wl_frmPEODP_SelItm.wp_bSelItm
            Rpt_ImpFal()
        Catch ex As Exception
            MsgBox("Error :  cmdImpFal_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLstATALM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstATALM.Click
        Try
            BD_frmATALM()
            If wl_eATALM.sCodAlm <> "" Then
                txtsCodAlm.Text = wl_eATALM.sCodAlm
                txtsCodAlm.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdLstATALM_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLstPELIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstPELIM.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmQ_ePELIM_eIEDMI()
            If wl_ePELIMeIEDMI.ePELIM.sCodItm <> "" Then
                mtbsCodItm.Text = wl_ePELIMeIEDMI.ePELIM.sCodItm
                vl_sCodItm = wl_ePELIMeIEDMI.ePELIM.sCodItm
                txtsCodAlm.Text = wl_ePELIMeIEDMI.ePELIM.sCodAlm
                txtsNomItm.Text = wl_ePELIMeIEDMI.sNomItm
                vl_nPreVta = wl_ePELIMeIEDMI.ePELIM.nPreVta
                vl_nPorGto = vg_nPorGto
                vl_nPorIto = vg_nPorIto
                mtbsCodItm.Focus()
            Else

                txtnCanOdp.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdLstPELIM_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLstPEODP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstPEODP.Click
        Try
            BD_frmPEODP()


            If wl_ePEODP.sCodDoc <> "" Then
                cboABODP.SelectedValue = wl_ePEODP.sCodDoc
                txtnNroDoc.Text = wl_ePEODP.nNroDoc
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : cmdLstPEODP_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdRecInv_Click(sender As System.Object, e As System.EventArgs) Handles cmdRecInv.Click
        Try

            BD_LeeFecIni()
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_eIEDMI.sCodItm = mtbsCodItm.Text

            wl_sDesMsgCmd = "Este proceso recalcula los saldos finales. Continua ?"
            wl_sTitMsgCmd = "Recalcular Saldos de Inventarios"
            wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
            wl_eGELMOV1.xsCodItm = mtbsCodItm.Text

            wp_nBoxMsg = 4
            wp_sDesMsg = wl_sDesMsgCmd
            wp_sTitMsg = wl_sTitMsgCmd
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)
            If wp_nResMsg = 6 Then
                BD_SdoInvIEDMI_0(wl_eIEDMI)
                BD_SdoIniIEDMI(wl_eATASI)
                Plo_RecSdoIEDMI(wl_eIEDMI)
                wp_nBoxMsg = 0
                wl_sDesMsgCmd = "Proceso completo"
                wl_sTitMsgCmd = "Fin proceso: Recalcular Saldos de Inventarios"
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                cmdRecODP.Enabled = True
                cmdRecEDP.Enabled = False
                cmdRecInv.Enabled = False
            End If




        Catch ex As Exception
            MsgBox("Error : cmdRecInv_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdRecEDP_Click(sender As System.Object, e As System.EventArgs) Handles cmdRecEDP.Click
        Try

            wl_ePLODP4 = New moe_Estructuras.ePLODP4
            wl_ePEODP_PLODP4 = New moe_Estructuras.ePEODP_PLODP4
            wl_sDesMsgCmd = "Este proceso actualiza los precios de las EDP. Continua ?"
            wl_sTitMsgCmd = "Actualizar los precios de las EDP"

            wp_nBoxMsg = 4
            wp_sDesMsg = wl_sDesMsgCmd
            wp_sTitMsg = wl_sTitMsgCmd
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)
            If wp_nResMsg = 6 Then

                wl_ePEODP_PLODP4.dFecIni = Nothing
                wl_ePEODP_PLODP4.sCodDoc = cboABODP.SelectedValue
                wl_ePEODP_PLODP4.nNroDoc = txtnNroDoc.Text

                BD_ILMOV1_PLODP4()

                wp_nBoxMsg = 0
                wl_sDesMsgCmd = "Proceso completo"
                wl_sTitMsgCmd = "Fin proceso: Actualizar precios de EDP"
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                cmdRecODP.Enabled = False
                cmdRecEDP.Enabled = False
                cmdRecInv.Enabled = True
            End If


        Catch ex As Exception
            MsgBox("Error : cmdRecEDP_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdRecODP_Click(sender As System.Object, e As System.EventArgs) Handles cmdRecODP.Click
        Try
            wl_ePEODP = New moe_Estructuras.ePEODP

            wl_sDesMsgCmd = "Este proceso recalcula los saldos de esta OP. Continua ?"
            wl_sTitMsgCmd = "Recalcular Saldos de OP"

            wp_nBoxMsg = 4
            wp_sDesMsg = wl_sDesMsgCmd
            wp_sTitMsg = wl_sTitMsgCmd
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)
            If wp_nResMsg = 6 Then
                wl_ePEODP.sCodDoc = cboABODP.SelectedValue
                wl_ePEODP.nNroDoc = txtnNroDoc.Text
                wl_ePEODP.dFecIni = dtpFecEmi.Value

                BD_SdoOPPEODP_0(wl_ePEODP)
                Plo_RecSdoPEODP(wl_ePEODP)

                wp_nBoxMsg = 0
                wl_sDesMsgCmd = "Proceso completo"
                wl_sTitMsgCmd = "Fin proceso: Recalcular Saldos de OP"
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                BD_BuscarPLODP4()
                BD_ePLODP4_DT(wl_DTE1)
                BD_Var_ePLODP4()
                Plo_FrmPLODP4_Var()
                cmdRecODP.Enabled = False
                cmdRecEDP.Enabled = True
                cmdRecInv.Enabled = False
            End If

        Catch ex As Exception
            MsgBox("Error : cmdRecODP_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub lstCpa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCpA.SelectedIndexChanged
        Try
            If vl_sEstOdp = "3" Then
                MsgBox("Documento cerrado")
                cmdCancelar.Focus()
                Exit Sub

            End If
            If vl_sEstOdp = "1" Then
                MsgBox("Documento no está liberado")
                lstCpA.Visible = False
                cmdCancelar.Focus()
                Exit Sub

            End If
            Dim wl_aeGEMOV(0) As moe_Estructuras.eGEMOV
            ' Dim wl_aeGLMOV1(0) As moe_Estructuras.eGEMOV
            lstCpA.Visible = False

            If lstCpA.SelectedIndex = 0 Then
                Dim wl_frmGEMOV As New frmPESDM
                Dim wl_sFrmDtn As New frmPESDM
                wl_sFrmDtn.wg_sFrmOri = Me.Name
                ReDim wl_aePEODP(0)
                wl_aePEODP(0) = wl_ePEODP
                wl_sFrmDtn.wp_aePEODP = wl_aePEODP
                wl_sFrmDtn.wp_aePLODP1 = wl_aePLODP1
                wl_sFrmDtn.Show()
            End If
            If lstCpA.SelectedIndex = 1 Then
                Dim wl_frmGEMOV As New frmPEEDP
                Dim wl_sFrmDtn As New frmPEEDP
                wl_sFrmDtn.wg_sFrmOri = Me.Name
                ReDim wl_aePEODP(0)
                wl_aePEODP(0) = wl_ePEODP
                wl_sFrmDtn.wp_aePEODP = wl_aePEODP
                wl_sFrmDtn.wp_aePLODP1 = wl_aePLODP1
                wl_sFrmDtn.Show()
            End If
            If lstCpA.SelectedIndex = 2 Then
                Dim wl_frmGEMOV As New frmPEEDM
                Dim wl_sFrmDtn As New frmPEEDM
                wl_sFrmDtn.wg_sFrmOri = Me.Name
                ReDim wl_aePEODP(0)
                wl_aePEODP(0) = wl_ePEODP
                wl_sFrmDtn.wp_aePEODP = wl_aePEODP
                wl_sFrmDtn.wp_aePLODP1 = wl_aePLODP1
                wl_sFrmDtn.Show()
            End If
            '   cmdBuscar_Click(Nothing,
            '                   Nothing)
        Catch ex As Exception
            MsgBox("Error :  lstCpa_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
   
#Region "070 DGV "
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Try
            dgv_ActualizarDetalle1(wp_sCmdSel)
            dgv_ActualizarDetalle2(wp_sCmdSel)
            dgv_ActualizarDetalle3(wp_sCmdSel)
            dgv_ActualizarDetalle5(wp_sCmdSel)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error :  dgv_ActualizarDetalle")
        End Try
        Return True
    End Function
    Private Function dgv_ActualizarDetalle1(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRowSub As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text
            wl_CtrlDgv = Me.dgv1
            For wl_nRowSub = 0 To dgv1.RowCount - 1
                If dgv1.Rows(wl_nRowSub).Cells("sCodCmt").Value <> Nothing Then
                    If dgv1.Rows(wl_nRowSub).Cells("sCodDoc").Value <> vl_sCodDoc Or
                        dgv1.Rows(wl_nRowSub).Cells("nNroDoc").Value <> vl_nNroDoc Or
                        dgv1.Rows(wl_nRowSub).Cells("sCodSer").Value <> vl_sCodSer Or
                        dgv1.Rows(wl_nRowSub).Cells("sCodItm").Value <> vl_sCodItm Then
                        dgv1.Rows(wl_nRowSub).Cells("sCodDoc").Value = vl_sCodDoc
                        dgv1.Rows(wl_nRowSub).Cells("nNroDoc").Value = vl_nNroDoc
                        dgv1.Rows(wl_nRowSub).Cells("sCodSer").Value = vl_sCodSer
                        dgv1.Rows(wl_nRowSub).Cells("sCodItm").Value = vl_sCodItm
                    End If


                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLODP1 = New moe_Estructuras.ePLODP1
                    moo_ePLODP1_DGV(wl_ePLODP1,
                                    Me.dgv1,
                                    wl_nRowSub)
                    '                  
                    If wl_ePLODP1.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv1.Rows(wl_nRowSub).Visible = True Then
                        If dgv1.Rows(wl_nRowSub).Cells("sCodAlmCns").Value <> Nothing Then
                            wl_bYesNo = clnPEODP.cnCrearActualizarPLODP1(wl_ePLODP1,
                                                                         wr_bEOFL1,
                                                                         wp_sCmdSel)
                        End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPLODP.cnEliminarPLODP1(wl_ePLODP1,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle1")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Function dgv_ActualizarDetalle2(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRowSub As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            wl_CtrlDgv = Me.dgv2
            For wl_nRowSub = 0 To dgv2.RowCount - 1
                If dgv2.Rows(wl_nRowSub).Cells("sCodOpe").Value <> Nothing Then
                    If dgv2.Rows(wl_nRowSub).Cells("sCodDoc").Value <> vl_sCodDoc Or
                            dgv2.Rows(wl_nRowSub).Cells("nNroDoc").Value <> vl_nNroDoc Or
                            dgv2.Rows(wl_nRowSub).Cells("sCodSer").Value <> vl_sCodSer Or
                            dgv2.Rows(wl_nRowSub).Cells("sCodItm").Value <> vl_sCodItm Then
                        dgv2.Rows(wl_nRowSub).Cells("sCodDoc").Value = vl_sCodDoc
                        dgv2.Rows(wl_nRowSub).Cells("nNroDoc").Value = vl_nNroDoc
                        dgv2.Rows(wl_nRowSub).Cells("sCodSer").Value = vl_sCodSer
                        dgv2.Rows(wl_nRowSub).Cells("sCodItm").Value = vl_sCodItm
                    End If


                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLODP2 = New moe_Estructuras.ePLODP2
                    moo_ePLODP2_DGV(wl_ePLODP2,
                                    Me.dgv2,
                                    wl_nRowSub)
                    '                  
                    If wl_ePLODP2.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv2.Rows(wl_nRowSub).Visible = True Then
                        '   If dgv2.Rows(wl_nRow).Cells("nTieOpe").Value <> 0 Then
                        wl_bYesNo = clnPEODP.cnCrearActualizarPLODP2(wl_ePLODP2,
                                                                     wr_bEOFL1,
                                                                     wp_sCmdSel)
                        ' End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPLODP.cnEliminarPLODP2(wl_ePLODP2,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next


        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle2")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Function dgv_ActualizarDetalle3(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRowSub As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            wl_CtrlDgv = Me.dgv3
            For wl_nRowSub = 0 To dgv3.RowCount - 1
                If dgv3.Rows(wl_nRowSub).Cells("sCodCIF").Value <> Nothing Then
                    If dgv3.Rows(wl_nRowSub).Cells("sCodDoc").Value <> vl_sCodDoc Or
        dgv3.Rows(wl_nRowSub).Cells("nNroDoc").Value <> vl_nNroDoc Or
        dgv3.Rows(wl_nRowSub).Cells("sCodSer").Value <> vl_sCodSer Or
        dgv3.Rows(wl_nRowSub).Cells("sCodItm").Value <> vl_sCodItm Then
                        dgv3.Rows(wl_nRowSub).Cells("sCodDoc").Value = vl_sCodDoc
                        dgv3.Rows(wl_nRowSub).Cells("nNroDoc").Value = vl_nNroDoc
                        dgv3.Rows(wl_nRowSub).Cells("sCodSer").Value = vl_sCodSer
                        dgv3.Rows(wl_nRowSub).Cells("sCodItm").Value = vl_sCodItm
                    End If

                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLODP3 = New moe_Estructuras.ePLODP3
                    moo_ePLODP3_DGV(wl_ePLODP3,
                                    Me.dgv3,
                                    wl_nRowSub)
                    '                  
                    If wl_ePLODP3.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv3.Rows(wl_nRowSub).Visible = True Then
                        If dgv3.Rows(wl_nRowSub).Cells("nTasCIF").Value <> 0 Then
                            wl_bYesNo = clnPEODP.cnCrearActualizarPLODP3(wl_ePLODP3,
                                                                         wr_bEOFL1,
                                                                         wp_sCmdSel)
                        End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPLODP.cnEliminarPLODP3(wl_ePLODP3,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle3")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Function dgv_ActualizarDetalle5(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRowSub As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            wl_CtrlDgv = Me.dgv5
            For wl_nRowSub = 0 To dgv5.RowCount - 1
                If dgv5.Rows(wl_nRowSub).Cells("sCodAna").Value <> Nothing Then
                    If dgv5.Rows(wl_nRowSub).Cells("sCodDoc").Value <> vl_sCodDoc Or
dgv5.Rows(wl_nRowSub).Cells("nNroDoc").Value <> vl_nNroDoc Or
dgv5.Rows(wl_nRowSub).Cells("sCodSer").Value <> vl_sCodSer Or
dgv5.Rows(wl_nRowSub).Cells("sCodItm").Value <> vl_sCodItm Then
                        dgv5.Rows(wl_nRowSub).Cells("sCodDoc").Value = vl_sCodDoc
                        dgv5.Rows(wl_nRowSub).Cells("nNroDoc").Value = vl_nNroDoc
                        dgv5.Rows(wl_nRowSub).Cells("sCodSer").Value = vl_sCodSer
                        dgv5.Rows(wl_nRowSub).Cells("sCodItm").Value = vl_sCodItm
                    End If

                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLODP5 = New moe_Estructuras.ePLODP5
                    moo_ePLODP5_DGV(wl_ePLODP5,
                                    Me.dgv5,
                                    wl_nRowSub)
                    '                  
                    If wl_ePLODP5.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv5.Rows(wl_nRowSub).Visible = True Then
                        wl_bYesNo = clnPEODP.cnCrearActualizarPLODP5(wl_ePLODP5,
                                                                     wr_bEOFL1,
                                                                     wp_sCmdSel)
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPLODP.cnEliminarPLODP5(wl_ePLODP5,
                                                                  wr_bEOFL1)
                        End If

                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle5")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdiRow(ByRef wl_CtrlDgv)

        Try
            dgv_AdiRowPEODP(wl_CtrlDgv)
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_AdiRowPEODP(ByRef vl_VlrCtrl As DataGridView)
        Try
            vl_VlrCtrl.Rows.Add()
            vl_VlrCtrl.RowTemplate.Height = wl_RowAlto
            wl_nTab = 0
            wl_nRow = vl_VlrCtrl.CurrentCellAddress.Y
            wl_nCntRow = vl_VlrCtrl.Rows.Count
            vl_VlrCtrl.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            wl_nCntRow = vl_VlrCtrl.Rows.Count - 1
            vl_VlrCtrl.Rows(wl_nCntRow).Cells("sCodDoc").Value = cboABODP.SelectedValue
            vl_VlrCtrl.Rows(wl_nCntRow).Cells("nNroDoc").Value = CInt(txtnNroDoc.Text)
            vl_VlrCtrl.Rows(wl_nCntRow).Cells("sCodSer").Value = cboAPLND1.SelectedValue
            vl_VlrCtrl.Rows(wl_nCntRow).Cells("sCodItm").Value = mtbsCodItm.Text

            If vl_VlrCtrl.Name = "dgv5" Then
                wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nCntRow = wl_CtrlDgv.Rows.Count
                wl_nRow = wl_nCntRow - 1
                wl_nCol = wl_nColIniGrl
                wl_CtrlDgv.CurrentCell = dgv5.Rows(wl_nRow).Cells(wl_nCol)
            End If

        Catch ex As Exception
            MsgBox("Error : dgv_AdiRowPEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV_DT()
        Try
            dgv_DGV1_DT()
            dgv_DGV2_DT()
            dgv_DGV3_DT()
            dgv_DGV5_DT()
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_DGV1_DT()
        Dim wl_nRowSub As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv1

        Try
            ReDim wl_aePLODP1(0)
            wl_aePLODP1(0) = New moe_Estructuras.ePLODP1


            wl_DTL1 = clnPEODP.cndtConsultarPLODP1(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFL1)


            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        dgv_AdiRowPEODP(vl_CtrlDgv)
                        moo_DGV_DTePLODP1(vl_CtrlDgv,
                                          wl_DTL1,
                                          wl_nRowSub)
                        If wl_ePEODP.sEstOdp = "1" Then
                            wl_nRow = wl_nRowSub
                            dgv_Vda_SdoAlm()
                        End If
                        If wl_ePEODP.sEstOdp = "2" Then
                            dgv_Vda_PLODP1()
                        End If
                        If wl_ePEODP.sEstOdp = "5" Then
                            dgv_Vda_SdoAlm()
                            'dgv_Mueve_SdoRes()
                        End If

                    Next
                End With
                moo_aePLODP1_DT(wl_aePLODP1,
                                wl_DTL1)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV2_DT()
        Dim wl_nRowSub As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv2
        Try
            ReDim wl_aePLODP2(0)
            wl_aePLODP2(0) = New moe_Estructuras.ePLODP2
            wl_DTL1 = clnPEODP.cndtConsultarPLODP2(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   Nothing,
                                                   wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv2
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        dgv_AdiRowPEODP(vl_CtrlDgv)
                        moo_DGV_DTePLODP2(vl_CtrlDgv,
                                          wl_DTL1,
                                          wl_nRowSub)
                        'Habilité estas líneas 2018-10-09
                        vl_sCodOpe = vl_CtrlDgv.Rows(wl_nRow).Cells("sCodOpe").Value
                        BD_BuscarATOPE()
                        vl_CtrlDgv.Rows(wl_nRow).Cells("sNomOpe").Value = wl_eATOPE.sNomOpe
                    Next
                End With
                moo_aePLODP2_DT(wl_aePLODP2,
                              wl_DTL1)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV3_DT()
        Dim wl_nRowSub As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv3
        Try
            ReDim wl_aePLODP3(0)
            wl_aePLODP3(0) = New moe_Estructuras.ePLODP3

            wl_DTL1 = clnPEODP.cndtConsultarPLODP3(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv3
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        dgv_AdiRowPEODP(vl_CtrlDgv)
                        moo_DGV_DTePLODP3(vl_CtrlDgv,
                                          wl_DTL1,
                                          wl_nRowSub)
                        'Habilité estas líneas 2018-10-09
                        vl_sCodCIF = vl_CtrlDgv.Rows(wl_nRow).Cells("sCodCIF").Value
                        BD_BuscarATCIF()
                        vl_CtrlDgv.Rows(wl_nRow).Cells("sNomCIF").Value = wl_eATCIF.sNomCIF
                        vl_CtrlDgv.Rows(wl_nRow).Cells("nVlrCIFRea").Value = wl_eATCIF.nVlrCIFRea
                    Next
                End With
                moo_aePLODP3_DT(wl_aePLODP3,
                              wl_DTL1)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV5_DT()
        Dim wl_nRowSub As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv5
        Try
            ReDim wl_aePLODP5(0)
            wl_aePLODP5(0) = New moe_Estructuras.ePLODP5

            wl_DTL1 = clnPEODP.cndtConsultarPLODP5(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv5
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        dgv_AdiRowPEODP(vl_CtrlDgv)
                        moo_DGV_DTePLODP5(vl_CtrlDgv,
                                          wl_DTL1,
                                          wl_nRowSub)

                        vl_sCodTipAna = vl_CtrlDgv.Rows(wl_nRowSub).Cells("sCodTipAna").Value
                        BD_BuscarATTIA()
                        vl_CtrlDgv.Rows(wl_nRowSub).Cells("sNomTipAna").Value = wl_eATTIA.sNomTipAna
                        '    vl_CtrlDgv.Rows(wl_nRow).Cells("sNomCIF").Value = wl_eATCIF.sNomCIF
                    Next
                End With
                moo_aePLODP5_DT(wl_aePLODP5,
                              wl_DTL1)

            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV5_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function dgv1_VdaRow(ByRef wl_bVdaRow) As Boolean
        Try
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then

                '                wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
                '               wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then
                ' wl_bVdaRow = False
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_VdaRow")
            MsgBox(ex.Message)
        End Try
        Return wl_bVdaRow
    End Function
    Private Sub dgv_DGV_DT_PLLIM()
        Try
            vl_sCodDoc = cboABODP.SelectedValue
            vl_nNroDoc = CLng(txtnNroDoc.Text)
            vl_nCanOdp = CDbl(txtnCanOdp.Text)
            vl_sCodItm = mtbsCodItm.Text
            dgv_DGV1_DT_PLFOM1()
            dgv_DGV5_DT_PLFOM5()
            dgv_DGV1_DT_PLLIM1()
            dgv_DGV2_DT_PLLIM2()
            dgv_DGV3_DT_PLLIM3()

        Catch ex As Exception
            MsgBox("Error en: dgv_DGV1_DT_PELIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV1_DT_PLFOM1()
        Dim wl_nRowSub As Integer
        wl_CtrlDgv = Me.dgv1
        vl_sCodItm = mtbsCodItm.Text
        vl_sCodFor = ""
        wr_bEOFL1 = True
        Try
            wl_DTL1 = New DataTable
            wl_DTL1 = clnPELIM.cndtConsultarPLLIM4(vl_sCodItm,
                                                   wr_bEOFL1)



            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                If wl_DTL1.Rows(0).Item("bItmAct") = False Then
                    Exit Sub
                End If
            End If
            wl_CtrlDgv = Me.dgv1
            If Not wr_bEOFL1 Then
                vl_sCodFor = wl_DTL1.Rows(0).Item("sCodCmt")
                wl_DTL1 = New DataTable
                wl_DTL1 = clnPEFOM.cndtConsultarPLFOM1(vl_sCodFor,
                                                       wr_bEOFL1)

                If Not wr_bEOFL1 Then
                    With wl_CtrlDgv
                        wl_nCntRow = 0
                        For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                            If wl_DTL1.Rows(wl_nRowSub).Item("T0.bItmAct") = False Then
                                Continue For
                            End If
                            dgv_AdiRow(wl_CtrlDgv)
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCmt").Value = wl_DTL1.Rows(wl_nRowSub).Item("sCodCmt")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomCmt").Value = wl_DTL1.Rows(wl_nRowSub).Item("sNomItm")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanCmt").Value = wl_DTL1.Rows(wl_nRowSub).Item("nCanCmt")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("sUniMedInv").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.sUniMedInv")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanReq").Value = wl_DTL1.Rows(wl_nRowSub).Item("nCanCmt") * vl_nCanOdp
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanCns").Value = 0
                            'wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value = wl_DTL1.Rows(wl_nRowSub).Item("T2.nPreUni")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value = wl_DTL1.Rows(wl_nRowSub).Item("nCosItm")
                            If wl_DTL1.Rows(wl_nCntRow).Item("T1.sUniMedInv") = "gr" Then
                                wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value = wl_DTL1.Rows(wl_nRowSub).Item("nCosItm") * 1000
                            End If

                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotReq").Value = 0
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotCns").Value = 0
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodAlmCns").Value = wl_DTL1.Rows(wl_nRowSub).Item("sCodAlmCns")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCmtAlt").Value = wl_DTL1.Rows(wl_nRowSub).Item("sCodCmtAlt")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nSdoInv").Value = wl_DTL1.Rows(wl_nRowSub).Item("nSdoInv")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("nSdoAlm").Value = wl_DTL1.Rows(wl_nRowSub).Item("nSdoAlm")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCtaInv").Value = wl_DTL1.Rows(wl_nRowSub).Item("sCtaInv")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndCan").Value = wl_DTL1.Rows(wl_nRowSub).Item("bIndCan")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndCos").Value = wl_DTL1.Rows(wl_nRowSub).Item("bIndCos")
                            wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndLibODP").Value = wl_DTL1.Rows(wl_nRowSub).Item("bIndLibODP")
                            wl_nRow = wl_nCntRow
                            dgv_Vda_SdoAlm()
                            wl_nCntRow = wl_nCntRow + 1

                            'If wl_CtrlDgv.Rows(wl_nRow).Cells("bIndCan").Value = True Then
                            ' If (wl_CtrlDgv.Rows(wl_nRow).Cells("nCanReq").Value - wl_CtrlDgv.Rows(wl_nRow).Cells("nCanCns").Value) > wl_CtrlDgv.Rows(wl_nRow).Cells("nSdoAlm").Value Then
                            ' wl_CtrlDgv.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                            ' End If
                            ' End If
                            ' If wl_CtrlDgv.Rows(wl_nRow).Cells("bIndCos").Value = True Then
                            ' If wl_CtrlDgv.Rows(wl_nRow).Cells("nPreUni").Value <= 0 Then
                            ' wl_CtrlDgv.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red

                            '                            End If
                            '            End If






                        Next
                    End With
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: dgv_DGV1_DT_PLFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV1_DT_PLLIM1()
        Dim wl_nRowSub As Integer
        wl_CtrlDgv = Me.dgv1
        vl_sCodItm = mtbsCodItm.Text

        wr_bEOFL1 = True
        Try
            wl_DTL1 = New DataTable
            wl_DTL1 = clnPELIM.cndtConsultarPLLIM1(vl_sCodItm,
                                                  wr_bEOFL1)
            '   If dgv1.Rows.Count > 0 Then
            'dgv1.Rows.Clear()
            'End If

            If Not wr_bEOFL1 Then
                wl_CtrlDgv = Me.dgv1
                With wl_CtrlDgv
                    wl_nCntRow = 0
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        If wl_DTL1.Rows(wl_nRowSub).Item("T0.bItmAct") = False Then
                            Continue For
                        End If
                        dgv_AdiRow(wl_CtrlDgv)
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCmt").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sCodCmt")), wl_DTL1.Rows(wl_nRowSub).Item("sCodCmt"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomCmt").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sNomItm")), wl_DTL1.Rows(wl_nRowSub).Item("sNomItm"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sUniMedInv").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("T1.sUniMedInv")), wl_DTL1.Rows(wl_nRowSub).Item("T1.sUniMedInv"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanCmt").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("nCanCmt")), wl_DTL1.Rows(wl_nRowSub).Item("nCanCmt"), 0)
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanReq").Value = wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanCmt").Value * vl_nCanOdp
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanCns").Value = 0
                        '  wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("T2.nPreUni")), wl_DTL1.Rows(wl_nRowSub).Item("T2.nPreUni"), 0)
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("nCosItm")), wl_DTL1.Rows(wl_nRowSub).Item("nCosItm"), 0)
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotReq").Value = wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanReq").Value * wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotCns").Value = 0
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodAlmCns").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sCodAlmCns")), wl_DTL1.Rows(wl_nRowSub).Item("sCodAlmCns"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCmtAlt").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sCodCmtAlt")), wl_DTL1.Rows(wl_nRowSub).Item("sCodCmtAlt"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nSdoInv").Value = wl_DTL1.Rows(wl_nRowSub).Item("nSdoInv")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nSdoAlm").Value = wl_DTL1.Rows(wl_nRowSub).Item("nSdoAlm")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCtaInv").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sCtaInv")), wl_DTL1.Rows(wl_nRowSub).Item("sCtaInv"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndCan").Value = wl_DTL1.Rows(wl_nRowSub).Item("bIndCan")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndCos").Value = wl_DTL1.Rows(wl_nRowSub).Item("bIndCos")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndLibODP").Value = wl_DTL1.Rows(wl_nRowSub).Item("bIndLibODP")
                        If wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndCan").Value = True Then
                            If (wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanReq").Value - wl_CtrlDgv.Rows(wl_nCntRow).Cells("nCanCns").Value) > wl_CtrlDgv.Rows(wl_nCntRow).Cells("nSdoAlm").Value Then
                                wl_CtrlDgv.Rows(wl_nCntRow).DefaultCellStyle.ForeColor = Color.Red
                            End If
                        End If
                        If wl_CtrlDgv.Rows(wl_nCntRow).Cells("bIndCos").Value = True Then
                            If wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value <= 0 Then
                                wl_CtrlDgv.Rows(wl_nCntRow).DefaultCellStyle.ForeColor = Color.Red

                            End If
                        End If

                        wl_nCntRow = wl_nCntRow + 1
                        ' wl_CtrlDgv.Rows(wl_nRow).Cells("sCodCmtAlt").Value = wg_DTL1.Rows(wl_nRow).Item("sCodCmtAlt")
                    Next
                End With
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV1_DT_PLLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV2_DT_PLLIM2()
        Dim wl_nRowSub As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        wl_CtrlDgv = Me.dgv2


        Try
            wl_DTL1 = clnPELIM.cndtConsultarPLLIM2(vl_sCodItm,
                                                  wr_bEOFL1)
            wl_CtrlDgv = Me.dgv2
            If dgv2.Rows.Count > 0 Then
                dgv2.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    wl_nCntRow = 0
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        If wl_DTL1.Rows(wl_nRowSub).Item("bItmAct") = False Then
                            Continue For
                        End If
                        dgv_AdiRow(wl_CtrlDgv)
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPosOpe").Value = wl_DTL1.Rows(wl_nRowSub).Item("nPosOpe")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodOpe").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodOpe")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomOpe").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sNomOpe")), wl_DTL1.Rows(wl_nRowSub).Item("sNomOpe"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodCtr")), wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodCtr"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTieOpe").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.nTieOpe")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTieReq").Value = wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTieOpe").Value * vl_nCanOdp
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTieCns").Value = 0
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.nPreUni")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotReq").Value = wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTieReq").Value * wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotCns").Value = wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTieCns").Value * wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPreUni").Value
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPorOpeReq").Value = wl_DTL1.Rows(wl_nRowSub).Item("nPorOpe")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nPorOpeCns").Value = 0
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVrcPorOpe").Value = 0
                        wl_nCntRow = wl_nCntRow + 1
                    Next
                End With
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV2_DT_PLLIM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV3_DT_PLLIM3()
        Dim wl_nRowSub As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        wl_CtrlDgv = Me.dgv3
        Try
            wl_DTL1 = clnPELIM.cndtConsultarPLLIM3(vl_sCodItm,
                                                  wr_bEOFL1)
            If dgv3.Rows.Count > 0 Then
                dgv3.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    wl_nCntRow = 0
                    For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                        If wl_DTL1.Rows(wl_nRowSub).Item("bItmAct") = False Then
                            Continue For
                        End If
                        dgv_AdiRow(wl_CtrlDgv)
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCIF").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodCIF")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomCIF").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("sNomCIF")), wl_DTL1.Rows(wl_nRowSub).Item("sNomCIF"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodCtr").Value = IIf(Not IsDBNull(wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodCtr")), wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodCtr"), "")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrCIFRea").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.nVlrCIFRea")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrReq").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.nTasCIF") * vl_nCanOdp
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrCns").Value = 0
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nTasCIF").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.nTasCIF")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotReq").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrReq").Value * wl_DTL1.Rows(wl_nRowSub).Item("T0.nVlrCIFRea") * wl_DTL1.Rows(wl_nRowSub).Item("T0.nTasCIF")
                        wl_CtrlDgv.Rows(wl_nCntRow).Cells("nVlrTotCns").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrCns").Value * wl_DTL1.Rows(wl_nRowSub).Item("T0.nVlrCIFRea") * wl_DTL1.Rows(wl_nRowSub).Item("T0.nTasCIF")
                        wl_nCntRow = wl_nCntRow + 1

                    Next
                End With
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV3_DT_PLLIM3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV5_DT_PLFOM5()
        Dim wl_nRowSub As Integer

        vl_sCodItm = mtbsCodItm.Text
        vl_sCodFor = ""
        wr_bEOFL1 = True
        Try
            wl_DTL1 = New DataTable
            wl_DTL1 = clnPELIM.cndtConsultarPLLIM4(vl_sCodItm,
                                                   wr_bEOFL1)


            wl_CtrlDgv = Me.dgv5
            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                If wl_DTL1.Rows(0).Item("bItmAct") = False Then
                    Exit Sub
                End If
            End If
            If Not wr_bEOFL1 Then
                vl_sCodFor = wl_DTL1.Rows(0).Item("sCodCmt")
                wl_DTL1 = New DataTable
                wl_DTL1 = clnPEFOM.cndtConsultarPLFOM5(vl_sCodFor,
                                                       wr_bEOFL1)
                wl_CtrlDgv = Me.dgv5
                If Not wr_bEOFL1 Then
                    With wl_CtrlDgv
                        For wl_nRowSub = 0 To wl_DTL1.Rows.Count - 1
                            If wl_DTL1.Rows(wl_nRowSub).Item("bItmAct") = False Then
                                Continue For
                            End If
                            dgv_AdiRow(wl_CtrlDgv)
                            wl_CtrlDgv.Rows(wl_nRowSub).Cells("sCodCmt").Value = vl_sCodFor
                            wl_CtrlDgv.Rows(wl_nRowSub).Cells("sCodAna").Value = wl_DTL1.Rows(wl_nRowSub).Item("T0.sCodAna")
                            wl_CtrlDgv.Rows(wl_nRowSub).Cells("sNomAna").Value = wl_DTL1.Rows(wl_nRowSub).Item("sNomAna")
                            wl_CtrlDgv.Rows(wl_nRowSub).Cells("sDesAna").Value = wl_DTL1.Rows(wl_nRowSub).Item("sDesAna")
                            wl_CtrlDgv.Rows(wl_nRowSub).Cells("sCodTipAna").Value = wl_DTL1.Rows(wl_nRowSub).Item("T2.sCodTipAna")
                            wl_CtrlDgv.Rows(wl_nRowSub).Cells("sNomTipAna").Value = wl_DTL1.Rows(wl_nRowSub).Item("sNomTipAna")
                        Next
                    End With
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: dgv_DGV5_DT_PLFOM5")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_RecalDGV()
        wl_ePLODP4 = New moe_Estructuras.ePLODP4
        dgv_RecalDGV1()
        dgv_RecalDGV2()
        dgv_RecalDGV3()
    End Sub
    Private Sub dgv_RecalDGV1()
        Try
            wl_CtrlDgv = Me.dgv1
            Dim wl_nRowSub As Integer
            Dim wl_nCanReqAnt = 0
            wl_ePLODP4.nVlrTotReqMPD = 0
            wl_ePLODP4.nVlrTotCnsMPD = 0
            If dgv1.Rows.Count > 0 Then
                For wl_nRowSub = 0 To dgv1.Rows.Count - 1
                    If wl_CtrlDgv.Rows(wl_nRowSub).Visible = True Then
                        '   wl_nCanLotStn = wl_ePELIMeIEDMI.ePELIM.nCanLotStn
                        '    vl_sUniMedStn = wl_ePELIMeIEDMI.ePELIM.sUniMedStn
                        '    wl_nCanUniStn = wl_ePELIMeIEDMI.ePELIM.nCanUniStn
                        '    vl_sUniMedInv = wl_ePELIMeIEDMI.ePELIM.sUniMedInv
                        '    wl_sUniMedReq = wl_ePELIMeIEDMI.ePELIM.sUniMedInv
                        wl_nCanLotStn = wl_ePEODP.nCanLotStn
                        vl_sUniMedStn = wl_ePEODP.sUniMedStn
                        wl_nCanUniStn = wl_ePEODP.nCanUniStn
                        vl_sUniMedInv = wl_ePEODP.sUniMedInv
                        wl_sUniMedReq = wl_ePEODP.sUniMedInv
                        wl_nCanReqAnt = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nCanReq").Value

                        wl_nCanOdp = CDbl(txtnCanOdp.Text)
                        vl_sUniMedOdp = cboACUNI.SelectedValue
                        wl_nCanCmt = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nCanCmt").Value
                        wl_sUniMedCmt = wl_CtrlDgv.Rows(wl_nRowSub).Cells("sUniMedInv").Value
                        wl_nCanReq = 0
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nCanReq").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nCanCmt").Value * vl_nCanOdp
                        wl_nCanReq = mof_fCanReq(wl_nCanLotStn,
                                                 vl_sUniMedStn,
                                                 wl_nCanUniStn,
                                                 vl_sUniMedInv,
                                                 vl_nCanOdp,
                                                 vl_sUniMedOdp,
                                                 wl_nCanCmt,
                                                 wl_sUniMedCmt,
                                                 wl_nCanReq,
                                                 wl_sUniMedReq)
                        If wl_nCanReq = 0 Then
                            wl_nCanReq = wl_nCanReqAnt
                        End If

                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nCanReq").Value = wl_nCanReq
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotReq").Value = wl_nCanReq * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nPreUni").Value
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotCns").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nCanCns").Value * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nPreUni").Value
                        wl_ePLODP4.nVlrTotReqMPD = wl_ePLODP4.nVlrTotReqMPD + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotReq").Value
                        wl_ePLODP4.nVlrTotCnsMPD = wl_ePLODP4.nVlrTotCnsMPD + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotCns").Value
                        wl_nRow = wl_nRowSub
                        dgv_Vda_SdoAlm()
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_RecalDGV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_RecalDGV2()
        Try
            wl_ePLODP4.nTotTieReqMOD = 0
            wl_ePLODP4.nTotTieCnsMOD = 0
            wl_ePLODP4.nVlrTotReqMOD = 0
            wl_ePLODP4.nVlrTotCnsMOD = 0

            wl_CtrlDgv = Me.dgv2
            Dim wl_nRowSub As Integer
            If wl_CtrlDgv.Rows.Count > 0 Then
                For wl_nRowSub = 0 To dgv2.Rows.Count - 1
                    If wl_CtrlDgv.Rows(wl_nRowSub).Visible = True Then
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTieReq").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTieOpe").Value * vl_nCanUniOdp
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotReq").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTieReq").Value * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nPreUni").Value
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotCns").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTieCns").Value * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nPreUni").Value
                        wl_ePLODP4.nTotTieReqMOD = wl_ePLODP4.nTotTieReqMOD + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTieReq").Value
                        wl_ePLODP4.nTotTieCnsMOD = wl_ePLODP4.nTotTieCnsMOD + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTieCns").Value
                        wl_ePLODP4.nVlrTotReqMOD = wl_ePLODP4.nVlrTotReqMOD + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotReq").Value
                        wl_ePLODP4.nVlrTotCnsMOD = wl_ePLODP4.nVlrTotCnsMOD + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotCns").Value
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_RecalDGV2")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_RecalDGV3()
        wl_CtrlDgv = Me.dgv3
        Try
            wl_ePLODP4.nTotTasReqCIF = 0
            wl_ePLODP4.nTotTasCnsCIF = 0
            wl_ePLODP4.nVlrTotReqCIF = 0
            wl_ePLODP4.nVlrTotCnsCIF = 0
            vl_nTasCIF = wl_ePEODP.nTieItm

            If wl_ePEODP.nCanUniOdp <> 0 Then
                vl_nTasCIF = wl_ePLODP4.nTotTieReqMOD / wl_ePEODP.nCanUniOdp
            End If

            Dim wl_nRowSub As Integer
            If dgv3.Rows.Count > 0 Then
                For wl_nRowSub = 0 To dgv3.Rows.Count - 1
                    If wl_CtrlDgv.Rows(wl_nRowSub).Visible = True Then
                        '  wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrReq").Value = vl_nCanUniOdp * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nTasCIF").Value
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrReq").Value = vl_nCanUniOdp * vl_nTasCIF
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotReq").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrReq").Value * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrCIFRea").Value
                        wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotCns").Value = wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrCns").Value * wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrCIFRea").Value
                        wl_ePLODP4.nTotTasReqCIF = wl_ePLODP4.nTotTasReqCIF + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrReq").Value
                        wl_ePLODP4.nTotTasCnsCIF = wl_ePLODP4.nTotTasCnsCIF + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrCns").Value
                        wl_ePLODP4.nVlrTotReqCIF = wl_ePLODP4.nVlrTotReqCIF + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotReq").Value
                        wl_ePLODP4.nVlrTotCnsCIF = wl_ePLODP4.nVlrTotCnsCIF + wl_CtrlDgv.Rows(wl_nRowSub).Cells("nVlrTotCns").Value
                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_RecalDGV3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function dgv_Vda_PLODP1() As Boolean
        Try
            Dim wl_nRowSub As Integer

            wl_bYesNo = True

            With dgv1
                For wl_nRowSub = 0 To dgv1.Rows.Count - 1

                    wl_nRow = wl_nRowSub
                    If .Rows(wl_nRowSub).Visible = True Then

                        dgv_Vda_SdoAlm()
                        If cboABEOP.SelectedValue = "2" Or cboABEOP.SelectedValue = "5" Then
                            If cboABEOP.SelectedValue = "2" Then
                                If .Rows(wl_nRowSub).Cells("bIndCan").Value = True Then
                                    'Con saldo Almacén
                                    If (.Rows(wl_nRowSub).Cells("nCanReq").Value - .Rows(wl_nRowSub).Cells("nCanCns").Value) > .Rows(wl_nRowSub).Cells("nSdoAlm").Value Then
                                        .Rows(wl_nRowSub).DefaultCellStyle.ForeColor = Color.Red
                                        If cboABEOP.SelectedValue = "2" And vl_sEstOdpIni = "1" Then
                                            If .Rows(wl_nRowSub).Cells("bIndLibODP").Value = False Then
                                                MsgBox(.Rows(wl_nRowSub).Cells("sCodCmt").Value & " no tiene Saldo del almacén suficiente")
                                                .CurrentCell = .Rows(wl_nRowSub).Cells("sCodAlmCns")
                                                wl_bYesNo = False
                                            End If
                                        End If
                                    End If
                                End If
                            End If

                            'Con saldo Disponible
                            If cboABEOP.SelectedValue = "5" Then


                                If (vl_bIndCanRes = True) Then
                                    If (.Rows(wl_nRowSub).Cells("nCanReq").Value - .Rows(wl_nRowSub).Cells("nCanCns").Value) > .Rows(wl_nRowSub).Cells("nSdoFinDisAlm").Value Then
                                        .Rows(wl_nRowSub).DefaultCellStyle.ForeColor = Color.Red
                                        If cboABEOP.SelectedValue = "5" And vl_sEstOdpIni = "1" Then
                                            If .Rows(wl_nRowSub).Cells("bIndLibODP").Value = False Then
                                                MsgBox(.Rows(wl_nRowSub).Cells("sCodCmt").Value & " no tiene Saldo Disponible del Almacén suficiente")
                                                .CurrentCell = .Rows(wl_nRowSub).Cells("sCodAlmCns")
                                                wl_bYesNo = False
                                            End If
                                        End If
                                    End If
                                End If
                                'Con saldo proyectado
                                If (vl_bIndCanPry = True) Then
                                    If (.Rows(wl_nRowSub).Cells("nCanReq").Value - .Rows(wl_nRowSub).Cells("nCanCns").Value) > .Rows(wl_nRowSub).Cells("nSdoFinPry").Value Then
                                        .Rows(wl_nRowSub).DefaultCellStyle.ForeColor = Color.Red
                                        If cboABEOP.SelectedValue = "2" And vl_sEstOdpIni = "1" Then
                                            If .Rows(wl_nRowSub).Cells("bIndLibODP").Value = False Then
                                                MsgBox(.Rows(wl_nRowSub).Cells("sCodCmt").Value & " no tiene Saldo Proyectado suficiente")
                                                .CurrentCell = .Rows(wl_nRowSub).Cells("sCodAlmCns")
                                                wl_bYesNo = False
                                            End If
                                        End If
                                    End If
                                End If
                                If dgv1.Rows(wl_nRowSub).DefaultCellStyle.ForeColor = Color.Black Then

                                    If .Rows(wl_nRowSub).Cells("bIndCos").Value = True Then
                                        If .Rows(wl_nRowSub).Cells("nPreUni").Value <= 0 Then
                                            .Rows(wl_nRowSub).DefaultCellStyle.ForeColor = Color.Red
                                            MsgBox(vl_CtrlDgv.Rows(wl_nRowSub).Cells("sCodCmt").Value & " no tiene Costo")
                                            '      wl_bYesNo = False
                                            ' wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm")
                                        End If
                                    End If
                                End If

                            End If
                        End If

                    End If
                Next
            End With
        Catch ex As Exception
            MsgBox("Error en: dgv_Vda_PLODP1")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_Vda_SdoAlm()
        Try
            If dgv1.Rows(wl_nRow).Cells("bIndCan").Value = True Then
                'Manejo de Cantidad Requerida con Saldo Normal
                If dgv1.Rows(wl_nRow).Cells("nCanReq").Value > dgv1.Rows(wl_nRow).Cells("nSdoAlm").Value Then
                    dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                Else
                    dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black
                End If
                'Manejo de Cantidad Requerida con Saldo Reservado
                If (vl_bIndCanRes = True) Then
                    If dgv1.Rows(wl_nRow).Cells("nCanReq").Value > dgv1.Rows(wl_nRow).Cells("nSdoFinDisAlm").Value Then
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black
                    End If
                End If
                'Manejo de Cantidad Requerida con Saldo  Proyectado
                If (vl_bIndCanPry = True) Then
                    If dgv1.Rows(wl_nRow).Cells("nCanReq").Value > dgv1.Rows(wl_nRow).Cells("nSdoFinPry").Value Then
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black
                    End If
                End If

            End If
            If dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black Then
                If dgv1.Rows(wl_nRow).Cells("bIndCos").Value = True Then
                    If dgv1.Rows(wl_nRow).Cells("nPreUni").Value <= 0 Then
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: dgv_Vda_Sdo")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_Mueve_SdoRes()
        Try

            Dim wl_nRowSub As Integer

            wl_bYesNo = True

            With dgv1
                For wl_nRowSub = 0 To dgv1.Rows.Count - 1

                    wl_nRow = wl_nRowSub
                    If .Rows(wl_nRowSub).Visible = True Then


                        'dgv_Vda_SdoAlm()

                        .Rows(wl_nRowSub).Cells("nCanResODPAlm").Value = .Rows(wl_nRowSub).Cells("nCanResODPAlm").Value + .Rows(wl_nRowSub).Cells("nCanReq").Value
                        .Rows(wl_nRowSub).Cells("nSdoFinDisAlm").Value = .Rows(wl_nRowSub).Cells("nSdoFinDisAlm").Value - .Rows(wl_nRowSub).Cells("nCanReq").Value



                    End If
                Next
            End With
        Catch ex As Exception
            MsgBox("Error en: dgv_Mueve_SdoRes")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region
#Region "071 DGV Procedimientos del Usuario. Comunes"
    Private Sub dgv_APDGV()
        'Fec_Ult_Mod: 2014.04.20
        Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
        Try
            wg_nColIni = 0
            wg_nColFin = 0
            wl_nColIni = 0
            wl_nColFin = 0

            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nColIni = wg_nColIni
            wl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin
            wl_nTotCol = UBound(wl_aeAPDGV) + 1
            If wl_sCodDgv = "dgv1" Then
                wl_nTotCol1 = wl_nTotCol
                wl_nColFin1 = wl_nColFin
                wl_nColIni1 = wl_nColIni
            End If
            If wl_sCodDgv = "dgv2" Then
                wl_nTotCol2 = wl_nTotCol
                wl_nColFin2 = wl_nColFin
                wl_nColIni2 = wl_nColIni
            End If
            If wl_sCodDgv = "dgv3" Then
                wl_nTotCol3 = wl_nTotCol
                wl_nColFin3 = wl_nColFin
                wl_nColIni3 = wl_nColIni
            End If
            If wl_sCodDgv = "dgv5" Then
                wl_nTotCol5 = wl_nTotCol
                wl_nColFin5 = wl_nColFin
                wl_nColIni5 = wl_nColIni
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_APDGV")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_AvanzaCol()
        'FUA : 2014.10.31
        Dim wl_i As Integer
        Try
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_i = wl_nCol
            For wl_i = wl_nCol To wl_nTotCol - 1
                If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = False Then
                    Continue For
                End If
                If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).ReadOnly = True Then
                    Continue For
                End If
                If wl_i = wl_nTotCol - 1 Then
                    If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = True Then
                        If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).ReadOnly = False Then
                            Exit For
                        Else

                            Continue For
                        End If
                    End If
                End If

                Exit For
            Next
            '    If wl_i > wl_nTotCol - 1 Then
            ' wl_i = wl_nTotCol - 1
            ' End If

            wl_nCol = wl_i
            If wl_nCol > wl_nColFin Then
                wl_bVdaRow = True
                '  wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nRow < wl_nCntRow - 1 Then
                        wl_nRow = wl_nRow + 1
                    Else
                        dgv_AdiRow(wl_CtrlDgv)
                        wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                        wl_nRow = wl_nRow + 1
                    End If
                End If
                wl_nCol = wl_nColIniGrl
            End If
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)

        Catch ex As Exception
            MsgBox("Error :  dgv_AvanzaCol")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConfiguraCol()
        Try
            Dim wl_bCnfVis As Boolean = False
            Dim vl_sNomCmp As String
            Dim vl_sTitCol As String
            wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
            For wp_nC = 0 To wl_nTotCol - 1
                wp_bVisible = True
                wp_bReadOnly = False
                wp_bColxDef = False
                wp_sTipCol = "S"
                wl_eAPDGV = wl_aeAPDGV(wp_nC)
                '  With wl_CtrlDgv
                '.Columns(wp_nC).HeaderText = wl_eAPDGV.sTitCol
                'End With
                With wl_eAPDGV
                    wp_sTipCol = .sTipCol
                    wp_bVisible = .bVisible
                    wp_bReadOnly = .bReadOnly
                    wp_bColxDef = .bColxDef
                    vl_sNomCmp = .sNomCmp
                    vl_nTamCmp = .nTamCmp
                    vl_sTitCol = .sTitCol

                End With
                mof_DGVFormatCol(wl_CtrlDgv,
                                 wp_nC,
                                 wp_sTipCol,
                                 wp_bVisible,
                                 wp_bReadOnly,
                                 vl_sNomCmp,
                                 vl_nTamCmp,
                                 vl_sTitCol)
                If wl_bCnfVis = False Then
                    If wp_bVisible Then
                        If wp_bReadOnly = False Then
                            wl_nColIniGrl = wp_nC
                            wl_nColFinGrl = wp_nC
                            wl_bCnfVis = True
                        End If
                    End If
                End If
                If wl_bCnfVis = True Then
                    If wp_bVisible Then
                        wl_nColFinGrl = wp_nC
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error :  dgv_ConfiguraCol")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_EliminarLinea(ByVal wp_VlrCtrl As DataGridView)
        Dim wl_nRowSub As Integer
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRowSub = (wp_VlrCtrl.Rows.Count).ToString
            wl_nCol = wp_VlrCtrl.CurrentRow.Index
            If wl_nRowSub >= 0 Then
                wp_VlrCtrl.Rows(wl_nCol).Visible = False
                wl_nCol = 0
                For wl_nRowSub = 0 To wp_VlrCtrl.Rows.Count - 1
                    If wp_VlrCtrl.Rows(wl_nRowSub).Visible = True Then
                        wp_VlrCtrl.Rows(wl_nRowSub).HeaderCell.Value = (wl_nCol + 1).ToString
                        wl_nCol = wl_nCol + 1
                    End If
                Next
                wp_VlrCtrl.RefreshEdit()
            End If
            dgv_RecalDGV1()
            cmdActualizar.Focus()

        Catch
            MsgBox("Error: dgv_EliminarLinea")
        End Try

    End Sub
    Private Sub dgv_RetroCol()
        Dim wl_i As Integer
        Try
            wl_i = wl_nColKD - 1
            wl_nCol = wl_i

            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = False Then
                For wl_i = wl_nCol To wl_nColIniGrl Step -1
                    '  wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i)
                    If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = True Then
                        Exit For
                    End If
                Next
                wl_nCol = wl_i
            End If
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i)
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                For wl_i = wl_nCol To wl_nColIniGrl Step -1
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i)
                    If wl_CtrlDgv.CurrentCell.ReadOnly = False Then
                        Exit For
                    End If
                Next
                wl_nCol = wl_i
            End If

            If wl_nCol < wl_nColIniGrl Then
                wl_bVdaRow = True
                wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nRow > 0 Then
                        wl_nRow = wl_nRow - 1
                    Else
                        wl_nRow = wl_nCntRow
                    End If
                End If
                wl_nCol = wl_nColFin
            End If
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)

        Catch ex As Exception
            MsgBox("Error :  dgv_RetrocedeCol")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "072 DGV Controladores de Eventos "
#Region "DGV1 Controladores de Eventos"
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRowAnt = e.RowIndex
            wl_nColAnt = e.ColumnIndex
            wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
        Catch ex As Exception
            MsgBox("Error en: dgv1_CellLeave")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv1.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv1.CurrentCell.ReadOnly = True Then
                dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv1_CellMouseClick")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
        wl_CtrlDgv = dgv1
        wl_sCodDgv = "dgv1"
        If wl_CtrlDgv.Enabled = False Then
            Exit Sub
        End If
        wl_nCol = e.ColumnIndex
        wl_nRow = e.RowIndex
        Try
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nColIni1)
                Exit Sub
            End If

            dgv_APDGV()
            wl_CtrlDgv = dgv1
            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodCmt" Then
                BD_frmIEDMIR()
                If wl_eIEDMI.sCodItm <> "" Then
                    vl_sCodItm = wl_eIEDMI.sCodItm
                    vl_sCodAlm = wl_eIEDMI.sCodAlm
                    wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
                    wl_bEOF = True
                    wl_DTE1 = New DataTable
                    wl_DTE1 = clnIEDMI.cndtConGELDMI1(vl_sCodItm,
                                                      vl_sCodAlm,
                                                      wl_bEOF)

                    If Not wl_bEOF Then
                        moo_eIELDMI1_DT(wl_eIELDMI1,
                                        wl_DTE1,
                                        0)
                        moo_DGVPLODP1_eIELDMI1(wl_CtrlDgv,
                                               wl_eIELDMI1,
                                               wl_nRow)
                    End If
                End If
            End If
            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodAlmCns" Then
                BD_CargarATALM()
                wl_CtrlDgv.Rows(wl_nRow).Cells("sCodAlmCns").Value = wl_eATALM.sCodAlm
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellValueChanged
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try
            wl_CtrlDgv = Me.dgv1
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If

        Catch
            MsgBox("Error : dgv1_CellValueChanged")

        End Try

    End Sub
    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try
            If dgv1.CurrentCellAddress.Y > 0 Then
                If dgv1.CurrentCell.ColumnIndex > wl_nColFin1 Then
                    '     dgv_AdicionarLinea()
                End If
            End If
        Catch
            MsgBox("Error: dgv1_CurrentCellChanged")
            MsgBox(wl_nRow.ToString & " " & wl_nCol.ToString)
        End Try
    End Sub
    Private Sub dgv1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv1.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())



            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv1.CurrentCell = dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv1_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyDown
        Try


            wl_CtrlDgv = Me.dgv1
            If e.KeyCode = Keys.Tab Then
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_KeyDown")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv1.KeyPress
        Try
            wl_CtrlDgv = Me.dgv1
            If e.KeyChar = ChrW(Keys.Tab) Then
                wl_nRowKP = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKP = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKP = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKP = wl_CtrlDgv.CurrentCell.ColumnIndex
            Else
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex

            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_KeyPress")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyUp
        '
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_nTmpCol As Integer
        '   Dim wl_sNomCmp As String


        '  wl_sCod = ""
        '  wl_sNom = ""
        '  wl_nVlr = 0
        '  wl_sDoc = ""
        wl_sNomtbl = ""
        Try
            mof_LmpMsgError()
            '    wl_sNomCmp = wl_eAPDGV.sNomCmp

            wl_CtrlDgv = Me.dgv1
            wl_sCodDgv = "dgv1"
            wl_nTmpCol = wl_nTotCol
            wl_nTotCol = wl_nTotCol1
            wl_nColIni = wl_nColIni1
            wl_nColFin = wl_nColFin1
            wl_nColIniGrl = wl_nColIni1
            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nCntCol = wl_CtrlDgv.ColumnCount
            If e.KeyCode = Keys.Tab Then
                wl_bAva = True
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_bRet = True
            End If
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            If wl_nColAnt < wl_nColIni Then
                wl_nColAnt = wl_nColIni
            End If
            '    wp_nColNom = wl_nColAnt
            '    wp_nColVlr = wl_nColAnt
            wl_bVda = True
            wl_CtrlDgv = Me.dgv1
            wl_sCodDgv = "dgv1"
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)

            mov_dgv_VdaPLODP1(wl_nCol,
                             wl_nColAnt,
                             wl_nColSig,
                             wl_nRow,
                             wl_nRowAnt,
                             wl_nRowSig,
                             wl_CtrlDgv,
                             wl_aeAPDGV,
                             wl_bVda)
            If wl_bVda = False Then


                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nCol)
                Exit Sub
            Else
                mof_LmpMsgError()
            End If

            dgv_Vda_SdoAlm()


            '   If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodCmt" Then
            ' BD_CargarIEDMI(wl_nCol)
            ' End If
            dgv_RecalDGV1()

            '   dgv_TotDoc()
            wl_CtrlDgv = Me.dgv1
            If wl_bAva Then
                dgv_AvanzaCol()
            End If
            If wl_bRet = True Then
                dgv_RetroCol()
            End If
            wl_nTotCol = wl_nTmpCol
        Catch ex As Exception
            MsgBox("Error: dgv1_KeyUp")
            MsgBox(ex.Message)
        End Try



    End Sub
    Private Sub dgv1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCol = dgv1.CurrentCellAddress.X
            wl_nCntRow = dgv1.Rows.Count
            If wl_nRow + 1 = wl_nCntRow Then
                If wl_nColAnt = wl_nColFin1 Then
                    If dgv1.Rows(wl_nRow).Cells(2).Value <> Nothing Then
                        dgv_AdiRow(dgv1)
                        wl_nRow = dgv1.CurrentCellAddress.Y + 1
                        wl_nCol = wl_nColIni1
                        dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                    Else
                        dgv1.CurrentCell = dgv1.Rows(0).Cells(2)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: dgv1_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "DGV2 Controladores de Eventos"
    Private Sub dgv2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellEndEdit
        Try
            If dgv2.Enabled = False Then
                Exit Sub
            End If
            wl_nRowAnt = e.RowIndex
            wl_nColAnt = e.ColumnIndex
            If wl_nColAnt = wl_nTotCol2 - 1 Then
                wl_CtrlDgv = Me.dgv2
                wl_nRow = wl_nRowAnt
                wl_nTotCol = wl_nTotCol2
                wl_nColFin = wl_nColFin2
                wl_nCol = wl_nTotCol2
                wl_nColIniGrl = wl_nColIni2
                wl_nRow = wl_nRowAnt
                dgv_AvanzaCol()
            End If

        Catch ex As Exception
            MsgBox("Error : dgv2_CellEndEdit")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellLeave
        If dgv2.Enabled = False Then
            Exit Sub
        End If
        wl_nRowAnt = e.RowIndex
        wl_nColAnt = e.ColumnIndex
    End Sub
    Private Sub dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseClick
        Try
            If dgv2.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv2.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If

            If dgv2.Enabled = False Then
                Exit Sub
            End If
            If dgv2.CurrentCell.ReadOnly = True Then
                dgv2.CurrentCell = dgv2.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv2_CellMouseClick")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseDoubleClick
        If dgv2.Enabled = False Then
            Exit Sub
        End If
        Try

            wl_nCol = e.ColumnIndex
            wl_nRow = e.RowIndex

            If dgv2.CurrentCell.ReadOnly = True Then
                dgv2.CurrentCell = dgv2.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                Exit Sub
            End If
            wl_sCodDgv = "dgv2"
            dgv_APDGV()



            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodOpe" Then
                BD_CargarATOPE(wl_nCol,
                               wl_nCol,
                               wl_nCol)
                dgv2.Rows(wl_nRow).Cells("sCodOpe").Value = wl_eATOPE.sCodOpe
            End If

            Dim wl_frmLst As New frmGQLst

            If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
                BD_CargarATOPE(2, 3, 4)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv2_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellValueChanged
        If dgv2.Enabled = False Then
            Exit Sub
        End If
        Try
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : dgv2_CellValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellChanged
        If dgv2.Enabled = False Then
            Exit Sub
        End If
        Try
            If dgv2.CurrentCellAddress.Y > 0 Then
                If dgv2.CurrentCell.ColumnIndex > wl_nColFin2 Then
                    '     dgv_AdicionarLinea()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: dgv2_CurrentCellChanged")
            MsgBox(wl_nRow.ToString & " " & wl_nCol.ToString)
        End Try
    End Sub
    Private Sub dgv2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv2.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv2.CurrentCell = dgv2.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv2_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv2.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_nTmpCol As Integer
        wl_sNomtbl = ""
        Try
            mof_LmpMsgError()
            wl_CtrlDgv = Me.dgv2
            wl_sCodDgv = "dgv2"
            wl_nTmpCol = wl_nTotCol
            wl_nTotCol = wl_nTotCol2
            wl_nColIni = wl_nColIni2
            wl_nColFin = wl_nColFin2
            wl_nColIniGrl = wl_nColIni2

            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nCntCol = wl_CtrlDgv.ColumnCount
            If e.KeyCode = Keys.Tab Then
                wl_bAva = True
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_bRet = True
            End If
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            If wl_nColAnt < wl_nColIni Then
                wl_nColAnt = wl_nColIni
            End If
            wl_bVda = True
            wl_CtrlDgv = Me.dgv2
            wl_sCodDgv = "dgv2"
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)

            mov_dgv_VdaPLODP2(wl_nCol,
                              wl_nColAnt,
                              wl_nColSig,
                              wl_nRow,
                              wl_nRowAnt,
                              wl_nRowSig,
                              wl_CtrlDgv,
                              wl_aeAPDGV,
                              wl_bVda)

            If wl_bVda = False Then
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nCol)
                Exit Sub
            Else
                mof_LmpMsgError()
            End If


            If wl_bAva Then
                dgv_AvanzaCol()
            End If
            If wl_bRet = True Then
                dgv_RetroCol()
            End If
            wl_nTotCol = wl_nTmpCol
        Catch ex As Exception
            MsgBox("Error : dgv2_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            wl_nRow = dgv2.CurrentCellAddress.Y
            wl_nCol = dgv2.CurrentCellAddress.X
            wl_nCntRow = dgv2.Rows.Count
            If wl_nRow + 1 = wl_nCntRow Then

                If wl_nColAnt = wl_nColFin2 Then
                    If dgv2.Rows(wl_nRow).Cells(2).Value <> Nothing Then
                        dgv_AdiRow(dgv2)
                        wl_nRow = dgv2.CurrentCellAddress.Y + 1
                        wl_nCol = wl_nColIni2
                        dgv2.CurrentCell = dgv2.Rows(wl_nRow).Cells(wl_nCol)
                    Else
                        dgv2.CurrentCell = dgv2.Rows(0).Cells(2)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : dgv2_Leave")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "DGV3 Controladores de Eventos"
    Private Sub dgv3_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellLeave
        Try
            If dgv3.Enabled = False Then
                Exit Sub
            End If
            wl_nRowAnt = e.RowIndex
            wl_nColAnt = e.ColumnIndex
        Catch ex As Exception
            MsgBox("Error :  dgv3_CellLeave")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv3.CellMouseClick
        Try
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv3.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv3.Enabled = False Then
                Exit Sub
            End If
            If dgv3.CurrentCell.ReadOnly = True Then
                dgv3.CurrentCell = dgv3.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv3_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv3.CellMouseDoubleClick
        Try
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv3.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If

            If dgv3.Enabled = False Then
                Exit Sub
            End If
            If dgv3.CurrentCell.ReadOnly = True Then
                dgv3.CurrentCell = dgv3.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv3_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellValueChanged
        If dgv3.Enabled = False Then
            Exit Sub
        End If
        Try
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : dgv3_CellValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv3_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv3.CurrentCellChanged
        If dgv3.Enabled = False Then
            Exit Sub
        End If
        Try
            If dgv3.CurrentCellAddress.Y > 0 Then
                If dgv3.CurrentCell.ColumnIndex > wl_nColFin3 Then
                    '     dgv_AdicionarLinea()
                End If
            End If
        Catch
            MsgBox("Error: dgv3_CurrentCellChanged")
            MsgBox(wl_nRow.ToString & " " & wl_nCol.ToString)
        End Try
    End Sub
    Private Sub dgv3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv3.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv3.CurrentCell = dgv3.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv3_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv3.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_nTmpCol As Integer
        wl_sNomtbl = ""
        Try
            mof_LmpMsgError()
            wl_CtrlDgv = Me.dgv3
            wl_sCodDgv = "dgv3"
            wl_nTmpCol = wl_nTotCol
            wl_nTotCol = wl_nTotCol3
            wl_nColIni = wl_nColIni3
            wl_nColFin = wl_nColFin3
            wl_nColIniGrl = wl_nColIni3

            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nCntCol = wl_CtrlDgv.ColumnCount
            If e.KeyCode = Keys.Tab Then
                wl_bAva = True
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_bRet = True
            End If
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            If wl_nColAnt < wl_nColIni Then
                wl_nColAnt = wl_nColIni
            End If
            wl_bVda = True
            wl_CtrlDgv = Me.dgv3
            wl_sCodDgv = "dgv3"
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)

            mov_dgv_VdaPLODP3(wl_nCol,
                              wl_nColAnt,
                              wl_nColSig,
                              wl_nRow,
                              wl_nRowAnt,
                              wl_nRowSig,
                              wl_CtrlDgv,
                              wl_aeAPDGV,
                              wl_bVda)

            If wl_bVda = False Then
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nCol)
                Exit Sub
            Else
4:              mof_LmpMsgError()
            End If


            If wl_bAva Then
                dgv_AvanzaCol()
            End If
            If wl_bRet = True Then
                dgv_RetroCol()
            End If
            wl_nTotCol = wl_nTmpCol
        Catch ex As Exception
            MsgBox("Error : dgv3_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv3.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            wl_nRow = dgv3.CurrentCellAddress.Y
            wl_nCol = dgv3.CurrentCellAddress.X
            wl_nCntRow = dgv3.Rows.Count
            If wl_nRow + 1 = wl_nCntRow Then
                If wl_nColAnt = wl_nColFin3 Then
                    If dgv3.Rows(wl_nRow).Cells(2).Value <> Nothing Then
                        dgv_AdiRow(dgv3)
                        wl_nRow = dgv3.CurrentCellAddress.Y + 1
                        wl_nCol = wl_nColIni3
                        dgv3.CurrentCell = dgv3.Rows(wl_nRow).Cells(wl_nCol)
                    Else
                        dgv3.CurrentCell = dgv3.Rows(0).Cells(2)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : dgv3_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "DGV5 Controladores de Eventos"
    Private Sub dgv5_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv5.CellLeave
        '  Stop
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = dgv5.CurrentCell.RowIndex
            wl_nColKD = dgv5.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv5_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv5.CellMouseClick
        Try
            If dgv5.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv5.CurrentCell.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv5.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv5.CurrentCell.ReadOnly = True Then
                dgv5.CurrentCell = dgv5.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv5_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv5.CellMouseDoubleClick
        Try
            If dgv5.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv5.CurrentCell.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If

            If dgv5.Rows.Count > 0 Then
                wl_CtrlDgv = Me.dgv5
                If dgv5.CurrentCell.ReadOnly = True Then
                    dgv5.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If

                wl_nCol = e.ColumnIndex
                wl_nRow = e.RowIndex
                If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
                wl_sCodDgv = "dgv5"
                dgv_APDGV()
                If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodCmt" Then
                    'vl_sCodItm = dgv4.CurrentRow.Cells("sCodCmt").Value
                    wl_bEOF = BD_BuscarATANA()
                    If wl_bEOF Then
                        BD_frmATANA()
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Error :  dgv5_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv5.CellValueChanged
        Try
            wl_CtrlDgv = Me.dgv5
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv5_CellValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv5_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv5.CurrentCellDirtyStateChanged
        Try
            If dgv5.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv5_CurrentCellDirtyStateChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv5.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv5.CurrentCell = dgv5.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv5_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv5.KeyDown
        Try
            wl_CtrlDgv = Me.dgv5
            If e.KeyCode = Keys.Tab Then
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv5_KeyDown")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv5.KeyPress
        Try
            wl_CtrlDgv = Me.dgv5
            If e.KeyChar = ChrW(Keys.Tab) Then
                wl_nRowKP = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKP = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKP = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKP = wl_CtrlDgv.CurrentCell.ColumnIndex
            Else
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex

            End If
        Catch ex As Exception
            MsgBox("Error :  dgv5_KeyPress")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv5.KeyUp

        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_bAdiRow As Boolean = False
        Try
            mof_LmpMsgError()
            wl_CtrlDgv = dgv5
            wl_sCodDgv = "dgv5"
            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCntCol = wl_CtrlDgv.ColumnCount
            wl_nTotCol = wl_nTotCol5
            wl_nColIniGrl = wl_nColIni5
            wl_nColFin = wl_nColFin5
            If sender Is Nothing Then
                wl_bAva = True
                wl_bRet = False
            Else
                If e.KeyCode = Keys.Tab Then
                    wl_bAva = True
                End If
                If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                    wl_bRet = True
                End If
            End If
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)

            mov_dgv_VdaPLODP5(wl_nCol,
                           wl_nColAnt,
                           wl_nColSig,
                           wl_nRow,
                           wl_nRowAnt,
                           wl_nRowSig,
                           wl_CtrlDgv,
                           wl_aeAPDGV,
                           wl_bVda)

            If wl_bAva Then
                If sender Is Nothing Then
                    wl_nCol = wl_nCol + 1
                End If
                wl_bAva = mof_dgvSigCol(wl_nCol,
                                        wl_nRow,
                                        wl_nTotCol,
                                        wl_nColFin,
                                        wl_nColIniGrl,
                                        wl_nCntRow,
                                        dgv5,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRow(dgv5)
                    wl_nRow = dgv5.CurrentCellAddress.Y
                End If
                dgv5.CurrentCell = dgv5.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin,
                                         wl_nColIniGrl,
                                         wl_nCntRow,
                                         dgv5,
                                         wl_nColKD)
                dgv5.CurrentCell = dgv5.Rows(wl_nRow).Cells(wl_nCol)
                dgv5.Focus()
            End If
            wl_nRowAnt = dgv5.CurrentCell.RowIndex
            wl_nColAnt = dgv5.CurrentCell.ColumnIndex

        Catch ex As Exception
            MsgBox("Error: dgv5_KeyUp")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv5.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            wl_nRow = dgv5.CurrentCellAddress.Y
            wl_nCol = dgv5.CurrentCellAddress.X
            wl_nCntRow = dgv5.Rows.Count
            If wl_nRow + 1 = wl_nCntRow Then
                If wl_nColAnt = wl_nColFin5 Then
                    If dgv5.Rows(wl_nRow).Cells(2).Value <> Nothing Then
                        dgv_AdiRow(dgv5)
                        wl_nRow = dgv5.CurrentCellAddress.Y + 1
                        wl_nCol = wl_nColIni5
                        dgv5.CurrentCell = dgv5.Rows(wl_nRow).Cells(wl_nCol)
                    Else
                        dgv5.CurrentCell = dgv5.Rows(0).Cells(wl_nColIni5)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : dgv3_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region
#End Region

#Region "Funciones Locales"

#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActivarCmpAct()
        Try
            wl_bSwsEliLin = True
            wl_bVda1 = True
            wl_bVdaCodItm = False
            cboABODP.Enabled = True
            cboAPLND1.Enabled = True
            txtsNroLot.Enabled = True
            cboABEOP.Enabled = True
            mtbsCodItm.Enabled = True
            txtnCanOdp.Enabled = True
            cboACUNI.Enabled = True
            txtsCodAlm.Enabled = True
            cmdLstPELIM.Enabled = True
            dtpFecEmi.Enabled = True
            dtpFecIni.Enabled = True
            dtpFecFin.Enabled = True
            txtsCmn.Enabled = True
            cmdLstPEODP.Enabled = False
            cmdLstATALM.Enabled = True
            lstCpA.Visible = False
            cmdCpa.Enabled = False
            cmdRecEDP.Enabled = False
            cmdRecInv.Enabled = False
            cmdRecODP.Enabled = False
            If vl_sCodSer = "FM" Then
                txtsNomItm.Enabled = True
            Else
                txtsNomItm.Enabled = False
            End If

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()

            wl_sCodDgv = "dgv2"
            wl_CtrlDgv = Me.dgv2
            dgv_APDGV()
            dgv_ConfiguraCol()

            wl_sCodDgv = "dgv3"
            wl_CtrlDgv = Me.dgv3
            dgv_APDGV()
            dgv_ConfiguraCol()

            wl_sCodDgv = "dgv5"
            wl_CtrlDgv = Me.dgv5
            dgv_APDGV()
            dgv_ConfiguraCol()

        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_ActivarCmpAut()
        Try
            cboABEOP.Enabled = True
            cmdCpa.Enabled = True
            cmdRecEDP.Enabled = False
            cmdRecInv.Enabled = False
            cmdRecODP.Enabled = True
            '   mtbFecIni.Enabled = True
            '     mtbFecFin.Enabled = True



        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAut")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_FrmPEODP_Var()
        Try
            wl_nNroDocAnt = vl_nNroDoc
            txtsNomItm.Text = vl_sNomItm
            cboABODP.SelectedValue = vl_sCodDoc
            cboAPLND1.SelectedValue = vl_sCodSer
            vl_nNroDoc = wl_nNroDocAnt
            txtnNroDoc.Text = vl_nNroDoc
            txtsNroLot.Text = vl_sNroLot
            cboABEOP.SelectedValue = vl_sEstOdp

            mtbsCodItm.Text = vl_sCodItm
            'vl_nCanLotStn
            'vl_sUniMedStn =
            txtnCanUniStn.Text = FormatNumber(vl_nCanUniStn, 2)
            txtnCanOdp.Text = FormatNumber(vl_nCanOdp, 4)
            txtnCanUniOdp.Text = FormatNumber(vl_nCanUniOdp, 2)
            cboACUNI.SelectedValue = vl_sUniMedOdp
            txtsUniMedInv.Text = vl_sUniMedInv
            txtsUniMedInv1.Text = vl_sUniMedInv
            txtnCanUniEdp.Text = FormatNumber(vl_nCanUniEdp, 2)
            txtnTieItm.Text = FormatNumber(vl_nTieItm, 2)
            txtnTotTieOdp.Text = FormatNumber(vl_nTotTieOdp, 2)
            txtnTotTieEdp.Text = FormatNumber(vl_nTotTieEdp, 2)
            txtsCodAlm.Text = vl_sCodAlm

            dtpFecEmi.Text = vl_dFecEmi
            dtpFecIni.Text = vl_dFecIni
            dtpFecFin.Text = vl_dFecFin
            txtsCmn.Text = vl_sCmn


        Catch ex As Exception
            MsgBox("Error : Plo_FrmPEODP_Var")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_FrmPLODP4_Var()
        Try
            'vl_nVrcCan 
            txtnVlrTotReqMPD.Text = FormatCurrency(vl_nVlrTotReqMPD, 2)
            txtnVlrTotCnsMPD.Text = FormatCurrency(vl_nVlrTotCnsMPD, 2)
            txtnVrcTotMPD.Text = FormatCurrency(vl_nVrcTotMPD, 2)
            txtnTotTieReqMOD.Text = FormatNumber(vl_nTotTieReqMOD, 2)
            txtnTotTieCnsMOD.Text = FormatNumber(vl_nTotTieCnsMOD, 2)
            txtnVrcTieMOD.Text = FormatNumber(vl_nVrcTieMOD, 2)
            txtnVlrTotReqMOD.Text = FormatCurrency(vl_nVlrTotReqMOD, 2)
            txtnVlrTotCnsMOD.Text = FormatCurrency(vl_nVlrTotCnsMOD, 2)
            txtnVrcTotMOD.Text = FormatCurrency(vl_nVrcTotMOD, 2)
            txtnTotTasReqCIF.Text = FormatNumber(vl_nTotTasReqCIF, 2)
            txtnTotTasCnsCIF.Text = FormatNumber(vl_nTotTasCnsCIF, 2)
            txtnVrcTasCIF.Text = FormatNumber(vl_nVrcTasCIF, 2)
            txtnVlrTotReqCIF.Text = FormatCurrency(vl_nVlrTotReqCIF, 2)
            txtnVlrTotCnsCIF.Text = FormatCurrency(vl_nVlrTotCnsCIF, 2)
            txtnVrcTotCIF.Text = FormatCurrency(vl_nVrcTotCIF, 2)
            txtnCosTotReq.Text = FormatCurrency(vl_nCosTotReq, 2)
            txtnCosTotCns.Text = FormatCurrency(vl_nCosTotCns, 2)
            txtnVrcCosTot.Text = FormatCurrency(vl_nVrcCosTot, 2)
            txtnTotUniReq.Text = FormatNumber(vl_nTotUniReq, 2)
            txtnTotUniCns.Text = FormatNumber(vl_nTotUniCns, 2)
            txtnVrcUni.Text = FormatNumber(vl_nVrcUni, 2)
            txtnCosUniReq.Text = FormatCurrency(vl_nCosUniReq, 2)
            txtnCosUniCns.Text = FormatCurrency(vl_nCosUniCns, 2)
            txtnVrcCosUni.Text = FormatCurrency(vl_nVrcCosUni, 2)

            txtnPreVta.Text = FormatCurrency(vl_nPreVta, 2)
            txtnPorGto.Text = FormatNumber(vl_nPorGto, 2)
            txtnPorIto.Text = FormatNumber(vl_nPorIto, 2)
            txtnCanUniEdp1.Text = FormatNumber(vl_nCanUniEdp, 2)
            txtnVlrTotCnsMPD1.Text = FormatCurrency(vl_nVlrTotCnsMPD, 0)
            txtnVlrTotCnsMOD1.Text = FormatCurrency(vl_nVlrTotCnsMOD, 0)
            txtnVlrTotCnsCIF1.Text = FormatCurrency(vl_nVlrTotCnsCIF, 0)
            txtnCosTotCns1.Text = FormatCurrency(vl_nCosTotCns, 0)


            wl_nVlrGtoUni = 0
            wl_nVlrUtiBru = 0
            wl_nVlrItoUni = 0
            wl_nVlrUtiNet = 0

            wl_nTotVta = vl_nPreVta * vl_nCanUniEdp

            wl_nVlrGtoUni = vl_nCosUniCns * vl_nPorGto
            If vl_nPreVta <> 0 Then
                wl_nVlrUtiBru = vl_nPreVta - (vl_nCosUniCns + wl_nVlrGtoUni)
                wl_nVlrUtiNet = wl_nVlrUtiBru / (1 + vl_nPorIto)
                wl_nVlrItoUni = wl_nVlrUtiBru - wl_nVlrUtiNet
            Else
                wl_nVlrUtiBru = 0
                wl_nVlrUtiNet = 0
                wl_nVlrItoUni = 0
            End If


            txtnGtoUniCns.Text = FormatCurrency(wl_nVlrGtoUni, 2)
            txtnItoUniCns.Text = FormatCurrency(wl_nVlrItoUni, 2)
            txtnUtiUni.Text = FormatCurrency(wl_nVlrUtiNet, 2)

            txtnGtoTotCns.Text = FormatCurrency(wl_nVlrGtoUni * vl_nCanUniEdp, 0)
            txtnItoTotCns.Text = FormatCurrency(wl_nVlrItoUni * vl_nCanUniEdp, 0)
            txtnUtiTot.Text = FormatCurrency(wl_nVlrUtiNet * vl_nCanUniEdp, 0)
            txtnTotVta.Text = FormatCurrency(wl_nTotVta, 0)

            If vl_nCanUniEdp <> 0 Then
                txtnVlrUniCnsMPD.Text = FormatCurrency(vl_nVlrTotCnsMPD / vl_nCanUniEdp, 0)
                txtnVlrUniCnsMOD.Text = FormatCurrency(vl_nVlrTotCnsMOD / vl_nCanUniEdp, 0)
                txtnVlrUniCnsCIF.Text = FormatCurrency(vl_nVlrTotCnsCIF / vl_nCanUniEdp, 0)
                txtnCosUniCns1.Text = FormatCurrency(vl_nCosUniCns, 2)
            End If


        Catch ex As Exception
            MsgBox("Error : Plo_FrmPLODP4_Var")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_Frm_VarePELIMeIEDMI()
        Try
            mtbsCodItm.Text = vl_sCodItm
            txtsCodAlm.Text = vl_sCodAlm
            txtsNomItm.Text = vl_sNomItm
            txtnCanUniStn.Text = FormatNumber(vl_nCanUniStn, 2)
            txtnTieItm.Text = FormatNumber(vl_nTieItm, 2)
            txtsUniMedInv.Text = vl_sUniMedInv
            txtsUniMedInv1.Text = vl_sUniMedInv
            txtnPreVta.Text = FormatNumber(vl_nPreVta, 0)
            txtnPorGto.Text = FormatNumber(vl_nPorGto, 2)
            txtnPorIto.Text = FormatNumber(vl_nPorIto, 2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eIEDMI")
        End Try

    End Sub
    Private Sub Plo_InactivarCmpAct()
        Try
            wl_bSwsEliLin = False
            wl_bVda1 = False
            wl_bVdaCodItm = False
            cboABODP.Enabled = False
            cboAPLND1.Enabled = False
            txtsNroLot.Enabled = False
            cboABEOP.Enabled = False
            mtbsCodItm.Enabled = False
            txtsNomItm.Enabled = False
            txtnCanOdp.Enabled = False
            cboACUNI.Enabled = False
            txtsCodAlm.Enabled = False
            cmdLstPELIM.Enabled = False
            dtpFecEmi.Enabled = False
            dtpFecIni.Enabled = False
            dtpFecFin.Enabled = False
            txtsCmn.Enabled = False
            cmdLstPEODP.Enabled = False
            cmdLstATALM.Enabled = False
            lstCpA.Visible = False
            cmdCpa.Enabled = False
            cmdRecEDP.Enabled = False
            cmdRecInv.Enabled = False
            cmdRecODP.Enabled = False

            For wl_i = 0 To dgv1.Rows.Count - 1
                dgv1.Rows(wl_i).ReadOnly = True
                dgv1.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
            For wl_i = 0 To dgv2.Rows.Count - 1
                dgv2.Rows(wl_i).ReadOnly = True
                dgv2.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next

            For wl_i = 0 To dgv3.Rows.Count - 1
                dgv3.Rows(wl_i).ReadOnly = True
                dgv3.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
            For wl_i = 0 To dgv5.Rows.Count - 1
                dgv5.Rows(wl_i).ReadOnly = True
                dgv5.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
            dgv1.Select()
            cmdOk.Focus()
        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactivarCmpBus()
        Try
            txtnNroDoc.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpBus")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactOP_1()
        Try

            cboABODP.Enabled = False
            cboAPLND1.Enabled = False
            mtbsCodItm.Enabled = False
            txtnNroDoc.Enabled = False
            'cmdRecEDP.Enabled = False
            'cmdRecInv.Enabled = False
            'cmdRecODP.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactOP_1")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_IniciarEst()
        Try
            wl_ePEODP = New moe_Estructuras.ePEODP
            wl_ePLODP1 = New moe_Estructuras.ePLODP1
            wl_ePLODP2 = New moe_Estructuras.ePLODP2
            wl_ePLODP3 = New moe_Estructuras.ePLODP3
            wl_ePELIM = New moe_Estructuras.ePELIM
            wl_ePLLIM1 = New moe_Estructuras.ePLLIM1
            wl_ePLLIM2 = New moe_Estructuras.ePLLIM2
            wl_ePLLIM3 = New moe_Estructuras.ePLLIM3
            ' ReDim vl_aePLODP1(0)
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmPEODP"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "ODP"
            vl_sTipMov = " "
            vl_sClsDoc = "DP"
            wl_ePEODP.sCodDoc = vl_sCodDoc
            wl_ePEODP.sClsDoc = vl_sClsDoc
            wl_ePEODP.sCodUsr = vg_sNomUsr
            wl_ePEODP.dFecSys = Date.Today

            wl_bSwsCbo = False
            wl_bSwsCboABODP = False

            ' Plo_LeeAPEND()

        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarSer()
        Try
            Plo_LeeAPLND1()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarSer")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarVar()
        Try

            wl_bYesNo = False
            wl_bEdit = False
            wl_sCodErrAdi = "10-319"
            wl_sCodErrCon = "10-119"
            wl_sCodErrOk = "20-001"
            wl_sDesMsgEli = "Este opción elimina el documento. ¿ Continua ?"
            wl_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wl_sCmpTSB = "sCodItm"
            wl_sDatTSB = ""

            ' vl_sCodDoc = cboABODP.SelectedValue


            dtpFecEmi.Value = Date.Today
            dtpFecEmi.Format = DateTimePickerFormat.Custom
            dtpFecEmi.CustomFormat = "yyyy-MM-dd"
            dtpFecIni.Value = Date.Today
            dtpFecIni.Format = DateTimePickerFormat.Custom
            dtpFecIni.CustomFormat = "yyyy-MM-dd"
            dtpFecFin.Value = Date.Today
            dtpFecFin.Format = DateTimePickerFormat.Custom
            dtpFecFin.CustomFormat = "yyyy-MM-dd"


            wl_ePEODP.sCodDoc = vl_sCodDoc
            wl_ePEODP.sClsDoc = vl_sClsDoc
            wl_ePEODP.nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)

            mof_ActivarCrear(Me)
            '        Plo_LeeAPEND()

            vl_sNroLot = ""
            vl_sEstOdp = "1"
            vl_sEstOdpIni = ""
            vl_sCodItm = ""
            vl_nCanLotStn = 0
            vl_sUniMedStn = ""
            vl_nCanUniStn = 0
            vl_nCanOdp = 1
            vl_nCanUniOdp = 0
            cboACUNI.SelectedValue = "Kg"
            If cboACUNI.SelectedIndex > -1 Then
                vl_sUniMedOdp = cboACUNI.SelectedValue
            Else
                vl_sUniMedOdp = ""
            End If

            vl_sUniMedInv = ""
            vl_nCanUniEdp = 0
            vl_nTieItm = 0
            vl_nTotTieOdp = 0
            vl_nTotTieEdp = 0
            vl_sCodAlm = ""
            vl_dFecEmi = dtpFecEmi.Value.ToShortDateString
            vl_dFecIni = dtpFecIni.Value.ToShortDateString
            vl_dFecFin = dtpFecFin.Value.ToShortDateString


            vl_dFecSys = Date.Today
            vl_sCodUsr = vg_sCodUsr

            vl_nVrcCan = 0
            vl_nVlrTotReqMPD = 0
            vl_nVlrTotCnsMPD = 0
            vl_nVrcTotMPD = 0
            vl_nTotTieReqMOD = 0
            vl_nTotTieCnsMOD = 0
            vl_nVrcTieMOD = 0
            vl_nVlrTotReqMOD = 0
            vl_nVlrTotCnsMOD = 0
            vl_nVrcTotMOD = 0
            vl_nTotTasReqCIF = 0
            vl_nTotTasCnsCIF = 0
            vl_nVrcTasCIF = 0
            vl_nVlrTotReqCIF = 0
            vl_nVlrTotCnsCIF = 0
            vl_nVrcTotCIF = 0
            vl_nCosTotReq = 0
            vl_nCosTotCns = 0
            vl_nVrcCosTot = 0
            vl_nTotUniReq = 0
            vl_nTotUniCns = 0
            vl_nVrcUni = 0
            vl_nCosUniReq = 0
            vl_nCosUniCns = 0
            vl_nVrcCosUni = 0

            vl_nPreVta = 0
            vl_nPorGto = vg_nPorGto
            vl_nPorIto = vg_nPorIto

            wl_nTab = 0
            txtnCanOdp.Text = 1
            txtnCanUniOdp.Text = 0
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVarDGV()
        'Fec_Ult_Mod: 2014.04.29
        'dgv
        Try
            wl_nTab = 0
            wl_nRowVacia = 7
            wl_nColAnt = wl_nColIniGrl
            wl_nRowAnt = 0
            'Plo_SelDGV(wl_nNroDgv)

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()


            wl_sCodDgv = "dgv2"
            wl_CtrlDgv = Me.dgv2
            dgv_APDGV()
            mof_ConfigurarDGV(wl_CtrlDgv,
                             wl_nTotCol)
            dgv_ConfiguraCol()

            wl_sCodDgv = "dgv3"
            wl_CtrlDgv = Me.dgv3
            dgv_APDGV()
            mof_ConfigurarDGV(Me.dgv3,
                                 wl_nTotCol)
            dgv_ConfiguraCol()


            wl_sCodDgv = "dgv5"
            wl_CtrlDgv = Me.dgv5
            dgv_APDGV()
            mof_ConfigurarDGV(Me.dgv5,
                                 wl_nTotCol)
            dgv_ConfiguraCol()



        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_RecalPLODP4()
        Try

            If vl_nCanLotStn <> 0 Then
                If vl_sUniMedOdp = "U" Then
                    vl_nCanUniOdp = vl_nCanOdp
                Else
                    vl_nCanUniOdp = (vl_nCanOdp * vl_nCanUniStn) / vl_nCanLotStn
                End If
            Else
                vl_nCanUniOdp = vl_nCanOdp
            End If

            wl_ePEODP.nCanOdp = vl_nCanOdp
            wl_ePEODP.nCanUniOdp = vl_nCanUniOdp

            wl_ePLODP4.nCanOdp = vl_nCanOdp
            wl_ePLODP4.nCanUniOdp = vl_nCanUniOdp
            wl_ePLODP4.nCanUniEdp = vl_nCanUniEdp

            wl_ePLODP4.nTotUniReq = vl_nCanUniOdp
            wl_ePLODP4.nTotUniCns = wl_ePLODP4.nCanUniEdp

            wl_ePLODP4.nCosTotReq = wl_ePLODP4.nVlrTotReqMPD + wl_ePLODP4.nVlrTotReqMOD + wl_ePLODP4.nVlrTotReqCIF
            wl_ePLODP4.nCosTotCns = wl_ePLODP4.nVlrTotCnsMPD + wl_ePLODP4.nVlrTotCnsMOD + wl_ePLODP4.nVlrTotCnsCIF

            If wl_ePLODP4.nCanUniOdp <> 0 Then
                wl_ePLODP4.nCosUniReq = wl_ePLODP4.nCosTotReq / wl_ePLODP4.nCanUniOdp
            Else
                wl_ePLODP4.nCosUniReq = 0
            End If
            If wl_ePLODP4.nCanUniEdp <> 0 Then
                wl_ePLODP4.nCosUniCns = wl_ePLODP4.nCosTotCns / wl_ePLODP4.nCanUniEdp
            Else
                wl_ePLODP4.nCosUniCns = 0
            End If
            wl_ePLODP4.nPreVta = vl_nPreVta
            wl_ePLODP4.nPorGto = vl_nPorGto
            wl_ePLODP4.nPorIto = vl_nPorIto

            wl_ePLODP4.nVrcCan = wl_ePLODP4.nCanUniEdp - wl_ePLODP4.nCanUniOdp
            vl_nVrcCan = wl_ePLODP4.nCanUniEdp - wl_ePLODP4.nCanUniOdp
            wl_ePLODP4.nVrcTotMPD = wl_ePLODP4.nVlrTotCnsMPD - wl_ePLODP4.nVlrTotReqMPD
            wl_ePLODP4.nVrcTieMOD = wl_ePLODP4.nTotTieCnsMOD - wl_ePLODP4.nTotTieReqMOD
            wl_ePLODP4.nVrcTotMOD = wl_ePLODP4.nVlrTotCnsMOD - wl_ePLODP4.nVlrTotReqMOD
            wl_ePLODP4.nVrcTasCIF = wl_ePLODP4.nTotTasCnsCIF - wl_ePLODP4.nTotTasReqCIF
            wl_ePLODP4.nVrcTotCIF = wl_ePLODP4.nVlrTotCnsCIF - wl_ePLODP4.nVlrTotReqCIF
            wl_ePLODP4.nVrcCosTot = wl_ePLODP4.nCosTotCns - wl_ePLODP4.nCosTotReq
            wl_ePLODP4.nVrcUni = wl_ePLODP4.nTotUniCns - wl_ePLODP4.nTotUniReq
            wl_ePLODP4.nVrcCosUni = wl_ePLODP4.nCosUniCns - wl_ePLODP4.nCosUniReq
            wl_ePEODP.nTotTieOdp = (vl_nCanUniOdp * vl_nTieItm) / 60
            wl_ePEODP.nTotTieEdp = (vl_nCanUniEdp * vl_nTieItm) / 60
            vl_nTotTieOdp = wl_ePEODP.nTotTieOdp
            vl_nTotTieEdp = wl_ePEODP.nTotTieEdp

        Catch ex As Exception
            MsgBox("Error : Plo_RecalPLODP4")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_RecSdoPEODP(ByVal wl_ePEODP As Object)
        Try
            ReDim wl_aePEODP(0)
            wl_aePEODP(0) = New moe_Estructuras.ePEODP
            vl_sCodDoc = ""
            vl_nNroDoc = 0
            vl_sEstOdp = ""

            vl_sCodDoc = wl_epeodp.sCodDoc
            vl_nNroDoc = wl_epeodp.nNroDoc

            mof_Funciones.mof_CargarPEODP(vl_sCodDoc,
                          vl_nNroDoc,
                          vl_sEstOdp,
                          vl_dFecEmi,
                          wl_bEOF,
                          wl_aePEODP)



            For wl_nI = 0 To wl_aePEODP.Count - 1
                vl_sCodDoc = wl_aePEODP(wl_nI).sCodDoc
                vl_nNroDoc = wl_aePEODP(wl_nI).nNroDoc

                If vl_sCodDoc = "" Then
                    Continue For
                End If
                wl_sNomtbl = "ILMOV1"
                wl_sNomCmp = "sCodDocBas"
                wl_sDatCmp = vl_sCodDoc
                wl_sTipCmp = "S"
                wl_sCmpOrd = "sCodDocBas"
                wl_sTipOrd = ""
                wl_sNomCmp1 = "nNroDocBas"
                wl_sDatCmp1 = vl_nNroDoc
                wl_sTipCmp1 = "N"
                wl_sCmpOrd1 = "nNroDocBas"
                wl_sTipOrd1 = ""
                wl_sCmdSel = "A"

                BD_CargarGLINV1()

                For wl_nJ = 0 To wl_aeGLMOV1.Count - 1
                    wl_bYesNo = False

                    wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                    wl_eGLMOV1 = wl_aeGLMOV1(wl_nJ)
                    vl_sCodDoc = wl_eGLMOV1.sCodDoc
                    vl_nNroDoc = wl_eGLMOV1.nNroDoc


                    If vl_sCodDoc = "" Then
                        Continue For
                    End If
                    If wl_eGLMOV1.sCodDoc = "EDM" Or
                        wl_eGLMOV1.sCodDoc = "SDM" Then
                        wl_bEOF = True
                        clnPEODP.cnActCnsPLODP1(wl_eGLMOV1,
                                                wl_bEOF,
                                                wl_sCmdSel)
                        clnPEODP.cnActCnsMPDPLODP4(wl_eGLMOV1,
                                                   wl_bEOF,
                                                   wl_sCmdSel)
                        clnPEODP.cnRecalPLODP4(wl_eGLMOV1.sCodDocBas,
                                               wl_eGLMOV1.nNroDocBas)
                    End If
                    If wl_eGLMOV1.sCodDoc = "EDP" Or
                         wl_eGLMOV1.sCodDoc = "SDP" Then
                        wl_bEOF = True
                        clnPEODP.cnActEDPPEODP(wl_eGLMOV1,
                                               wr_bEOFL1,
                                               wp_sCmdSel)
                        clnPEODP.cnActEDPPLODP4(wl_eGLMOV1,
                                                wl_bEOF,
                                                wl_sCmdSel)
                        clnPEODP.cnRecalPLODP4(wl_eGLMOV1.sCodDocBas,
                                               wl_eGLMOV1.nNroDocBas)

                    End If
                Next


                BD_CargarPLROP1()
                For wl_nJ = 0 To wl_aePLROP1.Count - 1
                    wl_bEOF = True
                    wl_bYesNo = False
                    wl_ePLROP1 = New moe_Estructuras.ePLROP1
                    wl_ePLROP1 = wl_aePLROP1(wl_nJ)
                    vl_sCodDoc = wl_ePLROP1.sCodDoc
                    vl_nNroDoc = wl_ePLROP1.nNroDoc
                    If vl_sCodDoc = "" Then
                        Continue For
                    End If
                    clnPEODP.cnActCnsPLODP2(wl_ePLROP1,
                                wl_bEOF,
                                wl_sCmdSel)
                    clnPEODP.cnActCnsMODPLODP4(wl_ePLROP1,
                                               wl_bEOF,
                                               wl_sCmdSel)
                    clnPEODP.cnActCnsPLODP3(wl_ePLROP1,
                                            wl_bEOF,
                                            wl_sCmdSel)
                    clnPEODP.cnActCnsCIFPLODP4(wl_ePLROP1,
                                               wl_bEOF,
                                               wl_sCmdSel)
                    clnPEODP.cnRecalPLODP4(wl_ePLROP1.sCodDocBas,
                                           wl_ePLROP1.nNroDocBas)
                    clnPEODP.cnActPorOpeCnsPLODP2(wl_ePLROP1,
                                                  wl_bEOF)
                Next
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_RecSdoPEODP")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_Var_FrmPEODP()
        Try
            vl_sCodDoc = cboABODP.SelectedValue
            vl_nNroDoc = CLng(txtnNroDoc.Text)
            vl_sCodSer = cboAPLND1.SelectedValue
            vl_sNroLot = txtsNroLot.Text
            vl_sEstOdp = cboABEOP.SelectedValue
            vl_sCodItm = mtbsCodItm.Text
            vl_sNomItm = txtsNomItm.Text

            If vl_nCanLotStn = 0 Then
                vl_nCanLotStn = 100
                vl_nCanUniStn = 100
            End If
            If vl_sUniMedStn = "" Then
                vl_sUniMedStn = "Kg"
            End If

            'vl_nCanLotStn
            'vl_sUniMedStn =
            vl_nCanUniStn = CDbl(txtnCanUniStn.Text)
            vl_nCanOdp = CDbl(txtnCanOdp.Text)
            vl_nCanUniOdp = CDbl(txtnCanUniOdp.Text)
            If vl_nCanUniOdp = 0 Then
                'vl_nCanUniStn = 100

                txtnCanUniStn.Text = FormatNumber(vl_nCanUniStn, 2)
                vl_nCanUniOdp = vl_nCanUniStn * vl_nCanOdp
                txtnCanUniOdp.Text = FormatNumber(vl_nCanUniOdp, 2)
            End If

            '  End If
            vl_sUniMedOdp = cboACUNI.SelectedValue
            '  vl_sUniMedInv =
            If txtnCanUniEdp.Text = "" Then
                txtnCanUniEdp.Text = 0
            End If
            vl_nCanUniEdp = CDbl(txtnCanUniEdp.Text)
            If txtnTieItm.Text = "" Then
                txtnTieItm.Text = 0
            End If
            vl_nTieItm = CDbl(txtnTieItm.Text)
            If txtnTotTieOdp.Text = "" Then
                txtnTotTieOdp.Text = 0
            End If
            vl_nTotTieOdp = CDbl(txtnTotTieOdp.Text)
            If txtnTotTieEdp.Text = "" Then
                txtnTotTieEdp.Text = 0
            End If
            vl_nTotTieEdp = CDbl(txtnTotTieEdp.Text)
            vl_sCodAlm = txtsCodAlm.Text
            vl_dFecEmi = dtpFecEmi.Value.ToShortDateString
            vl_dFecIni = dtpFecIni.Value.ToShortDateString
            vl_dFecFin = dtpFecFin.Value.ToShortDateString

            vl_dFecSys = Date.Today
            vl_sCodUsr = vg_sCodUsr
            vl_sCmn = txtsCmn.Text
        Catch ex As Exception
            MsgBox("Error : Plo_Var_FrmPEODP")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_Var_FrmPLODP4()
        Try
            'vl_nVrcCan 
            vl_nVlrTotReqMPD = CDbl(txtnVlrTotReqMPD.Text)
            vl_nVlrTotCnsMPD = CDbl(txtnVlrTotCnsMPD.Text)
            vl_nVrcTotMPD = CDbl(txtnVrcTotMPD.Text)
            vl_nTotTieReqMOD = CDbl(txtnTotTieReqMOD.Text)
            vl_nTotTieCnsMOD = CDbl(txtnTotTieCnsMOD.Text)
            vl_nVrcTieMOD = CDbl(txtnVrcTieMOD.Text)
            vl_nVlrTotReqMOD = CDbl(txtnVlrTotReqMOD.Text)
            vl_nVlrTotCnsMOD = CDbl(txtnVlrTotCnsMOD.Text)
            vl_nVrcTotMOD = CDbl(txtnVrcTotMOD.Text)
            vl_nTotTasReqCIF = CDbl(txtnTotTasReqCIF.Text)
            vl_nTotTasCnsCIF = CDbl(txtnTotTasCnsCIF.Text)
            vl_nVrcTasCIF = CDbl(txtnVrcTasCIF.Text)
            vl_nVlrTotReqCIF = CDbl(txtnVlrTotReqCIF.Text)
            vl_nVlrTotCnsCIF = CDbl(txtnVlrTotCnsCIF.Text)
            vl_nVrcTotCIF = CDbl(txtnVrcTotCIF.Text)
            vl_nCosTotReq = CDbl(txtnCosTotReq.Text)
            vl_nCosTotCns = CDbl(txtnCosTotCns.Text)
            vl_nVrcCosTot = CDbl(txtnVrcCosTot.Text)
            vl_nTotUniReq = CDbl(txtnTotUniReq.Text)
            vl_nTotUniCns = CDbl(txtnTotUniCns.Text)
            vl_nVrcUni = CDbl(txtnVrcUni.Text)
            vl_nCosUniReq = CDbl(txtnCosUniReq.Text)
            vl_nCosUniCns = CDbl(txtnCosUniCns.Text)
            vl_nVrcCosUni = CDbl(txtnVrcCosUni.Text)
            vl_nPreVta = CDbl(txtnPreVta.Text)
            vl_nPorGto = CDbl(txtnPorGto.Text)
            vl_nPorIto = CDbl(txtnPorIto.Text)
        Catch ex As Exception
            MsgBox("Error : Plo_Var_FrmPLODP4")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_RecSdoIEDMI(ByVal wl_eIEDMI)
        Try
            wl_bEOF = True
            wl_sNomtbl = "IEMOV"
            vl_sCodItm = ""
            If wl_eIEDMI.sCodItm <> "" Then
                vl_sCodItm = wl_eIEDMI.sCodItm
            End If


            mof_Funciones.mof_CargarGELMOV1(wl_dFecFin,
                                            wl_bEOF,
                                            wl_eATASI,
                                            wl_eIEDMI,
                                            wL_aeGELMOV1)
            BD_GLMOV1_GELMOV1()

            wl_sNomtbl = "ILMOV1"

            For wl_nJ = 0 To wl_aeGLMOV1.Count - 1
                wl_bYesNo = False
                wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                wl_eGLMOV1 = wl_aeGLMOV1(wl_nJ)
                wl_bYesNo = cnf.cnf_ActSdoInv(wl_eGLMOV1)
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_RecSdoIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarCrear()
        Try
            wl_bVda1 = True
            wl_bVdaCodItm = False

            mof_ActivarCrear(Me)
            Cbo_CargarLst()
            Plo_IniciarFrm()
            Plo_IniciarVar()
            dgv1.Select()
            cmdLstPEODP.Enabled = False
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()
            wl_CtrlDgv.Rows.Clear()
            dgv_AdiRowPEODP(wl_CtrlDgv)

            wl_sCodDgv = "dgv2"
            wl_CtrlDgv = Me.dgv2
            dgv_APDGV()
            dgv_ConfiguraCol()
            wl_CtrlDgv.Rows.Clear()
            dgv_AdiRowPEODP(wl_CtrlDgv)

            wl_sCodDgv = "dgv3"
            wl_CtrlDgv = Me.dgv3
            dgv_APDGV()
            dgv_ConfiguraCol()
            wl_CtrlDgv.Rows.Clear()
            dgv_AdiRowPEODP(wl_CtrlDgv)
            Plo_ActivarCmpAct()
            cboABODP.Focus()

            'cmdRecEDP.Enabled = False
            'cmdRecInv.Enabled = False
            'cmdRecODP.Enabled = False

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarBuscar()
        Try
            wl_bVda1 = False
            wl_bVdaCodItm = False
            mof_ActivarBuscar(Me)
            Plo_IniciarFrm()
            Plo_IniciarVarDGV()
            txtnNroDoc.Text = ""
            txtnNroDoc.Enabled = True
            Plo_ActivarCmpAct()
            cmdLstPEODP.Enabled = True
            cboABODP.Focus()

            cmdRecEDP.Enabled = False
            cmdRecInv.Enabled = False
            cmdRecODP.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarBuscar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_LeeAPEND()
        ' Fec Ult Mod. 2014.04.19
        Dim clnConTbl As New ClaseNegocios.clnConTbl
        Try
            wl_eAPEND = New moe_Estructuras.eAPEND
            wl_sNomTblE2 = "APEND"
            wl_sNomCmpE21 = "sCodDoc"
            wl_sDatCmpE21 = vl_sCodDoc
            wl_sTipCmpE21 = "S"
            wl_sCmpOrdE21 = ""
            wl_sTipOrdE21 = "S"
            wl_sNomCmpE22 = "sCodSer"
            wl_sDatCmpE22 = vl_sCodSer
            wl_sTipCmpE22 = "S"
            wr_bEOFE1 = True
            wl_DTE2 = clnConTbl.cndtBuscar(wl_sNomTblE2,
                                           wl_sNomCmpE21,
                                           wl_sDatCmpE21,
                                           wl_sTipCmpE21,
                                           wl_sCmpOrdE21,
                                           wl_sTipOrdE21,
                                           wr_bEOFE1)
            If wr_bEOFE1 = False Then
                moo_eAPEND_DT(wl_eAPEND,
                              wl_DTE2,
                              0)
                vl_sCodSer = wl_eAPEND.sCodSer
                txtnNroDoc.Text = wl_eAPEND.nNroSig
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_LeeAPEND")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_LeeAPLND1()
        Dim clnConTbl As New ClaseNegocios.clnConTbl

        wl_sNomTblE2 = "APLND1"
        wl_sNomCmpE21 = "sCodDoc"
        wl_sDatCmpE21 = wl_ePEODP.sCodDoc
        wl_sTipCmpE21 = "S"
        wl_sCmpOrdE21 = ""
        wl_sTipOrdE21 = "S"
        wl_sNomCmpE22 = "sCodSer"
        wl_sDatCmpE22 = wl_ePEODP.sCodSer
        wl_sTipCmpE22 = "S"
        wr_bEOFE1 = True
        wg_DTE2 = clnConTbl.cndtBuscarE2(wl_sNomTblE2,
                                         wl_sNomCmpE21,
                                         wl_sDatCmpE21,
                                         wl_sTipCmpE21,
                                         wl_sNomCmpE22,
                                         wl_sDatCmpE22,
                                         wl_sTipCmpE22,
                                         wr_bEOFE1)
        If wr_bEOFE1 = False Then

        End If
        ' TextBox1.Text = wg_DTE2.Rows(0).Item(3)

    End Sub
    Private Sub PloNroSig_APEND()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = CType(txtnNroDoc.Text, Double) + 1
            wl_sNomTblE2 = "APEND"
            wl_sNomCmpE21 = "sCodDoc"
            wl_sDatCmpE21 = wl_ePEODP.sCodDoc
            wl_sTipCmpE21 = "S"
            wl_sNomCmpE22 = "sCodSer"
            wl_sDatCmpE22 = wl_ePEODP.sCodSer
            wl_sTipCmpE22 = "S"
            wp_sNomCmp = "nNroSig"
            wp_sDatCmp = vl_nNroSig
            wp_sTipCmp = "N"
            wr_bEOF = True
            wr_bEOF = clnActTbl.cndtActDosLlaUnCmp(wl_sNomTblE2,
                                                   wl_sNomCmpE21,
                                                   wl_sDatCmpE21,
                                                   wl_sTipCmpE21,
                                                   wl_sNomCmpE22,
                                                   wl_sDatCmpE22,
                                                   wl_sTipCmpE22,
                                                   wp_sNomCmp,
                                                   wp_sDatCmp,
                                                   wp_sTipCmp,
                                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : PloNroSig_APEND")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub PloNroSig_APLND1()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = CType(txtnNroDoc.Text, Double) + 1
            wl_sNomTblE2 = "APLND1"
            wl_sNomCmpE21 = "sCodDoc"
            wl_sDatCmpE21 = wl_ePEODP.sCodDoc
            wl_sTipCmpE21 = "S"
            wl_sNomCmpE22 = "sCodSer"
            wl_sDatCmpE22 = wl_ePEODP.sCodSer
            wl_sTipCmpE22 = "S"
            wp_sNomCmp = "nNroSig"
            wp_sDatCmp = vl_nNroSig
            wp_sTipCmp = "N"

            wr_bEOF = True
            clnActTbl.cndtActDosLlaUnCmp(wl_sNomTblE2,
                                         wl_sNomCmpE21,
                                         wl_sDatCmpE21,
                                         wl_sTipCmpE21,
                                         wl_sNomCmpE22,
                                         wl_sDatCmpE22,
                                         wl_sTipCmpE22,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_sTipCmp,
                                         wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : PloNroSig_APLND1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ReservarMP()
        Try
            dgv_Mueve_SdoRes()
        Catch ex As Exception
            MsgBox("Error : Plo_ReservarMP")
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub Plo_ReversarReservarMP()
        Try

        Catch ex As Exception
            MsgBox("Error : PloNroSig_APLND1")
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub Plo_CrgModCtb()
        Try

        Catch ex As Exception
            MsgBox("Error : Plo_CrgModCtb")
            MsgBox(ex.Message)

        End Try
    End Sub

#End Region
#Region "082 Elo Eventos locales del Formulario"
    Private Sub cboACUNI_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboACUNI.LostFocus
        Try
            If wl_bVda1 = False Then
                Exit Sub
            End If
            If wl_bVdaCodItm = False Then
                Exit Sub
            End If

            vl_nCanOdp = CDbl(txtnCanOdp.Text)
            vl_sCodItm = mtbsCodItm.Text
            vl_sUniMedOdp = cboACUNI.SelectedValue

            Plo_Cal_Lostfocus()

        Catch ex As Exception
            MsgBox("Error : cboACUNI_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mtbsCodItm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbsCodItm.LostFocus
        Try
            If wl_bVda1 = False Then
                Exit Sub
            End If
            wl_bVda = False
            vl_sCodItm = mtbsCodItm.Text
            txtnCanOdp.Text = Format(1)
            vl_nCanOdp = CDbl(txtnCanOdp.Text)
            vl_sUniMedOdp = cboACUNI.SelectedValue
            If cmdCrear.Visible = True Then
                If Mid(mtbsCodItm.Text, 1, 1) = " " Then
                    cmdLstPELIM.Focus()
                    Exit Sub
                End If
                wr_bEOFE2 = False
                If vl_sCodSer <> "FM" Then
                    BD_BuscarPELIM()
                    If wr_bEOFE2 = True Then
                        wp_sNomTbl = wl_sNomTblE1
                        wp_sDatCmp = mtbsCodItm.Text
                        wp_sCodErr = "10-101"
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        mtbsCodItm.Focus()
                        wl_bVdaCodItm = False
                        'cmdLstPELIM.Focus()
                        Exit Sub
                    End If
                    wl_bVdaCodItm = True
                    wl_bVda = True
                    BD_Var_ePELIMeIEDMI()
                    Plo_Frm_VarePELIMeIEDMI()
                Else


                    txtnCanOdp.Text = "1"
                    txtnCanUniStn.Text = "1"
                    vl_sCodAlm = "Grl"
                    vl_sCodDoc = cboABODP.SelectedValue
                    vl_nNroDoc = CLng(txtnNroDoc.Text)
                    vl_nCanOdp = CDbl(txtnCanOdp.Text)
                    vl_nCanUniStn = CDbl(txtnCanUniStn.Text)
                    wl_bVdaCodItm = True
                    wl_bVda = True
                    txtsNomItm.Focus()

                End If

                'If wl_ePEODP.sCodDoc = "ODP" Or wl_ePEODP.sCodDoc = "ODA" Or wl_ePEODP.sCodDoc = "OPE" Then
                If vl_sCodDoc = "ODP" Or vl_sCodDoc = "ODA" Or vl_sCodDoc = "OPE" Then
                    '   If vl_sCodSer <> "FM" Then
                    Plo_Cal_Lostfocus()
                    dgv_DGV_DT_PLLIM()
                    Plo_Cal_Lostfocus()
                    'End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Error : mtbsCodItm_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_Cal_Lostfocus()
        Try
            mof_LmpMsgError()
            Plo_Var_FrmPEODP()
            Plo_FrmPEODP_Var()
            BD_ePEODP_Var()
            Plo_RecalPLODP4()
            BD_ePLODP4_Var()
            'Plo_FrmPLODP4_Var()
            dgv_RecalDGV()
            Plo_RecalPLODP4()
            BD_ePEODP_Var()
            BD_Var_ePLODP4()
            Plo_FrmPEODP_Var()
            Plo_FrmPLODP4_Var()

        Catch ex As Exception
            MsgBox("Error : Plo_Cal_Lostfocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtnCanOdp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnCanOdp.LostFocus
        Try
            Dim wl_nvlr As Integer
            If Not Double.TryParse(txtnCanOdp.Text, wl_nvlr) Then
                txtnCanOdp.Focus()
                Exit Sub
            End If
            If wl_bVda1 = False Then
                Exit Sub
            End If
            If wl_bVdaCodItm = False Then
                Exit Sub
            End If


            vl_nCanOdp = CDbl(txtnCanOdp.Text)
            vl_sCodItm = mtbsCodItm.Text
            vl_sUniMedOdp = cboACUNI.SelectedValue

            If CDbl(txtnCanOdp.Text) >= 0 Then
                If Mid(mtbsCodItm.Text, 1, 1) <> " " Then
                    Plo_Cal_Lostfocus()
                End If

            Else
                txtnCanOdp.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : txtnCanOdp_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtnNroDoc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnNroDoc.KeyUp
        Try
            If e.KeyData = Keys.Enter Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)

                End If
            End If

            If cmdCrear.Visible = True Then
                If Mid(mtbsCodItm.Text, 1, 1) = " " Then
                    mtbsCodItm.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: txtnNroDoc_KeyUp")
        End Try
    End Sub
    Private Sub txtnNroDoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnNroDoc.LostFocus
        Try
            Dim wl_nvlr As Integer

            mof_LmpMsgError()
            If Not Double.TryParse(txtnNroDoc.Text, wl_nvlr) Then
                txtnNroDoc.Focus()
                Exit Sub
            End If

            If IsNothing(txtnNroDoc.Text) Then
                Exit Sub
            End If
            If txtnNroDoc.Text = "" Then
                Exit Sub
            End If

            vl_nNroDoc = CLng(txtnNroDoc.Text)
            If cmdBuscar.Visible = True Then
                cmdBuscar_Click(Nothing,
                                    Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: txtnNroDoc_LostFocus")
        End Try

    End Sub
    Private Sub txtsCodAlm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodAlm.LostFocus
        Try
            If cmdBuscar.Visible = True Then
                Exit Sub
            End If
            wr_bEOFE2 = False
            mof_LmpMsgError()


            vl_sCodAlm = txtsCodAlm.Text
            wr_bEOFE2 = BD_BuscarATALM()
            If wr_bEOFE2 = True Then
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = txtsCodAlm.Text
                wp_sCodErr = "10-103"
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                txtsCodAlm.Focus()
                Exit Sub
            End If
            txtsCodAlm.Text = wl_eATALM.sCodAlm
            If vl_sCodSer <> "FM" Then
                wr_bEOFE2 = False
                wr_bEOFE2 = BD_ConSdoILMDI1()
                If wr_bEOFE2 = True Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = "10-117"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodAlm.Focus()
                    Exit Sub

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: txtsCodAlm_LostFocus")
        End Try

    End Sub
#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            Dim wl_aePEODP(0) As moe_Estructuras.ePEODP
            Dim wl_aePLODP4(0) As moe_Estructuras.ePLODP4

            BD_ePEODP_Var()
            dgv_DGV_DT()
            wl_aePEODP(0) = wl_ePEODP
            wl_aePLODP4(0) = wl_ePLODP4

            If wg_eACPAG.bPrnODPPla = False Then
                If wl_ePEODP.sEstOdp = "1" Then
                    MsgBox("OP no se puede imprimir en este estado")
                    Exit Sub
                End If

            End If

            wl_sNroALetras = mof_NroALetras(CType(wl_ePLODP4.nVrcCosTot, String),
                                            wg_sCodMon)

            wl_bImpP001 = False
            wl_bImpP002 = False
            wl_bImpP003 = False
            wl_bImpP004 = False
            wl_bImpP005 = False
            Dim wl_frmPEODP_SelRpt As New frmPEODP_SelRpt
            wl_frmPEODP_SelRpt.ShowDialog()
            wl_bImpP001 = wl_frmPEODP_SelRpt.wp_bImpP001
            wl_bImpP002 = wl_frmPEODP_SelRpt.wp_bImpP002
            wl_bImpP003 = wl_frmPEODP_SelRpt.wp_bImpP003
            wl_bImpP004 = wl_frmPEODP_SelRpt.wp_bImpP004
            wl_bImpP005 = wl_frmPEODP_SelRpt.wp_bImpP005
            

            mof_ActivarOK(Me)
            'ODP
            If wl_bImpP001 = True Then
                If wl_aePLODP1.Length <> 0 Then
                    If wl_aePLODP1(0).sCodDoc <> "" Then
                        Dim wl_frmRPT As New rptPROP001
                        wl_frmRPT.wp_aePEODP = wl_aePEODP
                        wl_frmRPT.wp_aePLODP1 = wl_aePLODP1
                        wl_frmRPT.wp_aePLODP2 = wl_aePLODP2
                        wl_frmRPT.wp_aePLODP3 = wl_aePLODP3
                        wl_frmRPT.wp_aePLODP4 = wl_aePLODP4
                        wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                        wl_frmRPT.Show()
                    End If
                End If
            End If
            ' Formato Calidad
            If wl_bImpP002 = True Then
                If wl_aePLODP5.Length <> 0 Then
                    If wl_aePLODP5(0).sCodDoc <> "" Then
                        Dim wl_frmRPT1 As New rptPROP002
                        wl_frmRPT1.wp_aePEODP = wl_aePEODP
                        wl_frmRPT1.wp_aePLODP1 = wl_aePLODP1
                        wl_frmRPT1.wp_aePLODP2 = wl_aePLODP2
                        wl_frmRPT1.wp_aePLODP3 = wl_aePLODP3
                        wl_frmRPT1.wp_aePLODP4 = wl_aePLODP4
                        wl_frmRPT1.wp_aePLODP5 = wl_aePLODP5
                        wl_frmRPT1.wp_sNroALetras = wl_sNroALetras
                        wl_frmRPT1.Show()
                    End If
                End If
            End If
            'Etiquetas
            If wl_bImpP004 = True Then
                If wl_ePEODP.sCodDoc <> "ODA" Then
                    If wl_aePLODP1.Length <> 0 Then
                        If wl_aePLODP1(0).sCodDoc <> "" Then
                            Dim wl_frmRPT2 As New rptPROP004
                            wl_frmRPT2.wp_aePEODP = wl_aePEODP
                            wl_frmRPT2.wp_aePLODP1 = wl_aePLODP1
                            wl_frmRPT2.wp_aePLODP2 = wl_aePLODP2
                            wl_frmRPT2.wp_aePLODP3 = wl_aePLODP3
                            wl_frmRPT2.wp_aePLODP4 = wl_aePLODP4
                            wl_frmRPT2.wp_sNroALetras = wl_sNroALetras
                            wl_frmRPT2.Show()
                        End If
                    End If
                End If
            End If
            If wl_aePLODP1.Length <> 0 Then
                'Salidas de MP y MEE
                If wl_bImpP005 = True Then
                    If wl_aePLODP1(0).sCodDoc <> "" Then
                        Dim wl_frmRPT3 As New rptPROP0011
                        wl_frmRPT3.wp_aePEODP = wl_aePEODP
                        wl_frmRPT3.wp_aePLODP1 = wl_aePLODP1
                        wl_frmRPT3.wp_sNroALetras = wl_sNroALetras
                        wl_frmRPT3.Show()
                    End If
                    If wl_aePLODP1(0).sCodDoc <> "" Then
                        Dim wl_frmRPT4 As New rptPROP0012
                        wl_frmRPT4.wp_aePEODP = wl_aePEODP
                        wl_frmRPT4.wp_aePLODP1 = wl_aePLODP1
                        wl_frmRPT4.wp_sNroALetras = wl_sNroALetras
                        wl_frmRPT4.Show()
                    End If
                End If

                ' Operaciones
                If wl_bImpP003 = True Then
                    If wl_aePLODP1(0).sCodDoc <> "" Then
                        Dim wl_frmRPT5 As New rptPROP003
                        wl_frmRPT5.wp_aePEODP = wl_aePEODP
                        wl_frmRPT5.wp_aePLODP2 = wl_aePLODP2
                        wl_frmRPT5.wp_sNroALetras = wl_sNroALetras
                        wl_frmRPT5.Show()
                    End If
                End If

            End If


        Catch ex As Exception
            MsgBox("Error :  Rpt_PrmRpt")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Rpt_ImpFal()
        Try
            Dim wl_aePEODP(0) As moe_Estructuras.ePEODP
            Dim wl_aePLODP4(0) As moe_Estructuras.ePLODP4



            BD_ePEODP_Var()
            dgv_DGV_DT()
            wl_aePEODP(0) = wl_ePEODP
            wl_aePLODP4(0) = wl_ePLODP4

            
            wl_sNroALetras = mof_NroALetras(CType(wl_ePLODP4.nVrcCosTot, String),
                                            wg_sCodMon)
            mof_ActivarOK(Me)

            If wl_aePLODP1.Length <> 0 Then
                If wl_aePLODP1(0).sCodDoc <> "" Then
                    Dim wl_frmRPT As New rptPROP006
                    wl_frmRPT.wp_aePEODP = wl_aePEODP
                    wl_frmRPT.wp_aePLODP1 = wl_aePLODP1
                    wl_frmRPT.wp_aePLODP2 = wl_aePLODP2
                    wl_frmRPT.wp_aePLODP3 = wl_aePLODP3
                    wl_frmRPT.wp_aePLODP4 = wl_aePLODP4
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.wp_bSelItm = vl_bSelItm
                    wl_frmRPT.Show()
                End If
            End If



        Catch ex As Exception
            MsgBox("Error :  Rpt_ImpFal")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region


#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#Region "110 grl Changed"
    Private Sub grl_Cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Chb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_mtb_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Txt_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DirectCast(sender, TextBox).Name = "mtbsCodItm" Then
            wl_sClaPpl = mtbsCodItm.Text
            mof_LmpMsgError()
        Else
            grl_TextChange()
        End If
    End Sub
#End Region

#Region "120 grl Eventos"
    Public Sub grl_EventCtrl(ByVal wp_VlrCtrl As Control)
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is ComboBox Then
                AddHandler DirectCast(oCtrl, ComboBox).GotFocus, AddressOf grl_Cbo_GotFocus
                AddHandler DirectCast(oCtrl, ComboBox).LostFocus, AddressOf grl_Cbo_LostFocus
                AddHandler DirectCast(oCtrl, ComboBox).SelectedIndexChanged, AddressOf grl_Cbo_SelectedIndexChanged
            End If
            If TypeOf oCtrl Is CheckBox Then
                AddHandler DirectCast(oCtrl, CheckBox).GotFocus, AddressOf grl_Chb_GotFocus
                AddHandler DirectCast(oCtrl, CheckBox).LostFocus, AddressOf grl_Chb_LostFocus
                AddHandler DirectCast(oCtrl, CheckBox).CheckedChanged, AddressOf grl_Chb_CheckedChanged
            End If
            If TypeOf oCtrl Is MaskedTextBox Then
                AddHandler DirectCast(oCtrl, MaskedTextBox).GotFocus, AddressOf grl_mtb_GotFocus
                AddHandler DirectCast(oCtrl, MaskedTextBox).LostFocus, AddressOf grl_mtb_LostFocus
                AddHandler DirectCast(oCtrl, MaskedTextBox).TextChanged, AddressOf grl_mtb_Changed
            End If
            If TypeOf oCtrl Is RadioButton Then
                AddHandler DirectCast(oCtrl, RadioButton).GotFocus, AddressOf grl_Rdb_GotFocus
                AddHandler DirectCast(oCtrl, RadioButton).LostFocus, AddressOf grl_Rdb_LostFocus
                AddHandler DirectCast(oCtrl, RadioButton).CheckedChanged, AddressOf grl_Rdb_CheckedChanged
            End If
            If TypeOf oCtrl Is TextBox Then
                AddHandler DirectCast(oCtrl, TextBox).GotFocus, AddressOf grl_Txt_GotFocus
                AddHandler DirectCast(oCtrl, TextBox).LostFocus, AddressOf grl_Txt_LostFocus
                AddHandler DirectCast(oCtrl, TextBox).TextChanged, AddressOf grl_Txt_Changed
                AddHandler DirectCast(oCtrl, TextBox).KeyUp, AddressOf grl_Txt_KeyUp
            End If
            If TypeOf oCtrl Is GroupBox Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is SplitContainer Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabControl Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabPage Then
                grl_EventCtrl(oCtrl)
            End If
        Next
    End Sub
    Private Sub grl_AddHandler()
        AddHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        AddHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        AddHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        AddHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        AddHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        AddHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        AddHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VwvPrv
        AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        AddHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        AddHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
    End Sub
    Private Sub grl_RemoveHandler()
        RemoveHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        RemoveHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        RemoveHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        RemoveHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        RemoveHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        RemoveHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        RemoveHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VwvPrv
        RemoveHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        RemoveHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        RemoveHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
    End Sub
#End Region

#Region "130 grl Got Focus"
    Private Sub grl_Cbo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Chb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_mtb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrGot
        DirectCast(sender, MaskedTextBox).SelectionStart = 0
        DirectCast(sender, MaskedTextBox).SelectionLength = DirectCast(sender, MaskedTextBox).Text.Length
    End Sub
    Private Sub grl_Rdb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = wg_ClrGot
        DirectCast(sender, TextBox).SelectionStart = 0
        DirectCast(sender, TextBox).SelectionLength = DirectCast(sender, TextBox).Text.Length
        DirectCast(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "140 grl Lost Focus. Personalizados"
    ' Private Sub grl_Txt_KeyUp(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub grl_Txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        ' mof_LmpMsgError()
        wl_cvTxt = GetNextControl(wl_cvTxt, False)

        If cmdCancelar.Focused = False Then
            If wl_cvTxt IsNot Nothing Then
                If wl_cvTxt.Name = "txtsCodItm" Then
                    mov_VdaMTB(wl_bVda,
                               mtbsCodItm)
                End If
            End If
        End If
        If e.KeyData = Keys.Enter Then
            If wl_cvTxt.Name = "cboAPLND1" Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar.Focus()
                End If
            End If
        End If

        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim wl_cvTxt As Control = ActiveControl
        'wl_cvTxt = GetNextControl(wl_cvTxt, False)
        'If cmdCancelar.Focused = False Then
        ' If wl_cvTxt IsNot Nothing Then
        ' If wl_cvTxt.Name = "mtbsCodItm" Then
        ' mov_VdaMTB(wl_bVda,
        '            mtbsCodItm)
        ' End If
        ' End If
        ' End If
        'DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
#End Region
#Region "141 grl Lost Focus. Comunes"
    Private Sub grl_Cbo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Chb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_mtb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Rdb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrLost
    End Sub
#End Region

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
    Public Sub grl_TextChange()
        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region

#Region "160 TSB ToolStrip Procedimientos eventos de la barra de herramientas:BPASUCE"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
        Plo_ActivarBuscar()
    End Sub
    Private Sub tsb_Primero()
        BD_DatPrmTSB()
        ' mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtPrimero(wl_sNomTblE1,
                                                    wl_sCmpTSB,
                                                    wl_sDatTSB,
                                                    wr_bEOFE1)

                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtPrimeroMov(wl_sNomTblE1,
                                                       wl_sNomCmpE11,
                                                       wl_sDatCmpE11,
                                                       wl_sTipCmpE11,
                                                       wl_sNomCmpE12,
                                                       wl_sDatCmpE12,
                                                       wl_sTipCmpE12,
                                                       wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If

            End If


        Catch ex As Exception
            MsgBox("Error en: tsb_Primero")
        End Try

    End Sub
    Private Sub tsb_Anterior()
        BD_DatPrmTSB()
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtAnterior(wl_sNomTblE1,
                                                     wl_sCmpTSB,
                                                     wl_sDatTSB,
                                                     wl_sTipCmpTSB,
                                                     wr_bEOFE1)
                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtAnteriorMov(wl_sNomTblE1,
                                                        wl_sNomCmpE11,
                                                        wl_sDatCmpE11,
                                                        wl_sTipCmpE11,
                                                        wl_sNomCmpE12,
                                                        wl_sDatCmpE12,
                                                        wl_sTipCmpE12,
                                                        wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Anterior")
        End Try

    End Sub
    Private Sub tsb_Siguiente()
        BD_DatPrmTSB()
        '  mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtSiguiente(wl_sNomTblE1,
                                                      wl_sCmpTSB,
                                                      wl_sDatTSB,
                                                      wl_sTipCmpTSB,
                                                      wr_bEOFE1)
                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtSiguienteMov(wl_sNomTblE1,
                                                         wl_sNomCmpE11,
                                                         wl_sDatCmpE11,
                                                         wl_sTipCmpE11,
                                                         wl_sNomCmpE12,
                                                         wl_sDatCmpE12,
                                                         wl_sTipCmpE12,
                                                         wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If

            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Siguiente")
        End Try

    End Sub
    Private Sub tsb_Ultimo()
        BD_DatPrmTSB()
        mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            wl_DTE1 = New DataTable
            If wl_sNomTblE1 <> "" Then
                If wl_sTipTbl = "E1" Then
                    wl_DTE1 = clnConTbl.cndtUltimo(wl_sNomTblE1,
                                                   wl_sCmpTSB,
                                                   wl_sDatTSB,
                                                   wr_bEOFE1)
                End If
                If wl_sTipTbl = "E2" Then
                    wl_DTE1 = clnConTbl.cndtUltimoMov(wl_sNomTblE1,
                                                      wl_sNomCmpE11,
                                                      wl_sDatCmpE11,
                                                      wl_sTipCmpE11,
                                                      wl_sNomCmpE12,
                                                      wl_sDatCmpE12,
                                                      wl_sTipCmpE12,
                                                      wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Ultimo")
        End Try
    End Sub
    Public Sub tsb_Crear()
        mof_fLmpCtrl(Me)
        Plo_ActivarCrear()

    End Sub
    Public Sub tsb_Eliminar()
        mof_ActivarEliminar(Me)
    End Sub
#End Region

#Region "161 TSB ToolStrip Procedimientos eventos de la barra de herramientas:VI"
    Private Sub tsb_VwvPrv()
        Try
            Rpt_PrmRpt()
        Catch ex As Exception
            MsgBox("Error :  tsb_VisVwV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
#End Region

#Region "170 TSMI ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
        Try
            '  If wl_eGEMOV.sEstDoc > "1" Then
            ' Exit Sub
            ' End If
            If TabControl1.SelectedTab Is TabPage1 Then
                wl_CtrlDgv = Me.dgv1
            End If
            If TabControl1.SelectedTab Is TabPage2 Then
                wl_CtrlDgv = Me.dgv2
            End If
            If TabControl1.SelectedTab Is TabPage3 Then
                wl_CtrlDgv = Me.dgv3
            End If
            If TabControl1.SelectedTab Is TabPage5 Then
                wl_CtrlDgv = Me.dgv5
            End If
            dgv_AdiRowPEODP(wl_CtrlDgv)
        Catch ex As Exception
            MsgBox("Error : tsmi_CrearLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsmi_EliminarLinea()
        Try
            If wl_bSwsEliLin = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If cmdCrear.Visible = False Then
                mof_ActivarActualizar(Me)
            End If
            If TabControl1.SelectedTab Is TabPage1 Then
                wl_CtrlDgv = Me.dgv1
            End If
            If TabControl1.SelectedTab Is TabPage2 Then
                wl_CtrlDgv = Me.dgv2
            End If
            If TabControl1.SelectedTab Is TabPage3 Then
                wl_CtrlDgv = Me.dgv3
            End If
            dgv_EliminarLinea(wl_CtrlDgv)
        Catch ex As Exception
            MsgBox("Error : tsmi_EliminarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

End Class