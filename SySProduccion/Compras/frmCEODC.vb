Public Class frmCEODC
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-10
#Region "001 Inicia. wg - vg Definición del variables públicas"
    Public Property wg_aeGEMOV As Array
    Public Property wg_aeGLMOV1 As Array
    Public Property wg_aeATVEN As Array
    Public Property wg_aeTEDMT As Array
    Public Property wg_aeTLDMT1 As Array
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
    Dim wl_bvdaCbo As Boolean
    Dim wl_bVdoVta As Boolean
    Dim wl_bYesNo As Boolean
    Dim wl_bABTID As Boolean

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
    Dim wl_sNomCmp As String
    Dim wl_sTipCmp As String
    Dim wl_sCmpOrd As String
    Dim wl_sTipOrd As String

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

    Dim vl_nId As Long
    Dim vl_sCodDoc As String
    Dim vl_sCodDocBas As String
    Dim vl_nNroDoc As Long
    Dim vl_nNroDocBas As Long
    Dim vl_sCodTra As String
    Dim vl_sEstDoc As String
    Dim vl_sTipMov As String
    Dim vl_dFecCtb As Date
    Dim vl_dFecDoc As Date
    Dim vl_dFecVto As Date
    Dim vl_dFecSys As Date
    Dim vl_sCodTer As String
    Dim vl_sNomTer As String '10
    Dim vl_nPorDto As Double
    Dim vl_sAlmOri As String
    Dim vl_sDocRef As String
    Dim vl_nTotBas As Double
    Dim vl_nTotDto As Double
    Dim vl_nTotGtoAdi As Double
    Dim vl_nTotIvaCom As Double
    Dim vl_nTotIvaVta As Double
    Dim vl_nVlrRdd As Double
    Dim vl_nTotDoc As Double '20
    Dim vl_sCndPag As String
    Dim vl_sClsDoc As String
    Dim vl_sTipDoc As String
    Dim vl_sCodVen As String
    Dim vl_sCodSer As String
    Dim vl_sDirTer As String
    Dim vl_sCiuTer As String
    Dim vl_sDepTer As String '30
    Dim vl_sPaiTer As String
    Dim vl_sCmn As String
    Dim vl_sCodCteCtb As String
    Dim vl_nNroCteCtb As Long
    Dim vl_nIdFECCT As Long
    Dim vl_sNitTer As String
    Dim vl_sCodMon As String
    Dim vl_bPrp01 As Boolean
    Dim vl_bPrp02 As Boolean
    Dim vl_bPrp03 As Boolean '40
    Dim vl_sCodUsr As String
    Dim vl_sCodAut As String
    Dim vl_sEstDocAnt As String
    Dim vl_sCodAutAnt As String


    'GLMOV1
    Dim vl_sCodItm As String
    Dim vl_sCodAlm As String
    Dim vl_sCodAlmCom As String

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
    Dim wl_nColFin1 As Integer
    Dim wl_nColFin2 As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIni1 As Integer
    Dim wl_nColIni2 As Integer
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
    Dim clnTblAB As New ClaseNegocios.clnTblAB
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTLst1 As New DataTable
    Dim wl_DTE1 As New DataTable
    Dim wl_DTE2 As New DataTable

#End Region
#Region "015 Estructuras"

    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim wl_aeGEMOV() As moe_Estructuras.eGEMOV
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1

    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eABESD As moe_Estructuras.eABESD
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eATALM As moe_Estructuras.eATALM
    Dim wl_eATALMCom As moe_Estructuras.eATALM
    Dim wl_eATIVA As moe_Estructuras.eATIVA
    Dim wl_eATVEN As moe_Estructuras.eATVEN
    Dim wl_eATVEN_Aut As moe_Estructuras.eATVEN
    Dim wl_eFECTT As moe_Estructuras.eFECTT
    Dim wl_eIEDMI As moe_Estructuras.eIEDMI
    Dim wl_eIELDMI1 As moe_Estructuras.eIELDMI1
    Dim wl_eILDMI1 As moe_Estructuras.eILDMI1
    Dim wl_eILDMI2 As moe_Estructuras.eILDMI2
    Dim wl_eFLCTT1 As moe_Estructuras.eFLCTT1
    Dim wl_eGEMOV As moe_Estructuras.eGEMOV
    Dim wl_eGLMOV1 As moe_Estructuras.eGLMOV1

    Dim wl_eTEDMT As moe_Estructuras.eTEDMT
    Dim wl_eTLDMT1 As moe_Estructuras.eTLDMT1
    Dim wl_eTLDMT4 As moe_Estructuras.eTLDMT4
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
    Private Sub frmCEODC_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        grl_RemoveHandler()
        Me.Dispose()
    End Sub
    Private Sub frmCEODC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Plo_SelDGV(wl_nNroDgv)
            grl_EventCtrl(Me)
            Cbo_CargarLst()
            Plo_ActivarCrear() '080
            Plo_TxtIni() '080
            Plo_CrgModCtb() '081
            Plo_InHabRdb()
        Catch ex As Exception
            MsgBox("Error :  frmCEODC_Load")
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
            Cbo_CargarABEOC()
            Cbo_CargarCodAut()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarAPLND1()
        Try
            wg_sTblLst1 = "APLND1"
            wr_bEOFLst1 = wr_bEOFLst1
            wl_DTLst1 = clnConTbl.cndtCargarNro(wg_sTblLst1,
                                                wl_eGEMOV.sCodDoc,
                                                wr_bEOFLst1)
            wl_bSwsCbo = False
            If Not wr_bEOFLst1 Then
                cboAPLND1.DataSource = wl_DTLst1
                cboAPLND1.ValueMember = wl_DTLst1.Columns("sCodSer").Caption.ToString
                cboAPLND1.DisplayMember = wl_DTLst1.Columns("sCodSer").Caption.ToString
                cboAPLND1.SelectedValue = wl_DTE2.Rows(0).Item("sCodSer")
                vl_sCodSer = cboAPLND1.SelectedValue
            End If
            wl_bSwsCbo = True
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarAPLND1")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboAPLND1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAPLND1.SelectedIndexChanged
        Try

            wl_eAPLND1 = New moe_Estructuras.eAPLND1

            If cmdCrear.Visible = True Then

                If wl_bSwsCbo Then
                    wg_sTblLst1 = "APLND1"
                    wr_bEOFLst1 = wr_bEOFLst1
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
                        Select Case vl_sCodSer
                            Case "OC"
                                cboABTID.SelectedValue = "IT"
                                wl_CtrlDgv = Me.dgv1

                            Case "SC"
                                cboABTID.SelectedValue = "SE"
                                wl_CtrlDgv = Me.dgv2
                            Case "OS"
                                cboABTID.SelectedValue = "SE"
                                wl_CtrlDgv = Me.dgv2
                            Case Else
                                cboABTID.SelectedValue = "IT"
                                wl_CtrlDgv = Me.dgv1
                        End Select
                    End If



                    If cboAPLND1.SelectedValue = "Sc" Then
                        Plo_HabRdb()
                    Else
                        Plo_InHabRdb()
                    End If
                    Plo_IniciarVar()
                End If

            Else
                wl_bSwsCbo = True
                vl_sCodSer = cboAPLND1.SelectedValue
                '   wl_i = cboAPLND1.FindString(vl_sCodSer)
                Select Case vl_sCodSer
                    Case "OC"
                        cboABTID.SelectedValue = "IT"
                        wl_CtrlDgv = Me.dgv1

                    Case "SC"
                        cboABTID.SelectedValue = "SE"
                        wl_CtrlDgv = Me.dgv2
                    Case "OS"
                        cboABTID.SelectedValue = "SE"
                        wl_CtrlDgv = Me.dgv2
                    Case Else
                        cboABTID.SelectedValue = "IT"
                        wl_CtrlDgv = Me.dgv1
                End Select
                '  cboAPLND1.SelectedIndex = wl_i
            End If

        Catch ex As Exception
            MsgBox("Error :  cboAPLND1_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarABEOC()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABEOC"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABEOC.DataSource = wg_DTLst1
                cboABEOC.ValueMember = wg_DTLst1.Columns(1).Caption.ToString
                cboABEOC.DisplayMember = wg_DTLst1.Columns(2).Caption.ToString
            End If
            wl_bvdaCbo = False
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABEOC")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboABEOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboABEOC.SelectedIndexChanged
        Try
            If wl_bvdaCbo = True Then
                If cboABEOC.SelectedValue = "1" Then

                End If
                If cboABEOC.SelectedValue = "2" Then

                End If

                If cboABEOC.SelectedValue = "3" Then

                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  cboABEOC_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub Cbo_CargarABESD()
    '    ' Reemplazada por Cbo_CargarABEOC
    '    Try
    '        '  cboABESD.Enabled = False
    '        wg_DTLst1 = New DataTable
    '        wg_sTblLst1 = "ABESD"
    '        wr_bEOFLst1 = True
    '        wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
    '                                              wr_bEOFLst1)
    '        If Not wr_bEOFLst1 Then
    '            cboABEOC.DataSource = wg_DTLst1
    '            cboABEOC.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
    '            cboABEOC.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error :  Cbo_CargarABESD")
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub
    Private Sub Cbo_CargarABTID()
        Try
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABTID"
            wr_bEOFLst1 = True

            wl_bABTID = False
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABTID.DataSource = wg_DTLst1
                cboABTID.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
                cboABTID.DisplayMember = wg_DTLst1.Columns(1).Caption.ToString
            End If
            cboABTID.SelectedValue = "IT"
            wl_nNroDgv = 1
            wl_bABTID = True
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABTID")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cboABTID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboABTID.SelectedIndexChanged
        Try
            If wl_bABTID = True Then
                If wl_CtrlDgv.Visible = True Then
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
                            wl_nNroDgv = 1
                            cboABTID.SelectedValue = "OC"
                            vl_sTipDoc = cboABTID.SelectedValue
                    End Select

                    Plo_SelDGV(wl_nNroDgv)
                    txtsCodTer.Focus()
                End If
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
            wg_DTLst1 = clnTblAB.cndtCrgATVEN(wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATVEN.DataSource = wg_DTLst1
                cboATVEN.ValueMember = wg_DTLst1.Columns("sCodVen").Caption.ToString
                cboATVEN.DisplayMember = wg_DTLst1.Columns("sNomVen").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATVEN")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarCodAut()
        Try
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATVEN"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnTblAB.cndtCrgATVEN(wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboCodAut.DataSource = wg_DTLst1
                cboCodAut.ValueMember = wg_DTLst1.Columns("sCodVen").Caption.ToString
                cboCodAut.DisplayMember = wg_DTLst1.Columns("sNomVen").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarCodAut")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "040 BD Procedimientos sobre la BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        '  wl_sNomTblE1 = "CEODC"
        wl_bYesNo = False
        Try
            Plo_Var_Frm()
            BD_eGEMOV_Var()

            BD_BuscarTEDMT()
            If wr_bEOFE2 Then
                MsgBox("Código del Tercero es obligatorio")
                txtsCodTer.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            If cboABTID.SelectedValue = "IT" Then
                wl_nNroDgv = 1
                wl_sCodDgv = "dgv1"
                wl_CtrlDgv = Me.dgv1
            Else
                wl_nNroDgv = 2
                wl_sCodDgv = "dgv2"
                wl_CtrlDgv = Me.dgv2
            End If

            If vl_sEstDocAnt = "P" And vl_sEstDoc = "A" Then
                MsgBox("Estado del documento solo puede ser Aprobado/Cerrado")
                cboABEOC.Focus()
                Return wl_bYesNo
            End If
            If vl_sCodVen Is Nothing Then
                vl_sCodVen = "00"
            End If

            If vl_sCodAut Is Nothing Then
                vl_sCodAut = "00"
                wl_eGEMOV.sCodAut = vl_sCodAut
            End If


            If vl_sCodVen = "00" Then
                MsgBox("Debe seleccionar un código de Solicitado Por")
                cboATVEN.Focus()
                cboATVEN.SelectedValue = "00"
                Return wl_bYesNo
            End If

            If vl_sCodAut = "00" And vl_sEstDoc <> "A" Then
                MsgBox("Debe seleccionar un código de Autorizado por")
                cboCodAut.Focus()
                Return wl_bYesNo
            End If


            If wl_CtrlDgv.Rows.Count Then
                If wl_nNroDgv = 1 Then

                    If wl_CtrlDgv.Rows(0).Cells("sCodItm").Value = "" Then
                        MsgBox("Documento no tiene detalle")
                        txtsCodTer.Focus()
                        Return wl_bYesNo
                    End If
                Else
                    If wl_CtrlDgv.Rows(0).Cells("sNomItm").Value = "" And wl_CtrlDgv.Rows(0).Cells("sNomAlt").Value = "" Then
                        MsgBox("Documento no tiene detalle")
                        txtsCodTer.Focus()
                        Return wl_bYesNo
                    End If
                End If
                'txtsCodTer.Focus()
                '  Return wl_bYesNo
            End If
            For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                If wl_nNroDgv = 1 Then
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value = "" Then
                        Exit For
                    End If
                Else
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sNomItm").Value = "" And wl_CtrlDgv.Rows(wl_nI).Cells("sNomAlt").Value = "" Then
                        Exit For
                    End If
                End If
                If wl_nNroDgv = 1 Then
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
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodAlm").Value = "" Then
                        MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " no tiene almacén")
                        wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("sCodAlm")
                        Return wl_bYesNo
                    End If
                End If

                If wl_CtrlDgv.Rows(wl_nI).Cells("sTipMov").Value = "S" Then
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sTipMov").Value = "S" Then
                        If wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm").Value > wl_CtrlDgv.Rows(wl_nI).Cells("nSdoAlm").Value Then
                            MsgBox(wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value & " no tiene saldo suficiente")
                            wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanItm")
                            Return wl_bYesNo
                        End If
                    End If
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
                wl_sNomTblE1 = "CEODC"
                wg_sNomCmpE11 = "nNroDoc"
                wg_sTipCmpE11 = "N"
                wg_sTitCmpE11 = "Número documento"
                wg_sDatCmpE11 = CLng(txtnNroDoc.Text)
                wg_sClaPpl = txtnNroDoc.Text
                wr_bEOFE1 = True
            End If
            If wg_sTipTbl = "E2" Then
                wl_sNomTblE1 = "CEODC"
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
                .sCodDoc = vl_sCodDoc
                .nNroDoc = vl_nNroDoc
                .sEstDoc = vl_sEstDoc
                .sCodTra = vl_sCodTra
                .sTipMov = vl_sTipMov
                .dFecCtb = vl_dFecCtb
                .dFecDoc = vl_dFecDoc
                .dFecVto = vl_dFecVto
                .dFecSys = vl_dFecSys
                .sCodTer = vl_sCodTer
                .sNomTer = vl_sNomTer '10
                .nPorDto = vl_nPorDto
                .sAlmOri = vl_sAlmOri
                .sDocRef = vl_sDocRef
                .nTotBas = vl_nTotBas
                .nTotDto = vl_nTotDto '15
                .nTotGtoAdi = vl_nTotGtoAdi '16
                .nTotIvaCom = vl_nTotIvaCom '17
                .nTotIvaVta = vl_nTotIvaVta '18
                .nVlrRdd = vl_nVlrRdd '19
                .nTotDoc = vl_nTotDoc '20
                .sCodDocBas = vl_sCodDocBas
                .nNroDocBas = vl_nNroDocBas
                .sCndPag = vl_sCndPag
                .sClsDoc = vl_sClsDoc
                .sTipDoc = vl_sTipDoc
                .sCodVen = cboATVEN.SelectedValue
                .sCodSer = cboAPLND1.SelectedValue
                .sDirTer = vl_sDirTer
                .sCiuter = vl_sCiuTer
                .sDepTer = vl_sDepTer '30
                .sPaiTer = vl_sPaiTer
                .sCmn = vl_sCmn
                .sCodCteCtb = vl_sCodCteCtb
                .nNroCteCtb = vl_nNroCteCtb
                .nIdFECCT = vl_nIdFECCT
                .sNitTer = vl_sNitTer
                .sCodMon = vl_sCodMon
                .bPrp01 = rdbPrp01.Checked
                .bPrp02 = rdbPrp02.Checked
                .bPrp03 = rdbPrp03.Checked

                .sCodUsr = vg_sCodUsr '37
                .sCodAut = cboCodAut.SelectedValue
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
    Private Sub BD_Lst_eATMON()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATMON"
            wl_frmLst.wp_eATMON = New moe_Estructuras.eATMON

            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATMON.sCodMon <> "" Then
                vl_sCodMon = wl_frmLst.wp_eATMON.sCodMon
                txtsCodMon.Text = wl_frmLst.wp_eATMON.sCodMon
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Lst_eATMON")
        End Try
    End Sub
    Private Sub BD_eTEDMT_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            moo_eTEDMT_DT(wl_eTEDMT,
                          wp_DTE1,
                          wl_nRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Vl_Var")
        End Try
    End Sub
    Private Sub BD_Var_eGEMOV()
        Try
            With wl_eGEMOV
                vl_nId = .nID
                vl_sCodDoc = .sCodDoc
                vl_nNroDoc = .nNroDoc
                vl_sCodTra = .sCodTra
                vl_sEstDoc = .sEstDoc
                vl_sTipMov = .sTipMov
                vl_dFecCtb = .dFecCtb
                vl_dFecDoc = .dFecDoc
                vl_dFecVto = .dFecVto
                vl_dFecSys = .dFecSys
                vl_sCodTer = .sCodTer
                vl_sNomTer = .sNomTer
                vl_nPorDto = .nPorDto
                vl_sAlmOri = .sAlmOri
                vl_sDocRef = .sDocRef
                vl_nTotBas = .nTotBas
                vl_nTotDto = .nTotDto
                vl_nTotGtoAdi = .nTotGtoAdi
                vl_nTotIvaCom = .nTotIvaCom
                vl_nTotIvaVta = .nTotIvaVta
                vl_nVlrRdd = .nVlrRdd
                vl_nTotDoc = .nTotDoc
                vl_sCodDocBas = .sCodDocBas
                vl_nNroDocBas = .nNroDocBas
                vl_sCndPag = .sCndPag
                vl_sClsDoc = .sClsDoc
                vl_sTipDoc = .sTipDoc
                vl_sCodVen = .sCodVen
                vl_sCodSer = .sCodSer
                vl_sDirTer = .sDirTer
                vl_sCiuTer = .sCiuter
                vl_sDepTer = .sDepTer
                vl_sPaiTer = .sPaiTer
                vl_sCmn = .sCmn
                vl_sCodCteCtb = .sCodCteCtb
                vl_nNroCteCtb = .nNroCteCtb
                vl_nIdFECCT = .nIdFECCT
                vl_sNitTer = .sNitTer
                vl_sCodMon = .sCodMon
                vl_bPrp01 = .bPrp01
                vl_bPrp02 = .bPrp02
                vl_bPrp03 = .bPrp03
                vl_sCodUsr = .sCodUsr
                vl_sCodAut = .sCodAut
                vl_sEstDocAnt = .sEstDoc
                vl_sCodAutAnt = .sCodAut

                If vl_sEstDoc = "A" Then
                    Plo_ActivarCmpAct()
                    Plo_ActivarCmpAut()
                Else
                    If vl_sEstDoc = "P" Then
                        Plo_InactCmpAct()
                        Plo_ActivarCmpEstDoc()
                    End If
                End If
                If vl_sTipDoc = "IT" Then
                    dgv2.Visible = False
                    dgv1.Visible = True
                Else
                    dgv1.Visible = False
                    dgv2.Visible = True
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eGEMOV")
        End Try


    End Sub
    Private Sub BD_Var_eTEDMT()
        Try
            With wl_eTEDMT
                '  vl_nId = .nID
                txtsNomTer.Text = .sNomTer
                txtsCndPag.Text = .sCndPag
                vl_sNitTer = .sNitTer
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_eTEDMT")
        End Try
    End Sub
    Private Sub BD_Var_eTLDMT1()
        Try
            With wl_eTLDMT1
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
    Private Sub BD_Var_TEDMT_TLDMT1()
        Try
            wl_eGEMOV.sCodTer = txtsCodTer.Text
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            wl_bEOF = mof_fConTEDMT(wl_eGEMOV.sCodTer,
                                    wl_eTEDMT)
            BD_Var_eTEDMT()
            wl_eTLDMT1 = New moe_Estructuras.eTLDMT1
            wl_bEOF = mof_fConTLDMT1(wl_eGEMOV.sCodTer,
                                     wl_eTLDMT1)
            BD_Var_eTLDMT1()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_TEDMT_TLDMT1")
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
            Plo_Frm_Var()
            BD_TipDoc()
            wl_CtrlDgv.Visible = True
            dgv_DetADgv()
            BD_DatPrmTipTbl(wg_sTipTbl)
            Plo_InactCmpAct()
            mof_ActivarOK(Me)
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
    Private Function BD_BuscarATALMCom() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATALMCom = New moe_Estructuras.eATALM
            wr_bEOFE2 = mof_fConATALM(wl_eATALMCom.sCodAlm,
                                      wl_eATALMCom)
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
    Private Function BD_BuscarATVEN_Aut() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATVEN_Aut = New moe_Estructuras.eATVEN
            wr_bEOFE2 = mof_fConATVEN(wl_eGEMOV.sCodAut,
                                      wl_eATVEN_Aut)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATVEN_Aut")
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

                wl_sNomtbl = "ILDMI2"
                wl_sNomCmp = "sCodTer"
                wl_sDatCmp = txtsCodTer.Text
                wl_sTipCmp = "S"
                wl_sCmpOrd = ""
                wl_sTipOrd = ""
                wl_DTE1 = mof_fConTbl(wl_sNomtbl,
                                      wl_sNomCmp,
                                      wl_sDatCmp,
                                      wl_sTipCmp,
                                      wl_sCmpOrd,
                                      wl_sTipOrd,
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
            wr_bEOFE2 = mof_fConTEDMT(vl_sCodTer,
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
    Private Function BD_BuscarTLDMT1() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eTLDMT1 = New moe_Estructuras.eTLDMT1
            wr_bEOFE2 = mof_fConTLDMT1(wl_eGEMOV.sCodTer,
                                      wl_eTLDMT1)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarTLDMT1")
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
    Private Sub BD_CargarATALMCom()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATALMCom = New moe_Estructuras.eATALM
            wg_sTblCon1 = "ATALM"
            wl_frmLst.wp_sTxtFrm = "Almacenes"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATALM.sCodAlm <> "" Then
                wl_eATALMCom = wl_frmLst.wp_eATALM
                wl_CtrlDgv.CurrentRow.Cells("sCodAlm").Value = wl_eATALM.sCodAlm
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodAlm")
            End If
        Catch ex As Exception
            MsgBox("Error :  BD_CargarATALMCom")
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
                wl_CtrlDgv.CurrentRow.Cells("sCodIVA").Value = wg_eATIVA.sCodIVA
                wl_CtrlDgv.CurrentRow.Cells("nPorIva").Value = wg_eATIVA.nPorIVA
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodIVA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATIVA")
        End Try
    End Sub
    Private Sub BD_CargarCEODC()

        Try

            Dim wl_frmLst As New frmGQLst
            wl_eGEMOV = New moe_Estructuras.eGEMOV
            wl_frmLst.wp_eGEMOV = New moe_Estructuras.eGEMOV
            wg_sTblCon1 = "CEODC"
            wl_frmLst.wp_sTxtFrm = "Consulta consecutivo ordenes de compra"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eGEMOV.sCodDoc <> "" Then
                wl_eGEMOV = wl_frmLst.wp_eGEMOV
                cboAPLND1.SelectedValue = wl_eGEMOV.sCodDoc
                txtnNroDoc.Text = wl_eGEMOV.nNroDoc
                cmdBuscar_Click(Nothing,
                           Nothing)
            Else
                txtnNroDoc.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarCEODC")
        End Try
    End Sub
    Private Sub BD_CargarIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_eIELDMI1 = New moe_Estructuras.eIELDMI1
            wl_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wg_sTblCon1 = "IEDMI"
            wl_frmLst.wp_sTxtFrm = "Items de inventarios"
            wl_frmLst.wp_sFrmOri = "frmCEODC"
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
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
    Private Sub BD_CargarILDMI2()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eILDMI2 = New moe_Estructuras.eILDMI2
            wl_eIELDMI1 = New moe_Estructuras.eIELDMI1
            wg_sTblCon1 = "ILDMI2"
            wr_bEOFCon1 = True
            wl_frmLst.wp_sTxtFrm = "Consulta de ítems por proveedor"
            wl_frmLst.wp_Q1_eILDMI2 = New moe_Estructuras.Q1_eILDMI2
            wl_frmLst.vp_sCodTer = txtsCodTer.Text
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_Q1_eILDMI2.eILDMI2.sCodItm <> "" Then
                wg_eILDMI2 = wl_frmLst.wp_Q1_eILDMI2.eILDMI2
                wl_CtrlDgv.CurrentRow.Cells("sCodItm").Value = wl_frmLst.wp_Q1_eILDMI2.eILDMI2.sCodItm
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.CurrentRow.Cells("sCodItm")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarILDMI2")
        End Try
    End Sub
    Private Sub BD_CargarTEDMT()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "TEDMT"
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            wl_frmLst.wp_eTEDMT = New moe_Estructuras.eTEDMT
            wl_frmLst.vp_sTipTer = "2"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eTEDMT.sCodTer <> "" Then
                wl_eTEDMT = wl_frmLst.wp_eTEDMT
                txtsCodTer.Text = wl_eTEDMT.sCodTer
                txtsNomTer.Text = wl_eTEDMT.sNomTer
                txtsCodTer.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Lst_TEDMT")
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
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            '   wp_nBoxMsg = 4
            '   wp_sDesMsg = wg_sDesMsgAdi
            '   wp_sTitMsg = wg_sTitMsgAdi
            '   wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
            '                            wp_sDesMsg,
            '                            wp_sTitMsg)
            '   If wp_nResMsg = 6 Then
            '   End If

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
                wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)

                Plo_IniciaFrm()
                Plo_InactCmpAct()
                mof_ActivarOK(Me)
                cmdOk.Focus()
            Else
                cmdCancelar.Focus()
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
                    Plo_Frm_Var()
                    mof_fLmpCtrl(Me.dgv1)
                    Plo_SelDGV(wl_nNroDgv)
                    dgv_DetADgv()
                    BD_Var_eGEMOV()
                    If vl_sEstDoc <> "A" Then
                        Plo_InactCmpAct()
                    End If

                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    cmdCpa.Enabled = True
                    lstCpA.Visible = False
                End If
            Else
                txtnNroDoc.Focus()
            End If



        Catch ex As Exception
            MsgBox("Error : cmdBuscar_Click")
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

                    wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                    If wl_bYesNo Then
                        wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                        PloNroSig_APEND()
                        PloNroSig_APLND1()
                        'Plo_InactivarCmpBus()
                        Plo_InactCmpAct()
                        mof_habTsbCrear()
                        mof_habTsbEliminar()
                        mof_InhabCtrl(Me)
                        mof_ActivarOK(Me)
                        wp_sNomTbl = wl_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = wg_sCodErrOk
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
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
            wg_sNomTblL1 = "CLODC1"
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
        Try
            lstCpA.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdCpa_Click")
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
    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        Try
            mof_LmpMsgError()
            wl_bEOF = False
            BD_CargarTEDMT()
            BD_Var_TEDMT_TLDMT1()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdListar_Click")
        End Try
    End Sub
    Private Sub cmdLstATMON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstATMON.Click
        Try
            mof_LmpMsgError()
            wl_bEOF = False
            BD_Lst_eATMON()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLstATMON_Click")
        End Try
    End Sub
    Private Sub cmdLstCEODP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstCEODP.Click
        Try
            BD_CargarCEODC()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLstCEODP_Click")
        End Try
    End Sub
    Private Sub cmdLstTEDMT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cmdMaestro.Click
        Try
            Dim frmTEDMT As New frmTEDMT
            frmTEDMT.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdLinea_Click")
        End Try

    End Sub
    Private Sub lstCpa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCpA.SelectedIndexChanged
        Try
            Dim wl_aeGEMOV(0) As moe_Estructuras.eGEMOV
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
                    wl_aeGEMOV(0) = wl_eGEMOV
                    wl_sFrmDtn.wg_aeGEMOV = wl_aeGEMOV
                    wl_sFrmDtn.wg_aeGLMOV1 = wl_aeGLMOV1
                    wl_sFrmDtn.Show()
                End If

            End If
            If lstCpA.SelectedIndex = 1 Then
                Dim wl_frmGEMOV As New frmCEFAP
                Dim wl_sFrmDtn As New frmCEFAP
                wl_sFrmDtn.wg_sFrmOri = Me.Name
                wl_aeGEMOV(0) = wl_eGEMOV
                wl_sFrmDtn.wg_aeGEMOV = wl_aeGEMOV
                wl_sFrmDtn.wg_aeGLMOV1 = wl_aeGLMOV1
                wl_sFrmDtn.Show()
            End If
            If lstCpA.SelectedIndex = 2 Then
                If wl_eGEMOV.sTipDoc <> "IT" Then
                    MsgBox("Este documento no maneja inventarios")
                    cmdCpa.Focus()
                Else
                    Dim wl_frmGEMOV As New frmCESAI
                    Dim wl_sFrmDtn As New frmCESAI
                    wl_sFrmDtn.wg_sFrmOri = Me.Name
                    wl_aeGEMOV(0) = wl_eGEMOV
                    wl_sFrmDtn.wg_aeGEMOV = wl_aeGEMOV
                    wl_sFrmDtn.wg_aeGLMOV1 = wl_aeGLMOV1
                    wl_sFrmDtn.Show()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error :  lstCpa_SelectedIndexChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "061 Eventos_Click Lista Controladores de Eventos (Remitente_evento)"
#End Region

#Region "070 DGV Procedimientos"
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wg_eGLMOV1 = New moe_Estructuras.eGLMOV1
        wg_sNomTblL1 = "CLODC1"
        Try

            For wl_nRow = 0 To wl_CtrlDgv.RowCount - 1
                If wl_eGEMOV.sTipDoc = "IT" Then
                    If wl_CtrlDgv.Rows(wl_nRow).Cells("sCodItm").Value Is Nothing Then
                        Exit For
                    End If
                End If
                If wl_eGEMOV.sTipDoc = "SE" Then
                    If wl_CtrlDgv.Rows(wl_nRow).Cells("sNomItm").Value Is Nothing And wl_CtrlDgv.Rows(wl_nRow).Cells("sNomAlt").Value Is Nothing Then
                        Exit For
                    End If
                End If
                Plo_Frm_Var()
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
        'Fec_Ult_Act : 2015.06.12
        Try
            ' Viene de tsmi_CrearLinea
            dgv_AdiRowGLMOV1()
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_AdiRowGLMOV1()
        'Fec_Ult_Act : 2015.06.12
        Try

            wl_nCntRow = wl_CtrlDgv.RowCount - 1
            '   If wl_nCntRow > -1 Then
            ' wl_nCol = wl_CtrlDgv.Columns("sCodItm").Index
            ' If wl_nNroDgv = 2 Then
            ' If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomAlt").Value = "" And wl_CtrlDgv.Rows(wl_nCntRow).Cells("sNomAlt").Value = "" Then
            ' Exit Sub
            ' End If
            ' Else
            '
            '            If wl_CtrlDgv.Rows(wl_nCntRow).Cells("sCodItm").Value = "" Then
            ' Exit Sub
            ' End If
            ' End If
            ' End If
            With wl_CtrlDgv
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentRow.Cells("sCodDoc").Value = vl_sCodDoc
                .CurrentRow.Cells("nNroDoc").Value = CInt(txtnNroDoc.Text)
                .CurrentRow.Cells("sCodSer").Value = cboAPLND1.SelectedValue
                .CurrentRow.Cells("sTipMov").Value = vl_sTipMov
                .CurrentRow.Cells("sClsDoc").Value = vl_sClsDoc
                .CurrentRow.HeaderCell.Value = (wl_CtrlDgv.CurrentRow.Index + 1).ToString
            End With
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_nColIniGrl
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRowGLMOV1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wg_DTL1 = New DataTable
        wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
        ReDim wl_aeGLMOV1(0)

        wg_sNomTblL1 = "CLODC1"

        wr_bEOFL1 = True
        '  wl_eGEMOV.nNroDoc = txtnNroDoc.Text
        vl_sCodItm = ""

        Try
            If wl_eGEMOV.sTipDoc = "IT" Then
                wl_CtrlDgv = Me.dgv1
                wl_sCodDgv = "dgv1"
                wl_nNroDgv = "1"


                wg_DTL1 = clnIEINV.cndtConsultarILMOV1(wg_sNomTblL1,
                                                       wl_eGEMOV.sCodDoc,
                                                       wl_eGEMOV.nNroDoc,
                                                       vl_sCodItm,
                                                       wr_bEOFL1)
            Else
                wl_CtrlDgv = Me.dgv2
                wl_sCodDgv = "dgv2"
                wl_nNroDgv = "2"

                wg_DTL1 = clnIEINV.cndtConSolILMOV1(wg_sNomTblL1,
                                                    wl_eGEMOV.sCodDoc,
                                                    wl_eGEMOV.nNroDoc,
                                                    wr_bEOFL1)
            End If
            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                Plo_SelDGV(wl_nNroDgv)
                With wl_CtrlDgv
                    ReDim wl_aeGLMOV1(wg_DTL1.Rows.Count)
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRowGLMOV1()
                        If wl_eGEMOV.sTipDoc = "IT" Then
                            moo_DGV_DTeILMOV1(wl_CtrlDgv,
                                           wg_DTL1,
                                           wl_nRow)
                        Else
                            moo_DGV_SolDTeILMOV1(wl_CtrlDgv,
                                                 wg_DTL1,
                                                 wl_nRow)
                        End If
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
    Private Function dgv1_VdaRow(ByRef wl_bVdaRow) As Boolean
        Try

            wl_bVdaRow = True
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then

                '                wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
                '               wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then
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
            If wl_sCodDgv = "dgv1" Then
                wl_nColIni1 = wg_nColIni
                wl_nColFin1 = wg_nColFin
            End If
            If wl_sCodDgv = "dgv2" Then
                wl_nColIni2 = wg_nColIni
                wl_nColFin2 = wg_nColFin
            End If

            wl_nColIniGrl = wg_nColIni
            wl_nColFin = wg_nColFin
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
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nTotLin" Or
                wl_aeAPDGV(wl_nColAnt).sNomCmp = "nLinBas " Then

                wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
                moo_eGLMOV1_DGVGLMOV1(wl_eGLMOV1,
                                      wl_CtrlDgv,
                                      wl_nRowKU)
                If vl_sCodMon = "USD" Or vl_sCodMon = "EUR" Then
                    wl_eGLMOV1.nPreUniUsd = wl_eGLMOV1.nPreUni
                End If
                wl_eGLMOV1.nPreUniUsd = wl_eGLMOV1.nPreUni

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
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = dgv1.CurrentCell.RowIndex
            wl_nColKD = dgv1.CurrentCell.ColumnIndex
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
            MsgBox("Error: dgv1_CellMouseClick")
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
                wl_bEOF = BD_BuscarILDMI2()
                If wl_bEOF Then
                    BD_CargarIEDMI()
                Else
                    BD_CargarILDMI2()
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
        Catch
            MsgBox("Error : dgv1_CellValueChanged")
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
                                        wl_nColFin1,
                                        wl_nColIniGrl,
                                        wl_nCntRow,
                                        wl_CtrlDgv,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRowGLMOV1()
                    wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y

                End If
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin1,
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
    End Sub
    Private Sub dgv1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.Leave
        Try
            wl_nRow = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nCol = wl_CtrlDgv.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin1 Then
                dgv1_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv1_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
    'dgv2
    Private Sub dgv2_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellLeave
        Try
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = dgv2.CurrentCell.RowIndex
            wl_nColKD = dgv2.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv2_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseClick
        Try
            wl_CtrlDgv = dgv2
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
            MsgBox("Error: dgv2_CellMouseClick")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseDoubleClick
        Try
            wl_CtrlDgv = dgv2
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
                wl_bEOF = BD_BuscarILDMI2()
                If wl_bEOF Then
                    BD_CargarIEDMI()
                Else
                    BD_CargarILDMI2()
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
    Private Sub dgv2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv2.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv2.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv2.CurrentCell = dgv2.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv2_DataError")
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
        Dim wl_bAdiRow As Boolean = False

        Try
            mof_LmpMsgError()
            wl_CtrlDgv = dgv2
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
                                        wl_nColFin2,
                                        wl_nColIniGrl,
                                        wl_nCntRow,
                                        wl_CtrlDgv,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRowGLMOV1()
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
            wl_nRowAnt = wl_CtrlDgv.CurrentCellAddress.Y

        Catch ex As Exception
            MsgBox("Error: dgv2_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.Leave
        Try
            wl_nRow = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nCol = wl_CtrlDgv.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv2_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv2_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "073 DGV Procedimientos llamados por los Controladores de Eventos"
#End Region
#End Region

#Region "080 Plo Procedimientos del Formulario"
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActivarCmpAct()
        Try
            txtsCodTer.Enabled = True
            cmdListar.Enabled = True
            txtsNomTer.Enabled = False
            txtsDocRef.Enabled = True
            cboATVEN.Enabled = True
            cboCodAut.Enabled = True
            txtnNroDoc.Enabled = False
            cmdLstCEODP.Enabled = False
            cboABEOC.Enabled = True
            cboAPLND1.Enabled = True
            dtpFecCtb.Enabled = True
            dtpFecDoc.Enabled = True
            dtpFecVto.Enabled = True



            'mtbFecCtb.Enabled = True
            'mtbFecVto.Enabled = True
            'mtbFecDoc.Enabled = True
            txtsCmn.Enabled = True
            lstCpA.Visible = False
            cmdCpa.Enabled = False
            cboABTID.Enabled = True
            txtnTotBas.Enabled = False
            txtnTotDto.Enabled = True
            txtnTotGtoAdi.Enabled = True
            txtnVlrRdd.Enabled = True
            txtnTotIvaCom.Enabled = False
            txtnTotDoc.Enabled = False
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()

            wl_sCodDgv = "dgv2"
            wl_CtrlDgv = Me.dgv2
            dgv_APDGV()
            dgv_ConfiguraCol()

        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Plo_ActivarCmpEstDoc()
        Try
            '     cboCodAut.Enabled = True
            cboABEOC.Enabled = True
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAut")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCmpAut()
        Try
            '     cboCodAut.Enabled = True
            cboCodAut.Enabled = True
            cboABEOC.Enabled = True
        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAut")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCmpBus()
        Try
            cboAPLND1.Enabled = True
            txtnNroDoc.Enabled = True
            cmdLstCEODP.Enabled = True
            txtnNroDoc.Enabled = True
        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpBus")
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
                cboABEOC.SelectedValue = vl_sEstDoc
                wl_sNomCmp = "sEstDoc"
                wl_sTipCmp = "N"
                wl_sDatCmp = cboABEOC.SelectedValue
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
    Private Sub Plo_Frm_Var()
        Try
            txtnNroDoc.Text = vl_nNroDoc
            cboABEOC.SelectedValue = vl_sEstDoc
            'mtbFecCtb.Text = vl_dFecCtb
            'mtbFecDoc.Text = vl_dFecDoc
            'mtbFecVto.Text = vl_dFecVto

            dtpFecCtb.Text = vl_dFecCtb
            dtpFecDoc.Text = vl_dFecDoc
            dtpFecVto.Text = vl_dFecVto



            txtsCodTer.Text = vl_sCodTer
            txtsNomTer.Text = vl_sNomTer
            txtsDocRef.Text = vl_sDocRef
            txtnTotBas.Text = FormatCurrency(vl_nTotBas, 2)
            txtnTotDto.Text = FormatCurrency(vl_nTotDto, 2)
            txtnTotGtoAdi.Text = FormatCurrency(vl_nTotGtoAdi, 2)
            txtnTotIvaCom.Text = FormatCurrency(vl_nTotIvaCom, 2)
            txtnVlrRdd.Text = FormatCurrency(vl_nVlrRdd, 2)
            txtnTotDoc.Text = FormatCurrency(vl_nTotDoc, 2)
            txtsCndPag.Text = vl_sCndPag
            cboATVEN.SelectedValue = vl_sCodVen
            cboAPLND1.SelectedValue = vl_sCodSer
            txtsDirTer.Text = vl_sDirTer
            txtsCiuTer.Text = vl_sCiuTer
            txtsDepTer.Text = vl_sDepTer
            txtsPaiTer.Text = vl_sPaiTer
            txtsCmn.Text = vl_sCmn
            txtsCodMon.Text = vl_sCodMon
            rdbPrp01.Checked = vl_bPrp01
            rdbPrp02.Checked = vl_bPrp02
            rdbPrp03.Checked = vl_bPrp03
            cboCodAut.SelectedValue = vl_sCodAut
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Frm_Var")
        End Try
    End Sub
    Private Sub Plo_FrmLstdet()
        Try
            Dim wl_frmLstDet As New frmGQLstDet
            Dim wg_DTL1 As New DataTable
            wg_sTblCon1 = "CEODC"
            wg_sCmpCon11 = "sCodDoc"
            wg_sCmpCon12 = "nNroDoc"
            wg_sTitCon11 = "Código OP"
            wg_sTitCon12 = "Número OP"
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
    Private Sub Plo_InactCmpAct()
        Try
            txtsCodTer.Enabled = False
            cmdListar.Enabled = False
            txtsNomTer.Enabled = False
            txtsDocRef.Enabled = False
            cboATVEN.Enabled = False
            cboCodAut.Enabled = False
            cboAPLND1.Enabled = False
            txtnNroDoc.Enabled = False
            cmdLstCEODP.Enabled = False
            '     cboABESD.Enabled = False
            dtpFecCtb.Enabled = False
            dtpFecDoc.Enabled = False
            dtpFecVto.Enabled = False

            'mtbFecCtb.Enabled = False
            'mtbFecVto.Enabled = False
            'mtbFecDoc.Enabled = False
            txtsCmn.Enabled = False
            txtnTotBas.Enabled = False
            txtnTotDto.Enabled = False
            txtnTotGtoAdi.Enabled = False
            txtnVlrRdd.Enabled = False
            txtnTotIvaCom.Enabled = False
            txtnTotDoc.Enabled = False
            lstCpA.Visible = False
            cmdCpa.Enabled = False
            cboABTID.Enabled = False
            If vl_sTipDoc = "IT" Then
                dgv1.Visible = True
                dgv2.Visible = False
                For wl_i = 0 To dgv1.Rows.Count - 1
                    dgv1.Rows(wl_i).ReadOnly = True
                    dgv1.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                Next
            Else
                dgv1.Visible = False
                dgv2.Visible = True
                For wl_i = 0 To dgv2.Rows.Count - 1
                    dgv2.Rows(wl_i).ReadOnly = True
                    dgv2.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
                Next
            End If

        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactivarCmpBus()
        Try
            cmdLstCEODP.Enabled = False
            txtnNroDoc.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactivarCmpBus")
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
            wl_sNomFrm = "frmCEODC"
            wl_nNroDgv = 1

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            vl_sCodDoc = "ODC"
            vl_sTipMov = " "
            vl_sClsDoc = "DC"
            ' wl_bSwsCbo = False

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
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            wl_eATVEN = New moe_Estructuras.eATVEN
            wl_eATVEN_Aut = New moe_Estructuras.eATVEN
            wl_eTEDMT = New moe_Estructuras.eTEDMT
            ReDim wl_aeGLMOV1(0)

        Catch ex As Exception
            MsgBox("Error : Plo_IniciarEst")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Plo_IniciaFrm()
        Try
            wl_sTipTbl = "E2"
            wg_sTipTbl = wl_sTipTbl
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
            dtpFecVto.Value = Date.Today
            dtpFecVto.Format = DateTimePickerFormat.Custom
            dtpFecVto.CustomFormat = "yyyy-MM-dd"


            mof_ActivarCrear(Me)
            'dtpFecCtb.Visible = False
            'mtbFecCtb.Text = dtpFecCtb.Value
            'mtbFecDoc.Text = Today
            'mtbFecVto.Text = Today
            txtsCodMon.Enabled = False
            txtsCodMon.Text = vl_sCodMon

            'If txtnNroDoc.Text = "" Then
            ' txtnNroDoc.Text = 0
            ' End If
            'vl_nNroDoc = CLng(txtnNroDoc.Text)
            vl_sEstDoc = "A"
            vl_sCodTra = ""
            'vl_sTipMov = ""
            'vl_dFecCtb = mtbFecCtb.Text
            'vl_dFecDoc = mtbFecDoc.Text
            'vl_dFecVto = mtbFecCtb.Text
            vl_dFecCtb = dtpFecCtb.Value.ToShortDateString
            vl_dFecDoc = dtpFecDoc.Value.ToShortDateString
            vl_dFecVto = dtpFecVto.Value.ToShortDateString




            vl_dFecSys = Date.Today
            vl_sCodTer = ""
            vl_sNomTer = "" '10
            vl_nPorDto = 0
            vl_sAlmOri = ""
            vl_sDocRef = ""
            vl_nTotBas = 0
            vl_nTotDto = 0
            vl_nTotGtoAdi = 0
            vl_nTotIvaCom = 0
            vl_nTotIvaVta = 0
            vl_nVlrRdd = 0
            vl_nTotDoc = 0 '20
            vl_sCodDocBas = ""
            vl_nNroDocBas = 0
            vl_sCndPag = ""
            vl_sCodVen = ""
            vl_sCodSer = cboAPLND1.SelectedValue
            vl_sDirTer = ""
            vl_sCiuTer = ""
            vl_sDepTer = "" '30
            vl_sPaiTer = ""
            vl_sCmn = txtsCmn.Text
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0
            vl_sNitTer = ""
            vl_sCodMon = wg_sCodMon
            vl_bPrp01 = False
            vl_bPrp02 = False
            vl_bPrp03 = False '40
            vl_sCodUsr = vg_sCodUsr
            vl_sCodAut = cboCodAut.SelectedValue
            vl_sEstDocAnt = ""

            cboABEOC.SelectedValue = vl_sEstDoc
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            If cboAPLND1.SelectedValue Is Nothing Then
                cboAPLND1.SelectedValue = "OC"
                wl_nNroDgv = 1
            Else
                If cboAPLND1.SelectedValue = "OC" Then
                    wl_nNroDgv = 1
                Else
                    wl_nNroDgv = 2
                End If
                Plo_SelDGV(wl_nNroDgv)
            End If
            txtsNomTer.Enabled = False
            txtnTotBas.Enabled = False
            txtnTotDoc.Enabled = False

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
            wl_sNomFrm = "frmCEODC"
            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            vl_sCodDoc = "ODC"
            vl_sTipMov = " "
            vl_sClsDoc = "DC"
            ' wl_bSwsCbo = False
            cmdBuscar_Click(Nothing,
                            Nothing)

        Catch ex As Exception
            MsgBox("Error : Plo_CerrarDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_SelDGV(ByVal wl_nNroDgv As Integer)
        ' wl_CtrlDgv = New DataGridView
        Try
            If wl_nNroDgv = 1 Then
                If dgv2.Visible = True Then
                    If dgv2.Rows.Count > 0 Then
                        dgv2.Rows.Clear()
                    End If
                End If
                dgv2.Visible = False
                dgv1.Visible = True
                dgv1.Rows.Clear()
                wl_sCodDgv = "dgv1"
                wl_CtrlDgv = Me.dgv1
            End If
            If wl_nNroDgv = 2 Then
                If dgv1.Visible = True Then
                    If dgv1.Rows.Count > 0 Then
                        dgv1.Rows.Clear()
                    End If
                End If
                dgv1.Visible = False
                dgv2.Visible = True
                dgv2.Rows.Clear()
                wl_sCodDgv = "dgv2"
                wl_CtrlDgv = Me.dgv2
            End If
            dgv_APDGV()
            mof_ConfigurarDGV(wl_CtrlDgv,
                             wl_nTotCol)
            dgv_ConfiguraCol()
            If txtnNroDoc.Text <> "" Then
                dgv_AdiRowGLMOV1()
            End If

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
    Private Sub Plo_Var_Frm()
        Try
            'vl_nId
            'vl_sCodDoc
            vl_nNroDoc = CLng(txtnNroDoc.Text)
            vl_sEstDoc = cboABEOC.SelectedValue
            vl_sCodTra = ""
            'vl_sTipMov = ""
            'vl_dFecCtb = mtbFecCtb.Text
            'vl_dFecDoc = mtbFecDoc.Text
            'vl_dFecVto = mtbFecCtb.Text
            vl_dFecCtb = dtpFecCtb.Value.ToShortDateString
            vl_dFecDoc = dtpFecDoc.Value.ToShortDateString
            vl_dFecVto = dtpFecVto.Value.ToShortDateString
            vl_dFecSys = Date.Today

            vl_sCodTer = txtsCodTer.Text
            vl_sNomTer = txtsNomTer.Text  '10
            vl_nPorDto = 0
            vl_sAlmOri = ""
            vl_sDocRef = txtsDocRef.Text
            vl_nTotBas = CDbl(txtnTotBas.Text)
            vl_nTotDto = CDbl(txtnTotDto.Text)
            vl_nTotGtoAdi = CDbl(txtnTotGtoAdi.Text)
            vl_nTotIvaCom = CDbl(txtnTotIvaCom.Text)
            vl_nTotIvaVta = 0
            vl_nVlrRdd = CDbl(txtnVlrRdd.Text)
            vl_nTotDoc = CDbl(txtnTotDoc.Text) '20
            vl_sCodDocBas = ""
            vl_nNroDocBas = 0
            vl_sCndPag = txtsCndPag.Text
            'vl_sClsDoc
            vl_sTipDoc = cboABTID.SelectedValue
            vl_sCodVen = cboATVEN.SelectedValue
            vl_sCodSer = cboAPLND1.SelectedValue
            vl_sDirTer = txtsDirTer.Text
            vl_sCiuTer = txtsCiuTer.Text
            vl_sDepTer = txtsDepTer.Text
            vl_sPaiTer = txtsPaiTer.Text
            vl_sCmn = txtsCmn.Text
            vl_sCodCteCtb = ""
            vl_nNroCteCtb = 0
            vl_nIdFECCT = 0
            vl_sNitTer = wl_eTEDMT.sNitTer
            vl_sCodMon = txtsCodMon.Text
            'vl_bPrp01 = False
            'vl_bPrp02 = False
            'vl_bPrp03 = False '40
            vl_sCodUsr = vg_sCodUsr
            vl_sCodAut = cboCodAut.SelectedValue
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Plo_Var_Frm")
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarBuscar()
        Try
            mof_HabCtrl(Me)
            Plo_IniciarVar()
            ' Plo_InHabCtrl()
            Plo_InactCmpAct()
            Plo_ActivarCmpBus()
            mof_ActivarBuscar(Me)
            cboABTID.SelectedIndex = 0

            wl_CtrlDgv.Visible = True
            wl_CtrlDgv.Rows.Clear()
            mof_ConfigurarDGV(Me.wl_CtrlDgv,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            '  dgv_AdiRowGLMOV1()
            cboAPLND1.Enabled = True
            txtnNroDoc.Enabled = True
            txtnNroDoc.Text = ""
            ' cboABESD.Enabled = True
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
            ' Plo_ActivarCmpAct()
            Plo_IniciarEst() '080
            Plo_IniciarDoc() '080
            Plo_IniciarVar() '080
            Plo_ActivarCmpAct()
            '   dgv1.Select()
            mof_ActivarCrear(Me)

            txtnNroDoc.Enabled = False
            cboABEOC.Enabled = True

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
            wl_eGEMOV.sCodDoc = "ODC"
            wl_eGEMOV.sTipMov = " "
            wl_eGEMOV.sClsDoc = "DC"
            wl_eGEMOV.nNroDoc = txtnNroDoc.Text
            wl_eGEMOV.dFecCtb = dtpFecCtb.Value.ToShortDateString
            wl_eGEMOV.dFecDoc = dtpFecDoc.Value.ToShortDateString
            wl_eGEMOV.dFecVto = dtpFecDoc.Value.ToShortDateString
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
            wl_DTE2 = clnConTbl.cndtBuscar(wg_sNomTblE2,
                                           wg_sNomCmpE21,
                                           wg_sDatCmpE21,
                                           wg_sTipCmpE21,
                                           wg_sCmpOrdE21,
                                           wg_sTipOrdE21,
                                           wr_bEOFE1)
            If wr_bEOFE1 = False Then
                moo_eAPEND_DT(wl_eAPEND,
                              wl_DTE2,
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
        wl_DTE2 = clnConTbl.cndtBuscarE2(wg_sNomTblE2,
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
    Private Sub CerrarOrdenDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarOrdenDeCompraToolStripMenuItem.Click
        Try
            Plo_CerrarDoc()
        Catch ex As Exception
            MsgBox("Error :  CerrarOrdenDeCompraToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtpFecCtb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecCtb.ValueChanged


        Try
            vl_dFecCtb = dtpFecCtb.Value.ToShortDateString

            'vl_dFecCtb = DatePart(DateInterval.Day, dtpFecCtb.Value) & "/" & DatePart(DateInterval.Month, dtpFecCtb.Value) & "/" & DatePart(DateInterval.Year, dtpFecCtb.Value)







            '    DatePart(DateInterval.Day, dtpFecCtb)
            '    DatePart(DateInterval.Month, dtpFecCtb)
            '    DatePart(DateInterval.Year, dtpFecCtb)


            '   wl_eGEMOV.dFecCtb = dtpFecCtb.Value.ToShortDateString
        Catch ex As Exception
            MsgBox("Error :  dtpFecCtb_ValueChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtpFecVto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecVto.ValueChanged
        Try
            vl_dFecVto = dtpFecVto.Value.ToShortDateString
            '  vl_dFecVto = DatePart(DateInterval.Day, dtpFecVto.Value) & "/" & DatePart(DateInterval.Month, dtpFecVto.Value) & "/" & DatePart(DateInterval.Year, dtpFecVto.Value)
            'wl_eGEMOV.dFecVto = dtpFecVto.Value.ToShortDateString
        Catch ex As Exception
            MsgBox("Error :  dtpFecVto_ValueChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtpFecDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecDoc.ValueChanged
        Try
            vl_dFecDoc = dtpFecDoc.Value.ToShortDateString
            '  vl_dFecVto = DatePart(DateInterval.Day, dtpFecDoc.Value) & "/" & DatePart(DateInterval.Month, dtpFecDoc.Value) & "/" & DatePart(DateInterval.Year, dtpFecDoc.Value)
            ' wl_eGEMOV.dFecDoc = dtpFecDoc.Value.ToShortDateString
        Catch ex As Exception
            MsgBox("Error :  dtpFecDoc_ValueChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListaItemsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaItemsToolStripMenuItem1.Click
        Try
            wl_nRowKD = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nColKD = wl_CtrlDgv.CurrentCell.ColumnIndex
            wl_nColNom = wl_nColKD + 1
            wl_nColSig = wl_nColKD
            BD_CargarIEDMI()
        Catch ex As Exception
            MsgBox("Error :  ListaItemsToolStripMenuItem1_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txtnNroDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnNroDoc.DoubleClick
        Try

            BD_CargarCEODC()
        Catch ex As Exception
            MsgBox("Error :  txtnNroDoc_DoubleClick")
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
                        txtsDocRef.Focus()
                    End If
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

                If Mid(txtsCodTer.Text, 1, 1) = "" Or Mid(txtsCodTer.Text, 1, 1) = " " Then
                    txtsCodTer.Focus()
                    Exit Sub
                End If
                vl_sCodTer = txtsCodTer.Text
                wr_bEOFE2 = False
                BD_BuscarTEDMT()
                If wr_bEOFE2 = True Then
                    wp_sNomTbl = "TEDMT"
                    wp_sDatCmp = txtsCodTer.Text
                    wp_sCodErr = "10-108"
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    txtsCodTer.Focus()
                Else
                    If cmdCrear.Enabled = False Then
                        cmdCrear.Enabled = True
                    End If
                    BD_Var_TEDMT_TLDMT1()
                    txtsDocRef.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error : txtsCodTer_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtnNroDoc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnNroDoc.KeyUp
        Try
            If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
                If cmdBuscar.Visible = True Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : txtnNroDoc_KeyUp")
            MsgBox(ex.Message)
        End Try

    End Sub


#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            Dim wl_aeGEMOV(0) As moe_Estructuras.eGEMOV
            Dim wl_aeATVEN(0) As moe_Estructuras.eATVEN
            Dim wl_aeATVEN_Aut(0) As moe_Estructuras.eATVEN
            Dim wl_aeTEDMT(0) As moe_Estructuras.eTEDMT
            Dim wl_aeTLDMT1(0) As moe_Estructuras.eTLDMT1
            Dim wl_aeTLDMT4(0) As moe_Estructuras.eTLDMT4
            dgv_DetADgv()
            BD_BuscarATVEN()
            BD_BuscarATVEN_Aut()
            BD_BuscarTEDMT()
            BD_BuscarTLDMT1()
            wl_aeGEMOV(0) = wl_eGEMOV
            wl_aeATVEN(0) = wl_eATVEN
            wl_aeATVEN_Aut(0) = wl_eATVEN_Aut
            wl_aeTEDMT(0) = wl_eTEDMT
            wl_aeTLDMT1(0) = wl_eTLDMT1
            wl_sNroALetras = mof_NroALetras(CType(wl_eGEMOV.nTotDoc, String),
                                            wl_eGEMOV.sCodMon)
            'MsgBox(wl_sNroALetras.ToString)
            mof_ActivarOK(Me)
            Select Case wl_eGEMOV.sCodSer
                Case "OC"
                    Dim wl_frmRPT As New rptCOOC001
                    wl_frmRPT.wp_aeGEMOV = wl_aeGEMOV
                    wl_frmRPT.wp_aeGLMOV1 = wl_aeGLMOV1
                    wl_frmRPT.wp_aeATVEN = wl_aeATVEN
                    wl_frmRPT.wp_aeATVEN_Aut = wl_aeATVEN_Aut
                    wl_frmRPT.wp_aeTEDMT = wl_aeTEDMT
                    wl_frmRPT.wp_aeTLDMT1 = wl_aeTLDMT1
                    wl_frmRPT.wp_aeTLDMT4 = wl_aeTLDMT4
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.Show()
                Case "OS"
                    Dim wl_frmRPT As New rptCOOS001
                    wl_frmRPT.wp_aeGEMOV = wl_aeGEMOV
                    wl_frmRPT.wp_aeGLMOV1 = wl_aeGLMOV1
                    wl_frmRPT.wp_aeATVEN = wl_aeATVEN
                    wl_frmRPT.wp_aeATVEN_Aut = wl_aeATVEN_Aut
                    wl_frmRPT.wp_aeTEDMT = wl_aeTEDMT
                    wl_frmRPT.wp_aeTLDMT4 = wl_aeTLDMT4
                    wl_frmRPT.wp_aeTLDMT1 = wl_aeTLDMT1
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.Show()
                Case "SC"
                    Dim wl_frmRPT As New rptCOSC001
                    wl_frmRPT.wp_aeGEMOV = wl_aeGEMOV
                    wl_frmRPT.wp_aeGLMOV1 = wl_aeGLMOV1
                    wl_frmRPT.wp_aeATVEN = wl_aeATVEN
                    wl_frmRPT.wp_aeATVEN_Aut = wl_aeATVEN_Aut
                    wl_frmRPT.wp_aeTEDMT = wl_aeTEDMT
                    wl_frmRPT.wp_aeTLDMT4 = wl_aeTLDMT4
                    wl_frmRPT.wp_aeTLDMT1 = wl_aeTLDMT1
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
                '   If wl_cvTxt.Name = "txtnNroDoc" Then
                ' mov_VdaTxt(wl_bVda,
                '           txtnNroDoc)
                ' End If
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
                ' If wl_cvTxt.Name = "txtnNroDoc" Then
                ' mov_VdaTxt(wl_bVda,
                '            txtnNroDoc)
                ' End If
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
            If wl_eGEMOV.sEstDoc > "A" Then
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