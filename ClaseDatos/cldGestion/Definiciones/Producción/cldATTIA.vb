Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATTIA
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
    Public Function cdCrearActATTIA(ByVal wp_eATTIA As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATTIA"
            wp_sNomCmp = "sCodTipAna"
            wp_sDatCmp = wp_eATTIA.sCodTipAna
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATTIA
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATCIF "
                    wp_sCmdSql += "(sCodTipAna) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTipAna & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATCIF "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomTipAna     = '" & .sNomTipAna & "' "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodTipAna     = '" & .sCodTipAna & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATTIA.cdCrearActATTIA ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATTIA(ByVal wp_eATTIA As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATTIA
                wp_sCmdSql = "Delete * from  ATTIA "
                wp_sCmdSql += "where sCodTipAna = '" & .sCodTipAna & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATTIA.cdEliATTIA")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
