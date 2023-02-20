Public Class cldCEODC
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wp_sCmdSql As String
    Dim wl_bYesNo As Boolean
    Public Function cdActSdoCanLinCLODP1(ByVal wl_eILMOV1 As Object,
                                         ByVal wr_bEOFL1 As Boolean,
                                         ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_bYesNo = True
            With wl_eILMOV1
                wl_bYesNo = False
                wp_sCmdSql = "Update CLODC1 "
                wp_sCmdSql += " SET "
                If .sTipMov = "S" Then
                    'S - Salida de inventarios, aumenta el saldo
                    wp_sCmdSql += "nSdoCanLin     = nSdoCanLin + " & .nCanItm
                Else
                    'E - Entrada de inventarios, disminuye el saldo
                    wp_sCmdSql += "nSdoCanLin     = nSdoCanLin - " & .nCanItm
                End If
               
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += " and "
                wp_sCmdSql += "sCodItm     = '" & .sCodItm & "')"
                'wp_sCmdSql += ")"
                wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldCEODC.cdActSdoCanLinCLODP1")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function
    Public Function cddtCargarGEMOV(ByVal wp_sNomTbl As String,
                                    ByRef wr_bEOF As Boolean) As DataTable

        Try
            Dim wp_sCmdSql As String
            wp_sCmdSql = "select * from " & wp_sNomTbl
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldCEODC.cddtCargarGEMOV ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConGEMOV(ByVal wp_sNomTbl As String,
                                  ByVal wp_eGEMOV As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim wl_bIndAND As Boolean = False
            With wp_eGEMOV
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += wp_sNomTbl
                wp_sCmdSql += " T0 "
                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    wp_sCmdSql += " T0.sCodDoc = '" & .sCodDoc & "' "
                End If
                If .nNroDoc <> 0 Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wl_bIndAND = True
                    End If
                    If wl_bIndAND Then
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc
                End If
                wp_sCmdSql += " ORDER BY T0.sCodDoc, T0.sCodSer, T0.nNroDoc "

            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)

            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGEMOV")
            Return Nothing
            Throw ex
        End Try
    End Function
End Class
