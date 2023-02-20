Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATASI
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
    Public Function cddtConATASI(ByVal wp_eATASI As Object,
                                ByRef wr_bEOF As Boolean) As DataTable
        Try
            With wp_eATASI

                wp_sCmdSql = "SELECT * FROM ATASI T0 "
                If .nAnoSdoIni <> 0 Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "T0.nAnoSdoIni = " & .nAnoSdoIni

                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.sNomTblEnc = "
                    wp_sCmdSql += "'" & .sNomTblEnc & "'"
                    wp_sCmdSql += ")"
                End If
                wp_sCmdSql += " ORDER BY T0.nAnoSdoIni "

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                wr_bEOF = False
                Return wl_DT
            Else
                wr_bEOF = True
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldATASI.cddtConATASI")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActATASI(ByVal wp_eATASI As Object,
                                ByRef wr_bEOF As Boolean,
                                ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try

            With wp_eATASI
                wl_YesNo = True
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into ATASI "
                    wp_sCmdSql += "(nAnoSdoIni, "
                    wp_sCmdSql += "sNomTblEnc) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "(" & .nAnoSdoIni & ", "
                    wp_sCmdSql += "'" & .sNomTblEnc & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update ATASI "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomTblDet     = '" & .sNomTblDet & "', "
                    wp_sCmdSql += "sNomTblEncSdoIni     = '" & .sNomTblEncSdoIni & "', "
                    wp_sCmdSql += "sNomTblDetSdoIni     = '" & .sNomTblDetSdoIni & "', "
                    wp_sCmdSql += "dFecIniAno     = #" & .dFecFin & "#, "
                    wp_sCmdSql += "sEstPdo     = '" & .sEstPdo & "', "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "( "
                    wp_sCmdSql += "nAnoSdoIni = " & .nAnoSdoIni
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "sNomTblEnc = '" & .sNomTblEnc & "'"
                    wp_sCmdSql += ") "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: cldATASI.cdCrearActualizar ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATASI(ByVal wp_eATASI As Object,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATASI
                wp_sCmdSql = "Delete * from  ATASI "
                wp_sCmdSql += " where "
                wp_sCmdSql += "( "
                wp_sCmdSql += "nAnoSdoIni = " & .nAnoSdoIni
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sNomTblEnc = '" & .sNomTblEnc & "'"
                wp_sCmdSql += ") "
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATASI.cdEliATASI")
            Throw ex
        End Try
        Return wl_YesNo
    End Function

End Class
