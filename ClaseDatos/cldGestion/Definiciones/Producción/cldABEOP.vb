Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldABEOP
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
    Public Function cdCrearActABEOP(ByVal wp_eABEOP As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ABEOP"
            wp_sNomCmp = "sCodEstODP"
            wp_sDatCmp = wp_eABEOP.sCodEstODP
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eABEOP
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ABEOP "
                    wp_sCmdSql += "(sCodEstODP) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodEstODP & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ABEOP "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomEstODP     = '" & .sNomEstODP & "', "
                wp_sCmdSql += "nNroOrd     = " & .nNroOrd & ", "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodEstODP     = '" & .sCodEstODP & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldABEOP.cdCrearActABEOP ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliABEOP(ByVal wp_eABEOP As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eABEOP
                wp_sCmdSql = "Delete * from  ABEOP "
                wp_sCmdSql += "where sCodEstODP = '" & .sCodEstODP & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldABEOP.cdEliABEOP")
            Throw ex
        End Try
        Return wl_YesNo

    End Function

End Class
