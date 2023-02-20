Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnACUNI
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldACUNI
    Public Function cnCrearActACUNI(ByVal wp_eACUNI As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActACUNI(wp_eACUNI,
                                               wr_bEOF,
                                              wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnACUNI.cnCrearActACUNI")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliACUNI(ByVal wp_eACUNI As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliACUNI(wp_eACUNI,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnACUNI.cnEliACUNI")
        End Try
        Return wl_YesNo

    End Function
End Class
