Public Class clnCEODC
    Dim wl_DT As New DataTable
    Dim oAccDat As New ClaseDatos.cldCEODC
    Dim wl_bYesNo As Boolean

    Public Function cnActSdoCanLinCLODP1(ByVal wp_eILMOV1 As Object,
                                         ByVal wr_bEOFL1 As Boolean,
                                         ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_bYesNo = False
            wl_bYesNo = oAccDat.cdActSdoCanLinCLODP1(wp_eILMOV1,
                                                     wr_bEOFL1,
                                                     wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnActSdoCanLinCLODP1")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function

    Public Function cndtCargarGEMOV(ByVal vp_sNomTbl,
                                    ByRef wr_bEOF) As DataTable
        Try
            wl_DT = oAccDat.cddtCargarGEMOV(vp_sNomTbl,
                                            wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox("Error : clnCEODC.cndtCargarGEMOV")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConGEMOV(ByVal wp_sNomTbl As String,
                                 ByVal wp_eGEMOV As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldCEODC

            wl_DT = oAccDat.cddtConGEMOV(wp_sNomTbl,
                                         wp_eGEMOV,
                                         wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
