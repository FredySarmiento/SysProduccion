Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATPCO
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
    Public Function cddtConATPCO(ByVal wp_eATPCO As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            With wp_eATPCO

                wp_sCmdSql = "SELECT * FROM ATPCO T0 "
                If .sCodPdo <> "" Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "T0.sCodPdo = "
                    wp_sCmdSql += "'" & .sCodPdo & "'"
                End If
                wp_sCmdSql += " ORDER BY T0.sCodPdo "

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldATPCO.cddtConATPCO")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActATPCO(ByVal wp_eATPCO As Object,
                                   ByRef wr_bEOF As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try

            With wp_eATPCO
                wl_YesNo = True
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into ATPCO "
                    wp_sCmdSql += "(sCodPdo) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodPdo & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update ATPCO "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomPdo     = '" & .sNomPdo & "', "
                    wp_sCmdSql += "sEstPdo     = '" & .sEstPdo & "', "
                    wp_sCmdSql += "dFecIni     = #" & .dFecIni & "#, "
                    wp_sCmdSql += "dFecFin     = #" & .dFecFin & "#, "
                    wp_sCmdSql += "sCodAno     = '" & .sCodAno & "', "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "sCodPdo = '" & .sCodPdo & "' "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: cldATPCO.cdCrearActualizar ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATPCO(ByVal wp_eATPCO As Object,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATPCO
                wp_sCmdSql = "Delete * from  ATPCO "
                wp_sCmdSql += "where sCodPco = '" & .sCodPco & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATPCO.cdEliATPCO")
            Throw ex
        End Try
        Return wl_YesNo
    End Function

End Class
