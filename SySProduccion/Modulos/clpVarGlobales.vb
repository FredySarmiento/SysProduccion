Module clpVarGlobales



#Region "vg Variable BD Global"
    Public vg_sCodcia As String = ""
    Public vg_sNomCia As String = ""

    Public vg_sCodUsr As String
    Public vg_sPwdUsr As String
    Public vg_sNomUsr As String

    Public vg_bFinSys As Boolean
    Public vg_sCodErr As String
    Public vg_sDesErr As String
    Public vg_sCodClr As String

#End Region
#Region "vg parámetros ACPAG "
    Public vg_sLmtCre As String
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
    Public vg_sCtaCbtxDef As String
    Public vg_sVisItmIna As String
    Public vg_sRutXls As String
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
    Public wp_nColDocBas As Integer

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
    Public wg_nSelCon13 As Double
    Public wg_sTitCon13 As String = ""
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



#End Region
#Region "Objetos"
    ' Colores

    Public wg_ClrFrm As Color = Color.AliceBlue
    Public wg_ClrGot As Color = Color.PaleGoldenrod
    Public wg_ClrLost As Color = Color.White
    Public wg_ClrEnable As Color = Color.AliceBlue

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

    'Estructuras

    Public wp_eGEMOV As strGEMOV
    Public wp_eAPDGV As strAPDGV

#End Region



End Module
