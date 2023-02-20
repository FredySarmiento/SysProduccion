Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class ClnATVEN
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATVEN
    Public Function cnCrearActATVEN(ByVal wp_eATVEN As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATVEN(wp_eATVEN,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATVEN.cnCrearActATVEN")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATVEN(ByVal wp_eATVEN As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATVEN(wp_eATVEN,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATVEN.cnEliATVEN")
        End Try
        Return wl_YesNo

    End Function
End Class
