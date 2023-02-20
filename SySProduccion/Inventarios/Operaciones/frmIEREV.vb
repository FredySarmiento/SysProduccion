Imports System.Data.OleDb
Imports System.Data
Public Class frmIEREV
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-10

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
    Dim vl_nNroSig As Double
    Dim wl_bCmpVdo As Boolean
    ' wl Booleanas
    Dim wl_bEdit As Boolean
    Dim wl_bEOF As Boolean
    Dim wl_bSwsBor As Boolean
    Dim wl_bCboAPLND1 As Boolean

    Dim wl_bVda As Boolean
    Dim wl_bVdoCom As Boolean
    Dim wl_bVdoVta As Boolean
    Dim wl_bYesNo As Boolean
    ' wl numéricas
    Dim wl_nBoxMsg As Integer
    Dim wl_nNroDocAnt As Long
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

    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_nNroOpc As Integer
    Dim wp_sTipCmp As String
#End Region
#Region "012 BD - Variables campos BD Locales"
    'IEREV
    Dim vl_nId As Long
    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Long
    Dim vl_sCodSer As String
    Dim vl_sCodTra As String
    Dim vl_sEstDoc As String
    Dim vl_sTipRev As String
    Dim vl_dFecCtb As Date
    Dim vl_dFecDoc As Date
    Dim vl_dFecVto As Date
    Dim vl_dFecSys As Date
    Dim vl_sDocRef As String
    Dim vl_nTotDoc As Double
    Dim vl_sClsDoc As String
    Dim vl_sCmn As String
    Dim vl_sCodCteCtb As String
    Dim vl_nNroCteCtb As Long
    Dim vl_nIdFECCT As Long
    Dim vl_sCodMon As String
    Dim vl_sCodUsr As String
    Dim vl_sCodAut As String
    Dim vl_sEstPdo As String
    'ILREV1
    Dim vl_sCodItm As String
    Dim vl_sCodAlm As String

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas
    Dim wl_bvdaCbo As Boolean
    Dim vl_nTamCmp As Integer
    Dim wl_bVdaRow As Boolean
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_nCellCod As Integer
    Dim wl_nCellDes As Integer
    Dim wl_nCntCol As Integer
    Dim wl_nCntRow As Integer
    Dim wl_nCol As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColCVC As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColKD As Integer
    Dim wl_nColKP As Integer
    Dim wl_nColKU As Integer
    Dim wl_nColNom As Integer
    Dim wl_nColSig As Integer
    Dim wl_nNroCol As Integer
    Dim wl_nNroDgv As Integer
    Dim wl_nRow As Integer
    Dim wl_nRowAct As Integer
    Dim wl_nRowAlto As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nRowCVC As Integer
    Dim wl_nRowIni As Integer
    Dim wl_nRowKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nRowSig As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nTotCol As Integer
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fila
#End Region
#Region "014 Objetos locales"
    Dim clnActTab As New ClaseNegocios.clnActTbl
    Dim clnTblAB As New ClaseNegocios.clnTblAB
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTE1 As DataTable
#End Region
#Region "015 Estructuras"

    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim vl_aeIEREV() As moe_Estructuras.eIEREV
    Dim wl_aeILREV1() As moe_Estructuras.eILREV1
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eABESD As New moe_Estructuras.eABESD
    Dim wl_eABTIR As New moe_Estructuras.eABTIR
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATTIN As New moe_Estructuras.eATTIN
    Dim wl_eFECTT As New moe_Estructuras.eFECTT
    Dim wl_eFLCTT1 As New moe_Estructuras.eFLCTT1
    Dim wl_eIEREV As New moe_Estructuras.eIEREV
    Dim wl_eILREV1 As New moe_Estructuras.eILREV1
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eIELDMI1 = New moe_Estructuras.eIELDMI1

#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#End Region

#Region "020 frm Eventos - Principal"

    Private Sub frmIEREV_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error :  frmIEREV_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmIEREV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_RemoveHandler()
            grl_AddHandler()
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            Plo_IniciarEst() '080
            Plo_IniciarDoc() '080
            Plo_IniciarVar() '080
            wl_sTipTbl = "E2"
            wg_sTipTbl = wl_sTipTbl
            BD_DatPrmTipTbl(wg_sTipTbl)
            dgv_APDGV()
            Plo_IniciarVarDGV() '080
            grl_EventCtrl(Me)
            Cbo_CargarLst()
            Plo_ActivarCrear() '080
            Plo_TxtIni() '080
        Catch ex As Exception
            MsgBox("Error :  frmIEREV_Load")
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarAPLND1()
            Cbo_CargarATTIN()
            Cbo_CargarABTIR()
            wl_bvdaCbo = True
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABTIR()
        Try
            wl_eABTIR = New moe_Estructuras.eABTIR
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABTIR"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnTblAB.cndtCrgABTIR(wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABTIR.DataSource = wg_DTLst1
                cboABTIR.ValueMember = wg_DTLst1.Columns("sTipRev").Caption.ToString
                cboABTIR.DisplayMember = wg_DTLst1.Columns("sNomTipRev").Caption.ToString
            End If
            wl_bvdaCbo = False
            cboABTIR.SelectedValue = "1"
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABTIR")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarAPLND1()
        Try
            wl_bCboAPLND1 = False
            wg_sTblLst1 = "APLND1"
            wr_bEOFLst1 = wr_bEOFLst1
            wg_DTLst1 = clnConTbl.cndtCargarNro(wg_sTblLst1,
                                                wl_eIEREV.sCodDoc,
                                                wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboAPLND1.DataSource = wg_DTLst1
                cboAPLND1.ValueMember = wg_DTLst1.Columns("sCodSer").Caption.ToString
                cboAPLND1.DisplayMember = wg_DTLst1.Columns("sCodSer").Caption.ToString
                cboAPLND1.SelectedValue = wg_DTE2.Rows(0).Item("sCodSer")
            End If
            wl_bCboAPLND1 = True
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarAPLND1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboABTIR_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboABTIR.SelectedIndexChanged
        Try
            If wl_bvdaCbo = True Then
                vl_sTipRev = cboABTIR.SelectedValue
                wl_eIEREV.sTipRev = vl_sTipRev
                dgv1.Rows.Clear()
                dgv_APDGV()
                Plo_IniciarVarDGV() '080
                dgv_AdiRow()

            End If
        Catch ex As Exception
            MsgBox("Error :  cboABTIR_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboAPLND1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim wl_i As Integer
        Try
            If wl_bCboAPLND1 Then
                wl_i = cboAPLND1.SelectedIndex


                If cmdCrear.Visible = True Then
                    vl_sCodSer = cboAPLND1.SelectedValue

                    wg_DTLst1 = clnConTbl.cndtSelSer(wg_sTblLst1,
                                                       vl_sCodDoc,
                                                       vl_sCodSer,
                                                       wr_bEOFLst1)
                    If Not wr_bEOFLst1 Then
                        moo_eAPLND1_DT(wl_eAPLND1,
                                       wg_DTLst1,
                                       0)
                        txtnNroDoc.Text = wl_eAPLND1.nNroSig
                        vl_nNroDoc = wl_eAPLND1.nNroSig
                        vl_sCodSer = wl_eAPLND1.sCodSer
                        Plo_IniciarVar()
                        wl_CtrlDgv.Rows.Clear()
                        dgv_AdiRowILREV1()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cboAPLND1_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATTIN()
        Try
            '  cboABESD.Enabled = False
            wl_eATTIN = New moe_Estructuras.eATTIN
            wl_eATTIN.sTipMov = "E"
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATTIN"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnTblAB.cndtCrgATTIN(wl_eATTIN,
                                              wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATTIN.DataSource = wg_DTLst1
                cboATTIN.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboATTIN.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATTIN")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "040 BD Procedimientos"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        '  wl_sNomTblE1 = "CEODC"
        wl_bYesNo = False
        Try
            Plo_Var_Frm()
            BD_eIEREV_Var()

            vl_dFecCtb = dtpFecCtb.Text
            vl_dFecDoc = dtpFecDoc.Text

            wl_bEOF = True
            vl_sEstPdo = "0"
            wl_bEOF = mov_VdaPdoCtb(vl_dFecCtb, vl_sEstPdo)
            If wl_bEOF = True Then
                MsgBox("Período Contable, para la fecha contable, No Existe")
                dtpFecCtb.Focus()
                Return wl_bYesNo
            Else
                If vl_sEstPdo = "2" Then
                    MsgBox("Período Contable para la fecha contable está Cerrado. No se puede actualizar")
                    dtpFecCtb.Focus()
                    cmdCancelar.Focus()
                    Return wl_bYesNo
                End If
            End If
            wl_bEOF = mov_VdaPdoCtb(vl_dFecDoc, vl_sEstPdo)
            If wl_bEOF = True Then
                MsgBox("Período Contable, para la fecha del documento, No Existe")
                dtpFecDoc.Focus()
                Return wl_bYesNo
            Else
                If vl_sEstPdo = "2" Then
                    MsgBox("Período Contable, para la fecha del documento, Está Cerrado")
                    dtpFecDoc.Focus()
                    Return wl_bYesNo
                End If
            End If

            If wl_CtrlDgv.Rows.Count Then
                If wl_CtrlDgv.Rows(0).Cells("sCodItm").Value = "" Then
                    MsgBox("Documento no tiene detalle")
                    dtpFecCtb.Focus()
                    Return wl_bYesNo
                End If
            End If
            If cmdCrear.Visible = True Then
                For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                    If wl_CtrlDgv.Rows(wl_nI).Visible = False Then
                        Continue For
                    End If
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value = "" Then
                        Exit For
                    End If
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodAlm").Value = "" Then
                        MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " no tiene almacén")
                        wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("sCodAlm")
                        Return wl_bYesNo
                    End If
                    dgv_Vda_SdoAlm()
                    If wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm").Value = 0 Then
                        MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " tiene Cantidad en 0")
                        wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm")
                        Return wl_bYesNo
                    End If
                    If wl_CtrlDgv.Rows(wl_nI).Cells("bIndCos").Value = True Then
                        If wl_CtrlDgv.Rows(wl_nI).Cells("nPreUni").Value = 0 Then
                            MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " tiene Precio Unitario en 0")
                            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nPreUni")
                            Return wl_bYesNo
                        End If
                    End If
                    If wl_CtrlDgv.Rows(wl_nI).Cells("bIndCan").Value = True Then
                        If wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm").Value > wl_CtrlDgv.Rows(wl_nI).Cells("nSdoAlm").Value Then
                            MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " no tiene saldo suficiente")
                            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm")
                            Return wl_bYesNo
                        End If
                    End If
                Next
            End If

            wg_bVdaE1 = True
            If Not mov_VdaTxt(wg_bVdaE1,
                              txtnNroDoc) Then
                txtnNroDoc.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            wl_bYesNo = clnIEINV.cnCrearActIEREV(wl_eIEREV,
                                                 wp_sCmdSel,
                                                 wr_bEOFE1)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        'Fec Ult Act.: 2014.04.22
        Try
            ' Tipo de tabla
            If wg_sTipTbl = "E1" Then
                wl_sNomTblE1 = "IEREV"
                wg_sNomCmpE11 = "nNroDoc"
                wg_sTipCmpE11 = "N"
                wg_sTitCmpE11 = "Número documento"
                wg_sDatCmpE11 = CLng(txtnNroDoc.Text)
                wg_sClaPpl = txtnNroDoc.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "E2" Then
                wl_sNomTblE1 = "IEREV"
                wg_sNomCmpE11 = "sCodDoc"
                wg_sTipCmpE11 = "S"
                wg_sTitCmpE11 = "Código Mov "
                wg_sDatCmpE11 = vl_sCodDoc
                wg_sNomCmpE12 = "nNroDoc"
                wg_sTipCmpE12 = "N"
                wg_sTitCmpE12 = "Numero documento"
                wg_sDatCmpE12 = CLng(txtnNroDoc.Text)
                wg_sCmpTSB = CLng(txtnNroDoc.Text)
                wl_sClaPPl1 = wg_sDatCmpE11
                wl_sClaPPl2 = wg_sDatCmpE12
                wr_bEOFE1 = True
            End If

        Catch ex As Exception
            MsgBox("Error :  BD_DatPrmTipTbl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_DatPrmTSB()
        Try
            wg_nCmpCla = 3
            wg_sCmpTSB1 = "sCodDoc"
            wg_sCmpTSB2 = "nNroDoc"
            Select Case wg_nCmpCla
                Case 1
                    wg_sCmpTSB = wg_sCmpTSB1
                    wg_sDatTSB = wl_eIEREV.nID
                    wg_sTipCmpTSB = "N"

                Case 2
                    wg_sCmpTSB = wg_sCmpTSB2
                    wg_sDatTSB = wg_sClaPpl
                    wg_sTipCmpTSB = "N"
                Case 3
                    wg_sDatTSB1 = wl_sClaPPl1
                    wg_sTipCmpTSB1 = "S"
                    wg_sDatTSB2 = wl_sClaPPl2
                    wg_sTipCmpTSB2 = "N"
            End Select
        Catch ex As Exception
            MsgBox("Error :  BD_DatPrmTSB")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BD_eIEREV_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eIEREV = New moe_Estructuras.eIEREV
            moo_eIEREV_DT(wl_eIEREV,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox("Error :  BD_eIEREV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_eIEREV_Var()
        Try
            wl_eIEREV = New moe_Estructuras.eIEREV
            With wl_eIEREV
                .nID = vl_nId
                .sCodDoc = vl_sCodDoc '1
                .nNroDoc = vl_nNroDoc
                .sCodSer = vl_sCodSer
                .sCodTra = vl_sCodTra
                .sEstDoc = vl_sEstDoc
                .sTipRev = vl_sTipRev '5
                .dFecCtb = vl_dFecCtb
                .dFecDoc = vl_dFecDoc
                .dFecVto = vl_dFecVto
                .dFecSys = vl_dFecSys
                .sDocRef = vl_sDocRef '10
                .nTotDoc = vl_nTotDoc
                .sClsDoc = vl_sClsDoc
                .sCmn = vl_sCmn
                .sCodCteCtb = vl_sCodCteCtb
                .nNroCteCtb = vl_nNroCteCtb
                .nIdFECCT = vl_nIdFECCT
                .sCodMon = vl_sCodMon
                .sCodUsr = vl_sCodUsr
                .sCodAut = vl_sCodAut '20
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eIEREV_Var")
        End Try
    End Sub
    Private Sub BD_eILREV1_Var(ByVal wl_nRow)
        Try
            wl_eILREV1 = New moe_Estructuras.eILREV1
            moo_eILREV1_DGVILREV1(wl_eILREV1,
                                  wl_CtrlDgv,
                                  wl_nRow)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eILREV1_Var")
        End Try
    End Sub
    Private Sub BD_Var_eIEREV()
        Try
            With wl_eIEREV
                vl_nId = .nID
                vl_sCodDoc = .sCodDoc
                vl_nNroDoc = .nNroDoc
                vl_sCodSer = .sCodSer
                vl_sCodTra = .sCodTra
                vl_sEstDoc = .sEstDoc
                vl_sTipRev = .sTipRev
                vl_dFecCtb = .dFecCtb
                vl_dFecDoc = .dFecDoc
                vl_dFecVto = .dFecVto
                vl_dFecSys = .dFecSys
                vl_sDocRef = .sDocRef
                vl_nTotDoc = .nTotDoc
                vl_sClsDoc = .sClsDoc
                vl_sCmn = .sCmn
                vl_sCodCteCtb = .sCodCteCtb
                vl_nNroCteCtb = .nNroCteCtb
                vl_nIdFECCT = .nIdFECCT
                vl_sCodMon = .sCodMon
                vl_sCodUsr = .sCodUsr
                vl_sCodAut = .sCodAut
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eIEREV")
        End Try


    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            BD_eIEREV_DT(wg_DTE1)
            BD_Var_eIEREV()
            Plo_Frm_Var()
            dgv_DetADgv()
            BD_DatPrmTipTbl(wg_sTipTbl)
            Plo_InactCmpAct()
            mof_ActivarOK(Me)
            cmdOk.Focus()

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
            wr_bEOFE2 = mof_fConATALM(wl_eATALM.sCodAlm,
                                      wl_eATALM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATALM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarABTIR() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eABTIR = New moe_Estructuras.eABTIR
            wr_bEOFE2 = mof_fConABTIR(wl_eABTIR.sTipRev,
                                      wl_eABTIR)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarABTIR")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarIEDMI() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wr_bEOFE2 = mof_fConIEDMI(vl_sCodItm,
                                      wl_eIEDMI)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarIEDMI")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarILREV1() As Boolean
        Try
            wl_DTE1 = New DataTable

            wr_bEOFE2 = True
            wl_eILREV1 = New moe_Estructuras.eILREV1
            wl_DTE1 = clnIEINV.cndtConILREV1(wl_eILREV1,
                                             vl_sCodAlm)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarILREV1")
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
    Private Sub BD_CargarIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_eIELDMI1 = New moe_Estructuras.eIELDMI1
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_sTxtFrm = "Items de inventarios"
            wg_sTblCon1 = "IEDMI"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> "" Then
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
                wl_CtrlDgv.CurrentRow.Cells("sCodItm").Value = wl_frmLst.wp_eIEDMI.sCodItm
                wl_CtrlDgv.CurrentRow.Cells("sNomItm").Value = wl_frmLst.wp_eIEDMI.sNomItm
                wl_CtrlDgv.CurrentRow.Cells("sNomAlt").Value = wl_frmLst.wp_eIEDMI.sNomAlt
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodItm")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarIEDMI")
        End Try
    End Sub
    Private Sub BD_CargarIEDMIR()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wg_sTblCon1 = "IEDMIR"
            wl_frmLst.wp_sTxtFrm = "Items de inventarios"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> "" Then
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
                wl_CtrlDgv.CurrentRow.Cells("sCodItm").Value = wl_frmLst.wp_eIEDMI.sCodItm
                wl_CtrlDgv.CurrentRow.Cells("sNomItm").Value = wl_frmLst.wp_eIEDMI.sNomItm
                wl_CtrlDgv.CurrentRow.Cells("sNomAlt").Value = wl_frmLst.wp_eIEDMI.sNomAlt
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodItm")
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_CargarIEDMIR")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "044 BD Contabilización"
    Private Sub BD_FECTT_GEMOV()
        Try
            wl_bYesNo = False
            wl_eFECTT = New moe_Estructuras.eFECTT


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_FECTT_GEMOV")
        End Try
    End Sub
    Private Sub BD_FLCTT1_GLMOV1()
        Try
            wl_eFLCTT1 = New moe_Estructuras.eFLCTT1


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_FLCTT1_GLMOV1")
        End Try
    End Sub
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
                wp_sCodErr = wg_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                mof_ActivarOK(Me)
                wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                txtnNroDoc.Focus()
                Plo_IniciaFrm()

            Else
                '   txtnNroDoc.Focus()
            End If
            'Plo_IniciaFrm()
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
            If txtnNroDoc.Text <> "" Then
                vl_nNroDoc = CInt(txtnNroDoc.Text)
                wl_eIEREV = New moe_Estructuras.eIEREV
                wl_eIEREV.sCodDoc = vl_sCodDoc
                wl_eIEREV.sCodSer = vl_sCodSer
                wl_eIEREV.nNroDoc = vl_nNroDoc
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_DTE1 = clnIEINV.cndtConIEREV(wl_eIEREV,
                                                wr_bEOFE1)

                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtnNroDoc.Text
                    wp_sCodErr = "10-119"
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    txtnNroDoc.Focus()
                Else

                    BD_eIEREV_DT(wg_DTE1)
                    BD_Var_eIEREV()
                    Plo_Frm_Var()
                    mof_fLmpCtrl(Me.dgv1)
                    dgv_DetADgv()
                    Plo_InactCmpAct()
                    cmdLstIEREV.Enabled = False
                    mof_ActivarOK(Me)
                    '      mof_habTsbEliminar()

                End If

            End If
            txtnNroDoc.Focus()

        Catch ex As Exception
            MsgBox("Error : cmdBuscar_Click")
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
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Try
            wp_sCmdSel = "C"
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtnNroDoc.Text <> "" Then

                BD_DatPrmTipTbl(wg_sTipTbl)

                wg_DTE1 = mof_fConTblE2(wl_sNomTblE1,
                                        wg_sNomCmpE11,
                                        wg_sDatCmpE11,
                                        wg_sTipCmpE11,
                                        wg_sNomCmpE12,
                                        wg_sDatCmpE12,
                                        wg_sTipCmpE12,
                                        wr_bEOFE1)


                If wr_bEOFE1 Then

                    wp_nBoxMsg = 4
                    wp_sDesMsg = wg_sDesMsgAdi
                    wp_sTitMsg = wg_sTitMsgAdi
                    wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                             wp_sDesMsg,
                                             wp_sTitMsg)

                    If wp_nResMsg = 6 Then



                        wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                        If wl_bYesNo Then
                            wp_sNomTbl = wl_sNomTblE1
                            wp_sDatCmp = ""
                            wp_sCodErr = wg_sCodErrOk
                            mof_MsgError(wp_sNomTbl,
                                         wp_sDatCmp,
                                         wp_sCodErr)
                            mof_ActivarOK(Me)
                            mof_habTsbCrear()
                            mof_habTsbEliminar()
                            wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                            PloNroSig_APEND()
                            PloNroSig_APLND1()
                            '  mof_InhabCtrl(Me)
                            Plo_InactCmpAct()
                            mof_ActivarOK(Me)
                            cmdOk.Focus()
                            'Plo_IniciaFrm()
                        End If
                    End If
                Else
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtnNroDoc.Text
                    wp_sCodErr = "10-319"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    dtpFecCtb.Focus()
                End If
            End If
            ' Plo_IniciaFrm()
        Catch ex As Exception
            MsgBox("Error : cmdCrear_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            MsgBox("Opción no disponible en este documento")
            cmdCancelar.Focus()
            Exit Sub

            wp_sCmdSel = "E"
            wg_sTipTbl = wl_sTipTbl
            wg_sNomTblL1 = "ILREV1"
            wl_bYesNo = False
            mof_LmpMsgError()
            If txtnNroDoc.Text <> "" Then
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
                        wr_bEOFE1 = True
                        wl_bYesNo = clnIEINV.cnEliminar(wl_sNomTblE1,
                                                        wg_sNomTblL1,
                                                        wl_eIEREV.sCodDoc,
                                                        wl_eIEREV.nNroDoc,
                                                        wr_bEOFE1)
                        If wl_bYesNo Then
                            mof_ActivarBuscar(Me)
                            wp_sNomTbl = wl_sNomTblE1
                            wp_sDatCmp = ""
                            wp_sCodErr = wg_sCodErrOk
                            mof_MsgError(wp_sNomTbl,
                                         wp_sDatCmp,
                                         wp_sCodErr)
                            mof_ActivarOK(Me)
                        Else
                            txtnNroDoc.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : cmdEliminar_Click")
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

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"


    Private Sub cmdConCteCtb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConCteCtb.Click

    End Sub
    Private Sub cmdLstIEREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstIEREV.Click
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "IEREV"
            wl_eIEREV = New moe_Estructuras.eIEREV
            wl_frmLst.wp_eIEREV = New moe_Estructuras.eIEREV
            wl_frmLst.vp_sCodDoc = vl_sCodDoc
            wl_frmLst.wp_sTxtFrm = "Consulta " + Me.Text
            wl_frmLst.ShowDialog()
            wl_eIEREV = wl_frmLst.wp_eIEREV
            wg_DTCon1 = New DataTable
            If wl_frmLst.wp_eIEREV.sCodDoc <> "" Then
                wl_eIEREV = wl_frmLst.wp_eIEREV
                cboAPLND1.SelectedValue = wl_eIEREV.sCodDoc
                txtnNroDoc.Text = wl_eIEREV.nNroDoc
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : cmdLstIEREV_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    
#End Region

#Region "070 DGV Procedimientos"
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wl_eILREV1 = New moe_Estructuras.eILREV1
        wg_sNomTblL1 = "ILREV1"
        Try
            '  wl_eGLMOV1.sCodItm = txtnNroDoc.Text
            For wl_nRow = 0 To wl_CtrlDgv.RowCount - 1
                'Ini 2018-07-12 Req 2018-01
                '     wl_CtrlDgv.Rows(wl_nRow).Cells("nNroDoc").Value = wl_eGEMOV.nNroDoc
                ' Fin 2018-07-12

                If wl_CtrlDgv.Rows(wl_nRow).Visible = False Then
                    Continue For
                End If
                If wl_CtrlDgv.Rows(wl_nRow).Cells("sCodItm").Value Is Nothing Then
                    Exit For
                End If
                BD_eILREV1_Var(wl_nRow)

                wp_sCmdSel = wl_sCmdAnt
                wl_eILREV1.nID = wl_CtrlDgv.Rows(wl_nRow).Cells("nId").Value
                If wl_eILREV1.nID <> 0 Then
                    wp_sCmdSel = "A"
                Else
                    wp_sCmdSel = "C"
                End If

                If wl_CtrlDgv.Rows(wl_nRow).Visible = True Then
                    clnIEINV.cnCrearActILREV1(wl_eILREV1,
                                              wp_sCmdSel,
                                              wp_bEOF2)

                Else
                    If wp_sCmdSel = "A" Then
                        wl_eILREV1.sCodDoc = wl_CtrlDgv.Rows(wl_nRow).Cells("sCodDoc").Value
                        wl_eILREV1.nNroDoc = wl_CtrlDgv.Rows(wl_nRow).Cells("nNroDoc").Value
                        wl_bYesNo = clnIEINV.cnEliILREV1(wl_eILREV1.nID,
                                                         wl_eILREV1.sCodDoc,
                                                         wl_eILREV1.nNroDoc,
                                                         wp_bEOF2)
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdiRow()
        'Fec_Ult_Act : 2015.06.12
        Try
            ' Viene de tsmi_CrearLinea
            dgv_AdiRowILREV1()
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_AdiRowILREV1()
        'Fec_Ult_Act : 2015.07.09
        Try

            wl_nCntRow = wl_CtrlDgv.RowCount - 1
            If wl_nCntRow > -1 Then
                wl_nCol = wl_CtrlDgv.Columns("sCodItm").Index
                If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodItm").Value = "" Then
                    Exit Sub
                End If
            End If
            With wl_CtrlDgv
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentRow.Cells("sCodDoc").Value = wl_eIEREV.sCodDoc
                .CurrentRow.Cells("nNroDoc").Value = wl_eIEREV.nNroDoc
                .CurrentRow.Cells("sCodSer").Value = wl_eIEREV.sCodSer
                .CurrentRow.Cells("sClsDoc").Value = wl_eIEREV.sClsDoc
                .CurrentRow.Cells("sTipRev").Value = wl_eIEREV.sTipRev
                .CurrentRow.HeaderCell.Value = (wl_CtrlDgv.CurrentRow.Index + 1).ToString
            End With
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_nColIniGrl
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRowIEREV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wg_DTL1 = New DataTable
        wl_eILREV1 = New moe_Estructuras.eILREV1
        ReDim wl_aeILREV1(0)
        wg_sNomTblL1 = "ILREV1"
        wr_bEOFL1 = True
        Try
            wg_DTL1 = clnIEINV.cndtConILREV1(wl_eIEREV,
                                             wr_bEOFL1)
            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    ReDim wl_aeILREV1(wg_DTL1.Rows.Count)
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRowILREV1()
                        moo_DGV_DTeILREV1(wl_CtrlDgv,
                                          wg_DTL1,
                                          wl_nRow)
                        moo_eILREV1_DGVILREV1(wl_eILREV1,
                                              wl_CtrlDgv,
                                              wl_nRow)
                        wl_aeILREV1(wl_nRow) = wl_eILREV1
                    Next
                End With
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DetADgv")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_LstADgv()
        Dim wl_nRow As Integer

        Dim wl_nRowDgv As Integer
        wl_nRow = 0
        Try
            wl_nRowDgv = 0
            If wl_CtrlDgv.Rows.Count > 1 Then
                wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            End If
            moo_DGVMov1_aePLODP1(wl_CtrlDgv,
                             wg_aePLODP1)

            wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nRowDgv
                    .Rows(wl_nRow).Cells("nId").Value = 0
                    .Rows(wl_nRow).Cells("nPorCms").Value = 0
                    .Rows(wl_nRow).Cells("sCodDoc").Value = vl_sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = vl_nNroDoc
                    .Rows(wl_nRow).Cells("sTipRev").Value = vl_sTipRev
                    If .Rows(wl_nRow).Cells("nCanItm").Value > .Rows(wl_nRow).Cells("nSdoAlm").Value Then
                        wl_CtrlDgv.Rows(wl_nRow).DefaultCellStyle.SelectionBackColor = Color.Red
                    End If

                Next

            End With
            cmdCrear.Focus()

        Catch ex As Exception
            MsgBox("Error: dgv_LstADgv")
        End Try
    End Sub
    Private Sub dgv_Vda_SdoAlm()
        Try
            If dgv1.Rows(wl_nRow).Cells("bIndCan").Value = True Then
                If dgv1.Rows(wl_nRow).Cells("nCanItm").Value > dgv1.Rows(wl_nRow).Cells("nSdoAlm").Value Then
                    dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                Else
                    dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black
                End If
            End If
            If dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black Then
                If dgv1.Rows(wl_nRow).Cells("bIndCos").Value = True Then
                    If dgv1.Rows(wl_nRow).Cells("nPreUni").Value <= 0 Then
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        dgv1.Rows(wl_nRow).DefaultCellStyle.ForeColor = Color.Black
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: dgv_Vda_Sdo")
            MsgBox(ex.Message)
        End Try

    End Sub

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
        Try
            Dim wl_bCnfVis As Boolean = False
            Dim vl_sNomCmp As String
            Dim vl_sTitCol As String
            wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
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
                    vl_nTamCmp = .nTamCmp
                    vl_sTitCol = .sTitCol
                End With

                mof_DGVFormatCol(wl_CtrlDgv,
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
            MsgBox("Error :  dgv_ConfiguraCol")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_EliminarLinea()
        Dim wl_nRow As Integer
        Try
            wl_nRow = (dgv1.Rows.Count).ToString
            wl_nCol = dgv1.CurrentRow.Index
            If wl_nRow >= 0 Then
                wl_CtrlDgv.Rows(wl_nCol).Visible = False
                wl_nCol = 0
                For wl_nRow = 0 To dgv1.Rows.Count - 1
                    If wl_CtrlDgv.Rows(wl_nRow).Visible = True Then
                        wl_CtrlDgv.Rows(wl_nRow).HeaderCell.Value = (wl_nCol + 1).ToString
                        wl_nCol = wl_nCol + 1
                    End If
                Next
                wl_CtrlDgv.RefreshEdit()
            End If
        Catch ex As Exception
            MsgBox("Error: dgv_EliminarLinea")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_SumLin()
        'fec_ult_act = 2014.04.25
        Dim wl_nCntRow As Integer

        Try
            vl_nTotDoc = 0
            wl_nCntRow = wl_CtrlDgv.Rows.Count

            wl_eILREV1 = New moe_Estructuras.eILREV1

            For wl_i = 0 To wl_nCntRow - 1


                '    moo_eILREV1_DGVILREV1(wl_eILREV1,
                '                         wl_CtrlDgv,
                '                        wl_i)
                mof_fILREV1SumLin(wl_eILREV1.nPreUni,
                                  wl_eILREV1.nPreant,
                                  wl_eILREV1.nDifPre,
                                  wl_eILREV1.nTotLin,
                                  vl_nTotDoc)

            Next
            '    moo_eILREV1_DGVILREV1(wl_eILREV1,
            '                         wl_CtrlDgv,
            '                         wl_nRowKU)
            dgv_TotDoc()

        Catch ex As Exception
            MsgBox("Error: dgv_SumLin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotLin()
        Try
            If wl_aeAPDGV(wl_nColAnt).sNomCmp = "nCanItm" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreUni" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreAnt" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nDifPre" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nTotLin" Then
                wl_eILREV1 = New moe_Estructuras.eILREV1
                moo_eILREV1_DGVILREV1(wl_eILREV1,
                                      wl_CtrlDgv,
                                      wl_nRowKU)
                mof_fILREV1TotLin(wl_eILREV1.nCanItm,
                                  wl_eILREV1.nPreUni,
                                  wl_eILREV1.nPreant,
                                  wl_eILREV1.nDifPre,
                                  wl_eILREV1.nTotLin,
                                  wl_eILREV1.sTipRev)
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nCanItm").Value = wl_eILREV1.nCanItm
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreUni").Value = wl_eILREV1.nPreUni
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreant").Value = wl_eILREV1.nPreant
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nDifPre").Value = wl_eILREV1.nDifPre
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nTotLin").Value = wl_eILREV1.nTotLin
            End If
        Catch ex As Exception
            MsgBox("Error: dgv_TotLin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotDoc()
        Try
            txtnTotDoc.Text = FormatCurrency(vl_nTotDoc)
        Catch ex As Exception
            MsgBox("Error: dgv1_TotDoc")
            MsgBox(ex.Message)
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
            wl_CtrlDgv = dgv1
            If wl_CtrlDgv.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If wl_CtrlDgv.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nCol = e.ColumnIndex
            wl_nRow = e.RowIndex
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
            If wl_CtrlDgv.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If wl_CtrlDgv.Enabled = False Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nCol = e.ColumnIndex
            wl_nRow = e.RowIndex
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If


            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodItm" Then
                BD_CargarIEDMIR()
                If wl_eIEDMI.sCodItm <> "" Then
                    vl_sCodItm = wl_eIEDMI.sCodItm
                    vl_sCodAlm = wl_eIEDMI.sCodAlm
                    wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
                    wl_bEOF = True
                    wl_DTE1 = New DataTable
                    wl_DTE1 = clnIEDMI.cndtConGELDMI1(vl_sCodItm,
                                                      vl_sCodAlm,
                                                      wl_bEOF)

                    If Not wl_bEOF Then
                        moo_eIELDMI1_DT(wl_eIELDMI1,
                                        wl_DTE1,
                                        0)
                        moo_DGVILREV1_eIELDMI1(wl_CtrlDgv,
                                               wl_eIELDMI1,
                                               wl_nRow)

                    End If
                End If
            End If
            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodAlm" Then
                BD_CargarATALM()
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
            mov_dgv_VdaILREV1(wl_nCol,
                              wl_nColAnt,
                              wl_nColSig,
                              wl_nRow,
                              wl_nRowAnt,
                              wl_nRowSig,
                              wl_CtrlDgv,
                              wl_aeAPDGV)

            dgv_TotLin()
            dgv_SumLin()
            dgv_TotDoc()

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
                If wl_bAdiRow = True Then
                    dgv_AdiRowILREV1()
                    wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                End If
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
#End Region
#Region "073 DGV Procedimientos llamados por los Controladores de Eventos"
#End Region
#End Region

#Region "080 Plo Procedimientos del Formulario."
#Region "080 Plo Procedimientos del Formulario. Personalizados"

    Private Sub Plo_frmLstdet()
        Try
            Dim wl_frmLstDet As New frmGQLstDet
            Dim wg_DTL1 As New DataTable
            wg_sTblCon1 = "IEMOV"
            wg_sCmpCon11 = "sCodDoc"
            wg_sCmpCon12 = "nNroDoc"
            wg_sTitCon11 = "Código Ent"
            wg_sTitCon12 = "Número Ent"
            wr_bEOFCon1 = True
            wl_frmLstDet.ShowDialog()
            dgv_LstADgv()
        Catch ex As Exception
            MsgBox("Error : Plo_frmLstdet")
            MsgBox(ex.Message)
        End Try






    End Sub
    Private Sub Plo_HabCtrl()
        Try

        Catch ex As Exception
            MsgBox("Error : Plo_HabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabCtrl()
        Try

        Catch ex As Exception
            MsgBox("Error : Plo_InHabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarDoc()
        Try
            wl_sNomFrm = "frmIEREV"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "REV"
            vl_sClsDoc = "DI"
            wl_nNroDgv = 1
            wl_CtrlDgv = dgv1

            Plo_LeeAPEND()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarEst()
        Try
            wl_eIEREV = New moe_Estructuras.eIEREV
            wl_eILREV1 = New moe_Estructuras.eILREV1
            ReDim wl_aeILREV1(0)
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciaFrm()
        Try
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            Plo_IniciarEst() '080
            Plo_IniciarDoc() '080
            Plo_IniciarVar() '080
            wl_sTipTbl = "E2"
            wg_sTipTbl = wl_sTipTbl
            BD_DatPrmTipTbl(wg_sTipTbl)
            dgv_APDGV()
            Plo_IniciarVarDGV() '080
            grl_EventCtrl(Me)
            Cbo_CargarLst()
            Plo_ActivarCrear() '080
            Plo_TxtIni() '080
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarSer()
        Try
            Plo_LeeAPLND1()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarSer")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciarText()
        ' datos por del formulario
        Try

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarText")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            'GEMOV

            vl_nId = 0
            ' vl_nNroDoc = 0
            vl_sCodTra = ""
            vl_sEstDoc = "2"
            vl_dFecCtb = Date.Today
            vl_dFecDoc = Date.Today
            vl_dFecVto = Date.Today
            vl_dFecSys = Date.Today
            vl_sDocRef = ""
            vl_nTotDoc = 0 '20
           
            '   vl_sCodSer = ""

            cboABTIR.SelectedValue = "1"
            If cboABTIR.SelectedIndex > -1 Then
                vl_sTipRev = cboABTIR.SelectedValue
            Else
                vl_sTipRev = "1"
            End If


            vl_sCmn = ""
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0

            vl_sCodUsr = vg_sCodUsr

            wl_eIEREV = New moe_Estructuras.eIEREV
            wl_CtrlDgv = dgv1
            wl_eIEREV.sCodDoc = vl_sCodDoc
            wl_eIEREV.nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)
            wl_eIEREV.sTipRev = vl_sTipRev
            wl_eIEREV.sClsDoc = vl_sClsDoc
            wl_eIEREV.sCodSer = vl_sCodSer
            wl_eIEREV.sCodUsr = vg_sNomUsr

            wl_eIEREV.dFecSys = Date.Today

            wl_bVdoVta = False
            wl_bVdoCom = False

            ' errores
            wl_bYesNo = False
            wl_bEdit = False
            wg_sCodErrAdi = "10-203"
            wg_sCodErrCon = "10-103"
            wg_sCodErrOk = "20-001"
            wl_sCoderr = "10-112"
            wg_sDesMsgEli = "Este opción elimina el documento. ¿ Continua ?"
            wg_sTitMsgEli = "Mensaje del sistema"
            wg_sDesMsgAdi = "Este documento no puede modificarse después de crearse. ¿ Continua ?"
            wg_sTitMsgAdi = Me.Text

            ' IEINV

            dtpFecCtb.Value = Date.Today
            dtpFecCtb.Format = DateTimePickerFormat.Custom
            dtpFecCtb.CustomFormat = "yyyy-MM-dd"
            dtpFecDoc.Value = Date.Today
            dtpFecDoc.Format = DateTimePickerFormat.Custom
            dtpFecDoc.CustomFormat = "yyyy-MM-dd"




            mof_ActivarCrear(Me)
          

            ' Variables numéricas
            wl_nNroDgv = 1

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVarDGV()
        'Fec_Ult_Mod: 2014.04.29
        'dgv
        Try
            wl_nTab = 0
            wl_nRowVacia = 7
            wl_nColAnt = wl_nColIniGrl
            wl_nRowAnt = 0
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_RefrescaDoc()
        Try
            wp_sCmdSel = "B"
            wl_sNomFrm = "frmIEREV"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "REV"
            vl_sClsDoc = "DI"
            wl_nNroDgv = 1
            wl_CtrlDgv = dgv1
            cmdBuscar_Click(Nothing,
                            Nothing)

        Catch ex As Exception
            MsgBox("Error : Plo_RefrescaDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_SelDGV(ByVal wl_nNroDgv As Integer)
        wl_CtrlDgv = New DataGridView
        Try
            If wl_nNroDgv = 1 Then
                dgv1.Visible = True
                wl_sCodDgv = "dgv1"
                wl_CtrlDgv = Me.dgv1
            End If
            dgv_APDGV()
            '      Plo_ActivarCrear() '080
        Catch ex As Exception
            MsgBox("Error : Plo_SelDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_TxtIni()
        Try
        Catch ex As Exception
            MsgBox("Error : Plo_SelDGV")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_Frm_Var()
        Try
            wl_nNroDocAnt = vl_nNroDoc

            wl_eIEREV.nNroDoc = wl_nNroDocAnt
            cboAPLND1.SelectedValue = vl_sCodSer
            txtnNroDoc.Text = vl_nNroDoc
            'cboABESD.SelectedValue = vl_sEstDoc
            dtpFecCtb.Text = vl_dFecCtb
            dtpFecDoc.Text = vl_dFecDoc
            cboATTIN.SelectedValue = vl_sCodTra
            cboABTIR.SelectedValue = vl_sTipRev
            txtsCmn.Text = vl_sCmn
            txtsCodCteCtb.Text = vl_sCodCteCtb '31
            txtnNroCteCtb.Text = vl_nNroCteCtb '32
            txtnTotDoc.Text = FormatCurrency(vl_nTotDoc)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Var_frm")
        End Try
    End Sub
    Private Sub Plo_Var_Frm()
        Try
            vl_nNroDoc = CLng(txtnNroDoc.Text)
            vl_sEstDoc = "2"
            vl_dFecCtb = dtpFecCtb.Text
            vl_dFecDoc = dtpFecDoc.Text
            vl_dFecVto = dtpFecDoc.Text
            vl_dFecSys = Date.Today
            vl_sDocRef = ""
            vl_sCodTra = cboATTIN.SelectedValue
            vl_sCodSer = cboAPLND1.SelectedValue
            vl_sTipRev = cboABTIR.SelectedValue
            vl_sCmn = txtsCmn.Text
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0
            vl_sCodUsr = vg_sCodUsr
           
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Var_frm")
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarCmpAct()
        Try
            cboAPLND1.Enabled = True
            txtnNroDoc.Enabled = False
            dtpFecCtb.Enabled = True
            dtpFecDoc.Enabled = True

            txtsCmn.Enabled = True
            txtsCodCteCtb.Enabled = True
            txtnNroCteCtb.Enabled = True
            cboATTIN.Enabled = True
            cboABTIR.Enabled = True
            cmdLstIEREV.Enabled = False
            txtnTotDoc.Enabled = False
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()

        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarBuscar")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_ActivarBuscar()
        Try
            mof_HabCtrl(Me)
            Plo_IniciarVar()
            Plo_InHabCtrl()
            mof_ActivarBuscar(Me)

            wl_CtrlDgv.Enabled = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(Me.wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            dgv_AdiRowILREV1()
            cmdLstIEREV.Enabled = True
            cboAPLND1.Enabled = True
            txtnNroDoc.Enabled = True
            txtnNroDoc.Focus()
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarBuscar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCrear()
        Try

            mof_ActivarCrear(Me)
            mof_HabCtrl(Me)
            Plo_InHabCtrl()
            Plo_IniciarEst() '080
            Plo_IniciarDoc() '080
            Plo_IniciarVar() '080
            Plo_ActivarCmpAct()
            Cbo_CargarAPLND1()

            wl_CtrlDgv.Enabled = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            dgv_AdiRowILREV1()
            Plo_ActivarCmpAct()
            '    cmdLstIEENI.Enabled = False'
            ' txtnNroDoc.Enabled = False
            '   cboATTIN.Enabled = True
            cboABTIR.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarCrear")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_CrgModCtb()
        Try
            wl_eIEREV.sCodDoc = "REV"
            wl_eIEREV.sTipRev = vl_sTipRev
            wl_eIEREV.sClsDoc = "DI"
            wl_eIEREV.nNroDoc = txtnNroDoc.Text
            wl_eIEREV.dFecCtb = dtpFecCtb.Text
            wl_eIEREV.dFecDoc = dtpFecDoc.Text
            wl_eIEREV.dFecVto = dtpFecDoc.Text
            wl_eIEREV.dFecSys = Date.Today

        Catch ex As Exception
            MsgBox("Error : Plo_CrgModCtb")
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Plo_InactCmpAct()
        Try
            cboAPLND1.Enabled = False
            txtnNroDoc.Enabled = False
            dtpFecCtb.Enabled = False
            dtpFecDoc.Enabled = False
            txtsCmn.Enabled = False
            txtsCodCteCtb.Enabled = False
            txtnNroCteCtb.Enabled = False
            cboATTIN.Enabled = False
            cboABTIR.Enabled = False
            txtnTotDoc.Enabled = False
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
           For wl_i = 0 To dgv1.Rows.Count - 1
                dgv1.Rows(wl_i).ReadOnly = True
                dgv1.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarBuscar")
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Plo_LeeAPEND()
        ' Fec Ult Mod. 2014.04.19
        Dim clnConTbl As New ClaseNegocios.clnConTbl
        Try
            wl_eAPEND = New moe_Estructuras.eAPEND
            wg_sNomTblE2 = "APEND"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = vl_sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sCmpOrdE21 = ""
            wg_sTipOrdE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = vl_sCodSer
            wg_sTipCmpE22 = "S"
            wr_bEOFE1 = True
            wg_DTE2 = clnConTbl.cndtBuscar(wg_sNomTblE2,
                                           wg_sNomCmpE21,
                                           wg_sDatCmpE21,
                                           wg_sTipCmpE21,
                                           wg_sCmpOrdE21,
                                           wg_sTipOrdE21,
                                           wr_bEOFE1)
            If wr_bEOFE1 = False Then
                moo_eAPEND_DT(wl_eAPEND,
                              wg_DTE2,
                              0)
                vl_sCodSer = wl_eAPEND.sCodSer
                txtnNroDoc.Text = wl_eAPEND.nNroSig
            End If

        Catch ex As Exception
            MsgBox("Error : Plo_LeeAPEND")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_LeeAPLND1()
        Dim clnConTbl As New ClaseNegocios.clnConTbl

        wg_sNomTblE2 = "APLND1"
        wg_sNomCmpE21 = "sCodDoc"
        wg_sDatCmpE21 = wl_eIEREV.sCodDoc
        wg_sTipCmpE21 = "S"
        wg_sCmpOrdE21 = ""
        wg_sTipOrdE21 = "S"
        wg_sNomCmpE22 = "sCodSer"
        wg_sDatCmpE22 = wl_eIEREV.sCodSer
        wg_sTipCmpE22 = "S"
        wr_bEOFE1 = True
        wg_DTE2 = clnConTbl.cndtBuscarE2(wg_sNomTblE2,
                                         wg_sNomCmpE21,
                                         wg_sDatCmpE21,
                                         wg_sTipCmpE21,
                                         wg_sNomCmpE22,
                                         wg_sDatCmpE22,
                                         wg_sTipCmpE22,
                                         wr_bEOFE1)
        If wr_bEOFE1 = False Then

        End If
        ' TextBox1.Text = wg_DTE2.Rows(0).Item(3)

    End Sub
    Private Sub PloNroSig_APEND()
        Try
            Dim clnActualizar As New ClaseNegocios.clnActTbl
            vl_nNroSig = CType(txtnNroDoc.Text, Double) + 1
            wg_sNomTblE2 = "APEND"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = wl_eIEREV.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_eIEREV.sCodSer
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
            vl_nNroSig = CType(txtnNroDoc.Text, Double) + 1
            wg_sNomTblE2 = "APLND1"
            wg_sNomCmpE21 = "sCodDoc"
            wg_sDatCmpE21 = wl_eIEREV.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_eIEREV.sCodSer
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
    Private Sub txtnNroDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnNroDoc.DoubleClick
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "IEMOV"
            wl_frmLst.wp_sTxtFrm = "Consulta consecutivo ordenes de entradas de compras"


            wl_frmLst.ShowDialog()
            txtnNroDoc.Text = wg_nSelCon13
            cmdBuscar_Click(Nothing,
                            Nothing)

        Catch ex As Exception
            MsgBox("Error : txtnNroDoc_DoubleClick")
            MsgBox(ex.Message)
        End Try

        'Plo_frmLstdet()
    End Sub
    Private Sub txtnNroDoc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnNroDoc.KeyUp
        Try
            If e.KeyData = Keys.Enter Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : txtsCodTer_KeyUp")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region


#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            Dim wl_aeIEREV(0) As moe_Estructuras.eIEREV
            Dim wl_aeABTIR(0) As moe_Estructuras.eABTIR
            dgv_DetADgv()
            wl_aeIEREV(0) = wl_eIEREV
            wl_aeABTIR(0) = wl_eABTIR


            wl_sNroALetras = mof_NroALetras(CType(wl_eIEREV.nTotDoc, String),
                                                  wl_eIEREV.sCodMon)

            mof_ActivarOK(Me)
            Dim wl_frmRPT As New rptRIREV01
            wl_frmRPT.wp_aeIEREV = wl_aeIEREV
            wl_frmRPT.wp_aeILREV1 = wl_aeILREV1
            wl_frmRPT.wp_sNroALetras = wl_sNroALetras
            wl_frmRPT.Show()


        Catch ex As Exception
            MsgBox("Error :  Rpt_PrmRpt")
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
        If DirectCast(sender, TextBox).Name = "txtnNroDoc" Then
            wg_sClaPpl = txtnNroDoc.Text
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
                AddHandler DirectCast(oCtrl, TextBox).KeyUp, AddressOf grl_Txt_KeyUp
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
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VwvPrv
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
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VwvPrv
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
        DirectCast(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "140 grl Lost Focus. Personalizados"
    Private Sub grl_Txt_KeyUp(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        ' mof_LmpMsgError()
        wl_cvTxt = GetNextControl(wl_cvTxt, False)
        If cmdCancelar.Focused = False Then
            If wl_cvTxt IsNot Nothing Then
                If wl_cvTxt.Name = "txtnNroDoc" Then
                    mov_VdaTxt(wl_bVda,
                               txtnNroDoc)
                End If
                If wl_cvTxt.Name = "txtnTotGtoAdi" Then
                    dgv_TotDoc()

                End If
                If wl_cvTxt.Name = "txtnVlrRdd" Then
                    dgv_TotDoc()
                End If


            End If
        End If
        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        ' mof_LmpMsgError()
        wl_cvTxt = GetNextControl(wl_cvTxt, False)
        If cmdCancelar.Focused = False Then
            If wl_cvTxt IsNot Nothing Then
                If wl_cvTxt.Name = "txtnNroDoc" Then
                    mov_VdaTxt(wl_bVda,
                               txtnNroDoc)
                End If
                If wl_cvTxt.Name = "txtnTotGtoAdi" Then
                    dgv_TotDoc()
                End If
                If wl_cvTxt.Name = "txtnVlrRdd" Then
                    dgv_TotDoc()
                End If
            End If
        End If
        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
#End Region

#Region "141 grl Lost Focus. Comunes"

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
        BD_DatPrmTSB()
        ' mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try

            If wl_sNomTblE1 <> "" Then
                If wg_sTipTbl = "E1" Then
                    wg_DTE1 = clnConTbl.cndtAnterior(wl_sNomTblE1,
                                                    wg_sCmpTSB,
                                                    wg_sDatTSB,
                                                    wg_sTipCmpTSB,
                                                    wr_bEOFE1)
                End If
                If wg_sTipTbl = "E2" Then
                    wg_DTE1 = clnConTbl.cndtAnteriorMov(wl_sNomTblE1,
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
            MsgBox("Error en: tsb_Anterior")
        End Try

    End Sub
    Private Sub tsb_Siguiente()
        BD_DatPrmTSB()
        '  mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            If wl_sNomTblE1 <> "" Then
                If wg_sTipTbl = "E1" Then
                    wg_DTE1 = clnConTbl.cndtSiguiente(wl_sNomTblE1,
                                                      wg_sCmpTSB,
                                                      wg_sDatTSB,
                                                      wg_sTipCmpTSB,
                                                      wr_bEOFE1)
                End If
                If wg_sTipTbl = "E2" Then
                    wg_DTE1 = clnConTbl.cndtSiguienteMov(wl_sNomTblE1,
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
            MsgBox("Error en: tsb_Siguiente")
        End Try

    End Sub
    Private Sub tsb_Ultimo()
        BD_DatPrmTSB()
        mof_ActivarOK(Me)
        wr_bEOFE1 = True
        Try
            If wl_sNomTblE1 <> "" Then
                If wg_sTipTbl = "E1" Then
                    wg_DTE1 = clnConTbl.cndtUltimo(wl_sNomTblE1,
                                                    wg_sCmpTSB,
                                                    wg_sDatTSB,
                                                    wr_bEOFE1)
                End If
                If wg_sTipTbl = "E2" Then
                    wg_DTE1 = clnConTbl.cndtUltimoMov(wl_sNomTblE1,
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
    Private Sub tsb_VwvPrv()
        Try
            Rpt_PrmRpt()
        Catch ex As Exception
            MsgBox("Error :  tsb_VisVwV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
#End Region

#Region "170 TSMI ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
        Try
            If wl_eIEREV.sEstDoc > "1" Then
                Exit Sub
            End If
            dgv_AdiRow()
        Catch ex As Exception
            MsgBox("Error : tsmi_CrearLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsmi_EliminarLinea()
        Try
            If cmdCrear.Visible = True Then
                dgv_EliminarLinea()
            Else
                cmdCancelar.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : tsmi_EliminarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

   
End Class