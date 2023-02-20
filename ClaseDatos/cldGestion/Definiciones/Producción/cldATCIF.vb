Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATCIF
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
    Public Function cdCrearActATCIF(ByVal wp_eATCIF As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim vl_sCodCIF As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATCIF"
            wp_sNomCmp = "sCodCIF"
            wp_sDatCmp = wp_eATCIF.sCodCIF
            vl_sCodCIF = wp_eATCIF.sCodCIF
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATCIF
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATCIF "
                    wp_sCmdSql += "(sCodCIF) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & vl_sCodCIF & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATCIF "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomCIF     = '" & .sNomCIF & "', "
                wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "', "
                wp_sCmdSql += "nTasCIF     = " & .nTasCIF & ", "
                wp_sCmdSql += "nVlrCIF     = " & .nVlrCIF & ", "
                wp_sCmdSql += "nVlrCIFPpo  = " & .nVlrCIFPpo & ", "
                wp_sCmdSql += "nBasCIFPpo  = " & .nBasCIFPpo & ", "
                wp_sCmdSql += "nVlrCIFRea  = " & .nVlrCIFRea & ", "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodCIF     = '" & .sCodCIF & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATCIF.cdCrearActATCIF ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATCIF(ByVal wp_eATCIF As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATCIF
                wp_sCmdSql = "Delete * from  ATCIF "
                wp_sCmdSql += "where sCodCIF = '" & .sCodCIF & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATOPE.cdEliATCIF")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
