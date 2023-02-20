Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATANA
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATANA
    Public Function cnCrearActATANA(ByVal wp_eATANA As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATANA(wp_eATANA,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATANA.cnCrearActATANA")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATANA(ByVal wp_eATANA As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATANA(wp_eATANA,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnATANA.cnEliATANA")
        End Try
        Return wl_YesNo

    End Function
End Class
