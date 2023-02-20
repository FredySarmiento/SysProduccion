Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATASI
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldATASI
    Public Function cndtConATASI(ByVal wp_eATASI As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try


            wl_DT = oAccDat.cddtConATASI(wp_eATASI,
                                            wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATASI.cndtConATASI")
        End Try
        Return wl_DT

    End Function
    Public Function cnCrearActATASI(ByVal wp_eATASI As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oAccDat.cdCrearActATASI(wp_eATASI,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATASI.cnCrearActATASI")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliATASI(ByVal wp_eATASI As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATASI(wp_eATASI,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnATASI.cnEliATASI")
        End Try
        Return wl_YesNo

    End Function
End Class
