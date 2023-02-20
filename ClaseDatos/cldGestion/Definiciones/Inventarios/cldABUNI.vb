Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldACUNI
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
    Public Function cdCrearActACUNI(ByVal wr_eACUNI As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim wl_sCodUni As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ACUNI"
            wp_sNomCmp = "sCodUni"
            wp_sDatCmp = wr_eACUNI.sCodUni
            wl_sCodUni = wr_eACUNI.sCodUni
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wr_eACUNI
                wl_sCodUni = .sCodUni
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)

                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ACUNI "
                    wp_sCmdSql += "(sCodUni) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & wl_sCodUni & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ACUNI "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomUni     = '" & .sNomUni & "', "
                wp_sCmdSql += "sCodUniBas     = '" & .sCodUniBas & "', "
                wp_sCmdSql += "nUniBas     = " & .nUniBas & " "
                wp_sCmdSql += "  where "
                wp_sCmdSql += "sCodUni = '" & wl_sCodUni & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldACUNI.cdCrearActACUNI ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliACUNI(ByVal wp_eACUNI As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eACUNI
                wp_sCmdSql = "Delete * from  ACUNI "
                wp_sCmdSql += "where sCodUni = '" & .sCodUni & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldACUNI.cdEliACUNI")
            Throw ex
        End Try
        Return wl_YesNo

    End Function

End Class


