Public Class frmCR002
#Region "000 Inicia. wp - vp Definición del variables públicas"
#End Region
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' wl - Variables de trabajo locales
    ' vl - Variables que corresponde a campos de la BD locales
    ' wp - Variables de trabajo locales parámetro
    ' vl - Variables que corresponde a campos de la BD locales - parámeto
#End Region
#Region "011 frm - Variables Locales"
    ' Booleanas
   
    ' Cadenas
    Dim wl_sTblCon1 As String
    Dim wl_sTblCon2 As String
    Dim wl_sNomTblE1 As String
    Dim wl_sTxtFrm As String
    Dim vl_sNomTblE1 As String
    Dim vl_sNomTblL1 As String
    Dim vl_sCodDocI As String
    Dim vl_sCodSerI As String
    Dim vl_sCodSerF As String
    Dim vl_sEstDocI As String
    Dim vl_sCodTerI As String
    Dim vl_sCodTerF As String
    Dim vl_sCodVenI As String
    Dim vl_sCodItmI As String
    Dim vl_sCodItmF As String
    Dim vl_sCodDoc As String
    Dim vl_sTipMov As String
    Dim vl_sClsDoc As String



    'Numéricas
    Dim vl_nNroDocI As Long
    Dim vl_nNroDocF As Long

    'Fechas
    Dim vl_dFecDocI As Date
    Dim vl_dFecDocF As Date


#End Region
#Region "012 BD - Variables campos BD Locales"

    
#End Region
#Region "013 DGV - Variables Locales"
    'booleanas
    'cadena
    ' Dim wl_sOpeLgc As String  'Y, O, N
    'Columnas
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

#End Region
#Region "014 Objetos locales"
    Dim clnIEDMI As New ClaseNegocios.clnIEDMI
    Dim clnIEINV As New ClaseNegocios.clnIEINV
    Dim wl_CtrlDgv As DataGridView
    Dim clnActTab As New ClaseNegocios.clnActTbl


#End Region
#Region "015 Estructuras"
    Dim vl_aeAPDGV() As moe_Estructuras.eAPDGV
    Dim wl_aeAPQDG() As moe_Estructuras.eAPQDG
    Dim vl_eAPDGV As New moe_Estructuras.eAPDGV
    Dim wl_eAPEND As New moe_Estructuras.eAPEND
    Dim wl_eAPLND1 As New moe_Estructuras.eAPLND1
    Dim wl_eGEMOV As moe_Estructuras.eGEMOV
    Dim wl_eGLMOV1 As moe_Estructuras.eGLMOV1
    Dim wl_aeGLMOV1() As moe_Estructuras.eGLMOV1
    Dim wl_eTEDMT As moe_Estructuras.eTEDMT
    Dim vl_eTLDMT1 As moe_Estructuras.eTLDMT1
    Dim wl_eTLDMT4 As moe_Estructuras.eTLDMT4
    Dim wl_eATVEN As moe_Estructuras.eATVEN
    Dim wl_eATALM As moe_Estructuras.eATALM
    Dim wl_eATIVA As moe_Estructuras.eATIVA
    Dim vl_eABESD As moe_Estructuras.eABESD
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
    Private Sub frmCR002_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grl_RemoveHandler()
        grl_AddHandler()
        mof_fCnfCtrl(Me)
        mof_IniciarVar()
        Plo_IniciarEst() '080
        Plo_IniciarVar() '080
        grl_EventCtrl(Me)
        Cbo_CargarLista()
        Plo_ActivarOk() '080
        Plo_TxtIni() '080
    End Sub
#End Region
#Region "030 Cbo Llenar Combobox. Funciones"
    Private Sub Cbo_CargarLista()
        Try
        Catch ex As Exception
            MsgBox("Error :  Cbo_CargarLista")
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
#Region "040 BD Procedimientos sobre la BD. Personalizados"
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        'Fec Ult Act.: 2014.04.22
        Try


        Catch ex As Exception
            MsgBox("Error :  BD_DatPrmTipTbl")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BD_DatPrmTSB()




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
            txtsCodTerI.Text = wg_sSelCon11
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_Lst_TEDMT")
        End Try
    End Sub
    Private Sub BD_eTEDMT_DT(ByVal wp_DTE1 As DataTable)
        Dim wl_nRow As Integer
        wl_nRow = wp_DTE1.Rows.Count - 1
        wg_eTEDMT = New moe_Estructuras.eTEDMT
        moo_eTEDMT_DT(wg_eTEDMT,
                      wp_DTE1,
                      wl_nRow)
    End Sub
#End Region
#Region "041 BD Procedimientos sobre la BD. Comunes"

    Private Sub BD_tsbPASU()
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_tsbPASU")
        End Try
    End Sub
#End Region
#Region "042 BD Busquedas"

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
    Private Function BD_BuscarATALM() As Boolean
        Try
            wr_bEOFE2 = True
            wl_eATALM = New moe_Estructuras.eATALM
            wr_bEOFE2 = mof_fConATALM(wl_eATALM.sCodAlm,
                                      wl_eATALM)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarATVEN")
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
    Private Sub BD_ConGELMOV()
        Dim wl_frmGQGEMOV As New frmGQGEMOV
        Dim wl_sFrmDtn As New frmGQGEMOV
        wl_sFrmDtn.wp_sNomTblE = "CEODC"
        wl_sFrmDtn.wp_sNomTblL = "CLODC1"
        wg_sTblCon1 = "CEODC"
        wl_sFrmDtn.wp_sFrmOri = Me.Name
        wl_sFrmDtn.wp_sTxtFrm = wl_sTxtFrm
        wl_sFrmDtn.Text = "Consulta órdenes de compras"
        wl_sFrmDtn.wp_sCodDocI = vl_sCodDoc
        wl_sFrmDtn.wp_sCodSerI = vl_sCodSerI
        wl_sFrmDtn.wp_sCodSerF = vl_sCodSerF
        wl_sFrmDtn.wp_nNroDocI = vl_nNroDocI
        wl_sFrmDtn.wp_nNroDocF = vl_nNroDocF
        wl_sFrmDtn.wp_sEstDocI = vl_sEstDocI
        wl_sFrmDtn.wp_dFecDocI = vl_dFecDocI
        wl_sFrmDtn.wp_dFecDocF = vl_dFecDocF
        wl_sFrmDtn.wp_sCodTerI = vl_sCodTerI
        wl_sFrmDtn.wp_sCodTerF = vl_sCodTerF
        wl_sFrmDtn.wp_sCodVenI = vl_sCodVenI
        wl_sFrmDtn.wp_sCodItmI = vl_sCodItmI
        wl_sFrmDtn.wp_sCodItmF = vl_sCodItmF
        wl_sFrmDtn.Show()

    End Sub
#End Region

#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    ' Command Buttoms
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        grl_Cerrar()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        Plo_VdaVar()
        BD_ConGELMOV()

        ' grl_Cerrar()
    End Sub
#End Region
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub Plo_HabCtrl()
        Try

        Catch ex As Exception
            MsgBox("Error : Plo_HabCtrl")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_IniciarEst()
        wl_eGEMOV = New moe_Estructuras.eGEMOV
        wl_eGLMOV1 = New moe_Estructuras.eGLMOV1
        ReDim wl_aeGLMOV1(0)
    End Sub
    Private Sub Plo_IniciarVar()
        ' datos por del formulario
        Try
            vl_sCodDocI = ""
            vl_sCodSerI = ""
            vl_sCodSerF = ""
            vl_sCodTerI = ""
            vl_sCodTerF = ""
            vl_sCodVenI = ""
            vl_sCodItmI = ""
            vl_sCodItmF = ""
            vl_sEstDocI = ""
            vl_nNroDocI = 0
            vl_nNroDocF = 0

            vl_sCodDoc = "ODC"
            vl_sTipMov = " "
            vl_sClsDoc = "DC"

            mtbFecDocI.Text = Today
            mtbFecDocF.Text = Today

            wl_sTblCon1 = "CEODC"
            wl_sTblCon2 = "CLODC1"
            wl_sTxtFrm = "Consulta órdenes de compras"

            wg_sCodErrAdi = "10-203"
            wg_sCodErrCon = "10-103"
            wg_sCodErrOk = "20-001"
            wl_sCoderr = "10-112"
            wg_sDesMsgEli = "Este opción elimina el documento. ¿ Continua ?"
            wg_sTitMsgEli = "Mensaje del sistema"
            wg_sDesMsgAdi = "Este documento no puede modificarse después de crearse. ¿ Continua ?"
            wg_sTitMsgAdi = "Orden de compra"


        Catch ex As Exception
            MsgBox("Error : Plo_IniciarVar")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_TxtIni()
        txtsCodSerI.Focus()
    End Sub
    Private Sub Plo_frmLstdet()
        Dim wl_frmLstDet As New frmGQLstDet
        Dim wg_DTL1 As New DataTable
        wg_sTblCon1 = "CEODC"
        wg_sCmpCon11 = "sCodDoc"
        wg_sCmpCon12 = "nNroDoc"
        wg_sTitCon11 = "Código OP"
        wg_sTitCon12 = "Número OP"
        wr_bEOFCon1 = True
        wl_frmLstDet.ShowDialog()
    End Sub
    Private Sub Plo_VdaVar()
        Try
            Dim vl_bVdaE1 As Boolean

            If String.IsNullOrEmpty(txtnNroDoCI.Text) Then
                vl_nNroDocI = 0
            Else
                mov_VdaDatEsNro(vl_bVdaE1,
                                txtnNroDoCI.Text)
                If vl_bVdaE1 Then
                    vl_nNroDocI = CLng(txtnNroDoCI.Text)
                Else
                    vl_nNroDocI = 0
                End If
            End If
            If String.IsNullOrEmpty(txtnNroDocF.Text) Then
                vl_nNroDocF = 0
            Else
                mov_VdaDatEsNro(vl_bVdaE1,
                                txtnNroDocF.Text)
                If vl_bVdaE1 Then
                    vl_nNroDocF = CLng(txtnNroDocF.Text)
                Else
                    vl_nNroDocF = 0
                End If
            End If
            vl_sCodSerI = txtsCodSerI.Text
            vl_sCodVenI = txtsCodVenI.Text
            vl_dFecDocI = mtbFecDocI.Text
            vl_dFecDocF = mtbFecDocF.Text
            vl_sCodTerI = txtsCodTerI.Text
            vl_sCodTerF = txtsCodTerF.Text
            vl_sCodItmI = txtsCodItmI.Text
            vl_sCodItmF = txtsCodItmF.Text



        Catch ex As Exception
            MsgBox("Error : Plo_VdaVar")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "081 Plo Procedimientos del Formulario. Comunes"
    Private Sub Plo_ActivarOk()
        Try
            mof_ActivarOK(Me)
            mof_HabCtrl(Me)
            Plo_IniciarEst() '080
            Plo_IniciarVar() '080
            txtsCodSerI.Focus()

        Catch ex As Exception
            MsgBox("Error : Plo_ActivarOk")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Plo_ActivarBuscar()
        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Plo_ActivarCrear()
        Try

        Catch ex As Exception

        End Try
    End Sub


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
    End Sub
#End Region
#Region "140 grl Lost Focus. Personalizados"
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim wl_cvTxt As Control = ActiveControl
        ' mof_LmpMsgError()
        wl_cvTxt = GetNextControl(wl_cvTxt, False)
        If cmdCancelar.Focused = False Then

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
        '   If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
        'Mof_ActivarActualizar(Me)
        'nd If
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
            '  Rpt_PrmRpt()
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
        'dgv_AdiRow()
    End Sub
    Private Sub tsmi_EliminarLinea()
        'If cmdCrear.Visible = False Then
        ' mof_ActivarActualizar(Me)
        ' End If

        ' dgv_EliminarLinea()
    End Sub
#End Region


   
End Class