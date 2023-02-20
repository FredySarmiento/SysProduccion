Public Class frmASRES
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

    Dim wl_sNomCmp As String
    Dim wl_sDatCmp As String
    Dim wl_sTipCmp As String
    Dim wl_sCmpOrd As String
    Dim wl_sTipOrd As String
    Dim wl_sNomCmp1 As String
    Dim wl_sDatCmp1 As String
    Dim wl_sTipCmp1 As String
    Dim wl_sCmpOrd1 As String
    Dim wl_sTipOrd1 As String
    Dim wl_sCmdSel As String
    Dim wl_sNomTblL As String

    Dim wl_dFecIni As Date
    Dim wl_dFecFin As Date
    Dim wl_dFecIniOdp As Date

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodItm As String
    Dim vl_sEstOdp As String
#End Region
#Region "013 DGV - Variables Locales"
    Dim wl_sCodItmIni As String
    Dim wl_sCodDocIni As String
    Dim wl_nNroDocIni As Long

#End Region
#Region "014 Objetos locales"
    Dim clnATASI As New ClaseNegocios.clnATASI
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
    Dim wl_aeATASI() As moe_Estructuras.eATASI
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
    Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
    Dim wl_aePEODP() As moe_Estructuras.ePEODP
    Dim wl_aePLODP1() As moe_Estructuras.ePLODP1
    Dim wl_aePLODP2() As moe_Estructuras.ePLODP2
    Dim wl_aePLODP3() As moe_Estructuras.ePLODP3
    Dim wl_aePEODP_PLODP4() As moe_Estructuras.ePEODP_PLODP4
    Dim wl_aePEROP() As moe_Estructuras.ePEROP
    Dim wl_aePLROP1() As moe_Estructuras.ePLROP1

    Dim wl_eATASI As New moe_Estructuras.eATASI
    Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
    Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
    Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEODP_PLODP4 As New moe_Estructuras.ePEODP_PLODP4
    Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1
    Dim wl_ePLODP2 As New moe_Estructuras.ePLODP2
    Dim wl_ePLODP3 As New moe_Estructuras.ePLODP3
    Dim wl_ePLODP4 As New moe_Estructuras.ePLODP4
    Dim wl_ePEROP As New moe_Estructuras.ePEROP
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1

#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
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
    Private Sub frmASRES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            dtpFecFin.Value = Date.Today

            Plo_IniciarVar()
            BD_LeeFecIni()
            txtnAnoSdoIniInv.Text = vg_nAnoSdoIniInv
        Catch ex As Exception
            MsgBox("Error :  frmASRES_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
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
            If wl_bEOF = False Then
                moo_aeATASI_DT(wl_aeATASI,
                               wl_DTE1)
                wl_eATASI = wl_aeATASI(0)
                wl_dFecIni = wl_aeATASI(0).dFecIniAno
                txtdFecIniAno.Text = wl_dFecIni
                txtdFecIniOdp.Text = wl_dFecIni
            End If

        Catch ex As Exception
            MsgBox("Error : BD_LeeFecIni")
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
    Private Sub BD_SdoOPPEODP_0(ByVal wl_ePEODP)
        Try
            '  wl_ePEODP = New moe_Estructuras.ePEODP
            wl_bYesNo = True
            '    wl_ePEODP.sCodDoc = "ODP"
            '   wl_ePEODP.nNroDoc = "20009"
            wl_bYesNo = clnPEODP.cnSdoOPPEODP_0(wl_ePEODP)
            wl_bYesNo = True

        Catch ex As Exception
            MsgBox("Error : BD_SdoOPPEODP_0")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"

#End Region
#Region "042 BD Busquedas"


#End Region

#Region "043 BD Cargar"
    Private Sub BD_CargarGEMOV()

        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnIEINV.cndtCargarGEMOV(wl_sNomtbl,
                                                wl_bEOF)
            ReDim wl_aeGEMOV(0)
            wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
            If wl_bEOF = False Then
                moo_aeGEMOV_DT(wl_aeGEMOV,
                               wl_DTE1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarGELMOV1()

        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_sNomtbl = "IEMOV"
            wl_sNomTblL = "ILMOV1"
            wl_eGELMOV1.xsCodItm = wl_eIEDMI.sCodItm
            wl_eGELMOV1.dFecDoc = wl_eATASI.dFecIniAno
            wl_eGELMOV1.dFecVto = dtpFecFin.Value



            wl_DTE1 = clnIEINV.cndtCargarGELMOV1(wl_sNomtbl,
                                                 wl_sNomTblL,
                                                 wl_eGELMOV1,
                                                 wl_bEOF)
            ReDim wl_aeGELMOV1(0)
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            ReDim wl_aeGEMOV(0)
            wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
            If wl_bEOF = False Then
                moo_aeGELMOV1_DT(wl_aeGELMOV1,
                               wl_DTE1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarGEMOV")
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
    Private Sub BD_CargarGLMOV1()
        Try
            wl_bEOF = True
            wl_DTL1 = New DataTable
            '  wl_DTL1 = clnIEINV.cndtConGLMOV1(wl_eGLMOV1,
            '                                   wl_sNomtbl,
            '                                   wl_bEOF)

            wl_DTL1 = clnIEINV.cndtConsultarILMOV1(wl_sNomtbl,
                                                   vl_sCodDoc,
                                                   vl_nNroDoc,
                                                   vl_sCodItm,
                                                   wl_bEOF)



            ReDim wl_aeGLMOV1(0)
            wl_aeGLMOV1(0) = New moe_Estructuras.eGLMOV1
            If wl_bEOF = False Then
                moo_aeGLMOV1_DT(wl_aeGLMOV1,
                                wl_DTL1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarPEODP()

        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable

            wl_DTE1 = clnPEODP.cndtConsultarPEODP(vl_sCodDoc,
                                                  vl_nNroDoc,
                                                  vl_sEstOdp,
                                                  wl_dFecIniOdp,
                                                  wl_bEOF)
            ReDim wl_aePEODP(0)
            wl_aePEODP(0) = New moe_Estructuras.ePEODP
            If wl_bEOF = False Then
                moo_aePEODP_DT(wl_aePEODP,
                               wl_DTE1)
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_CargarPEODP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarPLODP1()

        Try

            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP1(vl_sCodDoc,
                                                   vl_sCodDoc,
                                                   wl_bEOF)
            ReDim wl_aePLODP1(0)
            wl_aePLODP1(0) = New moe_Estructuras.ePLODP1

            If wl_bEOF = False Then
                moo_aePLODP1_DT(wl_aePLODP1,
                               wl_DTE1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarPLODP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarPLODP2()

        Try

            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP2(vl_sCodDoc,
                                                   vl_sCodDoc,
                                                   Nothing,
                                                   wl_bEOF)
            ReDim wl_aePLODP2(0)
            wl_aePLODP2(0) = New moe_Estructuras.ePLODP2

            If wl_bEOF = False Then
                moo_aePLODP2_DT(wl_aePLODP2,
                               wl_DTE1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarPLODP2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarPLODP3()

        Try

            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConsultarPLODP3(vl_sCodDoc,
                                                   vl_sCodDoc,
                                                   wl_bEOF)
            ReDim wl_aePLODP3(0)
            wl_aePLODP3(0) = New moe_Estructuras.ePLODP3


            If wl_bEOF = False Then
                moo_aePLODP3_DT(wl_aePLODP3,
                               wl_DTE1)
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_CargarPLODP3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_CargarPEODP_PLODP4()
        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEODP.cndtConPEODP_PLODP4(wl_ePEODP_PLODP4,
                                                   wl_bEOF)
            ReDim wl_aePEODP_PLODP4(0)
            wl_aePEODP_PLODP4(0) = New moe_Estructuras.ePEODP_PLODP4
            If wl_bEOF = False Then
                moo_aePEODP_PLODP4_DT(wl_aePEODP_PLODP4,
                                      wl_DTE1)
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_CargarPEODP_PLODP4")
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
    Private Sub BD_GEMOV_GELMOV1()
        Try
            ReDim wl_aeGEMOV(0)
            wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
            moo_aeGEMOV_aeGELMOV1(wl_aeGEMOV,
                                    wl_aeGELMOV1)
        Catch ex As Exception
            MsgBox("Error :  BD_CargarGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_GLMOV1_GELMOV1()
        Try
            ReDim wl_aeGLMOV1(0)
            wl_aeGLMOV1(0) = New moe_Estructuras.eGLMOV1
            moo_aeGLMOV1_aeGELMOV1(wl_aeGLMOV1,
                                   wl_aeGELMOV1)
        Catch ex As Exception
            MsgBox("Error :  BD_GLMOV1_GELMOV1")
            MsgBox(ex.Message)
        End Try
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
#End Region
#Region "050 CommandButtons_Click"
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
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
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdIEDMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMI.Click
        Try
            Plo_IniciarVar()

            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_eGELMOV1 = New moe_Estructuras.eGELMOV1


            Dim wl_frmASRES_LeeItm As New frmASRES_LeeItm
            wl_frmASRES_LeeItm.wp_sCoditmIni = ""
            wl_frmASRES_LeeItm.ShowDialog()

            wl_sCodItmIni = wl_frmASRES_LeeItm.wp_sCoditmIni
            wl_eIEDMI.sCodItm = wl_frmASRES_LeeItm.wp_sCoditmIni

            wl_sDesMsgCmd = "Este proceso recalcula los saldos finales. Continua ?"
            wl_sTitMsgCmd = "Recalcular Saldos de Inventarios"
            If wl_sCodItmIni <> "" Then
                wl_eGELMOV1.xsCodItm = wl_sCodItmIni
            End If

            wp_nBoxMsg = 4
            wp_sDesMsg = wl_sDesMsgCmd
            wp_sTitMsg = wl_sTitMsgCmd
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)
            If wp_nResMsg = 6 Then
                Plo_SdoInvIEDMI_0(wl_eIEDMI)
                Plo_SdoIniIEDMI(wl_eATASI)
                Plo_RecSdoIEDMI(wl_eIEDMI)
                wp_nBoxMsg = 0
                wl_sDesMsgCmd = "Proceso completo"
                wl_sTitMsgCmd = "Fin proceso: Recalcular Saldos de Inventarios"
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
            End If




        Catch ex As Exception
            MsgBox("Error :  cmdIEDMI_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdILMOV1_Click(sender As System.Object, e As System.EventArgs) Handles cmdILMOV1.Click
        Try
            Plo_IniciarVar()


            wl_ePLODP4 = New moe_Estructuras.ePLODP4

            Dim wl_frmASRES_LeeOdp As New frmASRES_LeeOdp
            wl_frmASRES_LeeOdp.wp_sCodDocIni = ""
            wl_frmASRES_LeeOdp.wp_nNroDocIni = 0

            wl_frmASRES_LeeOdp.ShowDialog()

            ' REVISAR ESTA LINEA
            ' REVISAR ESTA LINEA
            ' REVISAR ESTA LINEA
            ' REVISAR ESTA LINEA

            wl_sCodItmIni = wl_frmASRES_LeeOdp.wp_sCodDocIni
            wl_eIEDMI.sCodItm = wl_frmASRES_LeeOdp.wp_nNroDocIni

            wl_sDesMsgCmd = "Este proceso actualiza los precios de las EDP. Continua ?"
            wl_sTitMsgCmd = "Actualizar los precios de las EDP"

            wp_nBoxMsg = 4
            wp_sDesMsg = wl_sDesMsgCmd
            wp_sTitMsg = wl_sTitMsgCmd
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)
            If wp_nResMsg = 6 Then

                wl_ePLODP4.sCodDoc = wl_frmASRES_LeeOdp.wp_sCodDocIni
                wl_ePLODP4.nNroDoc = wl_frmASRES_LeeOdp.wp_nNroDocIni


                Plo_ActPreUniEDP(wl_ePLODP4,
                                 wl_dFecIni)
                '                Plo_SdoOPPEODP_0(wl_ePEODP)

                wp_nBoxMsg = 0
                wl_sDesMsgCmd = "Proceso completo"
                wl_sTitMsgCmd = "Fin proceso: Actualizar precios de EDP"
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
            End If


        Catch ex As Exception
            MsgBox("Error :  cmdPEODP_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdPEODP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPEODP.Click
        Try
            Plo_IniciarVar()


            wl_ePEODP = New moe_Estructuras.ePEODP

            Dim wl_frmASRES_LeeOdp As New frmASRES_LeeOdp
            wl_frmASRES_LeeOdp.wp_sCodDocIni = ""
            wl_frmASRES_LeeOdp.wp_nNroDocIni = 0

            wl_frmASRES_LeeOdp.ShowDialog()

            wl_sCodItmIni = wl_frmASRES_LeeOdp.wp_sCodDocIni
            wl_eIEDMI.sCodItm = wl_frmASRES_LeeOdp.wp_nNroDocIni

            wl_sDesMsgCmd = "Este proceso recalcula los saldos de las OP. Continua ?"
            wl_sTitMsgCmd = "Recalcular Saldos de OP"

            wp_nBoxMsg = 4
            wp_sDesMsg = wl_sDesMsgCmd
            wp_sTitMsg = wl_sTitMsgCmd
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)
            If wp_nResMsg = 6 Then
                wl_ePEODP.sCodDoc = wl_frmASRES_LeeOdp.wp_sCodDocIni
                wl_ePEODP.nNroDoc = wl_frmASRES_LeeOdp.wp_nNroDocIni

                wl_ePEODP.dFecIni = txtdFecIniOdp.Text


                Plo_SdoOPPEODP_0(wl_ePEODP)
                Plo_RecSdoPEODP(wl_ePEODP)

                wp_nBoxMsg = 0
                wl_sDesMsgCmd = "Proceso completo"
                wl_sTitMsgCmd = "Fin proceso: Recalcular Saldos de OP"
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
            End If


        Catch ex As Exception
            MsgBox("Error :  cmdPEODP_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmASRES"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_sCodErrAdi = ""
            wl_sCodErrCon = ""
            wl_sCodErrOk = "20-001"
            wl_sDesMsgCmd = ""
            wl_sTitMsgCmd = ""

            wl_dFecIni = Date.Today
            wl_dFecFin = Date.Today
            'dtpFecFin.Value = Date.Today
            dtpFecFin.Format = DateTimePickerFormat.Custom
            dtpFecFin.CustomFormat = "yyyy-MM-dd"


            ' globales
            ' De la BD
            vl_sCodDoc = ""
            vl_nNroDoc = 0
            vl_sEstOdp = ""
            mof_ActivarOK(Me)
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Plo_ActPreUniEDP(ByVal wl_ePLODP4 As Object,
                                 ByVal wl_dFecIni As Date)
        Try
            vl_sCodDoc = ""
            vl_nNroDoc = 0
            vl_sEstOdp = ""

            vl_sCodDoc = wl_ePLODP4.sCodDoc
            vl_nNroDoc = wl_ePLODP4.nNroDoc
            txtsCodDocnNroDoc.Visible = True
            wl_ePEODP_PLODP4 = New moe_Estructuras.ePEODP_PLODP4
            wl_ePEODP_PLODP4.dFecIni = txtdFecIniAno.Text
            wl_ePEODP_PLODP4.sCodDoc = wl_ePLODP4.sCodDoc
            wl_ePEODP_PLODP4.nNroDoc = wl_ePLODP4.nNroDoc

            BD_ILMOV1_PLODP4()

            'BD_CargarPEODP_PLODP4()



            'For wl_nI = 0 To wl_aePEODP_PLODP4.Count - 1
            ' vl_sCodDoc = wl_aePEODP_PLODP4(wl_nI).sCodDoc
            ' vl_nNroDoc = wl_aePEODP_PLODP4(wl_nI).nNroDoc
            ' vl_sCodItm = wl_aePEODP_PLODP4(wl_nI).sCodItm
            '
            '            txtsCodDocnNroDoc.Text = "OP: " & vl_sCodDoc & " " & vl_nNroDoc.ToString & " " & vl_sCodItm.ToString

            'If vl_sCodDoc = "" Then
            ' Continue For
            ' End If
            ' wl_ePLODP4 = New moe_Estructuras.ePLODP4
            ' wl_ePLODP4 = wl_aePEODP_PLODP4(wl_nI)
            ' wl_bYesNo = False
            '
            '            clnIEINV.cnActILMOV1_PLODP4(wl_ePLODP4,
            '                                       wl_bYesNo)
            '            clnIEINV.cnActIEMOV_ILMOV1(wl_ePLODP4,
            '                                       wl_bYesNo)
            '
            '            Next

        Catch ex As Exception
            MsgBox("Error : Plo_RecSdoPEODP")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_RecSdoIEDMI(ByVal wl_eIEDMI)
        Try
            wl_sNomtbl = "IEMOV"
            vl_sCodItm = ""
            If wl_eIEDMI.sCodItm <> "" Then
                vl_sCodItm = wl_eIEDMI.sCodItm
            End If
            txtsCodDocnNroDoc.Visible = True

            BD_CargarGELMOV1()
            BD_GLMOV1_GELMOV1()

            wl_sNomtbl = "ILMOV1"

            '  For wl_nI = 0 To wl_aeGEMOV.Count - 1
            ' vl_sCodDoc = wl_aeGEMOV(wl_nI).sCodDoc
            ' vl_nNroDoc = wl_aeGEMOV(wl_nI).nNroDoc
            ' txtsCodDocnNroDoc.Text = wl_nI.ToString
            ' BD_CargarGLMOV1()
            For wl_nJ = 0 To wl_aeGLMOV1.Count - 1
                txtsCodDocnNroDoc.Text = "Inventarios : " & wl_nJ.ToString
                wl_bYesNo = False
                wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                wl_eGLMOV1 = wl_aeGLMOV1(wl_nJ)
                wl_bYesNo = cnf.cnf_ActSdoInv(wl_eGLMOV1)
                'Next
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_RecSdoIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_RecSdoPEODP(ByVal wl_epeodp As Object)
        Try

            vl_sCodDoc = ""
            vl_nNroDoc = 0
            vl_sEstOdp = ""

            vl_sCodDoc = wl_epeodp.sCodDoc
            vl_nNroDoc = wl_epeodp.nNroDoc
            txtsCodDocnNroDoc.Visible = True
            wl_dFecIniOdp = txtdFecIniOdp.Text

            BD_CargarPEODP()


            For wl_nI = 0 To wl_aePEODP.Count - 1
                vl_sCodDoc = wl_aePEODP(wl_nI).sCodDoc
                vl_nNroDoc = wl_aePEODP(wl_nI).nNroDoc
                txtsCodDocnNroDoc.Text = "OP: " & vl_sCodDoc & " " & vl_nNroDoc.ToString

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
    Private Sub Plo_SdoIniIEDMI(ByVal wl_eATASI As Object)
        Try
            BD_SdoIniIEDMI(wl_eATASI)
        Catch ex As Exception
            MsgBox("Error : Plo_SdoIniIEDMI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_SdoInvIEDMI_0(ByVal wl_eIEDMI As Object)
        Try
            BD_SdoInvIEDMI_0(wl_eIEDMI)
        Catch ex As Exception
            MsgBox("Error : Plo_SdoInvIEDMI_0")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_SdoOPPEODP_0(ByVal wl_ePEODP As Object)
        Try
            BD_SdoOPPEODP_0(wl_ePEODP)
        Catch ex As Exception
            MsgBox("Error : Plo_SdoOPPEODP_0")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "081 Plo Procedimientos del Formulario. Comunes"

#End Region
#Region "082 Plo Eventos locales del Formulario"

    Private Sub dtpFecFin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecFin.ValueChanged
        Try
            '  dtpFecFin.Value = dtpFecFin.Text
            dtpFecFin.Format = DateTimePickerFormat.Custom
            dtpFecFin.CustomFormat = "yyyy-MM-dd"

        Catch ex As Exception
            MsgBox("Error : dtpFecFin_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
   
#End Region

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