Imports System.Data.OleDb
Imports System.Data

Public Class frmIEENI
#Region "01 Eventos Iniciales"
    ' Public Sub New()
    ' Llamada necesaria para el diseñador.
    '    InitializeComponent()
    '    AddHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
    '    AddHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
    '    AddHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
    '    AddHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
    '    AddHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
    '    AddHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
    '    AddHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
    '    AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
    '    AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
    '    AddHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
    '    AddHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea


    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    'End Sub
#End Region
#Region "vl - wl Definición del variables Locales"
    ' variables locales dgv

    Dim wl_nTab As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColFin As Integer
    Dim wl_nTotCol As Integer
    Dim wl_nCntRow As Integer
    Dim wl_nRow As Integer
    Dim wl_nCol As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nColAnt As Integer
    Dim wl_RowAlto As Integer
    Dim wl_nRowIni As Integer
    Dim wl_nRowVacia As Integer
    Dim wp_sTipCol As String 'N = numérico. C = pesos. S = string. d = fecha
    Dim wp_bVisible As Boolean
    Dim wp_bReadOnly As Boolean

    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y

    ' Variables Locales

    Dim wl_bYesNo As Boolean
    Dim wl_bEdit As Boolean


    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bCmpVdo As Boolean
    Dim wl_bSwsBor As Boolean

    Dim wl_nBoxMsg As Integer
    Dim wl_nNroCol As Integer
    Dim wp_nNroOpc As Integer

    Dim wl_nResMsg As String
    Dim wp_sNomTbl As String
    Dim wp_sNomLla As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sDatCmp As String
    Dim wp_sTipCmp As String

    ' Variables Campos de la BD

    Dim vp_nId As Integer
    Dim vp_sCodDoc As String
    Dim vp_nNroDoc As Integer
    Dim vp_sTipMov As String
    Dim vp_fFecCtb As Date
    Dim vp_fFecDoc As Date
    Dim vp_sAlmOri As String
    Dim vp_sCodTer As String
    Dim vp_sDocRef As String
    Dim vp_nTotDoc As Integer
    Dim vp_nEstDoc As String
    Dim vp_sCodCteCtb As String
    Dim vp_nNroCteCtb As String

    Dim vp_sCodItm As String
    Dim vp_sDesItm As String
    Dim vp_sCodAlm As String
    Dim vp_nCanItm As Double
    Dim vp_sUniMedInv As String
    Dim vp_nPreUni As Double
    Dim vp_nVlrTot As Double
    Dim vp_nSdoSto As Double
    Dim vp_sCtaCtb As String
    Dim vp_sEstLin As String
    Dim vp_sCodDocBas As String
    Dim vp_nNroDocBas As Double
    Dim vp_nNroSig As Double


    ' objetos locales

    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI

    ' Otras variables
    Dim wl_sTipTbl As String


#End Region
#Region "frm Eventos - Principal"

    Private Sub frmIEINV_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        grl_RemoveHandler()

    End Sub
    Private Sub frmIEINV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grl_RemoveHandler()
        grl_AddHandler()
        mof_IniciarVar()
        Plo_IniciarVar()
        wl_sTipTbl = "E1"
        wg_sTipTbl = wl_sTipTbl
        BD_DatPrmTipTbl(wg_sTipTbl)
        grl_EventCtrl(Me)

        Cbo_CargarLista()
        Plo_ActivarCrear()

    End Sub

#End Region


#Region "Cbo Llenar Combobox"
    Private Sub Cbo_CargarLista()

    End Sub
#End Region

#Region "BD Procedimientos sobre la BD"""
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        ' Tipo de tabla
        If wg_sTipTbl = "E1" Then
            wg_sNomTblE1 = "IEMOV"
            wg_sNomCmpE11 = "nNroDoc"
            wg_sTipCmpE11 = "N"
            wg_sTitCmpE11 = "Número documento"
            wg_sDatCmpE11 = TextBox1.Text
            wg_sClaPpl = TextBox1.Text
            wr_bEOFE1 = True
        End If
        If wg_sTipTbl = "E2" Then
            wg_sNomTblE1 = "IEMOV"
            wg_sNomCmpE11 = "sCodMov"
            wg_sTipCmpE11 = "C"
            wg_sTitCmpE11 = "Código Mov "
            wg_sNomCmpE12 = "nNroDoc"
            wg_sTipCmpE12 = "N"
            wg_sTitCmpE12 = "Numero documento"
            wg_sDatCmpE12 = TextBox1.Text

            wr_bEOFE1 = True
        End If
    End Sub
    Private Sub BD_DatPrmTSB() 'Constante
        wg_nCmpCla = 2
        wg_sCmpTSB1 = "nId"
        wg_sCmpTSB2 = "nNroDoc"
        Select Case wg_nCmpCla
            Case 1
                wg_sCmpTSB = wg_sCmpTSB1
                wg_sDatTSB = vp_nId
                wg_sTipCmpTSB = "N"

            Case 2
                wg_sCmpTSB = wg_sCmpTSB2
                wg_sDatTSB = wg_sClaPpl
                wg_sTipCmpTSB = "N"
        End Select
    End Sub
    Private Sub BD_tsbPASU()
        BD_TblAVp()
        dgv1.Enabled = True
        dgv_LlenaDGV()
        mof_ActivarOK(Me)
    End Sub



    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            BD_VpaTbl()
            If Not Validaciones(wg_bVdaE1) Then
                TextBox1.Focus()
            Else
                ReDim wg_aeGEMOV(0)
                wg_aeGEMOV(0) = wg_eGEMOV


                '      wl_bYesNo = clnIEINV.cnCrearActualizar(wg_aeGEMOV(0),
                '                                            wr_bEOFE1,
                '                                           wp_sCmdSel)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmd_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_TblAVp()

        vp_nId = wg_DTE1.Rows(0).Item(0)
        TextBox1.Text = wg_DTE1.Rows(0).Item(2)
        mtbFecCtb.Text = wg_DTE1.Rows(0).Item(4)
        mtbFecDoc.Text = wg_DTE1.Rows(0).Item(5)
        TextBox2.Text = wg_DTE1.Rows(0).Item(6)
        TextBox3.Text = wg_DTE1.Rows(0).Item(7)
        TextBox5.Text = wg_DTE1.Rows(0).Item(9)

        vp_nNroDoc = TextBox1.Text
        vp_sDocRef = TextBox3.Text
        vp_fFecCtb = dtpFecCtb.Value
        vp_fFecDoc = dtpFecDoc.Value
        vp_sAlmOri = ""
        vp_sCodTer = TextBox2.Text
        vp_nTotDoc = vp_nVlrTot
        wg_sClaPpl = TextBox1.Text
    End Sub
    Private Sub BD_VpaTbl()
        wg_eGEMOV = New moe_Estructuras.eGEMOV

        vp_nNroDoc = TextBox1.Text
        vp_sDocRef = TextBox3.Text
        vp_fFecCtb = dtpFecCtb.Value
        vp_fFecDoc = dtpFecDoc.Value
        vp_sAlmOri = ""
        vp_sCodTer = TextBox2.Text
        vp_nTotDoc = vp_nVlrTot

    End Sub
    Private Sub BD_CargarIEDMI(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Dim wl_frmLst As New frmGQLst
        wg_sTblCon1 = "IEDMI"
        wg_sCmpCon11 = "sCodItm"
        wg_sCmpCon12 = "sDesItm"
        wg_sTitCon11 = "Código ítem"
        wg_sTitCon12 = "Nombre ítem"
        wg_sSelCon11 = ""
        wg_sSelCon12 = ""
        wr_bEOFCon1 = True
        wl_frmLst.ShowDialog()
        dgv1.CurrentRow.Cells(wl_CellCod).Value = wg_sSelCon11
        dgv1.CurrentRow.Cells(wl_CellDes).Value = wg_sSelCon12
        dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
    End Sub
    Private Sub BD_CargarATALM(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
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
        If wl_CellCod > -1 Then
            dgv1.CurrentRow.Cells(wl_CellCod).Value = wg_sSelCon11
        End If
        If wl_CellDes > -1 Then
            dgv1.CurrentRow.Cells(wl_CellDes).Value = wg_sSelCon12

        End If

        dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
    End Sub
#End Region

#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
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
            wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
        Else
            TextBox2.Focus()
        End If
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        wp_sCmdSel = "B"
        wg_sTipTbl = wl_sTipTbl
        wl_bYesNo = False
        mof_LmpMsgError()
        If TextBox1.Text <> "" Then
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
                wp_sDatCmp = TextBox1.Text
                wp_sCodErr = wg_sCodErrCon
                mof_MsgError(wp_sNomTbl,
                            wp_sDatCmp,
                            wp_sCodErr)
                TextBox1.Focus()
            Else
                BD_TblAVp()
                mof_fLmpCtrl(Me.dgv1)
                dgv_LlenaDGV()
                mof_ActivarOK(Me)
                mof_habTsbEliminar()
            End If
        End If
        TextBox1.Focus()

    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        wp_sCmdSel = "C"
        wl_bYesNo = False
        mof_LmpMsgError()
        If TextBox1.Text <> "" Then
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
                wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                PloNroSig_APEND()
            Else
                wp_sNomTbl = wg_sNomTblE1
                wp_sDatCmp = TextBox1.Text
                wp_sCodErr = wg_sCodErrAdi
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                TextBox1.Focus()
            End If
        End If
        TextBox1.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        wp_sCmdSel = "E"
        wg_sTipTbl = wl_sTipTbl
        wg_sNomTblE1 = "IEMOV"
        wg_sNomTblL1 = "ILMOV1"
        wl_bYesNo = False
        mof_LmpMsgError()
        If TextBox1.Text <> "" Then
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
                    wr_bEOFE1 = True
                    wl_bYesNo = clnIEINV.cnEliminar(wg_sNomTblE1,
                                                    wg_sNomTblL1,
                                                    vp_sCodDoc,
                                                    vp_nNroDoc,
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
                        TextBox2.Focus()
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        grl_Cerrar()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        grl_Cerrar()
    End Sub
#End Region

#Region "CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdListar.Click
        Dim wl_frmLst As New frmGQLst
        wg_sTblCon1 = "TEDMT"
        wg_sCmpCon11 = "sCodTer"
        wg_sCmpCon12 = "sNomTer"
        wg_sTitCon11 = "Código tercero"
        wg_sTitCon12 = "Nombre tercero"
        wg_sSelCon11 = ""
        wg_sSelCon12 = ""
        wr_bEOFCon1 = True
        wl_frmLst.ShowDialog()

        ' TextBox6.Text = wg_sSelCon11

    End Sub
    Private Sub cmdLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdLinea.Click
        Dim wl_frmLst As New frmGQLst
        wg_sTblCon1 = "ILDMI2"
        wg_sCmpCon11 = "sCodItm"
        wg_sCmpCon12 = "sCodter"
        wg_sTitCon11 = "Código ítem"
        wg_sTitCon12 = "Código Tercero"
        wg_sSelCon12 = ""
        wr_bEOFCon1 = True

        wl_frmLst.ShowDialog()
        ' TextBox6.Text = wg_sSelCon12

    End Sub
    Private Sub cmdMaestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdMaestro.Click
        Dim frmMaestro As New frmTEDMT
        frmMaestro.Show()
    End Sub
#End Region

#Region "DGV Procedimientos del Usuario"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wg_sNomTblL1 = "ILMOV1"
        Try
            vp_sCodItm = TextBox1.Text

            For wl_nRow = 0 To dgv1.RowCount - 1
                If dgv1.Rows(wl_nRow).Cells(4).Value Is Nothing Then
                    Exit For
                End If

                vp_nId = dgv1.Rows(wl_nRow).Cells(0).Value
                vp_sCodDoc = dgv1.Rows(wl_nRow).Cells(1).Value
                vp_nNroDoc = dgv1.Rows(wl_nRow).Cells(2).Value
                vp_sTipMov = dgv1.Rows(wl_nRow).Cells(3).Value
                vp_sCodItm = dgv1.Rows(wl_nRow).Cells(4).Value
                vp_sDesItm = dgv1.Rows(wl_nRow).Cells(5).Value
                vp_sCodAlm = dgv1.Rows(wl_nRow).Cells(6).Value
                vp_nCanItm = dgv1.Rows(wl_nRow).Cells(7).Value
                vp_sUniMedInv = dgv1.Rows(wl_nRow).Cells(8).Value
                vp_nPreUni = dgv1.Rows(wl_nRow).Cells(9).Value
                vp_nVlrTot = dgv1.Rows(wl_nRow).Cells(10).Value
                vp_nSdoSto = dgv1.Rows(wl_nRow).Cells(11).Value
                vp_sCtaCtb = dgv1.Rows(wl_nRow).Cells(12).Value
                'wp_sOpc = dgv1.Rows(i).Cells(13).Value

                wp_sCmdSel = wl_sCmdAnt
                If vp_nId <> 0 Then
                    wp_sCmdSel = "A"
                Else
                    wp_sCmdSel = "C"
                End If

                If dgv1.Rows(wl_nRow).Visible = True Then

                    clnIEINV.cnCrearActILMOV1(wg_sNomTblL1,
                                              vp_nId,
                                              wp_sCmdSel,
                                              wp_bEOF2)


                Else
                    vp_sCodDoc = dgv1.Rows(wl_nRow).Cells(1).Value
                    vp_nNroDoc = dgv1.Rows(wl_nRow).Cells(2).Value
                    wl_bYesNo = clnIEINV.cnEliminarILMOV1(wg_sNomTblL1,
                                                          vp_nId,
                                                          vp_sCodDoc,
                                                          vp_nNroDoc,
                                                          wp_bEOF2)

                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdicionarLinea()
        Try
            With dgv1
                wl_nCntRow = .RowCount
                ' If .RowCount = 0 Then
                .Rows.Add()
                'End If


                wl_nCntRow = .RowCount

                .RowTemplate.Height = wl_RowAlto

                .CurrentCell = .Rows(wl_nCntRow - 1).Cells(4)

                .CurrentRow.Cells(1).Value = vp_sCodDoc
                .CurrentRow.Cells(2).Value = vp_nNroDoc
                .CurrentRow.Cells(3).Value = vp_sTipMov
                vp_nVlrTot = vp_nVlrTot + (.CurrentRow.Cells(7).Value * .CurrentRow.Cells(9).Value)
                .CurrentRow.Cells(10).Value = (.CurrentRow.Cells(7).Value * .CurrentRow.Cells(9).Value)
                .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString

                .CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIni)
            End With
            wl_nTab = 0


            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count
            dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            ' dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIni)
            dgv1.Rows(wl_nRow).Cells(2).Value = TextBox1.Text

        Catch ex As Exception
            MsgBox("Error : dgv_AdicionarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_AdiLinBlanco(ByVal wl_nRowVacia As Integer)
        For wl_nF = 0 To wl_nRowVacia
            dgv1.Rows.Add()
        Next
    End Sub
    Private Sub dgv_ConfigurarDGV()
        wl_nTotCol = 14
        wl_nColFin = 10

        With dgv1
            'Propiedades iniciales
            .Dock = DockStyle.Fill
            .BackgroundColor = wg_ClrFrm
            .BorderStyle = BorderStyle.FixedSingle

            .TopLeftHeaderCell.Value = "Nro"




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


            .SelectionMode = DataGridViewSelectionMode.CellSelect

            .MultiSelect = False

            .EnableHeadersVisualStyles = False
            .ColumnCount = wl_nTotCol

        End With

        With dgv1
            .Columns(0).HeaderText = "Nro_Reg"
            .Columns(1).HeaderText = "Cod_Doc"
            .Columns(2).HeaderText = "Nro_Doc"
            .Columns(3).HeaderText = "Tip_Mov"
            .Columns(4).HeaderText = "Código Ítem"
            .Columns(5).HeaderText = "Descripción"
            .Columns(6).HeaderText = "Almacén"
            .Columns(7).HeaderText = "Cantidad"
            .Columns(8).HeaderText = "Unidad"
            .Columns(9).HeaderText = "Precio Unitario"
            .Columns(10).HeaderText = "Total"
            .Columns(11).HeaderText = "En Stock"
            .Columns(12).HeaderText = "Cuenta Contable"
            .Columns(13).HeaderText = "Estado"
        End With

    End Sub
    Private Sub dgv_ConfiguraCol()
        Dim vl_sNomCmp As String
        wl_nColFin = -1
        wl_nColIni = -1
        wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha

        ' formato c: cadena con formato numérico estándar

        For wp_nC = 0 To wl_nTotCol - 1
            wp_bVisible = True
            wp_bReadOnly = False
            wp_sTipCol = "S"

            ' formato
            If wp_nC = 0 Then
                wp_sTipCol = "N"
                wp_bVisible = False
                wp_bReadOnly = True
            End If
            If wp_nC = 1 Then
                wp_bVisible = False
                wp_bReadOnly = True
            End If
            If wp_nC = 2 Then
                wp_bReadOnly = True
                wp_bVisible = False
            End If

            If wp_nC = 3 Then
                wp_bVisible = False
                wp_bReadOnly = True
            End If



            If wp_nC = 7 Then
                wp_sTipCol = "C" 'N = numérico. C = pesos. S = string. d = fec
            End If

            If wp_nC = 8 Then
                wp_bReadOnly = True
            End If
            If wp_nC = 9 Then
                wp_sTipCol = "C" 'N = numérico. C = pesos. S = string. d = fecha
            End If

            If wp_nC = 10 Then
                wp_sTipCol = "C" 'N = numérico. C = pesos. S = string. d = fecha
            End If
            If wp_nC = 11 Then
                wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
                wp_bReadOnly = True
            End If
            If wp_nC = 12 Then
                wp_bReadOnly = True
            End If

            If wp_nC = 13 Then
                wp_bReadOnly = True
            End If
            vl_sNomCmp = ""
            mof_DGVFormatCol(Me.dgv1,
                             wp_nC,
                             wp_sTipCol,
                             wp_bVisible,
                             wp_bReadOnly,
                             vl_sNomCmp)

            If wl_nColIni < 0 Then
                If dgv1.Columns(wp_nC).Visible = True Then
                    wl_nColIni = wp_nC
                End If
            End If
            If dgv1.Columns(wp_nC).Visible = True And dgv1.Columns(wp_nC).ReadOnly = False Then
                wl_nColFin = wp_nC
            End If
        Next
    End Sub
    Private Sub dgv_LlenaDGV()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vp_nNroDoc = TextBox1.Text
        wg_sNomTblL1 = "ILMOV1"
        Try
            wg_DTL1 = clnIEINV.cndtConsultarILMOV1(wg_sNomTblL1,
                                                   vp_sCodDoc,
                                                   vp_nNroDoc,
                                                   wr_bEOFL1)


            If dgv1.Rows.Count > 0 Then
                dgv1.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdicionarLinea()
                        .Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                        .Rows(wl_nRow).Cells(0).Value = wg_DTL1.Rows(wl_nRow).Item(0)
                        .Rows(wl_nRow).Cells(1).Value = wg_DTL1.Rows(wl_nRow).Item(1)
                        .Rows(wl_nRow).Cells(2).Value = wg_DTL1.Rows(wl_nRow).Item(2)
                        .Rows(wl_nRow).Cells(3).Value = wg_DTL1.Rows(wl_nRow).Item(3)
                        .Rows(wl_nRow).Cells(4).Value = wg_DTL1.Rows(wl_nRow).Item(4)
                        .Rows(wl_nRow).Cells(5).Value = wg_DTL1.Rows(wl_nRow).Item(14)
                        .Rows(wl_nRow).Cells(6).Value = wg_DTL1.Rows(wl_nRow).Item(5)
                        .Rows(wl_nRow).Cells(7).Value = wg_DTL1.Rows(wl_nRow).Item(6)
                        .Rows(wl_nRow).Cells(8).Value = wg_DTL1.Rows(wl_nRow).Item(7)
                        .Rows(wl_nRow).Cells(9).Value = wg_DTL1.Rows(wl_nRow).Item(8)
                        .Rows(wl_nRow).Cells(10).Value = wg_DTL1.Rows(wl_nRow).Item(9)
                        .Rows(wl_nRow).Cells(12).Value = wg_DTL1.Rows(wl_nRow).Item(12)
                    Next
                End With
                dgv_SumaFormatea()

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
                dgv1.Rows(wl_nRow).Cells(1).Value = TextBox1.Text
                dgv1.Rows(wl_nRow).Cells(2).Value = TextBox2.Text
                wr_bEOFL1 = True
                wg_sTblLst1 = "ATALM"
                wg_sCmpLst1 = "sCodAlm"
                wg_sTipLst1 = "C"
                wg_sCmpOrdLst1 = ""
                wg_sTipOrdLst1 = ""
                wg_sDatLst1 = dgv1.CurrentRow.Cells(2).Value
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
                For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_SumaFormatea()
        vp_nVlrTot = 0
        With dgv1
            For i = 0 To .RowCount - 1
                vp_nVlrTot = vp_nVlrTot + (.Rows(i).Cells(7).Value * .Rows(i).Cells(9).Value)
                .Rows(i).Cells(10).Value = (.Rows(i).Cells(7).Value * .Rows(i).Cells(9).Value)
                .Columns(7).DefaultCellStyle.Format = "###,###,###,###.00"
                .Columns(9).DefaultCellStyle.Format = "###,###,###,###.00"
                .Columns(10).DefaultCellStyle.Format = "###,###,###,###.00"
                .Columns(11).DefaultCellStyle.Format = "###,###,###,###.00"
                .Columns(9).DefaultCellStyle.Format = "c"
                .Columns(10).DefaultCellStyle.Format = "c"
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next
        End With
        TextBox5.Text = Format(CDbl(vp_nVlrTot), "C")
        TextBox5.TextAlign = HorizontalAlignment.Right
    End Sub
#End Region
#Region "DGV Controladores de Eventos"
    Private Sub dgv1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgv1.CellFormatting

        e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        If e.ColumnIndex = 9 Or
           e.ColumnIndex = 10 Then
            e.CellStyle.Format = "###,###,###,###.##"
            e.CellStyle.Format = "c"
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If e.ColumnIndex = 0 Or
           e.ColumnIndex = 2 Or
           e.ColumnIndex = 7 Or
           e.ColumnIndex = 11 Then
            e.CellStyle.Format = "###,###,###,###.00"
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

    End Sub

    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        wl_nRowAnt = e.RowIndex
        wl_nColAnt = e.ColumnIndex
    End Sub

    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        If dgv1.CurrentCell.ReadOnly = True Then
            dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
        End If
    End Sub
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
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


    Private Sub dgv1_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles dgv1.CellStateChanged
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try
        Catch
            MsgBox("Error: dgv1_CellStateChanged")
        End Try

    End Sub


    Private Sub dgv1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellValueChanged
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        Try
            If dgv1.Rows.Count > 0 Then
                grl_TextChange()
                wl_nRow = e.RowIndex
                wl_nCol = e.ColumnIndex


                ' Consulta saldos item en almacén
                If wl_nCol = 7 Then
                    wr_bEOFE2 = True
                    vp_sCodItm = dgv1.CurrentRow.Cells(4).Value
                    vp_sCodAlm = dgv1.CurrentRow.Cells(6).Value
                    wg_DTE2 = clnIEDMI.cndtConSdoILMDI1(vp_sCodAlm,
                                                        vp_sCodItm,
                                                        wp_bEOF2)

                    If Not wp_bEOF2 Then
                        dgv1.Rows(wl_nRow).Cells(11).Value = wg_DTE2.Rows(0).Item(5)
                    End If
                End If

                If wl_nCol = 7 Or wl_nCol = 9 Or wl_nCol = 10 Then
                    dgv_SumaFormatea()
                    wl_nNroCol = wl_nCol

                End If


            End If



        Catch
            MsgBox("Error : dgv1_CellValueChanged")

        End Try

    End Sub
    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
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

    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyUp
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_i As Integer

        Try
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCol = dgv1.CurrentCellAddress.X
            wl_nCntRow = dgv1.Rows.Count



            If wl_nCol = 5 Then
                If dgv1.CurrentRow.Cells(4).Value <> Nothing Then
                    wg_sNomTblE2 = "IEDMI"
                    wg_sNomCmpE21 = "sCodItm"
                    wg_sDatCmpE21 = dgv1.CurrentRow.Cells(4).Value
                    wg_sTipCmpE21 = "C"
                    wr_bEOFE2 = False
                    wg_sCmpOrdE21 = ""
                    wg_sTipOrdE21 = ""
                    wg_DTE2 = clnConTbl.cndtBuscar(wg_sNomTblE2,
                                                   wg_sNomCmpE21,
                                                   wg_sDatCmpE21,
                                                   wg_sTipCmpE21,
                                                   wg_sCmpOrdE21,
                                                   wg_sTipOrdE21,
                                                   wr_bEOFE2)
                    If Not wr_bEOFE2 Then
                        dgv1.Rows(wl_nRow).Cells(5).Value = wg_DTE2.Rows(0).Item(3)
                        dgv1.Rows(wl_nRow).Cells(8).Value = wg_DTE2.Rows(0).Item(30)
                        wl_nCol = 6
                        dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                        Exit Sub
                    Else
                        dgv1.CurrentCell.Value = Nothing
                    End If

                End If
            End If

            If dgv1.CurrentCell.Value = Nothing Then
                If wl_nCol = 5 Then ' Or wl_nCol = 5 
                    dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                    BD_CargarIEDMI(4, 5, 4)
                    Exit Sub
                End If
                If wl_nColAnt = 6 Then
                    If dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt).Value = Nothing Then
                        dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                        BD_CargarATALM(6, -1, 7)
                    End If
                    'Exit Sub
                End If
            End If

            If wl_nColAnt = 6 Then
                If dgv1.CurrentRow.Cells(6).Value <> Nothing Then
                    wr_bEOFL1 = True
                    wg_sTblLst1 = "ATALM"
                    wg_sCmpLst1 = "sCodAlm"
                    wg_sTipLst1 = "C"
                    wg_sCmpOrdLst1 = ""
                    wg_sTipOrdLst1 = ""
                    wg_sDatLst1 = dgv1.CurrentRow.Cells(6).Value
                    wg_DTLst1 = clnConTbl.cndtBuscar(wg_sTblLst1,
                                                     wg_sCmpLst1,
                                                     wg_sDatLst1,
                                                     wg_sTipLst1,
                                                     wg_sCmpOrdLst1,
                                                     wg_sTipOrdLst1,
                                                     wr_bEOFLst1)
                    If Not wr_bEOFLst1 Then
                        dgv1.Rows(wl_nRow).Cells(6).Value = wg_DTLst1.Rows(0).Item(0)
                        wl_nCol = 7
                        dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                        wg_sNomTblE2 = "ILDMI1"
                        wg_sNomCmpE21 = "sCodItm"
                        wg_sDatCmpE21 = dgv1.CurrentRow.Cells(4).Value
                        wg_sTipCmpE21 = "C"
                        wg_sNomCmpE22 = "sCodAlm"
                        wg_sDatCmpE22 = dgv1.CurrentRow.Cells(6).Value
                        wg_sTipCmpE22 = "C"
                        wr_bEOFE2 = False
                        wg_DTE2 = clnConTbl.cndtBuscarE2(wg_sNomTblE2,
                                                        wg_sNomCmpE21,
                                                        wg_sDatCmpE21,
                                                        wg_sTipCmpE22,
                                                        wg_sNomCmpE22,
                                                        wg_sDatCmpE22,
                                                        wg_sTipCmpE22,
                                                        wr_bEOFE2)
                        If wr_bEOFE2 Then
                            MsgBox("Ítem + almacén no Existe en Almacén referencia")
                            wl_nColAnt = 6
                            dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColAnt)
                            wl_nColAnt = 6
                            dgv1.CurrentCell.Value = Nothing
                        End If

                        Exit Sub
                    Else
                        wl_nColAnt = 6
                        dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColAnt)
                        wl_nColAnt = 6
                        dgv1.CurrentCell.Value = Nothing
                    End If
                End If
                wl_nColAnt = 6
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColAnt)
                wl_nColAnt = 6
                dgv1.CurrentCell.Value = Nothing
            End If



            If dgv1.CurrentCell.ReadOnly = True Then
                For wl_i = wl_nCol To wl_nColFin
                    If dgv1.CurrentCell.ReadOnly = False Then
                        Exit For
                    End If
                    If wl_i > wl_nColFin Then
                        wl_i = wl_nColIni
                        If dgv1.CurrentCell.RowIndex = dgv1.Rows.Count - 1 Then
                            dgv_AdicionarLinea()
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
                            dgv_AdicionarLinea()
                        End If
                        dgv_SumaFormatea()
                        wl_nRow = dgv1.CurrentCellAddress.Y '+ 1
                        wl_nCol = wl_nColIni
                        dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                        wl_nTab = 0
                    Else
                        wl_nTab = 1
                    End If
                End If
            End If





        Catch ex As Exception
            MsgBox("Error: dgv1_KeyUp")

            MsgBox(ex.Message)


        End Try
    End Sub


#End Region
#Region "Funciones Locales"

    Private Function Validaciones(ByRef wl_bVda As Boolean)
        wl_bVda = False
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("El Número del documento es obligatorio")
            TextBox1.Focus()
            Return wl_bVda
        End If
        wl_bVda = True
        Return wl_bVda
    End Function

#End Region

#Region "Plo Procedimientos del Formulario"
    Private Sub Plo_IniciarVar()
        wl_bYesNo = False
        wl_bEdit = False
        wg_sCodErrAdi = "10-203"
        wg_sCodErrCon = "10-103"
        wg_sCodErrOk = "20-001"
        wg_sDesMsgEli = "Este opción elimina el documento. ¿ Continua ?"
        wg_sTitMsgEli = "Mensaje del sistema"

        ' IEINV

        vp_nNroDoc = 0

        dtpFecCtb.Format = DateTimePickerFormat.Short
        dtpFecDoc.Format = DateTimePickerFormat.Short
        dtpFecCtb.Value = Date.Today
        dtpFecDoc.Value = Date.Today

        mof_ActivarCrear(Me)

        ' dgv_AdicionarLinea()
        dtpFecCtb.Visible = False
        dtpFecDoc.Visible = False
        mtbFecCtb.Text = dtpFecCtb.Value
        mtbFecDoc.Text = dtpFecDoc.Value

        vp_sCodDoc = "ENT"
        vp_sTipMov = "E"
        Plo_LeeAPEND()
        vp_nNroDoc = TextBox1.Text

        'dgv

        wl_nColFin = 10
        wl_nColIni = 4
        wl_nTotCol = 12
        wl_RowAlto = 6
        wl_nTab = 0
        wl_nRowVacia = 7
        dgv_ConfigurarDGV()
    End Sub
    Private Sub Plo_ActivarCrear()
        mof_ActivarCrear(Me)
        Plo_IniciarVar()
        dgv1.Enabled = True
        dgv1.Rows.Clear()
        dgv_ConfigurarDGV()
        dgv_ConfiguraCol()
        dgv_AdicionarLinea()
    End Sub
    Private Sub Plo_LeeAPEND()
        Dim clnConTbl As New ClaseNegocios.clnConTbl

        wg_sNomTblE2 = "APEND"
        wg_sNomCmpE21 = "sCodDoc"
        wg_sDatCmpE21 = vp_sCodDoc
        wg_sTipCmpE21 = "C"
        wg_sCmpOrdE21 = ""
        wg_sTipOrdE21 = ""
        wr_bEOFE1 = True
        wg_DTE2 = clnConTbl.cndtBuscar(wg_sNomTblE2,
                                       wg_sNomCmpE21,
                                       wg_sDatCmpE21,
                                       wg_sTipCmpE21,
                                       wg_sCmpOrdE21,
                                       wg_sTipOrdE21,
                                       wr_bEOFE1)

        TextBox1.Text = wg_DTE2.Rows(0).Item(5)
        ' vp_nNroDoc = vl_DT.Rows(0).Item(4)

    End Sub
    Private Sub PloNroSig_APEND()
        Dim clnActualizar As New ClaseNegocios.clnActTbl

        vp_nNroSig = CType(TextBox1.Text, Double) + 1
        wg_sNomTblE2 = "APEND"
        wg_sNomCmpE21 = "sCodDoc"
        wg_sDatCmpE21 = vp_sCodDoc
        wg_sTipCmpE21 = "C"

        wp_sNomCmp = "nNroSig"
        wp_sDatCmp = vp_nNroSig
        wp_sTipCmp = "N"

        wr_bEOF = True
        clnActTbl.cndtActUnaLlaUnCmp(wg_sNomTblE2,
                                        wg_sNomCmpE21,
                                        wg_sDatCmpE21,
                                        wg_sTipCmpE21,
                                        wp_sNomCmp,
                                        wp_sDatCmp,
                                        wp_sTipCmp,
                                        wr_bEOF)


    End Sub

#End Region

#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#End Region


#Region "grl Changed"
    Private Sub grl_Cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Chb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Txt_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DirectCast(sender, TextBox).Name = "TextBox1" Then
            wg_sClaPpl = TextBox1.Text
            mof_LmpMsgError()
        Else
            grl_TextChange()
        End If
    End Sub
#End Region
#Region "grl Eventos"
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
#Region "Grl Got Focus"
    Private Sub grl_Cbo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Chb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrGot
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
#Region "grl Lost Focus"
    Private Sub grl_Cbo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Chb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Rdb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
#End Region
#Region "grl Otros"
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_LmpMsgError()
        Me.Close()
    End Sub
    Private Sub grl_TextChange()
        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region
#Region "TSB ToolStrip Procedimientos eventos de la barra de herramientas"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
    End Sub
    Private Sub tsb_Primero()
        BD_DatPrmTSB()
        mof_habTsbCrear()
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
        BD_DatPrmTSB()
        mof_habTsbCrear()
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
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Anterior")
        End Try

    End Sub
    Private Sub tsb_Siguiente()
        BD_DatPrmTSB()
        mof_habTsbCrear()
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
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Siguiente")
        End Try

    End Sub
    Private Sub tsb_Ultimo()
        BD_DatPrmTSB()
        mof_habTsbCrear()
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
    End Sub
    Private Sub tsb_VistaPrevia()
        MsgBox("Vista Previa")
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
#End Region
#Region "TSMI ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
        dgv_AdicionarLinea()
    End Sub
    Private Sub tsmi_EliminarLinea()
        mof_ActivarActualizar(Me)
        dgv_EliminarLinea()
    End Sub
#End Region



    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class