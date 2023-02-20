Imports System.Data.OleDb
Imports System.Data


Public Class frmTEDMT
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#Region "001 Inicia. wg - vg Definición del variables públicas"
    Public Property vp_sCodTer As String
#End Region
#Region "011 frm - Variables Locales"
    ' Booleanas
    Dim wl_bVda As Boolean
    Dim vl_bEOF1 As Boolean
    ' Cadenas
    Dim wl_sCodPrm As String
    Dim wl_sTipTbl As String
    Dim wl_sCmdAnt As String
    ' Numéricas
#End Region
#Region "012 BD - Variables campos BD Locales"
    ' Variables Campos de la BD

    Dim vp_nId As Long '0
    Dim vl_sCodTer As String '1
    Dim vp_sNomTer As String '2
    Dim vp_sTipTer As String '3
    Dim vp_sNitTer As String '4
    Dim vp_sDigVer As String '5
    Dim vp_sDirTer As String '6
    Dim vp_sTel1Ter As String '7
    Dim vp_sTel2Ter As String '8
    Dim vp_sTelCll As String '9
    Dim vp_sFax As String '10
    Dim vp_sNomAlt As String '11
    Dim vp_sCodGrpTer As String '12
    Dim vp_sEmlTer As String '13
    Dim vp_sNomCtc As String '14
    Dim vp_sTipCtaCtb As String '15
    Dim vp_sCodCtaCtb As String '16
    Dim vp_sCndPag As String '17
    Dim vp_sCodLstPre As String '18
    Dim vp_nPorDto As Double '19
    Dim vp_nLimCre As Double '20
    Dim vp_bAct As Boolean '21
    Dim vp_bIna As Boolean '22

    Dim vp_sDirTerAlt As String '2
    Dim vp_sCiuTer As String '3
    Dim vp_sDepTer As String '4
    Dim vp_sPaiTer As String '5
    Dim vp_bDirDfl As Boolean '6

    Dim vp_sCodRet As String '2

    Dim vp_sCodIVA As String '2

    Dim vp_sTipDoc As String '2
    Dim vp_sMMNomTer As String '3
    Dim vp_sMMPriNom As String '4
    Dim vp_sMMSegNom As String '5
    Dim vp_sMMPriApe As String '6
    Dim vp_sMMSegApe As String '7
    Dim vp_sMMDirTer As String '8
    Dim vp_sMMCodDep As String '9
    Dim vp_sMMCodCiu As String '10
    Dim vp_sMMCodPai As String '11
    Dim vp_dMMFecRUT As Date '12
    Dim vp_sMMCodAcePpl As String '13
    Dim vp_sMMCodAceScn As String '14
    Dim dgv1 As New DataGridView


#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    Dim wp_bVisible As Boolean
    Dim wp_bReadOnly As Boolean
    Dim wl_bYesNo As Boolean
    Dim wl_bEdit As Boolean
    'cadena
    Dim wl_sOpeLgc As String
    'Columnas
    Dim wl_nTab As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColFin As Integer
    Dim wl_nTotCol As Integer
    Dim wl_nCol As Integer
    Dim wl_nColAnt As Integer
    Dim wp_sTipCol As String 'N = numérico. C = pesos. S = string. d = fecha
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_nColVda1 As Integer  'columna a validar 1
    Dim wl_nColVda2 As Integer  'columna a validar 2
    Dim vl_nTamCmp As Integer
    'Filas
    Dim wl_nRowAlto As Integer

    Dim wl_nRowIni As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nCntRow As Integer
    Dim wl_nRow As Integer
    'Dim wl_RowAlto As Integer
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fila
#End Region
#Region "014 Objetos locales"
    Dim clnTEDMT As New ClaseNegocios.clnTEDMT

    Dim wl_tbp As New TabPage
#End Region
#Region "015 Estructuras"
    Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
    Dim wl_eLEDMT1 As New moe_Estructuras.eTLDMT1
    Dim wl_eLEDMT2 As New moe_Estructuras.eTLDMT2
    Dim wl_eLEDMT3 As New moe_Estructuras.eTLDMT3
    Dim wl_eLEDMT4 As New moe_Estructuras.eTLDMT4
#End Region
#Region "018 Errores"
    'Código de error

    '10-108 Código de tercero no existe
    '10-208 Falta código de tercero 
    '10-308 Código de tercero ya existe
    '10-318 Ítem + Tercero ya existe
    '10-408 Código de tercero es obligatorio
    '20-001 Operación  finalizada con éxito

    Dim wl_sNomtbl As String
    Dim wl_sDatCmp As String
    Dim wl_sCoderr As String
    Dim wl_sCodErrNoEx As String = "10-108"
    Dim wl_sCodErrSinCod As String = "10-208"
    Dim wl_sCodErrItm_Ter As String = "10-318"
    Dim wl_sCodErrYaEx1 As String = "10-308"
    Dim wl_sCodErrObl As String = "10-408"
    Dim wl_sCodErrOk As String = "20-001"



#End Region

#Region "019 Fin 010.  vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#End Region

#Region "020 frm Eventos - Principal"
    Private Sub frmTEDMT_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        grl_RemoveHandler()
    End Sub

    Private Sub frmTEDMT_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtsCodTer.Focus()
    End Sub


    Private Sub frmTEDMT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text += "  -  " + vg_sNomCia
        wp_sNomFrm = "frmTEDMT"
        grl_RemoveHandler()
        grl_AddHandler()
        mof_fCnfCtrl(Me)
        mof_IniciarVar()
        Plo_IniciarDoc()
        Plo_IniciarVar()

        wl_sTipTbl = "E1"
        wg_sTipTbl = wl_sTipTbl
        BD_DatPrmTipTbl(wg_sTipTbl)

        'dgv_APDGV()
        'Plo_IniciarVarDGV()
        grl_EventCtrl(Me)
        Cbo_CargarLista()
        mof_fLmpCtrl(Me)
        Plo_ActivarBuscar()

        If vp_sCodTer <> "" Then
            txtsCodTer.Text = vp_sCodTer
            cmdBuscar_Click(Nothing,
                            Nothing)
        End If




    End Sub
#End Region
#Region "030 Cbo Llenar Combobox"
    Private Sub Cbo_CargarLista()
        Try

            '1
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABTIT"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboTTGRP.DataSource = wg_DTLst1
                cboTTGRP.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
                cboTTGRP.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
            End If
            '2
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATCOP"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATCOP.DataSource = wg_DTLst1
                cboATCOP.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboATCOP.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString

            End If
            '3
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "IELIP"
            wr_bEOFLst1 = wr_bEOFLst1
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboIELIP.DataSource = wg_DTLst1
                cboIELIP.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboIELIP.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString

            End If
            '4
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "WTTID"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboWTTID.DataSource = wg_DTLst1
                cboWTTID.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboWTTID.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString

            End If
            '5
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "WTCIU"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboWTCIU.DataSource = wg_DTLst1
                cboWTCIU.ValueMember = wg_DTLst1.Columns(2).Caption.ToString
                cboWTCIU.DisplayMember = wg_DTLst1.Columns(3).Caption.ToString

            End If
            '6
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "WTDEP"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboWTDEP.DataSource = wg_DTLst1
                cboWTDEP.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboWTDEP.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString

            End If
            '7
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "WTPAI"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboWTPAI.DataSource = wg_DTLst1
                cboWTPAI.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboWTPAI.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString

            End If
            '8
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "WTCAE"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboWTCAEPpl.DataSource = wg_DTLst1
                cboWTCAEPpl.ValueMember = wg_DTLst1.Columns("sCodAce").Caption.ToString
                cboWTCAEPpl.DisplayMember = wg_DTLst1.Columns("sNomAce").Caption.ToString
            End If
            '9
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "WTCAE"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboWTCAEScn.DataSource = wg_DTLst1
                cboWTCAEScn.ValueMember = wg_DTLst1.Columns("sCodAce").Caption.ToString
                cboWTCAEScn.DisplayMember = wg_DTLst1.Columns("sNomAce").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarLista")
        End Try

    End Sub
#End Region

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        Try
            ' Tipo de tabla
            If wg_sTipTbl = "E1" Then
                wg_sNomTblE1 = "TEDMT"
                wg_sNomCmpE11 = "sCodTer"
                wg_sTipCmpE11 = "C"
                wg_sTitCmpE11 = "Código tercero "
                wg_sDatCmpE11 = txtsCodTer.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "L1" Then
                wg_sNomTblL1 = "TLDMT1"
                wg_sNomCmpL11 = "sCodTer"
                wg_sTipCmpL11 = "C"
                wg_sTitCmpL11 = "Código tercero "
                wg_sDatCmpL11 = txtsCodTer.Text
                wg_sNomCmpL12 = ""
                wg_sTipCmpL12 = ""
                wg_sTitCmpL12 = ""
                wg_sDatCmpL11 = ""
                wr_bEOFL1 = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_DatPrmTipTbl")
        End Try
    End Sub
    Private Sub BD_DatPrmTSB() 'Constante
        Try
            wg_nCmpCla = 2
            wg_sCmpTSB = ""
            wg_sDatTSB = ""
            wg_sCmpTSB1 = "nId"
            wg_sCmpTSB2 = "sCodTer"

            Select Case wg_nCmpCla
                Case 1
                    wg_sCmpTSB = wg_sCmpTSB1
                    wg_sDatTSB = vp_nId
                    wg_sTipCmpTSB = "N"

                Case 2
                    wg_sCmpTSB = wg_sCmpTSB2
                    wg_sDatTSB = wg_sClaPpl
                    wg_sTipCmpTSB = "C"
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_DatPrmTSB")
        End Try

    End Sub

    Private Function BD_BuscarTLDMT1() As Boolean
        Try
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_sNomTblE2 = "TLDMT1"
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
            MsgBox("Error en el SUB: BD_BuscarTLDMT1")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarTLDMT2() As Boolean
        Try
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_sNomTblE2 = "TLDMT2"
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
            MsgBox("Error en el SUB: BD_BuscarTLDMT2")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarTLDMT3() As Boolean
        Try
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_sNomTblE2 = "TLDMT3"
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
            MsgBox("Error en el SUB: BD_BuscarTLDMT3")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarTLDMT4() As Boolean
        Try
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_sNomTblE2 = "TLDMT4"
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
            MsgBox("Error en el SUB: BD_BuscarTLDMT4")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        wl_sNomtbl = "TEDMT"
        wl_sDatCmp = "sCodTer"
        wl_sCoderr = wl_sCodErrObl


        Try
            BD_eTEDMT_Var()
            If mov_VdaDatVio(wl_bYesNo,
                                 txtsCodTer.Text) Then
                mof_MsgError(wl_sNomtbl,
                             wl_sDatCmp,
                             wl_sCoderr)
                txtsCodTer.Focus()
            Else

                wl_bYesNo = False
                wl_bYesNo = clnTEDMT.cnCrearActualizar(wg_eTEDMT,
                                                       wr_bEOFE1,
                                                       wp_sCmdSel)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmd_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Function BD_CrearActualizarTLDMT1(ByVal wp_sCmdSel As String) As Boolean

        wl_bYesNo = False
        wl_sNomtbl = "TLDMT1"
        wl_sDatCmp = "sCodTer"
        wl_sCoderr = wl_sCodErrObl

        Try
            wl_bYesNo = BD_BuscarTLDMT1()
            If wl_bYesNo = True Then
                wp_sCmdSel = "C"
            Else
                wp_sCmdSel = "A"
            End If
            BD_eTLDMT1_Var()
            wl_bYesNo = False
            wl_bYesNo = clnTEDMT.cnCrearActualizarTLDMT1(wg_eTLDMT1,
                                                         wr_bEOFE2,
                                                         wp_sCmdSel)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizarTLDMT1")
        End Try
        wp_sCmdSel = wl_sCmdAnt
        Return wl_bYesNo
    End Function
    Private Function BD_CrearActualizarTLDMT2(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        wl_sNomtbl = "TLDMT2"
        wl_sDatCmp = "sCodTer"

        Try


            wl_bYesNo = BD_BuscarTLDMT2()
            If wl_bYesNo = True Then
                wp_sCmdSel = "C"
            Else
                wp_sCmdSel = "A"
            End If
            BD_eTLDMT2_Var()
            wl_bYesNo = False
            wl_bYesNo = clnTEDMT.cnCrearActualizarTLDMT2(wg_eTLDMT2,
                                                         wr_bEOFE2,
                                                         wp_sCmdSel)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizarTLDMT2")
        End Try
        wp_sCmdSel = wl_sCmdAnt
        Return wl_bYesNo
    End Function
    Private Function BD_CrearActualizarTLDMT3(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        wl_sNomtbl = "TLDMT3"
        wl_sDatCmp = "sCodTer"

        Try


            wl_bYesNo = BD_BuscarTLDMT3()
            If wl_bYesNo = True Then
                wp_sCmdSel = "C"
            Else
                wp_sCmdSel = "A"
            End If
            BD_eTLDMT3_Var()
            wl_bYesNo = False
            wl_bYesNo = clnTEDMT.cnCrearActualizarTLDMT3(wg_eTLDMT3,
                                                         wr_bEOFE2,
                                                         wp_sCmdSel)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizarTLDMT3")
        End Try
        wp_sCmdSel = wl_sCmdAnt
        Return wl_bYesNo
    End Function
    Private Function BD_CrearActualizarTLDMT4(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        wl_sNomtbl = "TLDMT4"
        wl_sDatCmp = "sCodTer"
        Try


            wl_bYesNo = BD_BuscarTLDMT4()
            If wl_bYesNo = True Then
                wp_sCmdSel = "C"
            Else
                wp_sCmdSel = "A"
            End If
            BD_eTLDMT4_Var()
            wl_bYesNo = False
            wl_bYesNo = clnTEDMT.cnCrearActualizarTLDMT4(wg_eTLDMT4,
                                                         wr_bEOFE2,
                                                         wp_sCmdSel)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizarTLDMT4")
        End Try
        wp_sCmdSel = wl_sCmdAnt
        Return wl_bYesNo
    End Function
    Private Sub BD_eTEDMT_DT(ByVal wp_DTE2 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE2.Rows.Count - 1
            wg_eTEDMT = New moe_Estructuras.eTEDMT
            moo_eTEDMT_DT(wg_eTEDMT,
                          wp_DTE2,
                          wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTEDMT_DT")
        End Try

    End Sub
    Private Sub BD_eTLDMT1_DT(ByVal wp_DTE2 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE2.Rows.Count - 1
            wg_eTLDMT1 = New moe_Estructuras.eTLDMT1
            moo_eTLDMT1_DT(wg_eTLDMT1,
                          wp_DTE2,
                          wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT1_DT")
        End Try

    End Sub
    Private Sub BD_eTLDMT2_DT(ByVal wp_DTE2 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE2.Rows.Count - 1
            wg_eTLDMT2 = New moe_Estructuras.eTLDMT2
            moo_eTLDMT2_DT(wg_eTLDMT2,
                           wp_DTE2,
                           wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT2_DT")
        End Try

    End Sub
    Private Sub BD_eTLDMT3_DT(ByVal wp_DTE2 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE2.Rows.Count - 1
            wg_eTLDMT3 = New moe_Estructuras.eTLDMT3
            moo_eTLDMT3_DT(wg_eTLDMT3,
                           wp_DTE2,
                           wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT3_DT")
        End Try

    End Sub
    Private Sub BD_eTLDMT4_DT(ByVal wp_DTE2 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE2.Rows.Count - 1
            wg_eTLDMT4 = New moe_Estructuras.eTLDMT4
            moo_eTLDMT4_DT(wg_eTLDMT4,
                           wp_DTE2,
                           wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT4_DT")
        End Try

    End Sub
    Private Sub BD_eTEDMT_Var()
        Try
            wg_eTEDMT = New moe_Estructuras.eTEDMT
            wg_sClaPpl = txtsCodTer.Text
            With wg_eTEDMT
                .sCodTer = txtsCodTer.Text
                .sNomTer = txtsNomTer.Text

                If String.IsNullOrEmpty(cboTTGRP.SelectedValue) Then
                    .sTipTer = ""
                Else
                    .sTipTer = cboTTGRP.SelectedValue
                End If
                .sNitTer = txtsNitTer.Text
                .sDigVer = txtsDigVer.Text
                .sDirTer = txtsDirTer.Text
                .sTel1Ter = txtsTel1Ter.Text
                .sTel2Ter = txtsTel2Ter.Text
                .sTelCll = txtsTelCll.Text
                .sFax = txtsFax.Text
                .sNomAlt = txtsNomAlt.Text
                .sCodGrpTer = ""
                .sEmlTer = txtsEmlTer.Text
                .sNomCtc = txtsNomCtc.Text
                .sTipCtaCtb = ""
                .sCodCtaCtb = txtsCodCtaCtb.Text
                If String.IsNullOrEmpty(cboATCOP.SelectedValue) Then
                    .sCndPag = ""
                Else
                    .sCndPag = cboATCOP.SelectedValue
                End If
                If String.IsNullOrEmpty(cboIELIP.SelectedValue) Then
                    .sCodLstPre = ""
                Else
                    .sCodLstPre = cboIELIP.SelectedValue
                End If
                If String.IsNullOrEmpty(txtnPorDto.Text) Then
                    .nPorDto = 0
                Else
                    .nPorDto = CDbl(txtnPorDto.Text)
                End If
                If String.IsNullOrEmpty(txtnLmtCre.Text) Then
                    .nLmtCre = 0
                Else
                    .nLmtCre = CDbl(txtnLmtCre.Text)
                End If

                .bAct = rdbItmAct.Checked
                .bIna = rdbItmIna.Checked
                .sCmn = txtsCmn.Text
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTEDMT_Var")
        End Try
    End Sub
    Private Sub BD_eTLDMT1_Var()
        Try
            wg_eTLDMT1 = New moe_Estructuras.eTLDMT1
            wg_sClaPpl = txtsCodTer.Text
            With wg_eTLDMT1
                .sCodTer = txtsCodTer.Text
                .sDirTer = txtsDirTer.Text
                .sCiuTer = txtsCiuTer.Text
                .sDepTer = txtsDepTer.Text
                .sPaiTer = txtsPaiTer.Text
                .bDirDfl = True
                '   .bDirDfl = chbbItmInv.Checked

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT1_Var")
        End Try
    End Sub
    Private Sub BD_eTLDMT2_Var()
        Try
            wg_eTLDMT2 = New moe_Estructuras.eTLDMT2
            wg_sClaPpl = txtsCodTer.Text
            With wg_eTLDMT2
                .sCodTer = txtsCodTer.Text
                .sCodRet = txtsCodRet.Text
                .bAct = True
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT2_Var")
        End Try
    End Sub
    Private Sub BD_eTLDMT3_Var()
        Try
            wg_eTLDMT3 = New moe_Estructuras.eTLDMT3
            wg_sClaPpl = txtsCodTer.Text
            With wg_eTLDMT3
                .sCodTer = txtsCodTer.Text
                .sCodIVA = txtsCodIVA.Text
                .bAct = True
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT3_Var")
        End Try
    End Sub
    Private Sub BD_eTLDMT4_Var()
        Try
            wg_eTLDMT4 = New moe_Estructuras.eTLDMT4
            wg_sClaPpl = txtsCodTer.Text
            With wg_eTLDMT4
                .sCodTer = txtsCodTer.Text

                If String.IsNullOrEmpty(cboWTTID.SelectedValue) Then
                    .sMMTipDoc = ""
                Else
                    .sMMTipDoc = cboWTTID.SelectedValue
                End If
                .sMMNomTer = txtsMMNomTer.Text
                .sMMPriNom = txtsMMPriNom.Text
                .sMMSegNom = txtsMMSegNom.Text
                .sMMPriApe = txtsMMPriApe.Text
                .sMMSegApe = txtsMMSegApe.Text
                .sMMDirTer = txtsMMDirTer.Text

                If String.IsNullOrEmpty(cboWTDEP.SelectedValue) Then
                    .sMMCodDep = ""
                Else
                    .sMMCodDep = cboWTDEP.SelectedValue
                End If
                If String.IsNullOrEmpty(cboWTCIU.SelectedValue) Then
                    .sMMCodCiu = ""
                Else
                    .sMMCodCiu = cboWTCIU.SelectedValue
                End If
                If String.IsNullOrEmpty(cboWTPAI.SelectedValue) Then
                    .sMMCodPai = ""
                Else
                    .sMMCodPai = cboWTPAI.SelectedValue
                End If
                .dMMFecRUT = mtbFecRUT.Text
                If String.IsNullOrEmpty(cboWTCAEPpl.SelectedValue) Then
                    .sMMCodAcvPpl = ""
                Else
                    .sMMCodAcvPpl = cboWTCAEPpl.SelectedValue
                End If
                If String.IsNullOrEmpty(cboWTCAEScn.SelectedValue) Then
                    .sMMCodAcvAlt = ""
                Else
                    .sMMCodAcvAlt = cboWTCAEScn.SelectedValue
                End If


            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eTLDMT4_Var")
        End Try
    End Sub
    Private Sub BD_Var_eTEDMT()
        Try
            With wg_eTEDMT
                vp_nId = .nID
                txtsCodTer.Text = .sCodTer
                txtsNomTer.Text = .sNomTer
                cboTTGRP.SelectedValue = .sTipTer
                txtsNitTer.Text = .sNitTer
                txtsDigVer.Text = .sDigVer
                txtsDirTer.Text = .sDirTer
                txtsTel1Ter.Text = .sTel1Ter
                txtsTel2Ter.Text = .sTel2Ter
                txtsTelCll.Text = .sTelCll
                txtsFax.Text = .sFax
                txtsNomAlt.Text = .sNomAlt
                txtsEmlTer.Text = .sEmlTer
                txtsNomCtc.Text = .sNomCtc
                txtsCodCtaCtb.Text = .sCodCtaCtb
                cboATCOP.SelectedValue = .sCndPag
                cboIELIP.SelectedValue = .sCodLstPre
                txtnPorDto.Text = .nPorDto
                txtnLmtCre.Text = .nLmtCre
                rdbItmAct.Checked = .bAct
                rdbItmIna.Checked = .bIna
                txtsCmn.Text = .sCmn
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eTEDMT")
        End Try
        wg_sClaPpl = txtsCodTer.Text
    End Sub
    Private Sub BD_Var_eTLDMT1()
        Try
            With wg_eTLDMT1
                vp_nId = .nID
                txtsCodTer.Text = .sCodTer
                txtsDirTer.Text = .sDirTer
                txtsCiuTer.Text = .sCiuTer
                txtsDepTer.Text = .sDepTer
                txtsPaiTer.Text = .sPaiTer
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eTLDMT1")
        End Try
    End Sub
    Private Sub BD_Var_eTLDMT2()
        Try
            With wg_eTLDMT2
                vp_nId = .nID
                txtsCodTer.Text = .sCodTer
                txtsCodRet.Text = .sCodRet
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eTLDMT2")
        End Try
    End Sub
    Private Sub BD_Var_eTLDMT3()
        Try
            With wg_eTLDMT3
                vp_nId = .nID
                txtsCodTer.Text = .sCodTer
                txtsCodIVA.Text = .sCodIVA
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eTLDMT3")
        End Try
    End Sub
    Private Sub BD_Var_eTLDMT4()
        Try
            With wg_eTLDMT4
                vp_nId = .nID
                cboWTTID.SelectedValue = .sMMTipDoc
                txtsCodTer.Text = .sCodTer
                txtsMMNomTer.Text = .sMMNomTer
                txtsMMPriNom.Text = .sMMPriNom
                txtsMMSegNom.Text = .sMMSegNom
                txtsMMPriApe.Text = .sMMPriApe
                txtsMMSegApe.Text = .sMMSegApe
                txtsMMDirTer.Text = .sMMDirTer
                cboWTDEP.SelectedValue = .sMMCodDep
                cboWTCIU.SelectedValue = .sMMCodCiu
                cboWTPAI.SelectedValue = .sMMCodPai
                cboWTCAEPpl.SelectedValue = .sMMCodAcvPpl
                cboWTCAEScn.SelectedValue = .sMMCodAcvAlt
                mtbFecRUT.Text = .dMMFecRUT
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eTLDMT3")
        End Try
    End Sub
    Private Sub BD_CargarATALM(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATALM"
            wg_sCmpCon11 = "sCodAlm"
            wg_sCmpCon12 = "sNomAlm"
            wg_sTitCon11 = "Código almacén"
            wg_sTitCon12 = "Nombre almacén"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.ShowDialog()
            '  dgv1.CurrentRow.Cells(wl_CellCod).Value = wg_sSelCon11
            '  dgv1.CurrentRow.Cells(wl_CellDes).Value = wg_sSelCon12
            '  dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATALM")
        End Try
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        BD_eTEDMT_DT(wg_DTE1)
        BD_Var_eTEDMT()
        wl_bYesNo = BD_BuscarTLDMT1()
        If wl_bYesNo = False Then
            BD_eTLDMT1_DT(wg_DTE2)
            BD_Var_eTLDMT1()
        End If
        wl_bYesNo = BD_BuscarTLDMT2()
        If wl_bYesNo = False Then
            BD_eTLDMT2_DT(wg_DTE2)
            BD_Var_eTLDMT2()
        End If
        wl_bYesNo = BD_BuscarTLDMT3()
        If wl_bYesNo = False Then
            BD_eTLDMT3_DT(wg_DTE2)
            BD_Var_eTLDMT3()
        End If
        wl_bYesNo = BD_BuscarTLDMT4()
        If wl_bYesNo = False Then
            BD_eTLDMT4_DT(wg_DTE2)
            BD_Var_eTLDMT4()
        End If


        '  dgv1.Enabled = True
        '     dgv_DetADgv()
        mof_ActivarOK(Me)

        ' dgv1.Enabled = True
        ' dgv_DetADgv()

    End Sub
#End Region


#Region "045 BD Llamar frmGQLst"
    Private Sub BD_frmGQLst_TEDMT()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "TEDMT"
            wl_frmLst.wp_eTEDMT = New moe_Estructuras.eTEDMT
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eTEDMT.sCodTer <> " " Then
                wl_eTEDMT = New moe_Estructuras.eTEDMT
                wl_eTEDMT = wl_frmLst.wp_eTEDMT
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmGQLst_TEDMT")
        End Try
    End Sub
#End Region



#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            wp_sCmdSel = "A"
            wl_sCmdAnt = wp_sCmdSel

            wl_bYesNo = False
            wr_bEOFE1 = True
            wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
            If wl_bYesNo Then
                wl_bYesNo = BD_CrearActualizarTLDMT1(wp_sCmdSel)
                wl_bYesNo = BD_CrearActualizarTLDMT2(wp_sCmdSel)
                wl_bYesNo = BD_CrearActualizarTLDMT3(wp_sCmdSel)
                wl_bYesNo = BD_CrearActualizarTLDMT4(wp_sCmdSel)

                wp_sNomTbl = wg_sNomTblE1
                wp_sDatCmp = ""
                wp_sCodErr = wg_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                mof_ActivarOK(Me)
                '  wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)

            Else
                txtsNomTer.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdActualizar_Click")
        End Try
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try


            wp_sCmdSel = "B"
            wl_sCmdAnt = wp_sCmdSel
            wg_sTipTbl = wl_sTipTbl
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_DTE1 = mof_fConTbl(wg_sNomTblE1,
                                      wg_sNomCmpE11,
                                      wg_sDatCmpE11,
                                      wg_sTipCmpE11,
                                      wg_sCmpOrdE11,
                                      wg_sTipOrdE11,
                                      wr_bEOFE1)
                If wr_bEOFE1 Then
                    wp_sNomTbl = wg_sNomTblE1
                    wp_sDatCmp = txtsCodTer.Text
                    wp_sCodErr = wg_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    txtsCodTer.Enabled = True
                    txtsCodTer.Focus()
                Else
                    BD_eTEDMT_DT(wg_DTE1)
                    BD_Var_eTEDMT()

                    wl_bYesNo = BD_BuscarTLDMT1()
                    If wl_bYesNo = False Then
                        BD_eTLDMT1_DT(wg_DTE2)
                        BD_Var_eTLDMT1()
                    End If
                    wl_bYesNo = BD_BuscarTLDMT2()
                    If wl_bYesNo = False Then
                        BD_eTLDMT2_DT(wg_DTE2)
                        BD_Var_eTLDMT2()
                    End If
                    wl_bYesNo = BD_BuscarTLDMT3()
                    If wl_bYesNo = False Then
                        BD_eTLDMT3_DT(wg_DTE2)
                        BD_Var_eTLDMT3()
                    End If
                    wl_bYesNo = BD_BuscarTLDMT4()
                    If wl_bYesNo = False Then
                        BD_eTLDMT4_DT(wg_DTE2)
                        BD_Var_eTLDMT4()
                    End If
                    txtsCodTer.Enabled = False


                    'mof_fLmpCtrl(Me.dgv1)
                    'Dgv_DetADgv()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    cmdOk.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdBuscar_Click")
        End Try

    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Try
            wp_sCmdSel = "C"
            wl_sCmdAnt = wp_sCmdSel
            wg_sTipTbl = wl_sTipTbl
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtsCodter.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_DTE1 = mof_fConTbl(wg_sNomTblE1,
                                      wg_sNomCmpE11,
                                      wg_sDatCmpE11,
                                      wg_sTipCmpE11,
                                      wg_sCmpOrdE11,
                                      wg_sTipOrdE11,
                                      wr_bEOFE1)
                If wr_bEOFE1 Then
                    wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                    If wl_bYesNo Then
                        wl_bYesNo = BD_CrearActualizarTLDMT1(wp_sCmdSel)
                        wl_bYesNo = BD_CrearActualizarTLDMT2(wp_sCmdSel)
                        wl_bYesNo = BD_CrearActualizarTLDMT3(wp_sCmdSel)
                        wl_bYesNo = BD_CrearActualizarTLDMT4(wp_sCmdSel)

                        wp_sNomTbl = wg_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = wg_sCodErrOk
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        mof_ActivarOK(Me)
                        mof_habTsbCrear()
                        mof_habTsbEliminar()
                    End If
                    '                    wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)

                Else
                    wp_sNomTbl = wg_sNomTblE1
                    wp_sDatCmp = txtsCodTer.Text
                    wp_sCodErr = wg_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodTer.Focus()
                End If
            End If
            txtsCodter.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdCrear_Click")
        End Try
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            wp_sCmdSel = "E"
            wl_sCmdAnt = wp_sCmdSel
            wg_sTipTbl = wl_sTipTbl
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                vl_sCodTer = txtsCodTer.Text
                wp_nBoxMsg = 4
                wp_sDesMsg = wg_sDesMsgEli
                wp_sTitMsg = wg_sTitMsgEli
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)
                If wp_nResMsg = 6 Then
                    BD_DatPrmTipTbl(wg_sTipTbl)
                    wg_sCmpOrdE11 = ""
                    wg_sTipOrdE11 = ""
                    wg_DTE1 = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                                   wg_sNomCmpE11,
                                                   wg_sDatCmpE11,
                                                   wg_sTipCmpE11,
                                                   wg_sCmpOrdE11,
                                                   wg_sTipOrdE11,
                                                   wr_bEOFE1)
                    If Not wr_bEOFE1 Then
                        wp_sNomTbl = ""
                        wl_bYesNo = mov_VdasCodTer(vl_sCodTer,
                                                   wp_sNomTbl,
                                                   wl_bVda)

                        If wl_bVda = True Then
                            wl_bYesNo = clnTEDMT.cnEliminar(vl_sCodTer,
                                                        wr_bEOFE1)
                            If wl_bYesNo Then

                                mof_ActivarBuscar(Me)
                                wp_sNomTbl = wg_sNomTblE1
                                wp_sDatCmp = ""
                                wp_sCodErr = wg_sCodErrOk
                                mof_MsgError(wp_sNomTbl,
                                             wp_sDatCmp,
                                             wp_sCodErr)
                                mof_ActivarOK(Me)

                            Else
                                txtsNomTer.Focus()
                            End If
                        Else
                            wp_sDatCmp = vl_sCodTer
                            wp_sCodErr = "10-608"
                            mof_MsgError(wp_sNomTbl,
                                         wp_sDatCmp,
                                         wp_sCodErr)
                            mof_ActivarOK(Me)
                            cmdOk.Focus()

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdEliminar_Click")
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        grl_Cerrar()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        grl_Cerrar()
    End Sub
#End Region
#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Try
            vl_bEOF1 = False
            BD_frmGQLst_TEDMT()
            txtsCodTer.Text = wl_eTEDMT.sCodTer
            txtsNomTer.Text = wl_eTEDMT.sNomTer
            cmdBuscar_Click(Nothing,
                            Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
    End Sub
#End Region


#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Sub dgv_AdiRow()
        Exit Sub

        Try
            With dgv1
                wl_nCntRow = .RowCount
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                Dim wl_dgvrows As DataGridViewRow = dgv1.Rows(wl_nRow)
                wl_dgvrows.Height = 16
                .CurrentRow.Cells(1).Value = vl_sCodTer
                .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)
            End With
            wl_nTab = 0
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count
            dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            dgv1.Rows(wl_nRow).Cells(1).Value = txtsCodTer.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: dgv_AdiRow")

        End Try
    End Sub
    Private Sub dgv_AdicionarLinea1()
        Try
            dgv1.Rows.Add()
            dgv1.RowTemplate.Height = wl_nRowAlto
            wl_nTab = 0
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count
            dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            'dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIni)
            ' dgv1.Rows(wl_nRow).Cells(1).Value = txtsCodter.Text
        Catch ex As Exception
            MsgBox("Error : dgv_AdicionarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_APDGV()
        Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
        Try
            wg_nColFin = 0
            wg_aeAPDGV = mof_fConAPDGV(wp_sNomFrm,
                                       wp_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nTotCol = UBound(wg_aeAPDGV) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APDGV")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodTer = txtsCodTer.Text

            For wl_nRow = 0 To dgv1.RowCount - 1
                vp_nId = dgv1.Rows(wl_nRow).Cells(0).Value
                ' vp_sCodAlm = dgv1.Rows(wl_nRow).Cells(2).Value
                ' vp_sDesAlm = dgv1.Rows(wl_nRow).Cells(3).Value
                ' vp_nCanMin = dgv1.Rows(wl_nRow).Cells(4).Value
                ' vp_nCanMax = dgv1.Rows(wl_nRow).Cells(5).Value
                ' vp_nOrdMin = dgv1.Rows(wl_nRow).Cells(6).Value
                '   vp_nSdoAlm = dgv1.Rows(wl_nRow).Cells(7).Value
                '  vp_nPreUni = dgv1.Rows(wl_nRow).Cells(8).Value
                ' vp_nVlrTot = dgv1.Rows(wl_nRow).Cells(9).Value
                wp_sCmdSel = wl_sCmdAnt
                If vp_nId <> 0 Then
                    wp_sCmdSel = "A"
                Else
                    wp_sCmdSel = "C"
                End If
                ' If dgv1.Rows(wl_nRow).Visible = True Then
                ' If vp_sCodAlm <> Nothing Then
                ' wl_bYesNo = clnIEDMI.cnCrearActualizarILMDI1(wl_eILDMI1,
                '                                             wr_bEOF,
                '                                            wp_sCmdSel)
                ' End If
                'Else
                'wl_bYesNo = clnIEDMI.cnEliminarILMDI1(vp_sCodTer,
                '                                     vp_sCodAlm,
                '                                     wr_bEOFL1)
                'End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdiLinBlanco(ByVal wl_nRowVacia As Integer)
        For wl_nF = 0 To wl_nRowVacia
            dgv1.Rows.Add()
        Next
    End Sub
    Private Sub dgv_ConfigurarDGV1()
        wl_nTotCol = 12
        wl_nColFin = 10

        With dgv1
            'Propiedades iniciales
            .Dock = DockStyle.Fill
            .BackgroundColor = wg_ClrFrm
            .BorderStyle = BorderStyle.FixedSingle

            ' Propiedades
            'Rows

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowTemplate.Height = 10
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .AllowUserToResizeRows = False
            .RowHeadersWidth = 12
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty

            ' Columns
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .ColumnHeadersHeight = 20
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .Columns.Clear()

            .SelectionMode = DataGridViewSelectionMode.CellSelect

            .MultiSelect = False

            .EnableHeadersVisualStyles = False
            .ColumnCount = wl_nTotCol

        End With

        With dgv1
            .Columns(0).HeaderText = "0 Nro"
            .Columns(1).HeaderText = "1 Código ítem"
            .Columns(2).HeaderText = "2 Código almacén"
            .Columns(3).HeaderText = "3 Nombre almacén "
            .Columns(4).HeaderText = "4 Cantidad mínima "
            .Columns(5).HeaderText = "5 Cantidad máxima "
            .Columns(6).HeaderText = "6 Pedido mínima "
            .Columns(7).HeaderText = "7 Saldo almacén "
            .Columns(8).HeaderText = "8 Precio unitario "
            .Columns(9).HeaderText = "9 Valor total "
            .Columns(10).HeaderText = "10 Código almacén "
            .Columns(11).HeaderText = "11 Estado "
        End With

    End Sub

    Private Sub dgv_ConfiguraCol()
        Dim wl_bCnfVis As Boolean = False
        Dim vl_sNomCmp As String
        Dim vl_sTitCol As String
        wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
        Try

            For wp_nC = 0 To wl_nTotCol - 1
                wp_bVisible = True
                wp_bReadOnly = False
                wp_bColxDef = False
                wp_sTipCol = "S"
                wg_eAPDGV = wg_aeAPDGV(wp_nC)
              
                With wg_eAPDGV
                    wp_sTipCol = .sTipCol
                    wp_bVisible = .bVisible
                    wp_bReadOnly = .bReadOnly
                    wp_bColxDef = .bColxDef
                    vl_sNomCmp = .sNomCmp
                    vl_sTitCol = .sTitCol
                End With

                mof_DGVFormatCol(Me.dgv1,
                             wp_nC,
                             wp_sTipCol,
                             wp_bVisible,
                             wp_bReadOnly,
                             vl_sNomCmp,
                             vl_nTamCmp,
                             vl_sTitCol)
                If wl_bCnfVis = False Then
                    If wp_bVisible Then
                        If wp_bReadOnly = False Then
                            wl_nColIniGrl = wp_nC
                            wl_nColFinGrl = wp_nC
                            wl_bCnfVis = True
                        End If
                    End If
                End If
                If wl_bCnfVis = True Then
                    If wp_bVisible Then
                        wl_nColFinGrl = wp_nC
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ConfiguraCol")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodTer = txtsCodTer.Text

        Try
            wg_DTL1 = clnIEDMI.cndtConsultarILMDI1(vl_sCodTer,
                                                   wr_bEOFL1)



            If dgv1.Rows.Count > 0 Then
                dgv1.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow()
                        moo_DGV_DT_eILDMI1(Me.dgv1,
                                           wg_DTL1,
                                          wl_nRow)

                    Next
                End With
                'dgv_SumaFormatea()

            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DetADgv")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_LlenaDGV1()

        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodTer = txtsCodTer.Text

        Try
            wg_DTL1 = clnIEDMI.cndtConsultarILMDI1(vl_sCodTer,
                                                  wr_bEOFL1)
            If dgv1.Rows.Count > 0 Then
                dgv1.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow()

                        dgv1.Rows(wl_nRow).Cells(0).Value = wg_DTL1.Rows(wl_nRow).Item(0)
                        dgv1.Rows(wl_nRow).Cells(1).Value = wg_DTL1.Rows(wl_nRow).Item(1)
                        dgv1.Rows(wl_nRow).Cells(2).Value = wg_DTL1.Rows(wl_nRow).Item(2)
                        dgv1.Rows(wl_nRow).Cells(3).Value = wg_DTL1.Rows(wl_nRow).Item(10)
                        dgv1.Rows(wl_nRow).Cells(4).Value = wg_DTL1.Rows(wl_nRow).Item(3)
                        dgv1.Rows(wl_nRow).Cells(5).Value = wg_DTL1.Rows(wl_nRow).Item(4)
                        dgv1.Rows(wl_nRow).Cells(6).Value = wg_DTL1.Rows(wl_nRow).Item(5)
                        dgv1.Rows(wl_nRow).Cells(7).Value = wg_DTL1.Rows(wl_nRow).Item(6)
                        dgv1.Rows(wl_nRow).Cells(8).Value = wg_DTL1.Rows(wl_nRow).Item(7)
                        dgv1.Rows(wl_nRow).Cells(9).Value = wg_DTL1.Rows(wl_nRow).Item(8)

                    Next
                End With
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_LlenaDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_CrearPrimeraLinea()
        Try
            With dgv1
                dgv1.Rows.Add()
                dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                dgv1.Rows(wl_nRow).Cells(1).Value = txtsCodTer.Text
                '  dgv1.Rows(wl_nRow).Cells(2).Value = cboATALM.SelectedValue
                '    wr_bEOFL1 = True
                wg_sTblLst1 = "ATALM"
                wg_sCmpLst1 = "sCodAlm"
                wg_sTipLst1 = "C"
                wg_sDatLst1 = dgv1.CurrentRow.Cells(2).Value
                wg_sCmpOrdLst1 = ""
                wg_sTipOrdLst1 = ""

                wg_DTLst1 = clnConTbl.cndtBuscar(wg_sTblLst1,
                                                wg_sCmpLst1,
                                                wg_sDatLst1,
                                                wg_sTipLst1,
                                                wg_sCmpOrdLst1,
                                                wg_sTipOrdLst1,
                                                wr_bEOFLst1)
                If Not wr_bEOFL1 Then
                    dgv1.Rows(wl_nRow).Cells(3).Value = wg_DTLst1.Rows(0).Item(1)

                Else
                    MsgBox("Registro No Existe")
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : dgv_CreaPrimeraLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_EliminarLinea()
        Dim wl_nRow As Integer
        Try
            wl_nRow = (dgv1.Rows.Count).ToString
            wl_nCol = dgv1.CurrentRow.Index
            If wl_nRow >= 0 Then
                dgv1.Rows(wl_nCol).Visible = False
                wl_nCol = 0
                For wl_nRow = 0 To dgv1.Rows.Count - 1
                    If dgv1.Rows(wl_nRow).Visible = True Then
                        dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCol + 1).ToString
                        wl_nCol = wl_nCol + 1
                    End If
                Next
                dgv1.RefreshEdit()
            End If
        Catch
            MsgBox("Error: dgv_EliminarLinea")
        End Try

    End Sub
    Private Sub dgv_BorraLinea()
        Dim I As Int16
        Try
            I = dgv1.CurrentRow.Index
            dgv1.Rows(I).Cells(9).Value = "B"
            dgv1.Rows.Remove(dgv1.CurrentRow)
            dgv1.RefreshEdit()
        Catch ex As Exception
            MsgBox("Error: dgv_BorraLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "071 DGV Procedimientos del Usuario. Comunes"

#End Region
#Region "072 DGV Controladores de Eventos "
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        wl_nRowAnt = e.RowIndex
        wl_nColAnt = e.ColumnIndex
    End Sub
    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        If dgv1.CurrentCell.ReadOnly = True Then
            dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
        End If
    End Sub
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try

            If dgv1.CurrentCell.ReadOnly = True Then
                dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If


            Dim wl_frmLst As New frmGQLst

            If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
                BD_CargarATALM(2, 3, 4)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try

        Catch
            MsgBox("Error: dgv1_CellStateChanged")
        End Try

    End Sub
    Private Sub dgv1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try
            If dgv1.Rows.Count > 0 Then


                grl_TextChange()
                wl_nRow = e.RowIndex
                wl_nCol = e.ColumnIndex
                If wl_nCol = 1 Then
                    wr_bEOFL1 = True
                    wg_sTblLst1 = "ATALM"
                    wg_sCmpLst1 = "sCodAlm"
                    wg_sTipLst1 = "C"
                    wg_sDatLst1 = dgv1.CurrentRow.Cells(2).Value
                    wg_sCmpOrdLst1 = ""
                    wg_sTipOrdLst1 = ""
                    If wg_sDatLst1 <> Nothing Then
                        wg_DTLst1 = clnConTbl.cndtBuscar(wg_sTblLst1,
                                                         wg_sCmpLst1,
                                                         wg_sDatLst1,
                                                         wg_sTipLst1,
                                                         wg_sCmpOrdLst1,
                                                         wg_sTipOrdLst1,
                                                         wr_bEOFLst1)
                        If Not wr_bEOFLst1 Then
                            dgv1.Rows(wl_nRow).Cells(8).Value = wg_DTLst1.Rows(0).Item(1)

                        Else
                            MsgBox("Registro No Existe")
                        End If
                    End If
                End If

            End If



        Catch
            MsgBox("Error : dgv1_CellValueChanged")

        End Try

    End Sub
    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try
            If dgv1.CurrentCellAddress.Y > 0 Then
                If dgv1.CurrentCell.ColumnIndex > wl_nColFin Then
                    '     dgv_AdicionarLinea()
                End If
            End If
        Catch
            MsgBox("Error: dgv1_CurrentCellChanged")
            MsgBox(wl_nRow.ToString & " " & wl_nCol.ToString)
        End Try
    End Sub
    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_i As Integer
        wl_nRow = dgv1.CurrentCellAddress.Y
        wl_nCol = dgv1.CurrentCellAddress.X
        wl_nCntRow = dgv1.Rows.Count

        If dgv1.CurrentCell.Value = Nothing And
            (wl_nCol = 2 Or wl_nCol = 3) Then
            dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            BD_CargarATALM(2, 3, 2)
            Exit Sub
        End If


        If dgv1.CurrentCell.ReadOnly = True Then
            For wl_i = wl_nCol To wl_nColFin
                If dgv1.CurrentCell.ReadOnly = False Then
                    Exit For
                End If
                If wl_i > wl_nColFin Then
                    wl_i = wl_nColIni
                    If dgv1.CurrentCell.RowIndex = dgv1.Rows.Count - 1 Then
                        dgv_AdiRow()
                        wl_nRow = dgv1.CurrentCellAddress.Y + 1
                    End If
                End If
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_i)
            Next
            wl_nCol = wl_i - 1
            If dgv1.CurrentCell.ReadOnly = True And wl_nCol = wl_nColFin Then
                wl_nTab = 1
            End If
        End If

        wl_nRow = dgv1.CurrentCellAddress.Y
        wl_nCol = dgv1.CurrentCellAddress.X
        wl_nCntRow = dgv1.Rows.Count

        If dgv1.CurrentCellAddress.X >= wl_nColFin Then
            If e.KeyCode = Keys.Tab Then
                If wl_nTab > 0 Then
                    If dgv1.CurrentCell.RowIndex = dgv1.Rows.Count - 1 Then
                        dgv_AdiRow()
                    End If
                    wl_nRow = dgv1.CurrentCellAddress.Y + 1
                    wl_nCol = wl_nColIni
                    dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                    wl_nTab = 0
                Else
                    wl_nTab = 1
                End If
            End If
        End If
    End Sub
    Private Sub dgv1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        ' dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect





    End Sub
    Private Sub dgv1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs)
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Exit Sub
        Try
            wl_nRow = (dgv1.Rows.Count).ToString
            MsgBox("Línea " & wl_nRow & " Eliminada")
        Catch
            MsgBox("Línea " & wl_nRow)

        End Try
    End Sub
#End Region
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarDoc()
        wp_sNomFrm = "frmTEMDT"
    End Sub
    Private Sub Plo_IniciarVar()
        wl_bYesNo = False
        wl_bEdit = False
        wg_sCodErrAdi = wl_sCodErrYaEx1
        wg_sCodErrCon = wl_sCodErrNoEx
        wg_sCodErrOk = wl_sCodErrOk
        wg_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
        wg_sTitMsgEli = "Mensaje del sistema"

        ' globales
        wg_sCmpTSB = "sCodTer"
        wg_sDatTSB = ""
        mof_ActivarBuscar(Me)
        txtsCodTer.Focus()

        'dtpFecCtb.Format = DateTimePickerFormat.Short
        'dtpFecCtb.Value = Date.Today

        mof_ActivarCrear(Me)
        'dtpFecCtb.Visible = False
        'mtbFecCtb.Text = dtpFecCtb.Value
        mtbFecRUT.Text = Today




    End Sub
    Private Sub Plo_IniciarVarDGV()
        'dgv
        wl_nTab = 0
        wl_nRowVacia = 7

        wl_nColAnt = wl_nColIniGrl
        wl_nRowAnt = 0


        wl_nColVda1 = 4
        wl_nColVda2 = 5

        wl_sOpeLgc = "Y"

        mof_ConfigurarDGV(Me.dgv1,
                          wl_nTotCol)

    End Sub
    Private Sub Plo_ActivarCrear()
        Plo_IniciarVar()
        mof_ActivarCrear(Me)
        txtsCodTer.Enabled = True
        txtsCodTer.Focus()

        '    dgv1.Enabled = True
        '   mof_ConfigurarDGV(Me.dgv1,
        '                 wl_nTotCol)
        '  dgv_ConfiguraCol()
        ' dgv1.Rows.Clear()
        'dgv_AdicionarLinea()
        ' dgv_AdiRow()
        txtsCodTer.Focus()

    End Sub
    Private Sub Plo_ActivarBuscar()
        '  mof_fLmpCtrl(Me)
        Plo_IniciarVar()
        txtsCodTer.Enabled = True
        txtsCodTer.Focus()
        mof_ActivarBuscar(Me)

        '  dgv1.Enabled = True
        '  dgv1.Rows.Clear()
        ' mof_ConfigurarDGV(Me.dgv1,
        '                    wl_nTotCol)
        ' dgv_ConfiguraCol()
        ' dgv1.Rows.Clear()
        ' dgv_AdiRow()

        '
    End Sub
    Private Sub Plo_ActivarOk()
        txtsNomTer.Focus()
        '
    End Sub
#End Region
#Region "090 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"
    Private Sub txtsCodTer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCodTer.KeyUp
        Try
            If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: txtsCodTer_KeyUp")
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Private Sub txtsCodTer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodTer.LostFocus
        Try
            If cmdBuscar.Visible = True Then
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error: txtsCodTer_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#End Region
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
        If DirectCast(sender, TextBox).Name = "txtsCodter" Then
            wg_sClaPpl = txtsCodTer.Text
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
    Private Sub grl_AddHandler()
        AddHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        AddHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        AddHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        AddHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        AddHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        AddHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        AddHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        AddHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        AddHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
    End Sub
    Private Sub grl_RemoveHandler()
        RemoveHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        RemoveHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        RemoveHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        RemoveHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        RemoveHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        RemoveHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        RemoveHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        RemoveHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        RemoveHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        RemoveHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
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
        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Rdb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        wl_cvTxt = GetNextControl(wl_cvTxt, False)
        If cmdCancelar.Focused = False Then
            If wl_cvTxt IsNot Nothing Then


                If wl_cvTxt.Name = "txtsCodter" Then
                    mov_VdaTxt(wl_bVda,
                               txtsCodTer)
                End If
            End If
        End If
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
        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region
#Region "160 TSB ToolStrip Procedimientos eventos de la barra de herramientas:BCPASUE"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
        Plo_ActivarBuscar()
    End Sub
    Private Sub tsb_Primero()
        mof_fLmpCtrl(Me)
        BD_DatPrmTSB()
        mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            If wg_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtPrimero(wg_sNomTblE1,
                                                wg_sCmpTSB,
                                                wg_sDatTSB,
                                                wr_bEOFE1)
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

            If wg_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtAnterior(wg_sNomTblE1,
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
            If wg_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtSiguiente(wg_sNomTblE1,
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
            If wg_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl.cndtUltimo(wg_sNomTblE1,
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
        cmdEliminar.Focus()
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
        dgv_AdiRow()
    End Sub
    Private Sub tsmi_EliminarLinea()
        mof_ActivarActualizar(Me)
        dgv_EliminarLinea()
    End Sub
#End Region

   
    
End Class