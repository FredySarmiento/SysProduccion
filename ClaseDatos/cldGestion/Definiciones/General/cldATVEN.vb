Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATVEN
    Inherits cldConTbl

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim wp_sNomTbl As String
    Dim wp_sNomCmp As String
    Dim wp_sDatCmp As String
    Dim wp_sTipCmp As String
    Dim wp_sCmpOrd As String
    Dim wp_sTipOrd As String
    Public Function cdCrearActATVEN(ByVal wp_eATVEN As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim vl_sCodVen As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATVEN"
            wp_sNomCmp = "sCodVen"
            wp_sDatCmp = wp_eATVEN.sCodVen
            vl_sCodVen = wp_eATVEN.sCodVen
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATVEN
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATVEN "
                    wp_sCmdSql += "(sCodVen) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & vl_sCodVen & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATVEN "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomVen     = '" & .sNomVen & "', "
                wp_sCmdSql += "sCodZon     = '" & .sCodZon & "', "
                wp_sCmdSql += "sTipVen     = '" & .sTipVen & "', "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodVen = '" & .sCodVen & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATVEN.cdCrearActATVEN ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATVEN(ByVal wp_eATVEN As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATVEN
                wp_sCmdSql = "Delete * from  ATVEN "
                wp_sCmdSql += "where sCodVen = '" & .sCodVen & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATVEN.cdEliATVEN")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
