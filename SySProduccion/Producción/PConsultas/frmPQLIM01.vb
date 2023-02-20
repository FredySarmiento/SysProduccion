Public Class frmPQLIM01
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2016-01-19

#Region "001 Inicia. wp - vp Definición del variables públicas"
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
    Dim vl_sCodStr As String
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
    Dim wl_sCodItmIni As String
    Dim vl_sCodItm As String


#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnConQry As New ClaseNegocios.clnConQry
    Dim wl_DTE1 As DataTable
    Dim wl_DTE2 As DataTable
    Dim wl_DTL1 As DataTable
    Dim wl_DTL2 As DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_aeQ_PQFOM1() As moe_Estructuras.eQ_PQFOM1
    Dim wl_eQ_PQFOM1 As New moe_Estructuras.eQ_PQFOM1
    Dim wl_aeQ_PQLIM1() As moe_Estructuras.eQ_PQLIM1
    Dim wl_eQ_PQLIM1 As New moe_Estructuras.eQ_PQLIM1
    Dim wl_eQ_PQLIM1_Ini As New moe_Estructuras.eQ_PQLIM1
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_QGrl As New moe_Estructuras.eIEDMI

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
    Private Sub frmPQLIM01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error : frmPQLIM01_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmPQLIM01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()
        Catch ex As Exception
            MsgBox("Error :  frmPQLIM01_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aePQFOM01_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeQ_PQLIM1(0)
            wl_aeQ_PQLIM1(0) = New moe_Estructuras.eQ_PQLIM1



            '   moo_aeGELMOV1_DT(wl_aeGELMOV1,
            '                   wp_DTE1,
            '                   wl_dFecDocIni,
            '                   wl_dFecDocFin,
            '                   Nothing)
        Catch ex As Exception
            MsgBox("Error :  BD_aePQFOM01_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_aePQLIM01_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aeQ_PQLIM1(0)
            wl_aeQ_PQLIM1(0) = New moe_Estructuras.eQ_PQLIM1

            '   moo_aeGELMOV1_DT(wl_aeGELMOV1,
            '                   wp_DTE1,
            '                   wl_dFecDocIni,
            '                   wl_dFecDocFin,
            '                   Nothing)
        Catch ex As Exception
            MsgBox("Error :  BD_aePQLIM01_DT")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "042 BD Busquedas"


    Private Function BD_BuscarIEDMI() As Boolean
        Try
            wr_bEOFE2 = True
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()

            'If txtsCodItm.Text <> "" Then
            If mtbsCodItmIni.Text <> "" Then
                wg_sNomTblE2 = "IEDMI"
                wg_sNomCmpE11 = "sCodItm"
                wg_sDatCmpE11 = mtbsCodItmIni.Text
                wg_sTipCmpE11 = "C"
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_sTitCmpE11 = "Código ítem "
                wg_DTE2 = mof_fConTbl(wg_sNomTblE2,
                                      wg_sNomCmpE11,
                                      wg_sDatCmpE11,
                                      wg_sTipCmpE11,
                                      wg_sCmpOrdE11,
                                      wg_sTipOrdE11,
                                      wr_bEOFE2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarIEDMI")
        End Try
        Return wr_bEOFE2
    End Function
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
            If wl_frmLst.wp_eIEDMI_QGrl.sCodItm <> "" Then
                wl_eIEDMI_QGrl.sCodItm = wl_frmLst.wp_eIEDMI_QGrl.sCodItm
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMI_QGrl")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try

            Dim wl_frmLst As New frmGQLst

            If rdbConMPD.Checked = True Then
                wl_frmLst.wp_eQ_PQFOM1 = New moe_Estructuras.eQ_PQFOM1
                wl_eQ_PQFOM1 = New moe_Estructuras.eQ_PQFOM1


                wl_frmLst.vp_sCodStr = vl_sCodStr
                wl_frmLst.vp_sCodItm = ""
                wl_frmLst.vp_sCodCmt = mtbsCodItmIni.Text
                wg_sTblCon1 = "Q_PQFOM1"

                wl_frmLst.ShowDialog()
                If wl_frmLst.wp_eQ_PQFOM1.sCodCmt <> "" Then
                    wl_eQ_PQFOM1.sCodCmt = wl_frmLst.wp_eQ_PQFOM1.sCodCmt
                End If

            End If
            If rdbConMEE.Checked = True Then
                wl_frmLst.wp_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1
                wl_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1


                wl_frmLst.vp_sCodStr = vl_sCodStr
                wl_frmLst.vp_sCodItm = ""
                wl_frmLst.vp_sCodCmt = mtbsCodItmIni.Text
                wg_sTblCon1 = "Q_PQLIM1"

                wl_frmLst.ShowDialog()
                If wl_frmLst.wp_eQ_PQLIM1.sCodCmt <> "" Then
                    wl_eQ_PQLIM1.sCodCmt = wl_frmLst.wp_eQ_PQLIM1.sCodCmt
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
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"



    Private Sub cmdIEDMIIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMIIni.Click
        Try
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_eIEDMI.sCodItm = " "
            vl_sCodStr = "EIEDMI_QITM"
            BD_frmIEDMI_QGrl()
            If wl_eIEDMI_QGrl.sCodItm <> "" Then
                mtbsCodItmIni.Text = wl_eIEDMI_QGrl.sCodItm
                vl_sCodItm = wl_eIEDMI_QGrl.sCodItm
                wl_eIEDMI.sCodItm = wl_eIEDMI_QGrl.sCodItm
            End If
        Catch ex As Exception
            MsgBox("Error : cmdIEDMIIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aeQ_PQLIM1(0)
            wl_eQ_PQLIM1 = New moe_Estructuras.eQ_PQLIM1

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmRIMOV02"

        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try

            wl_bYesNo = False
            wl_sCodErrAdi = "10-301"
            wl_sCodErrCon = "10-101"
            wl_sCodErrOk = "20-001"
            '       wl_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
            '       wl_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wl_sCmpTSB = "sCodItm"
            wl_sDatTSB = ""
            vl_sCodItm = ""
            mtbsCodItmIni.Text = ""
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_VdaVar()
        Try

            wl_sCodItmIni = mtbsCodItmIni.Text


        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"

#End Region


#Region "082 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"

    Private Sub mtbsCodItmIni_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtbsCodItmIni.KeyUp
        Try
            If Mid(mtbsCodItmIni.Text, 1, 1) <> " " Then
                wr_bEOFE2 = False
                BD_BuscarIEDMI()
                If wr_bEOFE2 = True Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = mtbsCodItmIni.Text
                    wp_sCodErr = wg_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mtbsCodItmIni.Focus()
                Else
                    txtsNomItm.Text = wg_DTE2.Rows(0).Item("sNomItm")
                    cmdOk.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: mtbsCodItmIni_KeyUp")
        End Try

    End Sub
    Private Sub mtbsCodItmIni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbsCodItmIni.LostFocus
        Try
            If Mid(mtbsCodItmIni.Text, 1, 1) <> " " Then
                wr_bEOFE2 = False
                BD_BuscarIEDMI()
                If wr_bEOFE2 = True Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = mtbsCodItmIni.Text
                    wp_sCodErr = wg_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mtbsCodItmIni.Focus()
                Else
                    txtsNomItm.Text = wg_DTE2.Rows(0).Item("sNomItm")
                    cmdOk.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: mtbsCodItmIni_LostFocus")
        End Try

    End Sub
#End Region

#End Region
#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try


            If wl_aeQ_PQLIM1(0).sCodCmt <> "" Then
                Dim wl_frmRPT02 As New rptIRMOV03
                wl_frmRPT02.wp_aeGELMOV1 = wl_aeQ_PQLIM1
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