Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldATAUT
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wp_sCmdSql As String
    Dim wl_YesNo As Boolean


    Public Function cddtConATAUT(ByVal vp_sCodUsr As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += "("
            wp_sCmdSql += "ATAUT T0 "
            wp_sCmdSql += "INNER JOIN ABAUT T1 "
            wp_sCmdSql += "ON T0.sCodAut = T1.sCodAut) "
            wp_sCmdSql += "INNER JOIN ABOPC T2 "
            wp_sCmdSql += "ON T0.sCodFrm = T2.sCodFrm "
            wp_sCmdSql += "WHERE (T0.sCodUsr = '" & vp_sCodUsr & "')"
            wp_sCmdSql += " ORDER BY T0.sCodUsr, T0.sCodFrm "

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: cldATAUT.cddtConATAUT")
            Return Nothing
            Throw ex
        End Try



    End Function
    Public Function cdCrearActATAUT(ByVal wp_eATAUT As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean

        wl_YesNo = True
        Try
            With wp_eATAUT
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into ATAUT "
                    wp_sCmdSql += "(sCodUsr, "
                    wp_sCmdSql += "sCodFrm, "
                    wp_sCmdSql += "sCodAut "
                    wp_sCmdSql += " ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodUsr & "',"
                    wp_sCmdSql += "'" & .sCodFrm & "',"
                    wp_sCmdSql += "'" & .sCodAut & "'"
                    wp_sCmdSql += " )"
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update ATAUT T0 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "T0.sCodAut     = '" & .sCodAut & "' "
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "T0.sCodUsr =        '" & .sCodUsr & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.sCodfrm =        '" & .sCodFrm
                    wp_sCmdSql += "')"
                End If
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error: cldATUSR.cdCrearActATAUT")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class
