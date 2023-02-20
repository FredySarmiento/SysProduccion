Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class ClnATZON
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATZON
    Public Function cnCrearActATZON(ByVal wp_eATZON As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATZON(wp_eATZON,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATZON.cnCrearActATZON")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATZON(ByVal wp_eATZON As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATZON(wp_eATZON,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATZON.cnEliATZON")
        End Try
        Return wl_YesNo

    End Function
End Class
