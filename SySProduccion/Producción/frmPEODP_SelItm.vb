Public Class frmPEODP_SelItm

    Public wp_bSelItm As Boolean

    Private Sub frmPEODP_SelItm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '           Me.Text += "  -  " + vg_sNomCia
            chbbSelItm.Checked = True
            wp_bSelItm = chbbSelItm.Checked
        Catch ex As Exception
            MsgBox("Error :  frmPEODP_SelItm_Load")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Try
            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdCancelar_Click")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            wp_sCmdSel = "O"

            grl_Cerrar()
        Catch ex As Exception
            MsgBox("Error :  cmdOk_Click")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chbbSelItm_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbbSelItm.CheckedChanged
        Try
            wp_bSelItm = chbbSelItm.Checked
        Catch ex As Exception
            MsgBox("Error :  chbbSelItm_CheckedChanged")
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