Imports System.Data.OleDb
Imports System.Data
Public Class frmACDEM

#Region "01 Configuración del formulario"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        AddHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        AddHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        AddHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        AddHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        AddHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        AddHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        AddHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        AddHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        AddHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        AddHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
#End Region
#Region "02 2 Definición del variables locales"
    Dim vp_nId As Integer
    Dim vl_sCodCia As String
    Dim wl_bYesNo As Boolean
    Dim clnACDEM As New ClaseNegocios.clnACDEM

#End Region
#Region "03 Programa principal"

    Private Sub frmACDEM_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.Dispose()
    End Sub

    Private Sub frmACDEM_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Me.Text += "  -  " + vg_sNomCia
        grl_RemoveHandler()
    End Sub

    Private Sub frmACDEM_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmACDEM_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '  e.Cancel = True

    End Sub
    Private Sub frmACDEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grl_RemoveHandler()
        grl_AddHandler()
        Lmp_limpiarfrm()
        Cbo_CargarLst()
        Plo_ACDEM()
        TabControl1.Focus()
        TabPage1.Focus()
        TextBox1.Focus()
        Plo_ActivarOK()
    End Sub
    Private Sub frmACDEM_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub

#End Region

#Region "05 BD Procedimientos sobre la BD"
    Private Sub BD_DatPrm(ByRef wg_sTipTbl As String)
        If wg_sTipTbl = "E1" Then
            wg_sNomTblE1 = "ACDEM"
            wg_sNomCmpE11 = "sCodCia"
            wg_sTipCmpE11 = "C"
            wg_sTitCmpE11 = "Código Compañía "
            wg_sDatCmpE11 = vg_sCodcia
            wr_bEOFE1 = True
        End If

    End Sub
    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            Dim vp_sNomCia As String
            Dim vp_sDirCia As String
            Dim vp_sCiuCia As String
            Dim vp_sDepCia As String
            Dim vp_sPaiCia As String
            Dim vp_sRepLeg As String
            Dim vp_sEmlCia As String
            Dim vp_sTel1Cia As String
            Dim vp_sTel2Cia As String
            Dim vp_sFaxCia As String
            Dim vp_sNitCia As String
            Dim vp_sDigVer As String
            Dim vp_nAnoSdoIniInv As Integer
            Dim vp_bInvPte As Boolean
            Dim vp_sTipInv As String
            Dim vp_bCosXBod As Boolean
            Dim vp_bMovSinCos As Boolean
            Dim vp_nId As Integer

            vp_nId = 0
            vp_sNomCia = TextBox1.Text.Trim
            vp_sDirCia = TextBox2.Text.Trim
            vp_sCiuCia = txtsCiuCia.Text.Trim
            vp_sDepCia = txtsDepCia.Text.Trim
            vp_sPaiCia = txtsPaiCia.Text.Trim
            vp_sRepLeg = txtsRepLeg.Text.Trim
            vp_sEmlCia = txtsEmlCia.Text.Trim
            vp_sTel1Cia = txtsTel1Cia.Text.Trim
            vp_sTel2Cia = txtsTel2Cia.Text.Trim
            vp_sFaxCia = txtsFaxCia.Text.Trim
            vp_sNitCia = txtsNitCia.Text.Trim
            vp_sDigVer = txtsDigVer.Text.Trim
            vp_nAnoSdoIniInv = cboATASI.SelectedValue
            vp_bInvPte = chbbInvPte.Checked
            If String.IsNullOrEmpty(cbosTipInv.SelectedItem) Then
                vp_sTipInv = ""
            Else
                vp_sTipInv = cbosTipInv.SelectedItem
            End If
            vp_bCosXBod = chbbCosXBod.Checked
            vp_bMovSinCos = chbbMovSinCos.Checked
            If Not Validaciones(wp_bVda) Then
                TextBox1.Focus()
            Else

                wl_bYesNo = clnACDEM.cnCrearActualizar(vg_sCodcia,
                                vp_sNomCia,
                                vp_sDirCia,
                                vp_sCiuCia,
                                vp_sDepCia,
                                vp_sPaiCia,
                                vp_sRepLeg,
                                vp_sEmlCia,
                                vp_sTel1Cia,
                                vp_sTel2Cia,
                                vp_sFaxCia,
                                vp_sNitCia,
                                vp_sDigVer,
                                vp_nAnoSdoIniInv,
                                vp_bInvPte,
                                vp_sTipInv,
                                vp_bCosXBod,
                                vp_bMovSinCos,
                                vp_nId,
                                wr_bEOF,
                                wp_sCmdSel)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_Eliminar(ByVal wp_sNomTbl,
                             ByVal wp_sNomCmp,
                             ByVal wp_sDatCmp,
                             ByVal wp_sTipCmp,
                             ByRef wr_bEOF)

        wg_bVdaE1 = False
        wr_bEOFE1 = True
        wg_sNomCmpE11 = "sCodCia"
        wg_sDatCmpE11 = vg_sCodcia
        wp_nBoxMsg = 4
        wp_sDesMsg = "Este opción elimina la compañía. ¿ Continua ?"
        wp_sTitMsg = "Mensaje del sistema"

        wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                 wp_sDesMsg,
                                 wp_sTitMsg)
        Try
            If wp_nResMsg = 6 Then
                wp_sCmpOrd = ""
                wp_sTipOrd = ""

                wg_DTE1 = clnConTbl.cndtBuscar(wp_sNomTbl,
                                           wp_sNomCmp,
                                           wp_sDatCmp,
                                           wp_sTipCmp,
                                           wp_sCmpOrd,
                                           wp_sTipOrd,
                                           wr_bEOF)

                If Not wr_bEOFE1 Then
                    clnActTbl.cnEliReg(wp_sNomTbl,
                                           wp_sNomCmp,
                                           wp_sDatCmp,
                                           wp_sTipCmp,
                                           wr_bEOF)
                    wg_bVdaE1 = True
                End If
                tsb_Crear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error: BD_Eliminar")
        End Try

    End Sub

    Private Sub BD_TblaVar()


        TextBox1.Text = wg_DTE1.Rows(0).Item("sNomCia")
        TextBox2.Text = wg_DTE1.Rows(0).Item("sDirCia")
        txtsCiuCia.Text = wg_DTE1.Rows(0).Item("sCiuCia")
        txtsDepCia.Text = wg_DTE1.Rows(0).Item("sDepCia")
        txtsPaiCia.Text = wg_DTE1.Rows(0).Item("sPaiCia")
        txtsRepLeg.Text = wg_DTE1.Rows(0).Item("sRepLeg")
        txtsEmlCia.Text = wg_DTE1.Rows(0).Item("sEmlCia")
        txtsTel1Cia.Text = wg_DTE1.Rows(0).Item("sTel1Cia")
        txtsTel2Cia.Text = wg_DTE1.Rows(0).Item("sTel2Cia")
        txtsNitCia.Text = wg_DTE1.Rows(0).Item("sNitCia")
        txtsDigVer.Text = wg_DTE1.Rows(0).Item("sDigVer")
        cboATASI.SelectedValue = wg_DTE1.Rows(0).Item("nAnoSdoIniInv")
        chbbInvPte.Checked = wg_DTE1.Rows(0).Item("bInvPte")
        cbosTipInv.Text = wg_DTE1.Rows(0).Item("sTipInv")
        chbbCosXBod.Checked = wg_DTE1.Rows(0).Item("bCosXBod")
        chbbMovSinCos.Checked = wg_DTE1.Rows(0).Item("bMovSinCos")
        Plo_ActivarOK()
    End Sub
#End Region
#Region "030 Cbo Llenar Combobox"
    Private Sub Cbo_CargarLst()
        Try
            Cbo_CargarATASI()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarLst")
        End Try
    End Sub
    Private Sub Cbo_CargarATASI()
        Try
            '4
            wg_DTLst1 = New DataTable
            wg_sTblLst1 = "ATASI"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1, wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                cboATASI.DataSource = wg_DTLst1
                cboATASI.DisplayMember = wg_DTLst1.Columns("nAnoSdoIni").Caption.ToString
                cboATASI.ValueMember = wg_DTLst1.Columns("nAnoSdoIni").Caption.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: Cbo_CargarATASI")
        End Try
    End Sub
#End Region
#Region "06 - 1 Lmp Limpiar Formulario"
    Private Sub Lmp_limpiarfrm()
        Dim wl_oCtr As Control
        For Each wl_oCtr In TabPage1.Controls
            If TypeOf (wl_oCtr) Is TextBox Then
                wl_oCtr.Text = ""
                wl_oCtr.BackColor = wg_ClrLost
            End If
        Next
        For Each wl_oCtr In TabPage2.Controls
            If TypeOf (wl_oCtr) Is TextBox Then
                wl_oCtr.Text = ""
                wl_oCtr.BackColor = wg_ClrLost
            End If
        Next
        For Each wl_oCtr In TabPage3.Controls
            If TypeOf (wl_oCtr) Is TextBox Then
                wl_oCtr.Text = ""
                wl_oCtr.BackColor = wg_ClrLost
            End If
        Next
        For Each wl_oCtr In TabPage3.Controls
            If TypeOf (wl_oCtr) Is ComboBox Then
                wl_oCtr.Text = ""
                wl_oCtr.BackColor = wg_ClrLost
            End If
        Next
    End Sub
#End Region
#Region "Procedimientos locales"
    Private Sub Plo_ACDEM()
        wg_sTipTbl = "E1"

        Dim clnConTbl1 As New ClaseNegocios.clnConTbl
        Dim clnActTbl1 As New ClaseNegocios.clnActTbl

        wp_sCmdSel = "B"
        wl_bYesNo = False
        BD_DatPrm(wg_sTipTbl)
        wg_sCmpOrdE11 = ""
        wg_sTipOrdE11 = ""
        wg_DTE1 = clnConTbl1.cndtBuscar(wg_sNomTblE1,
                  wg_sNomCmpE11,
                  wg_sDatCmpE11,
                  wg_sTipCmpE11,
                  wg_sCmpOrdE11,
                  wg_sTipOrdE11,
                  wr_bEOFE1)


        If wr_bEOFE1 Then
            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = vg_sCodcia
            wp_sCodErr = "10-002"
            mof_MsgError(wp_sNomTbl,
                        wp_sDatCmp,
                        wp_sCodErr)
        Else
            BD_TblaVar()
            Plo_ActivarOK()
        End If

    End Sub
    Private Sub Plo_activarBotones(ByVal wp_sCmdSel)
        cmdCancelar.Visible = True
        Select Case wp_sCmdSel
            Case "A"
                cmdBuscar.Visible = False
                cmdActualizar.Visible = True
                cmdCrear.Visible = False
                cmdEliminar.Visible = False
                cmdOk.Visible = False
            Case "B"
                cmdBuscar.Visible = True
                cmdActualizar.Visible = False
                cmdCrear.Visible = False
                cmdEliminar.Visible = False
                cmdOk.Visible = False
            Case "C"
                cmdBuscar.Visible = False
                cmdActualizar.Visible = False
                cmdCrear.Visible = True
                cmdEliminar.Visible = False
                cmdOk.Visible = False
            Case "E"
                cmdBuscar.Visible = False
                cmdActualizar.Visible = False
                cmdCrear.Visible = False
                cmdEliminar.Visible = True
                cmdOk.Visible = False
            Case "O"
                cmdBuscar.Visible = False
                cmdActualizar.Visible = False
                cmdCrear.Visible = False
                cmdEliminar.Visible = False
                cmdOk.Visible = True
        End Select

    End Sub
    Private Sub Plo_ColorGotFocus()
        Dim wl_oCtr As Control
        For Each wl_oCtr In TabPage1.Controls
            If TypeOf (wl_oCtr) Is TextBox Then
                If wl_oCtr.Focused Then
                    wl_oCtr.BackColor = wg_ClrGot
                End If
            End If
        Next
    End Sub
    Private Sub Plo_ActivarBuscar()

    End Sub
    Private Sub Plo_ActivarCrear()

    End Sub


    Private Sub Plo_ActivarOK()
        Plo_activarBotones("O")
        TextBox1.Focus()
        cmdOk.TabIndex = 0

    End Sub
    Public Sub Plo_activarActualizar()

        cmdActualizar.Visible = True
        cmdActualizar.TabIndex = 0
        cmdOk.Visible = False


    End Sub
    Public Sub PLo_activarEliminar()
        MsgBox("ELiminar")
    End Sub
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        Me.Close()
    End Sub
#End Region

#Region "07 Procedimientos Controladores de Eventos (Remitente_evento)"
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        wp_sCmdSel = "B"
        wl_bYesNo = False
        If TextBox1.Text <> "" Then
            BD_DatPrm(wg_sTipTbl)
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""
            wg_DTE1 = clnConTbl.cndtBuscar(wg_sNomTblE1,
                      wg_sNomCmpE11,
                      wg_sDatCmpE11,
                      wg_sTipCmpE11,
                      wg_sCmpOrdE11,
                      wg_sTipOrdE11,
                      wr_bEOFE1)
            If wr_bEOFE1 Then
                wp_sNomTbl = wg_sNomTblE1
                wp_sDatCmp = TextBox1.Text
                wp_sCodErr = "10-102"
                mof_MsgError(wp_sNomTbl,
                            wp_sDatCmp,
                            wp_sCodErr)
                TextBox1.Focus()
            Else
                BD_TblaVar()
                Plo_ActivarOK()
                mof_habTsbEliminar()
            End If
        End If
        TextBox1.Focus()
    End Sub

    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        Dim wp_nNroOpc As Integer
        wp_nNroOpc = 1
        BD_CrearActualizar(wp_nNroOpc)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        mof_LmpMsgError()
        grl_Cerrar()

    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        wp_sCmdSel = "A"
        wl_bYesNo = False
        wr_bEOFE1 = True
        wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
        If wl_bYesNo Then
            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = "20-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            Plo_ActivarOK()
        Else
            TextBox1.Focus()
        End If
        Plo_ActivarOK()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        wp_sCmdSel = "E"
        wl_bYesNo = False
        If TextBox1.Text <> "" Then
            wp_nBoxMsg = 4
            wp_sDesMsg = "Este opción elimina el usuario. ¿ Continua ?"
            wp_sTitMsg = "Mensaje del sistema"

            wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                     wp_sDesMsg,
                                     wp_sTitMsg)

            If wp_nResMsg = 6 Then
                BD_DatPrm(wg_sTipTbl)
                wp_sCmpOrd = ""
                wp_sTipOrd = ""

                wg_DTE1 = clnConTbl.cndtBuscar(wp_sNomTbl,
                                           wp_sNomCmp,
                                           wp_sDatCmp,
                                           wp_sTipCmp,
                                           wp_sCmpOrd,
                                           wp_sTipOrd,
                                           wr_bEOF)
                If Not wr_bEOFE1 Then
                    wl_bYesNo = clnActTbl.cnEliReg(wp_sNomTbl,
                                           wp_sNomCmp,
                                           wp_sDatCmp,
                                           wp_sTipCmp,
                                           wr_bEOF)
                    If wl_bYesNo Then
                        Plo_ActivarBuscar()
                        wp_sNomTbl = wg_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = "20-001"
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        Plo_ActivarOK()
                        tsb_Crear()
                    Else
                        TextBox2.Focus()
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        mof_LmpMsgError()
        grl_Cerrar()
    End Sub
#End Region

#Region "Funciones"
    Private Function Validaciones(ByRef wl_bVda As Boolean)
        wl_bVda = False
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("El Nombre de la Compañía es Obligatorio")
            TextBox1.Focus()
            Return wl_bVda
        End If
        wl_bVda = True
        Return wl_bVda
    End Function
#End Region

#Region "Procedimientos"
    Private Sub cmd_Primero()
        MsgBox("Primero")
    End Sub
    Private Sub cmd_Anterior()
        MsgBox("Anterior")
    End Sub
    Private Sub cmd_Siguiente()
        MsgBox("Siguiente")
    End Sub
    Private Sub cmd_Ultimo()
        MsgBox("Ultimo")
    End Sub
    Private Sub cmd_Prn()
        MsgBox("Imprimir")
    End Sub
    Private Sub cmd_VistaPrevia()
        MsgBox("Vista Previa")
    End Sub





#End Region


#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#End Region
#Region "grl Eventos"
    Private Sub grl_AddHandler()
        AddHandler mdiPpal.wg_tsbPrimero, AddressOf tsb_Primero
        AddHandler mdiPpal.wg_tsbAnterior, AddressOf tsb_Anterior
        AddHandler mdiPpal.wg_tsbSiguiente, AddressOf tsb_Siguiente
        AddHandler mdiPpal.wg_tsbUltimo, AddressOf tsb_Ultimo
        AddHandler mdiPpal.wg_tsbBuscar, AddressOf tsb_Buscar
        AddHandler mdiPpal.wg_tsbCrear, AddressOf tsb_Crear
        AddHandler mdiPpal.wg_tsbEliminar, AddressOf tsb_Eliminar
        AddHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
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
        RemoveHandler mdiPpal.wg_tsbVistaPrevia, AddressOf tsb_VistaPrevia
        RemoveHandler mdiPpal.wg_tsbPrn, AddressOf tsb_Prn
        RemoveHandler mdiPpal.wg_tsmiCrearLinea, AddressOf tsmi_CrearLinea
        RemoveHandler mdiPpal.wg_tsmiEliminarLinea, AddressOf tsmi_EliminarLinea
    End Sub
#End Region
#Region "Evento Got Focus"
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = wg_ClrGot

        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length
    End Sub
    Private Sub TextBox2_GotFocus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = wg_ClrGot
        TextBox2.SelectionStart = 0
        TextBox2.SelectionLength = TextBox2.Text.Length
    End Sub
    Private Sub txtsCiuCia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCiuCia.GotFocus
        txtsCiuCia.BackColor = wg_ClrGot
        txtsCiuCia.SelectionStart = 0
        txtsCiuCia.SelectionLength = txtsCiuCia.Text.Length
    End Sub
    Private Sub txtsDepCia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsDepCia.GotFocus
        txtsDepCia.BackColor = wg_ClrGot
        txtsDepCia.SelectionStart = 0
        txtsDepCia.SelectionLength = txtsDepCia.Text.Length
    End Sub
    Private Sub txtsPaiCia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPaiCia.GotFocus
        txtsPaiCia.BackColor = wg_ClrGot
        txtsPaiCia.SelectionStart = 0
        txtsPaiCia.SelectionLength = txtsPaiCia.Text.Length
    End Sub
    Private Sub txtsRepLeg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsRepLeg.GotFocus
        txtsRepLeg.BackColor = wg_ClrGot
        txtsRepLeg.SelectionStart = 0
        txtsRepLeg.SelectionLength = txtsRepLeg.Text.Length
    End Sub

    Private Sub txtsTel1Cia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsTel1Cia.GotFocus
        txtsTel1Cia.BackColor = wg_ClrGot
        txtsTel1Cia.SelectionStart = 0
        txtsTel1Cia.SelectionLength = txtsTel1Cia.Text.Length
    End Sub
    Private Sub txtsTel2Cia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsTel2Cia.GotFocus
        txtsTel2Cia.BackColor = wg_ClrGot
        txtsTel2Cia.SelectionStart = 0
        txtsTel2Cia.SelectionLength = txtsTel2Cia.Text.Length
    End Sub

    Private Sub txtsFaxCia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsFaxCia.GotFocus
        txtsFaxCia.BackColor = wg_ClrGot
        txtsFaxCia.SelectionStart = 0
        txtsFaxCia.SelectionLength = txtsFaxCia.Text.Length
    End Sub

    Private Sub txtsEmlCia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsEmlCia.GotFocus
        txtsEmlCia.BackColor = wg_ClrGot
        txtsEmlCia.SelectionStart = 0
        txtsEmlCia.SelectionLength = txtsEmlCia.Text.Length
    End Sub
    Private Sub txtsNitCia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsNitCia.GotFocus
        txtsNitCia.BackColor = wg_ClrGot
        txtsNitCia.SelectionStart = 0
        txtsNitCia.SelectionLength = txtsNitCia.Text.Length
    End Sub

    Private Sub txtsDigVer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsDigVer.GotFocus
        txtsDigVer.BackColor = wg_ClrGot
        txtsDigVer.SelectionStart = 0
        txtsDigVer.SelectionLength = txtsDigVer.Text.Length
    End Sub
    Private Sub cbosTipInv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosTipInv.GotFocus
        cbosTipInv.BackColor = wg_ClrGot
    End Sub
#End Region
#Region "Evento Lost Focus"


    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = wg_ClrLost
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsCiuCia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCiuCia.LostFocus
        txtsCiuCia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsDepCia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsDepCia.LostFocus
        txtsDepCia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsPaiCia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPaiCia.LostFocus
        txtsPaiCia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsRepLeg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsRepLeg.LostFocus
        txtsRepLeg.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsTel1Cia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsTel1Cia.LostFocus
        txtsTel1Cia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsTel2Cia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsTel2Cia.LostFocus
        txtsTel2Cia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsFaxCia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsFaxCia.LostFocus
        txtsFaxCia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsEmlCia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsEmlCia.LostFocus
        txtsEmlCia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsNitCia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsNitCia.LostFocus
        txtsNitCia.BackColor = wg_ClrLost
    End Sub
    Private Sub txtsDigVer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsDigVer.LostFocus
        txtsDigVer.BackColor = wg_ClrLost
    End Sub
    Private Sub cbosTipInv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbosTipInv.LostFocus
        cbosTipInv.BackColor = wg_ClrLost
    End Sub

#End Region
#Region "Eventos KeyDown, ENTER"
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsCiuCia.Focus()
        End If
    End Sub

    Private Sub txtsCiuCia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsCiuCia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsDepCia.Focus()
        End If
    End Sub
    Private Sub txtsDepCia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsDepCia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsPaiCia.Focus()
        End If
    End Sub
    Private Sub txtsPaiCia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsPaiCia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsRepLeg.Focus()
        End If
    End Sub
    Private Sub txtsrepLeg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsRepLeg.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsTel1Cia.Focus()
        End If
    End Sub
    Private Sub txtsTel1Cia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsTel1Cia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsTel2Cia.Focus()
        End If
    End Sub
    Private Sub txtsTel2Cia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsTel2Cia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsEmlCia.Focus()
        End If
    End Sub
    Private Sub txtsEmlCia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsEmlCia.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmdActualizar.Visible = True Then
                cmdActualizar.Focus()
            Else
                cmdOk.Focus()
            End If
        End If

    End Sub
#End Region
#Region "Eventos Text Changed"
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Plo_activarActualizar()
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsCiuCia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsCiuCia.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsDepCia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsDepCia.TextChanged
        Plo_activarActualizar()
    End Sub
    Private Sub txtsPaiCia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsPaiCia.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsRepLeg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsRepLeg.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsTel1Cia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsTel1Cia.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsTel2Cia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsTel2Cia.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsFaxCia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsFaxCia.TextChanged
        Plo_activarActualizar()
    End Sub
    Private Sub txtsEmlCia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsEmlCia.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsNitCia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsNitCia.TextChanged
        Plo_activarActualizar()
    End Sub

    Private Sub txtsDigVer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsDigVer.TextChanged
        Plo_activarActualizar()
    End Sub
    Private Sub cboATASI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboATASI.SelectedIndexChanged
        Plo_activarActualizar()
    End Sub
    Private Sub chbbInvPte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbbInvPte.CheckedChanged
        Plo_activarActualizar()
    End Sub

    Private Sub cbosTipInv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosTipInv.SelectedIndexChanged
        Plo_activarActualizar()
    End Sub
    Private Sub chbbCosXBod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbbCosXBod.CheckedChanged
        Plo_activarActualizar()
    End Sub

    Private Sub chbbMovSinCos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbbMovSinCos.CheckedChanged
        Plo_activarActualizar()
    End Sub

#End Region

#Region "90 tsb ToolStrip Procedimientos eventos de la barra de herramientas"
    Private Sub tsb_Primero()
        Dim clnConTbl1 As New ClaseNegocios.clnConTbl
        Dim clnActTbl1 As New ClaseNegocios.clnActTbl

        BD_DatPrmTSB()
        mof_habTsbCrear()
        wr_bEOFE1 = True
        Try
            If wg_sNomTblE1 <> "" Then
                wg_DTE1 = clnConTbl1.cndtPrimero(wg_sNomTblE1,
                                                wg_sCmpTSB,
                                                wg_sDatTSB,
                                                wr_bEOFE1)
                If Not wr_bEOFE1 Then
                    tsb_TblAVar()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Primero")
        End Try

    End Sub
    Private Sub tsb_Anterior()
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
                    tsb_TblAVar()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Anterior")
        End Try

    End Sub
    Private Sub tsb_Siguiente()
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
                    tsb_TblAVar()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en: tsb_Siguiente")
        End Try

    End Sub
    Private Sub tsb_Ultimo()
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
                    tsb_TblAVar()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Ultimo")
        End Try
    End Sub
    Private Sub tsb_TblAVar()
        wr_bEOFE1 = True
        cmdOk.Focus()
        Try
            BD_TblaVar()
            Plo_ActivarOK()
            mof_habTsbEliminar()
        Catch ex As Exception
            MsgBox("Error en: tsb_TblAVar")
        End Try
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
    Private Sub tsb_VistaPrevia()
        MsgBox("Vista Previa")
    End Sub
    Public Sub tsb_Buscar()
        Lmp_limpiarfrm()
        mof_habTsbCrear()
        Plo_ActivarBuscar()
    End Sub
    Public Sub tsb_Crear()
        Lmp_limpiarfrm()
        mof_habTsbCrear()
        Plo_ActivarCrear()

    End Sub
    Public Sub tsb_Eliminar()
        PLo_activarEliminar()
    End Sub
    Private Sub BD_DatPrmTSB()
        Select Case wg_nClaPpltsb
            Case 1
                Select Case wg_nCmpCla
                    Case 1
                        wg_sCmpTSB = wg_sCmpTSB1
                        wg_sDatTSB = vp_nId
                        wg_sTipCmpTSB = "N"

                    Case 2
                        wg_sCmpTSB = wg_sCmpTSB2
                        wg_sDatTSB = wg_sClaPpl
                        wg_sTipCmpTSB = "N"
                End Select
            Case 2

        End Select
    End Sub
#End Region

#Region "90 2  tsmi ToolStripMenuItem Procedimientos eventos barra de menus"
    Private Sub tsmi_CrearLinea()
    End Sub
    Private Sub tsmi_EliminarLinea()
    End Sub

#End Region

   
End Class