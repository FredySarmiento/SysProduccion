Imports System.Data
Imports ClaseDatos



Public Class clnATUSR
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATUSR
    Public Function cndtConsultar(ByVal vp_sCodUsr,
                                  ByVal vp_sPwdUsr,
                                  ByRef vp_bEOF1) As DataTable
        Try
            wl_DT = oAccDat.cddtConsultar(vp_sCodUsr,
                                            vp_sPwdUsr,
                                            vp_bEOF1)

            Return wl_DT

        Catch ex As Exception
            MsgBox("Error : clnATUSR.cndtConsultar")
            'Throw ex
            ' MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActualizar(
                  ByVal vp_sCodUsr As String,
                  ByVal vp_sPwdUsr As String,
                  ByVal vp_sNomUsr As String,
                  ByVal vp_sTipUsr As String,
                  ByVal vp_sTel1Usr As String,
                  ByVal vp_sTel2Usr As String,
                  ByVal vp_sEmlUsr As String,
                  ByVal vp_bUsrBlq As Boolean,
                  ByRef wp_bEOF1 As Boolean,
                  ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(
                        vp_sCodUsr,
                        vp_sPwdUsr,
                        vp_sNomUsr,
                        vp_sTipUsr,
                        vp_sTel1Usr,
                        vp_sTel2Usr,
                        vp_sEmlUsr,
                        vp_bUsrBlq,
                        wp_bEOF1,
                        wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnATUSR.cnCrearActualizar")
        End Try
        Return wl_YesNo
    End Function

End Class


