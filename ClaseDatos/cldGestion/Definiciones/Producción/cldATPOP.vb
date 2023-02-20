Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATPOP
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand

    Public Function cdCrearActATPOP(ByVal wp_eATPOP As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_eATPOP
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into ATPOP "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update ATPOP "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomTer     = """ & .sNomTer & """ "
                    wp_sCmdSql += " ,"
                    wp_sCmdSql += "bRegAci     = " & .bRegAci & " "
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldATPOP.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConATPOP(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try

            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0"
            If wp_sDatCmp <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0." & wp_sNomCmp
                wp_sCmdSql += " = '" & wp_sDatCmp & "'"
            End If
            wp_sCmdSql += " ORDER BY T0.sCodTer"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldATPOP.cddtConATPOP")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdEliATPOP(ByVal wp_eATPOP As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATPOP
                wp_sCmdSql = "Delete * from  HEDMT "
                wp_sCmdSql += "where sCodTer = '" & .sCodTer & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldATPOP.cdEliminar")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
