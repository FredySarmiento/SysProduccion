Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATANA
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
    Public Function cdCrearActATANA(ByVal wp_eATANA As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try
            wp_sNomTbl = "ATANA"
            wp_sNomCmp = "sCodAna"
            wp_sDatCmp = wp_eATANA.sCodAna
            wp_sTipCmp = "S"
            wp_sCmpOrd = ""
            wp_sTipOrd = ""
            With wp_eATANA
                wl_bEOF1 = cddtConEOF(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sCmpOrd,
                                      wp_sTipOrd,
                                      wr_bEOF)
                If wl_bEOF1 = True Then
                    wp_sCmdSql = "Insert into ATANA "
                    wp_sCmdSql += "(sCodAna) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodAna & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update ATANA "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomAna     = '" & .sNomAna & "', "
                wp_sCmdSql += "sCodTipAna     = '" & .sCodTipAna & "', "
                wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                wp_sCmdSql += " where "
                wp_sCmdSql += "sCodAna     = '" & .sCodAna & "' "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldATANA.cdCrearActATANA ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATANA(ByVal wp_eATANA As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATANA
                wp_sCmdSql = "Delete * from  ATANA "
                wp_sCmdSql += "where sCodAna = '" & .sCodAna & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATANA.cdEliATANA")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
