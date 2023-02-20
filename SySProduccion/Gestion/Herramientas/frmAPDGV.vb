Public Class frmAPDGV
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23
#Region "001 Inicia. wg - vg Definición del variables públicas"

    'Estructuras
    Public Property wp_eAPDGV As moe_Estructuras.eAPDGV
    'variables
    Public Property vp_sCodFrm As String
    Public Property vp_sCodDgv As String


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
    Dim vl_sCodFrm As String
    Dim vl_sCodDgv As String
    Dim vl_nColOri As Long

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
    Dim clnAPDGV As New ClaseNegocios.clnAPDGV
    Dim wl_CtrlDgv As New DataGridView
    Dim wl_DTL1 As DataTable

#End Region
#Region "015 Estructuras"

    Dim wl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim vl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim vl_eAPDGV As New moe_Estructuras.eAPDGV
    
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

    Private Sub frmAPDGV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            mof_fCnfCtrl(Me)
            mof_IniciarVar()
            Plo_IniciarVar()
            Plo_IniciarVarDGV()
            Plo_IniciarFrm()
        Catch ex As Exception
            MsgBox("Error : frmAPDGV_Load")
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region

#Region "040 BD"
#Region "040 BD Procedimientos sobre la BD. Personalizados"


    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nI1 As Integer = 0
        wl_bYesNo = True
        Try


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: cmd_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
#End Region
#Region "043 BD Cargar"
    Private Sub BD_CargarAPDGV(ByVal wl_CellCod As Integer,
                                ByVal wl_CellDes As Integer,
                                ByVal wl_CellSig As Integer)
        Try

            Dim wl_frmLst As New frmAPDGV
            vl_eAPDGV = New moe_Estructuras.eAPDGV


            wl_frmLst.wp_eAPDGV = New moe_Estructuras.eAPDGV
            wl_frmLst.ShowDialog()
            wl_nRowAct = wl_CtrlDgv.CurrentCellAddress.Y
            If wl_frmLst.wp_eAPDGV.sCodFrm <> "" Then

            End If
            dgv1.CurrentCell = dgv1.CurrentRow.Cells(wl_CellSig)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_CargarAPDGV")
        End Try
    End Sub

#End Region
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Try
            wp_sCmdSel = "A"
            wl_bYesNo = False
            wr_bEOFE1 = True
            wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
            If wl_bYesNo Then
                wl_bYesNo = dgv_ActDetAPDGV(wp_sCmdSel)
                wp_sNomTbl = wl_sNomTblE1
                wp_sDatCmp = ""
                wp_sCodErr = wl_sCodErrOk
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)

                mof_ActivarOK(Me)
                cmdOk.Focus()
            Else
                cmdCancelar.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error :  cmdActualizar_Click")
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

#Region "070 DGV Procedimientos"
#Region "070 DGV Procedimientos del Usuario. Personalizados"
    Private Function dgv_ActDetAPDGV(ByVal wp_sCmdSel As String) As Boolean
        Dim wl_nRow As Integer
        Dim wl_sCmdAnt As String
        wl_sCmdAnt = wp_sCmdSel
        wl_bYesNo = False
        Try
            wl_CtrlDgv = Me.dgv1

            For wl_nRow = 0 To dgv1.RowCount - 1

                wp_sCmdSel = wl_sCmdAnt
                vl_eAPDGV = New moe_Estructuras.eAPDGV
                moo_eAPDGV_DGV(vl_eAPDGV,
                                Me.dgv1,
                                wl_nRow)
                '                  
                If vl_eAPDGV.nID <> 0 Then
                    wp_sCmdSel = "A"
                Else
                    wp_sCmdSel = "C"
                End If
                If dgv1.Rows(wl_nRow).Visible = True Then
                    wl_bYesNo = clnAPDGV.cnCrearActualizar(vl_eAPDGV,
                                                               wr_bEOFL1,
                                                               wp_sCmdSel)
                Else
                    If wp_sCmdSel = "A" Then
                        wl_bYesNo = clnAPDGV.cnEliminar(vl_eAPDGV,
                                                        wr_bEOFL1)
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox("Error : dgv_ActDetAPDGV")
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

            wl_CtrlDgv = Me.dgv1

            wl_nCntRow = wl_CtrlDgv.RowCount - 1

            With wl_CtrlDgv
                wl_nCntRow = .RowCount
                .Rows.Add()
                wl_nCntRow = .RowCount
                wl_nRow = wl_nCntRow - 1
                .RowTemplate.Height = wl_nRowAlto
                .Font = New System.Drawing.Font("Sans Serif", 8, FontStyle.Regular)
                '   .CurrentCell = .Rows(wl_nRow).Cells(wl_nColIniGrl)
                '   .CurrentRow.HeaderCell.Value = (wl_CtrlDgv.CurrentRow.Index + 1).ToString
                '   .CurrentRow.Cells("sCodFrm").Value = vp_sCodFrm
            End With
            wl_nTab = 0
            ' wl_nRow = dgv1.CurrentCellAddress.Y
            wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
            '  wl_nCntRow = dgv1.Rows.Count
            wl_nCntRow = wl_CtrlDgv.Rows.Count
            '  wl_CtrlDgv.Rows(wl_nRow).HeaderCell.Value = (wl_nCntRow).ToString
        Catch ex As Exception
            MsgBox("Error : dgv_AdiRow")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_DetADgv()
        Dim wl_nRow As Integer
        wl_DTL1 = New DataTable

        ReDim vl_aeAPDGV(0)

        wl_CtrlDgv = Me.dgv1
        vl_eAPDGV = New moe_Estructuras.eAPDGV
        vl_eAPDGV.sCodFrm = vp_sCodFrm
        vl_eAPDGV.sCodDgv = vp_sCodDgv
       
        Try
            wl_DTL1 = clnAPDGV.cndtConAPDGV(vl_eAPDGV,
                                            wl_bEOF)

            If wl_CtrlDgv.Rows.Count > 0 Then
                wl_CtrlDgv.Rows.Clear()
            End If

            If Not wr_bEOFL1 Then
                With wl_CtrlDgv
                    For wl_nRow = 0 To wl_DTL1.Rows.Count - 1
                        dgv_AdiRow()
                        vl_eAPDGV = New moe_Estructuras.eAPDGV
                        moo_eAPDGV_DT(vl_eAPDGV,
                                      wl_DTL1,
                                      wl_nRow)
                        moo_DGV_eAPDGV(wl_CtrlDgv,
                                       vl_eAPDGV,
                                       wl_nRow)
                    Next
                End With


            End If
        Catch ex As Exception
            MsgBox("Error en: dgv_DetADgv")
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
            wl_aeAPDGV = mof_fConAPDGV(wl_sNomFrm,
                                       wl_sCodDgv)
            wl_nColIniGrl = wg_nColIni
            wl_nColIni = wg_nColIni
            vl_nColFin = wg_nColFin
            wl_nColFinGrl = wg_nColFin
            wl_nTotCol = UBound(wl_aeAPDGV) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APDGV")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_AvanzaCol()
        'FUA : 2014.10.31
        Dim wl_i As Integer
        Try
            wl_nCntRow = wl_CtrlDgv.Rows.Count
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
                        If wl_CtrlDgv.Rows(wl_nRow).Cells(wl_i).ReadOnly = False Then
                            Exit For
                        Else

                            Continue For
                        End If
                    End If
                End If

                Exit For
            Next
            '    If wl_i > wl_nTotCol - 1 Then
            ' wl_i = wl_nTotCol - 1
            ' End If

            wl_nCol = wl_i
            If wl_nCol > vl_nColFin Then
                wl_bVdaRow = True
                '  wl_bVdaRow = dgv1_VdaRow(wl_bVdaRow)
                If wl_bVdaRow Then
                    If wl_nRow < wl_nCntRow - 1 Then
                        wl_nRow = wl_nRow + 1
                    Else
                        dgv_AdiRow()
                        wl_nRow = wl_CtrlDgv.CurrentCellAddress.Y
                        wl_nRow = wl_nRow + 1
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
                wl_eAPDGV = wl_aeAPDGV(wp_nC)
                '  With wl_CtrlDgv
                '.Columns(wp_nC).HeaderText = wl_eAPDGV.sTitCol
                'End With
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

            wp_sNomTbl = wl_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = ""
            wl_nRow = e.RowIndex
            wl_nCol = e.ColumnIndex
            If wl_CtrlDgv.Enabled = False Then
                Exit Sub
            End If
            If wl_CtrlDgv.CurrentCell.ReadOnly = True Then
                'dgv1_Valida()
                wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
                Exit Sub
            End If

           
            If cmdOk.Visible = True Then
                mof_ActivarActualizar(Me)
            End If








        Catch ex As Exception
            MsgBox("Error en: dgv1_CellMouseClick")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseDoubleClick
        If wl_CtrlDgv.Enabled = False Then
            Exit Sub
        End If
        wl_nCol = e.ColumnIndex
        wl_nRow = e.RowIndex
        Try

            

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
            If cmdOk.Visible = True Then
                mof_ActivarActualizar(Me)
            End If



        Catch ex As Exception
            MsgBox("Error :  dgv1_CellValueChanged")
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
            wl_bVda = True
            '    mov_dgv_VdaPLROP1(wl_nCol,
            '                      wl_nColAnt,
            '                      wl_nColSig,
            '                      wl_nRow,
            '                      wl_nRowAnt,
            '                      wl_nRowSig,
            '                      wl_CtrlDgv,
            '                      wg_aeAPDGV,
            '                      wl_bVda)
            '    If wl_bVda = False Then
            ' wl_CtrlDgv.CurrentCell = wl_CtrlDgv.Rows(wl_nRowAnt).Cells(wl_nColAnt)
            ' Exit Sub
            ' End If


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
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_ActivarCmpAct()
        Try

            wl_sCodDgv = "dgv1"
            wl_CtrlDgv = Me.dgv1
            dgv_APDGV()
            dgv_ConfiguraCol()

        Catch ex As Exception
            MsgBox("Error :  Plo_ActivarCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_InactCmpAct()
        Try

            For i = 0 To wl_aeAPDGV.Length - 1
                wl_aeAPDGV(i).bReadOnly = True
            Next
            dgv_ConfiguraCol()

        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpAct")
            MsgBox(ex.Message)

        End Try


    End Sub
    Private Sub Plo_IniciarFrm()
        Try
            wl_bYesNo = False
            wl_bEdit = False
            wl_sNomFrm = "frmAPDGV"
            wl_sNomTblE1 = "APDGV"
            dgv_DetADgv()
            mof_ActivarOK(Me)
            cmdOk.Focus()



        Catch ex As Exception
            MsgBox("Error : Plo_IniciarFrm")
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Plo_IniciarVar()
        Try
            wl_bYesNo = False
            wl_bEdit = False
            wl_sCodErrAdi = ""
            wl_sCodErrCon = ""
            wl_sCodErrOk = "20-001"


            wl_bYesNo = False
            wl_bEdit = False
            wl_sNomFrm = "frmAPDGV"

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


        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVarDGV")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
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

#End Region
End Class