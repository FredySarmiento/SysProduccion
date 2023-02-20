Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATOPE
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATOPE
    Public Function cnCrearActATOPE(ByVal wp_eATOPE As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATOPE(wp_eATOPE,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATOPE.cnCrearActATOPE")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATOPE(ByVal wp_eATOPE As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATOPE(wp_eATOPE,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATOPE.cnEliATOPE")
        End Try
        Return wl_YesNo

    End Function
End Class
