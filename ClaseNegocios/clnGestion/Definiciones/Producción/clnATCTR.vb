Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATCTR
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATCTR
    Public Function cnCrearActATCTR(ByVal wp_eATCTR As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATCTR(wp_eATCTR,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATCTR.cnCrearActATCTR")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATCTR(ByVal wp_eATCTR As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATCTR(wp_eATCTR,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATCTR.cnEliATCTR")
        End Try
        Return wl_YesNo

    End Function
End Class
