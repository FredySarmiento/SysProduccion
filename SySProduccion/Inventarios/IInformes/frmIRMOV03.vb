Public Class frmIRMOV03
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

    Dim wl_sCodAlm As String
    Dim wl_sCodGrp As String



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
    Dim wl_aeATALM() As moe_Estructuras.eATALM
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_aeAPEND() As moe_Estructuras.eAPEND
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_aeAPLND1() As moe_Estructuras.eAPLND1
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_aeATTIN() As moe_Estructuras.eATTIN
    Dim wl_eATTIN As New moe_Estructuras.eATTIN
    Dim wl_aeGELMOV1() As moe_Estructuras.eGELMOV1
    Dim wl_eGELMOV1 As New moe_Estructuras.eGELMOV1
    Dim wl_aeGELMOV1_Grl() As moe_Estructuras.eGELMOV1
    Dim wl_eGELMOV1_Grl As New moe_Estructuras.eGELMOV1
    Dim wl_aeGELMOV1_Ini() As moe_Estructuras.eGELMOV1
    Dim wl_eGELMOV1_Ini As New moe_Estructuras.eGELMOV1
    Dim wl_aeGELMOV1_Fin() As moe_Estructuras.eGELMOV1
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


    Private Sub frmRIMOV03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()
        Catch ex As Exception
            MsgBox("Error :  frmRIMOV03_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aeGELMOV1_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeGELMOV1(0)
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1

            '   moo_aeGELMOV1_DT(wl_aeGELMOV1,
            '                   wp_DTE1,
            '                   wl_dFecDocIni,
            '                   wl_dFecDocFin,
            '                   Nothing)
        Catch ex As Exception
            MsgBox("Error :  BD_aeGELMOV1_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Private Sub BD_frmGELMOV1_QIniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eGELMOV1_Ini = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1_Fin = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1 = New moe_Estructuras.eGELMOV1

            wl_frmLst.wp_bVdaCanMin = False

            ReDim wl_aeGELMOV1(0)
            ReDim wg_aeGELMOV1(0)
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            wg_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1_Ini = wl_eGELMOV1_Ini
            wl_frmLst.wp_eGELMOV1_Fin = wl_eGELMOV1_Fin
            wg_sTblCon1 = "GELMOV1_QIniFin"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeIELDMI1) Then
                If wg_aeGELMOV1.Length > 0 Then
                    If wg_aeGELMOV1(0).xsCodItm <> "" Then
                        wl_aeGELMOV1 = wg_aeGELMOV1
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIELDMI_QIniFin")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmGELMOV1_QGrl()
        Try
         
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eGELMOV1_Grl = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1 = wl_eGELMOV1
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wl_frmLst.wp_sMayMenIgu = wl_sMayMenIgu
            wl_frmLst.wp_sTlbMov = "IEMOV"
            wg_sTblCon1 = "GELMOV1_Grl"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eGELMOV1_Grl.sTipMov <> "" Then
                wl_eGELMOV1_Grl.sTipMov = wl_frmLst.wp_eGELMOV1_Grl.sTipMov
            End If
            If wl_frmLst.wp_eGELMOV1_Grl.sCodDoc <> "" Then
                wl_eGELMOV1_Grl.sCodDoc = wl_frmLst.wp_eGELMOV1_Grl.sCodDoc
            End If
            If wl_frmLst.wp_eGELMOV1_Grl.nNroDoc <> 0 Then
                wl_eGELMOV1_Grl.nNroDoc = wl_frmLst.wp_eGELMOV1_Grl.nNroDoc
            End If
            If wl_frmLst.wp_eGELMOV1_Grl.sCodSer <> "" Then
                wl_eGELMOV1_Grl.sCodSer = wl_frmLst.wp_eGELMOV1_Grl.sCodSer
            End If
            If wl_frmLst.wp_eGELMOV1_Grl.sCodTra <> "" Then
                wl_eGELMOV1_Grl.sCodTra = wl_frmLst.wp_eGELMOV1_Grl.sCodTra
            End If
            If wl_frmLst.wp_eGELMOV1_Grl.xsCodItm <> "" Then
                wl_eGELMOV1_Grl.xsCodItm = wl_frmLst.wp_eGELMOV1_Grl.xsCodItm
            End If


        Catch ex As Exception
            MsgBox("Error :  BD_frmGELMOV1_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmGELMOV1_IniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eGELMOV1_Ini = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1_Fin = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1 = New moe_Estructuras.eGELMOV1
            ReDim wl_aeGELMOV1(0)
            ReDim wg_aeGELMOV1(0)
            wl_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            wg_aeGELMOV1(0) = New moe_Estructuras.eGELMOV1
            wl_frmLst.wp_eGELMOV1_Ini = wl_eGELMOV1_Ini
            wl_frmLst.wp_eGELMOV1_Fin = wl_eGELMOV1_Fin
            wl_frmLst.vp_sCodStr = "EGELMOV1"
            wl_frmLst.wp_sTlbMov = "IEMOV"
            wg_sTblCon1 = "GELMOV1_IniFin"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeGELMOV1) Then
                If wg_aeGELMOV1.Length > 0 Then
                    If wg_aeGELMOV1(0).sCodDoc <> "" Then
                        wl_aeGELMOV1 = wg_aeGELMOV1
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmGELMOV1_IniFin")
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
            BD_frmGELMOV1_IniFin()
            If Not IsNothing(wl_aeGELMOV1) Then
                If wl_aeGELMOV1.Length <> 0 Then
                    If wl_aeGELMOV1(0).sCodDoc <> "" Then
                        wl_aeGELMOV1 = wg_aeGELMOV1
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
            txtsTipMov.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdLimpiar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"

    Private Sub cmdAPENDFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDFin.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Fin
            wl_eGELMOV1.sCodDoc = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGELMOV1_QCODDOC"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sCodDoc <> "" Then
                txtsCodDocFin.Text = wl_eGELMOV1_Grl.sCodDoc
                vl_sCodDoc = wl_eGELMOV1_Grl.sCodDoc
                wl_eGELMOV1_Fin.sCodDoc = wl_eGELMOV1_Grl.sCodDoc
                wl_eGELMOV1.sCodDoc = wl_eGELMOV1_Grl.sCodDoc
                cmdAPENDSerI.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdAPENDIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDIni.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Ini
            wl_eGELMOV1.sCodDoc = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGELMOV1_QCODDOC"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sCodDoc <> "" Then
                txtsCodDocIni.Text = wl_eGELMOV1_Grl.sCodDoc
                vl_sCodDoc = wl_eGELMOV1_Grl.sCodDoc
                wl_eGELMOV1_Ini.sCodDoc = wl_eGELMOV1_Grl.sCodDoc
                wl_eGELMOV1.sCodDoc = wl_eGELMOV1_Grl.sCodDoc
                cmdAPENDFin.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDIni_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdAPENDSerF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDSerF.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Fin
            wl_eGELMOV1.sCodSer = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGELMOV1_QCODSER"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sCodSer <> "" Then
                txtsCodSerFin.Text = wl_eGELMOV1_Grl.sCodSer
                vl_sCodSer = wl_eGELMOV1_Grl.sCodSer
                wl_eGELMOV1_Fin.sCodSer = wl_eGELMOV1_Grl.sCodSer
                wl_eGELMOV1.sCodSer = wl_eGELMOV1_Grl.sCodSer
                cmdIEMOVIni.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDSerI_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdAPENDSerI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDSerI.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Ini
            wl_eGELMOV1.sCodSer = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGELMOV1_QCODSER"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sCodSer <> "" Then
                txtsCodSerIni.Text = wl_eGELMOV1_Grl.sCodSer
                vl_sCodSer = wl_eGELMOV1_Grl.sCodSer
                wl_eGELMOV1_Ini.sCodSer = wl_eGELMOV1_Grl.sCodSer
                wl_eGELMOV1.sCodSer = wl_eGELMOV1_Grl.sCodSer
                cmdAPENDSerF.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDSerI_Click")
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cmdIEMOVFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEMOVFin.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Fin
            wl_eGELMOV1.nNroDoc = -1
            vl_sCodStr = "EGELMOV1_QNRODOC"
            wl_sMayMenIgu = "Men"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.nNroDoc <> 0 Then
                txtnNroDocFin.Text = wl_eGELMOV1_Grl.nNroDoc
                vl_nNroDoc = wl_eGELMOV1_Grl.nNroDoc
                wl_eGELMOV1_Fin.nNroDoc = wl_eGELMOV1_Grl.nNroDoc
                wl_eGELMOV1.nNroDoc = wl_eGELMOV1_Grl.nNroDoc
                cmdATTINIni.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdIEMOVFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdIEMOVIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEMOVIni.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Ini
            wl_eGELMOV1.nNroDoc = -1
            vl_sCodStr = "EGELMOV1_QNRODOC"
            wl_sMayMenIgu = "May"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.nNroDoc <> 0 Then
                txtnNroDocIni.Text = wl_eGELMOV1_Grl.nNroDoc
                vl_nNroDoc = wl_eGELMOV1_Grl.nNroDoc
                wl_eGELMOV1_Ini.nNroDoc = wl_eGELMOV1_Grl.nNroDoc
                wl_eGELMOV1.nNroDoc = wl_eGELMOV1_Grl.nNroDoc
                cmdIEMOVFin.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdIEMOVIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTipMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTipMov.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Ini
            wl_eGELMOV1.sTipMov = " "
            vl_sCodStr = "EGELMOV1_QTIPMOV"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sTipMov <> "" Then
                txtsTipMov.Text = wl_eGELMOV1_Grl.sTipMov
                vl_sTipMov = wl_eGELMOV1_Grl.sTipMov
                wl_eGELMOV1_Ini.sTipMov = wl_eGELMOV1_Grl.sTipMov
                wl_eGELMOV1_Fin.sTipMov = wl_eGELMOV1_Grl.sTipMov
                wl_eGELMOV1.sTipMov = wl_eGELMOV1_Grl.sTipMov
                cmdAPENDIni.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdTipMov_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdATTINFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdATTINFin.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Fin
            wl_eGELMOV1.sCodTra = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGELMOV1_QCODTRA"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sCodTra <> "" Then
                txtsCodTraFin.Text = wl_eGELMOV1_Grl.sCodTra
                vl_sCodTra = wl_eGELMOV1_Grl.sCodTra
                wl_eGELMOV1_Fin.sCodTra = wl_eGELMOV1_Grl.sCodTra
                wl_eGELMOV1.sCodTra = wl_eGELMOV1_Grl.sCodTra
                cmdOk.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdATTINIni_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdATTINIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdATTINIni.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Ini
            wl_eGELMOV1.sCodTra = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGELMOV1_QCODTRA"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.sCodTra <> "" Then
                txtsCodTraIni.Text = wl_eGELMOV1_Grl.sCodTra
                vl_sCodTra = wl_eGELMOV1_Grl.sCodTra
                wl_eGELMOV1_Ini.sCodTra = wl_eGELMOV1_Grl.sCodTra
                wl_eGELMOV1.sCodTra = wl_eGELMOV1_Grl.sCodTra
                cmdATTINFin.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdATTINIni_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdGELMOV1Ini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGELMOV1Ini.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Ini
            wl_eGELMOV1_Ini.xsCodItm = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGELMOV1_QCODITM"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.xsCodItm <> "" Then
                mtbsCodItmIni.Text = wl_eGELMOV1_Grl.xsCodItm
                vl_sCodItm = wl_eGELMOV1_Grl.xsCodItm
                wl_eGELMOV1_Ini.xsCodItm = wl_eGELMOV1_Grl.xsCodItm
                wl_eGELMOV1.xsCodItm = wl_eGELMOV1_Grl.xsCodItm
                cmdGELMOV1Fin.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdGELMOV1Ini_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdGELMOV1Fin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGELMOV1Fin.Click
        Try
            wl_eGELMOV1 = wl_eGELMOV1_Fin
            wl_eGELMOV1.xsCodItm = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGELMOV1_QCODITM"
            BD_frmGELMOV1_QGrl()
            If wl_eGELMOV1_Grl.xsCodItm <> "" Then
                mtbsCodItmFin.Text = wl_eGELMOV1_Grl.xsCodItm
                vl_sCodItm = wl_eGELMOV1_Grl.xsCodItm
                wl_eGELMOV1_Fin.xsCodItm = wl_eGELMOV1_Grl.xsCodItm
                wl_eGELMOV1.xsCodItm = wl_eGELMOV1_Grl.xsCodItm
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdGELMOV1Fin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeGELMOV1(0)
            ReDim wl_aeGELMOV1_Ini(0)
            ReDim wl_aeGELMOV1_Fin(0)
            wl_eGELMOV1 = New moe_Estructuras.eGELMOV1
            wl_eGELMOV1_Ini = New moe_Estructuras.eGELMOV1
            wl_eGELMOV1_Fin = New moe_Estructuras.eGELMOV1

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmRIMOV02"
            dtpFecDocIni.Format = DateTimePickerFormat.Custom
            dtpFecDocIni.CustomFormat = "yyyy-MM-dd"
            dtpFecDocFin.Format = DateTimePickerFormat.Custom
            dtpFecDocFin.CustomFormat = "yyyy-MM-dd"
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
            vl_sCodDoc = ""
            vl_sCodSer = ""
            vl_nNroDoc = 0
            vl_sCodItm = ""
            vl_sCodStr = ""
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_VdaVar()
        Try

            wl_sCodItmIni = mtbsCodItmIni.Text
            wl_sCodItmFin = mtbsCodItmFin.Text

            If txtsCodDocFin.Text = "" Then
                txtsCodDocFin.Text = txtsCodDocIni.Text
            End If
            If txtsCodDocIni.Text = "" Then
                txtsCodDocIni.Text = txtsCodDocFin.Text
            End If
            If Val(txtnNroDocIni.Text) = 0 Then
                txtnNroDocIni.Text = txtnNroDocFin.Text
            End If
            If Val(txtnNroDocFin.Text) = 0 Then
                txtnNroDocFin.Text = txtnNroDocIni.Text
            End If
            If txtsCodSerFin.Text = "" Then
                txtsCodSerFin.Text = txtsCodSerIni.Text
            End If
            If txtsCodSerIni.Text = "" Then
                txtsCodSerIni.Text = txtsCodSerFin.Text
            End If
            If txtsCodTraFin.Text = "" Then
                txtsCodTraFin.Text = txtsCodTraIni.Text
            End If
            If txtsCodTraIni.Text = "" Then
                txtsCodTraIni.Text = txtsCodTraFin.Text
            End If
            If mtbsCodItmFin.Text = "   -" Then
                mtbsCodItmFin.Text = mtbsCodItmIni.Text
                wl_sCodItmFin = mtbsCodItmIni.Text
            End If
            If mtbsCodItmIni.Text = "   -" Then
                mtbsCodItmIni.Text = mtbsCodItmFin.Text
                wl_sCodItmIni = mtbsCodItmFin.Text
            End If

            If wl_sCodItmFin = "   -" Then
                wl_sCodItmFin = ""
            End If
            If wl_sCodItmIni = "   -" Then
                wl_sCodItmIni = ""
            End If
            wl_sCodDocIni = txtsCodDocIni.Text
            wl_sCodDocFin = txtsCodDocFin.Text
            wl_nNroDocIni = Val(txtnNroDocIni.Text)
            wl_nNroDocFin = Val(txtnNroDocFin.Text)
            wl_sCodSerIni = txtsCodSerIni.Text
            wl_sCodSerFin = txtsCodSerFin.Text
            wl_sCodTraIni = txtsCodTraIni.Text
            wl_sCodTraFin = txtsCodTraFin.Text

            wl_eGELMOV1_Ini.sTipMov = txtsTipMov.Text
            wl_eGELMOV1_Fin.sTipMov = txtsTipMov.Text
            wl_eGELMOV1_Ini.sCodDoc = wl_sCodDocIni
            wl_eGELMOV1_Fin.sCodDoc = wl_sCodDocFin
            wl_eGELMOV1_Ini.nNroDoc = wl_nNroDocIni
            wl_eGELMOV1_Fin.nNroDoc = wl_nNroDocFin
            wl_eGELMOV1_Ini.sCodSer = wl_sCodSerIni
            wl_eGELMOV1_Fin.sCodSer = wl_sCodSerFin
            wl_eGELMOV1_Ini.sCodTra = wl_sCodTraIni
            wl_eGELMOV1_Fin.sCodTra = wl_sCodTraFin
            wl_eGELMOV1_Ini.xsCodItm = wl_sCodItmIni
            wl_eGELMOV1_Fin.xsCodItm = wl_sCodItmFin



            wl_dFecDocIni = dtpFecDocIni.Value.ToShortDateString
            wl_eGELMOV1_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString
            wl_dFecDocFin = dtpFecDocFin.Value.ToShortDateString
            wl_eGELMOV1_Fin.dFecDoc = dtpFecDocFin.Value.ToShortDateString

        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"

#End Region
#Region "082 Elo Eventos locales del Formulario"
    Private Sub dtpFecDocIni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecDocIni.ValueChanged
        Try
            wl_dFecDocIni = dtpFecDocIni.Value.ToShortDateString
            wl_eGELMOV1_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString

        Catch ex As Exception
            MsgBox("Error :  dtpFecDocIni_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub

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


            If wl_aeGELMOV1(0).sCodDoc <> "" Then
                Dim wl_frmRPT02 As New rptIRMOV03
                wl_frmRPT02.wp_aeGELMOV1 = wl_aeGELMOV1
                wl_frmRPT02.Show()
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