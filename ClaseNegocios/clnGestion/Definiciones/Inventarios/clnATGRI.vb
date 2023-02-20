Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATGRI
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATGRI

    Public Function cnCrearActATGRI(ByVal wp_eATGRI As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATGRI(wp_eATGRI,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATGRI.cnCrearActATGRI")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATGRI(ByVal wp_eATGRI As Object,
                                 ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATGRI(wp_eATGRI,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATGRI.cnEliATGRI")
        End Try
        Return wl_YesNo

    End Function
End Class
