Public Class frmPEODP_SelRpt
    Public wp_bImpP001 As Boolean
    Public wp_bImpP002 As Boolean
    Public wp_bImpP003 As Boolean
    Public wp_bImpP004 As Boolean
    Public wp_bImpP005 As Boolean


    Private Sub frmPEODP_SelRpt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            '           Me.Text += "  -  " + vg_sNomCia
            chbbImpOdp.Checked = True
            wp_bImpP001 = chbbImpOdp.Checked

            chbbImpCld.Checked = False
            wp_bImpP002 = chbbImpCld.Checked

            chbbImpOpe.Checked = False
            wp_bImpP003 = chbbImpOpe.Checked

            chbbImpEti.Checked = False
            wp_bImpP004 = chbbImpEti.Checked

            chbbImpSal.Checked = False
            wp_bImpP005 = chbbImpSal.Checked


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
    
    Private Sub chbbImpCld_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbbImpCld.CheckedChanged
        Try
            wp_bImpP002 = chbbImpCld.Checked
        Catch ex As Exception
            MsgBox("Error :  chbbImpCld_CheckedChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chbbImpEti_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbbImpEti.CheckedChanged
        Try
            wp_bImpP004 = chbbImpEti.Checked
        Catch ex As Exception
            MsgBox("Error :  chbbImpEti_CheckedChanged")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub chbbImpOdp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbbImpOdp.CheckedChanged
        Try
            wp_bImpP001 = chbbImpOdp.Checked
        Catch ex As Exception
            MsgBox("Error :  chbbImpOdp_CheckedChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chbbImpOpe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbbImpOpe.CheckedChanged
        Try
            wp_bImpP003 = chbbImpOpe.Checked
        Catch ex As Exception
            MsgBox("Error :  chbbImpOdp_CheckedChanged")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chbbImpSal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbbImpSal.CheckedChanged
        Try
            wp_bImpP005 = chbbImpSal.Checked
        Catch ex As Exception
            MsgBox("Error :  chbbImpOdp_CheckedChanged")
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