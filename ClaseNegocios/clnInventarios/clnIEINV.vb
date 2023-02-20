Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos


Public Class clnIEINV
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldIEINV

    Private _cnCrearActualizar As Boolean

    Public Function cnActILMOV1_PLODP4(ByVal wr_ePEODP_PLODP4 As Object,
                                       ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdActILMOV1_PLODP4(wr_ePEODP_PLODP4,
                                                  wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnActILMOV1_PLODP4")
            Throw ex
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActIEMOV_ILMOV1(ByVal wr_ePLODP4 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oAccDat.cdActIEMOV_ILMOV1(wr_ePLODP4,
                                                 wr_bEOF)
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnCrearActualizarILMOV1")

        End Try
        Return wl_YesNo
    End Function


    Public Function cndtConsultar(ByVal vp_sCodDoc As String,
                                  ByVal vp_nNroDoc As Double,
                                  ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConsultar(vp_sCodDoc,
                                            vp_nNroDoc,
                                            wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConsultar")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActualizar(ByVal wp_sNomTbl As String,
                                      ByVal wr_eGEMOV As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wp_sNomTbl,
                                                 wr_eGEMOV,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtConsultarILMOV1(ByVal wp_sNomTbl As String,
                                        ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Integer,
                                        ByVal vp_sCodItm As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConsultarILMOV1(wp_sNomTbl,
                                                vp_sCodDoc,
                                                vp_nNroDoc,
                                                vp_sCodItm,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConsultarILMOV1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConSolILMOV1(ByVal wp_sNomTbl As String,
                                     ByVal vp_sCodDoc As String,
                                     ByVal vp_nNroDoc As Integer,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConSolILMOV1(wp_sNomTbl,
                                             vp_sCodDoc,
                                             vp_nNroDoc,
                                             wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConSolILMOV1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearActILMOV1(ByVal wp_sNomTbl As String,
                                            ByVal wr_eGEMOV1 As Object,
                                            ByVal wp_sCmdSel As String,
                                            ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False

            wl_YesNo = oAccDat.cdCrearActILMOV1(wp_sNomTbl,
                                                       wr_eGEMOV1,
                                                       wp_sCmdSel,
                                                       wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnCrearActualizarILMOV1")
            '  Throw ex
            '  MsgBox(ex.Message)
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliminar(ByVal wp_sNomtblE As String,
                               ByVal wp_sNomtblL As String,
                               ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByRef wr_bEOF As Boolean) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(wp_sNomtblE,
                                          wp_sNomtblE,
                                          vp_sCodDoc,
                                          vp_nNroDoc,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnEliminarILMOV1(ByVal wp_sNomtbl As String,
                                     ByVal vp_nNroReg As Integer,
                                     ByVal vp_sCodDoc As String,
                                     ByVal vp_nNroDoc As Double,
                                     ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarILMOV1(wp_sNomtbl,
                                                vp_nNroReg,
                                                vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnEliminarILMOV1")
            '  Throw ex
            'Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo

    End Function
    Public Function cndtCargarGEMOV(ByVal vp_sNomTbl As String,
                                    ByRef wr_bEOF As Boolean) As DataTable
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
    Public Function cndtCargarGELMOV1(ByVal wp_sNomTblE As String,
                                      ByVal wp_sNomTblL As String,
                                      ByVal wp_eGELMOV1 As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable

        Try

            wl_DT = oAccDat.cddtCargarGELMOV1(wp_sNomTblE,
                                              wp_sNomTblL,
                                              wp_eGELMOV1,
                                              wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox("Error : clnCEODC.cndtCargarGELMOV1")
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function cndtConGEINV(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByVal wp_sTipCmp As String,
                                 ByVal wp_sNomCmp1 As String,
                                 ByVal wp_sDatCmp1 As String,
                                 ByVal wp_sTipCmp1 As String,
                                 ByVal wp_sCmpOrd As String,
                                 ByVal wp_sTipOrd As String,
                                 ByVal wp_sCmpOrd1 As String,
                                 ByVal wp_sTipOrd1 As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV
            wl_DT = oAccDat.cddtConGEINV(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_sTipCmp,
                                         wp_sNomCmp1,
                                         wp_sDatCmp1,
                                         wp_sTipCmp1,
                                         wp_sCmpOrd,
                                         wp_sTipOrd,
                                         wp_sCmpOrd1,
                                         wp_sTipOrd1,
                                         wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConGEMOV(ByVal wp_sNomTbl As String,
                                 ByVal wp_eGEMOV As Object,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

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
    Public Function cndtConGEMOV_Grl(ByVal wp_sNomTbl As String,
                                     ByVal wp_eGEMOV As Object,
                                     ByVal wp_sMayMenIgu As String,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGEMOV_Grl(wp_sNomTbl,
                                             wp_eGEMOV,
                                             wp_sMayMenIgu,
                                             wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConGEMOV_QIniFin(ByVal wp_sNomTbl As String,
                                         ByVal wp_eGEMOV_Ini As Object,
                                         ByVal wp_eGEMOV_Fin As Object,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGEMOV_QIniFin(wp_sNomTbl,
                                                 wp_eGEMOV_Ini,
                                                 wp_eGEMOV_Fin,
                                                 wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConGEMOV_QIniFin")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConGLINV1(ByVal wp_sNomTbl As String,
                                  ByVal wp_sNomCmp As String,
                                  ByVal wp_sDatCmp As String,
                                  ByVal wp_sTipCmp As String,
                                  ByVal wp_sNomCmp1 As String,
                                  ByVal wp_sDatCmp1 As String,
                                  ByVal wp_sTipCmp1 As String,
                                  ByVal wp_sCmpOrd As String,
                                  ByVal wp_sTipOrd As String,
                                  ByVal wp_sCmpOrd1 As String,
                                  ByVal wp_sTipOrd1 As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGLINV1(wp_sNomTbl,
                                          wp_sNomCmp,
                                          wp_sDatCmp,
                                          wp_sTipCmp,
                                          wp_sNomCmp1,
                                          wp_sDatCmp1,
                                          wp_sTipCmp1,
                                          wp_sCmpOrd,
                                          wp_sTipOrd,
                                          wp_sCmpOrd1,
                                          wp_sTipOrd1,
                                          wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : cldConTbl.cNdtConGLINV1")
            Return Nothing
            Throw ex
            Return Nothing
        End Try

    End Function
    Public Function cndtConGLMOV1(ByVal wp_eGLMOV1 As Object,
                                  ByVal wp_sNomTbl As String,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGLMOV1(wp_eGLMOV1,
                                          wp_sNomTbl,
                                          wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConGELMOV1(ByVal wp_sNomTblE As String,
                                   ByVal wp_sNomTblL As String,
                                   ByVal wp_sCodDoc As String,
                                   ByVal wp_sCodSerI As String,
                                   ByVal wp_sCodSerF As String,
                                   ByVal wp_nNroDocI As Long,
                                   ByVal wp_nNroDocF As Long,
                                   ByVal wp_sEstDoc As String,
                                   ByVal wp_dFecDocI As String,
                                   ByVal wp_dFecDocF As String,
                                   ByVal wp_sCodVen As String,
                                   ByVal wp_sCodTerI As String,
                                   ByVal wp_sCodTerF As String,
                                   ByVal wp_sCodItmI As String,
                                   ByVal wp_sCodItmF As String,
                                   ByVal wp_sCodDocBas As String,
                                   ByVal wp_nNroDocBas As Long,
                                   ByRef wr_bEOF As Boolean) As DataTable

        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGELMOV1(wp_sNomTblE,
                                           wp_sNomTblL,
                                           wp_sCodDoc,
                                           wp_sCodSerI,
                                           wp_sCodSerF,
                                           wp_nNroDocI,
                                           wp_nNroDocF,
                                           wp_sEstDoc,
                                           wp_dFecDocI,
                                           wp_dFecDocF,
                                           wp_sCodVen,
                                           wp_sCodTerI,
                                           wp_sCodTerF,
                                           wp_sCodItmI,
                                           wp_sCodItmF,
                                           wp_sCodDocBas,
                                           wp_nNroDocBas,
                                           wr_bEOF)
            Return wl_DT



        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConGELMOV1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConGELMOV1_QGrl(ByVal wp_sNomTbl As String,
                                        ByVal wp_eGELMOV1 As Object,
                                        ByVal wp_sMayMenIgu As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGELMOV1_QGrl(wp_sNomTbl,
                                                wp_eGELMOV1,
                                                wp_sMayMenIgu,
                                                wr_bEOF)



            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConGELMOV1_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConGELMOV1_QIniFin(ByVal wp_sNomTbl As String,
                                           ByVal wp_eGELMOV1_Ini As Object,
                                           ByVal wp_eGELMOV1_Fin As Object,
                                           ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConGELMOV1_QIniFin(wp_sNomTbl,
                                                   wp_eGELMOV1_Ini,
                                                   wp_eGELMOV1_Fin,
                                                   wr_bEOF)



            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConGELMOV1_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
#Region "KARDEX"
    Public Function cndtConKARDEX_QGrl(ByVal wp_eKARDEX As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConKARDEX_QGrl(wp_eKARDEX,
                                                wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConKARDEX_QGrl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConSdoAntKARDEX(ByVal wp_eKARDEX As Object,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConSdoAntKARDEX(wp_eKARDEX,
                                                wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConSdoAntKARDEX")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConKARDEX_QIniFin(ByVal wp_eKARDEX As Object,
                                          ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConKARDEX_QIniFin(wp_eKARDEX,
                                                  wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConKARDEX_QIniFin")
            Return Nothing
            Throw ex
        End Try
    End Function
#End Region
#Region "IEREV"
    Public Function cnCrearActIEREV(ByVal wp_eIEREV As Object,
                                    ByVal wp_sCmdSel As String,
                                    ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActIEREV(wp_eIEREV,
                                               wp_sCmdSel,
                                               wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnCrearActIEREV")
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActILREV1(ByVal wp_eILREV1 As Object,
                                     ByVal wp_sCmdSel As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActILREV1(wp_eILREV1,
                                                wp_sCmdSel,
                                                wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnCrearActILREV1")
        End Try
        Return wl_YesNo
    End Function

    Public Function cndtConIEREV(ByVal wp_eIEREV As Object,
                                ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConIEREV(wp_eIEREV,
                                          wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cddtConIEREV")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConILREV1(ByVal wp_eILREV1 As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldIEINV

            wl_DT = oAccDat.cddtConILREV1(wp_eILREV1,
                                          wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnIEINV.cndtConILREV1")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cnEliILREV1(ByVal vp_nNroReg As Integer,
                                ByVal vp_sCodDoc As String,
                                ByVal vp_nNroDoc As Double,
                                ByVal wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliILREV1(vp_nNroReg,
                                          vp_sCodDoc,
                                          vp_nNroDoc,
                                          wr_bEOF)

        Catch ex As Exception
            MsgBox("Error : clnIEINV.cnEliminarILMOV1")
            '  Throw ex
            'Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo

    End Function
#End Region


End Class
