Imports System.Data
Imports ClaseDatos

Public Class clnATERR
    Dim wl_DT As New DataTable
    Dim oAccDat As New ClaseDatos.cldABERR
    Public Function cndtConsultar(ByRef vp_sCodErr,
                                      ByRef wr_bEOF) As DataTable


        Try
            wl_DT = oAccDat.cddtConsultar(vp_sCodErr,
                                            wr_bEOF)

            Return wl_DT

        Catch ex As Exception
            MsgBox("Error : clnATERR.cndtConsultar")
            'Throw ex
            ' MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
