Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos

Public Class clnPELIM
    Dim oAccDat As New ClaseDatos.cldPELIM()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnActPLLIM2nPreUni(ByVal wr_eATCTR As Object,
                                       ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = oAccDat.cdActPLLIM2nPreUni(wr_eATCTR,
                                                  wr_bEOF)

        Catch ex As Exception
            MsgBox("Error: clnPELIM.cnActPLLIM2nPreUni")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActPLLIM3nVlrCIFRea(ByVal wr_eATCIF As Object,
                                          ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = oAccDat.cdActPLLIM3nVlrCIFRea(wr_eATCIF,
                                                      wr_bEOF)

        Catch ex As Exception
            MsgBox("Error: clnPELIM.cnActPLLIM2nPreUni")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizar(ByVal vp_ePELIM As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(vp_ePELIM,
                                                 wr_bEOF,
                                                 wp_sCmdSel)


        Catch ex As Exception
            MsgBox("Error: clnPELIM.cnCrearActualizar")
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
            MsgBox("Error: clnPELIM.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarPLLIM1(ByVal wp_ePLLIM1 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM1(wp_ePLLIM1,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarPLLIM1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLLIM2(ByVal wp_ePLLIM2 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM2(wp_ePLLIM2,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarPLLIM2")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLLIM3(ByVal wp_ePLLIM3 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM3(wp_ePLLIM3,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarPLLIM3")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLLIM4(ByVal wp_ePLLIM4 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM4(wp_ePLLIM4,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarPLLIM4")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConCmtPLLIM1(ByVal wp_sPLLIM1 As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConCmtPLLIM1(wp_sPLLIM1,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConCmtPLLIM1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConCmtPLLIM4(ByVal wp_sPLLIM1 As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConCmtPLLIM4(wp_sPLLIM1,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConCmtPLLIM4")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPELIM(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPELIM(vp_sCodItm,
                                               wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConsultarPELIM")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLLIM1(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLLIM1(vp_sCodItm, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConsultarPLLIM1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLLIM2(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLLIM2(vp_sCodItm, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConsultarPLLIM2")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLLIM3(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLLIM3(vp_sCodItm, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConsultarPLLIM3")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLLIM4(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLLIM4(vp_sCodItm, wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cndtConsultarPLLIM4")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cnEliminarPLLIM1(ByVal wp_ePLLIM1 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM1(wp_ePLLIM1,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLLIM2(ByVal wp_ePLLIM2 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM2(wp_ePLLIM2,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM2")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLLIM3(ByVal wp_ePLLIM3 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM3(wp_ePLLIM3,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM3")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLLIM4(ByVal wp_ePLLIM4 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM4(wp_ePLLIM4,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM4")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
End Class

