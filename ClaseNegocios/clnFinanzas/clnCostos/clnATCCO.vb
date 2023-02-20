Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATCCO
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATCCO
    Public Function cnCrearActATCCO(ByVal wp_eATCCO As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATCCO(wp_eATCCO,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATCCO.cnCrearActATCCO")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATCCO(ByVal wp_eATCCO As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATCCO(wp_eATCCO,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATCCO.cnEliATCCO")
        End Try
        Return wl_YesNo

    End Function
End Class
