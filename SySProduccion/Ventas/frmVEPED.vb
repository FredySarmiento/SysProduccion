Public Class frmVEPED
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-10
#End Region
#Region "001 Inicia. wp - vp Definición del variables públicas"
    Public Property wg_aeGEMOV As Array
    Public Property wg_aeGLMOV1 As Array
    Public Property wg_aeATVEN As Array
    Public Property wg_aeTEDMT As Array
    Public Property wg_aeTLDMT4 As Array
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
    Dim wl_sClaPPl1 As String
    Dim wl_sClaPPl2 As String
    Dim wl_sCod As String
    Dim wl_sCodDgv As String
    Dim wl_sDoc As String
    Dim wl_sNom As String
    Dim wl_sNomFrm As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNomTblL1 As String
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
    Dim vl_nNroDoc As Long
    Dim vl_nTotBas As Double
    Dim vl_nTotDoc As Double
    Dim vl_nTotDto As Double
    Dim vl_nTotGtoAdi As Double
    Dim vl_nTotIvaCom As Double
    Dim vl_nTotIvaVta As Double
    Dim vl_nVlrRdd As Double
    Dim vl_sClsDoc As String
    Dim vl_sCodDoc As String
    Dim vl_sCodSer As String
    Dim vl_sEstDoc As String
    Dim vl_sNitTer As String
    Dim vl_sTipDoc As String
    Dim vl_sTipMov As String
    Dim vl_sCodItm As String
#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas
    Dim vl_nColFin As Integer
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
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim wl_CtrlDgv As New DataGridView
#End Region
#Region "015 Estructuras"
    Dim vl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim vl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim wl_eGLMOV1 As moe_Estructuras.eGLMOV1
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
    Dim vl_eABESD As moe_Estructuras.eABESD
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATALM As moe_Estructuras.eATALM
    Dim wl_eATIVA As moe_Estructuras.eATIVA
    Dim wl_eATVEN As moe_Estructuras.eATVEN
    Dim wl_eFECTT As moe_Estructuras.eFECTT
    Dim wl_eFLCTT1 As moe_Estructuras.eFLCTT1
    Dim wl_eGEMOV As moe_Estructuras.eGEMOV
    Dim vl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_eTEDMT As moe_Estructuras.eTEDMT
    Dim vl_eTLDMT1 As moe_Estructuras.eTLDMT1
    Dim wl_eTLDMT4 As moe_Estructuras.eTLDMT4
#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region
#Region "020 frm Eventos - Principal"

    Private Sub frmVEPED_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error :  frmVEPED_Disposed")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmVEPED_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Plo_CrgModCtb() '081
            If wg_sFrmOri = "frmVEPED" Then
                BD_Var_wp_aeGEMOV()
                BD_eGEMOV_Var()
                dgv_wp_aeGLMOV1ADgv()
            End If
            If wg_sFrmOri = "frmVEFAC" Then
                BD_Var_wp_aeGEMOV()
                BD_eGEMOV_Var()
                dgv_wp_aeGLMOV1ADgv()
            End If
        Catch ex As Exception
            MsgBox("Error :  frmVEPED_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region


#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarABTID()
            Cbo_CargarAPLND1()
            Cbo_CargarATVEN()
            Cbo_CargarABESD()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarAPLND1()
        Try
            wg_sTblLst1 = "APLND1"
            wr_bEOFLst1 = wr_bEOFLst1
            wg_DTLst1 = clnConTbl.cndtCargarNro(wg_sTblLst1,
                                                wl_eGEMOV.sCodDoc,
                                                wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboAPLND1.DataSource = wg_DTLst1
                cboAPLND1.ValueMember = wg_DTLst1.Columns("sCodSer").Caption.ToString
                cboAPLND1.DisplayMember = wg_DTLst1.Columns("sCodSer").Caption.ToString
                cboAPLND1.SelectedValue = wg_DTE2.Rows(0).Item("sCodSer")
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarAPLND1")
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


                        If cboAPLND1.SelectedValue.ToString = "Sc" Then
                            Plo_HabRdb()
                        Else
                            Plo_InHabRdb()
                        End If
                        Plo_IniciarVar()
                        wl_CtrlDgv.Rows.Clear()
                        dgv_AdiRow()

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
    Private Sub Cbo_CargarABESD()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABESD"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABESD.DataSource = wg_DTLst1
                cboABESD.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
                cboABESD.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABESD")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarABTID()
        Try
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABTID"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABTID.DataSource = wg_DTLst1
                cboABTID.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
                cboABTID.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABTID")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboABTID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboABTID.SelectedIndexChanged
        Try
            If wl_CtrlDgv.Enabled = True Then
                vl_sTipDoc = ""
                wl_nNroDgv = 1
                Select Case cboABTID.SelectedIndex
                    Case 0
                        wl_nNroDgv = 1
                        vl_sTipDoc = cboABTID.SelectedValue.ToString
                    Case 1
                        wl_nNroDgv = 2
                        vl_sTipDoc = cboABTID.SelectedValue.ToString
                    Case Else
                End Select

                Plo_SelDGV(wl_nNroDgv)
                wl_CtrlDgv.Enabled = True
                wl_CtrlDgv.Rows.Clear()
                mof_ConfigurarDGV(wl_CtrlDgv,
                                  wl_nTotCol)
                dgv_ConfiguraCol()
                dgv_AdiRow()
                txtsCodTer.Focus()
                '  dgv_APDGV()
            End If
        Catch ex As Exception
            MsgBox("Error :  cboABTID_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarATVEN()
        Try
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATVEN"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATVEN.DataSource = wg_DTLst1
                cboATVEN.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboATVEN.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATVEN")
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
            BD_eGEMOV_Var()
            BD_BuscarTEDMT()
            If wr_bEOFE2 Then
                MsgBox("Código del Tercero es obligatorio")
                txtsCodTer.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            If wl_CtrlDgv.Rows.Count Then
                If wl_nNroDgv = 1 Then

                    If wl_CtrlDgv.Rows(0).Cells("sCodItm").Value = "" Then
                        MsgBox("Documento no tiene detalle")
                        txtsCodTer.Focus()
                        Return wl_bYesNo
                    End If
                Else
                    If wl_CtrlDgv.Rows(0).Cells("sNomAlt").Value = "" Then
                        MsgBox("Documento no tiene detalle")
                        txtsCodTer.Focus()
                        Return wl_bYesNo
                    End If
                End If
                'txtsCodTer.Focus()
                '  Return wl_bYesNo
            End If
            For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                wl_ni1 = wl_nI + 1
                If wl_nNroDgv = 1 Then
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value = "" Then
                        Exit For
                    End If
                Else
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sNomAlt").Value = "" Then
                        Exit For
                    End If
                End If

                If wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm").Value = 0 Then
                    MsgBox("Línea Nro. " & wl_ni1.ToString & " tiene Cantidad en 0")
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm")
                    Return wl_bYesNo
                End If
                If wl_CtrlDgv.Rows(wl_nI).Cells("nPreUni").Value = 0 Then
                    MsgBox("Línea Nro. " & wl_ni1.ToString & " tiene Precio Unitario en 0")
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nPreUni")
                    Return wl_bYesNo
                End If

            Next


            wg_bVdaE1 = True
            If Not mov_VdaTxt(wg_bVdaE1,
                              txtsCodTer) Then
                txtsCodTer.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            If Not mov_VdaTxt(wg_bVdaE1,
                              txtnNroDoc) Then
                txtnNroDoc.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            wl_bYesNo = clnIEINV.cnCrearActualizar(wl_sNomTblE1,
                                                   wl_eGEMOV,
                                                   wr_bEOFE1,
                                                   wp_sCmdSel)

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
                wl_sNomTblE1 = "VEPED"
                wl_sNomTblL1 = "VLPED1"
                wg_sNomCmpE11 = "nNroDoc"
                wg_sTipCmpE11 = "N"
                wg_sTitCmpE11 = "Número documento"
                wg_sDatCmpE11 = CLng(txtnNroDoc.Text)
                wg_sClaPpl = txtnNroDoc.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "E2" Then
                wl_sNomTblE1 = "VEPED"
                wl_sNomTblL1 = "VLPED1"
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
                    wg_sDatTSB = wl_eGEMOV.nID
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
    Private Sub BD_eGEMOV_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eGEMOV = New moe_Estructuras.eGEMOV
            moo_eGEMOV_DT(wl_eGEMOV,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox("Error :  BD_eGEMOV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_eGEMOV_Var()
        Try
            wl_eGEMOV = New moe_Estructuras.eGEMOV
            With wl_eGEMOV
                .nID = 0 '0
                .sCodDoc = vl_sCodDoc '1
                .nNroDoc = txtnNroDoc.Text '2
                .sEstDoc = cboABESD.SelectedValue '3
                .sTipMov = vl_sTipMov '4
                .dFecCtb = mtbFecCtb.Text '5
                .dFecDoc = mtbFecDoc.Text '7
                .dFecVto = mtbFecVto.Text '6
                .dFecSys = Today '8
                .sCodTer = txtsCodTer.Text '9
                .sNomTer = txtsNomTer.Text '10
                .nPorDto = 0 '11
                .sAlmOri = "" '12
                .sDocRef = txtsDocRef.Text
                .nTotBas = vl_nTotBas '14
                .nTotDto = vl_nTotDto '15
                .nTotGtoAdi = vl_nTotGtoAdi '16
                .nTotIvaCom = vl_nTotIvaCom '17
                .nTotIvaVta = vl_nTotIvaVta '18
                .nVlrRdd = vl_nVlrRdd '19
                .nTotDoc = vl_nTotDoc '20
                .sCodDocBas = "" '21
                .nNroDocBas = 0 '22
                .sCndPag = txtsCndPag.Text '23
                .sClsDoc = vl_sClsDoc '24
                .sTipDoc = vl_sTipDoc '25
                .sCodVen = "" '26
                .sCodSer = cboAPLND1.Text '27
                .sDirTer = txtsDirTer.Text '28
                .sCiuter = txtsCiuTer.Text '29
                .sDepTer = txtsDepTer.Text '30
                .sPaiTer = txtsPaiTer.Text '31
                .sCmn = txtsCmn.Text '32
                .sCodCteCtb = txtsCodCteCtb.Text '33
                If String.IsNullOrEmpty(txtnNroCteCtb.Text) Then
                    .nNroCteCtb = 0
                Else
                    .nNroCteCtb = CLng(txtnNroCteCtb.Text) '34
                End If
                .nIdFECCT = 0 '35
                .sNitTer = vl_sNitTer '36
                .sCodUsr = vg_sCodUsr '37
                .bPrp01 = rdbPrp01.Checked
                .bPrp02 = rdbPrp02.Checked
                .bPrp03 = rdbPrp03.Checked
                .sCodVen = cboATVEN.Text
            End With
        Catch ex As Exception
            MsgBox(ex.Message)

            MsgBox("Error en el SUB: BD_eGEMOV_Var")
        End Try
    End Sub
    Private Sub BD_eGLMOV1_Var(ByVal wl_nRow)
        Try
            wg_eGLMOV1 = New moe_Estructuras.eGLMOV1
            moo_eGLMOV1_DGVGLMOV1(wg_eGLMOV1,
                                  wl_CtrlDgv,
                                  wl_nRow)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Vl_Var")
        End Try
    End Sub
    Private Sub BD_eTEDMT_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wg_eTEDMT = New moe_Estructuras.eTEDMT
            moo_eTEDMT_DT(wg_eTEDMT,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Vl_Var")
        End Try
    End Sub
    Private Sub BD_Lst_TEDMT()
        Try
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
            txtsCodTer.Text = wg_sSelCon11
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Lst_TEDMT")
        End Try
    End Sub
    Private Sub BD_Var_eGEMOV()
        Dim vl_nNroDocAnt As Long
        Try

            With wl_eGEMOV
                vl_nNroDocAnt = .nNroDoc
                cboAPLND1.Text = .sCodSer
                wl_eGEMOV.nNroDoc = vl_nNroDocAnt
                txtnNroDoc.Text = .nNroDoc '2
                vl_sCodDoc = .sCodDoc '2
                cboABESD.SelectedValue = .sEstDoc
                mtbFecCtb.Text = .dFecCtb  '5
                mtbFecDoc.Text = .dFecDoc '7
                mtbFecVto.Text = .dFecVto  '6
                'mtbFecSys.Text = .dFecSys  '8
                txtsCodTer.Text = .sCodTer   '9
                txtsNomTer.Text = .sNomTer '10
                txtsDocRef.Text = .sDocRef
                txtsCndPag.Text = .sCndPag
                cboABTID.SelectedValue = .sTipDoc
                txtsDirTer.Text = .sDirTer
                txtsCiuTer.Text = .sCiuter
                txtsDepTer.Text = .sDepTer
                txtsCmn.Text = .sCmn
                txtsCodCteCtb.Text = .sCodCteCtb '31
                txtnNroCteCtb.Text = .nNroCteCtb '32
                vl_sNitTer = .sNitTer


                rdbPrp01.Checked = .bPrp01
                rdbPrp02.Checked = .bPrp02
                rdbPrp03.Checked = .bPrp03
                cboATVEN.SelectedValue = .sCodVen
                txtnTotBas.Text = FormatCurrency(.nTotBas)
                txtnTotDoc.Text = FormatCurrency(.nTotDoc)
                txtnTotDto.Text = FormatCurrency(.nTotDto)
                txtnTotGtoAdi.Text = FormatCurrency(.nTotGtoAdi)
                txtnTotIvaCom.Text = FormatCurrency(.nTotIvaCom)
                txtnVlrRdd.Text = FormatCurrency(.nVlrRdd)
                If .sEstDoc > "A" Then
                    mof_InhabCtrl(Me)
                End If
                If .sEstDoc = "C" Then
                    ' Plo_HabCtrl()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eGEMOV")
        End Try


    End Sub
    Private Sub BD_Var_eTEDMT()
        Try
            With wg_eTEDMT
                '  vl_nId = .nID
                txtsNomTer.Text = .sNomTer
                txtsCndPag.Text = .sCndPag
                vl_sNitTer = .sNitTer
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eGEMOV")
        End Try
    End Sub
    Private Sub BD_Var_eTLDMT1()
        Try
            With wg_eTLDMT1
                txtsDirTer.Text = .sDirTer
                txtsCiuTer.Text = .sCiuTer
                txtsDepTer.Text = .sDepTer
                txtsPaiTer.Text = .sPaiTer
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eGEMOV")
        End Try

    End Sub
    Private Sub BD_Var_TEDMT_TLDMT1()
        Try
            wl_eGEMOV.sCodTer = txtsCodTer.Text
            wg_eTEDMT = New moe_Estructuras.eTEDMT
            wl_bEOF = mof_fConTEDMT(wl_eGEMOV.sCodTer,
                                    wg_eTEDMT)
            BD_Var_eTEDMT()
            wg_eTLDMT1 = New moe_Estructuras.eTLDMT1
            wl_bEOF = mof_fConTLDMT1(wl_eGEMOV.sCodTer,
                                     wg_eTLDMT1)
            BD_Var_eTLDMT1()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_TEDMT_TLDMT1")
        End Try
    End Sub
    Private Sub BD_Var_wp_aeGEMOV()
        Try
            With wg_aeGEMOV(0)
                '  vl_sCodDoc = .sCodDoc '2
                'txtnNroDoc.Text = .nNroDoc '2
                'cboABESD.SelectedValue = .sEstDoc
                'mtbFecCtb.Text = .dFecCtb  '5
                'mtbFecDoc.Text = .dFecDoc '7
                'mtbFecVto.Text = .dFecVto  '6
                txtsCodTer.Text = .sCodTer   '9
                txtsNomTer.Text = .sNomTer '10
                txtsDocRef.Text = .sDocRef
                txtsCndPag.Text = .sCndPag
                'cboAPLND1.Text = .sCodSer
                txtsDirTer.Text = .sDirTer
                txtsCiuTer.Text = .sCiuter
                txtsDepTer.Text = .sDepTer
                txtsCmn.Text = .sCmn
                txtsCodCteCtb.Text = .sCodCteCtb '31
                txtnNroCteCtb.Text = .nNroCteCtb '32
                vl_sNitTer = .sNitTer
                cboABTID.SelectedValue = .sTipDoc
                rdbPrp01.Checked = .bPrp01
                rdbPrp02.Checked = .bPrp02
                rdbPrp03.Checked = .bPrp03
                cboATVEN.SelectedValue = .sCodVen
                txtnTotBas.Text = FormatCurrency(.nTotBas)
                txtnTotDoc.Text = FormatCurrency(.nTotDoc)
                txtnTotDto.Text = FormatCurrency(.nTotDto)
                txtnTotGtoAdi.Text = FormatCurrency(.nTotGtoAdi)
                txtnTotIvaCom.Text = FormatCurrency(.nTotIvaCom)
                txtnVlrRdd.Text = FormatCurrency(.nVlrRdd)
                vl_nTotBas = .nTotBas
                vl_nTotDto = .nTotDto
                vl_nTotGtoAdi = .nTotGtoAdi
                vl_nTotIvaCom = .nTotIvaCom
                vl_nTotIvaVta = .nTotIvaVta
                vl_nVlrRdd = .nVlrRdd
                vl_nTotDoc = .nTotDoc
                ' mof_InhabCtrl(Me)

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eGEMOV")
        End Try

    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_TipDoc()
        Try
            If wl_eGEMOV.sTipDoc = "SE" Then
                wl_nNroDgv = 2
            Else
                wl_nNroDgv = 1
            End If
            Plo_SelDGV(wl_nNroDgv)
            wl_CtrlDgv.Enabled = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            dgv_AdiRow()
            txtsCodTer.Focus()
        Catch ex As Exception
            MsgBox("Error :  BD_TipDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_tsbPASU()
        Try
            BD_eGEMOV_DT(wg_DTE1)
            BD_Var_eGEMOV()
            BD_TipDoc()
            wl_CtrlDgv.Enabled = True
            dgv_DetADgv()
            mof_ActivarOK(Me)
            BD_DatPrmTipTbl(wg_sTipTbl)
            dgv1.Enabled = False
            dgv2.Enabled = False
            cmdCpa.Enabled = True
            lstCpA.Visible = False
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
    Private Function BD_BuscarATIVA() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATIVA = New moe_Estructuras.eATIVA
            wr_bEOFE2 = mof_fConATIVA(wl_eATIVA.sCodIVA,
                                      wl_eATIVA)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATIVA")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATVEN() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATVEN = New moe_Estructuras.eATVEN
            wr_bEOFE2 = mof_fConATVEN(wl_eGEMOV.sCodVen,
                                      wl_eATVEN)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATVEN")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarILDMI2() As Boolean
        Try
            wr_bEOFE2 = True
            wg_sTipTbl = wl_sTipTbl
            mof_LmpMsgError()
            If txtsCodTer.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)

                wg_sNomTblE2 = "ILDMI2"
                wg_sNomCmpE11 = "sCodTer"
                wg_sDatCmpE11 = txtsCodTer.Text
                wg_sTipCmpE11 = "S"
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
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
            MsgBox("Error en el SUB: BD_BuscarILDMI2")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarTEDMT() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            wr_bEOFE2 = mof_fConTEDMT(wl_eGEMOV.sCodTer,
                                      wl_eTEDMT)
            If wr_bEOFE2 = False Then
                mof_LmpMsgError()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarTEDMT")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarTLDMT4() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eTLDMT4 = New moe_Estructuras.eTLDMT4
            wr_bEOFE2 = mof_fConTLDMT4(wl_eGEMOV.sCodTer,
                                      wl_eTLDMT4)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarTLDMT4")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "043 BD Cargar"
    Private Sub BD_CargarATALM(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_eATALM = New moe_Estructuras.eATALM
            wl_frmLst.wp_sTxtFrm = "Almacenes"

            wg_sTblCon1 = "ATALM"
            wg_sCmpCon11 = "sCodAlm"
            wg_sCmpCon12 = "sNomAlm"
            wg_sTitCon11 = "Código almacén"
            wg_sTitCon12 = "Nombre almacén"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon2 = True
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            moo_DGVGLMOV1_eATALM(Me.dgv1,
                                 wg_eATALM,
                                 wl_nRowAct)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellDes)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATALM")
        End Try
    End Sub
    Private Sub BD_CargarATIVA(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_eATIVA = New moe_Estructuras.eATIVA
            wl_frmLst.wp_sTxtFrm = "Impuestos"

            wg_sTblCon1 = "ATIVA"
            wg_sCmpCon11 = "sCodIVA"
            wg_sCmpCon12 = "sNomIVA"
            wg_sTitCon11 = "Código IVA"
            wg_sTitCon12 = "Nombre IVA"
            wg_sDatCon11 = vl_sClsDoc
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon2 = True
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            moo_DgvGLMOV1_eATIVA(Me.wl_CtrlDgv,
                                 wg_eATIVA,
                                 wl_nRowAct)
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells(wl_CellSig)
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells(wl_CellDes)
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells(wl_CellSig)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATALM")
        End Try
    End Sub
    Private Sub BD_CargarIEDMI(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_eIELDMI1 = New moe_Estructuras.eIELDMI1
            wl_frmLst.wp_sTxtFrm = "Items de inventarios"

            wg_sTblCon1 = "IEDMI"
            wg_sCmpCon11 = "sCodItm"
            wg_sCmpCon12 = "sNomItm"
            wg_sTitCon11 = "Código ítem"
            wg_sTitCon12 = "Nombre ítem"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.wp_sFrmOri = "frmCEODC"
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            wl_CtrlDgv.CurrentCell.Value = wg_sSelCon11
            '   moo_DGVGLMOV1_eIELDMI1(Me.dgv1,
            '                         wg_eIELDMI1,
            '                        wl_nRowAct)

            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellDes)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarIEDMI")
        End Try
    End Sub
    Private Sub BD_CargarILDMI2(ByVal wl_CellCod As Integer,
                                ByVal wl_CellDes As Integer,
                                ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_eILDMI2 = New moe_Estructuras.eILDMI2
            wg_eIELDMI1 = New moe_Estructuras.eIELDMI1

            wg_sTblCon1 = "ILDMI2"
            wg_sCmpCon11 = "sCodTer"
            wg_sCmpCon12 = "sNomTer"
            wg_sDatCon11 = txtsCodTer.Text
            wg_sTitCon11 = "Código tercero"
            wg_sTitCon12 = "Nombre tercero"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wg_sSelCon15 = ""
            wr_bEOFCon1 = True
            wl_frmLst.wp_sTxtFrm = "Consulta de ítems por proveedor"
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            wl_CtrlDgv.CurrentCell.Value = wg_sSelCon12
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellDes)
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
            'dgv1.CurrentCell.Style.ForeColor = Color.Black

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarILDMI2")
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
                vl_nNroDoc = CInt(txtnNroDoc.Text)
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                wl_eGEMOV.sCodDoc = vl_sCodDoc
                wl_eGEMOV.sCodSer = vl_sCodSer
                wl_eGEMOV.nNroDoc = vl_nNroDoc
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

                    BD_eGEMOV_DT(wg_DTE1)
                    BD_Var_eGEMOV()
                    mof_fLmpCtrl(Me.dgv1)
                    dgv_DetADgv()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    cmdCpa.Enabled = True
                    lstCpA.Visible = False
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
                            mof_InhabCtrl(Me)
                            Plo_IniciaFrm()
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
            wg_sNomTblL1 = wl_sNomTblL1
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
                                                        wl_eGEMOV.sCodDoc,
                                                        wl_eGEMOV.nNroDoc,
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
    Private Sub cmdCpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCpa.Click

        lstCpA.Visible = True
    End Sub
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Try
            mof_LmpMsgError()
            wl_bEOF = False
            BD_Lst_TEDMT()
            BD_Var_TEDMT_TLDMT1()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
    End Sub
    Private Sub cmdLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdLinea.Click
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ILDMI2"
            wg_sCmpCon11 = "sCodItm"
            wg_sCmpCon12 = "sCodter"
            wg_sTitCon11 = "Código ítem"
            wg_sTitCon12 = "Código Tercero"
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLinea_Click")
        End Try

    End Sub
    Private Sub cmdMaestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdMaestro.Click
        Try
            Dim frmMaestro As New frmTEDMT
            frmMaestro.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLinea_Click")
        End Try

    End Sub
    Private Sub lstCpa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCpA.SelectedIndexChanged
        Try
            Dim vl_aeGEMOV(0) As moe_Estructuras.eGEMOV
            ' Dim wl_aeGLMOV1(0) As moe_Estructuras.eGEMOV
            lstCpA.Visible = False

            If lstCpA.SelectedIndex = 0 Then
                If wl_eGEMOV.sTipDoc <> "IT" Then
                    MsgBox("Este documento no maneja inventarios")
                    cmdCpa.Focus()
                Else
                    Dim wl_frmGEMOV As New frmCEENI
                    Dim wl_sFrmDtn As New frmCEENI
                    wl_sFrmDtn.wg_sFrmOri = Me.Name
                    vl_aeGEMOV(0) = wl_eGEMOV
                    wl_sFrmDtn.wg_aeGEMOV = vl_aeGEMOV
                    wl_sFrmDtn.wg_aeGLMOV1 = wl_aeGLMOV1
                    wl_sFrmDtn.Show()
                End If

            End If
            If lstCpA.SelectedIndex = 1 Then
                Dim wl_frmGEMOV As New frmCEFAP
                Dim wl_sFrmDtn As New frmCEFAP
                wl_sFrmDtn.wg_sFrmOri = Me.Name
                vl_aeGEMOV(0) = wl_eGEMOV
                wl_sFrmDtn.wg_aeGEMOV = vl_aeGEMOV
                wl_sFrmDtn.wg_aeGLMOV1 = wl_aeGLMOV1
                wl_sFrmDtn.Show()
            End If
        Catch ex As Exception
            MsgBox("Error :  lstCpa_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "061 Eventos_Click Lista Controladores de Eventos (Remitente_evento)"
#End Region

#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wg_eGLMOV1 = New moe_Estructuras.eGLMOV1
        wg_sNomTblL1 = wl_sNomTblL1
        Try
            '  wl_eGLMOV1.sCodItm = txtnNroDoc.Text
            For wl_nRow = 0 To wl_CtrlDgv.RowCount - 1
                If wl_eGEMOV.sTipDoc = "IT" Then
                    If wl_CtrlDgv.Rows(wl_nRow).Cells("sCodItm").Value Is Nothing Then
                        Exit For
                    End If
                End If
                If wl_eGEMOV.sTipDoc = "SE" Then
                    If wl_CtrlDgv.Rows(wl_nRow).Cells("sNomAlt").Value Is Nothing Then
                        Exit For
                    End If
                End If
                BD_eGLMOV1_Var(wl_nRow)

                wp_sCmdSel = wl_sCmdAnt
                wl_eGLMOV1.nID = wl_CtrlDgv.Rows(wl_nRow).Cells("nId").Value
                If wl_eGLMOV1.nID <> 0 Then
                    wp_sCmdSel = "A"
                Else
                    wp_sCmdSel = "C"
                End If

                If wl_CtrlDgv.Rows(wl_nRow).Visible = True Then
                    clnIEINV.cnCrearActILMOV1(wg_sNomTblL1,
                                              wg_eGLMOV1,
                                              wp_sCmdSel,
                                              wp_bEOF2)
                Else
                    If wp_sCmdSel = "A" Then
                        wl_eGLMOV1.sCodDoc = wl_CtrlDgv.Rows(wl_nRow).Cells(1).Value
                        wl_eGLMOV1.nNroDoc = wl_CtrlDgv.Rows(wl_nRow).Cells(2).Value
                        wl_bYesNo = clnIEINV.cnEliminarILMOV1(wg_sNomTblL1,
                                                              wl_eGLMOV1.nID,
                                                              wl_eGLMOV1.sCodDoc,
                                                              wl_eGLMOV1.nNroDoc,
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
        'Fec_Ult_Act : 2014.09.15
        Try
            ' If wl_eGEMOV.sEstDoc > "1" Then
            'Exit Sub
            'End If


            wl_nCntRow = wl_CtrlDgv.RowCount - 1
            If wl_nCntRow > -1 Then
                wl_nCol = wl_CtrlDgv.Columns("sCodItm").Index
                If wl_nNroDgv = 2 Then
                    If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomAlt").Value = "" Then
                        Exit Sub
                    End If
                Else
                    If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodItm").Value = "" Then
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
                .CurrentRow.Cells("sCodDoc").Value = wl_eGEMOV.sCodDoc
                .CurrentRow.Cells("nNroDoc").Value = wl_eGEMOV.nNroDoc
                .CurrentRow.Cells("sTipMov").Value = wl_eGEMOV.sTipMov
                .CurrentRow.Cells("sCodSer").Value = wl_eGEMOV.sCodSer
                .CurrentRow.Cells("sClsDoc").Value = wl_eGEMOV.sClsDoc
                ' .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString
                .CurrentRow.HeaderCell.Value = (wl_CtrlDgv.CurrentRow.Index + 1).ToString
            End With
            wl_nTab = 0
            ' wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            '  wl_nCntRow = dgv1.Rows.Count
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_CtrlDgv.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            wl_CtrlDgv.Rows(wl_nRow).Cells(2).Value = txtnNroDoc.Text
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wg_DTL1 = New DataTable
        wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
        ReDim wl_aeGLMOV1(0)

        wg_sNomTblL1 = wl_sNomTblL1


        wr_bEOFL1 = True
        '  wl_eGEMOV.nNroDoc = txtnNroDoc.Text
        vl_sCodItm = ""
        Try
            If wl_eGEMOV.sTipDoc = "IT" Then
                wg_DTL1 = clnIEINV.cndtConsultarILMOV1(wg_sNomTblL1,
                                                       wl_eGEMOV.sCodDoc,
                                                       wl_eGEMOV.nNroDoc,
                                                       vl_sCodItm,
                                                       wr_bEOFL1)
            Else
                wg_DTL1 = clnIEINV.cndtConSolILMOV1(wg_sNomTblL1,
                                                    wl_eGEMOV.sCodDoc,
                                                    wl_eGEMOV.nNroDoc,
                                                    wr_bEOFL1)
            End If



            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    ReDim wl_aeGLMOV1(wg_DTL1.Rows.Count)
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow()
                        moo_DGV_DTeILMOV1(wl_CtrlDgv,
                                           wg_DTL1,
                                           wl_nRow)


                        moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                              wl_CtrlDgv,
                                              wl_nRow)
                        wl_aeGLMOV1(wl_nRow) = wl_eGLMOV1
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
        Dim wl_nCol As Integer
        Dim wl_nRowDgv As Integer
        wl_nRow = 0
        Try
            wl_nRowDgv = 0
            If wl_CtrlDgv.Rows.Count > 1 Then
                wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            End If
            moo_DGVMov1_aePLODP1(wl_CtrlDgv,
                             wg_aePLODP1)
            With wl_CtrlDgv
                For wl_nRow = 0 To .Rows.Count - 2
                    .Rows(wl_nRowDgv).Cells(1).Value = wl_eGEMOV.sCodDoc
                    .Rows(wl_nRowDgv).Cells(2).Value = wl_eGEMOV.nNroDoc
                    .Rows(wl_nRowDgv).Cells(3).Value = wl_eGEMOV.sTipMov
                    For wl_nCol = 0 To wg_aeAPDGV.Length - 1
                        If wg_aeAPDGV(wl_nCol).bColTot = True Then
                            If wg_aeAPDGV(wl_nCol).sDesOpe = "Ope_11" Then
                                mof_fOpe_16(wl_CtrlDgv,
                                            wl_nRowDgv)
                            End If
                        End If
                    Next
                    wl_nRowDgv = wl_nRowDgv + 1
                Next

            End With

            wl_CtrlDgv.CurrentCell = dgv1.Rows(wl_nRowDgv).Cells(wl_nColIniGrl)
            With wl_CtrlDgv
                .Rows(wl_nRowDgv).Cells(1).Value = wl_eGEMOV.sCodDoc
                .Rows(wl_nRowDgv).Cells(2).Value = wl_eGEMOV.nNroDoc
                .Rows(wl_nRowDgv).Cells(3).Value = wl_eGEMOV.sTipMov
            End With

            cmdCrear.Focus()

        Catch ex As Exception
            MsgBox("Error: dgv_LstADgv")
        End Try
    End Sub
    Private Sub dgv_wp_aeGLMOV1ADgv()
        Try
            Dim wl_nRow As Integer
            Dim wl_nCntRow As Integer
            wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
            wl_nCntRow = UBound(wl_aeGLMOV1)
            ReDim wl_aeGLMOV1(wl_nCntRow)
            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If

            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nCntRow - 1
                    dgv_AdiRow()
                    wl_eGLMOV1 = wl_aeGLMOV1(wl_nRow)

                    wl_aeGLMOV1(wl_nRow).sCodDoc = vl_sCodDoc
                    wl_aeGLMOV1(wl_nRow).nNroDoc = txtnNroDoc.Text
                    wl_aeGLMOV1(wl_nRow).sCodDocBas = wg_aeGEMOV(0).sCodDoc
                    wl_aeGLMOV1(wl_nRow).nNroDocBas = wg_aeGEMOV(0).nNroDoc
                    wl_aeGLMOV1(wl_nRow).nLinBas = wl_aeGLMOV1(wl_nRow).nID
                    wl_aeGLMOV1(wl_nRow).nID = 0
                    wl_aeGLMOV1(wl_nRow).sClsDoc = vl_sClsDoc
                    wl_aeGLMOV1(wl_nRow).sTipMov = vl_sTipMov

                    moo_DGV_eGLMOV1(wl_CtrlDgv,
                                     wl_eGLMOV1,
                                     wl_nRow)
                Next
            End With
        Catch ex As Exception
            MsgBox("Error en: dgv_wp_aeGLMOV1ADgv")
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
            vl_nColFin = 0
            wg_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nColIni = wg_nColIni
            vl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin
            wl_nTotCol = UBound(wg_aeAPDGV) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APDGV")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_AvanzaCol()
        Dim wl_i As Integer
        Try
            wl_i = wl_nCol
            For wl_i = wl_nCol To wl_nTotCol - 1
                If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = False Then
                    Continue For
                End If
                If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).ReadOnly = True Then
                    Continue For
                End If
                If wl_i = wl_nTotCol - 1 Then
                    If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = True Then
                        Continue For
                    End If
                End If

                Exit For
            Next
            wl_nCol = wl_i
            ' If wl_nCol > wg_nColFin Then
            If wl_nCol > vl_nColFin Then
                wl_bVdaRow = True
                wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nRow < wl_nCntRow - 1 Then
                        wl_nRow = wl_nRow + 1
                    Else
                        dgv_AdiRow()
                        wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                    End If
                End If
                wl_nCol = wl_nColIniGrl
            End If
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)

        Catch ex As Exception
            MsgBox("Error :  dgv_AvanzaCol")
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
                wg_eAPDGV = wg_aeAPDGV(wp_nC)
               
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
                For wl_nRow = 0 To wl_CtrlDgv.Rows.Count - 1
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
    Private Sub dgv_RetroCol()
        Dim wl_i As Integer
        Try
            wl_i = wl_nColKD - 1
            wl_nCol = wl_i

            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = False Then
                For wl_i = wl_nCol To wl_nColIniGrl Step -1
                    '  wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i)
                    If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).Visible = True Then
                        Exit For
                    End If
                Next
                wl_nCol = wl_i
            End If
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i)
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                For wl_i = wl_nCol To wl_nColIniGrl Step -1
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i)
                    If wl_CtrlDgv.CurrentCell.ReadOnly = False Then
                        Exit For
                    End If
                Next
                wl_nCol = wl_i
            End If

            If wl_nCol < wl_nColIniGrl Then
                wl_bVdaRow = True
                wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nRow > 0 Then
                        wl_nRow = wl_nRow - 1
                    Else
                        wl_nRow = wl_nCntRow
                    End If
                End If
                wl_nCol = vl_nColFin
            End If
            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)

        Catch ex As Exception
            MsgBox("Error :  dgv_RetrocedeCol")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_SumLin()
        'fec_ult_act = 2014.04.25
        Dim wl_nCntRow As Integer

        Try
            vl_nTotBas = 0
            vl_nTotDto = 0
            vl_nTotIvaCom = 0
            vl_nTotIvaVta = 0
            vl_nTotDoc = 0
            wl_nCntRow = wl_CtrlDgv.Rows.Count

            wl_eGLMOV1 = New moe_Estructuras.eGLMOV1

            For wl_i = 0 To wl_nCntRow - 1


                moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                      wl_CtrlDgv,
                                      wl_i)
                mof_fGLMOV1SumLin(wl_eGLMOV1.nVlrBas,
                                  wl_eGLMOV1.nVlrDtoLin,
                                  wl_eGLMOV1.nVlrIvaLin,
                                  wl_eGLMOV1.nTotLin,
                                  vl_nTotBas,
                                  vl_nTotDto,
                                  vl_nTotIvaCom,
                                  vl_nTotIvaVta,
                                  vl_nTotDoc,
                                  wl_eGLMOV1.sClsDoc)

            Next
            moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                 wl_CtrlDgv,
                                 wl_nRowKU)
            dgv_TotDoc()

        Catch ex As Exception
            MsgBox("Error: dgv_SumLin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotLin()
        Try
            'nCanItm, 9
            'nPreUni 11
            'nVlrBas 12
            'nPorDto 13
            'nVlrDto 14
            'nPreDto 15
            'nVlrDtoLin 16
            'nPorIva 18
            'nVlrIva 19
            'nVlrIvaLin 20
            'nPreBru 21
            'nTotLin 22
            If wg_aeAPDGV(wl_nColAnt).sNomCmp = "nCanItm" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nPreUni" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrBas" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nPorDto" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrDto" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nPreDto" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrDtoLin" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nPorIva" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrIva" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrIvaLin" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nPreBru" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nTasCamUsd" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nPreUniUsd" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrBasUsd" Or
                wg_aeAPDGV(wl_nColAnt).sNomCmp = "nTotLin" Then


                wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                      wl_CtrlDgv,
                                      wl_nRowKU)
                mof_fGLMOV1TotLin(wl_eGLMOV1.nCanItm,
                                  wl_eGLMOV1.nPreUni,
                                  wl_eGLMOV1.nVlrBas,
                                  wl_eGLMOV1.nPorDto,
                                  wl_eGLMOV1.nVlrDto,
                                  wl_eGLMOV1.nPreDto,
                                  wl_eGLMOV1.nVlrDtoLin,
                                  wl_eGLMOV1.nPorIva,
                                  wl_eGLMOV1.nVlrIva,
                                  wl_eGLMOV1.nVlrIvaLin,
                                  wl_eGLMOV1.nPreBru,
                                  wl_eGLMOV1.nTasCamUsd,
                                  wl_eGLMOV1.nPreUniUsd,
                                  wl_eGLMOV1.nVlrBasUsd,
                                  wl_eGLMOV1.nTotLin)
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreUni").Value = wl_eGLMOV1.nPreUni
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nVlrBas").Value = wl_eGLMOV1.nVlrBas
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nVlrDto").Value = wl_eGLMOV1.nVlrDto
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreDto").Value = wl_eGLMOV1.nPreDto
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nVlrDtoLin").Value = wl_eGLMOV1.nVlrDtoLin
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nVlrIva").Value = wl_eGLMOV1.nVlrIva
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nVlrIvaLin").Value = wl_eGLMOV1.nVlrIvaLin
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreBru").Value = wl_eGLMOV1.nPreBru
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nTotLin").Value = wl_eGLMOV1.nTotLin
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nPreUniUsd").Value = wl_eGLMOV1.nPreUniUsd
                wl_CtrlDgv.Rows(wl_nRowKU).Cells("nVlrBasUsd").Value = wl_eGLMOV1.nVlrBasUsd
            End If


        Catch ex As Exception
            MsgBox("Error: dgv_TotLin")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotDoc()
        Try

            If String.IsNullOrWhiteSpace(txtnTotGtoAdi.Text) Then
                txtnTotGtoAdi.Text = "0"
            End If
            vl_nTotGtoAdi = CType(txtnTotGtoAdi.Text, Double)


            If String.IsNullOrWhiteSpace(txtnVlrRdd.Text) Then
                txtnVlrRdd.Text = "0"
            End If
            vl_nVlrRdd = CType(txtnVlrRdd.Text, Double)


            mof_fGEMOVTotDoc(vl_nTotBas,
                             wl_eGEMOV.nPorDto,
                             vl_nTotDto,
                             vl_nTotGtoAdi,
                             vl_nTotIvaCom,
                             vl_nTotIvaVta,
                             vl_nVlrRdd,
                             vl_nTotDoc)

            txtnTotBas.Text = FormatCurrency(vl_nTotBas)
            txtnTotDoc.Text = FormatCurrency(vl_nTotDoc)
            txtnTotDto.Text = FormatCurrency(vl_nTotDto)
            txtnTotGtoAdi.Text = FormatCurrency(vl_nTotGtoAdi)
            txtnTotIvaCom.Text = FormatCurrency(vl_nTotIvaCom)
            txtnVlrRdd.Text = FormatCurrency(vl_nVlrRdd)


        Catch ex As Exception
            MsgBox("Error: dgv1_TotDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "072 DGV Controladores de Eventos "
    'dgv1
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        '  Stop
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            If wl_nColKU = wl_nTotCol - 1 Or wl_nColKU = vl_nColFin Then
                '    dgv1_KeyUp(Nothing,
                '              Nothing)
                ' Stop

            End If
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
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                'dgv1_Valida()
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error : dgv1_CellMouseClick")
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


            If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodItm" Then
                wl_nColNom = wl_nCol + 2
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarILDMI2()
                If wl_bEOF Then
                    BD_CargarIEDMI(wl_nCol,
                                  wl_nColNom,
                                  wl_nColSig)
                Else
                    BD_CargarILDMI2(wl_nCol,
                                    wl_nColNom,
                                    wl_nColSig)

                End If

            End If
            If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodAlm" Then
                wl_nColNom = wl_nCol + 1
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarATALM()
                If wl_bEOF Then
                    BD_CargarATALM(wl_nCol,
                                  wl_nColNom,
                                  wl_nColSig)
                End If

            End If
            If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodIva" Then
                wl_nColNom = wl_nCol + 1
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarATIVA()
                If wl_bEOF Then
                    BD_CargarATIVA(wl_nCol,
                                  wl_nColNom,
                                  wl_nColSig)
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
        Catch
            MsgBox("Error : dgv1_CellValueChanged")
        End Try
    End Sub
    Private Sub dgv1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyDown
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


    End Sub
    Private Sub dgv1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv1.KeyPress
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
    End Sub
    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False

        wl_sCod = ""
        wl_sNom = ""
        wl_nVlr = 0
        wl_sDoc = ""
        wl_sNomtbl = ""
        Try
            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nCntCol = wl_CtrlDgv.ColumnCount
            If e.KeyCode = Keys.Tab Then
                wl_bAva = True
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_bRet = True
            End If
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wp_nColNom = wl_nColAnt
            wp_nColVlr = wl_nColAnt
            mov_dgv_VdaGLMOV1(wl_nCol,
                           wl_nColAnt,
                           wl_nColSig,
                           wl_nRow,
                           wl_nRowAnt,
                           wl_nRowSig,
                           wl_CtrlDgv,
                           wg_aeAPDGV)
            dgv_TotLin()
            dgv_SumLin()
            dgv_TotDoc()

            If wl_bAva Then
                dgv_AvanzaCol()
            End If
            If wl_bRet = True Then
                dgv_RetroCol()
            End If
        Catch ex As Exception
            MsgBox("Error: dgv1_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    'dgv2
    Private Sub dgv2_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellLeave
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            If wl_nColKU = wl_nTotCol - 1 Or wl_nColKU = vl_nColFin Then
                ' dgv1_KeyUp(Nothing,
                '           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv2_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseDoubleClick
        If wl_CtrlDgv.Enabled = False Then
            Exit Sub
        End If
        wl_nCol = e.ColumnIndex
        wl_nRow = e.RowIndex
        Try
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If


            If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodItm" Then
                wl_nColNom = wl_nCol + 1
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarILDMI2()
                If wl_bEOF Then
                    BD_CargarIEDMI(wl_nCol,
                                  wl_nColNom,
                                  wl_nColSig)
                Else
                    BD_CargarILDMI2(wl_nCol,
                                    wl_nColNom,
                                    wl_nColSig)

                End If

            End If
            If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodAlm" Then
                wl_nColNom = wl_nCol + 1
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarATALM()
                If wl_bEOF Then
                    BD_CargarATALM(wl_nCol,
                                  wl_nColNom,
                                  wl_nColSig)
                End If

            End If
            If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodIva" Then
                wl_nColNom = wl_nCol + 1
                wl_nColSig = wl_nCol

                wl_bEOF = BD_BuscarATIVA()
                If wl_bEOF Then
                    BD_CargarATIVA(wl_nCol,
                                   wl_nColNom,
                                   wl_nColSig)
                End If

            End If

        Catch ex As Exception
            MsgBox("Error :  dgv1_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellValueChanged
        Try
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : dgv2_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv2.KeyDown
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
    End Sub
    Private Sub dgv2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv2.KeyPress
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
    End Sub
    Private Sub dgv2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv2.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        wl_sCod = ""
        wl_sNom = ""
        wl_nVlr = 0
        wl_sDoc = ""

        wl_sNomtbl = ""
        Try
            wl_nRowKU = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKU = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nRowSig = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count

            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nCntCol = wl_CtrlDgv.ColumnCount

            If e.KeyCode = Keys.Tab Then
                wl_bAva = True
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_bRet = True
            End If


            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColSig = wl_CtrlDgv.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wp_nColNom = wl_nColAnt
            wp_nColVlr = wl_nColAnt


            mov_dgv_VdaGLMOV1(wl_nCol,
                           wl_nColAnt,
                           wl_nColSig,
                           wl_nRow,
                           wl_nRowAnt,
                           wl_nRowSig,
                           wl_CtrlDgv,
                           wg_aeAPDGV)


            dgv_TotLin()
            dgv_SumLin()
            dgv_TotDoc()
            If wl_bAva Then
                dgv_AvanzaCol()
            End If
            If wl_bRet = True Then
                dgv_RetroCol()
            End If
        Catch ex As Exception
            MsgBox("Error: dgv2_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "073 DGV Procedimientos llamados por los Controladores de Eventos"
#End Region

#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub CerrarOrdenDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Plo_CerrarDoc()
        Catch ex As Exception
            MsgBox("Error :  CerrarOrdenDeCompraToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListaItemsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nColNom = wl_nColKD + 1
            wl_nColSig = wl_nColKD
            BD_CargarIEDMI(wl_nColKD,
                           wl_nColNom,
                           wl_nColSig)
        Catch ex As Exception
            MsgBox("Error :  ListaItemsToolStripMenuItem1_Click")
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
                vl_sEstDoc = "2"
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
            wg_sTblCon1 = "VEPED"
            wg_sCmpCon11 = "sCodDoc"
            wg_sCmpCon12 = "nNroDoc"
            wg_sTitCon11 = "Código Ped"
            wg_sTitCon12 = "Número Ped"
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
            lstCpA.Visible = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_HabRdb()
        Try
            rdbPrp01.Visible = True
            rdbPrp02.Visible = True
            rdbPrp03.Visible = True
            rdbPrp01.Enabled = True
            rdbPrp02.Enabled = True
            rdbPrp03.Enabled = True
        Catch ex As Exception
            MsgBox("Error : Plo_HabRdb")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabCtrl()
        Try
            lstCpA.Visible = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_InHabRdb()
        Try
            rdbPrp01.Visible = False
            rdbPrp02.Visible = False
            rdbPrp03.Visible = False
            rdbPrp01.Enabled = False
            rdbPrp02.Enabled = False
            rdbPrp03.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_InHabRdb")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarDoc()
        Try
            wl_sNomFrm = "frmVEPED"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "PED"
            vl_sTipMov = " "
            vl_sClsDoc = "DV"
            wl_bSwsCbo = False

            Plo_LeeAPEND()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarEst()
        Try
            wl_eGEMOV = New moe_Estructuras.eGEMOV
            wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
            ReDim wl_aeGLMOV1(0)

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
            txtnTotGtoAdi.Text = ""
            txtnVlrRdd.Text = ""
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarText")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            wl_eGEMOV.sCodDoc = vl_sCodDoc
            wl_eGEMOV.nNroDoc = IIf(txtnNroDoc.Text <> "", txtnNroDoc.Text, 0)
            wl_eGEMOV.sCodSer = vl_sCodSer
            wl_eGEMOV.sTipMov = vl_sTipMov
            wl_eGEMOV.sClsDoc = vl_sClsDoc
            wl_eGEMOV.sCodUsr = vg_sNomUsr
            wl_eGEMOV.dFecSys = Date.Today

            vl_sEstDoc = "C"
            cboABESD.SelectedValue = vl_sEstDoc
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
            wg_sTitMsgAdi = "Orden de compra"

            ' IEINV
            dtpFecCtb.Format = DateTimePickerFormat.Short
            dtpFecCtb.Value = Date.Today
            mof_ActivarCrear(Me)
            dtpFecCtb.Visible = False
            mtbFecCtb.Text = dtpFecCtb.Value
            mtbFecDoc.Text = Today
            mtbFecVto.Text = Today

            ' Variables numéricas
            wl_nNroDgv = 1
            Plo_InHabRdb()
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
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_RefrescaDoc()
        Try
            wp_sCmdSel = "B"
            '   wl_sNomFrm = "frmCEODC"
            '   wl_sCodDgv = "dgv1"
            '   vl_sCodDoc = "ODC"
            '   vl_sTipMov = " "
            '   vl_sClsDoc = "DC"
            wl_bSwsCbo = False
            cmdBuscar_Click(Nothing,
                            Nothing)

        Catch ex As Exception
            MsgBox("Error : Plo_CerrarDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_SelDGV(ByVal wl_nNroDgv As Integer)
        wl_CtrlDgv = New DataGridView
        Try
            If wl_nNroDgv = 1 Then
                dgv2.Visible = False
                dgv1.Visible = True
                wl_sCodDgv = "dgv1"
                wl_CtrlDgv = Me.dgv1

            End If
            If wl_nNroDgv = 2 Then
                dgv1.Visible = False
                dgv2.Visible = True
                wl_sCodDgv = "dgv2"
                wl_CtrlDgv = Me.dgv2
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
            cboABTID.SelectedIndex = 0

            wl_CtrlDgv.Enabled = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(Me.wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            dgv_AdiRow()
            cboAPLND1.Enabled = True
            txtsCodTer.Enabled = True
            txtnNroDoc.Enabled = True
            cboABESD.Enabled = False
            txtnNroDoc.Focus()
            cmdCpa.Enabled = False
            lstCpA.Visible = False
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
            cboABTID.SelectedIndex = 0
            Cbo_CargarAPLND1()

            wl_CtrlDgv.Enabled = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            dgv_AdiRow()
            txtnNroDoc.Enabled = False
            cboABESD.Enabled = False
            dgv1.Enabled = True
            dgv2.Enabled = True
            cmdCpa.Enabled = False
            lstCpA.Visible = False
            txtsCodTer.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarCrear")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_CrgModCtb()
        Try
            wl_eGEMOV.sTipDoc = "IT"
            wl_eGEMOV.sCodDoc = "PED"
            wl_eGEMOV.sTipMov = " "
            wl_eGEMOV.sClsDoc = "DV"
            wl_eGEMOV.nNroDoc = txtnNroDoc.Text
            wl_eGEMOV.dFecCtb = mtbFecCtb.Text
            wl_eGEMOV.dFecDoc = mtbFecDoc.Text
            wl_eGEMOV.dFecVto = mtbFecVto.Text
            wl_eGEMOV.dFecSys = Date.Today

        Catch ex As Exception
            MsgBox("Error : Plo_CrgModCtb")
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
        wg_sDatCmpE21 = wl_eGEMOV.sCodDoc
        wg_sTipCmpE21 = "S"
        wg_sCmpOrdE21 = ""
        wg_sTipOrdE21 = "S"
        wg_sNomCmpE22 = "sCodSer"
        wg_sDatCmpE22 = wl_eGEMOV.sCodSer
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
            wg_sDatCmpE21 = wl_eGEMOV.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_eGEMOV.sCodSer
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
            wg_sDatCmpE21 = wl_eGEMOV.sCodDoc
            wg_sTipCmpE21 = "S"
            wg_sNomCmpE22 = "sCodSer"
            wg_sDatCmpE22 = wl_eGEMOV.sCodSer
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
            wg_sTblCon1 = "CEODC"
            wl_frmLst.wp_sTxtFrm = "Consulta consecutivo ordenes de compra"


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
                    wl_eGEMOV.sCodTer = txtsCodTer.Text
                    BD_BuscarTEDMT()
                    If wr_bEOFE2 Then
                        wp_sNomTbl = "TEDMT"
                        wp_sDatCmp = txtsCodTer.Text
                        wp_sCodErr = "10-108"
                        mof_MsgError(wp_sNomTbl,
                                    wp_sDatCmp,
                                    wp_sCodErr)
                        txtsCodTer.Focus()
                    Else
                        BD_Var_TEDMT_TLDMT1()
                    End If
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

#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            Dim vl_aeGEMOV(0) As moe_Estructuras.eGEMOV
            Dim vl_aeATVEN(0) As moe_Estructuras.eATVEN
            Dim vl_aeTEDMT(0) As moe_Estructuras.eTEDMT
            Dim vl_aeTLDMT4(0) As moe_Estructuras.eTLDMT4
            dgv_DetADgv()
            BD_BuscarATVEN()
            BD_BuscarTEDMT()
            BD_BuscarTLDMT4()
            vl_aeGEMOV(0) = wl_eGEMOV
            vl_aeATVEN(0) = wl_eATVEN
            vl_aeTEDMT(0) = wl_eTEDMT
            vl_aeTLDMT4(0) = wl_eTLDMT4
            wl_sNroALetras = mof_NroALetras(CType(wl_eGEMOV.nTotDoc, String),
                                            wl_eGEMOV.sCodMon)
            mof_ActivarOK(Me)

            Select Case wl_eGEMOV.sCodSer
                Case "Oc"
                    Dim wl_frmRPT As New rptCOOC001
                    wl_frmRPT.wp_aeGEMOV = vl_aeGEMOV
                    wl_frmRPT.wp_aeGLMOV1 = wl_aeGLMOV1
                    wl_frmRPT.wp_aeATVEN = vl_aeATVEN
                    wl_frmRPT.wp_aeTEDMT = vl_aeTEDMT
                    wl_frmRPT.wp_aeTLDMT4 = vl_aeTLDMT4
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.Show()
                Case "Os"
                    Dim wl_frmRPT As New rptCOOS001
                    wl_frmRPT.wp_aeGEMOV = vl_aeGEMOV
                    wl_frmRPT.wp_aeGLMOV1 = wl_aeGLMOV1
                    wl_frmRPT.wp_aeATVEN = vl_aeATVEN
                    wl_frmRPT.wp_aeTEDMT = vl_aeTEDMT
                    wl_frmRPT.wp_aeTLDMT4 = vl_aeTLDMT4
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.Show()
                Case "Sc"
                    Dim wl_frmRPT As New rptCOSC001
                    wl_frmRPT.wp_aeGEMOV = vl_aeGEMOV
                    wl_frmRPT.wp_aeGLMOV1 = wl_aeGLMOV1
                    wl_frmRPT.wp_aeATVEN = vl_aeATVEN
                    wl_frmRPT.wp_aeTEDMT = vl_aeTEDMT
                    wl_frmRPT.wp_aeTLDMT4 = vl_aeTLDMT4
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.Show()
            End Select




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
                If wl_cvTxt.Name = "txtsCodTer" Then
                    wl_eGEMOV.sCodTer = txtsCodTer.Text
                    BD_BuscarTEDMT()
                    If wr_bEOFE2 Then
                        wp_sNomTbl = "TEDMT"
                        wp_sDatCmp = txtsCodTer.Text
                        wp_sCodErr = "10-108"
                        mof_MsgError(wp_sNomTbl,
                                    wp_sDatCmp,
                                    wp_sCodErr)
                        txtsCodTer.Focus()
                    Else
                        BD_Var_TEDMT_TLDMT1()
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
            If wl_eGEMOV.sEstDoc > "1" Then
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
            If cmdCrear.Visible = False Then
                mof_ActivarActualizar(Me)
            End If

            dgv_EliminarLinea()
        Catch ex As Exception
            MsgBox("Error : tsmi_EliminarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class