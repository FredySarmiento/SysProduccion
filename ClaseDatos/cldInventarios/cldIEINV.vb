Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldIEINV
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim cldIEDMI As New cldIEDMI
#Region "C - Crear"
    Public Function cdCrearActualizar(ByVal wp_sNomTbl As String,
                                      ByVal wr_eGEMOV As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            Dim vl_sFecCtb As String
            Dim vl_sFecDoc As String
            Dim vl_sFecSys As String
            Dim vl_sFecVto As String
            wl_YesNo = True
            With wr_eGEMOV
                vl_sFecCtb = cdf_dDMY_MDY(.dFecCtb)
                vl_sFecDoc = cdf_dDMY_MDY(.dFecDoc)
                vl_sFecSys = cdf_dDMY_MDY(.dFecSys)
                vl_sFecVto = cdf_dDMY_MDY(.dFecVto)
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into "
                    wp_sCmdSql += wp_sNomTbl
                    wp_sCmdSql += " (sCodDoc , " '1
                    wp_sCmdSql += " nNroDoc) " '2
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodDoc & "', "
                    wp_sCmdSql += .nNroDoc & " )"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update "
                wp_sCmdSql += wp_sNomTbl
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sCodSer  = '" & .sCodSer & "',"
                wp_sCmdSql += "sCodTra  = '" & .sCodTra & "',"
                wp_sCmdSql += "sEstDoc     = '" & .sEstDoc & "', " ' 5
                wp_sCmdSql += "sTipMov     = '" & .sTipMov & "', "
                wp_sCmdSql += "dFecCtb     =  #" & vl_sFecCtb & "# , "
                wp_sCmdSql += "dFecDoc     =  #" & vl_sFecDoc & "#, "
                wp_sCmdSql += "dFecVto     =  #" & vl_sFecVto & "#, "
                wp_sCmdSql += "dFecSys     =  #" & vl_sFecSys & "#, " '10
                wp_sCmdSql += "sCodTer     = '" & .sCodTer & "', "
                wp_sCmdSql += "sNomTer     = """ & .sNomTer & """, "
                wp_sCmdSql += "nPorDto     = " & .nPorDto & ", "
                wp_sCmdSql += "sAlmOri     = '" & .sAlmOri & "', "
                wp_sCmdSql += "sDocRef     = '" & .sDocRef & "', " '15
                wp_sCmdSql += "nTotBas    = " & .nTotBas & ", "
                wp_sCmdSql += "nTotDto    = " & .nTotDto & ", "
                wp_sCmdSql += "nTotGtoAdi    = " & .nTotGtoAdi & ", "
                wp_sCmdSql += "nTotIvaCom    = " & .nTotIvaCom & ", "
                wp_sCmdSql += "nTotIvaVta    = " & .nTotIvaVta & ", " '20
                wp_sCmdSql += "nVlrRdd    = " & .nVlrRdd & ", "
                wp_sCmdSql += "nTotDoc     = " & .nTotDoc & ", "
                wp_sCmdSql += "sCodDocBas  = '" & .sCodDocBas & "', "
                wp_sCmdSql += "nNroDocBas  = " & .nNroDocBas & ", "
                wp_sCmdSql += "sCndPag  = '" & .sCndPag & "', " '25
                wp_sCmdSql += "sClsDoc  = '" & .sClsDoc & "', "
                wp_sCmdSql += "sTipDoc  = '" & .sTipDoc & "', "
                wp_sCmdSql += "sCodVen  = '" & .sCodVen & "' ,"
                wp_sCmdSql += "sDirTer  = '" & .sDirTer & "',"
                wp_sCmdSql += "sCiuTer  = '" & .sCiuter & "'," '30
                wp_sCmdSql += "sDepTer  = '" & .sDepTer & "',"
                wp_sCmdSql += "sPaiTer  = '" & .sPaiTer & "',"
                wp_sCmdSql += "sCmn     = '" & .sCmn & "', "
                wp_sCmdSql += "sCodCteCtb  = '" & .sCodCteCtb & "', "
                wp_sCmdSql += "nNroCteCtb  = " & .nNroCteCtb & " , " '35
                wp_sCmdSql += "nIdFECCT  = " & .nIdFECCT & ","
                wp_sCmdSql += "sNitTer  = '" & .sNitTer & "', "
                wp_sCmdSql += "sCodMon  = '" & .sCodMon & "', "
                wp_sCmdSql += "sCodUsr  = '" & .sCodUsr & "',"
                wp_sCmdSql += "sCodAut  = '" & .sCodAut & "'" '40
                wp_sCmdSql += "  where "
                wp_sCmdSql += "( "
                wp_sCmdSql += "sCodDoc = '" & .sCodDoc & "' "
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc = " & .nNroDoc
                wp_sCmdSql += ") "
            End With
            ' Ini 2018-07-13
            If wl_YesNo Then
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If
            ' fin 2018-07-13
        Catch ex As Exception
            MsgBox("Error: cldIEINV.cdCrearActualizar ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActILMOV1(ByVal wp_sNomTbl As String,
                                     ByVal wr_eGLMOV1 As Object,
                                     ByVal wp_sCmdSel As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = ""
            With wr_eGLMOV1
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into "
                    wp_sCmdSql += wp_sNomTbl
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc, " '1
                    wp_sCmdSql += "nNroDoc, " '2
                    wp_sCmdSql += "sTipMov, " '3
                    wp_sCmdSql += "sCodSer, " '4
                    wp_sCmdSql += "sCodDocBas, " '5
                    wp_sCmdSql += "sCodSerBas, " '6
                    wp_sCmdSql += "nNroDocBas, " '7
                    wp_sCmdSql += "sCodItm, " '8
                    wp_sCmdSql += "sNomItm, "
                    wp_sCmdSql += "sNomAlt," '10
                    wp_sCmdSql += "sCodAlm, "
                    wp_sCmdSql += "nCanItm, "
                    wp_sCmdSql += "sUniMedInv, "
                    wp_sCmdSql += "nPreUni, "
                    wp_sCmdSql += "nVlrBas, " '15
                    wp_sCmdSql += "nPorDto, "
                    wp_sCmdSql += "nVlrDto, "
                    wp_sCmdSql += "nPreDto, "
                    wp_sCmdSql += "nVlrDtoLin, "
                    wp_sCmdSql += "sCodIva, " '20
                    wp_sCmdSql += "nPorIva, "
                    wp_sCmdSql += "nVlrIva, "
                    wp_sCmdSql += "nVlrIvaLin, "
                    wp_sCmdSql += "nPreBru, "
                    wp_sCmdSql += "nTotLin, " '25 
                    wp_sCmdSql += "nPorCms, "
                    wp_sCmdSql += "sCodCco, "
                    wp_sCmdSql += "sTipLIM, "
                    wp_sCmdSql += "sCodVen, "
                    wp_sCmdSql += "nLinBas, "
                    wp_sCmdSql += "sCodPdo, " '30
                    wp_sCmdSql += "sCodCta, "
                    wp_sCmdSql += "bSolIto, "
                    wp_sCmdSql += "sCtaCosVta, "
                    wp_sCmdSql += "bItmBlq, "
                    wp_sCmdSql += "sClsDoc,"
                    wp_sCmdSql += "nTasCamUsd,"
                    wp_sCmdSql += "nPreUniUsd,"
                    wp_sCmdSql += "nVlrBasUsd,"
                    wp_sCmdSql += "sCodRch," '
                    wp_sCmdSql += "sNroLot," '
                    wp_sCmdSql += "nSdoCanLin, "
                    wp_sCmdSql += "nPesProm "
                    wp_sCmdSql += " ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "' , " '1
                    wp_sCmdSql += .nNroDoc & " , " '2
                    wp_sCmdSql += "'" & .sTipMov & "' , " '3
                    wp_sCmdSql += "'" & .sCodSer & "'," '4
                    wp_sCmdSql += "'" & .sCodDocBas & "', " '5
                    wp_sCmdSql += "'" & .sCodSerBas & "', "
                    wp_sCmdSql += .nNroDocBas & ", "
                    wp_sCmdSql += "'" & .sCodItm & "' ,"
                    wp_sCmdSql += """" & .sNomItm & """, "
                    wp_sCmdSql += """" & .sNomAlt & """, " '10
                    wp_sCmdSql += "'" & .sCodalm & "', "
                    wp_sCmdSql += .nCanItm & " , "
                    wp_sCmdSql += "'" & .sUniMedInv & "', "
                    wp_sCmdSql += .nPreUni & ", "
                    wp_sCmdSql += .nVlrBas & ", " '15
                    wp_sCmdSql += .nPorDto & ", "
                    wp_sCmdSql += .nVlrDto & ", "
                    wp_sCmdSql += .nPreDto & ", "
                    wp_sCmdSql += .nVlrDtoLin & ", "
                    wp_sCmdSql += "'" & .sCodIva & "', " '20
                    wp_sCmdSql += .nPorIva & ", "
                    wp_sCmdSql += .nVlrIva & ", "
                    wp_sCmdSql += .nVlrIvaLin & ", "
                    wp_sCmdSql += .nPreBru & ", "
                    wp_sCmdSql += .nTotLin & ", " '25
                    wp_sCmdSql += .nPorCms & ", "
                    wp_sCmdSql += "'" & .sCodCco & "', "
                    wp_sCmdSql += "'" & .sTipLIM & "', "
                    wp_sCmdSql += "'" & .sCodVen & "', "
                    wp_sCmdSql += .nLinBas & ", " '30
                    wp_sCmdSql += "'" & .sCodPdo & "', "
                    wp_sCmdSql += "'" & .sCodCta & "', "
                    wp_sCmdSql += .bSolIto & " , "
                    wp_sCmdSql += "'" & .sCtaCosVta & "' , "
                    wp_sCmdSql += .bItmBlq & ", " '35
                    wp_sCmdSql += "'" & .sClsDoc & "'," '
                    wp_sCmdSql += .nTasCamUsd & ", "
                    wp_sCmdSql += .nPreUniUsd & ", "
                    wp_sCmdSql += .nVlrBasUsd & ", "
                    wp_sCmdSql += "'" & .sCodRch & "', " '40
                    wp_sCmdSql += "'" & .sNroLot & "', "
                    wp_sCmdSql += .nSdoCanLin & ", "
                    wp_sCmdSql += .nPesProm & " )"
                    ' wp_sCmdSql += " )"
                End If
                If wp_sCmdSel = "A" Then
                    wp_sCmdSql = "Update "
                    wp_sCmdSql += wp_sNomTbl
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "', " '3
                    wp_sCmdSql += "sTipMov     = '" & .sTipMov & "', " '
                    wp_sCmdSql += "sCodDocBas  = '" & .sCodDocBas & "', " '5
                    wp_sCmdSql += "sCodSerBas  = '" & .sCodSerBas & "', " '
                    wp_sCmdSql += "nNroDocBas  = " & .nNroDocBas & " , " '
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "', " '
                    wp_sCmdSql += "sNomItm     = " & """" & .sNomItm & """, " '
                    wp_sCmdSql += "sNomAlt     = " & """" & .sNomAlt & """, " '10
                    wp_sCmdSql += "sCodAlm     = '" & .sCodalm & "', " '
                    wp_sCmdSql += "nCanItm     = " & .nCanItm & ", " '
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', " '
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", " '
                    wp_sCmdSql += "nVlrBas     = " & .nVlrBas & ", " '15
                    wp_sCmdSql += "nPorDto     = " & .nPorDto & ", " '
                    wp_sCmdSql += "nVlrDto     = " & .nVlrDto & ", " '
                    wp_sCmdSql += "nPreDto     = " & .nPreDto & ", " '
                    wp_sCmdSql += "nVlrDtoLin     = " & .nVlrDtoLin & ", " '
                    wp_sCmdSql += "sCodIva     = '" & .sCodIva & "' , " '20
                    wp_sCmdSql += "nPorIva     = " & .nPorIva & ", " '
                    wp_sCmdSql += "nVlrIva     = " & .nVlrIva & ", " '
                    wp_sCmdSql += "nVlrIvaLin  = " & .nVlrIvaLin & ", " '
                    wp_sCmdSql += "nPreBru     = " & .nPreBru & ", " '
                    wp_sCmdSql += "nTotLin     = " & .nTotLin & ", " '25
                    wp_sCmdSql += "nPorCms     = " & .nPorCms & ", " '
                    wp_sCmdSql += "sCodCco     = '" & .sCodCco & "' ," '
                    wp_sCmdSql += "sTipLIM     = '" & .sTipLIM & "' ," '
                    wp_sCmdSql += "sCodVen     = '" & .sCodVen & "' ," '
                    wp_sCmdSql += "nLinBas     = " & .nLinBas & "," '30
                    wp_sCmdSql += "sCodPdo     = '" & .sCodPdo & "' ," '
                    wp_sCmdSql += "sCodCta     = '" & .sCodCta & "' ," '
                    wp_sCmdSql += "bSolIto     = " & .bSolIto & ", " '
                    wp_sCmdSql += "sCtaCosVta  = '" & .sCtaCosVta & "' , " '
                    wp_sCmdSql += "bItmBlq     = " & .bItmBlq & ", " '35 
                    wp_sCmdSql += "sClsDoc     = '" & .sClsDoc & "', " '
                    wp_sCmdSql += "nTasCamUsd  = " & .nTasCamUsd & "," '
                    wp_sCmdSql += "nPreUniUsd  = " & .nPreUniUsd & "," '
                    wp_sCmdSql += "nVlrBasUsd  = " & .nVlrBasUsd & ","  '
                    wp_sCmdSql += "sCodRch     = '" & .sCodRch & "', " '40
                    wp_sCmdSql += "sNroLot     = '" & .sNroLot & "', " '
                    wp_sCmdSql += "nSdoCanLin  = " & .nSdoCanLin & "," '
                    wp_sCmdSql += "nPesProm  = " & .nPesProm '43
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(nID        = " & .nId & " and "
                    wp_sCmdSql += "sCodDoc     = '" & .sCodDoc & "' and "
                    wp_sCmdSql += "nNroDoc     = " & .nNroDoc
                    wp_sCmdSql += ")"
                End If
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            If wl_YesNo Then
                wl_YesNo = False
                wl_YesNo = cdf_ActSdoInv(wr_eGLMOV1)
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cdCrearActualizarILMOV1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function

#End Region
#Region "R - Consultar"
    Public Function cddtCargarGEMOV(ByVal wp_sNomTbl As String,
                                  ByRef wr_bEOF As Boolean) As DataTable

        Try
            Dim wp_sCmdSql As String
            wp_sCmdSql = "select * from " & wp_sNomTbl & " T0"
            wp_sCmdSql += " ORDER BY "
            wp_sCmdSql += " T0.dFecCtb, T0.sTipMov, T0.nId "

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
    Public Function cddtCargarGELMOV1(ByVal wp_sNomTblE As String,
                                      ByVal wp_sNomTblL As String,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable



        Try

            'SELECT * FROM 
            'IEMOV 
            'INNER JOIN 
            '(
            'ILMOV1 
            'INNER JOIN (ILDMI1 INNER JOIN IEDMI ON ILDMI1.sCodItm=IEDMI.sCodItm) 
            'ON (ILMOV1.sCodItm=ILDMI1.sCodItm) AND (ILMOV1.sCodAlm=ILDMI1.sCodAlm)) 
            'ON (IEMOV.sCodDoc=ILMOV1.sCodDoc) AND (IEMOV.nNroDoc=ILMOV1.nNroDoc);


            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            Dim wl_dFecMDAIni As Date
            Dim wl_dFecMDAFin As Date
            Dim wl_sFecMDAIni As String
            Dim wl_sFecMDAFin As String

            wl_dFecMDAIni = wp_eGELMOV1.dFecDoc
            wl_dFecMDAFin = wp_eGELMOV1.dFecVto
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)
            wl_sFecMDAFin = cdf_dDMY_MDY(wl_dFecMDAFin)


            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTblE 'IEMOV T0
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN "
            wp_sCmdSql += "( "
            wp_sCmdSql += wp_sNomTblL 'ILMOV1 T1
            wp_sCmdSql += " T1 "
            wp_sCmdSql += " INNER JOIN (ILDMI1 T2 INNER JOIN IEDMI T3 ON T2.sCodItm = T3.sCodItm) "
            wp_sCmdSql += " ON "
            wp_sCmdSql += " (T1.sCodItm = T2.sCodItm)"
            wp_sCmdSql += " AND "
            wp_sCmdSql += " (T1.sCodAlm = T2.sCodAlm)"
            wp_sCmdSql += ") "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "(T0.sCodDoc = T1.sCodDoc) "
            wp_sCmdSql += " AND "
            wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "

            With wp_eGELMOV1


                If .sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If
                    wp_sCmdSql += " T0.sCodDoc = '" & .sCodDoc & "' "
                    vl_bIndAND = True
                End If
                If .sCodSer <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T0.sCodSer = '" & .sCodSer & "'"
                End If
                If .nNroDoc <> 0 Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc
                End If
                If .sEstDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T0.sEstDoc = '" & .sEstDoc & "'"
                End If
                '2018-08-03 Se incluye el filtro de las fechas
                If wl_sFecMDAIni <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        vl_bIndAND = True
                        wp_sCmdSql += " AND "
                    End If
                    wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecMDAIni & "#"
                End If
                If wl_sFecMDAFin <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T0.dFecDoc <= #" & wl_sFecMDAFin & "#"
                End If

                ' 2018-08-03 Fin
                If .sCodVen <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T0.sCodVen = '" & .sCodVen & "'"
                End If
                If .sCodTer <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T0.sCodTer = '" & .sCodTerI & "'"
                End If

                'vl_bIndAND = True
                If .xsCodItm <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T1.sCodItm = '" & .xsCodItm & "'"
                End If
                If .sCodDocBas <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T1.sCodDocBas = '" & .xsCodDocBas & "' "
                End If
                If .nNroDocBas <> 0 Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T1.nNroDocBas = " & .xnNroDocBas
                End If
            End With
            wp_sCmdSql += " ORDER BY T0.dFecCtb, T0.sTipDoc,T0.nId "

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGELMOV")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultar(ByVal vp_sCodDoc,
                                  ByVal vp_nNroDoc,
                                  ByRef wr_bEOF) As DataTable


        Try
            wp_sCmdSql = "select * from IEMOV "
            wp_sCmdSql += " where "
            wp_sCmdSql += "sCodDoc = '" & vp_sCodDoc & "' and "
            wp_sCmdSql += "nNroDoc = " & vp_nNroDoc
            wl_DT = cdfdtConsultar(wp_sCmdSql,
                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: cldIEINV.cddtConsultar ")
            Throw ex
        End Try

        Return wl_DT
    End Function
    Public Function cddtConsultarILMOV1(ByVal wp_sNomTbl As String,
                                          ByVal vp_sCodDoc As String,
                                          ByVal vp_nNroDoc As Double,
                                          ByVal vp_sCodItm As String,
                                          ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_nCntReg As Integer


            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " FROM ("
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            If vp_sCodDoc IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodItm = T1.sCodItm)"
                wp_sCmdSql += " INNER JOIN  ILDMI1 T2 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T1.sCodItm = T2.sCodItm"
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += " T0.sCodDoc = '" & vp_sCodDoc & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += " T0.nNroDoc = " & vp_nNroDoc
                wp_sCmdSql += " AND "
                wp_sCmdSql += " T0.sCodAlm = T2.sCodAlm"
                If vp_sCodItm <> "" Then
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += " T0.sCodItm = '" & vp_sCodItm & "' "
                End If



            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntReg = wl_DT.Rows.Count

        Catch ex As Exception
            MsgBox("Error: cldIEINV.cddtConsultarILMOV1 ")
            Throw ex
        End Try

        Return wl_DT
    End Function
    Public Function cddtConGEINV(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByVal wp_sTipCmp As String,
                                 ByVal wp_sNomCmp1 As String,
                                 ByVal wp_sDatCmp1 As String,
                                 ByVal wp_sTipCmp1 As String,
                                 ByVal wp_sCmpOrd As String,
                                 ByVal wp_sTipOrd As String,
                                 ByVal wp_sCmpOrd1 As String,
                                 ByVal wp_sTipOrd1 As String,
                                 ByRef wr_bEOF As Boolean) As DataTable


        Try

            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.["
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += "]"
            wp_sCmdSql += " = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            If wp_sNomCmp1 <> "" Then
                wp_sCmdSql += " AND T0.[" & wp_sNomCmp1
                wp_sCmdSql += "]"
                wp_sCmdSql += " = "
                If wp_sTipCmp1 = "N" Then
                    wp_sCmdSql += wp_sDatCmp1
                Else
                    If wp_sTipCmp1 = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
                    End If
                End If
            End If

            If wp_sCmpOrd <> "" Then
                wp_sCmdSql += " ORDER BY "
                wp_sCmdSql += wp_sCmpOrd
                If wp_sTipOrd = "D" Then
                    wp_sCmdSql += " DESC"
                End If
                If wp_sCmpOrd1 <> "" Then
                    wp_sCmdSql += " , "
                    wp_sCmdSql += wp_sCmpOrd
                    If wp_sTipOrd = "D" Then
                        wp_sCmdSql += " DESC"
                    End If
                End If
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: cldIEINV.cddtConGEINV ")
            Throw ex
        End Try

        Return wl_DT
    End Function
    Public Function cddtConGELMOV1(ByVal wp_sNomTblE As String,
                                 ByVal wp_sNomTblL As String,
                                 ByVal wp_sCodDoc As String,
                                 ByVal wp_sCodSerI As String,
                                 ByVal wp_sCodSerF As String,
                                 ByVal wp_nNroDocI As Long,
                                 ByVal wp_nNroDocF As Long,
                                 ByVal wp_sEstDoc As String,
                                 ByVal wp_dFecDocI As String,
                                 ByVal wp_dFecDocF As String,
                                 ByVal wp_sCodVen As String,
                                 ByVal wp_sCodTerI As String,
                                 ByVal wp_sCodTerF As String,
                                 ByVal wp_sCodItmI As String,
                                 ByVal wp_sCodItmF As String,
                                 ByVal wp_sCodDocBas As String,
                                 ByVal wp_nNroDocBas As Long,
                                 ByRef wr_bEOF As Boolean) As DataTable

        Try

            Dim vl_bIndAND As Boolean = False
            'wp_sCmdSql = "SELECT * FROM "
            'wp_sCmdSql += "( "
            'wp_sCmdSql += wp_sNomTblE
            'wp_sCmdSql += " T0 "
            'wp_sCmdSql += " INNER JOIN "
            'wp_sCmdSql += wp_sNomTblL
            'wp_sCmdSql += " T1 "
            'wp_sCmdSql += " ON "
            'wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc "
            'wp_sCmdSql += " AND "
            'wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc) "
            'wp_sCmdSql += "INNER JOIN ILDMI1 T2 "
            'wp_sCmdSql += "ON "
            'wp_sCmdSql += "(T1.[sCoditm] = T2.[sCodItm]) "
            'wp_sCmdSql += "AND "
            'wp_sCmdSql += "(T1.[sCodAlm] = T2.[sCodAlm]) "



            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTblE 'IEMOV T0
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN "
            wp_sCmdSql += "( "
            wp_sCmdSql += wp_sNomTblL 'ILMOV1 T1
            wp_sCmdSql += " T1 "
            wp_sCmdSql += " INNER JOIN (ILDMI1 T2 INNER JOIN IEDMI T3 ON T2.sCodItm = T3.sCodItm) "
            wp_sCmdSql += " ON "
            wp_sCmdSql += " (T1.sCodItm = T2.sCodItm)"
            wp_sCmdSql += " AND "
            wp_sCmdSql += " (T1.sCodAlm = T2.sCodAlm)"
            wp_sCmdSql += ") "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "(T0.sCodDoc = T1.sCodDoc) "
            wp_sCmdSql += " AND "
            wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "
            wp_sCmdSql += " WHERE "



            If wp_sCodDoc <> "" Then
                wp_sCmdSql += " T0.sCodDoc = '" & wp_sCodDoc & "' "
                vl_bIndAND = True
            End If
            If wp_sCodSerI <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.sCodSer >= '" & wp_sCodSerI & "'"
            End If
            If wp_sCodSerF <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.sCodSer <= '" & wp_sCodSerF & "'"
            End If
            If wp_nNroDocI <> 0 Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.nNroDoc <= " & wp_nNroDocI
            End If
            If wp_nNroDocF <> 0 Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.nNroDoc >= " & wp_nNroDocF
            End If
            If wp_sEstDoc <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.sEstDoc = '" & wp_sEstDoc & "'"
            End If
            If wp_dFecDocI <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.dFecDoc >= #" & wp_dFecDocI & "#"
            End If
            If wp_dFecDocF <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.dFecDoc <= #" & wp_dFecDocF & "#"
            End If
            If wp_sCodVen <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.sCodVen = '" & wp_sCodVen & "'"
            End If
            If wp_sCodTerI <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T0.sCodTer >= '" & wp_sCodTerI & "'"
            End If
            If wp_sCodTerF <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                wp_sCmdSql += " T0.sCodTer <= '" & wp_sCodTerF & "'"
            End If
            vl_bIndAND = True
            If wp_sCodItmI <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T1.sCodItm >= '" & wp_sCodItmI & "'"
            End If
            If wp_sCodItmF <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T1.sCodItm <= '" & wp_sCodItmF & "'"
            End If
            If wp_sCodDocBas <> "" Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T1.sCodDocBas = '" & wp_sCodDocBas & "' "
            End If
            If wp_nNroDocBas <> 0 Then
                If vl_bIndAND Then
                    wp_sCmdSql += " AND "
                End If
                vl_bIndAND = True
                wp_sCmdSql += " T1.nNroDocBas = " & wp_nNroDocBas
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGELMOV")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConGELMOV1_QIniFin(ByVal wp_sNomTbl As String,
                                           ByVal wp_eGELMOV1_Ini As Object,
                                           ByVal wp_eGELMOV1_Fin As Object,
                                           ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean
            Dim wl_sFecDocIni As String
            Dim wl_sDDIni As String
            Dim wl_sMMMIni As String
            Dim wl_nMMIni As Integer
            Dim wl_sYYYYIni As String
            Dim wl_sFecDocFin As String
            Dim wl_sDDFin As String
            Dim wl_sMMMFin As String
            Dim wl_nMMFin As Integer
            Dim wl_sYYYYFin As String
            Dim wl_sNomTblL As String
            If wp_sNomTbl = "CEODC" Then
                wl_sNomTblL = "CLODC1"
            Else
                wl_sNomTblL = "ILMOV1"
            End If

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_eGELMOV1_Ini
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += wp_sNomTbl 'IEMOV T0
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN "
                wp_sCmdSql += "( "
                wp_sCmdSql += wl_sNomTblL 'ILMOV1 T1
                wp_sCmdSql += " T1 "
                wp_sCmdSql += " INNER JOIN (ILDMI1 T2 INNER JOIN IEDMI T3 ON T2.sCodItm = T3.sCodItm) "
                wp_sCmdSql += " ON "
                wp_sCmdSql += " (T1.sCodItm = T2.sCodItm)"
                wp_sCmdSql += " AND "
                wp_sCmdSql += " (T1.sCodAlm = T2.sCodAlm)"
                wp_sCmdSql += ") "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "(T0.sCodDoc = T1.sCodDoc) "
                wp_sCmdSql += " AND "
                wp_sCmdSql += "(T0.nNroDoc = T1.nNroDoc) "

                If .sTipMov <> "" Then
                    If .sTipMOv <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sTipMov = '" & .sTipMov & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc >= '" & .sCodDoc & "'"
                    End If
                End If

                If wp_eGELMOV1_Fin.sCodDoc <> "" Then
                    If wp_eGELMOV1_Fin.sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc <= '" & wp_eGELMOV1_Fin.sCodDoc & "'"
                    End If
                End If

                If .nNroDoc <> -1 Then
                    If .nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc >= " & .nNroDoc & " "
                    End If
                End If

                If wp_eGELMOV1_Fin.nNroDoc <> -1 Then
                    If wp_eGELMOV1_Fin.nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc <= " & wp_eGELMOV1_Fin.nNroDoc & " "
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
                        wp_sCmdSql += " T0.sCodSer >= '" & .sCodSer & "'"
                    End If
                End If

                If wp_eGELMOV1_Fin.sCodSer <> "" Then
                    If wp_eGELMOV1_Fin.sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer <= '" & wp_eGELMOV1_Fin.sCodSer & "'"
                    End If
                End If
                If .sCodTra <> "" Then
                    If .sCodTra <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTra >= '" & .sCodTra & "'"
                    End If
                End If
                If wp_eGELMOV1_Fin.sCodTra <> "" Then
                    If wp_eGELMOV1_Fin.sCodTra <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTra <= '" & wp_eGELMOV1_Fin.sCodTra & "'"
                    End If
                End If

                If .sCodTer <> "" Then
                    If .sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer >= '" & .sCodTer & "'"
                    End If
                End If

                If wp_eGELMOV1_Fin.sCodTer <> "" Then
                    If wp_eGELMOV1_Fin.sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer <= '" & wp_eGELMOV1_Fin.sCodTer & "'"
                    End If
                End If


                If .sEstDoc <> "" Then
                    If .sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc >= '" & .sEstDoc & "'"
                    End If
                End If

                If wp_eGELMOV1_Fin.sEstDoc <> "" Then
                    If wp_eGELMOV1_Fin.sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc <= '" & wp_eGELMOV1_Fin.sEstDoc & "'"
                    End If
                End If



                If .xsCodItm <> "" Then
                    If .xsCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.sCodItm >= '" & .xsCodItm & "'"
                    End If
                End If

                If wp_eGELMOV1_Fin.xsCodItm <> "" Then
                    If wp_eGELMOV1_Fin.xsCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.sCodItm <= '" & wp_eGELMOV1_Fin.xsCodItm & "'"
                    End If
                End If


                If .dFecDoc <> Nothing Then
                    If .dFecDoc <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        '     wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "


                        wl_sDDIni = DatePart(DateInterval.Day, .dFecDoc)
                        wl_nMMIni = DatePart(DateInterval.Month, .dFecDoc)
                        wl_sMMMIni = MonthName(wl_nMMIni, True)
                        Select Case wl_nMMIni
                            Case 1
                                wl_sMMMIni = "jan"
                            Case 2
                                wl_sMMMIni = "feb"
                            Case 3
                                wl_sMMMIni = "mar"
                            Case 4
                                wl_sMMMIni = "apr"
                            Case 5
                                wl_sMMMIni = "may"
                            Case 6
                                wl_sMMMIni = "jun"
                            Case 7
                                wl_sMMMIni = "jul"
                            Case 8
                                wl_sMMMIni = "aug"
                            Case 9
                                wl_sMMMIni = "sep"
                            Case 10
                                wl_sMMMIni = "oct"
                            Case 11
                                wl_sMMMIni = "nov"
                            Case 12
                                wl_sMMMIni = "dec"
                        End Select

                        wl_sYYYYIni = DatePart(DateInterval.Year, .dFecDoc)
                        wl_sFecDocIni = wl_sDDIni & "-" & wl_sMMMIni & "-" & wl_sYYYYIni
                        wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "

                    End If
                End If
                If wp_eGELMOV1_Fin.dFecDoc <> Nothing Then
                    If wp_eGELMOV1_Fin.dFecDoc <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        '  wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "
                        wl_sDDFin = DatePart(DateInterval.Day, wp_eGELMOV1_Fin.dFecDoc)
                        wl_nMMFin = DatePart(DateInterval.Month, wp_eGELMOV1_Fin.dFecDoc)
                        wl_sDDFin = DatePart(DateInterval.Day, wp_eGELMOV1_Fin.dFecDoc)
                        wl_nMMFin = DatePart(DateInterval.Month, wp_eGELMOV1_Fin.dFecDoc)
                        wl_sMMMFin = MonthName(wl_nMMFin, True)
                        Select Case wl_nMMFin
                            Case 1
                                wl_sMMMFin = "jan"
                            Case 2
                                wl_sMMMFin = "feb"
                            Case 3
                                wl_sMMMFin = "mar"
                            Case 4
                                wl_sMMMFin = "apr"
                            Case 5
                                wl_sMMMFin = "may"
                            Case 6
                                wl_sMMMFin = "jun"
                            Case 7
                                wl_sMMMFin = "jul"
                            Case 8
                                wl_sMMMFin = "aug"
                            Case 9
                                wl_sMMMFin = "sep"
                            Case 10
                                wl_sMMMFin = "oct"
                            Case 11
                                wl_sMMMFin = "nov"
                            Case 12
                                wl_sMMMFin = "dec"
                        End Select
                        wl_sYYYYFin = DatePart(DateInterval.Year, wp_eGELMOV1_Fin.dFecDoc)
                        wl_sFecDocFin = wl_sDDFin & "-" & wl_sMMMFin & "-" & wl_sYYYYFin
                        wp_sCmdSql += " T0.dFecDoc <= #" & wl_sFecDocFin & "# "
                    End If
                End If

                wl_bComa = False
                wp_sCmdSql += " ORDER BY "

                wp_sCmdSql += "T0.sTipMov, "
                wp_sCmdSql += "T0.sCodDoc, "
                'wp_sCmdSql += "T0.sCodSer, "
                wp_sCmdSql += "T0.nNroDoc, "
                wp_sCmdSql += "T0.dFecDoc "
            End With


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGELMOV1_IniFin")
            Return Nothing
            Throw ex
        End Try
        Return Nothing


    End Function
    Public Function cddtConGELMOV1_QGrl(ByVal wp_sNomTbl As String,
                                        ByVal wp_eGELMOV1 As Object,
                                       ByVal wp_sMayMenIgu As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_eGELMOV1
                wp_sCmdSql = "SELECT "
                If .sTipMov <> "" Then
                    wp_sCmdSql += "T0.sTipMov "
                    wl_bComa = True
                End If
                If .sCodDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If

                If .nNroDoc = -1 Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If
                If .sCodTra <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T2.sCodTra "
                    wl_bComa = True
                End If
                If .sEstDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstDoc "
                    wl_bComa = True
                End If
                If .sCodTer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodTer, "
                    wp_sCmdSql += "T0.sNomTer "
                    wl_bComa = True
                End If

                If .xsCodItm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T0.sNomItm "
                    wl_bComa = True
                End If
                If .xsCodAlm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodAlm "
                    wl_bComa = True
                End If

                If .dFecDoc <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T2.dFecDoc "
                    wl_bComa = True
                End If
                wp_sCmdSql += " FROM "
                wp_sCmdSql += " ( "
                wp_sCmdSql += " ILMOV1 "
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm) "
                wp_sCmdSql += "INNER JOIN IEMOV T2 "
                wp_sCmdSql += "ON "
                wp_sCmdSql += "(T0.[sCodDoc] = T2.[sCodDoc]) "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "(T0.[nNroDoc] = T2.[nNroDoc]) "
                If .sTipMov <> "" Then
                    If .sTipMOv <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sTipMov = '" & .sTipMov & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc = '" & .sCodDoc & "'"
                    End If
                End If
                If .nNroDoc <> -1 Then
                    If .nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        If wp_sMayMenIgu = "May" Then
                            wp_sCmdSql += " T0.nNroDoc >= " & .nNroDoc & " "
                        Else
                            If wp_sMayMenIgu = "Men" Then
                                wp_sCmdSql += " T0.nNroDoc <= " & .nNroDoc & " "
                            Else
                                wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc & " "
                            End If
                        End If
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
                        wp_sCmdSql += " T0.sCodSer = '" & .sCodSer & "'"
                    End If
                End If

                If .sCodTer <> "" Then
                    If .sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer = '" & .sCodter & "'"
                    End If
                End If


                If .sEstDoc <> "" Then
                    If .sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc = '" & .sEstDoc & "'"
                    End If
                End If

                If .sCodTra <> "" Then
                    If .sCodTra <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T2.sCodTra = '" & .sCodTra & "'"
                    End If
                End If


                If .xsCodItm <> "" Then
                    If .xsCodItm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodItm = '" & .xsCodItm & "'"
                    End If

                End If
                If .xsCodAlm <> "" Then
                    If .xsCodAlm <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodAlm = '" & .xsCodAlm & "'"
                    End If

                End If
                '    If .sCodGrp <> "" Then
                ' If .sCodGrp <> " " Then
                ' If wl_WHERE <> "" Then
                ' wp_sCmdSql += wl_WHERE
                ' wl_WHERE = ""
                ' Else
                ' wp_sCmdSql += wl_AND
                ' End If
                ' wp_sCmdSql += " T0.sCodGrp = '" & .sCodGrp & "'"
                ' End If
                ' End If

                wl_bComa = False
                wp_sCmdSql += " GROUP BY "


                If .sTipMov <> "" Then
                    wp_sCmdSql += "T0.sTipMov "
                    wl_bComa = True
                End If
                If .sCodDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If
                If .nNroDoc = -1 Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If
                If .sCodTra <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T2.sCodTra "
                    wl_bComa = True
                End If
                If .sCodTer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodTer, "
                    wp_sCmdSql += "T0.sNomTer "
                    wl_bComa = True
                End If
                If .xsCodItm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodItm, "
                    wp_sCmdSql += "T0.sNomItm "
                    wl_bComa = True
                End If
                If .xsCodAlm <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodAlm "
                    wl_bComa = True
                End If
                If .dFecDoc <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T2.dFecDoc "
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
            MsgBox("Error : cldIEINV.cddtConGELMOV1_QGrl")
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
    Public Function cddtConGEMOV_Grl(ByVal wp_sNomTbl As String,
                                     ByVal wp_eGEMOV As Object,
                                     ByVal wp_sMayMenIgu As String,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_eGEMOV
                wp_sCmdSql = "SELECT "
                If .sTipMov <> "" Then
                    wp_sCmdSql += "T0.sTipMov "
                    wl_bComa = True
                End If
                If .sCodDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If

                If .nNroDoc = -1 Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If
                If .sCodTra <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodTra "
                    wl_bComa = True
                End If
                If .sEstDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstDoc "
                    wl_bComa = True
                End If
                If .sCodTer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodTer, "
                    wp_sCmdSql += "T0.sNomTer "
                    wl_bComa = True
                End If

                If .dFecDoc <> Nothing Then
                    If .dFecDoc <> #1/1/1901# Then
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.dFecDoc "
                        wl_bComa = True
                    End If
                End If

                wp_sCmdSql += " from "
                wp_sCmdSql += wp_sNomTbl
                wp_sCmdSql += " T0 "
                If .sTipMov <> "" Then
                    If .sTipMOv <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sTipMov = '" & .sTipMov & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc = '" & .sCodDoc & "'"
                    End If
                End If
                If .nNroDoc <> -1 Then
                    If .nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        If wp_sMayMenIgu = "May" Then
                            wp_sCmdSql += " T0.nNroDoc >= " & .nNroDoc & " "
                        Else
                            If wp_sMayMenIgu = "Men" Then
                                wp_sCmdSql += " T0.nNroDoc <= " & .nNroDoc & " "
                            Else
                                wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc & " "
                            End If
                        End If
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
                        wp_sCmdSql += " T0.sCodSer = '" & .sCodSer & "'"
                    End If
                End If

                If .sCodTer <> "" Then
                    If .sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer = '" & .sCodter & "'"
                    End If
                End If


                If .sEstDoc <> "" Then
                    If .sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc = '" & .sEstDoc & "'"
                    End If
                End If

                If .sCodTra <> "" Then
                    If .sCodTra <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTra = '" & .sCodTra & "'"
                    End If
                End If

                wl_bComa = False
                wp_sCmdSql += " GROUP BY "

                If .sTipMov <> "" Then
                    wp_sCmdSql += "T0.sTipMov "
                    wl_bComa = True
                End If
                If .sCodDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodDoc "
                    wl_bComa = True
                End If
                If .nNroDoc = -1 Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.nNroDoc "
                    wl_bComa = True
                End If
                If .sCodSer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodSer "
                    wl_bComa = True
                End If
                If .sCodTra <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodTra "
                    wl_bComa = True
                End If
                If .sEstDoc <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sEstDoc "
                    wl_bComa = True
                End If
                If .sCodTer <> "" Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T0.sCodTer, "
                    wp_sCmdSql += "T0.sNomTer "
                    wl_bComa = True
                End If


                If .dFecDoc <> Nothing Then
                    If .dFecDoc <> #1/1/1901# Then
                        If wl_bComa = True Then
                            wp_sCmdSql += ","
                        End If
                        wp_sCmdSql += "T0.dFecDoc "
                        wl_bComa = True
                    End If
                End If

            End With


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cddtConGEMOV_Grl")
            Return Nothing
            Throw ex
        End Try

    End Function
    Public Function cddtConGEMOV_QIniFin(ByVal wp_sNomTbl As String,
                                        ByVal wp_eGEMOV_Ini As Object,
                                        ByVal wp_eGEMOV_Fin As Object,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean
            Dim wl_sFecDocIni As String
            Dim wl_sDDIni As String
            Dim wl_sMMMIni As String
            Dim wl_nMMIni As Integer
            Dim wl_sYYYYIni As String
            Dim wl_sFecDocFin As String
            Dim wl_sDDFin As String
            Dim wl_sMMMFin As String
            Dim wl_nMMFin As Integer
            Dim wl_sYYYYFin As String


            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_eGEMOV_Ini
                wp_sCmdSql = "SELECT * "
                wp_sCmdSql += " from "
                wp_sCmdSql += wp_sNomTbl
                wp_sCmdSql += " T0 "
                If .sTipMov <> "" Then
                    If .sTipMOv <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sTipMov = '" & .sTipMov & "' "
                        wl_WHERE = ""
                    End If
                End If
                If .sCodDoc <> "" Then
                    If .sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc >= '" & .sCodDoc & "'"
                    End If
                End If

                If wp_eGEMOV_Fin.sCodDoc <> "" Then
                    If wp_eGEMOV_Fin.sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc <= '" & wp_eGEMOV_Fin.sCodDoc & "'"
                    End If
                End If

                If .nNroDoc <> -1 Then
                    If .nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc >= " & .nNroDoc & " "
                    End If
                End If

                If wp_eGEMOV_Fin.nNroDoc <> -1 Then
                    If wp_eGEMOV_Fin.nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc <= " & wp_eGEMOV_Fin.nNroDoc & " "
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
                        wp_sCmdSql += " T0.sCodSer >= '" & .sCodSer & "'"
                    End If
                End If

                If wp_eGEMOV_Fin.sCodSer <> "" Then
                    If wp_eGEMOV_Fin.sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer <= '" & wp_eGEMOV_Fin.sCodSer & "'"
                    End If
                End If
                If .sCodTra <> "" Then
                    If .sCodTra <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTra >= '" & .sCodTra & "'"
                    End If
                End If
                If wp_eGEMOV_Fin.sCodTra <> "" Then
                    If wp_eGEMOV_Fin.sCodTra <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTra <= '" & wp_eGEMOV_Fin.sCodTra & "'"
                    End If
                End If

                If .sCodTer <> "" Then
                    If .sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer >= '" & .sCodTer & "'"
                    End If
                End If

                If wp_eGEMOV_Fin.sCodTer <> "" Then
                    If wp_eGEMOV_Fin.sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer <= '" & wp_eGEMOV_Fin.sCodTer & "'"
                    End If
                End If


                If .sEstDoc <> "" Then
                    If .sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc >= '" & .sEstDoc & "'"
                    End If
                End If

                If wp_eGEMOV_Fin.sEstDoc <> "" Then
                    If wp_eGEMOV_Fin.sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc <= '" & wp_eGEMOV_Fin.sEstDoc & "'"
                    End If
                End If

                If .dFecDoc <> Nothing Then
                    If .dFecDoc <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        '     wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "


                        wl_sDDIni = DatePart(DateInterval.Day, .dFecDoc)
                        wl_nMMIni = DatePart(DateInterval.Month, .dFecDoc)
                        wl_sMMMIni = MonthName(wl_nMMIni, True)
                        Select Case wl_nMMIni
                            Case 1
                                wl_sMMMIni = "jan"
                            Case 2
                                wl_sMMMIni = "feb"
                            Case 3
                                wl_sMMMIni = "mar"
                            Case 4
                                wl_sMMMIni = "apr"
                            Case 5
                                wl_sMMMIni = "may"
                            Case 6
                                wl_sMMMIni = "jun"
                            Case 7
                                wl_sMMMIni = "jul"
                            Case 8
                                wl_sMMMIni = "aug"
                            Case 9
                                wl_sMMMIni = "sep"
                            Case 10
                                wl_sMMMIni = "oct"
                            Case 11
                                wl_sMMMIni = "nov"
                            Case 12
                                wl_sMMMIni = "dec"
                        End Select

                        wl_sYYYYIni = DatePart(DateInterval.Year, .dFecDoc)
                        wl_sFecDocIni = wl_sDDIni & "-" & wl_sMMMIni & "-" & wl_sYYYYIni
                        wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "

                    End If
                End If
                If wp_eGEMOV_Fin.dFecDoc <> Nothing Then
                    If wp_eGEMOV_Fin.dFecDoc <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        '  wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "
                        wl_sDDFin = DatePart(DateInterval.Day, wp_eGEMOV_Fin.dFecDoc)
                        wl_nMMFin = DatePart(DateInterval.Month, wp_eGEMOV_Fin.dFecDoc)
                        wl_sDDFin = DatePart(DateInterval.Day, wp_eGEMOV_Fin.dFecDoc)
                        wl_nMMFin = DatePart(DateInterval.Month, wp_eGEMOV_Fin.dFecDoc)
                        wl_sMMMFin = MonthName(wl_nMMFin, True)
                        Select Case wl_nMMFin
                            Case 1
                                wl_sMMMFin = "jan"
                            Case 2
                                wl_sMMMFin = "feb"
                            Case 3
                                wl_sMMMFin = "mar"
                            Case 4
                                wl_sMMMFin = "apr"
                            Case 5
                                wl_sMMMFin = "may"
                            Case 6
                                wl_sMMMFin = "jun"
                            Case 7
                                wl_sMMMFin = "jul"
                            Case 8
                                wl_sMMMFin = "aug"
                            Case 9
                                wl_sMMMFin = "sep"
                            Case 10
                                wl_sMMMFin = "oct"
                            Case 11
                                wl_sMMMFin = "nov"
                            Case 12
                                wl_sMMMFin = "dec"
                        End Select
                        wl_sYYYYFin = DatePart(DateInterval.Year, wp_eGEMOV_Fin.dFecDoc)
                        wl_sFecDocFin = wl_sDDFin & "-" & wl_sMMMFin & "-" & wl_sYYYYFin
                        wp_sCmdSql += " T0.dFecDoc <= #" & wl_sFecDocFin & "# "
                    End If
                End If

                wl_bComa = False
                wp_sCmdSql += " ORDER BY "

                wp_sCmdSql += "T0.sTipMov, "
                wp_sCmdSql += "T0.sCodDoc, "
                'wp_sCmdSql += "T0.sCodSer, "
                wp_sCmdSql += "T0.nNroDoc, "
                wp_sCmdSql += "T0.dFecDoc "
            End With


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGEMOV_IniFin")
            Return Nothing
            Throw ex
        End Try
        Return Nothing
    End Function
    Public Function cddtConGLINV1(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sTipCmp As String,
                                  ByVal wp_sNomCmp1 As String,
                                  ByVal wp_sDatCmp1 As String,
                                  ByVal wp_sTipCmp1 As String,
                                  ByVal wp_sCmpOrd As String,
                                  ByVal wp_sTipOrd As String,
                                  ByVal wp_sCmpOrd1 As String,
                                  ByVal wp_sTipOrd1 As String,
                                  ByRef wr_bEOF As Boolean) As DataTable


        Try

            '  wp_sCmdSql = " SELECT * "
            '  wp_sCmdSql += " from "
            '  wp_sCmdSql += "( PLODP1 T0 "
            '  wp_sCmdSql += "INNER JOIN IEDMI T1 "
            '  wp_sCmdSql += " ON "
            '  wp_sCmdSql += "T0.[sCodCmt] = T1.[sCodItm]) "
            '  wp_sCmdSql += "INNER JOIN ILDMI1 T2 "
            '  wp_sCmdSql += "ON "
            '  wp_sCmdSql += "(T0.[sCodcmt] = T2.[sCodItm]) "
            '  wp_sCmdSql += "AND "
            '  wp_sCmdSql += "(T0.[sCodAlmCns] = T2.[sCodAlm]) "

            wp_sCmdSql = "SELECT * FROM ("
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN IEDMI T1 "
            wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm) "
            '    wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm "
            wp_sCmdSql += " INNER JOIN ILDMI1 T2 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += " (T0.sCodItm= T2.sCodItm) "
            wp_sCmdSql += " AND  "
            wp_sCmdSql += " (T0.sCodAlm = T2.sCodAlm) "
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.["
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += "]"
            wp_sCmdSql += " = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If

            wp_sCmdSql += " AND T0.[" & wp_sNomCmp1
            wp_sCmdSql += "]"
            wp_sCmdSql += " = "
            If wp_sTipCmp1 = "N" Then
                wp_sCmdSql += wp_sDatCmp1
            Else
                If wp_sTipCmp1 = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
                End If
            End If
            If wp_sCmpOrd <> "" Then
                wp_sCmdSql += " ORDER BY "
                wp_sCmdSql += "T0." & wp_sCmpOrd
                If wp_sTipOrd = "D" Then
                    wp_sCmdSql += " DESC"
                End If
                If wp_sCmpOrd1 <> "" Then
                    wp_sCmdSql += " , "
                    wp_sCmdSql += "T0." & wp_sCmpOrd1
                    If wp_sTipOrd1 = "D" Then
                        wp_sCmdSql += " DESC"
                    End If
                End If
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                wr_bEOF = False
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: cldIEINV.cddtConGLINV1 ")
            Throw ex
        End Try

        Return wl_DT
    End Function
    Public Function cddtConGLMOV1(ByVal wp_eGLMOV1 As Object,
                                  ByVal wp_sNomTbl As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim wl_bIndAND As Boolean = False

            With wp_eGLMOV1
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += wp_sNomTbl
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm "

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
            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGLMOV1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConKARDEX_QIniFin(ByVal wp_eKARDEX As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim wl_bIndAND As Boolean = False
            Dim wl_bComa As Boolean = False
            Dim wl_sFecDocIni As String
            Dim wl_sDDIni As String
            Dim wl_sMMMIni As String
            Dim wl_nMMIni As Integer
            Dim wl_sYYYYIni As String
            Dim wl_sFecDocFin As String
            Dim wl_sDDFin As String
            Dim wl_sMMMFin As String
            Dim wl_nMMFin As Integer
            Dim wl_sYYYYFin As String

            With wp_eKARDEX
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += " ( "
                wp_sCmdSql += " ILMOV1 "
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm) "
                wp_sCmdSql += "INNER JOIN IEMOV T2 "
                wp_sCmdSql += "ON "
                wp_sCmdSql += "(T0.[sCodDoc] = T2.[sCodDoc]) "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "(T0.[nNroDoc] = T2.[nNroDoc]) "

                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        End If
                        wp_sCmdSql += " T0.sCodItm = '" & .sCodItm & "' "
                    End If
                End If
                If .sCodAlm <> "" Then
                    If .sCodAlm <> " " Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wl_bIndAND = True
                        End If
                        If wl_bIndAND Then
                            wp_sCmdSql += " AND "
                        End If
                        wp_sCmdSql += " T0.sCodAlm = '" & .sCodAlm & "' "
                    End If
                End If
                If .dFecDocIni <> Nothing Then
                    If .dFecDocIni <> #1/1/1901# Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wl_bIndAND = True
                        End If
                        If wl_bIndAND Then
                            wp_sCmdSql += " AND "
                        End If
                        wl_sDDIni = DatePart(DateInterval.Day, .dFecDocIni)
                        wl_nMMIni = DatePart(DateInterval.Month, .dFecDocIni)
                        wl_sMMMIni = MonthName(wl_nMMIni, True)
                        Select Case wl_nMMIni
                            Case 1
                                wl_sMMMIni = "jan"
                            Case 2
                                wl_sMMMIni = "feb"
                            Case 3
                                wl_sMMMIni = "mar"
                            Case 4
                                wl_sMMMIni = "apr"
                            Case 5
                                wl_sMMMIni = "may"
                            Case 6
                                wl_sMMMIni = "jun"
                            Case 7
                                wl_sMMMIni = "jul"
                            Case 8
                                wl_sMMMIni = "aug"
                            Case 9
                                wl_sMMMIni = "sep"
                            Case 10
                                wl_sMMMIni = "oct"
                            Case 11
                                wl_sMMMIni = "nov"
                            Case 12
                                wl_sMMMIni = "dec"
                        End Select

                        wl_sYYYYIni = DatePart(DateInterval.Year, .dFecDocIni)
                        wl_sFecDocIni = wl_sDDIni & "-" & wl_sMMMIni & "-" & wl_sYYYYIni
                        wp_sCmdSql += " T2.dFecDoc >= #" & wl_sFecDocIni & "# "
                    End If
                End If
                If .dFecDocFin <> Nothing Then
                    If .dFecDocFin <> #1/1/1901# Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wl_bIndAND = True
                        End If
                        If wl_bIndAND Then
                            wp_sCmdSql += " AND "
                        End If
                        wl_sDDFin = DatePart(DateInterval.Day, .dFecDocFin)
                        wl_nMMFin = DatePart(DateInterval.Month, .dFecDocfin)
                        wl_sDDFin = DatePart(DateInterval.Day, .dFecDocfin)
                        wl_nMMFin = DatePart(DateInterval.Month, .dFecDocfin)
                        wl_sMMMFin = MonthName(wl_nMMFin, True)
                        Select Case wl_nMMFin
                            Case 1
                                wl_sMMMFin = "jan"
                            Case 2
                                wl_sMMMFin = "feb"
                            Case 3
                                wl_sMMMFin = "mar"
                            Case 4
                                wl_sMMMFin = "apr"
                            Case 5
                                wl_sMMMFin = "may"
                            Case 6
                                wl_sMMMFin = "jun"
                            Case 7
                                wl_sMMMFin = "jul"
                            Case 8
                                wl_sMMMFin = "aug"
                            Case 9
                                wl_sMMMFin = "sep"
                            Case 10
                                wl_sMMMFin = "oct"
                            Case 11
                                wl_sMMMFin = "nov"
                            Case 12
                                wl_sMMMFin = "dec"
                        End Select
                        wl_sYYYYFin = DatePart(DateInterval.Year, .dFecDocFin)
                        wl_sFecDocFin = wl_sDDFin & "-" & wl_sMMMFin & "-" & wl_sYYYYFin
                        wp_sCmdSql += " T2.dFecDoc <= #" & wl_sFecDocFin & "# "
                    End If
                End If
                If .sCodAlm <> "" Then
                    If .sCodAlm <> " " Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wl_bIndAND = True
                        End If
                        If wl_bIndAND Then
                            wp_sCmdSql += " AND "
                        End If
                        wp_sCmdSql += " T0.sCodAlm = '" & .sCodAlm & "' "
                    End If
                End If



                '   If wl_bIndWHERE = False Then
                'wp_sCmdSql += " ORDER BY "
                wp_sCmdSql += " ORDER BY T2.dFecDoc, T0.sTipMov, T2.nID  "
                'wp_sCmdSql += " T0.sCodItm,"
                '  wp_sCmdSql += " T0.nId "
                'wp_sCmdSql += " T2.dFecDoc,"
                'wp_sCmdSql += " T2.sTipMov,"
                'wp_sCmdSql += " T2.sCodDoc "
                'End If
            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cddtConKARDEX_QIniFin")
            Return Nothing
            Throw ex
        End Try

    End Function
    Public Function cddtConKARDEX_QGrl(ByVal wp_eKARDEX As Object,
                                       ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_eKARDEX
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
                    wp_sCmdSql += "T0.sCodAlm "
                    wl_bComa = True
                End If

                If .dFecDoc <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T2.dFecDoc "
                    wl_bComa = True
                End If
                wp_sCmdSql += " FROM "
                wp_sCmdSql += " ( "
                wp_sCmdSql += " ILMOV1 "
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm) "
                wp_sCmdSql += "INNER JOIN IEMOV T2 "
                wp_sCmdSql += "ON "
                wp_sCmdSql += "(T0.[sCodDoc] = T2.[sCodDoc]) "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "(T0.[nNroDoc] = T2.[nNroDoc]) "
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
                    wp_sCmdSql += "T0.sCodAlm "
                    wl_bComa = True
                End If
                If .dFecDoc <> Nothing Then
                    If wl_bComa = True Then
                        wp_sCmdSql += ","
                    End If
                    wp_sCmdSql += "T2.dFecDoc "
                    wl_bComa = True
                End If
                wp_sCmdSql += " ORDER BY T2.dFecDoc, T0.sTipMov, T2.nID  "


            End With


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return (wl_DT)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cddtConKARDEX_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConSdoAntKARDEX(ByVal wp_eKARDEX As Object,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim wl_bIndAND As Boolean = False
            Dim wl_bComa As Boolean = False
            Dim wl_sFecDocIni As String
            Dim wl_sDD As String
            Dim wl_sMMM As String
            Dim wl_nMM As Integer
            Dim wl_sYYYY As String

            With wp_eKARDEX
                wp_sCmdSql = "SELECT "
                wp_sCmdSql += "t0.sCodItm, T1.sNomItm, "
                wp_sCmdSql += "Sum(Switch(T0.sTipMov="
                wp_sCmdSql += """E"""
                wp_sCmdSql += ",nCanItm)) AS nCanItmEnt,"
                wp_sCmdSql += "Sum(Switch(T0.sTipMov="
                wp_sCmdSql += """E"""
                wp_sCmdSql += ",nTotLin)) AS nTotLinEnt,"
                wp_sCmdSql += "Sum(Switch(T0.sTipMov="
                wp_sCmdSql += """S"""
                wp_sCmdSql += ",nCanItm)) AS nCanItmSal,"
                wp_sCmdSql += "Sum(Switch(T0.sTipMov="
                wp_sCmdSql += """S"""
                wp_sCmdSql += ",nTotLin)) AS nTotLinSal"
                wp_sCmdSql += " FROM "
                wp_sCmdSql += " ( "
                wp_sCmdSql += " ILMOV1 "
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON T0.sCodItm = T1.sCodItm) "
                wp_sCmdSql += "INNER JOIN IEMOV T2 "
                wp_sCmdSql += "ON "
                wp_sCmdSql += "(T0.[sCodDoc] = T2.[sCodDoc]) "
                wp_sCmdSql += "AND "
                wp_sCmdSql += "(T0.[nNroDoc] = T2.[nNroDoc]) "

                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        End If
                        wp_sCmdSql += " T0.sCodItm = '" & .sCodItm & "' "
                    End If
                End If
                If .sCodAlm <> "" Then
                    If .sCodAlm <> " " Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wl_bIndAND = True
                        End If
                        If wl_bIndAND Then
                            wp_sCmdSql += " AND "
                        End If
                        wp_sCmdSql += " T0.sCodAlm = '" & .sCodAlm & "' "
                    End If
                End If
                If .dFecDocIni <> Nothing Then
                    If .dFecDocIni <> #1/1/1901# Then
                        If wl_bIndWHERE = False Then
                            wp_sCmdSql += " WHERE "
                            wl_bIndWHERE = True
                        Else
                            wl_bIndAND = True
                        End If
                        If wl_bIndAND Then
                            wp_sCmdSql += " AND "
                        End If
                        wl_sDD = DatePart(DateInterval.Day, .dFecDocIni)
                        wl_nMM = DatePart(DateInterval.Month, .dFecDocIni)
                        wl_sMMM = "jan"
                        Select Case wl_nMM
                            Case 1
                                wl_sMMM = "jan"
                            Case 2
                                wl_sMMM = "feb"
                            Case 3
                                wl_sMMM = "mar"
                            Case 4
                                wl_sMMM = "apr"
                            Case 5
                                wl_sMMM = "may"
                            Case 6
                                wl_sMMM = "jun"
                            Case 7
                                wl_sMMM = "jul"
                            Case 8
                                wl_sMMM = "aug"
                            Case 9
                                wl_sMMM = "sep"
                            Case 10
                                wl_sMMM = "oct"
                            Case 11
                                wl_sMMM = "nov"
                            Case 12
                                wl_sMMM = "dec"
                        End Select


                        wl_sYYYY = DatePart(DateInterval.Year, .dFecDocIni)
                        wl_sFecDocIni = wl_sDD & "-" & wl_sMMM & "-" & wl_sYYYY
                        wp_sCmdSql += " T2.dFecDoc < #" & wl_sFecDocIni & "# "
                    End If
                End If
                If wl_bIndWHERE = True Then
                    wp_sCmdSql += " GROUP BY "
                    wp_sCmdSql += " T0.sCodItm, T1.sNomItm"

                End If
            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cddtConSdoAntKARDEX")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConSolILMOV1(ByVal wp_sNomTbl As String,
                                     ByVal vp_sCodDoc As String,
                                     ByVal vp_nNroDoc As Double,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_nCntReg As Integer
            wp_sCmdSql = "SELECT * "
            wp_sCmdSql += " FROM ("
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN CEODC T1 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc"
            wp_sCmdSql += "  AND "
            wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc"
            wp_sCmdSql += ")"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.sCodDoc = '" & vp_sCodDoc & "' "
            wp_sCmdSql += " AND "
            wp_sCmdSql += " T0.nNroDoc = " & vp_nNroDoc
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntReg = wl_DT.Rows.Count
        Catch ex As Exception
            MsgBox("Error: cldIEINV.cddtConSolILMOV1 ")
            Throw ex
        End Try
        Return wl_DT
    End Function

#End Region
#Region "U - Actualizar"
    Public Function cdActILMOV1_PLODP4(ByVal wr_ePEODP_PLODP4 As Object,
                                      ByRef wr_bEOF As Boolean) As Boolean

        ' 2018-08-31
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            Dim wl_dFecMDAIni As Date
            Dim wl_sFecMDAIni As String
            ' Actualiza el Detalle de las EDP cuando se modifican los costos de la ODP
            wl_dFecMDAIni = wr_ePEODP_PLODP4.dFecini
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)

            wl_YesNo = False
            wp_sCmdSql = ""
            With wr_ePEODP_PLODP4
                wp_sCmdSql = "UPDATE (ILMOV1 AS T0 INNER JOIN IEMOV AS T1 ON (T0.sCodDoc = T1.sCodDoc) AND (T0.nNroDoc = T1.nNroDoc)) "
                wp_sCmdSql += "INNER JOIN PLODP4 AS T2 ON "
                wp_sCmdSql += "T0.sCodItm = T2.sCodItm "
                wp_sCmdSql += "AND T0.sCodDocBas = T2.sCodDoc "
                wp_sCmdSql += "AND T0.nNroDocBas = T2.nNroDoc "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "t0.nPreUni = T2.nCosUniCns, "
                wp_sCmdSql += "t0.nVlrBas = T2.nCosUniCns * T0.nCanItm, "
                wp_sCmdSql += "t0.nPreDto = T2.nCosUniCns, "
                wp_sCmdSql += "t0.nPreBru = T2.nCosUniCns,  "
                wp_sCmdSql += "t0.nTotLin = T2.nCosUniCns * T0.nCanItm"

                If wr_ePEODP_PLODP4.sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If

                    wp_sCmdSql += "T2.sCodDoc = '" & wr_ePEODP_PLODP4.sCodDoc & "' "
                    If wr_ePEODP_PLODP4.nNroDoc <> 0 Then
                        If vl_bIndAND = False Then
                            wp_sCmdSql += " AND "
                            vl_bIndAND = True
                        End If
                        wp_sCmdSql += "T2.nNroDoc = " & wr_ePEODP_PLODP4.nNroDoc
                    End If
                End If

                If .sCodItm <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T1.sCodItm        = '" & .sCodItm & "'"
                End If
                '2018-08-14 Se incluye el filtro de las fechas
                If wl_sFecMDAIni <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If

                    wp_sCmdSql += " T1.dFecDoc >= #" & wl_sFecMDAIni & "#"
                End If


                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

                ' Actualiza las Encabezados a 0 de las EDP cuando se modifican los costos de la ODP

                wl_bIndWHERE = False
                vl_bIndAND = False

                wp_sCmdSql = ""
                wp_sCmdSql = "UPDATE (ILMOV1 AS T0 INNER JOIN IEMOV AS T1 ON (T0.sCodDoc = T1.sCodDoc) AND (T0.nNroDoc = T1.nNroDoc)) "
                wp_sCmdSql += "INNER JOIN PLODP4 AS T2 ON "
                wp_sCmdSql += "T0.sCodItm = T2.sCodItm "
                wp_sCmdSql += "AND T0.sCodDocBas = T2.sCodDoc "
                wp_sCmdSql += "AND T0.nNroDocBas = T2.nNroDoc "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T1.nTotBas = 0, "
                wp_sCmdSql += "T1.nTotDto = 0, "
                wp_sCmdSql += "T1.nTotIvaCom = 0, "
                wp_sCmdSql += "T1.nTotIvaVta = 0,  "
                wp_sCmdSql += "T1.nTotDoc = 0 "
                If wr_ePEODP_PLODP4.sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If

                    wp_sCmdSql += "T2.sCodDoc = '" & wr_ePEODP_PLODP4.sCodDoc & "' "
                    If wr_ePEODP_PLODP4.nNroDoc <> 0 Then
                        If vl_bIndAND = False Then
                            wp_sCmdSql += " AND "
                            vl_bIndAND = True
                        End If
                        wp_sCmdSql += "T2.nNroDoc = " & wr_ePEODP_PLODP4.nNroDoc
                    End If
                End If

                If .sCodItm <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T1.sCodItm        = '" & .sCodItm & "'"
                End If
                '2018-08-14 Se incluye el filtro de las fechas
                If wl_sFecMDAIni <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If

                    wp_sCmdSql += " T1.dFecDoc >= #" & wl_sFecMDAIni & "#"
                End If

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


                ' Actualiza las Encabezados las EDP con el valor de cada registro del detalle de la EDP,
                ' cuando se modifican los costos de la ODP

                wl_bIndWHERE = False
                vl_bIndAND = False

                wp_sCmdSql = ""
                wp_sCmdSql = "UPDATE (ILMOV1 AS T0 INNER JOIN IEMOV AS T1 ON (T0.sCodDoc = T1.sCodDoc) AND (T0.nNroDoc = T1.nNroDoc)) "
                wp_sCmdSql += "INNER JOIN PLODP4 AS T2 ON "
                wp_sCmdSql += "T0.sCodItm = T2.sCodItm "
                wp_sCmdSql += "AND T0.sCodDocBas = T2.sCodDoc "
                wp_sCmdSql += "AND T0.nNroDocBas = T2.nNroDoc "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T1.nTotBas = T1.nTotBas + T0.nVlrBas, "
                wp_sCmdSql += "T1.nTotDto = T1.nTotDto + T0.nVlrDto, "
                wp_sCmdSql += "T1.nTotIvaCom = T1.nTotIvaCom + T0.nVlrIvaLin, "
                wp_sCmdSql += "T1.nTotIvaVta = T1.nTotIvaVta + T0.nVlrIvaLin,  "
                wp_sCmdSql += "T1.nTotDoc = T1.nTotDoc + T0.nTotLin "
                '     wp_sCmdSql += " WHERE ((T0.sCodDoc=T1.sCodDoc) And (T0.nNroDoc=T1.nNroDoc))"
                If wr_ePEODP_PLODP4.sCodDoc <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    End If

                    wp_sCmdSql += "T2.sCodDoc = '" & wr_ePEODP_PLODP4.sCodDoc & "' "
                    If wr_ePEODP_PLODP4.nNroDoc <> 0 Then
                        If vl_bIndAND = False Then
                            wp_sCmdSql += " AND "
                            vl_bIndAND = True
                        End If
                        wp_sCmdSql += "T2.nNroDoc = " & wr_ePEODP_PLODP4.nNroDoc
                    End If
                End If

                If .sCodItm <> "" Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If
                    wp_sCmdSql += " T1.sCodItm        = '" & .sCodItm & "'"
                End If
                '2018-08-14 Se incluye el filtro de las fechas
                If wl_sFecMDAIni <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If

                    wp_sCmdSql += " T1.dFecDoc >= #" & wl_sFecMDAIni & "#"
                End If

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cdActILMOV1_PLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActIEMOV_ILMOV1(ByVal wr_eILMOV1 As Object,
                                      ByRef wr_bEOF As Boolean) As Boolean
        Try
            'OJO - no se ha probado esta función

            Dim wl_bIndWHERE As Boolean = False
            Dim vl_bIndAND As Boolean = False
            wl_YesNo = False
            wp_sCmdSql = ""
            ' Actualiza las Encabezados a 0 del movimiento de inventarios cuando se modifican por la BD el 
            ' detalle del movimiento o cuando hay errores en el total de la línea del movimiento.
            ' Se toma cómo fecha de inicio, la fecha del inventario activa: ACDEM
            Dim wl_dFecMDAIni As Date
            Dim wl_sFecMDAIni As String

            wl_dFecMDAIni = wr_eILMOV1.dFecini
            wl_sFecMDAIni = cdf_dDMY_MDY(wl_dFecMDAIni)

            ' Actualiza las Encabezados a 0 de las EDP cuando se modifican los costos de la ODP
            With wr_eILMOV1
                wp_sCmdSql = "UPDATE IEMOV AS T0 INNER JOIN ILMOV1 AS T1 ON "
                wp_sCmdSql += "(T0.sCodDoc = T1.sCodDoc) AND (T0.nNroDoc = T1.nNroDoc) "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nTotBas = 0, "
                wp_sCmdSql += "T0.nTotDto = 0, "
                wp_sCmdSql += "T0.nTotIvaCom = 0, "
                wp_sCmdSql += "T0.nTotIvaVta = 0, "
                wp_sCmdSql += "T0.nTotDoc = 0"

                '2018-08-14 Se incluye el filtro de las fechas
                If wl_sFecMDAIni <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If

                    wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecMDAIni & "#"
                End If
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

            ' Actualiza las Encabezados los movimientos de inventarios con el valor de cada registro del detalle.

            wl_bIndWHERE = False
            vl_bIndAND = False
            wp_sCmdSql = ""
            With wr_eILMOV1
                wp_sCmdSql = "UPDATE IEMOV AS T0 INNER JOIN ILMOV1 AS T1 ON "
                wp_sCmdSql += "(T0.sCodDoc = T1.sCodDoc) AND (T0.nNroDoc = T1.nNroDoc) "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "T0.nTotBas = (T0.nTotBas + T1.nVlrBas), "
                wp_sCmdSql += "T0.nTotDto = (T0.nTotDto + T1.nVlrDto), "
                wp_sCmdSql += "T0.nTotIvaCom = (T0.nTotIvaCom + T1.nVlrIvaLin), "
                wp_sCmdSql += "T0.nTotIvaVta = (T0.nTotIvaCom + T1.nVlrIvaLin), "
                wp_sCmdSql += "T0.nTotDoc = (T0.nTotDoc + T1.nTotLin)"
                '2018-08-14 Se incluye el filtro de las fechas
                If wl_sFecMDAIni <> Nothing Then
                    If wl_bIndWHERE = False Then
                        wp_sCmdSql += " WHERE "
                        wl_bIndWHERE = True
                    Else
                        wp_sCmdSql += " AND "
                        vl_bIndAND = True
                    End If

                    wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecMDAIni & "#"
                End If

                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cdActIEMOV_ILMOV1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function

#End Region
#Region "D - Eliminar"
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
            MsgBox("Error: cldIEINV.cdEliminar ")
            '  MsgBox("Error: cldIEINV.cdEliminar ")
            Throw ex

        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliminarILMOV1(ByVal wp_sNomTblL As String,
                                         ByVal vp_nNroReg As Integer,
                                         ByVal vp_sCodDoc As String,
                                         ByVal vp_nNroDoc As Double,
                                         ByVal wr_bEOF As Boolean) As Boolean

        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from "
            wp_sCmdSql += wp_sNomTblL
            wp_sCmdSql += " where "
            wp_sCmdSql += "(nId       = " & vp_nNroReg & " and "
            wp_sCmdSql += "sCodDoc    = '" & vp_sCodDoc & "' and "
            wp_sCmdSql += "nNroDoc    = " & vp_nNroDoc
            wp_sCmdSql += ")"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error : cldIEINV.cdEliminarILMOV1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
#End Region

#Region "IEREV"
    Public Function cddtConIEREV(ByVal wp_eIEREV As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim wl_bIndAND As Boolean = False
            With wp_eIEREV
                wp_sCmdSql = "SELECT * FROM IEREV"
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
            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)

            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConIEREV")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConILREV1(ByVal wp_eILREV1 As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_bIndWHERE As Boolean = False
            Dim wl_bIndAND As Boolean = False
            Dim wl_nCntReg As Integer
            With wp_eILREV1
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " FROM ("
                wp_sCmdSql += " ILREV1 T0"
                wp_sCmdSql += " INNER JOIN IEDMI T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodItm = T1.sCodItm)"
                wp_sCmdSql += " INNER JOIN  ILDMI1 T2 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T1.sCodItm = T2.sCodItm"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "T0.sCodAlm = T2.sCodAlm"

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
            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntReg = wl_DT.Rows.Count
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConGLMOV1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActIEREV(ByVal wp_eIEREV As Object,
                                    ByVal wp_sCmdSel As String,
                                    ByRef wr_bEOF As Boolean) As Boolean
        Try
            Dim vl_sFecCtb As String
            Dim vl_sFecDoc As String
            Dim vl_sFecSys As String
            Dim vl_sFecVto As String



            With wp_eIEREV
                vl_sFecCtb = cdf_dDMY_MDY(.dFecCtb)
                vl_sFecDoc = cdf_dDMY_MDY(.dFecDoc)
                vl_sFecSys = cdf_dDMY_MDY(.dFecSys)
                vl_sFecVto = cdf_dDMY_MDY(.dFecVto)

                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into "
                    wp_sCmdSql += " IEREV"
                    wp_sCmdSql += " (sCodDoc , " '1
                    wp_sCmdSql += " nNroDoc) " '2
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodDoc & "', "
                    wp_sCmdSql += .nNroDoc & " )"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                wp_sCmdSql = "Update "
                wp_sCmdSql += "  IEREV"
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sCodSer  = '" & .sCodSer & "',"
                wp_sCmdSql += "sCodTra  = '" & .sCodTra & "',"
                wp_sCmdSql += "sEstDoc     = '" & .sEstDoc & "', " ' 5
                wp_sCmdSql += "sTipRev     = '" & .sTipRev & "', "
                wp_sCmdSql += "dFecCtb     =  #" & vl_sFecCtb & "# , "
                wp_sCmdSql += "dFecDoc     =  #" & vl_sFecDoc & "#, "
                wp_sCmdSql += "dFecVto     =  #" & vl_sFecVto & "#, "
                wp_sCmdSql += "dFecSys     =  #" & vl_sFecSys & "#, " '10
                wp_sCmdSql += "sDocRef     = '" & .sDocRef & "', "
                wp_sCmdSql += "nTotDoc     = " & .nTotDoc & ", "
                wp_sCmdSql += "sClsDoc  = '" & .sClsDoc & "', "
                wp_sCmdSql += "sCmn     = '" & .sCmn & "', "
                wp_sCmdSql += "sCodCteCtb  = '" & .sCodCteCtb & "', "
                wp_sCmdSql += "nNroCteCtb  = " & .nNroCteCtb & " , " '
                wp_sCmdSql += "nIdFECCT  = " & .nIdFECCT & ","
                wp_sCmdSql += "sCodMon  = '" & .sCodMon & "', "
                wp_sCmdSql += "sCodUsr  = '" & .sCodUsr & "',"
                wp_sCmdSql += "sCodAut  = '" & .sCodAut & "'" '20
                wp_sCmdSql += "  where "
                wp_sCmdSql += "( "
                wp_sCmdSql += "sCodDoc = '" & .sCodDoc & "' "
                wp_sCmdSql += " and "
                wp_sCmdSql += "nNroDoc = " & .nNroDoc
                wp_sCmdSql += ") "
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldIEINV.cdCrearActIEREV ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActILREV1(ByVal wp_eILREV1 As Object,
                                     ByVal wp_sCmdSel As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = ""
            With wp_eILREV1
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into "
                    wp_sCmdSql += " ILREV1 "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc, " '1
                    wp_sCmdSql += "nNroDoc, " '2
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sTipRev, "
                    wp_sCmdSql += "sCodItm, "
                    wp_sCmdSql += "sNomItm, "
                    wp_sCmdSql += "sNomAlt,"
                    wp_sCmdSql += "sCodAlm, "
                    wp_sCmdSql += "nCanItm, "
                    wp_sCmdSql += "sUniMedInv, " '10
                    wp_sCmdSql += "nPreUni, " '
                    wp_sCmdSql += "nPreAnt, " '
                    wp_sCmdSql += "nDifPre, " '
                    wp_sCmdSql += "nTotLin, " ' 
                    wp_sCmdSql += "sCodPdo, " '15
                    wp_sCmdSql += "sCodCta, " '
                    wp_sCmdSql += "sCtaCosVta, " '
                    wp_sCmdSql += "sCtaAumInv, " '
                    wp_sCmdSql += "sCtaRedInv, " '
                    wp_sCmdSql += "sClsDoc" '20
                    wp_sCmdSql += " ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "' , " '1
                    wp_sCmdSql += .nNroDoc & " , " '2
                    wp_sCmdSql += "'" & .sCodSer & "'," '
                    wp_sCmdSql += "'" & .sTipRev & "' , " '
                    wp_sCmdSql += "'" & .sCodItm & "' ," ' 
                    wp_sCmdSql += """" & .sNomItm & """, " '
                    wp_sCmdSql += """" & .sNomAlt & """, " '
                    wp_sCmdSql += "'" & .sCodalm & "', " '
                    wp_sCmdSql += .nCanItm & " , " '
                    wp_sCmdSql += "'" & .sUniMedInv & "', " '10
                    wp_sCmdSql += .nPreUni & ", "
                    wp_sCmdSql += .nPreAnt & ", "
                    wp_sCmdSql += .nDifPre & ", "
                    wp_sCmdSql += .nTotLin & ", " '
                    wp_sCmdSql += "'" & .sCodPdo & "', " '15
                    wp_sCmdSql += "'" & .sCodCta & "', " '
                    wp_sCmdSql += "'" & .sCtaCosVta & "' , " '
                    wp_sCmdSql += "'" & .sCtaAumInv & "' , " '
                    wp_sCmdSql += "'" & .sCtaRedInv & "' , " '
                    wp_sCmdSql += "'" & .sClsDoc & "'" '20
                    wp_sCmdSql += " )"
                End If
                If wp_sCmdSel = "A" Then
                    wp_sCmdSql = "Update "
                    wp_sCmdSql += " ILREV1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodSer     = '" & .sCodSer & "', " '
                    wp_sCmdSql += "sTipRev     = '" & .sTipRev & "', " '
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "', " ' 5
                    wp_sCmdSql += "sNomItm     = " & """" & .sNomItm & """, "
                    wp_sCmdSql += "sNomAlt     = " & """" & .sNomItm & """, "
                    wp_sCmdSql += "sCodAlm     = '" & .sCodalm & "', " '
                    wp_sCmdSql += "nCanItm     = " & .nCanItm & ", " '
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', " '10
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", " '
                    wp_sCmdSql += "nPreAnt     = " & .nPreAnt & ", " '
                    wp_sCmdSql += "nDifPre     = " & .nDifPre & ", " '
                    wp_sCmdSql += "nTotLin     = " & .nTotLin & ", " '
                    wp_sCmdSql += "sCodPdo     = '" & .sCodPdo & "' ," '
                    wp_sCmdSql += "sCodCta     = '" & .sCodCta & "' ," '
                    wp_sCmdSql += "sCtaCosVta     = '" & .sCtaCosVta & "' ," '
                    wp_sCmdSql += "sCtaAumInv     = '" & .sCtaAumInv & "' ," '    
                    wp_sCmdSql += "sCtaRedInv  = '" & .sCtaRedInv & "' , " '
                    wp_sCmdSql += "sClsDoc     = '" & .sClsDoc & "' " '
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(nID        = " & .nId & " and "
                    wp_sCmdSql += "sCodDoc     = '" & .sCodDoc & "' and "
                    wp_sCmdSql += "nNroDoc     = " & .nNroDoc
                    wp_sCmdSql += ")"
                End If
            End With
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            If wl_YesNo Then
                wl_YesNo = False
                wl_YesNo = cdf_RevSdoInv(wp_eILREV1)
            End If
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cdCrearActILREV1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliILREV1(ByVal vp_nNroReg As Integer,
                                    ByVal vp_sCodDoc As String,
                                    ByVal vp_nNroDoc As Double,
                                    ByVal wr_bEOF As Boolean) As Boolean

        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from "
            wp_sCmdSql += "ILREV1 "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(nId       = " & vp_nNroReg & " and "
            wp_sCmdSql += "sCodDoc    = '" & vp_sCodDoc & "' and "
            wp_sCmdSql += "nNroDoc    = " & vp_nNroDoc
            wp_sCmdSql += ")"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error : cldIEINV.cdEliIREV1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
#End Region
End Class
