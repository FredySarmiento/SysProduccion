Imports System.Data
Imports ClaseDatos
Public Class clnATAUT
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATAUT
    Public Function cndtConATAUT(ByVal vp_sCodUsr As String,
                                 ByRef wp_bEOF1 As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConATAUT(vp_sCodUsr,
                                         wp_bEOF1)

            Return wl_DT

        Catch ex As Exception
            MsgBox("Error : clnATAUT.cndtConATAUT")
            'Throw ex
            ' MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActATAUT(ByVal wp_eATAUT As Object,
                                    ByRef wp_bEOF1 As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATAUT(wp_eATAUT,
                                               wp_bEOF1,
                                               wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnATUSR.cnCrearActATAUT")
        End Try
        Return wl_YesNo
    End Function

End Class
