Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnPEFOM
    Dim oAccDat As New ClaseDatos.cldPEFOM
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnActPLFOM2nPreUni(ByVal wr_eATCTR As Object,
                                       ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = oAccDat.cdActPLFOM2nPreUni(wr_eATCTR,
                                                  wr_bEOF)

        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnActPLFOM2nPreUni")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnActPLFOM3nVlrCIFRea(ByVal wr_eATCIF As Object,
                                          ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = oAccDat.cdActPLFOM3nVlrCIFRea(wr_eATCIF,
                                                     wr_bEOF)

        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnActPLFOM3nVlrCIFRea")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizar(ByVal vp_ePEFOM As Object,
                                    ByRef wr_bEOF As Boolean,
                                    ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(vp_ePEFOM,
                                                 wr_bEOF,
                                                 wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnCrearActualizar")
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
            MsgBox("Error: clnPEFOM.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarPLFOM1(ByVal wp_ePLFOM1 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLFOM1(wp_ePLFOM1,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnCrearActualizarPLFOM1")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLFOM2(ByVal wp_ePLFOM2 As Object,
                                           ByVal wr_bEOF As Boolean,
                                           ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLFOM2(wp_ePLFOM2,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnCrearActualizarPLFOM2")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLFOM3(ByVal wp_ePLFOM3 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLFOM3(wp_ePLFOM3,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnCrearActualizarPLFOM3")
            'Throw ex
            MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cnCrearActualizarPLFOM5(ByVal wp_ePLFOM5 As Object,
                                            ByVal wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarPLFOM5(wp_ePLFOM5,
                                                       wr_bEOF,
                                                       wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnCrearActualizarPLFOM5")
            Throw ex
            'MsgBox(ex.Message)
        End Try
        Return wl_YesNo
    End Function
    Public Function cndtConAnaPLFOM5(ByVal wp_sPLFOM5 As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConAnaPLFOM5(wp_sPLFOM5,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConAnaPLFOM5")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConCmtPLFOM1(ByVal wp_sPLFOM1 As Object,
                                     ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConCmtPLFOM1(wp_sPLFOM1,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConCmtPLFOM1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPEFOM(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPEFOM(vp_sCodItm,
                                               wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConsultarPEFOM")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLFOM1(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLFOM1(vp_sCodItm,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConsultarPLFOM1")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLFOM2(ByVal vp_sCodItm As String,
                                    ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLFOM2(vp_sCodItm,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConsultarPLFOM2")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLFOM3(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLFOM3(vp_sCodItm,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConsultarPLFOM3")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLFOM5(ByVal vp_sCodItm As String,
                                       ByRef wr_bEOF As Boolean) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultarPLFOM5(vp_sCodItm,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cndtConsultarPLFOM5")
            ' Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnEliminarPLFOM1(ByVal wp_ePLFOM1 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLFOM1(wp_ePLFOM1,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnEliminarPLFOM1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLFOM2(ByVal vp_sCodItm As String,
                                       ByVal vp_sCodOpe As String,
                                       ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLFOM2(vp_sCodItm,
                                              vp_sCodOpe,
                                              wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnEliminarPLFOM2")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLFOM3(ByVal vp_sCodItm As String,
                                     ByVal vp_sCodCIF As String,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLFOM3(vp_sCodItm,
                                                vp_sCodCIF,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnEliminarPLFOM3")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
    Public Function cnEliminarPLFOM5(ByVal wp_ePLFOM5 As Object,
                                     ByRef wr_bEOF As Boolean) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminarPLFOM5(wp_ePLFOM5,
                                                wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEFOM.cnEliminarPLFOM5")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
        Return wl_YesNo
    End Function
End Class
