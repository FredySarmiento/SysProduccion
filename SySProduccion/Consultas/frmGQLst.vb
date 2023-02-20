Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmGQLst
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23
#Region "001 Inicia. wg - vg Definición del variables públicas"

    'Estructuras
    Public Property wp_eABEOC As moe_Estructuras.eABEOC
    Public Property wp_eABEOP As moe_Estructuras.eABEOP
    Public Property wp_eABODP As moe_Estructuras.eABODP
    Public Property wp_eAPLND1 As moe_Estructuras.eAPLND1
    Public Property wp_eATALM As moe_Estructuras.eATALM
    Public Property wp_eATANA As moe_Estructuras.eATANA
    Public Property wp_eATCCO As moe_Estructuras.eATCCO
    Public Property wp_eATCIF As moe_Estructuras.eATCIF
    Public Property wp_eATCTR As moe_Estructuras.eATCTR
    Public Property wp_eATGRI As moe_Estructuras.eATGRI
    Public Property wp_eATIVA As moe_Estructuras.eATIVA
    Public Property wp_eATMON As moe_Estructuras.eATMON
    Public Property wp_eATOPE As moe_Estructuras.eATOPE
    Public Property wp_eATPCO As moe_Estructuras.eATPCO
    Public Property wp_eATPOP As moe_Estructuras.eATPOP
    Public Property wp_eATTIN As moe_Estructuras.eATTIN
    Public Property wp_eATVEN As moe_Estructuras.eATVEN
    Public Property wp_eATZON As moe_Estructuras.eATZON
    Public Property wp_eFTPUC As moe_Estructuras.eFTPUC
    Public Property wp_eGEMOV As moe_Estructuras.eGEMOV
    Public Property wp_eGEMOV_Ini As moe_Estructuras.eGEMOV
    Public Property wp_eGEMOV_Fin As moe_Estructuras.eGEMOV
    Public Property wp_eGEMOV_Grl As moe_Estructuras.eGEMOV
    Public Property wp_eGELMOV1 As moe_Estructuras.eGELMOV1
    Public Property wp_eGELMOV1_Ini As moe_Estructuras.eGELMOV1
    Public Property wp_eGELMOV1_Fin As moe_Estructuras.eGELMOV1
    Public Property wp_eGELMOV1_Grl As moe_Estructuras.eGELMOV1

    Public Property wp_eHEDMT As moe_Estructuras.eHEDMT
    Public Property wp_eIEDMI As moe_Estructuras.eIEDMI
    Public Property wp_eIEDMI_Ini As moe_Estructuras.eIEDMI
    Public Property wp_eIEDMI_Fin As moe_Estructuras.eIEDMI
    Public Property wp_eIEDMI_QGrl As moe_Estructuras.eIEDMI
    Public Property wp_eIELDMI1 As moe_Estructuras.eIELDMI1
    Public Property wp_eIEREV As moe_Estructuras.eIEREV
    Public Property wp_eILDMI2 As moe_Estructuras.eILDMI2
    Public Property wp_eILREV1 As moe_Estructuras.eILREV1
    Public Property wp_eKARDEX As moe_Estructuras.eKARDEX
    Public Property wp_eKARDEX_Ini As moe_Estructuras.eKARDEX
    Public Property wp_eKARDEX_Fin As moe_Estructuras.eKARDEX
    Public Property wp_eKARDEX_QGrl As moe_Estructuras.eKARDEX
    Public Property wp_ePEFOM As moe_Estructuras.ePEFOM
    Public Property wp_ePELIM As moe_Estructuras.ePELIM
    Public Property wp_ePEODP As moe_Estructuras.ePEODP
    Public Property wp_ePELROP1 As moe_Estructuras.ePELROP1
    Public Property wp_ePEODP_Ini As moe_Estructuras.ePEODP
    Public Property wp_ePEODP_Fin As moe_Estructuras.ePEODP
    Public Property wp_ePEODP_QGrl As moe_Estructuras.ePEODP
    Public Property wp_ePEODP_PLODP4 As moe_Estructuras.ePEODP_PLODP4
    Public Property wp_ePEODP_PLODP4_Ini As moe_Estructuras.ePEODP_PLODP4
    Public Property wp_ePEODP_PLODP4_Fin As moe_Estructuras.ePEODP_PLODP4
    Public Property wp_ePEODP_PLODP4_QGrl As moe_Estructuras.ePEODP_PLODP4
    Public Property wp_ePEROP As moe_Estructuras.ePEROP
    Public Property wp_ePEROP_Ini As moe_Estructuras.ePEROP
    Public Property wp_ePEROP_Fin As moe_Estructuras.ePEROP
    Public Property wp_ePEROP_Grl As moe_Estructuras.ePEROP

    Public Property wp_ePLODP1 As moe_Estructuras.ePLODP1
    Public Property wp_ePLODP2 As moe_Estructuras.ePLODP2
    Public Property wp_ePLODP3 As moe_Estructuras.ePLODP3
    Public Property wp_ePLROP1 As moe_Estructuras.ePLROP1
    Public Property wp_ePLROP1_Ini As moe_Estructuras.ePLROP1
    Public Property wp_ePLROP1_Fin As moe_Estructuras.ePLROP1
    Public Property wp_ePLROP1_Grl As moe_Estructuras.ePLROP1
    Public Property wp_eQ_PQFOM1 As moe_Estructuras.eQ_PQFOM1
    Public Property wp_eQ_PQLIM1 As moe_Estructuras.eQ_PQLIM1
    Public Property wp_eTEDMT As moe_Estructuras.eTEDMT


    'variables
    Public Property vp_sCodAlm As String
    Public Property vp_sCodDoc As String
    Public Property vp_sCodItm As String
    Public Property vp_sCodCmt As String
    Public Property vp_sCodSer As String
    Public Property vp_sCodStr As String
    Public Property vp_sCodTer As String
    Public Property vp_sEstOdp As String
    Public Property vp_nNroDoc As Long
    Public Property wp_bImpItmInac As Boolean
    Public Property wp_bImpItmCero As Boolean
    Public Property wp_bVdaCanMin As Boolean
    Public Property vp_sTipTer As String
    Public Property wp_sTlbMov As String
    Public Property wp_sMayMenIgu As String

    Public Property wp_Q_ePELIM_eIEDMI As moe_Estructuras.Q_ePELIM_eIEDMI
    Public Property wp_Q1_eILDMI2 As moe_Estructuras.Q1_eILDMI2
    Public Property wp_sFrmOri As String
    Public Property wp_sTxtFrm As String
    Public Property wp_sNomCmp As String
    Public Property wp_sTipCmp As String
    Public Property wp_sDatCmp As String
    Public Property wp_dFecDocIni As Date
    Public Property wp_dFecDocFin As Date
    Public Property wp_sNomTblTmp As String

#End Region
#Region "011 frm - Variables Locales"
    ' Variables locales
    Dim wl_RowAlto As Integer
    Dim wl_nTab As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColIni As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nColVda1 As Integer
    Dim wl_nColVda2 As Integer
    Dim wl_sOpeLgc As String
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nCntReg As Integer
    Dim wl_nColOrd As Integer
    Dim vl_nTamCmp As Integer
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_YIni As Integer ' dgv1.CurrentCellAddress.Y Row
    Dim wl_YFin As Integer ' dgv1.CurrentCellAddress.Y Row
    Dim wl_sNomCmp As String
    Dim wl_sTipCmp As String
    Dim wl_sNomCmp1 As String
    Dim wl_sDatCmp1 As String
    Dim wl_sTipCmp1 As String
    Dim wl_sCmpOrd As String
    Dim wl_sTipOrd As String
    Dim wl_sCmpOrd1 As String
    Dim wl_sTipOrd1 As String
#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim wl_nTotcol As Integer
    Dim wl_sSelCon11 As String
    Dim wl_sSelCon12 As String
    Dim wl_nSelCon13 As Double
    Dim wl_sSelCon14 As String

#End Region
    ' Objetos del formulario
#Region "014 Objetos locales"
    Dim clnConTbl As New ClaseNegocios.clnConTbl
    Dim clnTblAb As New ClaseNegocios.clnTblAB
#End Region
#Region "015 Estructuras"
    Dim wl_aeABEOC() As moe_Estructuras.eABEOC
    Dim wl_aeABEOP() As moe_Estructuras.eABEOP
    Dim wl_aeABODP() As moe_Estructuras.eABODP
    Dim wl_aeAPLND1() As moe_Estructuras.eAPLND1
    Dim wl_aeATALM() As moe_Estructuras.eATALM
    Dim wl_aeATANA() As moe_Estructuras.eATANA
    Dim wl_aeATCCO() As moe_Estructuras.eATCCO
    Dim wl_aeATCIF() As moe_Estructuras.eATCIF
    Dim wl_aeATCTR() As moe_Estructuras.eATCTR
    Dim wl_aeATGRI() As moe_Estructuras.eATGRI
    Dim wl_aeATIVA() As moe_Estructuras.eATIVA
    Dim wl_aeATMON() As moe_Estructuras.eATMON
    Dim wl_aeATOPE() As moe_Estructuras.eATOPE
    Dim wl_aeATPCO() As moe_Estructuras.eATPCO
    Dim wl_aeATPOP() As moe_Estructuras.eATPOP
    Dim wl_aeATTIN() As moe_Estructuras.eATTIN
    Dim wl_aeATVEN() As moe_Estructuras.eATVEN
    Dim wl_aeATZON() As moe_Estructuras.eATZON
    Dim wl_aeCEODC() As moe_Estructuras.eGEMOV
    Dim wl_aeCEENI() As moe_Estructuras.eGEMOV
    Dim wl_aeCEFAP() As moe_Estructuras.eGEMOV
    Dim wl_aeCESAI() As moe_Estructuras.eGEMOV
    Dim wl_aeFTPUC() As moe_Estructuras.eFTPUC
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV_Ini() As moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV_Fin() As moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV_Grl() As moe_Estructuras.eGEMOV
    Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wl_aeGELMOV1_Ini() As moe_Estructuras.eGELMOV1
    Dim wl_aeGELMOV1_Fin() As moe_Estructuras.eGELMOV1
    Dim wl_aeGELMOV1_Grl() As moe_Estructuras.eGELMOV1

    Dim wl_aeHEDMT() As moe_Estructuras.eHEDMT
    Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
    Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
    Dim wl_aeIEDMI_Ini() As moe_Estructuras.eIEDMI
    Dim wl_aeIEDMI_Fin() As moe_Estructuras.eIEDMI
    Dim wl_aeIEDMI_QGrl() As moe_Estructuras.eIEDMI
    Dim wl_aeIEENI() As moe_Estructuras.eGEMOV
    Dim wl_aeIESAI() As moe_Estructuras.eGEMOV
    Dim wl_aeIEREV() As moe_Estructuras.eIEREV
    Dim wl_aeIETRI() As moe_Estructuras.eGEMOV
    Dim wl_aeILREV1() As moe_Estructuras.eILREV1
    Dim wl_aeKARDEX() As moe_Estructuras.eKARDEX
    Dim wl_aeKARDEX_Ini() As moe_Estructuras.eKARDEX
    Dim wl_aeKARDEX_Fin() As moe_Estructuras.eKARDEX
    Dim wl_aeKARDEX_QGrl() As moe_Estructuras.eKARDEX
    Dim wl_aePEEDM() As moe_Estructuras.eGEMOV
    Dim wl_aePEEDP() As moe_Estructuras.eGEMOV
    Dim wl_aePEFOM() As moe_Estructuras.ePEFOM
    Dim wl_aePELIM() As moe_Estructuras.ePELIM
    Dim wl_aePEODP() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_Ini() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_Fin() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_QGrl() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_PLODP4() As moe_Estructuras.ePEODP_PLODP4
    Dim wl_aePEODP_PLODP4_Ini() As moe_Estructuras.ePEODP_PLODP4
    Dim wl_aePEODP_PLODP4_Fin() As moe_Estructuras.ePEODP_PLODP4
    Dim wl_aePEODP_PLODP4_QGrl() As moe_Estructuras.ePEODP_PLODP4

    Dim wl_aePELROP1() As moe_Estructuras.ePELROP1

    Dim wl_aePEROP() As moe_Estructuras.ePEROP
    Dim wl_aePEROP_Ini() As moe_Estructuras.ePEROP
    Dim wl_aePEROP_Fin() As moe_Estructuras.ePEROP
    Dim wl_aePEROP_Grl() As moe_Estructuras.ePEROP


    Dim wl_aePESDM() As moe_Estructuras.eGEMOV
    Dim wl_aePESDP() As moe_Estructuras.eGEMOV
    Dim wl_aePLODP1() As moe_Estructuras.ePLODP1
    Dim wl_aePLODP2() As moe_Estructuras.ePLODP2
    Dim wl_aePLODP3() As moe_Estructuras.ePLODP3
    Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
    Dim wl_aePLROP1_Ini() As moe_Estructuras.ePLROP1
    Dim wl_aePLROP1_Fin() As moe_Estructuras.ePLROP1
    Dim wl_aePLROP1_Grl() As moe_Estructuras.ePLROP1
    Dim wl_aeQ_PQFOM1() As moe_Estructuras.eQ_PQFOM1
    Dim wl_aeQ_PQLIM1() As moe_Estructuras.eQ_PQLIM1

    Dim wl_aePLROP_Grl() As moe_Estructuras.ePLROP1
    Dim wl_aeTEDMT() As moe_Estructuras.eTEDMT
    Dim wl_aeVEENI() As moe_Estructuras.eGEMOV
    Dim wl_aeVESAI() As moe_Estructuras.eGEMOV

    Dim wl_aQ_ePELIM_eIEDMI() As moe_Estructuras.Q_ePELIM_eIEDMI
    Dim wl_Q1_aeILDMI2() As moe_Estructuras.Q1_eILDMI2

    Dim wl_eABEOC As New moe_Estructuras.eABEOC
    Dim wl_eABEOP As New moe_Estructuras.eABEOP
    Dim wl_eABODP As New moe_Estructuras.eABODP
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATANA As New moe_Estructuras.eATANA
    Dim wl_eATCCO As New moe_Estructuras.eATCCO
    Dim wl_eATCIF = New moe_Estructuras.eATCIF
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
    Dim wl_eATGRI As New moe_Estructuras.eATGRI
    Dim wl_eATIVA As New moe_Estructuras.eATIVA
    Dim wl_eATMON As New moe_Estructuras.eATMON
    Dim wl_eATOPE = New moe_Estructuras.eATOPE
    Dim wl_eATPCO = New moe_Estructuras.eATPCO
    Dim wl_eATPOP = New moe_Estructuras.eATPOP
    Dim wl_eATTIN As New moe_Estructuras.eATTIN
    Dim wl_eATVEN As New moe_Estructuras.eATVEN
    Dim wl_eATZON As New moe_Estructuras.eATZON
    Dim wl_eCEODC = New moe_Estructuras.eGEMOV
    Dim wl_eCEENI = New moe_Estructuras.eGEMOV
    Dim wl_eCEFAP = New moe_Estructuras.eGEMOV
    Dim wl_eCESAI = New moe_Estructuras.eGEMOV
    Dim wl_eFTPUC = New moe_Estructuras.eFTPUC
    Dim wl_eGEMOV = New moe_Estructuras.eGEMOV
    Dim wl_eGEMOV_Fin = New moe_Estructuras.eGEMOV
    Dim wl_eGEMOV_Grl = New moe_Estructuras.eGEMOV
    Dim wl_eGEMOV_Ini = New moe_Estructuras.eGEMOV
    Dim wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
    Dim wl_eGELMOV1_Fin = New moe_Estructuras.eGELMOV1
    Dim wl_eGELMOV1_Grl = New moe_Estructuras.eGELMOV1
    Dim wl_eGELMOV1_Ini = New moe_Estructuras.eGELMOV1
    Dim wl_eHEDMT = New moe_Estructuras.eHEDMT
    Dim wl_eIEDMI = New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_QGrl = New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_Ini = New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_Fin = New moe_Estructuras.eIEDMI
    Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
    Dim wl_eIEENI = New moe_Estructuras.eGEMOV
    Dim wl_eIESAI = New moe_Estructuras.eGEMOV
    Dim wl_eIEREV = New moe_Estructuras.eIEREV
    Dim wl_eIETRI = New moe_Estructuras.eGEMOV
    Dim wl_eILREV1 = New moe_Estructuras.eILREV1
    Dim wl_eKARDEX = New moe_Estructuras.eKARDEX
    Dim wl_eKARDEX_QGrl = New moe_Estructuras.eKARDEX
    Dim wl_eKARDEX_Ini = New moe_Estructuras.eKARDEX
    Dim wl_eKARDEX_Fin = New moe_Estructuras.eKARDEX
    Dim wl_ePEEDM = New moe_Estructuras.eGEMOV
    Dim wl_ePEEDP = New moe_Estructuras.eGEMOV
    Dim wl_ePEFOM = New moe_Estructuras.ePEFOM
    Dim wl_ePELIM = New moe_Estructuras.ePELIM
    Dim wl_ePEODP = New moe_Estructuras.ePEODP
    Dim wl_ePEODP_Fin = New moe_Estructuras.ePEODP
    Dim wl_ePEODP_Ini = New moe_Estructuras.ePEODP
    Dim wl_ePEODP_QGrl = New moe_Estructuras.ePEODP
    Dim wl_ePEODP_PLODP4 = New moe_Estructuras.ePEODP_PLODP4
    Dim wl_ePEODP_PLODP4_Fin = New moe_Estructuras.ePEODP_PLODP4
    Dim wl_ePEODP_PLODP4_Ini = New moe_Estructuras.ePEODP_PLODP4
    Dim wl_ePEODP_PLODP4_QGrl = New moe_Estructuras.ePEODP_PLODP4

    Dim wl_ePELROP1 = New moe_Estructuras.ePELROP1
    Dim wl_ePEROP = New moe_Estructuras.ePEROP
    Dim wl_ePEROP_Fin = New moe_Estructuras.ePEROP
    Dim wl_ePEROP_Grl = New moe_Estructuras.ePEROP
    Dim wl_ePEROP_Ini = New moe_Estructuras.ePEROP
    Dim wl_ePESDM = New moe_Estructuras.eGEMOV
    Dim wl_ePESDP = New moe_Estructuras.eGEMOV
    Dim wl_ePLODP1 = New moe_Estructuras.ePLODP1
    Dim wl_ePLODP2 = New moe_Estructuras.ePLODP2
    Dim wl_ePLODP3 = New moe_Estructuras.ePLODP3
    Dim wl_ePLROP1 = New moe_Estructuras.ePLROP1
    Dim wl_ePLROP1_Fin = New moe_Estructuras.ePLROP1
    Dim wl_ePLROP1_Grl = New moe_Estructuras.ePLROP1
    Dim wl_ePLROP1_Ini = New moe_Estructuras.ePLROP1
    Dim wl_eQ_PQFOM1 = New moe_Estructuras.eQ_PQFOM1
    Dim wl_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1

    Dim wl_eTEDMT = New moe_Estructuras.eTEDMT
    Dim wl_eVEENI = New moe_Estructuras.eGEMOV
    Dim wl_eVESAI = New moe_Estructuras.eGEMOV
    Dim wl_Q_ePELIM_eIEDMI = New moe_Estructuras.Q_ePELIM_eIEDMI
    Dim wl_Q1_eILDMI2 = New moe_Estructuras.Q1_eILDMI2

#End Region
#Region "016 Variables para exportar a Excel"
    'Dim excelLocation As String = "C:\Siles\prueba.xlsx"

    'Dim oApp As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
    'Dim oWorkBook As Microsoft.Office.Interop.Excel._Workbook = oApp.Workbooks.Add(Type.Missing)
    'Dim oWorkSheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing

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
    Private Sub frmGQLst_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            If wg_sTblCon1 = "ABEOC" Then
                If wl_aeABEOC.Length <> 0 Then
                    If wl_aeABEOC(0).sCodEstODC <> "" Then
                        wp_eABEOC = wl_aeABEOC(0)
                        wl_eABEOC = wl_aeABEOC(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "ABEOP" Then
                If wl_aeABEOP.Length <> 0 Then
                    If wl_aeABEOP(0).sCodEstODP <> "" Then
                        wp_eABEOP = wl_aeABEOP(0)
                        wl_eABEOP = wl_aeABEOP(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "ABODP" Then
                If wl_aeABODP.Length <> 0 Then
                    If wl_aeABODP(0).sCodDoc <> "" Then
                        wp_eABODP = wl_aeABODP(0)
                        wl_eABODP = wl_aeABODP(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "APLND1" Then
                If wl_aeAPLND1.Length <> 0 Then
                    If wl_aeAPLND1(0).sCodDoc <> "" Then
                        wp_eAPLND1 = wl_aeAPLND1(0)
                        wl_eAPLND1 = wl_aeAPLND1(0)
                    End If
                End If
            End If
            If dgv1.Rows.Count > 0 Then
                If wg_sTblCon1 = "ATALM" Then
                    If wl_aeATALM(0).sCodAlm <> "" Then
                        wl_eATALM = wl_aeATALM(0)
                        wp_eATALM = wl_aeATALM(0)
                    End If
                End If
                If wg_sTblCon1 = "ATANA" Then
                    If wl_aeATANA(0).sCodAna <> "" Then
                        wl_eATANA = wl_aeATANA(0)
                        wp_eATANA = wl_aeATANA(0)
                    End If
                End If
                If wg_sTblCon1 = "ATCCO" Then
                    If wl_aeATCCO.Length <> 0 Then
                        If wl_aeATCCO(0).sCodCco <> "" Then
                            wp_eATCCO = wl_aeATCCO(0)
                            wl_eATCCO = wl_aeATCCO(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATCTR" Then
                    If wl_aeATCTR.Length <> 0 Then
                        If wl_aeATCTR(0).sCodCtr <> "" Then
                            wp_eATCTR = wl_aeATCTR(0)
                            wl_eATCTR = wl_aeATCTR(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATCIF" Then
                    If wl_aeATCIF.Length <> 0 Then
                        If wl_aeATCIF(0).sCodCIF <> "" Then
                            wl_eATCIF = wl_aeATCIF(0)
                            wp_eATCIF = wl_aeATCIF(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATGRI" Then
                    If wl_aeATGRI.Length <> 0 Then
                        If wl_aeATGRI(0).sCodGrp <> "" Then
                            wp_eATGRI = wl_aeATGRI(0)
                            wl_eATGRI = wl_aeATGRI(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATIVA" Then
                    If wl_aeATIVA.Length <> 0 Then
                        If wl_aeATIVA(0).sCodIVA <> "" Then
                            wp_eATIVA = wl_aeATIVA(0)
                            wl_eATIVA = wl_aeATIVA(0)
                            wg_eATIVA = wl_aeATIVA(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATMON" Then
                    If wl_aeATMON.Length <> 0 Then
                        If wl_aeATMON(0).sCodMon <> "" Then
                            wp_eATMON = wl_aeATMON(0)
                            wl_eATMON = wl_aeATMON(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATOPE" Then
                    If wl_aeATOPE.Length <> 0 Then
                        If wl_aeATOPE(0).sCodOpe <> "" Then
                            wl_eATOPE = wl_aeATOPE(0)
                            wp_eATOPE = wl_aeATOPE(0)
                            wg_eATOPE = wl_aeATOPE(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATPCO" Then
                    If wl_aeATPCO.Length <> 0 Then
                        If wl_aeATPCO(0).sCodPdo <> "" Then
                            wl_eATPCO = wl_aeATPCO(0)
                            wp_eATPCO = wl_aeATPCO(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATPOP" Then
                    If wl_aeATPOP.Length <> 0 Then
                        If wl_aeATPOP(0).sCodTer <> "" Then
                            wl_eATPOP = wl_aeATPOP(0)
                            wp_eATPOP = wl_aeATPOP(0)
                            wg_eATPOP = wl_aeATPOP(0)
                            wg_aeATPOP = wl_aeATPOP
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATTIN" Then
                    If wl_aeATTIN(0).sCodTra <> "" Then
                        wl_eATTIN = wl_aeATTIN(0)
                        wp_eATTIN = wl_aeATTIN(0)
                    End If
                End If
                If wg_sTblCon1 = "ATVEN" Then
                    If wl_aeATVEN.Length <> 0 Then
                        If wl_aeATVEN(0).sCodVen <> "" Then
                            wp_eATVEN = wl_aeATVEN(0)
                            wl_eATVEN = wl_aeATVEN(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "ATZON" Then
                    If wl_aeATZON.Length <> 0 Then
                        If wl_aeATZON(0).sCodZON <> "" Then
                            wp_eATZON = wl_aeATZON(0)
                            wl_eATZON = wl_aeATZON(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "CEODC" Then
                    If wl_aeCEODC.Length <> 0 Then
                        If wl_aeCEODC(0).sCodDoc <> "" Then
                            wp_eGEMOV = wl_aeCEODC(0)
                            wl_eGEMOV = wl_aeCEODC(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "CEENI" Then
                    If wl_aeGEMOV.Length <> 0 Then
                        If wl_aeCEENI(0).sCodDoc <> "" Then
                            wp_eGEMOV = wl_aeCEENI(0)
                            wl_eGEMOV = wl_aeCEENI(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "CEFAP" Then
                    If wl_aeCEFAP.Length <> 0 Then
                        If wl_aeCEFAP(0).sCodDoc <> "" Then
                            wp_eGEMOV = wl_aeCEFAP(0)
                            wl_eGEMOV = wl_aeCEFAP(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "CESAI" Then
                    If wl_aeCESAI.Length <> 0 Then
                        If wl_aeCESAI(0).sCodDoc <> "" Then
                            wp_eGEMOV = wl_aeCESAI(0)
                        End If

                    End If
                End If
                If wg_sTblCon1 = "FTPUC" Then
                    If wl_aeFTPUC.Length <> 0 Then
                        If wl_aeFTPUC(0).sCodCta <> "" Then
                            wp_eFTPUC = wl_aeFTPUC(0)
                            wl_eFTPUC = wl_aeFTPUC(0)
                        End If
                    End If
                End If

                If wg_sTblCon1 = "GEMOV" Then
                    If wl_aeGEMOV.Length <> 0 Then
                        If wl_aeGEMOV(0).sCodDoc <> "" Then
                            wp_eGEMOV = wl_aeGEMOV(0)
                            wg_eGEMOV = wl_aeGEMOV(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "GEMOV_Grl" Then
                    If wl_aeGEMOV_Grl.Length <> 0 Then
                        If wl_aeGEMOV_Grl(0).sCodDoc <> "" Or
                              wl_aeGEMOV_Grl(0).sTipMov <> "" Or
                               wl_aeGEMOV_Grl(0).nNroDoc <> 0 Or
                              wl_aeGEMOV_Grl(0).sCodSer <> "" Or
                              wl_aeGEMOV_Grl(0).sCodTer <> "" Or
                              wl_aeGEMOV_Grl(0).sEstDoc <> "" Or
                              wl_aeGEMOV_Grl(0).sCodTra <> "" Then
                            wl_eGEMOV_Grl = wl_aeGEMOV_Grl(0)
                            wp_eGEMOV_Grl = wl_aeGEMOV_Grl(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "GEMOV_IniFin" Then
                    ReDim wg_aeGEMOV(0)
                    wg_aeGEMOV(0) = New moe_Estructuras.eGEMOV

                    If wl_aeGEMOV.Length <> 0 Then
                        If wl_aeGEMOV(0).sCodDoc <> "" Then
                            wl_eGEMOV = wl_aeGEMOV(0)
                            wp_eGEMOV = wl_aeGEMOV(0)
                            wg_aeGEMOV = wl_aeGEMOV
                        End If
                    End If
                End If

                If wg_sTblCon1 = "GELMOV1" Then
                    If wl_aeGELMOV1.Length <> 0 Then
                        If wl_aeGELMOV1(0).sCodDoc <> "" Then
                            wp_eGELMOV1 = wl_aeGELMOV1(0)
                            wg_eGELMOV1 = wl_aeGELMOV1(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "GELMOV1_Grl" Then
                    If wl_aeGELMOV1_Grl.Length <> 0 Then
                        If wl_aeGELMOV1_Grl(0).sCodDoc <> "" Or
                              wl_aeGELMOV1_Grl(0).sTipMov <> "" Or
                               wl_aeGELMOV1_Grl(0).nNroDoc <> 0 Or
                              wl_aeGELMOV1_Grl(0).sCodSer <> "" Or
                              wl_aeGELMOV1_Grl(0).sCodTer <> "" Or
                              wl_aeGELMOV1_Grl(0).sEstDoc <> "" Or
                              wl_aeGELMOV1_Grl(0).sCodTra <> "" Or
                              wl_aeGELMOV1_Grl(0).xsCodItm <> "" Then
                            wl_eGELMOV1_Grl = wl_aeGELMOV1_Grl(0)
                            wp_eGELMOV1_Grl = wl_aeGELMOV1_Grl(0)
                        End If
                    End If
                End If
                If wg_sTblCon1 = "GELMOV1_IniFin" Then
                    ReDim wg_aeGELMOV1(0)
                    wg_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
                    If wl_aeGELMOV1.Length <> 0 Then
                        If wl_aeGELMOV1(0).sCodDoc <> "" Then
                            wl_eGELMOV1 = wl_aeGELMOV1(0)
                            wp_eGELMOV1 = wl_aeGELMOV1(0)
                            wg_aeGELMOV1 = wl_aeGELMOV1
                        End If
                    End If
                End If
                If wg_sTblCon1 = "GEMOV_IniFin" Then
                    ReDim wg_aeGEMOV(0)
                    wg_aeGEMOV(0) = New moe_Estructuras.eGEMOV

                    If wl_aeGEMOV.Length <> 0 Then
                        If wl_aeGEMOV(0).sCodDoc <> "" Then
                            wl_eGEMOV = wl_aeGEMOV(0)
                            wp_eGEMOV = wl_aeGEMOV(0)
                            wg_aeGEMOV = wl_aeGEMOV
                        End If
                    End If
                End If


                If wg_sTblCon1 = "IEMOV" Then

                    ReDim wg_aeGEMOV(0)
                    wg_aeGEMOV(0) = New moe_Estructuras.eGEMOV

                    If wl_aeGEMOV.Length <> 0 Then
                        If wl_aeGEMOV(0).sTipMov <> "" Then
                            wg_aeGEMOV = wl_aeGEMOV
                        End If
                    End If
                End If

            End If
            If wg_sTblCon1 = "IEDMI_QIniFin" Then
                ReDim wg_aeIEDMI(0)
                wg_aeIEDMI(0) = New moe_Estructuras.eIEDMI
                If wl_aeIEDMI.Length <> 0 Then
                    If wl_aeIEDMI(0).sCodItm <> "" Then
                        wg_aeIEDMI = wl_aeIEDMI
                    End If
                End If
            End If


            If wg_sTblCon1 = "HEDMT" Then
                If wl_aeHEDMT.Length <> 0 Then
                    If wl_aeHEDMT(0).sCodTer <> "" Then
                        wp_eHEDMT = wl_aeHEDMT(0)
                        wg_eHEDMT = wl_aeHEDMT(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IEDMI" Then
                If wl_aeIEDMI.Length <> 0 Then
                    If wl_aeIEDMI(0).sCodItm <> "" Then
                        wp_eIEDMI = wl_aeIEDMI(0)
                        wg_eIEDMI = wl_aeIEDMI(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IEDMI_QGrl" Then
                If wl_aeIEDMI_QGrl.Length <> 0 Then
                    If wl_aeIEDMI_QGrl(0).sCodItm <> "" Or
                         wl_aeIEDMI_QGrl(0).sCodAlm <> "" Or
                          wl_aeIEDMI_QGrl(0).sCodGrp <> "" Then
                        wl_eIEDMI_QGrl = wl_aeIEDMI_QGrl(0)
                        wp_eIEDMI_QGrl = wl_aeIEDMI_QGrl(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IEDMI_QIniFin" Then
                ReDim wg_aeIEDMI(0)
                wg_aeIEDMI(0) = New moe_Estructuras.eIEDMI
                If wl_aeIEDMI.Length <> 0 Then
                    If wl_aeIEDMI(0).sCodItm <> "" Then
                        wg_aeIEDMI = wl_aeIEDMI
                    End If
                End If
            End If
            If wg_sTblCon1 = "IELDMI1_QIniFin" Then
                ReDim wg_aeIELDMI1(0)
                wg_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1
                If wl_aeIELDMI1.Length <> 0 Then
                    If wl_aeIELDMI1(0).eIEDMI.sCodItm <> "" Then
                        wg_aeIELDMI1 = wl_aeIELDMI1
                    End If
                End If
            End If
            If wg_sTblCon1 = "IEDMIR" Then
                If wl_aeIEDMI.Length <> 0 Then
                    If wl_aeIEDMI(0).sCodItm <> "" Then
                        wp_eIEDMI = wl_aeIEDMI(0)
                        wg_eIEDMI = wl_aeIEDMI(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IEENI" Then
                If wl_aeIEENI.Length <> 0 Then
                    If wl_aeIEENI(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aeIEENI(0)
                        wl_eGEMOV = wl_aeIEENI(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IELDMI1" Then
                If wl_aeIELDMI1.Length <> 0 Then
                    If wl_aeIELDMI1(0).eIEDMI.sCodItm() <> "" Then
                        wp_eIELDMI1 = wl_aeIELDMI1(0)
                    End If
                    wg_sSelCon12 = ""
                    wg_sSelCon15 = ""
                End If
            End If
            If wg_sTblCon1 = "IESAI" Then
                If wl_aeIESAI.Length <> 0 Then
                    If wl_aeIESAI(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aeIESAI(0)
                        wl_eGEMOV = wl_aeIESAI(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IEREV" Then
                If wl_aeIEREV.Length <> 0 Then
                    If wl_aeIEREV(0).sCodDoc <> "" Then
                        wp_eIEREV = wl_aeIEREV(0)
                        wl_eIEREV = wl_aeIEREV(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "IETRI" Then
                If wl_aeIETRI.Length <> 0 Then
                    If wl_aeIETRI(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aeIETRI(0)
                        wl_eGEMOV = wl_aeIETRI(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "ILDMI2" Then
                If wl_Q1_aeILDMI2.Length <> 0 Then
                    If wl_Q1_aeILDMI2(0).eILDMI2.sCodTer <> "" Then
                        wp_Q1_eILDMI2 = wl_Q1_aeILDMI2(0)
                        wl_Q1_eILDMI2 = wl_Q1_aeILDMI2(0)
                    End If
                End If
            End If

            If wg_sTblCon1 = "KARDEX" Then
                If wl_aeKARDEX.Length <> 0 Then
                    If wl_aeKARDEX(0).sCodItm <> "" Then
                        wp_eKARDEX = wl_aeKARDEX(0)
                        wg_eKARDEX = wl_aeKARDEX(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "KARDEX_QGrl" Then
                If wl_aeKARDEX_QGrl.Length <> 0 Then
                    If wl_aeKARDEX_QGrl(0).sCodItm <> "" Or
                         wl_aeKARDEX_QGrl(0).sCodAlm <> "" Then
                        wl_eKARDEX_QGrl = wl_aeKARDEX_QGrl(0)
                        wp_eKARDEX_QGrl = wl_aeKARDEX_QGrl(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "KARDEX_QIniFin" Then
                ReDim wg_aeKARDEX(0)
                wg_aeKARDEX(0) = New moe_Estructuras.eKARDEX
                If wl_aeKARDEX.Length <> 0 Then
                    If wl_aeKARDEX.Length = 1 Then
                        If wl_aeKARDEX(0).sCodItm <> "" Then
                            wg_aeKARDEX = wl_aeKARDEX
                        End If
                    Else
                        If wl_aeKARDEX(1).sCodItm <> "" Then
                            wg_aeKARDEX = wl_aeKARDEX
                        End If
                    End If

                    
                End If
            End If


            If wg_sTblCon1 = "PEEDM" Then
                If wl_aePEEDM.Length <> 0 Then
                    If wl_aePEEDM(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aePEEDM(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEEDP" Then
                If wl_aePEEDP.Length <> 0 Then
                    If wl_aePEEDP(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aePEEDP(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEFOM" Then
                If wl_aePEFOM.Length <> 0 Then
                    If wl_aePEFOM(0).sCodItm <> "" Then
                        wp_ePEFOM = wl_aePEFOM(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PELIM" Then
                If wl_aQ_ePELIM_eIEDMI.Length > 0 Then
                    If wl_aQ_ePELIM_eIEDMI(0).ePELIM.sCodItm <> "" Then
                        wp_Q_ePELIM_eIEDMI = wl_aQ_ePELIM_eIEDMI(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEODP" Then
                If wl_aePEODP.Length <> 0 Then
                    If wl_aePEODP(0).sCodDoc <> "" Then
                        wp_ePEODP = wl_aePEODP(0)
                        wg_ePEODP = wl_aePEODP(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEODP_QGrl" Then
                If wl_aePEODP_QGrl.Length <> 0 Then
                    If wl_aePEODP_QGrl(0).sCodDoc <> "" Or
                         wl_aePEODP_QGrl(0).nNroDoc <> 0 Or
                          wl_aePEODP_QGrl(0).sCodSer <> "" Or
                           wl_aePEODP_QGrl(0).sEstOdp <> "" Or
                            wl_aePEODP_QGrl(0).sCodItm <> "" Or
                             wl_aePEODP_QGrl(0).dFecEmi <> Nothing Or
                              wl_aePEODP_QGrl(0).dFecIni <> Nothing Or
                               wl_aePEODP_QGrl(0).dFecFin <> Nothing Then
                        wl_ePEODP_QGrl = wl_aePEODP_QGrl(0)
                        wp_ePEODP_QGrl = wl_aePEODP_QGrl(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEODP_QIniFin" Then
                ReDim wg_aePEODP(0)
                wg_aePEODP(0) = New moe_Estructuras.ePEODP
                If wl_aePEODP.Length <> 0 Then

                    If wl_aePEODP(0).sCodDoc <> "" Then
                        ' wp_ePEODP = wl_aePEODP(0)
                        wg_aePEODP = wl_aePEODP
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEODP_PLODP4" Then
                If wl_aePEODP_PLODP4.Length <> 0 Then
                    If wl_aePEODP_PLODP4(0).sCodDoc <> "" Then
                        wp_ePEODP_PLODP4 = wl_aePEODP_PLODP4(0)
                        wg_ePEODP_PLODP4 = wl_aePEODP_PLODP4(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEODP_PLODP4_QGrl" Then
                If wl_aePEODP_PLODP4_QGrl.Length <> 0 Then
                    If wl_aePEODP_PLODP4_QGrl(0).sCodDoc <> "" Or
                         wl_aePEODP_PLODP4_QGrl(0).nNroDoc <> 0 Or
                          wl_aePEODP_PLODP4_QGrl(0).sCodSer <> "" Or
                           wl_aePEODP_PLODP4_QGrl(0).sEstOdp <> "" Or
                            wl_aePEODP_PLODP4_QGrl(0).sCodItm <> "" Or
                             wl_aePEODP_PLODP4_QGrl(0).dFecEmi <> Nothing Or
                              wl_aePEODP_PLODP4_QGrl(0).dFecIni <> Nothing Or
                               wl_aePEODP_PLODP4_QGrl(0).dFecFin <> Nothing Then
                        wl_ePEODP_PLODP4_QGrl = wl_aePEODP_PLODP4_QGrl(0)
                        wp_ePEODP_PLODP4_QGrl = wl_aePEODP_PLODP4_QGrl(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEODP_PLODP4_QIniFin" Then
                ReDim wg_aePEODP_PLODP4(0)
                wg_aePEODP_PLODP4(0) = New moe_Estructuras.ePEODP_PLODP4
                If wl_aePEODP_PLODP4.Length <> 0 Then

                    If wl_aePEODP_PLODP4(0).sCodDoc <> "" Then
                        ' wp_ePEODP = wl_aePEODP(0)
                        wg_aePEODP_PLODP4 = wl_aePEODP_PLODP4
                    End If
                End If
            End If

            If wg_sTblCon1 = "PLODP1" Then
                If wl_aePLODP1.Length <> 0 Then
                    If wl_aePLODP1(0).sCodDoc <> "" Then
                        wl_ePLODP1 = wl_aePLODP1(0)
                        wp_ePLODP1 = wl_aePLODP1(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PLODP2" Then
                If wl_aePLODP2.Length <> 0 Then
                    If wl_aePLODP2(0).sCodDoc <> "" Then
                        wl_ePLODP2 = wl_aePLODP2(0)
                        wp_ePLODP2 = wl_aePLODP2(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEROP" Then
                If wl_aePEROP.Length <> 0 Then
                    If wl_aePEROP(0).sCodDoc <> "" Then
                        wp_ePEROP = wl_aePEROP(0)
                        wg_ePEROP = wl_aePEROP(0)
                    End If
                End If
            End If

            If wg_sTblCon1 = "PEROP_Grl" Then
                If wl_aePEROP_Grl.Length <> 0 Then
                    If wl_aePEROP_Grl(0).sCodDoc <> "" Or
                          wl_aePEROP_Grl(0).nNroDoc <> 0 Or
                          wl_aePEROP_Grl(0).sCodSer <> "" Or
                          wl_aePEROP_Grl(0).sCodTer <> "" Then
                        wl_ePEROP_Grl = wl_aePEROP_Grl(0)
                        wp_ePEROP_Grl = wl_aePEROP_Grl(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PEROP_IniFin" Then
                ReDim wg_aePELROP1(0)
                wg_aePELROP1(0) = New moe_Estructuras.ePELROP1

                If wl_aePELROP1.Length <> 0 Then
                    If wl_aePELROP1(0).sCodDoc <> "" Then
                        wl_ePELROP1 = wl_aePELROP1(0)
                        wp_ePELROP1 = wl_aePELROP1(0)
                        wg_aePELROP1 = wl_aePELROP1
                    End If
                End If
            End If
            If wg_sTblCon1 = "PLODP3" Then
                If wl_aePLODP3.Length <> 0 Then
                    If wl_aePLODP3(0).sCodDoc <> "" Then
                        wl_ePLODP3 = wl_aePLODP3(0)
                        wp_ePLODP3 = wl_aePLODP3(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PESDM" Then
                If wl_aePESDM.Length <> 0 Then
                    If wl_aePESDM(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aePESDM(0)
                        wl_eGEMOV = wl_aePESDM(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PESDP" Then
                If wl_aePESDP.Length <> 0 Then
                    If wl_aePESDP(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aePESDP(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PLROP1" Then
                If wl_aePLROP1.Length <> 0 Then
                    If wl_aePLROP1(0).sCodDoc <> "" Then
                        wp_ePLROP1 = wl_aePLROP1(0)
                        wg_ePLROP1 = wl_aePLROP1(0)
                    End If
                End If
            End If

            If wg_sTblCon1 = "PLROP1_Grl" Then
                If wl_aePLROP1_Grl.Length <> 0 Then
                    If wl_aePLROP1_Grl(0).sCodDoc <> "" Or
                          wl_aePLROP1_Grl(0).nNroDoc <> 0 Or
                          wl_aePLROP1_Grl(0).sCodSer <> "" Or
                          wl_aePLROP1_Grl(0).nNroDocBas <> 0 Then
                        wl_ePLROP1_Grl = wl_aePLROP1_Grl(0)
                        wp_ePLROP1_Grl = wl_aePLROP1_Grl(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "PLROP1_IniFin" Then
                ReDim wg_aePELROP1(0)
                wg_aePELROP1(0) = New moe_Estructuras.ePELROP1
                If wl_aePELROP1.Length <> 0 Then
                    If wl_aePELROP1(0).sCodDoc <> "" Then
                        wl_ePELROP1 = wl_aePELROP1(0)
                        wp_ePELROP1 = wl_aePELROP1(0)
                        wg_aePELROP1 = wl_aePELROP1
                    End If
                End If
            End If

            If wg_sTblCon1 = "Q_PQFOM1" Then
                If wl_aeQ_PQFOM1.Length <> 0 Then
                    If wl_aeQ_PQFOM1(0).sCodCmt <> "" Then
                        wl_eQ_PQFOM1 = wl_aeQ_PQFOM1(0)
                        wp_eQ_PQFOM1 = wl_aeQ_PQFOM1(0)
                        wg_aeQ_PQFOM1 = wl_aeQ_PQFOM1
                    End If
                End If
            End If
            If wg_sTblCon1 = "Q_PQLIM1" Then
                If wl_aeQ_PQLIM1.Length <> 0 Then
                    If wl_aeQ_PQLIM1(0).sCodCmt <> "" Then
                        wl_eQ_PQLIM1 = wl_aeQ_PQLIM1(0)
                        wp_eQ_PQLIM1 = wl_aeQ_PQLIM1(0)
                        wg_aeQ_PQLIM1 = wl_aeQ_PQLIM1
                    End If
                End If
            End If

            If wg_sTblCon1 = "TEDMT" Then
                If wl_aeTEDMT.Length <> 0 Then
                    If wl_aeTEDMT(0).sCodTer <> "" Then
                        wp_eTEDMT = wl_aeTEDMT(0)
                        wg_eTEDMT = wl_aeTEDMT(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "TEDMT_1" Then
                If wl_aeTEDMT.Length <> 0 Then
                    If wl_aeTEDMT(0).sCodTer <> "" Then
                        wp_eTEDMT = wl_aeTEDMT(0)
                        wg_eTEDMT = wl_aeTEDMT(0)
                    End If
                End If
            End If
            If wg_sTblCon1 = "TEDMT_2" Then
                If wl_aeTEDMT.Length <> 0 Then
                    If wl_aeTEDMT(0).sCodTer <> "" Then
                        wp_eTEDMT = wl_aeTEDMT(0)
                        wg_eTEDMT = wl_aeTEDMT(0)
                        wg_aeTEDMT = wl_aeTEDMT
                    End If
                End If
            End If
            If wg_sTblCon1 = "VEENI" Then
                If wl_aeVESAI.Length <> 0 Then
                    If wl_aeVEENI(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aeVEENI(0)
                    End If

                End If
            End If
            If wg_sTblCon1 = "VESAI" Then
                If wl_aeVESAI.Length <> 0 Then
                    If wl_aeVESAI(0).sCodDoc <> "" Then
                        wp_eGEMOV = wl_aeVESAI(0)
                    End If

                End If
            End If

            '        oWorkBook.Save()
            '       oWorkBook.Close()
            '      oApp.Quit()
            mof_inhabTsbExcel()
        Catch ex As Exception
            MsgBox("Error : frmConsultar_FormClosed")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmGQLst_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If cmdSeleccionar.Focused = False Then
                Plo_DevCancelar()
                '  cmdCancelar_Click(Nothing,
                '                   Nothing)
            End If

        Catch ex As Exception
            MsgBox("Error : frmGQLst_FormClosing")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmGQLst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            If wp_sTxtFrm <> "" Then
                Me.Text = wp_sTxtFrm
            End If
            Me.BackColor = wg_ClrFrm

            ' oWorkBook = oApp.Workbooks.Open(excelLocation)
            ' oWorkSheet = oWorkBook.Worksheets("hoja1")
            ' oWorkSheet = oWorkBook.Sheets("Hoja1")
            ' oWorkSheet = oWorkBook.ActiveSheet

            '    mof_habTsbExcel()

            Plo_inicializarVar()



            wl_nTotcol = 0
            wg_sCodStr = ""

            Select Case wg_sTblCon1
                Case "ABEOC"
                    wg_sCodStr = "EABEOC"
                Case "ABEOP"
                    wg_sCodStr = "EABEOP"
                Case "ABODP"
                    wg_sCodStr = "EABODP"
                Case "APLND1"
                    wg_sCodStr = "EAPLND1"
                Case "ATALM"
                    wg_sCodStr = "EATALM"
                Case "ATANA"
                    wg_sCodStr = "EATANA"
                Case "ATCCO"
                    wg_sCodStr = "EATCCO"
                Case "ATCIF"
                    wg_sCodStr = "EATCIF"
                Case "ATCTR"
                    wg_sCodStr = "EATCTR"
                Case "ATGRI"
                    wg_sCodStr = "EATGRI"
                Case "ATIVA"
                    wg_sCodStr = "EATIVA"
                Case "ATMON"
                    wg_sCodStr = "EATMON"
                Case "ATOPE"
                    wg_sCodStr = "EATOPE"
                Case "ATPCO"
                    wg_sCodStr = "EATPCO"
                Case "ATPOP"
                    wg_sCodStr = "EATPOP"
                Case "ATTIN"
                    wg_sCodStr = "EATTIN"
                Case "ATVEN"
                    wg_sCodStr = "EATVEN"
                Case "ATZON"
                    wg_sCodStr = "EATZON"
                Case "CEENI"
                    wg_sCodStr = "ECEENI"
                Case "CEFAP"
                    wg_sCodStr = "ECEFAP"
                Case "CEODC"
                    wg_sCodStr = "ECEODC"
                Case "CESAI"
                    wg_sCodStr = "ECESAI"
                Case "FTPUC"
                    wg_sCodStr = "EFTPUC"
                Case "GEMOV"
                    wg_sCodStr = "EGEMOV"
                Case "GEMOV_Grl"
                    wg_sCodStr = "EGEMOV"
                    wg_sCodStr = vp_sCodStr
                Case "GEMOV_IniFin"
                    wg_sCodStr = "EGEMOV_IniFin"
                Case "GELMOV1_Grl"
                    wg_sCodStr = "EGELMOV1"
                    wg_sCodStr = vp_sCodStr
                Case "GELMOV1_IniFin"
                    wg_sCodStr = "EGELMOV1_IniFin"
                    wg_sCodStr = vp_sCodStr
                Case "HEDMT"
                    wg_sCodStr = "EHEDMT"
                Case "IEDMI"
                    wg_sCodStr = "EIEDMI"
                Case "IEDMI_QGrl"
                    wg_sCodStr = "EIEDMI_QGRL"
                    wg_sCodStr = vp_sCodStr
                Case "IEDMI_QIniFin"
                    wg_sCodStr = "EIEDMI"
                Case "IELDMI1_QIniFin"
                    wg_sCodStr = "EIELDMI1"
                Case "IEDMIR"
                    wg_sCodStr = "EIEDMIR"
                Case "IEENI"
                    wg_sCodStr = "EIEENI"
                Case "IELDMI1"
                    wg_sCodStr = "EIELDMI1"
                Case "IESAI"
                    wg_sCodStr = "EIESAI"
                Case "IEREV"
                    wg_sCodStr = "EIEREV"
                Case "IETRI"
                    wg_sCodStr = "EIETRI"
                Case "ILDMI2"
                    wg_sCodStr = "Q1_EILDMI2"
                Case "KARDEX"
                    wg_sCodStr = "EKARDEX"
                Case "KARDEX_QGrl"
                    wg_sCodStr = "EKARDEX_QGRL"
                    wg_sCodStr = vp_sCodStr
                Case "KARDEX_QIniFin"
                    wg_sCodStr = "EKARDEX"
                Case "PEEDM"
                    wg_sCodStr = "EPEEDM"
                Case "PEEDP"
                    wg_sCodStr = "EPEEDP"
                Case "PEFOM"
                    wg_sCodStr = "EPEFOM"
                Case "PELIM"
                    wg_sCodStr = "EPELIM"
                Case "PEODP"
                    wg_sCodStr = "EPEODP"
                Case "PEODP_QGrl"
                    wg_sCodStr = "EPEODP_QGRL"
                    wg_sCodStr = vp_sCodStr
                Case "PEODP_QIniFin"
                    wg_sCodStr = "EPEODP"
                Case "PEODP_PLODP4"
                    wg_sCodStr = "EPEODP_PLODP4"
                    wg_sCodStr = vp_sCodStr
                Case "PEODP_PLODP4_QGrl"
                    wg_sCodStr = "EPEODP_PLDOP4_QGRL"
                    wg_sCodStr = vp_sCodStr
                Case "PEODP_PLODP4_QIniFin"
                    wg_sCodStr = "EPEODP_PLODP4"
                Case "PEROP"
                    wg_sCodStr = "EPEROP"
                Case "PEROP_Grl"
                    wg_sCodStr = "EPEROP"
                    wg_sCodStr = vp_sCodStr
                Case "PEROP_IniFin"
                    wg_sCodStr = "EPEROP_IniFin"
                Case "PLODP1"
                    wg_sCodStr = "EPLODP21"
                Case "PLODP2"
                    wg_sCodStr = "EPLODP2"
                Case "PLODP3"
                    wg_sCodStr = "EPLODP3"
                Case "Q_PQFOM1"
                    wg_sCodStr = "EQ_PQFOM1"
                Case "Q_PQLIM1"
                    wg_sCodStr = "EQ_PQLIM1"
                Case "PESDM"
                    wg_sCodStr = "EPESDM"
                Case "PESDP"
                    wg_sCodStr = "EPESDP"
                Case "TEDMT"
                    wg_sCodStr = "ETEDMT"
                Case "TEDMT_1"
                    wg_sCodStr = "ETEDMT"
                Case "TEDMT_2"
                    wg_sCodStr = "ETEDMT"
                Case "VEENI"
                    wg_sCodStr = "EVEENI"
                Case "VESAI"
                    wg_sCodStr = "EVESAI"
            End Select
            dgv_APQDG(wg_sCodStr)
            Plo_IniciarVarDGV()
            Select Case wg_sTblCon1
                Case "ABEOC"
                    dgv_ConABEOC()
                Case "ABEOP"
                    dgv_ConABEOP()
                Case "ABODP"
                    dgv_ConABODP()
                Case "APLND1"
                    dgv_ConAPLND1()
                Case "ATALM"
                    dgv_ConATALM()
                Case "ATANA"
                    dgv_ConATANA()
                Case "ATCCO"
                    dgv_ConATCCO()
                Case "ATCIF"
                    dgv_ConATCIF()
                Case "ATCTR"
                    dgv_ConATCTR()
                Case "ATGRI"
                    dgv_ConATGRI()
                Case "ATIVA"
                    dgv_ConATIVA()
                Case "ATMON"
                    dgv_ConATMON()
                Case "ATOPE"
                    dgv_ConATOPE()
                Case "ATPCO"
                    dgv_ConATPCO()
                Case "ATPOP"
                    dgv_ConATPOP()
                Case "ATTIN"
                    dgv_ConATTIN()
                Case "ATVEN"
                    dgv_ConATVEN()
                Case "ATZON"
                    dgv_ConATZON()
                Case "CEENI"
                    dgv_ConGEINV()
                Case "CEFAP"
                    dgv_ConCEFAP()
                Case "CEODC"
                    dgv_ConCEODC()
                Case "CESAI"
                    dgv_ConGEINV()
                Case "FTPUC"
                    dgv_ConFTPUC()
                Case "GEMOV"
                    dgv_ConGEMOV()
                Case "GEMOV_Grl"
                    dgv_ConGEMOV_Grl()
                Case "GEMOV_IniFin"
                    dgv_ConGEMOV_IniFin()
                Case "GELMOV1_Grl"
                    dgv_ConGELMOV1_QGrl()
                Case "GELMOV1_IniFin"
                    dgv_ConGELMOV1_QIniFin()
                Case "HEDMT"
                    dgv_ConHEDMT()
                Case "IEDMI"
                    dgv_ConIEDMI()
                Case "IEDMI_QGrl"
                    dgv_ConIEDMI_QGrl()
                Case "IEDMI_QIniFin"
                    dgv_ConIEDMI_QIniFin()
                Case "IELDMI1_QIniFin"
                    dgv_ConIELDMI1_QIniFin()
                Case "IEENI"
                    dgv_ConGEINV()
                Case "IEDMIR"
                    dgv_ConIEDMI()
                Case "IELDMI1"
                    dgv_ConGELDMI1()
                Case "IESAI"
                    dgv_ConGEINV()
                Case "IEREV"
                    dgv_ConIEREV()
                Case "IETRI"
                    dgv_ConGEINV()
                Case "ILDMI2"
                    dgv_ConILDMI2()
                Case "KARDEX"
                    dgv_ConKARDEX()
                Case "KARDEX_QGrl"
                    dgv_ConKARDEX_QGrl()
                Case "KARDEX_QIniFin"
                    dgv_ConKARDEX_QIniFin()
                Case "PEFOM"
                    dgv_ConPEFOM()
                Case "PELIM"
                    dgv_ConPELIM()
                Case "PEEDM"
                    dgv_ConGEINV()
                Case "PEEDP"
                    dgv_ConGEINV()
                Case "PEODP"
                    dgv_ConPEODP()
                Case "PEODP_QGrl"
                    dgv_ConPEODP_QGrl()
                Case "PEODP_QIniFin"
                    dgv_ConPEODP_QIniFin()
                Case "PEODP_PLODP4"
                    dgv_ConPEODP_PLODP4()
                Case "PEODP_PLODP4_QGrl"
                    dgv_ConPEODP_PLODP4_QGrl()
                Case "PEODP_PLODP4_QIniFin"
                    dgv_ConPEODP_PLODP4_QIniFin()
                Case "PEODP_QGrl"
                    dgv_ConPEODP_PLODP4_QGrl()
                Case "PEODP_QIniFin"
                    dgv_ConPEODP_PLODP4_QIniFin()
                Case "PLODP1"
                    dgv_ConPLODP1()
                Case "PLODP2"
                    dgv_ConPLODP2()
                Case "PLODP3"
                    dgv_ConPLODP3()

                Case "Q_PQFOM1"
                    dgv_ConQ_PQFOM1()
                Case "Q_PQLIM1"
                    dgv_ConQ_PQLIM1()
                Case "PEROP"
                    dgv_ConPEROP()
                Case "PEROP_Grl"
                    dgv_ConPEROP_Grl()
                Case "PEROP_IniFin"
                    dgv_ConPEROP_IniFin()
                Case "PESDM"
                    dgv_ConGEINV()
                Case "PESDP"
                    dgv_ConGEINV()
                Case "TEDMT"
                    dgv_ConTEDMT()
                Case "TEDMT_1"
                    dgv_ConTEDMT_1()
                Case "TEDMT_2"
                    dgv_ConTEDMT_2()
                Case "VEENI"
                    dgv_ConGEINV()
                Case "VESAI"
                    dgv_ConGEINV()
            End Select
        Catch ex As Exception
            MsgBox("Error : frmConsulta_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            Plo_DevCancelar()
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        Try
            wl_YIni = 0
            wl_YFin = 0
            If dgv1.Rows.Count > 0 Then
                dgv1.CurrentRow.Selected = True
                'Row
                wl_YIni = dgv1.CurrentCellAddress.Y
                wl_YFin = dgv1.CurrentCellAddress.Y
            End If
            Plo_DevSel()
        Catch ex As Exception
            MsgBox("Error : cmdSeleccionar_Click")
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub
#End Region

#Region "070 DGV "
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Sub dgv_ConABEOC()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeABEOC(0)
            If Not wr_bEOFCon1 Then
                moo_aeABEOC_DT(wl_aeABEOC,
                               wg_DTCon1)
                moo_DGV_aeABEOC(Me.dgv1,
                                wl_aeABEOC)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConABEOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConABEOP()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeABEOP(0)
            If Not wr_bEOFCon1 Then
                moo_aeABEOP_DT(wl_aeABEOP,
                               wg_DTCon1)
                moo_DGV_aeABEOP(Me.dgv1,
                                wl_aeABEOP)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConABEOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConABODP()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeABODP(0)
            If Not wr_bEOFCon1 Then
                moo_aeABODP_DT(wl_aeABODP,
                               wg_DTCon1)
                moo_DGV_aeABODP(Me.dgv1,
                                wl_aeABODP)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConABODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConAPLND1()
        Dim clnAPLND1 As New ClaseNegocios.clnAPLND1
        wl_eAPLND1 = New moe_Estructuras.eAPLND1
        Try
            wl_eAPLND1.sCodDoc = vp_sCodDoc
            wl_eAPLND1.sCodSer = vp_sCodSer

            wr_bEOFCon1 = False
            wg_DTCon1 = clnAPLND1.cndtConAPLND1(wl_eAPLND1,
                                                wr_bEOFCon1)
            ReDim wl_aeAPLND1(0)
            If Not wr_bEOFCon1 Then
                moo_aeAPLND1_DT(wl_aeAPLND1,
                                wg_DTCon1)
                moo_DGV_aeAPLND1(Me.dgv1,
                                 wl_aeAPLND1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConAPLND1")
        End Try

    End Sub
    Private Sub dgv_ConATALM()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeATALM(0)
            If Not wr_bEOFCon1 Then
                moo_aeATALM_DT(wl_aeATALM,
                               wg_DTCon1)
                moo_DGV_aeATALM(Me.dgv1,
                                wl_aeATALM)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATALM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATANA()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeATANA(0)
            If Not wr_bEOFCon1 Then
                moo_aeATANA_DT(wl_aeATANA,
                               wg_DTCon1)
                moo_DGV_aeATANA(Me.dgv1,
                                wl_aeATANA)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATANA")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_ConATCCO()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATCCO(wr_bEOFCon1)
            ReDim wl_aeATCCO(0)
            If Not wr_bEOFCon1 Then
                moo_aeATCCO_DT(wl_aeATCCO,
                               wg_DTCon1)
                moo_DGV_aeATCCO(Me.dgv1,
                                wl_aeATCCO)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATCCO")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATCIF()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATCIF(wr_bEOFCon1)
            ReDim wg_aeATCIF(0)
            If Not wr_bEOFCon1 Then
                moo_aeATCIF_DT(wg_aeATCIF,
                               wg_DTCon1)
                moo_DGV_aeATCIF(Me.dgv1,
                                wg_aeATCIF)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATCIF")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATCTR()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATCTR(wr_bEOFCon1)

            ReDim wl_aeATCTR(0)
            If Not wr_bEOFCon1 Then
                moo_aeATCTR_DT(wl_aeATCTR,
                               wg_DTCon1)
                moo_DGV_aeATCTR(Me.dgv1,
                                wl_aeATCTR)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATCTR")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATGRI()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATGRI(wr_bEOFCon1)

            ReDim wl_aeATGRI(0)
            If Not wr_bEOFCon1 Then
                moo_aeATGRI_DT(wl_aeATGRI,
                               wg_DTCon1)
                moo_DGV_aeATGRI(Me.dgv1,
                                wl_aeATGRI)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATGRI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATIVA()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtConATIVA(wg_sDatCon11,
                                               wr_bEOFCon1)

            ReDim wg_aeATIVA(0)
            If Not wr_bEOFCon1 Then
                moo_aeATIVA_DT(wg_aeATIVA,
                               wg_DTCon1)
                moo_DGV_aeATIVA(Me.dgv1,
                                wg_aeATIVA)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATIVA")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATMON()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeATMON(0)
            If Not wr_bEOFCon1 Then
                moo_aeATMON_DT(wl_aeATMON,
                               wg_DTCon1)
                moo_DGV_aeATMON(Me.dgv1,
                                wl_aeATMON)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATMON")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_ConATOPE()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATOPE(wr_bEOFCon1)
            ReDim wg_aeATOPE(0)
            If Not wr_bEOFCon1 Then
                moo_aeATOPE_DT(wg_aeATOPE,
                               wg_DTCon1)
                moo_DGV_aeATOPE(Me.dgv1,
                                wg_aeATOPE)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATOPE")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATPCO()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATPCO(
                                             wr_bEOFCon1)
            ReDim wl_aeATPCO(0)
            If Not wr_bEOFCon1 Then
                moo_aeATPCO_DT(wl_aeATPCO,
                               wg_DTCon1)
                moo_DGV_aeATPCO(Me.dgv1,
                                wl_aeATPCO)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATPCO")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATPOP()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATPOP(wr_bEOFCon1)
            ReDim wl_aeATPOP(0)
            If Not wr_bEOFCon1 Then
                moo_aeATPOP_DT(wl_aeATPOP,
                               wg_DTCon1)
                moo_DGV_aeATPOP(Me.dgv1,
                                wl_aeATPOP)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATPOP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATTIN()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeATTIN(0)
            If Not wr_bEOFCon1 Then
                moo_aeATTIN_DT(wl_aeATTIN,
                               wg_DTCon1)
                moo_DGV_aeATTIN(Me.dgv1,
                                wl_aeATTIN)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATTIN")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_ConATVEN()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wg_aeATVEN(0)
            If Not wr_bEOFCon1 Then
                moo_aeATVEN_DT(wg_aeATVEN,
                               wg_DTCon1)
                moo_DGV_aeATVEN(Me.dgv1,
                                wg_aeATVEN)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConITVEN")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConATZON()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnTblAb.cndtCrgATZON(wr_bEOFCon1)
            ReDim wl_aeATZON(0)
            If Not wr_bEOFCon1 Then
                moo_aeATZON_DT(wl_aeATZON,
                               wg_DTCon1)
                moo_DGV_aeATZON(Me.dgv1,
                                wl_aeATZON)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATZON")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConCEFAP()
        Dim clnCEFAP As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnCEFAP.cndtConGEMOV(wg_sTblCon1,
                                              wl_eGEMOV,
                                              wr_bEOFCon1)
            ReDim wg_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wg_aeGEMOV,
                               wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                               wg_aeGEMOV)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConCEFAP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConCEODC()
        Dim clnCEODC As New ClaseNegocios.clnCEODC
        Dim wl_nF As Integer
        Dim wl_nC As Integer
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnCEODC.cndtConGEMOV(wg_sTblCon1,
                                              wl_eGEMOV,
                                              wr_bEOFCon1)
            ReDim wg_aeCEODC(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wl_aeCEODC,
                               wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                                wl_aeCEODC)
                With wg_aeAPQDG
                    wl_nC = .Count
                    For wl_nF = 0 To wl_nC - 1
                        If wg_aeAPQDG(wl_nF).nColOri <> wg_aeAPQDG(wl_nF).nNroCol Then
                            dgv1.Columns(wl_nF).DisplayIndex = wg_aeAPQDG(wl_nF).nNroCol
                        End If
                    Next
                End With
                '    dgv1.Columns(27).DisplayIndex = 2
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConCEODC")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_ConFTPUC()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wg_aeFTPUC(0)
            If Not wr_bEOFCon1 Then
                moo_aeFTPUC_DT(wg_aeFTPUC,
                               wg_DTCon1)
                moo_DGV_aeFTPUC(Me.dgv1,
                                wg_aeFTPUC)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConFTPUC")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConGELDMI1()
        Try
            'Fec_Ult_Act : 2015.03.11
            Dim wl_nCntReg As Integer

            wr_bEOFCon1 = False

            wg_DTCon1 = clnIEDMI.cndtConGELDMI1(Nothing,
                                                Nothing,
                                                wr_bEOFCon1)
            wl_nCntReg = wg_DTCon1.Rows.Count
            ReDim wg_aeIELDMI1(0)
            If Not wr_bEOFCon1 Then
                moo_aeIELDMI1_DT(wg_aeIELDMI1,
                                 wg_DTCon1)
                moo_DGV_aeIELDMI1(Me.dgv1,
                                 wg_aeIELDMI1)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConGELDMI1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConGEMOV()
        Dim clnGEMOV As New ClaseNegocios.clnIEINV
        Dim wl_sTabAnt1 As String
        Try
            wr_bEOFCon1 = False

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "IEMOV"
            wg_DTCon1 = clnGEMOV.cndtConGEMOV(wg_sTblCon1,
                                              wl_eGEMOV,
                                              wr_bEOFCon1)
            ReDim wg_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wg_aeGEMOV,
                               wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                               wg_aeGEMOV)
            End If
            wg_sTblCon1 = wl_sTabAnt1
        Catch ex As Exception
            MsgBox("Error : dgv_ConGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConGEMOV_Grl()
        Dim clnGEMOV As New ClaseNegocios.clnIEINV
        Dim wl_sTabAnt1 As String
        Try
            wr_bEOFCon1 = False

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "IEMOV"
            wg_sTblCon1 = wp_sTlbMov
            wg_DTCon1 = clnGEMOV.cndtConGEMOV_Grl(wg_sTblCon1,
                                                  wp_eGEMOV,
                                                  wp_sMayMenIgu,
                                                  wr_bEOFCon1)
            ReDim wg_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EGEMOV_QTIPMOV" Then
                    moo_aeGEMOV_QTipMov_DT(wl_aeGEMOV_Grl,
                                           wg_DTCon1)
                    moo_DGV_aeGEMOV_QTipMov(Me.dgv1,
                                            wl_aeGEMOV_Grl)

                End If
                If wg_sCodStr = "EGEMOV_QCODDOC" Then
                    moo_aeGEMOV_QCodDoc_DT(wl_aeGEMOV_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGEMOV_QCodDoc(Me.dgv1,
                                         wl_aeGEMOV_Grl)
                End If
                If wg_sCodStr = "EGEMOV_QNRODOC" Then
                    moo_aeGEMOV_QNroDoc_DT(wl_aeGEMOV_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGEMOV_QNroDoc(Me.dgv1,
                                         wl_aeGEMOV_Grl)
                End If
                If wg_sCodStr = "EGEMOV_QCODSER" Then
                    moo_aeGEMOV_QCodSer_DT(wl_aeGEMOV_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGEMOV_QCodSer(Me.dgv1,
                                         wl_aeGEMOV_Grl)
                End If
                If wg_sCodStr = "EGEMOV_QCODTER" Then
                    moo_aeGEMOV_QCodTer_DT(wl_aeGEMOV_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGEMOV_QCodTer(Me.dgv1,
                                         wl_aeGEMOV_Grl)
                End If
                If wg_sCodStr = "EGEMOV_QESTDOC" Then
                    moo_aeGEMOV_QEstDoc_DT(wl_aeGEMOV_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGEMOV_QEstDoc(Me.dgv1,
                                         wl_aeGEMOV_Grl)
                End If

                If wg_sCodStr = "EGEMOV_QCODTRA" Then
                    moo_aeGEMOV_QCodTra_DT(wl_aeGEMOV_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGEMOV_QCodTra(Me.dgv1,
                                         wl_aeGEMOV_Grl)
                End If

            End If
            wg_sTblCon1 = wl_sTabAnt1


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConGEMOV_Grl")
        End Try

    End Sub
    Private Sub dgv_ConGEMOV_IniFin()
        Dim clnGEMOV As New ClaseNegocios.clnIEINV

        Try
            Dim wl_sTabAnt1 As String

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "IEMOV"
            wg_sTblCon1 = wp_sTlbMov

            wr_bEOFCon1 = False
            wg_DTCon1 = clnGEMOV.cndtConGEMOV_QIniFin(wg_sTblCon1,
                                                      wp_eGEMOV_Ini,
                                                      wp_eGEMOV_Fin,
                                                      wr_bEOFCon1)
            ReDim wl_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wl_aeGEMOV,
                                 wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                                wl_aeGEMOV)
            End If
            wg_sTblCon1 = wl_sTabAnt1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConGEMOV_IniFin")
        End Try

    End Sub
    Private Sub dgv_ConGELMOV1_QGrl()
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEINV.cndtConGELMOV1_QGrl(wp_sNomTbl,
                                                     wp_eGELMOV1,
                                                     wp_sMayMenIgu,
                                                     wr_bEOFCon1)


            ReDim wl_aeGELMOV1_Grl(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EGELMOV1_QTIPMOV" Then
                    moo_aeGELMOV1_QTipMov_DT(wl_aeGELMOV1_Grl,
                                           wg_DTCon1)
                    moo_DGV_aeGELMOV1_QTipMov(Me.dgv1,
                                            wl_aeGELMOV1_Grl)

                End If
                If wg_sCodStr = "EGELMOV1_QCODDOC" Then
                    moo_aeGELMOV1_QCodDoc_DT(wl_aeGELMOV1_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGELMOV1_QCodDoc(Me.dgv1,
                                         wl_aeGELMOV1_Grl)
                End If
                If wg_sCodStr = "EGELMOV1_QNRODOC" Then
                    moo_aeGELMOV1_QNroDoc_DT(wl_aeGELMOV1_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGELMOV1_QNroDoc(Me.dgv1,
                                         wl_aeGELMOV1_Grl)
                End If
                If wg_sCodStr = "EGELMOV1_QCODSER" Then
                    moo_aeGELMOV1_QCodSer_DT(wl_aeGELMOV1_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGELMOV1_QCodSer(Me.dgv1,
                                         wl_aeGELMOV1_Grl)
                End If
                If wg_sCodStr = "EGELMOV1_QCODTER" Then
                    moo_aeGELMOV1_QCodTer_DT(wl_aeGELMOV1_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGELMOV1_QCodTer(Me.dgv1,
                                         wl_aeGELMOV1_Grl)
                End If
                If wg_sCodStr = "EGELMOV1_QCODTRA" Then
                    moo_aeGELMOV1_QCodTra_DT(wl_aeGELMOV1_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGELMOV1_QCodTra(Me.dgv1,
                                         wl_aeGELMOV1_Grl)
                End If
                If wg_sCodStr = "EGELMOV1_QCODITM" Then
                    moo_aeGELMOV1_QCodItm_DT(wl_aeGELMOV1_Grl,
                                         wg_DTCon1)
                    moo_DGV_aeGELMOV1_QCodItm(Me.dgv1,
                                         wl_aeGELMOV1_Grl)
                End If
                'moo_DGV_aeIEDMI_QItm_DT(Me.dgv1,
                '                        wg_DTCon1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConKARDEX_QGrl")
        End Try

    End Sub
    Private Sub dgv_ConGELMOV1_QIniFin()
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            ReDim wl_aeGELMOV1(0)
            ReDim wl_aeGELMOV1_Ini(0)
            ReDim wl_aeGELMOV1_Fin(0)

            wl_aeGELMOV1_Ini(0) = New moe_Estructuras.eGELMOV1
            wl_aeGELMOV1_Fin(0) = New moe_Estructuras.eGELMOV1
            wp_sNomTbl = "IEMOV"
            wg_DTCon1 = clnIEINV.cndtConGELMOV1_QIniFin(wp_sNomTbl,
                                                        wp_eGELMOV1_Ini,
                                                        wp_eGELMOV1_Fin,
                                                        wr_bEOFCon1)
            If Not wr_bEOFCon1 Then
                moo_aeGELMOV1_DT(wl_aeGELMOV1,
                                 wg_DTCon1)

                moo_DGV_aeGELMOV1(Me.dgv1,
                                  wl_aeGELMOV1)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConGELMOV1_QIniFin")
        End Try

    End Sub
    Private Sub dgv_ConHEDMT()
        Try
            Dim clnHEDMT As New ClaseNegocios.clnHEDMT
            Dim vl_sTblCon1 As String
            Dim vl_sNomCmp1 As String
            Dim vl_sDatCmp1 As String
            vl_sTblCon1 = "HEDMT"
            vl_sNomCmp1 = "sTipTer"
            vl_sDatCmp1 = ""


            wr_bEOFCon1 = False
            wg_DTCon1 = clnHEDMT.cndtConHEDMT(vl_sTblCon1,
                                              vl_sNomCmp1,
                                              vl_sDatCmp1,
                                              wr_bEOFCon1)
            ReDim wl_aeHEDMT(0)
            If Not wr_bEOFCon1 Then
                moo_aeHEDMT_DT(wl_aeHEDMT,
                            wg_DTCon1)
                moo_DGV_aeHEDMT(Me.dgv1,
                                wl_aeHEDMT)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConHEDMT_1")
        End Try
    End Sub
    Private Sub dgv_ConIEDMI()
        Try
            Dim clnIEDMI As New ClaseNegocios.clnIEDMI
            'Fec_Ult_Act : 2014.07.18
            Dim wl_nCntReg As Integer
            Dim wl_sNomTbl As String
            Dim wl_sNomCmp As String
            Dim wl_sDatCmp As String
            Dim vl_sCodAlm As String

            wl_sNomTbl = ""
            wl_sNomCmp = ""
            wl_sDatCmp = ""
            vl_sCodAlm = vp_sCodAlm
            If wp_sFrmOri = "frmCEODC" Then
                wl_sNomCmp = "bItmCom"
                wl_sDatCmp = "V"
            End If
            If wp_sFrmOri = "frmVEFAC" Then
                wl_sNomCmp = "bItmVta"
                wl_sDatCmp = "V"
            End If

            wr_bEOFCon1 = False
            wl_sNomTbl = "IEDMI"
            If wg_sCodStr = "EIEDMI" Then
                wg_DTCon1 = clnIEDMI.cndtConIEDMI(wl_sNomTbl,
                                                  wl_sNomCmp,
                                                  wl_sDatCmp,
                                                  wp_eIEDMI,
                                                  wr_bEOFCon1)
            End If
            If wg_sCodStr = "EIEDMIR" Then
                wg_DTCon1 = clnIEDMI.cndtConIEDMIR(wl_sNomTbl,
                                                   wl_sNomCmp,
                                                   wl_sDatCmp,
                                                   vl_sCodAlm,
                                                   wr_bEOFCon1)
            End If

            wl_nCntReg = wg_DTCon1.Rows.Count
            ReDim wl_aeIEDMI(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EIEDMI" Then
                    moo_DGV_DT_aeIEDMI(Me.dgv1,
                                       wg_DTCon1)
                End If
                If wg_sCodStr = "EIEDMIR" Then
                    moo_DGV_DT_aeIEDMIR(Me.dgv1,
                                        wg_DTCon1)
                End If


            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConIEDMI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConIEDMI_QGrl()
        Dim clnIEDMI As New ClaseNegocios.clnIEDMI
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEDMI.cndtConIEDMI_QGrl(wp_eIEDMI,
                                                   wr_bEOFCon1)


            ReDim wl_aeIEDMI_QGrl(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EIEDMI_QITM" Then
                    '    moo_aeIEDMI_QItm_DT(wl_aeIEDMI_QGrl,
                    '                         wg_DTCon1)
                    '    moo_DGV_aeIEDMI_QItm(Me.dgv1,
                    '                          wl_aeIEDMI_QGrl)
                    '
                    moo_DGV_aeIEDMI_QItm_DT(Me.dgv1,
                                            wg_DTCon1)

                End If
                If wg_sCodStr = "EIEDMI_QGRP" Then
                    moo_aeIEDMI_QGrp_DT(wl_aeIEDMI_QGrl,
                                         wg_DTCon1)
                    moo_DGV_aeIEDMI_QGrp(Me.dgv1,
                                         wl_aeIEDMI_QGrl)
                End If
                If wg_sCodStr = "EIEDMI_QALM" Then
                    moo_aeIEDMI_QAlm_DT(wl_aeIEDMI_QGrl,
                                         wg_DTCon1)
                    moo_DGV_aeIEDMI_QAlm(Me.dgv1,
                                         wl_aeIEDMI_QGrl)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConIEDMI_QGrl")
        End Try

    End Sub
    Private Sub dgv_ConIEDMI_QIniFin()
        Dim clnIEDMI As New ClaseNegocios.clnIEDMI
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEDMI.cndtConIEDMI_QIniFin(wp_eIEDMI_Ini,
                                                      wp_eIEDMI_Fin,
                                                      wp_bImpItmInac,
                                                      wp_bImpItmCero,
                                                      wp_sNomTblTmp,
                                                      wr_bEOFCon1)
            ReDim wl_aeIEDMI(0)
            If Not wr_bEOFCon1 Then
                moo_aeIEDMI_DT(wl_aeIEDMI,
                                 wg_DTCon1)
                moo_DGV_aeIEDMI(Me.dgv1,
                                wl_aeIEDMI)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConIEDMI_QIniFin")
        End Try

    End Sub
    Private Sub dgv_ConIELDMI1_QIniFin()
        Dim clnIEDMI As New ClaseNegocios.clnIEDMI
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEDMI.cndtConIELDMI1_QIniFin(wp_eIEDMI_Ini,
                                                        wp_eIEDMI_Fin,
                                                        wp_bImpItmInac,
                                                        wp_bImpItmCero,
                                                        wp_bVdaCanMin,
                                                        wr_bEOFCon1)
            ReDim wl_aeIELDMI1(0)
            If Not wr_bEOFCon1 Then
                moo_aeIELDMI1_DT(wl_aeIELDMI1,
                                 wg_DTCon1)
                moo_DGV_aeIELDMI1(Me.dgv1,
                                  wl_aeIELDMI1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConIELDMI1_QIniFin")
        End Try

    End Sub
    Private Sub dgv_ConIEREV()
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Dim wl_sTabAnt1 As String
        Try
            wr_bEOFCon1 = False

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "IEMOV"
            wg_DTCon1 = clnIEINV.cndtConIEREV(wl_eIEREV,
                                              wr_bEOFCon1)
            ReDim wg_aeIEREV(0)
            If Not wr_bEOFCon1 Then
                moo_aeIEREV_DT(wg_aeIEREV,
                               wg_DTCon1)
                moo_DGV_aeIEREV(Me.dgv1,
                                wg_aeIEREV)
            End If
            wg_sTblCon1 = wl_sTabAnt1
        Catch ex As Exception
            MsgBox("Error : dgv_ConIEREV")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_ConILDMI2()
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEDMI.cndtConILDMI2(wg_sTblCon1,
                                               vp_sCodTer,
                                               wr_bEOFCon1)
            ReDim wl_Q1_aeILDMI2(0)
            If Not wr_bEOFCon1 Then
                moo_Q1_aeILDMI2_DT(wl_Q1_aeILDMI2,
                                   wg_DTCon1)
                moo_DGV_Q1_aeILDMI2(Me.dgv1,
                                 wl_Q1_aeILDMI2)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConKARDEX()
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEINV.cndtConSdoAntKARDEX(wp_eKARDEX,
                                                     wr_bEOFCon1)
            ReDim wl_aeKARDEX(0)

            If Not wr_bEOFCon1 Then
                moo_aeKARDEX_DT(wl_aeKARDEX,
                                 wg_DTCon1,
                                 wp_dFecDocIni,
                                 wp_dFecDocFin,
                                 Nothing)
                moo_DGV_aeKARDEX(Me.dgv1,
                                 wl_aeKARDEX)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConKARDEX")
        End Try

    End Sub
    Private Sub dgv_ConKARDEX_QGrl()
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEINV.cndtConKARDEX_QGrl(wp_eKARDEX,
                                                    wr_bEOFCon1)


            ReDim wl_aeKARDEX_QGrl(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EKARDEX_QITM" Then
                    moo_aeKARDEX_QItm_DT(wl_aeKARDEX_QGrl,
                                         wg_DTCon1)
                    moo_DGV_aeKARDEX_QItm(Me.dgv1,
                                          wl_aeKARDEX_QGrl)
                    'moo_DGV_aeIEDMI_QItm_DT(Me.dgv1,
                    '                        wg_DTCon1)
                End If
                If wg_sCodStr = "EKARDEX_QALM" Then
                    moo_aeKARDEX_QAlm_DT(wl_aeKARDEX_QGrl,
                                         wg_DTCon1)
                    moo_DGV_aeKARDEX_QAlm(Me.dgv1,
                                         wl_aeKARDEX_QGrl)
                End If
                If wg_sCodStr = "EKARDEX_QFDOC" Then
                
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConKARDEX_QGrl")
        End Try

    End Sub
    Private Sub dgv_ConKARDEX_QIniFin()
        Dim clnIEINV As New ClaseNegocios.clnIEINV
        Dim wl_eKARDEXSdoAnt As New moe_Estructuras.eKARDEX
        Try
            wr_bEOFCon1 = False
            ReDim wl_aeKARDEX(0)
            wg_DTCon1 = clnIEINV.cndtConSdoAntKARDEX(wp_eKARDEX_Ini,
                                                     wr_bEOFCon1)
            If Not wr_bEOFCon1 Then
                moo_aeKARDEXSdoAnt_DT(wl_aeKARDEX,
                                      wg_DTCon1,
                                      wp_dFecDocIni,
                                      wp_dFecDocFin)


                moo_DGV_aeKARDEX(Me.dgv1,
                                 wl_aeKARDEX)
                wl_eKARDEXSdoAnt = wl_aeKARDEX(0)
            End If

            wr_bEOFCon1 = False
            ReDim wl_aeKARDEX(0)
            wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
            wg_DTCon1 = clnIEINV.cndtConKARDEX_QIniFin(wp_eKARDEX_Ini,
                                                       wr_bEOFCon1)
            If Not wr_bEOFCon1 Then
                moo_aeKARDEX_DT(wl_aeKARDEX,
                                 wg_DTCon1,
                                 wp_dFecDocIni,
                                 wp_dFecDocFin,
                                 wl_eKARDEXSdoAnt)

                moo_DGV_aeKARDEX(Me.dgv1,
                                wl_aeKARDEX)
            Else
                ReDim wl_aeKARDEX(0)
                wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
                moo_aeKARDEX_eKARDEXSdoAnt(wl_aeKARDEX,
                                           wl_eKARDEXSdoAnt)

                moo_DGV_aeKARDEX(Me.dgv1,
                                wl_aeKARDEX)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConKARDEX_QIniFin")
        End Try

    End Sub
    Private Sub dgv_ConPEFOM()
        Dim clnPEFOM As New ClaseNegocios.clnPEFOM
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEFOM.cndtConsultarPEFOM(Nothing,
                                                    wr_bEOFCon1)
            ReDim wl_aePEFOM(0)
            If Not wr_bEOFCon1 Then
                moo_DGV_DTePEFOM(Me.dgv1,
                                 wg_DTCon1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEFOM")

        End Try

    End Sub
    Private Sub dgv_ConPELIM()
        Dim clnPELIM As New ClaseNegocios.clnPELIM
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPELIM.cndtConsultarPELIM(Nothing,
                                                    wr_bEOFCon1)
            ReDim wl_aePELIM(0)
            If Not wr_bEOFCon1 Then
                moo_DGV_DTePELIM(Me.dgv1,
                                 wg_DTCon1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPELIM")
        End Try

    End Sub
    Private Sub dgv_ConPEODP()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            wr_bEOFCon1 = False
            If vp_sCodDoc = "" Then
                wg_DTCon1 = clnPEODP.cndtConsultarPEODP(Nothing,
                                                        0,
                                                        vp_sEstOdp,
                                                        Nothing,
                                                        wr_bEOFCon1)
            Else
                wg_DTCon1 = clnPEODP.cndtConsultarPEODP(vp_sCodDoc,
                                                        0,
                                                        vp_sEstOdp,
                                                        Nothing,
                                                        wr_bEOFCon1)
            End If


            ReDim wl_aePEODP(0)
            If Not wr_bEOFCon1 Then
                moo_aePEODP_DT(wl_aePEODP,
                               wg_DTCon1)
                moo_DGV_aePEODP(Me.dgv1,
                                wl_aePEODP)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP")
        End Try

    End Sub
    Private Sub dgv_ConPEODP_QGrl()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConPEODP_QGrl(wp_ePEODP,
                                                    wr_bEOFCon1)


            ReDim wl_aePEODP_QGrl(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EPEODP_QCDOC" Then
                    moo_aePEODP_QCDoc_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QCDoc(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QCSER" Then
                    moo_aePEODP_QCSer_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QCSer(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QEODP" Then
                    moo_aePEODP_QEstODP_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QEstODP(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QFEMI" Then
                    moo_aePEODP_QFEmi_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QFEmi(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QFFIN" Then
                    moo_aePEODP_QFFin_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QFFin(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QFINI" Then
                    moo_aePEODP_QFIni_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QFIni(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QITM" Then
                    moo_aePEODP_QItm_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QItm(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QNDOC" Then
                    moo_aePEODP_QNDoc_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QNDoc(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP_QFEmi")
        End Try

    End Sub
    Private Sub dgv_ConPEODP_QIniFin()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        ReDim wg_aeIELDMI1(0)
        wg_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1
        ReDim wl_aeIELDMI1(0)
        wl_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1

        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConPEODP_QIniFin(wp_ePEODP_Ini,
                                                      wp_ePEODP_Fin,
                                                      wr_bEOFCon1)
            ReDim wl_aePEODP(0)
            If Not wr_bEOFCon1 Then
                moo_aePEODP_DT(wl_aePEODP,
                               wg_DTCon1)
                moo_DGV_aePEODP(Me.dgv1,
                                wl_aePEODP)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP_QIniFin")
        End Try

    End Sub
    Private Sub dgv_ConPEODP_PLODP4()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        wl_ePEODP_PLODP4 = New moe_Estructuras.ePEODP_PLODP4
        wl_ePEODP_PLODP4.sCodDoc = vp_sCodDoc
        wl_ePEODP_PLODP4.sEstOdp = vp_sEstOdp
        Try
            wr_bEOFCon1 = False
            If vp_sCodDoc = "" Then
                wg_DTCon1 = clnPEODP.cndtConPEODP_PLODP4(wl_ePEODP_PLODP4,
                                                        wr_bEOFCon1)
            Else
                wg_DTCon1 = clnPEODP.cndtConPEODP_PLODP4(wl_ePEODP_PLODP4,
                                                        wr_bEOFCon1)
            End If


            ReDim wl_aePEODP_PLODP4(0)
            If Not wr_bEOFCon1 Then
                moo_aePEODP_PLODP4_DT(wl_aePEODP_PLODP4,
                                      wg_DTCon1)
                moo_DGV_aePEODP_PLODP4(Me.dgv1,
                                       wl_aePEODP_PLODP4)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP_PLODP4")
        End Try

    End Sub
    Private Sub dgv_ConPEODP_PLODP4_QGrl()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConPEODP_PLODP4_QGrl(wp_ePEODP,
                                                    wr_bEOFCon1)


            ReDim wl_aePEODP_QGrl(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EPEODP_QCDOC" Then
                    moo_aePEODP_QCDoc_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QCDoc(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QCSER" Then
                    moo_aePEODP_QCSer_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QCSer(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QEODP" Then
                    moo_aePEODP_QEstODP_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QEstODP(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QFEMI" Then
                    moo_aePEODP_QFEmi_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QFEmi(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QFFIN" Then
                    moo_aePEODP_QFFin_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QFFin(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QFINI" Then
                    moo_aePEODP_QFIni_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QFIni(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QITM" Then
                    moo_aePEODP_QItm_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QItm(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If
                If wg_sCodStr = "EPEODP_QNDOC" Then
                    moo_aePEODP_QNDoc_DT(wl_aePEODP_QGrl,
                                      wg_DTCon1)
                    moo_DGV_aePEODP_QNDoc(Me.dgv1,
                                          wl_aePEODP_QGrl)
                End If





            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP_PLODP4_QGrl")
        End Try

    End Sub
    Private Sub dgv_ConPEODP_PLODP4_QIniFin()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        ReDim wg_aeIELDMI1(0)
        wg_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1
        ReDim wl_aeIELDMI1(0)
        wl_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1

        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConPEODP_PLODP4_QIniFin(wp_ePEODP_PLODP4_Ini,
                                                             wp_ePEODP_PLODP4_Fin,
                                                             wr_bEOFCon1)
            ReDim wl_aePEODP_PLODP4(0)
            If Not wr_bEOFCon1 Then
                moo_aePEODP_PLODP4_DT(wl_aePEODP_PLODP4,
                                      wg_DTCon1)
                moo_DGV_aePEODP_PLODP4(Me.dgv1,
                                       wl_aePEODP_PLODP4)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP_PLODP4_QIniFin")
        End Try

    End Sub





    Private Sub dgv_ConPEROP()
        Dim clnPEROP As New ClaseNegocios.clnPEROP
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEROP.cndtConsultar(Nothing,
                                                     0,
                                           wr_bEOFCon1)


            ReDim wl_aePEODP(0)
            If Not wr_bEOFCon1 Then
                moo_aePEROP_DT(wl_aePEROP,
                               wg_DTCon1)
                moo_DGV_aePEROP(Me.dgv1,
                                wl_aePEROP)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEODP")
        End Try

    End Sub
    Private Sub dgv_ConPEROP_Grl()
        Dim clnPEROP As New ClaseNegocios.clnPEROP
        Dim wl_sTabAnt1 As String
        Try
            wr_bEOFCon1 = False

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "PEROP"
            wg_DTCon1 = clnPEROP.cndtConPEROP_Grl(wg_sTblCon1,
                                                  wp_ePEROP,
                                                  wp_sMayMenIgu,
                                                  wr_bEOFCon1)
            ReDim wg_aePEROP(0)
            If Not wr_bEOFCon1 Then
                If wg_sCodStr = "EPEROP_QNRODOC" Then
                    moo_aePEROP_QNroDoc_DT(wl_aePEROP_Grl,
                                         wg_DTCon1)
                    moo_DGV_aePEROP_QNroDoc(Me.dgv1,
                                         wl_aePEROP_Grl)
                End If
                If wg_sCodStr = "EPEROP_QCODSER" Then
                    moo_aePEROP_QCodSer_DT(wl_aePEROP_Grl,
                                         wg_DTCon1)
                    moo_DGV_aePEROP_QCodSer(Me.dgv1,
                                         wl_aePEROP_Grl)
                End If
                If wg_sCodStr = "EPEROP_QCODTER" Then
                    moo_aePEROP_QCodTer_DT(wl_aePEROP_Grl,
                                           wg_DTCon1)
                    moo_DGV_aePEROP_QCodTer(Me.dgv1,
                                         wl_aePEROP_Grl)
                End If
                
            End If
            wg_sTblCon1 = wl_sTabAnt1


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEROP_Grl")
        End Try

    End Sub
    Private Sub dgv_ConPEROP_IniFin()
        Dim clnPEROP As New ClaseNegocios.clnPEROP

        Try
            Dim wl_sTabAnt1 As String

            ReDim wg_aePELROP1(0)
            wg_aePELROP1(0) = New moe_Estructuras.ePELROP1
            ReDim wl_aePELROP1(0)
            wl_aePELROP1(0) = New moe_Estructuras.ePELROP1
          

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "PEROP"

            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEROP.cndtConPEROP_QIniFin(wg_sTblCon1,
                                                      wp_ePEROP_Ini,
                                                      wp_ePEROP_Fin,
                                                      wr_bEOFCon1)
            ReDim wl_aePELROP1(0)
            If Not wr_bEOFCon1 Then

                moo_aePELROP1_DT(wl_aePELROP1,
                                 wg_DTCon1)
                moo_DGV_aePLEROP1(Me.dgv1,
                                  wl_aePELROP1)

            End If
            wg_sTblCon1 = wl_sTabAnt1
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPEROP_IniFin")
        End Try

    End Sub
    Private Sub dgv_ConPLODP1()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConsultarPLODP1(vp_sCodDoc,
                                                     vp_nNroDoc,
                                                     wr_bEOFCon1)
            ReDim wl_aePEODP(0)
            If Not wr_bEOFCon1 Then
                moo_aePLODP1_DT(wl_aePLODP1,
                                wg_DTCon1)
                moo_DGV_aePLODP1(Me.dgv1,
                                 wl_aePLODP1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPLODP1")
        End Try

    End Sub
    Private Sub dgv_ConPLODP2()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConsultarPLODP2(vp_sCodDoc,
                                                     vp_nNroDoc,
                                                     Nothing,
                                                     wr_bEOFCon1)
            ReDim wl_aePEODP(0)
            If Not wr_bEOFCon1 Then
                moo_aePLODP2_DT(wl_aePLODP2,
                                wg_DTCon1)
                moo_DGV_aePLODP2(Me.dgv1,
                                 wl_aePLODP2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPLODP2")
        End Try

    End Sub
    Private Sub dgv_ConPLODP3()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConsultarPLODP3(vp_sCodDoc,
                                                     vp_nNroDoc,
                                                     wr_bEOFCon1)
            ReDim wl_aePEODP(0)
            If Not wr_bEOFCon1 Then
                moo_aePLODP3_DT(wl_aePLODP3,
                                wg_DTCon1)
                moo_DGV_aePLODP3(Me.dgv1,
                                 wl_aePLODP3)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConPLODP3")
        End Try

    End Sub
    Private Sub dgv_ConQ_PQFOM1()
        Dim clnPQFOM1 As New ClaseNegocios.clnConQry
        Try
            wr_bEOFCon1 = False
            If vp_sCodCmt <> "" Then
                wg_DTCon1 = clnPQFOM1.cndtConPQFOM1(vp_sCodItm,
                                                    vp_sCodCmt,
                                                    wr_bEOFCon1)



                ReDim wl_aeQ_PQFOM1(0)
                If Not wr_bEOFCon1 Then
                    moo_aeQ_PQFOM1_DT(wl_aeQ_PQFOM1,
                                   wg_DTCon1)
                    moo_DGV_aeQ_PQFOM1(Me.dgv1,
                                    wl_aeQ_PQFOM1)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConQ_PQLIM1")
        End Try

    End Sub
    Private Sub dgv_ConQ_PQLIM1()
        Dim clnPQLIM1 As New ClaseNegocios.clnConQry
        Try
            wr_bEOFCon1 = False
            If vp_sCodCmt <> "" Then
                wg_DTCon1 = clnPQLIM1.cndtConPQLIM1(vp_sCodItm,
                                                    vp_sCodCmt,
                                                    wr_bEOFCon1)



                ReDim wl_aeQ_PQLIM1(0)
                If Not wr_bEOFCon1 Then
                    moo_aeQ_PQLIM1_DT(wl_aeQ_PQLIM1,
                                   wg_DTCon1)
                    moo_DGV_aeQ_PQLIM1(Me.dgv1,
                                    wl_aeQ_PQLIM1)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConQ_PQLIM1")
        End Try

    End Sub


    Private Sub dgv_ConGEINV()
        Dim clnGEMOV As New ClaseNegocios.clnIEINV
        wl_eGEMOV = New moe_Estructuras.eGEMOV
        wl_sNomtbl = "IEMOV"
        wl_sNomCmp = "sCodDoc"
        wl_sDatCmp = vp_sCodDoc
        wl_sTipCmp = "S"
        wl_sNomCmp1 = ""
        wl_sDatCmp1 = ""
        wl_sTipCmp1 = ""
        wl_sCmpOrd = "sCodDoc"
        wl_sTipOrd = "A"
        wl_sCmpOrd1 = "nNroDoc"
        wl_sTipOrd1 = "A"
        Dim wl_nF As Integer
        Dim wl_nC As Integer
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnGEMOV.cndtConGEINV(wl_sNomtbl,
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
                                              wr_bEOF)

            ReDim wl_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wl_aeGEMOV,
                               wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                                wl_aeGEMOV)
                With wg_aeAPQDG
                    wl_nC = .Count
                    For wl_nF = 0 To wl_nC - 1
                        If wg_aeAPQDG(wl_nF).nColOri <> wg_aeAPQDG(wl_nF).nNroCol Then
                            dgv1.Columns(wl_nF).DisplayIndex = wg_aeAPQDG(wl_nF).nNroCol
                        End If
                    Next
                End With
            End If


            If wg_sTblCon1 = "CEENI" Then
                ReDim wl_aeCEENI(0)
                wl_aeCEENI = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "CESAI" Then
                ReDim wl_aeCESAI(0)
                wl_aeCESAI = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "IEENI" Then
                ReDim wl_aeIEENI(0)
                wl_aeIEENI = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "IESAI" Then
                ReDim wl_aeIESAI(0)
                wl_aeIESAI = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "IETRI" Then
                ReDim wl_aeIETRI(0)
                wl_aeIETRI = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "PEEDM" Then
                ReDim wl_aePEEDM(0)
                wl_aePEEDM = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "PEEDP" Then
                ReDim wl_aePEEDP(0)
                wl_aePEEDP = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "PESDM" Then
                ReDim wl_aePESDM(0)
                wl_aePESDM = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "PSEDP" Then
                ReDim wl_aePESDP(0)
                wl_aePESDP = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "VEENI" Then
                ReDim wl_aeVEENI(0)
                wl_aeVEENI = wl_aeGEMOV
            End If
            If wg_sTblCon1 = "VESAI" Then
                ReDim wl_aeVESAI(0)
                wl_aeVESAI = wl_aeGEMOV
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConGEINV")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_ConTEDMT()
        Try
            Dim clnTEDMT As New ClaseNegocios.clnTEDMT
            Dim vl_sTblCon1 As String
            Dim vl_sNomCmp1 As String
            Dim vl_sDatCmp1 As String
            vl_sTblCon1 = "TEDMT"
            vl_sNomCmp1 = "sTipTer"
            vl_sDatCmp1 = ""
            If vp_sTipTer = "1" Or vp_sTipTer = "2" Then
                vl_sDatCmp1 = vp_sTipTer
            End If
            vl_sDatCmp1 = vp_sTipTer


            wr_bEOFCon1 = False
            wg_DTCon1 = clnTEDMT.cndtConTEDMT(vl_sTblCon1,
                                              vl_sNomCmp1,
                                              vl_sDatCmp1,
                                              wr_bEOFCon1)
            ReDim wl_aeTEDMT(0)
            If Not wr_bEOFCon1 Then
                moo_aeTEDMT_DT(wl_aeTEDMT,
                            wg_DTCon1)

                moo_DGV_aeTEDMT(Me.dgv1,
                                wl_aeTEDMT)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConTEDMT_1")
        End Try
    End Sub
    Private Sub dgv_ConTEDMT_1()
        Try
            Dim clnTEDMT As New ClaseNegocios.clnTEDMT
            Dim vl_sTblCon1 As String
            Dim vl_sNomCmp1 As String
            Dim vl_sDatCmp1 As String
            vl_sTblCon1 = "TEDMT"
            vl_sNomCmp1 = "sTipTer"
            vl_sDatCmp1 = "1"


            wr_bEOFCon1 = False
            wg_DTCon1 = clnTEDMT.cndtConTEDMT(vl_sTblCon1,
                                              vl_sNomCmp1,
                                              vl_sDatCmp1,
                                              wr_bEOFCon1)
            ReDim wl_aeTEDMT(0)
            If Not wr_bEOFCon1 Then
                moo_aeTEDMT_DT(wl_aeTEDMT,
                            wg_DTCon1)
                moo_DGV_aeTEDMT(Me.dgv1,
                                wl_aeTEDMT)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConTEDMT_1")
        End Try
    End Sub
    Private Sub dgv_ConTEDMT_2()
        Try
            Dim clnTEDMT As New ClaseNegocios.clnTEDMT
            Dim vl_sTblCon1 As String
            Dim vl_sNomCmp1 As String
            Dim vl_sDatCmp1 As String
            vl_sTblCon1 = "TEDMT"
            vl_sNomCmp1 = "sTipTer"
            vl_sDatCmp1 = "2"


            wr_bEOFCon1 = False
            wg_DTCon1 = clnTEDMT.cndtConTEDMT(vl_sTblCon1,
                                              vl_sNomCmp1,
                                              vl_sDatCmp1,
                                              wr_bEOFCon1)
            ReDim wl_aeTEDMT(0)
            If Not wr_bEOFCon1 Then
                moo_aeTEDMT_DT(wl_aeTEDMT,
                            wg_DTCon1)
                moo_DGV_aeTEDMT(Me.dgv1,
                                wl_aeTEDMT)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv_ConTEDMT")
        End Try
    End Sub
    Private Sub dgv_Con1Lla2Tbl()
        wg_DTCon1 = clnConTbl.cndtCon2Lla2Tbl(wg_sTblCon1,
                                              wg_sCmpCon11,
                                              wg_sDatCon11,
                                              wg_sTitCon11,
                                              wg_sCmpCon12,
                                              wg_sDatCon12,
                                              wg_sTitCon12,
                                              wg_sTblCon2,
                                              wg_sSelCon11,
                                              wr_bEOFCon1)
        If Not wr_bEOFCon1 Then
            With dgv1
                .DataSource = wg_DTCon1
                .Columns(0).HeaderText = wg_sTitCon11
                .Columns(1).HeaderText = wg_sTitCon12
            End With
            '   TextBox1.AutoCompleteCustomSource
        End If
    End Sub
    Private Sub dgv_Con2Lla2Tbl()
        wg_DTCon1 = clnConTbl.cndtCon2Lla2Tbl(wg_sTblCon1,
                                              wg_sCmpCon11,
                                              wg_sDatCon11,
                                              wg_sTitCon11,
                                              wg_sCmpCon12,
                                              wg_sDatCon12,
                                              wg_sTitCon12,
                                              wg_sTblCon2,
                                              wg_sSelCon11,
                                              wr_bEOFCon1)
        If Not wr_bEOFCon1 Then
            With dgv1
                .DataSource = wg_DTCon1
                .Columns(0).HeaderText = wg_sTitCon11
                .Columns(1).HeaderText = wg_sTitCon12
            End With
            '   TextBox1.AutoCompleteCustomSource


        End If
    End Sub
    Private Sub dgv_Configurar1()
        With dgv1

            ' Apariencia
            .ColumnHeadersHeight = 18
            .RowTemplate.Height = 18
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ' comportamiento
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' diseño
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


            ' Varios columnas



        End With
    End Sub
    Private Sub dgv1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentDoubleClick
        Try


            'If' dgv1.CurrentRow.Cells(0).Selected Or
            'dgv1.CurrentRow.Cells(1).Selected Or
            If dgv1.CurrentRow.Selected Then
                cmdSeleccionar_Click(Nothing,
                     Nothing)


                Plo_DevSel()
                Me.Close()
            End If

            ' If dgv1.CurrentRow.HeaderCell.Selected Then
            'Plo_DevSel()
            'Me.Close()
            'End If
        Catch ex As Exception
            MsgBox("Error en: dgv1_CellContentDoubleClick")
            MsgBox(ex.Message)

        End Try


    End Sub
    'Comunes
    Private Sub dgv_APQDG(ByVal wg_sCodStr As String)
        Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
        wg_eAPQDG = New moe_Estructuras.eAPQDG
        ' wg_sCodStr = "EIELDMI1"

        Try
            wg_aeAPQDG = mof_fConAPQDG(wg_sCodStr)
            wl_nTotcol = UBound(wg_aeAPQDG) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APQDG")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_ConfiguraCol()
        Try
            Dim wl_bCnfVis As Boolean = False
            Dim vl_sNomCmp As String
            Dim vl_sTitCol As String
            wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
            For wp_nC = 0 To wl_nTotcol - 1
                wp_bVisible = True
                wp_bReadOnly = False
                wp_bColxDef = False
                wp_sTipCol = "S"
                wg_eAPQDG = wg_aeAPQDG(wp_nC)

                With wg_eAPQDG
                    wp_sTipCol = .sTipCol
                    wp_bVisible = .bVisible
                    wp_bReadOnly = .bReadOnly
                    wp_bColxDef = .bColxDef
                    vl_sNomCmp = .sNomCmp
                    vl_nTamCmp = .nTamCmp
                    vl_sTitCol = .sTitCol
                End With

                mof_DGVFormatCol(Me.dgv1,
                             wp_nC,
                             wp_sTipCol,
                             wp_bVisible,
                             wp_bReadOnly,
                             vl_sNomCmp,
                             vl_nTamCmp,
                             vl_sTitCol)
                If wl_bCnfVis = False Then
                    If wp_bVisible Then
                        wl_nColIniGrl = wp_nC
                        wl_nColFinGrl = wp_nC
                        wl_bCnfVis = True
                    End If
                End If
                If wl_bCnfVis = True Then
                    If wp_bVisible Then
                        wl_nColFinGrl = wp_nC
                    End If
                End If
            Next
            wl_nColOrd = wl_nColIniGrl
        Catch ex As Exception
            MsgBox("Error en: dgv_ConfiguraCol")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "072 DGV Controladores de Eventos "
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
        Try
            Dim wl_sTblCon1 As String
            wl_sTblCon1 = wg_sTblCon1
            If dgv1.CurrentRow.Selected Then
                cmdSeleccionar.Focus()
                cmdSeleccionar_Click(Nothing,
                                    Nothing)
                '   Plo_DevSel()
                '   Me.Close()
            End If

            Select Case wg_sTblCon1
                Case "ATALM"


                Case "ATCCO"

                Case "ATIVA"

                Case "ATVEN"

                Case "CEENI"

                Case "CEFAP"

                Case "CEODC"

                Case "CESAI"

                Case "FTPUC"

                Case "IEDMI"
                    '        Dim wl_frm As New frmIEDMI
                    '        If dgv1.CurrentRow.Cells("sCodItm").Value <> "" Then
                    ' wl_frm.vp_sCodItm = dgv1.CurrentRow.Cells("sCodItm").Value
                    ' wl_frm.Show()
                    ' End If
                Case "IELDMI1"

                Case "ILDMI2"

                Case "PEFOM"
                    ' Dim wl_frm As New frmPEFOM
                    ' wl_frm.vp_sCodItm = dgv1.CurrentRow.Cells("sCodItm").Value
                    ' wl_frm.Show()
                Case "PELIM"
                    ' Dim wl_frm As New frmPELIM
                    ' wl_frm.vp_sCodItm = dgv1.CurrentRow.Cells("sCodItm").Value
                    ' wl_frm.Show()
                Case "PEODP"

                Case "ATCIF"

                Case "ATOPE"

                Case "TEDMT"
                    ' Dim wl_frm As New frmTEDMT
                    ' If dgv1.CurrentRow.Cells("sCodTer").Value <> "" Then
                    ' wl_frm.vp_sCodTer = dgv1.CurrentRow.Cells("sCodTer").Value
                    ' wl_frm.Show()
                    ' End If
                Case "TEDMT_1"

                Case "TEDMT_2"

            End Select

            wg_sTblCon1 = wl_sTblCon1



        Catch ex As Exception
            MsgBox("Error en: dgv1_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
        'dgv1.CurrentCell.Selected = True
    End Sub

    ' Private Sub dgv1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.Click
    '     Try
    '         wl_nColOrd = wl_nColIniGrl
    '         cmdCancelar.Focus()
    '     Catch ex As Exception
    '         MsgBox("Error en: dgv1_Click")
    '         MsgBox(ex.Message)
    '     End Try
    '
    '    End Sub
    Private Sub dgv1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.ColumnHeaderMouseClick
        Try
            wl_nColOrd = e.ColumnIndex
        Catch ex As Exception
            MsgBox("Error en: dgv1_ColumnHeaderMouseClick")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.RowHeaderMouseClick
        Me.dgv1.SelectionMode = _
               DataGridViewSelectionMode.RowHeaderSelect
        Me.dgv1.Rows(e.RowIndex).Selected = True
    End Sub
    Private Sub dgv1_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.RowHeaderMouseDoubleClick
        Try
            dgv1.CurrentRow.Selected = True
            cmdSeleccionar_Click(Nothing,
                                 Nothing)

            Plo_DevSel()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : dgv1_RowHeaderMouseDoubleClick")
        End Try
    End Sub
#End Region
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_DevCancelar()
        Try
            Select Case wg_sTblCon1
                Case "ABODP"
                    wp_eABODP = New moe_Estructuras.eABODP
                    wl_eABODP = New moe_Estructuras.eABODP
                    ReDim wl_aeABODP(0)
                    wl_aeABODP(0) = New moe_Estructuras.eABODP
                Case "APLND1"
                    wp_eAPLND1 = New moe_Estructuras.eAPLND1
                    wl_eAPLND1 = New moe_Estructuras.eAPLND1
                    ReDim wl_aeAPLND1(0)
                    wl_aeAPLND1(0) = New moe_Estructuras.eAPLND1
                Case "ATALM"
                    wp_eATALM = New moe_Estructuras.eATALM
                    wl_eATALM = New moe_Estructuras.eATALM
                    ReDim wl_aeATALM(0)
                    wl_aeATALM(0) = New moe_Estructuras.eATALM
                Case "ATANA"
                    wp_eATANA = New moe_Estructuras.eATANA
                    ReDim wl_aeATANA(0)
                    wl_aeATANA(0) = New moe_Estructuras.eATANA
                Case "ATCIF"
                    wl_eATCIF = New moe_Estructuras.eATCIF
                    wp_eATCIF = New moe_Estructuras.eATCIF
                    ReDim wl_aeATCIF(0)
                    wl_aeATCIF(0) = New moe_Estructuras.eATCIF
                Case "ATCCO"
                    wl_eATCCO = New moe_Estructuras.eATCCO
                    wp_eATCCO = New moe_Estructuras.eATCCO
                    ReDim wl_aeATCCO(0)
                    wl_aeATCCO(0) = New moe_Estructuras.eATCCO
                Case "ATCTR"
                    wl_eATCTR = New moe_Estructuras.eATCTR
                    wp_eATCTR = New moe_Estructuras.eATCTR
                    ReDim wl_aeATCTR(0)
                    wl_aeATCTR(0) = New moe_Estructuras.eATCTR
                Case "ATGRI"
                    wp_eATGRI = New moe_Estructuras.eATGRI
                    ReDim wl_aeATGRI(0)
                    wl_aeATGRI(0) = New moe_Estructuras.eATGRI
                Case "ATIVA"
                    wp_eATIVA = New moe_Estructuras.eATIVA
                    ReDim wl_aeATIVA(0)
                    wl_aeATIVA(0) = New moe_Estructuras.eATIVA
                Case "ATMON"
                    wp_eATMON = New moe_Estructuras.eATMON
                    wl_eATMON = New moe_Estructuras.eATMON
                    ReDim wl_aeATMON(0)
                    wl_aeATMON(0) = New moe_Estructuras.eATMON
                Case "ATOPE"
                    wp_eATOPE = New moe_Estructuras.eATOPE
                    wl_eATOPE = New moe_Estructuras.eATOPE
                    ReDim wl_aeATOPE(0)
                    wl_aeATOPE(0) = New moe_Estructuras.eATOPE
                Case "ATPCO"
                    wp_eATPCO = New moe_Estructuras.eATPCO
                    wl_eATPCO = New moe_Estructuras.eATPCO
                    ReDim wl_aeATPOP(0)
                    wl_aeATPCO(0) = New moe_Estructuras.eATPCO
                Case "ATPOP"
                    wp_eATPOP = New moe_Estructuras.eATPOP
                    wl_eATPOP = New moe_Estructuras.eATPOP
                    ReDim wl_aeATPOP(0)
                    wl_aeATPOP(0) = New moe_Estructuras.eATPOP
                Case "ATTIN"
                    wp_eATTIN = New moe_Estructuras.eATTIN
                    ReDim wl_aeATTIN(0)
                    wl_aeATTIN(0) = New moe_Estructuras.eATTIN
                Case "ATVEN"
                    wp_eATVEN = New moe_Estructuras.eATVEN
                    wl_eATVEN = New moe_Estructuras.eATVEN
                    ReDim wl_aeATVEN(0)
                    wl_aeATVEN(0) = New moe_Estructuras.eATVEN
                Case "ATZON"
                    wp_eATZON = New moe_Estructuras.eATZON
                    wl_eATZON = New moe_Estructuras.eATZON
                    ReDim wl_aeATZON(0)
                    wl_aeATZON(0) = New moe_Estructuras.eATZON
                Case "CEENI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eCEENI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeCEENI(0)
                    wl_aeCEENI(0) = New moe_Estructuras.eGEMOV
                Case "CEFAP"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eCEFAP = New moe_Estructuras.eGEMOV
                    ReDim wl_aeCEFAP(0)
                    wl_aeCEFAP(0) = New moe_Estructuras.eGEMOV
                Case "CEODC"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eCEODC = New moe_Estructuras.eGEMOV
                    ReDim wl_aeCEODC(0)
                    wl_aeCEODC(0) = New moe_Estructuras.eGEMOV
                Case "CESAI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eCESAI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeCESAI(0)
                    wl_aeCESAI(0) = New moe_Estructuras.eGEMOV
                Case "GEMOV"
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    ReDim wl_aeGEMOV(0)
                    wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
                Case "GEMOV_Grl"
                    wp_eGEMOV_Grl = New moe_Estructuras.eGEMOV
                    ReDim wl_aeGEMOV_Grl(0)
                    wl_aeGEMOV_Grl(0) = New moe_Estructuras.eGEMOV
                Case "GEMOV_IniFin"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    ReDim wl_aeGEMOV(0)
                    ReDim wg_aeGEMOV(0)
                    wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
                    wg_aeGEMOV(0) = New moe_Estructuras.eGEMOV
                Case "IEMOV"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    ReDim wl_aeGEMOV(0)
                    ReDim wg_aeGEMOV(0)
                    wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
                    wg_aeGEMOV(0) = New moe_Estructuras.eGEMOV
                Case "FTPUC"
                    wp_eFTPUC = New moe_Estructuras.eFTPUC
                Case "HEDMT"
                    wp_eHEDMT = New moe_Estructuras.eHEDMT
                Case "IEDMI"
                    wl_eIEDMI = New moe_Estructuras.eIEDMI
                    ReDim wl_aeIEDMI(0)
                    wl_aeIEDMI(0) = New moe_Estructuras.eIEDMI
                Case "IEDMI_QGrl"
                    wp_eIEDMI_QGrl = New moe_Estructuras.eIEDMI
                    ReDim wl_aeIEDMI_QGrl(0)
                    wl_aeIEDMI_QGrl(0) = New moe_Estructuras.eIEDMI
                Case "IELDMI1_QIniFin"
                    wp_eIELDMI1 = New moe_Estructuras.eIELDMI1
                    ReDim wl_aeIELDMI1(0)
                    ReDim wg_aeIELDMI1(0)
                    wl_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1
                    wg_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1
                Case "IEDMIR"
                    wl_eIEDMI = New moe_Estructuras.eIEDMI
                    ReDim wl_aeIEDMI(0)
                    wl_aeIEDMI(0) = New moe_Estructuras.eIEDMI
                Case "IEENI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eIEENI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeIEENI(0)
                    wl_aeIEENI(0) = New moe_Estructuras.eGEMOV
                Case "IELDMI1"
                    wp_eIELDMI1 = New moe_Estructuras.eIELDMI1
                    ReDim wl_aeIELDMI1(0)
                    wl_aeIELDMI1(0) = New moe_Estructuras.eIELDMI1
                Case "IEREV"
                    wp_eIEREV = New moe_Estructuras.eIEREV
                    wl_eIEREV = New moe_Estructuras.eIEREV
                    ReDim wl_aeIEREV(0)
                    wl_aeIEREV(0) = New moe_Estructuras.eIEREV
                Case "ILDMI2"
                    wp_Q1_eILDMI2 = New moe_Estructuras.Q1_eILDMI2
                    wl_Q1_eILDMI2 = New moe_Estructuras.Q1_eILDMI2
                    ReDim wl_Q1_aeILDMI2(0)
                    wl_Q1_aeILDMI2(0) = New moe_Estructuras.Q1_eILDMI2
                Case "IESAI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eIESAI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeIESAI(0)
                    wl_aeIESAI(0) = New moe_Estructuras.eGEMOV
                Case "IETRI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eIETRI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeIETRI(0)
                    wl_aeIETRI(0) = New moe_Estructuras.eGEMOV
                Case "KARDEX"
                    wl_eKARDEX = New moe_Estructuras.eKARDEX
                    ReDim wl_aeKARDEX(0)
                    wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
                Case "KARDEX_QGrl"
                    wp_eKARDEX_QGrl = New moe_Estructuras.eKARDEX
                    ReDim wl_aeKARDEX_QGrl(0)
                    wl_aeKARDEX_QGrl(0) = New moe_Estructuras.eKARDEX
                Case "KARDEX_QIniFin"
                    wp_eKARDEX = New moe_Estructuras.eKARDEX
                    ReDim wl_aeKARDEX(0)
                    ReDim wg_aeKARDEX(0)
                    wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
                    wg_aeKARDEX(0) = New moe_Estructuras.eKARDEX
                Case "PEEDM"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_ePEEDM = New moe_Estructuras.eGEMOV
                    ReDim wl_aePEEDM(0)
                    wl_aePEEDM(0) = New moe_Estructuras.eGEMOV
                Case "PEEDP"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_ePEEDP = New moe_Estructuras.eGEMOV
                    ReDim wl_aePEEDP(0)
                    wl_aePEEDP(0) = New moe_Estructuras.eGEMOV
                Case "PEFOM"
                    wp_ePEFOM = New moe_Estructuras.ePEFOM
                    ReDim wl_aePEFOM(0)
                    wl_aePEFOM(0) = New moe_Estructuras.ePEFOM
                Case "PELIM"
                    wp_ePELIM = New moe_Estructuras.ePELIM
                    wp_Q_ePELIM_eIEDMI = New moe_Estructuras.Q_ePELIM_eIEDMI
                    ReDim wl_aQ_ePELIM_eIEDMI(0)
                    wl_aQ_ePELIM_eIEDMI(0) = New moe_Estructuras.Q_ePELIM_eIEDMI
                Case "PEODP"
                    wp_ePEODP = New moe_Estructuras.ePEODP
                    ReDim wl_aePEODP(0)
                    wl_aePEODP(0) = New moe_Estructuras.ePEODP
                Case "PEODP_QGrl"
                    wp_ePEODP_QGrl = New moe_Estructuras.ePEODP
                    ReDim wl_aePEODP_QGrl(0)
                    wl_aePEODP_QGrl(0) = New moe_Estructuras.ePEODP
                Case "PEODP_QIniFin"
                    wp_ePEODP = New moe_Estructuras.ePEODP
                    ReDim wl_aePEODP(0)
                    wl_aePEODP(0) = New moe_Estructuras.ePEODP
                Case "PLODP1"
                    wp_ePLODP1 = New moe_Estructuras.ePLODP1
                    ReDim wl_aePLODP1(0)
                    wl_aePLODP1(0) = New moe_Estructuras.ePLODP1
                Case "PLODP2"
                    wp_ePLODP2 = New moe_Estructuras.ePLODP2
                    ReDim wl_aePLODP2(0)
                    wl_aePLODP2(0) = New moe_Estructuras.ePLODP2
                Case "PLODP3"
                    wp_ePLODP3 = New moe_Estructuras.ePLODP3
                    ReDim wl_aePLODP3(0)
                    wl_aePLODP3(0) = New moe_Estructuras.ePLODP3
                Case "Q_PQFOM1"
                    wp_eQ_PQFOM1 = New moe_Estructuras.eQ_PQFOM1
                    ReDim wl_aeQ_PQFOM1(0)
                    wl_aeQ_PQFOM1(0) = New moe_Estructuras.eQ_PQFOM1
                Case "Q_PQLIM1"
                    wp_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1
                    ReDim wl_aeQ_PQLIM1(0)
                    wl_aeQ_PQLIM1(0) = New moe_Estructuras.eQ_PQLIM1
                Case "PEROP"
                    wp_ePEROP = New moe_Estructuras.ePEROP
                    ReDim wl_aePEROP(0)
                    wl_aePEROP(0) = New moe_Estructuras.ePEROP
                Case "PEROP_QGrl"
                    wp_ePEROP_Grl = New moe_Estructuras.ePEROP
                    ReDim wl_aePEROP_Grl(0)
                    wl_aePEROP_Grl(0) = New moe_Estructuras.ePEROP
                Case "PEROP_IniFin"
                    wp_ePELROP1 = New moe_Estructuras.ePELROP1
                    ReDim wl_aePELROP1(0)
                    wl_aePELROP1(0) = New moe_Estructuras.ePELROP1
                Case "PESDM"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_ePESDM = New moe_Estructuras.eGEMOV
                    ReDim wl_aePESDM(0)
                    wl_aePESDM(0) = New moe_Estructuras.eGEMOV
                Case "PESDP"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_ePESDP = New moe_Estructuras.eGEMOV
                    ReDim wl_aePESDP(0)
                    wl_aePESDP(0) = New moe_Estructuras.eGEMOV
                Case "TEDMT"
                    wp_eTEDMT = New moe_Estructuras.eTEDMT
                    ReDim wl_aeTEDMT(0)
                    wl_aeTEDMT(0) = New moe_Estructuras.eTEDMT
                Case "TEDMT_1"
                    wp_eTEDMT = New moe_Estructuras.eTEDMT
                    ReDim wl_aeTEDMT(0)
                    wl_aeTEDMT(0) = New moe_Estructuras.eTEDMT
                Case "TEDMT_2"
                    wp_eTEDMT = New moe_Estructuras.eTEDMT
                    ReDim wl_aeTEDMT(0)
                    wl_aeTEDMT(0) = New moe_Estructuras.eTEDMT
                Case "VEENI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eVEENI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeVEENI(0)
                    wl_aeVEENI(0) = New moe_Estructuras.eGEMOV
                Case "VESAI"
                    wp_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eGEMOV = New moe_Estructuras.eGEMOV
                    wl_eVESAI = New moe_Estructuras.eGEMOV
                    ReDim wl_aeVESAI(0)
                    wl_aeVESAI(0) = New moe_Estructuras.eGEMOV

            End Select

        Catch ex As Exception
            MsgBox("Error : cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Plo_DevSel()
        Try
            Dim wl_nCntReg As Integer
            Dim wl_nRow As Integer
            wl_nRow = 0
            wl_nCntReg = 0
            If dgv1.Rows.Count < 1 Then
                Exit Sub
            End If
            If dgv1.Rows.Count > 1 Then
                wl_YFin = dgv1.Rows.Count - 1
                wl_nRow = 0
                wl_nCntReg = 0
                For wl_nRow = 0 To dgv1.Rows.Count - 1
                    If dgv1.Rows(wl_nRow).Cells(0).Selected = True Then
                        wl_nCntReg = wl_nCntReg + 1
                    End If
                Next
                '20190403. Cambio hecho pq en frmActPEROPAbr está generando un registro vacío.
                'Verificar en todas las demás consultas.
                'Inicio
                wl_nCntReg = wl_nCntReg - 1
                'Fin
                'Para selección múltiple
                Select Case wg_sTblCon1
                    Case "ATPOP"
                        '20190403. Cambio hecho pq en frmActPEROPAbr está generando un registro vacío.
                        'Verificar en todas las demás consultas.
                        'Inicio
                        '  wl_nCntReg = wl_nCntReg - 1
                        'Fin

                        ReDim wl_aeATPOP(wl_nCntReg)
                        wl_aeATPOP(wl_nCntReg) = New moe_Estructuras.eATPOP
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "IEMOV"
                        ReDim wl_aeGEMOV(wl_nCntReg)
                        wl_aeGEMOV(wl_nCntReg) = New moe_Estructuras.eGEMOV
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "CEODC"
                        ReDim wl_aeGEMOV(wl_nCntReg)
                        wl_aeGEMOV(wl_nCntReg) = New moe_Estructuras.eGEMOV
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "GEMOV_IniFin"
                        ReDim wl_aeGEMOV(wl_nCntReg)
                        wl_aeGEMOV(wl_nCntReg) = New moe_Estructuras.eGEMOV
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "GELMOV1_IniFin"
                        ReDim wl_aeGELMOV1(wl_nCntReg)
                        wl_aeGELMOV1(wl_nCntReg) = New moe_Estructuras.eGELMOV1
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "KARDEX_QIniFin"
                        ReDim wl_aeKARDEX(wl_nCntReg)
                        wl_aeKARDEX(wl_nCntReg) = New moe_Estructuras.eKARDEX
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "PEODP_QIniFin"
                        ReDim wl_aePEODP(wl_nCntReg)
                        wl_aePEODP(wl_nCntReg) = New moe_Estructuras.ePEODP
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "PEROP_IniFin"
                        ReDim wl_aePELROP1(wl_nCntReg)
                        wl_aePELROP1(wl_nCntReg) = New moe_Estructuras.ePELROP1
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If
                    Case "IELDMI1_QIniFin"
                        ReDim wl_aeIELDMI1(wl_nCntReg)
                        wl_aeIELDMI1(wl_nCntReg) = New moe_Estructuras.eIELDMI1
                        If wl_nCntReg > 1 Then
                            wl_YIni = 0
                        End If

                End Select
            End If

            


            Select Case wg_sTblCon1
                Case "ABEOC"
                    ReDim wl_aeABEOC(wl_nCntReg)
                Case "ABEOP"
                    ReDim wl_aeABEOP(wl_nCntReg)
                Case "ABODP"
                    ReDim wl_aeABODP(wl_nCntReg)
                Case "APLND1"
                    ReDim wl_aeAPLND1(wl_nCntReg)
                Case "ATALM"
                    ReDim wl_aeATALM(wl_nCntReg)
                Case "ATANA"
                    ReDim wl_aeATANA(wl_nCntReg)
                Case "ATCCO"
                    ReDim wl_aeATCCO(wl_nCntReg)
                Case "ATCIF"
                    ReDim wl_aeATCIF(wl_nCntReg)
                Case "ATIVA"
                    ReDim wl_aeATIVA(wl_nCntReg)
                Case "ATOPE"
                    ReDim wl_aeATOPE(wl_nCntReg)
                Case "ATPCO"
                    ReDim wl_aeATPCO(wl_nCntReg)
                Case "ATPOP"
                    ReDim wl_aeATPOP(wl_nCntReg)
                Case "ATTIN"
                    ReDim wl_aeATTIN(wl_nCntReg)
                Case "ATVEN"
                    ReDim wl_aeATVEN(wl_nCntReg)
                Case "ATZON"
                    ReDim wl_aeATZON(wl_nCntReg)
                Case "CEENI"
                    ReDim wl_aeCEENI(wl_nCntReg)
                Case "CEODC"
                    ReDim wl_aeCEODC(wl_nCntReg)
                Case "CESAI"
                    ReDim wl_aeCESAI(wl_nCntReg)
                Case "FTPUC"
                    ReDim wl_aeFTPUC(wl_nCntReg)
                Case "GEMOV"
                    ReDim wl_aeGEMOV(wl_nCntReg)
                Case "GEMOV_Grl"
                    ReDim wl_aeGEMOV(wl_nCntReg)
                    '    Case "GEMOV_IniFin"
                Case "GELMOV1_Grl"
                    ReDim wl_aeGELMOV1(wl_nCntReg)
                Case "GELMOV1_IniFin"
                    ReDim wl_aeGELMOV1(wl_nCntReg)
                    '    Case "GEMOV_IniFin"
                Case "IEMOV"
                    ReDim wl_aeGEMOV(wl_nCntReg)
                Case "HEDMT"
                    ReDim wl_aeHEDMT(wl_nCntReg)
                Case "IEDMI"
                    ReDim wl_aeIEDMI(wl_nCntReg)
                Case "IEDMI_QGrl"
                    ReDim wl_aeIEDMI(wl_nCntReg)
                Case "IELDMI1_QIniFin"
                    ReDim wl_aeIELDMI1(wl_nCntReg)
                Case "IEDMIR"
                    ReDim wl_aeIEDMI(wl_nCntReg)
                Case "IEENI"
                    ReDim wl_aeIEENI(wl_nCntReg)
                Case "IELDMI1"
                    ReDim wl_aeIELDMI1(wl_nCntReg)
                Case "ILDMI2"
                    ReDim wl_Q1_aeILDMI2(wl_nCntReg)
                Case "IESAI"
                    ReDim wl_aeIESAI(wl_nCntReg)
                Case "IEREV"
                    ReDim wl_aeIEREV(wl_nCntReg)
                Case "IETRI"
                    ReDim wl_aeIETRI(wl_nCntReg)
                Case "KARDEX"
                    ReDim wl_aeKARDEX(wl_nCntReg)
                Case "KARDEX_QGrl"
                    ReDim wl_aeKARDEX(wl_nCntReg)
                Case "KARDEX_QIniFin"
                    ReDim wl_aeKARDEX(wl_nCntReg)
                Case "PEFOM"
                    ReDim wl_aePEFOM(wl_nCntReg)
                Case "PELIM"
                    ReDim wl_aePELIM(wl_nCntReg)
                    ReDim wl_aQ_ePELIM_eIEDMI(wl_nCntReg)
                Case "PEODP"
                    ReDim wl_aePEODP(wl_nCntReg)
                Case "PEODP_QGrl"
                    ReDim wl_aePEODP_QGrl(wl_nCntReg)
                Case "PEODP_QIniFin"
                    ReDim wl_aePEODP(wl_nCntReg)
                Case "PEROP"
                    ReDim wl_aePEROP(wl_nCntReg)
                Case "PEROP_Grl"
                    ReDim wl_aePEROP_Grl(wl_nCntReg)
                Case "PEROP_IniFin"
                    ReDim wl_aePELROP1(wl_nCntReg)
                Case "PLODP1"
                    ReDim wl_aePLODP1(wl_nCntReg)
                Case "PLODP2"
                    ReDim wl_aePLODP2(wl_nCntReg)
                Case "PLODP3"
                    ReDim wl_aePLODP3(wl_nCntReg)
                Case "Q_PQFOM1"
                    ReDim wl_aeQ_PQFOM1(wl_nCntReg)
                Case "Q_PQLIM1"
                    ReDim wl_aeQ_PQLIM1(wl_nCntReg)
                Case "PESDM"
                    ReDim wl_aePESDM(wl_nCntReg)
                Case "TEDMT"
                    ReDim wl_aeTEDMT(wl_nCntReg)
                Case "TEDMT_1"
                    ReDim wl_aeTEDMT(wl_nCntReg)
                Case "TEDMT_2"
                    ReDim wl_aeTEDMT(wl_nCntReg)
                Case "VEENI"
                    ReDim wl_aeVEENI(wl_nCntReg)
                Case "VESAI"
                    ReDim wl_aeVESAI(wl_nCntReg)
            End Select
            wl_nCntReg = 0
            For wl_nRow = wl_YIni To wl_YFin
                If dgv1.Rows(wl_nRow).Cells(0).Selected Then
                    Select Case wg_sTblCon1
                        Case "ABEOC"
                            wl_eABEOC = New moe_Estructuras.eABEOC
                            wl_aeABEOC(wl_nCntReg) = New moe_Estructuras.eABEOC
                            moo_eABEOC_DGV(wl_eABEOC,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeABEOC(wl_nCntReg) = wl_eABEOC
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ABEOP"
                            wl_eABEOP = New moe_Estructuras.eABEOP
                            wl_aeABEOP(wl_nCntReg) = New moe_Estructuras.eABEOP
                            moo_eABEOP_DGV(wl_eABEOP,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeABEOP(wl_nCntReg) = wl_eABEOP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ABODP"
                            wl_eABODP = New moe_Estructuras.eABODP
                            wl_aeABODP(wl_nCntReg) = New moe_Estructuras.eABODP
                            moo_eABODP_DGV(wl_eABODP,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeABODP(wl_nCntReg) = wl_eABODP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "APLND1"
                            wl_eAPLND1 = New moe_Estructuras.eAPLND1
                            wl_aeAPLND1(wl_nCntReg) = New moe_Estructuras.eAPLND1
                            moo_eAPLND1_DGV(wl_eAPLND1,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeAPLND1(wl_nCntReg) = wl_eAPLND1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATALM"
                            wl_eATALM = New moe_Estructuras.eATALM
                            wl_aeATALM(wl_nCntReg) = New moe_Estructuras.eATALM
                            moo_eATALM_DGV(wl_eATALM,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATALM(wl_nCntReg) = wl_eATALM
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATANA"
                            wl_eATANA = New moe_Estructuras.eATANA
                            wl_aeATANA(wl_nCntReg) = New moe_Estructuras.eATANA
                            moo_eATANA_DGV(wl_eATANA,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATANA(wl_nCntReg) = wl_eATANA
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATCCO"
                            wl_eATCCO = New moe_Estructuras.eATCCO
                            wl_aeATCCO(wl_nCntReg) = New moe_Estructuras.eATCCO
                            moo_eATCCO_DGV(wl_eATCCO,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATCCO(wl_nCntReg) = wl_eATCCO
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATCIF"
                            wl_eATCIF = New moe_Estructuras.eATCIF
                            wl_aeATCIF(wl_nCntReg) = New moe_Estructuras.eATCIF
                            moo_DTVarDGV.moo_eATCIF_DGV(wl_eATCIF,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aeATCIF(wl_nCntReg) = wl_eATCIF
                            wl_nCntReg = wl_nCntReg + 1

                        Case "ATIVA"
                            wl_eATIVA = New moe_Estructuras.eATIVA
                            wl_aeATIVA(wl_nCntReg) = New moe_Estructuras.eATIVA
                            moo_eATIVA_DGV(wl_eATIVA,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATIVA(wl_nCntReg) = wl_eATIVA
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATMON"
                            wl_eATMON = New moe_Estructuras.eATMON
                            wl_aeATMON(wl_nCntReg) = New moe_Estructuras.eATMON
                            moo_eATMON_DGV(wl_eATMON,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATMON(wl_nCntReg) = wl_eATMON
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATOPE"
                            wl_eATOPE = New moe_Estructuras.eATOPE
                            wl_aeATOPE(wl_nCntReg) = New moe_Estructuras.eATOPE
                            moo_DTVarDGV.moo_eATOPE_DGV(wl_eATOPE,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aeATOPE(wl_nCntReg) = wl_eATOPE
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATPCO"
                            wl_eATPCO = New moe_Estructuras.eATPCO
                            wl_aeATPCO(wl_nCntReg) = New moe_Estructuras.eATPCO
                            moo_DTVarDGV.moo_eATPCO_DGV(wl_eATPCO,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aeATPCO(wl_nCntReg) = wl_eATPCO
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATPOP"
                            wl_eATPOP = New moe_Estructuras.eATPOP
                            wl_aeATPOP(wl_nCntReg) = New moe_Estructuras.eATPOP
                            moo_DTVarDGV.moo_eATPOP_DGV(wl_eATPOP,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aeATPOP(wl_nCntReg) = wl_eATPOP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATTIN"
                            wl_eATTIN = New moe_Estructuras.eATTIN
                            wl_aeATTIN(wl_nCntReg) = New moe_Estructuras.eATTIN
                            moo_eATTIN_DGV(wl_eATTIN,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATTIN(wl_nCntReg) = wl_eATTIN
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATVEN"
                            wl_eATVEN = New moe_Estructuras.eATVEN
                            wl_aeATVEN(wl_nCntReg) = New moe_Estructuras.eATVEN
                            moo_eATVEN_DGV(wl_eATVEN,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATVEN(wl_nCntReg) = wl_eATVEN
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ATZON"
                            wl_eATZON = New moe_Estructuras.eATZON
                            wl_aeATZON(wl_nCntReg) = New moe_Estructuras.eATZON
                            moo_eATZON_DGV(wl_eATZON,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeATZON(wl_nCntReg) = wl_eATZON
                            wl_nCntReg = wl_nCntReg + 1
                        Case "CEENI"
                            wl_eCEENI = New moe_Estructuras.eGEMOV
                            wl_aeCEENI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eCEENI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeCEENI(wl_nCntReg) = wl_eCEENI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "CEODC"
                            wl_eCEODC = New moe_Estructuras.eGEMOV
                            wl_aeCEODC(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eCEODC,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeCEODC(wl_nCntReg) = wl_eCEODC
                            wl_nCntReg = wl_nCntReg + 1
                        Case "CESAI"
                            wl_eCESAI = New moe_Estructuras.eGEMOV
                            wl_aeCESAI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eCESAI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeCESAI(wl_nCntReg) = wl_eCESAI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "FTPUC"
                            wl_eFTPUC = New moe_Estructuras.eFTPUC
                            wl_aeFTPUC(wl_nCntReg) = New moe_Estructuras.eFTPUC
                            moo_eFTPUC_DGV(wl_eFTPUC,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeFTPUC(wl_nCntReg) = wl_eFTPUC
                            wl_nCntReg = wl_nCntReg + 1
                        Case "GEMOV"
                            wl_eGEMOV = New moe_Estructuras.eGEMOV
                            wl_aeGEMOV(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eGEMOV,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeGEMOV(wl_nCntReg) = wl_eGEMOV
                            wl_nCntReg = wl_nCntReg + 1
                        Case "GEMOV_Grl"
                            wl_eGEMOV_Grl = New moe_Estructuras.eGEMOV
                            wl_aeGEMOV_Grl(wl_nCntReg) = New moe_Estructuras.eGEMOV

                            If wg_sCodStr = "EGEMOV_QTIPMOV" Then
                                moo_DTVarDGV.moo_eGEMOV_QTipMov_DGV(wl_eGEMOV_Grl,
                                                                Me.dgv1,
                                                                wl_nRow)
                            End If
                            If wg_sCodStr = "EGEMOV_QCODDOC" Then
                                moo_DTVarDGV.moo_eGEMOV_QCodDoc_DGV(wl_eGEMOV_Grl,
                                                                    Me.dgv1,
                                                                    wl_nRow)
                            End If
                            If wg_sCodStr = "EGEMOV_QNRODOC" Then
                                moo_DTVarDGV.moo_eGEMOV_QNroDoc_DGV(wl_eGEMOV_Grl,
                                                                    Me.dgv1,
                                                                    wl_nRow)
                            End If
                            If wg_sCodStr = "EGEMOV_QCODSER" Then
                                moo_DTVarDGV.moo_eGEMOV_QCodSer_DGV(wl_eGEMOV_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGEMOV_QCODTER" Then
                                moo_DTVarDGV.moo_eGEMOV_QCodTer_DGV(wl_eGEMOV_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGEMOV_QCODTRA" Then
                                moo_DTVarDGV.moo_eGEMOV_QCodTra_DGV(wl_eGEMOV_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGEMOV_QESTDOC" Then
                                moo_DTVarDGV.moo_eGEMOV_QEstDoc_DGV(wl_eGEMOV_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If


                            wl_aeGEMOV_Grl(wl_nCntReg) = wl_eGEMOV_Grl
                            wl_nCntReg = wl_nCntReg + 1
                        Case "GEMOV_IniFin"
                            wl_eGEMOV = New moe_Estructuras.eGEMOV
                            wl_aeGEMOV(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eGEMOV,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeGEMOV(wl_nCntReg) = wl_eGEMOV
                            wl_nCntReg = wl_nCntReg + 1
                        Case "GELMOV1"
                            wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                            wl_aeGELMOV1(wl_nCntReg) = New moe_Estructuras.eGELMOV1
                            moo_eGELMOV1_DGV(wl_eGELMOV1,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeGELMOV1(wl_nCntReg) = wl_eGELMOV1
                            wl_nCntReg = wl_nCntReg + 1

                        Case "GELMOV1_Grl"
                            wl_eGELMOV1_Grl = New moe_Estructuras.eGELMOV1
                            wl_aeGELMOV1_Grl(wl_nCntReg) = New moe_Estructuras.eGELMOV1

                            If wg_sCodStr = "EGELMOV1_QTIPMOV" Then
                                moo_DTVarDGV.moo_eGELMOV1_QTipMov_DGV(wl_eGELMOV1_Grl,
                                                                Me.dgv1,
                                                                wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QCODDOC" Then
                                moo_DTVarDGV.moo_eGELMOV1_QCodDoc_DGV(wl_eGELMOV1_Grl,
                                                                    Me.dgv1,
                                                                    wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QNRODOC" Then
                                moo_DTVarDGV.moo_eGELMOV1_QNroDoc_DGV(wl_eGELMOV1_Grl,
                                                                    Me.dgv1,
                                                                    wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QCODSER" Then
                                moo_DTVarDGV.moo_eGELMOV1_QCodSer_DGV(wl_eGELMOV1_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QCODTER" Then
                                moo_DTVarDGV.moo_eGELMOV1_QCodTer_DGV(wl_eGELMOV1_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QCODTRA" Then
                                moo_DTVarDGV.moo_eGELMOV1_QCodTra_DGV(wl_eGELMOV1_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QESTDOC" Then
                                moo_DTVarDGV.moo_eGELMOV1_QEstDoc_DGV(wl_eGELMOV1_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EGELMOV1_QCODITM" Then
                                moo_DTVarDGV.moo_eGELMOV1_QCodItm_DGV(wl_eGELMOV1_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If

                            wl_aeGELMOV1_Grl(wl_nCntReg) = wl_eGELMOV1_Grl
                            wl_nCntReg = wl_nCntReg + 1
                        Case "GELMOV1_IniFin"
                            wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
                            wl_aeGELMOV1(wl_nCntReg) = New moe_Estructuras.eGELMOV1
                            moo_eGELMOV1_DGV(wl_eGELMOV1,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeGELMOV1(wl_nCntReg) = wl_eGELMOV1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IEMOV"
                            wl_eGEMOV = New moe_Estructuras.eGEMOV
                            wl_aeGEMOV(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eGEMOV,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeGEMOV(wl_nCntReg) = wl_eGEMOV
                            wl_nCntReg = wl_nCntReg + 1

                        Case "HEDMT"
                            wl_eTEDMT = New moe_Estructuras.eHEDMT
                            wl_aeHEDMT(wl_nCntReg) = New moe_Estructuras.eHEDMT
                            moo_eHEDMT_DGV(wl_eHEDMT,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeHEDMT(wl_nCntReg) = wl_eHEDMT
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IEDMI"
                            wl_eIEDMI = New moe_Estructuras.eIEDMI
                            wl_aeIEDMI(wl_nCntReg) = New moe_Estructuras.eIEDMI
                            moo_eIEDMI_DGV(wl_eIEDMI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeIEDMI(wl_nCntReg) = wl_eIEDMI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IEDMI_QGrl"
                            wl_eIEDMI_QGrl = New moe_Estructuras.eIEDMI
                            wl_aeIEDMI_QGrl(wl_nCntReg) = New moe_Estructuras.eIEDMI

                            If wg_sCodStr = "EIEDMI_QITM" Then
                                moo_DTVarDGV.moo_eIEDMI_QItm_DGV(wl_eIEDMI_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EIEDMI_QALM" Then
                                moo_DTVarDGV.moo_eIEDMI_QAlm_DGV(wl_eIEDMI_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EIEDMI_QGRP" Then
                                moo_DTVarDGV.moo_eIEDMI_QGrp_DGV(wl_eIEDMI_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If

                            wl_aeIEDMI_QGrl(wl_nCntReg) = wl_eIEDMI_QGrl
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IELDMI1_QIniFin"
                            wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
                            wl_aeIELDMI1(wl_nCntReg) = New moe_Estructuras.eIELDMI1
                            moo_DTVarDGV.moo_eIELDMI1_DGV(wl_eIELDMI1,
                                                          Me.dgv1,
                                                          wl_nRow)
                            wl_aeIELDMI1(wl_nCntReg) = wl_eIELDMI1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IEDMIR"
                            wl_eIEDMI = New moe_Estructuras.eIEDMI
                            wl_aeIEDMI(wl_nCntReg) = New moe_Estructuras.eIEDMI
                            moo_eIEDMIR_DGV(wl_eIEDMI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeIEDMI(wl_nCntReg) = wl_eIEDMI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IEENI"
                            wl_eIEENI = New moe_Estructuras.eGEMOV
                            wl_aeIEENI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eIEENI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeIEENI(wl_nCntReg) = wl_eIEENI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "ILDMI2"
                            wl_Q1_eILDMI2 = New moe_Estructuras.Q1_eILDMI2
                            wl_Q1_aeILDMI2(wl_nCntReg) = New moe_Estructuras.Q1_eILDMI2
                            moo_Q1_eILDMI2_DGV(wl_Q1_eILDMI2,
                                               Me.dgv1,
                                               wl_nRow)
                            wl_Q1_aeILDMI2(wl_nCntReg) = wl_Q1_eILDMI2
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IELDMI1"
                            wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
                            wl_aeIELDMI1(wl_nCntReg) = New moe_Estructuras.eIELDMI1
                            moo_eIELDMI1_DGV(wg_eIELDMI1,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aeIELDMI1(wl_nCntReg) = wg_eIELDMI1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IESAI"
                            wl_eIESAI = New moe_Estructuras.eGEMOV
                            wl_aeIESAI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eIESAI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeIESAI(wl_nCntReg) = wl_eIESAI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IETRI"
                            wl_eIETRI = New moe_Estructuras.eGEMOV
                            wl_aeIETRI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eIETRI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeIETRI(wl_nCntReg) = wl_eIETRI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "IEREV"
                            wl_eIEREV = New moe_Estructuras.eIEREV
                            wl_aeIEREV(wl_nCntReg) = New moe_Estructuras.eIEREV
                            moo_eIEREV_DGV(wl_eIEREV,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeIEREV(wl_nCntReg) = wl_eIEREV
                            wl_nCntReg = wl_nCntReg + 1
                        Case "KARDEX"
                            wl_eKARDEX = New moe_Estructuras.eKARDEX
                            wl_aeKARDEX(wl_nCntReg) = New moe_Estructuras.eKARDEX
                            moo_eKARDEX_DGV(wl_eKARDEX,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeKARDEX(wl_nCntReg) = wl_eKARDEX
                            wl_nCntReg = wl_nCntReg + 1

                        Case "KARDEX_QGrl"
                            wl_eKARDEX_QGrl = New moe_Estructuras.eKARDEX
                            wl_aeKARDEX_QGrl(wl_nCntReg) = New moe_Estructuras.eKARDEX
                            If wg_sCodStr = "EKARDEX_QITM" Then
                                moo_DTVarDGV.moo_eKARDEX_QItm_DGV(wl_eKARDEX_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EKARDEX_QALM" Then
                                moo_DTVarDGV.moo_eKARDEX_QAlm_DGV(wl_eKARDEX_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            wl_aeKARDEX_QGrl(wl_nCntReg) = wl_eKARDEX_QGrl
                            wl_nCntReg = wl_nCntReg + 1

                        Case "KARDEX_QIniFin"
                            wl_eKARDEX = New moe_Estructuras.eKARDEX
                            wl_aeKARDEX(wl_nCntReg) = New moe_Estructuras.eKARDEX
                            moo_DTVarDGV.moo_eKARDEX_DGV(wl_eKARDEX,
                                                          Me.dgv1,
                                                          wl_nRow)
                            wl_aeKARDEX(wl_nCntReg) = wl_eKARDEX
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEEDM"
                            wl_ePEEDM = New moe_Estructuras.eGEMOV
                            wl_aePEEDM(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_ePEEDM,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aePEEDM(wl_nCntReg) = wl_ePEEDM
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEEDP"
                            wl_ePEEDP = New moe_Estructuras.eGEMOV
                            wl_aePEEDP(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_ePEEDP,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aePEEDP(wl_nCntReg) = wl_ePEEDP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEFOM"
                            wl_ePEFOM = New moe_Estructuras.ePEFOM
                            wl_aePEFOM(wl_nCntReg) = New moe_Estructuras.ePEFOM
                            moo_ePEFOM_DGV(wl_ePEFOM,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aePEFOM(wl_nCntReg) = wl_ePEFOM
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PELIM"
                            wl_Q_ePELIM_eIEDMI = New moe_Estructuras.Q_ePELIM_eIEDMI
                            wl_aQ_ePELIM_eIEDMI(wl_nCntReg) = New moe_Estructuras.Q_ePELIM_eIEDMI
                            moo_ePELIM_DGV(wl_Q_ePELIM_eIEDMI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aQ_ePELIM_eIEDMI(wl_nCntReg) = wl_Q_ePELIM_eIEDMI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEODP"
                            wl_ePEODP = New moe_Estructuras.ePEODP
                            wl_aePEODP(wl_nCntReg) = New moe_Estructuras.ePEODP
                            moo_DTVarDGV.moo_ePEODP_DGV(wl_ePEODP,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aePEODP(wl_nCntReg) = wl_ePEODP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEODP_QGrl"
                            wl_ePEODP_QGrl = New moe_Estructuras.ePEODP
                            wl_aePEODP_QGrl(wl_nCntReg) = New moe_Estructuras.ePEODP
                            If wg_sCodStr = "EPEODP_QCDOC" Then
                                moo_DTVarDGV.moo_ePEODP_QCDoc_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QCSER" Then
                                moo_DTVarDGV.moo_ePEODP_QCSer_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QEODP" Then
                                moo_DTVarDGV.moo_ePEODP_QEstODP_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QFEMI" Then
                                moo_DTVarDGV.moo_ePEODP_QFEmi_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QFFIN" Then
                                moo_DTVarDGV.moo_ePEODP_QFFin_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QFINI" Then
                                moo_DTVarDGV.moo_ePEODP_QFIni_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QITM" Then
                                moo_DTVarDGV.moo_ePEODP_QItm_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEODP_QNDOC" Then
                                moo_DTVarDGV.moo_ePEODP_QNDoc_DGV(wl_ePEODP_QGrl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            wl_aePEODP_QGrl(wl_nCntReg) = wl_ePEODP_QGrl
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEODP_QIniFin"

                            wl_ePEODP = New moe_Estructuras.ePEODP
                            wl_aePEODP(wl_nCntReg) = New moe_Estructuras.ePEODP
                            moo_DTVarDGV.moo_ePEODP_DGV(wl_ePEODP,
                                                        Me.dgv1,
                                                        wl_nRow)
                            wl_aePEODP(wl_nCntReg) = wl_ePEODP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEROP"
                            wl_ePEROP = New moe_Estructuras.ePEROP
                            wl_aePEROP(wl_nCntReg) = New moe_Estructuras.ePEROP
                            moo_DTVarDGV.moo_ePEROP_DGV(wl_ePEROP,
                                                        Me.dgv1,
                                                        wl_nRow)

                            wl_aePEROP(wl_nCntReg) = wl_ePEROP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PEROP_Grl"
                            wl_ePEROP_Grl = New moe_Estructuras.ePEROP
                            wl_aePEROP_Grl(wl_nCntReg) = New moe_Estructuras.ePEROP


                            If wg_sCodStr = "EPEROP_QNRODOC" Then
                                moo_DTVarDGV.moo_ePEROP_QNroDoc_DGV(wl_ePEROP_Grl,
                                                                    Me.dgv1,
                                                                    wl_nRow)
                            End If
                            If wg_sCodStr = "EPEROP_QCODSER" Then
                                moo_DTVarDGV.moo_ePEROP_QCodSer_DGV(wl_ePEROP_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If
                            If wg_sCodStr = "EPEROP_QCODTER" Then
                                moo_DTVarDGV.moo_ePEROP_QCodTer_DGV(wl_ePEROP_Grl,
                                                            Me.dgv1,
                                                            wl_nRow)
                            End If

                            wl_aePEROP_Grl(wl_nCntReg) = wl_ePEROP_Grl
                            wl_nCntReg = wl_nCntReg + 1

                        Case "PEROP_IniFin"

                            wl_ePELROP1 = New moe_Estructuras.ePELROP1
                            wl_aePELROP1(wl_nCntReg) = New moe_Estructuras.ePELROP1
                            moo_DTVarDGV.moo_ePELROP1_DGV(wl_ePELROP1,
                                                          Me.dgv1,
                                                          wl_nRow)
                            wl_aePELROP1(wl_nCntReg) = wl_ePELROP1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PLODP21"
                            wl_ePLODP1 = New moe_Estructuras.ePLODP1
                            wl_aePLODP1(wl_nCntReg) = New moe_Estructuras.ePLODP1
                            moo_DTVarDGV.moo_ePLODP1_DGV(wl_ePLODP1,
                                                         Me.dgv1,
                                                         wl_nRow)
                            wl_aePLODP1(wl_nCntReg) = wl_ePLODP1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PLODP2"
                            wl_ePLODP2 = New moe_Estructuras.ePLODP2
                            wl_aePLODP2(wl_nCntReg) = New moe_Estructuras.ePLODP2
                            moo_DTVarDGV.moo_ePLODP2_DGV(wl_ePLODP2,
                                                         Me.dgv1,
                                                         wl_nRow)
                            wl_aePLODP2(wl_nCntReg) = wl_ePLODP2
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PLODP3"
                            wl_ePLODP3 = New moe_Estructuras.ePLODP3
                            wl_aePLODP3(wl_nCntReg) = New moe_Estructuras.ePLODP3
                            moo_DTVarDGV.moo_ePLODP3_DGV(wl_ePLODP3,
                                                         Me.dgv1,
                                                         wl_nRow)
                            wl_aePLODP3(wl_nCntReg) = wl_ePLODP3
                            wl_nCntReg = wl_nCntReg + 1

                        Case "Q_PQFOM1"

                            wl_eQ_PQFOM1 = New moe_Estructuras.eQ_PQFOM1
                            wl_aeQ_PQFOM1(wl_nCntReg) = New moe_Estructuras.eQ_PQFOM1
                            moo_DTVarDGV.moo_eQ_PQFOM1_DGV(wl_eQ_PQFOM1,
                                                          Me.dgv1,
                                                          wl_nRow)
                            wl_aeQ_PQFOM1(wl_nCntReg) = wl_eQ_PQFOM1
                            wl_nCntReg = wl_nCntReg + 1
                        Case "Q_PQLIM1"

                            wl_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1
                            wl_aeQ_PQLIM1(wl_nCntReg) = New moe_Estructuras.eQ_PQLIM1
                            moo_DTVarDGV.moo_eQ_PQLIM1_DGV(wl_eQ_PQLIM1,
                                                          Me.dgv1,
                                                          wl_nRow)
                            wl_aeQ_PQLIM1(wl_nCntReg) = wl_eQ_PQLIM1
                            wl_nCntReg = wl_nCntReg + 1

                        Case "PESDM"
                            wl_ePESDM = New moe_Estructuras.eGEMOV
                            wl_aePESDM(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_ePESDM,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aePESDM(wl_nCntReg) = wl_ePESDM
                            wl_nCntReg = wl_nCntReg + 1
                        Case "PESDP"
                            wl_ePESDP = New moe_Estructuras.eGEMOV
                            wl_aePESDP(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_ePESDP,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aePESDP(wl_nCntReg) = wl_ePESDP
                            wl_nCntReg = wl_nCntReg + 1
                        Case "TEDMT"
                            wl_eTEDMT = New moe_Estructuras.eTEDMT
                            wl_aeTEDMT(wl_nCntReg) = New moe_Estructuras.eTEDMT
                            moo_eTEDMT_DGV(wl_eTEDMT,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeTEDMT(wl_nCntReg) = wl_eTEDMT
                            wl_nCntReg = wl_nCntReg + 1
                        Case "TEDMT_1"
                            wl_eTEDMT = New moe_Estructuras.eTEDMT
                            wl_aeTEDMT(wl_nCntReg) = New moe_Estructuras.eTEDMT
                            moo_eTEDMT_DGV(wl_eTEDMT,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeTEDMT(wl_nCntReg) = wl_eTEDMT
                            wl_nCntReg = wl_nCntReg + 1
                        Case "TEDMT_2"
                            wl_eTEDMT = New moe_Estructuras.eTEDMT
                            wl_aeTEDMT(wl_nCntReg) = New moe_Estructuras.eTEDMT
                            moo_eTEDMT_DGV(wl_eTEDMT,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeTEDMT(wl_nCntReg) = wl_eTEDMT
                            wl_nCntReg = wl_nCntReg + 1
                        Case "VEENI"
                            wl_eVEENI = New moe_Estructuras.eGEMOV
                            wl_aeVEENI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eVEENI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeVEENI(wl_nCntReg) = wl_eVEENI
                            wl_nCntReg = wl_nCntReg + 1
                        Case "VESAI"
                            wl_eVESAI = New moe_Estructuras.eGEMOV
                            wl_aeVESAI(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(wl_eVESAI,
                                           Me.dgv1,
                                           wl_nRow)
                            wl_aeVESAI(wl_nCntReg) = wl_eVESAI
                            wl_nCntReg = wl_nCntReg + 1
                    End Select
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_DevSel")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_inicializarVar()
        wl_sSelCon11 = ""
        wl_sSelCon12 = ""
        wl_nSelCon13 = 0
        wl_sSelCon14 = ""
        wg_sCmpCon11 = ""
        wg_sCmpCon12 = ""
        wg_sTitCon11 = ""
        wg_sTitCon12 = ""
        '  wg_sTblCon1 = ""
        wg_sCmpCon11 = ""
        'wg_sDatCon11 = ""
        wg_sTitCon11 = ""
        wg_sCmpCon12 = ""
        wg_sDatCon12 = ""
        wg_sTitCon12 = ""
        wg_sTblCon2 = ""
        wg_sSelCon11 = ""
        wr_bEOFCon1 = False
    End Sub
    Private Sub Plo_IniciarVarDGV()
        'dgv

        wl_nTab = 0
        wl_nRowVacia = 7


        wl_nColFin = 11
        'wl_nColIniGrl = 5
        wl_nColAnt = wl_nColIniGrl
        wl_nRowAnt = 0


        wl_nColVda1 = 4
        wl_nColVda2 = 5

        wl_sOpeLgc = "Y"


        mof_ConfigurarDGV(Me.dgv1,
                          wl_nTotcol)

        dgv_ConfiguraCol()
        dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv1.MultiSelect = True
    End Sub
#End Region
#Region "082 Elo PROCEDIMIENTOS EVENTOS PERSONALIZADOS"
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            TextBox1.Text = UCase(TextBox1.Text)
            TextBox1.Select(TextBox1.Text.Length, 0)
            For wl_nF = 0 To dgv1.Rows.Count - 2
                If dgv1.Rows(wl_nF).Cells(wl_nColOrd).Value.ToString.Contains(TextBox1.Text) Then
                    dgv1.CurrentCell = dgv1.Rows(wl_nF).Cells(wl_nColOrd)
                    Exit Sub
                End If
            Next wl_nF
        Catch ex As Exception
            MsgBox("Error en: TextBox1_TextChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                cmdSeleccionar.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv1_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub
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
    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export.Click
        Try
            'Export Header Names Start
            Dim columnsCount As Integer = dgv1.Columns.Count
            'For Each column In dgv1.Columns
            'oWorkSheet.Cells(1, column.Index + 1).Value = column.Name
            'Next
            'Export Header Name End

            'Export Each Row Start

            'For i As Integer = 0 To dgv1.Rows.Count - 1
            'Dim columnIndex As Integer = 0
            'Do Until columnIndex = columnsCount
            'oWorkSheet.Cells(i + 2, columnIndex + 1).Value = dgv1.Item(columnIndex, i).Value.ToString
            'columnIndex += 1
            'Loop
            ' Next
            'Export Each Row End
        Catch ex As Exception
            MsgBox("Error en: Export_Click")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

End Class