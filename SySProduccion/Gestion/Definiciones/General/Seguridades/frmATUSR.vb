Imports System.Data.OleDb
Imports System.Data
Public Class frmATUSR
#Region "01 Eventos Iniciales"
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
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
#End Region

#Region "vl - wl Definición del variables Locales"
    ' Variables Campos de la BD
    Dim vp_nId As Integer
    Dim vp_sCodUsr As String
    Dim vp_sPwdUsr As String
    Dim vp_sNomUsr As String
    Dim vp_sTipUsr As String
    Dim vp_sEmlUsr As String
    Dim vp_sTel1Usr As String
    Dim vp_sTel2Usr As String
    Dim vp_bUsrBlq As Boolean

    ' Variables de trabajo
    Dim wl_bYesNo As Boolean
    Dim wl_bEdit As Boolean

    ' Objetos del formulario
    Dim clnATUSR As New ClaseNegocios.clnATUSR

#End Region

#Region "frm Eventos - Principal"
   
    Private Sub frmATUSR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text += "  -  " + vg_sNomCia
            wg_sTipTbl = "E1"
            BD_DatPrmTipTbl(wg_sTipTbl)
            grl_EventCtrl(Me)
            Plo_IniciarVar()
            Cbo_CargarLista()
            mof_ActivarCrear(Me)
        Catch ex As Exception
            MsgBox("Error : frmATUSR_Load")
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Private Sub frmATUSR_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            Me.Dispose()
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : frmATUSR_Disposed")
            MsgBox(ex.Message)
        End Try
      
    End Sub
    Private Sub frmATUSR_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            TextBox1.Focus()
        Catch ex As Exception
            MsgBox("Error : frmATUSR_Disposed")
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Cbo Llenar Combobox"
    Private Sub Cbo_CargarLista()
        Try
            wg_sTblLst1 = "ABTUS"
            wr_bEOFLst1 = True
            wg_DTLst1 = clnConTbl.cndtCargarLista(wg_sTblLst1,
                                                 wr_bEOFLst1)
            If Not wr_bEOFLst1 Then
                ComboBox1.DataSource = wg_DTLst1
                ComboBox1.DisplayMember = wg_DTLst1.Columns(0).Caption.ToString
                ComboBox1.ValueMember = wg_DTLst1.Columns(0).Caption.ToString
            End If
        Catch ex As Exception
            MsgBox("Error : Cbo_CargarLista")
            MsgBox(ex.Message)
        End Try
      
    End Sub
#End Region

#Region "BD Procedimientos sobre la BD"
    Private Sub BD_DatPrmTipTbl(ByRef wg_sTipTbl As String)
        ' Tipo de tabla
        If wg_sTipTbl = "E1" Then
            wg_sNomTblE1 = "ATUSR"
            wg_sNomCmpE11 = "sCodUsr"
            wg_sTipCmpE11 = "C"
            wg_sTitCmpE11 = "Código usuario "
            wg_sDatCmpE11 = TextBox1.Text
            wr_bEOFE1 = True
        End If
    End Sub
    Private Sub BD_DatPrmTSB() 'Constante
        wg_nCmpCla = 2
        wg_sCmpTSB1 = "nId"
        wg_sCmpTSB2 = "sCodUsr"
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
    End Sub
    Private Sub BD_tsbPASU()
        BD_TblAVp()
        mof_ActivarOK(Me)
    End Sub

    Private Function BD_CrearActualizar(ByVal wp_sCmdSel As String) As Boolean
        wl_bYesNo = False
        Try
            BD_VpATbl()
            If Not Func_Validaciones(wg_bVdaE1) Then
                TextBox1.Focus()
            Else

                wl_bYesNo = clnATUSR.cnCrearActualizar(vp_sCodUsr,
                                                       vp_sPwdUsr,
                                                       vp_sNomUsr,
                                                       vp_sTipUsr,
                                                       vp_sTel1Usr,
                                                       vp_sTel2Usr,
                                                       vp_sEmlUsr,
                                                       vp_bUsrBlq,
                                                       wr_bEOFE1,
                                                       wp_sCmdSel)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: frmATUSR.cmd_CrearActualizar")
        End Try
        Return wl_bYesNo
    End Function
    Private Sub BD_TblAVp()
        wg_sClaPpl = TextBox1.Text
        vp_nId = wg_DTE1.Rows(0).Item(0)
        TextBox1.Text = wg_DTE1.Rows(0).Item(1)
        TextBox6.Text = wg_DTE1.Rows(0).Item(2)
        TextBox2.Text = wg_DTE1.Rows(0).Item(3)
        ComboBox1.SelectedValue = wg_DTE1.Rows(0).Item(4)
        TextBox3.Text = wg_DTE1.Rows(0).Item(6)
        TextBox4.Text = wg_DTE1.Rows(0).Item(7)
        TextBox5.Text = wg_DTE1.Rows(0).Item(5)
        CheckBox1.Checked = wg_DTE1.Rows(0).Item(8)
    End Sub
    Private Sub BD_VpATbl()
        wg_sClaPpl = TextBox1.Text
        vp_sCodUsr = TextBox1.Text
        vp_sNomUsr = TextBox2.Text
        vp_sTipUsr = ComboBox1.SelectedValue.ToString
        vp_sTel1Usr = TextBox3.Text
        vp_sTel2Usr = TextBox4.Text
        vp_sEmlUsr = TextBox5.Text
        vp_sPwdUsr = TextBox6.Text
        vp_bUsrBlq = CheckBox1.Checked
    End Sub
#End Region

#Region "Plo Procedimientos del Formulario"
    Private Sub Plo_IniciarVar()
        wl_bYesNo = False
        wl_bEdit = False
        wg_sCodErrAdi = "10-202"
        wg_sCodErrCon = "10-102"
        wg_sCodErrOk = "20-001"
        wg_sDesMsgEli = "Este opción elimina el usuario. ¿ Continua ?"
        wg_sTitMsgEli = "Mensaje del sistema"

    End Sub
#End Region

#Region "CommandButtons_Click Controladores de Eventos (Remitente_evento)"
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
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            mof_ActivarOK(Me)
        Else
            TextBox2.Focus()
        End If
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        wp_sCmdSel = "B"
        wl_bYesNo = False
        wg_sCmpOrdE11 = ""
        wg_sTipOrdE11 = ""
        mof_LmpMsgError()
        If TextBox1.Text <> "" Then
            BD_DatPrmTipTbl(wg_sTipTbl)
            wg_DTE1 = mof_fConTbl(wg_sNomTblE1,
                                  wg_sNomCmpE11,
                                  wg_sDatCmpE11,
                                  wg_sTipCmpE11,
                                  wg_sCmpOrdE11,
                                  wg_sTipOrdE11,
                                  wr_bEOFE1)
            If wr_bEOFE1 Then
                wp_sNomTbl = wg_sNomTblE1
                wp_sDatCmp = TextBox1.Text
                wp_sCodErr = wg_sCodErrCon
                mof_MsgError(wp_sNomTbl,
                            wp_sDatCmp,
                            wp_sCodErr)
                TextBox1.Focus()
            Else
                BD_TblAVp()
                mof_ActivarOK(Me)
                mof_habTsbEliminar()
            End If
        End If
        TextBox1.Focus()
    End Sub
    Private Sub cmdCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrear.Click
        wp_sCmdSel = "C"
        wl_bYesNo = False
        mof_LmpMsgError()
        If TextBox1.Text <> "" Then
            BD_DatPrmTipTbl(wg_sTipTbl)
            wg_sCmpOrdE11 = ""
            wg_sTipOrdE11 = ""

            wg_DTE1 = mof_fConTbl(wg_sNomTblE1,
                      wg_sNomCmpE11,
                      wg_sDatCmpE11,
                      wg_sTipCmpE11,
                      wg_sCmpOrdE11,
                      wg_sTipOrdE11,
                      wr_bEOFE1)
            If wr_bEOFE1 Then
                wl_bYesNo = BD_CrearActualizar(wp_sCmdSel)
                If wl_bYesNo Then
                    wp_sNomTbl = wg_sNomTblE1
                    wp_sDatCmp = ""
                    wp_sCodErr = wg_sCodErrOk
                    mof_MsgError(wp_sNomTbl,
                                 wp_sDatCmp,
                                 wp_sCodErr)
                    mof_ActivarOK(Me)
                    mof_habTsbCrear()
                    mof_habTsbEliminar()
                End If

            Else
                wp_sNomTbl = wg_sNomTblE1
                wp_sDatCmp = TextBox1.Text
                wp_sCodErr = wg_sCodErrAdi
                mof_MsgError(wp_sNomTbl,
                             wp_sDatCmp,
                             wp_sCodErr)
                TextBox1.Focus()
            End If
        End If
        TextBox1.Focus()
    End Sub
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        wp_sCmdSel = "E"
        wl_bYesNo = False
        mof_LmpMsgError()
        If TextBox1.Text <> "" Then
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

                wg_DTE1 = clnConTbl.cndtBuscar(wg_sNomTblE1,
                                                wg_sNomCmpE11,
                                                wg_sDatCmpE11,
                                                wg_sTipCmpE11,
                                                wg_sCmpOrdE11,
                                                wg_sTipOrdE11,
                                                wr_bEOFE1)
                If Not wr_bEOFE1 Then
                    wl_bYesNo = clnActTbl.cnEliReg(wg_sNomTblE1,
                                                   wg_sNomCmpE11,
                                                   wg_sDatCmpE11,
                                                   wg_sTipCmpE11,
                                                   wr_bEOFE1)
                    If wl_bYesNo Then
                        mof_ActivarBuscar(Me)
                        wp_sNomTbl = wg_sNomTblE1
                        wp_sDatCmp = ""
                        wp_sCodErr = wg_sCodErrOk
                        mof_MsgError(wp_sNomTbl,
                                     wp_sDatCmp,
                                     wp_sCodErr)
                        mof_ActivarBuscar(Me)
                    Else
                        TextBox2.Focus()
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error : cmdBuscar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        wp_sCmdSel = "O"
        grl_Cerrar()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim varfrm As New frmGAPUS
        varfrm.ShowDialog()
    End Sub
#End Region

#Region "Func - Funciones Validaciones"
    Private Function Func_Validaciones(ByRef wl_bVda1 As Boolean)
        wl_bVda1 = False
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("El código del usuario es obligatorio")
            TextBox1.Focus()
            Return wl_bVda1
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("El nombre del usuario es obligatorio")
            TextBox1.Focus()
            Return wl_bVda1
        End If
        If String.IsNullOrEmpty(ComboBox1.SelectedValue.ToString) Then

            MsgBox("El tipo de usuario es obligatorio")
            TextBox1.Focus()
            Return wl_bVda1
        End If

        If String.IsNullOrEmpty(TextBox6.Text) Then
            MsgBox("El password del usuario es obligatorio")
            TextBox1.Focus()
            Return wl_bVda1
        End If
        wl_bVda1 = True
        Return wl_bVda1
    End Function
#End Region

#Region "PROCEDIMIENTOS EVENTOS COMUNES"
#End Region

#Region "grl Changed"
    Private Sub grl_Cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Chb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grl_TextChange()
    End Sub
    Private Sub grl_Txt_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DirectCast(sender, TextBox).Name = "TextBox1" Then
            wg_sClaPpl = TextBox1.Text
            mof_LmpMsgError()
        Else
            grl_TextChange()
        End If
    End Sub
#End Region
#Region "grl Eventos"
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
#End Region
#Region "Grl Got Focus"
    Private Sub grl_Cbo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrGot
    End Sub
    Private Sub grl_Chb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrGot
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
#Region "grl Lost Focus"
    Private Sub grl_Cbo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, ComboBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Chb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, CheckBox).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Rdb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, RadioButton).BackColor = wg_ClrLost
    End Sub
    Private Sub grl_Txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DirectCast(sender, TextBox).BackColor = wg_ClrLost
    End Sub
#End Region
#Region "grl Otros"
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_LmpMsgError()
        Me.Close()
    End Sub
    Private Sub grl_TextChange()
        If cmdOk.Visible = True Or cmdEliminar.Visible = True Then
            mof_ActivarActualizar(Me)
        End If
    End Sub
#End Region
#Region "TSB ToolStrip Procedimientos eventos de la barra de herramientas"
    Public Sub tsb_Buscar()
        mof_fLmpCtrl(Me)
        mof_ActivarBuscar(Me)
    End Sub
    Private Sub tsb_Primero()
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
                    BD_tsbPASU()
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
                    BD_tsbPASU()
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
                    BD_tsbPASU()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: tsb_Ultimo")
        End Try
    End Sub
    Public Sub tsb_Crear()
        mof_fLmpCtrl(Me)
        mof_ActivarCrear(Me)

    End Sub
    Public Sub tsb_Eliminar()
        mof_ActivarEliminar(Me)
    End Sub
    Private Sub tsb_VistaPrevia()
        MsgBox("Vista Previa")
    End Sub
    Private Sub tsb_Prn()
        MsgBox("Imprimir")
    End Sub
#End Region
End Class