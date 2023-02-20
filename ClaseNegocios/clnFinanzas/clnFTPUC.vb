Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnFTPUC
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldFTPUC
    Public Function cndtConFTPUC(ByVal wp_eFTPUC_Ini As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
             wl_YesNo = False
            wl_DT = oAccDat.cddtConFTPUC(wp_eFTPUC_Ini,
                                         wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnFTPUC.cndtConFTPUC")
            Return Nothing
            Throw ex
        End Try
    End Function

    Public Function cnCrearActFTPUC(ByVal wp_eFTPUC As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActFTPUC(wp_eFTPUC,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnFTPUC.cnCrearActFTPUC")
        End Try
        Return wl_YesNo

    End Function

    Public Function cnEliFTPUC(ByVal wp_eFTPUC As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliFTPUC(wp_eFTPUC,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnFTPUC.cnEliFTPUC")
        End Try
        Return wl_YesNo

    End Function
End Class
