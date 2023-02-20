Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldAPQDG
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand

    Public Function cdCrearActAPQDG(ByVal wr_eAPQDG As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eAPQDG
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into APQDG "
                    wp_sCmdSql += "(sCodStr, "
                    wp_sCmdSql += "nColOri) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodStr & "',"
                    wp_sCmdSql += .nColOri & ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update APQDG "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nNroCol     = " & .nNroCol & ","
                    wp_sCmdSql += "sTitCol     = '" & .sTitCol & "',"
                    wp_sCmdSql += "sTipCol     = '" & .sTipCol & "',"
                    wp_sCmdSql += "bColxDef     = " & .bColxDef & ","
                    wp_sCmdSql += "bVisible     = " & .bVisible & ","
                    wp_sCmdSql += "bReadOnly     = " & .bReadOnly & ","
                    wp_sCmdSql += "sNomCmp     = '" & .sNomCmp & "',"
                    wp_sCmdSql += "nTamCmp     = " & .nTamCmp
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodStr =        '" & .sCodStr & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "nColOri =        " & .nColOri
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldAPQDG.cdCrearActAPQDG")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConAPQDG(ByVal wr_eAPQDG As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try

            With wr_eAPQDG
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += "APQDG T0 "

                If .sCodStr <> "" Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "T0.sCodStr = '" & .sCodStr & "' "
                End If

                wp_sCmdSql += "ORDER BY T0.sCodStr, T0.nColOri"

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldAPQDG.cddtConAPQDGV")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdEliAPQDG(ByVal wr_eAPQDG As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wr_eAPQDG
                wp_sCmdSql = "Delete * from  APQDG "
                wp_sCmdSql += "where "
                wp_sCmdSql += "sCodStr = '" & .sCodStr & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nColOri = " & .nColOri
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With


        Catch ex As Exception
            MsgBox("Error : cldAPQDG.cdEliAPQDG")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
