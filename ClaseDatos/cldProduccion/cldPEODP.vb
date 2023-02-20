Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldPEODP
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand
    Dim cldIEDMI As New cldIEDMI
#Region "C - Crear"
    Public Function cdCrearActualizar(ByVal vp_ePEODP As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            Dim vl_sFecEmi As String
            Dim vl_sFecIni As String
            Dim vl_sFecFin As String
            Dim vl_sFecSys As String
            With vp_ePEODP
                vl_sFecEmi = cdf_dDMY_MDY(.dFecEmi)
                vl_sFecIni = cdf_dDMY_MDY(.dFecIni)
                vl_sFecFin = cdf_dDMY_MDY(.dFecFin)
                vl_sFecSys = cdf_dDMY_MDY(.dFecSys)
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PEODP "
                    wp_sCmdSql += "(sCodDoc , "
                    wp_sCmdSql += "nNrodoc) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodDoc & "',"
                    wp_sCmdSql += .nNroDoc & ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PEODP "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "', "
                    wp_sCmdSql += "sNroLot     = '" & .sNroLot & "', "
                    wp_sCmdSql += "sEstOdp     = '" & .sEstODP & "', "
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "', "
                    wp_sCmdSql += "sNomItm     = """ & .sNomItm & """, "
                    'wp_sCmdSql += "sNomItm     = '" & .sNomItm & "', "
                    wp_sCmdSql += "nCanLotStn     = " & .nCanLotStn & ", "
                    wp_sCmdSql += "sUniMedStn  = '" & .sUniMedStn & "', "
                    wp_sCmdSql += "nCanUniStn     = " & .nCanUniStn & ", "
                    wp_sCmdSql += "nCanOdp     = " & .nCanOdp & ", "
                    wp_sCmdSql += "sUniMedOdp  = '" & .sUniMedOdp & "', "
                    wp_sCmdSql += "nCanUniOdp     = " & .nCanUniOdp & ", "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', "
                    wp_sCmdSql += "nCanUniEdp     = " & .nCanUniEdp & ", "
                    wp_sCmdSql += "nTieItm     = " & .nTieItm & ", "
                    wp_sCmdSql += "nTotTieOdp     = " & .nTotTieOdp & ", "
                    wp_sCmdSql += "nTotTieEdp     = " & .nTotTieEdp & ", "
                    wp_sCmdSql += "sCodAlm     = '" & .sCodAlm & "', "
                    wp_sCmdSql += "dFecEmi     = #" & vl_sFecEmi & "#, "
                    wp_sCmdSql += "dFecIni     = #" & vl_sFecIni & "#, "
                    wp_sCmdSql += "dFecFin     = #" & vl_sFecFin & "#, "
                    wp_sCmdSql += "dFecSys     = #" & vl_sFecSys & "#, "
                    wp_sCmdSql += "sClsDoc     = '" & .sClsDoc & "', "
                    wp_sCmdSql += "sCodUsr     = '" & .sCodUsr & "', "
                    wp_sCmdSql += "bIndCanRes  = " & .bIndCanRes & ", "
                    wp_sCmdSql += "bIndCanPry  = " & .bIndCanPry & ", "
                    wp_sCmdSql += "sCmn        = '" & .sCmn & "' "
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
            MsgBox("Error : cldPEODP.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLODP1(ByVal vl_ePLODP1 As Object,
                                           ByVal wr_bEOFL1 As Boolean,
                                           ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vl_ePLODP1
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLODP1 "
                    wp_sCmdSql += "(sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sCodItm, "
                    wp_sCmdSql += "sCodCmt ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('"
                    wp_sCmdSql += .sCodDoc
                    wp_sCmdSql += "' , "
                    wp_sCmdSql += .nNroDoc & " , "
                    wp_sCmdSql += "'"
                    wp_sCmdSql += .sCodSer
                    wp_sCmdSql += "' ,"
                    wp_sCmdSql += "'"
                    wp_sCmdSql += .sCodItm
                    wp_sCmdSql += "' , '"
                    wp_sCmdSql += .sCodCmt
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLODP1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "',"
                    wp_sCmdSql += "nCanCmt     = " & .nCanCmt & ", "
                    wp_sCmdSql += "nCanReq     = " & .nCanReq & ", "
                    wp_sCmdSql += "nCanCns     = " & .nCanCns & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nVlrTotReq     = " & .nVlrTotReq & ", "
                    wp_sCmdSql += "nVlrTotCns     = " & .nVlrTotCns & ", "
                    wp_sCmdSql += "sCodAlmCns  = '" & .sCodAlmCns & "', "
                    wp_sCmdSql += "sCodCmtAlt  = '" & .sCodCmtAlt & "'"
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodDoc     = '" & .sCodDoc & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "nNroDoc     = " & .nNroDoc
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodCmt     = '" & .sCodCmt & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                    'Actualizar los saldos de reservado




                End If
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdCrearActualizarPLODP1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLODP2(ByVal vl_ePLODP2 As Object,
                                            ByVal wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vl_ePLODP2
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLODP2 "
                    wp_sCmdSql += "(sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sCodItm, "
                    wp_sCmdSql += "sCodOpe ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "' , "
                    wp_sCmdSql += .nNroDoc & ", "
                    wp_sCmdSql += "'" & .sCodSer & "', "
                    wp_sCmdSql += "'" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodOpe & "' "
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLODP2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nPosOpe     = " & .nPosOpe & " , "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & " ', "
                    wp_sCmdSql += "nTieOpe     = " & .nTieOpe & " , "
                    wp_sCmdSql += "nTieReq     = " & .nTieReq & " , "
                    wp_sCmdSql += "nTieCns     = " & .nTieCns & " , "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & " , "
                    wp_sCmdSql += "nVlrTotReq     = " & .nVlrTotReq & " , "
                    wp_sCmdSql += "nVlrTotCns     = " & .nVlrTotCns & ", "
                    wp_sCmdSql += "nPorOpeReq     = " & .nPorOpeReq & ", "
                    wp_sCmdSql += "nPorOpeCns     = " & .nPorOpeCns & ", "
                    wp_sCmdSql += "nVrcPorOpe     = " & .nVrcPorOpe & " "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodDoc     = '" & .sCodDoc & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "nNroDoc     = " & .nNroDoc
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodOpe     = '" & .sCodOpe & "'"
                    wp_sCmdSql += ")"

                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdCrearActualizarPLODP2")
            Throw ex
        End Try

        Return wl_YesNo

    End Function
    Public Function cdCrearActualizarPLODP3(ByVal vl_ePLODP3 As Object,
                                            ByVal wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vl_ePLODP3
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLODP3 "
                    wp_sCmdSql += "(sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sCodItm, "
                    wp_sCmdSql += "sCodCIF ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "' ,"
                    wp_sCmdSql += .nNroDoc & " ,"
                    wp_sCmdSql += "'" & .sCodSer & "' ,"
                    wp_sCmdSql += "'" & .sCodItm & "' ,"
                    wp_sCmdSql += "'" & .sCodCif & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLODP3 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "' , "
                    wp_sCmdSql += "nVlrCIFRea     = " & .nVlrCifRea & " , "
                    wp_sCmdSql += "nVlrReq     = " & .nVlrReq & " ,  "
                    wp_sCmdSql += "nVlrCns     = " & .nVlrCns & " ,  "
                    wp_sCmdSql += "nTasCIF     = " & .nTasCIF & " ,  "
                    wp_sCmdSql += "nVlrTotReq     = " & .nVlrTotReq & " ,  "
                    wp_sCmdSql += "nVlrTotCns     = " & .nVlrTotCns & " "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodDoc     = '" & .sCodDoc & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "nNroDoc     = " & .nNroDoc
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodCif     = '" & .sCodCif & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdCrearActualizarPLODP3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLODP4(ByVal vl_ePLODP4 As Object,
                                            ByVal wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vl_ePLODP4
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLODP4 "
                    wp_sCmdSql += "(sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer,"
                    wp_sCmdSql += "sCodItm) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "' , "
                    wp_sCmdSql += .nNroDoc & " , "
                    wp_sCmdSql += "'" & .sCodSer & "',"
                    wp_sCmdSql += "'" & .sCodItm & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLODP4 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nCanOdp       = " & .nCanOdp & ", "
                    wp_sCmdSql += "nCanUniOdp       = " & .nCanUniOdp & ", "
                    wp_sCmdSql += "nCanUniEdp       = " & .nCanUniEdp & ", "
                    wp_sCmdSql += "nVrcCan       = " & .nVrcCan & ", "
                    wp_sCmdSql += "nVlrTotReqMPD = " & .nVlrTotReqMPD & ", "
                    wp_sCmdSql += "nVlrTotCnsMPD = " & .nVlrTotCnsMPD & ", " '10
                    wp_sCmdSql += "nVrcTotMPD    = " & .nVrcTotMPD & ", "
                    wp_sCmdSql += "nTotTieReqMOD = " & .nTotTieReqMOD & ", "
                    wp_sCmdSql += "nTotTieCnsMOD = " & .nTotTieCnsMOD & ", "
                    wp_sCmdSql += "nVrcTieMOD    = " & .nVrcTieMOD & ", "
                    wp_sCmdSql += "nVlrTotReqMOD = " & .nVlrTotReqMOD & ", "
                    wp_sCmdSql += "nVlrTotCnsMOD = " & .nVlrTotCnsMOD & ", "
                    wp_sCmdSql += "nVrcTotMOD    = " & .nVrcTotMOD & ", "
                    wp_sCmdSql += "nTotTasReqCIF    = " & .nTotTasReqCIF & ", "
                    wp_sCmdSql += "nTotTasCnsCIF    = " & .nTotTasCnsCIF & ", "
                    wp_sCmdSql += "nVrcTasCIF    = " & .nVrcTasCIF & ", " '20
                    wp_sCmdSql += "nVlrTotReqCIF = " & .nVlrTotReqCIF & ", "
                    wp_sCmdSql += "nVlrTotCnsCIF = " & .nVlrTotCnsCIF & ", "
                    wp_sCmdSql += "nVrcTotCIF    = " & .nVrcTotCIF & ", "
                    wp_sCmdSql += "nCosTotReq    = " & .nCosTotReq & ", "
                    wp_sCmdSql += "nCosTotCns    = " & .nCosTotCns & ", "
                    wp_sCmdSql += "nVrcCosTot    = " & .nVrcCosTot & ", "
                    wp_sCmdSql += "nTotUniReq    = " & .nTotUniReq & ", "
                    wp_sCmdSql += "nTotUniCns    = " & .nTotUniCns & ", "
                    wp_sCmdSql += "nVrcUni       = " & .nVrcUni & ", "
                    wp_sCmdSql += "nCosUniReq    = " & .nCosUniReq & ", " '30
                    wp_sCmdSql += "nCosUniCns    = " & .nCosUniCns & ", "
                    wp_sCmdSql += "nVrcCosUni    = " & .nVrcCosUni & ", " '32
                    wp_sCmdSql += "nPreVta       = " & .nPreVta & ", "
                    wp_sCmdSql += "nPorGto       = " & .nPorGto & ", "
                    wp_sCmdSql += "nPorIto       = " & .nPorIto '
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += " sCodDoc  = " & "'" & .sCodDoc & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "nNroDoc     = " & .nNroDoc
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdCrearActualizarPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLODP5(ByVal vl_ePLODP5 As Object,
                                            ByVal wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vl_ePLODP5
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLODP5 "
                    wp_sCmdSql += "(sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sCodItm, "
                    wp_sCmdSql += "sCodCmt, "
                    wp_sCmdSql += "sCodAna,  "
                    wp_sCmdSql += "sCodTipAna ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "' ,"
                    wp_sCmdSql += .nNroDoc & " ,"
                    wp_sCmdSql += "'" & .sCodSer & "' ,"
                    wp_sCmdSql += "'" & .sCodItm & "' ,"
                    wp_sCmdSql += "'" & .sCodCmt & "' ,"
                    wp_sCmdSql += "'" & .sCodAna & "',"
                    wp_sCmdSql += "'" & .sCodTipAna & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

            End With
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdCrearActualizarPLODP5")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdSdoOPPEODP_0(ByVal wp_ePEODP As Object) As Boolean
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            Dim wl_dFecMDAIni As Date
            Dim wl_sFecMDAIni As String

            wl_dFecMDAIni = wp_ePEODP.dFecIni
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)
            'PEODP
            With wp_ePEODP
                wl_YesNo = False
                wp_sCmdSql = "Update PEODP T0 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nCanUniEdp     = 0,"
                wp_sCmdSql += "T0.nTotTieEdp     = 0"
                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    vl_bIndAND = True
                    wp_sCmdSql += "T0.sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc =        " & .nNroDoc
                    'wp_sCmdSql += ")"
                End If
                '2018-08-10 Se incluye el filtro de las fechas
                If .sCodDoc = "" Then
                    If wl_sFecMDAIni <> Nothing Then
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
                        wp_sCmdSql += " T0.dFecEmi >= #" & wl_sFecMDAIni & "#"
                    End If
                End If

                'Fin 2018-08-10

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

                'PLODP1
                wl_bIndWHERE = False
                vl_bIndAND = False
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP1 AS T0 "
                wp_sCmdSql += "INNER JOIN PEODP AS T1 "
                wp_sCmdSql += " ON (T0.sCodDoc = T1.sCodDoc) "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nCanCns     = 0,"
                wp_sCmdSql += "T0.nVlrTotCns  = 0,"
                wp_sCmdSql += "T0.nVrcCan  = nCanCns - nCanReq,"
                wp_sCmdSql += "T0.nPorVrnCan  = 0,"
                wp_sCmdSql += "T0.nVlrVrcCan  =  T0.nVrcCan * T0.nPreUni"
                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    vl_bIndAND = True
                    wp_sCmdSql += "T0.sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc =        " & .nNroDoc
                End If
                '2018-08-10 Se incluye el filtro de las fechas
                If .sCodDoc = "" Then
                    If wl_sFecMDAIni <> Nothing Then
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
                        wp_sCmdSql += " T1.dFecEmi >= #" & wl_sFecMDAIni & "#"
                    End If
                End If

                'Fin 2018-08-10
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                ' PLODP2
                wl_bIndWHERE = False
                vl_bIndAND = False
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP2 AS T0 "
                wp_sCmdSql += "INNER JOIN PEODP AS T1 "
                wp_sCmdSql += " ON (T0.sCodDoc = T1.sCodDoc) "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nTieCns     = 0,"
                wp_sCmdSql += "T0.nVlrTotCns  = 0,"
                wp_sCmdSql += "T0.nPorOpeCns  = 0,"
                wp_sCmdSql += "T0.nVrcPorOpe  = 0"
                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    vl_bIndAND = True
                    wp_sCmdSql += "T0.sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc =        " & .nNroDoc
                End If
                '2018-08-10 Se incluye el filtro de las fechas
                If .sCodDoc = "" Then
                    If wl_sFecMDAIni <> Nothing Then
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
                        wp_sCmdSql += " T1.dFecEmi >= #" & wl_sFecMDAIni & "#"
                    End If
                End If

                'Fin 2018-08-10
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                ' PLODP3
                wl_bIndWHERE = False
                vl_bIndAND = False
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP3 T0 "
                wp_sCmdSql += "INNER JOIN PEODP AS T1 "
                wp_sCmdSql += " ON (T0.sCodDoc = T1.sCodDoc) "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nVlrCns     = 0,"
                wp_sCmdSql += "T0.nVlrTotCns  = 0,"
                wp_sCmdSql += "T0.nVrcCIF  = 0,"
                wp_sCmdSql += "T0.nPorVrcCIF  = 0,"
                wp_sCmdSql += "T0.nVlrVrcCIF  = 0"

                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    vl_bIndAND = True
                    wp_sCmdSql += "T0.sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc =        " & .nNroDoc
                End If
                '2018-08-10 Se incluye el filtro de las fechas
                If .sCodDoc = "" Then
                    If wl_sFecMDAIni <> Nothing Then
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
                        wp_sCmdSql += " T1.dFecEmi >= #" & wl_sFecMDAIni & "#"
                    End If
                End If

                'Fin 2018-08-10

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

                ' PLODP4
                wl_bIndWHERE = False
                vl_bIndAND = False
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP4 T0 "
                wp_sCmdSql += "INNER JOIN PEODP AS T1 "
                wp_sCmdSql += " ON (T0.sCodDoc = T1.sCodDoc) "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nCanUniEdp     = 0,"
                wp_sCmdSql += "T0.nVrcCan  = 0,"
                wp_sCmdSql += "T0.nVlrTotCnsMPD  = 0,"
                wp_sCmdSql += "T0.nVrcTotMPD  = 0,"
                wp_sCmdSql += "T0.nTotTieCnsMOD  = 0,"
                wp_sCmdSql += "T0.nVrcTieMOD  = 0,"
                wp_sCmdSql += "T0.nVlrTotCnsMOD  = 0,"
                wp_sCmdSql += "T0.nVrcTotMOD  = 0,"
                wp_sCmdSql += "T0.nTotTasCnsCIF  = 0,"
                wp_sCmdSql += "T0.nVrcTasCIF  = 0,"
                wp_sCmdSql += "T0.nVlrTotCnsCIF  = 0,"
                wp_sCmdSql += "T0.nVrcTotCIF  = 0,"
                wp_sCmdSql += "T0.nCosTotCns  = 0,"
                wp_sCmdSql += "T0.nVrcCosTot  = 0,"
                wp_sCmdSql += "T0.nTotUniCns  = 0,"
                wp_sCmdSql += "T0.nVrcUni  = 0,"
                wp_sCmdSql += "T0.nCosUniCns  = 0,"
                wp_sCmdSql += "T0.nVrcCosUni  = 0"


                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    vl_bIndAND = True
                    wp_sCmdSql += "T0.sCodDoc =        '" & .sCodDoc & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc =        " & .nNroDoc
                End If
                '2018-08-10 Se incluye el filtro de las fechas
                If .sCodDoc = "" Then
                    If wl_sFecMDAIni <> Nothing Then
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
                        wp_sCmdSql += " T1.dFecEmi >= #" & wl_sFecMDAIni & "#"
                    End If
                End If

                'Fin 2018-08-10
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            End With
        Catch ex As Exception
            MsgBox("Error: cldEODP.cdSdoOPPEODP_0")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
#End Region
#Region "R - Consultar"
    Public Function cddtConsultarPEODP(ByVal vp_sCodDoc As String,
                                     ByVal vp_nNroDoc As Integer,
                                     ByVal vp_sEstOdp As String,
                                     ByVal vp_dFecIni As Date,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            Dim wl_dFecMDAIni As Date
            Dim wl_sFecMDAIni As String
            wl_dFecMDAIni = vp_dFecIni
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from "
            wp_sCmdSql += " PEODP T0 "
            If vp_sCodDoc <> "" Then
                If wl_bIndWHERE = False Then
                    wp_sCmdSql += " WHERE "
                    wl_bIndWHERE = True
                End If
                vl_bIndAND = True
                wp_sCmdSql += "T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "T0.nNroDoc = " & vp_nNroDoc
            End If
            If vp_sEstOdp <> "" Then
                If vp_sEstOdp <> "0" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    If vl_bIndAND Then
                        wp_sCmdSql += " AND "
                    End If
                    vl_bIndAND = True
                    wp_sCmdSql += "T0.sEstOdp = '" & vp_sEstOdp & "'"
                End If
            End If

            '2018-08-10 Se incluye el filtro de las fechas
            If vp_sCodDoc = "" Then
                If wl_sFecMDAIni <> Nothing Then
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
                    wp_sCmdSql += " T0.dFecEmi >= #" & wl_sFecMDAIni & "#"
                End If
            End If
            'Fin 2018-08-10
            wp_sCmdSql += " ORDER BY T0.sCodDoc, T0.nNroDoc "

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPEODP")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLODP1(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = " SELECT * "
            wp_sCmdSql += " from "
            wp_sCmdSql += "( PLODP1 T0 "
            wp_sCmdSql += "INNER JOIN IEDMI T1 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0.[sCodCmt] = T1.[sCodItm]) "
            wp_sCmdSql += "INNER JOIN ILDMI1 T2 "
            wp_sCmdSql += "ON "
            wp_sCmdSql += "(T0.[sCodcmt] = T2.[sCodItm]) "
            wp_sCmdSql += "AND "
            wp_sCmdSql += "(T0.[sCodAlmCns] = T2.[sCodAlm]) "
            If vp_sCodDoc IsNot Nothing Then
                wp_sCmdSql += "WHERE "
                wp_sCmdSql += "T0.[sCodDoc] = '" & vp_sCodDoc & "' "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "T0.[nNroDoc] = " & vp_nNroDoc
            End If
            wp_sCmdSql += " ORDER BY T0.sCodDoc,  "
            wp_sCmdSql += " T0.nNroDoc, "
            wp_sCmdSql += " T0.sCodItm, "
            wp_sCmdSql += " T0.sCodCmt "

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPLODP1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLODP2(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByVal vp_sCodOpe As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from "
            wp_sCmdSql += " (PLODP2 T0"
            wp_sCmdSql += " INNER JOIN  ATOPE T1"
            wp_sCmdSql += " ON T0.sCodOpe = T1.sCodOpe)"
            wp_sCmdSql += " INNER JOIN  ATCTR T2"
            wp_sCmdSql += " ON T1.sCodCtr = T2.sCodCtr"
            If vp_sCodDoc IsNot Nothing Then

                wp_sCmdSql += wl_WHERE
                wp_sCmdSql += "T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "T0.nNroDoc = " & vp_nNroDoc
                wl_WHERE = " "
            End If
            If vp_sCodOpe IsNot Nothing Then
                If wl_WHERE <> " " Then
                    wp_sCmdSql += wl_WHERE
                Else
                    wp_sCmdSql += " AND "
                End If
                wp_sCmdSql += "T0.sCodOpe = '" & vp_sCodOpe & "' "
                wl_WHERE = " "
            End If
            wp_sCmdSql += " ORDER BY T0.sCodOpe "
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPLODP2")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLODP3(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from PLODP3 T0"
            If vp_sCodDoc IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN  ATCIF T1"
                wp_sCmdSql += " ON T0.sCodCIF = T1.sCodCIF "
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "T0.nNroDoc = " & vp_nNroDoc
            End If
            wp_sCmdSql += " ORDER BY T0.sCodCIF "
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPLODP3")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLODP4(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from PLODP4 T0"
            '            If vp_sCodDoc IsNot Nothing Or vp_nNroDoc > 0 Then
            If vp_nNroDoc > 0 Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "T0.nNroDoc = " & vp_nNroDoc
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPLODP4")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLODP5(ByVal vp_sCodDoc As String,
                                            ByVal vp_nNroDoc As Integer,
                                            ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = " SELECT * "
            wp_sCmdSql += " from "
            wp_sCmdSql += "( PLODP5 T0 "
            wp_sCmdSql += "INNER JOIN PLFOM5 T1 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0.[sCodCmt] = T1.[sCodItm] "
            wp_sCmdSql += " AND "
            wp_sCmdSql += "T0.[sCodAna] = T1.[sCodAna] "
            wp_sCmdSql += ") "
            wp_sCmdSql += "INNER JOIN ATANA T2 "
            wp_sCmdSql += "ON "
            wp_sCmdSql += "T1.[sCodAna] = T2.[sCodAna] "
            If vp_sCodDoc IsNot Nothing Then
                wp_sCmdSql += "WHERE "
                wp_sCmdSql += "T0.[sCodDoc] = '" & vp_sCodDoc & "' "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "T0.[nNroDoc] = " & vp_nNroDoc
            End If
            wp_sCmdSql += " ORDER BY T0.[sCodDoc],T0.[nNroDoc],T0.[sCodItm],T0.[sCodAna]"


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPLODP5")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConItmPLODP4(ByVal vp_sCodDoc As String,
                                     ByVal vp_nNroDoc As Integer,
                                     ByVal vp_sCodItm As String,
                                     ByVal wp_nNroReg As Integer,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql = "SELECT TOP " & wp_nNroReg
                wp_sCmdSql += " *"
                wp_sCmdSql += " from PLODP4 T0"
                wp_sCmdSql += " INNER JOIN PEODP T1 ON"
                wp_sCmdSql += " T0.sCodDoc = T1.sCodDoc AND T0.nNroDoc = T1.nNroDoc"
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodItm = '" & vp_sCodItm & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "T1.sEstOdp = '3' "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "T0.nNroDoc < " & vp_nNroDoc
                wp_sCmdSql += " ORDER BY T0.nNroDoc DESC"

            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConItmPLODP4")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPEODP_PLODP4(ByVal wl_ePEODP_PLODP4 As Object,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try

            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            Dim wl_dFecMDAIni As Date
            Dim wl_sFecMDAIni As String

            wl_dFecMDAIni = wl_ePEODP_PLODP4.dFecini
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)

            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from "
            wp_sCmdSql += " PEODP T0 "
            wp_sCmdSql += "INNER JOIN PLODP4 T1 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc AND "
            wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc "

            If wl_ePEODP_PLODP4.sCodDoc <> "" Then
                If wl_bIndWHERE = False Then
                    wp_sCmdSql += " WHERE "
                    wl_bIndWHERE = True
                End If
                wp_sCmdSql += "T0.sCodDoc = '" & wl_ePEODP_PLODP4.sCodDoc & "' "
                If wl_ePEODP_PLODP4.sCodDoc <> 0 Then
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc = " & wl_ePEODP_PLODP4.sCodDoc
                    vl_bIndAND = True
                End If
            End If

            If wl_ePEODP_PLODP4.sEstOdp <> "" Then
                If wl_ePEODP_PLODP4.sEstOdp <> "0" Then
                    If wl_ePEODP_PLODP4.sEstOdp Is Nothing Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wp_sCmdSql += " AND "
                            vl_bIndAND = True
                        End If
                    End If
                End If
                wp_sCmdSql += "T0.sEstOdp = '" & wl_ePEODP_PLODP4.sEstOdp & "'"
            End If

            '2018-08-03 Se incluye el filtro de las fechas
            If wl_sFecMDAIni <> Nothing Then
                If wl_bIndWHERE = False Then
                    wp_sCmdSql += " WHERE "
                    wl_bIndWHERE = True
                Else
                    wp_sCmdSql += " AND "
                    vl_bIndAND = True
                End If

                wp_sCmdSql += " T0.dFecEmi >= #" & wl_sFecMDAIni & "#"
            End If
            wp_sCmdSql += " ORDER BY T0.sCodDoc, T0.nNroDoc "

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConsultarPEODP")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPEODP_PLODP4_QGrl(ByVal wp_ePEODP_PLODP4 As Object,
                                             ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean


            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_ePEODP_PLODP4
                wp_sCmdSql = "SELECT "
                If .sCodDoc <> "" Then
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If

                If .nNroDoc <> 0 Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True
                End If

                If .sEstOdp <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstOdp "
                    wl_bComa = True
                End If
                If .sCodItm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T0.sNomItm"
                    wl_bComa = True
                End If
                If .dFecEmi <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecEmi "
                    wl_bComa = True
                End If
                If .dFecIni <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecIni "
                    wl_bComa = True
                End If
                If .dFecFin <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecFin "
                    wl_bComa = True
                End If


                wp_sCmdSql += " from "
                wp_sCmdSql += "( PEODP T0 "
                wp_sCmdSql += "INNER JOIN PLODP4 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc AND "
                wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc )"


                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodDoc = '" & .sCodDoc & "' "
                        wl_WHERE = ""
                    End If

                End If
                If .nNroDoc <> 0 Then
                    If .nNroDoc <> -1 Then


                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc
                    End If
                End If
                If .sCodSer <> "" Then
                    If .sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer = '" & .scodser & "'"
                    End If

                End If
                If .sEstOdp <> "" Then
                    If .sEstOdp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstOdp = '" & .sEstOdp & "'"
                    End If

                End If

                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += "T0.sCodItm = '" & .sCodItm & "' "

                    End If
                End If

                If .dFecEmi <> Nothing Then
                    If .dFecEmi <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecEmi = #" & .dFecEmi & "# "
                    End If

                End If

                If .dFecIni <> Nothing Then
                    If .dFecIni <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecIni = #" & .dFecIni & "# "
                    End If

                End If
                If .dFecFin <> Nothing Then
                    If .dFecFin <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecFin = #" & .dFecFin & "# "
                    End If

                End If
                wl_bComa = False
                wp_sCmdSql += " GROUP BY "

                If .sCodDoc <> "" Then
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If

                If .nNroDoc <> 0 Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True


                End If

                If .sEstOdp <> "" Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstOdp "
                    wl_bComa = True
                End If
                If .sCodItm <> "" Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T0.sNomItm"
                    wl_bComa = True
                End If
                If .dFecEmi <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecEmi "
                    wl_bComa = True
                End If
                If .dFecIni <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecIni "
                    wl_bComa = True
                End If
                If .dFecFin <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecFin "
                    wl_bComa = True
                End If

                '   wp_sCmdSql += " GROUP BY T0.sCodItm,T1.sNomItm"

            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConPEODP_PLODP4_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPEODP_PLODP4_QIniFin(ByVal wp_ePEODP_PLODP4_Ini As Object,
                                                ByVal wp_ePEODP_PLODP4_Fin As Object,
                                                ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean
            Dim wl_ORDER_BY As String
            Dim wl_dFecMDA As String
            Dim wl_dFecDMA As String

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_ORDER_BY = " ORDER BY "
            wl_bComa = False
            With wp_ePEODP_PLODP4_Ini
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " from "
                wp_sCmdSql += "( "
                wp_sCmdSql += "PEODP T0 "
                wp_sCmdSql += "INNER JOIN PLODP4 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc AND "
                wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc )"

                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodDoc >= '" & .sCodDoc & "' "
                        wl_WHERE = ""
                    End If
                End If
                If wp_ePEODP_PLODP4_Fin.sCodDoc <> "" Then
                    If wp_ePEODP_PLODP4_Fin.sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc <= '" & wp_ePEODP_PLODP4_Fin.sCodDoc & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .nNroDoc <> 0 Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.nNroDoc >= " & .nNroDoc
                End If
                If wp_ePEODP_PLODP4_Fin.nNroDoc <> 0 Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.nNroDoc <= " & wp_ePEODP_PLODP4_Fin.nNroDoc
                End If
                If .sCodSer <> "" Then
                    If .sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer >= '" & .scodser & "'"
                    End If
                End If
                If wp_ePEODP_PLODP4_Fin.sCodSer <> "" Then
                    If wp_ePEODP_PLODP4_Fin.sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer <= '" & wp_ePEODP_PLODP4_Fin.scodser & "'"
                    End If
                End If
                If .sEstOdp <> "" Then
                    If .sEstOdp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstOdp >= '" & .sEstOdp & "'"
                    End If
                End If
                If wp_ePEODP_PLODP4_Fin.sEstOdp <> "" Then
                    If wp_ePEODP_PLODP4_Fin.sEstOdp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstOdp <= '" & wp_ePEODP_PLODP4_Fin.sEstOdp & "'"
                    End If
                End If
                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += "T0.sCodItm >= '" & .sCodItm & "' "

                    End If
                End If
                If wp_ePEODP_PLODP4_Fin.sCodItm <> "" Then
                    If wp_ePEODP_PLODP4_Fin.sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += "T0.sCodItm <= '" & wp_ePEODP_PLODP4_Fin.sCodItm & "' "
                    End If
                End If

                wl_dFecMDA = .dFecEmi
                wl_dFecDMA = cdf_dDMY_MDY(wl_dFecMDA)

                If wl_dFecDMA <> Nothing Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.dFecEmi >= #" & wl_dFecDMA & "# "
                End If

                wl_dFecMDA = wp_ePEODP_PLODP4_Fin.dFecEmi
                wl_dFecDMA = cdf_dDMY_MDY(wl_dFecMDA)


                If wl_dFecDMA <> Nothing Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.dFecEmi <= #" & wl_dFecDMA & "# "
                End If

                If .dFecIni <> Nothing Then
                    If .dFecIni <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecIni >= #" & .dFecIni & "# "
                    End If
                End If
                If wp_ePEODP_PLODP4_Fin.dFecIni <> Nothing Then
                    If wp_ePEODP_PLODP4_Fin.dFecIni <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecIni <= #" & wp_ePEODP_PLODP4_Fin.dFecIni & "# "
                    End If
                End If
                If .dFecFin <> Nothing Then
                    If .dFecFin <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecFin >= #" & .dFecFin & "# "
                    End If
                End If
                If wp_ePEODP_PLODP4_Fin.dFecFin <> Nothing Then
                    If wp_ePEODP_PLODP4_Fin.dFecFin <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecFin <= #" & wp_ePEODP_PLODP4_Fin.dFecFin & "# "
                    End If
                End If
                If wl_WHERE = "" Then
                    wl_bComa = False
                    If .sCodDoc <> "" Then
                        wp_sCmdSql += wl_ORDER_BY
                        wp_sCmdSql += "T0.sCodDoc "
                        wl_ORDER_BY = ""
                        wl_bComa = True
                    End If
                    If .sCodSer <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.sCodSer "
                        wl_bComa = True
                    End If
                    If .nNroDoc <> 0 Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.nNroDoc "
                        wl_bComa = True
                    End If
                    If .sCodItm <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.sCodItm "
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
            MsgBox("Error : cldPEODP.cddtConPEODP_PLODP4_QIniFin")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPEODP_QGrl(ByVal wp_ePEODP As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean


            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_ePEODP
                wp_sCmdSql = "SELECT "
                If .sCodDoc <> "" Then
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If

                If .nNroDoc <> 0 Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True
                End If

                If .sEstOdp <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstOdp "
                    wl_bComa = True
                End If
                If .sCodItm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T1.sNomItm"
                    wl_bComa = True
                End If
                If .dFecEmi <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecEmi "
                    wl_bComa = True
                End If
                If .dFecIni <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecIni "
                    wl_bComa = True
                End If
                If .dFecFin <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecFin "
                    wl_bComa = True
                End If


                wp_sCmdSql += " from "
                wp_sCmdSql += "( PEODP T0 "
                wp_sCmdSql += "INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCoditm = T1.sCodItm) "
                wp_sCmdSql += "INNER JOIN ILDMI1 T2 "
                wp_sCmdSql += "ON "
                wp_sCmdSql += "(T0.[sCoditm] = T2.[sCodItm]) "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "(T0.[sCodAlm] = T2.[sCodAlm]) "
                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodDoc = '" & .sCodDoc & "' "
                        wl_WHERE = ""
                    End If

                End If
                If .nNroDoc <> 0 Then
                    If .nNroDoc <> -1 Then


                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc
                    End If
                End If
                If .sCodSer <> "" Then
                    If .sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer = '" & .scodser & "'"
                    End If

                End If
                If .sEstOdp <> "" Then
                    If .sEstOdp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstOdp = '" & .sEstOdp & "'"
                    End If

                End If

                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += "T0.sCodItm = '" & .sCodItm & "' "

                    End If
                End If

                If .dFecEmi <> Nothing Then
                    If .dFecEmi <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecEmi = #" & .dFecEmi & "# "
                    End If

                End If

                If .dFecIni <> Nothing Then
                    If .dFecIni <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecIni = #" & .dFecIni & "# "
                    End If

                End If
                If .dFecFin <> Nothing Then
                    If .dFecFin <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecFin = #" & .dFecFin & "# "
                    End If

                End If
                wl_bComa = False
                wp_sCmdSql += " GROUP BY "

                If .sCodDoc <> "" Then
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If

                If .nNroDoc <> 0 Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True


                End If

                If .sEstOdp <> "" Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstOdp "
                    wl_bComa = True
                End If
                If .sCodItm <> "" Then

                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T1.sNomItm"
                    wl_bComa = True
                End If
                If .dFecEmi <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecEmi "
                    wl_bComa = True
                End If
                If .dFecIni <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecIni "
                    wl_bComa = True
                End If
                If .dFecFin <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.dFecFin "
                    wl_bComa = True
                End If

                '   wp_sCmdSql += " GROUP BY T0.sCodItm,T1.sNomItm"

            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cddtConPEODP_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConPEODP_QIniFin(ByVal wp_ePEODP_Ini As Object,
                                         ByVal wp_ePEODP_Fin As Object,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean
            Dim wl_ORDER_BY As String
            Dim wl_dFecMDA As String
            Dim wl_dFecDMA As String

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_ORDER_BY = " ORDER BY "
            wl_bComa = False
            With wp_ePEODP_Ini
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " from "
                'wp_sCmdSql += "( "
                wp_sCmdSql += "PEODP T0 "
                'wp_sCmdSql += "INNER JOIN IEDMI T1 "
                'wp_sCmdSql += " ON "
                'wp_sCmdSql += "T0.sCoditm = T1.sCodItm) "
                'wp_sCmdSql += "INNER JOIN ILDMI1 T2 "
                'wp_sCmdSql += "ON "
                'wp_sCmdSql += "(T0.[sCoditm] = T2.[sCodItm]) "
                'wp_sCmdSql += "AND "
                'wp_sCmdSql += "(T0.[sCodAlm] = T2.[sCodAlm]) "
                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodDoc >= '" & .sCodDoc & "' "
                        wl_WHERE = ""
                    End If
                End If
                If wp_ePEODP_Fin.sCodDoc <> "" Then
                    If wp_ePEODP_Fin.sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc <= '" & wp_ePEODP_Fin.sCodDoc & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .nNroDoc <> 0 Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.nNroDoc >= " & .nNroDoc
                End If
                If wp_ePEODP_Fin.nNroDoc <> 0 Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.nNroDoc <= " & wp_ePEODP_Fin.nNroDoc
                End If
                If .sCodSer <> "" Then
                    If .sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer >= '" & .scodser & "'"
                    End If
                End If
                If wp_ePEODP_Fin.sCodSer <> "" Then
                    If wp_ePEODP_Fin.sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer <= '" & wp_ePEODP_Fin.scodser & "'"
                    End If
                End If
                If .sEstOdp <> "" Then
                    If .sEstOdp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstOdp >= '" & .sEstOdp & "'"
                    End If
                End If
                If wp_ePEODP_Fin.sEstOdp <> "" Then
                    If wp_ePEODP_Fin.sEstOdp <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstOdp <= '" & wp_ePEODP_Fin.sEstOdp & "'"
                    End If
                End If
                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += "T0.sCodItm >= '" & .sCodItm & "' "

                    End If
                End If
                If wp_ePEODP_Fin.sCodItm <> "" Then
                    If wp_ePEODP_Fin.sCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += "T0.sCodItm <= '" & wp_ePEODP_Fin.sCodItm & "' "
                    End If
                End If

                wl_dFecMDA = .dFecEmi
                wl_dFecDMA = cdf_dDMY_MDY(wl_dFecMDA)

                If wl_dFecDMA <> Nothing Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.dFecEmi >= #" & wl_dFecDMA & "# "
                End If

                wl_dFecMDA = wp_ePEODP_Fin.dFecEmi
                wl_dFecDMA = cdf_dDMY_MDY(wl_dFecMDA)


                If wl_dFecDMA <> Nothing Then
                    If wl_WHERE <> "" Then
                        wp_sCmdSql += wl_WHERE
                        wl_WHERE = ""
                    Else
                        wp_sCmdSql += wl_AND
                    End If
                    wp_sCmdSql += " T0.dFecEmi <= #" & wl_dFecDMA & "# "
                End If

                If .dFecIni <> Nothing Then
                    If .dFecIni <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecIni >= #" & .dFecIni & "# "
                    End If
                End If
                If wp_ePEODP_Fin.dFecIni <> Nothing Then
                    If wp_ePEODP_Fin.dFecIni <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecIni <= #" & wp_ePEODP_Fin.dFecIni & "# "
                    End If
                End If
                If .dFecFin <> Nothing Then
                    If .dFecFin <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecFin >= #" & .dFecFin & "# "
                    End If
                End If
                If wp_ePEODP_Fin.dFecFin <> Nothing Then
                    If wp_ePEODP_Fin.dFecFin <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.dFecFin <= #" & wp_ePEODP_Fin.dFecFin & "# "
                    End If
                End If
                If wl_WHERE = "" Then
                    wl_bComa = False
                    If .sCodDoc <> "" Then
                        wp_sCmdSql += wl_ORDER_BY
                        wp_sCmdSql += "T0.sCodDoc "
                        wl_ORDER_BY = ""
                        wl_bComa = True
                    End If
                    If .sCodSer <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.sCodSer "
                        wl_bComa = True
                    End If
                    If .nNroDoc <> 0 Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.nNroDoc "
                        wl_bComa = True
                    End If
                    If .sCodItm <> "" Then
                        If wl_ORDER_BY <> "" Then
                            wp_sCmdSql += wl_ORDER_BY
                            wl_ORDER_BY = ""
                        End If
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.sCodItm "
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
            MsgBox("Error : cldPEODP.cddtConPEODP_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region
#Region "U - Actualizar"
    Public Function cdActCnsCIFPLODP4(ByVal wp_ePLROP1 As Object,
                                     ByVal wr_bEOFL1 As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            Dim vl_nVlrCns As Double
            Dim vl_nVlrTotCns As Double
            Dim vl_sCodDocBas As String
            Dim vl_nNroDocBas As Long
            Dim wl_DT1 As New DataTable
            Dim wl_bEOF As Boolean

            wl_YesNo = True
            With wp_ePLROP1
                vl_sCodDocBas = .sCodDocBas
                vl_nNroDocBas = .nNroDocBas
            End With
            wl_bEOF = False
            wl_DT1 = cddtConsultarPLODP3(vl_sCodDocBas,
                                         vl_nNroDocBas,
                                         wl_bEOF)
            If wl_bEOF = True Then
                wl_YesNo = False
                Return wl_YesNo
                Exit Function
            End If
            vl_nVlrCns = 0
            vl_nVlrTotCns = 0
            For wl_i = 0 To wl_DT.Rows.Count - 1
                vl_nVlrCns = vl_nVlrCns + wl_DT.Rows(wl_i).Item("nVlrCns")
                vl_nVlrTotCns = vl_nVlrTotCns + wl_DT.Rows(wl_i).Item("nVlrTotCns")
            Next
            '  vl_nVlrCns = vl_nVlrCns / 60

            With wp_ePLROP1
                'wl_nVlrCns = Int(.nTieCns) * 60 + (.nTieCns - Int(.nTieCns)) * 60
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP4 T0 "
                wp_sCmdSql += " SET "
                '  If .sTipMov = "S" Then
                'S - Salida de inventarios, aumenta consumo
                wp_sCmdSql += "nTotTasCnsCIF  = " & vl_nVlrCns & ", "
                wp_sCmdSql += "nVlrTotCnsCIF  =  " & vl_nVlrTotCns
                ' Else
                'E - Entrada de inventarios, disminuye consumo
                '  wp_sCmdSql += "nTotTieCnsMOD  = nTotTieCnsMOD - " & wl_nTieCns & ", "
                'wp_sCmdSql += "nTotTasCnsCIF  = nTotTasCnsCIF - " & vl_nVlrCns & ", "
                'wp_sCmdSql += "nVlrTotCnsCIF  = nVlrTotCnsCIF - " & vl_nVlrTotCns
                'End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsCIFPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActCnsMODPLODP4(ByVal wp_ePLROP1 As Object,
                                      ByVal wr_bEOFL1 As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            Dim wl_nTieCns As Double
            wl_YesNo = True
            With wp_ePLROP1
                'wl_nTieCns = Int(.nTieCns) * 60 + (.nTieCns - Int(.nTieCns)) * 60
                wl_nTieCns = .nTieCns
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP4 "
                wp_sCmdSql += " SET "
                If .sTipMov = "S" Then
                    'S - Salida de inventarios, aumenta consumo
                    wp_sCmdSql += "nTotTieCnsMOD  = nTotTieCnsMOD + " & wl_nTieCns & ", "
                    wp_sCmdSql += "nVlrTotCnsMOD  = nVlrTotCnsMOD + " & .nTotLin
                Else
                    'E - Entrada de inventarios, disminuye consumo
                    wp_sCmdSql += "nTotTieCnsMOD  = nTotTieCnsMOD - " & wl_nTieCns & ", "
                    wp_sCmdSql += "nVlrTotCnsMOD  = nVlrTotCnsMOD - " & .nTotLin
                End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas

                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsMODPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActCnsMPDPLODP4(ByVal wl_eILMOV1 As Object,
                                      ByVal wr_bEOFL1 As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True



            With wl_eILMOV1
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP4 "
                wp_sCmdSql += " SET "
                If .sTipMov = "S" Then
                    'S - Salida de inventarios, aumenta consumo
                    wp_sCmdSql += "nVlrTotCnsMPD  = nVlrTotCnsMPD + " & .nTotLin & ", "
                    wp_sCmdSql += "nVrcTotMPD  = nVlrTotCnsMPD - nVlrTotReqMPD + " & .nTotLin
                Else
                    'E - Entrada de inventarios, disminuye consumo
                    wp_sCmdSql += "nVlrTotCnsMPD  = nVlrTotCnsMPD - " & .nTotLin & ", "
                    wp_sCmdSql += "nVrcTotMPD  = nVlrTotCnsMPD + nVlrTotReqMPD - " & .nTotLin
                End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActCnsPLODP1(ByVal wl_eILMOV1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wl_eILMOV1
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP1 "
                wp_sCmdSql += " SET "
                If .sTipMov = "S" Then
                    'S - Salida de inventarios, aumenta consumo
                    If .sUniMedInv = "gr" Then
                        wp_sCmdSql += "nCanCns     = nCanCns + " & .nCanItm / 1000 & ", "
                    Else
                        wp_sCmdSql += "nCanCns     = nCanCns + " & .nCanItm & ", "
                    End If

                    wp_sCmdSql += "nVlrTotCns  = nVlrTotCns + " & .nTotLin
                Else
                    'E - Entrada de inventarios, disminuye consumo
                    '                    wp_sCmdSql += "nCanCns     = nCanCns - " & .nCanItm & ", "

                    If .sUniMedInv = "gr" Then
                        wp_sCmdSql += "nCanCns     = nCanCns - " & .nCanItm / 1000 & ", "
                    Else
                        wp_sCmdSql += "nCanCns     = nCanCns - " & .nCanItm & ", "
                    End If

                    wp_sCmdSql += "nVlrTotCns  = nVlrTotCns - " & .nTotLin
                End If
                '   wp_sCmdSql += "nVrcCan = nCanCns - nCanReq,  "
                '  wp_sCmdSql += "nVlrVrcCan = nVrcCan *  nPreUni,"
                ' wp_sCmdSql += "nPorVrnCan = IIF( nCanReq <> 0,((nCanCns /  nCanReq ) - 1) * 100,0) "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += " and "
                wp_sCmdSql += "sCodCmt     = '" & .sCodItm & "')"
                'wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

                wl_YesNo = False
                wp_sCmdSql = "Update PLODP1 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nVrcCan = nCanCns - nCanReq  "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += " and "
                wp_sCmdSql += "sCodCmt     = '" & .sCodItm & "')"
                'wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


                wl_YesNo = False
                wp_sCmdSql = "Update PLODP1 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nVlrVrcCan = nVrcCan *  nPreUni,"
                wp_sCmdSql += "nPorVrnCan = IIF( nCanReq <> 0,((nCanCns /  nCanReq ) - 1) * 100,0) "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += " and "
                wp_sCmdSql += "sCodCmt     = '" & .sCodItm & "')"
                'wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsPLODP1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActCnsPLODP2(ByVal wl_ePLROP1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try
            Dim wl_nTieCns As Double
            wl_YesNo = True
            With wl_ePLROP1
                wl_YesNo = False
                ' wl_nTieCns = Int(.nTieCns) * 60 + (.nTieCns - Int(.nTieCns)) * 60
                wl_nTieCns = .nTieCns
                wp_sCmdSql = "Update PLODP2 "
                wp_sCmdSql += " SET "
                If .sTipMov = "S" Then
                    'S - Salida de inventarios, aumenta consumo
                    wp_sCmdSql += "nTieCns     = nTieCns + " & wl_nTieCns & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nVlrTotCns  = nVlrTotCns + " & .nTotLin
                Else
                    'E - Entrada de inventarios, disminuye consumo
                    wp_sCmdSql += "nTieCns     = nTieCns - " & wl_nTieCns & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nVlrTotCns  = nVlrTotCns - " & .nTotLin
                End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc      = " & .nNroDocBas
                wp_sCmdSql += " and "
                wp_sCmdSql += "sCodOpe      ='" & .sCodOpe & "'"
                wp_sCmdSql += ")"

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsPLODP2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActCnsPLODP3(ByVal wl_ePLROP1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try
            Dim wl_nTieCns As Double
            wl_YesNo = True
            With wl_ePLROP1
                wl_YesNo = False
                '  wl_nTieCns = Int(.nTieCns) * 60 + (.nTieCns - Int(.nTieCns)) * 60
                wl_nTieCns = .nTieCns
                wp_sCmdSql = "Update PLODP3 "
                wp_sCmdSql += " SET "
                If .sTipMov = "S" Then
                    'S - Salida de inventarios, aumenta consumo
                    wp_sCmdSql += "nVlrCns     = nVlrCns + " & wl_nTieCns & ", "
                    wp_sCmdSql += "nVlrTotCns  = nVlrTotCns + " & wl_nTieCns & " * nVlrCIFRea "
                Else
                    'E - Entrada de inventarios, disminuye consumo
                    wp_sCmdSql += "nVlrCns     = nVlrCns - " & wl_nTieCns & ", "
                    wp_sCmdSql += "nVlrTotCns  = nVlrTotCns - " & wl_nTieCns & " * nVlrCIFRea "
                End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc      = " & .nNroDocBas
                wp_sCmdSql += ")"

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsPLODP3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActPorOpeCnsPLODP2(ByVal wp_ePLROP1 As Object,
                                         ByVal wr_bEOFL1 As Boolean) As Boolean
        Try
            Dim vl_nTotTieCnsMOD As Double
            Dim vl_sCodDocBas As String
            Dim vl_nNroDocBas As Long
            Dim wl_DT1 As New DataTable
            Dim wl_bEOF As Boolean


            wl_YesNo = True
            vl_nTotTieCnsMOD = 0
            With wp_ePLROP1
                vl_sCodDocBas = .sCodDocBas
                vl_nNroDocBas = .nNroDocBas
            End With
            wl_bEOF = False
            wl_DT1 = cddtConsultarPLODP4(vl_sCodDocBas,
                                         vl_nNroDocBas,
                                         wl_bEOF)

            If wl_bEOF = True Then
                wl_YesNo = False
                Return wl_YesNo
                Exit Function
            End If

            vl_nTotTieCnsMOD = wl_DT.Rows(0).Item("nTotTieCnsMOD")
            wl_YesNo = True

            If vl_nTotTieCnsMOD > 0 Then
                With wp_ePLROP1
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLODP2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nPorOpeCns     = nTieCns / " & vl_nTotTieCnsMOD & " * 100"
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "nNroDoc      = " & .nNroDocBas
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End With
                With wp_ePLROP1
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLODP2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nVrcPorOpe     = nPorOpeCns - nPorOpeReq"
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "nNroDoc      = " & .nNroDocBas
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End With
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActCnsPLODP2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActEDPPEODP(ByVal wl_eILMOV1 As Object,
                                  ByVal wr_bEOFL1 As Boolean,
                                  ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wl_eILMOV1
                wl_YesNo = False
                wp_sCmdSql = "Update PEODP "
                wp_sCmdSql += " SET "
                If .sTipMov = "E" Then
                    'E - Entrada de inventarios, aumenta la producción
                    wp_sCmdSql += "nCanUniEdp     = nCanUniEdp + " & .nCanItm
                Else
                    'S - Salida de inventarios, dismunuye la producción
                    wp_sCmdSql += "nCanUniEdp     = nCanUniEdp - " & .nCanItm
                End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActEDPPEODP")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActEDPPLODP4(ByVal wl_eILMOV1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wl_eILMOV1
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP4 "
                wp_sCmdSql += " SET "
                If .sTipMov = "E" Then
                    'E - Entrada de inventarios, aumenta la producción

                    wp_sCmdSql += "nCanUniEdp  = nCanUniEdp + " & .nCanItm & " ,"
                    wp_sCmdSql += "nTotUniCns  = nTotUniCns + " & .nCanItm
                Else
                    'S - Salida de inventarios, dismunuye la producción
                    wp_sCmdSql += "nCanUniEdp  = nCanUniEdp - " & .nCanItm & " ,"
                    wp_sCmdSql += "nTotUniCns  = nTotUniCns - " & .nCanItm
                End If
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodDoc     = '" & .sCodDocBas & "'"
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc     = " & .nNroDocBas
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActEDPPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdRecalPLODP4(ByVal vp_sCodDoc As String,
                                  ByVal vp_nNroDoc As Long) As Boolean
        Try
            wl_YesNo = True
            wl_YesNo = False
            wp_sCmdSql = "Update PLODP4 "
            wp_sCmdSql += " SET "
            wp_sCmdSql += " nVrcCan  = nCanUniOdp - nCanUniEdp,"
            wp_sCmdSql += " nVrcTotMPD  = nVlrTotCnsMPD - nVlrTotReqMPD,"
            wp_sCmdSql += " nVrcTieMOD  = nTotTieCnsMOD - nTotTieReqMOD,"
            wp_sCmdSql += " nVrcTasCIF  = nTotTasCnsCIF - nTotTasReqCIF,"
            wp_sCmdSql += " nVrcTotMOD  = nVlrTotCnsMOD - nVlrTotReqMOD,"
            wp_sCmdSql += " nVrcTotCIF  = nVlrTotCnsCIF - nVlrTotReqCIF,"
            wp_sCmdSql += " nCosTotReq  = nVlrTotReqMPD + nVlrTotReqMOD + nVlrTotReqCIF,"
            wp_sCmdSql += " nCosTotCns  = nVlrTotCnsMPD + nVlrTotCnsMOD + nVlrTotCnsCIF,"
            wp_sCmdSql += " nVrcUni     = nTotUniReq - nTotUniCns "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodDoc     = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " and "
            wp_sCmdSql += "nNroDoc     = " & vp_nNroDoc
            wp_sCmdSql += ")"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Update PLODP4 "
            wp_sCmdSql += " SET "
            wp_sCmdSql += " nCosUniReq  = IIF(nTotUniReq <> 0, (nCosTotReq / nTotUniReq),0), "
            wp_sCmdSql += " nCosUniCns  = IIF(nCanUniEdp <> 0, (nCosTotCns / nCanUniEdp),0) "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodDoc     = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " and "
            wp_sCmdSql += "nNroDoc     = " & vp_nNroDoc
            wp_sCmdSql += ")"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Update PLODP4 "
            wp_sCmdSql += " SET "
            wp_sCmdSql += " nVrcCosTot  = nCosTotCns - nCosTotReq,"
            wp_sCmdSql += " nVrcCosUni  = nCosUniCns - nCosUniReq "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodDoc     = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " and "
            wp_sCmdSql += "nNroDoc     = " & vp_nNroDoc
            wp_sCmdSql += ")"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdActEDPPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
#End Region
#Region "D - Eliminar"
    Public Function cdEliminar(ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByVal vp_sCodSer As String,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  PLODP1 "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLODP2 "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLODP3 "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


            wp_sCmdSql = "Delete * from  PLODP4 "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


            wp_sCmdSql = "Delete * from  PLODP5 "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PEODP "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdEliminar")
            Throw ex

        End Try
        Return wl_YesNo

    End Function
    Public Function cdEliminarPLODP1(ByVal wp_ePLODP1 As Object,
                                       ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLODP1
                wp_sCmdSql = "Delete * from  PLODP1 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nNroDoc =        " & .nNroDoc
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodCmt =        '" & .sCodCmt & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdEliminarPLODP1")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLODP2(ByVal wp_ePLODP2 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLODP2
                wp_sCmdSql = "Delete * from  PLODP2 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nNroDoc =        " & .nNroDoc
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodOpe =        '" & .sCodOpe & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdEliminarPLODP2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliminarPLODP3(ByVal wp_ePLODP3 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLODP3
                wp_sCmdSql = "Delete * from  PLODP3 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nNroDoc =        " & .nNroDoc
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodCIF =        '" & .sCodCIF & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdEliminarPLODP3")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLODP4(ByVal wp_ePLODP4 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean

        Try
            wl_YesNo = False
            With wp_ePLODP4
                wp_sCmdSql = "Delete * from  PLODP4 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nNroDoc =        " & .nNroDoc
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodCmt =        '" & .sCodCmt & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodAna =        '" & .sCodAna & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdEliminarPLODP4")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLODP5(ByVal wp_ePLODP5 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            With wp_ePLODP5
                wl_YesNo = False
                wp_sCmdSql = "Delete * from  PLODP5 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodDoc =        '" & .sCodDoc & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "nNroDoc =        " & .nNroDoc
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodCmt =        '" & .sCodCmt & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodAna =        '" & .sCodAna & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdEliminarPLODP5")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
#End Region
       
     
End Class
