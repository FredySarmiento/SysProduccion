Public Class frmIESAI_LeeSAL
    Public wp_sCodDocOri As String
    Public wp_nNroDocOri As Long
    Private Sub frmIESAI_LeeSAL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            '           Me.Text += "  -  " + vg_sNomCia
            txtsCodDocOri.Text = wp_sCodDocOri
            wp_nNroDocOri = 0

        Catch ex As Exception
            MsgBox("Error :  frmIESAI_LeeSAL_Load")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            wp_nNroDocOri = 0
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"
            wp_sCodDocOri = txtsCodDocOri.Text
            wp_nNroDocOri = Val(txtnNroDocOri.Text)
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
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