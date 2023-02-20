Imports System.Data
Imports ClaseDatos
Public Class clnAPDGV
    Dim oAccDat As New ClaseDatos.cldAPDGV()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(ByVal wr_eAPDGV As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wr_eAPDGV,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnAPDGV.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConAPDGV(ByVal wr_eAPDGV As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConAPDGV(wr_eAPDGV,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnAPDGV.cndtConAPDGV")
            Return Nothing
        End Try
    End Function

    Public Function cnEliminar(ByVal wr_eAPDGV As Object,
                               ByVal wr_bEOF As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(wr_eAPDGV,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnAPDGV.cnEliminar")
        End Try
        Return wl_YesNo
    End Function
End Class
