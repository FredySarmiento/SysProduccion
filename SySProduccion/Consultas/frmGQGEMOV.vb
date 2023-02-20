Public Class frmGQGEMOV
#Region "000 Inicia. wp - vp Definición del variables públicas"
    ' Booleanas

    ' Cadenas
    Public Property wp_sFrmOri As String
    Public Property wp_sTxtFrm As String
    Public Property wp_sNomTblE As String
    Public Property wp_sNomTblL As String
    Public Property wp_sCodDocI As String
    Public Property wp_sCodSerI As String
    Public Property wp_sCodSerF As String
    Public Property wp_sCodTerI As String
    Public Property wp_sCodTerF As String
    Public Property wp_sCodVenI As String
    Public Property wp_sCodItmI As String
    Public Property wp_sCodItmF As String
    Public Property wp_sEstDocI As String
    Public Property wp_sCodDocBas As String
    Public Property wp_nNroDocBas As Long

    Public Property wp_sTblCon1 As String
    Public Property wp_sTblCon2 As String

    Public Property wp_sCodRpt As String


    'Numéricas
    Public Property wp_nNroDocI As Long
    Public Property wp_nNroDocF As Long

    'Fechas
    Public Property wp_dFecDocI As Date
    Public Property wp_dFecDocF As Date
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
    Dim vl_sIndCon As String
    Dim vl_nTotCol As Integer
    Dim vl_sSelCon11 As String
    Dim vl_sSelCon12 As String
    Dim vl_nSelCon13 As Long
    Dim vl_nSelCon14 As Double
    Dim vl_sCodRpt As String





#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'ColumnasDim wl_RowAlto As Integer
    Dim wl_nCntCol As Integer
    Dim wl_nCol As Integer
    Dim wl_nColAnt As Integer
    Dim wl_nColIni As Integer
    Dim wl_nColNom As Integer
    Dim wl_nColIniGrl As Integer
    Dim wl_nColFin As Integer
    Dim wl_nColFinGrl As Integer
    Dim wl_nColKD As Integer
    Dim wl_nColKP As Integer
    Dim wl_nColKU As Integer
    Dim wl_nColSig As Integer
    Dim wl_nNroCol As Integer
    Dim wl_nTotCol As Integer
    Dim wl_nColCVC As Integer
    Dim wl_nNroDgv As Integer
    Dim vl_nTamCmp As Integer
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
    Dim wl_nRowAct As Integer
    Dim wl_nRowCVC As Integer

    Dim wl_X As Integer ' dgv1.CurrentCellAddress.X Col
    Dim wl_Y As Integer ' dgv1.CurrentCellAddress.Y Fila
     Dim wl_nColOrd As Integer
    
#End Region

#Region "014 Objetos locales"
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnCEODC As New ClaseNegocios.clnIEINV
    Dim clnCLODC1 As New ClaseNegocios.clnIEINV
    Dim wl_CtrlDgv As DataGridView
    Dim clnActTab As New ClaseNegocios.clnActTbl


#End Region
#Region "015 Estructuras"
    Dim vl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim vl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eGEMOV As New moe_Estructuras.eGEMOV
    Dim vl_eCEODC As moe_Estructuras.eGEMOV
    Dim vl_eCLODC1 As moe_Estructuras.eGLMOV1
    Dim vl_aeGLODC1() As moe_Estructuras.eGLMOV1

    
#End Region
#Region "018 Errores"
    Dim wl_sNomtbl As String
    Dim wl_sDatCmp As String
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
    Private Sub frmGQGEMOV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text += "  -  " + vg_sNomCia
        If wp_sTblCon1 <> "" Then
            Me.Text = wp_sTxtFrm
        End If
        Me.BackColor = wg_ClrFrm
        Plo_inicializarVar()

        wg_sCodStr = ""
        Select Case wg_sTblCon1
            Case "CEODC"
                vl_sIndCon = "1"
                wl_nTotCol = 3
                wg_sCodStr = "ECEODC"

        End Select
        ' Plo_IniciarVarDGV()
        vl_sCodRpt = "CR002"
        'dgv_APRDG(vl_sCodRpt)
        dgv_APQDG(wg_sCodStr)
        Plo_IniciarVarDGV()
        Select Case vl_sIndCon
            Case "1"
                dgv_ConCEODC()
        End Select
    End Sub
#End Region

#Region "070 DGV Procedimientos del Usuario. Personalizados"

    Private Sub dgv_ConCEODC()
        Dim clnCELODC As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnCELODC.cndtConGELMOV1(wp_sNomTblE,
                                                 wp_sNomTblL,
                                                 wp_sCodDocI,
                                                 wp_sCodSerI,
                                                 wp_sCodSerF,
                                                 wp_nNroDocI,
                                                 wp_nNroDocF,
                                                 wp_sEstDocI,
                                                 wp_dFecDocI,
                                                 wp_dFecDocF,
                                                 wp_sCodVenI,
                                                 wp_sCodTerI,
                                                 wp_sCodTerF,
                                                 wp_sCodItmI,
                                                 wp_sCodItmF,
                                                 wp_sCodDocBas,
                                                 wp_nNroDocBas,
                                                 wr_bEOFCon1)
            ReDim wg_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_DGV_DTaeGELMOV(Me.dgv1,
                                   wg_DTCon1)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConCEODC")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dgv_ConCEFAP()
        Dim clnCEFAP As New ClaseNegocios.clnIEINV
        Try
            wr_bEOFCon1 = False
            wg_DTCon1 = clnCEFAP.cndtConGEMOV(wg_sTblCon1,
                                              wl_eGEMOV,
                                              wr_bEOFCon1)
            ReDim wg_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wg_aeGEMOV,
                               wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                               wg_aeGEMOV)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConCEFAP")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgv_ConGEMOV()
        Dim clnGEMOV As New ClaseNegocios.clnIEINV
        Dim wl_sTabAnt1 As String
        Try
            wr_bEOFCon1 = False

            wl_sTabAnt1 = wg_sTblCon1
            wg_sTblCon1 = "IEMOV"
            wg_DTCon1 = clnGEMOV.cndtConGEMOV(wg_sTblCon1,
                                               wl_eGEMOV,
                                              wr_bEOFCon1)
            ReDim wg_aeGEMOV(0)
            If Not wr_bEOFCon1 Then
                moo_aeGEMOV_DT(wg_aeGEMOV,
                               wg_DTCon1)
                moo_DGV_aeGEMOV(Me.dgv1,
                               wg_aeGEMOV)
            End If
            wg_sTblCon1 = wl_sTabAnt1
        Catch ex As Exception
            MsgBox("Error : dgv_ConGEMOV")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Con1Lla2Tbl()
        wg_DTCon1 = clnConTbl.cndtCon2Lla2Tbl(wg_sTblCon1,
                                              wg_sCmpCon11,
                                              wg_sDatCon11,
                                              wg_sTitCon11,
                                              wg_sCmpCon12,
                                              wg_sDatCon12,
                                              wg_sTitCon12,
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
    Private Sub dgv_Con2Lla2Tbl()
        wg_DTCon1 = clnConTbl.cndtCon2Lla2Tbl(wg_sTblCon1,
                                              wg_sCmpCon11,
                                              wg_sDatCon11,
                                              wg_sTitCon11,
                                              wg_sCmpCon12,
                                              wg_sDatCon12,
                                              wg_sTitCon12,
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
    Private Sub dgv_Configurar1()
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
    Private Sub dgv1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If dgv1.CurrentRow.Cells(0).Selected Or
          dgv1.CurrentRow.Cells(1).Selected Or
          dgv1.CurrentRow.HeaderCell.Selected Then
            Plo_DevSel()
            Me.Close()
        End If

    End Sub
    'Comunes
    Private Sub dgv_APRDG(ByVal vl_sCodRpt As String)
        Dim wl_eAPRDG As New moe_Estructuras.eAPRDG
        wg_eAPRDG = New moe_Estructuras.eAPRDG
        ' wg_sCodStr = "EIELDMI1"

        Try
            wg_aeAPRDG = mof_fConAPRDG(vl_sCodRpt)
            wl_nTotCol = UBound(wg_aeAPRDG) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APRDG")
            MsgBox(ex.Message)

        End Try
    End Sub
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
                wg_eAPQDG = wg_aeAPQDG(wp_nC)

                With wg_eAPQDG
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
            wl_nColOrd = wl_nColIniGrl
        Catch ex As Exception
            MsgBox("Error en: dgv_ConfiguraCol")
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        grl_Cerrar()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        grl_Cerrar()
    End Sub
#End Region

#Region "80 - 2 Plo Procedimientos Locales"
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
                Case "CEODC"
                    ReDim wg_aeCEODC(wl_nCntReg)

            End Select
            wl_nCntReg = 0
            For wl_nRow = 0 To dgv1.Rows.Count - 1
                If dgv1.Rows(wl_nRow).Cells(0).Selected Then
                    Select Case wg_sTblCon1
                        Case "CEODC"
                            vl_eCEODC = New moe_Estructuras.eGEMOV
                            wg_aeCEODC(wl_nCntReg) = New moe_Estructuras.eGEMOV
                            moo_eGEMOV_DGV(vl_eCEODC,
                                           Me.dgv1,
                                           wl_nRow)
                            wg_aeCEODC(wl_nCntReg) = vl_eCEODC
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
        vl_sSelCon11 = ""
        vl_sSelCon12 = ""
        vl_nSelCon13 = 0
        vl_nSelCon14 = 0
        wg_sCmpCon11 = ""
        wg_sCmpCon12 = ""
        wg_sTitCon11 = ""
        wg_sTitCon12 = ""
        vl_sIndCon = "1"
        '  wg_sTblCon1 = ""
        wg_sCmpCon11 = ""
        'wg_sDatCon11 = ""
        wg_sTitCon11 = ""
        wg_sCmpCon12 = ""
        wg_sDatCon12 = ""
        wg_sTitCon12 = ""
        wg_sTblCon2 = ""
        wg_sSelCon11 = ""
        wr_bEOFCon1 = False
    End Sub
    Private Sub Plo_IniciarVarDGV()
        'dgv


        wl_nRowVacia = 7


        wl_nColFin = 11
        'wl_nColIniGrl = 5
        wl_nColAnt = wl_nColIniGrl
        wl_nRowAnt = 0





        mof_ConfigurarDGV(Me.dgv1,
                          wl_nTotCol)

        dgv_ConfiguraCol()
        dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv1.MultiSelect = True
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

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
#End Region
End Class