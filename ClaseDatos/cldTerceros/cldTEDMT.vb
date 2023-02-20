Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion




Public Class cldTEDMT
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand

    Public Function cdCrearActualizar(ByVal wr_eTEDMT As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eTEDMT
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into TEDMT "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update TEDMT "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomTer     = """ & .sNomTer & """, " '2
                    wp_sCmdSql += "sTipTer     = '" & .sTipTer & "', " '3
                    wp_sCmdSql += "sNitTer     = '" & .sNitTer & "', " '4
                    wp_sCmdSql += "sDigVer     = '" & .sDigVer & "', " '5
                    wp_sCmdSql += "sDirTer     = '" & .sDirTer & "', " '6
                    wp_sCmdSql += "sTel1Ter    = '" & .sTel1Ter & "', " '7
                    wp_sCmdSql += "sTel2Ter    = '" & .sTel2Ter & "', " '8
                    wp_sCmdSql += "sTelCll     = '" & .sTelCll & "', " '9
                    wp_sCmdSql += "sFax        = '" & .sFax & "', " '10
                    wp_sCmdSql += "sNomAlt     = '" & .sNomAlt & "', " '11
                    wp_sCmdSql += "sCodGrpTer  = '" & .sCodGrpTer & "', " '12
                    wp_sCmdSql += "sEmlTer     = '" & .sEmlTer & "', " '13 
                    wp_sCmdSql += "sNomCtc     = '" & .sNomCtc & "'," '14 
                    wp_sCmdSql += "sTipCtaCtb  = '" & .sTipCtaCtb & "'," '15
                    wp_sCmdSql += "sCodCtaCtb  = '" & .sCodCtaCtb & "'," '16 
                    wp_sCmdSql += "sCndPag     = '" & .sCndPag & "'," '17
                    wp_sCmdSql += "sCodLstPre  = '" & .sCodLstPre & "'," '18
                    wp_sCmdSql += "nPorDto     = " & .nPorDto & " ," '19
                    wp_sCmdSql += "nLmtCre     = " & .nLmtCre & " ," '20
                    wp_sCmdSql += "bAct        = " & .bAct & "," '21
                    wp_sCmdSql += "bIna        = " & .bIna & "," '22
                    wp_sCmdSql += "sCmn        = '" & .sCmn & "' " '23
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldTEDMT.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarTLDMT1(ByVal wr_eTLDMT1 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eTLDMT1
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into TLDMT1 "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update TLDMT1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sDirTer     = '" & .sDirTer & "', " '1
                    wp_sCmdSql += "sCiuTer     = '" & .sCiuTer & "', " '2
                    wp_sCmdSql += "sDepTer     = '" & .sDepTer & "', " '3
                    wp_sCmdSql += "sPaiTer     = '" & .sPaiTer & "', " '4
                    wp_sCmdSql += "bDirDfl     =  " & .bDirDfl  '5
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldTEDMT.cdCrearActualizarTLDMT1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarTLDMT2(ByVal wr_eTLDMT2 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eTLDMT2
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into TLDMT2 "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update TLDMT2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodRet     = '" & .sCodRet & "', " '2
                    wp_sCmdSql += "bAct     =  " & .bAct  '3
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldTEDMT.cdCrearActualizarTLDMT2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarTLDMT3(ByVal wr_eTLDMT3 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eTLDMT3
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into TLDMT3 "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update TLDMT3 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodIVA     = '" & .sCodIVA & "', " '2
                    wp_sCmdSql += "bAct     =  " & .bAct  '3
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldTEDMT.cdCrearActualizarTLDMT3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarTLDMT4(ByVal wr_eTLDMT4 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eTLDMT4
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into TLDMT4 "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update TLDMT4 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sMMTipDoc     = '" & .sMMTipDoc & "', " '2
                    wp_sCmdSql += "sMMNomTer     = '" & .sMMNomTer & "', " '3
                    wp_sCmdSql += "sMMPriNom     = '" & .sMMPriNom & "', " '4
                    wp_sCmdSql += "sMMSegNom     = '" & .sMMSegNom & "', " '5
                    wp_sCmdSql += "sMMPriApe     = '" & .sMMPriApe & "', " '6
                    wp_sCmdSql += "sMMSegApe     = '" & .sMMSegApe & "', " '7
                    wp_sCmdSql += "sMMDirTer     = '" & .sMMDirTer & "', " '8
                    wp_sCmdSql += "sMMCodDep     = '" & .sMMCodDep & "', " '9
                    wp_sCmdSql += "sMMCodCiu     = '" & .sMMCodCiu & "', " '10
                    wp_sCmdSql += "sMMCodPai     = '" & .sMMCodPai & "', " '11
                    wp_sCmdSql += "dMMFecRUT     =  #" & .dMMFecRUT & "# ," '12
                    wp_sCmdSql += "sMMCodAcvPpl  = '" & .sMMCodAcvPpl & "', " '13
                    wp_sCmdSql += "sMMCodAcvAlt  = '" & .sMMCodAcvAlt & "' " '14
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldTEDMT.cdCrearActualizarTLDMT4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConTEDMT(ByVal wp_sNomTbl As String,
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
            MsgBox("Error : cldConTbl.cddtConTEDMT_ILDMI2")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdEliminar(ByVal vp_sCodTer As String,
                                   ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  TLDMT4 "
            wp_sCmdSql += "where sCodTer = '" & vp_sCodTer & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  TLDMT3 "
            wp_sCmdSql += "where sCodTer = '" & vp_sCodTer & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  TLDMT2 "
            wp_sCmdSql += "where sCodTer = '" & vp_sCodTer & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  TLDMT1 "
            wp_sCmdSql += "where sCodTer = '" & vp_sCodTer & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


            wp_sCmdSql = "Delete * from  TEDMT "
            wp_sCmdSql += "where sCodTer = '" & vp_sCodTer & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldTEDMT.cdEliminar")
            Throw ex

        End Try
        Return wl_YesNo

    End Function
End Class
