Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos

Public Class clnHEDMT
    Dim oAccDat As New ClaseDatos.cldHEDMT()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(ByVal wr_eHEDMT As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wr_eHEDMT,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnHEDMT.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConHEDMT(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConHEDMT(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnHEDMT.cndtConHEDMT")
            Return Nothing
        End Try
    End Function

    Public Function cnEliminar(ByRef vp_sCodItm As String,
                       ByVal wr_bEOF As String) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(vp_sCodItm,
                                 wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnHEDMT.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
End Class
