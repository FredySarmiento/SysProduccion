Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion


Public Class cldIEDMI
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_bYesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand
#Region "C - Crear"
    Public Function cdCrearActualizar(ByVal wr_eIEDMI As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_bYesNo = True
            With wr_eIEDMI
                If wp_sCmdSel = "C" Then
                    wl_bYesNo = False
                    wp_sCmdSql = "Insert into IEDMI "
                    wp_sCmdSql += "(sCodItm) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "')"
                    wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_bYesNo Then
                    wl_bYesNo = False
                    wp_sCmdSql = "Update IEDMI "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodBar     = '" & .sCodBar & "', "
                    wp_sCmdSql += "sNomItm     = """ & .sNomItm & """, "
                    wp_sCmdSql += "sNomAlt     = """ & .sNomAlt & """, "
                    wp_sCmdSql += "sClsItm     = '" & .sClsItm & "', "
                    wp_sCmdSql += "sCodGrp     = '" & .sCodGrp & "', "
                    wp_sCmdSql += "sCodSgr     = '" & .sCodSgr & "', "
                    wp_sCmdSql += "bItmInv     =  " & .bItmInv & " , "
                    wp_sCmdSql += "bItmVta     =  " & .bItmVta & " , "
                    wp_sCmdSql += "bItmCom     =  " & .bItmCom & " , "
                    wp_sCmdSql += "bIndIVA     =  " & .bIndIVA & " , "
                    wp_sCmdSql += "sCodAlt     = '" & .sCodAlt & "', "
                    wp_sCmdSql += "sTipGes     = '" & .sTipGes & "', "
                    wp_sCmdSql += "bItmAct     =  " & .bItmAct & " , "
                    wp_sCmdSql += "bItmIna     =  " & .bItmIna & " , "
                    wp_sCmdSql += "sCodTerPrv  = '" & .sCodTerPrv & "', "
                    wp_sCmdSql += "sCodTerFte  = '" & .sCodTerFte & "',"
                    wp_sCmdSql += "sCodItmFte  = '" & .sCodItmFte & "',"
                    wp_sCmdSql += "sUniMedCom  = '" & .sUniMedCom & "',"
                    wp_sCmdSql += "nCanUniCom  =  " & .nCanUniCom & ","
                    wp_sCmdSql += "sUniEmpCom  = '" & .sUniEmpCom & "',"
                    wp_sCmdSql += "nCanUniECom =  " & .nCanUniECom & " ,"
                    wp_sCmdSql += "sCodItoCom  = '" & .sCodItoCom & "'," '23
                    wp_sCmdSql += "sUniMedVta  = '" & .sUniMedVta & "',"
                    wp_sCmdSql += "nCanUniVta  =  " & .nCanUniVta & " ,"
                    wp_sCmdSql += "sUniEmpVta  = '" & .sUniEmpVta & "',"
                    wp_sCmdSql += "nCanUniEVta  = " & .nCanUniEVta & " ,"
                    wp_sCmdSql += "sCodItoVta  = '" & .sCodItoVta & "',"
                    wp_sCmdSql += "sCriCtaCbe  = '" & .sCriCtaCbe & "',"
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "',"
                    wp_sCmdSql += "sMetVlz     = '" & .sMetVlz & "',"
                    wp_sCmdSql += "nCosItm     =  " & .nCosItm & ","
                    wp_sCmdSql += "sCodAlm     = '" & .sCodAlm & "',"
                    wp_sCmdSql += "nSdoInv     =  " & .nSdoInv & ","
                    wp_sCmdSql += "sIvaCom     = '" & .sIvaCom & "',"
                    wp_sCmdSql += "sIvaVta     = '" & .sIvaVta & "',"
                    wp_sCmdSql += "sCodCco     = '" & .sCodCco & "', "
                    wp_sCmdSql += "sUbiAlm     = '" & .sUbiAlm & "', "
                    wp_sCmdSql += "bIndCan     =  " & .bIndCan & " , "
                    wp_sCmdSql += "bIndCos     =  " & .bIndCos & " , "
                    wp_sCmdSql += "bIndLibODP  =  " & .bIndLibODP & " , "
                    wp_sCmdSql += "nUltPreEnt  =  " & .nUltPreEnt & " , "
                    wp_sCmdSql += "sCodAlmCom  = '" & .sCodAlmCom & "' , "
                    wp_sCmdSql += "sCodGrpVta  = '" & .sCodGrpVta & "', "
                    wp_sCmdSql += "bIndCanRes     =  " & .bIndCanRes & " , "
                    wp_sCmdSql += "bIndCanPry  =  " & .bIndCanPry & " , "
                    wp_sCmdSql += "nSdoIni  = '" & .nSdoIni & "', "
                    wp_sCmdSql += "nSdoIniAno  = '" & .nSdoIniAno & "', "
                    wp_sCmdSql += "nCanResODP  = '" & .nCanResODP & "', "
                    wp_sCmdSql += "nSdoFinDis  = '" & .nSdoFinDis & "', "
                    wp_sCmdSql += "nCanPedODC  = '" & .nCanPedODC & "', "
                    wp_sCmdSql += "nSdoFinPry  = '" & .nSdoFinPry & "', "
                    wp_sCmdSql += "nLeadTime  = '" & .nLeadTime & "'"
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodItm =        '" & .sCodItm
                    wp_sCmdSql += "')"
                    wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function
    Public Function cdCrearActualizarILMDI1(ByVal wp_eILDMI1 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_bYesNo = True

            With wp_eILDMI1


                If wp_sCmdSel = "C" Then
                    wl_bYesNo = False
                    wp_sCmdSql = "Insert into ILDMI1 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "sCodAlm ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodAlm & "')"
                    wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_bYesNo Then
                    wl_bYesNo = False
                    wp_sCmdSql = "Update ILDMI1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nCanMin     = " & .nCanMin & ", "
                    wp_sCmdSql += "nCanMax     = " & .nCanMax & ", "
                    wp_sCmdSql += "nOrdMin     = " & .nOrdMin & ", "
                    wp_sCmdSql += "nSdoAlm     = " & .nSdoAlm & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nVlrTot     = " & .nVlrTot & ", "
                    wp_sCmdSql += "nUltPreEnt  =  " & .nUltPreEnt & ", "
                    wp_sCmdSql += "sCtaInv     = '" & .sCtaInv & "', "
                    wp_sCmdSql += "sCtaCosVta  = '" & .sCtaCosVta & "', "
                    wp_sCmdSql += "sCtaTrs     = '" & .sCtaTrs & "', "
                    wp_sCmdSql += "sCtaIng     = '" & .sCtaIng & "', "
                    wp_sCmdSql += "sCtaDevVta  = '" & .sCtaDevVta & "', "
                    wp_sCmdSql += "sCtaVrc     = '" & .sCtaVrc & "', "
                    wp_sCmdSql += "sCtaGto     = '" & .sCtaGto & "', "
                    wp_sCmdSql += "sCtaDot     = '" & .sCtaDot & "', "
                    wp_sCmdSql += "sCtaDifPre  = '" & .sCtaDifPre & "', "
                    wp_sCmdSql += "sCtaRev     = '" & .sCtaRev & "', "
                    wp_sCmdSql += "sCtaAumInv  = '" & .sCtaAumInv & "', "
                    wp_sCmdSql += "sCtaRedInv  = '" & .sCtaRedInv & "', "
                    wp_sCmdSql += "sCtaCom     = '" & .sCtaCom & "', "
                    wp_sCmdSql += "sCtaDevCom  = '" & .sCtaDevCom & "', "
                    wp_sCmdSql += "sCtaWIP     = '" & .sCtaDevCom & "' "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm    = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodAlm     = '" & .sCodAlm
                    wp_sCmdSql += "')"
                    wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdCrearActualizarILMDI1")
            Throw ex
        End Try

        Return wl_bYesNo

    End Function
    Public Function cdCrearActualizarILDMI2(ByVal wp_eILDMI2 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_bYesNo = True

            With wp_eILDMI2
                If wp_sCmdSel = "C" Then
                    wl_bYesNo = False
                    wp_sCmdSql = "Insert into ILDMI2 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "sCodTer ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodTer & "')"
                    wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_bYesNo Then
                    wl_bYesNo = False
                    wp_sCmdSql = "Update ILDMI2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodLstPre     = '" & .sCodLstPre & "', "
                    wp_sCmdSql += "nUltPreCom     = " & .nUltPreCom & ", "
                    wp_sCmdSql += "bTerDfl        = " & .bTerDfl & " "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodTer     = '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdCrearActualizarILDMI2")
            Throw ex
        End Try

        Return wl_bYesNo

    End Function
#End Region
#Region "U - Actualizar"
    Public Function cdActUltPreEntIEDMI(ByVal wl_eILMOV1 As Object,
                                        ByVal wr_bEOFL1 As Boolean,
                                        ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_bYesNo = True
            With wl_eILMOV1
                wl_bYesNo = False
                wp_sCmdSql = "Update IEDMI "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nUltPreEnt     = " & .nPreUni

                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "')"
                'wp_sCmdSql += ")"
                wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldCEODC.cdActUltPreEntIEDMI")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function
    Public Function cdActUltPreEntILDMI1(ByVal wl_eILMOV1 As Object,
                                     ByVal wr_bEOFL1 As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_bYesNo = True
            With wl_eILMOV1
                wl_bYesNo = False
                wp_sCmdSql = "Update ILDMI1 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nUltPreEnt     = " & .nPreUni

                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "sCodAlm     = '" & .sCodAlm & "')"
                'wp_sCmdSql += ")"
                wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldCEODC.cdActUltPreEntIEDMI")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function
    Public Function cdSdoIniIEDMI(ByVal wp_eATASI As Object,
                                     ByVal wp_eIEDMI As Object,
                                     ByVal wp_sNomTbl As String) As Boolean
        Try
            wl_bYesNo = True
            wp_sCmdSql = "Update " & wp_sNomTbl & " T0, "
            wp_sCmdSql += wp_eATASI.sNomTblEncSdoIni & " T1 "
            wp_sCmdSql += " SET "
            wp_sCmdSql += "T0.nCosItm     = T1.nCosItm ,"
            wp_sCmdSql += "T0.nSdoInv     = T1.nSdoInv, "
            'wp_sCmdSql += "T0.nCanResODP     = T1.nCanResODP, "
            'wp_sCmdSql += "T0.nSdoFinDis     = T1.nSdoFinDis, "
            'wp_sCmdSql += "T0.nCanPedODC     = T1.nCanPedODC, "
            'wp_sCmdSql += "T0.nSdoFinPry     = T1.nSdoFinPry "
            wp_sCmdSql += "T0.nSdoIni     = T1.nSdoInv, "
            wp_sCmdSql += "T0.nSdoIniAno     = T1.nSdoInv "
            wp_sCmdSql += " WHERE T0.bIndCan = TRUE "
            wp_sCmdSql += "And t0.sCodItm = t1.sCodItm "
            If wp_eIEDMI.sCodItm <> "" Then
                wp_sCmdSql += "AND t0.sCodItm = " & " '" & wp_eIEDMI.sCodItm & "' "
            End If
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Update ILDMI1 T0,  "
            wp_sCmdSql += wp_eATASI.sNomTblDetSdoIni & " T1 "
            wp_sCmdSql += " SET "
            wp_sCmdSql += "T0.nSdoAlm     =  T1.nSdoAlm,"
            wp_sCmdSql += "T0.nPreUni     =  T1.nPreUni,"
            wp_sCmdSql += "T0.nVlrTot     =  T1.nVlrTot, "
            wp_sCmdSql += "T0.nSdoIniAlm     = T1.nSdoAlm, "
            wp_sCmdSql += "T0.nSdoIniAnoAlm     = T1.nSdoAlm "

            wp_sCmdSql += " WHERE T0.sCodItm = T1.sCodItm "
            wp_sCmdSql += " AND T0.sCodAlm = T1.sCodAlm "
            If wp_eIEDMI.sCodItm <> "" Then
                wp_sCmdSql += " AND t0.sCodItm = " & " '" & wp_eIEDMI.sCodItm & "' "
            End If
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clnIEDMI.cdSdoIniIEDMI")
        End Try
        Return wl_bYesNo

    End Function
    Public Function cdSdoInvIEDMI_0(ByVal wp_eIEDMI As Object,
                                    ByVal wp_sNomTbl As String) As Boolean
        Try
            wl_bYesNo = True
            wp_sCmdSql = "Update " & wp_sNomTbl & " T0"
            wp_sCmdSql += " SET "
            wp_sCmdSql += "T0.nCosItm     =  0,"
            wp_sCmdSql += "T0.nSdoInv     =  0, "
            'wp_sCmdSql += "T0.nCanResODP     =  0, "
            wp_sCmdSql += "T0.nSdoFinDis     =  0, "
            'wp_sCmdSql += "T0.nCanPedODC     =  0, "
            wp_sCmdSql += "T0.nSdoFinPry     =  0 "
            wp_sCmdSql += "WHERE T0.bIndCan = TRUE "
            If wp_eIEDMI.sCodItm <> "" Then
                wp_sCmdSql += "AND t0.sCodItm = " & " '" & wp_eIEDMI.sCodItm & "' "
            End If
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            If wp_sNomTbl = "IEDMI" Then
                wp_sCmdSql = "Update ILDMI1 T0 "
                wp_sCmdSql += " INNER JOIN  IEDMI T1"
                wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm"
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nSdoAlm     =  0,"
                wp_sCmdSql += "T0.nPreUni     =  0,"
                wp_sCmdSql += "T0.nVlrTot     =  0 "
                wp_sCmdSql += "WHERE T1.bIndCan = TRUE "
                If wp_eIEDMI.sCodItm <> "" Then
                    wp_sCmdSql += " AND t0.sCodItm = " & " '" & wp_eIEDMI.sCodItm & "' "
                End If
                wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clnIEDMI.cdSdoInvIEDMI_0")
        End Try
        Return wl_bYesNo

    End Function

#End Region

#Region "R - Consultar"
    Public Function cddtConGELDMI1(ByVal vp_sCodItm As String,
                                   ByVal vp_sCodAlm As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        'devuelve el ítem con el almacén de IEDMI
        Try
            wp_sCmdSql = "SELECT * FROM IEDMI T0 INNER JOIN ILDMI1 T1 ON (T0.sCodItm = T1.sCodItm)"
            '   wp_sCmdSql += " AND (T0.sCodAlm = T1.sCodAlm)"
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " where "
                wp_sCmdSql += "(T0.sCodItm     = '" & vp_sCodItm & "' and "
                wp_sCmdSql += "T1.sCodAlm     = '" & vp_sCodAlm
                wp_sCmdSql += "')"
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGELDMI1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConIEDMI(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByVal wp_eIEDMI As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim vl_WHERE As Boolean = True
            Dim vl_bSiNo As Boolean = True
            Dim vl_nPos As Integer
            Dim vl_bLIKECod As Boolean = False
            Dim vl_bLIKENom As Boolean = False
            Dim vl_sCodItm As String

            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0"

            vl_nPos = 1
            vl_sCodItm = wp_eIEDMI.sCodItm
            If vl_sCodItm = "   -" Then
                vl_sCodItm = ""
            End If
            vl_nPos = InStr(1, wp_eIEDMI.sCodItm, "%")
            If vl_nPos = 0 Then
                vl_nPos = InStr(1, wp_eIEDMI.sNomItm, "%")
                If vl_nPos = 0 Then
                    vl_nPos = 1
                Else
                    vl_bLIKECod = False
                    vl_bLIKENom = True
                End If
            Else
                vl_bLIKECod = True
                vl_bLIKENom = False
            End If

            If vl_nPos = 0 Then
                vl_nPos = 1
            End If

            'If Mid(wp_eIEDMI.sCodItm, 1, 1) <> " " Then
            If Mid(vl_sCodItm, 1, 1) <> "" Then
                wp_sCmdSql += " WHERE T0.sCodItm LIKE '" & Mid(wp_eIEDMI.sCodItm, 1, vl_nPos) & "'"
                vl_WHERE = False
                vl_bSiNo = False
            Else
                If Mid(wp_eIEDMI.sNomItm, 1, 1) <> "" Then
                    wp_sCmdSql += " WHERE T0.sNomItm LIKE '" & Mid(wp_eIEDMI.sNomItm, 1, vl_nPos) & "'"
                    vl_WHERE = False
                    vl_bSiNo = False
                End If
            End If

            If wp_sNomCmp <> "" Then
                If vl_bSiNo Then
                    wp_sCmdSql += " WHERE "
                Else
                    wp_sCmdSql += " AND "
                End If

                wp_sCmdSql += "T0." & wp_sNomCmp
                If wp_sNomCmp = "bItmCom" Then
                    vl_bSiNo = True
                End If
                If wp_sNomCmp = "bItmVta" Then
                    vl_bSiNo = True
                End If
                wp_sCmdSql += " = " & vl_bSiNo
            End If

            If vl_bLIKENom Then
                wp_sCmdSql += " ORDER BY T0.sNomItm"
            Else
                wp_sCmdSql += " ORDER BY T0.sCodItm"
            End If


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConIEDMI")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConIEDMI_QGrl(ByVal wp_eIEDMI As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_eIEDMI
                wp_sCmdSql = "SELECT "
                If .sCodItm <> "" Then
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T0.sNomItm "
                    wl_bComa = True
                End If
                If .sCodAlm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T1.sCodAlm "
                    wl_bComa = True
                End If

                If .sCodGrp <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodGrp "
                    wl_bComa = True
                End If
                wp_sCmdSql += " from "
                wp_sCmdSql += "IEDMI T0 "
                wp_sCmdSql += "INNER JOIN ILDMI1 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCoditm = T1.sCodItm "
                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodItm = '" & .sCodItm & "' "
                        wl_WHERE = ""
                    End If

                End If

                If .sCodAlm <> "" Then
                    If .sCodAlm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.sCodAlm = '" & .sCodAlm & "'"
                    End If

                End If
                If .sCodGrp <> "" Then
                    If .sCodGrp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodGrp = '" & .sCodGrp & "'"
                    End If
                End If

                wl_bComa = False
                wp_sCmdSql += " GROUP BY "

                If .sCodItm <> "" Then
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T0.sNomItm "
                    wl_bComa = True
                End If
                If .sCodAlm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T1.sCodAlm "
                    wl_bComa = True
                End If
                If .sCodGrp <> "" Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodGrp "
                    wl_bComa = True
                End If

            End With


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConIEDMI_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConIEDMI_QIniFin(ByVal wp_eIEDMI_Ini As Object,
                                         ByVal wp_eIEDMI_Fin As Object,
                                         ByVal wp_bImpItmInac As Boolean,
                                         ByVal wp_bImpItmCero As Boolean,
                                         ByVal wp_sNomTblTmp As String,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean
            Dim wl_ORDER_BY As String
            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_ORDER_BY = " ORDER BY "
            wl_bComa = False
            With wp_eIEDMI_Ini
                wp_sCmdSql = "SELECT * "
                If wp_sNomTblTmp <> "" Then
                    wp_sCmdSql = "DROP TABLE TmpIEDMI"
                    wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
                    wp_sCmdSql = "SELECT * "
                    wp_sCmdSql += " INTO "
                    wp_sCmdSql += wp_sNomTblTmp
                End If
                wp_sCmdSql += " from "
                wp_sCmdSql += "IEDMI T0 "
                'wp_sCmdSql += "INNER JOIN ILDMI1 T1 "
                'wp_sCmdSql += " ON "
                'wp_sCmdSql += "T0.sCodItm = T1.sCodItm "
                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodItm >= '" & .sCodItm & "' "
                        wl_WHERE = ""
                    End If
                End If
                If wp_eIEDMI_Fin.sCodItm <> "" Then
                    If wp_eIEDMI_Fin.sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodItm <= '" & wp_eIEDMI_Fin.sCodItm & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .sCodGrp <> "" Then
                    If .sCodGrp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodGrp >= '" & .sCodGrp & "'"
                    End If
                End If
                If wp_eIEDMI_Fin.sCodGrp <> "" Then
                    If wp_eIEDMI_Fin.sCodGrp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodGrp <= '" & wp_eIEDMI_Fin.sCodGrp & "'"
                    End If
                End If

                If wp_bImpItmInac <> True Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.bItmIna = false "
                End If

                If wp_bImpItmCero <> True Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.nSdoInv <> 0 "
                End If


                If wl_WHERE = "" Then
                    wl_bComa = False
                    If .sCodItm <> "" Then
                        wp_sCmdSql += wl_ORDER_BY
                        wp_sCmdSql += "T0.sCodItm "
                        wl_ORDER_BY = ""
                        wl_bComa = True
                    End If
                    If .sCodGrp <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.sCodGrp "
                        wl_bComa = True
                    End If
                End If
            End With
            If wl_WHERE = "" Then
                wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
                If wp_sNomTblTmp <> "" Then
                    wp_sCmdSql = "Select * FROM " & wp_sNomTblTmp
                    wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
                End If
            End If
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConIEDMI_QIniFin")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConIELDMI1_QIniFin(ByVal wp_eIEDMI_Ini As Object,
                                           ByVal wp_eIEDMI_Fin As Object,
                                           ByVal wp_bImpItmInac As Boolean,
                                           ByVal wp_bImpItmCero As Boolean,
                                           ByVal wp_bVdaCanMin As Boolean,
                                           ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean
            Dim wl_ORDER_BY As String
            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_ORDER_BY = " ORDER BY "
            wl_bComa = False
            With wp_eIEDMI_Ini
                wp_sCmdSql = "SELECT * "
                wp_sCmdSql += " from "
                wp_sCmdSql += "IEDMI T0 "
                wp_sCmdSql += "INNER JOIN ILDMI1 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodItm = T1.sCodItm "
                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodItm >= '" & .sCodItm & "' "
                        wl_WHERE = ""
                    End If
                End If
                If wp_eIEDMI_Fin.sCodItm <> "" Then
                    If wp_eIEDMI_Fin.sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodItm <= '" & wp_eIEDMI_Fin.sCodItm & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .sCodAlm <> "" Then
                    If .sCodAlm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.sCodAlm >= '" & .sCodAlm & "'"
                    End If
                End If
                If wp_eIEDMI_Fin.sCodAlm <> "" Then
                    If wp_eIEDMI_Fin.sCodAlm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.sCodAlm <= '" & wp_eIEDMI_Fin.sCodAlm & "'"
                    End If
                End If
                If .sCodGrp <> "" Then
                    If .sCodGrp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodGrp >= '" & .sCodGrp & "'"
                    End If
                End If
                If wp_eIEDMI_Fin.sCodGrp <> "" Then
                    If wp_eIEDMI_Fin.sCodGrp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodGrp <= '" & wp_eIEDMI_Fin.sCodGrp & "'"
                    End If
                End If

                If wp_bImpItmInac <> True Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.bItmIna = false "
                End If

                If wp_bImpItmCero <> True Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T1.nSdoAlm <> 0 "
                End If

                If wp_bVdaCanMin = True Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T1.nSdoAlm <= T1.nCanMin "
                End If


                If wl_WHERE = "" Then
                    wl_bComa = False
                    If .sCodItm <> "" Then
                        wp_sCmdSql += wl_ORDER_BY
                        wp_sCmdSql += "T0.sCodItm "
                        wl_ORDER_BY = ""
                        wl_bComa = True
                    End If
                    If .sCodAlm <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T1.sCodAlm "
                        wl_bComa = True
                    End If
                    If .sCodGrp <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.sCodGrp "
                        wl_bComa = True
                    End If
                End If
            End With
            If wl_WHERE = "" Then
                wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            End If
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConIEDMI_QIniFin")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConIEDMIR(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sCodAlm As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim vl_bSiNo As Boolean = False
            Dim wl_WHERE As String
            Dim wl_AND As String
            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wp_sCmdSql = "SELECT T0.nId, "
            wp_sCmdSql += "T0.sCodItm, "
            wp_sCmdSql += "T0.sNomItm, "
            wp_sCmdSql += "T0.sNomAlt, "
            wp_sCmdSql += "T1.sCodAlm "
            wp_sCmdSql += " FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0"
            wp_sCmdSql += " INNER JOIN ILDMI1 T1 ON (T0.sCodItm = T1.sCodItm)"
            If wp_sNomCmp <> "" Then
                wp_sCmdSql += wl_WHERE
                wl_WHERE = " "
                wp_sCmdSql += "T0." & wp_sNomCmp
                If wp_sNomCmp = "bItmCom" Then
                    vl_bSiNo = True
                End If
                If wp_sNomCmp = "bItmVta" Then
                    vl_bSiNo = True
                End If
                wp_sCmdSql += " = " & vl_bSiNo
            End If
            If wp_sCodAlm <> "" Then
                If wl_WHERE <> " " Then
                    wp_sCmdSql += wl_WHERE
                Else
                    wp_sCmdSql += wl_AND
                End If



                wp_sCmdSql += " T1.sCodAlm = '" & wp_sCodAlm & "'"
            End If


            wp_sCmdSql += " ORDER BY T0.sCodItm"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConIEDMI")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConILDMI2(ByVal wp_sNomTbl As String,
                                  ByVal wg_sDatCon11 As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT "
            wp_sCmdSql += "T0.nId,"
            wp_sCmdSql += "T0.sCodItm,"
            wp_sCmdSql += "T0.sCodTer,"
            wp_sCmdSql += "T0.sCodLstPre,"
            wp_sCmdSql += "T0.nUltPreCom,"
            wp_sCmdSql += "T0.bTerDfl,"
            wp_sCmdSql += "T1.sNomItm,"
            wp_sCmdSql += "T1.sNomAlt "
            wp_sCmdSql += "FROM ILDMI2 T0 INNER JOIN IEDMI T1 ON"
            wp_sCmdSql += " (T0.sCodItm = T1.sCodItm) "
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += "(T0.sCodTer = '"
            wp_sCmdSql += wg_sDatCon11 & "')"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConILDMI2")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConItmILDMI2(ByVal vp_sCodItm,
                                     ByRef wr_bEOF) As DataTable
        'devuelve todos los proveedores de un ítem
        Try

            wp_sCmdSql = "select * from ILDMI2 T0"
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN  TEDMT T1"
                wp_sCmdSql += " ON T0.sCodTer = T1.sCodTer"
                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConItmILDMI2")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConSdoFin(ByVal wp_eIEDMI_Ini As Object,
                                      ByVal wp_eIEDMI_Fin As Object,
                                      ByVal wp_bImpItmInac As Boolean,
                                      ByVal wp_bImpItmCero As Boolean,
                                      ByVal wp_dFecMDAIni As String,
                                      ByVal wp_dFecMDAFin As String,
                                      ByVal wp_eATASI As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable
        '2018-08-20 Se Adiciona esta función
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            Dim wl_dFecMDAIni As Date
            Dim wl_dFecMDAFin As Date
            Dim wl_sFecMDAIni As String
            Dim wl_sFecMDAFin As String

            wl_dFecMDAIni = wp_dFecMDAIni
            wl_dFecMDAFin = wp_dFecMDAFin
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)
            wl_sFecMDAFin = cdf_dDMY_MDY(wl_dFecMDAFin)



            'devuelve el ítem con el almacén vp_sCodAlm
            wp_sCmdSql = "SELECT"
            wp_sCmdSql += " T2.sCodAlm, "
            wp_sCmdSql += " T2.sCodGrp, "
            wp_sCmdSql += " T1.sCoditm, "
            wp_sCmdSql += " T2.sNomItm, "
            wp_sCmdSql += " T2.bItmAct, "
            wp_sCmdSql += " T2.bIndCan, "
            wp_sCmdSql += " T2.bIndCos, "
            wp_sCmdSql += "(SUM(IIf(T0.sTipMov = 'E',T1.nCanItm,0)) - SUM(IIf(T0.sTipMov = 'S',T1.nCanItm,0))) AS nSdoFinUni,  "
            wp_sCmdSql += "(SUM(IIf(T0.sTipMov = 'E',T1.nTotLin,0)) - SUM(IIf(T0.sTipMov = 'S',T1.nTotLin,0))) AS nSdoFinPes "

            wp_sCmdSql += "FROM IEMOV T0 INNER JOIN "
            wp_sCmdSql += "( "
            wp_sCmdSql += "ILMOV1 T1 INNER JOIN " & wp_eATASI.sNomTblEnc & " T2 "
            wp_sCmdSql += "ON T1.sCodItm = T2.sCodItm"
            wp_sCmdSql += ") "
            wp_sCmdSql += "ON (T0.sCodDoc = T1.sCodDoc) AND  (T0.nNroDoc = T1.nNroDoc)"

            If wp_eIEDMI_Ini.sCodAlm <> "" Then
                If wp_eIEDMI_Ini.sCodAlm <> " " Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T2.sCodAlm >= '" & wp_eIEDMI_Ini.sCodAlm & "'"
                End If
            End If
            If wp_eIEDMI_Fin.sCodAlm <> "" Then
                If wp_eIEDMI_Fin.sCodAlm <> " " Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T2.sCodAlm <= '" & wp_eIEDMI_Fin.sCodAlm & "'"
                End If
            End If

            If wp_eIEDMI_Ini.sCodItm <> "" Then
                If wp_eIEDMI_Ini.sCodItm <> " " Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += " T2.sCodItm >= '" & wp_eIEDMI_Ini.sCodItm & "' "
                    wl_bIndWHERE = True
                Else
                    vl_bIndAND = False
                End If
            End If
            If wp_eIEDMI_Fin.sCodItm <> "" Then
                If wp_eIEDMI_Fin.sCodItm <> " " Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T2.sCodItm <= '" & wp_eIEDMI_Fin.sCodItm & "' "
                End If
            End If
            If wp_eIEDMI_Ini.sCodGrp <> "" Then
                If wp_eIEDMI_Ini.sCodGrp <> " " Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T2.sCodGrp >= '" & wp_eIEDMI_Ini.sCodGrp & "'"
                End If
            End If
            If wp_eIEDMI_Fin.sCodGrp <> "" Then
                If wp_eIEDMI_Fin.sCodGrp <> " " Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T2.sCodGrp <= '" & wp_eIEDMI_Fin.sCodGrp & "'"
                End If
            End If


            If wp_bImpItmInac <> True Then
                If wl_bIndWHERE = False Then
                    wp_sCmdSql += " WHERE "
                    wl_bIndWHERE = True
                Else
                    wp_sCmdSql += " AND "
                End If
                wp_sCmdSql += " T2.bItmIna = false "
            End If

            '   If wp_bImpItmCero <> True Then
            ' If wl_bIndWHERE = False Then
            ' wp_sCmdSql += " WHERE "
            ' wl_bIndWHERE = True
            ' Else
            ' wp_sCmdSql += " AND "
            ' End If
            ' wp_sCmdSql += " T2.nSdoInv <> 0 "
            ' End If

            ' If wl_sFecMDAIni <> Nothing Then
            ' If wl_bIndWHERE = False Then
            ' wp_sCmdSql += " WHERE "
            ' wl_bIndWHERE = True
            ' Else
            ' vl_bIndAND = True
            ' End If
            ' If vl_bIndAND Then
            ' wp_sCmdSql += " AND "
            ' End If
            ' vl_bIndAND = True
            ' wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecMDAIni & "#"
            ' End If
            If wl_sFecMDAFin <> Nothing Then
                If wl_bIndWHERE = False Then
                    wp_sCmdSql += " WHERE "
                    wl_bIndWHERE = True
                Else
                    vl_bIndAND = True
                End If
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.dFecDoc <= #" & wl_sFecMDAFin & "#"
            End If

            wp_sCmdSql += " GROUP BY T2.sCodAlm,T2.sCodGrp,T1.sCoditm,T2.sNomItm,T2.bItmAct,T2.bIndCan,bIndCos"

            'Inicio Consulta creada en la BD 2018-08-27

            'SELECT T2.sCodAlm, T2.sCodGrp, T1.sCoditm, T2.sNomItm,T2.bItmAct,T2.bIndCan,bIndCos,
            '(SUM(IIf(T0.sTipMov="E",T1.nCanItm,0))-SUM(IIf(T0.sTipMov="S",T1.nCanItm,0))) AS Sdo_Fin_Uni, 
            '(SUM(IIf(T0.sTipMov="E",T1.nTotLin,0))-SUM(IIf(T0.sTipMov="S",T1.nTotLin,0))) AS Sdo_Fin_Pes
            'FROM IEMOV AS T0 INNER JOIN (ILMOV1 AS T1 INNER JOIN IEDMI AS T2 ON T1.sCodItm=T2.sCodItm) ON (T0.nNroDoc=T1.nNroDoc) AND (T0.sCodDoc=T1.sCodDoc)
            'WHERE T0.dFecDoc <= #27-aug-2018#
            'GROUP BY T2.sCodAlm, T2.sCodGrp, T1.scoditm, T2.snomitm,T2.bItmAct,T2.bIndCan,bIndCos;

            'fin Consulta creada en la BD 2018-08-27



            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConSdoFin")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarILMDI1(ByVal vp_sCodItm,
                                            ByRef wr_bEOF) As DataTable
        'devuelve todos los almacenes de un ítem
        Try

            wp_sCmdSql = "select * from ILDMI1 T0"
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN  ATALM T1"
                wp_sCmdSql += " ON T0.sCodAlm = T1.sCodAlm"
                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConsultarILMDI1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConSdoILMDI1(ByVal vp_sCodAlm,
                                     ByVal vp_sCodItm,
                                     ByRef wr_bEOF) As DataTable
        Try
            'devuelve el ítem con el almacén vp_sCodAlm
            wp_sCmdSql = "SELECT * FROM IEDMI T0 INNER JOIN ILDMI1 T1 ON (T0.sCodItm = T1.sCodItm)"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += "T0.sCodItm = '" & vp_sCodItm & "' "
            wp_sCmdSql += " AND "
            wp_sCmdSql += "T1.sCodAlm = '" & vp_sCodAlm & "' "
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConSdoILMDI1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConSdoIEDMI(ByVal vp_sCodItm,
                                    ByRef wr_bEOF) As DataTable
        Try
            'devuelve el ítem con el almacén vp_sCodAlm
            wp_sCmdSql = "SELECT"
            wp_sCmdSql += " T0.nId, "
            wp_sCmdSql += " T0.sCodItm, "
            wp_sCmdSql += " T0.nSdoInv, "
            wp_sCmdSql += " T0.nSdoIni, "
            wp_sCmdSql += " T0.nSdoIniAno, "
            wp_sCmdSql += " T0.nCanResODP, "
            wp_sCmdSql += " T0.nSdoFinDis, "
            wp_sCmdSql += " T0.nCanPedODC, "
            wp_sCmdSql += " T0.nSdoFinPry "
            wp_sCmdSql += " FROM IEDMI T0 "
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "'"
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConSdoILMDI1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConTerILDMI2(ByVal vp_sCodTer,
                                     ByRef wr_bEOF) As DataTable
        'devuelve todos los ítems de un proveedor
        Try

            wp_sCmdSql = "select * from ILDMI2 T0"
            If vp_sCodTer IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN  TEDMT T1"
                wp_sCmdSql += " ON T0.sCodTer = T1.sCodTer"
                wp_sCmdSql += " WHERE T0.sCodTer = '" & vp_sCodTer & "' "
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConTerILDMI2")
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region
#Region "D - Borrar"
    Public Function cdEliminar(ByVal vp_sCodItm As String,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_bYesNo = False

            wp_sCmdSql = "Delete * from  ILDMI2 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  ILDMI1 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  IEDMI "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminar")
            Throw ex

        End Try
        Return wl_bYesNo

    End Function
    Public Function cdEliminarILMDI1(ByVal vp_sCodItm As String,
                                           ByVal vp_sCodAlm As String,
                                           ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_bYesNo = False
            wp_sCmdSql = "Delete * from  ILDMI1 "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodItm     = '" & vp_sCodItm & "' and "
            wp_sCmdSql += "sCodAlm     = '" & vp_sCodAlm
            wp_sCmdSql += "')"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminarILMDI1")
            Throw ex
        End Try

        Return wl_bYesNo
    End Function
    Public Function cdEliILDMI2(ByVal vp_sCodItm As String,
                                    ByVal vp_sCodTer As String,
                                    ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_bYesNo = False
            wp_sCmdSql = "Delete * from  ILDMI2 "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodItm     = '" & vp_sCodItm & "' and "
            wp_sCmdSql += "sCodTer     = '" & vp_sCodTer
            wp_sCmdSql += "')"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliILDMI2")
            Throw ex
        End Try

        Return wl_bYesNo
    End Function
#End Region

#Region "Otras"
    Public Function cdEliCrearTmpIEDMI() As Boolean
        Try

            wl_bYesNo = False
            wp_sCmdSql = "Drop Table TmpIEDMI"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            wp_sCmdSql = "Select * Into TmpIEDMI FROM IEDMI"
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Update TmpIEDMI T0"
            wp_sCmdSql += " SET "
            wp_sCmdSql += "T0.nCosItm     =  0,"
            wp_sCmdSql += "T0.nSdoInv     =  0 "
            wp_sCmdSql += "WHERE T0.bIndCan = TRUE "
            wl_bYesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliCrearTmpIEDMI")
            Throw ex
        End Try

        Return wl_bYesNo
    End Function

#End Region

End Class
