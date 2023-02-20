Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnABEOP
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldABEOP
    Public Function cnCrearActABEOP(ByVal wp_eABEOP As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActABEOP(wp_eABEOP,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnABEOP.cnCrearActABEOP")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliABEOP(ByVal wp_eABEOP As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliABEOP(wp_eABEOP,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnABEOP.cnEliABEOP")
        End Try
        Return wl_YesNo

    End Function
End Class
