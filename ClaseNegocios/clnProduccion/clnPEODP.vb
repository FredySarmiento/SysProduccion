Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnPEODP
    Dim oAccDat As New ClaseDatos.cldPEODP()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnActCnsCIFPLODP4(ByVal wp_ePLRCI1 As Object,
                                      ByVal wr_bEOFL1 As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdActCnsCIFPLODP4(wp_ePLRCI1,
                                                 wr_bEOFL1,
                                                 wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnActCnsCIFPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActCnsMODPLODP4(ByVal wp_ePLROP1 As Object,
                                      ByVal wr_bEOFL1 As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdActCnsMODPLODP4(wp_ePLROP1,
                                                 wr_bEOFL1,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnPEODP.cdActCnsMODPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActCnsMPDPLODP4(ByVal wp_eILMOV1 As Object,
                                      ByVal wr_bEOFL1 As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdActCnsMPDPLODP4(wp_eILMOV1,
                                                 wr_bEOFL1,
                                                 wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cdActCnsMPDPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActCnsPLODP1(ByVal wp_eILMOV1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdActCnsPLODP1(wp_eILMOV1,
                                              wr_bEOFL1,
                                              wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnActCnsPLODP1")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActCnsPLODP2(ByVal wl_ePLROP1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdActCnsPLODP2(wl_ePLROP1,
                                              wr_bEOFL1,
                                              wp_sCmdSel)


        Catch ex As Exception
            MsgBox("Error : cldPclnPEODPEODP.cnActCnsPLODP2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActCnsPLODP3(ByVal wl_ePLROP1 As Object,
                                   ByVal wr_bEOFL1 As Boolean,
                                   ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdActCnsPLODP3(wl_ePLROP1,
                                              wr_bEOFL1,
                                              wp_sCmdSel)


        Catch ex As Exception
            MsgBox("Error : cldPclnPEODPEODP.cnActCnsPLODP3")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActPorOpeCnsPLODP2(ByVal wp_ePLROP1 As Object,
                                         ByRef wr_bEOFL1 As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdActPorOpeCnsPLODP2(wp_ePLROP1,
                                                    wr_bEOFL1)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cdActPorOpeCnsPLODP2")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActEDPPEODP(ByVal wp_eILMOV1 As Object,
                                  ByVal wr_bEOFL1 As Boolean,
                                  ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdActEDPPEODP(wp_eILMOV1,
                                             wr_bEOFL1,
                                             wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnActEDPPEODP")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActEDPPLODP4(ByVal wp_eILMOV1 As Object,
                                      ByVal wr_bEOFL1 As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdActEDPPLODP4(wp_eILMOV1,
                                              wr_bEOFL1,
                                              wp_sCmdSel)


        Catch ex As Exception
            MsgBox("Error : clnPEODP.cdActCnsMPDPLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnRecalPLODP4(ByVal vp_sCodDoc As String,
                                  ByVal vp_nNroDoc As Long) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdRecalPLODP4(vp_sCodDoc,
                                             vp_nNroDoc)
        Catch ex As Exception
            MsgBox("Error : clnPEODP.cnRecalPLODP4")
            Throw ex
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizar(ByVal wp_ePEODP As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wp_ePEODP,
                                                 wr_bEOF,
                                                 wp_sCmdSel)



        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliminar(ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByVal vp_sCodSer As String,
                               ByRef wr_bEOF As String) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(vp_sCodDoc,
                                          vp_nNroDoc,
                                          vp_sCodSer,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarPLODP1(ByVal wp_ePLODP1 As Object,
                                            ByRef wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLODP1(wp_ePLODP1,
                                                       wr_bEOFL1,
                                                       wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error: clnPEODP.cdCrearActualizarPLODP1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLODP2(ByVal wp_ePLODP2 As Object,
                                            ByRef wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLODP2(wp_ePLODP2,
                                                       wr_bEOFL1,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnCrearActualizarPLODP2")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLODP3(ByVal wp_ePLODP3 As Object,
                                            ByRef wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLODP3(wp_ePLODP3,
                                                       wr_bEOFL1,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cdCrearActualizarPLODP3")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLODP4(ByVal wp_ePLODP4 As Object,
                                            ByRef wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLODP4(wp_ePLODP4,
                                                       wr_bEOFL1,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnCrearActualizarPLODP4")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConsultarPEODP(ByVal vp_sCodDoc As String,
                                       ByVal vp_nNroDoc As Integer,
                                       ByVal vp_sEstOdp As String,
                                       ByVal vp_dFecIni As Date,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPEODP(vp_sCodDoc,
                                               vp_nNroDoc,
                                               vp_sEstOdp,
                                               vp_dFecIni,
                                               wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConsultarPEODP")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPEODP_QGrl(ByVal wp_ePEODP As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConPEODP_QGrl(wp_ePEODP,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConPEODP_QGrl")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPEODP_QIniFin(ByVal wp_ePEODP_Ini As Object,
                                         ByVal wp_ePEODP_Fin As Object,
                                         ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConPEODP_QIniFin(wp_ePEODP_Ini,
                                                 wp_ePEODP_Fin,
                                                 wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConPEODP_QIniFin")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPEODP_PLODP4(ByVal wl_ePEODP_PLODP4 As Object,
                                        ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConPEODP_PLODP4(wl_ePEODP_PLODP4,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConPEODP_PLODP4")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPEODP_PLODP4_QGrl(ByVal wp_ePEODP_PLODP4 As Object,
                                             ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConPEODP_PLODP4_QGrl(wp_ePEODP_PLODP4,
                                                     wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConPEODP_PLODP4_QGrl")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPEODP_PLODP4_QIniFin(ByVal wp_ePEODP_PLODP4_Ini As Object,
                                                ByVal wp_ePEODP_PLODP4_Fin As Object,
                                                ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConPEODP_PLODP4_QIniFin(wp_ePEODP_PLODP4_Ini,
                                                 wp_ePEODP_PLODP4_Fin,
                                                 wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConPEODP_PLODP4_QIniFin")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActualizarPLODP5(ByVal wp_ePLODP5 As Object,
                                            ByRef wr_bEOFL1 As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLODP5(wp_ePLODP5,
                                                       wr_bEOFL1,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnCrearActualizarPLODP5")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConsultarPLODP1(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLODP1(vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConsultarPLODP1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLODP2(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByVal vp_sCodOpe As String,
                                        ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLODP2(vp_sCodDoc,
                                                vp_nNroDoc,
                                                vp_sCodOpe,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConsultarPLODP2")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLODP3(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLODP3(vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConsultarPLODP3")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLODP4(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLODP4(vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConsultarPLODP4")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLODP5(ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLODP5(vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cndtConsultarPLODP5")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConItmPLODP4(ByVal vp_sCodDoc As String,
                                     ByVal vp_nNroDoc As Integer,
                                     ByVal vp_sCodItm As String,
                                     ByVal wp_nNroReg As Integer,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConItmPLODP4(vp_sCodDoc,
                                             vp_nNroDoc,
                                             vp_sCodItm,
                                             wp_nNroReg,
                                             wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnddtConItmPLODP4")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnEliminarPLODP1(ByVal wp_ePLODP1 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLODP1(wp_ePLODP1,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnEliminarPLODP1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLODP2(ByVal wp_ePLODP2 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLODP2(wp_ePLODP2,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnEliminarPLPODP2")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLODP3(ByVal wp_ePLODP3 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLODP3(wp_ePLODP3,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnEliminarPLODP3")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLODP4(ByVal wp_ePLODP4 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLODP4(wp_ePLODP4,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnEliminarPLODP4")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLODP5(ByVal wp_ePLODP5 As Object,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLODP5(wp_ePLODP5,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnEliminarPLODP5")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnSdoOPPEODP_0(ByVal wp_ePEODP As Object) As Boolean
        Try



            wl_YesNo = False
            wl_YesNo = oAccDat.cdSdoOPPEODP_0(wp_ePEODP)
        Catch ex As Exception
            MsgBox("Error: clnPEODP.cnSdoOPPEODP_0")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function

End Class
