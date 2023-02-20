Public Class frmPEFOM_LeeFOM
    Public wp_sCoditmIni As String
#Region "010 Inicia. vl - wl Definición del variables Locales"
    ' vl - Variables que corresponde a campos de la BD locales
    ' wl - Variables de trabajo locales
    ' wp - Variables de trabajo locales parámetro
    ' vp - Variables que corresponde a campos de la BD locales - parámeto

    Dim wl_ePEFOM As New moe_Estructuras.ePEFOM
    Dim wl_sDesMsgCmd As String
    Dim wl_sTitMsgCmd As String
#End Region

    Private Sub frmPEFOM_LeeFOM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            '           Me.Text += "  -  " + vg_sNomCia
            wp_sCoditmIni = ""

        Catch ex As Exception
            MsgBox("Error :  frmPEFOM_LeeFOM_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            wp_sCoditmIni = ""
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"
            wp_sCoditmIni = mtbsCodItmIni.Text
            BD_BuscarPEFOM()
            If wr_bEOFE2 = True Then
                mtbsCodItmIni.Focus()
            Else
                grl_Cerrar()
            End If

        Catch ex As Exception
            MsgBox("Error :  cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtbsCodItmIni_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mtbsCodItmIni.KeyUp
        Try
            If e.KeyData = Keys.Enter Or e.KeyData = Keys.Tab Then
                cmdOk.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error : mtbsCodItmIni_KeyUp")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function BD_BuscarPEFOM() As Boolean
        Try

            wr_bEOFE2 = True
            wl_ePEFOM = New moe_Estructuras.ePEFOM
            wr_bEOFE2 = mof_fConPEFOM(wp_sCoditmIni,
                                      wl_ePEFOM)
            If wr_bEOFE2 = True Then

                wl_sDesMsgCmd = "Código No Existe"
                wl_sTitMsgCmd = "Buscar Código Fórmula"""

                wp_nBoxMsg = 0
                wp_sDesMsg = wl_sDesMsgCmd
                wp_sTitMsg = wl_sTitMsgCmd
                wp_nResMsg = mof_fMnjMsg(wp_nBoxMsg,
                                         wp_sDesMsg,
                                         wp_sTitMsg)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en el SUB: BD_BuscarPEFOM")
        End Try
        Return wr_bEOFE2
    End Function
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