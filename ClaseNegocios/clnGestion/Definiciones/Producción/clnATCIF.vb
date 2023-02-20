Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATCIF
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATCIF
    Public Function cnCrearActATCIF(ByVal wp_eATCIF As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATCIF(wp_eATCIF,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATCIF.cnCrearActATCIF")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATCIF(ByVal wp_eATCIF As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATCIF(wp_eATCIF,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATCIF.cnEliATCIF")
        End Try
        Return wl_YesNo

    End Function
End Class
