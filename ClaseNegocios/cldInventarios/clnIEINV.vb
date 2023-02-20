Imports System.Data
Imports System.Data.OleDb

Imports ClaseDatos
Public Class clnIEINV
    Public Function cndtConsultar(ByVal vp_sCodDoc As String, _
                                  ByVal vp_nNroDoc As Double, _
                                  ByRef wp_bEOF As Boolean) As DataTable

        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEINV()
        Try
            vl_DT = objAccDat.cddtConsultar(vp_sCodDoc, _
                                            vp_nNroDoc, _
                                            wp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Sub cnCrearActualizar(ByVal vp_sCodDoc As String, _
                                 ByVal vp_nNroDoc As Double, _
                                 ByVal vp_sTipMov As String, _
                                 ByVal vp_fFecCtb As Date, _
                                 ByVal vp_fFecDoc As Date, _
                                 ByVal vp_sAlmOri As String, _
                                 ByVal vp_sCodTer As String, _
                                 ByVal vp_sDocRef As String, _
                                 ByVal vp_nTotDoc As Double, _
                                 ByRef wp_bEOF As Boolean, _
                                 ByVal wp_nNroOpc As Integer)
        Dim objAccDat As New ClaseDatos.cldIEINV()



        objAccDat.cdCrearActualizar(vp_sCodDoc, _
                                    vp_nNroDoc, _
                                    vp_sTipMov, _
                                    vp_fFecCtb, _
                                    vp_fFecDoc, _
                                    vp_sAlmOri, _
                                    vp_sCodTer, _
                                    vp_sDocRef, _
                                    vp_nTotDoc, _
                                    wp_bEOF, _
                                    wp_nNroOpc)
    End Sub
    Public Sub cnEliminar(ByRef vp_sCodCia As Integer,
                       ByVal wp_bEOF As String)
        Dim objAccDat As New ClaseDatos.cldACDEM()
        objAccDat.cdEliminar(vp_sCodCia, _
                                 wp_bEOF)


    End Sub
    Public Function cndtConsultarILMOV1(ByVal vp_sCodDoc As String, _
                                       ByVal vp_nNroDoc As Integer, _
                                       ByRef vp_bEOF As Boolean) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEINV()
        Try
            vl_DT = objAccDat.cddtConsultarILMOV1(vp_sCodDoc, _
                                                 vp_nNroDoc, _
                                                 vp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Sub cnCrearActualizarILMOV1(ByVal vp_nNroReg As Integer, _
                                       ByVal vp_sCodDoc As String, _
                                       ByVal vp_nNroDoc As Double, _
                                       ByVal vp_sTipMov As String, _
                                       ByVal vp_sCodItm As String, _
                                       ByVal vp_sDesItm As String, _
                                       ByVal vp_sCodalm As String, _
                                       ByVal vp_nCanItm As Double, _
                                       ByVal vp_sUniMedInv As String, _
                                       ByVal vp_nPreUni As Double, _
                                       ByVal vp_nVlrTot As Double, _
                                       ByVal vp_nSdoSto As Double, _
                                       ByVal vp_sCtaCtb As String, _
                                       ByVal vp_sOpc As String, _
                                       ByRef wp_bEOF As Boolean)

        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEINV()
        Try
            objAccDat.cdCrearActualizarILMOV1(vp_nNroReg, _
                                              vp_sCodDoc, _
                                              vp_nNroDoc, _
                                              vp_sTipMov, _
                                              vp_sCodItm, _
                                              vp_sDesItm, _
                                              vp_sCodalm, _
                                              vp_nCanItm, _
                                              vp_sUniMedInv, _
                                              vp_nPreUni, _
                                              vp_nVlrTot, _
                                              vp_nSdoSto, _
                                              vp_sCtaCtb, _
                                              vp_sOpc, _
                                              wp_bEOF)

        Catch ex As Exception

            Throw ex
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function cnEliminarILMOV1(ByVal vp_sCodItm As String, _
                                           ByVal vp_sCodalm As String, _
                                ByRef vp_bEOF As Boolean) As DataTable
        Dim vl_DT As New DataTable
        Dim objAccDat As New ClaseDatos.cldIEINV()
        Try
            vl_DT = objAccDat.cdEliminarIDMOV(vp_sCodItm, _
                                              vp_sCodalm, _
                                              vp_bEOF)
            Return vl_DT
        Catch ex As Exception
            Throw ex
            'MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
