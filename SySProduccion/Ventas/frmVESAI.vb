Public Class frmVESAI

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
    Dim vl_nNroDocBas As Long
    Dim vl_dFecCtb As Date
    Dim vl_dFecDoc As Date
    Dim vl_dFecVto As Date
    Dim vl_dFecSys As Date
    Dim vl_nTotBas As Double
    Dim vl_nTotDoc As Double
    Dim vl_nTotDto As Double
    Dim vl_nTotGtoAdi As Double
    Dim vl_nTotIvaCom As Double
    Dim vl_nTotIvaVta As Double
    Dim vl_nVlrRdd As Double
    Dim vl_sClsDoc As String
    Dim vl_sCodDoc As String
    Dim vl_sCodDocBas As String
    Dim vl_sCodSer As String
    Dim vl_sEstDoc As String
    Dim vl_sNitTer As String
    Dim vl_sTipDoc As String
    Dim vl_sTipMov As String
    Dim vl_sCodTra As String
    Dim vl_sCodItm As String
    Dim vl_sCodAlm As String
    Dim vl_sCodVen As String
    Dim vl_sEstPdo As String

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
    Dim clnCEODC As New ClaseNegocios.clnCEODC
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim clnTblAB As New ClaseNegocios.clnTblAB
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTE1 As New DataTable
#End Region
#Region "015 Estructuras"
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim wl_eGLMOV1 As New moe_Estructuras.eGLMOV1
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
    Dim vl_eABESD As New moe_Estructuras.eABESD
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATIVA As New moe_Estructuras.eATIVA
    Dim wl_eATTIN As New moe_Estructuras.eATTIN
    Dim wl_eATVEN As New moe_Estructuras.eATVEN
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_eIELDMI1 As New moe_Estructuras.eIELDMI1
    Dim wl_eFECTT As New moe_Estructuras.eFECTT
    Dim wl_eFLCTT1 As New moe_Estructuras.eFLCTT1
    Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_eTEDMT As New moe_Estructuras.eTEDMT
    Dim wl_eTLDMT1 As New moe_Estructuras.eTLDMT1
    Dim wl_eTLDMT4 As New moe_Estructuras.eTLDMT4
#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    Dim wl_sDatCmp As String
    Dim wl_sNomtbl As String
#End Region
#Region "019 Fin definición del variables Locales"
#End Region



#Region "020 frm Eventos - Principal"

    Private Sub frmVESAI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error :  frmVESAI_Disposed")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmVESAI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            If wg_sFrmOri = "frmVENOC" Then
                BD_Var_wp_aeGEMOV()
                BD_eGEMOV_Var()
                dgv_wp_aeGLMOV1ADgv()
            End If
        Catch ex As Exception
            MsgBox("Error :  frmVESAI_Load")
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
            Cbo_CargarATTIN()
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
                vl_sTipDoc = cboABTID.SelectedValue

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
    Private Sub Cbo_CargarATTIN()
        Try
            '  cboABESD.Enabled = False
            wl_eATTIN = New moe_Estructuras.eATTIN
            wl_eATTIN.sTipMov = "S"
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATTIN"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnTblAB.cndtCrgATTIN(wl_eattin,
                                              wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATTIN.DataSource = wg_DTLst1
                cboATTIN.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboATTIN.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString
                vl_sCodTra = cboATTIN.SelectedValue
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATTIN")
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
                cboATVEN.ValueMember = wg_DTLst1.Columns("sCodVen").Caption.ToString
                cboATVEN.DisplayMember = wg_DTLst1.Columns("sNomVen").Caption.ToString
                vl_sCodVen = cboATVEN.SelectedValue


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
            wl_bEOF = True
            vl_sEstPdo = "0"
            vl_dFecCtb = dtpFecCtb.Text
            vl_dFecDoc = dtpFecDoc.Text

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
            'Ini 2018-07-20
            If wl_eGEMOV.sCodTra = "000" Or wl_eGEMOV.sCodTra = "001" Then
                MsgBox("Documento sin Transacción")
                cboATTIN.Focus()
                Return wl_bYesNo
            End If
            'Ini 2018-07-20

            If cmdCrear.Visible = True Then
                For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                    If wl_CtrlDgv.Rows(wl_nI).Visible = False Then
                        Continue For
                    End If
                    If wl_nNroDgv = 1 Then
                        If wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value = "" Then
                            Exit For
                        End If
                    Else
                        If wl_CtrlDgv.Rows(wl_nI).Cells("sNomAlt").Value = "" Then
                            Exit For
                        End If
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
                        If wl_CtrlDgv.Rows(wl_nI).Cells("sTipMov").Value = "S" Then
                            If wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm").Value > wl_CtrlDgv.Rows(wl_nI).Cells("nSdoAlm").Value Then
                                MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " no tiene saldo suficiente")
                                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm")
                                Return wl_bYesNo
                            End If
                        End If
                    End If
                Next

                '2018-07-20 Ini - Req 2018-01
                Plo_LeeAPEND()
                Plo_LeeAPLND1()
                vl_nNroDoc = CInt(txtnNroDoc.Text)
                wl_eGEMOV.nNroDoc = vl_nNroDoc
                '2018-07-20 Fin

            End If

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
                wl_sNomTblE1 = "IEMOV"
                wg_sNomCmpE11 = "nNroDoc"
                wg_sTipCmpE11 = "N"
                wg_sTitCmpE11 = "Número documento"
                wg_sDatCmpE11 = CLng(txtnNroDoc.Text)
                wg_sClaPpl = txtnNroDoc.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "E2" Then
                wl_sNomTblE1 = "IEMOV"
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
                .sCodSer = cboAPLND1.SelectedValue '27
                .sCodTra = cboATTIN.SelectedValue
                .sEstDoc = cboABESD.SelectedValue '3
                .sTipMov = vl_sTipMov '4
                .dFecCtb = dtpFecCtb.Text '5
                .dFecDoc = dtpFecDoc.Text '7
                .dFecVto = dtpFecCtb.Text '6
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
                .sCodVen = vl_sCodVen '26
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
                ' .sCodVen = cboATVEN.Text
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
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            wl_frmLst.wp_eTEDMT = New moe_Estructuras.eTEDMT
            wl_frmLst.vp_sTipTer = "1"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eTEDMT.sCodTer <> "" Then
                txtsCodTer.Text = wl_frmLst.wp_eTEDMT.sCodTer
                txtsNomTer.Text = wl_frmLst.wp_eTEDMT.sNomTer
                wl_eTEDMT = wl_frmLst.wp_eTEDMT
            End If
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
                cboATTIN.Text = .sCodTra
                wl_eGEMOV.nNroDoc = vl_nNroDocAnt
                txtnNroDoc.Text = .nNroDoc '2
                vl_sCodDoc = .sCodDoc '2
                vl_sCodTra = .sCodTra
                cboABESD.SelectedValue = .sEstDoc
                dtpFecCtb.Text = .dFecCtb  '5
                dtpFecDoc.Text = .dFecDoc '7

                'mtbFecSys.Text = .dFecSys  '8
                txtsCodTer.Text = .sCodTer   '9
                txtsNomTer.Text = .sNomTer '10
                txtsDocRef.Text = .sDocRef
                txtsCndPag.Text = .sCndPag
                cboABTID.SelectedValue = .sTipDoc
                vl_sTipDoc = .sTipDoc
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
                If .sEstDoc > "C" Then
                    mof_InhabCtrl(Me)
                End If
                If .sEstDoc = "A" Then
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
            wl_eGEMOV = New moe_Estructuras.eGEMOV
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
                vl_sTipDoc = .sTipDoc
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
            wl_eGEMOV = wg_eGEMOV
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
            Plo_InactCmpAct()
            mof_ActivarOK(Me)
            BD_DatPrmTipTbl(wg_sTipTbl)
            cmdCpa.Enabled = True
            lstCpa.Visible = False
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
    Private Function BD_BuscarIELDMI1() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            wr_bEOFE2 = mof_fConSdoAlm(vl_sCodItm,
                                       vl_sCodAlm,
                                       wl_eIELDMI1)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarIEDMI")
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
    Private Sub BD_CargarATIVA()

        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATIVA = New moe_Estructuras.eATIVA
            wl_frmLst.wp_sTxtFrm = "Impuestos"
            wg_sDatCon11 = vl_sClsDoc
            wg_sTblCon1 = "ATIVA"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATIVA.sCodIVA <> "" Then
                moo_DgvGLMOV1_eATIVA(Me.wl_CtrlDgv,
                                     wg_eATIVA,
                                     wl_nRowAct)
                wl_CtrlDgv.CurrentRow.Cells("sCodIVA").Value = wl_eATIVA.sCodIVA
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodIVA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATIVA")
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
    Private Sub BD_CargarVESAI()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eGEMOV = New moe_Estructuras.eGEMOV
            wl_frmLst.wp_eGEMOV = New moe_Estructuras.eGEMOV
            wl_frmLst.vp_sCodDoc = vl_sCodDoc
            wg_sTblCon1 = "VESAI"
            wl_frmLst.wp_sTxtFrm = "Consulta consecutivo " & Me.Text
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eGEMOV.sCodDoc <> "" Then
                wl_eGEMOV = wl_frmLst.wp_eGEMOV
                cboAPLND1.SelectedValue = wl_eGEMOV.sCodDoc
                txtnNroDoc.Text = wl_eGEMOV.nNroDoc
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarVEENI")
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
    Private Sub BD_frmIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wg_sTblCon1 = "IEDMIR"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> "" Then
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_frmIEDMIR()
        Try
            'FUA: 2015.05.14
            Dim wl_frmLst As New frmGQLst
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wg_sTblCon1 = "IEDMIR"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> "" Then
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
                dgv1.CurrentRow.Cells("sCodItm").Value = wl_eIEDMI.sCodItm
                dgv1.CurrentRow.Cells("sNomItm").Value = wl_eIEDMI.sNomItm
                dgv1.CurrentCell = dgv1.CurrentRow.Cells("sCodItm")


            End If
        Catch ex As Exception
            MsgBox("Error :  BD_frmIEDMIR")
            MsgBox(ex.Message)
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
                cmdOk.Focus()
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
            If txtnNroDoc.Text <> "" Then
                vl_nNroDoc = CInt(txtnNroDoc.Text)
                wl_eGEMOV = New moe_Estructuras.eGEMOV
                wl_eGEMOV.sCodDoc = vl_sCodDoc
                wl_eGEMOV.sCodSer = vl_sCodSer
                wl_eGEMOV.nNroDoc = vl_nNroDoc
                BD_DatPrmTipTbl(wg_sTipTbl)
                 wg_DTE1 = clnIEINV.cndtConGEMOV(wl_sNomTblE1,
                                                   wl_eGEMOV,
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
                    Plo_InactCmpAct()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    cmdCpa.Enabled = True
                    lstCpa.Visible = False
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
                    Else
                        '2018-07-20 Ini - Req 2018-01
                        Plo_LeeAPEND()
                        Plo_LeeAPLND1()
                        vl_nNroDoc = CInt(txtnNroDoc.Text)
                        wl_eGEMOV.nNroDoc = vl_nNroDoc
                        '2018-07-20 Fin
                        cmdCrear.Focus()

                    End If
                Else
                    '2018-10-24 Ini - Req 2018-01
                    Plo_LeeAPEND()
                    Plo_LeeAPLND1()
                    vl_nNroDoc = CInt(txtnNroDoc.Text)
                    wl_eGEMOV.nNroDoc = vl_nNroDoc
                    '2018-10-24 Fin
                    cmdCrear.Focus()


                    ' wp_sNomTbl = wl_sNomTblE1
                    ' wp_sDatCmp = txtnNroDoc.Text
                    ' wp_sCodErr = "10-319"
                    ' mof_MsgError(wp_sNomTbl,
                    '              wp_sDatCmp,
                    '             wp_sCodErr)
                    'txtsCodTer.Focus()
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
            wg_sNomTblL1 = "ILMOV1"
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
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Try
            wl_bEOF = False
            BD_Lst_TEDMT()
            BD_Var_TEDMT_TLDMT1()


            'wl_eGEMOV.sCodTer = txtsCodTer.Text
            'wg_eTEDMT = New moe_Estructuras.eTEDMT
            'wl_bEOF = mof_fConTEDMT(wl_eGEMOV.sCodTer,
            '                        wg_eTEDMT)
            'BD_Var_eTEDMT()
            'wg_eTLDMT1 = New moe_Estructuras.eTLDMT1
            'wl_bEOF = mof_fConTLDMT1(wl_eGEMOV.sCodTer,
            '                         wg_eTLDMT1)
            'BD_Var_eTLDMT1()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
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
    End Sub
    Private Sub cmdLstVESAI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstVESAI.Click
        Try
            BD_CargarVESAI()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLstVESAI_Click")
        End Try
    End Sub
    Private Sub cmdMaestro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdMaestro.Click
        Dim frmMaestro As New frmTEDMT
        frmMaestro.Show()
    End Sub
    Private Sub cmdCpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCpa.Click
        lstCpa.Visible = True

    End Sub
    Private Sub lstCpa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCpa.SelectedIndexChanged
        Try


            Dim vl_aeGEMOV(0) As moe_Estructuras.eGEMOV
            ' Dim wl_aeGLMOV1(0) As moe_Estructuras.eGEMOV
            lstCpa.Visible = False

            If lstCpa.SelectedIndex = 0 Then
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

#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wg_eGLMOV1 = New moe_Estructuras.eGLMOV1
        wg_sNomTblL1 = "ILMOV1"
        Try
            '  wl_eGLMOV1.sCodItm = txtnNroDoc.Text
            For wl_nRow = 0 To wl_CtrlDgv.RowCount - 1
                'Ini 2018-07-20 Req 2018-01
                wl_CtrlDgv.Rows(wl_nRow).Cells("nNroDoc").Value = wl_eGEMOV.nNroDoc
                ' Fin 2018-07-20

                If wl_CtrlDgv.Rows(wl_nRow).Visible = False Then
                    Continue For
                End If
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
                    clnCEODC.cnActSdoCanLinCLODP1(wg_eGLMOV1,
                                                  wr_bEOFL1,
                                                  wp_sCmdSel)


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

        wg_sNomTblL1 = "ILMOV1"

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
                    For wl_nCol = 0 To wl_aeAPDGV.Length - 1
                        If wl_aeAPDGV(wl_nCol).bColTot = True Then
                            If wl_aeAPDGV(wl_nCol).sDesOpe = "Ope_11" Then
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
    Private Sub dgv_wp_aeGLMOV1ADgv()
        Try
            Dim wl_nRow As Integer
            Dim wl_nCntRow As Integer
            wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
            wl_nCntRow = UBound(wg_aeGLMOV1)
            ReDim wl_aeGLMOV1(wl_nCntRow)
            wl_aeGLMOV1 = wg_aeGLMOV1

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
                wl_eAPDGV = wl_aeAPDGV(wp_nC)
                '  With wl_CtrlDgv
                ' .Columns(wp_nC).HeaderText = wg_eAPDGV.sTitCol
                ' End With
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
            If wl_aeAPDGV(wl_nColAnt).sNomCmp = "nCanItm" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreUni" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrBas" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPorDto" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrDto" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreDto" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrDtoLin" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPorIva" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrIva" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrIvaLin" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreBru" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nTasCamUsd" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nPreUniUsd" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nVlrBasUsd" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nTotLin" Then


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
                        moo_DGVGLMOV1_eIELDMI1(wl_CtrlDgv,
                                               wl_eIELDMI1,
                                               wl_nRow)

                    End If
                End If
            End If
            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodAlm" Then
                BD_CargarATALM()
            End If
            If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodIva" Then
                BD_CargarATIVA()
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
            mov_dgv_VdaGLMOV1(wl_nCol,
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
                    dgv_AdiRow()
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

#Region "080 Plo Procedimientos del Formulario. Personalizados"
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
            lstCpa.Visible = True
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
            lstCpa.Visible = False
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
            wl_sNomFrm = "frmVESAI"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "SDV"
            vl_sTipMov = "S"
            vl_sClsDoc = "DI"
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
            wl_eGEMOV.sCodTra = vl_sCodTra
            wl_eGEMOV.sTipMov = vl_sTipMov
            wl_eGEMOV.sClsDoc = vl_sClsDoc
            wl_eGEMOV.sTipDoc = vl_sTipDoc

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
            wg_sTitMsgAdi = Me.Text

            ' IEINV

            dtpFecCtb.Value = Date.Today
            dtpFecCtb.Format = DateTimePickerFormat.Custom
            dtpFecCtb.CustomFormat = "yyyy-MM-dd"
            dtpFecDoc.Value = Date.Today
            dtpFecDoc.Format = DateTimePickerFormat.Custom
            dtpFecDoc.CustomFormat = "yyyy-MM-dd"


           
            mof_ActivarCrear(Me)



            vl_dFecCtb = dtpFecCtb.Value.ToShortDateString
            vl_dFecDoc = dtpFecDoc.Value.ToShortDateString
            vl_dFecVto = dtpFecCtb.Value.ToShortDateString

            txtnTotBas.Enabled = False
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
            wl_sNomFrm = "frmVESAI"
            wl_sCodDgv = "dgv1"
            vl_sCodDoc = "SDV"
            vl_sTipMov = "S"
            vl_sClsDoc = "DI"
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
            lstCpa.Visible = False
            cmdLstVESAI.Enabled = True
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarBuscar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCmpAct()
        Try
            txtsCodTer.Enabled = False
            cmdListar.Enabled = False
            txtsNomTer.Enabled = False
            cboATVEN.Enabled = False
            cboAPLND1.Enabled = False
            txtnNroDoc.Enabled = False
            cmdLstVESAI.Enabled = False
            cboABESD.Enabled = False
            cboATTIN.Enabled = True
            dtpFecCtb.Enabled = False
            dtpFecDoc.Enabled = False
            txtsCmn.Enabled = False
            txtsCodCteCtb.Enabled = False
            txtnNroCteCtb.Enabled = False
            txtnTotDoc.Enabled = False
            txtsDocRef.Enabled = True

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()

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
            cmdCpa.Enabled = False
            lstCpa.Visible = False
            cmdLstVESAI.Enabled = False
            txtsCodTer.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarCrear")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_CrgModCtb()
        Try
            wl_eGEMOV.sTipDoc = "IT"
            wl_eGEMOV.sCodDoc = "SDV"
            wl_eGEMOV.sTipMov = "SE"
            wl_eGEMOV.sClsDoc = "DI"
            wl_eGEMOV.nNroDoc = txtnNroDoc.Text
            wl_eGEMOV.dFecCtb = dtpFecCtb.Text
            wl_eGEMOV.dFecDoc = dtpFecDoc.Text
            wl_eGEMOV.dFecVto = dtpFecCtb.Text
            wl_eGEMOV.dFecSys = Date.Today

        Catch ex As Exception
            MsgBox("Error : Plo_CrgModCtb")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Plo_InactCmpAct()
        Try
            txtsCodTer.Enabled = False
            cmdListar.Enabled = False
            txtsNomTer.Enabled = False
            cboATVEN.Enabled = False
            cboATTIN.Enabled = True
            cboAPLND1.Enabled = False
            txtnNroDoc.Enabled = False
            cmdLstVESAI.Enabled = False
            cboABESD.Enabled = False
            dtpFecCtb.Enabled = False
            dtpFecDoc.Enabled = False
            txtsCmn.Enabled = False
            txtsCodCteCtb.Enabled = False
            txtnNroCteCtb.Enabled = False
            txtnTotDoc.Enabled = False
            txtsDocRef.Enabled = True


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
                Case "OD"
                    Dim wl_frmRPT As New rptVEOD001
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