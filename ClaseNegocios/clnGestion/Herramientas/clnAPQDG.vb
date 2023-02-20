Imports System.Data
Imports ClaseDatos
Public Class clnAPQDG
    Dim oAccDat As New ClaseDatos.cldAPQDG
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActAPQDG(ByVal wr_eAPQDG As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActAPQDG(wr_eAPQDG,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnAPQDG.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConAPQDG(ByVal wr_eAPQDG As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConAPQDG(wr_eAPQDG,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnAPQDG.cndtConAPQDG")
            Return Nothing
        End Try
    End Function

    Public Function cnEliAPQDG(ByVal wr_eAPQDG As Object,
                               ByVal wr_bEOF As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliAPQDG(wr_eAPQDG,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnAPQDG.cnEliAPQDG")
        End Try
        Return wl_YesNo
    End Function
End Class
