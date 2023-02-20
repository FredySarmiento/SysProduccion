Public Class frmRIDMI04
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
    Dim wl_bImpItmCero As Boolean


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
    Dim wl_dFecDocFin As Date
    Dim wl_sNomTblL As String

    Dim wl_dFecIni As Date
    Dim wl_dFecFin As Date

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
    Dim vl_nNroDoc As Long
    Dim vl_sCodItm As String
    Dim wl_sCodItm As String
    Dim vl_sCodStr As String
    Dim vl_sTipMov As String
    Dim wl_sCodAlm As String
    Dim wl_sCodGrp As String


    Dim vl_bItmAct As Boolean


#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnATASI As New ClaseNegocios.clnATASI
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnIEINV As New ClaseNegocios.clnIEINV

    Dim cnf As New ClaseNegocios.clnFunciones
    Dim wl_DTE1 As DataTable
    Dim wl_DTE2 As DataTable
    Dim wl_DTL1 As DataTable
    Dim wl_DTL2 As DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_aeATALM() As moe_Estructuras.eATALM
    Dim wl_aeATASI() As moe_Estructuras.eATASI
    Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
    Dim wl_aeILDMI1() As moe_Estructuras.eILDMI1
    Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
    Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wl_aeQConSdoFin() As moe_Estructuras.eQConSdoFin

    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATASI As New moe_Estructuras.eATASI
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eILDMI1 As New moe_Estructuras.eILDMI1
    Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
    Dim wl_eIEDMI_Ini As New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_Fin As New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_QGrl As New moe_Estructuras.eIEDMI
    Dim wl_eGELMOV1 As moe_Estructuras.eGELMOV1
    Dim wl_eGEMOV As moe_Estructuras.eGEMOV
    Dim wl_eGLMOV1 As moe_Estructuras.eGLMOV1
    Dim wl_eQConSdoFin As New moe_Estructuras.eQConSdoFin


    Dim wl_eGELMOV1_Fin As New moe_Estructuras.eGELMOV1

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
    Private Sub frmRIDMI04_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()
            BD_LeeFecIni()

        Catch ex As Exception
            MsgBox("Error :  frmRIDMI04_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "040 BD"

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aeIEDMI_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeIEDMI(0)
            wl_aeIEDMI(0) = New moe_Estructuras.eIEDMI

            moo_aeIEDMI_DT(wl_aeIEDMI,
                            wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aeIEDMI_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_aeILDMI1_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeILDMI1(0)
            wl_aeILDMI1(0) = New moe_Estructuras.eILDMI1
            '   moo_aeILDMI1_DT(wl_aeILDMI1,
            '                  wp_DTE1)
        Catch ex As Exception
            MsgBox("Error :  BD_aeILDMI1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_ConSdoFin(ByVal wl_eIEDMI As Object)
        Try
            wl_sNomtbl = "TmpIEDMI"
           
            wl_bYesNo = True
            wl_DTE2 = New DataTable
            wl_DTE2 = clnIEDMI.cndtConSdoFin(wl_eIEDMI_Ini,
                                             wl_eIEDMI_Fin,
                                             vl_bItmAct,
                                             wl_bImpItmCero,
                                             wl_dFecIni,
                                             wl_dFecFin,
                                             wl_eATASI,
                                             wr_bEOF)

            If wr_bEOF = False Then
                wl_eQConSdoFin = New moe_Estructuras.eQConSdoFin
                ' wl_aeQConSdoFin(0) = New moe_Estructuras.eQConSdoFin
                moo_aeQConSdoFin_DT(wl_aeQConSdoFin,
                                    wl_DTE2)
            End If

            wl_bYesNo = True

        Catch ex As Exception
            MsgBox("Error : BD_ConSdoIni")
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
            If wl_bEOF = False Then
                moo_aeATASI_DT(wl_aeATASI,
                               wl_DTE1)
                wl_eATASI = wl_aeATASI(0)
                wl_dFecIni = wl_aeATASI(0).dFecIniAno
                dtpFecDocIni.Text = wl_dFecIni
            End If

        Catch ex As Exception
            MsgBox("Error : BD_LeeFecIni")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "041 BD Procedimientos sobre la BD. Comunes"

#End Region
#Region "042 BD Busquedas"

#End Region
#Region "043 BD Cargar"
    Private Sub BD_CargarGEMOV(wp_dFecDocFin)

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
    Private Sub BD_CargarGELMOV1()

        Try
            wl_bEOF = True
            wl_DTE1 = New DataTable
            wl_sNomtbl = "IEMOV"
            wl_sNomTblL = "ILMOV1"
            wl_eGELMOV1.xsCodItm = wl_eIEDMI.sCodItm
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
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmIEDMI_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eIEDMI_QGrl = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = wl_eIEDMI
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wg_sTblCon1 = "IEDMI_QGrl"

            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI_QGrl.sCodAlm <> "" Then
                wl_eIEDMI_QGrl.sCodAlm = wl_frmLst.wp_eIEDMI_QGrl.sCodAlm
            End If
            If wl_frmLst.wp_eIEDMI_QGrl.sCodItm <> "" Then
                wl_eIEDMI_QGrl.sCodItm = wl_frmLst.wp_eIEDMI_QGrl.sCodItm
            End If
            If wl_frmLst.wp_eIEDMI_QGrl.sCodGrp <> "" Then
                wl_eIEDMI_QGrl.sCodGrp = wl_frmLst.wp_eIEDMI_QGrl.sCodGrp
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMI_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmIEDMI_QIniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eIEDMI_Ini = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI_Fin = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_bImpItmInac = chbbImpItmInac.Checked
            wl_frmLst.wp_bImpItmCero = chbbImpItmCero.Checked
            wl_frmLst.wp_sNomTblTmp = "TmpIEDMI"
            wl_frmLst.wp_dFecDocFin = dtpFecDocFin.Text


            ReDim wl_aeIEDMI(0)
            ReDim wg_aeIEDMI(0)
            wl_aeIEDMI(0) = New moe_Estructuras.eIEDMI
            wg_aeIEDMI(0) = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI_Ini = wl_eIEDMI_Ini
            wl_frmLst.wp_eIEDMI_Fin = wl_eIEDMI_Fin
            wg_sTblCon1 = "IEDMI_QIniFin"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeIEDMI) Then
                If wg_aeIEDMI.Length > 0 Then
                    If wg_aeIEDMI(0).sCodItm <> "" Then
                        wl_aeIEDMI = wg_aeIEDMI
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMI_QIniFin")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmIELDMI1_QIniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eIEDMI_Ini = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI_Fin = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_bImpItmInac = chbbImpItmInac.Checked
            wl_frmLst.wp_bImpItmCero = chbbImpItmCero.Checked

            ReDim wl_aeIEDMI(0)
            ReDim wg_aeIEDMI(0)
            wl_aeIEDMI(0) = New moe_Estructuras.eIEDMI
            wg_aeIEDMI(0) = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI_Ini = wl_eIEDMI_Ini
            wl_frmLst.wp_eIEDMI_Fin = wl_eIEDMI_Fin
            wg_sTblCon1 = "IELDMI1_QIniFin"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeIELDMI1) Then
                If wg_aeIELDMI1.Length > 0 Then
                    If wg_aeIELDMI1(0).eIEDMI.sCodItm <> "" Then
                        wl_aeIELDMI1 = wg_aeIELDMI1
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIELDMI_QIniFin")
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
            '20180823 - Lee fecha inicial del informe

            Plo_ConSdoFin(wl_eIEDMI)

            If Not IsNothing(wl_aeQConSdoFin) Then
                If wl_aeQConSdoFin.Length <> 0 Then
                    If wl_aeQConSdoFin(0).sCodItm <> "" Then
                        '  wl_aeIEDMI = wg_aeIEDMI
                        Rpt_PrmRpt()
                    End If

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
            txtsCodItmIni.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdLimpiar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdIEDMI_QAlmFin_Click(sender As System.Object, e As System.EventArgs) Handles cmdIEDMI_QAlmFin.Click
        Try
            wl_eIEDMI = wl_eIEDMI_Fin
            wl_eIEDMI.sCodAlm = " "
            vl_sCodStr = "EIEDMI_QALM"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodAlm <> "" Then
                txtsCodAlmFin.Text = wl_eIEDMI_QGrl.sCodAlm
                wl_sCodAlm = wl_eIEDMI_QGrl.sCodAlm
                wl_eIEDMI_Fin.sCodAlm = wl_eIEDMI_QGrl.sCodAlm
                wl_eIEDMI.sCodAlm = wl_eIEDMI_QGrl.sCodAlm
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMI_QAlmFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdIEDMI_QAlmIni_Click(sender As System.Object, e As System.EventArgs) Handles cmdIEDMI_QAlmIni.Click
        Try
            wl_eIEDMI = wl_eIEDMI_Ini
            wl_eIEDMI.sCodAlm = " "
            vl_sCodStr = "EIEDMI_QALM"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodAlm <> "" Then
                txtsCodAlmIni.Text = wl_eIEDMI_QGrl.sCodAlm
                wl_sCodAlm = wl_eIEDMI_QGrl.sCodAlm
                wl_eIEDMI_Ini.sCodAlm = wl_eIEDMI_QGrl.sCodAlm
                wl_eIEDMI.sCodAlm = wl_eIEDMI_QGrl.sCodAlm
                cmdIEDMI_QAlmFin.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMI_QGrpIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdIEDMI_QGrpFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMI_QGrpFin.Click
        Try
            wl_eIEDMI = wl_eIEDMI_Fin
            wl_eIEDMI.sCodGrp = " "
            vl_sCodStr = "EIEDMI_QGRP"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodGrp <> "" Then
                txtsCodGrpFin.Text = wl_eIEDMI_QGrl.sCodGrp
                wl_sCodGrp = wl_eIEDMI_QGrl.sCodGrp
                wl_eIEDMI_Fin.sCodGrp = wl_eIEDMI_QGrl.sCodGrp
                wl_eIEDMI.sCodGrp = wl_eIEDMI_QGrl.sCodGrp
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMI_QGrpFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdIEDMI_QGrpIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMI_QGrpIni.Click
        Try
            wl_eIEDMI = wl_eIEDMI_Ini
            wl_eIEDMI.sCodGrp = " "
            vl_sCodStr = "EIEDMI_QGRP"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodGrp <> "" Then
                txtsCodGrpIni.Text = wl_eIEDMI_QGrl.sCodGrp
                wl_sCodGrp = wl_eIEDMI_QGrl.sCodGrp
                wl_eIEDMI_Ini.sCodGrp = wl_eIEDMI_QGrl.sCodGrp
                wl_eIEDMI.sCodGrp = wl_eIEDMI_QGrl.sCodGrp
                cmdIEDMI_QGrpFin.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMI_QGrpIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdIEDMI_QItmFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMI_QItmFin.Click
        Try
            wl_eIEDMI = wl_eIEDMI_Fin
            wl_eIEDMI.sCodItm = " "
            vl_sCodStr = "EIEDMI_QITM"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodItm <> "" Then
                txtsCodItmFin.Text = wl_eIEDMI_QGrl.sCodItm
                wl_sCodItm = wl_eIEDMI_QGrl.sCodItm
                wl_eIEDMI_Fin.sCodItm = wl_eIEDMI_QGrl.sCodItm
                wl_eIEDMI.sCodItm = wl_eIEDMI_QGrl.sCodItm
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMI_QItmFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdIEDMI_QItmIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMI_QItmIni.Click
        Try
            wl_eIEDMI = wl_eIEDMI_Ini
            wl_eIEDMI.sCodItm = " "
            vl_sCodStr = "EIEDMI_QITM"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodItm <> "" Then
                txtsCodItmIni.Text = wl_eIEDMI_QGrl.sCodItm
                wl_sCodItm = wl_eIEDMI_QGrl.sCodItm
                wl_eIEDMI_Ini.sCodItm = wl_eIEDMI_QGrl.sCodItm
                wl_eIEDMI.sCodItm = wl_eIEDMI_QGrl.sCodItm
                cmdIEDMI_QItmFin.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMI_QItmIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeIEDMI(0)
            ReDim wl_aeILDMI1(0)
            ReDim wl_aeATALM(0)
            wl_eATALM = New moe_Estructuras.eATALM
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_eIEDMI_Ini = New moe_Estructuras.eIEDMI
            wl_eIEDMI_Fin = New moe_Estructuras.eIEDMI
            wl_eILDMI1 = New moe_Estructuras.eILDMI1
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmRIDMI03"
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

            If txtsCodItmFin.Text = "" Then
                txtsCodItmFin.Text = txtsCodItmIni.Text
                wl_eIEDMI_Fin.sCodItm = txtsCodItmFin.Text
            End If
            If txtsCodItmIni.Text = "" Then
                txtsCodItmIni.Text = txtsCodItmFin.Text
                wl_eIEDMI_Ini.sCodItm = txtsCodItmIni.Text
            End If

            If txtsCodGrpFin.Text = "" Then
                txtsCodGrpFin.Text = txtsCodGrpIni.Text
                wl_eIEDMI_Fin.sCodGrp = txtsCodGrpFin.Text
            End If
            If txtsCodGrpIni.Text = "" Then
                txtsCodGrpIni.Text = txtsCodGrpFin.Text
                wl_eIEDMI_Ini.sCodGrp = txtsCodGrpIni.Text
            End If


            wl_eIEDMI_Fin.sCodItm = txtsCodItmFin.Text
            wl_eIEDMI_Ini.sCodItm = txtsCodItmIni.Text
            wl_eIEDMI_Fin.sCodGrp = txtsCodGrpFin.Text
            wl_eIEDMI_Ini.sCodGrp = txtsCodGrpIni.Text
            wl_dFecFin = dtpFecDocFin.Text

        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ConSdoFin(ByVal wl_eIEDMI As Object)
        Try
            BD_ConSdoFin(wl_eIEDMI)
        Catch ex As Exception
            MsgBox("Error : Plo_SdoInvIEDMI_0")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Plo_RecSdoIEDMI(ByVal wl_eIEDMI As Object,
                                ByVal wp_dFecDocFin As Date)
        Try
            wl_sNomtbl = "IEMOV"
            If wl_eIEDMI.sCodItm = "" Then
                BD_CargarGEMOV(wp_dFecDocFin)
            Else
                BD_CargarGELMOV1()
                BD_GEMOV_GELMOV1()
            End If
            For wl_nI = 0 To wl_aeGEMOV.Count - 1
                wl_eGLMOV1.sCodDoc = wl_aeGEMOV(wl_nI).sCodDoc
                wl_eGLMOV1.nNroDoc = wl_aeGEMOV(wl_nI).nNroDoc
                vl_sCodDoc = wl_aeGEMOV(wl_nI).sCodDoc
                vl_nNroDoc = wl_aeGEMOV(wl_nI).nNroDoc
                vl_sCodItm = ""

                If wl_eIEDMI.sCodItm <> "" Then
                    vl_sCodItm = wl_eIEDMI.sCodItm
                End If
                wl_sNomtbl = "ILMOV1"
                BD_CargarGLMOV1()
                For wl_nJ = 0 To wl_aeGLMOV1.Count - 1
                    wl_bYesNo = False
                    wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                    wl_eGLMOV1 = wl_aeGLMOV1(wl_nJ)
                    wl_bYesNo = cnf.cnf_ActSdoInv(wl_eGLMOV1)
                Next
            Next
        Catch ex As Exception
            MsgBox("Error : Plo_RecSdoIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"

#End Region

#Region "082 Elo Eventos locales del Formulario"

    Private Sub dtpFecDocFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecDocFin.ValueChanged
        Try
            wl_dFecDocFin = dtpFecDocFin.Value.ToShortDateString
            wl_eGELMOV1_Fin.dFecDoc = dtpFecDocFin.Value.ToShortDateString
        Catch ex As Exception
            MsgBox("Error :  dtpFecDocFin_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try

            '     Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            '     ReDim wl_aeIEDMI(0)
            Dim wl_bSDM_EDM As Boolean
            wl_bSDM_EDM = False
            If wl_aeQConSdoFin(0).sCodItm <> "" Then
                Dim wl_frmRPT01 As New rptRIDMI04
                wl_frmRPT01.wp_aeQConSdoFin = wl_aeQConSdoFin
                wl_frmRPT01.wp_dFecInv = wl_dFecFin
                wl_frmRPT01.Show()
            End If
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