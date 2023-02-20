Public Class frmRIMOV02
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
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV_Grl() As moe_Estructuras.eGEMOV
    Dim wl_eGEMOV_Grl As New moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV_Ini() As moe_Estructuras.eGEMOV
    Dim wl_eGEMOV_Ini As New moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV_Fin() As moe_Estructuras.eGEMOV
    Dim wl_eGEMOV_Fin As New moe_Estructuras.eGEMOV


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
    Private Sub frmRIMOV02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()
        Catch ex As Exception
            MsgBox("Error :  frmRIMOV02_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aeGEMOV_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeGEMOV(0)
            wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV

            '   moo_aeGEMOV_DT(wl_aeGEMOV,
            '                   wp_DTE1,
            '                   wl_dFecDocIni,
            '                   wl_dFecDocFin,
            '                   Nothing)
        Catch ex As Exception
            MsgBox("Error :  BD_aeGEMOV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmGEMOV_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eGEMOV_Grl = New moe_Estructuras.eGEMOV
            wl_frmLst.wp_eGEMOV = wl_eGEMOV
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wl_frmLst.wp_sMayMenIgu = wl_sMayMenIgu
            wl_frmLst.wp_sTlbMov = "IEMOV"
            wg_sTblCon1 = "GEMOV_Grl"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eGEMOV_Grl.sTipMov <> "" Then
                wl_eGEMOV_Grl.sTipMov = wl_frmLst.wp_eGEMOV_Grl.sTipMov
            End If
            If wl_frmLst.wp_eGEMOV_Grl.sCodDoc <> "" Then
                wl_eGEMOV_Grl.sCodDoc = wl_frmLst.wp_eGEMOV_Grl.sCodDoc
            End If
            If wl_frmLst.wp_eGEMOV_Grl.nNroDoc <> 0 Then
                wl_eGEMOV_Grl.nNroDoc = wl_frmLst.wp_eGEMOV_Grl.nNroDoc
            End If
            If wl_frmLst.wp_eGEMOV_Grl.sCodSer <> "" Then
                wl_eGEMOV_Grl.sCodSer = wl_frmLst.wp_eGEMOV_Grl.sCodSer
            End If
            If wl_frmLst.wp_eGEMOV_Grl.sCodTra <> "" Then
                wl_eGEMOV_Grl.sCodTra = wl_frmLst.wp_eGEMOV_Grl.sCodTra
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmGEMOV_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmGEMOV_IniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eGEMOV_Ini = New moe_Estructuras.eGEMOV
            wl_frmLst.wp_eGEMOV_Fin = New moe_Estructuras.eGEMOV
            wl_frmLst.wp_eGEMOV = New moe_Estructuras.eGEMOV
            ReDim wl_aeGEMOV(0)
            ReDim wg_aeGEMOV(0)
            wl_aeGEMOV(0) = New moe_Estructuras.eGEMOV
            wg_aeGEMOV(0) = New moe_Estructuras.eGEMOV
            wl_frmLst.wp_eGEMOV_Ini = wl_eGEMOV_Ini
            wl_frmLst.wp_eGEMOV_Fin = wl_eGEMOV_Fin
            wl_frmLst.wp_sTlbMov = "IEMOV"
            wg_sTblCon1 = "GEMOV_IniFin"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeGEMOV) Then
                If wg_aeGEMOV.Length > 0 Then
                    If wg_aeGEMOV(0).sCodDoc <> "" Then
                        wl_aeGEMOV = wg_aeGEMOV
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmGEMOV_IniFin")
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
            BD_frmGEMOV_IniFin()
            If Not IsNothing(wl_aeGEMOV) Then
                If wl_aeGEMOV.Length <> 0 Then
                    If wl_aeGEMOV(0).sCodDoc <> "" Then
                        wl_aeGEMOV = wg_aeGEMOV
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
            wl_eGEMOV = wl_eGEMOV_Fin
            wl_eGEMOV.sCodDoc = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGEMOV_QCODDOC"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sCodDoc <> "" Then
                txtsCodDocFin.Text = wl_eGEMOV_Grl.sCodDoc
                vl_sCodDoc = wl_eGEMOV_Grl.sCodDoc
                wl_eGEMOV_Fin.sCodDoc = wl_eGEMOV_Grl.sCodDoc
                wl_eGEMOV.sCodDoc = wl_eGEMOV_Grl.sCodDoc
                cmdAPENDSerI.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdAPENDIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDIni.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Ini
            wl_eGEMOV.sCodDoc = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGEMOV_QCODDOC"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sCodDoc <> "" Then
                txtsCodDocIni.Text = wl_eGEMOV_Grl.sCodDoc
                vl_sCodDoc = wl_eGEMOV_Grl.sCodDoc
                wl_eGEMOV_Ini.sCodDoc = wl_eGEMOV_Grl.sCodDoc
                wl_eGEMOV.sCodDoc = wl_eGEMOV_Grl.sCodDoc
                cmdAPENDFin.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDIni_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdAPENDSerF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDSerF.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Fin
            wl_eGEMOV.sCodSer = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGEMOV_QCODSER"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sCodSer <> "" Then
                txtsCodSerFin.Text = wl_eGEMOV_Grl.sCodSer
                vl_sCodSer = wl_eGEMOV_Grl.sCodSer
                wl_eGEMOV_Fin.sCodSer = wl_eGEMOV_Grl.sCodSer
                wl_eGEMOV.sCodSer = wl_eGEMOV_Grl.sCodSer
                cmdIEMOVIni.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDSerI_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdAPENDSerI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDSerI.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Ini
            wl_eGEMOV.sCodSer = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGEMOV_QCODSER"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sCodSer <> "" Then
                txtsCodSerIni.Text = wl_eGEMOV_Grl.sCodSer
                vl_sCodSer = wl_eGEMOV_Grl.sCodSer
                wl_eGEMOV_Ini.sCodSer = wl_eGEMOV_Grl.sCodSer
                wl_eGEMOV.sCodSer = wl_eGEMOV_Grl.sCodSer
                cmdAPENDSerF.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdAPENDSerI_Click")
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cmdIEMOVFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEMOVFin.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Fin
            wl_eGEMOV.nNroDoc = -1
            vl_sCodStr = "EGEMOV_QNRODOC"
            wl_sMayMenIgu = "Men"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.nNroDoc <> 0 Then
                txtnNroDocFin.Text = wl_eGEMOV_Grl.nNroDoc
                vl_nNroDoc = wl_eGEMOV_Grl.nNroDoc
                wl_eGEMOV_Fin.nNroDoc = wl_eGEMOV_Grl.nNroDoc
                wl_eGEMOV.nNroDoc = wl_eGEMOV_Grl.nNroDoc
                cmdATTINIni.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdIEMOVFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdIEMOVIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEMOVIni.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Ini
            wl_eGEMOV.nNroDoc = -1
            vl_sCodStr = "EGEMOV_QNRODOC"
            wl_sMayMenIgu = "May"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.nNroDoc <> 0 Then
                txtnNroDocIni.Text = wl_eGEMOV_Grl.nNroDoc
                vl_nNroDoc = wl_eGEMOV_Grl.nNroDoc
                wl_eGEMOV_Ini.nNroDoc = wl_eGEMOV_Grl.nNroDoc
                wl_eGEMOV.nNroDoc = wl_eGEMOV_Grl.nNroDoc
                cmdIEMOVFin.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdIEMOVIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTipMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTipMov.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Ini
            wl_eGEMOV.sTipMov = " "
            vl_sCodStr = "EGEMOV_QTIPMOV"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sTipMov <> "" Then
                txtsTipMov.Text = wl_eGEMOV_Grl.sTipMov
                vl_sTipMov = wl_eGEMOV_Grl.sTipMov
                wl_eGEMOV_Ini.sTipMov = wl_eGEMOV_Grl.sTipMov
                wl_eGEMOV_Fin.sTipMov = wl_eGEMOV_Grl.sTipMov
                wl_eGEMOV.sTipMov = wl_eGEMOV_Grl.sTipMov
                cmdAPENDIni.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdTipMov_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdATTINFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdATTINFin.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Fin
            wl_eGEMOV.sCodTra = " "
            wl_sMayMenIgu = "Men"
            vl_sCodStr = "EGEMOV_QCODTRA"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sCodTra <> "" Then
                txtsCodTraFin.Text = wl_eGEMOV_Grl.sCodTra
                vl_sCodTra = wl_eGEMOV_Grl.sCodTra
                wl_eGEMOV_Fin.sCodTra = wl_eGEMOV_Grl.sCodTra
                wl_eGEMOV.sCodTra = wl_eGEMOV_Grl.sCodTra
                cmdOk.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdATTINIni_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdATTINIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdATTINIni.Click
        Try
            wl_eGEMOV = wl_eGEMOV_Ini
            wl_eGEMOV.sCodTra = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EGEMOV_QCODTRA"
            BD_frmGEMOV_QGrl()
            If wl_eGEMOV_Grl.sCodTra <> "" Then
                txtsCodTraIni.Text = wl_eGEMOV_Grl.sCodTra
                vl_sCodTra = wl_eGEMOV_Grl.sCodTra
                wl_eGEMOV_Ini.sCodTra = wl_eGEMOV_Grl.sCodTra
                wl_eGEMOV.sCodTra = wl_eGEMOV_Grl.sCodTra
                cmdATTINFin.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdATTINIni_Click")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeGEMOV(0)
            ReDim wl_aeGEMOV_Ini(0)
            ReDim wl_aeGEMOV_Fin(0)
            wl_eGEMOV = New moe_Estructuras.eGEMOV
            wl_eGEMOV_Ini = New moe_Estructuras.eGEMOV
            wl_eGEMOV_Fin = New moe_Estructuras.eGEMOV

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
            wl_dFecDocIni = dtpFecDocIni.Value.ToShortDateString
            wl_eGEMOV_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString
            wl_dFecDocFin = dtpFecDocFin.Value.ToShortDateString
            wl_eGEMOV_Fin.dFecDoc = dtpFecDocFin.Value.ToShortDateString

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
            wl_eGEMOV_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString

        Catch ex As Exception
            MsgBox("Error :  dtpFecDocIni_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtpFecDocFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecDocFin.ValueChanged
        Try
            wl_dFecDocFin = dtpFecDocFin.Value.ToShortDateString
            wl_eGEMOV_Fin.dFecDoc = dtpFecDocFin.Value.ToShortDateString
        Catch ex As Exception
            MsgBox("Error :  dtpFecDocIni_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region


#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try

            
            If wl_aeGEMOV(0).sCodDoc <> "" Then
                Dim wl_frmRPT02 As New rptRIMOV02
                wl_frmRPT02.wp_aeGEMOV = wl_aeGEMOV
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