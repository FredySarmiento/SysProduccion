Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATALM
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATALM
    Public Function cnCrearActATALM(ByVal wp_eATALM As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oAccDat.cdCrearActATALM(wp_eATALM,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATALM.cnCrearActATALM")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATALM(ByVal wp_eATALM As Object,
                                 ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATALM(wp_eATALM,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATALM.cnEliATALM")
        End Try
        Return wl_YesNo

    End Function
End Class
