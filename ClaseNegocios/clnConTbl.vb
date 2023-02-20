Imports System.Data
Imports ClaseDatos
Public Class clnConTbl
    Dim wl_DT As New DataTable
    Dim oAccDat As New ClaseDatos.cldConTbl

    Public Function cndtCargarLista(ByVal vp_sNomTbl,
                                    ByRef wr_bEOF) As DataTable


        Try
            wl_DT = oAccDat.cddtCargarLista(vp_sNomTbl,
                                            wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtCargarNro(ByVal vp_sNomTbl,
                                  ByVal vp_sCodDoc,
                                  ByRef wr_bEOF) As DataTable


        Try
            wl_DT = oAccDat.cddtCargarNro(vp_sNomTbl,
                                          vp_sCodDoc,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtSelSer(ByVal vp_sNomTbl,
                               ByVal vp_sCodDoc,
                               ByVal vp_sCodSer,
                               ByRef wr_bEOF) As DataTable


        Try
            wl_DT = oAccDat.cddtSelSer(vp_sNomTbl,
                                       vp_sCodDoc,
                                       vp_sCodSer,
                                       wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtLst2Cmp(ByVal wp_sNomTbl,
                                ByVal wp_sNomCmp1,
                                ByVal wp_sNomCmp2,
                                ByRef wr_bEOF) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try

            wl_DT = oAccDat.cddtLst2Cmp(wp_sNomTbl,
                                        wp_sNomCmp1,
                                        wp_sNomCmp2,
                                        wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            MsgBox("Error en: cddtBuscar ")
            Throw ex
        End Try
    End Function
    Public Function cndtPrimero(ByVal wp_sNomTbl As String,
                                ByVal wp_sNomCmp As String,
                                ByVal wp_sDatCmp As String,
                                ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtPrimero(wp_sNomTbl,
                                        wp_sNomCmp,
                                        wp_sDatCmp,
                                        wr_bEOF)

            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtAnterior(ByVal wp_sNomTbl,
                                 ByVal wp_sNomCmp,
                                 ByVal wp_sDatCmp,
                                 ByVal wp_sTipCmp,
                                 ByRef wr_bEOF) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtAnterior(wp_sNomTbl,
                                         wp_sNomCmp,
                                         wp_sDatCmp,
                                         wp_sTipCmp,
                                         wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtSiguiente(ByVal wp_sNomTbl,
                                  ByVal wp_sNomCmp,
                                  ByVal wp_sDatCmp,
                                  ByVal wp_sTipCmp,
                                  ByRef wr_bEOF) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtSiguiente(wp_sNomTbl,
                                          wp_sNomCmp,
                                          wp_sDatCmp,
                                          wp_sTipCmp,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtUltimo(ByVal wp_sNomTbl,
                               ByVal wp_sNomCmp,
                               ByVal wp_sDatCmp,
                               ByRef wr_bEOF) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtUltimo(wp_sNomTbl,
                                       wp_sNomCmp,
                                       wp_sDatCmp,
                                       wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtPrimeroMov(ByVal wp_sNomTbl As String,
                                   ByVal wp_sNomCmp As String,
                                   ByVal wp_sDatCmp As String,
                                   ByVal wp_sTipCmp As String,
                                   ByVal wp_sNomCmp1 As String,
                                   ByVal wp_sDatCmp1 As String,
                                   ByVal wp_sTipCmp1 As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtPrimeroMov(wp_sNomTbl,
                                           wp_sNomCmp,
                                           wp_sDatCmp,
                                           wp_sTipCmp,
                                           wp_sNomCmp1,
                                           wp_sDatCmp1,
                                           wp_sTipCmp1,
                                           wr_bEOF)

            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtAnteriorMov(ByVal wp_sNomTbl As String,
                                   ByVal wp_sNomCmp As String,
                                   ByVal wp_sDatCmp As String,
                                   ByVal wp_sTipCmp As String,
                                   ByVal wp_sNomCmp1 As String,
                                   ByVal wp_sDatCmp1 As String,
                                   ByVal wp_sTipCmp1 As String,
                                   ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtAnteriorMov(wp_sNomTbl,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wp_sNomCmp1,
                                            wp_sDatCmp1,
                                            wp_sTipCmp1,
                                            wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtSiguienteMov(ByVal wp_sNomTbl As String,
                                   ByVal wp_sNomCmp As String,
                                   ByVal wp_sDatCmp As String,
                                   ByVal wp_sTipCmp As String,
                                   ByVal wp_sNomCmp1 As String,
                                   ByVal wp_sDatCmp1 As String,
                                   ByVal wp_sTipCmp1 As String,
                                   ByRef wr_bEOF As Boolean) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtSiguienteMov(wp_sNomTbl,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wp_sNomCmp1,
                                            wp_sDatCmp1,
                                            wp_sTipCmp1,
                                            wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtUltimoMov(ByVal wp_sNomTbl As String,
                                   ByVal wp_sNomCmp As String,
                                   ByVal wp_sDatCmp As String,
                                   ByVal wp_sTipCmp As String,
                                   ByVal wp_sNomCmp1 As String,
                                   ByVal wp_sDatCmp1 As String,
                                   ByVal wp_sTipCmp1 As String,
                                   ByRef wr_bEOF As Boolean) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtUltimoMov(wp_sNomTbl,
                                          wp_sNomCmp,
                                          wp_sDatCmp,
                                          wp_sTipCmp,
                                          wp_sNomCmp1,
                                          wp_sDatCmp1,
                                          wp_sTipCmp1,
                                          wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtBuscar(ByVal wp_sNomTbl As String,
                               ByVal wp_sNomCmp As String,
                               ByVal wp_sDatCmp As String,
                               ByVal wp_sTipCmp As String,
                               ByVal wp_sCmpOrd As String,
                               ByVal wp_sTipOrd As String,
                               ByRef wr_bEOF As Boolean) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtBuscar(wp_sNomTbl,
                                       wp_sNomCmp,
                                       wp_sDatCmp,
                                       wp_sTipCmp,
                                       wp_sCmpOrd,
                                       wp_sTipOrd,
                                       wr_bEOF)


            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtBuscarE2(ByVal wp_sNomTbl As String,
                                 ByVal wp_sNomCmp As String,
                                 ByVal wp_sDatCmp As String,
                                 ByVal wp_sTipCmp As String,
                                 ByVal wp_sNomCmp1 As String,
                                 ByVal wp_sDatCmp1 As String,
                                 ByVal wp_sTipCmp1 As String,
                                 ByRef wr_bEOF As Boolean) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtBuscarE2(wp_sNomTbl,
                                        wp_sNomCmp,
                                        wp_sDatCmp,
                                        wp_sTipCmp,
                                        wp_sNomCmp1,
                                        wp_sDatCmp1,
                                        wp_sTipCmp1,
                                        wr_bEOF)

            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtCon1Lla2Tbl(ByVal wp_sNomTbl As String,
                                    ByVal wp_sNomCmp As String,
                                    ByVal wp_sDatCmp As String,
                                    ByVal wp_sTipCmp As String,
                                    ByVal wp_sNomTbl1 As String,
                                    ByVal wp_sNomSel As String,
                                    ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtCon1Lla2Tbl(wp_sNomTbl,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wp_sNomTbl1,
                                            wp_sNomSel,
                                            wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnConTbl.cndtCon1Lla2Tbl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtCon1Lla1Cmp2Tbl(ByVal wp_sNomTbl As String,
                                        ByVal wp_sNomCmp As String,
                                        ByVal wp_sDatCmp As String,
                                        ByVal wp_sTipCmp As String,
                                        ByVal wp_sNomCmp1 As String,
                                        ByVal wp_sDatCmp1 As String,
                                        ByVal wp_sTipCmp1 As String,
                                        ByVal wp_sNomTbl1 As String,
                                        ByVal wp_sNomSel As String,
                                        ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtCon1Lla1Cmp2Tbl(wp_sNomTbl,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wp_sNomCmp1,
                                            wp_sDatCmp1,
                                            wp_sTipCmp1,
                                            wp_sNomTbl1,
                                            wp_sNomSel,
                                            wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnConTbl.cndtCon1Lla2Tbl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtCon2Lla2Tbl(ByVal wp_sNomTbl As String,
                                    ByVal wp_sNomCmp As String,
                                    ByVal wp_sDatCmp As String,
                                    ByVal wp_sTipCmp As String,
                                    ByVal wp_sNomCmp1 As String,
                                    ByVal wp_sDatCmp1 As String,
                                    ByVal wp_sTipCmp1 As String,
                                    ByVal wp_sNomTbl1 As String,
                                    ByVal wp_sNomSel As String,
                                    ByRef wr_bEOF As Boolean) As DataTable
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtCon2Lla2Tbl(wp_sNomTbl,
                                            wp_sNomCmp,
                                            wp_sDatCmp,
                                            wp_sTipCmp,
                                            wp_sNomCmp1,
                                            wp_sDatCmp1,
                                            wp_sTipCmp1,
                                            wp_sNomTbl1,
                                            wp_sNomSel,
                                            wr_bEOF)
            Return wl_DT
        Catch ex As Exception
            MsgBox("Error : clnConTbl.cndtCon1Lla2Tbl")
            Return Nothing
            Throw ex
        End Try
    End Function
    Public Function cndtConEOF(ByVal wp_sNomTbl As String,
                            ByVal wp_sNomCmp As String,
                            ByVal wp_sDatCmp As String,
                            ByVal wp_sTipCmp As String,
                                   ByVal wp_sCmpOrd As String,
                                   ByVal wp_sTipOrd As String,
                                   ByRef wr_bEOF As Boolean) As Boolean

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Dim wl_bEOF1 As Boolean
        Try
            wl_bEOF1 = oAccDat.cddtConEOF(wp_sNomTbl,
                                        wp_sNomCmp,
                                        wp_sDatCmp,
                                        wp_sTipCmp,
                                        wp_sCmpOrd,
                                        wp_sTipOrd,
                                        wr_bEOF)


            Return wl_bEOF1

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConEOF1Tbl2Cmp(ByVal wp_sNomTbl As String,
                                       ByVal wp_sNomCmp As String,
                                       ByVal wp_sDatCmp As String,
                                       ByVal wp_sTipCmp As String,
                                       ByVal wp_sNomCmp1 As String,
                                       ByVal wp_sDatCmp1 As String,
                                       ByVal wp_sTipCmp1 As String,
                                       ByRef wr_bEOF As Boolean) As Boolean
        ' Consulta 1 tabla y 2 campos.
        ' Fec_Ult_Act : 2015.08.04
        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Dim wl_bEOF1 As Boolean
        Try
            wl_bEOF1 = oAccDat.cddtConEOF1Tbl2Cmp(wp_sNomTbl,
                                                  wp_sNomCmp,
                                                  wp_sDatCmp,
                                                  wp_sTipCmp,
                                                  wp_sNomCmp1,
                                                  wp_sDatCmp1,
                                                  wp_sTipCmp1,
                                                  wr_bEOF)
            Return wl_bEOF1
        Catch ex As Exception
            MsgBox("Error en: cldConTbl.cndtConEOF1Tbl2Cmp ")
            Return Nothing
        End Try
    End Function


    Public Function cndtAPDGV(ByVal wp_sNomTbl As String,
                              ByVal wp_sNomCmp As String,
                              ByVal wp_sDatCmp As String,
                              ByVal wp_sTipCmp As String,
                              ByVal wp_sNomCmp1 As String,
                              ByVal wp_sDatCmp1 As String,
                              ByVal wp_sTipCmp1 As String,
                              ByVal wp_sCmpOrd As String,
                              ByRef wr_bEOF As Boolean) As DataTable

        Dim wl_DT As New DataTable
        Dim oAccDat As New ClaseDatos.cldConTbl
        Try
            wl_DT = oAccDat.cddtAPDGV(wp_sNomTbl,
                                      wp_sNomCmp,
                                      wp_sDatCmp,
                                      wp_sTipCmp,
                                      wp_sNomCmp1,
                                      wp_sDatCmp1,
                                      wp_sTipCmp1,
                                      wp_sCmpOrd,
                                      wr_bEOF)

            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function cndtConATIVA(ByVal wp_sDatCmp As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldConTbl

            wl_DT = oAccDat.cddtConATIVA(wp_sDatCmp,
                                         wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function cndtConABEPC(ByVal wp_sCodPco As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldConTbl

            wl_DT = oAccDat.cddtConABEPC(wp_sCodPco,
                                         wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function cndtConABOPC(ByVal wp_sCodOpc As String,
                                 ByRef wr_bEOF As Boolean) As DataTable
        Try
            Dim wl_DT As New DataTable
            Dim oAccDat As New ClaseDatos.cldConTbl

            wl_DT = oAccDat.cddtConABOPC(wp_sCodOpc,
                                         wr_bEOF)

            Return wl_DT
        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function ANT_cndtConILDMI2(ByVal vp_sNomTbl,
                                  ByVal wg_sDatCon11,
                                  ByRef wr_bEOF) As DataTable


        Try
            '   wl_DT = oAccDat.cddtConILDMI2(vp_sNomTbl,
            '                                wg_sDatCon11,
            '                               wr_bEOF)
            Return wl_DT

        Catch ex As Exception
            'Throw ex
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
