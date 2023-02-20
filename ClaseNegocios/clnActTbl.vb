Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos

Public Class clnActTbl

    Dim oActDatTbl As New ClaseDatos.cldActTbl
    Dim wl_YesNo As Boolean

    Public Function cndtActUnaLlaUnCmp(ByVal wp_sNomTbl,
                               ByVal wp_sNomLla,
                               ByVal wp_sDatLla,
                               ByVal wp_sTipLla,
                               ByVal wp_sNomCmp,
                               ByVal wp_sDatCmp,
                               ByVal wp_sTipCmp,
                               ByRef wr_bEOF) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oActDatTbl.cddtActRegUnaLlaUnCmp(wp_sNomTbl,
                                   wp_sNomLla,
                                   wp_sDatLla,
                                   wp_sTipLla,
                                   wp_sNomCmp,
                                   wp_sDatCmp,
                                   wp_sTipCmp,
                                   wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnActTbl.cndtActUnaLlaUnCmp")
            Throw ex

        End Try
        Return wl_YesNo

    End Function
    Public Function cndtActDosLlaUnCmp(ByVal wp_sNomTbl,
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
            wl_YesNo = oActDatTbl.cddtActRegDosLlaUnCmp(wp_sNomTbl,
                                                        wp_sNomLla,
                                                        wp_sDatLla,
                                                        wp_sTipLla,
                                                        wp_sNomLla1,
                                                        wp_sDatLla1,
                                                        wp_sTipLla1,
                                                        wp_sNomCmp,
                                                        wp_sDatCmp,
                                                        wp_sTipCmp,
                                                        wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnActTbl.cndtActDosLlaUnCmp")
            Throw ex

        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliReg(ByVal wp_sNomTbl As String,
                          ByVal wp_sNomCmp As String,
                          ByVal wp_sDatCmp As String,
                          ByVal wp_sTipCmp As String,
                          ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oActDatTbl.cdEliReg(wp_sNomTbl,
                                wp_sNomCmp,
                                wp_sDatCmp,
                                wp_sTipCmp,
                                wr_bEOF)


        Catch ex As Exception
            MsgBox("Error: clnActTbl.cnEliReg")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliRegLin(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal wp_sDatCmp As String,
                                ByVal wp_sTipCmp As String,
                                ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oActDatTbl.cdEliRegLin(wp_sNomTbl,
                                              wp_sNomCmp,
                                              wp_sDatCmp,
                                              wp_sTipCmp,
                                              wr_bEOF)


        Catch ex As Exception
            MsgBox("Error: clnActTbl.cnEliReg")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
End Class
