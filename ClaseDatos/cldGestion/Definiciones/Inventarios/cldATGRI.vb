
Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion
Public Class cldATGRI
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
    Public Function cdCrearActATGRI(ByVal wp_eATGRI As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try

            With wp_eATGRI
                wl_YesNo = True
                If wp_sCmdSel = "C" Then
                    wp_sCmdSql = "Insert into ATGRI "
                    wp_sCmdSql += "(sCodGrp) "
                    wp_sCmdSql += "values "
                    wp_sCmdSql += "('" & .sCodGrp & "') "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
                If wl_YesNo Then

                    '   wl_nNro = InStr(.sNomGrp, "'")
                    '   vl_sNomGrp = Mid(.sNomGrp, 1, wl_nNro - 1)

                    wl_YesNo = False
                    wp_sCmdSql = "Update ATGRI "
                    wp_sCmdSql += " SET "
                    wp_sCmdSql += "sNomGrp     = """ & .sNomGrp & """, " ' Graba con comilla sencilla
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
                    wp_sCmdSql += "sCtaAumInv  = '" & .sCtaAumInv & "', "
                    wp_sCmdSql += "sCtaRedInv  = '" & .sCtaRedInv & "', "
                    wp_sCmdSql += "sCtaCom     = '" & .sCtaCom & "', "
                    wp_sCmdSql += "sCtaDevCom  = '" & .sCtaDevCom & "', "
                    wp_sCmdSql += "sCtaWIP     = '" & .sCtaWIP & "', "
                    wp_sCmdSql += "sSysInv     = '" & .sSysInv & "', "
                    wp_sCmdSql += "sMetAba     = '" & .sMetAba & "', "
                    wp_sCmdSql += "sMetVlz     = '" & .sMetVlz & "', "
                    wp_sCmdSql += "bRegAci     = " & .bRegAci
                    wp_sCmdSql += " where "
                    wp_sCmdSql += "sCodGrp = '" & .sCodGrp & "' "
                    wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
                End If
            End With

        Catch ex As Exception
            MsgBox("Error: cldATGRI.cdCrearActATGRI ")
            Throw ex
        End Try


        Return wl_YesNo
    End Function
    Public Function cdEliATGRI(ByVal wp_eATGRI As Object,
                               ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            With wp_eATGRI
                wp_sCmdSql = "Delete * from  ATGRI "
                wp_sCmdSql += "where sCodGrp = '" & .sCodGrp & "'"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End With
        Catch ex As Exception
            MsgBox("Error : cldATGRI.cdEliATGRI")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
End Class
