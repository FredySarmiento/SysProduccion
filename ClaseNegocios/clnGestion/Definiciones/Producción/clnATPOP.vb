Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnATPOP
    Dim oAccDat As New ClaseDatos.cldATPOP
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActATPOP(ByVal wr_eATPOP As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActATPOP(wr_eATPOP,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnATPOP.cnCrearActATPOP")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConATPOP(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConATPOP(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnATPOP.cndtConATPOP")
            Return Nothing
        End Try
    End Function

    Public Function cnEliATPOP(ByVal wr_eATPOP As Object,
                               ByVal wr_bEOF As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliATPOP(wr_eATPOP,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnATPOP.cnEliATPOP")
        End Try
        Return wl_YesNo

    End Function
End Class
