Imports System.Data
Imports System.Data.OleDb

Imports ClaseDatos

Public Class clnIEDMI
    Public Function cndtConsultar(ByVal vp_sCodItm As String, _
                             ByRef vp_bEOF As Boolean) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        Try
            vl_DT = objAccDat.cddtConsultar(vp_sCodItm, vp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
   
    Public Sub cnCrearActualizar(
                   ByVal vp_sCodItm As String, _
                   ByVal vp_sCodBar As String, _
                   ByVal vp_sDesItm As String, _
                   ByVal vp_sDesAlt As String, _
                   ByVal vp_sClsItm As String, _
                   ByVal vp_sCodGrp As String, _
                   ByVal vp_sCodSgr As String, _
                   ByVal vp_bItmInv As Boolean, _
                   ByVal vp_bItmVta As Boolean, _
                   ByVal vp_bItmCom As Boolean, _
                   ByVal vp_bIndIVA As Boolean, _
                   ByVal vp_sCodAlt As String, _
                   ByVal vp_sTipGes As String, _
                   ByVal vp_bItmAct As Boolean, _
                   ByVal vp_bItmIna As Boolean, _
                   ByVal vp_sCodTerPrv As String, _
                   ByVal vp_sCodTerFte As String, _
                   ByVal vp_sCodItmFte As String, _
                   ByVal vp_sUniMedCom As String, _
                   ByVal vp_nCanUniCom As Double, _
                   ByVal vp_sUniEmpCom As String, _
                   ByVal vp_nCanUniECom As Double, _
                   ByVal vp_sCodItoCom As String, _
                   ByVal vp_sUniMedVta As String, _
                   ByVal vp_nCanUniVta As Double, _
                   ByVal vp_sUniEmpVta As String, _
                   ByVal vp_nCanUniEVta As Double, _
                   ByVal vp_sCodItoVta As String, _
                   ByVal vp_sCriCtaCbe As String, _
                   ByVal vp_sUniMedInv As String, _
                   ByVal vp_sMetVlz As String, _
                   ByVal vp_nCosItm As Double, _
                   ByRef wp_bEOF As Boolean, _
                   ByVal wp_sCmdSel As String)
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        objAccDat.cdCrearActualizar(
            vp_sCodItm, _
            vp_sCodBar, _
            vp_sDesItm, _
            vp_sDesAlt, _
            vp_sClsItm, _
            vp_sCodGrp, _
            vp_sCodSgr, _
            vp_bItmInv, _
            vp_bItmVta, _
            vp_bItmCom, _
            vp_bIndIVA, _
            vp_sCodAlt, _
            vp_sTipGes, _
            vp_bItmAct, _
            vp_bItmIna, _
            vp_sCodTerPrv, _
            vp_sCodTerFte, _
            vp_sCodItmFte, _
            vp_sUniMedCom, _
            vp_nCanUniCom, _
            vp_sUniEmpCom, _
            vp_nCanUniECom, _
            vp_sCodItoCom, _
            vp_sUniMedVta, _
            vp_nCanUniVta, _
            vp_sUniEmpVta, _
            vp_nCanUniEVta, _
            vp_sCodItoVta, _
            vp_sCriCtaCbe, _
            vp_sUniMedInv, _
            vp_sMetVlz, _
            vp_nCosItm, _
            wp_bEOF, _
            wp_sCmdSel)
    End Sub

    Public Sub cnEliminar(ByRef vp_sCodCia As Integer,
                       ByVal wp_bEOF As String)
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        objAccDat.cdEliminar(vp_sCodCia, _
                                 wp_bEOF)


    End Sub
    Public Function cndtConsultarILMDI1(ByVal vp_sCodItm As String, _
                                ByRef vp_bEOF As Boolean) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        Try
            vl_DT = objAccDat.cddtConsultarILMDI1(vp_sCodItm, vp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConSdoILMDI1(ByVal vp_sCodAlm As String, _
                                     ByVal vp_sCodItm As String, _
                                     ByRef wp_bEOF As Boolean) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        Try
            vl_DT = objAccDat.cddtConSdoILMDI1(vp_sCodAlm, _
                                               vp_sCodItm, _
                                               wp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActualizarILMDI1(ByVal vp_sCodItm As String, _
                                           ByVal vp_sCodalm As String, _
                                           ByVal vp_nCanMin As Double, _
                                           ByVal vp_nCanMax As Double, _
                                           ByVal vp_nOrdMin As Double, _
                                           ByVal vp_nSdoAlm As Double, _
                                           ByVal vp_nPreUni As Double, _
                                           ByVal wp_bEOF As Boolean, _
                                           ByVal vp_sOpc As String) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        Try
            vl_DT = objAccDat.cdCrearActualizarILMDI1(vp_sCodItm, _
                                                        vp_sCodalm, _
                                                        vp_nCanMin, _
                                                        vp_nCanMax, _
                                                        vp_nOrdMin, _
                                                        vp_nSdoAlm, _
                                                        vp_nPreUni, _
                                                        wp_bEOF, _
                                                        vp_sOpc)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnEliminarILMDI1(ByVal vp_sCodItm As String, _
                                           ByVal vp_sCodalm As String, _
                                ByRef vp_bEOF As Boolean) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEDMI()
        Try
            vl_DT = objAccDat.cdEliminarILMDI1(vp_sCodItm, _
                                              vp_sCodalm, _
                                              vp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
