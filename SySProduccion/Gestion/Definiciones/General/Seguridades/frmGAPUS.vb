Imports System.Data.OleDb
Imports System.Data
Public Class frmGAPUS
#Region "02 Definición del variables Locales"
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

    ' Objetos del formulario
    Dim clnATUSR As New ClaseNegocios.clnATUSR
    Dim clnActTbl As New ClaseNegocios.clnActTbl


#End Region
#Region "Programa Principal"
    Private Sub frmASPwdUsr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text += "  -  " + vg_sNomCia
        wg_sTipTbl = "E1"
        mof_inhabTsbPASU()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbEliminar()
        'vg_sCodUsr = "JES"
        'vg_sPwdUsr = "1234"
        txtsPwdUsrCop.Text = vg_sPwdUsr
        Plo_activarBotones("O")
        BD_DatPrm(wg_sTipTbl)


    End Sub

    Private Sub frmASPwdUsr_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtsPwdUsr.Focus()
    End Sub
#End Region
#Region "   BD Procedimientos sobre la BD"
    Private Sub BD_DatPrm(ByRef wg_sTipTbl As String)
        If wg_sTipTbl = "E1" Then
            wg_sNomTblE1 = "ATUSR"
            wg_sNomCmpE11 = "sCodUsr"
            wg_sTipCmpE11 = "C"
            wg_sTitCmpE11 = "Código usuario "
            wg_sDatCmpE11 = vg_sCodUsr
            wr_bEOFE1 = True
        End If

    End Sub
    Private Function BD_ActUnaLlaUnCmp(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomLla As String,
                                  ByVal wp_sDatLla As String,
                                  ByVal wp_sTipLla As String,
                                  ByVal wp_sNomcmp As String,
                                  ByVal wp_sDatcmp As String,
                                  ByVal wp_sTipCmp As String,
                                  ByRef wp_bEOF As Boolean) As Boolean
        wl_bYesNo = False
        Try
            wl_bYesNo = clnActTbl.cndtActUnaLlaUnCmp(
                                  wp_sNomTbl,
                                  wp_sNomLla,
                                  wp_sDatLla,
                                  wp_sTipLla,
                                  wp_sNomcmp,
                                  wp_sDatcmp,
                                  wp_sTipCmp,
                                  wp_bEOF)





        Catch ex As Exception

            MsgBox("Error en el SUB: frmATUSR.cmd_CrearActualizar")
            MsgBox(ex.Message)
        End Try
        Return wl_bYesNo


    End Function

#End Region
#Region "06 - 2 Plo Procedimientos Locales"
    Private Sub Plo_activarBotones(ByVal wp_sCmdSel)
        cmdCancelar.Visible = True
        Select Case wp_sCmdSel
            Case "A"
                cmdActualizar.Visible = True
                cmdOk.Visible = False
            Case "B"
                cmdActualizar.Visible = False
                cmdOk.Visible = False
            Case "C"
                cmdActualizar.Visible = False
                cmdOk.Visible = False
            Case "E"
                cmdActualizar.Visible = False
                cmdOk.Visible = False
            Case "O"
                cmdActualizar.Visible = False
                cmdOk.Visible = True
        End Select

    End Sub
    Private Sub Plo_ActivarActualizar()
        mof_LmpMsgError()
        TextBox1.Enabled = False
        TextBox1.BackColor = wg_ClrEnableF
        Plo_activarBotones("A")
    End Sub
    Private Sub Plo_ActivarBuscar()
        mof_LmpMsgError()
        Plo_activarBotones("B")
        mof_inhabTsbEliminar()
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub
    Private Sub Plo_ActivarCrear()
        mof_LmpMsgError()
        Plo_activarBotones("C")
        mof_inhabTsbEliminar()
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub
    Private Sub Plo_ActivarEliminar()
        mof_LmpMsgError()
        Plo_activarBotones("E")
        TextBox1.Enabled = False
        TextBox1.BackColor = wg_ClrEnableF
        TextBox1.Focus()
    End Sub
    Private Sub Plo_ActivarOK()
        Plo_activarBotones("O")
        TextBox1.Enabled = False
        TextBox1.BackColor = wg_ClrEnableF
        txtsPwdUsr.Focus()
    End Sub
    Private Sub grl_Cerrar()
        mof_inhabTsbBuscar()
        mof_inhabTsbCrear()
        mof_inhabTsbPASU()
        mof_inhabTsbEliminar()
        mof_LmpMsgError()
        Me.Close()
    End Sub
#End Region

#Region "Buttom Click"
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        wl_bYesNo = False
        wr_bEOFE1 = False
        wp_sNomCmp = "sPwdUsr"
        wp_sDatCmp = txtsPwdUsr.Text
        wp_sTipCmp = "C"
        If Trim(txtsPwdUsr.Text) = Trim(txtsPwdUsrCop.Text) Then
            wl_bYesNo = BD_ActUnaLlaUnCmp(wg_sNomTblE1,
                                          wg_sNomCmpE11,
                                          wg_sDatCmpE11,
                                          wg_sTipCmpE11,
                                          wp_sNomCmp,
                                          wp_sDatCmp,
                                          wp_sTipCmp,
                                          wr_bEOFE1)
        End If

        If wl_bYesNo Then
            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = ""
            wp_sCodErr = "20-001"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            Plo_InactCmpAct()
            Plo_ActivarOK()
            cmdOk.Focus()
        Else
            wp_sNomTbl = wg_sNomTblE1
            wp_sDatCmp = wg_sDatCmpE11
            wp_sCodErr = "10-003"
            mof_MsgError(wp_sNomTbl,
                         wp_sDatCmp,
                         wp_sCodErr)
            txtsPwdUsr.Focus()
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
        grl_Cerrar()
    End Sub

#End Region
#Region "Got Focus"
    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPwdUsr.GotFocus
        txtsPwdUsr.BackColor = wg_ClrGot
        txtsPwdUsr.SelectionStart = 0
        txtsPwdUsr.SelectionLength = txtsPwdUsr.Text.Length
    End Sub
    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPwdUsrCop.GotFocus
        txtsPwdUsrCop.BackColor = wg_ClrGot
        txtsPwdUsrCop.SelectionStart = 0
        txtsPwdUsrCop.SelectionLength = txtsPwdUsrCop.Text.Length

    End Sub
#End Region
#Region "Lost Focus"
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPwdUsr.LostFocus
        txtsPwdUsr.BackColor = wg_ClrLost
    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPwdUsrCop.LostFocus
        txtsPwdUsrCop.BackColor = wg_ClrLost
    End Sub
#End Region

#Region "Changed"
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsPwdUsr.TextChanged
        If cmdOk.Visible = True Then
            Plo_ActivarActualizar()
        End If
        mof_LmpMsgError()
    End Sub




    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsPwdUsrCop.TextChanged
        If cmdOk.Visible = True Then
            Plo_ActivarActualizar()
        End If
    End Sub

#End Region

    Private Sub Plo_InactCmpAct()
        Try
            txtsPwdUsr.Enabled = False
            txtsPwdUsrCop.Enabled = False
        Catch ex As Exception
            MsgBox("Error :  Plo_InactCmpAct")
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class