Imports System.Data
Imports System.Data.OleDb
Imports ClaseNegocios

Public Class frmGLogin
#Region "000 Inicia. Definición de variables"
    'Ultima actualización 000 - 019 : 2014-11-24
#Region "001 Inicia. wg - vg Definición del variables públicas"
#End Region
#Region "011 frm - Variables Locales"
    'Variables de trabajo parámetro
    Dim wl_sText As String

    Dim wp_sNomTbl As String
    Dim wp_sNomCmp As String
    Dim wp_sDatCmp As String
    Dim wp_sCodErr As String
    Dim wp_sDesErr As String
    Dim wp_sCodClr As String
    Dim wp_bEOF1 As Boolean
    Dim wl_bEOF As Boolean
    Dim wp_bEOF2 As Boolean
    Dim wp_bVda1 As Boolean
    Dim wp_bVda2 As Boolean
#End Region
#Region "012 BD - Variables campos BD Locales"
    Dim vp_sCodUsr As String
    Dim vp_sPwdUsr As String
    Dim vp_sCodErr As String
    Dim vp_sDesErr As String
    Dim vp_sCodClr As String
#End Region
#Region "014 Objetos locales"
    Dim clnATUSR As New ClaseNegocios.clnATUSR
    Dim clnATERR As New ClaseNegocios.clnATERR
    Dim clnATAUT As New ClaseNegocios.clnATAUT
    Dim oAccDat As New ClaseNegocios.clnATUSR
    Dim wl_DT1 As New DataTable
#End Region
#End Region

#Region "020 frm Eventos - Principal"
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = mdiPpal
            Me.Text += "  -  " + vg_sNomCia
            txtsNomCia.Text = vg_sNomCia
            limpiarCampos()
            txtsCodUsr.Focus()
        Catch ex As Exception
            MsgBox("Error : frmLogin_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "040 BD Procedimientos sobre la BD. Personalizados"

#End Region
#Region "042 BD Busquedas"
    Private Function BD_ConATAUT() As Boolean
        Try
            wl_DT1 = New DataTable
            ReDim wg_aeATAUT(0)
            wl_bEOF = False
            wl_DT1 = clnATAUT.cndtConATAUT(vg_sCodUsr,
                                           wl_bEOF)
            If wl_bEOF = False Then
                moo_aeATAUT_DT(wg_aeATAUT,
                               wl_DT1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_ConATAUT")
        End Try
        Return wr_bEOFE2
    End Function
#End Region
#Region "050 CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
#Region "CommandButtons_Click ABRECO Controladores de Eventos (Remitente_evento)"
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Try
            vg_sCodUsr = txtsCodUsr.Text
            vp_sCodUsr = txtsCodUsr.Text
            vp_sPwdUsr = txtsPwdUsr.Text
            wg_DTE1 = clnATUSR.cndtConsultar(vp_sCodUsr,
                                             vp_sPwdUsr,
                                             wp_bEOF1)
            If wp_bEOF1 Then
                vp_sCodErr = "10-001"
                vp_sDesErr = ""
                vp_sCodClr = ""
                wg_DTE1 = clnATERR.cndtConsultar(vp_sCodErr,
                                                 wp_bEOF1)
                If Not wp_bEOF1 Then
                    If wg_DTE1.Rows(0).Item("sCodClr") = "RED" Then
                        mdiPpal.lblMsgErr.BackColor = Color.Red
                    End If
                    mdiPpal.lblMsgErr.Text = wg_DTE1.Rows(0).Item("sDesErr")
                    txtsCodUsr.Focus()
                End If

            Else
                BD_ConATAUT()
                Me.Close()
                frmGMnuPpal.MdiParent = mdiPpal
                frmGMnuPpal.Show()
            End If
        Catch ex As Exception
            MsgBox("Error : cmdOK_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinalizar.Click
        Try
            Me.Close()
            mdiPpal.finalizar()
        Catch ex As Exception
            MsgBox("Error : cmdFinalizar_Click")
            MsgBox(ex.Message)
        End Try
       
    End Sub
#End Region
#End Region

#Region "080 Plo "
#Region "080 Plo Procedimientos del Formulario. Personalizados"
    Private Sub limpiarCampos()
        Try
            txtsCodUsr.Text = ""
            txtsPwdUsr.Text = ""
            txtsCodUsr.Focus()

        Catch ex As Exception
            MsgBox("Error : limpiarCampos")
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function validarUsr(ByVal vp_sCodusr,
                               ByVal vp_sPwdUsr,
                               ByRef wr_bEOF)
        Dim clnATUSR As New ClaseNegocios.clnATUSR
        Dim wl_DT1 As New DataTable
        Try
            wl_DT1 = clnATUSR.cndtConsultar(vp_sCodusr,
                                            vp_sPwdUsr,
                                            wr_bEOF)
            If wl_DT1 Is Nothing Then
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : validarUsr")
            MsgBox(ex.Message)
        End Try
        Return wl_DT1
    End Function
#End Region

#End Region
#Region "082 Elo Eventos locales del Formulario"
    Private Sub txtsCodUsr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodUsr.GotFocus
        Try
            txtsCodUsr.AutoSize = False
            txtsCodUsr.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
            txtsCodUsr.Height = 16
            txtsCodUsr.BackColor = Color.PaleGoldenrod
            txtsCodUsr.SelectionStart = 0
            txtsCodUsr.SelectionLength = txtsCodUsr.Text.Length
        Catch ex As Exception
            MsgBox("Error : txtsCodUsr_GotFocus")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtsCodUsr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsCodUsr.LostFocus
        Try
            txtsCodUsr.BackColor = Color.White
            mdiPpal.lblMsgErr.BackColor = Color.WhiteSmoke
            mdiPpal.lblMsgErr.Text = ""
        Catch ex As Exception
            MsgBox("Error : txtsCodUsr_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtsPwdUsr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPwdUsr.GotFocus
        Try
            txtsPwdUsr.AutoSize = False
            txtsPwdUsr.Font = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
            txtsPwdUsr.Height = 16

            txtsPwdUsr.BackColor = Color.PaleGoldenrod
            txtsPwdUsr.SelectionStart = 0
            txtsPwdUsr.SelectionLength = txtsPwdUsr.Text.Length
        Catch ex As Exception
            MsgBox("Error : txtsPwdUsr_GotFocus")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtsPwdUsr_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsPwdUsr.KeyUp
        Try
            If e.KeyData = Keys.Enter Then
                cmdOK.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : txtsCodUsr_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtsPwdUsr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsPwdUsr.LostFocus
        Try
            txtsPwdUsr.BackColor = Color.White
        Catch ex As Exception
            MsgBox("Error : txtspwdUsr_LostFocus")
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region


End Class

