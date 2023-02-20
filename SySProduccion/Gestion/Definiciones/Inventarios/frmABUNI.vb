'Tipo de formulario: detalle: ATUME. Unidades de medida

Public Class frmACUNI
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23
#Region "001 Inicia. wg - vg Definición del variables públicas"
    'Estructuras
    'variables

#End Region
#Region "011 frm - Variables Locales"
    ' Variables locales
    Dim wl_RowAlto As Integer
    Dim wl_nTab As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColIni As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nColVda1 As Integer
    Dim wl_nColVda2 As Integer
    Dim wl_sOpeLgc As String
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nCntReg As Integer
    Dim wl_nColOrd As Integer
    Dim vl_nTamCmp As Integer
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_YIni As Integer ' dgv1.CurrentCellAddress.Y Row
    Dim wl_YFin As Integer ' dgv1.CurrentCellAddress.Y Row



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

    Dim wl_nRowAct As Long
    Dim wl_nCntRow As Long

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim wl_nTotcol As Integer
    Dim vl_nId As Long
    Dim vl_sCodUni As String
    Dim vl_sNomUni As String
    Dim vl_sCodUniBas As String
    Dim vl_nUniBas As Long

#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas
    Dim vl_nColFin As Integer

    Dim wl_bVdaRow As Boolean
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_nCellCod As Integer
    Dim wl_nCellDes As Integer
    Dim wl_nCntCol As Integer
    Dim wl_nCol As Integer
    Dim wl_nColCVC As Integer
    Dim wl_nColKD As Integer
    Dim wl_nColKP As Integer
    Dim wl_nColKU As Integer
    Dim wl_nColNom As Integer
    Dim wl_nColSig As Integer
    Dim wl_nNroCol As Integer
    Dim wl_nNroDgv As Integer
    Dim wl_nRow As Integer
    Dim wl_nRowAlto As Integer
    Dim wl_nRowCVC As Integer
    Dim wl_nRowIni As Integer
    Dim wl_nRowKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nRowSig As Integer



#End Region
    ' Objetos del formulario
#Region "014 Objetos locales"
    Dim clnACUNI As New ClaseNegocios.clnACUNI
    Dim clnTblAB As New ClaseNegocios.clnTblAB

    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTL1 As DataTable

#End Region
#Region "015 Estructuras"
    Dim wl_aeACUNI() As moe_Estructuras.eACUNI
    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_eACUNI As New moe_Estructuras.eACUNI
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
    Dim wl_sCodErrOk As String
    Dim wl_sCodErrCon As String
    Dim wl_sCodErrAdi As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#End Region

#Region "020 frm Eventos - Principal"

    Private Sub frmATUME_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error : frmATUME_Disposed")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmATUME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            Plo_IniciarVar()
            Plo_IniciarDoc()
            Plo_IniciarVarDGV()
            Plo_IniciarFrm()

        Catch ex As Exception
            MsgBox("Error : frmATUME_Load")
            MsgBox(ex.Message)
        End Try

    End Sub


#End Region

#Region "040 BD Procedimientos sobre la BD. Personalizados"



    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        ' Tipo de tabla
        If wg_sTipTbl = "E1" Then
            wg_sNomTblE1 = "ACUNI"
            wg_sNomCmpE11 = "sCodUni"
            wg_sTipCmpE11 = "S"
            wg_sTitCmpE11 = "Unidad"
            wr_bEOFE1 = True
        End If

    End Sub
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean

        wl_bYesNo = False
        wl_nRow = dgv1.CurrentCellAddress.Y
        vl_sCodUni = dgv1.Rows(wl_nRow).Cells("sCodUni").Value
        Try
            BD_eACUNI_Var()
            If vl_sCodUni <> "" Then
                wl_bYesNo = clnACUNI.cnCrearActACUNI(wl_eACUNI,
                                                     wr_bEOFE1,
                                                     wp_sCmdSel)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_eACUNI_Var()
        Try
            wl_eACUNI = New moe_Estructuras.eACUNI
            With wl_eACUNI
                .sCodUni = dgv1.Rows(wl_nRow).Cells("sCodUni").Value
                .sNomUni = dgv1.Rows(wl_nRow).Cells("sNomUni").Value
                .sCodUniBas = dgv1.Rows(wl_nRow).Cells("sCodUniBas").Value
                .nUniBas = dgv1.Rows(wl_nRow).Cells("nUniBas").Value
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eACUNI_Var")
        End Try
    End Sub
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        wp_sCmdSel = "A"
        wl_bYesNo = False
        wr_bEOFE1 = True
        wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
        If wl_bYesNo Then
            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = wg_sCodErrOk
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            mof_ActivarOK(Me)
            wl_nRow = dgv1.Rows.Count - 1
        End If
        dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)
    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        grl_Cerrar()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        grl_Cerrar()
    End Sub
#End Region


#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Sub dgv_AdiRow()
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
                .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)
            End With
            wl_nTab = 0
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count
            dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConACUNI()
        Try
            wl_nTotcol = 4
            wg_sTblCon1 = "ACUNI"
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wl_aeACUNI(0)
            If Not wr_bEOFCon1 Then
                moo_aeACUNI_DT(wl_aeACUNI,
                               wg_DTCon1)
                moo_DGV_aeACUNI(Me.dgv1,
                                wl_aeACUNI)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConACUNI")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ColSolLec()
        Try
            wl_nCntReg = dgv1.RowCount
            With dgv1
                For wl_nI = 0 To wl_nCntReg - 1
                    .Rows(wl_nI).Cells(0).ReadOnly = True
                Next
            End With


        Catch ex As Exception
            MsgBox("Error : dgv_ColSolLec")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wl_DTL1 = New DataTable

        ReDim wl_aeACUNI(0)

        wl_CtrlDgv = Me.dgv1
        wl_eACUNI = New moe_Estructuras.eACUNI
        '  wl_eACUNI.sCodUni = vl_sCodUni

        Try
            wl_DTL1 = clnTblAB.cndtCrgACUNI(wl_bEOF)
            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    For wl_nRow = 0 To wl_DTL1.Rows.Count - 1
                        dgv_AdiRow()
                        wl_eACUNI = New moe_Estructuras.eACUNI
                        moo_eACUNI_DT(wl_eACUNI,
                                      wl_DTL1,
                                      wl_nRow)
                        moo_DGV_eACUNI(wl_CtrlDgv,
                                       wl_eACUNI,
                                       wl_nRow)
                    Next
                End With


            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DetADgv")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "071 DGV Procedimientos del Usuario. Comunes"
    Private Sub dgv_APDGV()
        Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
        Try
            wg_sCodStr =
            wg_nColFin = 0
            wg_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nTotcol = UBound(wg_aeAPDGV) + 1
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
        For wp_nC = 0 To wl_nTotcol - 1
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

    End Sub
#End Region
#Region "072 DGV Controladores de Eventos "

    Private Sub dgv1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv1.CellBeginEdit
        grl_TextChangeDGV()
    End Sub

    ' Private Sub dgv1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv1.KeyPress
    '    If (e.KeyChar >= ChrW(48) And e.KeyChar <= ChrW(57)) Then
    '       grl_TextChangeDGV()
    '  End If
    'End Sub

    ' Personalizadas
    ' Comunes


#End Region

#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActivarOk()
        mof_ActivarOK(Me)
        Plo_IniciarVar()
        dgv1.Enabled = True
        dgv1.Rows.Clear()
        Plo_IniciarVarDGV()
        dgv_ConfiguraCol()
        dgv_ConACUNI()
        dgv_ColSolLec()
        dgv_AdiRow()
    End Sub
    Private Sub Plo_IniciarDoc()
        wl_sNomFrm = "frmACUNI"
        wl_bSwsCbo = False
        wl_sCodDgv = "dgv1"
    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_bYesNo = False
            wl_bEdit = False
            wl_sNomFrm = "frmACUNI"
            wl_sNomTblE1 = "ACUNI"
            dgv_DetADgv()
            mof_ActivarOK(Me)
            cmdOk.Focus()



        Catch ex As Exception
            MsgBox("Error : Plo_IniciarFrm")
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try

            ' errores
            wl_bYesNo = False
            wl_bEdit = False
            wg_sCodErrAdi = "10-321"
            wg_sCodErrOk = "20-001"
            wl_sCoderr = "10-121"
            wg_sDesMsgEli = "No se puede eliminar uno de los registros de datos creados por el sistema"
            wg_sTitMsgEli = "Mensaje del sistema"
            ' IEINV

            ' mof_ActivarCrear(Me)


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
            'Plo_SelDGV(wl_nNroDgv)

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotcol)
            dgv_ConfiguraCol()


        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub



#End Region

#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#End Region
#Region "121 grl Eventos"
    Private Sub grl_AddHandlerDGV()
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
    End Sub
    Private Sub grl_RemoveHandlerDGV()
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        RemoveHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
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
    Public Sub grl_TextChangeDGV()
        If cmdOk.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
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


End Class