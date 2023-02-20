Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion


Public Class cldHEDMT
    Inherits cldFunciones
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String
    Dim oCmdSql = New OleDbCommand

    Public Function cdCrearActualizar(ByVal wr_eHEDMT As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = True
            With wr_eHEDMT
                If wp_sCmdSel = "C" Then
                    wl_YesNo = False
                    wp_sCmdSql = "Insert into HEDMT "
                    wp_sCmdSql += "(sCodTer) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodTer & "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update HEDMT "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomTer     = """ & .sNomTer & """, " '2
                    wp_sCmdSql += "sTipTer     = '" & .sTipTer & "', " '3
                    wp_sCmdSql += "sNitTer     = '" & .sNitTer & "', " '4
                    wp_sCmdSql += "sDigVer     = '" & .sDigVer & "', " '5
                    wp_sCmdSql += "sDirTer     = '" & .sDirTer & "', " '6
                    wp_sCmdSql += "sTel1Ter    = '" & .sTel1Ter & "', " '7
                    wp_sCmdSql += "sTel2Ter    = '" & .sTel2Ter & "', " '8
                    wp_sCmdSql += "sTelCll     = '" & .sTelCll & "', " '9
                    wp_sCmdSql += "sFax        = '" & .sFax & "', " '10
                    wp_sCmdSql += "sNomAlt     = '" & .sNomAlt & "', " '11
                    wp_sCmdSql += "sCodGrpTer  = '" & .sCodGrpTer & "', " '12
                    wp_sCmdSql += "sEmlTer     = '" & .sEmlTer & "', " '13 
                    wp_sCmdSql += "sNomCtc     = '" & .sNomCtc & "'," '14 
                    wp_sCmdSql += "sTipCtaCtb  = '" & .sTipCtaCtb & "'," '15
                    wp_sCmdSql += "sCodCtaCtb  = '" & .sCodCtaCtb & "'," '16 
                    wp_sCmdSql += "sCndPag     = '" & .sCndPag & "'," '17
                    wp_sCmdSql += "sCodLstPre  = '" & .sCodLstPre & "'," '18
                    wp_sCmdSql += "nPorDto     = " & .nPorDto & " ," '19
                    wp_sCmdSql += "nLmtCre     = " & .nLmtCre & " ," '20
                    wp_sCmdSql += "bAct        = " & .bAct & "," '21
                    wp_sCmdSql += "bIna        = " & .bIna & "," '22
                    wp_sCmdSql += "sCmn        = '" & .sCmn & "' " '23
                    wp_sCmdSql += "  where "
                    wp_sCmdSql += "("
                    wp_sCmdSql += "sCodTer =        '" & .sCodTer
                    wp_sCmdSql += "')"
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error : cldHEDMT.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cddtConHEDMT(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try

            wp_sCmdSql = "SELECT * FROM "
            wp_sCmdSql += wp_sNomTbl
            wp_sCmdSql += " T0"
            If wp_sDatCmp <> "" Then
                wp_sCmdSql += " WHERE "
                wp_sCmdSql += "T0." & wp_sNomCmp
                wp_sCmdSql += " = '" & wp_sDatCmp & "'"
            End If
            wp_sCmdSql += " ORDER BY T0.sCodTer"
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cddtConHEDMT")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdEliminar(ByVal vp_sCodTer As String,
                                   ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False

            wp_sCmdSql = "Delete * from  HEDMT "
            wp_sCmdSql += "where sCodTer = '" & vp_sCodTer & "'"
            wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)


        Catch ex As Exception
            MsgBox("Error : cldHEDMT.cdEliminar")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
