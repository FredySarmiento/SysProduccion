Public Class frmRIDMI03
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


#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim cnf As New ClaseNegocios.clnFunciones
    Dim wl_DTE1 As DataTable
    Dim wl_DTE2 As DataTable
    Dim wl_DTL1 As DataTable
    Dim wl_DTL2 As DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_aeATALM() As moe_Estructuras.eATALM
    Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
    Dim wl_aeILDMI1() As moe_Estructuras.eILDMI1
    Dim wl_aeIELDMI1() As moe_Estructuras.eIELDMI1

    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eILDMI1 As New moe_Estructuras.eILDMI1
    Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
    Dim wl_eIEDMI_Ini As New moe_Estructuras.eIEDMI
    Dim wl_eIEDMI_Fin As New moe_Estructuras.eIEDMI
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
    Private Sub frmRIDMI03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()

        Catch ex As Exception
            MsgBox("Error :  frmRIDMI03_Load")
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
#End Region

#Region "041 BD Procedimientos sobre la BD. Comunes"

#End Region
#Region "042 BD Busquedas"

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmIEDMI_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_eIEDMI_QGrl = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = wl_eIEDMI
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wl_frmLst.wp_sNomTblTmp = ""
            wg_sTblCon1 = "IEDMI_QGrl"

            wl_frmLst.ShowDialog()
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
            wl_frmLst.wp_sNomTblTmp = ""
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
            BD_frmIEDMI_QIniFin()
            If Not IsNothing(wl_aeIEDMI) Then
                If wl_aeIEDMI.Length <> 0 Then
                    If wl_aeIEDMI(0).sCodItm <> "" Then
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
        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"

#End Region
#Region "082 Elo Eventos locales del Formulario"

#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try

            '     Dim wl_aeIEDMI() As moe_Estructuras.eIEDMI
            '     ReDim wl_aeIEDMI(0)
            Dim wl_bSDM_EDM As Boolean
            wl_bSDM_EDM = False
            If wl_aeIEDMI(0).sCodItm <> "" Then
                Dim wl_frmRPT01 As New rptRIDMI03
                wl_frmRPT01.wp_aeIEDMI = wl_aeIEDMI
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