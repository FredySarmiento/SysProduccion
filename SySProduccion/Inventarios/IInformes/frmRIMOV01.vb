Public Class frmRIMOV01
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
    Dim wl_sCodAlm As String
    Dim wl_sCodGrp As String
    Dim wl_dFecDocIni As Date
    Dim wl_dFecDocFin As Date
    Dim vl_sNomItm As String
    Dim vl_sNomItmIni As String
    Dim vl_sNomItmFin As String


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
    Dim wl_aeKARDEX() As moe_Estructuras.eKARDEX
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eKARDEX As New moe_Estructuras.eKARDEX
    Dim wl_eKARDEX_Ini As New moe_Estructuras.eKARDEX
    Dim wl_eKARDEX_Fin As New moe_Estructuras.eKARDEX
    Dim wl_eKARDEX_QGrl As New moe_Estructuras.eKARDEX

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


    Private Sub frmRIMOV01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

#Region "040 BD"

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aeKARDEX_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeKARDEX(0)
            wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX

            moo_aeKARDEX_DT(wl_aeKARDEX,
                            wp_DTE1,
                            wl_dFecDocIni,
                            wl_dFecDocFin,
                            Nothing)
        Catch ex As Exception
            MsgBox("Error :  BD_aeKARDEX_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "041 BD Procedimientos sobre la BD. Comunes"

#End Region
#Region "042 BD Busquedas"

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmKARDEX_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eKARDEX_QGrl = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX = wl_eKARDEX
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wg_sTblCon1 = "KARDEX_QGrl"

            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eKARDEX_QGrl.sCodItm <> "" Then
                wl_eKARDEX_QGrl.sCodItm = wl_frmLst.wp_eKARDEX_QGrl.sCodItm
            End If
            If wl_frmLst.wp_eKARDEX_QGrl.sCodAlm <> "" Then
                wl_eKARDEX_QGrl.sCodAlm = wl_frmLst.wp_eKARDEX_QGrl.sCodAlm
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_frmKARDEX_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmKARDEX_QSdoAnt()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eKARDEX_Ini = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX_Fin = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX = New moe_Estructuras.eKARDEX

            ReDim wl_aeKARDEX(0)
            ReDim wg_aeKARDEX(0)
            wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
            wg_aeKARDEX(0) = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX_Ini = wl_eKARDEX_Ini
            wl_frmLst.wp_eKARDEX_Fin = wl_eKARDEX_Fin
            wl_frmLst.wp_dFecDocIni = wl_dFecDocIni
            wl_frmLst.wp_dFecDocFin = wl_dFecDocFin
            wg_sTblCon1 = "KARDEX_QSdoAnt"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeKARDEX) Then
                If wg_aeKARDEX.Length > 0 Then
                    If wg_aeKARDEX(0).sCodItm <> "" Then
                        wl_aeKARDEX = wg_aeKARDEX
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmKARDEX_QSdoAnt")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_frmKARDEX_QIniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eKARDEX_Ini = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX_Fin = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX = New moe_Estructuras.eKARDEX

            ReDim wl_aeKARDEX(0)
            ReDim wg_aeKARDEX(0)
            wl_aeKARDEX(0) = New moe_Estructuras.eKARDEX
            wg_aeKARDEX(0) = New moe_Estructuras.eKARDEX
            wl_frmLst.wp_eKARDEX_Ini = wl_eKARDEX_Ini
            wl_frmLst.wp_eKARDEX_Fin = wl_eKARDEX_Fin
            wl_frmLst.wp_dFecDocIni = wl_dFecDocIni
            wl_frmLst.wp_dFecDocFin = wl_dFecDocFin
            wg_sTblCon1 = "KARDEX_QIniFin"
            wl_frmLst.ShowDialog()


            If Not IsNothing(wg_aeKARDEX) Then
                If wg_aeKARDEX.Length > 0 Then

                    If wg_aeKARDEX.Length = 1 Then
                        If wg_aeKARDEX(0).sCodItm <> "" Then
                            wl_aeKARDEX = wg_aeKARDEX
                        End If
                    Else
                        If wg_aeKARDEX(1).sCodItm <> "" Then
                            wg_aeKARDEX(0).sCodItm = wg_aeKARDEX(1).sCodItm
                            wg_aeKARDEX(0).sNomItm = wg_aeKARDEX(1).sNomItm
                            wl_aeKARDEX = wg_aeKARDEX
                        End If
                    End If


                    ' If wg_aeKARDEX(1).sCodItm <> "" Then
                    'wl_aeKARDEX = wg_aeKARDEX
                    'End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmKARDEX_QIniFin")
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
            '     BD_frmKARDEX_QSdoAnt()
            BD_frmKARDEX_QIniFin()
            If Not IsNothing(wl_aeKARDEX) Then
                If wl_aeKARDEX.Length <> 0 Then


                    If wg_aeKARDEX.Length = 1 Then
                        If wg_aeKARDEX(0).sCodItm <> "" Then
                            wl_aeKARDEX = wg_aeKARDEX
                            Rpt_PrmRpt()
                        End If
                    Else
                        If wg_aeKARDEX(1).sCodItm <> "" Then
                            wl_aeKARDEX = wg_aeKARDEX
                            Rpt_PrmRpt()
                        End If
                    End If



                    ' If wl_aeKARDEX(1).sCodItm <> "" Then
                    ' wl_aeKARDEX = wg_aeKARDEX
                    ' Rpt_PrmRpt()
                    '                End If

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
            mtbsCodItmIni.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdLimpiar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdKARDEX_QAlmFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKARDEX_QAlmFin.Click
        Try
            wl_eKARDEX = wl_eKARDEX_Fin
            wl_eKARDEX.sCodAlm = " "
            vl_sCodStr = "EKARDEX_QALM"
            BD_frmKARDEX_QGrl()
            If wl_eKARDEX_QGrl.sCodAlm <> "" Then
                txtsCodAlmFin.Text = wl_eKARDEX_QGrl.sCodAlm
                wl_sCodAlm = wl_eKARDEX_QGrl.sCodAlm
                wl_eKARDEX_Fin.sCodAlm = wl_eKARDEX_QGrl.sCodAlm
                wl_eKARDEX.sCodAlm = wl_eKARDEX_QGrl.sCodAlm
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdKARDEX_QAlmFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdKARDEX_QAlmIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKARDEX_QAlmIni.Click
        Try
            wl_eKARDEX = wl_eKARDEX_Ini
            wl_eKARDEX.sCodAlm = " "
            vl_sCodStr = "EKARDEX_QALM"
            BD_frmKARDEX_QGrl()
            If wl_eKARDEX_QGrl.sCodAlm <> "" Then
                txtsCodAlmIni.Text = wl_eKARDEX_QGrl.sCodAlm
                wl_sCodAlm = wl_eKARDEX_QGrl.sCodAlm
                wl_eKARDEX_Ini.sCodAlm = wl_eKARDEX_QGrl.sCodAlm
                wl_eKARDEX.sCodAlm = wl_eKARDEX_QGrl.sCodAlm
                cmdKARDEX_QAlmFin.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdKARDEX_QItmIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdKARDEX_QItmFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKARDEX_QItmFin.Click
        Try
            wl_eKARDEX = wl_eKARDEX_Fin
            wl_eKARDEX.sCodItm = " "
            vl_sCodStr = "EKARDEX_QITM"
            BD_frmKARDEX_QGrl()
            If wl_eKARDEX_QGrl.sCodItm <> "" Then
                mtbsCodItmFin.Text = wl_eKARDEX_QGrl.sCodItm
                wl_sCodItm = wl_eKARDEX_QGrl.sCodItm
                vl_sNomItmFin = wl_eKARDEX_QGrl.sNomItm
                wl_eKARDEX_Fin.sCodItm = wl_eKARDEX_QGrl.sCodItm
                wl_eKARDEX.sCodItm = wl_eKARDEX_QGrl.sCodItm
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdKARDEX_QItmFin_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdKARDEX_QItmIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKARDEX_QItmIni.Click
        Try
            wl_eKARDEX = wl_eKARDEX_Ini
            wl_eKARDEX.sCodItm = " "
            vl_sCodStr = "EKARDEX_QITM"
            BD_frmKARDEX_QGrl()
            If wl_eKARDEX_QGrl.sCodItm <> "" Then
                mtbsCodItmIni.Text = wl_eKARDEX_QGrl.sCodItm
                vl_sNomItmIni = wl_eKARDEX_QGrl.sNomItm
                wl_sCodItm = wl_eKARDEX_QGrl.sCodItm
                wl_eKARDEX_Ini.sCodItm = wl_eKARDEX_QGrl.sCodItm
                wl_eKARDEX.sCodItm = wl_eKARDEX_QGrl.sCodItm
                cmdKARDEX_QItmFin.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdKARDEX_QItmIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeKARDEX(0)
            wl_eKARDEX = New moe_Estructuras.eKARDEX
            wl_eKARDEX_Ini = New moe_Estructuras.eKARDEX
            wl_eKARDEX_Fin = New moe_Estructuras.eKARDEX
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmRIMOV01"
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
            wl_sCodDoc = ""
            wl_sCodSer = ""
            wl_nNroDoc = 0
            wl_sEstOdp = ""
            wl_sCodItm = ""
            vl_sCodStr = ""
            dtpFecDocIni.Text = Year(Today).ToString + "-01-01"

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_VdaVar()
        Try
            If mtbsCodItmFin.Text = "   -   " Then
                mtbsCodItmFin.Text = mtbsCodItmIni.Text
                wl_eKARDEX_Fin.sCodItm = mtbsCodItmFin.Text
            End If
            If mtbsCodItmIni.Text = "" Then
                mtbsCodItmIni.Text = mtbsCodItmFin.Text
                wl_eKARDEX_Ini.sCodItm = mtbsCodItmIni.Text
            End If
            If txtsCodAlmFin.Text = "" Then
                txtsCodAlmFin.Text = txtsCodAlmIni.Text
                wl_eKARDEX_Fin.sCodAlm = txtsCodAlmFin.Text
            End If
            If txtsCodAlmIni.Text = "" Then
                txtsCodAlmIni.Text = txtsCodAlmFin.Text
                wl_eKARDEX_Ini.sCodAlm = txtsCodAlmIni.Text
            End If

            wl_eKARDEX_Ini.sCodItm = mtbsCodItmIni.Text
            wl_eKARDEX_Fin.sCodItm = mtbsCodItmFin.Text
            wl_eKARDEX_Ini.sCodAlm = txtsCodAlmIni.Text
            wl_eKARDEX_Fin.sCodAlm = txtsCodAlmFin.Text
            wl_dFecDocIni = dtpFecDocIni.Value.ToShortDateString
            wl_dFecDocFin = dtpFecDocFin.Value.ToShortDateString


            wl_eKARDEX_Ini.dFecDocIni = wl_dFecDocIni
            wl_eKARDEX_Ini.dFecDocFin = wl_dFecDocFin
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
            wl_eKARDEX_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString

        Catch ex As Exception
            MsgBox("Error :  dtpFecDocIni_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtpFecDocFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecDocFin.ValueChanged
        Try
            wl_dFecDocFin = dtpFecDocFin.Value.ToShortDateString
            wl_eKARDEX_Fin.dFecDoc = dtpFecDocFin.Value.ToShortDateString
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

            '  Dim wl_aeKARDEX() As moe_Estructuras.eKARDEX
            ' ReDim wl_aeKARDEX(0)
            '  Dim wl_bSDM_EDM As Boolean
            ' wl_bSDM_EDM = False

            If wl_aeKARDEX(1).sCodItm <> "" Then
                'wl_aeKARDEX(0).sCodItm = mtbsCodItmIni.Text
                ' wl_aeKARDEX(0).sNomItm = vl_sNomItm
                Dim wl_frmRPT01 As New rptRIMOV01
                wl_frmRPT01.wp_aeKARDEX = wl_aeKARDEX
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