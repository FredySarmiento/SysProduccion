Imports System.Data
Imports System.Data.OleDb
Imports ClaseDatos
Public Class clnPEROP
    Dim wl_DT As New DataTable
    Dim wl_YesNo As Boolean
    Dim wl_nIdEnc As Long
    Dim oAccDat As New ClaseDatos.cldPEROP
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
            MsgBox("Error : clnPEROP.cndtConsultar")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConsultarPLROP1(ByVal wp_sNomTbl As String,
                                        ByVal vp_sCodDoc As String,
                                        ByVal vp_nNroDoc As Double,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConsultarPLROP1(wp_sNomTbl,
                                                vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cndtConsultarPLROP1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPELROP_Grl(ByVal wp_ePEROP As Object,
                                      ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldPEROP

            wl_DT = oAccDat.cddtConPLEROP_Grl(wp_ePEROP,
                                              wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cndtConPELROP_Grl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConPEROP_Grl(ByVal wp_sNomTbl As String,
                                      ByVal wp_ePEROP As Object,
                                      ByVal wp_sMayMenIgu As String,
                                      ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldPEROP
            wl_DT = oAccDat.cddtConPEROP_Grl(wp_sNomTbl,
                                             wp_ePEROP,
                                             wp_sMayMenIgu,
                                             wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cndtConPEROP_Grl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConPEROP_QIniFin(ByVal wp_sNomTbl As String,
                                         ByVal wp_ePEROP_Ini As Object,
                                         ByVal wp_ePEROP_Fin As Object,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldPEROP

            wl_DT = oAccDat.cddtConPEROP_QIniFin(wp_sNomTbl,
                                                 wp_ePEROP_Ini,
                                                 wp_ePEROP_Fin,
                                                 wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cndtConPEROP_QIniFin")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConPLROP1_DocBas(ByVal wp_sNomTbl As String,
                                         ByVal vp_sCodDoc As String,
                                         ByVal vp_nNroDoc As Double,
                                         ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConPLROP1_DocBas(wp_sNomTbl,
                                                vp_sCodDoc,
                                                vp_nNroDoc,
                                                wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cndtConPLROP1_DocBas")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConGLROP1(ByVal wp_sNomCmp As String,
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
            wl_DT = oAccDat.cddtConGLROP1(wp_sNomCmp,
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
            MsgBox("Error : clnPEROP.cndtConGLROP1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConPLROP1(ByVal wp_ePLROP1 As Object,
                                  ByRef wr_bEOF As Boolean) As DataTable
        Try
            wl_DT = oAccDat.cddtConPLROP1(wp_ePLROP1,
                                                 wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cndtConPLROP1")
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Function cnCrearAct(ByVal wp_ePEROP As Object,
    '                           ByRef wr_bEOF As Boolean,
    '                           ByVal wp_sCmdSel As String) As Boolean

    Public Function cnCrearAct(ByVal wp_ePEROP As Object,
                               ByRef wr_nIdEnc As Long,
                               ByVal wp_sCmdSel As String) As Long

        Try
            wl_YesNo = False
            'wl_YesNo = oAccDat.cdCrearAct(wp_ePEROP,
            '                              wr_nIdEnc,
            '                              wp_sCmdSel)
            wl_nIdEnc = 0
            wl_nIdEnc = oAccDat.cdCrearAct(wp_ePEROP,
                                          wr_nIdEnc,
                                          wp_sCmdSel)
        Catch ex As Exception
            MsgBox("Error : clnPEROP.cnCrearAct")
        End Try
        Return wl_nIdEnc

    End Function
    Public Function cnCrearActPLROP1(ByVal wl_ePLROP1 As Object,
                                     ByVal wr_bEOFL1 As Boolean,
                                     ByVal wp_sCmdSel As String) As Boolean
        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdCrearActPLROP1(wl_ePLROP1,
                                                wr_bEOFL1,
                                                wp_sCmdSel)

        Catch ex As Exception
            MsgBox("Error : clnPEROP.cnCrearActPLROP1")
        End Try
        Return wl_YesNo


    End Function
    Public Function cnEliminar(ByVal vp_sCodDoc As String,
                               ByVal vp_nNroDoc As Integer,
                               ByRef wr_bEOF As Boolean) As Boolean

        Try
            wl_YesNo = False
            wl_YesNo = oAccDat.cdEliminar(vp_sCodDoc,
                                          vp_nNroDoc,
                                          wr_bEOF)
        Catch ex As Exception
            MsgBox("Error: clnPEROP.cnEliminar")
        End Try
        Return wl_YesNo
    End Function
   
End Class
