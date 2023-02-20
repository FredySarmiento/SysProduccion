Public Class frmPQLIM02
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2015-03-09

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

    Dim wl_sNroALetras As String

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nNroDocFin As Long
    Dim vl_nNroDocIni As Long

    Dim vl_sCodDocFin As String
    Dim vl_sCodDocIni As String
    Dim vl_sEstOdpFin As String
    Dim vl_sEstOdpIni As String
    Dim vl_sCodSerFin As String
    Dim vl_sCodSerIni As String
    Dim vl_sCodItmFin As String
    Dim vl_sCodItmIni As String
    Dim wl_sCodDoc As String
    Dim wl_sCodSer As String
    Dim wl_sEstOdp As String
    Dim wl_nNroDoc As Long
    Dim vl_sCodDoc As String
    Dim wl_sCodItm As String
    Dim vl_sCodStr As String
    Dim vl_sTipMov As String


#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim clnPEODP As New ClaseNegocios.clnPEODP
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim cnf As New ClaseNegocios.clnFunciones


    Dim wl_DTE1 As DataTable
    Dim wl_DTE2 As DataTable
    Dim wl_DTL1 As DataTable
    Dim wl_DTL2 As DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_aeABEOP() As moe_Estructuras.eABEOP
    Dim wl_aeABODP() As moe_Estructuras.eABODP
    Dim wl_aeAPLND1() As moe_Estructuras.eAPLND1
    Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wl_aePELEDM1() As moe_Estructuras.eGELMOV1
    Dim wl_aePELEDP1() As moe_Estructuras.eGELMOV1
    Dim wl_aePELSDM1() As moe_Estructuras.eGELMOV1
    Dim wl_aePEODP() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_Ini() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_Fin() As moe_Estructuras.ePEODP
    Dim wl_aePEODP_QGrl() As moe_Estructuras.ePEODP
    Dim wl_aePELROP1() As moe_Estructuras.ePELROP1

    Dim wl_eABEOP As New moe_Estructuras.eABEOP
    Dim wl_eABODP As New moe_Estructuras.eABODP
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eGELMOV1 As moe_Estructuras.eGELMOV1
    Dim wl_ePELEDM1 As moe_Estructuras.eGELMOV1
    Dim wl_ePELEDP1 As moe_Estructuras.eGELMOV1
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEODP_Ini As New moe_Estructuras.ePEODP
    Dim wl_ePEODP_Fin As New moe_Estructuras.ePEODP
    Dim wl_ePEODP_QGrl As New moe_Estructuras.ePEODP
    Dim wl_ePELROP1 As New moe_Estructuras.ePELROP1
    Dim wl_ePELSDM1 As moe_Estructuras.eGELMOV1

    Dim wp_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wp_aePELEDM1() As moe_Estructuras.eGELMOV1
    Dim wp_aePELEDP1() As moe_Estructuras.eGELMOV1
    Dim wp_aePEODP(0) As moe_Estructuras.ePEODP
    Dim wp_aePLODP1(0) As moe_Estructuras.ePLODP1
    Dim wp_aePLODP2(0) As moe_Estructuras.ePLODP2
    Dim wp_aePLODP3(0) As moe_Estructuras.ePLODP3
    Dim wp_aePLODP4(0) As moe_Estructuras.ePLODP4
    Dim wp_aePLODP5(0) As moe_Estructuras.ePLODP5
    Dim wp_aePELROP1() As moe_Estructuras.ePELROP1
    Dim wp_aePELSDM1() As moe_Estructuras.eGELMOV1

    Dim wp_eGELMOV1 As New moe_Estructuras.eGELMOV1
    Dim wp_ePELEDM1 As New moe_Estructuras.eGELMOV1
    Dim wp_ePELEDP1 As New moe_Estructuras.eGELMOV1
    Dim wp_ePEODP As New moe_Estructuras.ePEODP
    Dim wp_ePLODP1 As New moe_Estructuras.ePLODP1
    Dim wp_ePLODP2 As New moe_Estructuras.ePLODP2
    Dim wp_ePLODP3 As New moe_Estructuras.ePLODP3
    Dim wp_ePLODP4 As New moe_Estructuras.ePLODP4
    Dim wp_ePLODP5 As New moe_Estructuras.ePLODP5
    Dim wp_ePELROP1 As New moe_Estructuras.ePELROP1
    Dim wp_ePELSDM1 As New moe_Estructuras.eGELMOV1


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
    Private Sub frmPQLIM02_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error : frmPEFOM_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmPQLIM02_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()

        Catch ex As Exception
            MsgBox("Error :  frmRPODP01_Load")
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
#Region "040 BD"

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aePLODP1_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wp_aePLODP1(0)
            wp_aePLODP1(0) = New moe_Estructuras.ePLODP1

            moo_aePLODP1_DT(wp_aePLODP1,
                            wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aePLODP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_aePLODP2_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wp_aePLODP2(0)
            wp_aePLODP2(0) = New moe_Estructuras.ePLODP2
            moo_aePLODP2_DT(wp_aePLODP2,
                            wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aePLODP2_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_aePLODP3_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wp_aePLODP3(0)
            wp_aePLODP3(0) = New moe_Estructuras.ePLODP3
            moo_aePLODP3_DT(wp_aePLODP3,
                            wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aePLODP3_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_aePLODP4_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wp_aePLODP4(0) = New moe_Estructuras.ePLODP4
            moo_aePLODP4_DT(wp_aePLODP4,
                           wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aePLODP4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_aePELROP1_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wp_aePELROP1(0)
            wl_aePELROP1(0) = New moe_Estructuras.ePELROP1
            moo_aePELROP1_DT(wl_aePELROP1,
                             wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aePELROP1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BD_aeGELMOV1_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wp_aeGELMOV1(0)
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            moo_aeGELMOV1_DT(wl_aeGELMOV1,
                             wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aeGELMOV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "041 BD Procedimientos sobre la BD. Comunes"

#End Region
#Region "042 BD Busquedas"
    Private Function BD_ConGELMOV1() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnIEINV.cndtConGELMOV1(wl_sNomTblE1,
                                              wl_sNomTblE2,
                                              vl_sCodDoc,
                                              Nothing,
                                              Nothing,
                                              0,
                                              0,
                                              Nothing,
                                              Nothing,
                                              Nothing,
                                              Nothing,
                                              Nothing,
                                              Nothing,
                                              Nothing,
                                              Nothing,
                                              wl_ePEODP.sCodDoc,
                                              wl_ePEODP.nNroDoc,
                                              wr_bEOFE2)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConGELMOV1")
        End Try
        Return wr_bEOFE2

    End Function

    Private Function BD_ConPEODP() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPEODP(wl_ePEODP.sCodDoc,
                                                  wl_ePEODP.nNroDoc,
                                                  wl_ePEODP.sEstOdp,
                                                  Nothing,
                                                  wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPEODP")
        End Try
        Return wr_bEOFE2

    End Function
    Private Function BD_ConPLROP1_DocBas() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEROP.cndtConPLROP1_DocBas(wl_sNomtbl,
                                                    wl_ePEODP.sCodDoc,
                                                    wl_ePEODP.nNroDoc,
                                                    wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPEROP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPLODP1() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP1(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPLODP1")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPLODP2() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP2(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   Nothing,
                                                   wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPLODP2")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPLODP3() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP3(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPLODP3")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_ConPLODP4() As Boolean
        Try
            wr_bEOFE2 = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP4(wl_ePEODP.sCodDoc,
                                                   wl_ePEODP.nNroDoc,
                                                   wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPLODP4")
        End Try
        Return wr_bEOFE2
    End Function

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmABEOP()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eABEOP = New moe_Estructuras.eABEOP
            wl_frmLst.wp_eABEOP = New moe_Estructuras.eABEOP
            wg_sTblCon1 = "ABEOP"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eABEOP.sCodEstODP <> "" Then
                wl_eABEOP = wl_frmLst.wp_eABEOP
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmABEOP")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmABODP()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eABODP = New moe_Estructuras.eABODP
            wl_frmLst.wp_eABODP = New moe_Estructuras.eABODP
            wg_sTblCon1 = "ABODP"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eABODP.sCodDoc <> "" Then
                wl_eABODP = wl_frmLst.wp_eABODP
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmABODP")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmAPLND1()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eAPLND1 = New moe_Estructuras.eAPLND1
            wl_frmLst.wp_eAPLND1 = New moe_Estructuras.eAPLND1
            wl_frmLst.vp_sCodDoc = wl_sCodDoc
            wl_frmLst.vp_sCodSer = ""
            wg_sTblCon1 = "APLND1"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eAPLND1.sCodDoc <> "" Then
                wl_eAPLND1 = wl_frmLst.wp_eAPLND1
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmAPLND1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmPEODP()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_ePEODP = New moe_Estructuras.ePEODP
            wl_frmLst.wp_ePEODP = New moe_Estructuras.ePEODP
            wl_frmLst.vp_sCodDoc = wl_sCodDoc
            wl_frmLst.vp_sEstOdp = ""
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
    Private Sub BD_frmPEODP_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_ePEODP_QGrl = New moe_Estructuras.ePEODP
            wl_frmLst.wp_ePEODP = wl_ePEODP
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wg_sTblCon1 = "PEODP_QGrl"

            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_ePEODP_QGrl.sCodDoc <> "" Then
                wl_ePEODP_QGrl.sCodDoc = wl_frmLst.wp_ePEODP_QGrl.sCodDoc
            End If
            If wl_frmLst.wp_ePEODP_QGrl.nNroDoc <> 0 Then
                wl_ePEODP_QGrl.nNroDoc = wl_frmLst.wp_ePEODP_QGrl.nNroDoc
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_frmPEODP_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmPEODP_QIniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_ePEODP_Ini = New moe_Estructuras.ePEODP
            wl_frmLst.wp_ePEODP_Fin = New moe_Estructuras.ePEODP
            ReDim wl_aePEODP(0)
            ReDim wg_aePEODP(0)
            wl_aePEODP(0) = New moe_Estructuras.ePEODP
            wg_aePEODP(0) = New moe_Estructuras.ePEODP
            wl_ePEODP_Ini.sCodDoc = ""
            wl_ePEODP_Fin.sCodDoc = "Z"
            wl_frmLst.wp_ePEODP_Ini = wl_ePEODP_Ini
            wl_frmLst.wp_ePEODP_Fin = wl_ePEODP_Fin
            wg_sTblCon1 = "PEODP_QIniFin"
            wl_frmLst.ShowDialog()
            If wg_aePEODP.Length <> 0 Then
                If wg_aePEODP(0).sCodDoc <> "" Then
                    wl_aePEODP = wg_aePEODP
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmPEODP_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub


#End Region
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"


#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"
            Plo_VdaVar()
            BD_frmPEODP_QIniFin()
            If wl_aePEODP.Length <> 0 Then
                If wl_aePEODP(0).sCodDoc <> "" Then
                    wl_aePEODP = wg_aePEODP
                    Rpt_PrmRpt()
                End If

            End If

        Catch ex As Exception
            MsgBox("Error : cmdOk_Click")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Try
            mof_fCnfCtrl(Me)
            mof_fLmpCtrl(Me)
            mof_IniciarVar()
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()
            txtsCodDocIni.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdLimpiar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdLstPEODPIni_Click(sender As System.Object, e As System.EventArgs) Handles cmdLstPEODPIni.Click
        Try
            txtsCodDocIni.Text = ""
            txtnNroDocIni.Text = "0"
            cmdOk_Click(Nothing,
                        Nothing)


            

            
        Catch ex As Exception
            MsgBox("Error : cmdLstPEODPIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region



#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"

    Private Sub Plo_IniciarEst()
        Try

            ReDim wl_aeABEOP(0)
            ReDim wl_aeABODP(0)
            ReDim wl_aeAPLND1(0)
            ReDim wl_aePEODP(0)
            ReDim wl_aePEODP_Fin(0)
            ReDim wl_aePEODP_QGrl(0)
            ReDim wl_aePEODP_Ini(0)
            wl_eABEOP = New moe_Estructuras.eABEOP
            wl_eABODP = New moe_Estructuras.eABODP
            wl_eAPLND1 = New moe_Estructuras.eAPLND1
            wl_ePEODP = New moe_Estructuras.ePEODP
            wl_ePEODP_Ini = New moe_Estructuras.ePEODP
            wl_ePEODP_QGrl = New moe_Estructuras.ePEODP
            wl_ePEODP_Fin = New moe_Estructuras.ePEODP
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmRPODP01"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try

            wl_bYesNo = False

            wl_sCodErrAdi = "10-319"
            wl_sCodErrCon = "10-119"
            wl_sCodErrOk = "20-001"
            '       wl_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
            '       wl_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wl_sCmpTSB = "sCodItm"
            wl_sDatTSB = ""
            wl_sCodDoc = ""
            wl_sCodSer = ""
            wl_nNroDoc = 0
            wl_sEstOdp = ""
            wl_sCodItm = ""
            vl_sCodStr = ""



        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Plo_VdaVar()
        Try
            wl_ePEODP_Ini.sCodDoc = txtsCodDocIni.Text
            wl_ePEODP_Ini.nNroDoc = CDbl(txtnNroDocIni.Text)
            If txtsCodDocIni.Text <> " " Then
                wl_ePEODP_Fin.sCodDoc = txtsCodDocIni.Text
            End If

            If txtnNroDocIni.Text <> "" Then
                wl_ePEODP_Fin.nNroDoc = CDbl(txtnNroDocIni.Text)
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"

#End Region
#Region "082 Elo Eventos locales del Formulario"
   
    Private Sub txtnNroDocIni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnNroDocIni.LostFocus
        Try
            If txtnNroDocIni.Text = "" Then
                txtnNroDocIni.Text = "0"
            End If
            wl_ePEODP_Ini.nNroDoc = CDbl(txtnNroDocIni.Text)
        Catch ex As Exception
            MsgBox("Error : txtnNroDocIni_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
  
    Private Sub txtsCodDocIni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodDocIni.LostFocus
        Try
            wl_ePEODP_Ini.sCodDoc = txtsCodDocIni.Text
        Catch ex As Exception
            MsgBox("Error : txtsCodDocIni_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
 
#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            Dim wl_bSDM_EDM As Boolean
            wl_bSDM_EDM = False


            For wl_i = 0 To wl_aePEODP.Count - 1
                If wl_aePEODP.Length <> 0 Then
                    If wl_aePEODP(wl_i) Is Nothing Then
                        Exit For
                    End If
                End If

                ReDim wl_aePELEDM1(0)
                ReDim wl_aePELEDP1(0)
                ReDim wl_aePELSDM1(0)
                ReDim wl_aePELROP1(0)
                ReDim wp_aePEODP(0)
                ReDim wp_aePLODP1(0)
                ReDim wp_aePLODP2(0)
                ReDim wp_aePLODP3(0)
                ReDim wp_aePLODP4(0)

                ReDim wp_aePELEDM1(0)
                ReDim wp_aePELEDP1(0)
                ReDim wp_aePELSDM1(0)
                ReDim wp_aePELROP1(0)

                wl_aePELEDM1(0) = New moe_Estructuras.eGELMOV1
                wl_aePELEDP1(0) = New moe_Estructuras.eGELMOV1
                wl_aePELSDM1(0) = New moe_Estructuras.eGELMOV1
                wl_aePELROP1(0) = New moe_Estructuras.ePELROP1
                wp_aePELEDM1(0) = New moe_Estructuras.eGELMOV1
                wp_aePELEDP1(0) = New moe_Estructuras.eGELMOV1
                wp_aePELSDM1(0) = New moe_Estructuras.eGELMOV1
                wp_aePELROP1(0) = New moe_Estructuras.ePELROP1

                wp_aePEODP(0) = wl_aePEODP(wl_i)
                wl_ePEODP = New moe_Estructuras.ePEODP
                wl_ePEODP = wl_aePEODP(wl_i)
                BD_ConPLODP1()
                BD_aePLODP1_DT(wl_DTE1)
                BD_ConPLODP2()
                BD_aePLODP2_DT(wl_DTE1)
                BD_ConPLODP3()
                BD_aePLODP3_DT(wl_DTE1)
                BD_ConPLODP4()
                BD_aePLODP4_DT(wl_DTE1)

                wl_sNomTblE1 = "IEMOV"
                wl_sNomTblE2 = "ILMOV1"
                vl_sCodDoc = "EDP"
                ReDim wl_aeGELMOV1(0)
                wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
                wp_aePELEDP1(0) = New moe_Estructuras.eGELMOV1
                BD_ConGELMOV1()
                BD_aeGELMOV1_DT(wl_DTE1)
                If wl_aeGELMOV1.Length <> 0 Then
                    If wl_aeGELMOV1(0).sCodDoc <> "" Then
                        wp_aePELEDP1 = wl_aeGELMOV1
                    End If
                End If

                vl_sCodDoc = "EDM"
                ReDim wl_aeGELMOV1(0)
                wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
                wp_aePELEDM1(0) = New moe_Estructuras.eGELMOV1
                BD_ConGELMOV1()
                BD_aeGELMOV1_DT(wl_DTE1)
                If wl_aeGELMOV1.Length <> 0 Then
                    If wl_aeGELMOV1(0).sCodDoc <> "" Then
                        wl_bSDM_EDM = True
                        wp_aePELEDM1 = wl_aeGELMOV1
                    End If
                End If

                vl_sCodDoc = "SDM"
                ReDim wl_aeGELMOV1(0)
                wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
                wp_aePELSDM1(0) = New moe_Estructuras.eGELMOV1
                BD_ConGELMOV1()
                BD_aeGELMOV1_DT(wl_DTE1)
                If wl_aeGELMOV1.Length <> 0 Then
                    If wl_aeGELMOV1(0).sCodDoc <> "" Then
                        wl_bSDM_EDM = True
                        wp_aePELSDM1 = wl_aeGELMOV1
                    End If
                End If

               
                BD_ConPLROP1_DocBas()
                BD_aePELROP1_DT(wl_DTE1)
                If wl_aePELROP1.Length <> 0 Then
                    If wl_aePELROP1(0).sCodDoc <> "" Then
                        wp_aePELROP1 = wl_aePELROP1
                    End If
                End If

                wl_sNroALetras = mof_NroALetras(CType(wp_ePLODP4.nVrcCosTot, String),
                                                      wg_sCodMon)



                Dim wl_frmRPT01 As New rptPQLIM02
                wl_frmRPT01.wp_aePEODP = wp_aePEODP
                wl_frmRPT01.wp_aePELEDM1 = wp_aePELEDM1
                wl_frmRPT01.wp_aePELEDP1 = wp_aePELEDP1
                wl_frmRPT01.wp_aePLODP1 = wp_aePLODP1
                wl_frmRPT01.wp_aePLODP2 = wp_aePLODP2
                wl_frmRPT01.wp_aePLODP3 = wp_aePLODP3
                wl_frmRPT01.wp_aePLODP4 = wp_aePLODP4
                wl_frmRPT01.wp_aePELROP1 = wp_aePELROP1
                wl_frmRPT01.wp_aePELSDM1 = wp_aePELSDM1
                wl_frmRPT01.wp_sNroALetras = wl_sNroALetras
                wl_frmRPT01.Show()

            Next



        Catch ex As Exception
            MsgBox("Error :  Rpt_PrmRpt")
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