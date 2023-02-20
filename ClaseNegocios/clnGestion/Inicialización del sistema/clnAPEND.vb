Imports System.Data
Imports ClaseDatos
Public Class clnAPEND
    Dim oAccDat As New ClaseDatos.cldAPEND()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(ByVal wr_eAPEND As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wr_eAPEND,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnAPEND.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConAPEND(ByVal wr_eAPEND As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConAPEND(wr_eAPEND,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnAPEND.cndtConAPEND")
            Return Nothing
        End Try
    End Function

    Public Function cnEliminar(ByVal wr_eAPEND As Object,
                               ByVal wr_bEOF As String) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(wr_eAPEND,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnAPEND.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
End Class
