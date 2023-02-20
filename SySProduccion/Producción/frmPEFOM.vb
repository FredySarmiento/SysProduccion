Public Class frmPEFOM
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
    Dim wl_sNroALetras As String
    Dim wl_sCodItmIni As String
    Dim wl_sCodItm As String


#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vp_nId As Integer
    Dim vl_sCodItm As String
    Dim vl_sNomItm As String
    Dim vl_nCanLotStn As Double
    Dim vl_nCanUniStn As Double
    Dim vl_sUniMedStn As String
    Dim vl_sTipLIM As String
    Dim vl_sCodAlm As String
    Dim vl_bRegAci As Boolean
    Dim vl_nPesItm As Double
    Dim vl_nPorItm As Double
    Dim vl_nCanCmtItm As Double
    Dim vl_nTieItm As Double

    Dim vl_sCodCmt As String
    Dim vl_sDesCmt As String
    Dim vl_nCanCmt As Double
    Dim vl_nPesCmt As Double
    Dim vl_nPorCmt As Double

    Dim vl_sCodAlmCns As String
    Dim vl_sCodOpe As String
    Dim vl_sDesOpe As String
    Dim vl_nTieOpe As Double

    Dim vl_sCodCIF As String
    Dim vl_sDesCIF As String
    Dim vl_nVlrCIF As Double

    Dim vl_sCodAna As String
    Dim vl_sCodTipAna As String
    Dim vl_nPreVta As Double

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
    Dim wl_nColFin5 As Integer
    Dim wl_nColIni1 As Integer
    Dim wl_nColIni2 As Integer
    Dim wl_nColIni3 As Integer
    Dim wl_nColIni5 As Integer
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
    Dim wl_nTotCol5 As Integer

    Dim wl_nRowKD As Integer
    Dim wl_nColKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nColKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nColKU As Integer
    Dim wl_nNroDgv As Integer
    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y

    Dim wl_sCodDgv As String
    Dim wl_CtrlDgv As DataGridView

    Dim wp_sTipCol As String 'N = numérico. C = pesos. S = string. d = fecha
    Dim wp_bVisible As Boolean
    Dim wp_bReadOnly As Boolean


#End Region
#Region "014 Objetos locales"
    ' objetos locales
    Dim clnPEFOM As New ClaseNegocios.clnPEFOM
    Dim clnPLFOM1 As New ClaseNegocios.clnPEFOM
    Dim clnPLFOM2 As New ClaseNegocios.clnPEFOM
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim vl_CtrlDgv As New DataGridView

#End Region
#Region "015 Estructuras"
    Dim wl_aePLFOM1() As moe_Estructuras.ePLFOM1
    Dim wl_aePLFOM2() As moe_Estructuras.ePLFOM2
    Dim wl_aePLFOM3() As moe_Estructuras.ePLFOM3
    Dim wl_aePLFOM5() As moe_Estructuras.ePLFOM5
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eATANA As New moe_Estructuras.eATANA
    Dim wl_eATALM As New moe_Estructuras.eATALM
    Dim wl_eATTIA As New moe_Estructuras.eATTIA
    Dim wl_eIEDMI As New moe_Estructuras.eIEDMI
    Dim wl_ePEFOM As New moe_Estructuras.ePEFOM
    Dim wl_ePLFOM1 As New moe_Estructuras.ePLFOM1
    Dim wl_ePLFOM2 As New moe_Estructuras.ePLFOM2
    Dim wl_ePLFOM3 As New moe_Estructuras.ePLFOM3
    Dim wl_ePLFOM5 As New moe_Estructuras.ePLFOM5
    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_eATCIF As New moe_Estructuras.eATCIF
    Dim wl_eATOPE As New moe_Estructuras.eATOPE
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
    Private Sub frmPEFOM_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            grl_RemoveHandler()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error : frmPEFOM_Disposed")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmPEFOM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            mof_inhabTsbBuscar()
            mof_inhabTsbCrear()
            mof_inhabTsbPASU()
            mof_inhabTsbEliminar()
            mof_LmpMsgError()
            Plo_LiberarFrm()
            mof_LmpMsgError()
        Catch ex As Exception
            MsgBox("Error : frmPEFOM_FormClosing")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmPEFOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            grl_RemoveHandler()
            grl_AddHandler()

            mof_fCnfCtrl(Me)

            mof_IniciarVar()
            Plo_IniciarVar()
            Plo_IniciarFrm()
            wg_sTipTbl = "E1"
            BD_DatPrmTipTbl(wg_sTipTbl)

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
            MsgBox("Error : frmPEFOM_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub frmPEFOM_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        mtbsCodItm.Focus()
    End Sub
#End Region

#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarABLIM()
            Cbo_CargarACUNI()
            cbo_cargarATALM()

        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLst")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarABLIM()
        Try
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
            cboABLIM.SelectedValue = "02"
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarABLIM")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cbo_CargarACUNI()
        Try
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
            cboACUNI.SelectedValue = "Kg"
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarACUNI")
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
            cboATALM.SelectedValue = wg_eACPAG.sCodAlmXDef
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
            BD_ePEFOM_Var()
            BD_BuscarATALM()
            wl_CtrlDgv = Me.dgv1

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
            If wl_CtrlDgv.Name = "dgv5" Then
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
                End If

                If wl_CtrlDgv.Rows(wl_nI).Cells("nCanCmt").Value = 0 Then
                    MsgBox("Línea Nro. " & wl_nI1.ToString & " tiene Cantidad de componente en 0")
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nI).Cells("nCanCmt")
                    Return wl_bYesNo
                End If
            Next
            wg_bVdaE1 = True
            If Not mov_VdaMTB(wg_bVdaE1,
                              mtbsCodItm) Then

                mtbsCodItm.Focus()
                Return wl_bYesNo
                Exit Function
            End If
            wl_bYesNo = clnPEFOM.cnCrearActualizar(wl_ePEFOM,
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
            wl_sNomTblE1 = "PEFOM"
            wl_sNomCmpE11 = "sCodItm"
            wl_sTipCmpE11 = "C"
            wl_sTitCmpE11 = "Código ítem "
            wl_sDatCmpE11 = mtbsCodItm.Text
            wl_sNomTblL1 = "PLFOM1"
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
    Private Sub BD_ePEFOM_DT(ByVal wp_DTE1 As DataTable)
        Try
            Dim wl_nRow As Integer
            wl_nRow = wp_DTE1.Rows.Count - 1
            wl_ePEFOM = New moe_Estructuras.ePEFOM
            moo_ePEFOM_DT(wl_ePEFOM,
                          wp_DTE1,
                          wl_nRow)
            vl_sCodItm = wl_ePEFOM.sCodItm
        Catch ex As Exception
            MsgBox("Error :  BD_ePEFOM_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_ePEFOM_Var()
        Try
            wl_ePEFOM = New moe_Estructuras.ePEFOM
            wg_sClaPpl = mtbsCodItm.Text
            vl_sCodItm = mtbsCodItm.Text
            vl_sNomItm = txtsNomItm.Text
            With wl_ePEFOM
                .sCodItm = mtbsCodItm.Text
                If String.IsNullOrEmpty(txtnCanLotStn.Text) Then
                    txtnCanLotStn.Text = "0"
                End If
                .sCodItm = mtbsCodItm.Text
                .sNomItm = txtsNomItm.Text
                .nCanLotStn = CDbl(txtnCanLotStn.Text)
                .nCanUniStn = 0
                .sUniMedStn = cboACUNI.SelectedValue
                .sUniMedInv = cboACUNI.SelectedValue
                .sTipLIM = cboABLIM.SelectedValue
                .sCodAlm = cboATALM.SelectedValue
                .bRegAci = chbbRegAci.Checked
                .sRegSan = txtsRegSan.Text
                If String.IsNullOrEmpty(txtnPesItm.Text) Then
                    txtnPesItm.Text = "0"
                End If
                .nPesItm = CDbl(txtnPesItm.Text)
                If String.IsNullOrEmpty(txtnPorItm.Text) Then
                    txtnPorItm.Text = "0"
                End If
                .nPorItm = CDbl(txtnPorItm.Text)
            End With
        Catch ex As Exception
            MsgBox("Error :  BD_ePEFOM_Var")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BD_Var_ePEFOM()
        Try
            With wl_ePEFOM
                mtbsCodItm.Text = .sCodItm
                wg_sDatCmpE11 = mtbsCodItm.Text
                txtsNomItm.Text = .sNomItm
                txtnCanLotStn.Text = .nCanLotStn
                chbbRegAci.Checked = .bRegAci
                txtnPesItm.Text = .nPesItm
                txtnPorItm.Text = .nPorItm
                cboACUNI.SelectedValue = .sUniMedStn
                cboABLIM.SelectedValue = .sTipLIM
                cboATALM.SelectedValue = .sCodAlm
                txtsRegSan.Text = .sRegSan
                wg_sClaPpl = .sCodItm
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Var_ePEFOM")
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
            BD_ePEFOM_DT(wg_DTE1)
            BD_BuscarIEDMI()
            BD_Var_ePEFOM()

            dgv1.Enabled = True
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
            wr_bEOFE2 = mof_fConATALM(wl_ePEFOM.sCodAlm,
                                      wl_eATALM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATALM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATANA() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATANA = New moe_Estructuras.eATANA
            wr_bEOFE2 = mof_fConATANA(vl_sCodAna,
                                      wl_eATANA)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATANA")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATTIA() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATTIA = New moe_Estructuras.eATTIA
            wr_bEOFE2 = mof_fConATTIA(vl_sCodTipAna,
                                      wl_eATTIA)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATTIA")
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
    Private Function BD_BuscarPEFOM() As Boolean
        Try
            wr_bEOFE2 = True
            wl_ePEFOM = New moe_Estructuras.ePEFOM
            wr_bEOFE2 = mof_fConPEFOM(vl_sCodItm,
                                      wl_ePEFOM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPEFOM")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATCIF() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATCIF = New moe_Estructuras.eATCIF
            wr_bEOFE2 = mof_fConATCIF(vl_sCodCIF,
                                      wl_eATCIF)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATCIF")
        End Try
        Return wr_bEOFE2
    End Function
    Private Function BD_BuscarATOPE() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATOPE = New moe_Estructuras.eATOPE
            wr_bEOFE2 = mof_fConATOPE(vl_sCodOpe,
                                      wl_eATOPE)
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
            BD_frmATALM()
            If wl_eATALM.sCodAlm <> "" Then
                dgv1.CurrentRow.Cells("sCodAlmCns").Value = wl_eATALM.sCodAlm
                dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellCod)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATALM")
        End Try
    End Sub
    Private Sub BD_CargarATANA(ByVal wl_CellCod As Integer)
        Try
            BD_frmATANA()
            If wl_eATANA.sCodAna <> "" Then
                dgv5.CurrentRow.Cells("sCodAna").Value = wl_eATANA.sCodAna
                dgv5.CurrentRow.Cells("sNomAna").Value = wl_eATANA.sNomAna
                dgv5.CurrentRow.Cells("sCodTipAna").Value = wl_eATANA.sCodTipAna
                BD_BuscarATTIA()
                dgv5.CurrentRow.Cells("sNomTipAna").Value = wl_eATTIA.sNomTipAna
                dgv5.CurrentCell = dgv5.CurrentRow.Cells(wl_CellCod)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATANA")
        End Try
    End Sub
    Private Sub BD_CargarIEDMI(ByVal wp_nCol As Integer)
        Try
            BD_frmIEDMI()
            If wl_eIEDMI.sCodItm <> "" Then
                dgv1.CurrentRow.Cells("sCodCmt").Value = wl_eIEDMI.sCodItm
                If dgv1.CurrentRow.Cells("sNomCmt").Visible = True Then
                    dgv1.CurrentRow.Cells("sNomCmt").Value = wl_eIEDMI.sNomItm
                End If
                dgv1.CurrentRow.Cells("sUniMedInv").Value = wl_eIEDMI.sUniMedInv
                dgv1.CurrentRow.Cells("sCodAlmCns").Value = wl_eIEDMI.sCodAlm
                dgv1.CurrentRow.Cells("nPreUni").Value = wl_eIEDMI.nCosItm
                dgv1.CurrentCell = dgv1.CurrentRow.Cells(wp_nCol)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarIEDMI")
        End Try

    End Sub
    Private Sub BD_CargarATCIF(ByVal wl_CellCod As Integer)
        Try
            BD_frmATCIF()
            If wl_eATCIF.sCodCIF <> "" Then
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATCIF")
        End Try

    End Sub
    Private Sub BD_CargarATOPE(ByVal wl_CellCod As Integer)
        Try
            BD_frmATOPE()
            If wl_eATOPE.sCodOpe <> "" Then

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarATOPE")
        End Try
    End Sub
#End Region
#Region "045 BD Llamar frmGQLst"
    Private Sub BD_frmATALM()
        Try
            Dim wl_frmLst As New frmGQLst

            wg_sTblCon1 = "ATALM"
            wl_frmLst.wp_eATALM = New moe_Estructuras.eATALM
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATALM.sCodAlm <> " " Then
                wl_eATALM = New moe_Estructuras.eATALM
                wl_eATALM = wl_frmLst.wp_eATALM
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmATALM")
        End Try

    End Sub
    Private Sub BD_frmATANA()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATANA"
            wl_frmLst.wp_eATANA = New moe_Estructuras.eATANA
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATANA.sCodAna <> " " Then
                wl_eATANA = New moe_Estructuras.eATANA
                wl_eATANA = wl_frmLst.wp_eATANA
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmATANA")
        End Try

    End Sub
    Private Sub BD_frmIEDMI()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "IEDMI"

            wl_frmLst.wp_eIEDMI = New moe_Estructuras.eIEDMI

            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eIEDMI.sCodItm <> " " Then
                wl_eIEDMI = New moe_Estructuras.eIEDMI
                wl_eIEDMI = wl_frmLst.wp_eIEDMI
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmIEDMI")
        End Try

    End Sub
    Private Sub BD_frmPEFOM()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "PEFOM"
            wl_frmLst.wp_ePEFOM = New moe_Estructuras.ePEFOM
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_ePEFOM.sCodItm <> " " Then
                wl_ePEFOM = New moe_Estructuras.ePEFOM
                wl_ePEFOM = wl_frmLst.wp_ePEFOM
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmPEFOM")
        End Try

    End Sub
    Private Sub BD_frmATCIF()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATCIF"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATCIF.sCodCIF <> " " Then
                wl_eATCIF = New moe_Estructuras.eATCIF
                wl_eATCIF = wl_frmLst.wp_eATCIF
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_frmATCIF")
        End Try
    End Sub
    Private Sub BD_frmATOPE()
        Try
            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "ATOPE"
            wl_frmLst.ShowDialog()
            If wl_frmLst.wp_eATOPE.sCodOpe <> " " Then
                wl_eATOPE = New moe_Estructuras.eATOPE
                wl_eATOPE = wl_frmLst.wp_eATOPE
            End If

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
        Try
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
        Catch ex As Exception
            MsgBox("Error : cmdActualizar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            wp_sCmdSel = "B"
            wl_bYesNo = False
            mof_LmpMsgError()
            If mtbsCodItm.Text <> "" Then
                BD_DatPrmTipTbl(wg_sTipTbl)
                wl_sCmpOrdE11 = ""
                wl_sTipOrdE11 = ""
                wg_DTE1 = mof_fConTbl(wl_sNomTblE1,
                                      wl_sNomCmpE11,
                                      wl_sDatCmpE11,
                                      wl_sTipCmpE11,
                                      wl_sCmpOrdE11,
                                      wl_sTipOrdE11,
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
                    BD_ePEFOM_DT(wg_DTE1)
                    BD_BuscarIEDMI()
                    BD_Var_ePEFOM()
                    mof_fLmpCtrl(Me.dgv1)
                    mof_fLmpCtrl(Me.dgv5)
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
            MsgBox("Error : cmdBuscar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Try
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
        Catch ex As Exception
            MsgBox("Error : cmdBuscar_Click")
            MsgBox(ex.Message)

        End Try
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
                        wl_bYesNo = clnPEFOM.cnEliminar(vl_sCodItm,
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
                            mtbsCodItm.Focus()
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
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        grl_Cerrar()
    End Sub
#End Region

#Region "060 CommandButtons_Click Lista Controladores de Eventos (Remitente_evento)"
    Private Sub cmdLstPEFOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLstPEFOM.Click
        Try
            '   Dim wl_frmLst As New frmGQLst
            BD_frmPEFOM()
            If wl_ePEFOM.sCodItm <> "" Then
                mtbsCodItm.Text = wl_ePEFOM.sCodItm
                txtsNomItm.Text = wl_ePEFOM.sNomItm
                cmdBuscar_Click(Nothing,
                                Nothing)
            End If
            mtbsCodItm.Focus()
        Catch ex As Exception
            MsgBox("Error en: cmdListar_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCpd_Click(sender As System.Object, e As System.EventArgs) Handles cmdCpd.Click
        Try
            Dim wl_frmPEFOM_LeeFOM As New frmPEFOM_LeeFOM
            wl_frmPEFOM_LeeFOM.wp_sCoditmIni = ""
            wl_frmPEFOM_LeeFOM.ShowDialog()
            wl_sCodItm = vl_sCodItm
            wl_sCodItmIni = wl_frmPEFOM_LeeFOM.wp_sCoditmIni

            'mof_fLmpCtrl(Me)
            Plo_IniciarVarDGV()

            If wl_sCodItmIni <> "" Then
                vl_sCodItm = wl_sCodItmIni

                BD_DatPrmTipTbl(wg_sTipTbl)
                wl_sDatCmpE11 = vl_sCodItm
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

                If wr_bEOFE1 Then
                    wp_sNomTbl = wl_sNomTblE1
                    wp_sDatCmp = wl_sCodItmIni
                    wp_sCodErr = "10-101"
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    cmdCpd.Focus()
                Else

                    BD_ePEFOM_DT(wg_DTE1)
                    '   BD_BuscarIEDMI()
                    wl_ePEFOM.sCodItm = wl_sCodItmIni
                    wl_ePEFOM.sNomItm = ""
                    mtbsCodItm.Text = wl_sCodItmIni
                    BD_Var_ePEFOM()
                    mof_fLmpCtrl(Me.dgv1)
                    mof_fLmpCtrl(Me.dgv5)
                    dgv_DGV_DT()
                    mtbsCodItm.Text = wl_sCodItm
                    txtsNomItm.Text = ""
                    mtbsCodItm.Enabled = False
                    vl_sCodItm = wl_sCodItm
                    ' Plo_Frm_Var()
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
            dgv_ActualizarDetalle5(wp_sCmdSel)
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
                If dgv1.Rows(wl_nRow).Cells("sCodCmt").Value <> Nothing Then
                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLFOM1 = New moe_Estructuras.ePLFOM1
                    dgv1.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
                    moo_ePLFOM1_DGV(wl_ePLFOM1,
                                    Me.dgv1,
                                    wl_nRow)
                    '                  
                    If wl_ePLFOM1.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv1.Rows(wl_nRow).Visible = True Then
                        If dgv1.Rows(wl_nRow).Cells("sCodAlmCns").Value <> Nothing Then
                            wl_bYesNo = clnPEFOM.cnCrearActualizarPLFOM1(wl_ePLFOM1,
                                                                         wr_bEOFL1,
                                                                         wp_sCmdSel)
                        End If
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPEFOM.cnEliminarPLFOM1(wl_ePLFOM1,
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
    Private Function dgv_ActualizarDetalle5(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            vl_sCodItm = mtbsCodItm.Text
            For wl_nRow = 0 To dgv5.RowCount - 1
                If dgv5.Rows(wl_nRow).Cells("sCodAna").Value <> Nothing Then
                    wp_sCmdSel = wl_sCmdAnt
                    wl_ePLFOM5 = New moe_Estructuras.ePLFOM5
                    dgv5.Rows(wl_nRow).Cells("sCodItm").Value = mtbsCodItm.Text
                    moo_ePLFOM5_DGV(wl_ePLFOM5,
                                    Me.dgv5,
                                    wl_nRow)
                    If wl_ePLFOM5.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv5.Rows(wl_nRow).Visible = True Then

                        wl_bYesNo = clnPEFOM.cnCrearActualizarPLFOM5(wl_ePLFOM5,
                                                                     wr_bEOFL1,
                                                                     wp_sCmdSel)
                    Else
                        If wp_sCmdSel = "A" Then
                            wl_bYesNo = clnPEFOM.cnEliminarPLFOM5(wl_ePLFOM5,
                                                                  wr_bEOFL1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle5")
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
            dgv_DGV1_DT()
            dgv_DGV5_DT()
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV1_DT()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv1

        Try

            wg_DTL1 = clnPEFOM.cndtConsultarPLFOM1(vl_sCodItm,
                                                  wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    ReDim wl_aePLFOM1(wg_DTL1.Rows.Count - 1)
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow(dgv1)
                        moo_DGV_DTePLFOM1(vl_CtrlDgv,
                                          wg_DTL1,
                                          wl_nRow)
                        vl_sCodItm = dgv1.Rows(wl_nRow).Cells("sCodCmt").Value
                        wl_ePLFOM1 = New moe_Estructuras.ePLFOM1
                        moo_ePLFOM1_DT(wl_ePLFOM1,
                                       wg_DTL1,
                                       wl_nRow)
                        wl_aePLFOM1(wl_nRow) = wl_ePLFOM1
                    Next
                End With
            Else
                dgv_AdiRow(dgv1)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV_DT1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DGV5_DT()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = mtbsCodItm.Text
        vl_CtrlDgv = Me.dgv5
        Try
            wg_DTL1 = clnPEFOM.cndtConsultarPLFOM5(vl_sCodItm,
                                                  wr_bEOFL1)
            If vl_CtrlDgv.Rows.Count > 0 Then
                vl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                ReDim wl_aePLFOM5(wg_DTL1.Rows.Count - 1)
                With dgv5
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRow(vl_CtrlDgv)
                        moo_DGV_DTePLFOM5(vl_CtrlDgv,
                                          wg_DTL1,
                                          wl_nRow)
                        vl_sCodAna = vl_CtrlDgv.Rows(wl_nRow).Cells("sCodAna").Value
                        BD_BuscarATANA()
                        vl_CtrlDgv.Rows(wl_nRow).Cells("sNomAna").Value = wl_eATANA.sNomAna
                        vl_sCodTipAna = vl_CtrlDgv.Rows(wl_nRow).Cells("sCodTipAna").Value
                        BD_BuscarATTIA()
                        vl_CtrlDgv.Rows(wl_nRow).Cells("sNomTipAna").Value = wl_eATTIA.sNomTipAna
                        wl_ePLFOM5 = New moe_Estructuras.ePLFOM5
                        moo_ePLFOM5_DT(wl_ePLFOM5,
                                       wg_DTL1,
                                       wl_nRow)
                        wl_aePLFOM5(wl_nRow) = wl_ePLFOM5
                        wl_aePLFOM5(wl_nRow).sNomAna = wl_eATANA.sNomAna
                        wl_aePLFOM5(wl_nRow).sNomTipAna = wl_eATTIA.sNomTipAna
                    Next
                End With
            Else
                dgv_AdiRow(dgv5)
            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DGV5_DT")
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
    Private Sub dgv_PorLinPLFOM1()
        'fec_ult_act = 2014.10.27
        Dim wl_nCntRow As Integer
        Try
            vl_nPesItm = 0
            vl_nPorItm = 0
            vl_nCanCmtItm = 0
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            wl_ePLFOM1 = New moe_Estructuras.ePLFOM1
            For wl_i = 0 To wl_nCntRow - 1
                If dgv1.Rows(wl_i).Cells("bItmAct").Value = True Then
                    If dgv1.Rows(wl_i).Visible = True Then
                        vl_nPesItm = vl_nPesItm + dgv1.Rows(wl_i).Cells("nPesCmt").Value
                        vl_nCanCmtItm = vl_nCanCmtItm + dgv1.Rows(wl_i).Cells("nCanCmt").Value
                    End If
                End If
            Next

            For wl_i = 0 To wl_nCntRow - 1
                vl_nPorCmt = 0
                If dgv1.Rows(wl_i).Cells("bItmAct").Value = True Then
                    If dgv1.Rows(wl_i).Visible = True Then
                        If vl_nCanCmtItm <> 0 Then
                            'vl_nPorCmt = CInt((dgv1.Rows(wl_i).Cells("nCanCmt").Value / vl_nCanCmtItm) * 10000) / 100
                            vl_nPorCmt = CInt((dgv1.Rows(wl_i).Cells("nCanCmt").Value) * 100) / 100
                            dgv1.Rows(wl_i).Cells("nPorCmt").Value = vl_nPorCmt
                            '
                            vl_nPorItm = vl_nPorItm + vl_nPorCmt
                        End If
                    End If
                End If

            Next
            dgv_TotPEFOM()

        Catch ex As Exception
            MsgBox("Error: dgv_PorLinPLFOM1")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_TotPEFOM()
        Try
            'txtnPorItm.Text = FormatNumber(vl_nPorItm, 2)
            txtnPorItm.Text = FormatNumber(vl_nCanCmtItm, 2)
            txtnPesItm.Text = FormatNumber(vl_nPesItm, 2)
            txtnTieItm.Text = FormatNumber(vl_nTieItm, 2)
        Catch ex As Exception
            MsgBox("Error: dgv_TotPEFOM")
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
            wl_CtrlDgv = Me.dgv5
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
        wl_eAPDGV = New moe_Estructuras.eAPDGV
        ReDim wl_aeAPDGV(0)

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
            If wl_sCodDgv = "dgv5" Then
                wl_nTotCol5 = wl_nTotCol
                wl_nColFin5 = wl_nColFin
                wl_nColIni5 = wl_nColIni
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
    Private Sub dgv_EliminarLinea(ByVal vl_VlrCtrl As DataGridView)
        Dim wl_nRow As Integer
        Try
            If dgv1.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRow = (vl_VlrCtrl.Rows.Count).ToString
            wl_nCol = vl_VlrCtrl.CurrentRow.Index

            If wl_nRow >= 0 Then
                vl_VlrCtrl.Rows(wl_nCol).Visible = False
                wl_nCol = 0
                '     For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                For wl_nRow = 0 To vl_VlrCtrl.Rows.Count - 1
                    If vl_VlrCtrl.Rows(wl_nRow).Visible = True Then
                        vl_VlrCtrl.Rows(wl_nRow).HeaderCell.Value = (wl_nCol + 1).ToString
                        wl_nCol = wl_nCol + 1
                    End If
                Next
                vl_VlrCtrl.RefreshEdit()
            End If
            dgv_PorLinPLFOM1()
            dgv_TotPEFOM()
            cmdActualizar.Focus()
        Catch
            MsgBox("Error: dgv_EliminarLinea")
        End Try

    End Sub

#End Region '071 DGV Procedimientos del Usuario. Comunes
#Region "072 DGV Controladores de Eventos "
#Region "072 DGV Controladores de Eventos DGV1"
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
                Else
                    dgv1.CurrentRow.Selected = True
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

            dgv_PorLinPLFOM1()
            dgv_TotPEFOM()
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

                    wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                End If
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRow).Cells(wl_nCol)
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
#End Region
#Region "072 DGV Controladores de Eventos DGV5"
    'DGV3
    Private Sub dgv5_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv5.CellLeave
        Try
            If dgv5.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRowKD = e.RowIndex
            wl_nColKD = e.ColumnIndex
            wl_nRowKD = dgv5.CurrentCell.RowIndex
            wl_nColKD = dgv5.CurrentCell.ColumnIndex
        Catch ex As Exception
            MsgBox("Error : dgv5_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv5.CellMouseClick
        Try
            If dgv5.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            vl_CtrlDgv = Me.dgv5
            wl_sCodDgv = "dgv5"

            If dgv5.Rows.Count > 0 Then
                If dgv5.CurrentCell.ReadOnly = True Then
                    dgv5.CurrentCell = dgv5.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
            End If

        Catch ex As Exception

            MsgBox("Error : dgv5_CellMouseClick")
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub dgv5_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv5.CellMouseDoubleClick
        Try
            If dgv5.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            If dgv5.Rows.Count > 0 Then
                wl_CtrlDgv = Me.dgv5
                If dgv5.CurrentCell.ReadOnly = True Then
                    dgv5.CurrentCell = dgv5.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
                wl_nCol = e.ColumnIndex
                wl_nRow = e.RowIndex
                If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                    wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                End If
                wl_sCodDgv = "dgv5"
                dgv_APDGV()
                If wl_aeAPDGV(wl_nCol).sNomCmp = "sCodAna" Then
                    vl_sCodAna = dgv5.CurrentRow.Cells("sCodAna").Value
                    wl_bEOF = BD_BuscarATANA()
                    If wl_bEOF Then
                        BD_CargarATANA(wl_nCol)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv3_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv5.CellValueChanged
        If dgv5.Enabled = False Then
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
            MsgBox("Error : dgv5_CellValueChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv5.CurrentCellDirtyStateChanged
        Try
            If dgv5.IsCurrentCellDirty Then
                If cmdCrear.Visible = False Then
                    If cmdOk.Visible = True Then
                        mof_ActivarActualizar(Me)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv5_CurrentCellDirtyStateChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv5.DataError
        Try
            '   MessageBox.Show("Error en " & e.Context.ToString())
            wp_sNomTbl = " la Celda actual "
            wp_sDatCmp = dgv1.CurrentCell.Value
            wp_sCodErr = "11-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            dgv5.CurrentCell = dgv1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        Catch ex As Exception
            MsgBox("Error :  dgv5_DataError")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv5.KeyDown
        wl_CtrlDgv = Me.dgv5
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
            MsgBox("Error : dgv5_KeyDown")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv5.KeyPress
        Try
            wl_CtrlDgv = Me.dgv5
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
            MsgBox("Error : dgv5_KeyPress")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv5.KeyUp
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        Dim wl_bAdiRow As Boolean = False
        Try
            mof_LmpMsgError()
            wl_CtrlDgv = dgv5
            wl_sCodDgv = "dgv5"
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
            wl_nTotCol = wl_nTotCol5
            wl_nColIniGrl = wl_nColIni5
            wl_nColFin = wl_nColFin5
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
            mov_dgv_VdaPGFOM5(wl_nCol,
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
                                        dgv5,
                                        wl_bAdiRow)
                If wl_bAdiRow = True Then
                    dgv_AdiRow(dgv5)
                    wl_nRow = dgv5.CurrentCellAddress.Y
                End If
                dgv5.CurrentCell = dgv5.Rows(wl_nRow).Cells(wl_nCol)
            End If
            If wl_bRet = True Then
                wl_bRet = mof_dgvPrvCol(wl_nCol,
                                         wl_nRow,
                                         wl_nTotCol,
                                         wl_nColFin,
                                         wl_nColIniGrl,
                                         wl_nCntRow,
                                         dgv5,
                                         wl_nColKD)
                dgv5.CurrentCell = dgv5.Rows(wl_nRow).Cells(wl_nCol)
                dgv5.Focus()
            End If
            wl_nRowAnt = dgv5.CurrentCell.RowIndex
            wl_nColAnt = dgv5.CurrentCell.ColumnIndex

        Catch ex As Exception
            MsgBox("Error: dgv5_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv5.Leave
        Try
            If cmdCrear.Focused = True Then
                Exit Sub
            End If
            If cmdActualizar.Focused = True Then
                Exit Sub
            End If
            If dgv5.CurrentRow.ReadOnly = True Then
                cmdCancelar.Focus()
                Exit Sub
            End If
            wl_nRow = dgv5.CurrentCell.RowIndex
            wl_nCol = dgv5.CurrentCell.ColumnIndex
            If wl_nCol = wl_nColFin Then
                dgv5_KeyUp(Nothing,
                           Nothing)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv5_Leave")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region '072 DGV Controladores de Eventos "
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_LiberarFrm()
        Try
            If dgv1.RowCount > 0 Then
                dgv1.Rows.Clear()
                dgv1.Columns.Clear()
            End If
            If dgv5.RowCount > 0 Then
                dgv5.Rows.Clear()
                dgv5.Columns.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error : Plo_LiberarFrm")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_sNomFrm = "frmPEFOM"
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
            wl_nColIni5 = 0
            wl_nColFin1 = 0
            wl_nColFin2 = 0
            wl_nColFin3 = 0
            wl_nColFin5 = 0
            wl_nTotCol1 = 0
            wl_nTotCol2 = 0
            wl_nTotCol3 = 0
            wl_nTotCol5 = 0
            txtnCanLotStn.Text = 100
            chbbRegAci.Checked = True
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

            wl_sCodDgv = "dgv5"
            wl_CtrlDgv = Me.dgv5
            dgv_APDGV()
            mof_ConfigurarDGV(Me.dgv5,
                              wl_nTotCol)
            dgv_ConfiguraCol()
            If dgv5.RowCount > 0 Then
                dgv5.Rows.Clear()
            End If
            dgv_AdiRow(wl_CtrlDgv)
        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
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
            Plo_activarCmpAct()
            mof_ActivarBuscar(Me)
            Plo_IniciarVar()
            Plo_IniciarVarDGV()
            cmdCpd.Enabled = False
            mtbsCodItm.Enabled = True
            mtbsCodItm.Focus()
        Catch ex As Exception
            MsgBox("Error : Plo_ActivarBuscar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarCrear()
        Try
            Plo_activarCmpAct()
            mof_ActivarCrear(Me)
            Plo_IniciarVar()
            Plo_IniciarVarDGV()
            Cbo_CargarLst()
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
            cboATALM.Enabled = True
            chbbRegAci.Enabled = True
            cmdLstPEFOM.Enabled = True
            txtsRegSan.Enabled = True
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
            cboATALM.Enabled = False
            chbbRegAci.Enabled = False
            cmdLstPEFOM.Enabled = False
            txtsRegSan.Enabled = False
            cmdCpd.Enabled = False
            For wl_i = 0 To dgv5.Rows.Count - 1
                dgv5.Rows(wl_i).ReadOnly = True
                dgv5.Rows(wl_i).DefaultCellStyle.BackColor = wg_ClrReadOnlyT

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
            BD_BuscarPEFOM()
            If wr_bEOFE2 = False Then
                txtsNomItm.Text = wl_eIEDMI.sNomItm
                wr_bEOFE2 = BD_BuscarPEFOM()

                If wr_bEOFE2 Then
                    wp_sNomTbl = "PEFOM"
                    wp_sDatCmp = mtbsCodItm.Text
                    wp_sCodErr = "10-301"
                    mof_MsgError(wp_sNomTbl,
                                wp_sDatCmp,
                                wp_sCodErr)
                    mtbsCodItm.Focus()

                End If
            Else
                dgv1.Rows(0).Cells("sCodItm").Value = mtbsCodItm.Text
                dgv5.Rows(0).Cells("sCodItm").Value = mtbsCodItm.Text
                txtsNomItm.Focus()
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
                    cmdBuscar_Click(Nothing,
                                    Nothing)
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
    Private Sub mtbsCodItm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtbsCodItm.LostFocus
        Try
            mof_LmpMsgError()
            If cmdBuscar.Visible = True Then
                If Mid(mtbsCodItm.Text, 1, 1) <> " " Then
                    cmdBuscar_Click(Nothing,
                                    Nothing)
                Else
                    cmdLstPEFOM.Focus()
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
        Catch ex As Exception
            MsgBox("Error : mtbsCodItm_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region

#Region "090 Rpt - Reportes"
    Private Sub Rpt_PrmRpt()
        Try
            Dim wl_aePEFOM(0) As moe_Estructuras.ePEFOM
            BD_ePEFOM_Var()
            dgv_DGV_DT()
            wl_aePEFOM(0) = wl_ePEFOM
            
            wl_sNroALetras = mof_NroALetras(CType(wl_ePLFOM1.nCanCmt, String),
                                            wg_sCodMon)
            mof_ActivarOK(Me)

            If wl_aePLFOM1.Length <> 0 Then
                If wl_aePLFOM1(0).sCodItm <> "" Then
                    Dim wl_frmRPT As New rptPRFOM01
                    wl_frmRPT.wp_aePEFOM = wl_aePEFOM
                    wl_frmRPT.wp_aePLFOM1 = wl_aePLFOM1
                    wl_frmRPT.wp_aePLFOM5 = wl_aePLFOM5
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
            '        mof_inhabTsbBuscar()
            '        mof_inhabTsbCrear()
            '        mof_inhabTsbPASU()
            '        mof_inhabTsbEliminar()
            '        mof_LmpMsgError()
            '        Plo_LiberarFrm()
            Me.Close()
            '       mof_LmpMsgError()
        Catch ex As Exception
            MsgBox(wl_CtrlDgv.Name.ToString)
            MsgBox("Error: grl_Cerrar")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub grl_TextChange()

        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If

    End Sub
#End Region '150 grl Otros

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
            If TabControl1.SelectedTab Is TabPage2 Then
                wl_CtrlDgv = Me.dgv1
                wl_nColIni = wl_nColIni1

            End If
            If TabControl1.SelectedTab Is TabPage1 Then
                wl_CtrlDgv = Me.dgv5
                wl_nColIni = wl_nColIni5
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



#End Region 'PROCEDIMIENTOS EVENTOS COMUNES

    

End Class