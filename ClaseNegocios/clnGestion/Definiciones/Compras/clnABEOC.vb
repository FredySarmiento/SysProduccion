Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnABEOC
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldABEOC
    Public Function cnCrearActABEOC(ByVal wp_eABEOC As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActABEOC(wp_eABEOC,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnABEOC.cnCrearActABEOC")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliABEOC(ByVal wp_eABEOC As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliABEOC(wp_eABEOC,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnABEOC.cnEliABEOC")
        End Try
        Return wl_YesNo

    End Function
End Class
