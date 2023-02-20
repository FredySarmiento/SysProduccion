Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos

Public Class clnACPAG
    Dim oAccDat As New ClaseDatos.cldACPAG()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActACPAG(ByVal wr_eACPAG As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActACPAG(wr_eACPAG,
                                               wr_bEOF,
                                               wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnACPAG.cnCrearActACPAG")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConACPAG(ByVal wr_eACPAG As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConACPAG(wr_eACPAG,
                                         wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnACPAG.cndtConACPAG")
            Return Nothing
        End Try
    End Function

    Public Function cnEliACPAG(ByVal wr_eACPAG As Object,
                               ByVal wr_bEOF As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliACPAG(wr_eACPAG,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnACPAG.cnEliACPAG")
        End Try
        Return wl_YesNo
    End Function
End Class
