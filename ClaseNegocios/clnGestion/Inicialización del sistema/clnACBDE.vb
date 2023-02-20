Imports System.Data
Imports ClaseDatos
Public Class clnACBDE
    Dim wl_DT As New DataTable
    Dim oAccDat As New ClaseDatos.cldACBDE
    Public Function cndtConsultar(ByRef vp_bCiaSel,
                                  ByRef wp_pEOF) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultar(vp_bCiaSel, wp_pEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnACBDE.cndtConsultar")
            'Throw ex
            ' MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class


