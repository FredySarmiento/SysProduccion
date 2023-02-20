Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATCTR
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
    Public Function cdCrearActATCTR(ByVal wp_eATCTR As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim vl_sCodCTR As String
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATCTR"
            wp_sNomCmp = "sCodCtr"
            wp_sDatCmp = wp_eATCTR.sCodCtr
            vl_sCodCTR = wp_eATCTR.sCodCtr
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATCTR
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATCTR "
                    wp_sCmdSql += "(sCodCTR) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & vl_sCodCTR & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATCTR "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomCtr     = '" & .sNomCtr & "', "
                wp_sCmdSql += "sCodCco     = '" & .sCodCco & "', "
                wp_sCmdSql += "nCosMODFij  = " & .nCosMODFij & ", "
                wp_sCmdSql += "nCosMODVar  = " & .nCosMODVar & ", "
                wp_sCmdSql += "nCosHorCpr  = " & .nCosHorCpr & ", "
                wp_sCmdSql += "nScoVar     = " & .nScoVar & ", "
                wp_sCmdSql += "nCosHorVar  = " & .nCosHorVar & ", "
                wp_sCmdSql += "nCosTotMOD  = " & .nCosTotMOD & ", "
                wp_sCmdSql += "nUniTieOpe  = " & .nUniTieOpe & ", "
                wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATCTR.cdCrearActATCTR ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATCTR(ByVal wp_eATCTR As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATCTR
                wp_sCmdSql = "Delete * from  ATCTR "
                wp_sCmdSql += "where sCodCtr = '" & .sCodCtr & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATCTR.cdEliATCTR")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
