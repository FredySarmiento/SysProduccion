Public Class frmGQLstDet
#Region "01 Definición del variables Locales"

    ' DGV - Variables locales
    Dim wl_RowAlto As Integer
    Dim wl_nTab As Integer
    Dim wl_nRowVacia As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColIni As Integer
    Dim wl_nRowAnt As Integer
    Dim wl_nColVda1 As Integer
    Dim wl_nColVda2 As Integer
    Dim wl_sOpeLgc As String
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nCntReg As Integer


    ' Variables Campos de la BD


    Dim clnConTbl As New ClaseNegocios.clnConTbl
    ' Objetos del formulario

    ' Variables Campos de la BD

    Dim vp_sCodDoc As String
    Dim vp_nNroDoc As Integer
    Dim wl_sSelCon11 As String
    Dim wl_sSelCon12 As String
    Dim wl_nSelCon13 As Long
    Dim wl_nSelCon14 As Double
    Dim wl_sIndCon As String
    Dim wl_nTotcol As Long


    Dim wl_DTL1 As New DataTable


    ' Objetos del formulario


#End Region
#Region "03 Programa principal"
    Private Sub frmLstDet_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        wg_sSelCon11 = wl_sSelCon11
        wg_sSelCon12 = wl_sSelCon12
        wg_nSelCon13 = wl_nSelCon13
        wg_nSelCon14 = wl_nSelCon14

    End Sub
    Private Sub frmLstDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = wg_ClrFrm
        Plo_inicializarVar()
        wg_sCodStr = ""
        Select Case wg_sTblCon1
            Case "PLODP1"
                wl_nTotcol = 10
                wl_sIndCon = "1"
                wg_sCodStr = "EPLODP1"
        End Select
        dgv_APQDG(wg_sCodStr)
        Plo_IniciarVarDGV()
        Select Case wl_sIndCon
            Case "1"
                dgv_ConPLODP1()
        End Select





    End Sub
#End Region
#Region "06 - 2 Plo Procedimientos Locales"
    Private Sub Plo_DevSel()
        Try
            Dim wl_nCntReg As Integer
            Dim wl_nRow As Integer

            wl_nRow = 0
            wl_nCntReg = 0
            For wl_nRow = 0 To dgv1.Rows.Count - 1
                If dgv1.Rows(wl_nRow).Cells(0).Selected Then
                    wl_nCntReg = wl_nCntReg + 1
                End If
            Next
            Select Case wg_sTblCon1
                Case "PLODP1"
                    ReDim wg_aePLODP1(wl_nCntReg)
            End Select
            wl_nCntReg = 0
            For wl_nRow = 0 To dgv1.Rows.Count - 1
                If dgv1.Rows(wl_nRow).Cells(0).Selected Then
                    Select Case wg_sTblCon1
                        Case "PLODP1"
                            wl_ePLODP1 = New moe_Estructuras.ePLODP1
                            wg_aePLODP1(wl_nCntReg) = New moe_Estructuras.ePLODP1
                            moo_ePLODP1_DGV(wl_ePLODP1,
                                            Me.dgv1,
                                            wl_nRow)
                            wg_aePLODP1(wl_nCntReg) = wl_ePLODP1
                            wl_nCntReg = wl_nCntReg + 1

                    End Select
                End If

            Next


        Catch ex As Exception
            MsgBox("Error : Plo_DevSel")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_inicializarVar()
        wl_sSelCon11 = wg_sSelCon11
        wl_sSelCon12 = wg_sSelCon12
        wl_nSelCon13 = wg_nSelCon13
        wl_nSelCon14 = wg_nSelCon14
    End Sub
    Private Sub Plo_IniciarVarDGV()
        'dgv

        wl_nTab = 0
        wl_nRowVacia = 7


        wl_nColFin = 11
        'wl_nColIniGrl = 5
        wl_nColAnt = wl_nColIniGrl
        wl_nRowAnt = 0


        wl_nColVda1 = 4
        wl_nColVda2 = 5

        wl_sOpeLgc = "Y"


        mof_ConfigurarDGV(Me.dgv1,
                          wl_nTotcol)

        dgv_ConfiguraCol()
        dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv1.MultiSelect = True
    End Sub

#End Region
#Region "07 Procedimientos Controladores de Eventos (Remitente_evento)"
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        Try
            Plo_DevSel()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error : cmdSeleccionar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
#Region "20  Eventos del datagridview"
    Private Sub dgv_APQDG(ByVal wg_sCodStr As String)
        Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
        wg_eAPQDG = New moe_Estructuras.eAPQDG
        ' wg_sCodStr = "EIELDMI1"

        Try
            wg_aeAPQDG = mof_fConAPQDG(wg_sCodStr)
            wl_nTotcol = UBound(wg_aeAPQDG) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APQDG")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_ConPLODP1()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            vp_sCodDoc = wg_sSelCon11
            vp_nNroDoc = wg_nSelCon13
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConsultarPLODP1(vp_sCodDoc,
                                                     vp_nNroDoc,
                                                     wr_bEOF)


            ReDim wg_aePLODP1(0)
            If Not wr_bEOFCon1 Then
                moo_aePLODP1_DT(wg_aePLODP1,
                               wg_DTCon1)
                moo_DGV_aePLODP1(Me.dgv1,
                                wg_aePLODP1)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConPLODP1")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgv_Con1Lla2Tbl()
        wg_DTCon1 = clnConTbl.cndtCon1Lla2Tbl(wg_sTblCon1,
                                              wg_sCmpCon11,
                                              wg_sDatCon11,
                                              wg_sTitCon11,
                                              wg_sTblCon2,
                                              wg_sSelCon11,
                                              wr_bEOFCon1)
        If Not wr_bEOFCon1 Then
            With dgv1
                .DataSource = wg_DTCon1
                .Columns(0).HeaderText = wg_sTitCon11
                .Columns(1).HeaderText = wg_sTitCon12
            End With
            '   TextBox1.AutoCompleteCustomSource


        End If
    End Sub

    Private Sub dgv_Configurar()
        With dgv1

            ' Apariencia
            .ColumnHeadersHeight = 18
            .RowTemplate.Height = 18
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ' comportamiento
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' diseño
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill


            ' Varios columnas



        End With
    End Sub
    Private Sub dgv1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentDoubleClick
        If dgv1.CurrentRow.Cells(0).Selected Or
          dgv1.CurrentRow.Cells(1).Selected Or
          dgv1.CurrentRow.HeaderCell.Selected Then
            Plo_DevSel()
            Me.Close()
        End If

    End Sub
    Private Sub dgv_ConfiguraCol()

        Dim wl_nC As Integer
        Dim wl_bCnfVis As Boolean = False
        wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
        For wp_nC = 0 To wl_nTotcol - 1
            wp_bVisible = True
            wp_bReadOnly = False
            wp_bColxDef = False
            wp_sTipCol = "S"
            wg_eAPQDG = wg_aeAPQDG(wp_nC)
            With dgv1
                wl_nC = wp_nC
                .Columns(wl_nC).HeaderText = wg_eAPQDG.sTitCol
            End With
            With wg_eAPQDG
                wp_sTipCol = .sTipCol
                wp_bVisible = .bVisible
                wp_bReadOnly = .bReadOnly
                wp_bColxDef = .bColxDef
            End With

            mof_DGVFormatCol(Me.dgv1,
                         wp_nC,
                         wp_sTipCol,
                         wp_bVisible,
                         wp_bReadOnly)
            If wl_bCnfVis = False Then
                If wp_bVisible Then
                    wl_nColIniGrl = wp_nC
                    wl_nColFinGrl = wp_nC
                    wl_bCnfVis = True
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

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class