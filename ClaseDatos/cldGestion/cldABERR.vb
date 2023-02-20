Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldABERR
    Inherits cldFunciones
    Dim wl_DT As New DataTable

    Dim wp_sCmdSql As String
    Public Function cddtConsultar(ByVal vp_sCodErr,
                                 ByRef wr_bEOF) As DataTable

        Try
            wp_sCmdSql = "select * from ABERR "
            wp_sCmdSql += " where sCodErr = '" & vp_sCodErr & "'"
            wl_DT = cdfdtConsultar(wp_sCmdSql,
                                   wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldABERR.cddtConsultar")
            Return Nothing
            Throw ex

        End Try



    End Function
End Class
