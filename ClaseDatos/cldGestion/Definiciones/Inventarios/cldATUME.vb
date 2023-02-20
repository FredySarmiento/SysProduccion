Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATUME
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
    Public Function cdCrearActualizar(ByVal wr_eATUME As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Dim wl_sUniMed As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATUME"
            wp_sNomCmp = "sUniMed"
            wp_sDatCmp = wr_eATUME.sUnimed
            wl_sUniMed = wr_eATUME.sUnimed
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wr_eATUME
                wl_sUniMed = .sUnimed
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)

                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATUME "
                    wp_sCmdSql += "(sUniMed) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & wl_sUniMed & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATUME "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomMed     = '" & .sNomMed & "', "
                wp_sCmdSql += "sCodVol     = '" & .sCodVol & "', "
                wp_sCmdSql += "nVlrUme     = " & .nVlrUme & " "
                wp_sCmdSql += "  where "
                wp_sCmdSql += "sUniMed = '" & .sUnimed & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATUME.cdCrearActualizar ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class


