Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldAPEND
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand

    Public Function cdCrearActualizar(ByVal wr_eAPEND As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eAPEND
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into APEND "
                    wp_sCmdSql += "(sCodDoc, "
                    wp_sCmdSql += "sCodSer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodDoc & "',"
                    wp_sCmdSql += "'" & .sCodSer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update APEND "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nNroIni     = " & .nNroIni & ","
                    wp_sCmdSql += "nNroSig     = " & .nNroSig & ","
                    wp_sCmdSql += "nNroFin     = " & .nNroFin
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "sCodSer =        '" & .sCodSer & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldAPEND.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConAPEND(ByVal wr_eAPEND As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try

            With wr_eAPEND
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += "APEND T0"
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodDoc = '" & .sCodDoc & "'"
                If .sCodSer <> "" Then
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.sCodSer = '" & .sCodSer & "'"
                End If
            End With

            wp_sCmdSql += " ORDER BY T0.sCodDoc,T0.sCodSer"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldAPEND.cddtConAPEND")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdEliminar(ByVal wr_eAPEND As Object,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wr_eAPEND
                wp_sCmdSql = "Delete * from  APEND "
                wp_sCmdSql += "where "
                wp_sCmdSql += "sCodDoc = '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodDoc = '" & .sCodSer & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With


        Catch ex As Exception
            MsgBox("Error : cldAPEND.cdEliminar")
            Throw ex
        End Try
        Return wl_YesNo

    End Function


End Class
