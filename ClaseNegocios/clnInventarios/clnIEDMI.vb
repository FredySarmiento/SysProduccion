Imports System.Data
Imports System.Data.OleDb

Imports ClaseDatos

Public Class clnIEDMI
    Dim oAccDat As New ClaseDatos.cldIEDMI()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wl_bYesNo As Boolean
    Public Function cnActUltPreEntIEDMI(ByVal wp_eILMOV1 As Object,
                                        ByVal wr_bEOFL1 As Boolean,
                                        ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_bYesNo = False
            wl_bYesNo = oAccDat.cdActUltPreEntIEDMI(wp_eILMOV1,
                                                     wr_bEOFL1,
                                                     wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnActUltPreEntIEDMI")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function
    Public Function cnActUltPreEntILDMI1(ByVal wp_eILMOV1 As Object,
                                         ByVal wr_bEOFL1 As Boolean,
                                         ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_bYesNo = False
            wl_bYesNo = oAccDat.cdActUltPreEntILDMI1(wp_eILMOV1,
                                                     wr_bEOFL1,
                                                     wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnActUltPreEntILDMI1")
            Throw ex
        End Try
        Return wl_bYesNo
    End Function
    Public Function cnCrearActualizar(ByVal wr_eIEDMI As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wr_eIEDMI,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnIEDMI.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliminar(ByRef vp_sCodItm As String,
                       ByVal wr_bEOF As String) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(vp_sCodItm,
                                 wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConsultarILMDI1(ByVal vp_sCodItm As String,
                                ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarILMDI1(vp_sCodItm, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConsultarILMDI1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
   
    Public Function cndtConSdoILMDI1(ByVal vp_sCodAlm As String,
                                     ByVal vp_sCodItm As String,
                                     ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConSdoILMDI1(vp_sCodAlm,
                                             vp_sCodItm,
                                               wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConSdoILMDI1")
            'Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActualizarILMDI1(ByVal wp_eILDMI1 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarILMDI1(wp_eILDMI1,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarILMDI1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarILMDI1(ByVal vp_sCodItm As String,
                                     ByVal vp_sCodalm As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarILMDI1(vp_sCodItm,
                                              vp_sCodalm,
                                              wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarILMDI1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConGELDMI1(ByVal vp_sCodItm As String,
                                   ByVal vp_sCodalm As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Try

            wl_DT = oAccDat.cddtConGELDMI1(vp_sCodItm,
                                           vp_sCodalm,
                                           wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConGELDMI1")
            '  Throw ex
            'Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActualizarILDMI2(ByVal wp_eILDMI2 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarILDMI2(wp_eILDMI2,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarILDMI2")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConIEDMI(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByVal wp_eIEDMI As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConIEDMI(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_eIEDMI,
                                         wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnTEDMT.cndtConIEDMI")
            Return Nothing
        End Try
    End Function
    Public Function cndtConIEDMI_QGrl(ByVal wp_eIEDMI As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConIEDMI_QGrl(wp_eIEDMI,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConIEDMI_QGrl")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConIEDMI_QIniFin(ByVal wp_eIEDMI_Ini As Object,
                                         ByVal wp_eIEDMI_Fin As Object,
                                         ByVal wp_bImpItmInac As Boolean,
                                         ByVal wp_bImpItmCero As Boolean,
                                          ByVal wp_sNomTblTmp As String,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConIEDMI_QIniFin(wp_eIEDMI_Ini,
                                                 wp_eIEDMI_Fin,
                                                 wp_bImpItmInac,
                                                 wp_bImpItmCero,
                                                 wp_sNomTblTmp,
                                                 wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConIEDMI_QIniFin")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConIELDMI1_QIniFin(ByVal wp_eIEDMI_Ini As Object,
                                           ByVal wp_eIEDMI_Fin As Object,
                                           ByVal wp_bImpItmInac As Boolean,
                                           ByVal wp_bImpItmCero As Boolean,
                                           ByVal wp_bVdaCanMin As Boolean,
                                           ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConIELDMI1_QIniFin(wp_eIEDMI_Ini,
                                                   wp_eIEDMI_Fin,
                                                   wp_bImpItmInac,
                                                   wp_bImpItmCero,
                                                   wp_bVdaCanMin,
                                                   wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConIELDMI1_QIniFin")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConIEDMIR(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sCodAlm As String,
                                  ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConIEDMIR(wp_sNomTbl,
                                          wp_sNomCmp,
                                          wp_sDatCmp,
                                          wp_sCodAlm,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnTEDMT.cndtConIEDMIR")
            Return Nothing
        End Try
    End Function
    Public Function cndtConILDMI2(ByVal vp_sNomTbl,
                                 ByVal wg_sDatCon11,
                                 ByRef wr_bEOF) As DataTable


        Try
            wl_DT = oAccDat.cddtConILDMI2(vp_sNomTbl,
                                          wg_sDatCon11,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConItmILDMI2(ByVal vp_sCodItm As String,
                                     ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConItmILDMI2(vp_sCodItm, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConItmILDMI2")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConTerILDMI2(ByVal vp_sCodTer As String,
                                     ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConTerILDMI2(vp_sCodTer, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConTerILDMI2")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnEliILDMI2(ByVal vp_sCodItm As String,
                                ByVal vp_sCodTer As String,
                                ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliILDMI2(vp_sCodItm,
                                           vp_sCodTer,
                                           wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliILMDI2")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConSdoFin(ByVal wp_eIEDMI_Ini As Object,
                                ByVal wp_eIEDMI_Fin As Object,
                                ByVal wp_bImpItmInac As Boolean,
                                ByVal wp_bImpItmCero As Boolean,
                                ByVal wp_dFecMDAIni As String,
                                ByVal wp_dFecMDAFin As String,
                                ByVal wp_eATASI As Object,
                                ByRef wr_bEOF As Boolean) As DataTable

        '2018-08-23 Se Adiciona esta función
        Try

            wl_DT = oAccDat.cddtConSdoFin(wp_eIEDMI_Ini,
                                          wp_eIEDMI_Fin,
                                          wp_bImpItmInac,
                                          wp_bImpItmCero,
                                          wp_dFecMDAIni,
                                          wp_dFecMDAFin,
                                          wp_eATASI,
                                          wr_bEOF)

            Return wl_DT

        Catch ex As Exception
            MsgBox("Error : cldIEDMI.cddtConSdoFin")
            Return Nothing
            Throw ex
        End Try
    End Function

    Public Function cnSdoIniIEDMI(ByVal wp_eATASI As Object,
                                  ByVal wl_eIEDMI As Object,
                                  ByVal wp_sNomTbl As String) As Boolean
        Try
            wl_YesNo = True
            wl_YesNo = oAccDat.cdSdoIniIEDMI(wp_eATASI,
                                             wl_eIEDMI,
                                             wp_sNomTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clnIEDMI.cnSdoIniIEDMI")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnSdoInvIEDMI_0(ByVal wp_eIEDMI As Object,
                                    ByVal wp_sNomTbl As String) As Boolean
        Try
            wl_YesNo = True
            wl_YesNo = oAccDat.cdSdoInvIEDMI_0(wp_eIEDMI,
                                               wp_sNomTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error : clnIEDMI.cnSdoInvIEDMI_0")
        End Try
        Return wl_YesNo

    End Function
End Class
