Imports System.Data
Imports System.Data.OleDb

Imports ClaseDatos

Public Class clnTEDMT
    Dim oAccDat As New ClaseDatos.cldTEDMT()
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Public Function cnCrearActualizar(ByVal wr_eTEDMT As Object,
                                      ByRef wr_bEOF As Boolean,
                                      ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizar(wr_eTEDMT,
                                                 wr_bEOF,
                                                 wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnTEDMT.cnCrearActualizar")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarTLDMT1(ByVal wr_eTLDMT1 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarTLDMT1(wr_eTLDMT1,
                                                       wr_bEOF,
                                                       wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnTEDMT.cnCrearActualizarTLDMT1")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarTLDMT2(ByVal wr_eTLDMT2 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarTLDMT2(wr_eTLDMT2,
                                                       wr_bEOF,
                                                       wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnTEDMT.cnCrearActualizarTLDMT2")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarTLDMT3(ByVal wr_eTLDMT3 As Object,
                                            ByRef wr_bEOF As Boolean,
                                            ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarTLDMT3(wr_eTLDMT3,
                                                       wr_bEOF,
                                                       wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnTEDMT.cnCrearActualizarTLDMT3")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActualizarTLDMT4(ByVal wr_eTLDMT4 As Object,
                                           ByRef wr_bEOF As Boolean,
                                           ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActualizarTLDMT4(wr_eTLDMT4,
                                                       wr_bEOF,
                                                       wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnTEDMT.cnCrearActualizarTLDMT4")
        End Try
        Return wl_YesNo

    End Function


    Public Function cndtConTEDMT(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable


        Try
            wl_DT = oAccDat.cddtConTEDMT(wp_sNomTbl,
                                          wp_sNomCmp,
                                          wp_sDatCmp,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            MsgBox("Error : clnTEDMT.cndtConTEDMT")
            Return Nothing
        End Try
    End Function

    Public Function cnEliminar(ByRef vp_sCodItm As String,
                       ByVal wr_bEOF As String) As Boolean


        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(vp_sCodItm,
                                 wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnTEDMT.cnEliminar")
        End Try
        Return wl_YesNo

    End Function
End Class
