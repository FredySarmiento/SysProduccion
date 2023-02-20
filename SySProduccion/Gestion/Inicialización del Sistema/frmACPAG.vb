Public Class frmACPAG
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-10
#Region "001 Inicia. wg - vg Definición del variables públicas"
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"
    ' vl numéricas
    Dim wl_bCmpVdo As Boolean
    ' wl Booleanas
    Dim wl_bEdit As Boolean
    Dim wl_bEOF As Boolean
    Dim wl_bSwsBor As Boolean
    Dim wl_bSwsCbo As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bVdoCom As Boolean
    Dim wl_bVdoVta As Boolean
    Dim wl_bYesNo As Boolean
    ' wl numéricas
    Dim wl_nBoxMsg As Integer
    Dim wl_nResMsg As String
    Dim wl_nTab As Integer
    Dim wl_nVlr As Double


    Dim wl_sClaPPl1 As String
    Dim wl_sClaPPl2 As String
    Dim wl_sCod As String
    Dim wl_sCodDgv As String
    Dim wl_sDoc As String
    Dim wl_sNom As String
    Dim wl_sNomFrm As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNroALetras As String
    Dim wl_sTipTbl As String
    Dim wl_sClaPpl As String
    Dim wl_sDatCmpE11 As String
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
    Dim wl_sNomTblCbo As String


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



#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nId As Long
    Dim vl_sCodCia As String
    Dim vl_sCodUsr As String
    Dim vl_bLmtCre As Boolean
    Dim vl_sCndPagxDefCli As String
    Dim vl_sMetPagxDefCli As String
    Dim vl_sCndPagxDefPro As String
    Dim vl_sMetPagxDefPro As String
    Dim vl_sClrFrm As String
    Dim vl_sTipFont As String
    Dim vl_nTamFont As Long
    Dim vl_sForFec As String
    Dim vl_sForHor As String
    Dim vl_nNroDecPre As Long
    Dim vl_nNroDecCan As Long
    Dim vl_nNroDecPor As Long
    Dim vl_sCodAlmXDef As String
    Dim vl_sCriCtaCtb As String
    Dim vl_bVisItmIna As String
    Dim vl_sRutXls As String
    Dim vl_sTipRegTie As String
    Dim vl_sCodAlmCom As String
    Dim vl_bPrnODPPla As Boolean

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas

#End Region
#Region "014 Objetos locales"
    Dim clnACPAG As New ClaseNegocios.clnACPAG
    Dim wl_DTL1 As New DataTable

#End Region
#Region "015 Estructuras"
    Dim wl_aeACPAG() As moe_Estructuras.eACPAG
    Dim wl_eACPAG As New moe_Estructuras.eACPAG
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
    Private Sub frmACPAG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_AddHandlerVI()
            grl_AddHandlerVI()
            grl_EventCtrl(Me)
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            Plo_IniciarVar()
            Plo_IniciarFrm()
            Cbo_CargarLst()
            BD_BuscarACPAG()
            BD_eACPAG_DT(wl_DTL1)
            BD_Var_eACPAG()
            Plo_Frm_Var()

            mof_ActivarOK(Me)

        Catch ex As Exception
            MsgBox("Error :  frmACPAG_Load")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarABFMTFec()
            Cbo_CargarABFMTHH()
            Cbo_CargarABTRT()
            Cbo_CargarATALMInv()
            Cbo_CargarATALMCom()
            Cbo_CargarATCCC()
            Cbo_CargarACCLR()
            Cbo_CargarATCOPCli()
            Cbo_CargarATCOPProv()
            Cbo_CargarATMEPCli()
            Cbo_CargarATMEPProv()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarACCLR()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ACCLR"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACCLR.DataSource = wg_DTLst1
                cboACCLR.ValueMember = wg_DTLst1.Columns("sCodClr").Caption.ToString
                cboACCLR.DisplayMember = wg_DTLst1.Columns("sNomClr").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABCLR")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarABFMTFec()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABFMT"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABFMTFec.DataSource = wg_DTLst1
                cboABFMTFec.ValueMember = wg_DTLst1.Columns("sFmtFec").Caption.ToString
                cboABFMTFec.DisplayMember = wg_DTLst1.Columns("sFmtFec").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABFMTFec")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarABFMTHH()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABFMT"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABFMTHH.DataSource = wg_DTLst1
                cboABFMTHH.ValueMember = wg_DTLst1.Columns("sFmtHH").Caption.ToString
                cboABFMTHH.DisplayMember = wg_DTLst1.Columns("sFmtHH").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABFMTHH")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarABTRT()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABTRT"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABTRT.DataSource = wg_DTLst1
                cboABTRT.ValueMember = wg_DTLst1.Columns("sCodTipRegTie").Caption.ToString
                cboABTRT.DisplayMember = wg_DTLst1.Columns("sNomTipRegTie").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABTRT")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATALMCom()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATALM"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATALMCom.DataSource = wg_DTLst1
                cboATALMCom.ValueMember = wg_DTLst1.Columns("sCodAlm").Caption.ToString
                cboATALMCom.DisplayMember = wg_DTLst1.Columns("sNomAlm").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATALMCom")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATALMInv()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATALM"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATALMInv.DataSource = wg_DTLst1
                cboATALMInv.ValueMember = wg_DTLst1.Columns("sCodAlm").Caption.ToString
                cboATALMInv.DisplayMember = wg_DTLst1.Columns("sNomAlm").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATALMInv")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cbo_CargarATCCC()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATCCC"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATCCC.DataSource = wg_DTLst1
                cboATCCC.ValueMember = wg_DTLst1.Columns("sCriCtaCbe").Caption.ToString
                cboATCCC.DisplayMember = wg_DTLst1.Columns("sCriCtaCbe").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATCCC")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATCOPCli()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATCOP"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATCOPCli.DataSource = wg_DTLst1
                cboATCOPCli.ValueMember = wg_DTLst1.Columns("sCndPag").Caption.ToString
                cboATCOPCli.DisplayMember = wg_DTLst1.Columns("sCndPag").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATCOPCli")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATCOPProv()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATCOP"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATCOPProv.DataSource = wg_DTLst1
                cboATCOPProv.ValueMember = wg_DTLst1.Columns("sCndPag").Caption.ToString
                cboATCOPProv.DisplayMember = wg_DTLst1.Columns("sCndPag").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATCOPCli")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATMEPCli()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATMEP"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATMEPCli.DataSource = wg_DTLst1
                cboATMEPCli.ValueMember = wg_DTLst1.Columns("sCodMetPag").Caption.ToString
                cboATMEPCli.DisplayMember = wg_DTLst1.Columns("sNomMetPag").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATMEPCli")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATMEPProv()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATMEP"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATMEPProv.DataSource = wg_DTLst1
                cboATMEPProv.ValueMember = wg_DTLst1.Columns("sCodMetPag").Caption.ToString
                cboATMEPProv.DisplayMember = wg_DTLst1.Columns("sNomMetPag").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATMEPProv")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            Plo_Var_Frm()
            BD_eACPAG_Var()
            wl_bYesNo = clnACPAG.cnCrearActACPAG(wl_eACPAG,
                                                 wr_bEOFE1,
                                                 wp_sCmdSel)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function

    Private Sub BD_DatPrmTipTbl(ByRef wl_sTipTbl As String)
        Try
            wl_sNomTblE1 = "ACPAG"
            wl_sNomCmpE11 = "sCodCia"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código CIA "
            wl_sDatCmpE11 = vg_sCodcia
            wl_sClaPPl1 = wl_sDatCmpE11
            wr_bEOFE1 = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_DatPrmTipTbl")
        End Try
    End Sub
    Private Sub BD_DatPrmTSB() 'Constante
        Try
            '1 nId
            '2 NroDoc
            '3. CodDoc + NroDoc
            '4 Cod

            wl_nCmpCla = 4
            wl_sCmpTSB1 = "sCodCia"
            wl_sDatTSB = ""
            wl_sTipCmpTSB = "S"
            wl_sTipCmpTSB1 = "S"
            wl_sCmpTSB2 = ""
            wl_sTipCmpTSB2 = ""
            Select Case wl_nCmpCla
                Case 1
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_eACPAG.nID
                    wl_sTipCmpTSB = "N"

                Case 2
                    wl_sCmpTSB = wl_sCmpTSB2
                    wl_sDatTSB = wl_sClaPpl
                    wl_sTipCmpTSB = "N"
                Case 3
                    wl_sDatTSB1 = wl_sClaPPl1
                    wl_sTipCmpTSB1 = "S"
                    wl_sDatTSB2 = wl_sClaPPl2
                    wl_sTipCmpTSB2 = "N"
                Case 4
                    wl_sCmpTSB = wl_sCmpTSB1
                    wl_sDatTSB = wl_sClaPpl
                    wl_sTipCmpTSB = "S"
            End Select
        Catch ex As Exception
            MsgBox("Error :  BD_DatPrmTSB")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BD_eACPAG_Var()
        Try
            With wl_eACPAG
                .sCodCia = vl_sCodCia
                .sCodUsr = vg_sCodUsr
                .bLmtCre = vl_bLmtCre
                .sCndPagxDefCli = vl_sCndPagxDefCli
                .sMetPagxDefCli = vl_sMetPagxDefCli
                .sCndPagxDefPro = vl_sCndPagxDefPro
                .sMetPagxDefPro = vl_sMetPagxDefPro
                .sClrFrm = vl_sClrFrm
                .sTipFont = vl_sTipFont


                .sForFec = vl_sForFec
                .sForHor = vl_sForHor
                .nNroDecPre = vl_nNroDecPre
                .nNroDecCan = vl_nNroDecCan
                .nNroDecPor = vl_nNroDecPor
                .sCodAlmCom = vl_sCodAlmCom
                .sCodAlmXDef = vl_sCodAlmXDef
                .sCriCtaCtb = vl_sCriCtaCtb
                .bVisItmIna = vl_bVisItmIna
                .sRutXls = vl_sRutXls
                .sTipRegTie = vl_sTipRegTie
                .bPrnODPPla = vl_bPrnODPPla
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eACPAG_Var")
        End Try
    End Sub
    Private Sub BD_Var_eACPAG()
        Try
            With wl_eACPAG
                vl_sCodCia = .sCodCia
                vl_bLmtCre = .bLmtCre
                vl_sCndPagxDefCli = .sCndPagxDefCli
                vl_sMetPagxDefCli = .sMetPagxDefCli
                vl_sCndPagxDefPro = .sCndPagxDefPro
                vl_sMetPagxDefPro = .sMetPagxDefPro
                vl_sClrFrm = .sClrFrm
                vl_sForFec = .sForFec
                vl_sForHor = .sForHor
                vl_nNroDecPre = .nNroDecPre
                vl_nNroDecCan = .nNroDecCan
                vl_nNroDecPor = .nNroDecPor
                vl_sCodAlmCom = .sCodAlmCom
                vl_sCodAlmXDef = .sCodAlmXDef
                vl_sCriCtaCtb = .sCriCtaCtb
                vl_bVisItmIna = .bVisItmIna
                vl_sRutXls = .sRutXls
                vl_sTipRegTie = .sTipRegTie
                vl_bPrnODPPla = .bPrnODPPla
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eACPAG")
        End Try
    End Sub
    Private Sub BD_eACPAG_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eACPAG = New moe_Estructuras.eACPAG
            moo_eACPAG_DT(wl_eACPAG,
                          wp_DTE1)
            wl_sDatCmpE12 = vg_sCodcia
        Catch ex As Exception
            MsgBox("Error :  BD_eACPAG_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try
    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarACPAG() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eACPAG = New moe_Estructuras.eACPAG
            wl_DTL1 = New DataTable
            wl_eACPAG.sCodCia = vl_sCodCia
            wl_eACPAG.sCodUsr = vg_sCodUsr
            wl_DTL1 = clnACPAG.cndtConACPAG(wl_eACPAG,
                                            wr_bEOFE2)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarACPAG")
        End Try
        Return wr_bEOFE2
    End Function

#End Region
#Region "043 BD Cargar"

#End Region
#Region "045 BD Llamar frm"

#End Region
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            wp_sCmdSel = "A"
            wl_bYesNo = False
            wr_bEOFE1 = True

            wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
            If wl_bYesNo Then
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = ""
                wp_sCodErr = wl_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                Plo_InactCmpAct()
                mof_ActivarOK(Me)
                cmdOk.Focus()
            Else
                cmdCancelar.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error :  cmdActualizar_Click")
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
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdOk_Click")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region
#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActivarCmpAct()
        Try
            cboACCLR.Enabled = True
            cboABFMTHH.Enabled = True
            cboABFMTFec.Enabled = True
            cboABTRT.Enabled = True
            cboATALMInv.Enabled = True
            cboATCCC.Enabled = True
            cboATCOPCli.Enabled = True
            cboATCOPProv.Enabled = True
            cboATMEPCli.Enabled = True
            cboATMEPProv.Enabled = True
            chbbLmtCre.Enabled = True
            chbbVisItmIna.Enabled = True
            txtnNroDecCan.Enabled = True
            txtnNroDecPre.Enabled = True
            txtnNroDecPor.Enabled = True
            txtsRutXls.Enabled = True
            chbbPrnODPPla.Enabled = True


        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_ActivarCrear()
        mof_ActivarActualizar(Me)
    End Sub
    Private Sub Plo_InactCmpAct()
        Try
            cboACCLR.Enabled = False
            cboABFMTHH.Enabled = False
            cboABFMTFec.Enabled = False
            cboABTRT.Enabled = False
            cboATALMInv.Enabled = False
            cboATCCC.Enabled = False
            cboATCOPCli.Enabled = False
            cboATCOPProv.Enabled = False
            cboATMEPCli.Enabled = False
            cboATMEPProv.Enabled = False
            chbbLmtCre.Enabled = False
            chbbVisItmIna.Enabled = False
            txtnNroDecCan.Enabled = False
            txtnNroDecPre.Enabled = False
            txtnNroDecPor.Enabled = False
            txtsRutXls.Enabled = False
            chbbPrnODPPla.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpAct")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_bYesNo = False
            wl_bEdit = False
            wl_sNomFrm = "frmACPAG"
            mof_ActivarOK(Me)
            cmdOk.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarFrm")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_bEdit = False
            wl_sNomFrm = "frmACPAG"
            vl_sCodCia = vg_sCodcia
            vl_bLmtCre = False
            vl_sCndPagxDefCli = ""
            vl_sMetPagxDefCli = ""
            vl_sCndPagxDefPro = ""
            vl_sMetPagxDefPro = ""
            vl_sClrFrm = ""
            vl_sForHor = ""
            vl_sForFec = ""
            vl_nNroDecPre = 0
            vl_nNroDecPre = 0
            vl_nNroDecPor = 0
            vl_sCodAlmCom = ""
            vl_sCodAlmXDef = ""
            vl_bVisItmIna = False
            vl_sRutXls = ""
            vl_sTipRegTie = ""
            vl_bPrnODPPla = False
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_Frm_Var()
        Try
            cboATCCC.SelectedValue = vl_sCriCtaCtb
            chbbLmtCre.Checked = vl_bLmtCre
            cboATCOPCli.SelectedValue = vl_sCndPagxDefCli
            cboATMEPCli.SelectedValue = vl_sMetPagxDefCli
            cboATCOPProv.SelectedValue = vl_sCndPagxDefPro
            cboATMEPProv.SelectedValue = vl_sMetPagxDefPro
            cboACCLR.SelectedValue = vl_sClrFrm
            cboABFMTHH.SelectedValue = vl_sForHor
            cboABFMTFec.SelectedValue = vl_sForFec
            txtnNroDecPre.Text = FormatNumber(vl_nNroDecPre)
            txtnNroDecCan.Text = FormatNumber(vl_nNroDecCan)
            txtnNroDecPor.Text = FormatNumber(vl_nNroDecPor)
            cboATALMCom.SelectedValue = vl_sCodAlmCom
            cboATALMInv.SelectedValue = vl_sCodAlmXDef
            chbbVisItmIna.Checked = vl_bVisItmIna
            txtsRutXls.Text = vl_sRutXls
            cboABTRT.SelectedValue = vl_sTipRegTie
            chbbPrnODPPla.Checked = vl_bPrnODPPla
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Frm_Var")
        End Try
    End Sub
    Private Sub Plo_Var_Frm()
        Try
            vl_sCriCtaCtb = cboATCCC.SelectedValue
            vl_bLmtCre = chbbLmtCre.Checked
            vl_sCndPagxDefCli = cboATCOPCli.SelectedValue
            vl_sMetPagxDefCli = cboATMEPCli.SelectedValue
            vl_sCndPagxDefPro = cboATCOPProv.SelectedValue
            vl_sMetPagxDefPro = cboATMEPProv.SelectedValue
            vl_sClrFrm = cboACCLR.SelectedValue
            vl_sForHor = cboABFMTHH.SelectedValue
            vl_sForFec = cboABFMTFec.SelectedValue
            vl_nNroDecPre = CLng(txtnNroDecPre.Text)
            vl_nNroDecPre = CLng(txtnNroDecCan.Text)
            vl_nNroDecPor = CLng(txtnNroDecPor.Text)
            vl_sCodAlmCom = cboATALMCom.SelectedValue
            vl_sCodAlmXDef = cboATALMInv.SelectedValue
            vl_bVisItmIna = chbbVisItmIna.Checked
            vl_sRutXls = txtsRutXls.Text
            vl_sTipRegTie = cboABTRT.SelectedValue
            vl_bPrnODPPla = chbbPrnODPPla.Checked
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Var_Frm")
        End Try
    End Sub
#End Region
#End Region

#Region "PROCEDIMIENTOS EVENTOS COMUNES"

#Region "110 grl Changed"
    Private Sub grl_Cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Chb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_mtb_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Txt_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DirectCast(sender, TextBox).Name = "txt_sCodItm" Then
            'wg_sClaPpl = txtsCodItm.Text
            mof_LmpMsgError()
        Else
            grl_TextChange()
        End If
    End Sub
#End Region
#Region "120 grl Eventos"
    Public Sub grl_EventCtrl(ByVal wp_VlrCtrl As Control)
        For Each oCtrl As Object In wp_VlrCtrl.Controls
            If TypeOf oCtrl Is ComboBox Then
                AddHandler DirectCast(oCtrl, ComboBox).GotFocus, AddressOf grl_Cbo_GotFocus
                AddHandler DirectCast(oCtrl, ComboBox).LostFocus, AddressOf grl_Cbo_LostFocus
                AddHandler DirectCast(oCtrl, ComboBox).SelectedIndexChanged, AddressOf grl_Cbo_SelectedIndexChanged
            End If
            If TypeOf oCtrl Is CheckBox Then
                AddHandler DirectCast(oCtrl, CheckBox).GotFocus, AddressOf grl_Chb_GotFocus
                AddHandler DirectCast(oCtrl, CheckBox).LostFocus, AddressOf grl_Chb_LostFocus
                AddHandler DirectCast(oCtrl, CheckBox).CheckedChanged, AddressOf grl_Chb_CheckedChanged
            End If
            If TypeOf oCtrl Is MaskedTextBox Then
                AddHandler DirectCast(oCtrl, MaskedTextBox).GotFocus, AddressOf grl_mtb_GotFocus
                AddHandler DirectCast(oCtrl, MaskedTextBox).LostFocus, AddressOf grl_mtb_LostFocus
                AddHandler DirectCast(oCtrl, MaskedTextBox).TextChanged, AddressOf grl_mtb_Changed
            End If
            If TypeOf oCtrl Is RadioButton Then
                AddHandler DirectCast(oCtrl, RadioButton).GotFocus, AddressOf grl_Rdb_GotFocus
                AddHandler DirectCast(oCtrl, RadioButton).LostFocus, AddressOf grl_Rdb_LostFocus
                AddHandler DirectCast(oCtrl, RadioButton).CheckedChanged, AddressOf grl_Rdb_CheckedChanged
            End If
            If TypeOf oCtrl Is TextBox Then
                AddHandler DirectCast(oCtrl, TextBox).GotFocus, AddressOf grl_Txt_GotFocus
                AddHandler DirectCast(oCtrl, TextBox).LostFocus, AddressOf grl_Txt_LostFocus
                AddHandler DirectCast(oCtrl, TextBox).TextChanged, AddressOf grl_Txt_Changed
            End If

            If TypeOf oCtrl Is GroupBox Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is Panel Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is SplitContainer Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabControl Then
                grl_EventCtrl(oCtrl)
            End If
            If TypeOf oCtrl Is TabPage Then
                grl_EventCtrl(oCtrl)
            End If
        Next
    End Sub
    Private Sub grl_AddHandlerVI()
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
    End Sub
    Private Sub grl_RemoveHandlerVI()
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        RemoveHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
    End Sub
#End Region
#Region "130 grl Got Focus"
    Private Sub grl_Cbo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Chb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_mtb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrGot
        DirectCast(sender, MaskedTextBox).SelectionStart = 0
        DirectCast(sender, MaskedTextBox).SelectionLength = DirectCast(sender, MaskedTextBox).Text.Length
    End Sub
    Private Sub grl_Rdb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = wg_ClrGot
        DirectCast(sender, TextBox).SelectionStart = 0
        DirectCast(sender, TextBox).SelectionLength = DirectCast(sender, TextBox).Text.Length
    End Sub
#End Region
#Region "140 grl Lost Focus"
    Private Sub grl_Cbo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Chb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_mtb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim wl_cvMTB As Control = ActiveControl
        wl_cvMTB = GetNextControl(wl_cvMTB, False)
        If cmdCancelar.Focused = False Then
            If wl_cvMTB IsNot Nothing Then
                If wl_cvMTB.Name = "mtbsCodItm" Then

                End If
            End If
        End If

        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrLost


    End Sub
    Private Sub grl_Rdb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        '     Dim wl_cvTxt As Control = ActiveControl
        '    wl_cvTxt = GetNextControl(wl_cvTxt, False)
        '    If cmdCancelar.Focused = False Then
        ' If wl_cvTxt IsNot Nothing Then
        ' If wl_cvTxt.Name = "TxtCodBar" Then
        ' mov_VdaTxt(wl_bVda,
        '            TxtCodBar)
        ' End If
        ' End If
        ' End If
        DirectCast(sender, TextBox).BackColor = wg_ClrLost
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
    End Sub
    Public Sub grl_TextChange()
        If cmdOk.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region

#Region "160 TSB ToolStrip Procedimientos eventos de la barra de herramientas:BCPASUE"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
    End Sub
    Private Sub tsb_Primero()


        mof_fLmpCtrl(Me)
        BD_DatPrmTSB()
        ' mof_ActivarOK(Me)

        wr_bEOFE1 = True
        Try
            If wl_sNomTblE1 <> "" Then
                If wg_sTipTbl = "E1" Then
                    wg_DTE1 = clnConTbl.cndtPrimero(wl_sNomTblE1,
                                                    wg_sCmpTSB,
                                                    wg_sDatTSB,
                                                    wr_bEOFE1)

                End If
                If wg_sTipTbl = "E2" Then
                    wg_DTE1 = clnConTbl.cndtPrimeroMov(wl_sNomTblE1,
                                                       wg_sNomCmpE11,
                                                       wg_sDatCmpE11,
                                                       wg_sTipCmpE11,
                                                       wg_sNomCmpE12,
                                                       wg_sDatCmpE12,
                                                       wg_sTipCmpE12,
                                                       wr_bEOFE1)
                End If
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Primero")
        End Try

    End Sub
    Private Sub tsb_Anterior()
        mof_fLmpCtrl(Me)
        BD_DatPrmTSB()
        mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try

            If wl_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtAnterior(wl_sNomTblE1,
                                                wg_sCmpTSB,
                                                wg_sDatTSB,
                                                wg_sTipCmpTSB,
                                                wr_bEOFE1)
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                Else
                    tsb_Ultimo()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Anterior")
        End Try

    End Sub
    Private Sub tsb_Siguiente()
        mof_fLmpCtrl(Me)
        BD_DatPrmTSB()
        mof_ActivarOK(Me)

        wr_bEOFE1 = True
        Try
            If wl_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtSiguiente(wl_sNomTblE1,
                                                  wg_sCmpTSB,
                                                  wg_sDatTSB,
                                                  wg_sTipCmpTSB,
                                                  wr_bEOFE1)
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                Else
                    tsb_Primero()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Siguiente")
        End Try

    End Sub
    Private Sub tsb_Ultimo()
        mof_fLmpCtrl(Me)
        BD_DatPrmTSB()
        mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            If wl_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtUltimo(wl_sNomTblE1,
                                                wg_sCmpTSB,
                                                wg_sDatTSB,
                                                wr_bEOFE1)
                If Not wr_bEOFE1 Then
                    BD_tsbPASU()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Ultimo")
        End Try
    End Sub
    Public Sub tsb_Crear()
        mof_fLmpCtrl(Me)
        Plo_ActivarCrear()

    End Sub
    Public Sub tsb_Eliminar()
        mof_ActivarEliminar(Me)
    End Sub
#End Region
#Region "161 TSB ToolStrip Procedimientos eventos de la barra de herramientas:VI"
    Private Sub tsb_VistaPrevia()
        MsgBox("Vista Previa")
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
#End Region
#Region "170 TSMI ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
    End Sub
    Private Sub tsmi_EliminarLinea()
        mof_ActivarEliminar(Me)
    End Sub
    Private Sub tsmi_Eliminar()
        mof_ActivarActualizar(Me)

    End Sub

#End Region

#End Region


End Class