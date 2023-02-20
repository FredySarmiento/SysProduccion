Imports System.Data.OleDb
Imports System.Data



Public Class frmIEDMI
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-21
#End Region
#Region "001 Inicia. wg - vg Definición del variables públicas"
    Public Property vp_sCodItm As String
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"
    ' Booleanas
    Dim wl_bVda As Boolean
    Dim vl_bEOF1 As Boolean
    ' Cadenas
    Dim wl_sCodPrm As String
    Dim wl_sTipTbl As String
    Dim wl_sCodDgv As String
    Dim wl_sNomFrm As String
    Dim wl_sCodItm As String
    Dim wl_sCodAlm As String
    Dim wl_nTotInv As Double

    ' Numéricas
#End Region
#Region "012 BD - Variables campos BD Locales"
    ' Variables Campos de la BD

    Dim vp_nId As Integer
    Dim vl_sCodItm As String
    Dim vp_sCodBar As String
    Dim vp_sDesItm As String
    Dim vp_sDesAlt As String
    Dim vp_sClsItm As String
    Dim vl_sCodGrp As String
    Dim vp_sCodSgr As String
    Dim vp_bItmInv As Boolean
    Dim vp_bItmVta As Boolean
    Dim vp_bItmCom As Boolean
    Dim vp_bIndIVA As Boolean
    Dim vp_sCodAlt As String
    Dim vp_sTipGes As String
    Dim vp_bItmAct As Boolean
    Dim vp_bItmIna As Boolean
    Dim vp_sCodTerPrv As String
    Dim vp_sCodTerFte As String
    Dim vp_sCodItmFte As String
    Dim vp_sUniMedCom As String
    Dim vp_nCanUniCom As Double
    Dim vp_sUniEmpCom As String
    Dim vp_nCanUniECom As Double
    Dim vp_sCodItoCom As String
    Dim vp_sUniMedVta As String
    Dim vp_nCanUniVta As Double
    Dim vp_sUniEmpVta As String
    Dim vp_nCanUniEVta As Double
    Dim vp_sCodItoVta As String
    Dim vp_sCriCtaCbe As String
    Dim vp_sUniMedInv As String
    Dim vp_sMetVlz As String
    Dim vl_sCodAlmCom As String
    Dim vl_sCodGrpVta As String
    Dim vl_bIndCanRes As Boolean
    Dim vl_bIndCanPry As Boolean
    Dim vl_nSdoIni As Double
    Dim vl_nSdoIniAno As Double
    Dim vl_nCanResODP As Double
    Dim vl_nSdoFinDis As Double
    Dim vl_nCanPedODC As Double
    Dim vl_nSdoFinPry As Double
    Dim vl_nLeadTime As Long




    Dim vp_nCosItm As Double
    Dim vl_nUltPreEnt As Double
    Dim vl_sCodAlm As String
    Dim vp_sDesAlm As String
    Dim vp_nCanMin As Double
    Dim vp_nCanMax As Double
    Dim vp_nOrdMin As Double
    Dim vp_nSdoAlm As Double
    Dim vp_nPreUni As Double
    Dim vp_nVlrTot As Double
    Dim vp_sCtaInv As String

#End Region
#Region "013 DGV - Variables Locales"
    Dim vl_nColFin As Integer
    'booleanas
    Dim wp_bVisible As Boolean
    Dim wp_bReadOnly As Boolean
    Dim wl_bYesNo As Boolean
    Dim wl_bEdit As Boolean
    Dim wl_bEOF As Boolean
    Dim wl_bVdaRow As Boolean
    'cadena
    Dim wl_sOpeLgc As String
    'Columnas
    Dim wl_nColCVC As Integer
    Dim wl_nRowCVC As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nColKU As Integer
    Dim wl_nRowKD As Integer
    Dim wl_nColKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nColKP As Integer
    Dim wl_nRowSig As Integer
    Dim wl_nColSig As Integer
    Dim wl_nCntCol As Integer
    Dim wl_nColNom As Integer
    Dim wl_nRowAct As Integer
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
    Dim wl_sNomTblE1 As String
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
    Dim wl_nNroDgv As Integer
#End Region
#Region "014 Objetos locales"
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim wl_tbp As New TabPage
    Dim wl_CtrlDgv As New DataGridView

#End Region
#Region "015 Estructuras"
    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATGRI As New moe_Estructuras.eATGRI
    Dim wl_eATGRV As New moe_Estructuras.eATGRV
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eILDMI1 As New moe_Estructuras.eILDMI1
    Dim wl_eILDMI2 As New moe_Estructuras.eILDMI2
#End Region
#Region "018 Errores"
    Dim wl_sNomtbl As String
    Dim wl_sDatCmp As String
    Dim wl_sCoderr As String
    'Código de error
    '10-101 
    '10-203 
    '10-301 
    '10-317
    '10-401 
    '20-001
#End Region
#Region "019 Fin definición del variables Locales"
#End Region


#Region "020 frm Eventos - Principal"
    Private Sub frmIEDMI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        grl_RemoveHandler()
        Me.Dispose()
    End Sub
    Private Sub frmIEDMI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text += "  -  " + vg_sNomCia
        wl_sNomFrm = "frmIEDMI"
        grl_RemoveHandler()
        grl_AddHandler()
        mof_fCnfCtrl(Me)
        mof_IniciarVar()
        Plo_IniciarDoc()
        Plo_IniciarVar()
        wl_sTipTbl = "E1"
        wg_sTipTbl = wl_sTipTbl
        BD_DatPrmTipTbl(wg_sTipTbl)

        dgv_APDGV()
        Plo_IniciarVarDGV()
        grl_EventCtrl(Me)
        Cbo_CargarLst()
        mof_fLmpCtrl(Me)
        Plo_ActivarBuscar()
        If vp_sCodItm <> "" Then
            mtbsCodItm.Text = vp_sCodItm
            cmdBuscar_Click(Nothing,
                            Nothing)
        End If




    End Sub
    Private Sub frmIEDMI_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' txtsCodItm.Focus()
        mtbsCodItm.Focus()
    End Sub
#End Region
#Region "030 Cbo Llenar Combobox"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarACUNI()
            Cbo_CargarATALM()
            Cbo_CargarATALMCom()
            Cbo_CargarATCCC()
            Cbo_CargarATCLI()
            Cbo_CargarATGRI()
            Cbo_CargarATGRV()
            Cbo_CargarATIVA()
            Cbo_CargarATMEV()
            Cbo_CargarABTGE()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarLst")
        End Try
    End Sub
    Private Sub Cbo_CargarACUNI()
        Try
            '1
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ACUNI"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACUNIcom.DataSource = wg_DTLst1
                cboACUNIcom.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                cboACUNIcom.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
            '2
            wg_DTLst1 = New DataTable
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACUNIinv.DataSource = wg_DTLst1
                cboACUNIinv.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                cboACUNIinv.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
            '3
            wg_DTLst1 = New DataTable
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACUNIvta.DataSource = wg_DTLst1
                cboACUNIvta.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                cboACUNIvta.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarACUNI")
        End Try
    End Sub
    Private Sub Cbo_CargarATALM()
        Try
            '4
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATALM"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATALM.DataSource = wg_DTLst1
                cboATALM.DisplayMember = wg_DTLst1.Columns("sNomAlm").Caption.ToString
                cboATALM.ValueMember = wg_DTLst1.Columns("sCodAlm").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATALM")
        End Try
    End Sub
    Private Sub Cbo_CargarATALMCom()
        Try
            '4
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATALM"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATALMCom.DataSource = wg_DTLst1
                cboATALMCom.DisplayMember = wg_DTLst1.Columns("sNomAlm").Caption.ToString
                cboATALMCom.ValueMember = wg_DTLst1.Columns("sCodAlm").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATALMCom")
        End Try
    End Sub
    Private Sub Cbo_CargarATCCC()
        Try
            '5
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATCCC"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATCCC.DataSource = wg_DTLst1
                cboATCCC.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                cboATCCC.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarACUNI")
        End Try
    End Sub
    Private Sub Cbo_CargarATCLI()
        Try
            '6
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATCLI"
            wr_bEOFLst1 = wr_bEOFLst1
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATCLI.DataSource = wg_DTLst1
                cboATCLI.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
                cboATCLI.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATCLI")
        End Try

    End Sub
    Private Sub Cbo_CargarATGRI()
        Try
            '7
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATGRI"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATGRI.DataSource = wg_DTLst1
                cboATGRI.DisplayMember = wg_DTLst1.Columns("sNomGrp").Caption.ToString
                cboATGRI.ValueMember = wg_DTLst1.Columns("sCodGrp").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATGRI")
        End Try
    End Sub
    Private Sub Cbo_CargarATGRV()
        Try
            '7
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATGRV"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATGRV.DataSource = wg_DTLst1
                cboATGRV.DisplayMember = wg_DTLst1.Columns("sNomGrpVta").Caption.ToString
                cboATGRV.ValueMember = wg_DTLst1.Columns("sCodGrpVta").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATGRV")
        End Try
    End Sub
    Private Sub Cbo_CargarATIVA()
        Try
            '8
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATIVA"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATIVAcom.DataSource = wg_DTLst1
                cboATIVAcom.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString
                cboATIVAcom.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
            End If

            '9
            wg_DTLst1 = New DataTable
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATIVAvta.DataSource = wg_DTLst1
                cboATIVAvta.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString
                cboATIVAvta.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATIVA")
        End Try
    End Sub
    Private Sub Cbo_CargarATMEV()
        Try
            '10
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATMEV"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATMEV.DataSource = wg_DTLst1
                cboATMEV.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                cboATMEV.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATMEV")
        End Try
    End Sub
    Private Sub Cbo_CargarABTGE()
        Try
            '11
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABTGE"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABTGE.DataSource = wg_DTLst1
                cboABTGE.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                cboABTGE.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarABTGE")
        End Try
    End Sub
#End Region

#Region "040 BD Procedimientos sobre la BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        Try
            ' Tipo de tabla
            If wg_sTipTbl = "E1" Then
                wl_sNomTblE1 = "IEDMI"
                wg_sNomCmpE11 = "sCodItm"
                wg_sTipCmpE11 = "C"
                wg_sTitCmpE11 = "Código ítem "
                'wg_sDatCmpE11 = txtsCodItm.Text
                wg_sDatCmpE11 = mtbsCodItm.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "L1" Then
                wg_sNomTblL1 = "ILDMI1"
                wg_sNomCmpL11 = "sCodItm"
                wg_sTipCmpL11 = "C"
                wg_sTitCmpL11 = "Código ítem "
                'wg_sDatCmpL11 = txtsCodItm.Text
                wg_sDatCmpL11 = mtbsCodItm.Text
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
            wg_sCmpTSB2 = "sCodItm"

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
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        wl_sNomtbl = "IEDMI"
        wl_sDatCmp = "sCodItm"
        wl_sCoderr = "10-401"

        Try
            BD_eIEDMI_Var()
            If mov_VdaDatVio(wl_bYesNo,
                             mtbsCodItm.Text) Then
                '                                 txtsCodItm.Text) Then
                wl_sCoderr = "10-401"
                mof_MsgError(wl_sNomtbl,
                             wl_sDatCmp,
                             wl_sCoderr)
                'txtsCodItm.Focus()
                mtbsCodItm.Focus()
                Return False
                Exit Function
            End If
            If wl_bYesNo = False Then
                wl_bYesNo = False
                vl_sCodGrp = cboATGRI.SelectedValue

                If mov_VdaDatVio(wl_bYesNo,
                                 vl_sCodGrp) Then
                    wl_sCoderr = "10-413"
                    mof_MsgError(wl_sNomtbl,
                                 wl_sDatCmp,
                                 wl_sCoderr)

                    cboATGRI.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If wl_bYesNo = False Then
                wl_bYesNo = False
                vl_sCodGrpVta = cboATGRV.SelectedValue

                If mov_VdaDatVio(wl_bYesNo,
                                 vl_sCodGrpVta) Then
                    wl_sCoderr = "10-425"
                    mof_MsgError(wl_sNomtbl,
                                 wl_sDatCmp,
                                 wl_sCoderr)

                    cboATGRV.Focus()
                    Return False
                    Exit Function
                End If
            End If
            If wl_bYesNo = False Then
                wl_bYesNo = False
                vl_sCodAlm = cboATALM.SelectedValue
                If mov_VdaDatVio(wl_bYesNo,
                                 vl_sCodAlm) Then
                    wl_sCoderr = "10-403"
                    mof_MsgError(wl_sNomtbl,
                                 wl_sDatCmp,
                                 wl_sCoderr)
                    cboATALM.Focus()
                    Return False
                    Exit Function
                End If
            End If

            If wl_bYesNo = False Then
                wl_bYesNo = False
                wl_bYesNo = clnIEDMI.cnCrearActualizar(wl_eIEDMI,
                                                       wr_bEOFE1,
                                                       wp_sCmdSel)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmd_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_eIEDMI_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            moo_eIEDMI_DT(wl_eIEDMI,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eIEDMI_DT")
        End Try

    End Sub
    Private Sub BD_eIEDMI_Var()
        Try
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            'wg_sClaPpl = txtsCodItm.Text
            wg_sClaPpl = mtbsCodItm.Text
            With wl_eIEDMI
                '.sCodItm = txtsCodItm.Text
                .sCodItm = mtbsCodItm.Text
                .sCodBar = TxtCodBar.Text
                .sNomItm = TxtsNomItm.Text
                .sNomAlt = TxtsNomAlt.Text
                If String.IsNullOrEmpty(cboATCLI.SelectedValue) Then
                    .sClsItm = ""
                Else
                    .sClsItm = cboATCLI.SelectedValue
                End If
                If String.IsNullOrEmpty(cboATGRI.SelectedValue) Then
                    .sCodGrp = ""
                Else
                    .sCodGrp = cboATGRI.SelectedValue
                End If
                If String.IsNullOrEmpty(cboATGRV.SelectedValue) Then
                    .sCodGrpVta = ""
                Else
                    .sCodGrpVta = cboATGRV.SelectedValue
                End If
                .sCodSgr = ""
                .bItmInv = chbbItmInv.Checked
                .bItmVta = chbbItmVta.Checked
                .bItmCom = chbbItmCom.Checked
                .bIndIVA = chbbIndIVA.Checked
                .sCodAlt = TxtsCodAlt.Text
                If String.IsNullOrEmpty(cboABTGE.SelectedValue) Then
                    .sTipGes = ""
                Else
                    .sTipGes = cboABTGE.SelectedValue
                End If
                .bItmAct = rdbItmAct.Checked
                .bItmIna = rdbItmIna.Checked
                .sCodTerPrv = txtsCodTerPrv.Text
                .sCodTerFte = txtsCodTerFte.Text
                .sCodItmFte = txtCodItmFte.Text
                If String.IsNullOrEmpty(cboACUNIcom.SelectedValue) Then
                    .sUniMedCom = ""
                Else
                    .sUniMedCom = cboACUNIcom.SelectedValue
                End If
                If String.IsNullOrEmpty(txtnCanUniCom.Text) Then
                    txtnCanUniCom.Text = "0"
                End If
                .nCanUniCom = CDbl(txtnCanUniCom.Text)
                .sUniEmpCom = txtsUniEmpCom.Text
                If String.IsNullOrEmpty(txtnCanUniECom.Text) Then
                    txtnCanUniECom.Text = "0"
                End If
                .nCanUniECom = CDbl(txtnCanUniECom.Text) '22
                If String.IsNullOrEmpty(cboATIVAcom.SelectedValue) Then
                    .sCodItoCom = ""
                Else
                    .sCodItoCom = cboATIVAcom.SelectedValue
                End If
                If String.IsNullOrEmpty(cboACUNIvta.SelectedValue) Then
                    .sUniMedVta = ""
                Else
                    .sUniMedVta = cboACUNIvta.SelectedValue
                End If
                If String.IsNullOrEmpty(txtnCanUniVta.Text) Then
                    txtnCanUniVta.Text = "0"
                End If
                .nCanUniVta = CDbl(txtnCanUniVta.Text)
                .sUniEmpVta = txtsUniEmpVta.Text
                If String.IsNullOrEmpty(txtnCanUniEVta.Text) Then
                    txtnCanUniEVta.Text = "0"
                End If
                .nCanUniEVta = CDbl(txtnCanUniEVta.Text) '27
                If String.IsNullOrEmpty(cboATIVAvta.SelectedValue) Then
                    .sCodItoVta = ""
                Else
                    .sCodItoVta = cboATIVAvta.SelectedValue
                End If

                If String.IsNullOrEmpty(cboATCCC.SelectedValue) Then
                    .sCriCtaCbe = ""
                Else
                    .sCriCtaCbe = cboATCCC.SelectedValue
                End If
                If String.IsNullOrEmpty(cboACUNIinv.SelectedValue) Then
                    .sUniMedInv = ""
                Else
                    .sUniMedInv = cboACUNIinv.SelectedValue
                End If
                If String.IsNullOrEmpty(cboATMEV.SelectedValue) Then
                    .sMetVlz = ""
                Else
                    .sMetVlz = cboATMEV.SelectedValue
                End If
                If String.IsNullOrEmpty(txtnCosItm.Text) Then
                    txtnCosItm.Text = "0"
                End If
                If String.IsNullOrEmpty(txtnUltPreEnt.Text) Then
                    txtnUltPreEnt.Text = "0"
                End If
                .nCosItm = CDbl(txtnCosItm.Text)
                .nUltPreEnt = CDbl(txtnUltPreEnt.Text)

                ' .sCodAlm = cboATALM.Text
                If String.IsNullOrEmpty(cboATALM.SelectedValue) Then
                    .sCodAlm = ""
                Else
                    .sCodAlm = cboATALM.SelectedValue
                End If
                If String.IsNullOrEmpty(cboATALMCom.SelectedValue) Then
                    .sCodAlmCom = ""
                Else
                    .sCodAlmCom = cboATALMCom.SelectedValue
                End If


                If String.IsNullOrEmpty(txtnSdoInv.Text) Then
                    txtnSdoInv.Text = "0"
                End If
                txtnTotInv.Text = CDbl(txtnSdoInv.Text) * CDbl(txtnCosItm.Text)
                .nSdoInv = CDbl(txtnSdoInv.Text) '34
                .sUbiAlm = txtsUbiAlm.Text
                .sIvaCom = ""
                .sIvaVta = ""
                .sCodCco = ""
                .bIndCan = chbbIndCan.Checked
                .bIndCos = chbbIndCos.Checked
                .bIndLibODP = chbbIndLibODP.Checked
                .bIndCanRes = chbbIndCanRes.Checked
                .bIndCanPry = chbbIndCanPry.Checked
                If String.IsNullOrEmpty(txtnSdoIni.Text) Then
                    txtnSdoIni.Text = "0"
                End If
                .nSdoIni = txtnSdoIni.Text
                If String.IsNullOrEmpty(txtnSdoIniAno.Text) Then
                    txtnSdoIniAno.Text = "0"
                End If
                .nSdoIniAno = txtnSdoIniAno.Text
                If String.IsNullOrEmpty(txtnCanResODP.Text) Then
                    txtnCanResODP.Text = "0"
                End If
                .nCanResODP = txtnCanResODP.Text
                If String.IsNullOrEmpty(txtnSdoFinDis.Text) Then
                    txtnSdoFinDis.Text = "0"
                End If
                .nSdoFinDis = txtnSdoFinDis.Text
                If String.IsNullOrEmpty(txtnCanPedODC.Text) Then
                    txtnCanPedODC.Text = "0"
                End If
                .nCanPedODC = txtnCanPedODC.Text
                If String.IsNullOrEmpty(txtnSdoFinPry.Text) Then
                    txtnSdoFinPry.Text = "0"
                End If
                .nSdoFinPry = txtnSdoFinPry.Text
                If String.IsNullOrEmpty(txtnLeadTime.Text) Then
                    txtnLeadTime.Text = "0"
                End If
                .nLeadTime = txtnLeadTime.Text
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarLista")
        End Try
    End Sub
    Private Sub BD_eILDMI1_Var()
        wg_eILDMI1 = New moe_Estructuras.eILDMI1
    End Sub
    Private Sub BD_Var_eIEDMI()
        Try
            With wl_eIEDMI
                vp_nId = wg_DTE1.Rows(0).Item(0)
                ' txtsCodItm.Text = .sCodItm
                mtbsCodItm.Text = .sCodItm
                TxtCodBar.Text = .sCodBar
                TxtsNomItm.Text = .sNomItm
                TxtsNomAlt.Text = .sNomAlt
                cboATCLI.SelectedValue = .sClsItm
                cboATGRI.SelectedValue = .sCodGrp
                cboATGRV.SelectedValue = .sCodGrpVta
                '.sCodSgr
                chbbItmInv.Checked = .bItmInv
                chbbItmVta.Checked = .bItmVta
                chbbItmCom.Checked = .bItmCom
                chbbIndIVA.Checked = .bIndIVA
                TxtsCodAlt.Text = .sCodAlt
                cboABTGE.SelectedValue = .sTipGes
                rdbItmAct.Checked = .bItmAct
                rdbItmIna.Checked = .bItmIna
                txtsCodTerPrv.Text = .sCodTerPrv
                txtsCodTerFte.Text = .sCodTerFte
                txtCodItmFte.Text = .sCodItmFte
                cboACUNIcom.SelectedValue = .sUniMedCom
                txtnCanUniCom.Text = .nCanUniCom
                txtsUniEmpCom.Text = .sUniEmpCom
                txtnCanUniECom.Text = .nCanUniECom
                cboATIVAcom.SelectedValue = .sCodItoCom
                cboACUNIvta.SelectedValue = .sUniMedVta
                txtnCanUniVta.Text = .nCanUniVta
                txtsUniEmpVta.Text = .sUniEmpVta '26
                txtnCanUniEVta.Text = .nCanUniEVta
                cboATIVAvta.SelectedValue = .sCodItoVta
                cboATCCC.SelectedValue = .sCriCtaCbe
                cboACUNIinv.SelectedValue = .sUniMedInv
                cboATMEV.SelectedValue = .sMetVlz
                txtnCosItm.Text = FormatCurrency(.nCosItm)
                txtnUltPreEnt.Text = FormatCurrency(.nUltPreEnt)
                cboATALM.SelectedValue = .sCodAlm
                cboATALMCom.SelectedValue = .sCodAlmCom
                txtnSdoInv.Text = FormatNumber(.nSdoInv, 4)
                txtnTotInv.Text = FormatCurrency(.nSdoInv * .nCosItm, 0)
                txtsUbiAlm.Text = .sUbiAlm
                chbbIndCan.Checked = .bIndCan
                chbbIndCos.Checked = .bIndCos
                chbbIndLibODP.Checked = .bIndLibODP
                chbbIndCanRes.Checked = .bIndCanRes
                chbbIndCanPry.Checked = .bIndCanPry
                txtnSdoIni.Text = FormatNumber(.nSdoIni, 4)
                txtnSdoIniAno.Text = FormatNumber(.nSdoIniAno, 4)
                txtnCanResODP.Text = FormatNumber(.nCanResODP, 4)
                txtnSdoFinDis.Text = FormatNumber(.nSdoFinDis, 4)
                txtnCanPedODC.Text = FormatNumber(.nCanPedODC, 4)
                txtnSdoFinPry.Text = FormatNumber(.nSdoFinPry, 4)
                txtnLeadTime.Text = FormatNumber(.nLeadTime, 0)
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eIEDMI")
        End Try
        ' wg_sClaPpl = txtsCodItm.Text
        wg_sClaPpl = mtbsCodItm.Text
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            BD_eIEDMI_DT(wg_DTE1)
            BD_Var_eIEDMI()
            dgv1.Enabled = True
            dgv_DetADgv()
            mof_ActivarOK(Me)
            ' dgv1.Enabled = True
            ' dgv_DetADgv()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try
    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarATALM() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATALM = New moe_Estructuras.eATALM
            wr_bEOFE2 = mof_fConATALM(vl_sCodAlm,
                                      wl_eATALM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATALM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATGRI() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATGRI = New moe_Estructuras.eATGRI
            wr_bEOFE2 = mof_fConATGRI(vl_sCodGrp,
                                      wl_eATGRI)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATGRP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATGRV() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATGRV = New moe_Estructuras.eATGRV
            wr_bEOFE2 = mof_fConATGRV(vl_sCodGrpVta,
                                      wl_eATGRV)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATGRV")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarIEDMI() As Boolean
        Try
            wr_bEOFE2 = True
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()

            'If txtsCodItm.Text <> "" Then
            If mtbsCodItm.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_sNomTblE2 = "IEDMI"
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
#Region "043 BD Cargar"
    Private Sub BD_CargarATALM()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATALM = New moe_Estructuras.eATALM
            wg_sTblCon1 = "ATALM"
            wl_frmLst.wp_sTxtFrm = "Almacenes"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATALM.sCodAlm <> "" Then
                wl_eATALM = wl_frmLst.wp_eATALM
                wl_CtrlDgv.CurrentRow.Cells("sCodAlm").Value = wl_eATALM.sCodAlm
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodAlm")
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_CargarATALM")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "045 BD Llamar frmGQLst"
    Private Sub BD_frmGQLst_IEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "IEDMI"
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI.sCodItm = mtbsCodItm.Text
            wl_frmLst.wp_eIEDMI.sNomItm = TxtsNomItm.Text
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> " " Then
                wl_eIEDMI = New moe_Estructuras.eIEDMI
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmGQLst_IEDMI")
        End Try
    End Sub
#End Region
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            wp_sCmdSel = "A"
            wl_bYesNo = False
            wr_bEOFE1 = True
            wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
            If wl_bYesNo Then
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = ""
                wp_sCodErr = wg_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                mof_ActivarOK(Me)
                wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
            Else
                mtbsCodItm.Enabled = True
                mtbsCodItm.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdActualizar_Click")
        End Try
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            wp_sCmdSel = "B"
            wg_sTipTbl = wl_sTipTbl
            wl_bYesNo = False
            mof_LmpMsgError()
            'If txtsCodItm.Text <> "" Then
            If mtbsCodItm.Text <> "" Then

                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_DTE1 = mof_fConTbl(wl_sNomTblE1,
                                      wg_sNomCmpE11,
                                      wg_sDatCmpE11,
                                      wg_sTipCmpE11,
                                      wg_sCmpOrdE11,
                                      wg_sTipOrdE11,
                                      wr_bEOFE1)
                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    '   wp_sDatCmp = txtsCodItm.Text
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = wg_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    'txtsCodItm.Focus()
                    mtbsCodItm.Enabled = True
                    mtbsCodItm.Focus()
                Else
                    BD_eIEDMI_DT(wg_DTE1)
                    BD_Var_eIEDMI()
                    mof_fLmpCtrl(Me.dgv1)
                    dgv_DetADgv()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    mtbsCodItm.Enabled = False
                    cmdOk.Focus()
                End If
            End If
            'txtsCodItm.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdBuscar_Click")
        End Try

    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Try
            wp_sCmdSel = "C"
            wg_sTipTbl = wl_sTipTbl
            wl_bYesNo = False
            mof_LmpMsgError()
            'If txtsCodItm.Text <> "" Then
            If Mid(mtbsCodItm.Text, 1, 1) = " " Then
                cmdCancelar.Focus()
                Exit Sub
            End If

            If mtbsCodItm.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_DTE1 = mof_fConTbl(wl_sNomTblE1,
                                      wg_sNomCmpE11,
                                      wg_sDatCmpE11,
                                      wg_sTipCmpE11,
                                      wg_sCmpOrdE11,
                                      wg_sTipOrdE11,
                                      wr_bEOFE1)
                If wr_bEOFE1 Then
                    wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                    If wl_bYesNo Then
                        wp_sNomTbl = wl_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = wg_sCodErrOk
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        mof_habTsbCrear()
                        mof_habTsbEliminar()
                        wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                        mof_ActivarOK(Me)
                        cmdOk.Focus()
                    End If
                Else
                    wp_sNomTbl = wl_sNomTblE1
                    'wp_sDatCmp = txtsCodItm.Text
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = wg_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mtbsCodItm.Focus()
                    'txtsCodItm.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdCrear_Click")
        End Try
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            wp_sCmdSel = "E"
            wg_sTipTbl = wl_sTipTbl
            wl_bYesNo = False
            mof_LmpMsgError()
            'If txtsCodItm.Text <> "" Then
            If mtbsCodItm.Text <> "" Then
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
                    wg_DTE1 = clnConTbl.cndtBuscar(wl_sNomTblE1,
                                                   wg_sNomCmpE11,
                                                   wg_sDatCmpE11,
                                                   wg_sTipCmpE11,
                                                   wg_sCmpOrdE11,
                                                   wg_sTipOrdE11,
                                                   wr_bEOFE1)
                    If Not wr_bEOFE1 Then

                        wp_sNomTbl = ""
                        wl_bYesNo = mov_VdasCodItm(vl_sCodItm,
                                                   wp_sNomTbl,
                                                   wl_bVda)

                        If wl_bVda = True Then
                            wl_bYesNo = clnIEDMI.cnEliminar(vl_sCodItm,
                                                            wr_bEOFE1)
                            If wl_bYesNo Then
                                mof_ActivarBuscar(Me)
                                wp_sNomTbl = wl_sNomTblE1
                                wp_sDatCmp = ""
                                wp_sCodErr = wg_sCodErrOk
                                mof_MsgError(wp_sNomTbl,
                                             wp_sDatCmp,
                                             wp_sCodErr)
                                mof_fLmpCtrl(Me)
                                mof_ActivarBuscar(Me)

                            Else
                                TxtCodBar.Focus()
                            End If
                        Else
                            wp_sDatCmp = vl_sCodItm
                            wp_sCodErr = "10-601"
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
            Dim wl_frmLst As New frmGQLst
            wg_eTEDMT = New moe_Estructuras.eTEDMT
            wl_bEOF = False
            wl_bEOF = BD_BuscarIEDMI()
            If Not wl_bEOF Then
                wg_sTblCon1 = "TEDMT_2"
                wl_frmLst.ShowDialog()
                If wl_frmLst.wp_eTEDMT.sCodTer <> " " Then
                    txtsCodTerPrv.Text = wg_eTEDMT.sCodTer
                    wl_sNomTblE1 = "IEDMI"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
    End Sub
    Private Sub cmdLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLinea.Click
        Try
            Dim wl_frmLst As New frmILDMI2
            wl_bEOF = False
            wl_bEOF = BD_BuscarIEDMI()
            If Not wl_bEOF Then
                'vg_sCodItm = txtsCodItm.Text
                vg_sCodItm = mtbsCodItm.Text
                wg_sTblCon1 = "ILDMI2"
                wg_sCmpCon11 = "sCodItm"
                wg_sCmpCon12 = "sCodter"
                wg_sTitCon11 = "Código ítem"
                wg_sTitCon12 = "Código Tercero"
                wg_sSelCon12 = ""
                wr_bEOFCon1 = True

                wl_frmLst.ShowDialog()
                wl_sNomTblE1 = "IEDMI"
                ' TextBox6.Text = wg_sSelCon12
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLinea_Click")
        End Try
    End Sub
    Private Sub cmdMaestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMaestro.Click
        Dim vl_frmTEDMT As New frmTEDMT
        'Dim vl_frmTEDMT As New frmIEDMI
        wl_bEOF = False
        wl_bEOF = BD_BuscarIEDMI()
        If Not wl_bEOF Then
            wg_sCodItm = txtsCodTerPrv.Text
            MsgBox(wg_sCodItm)
            vl_frmTEDMT.Show()
        End If
    End Sub
    Private Sub cmdIEDMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIEDMI.Click
        Try
            BD_frmGQLst_IEDMI()
            If wl_eIEDMI.sCodItm <> "" Then
                mtbsCodItm.Text = wl_eIEDMI.sCodItm
                TxtsNomItm.Text = wl_eIEDMI.sNomItm
                mtbsCodItm.Focus()
                cmdBuscar_Click(Nothing,
                                Nothing)
                TxtsNomItm.Focus()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdIEDMI_Click")
        End Try
    End Sub
#End Region

#Region "TabPage_GotFocus Lista Controladores de Eventos (Remitente_evento)"


    Private Sub tbc001_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbc001.GotFocus
        chbbIndIVA.Focus()
    End Sub

    Private Sub tbp002_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp002.GotFocus
        txtsCodTerPrv.Focus()
    End Sub

    Private Sub tbp003_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp003.GotFocus
        cboACUNIvta.Focus()
    End Sub

    Private Sub tbp004_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbp004.GotFocus
        cboATCCC.Focus()
    End Sub
#End Region
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text
            wl_nRow = dgv1.Rows.Count
            vl_sCodAlm = cboATALM.SelectedValue

            If wl_nRow = 1 Then
                If String.IsNullOrEmpty(dgv1.Rows(0).Cells("sCodAlm").Value) Then
                    dgv1.Rows(0).Cells("sCodAlm").Value = vl_sCodAlm
                End If
                If String.IsNullOrEmpty(dgv1.Rows(0).Cells("sCodItm").Value) Then
                    dgv1.Rows(0).Cells("sCodItm").Value = vl_sCodItm
                End If
            End If

            For wl_nRow = 0 To dgv1.RowCount - 1
                wl_eILDMI1 = New moe_Estructuras.eILDMI1
                dgv1.Rows(0).Cells("sCodItm").Value = vl_sCodItm
                If dgv1.Rows(wl_nRow).Cells("sCodAlm").Value <> Nothing Then

                    moo_eILDMI1_DGV(wl_eILDMI1,
                                    dgv1,
                                    wl_nRow)

                    wp_sCmdSel = wl_sCmdAnt
                    If wl_eILDMI1.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv1.Rows(wl_nRow).Visible = True Then
                        If vl_sCodAlm <> Nothing Then
                            wl_bYesNo = clnIEDMI.cnCrearActualizarILMDI1(wl_eILDMI1,
                                                                         wr_bEOF,
                                                                         wp_sCmdSel)
                        End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnIEDMI.cnEliminarILMDI1(vl_sCodItm,
                                                                  vl_sCodAlm,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdiRowILDMI1()
        Try
            vl_sCodItm = mtbsCodItm.Text
            With dgv1
                wl_nCntRow = .RowCount
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                Dim wl_dgvrows As DataGridViewRow = dgv1.Rows(wl_nRow)
                wl_dgvrows.Height = 16
                .CurrentRow.Cells("sCodItm").Value = vl_sCodItm
                .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)
            End With
            wl_nTab = 0
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count
            dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            'dgv1.Rows(wl_nRow).Cells(1).Value = txtsCodItm.Text
            dgv1.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        'vp_sCodItm = txtsCodItm.Text
        vl_sCodItm = mtbsCodItm.Text
        Try
            wg_DTL1 = clnIEDMI.cndtConsultarILMDI1(vl_sCodItm,
                                                   wr_bEOFL1)



            If dgv1.Rows.Count > 0 Then
                dgv1.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRowILDMI1()
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
    Private Function dgv1_VdaRow(ByRef wl_bVdaRow) As Boolean
        Try
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then
                wl_bVdaRow = False
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_VdaRow")
            MsgBox(ex.Message)
        End Try
        Return wl_bVdaRow
    End Function
#End Region
#Region "071 DGV Procedimientos del Usuario. Comunes"
    Private Sub dgv_APDGV()
        'Fec_Ult_Mod: 2014.04.20
        wl_eAPDGV = New moe_Estructuras.eAPDGV
        Try
            wg_nColIni = 0
            wg_nColFin = 0
            wl_nColIni = 0
            wl_nColFin = 0
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nColIni = wg_nColIni
            wl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin
            wl_nTotCol = UBound(wl_aeAPDGV) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APDGV")
            MsgBox(ex.Message)

        End Try
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
                wl_eAPDGV = wl_aeAPDGV(wp_nC)
                With wl_eAPDGV
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
    Private Sub dgv_EliminarLinea()
        Dim wl_nRowSub As Integer
        wl_bVda = True
        wl_bYesNo = True

        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_sCodItm = vl_sCodItm
            wl_sCodAlm = dgv1.CurrentRow.Cells("sCodAlm").Value
            wp_sNomTbl = ""
            wl_bYesNo = mov_VdasCodItmCodAlm(wl_sCodItm,
                                             wl_sCodAlm,
                                             wp_sNomTbl,
                                             wl_bVda)



            If wl_bVda = True Then
                wl_nRowSub = (dgv1.Rows.Count).ToString
                wl_nCol = dgv1.CurrentRow.Index
                If wl_nRowSub >= 0 Then
                    dgv1.Rows(wl_nCol).Visible = False
                    wl_nCol = 0
                    For wl_nRowSub = 0 To dgv1.Rows.Count - 1
                        If dgv1.Rows(wl_nRowSub).Visible = True Then
                            dgv1.Rows(wl_nRowSub).HeaderCell.Value = (wl_nCol + 1).ToString
                            wl_nCol = wl_nCol + 1
                        End If
                    Next
                    dgv1.RefreshEdit()
                End If
                cmdActualizar.Focus()
            Else
                wp_sDatCmp = wl_sCodItm & " " & wl_sCodAlm
                wp_sCodErr = "10-617"
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                mof_ActivarOK(Me)
                cmdCancelar.Focus()
            End If

        Catch
            MsgBox("Error: dgv_EliminarLinea")
        End Try
    End Sub
    
#End Region
#Region "072 DGV Controladores de Eventos "
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv1_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Try

            wp_sNomTbl = wl_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = ""
            wl_nRow = e.RowIndex
            wl_nCol = e.ColumnIndex
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                'dgv1_Valida()
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv1_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
        Try
            wl_CtrlDgv = dgv1
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            wl_nCol = e.ColumnIndex
            wl_nRow = e.RowIndex
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If

            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodAlm" Then
                BD_CargarATALM()
                If cboATCCC.SelectedValue = "Almacén" Then
                    If wl_eATALM.sCodAlm <> "" Then
                        moo_DGVILDMI1_eATALM(dgv1,
                                             wl_eATALM,
                                             wl_nRow)
                    End If
                Else
                    If cboATCCC.SelectedValue = "Grupo de inventarios" Then
                        wl_eATGRI = New moe_Estructuras.eATGRI
                        wl_eATGRI.sCodGrp = vl_sCodGrp

                        If wl_eATGRI.sCodGrp <> "" Then
                            BD_BuscarATGRI()
                            moo_DGVILDMI1_eATGRI(dgv1,
                                                 wl_eATGRI,
                                                 wl_nRow)
                        End If

                    End If
                End If



            End If



        Catch ex As Exception
            MsgBox("Error :  dgv1_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellValueChanged
   Try
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_CellValueChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv1.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv1.CurrentCell = dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv1_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyDown
        Try
            If e.KeyCode = Keys.Tab Then
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_KeyDown")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv1.KeyPress
        Try

            If e.KeyChar = ChrW(Keys.Tab) Then

                wl_nRowKP = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKP = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKP = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKP = wl_CtrlDgv.CurrentCell.ColumnIndex
            Else
                wl_nRowKD = wl_CtrlDgv.CurrentCellAddress.Y
                wl_nColKD = wl_CtrlDgv.CurrentCellAddress.X
                wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
                wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex

            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_KeyPress")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_bAdiRow As Boolean = False

        Try
            mof_LmpMsgError()
            wl_CtrlDgv = dgv1
            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCntCol = wl_CtrlDgv.ColumnCount
            If sender Is Nothing Then
                wl_bAva = True
                wl_bRet = False
            Else
                If e.KeyCode = Keys.Tab Then
                    wl_bAva = True
                End If
                If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                    wl_bRet = True
                End If
            End If
            mov_dgv_VdaIEDMI(wl_nCol,
                             wl_nColAnt,
                             wl_nColSig,
                             wl_nRow,
                             wl_nRowAnt,
                             wl_nRowSig,
                             wl_CtrlDgv,
                             wl_aeAPDGV)

            If wl_bAva Then
                If sender Is Nothing Then
                    wl_nCol = wl_nCol + 1
                End If

                wl_bAva = mof_dgvSigCol(wl_nCol,
                                        wl_nRow,
                                        wl_nTotCol,
                                        wl_nColFin,
                                        wl_nColIniGrl,
                                        wl_nCntRow,
                                        dgv1,
                                        wl_bAdiRow)
                '           If wl_bAdiRow = True Then
                'dgv_AdiRowILDMI1()
                'wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                'End If
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin,
                                         wl_nColIniGrl,
                                         wl_nCntRow,
                                         dgv1,
                                         wl_nColKD)
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
            End If
            wl_nRowAnt = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColAnt = wl_CtrlDgv.CurrentCell.ColumnIndex

        Catch ex As Exception
            MsgBox("Error: dgv1_KeyUp")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub dgv1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            wl_nRow = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nCol = wl_CtrlDgv.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv1_KeyUp(Nothing,
                           Nothing)
            End If

        Catch ex As Exception
            MsgBox("Error : dgv1_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgv1.RowsRemoved
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
        Try
            wl_sNomFrm = "frmIEDMI"
            wl_nNroDgv = 0
            Plo_SelDGV(wl_nNroDgv)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        wl_bYesNo = False
        wl_bEdit = False
        wg_sCodErrAdi = "10-301"
        wg_sCodErrCon = "10-101"
        wg_sCodErrOk = "20-001"
        wg_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
        wg_sTitMsgEli = "Mensaje del sistema"
        wl_sCodDgv = "dgv1"
        ' globales
        vg_sCodItm = ""

        wg_sCmpTSB = "sCodItm"
        wg_sDatTSB = ""
        '   mof_ActivarBuscar(Me)

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
        mof_ActivarCrear(Me)
        Plo_IniciarVar()

        dgv1.Enabled = True
        mof_ConfigurarDGV(Me.dgv1,
                          wl_nTotCol)
        dgv_ConfiguraCol()
        dgv1.Rows.Clear()
        'dgv_AdicionarLinea()
        dgv_AdiRowILDMI1()
        'txtsCodItm.Focus()
        mtbsCodItm.Enabled = True
        mtbsCodItm.Focus()
    End Sub
    Private Sub Plo_ActivarBuscar()
        '  mof_fLmpCtrl(Me)
        Plo_IniciarVar()
        mof_ActivarBuscar(Me)


        dgv1.Enabled = True
        dgv1.Rows.Clear()
        mof_ConfigurarDGV(Me.dgv1,
                          wl_nTotCol)
        dgv_ConfiguraCol()
        dgv_AdiRowILDMI1()
        mtbsCodItm.Enabled = True
        mtbsCodItm.Focus()
        '
    End Sub
    Private Sub Plo_SelDGV(ByVal wl_nNroDgv As Integer)
        wl_CtrlDgv = New DataGridView
        Try
            If wl_nNroDgv = 0 Then
                dgv1.Visible = True
                wl_sCodDgv = "dgv1"
                wl_CtrlDgv = Me.dgv1
            End If
            dgv_APDGV()
        Catch ex As Exception
            MsgBox("Error : Plo_SelDGV")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "082 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"

    Private Sub mtbsCodItm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtbsCodItm.KeyUp
        Try
            If e.KeyData = Keys.Enter Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)

                End If
            End If

            If cmdCrear.Visible = True Then
                If Mid(mtbsCodItm.Text, 1, 1) = " " Then
                    mtbsCodItm.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: mtbsCodItm_KeyUp")
        End Try

    End Sub
    Private Sub mtbsCodItm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbsCodItm.LostFocus
        Try
            If cmdBuscar.Visible = True Then
                If Mid(mtbsCodItm.Text, 1, 1) <> " " Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                Else
                    cmdIEDMI.Focus()
                End If
                Exit Sub
            End If
            If cmdCrear.Visible = True Then
                If Mid(mtbsCodItm.Text, 1, 1) = " " Then
                    mtbsCodItm.Focus()
                    Exit Sub
                End If
                wr_bEOFE2 = False
                BD_BuscarIEDMI()
                If wr_bEOFE2 = False Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = wg_sCodErrAdi
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mtbsCodItm.Focus()

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: mtbsCodItm_LostFocus")
        End Try

    End Sub
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
        ' Dim wl_cvMTB As Control = ActiveControl
        '     wl_cvMTB = GetNextControl(wl_cvMTB, False)
        '     If cmdCancelar.Focused = False Then
        '         If wl_cvMTB IsNot Nothing Then
        '             If wl_cvMTB.Name = "mtbsCodItm" Then
        '                 mov_VdaMTB(wl_bVda,
        '                            mtbsCodItm)
        '             End If
        '         End If
        '     End If
        '
        '        DirectCast(sender, MaskedTextBox).BackColor = wg_ClrLost
        '

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
        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region

#Region "160 TSB ToolStrip Procedimientos eventos de la barra de herramientas:BCPASUE"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        Plo_ActivarBuscar()
        'mof_ActivarBuscar(Me)
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
        dgv_AdiRowILDMI1()
    End Sub
    Private Sub tsmi_EliminarLinea()

        mof_ActivarActualizar(Me)
        dgv_EliminarLinea()
    End Sub
    Private Sub tsmi_Eliminar()
        mof_ActivarEliminar(Me)
    End Sub



#End Region
#End Region


End Class
