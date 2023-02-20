Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldConTbl
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wp_sCmdSql As String

    Public Function cddtCargarLista(ByVal wp_sNomTbl As String,
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
            MsgBox("Error en: cldConTbl.cddtCargarLista ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtCargarNro(ByVal wp_sNomTbl As String,
                                  ByVal wp_sCodDoc As String,
                                  ByRef wr_bEOF As Boolean) As DataTable

        Try
            Dim wp_sCmdSql As String
            wp_sCmdSql = "SELECT * FROM " & wp_sNomTbl & " T0"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.sCodDoc = "
            wp_sCmdSql += "'" & wp_sCodDoc & "'"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtCargarLista ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtSelSer(ByVal wp_sNomTbl As String,
                               ByVal wp_sCodDoc As String,
                               ByVal wp_sCodSer As String,
                               ByRef wr_bEOF As Boolean) As DataTable

        Try
            Dim wp_sCmdSql As String
            wp_sCmdSql = "SELECT * FROM " & wp_sNomTbl & " T0"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.sCodDoc = "
            wp_sCmdSql += "'" & wp_sCodDoc & "'"
            wp_sCmdSql += " AND "
            wp_sCmdSql += " T0.sCodSer = "
            wp_sCmdSql += "'" & wp_sCodSer & "'"
            wp_sCmdSql += " ORDER BY T0.sCodSer"

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtCargarLista ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtLst2Cmp(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp1 As String,
                                ByVal wp_sNomCmp2 As String,
                                ByRef wr_bEOF As Boolean) As DataTable

        Try
            wp_sCmdSql = "SELECT "
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += " , "
            wp_sCmdSql += wp_sNomCmp2
            wp_sCmdSql += " FROM " & wp_sNomTbl
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtBuscar ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtPrimero(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal wp_sDatCmp As String,
                                ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT TOP 1 * FROM " & wp_sNomTbl
            wp_sCmdSql += " T0"
            wp_sCmdSql += " ORDER BY T0.[" & wp_sNomCmp & "]"
            wl_DT = cdfdtConsultar(wp_sCmdSql,
                                   wr_bEOF)


            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtPrimero ")
            Return Nothing
            Throw ex
        End Try


    End Function
    Public Function cddtAnterior(ByVal wp_sNomTbl As String,
                               ByVal wp_sNomCmp As String,
                               ByVal wp_sDatCmp As String,
                               ByVal wp_sTipCmp As String,
                               ByRef wr_bEOF As Boolean) As DataTable

        Try
            wp_sCmdSql = "SELECT TOP 1 * FROM " & wp_sNomTbl
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " < "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            wp_sCmdSql += " ORDER BY " & wp_sNomCmp & " DESC"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtAnterior ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtSiguiente(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sTipCmp As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT TOP 1 * FROM " & wp_sNomTbl
            wp_sCmdSql += " WHERE " & wp_sNomCmp
            wp_sCmdSql += " > "

            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            wp_sCmdSql += " ORDER BY " & wp_sNomCmp
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtSiguiente ")
            Return Nothing
            Throw ex
        End Try


    End Function
    Public Function cddtUltimo(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal vp_sDatCmp As String,
                                ByRef wr_bEOF As Boolean) As DataTable

        Try
            wp_sCmdSql = "SELECT * FROM " & wp_sNomTbl
            wp_sCmdSql += " WHERE " & wp_sNomCmp
            wp_sCmdSql += " = (SELECT MAX("
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += ") FROM "
            wp_sCmdSql += wp_sNomTbl & " ) "

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtUltimo ")
            Return Nothing
            Throw ex
        End Try


    End Function
    Public Function cddtPrimeroMov(ByVal wp_sNomTbl As String,
                                   ByVal wp_sNomCmp As String,
                                   ByVal wp_sDatCmp As String,
                                   ByVal wp_sTipCmp As String,
                                   ByVal wp_sNomCmp1 As String,
                                   ByVal wp_sDatCmp1 As String,
                                   ByVal wp_sTipCmp1 As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT TOP 1 * FROM " & wp_sNomTbl
            wp_sCmdSql += " T0"
            If wp_sDatCmp <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0.[" & wp_sNomCmp & "]"
                wp_sCmdSql += " =  "
                wp_sCmdSql += "'" & wp_sDatCmp & "'"
            End If

            wp_sCmdSql += " ORDER BY T0.["
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += "]"
            wp_sCmdSql += " , "
            wp_sCmdSql += " T0.["
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += "]"

            wl_DT = cdfdtConsultar(wp_sCmdSql,
                                   wr_bEOF)

            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtPrimeroMov ")
            Return Nothing
            Throw ex
        End Try


    End Function
    Public Function cddtAnteriorMov(ByVal wp_sNomTbl As String,
                                    ByVal wp_sNomCmp As String,
                                    ByVal wp_sDatCmp As String,
                                    ByVal wp_sTipCmp As String,
                                    ByVal wp_sNomCmp1 As String,
                                    ByVal wp_sDatCmp1 As String,
                                    ByVal wp_sTipCmp1 As String,
                                    ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT TOP 1 * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0"
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
            wp_sCmdSql += " AND "
            wp_sCmdSql += "T0.["
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += "]"
            wp_sCmdSql += " < "
            If wp_sTipCmp1 = "N" Then
                wp_sCmdSql += wp_sDatCmp1
            Else
                If wp_sTipCmp = "B" Then
                    wp_sCmdSql += wp_sDatCmp1
                Else
                    If wp_sTipCmp1 = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
                    End If
                End If
            End If
            wp_sCmdSql += " ORDER BY "
            wp_sCmdSql += " T0.["
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += "]"
            wp_sCmdSql += " DESC ,"
            wp_sCmdSql += " T0.["
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += "]"
            wp_sCmdSql += " DESC"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtAnterior ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtSiguienteMov(ByVal wp_sNomTbl As String,
                                     ByVal wp_sNomCmp As String,
                                     ByVal wp_sDatCmp As String,
                                     ByVal wp_sTipCmp As String,
                                     ByVal wp_sNomCmp1 As String,
                                     ByVal wp_sDatCmp1 As String,
                                     ByVal wp_sTipCmp1 As String,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT TOP 1 * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += "T0.["
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
            wp_sCmdSql += " > "
            If wp_sTipCmp1 = "N" Then
                wp_sCmdSql += wp_sDatCmp1
            Else
                If wp_sTipCmp = "B" Then
                    wp_sCmdSql += wp_sDatCmp1
                Else
                    If wp_sTipCmp1 = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
                    End If
                End If
            End If
            wp_sCmdSql += " ORDER BY " & wp_sNomCmp
            wp_sCmdSql += " , " & wp_sNomCmp1

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtSiguiente ")
            Return Nothing
            Throw ex
        End Try


    End Function
    Public Function cddtUltimoMov(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sTipCmp As String,
                                  ByVal wp_sNomCmp1 As String,
                                  ByVal wp_sDatCmp1 As String,
                                  ByVal wp_sTipCmp1 As String,
                                  ByRef wr_bEOF As Boolean) As DataTable

        Try
            Dim wl_nCntRow As Integer
            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE "
            '   wp_sCmdSql += " T0.["
            '   wp_sCmdSql += wp_sNomCmp
            '   wp_sCmdSql += "]"
            '   wp_sCmdSql += " = "
            '   If wp_sTipCmp = "N" Then
            ' wp_sCmdSql += wp_sDatCmp
            ' Else
            ' If wp_sTipCmp = "F" Then
            ' wp_sCmdSql += "#" & wp_sDatCmp & "#"
            ' Else
            ' wp_sCmdSql += "'" & wp_sDatCmp & "'"
            ' End If
            ' End If
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

            wp_sCmdSql += " AND "
            wp_sCmdSql += wp_sNomCmp1

            wp_sCmdSql += " = (SELECT MAX("
            wp_sCmdSql += " T0.["
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += "]"
            wp_sCmdSql += ") FROM "
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
            wp_sCmdSql += " )"



            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            wl_nCntRow = wl_DT.Rows.Count
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtUltimo ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtBuscar(ByVal wp_sNomTbl As String,
                               ByVal wp_sNomCmp As String,
                               ByVal wp_sDatCmp As String,
                               ByVal wp_sTipCmp As String,
                               ByVal wp_sCmpOrd As String,
                               ByVal wp_sTipOrd As String,
                               ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT  * FROM " & wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE T0.["
            wp_sCmdSql += wp_sNomCmp & "] = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            If wp_sCmpOrd <> "" Then
                wp_sCmdSql += " ORDER BY T0." & wp_sCmpOrd
                If wp_sTipOrd = "D" Then
                    wp_sCmdSql += " DESC"
                End If
            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wr_bEOF = False Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtBuscar ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtBuscarE2(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByVal wp_sTipCmp As String,
                                 ByVal wp_sNomCmp1 As String,
                                 ByVal wp_sDatCmp1 As String,
                                 ByVal wp_sTipCmp1 As String,
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
                If wp_sTipCmp = "B" Then
                    wp_sCmdSql += wp_sDatCmp
                Else
                    If wp_sTipCmp = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp & "'"
                    End If
                End If
            End If

            wp_sCmdSql += " AND T0.[" & wp_sNomCmp1
            wp_sCmdSql += "]"
            wp_sCmdSql += " = "
            If wp_sTipCmp1 = "N" Then
                wp_sCmdSql += wp_sDatCmp1
            Else
                If wp_sTipCmp = "B" Then
                    wp_sCmdSql += wp_sDatCmp1
                Else
                    If wp_sTipCmp1 = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
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
            MsgBox("Error en: cldConTbl.cddtBuscar ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtCon1Lla2Tbl(ByVal wp_sNomTbl As String,
                                    ByVal wp_sNomCmp As String,
                                    ByVal wp_sDatCmp As String,
                                    ByVal wp_sTipCmp As String,
                                    ByVal wp_sNomTbl1 As String,
                                    ByVal wp_sNomSel As String,
                                    ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT "
            wp_sCmdSql += "T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " , "
            wp_sCmdSql += "T1."
            wp_sCmdSql += wp_sNomSel
            wp_sCmdSql += " from "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += " T1"
            wp_sCmdSql += " ON "
            wp_sCmdSql += "T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            wp_sCmdSql += "T1."
            wp_sCmdSql += wp_sNomCmp

            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#"
                    wp_sCmdSql += wp_sDatCmp
                    wp_sCmdSql += "#"
                Else
                    wp_sCmdSql += "'"
                    wp_sCmdSql += wp_sDatCmp
                    wp_sCmdSql += "'"
                End If
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtCon1Lla2Tbl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtCon1Lla1Cmp2Tbl(ByVal wp_sNomTbl As String,
                                        ByVal wp_sNomCmp As String,
                                        ByVal wp_sDatCmp As String,
                                        ByVal wp_sTipCmp As String,
                                        ByVal wp_sNomCmp1 As String,
                                        ByVal wp_sDatCmp1 As String,
                                        ByVal wp_sTipCmp1 As String,
                                        ByVal wp_sNomTbl1 As String,
                                        ByVal wp_sNomSel As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT "
            wp_sCmdSql += "*"
            '  wp_sCmdSql += " , "
            '  wp_sCmdSql += wp_sNomTbl1
            '  wp_sCmdSql += ".*"
            wp_sCmdSql += " FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += " ON "
            wp_sCmdSql += "("
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += ")"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "("
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += " = "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += ")"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " AND "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += " = "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += "."
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql = "SELECT * FROM IEDMI T0 INNER JOIN ILDMI1 T1 ON (T0.sCodItm = T1.sCodItm)"
            wp_sCmdSql += " AND (T0.sCodAlm = T1.sCodAlm)"

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)


            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtCon1Lla2Tbl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtCon2Lla2Tbl(ByVal wp_sNomTbl As String,
                                    ByVal wp_sNomCmp As String,
                                    ByVal wp_sDatCmp As String,
                                    ByVal wp_sTipCmp As String,
                                    ByVal wp_sNomCmp1 As String,
                                    ByVal wp_sDatCmp1 As String,
                                    ByVal wp_sTipCmp1 As String,
                                    ByVal wp_sNomTbl1 As String,
                                    ByVal wp_sNomSel As String,
                                    ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT "
            wp_sCmdSql += "T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " , "
            wp_sCmdSql += "T1."
            wp_sCmdSql += wp_sNomSel
            wp_sCmdSql += " from "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " INNER JOIN "
            wp_sCmdSql += wp_sNomTbl1
            wp_sCmdSql += " T1"
            wp_sCmdSql += " ON "
            wp_sCmdSql += "("
            wp_sCmdSql += "T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            wp_sCmdSql += "T1."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += ")"
            wp_sCmdSql += " AND "
            wp_sCmdSql += "("
            wp_sCmdSql += "T0."
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += " = "
            wp_sCmdSql += "T1."
            wp_sCmdSql += wp_sNomCmp1
            wp_sCmdSql += ")"
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#"
                    wp_sCmdSql += wp_sDatCmp
                    wp_sCmdSql += "#"
                Else
                    wp_sCmdSql += "'"
                    wp_sCmdSql += wp_sDatCmp
                    wp_sCmdSql += "'"
                End If
            End If
            wp_sCmdSql += " AND "
            wp_sCmdSql += " T0."
            wp_sCmdSql += wp_sNomCmp
            wp_sCmdSql += " = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#"
                    wp_sCmdSql += wp_sDatCmp
                    wp_sCmdSql += "#"
                Else
                    wp_sCmdSql += "'"
                    wp_sCmdSql += wp_sDatCmp
                    wp_sCmdSql += "'"
                End If
            End If

            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)


            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtCon1Lla2Tbl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConEOF(ByVal wp_sNomTbl As String,
                               ByVal wp_sNomCmp As String,
                               ByVal wp_sDatCmp As String,
                               ByVal wp_sTipCmp As String,
                               ByVal wp_sCmpOrd As String,
                               ByVal wp_sTipOrd As String,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wp_sCmdSql = "SELECT  * FROM " & wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE T0.["
            wp_sCmdSql += wp_sNomCmp & "] = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If

            End If
            If wp_sCmpOrd <> "" Then
                wp_sCmdSql += " ORDER BY " & wp_sCmpOrd
                If wp_sTipOrd = "D" Then
                    wp_sCmdSql += " DESC"
                End If
            End If


            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT.Rows.Count = 0 Then
                wr_bEOF = True
            Else
                wr_bEOF = False
            End If
            Return wr_bEOF
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtConEOF ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConEOF1Tbl2Cmp(ByVal wp_sNomTbl As String,
                                       ByVal wp_sNomCmp As String,
                                       ByVal wp_sDatCmp As String,
                                       ByVal wp_sTipCmp As String,
                                       ByVal wp_sNomCmp1 As String,
                                       ByVal wp_sDatCmp1 As String,
                                       ByVal wp_sTipCmp1 As String,
                                       ByRef wr_bEOF As Boolean) As Boolean
        ' Consulta 1 tabla y 2 campos.
        ' Fec_Ult_Act : 2014.04.20

        Try
            wp_sCmdSql = "SELECT  * FROM " & wp_sNomTbl
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE T0.["
            wp_sCmdSql += wp_sNomCmp & "] = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If

            End If
            wp_sCmdSql += " AND T0.["
            wp_sCmdSql += wp_sNomCmp1 & "] = "
            If wp_sTipCmp1 = "N" Then
                wp_sCmdSql += wp_sDatCmp1
            Else
                If wp_sTipCmp1 = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
                End If

            End If
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT.Rows.Count = 0 Then
                wr_bEOF = True
            Else
                wr_bEOF = False
            End If
            Return wr_bEOF
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtConEOF ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function ANT_cddtConILDMI2(ByVal wp_sNomTbl As String,
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
    Public Function cddtConATIVA(ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            wp_sCmdSql = "SELECT * FROM ATIVA T0 "
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += "T0.sClsDoc = "
            wp_sCmdSql += "'" & wp_sDatCmp & "'"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConATIVA")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConTEDMT_ILDMI2(ByVal wp_sNomTbl As String,
                                        ByVal wp_sNomCmp As String,
                                        ByVal wp_sDatCmp As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try

            wp_sCmdSql = "SELECT * FROM TEDMT T0 INNER JOIN ILDMI2 T1 ON (T0.sCodItm = T1.sCodItm)"
            wp_sCmdSql += " AND (T0.sCodTer = T1.sCodTer)"

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
    Public Function cddtAPDGV(ByVal wp_sNomTbl As String,
                              ByVal wp_sNomCmp As String,
                              ByVal wp_sDatCmp As String,
                              ByVal wp_sTipCmp As String,
                              ByVal wp_sNomCmp1 As String,
                              ByVal wp_sDatCmp1 As String,
                              ByVal wp_sTipCmp1 As String,
                              ByVal wp_sCmpOrd As String,
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
                If wp_sTipCmp = "B" Then
                    wp_sCmdSql += wp_sDatCmp
                Else
                    If wp_sTipCmp = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp & "'"
                    End If
                End If
            End If

            wp_sCmdSql += " AND T0.[" & wp_sNomCmp1
            wp_sCmdSql += "]"
            wp_sCmdSql += " = "
            If wp_sTipCmp1 = "N" Then
                wp_sCmdSql += wp_sDatCmp1
            Else
                If wp_sTipCmp = "B" Then
                    wp_sCmdSql += wp_sDatCmp1
                Else
                    If wp_sTipCmp1 = "F" Then
                        wp_sCmdSql += "#" & wp_sDatCmp1 & "#"
                    Else
                        wp_sCmdSql += "'" & wp_sDatCmp1 & "'"
                    End If
                End If
            End If
            wp_sCmdSql += " ORDER BY "
            wp_sCmdSql += wp_sNomCmp & ","
            wp_sCmdSql += wp_sNomCmp1 & ","
            wp_sCmdSql += wp_sCmpOrd



            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtBuscar ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConABEPC(ByVal wp_sCodPdo As String,
                                 ByRef wr_bEOF As Boolean) As DataTable

        Try
            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += " ABEPC "
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.sCodPdoc ="
            wp_sCmdSql += "'" & wp_sCodPdo & "'"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtConABEPC ")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cddtConABOPC(ByVal wp_sCodOpc As String,
                                 ByRef wr_bEOF As Boolean) As DataTable

        Try
            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += " ABOPC "
            wp_sCmdSql += " T0 "
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += " T0.sCodOpc ="
            wp_sCmdSql += "'" & wp_sCodOpc & "'"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cddtConABOPC ")
            Return Nothing
            Throw ex
        End Try
    End Function

End Class
