Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldPEROP
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wl_nIdEnc As Long
    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand
    Public Function cdActPLODP2(ByVal wp_ePLROP1 As Object) As Boolean
        Try
            wl_YesNo = True
            With wp_ePLROP1
                wl_YesNo = False
                wp_sCmdSql = "Update PLODP2 T0"
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
            MsgBox("Error : cldPEROP.cdActPLODP2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConsultar(ByVal vp_sCodDoc,
                                  ByVal vp_nNroDoc,
                                  ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "select * from PEROP T0 "
            If vp_sCodDoc <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.sCodDoc = '" & vp_sCodDoc & "' "
                If vp_nNroDoc <> 0 Then
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.nNroDoc = " & vp_nNroDoc
                End If
            End If
            wp_sCmdSql += " ORDER BY T0.sCodDoc, T0.nNroDoc "
            wl_DT = cdfdtConsultar(wp_sCmdSql,
                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: cldPEROP.cddtConsultar ")
            Throw ex
        End Try

        Return wl_DT
    End Function
    Public Function cddtConPLEROP_Grl(ByVal wp_ePEROP As Object,
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


            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_ePEROP
                wp_sCmdSql = "SELECT * "
                wp_sCmdSql += " from "
                wp_sCmdSql += "(PEROP T0 "
                wp_sCmdSql += " INNER JOIN PLROP1 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc"
                wp_sCmdSql += " and "
                wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc"
                wp_sCmdSql += ")"


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
                        wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc & " "
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
                        wp_sCmdSql += " T0.sCodTer = '" & .sCodTer & "'"
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

                If .nNroDocBas <> -1 Then
                    If .nNroDocbas <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.nNroDocBas = " & .nNroDocBas & " "
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
                            Case 7.0R
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
                        wp_sCmdSql += " T0.dFecDoc = #" & wl_sFecDocIni & "# "

                    End If
                End If

                wl_bComa = False
                wp_sCmdSql += " ORDER BY "

                wp_sCmdSql += "T0.sTipMov, "
                wp_sCmdSql += "T0.sCodDoc, "
                wp_sCmdSql += "T0.sCodSer, "
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
            MsgBox("Error : cldPEROP.cddtConPEROP_QIniFin")
            Return Nothing
            Throw ex
        End Try
        Return Nothing
    End Function
    Public Function cddtConPEROP_Grl(ByVal wp_sNomTbl As String,
                                   ByVal wp_ePEROP As Object,
                                   ByVal wp_sMayMenIgu As String,
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


            wl_WHERE = " WHERE "
            wl_AND = " AND "
            wl_bComa = False

            With wp_ePEROP
               
                wp_sCmdSql = "SELECT * "
                wp_sCmdSql += " FROM PEROP T0"
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
                            Case 7.0R
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
                        wp_sCmdSql += " T0.dFecDoc = #" & wl_sFecDocIni & "# "

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
            MsgBox("Error : cldPEROP.cddtConPEROP_Grl")
            Return Nothing
            Throw ex
        End Try

    End Function
    Public Function cddtConPEROP_QIniFin(ByVal wp_sNomTbl As String,
                                        ByVal wp_ePEROP_Ini As Object,
                                        ByVal wp_ePEROP_Fin As Object,
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

            With wp_ePEROP_Ini
                wp_sCmdSql = "SELECT * "
                wp_sCmdSql += " from "
                wp_sCmdSql += "("
                wp_sCmdSql += wp_sNomTbl
                wp_sCmdSql += " T0 "
                wp_sCmdSql += " INNER JOIN PLROP1 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc"
                wp_sCmdSql += " and "
                wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc"
                wp_sCmdSql += ")"


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

                If wp_ePEROP_Fin.sCodDoc <> "" Then
                    If wp_ePEROP_Fin.sCodDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodDoc <= '" & wp_ePEROP_Fin.sCodDoc & "'"
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

                If wp_ePEROP_Fin.nNroDoc <> -1 Then
                    If wp_ePEROP_Fin.nNroDoc <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.nNroDoc <= " & wp_ePEROP_Fin.nNroDoc & " "
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

                If wp_ePEROP_Fin.sCodSer <> "" Then
                    If wp_ePEROP_Fin.sCodSer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodSer <= '" & wp_ePEROP_Fin.sCodSer & "'"
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

                If wp_ePEROP_Fin.sCodTer <> "" Then
                    If wp_ePEROP_Fin.sCodTer <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sCodTer <= '" & wp_ePEROP_Fin.sCodTer & "'"
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

                If wp_ePEROP_Fin.sEstDoc <> "" Then
                    If wp_ePEROP_Fin.sEstDoc <> " " Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T0.sEstDoc <= '" & wp_ePEROP_Fin.sEstDoc & "'"
                    End If
                End If
                If .nNroDocBas <> -1 Then
                    If .nNroDocbas <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.nNroDocBas >= " & .nNroDocBas & " "
                    End If
                End If

                If wp_ePEROP_Fin.nNroDocBas <> -1 Then
                    If wp_ePEROP_Fin.nNroDocBas <> 0 Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        wp_sCmdSql += " T1.nNroDocBas <= " & wp_ePEROP_Fin.nNroDocBas & " "
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
                            Case 7.0R
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
                If wp_ePEROP_Fin.dFecDoc <> Nothing Then
                    If wp_ePEROP_Fin.dFecDoc <> #1/1/1901# Then
                        If wl_WHERE <> "" Then
                            wp_sCmdSql += wl_WHERE
                            wl_WHERE = ""
                        Else
                            wp_sCmdSql += wl_AND
                        End If
                        '  wp_sCmdSql += " T0.dFecDoc >= #" & wl_sFecDocIni & "# "
                        wl_sDDFin = DatePart(DateInterval.Day, wp_ePEROP_Fin.dFecDoc)
                        wl_nMMFin = DatePart(DateInterval.Month, wp_ePEROP_Fin.dFecDoc)
                        wl_sDDFin = DatePart(DateInterval.Day, wp_ePEROP_Fin.dFecDoc)
                        wl_nMMFin = DatePart(DateInterval.Month, wp_ePEROP_Fin.dFecDoc)
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
                        wl_sYYYYFin = DatePart(DateInterval.Year, wp_ePEROP_Fin.dFecDoc)
                        wl_sFecDocFin = wl_sDDFin & "-" & wl_sMMMFin & "-" & wl_sYYYYFin
                        wp_sCmdSql += " T0.dFecDoc <= #" & wl_sFecDocFin & "# "
                    End If
                End If

                wl_bComa = False
                wp_sCmdSql += " ORDER BY "

                wp_sCmdSql += "T0.sTipMov, "
                wp_sCmdSql += "T0.sCodDoc, "
                wp_sCmdSql += "T0.sCodSer, "
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
            MsgBox("Error : cldPEROP.cddtConPEROP_QIniFin")
            Return Nothing
            Throw ex
        End Try
        Return Nothing
    End Function
    Public Function cddtConsultarPLROP1(ByVal wp_sNomTbl As String,
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
                wp_sCmdSql += " INNER JOIN PEROP T1 "
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
            MsgBox("Error: cldPEROP.cddtConsultarPLROP1 ")
            Throw ex
        End Try
        Return wl_DT
    End Function
    Public Function cddtConPLROP1_DocBas(ByVal wp_sNomTbl As String,
                                         ByVal vp_sCodDocBas As String,
                                         ByVal vp_nNroDocBas As Double,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_nCntReg As Integer

            wp_sCmdSql = "select *"
            wp_sCmdSql += " from "
            wp_sCmdSql += "("
            wp_sCmdSql += " PEROP"
            wp_sCmdSql += " T0 "
            If vp_sCodDocBas IsNot Nothing Then
                wp_sCmdSql += " INNER JOIN PLROP1 T1 "
                wp_sCmdSql += " ON "
                wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc"
                wp_sCmdSql += " and "
                wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc"
                wp_sCmdSql += ")"
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += " T1.sCodDocBas = '" & vp_sCodDocBas & "' "
                wp_sCmdSql += " AND "
                wp_sCmdSql += " T1.nNroDocBas = " & vp_nNroDocBas
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntReg = wl_DT.Rows.Count

        Catch ex As Exception
            MsgBox("Error: cldPEROP.cddtConPLROP1_DocBas ")
            Throw ex
        End Try
        Return wl_DT
    End Function
    Public Function cddtConGLROP1(ByVal wp_sNomCmp As String,
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
            Dim wl_nCntReg As Integer
            wr_bEOF = False
            wp_sCmdSql = "select *"
            wp_sCmdSql += " from "
            wp_sCmdSql += "("
            wp_sCmdSql += " PLROP1 T0 "
            '    wp_sCmdSql += " INNER JOIN PEROP T1 "
            '   wp_sCmdSql += " ON "
            '  wp_sCmdSql += "T0.sCodDoc = T1.sCodDoc"
            ' wp_sCmdSql += " and "
            'wp_sCmdSql += "T0.nNroDoc = T1.nNroDoc"
            wp_sCmdSql += ")"
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
            wl_nCntReg = wl_DT.Rows.Count
            If wl_nCntReg > 0 Then
                wr_bEOF = False
            End If

        Catch ex As Exception
            MsgBox("Error: cldPEROP.cddtConGLROP1 ")
            Throw ex
        End Try
        Return wl_DT
    End Function
    Public Function cddtConPLROP1(ByVal wp_ePLROP1 As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_WHERE As String
            Dim wl_AND As String

            Dim wl_nCntReg As Integer

            wl_WHERE = " WHERE "
            wl_AND = " AND "


            wr_bEOF = False
            wp_sCmdSql = "SELECT * FROM PLROP1 T0"
            With wp_ePLROP1
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
                        wp_sCmdSql += " T0.nNroDoc = " & .nNroDoc & " "
                    End If
                End If
            End With

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntReg = wl_DT.Rows.Count
            If wl_nCntReg > 0 Then
                wr_bEOF = False
            End If

        Catch ex As Exception
            MsgBox("Error: cldPEROP.cddtConPLROP1 ")
            Throw ex
        End Try
        Return wl_DT
    End Function
    'Public Function cdCrearAct(ByVal wp_ePEROP As Object,
    '                           ByRef wr_nIdEnc As Integer,
    '                           ByVal wp_sCmdSel As String) As Boolean

    Public Function cdCrearAct(ByVal wp_ePEROP As Object,
                               ByRef wr_nIdEnc As Integer,
                               ByVal wp_sCmdSel As String) As Long


        Try
            wl_YesNo = True
            wl_nIdEnc = 0
            Dim vl_sFecCtb As String
            Dim vl_sFecDoc As String
            Dim vl_sFecSys As String
            Dim vl_sFecVto As String
            With wp_ePEROP
                vl_sFecCtb = cdf_dDMY_MDY(.dFecCtb)
                vl_sFecDoc = cdf_dDMY_MDY(.dFecDoc)
                vl_sFecSys = cdf_dDMY_MDY(.dFecSys)
                vl_sFecVto = cdf_dDMY_MDY(.dFecVto)
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PEROP "
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
                    wl_nIdEnc = cdfDevuelveID("SELECT max(nId) from PEROP")
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PEROP "
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
                    wp_sCmdSql += "nTotHHOpe   = " & .nTotHHOpe & ", "
                    wp_sCmdSql += "nTotMMOpe   = " & .nTotMMOpe & ", "
                    wp_sCmdSql += "nTotTieOpe  = " & .nTotTieOpe & ", "
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
                    wp_sCmdSql += "sCodUsr     = '" & .sCodUsr & "', "
                    wp_sCmdSql += "bPrp01      = " & .bPrp01 & ", "
                    wp_sCmdSql += "bPrp02      = " & .bPrp02 & ", "
                    wp_sCmdSql += "bPrp03      = " & .bPrp03 & ", "
                    wp_sCmdSql += "nTotHHAlz   = " & .nTotHHAlz & ", "
                    wp_sCmdSql += "nTotMMAlz   = " & .nTotMMAlz & ", "
                    wp_sCmdSql += "nTotTieAlz  = " & .nTotTieAlz & ", "
                    wp_sCmdSql += "nTotHHCaf   = " & .nTotHHCaf & ", "
                    wp_sCmdSql += "nTotMMCaf   = " & .nTotMMCaf & ", "
                    wp_sCmdSql += "nTotTieCaf  = " & .nTotTieCaf & ", "
                    wp_sCmdSql += "nTotHHCns   = " & .nTotHHCns & ", "
                    wp_sCmdSql += "nTotMMCns   = " & .nTotMMCns & ", "
                    wp_sCmdSql += "nTotTieCns  = " & .nTotTieCns
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
            MsgBox("Error : cldPEROP.cdCrearAct")
            Throw ex
        End Try
        'Return wl_YesNo
        Return wl_nIdEnc
    End Function
    Public Function cdCrearActPLROP1(ByVal wl_ePLROP1 As Object,
                                     ByVal wr_bEOFL1 As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wl_ePLROP1
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into PLROP1 "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodDoc, "
                    wp_sCmdSql += "nNroDoc, "
                    wp_sCmdSql += "sCodSer, "
                    wp_sCmdSql += "sTipMov, "
                    wp_sCmdSql += "sCodDocBas,  "
                    wp_sCmdSql += "sCodSerBas,  "
                    wp_sCmdSql += "nNroDocBas,  "
                    wp_sCmdSql += "sCodItm,  "
                    wp_sCmdSql += "nCanItm,  "
                    wp_sCmdSql += "sCodOpe,  "
                    wp_sCmdSql += "sNomOpe,  "
                    wp_sCmdSql += "nHHIniOpe,  "
                    wp_sCmdSql += "nMMIniOpe,  "
                    wp_sCmdSql += "nHHFinOpe,  "
                    wp_sCmdSql += "nMMFinOpe,  "
                    wp_sCmdSql += "nHHCnsOpe,  "
                    wp_sCmdSql += "nMMCnsOpe,  "
                    wp_sCmdSql += "nTieCnsOpe,  "
                    wp_sCmdSql += "nHHCns,  "
                    wp_sCmdSql += "nMMCns,  "
                    wp_sCmdSql += "nTieCns,  "
                    wp_sCmdSql += "nTieReq,  "
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
                    wp_sCmdSql += "sCodCtr, "
                    wp_sCmdSql += "nHHIniAlz,  "
                    wp_sCmdSql += "nMMIniAlz,  "
                    wp_sCmdSql += "nHHFinAlz,  "
                    wp_sCmdSql += "nMMFinAlz,  "
                    wp_sCmdSql += "nHHCnsAlz,  "
                    wp_sCmdSql += "nMMCnsAlz,  "
                    wp_sCmdSql += "nTieCnsAlz,  "
                    wp_sCmdSql += "nHHIniCaf,  "
                    wp_sCmdSql += "nMMIniCaf,  "
                    wp_sCmdSql += "nHHFinCaf,  "
                    wp_sCmdSql += "nMMFinCaf,  "
                    wp_sCmdSql += "nHHCnsCaf,  "
                    wp_sCmdSql += "nMMCnsCaf,  "
                    wp_sCmdSql += "nTieCnsCaf,  "
                    wp_sCmdSql += "nIdPEROP "

                    wp_sCmdSql += ") "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "'" & .sCodDoc & "', "
                    wp_sCmdSql += .nNroDoc & " , "
                    wp_sCmdSql += "'" & .sCodSer & "', "
                    wp_sCmdSql += "'" & .sTipMov & "', "
                    wp_sCmdSql += "'" & .sCodDocBas & "', "
                    wp_sCmdSql += "'" & .sCodSerBas & "', "
                    wp_sCmdSql += .nNroDocBas & ", "
                    wp_sCmdSql += "'" & .sCodItm & "', "
                    wp_sCmdSql += .nCanItm & ", "
                    wp_sCmdSql += "'" & .sCodOpe & "', "
                    wp_sCmdSql += "'" & .sNomOpe & "', "
                    wp_sCmdSql += .nHHIniOpe & ", "
                    wp_sCmdSql += .nMMIniOpe & ", "
                    wp_sCmdSql += .nHHFinOpe & ", "
                    wp_sCmdSql += .nMMFinOpe & ", "
                    wp_sCmdSql += .nHHCnsOpe & ", "
                    wp_sCmdSql += .nMMCnsOpe & ", "
                    wp_sCmdSql += .nTieCnsOpe & ", "
                    wp_sCmdSql += .nHHCns & ", "
                    wp_sCmdSql += .nMMCns & ", "
                    wp_sCmdSql += .nTieCns & ", "
                    wp_sCmdSql += .nTieReq & ", "
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
                    wp_sCmdSql += "'" & .sCodCtr & "', "
                    wp_sCmdSql += .nHHIniAlz & ", "
                    wp_sCmdSql += .nMMIniAlz & ", "
                    wp_sCmdSql += .nHHFinAlz & ", "
                    wp_sCmdSql += .nMMFinAlz & ", "
                    wp_sCmdSql += .nHHCnsAlz & ", "
                    wp_sCmdSql += .nMMCnsAlz & ", "
                    wp_sCmdSql += .nTieCnsAlz & ", "
                    wp_sCmdSql += .nHHIniCaf & ", "
                    wp_sCmdSql += .nMMIniCaf & ", "
                    wp_sCmdSql += .nHHFinCaf & ", "
                    wp_sCmdSql += .nMMFinCaf & ", "
                    wp_sCmdSql += .nHHCnsCaf & ", "
                    wp_sCmdSql += .nMMCnsCaf & ", "
                    wp_sCmdSql += .nTieCnsCaf & ", "
                    wp_sCmdSql += .nIdPEROP & " )"
                    'wp_sCmdSql += " )"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    'If wp_sCmdSel = "A" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update PLROP1 "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sTipMov     = '" & .sTipMov & "', "
                    wp_sCmdSql += "sCodDocBas  = '" & .sCodDocBas & "', "
                    wp_sCmdSql += "sCodSerBas  = '" & .sCodSerBas & "', "
                    wp_sCmdSql += "nNroDocBas  = " & .nNroDocBas & " ,"
                    wp_sCmdSql += "sCodItm     = '" & .sCodItm & "', "
                    wp_sCmdSql += "nCanItm     = " & .nCanItm & " ,"
                    wp_sCmdSql += "sCodOpe     = '" & .sCodOpe & "', "
                    wp_sCmdSql += "sNomOpe     = '" & .sNomOpe & "', "
                    wp_sCmdSql += "nHHIniOpe   = " & .nHHIniOpe & ", "
                    wp_sCmdSql += "nMMIniOpe   =  " & .nMMIniOpe & ", "
                    wp_sCmdSql += "nHHFinOpe   = " & .nHHFinOpe & ", "
                    wp_sCmdSql += "nMMFinOpe   = " & .nMMFinOpe & ", "
                    wp_sCmdSql += "nHHCnsOpe   = " & .nHHCnsOpe & ", "
                    wp_sCmdSql += "nMMCnsOpe   = " & .nMMCnsOpe & ", "
                    wp_sCmdSql += "nTieCnsOpe     = " & .nTieCnsOpe & ", "
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
                    wp_sCmdSql += "sCodCtr     = '" & .sCodCtr & "', "
                    wp_sCmdSql += "nHHIniAlz   = " & .nHHIniAlz & ", "
                    wp_sCmdSql += "nMMIniAlz   =  " & .nMMIniAlz & ", "
                    wp_sCmdSql += "nHHFinAlz   = " & .nHHFinAlz & ", "
                    wp_sCmdSql += "nMMFinAlz   = " & .nMMFinAlz & ", "
                    wp_sCmdSql += "nHHCnsAlz   = " & .nHHCnsAlz & ", "
                    wp_sCmdSql += "nMMCnsAlz   = " & .nMMCnsAlz & ", "
                    wp_sCmdSql += "nTieCnsAlz  = " & .nTieCnsAlz & ", "
                    wp_sCmdSql += "nHHIniCaf   = " & .nHHIniCaf & ", "
                    wp_sCmdSql += "nMMIniCaf   =  " & .nMMIniCaf & ", "
                    wp_sCmdSql += "nHHFinCaf   = " & .nHHFinCaf & ", "
                    wp_sCmdSql += "nMMFinCaf   = " & .nMMFinCaf & ", "
                    wp_sCmdSql += "nHHCnsCaf   = " & .nHHCnsCaf & ", "
                    wp_sCmdSql += "nMMCnsCaf   = " & .nMMCnsCaf & ", "
                    wp_sCmdSql += "nTieCnsCaf  = " & .nTieCnsCaf
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "nId         = " & .nId
                    ' wp_sCmdSql += "nId         = 6"
                    wp_sCmdSql += ")"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With

        Catch ex As Exception
            MsgBox("Error : cldPEODP.cdCrearActualizarPLODP1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliminar(ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from PLROP1 "
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += "and nNrodoc = '" & vp_nNroDoc & "'"

            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

            wp_sCmdSql = "Delete * from PEROP"
            wp_sCmdSql += "where sCodDoc = '" & vp_sCodDoc & "'"
            wp_sCmdSql += "AND  sNroDoc = '" & vp_nNroDoc & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error: cldPEROP.cdEliminar ")
            Throw ex

        End Try
        Return wl_YesNo
    End Function
End Class
