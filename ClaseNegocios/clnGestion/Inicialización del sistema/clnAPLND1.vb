Imports System.Data
Imports ClaseDatos
Public Class clnAPLND1
    Dim oAccDat As New ClaseDatos.cldAPLND1()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(ByVal wr_eAPLND1 As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wr_eAPLND1,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnAPLND1.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConAPLND1(ByVal wr_eAPLND1 As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConAPLND1(wr_eAPLND1,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnAPLND1.cndtConAPLND1")
            Return Nothing
        End Try
    End Function

    Public Function cnEliminar(ByVal wr_eAPLND1 As Object,
                               ByVal wr_bEOF As String) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(wr_eAPLND1,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnAPLND1.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
End Class
