'Tipo de formulario: detalle: ATUME. Unidades de medida

Public Class frmATUME
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"

    ' Booleanas
    Dim wl_bCmpVdo As Boolean
    Dim wl_bEdit As Boolean
    Dim wl_bSwsBor As Boolean
    Dim wl_bSwsCbo As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bVdoCom As Boolean
    Dim wl_bVdoVta As Boolean
    Dim wl_bYesNo As Boolean
    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean

    'Numéricas

    Dim vp_nNroSig As Double
    Dim wl_nBoxMsg As Integer
    Dim wl_nTab As Integer
    Dim wl_nVlr As Double
    Dim wp_nNroOpc As Integer

    ' Cadenas

    Dim wl_sCod As String
    Dim wl_sCodErr As String
    Dim wl_nResMsg As String
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wl_sDoc As String
    Dim wl_sNom As String
    Dim wl_sNomTbl As String
    Dim wl_sTipTbl As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_sTipCmp As String

#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vp_sUniMed As String


    'Dim vp_fFecCtb As Date
    'Dim vp_fFecDoc As Date
    'Dim vp_nId As Long
    'Dim vp_nNroCte As Double
    'Dim vp_nNroDoc As Long
    'Dim vp_nTotDoc As String
    'Dim vp_sAlmOri As String
    'Dim vp_sClsDoc As String
    'Dim vp_sCodCte As String
    'Dim vp_sCodDoc As String
    'Dim vp_sCodItm As String
    'Dim vp_sCodSer As String
    'Dim vp_sCodTer As String
    'Dim vp_sDocRef As String
    'Dim vp_sEstDoc As String
    'Dim vp_sTipMov As String
    'Dim vp_sDesItm As String
    'Dim vp_sCodAlm As String
    'Dim vp_nCanItm As Double
    'Dim vp_sUniMedInv As String
    'Dim vp_nPreUni As Double
    'Dim vp_nVlrTot As Double
    'Dim vp_nSdoSto As Double
    'Dim vp_sCtaCtb As String
    'Dim vp_sEstLin As String
    'Dim vp_sCodDocBas As String
    'Dim vp_nNroDocBas As Double
    '
#End Region
#Region "013 DGV - Variables Locales"
    'Columnas

    Dim wl_nCntCol As Integer
    Dim wl_nCol As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColKD As Integer
    Dim wl_nColKP As Integer
    Dim wl_nColKU As Integer
    Dim wl_nColSig As Integer
    Dim wl_nNroCol As Integer
    Dim wl_nTotCol As Integer
    Dim vl_nTamCmp As Integer
    'Filas
    Dim wl_bVdaRow As Boolean
    Dim wl_nCellCod As Integer
    Dim wl_nCellDes As Integer
    Dim wl_nCntRow As Integer
    Dim wl_nColVda1 As Integer  'columna a validar 1
    Dim wl_nColVda2 As Integer  'columna a validar 2

    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_nRow As Integer
    Dim wl_nTotRow As Integer
    Dim wl_nRowAlto As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nRowIni As Integer
    Dim wl_nRowKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nRowSig As Integer
    Dim wl_sOpeLgc As String  'Y, O, N
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fila

#End Region
#Region "014 Objetos locales"
    Dim clnATUME As New ClaseNegocios.clnATUME



#End Region

#Region "019 Fin 010.  vl - wl Definición del variables Locales"
#End Region

#Region "020 frm Eventos - Principal"

    Private Sub frmATUME_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        grl_RemoveHandlerDGV()
        Me.Dispose()
    End Sub
    Private Sub frmATUME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grl_RemoveHandlerDGV()
        grl_AddHandlerDGV()
        mof_IniciarVar()
        Plo_IniciarDoc()
        Plo_IniciarVar()
        wl_sTipTbl = "E1"
        wg_sTipTbl = wl_sTipTbl
        BD_DatPrmTipTbl(wg_sTipTbl)
        dgv_APDGV()
        Plo_ActivarOk()
    End Sub


#End Region

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        ' Tipo de tabla
        If wg_sTipTbl = "E1" Then
            wg_sNomTblE1 = "ATUME"
            wg_sNomCmpE11 = "sUniMed"
            wg_sTipCmpE11 = "S"
            wg_sTitCmpE11 = "Unidad de medida"
            wr_bEOFE1 = True
        End If

    End Sub
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean

        wl_bYesNo = False
        wl_nRow = dgv1.CurrentCellAddress.Y
        vp_sUniMed = dgv1.Rows(wl_nRow).Cells(0).Value

        Try
            BD_eATUME_Var()
            If mov_VdaDatVio(wl_bYesNo,
                             vp_sUniMed) Then
                
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)

            Else
                wl_bYesNo = clnATUME.cnCrearActualizar(wg_eATUME,
                                                       wr_bEOFE1,
                                                       wp_sCmdSel)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_eATUME_Var()
        Try
            wg_eATUME = New moe_Estructuras.eATUME
            With wg_eATUME
                .sUniMed = dgv1.Rows(wl_nRow).Cells(0).Value
                .sNomMed = dgv1.Rows(wl_nRow).Cells(1).Value
                .sCodVol = dgv1.Rows(wl_nRow).Cells(2).Value
                .nVlrUme = dgv1.Rows(wl_nRow).Cells(3).Value
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eATUME_Var")
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
    Private Sub dgv_ConATUME()
        Try
            wl_nTotCol = 4
            wg_sTblCon1 = "ATUME"
            wr_bEOFCon1 = False
            wg_DTCon1 = clnConTbl.cndtCargarLista(wg_sTblCon1,
                                                  wr_bEOFCon1)
            ReDim wg_aeATUME(0)
            If Not wr_bEOFCon1 Then
                moo_aeATUME_DT(wg_aeATUME,
                               wg_DTCon1)
                moo_DGV_aeATUME(Me.dgv1,
                                wg_aeATUME)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConATUME")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ColSolLec()
        Try
            wl_nTotRow = dgv1.RowCount
            With dgv1
                For wl_nI = 0 To wl_nTotRow - 1
                    .Rows(wl_nI).Cells(0).ReadOnly = True
                Next
            End With

          
        Catch ex As Exception
            MsgBox("Error : dgv_ColSolLec")
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
            wg_aeAPDGV = mof_fConAPDGV(wp_sNomFrm,
                                       wp_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nTotCol = UBound(wg_aeAPDGV) + 1
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
        dgv_ConATUME()
        dgv_ColSolLec()
        dgv_AdiRow()
    End Sub
    Private Sub Plo_IniciarDoc()
        wp_sNomFrm = "frmATUME"
        wl_bSwsCbo = False

    End Sub
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try

            ' errores
            wl_bYesNo = False
            wl_bEdit = False
            wg_sCodErrAdi = "10-320"
            wg_sCodErrOk = "20-001"
            wl_sCodErr = "10-112"
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