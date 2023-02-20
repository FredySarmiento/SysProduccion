Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldPEFOM
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand
    Dim cldIEDMI As New cldIEDMI
#Region "C - Crear"
    Public Function cdCrearActualizar(ByVal vp_ePEFOM As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vp_ePEFOM


                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PEFOM "
                    wp_sCmdSql += "(sCodItm) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PEFOM "
                    wp_sCmdSql += " SET "
                    'wp_sCmdSql += "sNomItm     = '" & .sNomItm & "', "
                    wp_sCmdSql += "sNomItm     = """ & .sNomItm & """, "
                    wp_sCmdSql += "nCanLotStn  = " & .nCanLotStn & ", "
                    wp_sCmdSql += "sUniMedStn  = '" & .sUniMedStn & "', "
                    wp_sCmdSql += "nCanUniStn  = " & .nCanUniStn & ", "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', "
                    wp_sCmdSql += "sTipLIM     = '" & .sTipLIM & "', "
                    wp_sCmdSql += "sCodAlm     = '" & .sCodAlm & "', "
                    wp_sCmdSql += "nPesItm     = " & .nPesItm & ", "
                    wp_sCmdSql += "nPorItm     = " & .nPorItm & ", "
                    wp_sCmdSql += "nTieItm  = " & .nTieItm & ", "
                    wp_sCmdSql += "nCIFItm  = " & .nCIFItm & ", "
                    wp_sCmdSql += "nVlrItm     = " & .nVlrItm & ", "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci & ", "
                    wp_sCmdSql += "sRegSan     = '" & .sRegSan & "'"

                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodItm =        '" & .sCodItm
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLFOM1(ByRef wp_ePLFOM1 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLFOM1
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLFOM1 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "sCodCmt ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodCmt & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLFOM1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nCanCmt     = " & .nCanCmt & ", "
                    wp_sCmdSql += "nPesCmt     = " & .nPesCmt & ", "
                    wp_sCmdSql += "nPorCmt     = " & .nPorCmt & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "sCodAlmCns  = '" & .sCodAlmCns & "', "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', "
                    wp_sCmdSql += "sTipCmt     = '" & .sTipCmt & "', "
                    wp_sCmdSql += "sCodCmtAlt  = '" & .sCodCmtAlt & "', "
                    wp_sCmdSql += "bItmAct  = " & .bItmAct
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodCmt     = '" & .sCodCmt
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

            End With

        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdCrearActualizarPLFOM1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLFOM2(ByRef wp_ePLFOM2 As Object,
                                           ByVal wr_bEOF As Boolean,
                                           ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLFOM2
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLFOM2 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "sCodOpe, "
                    wp_sCmdSql += "nPosOpe ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodOpe & "',"
                    wp_sCmdSql += .nPosOpe & ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLFOM2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "',"
                    wp_sCmdSql += "nTieOpe     = " & .nTieOpe & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nPorOpe     = " & .nPorOpe & ", "
                    wp_sCmdSql += "nCanBasPro  = " & .nCanBasPro & ", "
                    wp_sCmdSql += "nTotTieOpe  = " & .nTotTieOpe & ", "
                    wp_sCmdSql += "bItmAct     = " & .bItmAct & "  "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodOpe     = '" & .sCodOpe & "' and "
                    wp_sCmdSql += "nPosOpe     = " & .nPosOpe
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdCrearActualizarPLFOM2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLFOM3(ByRef wp_ePLFOM3 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLFOM3
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLFOM3 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "sCodCIF ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodCIF & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLFOM3 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "',"
                    wp_sCmdSql += "nVlrCIFRea  = " & .nVlrCIFRea & ", "
                    wp_sCmdSql += "nTasCIF     = " & .nTasCIF & ",  "
                    wp_sCmdSql += "bItmAct     = " & .bItmAct & "  "

                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodCIF     = '" & .sCodCIF
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdCrearActualizarPLFOM3")
            Throw ex
        End Try

        Return wl_YesNo

    End Function
    Public Function cdCrearActualizarPLFOM5(ByRef wp_ePLFOM5 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLFOM5
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLFOM5 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "sCodAna ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "' , "
                    wp_sCmdSql += "'" & .sCodAna & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLFOM5 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sDesAna     = '" & .sDesAna & "',"
                    wp_sCmdSql += "sCodTipAna     = '" & .sCodTipAna & "',"
                    wp_sCmdSql += "bItmAct     = " & .bItmAct & "  "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodAna     = '" & .sCodAna
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdCrearActualizarPLFOM5")
            Throw ex
        End Try

        Return wl_YesNo

    End Function
#End Region
#Region "R - Consultar"
    Public Function cddtConAnaPLFOM5(ByVal wp_sPLFOM5 As Object,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False
            With wp_sPLFOM5
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " from "
                wp_sCmdSql += " PLFOM5 T0 "

                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodItm = '" & .sCodItm & "' "
                        wl_WHERE = ""
                    End If

                End If
                If .sCodAna <> "" Then
                    If .sCodAna <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodAna= '" & .sCodAna & "'"
                    End If

                End If

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConAnaPLFOM5")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConCmtPLFOM1(ByVal wp_sPLFOM1 As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False
            With wp_sPLFOM1
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " from "
                wp_sCmdSql += " PLFOM1 T0 "

                If .sCodItm <> "" Then
                    If .sCodItm <> " " Then
                        wp_sCmdSql += wl_WHERE
                        wp_sCmdSql += " T0.sCodItm = '" & .sCodItm & "' "
                        wl_WHERE = ""
                    End If

                End If
                If .sCodCmt <> "" Then
                    If .sCodCmt <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodCmt= '" & .sCodCmt & "'"
                    End If

                End If

            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConCmtPLFOM1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPEFOM(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT * "
            wp_sCmdSql += " from PEFOM T0"
            If vp_sCodItm IsNot Nothing Then

                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wp_sCmdSql += " ORDER BY T0.sCodItm "
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConsultarPEFOM")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLFOM1(ByVal vp_sCodItm As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from ("
            wp_sCmdSql += " PLFOM1 T0 "
            wp_sCmdSql += " INNER JOIN IEDMI T1 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0.sCodCmt = T1.sCodItm)"
            wp_sCmdSql += " INNER JOIN  ILDMI1 T2 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T1.sCodItm = T2.sCodItm"
            wp_sCmdSql += " WHERE "
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " T0.sCodItm = '" & vp_sCodItm & "' "
                wp_sCmdSql += " AND "
            End If
            wp_sCmdSql += " T0.sCodAlmCns = T2.sCodAlm"
            wp_sCmdSql += " ORDER BY T0.sCodItm , "
            wp_sCmdSql += " T0.sCodCmt"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConsultarPLFOM1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLFOM2(ByVal vp_sCodItm As String,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from PLFOM2 T0"
            wp_sCmdSql += " INNER JOIN  ATOPE T1"
            wp_sCmdSql += " ON T0.sCodOpe = T1.sCodOpe"
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConsultarPLFOM2")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLFOM3(ByVal vp_sCodItm As String,
                                          ByRef wr_bEOF As Boolean) As DataTable
        Try

            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from PLFOM3 T0"
            wp_sCmdSql += " INNER JOIN  ATCIF T1"
            wp_sCmdSql += " ON T0.sCodCIF = T1.sCodCIF "
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConsultarPLFOM3")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLFOM5(ByVal vp_sCodItm As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from ("
            wp_sCmdSql += " PLFOM5 T0 "
            wp_sCmdSql += " INNER JOIN ATANA T1 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0.sCodAna = T1.sCodAna)"
            wp_sCmdSql += " INNER JOIN  ATTIA T2 "
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T1.sCodTipAna = T2.sCodTipAna"
            wp_sCmdSql += " WHERE "
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += " T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wp_sCmdSql += " ORDER BY "
            wp_sCmdSql += " T0.sCodItm, "
            wp_sCmdSql += " T0.sCodAna "
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConsultarPLFOM5")
            Return Nothing
            Throw ex
        End Try
    End Function

#End Region
#Region "U - Actualizar"
    Public Function cdActPLFOM2nPreUni(ByVal wr_eATCTR As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = True
            With wr_eATCTR
                wp_sCmdSql = "Update PLFOM2 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nPreUni     = " & .nPreUni
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodCtr     = '" & .sCodCtr & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error: cldPEFOM.cdActPLFOM2nPreUni")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActPLFOM3nVlrCIFRea(ByVal wr_eATCIF As Object,
                                          ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = True
            With wr_eATCIF
                wp_sCmdSql = "Update PLFOM3 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nVlrCIFRea     = " & .nVlrCIFRea
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodCIF     = '" & .sCodCIF & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error: cldPEFOM.cdActPLFOM3nVlrCIFRea")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function

#End Region
#Region "D - Eliminar"
    Public Function cdEliminar(ByVal vp_sCodItm As String,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False

            wp_sCmdSql = "Delete * from  PLFOM5 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLFOM3 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLFOM2 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLFOM1 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PEFOM "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdEliminar")
            Throw ex

        End Try
        Return wl_YesNo

    End Function
    Public Function cdEliminarPLFOM1(ByVal wp_ePLFOM1 As Object,
                                       ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLFOM1


                wp_sCmdSql = "Delete * from  PLFOM1 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                wp_sCmdSql += "sCodCmt     = '" & .sCodCmt
                wp_sCmdSql += "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldIPEFOM.cdEliminarPLFOM1")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLFOM2(ByVal vp_sCodItm As String,
                                    ByVal vp_sCodOpe As String,
                                    ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  PLFOM2 "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodItm     = '" & vp_sCodItm & "' and "
            wp_sCmdSql += "sCodOpe     = '" & vp_sCodOpe
            wp_sCmdSql += "')"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdEliminarPLFOM2")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLFOM3(ByVal vp_sCodItm As String,
                                     ByVal vp_sCodCIF As String,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  PLFOM3 "
            wp_sCmdSql += " where "
            wp_sCmdSql += "(sCodItm     = '" & vp_sCodItm & "' and "
            wp_sCmdSql += "sCodCIF     = '" & vp_sCodCIF
            wp_sCmdSql += "')"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdEliminarPLFOM3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliminarPLFOM5(ByVal wp_ePLFOM5 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLFOM5


                wp_sCmdSql = "Delete * from  PLFOM5 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                wp_sCmdSql += " sCodAna     = '" & .sCodAna & "'"
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cdEliminarPLFOM5")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
#End Region
End Class
