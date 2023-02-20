Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATCCO
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
    Public Function cdCrearActATCCO(ByVal wp_eATCCO As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim vl_sCodCco As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATCCO"
            wp_sNomCmp = "sCodCco"
            wp_sDatCmp = wp_eATCCO.sCodCco
            vl_sCodCco = wp_eATCCO.sCodCco
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATCCO
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATCCO "
                    wp_sCmdSql += "(sCodCco) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & vl_sCodCco & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATCCO "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomCco     = '" & .sNomCco & "', "
                wp_sCmdSql += "bRegAci     = " & .bRegAci
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodCco = '" & .sCodCco & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATCCO.cdCrearActATCCO ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATCCO(ByVal wp_eATCCO As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATCCO
                wp_sCmdSql = "Delete * from  ATCCO "
                wp_sCmdSql += "where sCodCco = '" & .sCodCco & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATCCO.cdEliATCCO")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
