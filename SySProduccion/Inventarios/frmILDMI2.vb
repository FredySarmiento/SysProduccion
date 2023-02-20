Public Class frmILDMI2


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
    Dim wr_bEOF1 As Boolean
    Dim wr_bEOF2 As Boolean
    ' Cadenas
    Dim wl_sCod As String
    Dim wl_nResMsg As String
    Dim wl_sCmdSel As String
    Dim wl_sDoc As String
    Dim wl_sNom As String
    Dim wl_sTipTbl As String
    Dim wp_sDatCmp As String
    Dim wp_sDatLla As String
    Dim wp_sNomCmp As String
    Dim wp_sNomLla As String
    Dim wp_sNomTbl As String
    Dim wp_sTipCmp As String
    Dim wl_sNomTbl As String
    Dim wl_sNomCmp As String
    Dim wl_sDatCmp As String
    Dim wl_sTipCmp As String
    Dim wl_sNomCmp1 As String
    Dim wl_sDatCmp1 As String
    Dim wl_sTipCmp1 As String
    Dim wl_sCodDgv As String


    'Numéricas
    Dim vp_nNroSig As Double
    Dim wl_nBoxMsg As Integer
    Dim wl_nTab As Integer
    Dim wl_nVlr As Double
    Dim wp_nNroOpc As Integer
#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vl_nId As Integer
    Dim vl_sCodItm As String
    Dim vl_sCodTer As String
    Dim vl_sCodLstPre As String
    Dim vl_nUltPreCom As Double
    Dim vl_bTerDfl As Boolean
#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    Dim wl_sOpeLgc As String  'Y, O, N
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
    Dim wl_nColVda1 As Integer  'columna a validar 1
    Dim wl_nColVda2 As Integer  'columna a validar 2
    Dim vl_nTamCmp As Integer
    Dim vl_nColFin As Integer
    Dim vl_nColIni As Integer

    'Filas
    Dim wl_bVdaRow As Boolean
    Dim wl_nCellCod As Integer
    Dim wl_nCellDes As Integer
    Dim wl_nCntRow As Integer


    Dim wl_N As Integer ' dgv1.Rows.Add
    Dim wl_nRow As Integer
    Dim wl_nRowAlto As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nRowIni As Integer
    Dim wl_nRowKD As Integer
    Dim wl_nRowKP As Integer
    Dim wl_nRowKU As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nRowSig As Integer

    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fila

#End Region
#Region "014 Objetos locales"
    Dim clnILDMI2 As New ClaseNegocios.clnIEDMI
    Dim clnConTbl As New ClaseNegocios.clnConTbl
    Dim wl_CtrlDgv As New DataGridView


#End Region
#Region "015 Estructuras"
    Dim wl_eILDMI2 As New moe_Estructuras.eILDMI2
    Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
#End Region
#Region "018 Errores"
    Dim wl_sCoderr As String
    'Código de error
#End Region
#Region "019 Fin 010.  vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "020 frm Eventos - Principal"
    Private Sub frmILDMI2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text += "  -  " + vg_sNomCia
        wp_sNomFrm = "frmILDMI2"
        Me.BackColor = wg_ClrFrm
        vl_sCodItm = vg_sCodItm
        Plo_IniciarVar()
        wg_sCodStr = ""
        wg_sTblCon1 = "ILDMI2"
        wl_nTotCol = 10
        wg_sCodStr = "QRY_EILDMI2"
        'dgv_APDGV(wp_sNomFrm)
        dgv_APQDG(wg_sCodStr)
        Plo_IniciarVarDGV()
        dgv_ConILDMI2(vl_sCodItm)
        dgv_AdiRowDet()

    End Sub
#End Region

#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_CargarTEDMT(ByVal wl_CellCod As Integer,
                               ByVal wl_CellDes As Integer,
                               ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmGQLst
            wg_sTblCon1 = "TEDMT_2"
            wg_sCmpCon12 = "sNomTer"
            wg_sTitCon11 = "Código tercero"
            wg_sTitCon12 = "Nombre tercero"
            wg_sSelCon11 = ""
            wg_sSelCon12 = ""
            wr_bEOFCon1 = True
            wl_frmLst.ShowDialog()
            dgv1.CurrentRow.Cells(wl_CellCod).Value = wg_sSelCon11
            ' dgv1.CurrentRow.Cells(wl_CellDes).Value = wg_sSelCon12
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarTEDMT")
        End Try
    End Sub

    Private Sub BD_eILDMI2_Var(ByVal wl_nRow)

        Try
            wl_eILDMI2 = New moe_Estructuras.eILDMI2
            moo_eILDMI2_DGV(wl_eILDMI2,
                            Me.dgv1,
                            wl_nRow)


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_eILDMI2_Var")
        End Try


    End Sub
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            wl_sCmdSel = "A"
            wl_bYesNo = False
            wr_bEOFE1 = True
            wl_bYesNo = dgv_ActualizarDetalle(wl_sCmdSel)
            mof_ActivarOK(Me)
            dgv_AdiRowDet()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmdActualizar_Click")
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        grl_Cerrar()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wl_sCmdSel = "O"
        grl_Cerrar()
    End Sub
#End Region

#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Sub dgv_AdiRowDoc()
        Try
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRowDoc")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_AdiRowDet()
        Try
            With dgv1
                wl_nCntRow = .RowCount
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                ' .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                .CurrentCell = .Rows(wl_nRow).Cells(2)
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                Dim wl_dgvrows As DataGridViewRow = dgv1.Rows(wl_nRow)
                wl_dgvrows.Height = 16
                .CurrentRow.Cells(1).Value = vl_sCodItm
                ' .CurrentRow.Cells(2).Value = vl_sCodTer
                .CurrentRow.HeaderCell.Value = (dgv1.CurrentRow.Index + 1).ToString
                '.CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                '.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIniGrl)
            End With
            wl_nTab = 0
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count
            dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
            '  dgv1.Rows(wl_nRow).Cells(1).Value = txtSCodItm.Text
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRowDet")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_CrearPrimeraLinea()
        Try
            With dgv1
                dgv1.Rows.Add()
                dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nRow + 1).ToString
                dgv1.Rows(wl_nRow).Cells(1).Value = vg_sCodItm
                wr_bEOFL1 = True
                wg_sTblLst1 = "ILDMI2"
                wg_sCmpLst1 = "sCodTer"
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
    Private Sub dgv_ConILDMI2(ByVal vp_sCodItm)
        Try
            Dim vl_nConRow As Integer
            Dim vl_Qry_aeILDMI2() As moe_Estructuras.Qry_eILDMI2


            wr_bEOFCon1 = False
            wg_DTCon1 = clnIEDMI.cndtConItmILDMI2(vp_sCodItm,
                                                  wr_bEOFCon1)
            vl_nConRow = wg_DTCon1.Rows.Count()

            ReDim vl_Qry_aeILDMI2(vl_nConRow)
            If Not wr_bEOFCon1 Then
                moo_Qry_aeILDMI2_DT(vl_Qry_aeILDMI2,
                                    wg_DTCon1)
                moo_DGV_Qry_aeILDMI2(Me.dgv1,
                                    vl_Qry_aeILDMI2)

            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConILDMI2")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wr_bEOFL1 = True
        vl_sCodItm = vg_sCodItm
        Try
            wg_DTL1 = clnIEDMI.cndtConItmILDMI2(vl_sCodItm,
                                                wr_bEOFL1)


            If dgv1.Rows.Count > 0 Then
                dgv1.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With dgv1
                    For wl_nRow = 0 To wg_DTL1.Rows.Count - 1
                        dgv_AdiRowDet()

                        moo_DGV_DT_eILDMI2(Me.dgv1,
                                           wg_DTL1,
                                           wl_nRow)

                    Next
                End With
                'dgv_SumaFormatea()

            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DetADgv")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DgvADet1()
        Dim wl_nRow As Integer
        wr_bEOF1 = True
        Try

            With dgv1
                For wl_nRow = 0 To dgv1.Rows.Count - 1
                    wl_eILDMI2 = New moe_Estructuras.eILDMI2
                    moo_eILDMI2_DGV(wl_eILDMI2,
                                    Me.dgv1,
                                    wl_nRow)
                    wl_sNomTbl = "ILDMI2"
                    wl_sNomCmp = "sCodItm"
                    wl_sDatCmp = wl_eILDMI2.sCodItm
                    wl_sTipCmp = "S"
                    wl_sNomCmp1 = "sCodTer"
                    wl_sDatCmp1 = wl_eILDMI2.sCodTer
                    wl_sTipCmp1 = "S"

                    If wl_sDatCmp1 <> "" Then



                        wg_DTL1 = clnConTbl.cndtBuscarE2(wl_sNomTbl,
                                                         wl_sNomCmp,
                                                         wl_sDatCmp,
                                                         wl_sTipCmp,
                                                         wl_sNomCmp1,
                                                         wl_sDatCmp1,
                                                         wl_sTipCmp1,
                                                         wr_bEOF1)
                        If wr_bEOF1 Then
                            wl_sCmdSel = "C"
                        Else
                            wl_sCmdSel = "A"
                        End If

                        wr_bEOF1 = clnIEDMI.cnCrearActualizarILDMI2(wl_eILDMI2,
                                                               wr_bEOF1,
                                                               wl_sCmdSel)

                    End If

                Next
            End With

        Catch ex As Exception
            MsgBox("Error en: dgv_DgvADet")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function dgv_ActualizarDetalle(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        wl_eILDMI2 = New moe_Estructuras.eILDMI2
        Try
            vl_sCodItm = vg_sCodItm
            For wl_nRow = 0 To dgv1.RowCount - 1
                BD_eILDMI2_Var(wl_nRow)
                If wl_eILDMI2.sCodTer <> Nothing Then
                    wp_sCmdSel = wl_sCmdAnt
                    If wl_eILDMI2.nId <> 0 Then
                        wp_sCmdSel = "A"
                    Else
                        wp_sCmdSel = "C"
                    End If
                    If dgv1.Rows(wl_nRow).Visible = True Then
                        clnIEDMI.cnCrearActualizarILDMI2(wl_eILDMI2,
                                                         wp_bEOF2,
                                                         wp_sCmdSel)
                    Else
                        vl_sCodItm = wl_eILDMI2.sCodItm
                        vl_sCodTer = wl_eILDMI2.sCodTer
                        wl_bYesNo = clnIEDMI.cnEliILDMI2(vl_sCodItm,
                                                         vl_sCodTer,
                                                         wp_bEOF2)

                    End If
                End If

            Next
            dgv_DetADgv()
        Catch ex As Exception
            MsgBox("Error : dgv_ActualizarDetalle")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo

    End Function
    Private Sub dgv_LstADgv()
        Dim wl_nRow As Integer
        Dim wl_nCol As Integer
        Dim wl_nRowDgv As Integer
        wl_nRow = 0
        Try
            wl_nRowDgv = 0
            If dgv1.Rows.Count > 1 Then
                wl_nRowDgv = dgv1.Rows.Count - 1
            End If
            moo_DGVMov1_aePLODP1(Me.dgv1,
                             wg_aePLODP1)
            With dgv1
                For wl_nRow = 0 To dgv1.Rows.Count - 2
                    .Rows(wl_nRowDgv).Cells(1).Value = vl_sCodItm
                    .Rows(wl_nRowDgv).Cells(2).Value = vl_sCodTer
                    For wl_nCol = 0 To wg_aeAPDGV.Length - 1
                        If wg_aeAPDGV(wl_nCol).bColTot = True Then
                            If wg_aeAPDGV(wl_nCol).sDesOpe = "Ope_16" Then
                                mof_fOpe_16(Me.dgv1,
                                            wl_nRowDgv)
                            End If
                        End If
                    Next
                    wl_nRowDgv = wl_nRowDgv + 1
                Next

            End With

            dgv1.CurrentCell = dgv1.Rows(wl_nRowDgv).Cells(wl_nColIniGrl)
            With dgv1
                .Rows(wl_nRowDgv).Cells(1).Value = vl_sCodItm
                .Rows(wl_nRowDgv).Cells(2).Value = vl_sCodTer
            End With

            cmdOk.Focus()
        Catch ex As Exception
            MsgBox("Error: dgv_LstADgv")
        End Try
    End Sub
    Private Sub dgv1_Valida1()
        Try
            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = ""
            If wl_sOpeLgc = "Y" Then
                If wl_nCol <> wl_nColVda1 Then
                    If wl_nCol <> wl_nColVda2 Then
                        If dgv1.Rows(wl_nRow).Cells(wl_nColVda1).Value Is Nothing Or
                            dgv1.Rows(wl_nRow).Cells(wl_nColVda2).Value Is Nothing Then
                            wp_sCodErr = wl_sCoderr
                        End If
                    End If
                End If
            End If
            If wl_sOpeLgc = "O" Then
                If wl_nCol <> wl_nColVda1 Then
                    If dgv1.Rows(wl_nRow).Cells(wl_nColVda1).Value Is Nothing Then
                        If wl_nCol <> wl_nColVda2 Then
                            If dgv1.Rows(wl_nRow).Cells(wl_nColVda2).Value Is Nothing Then
                                wp_sCodErr = wl_sCoderr
                            End If
                        End If
                    End If
                End If
            End If
            If wl_sOpeLgc = "N" Then
                If wl_nCol <> wl_nColVda1 Then
                    If dgv1.Rows(wl_nRow).Cells(wl_nColVda1).Value Is Nothing Then
                        wp_sCodErr = wl_sCoderr
                    End If
                End If
            End If

            If wp_sCodErr <> "" Then
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColVda1)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Error : dgv1_Valida")
        End Try

    End Sub
    Private Function dgv1_VdaRow(ByRef wl_bVdaRow) As Boolean
        wl_nRow = dgv1.CurrentCellAddress.Y
        wl_nCol = dgv1.CurrentCellAddress.X
        If dgv1.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
            dgv1.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Or
            dgv1.Rows(wl_nRow).Cells(wl_nCol).Value = Nothing Then
            wl_bVdaRow = False
        End If
        Return wl_bVdaRow

    End Function
#End Region
#Region "071 DGV Procedimientos del Usuario. Comunes"
    Private Sub dgv_AdiLinBlanco(ByVal wl_nRowVacia As Integer)
        For wl_nF = 0 To wl_nRowVacia
            dgv1.Rows.Add()
        Next
    End Sub
    Private Sub dgv_APDGV(ByVal wg_sCodStr As String)
        'Fec_Ult_Mod: 2014.04.20
        Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
        Try
            wg_nColIni = 0
            wg_nColFin = 0
            vl_nColIni = 0
            vl_nColFin = 0
            wg_aeAPDGV = mof_fConAPDGV(wp_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            vl_nColIni = wg_nColIni
            vl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin
            wl_nTotCol = UBound(wg_aeAPDGV) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APDGV")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_APQDG(ByVal vp_sCodStr As String)
        Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
        wl_eAPQDG = New moe_Estructuras.eAPQDG
        ' wg_sCodStr = "EIELDMI1"

        Try
            wg_nColIni = 0
            wg_nColFin = 0
            vl_nColIni = 0
            vl_nColFin = 0
            wl_aeAPQDG = mof_fConAPQDG(vp_sCodStr)
            wl_nColIniGrl = wg_nColIni
            vl_nColIni = wg_nColIni
            vl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin

            wl_nTotCol = UBound(wl_aeAPQDG) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APQDG")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_AvanzaCol1()
        Dim wl_i As Integer
        Try
            wl_i = wl_nCol

            If dgv1.CurrentCell.Visible = False Then
                For wl_i = wl_nCol To wl_nTotCol - 1
                    If dgv1.CurrentCell.Visible = True Then
                        Exit For
                    End If
                Next
                wl_nCol = wl_i

            End If

            If dgv1.CurrentCell.ReadOnly = True Then
                For wl_i = wl_nCol To wl_nTotCol - 1
                    If dgv1.CurrentCell.Visible = False Then
                        dgv_AvanzaCol()
                    End If
                    dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_i)

                    If dgv1.CurrentCell.ReadOnly = False Then
                        Exit For
                    End If
                Next
                wl_nCol = wl_i


            End If


            If wl_nCol > wg_nColFin Then

                wl_bVdaRow = True
                wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nRow < wl_nCntRow - 1 Then
                        wl_nRow = wl_nRow + 1
                    Else
                        dgv_AdiRowDet()
                        wl_nRow = dgv1.CurrentCellAddress.Y
                    End If
                End If
                wl_nCol = wl_nColIniGrl
            End If
            dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
            '  dgv_SumaFormatea()
        Catch ex As Exception
            MsgBox("Error :  dgv_AvanzaCol")
            MsgBox(ex.Message)
        End Try
    End Sub

    '

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
                        dgv_AdiRowDet()
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
    '


    Private Sub dgv_CnfColAPDGV()
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
    Private Sub dgv_CnfColAPQDG()
        Dim wl_bCnfVis As Boolean = False
        Dim vl_sNomCmp As String
        Dim vl_sTitCol As String
        wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
        For wp_nC = 0 To wl_nTotCol - 1
            wp_bVisible = True
            wp_bReadOnly = False
            wp_bColxDef = False
            wp_sTipCol = "S"
            wl_eAPQDG = wl_aeAPQDG(wp_nC)
           
            With wl_eAPQDG
                wp_sTipCol = .sTipCol
                wp_bVisible = .bVisible
                wp_bReadOnly = .bReadOnly
                wp_bColxDef = .bColxDef
                vl_sNomCmp = .sNomCmp
                vl_nTamCmp = .nTamCmp
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
    Private Sub dgv_EliminarLinea()
        ' FUA : 2014-10-23
        Dim wl_nRow As Integer
        Dim wl_nRowVis As Integer
        Try
            wl_nRow = (dgv1.Rows.Count).ToString
            wl_nCol = dgv1.CurrentRow.Index
            wl_nRowKD = dgv1.CurrentCell.RowIndex

            moo_eILDMI2_DGV(wl_eILDMI2,
                                Me.dgv1,
                                wl_nRowKD)
            If wl_eILDMI2.sCodTer <> Nothing Then
                dgv1.Rows(wl_nRowKD).Visible = False
                wl_nRowVis = 0
                For wl_nRow = 0 To dgv1.Rows.Count - 1
                    If dgv1.Rows(wl_nRow).Visible = True Then
                        dgv1.Rows(wl_nRow).HeaderCell.Value = (wl_nCol + 1).ToString
                        wl_nRowVis = wl_nRowVis + 1
                    End If
                Next
                dgv1.RefreshEdit()
                wl_nRow = (dgv1.Rows.Count).ToString - 1
                dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nColIni)
            End If
        Catch
            MsgBox("Error: dgv_EliminarLinea")
        End Try

    End Sub
    Private Sub dgv_RetroCol1()
        Dim wl_i As Integer
        Try
            wl_i = wl_nColKD - 1
            wl_nCol = wl_i
            dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_i)
            If dgv1.CurrentCell.ReadOnly = True Then
                For wl_i = wl_nCol To wl_nColIniGrl Step -1
                    dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_i)
                    If dgv1.CurrentCell.ReadOnly = False Then
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
            dgv1.CurrentCell = dgv1.Rows(wl_nRow).Cells(wl_nCol)
            'dgv_SumaFormatea()



        Catch ex As Exception
            MsgBox("Error :  dgv_RetrocedeCol")
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
            MsgBox("Error :  dgv_RetroCol")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "072 DGV Controladores de Eventos Personalizados "

    Private Sub dgv1_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellLeave

        Try
            wl_nColKD = e.ColumnIndex
        Catch ex As Exception
            MsgBox("Error :  dgv1_CellLeave")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        wl_nCol = e.ColumnIndex
        wl_nRow = e.RowIndex
        Try
            If dgv1.CurrentCell.ReadOnly = True Then
                dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            End If
            Dim wl_frmLst As New frmGQLst
            If e.ColumnIndex = wl_nCol Or e.ColumnIndex = wl_nCol Then
                BD_CargarTEDMT(wl_nCol,
                               wl_nCol,
                               wl_nCol)
                mof_ActivarActualizar(Me)
            End If
        Catch ex As Exception
            MsgBox("Error :  dgv1_CellMouseDoubleClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellValueChanged
        If dgv1.Enabled = False Then
            Exit Sub
        End If
        wl_nCol = e.ColumnIndex
        wl_nRow = e.RowIndex

        Return

        Try
            If dgv1.Rows.Count > 0 Then
                wl_nRow = e.RowIndex
                wl_nCol = e.ColumnIndex

                If wl_nCol = 9 Or
                    wl_nCol = 11 Or
                    wl_nCol = 12 Or
                    wl_nCol = 13 Then
                    'dgv_SumaFormatea()
                    wl_nNroCol = wl_nCol
                End If
            End If
        Catch
            MsgBox("Error : dgv1_CellValueChanged")
        End Try
    End Sub
    Private Sub dgv1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyUp
        ' Fec Ult Act 2014.04.19
        ' frmILDMI2
        Dim wl_bAva As Boolean = False
        Dim wl_bRet As Boolean = False
        wp_sNomFrm = "frmILDMI2"
        wl_sCod = ""
        wl_sNom = ""
        wl_nVlr = 0
        wl_sDoc = ""

        wl_sNomTbl = ""
        Try
            wl_nRowKU = dgv1.CurrentCell.RowIndex
            wl_nColKU = dgv1.CurrentCell.ColumnIndex
            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nRowAnt = dgv1.CurrentCellAddress.Y
            wl_nRowSig = dgv1.CurrentCellAddress.Y
            wl_nCntRow = dgv1.Rows.Count

            wl_nCol = dgv1.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wl_nColSig = dgv1.CurrentCellAddress.X
            wl_nCntCol = dgv1.ColumnCount

            If e.KeyCode = Keys.Tab Then
                wl_bAva = True
            End If
            If e.Shift AndAlso e.KeyCode = Keys.Tab Then
                wl_bRet = True
            End If


            wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nCol = dgv1.CurrentCellAddress.X
            wl_nColSig = dgv1.CurrentCellAddress.X
            wl_nColAnt = wl_nColKD
            wp_nColNom = wl_nColAnt
            wp_nColVlr = wl_nColAnt
            mov_dgv_VdaAPQDG(wl_nCol,
                             wl_nColAnt,
                             wl_nColSig,
                             wl_nRow,
                             wl_nRowAnt,
                             wl_nRowSig,
                             Me.dgv1,
                             wl_aeAPQDG)
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

#End Region
#Region "073 DGV Controladores de eventos del Comunes"
    Private Sub dgv1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Try

            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = ""

            wl_nRow = e.RowIndex
            wl_nCol = e.ColumnIndex
            If dgv1.Enabled = False Then
                Exit Sub
            End If
            If dgv1.CurrentCell.ReadOnly = True Then
                'dgv1_Valida()
                dgv1.CurrentCell = dgv1.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Error : dgv1_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyDown
        If e.KeyCode = Keys.Tab Then
            wl_nRowKD = dgv1.CurrentCellAddress.Y
            wl_nColKD = dgv1.CurrentCellAddress.X
            wl_nRowKD = dgv1.CurrentCell.RowIndex
            wl_nColKD = dgv1.CurrentCell.ColumnIndex
        End If
        If e.Shift AndAlso e.KeyCode = Keys.Tab Then
            wl_nRowKD = dgv1.CurrentCellAddress.Y
            wl_nColKD = dgv1.CurrentCellAddress.X
            wl_nRowKD = dgv1.CurrentCell.RowIndex
            wl_nColKD = dgv1.CurrentCell.ColumnIndex
        End If


    End Sub
    Private Sub dgv1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgv1.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Then
            wl_nRowKP = dgv1.CurrentCellAddress.Y
            wl_nColKP = dgv1.CurrentCellAddress.X
            wl_nRowKP = dgv1.CurrentCell.RowIndex
            wl_nColKP = dgv1.CurrentCell.ColumnIndex
        Else
            wl_nRowKP = dgv1.CurrentCellAddress.Y
            wl_nColKP = dgv1.CurrentCellAddress.X
            wl_nRowKP = dgv1.CurrentCell.RowIndex
            wl_nColKP = dgv1.CurrentCell.ColumnIndex

        End If
    End Sub

#End Region
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_IniciarDoc()
    End Sub
    Private Sub Plo_IniciaILDMI2()
        wp_sNomFrm = "frmILDMI2"
        wl_bSwsCbo = False
    End Sub
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            vl_sCodItm = vg_sCodItm
            wl_bVdoVta = False
            wl_bVdoCom = False
            wl_sCodDgv = "dgv1"
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
            wg_sTitMsgAdi = "Salida de materiales"
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
        '  wl_nColVda1 = 4
        ' wl_nColVda2 = 5

        wl_sOpeLgc = "Y"
        wl_CtrlDgv = Me.dgv1



        mof_ConfigurarDGV(wl_CtrlDgv,
                          wl_nTotCol)
        dgv_CnfColAPQDG()
        'dgv_CnfColAPDGV()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        dgv_EliminarLinea()
        mof_ActivarActualizar(Me)
    End Sub
    Private Sub ListaTercerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaTercerosToolStripMenuItem.Click
        Try
            wl_nRowKD = dgv1.CurrentCell.RowIndex
            wl_nColKD = dgv1.CurrentCell.ColumnIndex
            BD_CargarTEDMT(wl_nColKD,
                           wl_nColKD,
                           wl_nColKD)
            mof_ActivarActualizar(Me)
        Catch ex As Exception
            MsgBox("Error :  ListaTercerosToolStripMenuItem_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "150 grl Otros"
    Private Sub grl_Cerrar()
        Me.Close()
    End Sub
#End Region
#Region "170 TSMI ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
        Try
            dgv_AdiRowDet()
        Catch ex As Exception
            MsgBox("Error :  tsmi_CrearLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tsmi_EliminarLinea()
        Try
            mof_ActivarActualizar(Me)
            dgv_EliminarLinea()
        Catch ex As Exception
            MsgBox("Error :  tsmi_EliminarLinea")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region





   
End Class