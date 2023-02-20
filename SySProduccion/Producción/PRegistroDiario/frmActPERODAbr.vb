Public Class frmActPERODAbr
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
    Dim wl_bDocCrd As Boolean
    Dim wl_bTF As Boolean
    Dim wl_bEOF1 As Boolean



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
    Dim wl_nHH As Integer
    Dim wl_nMM As Integer
    Dim wl_sHorSys As String
    Dim wl_nConReg As Integer
    Dim vl_sEstPdo As String


#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nId As Long
    Dim vl_sCodOpe As String
    Dim vl_sNomOpe As String
    Dim vl_nTieOpe As Double
    Dim vl_nUniTieOpe As Long
    Dim vl_bRegAci As Boolean
    Dim vl_sCodDoc As String
    Dim vl_sCodSer As String
    Dim vl_nNroDoc As Integer
    Dim vl_sEstDoc As String
    Dim vl_dFecDoc As Date
    Dim vl_sCodTer As String
    Dim vl_sNomTer As String
    Dim vl_nNroSig As Integer

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N

#End Region
#Region "014 Objetos locales"
    Dim clnATPOP As New ClaseNegocios.clnATPOP
    Dim clnATOPE As New ClaseNegocios.clnATOPE
    Dim clnATCTR As New ClaseNegocios.clnATCTR
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnPEODP As New ClaseNegocios.clnPEODP

    Dim wl_DTCbo As DataTable
    Dim wl_DTE1 As DataTable


    Dim clnTblAB As ClaseNegocios.clnTblAB

#End Region
#Region "015 Estructuras"
    Dim wl_aeATPOP() As moe_Estructuras.eATPOP
    Dim wl_eATPOP As New moe_Estructuras.eATPOP
    Dim wl_aeATOPE() As moe_Estructuras.eATOPE
    Dim wl_eATOPE As New moe_Estructuras.eATOPE
    Dim wl_eAPLND1 = New moe_Estructuras.eAPLND1
    Dim wl_ePEROP = New moe_Estructuras.ePEROP
    Dim wl_ePLROP1 = New moe_Estructuras.ePLROP1

#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
    Dim wl_sCodErrAdi As String
    Dim wl_sCodErrCon As String
    Dim wl_sCodErrOk As String
    Dim wl_sDesMsgEli As String
    Dim wl_sTitMsgEli As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmActPERODAbrir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            mof_IniciarVar()
            Plo_IniciarVar()
        Catch ex As Exception
            MsgBox("Error :  frmActPERODAbrir_Load")
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
#Region "042 BD Busquedas"
    Private Function BD_BuscarATOPE() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATOPE = New moe_Estructuras.eATOPE
            wr_bEOFE2 = mof_fConATOPE(vl_sCodOpe,
                                      wl_eATOPE)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATPOP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Sub BD_BuscarAPLND1()
        Try
            wl_eAPLND1 = New moe_Estructuras.eAPLND1
            wg_sTblLst1 = "APLND1"
            wr_bEOFLst1 = False
            wg_DTLst1 = clnConTbl.cndtSelSer(wg_sTblLst1,
                                         vl_sCodDoc,
                                         vl_sCodSer,
                                         wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                moo_eAPLND1_DT(wl_eAPLND1,
                           wg_DTLst1,
                           0)
                vl_nNroDoc = wl_eAPLND1.nNroSig
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarAPLND1")
        End Try
    End Sub
    Private Function BD_ConPEROP_Grl() As Boolean
        Try
            Dim wl_sNomTbl As String
            Dim wl_sMayMenIgu As String



            wr_bEOFE2 = True
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePEROP.sCodTer = vl_sCodTer
            wl_ePEROP.dFecDoc = vl_dFecDoc
            wl_ePEROP.sEstDoc = "A"
            wl_sNomTbl = "PEROP"
            wl_sMayMenIgu = "="
            wl_DTE1 = New DataTable
            wl_DTE1 = clnPEROP.cndtConPEROP_Grl(wl_sNomTbl,
                                                wl_ePEROP,
                                                wl_sMayMenIgu,
                                                wr_bEOFE2)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConPEROP_Grl")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmATOPE()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATOPE = New moe_Estructuras.eATOPE
            wg_sTblCon1 = "ATOPE"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATOPE.sCodOpe <> "" Then
                wl_eATOPE = wl_frmLst.wp_eATOPE
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmATOPE")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_frmaeATPOP()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATPOP = New moe_Estructuras.eATPOP
            ReDim wl_aeATPOP(0)
            ReDim wg_aeATPOP(0)
            wl_aeATPOP(0) = New moe_Estructuras.eATPOP
            wg_aeATPOP(0) = New moe_Estructuras.eATPOP
            wg_sTblCon1 = "ATPOP"

            wl_frmLst.ShowDialog()
            If Not IsNothing(wg_aeATPOP) Then
                If wg_aeATPOP.Length > 0 Then
                    If wg_aeATPOP(0).sCodTer <> "" Then
                        wl_aeATPOP = wg_aeATPOP
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_frmATPOP")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCrear_Click(sender As System.Object, e As System.EventArgs) Handles cmdCrear.Click
        Try
            vl_dFecDoc = dtpFecDocIni.Value
            wl_nHH = Int(txtnHHFinOpe.Text)
            wl_nMM = Int(txtnMMFinOpe.Text)
            wp_nBoxMsg = 4
            wp_sDesMsg = "Hora de Inicio :  " & wl_nHH & " - " & wl_nMM & "  .Está seguro de crear estos Registros?"
            wp_sTitMsg = "Mensaje del Sistema"
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)

            If wp_nResMsg = 6 Then
                If wl_eATOPE.sCodCtr <> "99" Then
                    MsgBox("Sólo puede seleccionar operaciones que comienzan por 99")
                    cmdLstATOPE.Focus()
                Else
                    Plo_CrearPEROP()
                    mof_ActivarOK(Me)
                End If
                cmdCancelar.Focus()
            End If
            cmdCancelar.Focus()

        Catch ex As Exception
            MsgBox("Error : cmdCrear_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdBuscar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOk_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdLstATPOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstATPOP.Click
        Try
            Dim wl_frmLst As New frmGQLst
            Plo_MueHHMM()
            BD_frmaeATPOP()

            If wl_eATPOP.sCodTer <> "" Then
                'Plo_ActCmd()
                mof_ActivarOK(Me)
            Else
                cmdLstATPOP.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en: cmdLstATOPE_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdLstATOPE_Click(sender As System.Object, e As System.EventArgs) Handles cmdLstATOPE.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmATOPE()
            If wl_eATOPE.sCodOpe <> "" Then
                txtsCodOpe.Text = wl_eATOPE.sCodOpe
                txtsNomOpe.Text = wl_eATOPE.sNomOpe
                mof_ActivarCrear(Me)
            Else
                txtsCodOpe.Text = ""
                txtsNomOpe.Text = ""
                mof_ActivarOK(Me)
            End If
        Catch ex As Exception
            MsgBox("Error en: cmdLstATOPE_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
   
#End Region

#Region "061 Otros Controladores de Eventos"
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            txtdHHMM.Text = TimeString.ToString
        Catch ex As Exception
            MsgBox("Error :  Timer1_Tick")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_CrearPEROP()
        Try
            Dim wl_nCntRow As Integer
            Dim wl_nI As Integer
            wl_nHH = Int(txtnHHFinOpe.Text)
            wl_nMM = Int(txtnMMFinOpe.Text)
            wl_nCntRow = wl_aeATPOP.Length
            wl_nConReg = 0
            For wl_nI = 0 To wl_nCntRow - 1
                wl_bDocCrd = True
                vl_sCodTer = wl_aeATPOP(wl_nI).sCodTer
                vl_sNomTer = wl_aeATPOP(wl_nI).sNomTer
                Plo_VdaDocCer()
                If wl_bDocCrd = False Then
                    MsgBox(vl_sCodTer & " - " & vl_sNomTer & " - " & vl_dFecDoc & " - Tiene Registro abierto")
                    wl_nConReg = wl_nConReg + 1
                End If
            Next
            If wl_nConReg > 0 Then
                MsgBox(wl_nConReg & "- Operarios no pueden ser creados. Proceso Cancelado")
                cmdCancelar.Focus()
            Else
                wl_nConReg = 0
                For wl_nI = 0 To wl_nCntRow - 1
                    wl_ePEROP = New moe_Estructuras.ePEROP
                    wl_ePLROP1 = New moe_Estructuras.ePLROP1
                    wl_bDocCrd = True
                    vl_sCodTer = wl_aeATPOP(wl_nI).sCodTer
                    vl_sNomTer = wl_aeATPOP(wl_nI).sNomTer
                    'Genera consecutivo
                    BD_BuscarAPLND1()
                    'Mover Var a PEROP 
                    Plo_ePEROP_Var()
                    'Mover Var a PLROP1
                    Plo_ePLROP1_Var()

                    wl_ePEROP.nNroDoc = vl_nNroDoc
                    wl_ePLROP1.nNroDoc = vl_nNroDoc

                    'Crea registro PEROP
                    'Plo_PEROP
                    '                    Plo_ePEROP_aePLEROP1()
                    '                    Plo_ePLROP1_aePLEROP1()
                    BD_CrearActualizarPEROP(wp_sCmdSel)
                    BD_CrearActualizarPLROP1(wp_sCmdSel)

                    'Suma 1 a  consecutivo
                    PloNroSig_APEND()
                    PloNroSig_APLND1()
                Next
                MsgBox("Proceso Terminado Exitosamente")
                Plo_IniciarVar()
                cmdCancelar.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_CrearPEROP")
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
    Private Sub Plo_IniciarVar()
        Try
            vl_sCodDoc = "ROK"
            vl_sCodSer = "RO"
            vl_nNroDoc = 0
            vl_sEstDoc = "A"
            wp_sCmdSel = "C"
            txtsCodOpe.Text = ""
            txtsNomOpe.Text = ""
            vl_sCodOpe = ""
            wl_nHH = 0
            wl_nMM = 0
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Plo_TxtsCodOpeKeyUp()
        Try
            vl_sCodOpe = txtsCodOpe.Text
            If vl_sCodOpe <> " " Then
                BD_BuscarATOPE()
                If wr_bEOFE2 Then
                    wp_sNomTbl = "ATOPE"
                    wp_sDatCmp = txtsCodOpe.Text
                    wp_sCodErr = "10-115"
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    txtsNomOpe.Text = ""
                    mof_ActivarOK(Me)
                    cmdCancelar.Focus()
                Else
                    txtsNomOpe.Text = wl_eATOPE.sNomOpe
                    mof_ActivarCrear(Me)
                    cmdCrear.Focus()
                End If
            Else
                cmdCancelar.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_TxtsCodOpeKeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_VdaDocCer()
        Try
            wl_bEOF = BD_ConPEROP_Grl()
            If wl_bEOF = False Then
                wl_bDocCrd = False
            Else
                wl_bDocCrd = True
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_VdaDocCer")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ePEROP_Var()
        Try
            wl_ePEROP.sCodDoc = vl_sCodDoc
            wl_ePEROP.sCodSer = vl_sCodSer
            wl_ePEROP.nNroDoc = vl_nNroDoc
            wl_ePEROP.sTipMov = "S"
            wl_ePEROP.sEstDoc = vl_sEstDoc
            wl_ePEROP.dFecCtb = vl_dFecDoc
            wl_ePEROP.dFecDoc = vl_dFecDoc
            wl_ePEROP.dFecVto = vl_dFecDoc
            wl_ePEROP.dFecSys = vl_dFecDoc
            wl_ePEROP.sCodTer = vl_sCodTer
            wl_ePEROP.sNomTer = vl_sNomTer
            wl_ePEROP.sDocRef = ""
            wl_ePEROP.nTotHHCns = 0
            wl_ePEROP.nTotMMCns = 0
            wl_ePEROP.nTotTieCns = 0
            wl_ePEROP.nTotDoc = 0
            wl_ePEROP.sCodCte = ""
            wl_ePEROP.nNroCte = 0
            wl_ePEROP.sClsDoc = "DP"
            wl_ePEROP.sCmn = ""
            wl_ePEROP.sCodCteCtb = ""
            wl_ePEROP.nNroCteCtb = 0
            wl_ePEROP.nIdFECCT = 0
            wl_ePEROP.sNitTer = ""
            wl_ePEROP.sTipDoc = ""
            wl_ePEROP.sCodUsr = ""
            wl_ePEROP.bPrp01 = False
            wl_ePEROP.bPrp02 = False
            wl_ePEROP.bPrp03 = False
            wl_ePEROP.nTotHHOpe = 0
            wl_ePEROP.nTotMMOpe = 0
            wl_ePEROP.nTotTieOpe = 0
            wl_ePEROP.nTotHHAlz = 0
            wl_ePEROP.nTotMMAlz = 0
            wl_ePEROP.nTotTieAlz = 0
            wl_ePEROP.nTotHHCaf = 0
            wl_ePEROP.nTotMMCaf = 0
            wl_ePEROP.nTotTieCaf = 0
        Catch ex As Exception
            MsgBox("Error : Plo_ePEROP_Var")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_ePLROP1_Var()
        Try
            wl_ePLROP1.sCodDoc = vl_sCodDoc
            wl_ePLROP1.nNroDoc = vl_nNroDoc
            wl_ePLROP1.sCodSer = vl_sCodSer
            wl_ePLROP1.sTipMov = "S"
            wl_ePLROP1.sCodDocBas = ""
            wl_ePLROP1.sCodSerBas = ""
            wl_ePLROP1.nNroDocBas = 0
            wl_ePLROP1.sCodItm = ""
            wl_ePLROP1.nCanItm = 0
            wl_ePLROP1.sCodOpe = wl_eATOPE.sCodOpe
            wl_ePLROP1.sNomOpe = wl_eATOPE.sNomOpe
            wl_ePLROP1.sClsDoc = "DP"
            wl_ePLROP1.nHHIniOpe = wl_nHH
            wl_ePLROP1.nMMIniOpe = wl_nMM
            wl_ePLROP1.nHHFinOpe = 0
            wl_ePLROP1.nMMFinOpe = 0
            wl_ePLROP1.nHHCnsOpe = 0
            wl_ePLROP1.nMMCnsOpe = 0
            wl_ePLROP1.nTieCnsOpe = 0
            wl_ePLROP1.nHHCns = 0
            wl_ePLROP1.nMMCns = 0
            wl_ePLROP1.nTieCns = 0
            wl_ePLROP1.nTieReq = 0
            wl_ePLROP1.nPreUni = 0
            wl_ePLROP1.nTotLin = 0
            wl_ePLROP1.sCodCco = ""
            wl_ePLROP1.nLinBas = 0
            wl_ePLROP1.sCodPdo = ""
            wl_ePLROP1.sCodCta = ""
            wl_ePLROP1.sCtaCosVta = ""
            wl_ePLROP1.bItmBlq = False
            wl_ePLROP1.nCanOpeTer = 0
            wl_ePLROP1.sCodCtr = wl_eATOPE.sCodCtr
            wl_ePLROP1.nHHIniAlz = 0
            wl_ePLROP1.nMMIniAlz = 0
            wl_ePLROP1.nHHFinAlz = 0
            wl_ePLROP1.nMMFinAlz = 0
            wl_ePLROP1.nHHCnsAlz = 0
            wl_ePLROP1.nMMCnsAlz = 0
            wl_ePLROP1.nTieCnsAlz = 0
            wl_ePLROP1.nHHIniCaf = 0
            wl_ePLROP1.nMMIniCaf = 0
            wl_ePLROP1.nHHFinCaf = 0
            wl_ePLROP1.nMMFinCaf = 0
            wl_ePLROP1.nHHCnsCaf = 0
            wl_ePLROP1.nMMCnsCaf = 0
            wl_ePLROP1.nTieCnsCaf = 0
        Catch ex As Exception
            MsgBox("Error : Plo_ePLROP1_Var")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub PloNroSig_APEND()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = vl_nNroDoc + 1

            wg_sNomTblE2 = "APEND"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = wl_ePEROP.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_ePEROP.sCodSer
            wg_sTipCmpE22 = "S"
            wp_sNomCmp = "nNroSig"
            wp_sDatCmp = vl_nNroSig
            wp_sTipCmp = "N"
            wr_bEOF = True
            wr_bEOF = clnActTbl.cndtActDosLlaUnCmp(wg_sNomTblE2,
                                                   wg_sNomCmpE21,
                                                   wg_sDatCmpE21,
                                                   wg_sTipCmpE21,
                                                   wg_sNomCmpE22,
                                                   wg_sDatCmpE22,
                                                   wg_sTipCmpE22,
                                                   wp_sNomCmp,
                                                   wp_sDatCmp,
                                                   wp_sTipCmp,
                                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : PloNroSig_APEND")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub PloNroSig_APLND1()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = vl_nNroDoc + 1
            wg_sNomTblE2 = "APLND1"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = wl_ePEROP.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_ePEROP.sCodSer
            wg_sTipCmpE22 = "S"
            wp_sNomCmp = "nNroSig"
            wp_sDatCmp = vl_nNroSig
            wp_sTipCmp = "N"

            wr_bEOF = True
            clnActTbl.cndtActDosLlaUnCmp(wg_sNomTblE2,
                                            wg_sNomCmpE21,
                                            wg_sDatCmpE21,
                                            wg_sTipCmpE21,
                                            wg_sNomCmpE22,
                                            wg_sDatCmpE22,
                                            wg_sTipCmpE22,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : PloNroSig_APLND1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "082 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"
    '  Private Sub txtsCodOpe_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCodOpe.KeyUp
    '      Try
    '          If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
    '              If vl_sCodOpe <> "" Then
    '                  Plo_TxtsCodOpeKeyUp()
    '              End If
    '          End If
    '      Catch ex As Exception
    '          MsgBox("Error : txtsCodOper_KeyUp")
    '          MsgBox(ex.Message)
    '      End Try
    '  End Sub

    Private Sub txtsCodOpe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodOpe.LostFocus
        Try
            If txtsCodOpe.Text <> "" Then
                Plo_TxtsCodOpeKeyUp()
            End If
        Catch ex As Exception
            MsgBox("Error : txtsCodOpe_LostFocus")
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