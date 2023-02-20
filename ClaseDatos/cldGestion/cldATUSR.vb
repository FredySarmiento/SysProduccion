
Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion

Public Class cldATUSR
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wp_sCmdSql As String
    Dim wl_YesNo As Boolean


    Public Function cddtConsultar(ByVal vp_sCodUsr,
                                  ByRef vp_sPwdUsr,
                                ByRef wr_bEOF) As DataTable
        Try
            wp_sCmdSql = "select * from ATUSR "
            wp_sCmdSql += " where (sCodUsr = '" & vp_sCodUsr & "'"
            wp_sCmdSql += " and sPwdUsr = '" & vp_sPwdUsr & "')"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error: cldATUSR.cddtConsultar")
            Return Nothing
            Throw ex
        End Try

       

    End Function
    Public Function cdCrearActualizar(ByVal vp_sCodUsr As String,
                  ByVal vp_sPwdUsr As String,
                  ByVal vp_sNomUsr As String,
                  ByVal vp_sTipUsr As String,
                  ByVal vp_sTel1Usr As String,
                  ByVal vp_sTel2Usr As String,
                  ByVal vp_sEmlUsr As String,
                  ByVal vp_bUsrBlq As Boolean,
                  ByRef wr_bEOF As Boolean,
                  ByVal wp_sCmdSel As String) As Boolean

        wl_YesNo = True

        Try
            If wp_sCmdSel = "C" Then
                wl_YesNo = False
                wp_sCmdSql = "Insert into ATUSR "
                wp_sCmdSql += "(sCodUsr) "
                wp_sCmdSql += "values "
                wp_sCmdSql += "('" & vp_sCodUsr & "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If
            If wl_YesNo Then
                wl_YesNo = False
                wp_sCmdSql = "Update ATUSR T0 "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sPwdUsr     = """ & vp_sPwdUsr & """, "
                wp_sCmdSql += "sNomUsr     = """ & vp_sNomUsr & """, "
                wp_sCmdSql += "sTipUsr     = '" & vp_sTipUsr & "', "
                wp_sCmdSql += "sTel1Usr     = '" & vp_sTel1Usr & "', "
                wp_sCmdSql += "sTel2Usr     = '" & vp_sTel2Usr & "', "
                wp_sCmdSql += "sEmlUsr    = '" & vp_sEmlUsr & "', "
                wp_sCmdSql += "bUsrBlq     =  " & vp_bUsrBlq & "  "
                wp_sCmdSql += "  where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodUsr =        '" & vp_sCodUsr
                wp_sCmdSql += "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If

        Catch ex As Exception
            MsgBox("Error: cldATUSR.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class








