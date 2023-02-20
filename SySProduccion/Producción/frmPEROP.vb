Public Class frmPEROP
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-10
#End Region
#Region "001 Inicia. wp - vp Definición del variables públicas"
    Public Property wg_aePEODP As Array
    Public Property wg_aePLODP2 As Array
    Public Property wg_aeTEDMT As Array
    Public Property wg_sFrmOri As String
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

    ' Caracter

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
    Dim wl_sNomTblL1 As String

    ' Variables públicas


    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_nNroOpc As Integer
    Dim wp_sTipCmp As String
    Dim wl_nIdPEROP As Long
#End Region
#Region "012 BD - Variables campos BD Locales"

    Dim vl_nId As Long
    Dim vl_nNroDoc As Long
    Dim vl_sCodDoc As String
    Dim vl_sCodSer As String
    Dim vl_sTipMov As String
    Dim vl_sCodTer As String
    Dim vl_sEstDoc As String
    Dim vl_dFecCtb As Date
    Dim vl_dFecDoc As Date
    Dim vl_dFecVto As Date
    Dim vl_dFecSys As Date
    Dim vl_sNomTer As String
    Dim vl_sDocRef As String
    Dim vl_nTotHHCns As Long
    Dim vl_nTotMMCns As Long
    Dim vl_nTotTieCns As Double
    Dim vl_nTotDoc As Double
    Dim vl_sCodCte As String
    Dim vl_nNroCte As Long
    Dim vl_sClsDoc As String
    Dim vl_sCmn As String
    Dim vl_sCodCteCtb As String
    Dim vl_nNroCteCtb As Long
    Dim vl_nIdFECCT As Long
    Dim vl_sNitTer As String
    Dim vl_sTipDoc As String
    Dim vl_sCodUsr As String
    Dim vl_bPrp01 As Boolean
    Dim vl_bPrp02 As Boolean
    Dim vl_bPrp03 As Boolean
    Dim vl_nTotHHOpe As Long
    Dim vl_nTotMMOpe As Long
    Dim vl_nTotTieOpe As Double
    Dim vl_nTotHHAlz As Long
    Dim vl_nTotMMAlz As Long
    Dim vl_nTotTieAlz As Double
    Dim vl_nTotHHCaf As Long
    Dim vl_nTotMMCaf As Long
    Dim vl_nTotTieCaf As Double

    Dim vl_sEstOdp As String
    Dim vl_sEstPdo As String
    Dim vl_sTipRegTie As String
#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas
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
    Dim clnPEROP As New ClaseNegocios.clnPEROP
    Dim clnPEODP As New ClaseNegocios.clnPEODP
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTLst1 As New DataTable
    Dim wl_DTAPLND1 As New DataTable

#End Region
#Region "015 Estructuras"

    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim wl_aePEROP() As moe_Estructuras.ePEROP
    Dim wl_aePLROP1() As moe_Estructuras.ePLROP1
    Dim wl_eABESD As New moe_Estructuras.eABESD
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
    Dim wl_eATOPE As New moe_Estructuras.eATOPE
    Dim wl_eFECTT As New moe_Estructuras.eFECTT
    Dim wl_eFLCTT1 As New moe_Estructuras.eFLCTT1
    Dim wl_eATPOP As New moe_Estructuras.eATPOP
    Dim wl_ePEODP As New moe_Estructuras.ePEODP
    Dim wl_ePEROP As New moe_Estructuras.ePEROP
    Dim wl_ePLODP2 As moe_Estructuras.ePLODP2
    Dim wl_ePLROP1 As New moe_Estructuras.ePLROP1


#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region

#Region "020 frm Eventos - Principal"

    Private Sub frmPEROP_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error :  frmPEROP_Disposed")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmPEROP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_RemoveHandler()
            grl_AddHandler()
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            Cbo_CargarLst()
            Plo_IniciarEst() '080
            Plo_IniciarDoc() '080
            Plo_IniciarVar() '080
            wl_sTipTbl = "E2"
            wg_sTipTbl = wl_sTipTbl
            BD_DatPrmTipTbl(wg_sTipTbl)
            dgv_APDGV()
            Plo_IniciarVarDGV() '080
            grl_EventCtrl(Me)
            'Cbo_CargarLst()
            Plo_ActivarCrear() '080
            Plo_TxtIni() '080

        Catch ex As Exception
            MsgBox("Error :  frmPESDM_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarAPLND1()
            Cbo_CargarABESD()
            Cbo_CargarABROP()

        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABESD()
        Try
            '  cboABESD.Enabled = False
            wl_DTLst1 = New DataTable
            wg_sTblLst1 = "ABESD"
            wr_bEOFLst1 = True
            wl_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABESD.DataSource = wl_DTLst1
                cboABESD.ValueMember = wl_DTLst1.Columns("sEstDoc").Caption.ToString
                cboABESD.DisplayMember = wl_DTLst1.Columns("sNomEstDoc").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABESD")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarABROP()
        Try
            '  cboABESD.Enabled = False
            wl_DTLst1 = New DataTable
            wg_sTblLst1 = "ABROP"
            wr_bEOFLst1 = True
            wl_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABROP.DataSource = wl_DTLst1
                cboABROP.ValueMember = wl_DTLst1.Columns("sTipMov").Caption.ToString
                cboABROP.DisplayMember = wl_DTLst1.Columns("sNomMov").Caption.ToString
            End If
            cboABROP.SelectedValue = "S"
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABROP")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarAPLND1()
        Try
            wl_DTAPLND1 = New DataTable
            wg_sTblLst1 = "APLND1"
            wr_bEOFLst1 = wr_bEOFLst1
            wl_DTAPLND1 = clnConTbl.cndtCargarNro(wg_sTblLst1,
                                                  wl_ePEROP.sCodDoc,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboAPLND1.DataSource = wl_DTAPLND1
                cboAPLND1.ValueMember = wl_DTAPLND1.Columns("sCodSer").Caption.ToString
                cboAPLND1.DisplayMember = wl_DTAPLND1.Columns("sCodSer").Caption.ToString
                cboAPLND1.SelectedValue = wg_DTE2.Rows(0).Item("sCodSer")
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarAPLND1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboABROP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboABROP.SelectedIndexChanged
        Try
            Select Case cboABROP.SelectedIndex
                Case 0
                    cboAPLND1.SelectedValue = "AO"
                Case 1
                    cboAPLND1.SelectedValue = "RO"
            End Select


        Catch ex As Exception
            MsgBox("Error :  cboABROP_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cboAPLND1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAPLND1.SelectedIndexChanged
        Dim wl_i As Integer
        Try

            wl_eAPLND1 = New moe_Estructuras.eAPLND1

            If cmdCrear.Visible = True Then

                wl_i = cboAPLND1.SelectedIndex
                If wl_bSwsCbo Then
                    wg_sTblLst1 = "APLND1"
                    wr_bEOFLst1 = wr_bEOFLst1
                    vl_sCodSer = cboAPLND1.Text
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
                        dgv_AdiRowPLROP1()
                    End If
                Else
                    wl_bSwsCbo = True
                    wl_i = cboAPLND1.FindString(vl_sCodSer)
                    cboAPLND1.SelectedIndex = wl_i
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cboAPLND1_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        '  wl_sNomTblE1 = "CEODC"
        Dim wl_ni1 As Integer
        wl_bYesNo = False
        Try
            Plo_Var_Frm()
            BD_ePEROP_Var()
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
                If wl_CtrlDgv.Rows(0).Cells("sCodOpe").Value = "" Then
                    MsgBox("Documento no tiene código de operación")
                    txtsCodTer.Focus()
                    Return wl_bYesNo
                End If
            End If
            For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                wl_ni1 = wl_nI + 1
                If wl_CtrlDgv.Rows(wl_nI).Cells("sCodOpe").Value = "" Then
                    Exit For
                End If
                '   If wl_CtrlDgv.Rows(wl_nI).Cells("nTieCns").Value = 0 Then
                ' MsgBox("Línea Nro. " & wl_ni1.ToString & " tiene Cantidad en 0")
                ' wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nTieCns")
                ' Return wl_bYesNo
                ' End If
            Next


            wg_bVdaE1 = True
            '     If Not mov_VdaTxt(wg_bVdaE1,
            '                       txtsCodTer) Then
            '     txtsCodTer.Focus()
            '     Return wl_bYesNo
            '     Exit Function
            '     End If
            If Not mov_VdaTxt(wg_bVdaE1,
                              txtnNroDoc) Then
                txtnNroDoc.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            'wl_bYesNo = clnPEROP.cnCrearAct(wl_ePEROP,
            '                                wr_bEOFE1,
            '                                wp_sCmdSel)

            wl_nIdPEROP = clnPEROP.cnCrearAct(wl_ePEROP,
                                              wr_nIdEnc,
                                              wp_sCmdSel)
            vl_nId = wl_nIdPEROP
            If (vl_nId) Then
                wl_bYesNo = True
            End If


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
                wl_sNomTblE1 = "PEROP"
                wg_sNomCmpE11 = "nNroDoc"
                wg_sTipCmpE11 = "N"
                wg_sTitCmpE11 = "Número documento"
                wg_sDatCmpE11 = CLng(txtnNroDoc.Text)
                wg_sClaPpl = txtnNroDoc.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "E2" Then
                wl_sNomTblE1 = "PEROP"
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
                    wg_sDatTSB = wl_ePEROP.nId
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
    Private Sub BD_ePEROP_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_ePEROP = New moe_Estructuras.ePEROP
            moo_ePEROP_DT(wl_ePEROP,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox("Error :  BD_ePEROP_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_ePEROP_Var()
        Try
            wl_ePEROP = New moe_Estructuras.ePEROP
            With wl_ePEROP
                .nId = 0 '0
                .sCodDoc = vl_sCodDoc '1
                .nNroDoc = vl_nNroDoc
                .sCodSer = vl_sCodSer
                .sTipMov = vl_sTipMov
                .sEstDoc = vl_sEstDoc '5
                .dFecCtb = vl_dFecCtb
                .dFecDoc = vl_dFecDoc
                .dFecVto = vl_dFecVto
                .dFecSys = vl_dFecSys
                .sCodTer = vl_sCodTer '10
                .sNomTer = vl_sNomTer
                .sDocRef = vl_sDocRef
                .nTotHHCns = vl_nTotHHCns
                .nTotMMCns = vl_nTotMMCns
                .nTotTieCns = vl_nTotTieCns '15
                .nTotDoc = vl_nTotDoc
                .sCodCte = vl_sCodCte
                .nNroCte = vl_nNroCte
                .sClsDoc = vl_sClsDoc
                .sCmn = vl_sCmn '20
                .sCodCteCtb = vl_sCodCteCtb
                .sCodCteCtb = vl_sCodCteCtb
                .nIdFECCT = vl_nIdFECCT
                .sNitTer = vl_sNitTer
                .sTipDoc = vl_sTipDoc '25
                .sCodUsr = vl_sCodUsr
                .bPrp01 = vl_bPrp01
                .bPrp02 = vl_bPrp02
                .bPrp03 = vl_bPrp03
                .nTotHHOpe = vl_nTotHHOpe '30
                .nTotMMOpe = vl_nTotMMOpe
                .nTotTieOpe = vl_nTotTieOpe
                .nTotHHAlz = vl_nTotHHAlz
                .nTotMMAlz = vl_nTotMMAlz
                .nTotTieAlz = vl_nTotTieAlz '35
                .nTotHHCaf = vl_nTotHHCaf
                .nTotMMCaf = vl_nTotMMCaf
                .nTotTieCaf = vl_nTotTieCaf '38

            End With
        Catch ex As Exception
            MsgBox(ex.Message)

            MsgBox("Error en el SUB: BD_ePEROP_Var")
        End Try
    End Sub
    Private Sub BD_ePLROP1_Var(ByVal wl_nRow)
        Try
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            moo_ePLROP1_DGV(wl_ePLROP1,
                            wl_CtrlDgv,
                            wl_nRow)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ePLROP1_Var")
        End Try
    End Sub
    Private Sub BD_eATPOP_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eATPOP = New moe_Estructuras.eATPOP
            moo_eATPOP_DT(wl_eATPOP,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eATPOP_DT")
        End Try
    End Sub
    Private Sub BD_Lst_ATPOP()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATPOP"
            wl_frmLst.wp_eATPOP = New moe_Estructuras.eATPOP
            wl_frmLst.ShowDialog()
            wl_eATPOP = wl_frmLst.wp_eATPOP
            txtsCodTer.Text = wl_eATPOP.sCodTer
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Lst_ATPOP")
        End Try
    End Sub
    Private Sub BD_Var_ePEROP()
        Dim vl_nNroDocAnt As Long
        Try
            With wl_ePEROP

                vl_nNroDocAnt = .nNroDoc
                wl_ePEROP.nNroDoc = vl_nNroDocAnt

                vl_sCodDoc = .sCodDoc
                vl_nNroDoc = .nNroDoc
                txtnNroDoc.Text = .nNroDoc
                vl_sCodSer = .sCodSer
                cboAPLND1.Text = .sCodSer
                vl_sTipMov = .sTipMov
                vl_sEstDoc = .sEstDoc
                cboABESD.SelectedValue = .sEstDoc
                vl_dFecCtb = .dFecCtb
                vl_dFecDoc = .dFecDoc
                vl_dFecVto = .dFecVto
                vl_dFecSys = .dFecSys
                vl_sCodTer = .sCodTer
                txtsCodTer.Text = .sCodTer
                vl_sNomTer = .sNomTer
                txtsNomTer.Text = .sNomTer '10
                vl_sDocRef = .sDocRef
                vl_nTotHHCns = .nTotHHCns
                vl_nTotMMCns = .nTotMMCns
                vl_nTotTieCns = .nTotTieCns
                vl_nTotDoc = .nTotDoc
                vl_sCodCte = .sCodCte
                vl_nNroCte = .nNroCte
                vl_sClsDoc = .sClsDoc
                vl_sCmn = .sCmn
                vl_sCodCteCtb = .sCodCteCtb
                vl_nNroCteCtb = .nNroCteCtb
                vl_nIdFECCT = .nIdFECCT
                vl_sNitTer = .sNitTer
                vl_sTipDoc = .sTipDoc
                vl_sCodUsr = .sCodUsr
                vl_bPrp01 = .bPrp01
                vl_bPrp02 = .bPrp02
                vl_bPrp03 = .bPrp03
                vl_nTotHHOpe = .nTotHHOpe
                vl_nTotMMOpe = .nTotMMOpe
                vl_nTotTieOpe = .nTotTieOpe
                vl_nTotHHAlz = .nTotHHAlz
                vl_nTotMMAlz = .nTotMMAlz
                vl_nTotTieAlz = .nTotTieAlz
                vl_nTotHHCaf = .nTotHHCaf
                vl_nTotMMCaf = .nTotMMCaf
                vl_nTotTieCaf = .nTotTieCaf
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ePEROP")
        End Try
    End Sub
    Private Sub BD_Var_eATPOP()
        Try
            With wl_eATPOP
                '  vl_nId = .nID
                txtsNomTer.Text = .sNomTer
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: wl_eATPOP")
        End Try
    End Sub
    Private Sub BD_Var_wp_aePEROP()
        Try
            With wl_aePEROP(0)
                vl_nId = .nId
                vl_sCodDoc = .sCodDoc
                vl_nNroDoc = .nNroDoc
                vl_sCodSer = .sCodSer
                vl_sTipMov = .sTipMov
                vl_sEstDoc = .sEstDoc
                vl_dFecCtb = .dFecCtb
                vl_dFecDoc = .dFecDoc
                vl_dFecVto = .dFecVto
                vl_dFecSys = .dFecSys
                vl_sCodTer = .sCodTer
                vl_sNomTer = .sNomTer
                vl_sDocRef = .sDocRef
                vl_nTotHHCns = .nTotHHCns
                vl_nTotMMCns = .nTotMMCns
                vl_nTotTieCns = .nTotTieCns
                vl_nTotDoc = .nTotDoc
                vl_sCodCte = .sCodCte
                vl_nNroCte = .nNroCte
                vl_sClsDoc = .sClsDoc
                vl_sCmn = .sCmn
                vl_sCodCteCtb = .sCodCteCtb
                vl_nNroCteCtb = .nNroCteCtb
                vl_nIdFECCT = .nIdFECCT
                vl_sNitTer = .sNitTer
                vl_sTipDoc = .sTipDoc
                vl_sCodUsr = .sCodUsr
                vl_bPrp01 = .bPrp01
                vl_bPrp02 = .bPrp02
                vl_bPrp03 = .bPrp03
                vl_nTotHHOpe = .nTotHHOpe
                vl_nTotMMOpe = .nTotMMOpe
                vl_nTotTieOpe = .nTotTieOpe
                vl_nTotHHAlz = .nTotHHAlz
                vl_nTotMMAlz = .nTotMMAlz
                vl_nTotTieAlz = .nTotTieAlz
                vl_nTotHHCaf = .nTotHHCaf
                vl_nTotMMCaf = .nTotMMCaf
                vl_nTotTieCaf = .nTotTieCaf
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_wp_aePEROP")
        End Try

    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_tsbPASU()
        Try
            BD_ePEROP_DT(wg_DTE1)
            BD_Var_ePEROP()
            Plo_Frm_Var()
            wl_CtrlDgv.Enabled = True
            dgv_DetADgv()
            mof_ActivarOK(Me)
            Plo_InactCmpAct()
            BD_DatPrmTipTbl(wg_sTipTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try
    End Sub
#End Region
#Region "042 BD Busquedas"
    Private Function BD_BuscarATCTR() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCTR = New moe_Estructuras.eATCTR
            wr_bEOFE2 = mof_fConATCTR(wl_eATOPE.sCodCtr,
                                      wl_eATCTR)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCTR")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATPOP() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATPOP = New moe_Estructuras.eATPOP
            wr_bEOFE2 = mof_fConATPOP(vl_sCodTer,
                                      wl_eATPOP)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATPOP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPEODP() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePEODP = New moe_Estructuras.ePEODP
            wr_bEOFE2 = mof_fConPEODP(wl_ePLROP1.sCodDocBas,
                                      wl_ePLROP1.nNroDocBas,
                                      vl_sEstOdp,
                                      wl_ePEODP)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPEODP")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPLODP2() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePLODP2 = New moe_Estructuras.ePLODP2
            wr_bEOFE2 = mof_fConPLODP2(wl_ePLROP1.sCodDocBas,
                                       wl_ePLROP1.nNroDocBas,
                                       Nothing,
                                       wl_ePLODP2)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPLODP2")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPLROP1() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            wr_bEOFE2 = mof_fConPLODP2(vl_sCodDoc,
                                       vl_nNroDoc,
                                       Nothing,
                                       wl_ePLROP1)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPLROP1")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATOPE() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATOPE = New moe_Estructuras.eATOPE
            wr_bEOFE2 = mof_fConATOPE(wl_ePLROP1.sCodOpe,
                                      wl_eATOPE)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATOPE")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "043 BD Cargar"
    Private Sub BD_Var_ATPOP()
        Try
            With wl_eATPOP
                txtsNomTer.Text = .sNomTer
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ATPOP")
        End Try
    End Sub
    Private Sub BD_CargarPEODP(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_ePEODP = New moe_Estructuras.ePEODP
            wl_frmLst.wp_sTxtFrm = "Ordenes de producción"
            wg_sTblCon1 = "PEODP"
            wl_frmLst.vp_sEstOdp = vl_sEstOdp
            wl_frmLst.wp_ePEODP = New moe_Estructuras.ePEODP
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            If wl_frmLst.wp_ePEODP.sCodDoc <> "" Then
                dgv1.CurrentRow.Cells("sCodDocBas").Value = wl_frmLst.wp_ePEODP.sCodDoc
                dgv1.CurrentRow.Cells("sCodSerBas").Value = wl_frmLst.wp_ePEODP.sCodSer
                dgv1.CurrentRow.Cells("nNroDocBas").Value = wl_frmLst.wp_ePEODP.nNroDoc
                dgv1.CurrentRow.Cells("sCodItm").Value = wl_frmLst.wp_ePEODP.sCodItm
                dgv1.CurrentRow.Cells("nCanItm").Value = wl_frmLst.wp_ePEODP.nCanUniOdp
            End If
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarPEODP")
        End Try
    End Sub
    Private Sub BD_CargarPLODP2(ByVal wl_CellCod As Integer,
                                ByVal wl_CellDes As Integer,
                                ByVal wl_CellSig As Integer)
        Try
            Dim wl_frmLst As New frmGQLst
            wl_ePLODP2 = New moe_Estructuras.ePLODP2
            wl_frmLst.wp_sTxtFrm = "Operaciones por orden de producción"
            wg_sTblCon1 = "PLODP2"
            wl_frmLst.wp_ePLODP2 = New moe_Estructuras.ePLODP2
            wl_frmLst.vp_sCodDoc = dgv1.CurrentRow.Cells("sCodDocBas").Value
            wl_frmLst.vp_sCodSer = dgv1.CurrentRow.Cells("sCodSerBas").Value
            wl_frmLst.vp_nNroDoc = dgv1.CurrentRow.Cells("nNroDocBas").Value
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            If wl_frmLst.wp_ePLODP2.sCodOpe <> "" Then
                wl_ePLODP2 = wl_frmLst.wp_ePLODP2
                dgv1.CurrentRow.Cells("sCodOpe").Value = wl_ePLODP2.sCodOpe
                dgv1.CurrentRow.Cells("sNomOpe").Value = wl_ePLODP2.sNomOpe
                dgv1.CurrentRow.Cells("sCodCtr").Value = wl_ePLODP2.sCodCtr
                dgv1.CurrentRow.Cells("nTieReq").Value = wl_ePLODP2.nTieReq
                dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarPLODP2")
        End Try

    End Sub
    Private Sub BD_CargarATOPE(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wl_eATOPE = New moe_Estructuras.eATOPE


            wl_frmLst.wp_sTxtFrm = "Operaciones"

            wg_sTblCon1 = "ATOPE"
            wl_frmLst.wp_eATOPE = New moe_Estructuras.eATOPE
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            If wl_frmLst.wp_eATOPE.sCodOpe <> "" Then
                wl_eATOPE = wl_frmLst.wp_eATOPE
                dgv1.CurrentRow.Cells("sCodOpe").Value = wl_eATOPE.sCodOpe
                dgv1.CurrentRow.Cells("sNomOpe").Value = wl_eATOPE.sNomOpe
                dgv1.CurrentRow.Cells("sCodCtr").Value = wl_eATOPE.sCodCtr
                dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellCod)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATOPE")
        End Try
    End Sub
#End Region
#Region "044 BD Contabilización"
    Private Sub BD_FECTT_PEROP()
        Try
            wl_bYesNo = False
            wl_eFECTT = New moe_Estructuras.eFECTT


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_FECTT_GEMOV")
        End Try
    End Sub
    Private Sub BD_FLCTT1_PLROP1()
        Try
            wl_eFLCTT1 = New moe_Estructuras.eFLCTT1


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_FLCTT1_GLMOV1")
        End Try
    End Sub
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

                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_DTE1 = mof_fConTbl(wl_sNomTblE1,
                                      wg_sNomCmpE12,
                                      wg_sDatCmpE12,
                                      wg_sTipCmpE12,
                                      wg_sCmpOrdE11,
                                      wg_sTipOrdE11,
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
                    txtnNroDoc.Enabled = False

                    BD_ePEROP_DT(wg_DTE1)
                    BD_Var_ePEROP()
                    Plo_Frm_Var()
                    mof_fLmpCtrl(Me.dgv1)
                    dgv_DetADgv()
                    mof_ActivarOK(Me)
                    Plo_InactCmpAct()
                    mof_habTsbEliminar()
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
                            wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                            PloNroSig_APEND()
                            PloNroSig_APLND1()
                            mof_InhabCtrl(Me)

                            wp_sNomTbl = wl_sNomTblE1
                            wp_sDatCmp = ""
                            wp_sCodErr = wg_sCodErrOk
                            mof_MsgError(wp_sNomTbl,
                                         wp_sDatCmp,
                                         wp_sCodErr)
                            mof_ActivarOK(Me)
                            mof_habTsbCrear()
                            Plo_IniciaFrm()
                            txtsCodTer.Focus()
                        End If
                    End If
                Else
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = txtnNroDoc.Text
                    wp_sCodErr = "10-319"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodTer.Focus()
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
            wp_sCmdSel = "E"
            wg_sTipTbl = wl_sTipTbl
            wg_sNomTblL1 = "PEROP"
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
                        wl_bYesNo = clnPEROP.cnEliminar(wl_ePEROP.sCodDoc,
                                                        wl_ePEROP.nNroDoc,
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
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Try
            mof_LmpMsgError()
            wl_bEOF = False
            BD_Lst_ATPOP()
            BD_Var_eATPOP()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
    End Sub
    Private Sub cmdLstPEROP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstPEROP.Click
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "PEROP"
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_frmLst.wp_ePEROP = New moe_Estructuras.ePEROP
            wl_frmLst.vp_sCodDoc = vl_sCodDoc
            wl_frmLst.wp_sTxtFrm = "Consulta " + Me.Text
            wl_frmLst.ShowDialog()
            wl_ePEROP = wl_frmLst.wp_ePEROP
            wg_DTCon1 = New DataTable
            If wl_frmLst.wp_ePEROP.sCodDoc <> "" Then
                wl_ePEROP = wl_frmLst.wp_ePEROP
                cboAPLND1.SelectedValue = wl_ePEROP.sCodDoc
                txtnNroDoc.Text = wl_ePEROP.nNroDoc
                cmdBuscar_Click(Nothing,
                                Nothing)


            End If
        Catch ex As Exception
            MsgBox("Error : cmdLstPEROP_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "070 DGV"
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wl_ePLROP1 = New moe_Estructuras.ePLROP1
        wl_sNomTblL1 = "PLROP1"
        wl_ePLROP1.nIdPEROP = vl_nId
        Try
            '  wl_eGLMOV1.sCodItm = txtnNroDoc.Text
            For wl_nRow = 0 To wl_CtrlDgv.RowCount - 1
                If wl_CtrlDgv.Rows(wl_nRow).Cells("sCodOpe").Value Is Nothing Then
                    Exit For
                End If

                BD_ePLROP1_Var(wl_nRow)

                wp_sCmdSel = wl_sCmdAnt
                wl_ePLROP1.nId = wl_CtrlDgv.Rows(wl_nRow).Cells("nId").Value
                wl_ePLROP1.nIdPEROP = vl_nId
                If wl_ePLROP1.nId <> 0 Then
                    wp_sCmdSel = "A"
                Else
                    wp_sCmdSel = "C"
                End If
                If wl_CtrlDgv.Rows(wl_nRow).Cells("sCodDocBas").Value <> Nothing Then


                    If wl_CtrlDgv.Rows(wl_nRow).Visible = True Then
                        clnPEROP.cnCrearActPLROP1(wl_ePLROP1,
                                                 wp_bEOF2,
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
                        '  clnPERCI.cnCrearActPLRCI(wl_ePLROP1,
                        '                           wp_bEOF2,
                        '                           wp_sCmdSel)



                    Else
                        If wp_sCmdSel = "A" Then
                            wl_ePLROP1.sCodDoc = wl_CtrlDgv.Rows(wl_nRow).Cells("sCodDoc").Value
                            wl_ePLROP1.nNroDoc = wl_CtrlDgv.Rows(wl_nRow).Cells("nNroDoc").Value
                            wl_bYesNo = clnPEROP.cnEliminar(wl_ePLROP1.sCodDoc,
                                                            wl_ePLROP1.nNroDoc,
                                                            wp_bEOF2)
                        End If
                    End If
                Else
                    If wl_CtrlDgv.Rows(wl_nRow).Visible = True Then
                        clnPEROP.cnCrearActPLROP1(wl_ePLROP1,
                                                 wp_bEOF2,
                                                 wp_sCmdSel)
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdiRowPLROP1()
        'Fec_Ult_Act : 2014.09.15
        Try
            ' If wl_eGEMOV.sEstDoc > "1" Then
            'Exit Sub
            'End If


            wl_nCntRow = wl_CtrlDgv.RowCount - 1
            If wl_nCntRow > -1 Then
                wl_nCol = wl_CtrlDgv.Columns("sCodItm").Index
                If wl_nNroDgv = 1 Then
                    If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomAlt").Value = "" Then
                        Exit Sub
                    End If
                Else
                    If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodOpe").Value = "" Then
                        Exit Sub
                    End If
                End If
            End If


            With wl_CtrlDgv
                wl_nCntRow = .RowCount
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentRow.Cells("sCodDoc").Value = wl_ePEROP.sCodDoc
                .CurrentRow.Cells("nNroDoc").Value = wl_ePEROP.nNroDoc
                .CurrentRow.Cells("sCodSer").Value = cboAPLND1.Text
                .CurrentRow.Cells("sTipMov").Value = vl_sTipMov
                .CurrentRow.Cells("sClsDoc").Value = wl_ePEROP.sClsDoc
                ' .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString

                .CurrentRow.HeaderCell.Value = (wl_CtrlDgv.CurrentRow.Index + 1).ToString
            End With

            'wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            'wl_nCntRow = wl_CtrlDgv.Rows.Count
            'wl_CtrlDgv.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            'wl_CtrlDgv.Rows(wl_nRow).Cells(2).Value = txtnNroDoc.Text

            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_nColIniGrl


        Catch ex As Exception
            MsgBox("Error : dgv_AdiRowPLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wg_DTL1 = New DataTable
        wl_ePLROP1 = New moe_Estructuras.ePLROP1
        ReDim wl_aePLROP1(0)

        wg_sNomTblL1 = "PLROP1"

        wr_bEOFL1 = True
        '  wl_eGEMOV.nNroDoc = txtnNroDoc.Text

        Try
            wg_DTL1 = clnPEROP.cndtConsultarPLROP1(wg_sNomTblL1,
                                                   wl_ePEROP.sCodDoc,
                                                   wl_ePEROP.nNroDoc,
                                                   wr_bEOFL1)

            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    ReDim wl_aePLROP1(wg_DTL1.Rows.Count)
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRowPLROP1()
                        moo_DGV_DTePLROP1(wl_CtrlDgv,
                                           wg_DTL1,
                                           wl_nRow)


                        moo_ePLROP1_DGV(wl_ePLROP1,
                                        wl_CtrlDgv,
                                        wl_nRow)
                        wl_aePLROP1(wl_nRow) = wl_ePLROP1
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
            wl_CtrlDgv.Rows.Clear()
            moo_DGVMov1_DTePLODP1(wl_CtrlDgv,
                                  wg_DTCon1)

            wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nRowDgv
                    .Rows(wl_nRow).Cells("nId").Value = 0
                    .Rows(wl_nRow).Cells("nPorCms").Value = 0
                    .Rows(wl_nRow).Cells("sCodDoc").Value = vl_sCodDoc
                    .Rows(wl_nRow).Cells("nNroDoc").Value = vl_nNroDoc
                Next
            End With
            ' wl_nColAnt = wl_CtrlDgv.CurrentRow.Cells("nCanItm").ColumnIndex
            ' dgv_TotLin()
            dgv_SumLin()
            dgv_TotDoc()
            '        wl_CtrlDgv.CurrentCell = dgv1.Rows(wl_nRowDgv).Cells(wl_nColIniGrl)
            cmdCrear.Focus()
        Catch ex As Exception
            MsgBox("Error: dgv_LstADgv")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_wp_aePLROP1_Dgv()
        Try
            Dim wl_nRow As Integer
            Dim wl_nCntRow As Integer
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            wl_nCntRow = UBound(wl_aePLROP1)
            ReDim wl_aePLROP1(wl_nCntRow)
            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If

            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nCntRow - 1
                    dgv_AdiRowPLROP1()
                    wl_ePLROP1 = wl_aePLROP1(wl_nRow)

                    wl_aePLROP1(wl_nRow).sCodDoc = vl_sCodDoc
                    wl_aePLROP1(wl_nRow).nNroDoc = txtnNroDoc.Text
                    wl_aePLROP1(wl_nRow).sTipMov = vl_sTipMov
                    wl_aePLROP1(wl_nRow).sCodDocBas = wl_aePLROP1(0).sCodDoc
                    wl_aePLROP1(wl_nRow).sCodSerBas = wl_aePLROP1(0).sCodSer
                    wl_aePLROP1(wl_nRow).nNroDocBas = wl_aePLROP1(0).nNroDoc
                    wl_aePLROP1(wl_nRow).nLinBas = wl_aePLROP1(wl_nRow).nId
                    wl_aePLROP1(wl_nRow).nId = 0
                    wl_aePLROP1(wl_nRow).sClsDoc = vl_sClsDoc

                    moo_DGV_ePLROP1(wl_CtrlDgv,
                                    wl_ePLROP1,
                                    wl_nRow)
                Next
            End With
        Catch ex As Exception
            MsgBox("Error en: dgv_wp_aePLROP1ADgv")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function dgv1_VdaRow(ByRef wl_bVdaRow) As Boolean
        Try
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
                wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
                wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then
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
        Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
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
                wg_eAPDGV = wl_aeAPDGV(wp_nC)

                With wg_eAPDGV
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
            vl_nTotTieOpe = 0
            vl_nTotDoc = 0
            wl_nCntRow = wl_CtrlDgv.Rows.Count

            ' wl_ePLROP1 = New moe_Estructuras.ePLROP1

            '           For wl_i = 0 To wl_nCntRow - 1
            ' wl_nColAnt = wl_CtrlDgv.CurrentRow.Cells("nCanItm").ColumnIndex
            ' wl_nRowKU = wl_i
            ' dgv_TotLin()
            ' '    moo_eGLMOV1_DGVGLMOV1(wl_ePLROP1,
            '                          wl_CtrlDgv,
            '                          wl_i)
            '    mof_fGLMOV1SumLin(wl_eGLMOV1.nVlrBas,
            '                      wl_eGLMOV1.nVlrDtoLin,
            '                      wl_eGLMOV1.nVlrIvaLin,
            '                      wl_eGLMOV1.nTotLin,
            '                      vl_nTotBas,
            '                      vl_nTotDto,
            '                      vl_nTotIvaCom,
            '                      vl_nTotIvaVta,
            '                     vl_nTotDoc,
            '                     wl_eGLMOV1.sClsDoc)

            'Next
            '            moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
            '                                   wl_CtrlDgv,
            '                                 wl_nRowKU)
            ' dgv_TotDoc()

        Catch ex As Exception
            MsgBox("Error: dgv_SumLin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotDoc()
        Try
            wl_nCntRow = dgv1.Rows.Count
            vl_nTotHHCns = 0
            vl_nTotMMCns = 0
            vl_nTotTieCns = 0
            For wl_i = 0 To wl_nCntRow - 1
                vl_nTotHHCns = vl_nTotHHCns + dgv1.Rows(wl_i).Cells("nHHCns").Value
                vl_nTotMMCns = vl_nTotMMCns + dgv1.Rows(wl_i).Cells("nMMCns").Value
                vl_nTotTieCns = vl_nTotTieCns + dgv1.Rows(wl_i).Cells("nTieCns").Value
            Next
            If vl_nTotMMCns > 60 Then
                vl_nTotHHCns = vl_nTotHHCns + Int(vl_nTotMMCns / 60)
                vl_nTotMMCns = (vl_nTotMMCns / 60 - Int(vl_nTotMMCns / 60)) * 60
            End If
            txtnTotTieCns.Text = FormatNumber(vl_nTotTieCns, 2)
            txtnTotHHCns.Text = FormatNumber(vl_nTotHHCns, 0)
            txtnTotMMCns.Text = FormatNumber(vl_nTotMMCns, 0)
        Catch ex As Exception
            MsgBox("Error: dgv_TotDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotLinPLROP1()
        Try

            'tipo de registro tiempo
            ' 1 HHII HHFF
            ' 2 HHCns
            ' 3 TotTie
            vl_sTipRegTie = wg_eACPAG.sTipRegTie

            wl_bVda = True
            If wl_aeAPDGV(wl_nColAnt).sNomCmp = "nCanItm" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreUni" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nHHIniOpe" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nMMIniOpe" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nHHFinOPe" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nMMFin" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nHHCns" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nMMCns" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nTieCns" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nTotLin" Then
                wl_ePLROP1 = New moe_Estructuras.ePLROP1
                moo_ePLROP1_DGV(wl_ePLROP1,
                                wl_CtrlDgv,
                                wl_nRowKU)
                If wl_ePLROP1.nHHIniOpe < 0 Or wl_ePLROP1.nHHIniOpe > 23 Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells("nHHIniOpe")
                    wl_bVda = False
                    Exit Sub
                End If
                If wl_ePLROP1.nMMIniOpe < 0 Or wl_ePLROP1.nMMIniOpe > 59 Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells("nMMIniOpe")
                    wl_bVda = False
                    Exit Sub
                End If
                If wl_ePLROP1.nHHFinOpe < 0 Or wl_ePLROP1.nHHFinOpe > 23 Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells("nHHFinOpe")
                    wl_bVda = False
                    Exit Sub
                End If
                If wl_ePLROP1.nMMFinOpe < 0 Or wl_ePLROP1.nMMFinOpe > 59 Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells("nMMFinOpe")
                    wl_bVda = False
                    Exit Sub
                End If
                If wl_ePLROP1.nMMFinOpe <> 0 Then
                    If wl_ePLROP1.nHHIniOpe > wl_ePLROP1.nHHFinOpe Then
                        MsgBox("Hora Inicial Mayor que Hora Final")
                        wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells("nHHFinOpe")
                        wl_bVda = False
                    End If
                End If

                mof_fPLROP1TotLin(wl_ePLROP1.nCanItm,
                                  wl_ePLROP1.nPreUni,
                                  wl_ePLROP1.nHHIniOpe,
                                  wl_ePLROP1.nMMIniOpe,
                                  wl_ePLROP1.nHHFinOpe,
                                  wl_ePLROP1.nMMFinOpe,
                                  wl_ePLROP1.nHHCns,
                                  wl_ePLROP1.nMMCns,
                                  wl_ePLROP1.nTieCns,
                                  wl_ePLROP1.nTotLin,
                                  vl_sTipRegTie)
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nCanItm").Value = wl_ePLROP1.nCanItm
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreUni").Value = wl_ePLROP1.nPreUni
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nHHIniOpe").Value = wl_ePLROP1.nHHIniOpe
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nMMIniOpe").Value = wl_ePLROP1.nMMIniOpe
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nHHFinOpe").Value = wl_ePLROP1.nHHFinOpe
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nMMFinOPe").Value = wl_ePLROP1.nMMFinOpe
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nHHCns").Value = wl_ePLROP1.nHHCns
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nMMCns").Value = wl_ePLROP1.nMMCns
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nTieCns").Value = wl_ePLROP1.nTieCns
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nTotLin").Value = wl_ePLROP1.nTotLin
            End If
        Catch ex As Exception
            MsgBox("Error: dgv_TotLinPLROP1")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "072 DGV Controladores de Eventos "
    'dgv1
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv1_CellLeave")
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
                Exit Sub
            End If
            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodDocBas" Or wl_aeAPDGV(wl_nCol).sNomCmp = "nNroDocBas" Then
                wl_nColNom = wl_nCol + 2
                wl_nColSig = wl_nCol
                wl_bEOF = True
                If dgv1.CurrentRow.Cells("sCodDocBas").Value <> "" Then
                    wl_bEOF = BD_BuscarPEODP()
                End If

                If wl_bEOF Then
                    BD_CargarPEODP(wl_nCol,
                                   wl_nColNom,
                                   wl_nColSig)
                End If

            End If



            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodOpe" Then
                wl_nColNom = wl_nCol + 2
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarATOPE()

                If wl_bEOF Then
                    wl_bEOF = True
                    If dgv1.CurrentRow.Cells("sCodDocBas").Value = Nothing Then
                        BD_CargarATOPE(wl_nCol,
                                     wl_nColNom,
                                     wl_nColSig)
                    Else
                        BD_CargarPLODP2(wl_nCol,
                                            wl_nColNom,
                                            wl_nColSig)
                    End If
                Else
                    wl_bEOF = True
                    If dgv1.CurrentRow.Cells("sCodDocBas").Value = Nothing Then
                        BD_CargarATOPE(wl_nCol,
                                     wl_nColNom,
                                     wl_nColSig)
                    Else
                        BD_CargarPLODP2(wl_nCol,
                                            wl_nColNom,
                                            wl_nColSig)
                    End If
                End If
                If BD_BuscarATCTR() = False Then
                    dgv1.CurrentRow.Cells("sCodCtr").Value = wl_eATCTR.nPreUni
                Else
                    dgv1.CurrentRow.Cells("sCodCtr").Value = 0
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

            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y

            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wp_nColNom = wl_nColAnt
            wp_nColVlr = wl_nColAnt
            mov_dgv_VdaPLROP1(wl_nCol,
                              wl_nColAnt,
                              wl_nColSig,
                              wl_nRow,
                              wl_nRowAnt,
                              wl_nRowSig,
                              wl_CtrlDgv,
                              wl_aeAPDGV,
                              wl_bVda)

            dgv_TotLinPLROP1()
            If wl_bVda = False Then
                Exit Sub
            End If
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
                                        wl_CtrlDgv,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRowPLROP1()
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
        Catch ex As Exception
            MsgBox("Error: dgv1_KeyUp")
            MsgBox(ex.Message)
        End Try

        'Try
        ' mof_LmpMsgError()
        ' wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
        ' wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
        ' wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
        ' wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
        ' wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
        ' wl_nCntRow = wl_CtrlDgv.Rows.Count
        ' wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
        ' wl_nColAnt = wl_nColKD
        ' wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
        ' wl_nCntCol = wl_CtrlDgv.ColumnCount
        ' If e.KeyCode = Keys.Tab Then
        ' wl_bAva = True
        ' End If
        ' If e.Shift AndAlso e.KeyCode = Keys.Tab Then
        ' wl_bRet = True
        ' End If
        ' wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
        ' wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
        ' wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
        ' wl_nColAnt = wl_nColKD
        ' wp_nColNom = wl_nColAnt
        ' wp_nColVlr = wl_nColAnt
        ' wl_bVda = True
        ' mov_dgv_VdaPLROP1(wl_nCol,
        '                   wl_nColAnt,
        '                   wl_nColSig,
        '                   wl_nRow,
        '                   wl_nRowAnt,
        '                   wl_nRowSig,
        '                   wl_CtrlDgv,
        '                   wl_aeAPDGV,
        '                   wl_bVda)
        ' If wl_bVda = False Then
        ' wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
        ' Exit Sub
        ' End If
        ' wl_bVda = True
        ' dgv_TotLinPLROP1()
        ' If wl_bVda = False Then
        ' Exit Sub
        ' End If
        ' dgv_SumLin()
        ' dgv_TotDoc()
        '
        '        If wl_bAva Then
        ' dgv_AvanzaCol()
        ' End If
        ' If wl_bRet = True Then
        ' dgv_RetroCol()
        ' End If
        ' Catch ex As Exception
        ' MsgBox("Error: dgv1_KeyUp")
        ' MsgBox(ex.Message)
        ' End Try
    End Sub
    Private Sub dgv1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.Leave
        Try
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

#Region "080 Plo"
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActCmpAct()
        Try
            txtsCodTer.Enabled = True
            txtsNomTer.Enabled = False
            cmdListar.Enabled = True
            cboABROP.Enabled = True
            cboAPLND1.Enabled = True
            txtnNroDoc.Enabled = True
            dtpFecCtb.Enabled = True
            dtpFecDoc.Enabled = True
            txtsCmn.Enabled = True
            cmdLstPEROP.Enabled = False
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_CerrarDoc()
        Dim wl_sNomCmp As String
        Dim wl_sTipCmp As String
        Dim wl_sDatCmp As String


        Try
            wp_nBoxMsg = 4
            wp_sDesMsg = wg_sDesMsgAdi
            wp_sTitMsg = wg_sTitMsgAdi
            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)

            If wp_nResMsg = 6 Then
                vl_sEstDoc = "C"
                cboABESD.SelectedValue = vl_sEstDoc
                wl_sNomCmp = "sEstDoc"
                wl_sTipCmp = "N"
                wl_sDatCmp = cboABESD.SelectedValue
                wr_bEOF = False
                wr_bEOF = clnActTab.cndtActDosLlaUnCmp(wl_sNomTblE1,
                                                       wg_sNomCmpE11,
                                                       wg_sDatCmpE11,
                                                       wg_sTipCmpE11,
                                                       wg_sNomCmpE12,
                                                       wg_sDatCmpE12,
                                                       wg_sTipCmpE12,
                                                       wl_sNomCmp,
                                                       wl_sDatCmp,
                                                       wl_sTipCmp,
                                                       wr_bEOF)
                Plo_RefrescaDoc()
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_CerrarDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_frmLstdet()
        Try
            Dim wl_frmLstDet As New frmGQLstDet
            Dim wg_DTL1 As New DataTable
            wl_frmLstDet.wp_ePEODP = wl_ePEODP
            wl_frmLstDet.wp_sCodDoc = wl_ePEODP.sCodDoc
            wl_frmLstDet.wp_nNroDoc = wl_ePEODP.nNroDoc
            wl_frmLstDet.wp_sCodSer = wl_ePEODP.sCodSer
            wl_frmLstDet.wp_sTblCon = "PLODP1"
            ReDim wg_aePLODP1(0)
            wl_frmLstDet.ShowDialog()
            dgv_LstADgv()
        Catch ex As Exception
            MsgBox("Error : Plo_frmLstdet")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_Frm_Var()
        Try

            txtnNroDoc.Text = vl_nNroDoc
            cboAPLND1.SelectedValue = vl_sCodSer
            cboABESD.SelectedValue = vl_sEstDoc
            dtpFecCtb.Text = vl_dFecCtb
            dtpFecDoc.Text = vl_dFecDoc
            txtsCodTer.Text = vl_sCodTer
            txtsNomTer.Text = vl_sNomTer
            txtsCmn.Text = vl_sCmn
            txtnTotHHCns.Text = vl_nTotHHCns
            txtnTotMMCns.Text = vl_nTotMMCns
            txtnTotTieCns.Text = vl_nTotTieCns
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Frm_Var")
        End Try
    End Sub
    Private Sub Plo_InactivarCmpBus()
        Try
            txtnNroDoc.Enabled = False

        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpBus")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_Var_Frm()
        Try
            vl_nNroDoc = CInt(txtnNroDoc.Text)
            vl_sCodSer = cboAPLND1.SelectedValue
            vl_sEstDoc = "C"
            vl_dFecCtb = dtpFecCtb.Value.ToShortDateString
            vl_dFecDoc = dtpFecDoc.Value.ToShortDateString
            vl_dFecVto = dtpFecCtb.Value.ToShortDateString

            vl_dFecSys = Today
            vl_sCodTer = txtsCodTer.Text
            vl_sNomTer = txtsNomTer.Text
            If txtnTotTieCns.Text = "" Then
                txtnTotTieCns.Text = "0"
            End If
            vl_nTotTieOpe = CDbl(txtnTotTieCns.Text)
            vl_sCodCte = ""
            vl_nNroCte = 0
            vl_sCmn = txtsCmn.Text
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0
            vl_sNitTer = ""
            vl_sCodUsr = vg_sCodUsr
            vl_bPrp01 = False
            vl_bPrp02 = False
            vl_bPrp03 = False
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Var_frm")
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
            txtnTotHHCns.Enabled = False
            txtnTotMMCns.Enabled = False
            txtnTotTieCns.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarDoc()
        Try
            wl_sNomFrm = "frmPEROP"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "ROP"
            vl_sClsDoc = "DP"
            vl_sTipMov = "S"
            wl_bSwsCbo = False

            Plo_LeeAPEND()
            vl_nNroDoc = CInt(txtnNroDoc.Text)
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarEst()
        Try
            wl_ePEROP = New moe_Estructuras.ePEROP
            wl_ePLROP1 = New moe_Estructuras.ePLROP1
            ReDim wl_aePLROP1(0)

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
            wl_ePEROP.sCodDoc = vl_sCodDoc
            wl_ePEROP.nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)
            wl_ePEROP.sClsDoc = vl_sClsDoc
            wl_ePEROP.sCodUsr = vg_sCodUsr
            wl_ePEROP.dFecSys = Date.Today


            'cboABESD.SelectedValue = vl_sEstDoc
            vl_sNitTer = ""
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



            dtpFecCtb.Value = Date.Today
            dtpFecCtb.Format = DateTimePickerFormat.Custom
            dtpFecCtb.CustomFormat = "yyyy-MM-dd"
            dtpFecDoc.Value = Date.Today
            dtpFecDoc.Format = DateTimePickerFormat.Custom
            dtpFecDoc.CustomFormat = "yyyy-MM-dd"
            mof_ActivarCrear(Me)


            vl_sEstOdp = "2" ' 
            'vl_sCodDoc
            vl_nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)
            vl_sCodSer = ""
            '   cboABROP.SelectedValue = "S"
            vl_sTipMov = cboABROP.SelectedValue
            'vl_sEstDoc
            vl_dFecCtb = dtpFecCtb.Value.ToShortDateString
            vl_dFecDoc = dtpFecDoc.Value.ToShortDateString
            vl_dFecVto = dtpFecCtb.Value.ToShortDateString
            vl_dFecSys = Date.Today
            vl_sCodTer = ""
            vl_sNomTer = ""
            vl_sDocRef = ""
            vl_nTotHHCns = 0
            vl_nTotMMCns = 0
            vl_nTotTieCns = 0
            vl_nTotDoc = 0
            vl_sCodCte = ""
            vl_nNroCte = 0
            'vl_sClsDoc = ""
            vl_sCmn = ""
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0
            vl_sNitTer = ""
            vl_sTipDoc = ""
            vl_sCodUsr = vg_sCodUsr
            vl_bPrp01 = False
            vl_bPrp02 = False
            vl_bPrp02 = False
            vl_nTotHHOpe = 0
            vl_nTotMMOpe = 0
            vl_nTotTieOpe = 0
            vl_nTotHHAlz = 0
            vl_nTotMMAlz = 0
            vl_nTotTieAlz = 0
            vl_nTotHHCaf = 0
            vl_nTotMMCaf = 0
            vl_nTotTieCaf = 0


            ' Variables numéricas
            wl_nNroDgv = 0
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
            Plo_SelDGV(wl_nNroDgv)
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_RefrescaDoc()
        Try
            wp_sCmdSel = "B"
            'wl_sNomFrm = "frmPESDM"
            'wl_sCodDgv = "dgv1"
            'vl_sCodDoc = "SDM"
            'vl_sTipMov = "S"
            'vl_sClsDoc = "DI"
            wl_bSwsCbo = False
            cmdBuscar_Click(Nothing,
                            Nothing)

        Catch ex As Exception
            MsgBox("Error : Plo_RefrescaDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_TxtsCodPerKeyUp()
        Try
            wl_ePEROP.sCodTer = txtsCodTer.Text
            vl_sCodTer = txtsCodTer.Text
            BD_BuscarATPOP()
            If wr_bEOFE2 Then
                wp_sNomTbl = "ATPOP"
                wp_sDatCmp = txtsCodTer.Text
                wp_sCodErr = "10-122"
                mof_MsgError(wp_sNomTbl,
                            wp_sDatCmp,
                            wp_sCodErr)
                txtsCodTer.Focus()
            Else
                txtsNomTer.Text = wl_eATPOP.sNomTer
                dgv1.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_TxtsCodPerKeyUp")
            MsgBox(ex.Message)
        End Try
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
            '      Plo_ActivarCrear() '080
        Catch ex As Exception
            MsgBox("Error : Plo_SelDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_TxtIni()
        Try
            txtsCodTer.Focus()
            txtsCodTer.Select()
        Catch ex As Exception
            MsgBox("Error : Plo_SelDGV")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
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
            dgv_AdiRowPLROP1()
            cboAPLND1.Enabled = True
            txtsCodTer.Enabled = True
            txtnNroDoc.Enabled = True
            cboABESD.Enabled = False
            txtnNroDoc.Focus()
            cmdLstPEROP.Enabled = True
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
            Plo_ActCmpAct()
            Cbo_CargarAPLND1()

            wl_CtrlDgv.Enabled = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            dgv_AdiRowPLROP1()
            txtnNroDoc.Enabled = False
            cboABESD.Enabled = False
            txtsCodTer.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarCrear")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_CrgModCtb()
        Try
            '   wl_eGEMOV.sTipDoc = "IT"
            '   wl_eGEMOV.sCodDoc = "SDM"
            '   wl_eGEMOV.sTipMov = " "
            '   wl_eGEMOV.sClsDoc = "DI"
            '   wl_eGEMOV.nNroDoc = txtnNroDoc.Text
            '   wl_eGEMOV.dFecCtb = mtbFecCtb.Text
            '   wl_eGEMOV.dFecDoc = mtbFecDoc.Text
            '   wl_eGEMOV.dFecVto = mtbFecVto.Text
            '   wl_eGEMOV.dFecSys = Date.Today

        Catch ex As Exception
            MsgBox("Error : Plo_CrgModCtb")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Plo_InactCmpAct()
        Try

            txtsCodTer.Enabled = False
            txtsNomTer.Enabled = False
            cmdListar.Enabled = False
            cboABROP.Enabled = False
            cboAPLND1.Enabled = False
            txtnNroDoc.Enabled = False
            dtpFecCtb.Enabled = False
            dtpFecDoc.Enabled = False
            txtsCmn.Enabled = False

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            For wl_i = 0 To dgv1.Rows.Count - 1
                dgv1.Rows(wl_i).ReadOnly = True
                dgv1.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactCmpCrear()
        Try
            txtnTotHHCns.Enabled = False
            txtnTotMMCns.Enabled = False
            txtnTotTieCns.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpCrear")
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
        wg_sDatCmpE21 = wl_ePEROP.sCodDoc
        wg_sTipCmpE21 = "S"
        wg_sCmpOrdE21 = ""
        wg_sTipOrdE21 = "S"
        wg_sNomCmpE22 = "sCodSer"
        wg_sDatCmpE22 = wl_ePEROP.sCodSer
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
            vl_nNroSig = CType(txtnNroDoc.Text, Double) + 1
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
    Private Sub txtnNroDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnNroDoc.DoubleClick
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "PEROP"
            wl_frmLst.wp_sTxtFrm = "Consulta consecutivo ordenes de registro de operaciones"

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
    Private Sub txtsCodTer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCodTer.KeyUp
        Try
            If e.KeyData = Keys.Enter Then

                If cmdCrear.Visible = True Then
                    Plo_TxtsCodPerKeyUp()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : txtsCodTer_KeyUp")
            MsgBox(ex.Message)
        End Try

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
    Private Sub txtsCodTer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodTer.LostFocus
        Try
            If cmdCrear.Visible = True Then
                If txtsCodTer.Text <> "" Then
                    Plo_TxtsCodPerKeyUp()
                Else
                    txtsCodTer.Focus()

                End If

            End If
        Catch ex As Exception
            MsgBox("Error : txtsCodTer_LostFocus")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#End Region


#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            ReDim wl_aePEROP(0)
            ReDim wl_aePLROP1(0)

            dgv_DetADgv()

            wl_aePEROP(0) = wl_ePEROP
            wg_aePLROP1 = wl_aePLROP1
            wl_sNroALetras = mof_NroALetras(CType(wl_ePEROP.nTotDoc, String),
                                            wg_sCodMon)
            mof_ActivarOK(Me)
            Dim wl_frmRPT As New rptPRROP01
            wl_frmRPT.wp_aePEROP = wl_aePEROP
            wl_frmRPT.wp_aePLROP1 = wl_aePLROP1

            wl_frmRPT.wp_sNroALetras = wl_sNroALetras
            wl_frmRPT.Show()


        Catch ex As Exception
            MsgBox("Error :  Rpt_PrmRpt")
            MsgBox(ex.Message)
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
                If wl_cvTxt.Name = "txtsCodTer" Then
                    wl_ePEROP.sCodTer = txtsCodTer.Text
                    vl_sCodTer = txtsCodTer.Text
                    BD_BuscarATPOP()
                    If wr_bEOFE2 Then
                        wp_sNomTbl = "ATPOP"
                        wp_sDatCmp = txtsCodTer.Text
                        wp_sCodErr = "10-122"
                        mof_MsgError(wp_sNomTbl,
                                    wp_sDatCmp,
                                    wp_sCodErr)
                        txtsCodTer.Focus()
                    Else
                        BD_Var_ATPOP()
                    End If
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
            dgv_AdiRowPLROP1()
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

#End Region

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim tabctl As TabControl = DirectCast(sender, TabControl)
        Dim g As Graphics = e.Graphics
        Dim font As Font = tabctl.Font
        Dim brush As New SolidBrush(Color.Black)
        Dim tabTextArea As RectangleF = RectangleF.op_Implicit(tabctl.GetTabRect(e.Index))
        If tabctl.SelectedIndex = e.Index Then
            font = New Font(font, FontStyle.Bold)
            brush = New SolidBrush(Color.Gray)
        End If
        g.DrawString(tabctl.TabPages(e.Index).Text, font, brush, tabTextArea)

    End Sub



   
   
End Class