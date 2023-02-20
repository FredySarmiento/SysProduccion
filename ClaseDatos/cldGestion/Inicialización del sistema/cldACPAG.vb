Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldACPAG
    Inherits cldFunciones
    Dim oCmdSql = New OleDbCommand
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim wl_DT As DataTable

    Public Function cddtConACPAG(ByRef wp_eACPAG As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable

        Try

            With wp_eACPAG
                wp_sCmdSql = "SELECT * FROM "
                wp_sCmdSql += "ACPAG T0"

                If .sCodCia <> "" Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "T0.sCodCia = '" & .sCodCia & "' "
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "T0.sCodUsr = '" & .sCodUsr & "' "
                End If

                wp_sCmdSql += "ORDER BY T0.sCodCia"

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldACPAG.cddtConACPAG")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActACPAG(ByVal wp_eACPAG As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean

        Try
            wl_YesNo = True

            With wp_eACPAG


                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into ACPAG "
                    wp_sCmdSql += "(sCodCia, "
                    wp_sCmdSql += " sCodUsr) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodCia & ",'"
                    wp_sCmdSql += .sCodUsr & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wp_sCmdSql = "Update ACPAG "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "bLmtCre   = " & .bLmtCre & ", "
                    wp_sCmdSql += "sCndPagxDefCli   = '" & .sCndPagxDefCli & "', "
                    wp_sCmdSql += "sMetPagxDefCli   = '" & .sMetPagxDefCli & "', "
                    wp_sCmdSql += "sCndPagxDefPro   = '" & .sCndPagxDefPro & "', "
                    wp_sCmdSql += "sMetPagxDefPro   = '" & .sMetPagxDefPro & "', "
                    wp_sCmdSql += "sClrFrm          = '" & .sClrFrm & "', "
                    wp_sCmdSql += "sTipFont         = '" & .sTipFont & "', "
                    wp_sCmdSql += "nTamFont         = '" & .nTamFont & "', "
                    wp_sCmdSql += "sForFec          = '" & .sForFec & "', "
                    wp_sCmdSql += "sForHor          = '" & .sForHor & "', "
                    wp_sCmdSql += "nNroDecPre       = " & .nNroDecPre & ", "
                    wp_sCmdSql += "nNroDecCan       = " & .nNroDecCan & ", "
                    wp_sCmdSql += "nNroDecPor       = " & .nNroDecPor & ", "
                    wp_sCmdSql += "sCodAlmXDef      = '" & .sCodAlmXDef & "', "
                    wp_sCmdSql += "sCrictaCtb       =  '" & .sCrictaCtb & "', "
                    wp_sCmdSql += "bVisItmIna       = " & .bVisItmIna & ", "
                    wp_sCmdSql += "sRutXls          =  '" & .sRutXls & "', "
                    wp_sCmdSql += "sTipRegTie       = '" & .sTipRegTie & "', "
                    wp_sCmdSql += "sCodAlmCom       = '" & .sCodAlmXDef & "', "
                    wp_sCmdSql += "bPrnODPPla       = " & .bPrnODPPla & ", "
                    wp_sCmdSql += "nPorGto       = " & .nPorGto & ", "
                    wp_sCmdSql += "nPorIto       = " & .nPorIto
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodCia = '" & .sCodCia & "'"
                    wp_sCmdSql += " AND "
                    wp_sCmdSql += "sCodUsr = '" & .sCodUsr
                    wp_sCmdSql += "' )"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: cldACPAG.cdCrearActACPAG")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliACPAG(ByVal wp_eACPAG As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eACPAG
                wp_sCmdSql = "Delete * from  ACPAG "
                wp_sCmdSql += "where "
                wp_sCmdSql += "sCodCia = '" & .sCodCia & "'"
                wp_sCmdSql += " AND "
                wp_sCmdSql += "sCodUsr = '" & .sCodUsr & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With


        Catch ex As Exception
            MsgBox("Error : cldACPAG.cdEliACPAG")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
