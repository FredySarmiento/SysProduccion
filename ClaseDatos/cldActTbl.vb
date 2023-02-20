
Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldActTbl
    Inherits cldFunciones

    Dim wl_DT As New DataTable
    'wl_YesNo = Yes,operacion correcta. No, operación incorrecta
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Public Function cddtActRegUnaLlaUnCmp(ByVal wp_sNomTbl,
                                   ByVal wp_sNomLla,
                                   ByVal wp_sDatLla,
                                   ByVal wp_sTipLla,
                                   ByVal wp_sNomCmp,
                                   ByVal wp_sDatCmp,
                                   ByVal wp_sTipCmp,
                                   ByRef wr_bEOF) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Update " & wp_sNomTbl
            wp_sCmdSql += " SET "
            wp_sCmdSql += wp_sNomCmp & " = "

            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += wp_sNomLla & " = "

            If wp_sTipLla = "N" Then
                wp_sCmdSql += wp_sDatLla
            Else
                If wp_sTipLla = "F" Then
                    wp_sCmdSql += "#" & wp_sDatLla & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatLla & "'"
                End If
            End If
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldActTbl.cddtActRegUnaLlaUnCmp")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtActRegDosLlaUnCmp(ByVal wp_sNomTbl,
                                          ByVal wp_sNomLla,
                                          ByVal wp_sDatLla,
                                          ByVal wp_sTipLla,
                                          ByVal wp_sNomLla1,
                                          ByVal wp_sDatLla1,
                                          ByVal wp_sTipLla1,
                                          ByVal wp_sNomCmp,
                                          ByVal wp_sDatCmp,
                                          ByVal wp_sTipCmp,
                                          ByRef wr_bEOF) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Update " & wp_sNomTbl
            wp_sCmdSql += " SET "
            wp_sCmdSql += wp_sNomCmp & " = "

            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            wp_sCmdSql += " WHERE "
            wp_sCmdSql += wp_sNomLla & " = "

            If wp_sTipLla = "N" Then
                wp_sCmdSql += wp_sDatLla
            Else
                If wp_sTipLla = "F" Then
                    wp_sCmdSql += "#" & wp_sDatLla & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatLla & "'"
                End If
            End If
            wp_sCmdSql += " AND "
            wp_sCmdSql += wp_sNomLla1 & " = "

            If wp_sTipLla1 = "N" Then
                wp_sCmdSql += wp_sDatLla1
            Else
                If wp_sTipLla1 = "F" Then
                    wp_sCmdSql += "#" & wp_sDatLla1 & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatLla1 & "'"
                End If
            End If


            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
        Catch ex As Exception
            MsgBox("Error: cldActTbl.cddtActRegDosLlaUnCmp")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliReg(ByVal wp_sNomTbl As String,
                          ByVal wp_sNomCmp As String,
                          ByVal wp_sDatCmp As String,
                          ByVal wp_sTipCmp As String,
                          ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " where "
            wp_sCmdSql += wp_sNomCmp & " = "

            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error: cldActTbl.cdEliReg")
            Throw ex

        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliRegLin(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal wp_sDatCmp As String,
                                ByVal wp_sTipCmp As String,
                                ByRef wr_bEOF As Boolean) As Boolean


        Try
            wl_YesNo = False
            wp_sCmdSql = "Delete * from  "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " where "
            wp_sCmdSql += wp_sNomCmp & " = "
            If wp_sTipCmp = "N" Then
                wp_sCmdSql += wp_sDatCmp
            Else
                If wp_sTipCmp = "F" Then
                    wp_sCmdSql += "#" & wp_sDatCmp & "#"
                Else
                    wp_sCmdSql += "'" & wp_sDatCmp & "'"
                End If
            End If

            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)

        Catch ex As Exception
            MsgBox("Error: cldActTbl.cdEliRegLin")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class
