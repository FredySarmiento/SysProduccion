Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATALM
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
    Public Function cddtConATALM(ByVal wp_eATALM As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            With wp_eATALM

                wp_sCmdSql = "SELECT * FROM ATALM T0 "
                If .sCodAlm <> "" Then
                    wp_sCmdSql += " WHERE "
                    wp_sCmdSql += "T0.sCodAlm = "
                    wp_sCmdSql += "'" & .sCodAlm & "'"
                End If
                wp_sCmdSql += " ORDER BY T0.sCodAlm "

            End With
            wl_DT = cdfdtConsultar(wp_sCmdSql, wr_bEOF)
            If wl_DT IsNot Nothing Then
                Return wl_DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error : cldATALM.cddtConATALM")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cdCrearActATALM(ByVal wp_eATALM As Object,
                                   ByRef wr_bEOF As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Dim wl_bEOF1 As Boolean = False
        Try

            With wp_eATALM
                wl_YesNo = True
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into ATALM "
                    wp_sCmdSql += "(sCodAlm) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodAlm & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If

                If wl_YesNo Then
                    wl_YesNo = False
                    wp_sCmdSql = "Update ATALM "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomAlm     = """ & .sNomAlm & """, "
                    wp_sCmdSql += "sUbiAlm     = '" & .sUbiAlm & "', "
                    wp_sCmdSql += "sCtaInv     = '" & .sCtaInv & "', "
                    wp_sCmdSql += "sCtaCosVta  = '" & .sCtaCosVta & "', "
                    wp_sCmdSql += "sCtaTrs     = '" & .sCtaTrs & "', "
                    wp_sCmdSql += "sCtaIng     = '" & .sCtaIng & "', "
                    wp_sCmdSql += "sCtaDevVta  = '" & .sCtaDevVta & "', "
                    wp_sCmdSql += "sCtaVrc     = '" & .sCtaVrc & "', "
                    wp_sCmdSql += "sCtaGto     = '" & .sCtaGto & "', "
                    wp_sCmdSql += "sCtaDot     = '" & .sCtaDot & "', "
                    wp_sCmdSql += "sCtaDifPre  = '" & .sCtaDifPre & "', "
                    wp_sCmdSql += "sCtaRev     = '" & .sCtaRev & "', "
                    wp_sCmdSql += "sCtaAumInv  = '" & .sCtaInv & "', "
                    wp_sCmdSql += "sCtaRedInv  = '" & .sCtaRedInv & "', "
                    wp_sCmdSql += "sCtaCom     = '" & .sCtaCom & "', "
                    wp_sCmdSql += "sCtaDevCom  = '" & .sCtaDevCom & "', "
                    wp_sCmdSql += "sCtaWIP     = '" & .sCtaWIP & "', "
                    wp_sCmdSql += "bSelxDef     = " & .bSelxDef & ", "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "sCodAlm = '" & .sCodAlm & "' "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: cldATALM.cdCrearActualizar ")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cdEliATALM(ByVal wp_eATALM As Object,
                                  ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATALM
                wp_sCmdSql = "Delete * from  ATALM "
                wp_sCmdSql += "where sCodAlm = '" & .sCodAlm & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATALM.cdEliATALM")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class



