Imports System.Data
Imports System.Data.OleDb

Imports ClaseDatos



Public Class clnACDEM
    Dim oAccDat As New ClaseDatos.cldACDEM()
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(ByVal vp_sCodcia As String,
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
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(vp_sCodcia,
                       vp_sNomCia,
                       vp_sDirCia,
                       vp_sCiuCia,
                       vp_sDepCia,
                       vp_sPaiCia,
                       vp_sRepLeg,
                       vp_sEmlCia,
                       vp_sTel1Cia,
                       vp_sTel2Cia,
                       vp_sFaxCia,
                       vp_sNitCia,
                       vp_sDigVer,
                       vp_bInvPte,
                       vp_sTipInv,
                       vp_bCosXBod,
                       vp_bMovSinCos,
                       vp_nId,
                       wr_bEOF,
                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnACDEM.cnCrearActualizar")
        End Try
        Return wl_YesNo
    End Function
End Class
