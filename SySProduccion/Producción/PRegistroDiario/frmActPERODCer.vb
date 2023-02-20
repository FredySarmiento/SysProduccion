Public Class frmActPERODCer
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
    Dim wl_bTF As Boolean
    Dim wl_bEOF1 As Boolean
    Dim wl_bDocCrd As Boolean


    ' wl numéricas

    Dim wl_sHorSys As String
    Dim wl_nHH As Integer
    Dim wl_nMM As Integer


    Dim wl_nHHIni As Integer
    Dim wl_nHHFin As Integer
    Dim wl_nMMIni As Integer
    Dim wl_nMMFin As Integer
    Dim wl_nHHCns As Integer
    Dim wl_nMMCns As Integer
    Dim wl_nTieCns As Integer
    Dim wp_nI As Integer
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
    Dim vl_sEstPdo As String

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnKARDEX As New ClaseNegocios.clnIEINV
    Dim cnf As New ClaseNegocios.clnFunciones
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnPEODP As New ClaseNegocios.clnPEODP
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
    Private Sub frmActPERODCer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            mof_fLmpCtrl(Me)
            Plo_IniciarFrm()
            Plo_IniciarEst()
            Plo_IniciarVar()

        Catch ex As Exception
            MsgBox("Error :  frmActPERODCer_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_aePEROP_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            ReDim wl_aePEROP(0)
            wl_aePEROP(0) = New moe_Estructuras.ePEROP

            '   moo_aePEROP_DT(wl_aePEROP,
            '                   wp_DTE1,
            '                   wl_dFecDocIni,
            '                   wl_dFecDocFin,
            '                   Nothing)
        Catch ex As Exception
            MsgBox("Error :  BD_aePEROP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_CrearActualizarPEROP(ByVal wp_sCmdSel As String)
        wl_bTF = False
        Try

            wl_bEOF = True
            vl_sEstPdo = "0"
            wl_bEOF = mov_VdaPdoCtb(vl_dFecDoc, vl_sEstPdo)
            If wl_bEOF = True Then
                MsgBox("Período Contable, para la fecha contable, No Existe")
                cmdCancelar.Focus()
                Return
            Else
                If vl_sEstPdo = "2" Then
                    MsgBox("Período Contable para la fecha contable está Cerrado. No se puede actualizar")
                    cmdCancelar.Focus()
                    Return
                End If
            End If
            wl_bEOF = mov_VdaPdoCtb(vl_dFecDoc, vl_sEstPdo)
            If wl_bEOF = True Then
                MsgBox("Período Contable, para la fecha del documento, No Existe")
                cmdCancelar.Focus()
                Return
            Else
                If vl_sEstPdo = "2" Then
                    MsgBox("Período Contable, para la fecha del documento, Está Cerrado")
                    cmdCancelar.Focus()
                    Return
                End If
            End If
            wg_bVdaE1 = True
            wl_bTF = clnPEROP.cnCrearAct(wl_ePEROP,
                                         wr_bEOFE1,
                                         wp_sCmdSel)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizarPEROP")
        End Try
    End Sub
    Private Sub BD_CrearActualizarPLROP1(ByVal wp_sCmdSel As String)
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bTF = False
        wl_bEOF = True
        wl_bEOF1 = True
        Try
            clnPEROP.cnCrearActPLROP1(wl_ePLROP1,
                                      wl_bEOF1,
                                      wp_sCmdSel)

            If wl_ePLROP1.sCodDocBas <> Nothing Then
                If wl_bDocCrd = True Then


                    clnPEROP.cnCrearActPLROP1(wl_ePLROP1,
                                                 wl_bEOF,
                                                 wp_sCmdSel)
                    clnPEODP.cnActCnsPLODP2(wl_ePLROP1,
                                            wr_bEOFL1,
                                            wp_sCmdSel)
                    clnPEODP.cnActCnsMODPLODP4(wl_ePLROP1,
                                               wr_bEOFL1,
                                               wp_sCmdSel)
                    clnPEODP.cnActCnsPLODP3(wl_ePLROP1,
                                            wr_bEOFL1,
                                            wp_sCmdSel)
                    clnPEODP.cnActCnsCIFPLODP4(wl_ePLROP1,
                                               wr_bEOFL1,
                                               wp_sCmdSel)
                    clnPEODP.cnRecalPLODP4(wl_ePLROP1.sCodDocBas,
                                           wl_ePLROP1.nNroDocBas)
                    clnPEODP.cnActPorOpeCnsPLODP2(wl_ePLROP1,
                                                  wr_bEOFL1)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : BD_CrearActualizarPLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmPEROP_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_ePEROP_Grl = New moe_Estructuras.ePEROP
            wl_frmLst.wp_ePEROP = wl_ePEROP
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wl_frmLst.wp_sMayMenIgu = wl_sMayMenIgu
            wl_frmLst.wp_sTlbMov = "PEROP"
            wg_sTblCon1 = "PEROP_Grl"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_ePEROP_Grl.nNroDoc <> 0 Then
                wl_ePEROP_Grl.nNroDoc = wl_frmLst.wp_ePEROP_Grl.nNroDoc
            End If
            If wl_frmLst.wp_ePEROP_Grl.sCodSer <> "" Then
                wl_ePEROP_Grl.sCodSer = wl_frmLst.wp_ePEROP_Grl.sCodSer
            End If
            If wl_frmLst.wp_ePEROP_Grl.sCodTer <> "" Then
                wl_ePEROP_Grl.sCodTer = wl_frmLst.wp_ePEROP_Grl.sCodTer
            End If
            If wl_frmLst.wp_ePEROP_Grl.sEstDoc <> "" Then
                wl_ePEROP_Grl.sEstDoc = wl_frmLst.wp_ePEROP_Grl.sEstDoc
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmPEROP_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmPEROP_IniFin()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_ePEROP_Ini = New moe_Estructuras.ePEROP
            wl_frmLst.wp_ePEROP_Fin = New moe_Estructuras.ePEROP
            wl_frmLst.wp_ePELROP1 = New moe_Estructuras.ePELROP1

            ReDim wl_aePELROP1(0)
            ReDim wg_aePELROP1(0)
            wl_aePELROP1(0) = New moe_Estructuras.ePELROP1
            wg_aePELROP1(0) = New moe_Estructuras.ePELROP1
            wl_frmLst.wp_ePEROP_Ini = wl_ePEROP_Ini
            wl_frmLst.wp_ePEROP_Fin = wl_ePEROP_Fin
            wl_frmLst.wp_sTlbMov = "PEROP"
            wg_sTblCon1 = "PEROP_IniFin"
            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aePELROP1) Then
                If wg_aePELROP1.Length > 0 Then
                    If wg_aePELROP1(0).sCodDoc <> "" Then
                        wl_aePELROP1 = wg_aePELROP1
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmPEROP_IniFin")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmPLROP1_QGrl()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_frmLst.wp_ePLROP1_Grl = New moe_Estructuras.ePLROP1
            wl_frmLst.wp_ePLROP1 = wl_ePLROP1
            wl_frmLst.vp_sCodStr = vl_sCodStr
            wl_frmLst.wp_sMayMenIgu = wl_sMayMenIgu
            wl_frmLst.wp_sTlbMov = "PLROP1"
            wg_sTblCon1 = "PLROP1_Grl"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_ePLROP1_Grl.nNroDoc <> 0 Then
                wl_ePLROP1_Grl.nNroDoc = wl_frmLst.wp_ePLROP1_Grl.nNroDoc
            End If
            If wl_frmLst.wp_ePLROP1_Grl.sCodSer <> "" Then
                wl_ePLROP1_Grl.sCodSer = wl_frmLst.wp_ePLROP1_Grl.sCodSer
            End If
            If wl_frmLst.wp_ePLROP1_Grl.nNroDocBas <> 0 Then
                wl_ePLROP1_Grl.nNroDocBas = wl_frmLst.wp_ePLROP1_Grl.nNroDocBas
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmPLROP1_QGrl")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdActualizar_Click(sender As System.Object, e As System.EventArgs) Handles cmdActualizar.Click
        Try

            wp_nBoxMsg = 4
            wl_nHH = Int(txtnHHFinOpe.Text)
            wl_nMM = Int(txtnMMFinOpe.Text)
            vl_dFecDoc = dtpFecDocIni.Text
            wp_sDesMsg = "Registros no pueden modificarse después de esta actualización. " & "Hora Cierre : " & wl_nHH & " - " & wl_nMM & "¿Continua?"
            wp_sTitMsg = "Mensaje del Sistema"
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)

            If wp_nResMsg = 6 Then
                Plo_ActPEROP()
                cmdLimpiar.PerformClick()
                cmdActualizar.Visible = False
                cmdOk.Visible = True
                MsgBox("Proceso Terminado Exitosamente")
                cmdCancelar.Focus()
            End If
            cmdCancelar.Focus()


        Catch ex As Exception
            MsgBox("Error :  cmdActualizar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "A"
            Plo_VdaVar()
            BD_frmPEROP_IniFin()
            If Not IsNothing(wl_aePELROP1) Then
                If wl_aePELROP1.Length <> 0 Then
                    If wl_aePELROP1(0).sCodDoc <> "" Then
                        wl_aePELROP1 = wg_aePELROP1
                        Plo_MueHHMM()
                        Plo_ActivarCmpAct()

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
            txtsCodSerIni.Focus()
        Catch ex As Exception
            MsgBox("Error : cmdLimpiar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdAPENDSerI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAPENDSerI.Click
        Try
            wl_ePEROP = wl_ePEROP_Ini
            wl_ePEROP.sCodSer = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EPEROP_QCODSER"
            BD_frmPEROP_QGrl()
            If wl_ePEROP_Grl.sCodSer <> "" Then
                txtsCodSerIni.Text = wl_ePEROP_Grl.sCodSer
                vl_sCodSer = wl_ePEROP_Grl.sCodSer
                wl_ePEROP_Ini.sCodSer = wl_ePEROP_Grl.sCodSer
                wl_ePEROP.sCodSer = wl_ePEROP_Grl.sCodSer
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdAPENDSerI_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Private Sub cmdIEMOVIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEMOVIni.Click
        Try
            wl_ePEROP = wl_ePEROP_Ini
            wl_ePEROP.nNroDoc = -1
            vl_sCodStr = "EPEROP_QNRODOC"
            wl_sMayMenIgu = "May"
            BD_frmPEROP_QGrl()
            If wl_ePEROP_Grl.nNroDoc <> 0 Then
                txtnNroDocIni.Text = wl_ePEROP_Grl.nNroDoc
                vl_nNroDoc = wl_ePEROP_Grl.nNroDoc
                wl_ePEROP_Ini.nNroDoc = wl_ePEROP_Grl.nNroDoc
                wl_ePEROP.nNroDoc = wl_ePEROP_Grl.nNroDoc
                cmdOk.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : cmdIEMOVIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdTEDMTIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTEDMTIni.Click
        Try
            wl_ePEROP = wl_ePEROP_Ini
            wl_ePEROP.sCodTer = " "
            wl_sMayMenIgu = "May"
            vl_sCodStr = "EPEROP_QCODTER"
            BD_frmPEROP_QGrl()
            If wl_ePEROP_Grl.sCodTer <> "" Then
                txtsCodTerIni.Text = wl_ePEROP_Grl.sCodTer
                vl_sCodTer = wl_ePEROP_Grl.sCodTer
                wl_ePEROP_Ini.sCodTer = wl_ePEROP_Grl.sCodTer
                wl_ePEROP.sCodTer = wl_ePEROP_Grl.sCodTer
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdTEDMTIni_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActivarCmpAct()
        Try
            cmdOk.Visible = False
            cmdActualizar.Visible = True


        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_IniciarEst()
        Try
            ReDim wl_aePEROP(0)
            ReDim wl_aePEROP_Ini(0)
            ReDim wl_aePEROP_Fin(0)
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePEROP_Ini = New moe_Estructuras.ePEROP
            wl_ePEROP_Fin = New moe_Estructuras.ePEROP

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmActPERODCer"
            dtpFecDocIni.Format = DateTimePickerFormat.Custom
            dtpFecDocIni.CustomFormat = "yyyy-MM-dd"
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
            wl_sCmpTSB = "sCodDoc"
            wl_sDatTSB = ""
            vl_sCodDoc = ""
            vl_sCodSer = ""
            vl_nNroDoc = 0
            vl_sCodItm = ""
            vl_sCodStr = ""
            vl_sEstDoc = "A"
            txtsEstDocIni.Text = vl_sEstDoc
            wl_nHH = 0
            wl_nMM = 0
            txtnHHFinOpe.Text = ""
            txtnMMFinOpe.Text = ""
            wp_sCmdSel = "A"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_VdaVar()
        Try
            wl_ePEROP_Ini.sEstDoc = txtsEstDocIni.Text
            wl_ePEROP_Fin.sEstDoc = txtsEstDocIni.Text
            wl_ePEROP_Ini.sCodSer = txtsCodSerIni.Text
            wl_ePEROP_Fin.sCodSer = txtsCodSerIni.Text
            wl_ePEROP_Ini.nNroDoc = Val(txtnNroDocIni.Text)
            wl_ePEROP_Fin.nNroDoc = Val(txtnNroDocIni.Text)
            wl_ePEROP_Ini.sCodTer = txtsCodTerIni.Text
            wl_ePEROP_Fin.sCodTer = txtsCodTerIni.Text
            wl_dFecDocIni = dtpFecDocIni.Value.ToShortDateString
            wl_ePEROP_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString
            wl_dFecDocFin = dtpFecDocIni.Value.ToShortDateString
            wl_ePEROP_Fin.dFecDoc = dtpFecDocIni.Value.ToShortDateString

        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_MueHHMM()
        Try


            wl_nHH = 0
            wl_nMM = 0
            wl_sHorSys = txtdHHMM.Text
            mof_fCnvHorSys(wl_sHorSys,
                          wl_nHH,
                         wl_nMM)
            txtnHHFinOpe.Text = wl_nHH
            txtnMMFinOpe.Text = wl_nMM

        Catch ex As Exception
            MsgBox("Error : Plo_MueveFec")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_ActPEROP()
        Try
            Dim wl_nCntRow As Integer
            Dim wl_nI As Integer
            wl_nHH = Int(txtnHHFinOpe.Text)
            wl_nMM = Int(txtnMMFinOpe.Text)
            wl_nCntRow = wl_aePELROP1.Length
            For wl_nI = 0 To wl_nCntRow - 1
                wp_nI = wl_nI
                If wl_aePELROP1(wl_nI).sEstDoc = "A" Then
                    wl_ePEROP = New moe_Estructuras.ePEROP
                    wl_ePLROP1 = New moe_Estructuras.ePLROP1
                    Plo_ePEROP_aePLEROP1()
                    Plo_ePLROP1_aePLEROP1()
                    Plo_CalTie()
                    Plo_VdaCerDoc()
                    BD_CrearActualizarPLROP1(wp_sCmdSel)
                    BD_CrearActualizarPEROP(wp_sCmdSel)
                End If
            Next


        Catch ex As Exception
            MsgBox("Error : Plo_ActPEROP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePEROP_aePLEROP1()
        Try
            wl_ePEROP.nId = wl_aePELROP1(wp_nI).nId
            wl_ePEROP.sCodDoc = wl_aePELROP1(wp_nI).sCodDoc
            wl_ePEROP.sCodDoc = wl_aePELROP1(wp_nI).sCodDoc
            wl_ePEROP.sCodSer = wl_aePELROP1(wp_nI).sCodSer
            wl_ePEROP.nNroDoc = wl_aePELROP1(wp_nI).nNroDoc
            wl_ePEROP.sTipMov = wl_aePELROP1(wp_nI).sTipMov
            wl_ePEROP.sEstDoc = wl_aePELROP1(wp_nI).sEstDoc
            wl_ePEROP.dFecCtb = wl_aePELROP1(wp_nI).dFecCtb
            wl_ePEROP.dFecDoc = wl_aePELROP1(wp_nI).dFecDoc
            wl_ePEROP.dFecVto = wl_aePELROP1(wp_nI).dFecVto
            wl_ePEROP.dFecSys = wl_aePELROP1(wp_nI).dFecSys
            wl_ePEROP.sCodTer = wl_aePELROP1(wp_nI).sCodTer
            wl_ePEROP.sNomTer = wl_aePELROP1(wp_nI).sNomTer
            wl_ePEROP.sDocRef = wl_aePELROP1(wp_nI).sDocRef
            wl_ePEROP.nTotHHCns = wl_aePELROP1(wp_nI).nTotHHCns
            wl_ePEROP.nTotMMCns = wl_aePELROP1(wp_nI).nTotMMCns
            wl_ePEROP.nTotTieCns = wl_aePELROP1(wp_nI).nTotTieCns
            wl_ePEROP.nTotDoc = wl_aePELROP1(wp_nI).nTotDoc
            wl_ePEROP.sCodCte = wl_aePELROP1(wp_nI).sCodCte
            wl_ePEROP.nNroCte = wl_aePELROP1(wp_nI).nNroCte
            wl_ePEROP.sClsDoc = wl_aePELROP1(wp_nI).sClsDoc
            wl_ePEROP.sCmn = wl_aePELROP1(wp_nI).sCmn
            wl_ePEROP.sCodCteCtb = wl_aePELROP1(wp_nI).sCodCteCtb
            wl_ePEROP.nNroCteCtb = wl_aePELROP1(wp_nI).nNroCteCtb
            wl_ePEROP.nIdFECCT = wl_aePELROP1(wp_nI).nIdFECCT
            wl_ePEROP.sNitTer = wl_aePELROP1(wp_nI).sNitTer
            wl_ePEROP.sTipDoc = wl_aePELROP1(wp_nI).sTipDoc
            wl_ePEROP.sCodUsr = wl_aePELROP1(wp_nI).sCodUsr
            wl_ePEROP.bPrp01 = wl_aePELROP1(wp_nI).bPrp01
            wl_ePEROP.bPrp02 = wl_aePELROP1(wp_nI).bPrp02
            wl_ePEROP.bPrp03 = wl_aePELROP1(wp_nI).bPrp03
            wl_ePEROP.nTotHHOpe = wl_aePELROP1(wp_nI).nTotHHOpe
            wl_ePEROP.nTotMMOpe = wl_aePELROP1(wp_nI).nTotMMOpe
            wl_ePEROP.nTotTieOpe = wl_aePELROP1(wp_nI).nTotTieOpe
            wl_ePEROP.nTotHHAlz = wl_aePELROP1(wp_nI).nTotHHAlz
            wl_ePEROP.nTotMMAlz = wl_aePELROP1(wp_nI).nTotMMAlz
            wl_ePEROP.nTotTieAlz = wl_aePELROP1(wp_nI).nTotTieAlz
            wl_ePEROP.nTotHHCaf = wl_aePELROP1(wp_nI).nTotHHCaf
            wl_ePEROP.nTotMMCaf = wl_aePELROP1(wp_nI).nTotMMCaf
            wl_ePEROP.nTotTieCaf = wl_aePELROP1(wp_nI).nTotTieCaf
        Catch ex As Exception
            MsgBox("Error : Plo_ePEROP_aePLEROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePLROP1_aePLEROP1()
        Try
            wl_ePLROP1.nId = wl_aePELROP1(wp_nI).xnId
            wl_ePLROP1.sCodDoc = wl_aePELROP1(wp_nI).xsCodDoc
            wl_ePLROP1.nNroDoc = wl_aePELROP1(wp_nI).xnNroDoc
            wl_ePLROP1.sCodSer = wl_aePELROP1(wp_nI).xsCodSer
            wl_ePLROP1.sTipMov = wl_aePELROP1(wp_nI).xsTipMov
            wl_ePLROP1.sCodDocBas = wl_aePELROP1(wp_nI).xsCodDocBas
            wl_ePLROP1.sCodSerBas = wl_aePELROP1(wp_nI).xsCodSerBas
            wl_ePLROP1.nNroDocBas = wl_aePELROP1(wp_nI).xnNroDocBas
            wl_ePLROP1.sCodItm = wl_aePELROP1(wp_nI).xsCodItm
            wl_ePLROP1.nCanItm = wl_aePELROP1(wp_nI).xnCanItm
            wl_ePLROP1.sCodOpe = wl_aePELROP1(wp_nI).xsCodOpe
            wl_ePLROP1.sNomOpe = wl_aePELROP1(wp_nI).xsNomOpe
            wl_ePLROP1.nHHIniOpe = wl_aePELROP1(wp_nI).xnHHIniOpe
            wl_ePLROP1.nMMIniOpe = wl_aePELROP1(wp_nI).xnMMIniOpe
            wl_ePLROP1.nHHFinOpe = wl_aePELROP1(wp_nI).xnHHFinOpe
            wl_ePLROP1.nMMFinOpe = wl_aePELROP1(wp_nI).xnMMFinOpe
            wl_ePLROP1.nHHCnsOpe = wl_aePELROP1(wp_nI).xnHHCnsOpe
            wl_ePLROP1.nMMCnsOpe = wl_aePELROP1(wp_nI).xnMMCnsOpe
            wl_ePLROP1.nTieCnsOpe = wl_aePELROP1(wp_nI).xnTieCnsOpe
            wl_ePLROP1.nHHCns = wl_aePELROP1(wp_nI).xnHHCns
            wl_ePLROP1.nMMCns = wl_aePELROP1(wp_nI).xnMMCns
            wl_ePLROP1.nTieCns = wl_aePELROP1(wp_nI).xnTieCns
            wl_ePLROP1.nTieReq = wl_aePELROP1(wp_nI).xnTieReq
            wl_ePLROP1.nPreUni = wl_aePELROP1(wp_nI).xnPreUni
            wl_ePLROP1.nTotLin = wl_aePELROP1(wp_nI).xnTotLin
            wl_ePLROP1.sCodCco = wl_aePELROP1(wp_nI).xsCodCco
            wl_ePLROP1.nLinBas = wl_aePELROP1(wp_nI).xnLinBas
            wl_ePLROP1.sCodPdo = wl_aePELROP1(wp_nI).xsCodPdo
            wl_ePLROP1.sCodCta = wl_aePELROP1(wp_nI).xsCodCta
            wl_ePLROP1.sCtaCosVta = wl_aePELROP1(wp_nI).xsCtaCosVta
            wl_ePLROP1.bItmBlq = wl_aePELROP1(wp_nI).xbItmBlq
            wl_ePLROP1.sClsDoc = wl_aePELROP1(wp_nI).xsClsDoc
            wl_ePLROP1.nCanOpeTer = wl_aePELROP1(wp_nI).xnCanOpeTer
            wl_ePLROP1.sCodCtr = wl_aePELROP1(wp_nI).xsCodCtr
            wl_ePLROP1.nHHIniAlz = wl_aePELROP1(wp_nI).xnHHIniAlz
            wl_ePLROP1.nMMIniAlz = wl_aePELROP1(wp_nI).xnMMIniAlz
            wl_ePLROP1.nHHFinAlz = wl_aePELROP1(wp_nI).xnHHFinAlz
            wl_ePLROP1.nMMFinAlz = wl_aePELROP1(wp_nI).xnMMFinAlz
            wl_ePLROP1.nHHCnsAlz = wl_aePELROP1(wp_nI).xnHHCnsAlz
            wl_ePLROP1.nMMCnsAlz = wl_aePELROP1(wp_nI).xnMMCnsAlz
            wl_ePLROP1.nTieCnsAlz = wl_aePELROP1(wp_nI).xnTieCnsAlz
            wl_ePLROP1.nHHIniCaf = wl_aePELROP1(wp_nI).xnHHIniCaf
            wl_ePLROP1.nMMIniCaf = wl_aePELROP1(wp_nI).xnMMIniCaf
            wl_ePLROP1.nHHFinCaf = wl_aePELROP1(wp_nI).xnHHFinCaf
            wl_ePLROP1.nMMFinCaf = wl_aePELROP1(wp_nI).xnMMFinCaf
            wl_ePLROP1.nHHCnsCaf = wl_aePELROP1(wp_nI).xnHHCnsCaf
            wl_ePLROP1.nMMCnsCaf = wl_aePELROP1(wp_nI).xnMMCnsCaf
            wl_ePLROP1.nTieCnsCaf = wl_aePELROP1(wp_nI).xnTieCnsCaf
        Catch ex As Exception
            MsgBox("Error : Plo_ePLROP1_aePLEROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Plo_CalTie()
        Try
            If wl_ePLROP1.nTieCnsCaf = 0 And ((wl_ePLROP1.nHHIniCaf - wl_ePLROP1.nHHFinCaf) + (wl_ePLROP1.nMMIniCaf - wl_ePLROP1.nMMFinCaf)) <> 0 Then
                If (wl_ePLROP1.nHHIniCaf > 0 Or wl_ePLROP1.nMMIniCaf > 0) Then
                    wl_ePLROP1.nHHFinCaf = wl_nHH
                    wl_ePLROP1.nMMFinCaf = wl_nMM
                End If
                wl_nHHIni = wl_ePLROP1.nHHIniCaf
                wl_nMMIni = wl_ePLROP1.nMMIniCaf
                wl_nHHFin = wl_ePLROP1.nHHFinCaf
                wl_nMMFin = wl_ePLROP1.nMMFinCaf
                wl_nHHCns = 0
                wl_nMMCns = 0
                wl_nTieCns = 0
                mof_fCalTie(wl_nHHIni,
                           wl_nMMIni,
                           wl_nHHFin,
                           wl_nMMFin,
                           wl_nHHCns,
                           wl_nMMCns,
                           wl_nTieCns)
                wl_ePLROP1.nHHCnsCaf = wl_nHHCns
                wl_ePLROP1.nMMCnsCaf = wl_nMMCns
                wl_ePLROP1.nTieCnsCaf = wl_nTieCns
            End If
            If wl_ePLROP1.nTieCnsAlz = 0 And ((wl_ePLROP1.nHHIniAlz - wl_ePLROP1.nHHFinAlz) + (wl_ePLROP1.nMMIniAlz - wl_ePLROP1.nMMFinAlz)) <> 0 Then
                If (wl_ePLROP1.nHHIniAlz > 0 Or wl_ePLROP1.nMMIniAlz > 0) Then
                    wl_ePLROP1.nHHFinAlz = wl_nHH
                    wl_ePLROP1.nMMFinAlz = wl_nMM
                End If
                wl_nHHIni = wl_ePLROP1.nHHIniAlz
                wl_nMMIni = wl_ePLROP1.nMMIniAlz
                wl_nHHFin = wl_ePLROP1.nHHFinAlz
                wl_nMMFin = wl_ePLROP1.nMMFinAlz
                wl_nHHCns = 0
                wl_nMMCns = 0
                wl_nTieCns = 0
                mof_fCalTie(wl_nHHIni,
                           wl_nMMIni,
                           wl_nHHFin,
                           wl_nMMFin,
                           wl_nHHCns,
                           wl_nMMCns,
                           wl_nTieCns)
                wl_ePLROP1.nHHCnsAlz = wl_nHHCns
                wl_ePLROP1.nMMCnsAlz = wl_nMMCns
                wl_ePLROP1.nTieCnsAlz = wl_nTieCns
            End If

            If wl_ePLROP1.nTieCnsOpe = 0 And ((wl_ePLROP1.nHHIniOpe - wl_ePLROP1.nHHFinOpe) + (wl_ePLROP1.nMMIniOpe - wl_ePLROP1.nMMFinOpe)) <> 0 Then
                If (wl_ePLROP1.nHHIniOpe > 0 Or wl_ePLROP1.nMMIniOpe > 0) Then
                    wl_ePLROP1.nHHFinOpe = wl_nHH
                    wl_ePLROP1.nMMFinOpe = wl_nMM
                End If
                wl_nHHIni = wl_ePLROP1.nHHIniOpe
                wl_nMMIni = wl_ePLROP1.nMMIniOpe
                wl_nHHFin = wl_ePLROP1.nHHFinOpe
                wl_nMMFin = wl_ePLROP1.nMMFinOpe
                wl_nHHCns = 0
                wl_nMMCns = 0
                wl_nTieCns = 0
                mof_fCalTie(wl_nHHIni,
                           wl_nMMIni,
                           wl_nHHFin,
                           wl_nMMFin,
                           wl_nHHCns,
                           wl_nMMCns,
                           wl_nTieCns)
                wl_ePLROP1.nHHCnsOpe = wl_nHHCns
                wl_ePLROP1.nMMCnsOpe = wl_nMMCns
                wl_ePLROP1.nTieCnsOpe = wl_nTieCns
            End If

            'Total Consumo Ope - Alz
            wl_nHHFin = wl_ePLROP1.nHHCnsOpe
            wl_nMMFin = wl_ePLROP1.nMMCnsOpe

            wl_nHHIni = wl_ePLROP1.nHHCnsAlz
            wl_nMMIni = wl_ePLROP1.nMMCnsAlz
            wl_nHHCns = 0
            wl_nMMCns = 0
            wl_nTieCns = 0
            mof_fCalTie(wl_nHHIni,
                       wl_nMMIni,
                       wl_nHHFin,
                       wl_nMMFin,
                       wl_nHHCns,
                       wl_nMMCns,
                       wl_nTieCns)
            wl_ePLROP1.nHHCns = wl_nHHCns
            wl_ePLROP1.nMMCns = wl_nMMCns
            wl_ePLROP1.nTieCns = wl_nTieCns

            'Total Consumo Ope - Caf
            wl_nHHIni = wl_ePLROP1.nHHCnsCaf
            wl_nMMIni = wl_ePLROP1.nMMCnsCaf
            
            wl_nHHCns = 0
            wl_nMMCns = 0
            wl_nTieCns = 0
            mof_fCalTie(wl_nHHIni,
                       wl_nMMIni,
                       wl_nHHFin,
                       wl_nMMFin,
                       wl_nHHCns,
                       wl_nMMCns,
                       wl_nTieCns)
            wl_ePLROP1.nHHCns = wl_nHHCns
            wl_ePLROP1.nMMCns = wl_nMMCns
            wl_ePLROP1.nTieCns = wl_nTieCns

            'Total Línea

            wl_ePLROP1.nTotLin = wl_ePLROP1.nPreUni * wl_ePLROP1.nTieCns

            'Encabezados
            wl_ePEROP.nTotDoc = wl_ePLROP1.nTotLin
            wl_ePEROP.nTotHHOpe = wl_ePLROP1.nHHCnsOpe
            wl_ePEROP.nTotMMOpe = wl_ePLROP1.nMMCnsOpe
            wl_ePEROP.nTotTieOpe = wl_ePLROP1.nTieCnsOpe
            wl_ePEROP.nTotHHAlz = wl_ePLROP1.nHHCnsAlz
            wl_ePEROP.nTotMMAlz = wl_ePLROP1.nMMCnsAlz
            wl_ePEROP.nTotTieAlz = wl_ePLROP1.nTieCnsAlz
            wl_ePEROP.nTotHHCaf = wl_ePLROP1.nHHCnsCaf
            wl_ePEROP.nTotMMCaf = wl_ePLROP1.nMMCnsCaf
            wl_ePEROP.nTotTieCaf = wl_ePLROP1.nTieCnsCaf

            wl_ePEROP.nTotHHCns = wl_ePLROP1.nHHCns
            wl_ePEROP.nTotMMCns = wl_ePLROP1.nMMCns
            wl_ePEROP.nTotTieCns = wl_ePLROP1.nTieCns
        Catch ex As Exception
            MsgBox("Error : Plo_CalTie")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_VdaCerDoc()
        Try
            wl_bDocCrd = False
            If wl_ePEROP.sEstDoc <> "C" Then
                wl_bDocCrd = True
                wl_ePEROP.sEstDoc = "C"
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_VdaCerDoc")
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
            wl_ePEROP_Ini.dFecDoc = dtpFecDocIni.Value.ToShortDateString

        Catch ex As Exception
            MsgBox("Error :  dtpFecDocIni_ValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Try
            txtdHHMM.Text = TimeString.ToString
        Catch ex As Exception
            MsgBox("Error :  Timer1_Tick")
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