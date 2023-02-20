Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos


Public Class clnATUME
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATUME

    Public Function cnCrearActualizar(ByVal wp_eATUME As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wp_eATUME,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATUME.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
End Class
