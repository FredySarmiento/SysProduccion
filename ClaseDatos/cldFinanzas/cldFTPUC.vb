Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldFTPUC
    Inherits cldConTbl

    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wp_sCmdSql As String
    Dim wp_sNomTbl As String
    Dim wp_sNomCmp As String
    Dim wp_sDatCmp As String
    Dim wp_sTipCmp As String
    Dim wp_sCmpOrd As String
    Dim wp_sTipOrd As String
    Public Function cddtConFTPUC(ByVal wp_eFTPUC_Ini As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_sWHERE As String
            wl_sWHERE = " WHERE"
            With wp_eFTPUC_Ini

                wp_sCmdSql = "SELECT * FROM FTPUC T0 "
                If .sCodCta <> "" Then
                    wp_sCmdSql += wl_sWHERE
                    wp_sCmdSql += "T0.sCodCta = "
                    wp_sCmdSql += "'" & .sCodCta & "'"
                    wl_sWHERE = ""

                End If
                If wl_sWHERE = "" Then
                    wp_sCmdSql += " AND "
                Else
                    wp_sCmdSql += wl_sWHERE
                    wl_sWHERE = ""
                End If
                wp_sCmdSql += "T0.bCtaMov = "
                wp_sCmdSql += .bCtaMov
                wp_sCmdSql += " ORDER BY TO.sCodCta"

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldFTPUC.cddtConFTPUC")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActFTPUC(ByVal wp_eFTPUC As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean

        Try
            With wp_eFTPUC
                wl_YesNo = True
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into FTPUC "
                    wp_sCmdSql += "(sCodCta) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodCta & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update FTPUC "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomCta     = '" & .sNomCta & "', "
                    wp_sCmdSql += "sCodCtaAlt     = '" & .sCodCtaAlt & "', "
                    wp_sCmdSql += "sNomAlt     = '" & .sNomAlt & "', "
                    wp_sCmdSql += "sCodNIIF  = '" & .sCodNIIF & "', "
                    wp_sCmdSql += "bCtaFluCaj     = " & .bCtaFluCaj & ", "
                    wp_sCmdSql += "bCtaPpo     = " & .bCtaPpo & ", "
                    wp_sCmdSql += "sClsCta  = '" & .sClsCta & "', "
                    wp_sCmdSql += "nSdoIniCta     = " & .nSdoIniCta & ", "
                    wp_sCmdSql += "nSdoFinCta     = " & .nSdoFinCta & ", "
                    wp_sCmdSql += "sNivCta     = '" & .sNivCta & "', "
                    wp_sCmdSql += "bCtaRcc  = " & .bCtaRcc & ", "
                    wp_sCmdSql += "sCodCtaRcc     = '" & .sCodCtaRcc & "', "
                    wp_sCmdSql += "bCtaCfd  = " & .bCtaCfd & ", "
                    wp_sCmdSql += "bCtaTer  = " & .bCtaTer & ", "
                    wp_sCmdSql += "bCtaBlq     = " & .bCtaBlq & ", "
                    wp_sCmdSql += "bCtaMov  = " & .bCtaMov & ", "
                    wp_sCmdSql += "bCtaIna     = " & .bCtaIna
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "sClodAlm = '" & .sClodAlm & "' "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: cldFTPUC.cdCrearActFTPUC ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliFTPUC(ByVal wp_eFTPUC As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eFTPUC
                wp_sCmdSql = "Delete * from  FTPUC "
                wp_sCmdSql += "where sCodAlm = '" & .sCodCta & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldFTPUC.cdEliFTPUC")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
