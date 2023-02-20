Imports System.Data.OleDb
Imports System.Data
Imports ClaseConexion



Public Class cldACDEM
    Inherits cldFunciones
    Dim oCmdSql = New OleDbCommand

    Dim wl_YesNo As Boolean

    Dim wp_sCmdSql As String


    Public Function cdCrearActualizar(ByVal vp_sCodCia As String,
                                ByVal vp_sNomCia As String,
                    ByVal vp_sDirCia As String,
                    ByVal vp_sCiuCia As String,
                    ByVal vp_sDepCia As String,
                    ByVal vp_sPaiCia As String,
                    ByVal vp_sRepLeg As String,
                    ByVal vp_sEmlCia As String,
                    ByVal vp_sTel1Cia As String,
                    ByVal vp_sTel2Cia As String,
                    ByVal vp_sFaxCia As String,
                    ByVal vp_sNitCia As String,
                    ByVal vp_sDigVer As String,
                    ByVal vp_bInvPte As Boolean,
                    ByVal vp_sTipInv As String,
                    ByVal vp_bCosXBod As Boolean,
                    ByVal vp_bMovSinCos As Boolean,
                    ByVal vp_nId As Integer,
                    ByRef wr_bEOF As Boolean,
                    ByVal wp_sCmdSel As String) As Boolean

        Try
            wl_YesNo = True

            If wp_sCmdSel = "C" Then
                wl_YesNo = False
                wp_sCmdSql = "Insert into ACDEM "
                wp_sCmdSql += "(sNomCia) "
                wp_sCmdSql += "values "
                wp_sCmdSql += "('" & vp_sNomCia & "')"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If
            If wl_YesNo Then
                wp_sCmdSql = "Update ACDEM "
                wp_sCmdSql += " SET "
                wp_sCmdSql += "sNomCia   = '" & vp_sNomCia & "', "
                wp_sCmdSql += "sDirCia   = '" & vp_sDirCia & "', "
                wp_sCmdSql += "sCiuCia   = '" & vp_sCiuCia & "', "
                wp_sCmdSql += "sDepCia   = '" & vp_sDepCia & "', "
                wp_sCmdSql += "sPaiCia   = '" & vp_sPaiCia & "', "
                wp_sCmdSql += "sRepLeg   = '" & vp_sRepLeg & "', "
                wp_sCmdSql += "sEmlCia   = '" & vp_sEmlCia & "', "
                wp_sCmdSql += "sTel1Cia  = '" & vp_sTel1Cia & "', "
                wp_sCmdSql += "sTel2Cia  = '" & vp_sTel2Cia & "', "
                wp_sCmdSql += "sFaxCia   = '" & vp_sFaxCia & "', "
                wp_sCmdSql += "sNitCia   = '" & vp_sNitCia & "', "
                wp_sCmdSql += "sDigVer   = '" & vp_sDigVer & "', "
                wp_sCmdSql += "bInvPte   =  " & vp_bInvPte & ", "
                wp_sCmdSql += "sTipInv   = '" & vp_sTipInv & "', "
                wp_sCmdSql += "bCosXBod  =  " & vp_bCosXBod & ", "
                wp_sCmdSql += "bMovSinCos = " & vp_bMovSinCos & " "
                wp_sCmdSql += "  where "
                wp_sCmdSql += "("
                wp_sCmdSql += "sCodCia = '" & vp_sCodCia
                wp_sCmdSql += "' )"
                wl_YesNo = cdfEjecutarCmdSql(wp_sCmdSql)
            End If

        Catch ex As Exception
            MsgBox("Error: cldACDEM.cdCrearActualizar")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class