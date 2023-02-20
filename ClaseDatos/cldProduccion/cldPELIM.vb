Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldPELIM
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand
    Dim cldIEDMI As New cldIEDMI
#Region "C - Crear"
    Public Function cdCrearActualizar(ByVal vp_ePELIM As Object,
                                     ByRef wr_bEOF As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With vp_ePELIM
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PELIM "
                    wp_sCmdSql += "(sCodItm) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodItm & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PELIM "
                    wp_sCmdSql += " SET "
                    ' wp_sCmdSql += "sNomItm     = '" & .sNomItm & "', "
                    wp_sCmdSql += "sNomItm     = """ & .sNomItm & """, "
                    wp_sCmdSql += "nCanLotStn  = " & .nCanLotStn & ", "
                    wp_sCmdSql += "sUniMedStn  = '" & .sUniMedStn & "', "
                    wp_sCmdSql += "nCanUniStn  = " & .nCanUniStn & ", "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', "
                    wp_sCmdSql += "sTipLIM     = '" & .sTipLIM & "', "
                    wp_sCmdSql += "sCodAlm     = '" & .sCodAlm & "', "
                    wp_sCmdSql += "nPesItm     = " & .nPesItm & ", "
                    wp_sCmdSql += "nPorItm     = " & .nPorItm & ", "
                    wp_sCmdSql += "nTieItm     = " & .nTieItm & ", "
                    wp_sCmdSql += "nCIFItm     = " & .nCIFItm & ", "
                    wp_sCmdSql += "nVlrItm     = " & .nVlrItm & ", "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci & ", "
                    wp_sCmdSql += "sRegSan     = '" & .sRegSan & "', "
                    wp_sCmdSql += "nPreVta     = " & .nPreVta
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodItm =        '" & .sCodItm & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLLIM1(ByRef wp_ePLLIM1 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLLIM1
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLLIM1 "
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
                    wp_sCmdSql = "Update PLLIM1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nCanCmt     = " & .nCanCmt & ", "
                    wp_sCmdSql += "nPesCmt     = " & .nPesCmt & ", "
                    wp_sCmdSql += "nPorCmt     = " & .nPorCmt & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "sCodAlmCns  = '" & .sCodAlmCns & "', "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', "
                    wp_sCmdSql += "sTipCmt  = '" & .sTipCmt & "', "
                    wp_sCmdSql += "sCodCmtAlt  = '" & .sCodCmtAlt & "', "
                    wp_sCmdSql += "bItmAct  = " & .bItmAct & " "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "'"
                    wp_sCmdSql += " and "
                    wp_sCmdSql += "sCodCmt     = '" & .sCodCmt & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cdCrearActualizarPLLIM11")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLLIM2(ByRef wp_ePLLIM2 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLLIM2
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLLIM2 "
                    wp_sCmdSql += "(sCodItm, "
                    wp_sCmdSql += "nPosOpe, "
                    wp_sCmdSql += " sCodOpe ) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodItm & "' , "
                    wp_sCmdSql += .nPosOpe & ","
                    wp_sCmdSql += "'" & .sCodOpe & "')"
                    ' wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                'wp_sCmdSql += "nCanMin     = " & vp_nCanMin & ", "
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLLIM2 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "', "
                    wp_sCmdSql += "nTieOpe     = " & .nTieOpe & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "nPorOpe     = " & .nPorOpe & ", "
                    wp_sCmdSql += "nCanBasPro  = " & .nCanBasPro & ", "
                    wp_sCmdSql += "nTotTieOpe     = " & .nTotTieOpe & ", "
                    wp_sCmdSql += "bItmAct  = " & .bItmAct & " "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodOpe     = '" & .sCodOpe & "' and "
                    wp_sCmdSql += "nPosOpe     = " & .nPosOpe
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cdCrearActualizarPLLIM2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLLIM3(ByRef wp_ePLLIM3 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLLIM3
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLLIM3 "
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
                    wp_sCmdSql = "Update PLLIM3 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "', "
                    wp_sCmdSql += "nVlrCIFRea     = " & .nVlrCIFRea & ", "
                    wp_sCmdSql += "nTasCIF     = " & .nTasCIF & ", "
                    wp_sCmdSql += "bItmAct  = " & .bItmAct & " "
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                    wp_sCmdSql += "sCodCIF     = '" & .sCodCIF & "'"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cdCrearActualizarPLLIM3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdCrearActualizarPLLIM4(ByRef wp_ePLLIM4 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLLIM4
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLLIM4 "
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
                    wp_sCmdSql = "Update PLLIM4 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "nCanCmt     = " & .nCanCmt & ", "
                    wp_sCmdSql += "nPesCmt     = " & .nPesCmt & ", "
                    wp_sCmdSql += "nPorCmt     = " & .nPorCmt & ", "
                    wp_sCmdSql += "nPreUni     = " & .nPreUni & ", "
                    wp_sCmdSql += "sCodAlmCns  = '" & .sCodAlmCns & "', "
                    wp_sCmdSql += "sUniMedInv  = '" & .sUniMedInv & "', "
                    wp_sCmdSql += "sTipCmt  = '" & .sTipCmt & "', "
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
            MsgBox("Error : cldPELIM.cdCrearActualizarPLLIM4")
            Throw ex
        End Try

        Return wl_YesNo

    End Function
#End Region
#Region "R - Consultar"
    Public Function cddtConCmtPLLIM1(ByVal wp_sPLLIM1 As Object,
                                    ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False
            With wp_sPLLIM1
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " from "
                wp_sCmdSql += " PLLIM1 T0 "

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
            wp_sCmdSql += " ORDER BY T0.sCodItm,"
            wp_sCmdSql += " T0.sCodCmt"

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConCmtPLLIM1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConCmtPLLIM4(ByVal wp_sPLLIM1 As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String
            Dim wl_bComa As Boolean

            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False
            With wp_sPLLIM1
                wp_sCmdSql = "SELECT *"
                wp_sCmdSql += " from "
                wp_sCmdSql += " PLLIM4 T0 "

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
                wp_sCmdSql += " ORDER BY T0.sCodItm,"
                wp_sCmdSql += " T0.sCodCmt"
            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPEFOM.cddtConCmtPLLIM1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPELIM(ByVal vp_sCodItm,
                                       ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "SELECT * "
            wp_sCmdSql += " from PELIM T0"
            wp_sCmdSql += " INNER JOIN  IEDMI T1"
            wp_sCmdSql += " ON T0.sCoditm = T1.sCodItm"
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
            MsgBox("Error : cldPELIM.cddtConsultarPELIM")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLLIM1(ByVal vp_sCodItm,
                                        ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "SELECT * "
            wp_sCmdSql += " from ("
            wp_sCmdSql += " PLLIM1 T0 "
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
            wp_sCmdSql += " ORDER BY T0.sCodItm,"
            wp_sCmdSql += " T0.sCodCmt"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cddtConsultarPLLIM1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLLIM2(ByVal vp_sCodItm,
                                          ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from "
            wp_sCmdSql += "( "
            wp_sCmdSql += "PLLIM2 T0"
            wp_sCmdSql += " INNER JOIN  ATOPE T1"
            wp_sCmdSql += " ON "
            wp_sCmdSql += " T0.sCodOpe = T1.sCodOpe"
            wp_sCmdSql += ") "
            wp_sCmdSql += " INNER JOIN  ATCTR T2"
            wp_sCmdSql += " ON "
            wp_sCmdSql += " T0.sCodCtr = T2.sCodCtr"
            wp_sCmdSql += " WHERE "
            If vp_sCodItm IsNot Nothing Then
                wp_sCmdSql += "T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wp_sCmdSql += " ORDER BY T0.sCodItm,"
            wp_sCmdSql += " T0.sCodOpe"

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cddtConsultarPLLIM2")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLLIM3(ByVal vp_sCodItm,
                                          ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from PLLIM3 T0"
            wp_sCmdSql += " INNER JOIN  ATCIF T1"
            wp_sCmdSql += " ON T0.sCodCIF = T1.sCodCIF "
            If vp_sCodItm IsNot Nothing Then

                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wp_sCmdSql += " ORDER BY T0.sCodItm,"
            wp_sCmdSql += " T0.sCodCIF"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cddtConsultarPLLIM3")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConsultarPLLIM4(ByVal vp_sCodItm,
                                          ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "SELECT *"
            wp_sCmdSql += " from PLLIM4 T0"
            wp_sCmdSql += " INNER JOIN  PEFOM T1"
            wp_sCmdSql += " ON T0.sCodCmt = T1.sCodItm"
            If vp_sCodItm IsNot Nothing Then
                '    wp_sCmdSql += " INNER JOIN  ITALM T1"
                '   wp_sCmdSql += " ON T0.sCodAlmCns = T1.sCodAlm"

                wp_sCmdSql += " WHERE T0.sCodItm = '" & vp_sCodItm & "' "
            End If
            wp_sCmdSql += " ORDER BY T0.sCodItm,"
            wp_sCmdSql += " T0.sCodCmt"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldPELIM.cddtConsultarPLLIM4")
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region
#Region "U - Actualizar"
    Public Function cdActPLLIM2nPreUni(ByVal wr_eATCTR As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = True
            With wr_eATCTR
                wp_sCmdSql = "Update PLLIM2 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nPreUni     = " & .nPreUni
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodCtr     = '" & .sCodCtr & "' "
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error: cldPELIM.cdActPLLIM2nPreUni")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cdActPLLIM3nVlrCIFRea(ByVal wr_eATCIF As Object,
                                       ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = True
            With wr_eATCIF
                wp_sCmdSql = "Update PLLIM3 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "nVlrCIFRea     = " & .nVlrCIFRea
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodCIF     = '" & .sCodCIF & "' "
                wp_sCmdSql += ")"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error: cldPELIM.cdActPLLIM3nVlrCIFRea")
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
            wp_sCmdSql = "Delete * from  PLLIM1 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLLIM2 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLLIM3 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PLLIM4 "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from  PELIM "
            wp_sCmdSql += "where sCodItm = '" & vp_sCodItm & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminar")
            Throw ex

        End Try
        Return wl_YesNo

    End Function
    Public Function cdEliminarPLLIM1(ByVal wp_ePLLIM1 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLLIM1
                wp_sCmdSql = "Delete * from  PLLIM1 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                wp_sCmdSql += "sCodCmt     = '" & .sCodCmt
                wp_sCmdSql += "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminarPLLIM1")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLLIM2(ByVal wl_ePLLIM2 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wl_ePLLIM2
                wp_sCmdSql = "Delete * from  PLLIM2 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                wp_sCmdSql += "sCodOpe     = '" & .sCodOpe
                wp_sCmdSql += "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminarPLLIM2")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLLIM3(ByVal wp_ePLLIM3 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLLIM3
                wp_sCmdSql = "Delete * from  PLLIM3 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                wp_sCmdSql += "sCodCIF     = '" & .sCodCIF
                wp_sCmdSql += "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With

        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminarPLLIM3")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
    Public Function cdEliminarPLLIM4(ByVal wp_ePLLIM4 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_ePLLIM4
                wp_sCmdSql = "Delete * from  PLLIM4 "
                wp_sCmdSql += " where "
                wp_sCmdSql += "(sCodItm     = '" & .sCodItm & "' and "
                wp_sCmdSql += "sCodCmt     = '" & .sCodCmt
                wp_sCmdSql += "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cdEliminarPLLIM4")
            Throw ex
        End Try

        Return wl_YesNo
    End Function
#End Region

End Class

