Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnPERCI
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim oAccDat As New ClaseDatos.cldPERCI
    Private _cnCrearActualizar As Boolean
    Public Function cndtConsultar(ByVal vp_sCodDoc,
                                  ByVal vp_nNroDoc,
                                  ByRef wr_bEOF) As DataTable

        Try
            wl_DT = oAccDat.cddtConsultar(vp_sCodDoc,
                                          vp_nNroDoc,
                                          wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPERCI.cndtConsultar")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLRCI1(ByVal wp_sNomTbl As String,
                                        ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Double,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConsultarPLRCI1(wp_sNomTbl,
                                                vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPERCI.cndtConsultarPLRCI1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cnCrearAct(ByVal wp_ePERCI As Object,
                               ByRef wr_bEOF As Boolean,
                               ByVal wp_sCmdSel As String) As Boolean

        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearAct(wp_ePERCI,
                                          wr_bEOF,
                                          wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnPERCI.cnCrearAct")
        End Try
        Return wl_YesNo

    End Function
    Public Function cnCrearActPLRCI1(ByVal wl_ePLRCI1 As Object,
                                     ByVal wr_bEOFL1 As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActPLRCI1(wl_ePLRCI1,
                                                wr_bEOFL1,
                                                wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnPERCI.cnCrearActPLRCI1")
        End Try
        Return wl_YesNo


    End Function
    Public Function cnEliminar(ByVal wp_sNomTblE1 As String,
                               ByVal wp_sNomTblL1 As String,
                               ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByRef wr_bEOF As Boolean) As Boolean

        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(wp_sNomTblE1,
                                          wp_sNomTblL1,
                                          vp_sCodDoc,
                                          vp_nNroDoc,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPERCI.cnEliminar")
        End Try
        Return wl_YesNo
    End Function

End Class
