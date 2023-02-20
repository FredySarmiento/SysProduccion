Public Class frmGQLstDet

#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-10-23

#Region "001 Inicia. wg - vg Definición del variables públicas"

    'Estructuras
    Public Property wp_ePEODP As New moe_Estructuras.ePEODP
    Public Property wp_ePLODP1 As New moe_Estructuras.ePLODP1
    Public Property wp_aePLODP1() As moe_Estructuras.ePLODP1

    'variables

    Public Property wp_sCodDoc As String
    Public Property wp_nNroDoc As String
    Public Property wp_sCodSer As String
    Public Property wp_sTblCon As String
    Public Property wp_sNomFrm As String

#End Region
#Region "011 frm - Variables Locales"


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
    Dim vl_nTamCmp As Integer
    Dim wl_sCodStr As String
    Dim wl_nColOrd As Integer

    ' Variables Campos de la BD


    Dim clnConTbl As New ClaseNegocios.clnConTbl
    ' Objetos del formulario

    ' Variables Campos de la BD

    Dim vl_sCodDoc As String
    Dim vl_nNroDoc As Integer
    Dim vl_sCodSer As String

    Dim wl_sSelCon11 As String
    Dim wl_sSelCon12 As String
    Dim wl_nSelCon13 As Long
    Dim wl_nSelCon14 As Double
    Dim wl_sIndCon As String
    Dim wl_nTotcol As Long

    Dim wl_DTL1 As New DataTable

    ' Objetos del formulario

    Dim wl_ePLODP1 As New moe_Estructuras.ePLODP1

#End Region
#Region "014 Objetos locales"

#End Region
#Region "015 Estructuras"
    Dim wl_aePEODP() As moe_Estructuras.ePEODP
    Dim wl_aePLODP1() As moe_Estructuras.ePLODP1

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
    Private Sub frmLstDet_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            If dgv1.Rows.Count > 0 Then
                If wp_sTblCon = "PLODP1" Then
                    If wl_aePLODP1.Length <> 0 Then
                        If wl_aePLODP1(0).sCodDoc <> "" Then
                            ReDim wg_aePLODP1(0)
                            wg_aePLODP1 = wl_aePLODP1
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : frmLstDet_FormClosed")
            MsgBox(ex.Message)
        End Try
     


    End Sub
    Private Sub frmLstDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            If wp_sNomFrm <> "" Then
                Me.Text = wp_sNomFrm
            End If

            Me.BackColor = wg_ClrFrm
            Plo_inicializarVar()
            wl_sCodStr = ""
            Select Case wp_sTblCon
                Case "PLODP1"
                    wl_nTotcol = 10
                    wl_sIndCon = "1"
                    wl_sCodStr = "EPLODP1"
            End Select
            dgv_APQDG(wl_sCodStr)
            Plo_IniciarVarDGV()
            Select Case wl_sIndCon
                Case "1"
                    dgv_ConPLODP1()
            End Select
        Catch ex As Exception
            MsgBox("Error : frmLstDet_Load")
            MsgBox(ex.Message)
        End Try
      

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
                If dgv1.Rows(wl_nRow).Cells(0).Selected = True Then
                    wl_nCntReg = wl_nCntReg + 1
                End If
            Next
            Select Case wp_sTblCon
                Case "PLODP1"
                    ReDim wl_aePLODP1(wl_nCntReg - 1)
            End Select
            wl_nCntReg = 0
            For wl_nRow = 0 To dgv1.Rows.Count - 1
                If dgv1.Rows(wl_nRow).Cells(0).Selected = True Then
                    Select Case wp_sTblCon
                        Case "PLODP1"
                            wl_ePLODP1 = New moe_Estructuras.ePLODP1
                            wl_aePLODP1(wl_nCntReg) = New moe_Estructuras.ePLODP1
                            moo_ePLODP1_DGV(wl_ePLODP1,
                                            Me.dgv1,
                                            wl_nRow)
                            wl_aePLODP1(wl_nCntReg) = wl_ePLODP1
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
        Try
            dgv1.Rows.Clear()
            Select Case wp_sTblCon
                Case "PLODP1"
                    wp_ePEODP = New moe_Estructuras.ePEODP
                    ReDim wl_aePEODP(0)
                    wl_aePEODP(0) = New moe_Estructuras.ePEODP
            End Select
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdSeleccionar_Click")
            MsgBox(ex.Message)
        End Try

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
    Private Sub dgv_APQDG(ByVal wp_sCodStr As String)
        Dim wl_eAPQDG As New moe_Estructuras.eAPQDG
        wg_eAPQDG = New moe_Estructuras.eAPQDG

        Try
            wg_aeAPQDG = mof_fConAPQDG(wp_sCodStr)
            wl_nTotcol = UBound(wg_aeAPQDG) + 1
        Catch ex As Exception
            MsgBox("Error en: dgv_APQDG")
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub dgv_ConPLODP1()
        Dim clnPEODP As New ClaseNegocios.clnPEODP
        Try
            vl_sCodDoc = wp_sCodDoc
            vl_nNroDoc = wp_nNroDoc
            vl_sCodSer = wp_sCodSer
            wr_bEOFCon1 = False
            wg_DTCon1 = clnPEODP.cndtConsultarPLODP1(vl_sCodDoc,
                                                     vl_nNroDoc,
                                                     wr_bEOFCon1)

            ReDim wl_aePLODP1(0)
            If Not wr_bEOFCon1 Then
                moo_aePLODP1_DT(wl_aePLODP1,
                                wg_DTCon1)
                moo_DGV_aePLODP1(Me.dgv1,
                                 wl_aePLODP1)
            End If
        Catch ex As Exception
            MsgBox("Error : dgv_ConPLODP1")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgv_Con1Lla2Tbl()
        wg_DTCon1 = clnConTbl.cndtCon1Lla2Tbl(wp_sTblCon,
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
        Try

       
        Dim wl_bCnfVis As Boolean = False
        Dim vl_sNomCmp As String
        Dim vl_sTitCol As String
        wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
        For wp_nC = 0 To wl_nTotcol - 1
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

        End Try
        '    Dim wl_nC As Integer
        '    Dim vl_sNomCmp As String
        '    Dim vl_sTitCol As String
        '    Dim wl_bCnfVis As Boolean = False
        '    wp_sTipCol = "N" 'N = numérico. C = pesos. S = string. d = fecha
        '    For wp_nC = 0 To wl_nTotcol - 1
        ' wp_bVisible = True
        ' wp_bReadOnly = False
        ' wp_bColxDef = False
        ' wp_sTipCol = "S"
        ' wg_eAPQDG = wg_aeAPQDG(wp_nC)
        '
        '        With wg_eAPQDG
        ' wp_sTipCol = .sTipCol
        ' wp_bVisible = .bVisible
        ' wp_bReadOnly = .bReadOnly
        ' wp_bColxDef = .bColxDef
        ' vl_sNomCmp = .sNomCmp
        ' vl_sTitCol = .sTitCol
        ' End With
        '
        '        mof_DGVFormatCol(Me.dgv1,
        '                     wp_nC,
        '                     wp_sTipCol,
        '                     wp_bVisible,
        '                     wp_bReadOnly,
        '                     vl_sNomCmp,
        '                     vl_nTamCmp,
        '                     vl_sTitCol)
        '        If wl_bCnfVis = False Then
        ' If wp_bVisible Then
        ' wl_nColIniGrl = wp_nC
        ' wl_nColFinGrl = wp_nC
        ' wl_bCnfVis = True
        ' End If
        ' End If
        ' If wl_bCnfVis = True Then
        ' If wp_bVisible Then
        ' wl_nColFinGrl = wp_nC
        ' End If
        ' End If
        ' Next

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

#End Region
    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            For wl_nF = 0 To dgv1.Rows.Count - 2
                If dgv1.Rows(wl_nF).Cells(wl_nColOrd).Value.ToString.Contains(TextBox1.Text) Then
                    dgv1.CurrentCell = dgv1.Rows(wl_nF).Cells(wl_nColOrd)
                    Exit Sub
                End If
            Next wl_nF
        Catch ex As Exception
            MsgBox("Error en: TextBox1_TextChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class