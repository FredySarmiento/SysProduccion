Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATCLI
    Inherits cldFunciones
    Public Function cddtConsultarCboBox(ByRef vp_bEOF) As DataTable
        Dim vl_DT As New DataTable


        Try
            Dim vp_sCmdSql As String
            Dim vl_swhere As String = ""
            vp_sCmdSql = "select * from ATCLI"
            vl_DT = cdfdtConsultar(vp_sCmdSql, vp_bEOF)
        Catch ex As Exception
            Throw ex
        End Try

        If vl_DT IsNot Nothing Then
            Return vl_DT
        Else
            Return Nothing
        End If

    End Function




End Class
