Public Class frmActPEROD
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2016-01-19

#Region "001 Inicia. wp - vp Definición del variables públicas"
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"
    ' vl numéricas

    ' wl Booleanas
    Dim wl_bYesNo As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bEOF As Boolean


    ' wl numéricas
    Dim wl_sNomTblCbo As String
    Dim wl_sNomFrm As String

    Dim wl_nCmpCla As String

    Dim wl_sCmpTSB As String
    Dim wl_sDatTSB As String
    Dim wl_sTipCmpTSB As String

    Dim wl_sCmpTSB1 As String
    Dim wl_sDatTSB1 As String
    Dim wl_sTipCmpTSB1 As String

    Dim wl_sCmpTSB2 As String
    Dim wl_sDatTSB2 As String
    Dim wl_sTipCmpTSB2 As String

    Dim wp_sTipCmp As String
    Dim wl_sTipTbl As String

    Dim wl_sClaPpl As String
    Dim wl_sClaPPl1 As String
    Dim wl_sClaPPl2 As String
    Dim wl_sDatCmpE11 As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNomCmpE11 As String
    Dim wl_sTipCmpE11 As String
    Dim wl_sTitCmpE11 As String
    Dim wl_sDatCmpE12 As String
    Dim wl_sNomTblE2 As String
    Dim wl_sNomCmpE12 As String
    Dim wl_sTipCmpE12 As String
    Dim wl_sTitCmpE12 As String
    Dim wl_sCmpOrdE11 As String
    Dim wl_sTipOrdE11 As String
    Dim wl_sMayMenIgu As String

    Dim wl_sNroALetras As String

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nNroDocFin As Long
    Dim vl_nNroDocIni As Long

    Dim wl_sCodDocFin As String
    Dim wl_sCodDocIni As String
    Dim wl_nNroDocIni As Long
    Dim wl_nNroDocFin As Long
    Dim wl_sCodSerFin As String
    Dim wl_sCodSerIni As String
    Dim wl_sCodTraFin As String
    Dim wl_sCodTraIni As String

    Dim wl_dFecDocIni As Date
    Dim wl_dFecDocFin As Date

    Dim wl_sCodItmFin As String
    Dim wl_sCodItmIni As String

    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodSer As String
    Dim vl_sCodTra As String
    Dim vl_sTipMov As String
    Dim vl_sCodItm As String
    Dim vl_sCodStr As String
    Dim vl_dFecDoc As Date
    Dim vl_sEstDoc As String
    Dim vl_sCodTer As String
    Dim wl_sCodAlm As String
    Dim wl_sCodGrp As String
    Dim vl_nNroDocBas As Long


#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnKARDEX As New ClaseNegocios.clnIEINV
    Dim cnf As New ClaseNegocios.clnFunciones
    Dim wl_DTE1 As DataTable
    Dim wl_DTE2 As DataTable
    Dim wl_DTL1 As DataTable
    Dim wl_DTL2 As DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_aeATOPE() As moe_Estructuras.eATOPE
    Dim wl_eATOPE As New moe_Estructuras.eATOPE
    Dim wl_aeAPEND() As moe_Estructuras.eAPEND
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_aeAPLND1() As moe_Estructuras.eAPLND1
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1

    Dim wl_aePEROP() As moe_Estructuras.ePEROP
    Dim wl_ePEROP As New moe_Estructuras.ePEROP
    Dim wl_aePEROP_Grl() As moe_Estructuras.ePEROP
    Dim wl_ePEROP_Grl As New moe_Estructuras.ePEROP
    Dim wl_aePEROP_Ini() As moe_Estructuras.ePEROP
    Dim wl_ePEROP_Ini As New moe_Estructuras.ePEROP
    Dim wl_aePEROP_Fin() As moe_Estructuras.ePEROP
    Dim wl_ePEROP_Fin As New moe_Estructuras.ePEROP

    Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1
    Dim wl_aePLROP1_Grl() As moe_Estructuras.ePLROP1
    Dim wl_ePLROP1_Grl As New moe_Estructuras.ePLROP1
    Dim wl_aePLROP1_Ini() As moe_Estructuras.ePLROP1
    Dim wl_ePLROP1_Ini As New moe_Estructuras.ePLROP1
    Dim wl_aePLROP1_Fin() As moe_Estructuras.ePLROP1
    Dim wl_ePLROP1_Fin As New moe_Estructuras.ePLROP1
    Dim wl_aePELROP1() As moe_Estructuras.ePELROP1

#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
    Dim wl_sCodErrAdi As String
    Dim wl_sCodErrCon As String
    Dim wl_sCodErrOk As String
    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmActPEROD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MsgBox("Error :  frmActPEROD_Load")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdAbrirReg_Click(sender As System.Object, e As System.EventArgs) Handles cmdAbrirReg.Click
        Try
            Dim wl_frmActPERODAbr As New frmActPERODAbr
            wl_frmActPERODAbr.ShowDialog()
        Catch ex As Exception
            MsgBox("Error : cmdAbrirReg_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCerrerReg_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrarReg.Click
        Try
            Dim wl_frmActPERODCer As New frmActPERODCer
            wl_frmActPERODCer.ShowDialog()
        Catch ex As Exception
            MsgBox("Error : cmdCerrerReg_Click")
            MsgBox(ex.Message)
        End Try
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

#End Region

    
    
End Class