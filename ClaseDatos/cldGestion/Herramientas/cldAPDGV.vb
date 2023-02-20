Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldAPDGV
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand

    Public Function cdCrearActualizar(ByVal wr_eAPDGV As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eAPDGV
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into APDGV "
                    wp_sCmdSql += "(sCodFrm, "
                    wp_sCmdSql += "sCodDgv,"
                    wp_sCmdSql += "nColOri) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodFrm & "',"
                    wp_sCmdSql += "'" & .sCodDgv & "',"
                    wp_sCmdSql += .nColOri & ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update APDGV "
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
                    wp_sCmdSql += "sCodFrm =        '" & .sCodFrm & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "sCodDgv =        '" & .sCodDgv & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "nColOri =        " & .nColOri
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldAPDGV.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConAPDGV(ByVal wr_eAPDGV As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try

            With wr_eAPDGV
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += "APDGV T0 "

                If .sCodFrm <> "" Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "T0.sCodFrm = '" & .sCodFrm & "' "
                End If

                wp_sCmdSql += "ORDER BY T0.sCodFrm, T0.sCodDgv, T0.nColOri"

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldAPDGV.cddtConAPDGV")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdEliminar(ByVal wr_eAPDGV As Object,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wr_eAPDGV
                wp_sCmdSql = "Delete * from  APDGV "
                wp_sCmdSql += "where "
                wp_sCmdSql += "sCodDoc = '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodDoc = '" & .sCodSer & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With


        Catch ex As Exception
            MsgBox("Error : cldAPDGV.cdEliminar")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
