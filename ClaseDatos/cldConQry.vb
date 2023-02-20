
Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldConQry
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wp_sCmdSql As String






#Region "Consultas de Producción"

    Public Function cddtConPQFOM1(ByVal wp_sCodItm As String,
                                   ByVal wp_sCodCmt As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Try

            wp_sCmdSql = "SELECT T0.nId, T0.sCodCmt, T1.sNomItm, T0.bItmAct, T2.sCodItm, T3.sNomItm, T0.sCodItm, T4.sNomItm "
            wp_sCmdSql += "FROM PEFOM AS T4 INNER JOIN (((PLFOM1 AS T0 INNER JOIN IEDMI AS T1 ON T0.sCodCmt = T1.sCodItm)  "
            wp_sCmdSql += "INNER JOIN PLLIM4 AS T2 ON T0.sCodItm = T2.sCodCmt)  "
            wp_sCmdSql += " INNER JOIN IEDMI AS T3 ON T2.sCodItm = T3.sCodItm) ON T4.sCodItm = T0.sCodItm "
            If wp_sCodCmt <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodCmt = "
                wp_sCmdSql += "'" & wp_sCodCmt & "'"
            End If
            wp_sCmdSql += " AND T0.bItmAct = TRUE"


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConQry.cddtConPQFOM02")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPQLIM1(ByVal wp_sCodItm As String,
                                   ByVal wp_sCodCmt As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Try

            wp_sCmdSql = "SELECT T0.nId, T0.sCodCmt, T1.sNomItm, T0.bItmAct, T0.sCodItm, T2.sNomItm "
            wp_sCmdSql += "FROM (PLLIM1 AS T0 INNER JOIN IEDMI AS T1 ON T0.sCodCmt = T1.sCodItm) "
            wp_sCmdSql += "INNER JOIN IEDMI AS T2 ON T0.sCodItm = T2.sCodItm "


            If wp_sCodItm <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodItm = "
                wp_sCmdSql += "'" & wp_sCodItm & "'"

            End If
            If wp_sCodCmt <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodCmt = "
                wp_sCmdSql += "'" & wp_sCodCmt & "'"
            End If
            wp_sCmdSql += " AND T0.bItmAct = TRUE"

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConQry.cddtConPQFOM02")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPQROP02(ByVal wp_sDatCmp As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Return Nothing
    End Function
    Public Function cddtConResCosMOD(ByVal wp_sCodItm As String,
                                     ByVal wp_sCodCmt As String,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT  T0.sTipMov, T0.sCodTra, T5.sNomTra,Sum(T1.nTotLin) AS SumaDenTotLin,"
            wp_sCmdSql += "T2.sCodGrp, T2.sNomGrp, T4.sCtaDeb, T4.sCtaCre"
            wp_sCmdSql += "FROM ATGRI T2 INNER JOIN ((((IEMOV T0 INNER JOIN ILMOV1 T1 ON (T0.nNroDoc = T1.nNroDoc) AND (T0.sCodDoc = T1.sCodDoc))"
            wp_sCmdSql += "INNER JOIN IEDMI T3 ON T1.sCodItm = T3.sCodItm) INNER JOIN ATTGC T4 ON (T0.sCodTra = T4.sCodTra) AND (T3.sCodGrp = T4.sCodGrp)) "
            wp_sCmdSql += "INNER JOIN ATTIN T5 ON T0.sCodTra = T5.sCodTra) ON T2.sCodGrp = T3.sCodGrp "
            wp_sCmdSql += "WHERE (((T0.dFecDoc)>=#11/1/2016# And (T0.dFecDoc)<=#11/30/2016#))"
            wp_sCmdSql += "GROUP BY  T0.sTipMov, T0.sCodTra, T5.sNomTra,T2.sCodGrp, T2.sNomGrp, T4.sCtaDeb, T4.sCtaCre"





            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConQry.cddtConCteCosMPD")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConResCosMPD(ByVal wp_sCodItm As String,
                                     ByVal wp_sCodCmt As String,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT  T0.sTipMov, T0.sCodTra, T5.sNomTra,Sum(T1.nTotLin) AS SumaDenTotLin,"
            wp_sCmdSql += "T2.sCodGrp, T2.sNomGrp, T4.sCtaDeb, T4.sCtaCre"
            wp_sCmdSql += "FROM ATGRI T2 INNER JOIN ((((IEMOV T0 INNER JOIN ILMOV1 T1 ON (T0.nNroDoc = T1.nNroDoc) AND (T0.sCodDoc = T1.sCodDoc))"
            wp_sCmdSql += "INNER JOIN IEDMI T3 ON T1.sCodItm = T3.sCodItm) INNER JOIN ATTGC T4 ON (T0.sCodTra = T4.sCodTra) AND (T3.sCodGrp = T4.sCodGrp)) "
            wp_sCmdSql += "INNER JOIN ATTIN T5 ON T0.sCodTra = T5.sCodTra) ON T2.sCodGrp = T3.sCodGrp "
            wp_sCmdSql += "WHERE (((T0.dFecDoc)>=#11/1/2016# And (T0.dFecDoc)<=#11/30/2016#))"
            wp_sCmdSql += "GROUP BY  T0.sTipMov, T0.sCodTra, T5.sNomTra,T2.sCodGrp, T2.sNomGrp, T4.sCtaDeb, T4.sCtaCre"





            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConQry.cddtConCteCosMPD")
            Return Nothing
            Throw ex
        End Try
    End Function

   

#End Region
End Class
