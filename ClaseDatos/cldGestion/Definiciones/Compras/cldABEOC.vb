Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldABEOC
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
    Public Function cdCrearActABEOC(ByVal wp_eABEOC As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ABEOC"
            wp_sNomCmp = "sCodEstODC"
            wp_sDatCmp = wp_eABEOC.sCodEstODC
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eABEOC
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ABEOC "
                    wp_sCmdSql += "(sCodEstODC) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodEstODC & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ABEOC "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomEstODC     = '" & .sNomEstODC & "', "
                wp_sCmdSql += "nNroOrd     = " & .nNroOrd & ", "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodEstODC     = '" & .sCodEstODC & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldABEOC.cdCrearActABEOC ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliABEOC(ByVal wp_eABEOC As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eABEOC
                wp_sCmdSql = "Delete * from  ABEOC "
                wp_sCmdSql += "where sCodEstODC = '" & .sCodEstODC & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldABEOC.cdEliABEOC")
            Throw ex
        End Try
        Return wl_YesNo

    End Function

End Class
