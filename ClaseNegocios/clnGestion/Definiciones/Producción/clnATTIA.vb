Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATTIA
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATTIA
    Public Function cnCrearActATTIA(ByVal wp_eATTIA As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATTIA(wp_eATTIA,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATTIA.cnCrearActATTIA")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATTIA(ByVal wp_eATTIA As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATTIA(wp_eATTIA,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATTIA.cnEliATTIA")
        End Try
        Return wl_YesNo

    End Function
End Class
