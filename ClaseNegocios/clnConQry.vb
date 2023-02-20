Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos

Public Class clnConQry

    Dim oActDatTbl As New ClaseDatos.cldActTbl
    Dim wl_YesNo As Boolean
#Region "Consultas de Producción"
    Public Function cndtConPQFOM1(ByVal wp_sCodItm As String,
                                  ByVal wp_sCodCmt As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldConQry
            wl_DT = oAccDat.cddtConPQFOM1(wp_sCodItm,
                                          wp_sCodCmt,
                                          wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPQLIM1(ByVal wp_sCodItm As String,
                                  ByVal wp_sCodCmt As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldConQry
            wl_DT = oAccDat.cddtConPQLIM1(wp_sCodItm,
                                          wp_sCodCmt,
                                          wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
#End Region


End Class
