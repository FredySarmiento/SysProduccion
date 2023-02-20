Public Class frmPELIM
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23


#Region "001 Inicia. wg - vg Definición del variables públicas"
    Public Property vp_sCodItm As String
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"

    Dim wl_bCmpVdo As Boolean
    Dim wl_bEdit As Boolean
    Dim wl_bSwsBor As Boolean
    Dim wl_bVda As Boolean
    Dim wl_bYesNo As Boolean

    Dim wl_nBoxMsg As Integer
    Dim wl_nColCVC As Integer
    Dim wl_nNroCol As Integer
    Dim wl_nResMsg As String
    Dim wl_nRowCVC As Integer


    Dim wl_sCmpOrdE11 As String
    Dim wl_sDatCmpE11 As String
    Dim wl_sDatCmpL11 As String
    Dim wl_sNomCmpE11 As String
    Dim wl_sNomCmpL11 As String
    Dim wl_sNomTblE1 As String
    Dim wl_sNomTblL1 As String
    Dim wl_sTipCmpE11 As String
    Dim wl_sTipCmpL11 As String
    Dim wl_sTipOrdE11 As String
    Dim wl_sTitCmpE11 As String
    Dim wl_sTitCmpL11 As String
    Dim wl_sCodItm As String
    Dim wl_sCodItmIni As String

    Dim wl_sNroALetras As String

    Dim wl_bEOF As Boolean
    Dim wp_bEOF1 As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wp_nNroOpc As Integer
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_sTipCmp As String

#End Region
#Region "012 BD - Variables campos BD Locales"

    Dim vp_nId As Integer
    Dim vl_sCodFor As String
    Dim vl_sCodItm As String
    Dim vl_sCodItmAnt As String
    Dim vl_sCodCmt As String
    Dim vl_sNomItm As String
    Dim vl_nCanLotStn As Double
    Dim vl_nCanUniStn As Double
    Dim vl_sUniMedInv As String
    Dim vl_sUniMedStn As String
    Dim vl_sTipLIM As String
    Dim vl_sCodAlm As String
    Dim vl_bRegAci As Boolean
    Dim vl_nPesItm As Double
    Dim vl_nPorItm As Double
    Dim vl_nCanCmtItm As Double
    Dim vl_nTieItm As Double
    Dim vl_nTotTieItm As Double
    Dim vl_sRegSan As String
    Dim vl_nPreVta As Double

    Dim vl_nCIFItm As Double
    Dim vl_nvlrItm As Double

    Dim vl_sDesCmt As String

    Dim vl_nCanCmt As Double
    Dim vl_nPesCmt As Double
    Dim vl_nPorCmt As Double


    Dim vl_sCodAlmCns As String
    Dim vl_sCodOpe As String
    Dim vl_sDesOpe As String
    Dim vl_nTieOpe As Double
    Dim vl_nPorOpe As Double
    Dim vl_sCodCtr As String

    Dim vl_sCodCIF As String
    Dim vl_sDesCIF As String
    Dim vl_nVlrCIFRea As Double


#End Region
#Region "013 DGV - Variables Locales"

    Dim wl_bVdaRow As Boolean
    Dim wl_nTab As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColFin1 As Integer
    Dim wl_nColFin2 As Integer
    Dim wl_nColFin3 As Integer
    Dim wl_nColFin4 As Integer
    Dim wl_nColIni1 As Integer
    Dim wl_nColIni2 As Integer
    Dim wl_nColIni3 As Integer
    Dim wl_nColIni4 As Integer
    Dim wl_nTotCol As Integer

    Dim wl_nColSig As Integer

    Dim vl_nTamCmp As Integer
    Dim wl_sNomFrm As String

    Dim wl_nCntRow As Integer
    Dim wl_nRow As Integer
    Dim wl_nCol As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nColAnt As Integer
    Dim wl_RowAlto As Integer
    Dim wl_nRowSig As Integer

    Dim wl_nCntCol As Integer

    Dim wl_nRowIni As Integer
    Dim wl_nRowVacia As Integer

    Dim wl_nTotCol1 As Integer
    Dim wl_nTotCol2 As Integer
    Dim wl_nTotCol3 As Integer
    Dim wl_nTotCol4 As Integer

    Dim wl_nRowKD As Integer
    Dim wl_nColKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nColKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nColKU As Integer
    Dim wl_nNroDgv As Integer
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col 
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fil

    Dim wl_sCodDgv As String
    Dim wl_CtrlDgv As DataGridView

    Dim wp_sTipCol As String 'N = numérico. C = pesos. S = string. d = fecha
    Dim wp_bVisible As Boolean
    Dim wp_bReadOnly As Boolean


#End Region
#Region "014 Objetos locales"
    ' objetos locales

    Dim clnPEFOM As New ClaseNegocios.clnPEFOM
    Dim clnPELIM As New ClaseNegocios.clnPELIM
    Dim clnPLFOM1 As New ClaseNegocios.clnPEFOM
    Dim clnPLLIM As New ClaseNegocios.clnPELIM
    Dim clnPLLIM1 As New ClaseNegocios.clnPELIM
    Dim clnPLLIM2 As New ClaseNegocios.clnPELIM
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI


    Dim vl_CtrlDgv As New DataGridView

#End Region
#Region "015 Estructuras"
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATCTR As New moe_Estructuras.eATCTR
    Dim vl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim vl_ePEFOM As New moe_Estructuras.ePEFOM
    Dim vl_ePLFOM1 As New moe_Estructuras.ePLFOM1
    Dim vl_eATCIF As New moe_Estructuras.eATCIF
    Dim vl_eATOPE As New moe_Estructuras.eATOPE
    Dim vl_Q_ePELIM_eIEDMI As New moe_Estructuras.Q_ePELIM_eIEDMI
    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aePLLIM1() As moe_Estructuras.ePLLIM1
    Dim wl_aePLLIM2() As moe_Estructuras.ePLLIM2
    Dim wl_aePLLIM3() As moe_Estructuras.ePLLIM3
    Dim wl_aePLLIM4() As moe_Estructuras.ePLLIM4
    Dim wl_ePELIM As New moe_Estructuras.ePELIM
    Dim wl_ePLLIM1 As New moe_Estructuras.ePLLIM1
    Dim wl_ePLLIM2 As New moe_Estructuras.ePLLIM2
    Dim wl_ePLLIM3 As New moe_Estructuras.ePLLIM3
    Dim wl_ePLLIM4 As New moe_Estructuras.ePLLIM4

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
    Private Sub frmPELIM_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error : frmPELIM_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPELIM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            mof_inhabTsbBuscar()
            mof_inhabTsbCrear()
            mof_inhabTsbPASU()
            mof_inhabTsbEliminar()
            mof_LmpMsgError()
            Plo_LiberarFrm()
            mof_LmpMsgError()
        Catch ex As Exception
            MsgBox("Error : frmPELIM_FormClosing")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmPELIM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_RemoveHandler()
            grl_AddHandler()
            mof_IniciarVar()
            Plo_IniciarVar()
            Plo_IniciarFrm()
            wg_sTipTbl = "E1"
            BD_DatPrmTipTbl(wg_sTipTbl)
            ' dgv_APDGV()
            Plo_IniciarVarDGV() '080
            grl_EventCtrl(Me)
            Cbo_CargarLst()
            Plo_ActivarBuscar()
            If vp_sCodItm <> "" Then
                mtbsCodItm.Text = vp_sCodItm
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : frmPELIM_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmPELIM_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mtbsCodItm.Focus()
    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarABLIM()
            Cbo_CargarACUNI()
            Cbo_CargarACUNIInv()
            cbo_cargarATALM()
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABLIM()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ABLIM"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboABLIM.DataSource = wg_DTLst1
                cboABLIM.ValueMember = wg_DTLst1.Columns("sCodLst").Caption.ToString
                cboABLIM.DisplayMember = wg_DTLst1.Columns("sDesLst").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABLIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarACUNI()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ACUNI"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACUNI.DataSource = wg_DTLst1
                cboACUNI.ValueMember = wg_DTLst1.Columns("sCodUni").Caption.ToString
                cboACUNI.DisplayMember = wg_DTLst1.Columns("sNomUni").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarACUNI")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarACUNIInv()
        Try
            '  cboABESD.Enabled = False
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ACUNI"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboACUNIInv.DataSource = wg_DTLst1
                cboACUNIInv.ValueMember = wg_DTLst1.Columns("sCodUni").Caption.ToString
                cboACUNIInv.DisplayMember = wg_DTLst1.Columns("sNomUni").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarACUNIInv")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Cbo_CargarATALM()
        Try
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATALM"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                  wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATALM.DataSource = wg_DTLst1
                cboATALM.ValueMember = wg_DTLst1.Columns("sCodAlm").Caption.ToString
                cboATALM.DisplayMember = wg_DTLst1.Columns("sCodAlm").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarATALM")
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            Dim wl_nI1 As Integer
            Plo_Var_frm()
            BD_ePELIM_Var()

            BD_BuscarATALM()
            If wr_bEOFE2 Then
                MsgBox("Código del Almacén es obligatorio")
                cboATALM.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            If wl_CtrlDgv.Name = "dgv1" Then
                wl_nNroDgv = 0
            End If
            If wl_CtrlDgv.Name = "dgv2" Then
                wl_nNroDgv = 1
            End If
            If wl_CtrlDgv.Name = "dgv3" Then
                wl_nNroDgv = 2
            End If
            If wl_CtrlDgv.Name = "dgv4" Then
                wl_nNroDgv = 3
            End If


            For wl_nI = 0 To wl_CtrlDgv.Rows.Count - 1
                wl_nI1 = wl_nI + 1
                If wl_nNroDgv = 0 Then
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodItm").Value = "" Then
                        Exit For
                    End If
                End If
                If wl_nNroDgv = 0 Then
                    If wl_CtrlDgv.Rows(wl_nI).Cells("sCodCmt").Value = "" Then
                        Exit For
                    End If
                    If wl_CtrlDgv.Rows(wl_nI).Cells("nCanCmt").Value = 0 Then
                        MsgBox("Línea Nro. " & wl_nI1.ToString & " tiene Cantidad de componente en 0")
                        wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanCmt")
                        Return wl_bYesNo
                    End If
                End If

            Next
            wg_bVdaE1 = True
            If Not mov_VdaMTB(wg_bVdaE1,
                              mtbsCodItm) Then

                mtbsCodItm.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            wl_bYesNo = clnPELIM.cnCrearActualizar(wl_ePELIM,
                                                   wr_bEOFE1,
                                                   wp_sCmdSel)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        Try
            wl_sNomTblE1 = "PELIM"
            wl_sNomCmpE11 = "sCodItm"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código ítem "
            wl_sDatCmpE11 = mtbsCodItm.Text
            wl_sNomTblL1 = "PLLIM1"
            wl_sNomCmpL11 = "sCodItm"
            wl_sTipCmpL11 = "C"
            wl_sTitCmpL11 = "Código ítem "
            wl_sDatCmpL11 = mtbsCodItm.Text
            wr_bEOFE1 = True
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
    Private Sub BD_ePELIM_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_ePELIM = New moe_Estructuras.ePELIM
            moo_ePELIM_DT(wl_ePELIM,
                          wp_DTE1,
                          wl_nRow)
            vl_sCodItm = wl_ePELIM.sCodItm

        Catch ex As Exception
            MsgBox("Error :  BD_ePELIM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_ePELIM_Var()
        Try
            wl_ePELIM = New moe_Estructuras.ePELIM
            ' wg_sClaPpl = vl_sCodItm
            wg_sClaPpl = mtbsCodItm.Text
            vl_sCodItm = mtbsCodItm.Text


            With wl_ePELIM
                .sCodItm = vl_sCodItm
                .sNomItm = vl_sNomItm
                .nCanLotStn = vl_nCanLotStn
                .sUniMedStn = vl_sUniMedStn
                .nCanUniStn = vl_nCanUniStn
                .sUniMedInv = vl_sUniMedInv
                .sTipLIM = vl_sTipLIM
                .sCodAlm = vl_sCodAlm
                .bRegAci = chbbRegAci.Checked
                .nPesItm = vl_nPesItm
                .nPorItm = vl_nPorItm
                .nTieItm = vl_nTieItm
                .nCIFItm = vl_nCIFItm
                .nVlrItm = vl_nvlrItm
                .sRegSan = vl_sRegSan
                .nPreVta = vl_nPreVta
            End With
        Catch ex As Exception
            MsgBox("Error :  BD_ePELIM_Var")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_Var_ePELIM()
        Try
            With wl_ePELIM
                wg_sClaPpl = .sCodItm
                mtbsCodItm.Text = .sCodItm
                vl_sCodItm = .sCodItm
                vl_sNomItm = .sNomItm
                vl_nCanLotStn = .nCanLotStn
                vl_sUniMedStn = .sUniMedStn
                vl_nCanUniStn = .nCanUniStn
                vl_sUniMedInv = .sUniMedInv
                vl_sTipLIM = .sTipLIM
                vl_sCodAlm = .sCodAlm
                vl_bRegAci = .bRegAci
                vl_nPesItm = .nPesItm
                vl_nPorItm = .nPorItm
                vl_nTieItm = .nTieItm
                vl_nCIFItm = .nCIFItm
                vl_nvlrItm = .nVlrItm
                vl_sRegSan = .sRegSan
                vl_nPreVta = .nPreVta
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ePELIM")
        End Try

    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"
    Private Sub BD_TipLIM()
        Try
        Catch ex As Exception
            MsgBox("Error :  BD_TipLIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_tsbPASU()
        Try
            mtbsCodItm.Text = wg_DTE1.Rows(0).Item("sCodItm")
            BD_BuscarPELIM()
            '  BD_ePELIM_DT(wg_DTE1)
            BD_BuscarIEDMI()
            BD_Var_ePELIM()
            Plo_frm_Var()

            ' dgv1.Enabled = True
            dgv_DGV_DT()
            mof_ActivarOK(Me)
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
            wr_bEOFE2 = mof_fConATALM(wl_ePELIM.sCodAlm,
                                      wl_eATALM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATALM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATCTR() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCTR = New moe_Estructuras.eATCTR
            wr_bEOFE2 = mof_fConATCTR(vl_sCodCtr,
                                      wl_eATCTR)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Try")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarIEDMI() As Boolean
        Try
            wr_bEOFE2 = True
            vl_eIEDMI = New moe_Estructuras.eIEDMI
            wr_bEOFE2 = mof_fConIEDMI(vl_sCodItm,
                                      vl_eIEDMI)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarIEDMI")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPEFOM() As Boolean
        Try
            wr_bEOFE2 = True
            vl_ePEFOM = New moe_Estructuras.ePEFOM
            wr_bEOFE2 = mof_fConPEFOM(vl_sCodItm,
                                      vl_ePEFOM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPEFOM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarPELIM() As Boolean
        Try
            wr_bEOFE2 = True
            vl_sCodItm = mtbsCodItm.Text
            wl_ePELIM = New moe_Estructuras.ePELIM
            wr_bEOFE2 = mof_fConPELIM(vl_sCodItm,
                                      wl_ePELIM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPELIM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATCIF() As Boolean
        Try
            wr_bEOFE2 = True
            vl_eATCIF = New moe_Estructuras.eATCIF
            wr_bEOFE2 = mof_fConATCIF(vl_sCodCIF,
                                      vl_eATCIF)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCIF")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATOPE() As Boolean
        Try
            wr_bEOFE2 = True
            vl_eATOPE = New moe_Estructuras.eATOPE
            wr_bEOFE2 = mof_fConATOPE(vl_sCodOpe,
                                      vl_eATOPE)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATOPE")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "043 BD Cargar"
    Private Sub BD_CargarATALM(ByVal wl_CellCod As Integer)
        Try
            BD_frmGQLstATALM()
            dgv1.CurrentRow.Cells("sCodAlmCns").Value = wl_eATALM.sCodAlm
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellCod)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATALM")
        End Try

    End Sub
    Private Sub BD_CargarIEDMI(ByVal wp_nCol As Integer)
        Try
            BD_frmGQLstIEDMI()
            dgv1.CurrentRow.Cells("sCodCmt").Value = vl_eIEDMI.sCodItm
            If dgv1.CurrentRow.Cells("sNomCmt").Visible = True Then
                dgv1.CurrentRow.Cells("sNomCmt").Value = vl_eIEDMI.sNomItm
            End If
            dgv1.CurrentRow.Cells("sUniMedInv").Value = vl_eIEDMI.sUniMedInv
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wp_nCol)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarIEDMI")
        End Try

    End Sub
    Private Sub BD_CargarPEFOM(ByVal wp_nCol As Integer)
        Try


            BD_frmGQLstPEFOM()
            dgv4.CurrentRow.Cells("sCodCmt").Value = vl_ePEFOM.sCodItm
            If dgv4.CurrentRow.Cells("sNomCmt").Visible = True Then
                dgv4.CurrentRow.Cells("sNomCmt").Value = vl_ePEFOM.sNomItm
            End If
            dgv4.CurrentRow.Cells("sUniMedInv").Value = vl_ePEFOM.sUniMedInv
            dgv4.CurrentCell = dgv4.CurrentRow.Cells(wp_nCol)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarPEFOM")
        End Try

    End Sub
    Private Sub BD_CargarATCIF(ByVal wl_CellCod As Integer)
        Try
            BD_frmGQLstATCIF()
            dgv3.CurrentRow.Cells("sCodCIF").Value = vl_eATCIF.sCodCIF
            dgv3.CurrentRow.Cells("sNomCIF").Value = vl_eATCIF.sNomCIF
            dgv3.CurrentCell = dgv3.CurrentRow.Cells(wl_CellCod)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATCIF")
        End Try

    End Sub
    Private Sub BD_CargarATOPE(ByVal wl_CellCod As Integer)
        Try
            BD_frmGQLstATOPE()
            dgv2.CurrentRow.Cells("sCodOPE").Value = vl_eATOPE.sCodOpe
            dgv2.CurrentRow.Cells("sNomOPE").Value = vl_eATOPE.sNomOpe
            dgv2.CurrentRow.Cells("sCodCtr").Value = vl_eATOPE.sCodCtr
            dgv2.CurrentCell = dgv2.CurrentRow.Cells(wl_CellCod)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATOPE")
        End Try
    End Sub
#End Region
#Region "045 BD Llamar frm"
    Private Sub BD_frmGQLstATALM()
        Try
            Dim wl_frmLst As New frmGQLst
            wl_eATALM = New moe_Estructuras.eATALM
            wg_sTblCon1 = "ATALM"
            wg_sCmpCon11 = "sCodAlm"
            wg_sCmpCon12 = "sNomAlm"
            wg_sTitCon11 = "Código almacén"
            wg_sTitCon12 = "Nombre almacén"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.ShowDialog()
            wl_eATALM = wl_frmLst.wp_eATALM
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmATALM")
        End Try

    End Sub
    Private Sub BD_frmGQLstIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "IEDMI"
            wg_sCmpCon11 = "sCodItm"
            wg_sCmpCon12 = "sDesItm"
            wg_sTitCon11 = "Código ítem"
            wg_sTitCon12 = "Descripción ítem"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI
            wl_frmLst.ShowDialog()
            vl_eIEDMI = wl_frmLst.wp_eIEDMI
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmIEDMI")
        End Try

    End Sub
    Private Sub BD_frmGQLstPEFOM()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "PEFOM"
            wl_frmLst.wp_ePEFOM = New moe_Estructuras.ePEFOM
            vl_ePEFOM = New moe_Estructuras.ePEFOM
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_ePEFOM.sCodItm <> "" Then
                vl_ePEFOM = wl_frmLst.wp_ePEFOM
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmPEFOM")
        End Try

    End Sub
    Private Sub BD_frmGQLstPELIM()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "PELIM"
            wl_frmLst.wp_Q_ePELIM_eIEDMI = New moe_Estructuras.Q_ePELIM_eIEDMI
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_Q_ePELIM_eIEDMI.ePELIM.sCodItm <> "" Then
                wl_ePELIM = New moe_Estructuras.ePELIM
                vl_Q_ePELIM_eIEDMI = New moe_Estructuras.Q_ePELIM_eIEDMI
                vl_Q_ePELIM_eIEDMI = wl_frmLst.wp_Q_ePELIM_eIEDMI
                wl_ePELIM = wl_frmLst.wp_Q_ePELIM_eIEDMI.ePELIM

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmGQLstPELIM")
        End Try

    End Sub
    Private Sub BD_frmGQLstATCIF()
        Try
            Dim wl_frmLst As New frmGQLst
            vl_eATCIF = New moe_Estructuras.eATCIF
            wg_sTblCon1 = "ATCIF"
            wg_sCmpCon11 = "sCodCIF"
            wg_sCmpCon12 = "sDesCIF"
            wg_sTitCon11 = "Código CIF"
            wg_sTitCon12 = "Nombre CIF"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.ShowDialog()
            vl_eATCIF = wl_frmLst.wp_eATCIF
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmATCIF")
        End Try
    End Sub
    Private Sub BD_frmGQLstATOPE()
        Try
            Dim wl_frmLst As New frmGQLst
            vl_eATOPE = New moe_Estructuras.eATOPE
            wg_sTblCon1 = "ATOPE"
            wg_sCmpCon11 = "sCodOPE"
            wg_sCmpCon12 = "sDesOPE"
            wg_sTitCon11 = "Código OPE"
            wg_sTitCon12 = "Nombre OPE"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True

            wl_frmLst.ShowDialog()
            vl_eATOPE = wl_frmLst.wp_eATOPE
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmATOPE")
        End Try

    End Sub
#End Region
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
            mof_MsgError(wl_sNomTblE1,
                         wp_sDatCmp,
                         wp_sCodErr)
            mof_ActivarOK(Me)
            wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
            mof_ActivarOK(Me)
            Plo_InactCmpAct()
            cmdOk.Focus()
        Else
            txtsNomItm.Focus()
        End If
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            Dim clnPELIM As New ClaseNegocios.clnPELIM

            wp_sCmdSel = "B"
            wl_bYesNo = False
            mof_LmpMsgError()
            If mtbsCodItm.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wl_sCmpOrdE11 = ""
                wl_sTipOrdE11 = ""
                '     wg_DTE1 = mof_fConTbl(wl_sNomTblE1,
                '                           wl_sNomCmpE11,
                '                           wl_sDatCmpE11,
                '                           wl_sTipCmpE11,
                '                           wl_sCmpOrdE11,
                '                           wl_sTipOrdE11,
                '                           wr_bEOFE1)
                wg_DTE1 = clnPELIM.cndtConsultarPELIM(wl_sDatCmpE11,
                                                      wr_bEOFE1)
                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = wg_sCodErrCon
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    mtbsCodItm.Focus()
                Else
                    BD_ePELIM_DT(wg_DTE1)
                    BD_BuscarIEDMI()

                    BD_Var_ePELIM()
                    Plo_frm_Var()
                    mof_fLmpCtrl(Me.dgv1)
                    mof_fLmpCtrl(Me.dgv2)
                    mof_fLmpCtrl(Me.dgv3)
                    mof_fLmpCtrl(Me.dgv4)
                    dgv_DGV_DT()
                    mof_ActivarOK(Me)
                    mof_habTsbEliminar()
                    mtbsCodItm.Enabled = False
                    txtsNomItm.Focus()
                End If
            Else
                mtbsCodItm.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        wp_sCmdSel = "C"
        wl_bYesNo = False
        mof_LmpMsgError()
        If mtbsCodItm.Text <> "" Then
            BD_DatPrmTipTbl(wg_sTipTbl)
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wg_DTE1 = mof_fConTbl(wl_sNomTblE1,
                                  wl_sNomCmpE11,
                                  wl_sDatCmpE11,
                                  wl_sTipCmpE11,
                                  wl_sCmpOrdE11,
                                  wl_sTipOrdE11,
                                  wr_bEOFE1)
            If wr_bEOFE1 Then
                ' BD_ePELIM_Var()
                wl_CtrlDgv = Me.dgv1
                wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                If wl_bYesNo Then
                    wl_bYesNo = dgv_ActualizarDetalle(wp_sCmdSel)
                    wp_sNomTbl = wg_sNomTblE1
                    wp_sDatCmp = ""
                    wp_sCodErr = wg_sCodErrOk
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mof_ActivarOK(Me)
                    mof_habTsbCrear()
                    mof_habTsbEliminar()
                    Plo_InactCmpAct()
                    cmdOk.Focus()
                End If
            Else
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = mtbsCodItm.Text
                wp_sCodErr = wg_sCodErrAdi
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                mtbsCodItm.Focus()

            End If

        End If
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        wp_sCmdSel = "E"
        wl_bYesNo = False
        mof_LmpMsgError()
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
                wg_sCmpOrdE11 = ""
                wg_sTipOrdE11 = ""
                wg_DTE1 = clnConTbl.cndtBuscar(wl_sNomTblE1,
                                               wl_sNomCmpE11,
                                               wl_sDatCmpE11,
                                               wl_sTipCmpE11,
                                               wl_sCmpOrdE11,
                                               wl_sTipOrdE11,
                                               wr_bEOFE1)
                If Not wr_bEOFE1 Then

                    wp_sNomTbl = ""
                    wl_bYesNo = mov_VdasCodFor(vl_sCodItm,
                                               wp_sNomTbl,
                                               wl_bVda)

                    If wl_bVda = True Then
                        wl_bYesNo = clnPELIM.cnEliminar(vl_sCodItm,
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
                            Plo_InactCmpAct()
                            cmdOk.Focus()
                        Else
                            txtsNomItm.Focus()
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
    Private Sub cmdLstIEDMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstIEDMI.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmGQLstIEDMI()
            mtbsCodItm.Text = vl_eIEDMI.sCodItm
            txtsNomItm.Text = vl_eIEDMI.sNomItm
            mtbsCodItm.Focus()
        Catch ex As Exception
            MsgBox("Error en: cmdLstIEDMI_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdLstPELIM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstPELIM.Click
        Try
            Dim wl_frmLst As New frmGQLst
            BD_frmGQLstPELIM()
            If wl_ePELIM.sCodItm <> "" Then
                mtbsCodItm.Text = wl_ePELIM.sCodItm
                txtsNomItm.Text = wl_ePELIM.sNomItm
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
            mtbsCodItm.Focus()
        Catch ex As Exception
            MsgBox("Error en: cmdLstPELIM_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCpd_Click(sender As System.Object, e As System.EventArgs) Handles cmdCpd.Click
        Try
            Dim wl_nRow As Integer
            wp_bEOF1 = False
            wp_bEOF2 = False
            wr_bEOFE2 = False
            Plo_VdaCrear()
            If wp_bEOF1 = True Then
                mtbsCodItm.Focus()
                Exit Sub
            End If
            If wp_bEOF2 = False Then
                mtbsCodItm.Focus()
                Exit Sub
            End If


            Dim wl_frmPELIM_LeeLIM As New frmPELIM_LeeLIM
            wl_frmPELIM_LeeLIM.wp_sCoditmIni = ""
            wl_frmPELIM_LeeLIM.ShowDialog()
            wl_sCodItm = vl_sCodItm
            wl_sCodItmIni = wl_frmPELIM_LeeLIM.wp_sCoditmIni


            'mof_fLmpCtrl(Me)
            Plo_IniciarVarDGV()

            If wl_sCodItmIni <> "" Then
                vl_sCodItm = wl_sCodItmIni
                wl_sDatCmpE11 = wl_sCodItmIni
                BD_DatPrmTipTbl(wg_sTipTbl)
                wg_DTE1 = clnPELIM.cndtConsultarPELIM(wl_sCodItmIni,
                                                     wr_bEOFE1)

                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = wl_sCodItmIni
                    wp_sCodErr = "10-101"
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    cmdCpd.Focus()
                Else
                    BD_ePELIM_DT(wg_DTE1)
                    '   BD_BuscarIEDMI()
                    wl_ePELIM.sCodItm = wl_sCodItmIni
                    wl_ePELIM.sNomItm = ""
                    mtbsCodItm.Text = wl_sCodItmIni
                    BD_Var_ePELIM()
                    mof_fLmpCtrl(Me.dgv1)
                    mof_fLmpCtrl(Me.dgv2)
                    mof_fLmpCtrl(Me.dgv3)
                    mof_fLmpCtrl(Me.dgv4)
                  
                    dgv_DGV_DT()

                    For wl_nRow = 0 To dgv1.RowCount - 1
                        If dgv1.Rows(wl_nRow).ReadOnly = True Then
                            Continue For
                        End If
                        If dgv1.Rows(wl_nRow).Cells("sCodCmt").Value <> Nothing Then
                            dgv1.Rows(wl_nRow).Cells("nId").Value = 0
                        End If
                    Next
                    mtbsCodItm.Text = wl_sCodItm
                    txtsNomItm.Text = ""
                    mtbsCodItm.Enabled = False
                    vl_sCodItm = wl_sCodItm
                    Plo_frm_Var()
                    dgv_sCodItm()
                    txtsNomItm.Focus()

                End If
            End If
        Catch ex As Exception
            MsgBox("Error : cmdCpd_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "070 DGV "
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Try
            dgv_ActualizarDetalle1(wp_sCmdSel)
            dgv_ActualizarDetalle2(wp_sCmdSel)
            dgv_ActualizarDetalle3(wp_sCmdSel)
            dgv_ActualizarDetalle4(wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error :  dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
    Private Function dgv_ActualizarDetalle1(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String

        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text

            For wl_nRow = 0 To dgv1.RowCount - 1
                If dgv1.Rows(wl_nRow).ReadOnly = True Then
                    Continue For
                End If
                If dgv1.Rows(wl_nRow).Cells("sCodCmt").Value <> Nothing Then
                    wp_sCmdSel = wl_sCmdAnt
                    dgv1.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
                    wl_ePLLIM1 = New moe_Estructuras.ePLLIM1
                    moo_ePLLIM1_DGV(wl_ePLLIM1,
                                    Me.dgv1,
                                    wl_nRow)
                    '                  
                    If wl_ePLLIM1.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv1.Rows(wl_nRow).Visible = True Then

                        If dgv1.Rows(wl_nRow).Cells("sCodAlmCns").Value <> Nothing Then
                            wl_bYesNo = clnPELIM.cnCrearActualizarPLLIM1(wl_ePLLIM1,
                                                                         wr_bEOFL1,
                                                                         wp_sCmdSel)
                        End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPELIM.cnEliminarPLLIM1(wl_ePLLIM1,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle1")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Function dgv_ActualizarDetalle2(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text

            For wl_nRow = 0 To dgv2.RowCount - 1
                If dgv2.Rows(wl_nRow).Cells("sCodOpe").Value <> Nothing Then
                    dgv2.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLLIM2 = New moe_Estructuras.ePLLIM2
                    moo_ePLLIM2_DGV(wl_ePLLIM2,
                                    Me.dgv2,
                                    wl_nRow)
                    If wl_ePLLIM2.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv2.Rows(wl_nRow).Visible = True Then
                        wl_bYesNo = clnPELIM.cnCrearActualizarPLLIM2(wl_ePLLIM2,
                                                                     wr_bEOFL1,
                                                                     wp_sCmdSel)
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPELIM.cnEliminarPLLIM2(wl_ePLLIM2,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle2")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Function dgv_ActualizarDetalle3(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text

            For wl_nRow = 0 To dgv3.RowCount - 1
                If dgv3.Rows(wl_nRow).Cells(2).Value <> Nothing Then
                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLLIM3 = New moe_Estructuras.ePLLIM3
                    dgv3.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
                    dgv3.Rows(wl_nRow).Cells("nTasCIF").Value = vl_nTieItm
                    moo_ePLLIM3_DGV(wl_ePLLIM3,
                                    Me.dgv3,
                                    wl_nRow)
                    If wl_ePLLIM3.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv3.Rows(wl_nRow).Visible = True Then

                        wl_bYesNo = clnPELIM.cnCrearActualizarPLLIM3(wl_ePLLIM3,
                                                                     wr_bEOFL1,
                                                                     wp_sCmdSel)
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPELIM.cnEliminarPLLIM3(wl_ePLLIM3,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle3")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Function dgv_ActualizarDetalle4(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text

            For wl_nRow = 0 To dgv4.RowCount - 1
                If dgv4.Rows(wl_nRow).Cells("sCodCmt").Value <> Nothing Then
                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLLIM4 = New moe_Estructuras.ePLLIM4
                    dgv4.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
                    moo_ePLLIM1_DGV(wl_ePLLIM4,
                                    Me.dgv4,
                                    wl_nRow)
                    '                  
                    If wl_ePLLIM4.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv4.Rows(wl_nRow).Visible = True Then
                        If dgv4.Rows(wl_nRow).Cells("sCodAlmCns").Value <> Nothing Then
                            wl_bYesNo = clnPELIM.cnCrearActualizarPLLIM4(wl_ePLLIM4,
                                                                         wr_bEOFL1,
                                                                         wp_sCmdSel)
                        End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPELIM.cnEliminarPLLIM4(wl_ePLLIM4,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle4")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_AdiRow(ByVal vl_VlrCtrl As DataGridView)
        Try
            wl_nTab = 0
            With vl_VlrCtrl
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
                .Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
            End With
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_nCol = wl_nColIniGrl
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV_DT()
        Try

            dgv_DGV1_DT_PLFOM1()
            dgv_DGV1_DT()
            dgv_DGV2_DT()
            dgv_DGV3_DT()
            dgv_DGV4_DT()
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV1_DT()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_sCodItmAnt = vl_sCodItm
        vl_CtrlDgv = Me.dgv1
        wl_nColIniGrl = wl_nColIni1
        Try
            wg_DTL1 = clnPELIM.cndtConsultarPLLIM1(vl_sCodItm,
                                                  wr_bEOFL1)
            'If vl_CtrlDgv.Rows.Count > 0 Then
            'vl_CtrlDgv.Rows.Clear()
            'End If
            If Not wr_bEOFL1 Then
                With dgv1
                    wl_nRowIni = dgv1.Rows.Count
                    If wl_nRowIni = 0 Then
                        ReDim wl_aePLLIM1(wg_DTL1.Rows.Count - 1)
                    End If

                    '
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow(dgv1)
                        '  moo_DGV_DTePLLIM1(vl_CtrlDgv,
                        '                      wg_DTL1,
                        '                      wl_nRowIni)
                        .Rows(wl_nRowIni).Cells("nId").Value = wg_DTL1.Rows(wl_nRow).Item("T0.nId")
                        .Rows(wl_nRowIni).Cells("sCodItm").Value = wg_DTL1.Rows(wl_nRow).Item("T0.sCodItm")
                        .Rows(wl_nRowIni).Cells("sCodCmt").Value = wg_DTL1.Rows(wl_nRow).Item("sCodCmt")
                        .Rows(wl_nRowIni).Cells("nCanCmt").Value = wg_DTL1.Rows(wl_nRow).Item("nCanCmt")
                        .Rows(wl_nRowIni).Cells("nPesCmt").Value = wg_DTL1.Rows(wl_nRow).Item("nPesCmt")
                        .Rows(wl_nRowIni).Cells("nPorCmt").Value = wg_DTL1.Rows(wl_nRow).Item("nPorCmt")
                        .Rows(wl_nRowIni).Cells("nPreUni").Value = wg_DTL1.Rows(wl_nRow).Item("T2.nPreUni")
                        .Rows(wl_nRowIni).Cells("sUniMedInv").Value = wg_DTL1.Rows(wl_nRow).Item("T0.sUniMedInv")
                        .Rows(wl_nRowIni).Cells("sCodAlmCns").Value = wg_DTL1.Rows(wl_nRow).Item("sCodAlmCns")
                        .Rows(wl_nRowIni).Cells("sTipCmt").Value = wg_DTL1.Rows(wl_nRow).Item("sTipCmt")
                        .Rows(wl_nRowIni).Cells("sCodCmtAlt").Value = wg_DTL1.Rows(wl_nRow).Item("sCodCmtAlt")
                        .Rows(wl_nRowIni).Cells("bItmAct").Value = wg_DTL1.Rows(wl_nRow).Item("T0.bItmAct")

                        vl_sCodItm = .Rows(wl_nRowIni).Cells("sCodCmt").Value
                        BD_BuscarIEDMI()
                        .Rows(wl_nRowIni).Cells("sNomCmt").Value = vl_eIEDMI.sNomItm
                        vl_sCodItm = vl_sCodItmAnt
                        wl_ePLLIM1 = New moe_Estructuras.ePLLIM1
                        moo_ePLLIM1_DT(wl_ePLLIM1,
                                       wg_DTL1,
                                       wl_nRow)
                        wl_ePLLIM1.sNomCmt = vl_eIEDMI.sNomItm
                        wl_aePLLIM1(wl_nRow) = wl_ePLLIM1
                        wl_nRowIni = wl_nRowIni + 1
                    Next
                End With
            Else
                dgv_AdiRow(vl_CtrlDgv)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV1_DT_PLFOM1()
        Dim wl_nRow As Integer
        wl_CtrlDgv = Me.dgv1
        vl_sCodItm = mtbsCodItm.Text
        vl_sCodFor = ""
        wl_nColIniGrl = wl_nColIni1
        wr_bEOFL1 = True
        Try


            wg_DTL1 = clnPELIM.cndtConsultarPLLIM4(vl_sCodItm,
                                                   wr_bEOFL1)
            If dgv1.Rows.Count > 0 Then
                dgv1.Rows.Clear()
            End If
            If Not wr_bEOFL1 Then
                If wg_DTL1.Rows(wl_nRow).Item("bItmAct") = True Then

                    vl_sCodFor = wg_DTL1.Rows(0).Item("sCodCmt")
                    wg_DTL1 = clnPEFOM.cndtConsultarPLFOM1(vl_sCodFor,
                                                           wr_bEOFL1)
                    If Not wr_bEOFL1 Then
                        With dgv1
                            ReDim wl_aePLLIM1(wg_DTL1.Rows.Count - 1)
                            wl_nRowIni = dgv1.Rows.Count
                            wl_nRow = dgv1.Rows.Count
                            For wl_nRowDT = 0 To wg_DTL1.Rows.Count - 1
                                If wg_DTL1.Rows(wl_nRowDT).Item("T0.bItmAct") = True Then
                                    dgv_AdiRow(dgv1)
                                    .Rows(wl_nRow).ReadOnly = True
                                    If .Rows(wl_nRow).ReadOnly = True Then
                                        .Rows(wl_nRow).DefaultCellStyle.BackColor = wg_ClrEnableT
                                    Else
                                        .Rows(wl_nRow).DefaultCellStyle.BackColor = wg_ClrEnableF
                                    End If
                                    .Rows(wl_nRow).Cells("nId").Value = wg_DTL1.Rows(wl_nRowDT).Item("T0.nId")
                                    .Rows(wl_nRow).Cells("sCodItm").Value = wg_DTL1.Rows(wl_nRowDT).Item("T0.sCodItm")
                                    .Rows(wl_nRow).Cells("sCodCmt").Value = wg_DTL1.Rows(wl_nRowDT).Item("sCodCmt")
                                    .Rows(wl_nRow).Cells("sNomCmt").Value = wg_DTL1.Rows(wl_nRowDT).Item("sNomItm")
                                    .Rows(wl_nRow).Cells("nCanCmt").Value = wg_DTL1.Rows(wl_nRowDT).Item("nCanCmt")
                                    .Rows(wl_nRow).Cells("nPesCmt").Value = wg_DTL1.Rows(wl_nRowDT).Item("nPesCmt")
                                    .Rows(wl_nRow).Cells("nPorCmt").Value = wg_DTL1.Rows(wl_nRowDT).Item("nPorCmt")
                                    .Rows(wl_nRow).Cells("nPreUni").Value = wg_DTL1.Rows(wl_nRowDT).Item("T2.nPreUni")
                                    .Rows(wl_nRow).Cells("sUniMedInv").Value = wg_DTL1.Rows(wl_nRowDT).Item("T0.sUniMedInv")
                                    .Rows(wl_nRow).Cells("sCodAlmCns").Value = wg_DTL1.Rows(wl_nRow).Item("sCodAlmCns")
                                    .Rows(wl_nRow).Cells("sTipCmt").Value = wg_DTL1.Rows(wl_nRowDT).Item("sTipCmt")
                                    .Rows(wl_nRow).Cells("sCodCmtAlt").Value = wg_DTL1.Rows(wl_nRowDT).Item("sCodCmtAlt")
                                    .Rows(wl_nRow).Cells("bItmAct").Value = wg_DTL1.Rows(wl_nRowDT).Item("T0.bItmAct")
                                    wl_ePLLIM1 = New moe_Estructuras.ePLLIM1
                                    moo_ePLLIM1_DT(wl_ePLLIM1,
                                                   wg_DTL1,
                                                   wl_nRowDT)
                                    wl_aePLLIM1(wl_nRow) = wl_ePLLIM1
                                    wl_nRowIni = wl_nRowIni + 1
                                    wl_nRow = wl_nRow + 1
                                End If

                            Next
                        End With
                    Else
                        '          dgv_AdiRow(wl_CtrlDgv)
                    End If

                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: dgv_DGV1_DT_PLFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV2_DT()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv2
        Try
            wg_DTL1 = clnPELIM.cndtConsultarPLLIM2(vl_sCodItm,
                                                  wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If
            wl_nColIniGrl = wl_nColIni2
            If Not wr_bEOFL1 Then
                With dgv2
                    ReDim wl_aePLLIM2(wg_DTL1.Rows.Count - 1)

                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow(vl_CtrlDgv)
                        moo_DGV_DTePLLIM2(vl_CtrlDgv,
                                          wg_DTL1,
                                          wl_nRow)
                        vl_sCodOpe = dgv2.Rows(wl_nRow).Cells("sCodOpe").Value
                        BD_BuscarATOPE()
                        dgv2.Rows(wl_nRow).Cells("sNomOpe").Value = vl_eATOPE.sNomOpe
                        wl_ePLLIM2 = New moe_Estructuras.ePLLIM2
                        moo_ePLLIM2_DT(wl_ePLLIM2,
                                       wg_DTL1,
                                       wl_nRow)
                        wl_aePLLIM2(wl_nRow) = wl_ePLLIM2
                    Next
                End With
            Else
                dgv_AdiRow(vl_CtrlDgv)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV3_DT()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv3
        wl_nColIniGrl = wl_nColIni3
        Try
            wg_DTL1 = clnPELIM.cndtConsultarPLLIM3(vl_sCodItm,
                                                  wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv3
                    ReDim wl_aePLLIM3(wg_DTL1.Rows.Count - 1)

                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow(vl_CtrlDgv)
                        moo_DGV_DTePLLIM3(vl_CtrlDgv,
                                          wg_DTL1,
                                          wl_nRow)
                        vl_sCodCIF = dgv3.Rows(wl_nRow).Cells("sCodCIF").Value
                        BD_BuscarATCIF()
                        dgv3.Rows(wl_nRow).Cells("sNomCIF").Value = vl_eATCIF.sNomCIF
                        wl_ePLLIM3 = New moe_Estructuras.ePLLIM3
                        moo_ePLLIM3_DT(wl_ePLLIM3,
                                       wg_DTL1,
                                       wl_nRow)
                        wl_aePLLIM3(wl_nRow) = wl_ePLLIM3
                    Next
                End With
            Else
                dgv_AdiRow(vl_CtrlDgv)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV4_DT()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_sCodItmAnt = vl_sCodItm
        vl_CtrlDgv = Me.dgv4
        wl_nColIniGrl = wl_nColIni4
        Try
            wg_DTL1 = clnPELIM.cndtConsultarPLLIM4(vl_sCodItm,
                                                  wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv4

                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow(vl_CtrlDgv)
                        moo_DGV_DTePLLIM4(vl_CtrlDgv,
                                          wg_DTL1,
                                          wl_nRow)
                        vl_sCodItm = dgv4.Rows(wl_nRow).Cells("sCodCmt").Value
                        BD_BuscarPEFOM()
                        dgv4.Rows(wl_nRow).Cells("sNomCmt").Value = vl_ePEFOM.sNomItm
                        vl_sCodItm = vl_sCodItmAnt
                    Next
                End With
            Else
                dgv_AdiRow(vl_CtrlDgv)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV4_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function dgv1_VdaRow(ByRef wl_bVdaRow) As Boolean
        Try
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            wl_nCol = wl_CtrlDgv.CurrentCellAddress.X
            If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then

                '                wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
                '               wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then
                ' wl_bVdaRow = False
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_VdaRow")
            MsgBox(ex.Message)
        End Try
        Return wl_bVdaRow
    End Function
    Private Sub dgv_PorLinPLLIM1()
        'fec_ult_act = 2014.10.27
        Dim wl_nCntRow As Integer

        Try

            vl_nPesItm = 0
            vl_nPorItm = 0
            vl_nCanCmtItm = 0
            wl_CtrlDgv = dgv1
            wl_nCntRow = wl_CtrlDgv.Rows.Count

            wl_ePLLIM1 = New moe_Estructuras.ePLLIM1


            For wl_i = 0 To wl_nCntRow - 1
                If dgv1.Rows(wl_i).Visible = True Then
                    vl_nPesItm = vl_nPesItm + dgv1.Rows(wl_i).Cells("nPesCmt").Value
                    vl_nCanCmtItm = vl_nCanCmtItm + dgv1.Rows(wl_i).Cells("nCanCmt").Value
                End If

            Next
            For wl_i = 0 To wl_nCntRow - 1
                vl_nPorCmt = 0
                If dgv1.Rows(wl_i).Visible = True Then
                    If vl_nCanCmtItm <> 0 Then
                        vl_nPorCmt = (vl_nPesItm + wl_CtrlDgv.Rows(wl_i).Cells("nCanCmt").Value / vl_nCanCmtItm) * 100
                        wl_CtrlDgv.Rows(wl_i).Cells("nPorCmt").Value = vl_nPorCmt
                        vl_nPorItm = vl_nPorItm + vl_nPorCmt
                    End If
                End If
            Next
            dgv_TotPELIM()

        Catch ex As Exception
            MsgBox("Error: dgv_PorLinPLLIM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotPELIM()
        Try
            txtnCIFItm.Text = FormatNumber(vl_nCIFItm, 2)
            txtnPesItm.Text = FormatNumber(vl_nPesItm, 2)
            txtnTieItm.Text = FormatNumber(vl_nTieItm, 2)
            txtnTotTieItm.Text = FormatNumber(vl_nTieItm * vl_nCanUniStn / 60, 2)
        Catch ex As Exception
            MsgBox("Error: dgv_TotPELIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_SumLinPLLIM2()
        'fec_ult_act = 2014.11.12
        Dim wl_nCntRow As Integer
        Try
            wl_CtrlDgv = Me.dgv2

            vl_nTieItm = 0
            vl_nCIFItm = 0

            wl_nCntRow = wl_CtrlDgv.Rows.Count

            For wl_i = 0 To wl_nCntRow - 1
                If wl_CtrlDgv.Rows(wl_i).Visible = True Then
                    If wl_CtrlDgv.Rows(wl_i).Cells("bItmAct").Value = True Then
                        vl_nTieItm = vl_nTieItm + wl_CtrlDgv.Rows(wl_i).Cells("nTieOpe").Value
                        vl_nCIFItm = vl_nCIFItm + wl_CtrlDgv.Rows(wl_i).Cells("nTieOpe").Value
                    End If
                End If
            Next
            For wl_i = 0 To wl_nCntRow - 1
                If wl_CtrlDgv.Rows(wl_i).Visible = True Then
                    vl_nPorOpe = 0
                    If vl_nTieItm <> 0 Then
                        If wl_CtrlDgv.Rows(wl_i).Cells("bItmAct").Value = True Then
                            vl_nPorOpe = (wl_CtrlDgv.Rows(wl_i).Cells("nTieOpe").Value / vl_nTieItm) * 100
                        Else
                            vl_nPorOpe = 0
                        End If
                        wl_CtrlDgv.Rows(wl_i).Cells("nPorOpe").Value = vl_nPorOpe
                        wl_CtrlDgv.Rows(wl_i).Cells("nTotTieOpe").Value = wl_CtrlDgv.Rows(wl_i).Cells("nTieOpe").Value * wl_CtrlDgv.Rows(wl_i).Cells("nPreUni").Value
                    End If
                End If

            Next

            '          dgv_TotPELIM()

        Catch ex As Exception
            MsgBox("Error: dgv_SumLinPLLIM2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_SumLinPLLIM3()
        'fec_ult_act = 2014.11.12
        Dim wl_nCntRow As Integer
        Try
            wl_CtrlDgv = Me.dgv3

            vl_nCIFItm = 0

            wl_nCntRow = wl_CtrlDgv.Rows.Count


            For wl_i = 0 To wl_nCntRow - 1
                vl_nCIFItm = vl_nCIFItm + wl_CtrlDgv.Rows(wl_i).Cells("nTasCIF").Value
            Next
            '      dgv_TotPELIM()

        Catch ex As Exception
            MsgBox("Error: dgv_SumLinPLLIM3")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_sCodItm()
        Try
            Dim wl_nRow As Integer

            Dim wl_nRowDgv As Integer
            wl_nRow = 0
            wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            wl_CtrlDgv = Me.dgv1
            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nRowDgv
                    .Rows(wl_nRow).Cells("nId").Value = 0
                    .Rows(wl_nRow).Cells("sCodItm").Value = vl_sCodItm
                Next

            End With
            wl_CtrlDgv = Me.dgv2
            wl_nRow = 0
            wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nRowDgv
                    .Rows(wl_nRow).Cells("nId").Value = 0
                    .Rows(wl_nRow).Cells("sCodItm").Value = vl_sCodItm
                Next
            End With
            wl_CtrlDgv = Me.dgv3
            wl_nRow = 0
            wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nRowDgv
                    .Rows(wl_nRow).Cells("nId").Value = 0
                    .Rows(wl_nRow).Cells("sCodItm").Value = vl_sCodItm
                Next
            End With
            wl_CtrlDgv = Me.dgv4
            wl_nRow = 0
            wl_nRowDgv = wl_CtrlDgv.Rows.Count - 1
            With wl_CtrlDgv
                For wl_nRow = 0 To wl_nRowDgv
                    .Rows(wl_nRow).Cells("nId").Value = 0
                    .Rows(wl_nRow).Cells("sCodItm").Value = vl_sCodItm
                Next
            End With


            wl_CtrlDgv = Me.dgv1
        Catch ex As Exception
            MsgBox("Error en: dgv_sCodItm")
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
            wg_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nColIni = wg_nColIni
            wl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin
            wl_nTotCol = UBound(wg_aeAPDGV) + 1
            If wl_sCodDgv = "dgv1" Then
                wl_nTotCol1 = wl_nTotCol
                wl_nColFin1 = wl_nColFin
                wl_nColIni1 = wl_nColIni
            End If
            If wl_sCodDgv = "dgv2" Then
                wl_nTotCol2 = wl_nTotCol
                wl_nColFin2 = wl_nColFin
                wl_nColIni2 = wl_nColIni
            End If
            If wl_sCodDgv = "dgv3" Then
                wl_nTotCol3 = wl_nTotCol
                wl_nColFin3 = wl_nColFin
                wl_nColIni3 = wl_nColIni
            End If
            If wl_sCodDgv = "dgv4" Then
                wl_nTotCol4 = wl_nTotCol
                wl_nColFin4 = wl_nColFin
                wl_nColIni4 = wl_nColIni
            End If
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
    Private Sub dgv_EliminarLinea(ByVal vl_VlrCtrl As DataGridView)
        Dim wl_nRow As Integer
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRow = (vl_VlrCtrl.Rows.Count).ToString
            wl_nCol = vl_VlrCtrl.CurrentRow.Index
            '    MsgBox(vl_VlrCtrl.Name.ToString)


            If wl_nRow >= 0 Then
                vl_VlrCtrl.Rows(wl_nCol).Visible = False
                wl_nCol = 0
                For wl_nRow = 0 To vl_VlrCtrl.Rows.Count - 1
                    If vl_VlrCtrl.Rows(wl_nRow).Visible = True Then
                        vl_VlrCtrl.Rows(wl_nRow).HeaderCell.Value = (wl_nCol + 1).ToString
                        wl_nCol = wl_nCol + 1
                    End If
                Next
                vl_VlrCtrl.RefreshEdit()
            End If
            dgv_PorLinPLLIM1()
            dgv_SumLinPLLIM2()
            dgv_SumLinPLLIM3()
            dgv_TotPELIM()
            cmdActualizar.Focus()
        Catch
            MsgBox("Error: dgv_EliminarLinea")
        End Try

    End Sub
#End Region
#Region "072 DGV Controladores de Eventos "
    'DGV1
    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
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
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            vl_CtrlDgv = Me.dgv1
            wl_sCodDgv = "dgv1"
            If dgv1.Rows.Count > 0 Then
                If dgv1.CurrentCell.ReadOnly = True Then
                    dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : dgv1_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv1.Rows.Count > 0 Then
                wl_CtrlDgv = Me.dgv1
                If dgv1.CurrentCell.ReadOnly = True Then
                    dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If

                wl_nCol = e.ColumnIndex
                wl_nRow = e.RowIndex
                If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
                wl_sCodDgv = "dgv1"
                dgv_APDGV()
                If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodCmt" Then
                    BD_CargarIEDMI(wl_nCol)
                End If
                If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodAlmCns" Then
                    wl_bEOF = BD_BuscarATALM()
                    If wl_bEOF Then
                        BD_CargarATALM(wl_nCol)
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
            wl_CtrlDgv = Me.dgv1
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
    Private Sub dgv1_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellDirtyStateChanged
        Try
            If dgv1.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_CurrentCellDirtyStateChanged")
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
            wl_CtrlDgv = Me.dgv1
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
            wl_CtrlDgv = Me.dgv1
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
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            mof_LmpMsgError()
            wl_CtrlDgv = dgv1
            wl_sCodDgv = "dgv1"
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
            wl_nTotCol = wl_nTotCol1
            wl_nColIniGrl = wl_nColIni1
            wl_nColFin = wl_nColFin1
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
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            mov_dgv_VdaPGFOM1(wl_nCol,
                             wl_nColAnt,
                             wl_nColSig,
                             wl_nRow,
                             wl_nRowAnt,
                             wl_nRowSig,
                             wl_CtrlDgv,
                             wl_aeAPDGV,
                             wl_bVda)

            dgv_PorLinPLLIM1()
            dgv_SumLinPLLIM2()
            dgv_TotPELIM()

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
                    dgv_AdiRow(dgv1)

                    wl_nRow = dgv1.CurrentCellAddress.Y
                End If
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                dgv1.Focus()

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
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
                dgv1.Focus()
            End If
            wl_nRowAnt = dgv1.CurrentCell.RowIndex
            wl_nColAnt = dgv1.CurrentCell.ColumnIndex
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
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRow = dgv1.CurrentCell.RowIndex
            wl_nCol = dgv1.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv1_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv1_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
    'DGV2
    Private Sub dgv2_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellLeave
        Try
            If dgv2.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
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
            If dgv2.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            vl_CtrlDgv = Me.dgv2
            wl_sCodDgv = "dgv2"

            If dgv2.Rows.Count > 0 Then
                If dgv2.CurrentCell.ReadOnly = True Then
                    If wl_nRowAnt = 0 Then
                        cmdCancelar.Focus()
                    Else
                        dgv2.CurrentCell = dgv2.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                    End If



                End If
            End If
            dgv_APDGV()
            wl_X = dgv2.CurrentCellAddress.X
            If wg_aeAPDGV(wl_X).sNomCmp = "bItmAct" Then
                dgv_SumLinPLLIM2()
                dgv_PorLinPLLIM1()
                dgv_TotPELIM()
            End If
        Catch ex As Exception
            MsgBox("Error : dgv2_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.CellMouseDoubleClick

        Try
            If dgv2.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv2.Rows.Count > 0 Then
                If dgv2.CurrentCell.ReadOnly = True Then
                    If wl_nRowAnt = 0 Then
                        cmdCancelar.Focus()
                    Else
                        dgv2.CurrentCell = dgv2.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                    End If
                End If

                wl_nCol = e.ColumnIndex
                wl_nRow = e.RowIndex
                If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If

                dgv_APDGV()
                If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodOpe" Then
                    vl_sCodOpe = dgv2.CurrentRow.Cells("sCodOpe").Value
                    wl_bEOF = BD_BuscarATOPE()
                    If wl_bEOF Then
                        BD_CargarATOPE(wl_nCol)
                    End If
                    dgv2.CurrentRow.Cells("sCodOPE").Value = vl_eATOPE.sCodOpe
                    dgv2.CurrentRow.Cells("sNomOPE").Value = vl_eATOPE.sNomOpe
                    dgv2.CurrentRow.Cells("sCodCtr").Value = vl_eATOPE.sCodCtr
                    vl_sCodCtr = dgv2.CurrentRow.Cells("sCodCtr").Value
                    wl_bEOF = BD_BuscarATCTR()
                    dgv2.CurrentRow.Cells("nPreUni").Value = wl_eATCTR.nPreUni
                End If

            End If
        Catch ex As Exception
            MsgBox("Error :  dgv2_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellValueChanged
        If dgv2.Enabled = False Then
            Exit Sub
        End If
        Try
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : dgv2_CellValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv2_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv2.ColumnHeaderMouseClick
        Try
            If dgv2.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv2_ColumnHeaderMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellDirtyStateChanged
        Try
            If dgv2.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv2_CurrentCellDirtyStateChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv2.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
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
        Try
            wl_CtrlDgv = Me.dgv2
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
            MsgBox("Error : dgv2_KeyDown")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub dgv2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv2.KeyPress
        Try
            wl_CtrlDgv = Me.dgv2
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
            MsgBox("Error : dgv2_KeyPress")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv2.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_bAdiRow As Boolean = False
        Try
            If dgv2.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            mof_LmpMsgError()
            wl_CtrlDgv = dgv2
            wl_sCodDgv = "dgv2"
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


            wl_nTotCol = wl_nTotCol2
            wl_nColIniGrl = wl_nColIni2
            wl_nColFin = wl_nColFin2


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
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            mov_dgv_VdaPGFOM2(wl_nCol,
                              wl_nColAnt,
                              wl_nColSig,
                              wl_nRow,
                              wl_nRowAnt,
                              wl_nRowSig,
                              wl_CtrlDgv,
                              wl_aeAPDGV,
                              wl_bVda)
            dgv_SumLinPLLIM2()
            dgv_TotPELIM()
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
                                        dgv2,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRow(dgv2)

                    wl_nRow = dgv2.CurrentCellAddress.Y
                End If
                dgv2.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin,
                                         wl_nColIniGrl,
                                         wl_nCntRow,
                                         dgv2,
                                         wl_nColKD)
                dgv2.CurrentCell = dgv2.Rows(wl_nRow).Cells(wl_nCol)
                dgv2.Focus()
            End If
            wl_nRowAnt = dgv2.CurrentCell.RowIndex
            wl_nColAnt = dgv2.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error: dgv2_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            If dgv2.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRow = dgv2.CurrentCell.RowIndex
            wl_nCol = dgv2.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv2_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv2_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
    'DGV3
    Private Sub dgv3_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellLeave
        Try
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = dgv3.CurrentCell.RowIndex
            wl_nColKD = dgv3.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv3_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv3.CellMouseClick
        Try
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            vl_CtrlDgv = Me.dgv3
            wl_sCodDgv = "dgv3"

            If dgv3.Rows.Count > 0 Then
                If dgv3.CurrentCell.ReadOnly = True Then
                    dgv3.CurrentCell = dgv3.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
            End If

        Catch ex As Exception

            MsgBox("Error : dgv3_CellMouseClick")
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub dgv3_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv3.CellMouseDoubleClick
        Try
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If

            If dgv3.Rows.Count > 0 Then
                wl_CtrlDgv = Me.dgv3
                If dgv3.CurrentCell.ReadOnly = True Then
                    dgv3.CurrentCell = dgv3.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If

                wl_nCol = e.ColumnIndex
                wl_nRow = e.RowIndex
                If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
                wl_sCodDgv = "dgv3"
                dgv_APDGV()
                If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodCIF" Then
                    vl_sCodOpe = dgv3.CurrentRow.Cells("sCodCIF").Value
                    wl_bEOF = BD_BuscarATOPE()
                    If wl_bEOF Then
                        BD_CargarATCIF(wl_nCol)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error :  dgv3_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellValueChanged
        If dgv3.Enabled = False Then
            Exit Sub
        End If
        Try
            wl_nColCVC = e.ColumnIndex
            wl_nRowCVC = e.RowIndex
            If cmdCrear.Visible = False Then
                If cmdOk.Visible = True Then
                    mof_ActivarActualizar(Me)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : dgv3_CellValueChanged")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv3_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv3.CurrentCellDirtyStateChanged
        Try
            If dgv3.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv3_CurrentCellDirtyStateChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv3.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv3.CurrentCell = dgv3.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv3_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv3.KeyDown
        wl_CtrlDgv = Me.dgv3
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
            MsgBox("Error : dgv3_KeyDown")
            MsgBox(ex.Message)

        End Try



    End Sub
    Private Sub dgv3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv3.KeyPress
        wl_CtrlDgv = Me.dgv3
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
    Private Sub dgv3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv3.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_bAdiRow As Boolean = False
        Try
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            mof_LmpMsgError()
            wl_CtrlDgv = dgv3
            wl_sCodDgv = "dgv3"
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


            wl_nTotCol = wl_nTotCol3
            wl_nColIniGrl = wl_nColIni3
            wl_nColFin = wl_nColFin3


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
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            mov_dgv_VdaPGFOM3(wl_nCol,
                              wl_nColAnt,
                              wl_nColSig,
                              wl_nRow,
                              wl_nRowAnt,
                              wl_nRowSig,
                              wl_CtrlDgv,
                              wl_aeAPDGV,
                              wl_bVda)

            dgv_SumLinPLLIM2()
            dgv_TotPELIM()
            wl_CtrlDgv = dgv3
            wl_sCodDgv = "dgv3"
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
                                        dgv3,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRow(dgv3)

                    wl_nRow = dgv3.CurrentCellAddress.Y
                End If
                dgv3.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin,
                                         wl_nColIniGrl,
                                         wl_nCntRow,
                                         dgv3,
                                         wl_nColKD)
                dgv3.CurrentCell = dgv3.Rows(wl_nRow).Cells(wl_nCol)
                dgv3.Focus()
            End If
            wl_nRowAnt = dgv3.CurrentCell.RowIndex
            wl_nColAnt = dgv3.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error: dgv3_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv3.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            If dgv3.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_CtrlDgv = dgv3
            wl_nRow = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nCol = wl_CtrlDgv.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv3_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv3_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
    'DGV4
    Private Sub dgv4_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv4.CellLeave
        Try
            If dgv4.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = dgv4.CurrentCell.RowIndex
            wl_nColKD = dgv4.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv4_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv4.CellMouseClick

        Try
            If dgv4.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            vl_CtrlDgv = Me.dgv4
            wl_sCodDgv = "dgv4"
            If dgv4.Rows.Count > 0 Then
                If dgv4.CurrentCell.ReadOnly = True Then
                    dgv4.CurrentCell = dgv4.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : dgv4_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv4.CellMouseDoubleClick

        Try
            If dgv4.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv4.Rows.Count > 0 Then
                wl_CtrlDgv = Me.dgv4
                If dgv4.CurrentCell.ReadOnly = True Then
                    dgv4.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If

                wl_nCol = e.ColumnIndex
                wl_nRow = e.RowIndex
                If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
                wl_sCodDgv = "dgv4"
                dgv_APDGV()
                If wg_aeAPDGV(wl_nCol).sNomCmp = "sCodCmt" Then
                    'vl_sCodItm = dgv4.CurrentRow.Cells("sCodCmt").Value
                    wl_bEOF = BD_BuscarPEFOM()
                    If wl_bEOF Then
                        BD_CargarPEFOM(wl_nCol)
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Error :  dgv4_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv4.CellValueChanged
        Try
            wl_CtrlDgv = Me.dgv4
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
            MsgBox("Error :  dgv4_CellValueChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv4_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv4.CurrentCellDirtyStateChanged
        Try
            If dgv4.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv4_CurrentCellDirtyStateChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv4.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv4.CurrentCell = dgv4.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv4_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv4.KeyDown
        Try
            wl_CtrlDgv = Me.dgv4
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
            MsgBox("Error :  dgv4_KeyDown")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv4.KeyPress
        Try
            wl_CtrlDgv = Me.dgv4
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
            MsgBox("Error :  dgv4_KeyPress")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv4.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_bAdiRow As Boolean = False
        wl_sNomtbl = ""
        Try
            If dgv4.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            mof_LmpMsgError()
            wl_CtrlDgv = dgv4
            wl_sCodDgv = "dgv4"
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


            wl_nTotCol = wl_nTotCol4
            wl_nColIniGrl = wl_nColIni4
            wl_nColFin = wl_nColFin4


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
            ReDim wl_aeAPDGV(0)
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            mov_dgv_VdaPGFOM1(wl_nCol,
                            wl_nColAnt,
                            wl_nColSig,
                            wl_nRow,
                            wl_nRowAnt,
                            wl_nRowSig,
                            wl_CtrlDgv,
                            wl_aeAPDGV,
                            wl_bVda)
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
                                        dgv4,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRow(dgv4)

                    wl_nRow = dgv4.CurrentCellAddress.Y
                End If
                dgv4.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin,
                                         wl_nColIniGrl,
                                         wl_nCntRow,
                                         dgv4,
                                         wl_nColKD)
                dgv4.CurrentCell = dgv4.Rows(wl_nRow).Cells(wl_nCol)
                dgv4.Focus()
            End If
            wl_nRowAnt = dgv4.CurrentCell.RowIndex
            wl_nColAnt = dgv4.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error: dgv4_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv4.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            If dgv4.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_CtrlDgv = dgv4
            wl_nRow = wl_CtrlDgv.CurrentCell.RowIndex
            wl_nCol = wl_CtrlDgv.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv4_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv4_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_frm_Var()

        Try
            mtbsCodItm.Text = vl_sCodItm
            txtsNomItm.Text = vl_sNomItm
            txtnCanLotStn.Text = FormatNumber(vl_nCanLotStn, 2)
            cboACUNI.SelectedValue = vl_sUniMedStn
            txtnCanUniStn.Text = vl_nCanUniStn
            cboACUNIInv.SelectedValue = vl_sUniMedInv
            cboABLIM.SelectedValue = vl_sTipLIM
            cboATALM.SelectedValue = vl_sCodAlm
            chbbRegAci.Checked = vl_bRegAci
            txtnPesItm.Text = FormatNumber(vl_nPesItm, 2)
            txtnTieItm.Text = FormatNumber(vl_nTieItm, 2)
            txtnTotTieItm.Text = FormatNumber(vl_nTotTieItm, 2)
            txtnCIFItm.Text = FormatNumber(vl_nCIFItm, 2)
            txtnPreVta.Text = FormatNumber(vl_nPreVta, 2)
            txtnTotTieItm.Text = FormatNumber(CDbl(txtnTieItm.Text) * CDbl(txtnCanUniStn.Text) / 60, 2)
        Catch ex As Exception
            MsgBox("Error :  Plo_frm_Var")
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Plo_Var_frm()
        Try
            vl_sCodItm = mtbsCodItm.Text
            vl_sNomItm = txtsNomItm.Text
            vl_nCanLotStn = CDbl(txtnCanLotStn.Text)
            vl_sUniMedStn = cboACUNI.SelectedValue
            vl_nCanUniStn = CDbl(txtnCanUniStn.Text)
            vl_sUniMedInv = cboACUNIInv.SelectedValue
            vl_sTipLIM = cboABLIM.SelectedValue
            vl_sCodAlm = cboATALM.SelectedValue
            vl_nPesItm = CDbl(txtnPesItm.Text)
            vl_nTieItm = CDbl(txtnTieItm.Text)
            vl_nTotTieItm = vl_nTieItm * vl_nCanUniStn / 60
            vl_nPreVta = CDbl(txtnPreVta.Text)
            vl_nCIFItm = CDbl(txtnCIFItm.Text)
        Catch ex As Exception
            MsgBox("Error :  Plo_Var_frm")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmPELIM"
            wl_sCodDgv = "dgv1"
        Catch ex As Exception
            MsgBox("Error : Plo_IniciaFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_bEdit = False
            wg_sCodErrAdi = "10-301"
            wg_sCodErrCon = "10-101"
            wg_sCodErrOk = "20-001"
            wg_sDesMsgEli = "Este opción elimina el código. ¿ Continua ?"
            wg_sTitMsgEli = "Mensaje del sistema"

            ' globales
            wg_sCmpTSB = "sCodItm"
            wg_sDatTSB = ""
            wl_nNroDgv = 0
            wl_nTab = 0
            wl_nColIni1 = 0
            wl_nColIni2 = 0
            wl_nColIni3 = 0
            wl_nColFin1 = 0
            wl_nColFin2 = 0
            wl_nColFin3 = 0
            wl_nTotCol1 = 0
            wl_nTotCol2 = 0
            wl_nTotCol3 = 0

            vl_sCodItm = ""
            vl_sNomItm = ""
            vl_nCanLotStn = 0
            vl_sUniMedStn = ""
            vl_nCanUniStn = 0
            vl_sUniMedInv = ""
            vl_sTipLIM = ""
            vl_sCodAlm = ""
            vl_nPesItm = 0
            vl_nTieItm = 0
            vl_nTotTieItm = 0
            vl_nPreVta = 0
            vl_nCIFItm = 0
            vl_nvlrItm = 0
            vl_sRegSan = ""
            vl_nPreVta = 0

            txtnCanLotStn.Text = "0"
            txtnPesItm.Text = "0"
            txtnTieItm.Text = "0"
            txtnTotTieItm.Text = "0"
            txtnCIFItm.Text = "0"
            txtnPreVta.Text = "0"

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
                              wl_nTotCol)
            dgv_ConfiguraCol()
            If dgv1.RowCount > 0 Then
                dgv1.Rows.Clear()
            End If
            dgv_AdiRow(wl_CtrlDgv)

            wl_sCodDgv = "dgv2"
            wl_CtrlDgv = Me.dgv2
            dgv_APDGV()
            mof_ConfigurarDGV(wl_CtrlDgv,
                             wl_nTotCol)
            dgv_ConfiguraCol()
            If dgv2.RowCount > 0 Then
                dgv2.Rows.Clear()
            End If

            dgv_AdiRow(wl_CtrlDgv)

            wl_sCodDgv = "dgv3"
            wl_CtrlDgv = Me.dgv3
            dgv_APDGV()
            mof_ConfigurarDGV(Me.dgv3,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            If dgv3.RowCount > 0 Then
                dgv3.Rows.Clear()
            End If

            dgv_AdiRow(wl_CtrlDgv)

            wl_sCodDgv = "dgv4"
            wl_CtrlDgv = Me.dgv4
            dgv_APDGV()
            mof_ConfigurarDGV(Me.dgv4,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            If dgv4.RowCount > 0 Then
                dgv4.Rows.Clear()
            End If
            dgv_AdiRow(wl_CtrlDgv)


        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_LiberarFrm()
        Try
            If dgv4.RowCount > 0 Then
                dgv4.Rows.Clear()
                dgv4.Columns.Clear()
            End If
            If dgv1.RowCount > 0 Then
                dgv1.Rows.Clear()
                dgv1.Columns.Clear()

            End If
            If dgv2.RowCount > 0 Then
                dgv2.Rows.Clear()
                dgv2.Columns.Clear()
            End If
            If dgv3.RowCount > 0 Then
                dgv3.Rows.Clear()
                dgv3.Columns.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_LiberarFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_SelDGV(ByVal wl_nNroDgv As Integer)
        wl_CtrlDgv = New DataGridView
        Try
            'If wl_nNroDgv = 0 Then
            ' ' dgv2.Visible = False
            ' dgv1.Visible = True
            ' wl_sCodDgv = "dgv1"
            ' wl_CtrlDgv = Me.dgv1
            '
            '            End If
            '            If wl_nNroDgv = 1 Then
            ' dgv1.Visible = False
            ' dgv2.Visible = True
            ' wl_sCodDgv = "dgv2"
            ' wl_CtrlDgv = Me.dgv2
            ' End If
            ' If wl_nNroDgv = 2 Then
            ' dgv1.Visible = False
            ' dgv2.Visible = True
            ' wl_sCodDgv = "dgv3"
            ' wl_CtrlDgv = Me.dgv3
            ' End If
            ' dgv_APDGV()
        Catch ex As Exception
            MsgBox("Error : Plo_SelDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarBuscar()
        Try
            Plo_ActivarCmpAct()
            mof_ActivarBuscar(Me)
            Plo_IniciarVar()
            Plo_IniciarVarDGV()
            mtbsCodItm.Enabled = True
            mtbsCodItm.Focus()
            cmdCpd.Enabled = False
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarBuscar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCrear()
        Try
            Plo_ActivarCmpAct()
            mof_ActivarCrear(Me)
            Plo_IniciarVar()
            Plo_IniciarVarDGV()
            dgv1.Select()
            cmdCpd.Enabled = True
            mtbsCodItm.Enabled = True
            mtbsCodItm.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCmpAct()
        Try
            mtbsCodItm.Enabled = True
            txtsNomItm.Enabled = True
            txtnCanLotStn.Enabled = True
            cboABLIM.Enabled = True
            cboACUNI.Enabled = True
            cboACUNIInv.Enabled = True
            cboATALM.Enabled = True
            chbbRegAci.Enabled = True
            txtnCanUniStn.Enabled = True
            cmdLstIEDMI.Enabled = True
            cmdLstPELIM.Enabled = True
            txtnPreVta.Enabled = True
            cmdCpd.Enabled = False

            Plo_IniciarVarDGV()
            dgv1.Select()


        Catch ex As Exception
            MsgBox("Error :  Plo_activarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactCmpAct()
        Try
            mtbsCodItm.Enabled = False
            txtsNomItm.Enabled = False
            txtnCanLotStn.Enabled = False
            cboABLIM.Enabled = False
            cboACUNI.Enabled = False
            cboACUNIInv.Enabled = False
            cboATALM.Enabled = False
            chbbRegAci.Enabled = False
            txtnCanUniStn.Enabled = False
            cmdLstIEDMI.Enabled = False
            cmdLstPELIM.Enabled = False
            txtnPreVta.Enabled = False
            cmdCpd.Enabled = False
            For wl_i = 0 To dgv4.Rows.Count - 1
                dgv4.Rows(wl_i).ReadOnly = True
                dgv4.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
            For wl_i = 0 To dgv3.Rows.Count - 1
                dgv3.Rows(wl_i).ReadOnly = True
                dgv3.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
            For wl_i = 0 To dgv2.Rows.Count - 1
                dgv2.Rows(wl_i).ReadOnly = True
                dgv2.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next

            For wl_i = 0 To dgv1.Rows.Count - 1
                dgv1.Rows(wl_i).ReadOnly = True
                dgv1.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT
            Next
            dgv1.Select()
            cmdOk.Focus()
        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_VdaCrear()
        Try
            vl_sCodItm = mtbsCodItm.Text
            BD_BuscarIEDMI()
            wp_bEOF1 = wr_bEOFE2
            If wr_bEOFE2 = False Then
                txtsNomItm.Text = vl_eIEDMI.sNomItm
                wr_bEOFE2 = BD_BuscarPELIM()
                wp_bEOF2 = wr_bEOFE2
                If wr_bEOFE2 = False Then
                    wp_sNomTbl = "PELIM"
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = "10-301"
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    mtbsCodItm.Focus()
                End If
            Else
                wp_sNomTbl = "IDEMI"
                wp_sDatCmp = mtbsCodItm.Text
                wp_sCodErr = "10-101"
                mof_MsgError(wp_sNomTbl,
                            wp_sDatCmp,
                            wp_sCodErr)
                mtbsCodItm.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "082 Pep PROCEDIMIENTOS EVENTOS PERSONALIZADOS"
    Private Sub mtbsCodItm_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbsCodItm.GotFocus
        Try
            ' mof_LmpMsgError()
            mtbsCodItm.SelectionStart = 0
            mtbsCodItm.SelectionLength = mtbsCodItm.Text.Length
        Catch ex As Exception
            MsgBox("Error : mtbsCodItm_GotFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mtbsCodItm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtbsCodItm.KeyUp
        Try
            If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then

                If cmdBuscar.Visible = True Then
                    ' cmdBuscar_Click(Nothing,
                    '                 Nothing)
                    If Mid(mtbsCodItm.Text, 1, 1) <> " " Then
                        cmdBuscar_Click(Nothing,
                                        Nothing)
                    Else
                        cmdLstIEDMI.Focus()
                    End If
                End If
                If cmdCrear.Visible = True Then
                    If Mid(mtbsCodItm.Text, 1, 1) = " " Then
                        mtbsCodItm.Focus()
                        Exit Sub
                    Else
                        cmdCpd.Enabled = True
                    End If
                    Plo_VdaCrear()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error : mtbsCodItm_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Private Sub mtbsCodItm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbsCodItm.LostFocus
    '      Try
    '          mof_LmpMsgError()
    '          If cmdBuscar.Visible = True Then
    '              If Mid(mtbsCodItm.Text, 1, 1) <> " " Then
    '                  cmdBuscar_Click(Nothing,
    '                                  Nothing)
    '              Else
    '                  cmdLstIEDMI.Focus()
    '              End If
    '
    '            End If
    '            If cmdCrear.Visible = True Then
    '                If Mid(mtbsCodItm.Text, 1, 1) = " " Then
    '                    mtbsCodItm.Focus()
    '                    Exit Sub
    '                End If
    '                Plo_VdaCrear()
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Error : mtbsCodItm_LostFocus")
    '            MsgBox(ex.Message)
    '       End Try
    '   End Sub
#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()

        Try
            Dim wl_aePELIM(0) As moe_Estructuras.ePELIM

            BD_ePELIM_Var()
            dgv_DGV_DT()
            wl_aePELIM(0) = wl_ePELIM

            wl_sNroALetras = ""
            mof_ActivarOK(Me)

            If wl_aePLLIM1.Length <> 0 Then
                If wl_aePLLIM1(0).sCodItm <> "" Then
                    Dim wl_frmRPT As New rptPRLIM01
                    wl_frmRPT.wp_aePELIM = wl_aePELIM
                    wl_frmRPT.wp_aePLLIM1 = wl_aePLLIM1
                    wl_frmRPT.wp_aePLLIM2 = wl_aePLLIM2
                    wl_frmRPT.wp_aePLLIM3 = wl_aePLLIM3
                    wl_frmRPT.wp_aePLLIM4 = wl_aePLLIM4
                    wl_frmRPT.wp_sNroALetras = wl_sNroALetras
                    wl_frmRPT.Show()
                End If
            End If

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
        If DirectCast(sender, TextBox).Name = "mtbsCodItm" Then
            wg_sClaPpl = mtbsCodItm.Text
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
                If wl_cvTxt.Name = "txtsCodItm" Then
                    mov_VdaMTB(wl_bVda,
                               mtbsCodItm)
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
                If wl_cvTxt.Name = "txtsCodItm" Then
                    mov_VdaMTB(wl_bVda,
                               mtbsCodItm)
                End If
                ' If wl_cvTxt.Name = "txtnTotGtoAdi" Then
                'dgv_TotDoc()
                'End If
                'If wl_cvTxt.Name = "txtnVlrRdd" Then
                ' dgv_TotDoc()
                'End If
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
        Try
            '  mof_inhabTsbBuscar()
            '  mof_inhabTsbCrear()
            '  mof_inhabTsbPASU()
            '  mof_inhabTsbEliminar()
            '  Plo_LiberarFrm()
            '  mof_LmpMsgError()
            Me.Close()
            '  mof_LmpMsgError()

        Catch ex As Exception
            MsgBox("Error : grl_Cerrar")
            MsgBox(ex.Message)
        End Try
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
            wg_DTE1 = New DataTable
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
        wr_bEOFE1 = True
        Try
            wg_DTE1 = New DataTable
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
                Else
                    tsb_Ultimo()
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
            wg_DTE1 = New DataTable
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
                Else
                    tsb_Primero()
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
            wg_DTE1 = New DataTable
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
            '  If wl_eGEMOV.sEstDoc > "1" Then
            ' Exit Sub
            ' End If
            If TabControl1.SelectedTab Is TabPage1 Then
                wl_CtrlDgv = Me.dgv4
            End If
            If TabControl1.SelectedTab Is TabPage2 Then
                wl_CtrlDgv = Me.dgv1
            End If
            If TabControl1.SelectedTab Is TabPage3 Then
                wl_CtrlDgv = Me.dgv2
            End If
            If TabControl1.SelectedTab Is TabPage4 Then
                wl_CtrlDgv = Me.dgv3
            End If
            dgv_AdiRow(wl_CtrlDgv)
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
            dgv_APDGV()
            dgv_EliminarLinea(vl_CtrlDgv)
        Catch ex As Exception
            MsgBox("Error : tsmi_EliminarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "TSB ToolStrip Procedimientos eventos de la barra de herramientas"
    Public Sub tsb_Buscar1()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
    End Sub
    Private Sub tsb_Primero1()
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
    Private Sub tsb_Anterior1()
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
    Private Sub tsb_Siguiente1()
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
    Private Sub tsb_Ultimo1()
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
    Public Sub tsb_Crear1()
        mof_fLmpCtrl(Me)
        Plo_ActivarCrear()

    End Sub
    Public Sub tsb_Eliminar1()
        mof_ActivarEliminar(Me)
    End Sub
    Private Sub tsb_VistaPrevia1()
        MsgBox("Vista Previa")
    End Sub
    Private Sub tsb_Prn1()
        MsgBox("Imprimir")
    End Sub


#End Region

#End Region



End Class