Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATOPE
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
    Public Function cdCrearActATOPE(ByVal wp_eATOPE As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim vl_sCodOpe As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATOPE"
            wp_sNomCmp = "sCodOpe"
            wp_sDatCmp = wp_eATOPE.sCodOpe
            vl_sCodOpe = wp_eATOPE.sCodOpe
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATOPE
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATOPE "
                    wp_sCmdSql += "(sCodOpe) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & vl_sCodOpe & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATOPE "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomOpe     = '" & .sNomOpe & "', "
                wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "', "
                wp_sCmdSql += "nTieOpe     = " & .nTieOpe & ", "
                wp_sCmdSql += "nUniTieOpe  = " & .nUniTieOpe & ", "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodOpe = '" & .sCodOpe & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATOPE.cdCrearActATOPE ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATOPE(ByVal wp_eATOPE As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATOPE
                wp_sCmdSql = "Delete * from  ATOPE "
                wp_sCmdSql += "where sCodOpe = '" & .sCodOpe & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATOPE.cdEliATOPE")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
