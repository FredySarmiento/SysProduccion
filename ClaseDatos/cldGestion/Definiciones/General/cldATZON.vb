Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATZON
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
    Public Function cdCrearActATZON(ByVal wp_eATZON As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim vl_sCodZon As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATZON"
            wp_sNomCmp = "sCodZon"
            wp_sDatCmp = wp_eATZON.sCodZon
            vl_sCodZon = wp_eATZON.sCodZon
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATZON
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATZON "
                    wp_sCmdSql += "(sCodZon) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & vl_sCodZon & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATZON "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomZon     = '" & .sNomZon & "', "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodZon = '" & .sCodZon & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATZON.cdCrearActATZON ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATZON(ByVal wp_eATZON As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATZON
                wp_sCmdSql = "Delete * from  ATZON "
                wp_sCmdSql += "where sCodZon = '" & .sCodZon & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATZON.cdEliATZON")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
