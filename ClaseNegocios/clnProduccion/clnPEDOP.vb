Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnPEDOP
    Dim oAccDat As New ClaseDatos.cldPELIM()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(
                   ByVal vp_sCodItm As String,
                   ByVal vp_nCanUniPro As Double,
                   ByVal vp_sUniMedPro As String,
                   ByVal vp_sTipLIM As String,
                   ByVal vp_sCodAlm As String,
                   ByVal vp_nPesItm As Double,
                   ByVal vp_nPorItm As Double,
                   ByRef wr_bEOF As Boolean,
                   ByVal wp_sCmdSel As String) As Boolean
        Try

            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(
                                            vp_sCodItm,
                                            vp_nCanUniPro,
                                            vp_sUniMedPro,
                                            vp_sTipLIM,
                                            vp_sCodAlm,
                                            vp_nPesItm,
                                            vp_nPorItm,
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
    Public Function cnCrearActualizarPLLIM1(ByVal vp_nId As Integer,
                                            ByVal vp_sCodItm As String,
                                            ByVal vp_sCodCmt As String,
                                            ByVal vp_nCanCmt As Double,
                                            ByVal vp_nPesCmt As Double,
                                            ByVal vp_nPorCmt As Double,
                                            ByVal vp_sCodAlmCns As String,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM1(vp_nId,
                                                      vp_sCodItm,
                                                      vp_sCodCmt,
                                                      vp_nCanCmt,
                                                      vp_nPesCmt,
                                                      vp_nPorCmt,
                                                      vp_sCodAlmCns,
                                                      wr_bEOF,
                                                      wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarILMDI1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLLIM2(ByVal vp_nId As Integer,
                                            ByVal vp_sCodItm As String,
                                            ByVal vp_sCodOpe As String,
                                            ByVal vp_nTieOpe As Double,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM2(vp_nId,
                                                      vp_sCodItm,
                                                      vp_sCodOpe,
                                                      vp_nTieOpe,
                                                      wr_bEOF,
                                                      wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarILMDI1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function

    Public Function cnCrearActualizarPLLIM3(ByVal vp_nId As Integer,
                                            ByVal vp_sCodItm As String,
                                            ByVal vp_sCodCIF As String,
                                            ByVal vp_nVlrCIF As Double,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLLIM3(vp_nId,
                                                      vp_sCodItm,
                                                      vp_sCodCIF,
                                                      vp_nVlrCIF,
                                                      wr_bEOF,
                                                      wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnCrearActualizarILMDI1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function

    Public Function cndtConsultarPELIM(ByVal vp_sCodItm As String,
                                          ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPELIM(vp_sCodItm, wr_bEOF)
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
    Public Function cnEliminarPLLIM1(ByVal vp_sCodItm As String,
                                     ByVal vp_sCodCmt As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM1(vp_sCodItm,
                                              vp_sCodCmt,
                                              wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLLIM2(ByVal vp_sCodItm As String,
                                     ByVal vp_sCodOpe As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM1(vp_sCodItm,
                                              vp_sCodOpe,
                                              wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM2")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLLIM3(ByVal vp_sCodItm As String,
                                     ByVal vp_sCodCIF As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLLIM1(vp_sCodItm,
                                                vp_sCodCIF,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnIEDMI.cnEliminarPLLIM3")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
End Class
