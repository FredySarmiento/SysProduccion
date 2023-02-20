Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldPERCI
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand
    Public Function cdActPLODP3(ByVal wp_ePLRCI1 As Object) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLRCI1
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP3 T0"
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nTieCns     = T0.nTieCns" & " + " & .nTieCns
                wp_sCmdSql += "  where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodDoc =        '" & .sCodDocBas & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nNroDoc =        " & .nNroDocBas
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodOpe =        '" & .sCodOpe & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldPERCI.cdActPLODP3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConsultar(ByVal vp_sCodDoc,
                                  ByVal vp_nNroDoc,
                                  ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "select * from PERCI "
            wp_sCmdSql += " where "
            wp_sCmdSql += "sCodDoc = '" & vp_sCodDoc & "' and "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_DT = cdfdtConsultar(wp_sCmdSql,
                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: cldPERCI.cddtConsultar ")
            Throw ex
        End Try

        Return wl_DT
    End Function
    Public Function cddtConsultarPLRCI1(ByVal wp_sNomTbl As String,
                                        ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Double,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_nCntReg As Integer

            wp_sCmdSql = "select *"
            wp_sCmdSql += " from "
            wp_sCmdSql += "("
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            If vp_sCodDoc IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN PERCI T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc"
                wp_sCmdSql += " and "
                wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc"
                wp_sCmdSql += ")"
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += " T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += " T0.nNroDoc = " & vp_nNroDoc
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntReg = wl_DT.Rows.Count

        Catch ex As Exception
            MsgBox("Error: cldPERCI.cddtConsultarPLRCI1 ")
            Throw ex
        End Try
        Return wl_DT
    End Function
    Public Function cdCrearAct(ByVal wp_ePERCI As Object,
                               ByRef wr_bEOF As Boolean,
                               ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            Dim vl_sFecCtb As String
            Dim vl_sFecDoc As String
            Dim vl_sFecSys As String
            Dim vl_sFecVto As String
            With wp_ePERCI
                vl_sFecCtb = cdf_dDMY_MDY(.dFecCtb)
                vl_sFecDoc = cdf_dDMY_MDY(.dFecDoc)
                vl_sFecSys = cdf_dDMY_MDY(.dFecSys)
                vl_sFecVto = cdf_dDMY_MDY(.dFecVto)

                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PERCI "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc, "
                    wp_sCmdSql += "nNrodoc "
                    wp_sCmdSql += ") "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "',"
                    wp_sCmdSql += .nNroDoc & ")"
                    'wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PERCI "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "', "
                    wp_sCmdSql += "sTipMov     = '" & .sTipMov & "', "
                    wp_sCmdSql += "sEstDoc     = '" & .sEstDoc & "', "
                    wp_sCmdSql += "dFecCtb     = #" & vl_sFecCtb & "#, "
                    wp_sCmdSql += "dFecDoc     = #" & vl_sFecDoc & "#, "
                    wp_sCmdSql += "dFecVto     = #" & vl_sFecVto & "#, "
                    wp_sCmdSql += "dFecSys     = #" & vl_sFecSys & "#, "
                    wp_sCmdSql += "sCodTer     = '" & .sCodTer & "', "
                    wp_sCmdSql += "sNomTer     = '" & .sNomTer & "', "
                    wp_sCmdSql += "sDocRef     = '" & .sDocRef & "', "
                    wp_sCmdSql += "nTotHHCIF   = " & .nTotHHCIF & ", "
                    wp_sCmdSql += "nTotMMCIF   = " & .nTotMMCIF & ", "
                    wp_sCmdSql += "nTotTieCIF  = " & .nTotTieCIF & ", "
                    wp_sCmdSql += "nTotDoc     = " & .nTotDoc & ", "
                    wp_sCmdSql += "sCodCte     = '" & .sCodCte & "', "
                    wp_sCmdSql += "nNroCte     = " & .nNroCte & ", "
                    wp_sCmdSql += "sClsDoc     = '" & .sClsDoc & "', "
                    wp_sCmdSql += "sCmn        = '" & .sCmn & "', "
                    wp_sCmdSql += "sCodCteCtb  = '" & .sCodCteCtb & "', "
                    wp_sCmdSql += "nNroCteCtb  = " & .nNroCteCtb & ", "
                    wp_sCmdSql += "nIdFECCT    = " & .nIdFECCT & ", "
                    wp_sCmdSql += "sNitTer     = '" & .sNitTer & "', "
                    wp_sCmdSql += "sTipDoc     = '" & .sTipDoc & "', "
                    wp_sCmdSql += "sCodUsr     = '" & .sCodUsr & "' "
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "nNroDoc =        " & .nNroDoc
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : cldPERCI.cdCrearAct")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActPLRCI1(ByVal wl_ePLRCI1 As Object,
                                     ByVal wr_bEOFL1 As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wl_ePLRCI1
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLRCI1 "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sTipMov, "
                    wp_sCmdSql += "sCodDocBas,  "
                    wp_sCmdSql += "nNroDocBas,  "
                    wp_sCmdSql += "sCodItm,  "
                    wp_sCmdSql += "nCanItm,  "
                    wp_sCmdSql += "sCodCIF,  "
                    wp_sCmdSql += "sNomCIF,  "
                    wp_sCmdSql += "nHHCns,  "
                    wp_sCmdSql += "nMMCns,  "
                    wp_sCmdSql += "nTieCns,  "
                    wp_sCmdSql += "nPreUni,  "
                    wp_sCmdSql += "nTotLin,  "
                    wp_sCmdSql += "sCodCco,  "
                    wp_sCmdSql += "nLinBas,  "
                    wp_sCmdSql += "sCodPdo,  "
                    wp_sCmdSql += "sCodCta,  "
                    wp_sCmdSql += "sCtaCosVta,  "
                    wp_sCmdSql += "bItmBlq,  "
                    wp_sCmdSql += "sClsDoc,  "
                    wp_sCmdSql += "nCanOpeTer,  "
                    wp_sCmdSql += "sCodCtr "
                    wp_sCmdSql += ") "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "', "
                    wp_sCmdSql += .nNroDoc & " , "
                    wp_sCmdSql += "'" & .sCodSer & "', "
                    wp_sCmdSql += "'" & .sTipMov & "', "
                    wp_sCmdSql += "'" & .sCodDocBas & "', "
                    wp_sCmdSql += .nNroDocBas & ", "
                    wp_sCmdSql += "'" & .sCodItm & "', "
                    wp_sCmdSql += .nCanItm & ", "
                    wp_sCmdSql += "'" & .sCodCIF & "', "
                    wp_sCmdSql += "'" & .sNomCIF & "', "
                    wp_sCmdSql += .nHHCns & ", "
                    wp_sCmdSql += .nMMCns & ", "
                    wp_sCmdSql += .nTieCns & ", "
                    wp_sCmdSql += .nPreUni & ", "
                    wp_sCmdSql += .nTotLin & ", "
                    wp_sCmdSql += "'" & .sCodCco & "', "
                    wp_sCmdSql += .nLinBas & ", "
                    wp_sCmdSql += "'" & .sCodPdo & "', "
                    wp_sCmdSql += "'" & .sCodCta & "', "
                    wp_sCmdSql += "'" & .sCtaCosVta & "', "
                    wp_sCmdSql += .bItmBlq & ", "
                    wp_sCmdSql += "'" & .sClsDoc & "', "
                    wp_sCmdSql += "'" & .nCanOpeTer & "', "
                    wp_sCmdSql += "'" & .sCodCtr & "' "
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    'If wp_sCmdSel = "A" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLRCI1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sTipMov     = '" & .sTipMov & "', "
                    wp_sCmdSql += "sCodDocBas  = '" & .sCodDocBas & "', "
                    wp_sCmdSql += "nNroDocBas  = " & .nNroDocBas & " ,"
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "', "
                    wp_sCmdSql += "nCanItm     = " & .nCanItm & " ,"
                    wp_sCmdSql += "sCodCIF     = '" & .sCodCIF & "', "
                    wp_sCmdSql += "sNomCIF     = '" & .sNomCIF & "', "
                    wp_sCmdSql += "nHHCns      = " & .nHHCns & ", "
                    wp_sCmdSql += "nMMCns      = " & .nMMCns & ", "
                    wp_sCmdSql += "nTieCns     = " & .nTieCns & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nTotLin     = " & .nTotLin & ", "
                    wp_sCmdSql += "sCodCco     = '" & .sCodCco & "', "
                    wp_sCmdSql += "nLinBas     = " & .nLinBas & ", "
                    wp_sCmdSql += "sCodPdo     = '" & .sCodPdo & "', "
                    wp_sCmdSql += "sCodCta     = '" & .sCodCta & "', "
                    wp_sCmdSql += "sCtaCosVta  = '" & .sCtaCosVta & "', "
                    wp_sCmdSql += "bItmBlq     = " & .bItmBlq & ","
                    wp_sCmdSql += "sClsDoc     = '" & .sClsDoc & "', "
                    wp_sCmdSql += "nCanOpeTer     = " & .nCanOpeTer & ", "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "' "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "nId         = " & .nId
                    ' wp_sCmdSql += "nId         = 6"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With

        Catch ex As Exception
            MsgBox("Error : cldPERCI.cdCrearActPLRCI1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliminar(ByVal wp_sNomTblE1 As String,
                               ByVal wp_sNomTblL1 As String,
                               ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  "
            wp_sCmdSql += wp_sNomTblL1
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += "and nNrodoc = '" & vp_nNroDoc & "'"

            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from "
            wp_sCmdSql += wp_sNomTblE1
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += "AND  sNroDoc = '" & vp_nNroDoc & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error: cldPERCI.cdEliminar ")
            '  MsgBox("Error: cldIEINV.cdEliminar ")
            Throw ex

        End Try
        Return wl_YesNo
    End Function

End Class
