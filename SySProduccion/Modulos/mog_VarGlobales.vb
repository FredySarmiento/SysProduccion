' mog - Módulo donde se defines la variables globales
Module mog_VarGlobales
#Region "vg Variable BD Global"
    Public vg_sCodcia As String = ""
    Public vg_sNomCia As String = ""
    Public vg_sNitCia As String = ""
    Public vg_sDigVer As String = ""
    Public vg_nAnoSdoIniInv As Integer

    Public vg_sNomBD As String = ""

    Public vg_sCodUsr As String
    Public vg_sPwdUsr As String
    Public vg_sNomUsr As String

    Public vg_bFinSys As Boolean
    Public vg_sCodErr As String
    Public vg_sDesErr As String
    Public vg_sCodClr As String

    Public Const vg_sNomBDCfg = "SysConfig.mdb"

#End Region
#Region "vg parámetros ACPAG "
    Public vg_bLmtCre As Boolean
    Public vg_sCndPagxDefCli As String
    Public vg_sMetPagxDefCli As String
    Public vg_sCndPagxDefPro As String
    Public vg_sMetPagxDefPro As String
    Public vg_sClrFrm As String
    Public vg_sForFec As String
    Public vg_sForHor As String
    Public vg_nNroDecPre As Integer
    Public vg_nNroDecCan As Integer
    Public vg_nNroDecPor As Integer
    Public vg_sCodAlmXDef As String
    Public vg_sCrictaCtb As String
    Public vg_bVisItmIna As Boolean
    Public vg_sRutXls As String
    Public vg_nPorGto As String
    Public vg_nPorIto As String

#End Region

#Region "wp variables APDGV "

    Public wp_nId As Long '0
    Public wp_sCodFrm As String '1
    Public wp_sCodDgv As String '2
    Public wp_nColOri As Integer '3
    Public wp_nNroCol As Integer '4 
    Public wp_sTitCol As String '5
    Public wp_sTipCol As String 'N = numérico. C = pesos. S = string. d = fecha 6
    Public wp_bColxDef As Boolean '7
    Public wp_bVisible As Boolean '8
    Public wp_bReadOnly As Boolean '9
    Public wp_bColPor As Boolean '10
    Public wp_nColNom As Integer '11
    Public wp_nColVlr As Integer '12
    Public wp_sNomDat As String '13
    Public wp_bDatReq As Boolean '14
    Public wp_sRglVdaDat As String '15 
    Public wp_sCodErrDat As String '16
    Public wp_sNomTblVda As String '17
    Public wp_bVdaEOF As Boolean '18
    Public wp_sRglVdaEOF As String '19
    Public wp_sCodErrEOF As String '20
    Public wp_sDesOpe As String '21
    Public wp_nColRes As Integer '22
    Public wp_sCodErrOpe As String '23
    Public wp_nColVda As Boolean '24
    Public wp_sRglVdaCol As String '25
    Public wp_sCodErrCol As String '26
    Public wp_sDatBas As String '27
    Public wp_bColTot As Boolean '28
    Public wp_bGQLst As Boolean '29
    Public wp_sCodErrEOF1 As String '30
    Public wp_nColCtaInv As Integer '31 
    Public wp_nColCosVta As Integer '32
    Public wp_sTblOriDat As String '33
    Public wp_nColDocBas As Integer '34 
    Public wp_nColNroBas As Integer '35

#End Region
#Region "wp variables APQRGV "
    Public wp_sCodStr As String '1
#End Region
#Region "wp variables APRGV "
    Public wp_sCodRpt As String '1
#End Region
#Region "wp variables ILDMI2 "
    Public vg_sCodItm As String '1


#End Region


#Region "wg Variables Globales"
    Public wg_nColFin As Long = 0
    Public wg_nColIni As Long = 0
    Public wg_sCodMon As String = "COP"

#End Region
#Region "wp Variable de trabajo Global parámetro"

    'Errores

    Public wp_sCodErr As String = ""
    Public wp_sDesErr As String = ""
    Public wp_sClrErr As String
    Public wp_sDatErr As String = ""
    Public wp_sTipDes As String

    'Eventos

    'Mensajes

    Public wp_nBoxMsg As Integer
    Public wp_sDesMsg As String = ""
    Public wp_sTitMsg As String = ""
    Public wp_nResMsg As Integer

    'Opciones

    Public wp_sCmdSel As Char 'C rear, A ctualizar, B uscar, E liminar, O k


    'Tablas

    Public wp_sNomTbl As String = ""
    Public wp_sNomCmp As String = ""
    Public wp_sTipCmp As String = "" 'wlTipCmp: N umérico. F echa, C adena
    Public wp_sDatCmp As String = ""
    Public wp_sDatSel As String = ""
    Public wp_sTitCmp As String = ""
    Public wp_sCmpOrd As String = ""
    Public wp_sTipOrd As String = ""


    Public wp_sNomCmp1 As String = ""
    Public wp_sTipCmp1 As String = "" 'wlTipCmp1: N umérico. F echa, C adena
    Public wp_sDatCmp1 As String = ""
    Public wp_sDatSel1 As String = ""
    Public wp_sTitCmp1 As String = ""
    Public wp_sCamOrd1 As String = ""
    Public wp_sTipOrd1 As String = ""

    Public wp_sNomLla As String = ""
    Public wp_sDatLla As String = ""
    Public wp_sTipLla As String = "" 'wlTipLla : N umérico. F echa, C adena

    Public wp_bVda As Boolean

    'Formularios
    Public wp_sNomFrm As String = ""


    ' Parámetros por referencia

    Public wr_bEOF As Boolean
    Public wp_VlrCtrl As Control
    Public wr_nIdEnc As Long



#End Region
#Region "wg Variables Globales parametros entre GEMOV"
    Public wg_sFmrOri As String
    Public wg_sTipDocOri As String

    Public wg_sFrmDes As String
    Public wg_sTipDocDes As String

#End Region
#Region "wg Variables Globales de conexión"

   



#End Region


#Region "wg Variable BD Global"
  


    'Tablas- Encabezado

    Public wg_sNomTblE1 As String = ""
    Public wg_sNomCmpE11 As String = ""
    Public wg_sDatCmpE11 As String = ""
    Public wg_sDatSelE11 As String = ""
    Public wg_sTipCmpE11 As String = ""
    Public wg_sTitCmpE11 As String = ""
    Public wg_sCmpOrdE11 As String = ""
    Public wg_sTipOrdE11 As String = ""

    Public wg_sNomCmpE12 As String = ""
    Public wg_sDatCmpE12 As String = ""
    Public wg_sDatSelE12 As String = ""
    Public wg_sTipCmpE12 As String = ""
    Public wg_sTitCmpE12 As String = ""
    Public wg_sCmpOrdE12 As String = ""
    Public wg_sTipOrdE12 As String = ""

    Public wr_bEOFE1 As Boolean
    Public wg_bVdaE1 As Boolean

    Public wg_sNomTblE2 As String = ""
    Public wg_sNomCmpE21 As String = ""
    Public wg_sDatCmpE21 As String = ""
    Public wg_sDatSelE21 As String = ""
    Public wg_sTipCmpE21 As String = ""
    Public wg_sTitCmpE21 As String = ""
    Public wg_sCmpOrdE21 As String = ""
    Public wg_sTipOrdE21 As String = ""

    Public wg_sNomCmpE22 As String = ""
    Public wg_sDatCmpE22 As String = ""
    Public wg_sDatSelE22 As String = ""
    Public wg_sTipCmpE22 As String = ""
    Public wg_sTitCmpE22 As String = ""
    Public wg_sCmpOrdE22 As String = ""
    Public wg_sTipOrdE22 As String = ""
    Public wr_bEOFE2 As Boolean


    'Tablas- Líneas    

    Public wg_sNomTblL1 As String = ""
    Public wg_sNomCmpL11 As String = ""
    Public wg_sDatCmpL11 As String = ""
    Public wg_sDatSelL11 As String = ""
    Public wg_sTipCmpL11 As String = ""
    Public wg_sTitCmpL11 As String = ""
    Public wg_sCmpOrdL11 As String = ""
    Public wg_sTipOrdL11 As String = ""

    Public wg_sNomCmpL12 As String = ""
    Public wg_sDatCmpL12 As String = ""
    Public wg_sDatSelL12 As String = ""
    Public wg_sTipCmpL12 As String = ""
    Public wg_sTitCmpL12 As String = ""
    Public wg_sCmpOrdL12 As String = ""
    Public wg_sTipOrdL12 As String = ""

    Public wr_bEOFL1 As Boolean
    Public wg_bVdaL1 As Boolean

    'Tablas- Listas, ComboBox

    Public wg_sTblLst1 As String = ""
    Public wg_sCmpLst1 As String = ""
    Public wg_sDatLst1 As String = ""
    Public wg_sTipLst1 As String = ""
    Public wg_sCmpOrdLst1 As String = ""
    Public wg_sTipOrdLst1 As String = ""
    Public wr_bEOFLst1 As Boolean
    '
    'Tablas- Listas, Errores, Mensajes

    Public wg_sTblErr1 As String = ""
    Public wg_bEOFErr1 As Boolean
    Public wg_sCodErrAdi As String
    Public wg_sCodErrCon As String
    Public wg_sCodErrOk As String
    Public wg_sCodErr As String = ""
    Public wg_sDesErr As String = ""

    Public wg_sDesMsgEli As String = ""
    Public wg_sTitMsgEli As String = ""
    Public wg_sDesMsgAdi As String = ""
    Public wg_sTitMsgAdi As String = ""
    '

    'Tablas- Consultas

    Public wg_sTblCon1 As String = "" '
    Public wg_sCmpCon11 As String = "'"
    Public wg_sDatCon11 As String = ""
    Public wg_sSelCon11 As String = ""
    Public wg_sTitCon11 As String = ""
    Public wg_sTipCon11 As String = ""
    Public wg_sCmpOrdCon11 As String = ""
    Public wg_sTipOrdCon11 As String = ""
    Public wg_sCmpCon12 As String = ""
    Public wg_sDatCon12 As String = ""
    Public wg_sSelCon12 As String = ""
    Public wg_sTipCon12 As String = ""
    Public wg_sTitCon12 As String = ""
    Public wg_sCmpOrdCon12 As String = ""
    Public wg_sTipOrdCon12 As String = ""
    Public wg_nSelCon13 As Long
    Public wg_sTitCon13 As String = ""
    Public wg_nSelCon14 As Double
    Public wg_sTitCon14 As String = ""
    Public wg_sSelCon15 As String = ""
    Public wr_bEOFCon1 As Boolean
    Public wg_sIndCon As String = ""

    Public wg_sTblCon2 As String = "" '
    Public wg_sCmpCon21 As String = "'"
    Public wg_sDatCon21 As String = ""
    Public wg_sSelCon21 As String = ""
    Public wg_sTipCon21 As String = ""
    Public wg_sTitCon21 As String = ""
    Public wg_sCmpOrdCon21 As String = ""
    Public wg_sTipOrdCon21 As String = ""
    Public wg_sCmpCon22 As String = ""
    Public wg_sDatCon22 As String = ""
    Public wg_sSelCon22 As String = ""
    Public wg_sTipCon22 As String = ""
    Public wg_sTitCon22 As String = ""
    Public wg_sCmpOrdCon22 As String = ""
    Public wg_sTipOrdCon22 As String = ""
    Public wr_bEOFCon2 As Boolean

    'TSB

    ' wl_nClaPpltsb: 1 - un campo, 2 - dos campos
    ' wl_sCmptsb1: nombre del campo de busqueda
    ' wl_nCmpCla: 1 - nId, 2 - Llave principal 

    Public wg_nClaPpltsb As Integer
    Public wg_nCmpCla As Integer
    Public wg_sClaPpl As String = ""
    Public wg_sCmpTSB As String = ""
    Public wg_sDatTSB As String = ""
    Public wg_sTipCmpTSB As String = ""
    Public wg_sCmpTSB1 As String = ""
    Public wg_sDatTSB1 As String = ""
    Public wg_sTipCmpTSB1 As String = ""
    Public wg_sCmpTSB2 As String = ""
    Public wg_sDatTSB2 As String = ""
    Public wg_sTipCmpTSB2 As String = ""

    ' Otras

    Public wg_sTipTbl As String = ""
    'E1 = Tabla Principal de la frm: Encabezado con 1 llave
    'E2 = Tabla Principal de la frm: Encabezado con 2 llave. Tabla secundaria de la frm: Encabezado
    'L1 = Tabla 1  Detalle/líneas
    'L2 = Tabla 2  Detalle/líneas
    'L3 = Tabla 3  Detalle/líneas

    Public wg_sNomFrm As String = ""
    Public wg_tsbboton As String = ""
    Public wg_sCodStr As String = ""

    ' Configuración datagridview

    Public wg_RowAlto As Integer
    Public wg_RowAncho As Integer
    Public wg_ColAlto As Integer

#End Region

#Region "wg Variable Datos BD Global"

    Public wg_sCodItm As String = ""
    Public wg_sCodTer As String = ""

#End Region
#Region "Objetos"
    ' Colores

    Public wg_ClrFrm As Color = Color.AliceBlue
    Public wg_ClrGot As Color = Color.PaleGoldenrod
    Public wg_ClrLost As Color = Color.White
    Public wg_ClrEnableT As Color = Color.AliceBlue
    Public wg_ClrEnableF As Color = Color.PaleGoldenrod
    Public wg_ClrReadOnlyT As Color = Color.AliceBlue
    Public wg_ClrReadOnlyF As Color = Color.White

    Public wg_ClrTree As Color = Color.LightSteelBlue
    'Controles
    Public wg_oCtr As Control


    'DT - DataTable. Encabezado. Detalle. Lista. Reporte. Consulta 

    Public wg_DT As New DataTable

    Public wg_DTE1 As New DataTable
    Public wg_DTE2 As New DataTable
    Public wg_DTL1 As New DataTable
    Public wg_DTL2 As New DataTable

    Public wg_DTCon1 As New DataTable
    Public wg_DTErr1 As New DataTable
    Public wg_DTLst1 As New DataTable
    Public wg_DTDGV1 As New DataTable

    ' Formularios
    Public wg_FrmLst As New frmGQLst

    'Clases
    Public clnConTbl As New ClaseNegocios.clnConTbl
    Public clnActTbl As New ClaseNegocios.clnActTbl
    Public clnATERR As New ClaseNegocios.clnATERR
    Public clnIEDMI As New ClaseNegocios.clnIEDMI
#End Region
#Region "Estructuras"

    'Estructuras

    Public vg_eACDEM As New moe_Estructuras.eACDEM

    Public wg_eACPAG As New moe_Estructuras.eACPAG

    Public wg_eAPDGV As New moe_Estructuras.eAPDGV
    Public wg_aeAPDGV() As moe_Estructuras.eAPDGV

    Public wg_eAPQDG As New moe_Estructuras.eAPQDG
    Public wg_aeAPQDG() As moe_Estructuras.eAPQDG

    Public wg_eAPRDG As New moe_Estructuras.eAPRDG
    Public wg_aeAPRDG() As moe_Estructuras.eAPRDG

    Public wg_eATALM As New moe_Estructuras.eATALM
    Public wg_aeATALM() As moe_Estructuras.eATALM

    Public wg_eATAUT As New moe_Estructuras.eATAUT
    Public wg_aeATAUT() As moe_Estructuras.eATAUT

    Public wg_eATCIF As New moe_Estructuras.eATCIF
    Public wg_aeATCIF() As moe_Estructuras.eATCIF

    Public wg_eATCCO As New moe_Estructuras.eATCCO
    Public wg_aeATCCO() As moe_Estructuras.eATCCO

    Public wg_eATIVA As New moe_Estructuras.eATIVA
    Public wg_aeATIVA() As moe_Estructuras.eATIVA

    Public wg_eATOPE As New moe_Estructuras.eATOPE
    Public wg_aeATOPE() As moe_Estructuras.eATOPE

    Public wg_eATPOP As New moe_Estructuras.eATPOP
    Public wg_aeATPOP() As moe_Estructuras.eATPOP

    Public wg_eATVEN As New moe_Estructuras.eATVEN
    Public wg_aeATVEN() As moe_Estructuras.eATVEN

    Public wg_eCEFAP As New moe_Estructuras.eGEMOV
    Public wg_aeCEFAP() As moe_Estructuras.eGEMOV
    Public wg_eCLFAP1 As New moe_Estructuras.eGLMOV1
    Public wg_aeCLFAP1() As moe_Estructuras.eGLMOV1

    Public wg_eCEODC As New moe_Estructuras.eGEMOV
    Public wg_aeCEODC() As moe_Estructuras.eGEMOV
    Public wg_eCLODC1 As New moe_Estructuras.eGLMOV1
    Public wg_aeCLODC1() As moe_Estructuras.eGLMOV1

    Public wg_eFTPUC As New moe_Estructuras.eFTPUC
    Public wg_aeFTPUC() As moe_Estructuras.eFTPUC

    Public wg_eGEMOV As New moe_Estructuras.eGEMOV
    Public wg_aeGEMOV() As moe_Estructuras.eGEMOV

    Public wg_eGLMOV1 As New moe_Estructuras.eGLMOV1
    Public wg_aeGLMOV1() As moe_Estructuras.eGLMOV1

    Public wg_eGELMOV1 As New moe_Estructuras.eGELMOV1
    Public wg_aeGELMOV1() As moe_Estructuras.eGELMOV1

    Public wg_eHEDMT As New moe_Estructuras.eHEDMT
    Public wg_aeHEDMT() As moe_Estructuras.eHEDMT

    Public wg_eIEDMI As New moe_Estructuras.eIEDMI
    Public wg_aeIEDMI() As moe_Estructuras.eIEDMI

    Public wg_eILDMI1 As New moe_Estructuras.eILDMI1
    Public wg_aeILDMI1() As moe_Estructuras.eILDMI1

    Public wg_eIELDMI1 As New moe_Estructuras.eIELDMI1
    Public wg_aeIELDMI1() As moe_Estructuras.eIELDMI1

    Public wg_eILDMI2 As New moe_Estructuras.eILDMI2
    Public wg_aeILDMI2() As moe_Estructuras.eILDMI2

    Public wg_eIEREV As New moe_Estructuras.eIEREV
    Public wg_aeIEREV() As moe_Estructuras.eIEREV

    Public wg_eILREV1 As New moe_Estructuras.eILREV1
    Public wg_aeILREV1() As moe_Estructuras.eILREV1

    Public wg_eKARDEX As New moe_Estructuras.eKARDEX
    Public wg_aeKARDEX() As moe_Estructuras.eKARDEX

    Public wg_ePEODP As New moe_Estructuras.ePEODP
    Public wg_aePEODP() As moe_Estructuras.ePEODP

    Public wg_ePLODP1 As New moe_Estructuras.ePLODP1
    Public wg_aePLODP1() As moe_Estructuras.ePLODP1

    Public wg_ePLODP2 As New moe_Estructuras.ePLODP2
    Public wg_aePLODP2() As moe_Estructuras.ePLODP2

    Public wg_ePLODP3 As New moe_Estructuras.ePLODP3
    Public wg_aePLODP3() As moe_Estructuras.ePLODP3

    Public wg_ePEODP_PLODP4 As New moe_Estructuras.ePEODP_PLODP4
    Public wg_aePEODP_PLODP4() As moe_Estructuras.ePEODP_PLODP4

    Public wg_ePERCI As New moe_Estructuras.ePERCI
    Public wg_aePERCI() As moe_Estructuras.ePERCI

    Public wg_ePLRCI1 As New moe_Estructuras.ePLRCI1
    Public wg_aePLRCI1() As moe_Estructuras.ePLRCI1

    Public wg_ePEROP As New moe_Estructuras.ePEROP
    Public wg_aePEROP() As moe_Estructuras.ePEROP

    Public wg_ePLROP1 As New moe_Estructuras.ePLROP1
    Public wg_aePLROP1() As moe_Estructuras.ePLROP1

    Public wg_ePELROP1 As New moe_Estructuras.ePELROP1
    Public wg_aePELROP1() As moe_Estructuras.ePELROP1

    Public wg_eQ_PQFOM1 As New moe_Estructuras.eQ_PQFOM1
    Public wg_aeQ_PQFOM1() As moe_Estructuras.eQ_PQFOM1

    Public wg_eQ_PQLIM1 As New moe_Estructuras.eQ_PQLIM1
    Public wg_aeQ_PQLIM1() As moe_Estructuras.eQ_PQLIM1


    Public wg_eSdoAlm As New moe_Estructuras.eSdoAlm
    Public wg_aeSdoAlm() As moe_Estructuras.eSdoAlm

    Public wg_eTEDMT As New moe_Estructuras.eTEDMT
    Public wg_aeTEDMT() As moe_Estructuras.eTEDMT

    Public wg_eTLDMT1 As New moe_Estructuras.eTLDMT1
    Public wg_aeTLDMT1 As moe_Estructuras.eTLDMT1

    Public wg_eTLDMT2 As New moe_Estructuras.eTLDMT2
    Public wg_aeTLDMT2 As moe_Estructuras.eTLDMT2

    Public wg_eTLDMT3 As New moe_Estructuras.eTLDMT3
    Public wg_aeTLDMT3 As moe_Estructuras.eTLDMT3

    Public wg_eTLDMT4 As New moe_Estructuras.eTLDMT4
    Public wg_aeTLDMT4 As moe_Estructuras.eTLDMT4

    Public wg_eWTCIU As New moe_Estructuras.eWTCIU
    Public wg_aeWTCIU As moe_Estructuras.eWTCIU

    Public wg_eWTDEP As New moe_Estructuras.eWTDEP
    Public wg_aeWTDEP As moe_Estructuras.eWTDEP

    Public wg_eWTPAI As New moe_Estructuras.eWTPAI
    Public wg_aeWTPAI As moe_Estructuras.eWTPAI

    Public wg_eWTTID As New moe_Estructuras.eWTTID
    Public wg_aeWTTID As moe_Estructuras.eWTTID

    Public wg_eQConSdoFin As New moe_Estructuras.eQConSdoFin
    Public wg_aeQConSdoFin As moe_Estructuras.eQConSdoFin

#End Region

End Module
